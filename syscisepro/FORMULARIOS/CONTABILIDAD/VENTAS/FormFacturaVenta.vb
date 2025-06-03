Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Xml
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports System.Text
Imports Krypton.Toolkit
Imports ComponentFactory.Krypton.Navigator


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>

    Public Class FormFacturaVenta
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

        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoConceptosFacturaVenta As New ClassConceptosFacturaVenta
        ReadOnly _objetoFormasPago As New ClassFormasPago
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoDetalleFacturaVenta As New ClassDetalleFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesAlfanumerica As New ClassAlfanumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _validacionesConversion As New ClassConversion
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos

        ReadOnly _objetoDireccionesFacturacion As New ClassDireccionesFacturacion


        Dim _varIdAsiento As Integer

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""
        Dim _porcentajeIva As Integer = 0
        Dim _secuencialFactura As String = 0
        Dim _numAutoContEspecial As String = ""
        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA
        Dim _razonSocial As String = "" ' razon social de la empresa emisora de la factura electrónica
        Dim _claveAcceso As String = "" ' clave de acceso para envio de la factura electrónica
        Dim _tipoIdentificacionCliente As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
        Dim _totalDebe As Decimal = 0
        Dim _totalHaber As Decimal = 0

        Private Sub FormFacturaVenta_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiarioFactura.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac

                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiarioFactura.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro


                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiarioFactura.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiarioFactura.Font = New Font("Roboto", 8, FontStyle.Regular)
            VerificarCbConvenio()

            AddHandler dgvDetalleFacturaVenta.CellValueChanged, AddressOf dgvDetalleFacturaVenta_CellValueChanged

            AutocompletarNombreCliente()
            DeshabilitadoInicio()
            CargarDatosEmpresa()
            lblSubtotalIva.Text = "Subtotal " + _porcentajeIva.ToString + ":"
            lblIva.Text = "IVA (" + _porcentajeIva.ToString + "):"
            LlenarComboConcepto()
            LlenarComboFormasPago()
            LlenarComboIva()
            'rbPtoEmision002.Checked = True
            'rbProduccion.Checked = True
            'rbTipoEmisionNormal.Checked = True
            cbxPtoEmision.SelectedIndex = 1

        End Sub
        Private Sub VerificarCbConvenio()
            If cbxConvenio.DataSource Is Nothing Then
                cbxConvenio.Items.Clear()
                cbxConvenio.Items.Add("-- SELECCIONE UNA CUENTA DEBITO --")
            End If
            cbxConvenio.SelectedIndex = 0
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
            'gbPtoEmision.Enabled = True
            'rbPtoEmision001.Enabled = True
            'rbPtoEmision002.Enabled = True
            cbxPtoEmision.Enabled = True
            'gbTipoAnbiente.Enabled = True
            rbPruebas.Enabled = True
            rbProduccion.Enabled = True
            'gbTipoEmision.Enabled = True
            rbTipoEmisionNormal.Enabled = True
            rbTipoEmisionIndisponibilidadSistema.Enabled = True
            'gbCliente.Enabled = False
            txtNombreComercialCliente.Enabled = False
            cmbDirecciones.Enabled = False
            'gbFecha.Enabled = False
            dtpFechaEmisionFacturaVenta.Enabled = False
            dtpPlazo.Enabled = False
            cbxPlazo.Enabled = False
            'gbSon.Enabled = False
            txtSon.Enabled = False
            'gbFormaPago.Enabled = False
            rbContado.Enabled = False
            rbCredito.Enabled = False
            'gbTipoPago.Enabled = False
            cmbTipoPagoFactura.Enabled = False
            'gbConceptoFactura.Enabled = False
            cmbConcepto.Enabled = False
            'gbObservaciones.Enabled = False
            txtObservacionesFactura.Enabled = False
            'gbValores.Enabled = False
            cmbIva.Enabled = False

            dgvDetalleFacturaVenta.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = False
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            btnCompEgreso.Enabled = False
            'GroupBox5.Enabled = False
            cbxConvenio.Enabled = False
            'GroupBox4.Enabled = False
            lblRucCiCliente.Text = "..."
            lblLlevaContabilidad.Text = "..."

        End Sub
        Private Sub CargarDatosEmpresa()
            Try
                Dim emp = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                If emp.Rows.Count > 0 Then
                    lblIdEmpresa.Text = emp.Rows(0)(0)
                    lblRucEmpresa.Text = emp.Rows(0)(2)
                    _razonSocial = emp.Rows(0)(3)
                    lblNombreComercialEmpresa.Text = emp.Rows(0)(4)
                    txtDireccionEmpresa.Text = emp.Rows(0)(5)
                    _numAutoContEspecial = emp.Rows(0)(6)
                    lblEstablecimientoFacturaEmpresa.Text = emp.Rows(0)(9)
                    lblNroAutoSRIEmpresa.Text = emp.Rows(0)(12)
                    '_porcentajeIva = emp.Rows(0)(21)  'AQUI CAMBIO 2024
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub LlenarComboConcepto()
            Try
                cmbConcepto.DataSource = _objetoConceptosFacturaVenta.SeleccionarRegistrosConceptosFacturaVenta(_tipoCon)
                cmbConcepto.DisplayMember = "NOMBRE_CONCEPTO_FACTURA_VENTA"
                cmbConcepto.ValueMember = "NOMBRE_CONCEPTO_FACTURA_VENTA"
                If (CType(cmbConcepto.DataSource, DataTable).Rows.Count > 0) Then cmbConcepto.SelectedIndex = 0
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbConcepto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbConcepto.SelectedValueChanged
            If cmbConcepto.SelectedValue Is Nothing Or TypeOf cmbConcepto.SelectedValue Is DataRowView Then Return
            lblCodigoCuentaConcepto.Text = _objetoConceptosFacturaVenta.BuscarCuentaConceptosFacturaVentaPorNombre(_tipoCon, cmbConcepto.SelectedValue)

            _fechaDesde = "01-01-" & dtpFechaEmisionFacturaVenta.Value.Year.ToString & " 00:00:00.001" ' primer dia del mes
            _fechaHasta = dtpFechaEmisionFacturaVenta.Value.Day.ToString & "-" & dtpFechaEmisionFacturaVenta.Value.Month.ToString & "-" & dtpFechaEmisionFacturaVenta.Value.Year.ToString & " 23:59:59.000" ' dia de emision de la factura

            CargarFacturasVenta()
            CargarAsiento()
        End Sub
        Private Sub LlenarComboFormasPago()
            Try
                cmbTipoPagoFactura.DataSource = _objetoFormasPago.SeleccionarRegistrosFormasPago(_tipoCon)
                cmbTipoPagoFactura.DisplayMember = "DETALLE_FORMA_PAGO"
                cmbTipoPagoFactura.ValueMember = "DETALLE_FORMA_PAGO"
                If (CType(cmbTipoPagoFactura.DataSource, DataTable).Rows.Count > 0) Then cmbTipoPagoFactura.SelectedIndex = 0
            Catch
                cmbTipoPagoFactura.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboIva()
            Try
                Dim data As New DataTable()
                data.Columns.Add("TIPO")
                data.Columns.Add("VAL")

                data.Rows.Add("IVA 10%", 10)
                data.Rows.Add("IVA 12%", 12)
                data.Rows.Add("IVA 13%", 13)
                data.Rows.Add("IVA 14%", 14)
                data.Rows.Add("IVA 15%", 15)


                cmbIva.DataSource = data
                cmbIva.DisplayMember = data.Columns("TIPO").ToString()
                cmbIva.ValueMember = data.Columns("VAL").ToString()
                cmbIva.DropDownWidth = 200
                cmbIva.SelectedIndex = 4
            Catch
                cmbIva.DataSource = Nothing
            End Try





        End Sub

        Private Sub CargarFacturasVenta()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.BuscarFacturaVentaXIdClienteConceptoRangoFecha(_tipoCon, lblIdClienteGeneral.Text, cmbConcepto.SelectedValue, _fechaDesde, _fechaHasta)
                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "FACTURA"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).HeaderText = "FECHA"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Format = "d"
                dgvFacturaVenta.Columns(3).HeaderText = "RUC"
                dgvFacturaVenta.Columns(3).Visible = False
                dgvFacturaVenta.Columns(4).HeaderText = "CLIENTE"
                dgvFacturaVenta.Columns(4).Visible = False
                dgvFacturaVenta.Columns(5).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(5).Visible = False
                dgvFacturaVenta.Columns(6).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(6).Visible = False
                dgvFacturaVenta.Columns(7).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(7).Visible = False
                dgvFacturaVenta.Columns(8).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(8).Visible = False
                dgvFacturaVenta.Columns(9).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(9).Visible = False
                dgvFacturaVenta.Columns(10).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(10).Visible = False
                dgvFacturaVenta.Columns(11).HeaderText = "EST"
                dgvFacturaVenta.Columns(11).Visible = False
                dgvFacturaVenta.Columns(12).Visible = False
                dgvFacturaVenta.Columns(13).Visible = False
                dgvFacturaVenta.Columns(14).Visible = False
                dgvFacturaVenta.Columns(15).Visible = False
                dgvFacturaVenta.Columns(16).Visible = False
                dgvFacturaVenta.Columns(17).Visible = False
                dgvFacturaVenta.Columns(18).Visible = False
                dgvFacturaVenta.Columns(19).Visible = False
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.Columns(2).Width = 80
                dgvFacturaVenta.ReadOnly = True
                dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarAsiento()
            Try
                If lblCodigoCuentaConcepto.Text <> "..." And lblRucCiCliente.Text <> "..." Then
                    dgvAsientoDiarioFactura.Rows.Clear()

                    'cxc
                    dgvAsientoDiarioFactura.Rows.Add()
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CODIGO").Value = "1010205"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CUENTA").Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "1010205")
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CONCEPTO").Value = "DOCUMENTOS Y CUENTAS POR COBRAR CLIENTES"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DETALLE").Value = "ID FV: " + lblIdFacturaVenta.Text.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DEBE").Value = CDec(txtTotal.Text)
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("HABER").Value = "0.00"

                    'iva
                    dgvAsientoDiarioFactura.Rows.Add()
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CODIGO").Value = "20107010206"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CUENTA").Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "20107010206")
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CONCEPTO").Value = "IVA COBRADO POR VENTA"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DETALLE").Value = "ID FV: " + lblIdFacturaVenta.Text.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DEBE").Value = "0.00"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("HABER").Value = CDec(txtIva.Text)

                    'venta
                    dgvAsientoDiarioFactura.Rows.Add()
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CODIGO").Value = lblCodigoCuentaConcepto.Text
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CUENTA").Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, lblCodigoCuentaConcepto.Text)
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("CONCEPTO").Value = "COMPROBANTE DIARIO DE VENTA"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DETALLE").Value = "ID FV: " + lblIdFacturaVenta.Text.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("DEBE").Value = "0.00"
                    dgvAsientoDiarioFactura.Rows(dgvAsientoDiarioFactura.Rows.Count - 1).Cells("HABER").Value = CDec(txtSubTotal.Text)

                    'sumar debe y haber
                    _totalDebe = 0
                    _totalHaber = 0
                    For indiceSuma = 0 To dgvAsientoDiarioFactura.Rows.Count - 1
                        _totalDebe += CDec(dgvAsientoDiarioFactura.Rows(indiceSuma).Cells("DEBE").Value)
                        _totalHaber += CDec(dgvAsientoDiarioFactura.Rows(indiceSuma).Cells("HABER").Value)
                    Next
                End If
            Catch ex As Exception
                'MsgBox("Cargar Asiento" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Error, Favor reportar a Sistemas")
                KryptonMessageBox.Show("Cargar Asiento" & vbNewLine & ex.Message.ToString, "Error, Favor reportar a Sistemas", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            _secuencialFactura = 0
            HabilitadoNuevo() ' habilita los campos que se van a utilizar para la factura
            LimpiarParametros() ' limpia los campos que se van a utilizar para la factura

            cbxConvenio.DataSource = Nothing
            VerificarCbConvenio()

            CargarDatosEmpresa()
            NumFactura()

            ObservacionesFecha()
            txtNombreComercialCliente.Focus()
            cbxPlazo.SelectedIndex = 3
            cmbTipoPagoFactura.SelectedIndex = 6
        End Sub
        Private Sub NumFactura()

            Dim _ptoEmision As String
            _ptoEmision = cbxPtoEmision.Text
            ' Número de factura
            'If lblPtoEmisionFacturaEmpresa.Text = "001" Then
            '    _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVenta(_tipoCon)) + 1
            'ElseIf lblPtoEmisionFacturaEmpresa.Text = "002" Then
            '    _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt(_tipoCon)) + 1
            'Else
            '    _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt(_tipoCon)) + 1
            'End If

            If _ptoEmision = "002" OrElse _ptoEmision = "003" OrElse _ptoEmision = "004" Then

                Select Case _ptoEmision
                    Case "002"
                        _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt(_tipoCon)) + 1
                    Case "003"
                        _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt3(_tipoCon)) + 1
                    Case "004"
                        _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt4(_tipoCon)) + 1

                End Select

            Else
                _secuencialFactura = CLng(_objetoFacturaVenta.BuscarMayorNumeroFacturaVenta(_tipoCon)) + 1
            End If

            Dim secuencial As Long = CLng(_secuencialFactura)
            _secuencialFactura = secuencial.ToString("D9")

            lblNumeroFacturaVenta.Text = _secuencialFactura

        End Sub
        Private Sub HabilitadoNuevo()
            'gbPtoEmision.Enabled = False
            'gbTipoAnbiente.Enabled = False
            'gbTipoEmision.Enabled = False

            'rbPtoEmision001.Enabled = False
            'rbPtoEmision002.Enabled = False
            cbxPtoEmision.Enabled = False
            rbPruebas.Enabled = False
            rbProduccion.Enabled = False
            rbTipoEmisionNormal.Enabled = False
            rbTipoEmisionIndisponibilidadSistema.Enabled = False



            'gbCliente.Enabled = True
            txtNombreComercialCliente.Enabled = True
            cmbDirecciones.Enabled = True
            'gbFecha.Enabled = True
            dtpFechaEmisionFacturaVenta.Enabled = True
            dtpPlazo.Enabled = True
            cbxPlazo.Enabled = True
            txtSon.Enabled = True
            'gbFormaPago.Enabled = True
            rbContado.Enabled = True
            rbCredito.Enabled = True
            'gbTipoPago.Enabled = True
            cmbTipoPagoFactura.Enabled = True
            'gbConceptoFactura.Enabled = True
            cmbConcepto.Enabled = True


            'gbObservaciones.Enabled = True
            txtObservacionesFactura.Enabled = True
            'gbValores.Enabled = False
            cmbIva.Enabled = True
            'gbValores.Enabled = True
            dgvDetalleFacturaVenta.Enabled = True
            dgvDetalleFacturaVenta.ReadOnly = False

            'GroupBox5.Enabled = True
            cbxConvenio.Enabled = True
            'GroupBox4.Enabled = True

            ' para que no se editen estas columnas del detalle de la factura
            dgvDetalleFacturaVenta.Columns(0).ReadOnly = True ' columna suprimir
            dgvDetalleFacturaVenta.Columns(1).ReadOnly = True ' columna id
            dgvDetalleFacturaVenta.Columns(6).ReadOnly = True ' columna valor total

            btnNuevo.Enabled = False
            btnModificar.Enabled = True
            btnCancelar.Enabled = True
            btnGuardar.Enabled = False
            btnCompEgreso.Enabled = True
        End Sub
        Private Sub LimpiarParametros()
            lblNumeroFacturaVenta.Text = "..."
            txtNombreComercialCliente.Text = ""
            txtRucCiCliente.Text = ""
            txtDireccionFacturacionCliente.Text = ""
            txtTelefonoClienteGeneral.Text = ""
            txtGuiaRemisionFacturaVenta.Text = "000"
            dgvDetalleFacturaVenta.Rows.Clear()
            dgvFacturaVenta.DataSource = Nothing
            txtSon.Text = ""
            txtObservacionesFactura.Text = ""
            txtSubtotal12.Text = "0.00"
            txtSubtotal0.Text = "0.00"
            txtDescuento.Text = "0.00"
            txtSubTotal.Text = "0.00"
            txtIva.Text = "0.00"
            txtTotal.Text = "0.00"
            lblSubtotalIva.Text = "Sub Total 12:"


            dgvAsientoDiarioFactura.Rows.Clear()
            cbxConvenio.DataSource = Nothing
        End Sub
        Private Sub ObservacionesFecha()
            Dim mes = dtpFechaEmisionFacturaVenta.Value.Month
            Dim nombreMes = ValidationForms.Mes(mes) 'MonthName(mes, False)
            Select Case mes
                Case 1, 3, 5, 7, 8, 10, 12
                    txtObservacionesFactura.Text = "Del 01 al 31 de " + nombreMes.ToUpper.ToString
                Case 2
                    txtObservacionesFactura.Text = "Del 01 al 28 de " + nombreMes.ToUpper.ToString
                Case 2, 4, 6, 9, 11
                    txtObservacionesFactura.Text = "Del 01 al 30 de " + nombreMes.ToUpper.ToString
            End Select
        End Sub
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            CargarDatosCliente()

            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = "01-" & dtpFechaEmisionFacturaVenta.Value.Month.ToString & "-" & dtpFechaEmisionFacturaVenta.Value.Year.ToString & " 00:00:00.001" ' primer dia del mes
            _fechaHasta = dtpFechaEmisionFacturaVenta.Value.Day.ToString & "-" & dtpFechaEmisionFacturaVenta.Value.Month.ToString & "-" & dtpFechaEmisionFacturaVenta.Value.Year.ToString & " 23:59:59.000" ' dia de emision de la factura

            CargarFacturasVenta()
            CargarConveniosDebitoBanco()
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)
                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    If cli.Rows(0)(3) = "9999999999999" Then
                        _tipoIdentificacionCliente = "07"
                    Else
                        Select Case cli.Rows(0)(2).ToString
                            Case "RUC"
                                _tipoIdentificacionCliente = "04"
                            Case "CEDULA"
                                _tipoIdentificacionCliente = "05"
                            Case "PASAPORTE"
                                _tipoIdentificacionCliente = "06"
                            Case "IDENTIFICACION DEL EXTERIOR"
                                _tipoIdentificacionCliente = "08"
                        End Select
                    End If
                    txtRucCiCliente.Text = cli.Rows(0)(3)
                    lblRucCiCliente.Text = cli.Rows(0)(3)
                    lblLlevaContabilidad.Text = cli.Rows(0)(7)
                    txtDireccionFacturacionCliente.Text = cli.Rows(0)(8)
                    txtTelefonoClienteGeneral.Text = cli.Rows(0)(11)
                    lblEmpresaCliente.Text = If(cli.Rows(0)(20) Is DBNull.Value, "", cli.Rows(0)(20))
                    ' CARGAR DIRECCIONES CLIENTE
                    Try
                        cmbDirecciones.DataSource = _objetoDireccionesFacturacion.BuscarDireccionesFacturacionClienteXIdClienteEnVentas(_tipoCon, lblIdClienteGeneral.Text)
                        cmbDirecciones.DisplayMember = "DIRECCION_FACTURACION"
                        cmbDirecciones.ValueMember = "DIRECCION_FACTURACION"
                        If (CType(cmbDirecciones.DataSource, DataTable).Rows.Count > 0) Then cmbDirecciones.SelectedIndex = 0
                    Catch
                        cmbDirecciones.DataSource = Nothing
                    End Try
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos cliente." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarConveniosDebitoBanco()
            Try
                cbxConvenio.DataSource = Nothing
                Dim co = _objetoConceptosFacturaVenta.SeleccionarConveniosDebitoByIdCliente(_tipoCon, CInt(lblIdClienteGeneral.Text.Trim))
                If co.Rows.Count <> 0 Then
                    cbxConvenio.DataSource = co
                    cbxConvenio.DisplayMember = co.Columns(1).ToString
                    cbxConvenio.ValueMember = co.Columns(0).ToString
                    If co.Rows.Count > 1 Then cbxConvenio.SelectedIndex = 1
                Else
                    VerificarCbConvenio()
                End If
            Catch ex As Exception
                'MsgBox("ERROR AL CARGAR CONVENIOS DÉBITO BANCARIO:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar convenios débito bancario:" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub cmbTipoPagoFactura_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoPagoFactura.SelectedValueChanged
            If cmbTipoPagoFactura.SelectedValue Is Nothing Or TypeOf cmbTipoPagoFactura.SelectedValue Is DataRowView Then Return
            lblCodigoFormasPago.Text = _objetoFormasPago.BuscarCodigoFormasPagoXdetalle(_tipoCon, cmbTipoPagoFactura.Text)
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellClick
            If dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "eliminarItem" AndAlso dgvDetalleFacturaVenta.Rows(e.RowIndex).IsNewRow = False Then
                dgvDetalleFacturaVenta.Rows.RemoveAt(e.RowIndex)
                dgvDetalleFacturaVenta.EndEdit()
                CalcularTotalesFactura()
            End If
        End Sub
        Private Sub CalcularTotalesFactura()
            Dim subtotal0 As Decimal
            Dim subTotal12 As Decimal = 0.0
            Dim subtotal As Decimal
            Dim descuent As Decimal = 0.0
            Dim iva2 As Decimal
            Dim total As Decimal


            For indiceSuma = 0 To dgvDetalleFacturaVenta.RowCount - 2
                If dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(3).Value <> Nothing And dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(4).Value <> Nothing Then
                    If dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(3).Value <> 0 And dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(4).Value <> 0 Then
                        subTotal12 += CDec(dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(3).Value) * CDec(dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(4).Value)
                        descuent += CDec(dgvDetalleFacturaVenta.Rows(indiceSuma).Cells(5).Value)
                    End If
                End If
            Next
            subtotal = subtotal0 + (subTotal12 - descuent)
            iva2 = Math.Round((subTotal12 - descuent) * (_porcentajeIva / 100), 2, MidpointRounding.ToEven)
            total = subtotal + iva2


            txtSubtotal0.Text = subtotal0
            txtSubtotal12.Text = subTotal12
            txtDescuento.Text = descuent
            txtSubTotal.Text = subtotal
            txtIva.Text = iva2
            txtTotal.Text = total
        End Sub

        Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTotal.TextChanged
            txtSon.Text = _validacionesConversion.Letras(txtTotal.Text) + " dólares"
        End Sub
        Private Sub rbPruebas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPruebas.CheckedChanged
            _tipoAmbiente = If(rbPruebas.Checked, 1, 2)
        End Sub
        Private Sub rbProduccion_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbProduccion.CheckedChanged
            _tipoAmbiente = If(rbProduccion.Checked, 2, 1)
        End Sub
        Private Sub rbTipoEmisionNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTipoEmisionNormal.CheckedChanged
            _tipoEmision = If(rbTipoEmisionNormal.Checked, 1, 2)
        End Sub
        Private Sub rbTipoEmisionIndisponibilidadSistema_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTipoEmisionIndisponibilidadSistema.CheckedChanged
            _tipoEmision = If(rbTipoEmisionIndisponibilidadSistema.Checked, 2, 1)
        End Sub
        Private Sub rbPtoEmision001_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs)
            lblPtoEmisionFacturaEmpresa.Text = If(rbPtoEmision001.Checked, "001", "002")
        End Sub
        Private Sub rbPtoEmision002_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs)
            lblPtoEmisionFacturaEmpresa.Text = If(rbPtoEmision002.Checked, "002", "001")
        End Sub
        Private Sub dtpFechaEmisionFacturaVenta_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpFechaEmisionFacturaVenta.ValueChanged
            ObservacionesFecha()
            If Not ValidarFecha() Then
                'MsgBox("LA SECUENCIA DE LOS MESES DE FACTURACIÓN ESTA SALTADA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("La secuencia de los meses de facturación esta saltada", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Function ValidarFecha()
            Dim fechaFacturaActual As DateTime
            Dim mesUltimaFactura As Integer
            Dim mesFacturaActual As Integer

            If dgvFacturaVenta.Rows.Count > 0 Then ' si hay facturas anteriores
                mesUltimaFactura = CDate(dgvFacturaVenta.Rows(0).Cells(2).Value).Month ' asigna el mes de la ultima factura
            Else ' si no hay facturas anteriores por el concepto seleccionado
                mesUltimaFactura = CDate(dtpFechaEmisionFacturaVenta.Value).Month - 1
            End If

            fechaFacturaActual = dtpFechaEmisionFacturaVenta.Value ' asigna la fecha actual
            mesFacturaActual = fechaFacturaActual.Month ' asigna el mes actual

            If mesUltimaFactura = (mesFacturaActual - 1) Or mesUltimaFactura = mesFacturaActual Then ' si el mes de la ultima factura es igual a el mes actual menos 1 los meses con seguidos
                Return True
            Else
                If cmbConcepto.SelectedValue = "VENTAS POR SERVICIOS DE SEGURIDAD Y VIGILANCIA" Or cmbConcepto.SelectedValue = "VENTAS POR SERVICIOS DE MONITOREO" Then ' si los meses no son seguidos y el concepto es vigilancia o monitoreo
                    Return False
                Else ' si no es vigilancia o monitoreo se puede facturar a meses saltados
                    Return True
                End If
            End If
        End Function
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            cbxConvenio.DataSource = Nothing
            VerificarCbConvenio()

            LimpiarParametros()
            DeshabilitadoInicio()
            cmbIva.SelectedIndex = 1
            cbxPtoEmision.SelectedIndex = 1
        End Sub
        Private Sub dgvDetalleFacturaVenta_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleFacturaVenta.EditingControlShowing
            Dim itemName = TryCast(e.Control, TextBox)
            If itemName IsNot Nothing Then
                itemName.CharacterCasing = CharacterCasing.Upper
                If dgvDetalleFacturaVenta.CurrentCell.ColumnIndex = 2 Then
                    itemName.AutoCompleteCustomSource = _objetoSecuencialItem.Autocompletar(_tipoCon)
                    itemName.AutoCompleteMode = AutoCompleteMode.Suggest
                    itemName.AutoCompleteSource = AutoCompleteSource.CustomSource
                Else
                    itemName.AutoCompleteMode = AutoCompleteMode.None
                End If
                AddHandler itemName.KeyPress, AddressOf ItemType_KeyPress
            End If
        End Sub
        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvDetalleFacturaVenta.KeyPress
            Select Case dgvDetalleFacturaVenta.CurrentCell.ColumnIndex
                Case 2 ' columna detalle item
                    e.Handled = Not _validacionesAlfanumerica.EsAlfanumerico(e.KeyChar)
                Case 3 ' columna cantidad
                    e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                Case 4 ' columna valor unitario
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                Case 5 ' columna descuento
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
            End Select
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellEndEdit
            dgvDetalleFacturaVenta.Rows(e.RowIndex).ErrorText = String.Empty
            BuscarIdItemDetalleFactura()
        End Sub
        Private Sub BuscarIdItemDetalleFactura()
            Try
                If dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value <> "" And dgvDetalleFacturaVenta.CurrentCell.ColumnIndex = 2 Then
                    For indice = 0 To dgvDetalleFacturaVenta.RowCount - 2
                        If indice <> dgvDetalleFacturaVenta.CurrentRow.Index Then
                            If dgvDetalleFacturaVenta.Rows(indice).Cells(2).Value.ToString <> dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value.ToString Then 'para ver si no esta repetido
                                ' id, cant, valor, desc
                                dgvDetalleFacturaVenta.CurrentRow.Cells(1).Value = _objetoSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value.ToString)
                                dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value = 1
                                dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value = _objetoSecuencialItem.BuscarCostoSecuencialItemXNombreSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value.ToString)
                                dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value = 0
                                dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value
                            Else
                                dgvDetalleFacturaVenta.Rows.RemoveAt(dgvDetalleFacturaVenta.CurrentRow.Index)
                                'MsgBox("EL ITEM SELECCIONADO YA ESTA AGREGADO A LA FACTURA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                KryptonMessageBox.Show("El item seleccionado ya esta agregado a la factura.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                Exit For
                            End If
                        Else
                            ' id, cant, valor, desc
                            dgvDetalleFacturaVenta.CurrentRow.Cells(1).Value = _objetoSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value.ToString)
                            dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value = 1
                            dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value = _objetoSecuencialItem.BuscarCostoSecuencialItemXNombreSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.CurrentRow.Cells(2).Value.ToString)
                            dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value = 0
                            dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value
                        End If
                    Next
                End If

                CalcularTotalesFactura()
                CargarAsiento()

            Catch ex As Exception
                'MsgBox("BUSCAR ID DE ITEM." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Error, por favor reportar a Sistemas")
                KryptonMessageBox.Show("Buscar id de item." & vbNewLine & ex.Message.ToString, "Error, por favor reportar a Sistemas", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValueChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellValueChanged
            If dgvDetalleFacturaVenta.RowCount = 0 Or dgvDetalleFacturaVenta.CurrentRow Is Nothing Then Return
            Try
                Dim cantidad As Decimal
                Dim valorUnitario As Decimal
                Dim valorDescuento As Decimal
                Dim valorTotal As Decimal

                If dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value Is Nothing OrElse dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value.ToString() = 0 Then
                    cantidad = 0
                Else
                    cantidad = CDec(dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value)
                End If

                If dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value Is Nothing OrElse dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value.ToString().Trim().Length = 0 Then
                    valorUnitario = 0
                Else
                    ' Si no es nulo, intenta convertirlo a Decimal
                    Decimal.TryParse(dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value.ToString(), valorUnitario)
                End If


                If dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value Is Nothing OrElse dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value.ToString().Trim().Length = 0 Then
                    valorDescuento = 0
                Else
                    ' Si no es nulo, intenta convertirlo a Decimal
                    Decimal.TryParse(dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value.ToString(), valorDescuento)
                End If


                valorTotal = (cantidad * valorUnitario) - valorDescuento  ' calcula el valor total del item
                dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = valorTotal ' asigna el valor a la casilla

            Catch
                If dgvDetalleFacturaVenta.CurrentRow Is Nothing Then Return
                If dgvDetalleFacturaVenta.CurrentRow.IsNewRow Then Return
                dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = "0.00"
            End Try
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValidating(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalleFacturaVenta.CellValidating
            If dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "valorUnitarioProductoServicio" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "cantidadProductoServicio" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "descuento" Then
                If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                    Return
                End If
            End If
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellValidated
            If dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "valorUnitarioProductoServicio" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "cantidadProductoServicio" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "descuento" Then
                CalcularTotalesFactura()
                CargarAsiento()
            End If
        End Sub
        Private Function ValidarValores()
            If CDec(txtTotal.Text) < 0.01 Then Return False
            If CDec(txtTotal.Text) <> (CDec(txtSubTotal.Text) + CDec(txtIva.Text)) Then Return False
            If _totalDebe <> _totalHaber Then Return False
            Return True
        End Function
        Private Function ValidarParametros() As Boolean
            Return lblIdEmpresa.Text <> "..." And lblIdClienteGeneral.Text <> "..." And lblNumeroFacturaVenta.Text <> "..." And lblCodigoCuentaConcepto.Text <> "..." And lblCodigoFormasPago.Text <> "0" And _
               txtGuiaRemisionFacturaVenta.Text <> "" And dgvDetalleFacturaVenta.RowCount > 1 And txtObservacionesFactura.Text <> "" And txtSon.Text <> ""
        End Function
        Private Function ValidarAsiento()
            Dim d = 0.0
            Dim h = 0.0
            For Each row As DataGridViewRow In dgvAsientoDiarioFactura.Rows
                d += CDec(row.Cells(4).Value)
                h += CDec(row.Cells(5).Value)
            Next
            Return Math.Round(d, 2) = Math.Round(h, 2)
        End Function

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            If Not cbxConvenio.DataSource Is Nothing Then
                If cbxConvenio.Items.Count > 1 And cbxConvenio.SelectedIndex = 0 Then
                    'MessageBox.Show("SELECCIONE EL CONVENIO DÉBTIO BANCO!!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    KryptonMessageBox.Show("Seleccione el convenio débito banco!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
            End If

            Dim claveIngresada As String ' clave ingresada para autorizar facturas con fecha saltada
            Dim claveGenerada As String ' clave para autorizar facturas con fecha saltada
            '
            Dim fechaMinimaIngreso = New Date(Date.Now.Year - 1, 1, 1)
            Dim fechaActualIngreso = New Date(dtpFechaEmisionFacturaVenta.Value.Year, dtpFechaEmisionFacturaVenta.Value.Month, dtpFechaEmisionFacturaVenta.Value.Day)

            If fechaMinimaIngreso > fechaActualIngreso Then ' si la fecha de registro de la factura corresponde al periodo contable en curso
                'MsgBox("NO SE PUEDEN REGISTRAR TRANSACCIONES DEL PERIODO " + dtpFechaEmisionFacturaVenta.Value.Year.ToString + "!", MsgBoxStyle.Critical, "Mensaje de validación")
                KryptonMessageBox.Show("No se pueden registrar transacciones del periodo " + dtpFechaEmisionFacturaVenta.Value.Year.ToString + "!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            Else
                If ValidarParametros() Then
                    If ValidarValores() Then ' verifica si los valores de la factura estan correctos
                        If ValidarAsiento() Then

                            'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA VENTA ACTUAL?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                            If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA VENTA ACTUAL?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                            _sqlCommands.Clear()

                            NumFactura()

                            If ValidarFecha() Then ' valida si las fechas de la nueva factura y la anterior del cliente son meses seguidos

                                'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                                _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("01", dtpFechaEmisionFacturaVenta.Value, lblRucEmpresa.Text, _tipoAmbiente, lblEstablecimientoFacturaEmpresa.Text, lblPtoEmisionFacturaEmpresa.Text, lblNumeroFacturaVenta.Text, _tipoEmision)

                                If _claveAcceso.ToString.Length = 49 Then ' si la clave de acceso para la facturacion electronica esta correcta

                                    ' guarda las tablas de la base de datos
                                    GuardarRegistroFacturaVenta() ' factura
                                    GuardarRegistroDetalleFacturaVenta() ' detalle de la factgura

                                    If (lblPtoEmisionFacturaEmpresa.Text = "002" OrElse lblPtoEmisionFacturaEmpresa.Text = "003" OrElse lblPtoEmisionFacturaEmpresa.Text = "004") Then ActualizarSecuencial() ' incrementa el secuencial de numeracion de factura

                                    GuardarPagosFacturaVenta() ' registra la deuda

                                    _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)
                                    NumeroRegistroAsientoLibroDiario() ' obtiene el numero de registro del asiento

                                    NuevoRegistroAsientoDiarioCxc() ' registra en el asiento diario la cuenta contable de cuentas por cobrar

                                    'If txtDescuento.Text > 0 Then NuevoRegistroAsientoDiarioDescuento()

                                    NuevoRegistroAsientoDiarioVenta() ' registra en el asiento diario la cuenta contable del tipo de venta
                                    NuevoRegistroAsientoDiarioIva() ' registra en el asiento diario la cuenta contable del iva

                                Else
                                    'MsgBox("CLAVE DE ACCESO INVALIDA. Por favor, intente nuevamente o póngase en contácto con el administrador!")
                                    KryptonMessageBox.Show("Clave de acceso invalida. Por favor, intente nuevamente o póngase en contácto con el administrador!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                    Exit Sub ' sale del evento
                                End If
                            Else
                                ' Show the input box.
                                'claveIngresada = InputBox("INGRESE LA CLAVE AUTORIZACIÓN", "VALOR COMPROBANTE")
                                claveIngresada = KryptonInputBox.Show("INGRESE LA CLAVE AUTORIZACIÓN", "VALOR COMPROBANTE")
                                If Not IsNumeric(claveIngresada) Then
                                    'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                    KryptonMessageBox.Show("Por favor ingrese solo números", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                    Exit Sub
                                End If

                                claveGenerada = claveGenerada + Format(dtpFechaEmisionFacturaVenta.Value, "ddMMyyyy").ToString 'fecha factura
                                claveGenerada = claveGenerada + lblNumeroFacturaVenta.Text.ToString  ' secuencial factura
                                claveGenerada = claveGenerada + "84" ' numero fijo
                                claveGenerada = claveGenerada + "9"
                                If claveGenerada.ToString = claveIngresada.ToString Then ' si la clave de autorizacion ingresada es correcta

                                    'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                                    _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("01", dtpFechaEmisionFacturaVenta.Value, lblRucEmpresa.Text, _tipoAmbiente, lblEstablecimientoFacturaEmpresa.Text, lblPtoEmisionFacturaEmpresa.Text, lblNumeroFacturaVenta.Text, _tipoEmision)

                                    If _claveAcceso.ToString.Length = 49 Then ' si la clave de acceso para la facturacion electronica esta correcta

                                        ' guarda las tablas de la base de datos
                                        GuardarRegistroFacturaVenta() ' factura
                                        GuardarRegistroDetalleFacturaVenta() ' detalle de la factura

                                        ActualizarSecuencial() ' incrementa el secuencial de numeracion de factura

                                        GuardarPagosFacturaVenta() ' registra la deuda

                                        _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)
                                        NumeroRegistroAsientoLibroDiario() ' obtiene el numero de registro del asiento

                                        NuevoRegistroAsientoDiarioCxc() ' registra en el asiento diario la cuenta contable de cuentas por cobrar

                                        'If txtDescuento.Text > 0 Then NuevoRegistroAsientoDiarioDescuento()

                                        NuevoRegistroAsientoDiarioVenta() ' registra en el asiento diario la cuenta contable del tipo de venta

                                        NuevoRegistroAsientoDiarioIva() ' registra en el asiento diario la cuenta contable del iva

                                    Else
                                        'MsgBox("CLAVE DE ACCESO INVALIDA. Por favor, intente nuevamente o póngase en contácto con el administrador!")
                                        KryptonMessageBox.Show("Clave de acceso invalida. Por favor, intente nuevamente o póngase en contácto con el administrador!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                        Exit Sub ' sale del evento
                                    End If
                                Else
                                    'MsgBox("CLAVE INGRESADA Y GENERADA NO SON IGUALES. Por favor, intente nuevamente o póngase en contácto con el administrador!")
                                    KryptonMessageBox.Show("Clave ingresada y generada no son iguales. Por favor, intente nuevamente o póngase en contácto con el administrador!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                    Exit Sub ' sale del evento
                                End If
                            End If


                            Dim nombreU As String = "FACTURA " & UserName
                            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                            If res(0) Then
                                If lblPtoEmisionFacturaEmpresa.Text = "002" OrElse lblPtoEmisionFacturaEmpresa.Text = "003" OrElse lblPtoEmisionFacturaEmpresa.Text = "004" Then ExportarXml()
                                DeshabilitadoInicio() ' bloquea los campos
                                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                            Else
                                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                Return
                            End If

                            'MsgBox(If(res(0), res(1) & vbNewLine & "XML GENERADO CORRECTAMENTE" & If(resx, " - XML GUARDADO", " - XML NO GUARDADO!"), res(1)), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")



                        Else
                            'MsgBox("No se puede guardar." & vbNewLine & ", EL ASIENTO NO CUADRA. REVISE EL ASIENTO DE DIARIO, SUBTOTAL, IVA Y TOTAL DE LA FACTURA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("El asiento no cuadra. revise el asiento de diario, subtotal, iva y total de la factura", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        End If
                    Else
                        'MsgBox("No se puede guardar." & vbNewLine & "INCONSISTENCIA CON LOS VALORES. REVISE EL ASIENTO DE DIARIO, SUBTOTAL, IVA Y TOTAL DE LA FACTURA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("Inconsistencia con los valores. revise el asiento de diario, subtotal, iva y total de la factura", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    End If
                Else
                    'MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No se han llenado todos los campos necesarios", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                End If
            End If
        End Sub
        Private Sub Auditoria()
            With _objAuditoria
                .IdAuditoria = CLng(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            End With
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Private Sub GuardarRegistroFacturaVenta()
            With _objetoFacturaVenta
                .IdFactura = .BuscarMayorIdFacturaVenta(_tipoCon) + 1
                .IdEmpresa = lblIdEmpresa.Text
                .NumeroFactura = CInt(lblNumeroFacturaVenta.Text)
                .FechaEmisionFactura = dtpFechaEmisionFacturaVenta.Value
                .GuiaRemisionFactura = txtGuiaRemisionFacturaVenta.Text
                .IdCliente = lblIdClienteGeneral.Text
                If rbContado.Checked Then
                    .TipoPagoFactura = rbContado.Text
                ElseIf rbCredito.Checked Then
                    .TipoPagoFactura = rbCredito.Text
                End If
                .ConceptoFactura = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, lblCodigoCuentaConcepto.Text)
                .ObservacionesFactura = txtObservacionesFactura.Text.ToUpper.TrimEnd
                .SubTotal12Factura = txtSubtotal12.Text
                .SubTotal0Factura = txtSubtotal0.Text
                .DescuentoFactura = txtDescuento.Text
                .SubTotalFactura = txtSubTotal.Text
                .PorcentajeIvaFactura = _porcentajeIva
                .IvaFactura = txtIva.Text
                .TotalFactura = txtTotal.Text
                If lblPtoEmisionFacturaEmpresa.Text = "002" OrElse lblPtoEmisionFacturaEmpresa.Text = "003" Then
                    .EstadoFactura = 2
                Else
                    .EstadoFactura = 1
                End If
                .PlazoFactura = dtpPlazo.Value
            End With
            _sqlCommands.Add(_objetoFacturaVenta.NuevoRegistroFacturaVenta)

            _objAuditoria.AccionAuditoria = "SE CREO UNA NUEVA FACTURA. Nº: " + CStr(lblEstablecimientoFacturaEmpresa.Text) + " - " + CStr(lblNumeroFacturaVenta.Text) _
                                            + " FECHA: " + dtpFechaEmisionFacturaVenta.Value + " RUC CLIENTE:" + txtRucCiCliente.Text + " NOMBRE COMERCIAL: " + txtNombreComercialCliente.Text _
                                            + " SUB TOTAL: " + txtSubTotal.Text + " IVA: " + txtIva.Text + " TOTAL: " + txtTotal.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()

            ' registre factura - convenio
            If Not cbxConvenio.DataSource Is Nothing Then
                If cbxConvenio.Items.Count > 1 Then
                    If cbxConvenio.SelectedIndex <> 0 Then
                        _objetoFacturaVenta.IdConvenio = CInt(cbxConvenio.SelectedValue)
                        _sqlCommands.Add(_objetoFacturaVenta.NuevoRegistroFacturaVentaConvenio)
                    End If
                End If
            End If
        End Sub
        Private Sub GuardarRegistroDetalleFacturaVenta()
            Dim i = _objetoDetalleFacturaVenta.BuscarMayorIdDetalleFacturaVenta(_tipoCon) + 1
            For indice = 0 To dgvDetalleFacturaVenta.RowCount - 2
                With _objetoDetalleFacturaVenta
                    .IdDetalleFactura = i
                    .IdSecuencialItem = dgvDetalleFacturaVenta.Rows(indice).Cells(1).Value
                    .CantidadDetalleFactura = dgvDetalleFacturaVenta.Rows(indice).Cells(3).Value ' cantidad
                    .ValorUDetalleFactura = dgvDetalleFacturaVenta.Rows(indice).Cells(4).Value ' valor unitario
                    .ValorDDetalleFactura = dgvDetalleFacturaVenta.Rows(indice).Cells(5).Value ' valor descuento
                    .ValorTDetalleFactura = dgvDetalleFacturaVenta.Rows(indice).Cells(6).Value ' valor total
                    .EstadoDetalleFactura = 1
                    .IdFactura = _objetoFacturaVenta.IdFactura
                End With
                _sqlCommands.Add(_objetoDetalleFacturaVenta.NuevoRegistroDetalleFacturaVenta)
                i += 1
            Next
        End Sub
        Private Sub ActualizarSecuencial()
            If cbxPtoEmision.SelectedItem.ToString() = "002" Then
                With _objetoInformacionTributaria
                    .Id = 1
                    .SecuencialFactura = CInt(lblNumeroFacturaVenta.Text)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialFacturaInformacionTributaria)
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "003" Then
                With _objetoInformacionTributaria
                    .Id = 1
                    .SecuencialFactura = CInt(lblNumeroFacturaVenta.Text)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialFacturaInformacionTributaria3)
            ElseIf cbxPtoEmision.SelectedItem.ToString() = "004" Then
                With _objetoInformacionTributaria
                    .Id = 1
                    .SecuencialFactura = CInt(lblNumeroFacturaVenta.Text)
                End With
                _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialFacturaInformacionTributaria4)
            End If

        End Sub
        Private Sub GuardarPagosFacturaVenta()
            With _objetoPagosFacturaVenta
                .IdPagoFactura = .BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
                .FechaPagoFactura = dtpFechaEmisionFacturaVenta.Value
                .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, _objetoFacturaVenta.IdFactura) + 1
                .FormaPagoFactura = "EFECTIVO"
                .MontoPagoFactura = "0.00"
                .SaldoPagoFactura = CDec(txtTotal.Text)
                .EstadoPagoFactura = 1
                .IdFactura = _objetoFacturaVenta.IdFactura
                .IdCliente = CInt(lblIdClienteGeneral.Text)
                .IdComprobanteIngreso = 0
            End With
            _sqlCommands.Add(_objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta)
        End Sub
        Private Sub NumeroRegistroAsientoLibroDiario()
            With _objetoNumeroRegistro
                .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
            End With
            _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())
        End Sub
        Private Sub NuevoRegistroAsientoDiarioCxc()
            _varIdAsiento = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionFacturaVenta.Value
                .CodigoCuentaAsiento = "1010205"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                .ConceptoAsiento = "DOCUMENTOS Y CUENTAS POR COBRAR CLIENTES"
                .DetalleTransaccionAsiento = "ID FV: " + _objetoFacturaVenta.IdFactura.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = CDec(txtTotal.Text)
                .ValorHaberAsiento = 0
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            GuardarNumeroRegistroAsientoXFacturaVenta() ' guarda el enlace entre el asiento de diario y la venta

            _varIdAsiento += 1
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
        End Sub

        Private Sub NuevoRegistroAsientoDiarioVenta() ' Registra en el diario la venta
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionFacturaVenta.Value
                .CodigoCuentaAsiento = lblCodigoCuentaConcepto.Text
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                .ConceptoAsiento = "COMPROBANTE DIARIO DE VENTA"
                .DetalleTransaccionAsiento = "ID FV: " + _objetoFacturaVenta.IdFactura.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = 0
                .ValorHaberAsiento = CDec(txtSubTotal.Text)
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
            _varIdAsiento += 1
        End Sub
        Private Sub NuevoRegistroAsientoDiarioIva() ' Registra en el diario el iva de la venta
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionFacturaVenta.Value
                .CodigoCuentaAsiento = "20107010206"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                .ConceptoAsiento = "IVA COBRADO POR VENTA"
                .DetalleTransaccionAsiento = "ID FV: " + _objetoFacturaVenta.IdFactura.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpFechaEmisionFacturaVenta.Value.Month.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = 0
                .ValorHaberAsiento = CDec(txtIva.Text)
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
            _varIdAsiento += 1
        End Sub
        Private Sub GuardarNumeroRegistroAsientoXFacturaVenta() 'Tabla intermedia para enlazar en el diario las facturas de venta con la retenciones cuando esta se nos emitan
            With _objetoNumeroRegistroAsientoFacturaVenta
                .IdFactura = _objetoFacturaVenta.IdFactura
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _varIdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoFacturaVenta.NuevoRegistroNumeroRegistroAsientoFacturaVenta)
        End Sub

        Public RutaDocsElec As String
        Private resx = False
        Private Sub ExportarXml()
            Try
                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
                Dim numeroFactura = lblEstablecimientoFacturaEmpresa.Text.ToString + "-" + lblPtoEmisionFacturaEmpresa.Text.ToString + "-" + lblNumeroFacturaVenta.Text

                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA " & numeroFactura & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
                End Select

                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<factura id='comprobante' version='1.1.0'>" & vbNewLine
                xml += "<infoTributaria>" ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocial & "</razonSocial>" & vbNewLine
                xml += "<ruc>" & lblRucEmpresa.Text & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine ' Pendiente...
                'xml += "<nombreComercial>" & lblNombreComercialEmpresa.Text & "</nombreComercial>" & vbNewLine 'Modificacion 01/04/24
                xml += "<codDoc>01</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & lblEstablecimientoFacturaEmpresa.Text & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & lblPtoEmisionFacturaEmpresa.Text & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & lblNumeroFacturaVenta.Text & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & txtDireccionEmpresa.Text & "</dirMatriz>" & vbNewLine
                xml += "<contribuyenteEspecial>NAC-DGERCGC25-00000011</contribuyenteEspecial>" & vbNewLine 'Modificacion 01/04/24
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoFactura>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpFechaEmisionFacturaVenta.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & txtDireccionEmpresa.Text & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionComprador>" & _tipoIdentificacionCliente & "</tipoIdentificacionComprador>" & vbNewLine
                xml += "<razonSocialComprador>" & txtNombreComercialCliente.Text & "</razonSocialComprador>" & vbNewLine
                xml += "<identificacionComprador>" & txtRucCiCliente.Text & "</identificacionComprador>" & vbNewLine
                xml += "<direccionComprador>" & cmbDirecciones.Text.Trim & "</direccionComprador>" & vbNewLine
                xml += "<totalSinImpuestos>" & txtSubTotal.Text & "</totalSinImpuestos>" & vbNewLine
                xml += "<totalDescuento>" & txtDescuento.Text & "</totalDescuento>" & vbNewLine
                xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
                If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                'xml += "<descuentoAdicional>0.00</descuentoAdicional>" & vbNewLine 'modificacion 01/04/2024
                xml += "<baseImponible>" & txtSubTotal.Text & "</baseImponible>" & vbNewLine
                'xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                xml += "<valor>" & txtIva.Text & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<propina>0.00</propina>" & vbNewLine
                xml += "<importeTotal>" & txtTotal.Text & "</importeTotal>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
                xml += "<pagos>" & vbNewLine
                xml += "<pago>" & vbNewLine
                xml += "<formaPago>" & lblCodigoFormasPago.Text.ToString.Trim & "</formaPago>" & vbNewLine
                xml += "<total>" & txtTotal.Text & "</total>" & vbNewLine
                xml += "<plazo>30</plazo>" & vbNewLine
                xml += "<unidadTiempo>dias</unidadTiempo>" & vbNewLine
                xml += "</pago>" & vbNewLine
                xml += "</pagos>" & vbNewLine
                ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</infoFactura>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                If dgvDetalleFacturaVenta.Rows.Count > 1 Then
                    For indiceDetalle = 0 To dgvDetalleFacturaVenta.Rows.Count - 2
                        xml += "<detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigoPrincipal>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(1).Value & "</codigoPrincipal>" & vbNewLine
                        xml += "<descripcion>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(2).Value & "</descripcion>" & vbNewLine
                        xml += "<cantidad>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(3).Value & "</cantidad>" & vbNewLine
                        xml += "<precioUnitario>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(4).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                        xml += "<descuento>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</descuento>" & vbNewLine
                        xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                        xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
                        If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                        xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                        xml += "<baseImponible>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value & "</baseImponible>" & vbNewLine
                        xml += "<valor>" & Math.Round(((CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value) * _porcentajeIva) / 100), 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                End If
                xml += "</detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & nres & ". </campoAdicional>" & vbNewLine
                If _tipoCon = TipoConexion.Seportpac Then
                    xml += "<campoAdicional nombre='Retencion'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones. Correo: seportpac@hotmail.com;</campoAdicional>" & vbNewLine
                Else
                    xml += "<campoAdicional nombre='Retencion'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
                End If
                xml += "<campoAdicional nombre='Observaciones'>" & txtObservacionesFactura.Text.ToUpper.ToString.TrimEnd & "</campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</factura>"


                _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
                _objetoComprobantesElectronicos.IdDocumento = _objetoFacturaVenta.IdFactura
                _objetoComprobantesElectronicos.Tipo = "FACTURA VENTA"
                _objetoComprobantesElectronicos.Documento = xml
                _objetoComprobantesElectronicos.FechaEmision = _objetoFacturaVenta.FechaEmisionFactura
                _objetoComprobantesElectronicos.NumDocumento = numeroFactura
                resx = _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

            Catch ex As Exception
                resx = False
                'MsgBox("ERROR A GENERAR FACTURA ELECTRÓNICA " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error a generar factura electrónica " & vbNewLine & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnCompEgreso_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCompEgreso.Click
            Dim frm As New FrmBuscarComprobanteIngresoEgreso
            frm.TipoCox = TipoCox
            frm.rbtIngreso.Enabled = False
            frm.rbtEgreso.Checked = True
            Try
                If frm.ShowDialog = vbOK Then
                    dgvDetalleFacturaVenta.Rows.Clear()
                    Dim grupo = frm.ListView1.SelectedItems(0).Group
                    For Each item As ListViewItem In grupo.Items
                        dgvDetalleFacturaVenta.Rows.Add()
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(1).Value = item.SubItems(2).Text ' id
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(2).Value = item.SubItems(3).Text ' det
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(3).Value = item.SubItems(4).Text ' cant
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(4).Value = item.SubItems(5).Text ' pvp
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(5).Value = "0.00"                ' desc
                        dgvDetalleFacturaVenta.Rows(dgvDetalleFacturaVenta.RowCount - 2).Cells(6).Value = item.SubItems(6).Text ' tot
                    Next

                    CalcularTotalesFactura()
                    CargarAsiento()
                End If
            Catch ex As Exception
                'MsgBox("ERROR AL CARGAR COMPROBANTE DE EGRESO " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error al cargar comprobante de egreso " & vbNewLine & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

            End Try
        End Sub

        Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIva.SelectedIndexChanged
            Dim selectedRow As DataRowView = DirectCast(cmbIva.SelectedItem, DataRowView)
            Dim selectedIva As Double = Convert.ToDouble(selectedRow("VAL"))
            lblSubtotalIva.Text = "Sub Total " & selectedIva.ToString() & "%"
            _porcentajeIva = selectedIva
        End Sub

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub

        Private Sub cbxPtoEmision_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxPtoEmision.SelectedValueChanged
            lblPtoEmisionFacturaEmpresa.Text = cbxPtoEmision.SelectedItem.ToString()
        End Sub

        Private Sub cbxPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPlazo.SelectedIndexChanged
            If cbxPlazo.SelectedItem IsNot Nothing Then
                Dim dias As Integer
                If Integer.TryParse(cbxPlazo.SelectedItem.ToString(), dias) Then
                    dtpPlazo.Value = DateTime.Now.AddDays(dias)
                End If
            End If
        End Sub

        'Private Sub ButtonSpecLeft_Click(sender As Object, e As EventArgs)
        '    If (navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup) Then
        '        navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly
        '        ButtonSpecLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight
        '    Else
        '        navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup
        '        ButtonSpecLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft

        '    End If

        'End Sub
    End Class
End Namespace