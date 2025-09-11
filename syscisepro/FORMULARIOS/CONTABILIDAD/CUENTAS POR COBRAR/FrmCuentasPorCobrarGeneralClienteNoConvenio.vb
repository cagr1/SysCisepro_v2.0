Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_COBRAR
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports ClosedXML.Excel

Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR
    Public Class FrmCuentasPorCobrarGeneralClienteNoConvenio
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
        Dim _idCliente As Integer = 0


        Private Sub FrmCuentasPorCobrarGeneralClienteNoConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Public Sub autocompletarNombreClienteAcumulado()
            Try
                txtCliente.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest
                txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtCliente.AutoCompleteCustomSource = Nothing
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
                    data = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetalladoPorClienteRangoFecha(_tipoCon, _fechaDesde, _fechaHasta)
                Else
                    data = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetalladoPorClienteRangoFechaIdCliente(_tipoCon, _fechaDesde, _fechaHasta, idCliente)
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
                KryptonMessageBox.Show("Metodo cargar cuentas por cobrar general por cliente" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
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
                'MsgBox("METODO SUMAR TOTAL CUENTAS POR COBRAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo sumar total cuentas por cobrar" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
            Try
                If dgvCuentasPorCobrar.RowCount > 0 Then
                    ExportarDatosExcel(dgvCuentasPorCobrar, "CUENTAS POR COBRAR")
                End If
            Catch ex As Exception
                KryptonMessageBox.Show("Metodo exportar" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvCuentasPorPagar As DataGridView, ByVal titulo As String)
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
                'MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Metodo exportar datos" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
            Dim frm As New FrmPendienteFacturacion
            frm.ShowDialog()
        End Sub

        Private Sub btnBuscarAcumulado_Click(sender As Object, e As EventArgs) Handles btnBuscarAcumulado.Click
            Dim fechaDesde As DateTime = dtpDesdeAcu.Value.Date
            Dim fechaHasta As Date = dtpHastaAcu.Value.Date.AddDays(1).AddSeconds(-1) ' hasta el final del día

            dgvClienteAcumulado.DataSource = Nothing

            cargarCuentasPorCobrarGeneralPorClienteAcumulado(fechaDesde, fechaHasta)
        End Sub


        Public Sub cargarCuentasPorCobrarGeneralPorClienteAcumulado(ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime)
            Try
                dgvClienteAcumulado.Rows.Clear()
                Dim auxCli = String.Empty
                Dim totCliente(6) As Decimal
                Dim totGeneral(7) As Decimal

                Dim data As DataTable = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetalladoPorClienteAcumulado(_tipoCon, fechaDesde, fechaHasta)


                If data.Rows.Count > 0 Then
                    auxCli = data.Rows(0)("Cliente").ToString().Trim()


                    ' Procesar cada fila de datos
                    For Each row As DataRow In data.Rows
                        Dim currentCliente As String = row("Cliente").ToString().Trim()

                        ' Si cambió el cliente, agregar totales y espacios
                        If Not auxCli.Equals(currentCliente) AndAlso Not String.IsNullOrEmpty(auxCli) Then
                            AgregarFilaTotal(totCliente, auxCli)
                            AgregarEspacioEntreClientes()

                            ' Acumular al total general y reiniciar totales del cliente
                            For i As Integer = 0 To 6
                                totGeneral(i) += totCliente(i)
                                totCliente(i) = 0 ' Reiniciar totales del cliente
                            Next
                        End If

                        ' Agregar fila con datos
                        dgvClienteAcumulado.Rows.Add(
                        row("Cliente"),
                        row("Factura"),
                        Format(CDate(row("Fecha")), "dd/MM/yyyy"),
                        CDec(row("Facturado")).ToString("N2"),
                        CDec(row("1-30")).ToString("N2"),
                        CDec(row("31-60")).ToString("N2"),
                        CDec(row("61-90")).ToString("N2"),
                        CDec(row("91-120")).ToString("N2"),
                        CDec(row(">120")).ToString("N2"),
                        CDec(row("Total")).ToString("N2")
            )

                        ' Acumular totales del cliente
                        totCliente(0) += CDec(row("Facturado"))
                        totCliente(1) += CDec(row("1-30"))
                        totCliente(2) += CDec(row("31-60"))
                        totCliente(3) += CDec(row("61-90"))
                        totCliente(4) += CDec(row("91-120"))
                        totCliente(5) += CDec(row(">120"))
                        totCliente(6) += CDec(row("Total"))

                        auxCli = currentCliente
                    Next

                    ' Agregar total del último cliente
                    If data.Rows.Count > 0 Then
                        AgregarFilaTotal(totCliente, auxCli)

                        ' Acumular al total general
                        For i As Integer = 0 To 6
                            totGeneral(i) += totCliente(i)
                        Next
                    End If

                    Dim rowIndex As Integer = dgvClienteAcumulado.Rows.Add()
                    With dgvClienteAcumulado.Rows(rowIndex)
                        .Cells(0).Value = "TOTAL GENERAL"
                        .Cells(3).Value = totGeneral(0).ToString("N2") ' Facturado
                        .Cells(4).Value = totGeneral(1).ToString("N2") ' 1-30
                        .Cells(5).Value = totGeneral(2).ToString("N2") ' 31-60
                        .Cells(6).Value = totGeneral(3).ToString("N2") ' 61-90
                        .Cells(7).Value = totGeneral(4).ToString("N2") ' 91-120
                        .Cells(8).Value = totGeneral(5).ToString("N2") ' >120
                        .Cells(9).Value = totGeneral(6).ToString("N2") ' Total

                        ' Formato de la fila de total general
                        .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                        .DefaultCellStyle.BackColor = Color.LightSteelBlue

                    End With

                    ' Ajustar visualización
                    dgvClienteAcumulado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                    dgvClienteAcumulado.AutoResizeRows()

                End If

                dgvCuentasPorCobrar.AutoResizeRows()
            Catch ex As Exception
                dgvCuentasPorCobrar.Rows.Clear()
                KryptonMessageBox.Show("Metodo cargar cuentas por cobrar general por cliente" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub AgregarFilaTotal(totales() As Decimal, nombreCliente As String)
            ' Agregar fila de totales para el cliente actual
            Dim rowIndex As Integer = dgvClienteAcumulado.Rows.Add()
            With dgvClienteAcumulado.Rows(rowIndex)
                .Cells(0).Value = "TOTAL " & nombreCliente
                .Cells(3).Value = totales(0).ToString("N2") ' Facturado
                .Cells(4).Value = totales(1).ToString("N2") ' 1-30
                .Cells(5).Value = totales(2).ToString("N2") ' 31-60
                .Cells(6).Value = totales(3).ToString("N2") ' 61-90
                .Cells(7).Value = totales(4).ToString("N2") ' 91-120
                .Cells(8).Value = totales(5).ToString("N2") ' >120
                .Cells(9).Value = totales(6).ToString("N2") ' Total

                ' Formato de la fila de totales
                .DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                .DefaultCellStyle.BackColor = Color.LightGray
            End With
        End Sub

        Private Sub AgregarEspacioEntreClientes()
            ' Agregar fila vacía como separador
            dgvClienteAcumulado.Rows.Add()

            ' Opcional: configurar altura de la fila vacía
            If dgvClienteAcumulado.RowCount > 0 Then
                dgvClienteAcumulado.Rows(dgvClienteAcumulado.RowCount - 1).Height = 10
            End If
        End Sub

        Private Sub txtCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            _idCliente = Convert.ToInt32(_objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtCliente.Text))
        End Sub

        Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
            Dim fechaDesde As DateTime = dtpDesdeAcu.Value.Date
            Dim fechaHasta As Date = dtpHastaAcu.Value.Date.AddDays(1).AddSeconds(-1) ' hasta el final del día

            dgvDetallado.DataSource = Nothing

            cargarCuentasPorCobrarDetallado(fechaDesde, fechaHasta)
        End Sub

        Private Sub cargarCuentasPorCobrarDetallado(fechaDesde As DateTime, fechaHasta As DateTime)
            Try

                dgvDetallado.Rows.Clear()
                dgvDetallado.Columns.Clear()
                Dim auxCliente = String.Empty
                Dim totFacturado As Decimal = 0
                Dim totSaldoPendiente As Decimal = 0
                Dim totGeneralFacturado As Decimal = 0
                Dim totGeneralSaldoPendiente As Decimal = 0

                With dgvDetallado.Columns
                    .Add("Cliente", "Cliente")
                    .Add("Factura", "Factura")
                    .Add("Fecha", "Fecha")
                    .Add("Facturado", "Facturado")
                    .Add("Dias Transcurridos", "Dias Transcurridos")
                    .Add("Saldo Pendiente", "Saldo Pendiente")
                End With


                Dim data As DataTable = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarGeneralDetallado(_tipoCon, fechaDesde, fechaHasta)

                If data.Rows.Count > 0 Then

                    auxCliente = data.Rows(0)("Cliente").ToString().Trim()


                    For Each row As DataRow In data.Rows
                        Dim currentCliente As String = row("Cliente").ToString().Trim()

                        ' Si cambió el proveedor, agregamos totales y reiniciamos
                        If Not auxCliente.Equals(currentCliente) AndAlso Not String.IsNullOrEmpty(auxCliente) Then
                            ' Agregar fila de total por proveedor
                            Dim rowIndex As Integer = dgvDetallado.Rows.Add()
                            With dgvDetallado.Rows(rowIndex)
                                .Cells(0).Value = "TOTAL " & auxCliente
                                .Cells(3).Value = totFacturado.ToString("N2")
                                .Cells(5).Value = totSaldoPendiente.ToString("N2")
                                .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                                .DefaultCellStyle.BackColor = Color.LightGray
                            End With

                            ' Agregar fila en blanco como separador
                            dgvDetallado.Rows.Add()

                            ' Acumular en total general
                            totGeneralFacturado += totFacturado
                            totGeneralSaldoPendiente += totSaldoPendiente

                            ' Reiniciar acumuladores por proveedor
                            totFacturado = 0
                            totSaldoPendiente = 0
                        End If

                        ' Agregar fila con datos del proveedor
                        dgvDetallado.Rows.Add(
                    row("Cliente"),
                    row("Factura"),
                    Format(CDate(row("Fecha")), "dd/MM/yyyy"),
                    CDec(row("Facturado")).ToString("N2"),
                    row("Dias Transcurridos"),
                    CDec(row("Saldo Pendiente")).ToString("N2")
                )

                        ' Acumular totales del proveedor
                        totFacturado += CDec(row("Facturado"))
                        totSaldoPendiente += CDec(row("Saldo Pendiente"))

                        auxCliente = currentCliente
                    Next

                    ' Agregar el total del último proveedor
                    If data.Rows.Count > 0 Then
                        Dim rowIndex As Integer = dgvDetallado.Rows.Add()
                        With dgvDetallado.Rows(rowIndex)
                            .Cells(0).Value = "TOTAL " & auxCliente
                            .Cells(3).Value = totFacturado.ToString("N2")
                            .Cells(5).Value = totSaldoPendiente.ToString("N2")
                            .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                            .DefaultCellStyle.BackColor = Color.LightGray
                        End With

                        ' Acumular último proveedor en total general
                        totGeneralFacturado += totFacturado
                        totGeneralSaldoPendiente += totSaldoPendiente
                    End If

                    ' Agregar total general
                    Dim rowGeneral As Integer = dgvDetallado.Rows.Add()
                    With dgvDetallado.Rows(rowGeneral)
                        .Cells(0).Value = "TOTAL GENERAL"
                        .Cells(3).Value = totGeneralFacturado.ToString("N2")
                        .Cells(5).Value = totGeneralSaldoPendiente.ToString("N2")
                        .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                        .DefaultCellStyle.BackColor = Color.LightSteelBlue
                    End With

                    dgvDetallado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



                End If

            Catch ex As Exception
                KryptonMessageBox.Show("Hubo un problema al cargar los datos." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportarComparacion_Click(sender As Object, e As EventArgs) Handles btnExportarComparacion.Click
            ExportarDatosComparacion(dgvClienteAcumulado, "CuentasPorPagar_Acumulados")
        End Sub

        Private Sub ExportarDatosComparacion(ByVal dgvComparacion As DataGridView, ByVal titulo As String)
            Try
                If dgvComparacion.Rows.Count = 0 Then
                    Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)



                'Crear un nuevo libro y hoja
                Dim workbook = New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("CxC_Acumulados")

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvComparacion)
                worksheet.Range("A1:" & ic & (dgvComparacion.RowCount + 50)).Style.Font.FontSize = 10


                'Encabezado

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon).ToString() & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Style.Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Range("A1:" & ic & "1").Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                worksheet.Range("A1:" & ic & "1").Style.Font.FontColor = XLColor.White
                worksheet.Range("A1:" & ic & "1").Style.Font.FontSize = 12

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpDesdeAcu.Value.ToLongDateString() & "  AL " & dtpHastaAcu.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Style.Font.FontSize = 12

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Style.Font.FontSize = 12

                'Encabezados de Columnas 
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvComparacion.Columns.Count - 1
                    If Not dgvComparacion.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvComparacion.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.Bold = True
                    worksheet.Cell(headin, indc).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                    worksheet.Cell(headin, indc).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    worksheet.Cell(headin, indc).Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                    worksheet.Cell(headin, indc).Style.Font.FontColor = XLColor.White
                    indc += 1
                Next


                ' Detalle de la tabla
                Dim columnasTexto As String() = {"Cliente", "No Factura", "Fecha", "Factura", "Dias Transcurrridos"} ' Solo "Cuenta" es texto
                Dim columnasNumericas As String() = {"Facturado", "0-30", "31-60", "61-90", "91-120", ">120", "Total", "Saldo Pendiente"} ' Estas son numéricas
                Dim c = 0
                For o = 0 To dgvComparacion.Rows.Count - 1
                    ' Omitir filas ocultas si el CheckBox está marcado


                    indc = 1
                    For j = 0 To dgvComparacion.Columns.Count - 1
                        If Not dgvComparacion.Columns(j).Visible Then Continue For

                        Dim cellValue = dgvComparacion.Rows(o).Cells(j).Value
                        Dim cell = worksheet.Cell(c + 1 + headin, indc)
                        Dim columnName As String = dgvComparacion.Columns(j).HeaderText

                        ' Aplicar formato según el tipo de columna
                        If columnasNumericas.Contains(columnName) Then
                            ' Columnas numéricas específicas ("Codigo", "Nivel", "Padre")
                            If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                                cell.Value = CDbl(cellValue) ' Asegurar que el valor sea numérico
                            Else
                                cell.Value = 0 ' Valor por defecto si no es numérico
                            End If
                        ElseIf columnasTexto.Contains(columnName) Then
                            ' Columna de texto ("Cuenta")
                            cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                        Else
                            ' Formato contable para el resto de columnas
                            If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                                cell.Value = CDbl(cellValue)
                                cell.Style.NumberFormat.Format = "#,##0.00" ' Formato contable
                            Else
                                cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                            End If
                        End If

                        ' Aplicar bordes a la celda
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        ' Aplicar borde inferior solo en la última fila
                        If o = dgvComparacion.Rows.Count - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                    c += 1
                Next


                ' Bordes inferiores
                worksheet.Range("A" & (c + headin) & ":" & ic & indc).Style.Border.BottomBorder = XLBorderStyleValues.Thin

                ' Ajustar columnas
                Dim range As IXLRange = worksheet.Range("A1:" & ic & (dgvComparacion.RowCount + 50))
                worksheet.Columns("A:" & ic).AdjustToContents()

                ' Guardar el archivo
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
                saveFileDialog.FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    workbook.SaveAs(saveFileDialog.FileName)
                    Process.Start(saveFileDialog.FileName)
                End If

                Krypton.Toolkit.KryptonMessageBox.Show("Datos exportados correctamente!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)




            Catch ex As Exception
                Krypton.Toolkit.KryptonMessageBox.Show("ERROR: " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportarDetallado_Click(sender As Object, e As EventArgs) Handles btnExportarDetallado.Click
            ExportarDatosComparacion(dgvDetallado, "CuentasPorPagar_Detallado")
        End Sub
    End Class
End Namespace
