Imports System.Data.SqlClient
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
Imports syscisepro.FORMULARIOS.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports System.Xml
Imports System.Text
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports Krypton.Toolkit


Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormSolicitudFondoRotativo
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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
        Public UserName As String
        ReadOnly _objetoGastosFondoRotativo As New ClassGastosFondoRotativo
        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudades As New ClassCiudades
        ReadOnly _objetoParroquias As New ClassParroquias
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objetoResponsableAutorizacion As New ClassResponsableAutorizacionFondoRotativo
        ReadOnly _objetoParametroDocumentos As New ClassParametroDocumentos
        ReadOnly _objRubros As New ClassRubrosFondoRotativo
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _objetoDetalleRetencionPlanCuentas As New ClassDetalleRetencionPlanCuentas
        Dim _objetoSolicitudFondoRotativo As ClassSolicitudFondoRotativo
        Dim _objetoFondoRotativo As ClassFondoRotativo
        Dim _objetoAuxiliarFondoRotativo As ClassAuxiliarFondoRotativo
        Dim _objLlegada As ClassLlegadaVehiculosControlCombustible
        Dim _objSalida As ClassSalidaVehiculoControlCombustible
        Dim _objetoControlcombustible As ClassControlCombustible
        Dim _objetoComprobantesCompra As ClassComprobantesCompra
        Dim _objetoInformacionTributaria As ClassInformacionTributaria
        Dim _objetoComprobantesRetencion As ClassComprobantesRetencion
        Dim _objetoDetalleComprobantesRetencion As ClassDetalleComprobantesRetencion
        Dim _objetoDocumentoNoDeducible As ClassDocumentoNoDeducible
        Dim _objetoHistorial As ClassHistorialLaboral
        Dim _objRegistroDescuento As ClassDescuentosPersonal
        Dim _objetoAnticipoPrestamo As ClassAnticiposPrestamos
        Dim _objetoAts As ClassAnexoTransaccional
        Dim _objAuditoria As ClassAuditoriaGeneral
        Dim _formDocumentoNoDeducible As FormDocumentosNoDeducibles
        Dim _formComprobanteCompra As FormRegistroComprobanteCompra
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral


        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= COMPROBANTE DE COMPRA =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Dim _idProveedorGeneral As Int64
        Dim _rucProveedorGeneral As String
        Dim _razonSocialProveedorGeneral As String
        Dim _direccionProveedorGeneral As String
        Dim _tipoComprobanteCompra As String
        Dim _numeroComprobanteCompra As String
        Dim _numAutoSriComprobanteCompra As String
        Dim _fechaAutoSriComprobantecompra As DateTime
        Dim _fechaEmisionComprobanteCompra As DateTime
        Dim _guiaRemisionComprobanteCompra As String
        Dim _docModComprobanteCompra As String
        Dim _razModComprobanteCompra As String
        Dim _observacionComprobanteCompra As String
        Dim _subtotal12ComprobanteCompra As Decimal
        Dim _subtotal0ComprobanteCompra As Decimal
        Dim _descuentoComprobanteCompra As Decimal
        Dim _subtotalComprobanteCompra As Decimal
        Dim _porcentajeIvaComprobanteCompra As Decimal
        Dim _ivaComprobanteCompra As Decimal
        Dim _totalComprobanteCompra As Decimal
        Dim _idOrdenCompora As Decimal
        Dim _tipoBs As Integer

        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= COMPROBANTE DE RETENCIÓN =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA
        Dim _idEmpresaCisepro As Integer
        Dim _rucEmpresaCisepro As String = ""
        Dim _razonSocialEmpresaCisepro As String = "" ' razon social de la empresa emisora de la factura electrónica
        Dim _nombreComercialEmpresaCisepro As String = ""
        Dim _direccionEmpresaCisepro As String = ""

        Dim _numAutoContEspecialCisepro As String = ""
        Dim _ptoEmisionRetencion As String = ""
        Dim _establecimientoRetencion As String = ""
        Dim _secuencialRetencion As String = 0
        Dim _claveAccesoRetencion As String = "" ' clave de acceso para envio de la factura electrónica

        Dim _ptoEmisionLiqCompra As String = ""
        Dim _establecimientoLiqCompra As String = ""
        Dim _secuencialLiqCompra As String = 0
        Dim _claveAccesoLiqCompra As String

        Dim _tipoIdentificacionProveedor As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
        Dim _numComprobanteRetencion As String
        Dim _fechaAutoSriComprobanteRetencion As String
        Dim _fechaEmisionComprobanteRetencion As Date
        Dim _totalComprobanteRetencion As Decimal

        Dim _numeroDocumentoNoDeducible As String
        Dim _fechaDocumentoNoDeducible As Date
        Dim _descripcionDocumentoNoDeducible As String
        Dim _valorDocumentoNoDeducible As Decimal

        Dim _validarComprobanteRetencion As Integer '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE
        Dim _validarComprobanteLiqCompra As Integer '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE
        Dim _validarLlenarDocumento As Integer  '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE

        Private Sub FormSolicitudFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'lblMontoFondoRotativo.ForeColor = Color.White
                    'lblMontoFondoRotativo.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'lblMontoFondoRotativo.ForeColor = Color.White
                    'lblMontoFondoRotativo.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'lblMontoFondoRotativo.ForeColor = Color.White
                    'lblMontoFondoRotativo.BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            AutocompletarNombreCliente()
        End Sub
        Private Sub LimpiarVariables()
            _tipoAmbiente = 0
            _tipoEmision = 0
            _idEmpresaCisepro = Nothing
            _rucEmpresaCisepro = ""
            _razonSocialEmpresaCisepro = ""
            _nombreComercialEmpresaCisepro = ""
            _direccionEmpresaCisepro = ""
            _numAutoContEspecialCisepro = ""
            _establecimientoRetencion = ""
            _ptoEmisionRetencion = ""
            _secuencialRetencion = 0
            _claveAccesoRetencion = ""
            _tipoIdentificacionProveedor = ""
            _numComprobanteRetencion = ""
            _fechaAutoSriComprobanteRetencion = DateTime.MinValue
            _fechaEmisionComprobanteRetencion = DateTime.MinValue
            _totalComprobanteRetencion = 0.0
            dgvDetallesRetencion.Rows.Clear()

            _idProveedorGeneral = 0
            _rucProveedorGeneral = ""
            _razonSocialProveedorGeneral = ""
            _direccionProveedorGeneral = ""

            _numeroDocumentoNoDeducible = ""
            _fechaDocumentoNoDeducible = DateTime.MinValue
            _descripcionDocumentoNoDeducible = ""
            _valorDocumentoNoDeducible = 0.0

            _validarComprobanteRetencion = 0
            _validarLlenarDocumento = 0
        End Sub

        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialCliente.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialCliente.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialCliente.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub DeshabilitadoInicio()
            txtFechaSolicitudFR.Enabled = False

            cmbConcepto.Enabled = False
            cmbProvincia.Enabled = False
            cmbCanton.Enabled = False
            cmbParroquia.Enabled = False
            cmbCentroCosto.Enabled = False

            cmbCargoResponsableAutoFR.Enabled = False

            btnBuscarPersonal.Enabled = False

            GroupBox3.Enabled = False
            'gbCombustible.Enabled = False
            chkCombustible.Enabled = False

            txtValorSolicitudFR.Enabled = False
            txtDetalleSolicitudFR.Enabled = False
            cmbNombreParametroDocumentos.Enabled = False
            txtNombreComercialCliente.Enabled = False

            btnNuevoSolicitudFR.Enabled = True
            btnGuardarSolicitudFR.Enabled = False
            btnDocumento.Enabled = False
            btnCancelarSolicitudFR.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtFechaSolicitudFR.Enabled = True

            cmbConcepto.Enabled = True
            cmbProvincia.Enabled = True
            cmbCanton.Enabled = True
            cmbParroquia.Enabled = True
            cmbCentroCosto.Enabled = True

            cmbCargoResponsableAutoFR.Enabled = True

            btnBuscarPersonal.Enabled = True

            chkCombustible.Enabled = True

            txtValorSolicitudFR.Enabled = True
            txtDetalleSolicitudFR.Enabled = True
            cmbNombreParametroDocumentos.Enabled = True

            btnNuevoSolicitudFR.Enabled = False
            btnGuardarSolicitudFR.Enabled = True
            btnDocumento.Enabled = True
            btnCancelarSolicitudFR.Enabled = True
            txtNombreComercialCliente.Enabled = True
        End Sub

        Private Sub LimpiarParametros()
            txtNroSolicitudFR.Tag = Nothing
            txtNroSolicitudFR.Clear()
            txtActividadDetalleFR.Clear()

            txtCIResponsableAutoFR.Clear()
            txtNombreResponsableAutoFR.Clear()
            txtApellidoResponsableAutoFR.Clear()
            txtValorSolicitudFR.Clear()
            txtDetalleSolicitudFR.Clear()
            txtCIReceptorDinero.Clear()
            txtReceptorDineroSolicitud.Clear()

            txtCodDebe.Clear()
            txtCodHaber.Clear()
            txtNombreComercialCliente.Clear()
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoSolicitudFR.Click
            _objetoSolicitudFondoRotativo = New ClassSolicitudFondoRotativo
            _objetoFondoRotativo = New ClassFondoRotativo
            _objetoAuxiliarFondoRotativo = New ClassAuxiliarFondoRotativo
            _objLlegada = New ClassLlegadaVehiculosControlCombustible
            _objSalida = New ClassSalidaVehiculoControlCombustible
            _objetoControlcombustible = New ClassControlCombustible
            _objetoComprobantesCompra = New ClassComprobantesCompra
            _objetoInformacionTributaria = New ClassInformacionTributaria
            _objetoComprobantesRetencion = New ClassComprobantesRetencion
            _objetoDetalleComprobantesRetencion = New ClassDetalleComprobantesRetencion
            _objetoDocumentoNoDeducible = New ClassDocumentoNoDeducible
            _objetoHistorial = New ClassHistorialLaboral
            _objetoAnticipoPrestamo = New ClassAnticiposPrestamos
            _objetoAts = New ClassAnexoTransaccional
            _objAuditoria = New ClassAuditoriaGeneral
            _objRegistroDescuento = New ClassDescuentosPersonal

            LimpiarVariables()

            LimpiarParametros()

            LlenarComboConceptoGastoFr()

            LlenarComboProvincias()
            cmbCanton.SelectedValue = 58 ' MACHALA
            cmbParroquia.SelectedValue = 287 ' MACHALA

            LlenarComboCentroCostos()
            LlenarComboCargoResponsable()
            LlenarComboParametroDocumentos()

            VerificarMontoFondoRotativo()

            HabilitadoNuevo()

            txtFechaSolicitudFR.Text = Date.Now
            txtActividadDetalleFR.Text = "101010102"
            txtCodHaber.Text = "101010102"
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarSolicitudFR.Click
            chkCombustible.Checked = False
            LimpiarParametros()
            LimpiarParametrosControlCombustible()
            LimpiarVariables()
            DeshabilitadoInicio()
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

        Private Sub LlenarComboCentroCostos()
            Try
                Dim data = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
                cmbCentroCosto.DataSource = data
                cmbCentroCosto.DisplayMember = "DETALLE_CENTRO_COSTO"
                cmbCentroCosto.ValueMember = "ID_CENTRO_COSTO"
                cmbCentroCosto.DropDownWidth = 300
                If (CType(cmbCentroCosto.DataSource, DataTable).Rows.Count > 0) Then cmbCentroCosto.SelectedIndex = 0
            Catch
                cmbCentroCosto.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboCargoResponsable()
            Try
                cmbCargoResponsableAutoFR.DataSource = _objetoResponsableAutorizacion.SeleccionarResponsablesAutorizacionFondoRotativo(_tipoCon)
                cmbCargoResponsableAutoFR.DisplayMember = "CARGO_RESPONSABLE_AUTO_FR"
                cmbCargoResponsableAutoFR.ValueMember = "ID_RESPONSABLE_AUTO_FR"
                cmbCargoResponsableAutoFR.DropDownWidth = 300
                If (CType(cmbCargoResponsableAutoFR.DataSource, DataTable).Rows.Count > 0) Then cmbCargoResponsableAutoFR.SelectedIndex = 0
            Catch
                cmbCargoResponsableAutoFR.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbCargoResponsableAutoFR_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCargoResponsableAutoFR.SelectedValueChanged
            If cmbCargoResponsableAutoFR.SelectedValue Is Nothing Or TypeOf cmbCargoResponsableAutoFR.SelectedValue Is DataRowView Then Return
            Try
                Dim cargoCombo = cmbCargoResponsableAutoFR.Text
                txtCIResponsableAutoFR.Text = _objetoResponsableAutorizacion.BuscarCedulaResponsablesFondoRotativoXCargo(_tipoCon, cargoCombo)
                txtNombreResponsableAutoFR.Text = _objetoResponsableAutorizacion.BuscarNombreResponsablesFondoRotativoXCargo(_tipoCon, cargoCombo)
                txtApellidoResponsableAutoFR.Text = _objetoResponsableAutorizacion.BuscarApellidoResponsablesFondoRotativoXCargo(_tipoCon, cargoCombo)
            Catch
                txtCIResponsableAutoFR.Clear()
                txtNombreResponsableAutoFR.Clear()
                txtApellidoResponsableAutoFR.Clear()
            End Try
        End Sub

        Private Sub LlenarComboParametroDocumentos()
            Try
                cmbNombreParametroDocumentos.DataSource = _objetoParametroDocumentos.SeleccionarParametrosDocumentos(_tipoCon)
                cmbNombreParametroDocumentos.DisplayMember = "NOMBRE_PARAMETRO_DOCUMENTOS"
                cmbNombreParametroDocumentos.ValueMember = "ID_PARAMETRO_DOCUMENTOS"
                cmbNombreParametroDocumentos.DropDownWidth = 300
                If (CType(cmbNombreParametroDocumentos.DataSource, DataTable).Rows.Count > 0) Then cmbNombreParametroDocumentos.SelectedIndex = 0
            Catch
                cmbNombreParametroDocumentos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbNombreParametroDocumentos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbNombreParametroDocumentos.SelectedValueChanged
            If cmbNombreParametroDocumentos.SelectedValue Is Nothing Or TypeOf cmbNombreParametroDocumentos.SelectedValue Is DataRowView Then Return
            cmbNombreParametroDocumentos.Tag = _objetoParametroDocumentos.BuscarTipoParametroDocumentosXId(_tipoCon, cmbNombreParametroDocumentos.SelectedValue)
        End Sub

        Private Sub LlenarComboConceptoGastoFr()
            Try
                cmbConcepto.DataSource = _objetoGastosFondoRotativo.SeleccionarGastosFondoRotativo(_tipoCon)
                cmbConcepto.DisplayMember = "NOMBRE_GASTOS_FR"
                cmbConcepto.ValueMember = "ID_GASTOS_FR"
                cmbConcepto.DropDownWidth = 300
                If (CType(cmbConcepto.DataSource, DataTable).Rows.Count > 0) Then cmbConcepto.SelectedIndex = 0
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbConcepto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbConcepto.SelectedValueChanged
            If cmbConcepto.SelectedValue Is Nothing Or TypeOf cmbConcepto.SelectedValue Is DataRowView Then Return
            txtCodDebe.Text = _objetoGastosFondoRotativo.BuscarCtaContableGastosFondoRotativoXNombre(_tipoCon, cmbConcepto.Text)
            If CInt(cmbConcepto.SelectedValue) = 2 Then
                GroupBox3.Enabled = True
                'gbCombustible.Enabled = True
                chkCombustible.Checked = True

                KryptonMessageBox.Show("No se olvide de realizar el control del combustible!", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                GroupBox3.Enabled = False
                'gbCombustible.Enabled = False
                chkCombustible.Checked = False
            End If
        End Sub
        Private Sub chkCombustible_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCombustible.CheckedChanged
            btnBuscarVehiculo.Enabled = chkCombustible.Checked
            LlenarComboCombustibles()
            LimpiarParametrosControlCombustible()
            txtDestinoControlC.Focus()
        End Sub

        Private Sub LlenarComboCombustibles()
            Try
                cbmCombustible.DataSource = _objRubros.SeleccionarRegistrosRubros(_tipoCon)
                cbmCombustible.DisplayMember = "NOMBRE_RUBRO"
                cbmCombustible.ValueMember = "ID_RUBRO"
                cbmCombustible.DropDownWidth = 100
                If (CType(cbmCombustible.DataSource, DataTable).Rows.Count > 0) Then cbmCombustible.SelectedIndex = 0
            Catch
                cbmCombustible.DataSource = Nothing
            End Try
        End Sub

        Private Sub LimpiarParametrosControlCombustible()
            txtIdActivoFijo.Clear()
            txtMarcaVehiculo.Clear()
            txtModeloVehiculo.Clear()
            txtPlacaVehiculo.Clear()
            txtValorControl.Text = 0.0
            txtKmLlegadaVehiculo.Text = 0.0
            txtKmSalidaVehiculo.Text = 0.0
            txtDestinoControlC.Clear()
            txtMotivoControlC.Clear()
            txtTotalKmControlC.Text = 0.0
        End Sub

        Private Sub VerificarMontoFondoRotativo()
            Try
                Dim fr = _objetoFondoRotativo.SeleccionarFondoRotativo(_tipoCon)

                Dim montoFondoRotativo = _objetoAuxiliarFondoRotativo.BuscarMontoAuxiliarFondoRotativo(_tipoCon)

                lblMontoAsignado.Text = CDbl(fr.Rows(0)(2)).ToString("N")
                lblMontoFondoRotativo.Text = CDbl(montoFondoRotativo).ToString("N")

                If montoFondoRotativo < 35 Then

                    KryptonMessageBox.Show("HA SUPERADO EL 95% DE SU FONDO. POR FAVOR REALICE LIQUIDACIÓN INMEDIATAMENTE!!!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                ElseIf montoFondoRotativo < 70 Then

                    KryptonMessageBox.Show("HA SUPERADO EL 90% DE SU FONDO. POR FAVOR REALICE LIQUIDACIÓN", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
                End If
            Catch ex As Exception

                KryptonMessageBox.Show("Error: " & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnBuscarPersonal_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.Todos = True
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtReceptorDineroSolicitud.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtReceptorDineroSolicitud.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                        txtCIReceptorDinero.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value
                    End If
                End If
            Catch ex As Exception
                txtReceptorDineroSolicitud.Tag = Nothing
                txtReceptorDineroSolicitud.Clear()
                txtCIReceptorDinero.Clear()
            End Try
        End Sub
        Private Sub btnDocumento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDocumento.Click
            If cmbNombreParametroDocumentos.Tag.ToString() = "DEDUCIBLE" Then
                Try
                    _formComprobanteCompra = New FormRegistroComprobanteCompra
                    _formComprobanteCompra.chkActivoFijo.Visible = False
                    _formComprobanteCompra.TipoCox = TipoCox
                    _formComprobanteCompra.CuentasConceptoCompra = 2 ' fondo
                    _formComprobanteCompra.IsDialog = True
                    _formComprobanteCompra.ValorMaximo = CDbl(lblMontoFondoRotativo.Text)
                    _formComprobanteCompra.btnGuardar.Visible = False
                    _formComprobanteCompra.btnGuardarEnFondoRotativo.Visible = True
                    _formComprobanteCompra.btnNuevo_Click(Nothing, Nothing)

                    _formComprobanteCompra.cmbNombreParametroDocumentos.SelectedValue = cmbNombreParametroDocumentos.SelectedValue
                    '_formComprobanteCompra.cmbConceptoCompra.SelectedValue = cmbConcepto.SelectedValue

                    If _formComprobanteCompra.ShowDialog <> DialogResult.OK Then Return

                    If (CDbl(_formComprobanteCompra.txtTotalComprobanteCompra.Text) - CDbl(_formComprobanteCompra.txtTotalComprobanteRetencion.Text)) > CDbl(lblMontoFondoRotativo.Text) Then Throw New Exception("No se permite procesar un valor mayor monto disponible para fondo rotativo ($" & lblMontoFondoRotativo.Text & ")!")

                    cmbNombreParametroDocumentos.SelectedValue = _formComprobanteCompra.cmbNombreParametroDocumentos.SelectedValue
                    'cmbConcepto.SelectedValue = _formComprobanteCompra.cmbConceptoCompra.SelectedValue
                    dtpFechaEmisionComprobanteCompra.Value = _formComprobanteCompra.dtpFechaEmisionComprobanteCompra.Value

                    _idProveedorGeneral = _formComprobanteCompra.lblIdProveedorGeneral.Text
                    _tipoIdentificacionProveedor = _formComprobanteCompra.TipoIdentificacionProveedor
                    _rucProveedorGeneral = _formComprobanteCompra.txtRucProveedorGeneral.Text
                    _razonSocialProveedorGeneral = _formComprobanteCompra.txtNombreComercialProveedorGeneral.Text
                    _direccionProveedorGeneral = _formComprobanteCompra.txtDireccionProveedorGeneral.Text
                    _tipoComprobanteCompra = _formComprobanteCompra.cmbNombreParametroDocumentos.Text
                    _numeroComprobanteCompra = _formComprobanteCompra.txtNumeroComprobanteCompra.Text
                    _numAutoSriComprobanteCompra = _formComprobanteCompra.txtNumAutoSRIComprobanteCompra.Text
                    _fechaAutoSriComprobantecompra = _formComprobanteCompra.dtpFechaAutoSRIComprobanteCompra.Value
                    _fechaEmisionComprobanteCompra = _formComprobanteCompra.dtpFechaEmisionComprobanteCompra.Value
                    _guiaRemisionComprobanteCompra = _formComprobanteCompra.txtGuiaRemisionComprobanteCompra.Text
                    _docModComprobanteCompra = _formComprobanteCompra.txtDocModComprobanteCompra.Text
                    _razModComprobanteCompra = _formComprobanteCompra.txtRazModComprobanteCompra.Text
                    _observacionComprobanteCompra = _formComprobanteCompra.txtObservacionesComprobantesCompra.Text
                    _subtotal12ComprobanteCompra = _formComprobanteCompra.txtSubtotal12FacturaCompra.Text
                    _subtotal0ComprobanteCompra = _formComprobanteCompra.txtSubtotal0FacturaCompra.Text
                    _descuentoComprobanteCompra = _formComprobanteCompra.txtDescuentoFacturaCompra.Text
                    _subtotalComprobanteCompra = _formComprobanteCompra.txtSubTotalComprobanteCompra.Text
                    _porcentajeIvaComprobanteCompra = _formComprobanteCompra.PorcentajeIva
                    _ivaComprobanteCompra = _formComprobanteCompra.txtIvaComprobanteCompra.Text
                    _totalComprobanteCompra = _formComprobanteCompra.txtTotalComprobanteCompra.Text
                    _idOrdenCompora = If(_formComprobanteCompra.lblOrdenCompra.Text.Equals("###"), 0, CInt(_formComprobanteCompra.lblOrdenCompra.Text))
                    _tipoBs = _formComprobanteCompra.cmbBienServicio.SelectedIndex

                    If _formComprobanteCompra.chkActivarRetencion.Checked Then
                        dtpComprobanteRetencion.Value = _formComprobanteCompra.dtpComprobanteRetencion.Value

                        _idEmpresaCisepro = _formComprobanteCompra.IdEmpresaCisepro
                        _rucEmpresaCisepro = _formComprobanteCompra.RucEmpresaCisepro
                        _razonSocialEmpresaCisepro = _formComprobanteCompra.RazonSocialEmpresaCisepro
                        _nombreComercialEmpresaCisepro = _formComprobanteCompra.NombreComercialEmpresaCisepro
                        _direccionEmpresaCisepro = _formComprobanteCompra.DireccionEmpresaCisepro
                        _numAutoContEspecialCisepro = _formComprobanteCompra.NumAutoContEspecialCisepro
                        _numComprobanteRetencion = _formComprobanteCompra.txtNumeroComprobanteRetencion.Text
                        _establecimientoRetencion = ""
                        _ptoEmisionRetencion = ""
                        _secuencialRetencion = ""
                        For indiceCadena = 1 To _numComprobanteRetencion.Length
                            If indiceCadena < 4 Then
                                _establecimientoRetencion = _establecimientoRetencion + Mid(_numComprobanteRetencion, indiceCadena, 1).ToString
                            ElseIf indiceCadena > 3 And indiceCadena < 7 Then
                                _ptoEmisionRetencion = _ptoEmisionRetencion + Mid(_numComprobanteRetencion, indiceCadena, 1).ToString
                            ElseIf indiceCadena > 6 Then
                                _secuencialRetencion = _secuencialRetencion + Mid(_numComprobanteRetencion, indiceCadena, 1).ToString
                            End If
                        Next
                        _fechaEmisionComprobanteRetencion = _formComprobanteCompra.dtpComprobanteRetencion.Value
                        _fechaAutoSriComprobanteRetencion = _formComprobanteCompra.dtpComprobanteRetencion.Value
                        _totalComprobanteRetencion = _formComprobanteCompra.txtTotalComprobanteRetencion.Text
                        _tipoAmbiente = If(_formComprobanteCompra.rbProduccion.Checked, 2, 1)
                        _tipoEmision = If(_formComprobanteCompra.rbTipoEmisionNormal.Checked, 1, 2)

                        If _formComprobanteCompra.dgvDetalleComprobanteRetencion.RowCount > 0 Then
                            dgvDetallesRetencion.Rows.Clear()
                            For Each row As DataGridViewRow In _formComprobanteCompra.dgvDetalleComprobanteRetencion.Rows
                                dgvDetallesRetencion.Rows.Add(row.Cells(0).Value.ToString(), row.Cells(1).Value.ToString(), row.Cells(2).Value.ToString(), row.Cells(3).Value.ToString(), row.Cells(4).Value.ToString(), row.Cells(5).Value.ToString(), row.Cells(6).Value.ToString(), row.Cells(7).Value.ToString())
                            Next
                            _validarComprobanteRetencion = 1
                        End If

                    Else
                        _validarComprobanteRetencion = 0
                    End If

                    If _formComprobanteCompra.cmbNombreParametroDocumentos.SelectedValue = 3 Then ' LIQ. COMPRA
                        _idEmpresaCisepro = _formComprobanteCompra.IdEmpresaCisepro
                        _rucEmpresaCisepro = _formComprobanteCompra.RucEmpresaCisepro
                        _razonSocialEmpresaCisepro = _formComprobanteCompra.RazonSocialEmpresaCisepro
                        _nombreComercialEmpresaCisepro = _formComprobanteCompra.NombreComercialEmpresaCisepro
                        _direccionEmpresaCisepro = _formComprobanteCompra.DireccionEmpresaCisepro
                        _numAutoContEspecialCisepro = _formComprobanteCompra.NumAutoContEspecialCisepro
                        _numComprobanteRetencion = _formComprobanteCompra.txtNumeroComprobanteRetencion.Text

                        _establecimientoLiqCompra = ""
                        _ptoEmisionLiqCompra = ""
                        _secuencialLiqCompra = ""
                        Dim numComprobanteCompra = _formComprobanteCompra.txtNumeroComprobanteCompra.Text
                        For indiceCadena = 1 To numComprobanteCompra.Length
                            If indiceCadena < 4 Then
                                _establecimientoLiqCompra = _establecimientoLiqCompra + Mid(numComprobanteCompra, indiceCadena, 1).ToString
                            ElseIf indiceCadena > 3 And indiceCadena < 7 Then
                                _ptoEmisionLiqCompra = _ptoEmisionLiqCompra + Mid(numComprobanteCompra, indiceCadena, 1).ToString
                            ElseIf indiceCadena > 6 Then
                                _secuencialLiqCompra = _secuencialLiqCompra + Mid(numComprobanteCompra, indiceCadena, 1).ToString
                            End If
                        Next
                        _fechaEmisionComprobanteRetencion = _formComprobanteCompra.dtpComprobanteRetencion.Value
                        _fechaAutoSriComprobanteRetencion = _formComprobanteCompra.dtpComprobanteRetencion.Value
                        _totalComprobanteRetencion = _formComprobanteCompra.txtTotalComprobanteRetencion.Text
                        _tipoAmbiente = If(_formComprobanteCompra.rbProduccion.Checked, 2, 1)
                        _tipoEmision = If(_formComprobanteCompra.rbTipoEmisionNormal.Checked, 1, 2)

                        ' copiar detalles compra
                        dgvAsientosDiario.Rows.Clear()
                        For Each row As DataGridViewRow In _formComprobanteCompra.dgvAsientosDiario.Rows
                            If (row.Cells(1).Value & "").ToString().Trim().Length > 0 Then
                                dgvAsientosDiario.Rows.Add(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString)
                            End If
                        Next

                        'Dim dt As DataTable = DataGridViewToDataTable(_formComprobanteCompra.dgvAsientosDiario)

                        'For Each row As DataRow In dt.Rows
                        '    If row(1).ToString().Trim().Length > 0 Then
                        '        dgvAsientosDiario.Rows.Add(row(0).ToString(), row(1).ToString(), row(2).ToString(), row(3).ToString(), row(4).ToString())
                        '    End If
                        'Next


                        _validarComprobanteLiqCompra = 1
                    Else
                        _validarComprobanteLiqCompra = 0
                    End If

                    txtValorSolicitudFR.Text = CDec(_totalComprobanteCompra) - CDec(_totalComprobanteRetencion)
                    txtNroDocumento.Text = _formComprobanteCompra.txtNumeroComprobanteCompra.Text
                    txtDetalleSolicitudFR.Text = _formComprobanteCompra.txtObservacionesComprobantesCompra.Text.ToUpper
                    _validarLlenarDocumento = 1
                    If chkCombustible.Checked Then txtValorControl.Text = txtValorSolicitudFR.Text
                Catch ex As Exception
                    _validarLlenarDocumento = 0

                    KryptonMessageBox.Show(ex.ToString & vbNewLine & "Por favor, vuelva a ingresar los datos de la factura!", "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try
            ElseIf cmbNombreParametroDocumentos.Tag.ToString() = "NO DEDUCIBLE" Then
                Try
                    _formDocumentoNoDeducible = New FormDocumentosNoDeducibles
                    _formDocumentoNoDeducible.TipoCox = TipoCox
                    _formDocumentoNoDeducible.ValorMaximo = CDbl(lblMontoFondoRotativo.Text)

                    If _formDocumentoNoDeducible.ShowDialog <> DialogResult.OK Then Return

                    If CDbl(_formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text) > CDbl(lblMontoFondoRotativo.Text) Then Throw New Exception("No se permite procesar un valor mayor monto disponible para fondo rotativo ($" & lblMontoFondoRotativo.Text & ")!")

                    _numeroDocumentoNoDeducible = _formDocumentoNoDeducible.txtNumeroDocumentoNoDeducible.Text
                    _fechaDocumentoNoDeducible = _formDocumentoNoDeducible.dtpDocumentoNoDeducible.Value
                    _descripcionDocumentoNoDeducible = _formDocumentoNoDeducible.txtDescripcionDocumentoNoDeducible.Text.ToUpper
                    _valorDocumentoNoDeducible = _formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text

                    txtCodDebe.Text = _formDocumentoNoDeducible.lblCodigoCuentaConcepto.Text
                    txtValorSolicitudFR.Text = _formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text
                    txtDetalleSolicitudFR.Text = _formDocumentoNoDeducible.txtDescripcionDocumentoNoDeducible.Text.ToUpper
                    txtNroDocumento.Text = _formDocumentoNoDeducible.txtNumeroDocumentoNoDeducible.Text
                    _validarLlenarDocumento = 1
                    If chkCombustible.Checked Then txtValorControl.Text = txtValorSolicitudFR.Text
                Catch ex As Exception
                    _validarLlenarDocumento = 0

                    KryptonMessageBox.Show(ex.ToString & vbNewLine & "Por favor, vuelva a ingresar los datos del documento!", "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End Try
            End If
        End Sub


        Public Function DataGridViewToDataTable(dgv As DataGridView) As DataTable
            Dim dt As New DataTable()

            ' Crear las columnas en el DataTable basadas en las columnas del DataGridView
            For Each col As DataGridViewColumn In dgv.Columns
                dt.Columns.Add(col.HeaderText, GetType(String)) ' Cambia GetType si necesitas otro tipo de datos
            Next

            ' Agregar las filas desde el DataGridView al DataTable
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then ' Ignorar la fila nueva
                    Dim dataRow As DataRow = dt.NewRow()
                    For Each cell As DataGridViewCell In row.Cells
                        dataRow(cell.ColumnIndex) = If(cell.Value IsNot Nothing, cell.Value.ToString(), DBNull.Value)
                    Next
                    dt.Rows.Add(dataRow)
                End If
            Next

            Return dt
        End Function
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSolicitudFR.Click
            If txtDetalleSolicitudFR.Text.Trim().Equals("...") Or txtDetalleSolicitudFR.Text.Length < 6 Then

                KryptonMessageBox.Show("DEBE AGREGAR LA OBSERVACIÓN O DETALLE DEL DOCUMENTO!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            End If

            If txtNombreComercialCliente.Text.Length = 0 Then
                KryptonMessageBox.Show("DEBE AGREGAR EL NOMBRE DEL CLIENTE O PROVEEDOR!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            End If

            If Not ValidarFecha() Then Return
            If Not ValidarNumeroComprobanteRepetidoProveedor() Then Return
            If Not ValidarNumeroComprobanteRetencionRepetido() Then Return
            If Not ValidarNumeroComprobanteLiquidacionRepetido() Then Return
            If chkCombustible.Checked And Not ValidacionParametrosCombustible() Then

                KryptonMessageBox.Show("NO OLVIDE INGRESAR LOS DATOS DEL CONTROL DE COMBUSTIBLE!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            End If

            If ValidacionParametros() = True Then
                If _validarLlenarDocumento = 1 Then

                    If CDbl(txtValorSolicitudFR.Text) > CDbl(lblMontoFondoRotativo.Text) Then

                        KryptonMessageBox.Show("No se puede procesar un valor mayor al valor disponible en fondo rotativo ($" & lblMontoFondoRotativo.Text & ")!" & vbCrLf & " Por favor, realice una reposición", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Return
                    End If
                    _sqlCommands.Clear()

                    _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                    _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                    _objAuditoria.FormularioAuditoria = Text.Trim
                    _objAuditoria.EstadoAuditoria = 1
                    _objAuditoria.IdUsuarioAuditoria = IdUsuario
                    If cmbNombreParametroDocumentos.Tag.ToString() = "DEDUCIBLE" Then

                        If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpFechaEmisionComprobanteCompra.Value) Then
                            'MsgBox("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA INGRESAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA INGRESAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICION AL DEPARTAMENTO DE SISTEMAS.", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Else

                            ' AAUXILIARES ID
                            _objetoSolicitudFondoRotativo.IdSolicitud = _objetoSolicitudFondoRotativo.BuscarMayorIdSolicitudFondoRotativo(_tipoCon) + 1
                            _objetoComprobantesCompra.IdComprobante = _objetoComprobantesCompra.BuscarMayorIdComprobanteCompra(_tipoCon) + 1
                            GuardarComprobanteCompra()
                            GuardarRegistroSolicitudFondoRotativoNuevo()
                            ActualizarMontoFondo()
                            If _validarComprobanteRetencion = 1 Then
                                If _ptoEmisionRetencion = "002" Then
                                    Dim ep = _objetoInformacionTributaria.SeleccionarRegistrosInformacionTributaria(_tipoCon)
                                    _secuencialRetencion = CType(ep.Rows(0)(9), Int64) + 1
                                    Select Case _secuencialRetencion.Length
                                        Case 1 : _secuencialRetencion = "00000000" + _secuencialRetencion
                                        Case 2 : _secuencialRetencion = "0000000" + _secuencialRetencion
                                        Case 3 : _secuencialRetencion = "000000" + _secuencialRetencion
                                        Case 4 : _secuencialRetencion = "00000" + _secuencialRetencion
                                        Case 5 : _secuencialRetencion = "0000" + _secuencialRetencion
                                        Case 6 : _secuencialRetencion = "000" + _secuencialRetencion
                                        Case 7 : _secuencialRetencion = "00" + _secuencialRetencion
                                        Case 8 : _secuencialRetencion = "0" + _secuencialRetencion
                                        Case 9 : _secuencialRetencion = _secuencialRetencion
                                    End Select
                                End If

                                'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                                _claveAccesoRetencion = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("07", dtpComprobanteRetencion.Value, _rucEmpresaCisepro,
_tipoAmbiente, _establecimientoRetencion, _ptoEmisionRetencion,
                                                                                                         _secuencialRetencion, _tipoEmision)
                                If _claveAccesoRetencion.ToString.Length = 49 Then ' si la clave de acceso para la retencion electronica es valida
                                    If _ptoEmisionRetencion = "002" Then ActualizarSecuencial() ' actualiza el secuencial de comprobante de retencion electronico
                                    GuardarComprobanteRetencion()
                                    GuardarDetalleComprobanteRetencion()
                                Else

                                    KryptonMessageBox.Show("ERROR AL GENERAR RETENCIÓN: CLAVE DE ACCESO INVALIDA!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                    Return
                                End If
                            End If
                            If _validarComprobanteLiqCompra = 1 Then
                                If _ptoEmisionLiqCompra = "002" Then
                                    Dim ep = _objetoInformacionTributaria.SeleccionarRegistrosInformacionTributaria(_tipoCon)
                                    _secuencialLiqCompra = CLng(ep.Rows(0)(22).ToString()) + 1
                                    Select Case _secuencialLiqCompra.Length
                                        Case 1 : _secuencialLiqCompra = "00000000" + _secuencialLiqCompra
                                        Case 2 : _secuencialLiqCompra = "0000000" + _secuencialLiqCompra
                                        Case 3 : _secuencialLiqCompra = "000000" + _secuencialLiqCompra
                                        Case 4 : _secuencialLiqCompra = "00000" + _secuencialLiqCompra
                                        Case 5 : _secuencialLiqCompra = "0000" + _secuencialLiqCompra
                                        Case 6 : _secuencialLiqCompra = "000" + _secuencialLiqCompra
                                        Case 7 : _secuencialLiqCompra = "00" + _secuencialLiqCompra
                                        Case 8 : _secuencialLiqCompra = "0" + _secuencialLiqCompra
                                        Case 9 : _secuencialLiqCompra = _secuencialLiqCompra
                                    End Select
                                End If

                                'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                                _claveAccesoLiqCompra = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("03", dtpFechaEmisionComprobanteCompra.Value, _rucEmpresaCisepro,
_tipoAmbiente, _establecimientoLiqCompra, _ptoEmisionLiqCompra,
                                                                                                         _secuencialLiqCompra, _tipoEmision)

                                If _claveAccesoLiqCompra.ToString.Length = 49 Then ' si la clave de acceso para la retencion electronica es valida
                                    If _ptoEmisionLiqCompra = "002" Then ActualizarSecuencialLiquidacion() ' actualiza el secuencial de comprobante de retencion electronico
                                Else

                                    KryptonMessageBox.Show("ERROR AL GENERAR LIQUIDACION COMPRA: CLAVE DE ACCESO INVALIDA!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                    Return
                                End If
                            End If
                        End If
                    ElseIf cmbNombreParametroDocumentos.Tag = "NO DEDUCIBLE" Then

                        ' AAUXILIARES ID
                        _objetoSolicitudFondoRotativo.IdSolicitud = _objetoSolicitudFondoRotativo.BuscarMayorIdSolicitudFondoRotativo(_tipoCon) + 1
                        _objetoDocumentoNoDeducible.IdDocumentoNo = _objetoDocumentoNoDeducible.BuscarMayorIdDocumentoNoDeducible(_tipoCon) + 1
                        GuardarRegistroSolicitudFondoRotativoNuevo()
                        GuardarDocumentoNoDeducible()

                        ActualizarMontoFondo()
                    End If

                    If cmbConcepto.SelectedValue = 2 And chkCombustible.Checked And txtMotivoControlC.Text.Trim().Length > 0 And txtValorControl.Text.Trim().Length > 0 Then
                        If CDbl(txtValorControl.Text) > 0 Then
                            GuardarCombustible()
                        Else

                            KryptonMessageBox.Show("El valor de combustible no puede ser 0!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                            Return
                        End If
                    End If


                    Dim nombreU As String = "SOLICITUD-FONDO-ROTATIVO " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        If _validarComprobanteRetencion = 1 And _ptoEmisionRetencion = "002" Then ExportarXml()
                        If _validarComprobanteLiqCompra = 1 And _ptoEmisionLiqCompra = "002" Then ExportarXmlLiquidacionCompra()

                        chkCombustible.Checked = False

                        txtNroSolicitudFR.Tag = _objetoSolicitudFondoRotativo.IdSolicitud
                        txtNroSolicitudFR.Text = _objetoSolicitudFondoRotativo.NroDocumentoSolicitud
                        btnNuevoSolicitudFR.Enabled = True
                        btnDocumento.Enabled = False
                        btnGuardarSolicitudFR.Enabled = False
                        btnCancelarSolicitudFR.Enabled = False
                        DeshabilitadoInicio()
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return

                    End If


                Else

                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO LOS DATOS DEL DOCUMENTO.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            Else

                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                txtValorSolicitudFR.Focus()
            End If
        End Sub
        Private Function ValidarNumeroComprobanteRepetidoProveedor()
            If cmbNombreParametroDocumentos.Tag.ToString() = "DEDUCIBLE" Then
                Dim n = _objetoComprobantesCompra.BuscarNumeroComprobanteXIdProveedorNumeroComprobante(_tipoCon, _idProveedorGeneral, _numeroComprobanteCompra.Trim.ToString)
                If n <> "0" Then

                    KryptonMessageBox.Show("EL NÚMERO DE COMPROBANTE " & n & " YA ESTA REGISTRADO PARA ESTE PROVEEDOR", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End Function
        Private Function ValidarNumeroComprobanteRetencionRepetido()
            If cmbNombreParametroDocumentos.Tag.ToString() = "DEDUCIBLE" Then
                If _numComprobanteRetencion <> "001001000000001" Then
                    If _objetoComprobantesRetencion.ExisteNumeroComprobanteRetencion(_tipoCon, _numComprobanteRetencion) Then

                        KryptonMessageBox.Show("EL NÚMERO DE COMPROBANTE DE RETENCIÓN " & _numComprobanteRetencion & " YA ESTA REGISTRADO!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Return False
                    End If
                    Return True
                End If
                Return True
            End If
            Return True
        End Function
        Private Function ValidarNumeroComprobanteLiquidacionRepetido()
            If cmbNombreParametroDocumentos.Tag = "DEDUCIBLE" Then
                If _objetoComprobantesRetencion.ExisteNumeroComprobanteLiquidacionCompra(_tipoCon, _numeroComprobanteCompra, _idProveedorGeneral) Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE LIQUIDACIÓN DE COMPRA " & _numeroComprobanteCompra & " YA ESTA REGISTRADO!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("EL NÚMERO DE COMPROBANTE DE LIQUIDACIÓN DE COMPRA " & _numeroComprobanteCompra & " YA ESTA REGISTRADO!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return False
                End If
                Return True
            End If
            Return True
        End Function
        Private Function ValidacionParametros() As Boolean
            Return (txtActividadDetalleFR.Text <> "" And cmbConcepto.SelectedValue > 0 And cmbProvincia.SelectedValue > 0 And cmbCanton.SelectedValue > 0 And cmbParroquia.SelectedValue > 0 And cmbCentroCosto.SelectedValue > 0 _
               And cmbCargoResponsableAutoFR.SelectedValue > 0 And txtCIResponsableAutoFR.Text <> "" And txtApellidoResponsableAutoFR.Text <> "" And txtNombreResponsableAutoFR.Text <> "" _
               And CDec(txtValorSolicitudFR.Text) > 0 And txtDetalleSolicitudFR.Text <> "" And txtCIReceptorDinero.Text <> "" And txtReceptorDineroSolicitud.Text <> "" _
               And cmbNombreParametroDocumentos.SelectedValue > 0 And txtCodDebe.Text <> "" And txtCodHaber.Text <> "")
        End Function

        Private Function ValidacionParametrosCombustible() As Boolean
            Return (txtIdActivoFijo.Text <> "" And txtPlacaVehiculo.Text <> "" And txtDestinoControlC.Text <> "" And txtMotivoControlC.Text <> "" And txtValorControl.Text <> "")
        End Function
        Private Sub Auditoria(ByVal accion As String)
            _objAuditoria.IdAuditoria += 1
            _objAuditoria.AccionAuditoria = accion
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub GuardarRegistroSolicitudFondoRotativoNuevo()

            With _objetoSolicitudFondoRotativo
                '.IdSolicitud = _objetoSolicitudFondoRotativo.BuscarMayorIdSolicitudFondoRotativo(_tipoCon) + 1
                .NumeroSolicitud = _objetoSolicitudFondoRotativo.BuscarMayorNroSolicitudFondoRotativo(_tipoCon) + 1
                .FechaSolicitud = dtpFechaEmisionComprobanteCompra.Value
                .ValorSolicitud = txtValorSolicitudFR.Text
                .DetalleSolicitud = txtDetalleSolicitudFR.Text.ToUpper & (If(_objetoComprobantesCompra.IdComprobante = 0, "", "     ID CC: " & _objetoComprobantesCompra.IdComprobante))
                .CodDebeSolicitud = txtCodDebe.Text
                .CodHaberSolicitud = txtCodHaber.Text
                .EstadoSolicitud = 1
                .IdFondo = 1
                .IdResponsable = cmbCargoResponsableAutoFR.SelectedValue
                .IdCentro = cmbCentroCosto.SelectedValue
                .IdGasto = cmbConcepto.SelectedValue
                .IdPersonal = CInt(txtReceptorDineroSolicitud.Tag)
                .IdProvincias = 7
                .IdCiudad = 58
                .IdParroquias = 287
                .IdParametroDocumentos = cmbNombreParametroDocumentos.SelectedValue
                .IdLiquidacion = 0
                .TipoDocumento = cmbNombreParametroDocumentos.Tag
                If cmbNombreParametroDocumentos.Tag = "DEDUCIBLE" Then
                    .IdDocumento = _objetoComprobantesCompra.IdComprobante
                    .NumeroDocumento = _numeroComprobanteCompra 'guarda el numero de comprobante de compra para mostrar en la liquidación
                ElseIf cmbNombreParametroDocumentos.Tag = "NO DEDUCIBLE" Then
                    .IdDocumento = _objetoDocumentoNoDeducible.IdDocumentoNo
                    .NumeroDocumento = _numeroDocumentoNoDeducible 'guarda el numero de documento no deducible para mostrar en la liquidación
                End If
                .NombreCliente = txtNombreComercialCliente.Text
            End With
            _sqlCommands.Add(_objetoSolicitudFondoRotativo.NuevoRegistroSolicitudForndoRotativoCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", N° " & _objetoSolicitudFondoRotativo.NumeroSolicitud &
            ", FECHA: " & _objetoSolicitudFondoRotativo.FechaSolicitud & ", VALOR: " & _objetoSolicitudFondoRotativo.ValorSolicitud)


            ' en el caso de anticipos a empleados (descontados a fin de mes en el rol)
            If cmbNombreParametroDocumentos.Tag = "NO DEDUCIBLE" And cmbConcepto.SelectedValue = 33 Then

                With _objetoAnticipoPrestamo
                    .IdAnticipoPrestamo = .BuscarMayorIdAnticiposPrestamos(_tipoCon) + 1
                    .FechaAnticipoPrestamo = _objetoSolicitudFondoRotativo.FechaSolicitud
                    .TipoAnticipoPrestamo = "ANTICIPO"
                    .FormaAnticipoPrestamo = "EFECTIVO"
                    .Valor = txtValorSolicitudFR.Text
                    .IdPersonal = CInt(txtReceptorDineroSolicitud.Tag)
                    .Estado = 1
                    .Detalle = "ANTICIPOS (EMERGENTE) A: " & txtReceptorDineroSolicitud.Text & ", CON MOTIVO: " & txtDetalleSolicitudFR.Text.ToUpper.Trim & " - VALOR: " & txtValorSolicitudFR.Text & " | ID FR: " & _objetoSolicitudFondoRotativo.IdSolicitud
                    .Diferido = 0
                    .Interes = 0
                    .ValorCuotas = 0
                    .SaldoCuotas = 1
                    .SaldoValor = .Valor
                    .IdAuxFondoCheque = _objetoSolicitudFondoRotativo.IdSolicitud
                End With
                _sqlCommands.Add(_objetoAnticipoPrestamo.GuardarAnticiposPrestamoCommand())
                Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", " & _objetoAnticipoPrestamo.Detalle)

                With _objRegistroDescuento
                    .IdRegistro = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(_tipoCon) + 1
                    .IdPersonal = CInt(txtReceptorDineroSolicitud.Tag)
                    .Fecha = _objetoAnticipoPrestamo.FechaAnticipoPrestamo
                    .Procesado = 0
                    .Mes = _objetoAnticipoPrestamo.FechaAnticipoPrestamo.Month
                    .Anio = _objetoAnticipoPrestamo.FechaAnticipoPrestamo.Year
                    .IdRol = 0
                    .Tipo = 3 ' DESCUENTO ANTICIPO EMERGENTE
                    .Observacion = _objetoAnticipoPrestamo.Detalle
                    .Valor = _objetoAnticipoPrestamo.Valor
                    .Tipot = "DESCUENTO ANTICIPO EMERGENTE"
                    .Idprog = 0
                End With
                _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands())
                Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", N° " & _objetoSolicitudFondoRotativo.NumeroSolicitud &
                ", FECHA: " & _objetoSolicitudFondoRotativo.FechaSolicitud & ", VALOR: " & _objetoSolicitudFondoRotativo.ValorSolicitud & ", ANTICIPO EMERGENTE A: " &
                _objRegistroDescuento.IdPersonal & ", VALOR: " & _objRegistroDescuento.Valor)

                With _objetoHistorial
                    .IdHistorias = .BuscarMayorIdHistoriaLaboral(_tipoCon) + 1
                    .FechaHistoria = _objetoSolicitudFondoRotativo.FechaSolicitud
                    .DetalleHistoria = _objetoAnticipoPrestamo.Detalle
                    .EstadoHistoria = 1
                    .IdPersonalHistoria = CInt(txtReceptorDineroSolicitud.Tag)
                    .IdSitioPuestoHistoria = String.Empty
                    .IdAuxiliares = _objetoAnticipoPrestamo.IdAnticipoPrestamo
                End With
                _sqlCommands.Add(_objetoHistorial.NuevaHistorialLaboralCommand())
            End If
        End Sub

        Private Sub ActualizarMontoFondo()
            Dim fr = _objetoFondoRotativo.SeleccionarFondoRotativo(_tipoCon)
            Dim montoAnteriorFondoRotativo = CDec(lblMontoFondoRotativo.Text)
            Dim nuevoMontoFondoRotativo = CDec(lblMontoFondoRotativo.Text) - CDec(txtValorSolicitudFR.Text)

            With _objetoAuxiliarFondoRotativo
                .IdFondo = CInt(fr.Rows(0)(0))
                .MontoFondo = nuevoMontoFondoRotativo
                .MontoAnteriorFondo = montoAnteriorFondoRotativo
            End With
            _sqlCommands.Add(_objetoAuxiliarFondoRotativo.ActualizarMontoAuxiliarFondoRotativoCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", ACTUALZIAR MONTO FONDO ROTATIVO ANT: " & montoAnteriorFondoRotativo & ", ACT: " & nuevoMontoFondoRotativo)
        End Sub

        Private Sub GuardarDocumentoNoDeducible()

            With _objetoDocumentoNoDeducible
                '.IdDocumentoNo = _objetoDocumentoNoDeducible.BuscarMayorIdDocumentoNoDeducible(_tipoCon) + 1
                .NumeroDocumentoNo = _numeroDocumentoNoDeducible
                .FechaDocumentoNo = _fechaDocumentoNoDeducible
                .DescripcionDocumentoNo = _descripcionDocumentoNoDeducible
                .ValorDocumentoNo = _valorDocumentoNoDeducible
                .EstadoDocumentoNo = 1
                .Idparametro = cmbNombreParametroDocumentos.SelectedValue
                .IdSolicitudFondo = _objetoSolicitudFondoRotativo.IdSolicitud '==> id de fondo rotativo
                .IdSolicitudCaja = 0 '===> id de caja chica
            End With
            _sqlCommands.Add(_objetoDocumentoNoDeducible.NuevoRegistroDocumentoNoDeducibleCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", DOCUMENTO NO DEDUCIBLE " &
               "ID: " & _objetoDocumentoNoDeducible.IdDocumentoNo & ", N°: " & _objetoDocumentoNoDeducible.NumeroDocumentoNo & ", FECHA: " & _objetoDocumentoNoDeducible.FechaDocumentoNo &
               "VALOR: " & _objetoDocumentoNoDeducible.ValorDocumentoNo)
        End Sub

        Private Sub GuardarCombustible()

            With _objSalida
                .IdSalidaVehiculo = .BuscarMayorIdSalidaVehiculos(_tipoCon) + 1
                .FechaSalidaVehiculo = dtpFechaSalidaVehiculo.Value.Date
                .HoraSalidaVehiculo = dtpHoraSalidaVehiculo.Value.TimeOfDay.ToString
                .KmSalidaVehiculo = txtKmSalidaVehiculo.Text
                .EstadoSalidaVehiculo = 1
            End With
            _sqlCommands.Add(_objSalida.NuevoRegistroSalidaVehiculosCommand())


            With _objLlegada
                .IdLlegadaVehiculo = .BuscarMayorIdLlegadaVehiculos(_tipoCon) + 1
                .FechaLlegadaVehiculo = dtpFechaLlegadaVehiculo.Value.Date
                .HoraLlegadaVehiculo = dtpHoraLlegadaVehiculo.Value.TimeOfDay.ToString
                .KmLlegadaVehiculo = txtKmLlegadaVehiculo.Text
                .EstadoLlegadaVehiculo = 1
            End With
            _sqlCommands.Add(_objLlegada.NuevoRegistroLlegadaVehiculosCommand())


            With _objetoControlcombustible
                .IdControl = .BuscarMayorIdControlCombustible(_tipoCon) + 1
                .FechaControl = txtFechaControl.Text
                .ValorControl = txtValorControl.Text
                .DestinoControl = txtDestinoControlC.Text.ToUpper
                .TotalKmControl = txtTotalKmControlC.Text
                .EstadoControl = 1
                .MotivoControl = txtMotivoControlC.Text.ToUpper
                .IdSolicitudFr = _objetoSolicitudFondoRotativo.IdSolicitud
                .IdSolicitudCch = 0
                .IdActivo = txtIdActivoFijo.Text
                .IdGastosFondoRotativo = CInt(cmbConcepto.SelectedValue)
                .IdGastosCajaChica = 0
                .IdResponsableFondoRotativo = _objetoResponsableAutorizacion.BuscarIdResponsablesFondoRotativoXCargo(_tipoCon, cmbCargoResponsableAutoFR.Text)
                .IdResponsableCajaChica = 0
                .IdPersonal = CInt(txtReceptorDineroSolicitud.Tag)
                .IdRubro = cbmCombustible.SelectedValue
                .IdSalida = _objSalida.IdSalidaVehiculo
                .IdLlegada = _objLlegada.IdLlegadaVehiculo
            End With
            _sqlCommands.Add(_objetoControlcombustible.NuevoRegistroControlCombustiblesCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", CONTROL COMBUSTIBLE " &
               "ID: " & _objetoControlcombustible.IdControl & ", FECHA: " & _objetoControlcombustible.FechaControl & ", VALOR: " & _objetoControlcombustible.ValorControl &
               "DESTINO: " & _objetoControlcombustible.DestinoControl)
        End Sub

        Private Sub GuardarComprobanteCompra()
            With _objetoComprobantesCompra
                '.IdComprobante = .BuscarMayorIdComprobanteCompra(_tipoCon) + 1
                .IdProveedorGeneral = _idProveedorGeneral
                .TipoComprobante = _tipoComprobanteCompra
                .NumeroComprobante = Trim(_numeroComprobanteCompra.Trim)
                .NumAutoSriComprobante = Trim(_numAutoSriComprobanteCompra.Trim)
                .FechaAutoSriComprobante = _fechaAutoSriComprobantecompra
                .FechaEmisionComprobante = _fechaEmisionComprobanteCompra
                .GuiaRemisionComprobante = _guiaRemisionComprobanteCompra
                .DocModComprobante = _docModComprobanteCompra
                .RazModComprobante = _razModComprobanteCompra
                .ObservacionComprobante = txtDetalleSolicitudFR.Text
                .Subtotal12Comprobante = _subtotal12ComprobanteCompra
                .Subtotal0Comprobante = _subtotal0ComprobanteCompra
                .DescuentoComprobante = _descuentoComprobanteCompra
                .SubtotalComprobante = _subtotalComprobanteCompra
                .PorcentajeIvaComprobante = _porcentajeIvaComprobanteCompra
                .IvaComprobante = _ivaComprobanteCompra
                .TotalComprobante = _totalComprobanteCompra
                .EstadoComprobante = 10 ' =-=-=-= PAGADO POR FONDO 
                .IdOrdenCompra = _idOrdenCompora
            End With
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoRegistroComprobanteCompraCommand())
            'Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", COMPROBANTE DE COMPRA " & _
            '    "ID: " & _objetoComprobantesCompra.IdComprobante & ", N°: " & _objetoComprobantesCompra.NumeroComprobante & ", FECHA: " & _objetoComprobantesCompra.FechaEmisionComprobante & _
            '    "VALOR: " & _objetoComprobantesCompra.TotalComprobante)

            If _objetoComprobantesCompra.IdOrdenCompra = 0 Then Return
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoDetalleOrdenComprobanteCompraCommand())
        End Sub

        Private Sub ActualizarSecuencial() 'ACTUALIZA EL SECUENCIAL DE LOS DOCUMENTOS ELECTRONICOS
            With _objetoInformacionTributaria
                .Id = _idEmpresaCisepro
                .SecuencialComprobanteRetencion = _secuencialRetencion
            End With
            _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", ACTUALIZAR SECUENCIAL RETENCION N°: " & _objetoInformacionTributaria.SecuencialComprobanteRetencion)
        End Sub
        Private Sub ActualizarSecuencialLiquidacion()
            With _objetoInformacionTributaria
                .Id = _idEmpresaCisepro
                .SecuencialLiquidacionCompra = CLng(_secuencialLiqCompra)
            End With
            _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand())
            'Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", ACTUALIZAR SECUENCIAL RETENCION N°: " & _objetoInformacionTributaria.SecuencialComprobanteRetencion)
        End Sub
        Private Sub GuardarComprobanteRetencion()

            With _objetoComprobantesRetencion
                .IdComprobanteRetencion = .BuscarMayorIdComprobanteRetencionCompra(_tipoCon) + 1
                .NumeroComprobanteRetencion = _numComprobanteRetencion
                .NumAutoSriComprobanteRetencion = "1113541356"
                .FechaAutoSriComprobanteRetencion = _fechaAutoSriComprobanteRetencion
                .FechaEmisionComprobanteRetencion = _fechaEmisionComprobanteRetencion
                .IdProveedor = _idProveedorGeneral
                .TipoCompVentaComprobanteRetencion = _tipoComprobanteCompra
                .NumCompVentaComprobanteRetencion = _numeroComprobanteCompra
                .TotalComprobanteRetencion = _totalComprobanteRetencion
                If _ptoEmisionRetencion = "002" Then
                    .EstadoComprobanteRetencion = 110 'Comprobante de retencion electronico emitido por fondo rotativo
                Else
                    .EstadoComprobanteRetencion = 10 'Comprobante de retencion fisico emitido por fondo rotativo
                End If
                .IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante
            End With
            _sqlCommands.Add(_objetoComprobantesRetencion.NuevoRegistroComprobanteRetencionCompraCommand())
            Auditoria("SOLICITUD DE FONDO ROTATIVO ID: " & _objetoSolicitudFondoRotativo.IdSolicitud & ", COMPROBANTE DE RETENCIÓN " &
                "ID: " & _objetoComprobantesRetencion.IdComprobanteRetencion & ", N°: " & _objetoComprobantesRetencion.NumeroComprobanteRetencion & ", FECHA: " & _objetoComprobantesRetencion.FechaEmisionComprobanteRetencion &
                "VALOR: " & _objetoComprobantesRetencion.TotalComprobanteRetencion)
        End Sub

        Private Sub GuardarDetalleComprobanteRetencion()
            Dim idc = _objetoDetalleComprobantesRetencion.BuscarMayorIdDetalleComprobanteRetencionCompra(_tipoCon) + 1
            Dim idr = _objetoDetalleRetencionPlanCuentas.BuscarMayorIdRegistroDetalleRetencionPlanCuenta(_tipoCon) + 1

            For indice = 0 To dgvDetallesRetencion.RowCount - 1
                With _objetoDetalleComprobantesRetencion
                    .IdDetalleComprobanteRetencion = idc
                    .EjFiscalDetalleComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(0).Value
                    .CodigoDetalleComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(1).Value
                    .BaseImponibleDetalleComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(2).Value
                    .ImpuestoDetalleComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(3).Value
                    .PorcentajeComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(4).Value
                    .ValorDetalleComprobanteRetencion = dgvDetallesRetencion.Rows(+indice).Cells(5).Value
                    If _ptoEmisionRetencion = "002" Then
                        .EstadoDetalleComprobanteRetencion = 110 'Comprobante de retencion electronico emitido por fondo rotativo
                    Else
                        .EstadoDetalleComprobanteRetencion = 10 'Comprobante de retencion fisico emitido por fondo rotativo
                    End If
                    .IdComprobanteRetencion = _objetoComprobantesRetencion.IdComprobanteRetencion
                    .IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante
                End With
                _sqlCommands.Add(_objetoDetalleComprobantesRetencion.NuevoRegistroDetalleComprobanteRetencionCompraCommand())


                ' DETALLE RETENCION PLAN CUENTA
                With _objetoDetalleRetencionPlanCuentas
                    .IdDetalleRetencionPlanCuenta = idr
                    .IdFacturaVenta = 0
                    .IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante
                    .IdDetalleComprobanteRetencionVenta = 0
                    .IdDetalleComprobanteRetencionCompra = idc
                    .Codigo = dgvDetallesRetencion.Rows(+indice).Cells(6).Value
                    .Cuenta = dgvDetallesRetencion.Rows(+indice).Cells(7).Value
                End With
                _sqlCommands.Add(_objetoDetalleRetencionPlanCuentas.NuevoRegistroDetalleRetencionPlanCuenta)


                idc += 1
                idr += 1
            Next
        End Sub

        Private Function ValidarFecha()
            Dim fechaActual = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day) ' establece la fecha minima de ingreso (año,mes,dia)

            Dim fechaCompra = New Date(dtpFechaEmisionComprobanteCompra.Value.Year, dtpFechaEmisionComprobanteCompra.Value.Month, dtpFechaEmisionComprobanteCompra.Value.Day) ' establece la fecha actual de ingreso (año,mes,dia)
            Dim fechaRetencion = New Date(dtpComprobanteRetencion.Value.Year, dtpComprobanteRetencion.Value.Month, dtpComprobanteRetencion.Value.Day) ' establece la fecha minima de ingreso (año,mes,dia)

            Dim fechaMaximaIngreso = fechaCompra
            If _tipoCon = TipoConexion.Seportpac Then
                fechaMaximaIngreso = fechaCompra.AddDays(180) ' 6 meses
            Else
                fechaMaximaIngreso = fechaCompra.AddDays(60) ' 2 meses
            End If

            If fechaRetencion < fechaCompra Then

                KryptonMessageBox.Show("La fecha de la retención no puede ser menor a la compra!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return False
            Else
                If fechaActual > fechaMaximaIngreso Then

                    KryptonMessageBox.Show("No puede ingresar facturas despues de 90 días de su emisión!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return False
                ElseIf fechaCompra > fechaActual Then

                    KryptonMessageBox.Show("No puede ingresar fecha futuras!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return False
                Else
                    Return True
                End If
            End If
        End Function

        Private Sub txtValorControl_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
            Dim txt = CType(sender, TextBox)
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar, txt.Text)
        End Sub

        Private Sub txtKmLlegadaVehiculo_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs)
            If txtKmLlegadaVehiculo.Text.Trim().Length = 0 Then txtKmLlegadaVehiculo.Text = 0
            If txtKmSalidaVehiculo.Text.Trim().Length = 0 Then txtKmSalidaVehiculo.Text = 0
            txtKmLlegadaVehiculo.ForeColor = If(CInt(txtKmLlegadaVehiculo.Text) < CInt(txtKmSalidaVehiculo.Text), Color.Red, Color.Black)
            txtTotalKmControlC.Text = CInt(txtKmLlegadaVehiculo.Text) - CInt(txtKmSalidaVehiculo.Text)
        End Sub



        Public RutaDocsElec As String
        Private Sub ExportarXml()
            Try
                Dim numeroRetencion = _establecimientoRetencion.ToString + "-" + _ptoEmisionRetencion.ToString + "-" + _secuencialRetencion.ToString

                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\RETENCION " & numeroRetencion & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\RETENCION " & numeroRetencion & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\RETENCION " & numeroRetencion & ".xml"
                End Select

                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<comprobanteRetencion id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresaCisepro & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresaCisepro & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresaCisepro & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAccesoRetencion & "</claveAcceso>" & vbNewLine ' Pendiente...
                xml += "<codDoc>07</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoRetencion & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionRetencion & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialRetencion & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresaCisepro & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA RETENCION =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpComprobanteRetencion.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresaCisepro & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecialCisepro & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionSujetoRetenido>" & _tipoIdentificacionProveedor & "</tipoIdentificacionSujetoRetenido>" & vbNewLine
                xml += "<razonSocialSujetoRetenido>" & _razonSocialProveedorGeneral & "</razonSocialSujetoRetenido>" & vbNewLine
                xml += "<identificacionSujetoRetenido>" & _rucProveedorGeneral & "</identificacionSujetoRetenido>" & vbNewLine

                Dim mesPeriodoFiscal = If(dtpComprobanteRetencion.Value.Month < 10, "0" & dtpComprobanteRetencion.Value.Month, dtpComprobanteRetencion.Value.Month.ToString)
                Dim periodoFiscal = mesPeriodoFiscal.ToString + "/" + dtpComprobanteRetencion.Value.Year.ToString
                xml += "<periodoFiscal>" & periodoFiscal & "</periodoFiscal>" & vbNewLine
                xml += "</infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                If dgvDetallesRetencion.Rows.Count > 0 Then
                    xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    For indiceDetalle = 0 To dgvDetallesRetencion.Rows.Count - 1
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        If dgvDetallesRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "RENTA" Then
                            xml += "<codigo>1</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            xml += "<codigoRetencion>" & dgvDetallesRetencion.Rows(indiceDetalle).Cells(1).Value.ToString & "</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION RENTA
                        ElseIf dgvDetallesRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "IVA" Then
                            xml += "<codigo>2</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            If dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value = 10 Then
                                xml += "<codigoRetencion>9</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value = 20 Then
                                xml += "<codigoRetencion>10</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value = 30 Then
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA BIENES
                            ElseIf dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value = 70 Then
                                xml += "<codigoRetencion>2</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA SERVICIOS
                            ElseIf dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value = 100 Then
                                xml += "<codigoRetencion>3</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA 100%
                            Else
                                xml += "<codigoRetencion>0</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA
                            End If
                        End If

                        xml += "<baseImponible>" & Math.Round(CDbl(dgvDetallesRetencion.Rows(indiceDetalle).Cells(2).Value), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                        xml += "<porcentajeRetener>" & dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value & "</porcentajeRetener>" & vbNewLine
                        xml += "<valorRetenido>" & Math.Round(CDbl(dgvDetallesRetencion.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</valorRetenido>" & vbNewLine
                        xml += "<codDocSustento>01</codDocSustento>" & vbNewLine
                        xml += "<numDocSustento>" & _numeroComprobanteCompra.Trim.ToString & "</numDocSustento>" & vbNewLine
                        xml += "<fechaEmisionDocSustento>" & Format(dtpFechaEmisionComprobanteCompra.Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                    Next
                    xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                End If

                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=                    
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & nres & "</campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</comprobanteRetencion>" & vbNewLine


                ' GUARDAR COMPROBANTE ELECTRONICO 
                _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
                _objetoComprobantesElectronicos.IdDocumento = _objetoComprobantesRetencion.IdComprobanteRetencion
                _objetoComprobantesElectronicos.Tipo = "RETENCION COMPRA"
                _objetoComprobantesElectronicos.Documento = xml
                _objetoComprobantesElectronicos.FechaEmision = _objetoComprobantesRetencion.FechaEmisionComprobanteRetencion
                _objetoComprobantesElectronicos.NumDocumento = _objetoComprobantesRetencion.NumeroComprobanteRetencion
                _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

            Catch ex As Exception
                'MsgBox("ERROR AL GENERAR RETENCIÓN ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("ERROR AL GENERAR RETENCIÓN ELECTRÓNICA" & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ExportarXmlLiquidacionCompra()
            Try
                Dim baseImponibles As Decimal
                Dim totalSinImpuesto As Decimal

                Dim numeroFactura = _establecimientoLiqCompra & "-" & _ptoEmisionLiqCompra & "-" & _secuencialLiqCompra

                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                End Select

                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<liquidacionCompra id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresaCisepro & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresaCisepro & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresaCisepro & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAccesoLiqCompra & "</claveAcceso>" & vbNewLine
                xml += "<codDoc>03</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoLiqCompra & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionLiqCompra & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialLiqCompra & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresaCisepro & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoLiquidacionCompra>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpComprobanteRetencion.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresaCisepro & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecialCisepro & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionProveedor>" & _tipoIdentificacionProveedor & "</tipoIdentificacionProveedor>" & vbNewLine
                xml += "<razonSocialProveedor>" & _razonSocialProveedorGeneral & "</razonSocialProveedor>" & vbNewLine
                xml += "<identificacionProveedor>" & _rucProveedorGeneral & "</identificacionProveedor>" & vbNewLine
                xml += "<direccionProveedor>" & _direccionProveedorGeneral & "</direccionProveedor>" & vbNewLine ' ficha tecnica diciembre 2019; implementado 16/12/2019

                totalSinImpuesto = Math.Round(_subtotal12ComprobanteCompra, 2, MidpointRounding.ToEven) - Math.Round(_descuentoComprobanteCompra, 2, MidpointRounding.ToEven)

                xml += "<totalSinImpuestos>" & totalSinImpuesto & "</totalSinImpuestos>" & vbNewLine
                xml += "<totalDescuento>" & _descuentoComprobanteCompra & "</totalDescuento>" & vbNewLine

                xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                If _porcentajeIvaComprobanteCompra = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                If _porcentajeIvaComprobanteCompra = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                If _porcentajeIvaComprobanteCompra = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                xml += "<descuentoAdicional>0.00</descuentoAdicional>" & vbNewLine
                baseImponibles = Math.Round(_subtotal12ComprobanteCompra, 2, MidpointRounding.ToEven) - Math.Round(_descuentoComprobanteCompra, 2, MidpointRounding.ToEven)
                xml += "<baseImponible>" & baseImponibles & "</baseImponible>" & vbNewLine
                xml += "<tarifa>" & _porcentajeIvaComprobanteCompra & "</tarifa>" & vbNewLine
                xml += "<valor>" & Math.Round(_ivaComprobanteCompra, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<importeTotal>" & _totalComprobanteCompra & "</importeTotal>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                '' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
                xml += "<pagos>" & vbNewLine
                xml += "<pago>" & vbNewLine
                xml += "<formaPago>01</formaPago>" & vbNewLine
                xml += "<total>" & _totalComprobanteCompra & "</total>" & vbNewLine
                xml += "<plazo>30</plazo>" & vbNewLine
                xml += "<unidadTiempo>dias</unidadTiempo>" & vbNewLine
                xml += "</pago>" & vbNewLine
                xml += "</pagos>" & vbNewLine
                xml += "</infoLiquidacionCompra>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                xml += "<detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                If dgvAsientosDiario.Rows.Count > 1 Then
                    For indiceDetalle = 0 To dgvAsientosDiario.Rows.Count - 2
                        xml += "<detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigoPrincipal>" & dgvAsientosDiario.Rows(indiceDetalle).Cells(1).Value & "</codigoPrincipal>" & vbNewLine
                        xml += "<descripcion>" & dgvAsientosDiario.Rows(indiceDetalle).Cells(2).Value & "</descripcion>" & vbNewLine
                        xml += "<cantidad>1</cantidad>" & vbNewLine
                        xml += "<precioUnitario>" & Math.Round(CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                        xml += "<descuento>0</descuento>" & vbNewLine
                        xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                        xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                        If dgvAsientosDiario.Rows(indiceDetalle).Cells(4).Value = "S" Then
                            If _porcentajeIvaComprobanteCompra = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                            If _porcentajeIvaComprobanteCompra = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                            If _porcentajeIvaComprobanteCompra = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                            xml += "<tarifa>" & _porcentajeIvaComprobanteCompra & "</tarifa>" & vbNewLine
                            xml += "<baseImponible>" & dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value & "</baseImponible>" & vbNewLine
                            Dim valorIvaDetalle = (CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value) * _porcentajeIvaComprobanteCompra) / 100
                            xml += "<valor>" & Math.Round(valorIvaDetalle, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                        Else
                            xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                            xml += "<tarifa>0</tarifa>" & vbNewLine
                            xml += "<baseImponible>" & dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value & "</baseImponible>" & vbNewLine
                            xml += "<valor>0</valor>" & vbNewLine
                        End If

                        xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                End If
                xml += "</detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & ". </campoAdicional>" & vbNewLine
                If _tipoCon = TipoConexion.Seportpac Then
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones Correo: seportpac@hotmail.com;</campoAdicional>" & vbNewLine
                Else
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
                End If
                xml += "<campoAdicional nombre='Observaciones'>" & txtDetalleSolicitudFR.Text.ToUpper.Trim() & "</campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</liquidacionCompra>" & vbNewLine


                ' GUARDAR COMPROBANTE ELECTRONICO 
                _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
                _objetoComprobantesElectronicos.IdDocumento = _objetoComprobantesCompra.IdComprobante
                _objetoComprobantesElectronicos.Tipo = "LIQUIDACION COMPRA"
                _objetoComprobantesElectronicos.Documento = xml
                _objetoComprobantesElectronicos.FechaEmision = _objetoComprobantesCompra.FechaEmisionComprobante
                _objetoComprobantesElectronicos.NumDocumento = _objetoComprobantesCompra.NumeroComprobante
                _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()


            Catch ex As Exception

                KryptonMessageBox.Show("ERROR A GENERAR LIQUIDACIÓN DE COMPRAS " & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnBuscarVehiculo_Click(sender As Object, e As EventArgs) Handles btnBuscarVehiculo.Click
            Dim formBuscarVehiculo As New FormBuscarVehiculo
            formBuscarVehiculo.TipoCox = TipoCox
            DialogResult = formBuscarVehiculo.ShowDialog
            If DialogResult = vbOK Then
                txtIdActivoFijo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("ID_ACTIVO_FIJO").Value.ToString
                txtPlacaVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("PLACAS").Value.ToString
                txtMarcaVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("MARCA").Value.ToString
                txtModeloVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("MODELO").Value.ToString
            End If
        End Sub
    End Class
End Namespace