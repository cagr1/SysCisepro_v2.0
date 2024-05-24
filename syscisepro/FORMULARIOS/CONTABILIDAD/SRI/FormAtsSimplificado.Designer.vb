Namespace FORMULARIOS.CONTABILIDAD.SRI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAtsSimplificado
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAtsSimplificado))
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label95 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.tcATSSimplificado = New System.Windows.Forms.TabControl()
            Me.tpVentasATS = New System.Windows.Forms.TabPage()
            Me.dgvVentasATS = New System.Windows.Forms.DataGridView()
            Me.gbTotalesVentas = New System.Windows.Forms.GroupBox()
            Me.Label83 = New System.Windows.Forms.Label()
            Me.txtIva14FacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label84 = New System.Windows.Forms.Label()
            Me.TextBox101 = New System.Windows.Forms.TextBox()
            Me.Label85 = New System.Windows.Forms.Label()
            Me.txtIva12FacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label82 = New System.Windows.Forms.Label()
            Me.txtSubtotal14FacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.txtSubtotal0FacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.txtSubtotal12FacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.txtDescuentoFacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.txtSubtotalFacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.txtIvaFacturaVentas = New System.Windows.Forms.TextBox()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.txtTotalFacturaVentas = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleComprobanteRetencionVenta = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencionVenta = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionVenta = New System.Windows.Forms.DataGridView()
            Me.dgvDatosAgrupadosVentas = New System.Windows.Forms.DataGridView()
            Me.TIPO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NUMERO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL_12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_RET_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_RET_RENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.tpNotasCredito = New System.Windows.Forms.TabPage()
            Me.dgvNotasCredito = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label87 = New System.Windows.Forms.Label()
            Me.txtIva14NotaCredito = New System.Windows.Forms.TextBox()
            Me.Label88 = New System.Windows.Forms.Label()
            Me.txtIva0NotaCredito = New System.Windows.Forms.TextBox()
            Me.Label89 = New System.Windows.Forms.Label()
            Me.txtIva12NotaCredito = New System.Windows.Forms.TextBox()
            Me.Label86 = New System.Windows.Forms.Label()
            Me.txtSubtotal14NotaCredito = New System.Windows.Forms.TextBox()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.txtSubtotal0NotaCredito = New System.Windows.Forms.TextBox()
            Me.lblSubtotalIva = New System.Windows.Forms.Label()
            Me.txtSubtotal12NotaCredito = New System.Windows.Forms.TextBox()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtSubtotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.txtIvaNotaCredito = New System.Windows.Forms.TextBox()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.dgvDatosAgrupadosNotasCredito = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpComprasATS = New System.Windows.Forms.TabPage()
            Me.dgvComprasATS = New System.Windows.Forms.DataGridView()
            Me.gbTotalesCompras = New System.Windows.Forms.GroupBox()
            Me.Label91 = New System.Windows.Forms.Label()
            Me.txtIva14Compras = New System.Windows.Forms.TextBox()
            Me.Label92 = New System.Windows.Forms.Label()
            Me.txtIva0Compras = New System.Windows.Forms.TextBox()
            Me.Label93 = New System.Windows.Forms.Label()
            Me.txtIva12Compras = New System.Windows.Forms.TextBox()
            Me.Label90 = New System.Windows.Forms.Label()
            Me.txtSubtotal14Compras = New System.Windows.Forms.TextBox()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.txtSubtotal0Compras = New System.Windows.Forms.TextBox()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.txtSubtotal12Compras = New System.Windows.Forms.TextBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.txtDescuentoCompras = New System.Windows.Forms.TextBox()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.txtSubtotalCompras = New System.Windows.Forms.TextBox()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtIvaCompras = New System.Windows.Forms.TextBox()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.txtTotalCompras = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencionCompra = New System.Windows.Forms.DataGridView()
            Me.tpCodigosRetencionCompras = New System.Windows.Forms.TabPage()
            Me.dgvCodigosRetencionCompras = New System.Windows.Forms.DataGridView()
            Me.ID_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.EJ_FISCAL_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CODIGO_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IMPUESTO_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PORCENTAJE_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ESTADO_DETALLE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_COMPROBANTE_RETENCION_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_COMPROBANTE_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpResumenATS = New System.Windows.Forms.TabPage()
            Me.gbCabecera = New System.Windows.Forms.GroupBox()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.lblSinRetencion = New System.Windows.Forms.Label()
            Me.gbRetencionesEfectuaron = New System.Windows.Forms.GroupBox()
            Me.Label68 = New System.Windows.Forms.Label()
            Me.Label70 = New System.Windows.Forms.Label()
            Me.Label67 = New System.Windows.Forms.Label()
            Me.TextBox99 = New System.Windows.Forms.TextBox()
            Me.Label66 = New System.Windows.Forms.Label()
            Me.TextBox98 = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.TextBox76 = New System.Windows.Forms.TextBox()
            Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape50 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape49 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape48 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape47 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape46 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.gbRetencionesFuenteIva = New System.Windows.Forms.GroupBox()
            Me.TextBox100 = New System.Windows.Forms.TextBox()
            Me.Label94 = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.Label80 = New System.Windows.Forms.Label()
            Me.TextBox90 = New System.Windows.Forms.TextBox()
            Me.TextBox91 = New System.Windows.Forms.TextBox()
            Me.Label58 = New System.Windows.Forms.Label()
            Me.Label59 = New System.Windows.Forms.Label()
            Me.TextBox75 = New System.Windows.Forms.TextBox()
            Me.TextBox65 = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.TextBox63 = New System.Windows.Forms.TextBox()
            Me.TextBox64 = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape55 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape45 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape44 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape43 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape42 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape41 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape40 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape39 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape38 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.gbVentas = New System.Windows.Forms.GroupBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label76 = New System.Windows.Forms.Label()
            Me.Label77 = New System.Windows.Forms.Label()
            Me.Label78 = New System.Windows.Forms.Label()
            Me.Label79 = New System.Windows.Forms.Label()
            Me.TextBox71 = New System.Windows.Forms.TextBox()
            Me.TextBox72 = New System.Windows.Forms.TextBox()
            Me.TextBox73 = New System.Windows.Forms.TextBox()
            Me.TextBox74 = New System.Windows.Forms.TextBox()
            Me.TextBox55 = New System.Windows.Forms.TextBox()
            Me.TextBox56 = New System.Windows.Forms.TextBox()
            Me.TextBox57 = New System.Windows.Forms.TextBox()
            Me.TextBox58 = New System.Windows.Forms.TextBox()
            Me.TextBox59 = New System.Windows.Forms.TextBox()
            Me.TextBox60 = New System.Windows.Forms.TextBox()
            Me.TextBox61 = New System.Windows.Forms.TextBox()
            Me.TextBox62 = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape52 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape17 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape16 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape15 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.gbRetencionesFuenteRenta = New System.Windows.Forms.GroupBox()
            Me.TextBox103 = New System.Windows.Forms.TextBox()
            Me.Label97 = New System.Windows.Forms.Label()
            Me.TextBox102 = New System.Windows.Forms.TextBox()
            Me.Label96 = New System.Windows.Forms.Label()
            Me.Label73 = New System.Windows.Forms.Label()
            Me.Label74 = New System.Windows.Forms.Label()
            Me.Label75 = New System.Windows.Forms.Label()
            Me.Label72 = New System.Windows.Forms.Label()
            Me.Label71 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label69 = New System.Windows.Forms.Label()
            Me.TextBox89 = New System.Windows.Forms.TextBox()
            Me.TextBox95 = New System.Windows.Forms.TextBox()
            Me.TextBox88 = New System.Windows.Forms.TextBox()
            Me.TextBox87 = New System.Windows.Forms.TextBox()
            Me.TextBox96 = New System.Windows.Forms.TextBox()
            Me.TextBox86 = New System.Windows.Forms.TextBox()
            Me.TextBox97 = New System.Windows.Forms.TextBox()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.Label65 = New System.Windows.Forms.Label()
            Me.Label56 = New System.Windows.Forms.Label()
            Me.TextBox92 = New System.Windows.Forms.TextBox()
            Me.Label55 = New System.Windows.Forms.Label()
            Me.TextBox93 = New System.Windows.Forms.TextBox()
            Me.TextBox94 = New System.Windows.Forms.TextBox()
            Me.Label64 = New System.Windows.Forms.Label()
            Me.TextBox77 = New System.Windows.Forms.TextBox()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.TextBox28 = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.TextBox29 = New System.Windows.Forms.TextBox()
            Me.TextBox30 = New System.Windows.Forms.TextBox()
            Me.TextBox31 = New System.Windows.Forms.TextBox()
            Me.TextBox32 = New System.Windows.Forms.TextBox()
            Me.TextBox33 = New System.Windows.Forms.TextBox()
            Me.TextBox34 = New System.Windows.Forms.TextBox()
            Me.TextBox35 = New System.Windows.Forms.TextBox()
            Me.TextBox36 = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.TextBox37 = New System.Windows.Forms.TextBox()
            Me.TextBox38 = New System.Windows.Forms.TextBox()
            Me.TextBox39 = New System.Windows.Forms.TextBox()
            Me.TextBox40 = New System.Windows.Forms.TextBox()
            Me.TextBox41 = New System.Windows.Forms.TextBox()
            Me.TextBox42 = New System.Windows.Forms.TextBox()
            Me.TextBox43 = New System.Windows.Forms.TextBox()
            Me.TextBox44 = New System.Windows.Forms.TextBox()
            Me.TextBox45 = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.TextBox46 = New System.Windows.Forms.TextBox()
            Me.TextBox47 = New System.Windows.Forms.TextBox()
            Me.TextBox48 = New System.Windows.Forms.TextBox()
            Me.TextBox49 = New System.Windows.Forms.TextBox()
            Me.TextBox50 = New System.Windows.Forms.TextBox()
            Me.TextBox51 = New System.Windows.Forms.TextBox()
            Me.TextBox52 = New System.Windows.Forms.TextBox()
            Me.TextBox53 = New System.Windows.Forms.TextBox()
            Me.TextBox54 = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.TextBox19 = New System.Windows.Forms.TextBox()
            Me.TextBox20 = New System.Windows.Forms.TextBox()
            Me.TextBox21 = New System.Windows.Forms.TextBox()
            Me.TextBox22 = New System.Windows.Forms.TextBox()
            Me.TextBox23 = New System.Windows.Forms.TextBox()
            Me.TextBox24 = New System.Windows.Forms.TextBox()
            Me.TextBox25 = New System.Windows.Forms.TextBox()
            Me.TextBox26 = New System.Windows.Forms.TextBox()
            Me.TextBox27 = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.TextBox10 = New System.Windows.Forms.TextBox()
            Me.TextBox11 = New System.Windows.Forms.TextBox()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.TextBox13 = New System.Windows.Forms.TextBox()
            Me.TextBox14 = New System.Windows.Forms.TextBox()
            Me.TextBox15 = New System.Windows.Forms.TextBox()
            Me.TextBox16 = New System.Windows.Forms.TextBox()
            Me.TextBox17 = New System.Windows.Forms.TextBox()
            Me.TextBox18 = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape37 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape36 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape35 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape34 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape33 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape32 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape31 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape30 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape29 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape28 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape27 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape26 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape25 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape24 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape23 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape22 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape21 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape20 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape19 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.gbCompras = New System.Windows.Forms.GroupBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label63 = New System.Windows.Forms.Label()
            Me.Label62 = New System.Windows.Forms.Label()
            Me.Label61 = New System.Windows.Forms.Label()
            Me.Label60 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.TextBox82 = New System.Windows.Forms.TextBox()
            Me.TextBox83 = New System.Windows.Forms.TextBox()
            Me.TextBox84 = New System.Windows.Forms.TextBox()
            Me.TextBox85 = New System.Windows.Forms.TextBox()
            Me.TextBox78 = New System.Windows.Forms.TextBox()
            Me.TextBox79 = New System.Windows.Forms.TextBox()
            Me.TextBox80 = New System.Windows.Forms.TextBox()
            Me.TextBox81 = New System.Windows.Forms.TextBox()
            Me.TextBox69 = New System.Windows.Forms.TextBox()
            Me.lblIvaTotalCompras = New System.Windows.Forms.TextBox()
            Me.TextBox70 = New System.Windows.Forms.TextBox()
            Me.txtIvaNotaVentaCompras = New System.Windows.Forms.TextBox()
            Me.TextBox68 = New System.Windows.Forms.TextBox()
            Me.txtIvaLiquidacionCompras = New System.Windows.Forms.TextBox()
            Me.txtIvaFacturasCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa12NotaVentaCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa12LiquidacionCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa12FacturasCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa0NotaVentaCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa0LiquidacionCompras = New System.Windows.Forms.TextBox()
            Me.txtTarifa0FacturaCompras = New System.Windows.Forms.TextBox()
            Me.txtNroRegistrosNotasVentaCompras = New System.Windows.Forms.TextBox()
            Me.txtNroRegistrosLiquidacionCompras = New System.Windows.Forms.TextBox()
            Me.txtNroRegistrosFacturasCompras = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape51 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.gbComprobantesAnulados = New System.Windows.Forms.GroupBox()
            Me.Label81 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.TextBox66 = New System.Windows.Forms.TextBox()
            Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LineShape54 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape53 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.LineShape18 = New Microsoft.VisualBasic.PowerPacks.LineShape()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGenerarXML = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbRangoFechas.SuspendLayout()
            Me.tcATSSimplificado.SuspendLayout()
            Me.tpVentasATS.SuspendLayout()
            CType(Me.dgvVentasATS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotalesVentas.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDatosAgrupadosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpNotasCredito.SuspendLayout()
            CType(Me.dgvNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvDatosAgrupadosNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpComprasATS.SuspendLayout()
            CType(Me.dgvComprasATS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTotalesCompras.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpCodigosRetencionCompras.SuspendLayout()
            CType(Me.dgvCodigosRetencionCompras, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpResumenATS.SuspendLayout()
            Me.gbCabecera.SuspendLayout()
            Me.gbRetencionesEfectuaron.SuspendLayout()
            Me.gbRetencionesFuenteIva.SuspendLayout()
            Me.gbVentas.SuspendLayout()
            Me.gbRetencionesFuenteRenta.SuspendLayout()
            Me.gbCompras.SuspendLayout()
            Me.gbComprobantesAnulados.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label95)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(1, 22)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(1071, 44)
            Me.gbRangoFechas.TabIndex = 106
            Me.gbRangoFechas.TabStop = False
            '
            'Label95
            '
            Me.Label95.AutoSize = True
            Me.Label95.Location = New System.Drawing.Point(8, 18)
            Me.Label95.Name = "Label95"
            Me.Label95.Size = New System.Drawing.Size(103, 13)
            Me.Label95.TabIndex = 3
            Me.Label95.Text = "CARGAR DATOS DEL"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(419, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(19, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "AL"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Location = New System.Drawing.Point(444, 14)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(274, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Location = New System.Drawing.Point(117, 14)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(274, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(1029, 6)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteCompra.TabIndex = 3
            Me.lblIdComprobanteCompra.Text = "0"
            '
            'tcATSSimplificado
            '
            Me.tcATSSimplificado.Controls.Add(Me.tpVentasATS)
            Me.tcATSSimplificado.Controls.Add(Me.tpNotasCredito)
            Me.tcATSSimplificado.Controls.Add(Me.tpComprasATS)
            Me.tcATSSimplificado.Controls.Add(Me.tpCodigosRetencionCompras)
            Me.tcATSSimplificado.Controls.Add(Me.tpResumenATS)
            Me.tcATSSimplificado.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcATSSimplificado.Location = New System.Drawing.Point(-1, 68)
            Me.tcATSSimplificado.Name = "tcATSSimplificado"
            Me.tcATSSimplificado.SelectedIndex = 0
            Me.tcATSSimplificado.Size = New System.Drawing.Size(1077, 628)
            Me.tcATSSimplificado.TabIndex = 108
            '
            'tpVentasATS
            '
            Me.tpVentasATS.BackColor = System.Drawing.Color.White
            Me.tpVentasATS.Controls.Add(Me.dgvVentasATS)
            Me.tpVentasATS.Controls.Add(Me.gbTotalesVentas)
            Me.tpVentasATS.Controls.Add(Me.lblIdDetalleComprobanteRetencionVenta)
            Me.tpVentasATS.Controls.Add(Me.lblIdComprobanteRetencionVenta)
            Me.tpVentasATS.Controls.Add(Me.dgvDetalleComprobanteRetencionVenta)
            Me.tpVentasATS.Controls.Add(Me.dgvComprobanteRetencionVenta)
            Me.tpVentasATS.Controls.Add(Me.dgvDatosAgrupadosVentas)
            Me.tpVentasATS.Controls.Add(Me.lblIdFacturaVenta)
            Me.tpVentasATS.Location = New System.Drawing.Point(4, 22)
            Me.tpVentasATS.Name = "tpVentasATS"
            Me.tpVentasATS.Padding = New System.Windows.Forms.Padding(3)
            Me.tpVentasATS.Size = New System.Drawing.Size(1069, 602)
            Me.tpVentasATS.TabIndex = 1
            Me.tpVentasATS.Text = "VENTAS"
            '
            'dgvVentasATS
            '
            Me.dgvVentasATS.AllowUserToAddRows = False
            Me.dgvVentasATS.AllowUserToDeleteRows = False
            Me.dgvVentasATS.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvVentasATS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvVentasATS.BackgroundColor = System.Drawing.Color.White
            Me.dgvVentasATS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvVentasATS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvVentasATS.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvVentasATS.Location = New System.Drawing.Point(0, 0)
            Me.dgvVentasATS.Name = "dgvVentasATS"
            Me.dgvVentasATS.ReadOnly = True
            Me.dgvVentasATS.RowHeadersVisible = False
            Me.dgvVentasATS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvVentasATS.Size = New System.Drawing.Size(1069, 519)
            Me.dgvVentasATS.TabIndex = 1
            '
            'gbTotalesVentas
            '
            Me.gbTotalesVentas.Controls.Add(Me.Label83)
            Me.gbTotalesVentas.Controls.Add(Me.txtIva14FacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label84)
            Me.gbTotalesVentas.Controls.Add(Me.TextBox101)
            Me.gbTotalesVentas.Controls.Add(Me.Label85)
            Me.gbTotalesVentas.Controls.Add(Me.txtIva12FacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label82)
            Me.gbTotalesVentas.Controls.Add(Me.txtSubtotal14FacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label42)
            Me.gbTotalesVentas.Controls.Add(Me.txtSubtotal0FacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label41)
            Me.gbTotalesVentas.Controls.Add(Me.txtSubtotal12FacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label40)
            Me.gbTotalesVentas.Controls.Add(Me.txtDescuentoFacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label39)
            Me.gbTotalesVentas.Controls.Add(Me.txtSubtotalFacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label38)
            Me.gbTotalesVentas.Controls.Add(Me.txtIvaFacturaVentas)
            Me.gbTotalesVentas.Controls.Add(Me.Label37)
            Me.gbTotalesVentas.Controls.Add(Me.txtTotalFacturaVentas)
            Me.gbTotalesVentas.Location = New System.Drawing.Point(0, 519)
            Me.gbTotalesVentas.Name = "gbTotalesVentas"
            Me.gbTotalesVentas.Size = New System.Drawing.Size(1069, 80)
            Me.gbTotalesVentas.TabIndex = 60
            Me.gbTotalesVentas.TabStop = False
            Me.gbTotalesVentas.Text = "TOTALES"
            '
            'Label83
            '
            Me.Label83.AutoSize = True
            Me.Label83.BackColor = System.Drawing.Color.White
            Me.Label83.Location = New System.Drawing.Point(731, 60)
            Me.Label83.Name = "Label83"
            Me.Label83.Size = New System.Drawing.Size(49, 13)
            Me.Label83.TabIndex = 19
            Me.Label83.Text = "IVA 14:"
            '
            'txtIva14FacturaVentas
            '
            Me.txtIva14FacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtIva14FacturaVentas.Enabled = False
            Me.txtIva14FacturaVentas.Location = New System.Drawing.Point(786, 57)
            Me.txtIva14FacturaVentas.Name = "txtIva14FacturaVentas"
            Me.txtIva14FacturaVentas.ReadOnly = True
            Me.txtIva14FacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtIva14FacturaVentas.TabIndex = 18
            Me.txtIva14FacturaVentas.Text = "0.00"
            Me.txtIva14FacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label84
            '
            Me.Label84.AutoSize = True
            Me.Label84.BackColor = System.Drawing.Color.White
            Me.Label84.Location = New System.Drawing.Point(731, 14)
            Me.Label84.Name = "Label84"
            Me.Label84.Size = New System.Drawing.Size(49, 13)
            Me.Label84.TabIndex = 17
            Me.Label84.Text = "IVA  0:"
            '
            'TextBox101
            '
            Me.TextBox101.BackColor = System.Drawing.Color.White
            Me.TextBox101.Enabled = False
            Me.TextBox101.Location = New System.Drawing.Point(786, 11)
            Me.TextBox101.Name = "TextBox101"
            Me.TextBox101.ReadOnly = True
            Me.TextBox101.Size = New System.Drawing.Size(72, 20)
            Me.TextBox101.TabIndex = 16
            Me.TextBox101.Text = "0.00"
            Me.TextBox101.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label85
            '
            Me.Label85.AutoSize = True
            Me.Label85.BackColor = System.Drawing.Color.White
            Me.Label85.Location = New System.Drawing.Point(731, 37)
            Me.Label85.Name = "Label85"
            Me.Label85.Size = New System.Drawing.Size(49, 13)
            Me.Label85.TabIndex = 15
            Me.Label85.Text = "IVA 12:"
            '
            'txtIva12FacturaVentas
            '
            Me.txtIva12FacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtIva12FacturaVentas.Enabled = False
            Me.txtIva12FacturaVentas.Location = New System.Drawing.Point(786, 34)
            Me.txtIva12FacturaVentas.Name = "txtIva12FacturaVentas"
            Me.txtIva12FacturaVentas.ReadOnly = True
            Me.txtIva12FacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtIva12FacturaVentas.TabIndex = 14
            Me.txtIva12FacturaVentas.Text = "0.00"
            Me.txtIva12FacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label82
            '
            Me.Label82.AutoSize = True
            Me.Label82.BackColor = System.Drawing.Color.White
            Me.Label82.Location = New System.Drawing.Point(540, 60)
            Me.Label82.Name = "Label82"
            Me.Label82.Size = New System.Drawing.Size(79, 13)
            Me.Label82.TabIndex = 13
            Me.Label82.Text = "SUBTOTAL 14:"
            '
            'txtSubtotal14FacturaVentas
            '
            Me.txtSubtotal14FacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtSubtotal14FacturaVentas.Enabled = False
            Me.txtSubtotal14FacturaVentas.Location = New System.Drawing.Point(625, 57)
            Me.txtSubtotal14FacturaVentas.Name = "txtSubtotal14FacturaVentas"
            Me.txtSubtotal14FacturaVentas.ReadOnly = True
            Me.txtSubtotal14FacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal14FacturaVentas.TabIndex = 12
            Me.txtSubtotal14FacturaVentas.Text = "0.00"
            Me.txtSubtotal14FacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label42
            '
            Me.Label42.AutoSize = True
            Me.Label42.BackColor = System.Drawing.Color.White
            Me.Label42.Location = New System.Drawing.Point(546, 14)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(73, 13)
            Me.Label42.TabIndex = 11
            Me.Label42.Text = "SUBTOTAL 0:"
            '
            'txtSubtotal0FacturaVentas
            '
            Me.txtSubtotal0FacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0FacturaVentas.Enabled = False
            Me.txtSubtotal0FacturaVentas.Location = New System.Drawing.Point(625, 11)
            Me.txtSubtotal0FacturaVentas.Name = "txtSubtotal0FacturaVentas"
            Me.txtSubtotal0FacturaVentas.ReadOnly = True
            Me.txtSubtotal0FacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal0FacturaVentas.TabIndex = 10
            Me.txtSubtotal0FacturaVentas.Text = "0.00"
            Me.txtSubtotal0FacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.BackColor = System.Drawing.Color.White
            Me.Label41.Location = New System.Drawing.Point(540, 37)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(79, 13)
            Me.Label41.TabIndex = 9
            Me.Label41.Text = "SUBTOTAL 12:"
            '
            'txtSubtotal12FacturaVentas
            '
            Me.txtSubtotal12FacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12FacturaVentas.Enabled = False
            Me.txtSubtotal12FacturaVentas.Location = New System.Drawing.Point(625, 34)
            Me.txtSubtotal12FacturaVentas.Name = "txtSubtotal12FacturaVentas"
            Me.txtSubtotal12FacturaVentas.ReadOnly = True
            Me.txtSubtotal12FacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal12FacturaVentas.TabIndex = 8
            Me.txtSubtotal12FacturaVentas.Text = "0.00"
            Me.txtSubtotal12FacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label40
            '
            Me.Label40.AutoSize = True
            Me.Label40.BackColor = System.Drawing.Color.White
            Me.Label40.Location = New System.Drawing.Point(356, 14)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(67, 13)
            Me.Label40.TabIndex = 7
            Me.Label40.Text = "DESCUENTO:"
            '
            'txtDescuentoFacturaVentas
            '
            Me.txtDescuentoFacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtDescuentoFacturaVentas.Enabled = False
            Me.txtDescuentoFacturaVentas.Location = New System.Drawing.Point(429, 11)
            Me.txtDescuentoFacturaVentas.Name = "txtDescuentoFacturaVentas"
            Me.txtDescuentoFacturaVentas.ReadOnly = True
            Me.txtDescuentoFacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtDescuentoFacturaVentas.TabIndex = 6
            Me.txtDescuentoFacturaVentas.Text = "0.00"
            Me.txtDescuentoFacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label39
            '
            Me.Label39.AutoSize = True
            Me.Label39.BackColor = System.Drawing.Color.White
            Me.Label39.Location = New System.Drawing.Point(890, 14)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(61, 13)
            Me.Label39.TabIndex = 5
            Me.Label39.Text = "SUBTOTAL:"
            '
            'txtSubtotalFacturaVentas
            '
            Me.txtSubtotalFacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtSubtotalFacturaVentas.Enabled = False
            Me.txtSubtotalFacturaVentas.Location = New System.Drawing.Point(957, 11)
            Me.txtSubtotalFacturaVentas.Name = "txtSubtotalFacturaVentas"
            Me.txtSubtotalFacturaVentas.ReadOnly = True
            Me.txtSubtotalFacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotalFacturaVentas.TabIndex = 4
            Me.txtSubtotalFacturaVentas.Text = "0.00"
            Me.txtSubtotalFacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.BackColor = System.Drawing.Color.White
            Me.Label38.Location = New System.Drawing.Point(920, 37)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(31, 13)
            Me.Label38.TabIndex = 3
            Me.Label38.Text = "IVA:"
            '
            'txtIvaFacturaVentas
            '
            Me.txtIvaFacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtIvaFacturaVentas.Enabled = False
            Me.txtIvaFacturaVentas.Location = New System.Drawing.Point(957, 34)
            Me.txtIvaFacturaVentas.Name = "txtIvaFacturaVentas"
            Me.txtIvaFacturaVentas.ReadOnly = True
            Me.txtIvaFacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtIvaFacturaVentas.TabIndex = 2
            Me.txtIvaFacturaVentas.Text = "0.00"
            Me.txtIvaFacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.BackColor = System.Drawing.Color.White
            Me.Label37.Location = New System.Drawing.Point(908, 60)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(43, 13)
            Me.Label37.TabIndex = 1
            Me.Label37.Text = "TOTAL:"
            '
            'txtTotalFacturaVentas
            '
            Me.txtTotalFacturaVentas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturaVentas.Enabled = False
            Me.txtTotalFacturaVentas.Location = New System.Drawing.Point(957, 57)
            Me.txtTotalFacturaVentas.Name = "txtTotalFacturaVentas"
            Me.txtTotalFacturaVentas.ReadOnly = True
            Me.txtTotalFacturaVentas.Size = New System.Drawing.Size(72, 20)
            Me.txtTotalFacturaVentas.TabIndex = 0
            Me.txtTotalFacturaVentas.Text = "0.00"
            Me.txtTotalFacturaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdDetalleComprobanteRetencionVenta
            '
            Me.lblIdDetalleComprobanteRetencionVenta.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(1028, 435)
            Me.lblIdDetalleComprobanteRetencionVenta.Name = "lblIdDetalleComprobanteRetencionVenta"
            Me.lblIdDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionVenta.TabIndex = 6
            Me.lblIdDetalleComprobanteRetencionVenta.Text = "0"
            '
            'lblIdComprobanteRetencionVenta
            '
            Me.lblIdComprobanteRetencionVenta.AutoSize = True
            Me.lblIdComprobanteRetencionVenta.Location = New System.Drawing.Point(1028, 348)
            Me.lblIdComprobanteRetencionVenta.Name = "lblIdComprobanteRetencionVenta"
            Me.lblIdComprobanteRetencionVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteRetencionVenta.TabIndex = 5
            Me.lblIdComprobanteRetencionVenta.Text = "0"
            '
            'dgvDetalleComprobanteRetencionVenta
            '
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionVenta.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionVenta.Location = New System.Drawing.Point(0, 435)
            Me.dgvDetalleComprobanteRetencionVenta.Name = "dgvDetalleComprobanteRetencionVenta"
            Me.dgvDetalleComprobanteRetencionVenta.Size = New System.Drawing.Size(1069, 84)
            Me.dgvDetalleComprobanteRetencionVenta.TabIndex = 3
            '
            'dgvComprobanteRetencionVenta
            '
            Me.dgvComprobanteRetencionVenta.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionVenta.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencionVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionVenta.Location = New System.Drawing.Point(0, 346)
            Me.dgvComprobanteRetencionVenta.Name = "dgvComprobanteRetencionVenta"
            Me.dgvComprobanteRetencionVenta.Size = New System.Drawing.Size(1069, 83)
            Me.dgvComprobanteRetencionVenta.TabIndex = 2
            '
            'dgvDatosAgrupadosVentas
            '
            Me.dgvDatosAgrupadosVentas.AllowUserToAddRows = False
            Me.dgvDatosAgrupadosVentas.AllowUserToDeleteRows = False
            Me.dgvDatosAgrupadosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDatosAgrupadosVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO_ID, Me.NUMERO_ID, Me.SUBTOTAL_0, Me.SUBTOTAL_12, Me.DESCUENTO, Me.SUBTOTAL, Me.IVA, Me.TOTAL, Me.VALOR_RET_IVA, Me.VALOR_RET_RENTA, Me.CANTIDAD})
            Me.dgvDatosAgrupadosVentas.Location = New System.Drawing.Point(0, 209)
            Me.dgvDatosAgrupadosVentas.Name = "dgvDatosAgrupadosVentas"
            Me.dgvDatosAgrupadosVentas.ReadOnly = True
            Me.dgvDatosAgrupadosVentas.Size = New System.Drawing.Size(1069, 136)
            Me.dgvDatosAgrupadosVentas.TabIndex = 59
            '
            'TIPO_ID
            '
            Me.TIPO_ID.HeaderText = "TIPO_ID"
            Me.TIPO_ID.Name = "TIPO_ID"
            Me.TIPO_ID.ReadOnly = True
            '
            'NUMERO_ID
            '
            Me.NUMERO_ID.HeaderText = "NUMERO_ID"
            Me.NUMERO_ID.Name = "NUMERO_ID"
            Me.NUMERO_ID.ReadOnly = True
            '
            'SUBTOTAL_0
            '
            Me.SUBTOTAL_0.HeaderText = "SUBTOTAL_0"
            Me.SUBTOTAL_0.Name = "SUBTOTAL_0"
            Me.SUBTOTAL_0.ReadOnly = True
            '
            'SUBTOTAL_12
            '
            Me.SUBTOTAL_12.HeaderText = "SUBTOTAL_12"
            Me.SUBTOTAL_12.Name = "SUBTOTAL_12"
            Me.SUBTOTAL_12.ReadOnly = True
            '
            'DESCUENTO
            '
            Me.DESCUENTO.HeaderText = "DESCUENTO"
            Me.DESCUENTO.Name = "DESCUENTO"
            Me.DESCUENTO.ReadOnly = True
            '
            'SUBTOTAL
            '
            Me.SUBTOTAL.HeaderText = "SUBTOTAL"
            Me.SUBTOTAL.Name = "SUBTOTAL"
            Me.SUBTOTAL.ReadOnly = True
            '
            'IVA
            '
            Me.IVA.HeaderText = "IVA"
            Me.IVA.Name = "IVA"
            Me.IVA.ReadOnly = True
            '
            'TOTAL
            '
            Me.TOTAL.HeaderText = "TOTAL"
            Me.TOTAL.Name = "TOTAL"
            Me.TOTAL.ReadOnly = True
            '
            'VALOR_RET_IVA
            '
            Me.VALOR_RET_IVA.HeaderText = "VALOR_RET_IVA"
            Me.VALOR_RET_IVA.Name = "VALOR_RET_IVA"
            Me.VALOR_RET_IVA.ReadOnly = True
            '
            'VALOR_RET_RENTA
            '
            Me.VALOR_RET_RENTA.HeaderText = "VALOR_RET_RENTA"
            Me.VALOR_RET_RENTA.Name = "VALOR_RET_RENTA"
            Me.VALOR_RET_RENTA.ReadOnly = True
            '
            'CANTIDAD
            '
            Me.CANTIDAD.HeaderText = "CANTIDAD"
            Me.CANTIDAD.Name = "CANTIDAD"
            Me.CANTIDAD.ReadOnly = True
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(1028, 6)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "0"
            '
            'tpNotasCredito
            '
            Me.tpNotasCredito.BackColor = System.Drawing.Color.White
            Me.tpNotasCredito.Controls.Add(Me.dgvNotasCredito)
            Me.tpNotasCredito.Controls.Add(Me.GroupBox1)
            Me.tpNotasCredito.Controls.Add(Me.dgvDatosAgrupadosNotasCredito)
            Me.tpNotasCredito.Location = New System.Drawing.Point(4, 22)
            Me.tpNotasCredito.Name = "tpNotasCredito"
            Me.tpNotasCredito.Padding = New System.Windows.Forms.Padding(3)
            Me.tpNotasCredito.Size = New System.Drawing.Size(1069, 602)
            Me.tpNotasCredito.TabIndex = 4
            Me.tpNotasCredito.Text = "NOTAS DE CRÉDITO"
            '
            'dgvNotasCredito
            '
            Me.dgvNotasCredito.AllowUserToAddRows = False
            Me.dgvNotasCredito.AllowUserToDeleteRows = False
            Me.dgvNotasCredito.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNotasCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvNotasCredito.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotasCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNotasCredito.Location = New System.Drawing.Point(0, 0)
            Me.dgvNotasCredito.Name = "dgvNotasCredito"
            Me.dgvNotasCredito.ReadOnly = True
            Me.dgvNotasCredito.RowHeadersVisible = False
            Me.dgvNotasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotasCredito.Size = New System.Drawing.Size(1069, 520)
            Me.dgvNotasCredito.TabIndex = 61
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label87)
            Me.GroupBox1.Controls.Add(Me.txtIva14NotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label88)
            Me.GroupBox1.Controls.Add(Me.txtIva0NotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label89)
            Me.GroupBox1.Controls.Add(Me.txtIva12NotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label86)
            Me.GroupBox1.Controls.Add(Me.txtSubtotal14NotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label49)
            Me.GroupBox1.Controls.Add(Me.txtSubtotal0NotaCredito)
            Me.GroupBox1.Controls.Add(Me.lblSubtotalIva)
            Me.GroupBox1.Controls.Add(Me.txtSubtotal12NotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label52)
            Me.GroupBox1.Controls.Add(Me.txtSubtotalNotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label53)
            Me.GroupBox1.Controls.Add(Me.txtIvaNotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label54)
            Me.GroupBox1.Controls.Add(Me.txtTotalNotaCredito)
            Me.GroupBox1.Location = New System.Drawing.Point(0, 519)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1069, 87)
            Me.GroupBox1.TabIndex = 62
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "TOTALES"
            '
            'Label87
            '
            Me.Label87.AutoSize = True
            Me.Label87.BackColor = System.Drawing.Color.White
            Me.Label87.Location = New System.Drawing.Point(731, 64)
            Me.Label87.Name = "Label87"
            Me.Label87.Size = New System.Drawing.Size(49, 13)
            Me.Label87.TabIndex = 25
            Me.Label87.Text = "IVA 14:"
            '
            'txtIva14NotaCredito
            '
            Me.txtIva14NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIva14NotaCredito.Enabled = False
            Me.txtIva14NotaCredito.Location = New System.Drawing.Point(786, 61)
            Me.txtIva14NotaCredito.Name = "txtIva14NotaCredito"
            Me.txtIva14NotaCredito.ReadOnly = True
            Me.txtIva14NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtIva14NotaCredito.TabIndex = 24
            Me.txtIva14NotaCredito.Text = "0.00"
            Me.txtIva14NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label88
            '
            Me.Label88.AutoSize = True
            Me.Label88.BackColor = System.Drawing.Color.White
            Me.Label88.Location = New System.Drawing.Point(731, 14)
            Me.Label88.Name = "Label88"
            Me.Label88.Size = New System.Drawing.Size(49, 13)
            Me.Label88.TabIndex = 23
            Me.Label88.Text = "IVA  0:"
            '
            'txtIva0NotaCredito
            '
            Me.txtIva0NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIva0NotaCredito.Enabled = False
            Me.txtIva0NotaCredito.Location = New System.Drawing.Point(786, 11)
            Me.txtIva0NotaCredito.Name = "txtIva0NotaCredito"
            Me.txtIva0NotaCredito.ReadOnly = True
            Me.txtIva0NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtIva0NotaCredito.TabIndex = 22
            Me.txtIva0NotaCredito.Text = "0.00"
            Me.txtIva0NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label89
            '
            Me.Label89.AutoSize = True
            Me.Label89.BackColor = System.Drawing.Color.White
            Me.Label89.Location = New System.Drawing.Point(731, 39)
            Me.Label89.Name = "Label89"
            Me.Label89.Size = New System.Drawing.Size(49, 13)
            Me.Label89.TabIndex = 21
            Me.Label89.Text = "IVA 12:"
            '
            'txtIva12NotaCredito
            '
            Me.txtIva12NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIva12NotaCredito.Enabled = False
            Me.txtIva12NotaCredito.Location = New System.Drawing.Point(786, 36)
            Me.txtIva12NotaCredito.Name = "txtIva12NotaCredito"
            Me.txtIva12NotaCredito.ReadOnly = True
            Me.txtIva12NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtIva12NotaCredito.TabIndex = 20
            Me.txtIva12NotaCredito.Text = "0.00"
            Me.txtIva12NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label86
            '
            Me.Label86.AutoSize = True
            Me.Label86.BackColor = System.Drawing.Color.White
            Me.Label86.Location = New System.Drawing.Point(540, 64)
            Me.Label86.Name = "Label86"
            Me.Label86.Size = New System.Drawing.Size(79, 13)
            Me.Label86.TabIndex = 13
            Me.Label86.Text = "SUBTOTAL 14:"
            '
            'txtSubtotal14NotaCredito
            '
            Me.txtSubtotal14NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal14NotaCredito.Enabled = False
            Me.txtSubtotal14NotaCredito.Location = New System.Drawing.Point(625, 61)
            Me.txtSubtotal14NotaCredito.Name = "txtSubtotal14NotaCredito"
            Me.txtSubtotal14NotaCredito.ReadOnly = True
            Me.txtSubtotal14NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal14NotaCredito.TabIndex = 12
            Me.txtSubtotal14NotaCredito.Text = "0.00"
            Me.txtSubtotal14NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.BackColor = System.Drawing.Color.White
            Me.Label49.Location = New System.Drawing.Point(546, 14)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(73, 13)
            Me.Label49.TabIndex = 11
            Me.Label49.Text = "SUBTOTAL 0:"
            '
            'txtSubtotal0NotaCredito
            '
            Me.txtSubtotal0NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0NotaCredito.Enabled = False
            Me.txtSubtotal0NotaCredito.Location = New System.Drawing.Point(625, 11)
            Me.txtSubtotal0NotaCredito.Name = "txtSubtotal0NotaCredito"
            Me.txtSubtotal0NotaCredito.ReadOnly = True
            Me.txtSubtotal0NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal0NotaCredito.TabIndex = 10
            Me.txtSubtotal0NotaCredito.Text = "0.00"
            Me.txtSubtotal0NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.AutoSize = True
            Me.lblSubtotalIva.BackColor = System.Drawing.Color.White
            Me.lblSubtotalIva.Location = New System.Drawing.Point(540, 39)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotalIva.TabIndex = 9
            Me.lblSubtotalIva.Text = "SUBTOTAL 12:"
            '
            'txtSubtotal12NotaCredito
            '
            Me.txtSubtotal12NotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12NotaCredito.Enabled = False
            Me.txtSubtotal12NotaCredito.Location = New System.Drawing.Point(625, 36)
            Me.txtSubtotal12NotaCredito.Name = "txtSubtotal12NotaCredito"
            Me.txtSubtotal12NotaCredito.ReadOnly = True
            Me.txtSubtotal12NotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal12NotaCredito.TabIndex = 8
            Me.txtSubtotal12NotaCredito.Text = "0.00"
            Me.txtSubtotal12NotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.BackColor = System.Drawing.Color.White
            Me.Label52.Location = New System.Drawing.Point(890, 14)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(61, 13)
            Me.Label52.TabIndex = 5
            Me.Label52.Text = "SUBTOTAL:"
            '
            'txtSubtotalNotaCredito
            '
            Me.txtSubtotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSubtotalNotaCredito.Enabled = False
            Me.txtSubtotalNotaCredito.Location = New System.Drawing.Point(957, 11)
            Me.txtSubtotalNotaCredito.Name = "txtSubtotalNotaCredito"
            Me.txtSubtotalNotaCredito.ReadOnly = True
            Me.txtSubtotalNotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotalNotaCredito.TabIndex = 4
            Me.txtSubtotalNotaCredito.Text = "0.00"
            Me.txtSubtotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.BackColor = System.Drawing.Color.White
            Me.Label53.Location = New System.Drawing.Point(920, 39)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(31, 13)
            Me.Label53.TabIndex = 3
            Me.Label53.Text = "IVA:"
            '
            'txtIvaNotaCredito
            '
            Me.txtIvaNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtIvaNotaCredito.Enabled = False
            Me.txtIvaNotaCredito.Location = New System.Drawing.Point(957, 36)
            Me.txtIvaNotaCredito.Name = "txtIvaNotaCredito"
            Me.txtIvaNotaCredito.ReadOnly = True
            Me.txtIvaNotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtIvaNotaCredito.TabIndex = 2
            Me.txtIvaNotaCredito.Text = "0.00"
            Me.txtIvaNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label54
            '
            Me.Label54.AutoSize = True
            Me.Label54.BackColor = System.Drawing.Color.White
            Me.Label54.Location = New System.Drawing.Point(908, 64)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New System.Drawing.Size(43, 13)
            Me.Label54.TabIndex = 1
            Me.Label54.Text = "TOTAL:"
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Enabled = False
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(957, 61)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.ReadOnly = True
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(72, 20)
            Me.txtTotalNotaCredito.TabIndex = 0
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvDatosAgrupadosNotasCredito
            '
            Me.dgvDatosAgrupadosNotasCredito.AllowUserToAddRows = False
            Me.dgvDatosAgrupadosNotasCredito.AllowUserToDeleteRows = False
            Me.dgvDatosAgrupadosNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDatosAgrupadosNotasCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
            Me.dgvDatosAgrupadosNotasCredito.Location = New System.Drawing.Point(6, 294)
            Me.dgvDatosAgrupadosNotasCredito.Name = "dgvDatosAgrupadosNotasCredito"
            Me.dgvDatosAgrupadosNotasCredito.ReadOnly = True
            Me.dgvDatosAgrupadosNotasCredito.Size = New System.Drawing.Size(1032, 91)
            Me.dgvDatosAgrupadosNotasCredito.TabIndex = 63
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.HeaderText = "TIPO_ID"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.HeaderText = "NUMERO_ID"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.HeaderText = "SUBTOTAL_0"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.HeaderText = "SUBTOTAL_12"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.HeaderText = "DESCUENTO"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.HeaderText = "SUBTOTAL"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.HeaderText = "IVA"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.HeaderText = "TOTAL"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.HeaderText = "VALOR_RET_IVA"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.HeaderText = "VALOR_RET_RENTA"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.HeaderText = "CANTIDAD"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            '
            'tpComprasATS
            '
            Me.tpComprasATS.BackColor = System.Drawing.Color.White
            Me.tpComprasATS.Controls.Add(Me.dgvComprasATS)
            Me.tpComprasATS.Controls.Add(Me.gbTotalesCompras)
            Me.tpComprasATS.Controls.Add(Me.lblIdDetalleComprobanteRetencionCompra)
            Me.tpComprasATS.Controls.Add(Me.lblIdComprobanteRetencionCompra)
            Me.tpComprasATS.Controls.Add(Me.dgvDetalleComprobanteRetencionCompra)
            Me.tpComprasATS.Controls.Add(Me.dgvComprobanteRetencionCompra)
            Me.tpComprasATS.Controls.Add(Me.lblIdComprobanteCompra)
            Me.tpComprasATS.Location = New System.Drawing.Point(4, 22)
            Me.tpComprasATS.Name = "tpComprasATS"
            Me.tpComprasATS.Padding = New System.Windows.Forms.Padding(3)
            Me.tpComprasATS.Size = New System.Drawing.Size(1069, 602)
            Me.tpComprasATS.TabIndex = 0
            Me.tpComprasATS.Text = "COMPRAS"
            '
            'dgvComprasATS
            '
            Me.dgvComprasATS.AllowUserToAddRows = False
            Me.dgvComprasATS.AllowUserToDeleteRows = False
            Me.dgvComprasATS.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprasATS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprasATS.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprasATS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprasATS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprasATS.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprasATS.Name = "dgvComprasATS"
            Me.dgvComprasATS.ReadOnly = True
            Me.dgvComprasATS.RowHeadersVisible = False
            Me.dgvComprasATS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprasATS.Size = New System.Drawing.Size(1069, 520)
            Me.dgvComprasATS.TabIndex = 0
            '
            'gbTotalesCompras
            '
            Me.gbTotalesCompras.Controls.Add(Me.Label91)
            Me.gbTotalesCompras.Controls.Add(Me.txtIva14Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label92)
            Me.gbTotalesCompras.Controls.Add(Me.txtIva0Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label93)
            Me.gbTotalesCompras.Controls.Add(Me.txtIva12Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label90)
            Me.gbTotalesCompras.Controls.Add(Me.txtSubtotal14Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label43)
            Me.gbTotalesCompras.Controls.Add(Me.txtSubtotal0Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label44)
            Me.gbTotalesCompras.Controls.Add(Me.txtSubtotal12Compras)
            Me.gbTotalesCompras.Controls.Add(Me.Label45)
            Me.gbTotalesCompras.Controls.Add(Me.txtDescuentoCompras)
            Me.gbTotalesCompras.Controls.Add(Me.Label46)
            Me.gbTotalesCompras.Controls.Add(Me.txtSubtotalCompras)
            Me.gbTotalesCompras.Controls.Add(Me.Label47)
            Me.gbTotalesCompras.Controls.Add(Me.txtIvaCompras)
            Me.gbTotalesCompras.Controls.Add(Me.Label48)
            Me.gbTotalesCompras.Controls.Add(Me.txtTotalCompras)
            Me.gbTotalesCompras.Location = New System.Drawing.Point(0, 519)
            Me.gbTotalesCompras.Name = "gbTotalesCompras"
            Me.gbTotalesCompras.Size = New System.Drawing.Size(1069, 87)
            Me.gbTotalesCompras.TabIndex = 61
            Me.gbTotalesCompras.TabStop = False
            Me.gbTotalesCompras.Text = "TOTALES"
            '
            'Label91
            '
            Me.Label91.AutoSize = True
            Me.Label91.Location = New System.Drawing.Point(731, 66)
            Me.Label91.Name = "Label91"
            Me.Label91.Size = New System.Drawing.Size(49, 13)
            Me.Label91.TabIndex = 25
            Me.Label91.Text = "IVA 14:"
            '
            'txtIva14Compras
            '
            Me.txtIva14Compras.Enabled = False
            Me.txtIva14Compras.Location = New System.Drawing.Point(786, 63)
            Me.txtIva14Compras.Name = "txtIva14Compras"
            Me.txtIva14Compras.ReadOnly = True
            Me.txtIva14Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtIva14Compras.TabIndex = 24
            Me.txtIva14Compras.Text = "0.00"
            Me.txtIva14Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label92
            '
            Me.Label92.AutoSize = True
            Me.Label92.Location = New System.Drawing.Point(731, 14)
            Me.Label92.Name = "Label92"
            Me.Label92.Size = New System.Drawing.Size(49, 13)
            Me.Label92.TabIndex = 23
            Me.Label92.Text = "IVA  0:"
            '
            'txtIva0Compras
            '
            Me.txtIva0Compras.Enabled = False
            Me.txtIva0Compras.Location = New System.Drawing.Point(786, 11)
            Me.txtIva0Compras.Name = "txtIva0Compras"
            Me.txtIva0Compras.ReadOnly = True
            Me.txtIva0Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtIva0Compras.TabIndex = 22
            Me.txtIva0Compras.Text = "0.00"
            Me.txtIva0Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label93
            '
            Me.Label93.AutoSize = True
            Me.Label93.Location = New System.Drawing.Point(731, 40)
            Me.Label93.Name = "Label93"
            Me.Label93.Size = New System.Drawing.Size(49, 13)
            Me.Label93.TabIndex = 21
            Me.Label93.Text = "IVA 12:"
            '
            'txtIva12Compras
            '
            Me.txtIva12Compras.Enabled = False
            Me.txtIva12Compras.Location = New System.Drawing.Point(786, 37)
            Me.txtIva12Compras.Name = "txtIva12Compras"
            Me.txtIva12Compras.ReadOnly = True
            Me.txtIva12Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtIva12Compras.TabIndex = 20
            Me.txtIva12Compras.Text = "0.00"
            Me.txtIva12Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label90
            '
            Me.Label90.AutoSize = True
            Me.Label90.Location = New System.Drawing.Point(540, 66)
            Me.Label90.Name = "Label90"
            Me.Label90.Size = New System.Drawing.Size(79, 13)
            Me.Label90.TabIndex = 13
            Me.Label90.Text = "SUBTOTAL 14:"
            '
            'txtSubtotal14Compras
            '
            Me.txtSubtotal14Compras.Enabled = False
            Me.txtSubtotal14Compras.Location = New System.Drawing.Point(625, 63)
            Me.txtSubtotal14Compras.Name = "txtSubtotal14Compras"
            Me.txtSubtotal14Compras.ReadOnly = True
            Me.txtSubtotal14Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal14Compras.TabIndex = 12
            Me.txtSubtotal14Compras.Text = "0.00"
            Me.txtSubtotal14Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(546, 14)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(73, 13)
            Me.Label43.TabIndex = 11
            Me.Label43.Text = "SUBTOTAL 0:"
            '
            'txtSubtotal0Compras
            '
            Me.txtSubtotal0Compras.Enabled = False
            Me.txtSubtotal0Compras.Location = New System.Drawing.Point(625, 11)
            Me.txtSubtotal0Compras.Name = "txtSubtotal0Compras"
            Me.txtSubtotal0Compras.ReadOnly = True
            Me.txtSubtotal0Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal0Compras.TabIndex = 10
            Me.txtSubtotal0Compras.Text = "0.00"
            Me.txtSubtotal0Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(540, 40)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(79, 13)
            Me.Label44.TabIndex = 9
            Me.Label44.Text = "SUBTOTAL 12:"
            '
            'txtSubtotal12Compras
            '
            Me.txtSubtotal12Compras.Enabled = False
            Me.txtSubtotal12Compras.Location = New System.Drawing.Point(625, 37)
            Me.txtSubtotal12Compras.Name = "txtSubtotal12Compras"
            Me.txtSubtotal12Compras.ReadOnly = True
            Me.txtSubtotal12Compras.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotal12Compras.TabIndex = 8
            Me.txtSubtotal12Compras.Text = "0.00"
            Me.txtSubtotal12Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Location = New System.Drawing.Point(342, 14)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(67, 13)
            Me.Label45.TabIndex = 7
            Me.Label45.Text = "DESCUENTO:"
            '
            'txtDescuentoCompras
            '
            Me.txtDescuentoCompras.Enabled = False
            Me.txtDescuentoCompras.Location = New System.Drawing.Point(415, 11)
            Me.txtDescuentoCompras.Name = "txtDescuentoCompras"
            Me.txtDescuentoCompras.ReadOnly = True
            Me.txtDescuentoCompras.Size = New System.Drawing.Size(72, 20)
            Me.txtDescuentoCompras.TabIndex = 6
            Me.txtDescuentoCompras.Text = "0.00"
            Me.txtDescuentoCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Location = New System.Drawing.Point(890, 14)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(61, 13)
            Me.Label46.TabIndex = 5
            Me.Label46.Text = "SUBTOTAL:"
            '
            'txtSubtotalCompras
            '
            Me.txtSubtotalCompras.Enabled = False
            Me.txtSubtotalCompras.Location = New System.Drawing.Point(957, 11)
            Me.txtSubtotalCompras.Name = "txtSubtotalCompras"
            Me.txtSubtotalCompras.ReadOnly = True
            Me.txtSubtotalCompras.Size = New System.Drawing.Size(72, 20)
            Me.txtSubtotalCompras.TabIndex = 4
            Me.txtSubtotalCompras.Text = "0.00"
            Me.txtSubtotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Location = New System.Drawing.Point(920, 40)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(31, 13)
            Me.Label47.TabIndex = 3
            Me.Label47.Text = "IVA:"
            '
            'txtIvaCompras
            '
            Me.txtIvaCompras.Enabled = False
            Me.txtIvaCompras.Location = New System.Drawing.Point(957, 37)
            Me.txtIvaCompras.Name = "txtIvaCompras"
            Me.txtIvaCompras.ReadOnly = True
            Me.txtIvaCompras.Size = New System.Drawing.Size(72, 20)
            Me.txtIvaCompras.TabIndex = 2
            Me.txtIvaCompras.Text = "0.00"
            Me.txtIvaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(908, 66)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(43, 13)
            Me.Label48.TabIndex = 1
            Me.Label48.Text = "TOTAL:"
            '
            'txtTotalCompras
            '
            Me.txtTotalCompras.Enabled = False
            Me.txtTotalCompras.Location = New System.Drawing.Point(957, 63)
            Me.txtTotalCompras.Name = "txtTotalCompras"
            Me.txtTotalCompras.ReadOnly = True
            Me.txtTotalCompras.Size = New System.Drawing.Size(72, 20)
            Me.txtTotalCompras.TabIndex = 0
            Me.txtTotalCompras.Text = "0.00"
            Me.txtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdDetalleComprobanteRetencionCompra
            '
            Me.lblIdDetalleComprobanteRetencionCompra.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(1029, 401)
            Me.lblIdDetalleComprobanteRetencionCompra.Name = "lblIdDetalleComprobanteRetencionCompra"
            Me.lblIdDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionCompra.TabIndex = 9
            Me.lblIdDetalleComprobanteRetencionCompra.Text = "0"
            '
            'lblIdComprobanteRetencionCompra
            '
            Me.lblIdComprobanteRetencionCompra.AutoSize = True
            Me.lblIdComprobanteRetencionCompra.Location = New System.Drawing.Point(1029, 312)
            Me.lblIdComprobanteRetencionCompra.Name = "lblIdComprobanteRetencionCompra"
            Me.lblIdComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdComprobanteRetencionCompra.TabIndex = 8
            Me.lblIdComprobanteRetencionCompra.Text = "0"
            '
            'dgvDetalleComprobanteRetencionCompra
            '
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencionCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(6, 401)
            Me.dgvDetalleComprobanteRetencionCompra.Name = "dgvDetalleComprobanteRetencionCompra"
            Me.dgvDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(1038, 84)
            Me.dgvDetalleComprobanteRetencionCompra.TabIndex = 2
            '
            'dgvComprobanteRetencionCompra
            '
            Me.dgvComprobanteRetencionCompra.AllowUserToAddRows = False
            Me.dgvComprobanteRetencionCompra.AllowUserToDeleteRows = False
            Me.dgvComprobanteRetencionCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencionCompra.Location = New System.Drawing.Point(6, 312)
            Me.dgvComprobanteRetencionCompra.Name = "dgvComprobanteRetencionCompra"
            Me.dgvComprobanteRetencionCompra.Size = New System.Drawing.Size(1038, 83)
            Me.dgvComprobanteRetencionCompra.TabIndex = 1
            '
            'tpCodigosRetencionCompras
            '
            Me.tpCodigosRetencionCompras.Controls.Add(Me.dgvCodigosRetencionCompras)
            Me.tpCodigosRetencionCompras.Location = New System.Drawing.Point(4, 22)
            Me.tpCodigosRetencionCompras.Name = "tpCodigosRetencionCompras"
            Me.tpCodigosRetencionCompras.Padding = New System.Windows.Forms.Padding(3)
            Me.tpCodigosRetencionCompras.Size = New System.Drawing.Size(1069, 602)
            Me.tpCodigosRetencionCompras.TabIndex = 3
            Me.tpCodigosRetencionCompras.Text = "CODIGO RETENCIONES COMPRAS"
            Me.tpCodigosRetencionCompras.UseVisualStyleBackColor = True
            '
            'dgvCodigosRetencionCompras
            '
            Me.dgvCodigosRetencionCompras.AllowUserToAddRows = False
            Me.dgvCodigosRetencionCompras.AllowUserToDeleteRows = False
            Me.dgvCodigosRetencionCompras.AllowUserToResizeRows = False
            Me.dgvCodigosRetencionCompras.BackgroundColor = System.Drawing.Color.White
            Me.dgvCodigosRetencionCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCodigosRetencionCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCodigosRetencionCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_DETALLE_RETENCION_COMPRA, Me.EJ_FISCAL_DETALLE_RETENCION_COMPRA, Me.CODIGO_DETALLE_RETENCION_COMPRA, Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA, Me.IMPUESTO_DETALLE_RETENCION_COMPRA, Me.PORCENTAJE_DETALLE_RETENCION_COMPRA, Me.VALOR_DETALLE_RETENCION_COMPRA, Me.ESTADO_DETALLE_RETENCION_COMPRA, Me.ID_COMPROBANTE_RETENCION_COMPRA, Me.ID_COMPROBANTE_COMPRA})
            Me.dgvCodigosRetencionCompras.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvCodigosRetencionCompras.Location = New System.Drawing.Point(3, 3)
            Me.dgvCodigosRetencionCompras.Name = "dgvCodigosRetencionCompras"
            Me.dgvCodigosRetencionCompras.ReadOnly = True
            Me.dgvCodigosRetencionCompras.RowHeadersVisible = False
            Me.dgvCodigosRetencionCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCodigosRetencionCompras.Size = New System.Drawing.Size(1063, 596)
            Me.dgvCodigosRetencionCompras.TabIndex = 0
            '
            'ID_DETALLE_RETENCION_COMPRA
            '
            Me.ID_DETALLE_RETENCION_COMPRA.HeaderText = "ID"
            Me.ID_DETALLE_RETENCION_COMPRA.Name = "ID_DETALLE_RETENCION_COMPRA"
            Me.ID_DETALLE_RETENCION_COMPRA.ReadOnly = True
            Me.ID_DETALLE_RETENCION_COMPRA.Width = 80
            '
            'EJ_FISCAL_DETALLE_RETENCION_COMPRA
            '
            Me.EJ_FISCAL_DETALLE_RETENCION_COMPRA.HeaderText = "EJERCICIO FISCAL"
            Me.EJ_FISCAL_DETALLE_RETENCION_COMPRA.Name = "EJ_FISCAL_DETALLE_RETENCION_COMPRA"
            Me.EJ_FISCAL_DETALLE_RETENCION_COMPRA.ReadOnly = True
            '
            'CODIGO_DETALLE_RETENCION_COMPRA
            '
            Me.CODIGO_DETALLE_RETENCION_COMPRA.HeaderText = "CODIGO"
            Me.CODIGO_DETALLE_RETENCION_COMPRA.Name = "CODIGO_DETALLE_RETENCION_COMPRA"
            Me.CODIGO_DETALLE_RETENCION_COMPRA.ReadOnly = True
            '
            'BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA
            '
            Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA.HeaderText = "BASE IMPONIBLE"
            Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA.Name = "BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA"
            Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA.ReadOnly = True
            Me.BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA.Width = 140
            '
            'IMPUESTO_DETALLE_RETENCION_COMPRA
            '
            Me.IMPUESTO_DETALLE_RETENCION_COMPRA.HeaderText = "IMPUESTO"
            Me.IMPUESTO_DETALLE_RETENCION_COMPRA.Name = "IMPUESTO_DETALLE_RETENCION_COMPRA"
            Me.IMPUESTO_DETALLE_RETENCION_COMPRA.ReadOnly = True
            '
            'PORCENTAJE_DETALLE_RETENCION_COMPRA
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.PORCENTAJE_DETALLE_RETENCION_COMPRA.DefaultCellStyle = DataGridViewCellStyle5
            Me.PORCENTAJE_DETALLE_RETENCION_COMPRA.HeaderText = "PORCENTAJE"
            Me.PORCENTAJE_DETALLE_RETENCION_COMPRA.Name = "PORCENTAJE_DETALLE_RETENCION_COMPRA"
            Me.PORCENTAJE_DETALLE_RETENCION_COMPRA.ReadOnly = True
            '
            'VALOR_DETALLE_RETENCION_COMPRA
            '
            Me.VALOR_DETALLE_RETENCION_COMPRA.HeaderText = "VALOR"
            Me.VALOR_DETALLE_RETENCION_COMPRA.Name = "VALOR_DETALLE_RETENCION_COMPRA"
            Me.VALOR_DETALLE_RETENCION_COMPRA.ReadOnly = True
            Me.VALOR_DETALLE_RETENCION_COMPRA.Width = 110
            '
            'ESTADO_DETALLE_RETENCION_COMPRA
            '
            Me.ESTADO_DETALLE_RETENCION_COMPRA.HeaderText = "EST"
            Me.ESTADO_DETALLE_RETENCION_COMPRA.Name = "ESTADO_DETALLE_RETENCION_COMPRA"
            Me.ESTADO_DETALLE_RETENCION_COMPRA.ReadOnly = True
            '
            'ID_COMPROBANTE_RETENCION_COMPRA
            '
            Me.ID_COMPROBANTE_RETENCION_COMPRA.HeaderText = "ID RET"
            Me.ID_COMPROBANTE_RETENCION_COMPRA.Name = "ID_COMPROBANTE_RETENCION_COMPRA"
            Me.ID_COMPROBANTE_RETENCION_COMPRA.ReadOnly = True
            Me.ID_COMPROBANTE_RETENCION_COMPRA.Width = 97
            '
            'ID_COMPROBANTE_COMPRA
            '
            Me.ID_COMPROBANTE_COMPRA.HeaderText = "ID COMPRA"
            Me.ID_COMPROBANTE_COMPRA.Name = "ID_COMPROBANTE_COMPRA"
            Me.ID_COMPROBANTE_COMPRA.ReadOnly = True
            Me.ID_COMPROBANTE_COMPRA.Width = 95
            '
            'tpResumenATS
            '
            Me.tpResumenATS.BackColor = System.Drawing.Color.White
            Me.tpResumenATS.Controls.Add(Me.gbCabecera)
            Me.tpResumenATS.Controls.Add(Me.lblSinRetencion)
            Me.tpResumenATS.Controls.Add(Me.gbRetencionesEfectuaron)
            Me.tpResumenATS.Controls.Add(Me.gbRetencionesFuenteIva)
            Me.tpResumenATS.Controls.Add(Me.gbVentas)
            Me.tpResumenATS.Controls.Add(Me.gbRetencionesFuenteRenta)
            Me.tpResumenATS.Controls.Add(Me.gbCompras)
            Me.tpResumenATS.Controls.Add(Me.gbComprobantesAnulados)
            Me.tpResumenATS.Location = New System.Drawing.Point(4, 22)
            Me.tpResumenATS.Name = "tpResumenATS"
            Me.tpResumenATS.Padding = New System.Windows.Forms.Padding(3)
            Me.tpResumenATS.Size = New System.Drawing.Size(1069, 602)
            Me.tpResumenATS.TabIndex = 2
            Me.tpResumenATS.Text = "RESUMEN"
            '
            'gbCabecera
            '
            Me.gbCabecera.Controls.Add(Me.Label36)
            Me.gbCabecera.Location = New System.Drawing.Point(0, -3)
            Me.gbCabecera.Name = "gbCabecera"
            Me.gbCabecera.Size = New System.Drawing.Size(1069, 40)
            Me.gbCabecera.TabIndex = 6
            Me.gbCabecera.TabStop = False
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.Location = New System.Drawing.Point(292, 9)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(467, 28)
            Me.Label36.TabIndex = 0
            Me.Label36.Text = "TALÓN RESUMEN - ANEXO TRANSACCIONAL"
            '
            'lblSinRetencion
            '
            Me.lblSinRetencion.AutoSize = True
            Me.lblSinRetencion.Location = New System.Drawing.Point(1011, 14)
            Me.lblSinRetencion.Name = "lblSinRetencion"
            Me.lblSinRetencion.Size = New System.Drawing.Size(13, 13)
            Me.lblSinRetencion.TabIndex = 0
            Me.lblSinRetencion.Text = "0"
            '
            'gbRetencionesEfectuaron
            '
            Me.gbRetencionesEfectuaron.Controls.Add(Me.Label68)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.Label70)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.Label67)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.TextBox99)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.Label66)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.TextBox98)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.Label32)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.TextBox76)
            Me.gbRetencionesEfectuaron.Controls.Add(Me.ShapeContainer6)
            Me.gbRetencionesEfectuaron.Location = New System.Drawing.Point(0, 449)
            Me.gbRetencionesEfectuaron.Name = "gbRetencionesEfectuaron"
            Me.gbRetencionesEfectuaron.Size = New System.Drawing.Size(571, 154)
            Me.gbRetencionesEfectuaron.TabIndex = 5
            Me.gbRetencionesEfectuaron.TabStop = False
            Me.gbRetencionesEfectuaron.Text = "RESUMEN DE RETENCION QUE LE EFECTUARON EN EL PERIODO"
            '
            'Label68
            '
            Me.Label68.AutoSize = True
            Me.Label68.Location = New System.Drawing.Point(468, 20)
            Me.Label68.Name = "Label68"
            Me.Label68.Size = New System.Drawing.Size(91, 13)
            Me.Label68.TabIndex = 104
            Me.Label68.Text = "Valor Retenido"
            '
            'Label70
            '
            Me.Label70.AutoSize = True
            Me.Label70.Location = New System.Drawing.Point(119, 20)
            Me.Label70.Name = "Label70"
            Me.Label70.Size = New System.Drawing.Size(133, 13)
            Me.Label70.TabIndex = 103
            Me.Label70.Text = "Concepto de Retención"
            '
            'Label67
            '
            Me.Label67.AutoSize = True
            Me.Label67.Location = New System.Drawing.Point(183, 70)
            Me.Label67.Name = "Label67"
            Me.Label67.Size = New System.Drawing.Size(211, 13)
            Me.Label67.TabIndex = 23
            Me.Label67.Text = "VALOR DE RENTA QUE LE HAN RETENIDO"
            '
            'TextBox99
            '
            Me.TextBox99.BackColor = System.Drawing.Color.White
            Me.TextBox99.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox99.Location = New System.Drawing.Point(484, 70)
            Me.TextBox99.Name = "TextBox99"
            Me.TextBox99.ReadOnly = True
            Me.TextBox99.Size = New System.Drawing.Size(71, 13)
            Me.TextBox99.TabIndex = 22
            Me.TextBox99.Text = "0.00"
            Me.TextBox99.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label66
            '
            Me.Label66.AutoSize = True
            Me.Label66.Location = New System.Drawing.Point(183, 45)
            Me.Label66.Name = "Label66"
            Me.Label66.Size = New System.Drawing.Size(199, 13)
            Me.Label66.TabIndex = 21
            Me.Label66.Text = "VALOR DE IVA QUE LE HAN RETENIDO"
            '
            'TextBox98
            '
            Me.TextBox98.BackColor = System.Drawing.Color.White
            Me.TextBox98.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox98.Location = New System.Drawing.Point(484, 45)
            Me.TextBox98.Name = "TextBox98"
            Me.TextBox98.ReadOnly = True
            Me.TextBox98.Size = New System.Drawing.Size(71, 13)
            Me.TextBox98.TabIndex = 20
            Me.TextBox98.Text = "0.00"
            Me.TextBox98.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(263, 95)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(37, 13)
            Me.Label32.TabIndex = 19
            Me.Label32.Text = "TOTAL"
            '
            'TextBox76
            '
            Me.TextBox76.BackColor = System.Drawing.Color.White
            Me.TextBox76.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox76.Location = New System.Drawing.Point(484, 95)
            Me.TextBox76.Name = "TextBox76"
            Me.TextBox76.ReadOnly = True
            Me.TextBox76.Size = New System.Drawing.Size(71, 13)
            Me.TextBox76.TabIndex = 18
            Me.TextBox76.Text = "0.00"
            Me.TextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ShapeContainer6
            '
            Me.ShapeContainer6.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer6.Name = "ShapeContainer6"
            Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape50, Me.LineShape49, Me.LineShape48, Me.LineShape47, Me.LineShape46})
            Me.ShapeContainer6.Size = New System.Drawing.Size(565, 135)
            Me.ShapeContainer6.TabIndex = 105
            Me.ShapeContainer6.TabStop = False
            '
            'LineShape50
            '
            Me.LineShape50.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape50.Name = "LineShape50"
            Me.LineShape50.X1 = 422
            Me.LineShape50.X2 = 422
            Me.LineShape50.Y1 = 0
            Me.LineShape50.Y2 = 95
            '
            'LineShape49
            '
            Me.LineShape49.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape49.Name = "LineShape49"
            Me.LineShape49.X1 = 565
            Me.LineShape49.X2 = 0
            Me.LineShape49.Y1 = 95
            Me.LineShape49.Y2 = 95
            '
            'LineShape48
            '
            Me.LineShape48.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape48.Name = "LineShape48"
            Me.LineShape48.X1 = 565
            Me.LineShape48.X2 = 0
            Me.LineShape48.Y1 = 70
            Me.LineShape48.Y2 = 70
            '
            'LineShape47
            '
            Me.LineShape47.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape47.Name = "LineShape47"
            Me.LineShape47.X1 = 565
            Me.LineShape47.X2 = 0
            Me.LineShape47.Y1 = 45
            Me.LineShape47.Y2 = 45
            '
            'LineShape46
            '
            Me.LineShape46.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape46.Name = "LineShape46"
            Me.LineShape46.X1 = 565
            Me.LineShape46.X2 = 0
            Me.LineShape46.Y1 = 20
            Me.LineShape46.Y2 = 20
            '
            'gbRetencionesFuenteIva
            '
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox100)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label94)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label31)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label50)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label80)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox90)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox91)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label58)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label59)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox75)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox65)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label27)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox63)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.TextBox64)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label25)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.Label26)
            Me.gbRetencionesFuenteIva.Controls.Add(Me.ShapeContainer5)
            Me.gbRetencionesFuenteIva.Location = New System.Drawing.Point(574, 374)
            Me.gbRetencionesFuenteIva.Name = "gbRetencionesFuenteIva"
            Me.gbRetencionesFuenteIva.Size = New System.Drawing.Size(495, 229)
            Me.gbRetencionesFuenteIva.TabIndex = 3
            Me.gbRetencionesFuenteIva.TabStop = False
            Me.gbRetencionesFuenteIva.Text = "RETENCIONES EN LA FUENTE DEL IVA"
            '
            'TextBox100
            '
            Me.TextBox100.BackColor = System.Drawing.Color.White
            Me.TextBox100.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox100.Location = New System.Drawing.Point(406, 120)
            Me.TextBox100.Name = "TextBox100"
            Me.TextBox100.ReadOnly = True
            Me.TextBox100.Size = New System.Drawing.Size(68, 13)
            Me.TextBox100.TabIndex = 105
            Me.TextBox100.Text = "0.00"
            Me.TextBox100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label94
            '
            Me.Label94.AutoSize = True
            Me.Label94.Location = New System.Drawing.Point(153, 120)
            Me.Label94.Name = "Label94"
            Me.Label94.Size = New System.Drawing.Size(109, 13)
            Me.Label94.TabIndex = 104
            Me.Label94.Text = "RETENCIÓN IVA 50%"
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(360, 20)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(91, 13)
            Me.Label31.TabIndex = 102
            Me.Label31.Text = "Valor Retenido"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Location = New System.Drawing.Point(87, 20)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(133, 13)
            Me.Label50.TabIndex = 101
            Me.Label50.Text = "Concepto de Retención"
            '
            'Label80
            '
            Me.Label80.AutoSize = True
            Me.Label80.Location = New System.Drawing.Point(275, 195)
            Me.Label80.Name = "Label80"
            Me.Label80.Size = New System.Drawing.Size(43, 13)
            Me.Label80.TabIndex = 44
            Me.Label80.Text = "TOTAL:"
            '
            'TextBox90
            '
            Me.TextBox90.BackColor = System.Drawing.Color.White
            Me.TextBox90.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox90.Location = New System.Drawing.Point(406, 45)
            Me.TextBox90.Name = "TextBox90"
            Me.TextBox90.ReadOnly = True
            Me.TextBox90.Size = New System.Drawing.Size(68, 13)
            Me.TextBox90.TabIndex = 43
            Me.TextBox90.Text = "0.00"
            Me.TextBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox91
            '
            Me.TextBox91.BackColor = System.Drawing.Color.White
            Me.TextBox91.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox91.Location = New System.Drawing.Point(406, 70)
            Me.TextBox91.Name = "TextBox91"
            Me.TextBox91.ReadOnly = True
            Me.TextBox91.Size = New System.Drawing.Size(68, 13)
            Me.TextBox91.TabIndex = 42
            Me.TextBox91.Text = "0.00"
            Me.TextBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label58
            '
            Me.Label58.AutoSize = True
            Me.Label58.Location = New System.Drawing.Point(153, 45)
            Me.Label58.Name = "Label58"
            Me.Label58.Size = New System.Drawing.Size(109, 13)
            Me.Label58.TabIndex = 41
            Me.Label58.Text = "RETENCIÓN IVA 10%"
            '
            'Label59
            '
            Me.Label59.AutoSize = True
            Me.Label59.Location = New System.Drawing.Point(153, 70)
            Me.Label59.Name = "Label59"
            Me.Label59.Size = New System.Drawing.Size(109, 13)
            Me.Label59.TabIndex = 40
            Me.Label59.Text = "RETENCIÓN IVA 20%"
            '
            'TextBox75
            '
            Me.TextBox75.BackColor = System.Drawing.Color.White
            Me.TextBox75.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox75.Location = New System.Drawing.Point(406, 195)
            Me.TextBox75.Name = "TextBox75"
            Me.TextBox75.ReadOnly = True
            Me.TextBox75.Size = New System.Drawing.Size(68, 13)
            Me.TextBox75.TabIndex = 38
            Me.TextBox75.Text = "0.00"
            Me.TextBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox65
            '
            Me.TextBox65.BackColor = System.Drawing.Color.White
            Me.TextBox65.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox65.Location = New System.Drawing.Point(406, 170)
            Me.TextBox65.Name = "TextBox65"
            Me.TextBox65.ReadOnly = True
            Me.TextBox65.Size = New System.Drawing.Size(68, 13)
            Me.TextBox65.TabIndex = 37
            Me.TextBox65.Text = "0.00"
            Me.TextBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(154, 170)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(115, 13)
            Me.Label27.TabIndex = 36
            Me.Label27.Text = "RETENCIÓN IVA 100%"
            '
            'TextBox63
            '
            Me.TextBox63.BackColor = System.Drawing.Color.White
            Me.TextBox63.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox63.Location = New System.Drawing.Point(406, 145)
            Me.TextBox63.Name = "TextBox63"
            Me.TextBox63.ReadOnly = True
            Me.TextBox63.Size = New System.Drawing.Size(68, 13)
            Me.TextBox63.TabIndex = 35
            Me.TextBox63.Text = "0.00"
            Me.TextBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox64
            '
            Me.TextBox64.BackColor = System.Drawing.Color.White
            Me.TextBox64.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox64.Location = New System.Drawing.Point(406, 95)
            Me.TextBox64.Name = "TextBox64"
            Me.TextBox64.ReadOnly = True
            Me.TextBox64.Size = New System.Drawing.Size(68, 13)
            Me.TextBox64.TabIndex = 34
            Me.TextBox64.Text = "0.00"
            Me.TextBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(154, 145)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(109, 13)
            Me.Label25.TabIndex = 33
            Me.Label25.Text = "RETENCIÓN IVA 70%"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(154, 95)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(109, 13)
            Me.Label26.TabIndex = 32
            Me.Label26.Text = "RETENCIÓN IVA 30%"
            '
            'ShapeContainer5
            '
            Me.ShapeContainer5.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer5.Name = "ShapeContainer5"
            Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape55, Me.LineShape45, Me.LineShape44, Me.LineShape43, Me.LineShape42, Me.LineShape41, Me.LineShape40, Me.LineShape39, Me.LineShape38})
            Me.ShapeContainer5.Size = New System.Drawing.Size(489, 210)
            Me.ShapeContainer5.TabIndex = 103
            Me.ShapeContainer5.TabStop = False
            '
            'LineShape55
            '
            Me.LineShape55.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape55.Name = "LineShape55"
            Me.LineShape55.X1 = 488
            Me.LineShape55.X2 = 0
            Me.LineShape55.Y1 = 195
            Me.LineShape55.Y2 = 195
            '
            'LineShape45
            '
            Me.LineShape45.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape45.Name = "LineShape45"
            Me.LineShape45.X1 = 488
            Me.LineShape45.X2 = 0
            Me.LineShape45.Y1 = 170
            Me.LineShape45.Y2 = 170
            '
            'LineShape44
            '
            Me.LineShape44.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape44.Name = "LineShape44"
            Me.LineShape44.X1 = 333
            Me.LineShape44.X2 = 333
            Me.LineShape44.Y1 = 0
            Me.LineShape44.Y2 = 195
            '
            'LineShape43
            '
            Me.LineShape43.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape43.Name = "LineShape43"
            Me.LineShape43.X1 = 488
            Me.LineShape43.X2 = 0
            Me.LineShape43.Y1 = 145
            Me.LineShape43.Y2 = 145
            '
            'LineShape42
            '
            Me.LineShape42.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape42.Name = "LineShape42"
            Me.LineShape42.X1 = 488
            Me.LineShape42.X2 = 0
            Me.LineShape42.Y1 = 120
            Me.LineShape42.Y2 = 120
            '
            'LineShape41
            '
            Me.LineShape41.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape41.Name = "LineShape41"
            Me.LineShape41.X1 = 488
            Me.LineShape41.X2 = 0
            Me.LineShape41.Y1 = 95
            Me.LineShape41.Y2 = 95
            '
            'LineShape40
            '
            Me.LineShape40.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape40.Name = "LineShape40"
            Me.LineShape40.X1 = 488
            Me.LineShape40.X2 = 0
            Me.LineShape40.Y1 = 70
            Me.LineShape40.Y2 = 70
            '
            'LineShape39
            '
            Me.LineShape39.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape39.Name = "LineShape39"
            Me.LineShape39.X1 = 488
            Me.LineShape39.X2 = 0
            Me.LineShape39.Y1 = 45
            Me.LineShape39.Y2 = 45
            '
            'LineShape38
            '
            Me.LineShape38.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape38.Name = "LineShape38"
            Me.LineShape38.X1 = 488
            Me.LineShape38.X2 = 0
            Me.LineShape38.Y1 = 20
            Me.LineShape38.Y2 = 20
            '
            'gbVentas
            '
            Me.gbVentas.Controls.Add(Me.Label30)
            Me.gbVentas.Controls.Add(Me.Label76)
            Me.gbVentas.Controls.Add(Me.Label77)
            Me.gbVentas.Controls.Add(Me.Label78)
            Me.gbVentas.Controls.Add(Me.Label79)
            Me.gbVentas.Controls.Add(Me.TextBox71)
            Me.gbVentas.Controls.Add(Me.TextBox72)
            Me.gbVentas.Controls.Add(Me.TextBox73)
            Me.gbVentas.Controls.Add(Me.TextBox74)
            Me.gbVentas.Controls.Add(Me.TextBox55)
            Me.gbVentas.Controls.Add(Me.TextBox56)
            Me.gbVentas.Controls.Add(Me.TextBox57)
            Me.gbVentas.Controls.Add(Me.TextBox58)
            Me.gbVentas.Controls.Add(Me.TextBox59)
            Me.gbVentas.Controls.Add(Me.TextBox60)
            Me.gbVentas.Controls.Add(Me.TextBox61)
            Me.gbVentas.Controls.Add(Me.TextBox62)
            Me.gbVentas.Controls.Add(Me.Label23)
            Me.gbVentas.Controls.Add(Me.Label24)
            Me.gbVentas.Controls.Add(Me.ShapeContainer2)
            Me.gbVentas.Location = New System.Drawing.Point(0, 259)
            Me.gbVentas.Name = "gbVentas"
            Me.gbVentas.Size = New System.Drawing.Size(571, 115)
            Me.gbVentas.TabIndex = 2
            Me.gbVentas.TabStop = False
            Me.gbVentas.Text = "VENTAS"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(248, 95)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(49, 15)
            Me.Label30.TabIndex = 39
            Me.Label30.Text = "TOTAL:"
            '
            'Label76
            '
            Me.Label76.AutoSize = True
            Me.Label76.Location = New System.Drawing.Point(516, 10)
            Me.Label76.Name = "Label76"
            Me.Label76.Size = New System.Drawing.Size(37, 26)
            Me.Label76.TabIndex = 37
            Me.Label76.Text = "Valor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IVA"
            '
            'Label77
            '
            Me.Label77.AutoSize = True
            Me.Label77.Location = New System.Drawing.Point(351, 10)
            Me.Label77.Name = "Label77"
            Me.Label77.Size = New System.Drawing.Size(61, 26)
            Me.Label77.TabIndex = 36
            Me.Label77.Text = "BI tarifa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dif de 0%"
            '
            'Label78
            '
            Me.Label78.AutoSize = True
            Me.Label78.Location = New System.Drawing.Point(429, 10)
            Me.Label78.Name = "Label78"
            Me.Label78.Size = New System.Drawing.Size(67, 26)
            Me.Label78.TabIndex = 35
            Me.Label78.Text = "No objeto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de IVA"
            '
            'Label79
            '
            Me.Label79.AutoSize = True
            Me.Label79.Location = New System.Drawing.Point(301, 10)
            Me.Label79.Name = "Label79"
            Me.Label79.Size = New System.Drawing.Size(49, 13)
            Me.Label79.TabIndex = 34
            Me.Label79.Text = "Nro Reg"
            '
            'TextBox71
            '
            Me.TextBox71.BackColor = System.Drawing.Color.White
            Me.TextBox71.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox71.Location = New System.Drawing.Point(432, 95)
            Me.TextBox71.Name = "TextBox71"
            Me.TextBox71.ReadOnly = True
            Me.TextBox71.Size = New System.Drawing.Size(58, 13)
            Me.TextBox71.TabIndex = 25
            Me.TextBox71.Text = "0.00"
            Me.TextBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox72
            '
            Me.TextBox72.BackColor = System.Drawing.Color.White
            Me.TextBox72.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox72.Location = New System.Drawing.Point(499, 95)
            Me.TextBox72.Name = "TextBox72"
            Me.TextBox72.ReadOnly = True
            Me.TextBox72.Size = New System.Drawing.Size(64, 13)
            Me.TextBox72.TabIndex = 27
            Me.TextBox72.Text = "0.00"
            Me.TextBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox73
            '
            Me.TextBox73.BackColor = System.Drawing.Color.White
            Me.TextBox73.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox73.Location = New System.Drawing.Point(305, 95)
            Me.TextBox73.Name = "TextBox73"
            Me.TextBox73.ReadOnly = True
            Me.TextBox73.Size = New System.Drawing.Size(43, 13)
            Me.TextBox73.TabIndex = 24
            Me.TextBox73.Text = "0"
            Me.TextBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox74
            '
            Me.TextBox74.BackColor = System.Drawing.Color.White
            Me.TextBox74.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox74.Location = New System.Drawing.Point(354, 95)
            Me.TextBox74.Name = "TextBox74"
            Me.TextBox74.ReadOnly = True
            Me.TextBox74.Size = New System.Drawing.Size(67, 13)
            Me.TextBox74.TabIndex = 26
            Me.TextBox74.Text = "0.00"
            Me.TextBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox55
            '
            Me.TextBox55.BackColor = System.Drawing.Color.White
            Me.TextBox55.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox55.Location = New System.Drawing.Point(499, 70)
            Me.TextBox55.Name = "TextBox55"
            Me.TextBox55.ReadOnly = True
            Me.TextBox55.Size = New System.Drawing.Size(64, 13)
            Me.TextBox55.TabIndex = 23
            Me.TextBox55.Text = "0.00"
            Me.TextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox56
            '
            Me.TextBox56.BackColor = System.Drawing.Color.White
            Me.TextBox56.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox56.Location = New System.Drawing.Point(499, 45)
            Me.TextBox56.Name = "TextBox56"
            Me.TextBox56.ReadOnly = True
            Me.TextBox56.Size = New System.Drawing.Size(64, 13)
            Me.TextBox56.TabIndex = 22
            Me.TextBox56.Text = "0.00"
            Me.TextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox57
            '
            Me.TextBox57.BackColor = System.Drawing.Color.White
            Me.TextBox57.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox57.Location = New System.Drawing.Point(354, 70)
            Me.TextBox57.Name = "TextBox57"
            Me.TextBox57.ReadOnly = True
            Me.TextBox57.Size = New System.Drawing.Size(67, 13)
            Me.TextBox57.TabIndex = 21
            Me.TextBox57.Text = "0.00"
            Me.TextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox58
            '
            Me.TextBox58.BackColor = System.Drawing.Color.White
            Me.TextBox58.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox58.Location = New System.Drawing.Point(354, 45)
            Me.TextBox58.Name = "TextBox58"
            Me.TextBox58.ReadOnly = True
            Me.TextBox58.Size = New System.Drawing.Size(67, 13)
            Me.TextBox58.TabIndex = 20
            Me.TextBox58.Text = "0.00"
            Me.TextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox59
            '
            Me.TextBox59.BackColor = System.Drawing.Color.White
            Me.TextBox59.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox59.Location = New System.Drawing.Point(432, 70)
            Me.TextBox59.Name = "TextBox59"
            Me.TextBox59.ReadOnly = True
            Me.TextBox59.Size = New System.Drawing.Size(59, 13)
            Me.TextBox59.TabIndex = 19
            Me.TextBox59.Text = "0.00"
            Me.TextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox60
            '
            Me.TextBox60.BackColor = System.Drawing.Color.White
            Me.TextBox60.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox60.Location = New System.Drawing.Point(432, 45)
            Me.TextBox60.Name = "TextBox60"
            Me.TextBox60.ReadOnly = True
            Me.TextBox60.Size = New System.Drawing.Size(59, 13)
            Me.TextBox60.TabIndex = 18
            Me.TextBox60.Text = "0.00"
            Me.TextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox61
            '
            Me.TextBox61.BackColor = System.Drawing.Color.White
            Me.TextBox61.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox61.Location = New System.Drawing.Point(305, 70)
            Me.TextBox61.Name = "TextBox61"
            Me.TextBox61.ReadOnly = True
            Me.TextBox61.Size = New System.Drawing.Size(43, 13)
            Me.TextBox61.TabIndex = 17
            Me.TextBox61.Text = "0"
            Me.TextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox62
            '
            Me.TextBox62.BackColor = System.Drawing.Color.White
            Me.TextBox62.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox62.Location = New System.Drawing.Point(305, 45)
            Me.TextBox62.Name = "TextBox62"
            Me.TextBox62.ReadOnly = True
            Me.TextBox62.Size = New System.Drawing.Size(43, 13)
            Me.TextBox62.TabIndex = 16
            Me.TextBox62.Text = "0"
            Me.TextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(2, 70)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(295, 13)
            Me.Label23.TabIndex = 15
            Me.Label23.Text = "DOCUMENTOS AUTORIZADOS EN VENTAS EXCEPTO ND Y NC"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(2, 45)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(103, 13)
            Me.Label24.TabIndex = 14
            Me.Label24.Text = "NOTAS DE CRÉDITO"
            '
            'ShapeContainer2
            '
            Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer2.Name = "ShapeContainer2"
            Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape52, Me.LineShape17, Me.LineShape16, Me.LineShape15, Me.LineShape14, Me.LineShape13, Me.LineShape12, Me.LineShape11})
            Me.ShapeContainer2.Size = New System.Drawing.Size(565, 96)
            Me.ShapeContainer2.TabIndex = 38
            Me.ShapeContainer2.TabStop = False
            '
            'LineShape52
            '
            Me.LineShape52.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape52.Name = "LineShape52"
            Me.LineShape52.X1 = 565
            Me.LineShape52.X2 = 0
            Me.LineShape52.Y1 = 95
            Me.LineShape52.Y2 = 95
            '
            'LineShape17
            '
            Me.LineShape17.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape17.Name = "LineShape17"
            Me.LineShape17.X1 = 565
            Me.LineShape17.X2 = 0
            Me.LineShape17.Y1 = 70
            Me.LineShape17.Y2 = 70
            '
            'LineShape16
            '
            Me.LineShape16.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape16.Name = "LineShape16"
            Me.LineShape16.X1 = 565
            Me.LineShape16.X2 = 0
            Me.LineShape16.Y1 = 45
            Me.LineShape16.Y2 = 45
            '
            'LineShape15
            '
            Me.LineShape15.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape15.Name = "LineShape15"
            Me.LineShape15.X1 = 565
            Me.LineShape15.X2 = 0
            Me.LineShape15.Y1 = 20
            Me.LineShape15.Y2 = 20
            '
            'LineShape14
            '
            Me.LineShape14.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape14.Name = "LineShape14"
            Me.LineShape14.X1 = 493
            Me.LineShape14.X2 = 493
            Me.LineShape14.Y1 = 0
            Me.LineShape14.Y2 = 94
            '
            'LineShape13
            '
            Me.LineShape13.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape13.Name = "LineShape13"
            Me.LineShape13.X1 = 422
            Me.LineShape13.X2 = 422
            Me.LineShape13.Y1 = 0
            Me.LineShape13.Y2 = 94
            '
            'LineShape12
            '
            Me.LineShape12.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape12.Name = "LineShape12"
            Me.LineShape12.X1 = 347
            Me.LineShape12.X2 = 347
            Me.LineShape12.Y1 = 0
            Me.LineShape12.Y2 = 94
            '
            'LineShape11
            '
            Me.LineShape11.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape11.Name = "LineShape11"
            Me.LineShape11.X1 = 296
            Me.LineShape11.X2 = 296
            Me.LineShape11.Y1 = 0
            Me.LineShape11.Y2 = 94
            '
            'gbRetencionesFuenteRenta
            '
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox103)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label97)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox102)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label96)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label73)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label74)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label75)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label72)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label71)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label33)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label69)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox89)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox95)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox88)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox87)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox96)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox86)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox97)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label57)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label65)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label56)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox92)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label55)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox93)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox94)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label64)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox77)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox9)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox28)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label7)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox29)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox30)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox31)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox32)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox33)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox34)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox35)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox36)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label14)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label15)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label16)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox37)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox38)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox39)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox40)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox41)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox42)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox43)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox44)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox45)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label17)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label18)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label19)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox46)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox47)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox48)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox49)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox50)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox51)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox52)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox53)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox54)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label20)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label21)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label22)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox19)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox20)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox21)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox22)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox23)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox24)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox25)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox26)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox27)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label11)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label12)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label13)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox10)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox11)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox12)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox13)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox14)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox15)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox16)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox17)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox18)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label8)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label9)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label10)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox1)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox2)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox3)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox4)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox5)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox6)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox7)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.TextBox8)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label5)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label6)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.Label51)
            Me.gbRetencionesFuenteRenta.Controls.Add(Me.ShapeContainer4)
            Me.gbRetencionesFuenteRenta.Location = New System.Drawing.Point(574, 34)
            Me.gbRetencionesFuenteRenta.Name = "gbRetencionesFuenteRenta"
            Me.gbRetencionesFuenteRenta.Size = New System.Drawing.Size(495, 340)
            Me.gbRetencionesFuenteRenta.TabIndex = 1
            Me.gbRetencionesFuenteRenta.TabStop = False
            Me.gbRetencionesFuenteRenta.Text = "RETENCIONES EN LA FUENTE DEL IMPUESTO A LA RENTA"
            '
            'TextBox103
            '
            Me.TextBox103.BackColor = System.Drawing.Color.White
            Me.TextBox103.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox103.Location = New System.Drawing.Point(268, 311)
            Me.TextBox103.Name = "TextBox103"
            Me.TextBox103.ReadOnly = True
            Me.TextBox103.Size = New System.Drawing.Size(60, 13)
            Me.TextBox103.TabIndex = 106
            Me.TextBox103.Text = "0.00"
            Me.TextBox103.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label97
            '
            Me.Label97.AutoSize = True
            Me.Label97.Location = New System.Drawing.Point(271, 294)
            Me.Label97.Name = "Label97"
            Me.Label97.Size = New System.Drawing.Size(61, 13)
            Me.Label97.TabIndex = 105
            Me.Label97.Text = "T. 1.75%:"
            '
            'TextBox102
            '
            Me.TextBox102.BackColor = System.Drawing.Color.White
            Me.TextBox102.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox102.Location = New System.Drawing.Point(415, 318)
            Me.TextBox102.Name = "TextBox102"
            Me.TextBox102.ReadOnly = True
            Me.TextBox102.Size = New System.Drawing.Size(60, 13)
            Me.TextBox102.TabIndex = 104
            Me.TextBox102.Text = "0.00"
            Me.TextBox102.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label96
            '
            Me.Label96.AutoSize = True
            Me.Label96.Location = New System.Drawing.Point(349, 318)
            Me.Label96.Name = "Label96"
            Me.Label96.Size = New System.Drawing.Size(61, 13)
            Me.Label96.TabIndex = 103
            Me.Label96.Text = "T. 2.75%:"
            '
            'Label73
            '
            Me.Label73.AutoSize = True
            Me.Label73.Location = New System.Drawing.Point(419, 20)
            Me.Label73.Name = "Label73"
            Me.Label73.Size = New System.Drawing.Size(37, 13)
            Me.Label73.TabIndex = 101
            Me.Label73.Text = "Valor"
            '
            'Label74
            '
            Me.Label74.AutoSize = True
            Me.Label74.Location = New System.Drawing.Point(339, 20)
            Me.Label74.Name = "Label74"
            Me.Label74.Size = New System.Drawing.Size(61, 13)
            Me.Label74.TabIndex = 100
            Me.Label74.Text = "Base Imp."
            '
            'Label75
            '
            Me.Label75.AutoSize = True
            Me.Label75.Location = New System.Drawing.Point(286, 20)
            Me.Label75.Name = "Label75"
            Me.Label75.Size = New System.Drawing.Size(49, 13)
            Me.Label75.TabIndex = 99
            Me.Label75.Text = "Nro Reg"
            '
            'Label72
            '
            Me.Label72.AutoSize = True
            Me.Label72.Location = New System.Drawing.Point(173, 20)
            Me.Label72.Name = "Label72"
            Me.Label72.Size = New System.Drawing.Size(37, 13)
            Me.Label72.TabIndex = 98
            Me.Label72.Text = "Valor"
            '
            'Label71
            '
            Me.Label71.AutoSize = True
            Me.Label71.Location = New System.Drawing.Point(100, 20)
            Me.Label71.Name = "Label71"
            Me.Label71.Size = New System.Drawing.Size(61, 13)
            Me.Label71.TabIndex = 97
            Me.Label71.Text = "Base Imp."
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Location = New System.Drawing.Point(44, 20)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(49, 13)
            Me.Label33.TabIndex = 96
            Me.Label33.Text = "Nro Reg"
            '
            'Label69
            '
            Me.Label69.AutoSize = True
            Me.Label69.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label69.Location = New System.Drawing.Point(337, 295)
            Me.Label69.Name = "Label69"
            Me.Label69.Size = New System.Drawing.Size(43, 13)
            Me.Label69.TabIndex = 94
            Me.Label69.Text = "TOTAL:"
            '
            'TextBox89
            '
            Me.TextBox89.BackColor = System.Drawing.Color.White
            Me.TextBox89.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox89.Location = New System.Drawing.Point(195, 320)
            Me.TextBox89.Name = "TextBox89"
            Me.TextBox89.ReadOnly = True
            Me.TextBox89.Size = New System.Drawing.Size(60, 13)
            Me.TextBox89.TabIndex = 70
            Me.TextBox89.Text = "0.00"
            Me.TextBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox95
            '
            Me.TextBox95.BackColor = System.Drawing.Color.White
            Me.TextBox95.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox95.Location = New System.Drawing.Point(408, 195)
            Me.TextBox95.Name = "TextBox95"
            Me.TextBox95.ReadOnly = True
            Me.TextBox95.Size = New System.Drawing.Size(65, 13)
            Me.TextBox95.TabIndex = 93
            Me.TextBox95.Text = "0.00"
            Me.TextBox95.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox88
            '
            Me.TextBox88.BackColor = System.Drawing.Color.White
            Me.TextBox88.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox88.Location = New System.Drawing.Point(60, 320)
            Me.TextBox88.Name = "TextBox88"
            Me.TextBox88.ReadOnly = True
            Me.TextBox88.Size = New System.Drawing.Size(60, 13)
            Me.TextBox88.TabIndex = 69
            Me.TextBox88.Text = "0.00"
            Me.TextBox88.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox87
            '
            Me.TextBox87.BackColor = System.Drawing.Color.White
            Me.TextBox87.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox87.Location = New System.Drawing.Point(195, 295)
            Me.TextBox87.Name = "TextBox87"
            Me.TextBox87.ReadOnly = True
            Me.TextBox87.Size = New System.Drawing.Size(60, 13)
            Me.TextBox87.TabIndex = 68
            Me.TextBox87.Text = "0.00"
            Me.TextBox87.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox96
            '
            Me.TextBox96.BackColor = System.Drawing.Color.White
            Me.TextBox96.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox96.Location = New System.Drawing.Point(338, 195)
            Me.TextBox96.Name = "TextBox96"
            Me.TextBox96.ReadOnly = True
            Me.TextBox96.Size = New System.Drawing.Size(65, 13)
            Me.TextBox96.TabIndex = 92
            Me.TextBox96.Text = "0.00"
            Me.TextBox96.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox86
            '
            Me.TextBox86.BackColor = System.Drawing.Color.White
            Me.TextBox86.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox86.Location = New System.Drawing.Point(60, 295)
            Me.TextBox86.Name = "TextBox86"
            Me.TextBox86.ReadOnly = True
            Me.TextBox86.Size = New System.Drawing.Size(60, 13)
            Me.TextBox86.TabIndex = 67
            Me.TextBox86.Text = "0.00"
            Me.TextBox86.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox97
            '
            Me.TextBox97.BackColor = System.Drawing.Color.White
            Me.TextBox97.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox97.Location = New System.Drawing.Point(290, 195)
            Me.TextBox97.Name = "TextBox97"
            Me.TextBox97.ReadOnly = True
            Me.TextBox97.Size = New System.Drawing.Size(43, 13)
            Me.TextBox97.TabIndex = 91
            Me.TextBox97.Text = "0"
            Me.TextBox97.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label57
            '
            Me.Label57.AutoSize = True
            Me.Label57.Location = New System.Drawing.Point(130, 320)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(67, 13)
            Me.Label57.TabIndex = 4
            Me.Label57.Text = "Total 10%:"
            '
            'Label65
            '
            Me.Label65.AutoSize = True
            Me.Label65.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label65.Location = New System.Drawing.Point(244, 195)
            Me.Label65.Name = "Label65"
            Me.Label65.Size = New System.Drawing.Size(31, 13)
            Me.Label65.TabIndex = 90
            Me.Label65.Text = "3440"
            '
            'Label56
            '
            Me.Label56.AutoSize = True
            Me.Label56.Location = New System.Drawing.Point(3, 320)
            Me.Label56.Name = "Label56"
            Me.Label56.Size = New System.Drawing.Size(61, 13)
            Me.Label56.TabIndex = 3
            Me.Label56.Text = "Total 8%:"
            '
            'TextBox92
            '
            Me.TextBox92.BackColor = System.Drawing.Color.White
            Me.TextBox92.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox92.Location = New System.Drawing.Point(167, 220)
            Me.TextBox92.Name = "TextBox92"
            Me.TextBox92.ReadOnly = True
            Me.TextBox92.Size = New System.Drawing.Size(65, 13)
            Me.TextBox92.TabIndex = 89
            Me.TextBox92.Text = "0.00"
            Me.TextBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label55
            '
            Me.Label55.AutoSize = True
            Me.Label55.Location = New System.Drawing.Point(130, 295)
            Me.Label55.Name = "Label55"
            Me.Label55.Size = New System.Drawing.Size(61, 13)
            Me.Label55.TabIndex = 2
            Me.Label55.Text = "Total 2%:"
            '
            'TextBox93
            '
            Me.TextBox93.BackColor = System.Drawing.Color.White
            Me.TextBox93.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox93.Location = New System.Drawing.Point(97, 220)
            Me.TextBox93.Name = "TextBox93"
            Me.TextBox93.ReadOnly = True
            Me.TextBox93.Size = New System.Drawing.Size(65, 13)
            Me.TextBox93.TabIndex = 88
            Me.TextBox93.Text = "0.00"
            Me.TextBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox94
            '
            Me.TextBox94.BackColor = System.Drawing.Color.White
            Me.TextBox94.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox94.Location = New System.Drawing.Point(49, 220)
            Me.TextBox94.Name = "TextBox94"
            Me.TextBox94.ReadOnly = True
            Me.TextBox94.Size = New System.Drawing.Size(43, 13)
            Me.TextBox94.TabIndex = 87
            Me.TextBox94.Text = "0"
            Me.TextBox94.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label64
            '
            Me.Label64.AutoSize = True
            Me.Label64.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label64.Location = New System.Drawing.Point(3, 220)
            Me.Label64.Name = "Label64"
            Me.Label64.Size = New System.Drawing.Size(25, 13)
            Me.Label64.TabIndex = 86
            Me.Label64.Text = "311"
            '
            'TextBox77
            '
            Me.TextBox77.BackColor = System.Drawing.Color.White
            Me.TextBox77.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox77.Location = New System.Drawing.Point(406, 295)
            Me.TextBox77.Name = "TextBox77"
            Me.TextBox77.ReadOnly = True
            Me.TextBox77.Size = New System.Drawing.Size(68, 13)
            Me.TextBox77.TabIndex = 84
            Me.TextBox77.Text = "0.00"
            Me.TextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox9
            '
            Me.TextBox9.BackColor = System.Drawing.Color.White
            Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox9.Location = New System.Drawing.Point(49, 45)
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.ReadOnly = True
            Me.TextBox9.Size = New System.Drawing.Size(43, 13)
            Me.TextBox9.TabIndex = 15
            Me.TextBox9.Text = "0"
            Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox28
            '
            Me.TextBox28.BackColor = System.Drawing.Color.White
            Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox28.Location = New System.Drawing.Point(408, 270)
            Me.TextBox28.Name = "TextBox28"
            Me.TextBox28.ReadOnly = True
            Me.TextBox28.Size = New System.Drawing.Size(65, 13)
            Me.TextBox28.TabIndex = 83
            Me.TextBox28.Text = "0.00"
            Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(3, 45)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(25, 13)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "302"
            '
            'TextBox29
            '
            Me.TextBox29.BackColor = System.Drawing.Color.White
            Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox29.Location = New System.Drawing.Point(408, 245)
            Me.TextBox29.Name = "TextBox29"
            Me.TextBox29.ReadOnly = True
            Me.TextBox29.Size = New System.Drawing.Size(65, 13)
            Me.TextBox29.TabIndex = 82
            Me.TextBox29.Text = "0.00"
            Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox30
            '
            Me.TextBox30.BackColor = System.Drawing.Color.White
            Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox30.Location = New System.Drawing.Point(408, 220)
            Me.TextBox30.Name = "TextBox30"
            Me.TextBox30.ReadOnly = True
            Me.TextBox30.Size = New System.Drawing.Size(65, 13)
            Me.TextBox30.TabIndex = 81
            Me.TextBox30.Text = "0.00"
            Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox31
            '
            Me.TextBox31.BackColor = System.Drawing.Color.White
            Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox31.Location = New System.Drawing.Point(338, 270)
            Me.TextBox31.Name = "TextBox31"
            Me.TextBox31.ReadOnly = True
            Me.TextBox31.Size = New System.Drawing.Size(65, 13)
            Me.TextBox31.TabIndex = 80
            Me.TextBox31.Text = "0.00"
            Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox32
            '
            Me.TextBox32.BackColor = System.Drawing.Color.White
            Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox32.Location = New System.Drawing.Point(338, 245)
            Me.TextBox32.Name = "TextBox32"
            Me.TextBox32.ReadOnly = True
            Me.TextBox32.Size = New System.Drawing.Size(65, 13)
            Me.TextBox32.TabIndex = 79
            Me.TextBox32.Text = "0.00"
            Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox33
            '
            Me.TextBox33.BackColor = System.Drawing.Color.White
            Me.TextBox33.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox33.Location = New System.Drawing.Point(338, 220)
            Me.TextBox33.Name = "TextBox33"
            Me.TextBox33.ReadOnly = True
            Me.TextBox33.Size = New System.Drawing.Size(65, 13)
            Me.TextBox33.TabIndex = 78
            Me.TextBox33.Text = "0.00"
            Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox34
            '
            Me.TextBox34.BackColor = System.Drawing.Color.White
            Me.TextBox34.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox34.Location = New System.Drawing.Point(290, 270)
            Me.TextBox34.Name = "TextBox34"
            Me.TextBox34.ReadOnly = True
            Me.TextBox34.Size = New System.Drawing.Size(43, 13)
            Me.TextBox34.TabIndex = 77
            Me.TextBox34.Text = "0"
            Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox35
            '
            Me.TextBox35.BackColor = System.Drawing.Color.White
            Me.TextBox35.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox35.Location = New System.Drawing.Point(290, 245)
            Me.TextBox35.Name = "TextBox35"
            Me.TextBox35.ReadOnly = True
            Me.TextBox35.Size = New System.Drawing.Size(43, 13)
            Me.TextBox35.TabIndex = 76
            Me.TextBox35.Text = "0"
            Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox36
            '
            Me.TextBox36.BackColor = System.Drawing.Color.White
            Me.TextBox36.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox36.Location = New System.Drawing.Point(290, 220)
            Me.TextBox36.Name = "TextBox36"
            Me.TextBox36.ReadOnly = True
            Me.TextBox36.Size = New System.Drawing.Size(43, 13)
            Me.TextBox36.TabIndex = 75
            Me.TextBox36.Text = "0"
            Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(244, 270)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(25, 13)
            Me.Label14.TabIndex = 74
            Me.Label14.Text = "421"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(244, 245)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(25, 13)
            Me.Label15.TabIndex = 73
            Me.Label15.Text = "405"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(244, 220)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(25, 13)
            Me.Label16.TabIndex = 72
            Me.Label16.Text = "403"
            '
            'TextBox37
            '
            Me.TextBox37.BackColor = System.Drawing.Color.White
            Me.TextBox37.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox37.Location = New System.Drawing.Point(408, 95)
            Me.TextBox37.Name = "TextBox37"
            Me.TextBox37.ReadOnly = True
            Me.TextBox37.Size = New System.Drawing.Size(65, 13)
            Me.TextBox37.TabIndex = 71
            Me.TextBox37.Text = "0.00"
            Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox38
            '
            Me.TextBox38.BackColor = System.Drawing.Color.White
            Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox38.Location = New System.Drawing.Point(408, 70)
            Me.TextBox38.Name = "TextBox38"
            Me.TextBox38.ReadOnly = True
            Me.TextBox38.Size = New System.Drawing.Size(65, 13)
            Me.TextBox38.TabIndex = 70
            Me.TextBox38.Text = "0.00"
            Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox39
            '
            Me.TextBox39.BackColor = System.Drawing.Color.White
            Me.TextBox39.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox39.Location = New System.Drawing.Point(408, 45)
            Me.TextBox39.Name = "TextBox39"
            Me.TextBox39.ReadOnly = True
            Me.TextBox39.Size = New System.Drawing.Size(65, 13)
            Me.TextBox39.TabIndex = 69
            Me.TextBox39.Text = "0.00"
            Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox40
            '
            Me.TextBox40.BackColor = System.Drawing.Color.White
            Me.TextBox40.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox40.Location = New System.Drawing.Point(338, 95)
            Me.TextBox40.Name = "TextBox40"
            Me.TextBox40.ReadOnly = True
            Me.TextBox40.Size = New System.Drawing.Size(65, 13)
            Me.TextBox40.TabIndex = 68
            Me.TextBox40.Text = "0.00"
            Me.TextBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox41
            '
            Me.TextBox41.BackColor = System.Drawing.Color.White
            Me.TextBox41.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox41.Location = New System.Drawing.Point(338, 70)
            Me.TextBox41.Name = "TextBox41"
            Me.TextBox41.ReadOnly = True
            Me.TextBox41.Size = New System.Drawing.Size(65, 13)
            Me.TextBox41.TabIndex = 67
            Me.TextBox41.Text = "0.00"
            Me.TextBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox42
            '
            Me.TextBox42.BackColor = System.Drawing.Color.White
            Me.TextBox42.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox42.Location = New System.Drawing.Point(338, 45)
            Me.TextBox42.Name = "TextBox42"
            Me.TextBox42.ReadOnly = True
            Me.TextBox42.Size = New System.Drawing.Size(65, 13)
            Me.TextBox42.TabIndex = 66
            Me.TextBox42.Text = "0.00"
            Me.TextBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox43
            '
            Me.TextBox43.BackColor = System.Drawing.Color.White
            Me.TextBox43.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox43.Location = New System.Drawing.Point(290, 95)
            Me.TextBox43.Name = "TextBox43"
            Me.TextBox43.ReadOnly = True
            Me.TextBox43.Size = New System.Drawing.Size(43, 13)
            Me.TextBox43.TabIndex = 65
            Me.TextBox43.Text = "0"
            Me.TextBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox44
            '
            Me.TextBox44.BackColor = System.Drawing.Color.White
            Me.TextBox44.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox44.Location = New System.Drawing.Point(290, 70)
            Me.TextBox44.Name = "TextBox44"
            Me.TextBox44.ReadOnly = True
            Me.TextBox44.Size = New System.Drawing.Size(43, 13)
            Me.TextBox44.TabIndex = 64
            Me.TextBox44.Text = "0"
            Me.TextBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox45
            '
            Me.TextBox45.BackColor = System.Drawing.Color.White
            Me.TextBox45.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox45.Location = New System.Drawing.Point(290, 45)
            Me.TextBox45.Name = "TextBox45"
            Me.TextBox45.ReadOnly = True
            Me.TextBox45.Size = New System.Drawing.Size(43, 13)
            Me.TextBox45.TabIndex = 63
            Me.TextBox45.Text = "0"
            Me.TextBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(244, 98)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(25, 13)
            Me.Label17.TabIndex = 62
            Me.Label17.Text = "340"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(244, 70)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(25, 13)
            Me.Label18.TabIndex = 61
            Me.Label18.Text = "332"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(244, 45)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(25, 13)
            Me.Label19.TabIndex = 60
            Me.Label19.Text = "322"
            '
            'TextBox46
            '
            Me.TextBox46.BackColor = System.Drawing.Color.White
            Me.TextBox46.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox46.Location = New System.Drawing.Point(167, 170)
            Me.TextBox46.Name = "TextBox46"
            Me.TextBox46.ReadOnly = True
            Me.TextBox46.Size = New System.Drawing.Size(65, 13)
            Me.TextBox46.TabIndex = 59
            Me.TextBox46.Text = "0.00"
            Me.TextBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox47
            '
            Me.TextBox47.BackColor = System.Drawing.Color.White
            Me.TextBox47.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox47.Location = New System.Drawing.Point(167, 145)
            Me.TextBox47.Name = "TextBox47"
            Me.TextBox47.ReadOnly = True
            Me.TextBox47.Size = New System.Drawing.Size(65, 13)
            Me.TextBox47.TabIndex = 58
            Me.TextBox47.Text = "0.00"
            Me.TextBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox48
            '
            Me.TextBox48.BackColor = System.Drawing.Color.White
            Me.TextBox48.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox48.Location = New System.Drawing.Point(167, 120)
            Me.TextBox48.Name = "TextBox48"
            Me.TextBox48.ReadOnly = True
            Me.TextBox48.Size = New System.Drawing.Size(65, 13)
            Me.TextBox48.TabIndex = 57
            Me.TextBox48.Text = "0.00"
            Me.TextBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox49
            '
            Me.TextBox49.BackColor = System.Drawing.Color.White
            Me.TextBox49.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox49.Location = New System.Drawing.Point(97, 170)
            Me.TextBox49.Name = "TextBox49"
            Me.TextBox49.ReadOnly = True
            Me.TextBox49.Size = New System.Drawing.Size(65, 13)
            Me.TextBox49.TabIndex = 56
            Me.TextBox49.Text = "0.00"
            Me.TextBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox50
            '
            Me.TextBox50.BackColor = System.Drawing.Color.White
            Me.TextBox50.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox50.Location = New System.Drawing.Point(97, 145)
            Me.TextBox50.Name = "TextBox50"
            Me.TextBox50.ReadOnly = True
            Me.TextBox50.Size = New System.Drawing.Size(65, 13)
            Me.TextBox50.TabIndex = 55
            Me.TextBox50.Text = "0.00"
            Me.TextBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox51
            '
            Me.TextBox51.BackColor = System.Drawing.Color.White
            Me.TextBox51.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox51.Location = New System.Drawing.Point(97, 120)
            Me.TextBox51.Name = "TextBox51"
            Me.TextBox51.ReadOnly = True
            Me.TextBox51.Size = New System.Drawing.Size(65, 13)
            Me.TextBox51.TabIndex = 54
            Me.TextBox51.Text = "0.00"
            Me.TextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox52
            '
            Me.TextBox52.BackColor = System.Drawing.Color.White
            Me.TextBox52.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox52.Location = New System.Drawing.Point(49, 170)
            Me.TextBox52.Name = "TextBox52"
            Me.TextBox52.ReadOnly = True
            Me.TextBox52.Size = New System.Drawing.Size(43, 13)
            Me.TextBox52.TabIndex = 53
            Me.TextBox52.Text = "0"
            Me.TextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox53
            '
            Me.TextBox53.BackColor = System.Drawing.Color.White
            Me.TextBox53.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox53.Location = New System.Drawing.Point(49, 145)
            Me.TextBox53.Name = "TextBox53"
            Me.TextBox53.ReadOnly = True
            Me.TextBox53.Size = New System.Drawing.Size(43, 13)
            Me.TextBox53.TabIndex = 52
            Me.TextBox53.Text = "0"
            Me.TextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox54
            '
            Me.TextBox54.BackColor = System.Drawing.Color.White
            Me.TextBox54.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox54.Location = New System.Drawing.Point(49, 120)
            Me.TextBox54.Name = "TextBox54"
            Me.TextBox54.ReadOnly = True
            Me.TextBox54.Size = New System.Drawing.Size(43, 13)
            Me.TextBox54.TabIndex = 51
            Me.TextBox54.Text = "0"
            Me.TextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(3, 170)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(25, 13)
            Me.Label20.TabIndex = 50
            Me.Label20.Text = "309"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(3, 145)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(25, 13)
            Me.Label21.TabIndex = 49
            Me.Label21.Text = "308"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(3, 120)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(25, 13)
            Me.Label22.TabIndex = 48
            Me.Label22.Text = "307"
            '
            'TextBox19
            '
            Me.TextBox19.BackColor = System.Drawing.Color.White
            Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox19.Location = New System.Drawing.Point(408, 170)
            Me.TextBox19.Name = "TextBox19"
            Me.TextBox19.ReadOnly = True
            Me.TextBox19.Size = New System.Drawing.Size(65, 13)
            Me.TextBox19.TabIndex = 47
            Me.TextBox19.Text = "0.00"
            Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox20
            '
            Me.TextBox20.BackColor = System.Drawing.Color.White
            Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox20.Location = New System.Drawing.Point(408, 145)
            Me.TextBox20.Name = "TextBox20"
            Me.TextBox20.ReadOnly = True
            Me.TextBox20.Size = New System.Drawing.Size(65, 13)
            Me.TextBox20.TabIndex = 46
            Me.TextBox20.Text = "0.00"
            Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox21
            '
            Me.TextBox21.BackColor = System.Drawing.Color.White
            Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox21.Location = New System.Drawing.Point(408, 120)
            Me.TextBox21.Name = "TextBox21"
            Me.TextBox21.ReadOnly = True
            Me.TextBox21.Size = New System.Drawing.Size(65, 13)
            Me.TextBox21.TabIndex = 45
            Me.TextBox21.Text = "0.00"
            Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox22
            '
            Me.TextBox22.BackColor = System.Drawing.Color.White
            Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox22.Location = New System.Drawing.Point(338, 170)
            Me.TextBox22.Name = "TextBox22"
            Me.TextBox22.ReadOnly = True
            Me.TextBox22.Size = New System.Drawing.Size(65, 13)
            Me.TextBox22.TabIndex = 44
            Me.TextBox22.Text = "0.00"
            Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox23
            '
            Me.TextBox23.BackColor = System.Drawing.Color.White
            Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox23.Location = New System.Drawing.Point(338, 145)
            Me.TextBox23.Name = "TextBox23"
            Me.TextBox23.ReadOnly = True
            Me.TextBox23.Size = New System.Drawing.Size(65, 13)
            Me.TextBox23.TabIndex = 43
            Me.TextBox23.Text = "0.00"
            Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox24
            '
            Me.TextBox24.BackColor = System.Drawing.Color.White
            Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox24.Location = New System.Drawing.Point(338, 120)
            Me.TextBox24.Name = "TextBox24"
            Me.TextBox24.ReadOnly = True
            Me.TextBox24.Size = New System.Drawing.Size(65, 13)
            Me.TextBox24.TabIndex = 42
            Me.TextBox24.Text = "0.00"
            Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox25
            '
            Me.TextBox25.BackColor = System.Drawing.Color.White
            Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox25.Location = New System.Drawing.Point(290, 170)
            Me.TextBox25.Name = "TextBox25"
            Me.TextBox25.ReadOnly = True
            Me.TextBox25.Size = New System.Drawing.Size(43, 13)
            Me.TextBox25.TabIndex = 41
            Me.TextBox25.Text = "0"
            Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox26
            '
            Me.TextBox26.BackColor = System.Drawing.Color.White
            Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox26.Location = New System.Drawing.Point(290, 145)
            Me.TextBox26.Name = "TextBox26"
            Me.TextBox26.ReadOnly = True
            Me.TextBox26.Size = New System.Drawing.Size(43, 13)
            Me.TextBox26.TabIndex = 40
            Me.TextBox26.Text = "0"
            Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox27
            '
            Me.TextBox27.BackColor = System.Drawing.Color.White
            Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox27.Location = New System.Drawing.Point(290, 121)
            Me.TextBox27.Name = "TextBox27"
            Me.TextBox27.ReadOnly = True
            Me.TextBox27.Size = New System.Drawing.Size(43, 13)
            Me.TextBox27.TabIndex = 39
            Me.TextBox27.Text = "0"
            Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(244, 170)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(25, 13)
            Me.Label11.TabIndex = 38
            Me.Label11.Text = "343"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(244, 145)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(25, 13)
            Me.Label12.TabIndex = 37
            Me.Label12.Text = "342"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(244, 120)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(25, 13)
            Me.Label13.TabIndex = 36
            Me.Label13.Text = "341"
            '
            'TextBox10
            '
            Me.TextBox10.BackColor = System.Drawing.Color.White
            Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox10.Location = New System.Drawing.Point(167, 270)
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.ReadOnly = True
            Me.TextBox10.Size = New System.Drawing.Size(65, 13)
            Me.TextBox10.TabIndex = 35
            Me.TextBox10.Text = "0.00"
            Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox11
            '
            Me.TextBox11.BackColor = System.Drawing.Color.White
            Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox11.Location = New System.Drawing.Point(167, 245)
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.ReadOnly = True
            Me.TextBox11.Size = New System.Drawing.Size(65, 13)
            Me.TextBox11.TabIndex = 34
            Me.TextBox11.Text = "0.00"
            Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox12
            '
            Me.TextBox12.BackColor = System.Drawing.Color.White
            Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox12.Location = New System.Drawing.Point(167, 195)
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.ReadOnly = True
            Me.TextBox12.Size = New System.Drawing.Size(65, 13)
            Me.TextBox12.TabIndex = 33
            Me.TextBox12.Text = "0.00"
            Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox13
            '
            Me.TextBox13.BackColor = System.Drawing.Color.White
            Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox13.Location = New System.Drawing.Point(97, 270)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.ReadOnly = True
            Me.TextBox13.Size = New System.Drawing.Size(65, 13)
            Me.TextBox13.TabIndex = 32
            Me.TextBox13.Text = "0.00"
            Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox14
            '
            Me.TextBox14.BackColor = System.Drawing.Color.White
            Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox14.Location = New System.Drawing.Point(97, 245)
            Me.TextBox14.Name = "TextBox14"
            Me.TextBox14.ReadOnly = True
            Me.TextBox14.Size = New System.Drawing.Size(65, 13)
            Me.TextBox14.TabIndex = 31
            Me.TextBox14.Text = "0.00"
            Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox15
            '
            Me.TextBox15.BackColor = System.Drawing.Color.White
            Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox15.Location = New System.Drawing.Point(97, 195)
            Me.TextBox15.Name = "TextBox15"
            Me.TextBox15.ReadOnly = True
            Me.TextBox15.Size = New System.Drawing.Size(65, 13)
            Me.TextBox15.TabIndex = 30
            Me.TextBox15.Text = "0.00"
            Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox16
            '
            Me.TextBox16.BackColor = System.Drawing.Color.White
            Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox16.Location = New System.Drawing.Point(49, 270)
            Me.TextBox16.Name = "TextBox16"
            Me.TextBox16.ReadOnly = True
            Me.TextBox16.Size = New System.Drawing.Size(43, 13)
            Me.TextBox16.TabIndex = 29
            Me.TextBox16.Text = "0"
            Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox17
            '
            Me.TextBox17.BackColor = System.Drawing.Color.White
            Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox17.Location = New System.Drawing.Point(49, 245)
            Me.TextBox17.Name = "TextBox17"
            Me.TextBox17.ReadOnly = True
            Me.TextBox17.Size = New System.Drawing.Size(43, 13)
            Me.TextBox17.TabIndex = 28
            Me.TextBox17.Text = "0"
            Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox18
            '
            Me.TextBox18.BackColor = System.Drawing.Color.White
            Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox18.Location = New System.Drawing.Point(49, 195)
            Me.TextBox18.Name = "TextBox18"
            Me.TextBox18.ReadOnly = True
            Me.TextBox18.Size = New System.Drawing.Size(43, 13)
            Me.TextBox18.TabIndex = 27
            Me.TextBox18.Text = "0"
            Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(3, 270)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(25, 13)
            Me.Label8.TabIndex = 26
            Me.Label8.Text = "320"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(3, 245)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(25, 13)
            Me.Label9.TabIndex = 25
            Me.Label9.Text = "312"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(3, 195)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(25, 13)
            Me.Label10.TabIndex = 24
            Me.Label10.Text = "310"
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Location = New System.Drawing.Point(167, 95)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(65, 13)
            Me.TextBox1.TabIndex = 23
            Me.TextBox1.Text = "0.00"
            Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox2
            '
            Me.TextBox2.BackColor = System.Drawing.Color.White
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox2.Location = New System.Drawing.Point(167, 70)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.ReadOnly = True
            Me.TextBox2.Size = New System.Drawing.Size(65, 13)
            Me.TextBox2.TabIndex = 22
            Me.TextBox2.Text = "0.00"
            Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox3.Location = New System.Drawing.Point(167, 45)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.ReadOnly = True
            Me.TextBox3.Size = New System.Drawing.Size(65, 13)
            Me.TextBox3.TabIndex = 21
            Me.TextBox3.Text = "0.00"
            Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox4
            '
            Me.TextBox4.BackColor = System.Drawing.Color.White
            Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox4.Location = New System.Drawing.Point(97, 95)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.ReadOnly = True
            Me.TextBox4.Size = New System.Drawing.Size(65, 13)
            Me.TextBox4.TabIndex = 20
            Me.TextBox4.Text = "0.00"
            Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox5
            '
            Me.TextBox5.BackColor = System.Drawing.Color.White
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox5.Location = New System.Drawing.Point(97, 70)
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.ReadOnly = True
            Me.TextBox5.Size = New System.Drawing.Size(65, 13)
            Me.TextBox5.TabIndex = 19
            Me.TextBox5.Text = "0.00"
            Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox6
            '
            Me.TextBox6.BackColor = System.Drawing.Color.White
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox6.Location = New System.Drawing.Point(97, 45)
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.Size = New System.Drawing.Size(65, 13)
            Me.TextBox6.TabIndex = 18
            Me.TextBox6.Text = "0.00"
            Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox7
            '
            Me.TextBox7.BackColor = System.Drawing.Color.White
            Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox7.Location = New System.Drawing.Point(49, 95)
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.ReadOnly = True
            Me.TextBox7.Size = New System.Drawing.Size(43, 13)
            Me.TextBox7.TabIndex = 17
            Me.TextBox7.Text = "0"
            Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox8
            '
            Me.TextBox8.BackColor = System.Drawing.Color.White
            Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox8.Location = New System.Drawing.Point(49, 70)
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.ReadOnly = True
            Me.TextBox8.Size = New System.Drawing.Size(43, 13)
            Me.TextBox8.TabIndex = 16
            Me.TextBox8.Text = "0"
            Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 98)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(25, 13)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "304"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 70)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(25, 13)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "303"
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Location = New System.Drawing.Point(3, 295)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(61, 13)
            Me.Label51.TabIndex = 1
            Me.Label51.Text = "Total 1%:"
            '
            'ShapeContainer4
            '
            Me.ShapeContainer4.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer4.Name = "ShapeContainer4"
            Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape37, Me.LineShape36, Me.LineShape35, Me.LineShape34, Me.LineShape33, Me.LineShape32, Me.LineShape31, Me.LineShape30, Me.LineShape29, Me.LineShape28, Me.LineShape27, Me.LineShape26, Me.LineShape25, Me.LineShape24, Me.LineShape23, Me.LineShape22, Me.LineShape21, Me.LineShape20, Me.LineShape19})
            Me.ShapeContainer4.Size = New System.Drawing.Size(489, 321)
            Me.ShapeContainer4.TabIndex = 102
            Me.ShapeContainer4.TabStop = False
            '
            'LineShape37
            '
            Me.LineShape37.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape37.Name = "LineShape37"
            Me.LineShape37.X1 = 488
            Me.LineShape37.X2 = 333
            Me.LineShape37.Y1 = 295
            Me.LineShape37.Y2 = 295
            '
            'LineShape36
            '
            Me.LineShape36.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape36.Name = "LineShape36"
            Me.LineShape36.X1 = 488
            Me.LineShape36.X2 = 0
            Me.LineShape36.Y1 = 270
            Me.LineShape36.Y2 = 270
            '
            'LineShape35
            '
            Me.LineShape35.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape35.Name = "LineShape35"
            Me.LineShape35.X1 = 488
            Me.LineShape35.X2 = 0
            Me.LineShape35.Y1 = 245
            Me.LineShape35.Y2 = 245
            '
            'LineShape34
            '
            Me.LineShape34.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape34.Name = "LineShape34"
            Me.LineShape34.X1 = 488
            Me.LineShape34.X2 = 0
            Me.LineShape34.Y1 = 220
            Me.LineShape34.Y2 = 220
            '
            'LineShape33
            '
            Me.LineShape33.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape33.Name = "LineShape33"
            Me.LineShape33.X1 = 488
            Me.LineShape33.X2 = 0
            Me.LineShape33.Y1 = 195
            Me.LineShape33.Y2 = 195
            '
            'LineShape32
            '
            Me.LineShape32.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape32.Name = "LineShape32"
            Me.LineShape32.X1 = 488
            Me.LineShape32.X2 = 0
            Me.LineShape32.Y1 = 170
            Me.LineShape32.Y2 = 170
            '
            'LineShape31
            '
            Me.LineShape31.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape31.Name = "LineShape31"
            Me.LineShape31.X1 = 488
            Me.LineShape31.X2 = 0
            Me.LineShape31.Y1 = 145
            Me.LineShape31.Y2 = 145
            '
            'LineShape30
            '
            Me.LineShape30.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape30.Name = "LineShape30"
            Me.LineShape30.X1 = 488
            Me.LineShape30.X2 = 0
            Me.LineShape30.Y1 = 120
            Me.LineShape30.Y2 = 120
            '
            'LineShape29
            '
            Me.LineShape29.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape29.Name = "LineShape29"
            Me.LineShape29.X1 = 488
            Me.LineShape29.X2 = 0
            Me.LineShape29.Y1 = 95
            Me.LineShape29.Y2 = 95
            '
            'LineShape28
            '
            Me.LineShape28.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape28.Name = "LineShape28"
            Me.LineShape28.X1 = 488
            Me.LineShape28.X2 = 0
            Me.LineShape28.Y1 = 70
            Me.LineShape28.Y2 = 70
            '
            'LineShape27
            '
            Me.LineShape27.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape27.Name = "LineShape27"
            Me.LineShape27.X1 = 488
            Me.LineShape27.X2 = 0
            Me.LineShape27.Y1 = 45
            Me.LineShape27.Y2 = 45
            '
            'LineShape26
            '
            Me.LineShape26.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape26.Name = "LineShape26"
            Me.LineShape26.X1 = 488
            Me.LineShape26.X2 = 0
            Me.LineShape26.Y1 = 20
            Me.LineShape26.Y2 = 20
            '
            'LineShape25
            '
            Me.LineShape25.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape25.Name = "LineShape25"
            Me.LineShape25.X1 = 402
            Me.LineShape25.X2 = 402
            Me.LineShape25.Y1 = 0
            Me.LineShape25.Y2 = 295
            '
            'LineShape24
            '
            Me.LineShape24.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape24.Name = "LineShape24"
            Me.LineShape24.X1 = 333
            Me.LineShape24.X2 = 333
            Me.LineShape24.Y1 = 0
            Me.LineShape24.Y2 = 295
            '
            'LineShape23
            '
            Me.LineShape23.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape23.Name = "LineShape23"
            Me.LineShape23.X1 = 282
            Me.LineShape23.X2 = 282
            Me.LineShape23.Y1 = 0
            Me.LineShape23.Y2 = 270
            '
            'LineShape22
            '
            Me.LineShape22.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape22.Name = "LineShape22"
            Me.LineShape22.X1 = 232
            Me.LineShape22.X2 = 232
            Me.LineShape22.Y1 = 0
            Me.LineShape22.Y2 = 270
            '
            'LineShape21
            '
            Me.LineShape21.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape21.Name = "LineShape21"
            Me.LineShape21.X1 = 161
            Me.LineShape21.X2 = 161
            Me.LineShape21.Y1 = 0
            Me.LineShape21.Y2 = 270
            '
            'LineShape20
            '
            Me.LineShape20.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape20.Name = "LineShape20"
            Me.LineShape20.X1 = 40
            Me.LineShape20.X2 = 40
            Me.LineShape20.Y1 = 0
            Me.LineShape20.Y2 = 270
            '
            'LineShape19
            '
            Me.LineShape19.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape19.Name = "LineShape19"
            Me.LineShape19.X1 = 91
            Me.LineShape19.X2 = 91
            Me.LineShape19.Y1 = 0
            Me.LineShape19.Y2 = 270
            '
            'gbCompras
            '
            Me.gbCompras.Controls.Add(Me.Label29)
            Me.gbCompras.Controls.Add(Me.Label63)
            Me.gbCompras.Controls.Add(Me.Label62)
            Me.gbCompras.Controls.Add(Me.Label61)
            Me.gbCompras.Controls.Add(Me.Label60)
            Me.gbCompras.Controls.Add(Me.Label35)
            Me.gbCompras.Controls.Add(Me.Label34)
            Me.gbCompras.Controls.Add(Me.TextBox82)
            Me.gbCompras.Controls.Add(Me.TextBox83)
            Me.gbCompras.Controls.Add(Me.TextBox84)
            Me.gbCompras.Controls.Add(Me.TextBox85)
            Me.gbCompras.Controls.Add(Me.TextBox78)
            Me.gbCompras.Controls.Add(Me.TextBox79)
            Me.gbCompras.Controls.Add(Me.TextBox80)
            Me.gbCompras.Controls.Add(Me.TextBox81)
            Me.gbCompras.Controls.Add(Me.TextBox69)
            Me.gbCompras.Controls.Add(Me.lblIvaTotalCompras)
            Me.gbCompras.Controls.Add(Me.TextBox70)
            Me.gbCompras.Controls.Add(Me.txtIvaNotaVentaCompras)
            Me.gbCompras.Controls.Add(Me.TextBox68)
            Me.gbCompras.Controls.Add(Me.txtIvaLiquidacionCompras)
            Me.gbCompras.Controls.Add(Me.txtIvaFacturasCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa12NotaVentaCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa12LiquidacionCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa12FacturasCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa0NotaVentaCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa0LiquidacionCompras)
            Me.gbCompras.Controls.Add(Me.txtTarifa0FacturaCompras)
            Me.gbCompras.Controls.Add(Me.txtNroRegistrosNotasVentaCompras)
            Me.gbCompras.Controls.Add(Me.txtNroRegistrosLiquidacionCompras)
            Me.gbCompras.Controls.Add(Me.txtNroRegistrosFacturasCompras)
            Me.gbCompras.Controls.Add(Me.Label4)
            Me.gbCompras.Controls.Add(Me.Label3)
            Me.gbCompras.Controls.Add(Me.Label2)
            Me.gbCompras.Controls.Add(Me.ShapeContainer1)
            Me.gbCompras.Location = New System.Drawing.Point(0, 34)
            Me.gbCompras.Name = "gbCompras"
            Me.gbCompras.Size = New System.Drawing.Size(571, 224)
            Me.gbCompras.TabIndex = 0
            Me.gbCompras.TabStop = False
            Me.gbCompras.Text = "COMPRAS"
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(239, 170)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(49, 15)
            Me.Label29.TabIndex = 35
            Me.Label29.Text = "TOTAL:"
            '
            'Label63
            '
            Me.Label63.AutoSize = True
            Me.Label63.Location = New System.Drawing.Point(512, 10)
            Me.Label63.Name = "Label63"
            Me.Label63.Size = New System.Drawing.Size(37, 26)
            Me.Label63.TabIndex = 33
            Me.Label63.Text = "Valor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IVA"
            '
            'Label62
            '
            Me.Label62.AutoSize = True
            Me.Label62.Location = New System.Drawing.Point(351, 10)
            Me.Label62.Name = "Label62"
            Me.Label62.Size = New System.Drawing.Size(61, 26)
            Me.Label62.TabIndex = 32
            Me.Label62.Text = "BI tarifa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dif de 0%"
            '
            'Label61
            '
            Me.Label61.AutoSize = True
            Me.Label61.Location = New System.Drawing.Point(429, 10)
            Me.Label61.Name = "Label61"
            Me.Label61.Size = New System.Drawing.Size(61, 26)
            Me.Label61.TabIndex = 31
            Me.Label61.Text = "No Objeto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de IVA"
            '
            'Label60
            '
            Me.Label60.AutoSize = True
            Me.Label60.Location = New System.Drawing.Point(301, 10)
            Me.Label60.Name = "Label60"
            Me.Label60.Size = New System.Drawing.Size(49, 13)
            Me.Label60.TabIndex = 30
            Me.Label60.Text = "Nro Reg"
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(2, 145)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(97, 13)
            Me.Label35.TabIndex = 29
            Me.Label35.Text = "NOTAS DE DEBITO"
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Location = New System.Drawing.Point(2, 120)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(103, 13)
            Me.Label34.TabIndex = 28
            Me.Label34.Text = "NOTAS DE CREDITO"
            '
            'TextBox82
            '
            Me.TextBox82.BackColor = System.Drawing.Color.White
            Me.TextBox82.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox82.Location = New System.Drawing.Point(499, 145)
            Me.TextBox82.Name = "TextBox82"
            Me.TextBox82.ReadOnly = True
            Me.TextBox82.Size = New System.Drawing.Size(64, 13)
            Me.TextBox82.TabIndex = 27
            Me.TextBox82.Text = "0.00"
            Me.TextBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox83
            '
            Me.TextBox83.BackColor = System.Drawing.Color.White
            Me.TextBox83.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox83.Location = New System.Drawing.Point(351, 145)
            Me.TextBox83.Name = "TextBox83"
            Me.TextBox83.ReadOnly = True
            Me.TextBox83.Size = New System.Drawing.Size(70, 13)
            Me.TextBox83.TabIndex = 26
            Me.TextBox83.Text = "0.00"
            Me.TextBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox84
            '
            Me.TextBox84.BackColor = System.Drawing.Color.White
            Me.TextBox84.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox84.Location = New System.Drawing.Point(427, 145)
            Me.TextBox84.Name = "TextBox84"
            Me.TextBox84.ReadOnly = True
            Me.TextBox84.Size = New System.Drawing.Size(64, 13)
            Me.TextBox84.TabIndex = 25
            Me.TextBox84.Text = "0.00"
            Me.TextBox84.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox85
            '
            Me.TextBox85.BackColor = System.Drawing.Color.White
            Me.TextBox85.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox85.Location = New System.Drawing.Point(305, 145)
            Me.TextBox85.Name = "TextBox85"
            Me.TextBox85.ReadOnly = True
            Me.TextBox85.Size = New System.Drawing.Size(43, 13)
            Me.TextBox85.TabIndex = 24
            Me.TextBox85.Text = "0"
            Me.TextBox85.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox78
            '
            Me.TextBox78.BackColor = System.Drawing.Color.White
            Me.TextBox78.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox78.Location = New System.Drawing.Point(499, 120)
            Me.TextBox78.Name = "TextBox78"
            Me.TextBox78.ReadOnly = True
            Me.TextBox78.Size = New System.Drawing.Size(64, 13)
            Me.TextBox78.TabIndex = 23
            Me.TextBox78.Text = "0.00"
            Me.TextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox79
            '
            Me.TextBox79.BackColor = System.Drawing.Color.White
            Me.TextBox79.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox79.Location = New System.Drawing.Point(351, 120)
            Me.TextBox79.Name = "TextBox79"
            Me.TextBox79.ReadOnly = True
            Me.TextBox79.Size = New System.Drawing.Size(70, 13)
            Me.TextBox79.TabIndex = 22
            Me.TextBox79.Text = "0.00"
            Me.TextBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox80
            '
            Me.TextBox80.BackColor = System.Drawing.Color.White
            Me.TextBox80.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox80.Location = New System.Drawing.Point(427, 120)
            Me.TextBox80.Name = "TextBox80"
            Me.TextBox80.ReadOnly = True
            Me.TextBox80.Size = New System.Drawing.Size(64, 13)
            Me.TextBox80.TabIndex = 21
            Me.TextBox80.Text = "0.00"
            Me.TextBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox81
            '
            Me.TextBox81.BackColor = System.Drawing.Color.White
            Me.TextBox81.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox81.Location = New System.Drawing.Point(305, 120)
            Me.TextBox81.Name = "TextBox81"
            Me.TextBox81.ReadOnly = True
            Me.TextBox81.Size = New System.Drawing.Size(43, 13)
            Me.TextBox81.TabIndex = 20
            Me.TextBox81.Text = "0"
            Me.TextBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox69
            '
            Me.TextBox69.BackColor = System.Drawing.Color.White
            Me.TextBox69.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox69.Location = New System.Drawing.Point(427, 170)
            Me.TextBox69.Name = "TextBox69"
            Me.TextBox69.ReadOnly = True
            Me.TextBox69.Size = New System.Drawing.Size(64, 13)
            Me.TextBox69.TabIndex = 16
            Me.TextBox69.Text = "0.00"
            Me.TextBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaTotalCompras
            '
            Me.lblIvaTotalCompras.BackColor = System.Drawing.Color.White
            Me.lblIvaTotalCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.lblIvaTotalCompras.Location = New System.Drawing.Point(499, 170)
            Me.lblIvaTotalCompras.Name = "lblIvaTotalCompras"
            Me.lblIvaTotalCompras.ReadOnly = True
            Me.lblIvaTotalCompras.Size = New System.Drawing.Size(64, 13)
            Me.lblIvaTotalCompras.TabIndex = 18
            Me.lblIvaTotalCompras.Text = "0.00"
            Me.lblIvaTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox70
            '
            Me.TextBox70.BackColor = System.Drawing.Color.White
            Me.TextBox70.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox70.Location = New System.Drawing.Point(305, 170)
            Me.TextBox70.Name = "TextBox70"
            Me.TextBox70.ReadOnly = True
            Me.TextBox70.Size = New System.Drawing.Size(43, 13)
            Me.TextBox70.TabIndex = 15
            Me.TextBox70.Text = "0"
            Me.TextBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaNotaVentaCompras
            '
            Me.txtIvaNotaVentaCompras.BackColor = System.Drawing.Color.White
            Me.txtIvaNotaVentaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIvaNotaVentaCompras.Location = New System.Drawing.Point(499, 70)
            Me.txtIvaNotaVentaCompras.Name = "txtIvaNotaVentaCompras"
            Me.txtIvaNotaVentaCompras.ReadOnly = True
            Me.txtIvaNotaVentaCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtIvaNotaVentaCompras.TabIndex = 14
            Me.txtIvaNotaVentaCompras.Text = "0.00"
            Me.txtIvaNotaVentaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBox68
            '
            Me.TextBox68.BackColor = System.Drawing.Color.White
            Me.TextBox68.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox68.Location = New System.Drawing.Point(351, 170)
            Me.TextBox68.Name = "TextBox68"
            Me.TextBox68.ReadOnly = True
            Me.TextBox68.Size = New System.Drawing.Size(70, 13)
            Me.TextBox68.TabIndex = 17
            Me.TextBox68.Text = "0.00"
            Me.TextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaLiquidacionCompras
            '
            Me.txtIvaLiquidacionCompras.BackColor = System.Drawing.Color.White
            Me.txtIvaLiquidacionCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIvaLiquidacionCompras.Location = New System.Drawing.Point(499, 95)
            Me.txtIvaLiquidacionCompras.Name = "txtIvaLiquidacionCompras"
            Me.txtIvaLiquidacionCompras.ReadOnly = True
            Me.txtIvaLiquidacionCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtIvaLiquidacionCompras.TabIndex = 13
            Me.txtIvaLiquidacionCompras.Text = "0.00"
            Me.txtIvaLiquidacionCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaFacturasCompras
            '
            Me.txtIvaFacturasCompras.BackColor = System.Drawing.Color.White
            Me.txtIvaFacturasCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIvaFacturasCompras.Location = New System.Drawing.Point(499, 45)
            Me.txtIvaFacturasCompras.Name = "txtIvaFacturasCompras"
            Me.txtIvaFacturasCompras.ReadOnly = True
            Me.txtIvaFacturasCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtIvaFacturasCompras.TabIndex = 12
            Me.txtIvaFacturasCompras.Text = "0.00"
            Me.txtIvaFacturasCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa12NotaVentaCompras
            '
            Me.txtTarifa12NotaVentaCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa12NotaVentaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa12NotaVentaCompras.Location = New System.Drawing.Point(351, 70)
            Me.txtTarifa12NotaVentaCompras.Name = "txtTarifa12NotaVentaCompras"
            Me.txtTarifa12NotaVentaCompras.ReadOnly = True
            Me.txtTarifa12NotaVentaCompras.Size = New System.Drawing.Size(70, 13)
            Me.txtTarifa12NotaVentaCompras.TabIndex = 11
            Me.txtTarifa12NotaVentaCompras.Text = "0.00"
            Me.txtTarifa12NotaVentaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa12LiquidacionCompras
            '
            Me.txtTarifa12LiquidacionCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa12LiquidacionCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa12LiquidacionCompras.Location = New System.Drawing.Point(351, 95)
            Me.txtTarifa12LiquidacionCompras.Name = "txtTarifa12LiquidacionCompras"
            Me.txtTarifa12LiquidacionCompras.ReadOnly = True
            Me.txtTarifa12LiquidacionCompras.Size = New System.Drawing.Size(70, 13)
            Me.txtTarifa12LiquidacionCompras.TabIndex = 10
            Me.txtTarifa12LiquidacionCompras.Text = "0.00"
            Me.txtTarifa12LiquidacionCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa12FacturasCompras
            '
            Me.txtTarifa12FacturasCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa12FacturasCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa12FacturasCompras.Location = New System.Drawing.Point(351, 45)
            Me.txtTarifa12FacturasCompras.Name = "txtTarifa12FacturasCompras"
            Me.txtTarifa12FacturasCompras.ReadOnly = True
            Me.txtTarifa12FacturasCompras.Size = New System.Drawing.Size(70, 13)
            Me.txtTarifa12FacturasCompras.TabIndex = 9
            Me.txtTarifa12FacturasCompras.Text = "0.00"
            Me.txtTarifa12FacturasCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa0NotaVentaCompras
            '
            Me.txtTarifa0NotaVentaCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa0NotaVentaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa0NotaVentaCompras.Location = New System.Drawing.Point(427, 70)
            Me.txtTarifa0NotaVentaCompras.Name = "txtTarifa0NotaVentaCompras"
            Me.txtTarifa0NotaVentaCompras.ReadOnly = True
            Me.txtTarifa0NotaVentaCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtTarifa0NotaVentaCompras.TabIndex = 8
            Me.txtTarifa0NotaVentaCompras.Text = "0.00"
            Me.txtTarifa0NotaVentaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa0LiquidacionCompras
            '
            Me.txtTarifa0LiquidacionCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa0LiquidacionCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa0LiquidacionCompras.Location = New System.Drawing.Point(427, 95)
            Me.txtTarifa0LiquidacionCompras.Name = "txtTarifa0LiquidacionCompras"
            Me.txtTarifa0LiquidacionCompras.ReadOnly = True
            Me.txtTarifa0LiquidacionCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtTarifa0LiquidacionCompras.TabIndex = 7
            Me.txtTarifa0LiquidacionCompras.Text = "0.00"
            Me.txtTarifa0LiquidacionCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTarifa0FacturaCompras
            '
            Me.txtTarifa0FacturaCompras.BackColor = System.Drawing.Color.White
            Me.txtTarifa0FacturaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTarifa0FacturaCompras.Location = New System.Drawing.Point(427, 45)
            Me.txtTarifa0FacturaCompras.Name = "txtTarifa0FacturaCompras"
            Me.txtTarifa0FacturaCompras.ReadOnly = True
            Me.txtTarifa0FacturaCompras.Size = New System.Drawing.Size(64, 13)
            Me.txtTarifa0FacturaCompras.TabIndex = 6
            Me.txtTarifa0FacturaCompras.Text = "0.00"
            Me.txtTarifa0FacturaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroRegistrosNotasVentaCompras
            '
            Me.txtNroRegistrosNotasVentaCompras.BackColor = System.Drawing.Color.White
            Me.txtNroRegistrosNotasVentaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNroRegistrosNotasVentaCompras.Location = New System.Drawing.Point(305, 70)
            Me.txtNroRegistrosNotasVentaCompras.Name = "txtNroRegistrosNotasVentaCompras"
            Me.txtNroRegistrosNotasVentaCompras.ReadOnly = True
            Me.txtNroRegistrosNotasVentaCompras.Size = New System.Drawing.Size(43, 13)
            Me.txtNroRegistrosNotasVentaCompras.TabIndex = 5
            Me.txtNroRegistrosNotasVentaCompras.Text = "0"
            Me.txtNroRegistrosNotasVentaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroRegistrosLiquidacionCompras
            '
            Me.txtNroRegistrosLiquidacionCompras.BackColor = System.Drawing.Color.White
            Me.txtNroRegistrosLiquidacionCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNroRegistrosLiquidacionCompras.Location = New System.Drawing.Point(305, 95)
            Me.txtNroRegistrosLiquidacionCompras.Name = "txtNroRegistrosLiquidacionCompras"
            Me.txtNroRegistrosLiquidacionCompras.ReadOnly = True
            Me.txtNroRegistrosLiquidacionCompras.Size = New System.Drawing.Size(43, 13)
            Me.txtNroRegistrosLiquidacionCompras.TabIndex = 4
            Me.txtNroRegistrosLiquidacionCompras.Text = "0"
            Me.txtNroRegistrosLiquidacionCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroRegistrosFacturasCompras
            '
            Me.txtNroRegistrosFacturasCompras.BackColor = System.Drawing.Color.White
            Me.txtNroRegistrosFacturasCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtNroRegistrosFacturasCompras.Location = New System.Drawing.Point(305, 45)
            Me.txtNroRegistrosFacturasCompras.Name = "txtNroRegistrosFacturasCompras"
            Me.txtNroRegistrosFacturasCompras.ReadOnly = True
            Me.txtNroRegistrosFacturasCompras.Size = New System.Drawing.Size(43, 13)
            Me.txtNroRegistrosFacturasCompras.TabIndex = 3
            Me.txtNroRegistrosFacturasCompras.Text = "0"
            Me.txtNroRegistrosFacturasCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(2, 70)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(91, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "NOTAS DE VENTA"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(2, 95)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(289, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "LIQUIDACIÓN DE COMPRAS OPRESTACIÓN DE SERVICIOS"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(2, 45)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(55, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "FACTURAS"
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape51, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
            Me.ShapeContainer1.Size = New System.Drawing.Size(565, 205)
            Me.ShapeContainer1.TabIndex = 34
            Me.ShapeContainer1.TabStop = False
            '
            'LineShape51
            '
            Me.LineShape51.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape51.Name = "LineShape51"
            Me.LineShape51.X1 = 565
            Me.LineShape51.X2 = 0
            Me.LineShape51.Y1 = 170
            Me.LineShape51.Y2 = 170
            '
            'LineShape10
            '
            Me.LineShape10.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape10.Name = "LineShape10"
            Me.LineShape10.X1 = 296
            Me.LineShape10.X2 = 296
            Me.LineShape10.Y1 = 0
            Me.LineShape10.Y2 = 170
            '
            'LineShape9
            '
            Me.LineShape9.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape9.Name = "LineShape9"
            Me.LineShape9.X1 = 493
            Me.LineShape9.X2 = 493
            Me.LineShape9.Y1 = 0
            Me.LineShape9.Y2 = 170
            '
            'LineShape8
            '
            Me.LineShape8.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape8.Name = "LineShape8"
            Me.LineShape8.X1 = 422
            Me.LineShape8.X2 = 422
            Me.LineShape8.Y1 = 0
            Me.LineShape8.Y2 = 170
            '
            'LineShape7
            '
            Me.LineShape7.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape7.Name = "LineShape7"
            Me.LineShape7.X1 = 565
            Me.LineShape7.X2 = 0
            Me.LineShape7.Y1 = 145
            Me.LineShape7.Y2 = 145
            '
            'LineShape6
            '
            Me.LineShape6.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape6.Name = "LineShape6"
            Me.LineShape6.X1 = 569
            Me.LineShape6.X2 = -5
            Me.LineShape6.Y1 = 120
            Me.LineShape6.Y2 = 120
            '
            'LineShape5
            '
            Me.LineShape5.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape5.Name = "LineShape5"
            Me.LineShape5.X1 = 565
            Me.LineShape5.X2 = 0
            Me.LineShape5.Y1 = 95
            Me.LineShape5.Y2 = 95
            '
            'LineShape4
            '
            Me.LineShape4.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape4.Name = "LineShape4"
            Me.LineShape4.X1 = 565
            Me.LineShape4.X2 = 0
            Me.LineShape4.Y1 = 20
            Me.LineShape4.Y2 = 20
            '
            'LineShape3
            '
            Me.LineShape3.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape3.Name = "LineShape3"
            Me.LineShape3.X1 = 565
            Me.LineShape3.X2 = 0
            Me.LineShape3.Y1 = 70
            Me.LineShape3.Y2 = 70
            '
            'LineShape2
            '
            Me.LineShape2.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape2.Name = "LineShape2"
            Me.LineShape2.X1 = 565
            Me.LineShape2.X2 = 0
            Me.LineShape2.Y1 = 45
            Me.LineShape2.Y2 = 45
            '
            'LineShape1
            '
            Me.LineShape1.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape1.Name = "LineShape1"
            Me.LineShape1.X1 = 347
            Me.LineShape1.X2 = 347
            Me.LineShape1.Y1 = 0
            Me.LineShape1.Y2 = 170
            '
            'gbComprobantesAnulados
            '
            Me.gbComprobantesAnulados.Controls.Add(Me.Label81)
            Me.gbComprobantesAnulados.Controls.Add(Me.Label28)
            Me.gbComprobantesAnulados.Controls.Add(Me.TextBox66)
            Me.gbComprobantesAnulados.Controls.Add(Me.ShapeContainer3)
            Me.gbComprobantesAnulados.Location = New System.Drawing.Point(0, 374)
            Me.gbComprobantesAnulados.Name = "gbComprobantesAnulados"
            Me.gbComprobantesAnulados.Size = New System.Drawing.Size(571, 75)
            Me.gbComprobantesAnulados.TabIndex = 4
            Me.gbComprobantesAnulados.TabStop = False
            Me.gbComprobantesAnulados.Text = "COMPROBANTES ANULADOS"
            '
            'Label81
            '
            Me.Label81.AutoSize = True
            Me.Label81.Location = New System.Drawing.Point(515, 20)
            Me.Label81.Name = "Label81"
            Me.Label81.Size = New System.Drawing.Size(49, 13)
            Me.Label81.TabIndex = 35
            Me.Label81.Text = "Nro Reg"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(3, 45)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(331, 13)
            Me.Label28.TabIndex = 17
            Me.Label28.Text = "TOTAL DE COMPROBANTES ANULADOS EN EL PERIODO INFORMADO"
            '
            'TextBox66
            '
            Me.TextBox66.BackColor = System.Drawing.Color.White
            Me.TextBox66.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox66.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox66.Location = New System.Drawing.Point(499, 45)
            Me.TextBox66.Name = "TextBox66"
            Me.TextBox66.ReadOnly = True
            Me.TextBox66.Size = New System.Drawing.Size(64, 15)
            Me.TextBox66.TabIndex = 16
            Me.TextBox66.Text = "0"
            Me.TextBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ShapeContainer3
            '
            Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
            Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer3.Name = "ShapeContainer3"
            Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape54, Me.LineShape53, Me.LineShape18})
            Me.ShapeContainer3.Size = New System.Drawing.Size(565, 56)
            Me.ShapeContainer3.TabIndex = 18
            Me.ShapeContainer3.TabStop = False
            '
            'LineShape54
            '
            Me.LineShape54.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape54.Name = "LineShape54"
            Me.LineShape54.X1 = 565
            Me.LineShape54.X2 = 0
            Me.LineShape54.Y1 = 45
            Me.LineShape54.Y2 = 45
            '
            'LineShape53
            '
            Me.LineShape53.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape53.Name = "LineShape53"
            Me.LineShape53.X1 = 565
            Me.LineShape53.X2 = 0
            Me.LineShape53.Y1 = 20
            Me.LineShape53.Y2 = 20
            '
            'LineShape18
            '
            Me.LineShape18.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LineShape18.Name = "LineShape18"
            Me.LineShape18.X1 = 492
            Me.LineShape18.X2 = 492
            Me.LineShape18.Y1 = 0
            Me.LineShape18.Y2 = 45
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnCargar, Me.btnGenerarXML, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1076, 24)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(79, 20)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnCargar
            '
            Me.btnCargar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.cog_error
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(81, 20)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnGenerarXML
            '
            Me.btnGenerarXML.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerarXML.Image = Global.syscisepro.My.Resources.Resources.generate_tables_icon
            Me.btnGenerarXML.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGenerarXML.Name = "btnGenerarXML"
            Me.btnGenerarXML.Size = New System.Drawing.Size(113, 20)
            Me.btnGenerarXML.Text = "GENERAR XML"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(82, 20)
            Me.btnReporte.Text = "REPORTE"
            Me.btnReporte.Visible = False
            '
            'FormAtsSimplificado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1076, 696)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcATSSimplificado)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAtsSimplificado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ATS SIMPLIFICADO"
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.tcATSSimplificado.ResumeLayout(False)
            Me.tpVentasATS.ResumeLayout(False)
            Me.tpVentasATS.PerformLayout()
            CType(Me.dgvVentasATS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotalesVentas.ResumeLayout(False)
            Me.gbTotalesVentas.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDatosAgrupadosVentas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpNotasCredito.ResumeLayout(False)
            CType(Me.dgvNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvDatosAgrupadosNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpComprasATS.ResumeLayout(False)
            Me.tpComprasATS.PerformLayout()
            CType(Me.dgvComprasATS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTotalesCompras.ResumeLayout(False)
            Me.gbTotalesCompras.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencionCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpCodigosRetencionCompras.ResumeLayout(False)
            CType(Me.dgvCodigosRetencionCompras, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpResumenATS.ResumeLayout(False)
            Me.tpResumenATS.PerformLayout()
            Me.gbCabecera.ResumeLayout(False)
            Me.gbCabecera.PerformLayout()
            Me.gbRetencionesEfectuaron.ResumeLayout(False)
            Me.gbRetencionesEfectuaron.PerformLayout()
            Me.gbRetencionesFuenteIva.ResumeLayout(False)
            Me.gbRetencionesFuenteIva.PerformLayout()
            Me.gbVentas.ResumeLayout(False)
            Me.gbVentas.PerformLayout()
            Me.gbRetencionesFuenteRenta.ResumeLayout(False)
            Me.gbRetencionesFuenteRenta.PerformLayout()
            Me.gbCompras.ResumeLayout(False)
            Me.gbCompras.PerformLayout()
            Me.gbComprobantesAnulados.ResumeLayout(False)
            Me.gbComprobantesAnulados.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents tcATSSimplificado As System.Windows.Forms.TabControl
        Friend WithEvents tpComprasATS As System.Windows.Forms.TabPage
        Friend WithEvents tpVentasATS As System.Windows.Forms.TabPage
        Friend WithEvents tpResumenATS As System.Windows.Forms.TabPage
        Friend WithEvents dgvComprasATS As System.Windows.Forms.DataGridView
        Friend WithEvents dgvVentasATS As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencionCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencionVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbCompras As System.Windows.Forms.GroupBox
        Friend WithEvents gbRetencionesFuenteRenta As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtIvaNotaVentaCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaLiquidacionCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaFacturasCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa12NotaVentaCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa12LiquidacionCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa12FacturasCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa0NotaVentaCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa0LiquidacionCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtTarifa0FacturaCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtNroRegistrosNotasVentaCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtNroRegistrosLiquidacionCompras As System.Windows.Forms.TextBox
        Friend WithEvents txtNroRegistrosFacturasCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents gbRetencionesEfectuaron As System.Windows.Forms.GroupBox
        Friend WithEvents gbComprobantesAnulados As System.Windows.Forms.GroupBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
        Friend WithEvents gbRetencionesFuenteIva As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents gbVentas As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
        Friend WithEvents lblIvaTotalCompras As System.Windows.Forms.TextBox
        Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
        Friend WithEvents lblIdDetalleComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdDetalleComprobanteRetencionVenta As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteRetencionVenta As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents TextBox77 As System.Windows.Forms.TextBox
        Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents dgvDatosAgrupadosVentas As System.Windows.Forms.DataGridView
        Friend WithEvents TIPO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NUMERO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL_0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL_12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DESCUENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_RET_IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_RET_RENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox79 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox80 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox83 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox84 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox85 As System.Windows.Forms.TextBox
        Friend WithEvents lblSinRetencion As System.Windows.Forms.Label
        Friend WithEvents Label36 As System.Windows.Forms.Label
        Friend WithEvents tpCodigosRetencionCompras As System.Windows.Forms.TabPage
        Friend WithEvents dgvCodigosRetencionCompras As System.Windows.Forms.DataGridView
        Friend WithEvents gbTotalesVentas As System.Windows.Forms.GroupBox
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents txtIvaFacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtTotalFacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotalFacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label42 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal0FacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label41 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12FacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents txtDescuentoFacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents gbTotalesCompras As System.Windows.Forms.GroupBox
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal0Compras As System.Windows.Forms.TextBox
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12Compras As System.Windows.Forms.TextBox
        Friend WithEvents Label45 As System.Windows.Forms.Label
        Friend WithEvents txtDescuentoCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotalCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtIvaCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents txtTotalCompras As System.Windows.Forms.TextBox
        Friend WithEvents tpNotasCredito As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal0NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotalIva As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label53 As System.Windows.Forms.Label
        Friend WithEvents txtIvaNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label54 As System.Windows.Forms.Label
        Friend WithEvents txtTotalNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents dgvNotasCredito As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDatosAgrupadosNotasCredito As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TextBox89 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox88 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox87 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox86 As System.Windows.Forms.TextBox
        Friend WithEvents Label57 As System.Windows.Forms.Label
        Friend WithEvents Label56 As System.Windows.Forms.Label
        Friend WithEvents Label55 As System.Windows.Forms.Label
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents TextBox90 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox91 As System.Windows.Forms.TextBox
        Friend WithEvents Label58 As System.Windows.Forms.Label
        Friend WithEvents Label59 As System.Windows.Forms.Label
        Friend WithEvents TextBox95 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox96 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox97 As System.Windows.Forms.TextBox
        Friend WithEvents Label65 As System.Windows.Forms.Label
        Friend WithEvents TextBox92 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox93 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox94 As System.Windows.Forms.TextBox
        Friend WithEvents Label64 As System.Windows.Forms.Label
        Friend WithEvents Label63 As System.Windows.Forms.Label
        Friend WithEvents Label62 As System.Windows.Forms.Label
        Friend WithEvents Label61 As System.Windows.Forms.Label
        Friend WithEvents Label60 As System.Windows.Forms.Label
        Friend WithEvents Label67 As System.Windows.Forms.Label
        Friend WithEvents TextBox99 As System.Windows.Forms.TextBox
        Friend WithEvents Label66 As System.Windows.Forms.Label
        Friend WithEvents TextBox98 As System.Windows.Forms.TextBox
        Friend WithEvents Label80 As System.Windows.Forms.Label
        Friend WithEvents Label76 As System.Windows.Forms.Label
        Friend WithEvents Label77 As System.Windows.Forms.Label
        Friend WithEvents Label78 As System.Windows.Forms.Label
        Friend WithEvents Label79 As System.Windows.Forms.Label
        Friend WithEvents Label73 As System.Windows.Forms.Label
        Friend WithEvents Label74 As System.Windows.Forms.Label
        Friend WithEvents Label75 As System.Windows.Forms.Label
        Friend WithEvents Label72 As System.Windows.Forms.Label
        Friend WithEvents Label71 As System.Windows.Forms.Label
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label69 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape17 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape16 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape15 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape14 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape13 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape12 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape18 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape36 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape35 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape34 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape33 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape32 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape31 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape30 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape29 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape28 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape27 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape26 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape25 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape24 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape23 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape22 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape21 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape20 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape19 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape37 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label68 As System.Windows.Forms.Label
        Friend WithEvents Label70 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer6 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape50 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape49 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape48 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape47 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape46 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Friend WithEvents LineShape45 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape44 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape43 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape42 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape41 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape40 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape39 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape38 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape52 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape51 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label81 As System.Windows.Forms.Label
        Friend WithEvents LineShape54 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents LineShape53 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents Label83 As System.Windows.Forms.Label
        Friend WithEvents txtIva14FacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label84 As System.Windows.Forms.Label
        Friend WithEvents TextBox101 As System.Windows.Forms.TextBox
        Friend WithEvents Label85 As System.Windows.Forms.Label
        Friend WithEvents txtIva12FacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label82 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal14FacturaVentas As System.Windows.Forms.TextBox
        Friend WithEvents Label87 As System.Windows.Forms.Label
        Friend WithEvents txtIva14NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label88 As System.Windows.Forms.Label
        Friend WithEvents txtIva0NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label89 As System.Windows.Forms.Label
        Friend WithEvents txtIva12NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label86 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal14NotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents Label91 As System.Windows.Forms.Label
        Friend WithEvents txtIva14Compras As System.Windows.Forms.TextBox
        Friend WithEvents Label92 As System.Windows.Forms.Label
        Friend WithEvents txtIva0Compras As System.Windows.Forms.TextBox
        Friend WithEvents Label93 As System.Windows.Forms.Label
        Friend WithEvents txtIva12Compras As System.Windows.Forms.TextBox
        Friend WithEvents Label90 As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal14Compras As System.Windows.Forms.TextBox
        Friend WithEvents TextBox100 As System.Windows.Forms.TextBox
        Friend WithEvents Label94 As System.Windows.Forms.Label
        Friend WithEvents LineShape55 As Microsoft.VisualBasic.PowerPacks.LineShape
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGenerarXML As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label95 As System.Windows.Forms.Label
        Friend WithEvents ID_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents EJ_FISCAL_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CODIGO_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BASE_IMPONIBLE_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IMPUESTO_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PORCENTAJE_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ESTADO_DETALLE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_COMPROBANTE_RETENCION_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_COMPROBANTE_COMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TextBox102 As System.Windows.Forms.TextBox
        Friend WithEvents Label96 As System.Windows.Forms.Label
        Friend WithEvents TextBox103 As System.Windows.Forms.TextBox
        Friend WithEvents Label97 As System.Windows.Forms.Label
    End Class
End Namespace