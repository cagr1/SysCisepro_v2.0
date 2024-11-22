Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarComprobantesCompra
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarComprobantesCompra))
            Me.lblPorcentaje = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.chkProveedorGeneral = New System.Windows.Forms.CheckBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbCompras = New System.Windows.Forms.RadioButton()
            Me.rbCajaChica = New System.Windows.Forms.RadioButton()
            Me.rbFondoRotativo = New System.Windows.Forms.RadioButton()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.XMLRETENCIÓNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.XMLNOTACRÉDITOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GENERARCOMPROBANTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PDFLIQUIDACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PDFRETENCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.btnLiquidacionPath = New System.Windows.Forms.Button()
            Me.btnRetencionPath = New System.Windows.Forms.Button()
            Me.txtLiquidacionPath = New System.Windows.Forms.TextBox()
            Me.txtRetencionPath = New System.Windows.Forms.TextBox()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.txtIva5Compras = New System.Windows.Forms.TextBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.txtTotalAPagar = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalCompras = New System.Windows.Forms.TextBox()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.txtSubTotalCompras = New System.Windows.Forms.TextBox()
            Me.txtIvaCompras = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblPorcentaje
            '
            Me.lblPorcentaje.AutoSize = True
            Me.lblPorcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblPorcentaje.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblPorcentaje.Location = New System.Drawing.Point(349, 6)
            Me.lblPorcentaje.Name = "lblPorcentaje"
            Me.lblPorcentaje.Size = New System.Drawing.Size(16, 13)
            Me.lblPorcentaje.TabIndex = 81
            Me.lblPorcentaje.Text = "..."
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(249, 6)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 80
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(156, 6)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 3
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'chkProveedorGeneral
            '
            Me.chkProveedorGeneral.AutoSize = True
            Me.chkProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.chkProveedorGeneral.Checked = True
            Me.chkProveedorGeneral.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkProveedorGeneral.Location = New System.Drawing.Point(371, 5)
            Me.chkProveedorGeneral.Name = "chkProveedorGeneral"
            Me.chkProveedorGeneral.Size = New System.Drawing.Size(56, 17)
            Me.chkProveedorGeneral.TabIndex = 77
            Me.chkProveedorGeneral.Text = "Todos"
            Me.chkProveedorGeneral.UseVisualStyleBackColor = False
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(6, 26)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(425, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(81, 6)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "0"
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(11, 90)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(923, 394)
            Me.dgvComprobantesCompra.TabIndex = 96
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbTodos.Checked = True
            Me.rbTodos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTodos.Location = New System.Drawing.Point(638, 26)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(56, 17)
            Me.rbTodos.TabIndex = 3
            Me.rbTodos.TabStop = True
            Me.rbTodos.Text = "Todos"
            Me.rbTodos.UseVisualStyleBackColor = False
            '
            'rbCompras
            '
            Me.rbCompras.AutoSize = True
            Me.rbCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbCompras.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCompras.Location = New System.Drawing.Point(565, 26)
            Me.rbCompras.Name = "rbCompras"
            Me.rbCompras.Size = New System.Drawing.Size(70, 17)
            Me.rbCompras.TabIndex = 2
            Me.rbCompras.Text = "Compras"
            Me.rbCompras.UseVisualStyleBackColor = False
            '
            'rbCajaChica
            '
            Me.rbCajaChica.AutoSize = True
            Me.rbCajaChica.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbCajaChica.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCajaChica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCajaChica.Location = New System.Drawing.Point(510, 26)
            Me.rbCajaChica.Name = "rbCajaChica"
            Me.rbCajaChica.Size = New System.Drawing.Size(47, 17)
            Me.rbCajaChica.TabIndex = 1
            Me.rbCajaChica.Text = "Caja"
            Me.rbCajaChica.UseVisualStyleBackColor = False
            '
            'rbFondoRotativo
            '
            Me.rbFondoRotativo.AutoSize = True
            Me.rbFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFondoRotativo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFondoRotativo.Location = New System.Drawing.Point(446, 26)
            Me.rbFondoRotativo.Name = "rbFondoRotativo"
            Me.rbFondoRotativo.Size = New System.Drawing.Size(59, 17)
            Me.rbFondoRotativo.TabIndex = 0
            Me.rbFondoRotativo.Text = "Fondo"
            Me.rbFondoRotativo.UseVisualStyleBackColor = False
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(817, 26)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(94, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(703, 26)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(92, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnReporte, Me.btnExportar, Me.ToolStripMenuItem1, Me.GENERARCOMPROBANTEToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(956, 32)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XMLRETENCIÓNToolStripMenuItem, Me.XMLNOTACRÉDITOToolStripMenuItem})
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(120, 28)
            Me.ToolStripMenuItem1.Text = "GENERAR XML"
            '
            'XMLRETENCIÓNToolStripMenuItem
            '
            Me.XMLRETENCIÓNToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.XMLRETENCIÓNToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.XMLRETENCIÓNToolStripMenuItem.Name = "XMLRETENCIÓNToolStripMenuItem"
            Me.XMLRETENCIÓNToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
            Me.XMLRETENCIÓNToolStripMenuItem.Text = "XML RETENCIÓN"
            '
            'XMLNOTACRÉDITOToolStripMenuItem
            '
            Me.XMLNOTACRÉDITOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.checkbook_20dp_FILL0_wght400_GRAD0_opsz20__2_
            Me.XMLNOTACRÉDITOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.XMLNOTACRÉDITOToolStripMenuItem.Name = "XMLNOTACRÉDITOToolStripMenuItem"
            Me.XMLNOTACRÉDITOToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
            Me.XMLNOTACRÉDITOToolStripMenuItem.Text = "XML LIQUIDACIÓN COMPRA"
            '
            'GENERARCOMPROBANTEToolStripMenuItem
            '
            Me.GENERARCOMPROBANTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDFLIQUIDACIONToolStripMenuItem, Me.PDFRETENCIONToolStripMenuItem})
            Me.GENERARCOMPROBANTEToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GENERARCOMPROBANTEToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.pdf
            Me.GENERARCOMPROBANTEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GENERARCOMPROBANTEToolStripMenuItem.Name = "GENERARCOMPROBANTEToolStripMenuItem"
            Me.GENERARCOMPROBANTEToolStripMenuItem.Size = New System.Drawing.Size(71, 28)
            Me.GENERARCOMPROBANTEToolStripMenuItem.Text = "RIDE"
            '
            'PDFLIQUIDACIONToolStripMenuItem
            '
            Me.PDFLIQUIDACIONToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.pdf
            Me.PDFLIQUIDACIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.PDFLIQUIDACIONToolStripMenuItem.Name = "PDFLIQUIDACIONToolStripMenuItem"
            Me.PDFLIQUIDACIONToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
            Me.PDFLIQUIDACIONToolStripMenuItem.Text = "LIQUIDACION"
            '
            'PDFRETENCIONToolStripMenuItem
            '
            Me.PDFRETENCIONToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.pdf
            Me.PDFRETENCIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.PDFRETENCIONToolStripMenuItem.Name = "PDFRETENCIONToolStripMenuItem"
            Me.PDFRETENCIONToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
            Me.PDFRETENCIONToolStripMenuItem.Text = "RETENCION"
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "OpenFileDialog1"
            '
            'btnLiquidacionPath
            '
            Me.btnLiquidacionPath.BackColor = System.Drawing.Color.Transparent
            Me.btnLiquidacionPath.FlatAppearance.BorderSize = 0
            Me.btnLiquidacionPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLiquidacionPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnLiquidacionPath.Location = New System.Drawing.Point(823, 37)
            Me.btnLiquidacionPath.Name = "btnLiquidacionPath"
            Me.btnLiquidacionPath.Size = New System.Drawing.Size(27, 27)
            Me.btnLiquidacionPath.TabIndex = 5
            Me.btnLiquidacionPath.UseVisualStyleBackColor = False
            '
            'btnRetencionPath
            '
            Me.btnRetencionPath.BackColor = System.Drawing.Color.Transparent
            Me.btnRetencionPath.FlatAppearance.BorderSize = 0
            Me.btnRetencionPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRetencionPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnRetencionPath.Location = New System.Drawing.Point(823, 9)
            Me.btnRetencionPath.Name = "btnRetencionPath"
            Me.btnRetencionPath.Size = New System.Drawing.Size(27, 27)
            Me.btnRetencionPath.TabIndex = 4
            Me.btnRetencionPath.UseVisualStyleBackColor = False
            '
            'txtLiquidacionPath
            '
            Me.txtLiquidacionPath.Enabled = False
            Me.txtLiquidacionPath.Location = New System.Drawing.Point(202, 39)
            Me.txtLiquidacionPath.Name = "txtLiquidacionPath"
            Me.txtLiquidacionPath.Size = New System.Drawing.Size(615, 20)
            Me.txtLiquidacionPath.TabIndex = 3
            '
            'txtRetencionPath
            '
            Me.txtRetencionPath.Enabled = False
            Me.txtRetencionPath.Location = New System.Drawing.Point(202, 13)
            Me.txtRetencionPath.Name = "txtRetencionPath"
            Me.txtRetencionPath.Size = New System.Drawing.Size(615, 20)
            Me.txtRetencionPath.TabIndex = 2
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(-1, 0)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(944, 555)
            Me.PdfViewer1.TabIndex = 0
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Location = New System.Drawing.Point(6, 49)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2, Me.KryptonPage3})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(944, 584)
            Me.KryptonNavigator1.TabIndex = 184
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage1.Controls.Add(Me.dgvComprobantesCompra)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(942, 557)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Consultas"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "60A89A382CC14AB266BE4180ACB5260B"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(11, 490)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIva5Compras)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalAPagar)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalCompras)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubTotalCompras)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIvaCompras)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(923, 59)
            Me.KryptonGroupBox3.TabIndex = 186
            Me.KryptonGroupBox3.Values.Heading = "Valores"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel14.Location = New System.Drawing.Point(740, 6)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(87, 20)
            Me.KryptonLabel14.TabIndex = 20
            Me.KryptonLabel14.Values.Text = "Total a Pagar"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel13.Location = New System.Drawing.Point(544, 5)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(102, 20)
            Me.KryptonLabel13.TabIndex = 19
            Me.KryptonLabel13.Values.Text = "Total Retencion"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel12.Location = New System.Drawing.Point(376, 5)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(95, 20)
            Me.KryptonLabel12.TabIndex = 18
            Me.KryptonLabel12.Values.Text = "Total Compras"
            '
            'txtIva5Compras
            '
            Me.txtIva5Compras.BackColor = System.Drawing.Color.White
            Me.txtIva5Compras.Enabled = False
            Me.txtIva5Compras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIva5Compras.Location = New System.Drawing.Point(293, 5)
            Me.txtIva5Compras.Name = "txtIva5Compras"
            Me.txtIva5Compras.Size = New System.Drawing.Size(79, 21)
            Me.txtIva5Compras.TabIndex = 17
            Me.txtIva5Compras.Text = "0.00"
            Me.txtIva5Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel11.Location = New System.Drawing.Point(250, 3)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel11.TabIndex = 16
            Me.KryptonLabel11.Values.Text = "IVA 5"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel10.Location = New System.Drawing.Point(141, 5)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel10.TabIndex = 15
            Me.KryptonLabel10.Values.Text = "IVA"
            '
            'txtTotalAPagar
            '
            Me.txtTotalAPagar.BackColor = System.Drawing.Color.White
            Me.txtTotalAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalAPagar.Enabled = False
            Me.txtTotalAPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAPagar.Location = New System.Drawing.Point(826, 4)
            Me.txtTotalAPagar.Name = "txtTotalAPagar"
            Me.txtTotalAPagar.ReadOnly = True
            Me.txtTotalAPagar.Size = New System.Drawing.Size(90, 21)
            Me.txtTotalAPagar.TabIndex = 6
            Me.txtTotalAPagar.Text = "0.00"
            Me.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(645, 5)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.ReadOnly = True
            Me.txtTotalRetencion.Size = New System.Drawing.Size(90, 21)
            Me.txtTotalRetencion.TabIndex = 8
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalCompras
            '
            Me.txtTotalCompras.BackColor = System.Drawing.Color.White
            Me.txtTotalCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalCompras.Enabled = False
            Me.txtTotalCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCompras.Location = New System.Drawing.Point(468, 5)
            Me.txtTotalCompras.Name = "txtTotalCompras"
            Me.txtTotalCompras.ReadOnly = True
            Me.txtTotalCompras.Size = New System.Drawing.Size(72, 21)
            Me.txtTotalCompras.TabIndex = 10
            Me.txtTotalCompras.Text = "0.00"
            Me.txtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel9.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel9.TabIndex = 0
            Me.KryptonLabel9.Values.Text = "SubTotal"
            '
            'txtSubTotalCompras
            '
            Me.txtSubTotalCompras.BackColor = System.Drawing.Color.White
            Me.txtSubTotalCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalCompras.Enabled = False
            Me.txtSubTotalCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalCompras.Location = New System.Drawing.Point(67, 4)
            Me.txtSubTotalCompras.Name = "txtSubTotalCompras"
            Me.txtSubTotalCompras.ReadOnly = True
            Me.txtSubTotalCompras.Size = New System.Drawing.Size(71, 21)
            Me.txtSubTotalCompras.TabIndex = 14
            Me.txtSubTotalCompras.Text = "0.00"
            Me.txtSubTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaCompras
            '
            Me.txtIvaCompras.BackColor = System.Drawing.Color.White
            Me.txtIvaCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaCompras.Enabled = False
            Me.txtIvaCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaCompras.Location = New System.Drawing.Point(171, 5)
            Me.txtIvaCompras.Name = "txtIvaCompras"
            Me.txtIvaCompras.ReadOnly = True
            Me.txtIvaCompras.Size = New System.Drawing.Size(75, 21)
            Me.txtIvaCompras.TabIndex = 12
            Me.txtIvaCompras.Text = "0.00"
            Me.txtIvaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(9, 9)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblPorcentaje)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCompras)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCajaChica)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFondoRotativo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteCompra)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(923, 78)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(817, 3)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel6.TabIndex = 84
            Me.KryptonLabel6.Values.Text = "Hasta"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(703, 3)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel5.TabIndex = 83
            Me.KryptonLabel5.Values.Text = "Desde"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(445, 2)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel4.TabIndex = 82
            Me.KryptonLabel4.Values.Text = "Parametros"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(214, 2)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel3.TabIndex = 78
            Me.KryptonLabel3.Values.Text = "Tipo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(114, 2)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel2.TabIndex = 77
            Me.KryptonLabel2.Values.Text = "Id CC"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(10, 2)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel1.TabIndex = 3
            Me.KryptonLabel1.Values.Text = "Proveedor"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(942, 557)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Rutas de Documentos"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "405B3CD29AE442AC3988A040680630DA"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(23, 30)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnLiquidacionPath)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtRetencionPath)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnRetencionPath)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtLiquidacionPath)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(877, 105)
            Me.KryptonGroupBox2.TabIndex = 0
            Me.KryptonGroupBox2.Values.Heading = "Seleecion de Rutas"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(8, 37)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(182, 20)
            Me.KryptonLabel8.TabIndex = 7
            Me.KryptonLabel8.Values.Text = "Ruta de Liquidacion de Compra"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(7, 12)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(174, 20)
            Me.KryptonLabel7.TabIndex = 6
            Me.KryptonLabel7.Values.Text = "Ruta de Retencion de Compra"
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.PdfViewer1)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(942, 557)
            Me.KryptonPage3.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage3.Text = "Reporte"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "E7A068A9D4EC4B4A40A25EDDE0DE1F87"
            '
            'FormBuscarComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(956, 645)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBuscarComprobantesCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR COMPROBANTES DE COMPRA"
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents rbCompras As System.Windows.Forms.RadioButton
        Friend WithEvents rbCajaChica As System.Windows.Forms.RadioButton
        Friend WithEvents rbFondoRotativo As System.Windows.Forms.RadioButton
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents chkProveedorGeneral As System.Windows.Forms.CheckBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents XMLRETENCIÓNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents XMLNOTACRÉDITOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
        Friend WithEvents GENERARCOMPROBANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PDFLIQUIDACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnLiquidacionPath As System.Windows.Forms.Button
        Friend WithEvents btnRetencionPath As System.Windows.Forms.Button
        Friend WithEvents txtLiquidacionPath As System.Windows.Forms.TextBox
        Friend WithEvents txtRetencionPath As System.Windows.Forms.TextBox
        Friend WithEvents PDFRETENCIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtIva5Compras As TextBox
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtTotalAPagar As TextBox
        Friend WithEvents txtTotalRetencion As TextBox
        Friend WithEvents txtTotalCompras As TextBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtSubTotalCompras As TextBox
        Friend WithEvents txtIvaCompras As TextBox
    End Class
End Namespace