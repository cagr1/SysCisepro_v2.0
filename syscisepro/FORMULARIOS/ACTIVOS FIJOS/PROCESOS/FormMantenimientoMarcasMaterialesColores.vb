Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.PARAMETROS
Imports ClassLibraryCisepro.ProcesosSql
Imports Krypton.Toolkit

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMantenimientoMarcasMaterialesColores
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

        ReadOnly _objetoMarcas As New ClassMarca
        ReadOnly _objetoMaterial As New ClassMaterial
        ReadOnly _objetoColor As New ClassColor
        Private ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Private Sub FormMantenimientoMarcasMaterialesColores_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvMarcas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvColores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvMateriales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvMarcas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvColores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvMateriales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvMarcas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvColores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvMateriales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvColores.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMarcas.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMateriales.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            MostrarTodosRegistrosColores()
            MostrarTodosRegistrosMarcas()
            MostrarTodosRegistrosMateriales() 
        End Sub

        Private Sub MostrarTodosRegistrosMarcas()
            dgvMarcas.DataSource = _objetoMarcas.SeleccionarTodosLosRegistrosMarca(_tipoCon)
            dgvMarcas.AutoResizeColumns()
            dgvMarcas.AutoResizeRows() 
            dgvMarcas.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMarcas.Columns("MARCA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMarcas.Columns("MARCA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMarcas.ReadOnly = False
            dgvMarcas.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub MostrarTodosRegistrosMateriales()
            dgvMateriales.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
            dgvMateriales.AutoResizeColumns()
            dgvMateriales.AutoResizeRows() 
            dgvMateriales.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMateriales.Columns("MATERIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMateriales.Columns("MATERIAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvMateriales.ReadOnly = False
            dgvMateriales.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub MostrarTodosRegistrosColores()
            dgvColores.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
            dgvColores.AutoResizeColumns()
            dgvColores.AutoResizeRows() 
            dgvColores.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvColores.Columns("COLOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvColores.Columns("COLOR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvColores.ReadOnly = False
            dgvColores.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub btnNuevoMarca_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoMarca.Click
            btnGuardarMarca.Enabled = True
            btnNuevoMarca.Enabled = False 
            txtDetalleMarca.Enabled = True
            txtDetalleMarca.Focus()
        End Sub

        Private Sub btnGuardarMarca_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarMarca.Click
            If txtDetalleMarca.Text <> "" Then

                'If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                _objAuditoria.FormularioAuditoria = Text.Trim
                _objAuditoria.EstadoAuditoria = 1
                _objAuditoria.IdUsuarioAuditoria = IdUsuario

                With _objetoMarcas
                    .IdMarca = _objetoMarcas.BuscarMayorIdMarca(_tipoCon) + 1
                    .DetalleMarca = txtDetalleMarca.Text.Trim.ToUpper
                    .EstadoMarca = 1 'Para indica el estado del registro 
                End With
                _sqlCommands.Add(_objetoMarcas.NuevaMarca)
                _objAuditoria.AccionAuditoria = "NUEVA MARCA CON REGISTRO N° " + txtIdMarca.Text
                _sqlCommands.Add(_objAuditoria.NuevaAuditoria)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    txtIdMarca.Enabled = False
                    txtDetalleMarca.Enabled = False
                    btnGuardarMarca.Enabled = False
                    btnNuevoMarca.Enabled = True
                    MostrarTodosRegistrosMarcas()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("No se puede guardar la MARCA debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar la MARCA debido a que no ha llenado todos los parámetros nesesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                txtDetalleMarca.Focus()
            End If
        End Sub

        Private Sub btnNuevoColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoColor.Click
            btnGuardarColor.Enabled = True
            btnNuevoColor.Enabled = False
            txtDetalleColor.Enabled = True
            txtDetalleColor.Focus()
        End Sub

        Private Sub btnGuardarColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarColor.Click
            If txtDetalleColor.Text <> "" Then

                'If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                _objAuditoria.FormularioAuditoria = Text.Trim
                _objAuditoria.EstadoAuditoria = 1
                _objAuditoria.IdUsuarioAuditoria = IdUsuario

                With _objetoColor
                    .Id = _objetoColor.BuscarMayorIdColor(_tipoCon) + 1
                    .Detalle = txtDetalleColor.Text.Trim.ToUpper
                    .Estado = 1 'Para indica el estado del registro
                End With
                _sqlCommands.Add(_objetoColor.NuevaColor)
                _objAuditoria.AccionAuditoria = "NUEVO COLOR CON REGISTRO N° " + txtIdColor.Text
                _sqlCommands.Add(_objAuditoria.NuevaAuditoria)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    MostrarTodosRegistrosColores()
                    txtIdColor.Enabled = False
                    txtDetalleColor.Enabled = False
                    btnGuardarColor.Enabled = False
                    btnNuevoColor.Enabled = True
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("No se puede guardar el COLOR debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar el COLOR debido a que no ha llenado todos los parámetros nesesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                txtDetalleColor.Focus()
            End If
        End Sub

        Private Sub btnNuevoMaterial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoMaterial.Click
            btnGuardarMaterial.Enabled = True
            btnNuevoMaterial.Enabled = False
            txtDetalleMaterial.Enabled = True
            txtDetalleMaterial.Focus()
        End Sub

        Private Sub btnGuardarMaterial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarMaterial.Click
            If txtDetalleMaterial.Text <> "" Then

                'If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                _objAuditoria.FormularioAuditoria = Text.Trim
                _objAuditoria.EstadoAuditoria = 1
                _objAuditoria.IdUsuarioAuditoria = IdUsuario

                With _objetoMaterial
                    .IdMaterial = _objetoMaterial.BuscarMayorIdMaterial(_tipoCon) + 1
                    .DetalleMaterial = txtDetalleMaterial.Text.Trim.ToUpper
                    .EstadoMaterial = 1 'Para indica el estado del registro
                End With
                _sqlCommands.Add(_objetoMaterial.NuevaMaterial)
                _objAuditoria.AccionAuditoria = "NUEVO MATERIAL CON REGISTRO N° " + txtIdMaterial.Text
                _sqlCommands.Add(_objAuditoria.NuevaAuditoria)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    MostrarTodosRegistrosMateriales()
                    txtIdMaterial.Enabled = False
                    txtDetalleMaterial.Enabled = False
                    btnGuardarMaterial.Enabled = False
                    btnNuevoMaterial.Enabled = True
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                'MsgBox("No se puede guardar el MATERIAL debido a que no ha llenado todos los parámetros nesesarios", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar el MATERIAL debido a que no ha llenado todos los parámetros nesesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                txtDetalleMaterial.Focus()
            End If
        End Sub
        Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnVolver.Click
            DialogResult = DialogResult.OK 
        End Sub
    End Class
End Namespace