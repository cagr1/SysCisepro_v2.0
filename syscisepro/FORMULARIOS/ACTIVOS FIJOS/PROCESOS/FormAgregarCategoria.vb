Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.JERARQUIAS_DE_ACTIVOS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAgregarCategoria
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

        ReadOnly _objetoCategoria As New ClassCategoria()
        ReadOnly _objetoGrupo As New ClassGrupo()
        ReadOnly _objetoSubGrupo As New ClassSubGrupo()
        ReadOnly _objetoSecuencial As New ClassSecuencial()
        ReadOnly _objetoValidacionesNumeros As New ClassNumerico()
        ReadOnly _objetoValidacionesAlfanumerico As New ClassAlfanumerico

        Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnVolver.Click
            DialogResult = DialogResult.OK
        End Sub

        Private Sub FormAgregarCategoria_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvCategoria.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSubgrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                    dgvCategoria.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSubgrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c 
                    dgvCategoria.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSubgrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvGrupos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            MostrarTodosRegistrosCategoria()
            MostrarTodosRegistrosGrupo()
            MostrarTodosRegistrosSubGrupo()
            MostrarTodosRegistrosSecuencial() 
        End Sub

        Private Sub MostrarTodosRegistrosCategoria()
            dgvCategoria.DataSource = _objetoCategoria.CargarDatosCategoria(_tipoCon)
            dgvCategoria.AutoResizeColumns()
            dgvCategoria.AutoResizeRows() 
            dgvCategoria.Columns("ID_CATEGORIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCategoria.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCategoria.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCategoria.ReadOnly = False
            dgvCategoria.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub MostrarTodosRegistrosGrupo()
            dgvGrupos.DataSource = _objetoGrupo.CargarDatosGrupo(_tipoCon)
            dgvGrupos.AutoResizeColumns()
            dgvGrupos.AutoResizeRows() 
            dgvGrupos.Columns("ID_GRUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvGrupos.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvGrupos.Columns("ID_CATEGORIA_GRUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvGrupos.ReadOnly = False
            dgvGrupos.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub MostrarTodosRegistrosSubGrupo()
            dgvSubgrupos.DataSource = _objetoSubGrupo.CargarDatosSubGrupo(_tipoCon)
            dgvSubgrupos.AutoResizeColumns()
            dgvSubgrupos.AutoResizeRows() 
            dgvSubgrupos.Columns("ID_SUB_GRUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSubgrupos.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSubgrupos.Columns("ID_GRUPO_SUB_GRUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSubgrupos.ReadOnly = False
            dgvSubgrupos.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub MostrarTodosRegistrosSecuencial()
            dgvSecuencial.DataSource = _objetoSecuencial.CargarDatosSecuencial(_tipoCon)
            dgvSecuencial.AutoResizeColumns()
            dgvSecuencial.AutoResizeRows() 
            dgvSecuencial.Columns("ID_SECUENCIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSecuencial.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSecuencial.Columns("ID_SUB_GRUPO_SECUENCIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvSecuencial.ReadOnly = False
            dgvSecuencial.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub LlenarComboCategoriaGrupo()
            cbmCategoriaGrupo.DataSource = _objetoCategoria.CargarDatosCategoria(_tipoCon)
            cbmCategoriaGrupo.DisplayMember = "NOMBRE_CATEGORIA"
            cbmCategoriaGrupo.ValueMember = "NOMBRE_CATEGORIA"
        End Sub

        Private Sub LlenarComboGrupoSubGrupo()
            cbmSubGrupo.DataSource = _objetoGrupo.CargarDatosGrupo(_tipoCon)
            cbmSubGrupo.DisplayMember = "NOMBRE_GRUPO"
            cbmSubGrupo.ValueMember = "NOMBRE_GRUPO"
        End Sub

        Private Sub LlenarComboSecuencial()
            cbSubGrupo.DataSource = _objetoSubGrupo.CargarDatosSubGrupo(_tipoCon)
            cbSubGrupo.DisplayMember = "NOMBRE_SUB_GRUPO"
            cbSubGrupo.ValueMember = "NOMBRE_SUB_GRUPO"
        End Sub

        Private Sub btnNuevoCategoria_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoCategoria.Click
            txtCodigoCategoria.Enabled = True
            txtNombreCategoria.Enabled = True
            txtNombreCategoria.Focus()
            btnNuevoCategoria.Enabled = False
            btnGuardarCategoria.Enabled = True

        End Sub

        Private Sub btnGuardarCategoria_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCategoria.Click
            If txtNombreCategoria.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objetoCategoria
                    .IdCategoria = _objetoCategoria.BuscarMayorCategoria(_tipoCon) + 1
                    .CodigoCategoria = _objetoCategoria.BuscarMayorCodigoCategoria(_tipoCon) + 1
                    .NombreCategoria = txtNombreCategoria.Text
                    .EstadoCategoria = 1 'Para indica el estado del registro
                End With
                _sqlCommands.Add(_objetoCategoria.NuevoRegistroCategoria)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtNombreCategoria.Enabled = False
                    txtCodigoCategoria.Enabled = False
                    btnGuardarCategoria.Enabled = False
                    btnNuevoCategoria.Enabled = True
                    MostrarTodosRegistrosCategoria()
                    LlenarComboCategoriaGrupo()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")


            Else
                MsgBox("No se puede guardar la CATEGORIA debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de Validación")
                txtCodigoCategoria.Focus()
            End If
        End Sub
        '==== VALIDACIONES DE TEXTBOXS ==============================================================================================================================
        Private Sub txtCodigoCategoria_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigoCategoria.KeyPress
            e.Handled = Not _objetoValidacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtNombreCategoria_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombreCategoria.KeyPress
            e.Handled = Not _objetoValidacionesAlfanumerico.EsAlfanumerico(e.KeyChar)
        End Sub
        Private Sub txtCodigoSubGrupo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtCodigoSubGrupo.KeyPress
            e.Handled = Not _objetoValidacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtNombreSubGrupo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNombreSubGrupo.KeyPress
            e.Handled = Not _objetoValidacionesAlfanumerico.EsAlfanumerico(e.KeyChar)
        End Sub
        '============================================================================================================================================================
        Private Sub btnNuevoGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoGrupo.Click
            LlenarComboCategoriaGrupo()
            txtNombreGrupo.Enabled = True
            txtCodigoGrupo.Enabled = True
            cbmCategoriaGrupo.Enabled = True
            txtCodigoGrupo.Text = ""
            txtNombreGrupo.Focus()
            btnNuevoGrupo.Enabled = False
            btnGuardarGrupo.Enabled = True

            txtCodigoGrupo.Text = _objetoGrupo.BuscarMayorCodigoGrupoPorIdCategoria(_tipoCon, _objetoCategoria.BuscarCodigoCategoriaPorNombreCategoria(_tipoCon, cbmCategoriaGrupo.SelectedValue.ToString)) + 1
        End Sub

        Private Sub btnGuardarGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarGrupo.Click
            If txtNombreGrupo.Text <> "" And cbmCategoriaGrupo.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objetoGrupo
                    .IdGrupo = _objetoGrupo.BuscarMayorGrupo(_tipoCon) + 1
                    .CodigoGrupo = Convert.ToInt32(txtCodigoGrupo.Text)
                    .NombreGrupo = txtNombreGrupo.Text
                    .IdCategoriaGrupo = cbmCategoriaGrupo.SelectedIndex + 1
                    .EstadoGrupo = 1 'Para indicar el estado del registro
                End With
                _sqlCommands.Add(_objetoGrupo.NuevoRegistroGrupo)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtNombreGrupo.Enabled = False
                    txtCodigoGrupo.Enabled = False
                    btnGuardarGrupo.Enabled = False
                    cbmCategoriaGrupo.Enabled = False
                    btnNuevoGrupo.Enabled = True
                    MostrarTodosRegistrosGrupo()
                    LlenarComboGrupoSubGrupo()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede guardar el GRUPO debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de Validación")
                txtCodigoGrupo.Focus()
            End If
        End Sub
        Private Sub btnGuardarSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSubGrupo.Click
            If txtNombreSubGrupo.Text <> "" And cbmSubGrupo.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objetoSubGrupo
                    .IdSubGrupo = _objetoSubGrupo.BuscarMayorSubGrupo(_tipoCon) + 1
                    .CodigosubGrupo = _objetoSubGrupo.BuscarMayorCodigoSubGrupoPorIdGrupo(_tipoCon, CInt(txtCodigoSubGrupo.Text)) + 1
                    .NombreSubGrupo = txtNombreSubGrupo.Text
                    .IdGrupoSubGrupo = cbmSubGrupo.SelectedIndex + 1
                    .EstadoSubGrupo = 1 'Para indicar el estado del registro
                End With
                _sqlCommands.Add(_objetoSubGrupo.NuevoRegistroSubGrupo)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtNombreSubGrupo.Enabled = False
                    txtCodigoSubGrupo.Enabled = False
                    btnGuardarSubGrupo.Enabled = False
                    cbmSubGrupo.Enabled = False
                    btnNuevoGrupo.Enabled = True
                    MostrarTodosRegistrosSubGrupo()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede guardar el SUB GRUPO debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de Validación")
                txtCodigoGrupo.Focus()
            End If
        End Sub
        Private Sub btnNuevoSubGrupo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSubGrupo.Click
            LlenarComboGrupoSubGrupo()
            txtCodigoSubGrupo.Enabled = True
            txtNombreSubGrupo.Enabled = True
            cbmSubGrupo.Enabled = True
            txtCodigoSubGrupo.Text = ""
            txtNombreSubGrupo.Focus()

            txtCodigoSubGrupo.Enabled = True
            txtNombreSubGrupo.Enabled = True
            cbmSubGrupo.Enabled = True
            btnGuardarSubGrupo.Enabled = True

            txtCodigoSubGrupo.Text = _objetoSubGrupo.BuscarMayorCodigoSubGrupoPorIdGrupo(_tipoCon, _objetoGrupo.BuscarIdGrupoPorNombreGrupo(_tipoCon, cbmSubGrupo.SelectedValue.ToString)) + 1
        End Sub

        Private Sub cbmSubGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmSubGrupo.SelectedIndexChanged
            txtCodigoSubGrupo.Text = _objetoSubGrupo.BuscarMayorCodigoSubGrupoPorIdGrupo(_tipoCon, _objetoGrupo.BuscarIdGrupoPorNombreGrupo(_tipoCon, cbmSubGrupo.SelectedValue.ToString)) + 1
        End Sub
        Private Sub btnNuevoSecuecial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSecuecial.Click
            LlenarComboSecuencial()
            txtCodigoSecuencial.Enabled = True
            txtNombreSecuencial.Enabled = True
            cbSubGrupo.Enabled = True
            txtCodigoSecuencial.Text = ""
            cbDepreciable.Enabled = True
            txtNombreSubGrupo.Focus()
            btnNuevoSecuecial.Enabled = False
            txtCodigoSecuencial.Focus()
            btnGuardarSecuencial.Enabled = True

            txtCodigoSecuencial.Text = _objetoSecuencial.BuscarMayorCodigoSecuencialPorIdSubGrupo(_tipoCon, _objetoSubGrupo.BuscarIdSubGrupoPorNombreSubGrupo(_tipoCon, cbSubGrupo.SelectedValue.ToString)) + 1
        End Sub

        Private Sub cbSubGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbSubGrupo.SelectedIndexChanged
            txtCodigoSecuencial.Text = _objetoSecuencial.BuscarMayorCodigoSecuencialPorIdSubGrupo(_tipoCon, _objetoSubGrupo.BuscarIdSubGrupoPorNombreSubGrupo(_tipoCon, cbSubGrupo.SelectedValue.ToString)) + 1
        End Sub
        Private Sub btnGuardarSecuencial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSecuencial.Click

            If MessageBox.Show("¿ESTA SEGURO QUE DESEA APROBAR EL COMPROBANTE DE EGRESO?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            With _objetoSecuencial
                .IdSecuencial = _objetoSecuencial.BuscarMayorSecuencial(_tipoCon) + 1
                .CodigoSecuencial = txtCodigoSecuencial.Text.Trim
                .NombreSecuencial = txtNombreSecuencial.Text.Trim.ToUpper
                .EstadoDepreciableSecuencial = cbDepreciable.Text
                .IdSubGrupoSecuencial = _objetoSubGrupo.BuscarIdSubGrupoPorNombreSubGrupo(_tipoCon, cbSubGrupo.SelectedValue.ToString)
                .EstadoSecuencial = 1
            End With
            _sqlCommands.Add(_objetoSecuencial.NuevaSecuencial)

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                txtIdSecuencial.Enabled = False
                txtCodigoSecuencial.Enabled = False
                txtNombreSecuencial.Enabled = False
                cbDepreciable.Enabled = False
                txtIdSecuencial.Text = ""
                txtCodigoSecuencial.Text = ""
                txtNombreSecuencial.Text = ""
                cbDepreciable.Text = ""
                btnNuevoSecuecial.Enabled = True
                MostrarTodosRegistrosSecuencial()
                btnGuardarSecuencial.Enabled = False
            End If
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema") 
        End Sub
       
        Private Sub cbmCategoriaGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmCategoriaGrupo.SelectedIndexChanged
            txtCodigoGrupo.Text = _objetoGrupo.BuscarMayorCodigoGrupoPorIdCategoria(_tipoCon, _objetoCategoria.BuscarCodigoCategoriaPorNombreCategoria(_tipoCon, cbmCategoriaGrupo.SelectedValue.ToString())) + 1
        End Sub
    End Class
End Namespace