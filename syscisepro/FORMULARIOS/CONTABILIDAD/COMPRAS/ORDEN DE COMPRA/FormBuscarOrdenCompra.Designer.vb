Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarOrdenCompra
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarOrdenCompra))
            Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.gbOrdenCompra = New System.Windows.Forms.GroupBox()
            Me.txtTotalOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblTotalORdenCompra = New System.Windows.Forms.Label()
            Me.txtIvaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.txtDescuentoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal0OrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.txtSubtotal12OrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.txtTipoPagoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblTipoPagoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtFormaPagoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblFormaPagoOrdenCompra = New System.Windows.Forms.Label()
            Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
            Me.lblNombreProveedor = New System.Windows.Forms.Label()
            Me.txtRucProveedor = New System.Windows.Forms.TextBox()
            Me.lblRucProveedor = New System.Windows.Forms.Label()
            Me.txtFechaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIdOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblFechaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblNroOrdenCompra = New System.Windows.Forms.Label()
            Me.lblIdOrdenCompra = New System.Windows.Forms.Label()
            Me.dgvOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAceptar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbOrdenCompra.SuspendLayout()
            CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvDetalleOrdenCompra
            '
            Me.dgvDetalleOrdenCompra.AllowUserToAddRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
            Me.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(2, 238)
            Me.dgvDetalleOrdenCompra.MultiSelect = False
            Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
            Me.dgvDetalleOrdenCompra.ReadOnly = True
            Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
            Me.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(1014, 333)
            Me.dgvDetalleOrdenCompra.TabIndex = 47
            '
            'gbOrdenCompra
            '
            Me.gbOrdenCompra.BackColor = System.Drawing.Color.White
            Me.gbOrdenCompra.Controls.Add(Me.txtTotalOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblTotalORdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtIvaOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtDescuentoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtSubtotal0OrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtSubtotal12OrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtTipoPagoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblTipoPagoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtFormaPagoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblFormaPagoOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtNombreProveedor)
            Me.gbOrdenCompra.Controls.Add(Me.lblNombreProveedor)
            Me.gbOrdenCompra.Controls.Add(Me.txtRucProveedor)
            Me.gbOrdenCompra.Controls.Add(Me.lblRucProveedor)
            Me.gbOrdenCompra.Controls.Add(Me.txtFechaOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.txtIdOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblFechaOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblNroOrdenCompra)
            Me.gbOrdenCompra.Controls.Add(Me.lblIdOrdenCompra)
            Me.gbOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbOrdenCompra.Location = New System.Drawing.Point(541, 35)
            Me.gbOrdenCompra.Name = "gbOrdenCompra"
            Me.gbOrdenCompra.Size = New System.Drawing.Size(475, 200)
            Me.gbOrdenCompra.TabIndex = 44
            Me.gbOrdenCompra.TabStop = False
            Me.gbOrdenCompra.Text = "DATOS ORDEN DE COMPRA"
            '
            'txtTotalOrdenCompra
            '
            Me.txtTotalOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalOrdenCompra.Enabled = False
            Me.txtTotalOrdenCompra.Location = New System.Drawing.Point(400, 170)
            Me.txtTotalOrdenCompra.Name = "txtTotalOrdenCompra"
            Me.txtTotalOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtTotalOrdenCompra.TabIndex = 22
            Me.txtTotalOrdenCompra.Text = "0.00"
            Me.txtTotalOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalORdenCompra
            '
            Me.lblTotalORdenCompra.AutoSize = True
            Me.lblTotalORdenCompra.Location = New System.Drawing.Point(322, 173)
            Me.lblTotalORdenCompra.Name = "lblTotalORdenCompra"
            Me.lblTotalORdenCompra.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalORdenCompra.TabIndex = 21
            Me.lblTotalORdenCompra.Text = "TOTAL:"
            '
            'txtIvaOrdenCompra
            '
            Me.txtIvaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaOrdenCompra.Enabled = False
            Me.txtIvaOrdenCompra.Location = New System.Drawing.Point(400, 144)
            Me.txtIvaOrdenCompra.Name = "txtIvaOrdenCompra"
            Me.txtIvaOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtIvaOrdenCompra.TabIndex = 20
            Me.txtIvaOrdenCompra.Text = "0.00"
            Me.txtIvaOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(322, 147)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(58, 13)
            Me.lblIvaOrdenCompra.TabIndex = 19
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'txtDescuentoOrdenCompra
            '
            Me.txtDescuentoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoOrdenCompra.Enabled = False
            Me.txtDescuentoOrdenCompra.Location = New System.Drawing.Point(400, 118)
            Me.txtDescuentoOrdenCompra.Name = "txtDescuentoOrdenCompra"
            Me.txtDescuentoOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtDescuentoOrdenCompra.TabIndex = 18
            Me.txtDescuentoOrdenCompra.Text = "0.00"
            Me.txtDescuentoOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(322, 121)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(73, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 17
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'txtSubtotal0OrdenCompra
            '
            Me.txtSubtotal0OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0OrdenCompra.Enabled = False
            Me.txtSubtotal0OrdenCompra.Location = New System.Drawing.Point(400, 92)
            Me.txtSubtotal0OrdenCompra.Name = "txtSubtotal0OrdenCompra"
            Me.txtSubtotal0OrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtSubtotal0OrdenCompra.TabIndex = 16
            Me.txtSubtotal0OrdenCompra.Text = "0.00"
            Me.txtSubtotal0OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(322, 95)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(75, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 15
            Me.lblSubtotal0OrdenCompra.Text = "SUBTOTAL 0:"
            '
            'txtSubtotal12OrdenCompra
            '
            Me.txtSubtotal12OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12OrdenCompra.Enabled = False
            Me.txtSubtotal12OrdenCompra.Location = New System.Drawing.Point(400, 66)
            Me.txtSubtotal12OrdenCompra.Name = "txtSubtotal12OrdenCompra"
            Me.txtSubtotal12OrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtSubtotal12OrdenCompra.TabIndex = 14
            Me.txtSubtotal12OrdenCompra.Text = "0.00"
            Me.txtSubtotal12OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(322, 69)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(81, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 13
            Me.lblSubtotal12OrdenCompra.Text = "SUBTOTAL 12:"
            '
            'txtTipoPagoOrdenCompra
            '
            Me.txtTipoPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTipoPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoPagoOrdenCompra.Enabled = False
            Me.txtTipoPagoOrdenCompra.Location = New System.Drawing.Point(83, 171)
            Me.txtTipoPagoOrdenCompra.Name = "txtTipoPagoOrdenCompra"
            Me.txtTipoPagoOrdenCompra.Size = New System.Drawing.Size(217, 21)
            Me.txtTipoPagoOrdenCompra.TabIndex = 12
            '
            'lblTipoPagoOrdenCompra
            '
            Me.lblTipoPagoOrdenCompra.AutoSize = True
            Me.lblTipoPagoOrdenCompra.Location = New System.Drawing.Point(4, 174)
            Me.lblTipoPagoOrdenCompra.Name = "lblTipoPagoOrdenCompra"
            Me.lblTipoPagoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblTipoPagoOrdenCompra.TabIndex = 11
            Me.lblTipoPagoOrdenCompra.Text = "TIPO PAGO:"
            '
            'txtFormaPagoOrdenCompra
            '
            Me.txtFormaPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtFormaPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFormaPagoOrdenCompra.Enabled = False
            Me.txtFormaPagoOrdenCompra.Location = New System.Drawing.Point(83, 142)
            Me.txtFormaPagoOrdenCompra.Name = "txtFormaPagoOrdenCompra"
            Me.txtFormaPagoOrdenCompra.Size = New System.Drawing.Size(217, 21)
            Me.txtFormaPagoOrdenCompra.TabIndex = 10
            '
            'lblFormaPagoOrdenCompra
            '
            Me.lblFormaPagoOrdenCompra.AutoSize = True
            Me.lblFormaPagoOrdenCompra.Location = New System.Drawing.Point(4, 145)
            Me.lblFormaPagoOrdenCompra.Name = "lblFormaPagoOrdenCompra"
            Me.lblFormaPagoOrdenCompra.Size = New System.Drawing.Size(80, 13)
            Me.lblFormaPagoOrdenCompra.TabIndex = 9
            Me.lblFormaPagoOrdenCompra.Text = "FORMA PAGO:"
            '
            'txtNombreProveedor
            '
            Me.txtNombreProveedor.BackColor = System.Drawing.Color.White
            Me.txtNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreProveedor.Enabled = False
            Me.txtNombreProveedor.Location = New System.Drawing.Point(83, 45)
            Me.txtNombreProveedor.Multiline = True
            Me.txtNombreProveedor.Name = "txtNombreProveedor"
            Me.txtNombreProveedor.Size = New System.Drawing.Size(217, 87)
            Me.txtNombreProveedor.TabIndex = 8
            '
            'lblNombreProveedor
            '
            Me.lblNombreProveedor.AutoSize = True
            Me.lblNombreProveedor.Location = New System.Drawing.Point(4, 48)
            Me.lblNombreProveedor.Name = "lblNombreProveedor"
            Me.lblNombreProveedor.Size = New System.Drawing.Size(73, 13)
            Me.lblNombreProveedor.TabIndex = 7
            Me.lblNombreProveedor.Text = "PROVEEDOR:"
            '
            'txtRucProveedor
            '
            Me.txtRucProveedor.BackColor = System.Drawing.Color.White
            Me.txtRucProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucProveedor.Enabled = False
            Me.txtRucProveedor.Location = New System.Drawing.Point(371, 22)
            Me.txtRucProveedor.Name = "txtRucProveedor"
            Me.txtRucProveedor.Size = New System.Drawing.Size(94, 21)
            Me.txtRucProveedor.TabIndex = 6
            '
            'lblRucProveedor
            '
            Me.lblRucProveedor.AutoSize = True
            Me.lblRucProveedor.Location = New System.Drawing.Point(322, 25)
            Me.lblRucProveedor.Name = "lblRucProveedor"
            Me.lblRucProveedor.Size = New System.Drawing.Size(31, 13)
            Me.lblRucProveedor.TabIndex = 5
            Me.lblRucProveedor.Text = "RUC:"
            '
            'txtFechaOrdenCompra
            '
            Me.txtFechaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtFechaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaOrdenCompra.Enabled = False
            Me.txtFechaOrdenCompra.Location = New System.Drawing.Point(202, 19)
            Me.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra"
            Me.txtFechaOrdenCompra.Size = New System.Drawing.Size(98, 21)
            Me.txtFechaOrdenCompra.TabIndex = 4
            '
            'txtIdOrdenCompra
            '
            Me.txtIdOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIdOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdOrdenCompra.Enabled = False
            Me.txtIdOrdenCompra.Location = New System.Drawing.Point(83, 19)
            Me.txtIdOrdenCompra.Name = "txtIdOrdenCompra"
            Me.txtIdOrdenCompra.Size = New System.Drawing.Size(72, 21)
            Me.txtIdOrdenCompra.TabIndex = 3
            '
            'lblFechaOrdenCompra
            '
            Me.lblFechaOrdenCompra.AutoSize = True
            Me.lblFechaOrdenCompra.Location = New System.Drawing.Point(158, 22)
            Me.lblFechaOrdenCompra.Name = "lblFechaOrdenCompra"
            Me.lblFechaOrdenCompra.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaOrdenCompra.TabIndex = 2
            Me.lblFechaOrdenCompra.Text = "FECHA:"
            '
            'lblNroOrdenCompra
            '
            Me.lblNroOrdenCompra.AutoSize = True
            Me.lblNroOrdenCompra.Location = New System.Drawing.Point(4, 22)
            Me.lblNroOrdenCompra.Name = "lblNroOrdenCompra"
            Me.lblNroOrdenCompra.Size = New System.Drawing.Size(23, 13)
            Me.lblNroOrdenCompra.TabIndex = 1
            Me.lblNroOrdenCompra.Text = "Nº:"
            '
            'lblIdOrdenCompra
            '
            Me.lblIdOrdenCompra.AutoSize = True
            Me.lblIdOrdenCompra.Location = New System.Drawing.Point(341, 0)
            Me.lblIdOrdenCompra.Name = "lblIdOrdenCompra"
            Me.lblIdOrdenCompra.Size = New System.Drawing.Size(19, 13)
            Me.lblIdOrdenCompra.TabIndex = 0
            Me.lblIdOrdenCompra.Text = "00"
            '
            'dgvOrdenCompra
            '
            Me.dgvOrdenCompra.AllowUserToAddRows = False
            Me.dgvOrdenCompra.AllowUserToDeleteRows = False
            Me.dgvOrdenCompra.AllowUserToOrderColumns = True
            Me.dgvOrdenCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvOrdenCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvOrdenCompra.Location = New System.Drawing.Point(2, 34)
            Me.dgvOrdenCompra.MultiSelect = False
            Me.dgvOrdenCompra.Name = "dgvOrdenCompra"
            Me.dgvOrdenCompra.ReadOnly = True
            Me.dgvOrdenCompra.RowHeadersVisible = False
            Me.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvOrdenCompra.Size = New System.Drawing.Size(538, 201)
            Me.dgvOrdenCompra.TabIndex = 43
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRecargar, Me.btnReporte, Me.btnAceptar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1018, 32)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnRecargar
            '
            Me.btnRecargar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(85, 28)
            Me.btnRecargar.Text = "BUSCAR"
            '
            'btnReporte
            '
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.syscisepro.My.Resources.Resources.ok
            Me.btnAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(84, 20)
            Me.btnAceptar.Text = "ACEPTAR"
            Me.btnAceptar.Visible = False
            '
            'FormBuscarOrdenCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1018, 572)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvDetalleOrdenCompra)
            Me.Controls.Add(Me.gbOrdenCompra)
            Me.Controls.Add(Me.dgvOrdenCompra)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarOrdenCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR ORDEN DE COMPRA"
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbOrdenCompra.ResumeLayout(False)
            Me.gbOrdenCompra.PerformLayout()
            CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbOrdenCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalORdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtIvaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtDescuentoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal0OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal12OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtTipoPagoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblTipoPagoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtFormaPagoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblFormaPagoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreProveedor As System.Windows.Forms.Label
        Friend WithEvents txtRucProveedor As System.Windows.Forms.TextBox
        Friend WithEvents lblRucProveedor As System.Windows.Forms.Label
        Friend WithEvents txtFechaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIdOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblNroOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Public WithEvents btnAceptar As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents btnRecargar As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents dgvOrdenCompra As System.Windows.Forms.DataGridView
    End Class
End Namespace