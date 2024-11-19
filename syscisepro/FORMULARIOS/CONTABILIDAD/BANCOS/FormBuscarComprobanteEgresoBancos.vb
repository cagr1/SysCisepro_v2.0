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
            dgvComprobanteEgresoBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
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
                dgvComprobanteEgresoBancos.Font = New Font("Roboto", 9, FontStyle.Regular)

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
                actualizarRegistroComprobanteEgresoBancos()
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

                Dim fec = ValidationForms.FechaActual(_tipoCon)
                 
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "COMPROBANTES_EGRESO"

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
                worksheet.Range("A2:" & ic & "2").Value = cmbBancos.Text & " CTA: " & cmbCuentaBancos.Text & ", PERÍODO: " & dtpDesde.Value.ToLongDateString() & "  AL " & dtpHasta.Value.ToLongDateString()
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

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception

                KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
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
    End Class
End Namespace