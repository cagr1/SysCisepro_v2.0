Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CARGOS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormResponsableAutorizacionFondoRotativo
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

        ReadOnly _objetoResponsableAutorizacionFondoRotativo As New ClassResponsableAutorizacionFondoRotativo
        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudades As New ClassCiudades
        ReadOnly _objetoParroquias As New ClassParroquias
        ReadOnly _objetoCargoOcupacional As New ClassCargo

        Dim _botonSeleccionado As Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            txtIdResponsableAutoFR.Enabled = False
            txtCIResponsableAutoFR.Enabled = False
            txtNombreResponsableAutoFR.Enabled = False
            txtApellidoResponsableAutoFR.Enabled = False
            cmbCargo.Enabled = False
            cmbProvincia.Enabled = False
            cmbCanton.Enabled = False
            cmbParroquia.Enabled = False
            btnGuardarResponsableAutoFR.Enabled = False
            btnCancelarResponsableAutoFR.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdResponsableAutoFR.Enabled = False
            txtCIResponsableAutoFR.Enabled = True
            txtNombreResponsableAutoFR.Enabled = True
            txtApellidoResponsableAutoFR.Enabled = True
            cmbCargo.Enabled = True
            cmbProvincia.Enabled = True
            cmbCanton.Enabled = True
            cmbParroquia.Enabled = True
            btnGuardarResponsableAutoFR.Enabled = True
            btnCancelarResponsableAutoFR.Enabled = True
            btnNuevoResponsableAutoFondoRotativo.Enabled = False
        End Sub

        Private Sub DesabilitadoCancelar()
            DesabilitadoInicio()
            btnNuevoResponsableAutoFondoRotativo.Enabled = True
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtIdResponsableAutoFR.Text <> "" And txtCIResponsableAutoFR.Text <> "" And txtNombreResponsableAutoFR.Text <> "" And txtApellidoResponsableAutoFR.Text <> ""
        End Function

        Private Sub LimpiarParametros()
            txtIdResponsableAutoFR.Text = ""
            txtCIResponsableAutoFR.Text = ""
            txtNombreResponsableAutoFR.Text = ""
            txtApellidoResponsableAutoFR.Text = ""
        End Sub

        Private Sub LlenarComboCargo()
            Try
                cmbCargo.DataSource = _objetoCargoOcupacional.SeleccionarTodosLosRegistrosCargos(_tipoCon)
                cmbCargo.DisplayMember = "DESCRIPCION"
                cmbCargo.ValueMember = "ID_CARGO_OCUPACIONAL"
                If (CType(cmbCargo.DataSource, DataTable).Rows.Count > 0) Then cmbCargo.SelectedIndex = 0
            Catch
                cmbCargo.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarResponsableAutorizacionFondoRotativo()
            Try
                dgvResponsableAutoFR.DataSource = _objetoResponsableAutorizacionFondoRotativo.SeleccionarResponsablesAutorizacionFondoRotativo(_tipoCon)

                dgvResponsableAutoFR.Columns(0).HeaderText = "ID"
                dgvResponsableAutoFR.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvResponsableAutoFR.Columns(1).HeaderText = "CEDULA"
                dgvResponsableAutoFR.Columns(2).HeaderText = "NOMBRE"
                dgvResponsableAutoFR.Columns(3).HeaderText = "APELLIDO"
                dgvResponsableAutoFR.Columns(4).HeaderText = "CARGO"
                dgvResponsableAutoFR.Columns(5).HeaderText = "EST"
                dgvResponsableAutoFR.Columns(6).HeaderText = "ID PROV"
                dgvResponsableAutoFR.Columns(7).HeaderText = "ID CIU"
                dgvResponsableAutoFR.Columns(8).HeaderText = "ID PARR"
                dgvResponsableAutoFR.AutoResizeColumns()
                dgvResponsableAutoFR.AutoResizeRows()
                dgvResponsableAutoFR.ReadOnly = True
            Catch
                dgvResponsableAutoFR.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarResponsableAutorizacionFondoRotativoNuevo()
            With _objetoResponsableAutorizacionFondoRotativo
                .IdResponsableAutorizacion = txtIdResponsableAutoFR.Text
                .CiResponsableAutorizacion = txtCIResponsableAutoFR.Text.Trim
                .NombreResponsableAutorizacion = txtNombreResponsableAutoFR.Text.ToUpper
                .ApellidoResponsableAutorizacion = txtApellidoResponsableAutoFR.Text.ToUpper
                .CargoResponsableAutorizacion = cmbCargo.SelectedValue.ToString
                .EstadoResponsableAutorizacion = 1
                .IdProvincia = cmbProvincia.SelectedValue
                .IdCiudad = cmbCanton.SelectedValue
                .IdParroquia = cmbParroquia.SelectedValue
            End With
            _sqlCommands.Add(_objetoResponsableAutorizacionFondoRotativo.NuevoRegistroResponsablesAutorizacionForndoRotativo)
        End Sub

        Private Sub FormResponsableAutorizacionFondoRotativo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava 
                    dgvResponsableAutoFR.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White 
                    dgvResponsableAutoFR.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White 
                    dgvResponsableAutoFR.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvResponsableAutoFR.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            LlenarComboProvincias()
            LlenarComboCargo()
            CargarResponsableAutorizacionFondoRotativo()
            DesabilitadoInicio()

        End Sub

        Private Sub dgvResponsableAutoFR_CellClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvResponsableAutoFR.CellClick
            If dgvResponsableAutoFR.RowCount = 0 Then Return
            If dgvResponsableAutoFR.CurrentRow Is Nothing Then Return
            txtIdResponsableAutoFR.Text = dgvResponsableAutoFR.CurrentRow.Cells.Item(0).Value
            txtCIResponsableAutoFR.Text = dgvResponsableAutoFR.CurrentRow.Cells.Item(1).Value
            txtNombreResponsableAutoFR.Text = dgvResponsableAutoFR.CurrentRow.Cells.Item(2).Value.ToString
            txtApellidoResponsableAutoFR.Text = dgvResponsableAutoFR.CurrentRow.Cells.Item(3).Value.ToString
        End Sub
        Private Sub btnNuevoResponsableAutoFondoRotativo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevoResponsableAutoFondoRotativo.Click
            _botonSeleccionado = 1
            LimpiarParametros() 
            txtIdResponsableAutoFR.Text = _objetoResponsableAutorizacionFondoRotativo.BuscarMayorIdResponsablesAutorizacionForndoRotativo(_tipoCon) + 1
            HabilitadoNuevo()
        End Sub
        Private Sub btnGuardarResponsableAutoFR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardarResponsableAutoFR.Click
            If ValidacionParametros() Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                Select Case (_botonSeleccionado)
                    Case 1 : GuardarResponsableAutorizacionFondoRotativoNuevo()
                End Select

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DesabilitadoCancelar()
                    CargarResponsableAutorizacionFondoRotativo()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema") 
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                txtIdResponsableAutoFR.Focus()
            End If
        End Sub
        Private Sub btnCancelarResponsableAutoFR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelarResponsableAutoFR.Click
            LimpiarParametros()
            DesabilitadoCancelar()
        End Sub

        Private Sub LlenarComboProvincias()
            Try
                cmbProvincia.DataSource = _objetoProvincias.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cmbProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cmbProvincia.ValueMember = "ID_PROVINCIAS"
                cmbProvincia.DropDownWidth = 300
                If (CType(cmbProvincia.DataSource, DataTable).Rows.Count > 0) Then cmbProvincia.SelectedValue = 7
            Catch
                cmbProvincia.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmProvincia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbProvincia.SelectedValueChanged
            If cmbProvincia.SelectedValue Is Nothing Or TypeOf cmbProvincia.SelectedValue Is DataRowView Then Return
            LlenarComboCiudad()
        End Sub

        Private Sub LlenarComboCiudad()
            Try
                cmbCanton.DataSource = _objetoCiudades.BuscarNombreCiudadXIdProvincia(_tipoCon, CInt(cmbProvincia.SelectedValue))
                cmbCanton.DisplayMember = "NOMBRE_CIUDADES"
                cmbCanton.ValueMember = "ID_CIUDAD"
                cmbCanton.DropDownWidth = 300
                If (CType(cmbCanton.DataSource, DataTable).Rows.Count > 0) Then cmbCanton.SelectedIndex = 0
            Catch
                cmbCanton.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCanton.SelectedValueChanged
            If cmbCanton.SelectedValue Is Nothing Or TypeOf cmbCanton.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub

        Private Sub LlenarComboParroquias()
            Try
                cmbParroquia.DataSource = _objetoParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, CInt(cmbCanton.SelectedValue))
                cmbParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cmbParroquia.ValueMember = "ID_PARROQUIAS"
                cmbParroquia.DropDownWidth = 300
                If (CType(cmbParroquia.DataSource, DataTable).Rows.Count > 0) Then cmbParroquia.SelectedIndex = 0
            Catch
                cmbParroquia.DataSource = Nothing
            End Try
        End Sub

    End Class
End Namespace