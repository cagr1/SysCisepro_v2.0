
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS

Namespace FORMULARIOS.CONTABILIDAD.SRI
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnexoTransaccional

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

        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos
        Dim objetoAnexoTransaccional As New ClassAnexoTransaccional
        Dim objetoComprobanteRetencionCompra As New ClassComprobantesRetencion
        Dim objetoDetalleComprobanteRetencionCompra As New ClassDetalleComprobantesRetencion

        Dim objetoDetalleComprobanteRetencionVentas As New ClassDetalleComprobantesRetencionVenta

        Dim cadenaNotasCredito As String()
        Dim cadenaFacturas As String()
        Dim cadenaIVABienes As String()
        Dim cadenaIVAServicios As String()
        Dim cadenaIVA100 As String()

        Public Sub limpiarParametros()
            dtpFechaDesde.ResetText()
            dtpFechaHasta.ResetText()
            dgvAnexoCompras.DataSource = Nothing
            dgvAnexoVentas.Rows.Clear()
            dgvAnexoRetencionesFuente.DataSource = Nothing
            dgvAnexoRetencionIVA.Rows.Clear()
            dgvAnexoRetencionesEfectuaron.DataSource = Nothing
        End Sub

        Public Sub cargarTotalCompras()
            dgvComprobanteCompra.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosTotalComprasXRangoFechas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
            dgvComprobanteCompra.AutoResizeColumns()
            dgvComprobanteCompra.AutoResizeRows()
        End Sub
        Public Sub cargarComprobanteRetencionCompra()
            dgvComprobanteRetencionCompra.DataSource = objetoComprobanteRetencionCompra.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))
            dgvComprobanteRetencionCompra.AutoResizeColumns()
            dgvComprobanteRetencionCompra.AutoResizeRows()
            'MsgBox("CARGA COMP RET")
        End Sub
        Public Sub cargarDetalleComprobanteRetencionCompras()
            dgvDetalleComprobanteRetencionCompra.DataSource = objetoDetalleComprobanteRetencionCompra.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))
            dgvDetalleComprobanteRetencionCompra.AutoResizeColumns()
            dgvDetalleComprobanteRetencionCompra.AutoResizeRows()
            'MsgBox("CARGA DET COMP RET")
        End Sub
        Public Sub cargarTotalVentas()
            dgvFacturasVenta.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosTotalVentasXRangoFechas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
            dgvFacturasVenta.AutoResizeColumns()
            dgvFacturasVenta.AutoResizeRows()
        End Sub
        Public Sub cargarDetalleComprobanteRetencionVentas()
            dgvDetalleComprobanteRetencionVenta.DataSource = objetoDetalleComprobanteRetencionVentas.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
            dgvDetalleComprobanteRetencionVenta.AutoResizeColumns()
            dgvDetalleComprobanteRetencionVenta.AutoResizeRows()
        End Sub

        Public Sub cargarAnexoCompras()
            Try

                dgvAnexoCompras.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_Compras(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
                'cantidadRegistrosAnexoCompras = dgvAnexoCompras.Rows.Count
                dgvAnexoCompras.AutoResizeColumns()
                dgvAnexoCompras.AutoResizeRows()
                dgvAnexoCompras.Columns(0).HeaderText = "TRANSACCIÓN"
                dgvAnexoCompras.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvAnexoCompras.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAnexoCompras.Columns(1).HeaderText = "Nº REGISTROS"
                dgvAnexoCompras.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoCompras.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoCompras.Columns(2).HeaderText = "BI TARIFA 0%"
                dgvAnexoCompras.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoCompras.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoCompras.Columns(3).HeaderText = "BI TARIFA 12%"
                dgvAnexoCompras.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoCompras.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoCompras.Columns(4).HeaderText = "VALOR IVA"
                dgvAnexoCompras.Columns(4).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoCompras.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoCompras.AutoResizeColumns()
                dgvAnexoCompras.AutoResizeRows()
            Catch
            End Try
        End Sub
        Public Sub cargarAnexoVentas()
            Try
                cadenaNotasCredito = {objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(0).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(1).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(2).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(3).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(4).ToString}

                cadenaFacturas = {objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(0).ToString, _
                                  objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(1).ToString, _
                                  objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(2).ToString, _
                                  objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(3).ToString, _
                                  objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(4).ToString}

                dgvAnexoVentas.Rows.Add(cadenaNotasCredito)
                dgvAnexoVentas.Rows.Add(cadenaFacturas)
                'dgvAnexoVentas.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(dtpFechaDesde.Value, dtpFechaHasta.Value)
                'cantidadRegistrosAnexoCompras = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_VentasFacturas(dtpFechaDesde.Value, dtpFechaHasta.Value).Rows.Count
                dgvAnexoVentas.AutoResizeColumns()
                dgvAnexoVentas.AutoResizeRows()
            Catch

            End Try
        End Sub
        Public Sub cargarAnexoComprobantesAnulados()
            Try
                dgvComprobantesAnulados.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_FacturasAnuladas(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
                'cantidadRegistrosAnexoCompras = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_FacturasAnuladas(dtpFechaDesde.Value, dtpFechaHasta.Value).Rows.Count

                dgvComprobantesAnulados.Columns(0).HeaderText = "DETALLE"
                dgvComprobantesAnulados.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvComprobantesAnulados.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesAnulados.Columns(1).HeaderText = "TOTAL"
                dgvComprobantesAnulados.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvComprobantesAnulados.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesAnulados.AutoResizeColumns()
                dgvComprobantesAnulados.AutoResizeRows()
            Catch ex As Exception
                MsgBox("FACTURAS ANULADAS." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción.")
            End Try
        End Sub
        Public Sub cargarAnexoRetencionFuente()
            Try
                Dim colValorRetenido As DataGridViewColumn = New DataGridViewTextBoxColumn()
                dgvAnexoRetencionesFuente.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionFuente(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))

                dgvAnexoRetencionesFuente.Columns(0).HeaderText = "CONCEPTO RETENCIÓN"
                dgvAnexoRetencionesFuente.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvAnexoRetencionesFuente.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAnexoRetencionesFuente.Columns(1).HeaderText = "Nº REGISTROS"
                dgvAnexoRetencionesFuente.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesFuente.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesFuente.Columns(2).HeaderText = "BASE IMPONIBLE"
                dgvAnexoRetencionesFuente.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesFuente.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesFuente.Columns.Add(colValorRetenido)
                dgvAnexoRetencionesFuente.Columns(3).HeaderText = "VALOR RETENIDO"
                dgvAnexoRetencionesFuente.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesFuente.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesFuente.AutoResizeColumns()
                dgvAnexoRetencionesFuente.AutoResizeRows()
            Catch ex As Exception
            End Try
        End Sub
        Public Sub calcularValorRetenidoFuente()
            Try
                For indiceRetFuente = 0 To dgvAnexoRetencionesFuente.RowCount - 1
                    Select Case dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(0).Value
                        Case "303"
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = (dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value * 10) / 100
                        Case "304", "320", "342"
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = (dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value * 8) / 100
                        Case "307", "308", "323", "341"
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = (dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value * 2) / 100
                        Case "309", "310", "312", "319", "322", "340"
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = (dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value * 1) / 100
                        Case "332"
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = (dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value * 0) / 100
                        Case Else
                            dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(3).Value = dgvAnexoRetencionesFuente.Rows(indiceRetFuente).Cells(2).Value
                    End Select
                Next
            Catch ex As Exception
                MsgBox("CALCULAR VALOR RETENIDO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub cargarAnexoRetencionIVA()
            Try
                cadenaIVABienes = {objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVABienes(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(0).ToString, _
                                   objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVABienes(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(1).ToString, _
                                   objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVABienes(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(2).ToString}

                cadenaIVAServicios = {objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVAServicios(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(0).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVAServicios(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(1).ToString, _
                                      objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVAServicios(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(2).ToString}

                cadenaIVA100 = {objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVA100(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(0).ToString, _
                                objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVA100(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(1).ToString, _
                                objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_RetencionIVA100(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))(0)(2).ToString}

                dgvAnexoRetencionIVA.Rows.Add(cadenaIVABienes)
                dgvAnexoRetencionIVA.Rows.Add(cadenaIVAServicios)
                dgvAnexoRetencionIVA.Rows.Add(cadenaIVA100)

                dgvAnexoRetencionIVA.AutoResizeColumns()
                dgvAnexoRetencionIVA.AutoResizeRows()
            Catch

            End Try
        End Sub
        Public Sub cargarAnexoRetencionesEfectuaron()
            Try
                dgvAnexoRetencionesEfectuaron.DataSource = objetoAnexoTransaccional.SeleccionarRegistrosAnexoTransaccional_ResumenRetencionesEfectuaron(_tipoCon, Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))

                dgvAnexoRetencionesEfectuaron.Columns(0).HeaderText = "OPERACIÓN"
                dgvAnexoRetencionesEfectuaron.Columns(0).DefaultCellStyle.BackColor = Color.Cyan
                dgvAnexoRetencionesEfectuaron.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvAnexoRetencionesEfectuaron.Columns(1).HeaderText = "CONCEPTO DE"
                dgvAnexoRetencionesEfectuaron.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesEfectuaron.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesEfectuaron.Columns(2).HeaderText = "RETENCIÓN"
                dgvAnexoRetencionesEfectuaron.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesEfectuaron.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesEfectuaron.Columns(3).HeaderText = "VALOR RETENIDO"
                dgvAnexoRetencionesEfectuaron.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvAnexoRetencionesEfectuaron.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvAnexoRetencionesEfectuaron.AutoResizeColumns()
                dgvAnexoRetencionesEfectuaron.AutoResizeRows()
            Catch ex As Exception

            End Try
        End Sub
        Public Sub sumarTotales()
            Try
                Dim acuTotalVentas As Decimal = 0

                Dim acuBITarifa0Compras As Decimal = 0
                Dim acuBITarifa12Compras As Decimal = 0
                Dim acuValorIVACompras As Decimal = 0

                Dim acuBITarifa0Ventas As Decimal = 0
                Dim acuBITarifa12Ventas As Decimal = 0
                Dim acuValorIVAVentas As Decimal = 0

                Dim acuBaseImponibleFuente As Decimal = 0
                Dim acuValorRetenidoFuente As Decimal = 0

                Dim acuValorRetenidoIVA As Decimal = 0

                Dim acuValorRetenidoRetencionesEfectuaron As Decimal = 0

                For indiceTotalVentas = 0 To dgvFacturasVenta.RowCount - 1
                    acuTotalVentas = acuTotalVentas + CType(dgvFacturasVenta.Rows(indiceTotalVentas).Cells(8).Value, Decimal)
                Next
                txtTotalVentas.Text = acuTotalVentas

                For indiceCompras = 0 To dgvAnexoCompras.RowCount - 1
                    acuBITarifa0Compras = acuBITarifa0Compras + dgvAnexoCompras.Rows(indiceCompras).Cells(2).Value
                    acuBITarifa12Compras = acuBITarifa12Compras + dgvAnexoCompras.Rows(indiceCompras).Cells(3).Value
                    acuValorIVACompras = acuValorIVACompras + dgvAnexoCompras.Rows(indiceCompras).Cells(4).Value
                Next
                txtTotalBITarifa0Compras.Text = acuBITarifa0Compras
                txtTotalBITarifa12Compras.Text = acuBITarifa12Compras
                txtTotalValorIVACompras.Text = acuValorIVACompras

                For indiceVentas = 0 To dgvAnexoVentas.RowCount - 1
                    acuBITarifa0Ventas = acuBITarifa0Ventas + dgvAnexoVentas.Rows(indiceVentas).Cells(2).Value
                    acuBITarifa12Ventas = acuBITarifa12Ventas + dgvAnexoVentas.Rows(indiceVentas).Cells(3).Value
                    acuValorIVAVentas = acuValorIVAVentas + dgvAnexoVentas.Rows(indiceVentas).Cells(4).Value
                Next
                txtTotalBITarifa0Ventas.Text = acuBITarifa0Ventas
                txtTotalBITarifa12Ventas.Text = acuBITarifa12Ventas
                txtTotalValorIVAVentas.Text = acuValorIVAVentas

                For indiceRenta = 0 To dgvAnexoRetencionesFuente.RowCount - 1
                    acuBaseImponibleFuente = acuBaseImponibleFuente + dgvAnexoRetencionesFuente.Rows(indiceRenta).Cells(2).Value
                    acuValorRetenidoFuente = acuValorRetenidoFuente + dgvAnexoRetencionesFuente.Rows(indiceRenta).Cells(3).Value
                Next
                txtTotalBaseImponibleFuente.Text = acuBaseImponibleFuente
                txtTotalValorRetenidoFuente.Text = acuValorRetenidoFuente

                For indiceIVA = 0 To dgvAnexoRetencionIVA.RowCount - 1
                    acuValorRetenidoIVA = acuValorRetenidoIVA + dgvAnexoRetencionIVA.Rows(indiceIVA).Cells(2).Value
                Next
                txtTotalValorRetenidoIVA.Text = acuValorRetenidoIVA

                For indiceREtEfectuaron = 0 To dgvAnexoRetencionesEfectuaron.RowCount - 1
                    acuValorRetenidoRetencionesEfectuaron = acuValorRetenidoRetencionesEfectuaron + dgvAnexoRetencionesEfectuaron.Rows(indiceREtEfectuaron).Cells(3).Value
                Next
                txtTotalValorRetenidoRetecioneEfectuaron.Text = acuValorRetenidoRetencionesEfectuaron
            Catch ex As Exception

            End Try
        End Sub
        Public Sub agruparDatosVentas()
            Dim validar As Integer = 0
            Dim cantidad As Integer = 0
            For indice = 0 To dgvFacturasVenta.RowCount - 1
                lblIdFacturaVenta.Text = dgvFacturasVenta.Rows(indice).Cells(0).Value
                cargarDetalleComprobanteRetencionVentas()
                validar = 1
                cantidad = 1
                For indiceDetalle = 0 To dgvDatosAgrupadosVentas.RowCount - 1
                    If dgvFacturasVenta.Rows(indice).Cells(4).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(1).Value Then
                        'acumula los valores de las facturas emitidas en el periodo seleccionado de cada cliente
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(2).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(2).Value + dgvFacturasVenta.Rows(indice).Cells(5).Value
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(3).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(3).Value + dgvFacturasVenta.Rows(indice).Cells(6).Value
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(4).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(4).Value + dgvFacturasVenta.Rows(indice).Cells(7).Value
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(5).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(5).Value + dgvFacturasVenta.Rows(indice).Cells(8).Value
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(6).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(6).Value + dgvFacturasVenta.Rows(indice).Cells(9).Value
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(7).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(7).Value + dgvFacturasVenta.Rows(indice).Cells(10).Value
                        'acumula los valores de las retenciones emitidas en el periodo seleccionado de cada cliente
                        If dgvDetalleComprobanteRetencionVenta.RowCount > 0 Then
                            Dim valorRetRenta As Decimal = 0
                            Dim valorRetIva As Decimal = 0
                            For indiceDetalleRetencion = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                                If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(4).Value = "RENTA" Then
                                    valorRetRenta = valorRetRenta + dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value
                                Else
                                    valorRetIva = valorRetIva + dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value
                                End If
                            Next
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(8).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(8).Value + valorRetIva
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(9).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(9).Value + valorRetRenta
                        End If
                        'cuenta la cantidad de facturas emitidas a cada cliente
                        dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(10).Value = CType(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(10).Value, Integer) + 1

                        validar = 0
                    End If
                Next
                If validar = 1 Then ' si el cliente no se repite se crea un nuevo registro

                    If dgvDetalleComprobanteRetencionVenta.RowCount > 0 Then 'si tiene retencion
                        Dim valorRetRenta As Decimal = 0
                        Dim valorRetIva As Decimal = 0
                        For indiceDetalleRetencion = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                            If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(4).Value = "RENTA" Then
                                valorRetRenta = valorRetRenta + dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value
                            Else
                                valorRetIva = valorRetIva + dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value
                            End If
                        Next
                        'agrega los valores del nuevo registro de factura y retencion por cliente
                        dgvDatosAgrupadosVentas.Rows.Add(dgvFacturasVenta.Rows(indice).Cells(3).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(4).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(5).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(6).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(7).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(8).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(9).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(10).Value, _
                                                         valorRetIva, _
                                                         valorRetRenta, _
                                                         cantidad)
                    Else
                        'agrega los valores del nuevo registro de factura sin retencion por cliente
                        dgvDatosAgrupadosVentas.Rows.Add(dgvFacturasVenta.Rows(indice).Cells(3).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(4).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(5).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(6).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(7).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(8).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(9).Value, _
                                                         dgvFacturasVenta.Rows(indice).Cells(10).Value, _
                                                         "0.00", _
                                                         "0.00", _
                                                         cantidad)
                    End If

                    'dgvDatosAgrupadosVentas.Rows.Add()
                End If
            Next
        End Sub

        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            If dtpFechaDesde.Value <> dtpFechaHasta.Value Then
                cargarTotalCompras()
                cargarTotalVentas()
                '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                cargarAnexoCompras()
                cargarAnexoVentas()
                cargarAnexoComprobantesAnulados()
                cargarAnexoRetencionFuente()
                calcularValorRetenidoFuente()
                cargarAnexoRetencionIVA()
                cargarAnexoRetencionesEfectuaron()
                sumarTotales()
                '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            Else
                MsgBox("REVISE LOS PARAMETROS DE BÚSQUEDA", MsgBoxStyle.Information, "Mensaje de información")
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            limpiarParametros()
        End Sub

        Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGenerarXML.Click
            'Try
            agruparDatosVentas()
            If dgvComprobanteCompra.RowCount > 0 And dgvFacturasVenta.RowCount > 0 Then
                Dim establecimiento As String = ""
                Dim puntoEmision As String = ""
                Dim secuencial As String = ""

                Dim estabRetencion As String = ""
                Dim ptoEmiRetencion As String = ""
                Dim secRetencion As String = ""

                Dim totalCompras As Decimal = 0

                Dim valorRetBienes As Decimal = 0.0
                Dim valorRetServicios As Decimal = 0.0
                Dim valRetServ100 As Decimal = 0.0

                Dim validarRetBienesServicios As Integer = 0

                For indice = 0 To dgvComprobanteCompra.RowCount - 1
                    totalCompras = totalCompras + dgvComprobanteCompra.Rows(indice).Cells(11).Value
                Next

                '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=CREAR XML =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                Dim obj As Object
                Dim archivo As Object
                Dim x As Integer = 0
                Dim month As String = ""
                Dim year As String = ""


                month = dtpFechaHasta.Value.Month.ToString
                year = dtpFechaHasta.Value.Year

                obj = CreateObject("Scripting.FileSystemObject")
                Dim ruta = ""
                Select Case month
                    Case 1
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "ENERO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "ENERO" + year & ".xml"
                    Case 2
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "FEBRERO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "FEBRERO" + year & ".xml"
                    Case 3
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "MARZO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "MARZO" + year & ".xml"
                    Case 4
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "ABRIL" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "ABRIL" + year & ".xml"
                    Case 5
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "MAYO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "MAYO" + year & ".xml"
                    Case 6
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "JUNIO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "JUNIO" + year & ".xml"
                    Case 7
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "JULIO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "JULIO" + year & ".xml"
                    Case 8
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "AGOSTO" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "AGOSTO" + year & ".xml"
                    Case 9
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "SEPTIEMBRE" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "SEPTIEMBRE" + year & ".xml"
                    Case 10
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "OCTUBRE" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "OCTUBRE" + year & ".xml"
                    Case 11
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "NOVIEMBRE" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "NOVIEMBRE" + year & ".xml"
                    Case 12
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & "DICIEMBRE" + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & "DICIEMBRE" + year & ".xml"
                    Case Else
                        'archivo = obj.CreateTextFile("\\SERVIDOR\Respaldos\ATS2014\" & month + year & ".xml", True)
                        ruta = "\\SERVIDOR\Respaldos\ATS2014\" & month + year & ".xml"
                End Select


                archivo = obj.CreateTextFile(ruta, True)
                archivo.writeline("<?xml version='1.0' encoding='UTF-8'?>")
                archivo.writeline("<iva>")
                archivo.writeline("<TipoIDInformante>R</TipoIDInformante>")
                archivo.writeline("<IdInformante>0790013360001</IdInformante>")
                archivo.writeline("<razonSocial>CISEPRO CIA LTDA</razonSocial>")
                archivo.writeline("<Anio>" & dtpFechaHasta.Value.Year & "</Anio>")

                Select Case dtpFechaHasta.Value.Month.ToString
                    Case "1"
                        archivo.writeline("<Mes>" & "01" & "</Mes>")
                    Case "2"
                        archivo.writeline("<Mes>" & "02" & "</Mes>")
                    Case "3"
                        archivo.writeline("<Mes>" & "03" & "</Mes>")
                    Case "4"
                        archivo.writeline("<Mes>" & "04" & "</Mes>")
                    Case "5"
                        archivo.writeline("<Mes>" & "05" & "</Mes>")
                    Case "6"
                        archivo.writeline("<Mes>" & "06" & "</Mes>")
                    Case "7"
                        archivo.writeline("<Mes>" & "07" & "</Mes>")
                    Case "8"
                        archivo.writeline("<Mes>" & "08" & "</Mes>")
                    Case "9"
                        archivo.writeline("<Mes>" & "09" & "</Mes>")
                    Case Else
                        archivo.writeline("<Mes>" & dtpFechaHasta.Value.Month & "</Mes>")
                End Select
                archivo.writeline("<numEstabRuc>001</numEstabRuc>")
                archivo.writeline("<totalVentas>" & txtTotalVentas.Text & "</totalVentas>")
                archivo.writeline("<codigoOperativo>IVA</codigoOperativo>")
                archivo.writeline("<compras>")
                For indice = 0 To dgvComprobanteCompra.RowCount - 1
                    lblIdComprobanteCompra.Text = dgvComprobanteCompra.Rows(indice).Cells(0).Value
                    'MsgBox(lblIdComprobanteCompra.Text.ToString)
                    cargarComprobanteRetencionCompra()
                    cargarDetalleComprobanteRetencionCompras()
                    archivo.writeline("<detalleCompras>")
                    If dgvComprobanteCompra.Rows(indice).Cells(3).Value = "FACTURA" Then
                        archivo.writeline("<codSustento>01</codSustento>")
                    ElseIf dgvComprobanteCompra.Rows(indice).Cells(3).Value = "NOTA DE VENTA" Then
                        archivo.writeline("<codSustento>02</codSustento>")
                    ElseIf dgvComprobanteCompra.Rows(indice).Cells(3).Value = "LIQUIDACION DE COMPRA DE BIENES O PRESTACIÓN DE SERVICIOS" Then
                        archivo.writeline("<codSustento>03</codSustento>")
                    Else
                        archivo.writeline("<codSustento>01</codSustento>")
                    End If
                    archivo.writeline("<tpIdProv>01</tpIdProv>")
                    archivo.writeline("<idProv>" & dgvComprobanteCompra.Rows(indice).Cells(2).Value & "</idProv>")
                    If dgvComprobanteCompra.Rows(indice).Cells(3).Value = "FACTURA" Then
                        archivo.writeline("<tipoComprobante>01</tipoComprobante>")
                    ElseIf dgvComprobanteCompra.Rows(indice).Cells(3).Value = "NOTA DE VENTA" Then
                        archivo.writeline("<tipoComprobante>02</tipoComprobante>")
                    ElseIf dgvComprobanteCompra.Rows(indice).Cells(3).Value = "LIQUIDACION DE COMPRA DE BIENES O PRESTACIÓN DE SERVICIOS" Then
                        archivo.writeline("<tipoComprobante>03</tipoComprobante>")
                    Else
                        archivo.writeline("<tipoComprobante>04</tipoComprobante>")
                    End If
                    archivo.writeline("<fechaRegistro>" & Format(dgvComprobanteCompra.Rows(indice).Cells(6).Value, "dd/MM/yyyy") & "</fechaRegistro>")
                    establecimiento = Mid(dgvComprobanteCompra.Rows(indice).Cells(5).Value, 1, 3)
                    archivo.writeline("<establecimiento>" & establecimiento & "</establecimiento>")
                    puntoEmision = Mid(dgvComprobanteCompra.Rows(indice).Cells(5).Value, 4, 3)
                    archivo.writeline("<puntoEmision>" & puntoEmision & "</puntoEmision>")
                    secuencial = Mid(dgvComprobanteCompra.Rows(indice).Cells(5).Value, 7)
                    archivo.writeline("<secuencial>" & secuencial & "</secuencial>")
                    archivo.writeline("<fechaEmision>" & Format(dgvComprobanteCompra.Rows(indice).Cells(6).Value, "dd/MM/yyyy") & "</fechaEmision>")
                    archivo.writeline("<autorizacion>" & dgvComprobanteCompra.Rows(indice).Cells(7).Value & "</autorizacion>")
                    archivo.writeline("<baseNoGraIva>0.00</baseNoGraIva>")
                    archivo.writeline("<baseImponible>" & dgvComprobanteCompra.Rows(indice).Cells(9).Value & "</baseImponible>")
                    archivo.writeline("<baseImpGrav>" & dgvComprobanteCompra.Rows(indice).Cells(8).Value & "</baseImpGrav>")
                    archivo.writeline("<montoIce>0.00</montoIce>")
                    archivo.writeline("<montoIva>" & dgvComprobanteCompra.Rows(indice).Cells(12).Value & "</montoIva>")
                    If dgvDetalleComprobanteRetencionCompra.RowCount > 0 Then
                        'MsgBox(dgvDetalleComprobanteRetencionCompra.RowCount)
                        For indiceDetalleIva = 0 To dgvDetalleComprobanteRetencionCompra.RowCount - 1
                            'MsgBox(indiceDetalleIva)
                            If dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(4).Value.ToString = "IVA" Then
                                'MsgBox(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(4).Value.ToString)
                                Select Case dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(2).Value.ToString
                                    Case "303" : valRetServ100 = valRetServ100 + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 303")
                                    Case "304" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 304")
                                    Case "307" : valRetServ100 = valRetServ100 + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 307")
                                    Case "308" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 308")
                                    Case "309" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 309")
                                    Case "312" : valorRetBienes = valorRetBienes + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 312")
                                    Case "319" : valorRetBienes = valorRetBienes + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 319")
                                    Case "320" : valRetServ100 = valRetServ100 + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 320")
                                    Case "321" : valorRetBienes = valorRetBienes + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 321")
                                    Case "322" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 322")
                                    Case "332" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 332")
                                    Case "340" : valorRetBienes = valorRetBienes + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 340")
                                    Case "341" : valorRetServicios = valorRetServicios + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE 341")
                                    Case Else : valRetServ100 = valRetServ100 + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value
                                        'MsgBox("CASE ELSE")
                                End Select
                            End If
                        Next
                    End If
                    archivo.writeline("<valorRetBienes>" & valorRetBienes & "</valorRetBienes>")
                    archivo.writeline("<valorRetServicios>" & valorRetServicios & "</valorRetServicios>")
                    archivo.writeline("<valRetServ100>" & valRetServ100 & "</valRetServ100>")
                    archivo.writeline("<pagoExterior>")
                    archivo.writeline("<pagoLocExt>01</pagoLocExt>")
                    archivo.writeline("<paisEfecPago>NA</paisEfecPago>")
                    archivo.writeline("<aplicConvDobTrib>NA</aplicConvDobTrib>")
                    archivo.writeline("<pagExtSujRetNorLeg>NA</pagExtSujRetNorLeg>")
                    archivo.writeline("</pagoExterior>")
                    If dgvComprobanteCompra.Rows(indice).Cells(13).Value > 999.99 Then
                        archivo.writeline("<formasDePago>")
                        archivo.writeline("<formaPago>01</formaPago>")
                        archivo.writeline("</formasDePago>")
                    End If
                    '<formasDePago>
                    '<formaPago>01</formaPago> 
                    '</formasDePago>
                    archivo.writeline("<air>")
                    For indiceDetalleRenta = 0 To dgvDetalleComprobanteRetencionCompra.RowCount - 1
                        If dgvDetalleComprobanteRetencionCompra.RowCount > 0 Then
                            If dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleRenta).Cells(4).Value = "RENTA" Then

                                archivo.writeline("<detalleAir>")
                                archivo.writeline("<codRetAir>" & dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleRenta).Cells(2).Value & "</codRetAir>")
                                archivo.writeline("<baseImpAir>" & dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleRenta).Cells(3).Value & "</baseImpAir>")
                                archivo.writeline("<porcentajeAir>" & dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleRenta).Cells(5).Value & "</porcentajeAir>")
                                archivo.writeline("<valRetAir>" & dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleRenta).Cells(6).Value & "</valRetAir>")
                                archivo.writeline("</detalleAir>")

                            End If
                        Else
                            If dgvDetalleComprobanteRetencionCompra.RowCount = 1 Then

                                archivo.writeline("<detalleAir>")
                                archivo.writeline("<codRetAir>0.00</codRetAir>")
                                archivo.writeline("<baseImpAir>0.00</baseImpAir>")
                                archivo.writeline("<porcentajeAir>0.00</porcentajeAir>")
                                archivo.writeline("<valRetAir>0.00</valRetAir>")
                                archivo.writeline("</detalleAir>")

                            End If
                        End If
                    Next
                    archivo.writeline("</air>")
                    For indiceCompRet = 0 To dgvComprobanteRetencionCompra.RowCount - 1
                        If dgvComprobanteRetencionCompra.RowCount > 0 Then
                            If dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value.ToString = "000000000000000" Then
                                archivo.writeline("<estabRetencion1>000</estabRetencion1>")
                                archivo.writeline("<ptoEmiRetencion1>000</ptoEmiRetencion1>")
                                archivo.writeline("<secRetencion1>0000</secRetencion1>")
                                archivo.writeline("<autRetencion1>" & dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(2).Value & "</autRetencion1>")
                                archivo.writeline("<fechaEmiRet1>" & Format(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(4).Value, "dd/MM/yyyy") & "</fechaEmiRet1>")
                            Else
                                estabRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 1, 3)
                                archivo.writeline("<estabRetencion1>" & estabRetencion & "</estabRetencion1>")
                                ptoEmiRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 4, 3)
                                archivo.writeline("<ptoEmiRetencion1>" & ptoEmiRetencion & "</ptoEmiRetencion1>")
                                secRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 7)
                                If CType(secRetencion, Integer) = 0 Then
                                    secRetencion = "000"
                                End If
                                archivo.writeline("<secRetencion1>" & secRetencion & "</secRetencion1>")
                                archivo.writeline("<autRetencion1>" & dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(2).Value & "</autRetencion1>")
                                archivo.writeline("<fechaEmiRet1>" & Format(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(4).Value, "dd/MM/yyyy") & "</fechaEmiRet1>")
                            End If
                        Else
                            archivo.writeline("<estabRetencion1>000</estabRetencion1>")
                            archivo.writeline("<ptoEmiRetencion1>000</ptoEmiRetencion1>")
                            archivo.writeline("<secRetencion1>0000</secRetencion1>")
                            archivo.writeline("<autRetencion1>0</autRetencion1>")
                            archivo.writeline("<fechaEmiRet1>00/00/0000</fechaEmiRet1>")
                        End If
                    Next

                    archivo.writeline("<docModificado>01</docModificado>")
                    archivo.writeline("<estabModificado>000</estabModificado>")
                    archivo.writeline("<ptoEmiModificado>000</ptoEmiModificado>")
                    archivo.writeline("<secModificado>0</secModificado>")
                    archivo.writeline("<autModificado>000</autModificado>")

                    archivo.writeline("</detalleCompras>")
                Next
                archivo.writeline("</compras>")
                archivo.writeline("<ventas>")
                For indiceVentas = 0 To dgvDatosAgrupadosVentas.RowCount - 1
                    archivo.writeline("<detalleVentas>")
                    If dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(0).Value = "RUC" Then
                        archivo.writeline("<tpIdCliente>04</tpIdCliente>")
                    ElseIf dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(0).Value = "CEDULA" Then
                        archivo.writeline("<tpIdCliente>05</tpIdCliente>")
                    End If
                    archivo.writeline("<idCliente>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(1).Value & "</idCliente>")
                    archivo.writeline("<tipoComprobante>18</tipoComprobante>")
                    archivo.writeline("<numeroComprobantes>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(10).Value & "</numeroComprobantes>")
                    archivo.writeline("<baseNoGraIva>0.00</baseNoGraIva>")
                    archivo.writeline("<baseImponible>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(2).Value & "</baseImponible>")
                    archivo.writeline("<baseImpGrav>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(3).Value & "</baseImpGrav>")
                    archivo.writeline("<montoIva>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(6).Value & "</montoIva>")
                    archivo.writeline("<valorRetIva>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(8).Value & "</valorRetIva>")
                    archivo.writeline("<valorRetRenta>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(9).Value & "</valorRetRenta>")
                    archivo.writeline("</detalleVentas>")
                Next
                archivo.writeline("</ventas>")
                archivo.writeline("<ventasEstablecimiento>")
                archivo.writeline("<ventaEst>")
                archivo.writeline("<codEstab>001</codEstab>")
                archivo.writeline("<ventasEstab>" & txtTotalVentas.Text & "</ventasEstab>")
                archivo.writeline("</ventaEst>")
                archivo.writeline("</ventasEstablecimiento>")

                archivo.writeline("</iva>")


                ' GUARDAR COMPROBANTE ELECTRONICO
                Dim lectura = obj.OpenTextFile(ruta, 1)
                _objetoComprobantesElectronicos.IdComprobante = _objetoComprobantesElectronicos.BuscarMayorIdComprobanteElectronico(_tipoCon) + 1
                _objetoComprobantesElectronicos.IdDocumento = 0
                _objetoComprobantesElectronicos.Tipo = "ATS"
                _objetoComprobantesElectronicos.Documento = lectura.readall
                _objetoComprobantesElectronicos.FechaEmision = DateTime.Now
                _objetoComprobantesElectronicos.NumDocumento = 0
                _objetoComprobantesElectronicos.GuardarComprobanteElectronico(_tipoCon)

                archivo.close()
                lectura.close()


                MsgBox("XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
            Else
                MsgBox("NO SE PUEDE GENERAR EL XML." & vbNewLine & "ASEGURESE DE HABER ESCOGIDO BIEN LAS FECHAS", MsgBoxStyle.Exclamation, "Mensaje de validación.")
            End If
            'Catch ex As Exception
            '    MsgBox("GENERAR XML" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción.")
            'End Try
        End Sub

        Private Sub FormAnexoTransaccional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAnexoCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAnexoRetencionIVA.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAnexoRetencionesEfectuaron.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAnexoRetencionesFuente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAnexoVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesAnulados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDatosAgrupadosVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAnexoCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAnexoRetencionIVA.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAnexoRetencionesEfectuaron.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAnexoRetencionesFuente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAnexoVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesAnulados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDatosAgrupadosVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAnexoCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAnexoRetencionIVA.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAnexoRetencionesEfectuaron.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAnexoRetencionesFuente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAnexoVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesAnulados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDatosAgrupadosVentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencionCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobanteRetencionCompra.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvAnexoCompras.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvAnexoRetencionIVA.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvAnexoRetencionesEfectuaron.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvAnexoRetencionesFuente.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvAnexoVentas.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvComprobanteCompra.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvComprobantesAnulados.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvDatosAgrupadosVentas.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvDetalleComprobanteRetencionCompra.Font = New Font("Roboto", 8.25, FontStyle.Regular)
            dgvDetalleComprobanteRetencionVenta.Font = New Font("Roboto", 8.25, FontStyle.Regular)

        End Sub
    End Class
End Namespace