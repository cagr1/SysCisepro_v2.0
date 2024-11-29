Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.SRI
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAtsSimplificado
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

        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoAnexoTransaccional As New ClassAnexoTransaccional
        ReadOnly _objetoComprobanteRetencionCompra As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobanteRetencionCompra As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoDetalleComprobanteRetencionVentas As New ClassDetalleComprobantesRetencionVenta

        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""
        Dim _comprasFacturas As String = ""
        Dim _comprasNotasVenta As String = ""
        Dim _comprasNotasCredito As String = ""
        Dim _comprasLiquidaciones As String = ""
        Dim _ventasNotasCredito As String = ""
        Dim _ventasFacturas As String = ""
        Dim _retencionesCompras As String = ""

        Private Sub FormATSSimplificado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvVentasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNotasCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCodigosRetencionCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvVentasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvNotasCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCodigosRetencionCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvVentasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNotasCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprasATS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCodigosRetencionCompras.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvVentasATS.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvNotasCredito.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprasATS.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvCodigosRetencionCompras.Font = New Font("Roboto", 8, FontStyle.Regular)
            btnCargar.Enabled = False
            btnGenerarXML.Enabled = False
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            dgvComprasATS.DataSource = Nothing
            dgvVentasATS.DataSource = Nothing
            dgvComprobanteRetencionCompra.DataSource = Nothing
            dgvComprobanteRetencionVenta.DataSource = Nothing
            dgvNotasCredito.DataSource = Nothing

            dgvDatosAgrupadosVentas.Rows.Clear()
            dgvDetalleComprobanteRetencionCompra.DataSource = Nothing
            dgvDetalleComprobanteRetencionVenta.DataSource = Nothing
            dgvCodigosRetencionCompras.Rows.Clear()

            CargarComprobantesCompra()
            CargarFacturasVenta()
            CargarNotasCredito()

            btnCargar.Enabled = True
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                dgvComprasATS.DataSource = _objetoAnexoTransaccional.SeleccionarRegistrosTotalComprasXRangoFechas(_tipoCon, _fechaDesde, _fechaHasta) '(Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
                dgvComprasATS.Columns(0).HeaderText = "ID"
                dgvComprasATS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(1).HeaderText = "RUC"
                dgvComprasATS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(2).HeaderText = "PROVEEDOR"
                dgvComprasATS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(3).HeaderText = "TIPO"
                dgvComprasATS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(4).HeaderText = "NUMERO"
                dgvComprasATS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(5).HeaderText = "FECHA EMISION"
                dgvComprasATS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(6).HeaderText = "FECHA AUTO SRI"
                dgvComprasATS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(7).HeaderText = "NUMERO AUTO SRI"
                dgvComprasATS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(8).HeaderText = "SUBTOTAL 12%"
                dgvComprasATS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(9).HeaderText = "SUBTOTAL  0%"
                dgvComprasATS.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(10).HeaderText = "DESCUENTO"
                dgvComprasATS.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(11).HeaderText = "SUBTOTAL"
                dgvComprasATS.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(12).HeaderText = "IVA"
                dgvComprasATS.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(13).HeaderText = "TOTAL"
                dgvComprasATS.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(14).HeaderText = "EST."
                dgvComprasATS.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(15).HeaderText = "NUMERO DCTO MODIFICA"
                dgvComprasATS.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(16).HeaderText = "NUM AUTO DCTO MODIFICA"
                dgvComprasATS.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

                dgvComprasATS.Columns(18).HeaderText = "TIP DOC"
                dgvComprasATS.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(19).HeaderText = "TIP PRO"
                dgvComprasATS.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprasATS.Columns(20).HeaderText = "SUBTOTAL 5%"
                dgvComprasATS.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

                dgvComprasATS.ReadOnly = True
                dgvComprasATS.AutoResizeColumns()
                dgvComprasATS.AutoResizeRows()

                dgvComprasATS.Columns(0).Width = 50
                dgvComprasATS.Columns(3).Width = 90
                dgvComprasATS.Columns(2).Width = 250
            Catch ex As Exception
                dgvComprasATS.DataSource = Nothing
                'MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
            SumarTotalesCompras()
        End Sub
        Private Sub SumarTotalesCompras()
            Dim tSubtotal0Compras As Decimal
            Dim tSubtotal12Compras As Decimal
            Dim tSubtotal14Compras As Decimal
            Dim tDescuentoCompras As Decimal
            Dim tSubtotalCompras As Decimal
            Dim tIva12Compras As Decimal
            Dim tIva14Compras As Decimal
            Dim tIvaCompras As Decimal
            Dim tTotalCompras As Decimal

            For i = 0 To dgvComprasATS.Rows.Count - 1

                ' LAS NOTAS DE CRÉDITO NO SE SUMAN
                If (dgvComprasATS.Rows(i).Cells(3).Value & "").ToString().Trim().Equals("NOTA DE CREDITO") Then Continue For

                If dgvComprasATS.Rows(i).Cells("PORCENTAJE").Value = 12 Then
                    tSubtotal12Compras += CDec(dgvComprasATS.Rows(i).Cells(8).Value)
                    tIva12Compras += CDec(dgvComprasATS.Rows(i).Cells(12).Value)
                ElseIf dgvComprasATS.Rows(i).Cells("PORCENTAJE").Value = 14 Then
                    tSubtotal14Compras += CDec(dgvComprasATS.Rows(i).Cells(8).Value)
                    tIva14Compras += CDec(dgvComprasATS.Rows(i).Cells(12).Value)
                End If
                tSubtotal0Compras += CDec(dgvComprasATS.Rows(i).Cells(9).Value)
                tDescuentoCompras += CDec(dgvComprasATS.Rows(i).Cells(10).Value)
                tSubtotalCompras += CDec(dgvComprasATS.Rows(i).Cells(11).Value)
                tIvaCompras += CDec(dgvComprasATS.Rows(i).Cells(12).Value)
                tTotalCompras += CDec(dgvComprasATS.Rows(i).Cells(13).Value)

            Next

            txtSubtotal0Compras.Text = tSubtotal0Compras
            txtSubtotal12Compras.Text = tSubtotal12Compras
            txtSubtotal14Compras.Text = tSubtotal14Compras
            txtDescuentoCompras.Text = tDescuentoCompras
            txtSubtotalCompras.Text = tSubtotalCompras
            txtIva12Compras.Text = tIva12Compras
            txtIva14Compras.Text = tIva14Compras
            txtIvaCompras.Text = tIvaCompras
            txtTotalCompras.Text = tTotalCompras
        End Sub
        Private Sub CargarFacturasVenta()
            Try
                dgvVentasATS.DataSource = _objetoAnexoTransaccional.SeleccionarRegistrosTotalVentasXRangoFechas(_tipoCon, _fechaDesde, _fechaHasta) '(Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))
                dgvVentasATS.Columns(0).HeaderText = "ID"
                dgvVentasATS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.Columns(1).HeaderText = "# FACTURA"
                dgvVentasATS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.Columns(2).HeaderText = "FECHA EMISIÓN"
                dgvVentasATS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.Columns(3).HeaderText = "RUC"
                dgvVentasATS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.Columns(4).HeaderText = "CLIENTE"
                dgvVentasATS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.Columns(5).HeaderText = "SUBTOTAL 0%"
                dgvVentasATS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(6).HeaderText = "SUBTOTAL IVA"
                dgvVentasATS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(7).HeaderText = "DESC."
                dgvVentasATS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(8).HeaderText = "SUBTOTAL"
                dgvVentasATS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(9).HeaderText = "IVA     "
                dgvVentasATS.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(10).HeaderText = "TOTAL  "
                dgvVentasATS.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvVentasATS.Columns(11).HeaderText = "EST"
                dgvVentasATS.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvVentasATS.AutoResizeColumns()
                dgvVentasATS.AutoResizeRows()
                dgvVentasATS.ReadOnly = True
            Catch ex As Exception
                dgvVentasATS.DataSource = Nothing
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar factura venta" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
            SumarTotalesVentas()
        End Sub
        Private Sub SumarTotalesVentas()
            Dim tSubtotal0FacturaVentas As Decimal
            Dim tSubtotal12FacturaVentas As Decimal
            Dim tSubtotal14FacturaVentas As Decimal
            Dim tDescuentoFacturaVentas As Decimal
            Dim tSubtotalFacturaVentas As Decimal
            Dim tIva12FacturaVentas As Decimal
            Dim tIva14FacturaVentas As Decimal
            Dim tIvaFacturaVentas As Decimal
            Dim tTotalFacturaVentas As Decimal
            For indice = 0 To dgvVentasATS.Rows.Count - 1
                If dgvVentasATS.Rows(indice).Cells(11).Value <> "0" Then
                    tSubtotal0FacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(5).Value)
                    If dgvVentasATS.Rows(indice).Cells("PORCENTAJE").Value = 12 Then
                        tSubtotal12FacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(6).Value)
                        tIva12FacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(9).Value)
                    ElseIf dgvVentasATS.Rows(indice).Cells("PORCENTAJE").Value = 14 Then
                        tSubtotal14FacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(6).Value)
                        tIva14FacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(9).Value)
                    End If
                    tDescuentoFacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(7).Value)
                    tSubtotalFacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(8).Value)
                    tIvaFacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(9).Value)
                    tTotalFacturaVentas += CDec(dgvVentasATS.Rows(indice).Cells(10).Value)
                End If
            Next
            txtSubtotal0FacturaVentas.Text = tSubtotal0FacturaVentas
            txtSubtotal12FacturaVentas.Text = tSubtotal12FacturaVentas
            txtSubtotal14FacturaVentas.Text = tSubtotal14FacturaVentas
            txtDescuentoFacturaVentas.Text = tDescuentoFacturaVentas
            txtSubtotalFacturaVentas.Text = tSubtotalFacturaVentas
            txtIva12FacturaVentas.Text = tIva12FacturaVentas
            txtIva14FacturaVentas.Text = tIva14FacturaVentas
            txtIvaFacturaVentas.Text = tIvaFacturaVentas
            txtTotalFacturaVentas.Text = tTotalFacturaVentas
        End Sub
        Private Sub CargarNotasCredito()
            Try
                dgvNotasCredito.DataSource = _objetoAnexoTransaccional.SeleccionarRegistrosTotalNotasCreditoXRangoFechas(_tipoCon, _fechaDesde, _fechaHasta) '(Format(dtpFechaDesde.Value, "dd/MM/yyyy"), Format(dtpFechaHasta.Value, "dd/MM/yyyy"))               
                dgvNotasCredito.Columns(0).HeaderText = "ID"
                dgvNotasCredito.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(1).HeaderText = "TIPO ID"
                dgvNotasCredito.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(2).HeaderText = "ID CLIENTE"
                dgvNotasCredito.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(3).HeaderText = "NOMBRE CLIENTE"
                dgvNotasCredito.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(4).HeaderText = "NÚMERO NC"
                dgvNotasCredito.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(5).HeaderText = "NUM AUTO SRI"
                dgvNotasCredito.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(6).HeaderText = "FECHA AUTO SRI"
                dgvNotasCredito.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(7).HeaderText = "FECHA EMISIÓN"
                dgvNotasCredito.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(8).HeaderText = "NUM DOC MODIFICA"
                dgvNotasCredito.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(9).HeaderText = "RAZÓN"
                dgvNotasCredito.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.Columns(10).HeaderText = "SUBTOTAL  0%"
                dgvNotasCredito.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotasCredito.Columns(11).HeaderText = "SUBTOTAL IVA"
                dgvNotasCredito.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotasCredito.Columns(12).HeaderText = "SUBTOTAL    "
                dgvNotasCredito.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotasCredito.Columns(13).HeaderText = "IVA         "
                dgvNotasCredito.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotasCredito.Columns(14).HeaderText = "TOTAL"
                dgvNotasCredito.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotasCredito.Columns(15).HeaderText = "EST"
                dgvNotasCredito.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotasCredito.AutoResizeColumns()
                dgvNotasCredito.AutoResizeRows()
                dgvNotasCredito.ReadOnly = True
                dgvNotasCredito.Columns(0).Width = 50
                dgvNotasCredito.Columns(1).Width = 50
            Catch ex As Exception
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar factura venta" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

            End Try
            SumarTotalesNotasCredito()
        End Sub
        Private Sub SumarTotalesNotasCredito()
            Dim tSubtotal0NotaCredito As Decimal
            Dim tSubtotal12NotaCredito As Decimal
            Dim tSubtotal14NotaCredito As Decimal
            Dim tSubtotalNotaCredito As Decimal
            Dim tIva12NotaCredito As Decimal
            Dim tIva14NotaCredito As Decimal
            Dim tIvaNotaCredito As Decimal
            Dim tTotalNotaCredito As Decimal
            For indice = 0 To dgvNotasCredito.Rows.Count - 1
                If dgvNotasCredito.Rows(indice).Cells("PORCENTAJE").Value = 12 Then
                    tSubtotal12NotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(11).Value)
                    tIva12NotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(13).Value)
                ElseIf dgvNotasCredito.Rows(indice).Cells("PORCENTAJE").Value = 14 Then
                    tSubtotal14NotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(11).Value)
                    tIva14NotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(13).Value)
                End If
                tSubtotal0NotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(10).Value)
                tSubtotalNotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(12).Value)
                tIvaNotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(13).Value)
                tTotalNotaCredito += CDec(dgvNotasCredito.Rows(indice).Cells(14).Value)
            Next
            txtSubtotal0NotaCredito.Text = tSubtotal0NotaCredito
            txtSubtotal12NotaCredito.Text = tSubtotal12NotaCredito
            txtSubtotal14NotaCredito.Text = tSubtotal14NotaCredito
            txtSubtotalNotaCredito.Text = tSubtotalNotaCredito
            txtIva12NotaCredito.Text = tIva12NotaCredito
            txtIva14NotaCredito.Text = tIva14NotaCredito
            txtIvaNotaCredito.Text = tIvaNotaCredito
            txtTotalNotaCredito.Text = tTotalNotaCredito
        End Sub
        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            tcATSSimplificado.SelectedTab = tpResumenATS

            gbCompras.Enabled = False
            gbVentas.Enabled = False
            gbComprobantesAnulados.Enabled = False
            gbRetencionesEfectuaron.Enabled = False
            gbRetencionesFuenteRenta.Enabled = False
            gbRetencionesFuenteIva.Enabled = False

            AgruparDatosVentas()
            AgruparDatosNotasCredito()

            ResumirCompras()
            ResumirVentas()
            ResumirNotasCredito()

            gbCompras.Enabled = True
            gbVentas.Enabled = True
            gbComprobantesAnulados.Enabled = True
            gbRetencionesEfectuaron.Enabled = True
            gbRetencionesFuenteRenta.Enabled = True
            gbRetencionesFuenteIva.Enabled = True
            btnGenerarXML.Enabled = True
        End Sub
        Private Sub AgruparDatosVentas()
            Dim validar As Integer
            Dim canti As Integer = 0
            _ventasFacturas = ""
            dgvDatosAgrupadosVentas.Rows.Clear()

            For indice = 0 To dgvVentasATS.RowCount - 1
                If dgvVentasATS.Rows(indice).Cells(11).Value > 0 Then
                    lblIdFacturaVenta.Text = dgvVentasATS.Rows(indice).Cells(0).Value

                    If _ventasFacturas = "" Then ' cadena de todos los id de las facturas que estan en la declaracion
                        _ventasFacturas = lblIdFacturaVenta.Text.ToString
                    Else
                        _ventasFacturas = _ventasFacturas + "," + lblIdFacturaVenta.Text.ToString
                    End If
                    dgvDetalleComprobanteRetencionVenta.DataSource = _objetoDetalleComprobanteRetencionVentas.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
                    validar = 1
                    canti = 1
                    For indiceDetalle = 0 To dgvDatosAgrupadosVentas.RowCount - 1
                        If dgvVentasATS.Rows(indice).Cells(4).Value = dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(1).Value Then
                            'acumula los valores de las facturas emitidas en el periodo seleccionado de cada cliente
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(2).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(2).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(5).Value, 2)
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(3).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(3).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(6).Value, 2)
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(4).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(4).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(7).Value, 2)
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(5).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(5).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(8).Value, 2)
                            'calcula el IVA del subtotal acumulado de los clientes que se repiten
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(6).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(6).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(9).Value, 2)
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(7).Value = Math.Round(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(7).Value, 2) + Math.Round(dgvVentasATS.Rows(indice).Cells(10).Value, 2)
                            'acumula los valores de las retenciones emitidas en el periodo seleccionado de cada cliente
                            If dgvDetalleComprobanteRetencionVenta.RowCount > 0 Then
                                Dim valorRetRenta As Decimal = 0
                                Dim valorRetIva As Decimal = 0
                                For indiceDetalleRetencion = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                                    If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(4).Value = "RENTA" Then
                                        valorRetRenta = Math.Round(valorRetRenta, 2) + Math.Round(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value, 2)
                                    Else
                                        valorRetIva = Math.Round(valorRetIva, 2) + Math.Round(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value, 2)
                                    End If
                                Next
                                dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(8).Value = Math.Round(Convert.ToDecimal(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(8).Value), 2) + Math.Round(valorRetIva, 2)
                                dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(9).Value = Math.Round(Convert.ToDecimal(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(9).Value), 2) + Math.Round(valorRetRenta, 2)
                            End If
                            'cuenta la cantidad de facturas emitidas a cada cliente
                            dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(10).Value = CInt(dgvDatosAgrupadosVentas.Rows(indiceDetalle).Cells(10).Value) + 1
                            'valorIva = 0
                            validar = 0
                        End If
                    Next
                    If validar = 1 Then ' si el cliente no se repite se crea un nuevo registro 
                        If dgvDetalleComprobanteRetencionVenta.RowCount > 0 Then 'si tiene retencion
                            Dim valorRetRenta As Decimal = 0
                            Dim valorRetIva As Decimal = 0
                            For indiceDetalleRetencion = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                                If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(4).Value = "RENTA" Then
                                    valorRetRenta = Math.Round(valorRetRenta, 2) + Math.Round(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value, 2)
                                Else
                                    valorRetIva = Math.Round(valorRetIva, 2) + Math.Round(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetencion).Cells(6).Value, 2)
                                End If
                            Next
                            'agrega los valores del nuevo registro de factura y retencion por cliente
                            dgvDatosAgrupadosVentas.Rows.Add(dgvVentasATS.Rows(indice).Cells(3).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(4).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(5).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(6).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(7).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(8).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(9).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(10).Value, _
                                                             valorRetIva, _
                                                             valorRetRenta, _
                                                             canti)
                        Else
                            'agrega los valores del nuevo registro de factura sin retencion por cliente
                            dgvDatosAgrupadosVentas.Rows.Add(dgvVentasATS.Rows(indice).Cells(3).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(4).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(5).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(6).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(7).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(8).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(9).Value, _
                                                             dgvVentasATS.Rows(indice).Cells(10).Value, _
                                                             "0.00", _
                                                             "0.00", _
                                                             canti)
                        End If
                    End If
                End If
            Next
        End Sub
        Private Sub AgruparDatosNotasCredito()
            Dim validar As Integer
            Dim canti As Integer = 0
            _ventasNotasCredito = ""
            dgvDatosAgrupadosNotasCredito.Rows.Clear()
            For indice = 0 To dgvNotasCredito.RowCount - 1
                If dgvNotasCredito.Rows(indice).Cells(15).Value > 0 Then

                    If _ventasNotasCredito = "" Then ' cadena de todos los id de las notas de credito que estan en la declaracion
                        _ventasNotasCredito = dgvNotasCredito.Rows(indice).Cells(15).Value.ToString
                    Else
                        _ventasNotasCredito = _ventasNotasCredito + "," + dgvNotasCredito.Rows(indice).Cells(0).Value.ToString
                    End If
                    validar = 1
                    canti = 1
                    For indiceDetalle = 0 To dgvDatosAgrupadosNotasCredito.RowCount - 1
                        If dgvNotasCredito.Rows(indice).Cells(2).Value.ToString = dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(1).Value.ToString Then
                            'acumula los valores de las facturas emitidas en el periodo seleccionado de cada cliente
                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(2).Value = Math.Round(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(2).Value, 2) + Math.Round(dgvNotasCredito.Rows(indice).Cells(10).Value, 2)
                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(3).Value = Math.Round(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(3).Value, 2) + Math.Round(dgvNotasCredito.Rows(indice).Cells(11).Value, 2)
                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(5).Value = Math.Round(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(5).Value, 2) + Math.Round(dgvNotasCredito.Rows(indice).Cells(12).Value, 2)
                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(6).Value = Math.Round(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(6).Value, 2) + Math.Round(dgvNotasCredito.Rows(indice).Cells(13).Value, 2)
                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(7).Value = Math.Round(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(7).Value, 2) + Math.Round(dgvNotasCredito.Rows(indice).Cells(14).Value, 2)

                            dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(10).Value = CType(dgvDatosAgrupadosNotasCredito.Rows(indiceDetalle).Cells(10).Value, Integer) + 1

                            validar = 0
                        End If
                    Next
                    If validar = 1 Then ' si el cliente no se repite se crea un nuevo registro
                        'agrega los valores del nuevo registro de factura sin retencion por cliente
                        dgvDatosAgrupadosNotasCredito.Rows.Add(dgvNotasCredito.Rows(indice).Cells(1).Value, _
                                                               dgvNotasCredito.Rows(indice).Cells(2).Value, _
                                                               Math.Round(dgvNotasCredito.Rows(indice).Cells(10).Value, 2), _
                                                               Math.Round(dgvNotasCredito.Rows(indice).Cells(11).Value, 2), _
                                                               "0.00", _
                                                               Math.Round(dgvNotasCredito.Rows(indice).Cells(12).Value, 2), _
                                                               Math.Round(dgvNotasCredito.Rows(indice).Cells(13).Value, 2), _
                                                               Math.Round(dgvNotasCredito.Rows(indice).Cells(14).Value, 2), _
                                                               "0.00", _
                                                               "0.00", _
                                                               canti)
                    End If
                End If
            Next
        End Sub
        Private Sub ResumirCompras()
            dgvCodigosRetencionCompras.Rows.Clear()

            Dim nroRegistrosFacturasCompras = 0
            Dim tarifa0FacturasCompras As Decimal = 0
            Dim tarifa12FacturasCompras As Decimal = 0
            Dim tarifa5FacturasCompras As Decimal = 0
            Dim ivaFacturasCompras As Decimal = 0
            Dim nroRegistrosLiquidacionCompras = 0
            Dim tarifa0LiquidacionCompras As Decimal = 0
            Dim tarifa12LiquidacionCompras As Decimal = 0
            Dim ivaLiquidacionCompras As Decimal = 0
            Dim nroRegistrosNotaVentaCompras = 0
            Dim tarifa0NotaVentaCompras As Decimal = 0
            Dim tarifa12NotaVentaCompras As Decimal = 0
            Dim ivaNotaVentaCompras As Decimal = 0
            Dim nroRegistrosNotaCreditoCompras = 0
            Dim tarifa0NotaCreditoCompras As Decimal = 0
            Dim tarifa12NotaCreditoCompras As Decimal = 0
            Dim ivaNotaCreditoCompras As Decimal = 0
            Dim nroRegistrosNotaDebitoCompras = 0
            Dim tarifa0NotaDebitoCompras As Decimal = 0
            Dim tarifa12NotaDebitoCompras As Decimal = 0
            Dim ivaNotaDebitoCompras As Decimal = 0

            'retencion en la fuente del impuesto a la renta
            Dim nroRegistros302 As Decimal = 0
            Dim valorRegistros302 As Decimal = 0
            Dim nroRegistros303 As Decimal = 0
            Dim valorRegistros303 As Decimal = 0
            Dim nroRegistros304 As Decimal = 0
            Dim valorRegistros304 As Decimal = 0
            Dim nroRegistros307 As Decimal = 0
            Dim valorRegistros307 As Decimal = 0
            Dim nroRegistros308 As Decimal = 0
            Dim valorRegistros308 As Decimal = 0
            Dim nroRegistros309 As Decimal = 0
            Dim valorRegistros309 As Decimal = 0
            Dim nroRegistros310 As Decimal = 0
            Dim valorRegistros310 As Decimal = 0
            Dim nroRegistros311 As Decimal = 0
            Dim valorRegistros311 As Decimal = 0
            Dim nroRegistros312 As Decimal = 0
            Dim valorRegistros312 As Decimal = 0
            Dim nroRegistros320 As Decimal = 0
            Dim valorRegistros320 As Decimal = 0
            Dim nroRegistros322 As Decimal = 0
            Dim valorRegistros322 As Decimal = 0
            Dim nroRegistros332 As Decimal = 0
            Dim valorRegistros332 As Decimal = 0
            Dim nroRegistros340 As Decimal = 0
            Dim valorRegistros340 As Decimal = 0
            Dim nroRegistros341 As Decimal = 0
            Dim valorRegistros341 As Decimal = 0
            Dim nroRegistros342 As Decimal = 0
            Dim valorRegistros342 As Decimal = 0
            Dim nroRegistros343 As Decimal = 0
            Dim valorRegistros343 As Decimal = 0
            Dim nroRegistros344 As Decimal = 0
            Dim valorRegistros344 As Decimal = 0

            Dim nroRegistros346 As Decimal = 0
            Dim valorRegistros346 As Decimal = 0
            Dim nroRegistros350 As Decimal = 0
            Dim valorRegistros350 As Decimal = 0

            Dim nroRegistros403 As Decimal = 0
            Dim valorRegistros403 As Decimal = 0
            Dim nroRegistros405 As Decimal = 0
            Dim valorRegistros405 As Decimal = 0
            Dim nroRegistros421 As Decimal = 0
            Dim valorRegistros421 As Decimal = 0
            Dim nroRegistros0 As Decimal = 0

            'total retencion a la renta acumulado pr por porcentaje
            Dim unoPorciento As Decimal = 0
            Dim unoSetentayCincoPorciento As Decimal = 0
            Dim dosPorciento As Decimal = 0
            Dim dosSetentayCincoPorciento As Decimal = 0
            Dim ochoPorciento As Decimal = 0
            Dim diezPorciento As Decimal = 0

            'retencion en la fuente del iva
            Dim valorRetencion10 As Decimal = 0
            Dim valorRetencion20 As Decimal = 0
            Dim valorRetencionBienes As Decimal = 0
            Dim valorRetencionServicios As Decimal = 0
            Dim valorRetencion100 As Decimal = 0

            _comprasFacturas = ""
            _comprasLiquidaciones = ""
            _comprasNotasVenta = ""
            _comprasNotasCredito = ""

            'recorre la tablas de compras del rango consultado
            For indiceCompCompra = 0 To dgvComprasATS.Rows.Count - 1
                ' separa las compras por tipo de documento y acumula los valores de cada tipo
                If dgvComprasATS.Rows(indiceCompCompra).Cells(3).Value = "FACTURA" Then
                    nroRegistrosFacturasCompras = nroRegistrosFacturasCompras + 1
                    tarifa0FacturasCompras = tarifa0FacturasCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(9).Value
                    tarifa12FacturasCompras = tarifa12FacturasCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(8).Value
                    tarifa5FacturasCompras = tarifa5FacturasCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(20).Value
                    ivaFacturasCompras = ivaFacturasCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(12).Value
                    If _comprasFacturas = "" Then
                        _comprasFacturas = dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    Else
                        _comprasFacturas = _comprasFacturas + "," + dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    End If
                ElseIf dgvComprasATS.Rows(indiceCompCompra).Cells(3).Value = "LIQUIDACION DE COMPRA DE BIENES O PRESTACION DE SERVICIOS" Then
                    nroRegistrosLiquidacionCompras = nroRegistrosLiquidacionCompras + 1
                    tarifa0LiquidacionCompras = tarifa0LiquidacionCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(9).Value
                    tarifa12LiquidacionCompras = tarifa12LiquidacionCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(8).Value
                    ivaLiquidacionCompras = ivaLiquidacionCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(12).Value
                    If _comprasLiquidaciones = "" Then
                        _comprasLiquidaciones = dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    Else
                        _comprasLiquidaciones = _comprasLiquidaciones + "," + dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    End If
                ElseIf dgvComprasATS.Rows(indiceCompCompra).Cells(3).Value = "NOTA DE VENTA" Then
                    nroRegistrosNotaVentaCompras = nroRegistrosNotaVentaCompras + 1
                    tarifa0NotaVentaCompras = tarifa0NotaVentaCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(9).Value
                    tarifa12NotaVentaCompras = tarifa12NotaVentaCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(8).Value
                    ivaNotaVentaCompras = ivaNotaVentaCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(12).Value
                    If _comprasNotasVenta = "" Then
                        _comprasNotasVenta = dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    Else
                        _comprasNotasVenta = _comprasNotasVenta + "," + dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    End If
                ElseIf dgvComprasATS.Rows(indiceCompCompra).Cells(3).Value = "NOTA DE CREDITO" Then
                    nroRegistrosNotaCreditoCompras = nroRegistrosNotaCreditoCompras + 1
                    tarifa0NotaCreditoCompras = tarifa0NotaCreditoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(9).Value
                    tarifa12NotaCreditoCompras = tarifa12NotaCreditoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(8).Value
                    ivaNotaCreditoCompras = ivaNotaCreditoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(12).Value
                    If _comprasNotasCredito = "" Then
                        _comprasNotasCredito = dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    Else
                        _comprasNotasCredito = _comprasNotasCredito + "," + dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value.ToString
                    End If
                ElseIf dgvComprasATS.Rows(indiceCompCompra).Cells(3).Value = "NOTA DE DEBITO" Then
                    nroRegistrosNotaDebitoCompras = nroRegistrosNotaDebitoCompras + 1
                    tarifa0NotaDebitoCompras = tarifa0NotaDebitoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(9).Value
                    tarifa12NotaDebitoCompras = tarifa12NotaDebitoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(8).Value
                    ivaNotaDebitoCompras = ivaNotaDebitoCompras + dgvComprasATS.Rows(indiceCompCompra).Cells(12).Value

                End If

                ' busca si los comprobantes de compra tienen retencion y va acumulando los valores
                lblIdComprobanteCompra.Text = dgvComprasATS.Rows(indiceCompCompra).Cells(0).Value
                CargarDetalleComprobanteRetencionCompra()
                If dgvDetalleComprobanteRetencionCompra.Rows.Count > 0 Then
                    'retenciones en la fuente del iva
                    For indiceDetallRetCompra = 0 To dgvDetalleComprobanteRetencionCompra.Rows.Count - 1
                        If dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(4).Value = "IVA" Then 'pregunta si el impuesto retenido es el IVA
                            'segun el codigo lo sepra en Bienes, Servicios y 100%
                            Select Case CDec(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(5).Value)
                                Case 10 ' 10%
                                    valorRetencion10 = valorRetencion10 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                Case 20 ' 20%
                                    valorRetencion20 = valorRetencion20 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                Case 30 '30% (Bienes)
                                    valorRetencionBienes = valorRetencionBienes + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                Case 70  ' 70% (Servicios)
                                    valorRetencionServicios = valorRetencionServicios + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                Case 100 ' 100%
                                    valorRetencion100 = valorRetencion100 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                Case Else
                                    valorRetencion100 = valorRetencion100 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                            End Select
                        End If

                        If dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(4).Value = "RENTA" Then
                            Select Case dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(2).Value.ToString ' selecciona  y acumula los valores de acuerdo al codigo de renta de la retencion
                                Case "302"
                                    nroRegistros302 = nroRegistros302 + 1
                                    valorRegistros302 = valorRegistros302 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case "303" ' 10%
                                    nroRegistros303 = nroRegistros303 + 1
                                    valorRegistros303 = valorRegistros303 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    diezPorciento = diezPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.1)
                                Case "304" ' 8%
                                    nroRegistros304 = nroRegistros304 + 1
                                    valorRegistros304 = valorRegistros304 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    ochoPorciento = ochoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.08)
                                Case "307" ' 2%
                                    nroRegistros307 = nroRegistros307 + 1
                                    valorRegistros307 = valorRegistros307 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    dosPorciento = dosPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.02)
                                Case "308" ' 10%
                                    nroRegistros308 = nroRegistros308 + 1
                                    valorRegistros308 = valorRegistros308 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    diezPorciento = diezPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.02)
                                Case "309" ' 1%
                                    nroRegistros309 = nroRegistros309 + 1
                                    valorRegistros309 = valorRegistros309 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoSetentayCincoPorciento = unoSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.01)
                                Case "310" ' 1%
                                    nroRegistros310 = nroRegistros310 + 1
                                    valorRegistros310 = valorRegistros310 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoPorciento = unoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.01)
                                Case "311" ' 2%
                                    nroRegistros311 = nroRegistros311 + 1
                                    valorRegistros311 = valorRegistros311 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    dosPorciento = dosPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.01)
                                Case "312" ' 1%
                                    nroRegistros312 = nroRegistros312 + 1
                                    valorRegistros312 = valorRegistros312 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoSetentayCincoPorciento = unoSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.0175)
                                Case "320" ' 8%
                                    nroRegistros320 = nroRegistros320 + 1
                                    valorRegistros320 = valorRegistros320 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    ochoPorciento = ochoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.08)
                                Case "322" ' 1.75%
                                    nroRegistros322 = nroRegistros322 + 1
                                    valorRegistros322 = valorRegistros322 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoSetentayCincoPorciento = unoSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.0175)
                                Case "332" ' 0%
                                    nroRegistros332 = nroRegistros332 + 1
                                    valorRegistros332 = valorRegistros332 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case "340" ' 1%
                                    nroRegistros340 = nroRegistros340 + 1
                                    valorRegistros340 = valorRegistros340 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoPorciento = unoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.01)
                                Case "341" ' 2%
                                    nroRegistros341 = nroRegistros341 + 1
                                    valorRegistros341 = valorRegistros341 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    dosPorciento = dosPorciento + dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.02)
                                Case "342" ' 8%
                                    nroRegistros342 = nroRegistros342 + 1
                                    valorRegistros342 = valorRegistros342 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    ochoPorciento = ochoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.08)
                                Case "343" ' 1%
                                    nroRegistros343 = nroRegistros343 + 1
                                    valorRegistros343 = valorRegistros343 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoSetentayCincoPorciento = unoSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.0175)
                                Case "346" ' 1.75%
                                    nroRegistros346 = nroRegistros346 + 1
                                    valorRegistros346 = valorRegistros346 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    unoSetentayCincoPorciento = unoSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.0175)

                                Case "350" ' 2%
                                    nroRegistros350 = nroRegistros350 + 1
                                    valorRegistros350 = valorRegistros350 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    dosPorciento = dosPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero) '(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value * 0.02)

                                Case "3440" ' 2%
                                    nroRegistros344 = nroRegistros344 + 1
                                    valorRegistros344 = valorRegistros344 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                    dosSetentayCincoPorciento = dosSetentayCincoPorciento + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case "403" ' 22%
                                    nroRegistros403 = nroRegistros403 + 1
                                    valorRegistros403 = valorRegistros403 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case "405" ' 22%
                                    nroRegistros405 = nroRegistros405 + 1
                                    valorRegistros405 = valorRegistros405 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case "421" ' 22%
                                    nroRegistros421 = nroRegistros421 + 1
                                    valorRegistros421 = valorRegistros421 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, 2, MidpointRounding.AwayFromZero)
                                Case Else
                            End Select

                        End If

                        ' carga el detalle de retencion de los comprobantes de compra que tengan
                        dgvCodigosRetencionCompras.Rows.Add(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(0).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(1).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(2).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(3).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(4).Value, _
                                    If(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(5).Value.ToString().EndsWith(".00"),
                                        CInt(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(5).Value),
                                        CDec(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(5).Value)), _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(6).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(7).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(8).Value, _
                                                            dgvDetalleComprobanteRetencionCompra.Rows(indiceDetallRetCompra).Cells(9).Value)
                    Next
                Else
                    nroRegistros0 = nroRegistros0 + 1
                End If
            Next
            'compras
            txtNroRegistrosFacturasCompras.Text = nroRegistrosFacturasCompras
            txtTarifa0FacturaCompras.Text = tarifa0FacturasCompras
            txtTarifa12FacturasCompras.Text = tarifa12FacturasCompras + tarifa5FacturasCompras
            txtIvaFacturasCompras.Text = ivaFacturasCompras

            txtNroRegistrosLiquidacionCompras.Text = nroRegistrosLiquidacionCompras : txtTarifa0LiquidacionCompras.Text = tarifa0LiquidacionCompras : txtTarifa12LiquidacionCompras.Text = tarifa12LiquidacionCompras : txtIvaLiquidacionCompras.Text = ivaLiquidacionCompras
            txtNroRegistrosNotasVentaCompras.Text = nroRegistrosNotaVentaCompras : txtTarifa0NotaVentaCompras.Text = tarifa0NotaVentaCompras : txtTarifa12NotaVentaCompras.Text = tarifa12NotaVentaCompras : txtIvaNotaVentaCompras.Text = ivaNotaVentaCompras
            TextBox81.Text = nroRegistrosNotaCreditoCompras : TextBox80.Text = tarifa0NotaCreditoCompras : TextBox79.Text = tarifa12NotaCreditoCompras : TextBox78.Text = ivaNotaCreditoCompras
            TextBox85.Text = nroRegistrosNotaDebitoCompras : TextBox84.Text = tarifa0NotaDebitoCompras : TextBox83.Text = tarifa12NotaDebitoCompras : TextBox82.Text = ivaNotaDebitoCompras
            '' totales compras
            '-- nro registros
            TextBox70.Text = CType(txtNroRegistrosFacturasCompras.Text, Decimal) + CType(txtNroRegistrosLiquidacionCompras.Text, Decimal) + CType(txtNroRegistrosNotasVentaCompras.Text, Decimal) + CType(TextBox81.Text, Decimal) + CType(TextBox85.Text, Decimal)
            '-- no objeto de iva
            TextBox69.Text = (CType(txtTarifa0FacturaCompras.Text, Decimal) + CType(txtTarifa0LiquidacionCompras.Text, Decimal) + CType(txtTarifa0NotaVentaCompras.Text, Decimal) + CType(TextBox84.Text, Decimal)) - CType(TextBox80.Text, Decimal) 'menos nota de credito
            '-- tarifa 12 %
            TextBox68.Text = (CType(txtTarifa12FacturasCompras.Text, Decimal) + CType(txtTarifa12LiquidacionCompras.Text, Decimal) + CType(txtTarifa12NotaVentaCompras.Text, Decimal) + CType(TextBox83.Text, Decimal)) - CType(TextBox79.Text, Decimal) 'menos nota de credito
            '-- valor iva
            lblIvaTotalCompras.Text = (CType(txtIvaFacturasCompras.Text, Decimal) + CType(txtIvaLiquidacionCompras.Text, Decimal) + CType(txtIvaNotaVentaCompras.Text, Decimal) + CType(TextBox82.Text, Decimal)) - CType(TextBox78.Text, Decimal) 'menos nota de credito

            'retencion en la fuente del impuesto a la renta
            TextBox9.Text = nroRegistros302 : TextBox6.Text = valorRegistros302
            TextBox8.Text = nroRegistros303 : TextBox5.Text = valorRegistros303 : TextBox2.Text = (TextBox5.Text * 10) / 100
            TextBox7.Text = nroRegistros304 : TextBox4.Text = valorRegistros304 : TextBox1.Text = (TextBox4.Text * 8) / 100
            TextBox54.Text = nroRegistros307 : TextBox51.Text = valorRegistros307 : TextBox48.Text = (TextBox51.Text * 2) / 100
            TextBox53.Text = nroRegistros308 : TextBox50.Text = valorRegistros308 : TextBox47.Text = (TextBox50.Text * 10) / 100
            TextBox52.Text = nroRegistros309 : TextBox49.Text = valorRegistros309 : TextBox46.Text = (TextBox49.Text * 1.75) / 100
            TextBox18.Text = nroRegistros310 : TextBox15.Text = valorRegistros310 : TextBox12.Text = (TextBox15.Text * 1) / 100
            TextBox94.Text = nroRegistros311 : TextBox93.Text = valorRegistros311 : TextBox92.Text = (TextBox93.Text * 2) / 100
            TextBox17.Text = nroRegistros312 : TextBox14.Text = valorRegistros312 : TextBox11.Text = (TextBox14.Text * 1.75) / 100
            TextBox16.Text = nroRegistros320 : TextBox13.Text = valorRegistros320 : TextBox10.Text = (TextBox13.Text * 8) / 100
            TextBox45.Text = nroRegistros322 : TextBox42.Text = valorRegistros322 : TextBox39.Text = (TextBox42.Text * 1.75) / 100
            TextBox44.Text = nroRegistros332 : TextBox41.Text = valorRegistros332 : TextBox38.Text = (TextBox41.Text * 0) / 100
            TextBox43.Text = nroRegistros340 : TextBox40.Text = valorRegistros340 : TextBox37.Text = (TextBox40.Text * 1) / 100
            TextBox27.Text = nroRegistros341 : TextBox24.Text = valorRegistros341 : TextBox21.Text = (TextBox24.Text * 2) / 100
            TextBox26.Text = nroRegistros342 : TextBox23.Text = valorRegistros342 : TextBox20.Text = (TextBox23.Text * 8) / 100
            TextBox25.Text = nroRegistros343 : TextBox22.Text = valorRegistros343 : TextBox19.Text = (TextBox22.Text * 1) / 100
            TextBox97.Text = nroRegistros344 : TextBox96.Text = valorRegistros344 : TextBox95.Text = (TextBox96.Text * 2.75) / 100
            ' NO HAY 346 - 350
            TextBox36.Text = nroRegistros403 : TextBox33.Text = valorRegistros403 : TextBox30.Text = (TextBox33.Text * 22) / 100
            TextBox35.Text = nroRegistros405 : TextBox32.Text = valorRegistros405 : TextBox29.Text = (TextBox32.Text * 22) / 100
            TextBox34.Text = nroRegistros421 : TextBox31.Text = valorRegistros421 : TextBox28.Text = (TextBox31.Text * 22) / 100
            ''totales retencion impuesto a la renta
            TextBox77.Text = CType(TextBox2.Text, Decimal) + CType(TextBox1.Text, Decimal) + CType(TextBox48.Text, Decimal) + CType(TextBox47.Text, Decimal) + CType(TextBox46.Text, Decimal) + CType(TextBox12.Text, Decimal) + CType(TextBox92.Text, Decimal) + CType(TextBox11.Text, Decimal) + CType(TextBox10.Text, Decimal) + CType(TextBox39.Text, Decimal) + CType(TextBox38.Text, Decimal) + CType(TextBox37.Text, Decimal) + CType(TextBox21.Text, Decimal) + CType(TextBox20.Text, Decimal) + CType(TextBox19.Text, Decimal) + CType(TextBox95.Text, Decimal) + CType(TextBox30.Text, Decimal) + CType(TextBox29.Text, Decimal) + CType(TextBox28.Text, Decimal)
            'retencion en la fuente del iva
            TextBox90.Text = valorRetencion10
            TextBox91.Text = valorRetencion20
            TextBox64.Text = valorRetencionBienes
            TextBox63.Text = valorRetencionServicios
            TextBox65.Text = valorRetencion100
            ''totales retencion en la fuente iva
            TextBox75.Text = CType(TextBox90.Text, Decimal) + CType(TextBox91.Text, Decimal) + CType(TextBox63.Text, Decimal) + CType(TextBox64.Text, Decimal) + CType(TextBox65.Text, Decimal)
            lblSinRetencion.Text = nroRegistros0
            ''totales renta por porcentaje 
            TextBox86.Text = (unoPorciento * 0.01)
            TextBox103.Text = (unoSetentayCincoPorciento * 0.0175)
            TextBox87.Text = (dosPorciento * 0.02)
            TextBox102.Text = (dosSetentayCincoPorciento * 0.0275)
            TextBox88.Text = (ochoPorciento * 0.08)
            TextBox89.Text = (diezPorciento * 0.1)
        End Sub
        Private Sub ResumirVentas()
            Dim nroRegistrosFacturasVentas = 0
            Dim tarifa0FacturasVentas As Decimal = 0
            Dim tarifa12FacturasVentas As Decimal = 0
            Dim ivaFacturasVentas As Decimal = 0
            Dim nroRegistrosAnulados = 0
            Dim valorRetencionesIvaEfectuaron As Decimal = 0
            Dim valorRetencionesRentaEfectuaron As Decimal = 0
            Dim valorRetencionesTotalEfectuaron As Decimal = 0

            'recorre la tablas de ventas del rango consultado
            For indiceFacturaVenta = 0 To dgvVentasATS.Rows.Count - 1
                ' separa las ventas por anuladas y validas
                If dgvVentasATS.Rows(indiceFacturaVenta).Cells(11).Value = "0" Then
                    nroRegistrosAnulados = nroRegistrosAnulados + 1
                Else
                    nroRegistrosFacturasVentas = nroRegistrosFacturasVentas + 1
                    tarifa0FacturasVentas = CType(tarifa0FacturasVentas, Decimal) + CType(dgvVentasATS.Rows(indiceFacturaVenta).Cells(5).Value, Decimal)
                    tarifa12FacturasVentas = Math.Round(CType(tarifa12FacturasVentas, Decimal), 2) + Math.Round(CType(dgvVentasATS.Rows(indiceFacturaVenta).Cells(6).Value, Decimal), 2)
                    ivaFacturasVentas = CType(ivaFacturasVentas, Decimal) + CType(dgvVentasATS.Rows(indiceFacturaVenta).Cells(9).Value, Decimal)
                    ' busca si las facturas tienen retencion y va acumulando los valores
                    lblIdFacturaVenta.Text = dgvVentasATS.Rows(indiceFacturaVenta).Cells(0).Value
                    dgvDetalleComprobanteRetencionVenta.DataSource = _objetoDetalleComprobanteRetencionVentas.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)

                    If dgvDetalleComprobanteRetencionVenta.Rows.Count > 0 Then
                        For indiceDetalleRetFactura = 0 To dgvDetalleComprobanteRetencionVenta.RowCount - 1
                            If dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetFactura).Cells(4).Value = "IVA" Then
                                valorRetencionesIvaEfectuaron = Math.Round(CType(valorRetencionesIvaEfectuaron, Decimal), 2) + Math.Round(CType(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetFactura).Cells(6).Value, Decimal), 2)
                            Else
                                valorRetencionesRentaEfectuaron = Math.Round(CType(valorRetencionesRentaEfectuaron, Decimal), 2) + Math.Round(CType(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetFactura).Cells(6).Value, Decimal), 2)
                            End If

                            valorRetencionesTotalEfectuaron = Math.Round(CType(valorRetencionesTotalEfectuaron, Decimal), 2) + Math.Round(CType(dgvDetalleComprobanteRetencionVenta.Rows(indiceDetalleRetFactura).Cells(6).Value, Decimal), 2)
                        Next
                    End If
                End If
            Next
            'ventas
            TextBox61.Text = nroRegistrosFacturasVentas
            TextBox59.Text = tarifa0FacturasVentas
            TextBox57.Text = tarifa12FacturasVentas
            TextBox55.Text = ivaFacturasVentas
            '' totales ventas 
            TextBox73.Text = CType(TextBox62.Text, Decimal) + CType(TextBox61.Text, Decimal)
            TextBox71.Text = CType(TextBox59.Text, Decimal) - CType(TextBox60.Text, Decimal)
            TextBox74.Text = CType(TextBox57.Text, Decimal) - CType(TextBox58.Text, Decimal)
            TextBox72.Text = CType(TextBox55.Text, Decimal) - CType(TextBox56.Text, Decimal)
            'comprobantes anulados
            TextBox66.Text = nroRegistrosAnulados
            'total retenciones que le efectuaron
            TextBox98.Text = valorRetencionesIvaEfectuaron
            TextBox99.Text = valorRetencionesRentaEfectuaron
            TextBox76.Text = valorRetencionesTotalEfectuaron
        End Sub
        Private Sub ResumirNotasCredito()
            Dim nroRegistrosNotasCredito = 0
            Dim tarifa0NotasCredito As Decimal = 0
            Dim tarifa12NotasCredito As Decimal = 0
            Dim ivaNotasCredito As Decimal = 0

            'recorre la tablas de compras del rango consultado
            For indiceNotasCredito = 0 To dgvNotasCredito.Rows.Count - 1
                ' separa las compras por tipo de documento y acumula los valores de cada tipo
                If dgvNotasCredito.Rows(indiceNotasCredito).Cells(15).Value <> "0" Then
                    nroRegistrosNotasCredito = nroRegistrosNotasCredito + 1
                    tarifa0NotasCredito = Math.Round(tarifa0NotasCredito, 2) + Math.Round(dgvNotasCredito.Rows(indiceNotasCredito).Cells(10).Value, 2)
                    tarifa12NotasCredito = Math.Round(tarifa12NotasCredito, 2) + Math.Round(dgvNotasCredito.Rows(indiceNotasCredito).Cells(11).Value, 2)
                    ivaNotasCredito = Math.Round(ivaNotasCredito, 2) + Math.Round(dgvNotasCredito.Rows(indiceNotasCredito).Cells(13).Value, 2)
                End If
            Next
            'ventas
            TextBox62.Text = nroRegistrosNotasCredito
            TextBox60.Text = Math.Round(tarifa0NotasCredito, 2)
            TextBox58.Text = Math.Round(tarifa12NotasCredito, 2)
            TextBox56.Text = Math.Round(ivaNotasCredito, 2)
            '' totales ventas 
            TextBox73.Text = CType(TextBox62.Text, Decimal) + CType(TextBox61.Text, Decimal)
            TextBox71.Text = CType(TextBox59.Text, Decimal) - CType(TextBox60.Text, Decimal)
            TextBox74.Text = CType(TextBox57.Text, Decimal) - CType(TextBox58.Text, Decimal)
            TextBox72.Text = CType(TextBox55.Text, Decimal) - CType(TextBox56.Text, Decimal)
        End Sub
        Private Sub CargarComprobanteRetencionCompras()
            dgvComprobanteRetencionCompra.DataSource = _objetoComprobanteRetencionCompra.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))
        End Sub
        Private Sub CargarDetalleComprobanteRetencionCompra()
            dgvDetalleComprobanteRetencionCompra.DataSource = _objetoDetalleComprobanteRetencionCompra.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))
        End Sub


        Public RutaAts As String
        Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGenerarXML.Click
            If dgvComprasATS.RowCount > 0 Then

                With _objetoAnexoTransaccional
                    .Periodo = dtpFechaDesde.Value
                    .ComprasFacturas = _comprasFacturas
                    .ComprasNotasVenta = _comprasNotasVenta
                    .ComprasNotasCredito = _comprasNotasCredito
                    .ComprasLiquidaciones = _comprasLiquidaciones
                    .VentasFacturas = _ventasFacturas
                    .VentasNotasCredito = _ventasNotasCredito
                    .RetencionesCompras = _retencionesCompras
                    .FechaCreacion = Date.Now
                    .Estado = 1
                End With

                Dim res = _objetoAnexoTransaccional.NuevoRegistroAts(_tipoCon)
                If Not res Then
                    'MsgBox("Error al guardar ATS! Por favor, contácte al administrador.", MsgBoxStyle.Exclamation, "Mensaje del sistema")
                    KryptonMessageBox.Show("Error al guardar ATS! Por favor, contácte al administrador.", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                'Dim longitudidProv = ""
                Dim establecimiento = ""
                Dim puntoEmision = ""
                Dim secuencial = ""

                Dim estabRetencion = ""
                Dim ptoEmiRetencion = ""
                Dim secRetencion = ""

                Dim estabModificado = ""
                Dim ptoEmiModificado = ""
                Dim secModificado = ""

                Dim facturasAnuladas = 0
                Dim totalCompras As Decimal = 0
                Dim totalVentas As Decimal = 0
                Dim totalNotasCredito As Decimal = 0

                Dim valorRetBienes As Decimal
                Dim valRetBien10 As Decimal
                Dim valorRetServicios As Decimal
                Dim valRetServ20 As Decimal
                Dim valRetServ50 As Decimal
                Dim valRetServ100 As Decimal

                For indice = 0 To dgvComprasATS.RowCount - 1
                    totalCompras = totalCompras + dgvComprasATS.Rows(indice).Cells(11).Value
                Next
                For indiceV = 0 To dgvVentasATS.RowCount - 1
                    If dgvVentasATS.Rows(indiceV).Cells(11).Value = "0" Then
                        facturasAnuladas = facturasAnuladas + 1
                    Else

                        totalVentas = totalVentas + dgvVentasATS.Rows(indiceV).Cells(8).Value
                    End If
                Next
                For indiceNC = 0 To dgvNotasCredito.Rows.Count - 1
                    If dgvNotasCredito.Rows(indiceNC).Cells(15).Value <> 0 Then
                        totalNotasCredito = totalNotasCredito + dgvNotasCredito.Rows(indiceNC).Cells(12).Value
                    End If
                Next

                '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=CREAR XML =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                Dim obj As Object
                Dim archivo As Object

                Dim month = dtpFechaHasta.Value.Month.ToString
                Dim year = dtpFechaHasta.Value.Year.ToString

                ' fecha actual para nombre del archivo 
                Dim dia = Date.Now.Day.ToString
                Dim mes = Date.Now.Month.ToString
                Dim año = Date.Now.Year.ToString
                Dim hora = Date.Now.Hour.ToString + "_" + Date.Now.Minute.ToString

                'Dim ats As String
                Dim ruc As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        'ats = "ATS-ASENAVA"
                        ruc = ""
                    Case TipoConexion.Seportpac
                        'ats = "ATS-SEPORTPAC"
                        ruc = "0790095871001"
                    Case Else
                        'ats = "ATS2014"
                        ruc = "0790013360001"
                End Select

                obj = CreateObject("Scripting.FileSystemObject")
                Select Case month
                    Case 1
                        archivo = obj.CreateTextFile(RutaAts & "\" & "ENERO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 2
                        archivo = obj.CreateTextFile(RutaAts & "\" & "FEBRERO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 3
                        archivo = obj.CreateTextFile(RutaAts & "\" & "MARZO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 4
                        archivo = obj.CreateTextFile(RutaAts & "\" & "ABRIL " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 5
                        archivo = obj.CreateTextFile(RutaAts & "\" & "MAYO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 6
                        archivo = obj.CreateTextFile(RutaAts & "\" & "JUNIO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 7
                        archivo = obj.CreateTextFile(RutaAts & "\" & "JULIO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 8
                        archivo = obj.CreateTextFile(RutaAts & "\" & "AGOSTO " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 9
                        archivo = obj.CreateTextFile(RutaAts & "\" & "SEPTIEMBRE " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 10
                        archivo = obj.CreateTextFile(RutaAts & "\" & "OCTUBRE " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 11
                        archivo = obj.CreateTextFile(RutaAts & "\" & "NOVIEMBRE " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case 12
                        archivo = obj.CreateTextFile(RutaAts & "\" & "DICIEMBRE " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                    Case Else
                        archivo = obj.CreateTextFile(RutaAts & "\" & month + " - " + year + " - (" + dia + "-" + mes + "-" + año + " " + hora + ")" & ".xml", True)
                End Select
                archivo.writeline("<?xml version='1.0' encoding='UTF-8'?>")
                archivo.writeline("<iva>")
                ' Identificación del informante
                Dim epr = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                archivo.writeline("<TipoIDInformante>R</TipoIDInformante>")
                archivo.writeline("<IdInformante>" & ruc & "</IdInformante>")
                archivo.writeline("<razonSocial>" & epr.Rows(0)(3) & "</razonSocial>")
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

                'If _tipoCon = TipoConexion.Seportpac Then archivo.writeline("<regimenMicroempresa>SI</regimenMicroempresa>")

                archivo.writeline("<numEstabRuc>001</numEstabRuc>")
                archivo.writeline("<totalVentas>0.00</totalVentas>")
                'archivo.writeline("<totalVentas>" & Math.Round(CDec(txtTotalFacturaVentas.Text), 2) & "</totalVentas>")
                archivo.writeline("<codigoOperativo>IVA</codigoOperativo>")

                ' COMPRAS
                archivo.writeline("<compras>")
                For indiceCompras = 0 To dgvComprasATS.RowCount - 1


                    lblIdComprobanteCompra.Text = dgvComprasATS.Rows(indiceCompras).Cells(0).Value
                    CargarComprobanteRetencionCompras()
                    CargarDetalleComprobanteRetencionCompra()
                    archivo.writeline("<detalleCompras>")

                    ' TIPO DE SUSTENTO TRIBUTARIO
                    If dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "COMPROBANTE DE PAGO DE DIVIDENDO" Then
                        archivo.writeline("<codSustento>10</codSustento>") ' Tabla 5 ficha técnica ATS
                    Else
                        archivo.writeline("<codSustento>02</codSustento>") ' Tabla 5 ficha técnica ATS
                    End If

                    Dim td = dgvComprasATS.Rows(indiceCompras).Cells(18).Value.ToString.Trim
                    If td.Equals("CED") Then
                        archivo.writeline("<tpIdProv>02</tpIdProv>")
                    ElseIf td.Equals("RUC") Then
                        archivo.writeline("<tpIdProv>01</tpIdProv>")
                    Else
                        archivo.writeline("<tpIdProv>03</tpIdProv>")
                    End If

                    archivo.writeline("<idProv>" & dgvComprasATS.Rows(indiceCompras).Cells(1).Value & "</idProv>")
                    If dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "FACTURA" Then
                        archivo.writeline("<tipoComprobante>01</tipoComprobante>")
                    ElseIf dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "NOTA DE VENTA" Then
                        archivo.writeline("<tipoComprobante>02</tipoComprobante>")
                    ElseIf dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "LIQUIDACION DE COMPRA DE BIENES O PRESTACION DE SERVICIOS" Then
                        archivo.writeline("<tipoComprobante>03</tipoComprobante>")
                        'aumentar claves
                        If td.Equals("PAS") Then
                            archivo.writeline("<tipoProv>" & If(dgvComprasATS.Rows(indiceCompras).Cells(18).Value.ToString.Trim.Equals("PN"), "01", "02") & "</tipoProv>")
                            archivo.writeline("<denoProv>" & dgvComprasATS.Rows(indiceCompras).Cells(2).Value & "</denoProv>")
                        End If
                    ElseIf dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "NOTA DE CREDITO" Then
                        archivo.writeline("<tipoComprobante>04</tipoComprobante>")
                    ElseIf dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "NOTA DE DEBITO" Then
                        archivo.writeline("<tipoComprobante>05</tipoComprobante>")
                    ElseIf dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "COMPROBANTE DE PAGO DE DIVIDENDO" Then
                        archivo.writeline("<tipoComprobante>19</tipoComprobante>")
                    Else
                        archivo.writeline("<tipoComprobante>01</tipoComprobante>")
                    End If

                    If dtpFechaDesde.Value >= "01-06-2016 00:00:01" Then
                        archivo.writeline("<parteRel>NO</parteRel>")
                    End If
                    archivo.writeline("<fechaRegistro>" & Format(dgvComprasATS.Rows(indiceCompras).Cells(5).Value, "dd/MM/yyyy") & "</fechaRegistro>")
                    establecimiento = Mid(dgvComprasATS.Rows(indiceCompras).Cells(4).Value, 1, 3)
                    archivo.writeline("<establecimiento>" & establecimiento & "</establecimiento>")
                    puntoEmision = Mid(dgvComprasATS.Rows(indiceCompras).Cells(4).Value, 4, 3)
                    archivo.writeline("<puntoEmision>" & puntoEmision & "</puntoEmision>")
                    secuencial = Mid(dgvComprasATS.Rows(indiceCompras).Cells(4).Value, 7)
                    archivo.writeline("<secuencial>" & secuencial & "</secuencial>")
                    archivo.writeline("<fechaEmision>" & Format(dgvComprasATS.Rows(indiceCompras).Cells(5).Value, "dd/MM/yyyy") & "</fechaEmision>")
                    archivo.writeline("<autorizacion>" & dgvComprasATS.Rows(indiceCompras).Cells(7).Value & "</autorizacion>")
                    archivo.writeline("<baseNoGraIva>" & dgvComprasATS.Rows(indiceCompras).Cells(9).Value & "</baseNoGraIva>")
                    archivo.writeline("<baseImponible>0.00</baseImponible>")
                    archivo.writeline("<baseImpGrav>" & dgvComprasATS.Rows(indiceCompras).Cells(8).Value & "</baseImpGrav>")
                    archivo.writeline("<baseImpExe>0.00</baseImpExe>")
                    archivo.writeline("<montoIce>0.00</montoIce>")

                    archivo.writeline("<montoIva>" & dgvComprasATS.Rows(indiceCompras).Cells(12).Value & "</montoIva>")

                    valRetBien10 = 0.0
                    valRetServ20 = 0.0
                    valRetServ50 = 0.0
                    valorRetBienes = 0.0
                    valorRetServicios = 0.0
                    valRetServ100 = 0.0
                    If dgvDetalleComprobanteRetencionCompra.RowCount > 0 Then
                        For indiceDetalleIva = 0 To dgvDetalleComprobanteRetencionCompra.RowCount - 1
                            If dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(4).Value.ToString = "IVA" Then
                                Select Case CDec(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(5).Value)
                                    Case 10 : valRetBien10 = valRetBien10 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case 20 : valRetServ20 = valRetServ20 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case 50 : valRetServ20 = valRetServ20 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case 30 : valorRetBienes = valorRetBienes + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case 70 : valorRetServicios = valorRetServicios + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case 100 : valRetServ100 = valRetServ100 + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                    Case Else : valorRetBienes = valorRetBienes + Math.Round(dgvDetalleComprobanteRetencionCompra.Rows(indiceDetalleIva).Cells(6).Value, 2, MidpointRounding.AwayFromZero)
                                End Select
                            End If
                        Next
                    End If
                    If dtpFechaDesde.Value >= "01-06-2015 00:00:01" Then
                        archivo.writeline("<valRetBien10>" & valRetBien10 & "</valRetBien10>")
                        archivo.writeline("<valRetServ20>" & valRetServ20 & "</valRetServ20>")
                    End If
                    archivo.writeline("<valorRetBienes>" & valorRetBienes & "</valorRetBienes>")
                    archivo.writeline("<valRetServ50>" & valRetServ50 & "</valRetServ50>")
                    archivo.writeline("<valorRetServicios>" & valorRetServicios & "</valorRetServicios>")
                    archivo.writeline("<valRetServ100>" & valRetServ100 & "</valRetServ100>")
                    archivo.writeline("<totbasesImpReemb>00.00</totbasesImpReemb>")
                    archivo.writeline("<pagoExterior>")
                    archivo.writeline("<pagoLocExt>01</pagoLocExt>")
                    archivo.writeline("<paisEfecPago>NA</paisEfecPago>")
                    archivo.writeline("<aplicConvDobTrib>NA</aplicConvDobTrib>")
                    archivo.writeline("<pagExtSujRetNorLeg>NA</pagExtSujRetNorLeg>")
                    archivo.writeline("</pagoExterior>")
                    If Convert.ToDecimal(dgvComprasATS.Rows(indiceCompras).Cells(13).Value) > Convert.ToDecimal(999.99) Then
                        archivo.writeline("<formasDePago>")
                        archivo.writeline("<formaPago>01</formaPago>")
                        archivo.writeline("</formasDePago>")
                    End If

                    archivo.writeline("<air>")
                    For indiceDetalleRenta = 0 To dgvCodigosRetencionCompras.RowCount - 1
                        If dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(4).Value.ToString = "RENTA" Then
                            If dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(9).Value = lblIdComprobanteCompra.Text Then
                                Dim valRetAir = Math.Round(dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(6).Value, 2)
                                archivo.writeline("<detalleAir>")
                                archivo.writeline("<codRetAir>" & dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(2).Value & "</codRetAir>")
                                archivo.writeline("<baseImpAir>" & dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(3).Value & "</baseImpAir>")
                                archivo.writeline("<porcentajeAir>" & dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(5).Value & "</porcentajeAir>")
                                archivo.writeline("<valRetAir>" & String.Format("{0:F2}", valRetAir) & "</valRetAir>")


                                ' pago de dividendos
                                If dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "COMPROBANTE DE PAGO DE DIVIDENDO" Then
                                    Select Case dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(2).Value.ToString
                                        Case "327", "330", "504A", "504D"
                                            archivo.writeline("<fechaPagoDiv>" & Format(dgvComprasATS.Rows(indiceCompras).Cells(5).Value, "dd/MM/yyyy") & "</fechaPagoDiv>")
                                            archivo.writeline("<imRentaSoc>" & dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(3).Value & "</imRentaSoc>")
                                            archivo.writeline("<anioUtDiv>" & 2010 & "</anioUtDiv>")
                                    End Select
                                End If

                                Select Case dgvCodigosRetencionCompras.Rows(indiceDetalleRenta).Cells(2).Value.ToString
                                    Case "338", "340", "341", "342", "342A", "342B", "327", "330", "504", "504D", "3440"
                                        archivo.writeline("<numCajBan>0</numCajBan>")
                                        archivo.writeline("<precCajBan>0</precCajBan>")
                                End Select

                                archivo.writeline("</detalleAir>")
                            End If
                        End If
                    Next
                    archivo.writeline("</air>")

                    For indiceCompRet = 0 To dgvComprobanteRetencionCompra.RowCount - 1
                        If dgvComprobanteRetencionCompra.RowCount > 0 Then
                            If CType(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, Int64) = 0 Then
                                archivo.writeline("<estabRetencion1>001</estabRetencion1>")
                                archivo.writeline("<ptoEmiRetencion1>001</ptoEmiRetencion1>")
                                archivo.writeline("<secRetencion1>000000001</secRetencion1>")
                                archivo.writeline("<autRetencion1>" & dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(2).Value & "</autRetencion1>")
                                archivo.writeline("<fechaEmiRet1>" & Format(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(4).Value, "dd/MM/yyyy") & "</fechaEmiRet1>")
                            Else
                                estabRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 1, 3)
                                archivo.writeline("<estabRetencion1>" & estabRetencion & "</estabRetencion1>")
                                ptoEmiRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 4, 3)
                                archivo.writeline("<ptoEmiRetencion1>" & ptoEmiRetencion & "</ptoEmiRetencion1>")
                                secRetencion = Mid(dgvComprobanteRetencionCompra.Rows(indiceCompRet).Cells(1).Value, 7)
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

                    secModificado = Mid(dgvComprasATS.Rows(indiceCompras).Cells(15).Value, 7)

                    'pregunta si el documento es NOTA DE CREDITO agrega la informacion correspondiente
                    If dgvComprasATS.Rows(indiceCompras).Cells(3).Value = "NOTA DE CREDITO" Then
                        archivo.writeline("<docModificado>01</docModificado>")
                        estabModificado = Mid(dgvComprasATS.Rows(indiceCompras).Cells(15).Value, 1, 3)
                        archivo.writeline("<estabModificado>" & estabModificado & "</estabModificado>")

                        ptoEmiModificado = Mid(dgvComprasATS.Rows(indiceCompras).Cells(15).Value, 4, 3)
                        archivo.writeline("<ptoEmiModificado>" & ptoEmiModificado & "</ptoEmiModificado>")
                        archivo.writeline("<secModificado>" & secModificado & "</secModificado>")
                        archivo.writeline("<autModificado>" & dgvComprasATS.Rows(indiceCompras).Cells(16).Value & "</autModificado>")
                    Else ' caso contrario llena en blanco
                        archivo.writeline("<docModificado>01</docModificado>")
                        archivo.writeline("<estabModificado>000</estabModificado>")
                        archivo.writeline("<ptoEmiModificado>000</ptoEmiModificado>")
                        archivo.writeline("<secModificado>0</secModificado>")
                        archivo.writeline("<autModificado>000</autModificado>")
                    End If

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
                    Else
                        archivo.writeline("<tpIdCliente>05</tpIdCliente>")
                    End If
                    archivo.writeline("<idCliente>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(1).Value & "</idCliente>")
                    archivo.writeline("<parteRelVtas>NO</parteRelVtas>")
                    archivo.writeline("<tipoComprobante>18</tipoComprobante>")
                    archivo.writeline("<tipoEmision>E</tipoEmision>")
                    archivo.writeline("<numeroComprobantes>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(10).Value & "</numeroComprobantes>")
                    archivo.writeline("<baseNoGraIva>0.00</baseNoGraIva>")
                    archivo.writeline("<baseImponible>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(2).Value & "</baseImponible>")
                    archivo.writeline("<baseImpGrav>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(3).Value & "</baseImpGrav>")
                    archivo.writeline("<montoIva>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(6).Value & "</montoIva>")
                    archivo.writeline("<montoIce>0.00</montoIce>")
                    archivo.writeline("<valorRetIva>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(8).Value & "</valorRetIva>")
                    archivo.writeline("<valorRetRenta>" & dgvDatosAgrupadosVentas.Rows(indiceVentas).Cells(9).Value & "</valorRetRenta>")
                    If dtpFechaDesde.Value >= "01-06-2016 00:00:01" Then
                        '01 SIN UTILIZACION DEL SISTEMA FINANCIERO - 02 CHEQUE PROPIO - 03 CHEQUE CERTIFICADO - 04 CHEQUE DE GERENCIA - 
                        '05 CHEQUE DEL EXTERIOR - 06 DEBITO DE CUENTA - 07 TRANSFERENCIA PROPIO BANCO - 08 TRANSFERENCIA OTRO BANCO NACIONAL
                        archivo.writeline("<formasDePago>")
                        archivo.writeline("<formaPago>01</formaPago>")
                        archivo.writeline("</formasDePago>")
                    End If
                    archivo.writeline("</detalleVentas>")
                Next
                For indiceNotaCredito = 0 To dgvDatosAgrupadosNotasCredito.Rows.Count - 1
                    archivo.writeline("<detalleVentas>")
                    If dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(0).Value = "RUC" Then
                        archivo.writeline("<tpIdCliente>04</tpIdCliente>")
                    ElseIf dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(0).Value = "CEDULA" Then
                        archivo.writeline("<tpIdCliente>05</tpIdCliente>")
                    End If
                    archivo.writeline("<idCliente>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(1).Value & "</idCliente>")
                    archivo.writeline("<parteRelVtas>NO</parteRelVtas>")
                    archivo.writeline("<tipoComprobante>04</tipoComprobante>")
                    archivo.writeline("<tipoEmision>E</tipoEmision>")
                    archivo.writeline("<numeroComprobantes>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(10).Value & "</numeroComprobantes>")
                    archivo.writeline("<baseNoGraIva>0.00</baseNoGraIva>")
                    archivo.writeline("<baseImponible>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(2).Value & "</baseImponible>")
                    archivo.writeline("<baseImpGrav>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(3).Value & "</baseImpGrav>")
                    archivo.writeline("<montoIva>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(6).Value & "</montoIva>")
                    archivo.writeline("<montoIce>0.00</montoIce>")
                    archivo.writeline("<valorRetIva>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(8).Value & "</valorRetIva>")
                    archivo.writeline("<valorRetRenta>" & dgvDatosAgrupadosNotasCredito.Rows(indiceNotaCredito).Cells(9).Value & "</valorRetRenta>") ' formato del impuesto a la renta para en caso de 1 decimal aumente a 2 (cero a la derecha)
                    archivo.writeline("</detalleVentas>")
                Next
                archivo.writeline("</ventas>")
                archivo.writeline("<ventasEstablecimiento>")
                archivo.writeline("<ventaEst>")
                archivo.writeline("<codEstab>" & establecimiento & "</codEstab>")
                archivo.writeline("<ventasEstab>0.00</ventasEstab>")
                If dtpFechaDesde.Value >= "01-06-2016 00:00:01" Then
                    archivo.writeline("<ivaComp>0.00</ivaComp>")
                End If
                archivo.writeline("</ventaEst>")
                archivo.writeline("</ventasEstablecimiento>")
                ' facturas anuladas
                archivo.writeline("<anulados>")
                For indiceAnulados = 0 To dgvVentasATS.Rows.Count - 1
                    If dgvVentasATS.Rows(indiceAnulados).Cells(11).Value = "0" Then
                        archivo.writeline("<detalleAnulados>")
                        archivo.writeline("<tipoComprobante>01</tipoComprobante>")
                        archivo.writeline("<establecimiento>" & establecimiento & "</establecimiento>")
                        archivo.writeline("<puntoEmision>" & puntoEmision & "</puntoEmision>")
                        archivo.writeline("<secuencialInicio>" & dgvVentasATS.Rows(indiceAnulados).Cells(1).Value & "</secuencialInicio>")
                        archivo.writeline("<secuencialFin>" & dgvVentasATS.Rows(indiceAnulados).Cells(1).Value & "</secuencialFin>")
                        archivo.writeline("<autorizacion>1115452816</autorizacion>")
                        archivo.writeline("</detalleAnulados>")
                    End If

                Next
                archivo.writeline("</anulados>")
                archivo.writeline("</iva>")
                archivo.close()

                'MsgBox("XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
                KryptonMessageBox.Show("XML generado correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

            Else
                'MsgBox("NO SE PUEDE GENERAR EL XML." & vbNewLine & "ASEGURESE DE HABER ESCOGIDO BIEN LAS FECHAS", MsgBoxStyle.Exclamation, "Mensaje de validación.")
                KryptonMessageBox.Show("No se puede generar el xml." & vbNewLine & "Asegurese de haber escogido bien las fechas", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

    End Class
End Namespace