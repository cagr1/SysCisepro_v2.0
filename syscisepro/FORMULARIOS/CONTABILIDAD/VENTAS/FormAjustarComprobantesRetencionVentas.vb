Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS
Imports Krypton.Toolkit


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAjustarComprobantesRetencionVentas
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
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoDetalleComprobantesRetencionVenta As New ClassDetalleComprobantesRetencionVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral

        ReadOnly _objetoImpuestos As New ClassImpuestos
        ReadOnly _objetoConceptos As New ClassConceptosPago
        ReadOnly _objetoPorcentajes As New ClassPorcentajes
        ReadOnly _objetoContribuyente As New ClassContribuyenteRetenido


        Private Sub FormAjustarComprobantesRetencionVentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            dtpMes.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            LlenarComboImpuesto()
            LlenarComboConcepto()

            AutocompletarNombreCliente()
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
        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialCliente.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialCliente.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialCliente.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            txtNumeroFacturaBuscar.Clear()
            CargarDatosCliente()
            If lblLlevaContabilidadClienteGeneral.Text = "SI" Then
                CargarFacturasVentaXIdCliente()
            ElseIf lblLlevaContabilidadClienteGeneral.Text = "NO" Then
                MsgBox("NO SE REGISTRAN RETENCIONES DE CLIENTES QUE NO LLEVAN CONTABILIDAD", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)
                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
                End If
            Catch
                lblIdClienteGeneral.Text = "..."
                lblRucClienteGenral.Text = "..."
                lblLlevaContabilidadClienteGeneral.Text = "..."
            End Try
        End Sub
        Private Sub CargarFacturasVentaXIdCliente()
            LimpiarParametrosRetencion()
            dgvPagosFacturaVenta.DataSource = Nothing
            dgvAsientoDiarioVenta.DataSource = Nothing

            Try
                Dim fechaDesde = dtpMes.Value.Day.ToString & "-" & dtpMes.Value.Month.ToString & "-" & dtpMes.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpMes.Value.AddMonths(1).AddDays(-1).Day.ToString & "-" & dtpMes.Value.Month.ToString & "-" & dtpMes.Value.Year.ToString & " 23:59:59.000"

                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXIdClienteFecha(_tipoCon, lblIdClienteGeneral.Text, fechaDesde, fechaHasta)
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
                dgvFacturaVenta.ReadOnly = True
                dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvFacturaVenta.DataSource = Nothing
                dgvComprobanteRetencion.DataSource = Nothing
                dgvDetalleComprobanteRetencion.DataSource = Nothing
                dgvPagosFacturaVenta.DataSource = Nothing
                dgvAsientoDiarioVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub LimpiarParametrosRetencion()
            lblIdComprobanteRetencion.Text = "..."
            txtNumAutoSRIComprobanteRetencion.Text = ""
            txtNumeroComprobanteRetencion.Text = ""
            txtBaseImponible.Text = "0.00"
            txtPorcentajeRetencion.Text = "0"
            txtValorRetencion.Text = "0.00"
            txtTotalComprobanteRetencion.Text = "0.00"
            dgvComprobanteRetencion.DataSource = Nothing
            dgvDetalleComprobanteRetencion.DataSource = Nothing
        End Sub
        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMes.ValueChanged
            CargarFacturasVentaXIdCliente()
        End Sub
        Private Sub txtNumeroFacturaBuscar_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroFacturaBuscar.KeyUp
            If e.KeyValue <> 13 Then Return
            txtNombreComercialCliente.Clear()
            CargarFacturasVentaXNroFactura()
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            CargarFacturasVentaXNroFactura()
        End Sub
        Private Sub CargarFacturasVentaXNroFactura()
            LimpiarParametrosRetencion()
            dgvPagosFacturaVenta.DataSource = Nothing
            dgvAsientoDiarioVenta.DataSource = Nothing

            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
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
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(12).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(13).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(14).HeaderText = "EST"
                dgvFacturaVenta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.ReadOnly = True
                dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvFacturaVenta.DataSource = Nothing
                dgvComprobanteRetencion.DataSource = Nothing
                dgvDetalleComprobanteRetencion.DataSource = Nothing
                dgvPagosFacturaVenta.DataSource = Nothing
                dgvAsientoDiarioVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvFacturaVenta_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellDoubleClick
            Dim formAsientoDiario As New FormBuscarAsientoDiario
            formAsientoDiario.TipoCox = TipoCox
            If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                DialogResult = formAsientoDiario.ShowDialog
            End If
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            LimpiarParametrosRetencion()
            dgvPagosFacturaVenta.DataSource = Nothing
            dgvAsientoDiarioVenta.DataSource = Nothing

            Try
                ' VARIABLES PARA CARGAR Y MODIFICAR EL COMPROBANTE DE RETENCION
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                lblTipoPagoFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                lblNumeroFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(2).Value
                lblFechaEmisionFacturaVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(3).Value, "dd/MM/yyyy")
                lblFechaEmisionVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(3).Value, "dd/MM/yyyy")
                txtSubtotal12.Text = dgvFacturaVenta.CurrentRow.Cells.Item(8).Value
                txtSubtotal0.Text = dgvFacturaVenta.CurrentRow.Cells.Item(9).Value
                txtDescuento.Text = dgvFacturaVenta.CurrentRow.Cells.Item(10).Value
                txtSubtotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(11).Value
                txtIva.Text = dgvFacturaVenta.CurrentRow.Cells.Item(12).Value
                txtTotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(13).Value
                lblEstadoFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(14).Value

                CargarPagosFacturaVenta()
                CargarComprobanteRetencion()

                lblNumeroRegistroVenta.Text = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                dgvAsientoDiarioVenta.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroVenta.Text)
            Catch
                lblIdFacturaVenta.Text = "..."
                lblTipoPagoFacturaVenta.Text = "..."
                lblNumeroFacturaVenta.Text = "0"
                lblFechaEmisionFacturaVenta.Text = Format(dgvFacturaVenta.CurrentRow.Cells.Item(3).Value, "dd/MM/yyyy")
                lblFechaEmisionVenta.Text = "00/00/0000"
                txtSubtotal12.Text = "0.00"
                txtSubtotal0.Text = "0.00"
                txtDescuento.Text = "0.00"
                txtSubtotal.Text = "0.00"
                txtIva.Text = "0.00"
                txtTotal.Text = "0.00"
                lblNumeroRegistroVenta.Text = "0"
                LimpiarParametrosRetencion()
                dgvPagosFacturaVenta.DataSource = Nothing
                dgvAsientoDiarioVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)
            Catch
                dgvPagosFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarComprobanteRetencion()
            LimpiarParametrosRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objetoComprobanteRetencionCompraVenta.SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
                dgvComprobanteRetencion.Columns(0).HeaderText = "ID"
                dgvComprobanteRetencion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(1).HeaderText = "ID CLI"
                dgvComprobanteRetencion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(2).HeaderText = "NRO"
                dgvComprobanteRetencion.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(3).HeaderText = "NRO AUTO SRI"
                dgvComprobanteRetencion.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(4).HeaderText = "FECHA"
                dgvComprobanteRetencion.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(5).HeaderText = "TIPO COMP"
                dgvComprobanteRetencion.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(6).HeaderText = "NRO COMP"
                dgvComprobanteRetencion.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(7).HeaderText = "VALOR"
                dgvComprobanteRetencion.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(8).HeaderText = "EST"
                dgvComprobanteRetencion.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(9).HeaderText = "ID FAC"
                dgvComprobanteRetencion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.ReadOnly = True
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                dgvComprobanteRetencion.Columns(1).Visible = False
                dgvComprobanteRetencion.Columns(3).Width = 175
                dgvComprobanteRetencion.Columns(4).Width = 125
            Catch
                LimpiarParametrosRetencion()
            End Try
        End Sub
        Private Sub dgvComprobanteRetencion_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobanteRetencion.SelectionChanged
            Try
                lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.CurrentRow.Cells.Item(0).Value
                txtNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.CurrentRow.Cells.Item(2).Value
                txtNumAutoSRIComprobanteRetencion.Text = dgvComprobanteRetencion.CurrentRow.Cells.Item(3).Value
                dtpComprobanteRetencion.Value = (Format(dgvComprobanteRetencion.CurrentRow.Cells.Item(4).Value, "dd/MM/yyyy"))

                txtTotalComprobanteRetencion.Text = dgvComprobanteRetencion.CurrentRow.Cells.Item(7).Value

                CargarDetalleComprobanteRetencion()
                CalcularTotalRetencion()
            Catch
                LimpiarParametrosRetencion()
            End Try
        End Sub
        Private Sub CargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencion.DataSource = _objetoDetalleComprobantesRetencionVenta.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion(_tipoCon, lblIdComprobanteRetencion.Text)
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = False
                dgvDetalleComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvDetalleComprobanteRetencion.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvDetalleComprobanteRetencion_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvDetalleComprobanteRetencion.SelectionChanged
            Try
                cmbConcepto.SelectedValue = _objetoConceptos.BuscarIdConceptoXCodigoConcepto(TipoCox, dgvDetalleComprobanteRetencion.CurrentRow.Cells(2).Value.ToString().Trim())
                txtBaseImponible.Text = dgvDetalleComprobanteRetencion.CurrentRow.Cells(3).Value
                cmbImpuesto.SelectedValue = If(dgvDetalleComprobanteRetencion.CurrentRow.Cells(4).Value.ToString().Trim().Equals("IVA"), 2, 1)

                txtPorcentajeRetencion.Text = dgvDetalleComprobanteRetencion.CurrentRow.Cells(5).Value
                txtValorRetencion.Text = dgvDetalleComprobanteRetencion.CurrentRow.Cells(6).Value
                lblIdDetalleComprobanteRetencionCompra.Text = dgvDetalleComprobanteRetencion.CurrentRow.Cells(0).Value
                lblEstadoDetalleComprabanteRetencionCompra.Text = dgvDetalleComprobanteRetencion.CurrentRow.Cells(7).Value
            Catch
                txtBaseImponible.Text = "0.00"
                txtPorcentajeRetencion.Text = "0"
                txtValorRetencion.Text = "0.00"
                lblIdDetalleComprobanteRetencionCompra.Text = "..."
            End Try
        End Sub
        Private Sub CalcularTotalRetencion()
            Dim acumulador As Decimal = 0
            Try
                For i = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                    acumulador += CDec(dgvDetalleComprobanteRetencion.Rows(i).Cells(6).Value)
                Next
                txtTotalComprobanteRetencion.Text = acumulador
            Catch
                txtTotalComprobanteRetencion.Text = "0.00"
            End Try
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
            If dgvFacturaVenta.RowCount = 0 Then
                KryptonMessageBox.Show("DEBE ESCOGER UNA FACTURA!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If lblIdFacturaVenta.Text <> "..." And lblIdComprobanteRetencion.Text <> "..." Then
                If KryptonMessageBox.Show("SI ANULA LA RETENCIÓN DE ESTA FACTRURA SE MODIFICARÁ EL ASIENTO Y LOS PAGOS CORRESPONDIETNES, DESEA ANULARLA?", "REGISTRAR RETENCIÓN", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.Yes Then
                    _sqlCommands.Clear()

                    Dim idasientoCuenta = 0
                    Dim valorCuenta = 0.0
                    For Each row As DataGridViewRow In dgvAsientoDiarioVenta.Rows
                        If (row.Cells(2).Value.ToString().StartsWith("101020") And CDec(row.Cells(6).Value) > 0) Then
                            idasientoCuenta = row.Cells(0).Value.ToString()
                            valorCuenta = CDec(row.Cells(6).Value)
                        End If
                        If (row.Cells(2).Value.ToString().StartsWith("1010501") Or
                            row.Cells(2).Value.ToString().StartsWith("1010502")) And row.Cells(3).Value.ToString().Contains("RETEN") Then
                            With _objetoAsientoLibroDiario
                                .IdAsiento = row.Cells(0).Value.ToString().Trim()
                            End With
                            _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXIdRegistro)
                        End If
                    Next

                    ' sumar a la cuenta por cobrar
                    With _objetoAsientoLibroDiario
                        .IdAsiento = idasientoCuenta
                        .ValorDebeAsiento = valorCuenta + CDec(txtTotalComprobanteRetencion.Text.Trim())
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.SumarDebeRetencionAsientoLibroDiarioXIdRegistro)

                    ' anular retencion
                    With _objetoComprobanteRetencionCompraVenta
                        .IdFacturaVenta = lblIdFacturaVenta.Text
                    End With
                    _sqlCommands.Add(_objetoComprobanteRetencionCompraVenta.AnularComprobanteRetencionVentaByIdFactura)

                    ' anular detalle retencion
                    With _objetoDetalleComprobantesRetencionVenta
                        .IdFactura = lblIdFacturaVenta.Text
                    End With
                    _sqlCommands.Add(_objetoDetalleComprobantesRetencionVenta.AnularDetalleComprobanteRetencionVentaByIdFactura)

                    ' anular pago retencion
                    With _objetoPagosFacturaVenta
                        .IdFactura = lblIdFacturaVenta.Text
                    End With
                    _sqlCommands.Add(_objetoPagosFacturaVenta.AnularPagoRetencionFacturaVentaByIdFacturaVenta)

                    Dim nombreU As String = "ANULACION COMPROBANTES RETENCION VENTAS " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        LimpiarParametrosRetencion()
                        dgvFacturaVenta_SelectionChanged(Nothing, Nothing)
                    End If
                    Dim messageIcon As KryptonMessageBoxIcon
                    If res(0) Then
                        messageIcon = KryptonMessageBoxIcon.Information
                    Else
                        messageIcon = KryptonMessageBoxIcon.Exclamation
                    End If
                    KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
                    'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                End If
            End If
        End Sub   
    End Class
End Namespace