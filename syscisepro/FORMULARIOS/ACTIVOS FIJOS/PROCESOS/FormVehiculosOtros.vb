Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.PARAMETROS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES.VEHICULOS
Imports Krypton.Toolkit
Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormVehiculosOtros
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

        ReadOnly _objVehiculosOtros As New ClassVehiculosOtros
        ReadOnly _objetoMarca As New ClassMarca
        ReadOnly _objetoColor As New ClassColor

        Private Sub Habilitar(ByVal nombreVehiculo As Boolean, ByVal responsable As Boolean, ByVal tipoVehiculo As Boolean, ByVal nombreCustodio As Boolean, ByVal placas As Boolean, ByVal chasis As Boolean, ByVal marca As Boolean, ByVal modelo As Boolean, ByVal serie As Boolean, ByVal motor As Boolean, ByVal cilindraje As Boolean, ByVal soat As Boolean, ByVal color As Boolean, ByVal capacidad As Boolean, ByVal ubicacion As Boolean, ByVal tipoCustodio As Boolean)
            txtNombreVehiculo.Enabled = nombreVehiculo
            txtResponsable.Enabled = responsable
            nudCapacidad.Enabled = tipoVehiculo
            txtNombreCustodio.Enabled = nombreCustodio
            txtPlacaVehiculo.Enabled = placas
            txtChasisVehiculo.Enabled = chasis
            cbmMarca.Enabled = marca
            txtModeloVehiculo.Enabled = modelo
            txtSerieVehiculo.Enabled = serie
            txtMotorVehiculo.Enabled = motor
            txtCilindrajeVehiculo.Enabled = cilindraje
            dtpSoat.Enabled = soat
            cbmColorVehiculo.Enabled = color
            txtTipoVehiculo.Enabled = capacidad
            txtUbicacion.Enabled = ubicacion
            cbmTipoCustodio.Enabled = tipoCustodio
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            Habilitar(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
            txtNombreVehiculo.Focus()
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtIdVehiculoOtros.Text <> "" And txtResponsable.Text <> "" And nudCapacidad.Text <> "" And txtNombreVehiculo.Text <> "" And txtNombreCustodio.Text <> "" And txtPlacaVehiculo.Text <> "" And txtChasisVehiculo.Text <> "" And cbmMarca.Text <> "" And txtModeloVehiculo.Text <> "" And _
               txtSerieVehiculo.Text <> "" And txtMotorVehiculo.Text <> "" And txtCilindrajeVehiculo.Text <> "" And cbmColorVehiculo.Text <> "" And txtTipoVehiculo.Text <> "" And txtUbicacion.Text <> "" And cbmTipoCustodio.Text <> "" Then

                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objVehiculosOtros
                    .Id = _objVehiculosOtros.BuscarMayorIdVehiculosOtros(_tipoCon) + 1
                    .Nombre = txtNombreVehiculo.Text.ToUpper
                    .Responsable = txtResponsable.Text.ToUpper
                    .Tipo = txtTipoVehiculo.Text.ToUpper
                    .NombreCustodio = txtNombreCustodio.Text.ToUpper
                    .Placas = txtPlacaVehiculo.Text.ToUpper
                    .Chasis = txtChasisVehiculo.Text.ToUpper
                    .Marca = cbmMarca.Text.ToUpper
                    .Modelo = txtModeloVehiculo.Text.ToUpper
                    .Serie = txtSerieVehiculo.Text.ToUpper
                    .Motor = txtMotorVehiculo.Text.ToUpper
                    .Cilindraje = txtCilindrajeVehiculo.Text.ToUpper
                    .Soat = dtpSoat.Text
                    .Color = cbmColorVehiculo.Text.ToUpper
                    .Capacacidad = nudCapacidad.Text
                    .Ubicacion = txtUbicacion.Text.ToUpper
                    .TipoCustodio = cbmTipoCustodio.Text.ToUpper
                    .Estado = 1
                End With
                _sqlCommands.Add(_objVehiculosOtros.NuevaVehiculosOtros)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    btnGuardar.Enabled = False
                    btnNuevo.Enabled = True
                    btnCancelar.Enabled = False
                    txtIdVehiculoOtros.Text = ""
                    txtResponsable.Text = ""
                    txtNombreVehiculo.Text = ""
                    txtNombreCustodio.Text = ""
                    txtPlacaVehiculo.Text = ""
                    txtChasisVehiculo.Text = ""
                    cbmMarca.Text = ""
                    txtModeloVehiculo.Text = ""
                    txtSerieVehiculo.Text = ""
                    txtMotorVehiculo.Text = ""
                    txtCilindrajeVehiculo.Text = ""
                    cbmColorVehiculo.Text = ""
                    txtTipoVehiculo.Text = ""
                    txtUbicacion.Text = ""
                    cbmTipoCustodio.Text = ""

                    CargarVehiculosOtros()
                    Habilitar(False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False)
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Else
                MsgBox("No se puede guardar el registro si no llena todos los parámetros necesarios", MsgBoxStyle.Information, "Mensaje de información")
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
        End Sub

        Private Sub CargarVehiculosOtros()
            dgvVehiculos.DataSource = _objVehiculosOtros.SeleccionarRegistrosVehiculosOtros(_tipoCon)
            dgvVehiculos.AutoResizeColumns()
            dgvVehiculos.AutoResizeRows()
        End Sub

        Private Sub LlenarComboMarcas()
            Try
                cbmMarca.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarca.DisplayMember = "DETALLE"
                cbmMarca.ValueMember = "DETALLE"
                cbmMarca.DropDownWidth = 400
            Catch
                cbmMarca.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColores()
            Try
                cbmColorVehiculo.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorVehiculo.DisplayMember = "DETALLE"
                cbmColorVehiculo.ValueMember = "DETALLE"
                cbmColorVehiculo.DropDownWidth = 200
            Catch
                cbmColorVehiculo.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
            CargarVehiculosOtros()
            LlenarComboColores()
            LlenarComboMarcas()
        End Sub

        Private Sub FormVehiculosOtros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
        End Sub
    End Class
End Namespace