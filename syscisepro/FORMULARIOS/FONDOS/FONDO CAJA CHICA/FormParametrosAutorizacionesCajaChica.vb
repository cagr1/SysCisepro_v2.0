Imports System.Data.SqlClient
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormParametrosAutorizacionesCajaChica
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

        ReadOnly _objProvincias As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objAutorizaciones As New ClassResponsableAutorizacionesCch

        '===============================================================================================================================================================================================================
        Private Sub CargarPersonal(ByVal tipo As String)
            Select Case tipo
                Case "CEDULA"
                    dgvPersonal.DataSource = _objPersonal.BuscarPorCedulaElPersonal(_tipoCon, txtParametroBusqueda.Text)
                Case "APELLIDOS"
                    dgvPersonal.DataSource = _objPersonal.BuscarPorApellidosElPersonal(_tipoCon, txtParametroBusqueda.Text, True)
            End Select
            dgvPersonal.AutoResizeColumns() 
            dgvPersonal.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvPersonal.Columns(0).HeaderText = "ID"
            dgvPersonal.Columns(6).DefaultCellStyle.Format = "d"
            For i = 9 To dgvPersonal.ColumnCount - 1
                dgvPersonal.Columns(i).Visible = False
            Next
            dgvPersonal.Columns("ID_PERSONAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub CargarAutorizaciones()
            Try
                dgvParametroAutorizaciones.DataSource = _objAutorizaciones.SeleccionarResponsablesAutorizacionCajaChica(_tipoCon) 
                dgvParametroAutorizaciones.EditMode = DataGridViewEditMode.EditProgrammatically
                For indice = 0 To dgvParametroAutorizaciones.RowCount - 1
                    If dgvParametroAutorizaciones.Rows(indice).Cells("ESTADO_RESPONSABLE_AUTO_CCH").Value = 2 Then
                        dgvParametroAutorizaciones.Rows(indice).DefaultCellStyle.BackColor = Color.Red
                    Else
                        dgvParametroAutorizaciones.Rows(indice).DefaultCellStyle.BackColor = Color.Green
                    End If
                Next

                dgvParametroAutorizaciones.Columns(0).HeaderText = "ID"
                dgvParametroAutorizaciones.Columns(0).Width = 50
                dgvParametroAutorizaciones.Columns(1).HeaderText = "RESPONSABLE"
                dgvParametroAutorizaciones.Columns(1).Width = 200
                dgvParametroAutorizaciones.Columns(2).HeaderText = "CÉDILA"
                dgvParametroAutorizaciones.Columns(2).Width = 80
                dgvParametroAutorizaciones.Columns(3).Visible = False
                dgvParametroAutorizaciones.Columns(4).Visible = False
                dgvParametroAutorizaciones.Columns(5).Visible = False
                dgvParametroAutorizaciones.Columns(6).Visible = False
                dgvParametroAutorizaciones.Columns(7).HeaderText = "PROVINCIA"
                dgvParametroAutorizaciones.Columns(7).Width = 150
                dgvParametroAutorizaciones.Columns(8).HeaderText = "CIUDAD"
                dgvParametroAutorizaciones.Columns(8).Width = 150
                dgvParametroAutorizaciones.Columns(9).HeaderText = "PARROQUIA"
                dgvParametroAutorizaciones.Columns(9).Width = 150
                dgvParametroAutorizaciones.Columns(10).HeaderText = "CARGO"
                dgvParametroAutorizaciones.Columns(10).Width = 200
            Catch
                dgvParametroAutorizaciones.DataSource = Nothing
            End Try
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub LlenarComboProvincias()
            Try
                Dim data = _objProvincias.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincias.DataSource = data
                cbmProvincias.DisplayMember = data.Columns("NOMBRE_PROVINCIAS").ToString
                cbmProvincias.ValueMember = data.Columns("NOMBRE_PROVINCIAS").ToString
                If (CType(cbmProvincias.DataSource, DataTable).Rows.Count > 0) Then cbmProvincias.SelectedIndex = 0
            Catch
                cbmProvincias.DataSource = Nothing
            End Try
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub LlenarComboCiudad()
            Try
                Dim data = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, _objProvincias.BuscarIdProvinciaPorNombreProvincia(_tipoCon, cbmProvincias.Text))
                cbmCiudad.DataSource = data
                cbmCiudad.DisplayMember = data.Columns("NOMBRE_CIUDADES").ToString
            Catch
                cbmCiudad.DataSource = Nothing
            End Try
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub LlenarComboParroquias()
            Dim data = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, _objCiudad.BuscarIdCiudadPorNombreCiudad(_tipoCon, cbmCiudad.Text))
            cbmParroquias.DataSource = data
            cbmParroquias.DisplayMember = data.Columns("NOMBRE_PARROQUIAS").ToString
            cbmParroquias.ValueMember = data.Columns("NOMBRE_PARROQUIAS").ToString
            cbmParroquias.DropDownWidth = 300
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub FormParámetrosAutorizacionesCajaChica_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvParametroAutorizaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'MenuStrip1.ForeColor = Color.White
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvParametroAutorizaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvParametroAutorizaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvPersonal.Font = New Font("Roboto", 7, FontStyle.Regular)
            dgvParametroAutorizaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            LlenarComboProvincias()
            LlenarComboCiudad()
            CargarAutorizaciones()

            txtParametroBusqueda.Focus()
        End Sub
      
        '===============================================================================================================================================================================================================
        Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnActualizar.Click
            If txtIdResponsable.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA ACTUALIZAR LOS DATOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                If rbActivo.Checked = True Then
                    _sqlCommands.Add(_objAutorizaciones.ActivarResponsableAutorizacionFondoCaja(CType(txtIdResponsable.Text, Integer)))
                End If
                If rbInactivo.Checked = True Then
                    _sqlCommands.Add(_objAutorizaciones.DesactivarResponsableAutorizacionFondoCaja(CType(txtIdResponsable.Text, Integer)))
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then CargarAutorizaciones()
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se pudo actualizar el estado del Responsable de Autorización sino selecciona un registro válido", MsgBoxStyle.Information, "Mensaje d Información")
            End If 
        End Sub
      
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            If txtCedula.Text <> "" And txtIdPersonal.Text <> "" And txtNombres.Text <> "" And cbmCiudad.Text <> "" And cbmProvincias.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objAutorizaciones
                    .IdResponsable = .BuscarMayorIdResponsableAutorizacionCajaChica(_tipoCon) + 1
                    .IdPersonal = txtIdPersonal.Text
                    .Nombres = txtNombres.Text
                    .Cedula = txtCedula.Text
                    .IdProvincia = _objProvincias.BuscarIdProvinciaPorNombreProvincia(_tipoCon, cbmProvincias.Text)
                    .IdCiudad = _objCiudad.BuscarIdCiudadPorNombreCiudad(_tipoCon, cbmCiudad.Text)
                    .IdParroquia = _objParroquias.BuscarIdParroquiaXNombreParroquia(_tipoCon, cbmParroquias.Text)
                    .Estado = 1
                End With
                _sqlCommands.Add(_objAutorizaciones.NuevoRegistroResponsableAutorizacionFondoCaja)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then CargarAutorizaciones()
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede Guardar el registro sino agrega todos los parámetros ", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End If
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub cbmProvincias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincias.SelectedIndexChanged
            LlenarComboCiudad()
        End Sub
        '===============================================================================================================================================================================================================
        Private Sub txtParametroBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtParametroBusqueda.TextChanged
            If rbCedula.Checked = True Then
                CargarPersonal("CEDULA")
            End If
            If rbApellidos.Checked = True Then
                CargarPersonal("APELLIDOS")
            End If
        End Sub

        Private Sub cbmCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCiudad.SelectedIndexChanged
            LlenarComboParroquias()
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            tcAutorizaciones.SelectedIndex = 1
            ConectarReporte()
        End Sub

        Private Sub ConectarReporte()
            Dim crResponsablesAutorizaciones As New crAutorizaciones
            crResponsablesAutorizaciones.SetDataSource(_objAutorizaciones.SeleccionarResponsablesAutorizaciones(_tipoCon))
            crResponsablesAutorizaciones.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvAutorizaciones.ReportSource = crResponsablesAutorizaciones
            crvAutorizaciones.Zoom(75)
            crvAutorizaciones.Refresh()
        End Sub

        Private Sub dgvPersonal_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvPersonal.SelectionChanged
            If dgvPersonal.RowCount = 0 Or dgvPersonal.CurrentRow Is Nothing Then Return
            txtIdPersonal.Text = dgvPersonal.CurrentRow.Cells.Item("ID_PERSONAL").Value.ToString()
            txtNombres.Text = dgvPersonal.CurrentRow.Cells.Item("APELLIDOS").Value.ToString() + " " + dgvPersonal.CurrentRow.Cells.Item("NOMBRES").Value.ToString()
            txtCedula.Text = dgvPersonal.CurrentRow.Cells.Item("CEDULA").Value.ToString()
        End Sub
         
        Private Sub dgvParametroAutorizaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvParametroAutorizaciones.SelectionChanged
            If dgvParametroAutorizaciones.RowCount = 0 Or dgvParametroAutorizaciones.CurrentRow Is Nothing Then Return
            txtIdResponsable.Text = dgvParametroAutorizaciones.CurrentRow.Cells.Item("ID_RESPONSABLE_AUTO_CCH").Value.ToString()
            txtNombreResponsable.Text = dgvParametroAutorizaciones.CurrentRow.Cells.Item("NOMBRES_AUTO_CCH").Value.ToString()
            txtCiudadResponsable.Text = dgvParametroAutorizaciones.CurrentRow.Cells.Item("NOMBRE_CIUDADES").Value.ToString()
            rbActivo.Checked = dgvParametroAutorizaciones.CurrentRow.Cells.Item("ESTADO_RESPONSABLE_AUTO_CCH").Value.ToString().Equals("1")
            rbInactivo.Checked = dgvParametroAutorizaciones.CurrentRow.Cells.Item("ESTADO_RESPONSABLE_AUTO_CCH").Value.ToString().Equals("2")
        End Sub

        Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub
    End Class
End Namespace