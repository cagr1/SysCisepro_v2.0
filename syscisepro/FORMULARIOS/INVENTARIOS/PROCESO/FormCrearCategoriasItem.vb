Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCrearCategoriasItem
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

        ReadOnly _objCategoria As New ClassCategoriaItem
        ReadOnly _objGrupo As New ClassGrupoItem
        ReadOnly _objSubGrupo As New ClassSubGrupoItem

        Private Sub CargarCategorías()
            Try
                cbmCategoría.DataSource = _objCategoria.SeleccionarCategoriasItemsActivas(_tipoCon)
                cbmCategoría.DisplayMember = "NOMBRE CATEGORÍA"
                cbmCategoría.ValueMember = "NOMBRE CATEGORÍA"
                cbmCategoría.DropDownWidth = 400
            Catch
                cbmCategoría.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarGrupos()
            Try
                cbmGrupo.DataSource = _objGrupo.SeleccionarGrupoItemsActivas(_tipoCon)
                cbmGrupo.DisplayMember = "NOMBRE GRUPO"
                cbmGrupo.ValueMember = "NOMBRE GRUPO"
                cbmGrupo.DropDownWidth = 400
            Catch
                cbmGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnNuevaCategoría_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevaCategoría.Click
            btnNuevaCategoría.Enabled = False
            btnCancelarCategoría.Enabled = True
            btnGuardarCategoría.Enabled = True

            txtNombreCategoria.Enabled = True
            txtNombreCategoria.Text = ""
            txtNombreCategoria.Focus()
        End Sub

        Private Sub btnGuardarCategoría_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCategoría.Click

            If txtNombreCategoria.Text.Trim().Length > 0 Then
                With _objCategoria
                    .IdCategoria = .BuscarMayorIdCategoriaItem(_tipoCon) + 1
                    .NombreCategoria = txtNombreCategoria.Text.Trim.ToUpper
                    .EstadoCategoria = 1
                    .FechaCategoria = Date.Now
                    .NuevaCategoriaItem(_tipoCon)
                End With

                btnCancelarCategoría.Enabled = False
                btnGuardarCategoría.Enabled = False
                btnNuevaCategoría.Enabled = True
                txtNombreCategoria.Enabled = False
            Else
                MsgBox("No ha llenado los parámetros necesarios para crear una Categoría nueva", MsgBoxStyle.Critical, "Mensaje de validación")
            End If
        End Sub

        Private Sub btnCancelarCategoría_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarCategoría.Click
            btnCancelarCategoría.Enabled = False
            btnGuardarCategoría.Enabled = False
            btnNuevaCategoría.Enabled = True
            txtNombreCategoria.Enabled = False
        End Sub

        Private Sub btnNuevoGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoGrupo.Click
            cbmCategoría.Enabled = True
            txtNombreGrupo.Enabled = True
            txtNombreGrupo.Text = ""
            btnNuevoGrupo.Enabled = False
            btnCancelarGrupo.Enabled = True
            btnGuardarGrupo.Enabled = True
            CargarCategorías()
        End Sub

        Private Sub btnGuardarGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarGrupo.Click
            If cbmCategoría.Text <> "" And cbmCategoría.Text <> "SELECCIONE CATEGORÍA" And lblIdCategoría.Text <> "0000" And txtNombreGrupo.Text <> "" Then
                With _objGrupo

                    .IdGrupo = .BuscarMayorIdGrupoItem(_tipoCon) + 1
                    .NombreGrupo = txtNombreGrupo.Text.Trim.ToUpper
                    .FechaGrupo = Date.Now
                    .IdCategoria = CType(lblIdCategoría.Text, Integer)


                    .CodigoGrupo = lblIdCategoría.Text & "." & CType(_objGrupo.BuscarMayorCodigoGrupoItemXidCategoria(_tipoCon, _objCategoria.BuscarIdCategoriaItemXnombreCategoriaItem(_tipoCon, cbmCategoría.Text)) + 1, String)
                    .EstadoGrupo = 1
                    .NuevaGrupoItem(_tipoCon)
                End With
                btnNuevoGrupo.Enabled = True
                btnCancelarGrupo.Enabled = False
                btnGuardarGrupo.Enabled = False

                cbmCategoría.DataSource = Nothing
                cbmCategoría.Enabled = False
                txtNombreGrupo.Enabled = False
            Else
                MsgBox("No ha llenado los parámetros necesarios para crear un Grupo nuevo", MsgBoxStyle.Critical, "Mensaje de validación")
                txtNombreGrupo.Focus()
            End If
        End Sub

        Private Sub btnCancelarGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarGrupo.Click
            btnNuevoGrupo.Enabled = True
            btnCancelarGrupo.Enabled = False
            btnGuardarGrupo.Enabled = False
            cbmCategoría.DataSource = Nothing
            cbmCategoría.Enabled = False
            txtNombreGrupo.Enabled = False
        End Sub

        Private Sub btnNuevoSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSubGrupo.Click
            btnNuevoSubGrupo.Enabled = False
            btnCancelarSubGrupo.Enabled = True
            btnGuardarSubGrupo.Enabled = True
            CargarGrupos()
            CargarIdGrupo()
            cbmGrupo.Enabled = True
            txtNombreSubGrupo.Enabled = True
            txtNombreSubGrupo.Text = ""
            txtNombreSubGrupo.Focus()
        End Sub

        Private Sub CargarIdGrupo()
            lblIdGrupo.Text = _objGrupo.BuscarIdGrupoItemXnombreGrupoItem(_tipoCon, cbmGrupo.Text.Trim)
        End Sub

        Private Sub btnGuardarSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSubGrupo.Click
            If cbmGrupo.Text <> "SELECCIONE GRUPO" And cbmGrupo.Text <> "" And lblIdGrupo.Text <> "" Then

                With _objSubGrupo

                    .IdSubGrupo = .BuscarMayorIdSubGrupoItem(True) + 1

                    .CodigoSubGrupo = CType(_objGrupo.BuscarCodigoGrupoItemXidGrupoItem(_tipoCon, lblIdGrupo.Text), String) & "." & CType((.BuscarMayorCodigoSubGrupoItemXidGrupo(_tipoCon, lblIdGrupo.Text) + 1), String)
                    .NombreSubGrupo = txtNombreSubGrupo.Text.Trim.ToUpper
                    .FechaSubGrupo = Date.Now
                    .IdGrupoSubGrupo = lblIdGrupo.Text
                    .EstadoSubGrupo = 1
                    .NuevaSubGrupoItem(_tipoCon)
                End With
                btnNuevoSubGrupo.Enabled = True
                btnCancelarSubGrupo.Enabled = False
                btnGuardarSubGrupo.Enabled = False
                cbmGrupo.Enabled = False
                txtNombreSubGrupo.Enabled = False
            Else
                MsgBox("No ha llenado los parámetros necesarios para crear un Sub Grupo nuevo", MsgBoxStyle.Critical, "Mensaje de validación")
                txtNombreSubGrupo.Focus()
            End If
        End Sub

        Private Sub btnCancelarSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarSubGrupo.Click
            btnNuevoSubGrupo.Enabled = True
            btnCancelarSubGrupo.Enabled = False
            btnGuardarSubGrupo.Enabled = True
            cbmGrupo.DataSource = Nothing
            txtNombreSubGrupo.Enabled = False
            cbmGrupo.Enabled = False
        End Sub

        Private Sub CargarIdCategoría()
            lblIdCategoría.Text = _objCategoria.BuscarIdCategoriaItemXnombreCategoriaItem(_tipoCon, cbmCategoría.Text.Trim)
        End Sub

        Private Sub cbmCategoría_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoría.SelectedValueChanged
            CargarIdCategoría()
        End Sub

        Private Sub cbmCategoría_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoría.SelectionChangeCommitted
            cbmCategoría.Enabled = False
        End Sub

        Private Sub lblCategoría_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCategoría.DoubleClick
            cbmCategoría.Enabled = True
        End Sub

        Private Sub lblGrupo_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblGrupo.DoubleClick
            cbmGrupo.Enabled = True
        End Sub

        Private Sub cbmGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo.SelectedIndexChanged
            CargarIdGrupo()
        End Sub

        Private Sub cbmGrupo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo.SelectionChangeCommitted
            cbmGrupo.Enabled = False
        End Sub

        Private Sub lblIdCategoría_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblIdCategoría.Click
            Dim formCrearItems As New FormCrearCategoriasItem
            formCrearItems.TipoCox = TipoCox
            formCrearItems.ShowDialog()
        End Sub

        Private Sub txtNombreCategoria_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreCategoria.KeyDown
            Try
                dgvPrevio.DataSource = _objCategoria.SeleccionarCategoriasItemsActivas(_tipoCon)
                dgvPrevio.AutoResizeRows()
                dgvPrevio.AutoResizeColumns()
            Catch
                dgvPrevio.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtNombreGrupo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreGrupo.KeyDown
            Try
                dgvPrevio.DataSource = _objGrupo.SeleccionarGrupoItemsActivas(_tipoCon)
                dgvPrevio.AutoResizeRows()
                dgvPrevio.AutoResizeColumns()
            Catch
                dgvPrevio.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtNombreSubGrupo_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreSubGrupo.KeyDown
            Try
                dgvPrevio.DataSource = _objSubGrupo.SeleccionarSubGrupoItemsActivas(_tipoCon)
                dgvPrevio.AutoResizeRows()
                dgvPrevio.AutoResizeColumns()
            Catch
                dgvPrevio.DataSource = Nothing
            End Try
        End Sub

        Private Sub FormCrearCategoriasItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvPrevio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvPrevio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvPrevio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
        End Sub
    End Class
End Namespace