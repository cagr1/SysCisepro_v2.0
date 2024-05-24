Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_COBRAR
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmCuentasCobrarGeneralMin
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Get
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        Return 2
                    Case TipoConexion.Seportpac
                        Return 1
                    Case Else
                        Return 0
                End Select
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 2
                        _tipoCon = TipoConexion.Asenava
                    Case 1
                        _tipoCon = TipoConexion.Seportpac
                    Case Else
                        _tipoCon = TipoConexion.Cisepro
                End Select
            End Set
        End Property
        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        Dim objetoCuentasPorCobrar As New ClassCuentasPorCobrar
        Dim objetoClienteGeneral As New ClassClienteGeneral

        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""

        Private Sub ExportarDatosExcel(ByVal dgvCuentasPorPagar As DataGridView, ByVal titulo As String)
            Try
                If dgvCuentasPorPagar.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "CUENTAS_COBRAR"

                 Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvCuentasPorPagar)
                worksheet.Range("A1:" & ic & (dgvCuentasPorPagar.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  CUENTAS POR COBRAR " & If(rbPorCliente.Checked, txtNombreComercialClienteGeneral.Text.Trim(), String.Empty)
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpDesde.Value.ToLongDateString() & "  AL " & dtpHasta.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvCuentasPorPagar.Columns.Count - 1
                    If Not dgvCuentasPorPagar.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvCuentasPorPagar.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvCuentasPorPagar.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvCuentasPorPagar.Columns.Count - 1

                        If Not dgvCuentasPorPagar.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvCuentasPorPagar.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvCuentasPorPagar.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                Dim ct = 3
                Dim cv = 4

                ' TOTALES, ETC
                Dim foot = headin + dgvCuentasPorPagar.RowCount + 3

                worksheet.Cells(foot, ct).Value = "SALDO TOTAL DE CLIENTES"
                worksheet.Cells(foot, ct).Font.Bold = True
                worksheet.Cells(foot, cv).Value = txtTotalCuentasPorCobrar.Text
                 
                worksheet.Range("A1:" & ic & dgvCuentasPorPagar.RowCount + 50).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub cargarCuentasPorCobrarGeneral(ByVal all As Boolean, ByVal min As Boolean)
            Try

                Dim data = objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralPorRangoFecha(_tipoCon, fechaDesde, fechaHasta, all)
                'If Not data Is Nothing And min And data.Rows.Count > 0 Then ' 0 1 2 3 4 5 6 7 8
                '    data.Columns.RemoveAt(3) ' 0 1 2 4 5 6 7 8
                '    data.Columns.RemoveAt(3) ' 0 1 2 5 6 7 8
                '    data.Columns.RemoveAt(3) ' 0 1 2 6 7 8
                '    data.Columns.RemoveAt(3) ' 0 1 2 7 8
                '    data.Columns.RemoveAt(3) ' 0 1 2 8
                'End If
                dgvCuentasPorCobrar.DataSource = data
                dgvCuentasPorCobrar.AutoResizeColumns()

                dgvCuentasPorCobrar.Columns(0).HeaderText = "ID CLI."
                dgvCuentasPorCobrar.Columns(0).Width = 50

                dgvCuentasPorCobrar.Columns(1).HeaderText = "RUC / CI."
                dgvCuentasPorCobrar.Columns(1).Width = 90

                dgvCuentasPorCobrar.Columns(2).HeaderText = "RAZÓN SOCIAL (CLIENTE)"
                dgvCuentasPorCobrar.Columns(2).Width = 570

                dgvCuentasPorCobrar.Columns(3).Visible = False
                dgvCuentasPorCobrar.Columns(4).Visible = False
                dgvCuentasPorCobrar.Columns(5).Visible = False
                dgvCuentasPorCobrar.Columns(6).Visible = False
                dgvCuentasPorCobrar.Columns(7).Visible = False

                dgvCuentasPorCobrar.Columns(8).HeaderText = "SALDO"
                dgvCuentasPorCobrar.Columns(8).Width = 80
                dgvCuentasPorCobrar.Columns(8).DefaultCellStyle.Format = "n"

                dgvCuentasPorCobrar.ReadOnly = False

            Catch ex As Exception
                MsgBox("METODO CARGAR CUENTAS POR COBRAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Public Sub cargarCuentasPorCobrarPorCliente(ByVal all As Boolean, ByVal min As Boolean)
            If txtNombreComercialClienteGeneral.Text.Trim().Length = 0 Then Return

            Dim data = objetoCuentasPorCobrar.BuscarCuentasPorCobrarPorClientePorRangoFecha(_tipoCon, lblIdClienteGeneral.Text, fechaDesde, fechaHasta, all)
            'If Not data Is Nothing And min And data.Rows.Count > 0 Then ' 0 1 2 3 4 5 6 7 8 9
            '    data.Columns.RemoveAt(3) ' 0 1 2 4 5 6 7 8 9
            '    data.Columns.RemoveAt(3) ' 0 1 2 5 6 7 8 9
            '    data.Columns.RemoveAt(3) ' 0 1 2 6 7 8 9
            '    data.Columns.RemoveAt(3) ' 0 1 2 7 8 9
            '    data.Columns.RemoveAt(3) ' 0 1 2 8 9
            'End If
            dgvCuentasPorCobrar.DataSource = data
            dgvCuentasPorCobrar.AutoResizeColumns()

            dgvCuentasPorCobrar.Columns(0).HeaderText = "ID FAC."
            dgvCuentasPorCobrar.Columns(0).Width = 50

            dgvCuentasPorCobrar.Columns(1).HeaderText = "N° FAC."
            dgvCuentasPorCobrar.Columns(1).Width = 90

            dgvCuentasPorCobrar.Columns(2).HeaderText = "FECHA EMISIÓN"
            dgvCuentasPorCobrar.Columns(2).Width = 130

            dgvCuentasPorCobrar.Columns(3).Visible = False
            dgvCuentasPorCobrar.Columns(4).Visible = False
            dgvCuentasPorCobrar.Columns(5).Visible = False
            dgvCuentasPorCobrar.Columns(6).Visible = False
            dgvCuentasPorCobrar.Columns(7).Visible = False

            dgvCuentasPorCobrar.Columns(8).HeaderText = "SALDO"
            dgvCuentasPorCobrar.Columns(8).Width = 80
            dgvCuentasPorCobrar.Columns(8).DefaultCellStyle.Format = "n"

            dgvCuentasPorCobrar.Columns(9).HeaderText = "OBSERVACIONES"


            'cantidadRegistrosCuentasPorCobrar = CType(dgvCuentasPorCobrar.DataSource, DataTable).Rows.Count

            dgvCuentasPorCobrar.ReadOnly = False

        End Sub
        Public Sub totalCuentasPorCobrarGeneral()
            Try
                Dim totalCobrar As Decimal = 0

                If dgvCuentasPorCobrar.RowCount > 0 Then
                    For indice = 0 To dgvCuentasPorCobrar.RowCount - 1
                        totalCobrar += dgvCuentasPorCobrar.Rows(indice).Cells("saldo").Value

                        If dgvCuentasPorCobrar.Rows(indice).Cells("saldo").Value > 0 Then
                            dgvCuentasPorCobrar.Rows(indice).Cells("saldo").Style.BackColor = Color.IndianRed
                        End If
                    Next

                    txtTotalCuentasPorCobrar.Text = Math.Round(totalCobrar, 2)
                End If
            Catch ex As Exception
                MsgBox("METODO SUMAR TOTAL CUENTAS POR COBRAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Public Sub autocompletarNombreCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub
        Public Sub autocompletarConsorcioCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = objetoClienteGeneral.AutocompletarConsorcio(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub
        Public Sub cargarDatosCliente()
            Try
                dgvCliente.DataSource = objetoClienteGeneral.BuscarClienteGeneralXNombreComercial(_tipoCon, txtNombreComercialClienteGeneral.Text)

                If dgvCliente.RowCount > 0 Then
                    lblIdClienteGeneral.Text = dgvCliente.Rows(0).Cells(0).Value
                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub FrmCuentasCobrarGeneralMin_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    ChkTodos.ForeColor = Color.White
                    ChkTodos.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    ChkTodos.ForeColor = Color.White
                    ChkTodos.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    ChkTodos.ForeColor = Color.White
                    ChkTodos.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            rbGeneral.Checked = True
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargarSitios.Click
            txtTotalCuentasPorCobrar.Text = "0.00"
             
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

            dgvCuentasPorCobrar.DataSource = Nothing

            If rbGeneral.Checked Then
                cargarCuentasPorCobrarGeneral(ChkTodos.Checked, _tipoCon)
            Else
                cargarCuentasPorCobrarPorCliente(ChkTodos.Checked, _tipoCon)
            End If
            dgvCuentasPorCobrar.ReadOnly = True
            totalCuentasPorCobrarGeneral()
        End Sub
       
         
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarSitio.Click
            Try
                If dgvCuentasPorCobrar.RowCount > 0 Then
                    ExportarDatosExcel(dgvCuentasPorCobrar, "CUENTAS POR COBRAR")
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtNombreComercialClienteGeneral_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then

                lblIdClienteGeneral.Text = objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
            End If
        End Sub

        Private Sub rbGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbGeneral.CheckedChanged
            If rbGeneral.Checked = True Then
                txtNombreComercialClienteGeneral.Enabled = False
                rbPorCliente.Checked = False
            End If
        End Sub
        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked = True Then
                txtNombreComercialClienteGeneral.Enabled = True
                txtNombreComercialClienteGeneral.Text = ""
                txtNombreComercialClienteGeneral.Focus()
                rbGeneral.Checked = False
                autocompletarNombreCliente()
            End If
        End Sub

        Private Sub ChkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ChkTodos.CheckedChanged
            btnBuscar_Click(Nothing, Nothing)
        End Sub

        Private Sub REPORTEASIENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTEASIENTOToolStripMenuItem.Click
            If dgvCuentasPorCobrar.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS QUE CARGAR. PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            Dim f = New FormReportCuentasCobrar
            f.IsMin = True            
            f.IsGeneral = rbGeneral.Checked
            f.cliente = txtNombreComercialClienteGeneral.Text
            f.saldo = txtTotalCuentasPorCobrar.Text
            f.DataGrid = dgvCuentasPorCobrar
            f.desde = dtpDesde.Value.ToString("dd/MM/yyyy")
            f.hasta = dtpHasta.Value.ToString("dd/MM/yyyy")
            f.TipoCox = TipoCox
            f.Show()
        End Sub
    End Class
End Namespace