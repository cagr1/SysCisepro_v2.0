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
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
Imports syscisepro.FORMULARIOS.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports System.Xml
Imports System.Text

Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormSolicitudGastoCajaChica
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

        ReadOnly _crControlcombustible As New crControlCombustibleCajaChica
        ReadOnly _objetoDetalleRetencionPlanCuentas As New ClassDetalleRetencionPlanCuentas
        ReadOnly _objGastosCajaChica As New ClassGastosCajaChica
        ReadOnly _objProvincia As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objCentroCostos As New ClassCentroCosto
        ReadOnly _objAutoriza As New ClassResponsableAutorizacionesCch
        ReadOnly _objCajasChicas As New ClassCajaChica
        ReadOnly _objPersonalCustodioCajaChica As New ClassPersonal
        ReadOnly _objParametrosDocumentos As New ClassParametroDocumentos
        ReadOnly _objRubros As New ClassRubrosFondoRotativo
        ReadOnly _objetoAts As New ClassAnexoTransaccional
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimales As New ClassDecimal

        Dim _objetoInformacionTributaria As ClassInformacionTributaria
        Dim _objetoDocumentoNoDeducible As ClassDocumentoNoDeducible
        Dim _objetoComprobantesCompra As ClassComprobantesCompra
        Dim _objetoComprobantesRetencion As ClassComprobantesRetencion
        Dim _objetoDetalleComprobantesRetencion As ClassDetalleComprobantesRetencion
        Dim _objAuxiliarCajaChica As ClassAuxiliarCajaChica
        Dim _objSolicitudCajaChica As ClassSolicitudCajaChica
        Dim _objetoControlcombustible As New ClassControlCombustible
        Dim _objLlegada As ClassLlegadaVehiculosControlCombustible
        Dim _objSalida As ClassSalidaVehiculoControlCombustible
        Dim _objAuditoria As ClassAuditoriaGeneral
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos

        Dim _formDocumentoNoDeducible As FormDocumentosNoDeducibles
        Dim _formComprobanteCompra As FormRegistroComprobanteCompra

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
        Dim _claveAccesoRetencion As String

        Dim _ptoEmisionLiqCompra As String = ""
        Dim _establecimientoLiqCompra As String = ""
        Dim _secuencialLiqCompra As String = 0
        Dim _claveAccesoLiqCompra As String

        Dim _tipoIdentificacionProveedor As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
        Dim _numComprobanteRetencion As String = ""
        Dim _fechaAutoSriComprobanteRetencion As DateTime
        Dim _fechaEmisionComprobanteRetencion As DateTime
        Dim _totalComprobanteRetencion As Decimal

        Dim _numeroDocumentoNoDeducible As String
        Dim _fechaDocumentoNoDeducible As Date
        Dim _descripcionDocumentoNoDeducible As String
        Dim _valorDocumentoNoDeducible As Decimal

        Dim _validarComprobanteRetencion As Integer '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE
        Dim _validarComprobanteLiqCompra As Integer '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE
        Dim _validarLlenarDocumento As Integer  '=== 0 --> NO HAY COMPROBANTE / 1--> SI HAY COMPROBANTE

        Private Sub FormSolicitudGastoCajaChica_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label6.ForeColor = Color.White
                    'Label6.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'lblMontoCajaChica.ForeColor = Color.White
                    'lblMontoCajaChica.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'lblMontoPorTransaccion.ForeColor = Color.White
                    'lblMontoPorTransaccion.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label6.ForeColor = Color.White
                    'Label6.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'lblMontoCajaChica.ForeColor = Color.White
                    'lblMontoCajaChica.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'lblMontoPorTransaccion.ForeColor = Color.White
                    'lblMontoPorTransaccion.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    'Label30.ForeColor = Color.White
                    'Label30.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label3.ForeColor = Color.White
                    'Label3.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label6.ForeColor = Color.White
                    'Label6.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'lblMontoAsignado.ForeColor = Color.White
                    'lblMontoAsignado.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'lblMontoCajaChica.ForeColor = Color.White
                    'lblMontoCajaChica.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'lblMontoPorTransaccion.ForeColor = Color.White
                    'lblMontoPorTransaccion.BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
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

            _establecimientoLiqCompra = ""
            _ptoEmisionLiqCompra = ""
            _secuencialLiqCompra = 0
            _claveAccesoLiqCompra = ""

            _tipoIdentificacionProveedor = ""

            _idProveedorGeneral = 0
            _rucProveedorGeneral = ""
            _razonSocialProveedorGeneral = ""
            _direccionProveedorGeneral = ""

            _numComprobanteRetencion = ""
            _fechaAutoSriComprobanteRetencion = DateTime.MinValue
            _fechaEmisionComprobanteRetencion = DateTime.MinValue
            _totalComprobanteRetencion = 0.0

            dgvDetallesRetencion.Rows.Clear()
            dgvAsientosDiario.Rows.Clear()

            _numeroDocumentoNoDeducible = ""
            _fechaDocumentoNoDeducible = DateTime.MinValue
            _descripcionDocumentoNoDeducible = ""
            _valorDocumentoNoDeducible = 0.0

            _validarComprobanteRetencion = 0
            _validarComprobanteLiqCompra = 0
            _validarLlenarDocumento = 0
        End Sub

        Private Sub Habilitar(ByVal detalle As Boolean)
            cbmCajasChicas.Enabled = detalle
            txtFecha.Enabled = detalle
            cbmProvincia.Enabled = detalle
            cbmCanton.Enabled = detalle
            cbmParroquia.Enabled = detalle
            cbmConcepto.Enabled = detalle
            cbmCentroCosto.Enabled = detalle
            cbmAutoriza.Enabled = detalle
            btnBuscarPersonalRecibe.Enabled = detalle
            chkCombustible.Enabled = detalle
            cbmParametrosDocumentos.Enabled = detalle
            btnDocumento.Enabled = detalle
            txtDetalleGasto.Enabled = detalle

            GroupBox1.Enabled = detalle
            chkCombustible.Enabled = detalle
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnDocumento.Enabled = True

            _objAuditoria = New ClassAuditoriaGeneral()
            _objetoInformacionTributaria = New ClassInformacionTributaria
            _objSolicitudCajaChica = New ClassSolicitudCajaChica()
            _objAuxiliarCajaChica = New ClassAuxiliarCajaChica()
            _objetoDocumentoNoDeducible = New ClassDocumentoNoDeducible
            _objetoComprobantesCompra = New ClassComprobantesCompra
            _objetoComprobantesRetencion = New ClassComprobantesRetencion
            _objetoDetalleComprobantesRetencion = New ClassDetalleComprobantesRetencion
            _objetoControlcombustible = New ClassControlCombustible
            _objLlegada = New ClassLlegadaVehiculosControlCombustible
            _objSalida = New ClassSalidaVehiculoControlCombustible

            LimpiarVariables()
            LimpiarParametrosControlCombustible()
            LimpiarParametros()

            LlenarComboProvincias() ' EL ORO
            cbmCanton.SelectedValue = 58 ' MACHALA
            cbmParroquia.SelectedValue = 287 ' MACHALA

            LlenarComboCentroCostos()

            LlenarComboCajasChicas()

            cbmCajasChicas.SelectedValue = 1 ' MACHALA

            LlenarComboParametrosDocumentos()
            cbmParametrosDocumentos.SelectedValue = 6

            _validarComprobanteRetencion = 0
            _validarComprobanteLiqCompra = 0
            _validarLlenarDocumento = 0

            Habilitar(True)

            chkCombustible.Checked = True
            chkCombustible.Checked = False
            txtDetalleGasto.Focus()
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnDocumento.Enabled = False

            txtNumeroSolicitud.Clear()
            txtNumeroSolicitud.Tag = Nothing

            txtCedulaRecibe.Tag = Nothing
            txtCedulaRecibe.Clear()
            txtNombresRecibe.Clear()

            txtValorGasto.Clear()
            txtDetalleGasto.Clear()
            txtNroDocumento.Clear()

            chkCombustible.Checked = False
            LimpiarVariables()
            LimpiarParametrosControlCombustible()
            LimpiarParametros()

            Habilitar(False)
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
                cbmCanton.DataSource = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, CInt(cbmProvincia.SelectedValue))
                cbmCanton.DisplayMember = "NOMBRE_CIUDADES"
                cbmCanton.ValueMember = "ID_CIUDAD"
                cbmCanton.DropDownWidth = 300
                If (CType(cbmCanton.DataSource, DataTable).Rows.Count > 0) Then cbmCanton.SelectedIndex = 0
            Catch
                cbmCanton.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCanton.SelectedValueChanged
            If cbmCanton.SelectedValue Is Nothing Or TypeOf cbmCanton.SelectedValue Is DataRowView Then Return
            LlenarComboParroquias()
        End Sub

        Private Sub LlenarComboParroquias()
            Try
                cbmParroquia.DataSource = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, CInt(cbmCanton.SelectedValue))
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS"
                cbmParroquia.ValueMember = "ID_PARROQUIAS"
                cbmParroquia.DropDownWidth = 300
                If (CType(cbmParroquia.DataSource, DataTable).Rows.Count > 0) Then cbmParroquia.SelectedIndex = 0
            Catch
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmParroquia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmParroquia.SelectedValueChanged
            If cbmParroquia.SelectedValue Is Nothing Or TypeOf cbmParroquia.SelectedValue Is DataRowView Then Return
            LlenarComboAutorizaciones()
        End Sub

        Private Sub LlenarComboAutorizaciones()
            If (cbmProvincia.SelectedValue Is Nothing Or cbmCanton.SelectedValue Is Nothing Or cbmParroquia.SelectedValue Is Nothing) Then Return
            Try
                cbmAutoriza.DataSource = _objAutoriza.SeleccionarAutorizacionxProvinciasCiudadesParroquias(_tipoCon, cbmProvincia.SelectedValue, cbmCanton.SelectedValue, cbmParroquia.SelectedValue)
                cbmAutoriza.DisplayMember = "NOMBRES_AUTO_CCH"
                cbmAutoriza.ValueMember = "ID_RESPONSABLE_AUTO_CCH"
                cbmAutoriza.DropDownWidth = 300
                If (CType(cbmAutoriza.DataSource, DataTable).Rows.Count > 0) Then cbmAutoriza.SelectedIndex = 0
            Catch
                cbmAutoriza.DataSource = Nothing
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

        Private Sub LlenarComboCajasChicas()
            Try
                cbmCajasChicas.DataSource = _objCajasChicas.SeleccionarCajasChicas(_tipoCon)
                cbmCajasChicas.DisplayMember = "DETALLE_CAJA_CHICA"
                cbmCajasChicas.ValueMember = "ID_CAJA_CHICA"
                cbmCajasChicas.DropDownWidth = 300
                If (CType(cbmCajasChicas.DataSource, DataTable).Rows.Count > 0) Then cbmCajasChicas.SelectedIndex = 0
            Catch
                cbmCajasChicas.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmCajasChicas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCajasChicas.SelectedValueChanged
            If cbmCajasChicas.SelectedValue Is Nothing Or TypeOf cbmCajasChicas.SelectedValue Is DataRowView Then Return

            lblMontoAsignado.Text = _objCajasChicas.BuscarMontoAsignadoCajaChicaXidCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)
            lblMontoCajaChica.Text = _objAuxiliarCajaChica.BuscarMontoCajaChicaXidCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)
            lblMontoPorTransaccion.Text = _objCajasChicas.BuscarValorAsignadoCajaChicaXidCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)

            ValidarPorcentajes()

            Try
                txtCedulaEntrega.Tag = _objCajasChicas.BuscarIdCustodioCajaChicaXDetalleCajaChica(_tipoCon, cbmCajasChicas.Text)
                Dim p = _objPersonalCustodioCajaChica.BuscarPersonalPorIdPersonal(_tipoCon, CInt(txtCedulaEntrega.Tag))
                txtCedulaEntrega.Text = p.Tables("PERSONAL").Rows(0).Item(1)
                txtNombresEntrega.Text = p.Tables("PERSONAL").Rows(0).Item(3) + " " + p.Tables("PERSONAL").Rows(0).Item(2)
            Catch
                txtCedulaEntrega.Clear()
                txtNombresEntrega.Clear()
            End Try

            LlenarComboConceptosMachala()

            txtActividad.Text = _objCajasChicas.BuscarCuentaContableXIdCajaChica(_tipoCon, cbmCajasChicas.SelectedValue)
            txtCodigoHaber.Text = txtActividad.Text
        End Sub

        Private Sub LlenarComboConceptosMachala()
            Try
                cbmConcepto.DataSource = _objGastosCajaChica.SeleccionarConceptosCajaChicaMachala2(_tipoCon)
                cbmConcepto.DisplayMember = "NOMBRE_GASTO_CAJA_CH"
                cbmConcepto.ValueMember = "ID_GASTOS_CAJA_CH"
                cbmConcepto.DropDownWidth = 400
                If (CType(cbmConcepto.DataSource, DataTable).Rows.Count > 0) Then cbmConcepto.SelectedIndex = 0
            Catch
                cbmConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmConcepto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmConcepto.SelectedValueChanged
            If cbmConcepto.SelectedValue Is Nothing Or TypeOf cbmConcepto.SelectedValue Is DataRowView Then Return

            If CInt(cbmConcepto.SelectedValue) = 14 Then
                GroupBox1.Enabled = True
                chkCombustible.Checked = True
                MsgBox("No se olvide de realizar el control del combustible!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                chkCombustible.Checked = False
                GroupBox1.Enabled = False
            End If
        End Sub

        Private Sub ValidarPorcentajes()
            Dim monto = CDec(lblMontoAsignado.Text)
            Dim valorPorcentaje70 = monto - ((monto * 70) / 100)
            Dim valorPorcentaje90 = monto - ((monto * 90) / 100)
            lblMontoCajaChica.ForeColor = Label6.ForeColor
            If CType(lblMontoCajaChica.Text, Decimal) <= valorPorcentaje90 Then
                lblMontoCajaChica.ForeColor = Color.Red
                MessageBox.Show("Ha superado el 90% de su saldo. Realice Reposición inmediatamente!!!", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf CType(lblMontoCajaChica.Text, Decimal) <= valorPorcentaje70 Then
                lblMontoCajaChica.ForeColor = Color.Yellow
                MessageBox.Show("Ha superado el 70% de su saldo. Realice una Reposición!", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub LlenarComboParametrosDocumentos()
            Try
                cbmParametrosDocumentos.DataSource = _objParametrosDocumentos.SeleccionarParametrosDocumentos(_tipoCon)
                cbmParametrosDocumentos.DisplayMember = "NOMBRE_PARAMETRO_DOCUMENTOS"
                cbmParametrosDocumentos.ValueMember = "ID_PARAMETRO_DOCUMENTOS"
                cbmParametrosDocumentos.DropDownWidth = 300
                If (CType(cbmParametrosDocumentos.DataSource, DataTable).Rows.Count > 0) Then cbmParametrosDocumentos.SelectedIndex = 0
            Catch
                cbmParametrosDocumentos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmParametrosDocumentos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmParametrosDocumentos.SelectedValueChanged
            If cbmParametrosDocumentos.SelectedValue Is Nothing Or TypeOf cbmParametrosDocumentos.SelectedValue Is DataRowView Then Return
            cbmParametrosDocumentos.Tag = _objParametrosDocumentos.BuscarTipoParametroDocumentosXId(_tipoCon, CInt(cbmParametrosDocumentos.SelectedValue))
        End Sub

        Private Sub chkCombustible_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkCombustible.CheckedChanged
            LlenarComboCombustibles()
            LimpiarParametrosControlCombustible()

            If chkCombustible.Checked Then
                btnBuscarVehiculo.Enabled = True
                txtFechaControl.Enabled = True
                cbmCombustible.Enabled = True
                txtValorControl.Enabled = True
                txtDestinoControlC.Enabled = True
                txtMotivoControlC.Enabled = True
                gbLlegadaVehiculo.Enabled = True
                gpSalidaVehiculo.Enabled = True
            Else
                btnBuscarVehiculo.Enabled = False
                txtFechaControl.Enabled = False
                cbmCombustible.Enabled = False
                txtValorControl.Enabled = False
                txtDestinoControlC.Enabled = False
                txtMotivoControlC.Enabled = False
                gbLlegadaVehiculo.Enabled = False
                gpSalidaVehiculo.Enabled = False
            End If
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

        Private Sub LimpiarParametros()
            txtNumeroSolicitud.Tag = Nothing
            txtNumeroSolicitud.Clear()
            txtActividad.Clear()
            txtCedulaRecibe.Clear()
            txtNombresRecibe.Clear()
            txtCedulaEntrega.Tag = Nothing

            txtCedulaEntrega.Clear()
            txtNombresEntrega.Clear()
            txtCedulaRecibe.Tag = Nothing

            txtCodigoDebe.Clear()
            txtCodigoHaber.Clear()
            txtValorGasto.Clear()
            txtNumeroSolicitud.Clear()
            txtDetalleGasto.Clear()
            txtNroDocumento.Clear()
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
            lblIdCombustible.Text = ""
        End Sub

        Private Sub btnBuscarPersonalRecibe_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonalRecibe.Click
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
                        txtCedulaRecibe.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtCedulaRecibe.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value
                        txtNombresRecibe.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                txtCedulaRecibe.Tag = Nothing
                txtCedulaRecibe.Clear()
                txtNombresRecibe.Clear()
            End Try
        End Sub

        Private Sub btnBuscarVehiculo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarVehiculo.Click
            Dim formBuscarVehiculo As New FormBuscarVehiculo
            formBuscarVehiculo.TipoCox = TipoCox
            DialogResult = formBuscarVehiculo.ShowDialog
            Try
                If DialogResult = vbOK Then
                    txtIdActivoFijo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("ID_ACTIVO_FIJO").Value.ToString
                    txtPlacaVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("PLACAS").Value.ToString
                    txtMarcaVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("MARCA").Value.ToString
                    txtModeloVehiculo.Text = formBuscarVehiculo.dgvVehiculos.CurrentRow.Cells.Item("MODELO").Value.ToString
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub btnDocumento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDocumento.Click
            If cbmParametrosDocumentos.Tag.ToString() = "DEDUCIBLE" Then
                Try
                    _formComprobanteCompra = New FormRegistroComprobanteCompra
                    _formComprobanteCompra.chkActivoFijo.Visible = False
                    _formComprobanteCompra.TipoCox = TipoCox
                    _formComprobanteCompra.CuentasConceptoCompra = 1 ' CAJA
                    _formComprobanteCompra.IsDialog = True
                    _formComprobanteCompra.ValorMaximo = CDbl(lblMontoPorTransaccion.Text)
                    _formComprobanteCompra.btnGuardar.Visible = False
                    _formComprobanteCompra.btnGuardarEnFondoRotativo.Visible = True
                    _formComprobanteCompra.btnNuevo_Click(Nothing, Nothing)

                    _formComprobanteCompra.cmbNombreParametroDocumentos.SelectedValue = cbmParametrosDocumentos.SelectedValue
                    _formComprobanteCompra.cmbConceptoCompra.SelectedValue = cbmConcepto.SelectedValue

                    If _formComprobanteCompra.ShowDialog <> DialogResult.OK Then Return

                    If (CDbl(_formComprobanteCompra.txtTotalComprobanteCompra.Text) - CDbl(_formComprobanteCompra.txtTotalComprobanteRetencion.Text)) > CDbl(lblMontoPorTransaccion.Text) Then Throw New Exception("No se permite procesar un valor mayor monto disponible para caja ($" & lblMontoPorTransaccion.Text & ")!")

                    cbmParametrosDocumentos.SelectedValue = _formComprobanteCompra.cmbNombreParametroDocumentos.SelectedValue
                    cbmConcepto.SelectedValue = _formComprobanteCompra.cmbConceptoCompra.SelectedValue
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
                                dgvDetallesRetencion.Rows.Add(row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString, row.Cells(6).Value.ToString, row.Cells(7).Value.ToString)
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

                        _validarComprobanteLiqCompra = 1
                    Else
                        _validarComprobanteLiqCompra = 0
                    End If

                    txtCodigoDebe.Text = _formComprobanteCompra.dgvAsientosDiario.Rows(0).Cells(1).Value
                    txtValorGasto.Text = CDec(_totalComprobanteCompra) - CDec(_totalComprobanteRetencion)
                    txtNroDocumento.Text = _formComprobanteCompra.txtNumeroComprobanteCompra.Text
                    txtDetalleGasto.Text = _formComprobanteCompra.txtObservacionesComprobantesCompra.Text.ToUpper

                    If chkCombustible.Checked Then txtValorControl.Text = txtValorGasto.Text
                    _validarLlenarDocumento = 1
                Catch ex As Exception
                    _validarLlenarDocumento = 0
                    MsgBox(ex.ToString & vbNewLine & "Por favor, vuelva a ingresar los datos de la factura!", MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                End Try
            ElseIf cbmParametrosDocumentos.Tag.ToString() = "NO DEDUCIBLE" Then
                Try
                    _formDocumentoNoDeducible = New FormDocumentosNoDeducibles
                    _formDocumentoNoDeducible.TipoCox = TipoCox
                    _formDocumentoNoDeducible.ValorMaximo = CDbl(lblMontoPorTransaccion.Text)

                    If _formDocumentoNoDeducible.ShowDialog <> DialogResult.OK Then Return

                    If CDbl(_formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text) > CDbl(lblMontoPorTransaccion.Text) Then Throw New Exception("No se permite procesar un valor mayor monto disponible para caja ($" & lblMontoPorTransaccion.Text & ")!")

                    _numeroDocumentoNoDeducible = _formDocumentoNoDeducible.txtNumeroDocumentoNoDeducible.Text
                    _fechaDocumentoNoDeducible = _formDocumentoNoDeducible.dtpDocumentoNoDeducible.Value
                    _descripcionDocumentoNoDeducible = _formDocumentoNoDeducible.txtDescripcionDocumentoNoDeducible.Text.ToUpper
                    _valorDocumentoNoDeducible = _formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text

                    txtCodigoDebe.Text = _formDocumentoNoDeducible.lblCodigoCuentaConcepto.Text
                    txtValorGasto.Text = _formDocumentoNoDeducible.txtValorDocumentoNoDeducible.Text
                    txtDetalleGasto.Text = _formDocumentoNoDeducible.txtDescripcionDocumentoNoDeducible.Text.ToUpper
                    txtNroDocumento.Text = _formDocumentoNoDeducible.txtNumeroDocumentoNoDeducible.Text

                    If chkCombustible.Checked Then txtValorControl.Text = txtValorGasto.Text
                    _validarLlenarDocumento = 1
                Catch ex As Exception
                    _validarLlenarDocumento = 0
                    MsgBox(ex.ToString & vbNewLine & "Por favor, vuelva a ingresar los datos del documento!", MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                End Try
            End If
        End Sub

        Private Sub txtKmLlegadaVehiculo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtKmSalidaVehiculo.KeyPress, txtKmLlegadaVehiculo.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub

        Private Sub txtKmLlegadaVehiculo_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtKmSalidaVehiculo.KeyUp, txtKmLlegadaVehiculo.KeyUp
            If txtKmLlegadaVehiculo.Text.Trim().Length = 0 Then txtKmLlegadaVehiculo.Text = 0
            If txtKmSalidaVehiculo.Text.Trim().Length = 0 Then txtKmSalidaVehiculo.Text = 0
            txtKmLlegadaVehiculo.ForeColor = If(CInt(txtKmLlegadaVehiculo.Text) < CInt(txtKmSalidaVehiculo.Text), Color.Red, Color.Black)
            txtTotalKmControlC.Text = CInt(txtKmLlegadaVehiculo.Text) - CInt(txtKmSalidaVehiculo.Text)
        End Sub

        Private Sub txtNroDocumento_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNroDocumento.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            ConectarReporte()
        End Sub

        Private Sub ConectarReporte()
            Try
                _crControlcombustible.SetDataSource(_objetoControlcombustible.SeleccionarRegistrosControlCombustibleReporteCajaChica(_tipoCon,
                CType(txtNumControl.Text, Int64)))
                _crControlcombustible.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvReporteCombustible.ReportSource = _crControlcombustible
                crvReporteCombustible.Zoom(75)
                crvReporteCombustible.Refresh()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
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
                MsgBox("Hey!! ¯\_(ツ)_/¯ la fecha de la retención no puede ser menor a la compra!")
                Return False
            Else
                If fechaActual > fechaMaximaIngreso Then
                    MsgBox("Hey!! ¯\_(ツ)_/¯ NO PUEDE ingresar facturas despues de 90 días de su emisión!")
                    Return False
                ElseIf fechaCompra > fechaActual Then
                    MsgBox("Hey!! ¯\_(ツ)_/¯ no es la maquina del tiempo no puede ingresar fechas futuras!")
                    Return False
                Else
                    Return True
                End If
            End If
        End Function

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtDetalleGasto.Text.Trim().Equals("...") Or txtDetalleGasto.Text.Length < 6 Then
                MsgBox("DEBE AGREGAR LA OBSERVACIÓN O DETALLE DEL DOCUMENTO!")
                Return
            End If

            If Not ValidarFecha() Then Return
            If Not ValidarNumeroComprobanteRepetidoProveedor() Then Return
            If Not ValidarNumeroComprobanteRetencionRepetido() Then Return
            If Not ValidarNumeroComprobanteLiquidacionRepetido() Then Return

            If chkCombustible.Checked And Not ValidacionParametrosCombustible() Then
                MsgBox("NO OLVIDE INGRESAR LOS DATOS DEL CONTROL DE COMBUSTIBLE!")
                Return
            End If

            If ValidarParametros() Then 'VALIDACIÓN

                If _validarLlenarDocumento = 1 Then

                    If CDbl(txtValorGasto.Text) > CDbl(lblMontoPorTransaccion.Text) Then
                        MsgBox("No se puede procesar un valor mayor al valor disponible en caja ($" & lblMontoPorTransaccion.Text & ")! Por favor, realice una reposición", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                        Return
                    End If

                    If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR EL COMPROBANTE?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return


                    _sqlCommands.Clear()

                    _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                    _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                    _objAuditoria.FormularioAuditoria = Text.Trim
                    _objAuditoria.EstadoAuditoria = 1
                    _objAuditoria.IdUsuarioAuditoria = IdUsuario

                    If cbmParametrosDocumentos.Tag.ToString() = "DEDUCIBLE" Then

                        If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpFechaEmisionComprobanteCompra.Value) Then
                            MsgBox("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA INGRESAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                        Else

                            ' AUX IDS
                            _objSolicitudCajaChica.IdSolitud = _objSolicitudCajaChica.BuscarMayorIdSolicitudCajaChica(_tipoCon) + 1
                            _objetoComprobantesCompra.IdComprobante = _objetoComprobantesCompra.BuscarMayorIdComprobanteCompra(_tipoCon) + 1

                            GuardarComprobanteCompra()
                            GuardarRegistroSolicitud()

                            If _validarComprobanteRetencion = 1 Then
                                If _ptoEmisionRetencion = "002" Then
                                    Dim ep = _objetoInformacionTributaria.SeleccionarRegistrosInformacionTributaria(_tipoCon)
                                    _secuencialRetencion = CLng(ep.Rows(0)(9).ToString()) + 1
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
                                    MsgBox("ERROR AL GENERAR RETENCIÓN: CLAVE DE ACCESO INVALIDA!")
                                    Return
                                End If
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
                                MsgBox("ERROR AL GENERAR LIQUIDACION COMPRA: CLAVE DE ACCESO INVALIDA!")
                                Return
                            End If
                        End If


                    ElseIf cbmParametrosDocumentos.Tag.ToString() = "NO DEDUCIBLE" Then
                        ' AUX IDS
                        _objSolicitudCajaChica.IdSolitud = _objSolicitudCajaChica.BuscarMayorIdSolicitudCajaChica(_tipoCon) + 1
                        _objetoDocumentoNoDeducible.IdDocumentoNo = _objetoDocumentoNoDeducible.BuscarMayorIdDocumentoNoDeducible(_tipoCon) + 1

                        GuardarRegistroSolicitud()
                        GuardarDocumentoNoDeducible()

                    End If

                    ActulizarMontosCajasChicas()
                    If cbmConcepto.SelectedValue = 14 And chkCombustible.Checked And txtMotivoControlC.Text.Trim().Length > 0 And txtValorControl.Text.Trim().Length > 0 Then
                        If CDbl(txtValorControl.Text) > 0 Then
                            GuardarCombustible()
                        Else
                            MsgBox("El valor de COMBUSTIBLES no puede ser 0!")
                            Return
                        End If
                    End If

                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then

                        If _validarComprobanteRetencion = 1 And _ptoEmisionRetencion = "002" Then ExportarXml()
                        If _validarComprobanteLiqCompra = 1 And _ptoEmisionLiqCompra = "002" Then ExportarXmlLiquidacionCompra()

                        chkCombustible.Enabled = False
                        GroupBox1.Enabled = False

                        txtNumeroSolicitud.Text = _objSolicitudCajaChica.Numero
                        txtNumeroSolicitud.Tag = _objSolicitudCajaChica.IdSolitud

                        lblIdCombustible.Text = "ID: " & _objetoControlcombustible.IdControl
                        txtNumControl.Text = _objetoControlcombustible.IdControl

                        btnNuevo.Enabled = True
                        btnDocumento.Enabled = False
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False

                        Habilitar(False)

                    End If
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                Else
                    MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO LOS DATOS DEL COMPROBANTE / FACTURA.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Function ValidarNumeroComprobanteRepetidoProveedor()
            If cbmParametrosDocumentos.Tag = "DEDUCIBLE" Then
                Dim n = _objetoComprobantesCompra.BuscarNumeroComprobanteXIdProveedorNumeroComprobante(_tipoCon, _idProveedorGeneral, _numeroComprobanteCompra)
                If n <> "0" Then
                    MsgBox("EL NÚMERO DE COMPROBANTE " & n & " YA ESTA REGISTRADO PARA ESTE PROVEEDOR", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        End Function

        Private Function ValidarNumeroComprobanteRetencionRepetido()
            If cbmParametrosDocumentos.Tag = "DEDUCIBLE" Then
                If _numComprobanteRetencion <> "001001000000001" Then
                    If _objetoComprobantesRetencion.ExisteNumeroComprobanteRetencion(_tipoCon, _numComprobanteRetencion) Then
                        MsgBox("EL NÚMERO DE COMPROBANTE DE RETENCIÓN " & _numComprobanteRetencion & " YA ESTA REGISTRADO!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                        Return False
                    End If
                    Return True
                End If
                Return True
            End If
            Return True
        End Function

        Private Function ValidarNumeroComprobanteLiquidacionRepetido()
            If cbmParametrosDocumentos.Tag = "DEDUCIBLE" Then
                If _objetoComprobantesRetencion.ExisteNumeroComprobanteLiquidacionCompra(_tipoCon, _numeroComprobanteCompra, _idProveedorGeneral) Then
                    MsgBox("EL NÚMERO DE COMPROBANTE DE LIQUIDACIÓN DE COMPRA " & _numeroComprobanteCompra & " YA ESTA REGISTRADO!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return False
                End If
                Return True
            End If
            Return True
        End Function

        Private Function ValidarParametros() As Boolean
            If txtCedulaRecibe.Tag Is Nothing Then Return False
            Return (CInt(cbmCajasChicas.SelectedValue) > 0 And _
               CInt(cbmConcepto.SelectedValue) > 0 And _
               CInt(cbmProvincia.SelectedValue) > 0 And _
               CInt(cbmCanton.SelectedValue) > 0 And _
               CInt(cbmParroquia.SelectedValue) > 0 And _
               CInt(cbmCentroCosto.SelectedValue) > 0 And _
               CInt(cbmAutoriza.SelectedValue) > 0 And _
               txtCedulaRecibe.Text <> "" And txtNombresRecibe.Text <> "" And _
               txtCedulaEntrega.Text <> "" And txtNombresEntrega.Text <> "" And _
               CInt(cbmParametrosDocumentos.SelectedValue) > 0 And txtNroDocumento.Text <> "" And _
              CDec(txtValorGasto.Text) > 0 And txtDetalleGasto.Text <> "" And _
               txtCodigoDebe.Text <> "" And txtCodigoHaber.Text <> "" And _
               CInt(txtCedulaRecibe.Tag) > 0)
        End Function

        Private Function ValidacionParametrosCombustible() As Boolean
            Return (txtIdActivoFijo.Text <> "" And txtPlacaVehiculo.Text <> "" And txtDestinoControlC.Text <> "" And txtMotivoControlC.Text <> "" And txtValorControl.Text <> "")
        End Function
        Private Sub Auditoria(ByVal accion As String)
            _objAuditoria.IdAuditoria += 1
            _objAuditoria.AccionAuditoria = accion
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub GuardarRegistroSolicitud()

            With _objSolicitudCajaChica
                '.IdSolitud = _objSolicitudCajaChica.BuscarMayorIdSolicitudCajaChica(_tipoCon) + 1
                .Numero = _objSolicitudCajaChica.BuscarMayorNumeroSolicitudCajaChica(_tipoCon) + 1
                .Fecha = txtFecha.Value
                .Valor = txtValorGasto.Text
                .Detalle = txtDetalleGasto.Text.ToUpper & (If(_objetoComprobantesCompra.IdComprobante = 0, "", "     ID CC: " & _objetoComprobantesCompra.IdComprobante))
                .CodDebe = txtCodigoDebe.Text
                .CodHaber = txtCodigoHaber.Text
                .Estado = 1
                .IdCajaChica = CInt(cbmCajasChicas.SelectedValue)
                .IdResponsable = CInt(cbmAutoriza.SelectedValue)
                .IdCentroCosto = CInt(cbmCentroCosto.SelectedValue)
                .IdGasto = CInt(cbmConcepto.SelectedValue)
                .IdPersonal = CInt(txtCedulaRecibe.Tag)
                .IdProvincia = CInt(cbmProvincia.SelectedValue)
                .IdCiudad = CInt(cbmCanton.SelectedValue)
                .IdParroquias = CInt(cbmParroquia.SelectedValue)
                .NombresRecibe = txtNombresRecibe.Text.ToUpper.Trim
                .CedulaRecibe = txtCedulaRecibe.Text.Trim
                .IdParametroDocumento = CInt(cbmParametrosDocumentos.SelectedValue)
                .NombresEntrega = txtNombresEntrega.Text.ToUpper.Trim
                .CedulaEntrega = txtCedulaEntrega.Text.Trim
                .NroParametroDocumento = txtNroDocumento.Text
                .IdLiquidacion = 0
                '.IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante + 1
                .IdComprobanteCompra = If(cbmParametrosDocumentos.Tag.ToString() = "DEDUCIBLE", _objetoComprobantesCompra.IdComprobante, _objetoDocumentoNoDeducible.IdDocumentoNo)
            End With
            _sqlCommands.Add(_objSolicitudCajaChica.NuevaSolicitudCajaChicaCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", N° " & _objSolicitudCajaChica.Numero & _
            ", FECHA: " & _objSolicitudCajaChica.Fecha & ", VALOR: " & _objSolicitudCajaChica.Valor)
        End Sub

        Private Sub GuardarComprobanteCompra()
            With _objetoComprobantesCompra
                '.IdComprobante = .BuscarMayorIdComprobanteCompra(_tipoCon) + 1
                .IdProveedorGeneral = _idProveedorGeneral
                .TipoComprobante = _tipoComprobanteCompra
                .NumeroComprobante = _numeroComprobanteCompra
                .NumAutoSriComprobante = _numAutoSriComprobanteCompra
                .FechaAutoSriComprobante = _fechaAutoSriComprobantecompra
                .FechaEmisionComprobante = _fechaEmisionComprobanteCompra
                .GuiaRemisionComprobante = _guiaRemisionComprobanteCompra
                .DocModComprobante = _docModComprobanteCompra
                .RazModComprobante = _razModComprobanteCompra
                .ObservacionComprobante = txtDetalleGasto.Text & " " & _observacionComprobanteCompra
                .Subtotal12Comprobante = _subtotal12ComprobanteCompra
                .Subtotal0Comprobante = _subtotal0ComprobanteCompra
                .DescuentoComprobante = _descuentoComprobanteCompra
                .SubtotalComprobante = _subtotalComprobanteCompra
                .PorcentajeIvaComprobante = _porcentajeIvaComprobanteCompra
                .IvaComprobante = _ivaComprobanteCompra
                .TotalComprobante = _totalComprobanteCompra
                .EstadoComprobante = 11
                .IdOrdenCompra = _idOrdenCompora
            End With
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoRegistroComprobanteCompraCommand())
            'Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", COMPROBANTE DE COMPRA " & _
            '    "ID: " & _objetoComprobantesCompra.IdComprobante & ", N°: " & _objetoComprobantesCompra.NumeroComprobante & ", FECHA: " & _objetoComprobantesCompra.FechaEmisionComprobante & _
            '    "VALOR: " & _objetoComprobantesCompra.TotalComprobante)

            If _objetoComprobantesCompra.IdOrdenCompra = 0 Then Return
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoDetalleOrdenComprobanteCompraCommand())
        End Sub

        Private Sub GuardarDocumentoNoDeducible()
            With _objetoDocumentoNoDeducible
                '.IdDocumentoNo = .BuscarMayorIdDocumentoNoDeducible(_tipoCon) + 1
                .NumeroDocumentoNo = _numeroDocumentoNoDeducible
                .FechaDocumentoNo = _fechaDocumentoNoDeducible
                .DescripcionDocumentoNo = _descripcionDocumentoNoDeducible
                .ValorDocumentoNo = _valorDocumentoNoDeducible
                .EstadoDocumentoNo = 1
                .Idparametro = cbmParametrosDocumentos.SelectedValue
                .IdSolicitudFondo = 0
                .IdSolicitudCaja = _objSolicitudCajaChica.IdSolitud
            End With
            _sqlCommands.Add(_objetoDocumentoNoDeducible.NuevoRegistroDocumentoNoDeducibleCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", DOCUMENTO NO DEDUCIBLE " & _
                "ID: " & _objetoDocumentoNoDeducible.IdDocumentoNo & ", N°: " & _objetoDocumentoNoDeducible.NumeroDocumentoNo & ", FECHA: " & _objetoDocumentoNoDeducible.FechaDocumentoNo & _
                "VALOR: " & _objetoDocumentoNoDeducible.ValorDocumentoNo)
        End Sub

        Private Sub ActulizarMontosCajasChicas()
            With _objAuxiliarCajaChica
                .IdCajaChica = _objSolicitudCajaChica.IdCajaChica
                .MontoCajaChica = CType(lblMontoCajaChica.Text, Decimal) - CType(txtValorGasto.Text, Decimal)
                .MontoAnterior = CType(lblMontoCajaChica.Text, Decimal)
            End With
            _sqlCommands.Add(_objAuxiliarCajaChica.ActualizarMontosCajaChicaCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", ACTUALIZACIÓN DE MONT CAJA CHICA " & _
                "ID CAJA: " & _objAuxiliarCajaChica.IdCajaChica & ", ANTERIOR: " & _objAuxiliarCajaChica.MontoAnterior & ", ACTUAL: " & _objAuxiliarCajaChica.MontoCajaChica)
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
                .IdSolicitudFr = 0
                .IdSolicitudCch = _objSolicitudCajaChica.IdSolitud
                .IdActivo = txtIdActivoFijo.Text
                .IdGastosFondoRotativo = 0
                '.IdGastosCajaChica = _objSolicitudCajaChica.IdGasto
                .IdGastosCajaChica = CInt(cbmConcepto.SelectedValue)
                .IdResponsableFondoRotativo = 0
                '.IdResponsableCajaChica = _objSolicitudCajaChica.IdPersonal
                .IdResponsableCajaChica = CInt(txtCedulaEntrega.Tag)
                .IdPersonal = CInt(txtCedulaRecibe.Tag)
                .IdRubro = cbmCombustible.SelectedValue
                .IdSalida = _objLlegada.IdLlegadaVehiculo
                .IdLlegada = _objSalida.IdSalidaVehiculo
            End With
            _sqlCommands.Add(_objetoControlcombustible.NuevoRegistroControlCombustiblesCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", CONTROL COMBUSTIBLE " & _
               "ID: " & _objetoControlcombustible.IdControl & ", FECHA: " & _objetoControlcombustible.FechaControl & ", VALOR: " & _objetoControlcombustible.ValorControl & _
               "DESTINO: " & _objetoControlcombustible.DestinoControl)
        End Sub

        Private Sub ActualizarSecuencial()
            With _objetoInformacionTributaria
                .Id = _idEmpresaCisepro
                .SecuencialComprobanteRetencion = CLng(_secuencialRetencion)
            End With
            _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", ACTUALIZAR SECUENCIAL RETENCION N°: " & _objetoInformacionTributaria.SecuencialComprobanteRetencion)
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
                    .EstadoComprobanteRetencion = 111 'Comprobante de retencion electronico emitido por fondo rotativo
                Else
                    .EstadoComprobanteRetencion = 11 'Comprobante de retencion fisico emitido por fondo rotativo
                End If
                .IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante
            End With
            _sqlCommands.Add(_objetoComprobantesRetencion.NuevoRegistroComprobanteRetencionCompraCommand())
            Auditoria("SOLICITUD DE CAJA CHICA ID: " & _objSolicitudCajaChica.IdSolitud & ", COMPROBANTE DE RETENCIÓN " & _
                "ID: " & _objetoComprobantesRetencion.IdComprobanteRetencion & ", N°: " & _objetoComprobantesRetencion.NumeroComprobanteRetencion & ", FECHA: " & _objetoComprobantesRetencion.FechaEmisionComprobanteRetencion & _
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
                        .EstadoDetalleComprobanteRetencion = 111 'Comprobante de retencion electronico emitido por fondo rotativo
                    Else
                        .EstadoDetalleComprobanteRetencion = 11 'Comprobante de retencion fisico emitido por fondo rotativo
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

        Private Sub txtValorControl_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorControl.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub

        Public RutaDocsElec As String
        Private Sub ExportarXml()
            Try
                Dim numeroRetencion = _establecimientoRetencion.ToString + "-" + _ptoEmisionRetencion.ToString + "-" + _secuencialRetencion.ToString
                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\RETENCIONES COMPRAS - CAJA\RETENCION " & numeroRetencion & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\COMPRAS\RETENCION " & numeroRetencion & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\RETENCIONES COMPRAS - CAJA\RETENCION " & numeroRetencion & ".xml"
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
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA
                            End If
                        End If
                        xml += "<baseImponible>" & dgvDetallesRetencion.Rows(indiceDetalle).Cells(2).Value & "</baseImponible>" & vbNewLine
                        xml += "<porcentajeRetener>" & dgvDetallesRetencion.Rows(indiceDetalle).Cells(4).Value & "</porcentajeRetener>" & vbNewLine
                        xml += "<valorRetenido>" & Math.Round(CDbl(dgvDetallesRetencion.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</valorRetenido>" & vbNewLine
                        xml += "<codDocSustento>01</codDocSustento>" & vbNewLine
                        xml += "<numDocSustento>" & _numeroComprobanteCompra.Trim.ToString & "</numDocSustento>" & vbNewLine
                        xml += "<fechaEmisionDocSustento>" & Format(dtpFechaEmisionComprobanteCompra.Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                    xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                End If


                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & "</campoAdicional>" & vbNewLine
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
                MsgBox("ERROR AL GENERAR RETENCIÓN ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
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
                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & ". </campoAdicional>" & vbNewLine
                If _tipoCon = TipoConexion.Seportpac Then
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones Correo: seportpac@hotmail.com;</campoAdicional>" & vbNewLine
                Else
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
                End If
                xml += "<campoAdicional nombre='Observaciones'>" & txtDetalleGasto.Text.ToUpper.Trim() & "</campoAdicional>" & vbNewLine
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
                MsgBox("ERROR A GENERAR LIQUIDACIÓN DE COMPRAS " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
            End Try
        End Sub

        Private Sub txtNumControl_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNumControl.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub

        Private Sub cbmCajasChicas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmCajasChicas.SelectedIndexChanged

        End Sub
    End Class
End Namespace