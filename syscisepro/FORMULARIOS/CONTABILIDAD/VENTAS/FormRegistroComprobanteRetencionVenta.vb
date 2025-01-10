Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.FORMULARIOS.CONTABILIDAD.PORCENTAJES_RETENCION
Imports Krypton.Toolkit


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRegistroComprobanteRetencionVenta
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
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoDetalleComprobantesRetencionVenta As New ClassDetalleComprobantesRetencionVenta
        ReadOnly _objetoDetalleRetencionPlanCuentas As New ClassDetalleRetencionPlanCuentas
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoAts As New ClassAnexoTransaccional
        ReadOnly _objetoImpuestos As New ClassImpuestos
        ReadOnly _objetoConceptos As New ClassConceptosPago
        ReadOnly _objetoPorcentajes As New ClassPorcentajes
        ReadOnly _objetoContribuyente As New ClassContribuyenteRetenido
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto

        Dim _validarRenta As Integer = 0

        Dim _busacarNumeroFactura As Integer = 0 ' para difereciar al cargar datos de grilla

        Private Sub FormRegistroComprobanteRetencionVenta_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencionVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencionVenta.Font = New Font("Roboto", 8, FontStyle.Regular)

            _sqlCommands = New List(Of SqlCommand)
            cmbBienServicio.SelectedIndex = 0
            DeshabilitadoInicio()
            AutocompletarNombreCliente()

            _busacarNumeroFactura = 0 ' 0 => carga grilla por cliente / 1 => carga grilla por numero factura
            txtNombreComercialCliente.Focus()
        End Sub
        Private Sub DeshabilitadoInicio()
            'gbClienteGeneral.Enabled = True
            txtNombreComercialCliente.Enabled = True
            'gbBuscarFactura.Enabled = True
            txtNumeroFacturaBuscar.Enabled = True
            'gbFacturaVenta.Enabled = True
            'gbRetencion.Enabled = False
            txtNumAutoSRIComprobanteRetencion.Enabled = False
            txtNumeroComprobanteRetencion.Enabled = False
            dtpComprobanteRetencion.Enabled = False
            cmbImpuesto.Enabled = False
            cmbConcepto.Enabled = False
            cmbContribuyente.Enabled = False
            cmbBienServicio.Enabled = False
            btnAgregarImpuesto.Enabled = False
            btnEliminarImpuesto.Enabled = False
            dgvDetalleComprobanteRetencionVenta.Enabled = False
            btnNuevo.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
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
        Private Sub LlenarComboImpuesto()
            Try
                Dim data = _objetoImpuestos.SeleccionarRegistrosImpuestos(_tipoCon)
                cmbImpuesto.DataSource = data
                cmbImpuesto.DisplayMember = data.Columns(1).ToString
                cmbImpuesto.ValueMember = data.Columns(0).ToString
                If (CType(cmbImpuesto.DataSource, DataTable).Rows.Count > 0) Then cmbImpuesto.SelectedIndex = 0
            Catch
                cmbImpuesto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboConcepto()
            Try
                Dim data = _objetoConceptos.SeleccionarRegistrosConceptosOrdenado(_tipoCon)
                cmbConcepto.DataSource = data
                cmbConcepto.DisplayMember = data.Columns(2).ToString
                cmbConcepto.ValueMember = data.Columns(0).ToString
                If (CType(cmbConcepto.DataSource, DataTable).Rows.Count > 0) Then cmbConcepto.SelectedIndex = 0
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboContribuyente()
            Try
                Dim data = _objetoContribuyente.SeleccionarRegistrosContribuyentes(_tipoCon)
                cmbContribuyente.DataSource = data
                cmbContribuyente.DisplayMember = data.Columns(1).ToString
                cmbContribuyente.ValueMember = data.Columns(0).ToString
                If (CType(cmbContribuyente.DataSource, DataTable).Rows.Count > 0) Then cmbContribuyente.SelectedIndex = 0
            Catch
                cmbContribuyente.DataSource = Nothing
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            If dgvFacturaVenta.RowCount = 0 Then
                'MsgBox("POR FAVOR SELECCIONE UNA FACTURA!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Por favor seleccione una factura!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            If dgvComprobanteRetencionVenta.RowCount > 0 Then
                'MsgBox("LA FACTURA SELECCIONADA YA TIENE REGISTRADO UN COMPROBANTE DE RETENCIÓN!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("La factura seleccionada ya tiene registrado un comprobante de retención!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            HabilitadoNuevo()

            LlenarComboImpuesto()
            LlenarComboConcepto()
            LlenarComboContribuyente()

            _busacarNumeroFactura = 0 ' 0 => carga grilla por cliente / 1 => carga grilla por numero factura
        End Sub
        Private Sub HabilitadoNuevo()
            'gbClienteGeneral.Enabled = False
            txtNombreComercialCliente.Enabled = False
            'gbBuscarFactura.Enabled = False
            txtNumeroFacturaBuscar.Enabled = False
            'gbFacturaVenta.Enabled = False
            'gbRetencion.Enabled = True
            txtNumAutoSRIComprobanteRetencion.Enabled = True
            txtNumeroComprobanteRetencion.Enabled = True
            dtpComprobanteRetencion.Enabled = True
            cmbImpuesto.Enabled = True
            cmbConcepto.Enabled = True
            cmbContribuyente.Enabled = True
            cmbBienServicio.Enabled = True
            btnAgregarImpuesto.Enabled = True
            btnEliminarImpuesto.Enabled = True
            dgvDetalleComprobanteRetencionVenta.Enabled = True
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
        End Sub
        Private Sub LimpiarParametros()
            lblIdClienteGeneral.Text = "..."
            lblRucClienteGenral.Text = ""
            lblLlevaContabilidadClienteGeneral.Text = "..."
            lblContribuyenteEspecial.Text = "..."
            txtNombreComercialCliente.Text = ""
            'lblNroRetencion.Text = "0"
            lblIdFacturaVenta.Text = "..." 'clear
            lblTipoPagoFacturaCompra.Text = "..." 'clear
            lblFechaEmisionVenta.Text = "00/00/0000" 'clear
            txtSubtotal12.Text = "0.00" 'clear
            txtSubtotal0.Text = "0.00" ' clear
            txtDescuento.Text = "0.00" ' clear
            txtSubtotal.Text = "0.00" 'clear
            txtIva.Text = "0.00" '
            txtTotal.Text = "0.00"
            txtNumAutoSRIComprobanteRetencion.Text = ""
            txtNumeroComprobanteRetencion.Text = ""
            txtTotalComprobanteRetencion.Text = "0.00"
            lblNumeroFacturaVenta.Text = ""
            If dgvFacturaVenta.DataSource IsNot Nothing Then
                dgvFacturaVenta.DataSource = Nothing
            Else
                dgvFacturaVenta.Rows.Clear()
            End If
            dgvComprobanteRetencionVenta.DataSource = Nothing
            txtNumeroFacturaBuscar.Clear()
            dgvDetalleComprobanteRetencionVenta.Rows.Clear()

            _validarRenta = 0
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)
                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
                    lblContribuyenteEspecial.Text = cli.Rows(0)(6)
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar datos del cliente!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarFacturasVentaXIdCliente()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaImpagasGeneralXIdCliente(_tipoCon, lblIdClienteGeneral.Text)
                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "ID E"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).HeaderText = "NÚMERO"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).HeaderText = "FECHA EMISIÓN"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).HeaderText = "GUIA REMISIÓN"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).HeaderText = "ID CLI"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(6).HeaderText = "TIPO PAGO"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
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
            Catch ex As Exception
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar facturas de venta!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarFacturasVentaXNroFactura()
            Try
                dgvFacturaVenta.DataSource = Nothing
                dgvComprobanteRetencionVenta.DataSource = Nothing

                If txtNumeroFacturaBuscar.Text.Trim().Length = 0 Then Return
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "FACTURA"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).HeaderText = "FECHA"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).HeaderText = "RUC"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).HeaderText = "CLIENTE"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(6).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(7).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(8).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).HeaderText = "EST"
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar facturas de venta!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarComprobanteRetencionVenta()
            Try
                dgvComprobanteRetencionVenta.DataSource = _objetoComprobanteRetencionCompraVenta.SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
                dgvComprobanteRetencionVenta.Columns(0).HeaderText = "ID"
                'dgvComprobanteRetencionVenta.Columns(0).Width = 50
                dgvComprobanteRetencionVenta.Columns(1).Visible = False
                dgvComprobanteRetencionVenta.Columns(2).HeaderText = "N° RET."
                'dgvComprobanteRetencionVenta.Columns(2).Width = 100
                dgvComprobanteRetencionVenta.Columns(3).HeaderText = "N° AUT."
                'dgvComprobanteRetencionVenta.Columns(3).Width = 90
                dgvComprobanteRetencionVenta.Columns(4).HeaderText = "FECHA"
                'dgvComprobanteRetencionVenta.Columns(4).Width = 90
                dgvComprobanteRetencionVenta.Columns(5).HeaderText = "TIPO"
                'dgvComprobanteRetencionVenta.Columns(5).Width = 80
                dgvComprobanteRetencionVenta.Columns(6).HeaderText = "N° FAC."
                'dgvComprobanteRetencionVenta.Columns(6).Width = 80
                dgvComprobanteRetencionVenta.Columns(7).HeaderText = "TOTAL"
                'dgvComprobanteRetencionVenta.Columns(7).Width = 80
                dgvComprobanteRetencionVenta.Columns(8).Visible = False
                dgvComprobanteRetencionVenta.Columns(9).Visible = False
                dgvComprobanteRetencionVenta.AutoResizeColumns()
            Catch
                dgvComprobanteRetencionVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CalcularTotalRetencion()
            Dim acumulador As Decimal = 0
            Try
                For i = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                    acumulador += CDec(dgvDetalleComprobanteRetencionVenta.Rows(i).Cells(5).Value)
                Next
                txtTotalComprobanteRetencion.Text = acumulador
            Catch ex As Exception
                txtTotalComprobanteRetencion.Text = acumulador
            End Try
        End Sub
        Private Function ValidacionParametros() As Boolean
            Return txtNombreComercialCliente.Text <> "" And lblIdClienteGeneral.Text <> "..." And lblIdFacturaVenta.Text <> "..." _
               And txtNumAutoSRIComprobanteRetencion.Text <> "" And txtNumeroComprobanteRetencion.Text <> "" _
               And txtTotalComprobanteRetencion.Text <> "0.00" And txtTotalComprobanteRetencion.Text <> "" And dgvDetalleComprobanteRetencionVenta.RowCount > 0
        End Function
        Private Function ValidacionValores() As Boolean
            Dim totalRetencion As Decimal = 0
            For indiceRetencion = 0 To dgvDetalleComprobanteRetencionVenta.Rows.Count - 1
                totalRetencion += CDec(dgvDetalleComprobanteRetencionVenta.Rows(indiceRetencion).Cells("ValorRetenido").Value)
            Next
            If CDec(txtTotalComprobanteRetencion.Text) = totalRetencion Then
                Return True
            Else
                'MsgBox("LA SUMA DE LOS DETALLES DE LA RETENCION NO COINCIDE CON EL TOTAL.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("La suma de los detalles de la retención no coincide con el total.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return False
            End If
        End Function
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            DeshabilitadoInicio()
            _busacarNumeroFactura = 0 ' 0 => carga grilla por cliente / 1 => carga grilla por numero factura
            txtNombreComercialCliente.Focus()
        End Sub
        Private Sub txtNumeroFacturaBuscar_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroFacturaBuscar.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            txtNombreComercialCliente.Clear()
            btnBuscarAsiento_Click(Nothing, Nothing)
        End Sub
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            txtNumeroFacturaBuscar.Clear()
            CargarDatosCliente()
            If lblLlevaContabilidadClienteGeneral.Text = "SI" Then
                CargarFacturasVentaXIdCliente()
                _busacarNumeroFactura = 0
            ElseIf lblLlevaContabilidadClienteGeneral.Text = "NO" Then
                'MsgBox("NO SE REGISTRAN RETENCIONES DE CLIENTES QUE NO LLEVAN CONTABILIDAD", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No se registran retenciones de clientes que no llevan contabilidad", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            txtNombreComercialCliente.Clear()
            CargarFacturasVentaXNroFactura()
            _busacarNumeroFactura = 1 ' 0 => carga grilla por cliente / 1 => carga grilla por numero factura
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Then Return
            If dgvFacturaVenta.CurrentRow Is Nothing Then Return
            If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                If _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells.Item(0).Value) = 0 Then
                    'MsgBox("ESTA FACTUARA YA HA SIDO CANCELADA" & vbNewLine & "NO SE PUEDE REGISTRAR RETENCIÓN", MsgBoxStyle.Information, "Mensaje de información")
                    KryptonMessageBox.Show("Esta factura ya ha sido cancelada" & vbNewLine & "No se puede registrar retención", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    If _busacarNumeroFactura = 0 Then
                        lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                        lblTipoPagoFacturaCompra.Text = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                        lblNumeroFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(2).Value
                        lblFechaEmisionVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(3).Value, "dd/MM/yyyy")
                        dtpComprobanteRetencion.MinDate = lblFechaEmisionVenta.Text ' Establece como fecha minima del comprobante de retención la de el comprobante de compra
                        dtpComprobanteRetencion.Value = lblFechaEmisionVenta.Text ' Establece como fecha del comprobante de retención la de el comprobante de compra
                        txtSubtotal12.Text = dgvFacturaVenta.CurrentRow.Cells.Item(8).Value
                        lblSubtotalIva.Text = "Subtotal " + dgvFacturaVenta.CurrentRow.Cells.Item(15).Value.ToString() + "%"
                        txtSubtotal0.Text = dgvFacturaVenta.CurrentRow.Cells.Item(9).Value
                        txtDescuento.Text = dgvFacturaVenta.CurrentRow.Cells.Item(10).Value
                        txtSubtotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(11).Value
                        txtIva.Text = dgvFacturaVenta.CurrentRow.Cells.Item(12).Value
                        lblIva.Text = "IVA " + dgvFacturaVenta.CurrentRow.Cells.Item(15).Value.ToString() + "%"
                        txtTotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(13).Value

                    Else
                        lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                        lblTipoPagoFacturaCompra.Text = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                        lblNumeroFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(1).Value
                        lblFechaEmisionVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(2).Value, "dd/MM/yyyy")
                        dtpComprobanteRetencion.MinDate = lblFechaEmisionVenta.Text ' Establece como fecha minima del comprobante de retención la de el comprobante de compra
                        dtpComprobanteRetencion.Value = lblFechaEmisionVenta.Text ' Establece como fecha del comprobante de retención la de el comprobante de compra
                        txtSubtotal12.Text = dgvFacturaVenta.CurrentRow.Cells.Item(5).Value
                        txtSubtotal0.Text = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                        txtDescuento.Text = dgvFacturaVenta.CurrentRow.Cells.Item(7).Value
                        txtSubtotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(8).Value
                        txtIva.Text = dgvFacturaVenta.CurrentRow.Cells.Item(9).Value
                        txtTotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(10).Value
                    End If
                    CargarComprobanteRetencionVenta()
                End If
            End If
        End Sub

        Private Sub btnAgregarImpuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarImpuesto.Click
            If txtSubtotal12.Text <> "" And txtIva.Text <> "" And txtTotal.Text <> "" Then '-=-=-=-=-= SI LOS DATOS DE FACTURA NO ESTAN VACIOS =-=-=-=-=-
                If CInt(cmbImpuesto.SelectedValue) <> 0 And CInt(cmbConcepto.SelectedValue) <> 0 And CInt(cmbContribuyente.SelectedValue) <> 0 Then '-=-=-=-=-= SI HA SELECCIONADO VALORES EN LOS COMBOS =-=-=-=-=-

                    If CInt(cmbImpuesto.SelectedValue) = 1 Then '-=-=-=-=-= SI ES RENTA =-=-=-=-=- dgvDetalleComprobanteRetencionVenta
                        Dim porret = _objetoPorcentajes.BuscarCantidadPorcentajesRenta(_tipoCon, CInt(cmbConcepto.SelectedValue), CInt(cmbContribuyente.SelectedValue), False)
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If

                        'Dim response = InputBox("INGRESE LA BASE IMPONIBLE", "COMPROBANTE RETENCIÓN", CDec(txtSubtotal.Text))
                        Dim response = KryptonInputBox.Show("Ingrese la base imponible", "Comprobante de retención", CDec(txtSubtotal.Text).ToString())
                        If IsNumeric(response) Then
                            If _validarRenta = 1 Then
                                Dim valorRetenido0 = (CDec(response) * porcent) / 100
                                dgvDetalleComprobanteRetencionVenta.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valorRetenido0, 2, MidpointRounding.ToEven), cod, cue)
                                _validarRenta = 1
                            Else
                                Dim valorRetenido12 = (CDec(response) * porcent) / 100
                                dgvDetalleComprobanteRetencionVenta.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valorRetenido12, 2, MidpointRounding.ToEven), cod, cue)
                                _validarRenta = 1
                            End If
                        Else
                            'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "El separador decimal es el '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    ElseIf CInt(cmbImpuesto.SelectedValue) = 2 Then ''-=-=-=-=-= SI ES IVA =-=-=-=-=-

                        Dim porret As DataTable
                        If lblContribuyenteEspecial.Text.Equals("SI") And CInt(cmbContribuyente.SelectedValue) <> 4 Then
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, 5, cmbBienServicio.SelectedIndex, False)
                        Else
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, CInt(cmbContribuyente.SelectedValue), cmbBienServicio.SelectedIndex, False)
                        End If
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If

                        Dim response = InputBox("INGRESE LA BASE IMPONIBLE", "COMPROBANTE RETENCIÓN", CDec(txtIva.Text))
                        If IsNumeric(response) Then
                            Dim valorRetenidoIva = Math.Round((CDec(response) * porcent) / 100, 3, MidpointRounding.AwayFromZero)
                            dgvDetalleComprobanteRetencionVenta.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valorRetenidoIva, 2, MidpointRounding.ToEven), cod, cue)
                        Else
                            'MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "Mensaje de validación")
                            KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "El separador decimal es el '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If

                    End If

                    CalcularTotalRetencion()
                Else
                    'MsgBox("SELECCIONE LOS PARAMETROS NECESARIOS: IMPUESTO, CONCEPTO, CONTRIBUYENTE.", MsgBoxStyle.Information, "Mensaje de información")
                    KryptonMessageBox.Show("Seleccione los parametros necesarios: Impuesto, Concepto, Contribuyente.", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            Else
                'MsgBox("NO HA INGRESADO DATOS DE FACTURA.", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("No ha ingresado datos de factura.", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        End Sub

        Private Sub btnEliminarImpuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminarImpuesto.Click
            If dgvDetalleComprobanteRetencionVenta.RowCount = 0 Then
                'MsgBox("NO HAY CELDAS EN LA GRILLA", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("No hay celdas en la grilla", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                If dgvDetalleComprobanteRetencionVenta.CurrentRow.Cells(3).Value = "RENTA" Then
                    dgvDetalleComprobanteRetencionVenta.Rows.RemoveAt(dgvDetalleComprobanteRetencionVenta.CurrentRow.Index)
                    _validarRenta = 0
                ElseIf dgvDetalleComprobanteRetencionVenta.CurrentRow.Cells(3).Value = "IVA" Then
                    dgvDetalleComprobanteRetencionVenta.Rows.RemoveAt(dgvDetalleComprobanteRetencionVenta.CurrentRow.Index)
                End If
            End If
            CalcularTotalRetencion()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpComprobanteRetencion.Value) Then ' si el ats del mes del comprobante ya fue generado
                'MsgBox("EL ATS DEL MES " & dtpComprobanteRetencion.Value.Month.ToString & " DEL AÑO " & dtpComprobanteRetencion.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA INGRESAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("El ATS del mes " & dtpComprobanteRetencion.Value.Month.ToString & " del año " & dtpComprobanteRetencion.Value.Year.ToString & " ya fue generado." & vbNewLine & " Si necesita ingresar este comprobante solicite una sustutiva a la contadora y haga una requisición al departamento de sistemas.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            Else
                If ValidacionParametros() Then
                    If ValidacionValores() Then
                        If Math.Round(CDec(txtTotalComprobanteRetencion.Text), 2) <= _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, lblIdFacturaVenta.Text) Then ' si el valor de la retención es menor o igual al saldo de la factura guarda

                            'If MessageBox.Show("¿Esta seguro que desea guardar EL COMPRONATE DE RETENCIÓN?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                            If KryptonMessageBox.Show("¿Esta seguro que desea guardar EL COMPRONATE DE RETENCIÓN?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                            _sqlCommands.Clear()

                            GuardarComprobanteRetencion()
                            GuardarDetalleComprobanteRetencion()

                            NuevoRegistroAsientoDiarioRetencion()
                            If (_objetoAsientoLibroDiario.CodigoCuentaAsiento + "").Trim().Length = 0 Then
                                'MsgBox("No se puede guardar." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "La cuenta para el código de retención escogido no ha sido definida en la BD!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                Return
                            End If

                            ActualizarRegistroAsientoDiarioCxc()
                            GuardarRegistroPagosFacturaVenta()


                            Dim nombreU As String = "COMPROBANTE-RETENCION " & UserName
                            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                            If res(0) Then
                                LimpiarParametros()
                                DeshabilitadoInicio()
                                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                            Else
                                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                                Return
                            End If
                        Else
                            'MsgBox("No se puede guardar." & vbNewLine & "EL VALOR DE LA RETENCIÓN ES MAYOR AL SALDO DE LA FACTURA", MsgBoxStyle.Information, "Mensaje de validación")
                            KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "El valor de la retención es mayor al saldo de la factura", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    End If
                Else
                    'MsgBox("No se puede guardar." & vbNewLine & "NO HA LLENADO TODOS LOS CAMPOS NECESARIOS", MsgBoxStyle.Information, "Mensaje de validación")
                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No ha llenado todos los campos necesarios", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
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
        Private Sub GuardarComprobanteRetencion()
            With _objetoComprobanteRetencionCompraVenta
                .IdComprobanteRetencion = .BuscarMayorIdComprobanteRetencionVenta(_tipoCon) + 1
                .IdCliente = lblIdClienteGeneral.Text
                .NumeroComprobanteRetencion = txtNumeroComprobanteRetencion.Text
                .NumAutoSriComprobanteRetencion = txtNumAutoSRIComprobanteRetencion.Text
                .FechaEmisionComprobanteRetencion = dtpComprobanteRetencion.Value
                .TipoCompVentaComprobanteRetencion = "FACTURA"
                .NumCompVentaComprobanteRetencion = lblNumeroFacturaVenta.Text
                .TotalComprobanteRetencion = txtTotalComprobanteRetencion.Text
                .EstadoComprobanteRetencion = 1
                .IdFacturaVenta = lblIdFacturaVenta.Text
            End With
            _sqlCommands.Add(_objetoComprobanteRetencionCompraVenta.NuevoRegistroComprobanteRetencionVenta)

            _objAuditoria.AccionAuditoria = "POR VENTA SE GUARDO UN NUEVO COMPROBANTE DE RETENCIÓN CON Nº: " + CStr(txtNumeroComprobanteRetencion.Text) _
                                           + " FECHA: " + CStr(dtpComprobanteRetencion.Value) + " TOTAL: " + CStr(txtTotalComprobanteRetencion.Text)
            _objAuditoria.FormularioAuditoria = Text.Trim.ToUpper
            Auditoria()
        End Sub
        Private Sub GuardarDetalleComprobanteRetencion()
            Dim i = _objetoDetalleComprobantesRetencionVenta.BuscarMayorIdDetalleComprobanteRetencionVenta(_tipoCon) + 1
            Dim idr = _objetoDetalleRetencionPlanCuentas.BuscarMayorIdRegistroDetalleRetencionPlanCuenta(_tipoCon) + 1


            For x = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                With _objetoDetalleComprobantesRetencionVenta
                    .IdDetalleComprobanteRetencion = i
                    .EjFiscalDetalleComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(0).Value
                    .CodigoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(1).Value
                    .BaseImponibleDetalleComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(2).Value
                    .ImpuestoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(3).Value
                    .PorcentajeComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(4).Value
                    .ValorDetalleComprobanteRetencion = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(5).Value
                    .EstadoDetalleComprobanteRetencion = 1
                    .IdComprobanteRetencion = _objetoComprobanteRetencionCompraVenta.IdComprobanteRetencion
                    .IdFactura = lblIdFacturaVenta.Text
                End With
                _sqlCommands.Add(_objetoDetalleComprobantesRetencionVenta.NuevoRegistroDetalleComprobanteRetencionVenta)


                ' DETALLE RETENCION PLAN CUENTA
                With _objetoDetalleRetencionPlanCuentas
                    .IdDetalleRetencionPlanCuenta = idr
                    .IdFacturaVenta = lblIdFacturaVenta.Text
                    .IdComprobanteCompra = 0
                    .IdDetalleComprobanteRetencionVenta = i
                    .IdDetalleComprobanteRetencionCompra = 0
                    .Codigo = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(6).Value
                    .Cuenta = dgvDetalleComprobanteRetencionVenta.Rows(x).Cells(7).Value
                End With
                _sqlCommands.Add(_objetoDetalleRetencionPlanCuentas.NuevoRegistroDetalleRetencionPlanCuenta)


                i += 1
                idr += 1
            Next
        End Sub

        Private Sub NuevoRegistroAsientoDiarioRetencion()
            Dim ida = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            Dim nrg = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
            Dim idl = _objetoNumeroRegistroAsientoFacturaVenta.BuscarIdLibroDiarioPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
             
            For indiceRetencion = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                _objetoAsientoLibroDiario.CodigoCuentaAsiento = "" ' LIMPIAR AUX

                Dim codigo = dgvDetalleComprobanteRetencionVenta.Rows(indiceRetencion).Cells.Item(6).Value.ToString().Trim()
                Dim cuenta = dgvDetalleComprobanteRetencionVenta.Rows(indiceRetencion).Cells.Item(7).Value.ToString().Trim()
                If codigo.Trim().Length = 0 Or cuenta.Trim().Length = 0 Then Exit Sub

                With _objetoAsientoLibroDiario
                    .IdAsiento = ida
                    .FechaAsiento = dgvFacturaVenta.CurrentRow.Cells.Item(3).Value
                    .CodigoCuentaAsiento = codigo.Trim
                    .NombreCuentaAsiento = cuenta.Trim
                    .ConceptoAsiento = "IMPUESTO RETENIDO"
                    .DetalleTransaccionAsiento = "ID FV: " + lblIdFacturaVenta.Text.ToString + " CLIENTE: " + txtNombreComercialCliente.Text.ToString + " FACTURA NRO: " + lblNumeroFacturaVenta.Text.ToString + " MES: " + dtpComprobanteRetencion.Value.Month.ToString
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                    .ValorDebeAsiento = CDec(dgvDetalleComprobanteRetencionVenta.Rows(indiceRetencion).Cells.Item(5).Value)
                    .ValorHaberAsiento = 0
                    .NumeroRegistroAsiento = nrg
                    .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = idl
                    '.NuevoRegistroAsientoLibroDiario(_tipoCon)                    
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand)

                ida += 1 
            Next
        End Sub
        Private Sub ActualizarRegistroAsientoDiarioCxc()
            Dim valorAsiento = CDec(txtTotal.Text) - CDec(txtTotalComprobanteRetencion.Text) ' total tactura - (retenciones ya hechas + nueva retencion)

            'Dim valorAsiento = CDec(txtTotal.Text) - (CDec(_objetoPagosFacturaVenta.BuscarTotalRetencionesPagosFacturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)) + CDec(txtTotalComprobanteRetencion.Text)) ' total tactura - (retenciones ya hechas + nueva retencion)
            With _objetoAsientoLibroDiario
                .IdAsiento = _objetoNumeroRegistroAsientoFacturaVenta.BuscarIdAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                .ValorDebeAsiento = valorAsiento
                .ValorHaberAsiento = 0
                .DebeHaberAsiento = 1  ' DEBE=1 / HABER=2 
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoAsientoLibroDiario.IdLibroDiario
                '.ActualizarRegistroAsientoLibroDiario(_tipoCon)
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.ActualizarRegistroAsientoLibroDiario)
        End Sub
        Private Sub GuardarRegistroPagosFacturaVenta()
            With _objetoPagosFacturaVenta
                .IdPagoFactura = .BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
                .FechaPagoFactura = dtpComprobanteRetencion.Value
                .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text) + 1
                .FormaPagoFactura = "RETENCIÓN"
                .MontoPagoFactura = txtTotalComprobanteRetencion.Text
                .SaldoPagoFactura = CDec(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)) - CDec(txtTotalComprobanteRetencion.Text)
                .EstadoPagoFactura = 1
                .IdFactura = lblIdFacturaVenta.Text
                .IdCliente = lblIdClienteGeneral.Text
                .IdComprobanteIngreso = 0
                '.NuevoRegistroPagosFacturaVenta(_tipoCon)
            End With
            _sqlCommands.Add(_objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta)
        End Sub

        Private Sub cmbImpuesto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbImpuesto.SelectedValueChanged
            If cmbImpuesto.SelectedValue Is Nothing Or TypeOf cmbImpuesto.SelectedValue Is DataRowView Then Return
            cmbConcepto.Enabled = cmbImpuesto.SelectedValue <> 2
            cmbContribuyente.Enabled = cmbImpuesto.SelectedValue <> 2
            cmbBienServicio.Enabled = cmbImpuesto.SelectedValue <> 1
        End Sub

        Private Sub dgvDetalleComprobanteRetencionVenta_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleComprobanteRetencionVenta.CellEndEdit
            Try
                ' dialogo escoger cuenta (cod, cue)
                Dim _frmPlan = New FrmBuscarPlanCuentas()
                _frmPlan.TipoCox = _tipoCon
                _frmPlan.Tipo = 1
                _frmPlan.cbxTipoCuenta.Enabled = False
                _frmPlan.txtParametrobusqueda.Enabled = False

                If dgvDetalleComprobanteRetencionVenta(3, e.RowIndex).Value = "IVA" Then
                    _frmPlan.txtParametrobusqueda.Text = "1010501"
                Else
                    _frmPlan.txtParametrobusqueda.Text = "1010502"
                End If

                If _frmPlan.ShowDialog = DialogResult.OK Then
                    dgvDetalleComprobanteRetencionVenta(6, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(1).Text.Trim()
                    dgvDetalleComprobanteRetencionVenta(7, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(2).Text.Trim()
                Else
                    dgvDetalleComprobanteRetencionVenta(6, e.RowIndex).Value = String.Empty
                    dgvDetalleComprobanteRetencionVenta(7, e.RowIndex).Value = String.Empty
                End If

                Dim bi = dgvDetalleComprobanteRetencionVenta.CurrentRow.Cells(2).Value
                Dim pr = dgvDetalleComprobanteRetencionVenta.CurrentRow.Cells(4).Value
                dgvDetalleComprobanteRetencionVenta(5, e.RowIndex).Value = (CDec(bi) * (CDec(pr) / 100))
            Catch
                dgvDetalleComprobanteRetencionVenta(4, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencionVenta(5, e.RowIndex).Value = 0
                dgvDetalleComprobanteRetencionVenta(6, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencionVenta(7, e.RowIndex).Value = String.Empty
                'MsgBox("HUBO UN PROBLEMA AL CALCULAR VALOR RETENIDO, INTENTE DE NUEVO.", MsgBoxStyle.Information, "Mensaje de información")
                KryptonMessageBox.Show("Hubo un problema al calcular valor retenido, intente de nuevo.", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
            CalcularTotalRetencion()
        End Sub
    End Class
End Namespace