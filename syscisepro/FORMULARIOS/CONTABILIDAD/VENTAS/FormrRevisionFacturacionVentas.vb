Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormrRevisionFacturacionVentas
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

        ReadOnly _objetoFacturasVentas As New ClassFacturaVenta
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoDetalleComprobantesRetencionVenta As New ClassDetalleComprobantesRetencionVenta
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta

        Private _idComprobanteRetencionVenta As Int64
        Dim _fechaInicial As Date
        Dim _fechaFinal As Date
        Dim _fechaInicialAnte As Date
        Dim _fechaInicialAnte2 As Date
        Dim _fechaInicialAnte3 As Date
        Dim _fechaInicialAnte4 As Date
        Dim _fechaInicialAnte5 As Date

        Dim _fechaFinalAnte As Date
        Dim _fechaFinalAnte2 As Date
        Dim _fechaFinalAnte3 As Date
        Dim _fechaFinalAnte4 As Date
        Dim _fechaFinalAnte5 As Date

        Private Sub CargarFacturasMesActual()
            Try
                dgvRevisionFacturacion.DataSource = _objetoFacturasVentas.SeleccionarFacturasVentaRevisionXRangoFechas(_tipoCon, _fechaInicial, _fechaFinal, _fechaInicialAnte, _fechaFinalAnte)
                dgvRevisionFacturacion.ReadOnly = False

                For indiceCol = 1 To dgvRevisionFacturacion.ColumnCount - 1
                    dgvRevisionFacturacion.Columns(indiceCol).ReadOnly = True
                    If indiceCol > 4 And indiceCol < 11 Then dgvRevisionFacturacion.Columns(indiceCol).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Next
                dgvRevisionFacturacion.Columns(2).Width = 285
                dgvRevisionFacturacion.Columns(4).Width = 80
                dgvRevisionFacturacion.Columns(7).Width = 80
                dgvRevisionFacturacion.Columns(11).Width = 300
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURAS VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub CargarComprobanteRetencionVenta()
            Try
                dgvComprobanteRetencionVenta.DataSource = _objetoComprobanteRetencionCompraVenta.SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
                dgvComprobanteRetencionVenta.AutoResizeColumns()
                dgvComprobanteRetencionVenta.AutoResizeRows()
                dgvComprobanteRetencionVenta.ReadOnly = False
                dgvComprobanteRetencionVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR COMPROBANTE DE RETENCIÓN VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub CargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencionVenta.DataSource = _objetoDetalleComprobantesRetencionVenta.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion(_tipoCon, _idComprobanteRetencionVenta)
                dgvDetalleComprobanteRetencionVenta.AutoResizeColumns()
                dgvDetalleComprobanteRetencionVenta.AutoResizeRows()
                dgvDetalleComprobanteRetencionVenta.ReadOnly = False
                dgvDetalleComprobanteRetencionVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub CargarDatosFactura()
            If dgvRevisionFacturacion.RowCount = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then
                Return
            End If
            Try
                If dgvRevisionFacturacion.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdFacturaVenta.Text = "..."
                Else

                    lblIdFacturaVenta.Text = _objetoFacturasVentas.BuscarIdFacturaVentaXNumeroFacturaVenta(_tipoCon, dgvRevisionFacturacion.CurrentRow.Cells.Item(3).Value)
                    txtRazonSocialClienteGeneral.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(2).Value
                    lblNumeroFacturaVenta.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(3).Value
                    lblFechaComprobanteCompra.Text = Format(dgvRevisionFacturacion.CurrentRow.Cells.Item(4).Value, "dd/MM/yyyy")
                    txtSubtotal12.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(5).Value
                    txtSubtotal0.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(6).Value
                    txtDescuento.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(7).Value
                    txtSubtotal.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(8).Value
                    txtIva.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(9).Value
                    txtTotal.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(10).Value

                    dgvRevisionFacturacion.Rows(dgvRevisionFacturacion.CurrentCell.RowIndex.ToString()).Selected = True

                    If txtTotal.Text > 0 Then CargarComprobanteRetencionVenta()
                    If dgvComprobanteRetencionVenta.RowCount > 0 Then
                        _idComprobanteRetencionVenta = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(0).Value
                        lblNumeroComprobanteRetencion.Text = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(2).Value
                        lblFechaComprobanteRetencion.Text = Format(dgvComprobanteRetencionVenta.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy")
                        txtTotalComprobanteRetencion.Text = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(7).Value
                    Else
                        _idComprobanteRetencionVenta = 0
                        lblNumeroComprobanteRetencion.Text = "0"
                        lblFechaComprobanteRetencion.Text = "00/00/0000"
                        txtTotalComprobanteRetencion.Text = "0,00"
                    End If

                    CargarDetalleComprobanteRetencion()
                    If dgvDetalleComprobanteRetencionVenta.RowCount > 0 Then
                        For indiceDetalle = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                            If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalle).Cells.Item(4).Value = "RENTA" Then
                                txtValorRetencionFuente.Text = dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalle).Cells.Item(6).Value
                            End If
                            If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalle).Cells.Item(4).Value = "IVA" Then
                                txtValorRetencionIVA.Text = dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalle).Cells.Item(6).Value
                            End If
                        Next
                    Else
                        txtValorRetencionFuente.Text = "0,00"
                        txtValorRetencionIVA.Text = "0,00"
                    End If
                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS FACTURA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ValidarFacturacion()
            Dim validarFacturacion = 0
            For indiceFactura = 0 To dgvRevisionFacturacion.RowCount - 1
                If dgvRevisionFacturacion.Rows(indiceFactura).Cells(10).Value > 0 Then
                    dgvRevisionFacturacion.Rows(indiceFactura).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                    validarFacturacion = 1
                Else
                    dgvRevisionFacturacion.Rows(indiceFactura).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next
            If validarFacturacion = 1 Then
                MsgBox("HAY FACTURAS POR APROBAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                MsgBox("NO HAY FACTURAS POR APROBAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End If
        End Sub

        Private Sub ValidarFechas()

            Dim mesActual = Date.Now.Month
            Dim añoActual = Date.Now.Year
            Dim añoAnterior = añoActual - 1
            Dim mesAnterior = mesActual - 1
            Dim mesAnterior2 = mesActual - 2
            Dim mesAnterior3 = mesActual - 3
            Dim mesAnterior4 = mesActual - 4
            Dim mesAnterior5 = mesActual - 5

            Select Case mesActual
                Case 1 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "ENERO :"
                    _fechaInicialAnte = "01-12-" + añoAnterior.ToString : _fechaFinalAnte = "31-12-" + añoAnterior.ToString : lblMesAnte.Text = "DICIEMBRE :"
                    _fechaInicialAnte2 = "01-11-" + añoAnterior.ToString : _fechaFinalAnte2 = "30-11-" + añoAnterior.ToString : lblMesAnte2.Text = "NOVIEMBRE :"
                    _fechaInicialAnte3 = "01-10-" + añoAnterior.ToString : _fechaFinalAnte3 = "31-10-" + añoAnterior.ToString : lblMesAnte3.Text = "OCTUBRE :"
                    _fechaInicialAnte4 = "01-09-" + añoAnterior.ToString : _fechaFinalAnte4 = "30-09-" + añoAnterior.ToString : lblMesAnte4.Text = "SEPTIEMBRE :"
                    _fechaInicialAnte5 = "01-08-" + añoAnterior.ToString : _fechaFinalAnte5 = "31-08-" + añoAnterior.ToString : lblMesActual.Text = "AGOSTO :"

                Case 2 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "28-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "FEBRERO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "ENERO :"
                    _fechaInicialAnte2 = "01-12-" + añoAnterior.ToString : _fechaFinalAnte2 = "31-12-" + añoAnterior.ToString : lblMesAnte2.Text = "DICIEMBRE :"
                    _fechaInicialAnte3 = "01-11-" + añoAnterior.ToString : _fechaFinalAnte3 = "30-11-" + añoAnterior.ToString : lblMesAnte3.Text = "NOVIEMBRE :"
                    _fechaInicialAnte4 = "01-10-" + añoAnterior.ToString : _fechaFinalAnte4 = "31-10-" + añoAnterior.ToString : lblMesAnte4.Text = "OCTUBRE :"
                    _fechaInicialAnte5 = "01-09-" + añoAnterior.ToString : _fechaFinalAnte5 = "30-09-" + añoAnterior.ToString : lblMesAnte5.Text = "SEPTIEMBRE :"

                Case 3 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "MARZO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "28-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "FEBRERO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "31-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "ENERO :"
                    _fechaInicialAnte3 = "01-12-" + añoAnterior.ToString : _fechaFinalAnte3 = "31-12-" + añoAnterior.ToString : lblMesAnte3.Text = "DICIEMBRE :"
                    _fechaInicialAnte4 = "01-11-" + añoAnterior.ToString : _fechaFinalAnte4 = "30-11-" + añoAnterior.ToString : lblMesAnte4.Text = "NOVIEMBRE :"
                    _fechaInicialAnte5 = "01-10-" + añoAnterior.ToString : _fechaFinalAnte5 = "31-10-" + añoAnterior.ToString : lblMesAnte5.Text = "OCTUBRE :"

                Case 4 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "30-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "ABRIL :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "MARZO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "28-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "FEBRERO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "ENERO :"
                    _fechaInicialAnte4 = "01-12-" + añoAnterior.ToString : _fechaFinalAnte4 = "31-12-" + añoAnterior.ToString : lblMesAnte4.Text = "DICIEMBRE :"
                    _fechaInicialAnte5 = "01-11-" + añoAnterior.ToString : _fechaFinalAnte5 = "30-11-" + añoAnterior.ToString : lblMesAnte5.Text = "NOVIEMBRE :"

                Case 5 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "MAYO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "30-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "ABRIL :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "31-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "MARZO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "28-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "FEBRERO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "31-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "ENERO :"
                    _fechaInicialAnte5 = "01-12-" + añoAnterior.ToString : _fechaFinalAnte5 = "31-12-" + añoAnterior.ToString : lblMesAnte5.Text = "DICIEMBRE :"

                Case 6 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "30-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "JUNIO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "MAYO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "30-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "ABRIL :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "MARZO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "28-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "FEBRERO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "31-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "ENERO :"

                Case 7 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "JULIO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "30-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "JUNIO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "31-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "MAYO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "30-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "ABRIL :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "31-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "MARZO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "28-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "FEBRERO :"

                Case 8 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "AGOSTO :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "JULIO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "30-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "JUNIO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "MAYO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "30-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "ABRIL :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "31-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "MARZO :"

                Case 9 : _fechaInicial = "01-0" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "30-0" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "SEPTIEMBRE :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "AGOSTO :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "31-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "JULIO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "30-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "JUNIO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "31-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "MAYO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "30-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "ABRIL :"

                Case 10 : _fechaInicial = "01-" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "OCTUBRE :"
                    _fechaInicialAnte = "01-0" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "30-0" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "SEPTIEMBRE :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "31-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "AGOSTO :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "JULIO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "30-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "JUNIO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "31-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "MAYO :"

                Case 11 : _fechaInicial = "01-" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "30-" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "NOVIEMBRE :"
                    _fechaInicialAnte = "01-" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "OCTUBRE :"
                    _fechaInicialAnte2 = "01-0" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "30-0" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "SEPTIEMBRE :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "AGOSTO :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "31-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "JULIO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte5 = "30-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "JUNIO :"

                Case 12 : _fechaInicial = "01-" + mesActual.ToString + "-" + añoActual.ToString : _fechaFinal = "31-" + mesActual.ToString + "-" + añoActual.ToString : lblMesActual.Text = "DICIEMBRE :"
                    _fechaInicialAnte = "01-" + mesAnterior.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "30-" + mesAnterior.ToString + "-" + añoActual.ToString : lblMesAnte.Text = "NOVIEMBRE :"
                    _fechaInicialAnte2 = "01-" + mesAnterior2.ToString + "-" + añoActual.ToString : _fechaFinalAnte = "31-" + mesAnterior2.ToString + "-" + añoActual.ToString : lblMesAnte2.Text = "OCTUBRE :"
                    _fechaInicialAnte3 = "01-0" + mesAnterior3.ToString + "-" + añoActual.ToString : _fechaFinalAnte2 = "30-0" + mesAnterior3.ToString + "-" + añoActual.ToString : lblMesAnte3.Text = "SEPTIEMBRE :"
                    _fechaInicialAnte4 = "01-0" + mesAnterior4.ToString + "-" + añoActual.ToString : _fechaFinalAnte3 = "31-0" + mesAnterior4.ToString + "-" + añoActual.ToString : lblMesAnte4.Text = "AGOSTO :"
                    _fechaInicialAnte5 = "01-0" + mesAnterior5.ToString + "-" + añoActual.ToString : _fechaFinalAnte4 = "31-0" + mesAnterior5.ToString + "-" + añoActual.ToString : lblMesAnte5.Text = "JULIO :"

            End Select
            _fechaInicial = _fechaInicial + " 00:00:00.001"
            _fechaInicialAnte = _fechaInicialAnte + " 00:00:00.001"
            _fechaInicialAnte2 = _fechaInicialAnte2 + " 00:00:00.001"
            _fechaInicialAnte3 = _fechaInicialAnte3 + " 00:00:00.001"
            _fechaInicialAnte4 = _fechaInicialAnte4 + " 00:00:00.001"
            _fechaInicialAnte5 = _fechaInicialAnte5 + " 00:00:00.001"
            _fechaFinal = _fechaFinal + " 23:59:59.000"
            _fechaFinalAnte = _fechaFinalAnte + " 23:59:59.000"
            _fechaFinalAnte2 = _fechaFinalAnte2 + " 23:59:59.000"
            _fechaFinalAnte3 = _fechaFinalAnte3 + " 23:59:59.000"
            _fechaFinalAnte4 = _fechaFinalAnte4 + " 23:59:59.000"
            _fechaFinalAnte5 = _fechaFinalAnte5 + " 23:59:59.000"
        End Sub

        Private Sub CargarTotalesFacturacion()
            Try
                txtTotalFacturadoMesActual.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicial, _fechaFinal)
                txtTotalFacturadoMesAnte.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicialAnte, _fechaFinalAnte)
                txtTotalFacturadoMesAnte2.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicialAnte2, _fechaFinalAnte2)
                txtTotalFacturadoMesAnte3.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicialAnte3, _fechaFinalAnte3)
                txtTotalFacturadoMesAnte4.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicialAnte4, _fechaFinalAnte4)
                txtTotalFacturadoMesAnte5.Text = _objetoFacturasVentas.BuscarTotalFacturaVentaXRangoFechas(_tipoCon, _fechaInicialAnte5, _fechaFinalAnte5)
            Catch ex As Exception
                MsgBox("CARGAR TOTALES FACUTRACION." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)
            Try
                Dim mExcel As New Excel.Application
                mExcel.Cursor = Excel.XlMousePointer.xlWait
                mExcel.Visible = True
                Dim objLibroExcel As Excel.Workbook = mExcel.Workbooks.Add
                Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
                With objHojaExcel
                    .Visible = Excel.XlSheetVisibility.xlSheetVisible
                    .Activate()
                    'Encabezado  
                    .Range("A1:L1").Merge()
                    .Range("A1:L1").Value = ValidationForms.NombreCompany(_tipoCon)
                    .Range("A1:L1").Font.Bold = True
                    .Range("A1:L1").Font.Size = 15

                    'Copete  
                    .Range("A2:L2").Merge()
                    .Range("A2:L2").Value = titulo
                    .Range("A2:L2").Font.Bold = True
                    .Range("A2:L2").Font.Size = 12

                    Const primeraLetra As Char = "A"
                    Const primerNumero As Short = 3
                    Dim Letra As Char, UltimaLetra As Char
                    Dim Numero As Integer, UltimoNumero As Integer
                    Dim cod_letra As Byte = Asc(primeraLetra) - 1
                    Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                    Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
                    'Establecer formatos de las columnas de la hija de cálculo  
                    Dim strColumna As String = ""
                    Dim LetraIzq As String = ""
                    Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
                    Letra = primeraLetra
                    Numero = primerNumero
                    Dim objCelda As Excel.Range
                    For Each c As DataGridViewColumn In dataGridViewExp.Columns
                        If c.Visible Then
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                cod_LetraIzq += 1
                                LetraIzq = Chr(cod_LetraIzq)
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                            strColumna = LetraIzq + Letra + Numero.ToString
                            objCelda = .Range(strColumna, Type.Missing)
                            objCelda.Value = c.HeaderText
                            objCelda.EntireColumn.Font.Size = 8
                            'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                            If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                                objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                            End If
                        End If
                    Next

                    Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
                    objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                    UltimaLetra = Letra
                    Dim UltimaLetraIzq As String = LetraIzq

                    'CARGA DE DATOS  
                    Dim i As Integer = Numero + 1

                    For Each reg As DataGridViewRow In dataGridViewExp.Rows
                        LetraIzq = ""
                        cod_LetraIzq = Asc(primeraLetra) - 1
                        Letra = primeraLetra
                        cod_letra = Asc(primeraLetra) - 1
                        For Each c As DataGridViewColumn In dataGridViewExp.Columns
                            If c.Visible Then
                                If Letra = "Z" Then
                                    Letra = primeraLetra
                                    cod_letra = Asc(primeraLetra)
                                    cod_LetraIzq += 1
                                    LetraIzq = Chr(cod_LetraIzq)
                                Else
                                    cod_letra += 1
                                    Letra = Chr(cod_letra)
                                End If
                                strColumna = LetraIzq + Letra
                                ' acá debería realizarse la carga  
                                .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                                '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                                '.Range(strColumna + i, strColumna + i).In()  

                            End If
                        Next
                        Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                        objRangoReg.Rows.BorderAround()
                        objRangoReg.Select()
                        i += 1
                    Next
                    UltimoNumero = i

                    'Dibujar las líneas de las columnas  
                    LetraIzq = ""
                    cod_LetraIzq = Asc("A")
                    cod_letra = Asc(primeraLetra)
                    Letra = primeraLetra
                    For Each c As DataGridViewColumn In dataGridViewExp.Columns
                        If c.Visible Then
                            objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                            objCelda.BorderAround()
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                LetraIzq = Chr(cod_LetraIzq)
                                cod_LetraIzq += 1
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                        End If
                    Next

                    'Dibujar el border exterior grueso  
                    Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
                    objRango.Select()
                    objRango.Columns.AutoFit()
                    objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                End With

                mExcel.Cursor = Excel.XlMousePointer.xlDefault
            Catch ex As Exception
                MsgBox("EXPORTAR REVISIÓN DE FACTURACIÓN." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try            
        End Sub

        Private Sub FormrRevisionFacturacionVentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRevisionFacturacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    dgvRevisionFacturacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    dgvRevisionFacturacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)

            btnExportar.Enabled = False ' deshabilita el boton
            btnFacturacion.Enabled = False ' deshabilita el boton 
            btnExportar.Enabled = True ' habilita el boton 
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvRevisionFacturacion.Rows.Count = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then Return
            ExportarDatosExcel(dgvRevisionFacturacion, "REVISIÓN DE FACTURACIÓN") ' exporta la facturacion  
        End Sub

        Private Sub btnFacturacion_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFacturacion.Click
            Dim f = New FormFacturaVenta
            f.TipoCox = TipoCox
            f.Show()
        End Sub

        Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAprovar.Click
            If dgvRevisionFacturacion.Rows.Count = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then Return

            Try
                _sqlCommands.Clear()

                btnAprovar.Enabled = False
                For i = 0 To dgvRevisionFacturacion.Rows.Count - 1
                    If dgvRevisionFacturacion.Rows(i).Cells(0).Value = True Then
                        With _objetoFacturasVentas
                            .IdFactura = dgvRevisionFacturacion.Rows(i).Cells(1).Value
                            .EstadoFactura = 4
                        End With
                        _sqlCommands.Add(_objetoFacturasVentas.ActualizarEstadoFacturaVenta)
                    End If
                Next

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    CargarFacturasMesActual()
                    btnAprovar.Enabled = True
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                MsgBox("APROBAR FACTURAS VENTA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub btnMarcarTodo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMarcarTodo.Click
            If dgvRevisionFacturacion.Rows.Count = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then Return
            Try
                btnMarcarTodo.Enabled = False 'deshabilita el boton mietras se marcan los checks
                For indiceVentas = 0 To dgvRevisionFacturacion.Rows.Count - 1
                    If dgvRevisionFacturacion.Rows(indiceVentas).Cells(0).Value = False And dgvRevisionFacturacion.Rows(indiceVentas).Cells(1).Value <> 0 Then ' pregusta si la casilla no esta marcada y si es factura valida
                        dgvRevisionFacturacion.Rows(indiceVentas).Cells(0).Value = True  ' marca la casilla check
                    End If
                Next
                btnMarcarTodo.Enabled = True ' vuelve a habilitar el boton
            Catch ex As Exception
                MsgBox("MARCAR TODAS LAS FACTURAS VENTA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub btnDesmarcarTodo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDesmarcarTodo.Click
            If dgvRevisionFacturacion.Rows.Count = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then Return
            Try
                btnDesmarcarTodo.Enabled = False 'deshaiulita el boton mietras se marcan los checks
                For indiceVentas = 0 To dgvRevisionFacturacion.Rows.Count - 1
                    If dgvRevisionFacturacion.Rows(indiceVentas).Cells(0).Value = True Then ' pregusta si la casilla esta marcada
                        dgvRevisionFacturacion.Rows(indiceVentas).Cells(0).Value = False ' desmarca la casilla check
                    End If
                Next
                btnDesmarcarTodo.Enabled = True
            Catch ex As Exception
                MsgBox("DESMARCAR TODAS LAS FACTURAS VENTA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub dgvRevisionFacturacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRevisionFacturacion.CellDoubleClick
            Try
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                If dgvRevisionFacturacion.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdFacturaVenta.Text = "..."
                Else
                    lblIdFacturaVenta.Text = dgvRevisionFacturacion.CurrentRow.Cells.Item(1).Value

                    formAsientoDiario.numeroRegsitroBusqueda = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            ValidarFechas()
            CargarFacturasMesActual()
            CargarTotalesFacturacion()
            ValidarFacturacion()
            btnExportar.Enabled = True
        End Sub

        Private Sub dgvRevisionFacturacion_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvRevisionFacturacion.SelectionChanged
            If dgvRevisionFacturacion.RowCount = 0 Or dgvRevisionFacturacion.CurrentRow Is Nothing Then Return
            CargarDatosFactura()
        End Sub

    End Class
End Namespace