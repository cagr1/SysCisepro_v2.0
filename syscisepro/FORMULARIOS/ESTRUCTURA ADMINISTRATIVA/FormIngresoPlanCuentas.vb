Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports ClosedXML.Excel
Imports System.IO

Namespace FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA
    ''' <summary>
    ''' CISEPRO 2019
    ''' </summary>
    Public Class FormIngresoPlanCuentas
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
        Public IdUsuario As Integer

        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas

        ReadOnly _objAsiento As New ClassAsientosLibroDiario
        ReadOnly _objetoEmpresa As New ClassEmpresa
        Private ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Dim _botonSeleccionado As Integer 

        Private Sub FormIngresoPlanCuentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPlanDeCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvPlanDeCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvPlanDeCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvPlanDeCuentas.Font = New Font("Roboto", 8, FontStyle.Regular)

            LlenarComboEmpresa()

        End Sub
        '==============================================================================================================================================================================
        Private Sub CargarCuentas()
            Try
                dgvPlanDeCuentas.DataSource = _objetoPlanCuentas.SeleccionarTodosLosRegistrosPlanDeCuentas(_tipoCon)
               
                dgvPlanDeCuentas.Columns(0).Width = 50
                dgvPlanDeCuentas.Columns(1).Width = 100
                dgvPlanDeCuentas.Columns(2).Width = 480
                dgvPlanDeCuentas.Columns(3).Width = 50
                dgvPlanDeCuentas.Columns(4).Width = 100
                dgvPlanDeCuentas.Columns(5).Width = 50
                dgvPlanDeCuentas.Columns(6).Width = 50
                dgvPlanDeCuentas.Columns(7).Width = 50
                dgvPlanDeCuentas.Columns(8).Visible = False
                dgvPlanDeCuentas.Columns(9).Width = 50
                dgvPlanDeCuentas.Columns(10).Visible = False

                dgvPlanDeCuentas.ReadOnly = False
                dgvPlanDeCuentas.EditMode = DataGridViewEditMode.EditProgrammatically

                For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvPlanDeCuentas.Rows Where row1.Cells(3).Value < 3
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                Next

                dgvPlanDeCuentas.AutoResizeRows()
            Catch
                dgvPlanDeCuentas.DataSource = Nothing
            End Try
        End Sub
        '=============================================================================================================================================================================
        Private Sub LlenarComboEmpresa()
            Try
                cbmEmpresa.DataSource = _objetoEmpresa.SeleccionarTodosLosRegistrosEmpresa(_tipoCon)
                cbmEmpresa.DisplayMember = "NOMBRE_COMERCIAL_EMPRESA"
                cbmEmpresa.ValueMember = "NOMBRE_COMERCIAL_EMPRESA"
            Catch
                cbmEmpresa.DataSource = Nothing
            End Try
        End Sub

        Private Sub LimpiarParametros()
            txtIdPlan.Text = ""
            txtCodigo.Text = ""
            txtDetalle.Text = ""
            txtPadre.Text = ""
            cbmTipo.Text = ""
            cbmNivel.Text = ""
            cbmMovimiento.Text = ""
            cbmPresupuesto.Text = ""
            cbmMovimiento.Text = ""
            cbmEmpresa.Text = ""
            cbmEstadoContable.Text = ""
        End Sub
        '=============================================================================================================================================================================
        Private Sub HabilitarBotones(ByVal botonNuevo As Boolean, ByVal botonModificar As Boolean, ByVal botonGuardar As Boolean, ByVal botonCancelar As Boolean)
            btnNuevo.Enabled = botonNuevo
            btnModificar.Enabled = botonModificar
            btnGuardar.Enabled = botonGuardar
            btnCancelar.Enabled = botonCancelar
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            _botonSeleccionado = 1
            LimpiarParametros()
            LlenarComboEmpresa()

            txtIdPlan.Text = _objetoPlanCuentas.BuscarMayorIdPlan(_tipoCon) + 1
            HabilitarBotones(False, False, True, True)
            HabilitarRegistro()
        End Sub
        '=============================================================================================================================================================================
        Private Sub HabilitarRegistro()
            txtCodigo.Enabled = True
            txtDetalle.Enabled = True
            cbmNivel.Enabled = True
            txtPadre.Enabled = True
            cbmMovimiento.Enabled = True
            cbmPresupuesto.Enabled = True
            cbmTipo.Enabled = True
            cbmEmpresa.Enabled = True
            cbmEstadoContable.Enabled = True
            txtCodigo.Focus()
        End Sub
        '=============================================================================================================================================================================
        Private Sub DeshabilitarRegistro()
            txtCodigo.Enabled = False
            txtDetalle.Enabled = False
            cbmNivel.Enabled = False
            txtPadre.Enabled = False
            cbmMovimiento.Enabled = False
            cbmPresupuesto.Enabled = False
            cbmTipo.Enabled = False
            cbmEmpresa.Enabled = False
            cbmEstadoContable.Enabled = False
        End Sub
        '=============================================================================================================================================================================
        Private Function ValidacionParametros() As Boolean
            Return txtIdPlan.Text <> "" And txtCodigo.Text <> "" And txtDetalle.Text <> "" And cbmNivel.Text <> "" And txtPadre.Text <> "" And cbmMovimiento.Text <> "" And cbmPresupuesto.Text <> "" And cbmTipo.Text <> "" And cbmEmpresa.Text <> "" And cbmEstadoContable.Text <> ""
        End Function
        '==============================================================================================================================================================================
        Private Sub Auditoria()
            With _objAuditoria
                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = Date.Now
                .NuevaAuditoria(_tipoCon)
            End With
        End Sub
        '==============================================================================================================================================================================
        Private Sub GuardarRegistroNuevo()
            Dim year = 0
            Dim numeroRegistro = 0

            Dim showBox As Boolean
            showBox = True
            While showBox = True
                Dim response = InputBox("INGRESE EL VALOR DEL COMPROBANTE", "VALOR BANCO", Date.Now.Year, , )
                If response = "" Then
                    showBox = True
                Else
                    If IsNumeric(response) = True Then
                        year = CType(response, Integer) ' <-- Recibe el valor del Imputbox
                        If year > Date.Now.Year Then
                            'MsgBox("EL AÑO INGRESADO NO PUEDE SER MAYOR AL AÑO EN CURSO", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("EL AÑO INGRESADO NO PUEDE SER MAYOR AL AÑO EN CURSO", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        ElseIf (Date.Now.Year - year) > 1 Then
                            'MsgBox("NO PUEDE HABER MAS DE UN AÑO DE DIFERENCIA DEL AÑO INGRESADO CON EL AÑO EN CURSO", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("NO PUEDE HABER MAS DE UN AÑO DE DIFERENCIA DEL AÑO INGRESADO CON EL AÑO EN CURSO", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Else
                            Dim n = _objAsiento.BuscarMayorNuneroRegistroAsientoInicialLibroDiarioXFecha(_tipoCon, year.ToString + "-01-01 00:00:01", year.ToString + "-01-01 23:59:59")
                            If n = 0 Then
                                numeroRegistro = _objAsiento.BuscarMayorNuneroRegistroAsientoInicialLibroDiario(_tipoCon) + 1
                            Else
                                numeroRegistro = n
                            End If

                            showBox = False
                        End If
                    Else
                        'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS ENTEROS", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("POR FAVOR INGRESE SOLO NÚMEROS ENTEROS", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                End If
            End While


            If _objetoPlanCuentas.BuscarNivelPlanCuentasPorCodigo(_tipoCon, txtPadre.Text) + 1 = cbmNivel.Text Then
                With _objetoPlanCuentas
                    .IdPlan = .BuscarMayorIdPlan(_tipoCon) + 1
                    .Codigo = txtCodigo.Text
                    .Detalle = txtDetalle.Text.Trim.ToUpper
                    .Nivel = cbmNivel.Text.Trim
                    .PadreCuentas = txtPadre.Text
                    .Movimiento = cbmMovimiento.Text.Trim.ToUpper
                    .Presupuesto = cbmPresupuesto.Text.Trim.ToUpper
                    .Tipo = cbmTipo.Text
                    .IdEmpresa = _objetoEmpresa.BuscarIdEmpresaPorNombre(_tipoCon, cbmEmpresa.Text.Trim)
                    .Estado = 1
                    .EstadoContable = cbmEstadoContable.Text
                    .NuevaRegistroPlanDeCuentas(_tipoCon)
                    DeshabilitarRegistro()
                End With
                With _objAsiento
                    .IdAsiento = .BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
                    .FechaAsiento = year.ToString + "-01-01 12:00:00"
                    .CodigoCuentaAsiento = txtCodigo.Text.Trim
                    .NombreCuentaAsiento = txtDetalle.Text.ToUpper.Trim
                    .ConceptoAsiento = "ACTUALIZACIÓN PLAN DE CUENTAS"
                    .DetalleTransaccionAsiento = "INGRESO DE CUENTA, ESTADO DE SITUACIÓN INICIAL"
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = "SUPERVICION MACHALA"
                    .ValorDebeAsiento = 0.0
                    .ValorHaberAsiento = 0.0
                    .NumeroRegistroAsiento = numeroRegistro
                    .DebeHaberAsiento = 1
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = 1
                    .EstadoMayorAsiento = 1
                    .NuevoRegistroAsientoLibroDiario(_tipoCon)
                End With
                _objAuditoria.AccionAuditoria = "CREO UNA NUEVA CUENTA " + txtIdPlan.Text
                _objAuditoria.FormularioAuditoria = Text.ToUpper
                Auditoria()
            Else
                'MsgBox("EL NIVEL DE LA CUENTA DEBE SER UNO MAS QUE LA CUENTA PADRE", MsgBoxStyle.Exclamation, "Mensaje de validación.")
                KryptonMessageBox.Show("EL NIVEL DE LA CUENTA DEBE SER UNO MAS QUE LA CUENTA PADRE", "Mensaje de validación.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        '==============================================================================================================================================================================
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            'If MessageBox.Show("Seguro que desea guardar los cambios realizados?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If KryptonMessageBox.Show("Seguro que desea guardar los cambios realizados?", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If

            Try
                If ValidacionParametros() Then
                    Select Case (_botonSeleccionado)
                        Case 1 : GuardarRegistroNuevo()
                        Case 2 : GuardarRegistroModificado()
                    End Select
                    HabilitarBotones(True, True, False, False)
                    CargarCuentas()
                Else
                    'MsgBox("No se puede guardar debido a que no ha llenado todos los campos nesesarios", MsgBoxStyle.Information, "Mensaje de validación")
                    KryptonMessageBox.Show("No se puede guardar debido a que no ha llenado todos los campos nesesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    txtCodigo.Focus()
                End If
            Catch ex As Exception

            End Try
        End Sub
        '==============================================================================================================================================================================
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            txtCodigo.Text = ""
            HabilitarBotones(True, True, False, False)
            DeshabilitarRegistro()
            _botonSeleccionado = 0
            DeshabilitarRegistro()
        End Sub
        '==============================================================================================================================================================================
        Private Sub GuardarRegistroModificado()
            With _objetoPlanCuentas
                .IdPlan = txtIdPlan.Text
                .Codigo = txtCodigo.Text
                .Detalle = txtDetalle.Text.Trim.ToUpper
                .Nivel = cbmNivel.Text.Trim
                .PadreCuentas = txtPadre.Text
                .Movimiento = cbmMovimiento.Text.Trim.ToUpper
                .Presupuesto = cbmPresupuesto.Text.Trim.ToUpper
                .Tipo = cbmTipo.Text
                .IdEmpresa = _objetoEmpresa.BuscarIdEmpresaPorNombre(_tipoCon, cbmEmpresa.Text.Trim)
                .Estado = 1
                .EstadoContable = cbmEstadoContable.Text
                .ModificarRegistroPlanDeCuentas(_tipoCon)
                DeshabilitarRegistro()
            End With
            _objAuditoria.AccionAuditoria = "ACTUALIZO LA CUENTA " + txtIdPlan.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub
        '==============================================================================================================================================================================
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            _botonSeleccionado = 2
            LlenarComboEmpresa()
            HabilitarBotones(False, False, True, True)
            HabilitarRegistro()
        End Sub

        Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodas.CheckedChanged
            If rbTodas.Checked Then
                txtBuscar.Text = ""
                txtBuscar.Enabled = False
                CargarCuentas()
            End If
        End Sub

        Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCodigo.CheckedChanged
            If rbCodigo.Checked Then
                txtBuscar.Text = "" : txtBuscar.Enabled = True
                txtBuscar.Focus()
            End If
        End Sub

        Private Sub rbCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCuenta.CheckedChanged
            If rbCuenta.Checked Then
                txtBuscar.Text = "" : txtBuscar.Enabled = True
                txtBuscar.Focus()
            End If
        End Sub

        Private Sub txtBuscar_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtBuscar.KeyUp
            If rbCodigo.Checked = True Then
                dgvPlanDeCuentas.DataSource = _objetoPlanCuentas.SeleccionarTodosLosRegistrosPlanDeCuentasxCodigo(_tipoCon, txtBuscar.Text.Trim)
            End If
            If rbCuenta.Checked Then
                dgvPlanDeCuentas.DataSource = _objetoPlanCuentas.SeleccionarTodosLosRegistrosPlanDeCuentasxDetalle(_tipoCon, txtBuscar.Text.Trim)
            End If

            dgvPlanDeCuentas.Columns(0).Width = 50
            dgvPlanDeCuentas.Columns(1).Width = 100
            dgvPlanDeCuentas.Columns(2).Width = 480
            dgvPlanDeCuentas.Columns(3).Width = 50
            dgvPlanDeCuentas.Columns(4).Width = 100
            dgvPlanDeCuentas.Columns(5).Width = 50
            dgvPlanDeCuentas.Columns(6).Width = 50
            dgvPlanDeCuentas.Columns(7).Width = 50
            dgvPlanDeCuentas.Columns(8).Visible = False
            dgvPlanDeCuentas.Columns(9).Width = 50
            dgvPlanDeCuentas.Columns(10).Visible = False

            dgvPlanDeCuentas.ReadOnly = False
            dgvPlanDeCuentas.EditMode = DataGridViewEditMode.EditProgrammatically

            For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvPlanDeCuentas.Rows Where row1.Cells(3).Value < 3
                row.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8, FontStyle.Bold)
            Next

            dgvPlanDeCuentas.AutoResizeRows()
        End Sub

        Private Sub dgvPlanDeCuentas_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvPlanDeCuentas.SelectionChanged
            Try
                If dgvPlanDeCuentas.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    txtIdPlan.Text = ""
                Else
                    txtIdPlan.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(0).Value
                    txtCodigo.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(1).Value.ToString.ToUpper
                    txtDetalle.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(2).Value.ToString.ToUpper
                    cbmNivel.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(3).Value
                    txtPadre.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(4).Value.ToString.ToUpper
                    cbmMovimiento.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(5).Value.ToString.ToUpper
                    cbmPresupuesto.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(6).Value.ToString.ToUpper
                    cbmTipo.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(7).Value

                    cbmEmpresa.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(8).Value.ToString.ToUpper

                    cbmEstadoContable.Text = dgvPlanDeCuentas.CurrentRow.Cells.Item(10).Value
                    dgvPlanDeCuentas.Rows(dgvPlanDeCuentas.CurrentCell.RowIndex.ToString()).Selected = True
                    btnModificar.Enabled = True
                End If
            Catch ex As Exception
                txtIdPlan.Text = "ERROR"
            End Try
        End Sub

        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            CargarCuentas()
            LlenarComboEmpresa()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            Try
                If dgvPlanDeCuentas.Rows.Count = 0 Then
                    'MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                'Dim fec = ValidationForms.FechaActual(_tipoCon)

                'Dim app = New Microsoft.Office.Interop.Excel.Application()
                'Dim workbook = app.Workbooks.Add(Type.Missing)
                'Dim worksheet = workbook.Worksheets(1)
                'worksheet.Name = "PLAN_CUENTAS"

                'Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvPlanDeCuentas)
                'worksheet.Range("A1:" & ic & (dgvPlanDeCuentas.RowCount + 50)).Font.Size = 10

                'worksheet.Range("A1:" & ic & "1").Merge()
                'worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  PLAN DE CUENTAS"
                'worksheet.Range("A1:" & ic & "1").Font.Bold = True
                'worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                'worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                'worksheet.Range("A1:" & ic & "1").Font.Size = 12
                ''Copete  
                'worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: AL " & fec.ToLongDateString()
                'worksheet.Range("A2:" & ic & "2").Font.Size = 12
                ''Fecha  
                'worksheet.Range("A3:" & ic & "3").Merge()
                'worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                'worksheet.Range("A3:" & ic & "3").Font.Size = 12

                ''Aca se ingresa las columnas
                'Dim indc = 1
                'Dim headin = 5
                'For i = 0 To dgvPlanDeCuentas.Columns.Count - 1
                '    If Not dgvPlanDeCuentas.Columns(i).Visible Then Continue For
                '    worksheet.Cells(headin, indc) = dgvPlanDeCuentas.Columns(i).HeaderText
                '    worksheet.Cells(headin, indc).Font.Bold = True
                '    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                '    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                '    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                '    worksheet.Cells(headin, indc).Font.Color = Color.White
                '    indc += 1
                'Next

                ''Aca se ingresa el detalle recorrera la tabla celda por celda
                'For i = 0 To dgvPlanDeCuentas.Rows.Count - 1
                '    indc = 1
                '    For j = 0 To dgvPlanDeCuentas.Columns.Count - 1

                '        If Not dgvPlanDeCuentas.Columns(j).Visible Then Continue For

                '        ' asigna valor a celda
                '        worksheet.Cells(i + 1 + headin, indc) = dgvPlanDeCuentas.Rows(i).Cells(j).Value

                '        ' definir bordes
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                '        If i = dgvPlanDeCuentas.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                '        indc += 1
                '    Next
                'Next

                'worksheet.Range("A1:" & ic & (dgvPlanDeCuentas.RowCount + 50)).Columns.AutoFit()

                'app.DisplayAlerts = False
                'app.Visible = True
                'app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                saveFileDialog.Title = "Guardar archivo Excel"
                saveFileDialog.FileName = $"PlanCuentas_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"


                If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                    Exit Sub
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim tituloReporte = ValidationForms.NombreCompany(_tipoCon) & " - " & "Plan de Cuentas"

                ' Crear workbook y worksheet
                Dim workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("COMPROBANTES_EGRESO")
                Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
                Dim xlColor As XLColor = XLColor.FromColor(colorSistema)
                ' Definir rango para el título
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvPlanDeCuentas)
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Cell(1, 1).Value = tituloReporte.ToString()
                worksheet.Cell(1, 1).Style.Font.SetBold(True)
                worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
                worksheet.Cell(1, 1).Style.Font.SetFontColor(XLColor.White)
                worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(xlColor)
                worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Cell(2, 1).Value = $"{cmbBancos.Text} CTA: {cmbCuentaBancos.Text}, PERÍODO: {dtpDesde.Value.ToLongDateString()} AL {dtpHasta.Value.ToLongDateString()}"
                worksheet.Cell(2, 1).Value = $"PERÍODO: AL {fec.ToLongDateString()}"
                worksheet.Cell(2, 1).Style.Font.SetFontSize(12)

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Cell(3, 1).Value = $"Fecha de Reporte: {fec.ToLongDateString()} {fec.ToLongTimeString()}"
                worksheet.Cell(3, 1).Style.Font.SetFontSize(12)

                ' Encabezados de columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvPlanDeCuentas.Columns.Count - 1
                    If Not dgvPlanDeCuentas.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvPlanDeCuentas.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.SetBold(True)
                    worksheet.Cell(headin, indc).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    worksheet.Cell(headin, indc).Style.Fill.SetBackgroundColor(xlColor)
                    worksheet.Cell(headin, indc).Style.Font.SetFontColor(XLColor.White)
                    worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    indc += 1
                Next

                ' Detalle de datos
                For i = 0 To dgvPlanDeCuentas.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvPlanDeCuentas.Columns.Count - 1
                        If Not dgvPlanDeCuentas.Columns(j).Visible Then Continue For

                        ' Asignar valor a la celda
                        worksheet.Cell(i + 1 + headin, indc).Value = dgvPlanDeCuentas.Rows(i).Cells(j).Value.ToString()

                        ' Establecer bordes
                        Dim cell = worksheet.Cell(i + 1 + headin, indc)
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        If i = dgvPlanDeCuentas.RowCount - 1 Then
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



            Catch
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace