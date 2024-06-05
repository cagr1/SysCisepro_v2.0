Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormFondoRotativo
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

        ReadOnly _objetoFondoRotativo As New ClassFondoRotativo
        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudades As New ClassCiudades
        ReadOnly _objetoParroquias As New ClassParroquias
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        
        Private Sub FormFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White 
                    dgvFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White 
                    dgvFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFondoRotativo.Font = New Font("Roboto", 8, FontStyle.Regular)
            LlenarComboCentroCostos()

            LlenarComboProvincias()
            cmbCanton.SelectedValue = 58

            DeshabilitadoInicio()
            CargarRegistrosFondoRotativo()

        End Sub

        Private Sub LimpiarParametros()
            txtIdFondoRotativo.Text = ""
            txtCustodioFondo.Text = ""
            txtDetalleFondoRotativo.Text = ""
            txtMontoFondoRotativo.Text = ""
            txtCtaContableFondo.Text = ""
        End Sub

        Private Sub DeshabilitadoInicio()
            txtDetalleFondoRotativo.Enabled = False
            txtMontoFondoRotativo.Enabled = False
            btnBuscarCustodio.Enabled = False
            txtCtaContableFondo.Enabled = False
            cmbTipoCuenta.Enabled = False
            cmbNivelCuenta.Enabled = False
            cmbProvincia.Enabled = False
            cmbCanton.Enabled = False
            cmbParroquia.Enabled = False
            cmbCentroCosto.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtDetalleFondoRotativo.Enabled = True
            txtMontoFondoRotativo.Enabled = True
            btnBuscarCustodio.Enabled = True
            txtCtaContableFondo.Enabled = True
            cmbTipoCuenta.Enabled = True
            cmbNivelCuenta.Enabled = True
            cmbProvincia.Enabled = True
            cmbCanton.Enabled = True
            cmbParroquia.Enabled = True
            cmbCentroCosto.Enabled = True
        End Sub

        Private Sub LlenarComboCentroCostos()
            Try
                cmbCentroCosto.DataSource = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
                cmbCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cmbCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cmbCentroCosto.DropDownWidth = 300
                If (CType(cmbCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cmbCentroCosto.SelectedIndex = 0
            Catch
                cmbCentroCosto.DataSource = Nothing
            End Try
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

        Private Sub btnNuevoGastosRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoFondoRotativo.Click
            LimpiarParametros()

            LlenarComboProvincias()
            cmbCanton.SelectedValue = 58

            LlenarComboCentroCostos()

            HabilitadoNuevo()

            btnNuevoFondoRotativo.Enabled = False
            btnModificarFondoRotativo.Enabled = False
            btnCancelarFondoRotativo.Enabled = True
            btnGuardarFondoRotativo.Enabled = True

        End Sub

        Private Sub btnBuscarCustodio_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarCustodio.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.IsOperaciones = False
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtCustodioFondo.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtCustodioFondo.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                txtCustodioFondo.Tag = Nothing
                txtCustodioFondo.Text = ""
            End Try
        End Sub

        Private Sub btnModificarFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificarFondoRotativo.Click
            btnNuevoFondoRotativo.Enabled = False
            btnModificarFondoRotativo.Enabled = False
            btnCancelarFondoRotativo.Enabled = True
            btnGuardarFondoRotativo.Enabled = True
            DeshabilitadoInicio()
        End Sub

        Private Sub btnGuardarFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarFondoRotativo.Click
            btnNuevoFondoRotativo.Enabled = True
            btnModificarFondoRotativo.Enabled = dgvFondoRotativo.RowCount > 0 And Not dgvFondoRotativo.CurrentRow Is Nothing
            btnCancelarFondoRotativo.Enabled = False
            btnGuardarFondoRotativo.Enabled = False
        End Sub

        Private Sub btnCancelarFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarFondoRotativo.Click
            LimpiarParametros()
            DeshabilitadoInicio()
            btnNuevoFondoRotativo.Enabled = True
            btnModificarFondoRotativo.Enabled = False
            btnCancelarFondoRotativo.Enabled = False
            btnGuardarFondoRotativo.Enabled = False
        End Sub
         
        Private Sub CargarRegistrosFondoRotativo()
            Try
                dgvFondoRotativo.DataSource = _objetoFondoRotativo.SeleccionarFondoRotativo(_tipoCon)

                dgvFondoRotativo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFondoRotativo.Columns(0).HeaderText = "ID FR"
                dgvFondoRotativo.Columns(1).HeaderText = "DETALLE DE FONDO"
                dgvFondoRotativo.Columns(2).HeaderText = "MONTO"
                dgvFondoRotativo.Columns(3).HeaderText = "CUENTA CONTABLE"
                dgvFondoRotativo.Columns(4).HeaderText = "TIPO CUENTA"
                dgvFondoRotativo.Columns(5).HeaderText = "NIVEL CUENTA"
                dgvFondoRotativo.Columns(6).HeaderText = "EST"
                dgvFondoRotativo.Columns(7).HeaderText = "ID PRO"
                dgvFondoRotativo.Columns(8).HeaderText = "ID CIU"
                dgvFondoRotativo.Columns(9).HeaderText = "ID PAR"
                dgvFondoRotativo.Columns(10).HeaderText = "ID CC"
                dgvFondoRotativo.Columns(11).HeaderText = "ID PER"
                dgvFondoRotativo.AutoResizeColumns()
                dgvFondoRotativo.AutoResizeRows()
                dgvFondoRotativo.ReadOnly = True
            Catch
                dgvFondoRotativo.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvFondoRotativo_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFondoRotativo.SelectionChanged
            If dgvFondoRotativo.RowCount = 0 Then Return
            If dgvFondoRotativo.CurrentRow Is Nothing Then Return
            txtIdFondoRotativo.Text = dgvFondoRotativo.CurrentRow.Cells(0).Value

            txtDetalleFondoRotativo.Text = dgvFondoRotativo.CurrentRow.Cells(1).Value
            txtMontoFondoRotativo.Text = dgvFondoRotativo.CurrentRow.Cells(2).Value

            txtCtaContableFondo.Text = dgvFondoRotativo.CurrentRow.Cells(3).Value
            cmbTipoCuenta.Text = dgvFondoRotativo.CurrentRow.Cells(4).Value
            cmbNivelCuenta.Text = dgvFondoRotativo.CurrentRow.Cells(5).Value

            cmbProvincia.SelectedValue = dgvFondoRotativo.CurrentRow.Cells(7).Value
            cmbCanton.SelectedValue = dgvFondoRotativo.CurrentRow.Cells(8).Value
            cmbParroquia.SelectedValue = dgvFondoRotativo.CurrentRow.Cells(9).Value
            cmbCentroCosto.SelectedValue = dgvFondoRotativo.CurrentRow.Cells(10).Value
        End Sub
         
    End Class
End Namespace