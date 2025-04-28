Imports System.Data.SqlClient
Imports System.Xml
Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports System.Text
Imports syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.PORCENTAJES_RETENCION
Imports Krypton.Toolkit
'Imports DocumentFormat.OpenXml.Wordprocessing



Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRegistroComprobanteCompra

        Private _tipoCon As TipoConexion
        Public UserName As String
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
        Dim _sqlCommandsActivoFijo As List(Of SqlCommand)
        Dim _frmActivoFijo As FormIngresoActivosFijos
        Dim _formDialogoNuevoActivo As FormDialogoNuevoActivo

        Public IdUsuario As Integer

        Dim _estado As Integer

        Public IsDialog As Boolean
        Public ValorMaximo As Double

        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoCiudad As New ClassCiudades
        ReadOnly _objetoParametroDocumentos As New ClassParametroDocumentos
        ReadOnly _objetoDetalleRetencionPlanCuentas As New ClassDetalleRetencionPlanCuentas
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria
        ReadOnly _objetoComprobantesRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoConceptos As New ClassConceptosPago
        ReadOnly _objetoContribuyente As New ClassContribuyenteRetenido
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoPorcentajes As New ClassPorcentajes
        ReadOnly _objetoAts As New ClassAnexoTransaccional
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos


        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= LIBRO  DIARIO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objGastosCajaChica As New ClassGastosCajaChica
        ReadOnly _objetoGastosFondoRotativo As New ClassGastosFondoRotativo
        Dim _objAuditoria As ClassAuditoriaGeneral

        '===== OBJETOS PARA VALIDACIONES ========================================================================================
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesAlfanumerica As New ClassAlfanumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        Public CuentasConceptoCompra As Integer

        Dim _dtEmpresa As DataTable
        Dim _dtProveedor As DataTable

        Public TipoIdentificacionProveedor As String  ' tipo de identificacion del cliente RUC => 04 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07 / IDENTIFICACION DELEXTERIOR = > 08
        Public PorcentajeIva As Integer = 0
        Public PorcentajeIva5 As Integer = 0
        Public PorcentajeIva8 As Integer = 0
        Private _ptoEmisionRetencion As String = ""
        Private _ptoEmisionLiqCompra As String = ""

        Private _secuencialRetencion As String = ""
        Private _secuencialLiqCompra As String = ""

        Private _establecimientoRetencion As String = ""
        Private _establecimientoLiqCompra As String = ""

        Private _numAutoLiqCompraEmpresaCisepro As String = ""

        Dim _claveAccesoRetencion As String = ""
        Dim _claveAccesoLiqCompra As String = ""

        Public IdEmpresaCisepro As Integer
        Public RucEmpresaCisepro As String = ""
        Public RazonSocialEmpresaCisepro As String = "" ' razon social de la empresa emisora de la factura electrónica
        Public NombreComercialEmpresaCisepro As String = ""
        Public DireccionEmpresaCisepro As String = ""
        Public NumAutoContEspecialCisepro As String = ""

        Dim _idld = 0

        Private _valDebe As Decimal = 0.0
        Private _valHaber As Decimal = 0.0
        'Manejo de multiples iva
        Private _subtotalesPorIva As New Dictionary(Of Integer, Decimal)
        Private _ivas As New Dictionary(Of Integer, Decimal)
        Private ReadOnly _ivaCuentas As New Dictionary(Of Integer, String) From {
            {5, "1010514"},
            {8, "1010515"},
            {12, "1010512"},
            {15, "1010513"}
        }



        Private Sub FormRegistroComprobanteCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a


                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientosDiario.DefaultCellStyle.SelectionForeColor = Color.White
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c


                    dgvAsientosDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientosDiario.DefaultCellStyle.SelectionForeColor = Color.White
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionForeColor = Color.White
            End Select
            dgvAsientosDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _sqlCommandsActivoFijo = New List(Of SqlCommand)

            chkActivoFijo.Checked = False
            chkActivoFijo.Enabled = False
            cmbBienServicio.SelectedIndex = 0
            rbProduccion.Checked = True
            rbTipoEmisionNormal.Checked = True
            'rbPtoEmision002.Checked = True
            cbxPtoEmision.SelectedIndex = 1
            VerificarConcepto()
            DeshabilitadoInicio()

            _estado = 0
        End Sub

        Private Sub VerificarConcepto()
            If CuentasConceptoCompra <> 0 Then Return
            gbConceptoCompra.Enabled = False
            gbConceptoCompra.Visible = False
            'gbTipoComprobanteCompra.Width = 473
            'cmbNombreParametroDocumentos.Width = 400
        End Sub

        Private Sub CargarDatosEmpresa()
            Try
                Dim epr = New ClassEmpresa
                _dtEmpresa = epr.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)

                If _dtEmpresa Is Nothing Then Return
                If _dtEmpresa.Rows.Count = 0 Then Return

                IdEmpresaCisepro = _dtEmpresa.Rows(0)(0).ToString()

                RucEmpresaCisepro = _dtEmpresa.Rows(0)(2).ToString()
                RazonSocialEmpresaCisepro = _dtEmpresa.Rows(0)(3).ToString()
                NombreComercialEmpresaCisepro = _dtEmpresa.Rows(0)(4).ToString()
                DireccionEmpresaCisepro = _dtEmpresa.Rows(0)(5).ToString()
                NumAutoContEspecialCisepro = _dtEmpresa.Rows(0)(6).ToString()
                _establecimientoRetencion = _dtEmpresa.Rows(0)(17).ToString()
                _establecimientoLiqCompra = _dtEmpresa.Rows(0)(26).ToString()

                _numAutoLiqCompraEmpresaCisepro = _dtEmpresa.Rows(0)(29).ToString()

                PorcentajeIva = CInt(_dtEmpresa.Rows(0)(21).ToString())

                SetIvaBox()
            Catch ex As Exception
                'MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos empresa." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub SetIvaBox()
            '0 %
            '10 %
            '12 %
            '14 %
            'cbxPorcentaje.SelectedValue = 2
            If PorcentajeIva = 0 Then cbxPorcentaje.SelectedIndex = 0
            If PorcentajeIva = 10 Then cbxPorcentaje.SelectedIndex = 1
            If PorcentajeIva = 12 Then cbxPorcentaje.SelectedIndex = 2
            If PorcentajeIva = 15 Then cbxPorcentaje.SelectedIndex = 3

            lblSubtotalIva.Text = "Subtotal " & PorcentajeIva & "%"
            lblIva.Text = "IVA  " & PorcentajeIva & "%"

        End Sub

        Private Sub InicializarDiccionarios()
            _subtotalesPorIva.Clear()
            _ivas.Clear()

            Dim porcentajesIva As Integer() = {0, 5, 8, 12, 15}
            For Each porcen In porcentajesIva
                _subtotalesPorIva(porcen) = 0.0
                _ivas(porcen) = 0.0
            Next
        End Sub

        Private Sub DeshabilitadoInicio()

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnGuardarEnFondoRotativo.Enabled = False
            btnCancelar.Enabled = False
            btnReporte.Enabled = False

            'gbPtoEmision.Enabled = False
            'rbPtoEmision001.Enabled = False
            'rbPtoEmision002.Enabled = False
            cbxPtoEmision.Enabled = False
            'gbTipoAnbiente.Enabled = False
            'rbProduccion.Enabled = False
            'rbPruebas.Enabled = False
            'gbTipoEmision.Enabled = False
            'rbTipoEmisionNormal.Enabled = False
            'rbTipoEmisionIndisponibilidadSistema.Enabled = False

            btnNuevo.Enabled = True
            btnReporte.Enabled = False
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            btnGuardarEnFondoRotativo.Enabled = False

            'gbTipoComprobanteCompra.Enabled = False
            cmbNombreParametroDocumentos.Enabled = False
            'gbRUCProveedor.Enabled = False
            txtRucProveedorGeneral.Enabled = False
            'gbNombreComercialProveedor.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = False
            'gbDatosProveedor.Enabled = False
            txtDireccionProveedorGeneral.Enabled = False
            txtCiudadProveedorGeneral.Enabled = False
            txtTelefonoProveedorGeneral.Enabled = False
            txtEmailProveedorGeneral.Enabled = False
            txtObligadoLlevarContabilidadProveedorGeneral.Enabled = False
            txtContribuyenteEspecialProveedorGeneral.Enabled = False
            txtNumAutoContEspFacturaCompra.Enabled = False

            gbConceptoCompra.Enabled = False

            'gbDatosComprobanteCompra.Enabled = False
            txtGuiaRemisionComprobanteCompra.Enabled = False
            txtDocModComprobanteCompra.Enabled = False
            txtRazModComprobanteCompra.Enabled = False

            'gbDatosEspecialesComprobanteCompra.Enabled = False
            txtNumeroComprobanteCompra.Enabled = False
            txtNumAutoSRIComprobanteCompra.Enabled = False
            dtpFechaAutoSRIComprobanteCompra.Enabled = False
            dtpFechaEmisionComprobanteCompra.Enabled = False
            chkActivarRetencion.Enabled = False
            chkReq.Enabled = False
            btnOrdenCompra.Enabled = False

            GroupBox2.Enabled = False
            'GroupBox1.Enabled = False

            dgvDetalleComprobanteRetencion.Enabled = True
            'GroupBox3.Enabled = False
            dgvAsientosDiario.Enabled = False
            'gbValoresComprobanteCompra.Enabled = False
            'txtSubtotal12FacturaCompra.Enabled = True
            'txtSubtotal5FacturaCompra.Enabled = True
            'txtSubtotal0FacturaCompra.Enabled = True
            'txtDescuentoFacturaCompra.Enabled = True
            'txtIvaComprobanteCompra.Enabled = True
            'txtIva5ComprobanteCompra.Enabled = True
            'txtTotalComprobanteCompra.Enabled = True

            'gbObservaciones.Enabled = False
            txtObservacionesComprobantesCompra.Enabled = False

            'gbRetencion.Enabled = False
            txtNumeroComprobanteRetencion.Enabled = False
            txtTotalComprobanteRetencion.Enabled = False
            dtpComprobanteRetencion.Enabled = False
            cmbImpuesto.Enabled = False
            cmbConcepto.Enabled = False
            cmbContribuyente.Enabled = False
            cmbBienServicio.Enabled = False
            btnAgregarImpuesto.Enabled = False
            btnEliminarImpuesto.Enabled = False
        End Sub

        Public Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            _objAuditoria = New ClassAuditoriaGeneral

            VerificarConcepto()

            LimpiarParametros()

            CargarDatosEmpresa()
            HabilitadoNuevo()

            LlenarComboParametroDocumentos()

            LlenarComboConceptoComprobanteCompras()

            AutocompletarNombreProveedor()

            dtpComprobanteRetencion.Value = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            txtNombreComercialProveedorGeneral.Focus()
            _estado = 1
        End Sub

        Private Sub LimpiarParametros()
            lblIdComprobanteCompra.Text = "..."
            cmbBienServicio.SelectedIndex = 0
            cbxPtoEmision.SelectedIndex = 1
            '================== PROVEEDOR ======================================
            chkReq.Checked = False
            txtNombreComercialProveedorGeneral.Text = ""
            txtRucProveedorGeneral.Text = ""
            txtDireccionProveedorGeneral.Text = ""
            txtTelefonoProveedorGeneral.Text = ""
            txtCiudadProveedorGeneral.Text = ""
            txtEmailProveedorGeneral.Text = ""
            txtObligadoLlevarContabilidadProveedorGeneral.Text = ""
            txtContribuyenteEspecialProveedorGeneral.Text = ""
            txtNumAutoContEspFacturaCompra.Text = ""

            '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= COMPROBANTE COMPRA =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            txtGuiaRemisionComprobanteCompra.Text = "000"
            txtDocModComprobanteCompra.Text = "000"
            txtRazModComprobanteCompra.Text = "0"
            txtNumeroComprobanteCompra.Text = ""
            txtNumAutoSRIComprobanteCompra.Text = ""
            txtSubtotal12FacturaCompra.Text = "0.00"
            txtSubtotal5FacturaCompra.Text = "0.00"
            txtSubtotal0FacturaCompra.Text = "0.00"
            txtSubTotalComprobanteCompra.Text = "0.00"
            txtDescuentoFacturaCompra.Text = "0.00"
            txtIvaComprobanteCompra.Text = "0.00"
            txtIva5ComprobanteCompra.Text = "0.00"
            txtTotalComprobanteCompra.Text = "0.00"
            txtObservacionesComprobantesCompra.Text = "..."
            chkActivoFijo.Checked = False
            chkActivoFijo.Enabled = False
            '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= COMPROBANTE RETENCION =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            chkActivarRetencion.Checked = False
            txtNumeroComprobanteRetencion.Text = ""
            txtTotalComprobanteRetencion.Text = "0.00"
            _dtEmpresa = Nothing
            _dtProveedor = Nothing
            dgvAsientosDiario.Rows.Clear()
            dgvDetalleComprobanteRetencion.Rows.Clear()

        End Sub

        Private Sub HabilitadoNuevo()
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnGuardarEnFondoRotativo.Enabled = True
            btnCancelar.Enabled = True
            btnReporte.Enabled = False

            'gbPtoEmision.Enabled = True
            ' rbPtoEmision001.Enabled = True
            'rbPtoEmision002.Enabled = True
            cbxPtoEmision.Enabled = True
            'gbTipoAnbiente.Enabled = False
            'rbProduccion.Enabled = True
            'rbPruebas.Enabled = True
            'gbTipoEmision.Enabled = False
            'rbTipoEmisionNormal.Enabled = True
            'rbTipoEmisionIndisponibilidadSistema.Enabled = True



            'gbTipoComprobanteCompra.Enabled = True
            cmbNombreParametroDocumentos.Enabled = True

            'gbTipoComprobanteCompra.Enabled = False
            cmbNombreParametroDocumentos.Enabled = True
            'gbRUCProveedor.Enabled = False
            txtRucProveedorGeneral.Enabled = True
            'gbNombreComercialProveedor.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = True
            'gbDatosProveedor.Enabled = False
            txtDireccionProveedorGeneral.Enabled = True
            txtCiudadProveedorGeneral.Enabled = True
            txtTelefonoProveedorGeneral.Enabled = True
            txtEmailProveedorGeneral.Enabled = True
            txtObligadoLlevarContabilidadProveedorGeneral.Enabled = True
            txtContribuyenteEspecialProveedorGeneral.Enabled = True
            txtNumAutoContEspFacturaCompra.Enabled = True

            gbConceptoCompra.Enabled = True

            'gbDatosComprobanteCompra.Enabled = False
            txtGuiaRemisionComprobanteCompra.Enabled = True
            txtDocModComprobanteCompra.Enabled = True
            txtRazModComprobanteCompra.Enabled = True

            'gbDatosEspecialesComprobanteCompra.Enabled = False
            txtNumeroComprobanteCompra.Enabled = True
            txtNumAutoSRIComprobanteCompra.Enabled = True
            dtpFechaAutoSRIComprobanteCompra.Enabled = True
            dtpFechaEmisionComprobanteCompra.Enabled = True
            chkActivarRetencion.Enabled = True
            chkReq.Enabled = True
            'btnOrdenCompra.Enabled = True

            'gbValoresComprobanteCompra.Enabled = True
            'txtSubtotal12FacturaCompra.Enabled = True
            'txtSubtotal5FacturaCompra.Enabled = True
            'txtSubtotal0FacturaCompra.Enabled = True
            'txtDescuentoFacturaCompra.Enabled = True
            'txtIvaComprobanteCompra.Enabled = True
            'txtIva5ComprobanteCompra.Enabled = True
            'txtTotalComprobanteCompra.Enabled = True

            GroupBox2.Enabled = True
            'GroupBox3.Enabled = True
            dgvAsientosDiario.Enabled = True
            'gbObservaciones.Enabled = True
            txtObservacionesComprobantesCompra.Enabled = True
        End Sub

        Private Sub LlenarComboConceptoComprobanteCompras()
            Try
                If CuentasConceptoCompra = 0 Then Return
                If CuentasConceptoCompra = 1 Then '1 CAJA CHICA
                    cmbConceptoCompra.DataSource = _objGastosCajaChica.SeleccionarConceptosCajaChicaMachala2(_tipoCon)
                    cmbConceptoCompra.DisplayMember = "NOMBRE_GASTO_CAJA_CH"
                    cmbConceptoCompra.ValueMember = "ID_GASTOS_CAJA_CH"
                Else  '2 FONDO ROTATIVO
                    cmbConceptoCompra.DataSource = _objetoGastosFondoRotativo.SeleccionarGastosFondoRotativo(_tipoCon)
                    cmbConceptoCompra.DisplayMember = "NOMBRE_GASTOS_FR"
                    cmbConceptoCompra.ValueMember = "ID_GASTOS_FR"
                End If
                If (CType(cmbConceptoCompra.DataSource, DataTable).Rows.Count > 0) Then cmbConceptoCompra.SelectedIndex = 0
            Catch
                cmbConceptoCompra.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboParametroDocumentos()
            Try
                cmbNombreParametroDocumentos.DataSource = _objetoParametroDocumentos.SeleccionarParametrosDocumentos(_tipoCon)
                cmbNombreParametroDocumentos.DisplayMember = "NOMBRE_PARAMETRO_DOCUMENTOS"
                cmbNombreParametroDocumentos.ValueMember = "ID_PARAMETRO_DOCUMENTOS"
                If (CType(cmbNombreParametroDocumentos.DataSource, DataTable).Rows.Count > 0) Then cmbNombreParametroDocumentos.SelectedIndex = 0
            Catch
                cmbNombreParametroDocumentos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbNombreParametroDocumentos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbNombreParametroDocumentos.SelectedValueChanged
            If cmbNombreParametroDocumentos.SelectedValue Is Nothing Or TypeOf cmbNombreParametroDocumentos.SelectedValue Is DataRowView Then Return
            lblTipoDocumento.Text = _objetoParametroDocumentos.BuscarTipoParametroDocumentosXId(_tipoCon, cmbNombreParametroDocumentos.SelectedValue)
            'If _ptoEmisionLiqCompra = "002" And cmbNombreParametroDocumentos.SelectedValue = 3 Then VerificarNumeroSecuencialLiquidacionCompra()
            If (_ptoEmisionLiqCompra = "002" OrElse _ptoEmisionLiqCompra = "003" OrElse _ptoEmisionLiqCompra = "004") And cmbNombreParametroDocumentos.SelectedValue = 3 Then VerificarNumeroSecuencialLiquidacionCompra()
            If cmbNombreParametroDocumentos.SelectedValue = 1 Then
                chkActivoFijo.Checked = False
                chkActivoFijo.Enabled = True
            Else
                chkActivoFijo.Checked = False
                chkActivoFijo.Enabled = False
            End If
        End Sub

        Private Sub AutocompletarNombreProveedor()
            txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
            txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
            txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub
        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyValue <> 13 Then Return
            CargarDatosProveedor()
        End Sub

        Private Sub CargarDatosProveedor()
            Try
                _dtProveedor = _objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtNombreComercialProveedorGeneral.Text)
                If _dtProveedor Is Nothing Then Return
                If _dtProveedor.Rows.Count = 0 Then Return

                lblIdProveedorGeneral.Text = _dtProveedor.Rows(0)(0).ToString
                txtRucProveedorGeneral.Text = _dtProveedor.Rows(0)(2).ToString

                If _dtProveedor.Rows(0)(14).ToString().Equals("CED") Then
                    gbRUCProveedor.Text = "CEDULA"
                    TipoIdentificacionProveedor = "05"
                ElseIf _dtProveedor.Rows(0)(14).ToString().Equals("RUC") Then
                    gbRUCProveedor.Text = "RUC"
                    TipoIdentificacionProveedor = "04"
                Else
                    gbRUCProveedor.Text = "PASAPORTE"
                    TipoIdentificacionProveedor = "06"
                End If

                If _dtProveedor.Rows(0)(2).ToString().Equals("9999999999999") Then TipoIdentificacionProveedor = "07"

                txtObligadoLlevarContabilidadProveedorGeneral.Text = _dtProveedor.Rows(0)(6).ToString()
                txtContribuyenteEspecialProveedorGeneral.Text = _dtProveedor.Rows(0)(7).ToString()
                txtDireccionProveedorGeneral.Text = _dtProveedor.Rows(0)(8).ToString()
                txtCiudadProveedorGeneral.Text = _objetoCiudad.BuscarNombreCiudadXIdCiudad(_tipoCon, _dtProveedor.Rows(0)(9).ToString())
                txtTelefonoProveedorGeneral.Text = _dtProveedor.Rows(0)(10).ToString()
                txtEmailProveedorGeneral.Text = _dtProveedor.Rows(0)(12).ToString()
                txtNumAutoContEspFacturaCompra.Text = If(_dtProveedor.Rows(0)(14) Is DBNull.Value, "0000", _dtProveedor.Rows(0)(14).ToString())
                'txtNumAutoContEspFacturaCompra.Text = _dtProveedor.Rows(0)(14).ToString()
            Catch
                gbRUCProveedor.Text = "CI / RUC / PASAPORTE"
                lblIdProveedorGeneral.Text = "..."
                txtRucProveedorGeneral.Clear()
                TipoIdentificacionProveedor = ""
                txtObligadoLlevarContabilidadProveedorGeneral.Clear()
                txtContribuyenteEspecialProveedorGeneral.Clear()
                txtDireccionProveedorGeneral.Clear()
                txtCiudadProveedorGeneral.Clear()
                txtTelefonoProveedorGeneral.Clear()
                txtEmailProveedorGeneral.Clear()
            End Try
        End Sub



        Private Sub LeerXml(ByVal s As IO.Stream)
            Try
                Dim reader As New XmlTextReader(s)
                Dim cadenaXml = ""
                Dim nombreNodo = ""

                txtNumeroComprobanteCompra.Text = ""
                reader.WhitespaceHandling = WhitespaceHandling.None

                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            If reader.Name <> "" Then nombreNodo = reader.Name
                        Case XmlNodeType.Text
                            If nombreNodo = "numeroAutorizacion" Then
                                txtNumAutoSRIComprobanteCompra.Text = reader.Value
                            ElseIf nombreNodo = "fechaAutorizacion" Then
                                dtpFechaAutoSRIComprobanteCompra.Value = reader.Value
                            ElseIf nombreNodo = "comprobante" Then
                                cadenaXml = reader.Value
                            End If
                        Case XmlNodeType.CDATA
                            cadenaXml = reader.Value
                    End Select
                End While

                Dim nuevoXml As New XmlDocument
                nuevoXml.LoadXml(Trim(cadenaXml))
                nuevoXml.Save((Application.StartupPath & "\Leer XML Temp\lectorTemp.xml"))

                Dim newReader As New XmlTextReader((Application.StartupPath & "\Leer XML Temp\lectorTemp.xml"))
                'Dim newReader As New XmlTextReader(s)
                newReader.WhitespaceHandling = WhitespaceHandling.None
                While newReader.Read()
                    Select Case newReader.NodeType
                        Case XmlNodeType.Element
                            nombreNodo = newReader.Name
                        Case XmlNodeType.Text
                            If nombreNodo = "estab" Then
                                txtNumeroComprobanteCompra.AppendText(newReader.Value)
                            ElseIf nombreNodo = "ptoEmi" Then
                                txtNumeroComprobanteCompra.AppendText(newReader.Value)
                            ElseIf nombreNodo = "secuencial" Then
                                txtNumeroComprobanteCompra.AppendText(newReader.Value)
                            ElseIf nombreNodo = "fechaEmision" Then
                                dtpFechaEmisionComprobanteCompra.Value = newReader.Value
                            ElseIf nombreNodo = "contribuyenteEspecial" Then
                                txtNumAutoContEspFacturaCompra.Text = newReader.Value
                            ElseIf nombreNodo = "totalSinImpuestos" Then
                                txtSubTotalComprobanteCompra.Text = newReader.Value
                            ElseIf nombreNodo = "baseImponible" Then
                            ElseIf nombreNodo = "valor" Then
                                Exit While
                            End If
                    End Select
                End While
                newReader.Close()
            Catch ex As Exception
                'MsgBox("Hubo un problema al cargar el archivo. Por favor, intente nuevamente!" & vbNewLine & ex.Message, MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("Hubo un problema al cargar el archivo. Por favor, intente nuevamente!" & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            _estado = 0
            If Not IsDialog Then
                LimpiarParametros()
                DeshabilitadoInicio()
            Else
                DialogResult = DialogResult.Cancel
            End If
        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If lblIdComprobanteCompra.Text <> 0 Then
                Dim f = New FormReporteComprobanteCompra
                f.TipoCox = TipoCox
                f.lblIdComprobanteCompra.Text = lblIdComprobanteCompra.Text
                f._porcentaje = PorcentajeIva
                f._tipoComprobante = cmbNombreParametroDocumentos.Text
                f._proveedorCompra = txtNombreComercialProveedorGeneral.Text
                f._numeroComprobante = Trim(txtNumeroComprobanteCompra.Text.Trim)
                f.ShowDialog()
            Else
                'MsgBox("NO SE HA ENCONTRADO EL ID DEL COMPROBANTE DE COMPRA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No se ha encontrado el id del comprobante de compra", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub cbxPorcentaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbxPorcentaje.SelectedIndexChanged
            PorcentajeIva = CInt(cbxPorcentaje.Text.Split(" ")(0).Trim)
            If PorcentajeIva = 0 Then
                txtSubtotal12FacturaCompra.Text = "0.00"
                txtIvaComprobanteCompra.Text = "0.00"
            End If
            lblSubtotalIva.Text = "SUB TOTAL " & PorcentajeIva & "%:"
            lblIva.Text = "IVA  (" & PorcentajeIva & "%):"
            CalcularTotalesFactura()
            If dgvDetalleComprobanteRetencion.RowCount = 0 Then Return
            'MsgBox("HA CAMBIADO EL PORCENTAJE DE IVA, NO OLVIDE REVISAR EL DETALLES DE LA RETENCIÓN!", MsgBoxStyle.Exclamation, "Mensaje de validación")
            KryptonMessageBox.Show("Ha cambiado el porcentaje de IVA, no olvide revisar el detalles de la retención!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
        End Sub

        Private Sub CalcularTotalesFactura()

            InicializarDiccionarios()
            Dim subTotal12 As Decimal = 0.0
            Dim subTotal5 As Decimal = 0.0
            Dim subtotal0 As Decimal = 0.0
            Dim iva As Decimal = 0.0
            'Dim iva5 As Decimal = 0.0

            For indiceSuma = 0 To dgvAsientosDiario.RowCount - 2
                If dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value Is Nothing Then Continue For
                If dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value = 0 Then Continue For

                Dim valor As Decimal = CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value) 'cambio2025
                Dim porcentaje As Integer = CInt(dgvAsientosDiario.Rows(indiceSuma).Cells(5).Value) 'cambio2025

                'If dgvAsientosDiario.Rows(indiceSuma).Cells(4).Value = "S" Then
                '    If dgvAsientosDiario.Rows(indiceSuma).Cells(5).Value = 5 Then
                '        subTotal5 += CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value)
                '        iva5 += Math.Round(CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value) * (CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(5).Value) / 100), 2, MidpointRounding.ToEven)
                '    ElseIf dgvAsientosDiario.Rows(indiceSuma).Cells(5).Value = 8 Then
                '        subTotal12 += CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value)
                '        iva += Math.Round(CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value) * (8 / 100), 2, MidpointRounding.ToEven)
                '    Else
                '        subTotal12 += CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value)
                '        iva += Math.Round(CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value) * (PorcentajeIva / 100), 2, MidpointRounding.ToEven)
                '    End If

                'Else
                '    subtotal0 += CDec(dgvAsientosDiario.Rows(indiceSuma).Cells(3).Value)
                'End If

                'cambio 2025

                If dgvAsientosDiario.Rows(indiceSuma).Cells(4).Value = "S" Then
                    _subtotalesPorIva(porcentaje) += valor
                    _ivas(porcentaje) += Math.Round(valor * (porcentaje / 100), 2, MidpointRounding.ToEven)
                Else
                    _subtotalesPorIva(0) += valor
                End If

            Next

            Dim subtotal As Decimal = _subtotalesPorIva.Values.Sum()

            ' Calcular IVA para cada porcentaje
            Dim iva5 As Decimal = _ivas(5)
            Dim iva8 As Decimal = _ivas(8)
            Dim iva12 As Decimal = _ivas(12)
            Dim iva15 As Decimal = _ivas(15)

            ' Calcular total
            Dim total As Decimal = subtotal + iva5 + iva8 + iva12 + iva15

            'txtSubtotal12FacturaCompra.Text = subTotal12
            txtSubtotal12FacturaCompra.Text = (_subtotalesPorIva(8) + _subtotalesPorIva(12) + _subtotalesPorIva(15)).ToString()
            'txtSubtotal5FacturaCompra.Text = subTotal5
            txtSubtotal5FacturaCompra.Text = _subtotalesPorIva(5).ToString()
            'txtSubtotal0FacturaCompra.Text = subtotal0
            txtSubtotal0FacturaCompra.Text = _subtotalesPorIva(0).ToString()
            txtSubTotalComprobanteCompra.Text = subtotal
            txtIvaComprobanteCompra.Text = iva8 + iva12 + iva15
            txtIva5ComprobanteCompra.Text = iva5

            txtTotalComprobanteCompra.Text = total

            CalcularTotalesRetencion()
        End Sub

        Private Sub CalcularTotalesRetencion()
            Dim acumulador As Decimal = 0.0
            For indice = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                acumulador += Math.Round(CType(dgvDetalleComprobanteRetencion.Rows(indice).Cells(5).Value, Decimal), 2, MidpointRounding.AwayFromZero)
            Next
            txtTotalComprobanteRetencion.Text = Math.Round(acumulador, 2, MidpointRounding.AwayFromZero)
        End Sub


        Private Sub LlenarComboImpuesto()
            Try
                Dim ip = New ClassImpuestos
                cmbImpuesto.DataSource = ip.SeleccionarRegistrosImpuestos(_tipoCon)
                cmbImpuesto.DisplayMember = "DESCRIPCION_IMPUESTO_RETENIDO"
                cmbImpuesto.ValueMember = "ID_IMPUESTO_RETENIDO"
                If (CType(cmbImpuesto.DataSource, DataTable).Rows.Count > 0) Then cmbImpuesto.SelectedIndex = 0
            Catch
                cmbImpuesto.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboConcepto()
            Try
                cmbConcepto.DataSource = _objetoConceptos.SeleccionarRegistrosConceptosOrdenado(_tipoCon)
                cmbConcepto.DisplayMember = "DESCRIPCION_CONCEPTO_PAGO"
                cmbConcepto.ValueMember = "ID_CONCEPTO_PAGO"
                If (CType(cmbConcepto.DataSource, DataTable).Rows.Count > 0) Then cmbConcepto.SelectedIndex = 0
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboContribuyente()
            Try
                cmbContribuyente.DataSource = _objetoContribuyente.SeleccionarRegistrosContribuyentes(_tipoCon)
                cmbContribuyente.DisplayMember = "TIPO_CONTRIBUYENTE_RETENIDO"
                cmbContribuyente.ValueMember = "ID_CONTRIBUYENTE_RETENIDO"
                If (CType(cmbContribuyente.DataSource, DataTable).Rows.Count > 0) Then cmbContribuyente.SelectedIndex = 0
            Catch
                cmbContribuyente.DataSource = Nothing
            End Try
        End Sub
        Private Sub txtGuiaRemisionComprobanteCompra_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtDocModComprobanteCompra_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtNumeroComprobanteCompra_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtNumAutoSRIComprobanteCompra_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        'Private Sub rbPtoEmision001_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPtoEmision001.CheckedChanged
        '    VerificarNumeroSecuencialRetencion()
        '    VerificarNumeroSecuencialLiquidacionCompra()
        'End Sub
        'Private Sub rbPtoEmision002_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPtoEmision002.CheckedChanged
        '    VerificarNumeroSecuencialRetencion()
        '    VerificarNumeroSecuencialLiquidacionCompra()
        'End Sub
        Private Sub VerificarNumeroSecuencialRetencion()


            _ptoEmisionRetencion = cbxPtoEmision.SelectedItem.ToString()

            If _ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004" Then

                Select Case _ptoEmisionRetencion
                    Case "002"
                        _secuencialRetencion = _objetoComprobantesRetencion.BuscarMayorNumeroComprobanteRetencionCompra(_tipoCon) + 1
                    Case "003"
                        _secuencialRetencion = _objetoComprobantesRetencion.BuscarMayorNumeroComprobanteRetencionCompra3(_tipoCon) + 1
                    Case "004"
                        _secuencialRetencion = _objetoComprobantesRetencion.BuscarMayorNumeroComprobanteRetencionCompra4(_tipoCon) + 1
                End Select
                Dim secuencial As Long = CLng(_secuencialRetencion)
                _secuencialRetencion = secuencial.ToString("D9")

                txtNumeroComprobanteRetencion.Text = _establecimientoRetencion.ToString & _ptoEmisionRetencion.ToString & _secuencialRetencion.ToString
            Else
                txtNumeroComprobanteRetencion.Text = "001001000000001"
                _secuencialRetencion = "0000000001"
            End If



        End Sub
        Private Sub VerificarNumeroSecuencialLiquidacionCompra()

            _ptoEmisionLiqCompra = cbxPtoEmision.SelectedItem.ToString()
            If cmbNombreParametroDocumentos.SelectedValue = 3 Then
                If _ptoEmisionLiqCompra = "002" OrElse _ptoEmisionLiqCompra = "003" OrElse _ptoEmisionLiqCompra = "004" Then

                    Select Case _ptoEmisionLiqCompra
                        Case "002"
                            _secuencialLiqCompra = CLng(_objetoComprobantesCompra.BuscarMayorNumeroLiquidacionCompraIt(_tipoCon)) + 1
                        Case "003"
                            _secuencialLiqCompra = CLng(_objetoComprobantesCompra.BuscarMayorNumeroLiquidacionCompraIt3(_tipoCon)) + 1
                        Case "004"
                            _secuencialLiqCompra = CLng(_objetoComprobantesCompra.BuscarMayorNumeroLiquidacionCompraIt4(_tipoCon)) + 1
                    End Select

                    Dim secuencial As Long = CLng(_secuencialLiqCompra)
                    _secuencialLiqCompra = secuencial.ToString("D9")

                    txtNumeroComprobanteCompra.Text = _establecimientoLiqCompra.ToString + _ptoEmisionLiqCompra.ToString + _secuencialLiqCompra.ToString
                    txtNumAutoSRIComprobanteCompra.Text = _numAutoLiqCompraEmpresaCisepro
                Else
                    _secuencialLiqCompra = "0000000001"
                    _numAutoLiqCompraEmpresaCisepro = ""
                    txtNumeroComprobanteCompra.Text = "001001000000001"
                    txtNumAutoSRIComprobanteCompra.Text = _numAutoLiqCompraEmpresaCisepro
                End If
            End If

        End Sub

        Private Sub txtNumAutoSRIComprobanteCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs)
            If _estado = 0 Then Return
            If txtNumAutoSRIComprobanteCompra.TextLength < 10 Then
                'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA DEL SRI NO PUEDE TENER MENOS DE 10 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de autorización de factura del SRI no puede tener menos de 10 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            ElseIf txtNumAutoSRIComprobanteCompra.TextLength > 10 And txtNumAutoSRIComprobanteCompra.TextLength < 37 Then
                'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA ELECTRÓNICA ES DE 37 DIGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de autorización de factura electrónica es de 37 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub txtNumeroComprobanteRetencion_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNumeroComprobanteRetencion.Validated
            If _estado = 0 Then Return
            If txtNumeroComprobanteRetencion.TextLength <> 15 Then
                'MsgBox("EL NÚMERO DE DE COMPROBANTE DE RETENCIÓN DEBE TENER 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de de comprobante de retención debe tener 15 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            Else
                _establecimientoRetencion = ""
                _ptoEmisionRetencion = ""
                _secuencialRetencion = ""
                For indiceCadena = 1 To txtNumeroComprobanteRetencion.Text.Length
                    If indiceCadena < 4 Then
                        _establecimientoRetencion += Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                    ElseIf indiceCadena > 3 And indiceCadena < 7 Then
                        _ptoEmisionRetencion += Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                    ElseIf indiceCadena > 6 Then
                        _secuencialRetencion += Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                    End If
                Next
            End If
        End Sub
        Private Sub txtNumeroComprobanteCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs)
            If _estado = 0 Then Return
            If lblIdProveedorGeneral.Text <> "..." Then
                If txtNumeroComprobanteCompra.Text.Trim.Length <> 15 Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE COMPRA DEBE TENER 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de comprobante de compra debe tener 15 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Else
                    If cmbNombreParametroDocumentos.SelectedValue <> 3 Then ValidarNumeroComprobanteRepetidoProveedor()
                End If
            Else
                txtNumeroComprobanteCompra.Text = ""
                'MsgBox("ANTES DE INGRESAR EL NUMERO DE COMPROBANTE SELECCIONE UN PROVEEDOR", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Antes de ingresar el número de comprobante seleccione un proveedor", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub txtDocModComprobanteCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs)
            If _estado = 0 Then Return
            If cmbNombreParametroDocumentos.SelectedValue = 7 Then
                If Trim(txtDocModComprobanteCompra.Text).Length <> 15 Then
                    'MsgBox("EL NÚMERO DE DE COMPROBANTE DE COMPRA DEBE TENER 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de de comprobante de compra debe tener 15 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            End If
        End Sub
        Private Sub txtRazModComprobanteCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs)
            If _estado = 0 Then Return
            If cmbNombreParametroDocumentos.SelectedValue = 7 Then
                If Trim(txtRazModComprobanteCompra.Text).Length < 10 Then
                    'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA DEL SRI NO PUEDE TENER MENOS DE 10 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de autorización de factura del SRI no puede tener menos de 10 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            End If
        End Sub

        Private Sub btnGuardarEnFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarEnFondoRotativo.Click
            dgvDetalleComprobanteRetencion.EndEdit()

            chkActivarRetencion_CheckedChanged(Nothing, Nothing)

            If txtObservacionesComprobantesCompra.Text.Trim().Equals("...") Or txtObservacionesComprobantesCompra.Text.Length < 6 Then
                'MsgBox("DEBE AGREGAR LA OBSERVACIÓN O DETALLE DEL DOCUMENTO!")
                KryptonMessageBox.Show("Debe agregar la observación o detalle del documento", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Try
                If Not ValidarFecha() Then Return
                If Not ValidarTipoDocumentoProveedor() Then Return
                If Not ValidarNumeroComprobanteRepetidoProveedor() Then Return
                If Not ValidarNumeroComprobanteRetencionRepetido() Then Return
                If Not ValidarNumeroComprobanteLiquidacionRepetido() Then Return

                If chkActivarRetencion.Checked And Not ValidacionParametrosRetencion() Then
                    'MsgBox("HA MARCADO RETENCIÓN PARA ESTA COMPRA, POR FAVOR VERIFIQUE!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Ha marcado retención para esta compra, por favor verifique", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If txtObservacionesComprobantesCompra.Text.Trim().Equals("...") Or txtObservacionesComprobantesCompra.Text.Length < 6 Then
                    'MsgBox("DEBE AGREGAR LA OBSERVACIÓN O DETALLE DEL DOCUMENTO!")
                    KryptonMessageBox.Show("Debe agregar la observación o detalle del documento", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If txtNumeroComprobanteCompra.Text.Trim.Contains("-") Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE COMPRA NO DEBE TENER GUÍONES. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de comprobante de compra no debe tener guíones. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If Trim(txtNumeroComprobanteCompra.Text.Trim).Length <> 15 Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE COMPRA DEBE TENER 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de comprobante de compra debe tener 15 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If txtNumAutoSRIComprobanteCompra.Text.Trim.Length < 10 Then
                    'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA DEL SRI NO PUEDE TENER MENOS DE 10 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de autorización de factura del SRI no puede tener menos de 10 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If txtNumAutoSRIComprobanteCompra.Text.Trim.Length > 10 And txtNumAutoSRIComprobanteCompra.TextLength < 37 Then
                    'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA ELECTRÓNICA ES DE 37 DIGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de autorización de factura electrónica es de 37 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If ValorMaximo < (CDbl(txtTotalComprobanteCompra.Text) - CDbl(txtTotalComprobanteRetencion.Text)) Then
                    'MsgBox("No se puede procesasr un valor mayor al valor disponible en CAJA / FONDO ROTATIVO ($" & ValorMaximo.ToString("N") & ")! Por favor, realice una reposición", MsgBoxStyle.Information, "Mensaje de información")
                    KryptonMessageBox.Show("No se puede procesar un valor mayor al valor disponible en CAJA / FONDO ROTATIVO ($" & ValorMaximo.ToString("N") & ")! Por favor, realice una reposición", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return
                End If

                Dim texto = "DEBE: " & _valDebe & "        -        HABER: " & _valHaber
                If Math.Abs(_valDebe - _valHaber) > 0.01 Then
                    'MsgBox("NO ES POSBLE PROCESAR LA COMPRA PORQUE LA TRANSACCIÓN GENERADA NO CUADRA!!!" & vbNewLine & texto)
                    KryptonMessageBox.Show("No es posible procesar la compra porque la transacción generada no cuadra!!!" & vbNewLine & texto, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
                _estado = 0
                DialogResult = DialogResult.OK
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show(ex.Message, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Function ValidarFecha()
            Dim fechaActual = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)

            Dim fechaCompra = New Date(dtpFechaEmisionComprobanteCompra.Value.Year, dtpFechaEmisionComprobanteCompra.Value.Month, dtpFechaEmisionComprobanteCompra.Value.Day)
            Dim fechaRetencion = New Date(dtpComprobanteRetencion.Value.Year, dtpComprobanteRetencion.Value.Month, dtpComprobanteRetencion.Value.Day)

            'cambio de fecha para registro de nota de credito 
            Dim fechaMaximaIngreso = fechaCompra
            If _tipoCon = TipoConexion.Seportpac Then
                fechaMaximaIngreso = fechaCompra.AddDays(360) ' 6 meses
            Else
                fechaMaximaIngreso = fechaCompra.AddDays(180) ' 2 meses
            End If

            If fechaRetencion < fechaCompra Then
                'MsgBox("Hey!! ¯\_(ツ)_/¯ la fecha de la retención no puede ser menor a la compra!")
                KryptonMessageBox.Show("La fecha de la retención no puede ser menor a la compra!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return False
            Else
                If fechaActual > fechaMaximaIngreso Then
                    'MsgBox("Hey!! ¯\_(ツ)_/¯ no puedes ingresar facturas después de 90 días de su emisión!")
                    KryptonMessageBox.Show("No puedes ingresar facturas después de 90 días de su emisión!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                ElseIf fechaCompra > fechaActual Then
                    'MsgBox("Hey!! ¯\_(ツ)_/¯ no es la maquina del tiempo, no puede ingresar fechas futuras!")
                    KryptonMessageBox.Show("No puede ingresar fechas futuras!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                Else
                    Return True
                End If
            End If
        End Function
        Private Sub dtpFechaEmisionComprobanteCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs)
            dtpComprobanteRetencion.MinDate = dtpFechaEmisionComprobanteCompra.Value ' establece como fecha minima de la retencion la fecha de la compra para que no se ingresen fechas menores
        End Sub
        Private Sub txtContribuyenteEspecialProveedorGeneral_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtContribuyenteEspecialProveedorGeneral.TextChanged
            If txtContribuyenteEspecialProveedorGeneral.Text.Trim().Length = 0 Then Return
            If txtContribuyenteEspecialProveedorGeneral.Text.Trim().Equals("NO") Then txtNumAutoContEspFacturaCompra.Text = "0000"
        End Sub
        Private Sub cmbImpuesto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbImpuesto.SelectedValueChanged
            If cmbImpuesto.SelectedValue Is Nothing Or TypeOf cmbImpuesto.SelectedValue Is DataRowView Then Return
            cmbConcepto.Enabled = cmbImpuesto.SelectedValue = 1
            cmbContribuyente.Enabled = cmbImpuesto.SelectedValue = 1
            cmbBienServicio.Enabled = cmbImpuesto.SelectedValue = 2
        End Sub
        Private Sub btnAgregarImpuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarImpuesto.Click
            If CDbl(txtTotalComprobanteCompra.Text) > 0.01 Then
                If CInt(cmbImpuesto.SelectedValue) <> 0 And CInt(cmbConcepto.SelectedValue) <> 0 And CInt(cmbContribuyente.SelectedValue) <> 0 And txtNumeroComprobanteRetencion.Text.Trim().Length <> 0 Then

                    If CInt(cmbImpuesto.SelectedValue) = 1 Then '-=-=-=-=-= SI ES RENTA =-=-=-=-=-
                        Dim porret = _objetoPorcentajes.BuscarCantidadPorcentajesRenta(_tipoCon, CInt(cmbConcepto.SelectedValue), CInt(cmbContribuyente.SelectedValue), True)
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If

                        'Dim response = InputBox("INGRESE LA BASE IMPONIBLE", "COMPROBANTE RETENCIÓN", CDbl(txtSubTotalComprobanteCompra.Text))
                        Dim response = KryptonInputBox.Show("Ingrese la base imponible", "Comprobante retención", txtSubTotalComprobanteCompra.Text)
                        If IsNumeric(response) Then
                            Dim valrenta = Math.Round((CDec(response) * porcent) / 100, 2, MidpointRounding.AwayFromZero)
                            dgvDetalleComprobanteRetencion.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valrenta, 3, MidpointRounding.AwayFromZero), cod, cue)
                        Else
                            'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "El separador decimal es el '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If

                    ElseIf CInt(cmbImpuesto.SelectedValue) = 2 Then '-=-=-=-=-= SI ES IVA =-=-=-=-=- 
                        Dim porret As DataTable
                        If txtContribuyenteEspecialProveedorGeneral.Text.Equals("SI") And CInt(cmbContribuyente.SelectedValue) <> 4 Then
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, 5, cmbBienServicio.SelectedIndex, True)
                        Else
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, CInt(cmbContribuyente.SelectedValue), cmbBienServicio.SelectedIndex, True)
                        End If
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If
                        Dim num As Decimal = CDbl(txtIvaComprobanteCompra.Text) + CDbl(txtIva5ComprobanteCompra.Text)
                        'Dim response = InputBox("INGRESE LA BASE IMPONIBLE", "COMPROBANTE RETENCIÓN", num)
                        Dim response = KryptonInputBox.Show("Ingrese la base imponible", "Comprobante retención", num.ToString())
                        If IsNumeric(response) Then
                            Dim valiva = Math.Round((CDbl(response) * porcent) / 100, 2, MidpointRounding.AwayFromZero)
                            dgvDetalleComprobanteRetencion.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valiva, 2, MidpointRounding.AwayFromZero), cod, cue)
                        Else
                            'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "El separador decimal es el '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    End If

                    CalcularTotalesFactura()
                Else
                    'MsgBox("SELECCIONE LOS PARAMETROS NECESARIOS: IMPUESTO, CONCEPTO, CONTRIBUYENTE.", MsgBoxStyle.Information, "Mensaje de información")
                    KryptonMessageBox.Show("Seleccione los parametros necesarios: Impuesto, Concepto, Contribuyente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            Else
                'MsgBox("NO HA INGRESADO DATOS DE FACTURA.", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("No ha ingresado datos de factura", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        End Sub
        Private Sub btnEliminarImpuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminarImpuesto.Click
            If dgvDetalleComprobanteRetencion.RowCount = 0 Then
                'MsgBox("NO HAY CELDAS EN LA GRILLA", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("No hay celdas en la grilla", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                If dgvDetalleComprobanteRetencion.CurrentRow.Cells(3).Value = "RENTA" Then
                    dgvDetalleComprobanteRetencion.Rows.RemoveAt(dgvDetalleComprobanteRetencion.CurrentRow.Index)
                ElseIf dgvDetalleComprobanteRetencion.CurrentRow.Cells(3).Value = "IVA" Then
                    dgvDetalleComprobanteRetencion.Rows.RemoveAt(dgvDetalleComprobanteRetencion.CurrentRow.Index)
                End If
            End If

            CalcularTotalesFactura()
        End Sub



        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvAsientosDiario.KeyPress
            Try
                Select Case dgvAsientosDiario.CurrentCell.ColumnIndex
                    Case 1
                        e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                    Case 2
                        e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                    Case 3
                        e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                    Case Else
                        e.Handled = Not _validacionesAlfanumerica.EsAlfanumerico(e.KeyChar)
                End Select
            Catch
                e.Handled = False
            End Try
        End Sub

        Private Su

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            dgvDetalleComprobanteRetencion.EndEdit()

            ' verificar nota de credito
            If cmbNombreParametroDocumentos.SelectedValue = 7 Then
                Dim fact = _objetoComprobantesCompra.SeleccionarComprobanteCompraXNumeroyAutorizacion(_tipoCon, txtDocModComprobanteCompra.Text, txtRazModComprobanteCompra.Text)
                If fact.Rows.Count = 0 Then
                    'MsgBox("DEBE ESPECIFICAR LA FACTURA A LA QUE AFECTA ESTA NOTA DE CREDITO!")
                    KryptonMessageBox.Show("Debe especificar la factura a la que afecta esta nota de crédito", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                Else
                    Dim tfn = _objetoComprobantesCompra.SeleccionarTotalSaldoComprobanteCompraXId(_tipoCon, fact.Rows(0)(0).ToString())
                    If tfn.Rows.Count = 0 Then
                        'MsgBox("DEBE ESPECIFICAR LA FACTURA A LA QUE AFECTA ESTA NOTA DE CREDITO!")
                        KryptonMessageBox.Show("Debe especificar la factura a la que afecta esta nota de crédito", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If
                End If
            End If

            ' activo fijo
            If chkActivoFijo.Checked And _sqlCommandsActivoFijo.Count = 0 Then
                'MsgBox("DEBE INGRESAR LA INFORMACIÓN DEL ACTIVO FIJO!")
                KryptonMessageBox.Show("Debe ingresar la información del activo fijo", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            ' orden compra
            If chkReq.Checked And lblOrdenCompra.Text.Equals("###") Then
                'MsgBox("DEBE ESPECIFICAR LA ORDEN DE COMPRA!")
                KryptonMessageBox.Show("Debe especificar la orden de compra", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            VerificarNumeroSecuencialRetencion()

            If txtObservacionesComprobantesCompra.Text.Trim().Equals("...") Or txtObservacionesComprobantesCompra.Text.Length < 6 Then
                'MsgBox("DEBE AGREGAR LA OBSERVACIÓN O DETALLE DEL DOCUMENTO!")
                KryptonMessageBox.Show("Debe agregar la observación o detalle del documento", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If Trim(txtNumeroComprobanteCompra.Text.Trim).Length <> 15 Then
                'MsgBox("EL NÚMERO DE COMPROBANTE DE COMPRA DEBE TENER 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de comprobante de compra debe tener 15 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If txtNumeroComprobanteCompra.Text.Trim.Contains("-") Then
                'MsgBox("EL NÚMERO DE COMPROBANTE DE COMPRA NO DEBE TENER GUÍONES. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de comprobante de compra no debe tener guíones. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If txtNumAutoSRIComprobanteCompra.Text.Trim.Length < 10 Then
                'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA DEL SRI NO PUEDE TENER MENOS DE 10 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de autorización de factura del SRI no puede tener menos de 10 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If txtNumAutoSRIComprobanteCompra.Text.Trim.Length > 10 And txtNumAutoSRIComprobanteCompra.TextLength < 37 Then
                'MsgBox("EL NÚMERO DE AUTORIZACIÓN DE FACTURA ELECTRÓNICA ES DE 37 DIGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El número de autorización de factura electrónica es de 37 dígitos. Por favor revise", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If Not ValidarFecha() Then Return
            If Not ValidarTipoDocumentoProveedor() Then Return
            If Not ValidarNumeroComprobanteRepetidoProveedor() Then Return
            If Not ValidarNumeroComprobanteRetencionRepetido() Then Return
            If Not ValidarNumeroComprobanteLiquidacionRepetido() Then Return

            If chkActivarRetencion.Checked And dgvDetalleComprobanteRetencion.RowCount = 0 Then
                'MsgBox("NO OLVIDE LLENAR LOS DETALLES DE LA RETENCIÓN!!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No olvide llenar los detalles de la retención", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If chkActivarRetencion.Checked And Not ValidacionParametrosRetencion() Then
                'MsgBox("HA MARCADO RETENCIÓN PARA ESTA COMPRA, POR FAVOR VERIFIQUE LOS DATOS DE LA MISMA!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Ha marcado retención para esta compra, por favor verifique los datos de la misma", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpFechaEmisionComprobanteCompra.Value) Then
                'MsgBox("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA INGRESAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICION AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El ATS del mes " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " del año " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " ya fue generado." & vbNewLine & " Si necesita ingresar este comprobante solicite una sustutiva a la contadora y haga una requisicion al departamento de sistemas.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            Else
                Dim msj = If(lblOrdenCompra.Text.Equals("###"), "", " CON ÓRDEN N° " & lblOrdenCompra.Text)
                'If MessageBox.Show("¿Esta seguro que desea guardar EL COMPROBANTE" & msj & "?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                If KryptonMessageBox.Show("¿Esta seguro que desea guardar EL COMPROBANTE" & msj & "?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

                If ValidacionParametros() Then

                    _valDebe = 0
                    _valHaber = 0

                    VerificarNumeroSecuencialRetencion()
                    VerificarNumeroSecuencialLiquidacionCompra()

                    'FACTURA 01, LIQUIDACION DE COMPRA 03, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                    _claveAccesoRetencion = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("07", dtpComprobanteRetencion.Value, RucEmpresaCisepro, If(rbPruebas.Checked, 1, 2), _establecimientoRetencion, _ptoEmisionRetencion, _secuencialRetencion, If(rbTipoEmisionNormal.Checked, 1, 2))
                    _claveAccesoLiqCompra = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("03", dtpFechaEmisionComprobanteCompra.Value, RucEmpresaCisepro, If(rbPruebas.Checked, 1, 2), _establecimientoLiqCompra, _ptoEmisionLiqCompra, _secuencialLiqCompra, If(rbTipoEmisionNormal.Checked, 1, 2))

                    If ((_ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004") And chkActivarRetencion.Checked And _claveAccesoRetencion.ToString.Length <> 49) Then

                        KryptonMessageBox.Show("Hubo un problema al generar la clave de acceso retención", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If

                    If ((_ptoEmisionLiqCompra = "002" OrElse _ptoEmisionLiqCompra = "003" OrElse _ptoEmisionLiqCompra = "004") And cmbNombreParametroDocumentos.SelectedValue = 3 And _claveAccesoLiqCompra.ToString.Length <> 49) Then

                        KryptonMessageBox.Show("Hubo un problema al generar la clave de acceso liquidación compra", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If

                    _sqlCommands.Clear()

                    _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
                    _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
                    _objAuditoria.FormularioAuditoria = Text.Trim
                    _objAuditoria.EstadoAuditoria = 1
                    _objAuditoria.IdUsuarioAuditoria = IdUsuario

                    GuardarComprobanteCompra()

                    If chkActivarRetencion.Checked Then
                        If (_ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004") And chkActivarRetencion.Checked Then ActualizarSecuencial()
                        GuardarComprobanteRetencion()
                        GuardarDetalleComprobanteRetencion()
                    End If

                    If (_ptoEmisionLiqCompra = "002" OrElse _ptoEmisionLiqCompra = "003" OrElse _ptoEmisionLiqCompra = "004") And cmbNombreParametroDocumentos.SelectedValue = 3 Then ActualizarSecuencialLiquidacion()

                    GuardarPagosComprobantesCompra()
                    GuardarPagosComprobantesCompraxNotaCredito()

                    ' CONTABILIDAD
                    NumeroRegistroAsientoLibroDiario()

                    _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)
                    _idld = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

                    NuevoRegistroAsientoDiarioCompra()

                    If txtIvaComprobanteCompra.Text > 0 Then NuevoRegistroAsientoDiarioIva(ObtenerPorcentajeIvaCombinado(), CDec(txtIvaComprobanteCompra.Text)) ' SI LA COMPRA GRABA IVA

                    If txtIva5ComprobanteCompra.Text > 0 Then NuevoRegistroAsientoDiarioIva(5, CDec(txtIvaComprobanteCompra.Text)) ' SI LA COMPRA GRABA IVA 5%

                    If chkActivarRetencion.Checked Then
                        If txtTotalComprobanteRetencion.Text > 0 Then
                            NuevoRegistroAsientoDiarioRetencion()
                            If (_objetoAsientoLibroDiario.CodigoCuentaAsiento + "").Trim().Length = 0 Then
                                'MsgBox("No se puede guardar." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "La cuenta para el código de retención escogido no ha sido definida en la BD!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                Return
                            End If
                        End If
                    End If

                    NuevoRegistroAsientoDiarioCxp()

                    Dim texto = "DEBE: " & _valDebe & "        -        HABER: " & _valHaber
                    If Math.Abs(_valDebe - _valHaber) > 0.01 Then
                        'MsgBox("NO ES POSBLE PROCESAR LA COMPRA PORQUE LA TRANSACCIÓN GENERADA NO CUADRA!!!" & vbNewLine & texto)
                        KryptonMessageBox.Show("No es posible procesar la compra porque la transacción generada no cuadra!!!" & vbNewLine & texto, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If


                    ' ACTIVO FIJO
                    If chkActivoFijo.Checked And _sqlCommandsActivoFijo.Count > 0 Then
                        ' copiar lista sql commands
                        For Each cmd As SqlCommand In _sqlCommandsActivoFijo
                            _sqlCommands.Add(cmd)
                        Next
                    End If



                    Dim nombreU As String = "Registro de Comprobante de Compra " & _objetoComprobantesCompra.IdComprobante.ToString() & " por : " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        _estado = 0

                        'If _ptoEmisionRetencion = "002" And chkActivarRetencion.Checked Then ExportarXmlRetencion()
                        If (_ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004") And chkActivarRetencion.Checked Then ExportarXmlRetencion()
                        'If _ptoEmisionLiqCompra = "002" And cmbNombreParametroDocumentos.SelectedValue = 3 Then ExportarXmlLiquidacionCompra()
                        If (_ptoEmisionLiqCompra = "002" OrElse _ptoEmisionLiqCompra = "003" OrElse _ptoEmisionLiqCompra = "004") And cmbNombreParametroDocumentos.SelectedValue = 3 Then ExportarXmlLiquidacionCompra()

                        lblIdComprobanteCompra.Text = _objetoComprobantesCompra.IdComprobante
                        DeshabilitadoInicio()
                        btnReporte.Enabled = True
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If



                Else
                    'MsgBox("No se puede guardar." & vbNewLine & "NO HA LLENADO TODOS LOS PARAMETROS NECESARIOS", MsgBoxStyle.Information, "Mensaje de validación")
                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No ha llenado todos los parametros necesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            End If
        End Sub

        Private Function ValidarTipoDocumentoProveedor() As Boolean
            If cmbNombreParametroDocumentos.SelectedValue = 3 Then 'LIQUIDACION DE COMPRA DE BIENES O PRESTACION DE SERVICIOS
                If txtRucProveedorGeneral.Text.Trim.Length = 13 Then
                    lblIdProveedorGeneral.Text = "..."
                    txtRucProveedorGeneral.Text = ""
                    txtNombreComercialProveedorGeneral.Text = ""
                    txtNombreComercialProveedorGeneral.Focus()
                    'MsgBox("LAS LIQUIDACIONES DE COMPRA NO SE PUEDEN HACER A PROVEEDORES CON RUC", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Las liquidaciones de compra no se pueden hacer a proveedores con RUC", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                End If
            ElseIf cmbNombreParametroDocumentos.SelectedValue = 1 Or cmbNombreParametroDocumentos.SelectedValue = 7 Then ' FACTURA / NOTA DE CREDITO
                If txtRucProveedorGeneral.Text.Length <> 13 Then
                    lblIdProveedorGeneral.Text = "..."
                    txtRucProveedorGeneral.Text = ""
                    txtNombreComercialProveedorGeneral.Text = ""
                    txtNombreComercialProveedorGeneral.Focus()
                    'MsgBox("LAS FACTURAS / NOTAS DE CREDITO NO SE PUEDEN HACER A PROVEEDORES SIN RUC", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Las facturas / notas de crédito no se pueden hacer a proveedores sin RUC", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return True
        End Function

        Private Function ValidarNumeroComprobanteRepetidoProveedor()
            If lblIdProveedorGeneral.Text <> "..." Then
                If txtNumeroComprobanteCompra.Text <> "" Then
                    If cmbNombreParametroDocumentos.SelectedValue <> 3 Then
                        Dim n = _objetoComprobantesCompra.BuscarNumeroComprobanteXIdProveedorNumeroComprobante(_tipoCon, lblIdProveedorGeneral.Text, txtNumeroComprobanteCompra.Text.Trim, cmbNombreParametroDocumentos.Text.Trim)
                        If n <> "0" Then
                            txtNumeroComprobanteCompra.Focus()
                            'MsgBox("EL NÚMERO DE COMPROBANTE " & n & " YA ESTA REGISTRADO PARA ESTE PROVEEDOR", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("El número de comprobante " & n & " ya está registrado para este proveedor", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                            Return False
                        End If
                    End If
                Else
                    'MsgBox("DEBE INGRESAR UN NUMERO DE FACTURA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Debe ingresar un número de factura", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                'MsgBox("DEBE INGRESAR UN PROVEEDOR", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Debe ingresar un proveedor", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return False
            End If
            Return True
        End Function

        Private Function ValidarNumeroComprobanteRetencionRepetido()
            If _estado = 0 Then Return True
            If txtNumeroComprobanteRetencion.Text <> "" And _ptoEmisionRetencion <> "001" Then
                If _objetoComprobantesRetencion.ExisteNumeroComprobanteRetencion(_tipoCon, txtNumeroComprobanteRetencion.Text) Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE RETENCIÓN " & txtNumeroComprobanteRetencion.Text & " YA ESTA REGISTRADO!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de comprobante de retención " & txtNumeroComprobanteRetencion.Text & " ya está registrado", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return True
        End Function

        Private Function ValidarNumeroComprobanteLiquidacionRepetido()
            If _estado = 0 Then Return True
            If txtNumeroComprobanteCompra.Text <> "" And _ptoEmisionLiqCompra <> "001" Then
                If _objetoComprobantesRetencion.ExisteNumeroComprobanteLiquidacionCompra(_tipoCon, txtNumeroComprobanteCompra.Text, lblIdProveedorGeneral.Text) Then
                    'MsgBox("EL NÚMERO DE COMPROBANTE DE LIQUIDACIÓN DE COMPRA " & txtNumeroComprobanteCompra.Text & " YA ESTA REGISTRADO!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("El número de comprobante de liquidación de compra " & txtNumeroComprobanteCompra.Text & " ya está registrado", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return True
        End Function

        Private Function ValidacionParametrosRetencion() As Boolean
            Return txtNumeroComprobanteRetencion.Text <> "" And txtTotalComprobanteRetencion.Text <> ""
        End Function

        Private Function ValidacionParametros() As Boolean
            Return (txtNombreComercialProveedorGeneral.Text <> "" And txtRucProveedorGeneral.Text <> "" And txtDireccionProveedorGeneral.Text <> "" _
               And txtCiudadProveedorGeneral.Text <> "" And txtTelefonoProveedorGeneral.Text <> "" And txtEmailProveedorGeneral.Text <> "" _
               And txtObligadoLlevarContabilidadProveedorGeneral.Text <> "" And txtContribuyenteEspecialProveedorGeneral.Text <> "" _
               And txtNumAutoContEspFacturaCompra.Text <> "" And txtNumeroComprobanteCompra.Text <> "" And txtNumAutoSRIComprobanteCompra.Text <> "" _
               And txtSubtotal12FacturaCompra.Text <> "" And txtSubtotal0FacturaCompra.Text <> "" And txtDescuentoFacturaCompra.Text <> "" _
               And txtIvaComprobanteCompra.Text <> "" And txtSubTotalComprobanteCompra.Text <> "" And txtTotalComprobanteCompra.Text <> "" _
               And dgvAsientosDiario.Rows.Count > 1)
        End Function

        Private Sub GuardarComprobanteCompra()
            With _objetoComprobantesCompra
                .IdComprobante = .BuscarMayorIdComprobanteCompra(_tipoCon) + 1
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .TipoComprobante = cmbNombreParametroDocumentos.Text
                .NumeroComprobante = Trim(txtNumeroComprobanteCompra.Text.Trim)
                .NumAutoSriComprobante = Trim(txtNumAutoSRIComprobanteCompra.Text.Trim)
                .FechaAutoSriComprobante = dtpFechaAutoSRIComprobanteCompra.Value
                .FechaEmisionComprobante = dtpFechaEmisionComprobanteCompra.Value
                .GuiaRemisionComprobante = txtGuiaRemisionComprobanteCompra.Text
                .DocModComprobante = txtDocModComprobanteCompra.Text
                .RazModComprobante = txtRazModComprobanteCompra.Text
                .ObservacionComprobante = txtObservacionesComprobantesCompra.Text
                .Subtotal12Comprobante = txtSubtotal12FacturaCompra.Text
                .Subtotal5Comprobante = txtSubtotal5FacturaCompra.Text
                .Subtotal0Comprobante = txtSubtotal0FacturaCompra.Text
                .DescuentoComprobante = txtDescuentoFacturaCompra.Text
                .SubtotalComprobante = txtSubTotalComprobanteCompra.Text

                '.PorcentajeIvaComprobante = PorcentajeIva
                If CDec(txtIva5ComprobanteCompra.Text) > 0 Then
                    .IvaComprobante = txtIva5ComprobanteCompra.Text
                    .PorcentajeIvaComprobante = 5
                Else
                    .IvaComprobante = txtIvaComprobanteCompra.Text
                    .PorcentajeIvaComprobante = ObtenerPorcentajeIvaCombinado()
                End If
                '.IvaComprobante = txtIvaComprobanteCompra.Text
                .Iva5Comprobante = txtIva5ComprobanteCompra.Text
                .TotalComprobante = txtTotalComprobanteCompra.Text
                .EstadoComprobante = 1
                .IdOrdenCompra = If(lblOrdenCompra.Text.Trim.Equals("###"), 0, CInt(lblOrdenCompra.Text))
            End With
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoRegistroComprobanteCompraCommand())
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", N°: " & _objetoComprobantesCompra.NumeroComprobante & ", FECHA: " & _objetoComprobantesCompra.FechaEmisionComprobante &
                "VALOR: " & _objetoComprobantesCompra.TotalComprobante)

            ' guardar detalle orde comprobante
            If _objetoComprobantesCompra.IdOrdenCompra = 0 Then Return
            _sqlCommands.Add(_objetoComprobantesCompra.NuevoDetalleOrdenComprobanteCompraCommand())

        End Sub

        Private Function ObtenerPorcentajeIvaCombinado() As Integer
            Dim ivaCombinado As Decimal = CDec(txtIvaComprobanteCompra.Text)
            Dim subtotalCombinado As Decimal = CDec(txtSubtotal12FacturaCompra.Text)

            If subtotalCombinado = 0 Then Return 0

            Dim porcentajeIva As Decimal = (ivaCombinado / subtotalCombinado) * 100

            ' Redondear al porcentaje de IVA más cercano (8%, 12%, 15%)
            Select Case porcentajeIva
                Case Is <= 8
                    Return 8
                Case Is <= 12
                    Return 12
                Case Else
                    Return 15
            End Select
        End Function


        Private Sub Auditoria(ByVal accion As String)
            _objAuditoria.IdAuditoria += 1
            _objAuditoria.AccionAuditoria = accion
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub ActualizarSecuencial()
            If cbxPtoEmision.SelectedItem.ToString() = "002" Then

                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialComprobanteRetencion = CLng(_secuencialRetencion)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand())
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "003" Then
                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialComprobanteRetencion = CLng(_secuencialRetencion)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand3())
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "004" Then
                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialComprobanteRetencion = CLng(_secuencialRetencion)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand4())
            End If
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", CTUALIZAR SECUENCIAL RETENCIÓN N°: " & _objetoInformacionTributaria.SecuencialComprobanteRetencion)
        End Sub
        Private Sub ActualizarSecuencialLiquidacion()
            If cbxPtoEmision.SelectedItem.ToString() = "002" Then
                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialLiquidacionCompra = CLng(_secuencialLiqCompra)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand())
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "003" Then
                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialLiquidacionCompra = CLng(_secuencialLiqCompra)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand3())
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "004" Then
                With _objetoInformacionTributaria
                    .Id = CInt(_dtEmpresa.Rows(0)(8).ToString())
                    .SecuencialLiquidacionCompra = CLng(_secuencialLiqCompra)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand4())
            End If

            'Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", CTUALIZAR SECUENCIAL RETENCIÓN N°: " & _objetoInformacionTributaria.SecuencialComprobanteRetencion)
        End Sub
        Private Sub GuardarComprobanteRetencion()
            With _objetoComprobantesRetencion
                .IdComprobanteRetencion = .BuscarMayorIdComprobanteRetencionCompra(_tipoCon) + 1
                .NumeroComprobanteRetencion = txtNumeroComprobanteRetencion.Text
                .NumAutoSriComprobanteRetencion = "1113541356"
                .FechaAutoSriComprobanteRetencion = dtpComprobanteRetencion.Value
                .FechaEmisionComprobanteRetencion = dtpComprobanteRetencion.Value
                .IdProveedor = lblIdProveedorGeneral.Text
                .TipoCompVentaComprobanteRetencion = cmbNombreParametroDocumentos.Text
                .NumCompVentaComprobanteRetencion = Trim(txtNumeroComprobanteCompra.Text)
                .TotalComprobanteRetencion = txtTotalComprobanteRetencion.Text
                If _ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004" Then
                    .EstadoComprobanteRetencion = 101 'Comprobante de retencion electronico emitido por compra
                Else
                    .EstadoComprobanteRetencion = 1 'Comprobante de retencion fisico emitido por compra
                End If
                .IdComprobanteCompra = _objetoComprobantesCompra.IdComprobante
            End With
            _sqlCommands.Add(_objetoComprobantesRetencion.NuevoRegistroComprobanteRetencionCompraCommand())
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", COMPROBANTE RETENCIÓN N°: " & _objetoComprobantesRetencion.NumeroComprobanteRetencion & ", FECHA: " & _objetoComprobantesRetencion.FechaEmisionComprobanteRetencion &
                "VALOR: " & _objetoComprobantesRetencion.TotalComprobanteRetencion)
        End Sub

        Private Sub GuardarDetalleComprobanteRetencion()
            Dim idd = _objetoDetalleComprobantesRetencion.BuscarMayorIdDetalleComprobanteRetencionCompra(_tipoCon) + 1
            Dim idr = _objetoDetalleRetencionPlanCuentas.BuscarMayorIdRegistroDetalleRetencionPlanCuenta(_tipoCon) + 1


            For indice = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                With _objetoDetalleComprobantesRetencion
                    .IdDetalleComprobanteRetencion = idd
                    .EjFiscalDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(0).Value
                    .CodigoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(1).Value
                    .BaseImponibleDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(2).Value
                    .ImpuestoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(3).Value.ToString.ToUpper
                    .PorcentajeComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(4).Value
                    .ValorDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(5).Value
                    If _ptoEmisionRetencion = "002" OrElse _ptoEmisionRetencion = "003" OrElse _ptoEmisionRetencion = "004" Then
                        .EstadoDetalleComprobanteRetencion = 101 'Comprobante de retencion electronico emitido por compra
                    Else
                        .EstadoDetalleComprobanteRetencion = 1 'Comprobante de retencion fisico emitido por compra
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
                    .IdDetalleComprobanteRetencionCompra = idd
                    .Codigo = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(6).Value
                    .Cuenta = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(7).Value
                End With
                _sqlCommands.Add(_objetoDetalleRetencionPlanCuentas.NuevoRegistroDetalleRetencionPlanCuenta)


                idd += 1
                idr += 1
            Next
        End Sub
        Private Sub GuardarPagosComprobantesCompraxNotaCredito()
            If cmbNombreParametroDocumentos.SelectedValue <> 7 Then Return ' NOTA CREDTIO
            Dim fact = _objetoComprobantesCompra.SeleccionarComprobanteCompraXNumeroyAutorizacion(_tipoCon, txtDocModComprobanteCompra.Text, txtRazModComprobanteCompra.Text)
            If fact.Rows.Count = 0 Then Return

            With _objetoPagosComprobantesCompra
                .IdPagosComprobantes += 1
                .NumeroPagosComprobantes = _objetoPagosComprobantesCompra.BuscarMayorNumeroPagosComprobantesCompra(_tipoCon, fact.Rows(0)(0)) + 1
                .MontoPagosComprobantes = CDbl(txtTotalComprobanteCompra.Text)
                .SaldoPagosComprobantes = _objetoPagosComprobantesCompra.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, fact.Rows(0)(0)) - .MontoPagosComprobantes
                .EstadoPagosComprobantes = 1
                .IdComprobante = fact.Rows(0)(0)
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .IdComprobanteEgreso = 0
            End With
            _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompraCommand())
        End Sub
        Private Sub GuardarPagosComprobantesCompra()
            With _objetoPagosComprobantesCompra
                .IdPagosComprobantes = .BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                .FechaPagosComprobantes = dtpFechaEmisionComprobanteCompra.Value
                .NumeroPagosComprobantes = 1
                If cmbNombreParametroDocumentos.SelectedValue = 7 Then ' verificar pago segun nota de crdito
                    .MontoPagosComprobantes = CDbl(txtTotalComprobanteCompra.Text)
                    .SaldoPagosComprobantes = 0
                Else
                    .MontoPagosComprobantes = 0
                    If chkActivarRetencion.Checked Then
                        .SaldoPagosComprobantes = CDec(txtTotalComprobanteCompra.Text) - CDec(txtTotalComprobanteRetencion.Text)
                    Else
                        .SaldoPagosComprobantes = CDec(txtTotalComprobanteCompra.Text)
                    End If
                End If
                .EstadoPagosComprobantes = 1
                .IdComprobante = _objetoComprobantesCompra.IdComprobante
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .IdComprobanteEgreso = 0
            End With
            _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompraCommand())
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", NOTA DE CRÉDITO ID: " & _objetoPagosComprobantesCompra.IdPagosComprobantes & ", FECHA: " & _objetoPagosComprobantesCompra.FechaPagosComprobantes &
                "VALOR: " & _objetoPagosComprobantesCompra.MontoPagosComprobantes)
        End Sub

        Private Sub NuevoRegistroAsientoDiarioCompra()
            For indiceAsiento = 0 To dgvAsientosDiario.Rows.Count - 2
                With _objetoAsientoLibroDiario
                    .IdAsiento = _idld
                    .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value
                    .CodigoCuentaAsiento = dgvAsientosDiario.Rows(indiceAsiento).Cells("CODIGO").Value.ToString().Trim
                    .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, dgvAsientosDiario.Rows(indiceAsiento).Cells("CODIGO").Value).ToString().Trim
                    .ConceptoAsiento = "COMPROBANTE DIARIO DE COMPRA"
                    .DetalleTransaccionAsiento = "ID CC: " & _objetoComprobantesCompra.IdComprobante & " PROVEEDOR: " & txtNombreComercialProveedorGeneral.Text.ToString & " " & cmbNombreParametroDocumentos.SelectedValue.ToString & " NRO: " & txtNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                    If cmbNombreParametroDocumentos.SelectedValue = 7 Then ' si es nota de credito
                        .ValorDebeAsiento = 0
                        .ValorHaberAsiento = CType(dgvAsientosDiario.Rows(indiceAsiento).Cells("VALOR").Value, Decimal)
                        .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                        _valHaber += .ValorHaberAsiento
                    Else
                        .ValorDebeAsiento = CType(dgvAsientosDiario.Rows(indiceAsiento).Cells("VALOR").Value, Decimal)
                        .ValorHaberAsiento = 0
                        .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                        _valDebe += .ValorDebeAsiento
                    End If
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())

                Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", ASIENTO DIARIO N°: " & _objetoAsientoLibroDiario.NumeroRegistroAsiento & ", FECHA: " & _objetoAsientoLibroDiario.FechaAsiento &
                "DET: " & _objetoAsientoLibroDiario.DetalleTransaccionAsiento & ", DEB: " & _objetoAsientoLibroDiario.ValorDebeAsiento & ", HAB: " & _objetoAsientoLibroDiario.ValorHaberAsiento)
                _idld += 1
            Next
            GuardarNumeroRegistroAsientoComprobanteCompra()
        End Sub

        Private Sub NuevoRegistroAsientoDiarioIva(porcentajeIva As Integer, valorIva As Decimal)

            If Not _ivaCuentas.ContainsKey(porcentajeIva) Then
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "La cuenta para el código de IVA " & porcentajeIva & " no ha sido definida en la BD!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If

            With _objetoAsientoLibroDiario
                .IdAsiento = _idld
                .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value

                .CodigoCuentaAsiento = _ivaCuentas(porcentajeIva)
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento).Trim
                .ConceptoAsiento = "IVA PAGADO POR COMPRA"
                .DetalleTransaccionAsiento = "ID CC: " & _objetoComprobantesCompra.IdComprobante & " PROVEEDOR: " & txtNombreComercialProveedorGeneral.Text.ToString & " " & cmbNombreParametroDocumentos.SelectedValue.ToString & " NRO: " & txtNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                If cmbNombreParametroDocumentos.SelectedValue = 7 Then ' si es nota de credito
                    .ValorDebeAsiento = 0
                    .ValorHaberAsiento = valorIva  'CDec(txtIvaComprobanteCompra.Text)
                    .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                    _valHaber += .ValorHaberAsiento
                Else
                    .ValorDebeAsiento = valorIva 'CDec(txtIvaComprobanteCompra.Text)
                    .ValorHaberAsiento = 0
                    .DebeHaberAsiento = 1  ' DEBE=1 / HABER=1 
                    _valDebe += .ValorDebeAsiento
                End If
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
            _idld += 1
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", ASIENTO DIARIO N°: " & _objetoAsientoLibroDiario.NumeroRegistroAsiento & ", FECHA: " & _objetoAsientoLibroDiario.FechaAsiento &
                "DET: " & _objetoAsientoLibroDiario.DetalleTransaccionAsiento & ", DEB: " & _objetoAsientoLibroDiario.ValorDebeAsiento & ", HAB: " & _objetoAsientoLibroDiario.ValorHaberAsiento)
        End Sub

        'Private Sub NuevoRegistroAsientoDiarioIva5()
        '    With _objetoAsientoLibroDiario
        '        .IdAsiento = _idld
        '        .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value

        '        .CodigoCuentaAsiento = "1010514"

        '        .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento).Trim
        '        .ConceptoAsiento = "IVA PAGADO POR COMPRA"
        '        .DetalleTransaccionAsiento = "ID CC: " & _objetoComprobantesCompra.IdComprobante & " PROVEEDOR: " & txtNombreComercialProveedorGeneral.Text.ToString & " " & cmbNombreParametroDocumentos.SelectedValue.ToString & " NRO: " & txtNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
        '        .ProvinciaAsiento = "EL ORO"
        '        .CiudadAsiento = "MACHALA"
        '        .ParroquiaAsiento = "MACHALA"
        '        .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
        '        If cmbNombreParametroDocumentos.SelectedValue = 7 Then ' si es nota de credito
        '            .ValorDebeAsiento = 0
        '            .ValorHaberAsiento = CDec(txtIvaComprobanteCompra.Text)
        '            .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
        '            _valHaber += .ValorHaberAsiento
        '        Else
        '            .ValorDebeAsiento = CDec(txtIva5ComprobanteCompra.Text)
        '            .ValorHaberAsiento = 0
        '            .DebeHaberAsiento = 1  ' DEBE=1 / HABER=1 
        '            _valDebe += .ValorDebeAsiento
        '        End If
        '        .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
        '        .ConciliarAsiento = 1
        '        .EstadoAsiento = 1
        '        .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
        '        .EstadoMayorAsiento = 0
        '    End With
        '    _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
        '    _idld += 1
        '    Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", ASIENTO DIARIO N°: " & _objetoAsientoLibroDiario.NumeroRegistroAsiento & ", FECHA: " & _objetoAsientoLibroDiario.FechaAsiento &
        '        "DET: " & _objetoAsientoLibroDiario.DetalleTransaccionAsiento & ", DEB: " & _objetoAsientoLibroDiario.ValorDebeAsiento & ", HAB: " & _objetoAsientoLibroDiario.ValorHaberAsiento)
        'End Sub

        ' retenciones
        Private Sub NuevoRegistroAsientoDiarioRetencion()
            For indiceRetencion = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                _objetoAsientoLibroDiario.CodigoCuentaAsiento = "" ' LIMPIAR AUX

                Dim codigo = dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(6).Value.ToString().Trim()
                Dim cuenta = dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(7).Value.ToString().Trim()
                If codigo.Trim().Length = 0 Or cuenta.Trim().Length = 0 Then Exit Sub

                With _objetoAsientoLibroDiario
                    .IdAsiento = _idld
                    .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value
                    .CodigoCuentaAsiento = codigo.Trim
                    .NombreCuentaAsiento = cuenta.Trim
                    .ConceptoAsiento = "OBLIGACIONES CON LA ADMINISTRACIÓN TRIBUTARIA"
                    .DetalleTransaccionAsiento = "ID CC: " & _objetoComprobantesCompra.IdComprobante & " PROVEEDOR: " & txtNombreComercialProveedorGeneral.Text.ToString & " " & cmbNombreParametroDocumentos.SelectedValue.ToString & " NRO: " & txtNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                    .ValorDebeAsiento = 0
                    .ValorHaberAsiento = CDec(dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(5).Value)
                    _valHaber += .ValorHaberAsiento
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", ASIENTO DIARIO N°: " & _objetoAsientoLibroDiario.NumeroRegistroAsiento & ", FECHA: " & _objetoAsientoLibroDiario.FechaAsiento &
                "DET: " & _objetoAsientoLibroDiario.DetalleTransaccionAsiento & ", DEB: " & _objetoAsientoLibroDiario.ValorDebeAsiento & ", HAB: " & _objetoAsientoLibroDiario.ValorHaberAsiento)
                _idld += 1
            Next
        End Sub

        Private Sub NuevoRegistroAsientoDiarioCxp()
            With _objetoAsientoLibroDiario
                .IdAsiento = _idld
                .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value
                .CodigoCuentaAsiento = "2010301"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "2010301")
                .ConceptoAsiento = "CUENTAS Y DOCUMENTOS POR PAGAR PROVEEDORES"
                .DetalleTransaccionAsiento = "ID CC: " & _objetoComprobantesCompra.IdComprobante & " PROVEEDOR: " & txtNombreComercialProveedorGeneral.Text.ToString & " " & cmbNombreParametroDocumentos.SelectedValue.ToString & " NRO: " & txtNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                If cmbNombreParametroDocumentos.SelectedValue = 7 Then ' si es nota de credito
                    .ValorDebeAsiento = CType(txtTotalComprobanteCompra.Text, Decimal) - CType(txtTotalComprobanteRetencion.Text, Decimal)
                    .ValorHaberAsiento = 0
                    .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                    _valDebe += .ValorDebeAsiento
                Else
                    .ValorDebeAsiento = 0
                    .ValorHaberAsiento = CType(txtTotalComprobanteCompra.Text, Decimal) - CType(txtTotalComprobanteRetencion.Text, Decimal)
                    .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                    _valHaber += .ValorHaberAsiento
                End If
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
            Auditoria("REGISTRO COMPROBANTE DE COMPRA ID: " & _objetoComprobantesCompra.IdComprobante & ", ASIENTO DIARIO N°: " & _objetoAsientoLibroDiario.NumeroRegistroAsiento & ", FECHA: " & _objetoAsientoLibroDiario.FechaAsiento &
                "DET: " & _objetoAsientoLibroDiario.DetalleTransaccionAsiento & ", DEB: " & _objetoAsientoLibroDiario.ValorDebeAsiento & ", HAB: " & _objetoAsientoLibroDiario.ValorHaberAsiento)
            _idld += 1
        End Sub

        Private Sub GuardarNumeroRegistroAsientoComprobanteCompra() 'Tabla intermedia para enlazar en el diario las comprobantes compra para anular compras
            With _objetoNumeroRegistroAsientoFacturaVenta
                .IdComprobante = _objetoComprobantesCompra.IdComprobante
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _idld
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoFacturaVenta.NuevoRegistroNumeroRegistroAsientoComprobanteCompraCommand())
        End Sub

        Private Sub NumeroRegistroAsientoLibroDiario()

            With _objetoNumeroRegistro
                .NumeroRegistro = _objetoNumeroRegistro.BuscarMayorNumeroRegistro(_tipoCon) + 1
                .NumeroAnterior = _objetoNumeroRegistro.BuscarMayorNumeroAnterior(_tipoCon)
            End With
            _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand)
        End Sub

        Public RutaDocsElec As String
        Private Sub ExportarXmlRetencion()
            Try
                Dim numeroRetencion = _establecimientoRetencion.ToString & "-" & _ptoEmisionRetencion.ToString & "-" & _secuencialRetencion
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
                xml += "<infoTributaria>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & If(rbPruebas.Checked, 1, 2) & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & If(rbTipoEmisionNormal.Checked, 1, 2) & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & RazonSocialEmpresaCisepro & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & NombreComercialEmpresaCisepro & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & RucEmpresaCisepro & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAccesoRetencion & "</claveAcceso>" & vbNewLine  ' Pendiente...
                xml += "<codDoc>07</codDoc>" & vbNewLine  ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoRetencion & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionRetencion & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialRetencion & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & DireccionEmpresaCisepro & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoCompRetencion>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA RETENCION =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpComprobanteRetencion.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & DireccionEmpresaCisepro & "</dirEstablecimiento>" & vbNewLine
                'If NumAutoContEspecialCisepro <> "0000" Then
                '    xml += "<contribuyenteEspecial>" & NumAutoContEspecialCisepro & "</contribuyenteEspecial>" & vbNewLine
                'End If
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionSujetoRetenido>" & TipoIdentificacionProveedor & "</tipoIdentificacionSujetoRetenido>" & vbNewLine
                xml += "<razonSocialSujetoRetenido>" & txtNombreComercialProveedorGeneral.Text & "</razonSocialSujetoRetenido>" & vbNewLine
                xml += "<identificacionSujetoRetenido>" & txtRucProveedorGeneral.Text & "</identificacionSujetoRetenido>" & vbNewLine

                Dim mesPeriodoFiscal = If(dtpComprobanteRetencion.Value.Month < 10, "0" & dtpComprobanteRetencion.Value.Month, dtpComprobanteRetencion.Value.Month.ToString)
                Dim periodoFiscal = mesPeriodoFiscal.ToString + "/" + dtpComprobanteRetencion.Value.Year.ToString

                xml += "<periodoFiscal>" & periodoFiscal & "</periodoFiscal>" & vbNewLine
                xml += "</infoCompRetencion>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                If dgvDetalleComprobanteRetencion.Rows.Count > 0 Then
                    xml += "<impuestos>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    For indiceDetalle = 0 To dgvDetalleComprobanteRetencion.Rows.Count - 1
                        xml += "<impuesto>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "RENTA" Then
                            xml += "<codigo>1</codigo>" & vbNewLine  ' RENTA => 1 IVA => 2 / ISD => 6
                            xml += "<codigoRetencion>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(1).Value.ToString & "</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION RENTA
                        ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "IVA" Then
                            xml += "<codigo>2</codigo>" & vbNewLine  ' RENTA => 1 IVA => 2 / ISD => 6
                            If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 10 Then
                                xml += "<codigoRetencion>9</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 20 Then
                                xml += "<codigoRetencion>10</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 30 Then
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION IVA BIENES
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 70 Then
                                xml += "<codigoRetencion>2</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION IVA SERVICIOS
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 100 Then
                                xml += "<codigoRetencion>3</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION IVA 100%
                            Else
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine  ' CODIGO DE RETENCION IVA BIENES
                            End If
                        End If
                        xml += "<baseImponible>" & Math.Round(dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(2).Value, 2, MidpointRounding.AwayFromZero) & "</baseImponible>" & vbNewLine
                        xml += "<porcentajeRetener>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value & "</porcentajeRetener>" & vbNewLine
                        xml += "<valorRetenido>" & Math.Round(dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(5).Value, 2, MidpointRounding.AwayFromZero) & "</valorRetenido>" & vbNewLine
                        If cmbNombreParametroDocumentos.SelectedValue = 9 Then
                            xml += "<codDocSustento>09</codDocSustento>" & vbNewLine
                        Else
                            xml += "<codDocSustento>01</codDocSustento>" & vbNewLine
                        End If
                        xml += "<numDocSustento>" & txtNumeroComprobanteCompra.Text & "</numDocSustento>" & vbNewLine
                        xml += "<fechaEmisionDocSustento>" & Format(dtpFechaEmisionComprobanteCompra.Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                    xml += "</impuestos>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                End If

                xml += "<infoAdicional>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & ". </campoAdicional>" & vbNewLine
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
                KryptonMessageBox.Show("Error al generar retención electrónica" & vbNewLine & ex.Message, "Mensaje de información.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ExportarXmlLiquidacionCompra()
            Try
                Dim baseImponibles As Decimal
                Dim totalSinImpuesto As Decimal

                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)

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
                xml += "<ambiente>" & If(rbPruebas.Checked, 1, 2) & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & If(rbTipoEmisionNormal.Checked, 1, 2) & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & RazonSocialEmpresaCisepro & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & NombreComercialEmpresaCisepro & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & RucEmpresaCisepro & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAccesoLiqCompra & "</claveAcceso>" & vbNewLine
                xml += "<codDoc>03</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoLiqCompra & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionLiqCompra & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialLiqCompra & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & DireccionEmpresaCisepro & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoLiquidacionCompra>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpFechaEmisionComprobanteCompra.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & txtDireccionProveedorGeneral.Text.Trim() & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & txtNumAutoContEspFacturaCompra.Text & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>" & txtObligadoLlevarContabilidadProveedorGeneral.Text.Trim() & "</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionProveedor>" & TipoIdentificacionProveedor & "</tipoIdentificacionProveedor>" & vbNewLine
                xml += "<razonSocialProveedor>" & txtNombreComercialProveedorGeneral.Text & "</razonSocialProveedor>" & vbNewLine
                xml += "<identificacionProveedor>" & txtRucProveedorGeneral.Text & "</identificacionProveedor>" & vbNewLine
                xml += "<direccionProveedor>" & txtDireccionProveedorGeneral.Text & "</direccionProveedor>" & vbNewLine ' ficha tecnica diciembre 2019; implementado 16/12/2019
                totalSinImpuesto = Math.Round(CDec(txtSubtotal12FacturaCompra.Text), 2, MidpointRounding.ToEven) - Math.Round(CDec(txtDescuentoFacturaCompra.Text), 2, MidpointRounding.ToEven)
                xml += "<totalSinImpuestos>" & totalSinImpuesto & "</totalSinImpuestos>" & vbNewLine
                xml += "<totalDescuento>" & txtDescuentoFacturaCompra.Text & "</totalDescuento>" & vbNewLine
                xml += "<codDocReembolso>00</codDocReembolso>" & vbNewLine
                xml += "<totalComprobantesReembolso>00</totalComprobantesReembolso>" & vbNewLine
                xml += "<totalBaseImponibleReembolso>00</totalBaseImponibleReembolso>" & vbNewLine
                xml += "<totalImpuestoReembolso>00</totalImpuestoReembolso>" & vbNewLine
                xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                'If PorcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                'If PorcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                'If PorcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                'If PorcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                'If PorcentajeIva = 8 Then xml += "<codigoPorcentaje>8</codigoPorcentaje>" & vbNewLine

                ' Obtener el porcentaje de IVA dinámicamente
                Dim porcentajeIva As Integer = ObtenerPorcentajeIvaCombinado()
                Dim codigoPorcentajeIva As String = ObtenerCodigoPorcentajeIva(porcentajeIva)
                xml += "<codigoPorcentaje>" & codigoPorcentajeIva & "</codigoPorcentaje>" & vbNewLine

                'xml += "<descuentoAdicional>0.00</descuentoAdicional>" & vbNewLine     'cambio 2024
                baseImponibles = Math.Round(CDec(txtSubtotal12FacturaCompra.Text), 2, MidpointRounding.ToEven) - Math.Round(CDec(txtDescuentoFacturaCompra.Text), 2, MidpointRounding.ToEven) & vbNewLine
                xml += "<baseImponible>" & baseImponibles & "</baseImponible>" & vbNewLine
                'xml += "<tarifa>" & PorcentajeIva & "</tarifa>" & vbNewLine
                xml += "<tarifa>" & porcentajeIva & "</tarifa>" & vbNewLine
                xml += "<valor>" & Math.Round(CDec(txtIvaComprobanteCompra.Text), 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<importeTotal>" & txtTotalComprobanteCompra.Text & "</importeTotal>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                '' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
                xml += "<pagos>" & vbNewLine
                xml += "<pago>" & vbNewLine
                xml += "<formaPago>01</formaPago>" & vbNewLine
                xml += "<total>" & txtTotalComprobanteCompra.Text & "</total>" & vbNewLine
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
                        xml += "<unidadMedida>UNIDAD</unidadMedida>" & vbNewLine
                        xml += "<cantidad>1</cantidad>" & vbNewLine
                        xml += "<precioUnitario>" & Math.Round(CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                        xml += "<descuento>0</descuento>" & vbNewLine
                        xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                        xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
                        If dgvAsientosDiario.Rows(indiceDetalle).Cells(4).Value = "S" Then

                            'If PorcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                            'If PorcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                            'If PorcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                            'If PorcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                            Dim codigoPorcentajeDetalle As String = ObtenerCodigoPorcentajeIva(porcentajeIva)
                            xml += "<codigoPorcentaje>" & codigoPorcentajeDetalle & "</codigoPorcentaje>" & vbNewLine
                            xml += "<tarifa>" & porcentajeIva & "</tarifa>" & vbNewLine
                            'xml += "<tarifa>" & PorcentajeIva & "</tarifa>" & vbNewLine
                            xml += "<baseImponible>" & dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value & "</baseImponible>" & vbNewLine
                            'Dim valorIvaDetalle = (CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value) * porcentajeIva) / 100
                            Dim valorIvaDetalle = (CDec(dgvAsientosDiario.Rows(indiceDetalle).Cells(3).Value) * porcentajeIva) / 100
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
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & nres & ". </campoAdicional>" & vbNewLine
                If _tipoCon = TipoConexion.Seportpac Then
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones Correo: seportpac@hotmail.com;</campoAdicional>" & vbNewLine
                Else
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
                End If
                xml += "<campoAdicional nombre='Observaciones'>" & txtObservacionesComprobantesCompra.Text.ToUpper.Trim() & "</campoAdicional>" & vbNewLine
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
                'MsgBox("ERROR A GENERAR LIQUIDACIÓN DE COMPRAS " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error al generar liquidación de compras" & vbNewLine & ex.Message, "Mensaje de información.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Function ObtenerCodigoPorcentajeIva(porcentajeIva As Integer) As String
            Select Case porcentajeIva
                Case 14
                    Return "3" ' IVA 14%
                Case 12
                    Return "2" ' IVA 12%
                Case 8
                    Return "8" ' IVA 8% 
                Case 15
                    Return "4" ' IVA 15%
                Case 0
                    Return "0" ' IVA 0%
                Case Else
                    Return "6" ' NO OBJETO DE IMPUESTO
            End Select
        End Function


        Private Sub btnOrdenCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim oc = New FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA.FormBuscarOrdenCompra()
                oc.TipoCox = _tipoCon
                oc.IdUsuario = IdUsuario
                oc.btnReporte.Visible = False
                oc.btnAceptar.Visible = True

                If oc.ShowDialog <> Windows.Forms.DialogResult.OK Then lblOrdenCompra.Text = "###"
                lblOrdenCompra.Text = oc.dgvOrdenCompra.CurrentRow.Cells(0).Value
            Catch
                lblOrdenCompra.Text = "###"
            End Try
        End Sub

        Private Sub dgvDetalleComprobanteRetencion_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleComprobanteRetencion.CellEndEdit
            Try
                ' dialogo escoger cuenta (cod, cue)
                Dim _frmPlan = New FrmBuscarPlanCuentas()
                _frmPlan.TipoCox = _tipoCon
                _frmPlan.Tipo = 2
                _frmPlan.cbxTipoCuenta.Enabled = False
                _frmPlan.txtParametrobusqueda.Enabled = False

                If dgvDetalleComprobanteRetencion(3, e.RowIndex).Value = "IVA" Then
                    _frmPlan.txtParametrobusqueda.Text = "201070102"
                Else
                    _frmPlan.txtParametrobusqueda.Text = "201070101"
                End If

                If _frmPlan.ShowDialog = DialogResult.OK Then
                    dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(1).Text.Trim()
                    dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(2).Text.Trim()
                Else
                    dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = String.Empty
                    dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = String.Empty
                End If

                Dim bi = dgvDetalleComprobanteRetencion.CurrentRow.Cells(2).Value
                Dim pr = dgvDetalleComprobanteRetencion.CurrentRow.Cells(4).Value
                dgvDetalleComprobanteRetencion.CurrentRow.Cells(5).Value = (CDec(bi) * (CDec(pr) / 100))
            Catch
                dgvDetalleComprobanteRetencion(4, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencion(5, e.RowIndex).Value = 0
                dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = String.Empty
                'MsgBox("HUBO UN PROBLEMA AL CALCULAR VALOR RETENIDO, INTENTE DE NUEVO.", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("Hubo un problema al calcular valor retenido, intente de nuevo.", "Mensaje de información.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
            CalcularTotalesFactura()
        End Sub

        Private Sub chkActivoFijo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivoFijo.CheckedChanged
            If Not chkActivoFijo.Checked Then
                _sqlCommandsActivoFijo.Clear()
                Return
            End If

            ' SELECCION ACTIVO FIJO            
            _frmActivoFijo = New FormIngresoActivosFijos
            _formDialogoNuevoActivo = New FormDialogoNuevoActivo
            _formDialogoNuevoActivo.TipoCox = TipoCox
            _frmActivoFijo.TipoCox = TipoCox
            _frmActivoFijo.IdUsuario = IdUsuario


            If _formDialogoNuevoActivo.ShowDialog() = DialogResult.OK Then

                ' ACTIVO FIJO 
                Select Case _formDialogoNuevoActivo.Tipo
                    Case 1 : _frmActivoFijo.HabilitarCamposRadios(True, True)
                    Case 2 : _frmActivoFijo.HabilitarCamposVehiculos(True, True)
                    Case 3 : _frmActivoFijo.HabilitarCamposTerrenos(True, True)
                    Case 4 : _frmActivoFijo.HabilitarCamposEquiposComputo(True, True)
                    Case 5 : _frmActivoFijo.HabilitarCamposLibrosyColecciones(True, True)
                    Case 6 : _frmActivoFijo.HabilitarCamposEquiposOficina(True, True)
                    Case 7 : _frmActivoFijo.HabilitarCamposMueblesOficina(True, True)
                    Case 8 : _frmActivoFijo.HabilitarCamposEquiposCocina(True, True)
                    Case 9 : _frmActivoFijo.HabilitarCamposEquiposAmbientación(True, True)
                    Case 10 : _frmActivoFijo.HabilitarCamposEquiposComunicacion(True, True)
                    Case 11 : _frmActivoFijo.HabilitarCamposEquiposSeguridad(True, True)
                    Case 12 : _frmActivoFijo.HabilitarCamposCamarasSeguridad(True, True)
                    Case 13 : _frmActivoFijo.HabilitarCamposGeneradores(True, True)
                    Case 14 : _frmActivoFijo.HabilitarCamposChalecos(True, True)
                    Case 15 : _frmActivoFijo.HabilitarCamposSoftware(True, True)
                    Case Else
                        _frmActivoFijo.HabilitarCamposArmas(True, True)
                End Select

                _frmActivoFijo.AutocompletarNombreProveedor()
                _frmActivoFijo.AutocompletarPersonal()
                _frmActivoFijo.AutocompletarResponsable()
                _frmActivoFijo.LlenarComboEmpresa()
                _frmActivoFijo.LlenarComboArea()
                _frmActivoFijo.LlenarComboGerencias()
                _frmActivoFijo.CargarCategoria()
                _frmActivoFijo.LlenarComboCuentasActivo()
                _frmActivoFijo.LlenarComboCuentasDepreciaciones()
                _frmActivoFijo.LlenarComboCuentasGastos()
                _frmActivoFijo.HabiLitarParametrosActivos(True, True)

                _frmActivoFijo.tcVarios.SelectedIndex = _formDialogoNuevoActivo.Tipo
                _frmActivoFijo.btnNuevo.Enabled = False
                _frmActivoFijo.btnGuardar.Enabled = True
                _frmActivoFijo.ButtonCancelar.Enabled = True
                _frmActivoFijo.txtIdActivoFijo.Text = "AUTO"
                _frmActivoFijo.txtIdActivoFijo.Enabled = False
                _frmActivoFijo.Text = _formDialogoNuevoActivo.Titulo
                _frmActivoFijo._tipoAccion = 1

                _frmActivoFijo.EsDialogo = True
                If _frmActivoFijo.ShowDialog() = DialogResult.OK Then
                    ' copiar lista sql commands
                    For Each cmd As SqlCommand In _frmActivoFijo._sqlCommands
                        _sqlCommandsActivoFijo.Add(cmd)
                    Next
                Else
                    _sqlCommandsActivoFijo.Clear()
                    chkActivoFijo.Checked = False
                End If
            Else
                _sqlCommandsActivoFijo.Clear()
                chkActivoFijo.Checked = False
            End If
            _formDialogoNuevoActivo.Close()
            _frmActivoFijo.Close()
        End Sub

        Private Sub dgvAsientosDiario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        End Sub

        Private Sub lblContribuyente_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub dtpFechaAutoSRIComprobanteCompra_ValueChanged(sender As Object, e As EventArgs)
            dtpComprobanteRetencion.Value = dtpFechaAutoSRIComprobanteCompra.Value
        End Sub

        Private Sub chkActivarRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivarRetencion.CheckedChanged
            If chkActivarRetencion.Checked Then
                'gbRetencion.Enabled = True

                txtNumeroComprobanteRetencion.Enabled = True
                txtTotalComprobanteRetencion.Enabled = True
                dtpComprobanteRetencion.Enabled = True
                cmbImpuesto.Enabled = True
                cmbConcepto.Enabled = True
                cmbContribuyente.Enabled = True
                cmbBienServicio.Enabled = True
                btnAgregarImpuesto.Enabled = True
                btnEliminarImpuesto.Enabled = True


                'GroupBox1.Enabled = True
                dgvDetalleComprobanteRetencion.Enabled = True

                LlenarComboImpuesto()
                LlenarComboConcepto()
                LlenarComboContribuyente()

                dtpComprobanteRetencion.MinDate = dtpFechaEmisionComprobanteCompra.Value
                dtpComprobanteRetencion.Value = dtpFechaEmisionComprobanteCompra.Value

                VerificarNumeroSecuencialRetencion()
            Else
                'GroupBox1.Enabled = False

                dgvDetalleComprobanteRetencion.Enabled = False

                'gbRetencion.Enabled = False

                txtNumeroComprobanteRetencion.Enabled = False
                txtTotalComprobanteRetencion.Enabled = False
                dtpComprobanteRetencion.Enabled = False
                cmbImpuesto.Enabled = False
                cmbConcepto.Enabled = False
                cmbContribuyente.Enabled = False
                cmbBienServicio.Enabled = False
                btnAgregarImpuesto.Enabled = False
                btnEliminarImpuesto.Enabled = False

                txtNumeroComprobanteRetencion.Text = ""
                txtTotalComprobanteRetencion.Text = "0.00"
                dtpComprobanteRetencion.MinDate = "1/01/2000"
            End If
        End Sub

        Private Sub dgvAsientosDiario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsientosDiario.CellClick
            If dgvAsientosDiario.Columns(e.ColumnIndex).Name = "eliminarItem" AndAlso dgvAsientosDiario.Rows(e.RowIndex).IsNewRow = False Then
                dgvAsientosDiario.EndEdit()
                dgvAsientosDiario.Rows.RemoveAt(e.RowIndex)
                CalcularTotalesFactura()
            End If
        End Sub

        Private Sub dgvAsientosDiario_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsientosDiario.CellEndEdit
            Try
                dgvAsientosDiario.Rows(e.RowIndex).ErrorText = [String].Empty
                If dgvAsientosDiario.Columns(e.ColumnIndex).Name = "CUENTA" Then
                    If dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value Is Nothing Then Return
                    If dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value.ToString.Trim.Length = 0 Then Return

                    Dim cod = dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value.ToString.Trim().Split("-")(0).Trim
                    Dim cue = dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value.ToString.Trim().Replace((cod.Trim & " - "), String.Empty).Trim

                    Try
                        Dim cc = _objetoPlanCuentas.BuscarDetallesCuentaPorCodigo(_tipoCon, cod)
                        If cc.Rows(0)(5) = "SI" Then
                            dgvAsientosDiario.CurrentRow.Cells("CODIGO").Value = cod
                            dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value = cc.Rows(0)(2)
                        Else
                            dgvAsientosDiario.CurrentRow.Cells("CODIGO").Value = String.Empty
                            dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value = String.Empty
                            'MsgBox("LA CUENTA: " & cc.Rows(0)(1) & " - " & cc.Rows(0)(2) & vbNewLine & "ES UNA CUENTA PADRE, NO GENERA MOVIMIENTO!!", MsgBoxStyle.Information, "Mensaje de información")
                            KryptonMessageBox.Show("La cuenta: " & cc.Rows(0)(1) & " - " & cc.Rows(0)(2) & vbNewLine & "es una cuenta padre, no genera movimiento!!", "Mensaje de información.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        End If
                    Catch ex As Exception
                        dgvAsientosDiario.CurrentRow.Cells("CODIGO").Value = cod
                        dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value = cue
                    End Try

                End If
            Catch
                dgvAsientosDiario.CurrentRow.Cells("CODIGO").Value = String.Empty
                dgvAsientosDiario.CurrentRow.Cells("CUENTA").Value = String.Empty
            End Try
        End Sub

        Private Sub dgvAsientosDiario_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsientosDiario.CellValidated
            If dgvAsientosDiario.Columns(e.ColumnIndex).Name = "PORCENTAJE" Then CalcularTotalesFactura()
        End Sub

        Private Sub dgvAsientosDiario_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsientosDiario.CellValueChanged
            If dgvAsientosDiario.Columns(e.ColumnIndex).Name = "PORCENTAJE" Then ' si se modifica el valor unitario


                Dim Control As Integer = Convert.ToInt32(dgvAsientosDiario.CurrentRow.Cells("PORCENTAJE").Value)
                Select Case Control
                    Case 0
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "N"
                    Case 5
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                        'PorcentajeIva = 5
                    Case 8
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                    Case 10
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                        'PorcentajeIva = 10
                    Case 12
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                        'PorcentajeIva = 12
                    Case 14
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                        'PorcentajeIva = 14
                    Case 15
                        dgvAsientosDiario.CurrentRow.Cells("IVA").Value = "S"
                        'PorcentajeIva = 15
                End Select

                CalcularTotalesFactura()
            End If
        End Sub

        Private Sub dgvAsientosDiario_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvAsientosDiario.CellBeginEdit
            If e.ColumnIndex = 1 Then e.Cancel = True
        End Sub

        Private Sub dgvAsientosDiario_KeyPress(sender As Object, e As KeyPressEventArgs)

        End Sub

        Private Sub dgvAsientosDiario_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvAsientosDiario.EditingControlShowing
            Dim itemName = TryCast(e.Control, TextBox)
            If itemName IsNot Nothing Then
                If dgvAsientosDiario.CurrentCell.ColumnIndex = 2 Then
                    itemName.AutoCompleteCustomSource = _objetoPlanCuentas.Autocompletar(_tipoCon)
                    itemName.AutoCompleteMode = AutoCompleteMode.Suggest
                    itemName.AutoCompleteSource = AutoCompleteSource.CustomSource
                Else
                    itemName.AutoCompleteMode = AutoCompleteMode.None
                End If
            End If
            Dim itemType = TryCast(e.Control, TextBox)
            If itemType IsNot Nothing Then AddHandler itemType.KeyPress, AddressOf ItemType_KeyPress
        End Sub

        Private Sub KryptonGroupBox3_Panel_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroupBox3.Panel.Paint

        End Sub

        Private Sub chkReq_CheckedChanged(sender As Object, e As EventArgs) Handles chkReq.CheckedChanged
            lblOrdenCompra.Text = "###"
            btnOrdenCompra.Enabled = chkReq.Checked
        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            ofdSeleccionarArchivo.InitialDirectory = "C:\"
            ofdSeleccionarArchivo.Filter = "ARCHIVO DE FACTURA ELECTRÓNICA (*.xml)|*.xml"
            ofdSeleccionarArchivo.Title = "Seleccione el archivo de factura electrónica"
            If ofdSeleccionarArchivo.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

            Dim archivo = ofdSeleccionarArchivo.OpenFile
            LeerXml(archivo)
            archivo.Close()
        End Sub

        Private Sub bntBuscarMod_Click(sender As Object, e As EventArgs) Handles bntBuscarMod.Click
            Dim frmEmitido = New FrmBuscarComprobanteCompraNotaCredito
            frmEmitido.IdProveedor = If(lblIdProveedorGeneral.Text = "...", 0, lblIdProveedorGeneral.Text)
            frmEmitido.TipoCox = TipoCox
            If frmEmitido.ShowDialog <> DialogResult.OK Then Return

            txtDocModComprobanteCompra.Text = frmEmitido.dgvCustodios.CurrentRow.Cells(3).Value ' numero
            txtRazModComprobanteCompra.Text = frmEmitido.dgvCustodios.CurrentRow.Cells(20).Value ' autorizacion

            ' VERIFICAR PAGOS Y NOTA DE CREDITO
            Dim ret = _objetoComprobantesRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, frmEmitido.dgvCustodios.CurrentRow.Cells(0).Value)
            If ret.Rows.Count > 0 Or CDec(frmEmitido.dgvCustodios.CurrentRow.Cells(10).Value) <> CDec(frmEmitido.dgvCustodios.CurrentRow.Cells(17).Value) Then
                'If MessageBox.Show("Existen retenciones o valores pagados para esta factura!! " & vbNewLine & "TOTAL: $ " & frmEmitido.dgvCustodios.CurrentRow.Cells(10).Value & " - SALDO: $" & frmEmitido.dgvCustodios.CurrentRow.Cells(17).Value & vbNewLine & "¿Desea continuar con el proceso?", "VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                If KryptonMessageBox.Show("Existen retenciones o valores pagados para esta factura!! " & vbNewLine & "TOTAL: $ " & frmEmitido.dgvCustodios.CurrentRow.Cells(10).Value & " - SALDO: $" & frmEmitido.dgvCustodios.CurrentRow.Cells(17).Value & vbNewLine & "¿Desea continuar con el proceso?", "VALIDACIÓN", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then

                    btnGuardar.Enabled = False
                    btnGuardarEnFondoRotativo.Enabled = False
                    Return
                End If
            End If

            btnGuardar.Enabled = True
            btnGuardarEnFondoRotativo.Enabled = True
        End Sub

        Private Sub cbxPtoEmision_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxPtoEmision.SelectedValueChanged
            VerificarNumeroSecuencialRetencion()
            VerificarNumeroSecuencialLiquidacionCompra()
        End Sub
    End Class
End Namespace