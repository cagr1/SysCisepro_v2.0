Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports Krypton.Toolkit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Namespace FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMantenimientoUsuario

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


        ReadOnly _objEmpresa As New ClassEmpresa
        ReadOnly _objSucursal As New ClassSucursal
        ReadOnly _objArea As New ClassArea
        ReadOnly _objUsuarioGeneral As New ClassUsuarioGeneral
        Dim _boton As Integer

        Public User As String
        Public Isadm As Boolean

        Private Sub Habilitar(ByVal usr As Boolean, ByVal idEmpresa As Boolean, ByVal idSucursal As Boolean, ByVal idArea As Boolean, ByVal datos As Boolean, ByVal login As Boolean, ByVal password As Boolean, ByVal tipoUsuario As Boolean, ByVal tipoRol As Boolean)
            txtIdUsuario.Enabled = usr
            cbmEmpresa.Enabled = idEmpresa
            cbmSucursal.Enabled = idSucursal
            cbmArea.Enabled = idArea
            txtDatos.Enabled = datos
            txtLogin.Enabled = login
            txtPassword.Enabled = password
            cbmTipoUsuario.Enabled = tipoUsuario
            cbmIdRol.Enabled = tipoRol
        End Sub

        Private Sub LimpiarTextBoxs()
            txtIdUsuario.Text = ""
            cbmEmpresa.Text = ""
            cbmSucursal.Text = ""
            cbmArea.Text = ""
            txtDatos.Text = ""
            txtLogin.Text = ""
            txtPassword.Text = ""
            cbmTipoUsuario.Text = ""
            cbmIdRol.Text = ""
            txtIdUsuario.Text = ""
        End Sub

        Private Sub ComboEmpresa()
            Try
                Dim e = _objEmpresa.SeleccionarTodosLosRegistrosEmpresa(_tipoCon)
                cbmEmpresa.DataSource = e
                cbmEmpresa.DisplayMember = e.Columns("NOMBRE_COMERCIAL_EMPRESA").ToString
                cbmEmpresa.ValueMember = e.Columns("NOMBRE_COMERCIAL_EMPRESA").ToString
                cbmEmpresa.DropDownWidth = 300
            Catch
                cbmEmpresa.DataSource = Nothing
            End Try
        End Sub

        Private Sub ComboSucursal()
            Try
                Dim e = _objSucursal.SeleccionarTodosLosRegistrosSucursal(_tipoCon)
                cbmSucursal.DataSource = e
                cbmSucursal.DisplayMember = e.Columns("NOMBRE_SUCURSAL").ToString
                cbmSucursal.ValueMember = e.Columns("NOMBRE_SUCURSAL").ToString
                cbmSucursal.DropDownWidth = 300
            Catch
                cbmSucursal.DataSource = Nothing
            End Try
        End Sub
        Private Sub ComboTipoRol()
            Try
                Dim e = _objUsuarioGeneral.SeleccionarRoles(_tipoCon)
                cbmIdRol.DataSource = e
                cbmIdRol.DisplayMember = e.Columns("fld_tipo_rol").ToString
                cbmIdRol.ValueMember = e.Columns("fld_id_rol").ToString
                cbmIdRol.DropDownWidth = 300
            Catch
                cbmSucursal.DataSource = Nothing
            End Try


        End Sub
        Private Sub ComboArea()
            Try
                Dim e = _objArea.SeleccionarTodosLosRegistrosArea(_tipoCon)
                cbmArea.DataSource = e
                cbmArea.DisplayMember = e.Columns("NOMBRE_AREA").ToString
                cbmArea.ValueMember = e.Columns("NOMBRE_AREA").ToString
                cbmArea.DropDownWidth = 300
            Catch ex As Exception
                cbmArea.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarUsuarios()
            Try
                dgvUsuarios.DataSource = _objUsuarioGeneral.SeleccionarUsuarioGeneral(_tipoCon)

                dgvUsuarios.Columns(0).Width = 50
                dgvUsuarios.Columns(1).Visible = False
                dgvUsuarios.Columns(2).Visible = False
                dgvUsuarios.Columns(3).Visible = False
                dgvUsuarios.Columns(4).Width = 250
                dgvUsuarios.Columns(5).Width = 120
                dgvUsuarios.Columns(6).Visible = False
                dgvUsuarios.Columns(7).Width = 300
                dgvUsuarios.Columns(8).Visible = False

                dgvUsuarios.ReadOnly = True
                dgvUsuarios.AutoResizeRows()

            Catch
                dgvUsuarios.DataSource = Nothing
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarUsuarios()
        End Sub

        Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmNuevo.Click
            _boton = 1
            Habilitar(False, True, True, True, True, True, True, True, True)
            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = True
            ToolStripMenuItem2.Enabled = False
            tsmCancelar.Enabled = True
            btnPersonal.Enabled = True
            txtIdUsuario.Clear()
            txtDatos.Tag = Nothing
            txtLogin.Clear()
            txtPassword.Clear()
            txtDatos.Clear()
        End Sub

        Private Sub tsmGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmGuardar.Click
            'If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            Select Case _boton
                Case 1
                    With _objUsuarioGeneral
                        .IdUsuario = _objUsuarioGeneral.BuscarMayorIdUsuario(_tipoCon) + 1
                        .IdEmpresa = _objEmpresa.BuscarIdEmpresaPorNombre(_tipoCon, cbmEmpresa.Text.Trim)
                        .IdSucursal = _objSucursal.BuscarIdSucursalPorNombre(_tipoCon, cbmSucursal.Text.Trim)
                        .IdArea = _objArea.BuscarIdAreaGeneralPorNombreAreaGeneral(_tipoCon, cbmArea.Text.Trim)
                        .DatosUsuario = txtDatos.Text.Trim.ToUpper
                        .LoginUsuario = txtLogin.Text.Trim.ToUpper
                        .PasswordUsuario = txtPassword.Text
                        .TipoUsuario = cbmTipoUsuario.Text
                        .EstadoUsuario = 1
                        .IdPersonal = txtIdPersonal.Text
                        .IdRol = cbmIdRol.SelectedValue
                    End With
                    _sqlCommands.Add(_objUsuarioGeneral.NuevoUsuarioGeneral)
                Case 2
                    With _objUsuarioGeneral
                        .IdUsuario = txtIdUsuario.Text
                        .PasswordUsuario = txtPassword.Text
                        .IdRol = cbmIdRol.SelectedValue
                    End With
                    _sqlCommands.Add(_objUsuarioGeneral.ModificarPasswordUsuarioGeneral)
            End Select

            Dim nombreU As String = "Ingreso de Usuario por: " & User


            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then

                Habilitar(False, False, False, False, False, False, False, False, False)
                tsmNuevo.Enabled = True
                tsmGuardar.Enabled = False
                ToolStripMenuItem2.Enabled = True
                tsmCancelar.Enabled = False
                LimpiarTextBoxs()
                btnPersonal.Enabled = False
                CargarUsuarios()

            End If

            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvUsuarios.CurrentRow Is Nothing Then Return

            If Not Isadm And Not txtDatos.Text.Trim.Equals(User.Trim) Then
                'MessageBox.Show("EL USUARIO QUE SELECCIONÓ NO ES SUYO, NO PUEDE REALIZAR ESTA ACCIÓN!", "VALIDACIÓN DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KryptonMessageBox.Show("El usuario que seleccionó no es suyo, no puede realizar esta acción!", "VALIDACIÓN DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                Return
            End If

            Dim respuesta = InputBox("Modificar contraseña o password", "Ingrese su contraseña actual" & vbCr & "" & vbCr & " Recuerde siempre su contraseña")

            If respuesta = _objUsuarioGeneral.BuscarPasswordPorLogin(_tipoCon, txtLogin.Text) Then
                txtPassword.Enabled = True
                cbmIdRol.Enabled = True
                tsmNuevo.Enabled = False
                tsmGuardar.Enabled = True
                ToolStripMenuItem2.Enabled = False
                tsmCancelar.Enabled = True
                btnPersonal.Enabled = False
                _boton = 2
            Else
                txtPassword.Enabled = False
                cbmIdRol.Enabled = False
                tsmNuevo.Enabled = True
                tsmGuardar.Enabled = False
                ToolStripMenuItem2.Enabled = True
                tsmCancelar.Enabled = False
                btnPersonal.Enabled = False
                'MessageBox.Show("DEBE INGRESAR SU CONTRASEÑA ACTUAL PARA REALIZAR CAMBIOS!", "VALIDADCIÓN DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                KryptonMessageBox.Show("Debe ingresar su contraseña actual para realizar cambios!", "VALIDADCIÓN DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub tsmCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmCancelar.Click
            _boton = 0
            Habilitar(False, False, False, False, False, False, False, False, False)
            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            ToolStripMenuItem2.Enabled = False
            tsmCancelar.Enabled = False
            btnPersonal.Enabled = False
            txtDatos.Tag = Nothing
            txtIdUsuario.Clear()
            txtLogin.Clear()
            txtPassword.Clear()
            txtDatos.Clear()
        End Sub

        Private Sub dgvUsuarios_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvUsuarios.SelectionChanged
            If dgvUsuarios.RowCount = 0 Or dgvUsuarios.CurrentRow Is Nothing Then Return

            Dim stringValue As String = dgvUsuarios.CurrentRow.Cells.Item(10).Value.ToString()
            Dim intValue As Integer
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells.Item(0).Value.ToString
            cbmEmpresa.Text = _objEmpresa.BuscarNombreEmpresaPorId(_tipoCon, CType(dgvUsuarios.CurrentRow.Cells.Item(1).Value.ToString, Integer))
            cbmSucursal.Text = _objSucursal.BuscarNombrePorIdSucursal(_tipoCon, CType(dgvUsuarios.CurrentRow.Cells.Item(2).Value.ToString, Integer))
            cbmArea.Text = _objArea.BuscarNombreAreaGeneralPorIdAreaGeneral(_tipoCon, CType(dgvUsuarios.CurrentRow.Cells.Item(3).Value.ToString, Integer))
            txtDatos.Text = dgvUsuarios.CurrentRow.Cells.Item(4).Value.ToString
            txtLogin.Text = dgvUsuarios.CurrentRow.Cells.Item(5).Value.ToString
            txtPassword.Text = dgvUsuarios.CurrentRow.Cells.Item(6).Value.ToString
            cbmTipoUsuario.Text = dgvUsuarios.CurrentRow.Cells.Item(7).Value.ToString
            txtDatos.Tag = dgvUsuarios.CurrentRow.Cells.Item(9).Value.ToString
            txtIdPersonal.Text = dgvUsuarios.CurrentRow.Cells.Item(9).Value.ToString
            If Integer.TryParse(stringValue, intValue) Then

                cbmIdRol.Text = _objUsuarioGeneral.SeleccionarNombreRol(_tipoCon, intValue)
            Else

                cbmIdRol.Text = _objUsuarioGeneral.SeleccionarNombreRol(_tipoCon, 0)
            End If

            tsmNuevo.Enabled = True
            tsmGuardar.Enabled = False
            ToolStripMenuItem2.Enabled = True
            tsmCancelar.Enabled = False
        End Sub

        Private Sub FormMantenimientoUsuario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvUsuarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvUsuarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvUsuarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvUsuarios.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            ComboEmpresa()
            ComboSucursal()
            ComboArea()
            CargarUsuarios()
            ComboTipoRol()
        End Sub

        Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.Todos = True
            'frm.IsOperaciones = True
            'frm.IsAdmin = False
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtDatos.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtDatos.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        txtIdPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                    End If
                End If
            Catch ex As Exception
                txtDatos.Clear()
                txtDatos.Tag = Nothing
            End Try
        End Sub

        Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
    End Class
End Namespace