Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS  
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports Microsoft.Office.Interop

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRevisionChequesEmitidos

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

        ReadOnly _objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        ReadOnly _objetoChequesEmitidos As New ClassChequesEmitidosCxp
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos
        ReadOnly _objetoBancos As New ClassBancos

        Private _idComprobanteEgresoB As Integer

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "CHEQUES"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
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
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
                If (CType(cmbBancos.DataSource, DataTable).Rows.Count > 0) Then cmbBancos.SelectedIndex = 1
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboCuentas()
            Try
                Dim data = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
                If (CType(cmbCuentaBancos.DataSource, Data.DataTable).Rows.Count > 0) Then cmbCuentaBancos.SelectedIndex = 0
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarChequesEmitidosNoCobrados()
            Try
                If _fechaDesde = "" Then Return

                dgvChequesEmitidosAprobados.DataSource = _objetoChequesEmitidos.BuscarChequesEmitidosNoCobradosXRangoFecha(_tipoCon, _fechaDesde, _fechaHasta, cmbBancos.Text, cmbCuentaBancos.Text)
                dgvChequesEmitidosAprobados.AutoResizeColumns()
                dgvChequesEmitidosAprobados.AutoResizeRows()
                dgvChequesEmitidosAprobados.Columns(2).Width = 90
                dgvChequesEmitidosAprobados.Columns(2).DefaultCellStyle.Format = "d"
                dgvChequesEmitidosAprobados.Columns(6).Width = 480

                For Each col As DataGridViewColumn In dgvChequesEmitidosAprobados.Columns
                    col.ReadOnly = True
                Next
                dgvChequesEmitidosAprobados.Columns(0).ReadOnly = False

            Catch
                dgvChequesEmitidosAprobados.DataSource = Nothing
            End Try
            SumarTotalEmitidosNoCobrados()
        End Sub

        Private Sub CargarChequesEmitidosCobrados()
            Try
                If _fechaDesde = "" Then Return

                dgvEmitidosCobrados.DataSource = _objetoChequesEmitidos.BuscarChequesEmitidosCobradosXRangoFechaCobro(_tipoCon, _fechaDesde, _fechaHasta, cmbBancos.Text, cmbCuentaBancos.Text)
                dgvEmitidosCobrados.ReadOnly = False
                dgvEmitidosCobrados.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvEmitidosCobrados.AutoResizeColumns()
                dgvEmitidosCobrados.Columns(1).DefaultCellStyle.Format = "d"
                dgvEmitidosCobrados.Columns(9).DefaultCellStyle.Format = "d"
                dgvEmitidosCobrados.AutoResizeRows()
                dgvEmitidosCobrados.ReadOnly = True
            Catch
                dgvEmitidosCobrados.DataSource = Nothing
            End Try
            SumarTotalEmitidosCobrados()
        End Sub

        Private Sub CargarChequesEmitidosCaducados()
            Try
                If _fechaDesde = "" Then Return

                dgvEmitidosCaducados.DataSource = _objetoChequesEmitidos.BuscarChequesEmitidosCaducadosXRangoFechaCobro(_tipoCon, _fechaDesde, _fechaHasta, cmbBancos.Text)
                dgvEmitidosCaducados.ReadOnly = False
                dgvEmitidosCaducados.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvEmitidosCaducados.AutoResizeColumns()
                dgvEmitidosCaducados.Columns(1).DefaultCellStyle.Format = "d"
                dgvEmitidosCaducados.Columns(9).DefaultCellStyle.Format = "d"
                dgvEmitidosCaducados.AutoResizeRows()
                dgvEmitidosCaducados.ReadOnly = True
            Catch
                dgvEmitidosCaducados.DataSource = Nothing
            End Try
            SumarTotalEmitidosCaducados()
        End Sub

        Private Sub SumarTotalEmitidosNoCobrados()
            Dim acuTotalNoCobrados As Decimal = 0
            For indice = 0 To dgvChequesEmitidosAprobados.RowCount - 1
                acuTotalNoCobrados += CDec(dgvChequesEmitidosAprobados.Rows(indice).Cells(7).Value)
            Next
            txtTotalEmitidosNoCobrados.Text = acuTotalNoCobrados
            tpEmitidosNoCobrados.Text = "EMITIDOS NO COBRADOS GENERAL: $ " & acuTotalNoCobrados
        End Sub

        Private Sub SumarTotalEmitidosCobrados()
            Dim acuTotalCobrados As Decimal = 0
            For indice = 0 To dgvEmitidosCobrados.RowCount - 1
                acuTotalCobrados += CDec(dgvEmitidosCobrados.Rows(indice).Cells(6).Value)
            Next
            txtTotalEmitidosCobrados.Text = acuTotalCobrados
            tpEmitidosCobrados.Text = "EMITIDOS COBRADOS GENERAL: $ " & acuTotalCobrados
        End Sub

        Private Sub SumarTotalEmitidosCaducados()
            Dim acuTotalCaducados As Decimal = 0
            For indice = 0 To dgvEmitidosCaducados.RowCount - 1
                acuTotalCaducados += CDec(dgvEmitidosCaducados.Rows(indice).Cells(6).Value)
            Next
            tpCaducados.Text = "EMITIDOS CADUCADOS: $ " & acuTotalCaducados
        End Sub

        Private Sub ActualizarChequeEmitidoACobrado()
            For indice = 0 To dgvChequesEmitidosAprobados.RowCount - 1
                If CBool(dgvChequesEmitidosAprobados.Rows(indice).Cells(0).Value) Then
                    With _objetoChequesEmitidos
                        .EstadoCheque = 3 ' 1 = generado ; 2 = aprobado ; 3 = cobrado ; 4 = caducado
                        .FechaCobro = dtpFechaCobroCheque.Value
                        .IdCheque = dgvChequesEmitidosAprobados.Rows(indice).Cells(1).Value
                        .ActualizarEstadoChequesEmitidos(_tipoCon)
                    End With
                End If
            Next
        End Sub

        Private Sub ActualizarChequeEmitidoACaducado()
            For indice = 0 To dgvChequesEmitidosAprobados.RowCount - 1
                If CBool(dgvChequesEmitidosAprobados.Rows(indice).Cells(0).Value) Then
                    With _objetoChequesEmitidos
                        .EstadoCheque = 4 ' 1 = generado ; 2 = aprobado ; 3 = cobrado ; 4 = caducado
                        .FechaCobro = dtpFechaCobroCheque.Value
                        .IdCheque = dgvChequesEmitidosAprobados.Rows(indice).Cells(1).Value
                        .ActualizarEstadoChequesEmitidos(_tipoCon)
                    End With
                End If
            Next
        End Sub

        Private Sub ActualizarMontoCuentaBancos()
            For indice = 0 To dgvChequesEmitidosAprobados.RowCount - 1
                If CBool(dgvChequesEmitidosAprobados.Rows(indice).Cells(0).Value) Then
                    With _objetoCuentaBancos
                        .IdCuentaBancos = .BuscarIdCuentaXNumeroCuenta(_tipoCon, dgvChequesEmitidosAprobados.Rows(indice).Cells(4).Value)
                        .NumeroCuentaBancos = dgvChequesEmitidosAprobados.Rows(indice).Cells(4).Value
                        .MontoCuentaBancos = CDec(dgvChequesEmitidosAprobados.Rows(indice).Cells(7).Value)
                        .ActualizarRestarMontoCuentasBancos(_tipoCon)
                    End With
                End If
            Next
        End Sub

        Private Sub FormRevisionChequesEmitidos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    CrToolStripTextBox1.ForeColor = Color.White
                    CrToolStripTextBox1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEmitidosCaducados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    CrToolStripTextBox1.ForeColor = Color.White
                    CrToolStripTextBox1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEmitidosCaducados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    CrToolStripTextBox1.ForeColor = Color.White
                    CrToolStripTextBox1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEmitidosCobrados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvChequesEmitidosAprobados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEmitidosCaducados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvEmitidosCobrados.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvChequesEmitidosAprobados.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEmitidosCaducados.Font = New Font("Roboto", 8, FontStyle.Regular)

            LlenarComboBancos()

            CargarChequesEmitidosNoCobrados()
          
            CargarChequesEmitidosCobrados()

            CargarChequesEmitidosCaducados()
        End Sub

        Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAprobar.Click
            dgvChequesEmitidosAprobados.EndEdit()

            If dgvChequesEmitidosAprobados.Rows.Count > 0 Then
                If dtpFechaCobroCheque.Value > dtpFechaDesde.Value Then
                    Dim respuestaMsgBox = MessageBox.Show("¿ESTA SEGURO QUE DESEA CAMBIAR LOS CHEQUES SELECCIONADOS A COBRADOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If respuestaMsgBox = MsgBoxResult.Yes Then
                         
                        If chkCaducado.Checked Then
                            ActualizarChequeEmitidoACaducado()
                        Else
                            ActualizarChequeEmitidoACobrado()
                            ActualizarMontoCuentaBancos()
                        End If

                        CargarChequesEmitidosNoCobrados()
                        CargarChequesEmitidosCobrados()
                        CargarChequesEmitidosCaducados()

                        chkCaducado.Checked = False
                    End If
                Else
                    MsgBox("LA FECHA DE COBRO / CADUCIDAD NO PUEDE SER MENOR A LA DE EMISIÓN", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Else
                MsgBox("NO HAY CHEQUES PARA APROBAR NO COBRADOS", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvChequesEmitidosAprobados.Rows.Count > 0 Then
                ExportarDatosExcel(dgvChequesEmitidosAprobados, "CHEQUES GIRADOS NO COBRADOS")
            Else
                MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            If cmbBancos.SelectedValue Is Nothing Or cmbCuentaBancos.SelectedValue Is Nothing Then Return

            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            CargarChequesEmitidosNoCobrados()
            CargarChequesEmitidosCobrados()
            CargarChequesEmitidosCaducados()

        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If _idComprobanteEgresoB <> 0 Then
                Dim f = New FormReporteComprobanteEgresoBancos
                f.TipoCox = TipoCox
                f.lblIdComprobanteEgreso.Text = _idComprobanteEgresoB
                f.ShowDialog()
            Else
                MsgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE EGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub dgvChequesEmitidosAprobados_CellClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvChequesEmitidosAprobados.CellClick
            Try
                If dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteEgresoBanco.Text = ""
                Else
                    _idComprobanteEgresoB = dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(9).Value
                    lblIdComprobanteEgresoBanco.Text = dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(9).Value
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub dgvChequesEmitidosAprobados_CellDoubleClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvChequesEmitidosAprobados.CellDoubleClick
            Try
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                If dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteEgresoBanco.Text = ""
                Else
                    _idComprobanteEgresoB = dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(9).Value
                    lblIdComprobanteEgresoBanco.Text = dgvChequesEmitidosAprobados.CurrentRow.Cells.Item(9).Value

                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgresoBanco.Text)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub dgvEmitidosCobrados_CellClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvEmitidosCobrados.CellClick
            Try
                If dgvEmitidosCobrados.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteEgresoBanco.Text = ""
                Else
                    _idComprobanteEgresoB = dgvEmitidosCobrados.CurrentRow.Cells.Item(8).Value
                    lblIdComprobanteEgresoBanco.Text = dgvEmitidosCobrados.CurrentRow.Cells.Item(8).Value
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub dgvEmitidosCobrados_CellDoubleClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvEmitidosCobrados.CellDoubleClick
            Try
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox

                If dgvEmitidosCobrados.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteEgresoBanco.Text = ""
                Else
                    _idComprobanteEgresoB = dgvEmitidosCobrados.CurrentRow.Cells.Item(8).Value
                    lblIdComprobanteEgresoBanco.Text = dgvEmitidosCobrados.CurrentRow.Cells.Item(8).Value

                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgresoBanco.Text)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub cmbBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBancos.SelectedIndexChanged
            If cmbBancos.SelectedValue Is Nothing Or TypeOf cmbBancos.SelectedValue Is DataRowView Then Return
            LlenarComboCuentas()
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If dgvEmitidosCobrados.Rows.Count > 0 Then
                ExportarDatosExcel(dgvEmitidosCobrados, "CHEQUES GIRADOS COBRADOS")
            Else
                MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If 
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvEmitidosCaducados.Rows.Count > 0 Then
                ExportarDatosExcel(dgvEmitidosCaducados, "CHEQUES GIRADOS CADUCADOS")
            Else
                MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
    End Class
End Namespace