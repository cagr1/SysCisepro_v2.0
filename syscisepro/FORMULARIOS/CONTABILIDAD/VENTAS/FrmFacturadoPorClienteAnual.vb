Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_COBRAR
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmFacturadoPorClienteAnual
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

        ReadOnly _objetoContratoCliente As New ClassContratoCliente
        ReadOnly _objetoCuentasPorCobrar As New ClassCuentasPorCobrar
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral

        Private Sub ExportarDatosExcel(ByVal titulo As String, ByVal sname As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = sname

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
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
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                '' TOTALES, ETC
                'Dim foot = headin + dgvAsientosDiario.RowCount + 3
                'worksheet.Cells(foot, 7).Value = "TOTAL DEBE"
                'worksheet.Cells(foot, 7).Font.Bold = True
                'worksheet.Cells(foot, 8).Value = txtTotalDebe.Text

                'worksheet.Cells(foot + 1, 7).Value = "TOTAL HABER"
                'worksheet.Cells(foot + 1, 7).Font.Bold = True
                'worksheet.Cells(foot + 1, 8).Value = txtTotalHaber.Text

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub CargarCuentasPorCobrarGeneral()
            Try
                Dim fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

                Dim data = _objetoCuentasPorCobrar.ReporteFacturadoPorClienteRangoFecha(_tipoCon, CInt(ComboBox2.Text), txtNombreComercialClienteGeneral.Text, fechaDesde, fechaHasta)
                 
                dgvAsientosDiario.DataSource = data
                dgvAsientosDiario.AutoResizeColumns()

                dgvAsientosDiario.Columns(0).HeaderText = "ID CLI."
                dgvAsientosDiario.Columns(0).Width = 50

                dgvAsientosDiario.Columns(1).HeaderText = "RUC / CI."
                dgvAsientosDiario.Columns(1).Width = 100

                dgvAsientosDiario.Columns(2).HeaderText = "RAZÓN SOCIAL (CLIENTE)"
                dgvAsientosDiario.Columns(2).Width = 400

                dgvAsientosDiario.Columns(3).HeaderText = "CONVENIO FACTURAR"
                dgvAsientosDiario.Columns(3).Width = 90
                'dgvAsientosDiario.Columns(3).DefaultCellStyle.BackColor = Color.Aqua
                dgvAsientosDiario.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(4).HeaderText = "TOTAL FACTUADO"
                dgvAsientosDiario.Columns(4).Width = 85
                dgvAsientosDiario.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(5).HeaderText = "RETENCIÓN"
                dgvAsientosDiario.Columns(5).Width = 85
                dgvAsientosDiario.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(6).Visible = False

                dgvAsientosDiario.Columns(7).HeaderText = "NOTA CRÉDITO"
                dgvAsientosDiario.Columns(7).Width = 85
                dgvAsientosDiario.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(8).HeaderText = "ABONADO"
                dgvAsientosDiario.Columns(8).Width = 85
                dgvAsientosDiario.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(9).HeaderText = "POR COBRAR"
                dgvAsientosDiario.Columns(9).Width = 90
                dgvAsientosDiario.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvAsientosDiario.Columns(10).HeaderText = "PENDIENTE FACTURAR"
                dgvAsientosDiario.Columns(10).Width = 100
                dgvAsientosDiario.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Catch
                dgvAsientosDiario.ReadOnly = False
            End Try
        End Sub

        Public Sub cargarCuentasPorCobrarPorCliente(ByVal all As Boolean)
            'If txtNombreComercialClienteGeneral.Text.Trim().Length = 0 Then Return

            'Dim data As DataTable

            'If rbPorCliente.Checked Then
            '    data = objetoCuentasPorCobrar.BuscarCuentasPorCobrarPorClientePorRangoFecha(_tipoCon, lblIdClienteGeneral.Text, fechaDesde, fechaHasta, all)
            '    dgvCuentasPorCobrar.DataSource = data
            '    dgvCuentasPorCobrar.AutoResizeColumns()

            '    dgvCuentasPorCobrar.Columns(2).HeaderText = "FECHA EMISIÓN"
            '    dgvCuentasPorCobrar.Columns(2).Width = 130

            '    dgvCuentasPorCobrar.Columns(3).HeaderText = "FACTURADO"
            '    dgvCuentasPorCobrar.Columns(3).Width = 80

            '    dgvCuentasPorCobrar.Columns(4).HeaderText = "RETENIDO"
            '    dgvCuentasPorCobrar.Columns(4).Width = 80

            '    dgvCuentasPorCobrar.Columns(5).HeaderText = "A COBRAR"
            '    dgvCuentasPorCobrar.Columns(5).Width = 80

            '    dgvCuentasPorCobrar.Columns(6).HeaderText = "NOT. CRÉDITO"
            '    dgvCuentasPorCobrar.Columns(6).Width = 90

            '    dgvCuentasPorCobrar.Columns(7).HeaderText = "ABONADO"
            '    dgvCuentasPorCobrar.Columns(7).Width = 80

            '    dgvCuentasPorCobrar.Columns(8).HeaderText = "SALDO"
            '    dgvCuentasPorCobrar.Columns(8).Width = 80

            '    dgvCuentasPorCobrar.Columns(9).HeaderText = "OBSERVACIONES"

            'Else
            '    data = objetoCuentasPorCobrar.BuscarCuentasPorCobrarPorClientesConsorcioPorRangoFecha(_tipoCon, fechaDesde, fechaHasta, txtNombreComercialClienteGeneral.Text.Trim, all)
            '    dgvCuentasPorCobrar.DataSource = data
            '    dgvCuentasPorCobrar.AutoResizeColumns()

            '    dgvCuentasPorCobrar.Columns(2).HeaderText = "RAZON SOCIAL (CLIENTE)"
            '    dgvCuentasPorCobrar.Columns(2).Width = 130

            '    dgvCuentasPorCobrar.Columns(3).HeaderText = "FECHA EMISIÓN"
            '    dgvCuentasPorCobrar.Columns(3).Width = 130

            '    dgvCuentasPorCobrar.Columns(4).HeaderText = "FACTURADO"
            '    dgvCuentasPorCobrar.Columns(4).Width = 80

            '    dgvCuentasPorCobrar.Columns(5).HeaderText = "RETENIDO"
            '    dgvCuentasPorCobrar.Columns(5).Width = 80

            '    dgvCuentasPorCobrar.Columns(6).HeaderText = "A COBRAR"
            '    dgvCuentasPorCobrar.Columns(6).Width = 80

            '    dgvCuentasPorCobrar.Columns(7).HeaderText = "NOT. CRÉDITO"
            '    dgvCuentasPorCobrar.Columns(7).Width = 90

            '    dgvCuentasPorCobrar.Columns(8).HeaderText = "ABONADO"
            '    dgvCuentasPorCobrar.Columns(8).Width = 80

            '    dgvCuentasPorCobrar.Columns(9).HeaderText = "SALDO"
            '    dgvCuentasPorCobrar.Columns(9).Width = 80

            '    dgvCuentasPorCobrar.Columns(10).HeaderText = "OBSERVACIONES"
            'End If

            'dgvCuentasPorCobrar.Columns(0).HeaderText = "ID FAC."
            'dgvCuentasPorCobrar.Columns(0).Width = 50

            'dgvCuentasPorCobrar.Columns(1).HeaderText = "N° FAC."
            'dgvCuentasPorCobrar.Columns(1).Width = 90

            ''            cantidadRegistrosCuentasPorCobrar = CType(dgvCuentasPorCobrar.DataSource, DataTable).Rows.Count

            'dgvCuentasPorCobrar.ReadOnly = False

        End Sub

        Public Sub totalCuentasPorCobrarGeneral()
            'Try
            '    Dim totalFacturado As Decimal = 0
            '    Dim totalRetenido As Decimal = 0
            '    Dim totalCobrar As Decimal = 0
            '    Dim totalNotaCredito As Decimal = 0
            '    Dim totalAbonado As Decimal = 0

            '    If dgvCuentasPorCobrar.RowCount > 0 Then

            '        For indice = 0 To dgvCuentasPorCobrar.RowCount - 1

            '            totalFacturado += dgvCuentasPorCobrar.Rows(indice).Cells("facturado").Value
            '            totalRetenido += dgvCuentasPorCobrar.Rows(indice).Cells("retenido").Value
            '            totalCobrar += dgvCuentasPorCobrar.Rows(indice).Cells("cobrar").Value
            '            totalNotaCredito += dgvCuentasPorCobrar.Rows(indice).Cells("nota_credito").Value
            '            totalAbonado += dgvCuentasPorCobrar.Rows(indice).Cells("abonado").Value

            '            If dgvCuentasPorCobrar.Rows(indice).Cells("saldo").Value > 0 Then dgvCuentasPorCobrar.Rows(indice).Cells("saldo").Style.BackColor = Color.IndianRed

            '        Next

            '        txtTotalFacturas.Text = Math.Round(totalFacturado, 2)
            '        txtTotalRetencion.Text = Math.Round(totalRetenido, 2)
            '        txtTotalACobrar.Text = Math.Round((totalFacturado - totalRetenido), 2)
            '        txtTotalNotaCredito.Text = Math.Round(totalNotaCredito, 2)

            '        txtTotalAbonado.Text = Math.Round(totalAbonado, 2)
            '        txtTotalCuentasPorCobrar.Text = Math.Round(((totalFacturado - totalRetenido) - (totalNotaCredito + totalAbonado)), 2)
            '    End If
            'Catch ex As Exception
            '    MsgBox("METODO SUMAR TOTAL CUENTAS POR COBRAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            'End Try
        End Sub

        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Sub GenerarAnios()
            Dim c = _objetoContratoCliente.BuscarAniosContratoActivoClienteGeneral(_tipoCon)
            Dim f = ValidationForms.FechaActual(_tipoCon)
            ComboBox2.Items.Clear()
            For Each r As DataRow In c.Rows
                ComboBox2.Items.Add(r(0))
            Next
            If Not ComboBox2.Items.Contains(f.Year) Then ComboBox2.Items.Add(f.Year)
            ComboBox2.SelectedIndex = 0
        End Sub

        Private Sub FormCuentasPorCobrarGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsientosDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            GenerarAnios()
            AutocompletarNombreCliente()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            CargarCuentasPorCobrarGeneral()

            For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvAsientosDiario.Rows Where CDec(row1.Cells(3).Value) = 0
                row.Cells(10).Value = "0.0"
            Next
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvAsientosDiario.RowCount > 0 Then ExportarDatosExcel("FACTURADO POR CLIENTE", "FACTURADO_CLIENTE")
        End Sub

        Private Sub txtNombreComercialClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                Dim idc = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
                If idc = 0 Then
                    lblIdClienteGeneral.Text = "..."
                Else
                    lblIdClienteGeneral.Text = idc
                End If
            Catch
                lblIdClienteGeneral.Text = "..."
            End Try
            CargarCuentasPorCobrarGeneral()
        End Sub

        Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ComboBox2.SelectedIndexChanged
            dtpDesde.Value = New DateTime(CInt(ComboBox2.Text), 1, 1, 0, 0, 0)
            dtpHasta.Value = dtpDesde.Value.AddYears(1).AddDays(-1)
        End Sub
    End Class
End Namespace