Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_COBRAR
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    Public Class FrmCuentasPorCobrarGeneralClienteConvenio
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

        ReadOnly _objetoCuentasPorCobrar As New ClassCuentasPorCobrar
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

        Private Sub FrmCuentasPorCobrarGeneralClienteConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCuentasPorCobrar.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCuentasPorCobrar.Font = New Font("Roboto", 8, FontStyle.Regular)
            cbxBanco.SelectedIndex = 0
            rbGeneral.Checked = True
        End Sub

        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked = True Then
                txtNombreComercialClienteGeneral.Enabled = True
                txtNombreComercialClienteGeneral.Text = ""
                txtNombreComercialClienteGeneral.Focus()
                rbGeneral.Checked = False
                autocompletarNombreCliente()
            End If
        End Sub

        Public Sub autocompletarNombreCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Sub txtNombreComercialClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click          
            txtTotalFacturas.Text = "0.00"
            txtTotalRetencion.Text = "0.00"
            txtTotalACobrar.Text = "0.00"
            txtTotalAbonado.Text = "0.00"
            txtTotalCuentasPorCobrar.Text = "0.00"

            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

            dgvCuentasPorCobrar.DataSource = Nothing

            cargarCuentasPorCobrarGeneralPorCliente(If(rbGeneral.Checked, 0, lblIdClienteGeneral.Text))
           
            totalCuentasPorCobrarGeneral()
        End Sub

        Public Sub cargarCuentasPorCobrarGeneralPorCliente(ByVal idCliente As String)
            Try
                dgvCuentasPorCobrar.Rows.Clear()
                Dim auxCli = String.Empty
                Dim tot(7) As Decimal

                Dim data As DataTable
                If idCliente = 0 Then
                    data = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetalladoPorClienteRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, cbxBanco.SelectedIndex)
                Else
                    data = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetalladoPorClienteRangoFechaIdCliente(_tipoCon, _fechaDesde, _fechaHasta, idCliente, cbxBanco.SelectedIndex)
                End If

                If data.Rows.Count > 0 Then
                    auxCli = data.Rows(0)(1).ToString().Trim()
                    'dgvCuentasPorCobrar.Rows.Add("", auxCli)
                    'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                    'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(_tipoCon)
                    'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.ForeColor = Color.WhiteSmoke

                    For Each row As DataRow In data.Rows
                        If Not auxCli.Equals(row(1).ToString().Trim) Then
                            'dgvCuentasPorCobrar.Rows.Add("", "TOTAL", "", "", "", tot(0), tot(1), tot(2), tot(3), tot(4), tot(5), "", "", "", tot(6))
                            dgvCuentasPorCobrar.Rows.Add("", "TOTAL", "", "", "", "", "", "", "", "", tot(5), "", "", "", tot(6))
                            dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                            dgvCuentasPorCobrar.Rows.Add("")
                            dgvCuentasPorCobrar.Rows.Add("")
                            tot(0) = 0
                            tot(1) = 0
                            tot(2) = 0
                            tot(3) = 0
                            tot(4) = 0
                            tot(5) = 0
                            tot(6) = 0

                            'dgvCuentasPorCobrar.Rows.Add("", row(1).ToString().Trim)
                            'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                            'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(_tipoCon)
                            'dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.ForeColor = Color.WhiteSmoke
                        End If

                        dgvCuentasPorCobrar.Rows.Add(row(0), row(1), row(2), row(3), row(4),
                                                     CDec(row(5)).ToString("N"), CDec(row(6)).ToString("N"), CDec(row(7)).ToString("N"), CDec(row(8)).ToString("N"), CDec(row(9)).ToString("N"),
                                                     CDec(row(10)).ToString("N"), row(11), row(12), row(13), CDec(If(row(14).ToString().Trim.Length = 0, 0, CDec(row(14)))).ToString("N"))

                        tot(0) += CDec(row(5))
                        tot(1) += CDec(row(6))
                        tot(2) += CDec(row(7))
                        tot(3) += CDec(row(8))
                        tot(4) += CDec(row(9))
                        tot(5) += CDec(row(10))
                        tot(6) += If(row(14).ToString().Trim.Length = 0, 0, CDec(row(14)))
                        auxCli = row(1).ToString().Trim()
                    Next
                    'dgvCuentasPorCobrar.Rows.Add("", "TOTAL", "", "", "", tot(0), tot(1), tot(2), tot(3), tot(4), tot(5), "", "", "", tot(6))
                    dgvCuentasPorCobrar.Rows.Add("", "TOTAL", "", "", "", "", "", "", "", "", tot(5), "", "", "", tot(6))
                    dgvCuentasPorCobrar.Rows(dgvCuentasPorCobrar.RowCount - 1).DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)

                End If

                dgvCuentasPorCobrar.AutoResizeRows()
            Catch ex As Exception
                dgvCuentasPorCobrar.Rows.Clear()
            End Try
        End Sub

        Public Sub totalCuentasPorCobrarGeneral()
            Try
                Dim totalFacturado As Decimal = 0
                Dim totalRetenido As Decimal = 0
                Dim totalCobrar As Decimal = 0
                Dim totalNotaCredito As Decimal = 0
                Dim totalAbonado As Decimal = 0

                If dgvCuentasPorCobrar.RowCount > 0 Then
                    For indice = 0 To dgvCuentasPorCobrar.RowCount - 1
                        If dgvCuentasPorCobrar.Rows(indice).Cells(0).Value.ToString().Trim.Length = 0 Then Continue For
                        totalFacturado += dgvCuentasPorCobrar.Rows(indice).Cells(5).Value
                        totalRetenido += dgvCuentasPorCobrar.Rows(indice).Cells(6).Value
                        totalCobrar += dgvCuentasPorCobrar.Rows(indice).Cells(7).Value
                        totalNotaCredito += dgvCuentasPorCobrar.Rows(indice).Cells(8).Value
                        totalAbonado += dgvCuentasPorCobrar.Rows(indice).Cells(9).Value
                        If dgvCuentasPorCobrar.Rows(indice).Cells(10).Value > 0 Then dgvCuentasPorCobrar.Rows(indice).Cells(10).Style.BackColor = Color.IndianRed
                    Next
                    txtTotalFacturas.Text = Math.Round(totalFacturado, 2)
                    txtTotalRetencion.Text = Math.Round(totalRetenido, 2)
                    txtTotalACobrar.Text = Math.Round((totalFacturado - totalRetenido), 2)
                    txtTotalNotaCredito.Text = Math.Round(totalNotaCredito, 2)
                    txtTotalAbonado.Text = Math.Round(totalAbonado, 2)
                    txtTotalCuentasPorCobrar.Text = Math.Round(((totalFacturado - totalRetenido) - (totalNotaCredito + totalAbonado)), 2)
                End If
            Catch ex As Exception
                MsgBox("METODO SUMAR TOTAL CUENTAS POR COBRAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            Try
                If dgvCuentasPorCobrar.RowCount > 0 Then
                    ExportarDatosExcel(dgvCuentasPorCobrar, "CUENTAS POR COBRAR")
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvCuentasPorPagar As DataGridView, ByVal titulo As String)
            Try
                If dgvCuentasPorPagar.Rows.Count = 0 Then
                    MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
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
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  CUENTAS POR COBRAR " & If(Not rbGeneral.Checked, txtNombreComercialClienteGeneral.Text.Trim(), String.Empty)
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
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

                Dim ct = 6
                Dim cv = 7

                ' TOTALES, ETC
                Dim footin = headin + dgvCuentasPorPagar.RowCount + 3

                ' mas abajo
                worksheet.Cells(footin, ct).Value = "SUBTOTAL"
                worksheet.Cells(footin, ct).Font.Bold = True
                worksheet.Cells(footin, cv).Value = "0.00"

                worksheet.Cells(footin + 1, ct).Value = "IVA"
                worksheet.Cells(footin + 1, ct).Font.Bold = True
                worksheet.Cells(footin + 1, cv).Value = "0.00"

                worksheet.Cells(footin + 2, ct).Value = "T. FACT."
                worksheet.Cells(footin + 2, ct).Font.Bold = True
                worksheet.Cells(footin + 2, cv).Value = txtTotalFacturas.Text

                worksheet.Cells(footin + 3, ct).Value = "T. RETENC."
                worksheet.Cells(footin + 3, ct).Font.Bold = True
                worksheet.Cells(footin + 3, cv).Value = txtTotalRetencion.Text

                ct = 8
                cv = 9

                worksheet.Cells(footin, ct).Value = "T. CORBRAR"
                worksheet.Cells(footin, ct).Font.Bold = True
                worksheet.Cells(footin, cv).Value = txtTotalACobrar.Text

                worksheet.Cells(footin + 1, ct).Value = "T.N. CRED."
                worksheet.Cells(footin + 1, ct).Font.Bold = True
                worksheet.Cells(footin + 1, cv).Value = txtTotalNotaCredito.Text

                worksheet.Cells(footin + 2, ct).Value = "T. ABONADO"
                worksheet.Cells(footin + 2, ct).Font.Bold = True
                worksheet.Cells(footin + 2, cv).Value = txtTotalAbonado.Text

                worksheet.Cells(footin + 3, ct).Value = "T. SALDO"
                worksheet.Cells(footin + 3, ct).Font.Bold = True
                worksheet.Cells(footin + 3, cv).Value = txtTotalCuentasPorCobrar.Text

                worksheet.Range("A1:" & ic & dgvCuentasPorPagar.RowCount + 50).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace