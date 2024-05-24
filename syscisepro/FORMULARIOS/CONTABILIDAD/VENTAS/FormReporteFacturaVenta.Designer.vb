Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteFacturaVenta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteFacturaVenta))
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.crvFacturaVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.gbBuscarFactura = New System.Windows.Forms.GroupBox()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblFechaEmisionFacturaVenta = New System.Windows.Forms.Label()
            Me.lblNumeroFacturaVenta = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIva = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal12 = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0 = New System.Windows.Forms.TextBox()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbBuscarFactura.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'crvFacturaVenta
            '
            Me.crvFacturaVenta.ActiveViewIndex = -1
            Me.crvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvFacturaVenta.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvFacturaVenta.Location = New System.Drawing.Point(0, 70)
            Me.crvFacturaVenta.Name = "crvFacturaVenta"
            Me.crvFacturaVenta.Size = New System.Drawing.Size(808, 599)
            Me.crvFacturaVenta.TabIndex = 0
            Me.crvFacturaVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(182, 2)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "/"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(248, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "/"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(196, 2)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(49, 13)
            Me.lblIdFacturaVenta.TabIndex = 8
            Me.lblIdFacturaVenta.Text = "0000000"
            '
            'gbBuscarFactura
            '
            Me.gbBuscarFactura.BackColor = System.Drawing.Color.White
            Me.gbBuscarFactura.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbBuscarFactura.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbBuscarFactura.Controls.Add(Me.Label2)
            Me.gbBuscarFactura.Controls.Add(Me.Label1)
            Me.gbBuscarFactura.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBuscarFactura.Location = New System.Drawing.Point(0, 0)
            Me.gbBuscarFactura.Name = "gbBuscarFactura"
            Me.gbBuscarFactura.Size = New System.Drawing.Size(270, 69)
            Me.gbBuscarFactura.TabIndex = 98
            Me.gbBuscarFactura.TabStop = False
            Me.gbBuscarFactura.Text = "BUSCAR FACTURA"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(177, 29)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(84, 23)
            Me.btnBuscarAsiento.TabIndex = 26
            Me.btnBuscarAsiento.Text = "BUSCAR #"
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(9, 31)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaVenta)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label28)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label30)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(270, 0)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(190, 69)
            Me.gbDatosComprobanteCompra.TabIndex = 97
            Me.gbDatosComprobanteCompra.TabStop = False
            Me.gbDatosComprobanteCompra.Text = "Datos"
            '
            'lblFechaEmisionFacturaVenta
            '
            Me.lblFechaEmisionFacturaVenta.AutoSize = True
            Me.lblFechaEmisionFacturaVenta.Location = New System.Drawing.Point(107, 34)
            Me.lblFechaEmisionFacturaVenta.Name = "lblFechaEmisionFacturaVenta"
            Me.lblFechaEmisionFacturaVenta.Size = New System.Drawing.Size(67, 13)
            Me.lblFechaEmisionFacturaVenta.TabIndex = 23
            Me.lblFechaEmisionFacturaVenta.Text = "00/00/0000"
            Me.lblFechaEmisionFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblNumeroFacturaVenta
            '
            Me.lblNumeroFacturaVenta.AutoSize = True
            Me.lblNumeroFacturaVenta.Location = New System.Drawing.Point(107, 17)
            Me.lblNumeroFacturaVenta.Name = "lblNumeroFacturaVenta"
            Me.lblNumeroFacturaVenta.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroFacturaVenta.TabIndex = 21
            Me.lblNumeroFacturaVenta.Text = "0"
            Me.lblNumeroFacturaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(18, 34)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(91, 13)
            Me.Label28.TabIndex = 12
            Me.Label28.Text = "Fecha Emisión:"
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(18, 17)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(73, 13)
            Me.Label30.TabIndex = 10
            Me.Label30.Text = "Nº FACTURA:"
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIva)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuento)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(460, 0)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(347, 69)
            Me.gbValoresComprobanteCompra.TabIndex = 96
            Me.gbValoresComprobanteCompra.TabStop = False
            Me.gbValoresComprobanteCompra.Text = "Valores"
            '
            'txtTotal
            '
            Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtTotal.Location = New System.Drawing.Point(253, 52)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(59, 13)
            Me.txtTotal.TabIndex = 32
            Me.txtTotal.Text = "0.00"
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(189, 17)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(189, 52)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'txtIva
            '
            Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtIva.Location = New System.Drawing.Point(253, 34)
            Me.txtIva.Name = "txtIva"
            Me.txtIva.Size = New System.Drawing.Size(59, 13)
            Me.txtIva.TabIndex = 31
            Me.txtIva.Text = "0.00"
            Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(189, 34)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(18, 52)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotal
            '
            Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal.Location = New System.Drawing.Point(253, 16)
            Me.txtSubtotal.Name = "txtSubtotal"
            Me.txtSubtotal.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal.TabIndex = 30
            Me.txtSubtotal.Text = "0.00"
            Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(18, 34)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'txtDescuento
            '
            Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtDescuento.Location = New System.Drawing.Point(103, 52)
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(59, 13)
            Me.txtDescuento.TabIndex = 29
            Me.txtDescuento.Text = "0.00"
            Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(18, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'txtSubtotal12
            '
            Me.txtSubtotal12.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal12.Location = New System.Drawing.Point(103, 16)
            Me.txtSubtotal12.Name = "txtSubtotal12"
            Me.txtSubtotal12.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal12.TabIndex = 27
            Me.txtSubtotal12.Text = "0.00"
            Me.txtSubtotal12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0
            '
            Me.txtSubtotal0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtSubtotal0.Location = New System.Drawing.Point(103, 34)
            Me.txtSubtotal0.Name = "txtSubtotal0"
            Me.txtSubtotal0.Size = New System.Drawing.Size(59, 13)
            Me.txtSubtotal0.TabIndex = 28
            Me.txtSubtotal0.Text = "0.00"
            Me.txtSubtotal0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(9, 73)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(799, 67)
            Me.dgvFacturaVenta.TabIndex = 99
            '
            'FormReporteFacturaVenta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(808, 669)
            Me.Controls.Add(Me.gbBuscarFactura)
            Me.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.Controls.Add(Me.crvFacturaVenta)
            Me.Controls.Add(Me.dgvFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteFacturaVenta"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "IMPRIMIR FACTURA"
            Me.gbBuscarFactura.ResumeLayout(False)
            Me.gbBuscarFactura.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crvFacturaVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents gbBuscarFactura As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents lblNumeroFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents gbValoresComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtIva As System.Windows.Forms.TextBox
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12 As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0 As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
    End Class
End Namespace