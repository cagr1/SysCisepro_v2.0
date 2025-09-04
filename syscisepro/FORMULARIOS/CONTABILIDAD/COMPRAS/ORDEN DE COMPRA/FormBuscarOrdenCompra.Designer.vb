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
            Me.txtTotalOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuentoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0OrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12OrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtTipoPagoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtFormaPagoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
            Me.txtRucProveedor = New System.Windows.Forms.TextBox()
            Me.txtFechaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIdOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblIdOrdenCompra = New System.Windows.Forms.Label()
            Me.dgvOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAceptar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtTotalOrdenCompra
            '
            Me.txtTotalOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalOrdenCompra.Enabled = False
            Me.txtTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalOrdenCompra.Location = New System.Drawing.Point(336, 150)
            Me.txtTotalOrdenCompra.Name = "txtTotalOrdenCompra"
            Me.txtTotalOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtTotalOrdenCompra.TabIndex = 22
            Me.txtTotalOrdenCompra.Text = "0.00"
            Me.txtTotalOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaOrdenCompra
            '
            Me.txtIvaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaOrdenCompra.Enabled = False
            Me.txtIvaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaOrdenCompra.Location = New System.Drawing.Point(336, 122)
            Me.txtIvaOrdenCompra.Name = "txtIvaOrdenCompra"
            Me.txtIvaOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtIvaOrdenCompra.TabIndex = 20
            Me.txtIvaOrdenCompra.Text = "0.00"
            Me.txtIvaOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuentoOrdenCompra
            '
            Me.txtDescuentoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoOrdenCompra.Enabled = False
            Me.txtDescuentoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoOrdenCompra.Location = New System.Drawing.Point(336, 96)
            Me.txtDescuentoOrdenCompra.Name = "txtDescuentoOrdenCompra"
            Me.txtDescuentoOrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtDescuentoOrdenCompra.TabIndex = 18
            Me.txtDescuentoOrdenCompra.Text = "0.00"
            Me.txtDescuentoOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0OrdenCompra
            '
            Me.txtSubtotal0OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0OrdenCompra.Enabled = False
            Me.txtSubtotal0OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0OrdenCompra.Location = New System.Drawing.Point(336, 70)
            Me.txtSubtotal0OrdenCompra.Name = "txtSubtotal0OrdenCompra"
            Me.txtSubtotal0OrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtSubtotal0OrdenCompra.TabIndex = 16
            Me.txtSubtotal0OrdenCompra.Text = "0.00"
            Me.txtSubtotal0OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12OrdenCompra
            '
            Me.txtSubtotal12OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12OrdenCompra.Enabled = False
            Me.txtSubtotal12OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12OrdenCompra.Location = New System.Drawing.Point(336, 45)
            Me.txtSubtotal12OrdenCompra.Name = "txtSubtotal12OrdenCompra"
            Me.txtSubtotal12OrdenCompra.Size = New System.Drawing.Size(65, 21)
            Me.txtSubtotal12OrdenCompra.TabIndex = 14
            Me.txtSubtotal12OrdenCompra.Text = "0.00"
            Me.txtSubtotal12OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTipoPagoOrdenCompra
            '
            Me.txtTipoPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTipoPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoPagoOrdenCompra.Enabled = False
            Me.txtTipoPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoPagoOrdenCompra.Location = New System.Drawing.Point(79, 150)
            Me.txtTipoPagoOrdenCompra.Name = "txtTipoPagoOrdenCompra"
            Me.txtTipoPagoOrdenCompra.Size = New System.Drawing.Size(146, 21)
            Me.txtTipoPagoOrdenCompra.TabIndex = 12
            '
            'txtFormaPagoOrdenCompra
            '
            Me.txtFormaPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtFormaPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFormaPagoOrdenCompra.Enabled = False
            Me.txtFormaPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFormaPagoOrdenCompra.Location = New System.Drawing.Point(79, 122)
            Me.txtFormaPagoOrdenCompra.Name = "txtFormaPagoOrdenCompra"
            Me.txtFormaPagoOrdenCompra.Size = New System.Drawing.Size(146, 21)
            Me.txtFormaPagoOrdenCompra.TabIndex = 10
            '
            'txtNombreProveedor
            '
            Me.txtNombreProveedor.BackColor = System.Drawing.Color.White
            Me.txtNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreProveedor.Enabled = False
            Me.txtNombreProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreProveedor.Location = New System.Drawing.Point(8, 70)
            Me.txtNombreProveedor.Multiline = True
            Me.txtNombreProveedor.Name = "txtNombreProveedor"
            Me.txtNombreProveedor.Size = New System.Drawing.Size(217, 46)
            Me.txtNombreProveedor.TabIndex = 8
            '
            'txtRucProveedor
            '
            Me.txtRucProveedor.BackColor = System.Drawing.Color.White
            Me.txtRucProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucProveedor.Enabled = False
            Me.txtRucProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucProveedor.Location = New System.Drawing.Point(307, 20)
            Me.txtRucProveedor.Name = "txtRucProveedor"
            Me.txtRucProveedor.Size = New System.Drawing.Size(94, 21)
            Me.txtRucProveedor.TabIndex = 6
            '
            'txtFechaOrdenCompra
            '
            Me.txtFechaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtFechaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaOrdenCompra.Enabled = False
            Me.txtFechaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaOrdenCompra.Location = New System.Drawing.Point(164, 21)
            Me.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra"
            Me.txtFechaOrdenCompra.Size = New System.Drawing.Size(98, 21)
            Me.txtFechaOrdenCompra.TabIndex = 4
            '
            'txtIdOrdenCompra
            '
            Me.txtIdOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIdOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdOrdenCompra.Enabled = False
            Me.txtIdOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdOrdenCompra.Location = New System.Drawing.Point(41, 21)
            Me.txtIdOrdenCompra.Name = "txtIdOrdenCompra"
            Me.txtIdOrdenCompra.Size = New System.Drawing.Size(72, 21)
            Me.txtIdOrdenCompra.TabIndex = 3
            '
            'lblIdOrdenCompra
            '
            Me.lblIdOrdenCompra.AutoSize = True
            Me.lblIdOrdenCompra.BackColor = System.Drawing.Color.Transparent
            Me.lblIdOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdOrdenCompra.Location = New System.Drawing.Point(274, -1)
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
            Me.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvOrdenCompra.Location = New System.Drawing.Point(9, 6)
            Me.dgvOrdenCompra.MultiSelect = False
            Me.dgvOrdenCompra.Name = "dgvOrdenCompra"
            Me.dgvOrdenCompra.ReadOnly = True
            Me.dgvOrdenCompra.RowHeadersVisible = False
            Me.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvOrdenCompra.Size = New System.Drawing.Size(554, 200)
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
            Me.btnReporte.Size = New System.Drawing.Size(91, 28)
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
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(576, 6)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIvaOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDescuentoOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSubtotal0OrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSubtotal12OrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreProveedor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFormaPagoOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucProveedor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTipoPagoOrdenCompra)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(429, 201)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(118, 21)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel11.TabIndex = 23
            Me.KryptonLabel11.Values.Text = "Fecha"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(267, 21)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel10.TabIndex = 20
            Me.KryptonLabel10.Values.Text = "RUC"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(231, 45)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(83, 20)
            Me.KryptonLabel9.TabIndex = 19
            Me.KryptonLabel9.Values.Text = "Subtotal 12%"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(231, 70)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel8.TabIndex = 18
            Me.KryptonLabel8.Values.Text = "Subtotal 0%"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(231, 96)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel7.TabIndex = 17
            Me.KryptonLabel7.Values.Text = "Descuento"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(231, 122)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel6.TabIndex = 16
            Me.KryptonLabel6.Values.Text = "IVA "
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(231, 150)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel5.TabIndex = 15
            Me.KryptonLabel5.Values.Text = "Total"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(8, 150)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel4.TabIndex = 14
            Me.KryptonLabel4.Values.Text = "Tipo"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(8, 122)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel3.TabIndex = 13
            Me.KryptonLabel3.Values.Text = "Pago"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(8, 45)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Proveedor"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(8, 20)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(27, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "No"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(1018, 540)
            Me.KryptonNavigator1.TabIndex = 190
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.dgvDetalleOrdenCompra)
            Me.KryptonPage1.Controls.Add(Me.dgvOrdenCompra)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(1016, 511)
            Me.KryptonPage1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Busqueda"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "5D44B70E5E604B1F24B31853908D244B"
            '
            'dgvDetalleOrdenCompra
            '
            Me.dgvDetalleOrdenCompra.AllowUserToAddRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
            Me.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(9, 218)
            Me.dgvDetalleOrdenCompra.MultiSelect = False
            Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
            Me.dgvDetalleOrdenCompra.ReadOnly = True
            Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
            Me.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(996, 282)
            Me.dgvDetalleOrdenCompra.TabIndex = 190
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.PdfViewer1)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(1016, 511)
            Me.KryptonPage2.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "B1CF942E9E5B4F0330AFA13F65BE84E0"
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(2, 3)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(1012, 505)
            Me.PdfViewer1.TabIndex = 0
            '
            'FormBuscarOrdenCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1018, 572)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarOrdenCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR ORDEN DE COMPRA"
            CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtTotalOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtTipoPagoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtFormaPagoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
        Friend WithEvents txtRucProveedor As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIdOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIdOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Public WithEvents btnAceptar As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents btnRecargar As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents dgvOrdenCompra As System.Windows.Forms.DataGridView
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents dgvDetalleOrdenCompra As DataGridView
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
    End Class
End Namespace