Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    '''CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormEstablecerCajasChicas

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


        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objCentroCostos As New ClassCentroCosto
        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objCajaChica As New ClassCajaChica
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _validacionesDecimales As New ClassDecimal

        Dim _botonSelecionado As Integer

        Private Sub FormEstablecerCajasChicas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCajas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'MenuStrip1.ForeColor = Color.White
                    dgvCajas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'MenuStrip1.ForeColor = Color.White
                    dgvCajas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCajas.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            LlenarComboProvincias()
            LlenarComboCentroCostos()

        End Sub
        Private Sub LlenarComboProvincias()
            Try
                cbmProvincia.DataSource = _objProvincia.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincia.DisplayMember = "NOMBRE_PROVINCIAS"
                cbmProvincia.ValueMember = "ID_PROVINCIAS"
                cbmProvincia.DropDownWidth = 300
                If (CType(cbmProvincia.DataSource, DataTable).Rows.Count > 0) Then cbmProvincia.SelectedValue = 7
            Catch
                cbmProvincia.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmProvincia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincia.SelectedValueChanged
            If cbmProvincia.SelectedValue Is Nothing Or TypeOf cbmProvincia.SelectedValue Is DataRowView Then Return
            LlenarComboCiudad()
        End Sub
        Private Sub LlenarComboCiudad()
            Try
                cbmCiudad.DataSource = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, CInt(cbmProvincia.SelectedValue))
                cbmCiudad.DisplayMember = "NOMBRE_CIUDADES"
                cbmCiudad.ValueMember = "ID_CIUDAD"
                cbmCiudad.DropDownWidth = 300
                If (CType(cbmCiudad.DataSource, DataTable).Rows.Count > 0) Then cbmCiudad.SelectedIndex = 0
            Catch
                cbmCiudad.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCiudad.SelectedValueChanged
            If cbmCiudad.SelectedValue Is Nothing Or TypeOf cbmCiudad.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub
        Private Sub LlenarComboParroquias()
            Try
                cbmParroquia.DataSource = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, CInt(cbmCiudad.SelectedValue))
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cbmParroquia.ValueMember = "ID_PARROQUIAS"
                cbmParroquia.DropDownWidth = 300
                If (CType(cbmParroquia.DataSource, DataTable).Rows.Count > 0) Then cbmParroquia.SelectedIndex = 0
            Catch
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboCentroCostos()
            Try
                cbmCentroCosto.DataSource = _objCentroCostos.SeleccionarCentroCosto(_tipoCon)
                cbmCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cbmCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cbmCentroCosto.DropDownWidth = 300
                If (CType(cbmCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cbmCentroCosto.SelectedIndex = 0
            Catch
                cbmCentroCosto.DataSource = Nothing
            End Try
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarCustodiosCajas()
        End Sub
        Private Sub CargarCustodiosCajas()
            Try
                dgvCajas.DataSource = _objPersonal.SeleccionarCajasChicasCustodios(_tipoCon)
                If dgvCajas.DataSource Is Nothing Then Return
                If dgvCajas.Rows.Count = 0 Then Return

                dgvCajas.Columns(0).HeaderText = "ID"
                dgvCajas.Columns(0).Width = 30
                dgvCajas.Columns(1).HeaderText = "DETALLE"
                dgvCajas.Columns(1).Width = 220

                dgvCajas.Columns(2).HeaderText = "MONTO"
                dgvCajas.Columns(2).Width = 60
                dgvCajas.Columns(3).HeaderText = "GASTO"
                dgvCajas.Columns(3).Width = 60

                dgvCajas.Columns(4).HeaderText = "CUENTA"
                dgvCajas.Columns(4).Width = 80
                dgvCajas.Columns(5).Visible = False
                dgvCajas.Columns(6).Visible = False
                dgvCajas.Columns(7).Visible = False
                dgvCajas.Columns(8).Visible = False
                dgvCajas.Columns(9).Visible = False
                dgvCajas.Columns(10).Visible = False

                dgvCajas.Columns(11).HeaderText = "ID"
                dgvCajas.Columns(11).Width = 40
                dgvCajas.Columns(12).HeaderText = "C.I."
                dgvCajas.Columns(12).Width = 80
                dgvCajas.Columns(13).HeaderText = "NOMBRES CUSTODIO"
                dgvCajas.Columns(13).Width = 150
                dgvCajas.Columns(14).HeaderText = "APELLIDOS CUSTODIO"
                dgvCajas.Columns(14).Width = 150

                dgvCajas.AutoResizeRows()

                btnModificar.Enabled = dgvCajas.RowCount > 0 And Not dgvCajas.CurrentRow Is Nothing
            Catch
                dgvCajas.DataSource = Nothing
            End Try
        End Sub
        Private Sub LimpiarCaja()
            txtIdCajaChica.Clear()
            txtIdCustodio.Clear()
            lblNombres.Clear()
            txtDetalle.Clear()
            txtMonto.Clear()
            txtValorGasto.Clear() 
            txtCuentaContable.Clear()
        End Sub
        Private Sub dgvCajas_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCajas.SelectionChanged
            If dgvCajas.DataSource Is Nothing Or dgvCajas.RowCount = 0 Or _botonSelecionado <> 0 Then
                LimpiarCaja()
                Return
            End If
            txtIdCajaChica.Text = dgvCajas.CurrentRow.Cells(0).Value
            txtIdCustodio.Text = dgvCajas.CurrentRow.Cells(11).Value
            lblNombres.Text = dgvCajas.CurrentRow.Cells(14).Value & " " & dgvCajas.CurrentRow.Cells(13).Value
            txtDetalle.Text = dgvCajas.CurrentRow.Cells(1).Value
            txtMonto.Text = dgvCajas.CurrentRow.Cells(2).Value
            txtValorGasto.Text = dgvCajas.CurrentRow.Cells(3).Value
            txtCuentaContable.Text = dgvCajas.CurrentRow.Cells(4).Value
            cbmCentroCosto.SelectedValue = dgvCajas.CurrentRow.Cells(7).Value
            cbmProvincia.SelectedValue = dgvCajas.CurrentRow.Cells(8).Value
            cbmCiudad.SelectedValue = dgvCajas.CurrentRow.Cells(9).Value
            cbmParroquia.SelectedValue = dgvCajas.CurrentRow.Cells(10).Value
            cbmNivelCuenta.Text = dgvCajas.CurrentRow.Cells(6).Value
            cbmTipoCuenta.Text = dgvCajas.CurrentRow.Cells(5).Value
        End Sub
        Private Sub btnBuscarCustodio_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarCustodio.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtIdCustodio.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        lblNombres.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                txtIdCustodio.Text = String.Empty
                lblNombres.Text = String.Empty
            End Try
            txtDetalle.Focus()
        End Sub
        Private Sub Habilitar(ByVal enable As Boolean)
            txtDetalle.Enabled = enable
            txtMonto.Enabled = enable
            txtValorGasto.Enabled = enable
            cbmCentroCosto.Enabled = enable
            cbmProvincia.Enabled = enable
            cbmCiudad.Enabled = enable
            cbmParroquia.Enabled = enable
            btnBuscarCustodio.Enabled = enable
        End Sub
        Private Sub btnNuevaCaja_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevaCaja.Click
            _botonSelecionado = 1
            LimpiarCaja()
            Habilitar(True)

            btnNuevaCaja.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
             
            cbmTipoCuenta.SelectedIndex = 0 ' 1
            cbmNivelCuenta.SelectedIndex = 5 ' 4
             
            txtDetalle.Focus()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If Not Validacion() Then
                KryptonMessageBox.Show("No se puede guardar debido a que no ha llenado todos los parámetros nesesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

                Return
            End If

            If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return

            _sqlCommands.Clear()

            Select Case (_botonSelecionado)
                Case 1

                    txtIdCajaChica.Text = _objCajaChica.BuscarMayorIdCajaChica(_tipoCon) + 1
                    If Convert.ToInt16(txtIdCajaChica.Text.Trim) < 10 Then
                        txtCuentaContable.Text = "1010101010" + txtIdCajaChica.Text
                    Else
                        txtCuentaContable.Text = "101010101" + txtIdCajaChica.Text
                    End If

                    With _objCajaChica
                        .Id = CInt(txtIdCajaChica.Text)
                        .Detalle = txtDetalle.Text.ToUpper
                        .Monto = CDec(txtMonto.Text)
                        .Valor = CDec(txtValorGasto.Text)
                        .CuentaContable = txtCuentaContable.Text
                        .TipoCuenta = cbmTipoCuenta.Text
                        .Nivel = cbmNivelCuenta.Text
                        .Estado = 1
                        .IdCentroCosto = cbmCentroCosto.SelectedValue
                        .IdProvincia = cbmProvincia.SelectedValue
                        .IdCiudad = cbmCiudad.SelectedValue
                        .IdParroquia = cbmParroquia.SelectedValue
                        .IdPersonal = CInt(txtIdCustodio.Text)                        
                    End With
                    _sqlCommands.Add(_objCajaChica.NuevaCajaChica)

                Case Else
                    With _objCajaChica
                        .Id = CInt(txtIdCajaChica.Text)
                        .Detalle = txtDetalle.Text.ToUpper
                        .Monto = CDec(txtMonto.Text)
                        .Valor = CDec(txtValorGasto.Text)
                        .IdCentroCosto = cbmCentroCosto.SelectedValue
                        .IdProvincia = cbmProvincia.SelectedValue
                        .IdCiudad = cbmCiudad.SelectedValue
                        .IdParroquia = cbmParroquia.SelectedValue
                        .IdPersonal = CInt(txtIdCustodio.Text)
                    End With
                    _sqlCommands.Add(_objCajaChica.ModificarCajaChica)
            End Select

            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                _botonSelecionado = 0

                Habilitar(False)

                btnNuevaCaja.Enabled = True
                btnGuardar.Enabled = False
                btnModificar.Enabled = True
                btnCancelar.Enabled = False

                CargarCustodiosCajas()
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If


        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            _botonSelecionado = 2

            Habilitar(True)


            btnNuevaCaja.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnCancelar.Enabled = True

            txtDetalle.Focus()
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            Habilitar(False)
            _botonSelecionado = 0

            LimpiarCaja()

            btnNuevaCaja.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = False

            CargarCustodiosCajas()
        End Sub
        Private Function Validacion() As Boolean
            Return txtIdCustodio.Text.Trim.Length > 0 And txtDetalle.Text.Trim.Length > 0 _
               And txtMonto.Text.Trim.Length > 0 And txtValorGasto.Text.Trim.Length > 0 _
               And (Not cbmCentroCosto.SelectedValue Is Nothing) And (Not cbmParroquia.SelectedValue Is Nothing)
        End Function
        Private Sub ConectarReporte()
            Dim crCajaChicasPorCustodios As New crCajasChicasCustodios
            crCajaChicasPorCustodios.SetDataSource(_objCajaChica.SeleccionarCajasChicaParametros(_tipoCon))
            crCajaChicasPorCustodios.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvCajasChicasCustodios.ReportSource = crCajaChicasPorCustodios
            crvCajasChicasCustodios.Zoom(75)
            crvCajasChicasCustodios.Refresh()
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            tcDatos.SelectedIndex = 1
            conectarReporte()
        End Sub

        Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorGasto.KeyPress, txtMonto.KeyPress
            e.Handled = Not _validacionesDecimales.esDecimal(e.KeyChar)
        End Sub
    End Class
End Namespace