Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormItemsBodega
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

        ReadOnly _objCategorias As New ClassCategoriaItem
        ReadOnly _objGrupos As New ClassGrupoItem
        ReadOnly _objSubGrupos As New ClassSubGrupoItem

        Private Sub FormItemsBodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip2.ForeColor = Color.White
                    MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSubGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip2.ForeColor = Color.White
                    MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSubGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip2.ForeColor = Color.White
                    MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSubGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            CargarCategorias()
        End Sub

        Private Sub CargarCategorias()
            Try
                dgvCategoriaItem.DataSource = _objCategorias.SeleccionarCategoriasItemsActivas(_tipoCon)
                dgvCategoriaItem.AutoResizeColumns()
                dgvCategoriaItem.Columns("ESTADO").Visible = False
                dgvCategoriaItem.Columns(0).Width = 50
                dgvCategoriaItem.Columns(1).Width = 238
                dgvCategoriaItem.Columns(2).Width = 80
                dgvCategoriaItem.AutoResizeRows()
            Catch
                dgvCategoriaItem.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvCategoriaItem_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCategoriaItem.SelectionChanged
            CargarGrupos()
        End Sub
        Private Sub CargarGrupos()
            Try
                dgvGrupoItem.DataSource = _objGrupos.SeleccionarGrupoItemsActivasXIdCategoria(_tipoCon, dgvCategoriaItem.CurrentRow.Cells(0).Value)
                dgvGrupoItem.AutoResizeColumns()
                dgvGrupoItem.Columns("ESTADO").Visible = False
                dgvGrupoItem.Columns(0).Width = 30
                dgvGrupoItem.Columns(1).Width = 50
                dgvGrupoItem.Columns(2).Width = 150
                dgvGrupoItem.Columns(3).Width = 80
                dgvGrupoItem.Columns(4).Width = 150
                dgvGrupoItem.Columns(5).Width = 70
                dgvGrupoItem.AutoResizeRows()
            Catch
                dgvGrupoItem.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvGrupoItem_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvGrupoItem.SelectionChanged
            CargarSubGrupos()
        End Sub
        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoCategoría.Click
            BotonesCategorias(False, True, True)
            ParámetrosCategoria("", "")
            HabilitarParámetrosCategoria(False, True, False)
            txtNombreCategoría.Focus()
        End Sub
        Private Sub BotonesCategorias(ByVal nuevaCategorías As Boolean, _
                                     ByVal cancelarCategorías As Boolean, _
                                     ByVal guardarCategorías As Boolean)
            btnNuevoCategoría.Enabled = nuevaCategorías
            btnCancelarCategoría.Enabled = cancelarCategorías
            btnGuardarCategoría.Enabled = guardarCategorías
        End Sub
        Private Sub ParámetrosCategoria(ByVal idCategoría As String, ByVal nombreCategoría As String)
            txtIdCategoría.Text = idCategoría
            txtNombreCategoría.Text = nombreCategoría
        End Sub
        Private Sub HabilitarParámetrosCategoria(ByVal idCategoría As Boolean, ByVal nombreCategoría As Boolean, ByVal lblIdCategoritext As Boolean)
            txtIdCategoría.Enabled = idCategoría
            txtNombreCategoría.Enabled = nombreCategoría
            txtCodigoCategoría.Enabled = lblIdCategoritext
        End Sub
        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarCategoría.Click
            BotonesCategorias(True, False, False)
            ParámetrosCategoria("", "")
            HabilitarParámetrosCategoria(False, False, False)
        End Sub
        Private Function ValidacionParametrosCategorías() As Boolean
            Return txtNombreCategoría.Text.Trim().Length > 0
        End Function
        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCategoría.Click
            If ValidacionParametrosCategorías() Then
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                txtIdCategoría.Text = _objCategorias.BuscarMayorIdCategoriaItem(_tipoCon) + 1 
                With _objCategorias 
                    .IdCategoria = txtIdCategoría.Text
                    .NombreCategoria = txtNombreCategoría.Text.ToUpper
                    .FechaCategoria = Date.Now
                    .EstadoCategoria = 1 
                End With
                _sqlCommands.Add(_objCategorias.NuevaCategoriaItem)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    BotonesCategorias(True, False, False)
                    HabilitarParámetrosCategoria(False, False, False)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("DATO NO GUARDADO, LLENE LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
            End If
            CargarCategorias()
        End Sub
        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvCategoriaItem, "CATEGORIAS")
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoGrupo.Click
            BotonesGrupo(False, True, True)
            ParámetrosGrupo("", "", "", "", "")
            HabilitarParámetrosGrupo(False, True, True, False)
            LlenarCategorías()
            txtNombreGrupo.Focus()
        End Sub
        Private Sub BotonesGrupo(ByVal nuevoGrupo As Boolean, ByVal cancelarGrupo As Boolean, ByVal guardarGrupo As Boolean)
            btnNuevoGrupo.Enabled = nuevoGrupo
            btnCancelarGrupo.Enabled = cancelarGrupo
            btnGuardarGrupo.Enabled = guardarGrupo
        End Sub
        Private Sub ParámetrosGrupo(ByVal idGrupo As String, ByVal cbmCategoriaText As String, ByVal nombreGrupo As String, ByVal lblidCategoríaText As String, ByVal codigoGrupoText As String)
            txtIdGrupo.Text = idGrupo
            cbmCategoría.Text = cbmCategoriaText
            txtNombreGrupo.Text = nombreGrupo
            txtCodigoCategoría.Text = lblidCategoríaText
            txtCódigoGrupo.Text = codigoGrupoText
        End Sub
        Private Sub HabilitarParámetrosGrupo(ByVal idGrupo As Boolean, ByVal cbmCategoriaText As Boolean, ByVal nombreGrupo As Boolean, ByVal txtCodigoGrupo As Boolean)
            txtIdGrupo.Enabled = idGrupo
            cbmCategoría.Enabled = cbmCategoriaText
            txtNombreGrupo.Enabled = nombreGrupo
            txtCódigoGrupo.Enabled = txtCodigoGrupo
        End Sub
        Private Sub LlenarCategorías()
            Try
                cbmCategoría.DataSource = _objCategorias.SeleccionarCategoriasItemsActivas(_tipoCon)
                cbmCategoría.DisplayMember = "NOMBRE CATEGORÍA"
                cbmCategoría.ValueMember = "NOMBRE CATEGORÍA"
            Catch
                cbmCategoría.DataSource = Nothing
            End Try
        End Sub
        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarGrupo.Click
            cbmCategoría.DataSource = Nothing
            BotonesGrupo(True, False, False)
            ParámetrosGrupo("", "SELECCIONE CATEGORÍA", "", "", "")
            HabilitarParámetrosGrupo(False, False, False, False)
        End Sub
        Private Function ValidacionParametrosGrupos() As Boolean
            Return txtNombreGrupo.Text.Trim().Length > 0 And cbmCategoría.Text <> "SELECCIONE CATEGORÍA" And cbmCategoría.Text.Trim().Length > 0 And txtCodigoCategoría.Text <> "0"
        End Function
        Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarGrupo.Click
            If ValidacionParametrosGrupos() Then
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                txtIdGrupo.Text = _objGrupos.BuscarMayorIdGrupoItem(_tipoCon) + 1
                With _objGrupos
                    .IdGrupo = txtIdGrupo.Text
                    .NombreGrupo = txtNombreGrupo.Text.ToUpper
                    .FechaGrupo = Date.Now
                    .EstadoGrupo = 1
                    .IdCategoria = CLng(txtCodigoCategoría.Text)
                    .CodigoGrupo = txtCodigoCategoría.Text.Trim + "." + txtCódigoGrupo.Text
                End With 
                _sqlCommands.Add(_objGrupos.NuevaGrupoItem)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    BotonesGrupo(True, False, False)
                    ParámetrosGrupo("", "SELECCIONE CATEGORÍA", "", "0", "0")
                    HabilitarParámetrosGrupo(False, False, False, False)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("DATO NO GUARDADO, LLENE LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
            End If
            CargarGrupos()
        End Sub
        Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarGrupos.Click
            ExportarDatosExcel(dgvGrupoItem, "GRUPO DE ITEMS DE BODEGA")
        End Sub
        Private Sub LlenarGrupo()
            Try
                cbmGrupo.DataSource = _objGrupos.SeleccionarGrupoItemsActivas(_tipoCon)
                cbmGrupo.DisplayMember = "NOMBRE GRUPO"
                cbmGrupo.ValueMember = "NOMBRE GRUPO"
            Catch
                cbmGrupo.DataSource = Nothing
            End Try
        End Sub
        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSubGrupo.Click
            BotonesSubGrupo(False, True, True)
            ParámetrosSubGrupo("", "", "", "", "")
            HabilitarParámetrosSubGrupo(False, True, True)
            txtNombreSubGrupo.Focus()
            LlenarGrupo()
        End Sub
        Private Sub BotonesSubGrupo(ByVal nuevoSubGrupo As Boolean, ByVal cancelarSubGrupo As Boolean, ByVal guardarSubGrupo As Boolean)
            btnNuevoSubGrupo.Enabled = nuevoSubGrupo
            btnCancelarSubGrupo.Enabled = cancelarSubGrupo
            btnGuardarSubGrupo.Enabled = guardarSubGrupo
        End Sub
        Private Sub ParámetrosSubGrupo(ByVal idSubGrupo As String, ByVal cbmGrupoText As String, ByVal nombreSubGrupo As String, ByVal txtCodigoGrupoText As String, ByVal codigoSubGrupoText As String)
            txtIdSubGrupo.Text = idSubGrupo
            cbmGrupo.Text = cbmGrupoText
            txtNombreSubGrupo.Text = nombreSubGrupo
            txtCodigoGrupo.Text = txtCodigoGrupoText
            txtCodigoSubGrupo.Text = codigoSubGrupoText
        End Sub
        Private Sub HabilitarParámetrosSubGrupo(ByVal idSubGrupo As Boolean, ByVal cbmGrupoText As Boolean, ByVal nombreSubGrupo As Boolean)
            txtIdSubGrupo.Enabled = idSubGrupo
            cbmGrupo.Enabled = cbmGrupoText
            txtNombreSubGrupo.Enabled = nombreSubGrupo
        End Sub
        Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarSubGrupo.Click
            cbmGrupo.DataSource = Nothing
            BotonesSubGrupo(True, False, False)
            ParámetrosSubGrupo("", "SELECCIONE GRUPO", "", "", "")
            HabilitarParámetrosSubGrupo(False, False, False)
        End Sub
        Private Sub ToolStripMenuItem2_Click_2(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSubGrupo.Click
            If ValidacionParametrosSubGrupos() Then
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                txtIdSubGrupo.Text = _objSubGrupos.BuscarMayorIdSubGrupoItem(_tipoCon) + 1
                With _objSubGrupos
                    .IdSubGrupo = CInt(txtIdSubGrupo.Text) + 1
                    .NombreSubGrupo = txtNombreSubGrupo.Text.ToUpper
                    .FechaSubGrupo = Date.Now
                    .EstadoSubGrupo = 1
                    .IdGrupoSubGrupo = _objGrupos.BuscarIdGrupoItemXnombreGrupoItem(_tipoCon, cbmGrupo.Text)
                    .CodigoSubGrupo = txtCodigoGrupo.Text + "." + txtCodigoSubGrupo.Text
                End With 
                _sqlCommands.Add(_objSubGrupos.NuevaSubGrupoItem)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    BotonesSubGrupo(True, False, False)
                    ParámetrosSubGrupo("", "SELECCIONE GRUPO", "", "0", "0")
                    HabilitarParámetrosSubGrupo(False, False, False)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("DATO NO GUARDADO, LLENE LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
            End If
            CargarSubGrupos()
        End Sub
        Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportarSubGrupo.Click
            ExportarDatosExcel(dgvSubGrupoItem, "SUBGRUPO")
        End Sub
        Private Sub CargarSubGrupos()
            Try
                dgvSubGrupoItem.DataSource = _objSubGrupos.SeleccionarSubGrupoItemsActivasXIdGrupo(_tipoCon, dgvGrupoItem.CurrentRow.Cells(0).Value)
                dgvSubGrupoItem.AutoResizeColumns()
                dgvSubGrupoItem.Columns("ESTADO").Visible = False
                dgvSubGrupoItem.Columns(0).Width = 30
                dgvSubGrupoItem.Columns(1).Width = 50
                dgvSubGrupoItem.Columns(2).Width = 150
                dgvSubGrupoItem.Columns(3).Width = 80
                dgvSubGrupoItem.Columns(4).Width = 148
                dgvSubGrupoItem.Columns(5).Width = 70
                dgvSubGrupoItem.AutoResizeRows()
            Catch
                dgvSubGrupoItem.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo.SelectedIndexChanged
            Try
                Dim ig = _objGrupos.BuscarIdGrupoItemXnombreGrupoItem(_tipoCon, cbmGrupo.Text)
                txtCodigoGrupo.Text = ig
                txtCodigoSubGrupo.Text = CType(_objSubGrupos.BuscarMayorCodigoSubGrupoItemXidGrupo(_tipoCon, ig), Int64) + 1
            Catch
                txtCodigoGrupo.Text = "0"
                txtCodigoSubGrupo.Text = "0"
            End Try
        End Sub
        Private Sub cbmCategoría_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoría.SelectedIndexChanged
            Try
                txtCodigoCategoría.Text = _objCategorias.BuscarIdCategoriaItemXnombreCategoriaItem(_tipoCon, cbmCategoría.Text)
                txtCódigoGrupo.Text = CType(_objGrupos.BuscarIdCategoriaItemXidGrupoItem(_tipoCon, _objGrupos.BuscarMayorCodigoGrupoItemXidCategoria(_tipoCon, _objCategorias.BuscarIdCategoriaItemXnombreCategoriaItem(_tipoCon, cbmCategoría.Text))), Int64) + 1
            Catch
                txtCodigoCategoría.Text = "0"
                txtCódigoGrupo.Text = "0"
            End Try
        End Sub
        Private Function ValidacionParametrosSubGrupos() As Boolean
            Return txtNombreSubGrupo.Text <> Nothing And cbmGrupo.Text <> "SELECCIONE GRUPO" And cbmGrupo.Text <> Nothing And txtCodigoGrupo.Text <> "0"
        End Function

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)

            Dim app As Excel._Application = New Excel.Application()
            Dim workbook As Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel._Worksheet = workbook.ActiveSheet

            worksheet.Name = titulo

            worksheet.Range("A1:Z" & dataGridViewExp.RowCount + 25).Font.Size = 10

            Dim ic As String
            If dataGridViewExp.ColumnCount = 4 Then
                ic = "D"
            Else
                ic = "G"
            End If

            worksheet.Range("A1:" & ic & "1").Merge()
            worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Bold = True
            worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
            worksheet.Range("A1:" & ic & "1").Font.Size = 12
            'Copete  
            worksheet.Range("A2:" & ic & "2").Merge()
            worksheet.Range("A2:" & ic & "2").Value = titulo
            worksheet.Range("A2:" & ic & "2").Font.Size = 12
            'Fecha  
            worksheet.Range("A3:" & ic & "3").Merge()
            worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " + Date.Now
            worksheet.Range("A3:" & ic & "3").Font.Size = 12



            'Aca se agregan las cabeceras de nuestro datagrid.
            Dim head = 4

            For i = 1 To dataGridViewExp.Columns.Count
                'worksheet.Cells(1 + head, i) = DataGridViewExp.Columns(i - 1).HeaderText
                'worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i) = dataGridViewExp.Columns(i - 1).HeaderText
                worksheet.Cells(1 + head, i).Font.Bold = True
                worksheet.Cells(1 + head, i).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(1 + head, i).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(1 + head, i).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(1 + head, i).Font.Color = Color.White
            Next

            'Aca se ingresa el detalle recorrera la tabla celda por celda 
            Dim dataGridViewExpRowCount = 0
            For Each row As DataGridViewRow In dataGridViewExp.Rows
                If row.Visible Then
                    For j = 0 To dataGridViewExp.Columns.Count - 1
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1) = row.Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If dataGridViewExpRowCount = dataGridViewExp.RowCount - 1 Then
                            worksheet.Cells(dataGridViewExpRowCount + 2 + head, j + 1).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        End If
                    Next
                    dataGridViewExpRowCount += 1
                End If
            Next

            worksheet.Range("A1:Z" & dataGridViewExpRowCount + 25).Columns.AutoFit()

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub
    End Class
End Namespace