Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.BODEGA
Imports ClassLibraryCisepro.INVENTARIOS.UBICACIONES
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormUbicacionesBodega
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

        ReadOnly _objBodegas As New ClassBodega
        ReadOnly _objCategorias As New ClassCategoriaUbicacionItem
        ReadOnly _objGrupos As New ClassGrupoUbicacionItem
        ReadOnly _objSubGrupos As New ClassSubGrupoUbicacionItem
        
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Private Sub Auditoria()
            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub

        Private Sub CargarCategorias()
            Try
                dgvCategoriaItem.DataSource = _objCategorias.SeleccionarCategoriasUbicacionItemsActivas(_tipoCon)
                dgvCategoriaItem.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvCategoriaItem.AutoResizeColumns()
                dgvCategoriaItem.AutoResizeRows()
                dgvCategoriaItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                dgvCategoriaItem.Columns("ESTADO").Visible = False

                dgvCategoriaItem.Columns(0).Width = 50
                dgvCategoriaItem.Columns(1).Width = 50
                dgvCategoriaItem.Columns(2).Width = 70
                dgvCategoriaItem.Columns(3).Width = 50
                dgvCategoriaItem.Columns(4).Width = 50
                dgvCategoriaItem.Columns(5).Width = 50
                dgvCategoriaItem.Columns(6).Width = 200
                dgvCategoriaItem.Columns(7).Width = 150
                dgvCategoriaItem.Columns(8).Width = 150
                dgvCategoriaItem.Columns(9).Width = 300
            Catch
                dgvCategoriaItem.DataSource = Nothing
            End Try 
        End Sub

        Private Sub CargarFilas()
            Try
                dgvGrupoItem.DataSource = _objGrupos.SeleccionarGrupoUbicacionItemsActivas(_tipoCon)

                dgvGrupoItem.Columns("ESTADO").Visible = False

                dgvGrupoItem.ReadOnly = False
                dgvGrupoItem.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvGrupoItem.AutoResizeColumns()
                dgvGrupoItem.AutoResizeRows()
                dgvGrupoItem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                dgvGrupoItem.Columns(0).Width = 50
                dgvGrupoItem.Columns(1).Width = 50
                dgvGrupoItem.Columns(2).Width = 70
                dgvGrupoItem.Columns(3).Width = 70
                dgvGrupoItem.Columns(4).Width = 70
                dgvGrupoItem.Columns(5).Width = 80
                dgvGrupoItem.Columns(6).Width = 80
                dgvGrupoItem.Columns(7).Width = 150
            Catch
                dgvGrupoItem.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarBodegas()
            Try
                cbmBodega.DataSource = _objBodegas.SeleccionarBodegasActivas(_tipoCon)
                cbmBodega.DisplayMember = "BODEGA"
                cbmBodega.ValueMember = "CÓDIGO"
            Catch
                cbmBodega.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarBodegasGrupo()
            Try
                cbmBodegaGrupo.DataSource = _objBodegas.SeleccionarBodegasActivas(_tipoCon)
                cbmBodegaGrupo.DisplayMember = "BODEGA"
                cbmBodegaGrupo.ValueMember = "BODEGA"
                cbmBodegaGrupo.DropDownWidth = 400
            Catch
                cbmBodegaGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarGrupoxIdBodega(ByVal idBodega As Int64)
            Try
                cbmCategoría.DataSource = _objGrupos.SeleccionarGrupoUbicacionItemsActivasXidBodegas(_tipoCon, idBodega)
                cbmCategoría.DisplayMember = "NOMBRE_CATEGORIA_UBICACION"
                cbmCategoría.ValueMember = "NOMBRE_CATEGORIA_UBICACION"
            Catch
                cbmCategoría.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarIdBodega()
            Try 
                txtNombreCategoría.Text = _objCategorias.ContarMayorIdBodegaxIdBodega(_tipoCon, CType(cbmBodega.SelectedValue, Int64)) + 1
            Catch ex As Exception
                txtNombreCategoría.Text = 0 
            End Try
        End Sub

        Private Sub LlenarIdBodegaGrupo()
            Try
                cbmBodegaGrupo.Tag = _objBodegas.BuscarIdBodegaXnombreBodega(_tipoCon, cbmBodegaGrupo.Text)
            Catch ex As Exception
                cbmBodegaGrupo.Tag = 0 
            End Try
        End Sub

        Private Sub LlenarIdCategoria()
            Try
                If cbmBodega.Text <> "" Then
                    cbmCategoría.Tag = _objCategorias.BuscaridCategoriaUbicacionXNombreXidBodega(_tipoCon, cbmCategoría.Text, CType(cbmBodegaGrupo.Tag, Int64))
                End If
            Catch ex As Exception
                cbmCategoría.Tag = 0 
            End Try
        End Sub

        Private Sub ParámetrosCategoria(ByVal idCategoría As String, _
                                       ByVal nombreCategoría As String, _
                                       ByVal cantidadCategoría As Integer, _
                                       ByVal cbmBodegaText As String )
            txtIdCategoría.Text = idCategoría
            txtNombreCategoría.Text = nombreCategoría
            nudFilas.Value = cantidadCategoría
            cbmBodega.Text = cbmBodegaText
        End Sub

        Private Sub ParámetrosGrupo(ByVal idGrupo As String, _
                                   ByVal cbmCategoriaText As String, _
                                   ByVal nombreGrupo As String, _
                                   ByVal nudCasillerosText As Integer, _
                                   ByVal cbmBodegasGrupoText As String)
            txtIdGrupo.Text = idGrupo
            cbmCategoría.Text = cbmCategoriaText
            txtNombreGrupo.Text = nombreGrupo
            nudCasilleros.Value = nudCasillerosText
            cbmBodegaGrupo.Text = cbmBodegasGrupoText
        End Sub

        Private Sub HabilitarParámetrosCategoria(ByVal idCategoría As Boolean, _
                                                ByVal nombreCategoría As Boolean, _                                               
                                                ByVal nudCategoriaValue As Boolean, ByVal cbmBodegaEnable As Boolean)
            txtIdCategoría.Enabled = idCategoría
            txtNombreCategoría.Enabled = nombreCategoría
            nudFilas.Enabled = nudCategoriaValue
            cbmBodega.Enabled = cbmBodegaEnable
        End Sub

        Private Sub HabilitarParámetrosGrupo(ByVal idGrupo As Boolean, _
                                            ByVal cbmCategoriaText As Boolean, _
                                            ByVal nombreGrupo As Boolean, _
                                            ByVal nudCasillerosText As Boolean, _
                                            ByVal cbmBodegaGrupoText As Boolean)
            txtIdGrupo.Enabled = idGrupo
            cbmCategoría.Enabled = cbmCategoriaText
            txtNombreGrupo.Enabled = nombreGrupo
            nudCasilleros.Enabled = nudCasillerosText
            cbmBodegaGrupo.Enabled = cbmBodegaGrupoText
        End Sub

        Private Sub BotonesCategorias(ByVal nuevaCategorías As Boolean, _
                                     ByVal cancelarCategorías As Boolean, _
                                     ByVal guardarCategorías As Boolean)
            btnNuevoCategoría.Enabled = nuevaCategorías
            btnCancelarCategoría.Enabled = cancelarCategorías
            btnGuardarCategoría.Enabled = guardarCategorías
        End Sub

        Private Sub BotonesGrupo(ByVal nuevoGrupo As Boolean, _
                                ByVal cancelarGrupo As Boolean, _
                                ByVal guardarGrupo As Boolean)
            btnNuevoGrupo.Enabled = nuevoGrupo
            btnCancelarGrupo.Enabled = cancelarGrupo
            btnGuardarGrupo.Enabled = guardarGrupo
        End Sub

        Private Function ValidacionParametrosCategorías() As Boolean
            If txtIdCategoría.Text <> Nothing And _
               txtNombreCategoría.Text <> Nothing And _
               nudFilas.Value > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function ValidacionParametrosGrupos() As Boolean
            If txtIdGrupo.Text <> Nothing And _
               txtNombreGrupo.Text <> Nothing And _
               cbmCategoría.Text <> "SELECCIONE CATEGORÍA" And _
               cbmCategoría.Text <> Nothing And
                  nudCasilleros.Value > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub cbmBodega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmBodega.SelectedIndexChanged
            LlenarIdBodega()
        End Sub

        Private Sub cbmCategoría_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoría.SelectedIndexChanged
            Dim objSerie As New ClassGenerarSerie
            LlenarIdCategoria()

            Try
                txtNombreGrupo.Text = objSerie.SerieCambiaLetras(_objGrupos.ContarNombreXidGrupoXidBodega(_tipoCon, CType(cbmCategoría.Tag, Int64), CType(cbmBodegaGrupo.Tag, Int64)) + 1)
            Catch ex As Exception
                txtNombreGrupo.Text = "0" 
            End Try
        End Sub

        Private Sub cbmBodegaGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmBodegaGrupo.SelectedIndexChanged
            LlenarIdBodegaGrupo()
            LlenarGrupoxIdBodega(CInt(cbmBodegaGrupo.Tag))
        End Sub

        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoCategoría.Click
            BotonesCategorias(False, True, True)
            ParámetrosCategoria("", "", 0, "")
            HabilitarParámetrosCategoria(False, False, True, True)
            LlenarBodegas()
            With _objCategorias 
                txtIdCategoría.Text = .BuscarMayorIdCategoriaUbicacionItem(_tipoCon) + 1
            End With
            txtNombreCategoría.Focus()
        End Sub

        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarCategoría.Click
            BotonesCategorias(True, False, False)
            ParámetrosCategoria("", "", 0, "") 
            HabilitarParámetrosCategoria(False, False, False, False)
        End Sub

        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCategoría.Click
            If ValidacionParametrosCategorías() Then
                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()
                With _objCategorias
                    .IdCategoriaUbicacion = .BuscarMayorIdCategoriaUbicacionItem(_tipoCon) + 1
                    .NombreCategoriaUbicacion = txtNombreCategoría.Text.ToUpper
                    .FechaCategoriaUbicacion = Date.Now
                    .EstadoCategoriaUbicacion = 1
                    .FilasTotal = nudFilas.Value
                    .FilasUsadas = 0
                    .FilasVacias = nudFilas.Value
                    .IdBodega = CType(cbmBodega.SelectedValue, Int64)
                End With
                _sqlCommands.Add(_objCategorias.NuevaCategoriaUbicacionItem)

                _objAuditoria.AccionAuditoria = "NUEVA PERCHA CREADA CON REGISTRO N°: " + CType(_objCategorias.IdCategoriaUbicacion, String)
                Auditoria()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    BotonesCategorias(True, False, False)
                    ParámetrosCategoria("", "", 0, "")
                    HabilitarParámetrosCategoria(False, False, False, False)
                    CargarCategorias()

                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema") 
                
            Else
                MsgBox("DATO NO GUARDADO, LLENE LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Information, "Mensaje de validación")
            End If 
        End Sub

        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoGrupo.Click
            BotonesGrupo(False, True, True)
            ParámetrosGrupo("", "", "", 0, "")
            HabilitarParámetrosGrupo(False, True, False, True, True)
            LlenarBodegasGrupo()
            With _objGrupos
                txtIdGrupo.Text = .BuscarMayorIdGrupoUbicacionItem(_tipoCon) + 1
            End With
        End Sub

        Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarGrupo.Click
            If ValidacionParametrosGrupos() Then
                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()
                With _objGrupos
                    .IdGrupoUbicacion = .BuscarMayorIdGrupoUbicacionItem(_tipoCon) + 1
                    .NombreGrupoUbicacion = txtNombreGrupo.Text.ToUpper
                    .FechaGrupoUbicacion = Date.Now
                    .EstadoGrupoUbicacion = 1
                    .IdCategoriaUbicacion = CType(cbmCategoría.Tag, Int64)
                    .CasillerosTotal = CType(nudCasilleros.Value, Integer)
                    .CasillerosUsados = 0
                    .CasilleroVacios = CType(nudCasilleros.Value, Integer)
                    .IdBodegas = CInt(cbmBodegaGrupo.Tag)
                End With
                _sqlCommands.Add(_objGrupos.NuevaGrupoUbicacionItem)
                _objAuditoria.AccionAuditoria = "NUEVO FILA CREADA CON REGISTRO N°: " + CType(_objGrupos.IdGrupoUbicacion, String)

                Auditoria()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    dgvGrupoItem.Enabled = True
                    CargarFilas()
                    BotonesGrupo(True, False, False)
                    ParámetrosGrupo("", "SELECCIONE PERCHA", "", 0, "SELECCIONE BODEGA")
                    HabilitarParámetrosGrupo(False, False, False, False, False)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Else
                MsgBox("DATO NO GUARDADO, LLENE LOS PARÁMETROS NECESARIOS", MsgBoxStyle.Information, "Mensaje de validación")
            End If
        End Sub

        Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarGrupo.Click
            cbmBodegaGrupo.Tag = 0
            cbmCategoría.Tag = 0
            BotonesGrupo(True, False, False)
            ParámetrosGrupo("", "SELECCIONE PERCHA", "", 0, "SELECCIONE BODEGA")
            HabilitarParámetrosGrupo(False, False, False, False, False)
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            cargarCategorias()
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            CargarFilas()
        End Sub

        Private Sub dgvGrupoItem_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvGrupoItem.SelectionChanged
            Try
                If dgvGrupoItem.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then

                Else
                    dgvCasilleros.DataSource = _objSubGrupos.SeleccionarSubGrupoUbicacionXidGrupoUbicacion(_tipoCon, dgvGrupoItem.CurrentRow.Cells.Item(0).Value.ToString.ToUpper)

                    dgvCasilleros.EditMode = DataGridViewEditMode.EditProgrammatically
                    dgvCasilleros.AutoResizeColumns()
                    dgvCasilleros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    dgvCasilleros.Columns(0).Width = 50
                    dgvCasilleros.Columns(1).Width = 80
                    dgvCasilleros.Columns(2).Width = 80
                    dgvCasilleros.Columns(3).Width = 50
                    dgvCasilleros.Columns(4).Width = 200

                End If
            Catch
                dgvCasilleros.DataSource = Nothing
            End Try
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            Dim percha As String = dgvGrupoItem.CurrentRow.Cells.Item(3).Value
            Dim fila As String = dgvGrupoItem.CurrentRow.Cells.Item(1).Value
            Dim idGrupoUbicacion As Integer = dgvGrupoItem.CurrentRow.Cells.Item(0).Value

            If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            With _objSubGrupos
                .IdSubGrupoUbicacion = .BuscarMayorIdSubGrupoUbicacionItem(_tipoCon) + 1
                .NombreSubGrupoUbicacion = percha & fila & .IdSubGrupoUbicacion
                .FechaSubGrupoUbicacion = Date.Now
                .EstadoSubGrupoUbicacion = 1
                .IdGrupoSubGrupoUbicacion = idGrupoUbicacion 
            End With
            _sqlCommands.Add(_objSubGrupos.NuevaSubGrupoUbicacion)

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty) 
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub FormUbicacionesBodega_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Button1.ForeColor = Color.White
                    Button1.BackColor = My.MySettingsProperty.Settings.ColorAsenava 
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCasilleros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Button1.ForeColor = Color.White
                    Button1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCasilleros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Button1.ForeColor = Color.White
                    Button1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCategoriaItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvGrupoItem.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCasilleros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCategoriaItem.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvGrupoItem.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvCasilleros.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
        End Sub
    End Class
End NameSpace