Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarComprobanteIngresoBaNcos
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

        Dim _idComprobanteIngresoB As Integer

        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoComprobanteIngreso As New ClassComprobanteIngresoBanco
        ReadOnly _objetoNumeroRegistroAsientoCompIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso

        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos

        Dim _tipoBusqueda As Integer = 0
        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)
                 
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "COMPROBANTES_INGRESO"

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
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!\n" & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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

        Private Sub AutocompletarConsorcioCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.AutocompletarConsorcio(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboCuentasBancos()
            Dim data = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
            cmbCuentaBancos.DataSource = data
            If cmbCuentaBancos.Items.Count = 0 Then
                cmbCuentaBancos.Text = "NINGUNA CUENTA"
            Else
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            End If
        End Sub

        Private Sub CargarComprobanteIngresoBancos()
            Try
                If _tipoBusqueda = 1 Then
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.SeleccionarComprobanteIngresoBancos(_tipoCon)
                ElseIf _tipoBusqueda = 2 Then
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusqueda = 3 Then
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXIdBancoIdCuentaRangoFecha(_tipoCon, CInt(cmbBancos.SelectedValue), CInt(cmbCuentaBancos.SelectedValue), _fechaDesde, _fechaHasta)
                ElseIf _tipoBusqueda = 4 Then
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXIClienteRangoFecha(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusqueda = 5 Then
                    dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXConsorcioRangoFecha(_tipoCon, txtNombreComercialClienteGeneral.Text, _fechaDesde, _fechaHasta)
                End If

                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()
                dgvComprobanteEgresoBancos.Font = New Font("Roboto", 9, FontStyle.Regular)
                dgvComprobanteEgresoBancos.Columns("FACTURAS").Width = 250
                dgvComprobanteEgresoBancos.Columns("CLIENTE").Width = 250
                dgvComprobanteEgresoBancos.Columns("OBSERVACION").Width = 250

                dgvComprobanteEgresoBancos.ReadOnly = True
                dgvComprobanteEgresoBancos.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvComprobanteEgresoBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub SumarTotal()
            Dim acumulador As Decimal = 0
            For indice = 0 To dgvComprobanteEgresoBancos.Rows.Count - 1
                acumulador = acumulador + CDec(dgvComprobanteEgresoBancos.Rows(indice).Cells("VALOR").Value)
            Next
            txtTotalComprobantesIngreso.Text = acumulador
        End Sub

        Private Sub FormBuscarComprobanteIngresoBaNCOS_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'set font robot dgvComporbanteEgresoBancos

            End Select
             
            llenarComboBancos()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"
            cargarComprobanteIngresoBancos()
            sumarTotal()
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvComprobanteEgresoBancos, "COMPROBANTES DE INGRESO")
        End Sub

        Private Sub dgvComprobanteEgresoBancos_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobanteEgresoBancos.CellDoubleClick
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return

            Dim formAsientoDiario As New FormBuscarAsientoDiario
            formAsientoDiario.TipoCox = TipoCox
            If dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteIngresoBanco.Text = ""
            Else
                _idComprobanteIngresoB = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value
                lblIdComprobanteIngresoBanco.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value

                formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoCompIngreso.BuscarNumeroRegistroAsientoPorIdComprobanteIngreso(_tipoCon, lblIdComprobanteIngresoBanco.Text)
                DialogResult = formAsientoDiario.ShowDialog
            End If
        End Sub

        Private Sub rbTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodo.CheckedChanged
            If rbTodo.Checked = True Then
                _tipoBusqueda = 1
                gbClienteGeneral.Enabled = False
                gbRangoFechas.Enabled = False
                gbBanco.Enabled = False
            End If
        End Sub

        Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFecha.CheckedChanged
            If rbFecha.Checked = True Then
                _tipoBusqueda = 2
                gbRangoFechas.Enabled = True
                gbClienteGeneral.Enabled = False
                gbBanco.Enabled = False
            End If
        End Sub

        Private Sub rbBanco_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbBanco.CheckedChanged
            If rbBanco.Checked = True Then
                _tipoBusqueda = 3
                gbBanco.Enabled = True
                gbClienteGeneral.Enabled = False
                gbRangoFechas.Enabled = True
            End If
        End Sub
        Private Sub rbCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCliente.CheckedChanged
            If rbCliente.Checked = True Then
                _tipoBusqueda = 4
                gbClienteGeneral.Enabled = True
                gbBanco.Enabled = False
                gbRangoFechas.Enabled = True
                autocompletarNombreCliente()
            End If
        End Sub
        Private Sub rbConsorcio_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbConsorcio.CheckedChanged
            If rbConsorcio.Checked = True Then
                _tipoBusqueda = 5
                gbClienteGeneral.Enabled = True
                gbBanco.Enabled = False
                gbRangoFechas.Enabled = True
                autocompletarConsorcioCliente()
            End If
        End Sub
         
        Private Sub txtNombreComercialClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyUp
            If e.KeyCode = Keys.Enter Then
                If rbCliente.Checked = True Then
                    lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
                End If
            End If
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If _idComprobanteIngresoB <> 0 Then
                Dim f = New FormReporteComprobanteIngresoBancos
                f.TipoCox = TipoCox
                f.lblIdComprobanteIngreso.Text = _idComprobanteIngresoB
                f.Show()
            Else
                MsgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE INGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub dgvComprobanteEgresoBancos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobanteEgresoBancos.SelectionChanged
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return
            Try
                If dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteIngresoBanco.Text = ""
                Else
                    _idComprobanteIngresoB = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value
                    lblIdComprobanteIngresoBanco.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
            If _idComprobanteIngresoB <> 0 Then
                Dim f = New FormReporteComprobanteIngresoBancos
                f.TipoCox = TipoCox
                f.Tipo = 1
                f.lblIdComprobanteIngreso.Text = _idComprobanteIngresoB
                f.Show()
            Else
                MsgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE INGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedValueChanged
            If cmbBancos.SelectedValue Is Nothing Or TypeOf cmbBancos.SelectedValue Is DataRowView Then Return
            LlenarComboCuentasBancos()
        End Sub
    End Class
End Namespace