Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
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
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports System.Xml
Imports System.Text
Imports Krypton.Toolkit


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormNotaCredito
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
        Public UserName As String

        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria
        ReadOnly _objetoNotaCredito As New ClassNotaCredito
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoDetalleFacturaVenta As New ClassDetalleFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _objetoNumeroRegistroAsientoNotaCredito As New ClassNumeroRegistroAsientoNotaCreditoVenta
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesAlfanumerica As New ClassAlfanumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos

        Private resx = False

        Dim _varIdAsiento As Integer
        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA
        Dim _rucEmpresa As String = ""
        Dim _razonSocialEmpresa As String = "" ' razon social de la empresa emisora de la factura electrónica
        Dim _nombreComercialEmpresa As String = ""
        Dim _direccionEmpresa As String = ""
        Dim _numAutoContEspecial As String = ""
        Dim _establecimientoNotaCredito As String = ""
        Dim _ptoEmisionNotaCredito As String = ""
        Dim _secuencialNotaCredito As String = 0 'Dim numeroRetencion As String = ""
        Dim _nroAutoSriNotaCredito As String = ""
        Dim _porcentajeIva As Integer = 0
        Dim _numeroNotaCredito = ""
        Dim _claveAcceso As String = "" ' clave de acceso para envio de la factura electrónica
        Dim _tipoIdentificacionCliente As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07

        Private Sub FormNotaCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava


                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac


                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro


                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            DeshabilitadoInicio()
            AutocompletarNombreCliente()
            CargarDatosEmpresa()

            lblSubtotalIva.Text = "Subtotal " + _porcentajeIva.ToString + ":"
            lblSubtotal12OrdenCompra.Text = "SUB TOTAL " + _porcentajeIva.ToString + ":"
            lblIva.Text = "IVA (" + _porcentajeIva.ToString + "):"
            lblIvaOrdenCompra.Text = "IVA (" + _porcentajeIva.ToString + "%):"

            rbProduccion.Checked = True
            rbTipoEmisionNormal.Checked = True
            rbPtoEmision002.Checked = True

        End Sub


        Private Sub DeshabilitadoInicio()
            'gbClienteGeneral.Enabled = False
            txtNombreComercialCliente.Enabled = False
            'gbFechaNotaCredito.Enabled = False
            txtComprobanteModificaNotaCredito.Enabled = False
            txtRazonModificacionNotaCredito.Enabled = False
            'gbValoresNotaCredito.Enabled = False
            txtSubtotal12NotaCredito.Enabled = False
            txtSubtotal0NotaCredito.Enabled = False
            txtDescuentoNotaCredito.Enabled = False
            txtSubTotalNotaCredito.Enabled = False
            txtIvaNotaCredito.Enabled = False
            txtTotalNotaCredito.Enabled = False
            btnNuevo.Enabled = True
            btnCancelar.Enabled = False
            btnGuardarSinFirmar.Enabled = False
            dgvFacturaVenta.Enabled = False
            dgvDetalleFacturaVenta.Enabled = False
            rbPtoEmision001.Enabled = True
            rbPtoEmision002.Enabled = True
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
        Private Sub CargarDatosEmpresa()
            Try
                Dim cli = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                If cli.Rows.Count > 0 Then
                    lblIdEmpresa.Text = cli.Rows(0)(0)
                    _rucEmpresa = cli.Rows(0)(2)
                    lblRucEmpresa.Text = cli.Rows(0)(2)
                    _razonSocialEmpresa = cli.Rows(0)(3)
                    _nombreComercialEmpresa = cli.Rows(0)(4)
                    lblNombreComercialEmpresa.Text = cli.Rows(0)(4)
                    _direccionEmpresa = cli.Rows(0)(5)
                    txtDireccionEmpresa.Text = cli.Rows(0)(5)
                    _numAutoContEspecial = cli.Rows(0)(6)
                    _establecimientoNotaCredito = cli.Rows(0)(13)
                    lblEstablecimientoFacturaEmpresa.Text = cli.Rows(0)(13)
                    _secuencialNotaCredito = CInt(cli.Rows(0)(15)) + 1
                    _nroAutoSriNotaCredito = cli.Rows(0)(16)
                    lblNroAutoSRIEmpresa.Text = _nroAutoSriNotaCredito
                    _porcentajeIva = cli.Rows(0)(21)
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos empresa." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            _secuencialNotaCredito = 0
            LimpiarParametros()
            HabilitadoNuevo()

            CargarDatosEmpresa()
            GenerarNumeroNotaCredito()
        End Sub
        Private Sub HabilitadoNuevo()

            rbPtoEmision001.Enabled = False
            rbPtoEmision002.Enabled = False
            rbPruebas.Enabled = False
            rbProduccion.Enabled = False
            rbTipoEmisionNormal.Enabled = False
            rbTipoEmisionIndisponibilidadSistema.Enabled = False
            'gbClienteGeneral.Enabled = True
            txtNombreComercialCliente.Enabled = True
            'gbFechaNotaCredito.Enabled = True
            txtComprobanteModificaNotaCredito.Enabled = True
            txtRazonModificacionNotaCredito.Enabled = True
            'gbValoresNotaCredito.Enabled = True
            txtSubtotal12NotaCredito.Enabled = True
            txtSubtotal0NotaCredito.Enabled = True
            txtDescuentoNotaCredito.Enabled = True
            txtSubTotalNotaCredito.Enabled = True
            txtIvaNotaCredito.Enabled = True
            txtTotalNotaCredito.Enabled = True
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnGuardarSinFirmar.Enabled = True

            dgvFacturaVenta.Enabled = True
            dgvDetalleFacturaVenta.Enabled = True
        End Sub
        Private Sub GenerarNumeroNotaCredito()
            Select Case _secuencialNotaCredito.Length
                Case 1 : _secuencialNotaCredito = "00000000" + _secuencialNotaCredito.ToString
                Case 2 : _secuencialNotaCredito = "0000000" + _secuencialNotaCredito.ToString
                Case 3 : _secuencialNotaCredito = "000000" + _secuencialNotaCredito.ToString
                Case 4 : _secuencialNotaCredito = "00000" + _secuencialNotaCredito.ToString
                Case 5 : _secuencialNotaCredito = "0000" + _secuencialNotaCredito.ToString
                Case 6 : _secuencialNotaCredito = "000" + _secuencialNotaCredito.ToString
                Case 7 : _secuencialNotaCredito = "00" + _secuencialNotaCredito.ToString
                Case 8 : _secuencialNotaCredito = "0" + _secuencialNotaCredito.ToString
                Case 9 : _numeroNotaCredito = _establecimientoNotaCredito.ToString + "-" + _ptoEmisionNotaCredito.ToString + "-" + _secuencialNotaCredito.ToString
            End Select
            lblNumeroSecuencialNotaCredito.Text = _secuencialNotaCredito
            _numeroNotaCredito = _establecimientoNotaCredito.ToString + _ptoEmisionNotaCredito.ToString + _secuencialNotaCredito.ToString
        End Sub
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            CargarDatosCliente()
            CargarFacturasVentaXIdCliente()
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)

                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
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
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos cliente." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarFacturasVentaXIdCliente()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaImpagasGeneralXIdCliente(_tipoCon, lblIdClienteGeneral.Text)
                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "ID E"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).Visible = False
                dgvFacturaVenta.Columns(2).HeaderText = "NÚMERO"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).HeaderText = "FECHA EMISIÓN"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).HeaderText = "GUIA REMISIÓN"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).Visible = False
                dgvFacturaVenta.Columns(5).HeaderText = "CLIENTE"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).Visible = False
                dgvFacturaVenta.Columns(6).HeaderText = "TIPO PAGO"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(6).Visible = False
                dgvFacturaVenta.Columns(7).HeaderText = "OBSERVACIONES"
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(8).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(9).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(10).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(11).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(12).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(13).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(14).HeaderText = "EST"
                dgvFacturaVenta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.Columns(7).Width = 150
                dgvFacturaVenta.ReadOnly = True
            Catch
                dgvFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Then Return
            If dgvFacturaVenta.CurrentRow Is Nothing Then Return

            Try
                Dim ptoEmisionFactura = ""

                If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdFacturaVenta.Text = "..."
                Else
                    If _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells(0).Value) = 0 Then
                        'MsgBox("ESTA FACTUARA YA HA SIDO CANCELADA" & vbNewLine & "NO SE PUEDE REGISTRAR NOTA DE CRÉDITO", MsgBoxStyle.Information, "Mensaje de información")
                        KryptonMessageBox.Show("Esta factura ya ha sido cancelada" & vbNewLine & "NO SE PUEDE REGISTRAR NOTA DE CRÉDITO", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else

                        If dgvFacturaVenta.CurrentRow.Cells.Item(14).Value = 1 Then
                            ptoEmisionFactura = "001"
                        ElseIf dgvFacturaVenta.CurrentRow.Cells.Item(14).Value = 2 Then
                            ptoEmisionFactura = "002"
                        End If

                        lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells(0).Value
                        lblTipoPagoFacturaCompra.Text = dgvFacturaVenta.CurrentRow.Cells(6).Value
                        Select Case dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.Length
                            Case 1 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-00000000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 2 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-0000000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 3 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-000000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 4 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-00000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 5 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-0000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 6 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-000" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 7 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-00" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 8 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-0" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                            Case 9 : lblNumeroFacturaVenta.Text = "001-" + ptoEmisionFactura + "-" + dgvFacturaVenta.CurrentRow.Cells.Item(2).Value.ToString
                        End Select
                        txtComprobanteModificaNotaCredito.Text = lblNumeroFacturaVenta.Text
                        lblFechaEmisionFacturaVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(3).Value, "dd/MM/yyyy")
                        txtSubtotal12.Text = dgvFacturaVenta.CurrentRow.Cells.Item(8).Value
                        txtSubtotal0.Text = dgvFacturaVenta.CurrentRow.Cells.Item(9).Value
                        txtDescuento.Text = dgvFacturaVenta.CurrentRow.Cells.Item(10).Value
                        txtSubtotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(11).Value
                        txtIva.Text = dgvFacturaVenta.CurrentRow.Cells.Item(12).Value
                        txtTotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(13).Value

                        CargarDetalleFacturaVentasXidFactura()
                    End If
                End If
            Catch ex As Exception
                'MsgBox("CELL_CLICK FACTURA VENTA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("CELL_CLICK factura venta." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarDetalleFacturaVentasXidFactura()
            dgvDetalleFacturaVenta.DataSource = _objetoDetalleFacturaVenta.SeleccionarDetalleFacturaDescripcionXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
            dgvDetalleFacturaVenta.AutoResizeColumns()
            dgvDetalleFacturaVenta.AutoResizeRows()
            dgvDetalleFacturaVenta.Columns(2).Width = 330
        End Sub
        Private Sub LimpiarParametros()
            lblIdClienteGeneral.Text = "..."
            lblRucClienteGenral.Text = ""
            lblLlevaContabilidadClienteGeneral.Text = "..."
            txtNombreComercialCliente.Text = ""

            lblFechaEmisionFacturaVenta.Text = "00/00/0000"
            txtSubtotal12.Text = "0.00"
            txtSubtotal0.Text = "0.00"
            txtDescuento.Text = "0.00"
            txtSubtotal.Text = "0.00"
            txtIva.Text = "0.00"
            txtTotal.Text = "0.00"
            dgvFacturaVenta.DataSource = Nothing
            dgvDetalleFacturaVenta.DataSource = Nothing
        End Sub
        Private Sub CalcularTotalesNota()
            Dim descuento As Decimal = 0.0
            Dim subtotal As Decimal = 0.0
            Dim subtotal2 As Decimal = 0.0
            Dim subtotal0 As Decimal = 0.0
            Dim subTotal12 As Decimal = 0.0
            Dim iva As Decimal = 0.0
            Dim total As Decimal = 0.0

            For i = 0 To dgvDetalleFacturaVenta.RowCount - 1
                If dgvDetalleFacturaVenta.Rows(i).Cells(3).Value <> Nothing And dgvDetalleFacturaVenta.Rows(i).Cells(4).Value <> Nothing Then
                    If dgvDetalleFacturaVenta.Rows(i).Cells(3).Value <> 0 And dgvDetalleFacturaVenta.Rows(i).Cells(4).Value <> 0 Then
                        descuento += CDec(dgvDetalleFacturaVenta.Rows(i).Cells(5).Value)
                        subtotal0 = 0
                        subTotal12 += (CDec(dgvDetalleFacturaVenta.Rows(i).Cells(6).Value) + CDec(dgvDetalleFacturaVenta.Rows(i).Cells(5).Value))
                        subtotal = (subTotal12 + subtotal0) - descuento
                        subtotal2 = subTotal12 + subtotal0
                        iva = Math.Round(((subTotal12 - descuento) * (_porcentajeIva / 100)), 2, MidpointRounding.ToEven)
                        total = subtotal + iva
                        txtSubtotal0NotaCredito.Text = subtotal0
                        txtSubtotal12NotaCredito.Text = subTotal12
                        txtDescuentoNotaCredito.Text = descuento
                        txtSubTotalNotaCredito.Text = subtotal2
                        txtIvaNotaCredito.Text = iva
                        txtTotalNotaCredito.Text = total
                    End If
                End If
            Next
        End Sub


        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            DeshabilitadoInicio()
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
        Private Sub rbPtoEmision001_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPtoEmision001.CheckedChanged
            If rbPtoEmision001.Checked = True Then
                _ptoEmisionNotaCredito = "001"
                lblPtoEmisionFacturaEmpresa.Text = "001"
            Else
                _ptoEmisionNotaCredito = "002"
                lblPtoEmisionFacturaEmpresa.Text = "002"
            End If
        End Sub
        Private Sub rbPtoEmision002_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPtoEmision002.CheckedChanged
            If rbPtoEmision002.Checked = True Then
                _ptoEmisionNotaCredito = "002"
                lblPtoEmisionFacturaEmpresa.Text = "002"
            Else
                _ptoEmisionNotaCredito = "001"
                lblPtoEmisionFacturaEmpresa.Text = "001"
            End If
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellEndEdit
            dgvDetalleFacturaVenta.Rows(e.RowIndex).ErrorText = String.Empty
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellValidated
            If dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "VALOR_U" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "CANT" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "DSCTO" Then
                CalcularTotalesNota()
            End If
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalleFacturaVenta.CellValidating
            If dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "VALOR_U" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "CANT" Or dgvDetalleFacturaVenta.Columns(e.ColumnIndex).Name = "DSCTO" Then
                If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then
                    Return
                End If
            End If
        End Sub
        Private Sub dgvDetalleFacturaVenta_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFacturaVenta.CellValueChanged
            Try
                Dim cantidad = If(dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value.ToString().Trim().Length = 0, 0, CDec(dgvDetalleFacturaVenta.CurrentRow.Cells(3).Value))
                Dim valorUnitario = If(dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value.ToString().Trim().Length = 0, 0, CDec(dgvDetalleFacturaVenta.CurrentRow.Cells(4).Value))
                Dim valorDescuento = If(dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value.ToString().Trim().Length = 0, 0, CDec(dgvDetalleFacturaVenta.CurrentRow.Cells(5).Value))
                Dim valorTotal = (cantidad * valorUnitario) - valorDescuento  ' calcula el valor total del item
                dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = valorTotal ' asigna el valor a la casilla
            Catch
                If dgvDetalleFacturaVenta.CurrentRow Is Nothing Then Return
                If dgvDetalleFacturaVenta.CurrentRow.IsNewRow Then Return
                dgvDetalleFacturaVenta.CurrentRow.Cells(6).Value = "0.00"
            End Try
        End Sub
        Private Sub dgvDetalleFacturaVenta_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleFacturaVenta.EditingControlShowing
            Dim itemName As TextBox = TryCast(e.Control, TextBox)
            If itemName IsNot Nothing Then
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
        Private Sub btnGuardarSinFirmar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarSinFirmar.Click
            If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LA NOTA DE CRÉDITO?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            _sqlCommands.Clear()

            GenerarNumeroNotaCredito()

            'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
            _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("04", dtpFechaEmisionNotaCredito.Value, _rucEmpresa, _tipoAmbiente, _establecimientoNotaCredito, _ptoEmisionNotaCredito, _secuencialNotaCredito, _tipoEmision)

            If _claveAcceso.ToString.Length = 49 Then
                If lblIdFacturaVenta.Text <> "..." Then
                    If _numeroNotaCredito <> "" And txtTotalNotaCredito.Text <> "0.00" And txtComprobanteModificaNotaCredito.Text <> "" And txtRazonModificacionNotaCredito.Text <> "" Then
                        If txtTotalNotaCredito.Text > _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, lblIdFacturaVenta.Text) Then
                            MsgBox("EL VALOR DE LA NOTA DE CREDITO ES MAYOR AL SALDO DE LA FACTURA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        Else

                            GuardarNotaCredito()

                            If _ptoEmisionNotaCredito = "002" Then ActualizarSecuencial()

                            GuardarRegistroPagosFacturaVenta()

                            _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                            ' numero registro asiento
                            With _objetoNumeroRegistro
                                .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                                .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                            End With
                            _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())


                            NuevoRegistroAsientoDiarioVenta()

                            NuevoRegistroAsientoDiarioIva()

                            NuevoRegistroAsientoDiarioCxc()



                            Dim nombreU As String = "Registro de nota de Credito por: " & UserName
                            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                            If res(0) Then
                                If _ptoEmisionNotaCredito = "002" Then ExportarXml() ' exporta la factura electónica a formato XML
                                DeshabilitadoInicio()
                            End If

                            Dim messageIcon As KryptonMessageBoxIcon
                            If res(0) Then
                                messageIcon = KryptonMessageBoxIcon.Information
                            Else
                                messageIcon = KryptonMessageBoxIcon.Exclamation
                            End If
                            KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)
                            'MsgBox(If(res(0), res(1) & vbNewLine & "XML GENERADO CORRECTAMENTE" & If(resx, " - XML GUARDADO", " - XML NO GUARDADO!"), res(1)), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                        End If
                    Else
                        MsgBox("NO HA LLENADO TODOS LOS PARAMETROS NECESARIOS PARA GUARDAR.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("No ha llenado todos los parametros necesarios para guardar.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If

                Else
                    'MsgBox("NO HA SELECCIONADO UNA FACTURA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No ha seleccionado una factura.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            Else
                'MsgBox("CLAVE DE ACCESO INVALIDA")
                KryptonMessageBox.Show("Clave de acceso invalida", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If

        End Sub
        Private Sub ActualizarSecuencial()
            With _objetoInformacionTributaria
                .Id = 1
                .SecuencialNotaCredito = _secuencialNotaCredito
            End With
            _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialNotaCreditoInformacionTributaria)
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
        Private Sub GuardarNotaCredito()
            With _objetoNotaCredito
                .IdNotaCredito = .BuscarMayorIdNotaCreditoVenta(_tipoCon) + 1
                .IdClienteGeneral = lblIdClienteGeneral.Text
                .NumeroNotaCredito = _numeroNotaCredito
                .NumAutoSriNotaCredito = lblNroAutoSRIEmpresa.Text
                .FechaAutoSriNotaCredito = dtpFechaEmisionNotaCredito.Value
                .FechaEmisionNotaCredito = dtpFechaEmisionNotaCredito.Value
                .NumDocModificacionNotaCredito = txtComprobanteModificaNotaCredito.Text
                .RazonModificacionNotaCredito = txtRazonModificacionNotaCredito.Text.TrimEnd
                .Subtotal12NotaCredito = txtSubtotal12NotaCredito.Text
                .Subtotal0NotaCredito = txtSubtotal0NotaCredito.Text
                .SubtotalNotaCredito = txtSubTotalNotaCredito.Text
                .PorcentajeIvaNotaCredito = _porcentajeIva
                .IvaNotaCredito = txtIvaNotaCredito.Text
                .TotalNotaCredito = txtTotalNotaCredito.Text
                .EstadoNotaCredito = 1 'recibe el estado al guardar según sea 'nuevo' o 'anular'
                .IdFactura = lblIdFacturaVenta.Text
            End With
            _sqlCommands.Add(_objetoNotaCredito.NuevoRegistroNotaCreditoVenta)

            _objAuditoria.AccionAuditoria = "SE GUARDO UNA NUEVA NOTA DE CRÉDITO DEL CLIENTE: " + CStr(txtNombreComercialCliente.Text) _
                                           + " FECHA: " + CStr(dtpFechaEmisionNotaCredito.Value) + " NUMERO NOTA CRÉDITO: " + CStr(_numeroNotaCredito) + " TOTAL: " + CStr(txtTotalNotaCredito.Text)
            _objAuditoria.FormularioAuditoria = Text.Trim.ToUpper
            Auditoria()
        End Sub
        Private Sub GuardarRegistroPagosFacturaVenta()
            With _objetoPagosFacturaVenta
                .IdPagoFactura = .BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
                .FechaPagoFactura = dtpFechaEmisionNotaCredito.Value
                .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text) + 1
                .FormaPagoFactura = "NOTA DE CRÉDITO"
                .MontoPagoFactura = txtTotalNotaCredito.Text
                If txtTotal.Text = txtTotalNotaCredito.Text Then
                    .SaldoPagoFactura = (CDec(_objetoComprobanteRetencionCompraVenta.BuscarTotalComprobanteRetencionVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)) + CDec(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, lblIdFacturaVenta.Text))) - CDec(txtTotalNotaCredito.Text)
                Else
                    .SaldoPagoFactura = CDec(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)) - CDec(txtTotalNotaCredito.Text)
                End If
                .EstadoPagoFactura = 1
                .IdFactura = lblIdFacturaVenta.Text
                .IdCliente = lblIdClienteGeneral.Text
                .IdComprobanteIngreso = _objetoNotaCredito.IdNotaCredito
            End With
            _sqlCommands.Add(_objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta)
        End Sub

        Private Sub NuevoRegistroAsientoDiarioVenta() ' Registra en el diario la venta
            _varIdAsiento = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionNotaCredito.Value
                .CodigoCuentaAsiento = "41020109"
                .NombreCuentaAsiento = "DEVOLUCIONES EN VENTAS"
                .ConceptoAsiento = "NOTA DE CREDITO"
                .DetalleTransaccionAsiento = "ID NC: " & _objetoNotaCredito.IdNotaCredito & " CLIENTE: " & txtNombreComercialCliente.Text.ToString & " NOTA CREDITO NRO: " + _numeroNotaCredito.ToString + "FACTURA MODIFICA: " + lblNumeroFacturaVenta.Text.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = CDec(txtSubTotalNotaCredito.Text)
                .ValorHaberAsiento = 0
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
                '.NuevoRegistroAsientoLibroDiario(_tipoCon)
            End With
            _varIdAsiento += 1
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
        End Sub
        Private Sub NuevoRegistroAsientoDiarioIva() ' Registra en el diario el iva de la venta
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionNotaCredito.Value
                .CodigoCuentaAsiento = "20107010206"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "20107010206")
                .ConceptoAsiento = "IVA COBRADO POR VENTA"
                .DetalleTransaccionAsiento = "ID NC: " + _objetoNotaCredito.IdNotaCredito.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " NOTA CREDITO NRO: " + _numeroNotaCredito.ToString + "FACTURA MODIFICA: " + lblNumeroFacturaVenta.Text.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = CType(txtIvaNotaCredito.Text, Decimal)
                .ValorHaberAsiento = 0
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
                '.NuevoRegistroAsientoLibroDiario(_tipoCon)
            End With
            _varIdAsiento += 1
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
        End Sub
        Private Sub NuevoRegistroAsientoDiarioCxc()
            With _objetoAsientoLibroDiario
                .IdAsiento = _varIdAsiento
                .FechaAsiento = dtpFechaEmisionNotaCredito.Value
                .CodigoCuentaAsiento = "1010205"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "1010205")
                .ConceptoAsiento = "DOCUMENTOS Y CUENTAS POR COBRAR CLIENTES"
                .DetalleTransaccionAsiento = "ID NC: " + _objetoNotaCredito.IdNotaCredito.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " NOTA CREDITO NRO: " + _numeroNotaCredito.ToString + "FACTURA MODIFICA: " + lblNumeroFacturaVenta.Text.ToString
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "MACHALA"
                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                .ValorDebeAsiento = 0
                .ValorHaberAsiento = CDec(txtTotalNotaCredito.Text)
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
                '.NuevoRegistroAsientoLibroDiario(_tipoCon)
            End With
            GuardarNumeroRegistroAsientoxNotaCredito()

            _varIdAsiento += 1
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
        End Sub
        Private Sub GuardarNumeroRegistroAsientoxNotaCredito() 'Tabla intermedia para enlazar en el diario las facturas de venta con la retenciones cuando esta se nos emitan
            With _objetoNumeroRegistroAsientoNotaCredito
                .IdNotaCredito = _objetoNotaCredito.IdNotaCredito
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _varIdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoNotaCredito.NuevoRegistroNumeroRegistroAsientoNotaCredito)
        End Sub

        Public RutaDocsElec As String
        Private Sub ExportarXml()
            Try
                Dim ruta As String
                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\NOTA CREDITO " & _numeroNotaCredito & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\NOTA CREDITO " & _numeroNotaCredito & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\NOTA CREDITO " & _numeroNotaCredito & ".xml"
                End Select
                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine                 
                xml += "<notaCredito id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine  ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresa & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresa & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresa & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine
                xml += "<codDoc>04</codDoc>" & vbNewLine  ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoNotaCredito & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionNotaCredito & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialNotaCredito & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoNotaCredito>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA NOTA DE CREDITO -=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpFechaEmisionNotaCredito.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresa & "</dirEstablecimiento>" & vbNewLine
                xml += "<contribuyenteEspecial>" & nres & "</contribuyenteEspecial>" & vbNewLine
                xml += "<tipoIdentificacionComprador>" & _tipoIdentificacionCliente & "</tipoIdentificacionComprador>" & vbNewLine
                xml += "<razonSocialComprador>" & txtNombreComercialCliente.Text & "</razonSocialComprador>" & vbNewLine
                xml += "<identificacionComprador>" & lblRucClienteGenral.Text & "</identificacionComprador>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<codDocModificado>01</codDocModificado>" & vbNewLine
                xml += "<numDocModificado>" & lblNumeroFacturaVenta.Text & "</numDocModificado>" & vbNewLine
                xml += "<fechaEmisionDocSustento>" & lblFechaEmisionFacturaVenta.Text & "</fechaEmisionDocSustento>" & vbNewLine
                xml += "<totalSinImpuestos>" & Math.Round(CDec(txtSubtotal12NotaCredito.Text), 2, MidpointRounding.ToEven) & "</totalSinImpuestos>" & vbNewLine
                xml += "<valorModificacion>" & Math.Round(CDec(txtTotalNotaCredito.Text), 2, MidpointRounding.ToEven) & "</valorModificacion>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                xml += "<totalConImpuestos>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine      ' IVA => 2 / ICE => 3 / IRBPNR => 5

                If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                xml += "<baseImponible>" & Math.Round(CDec(txtSubtotal12NotaCredito.Text), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                xml += "<valor>" & Math.Round(CDec(txtIvaNotaCredito.Text), 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<motivo>" & txtRazonModificacionNotaCredito.Text.ToString & "</motivo>" & vbNewLine
                xml += "</infoNotaCredito>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<detalles>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA -=-=-=-=-=-=-=-=-=-=
                If dgvDetalleFacturaVenta.Rows.Count > 0 Then
                    For indiceDetalle = 0 To dgvDetalleFacturaVenta.Rows.Count - 1
                        xml += "<detalle>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigoInterno>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(1).Value & "</codigoInterno>" & vbNewLine
                        xml += "<descripcion>" & _objetoSecuencialItem.BuscarNombreSecuencialItemXIdSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(1).Value) & "</descripcion>" & vbNewLine
                        xml += "<cantidad>" & dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(3).Value & "</cantidad>" & vbNewLine
                        xml += "<precioUnitario>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(4).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                        xml += "<descuento>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</descuento>" & vbNewLine
                        xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                        xml += "<impuestos>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<impuesto>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "<codigo>2</codigo>" & vbNewLine      ' IVA => 2 / ICE => 3 / IRBPNR => 5

                        If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                        If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                        xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                        xml += "<baseImponible>" & Math.Round(CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                        Dim valorIvaDetalle = (CDec(dgvDetalleFacturaVenta.Rows(indiceDetalle).Cells(6).Value) * _porcentajeIva) / 100
                        xml += "<valor>" & Math.Round(valorIvaDetalle, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</impuestos>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        xml += "</detalle>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                End If
                xml += "</detalles>" & vbNewLine      ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=     
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'> </campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</notaCredito>" & vbNewLine

                ' GUARDAR COMPROBANTE ELECTRONICO 
                _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
                _objetoComprobantesElectronicos.IdDocumento = _objetoNotaCredito.IdNotaCredito
                _objetoComprobantesElectronicos.Tipo = "NOTA DE CREDITO"
                _objetoComprobantesElectronicos.Documento = xml
                _objetoComprobantesElectronicos.FechaEmision = _objetoNotaCredito.FechaEmisionNotaCredito
                _objetoComprobantesElectronicos.NumDocumento = _objetoNotaCredito.NumeroNotaCredito
                resx = _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

            Catch ex As Exception
                resx = False
                'MsgBox("ERROR AL GENERAR NOTA DE CRÉDITO ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Information, "Mensaje de información.")
                KryptonMessageBox.Show("Error al generar nota de crédito electrónica" & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub


    End Class
End Namespace