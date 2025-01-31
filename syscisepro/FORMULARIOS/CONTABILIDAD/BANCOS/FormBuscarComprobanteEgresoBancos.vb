Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports Krypton.Toolkit
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.ChartDrawing
Imports ClosedXML.Excel



Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarComprobanteEgresoBancos
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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
        'Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _objetoComprobanteEgreso As New ClassComprobanteEgresoBanco
        'ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos
        ReadOnly _validacionesAlfanumerica As New ClassAlfanumerico
        Dim objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso

        Dim _estadoComprobanteEgresos = 1
        Dim _fechaDesde = ""
        Dim _fechaHasta = ""

        Public IdUsuario As Integer
        Public UserName As String


        Private Sub FormBuscarComprobanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            '_sqlCommands = New List(Of SqlCommand)
            dgvComprobanteEgresoBancos.Font = New Drawing.Font("Roboto", 8, FontStyle.Regular)
            LlenarComboBancos()
            'autocompletarNombreCliente()
        End Sub

        Private Sub LlenarComboBancos()
            Try
                cmbBancos.DataSource = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DisplayMember = "NOMBRE_BANCO"
                cmbBancos.ValueMember = "ID_BANCO"
                If (CType(cmbBancos.DataSource, DataTable).Rows.Count > 0) Then cmbBancos.SelectedIndex = 0
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBancos.SelectedIndexChanged
            If cmbBancos.SelectedValue Is Nothing Or TypeOf cmbBancos.SelectedValue Is DataRowView Then Return
            LlenarComboCuentasBancos()
        End Sub
        Private Sub LlenarComboCuentasBancos()
            cmbCuentaBancos.DataSource = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, cmbBancos.SelectedValue)
            If cmbCuentaBancos.Items.Count = 0 Then
                cmbCuentaBancos.Text = "NINGUNA CUENTA"
            Else
                cmbCuentaBancos.DisplayMember = "NUMERO_CUENTA_BANCOS"
                cmbCuentaBancos.ValueMember = "ID_CUENTA_BANCOS"
            End If
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"
            CargarComprobanteEgresoBancos()
        End Sub
        Private Sub CargarComprobanteEgresoBancos()
            Try
                If _estadoComprobanteEgresos = 1 Then ' Emitidos
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoEmitidosXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, txtBuscar.Text.Trim())
                ElseIf _estadoComprobanteEgresos = 2 Then ' Aprobados
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoAprobadosXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, txtBuscar.Text.Trim())
                ElseIf _estadoComprobanteEgresos = 3 Then ' Cheque
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.SeleccionarComprobanteEgresoBancosXNumeroCheque(_tipoCon, txtNumeroCheque.Text)
                ElseIf _estadoComprobanteEgresos = 4 Then ' Todos
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.SeleccionarOrdenadosComprobanteEgresoBancos(_tipoCon, txtBuscar.Text.Trim())
                ElseIf _estadoComprobanteEgresos = 5 Then ' Fecha
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, txtBuscar.Text.Trim())
                ElseIf _estadoComprobanteEgresos = 6 Then ' Banco
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoXIdBancoIdCuentaRangoFecha(_tipoCon, cmbBancos.SelectedValue, cmbCuentaBancos.SelectedValue, _fechaDesde, _fechaHasta, txtBuscar.Text.Trim())
                End If

                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()
                'Set font dgvComprobanteEgresoBancos Roboto
                dgvComprobanteEgresoBancos.Font = New Drawing.Font("Roboto", 9, FontStyle.Regular)

                dgvComprobanteEgresoBancos.Columns(0).HeaderText = "ID"
                dgvComprobanteEgresoBancos.Columns(1).HeaderText = "NRO CE"
                dgvComprobanteEgresoBancos.Columns(2).HeaderText = "FECHA"
                dgvComprobanteEgresoBancos.Columns(2).DefaultCellStyle.Format = "g"
                dgvComprobanteEgresoBancos.Columns(3).HeaderText = "FACTURA"
                dgvComprobanteEgresoBancos.Columns(4).HeaderText = "RUC / CI"
                dgvComprobanteEgresoBancos.Columns(5).HeaderText = "PAGADO A"
                dgvComprobanteEgresoBancos.Columns(6).HeaderText = "ACTIVIDAD"
                dgvComprobanteEgresoBancos.Columns(7).HeaderText = "CONCEPTO"
                dgvComprobanteEgresoBancos.Columns(8).HeaderText = "TIPO"
                dgvComprobanteEgresoBancos.Columns(9).HeaderText = "VALOR"
                dgvComprobanteEgresoBancos.Columns(10).HeaderText = "Nº CHEQUE"
                dgvComprobanteEgresoBancos.Columns(11).HeaderText = "BANCO"
                dgvComprobanteEgresoBancos.Columns(12).HeaderText = "CUENTA"
                dgvComprobanteEgresoBancos.Columns(13).HeaderText = "EST"

                dgvComprobanteEgresoBancos.Columns(2).Width = 120
                dgvComprobanteEgresoBancos.Columns(3).Width = 150
                dgvComprobanteEgresoBancos.Columns(7).Width = 250

                dgvComprobanteEgresoBancos.ReadOnly = True

            Catch
                dgvComprobanteEgresoBancos.DataSource = Nothing
            End Try
            SumarTotal()
        End Sub
        Private Sub SumarTotal()
            Dim a As Decimal = 0
            For i = 0 To dgvComprobanteEgresoBancos.Rows.Count - 1
                a += CDec(dgvComprobanteEgresoBancos.Rows(i).Cells(9).Value)
            Next
            txtTotalComprobantesEgreso.Text = Math.Round(a, 2)
        End Sub
        Private Sub rbEmitidos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbEmitidos.CheckedChanged
            _estadoComprobanteEgresos = If(rbEmitidos.Checked, 1, 2)
            If rbEmitidos.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                'gbNumeroCheque.Enabled = False
                txtNumeroCheque.Enabled = False
                'gbRangoFechas.Enabled = True
                dtpDesde.Enabled = True
                dtpHasta.Enabled = True
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
                'gbComandos.Enabled = True
                txtBuscar.Enabled = True
            End If
        End Sub
        Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFecha.CheckedChanged
            _estadoComprobanteEgresos = If(rbFecha.Checked, 5, 1)
            If rbFecha.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                'gbNumeroCheque.Enabled = False
                txtNumeroCheque.Enabled = False
                'gbRangoFechas.Enabled = True
                dtpDesde.Enabled = True
                dtpHasta.Enabled = True
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
                'gbComandos.Enabled = True
                txtBuscar.Enabled = True
            End If
        End Sub
        Private Sub rbNumeroCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNumeroCheque.CheckedChanged
            _estadoComprobanteEgresos = If(rbNumeroCheque.Checked, 3, 1)
            If rbNumeroCheque.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                txtNumeroCheque.Enabled = True
                txtNumeroCheque.Focus()
                'gbNumeroCheque.Enabled = True
                txtNumeroCheque.Enabled = True
                'gbRangoFechas.Enabled = False
                dtpDesde.Enabled = False
                dtpHasta.Enabled = False
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
                'gbComandos.Enabled = False
                txtBuscar.Enabled = False
            End If
        End Sub
        Private Sub rbAprobados_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAprobados.CheckedChanged
            _estadoComprobanteEgresos = If(rbAprobados.Checked, 2, 1)
            If rbAprobados.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                'gbNumeroCheque.Enabled = False
                txtNumeroCheque.Enabled = False
                'gbRangoFechas.Enabled = True
                dtpDesde.Enabled = True
                dtpHasta.Enabled = True
                'gbComandos.Enabled = True
                txtBuscar.Enabled = True
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False

            End If
        End Sub
        Private Sub rbBanco_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbBanco.CheckedChanged
            _estadoComprobanteEgresos = If(rbBanco.Checked, 6, 1)
            If rbBanco.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                'gbNumeroCheque.Enabled = False
                txtNumeroCheque.Enabled = False
                'gbRangoFechas.Enabled = True
                dtpDesde.Enabled = True
                dtpHasta.Enabled = True
                'gbBanco.Enabled = True
                cmbBancos.Enabled = True
                cmbCuentaBancos.Enabled = True
                'gbComandos.Enabled = True
                txtBuscar.Enabled = True
            End If
        End Sub
        Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodos.CheckedChanged
            _estadoComprobanteEgresos = If(rbTodos.Checked, 4, 1)
            If rbTodos.Checked Then
                txtBuscar.Clear()
                lblIdBeneficiario.Text = "..."
                'gbNumeroCheque.Enabled = False
                txtNumeroCheque.Enabled = False
                'gbRangoFechas.Enabled = False
                dtpDesde.Enabled = False
                dtpHasta.Enabled = False
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
                'gbComandos.Enabled = True
                txtBuscar.Enabled = True
            End If
        End Sub
        Private Sub dgvComprobanteEgresoBancos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobanteEgresoBancos.SelectionChanged
            If dgvComprobanteEgresoBancos.RowCount = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return
            lblIdComprobanteEgresoBanco.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells(0).Value
        End Sub
        Private Sub dgvComprobanteEgresoBancos_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobanteEgresoBancos.CellDoubleClick
            Dim formAsientoDiario As New FormBuscarAsientoDiario
            formAsientoDiario.TipoCox = TipoCox
            formAsientoDiario.NumeroRegsitroBusqueda = dgvComprobanteEgresoBancos.CurrentRow.Cells(14).Value  '_objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgresoBanco.Text)
            DialogResult = formAsientoDiario.ShowDialog
        End Sub
        Private Sub dgvComprobanteEgresoBancos_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvComprobanteEgresoBancos.EditingControlShowing
            Dim itemType = TryCast(e.Control, TextBox)
            If itemType IsNot Nothing Then AddHandler itemType.KeyPress, AddressOf ItemType_KeyPress
        End Sub
        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvComprobanteEgresoBancos.KeyPress
            Select Case dgvComprobanteEgresoBancos.CurrentCell.ColumnIndex
                Case 7
                    If _validacionesAlfanumerica.EsAlfanumerico(e.KeyChar) = True Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
            End Select
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If dgvComprobanteEgresoBancos.Rows.Count > 0 Then
                ActualizarRegistroComprobanteEgresoBancos()
                CargarComprobanteEgresoBancos()

                KryptonMessageBox.Show("Comprobante de egreso de bancos actualizado satisfactoreamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else

                KryptonMessageBox.Show("Por favor cargue comprobantes de egreso", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub ActualizarRegistroComprobanteEgresoBancos()
            For i = 0 To dgvComprobanteEgresoBancos.Rows.Count - 1
                With _objetoComprobanteEgreso
                    .Id = dgvComprobanteEgresoBancos.Rows(i).Cells(0).Value
                    .Concepto = dgvComprobanteEgresoBancos.Rows(i).Cells(7).Value.ToString.ToUpper
                    .ActualizarConceptoComprobanteEgresoBancos(_tipoCon)
                End With
            Next
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvComprobanteEgresoBancos, "COMPROBANTES DE EGRESO")
        End Sub
        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then

                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                'Dim fec = ValidationForms.FechaActual(_tipoCon)

                'Dim app = New Microsoft.Office.Interop.Excel.Application()
                'Dim workbook = app.Workbooks.Add(Type.Missing)
                'Dim worksheet = workbook.Worksheets(1)
                'worksheet.Name = "COMPROBANTES_EGRESO"

                'Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                'worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                'worksheet.Range("A1:" & ic & "1").Merge()
                'worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                'worksheet.Range("A1:" & ic & "1").Font.Bold = True
                'worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                'worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                'worksheet.Range("A1:" & ic & "1").Font.Size = 12
                ''Copete  
                'worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Range("A2:" & ic & "2").Value = cmbBancos.Text & " CTA: " & cmbCuentaBancos.Text & ", PERÍODO: " & dtpDesde.Value.ToLongDateString() & "  AL " & dtpHasta.Value.ToLongDateString()
                'worksheet.Range("A2:" & ic & "2").Font.Size = 12
                ''Fecha  
                'worksheet.Range("A3:" & ic & "3").Merge()
                'worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                'worksheet.Range("A3:" & ic & "3").Font.Size = 12

                ''Aca se ingresa las columnas
                'Dim indc = 1
                'Dim headin = 5
                'For i = 0 To dgvAsientosDiario.Columns.Count - 1
                '    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                '    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                '    worksheet.Cells(headin, indc).Font.Bold = True
                '    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                '    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                '    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                '    worksheet.Cells(headin, indc).Font.Color = Color.White
                '    indc += 1
                'Next

                ''Aca se ingresa el detalle recorrera la tabla celda por celda
                'For i = 0 To dgvAsientosDiario.Rows.Count - 1
                '    indc = 1
                '    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                '        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                '        ' asigna valor a celda
                '        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                '        ' definir bordes
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                '        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                '        indc += 1
                '    Next
                'Next

                'worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                'app.DisplayAlerts = False
                'app.Visible = True
                'app.DisplayAlerts = True

                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                saveFileDialog.Title = "Guardar archivo Excel"
                saveFileDialog.FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"


                If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                    Exit Sub
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim tituloReporte = ValidationForms.NombreCompany(_tipoCon) & " - " & titulo

                ' Crear workbook y worksheet
                Dim workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Comprobante_Egreso")
                Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
                Dim xlColor As XLColor = XLColor.FromColor(colorSistema)
                ' Definir rango para el título
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Cell(1, 1).Value = tituloReporte.ToString()
                worksheet.Cell(1, 1).Style.Font.SetBold(True)
                worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
                worksheet.Cell(1, 1).Style.Font.SetFontColor(XLColor.White)
                worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(xlColor)
                worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Cell(2, 1).Value = $"{cmbBancos.Text} CTA: {cmbCuentaBancos.Text}, PERÍODO: {dtpDesde.Value.ToLongDateString()} AL {dtpHasta.Value.ToLongDateString()}"
                worksheet.Cell(2, 1).Style.Font.SetFontSize(12)

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Cell(3, 1).Value = $"Fecha de Reporte: {fec.ToLongDateString()} {fec.ToLongTimeString()}"
                worksheet.Cell(3, 1).Style.Font.SetFontSize(12)

                ' Encabezados de columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.SetBold(True)
                    worksheet.Cell(headin, indc).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    worksheet.Cell(headin, indc).Style.Fill.SetBackgroundColor(xlColor)
                    worksheet.Cell(headin, indc).Style.Font.SetFontColor(XLColor.White)
                    worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    indc += 1
                Next

                ' Detalle de datos
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' Asignar valor a la celda
                        worksheet.Cell(i + 1 + headin, indc).Value = dgvAsientosDiario.Rows(i).Cells(j).Value.ToString()

                        ' Establecer bordes
                        Dim cell = worksheet.Cell(i + 1 + headin, indc)
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        If i = dgvAsientosDiario.RowCount - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                Next

                ' Ajustar columnas automáticamente
                worksheet.Columns("A:" & ic).AdjustToContents()

                ' Guardar el archivo en una ubicación temporal y abrirlo
                Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), saveFileDialog.FileName)
                ' Guardar el archivo en una ubicación temporal
                workbook.SaveAs(saveFileDialog.FileName)

                ' Abrir el archivo Excel automáticamente
                Process.Start(tempFilePath)

                KryptonMessageBox.Show("Datos exportados correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)


            Catch ex As Exception

                'KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                KryptonMessageBox.Show("Error al exportar " & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim rep = New FormReporteComprobanteEgresoBancos
            rep.TipoCox = TipoCox
            Dim mac = New FormReporteComprobanteEgresoBancoMachala
            mac.TipoCox = TipoCox
            If lblIdComprobanteEgresoBanco.Text <> 0 Then
                If dgvComprobanteEgresoBancos.CurrentRow.Cells(11).Value = "BANCO DE MACHALA" Then
                    If dgvComprobanteEgresoBancos.CurrentRow.Cells(8).Value = "CHEQUE" Then
                        If dgvComprobanteEgresoBancos.CurrentRow.Cells(10).Value < 38001 Then
                            rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                            rep.ShowDialog()
                        Else
                            mac.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                            mac.ShowDialog()
                        End If
                    Else
                        rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                        rep.ShowDialog()
                    End If
                Else
                    rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                    rep.ShowDialog()
                End If
            Else

                KryptonMessageBox.Show("Por favor seleccione un comprobante de egreso", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            Dim rep = New FormReporteComprobanteEgresoBancos
            rep.TipoCox = TipoCox
            Dim mac = New FormReporteComprobanteEgresoBancoMachala
            mac.TipoCox = TipoCox
            If lblIdComprobanteEgresoBanco.Text <> 0 Then
                If dgvComprobanteEgresoBancos.CurrentRow.Cells(11).Value = "BANCO DE MACHALA" Then
                    If dgvComprobanteEgresoBancos.CurrentRow.Cells(8).Value = "CHEQUE" Then
                        If dgvComprobanteEgresoBancos.CurrentRow.Cells(10).Value < 38001 Then
                            rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                            rep.Tipo = 1
                            rep.ShowDialog()
                        Else
                            mac.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                            mac.ShowDialog()
                        End If
                    Else
                        rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                        rep.Tipo = 1
                        rep.ShowDialog()
                    End If
                Else
                    rep.lblIdComprobanteEgreso.Text = lblIdComprobanteEgresoBanco.Text
                    rep.Tipo = 1
                    rep.ShowDialog()
                End If
            Else

                KryptonMessageBox.Show("Por favor seleccione un comprobante de egreso", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub txtBuscar_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyUp
            If e.KeyCode = Keys.Enter Then
                _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"
                CargarComprobanteEgresoBancos()
            End If
        End Sub

        Private Sub btnReporteTodos_Click(sender As Object, e As EventArgs) Handles btnReporteTodos.Click

            Try
                If dgvComprobanteEgresoBancos.Rows.Count > 0 Then

                    Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompra.pdf")
                    PdfViewer1.Document?.Dispose()
                    PdfViewer1.Document = Nothing

                    Dim pdfStream As New MemoryStream()
                    Dim document As New iTextSharp.text.Document(PageSize.A5)
                    Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
                    writer.CloseStream = False
                    document.Open()


                    Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
                    logo.ScaleToFit(30, 30)

                    Dim paginaAgregada As Boolean = False
                    ' Agregar el logo al documento
                    Dim numeroRegistro As Int64 = 0
                    Dim ds As DataSet
                    For Each row As DataGridViewRow In dgvComprobanteEgresoBancos.Rows
                        If row.Cells(11).Value = "BANCO DE MACHALA" Then
                            If row.Cells(8).Value = "CHEQUE" Then
                                If row.Cells(10).Value < 38001 Then





                                End If
                            Else
                                'crea reportedocument.NewPage()
                                paginaAgregada = True

                                'document.Add(logo)
                                'crea reporte

                            End If
                        Else
                            'crea reporte paginaAgregada = True

                            'document.Add(logo)
                            'crea reporte

                            paginaAgregada = True
                            numeroRegistro = objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, row.Cells(0).Value)
                            ds = _objetoComprobanteEgreso.BuscarComporbanteEgresoBancoxIdComprobanteNumeroRegistro2(_tipoCon, numeroRegistro)
                            GenerarReporte(document, writer, logo, row, ds)

                        End If


                    Next

                    If Not paginaAgregada Then
                        KryptonMessageBox.Show("No hay registros para mostrar", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        document.Close()
                        writer.Close()
                        Return
                    End If


                    document.Close()
                    writer.Close()

                    pdfStream.Seek(0, SeekOrigin.Begin)
                    PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
                    PdfViewer1.ZoomMode = 1

                Else
                    KryptonMessageBox.Show("No hay registros para mostrar", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return
                End If


            Catch ex As Exception
                KryptonMessageBox.Show("Hubo un problema al exportar datos! " & ex.Message.ToString(), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End Try



        End Sub
        Private Sub GenerarReporte(document As iTextSharp.text.Document, writer As PdfWriter, logo As iTextSharp.text.Image, row As DataGridViewRow, ds As DataSet)

            Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
            Dim fuente12 As New iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD)
            Dim fuente10 As New iTextSharp.text.Font(baseFont, 10)
            Dim fuente8 As New iTextSharp.text.Font(baseFont, 8)
            Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)


            document.NewPage()


            'document.Add(logo)
            'crea reporte
            Dim headerTable As PdfPTable = New PdfPTable(3)
            headerTable.TotalWidth = 400

            Dim ColumnWidhts As Single() = New Single() {120, 200, 80}
            headerTable.SetWidths(ColumnWidhts)



            Dim idContent As New Phrase()
            idContent.Add(New Chunk("Numero    ", fuente8Bold))
            idContent.Add(New Chunk("   " & row.Cells.Item(0).Value.ToString(), fuente8))
            idContent.Add(New Chunk(vbLf, fuente10))
            idContent.Add(New Chunk(vbLf & "Fecha  ", fuente8Bold))
            idContent.Add(New Chunk(row.Cells.Item(2).Value.ToString(), fuente8))



            Dim idCell As New PdfPCell(idContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            headerTable.AddCell(idCell)

            Dim tituloCell As New PdfPCell(New Phrase("COMPROBANTE DE EGRESO", fuente12)) With {
                            .HorizontalAlignment = Element.ALIGN_CENTER,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            headerTable.AddCell(tituloCell)

            Dim logoCell As New PdfPCell(logo) With {
                            .HorizontalAlignment = Element.ALIGN_CENTER,
                            .VerticalAlignment = Element.ALIGN_CENTER,
                            .Border = PdfPCell.NO_BORDER
                        }
            headerTable.AddCell(logoCell)
            headerTable.WriteSelectedRows(0, -1, 20, 575, writer.DirectContent)

            Dim rectTabla1 As PdfContentByte = writer.DirectContent
            rectTabla1.RoundRectangle(10.0F, 540.0F, 390.0F, 40.0F, 10.0F)
            rectTabla1.Stroke()


            Dim tabla1 As PdfPTable = New PdfPTable(2)
            tabla1.TotalWidth = 400

            Dim ColumnWidhts1 As Single() = New Single() {120, 280}
            tabla1.SetWidths(ColumnWidhts1)

            Dim FacturContent As New Phrase()
            FacturContent.Add(New Chunk("Factura: ", fuente8Bold))
            FacturContent.Add(New Chunk(row.Cells.Item(3).Value.ToString(), fuente8))

            Dim FacturCell As New PdfPCell(FacturContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(FacturCell)


            Dim PagadoAContent As New Phrase()
            PagadoAContent.Add(New Chunk("Pagado a: ", fuente8Bold))
            PagadoAContent.Add(New Chunk(row.Cells.Item(5).Value.ToString(), fuente8))

            Dim PagadoACell As New PdfPCell(PagadoAContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(PagadoACell)


            Dim RucContent As New Phrase()
            RucContent.Add(New Chunk("RUC/CI: ", fuente8Bold))
            RucContent.Add(New Chunk(row.Cells.Item(4).Value.ToString(), fuente8))

            Dim RucCell As New PdfPCell(RucContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(RucCell)


            Dim ConceptoContent As New Phrase()
            ConceptoContent.Add(New Chunk("Concepto: ", fuente8Bold))
            ConceptoContent.Add(New Chunk(row.Cells.Item(7).Value.ToString(), fuente8))

            Dim ConceptoCell As New PdfPCell(ConceptoContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(ConceptoCell)

            Dim ActividadContent As New Phrase()
            ActividadContent.Add(New Chunk("Actividad: ", fuente8Bold))
            ActividadContent.Add(New Chunk(row.Cells.Item(6).Value.ToString(), fuente8))

            Dim ActividadCell As New PdfPCell(ActividadContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(ActividadCell)

            Dim TipoPago As New Phrase()
            TipoPago.Add(New Chunk("Tipo Pago: ", fuente8Bold))
            TipoPago.Add(New Chunk(row.Cells.Item(8).Value.ToString(), fuente8))

            Dim TipoPagoCell As New PdfPCell(TipoPago) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla1.AddCell(TipoPagoCell)

            Dim tabla2 As PdfPTable = New PdfPTable(3)
            tabla2.TotalWidth = 400
            Dim ColumnWidhts2 As Single() = New Single() {120, 120, 160}
            tabla2.SetWidths(ColumnWidhts2)

            Dim BancoContent As New Phrase()
            BancoContent.Add(New Chunk("Banco: ", fuente8Bold))
            BancoContent.Add(New Chunk(row.Cells.Item(11).Value.ToString(), fuente8))

            Dim BancoCell As New PdfPCell(BancoContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla2.AddCell(BancoCell)

            Dim CuentaContent As New Phrase()
            CuentaContent.Add(New Chunk("Cuenta: ", fuente8Bold))
            CuentaContent.Add(New Chunk(row.Cells.Item(12).Value.ToString(), fuente8))

            Dim CuentaCell As New PdfPCell(CuentaContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla2.AddCell(CuentaCell)

            Dim ChequeContent As New Phrase()
            ChequeContent.Add(New Chunk("Cheque: ", fuente8Bold))
            ChequeContent.Add(New Chunk(row.Cells.Item(10).Value.ToString(), fuente8))

            Dim ChequeCell As New PdfPCell(ChequeContent) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER
                        }
            tabla2.AddCell(ChequeCell)

            Dim tabla2cell As PdfPCell = New PdfPCell(tabla2) With {
                            .HorizontalAlignment = Element.ALIGN_LEFT,
                            .VerticalAlignment = Element.ALIGN_MIDDLE,
                            .Border = PdfPCell.NO_BORDER,
                            .Colspan = 2
                        }
            tabla1.AddCell(tabla2cell)



            Dim EspacioVacío1 As New Phrase()
            EspacioVacío1.Add(New Chunk(" ", fuente8))

            Dim EspacioVacíoCell1 As New PdfPCell(EspacioVacío1) With {
                .HorizontalAlignment = Element.ALIGN_LEFT,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER,
                .Colspan = 2
            }
            tabla1.AddCell(EspacioVacíoCell1)

            ' Crear la segunda fila vacía
            Dim EspacioVacío2 As New Phrase()
            EspacioVacío2.Add(New Chunk(" ", fuente8))

            Dim EspacioVacíoCell2 As New PdfPCell(EspacioVacío2) With {
                    .HorizontalAlignment = Element.ALIGN_LEFT,
                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                    .Border = PdfPCell.NO_BORDER,
                    .Colspan = 2
                }
            tabla1.AddCell(EspacioVacíoCell2)

            ' Crear la línea de separación (subrayado)
            Dim LineaSeparacion As New Phrase()
            LineaSeparacion.Add(New Chunk("___________________", fuente8))

            Dim LineaCell As New PdfPCell(LineaSeparacion) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER,
                .Colspan = 2
            }
            tabla1.AddCell(LineaCell)

            ' Agregar el texto "Recibi conforme"
            Dim RecibiConformeContent As New Phrase()
            RecibiConformeContent.Add(New Chunk("Recibi conforme", fuente8Bold))

            Dim RecibiConformeCell As New PdfPCell(RecibiConformeContent) With {
            .HorizontalAlignment = Element.ALIGN_CENTER,
            .VerticalAlignment = Element.ALIGN_MIDDLE,
            .Border = PdfPCell.NO_BORDER,
            .Colspan = 2
            }


            tabla1.AddCell(RecibiConformeCell)


            tabla1.WriteSelectedRows(0, -1, 20, 520, writer.DirectContent)

            'insert 2 row empty

            Dim table2 As New PdfPTable(4)
            table2.TotalWidth = 400
            Dim asientoTable As DataTable = ds.Tables("ASIENTOS_LIBRO_DIARIO")
            Dim columnWidthsTable2() As Single = {80, 180, 70, 70}
            table2.SetWidths(columnWidthsTable2)


            Dim tituloTable2 As New PdfPCell(New Phrase("ASIENTOS DE DIARIO", fuente10)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,
                .Border = PdfPCell.NO_BORDER
            }
            table2.AddCell(tituloTable2)

            Dim emptyCell2 As New PdfPCell(New Phrase(" ", fuente8)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,
                .Border = PdfPCell.NO_BORDER
            }
            tabla2.AddCell(emptyCell2)

            Dim emptyCell3 As New PdfPCell(New Phrase(" ", fuente8)) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Colspan = 4,  ' Ocupa las 4 columnas
                .Border = PdfPCell.NO_BORDER
            }
            table2.AddCell(emptyCell3)

            table2.AddCell(New Phrase("Codigo", fuente8Bold))
            table2.AddCell(New Phrase("Detalle", fuente8Bold))
            table2.AddCell(New Phrase("Debe", fuente8Bold))
            table2.AddCell(New Phrase("Haber", fuente8Bold))


            Dim totalDebe As Decimal = 0
            Dim totalHaber As Decimal = 0

            For Each rowTable As DataRow In asientoTable.Rows
                table2.AddCell(New Phrase(rowTable.Item("CODIGO_CUENTA_ASIENTO").ToString(), fuente8))
                table2.AddCell(New Phrase(rowTable.Item("NOMBRE_CUENTA_ASIENTO").ToString(), fuente8))
                table2.AddCell(New Phrase(rowTable.Item("VALOR_DEBE_ASIENTO").ToString(), fuente8))
                table2.AddCell(New Phrase(rowTable.Item("VALOR_HABER_ASIENTO").ToString(), fuente8))

                totalDebe += rowTable.Item("VALOR_DEBE_ASIENTO")
                totalHaber += rowTable.Item("VALOR_HABER_ASIENTO")

            Next

            table2.WriteSelectedRows(0, -1, 10, 350, writer.DirectContent)

            Dim table3 As New PdfPTable(2)
            Dim columnWidthsTotal() As Single = {70, 70}
            table3.TotalWidth = 140
            Dim table2Height As Single = table2.TotalHeight
            table3.SetWidths(columnWidthsTotal)

            table3.AddCell(New Phrase(totalDebe.ToString("#,##0.00"), fuente8Bold))
            table3.AddCell(New Phrase(totalHaber.ToString("#,##0.00"), fuente8Bold))
            Dim baseY As Single = 350 - table2Height

            table3.WriteSelectedRows(0, -1, 270, baseY, writer.DirectContent)

            Dim table4 As New PdfPTable(3)
            Dim columnWidthsTotal2() As Single = {120, 120, 120}
            table4.TotalWidth = 360
            table4.SetWidths(columnWidthsTotal2)

            Dim LineaSeparacion1 As New Phrase()
            LineaSeparacion1.Add(New Chunk("___________________", fuente8))

            Dim LineaCell1 As New PdfPCell(LineaSeparacion1) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
            table4.AddCell(LineaCell1)

            Dim LineaSeparacion2 As New Phrase()
            LineaSeparacion2.Add(New Chunk("___________________", fuente8))

            Dim LineaCell2 As New PdfPCell(LineaSeparacion2) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
            table4.AddCell(LineaCell2)

            Dim LineaSeparacion3 As New Phrase()
            LineaSeparacion3.Add(New Chunk("___________________", fuente8))

            Dim LineaCell3 As New PdfPCell(LineaSeparacion3) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
            table4.AddCell(LineaCell3)

            Dim Contadora As New Phrase()
            Contadora.Add(New Chunk("Contadora", fuente8Bold))

            Dim ContadoraCell As New PdfPCell(Contadora) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
            table4.AddCell(ContadoraCell)

            Dim Gerente As New Phrase()
            Gerente.Add(New Chunk("Gerente Admin - Finan", fuente8Bold))

            Dim GerenteCell As New PdfPCell(Gerente) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }
            table4.AddCell(GerenteCell)

            Dim GerenteGeneral As New Phrase()
            GerenteGeneral.Add(New Chunk("Gerente General", fuente8Bold))

            Dim GerenteGeneralCell As New PdfPCell(GerenteGeneral) With {
                .HorizontalAlignment = Element.ALIGN_CENTER,
                .VerticalAlignment = Element.ALIGN_MIDDLE,
                .Border = PdfPCell.NO_BORDER
                    }

            table4.AddCell(GerenteGeneralCell)

            table4.WriteSelectedRows(0, -1, 20, 150, writer.DirectContent)


        End Sub

    End Class
End Namespace