 
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms 
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES 
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_PAGAR
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmCuentasPorPagarMin
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

        Dim objetoCuentasPorPagar As New ClassCuentasPorPagar

        Dim objetoProveedorGeneral As New ClassProveedores


        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""

        Public Sub autocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Public Sub cargarDatosProveedor()
            Try
                dgvProveedorGeneral.DataSource = objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtNombreComercialProveedorGeneral.Text)

                If dgvProveedorGeneral.RowCount > 0 Then
                    lblIdProveedorGeneral.Text = dgvProveedorGeneral.Rows(0).Cells(0).Value
                    lblRucProveedorGeneral.Text = dgvProveedorGeneral.Rows(0).Cells(2).Value
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS PROVEEDOR." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("CARGAR DATOS PROVEEDOR." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub cargarCuentasPorPagarGeneral(ByVal all As Boolean)
            'Try

            If all Then
                dgvCuentasPorPagar.DataSource = objetoCuentasPorPagar.BuscarCuentasPorPagarGeneralXRangoFechaMin(_tipoCon, fechaDesde, fechaHasta)
            Else
                dgvCuentasPorPagar.DataSource = objetoCuentasPorPagar.BuscarCuentasPorPagarGeneralXRangoFechaNoCeroMin(_tipoCon, fechaDesde, fechaHasta)
            End If
            dgvCuentasPorPagar.Columns(0).Width = 50
            dgvCuentasPorPagar.Columns(1).Width = 90
            dgvCuentasPorPagar.Columns(2).Width = 450
            dgvCuentasPorPagar.Columns(3).Visible = False
            dgvCuentasPorPagar.Columns(4).Visible = False
            dgvCuentasPorPagar.Columns(5).Visible = False
            dgvCuentasPorPagar.Columns(6).Visible = False
            dgvCuentasPorPagar.Columns(7).HeaderText = "SALDO"
            dgvCuentasPorPagar.Columns(7).Width = 90
             
            dgvCuentasPorPagar.AutoSizeRowsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvCuentasPorPagar.AutoResizeRows() 
            dgvCuentasPorPagar.ReadOnly = True 
        End Sub

        Public Sub cargarCuentasPorPagarPorProveedor(ByVal all As Boolean)
            If txtNombreComercialProveedorGeneral.Text.Trim().Length = 0 Then
                Return
            End If

            If all Then
                dgvCuentasPorPagar.DataSource = objetoCuentasPorPagar.BuscarCuentasPorPagarXIdProveedorRangoFechaMin(_tipoCon, lblIdProveedorGeneral.Text, fechaDesde, fechaHasta)
            Else
                dgvCuentasPorPagar.DataSource = objetoCuentasPorPagar.BuscarCuentasPorPagarXIdProveedorRangoFechaNoCeroMin(_tipoCon, lblIdProveedorGeneral.Text, fechaDesde, fechaHasta)
            End If

            dgvCuentasPorPagar.Columns(4).Visible = False
            dgvCuentasPorPagar.Columns(5).Visible = False
            dgvCuentasPorPagar.Columns(6).Visible = False
            dgvCuentasPorPagar.Columns(7).Visible = False
            dgvCuentasPorPagar.Columns(8).Visible = False
            dgvCuentasPorPagar.Columns(9).Visible = False
            dgvCuentasPorPagar.Columns(10).Visible = False
            dgvCuentasPorPagar.Columns(11).Visible = False
            dgvCuentasPorPagar.Columns(12).Visible = False
            dgvCuentasPorPagar.Columns(14).Visible = False

            dgvCuentasPorPagar.Columns(15).HeaderText = "SALDO" 

            dgvCuentasPorPagar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvCuentasPorPagar.ReadOnly = False
            dgvCuentasPorPagar.EditMode = DataGridViewEditMode.EditProgrammatically

        End Sub

        Public Sub sumarCuentasPorPagarGeneral() 
            Dim totalSaldo As Decimal = 0

            If dgvCuentasPorPagar.RowCount > 0 Then

                For indice = 0 To dgvCuentasPorPagar.RowCount - 1 
                    totalSaldo = totalSaldo + dgvCuentasPorPagar.Rows(indice).Cells.Item("SALDO").Value

                    If dgvCuentasPorPagar.Rows(indice).Cells.Item("SALDO").Value > 0 Then
                        dgvCuentasPorPagar.Rows(indice).Cells("SALDO").Style.BackColor = Color.IndianRed
                    End If

                Next
                 
                txtTotalCuentasPorPagar.Text = totalSaldo
            End If
        End Sub

        Public Sub sumarCuentasPorPagarPorProveedor()
            Dim totalAPagar As Decimal = 0

            ' verifica si se cargaron comprobanets
            If dgvCuentasPorPagar.RowCount > 0 Then
                ' recorre los comprobantes cargados
                For indice = 0 To dgvCuentasPorPagar.RowCount - 1
                    totalAPagar = totalAPagar + dgvCuentasPorPagar.Rows(indice).Cells.Item("SALDO").Value

                    If dgvCuentasPorPagar.Rows(indice).Cells.Item("SALDO").Value > 0 Then
                        dgvCuentasPorPagar.Rows(indice).Cells("SALDO").Style.BackColor = Color.IndianRed
                    End If
                Next

                txtTotalCuentasPorPagar.Text = totalAPagar

            End If
        End Sub

        Private Sub FrmCuentasPorPagarMin_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCuentasPorPagar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvCuentasPorPagar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvCuentasPorPagar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCuentasPorPagar.Font = New Font("Roboto", 8, FontStyle.Regular)
            autocompletarNombreProveedor()
            rbGeneral.Checked = True
        End Sub

        Private Sub txtNombreComercialProveedorGeneral_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then

                lblIdProveedorGeneral.Text = objetoProveedorGeneral.BuscarIdProveedorXNombreComercialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
                cargarDatosProveedor()
            End If
        End Sub

        Private Sub btnBuscarbtnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click 
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

            dgvCuentasPorPagar.DataSource = Nothing

            If rbGeneral.Checked Then
                cargarCuentasPorPagarGeneral(ChkTodos.Checked)
                sumarCuentasPorPagarGeneral()
            ElseIf rbPorCliente.Checked Then
                cargarCuentasPorPagarPorProveedor(ChkTodos.Checked)
                sumarCuentasPorPagarPorProveedor()
            Else
                'MsgBox("ESCOJA UN TIPOD E CONSULTA.", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("Escoja un tipod e consulta.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
            dgvCuentasPorPagar.ReadOnly = True
        End Sub
         

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Try
                If dgvCuentasPorPagar.Rows.Count = 0 Then
                    'MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "CUENTAS_PAGAR"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvCuentasPorPagar)
                worksheet.Range("A1:" & ic & (dgvCuentasPorPagar.RowCount + 50)).Font.Size = 10
                 
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  CUENTAS POR PAGAR " & If(rbPorCliente.Checked, txtNombreComercialProveedorGeneral.Text.Trim(), String.Empty)
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
                Dim cv = If(rbGeneral.Checked, 4, 6)

                ' TOTALES, ETC
                Dim foot = headin + dgvCuentasPorPagar.RowCount + 3

                worksheet.Cells(foot, ct).Value = "SALDO TOTAL A PROVEEDORES"
                worksheet.Cells(foot, ct).Font.Bold = True
                worksheet.Cells(foot, cv).Value = txtTotalCuentasPorPagar.Text
                worksheet.Range("A1:" & ic & dgvCuentasPorPagar.RowCount + 20).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try 
        End Sub
         
        Private Sub rbGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbGeneral.CheckedChanged
            If rbGeneral.Checked = True Then
                txtNombreComercialProveedorGeneral.Enabled = False
                rbPorCliente.Checked = False
            End If
        End Sub
        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked = True Then
                txtNombreComercialProveedorGeneral.Enabled = True
                txtNombreComercialProveedorGeneral.Text = ""
                txtNombreComercialProveedorGeneral.Focus()
                rbGeneral.Checked = False
            End If
        End Sub

        Private Sub REPORTEASIENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTEASIENTOToolStripMenuItem.Click
            If dgvCuentasPorPagar.Rows.Count = 0 Then
                'MsgBox("NO HAY REGISTROS QUE CARGAR. Primero realice una busqueda", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("NO HAY REGISTROS QUE CARGAR. Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Dim f = New FormReportCuentasPagar
            f.IsMin = True
            f.IsGeneral = rbGeneral.Checked
            f.proveedor = txtNombreComercialProveedorGeneral.Text
            f.saldo = txtTotalCuentasPorPagar.Text
            f.DataGrid = dgvCuentasPorPagar
            f.desde = dtpDesde.Value.ToString("dd/MM/yyyy")
            f.hasta = dtpHasta.Value.ToString("dd/MM/yyyy")
            f.TipoCox = TipoCox
            f.Show()
        End Sub
    End Class
End Namespace