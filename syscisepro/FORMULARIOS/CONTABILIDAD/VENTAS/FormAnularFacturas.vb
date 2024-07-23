Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO 
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnularFacturas
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

        ReadOnly _objetoNotaCredito As New ClassNotaCredito
        ReadOnly _objetoNumeroRegistroAsientoNotaCredito As New ClassNumeroRegistroAsientoNotaCreditoVenta
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoDetalleComprobantesRetencionVenta As New ClassDetalleComprobantesRetencionVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objUser As New ClassUsuarioGeneral
        Dim _idFacturaVenta As Integer
        Dim _notSelect As List(Of Integer)

        Private Sub FormAnularFacturas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _notSelect = New List(Of Integer)
             
            AutocompletarNombreCliente()
            txtNombreComercialCliente.Focus()
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
        
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)

                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarFacturasVentaXIdCliente()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXIdCliente(_tipoCon, lblIdClienteGeneral.Text) 
                dgvFacturaVenta.Columns(0).HeaderText = "CHK"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(0).ReadOnly = False
                dgvFacturaVenta.Columns(1).HeaderText = "ID"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).ReadOnly = True
                dgvFacturaVenta.Columns(2).HeaderText = "ID E"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).ReadOnly = True
                dgvFacturaVenta.Columns(3).HeaderText = "NÚMERO"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).ReadOnly = True
                dgvFacturaVenta.Columns(4).HeaderText = "FECHA EMISIÓN"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).ReadOnly = True
                dgvFacturaVenta.Columns(5).HeaderText = "GUIA REMISIÓN"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).ReadOnly = True
                dgvFacturaVenta.Columns(6).HeaderText = "ID CLI"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(6).ReadOnly = True
                dgvFacturaVenta.Columns(7).HeaderText = "TIPO PAGO"
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(7).ReadOnly = True
                dgvFacturaVenta.Columns(8).HeaderText = "OBSERVACIONES"
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(8).ReadOnly = True
                dgvFacturaVenta.Columns(9).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).ReadOnly = True
                dgvFacturaVenta.Columns(10).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).ReadOnly = True
                dgvFacturaVenta.Columns(11).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).ReadOnly = True
                dgvFacturaVenta.Columns(12).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(12).ReadOnly = True
                dgvFacturaVenta.Columns(13).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(13).ReadOnly = True
                dgvFacturaVenta.Columns(14).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(14).ReadOnly = True
                dgvFacturaVenta.Columns(15).HeaderText = "EST"
                dgvFacturaVenta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(15).ReadOnly = True
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarFacturasVentaXNroFactura()
            Try
                If (txtNumeroFacturaBuscar.Text.Trim().Length = 0) Then Return
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
                dgvFacturaVenta.Columns(0).HeaderText = "CHK"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(0).ReadOnly = False
                dgvFacturaVenta.Columns(1).HeaderText = "ID"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).ReadOnly = True
                dgvFacturaVenta.Columns(2).HeaderText = "ID E"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).ReadOnly = True
                dgvFacturaVenta.Columns(3).HeaderText = "NÚMERO"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).ReadOnly = True
                dgvFacturaVenta.Columns(4).HeaderText = "FECHA EMISIÓN"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).ReadOnly = True
                dgvFacturaVenta.Columns(5).HeaderText = "GUIA REMISIÓN"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).ReadOnly = True
                dgvFacturaVenta.Columns(6).HeaderText = "ID CLI"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(6).ReadOnly = True
                dgvFacturaVenta.Columns(7).HeaderText = "TIPO PAGO"
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(7).ReadOnly = True
                dgvFacturaVenta.Columns(8).HeaderText = "OBSERVACIONES"
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(8).ReadOnly = True
                dgvFacturaVenta.Columns(9).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).ReadOnly = True
                dgvFacturaVenta.Columns(10).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).ReadOnly = True
                dgvFacturaVenta.Columns(11).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).ReadOnly = True
                dgvFacturaVenta.Columns(12).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(12).ReadOnly = True
                dgvFacturaVenta.Columns(13).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(13).ReadOnly = True
                dgvFacturaVenta.Columns(14).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(14).ReadOnly = True
                dgvFacturaVenta.Columns(15).HeaderText = "EST"
                dgvFacturaVenta.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(15).ReadOnly = True
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, _idFacturaVenta) 
                dgvPagosFacturaVenta.Columns(1).HeaderText = "FECHA"
                dgvPagosFacturaVenta.Columns(2).HeaderText = "NÚMERO"
                dgvPagosFacturaVenta.Columns(3).HeaderText = "FORMA"
                dgvPagosFacturaVenta.Columns(4).HeaderText = "MONTO"
                dgvPagosFacturaVenta.Columns(5).HeaderText = "SALDO"
                dgvPagosFacturaVenta.Columns(6).HeaderText = "EST"
                dgvPagosFacturaVenta.Columns(7).HeaderText = "ID FV"  
            Catch ex As Exception
                MsgBox("METODO CARGAR PAGOS FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objetoComprobanteRetencionCompraVenta.SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(_tipoCon, _idFacturaVenta)
                dgvComprobanteRetencion.ReadOnly = False
                dgvComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarDetalleComprobanteRetencion(ByVal idCompRetenciom As Integer)
            Try
                dgvDetalleComprobanteRetencion.DataSource = _objetoDetalleComprobantesRetencionVenta.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion(_tipoCon, idCompRetenciom)
                dgvDetalleComprobanteRetencion.ReadOnly = False
                dgvDetalleComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarNotaCreditoVenta(ByVal idFacturaVenta As Integer)
            Try
                dgvNotaCreditoVenta.DataSource = _objetoNotaCredito.SeleccionarNotaCreditoXIdFactura(_tipoCon, idFacturaVenta)
                dgvDetalleComprobanteRetencion.ReadOnly = False
                dgvDetalleComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                dgvNotaCreditoVenta.DataSource = Nothing
                MsgBox("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        
        Private Sub txtNombreComercialCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            txtNumeroFacturaBuscar.Clear()
            CargarDatosCliente()
            CargarFacturasVentaXIdCliente() 
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            txtNombreComercialCliente.Clear()
            lblIdClienteGeneral.Text = "..."
            lblRucClienteGenral.Text = "..."
            lblLlevaContabilidadClienteGeneral.Text = "..."
            CargarFacturasVentaXNroFactura()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Dim sel = dgvFacturaVenta.Rows.Cast(Of DataGridViewRow)().Any(Function(row) CBool(row.Cells(0).EditedFormattedValue))
            If Not sel Then
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA FACTURA!", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If MessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR LAS FACTURAS SELECCIONADAS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            _sqlCommands.Clear()

            ActualizarEstadoFacturasVenta() ' actualizar estado factura y asiento
            ActualizarPagosFacturaVenta() ' actualiza los pagos
            ActualizarEstadoRetencionVenta() 'actualizar estado retención y detalle
            ActualizarEstadoNotaCredito() ' actualizar estado notade crédito y asiento

            Dim user As String = _objUser.DatosUsuario.ToString()
            Dim nombreU As String = "FACTURA-ANULADA " & user
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then btnNuevo_Click(Nothing, Nothing)
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub ActualizarEstadoFacturasVenta()
            For i = 0 To dgvFacturaVenta.RowCount - 1
                If dgvFacturaVenta.Rows(i).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada 
                    With _objetoFacturaVenta
                        .IdFactura = dgvFacturaVenta.Rows(i).Cells(1).Value
                        .EstadoFactura = 0
                        '.ActualizarEstadoFacturaVenta(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoFacturaVenta.ActualizarEstadoFacturaVenta)

                    anularAsientoLibroDiarioFactura(dgvFacturaVenta.Rows(i).Cells(1).Value)
                End If
            Next
        End Sub 
        Private Sub AnularAsientoLibroDiarioFactura(ByVal idFactura As Int64)
            Dim numerRegistro = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, idFactura)
            With _objetoAsientoLibroDiario
                .NumeroRegistroAsiento = numerRegistro
                '.AnularAsientoLibroDiarioXNumeroRegistro(_tipoCon)
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)
        End Sub 
        Private Sub ActualizarPagosFacturaVenta()
            For i = 0 To dgvFacturaVenta.RowCount - 1
                If dgvFacturaVenta.Rows(i).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada 

                    _idFacturaVenta = dgvFacturaVenta.CurrentRow.Cells.Item(1).Value ' obtiene la factura a anular
                    CargarPagosFacturaVenta() ' carga los pagos de la factura

                    For indicePago = 0 To dgvPagosFacturaVenta.Rows.Count - 1 ' recorre los pagos para actualizarlos
                        If dgvPagosFacturaVenta.Rows(indicePago).Cells(9).Value.ToString() <> "..." And dgvPagosFacturaVenta.Rows(indicePago).Cells(9).Value.ToString() <> "0" Then
                            With _objetoPagosFacturaVenta
                                '.IdPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("ID").Value
                                '.FechaPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("FECHA").Value
                                '.NumeroPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("NUMERO").Value
                                '.FormaPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("FORMA PAGO").Value
                                '.MontoPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value
                                '.SaldoPagoFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value
                                '.EstadoPagoFactura = 0
                                '.IdFactura = dgvPagosFacturaVenta.Rows(indicePago).Cells(7).Value
                                '.IdCliente = dgvPagosFacturaVenta.Rows(indicePago).Cells(8).Value
                                .IdComprobanteIngreso = dgvPagosFacturaVenta.Rows(indicePago).Cells(9).Value
                                '.ActualizarRegistroPagosFacturaVenta(_tipoCon)
                            End With
                            _sqlCommands.Add(_objetoPagosFacturaVenta.AnularPagosFacturaVentaByIdComprobanteIngresos)
                        End If

                       
                    Next
                End If
            Next
        End Sub 
        Private Sub ActualizarEstadoRetencionVenta()
            For i = 0 To dgvFacturaVenta.RowCount - 1
                If dgvFacturaVenta.Rows(i).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada 

                    _idFacturaVenta = dgvFacturaVenta.CurrentRow.Cells.Item(1).Value ' obtiene la factura a anular
                    CargarComprobanteRetencion()

                    For indiceRetencion = 0 To dgvComprobanteRetencion.Rows.Count - 1
                        With _objetoComprobanteRetencionCompraVenta
                            .IdComprobanteRetencion = dgvComprobanteRetencion.Rows(indiceRetencion).Cells(0).Value
                            .EstadoComprobanteRetencion = 0
                            '.ActualizarEstadoComprobanteRetencionVenta(_tipoCon)
                        End With
                        _sqlCommands.Add(_objetoComprobanteRetencionCompraVenta.ActualizarEstadoComprobanteRetencionVenta)

                        CargarDetalleComprobanteRetencion(dgvComprobanteRetencion.Rows(indiceRetencion).Cells(0).Value)
                        actualizarEstadoDetalleRetencionVenta()
                    Next
                End If
            Next
        End Sub
        Private Sub ActualizarEstadoDetalleRetencionVenta()
            For i = 0 To dgvDetalleComprobanteRetencion.Rows.Count - 1
                With _objetoDetalleComprobantesRetencionVenta
                    .IdDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(i).Cells(0).Value
                    .EstadoDetalleComprobanteRetencion = 0
                    '.ActualizarEstadoComprobanteRetencionVenta(_tipoCon)
                End With
                _sqlCommands.Add(_objetoDetalleComprobantesRetencionVenta.ActualizarEstadoComprobanteRetencionVenta)
            Next
        End Sub 
        Private Sub ActualizarEstadoNotaCredito()
            For indiceFactura = 0 To dgvFacturaVenta.RowCount - 1
                If dgvFacturaVenta.Rows(indiceFactura).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada 

                    CargarNotaCreditoVenta(dgvFacturaVenta.CurrentRow.Cells.Item(1).Value) ' carga las notas de credito de las facturas

                    For indiceNota = 0 To dgvNotaCreditoVenta.RowCount - 1
                        With _objetoNotaCredito
                            .IdNotaCredito = dgvNotaCreditoVenta.Rows(indiceNota).Cells(0).Value
                            .EstadoNotaCredito = 0
                            '.ActualizarEstadoNotaCreditoVenta(_tipoCon)
                        End With
                        _sqlCommands.Add(_objetoNotaCredito.ActualizarEstadoNotaCreditoVenta)

                        AnularAsientoLibroDiarioNotaCredito(dgvNotaCreditoVenta.Rows(indiceNota).Cells(0).Value)
                    Next
                End If
            Next
        End Sub
        Private Sub AnularAsientoLibroDiarioNotaCredito(ByVal idNotaCredito As Integer)
            Dim numerRegistro  = _objetoNumeroRegistroAsientoNotaCredito.BuscarNumeroRegistroAsientoPorIdNotaCredito(_tipoCon, idNotaCredito)
            With _objetoAsientoLibroDiario
                .NumeroRegistroAsiento = numerRegistro
                '.AnularAsientoLibroDiarioXNumeroRegistro(_tipoCon)
            End With
            _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)
        End Sub
        
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            If txtNombreComercialCliente.Text.Trim().Length > 0 Then
                txtNumeroFacturaBuscar.Clear()
                CargarDatosCliente()
                CargarFacturasVentaXIdCliente()
            Else
                txtNombreComercialCliente.Clear()
                lblIdClienteGeneral.Text = "..."
                lblRucClienteGenral.Text = "..."
                lblLlevaContabilidadClienteGeneral.Text = "..."
                CargarFacturasVentaXNroFactura()
            End If 
        End Sub

        Private Sub dgvFacturaVenta_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellContentClick
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvFacturaVenta.CurrentCell.EditedFormattedValue) Then
                    If _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells.Item(1).Value) < 0.01 Then
                        If Not _notSelect.Contains(dgvFacturaVenta.CurrentCell.RowIndex) Then _notSelect.Add(dgvFacturaVenta.CurrentCell.RowIndex)
                        MsgBox("ESTA FACTUARA YA HA SIDO CANCELADA" & vbNewLine & "NO SE PUEDE ANULAR", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                    Else
                        Dim si = _objetoPagosFacturaVenta.SeleccionarPagosActivoXIdComprobante(_tipoCon, CLng(dgvFacturaVenta.CurrentRow.Cells(1).Value))
                        If si.Rows.Count > 1 Or si.Rows(0)(2) > 1 Then
                            If Not _notSelect.Contains(dgvFacturaVenta.CurrentCell.RowIndex) Then _notSelect.Add(dgvFacturaVenta.CurrentCell.RowIndex)
                            MsgBox("ESTA FACTURA YA REGISTRA PAGOS. ANULE PRIMERO LOS PAGOS CORRESPONDIENTES O LA FACTURA NO SERÁ ANULADA!", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
                        End If
                    End If
                End If
            End If
            dgvFacturaVenta.EndEdit()
        End Sub

        Private Sub dgvFacturaVenta_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellEndEdit
            For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvFacturaVenta.Rows Where _notSelect.Contains(row1.Index)
                row.Cells(0).Value = False
            Next
            _notSelect.Clear()
        End Sub
    End Class
End Namespace