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
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.lblPorcentaje = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.chkProveedorGeneral = New System.Windows.Forms.CheckBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbParametrosBusqueda = New System.Windows.Forms.GroupBox()
            Me.rbTodos = New System.Windows.Forms.RadioButton()
            Me.rbCompras = New System.Windows.Forms.RadioButton()
            Me.rbCajaChica = New System.Windows.Forms.RadioButton()
            Me.rbFondoRotativo = New System.Windows.Forms.RadioButton()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.txtIva5Compras = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtSubTotalCompras = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtIvaCompras = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotalCompras = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTotalAPagar = New System.Windows.Forms.TextBox()
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
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnLiquidacionPath = New System.Windows.Forms.Button()
            Me.btnRetencionPath = New System.Windows.Forms.Button()
            Me.txtLiquidacionPath = New System.Windows.Forms.TextBox()
            Me.txtRetencionPath = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.PdfViewer1 = New PdfiumViewer.PdfViewer()
            Me.gbNombreComercialProveedor.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbParametrosBusqueda.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbTotal.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblPorcentaje)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label8)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label7)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gbNombreComercialProveedor.Controls.Add(Me.chkProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(0, 2)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(431, 61)
            Me.gbNombreComercialProveedor.TabIndex = 94
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'lblPorcentaje
            '
            Me.lblPorcentaje.AutoSize = True
            Me.lblPorcentaje.Location = New System.Drawing.Point(339, -1)
            Me.lblPorcentaje.Name = "lblPorcentaje"
            Me.lblPorcentaje.Size = New System.Drawing.Size(16, 13)
            Me.lblPorcentaje.TabIndex = 81
            Me.lblPorcentaje.Text = "..."
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(252, -1)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(11, 11)
            Me.lblEstadoComprobanteCompra.TabIndex = 80
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(211, -1)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(35, 13)
            Me.Label8.TabIndex = 79
            Me.Label8.Text = "TIPO:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(125, -1)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(37, 13)
            Me.Label7.TabIndex = 78
            Me.Label7.Text = "ID CC:"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(167, -1)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 3
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'chkProveedorGeneral
            '
            Me.chkProveedorGeneral.AutoSize = True
            Me.chkProveedorGeneral.Checked = True
            Me.chkProveedorGeneral.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkProveedorGeneral.Location = New System.Drawing.Point(362, 0)
            Me.chkProveedorGeneral.Name = "chkProveedorGeneral"
            Me.chkProveedorGeneral.Size = New System.Drawing.Size(63, 17)
            Me.chkProveedorGeneral.TabIndex = 77
            Me.chkProveedorGeneral.Text = "TODOS"
            Me.chkProveedorGeneral.UseVisualStyleBackColor = True
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(6, 24)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(414, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(74, -1)
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
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(6, 64)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(1151, 479)
            Me.dgvComprobantesCompra.TabIndex = 96
            '
            'gbParametrosBusqueda
            '
            Me.gbParametrosBusqueda.BackColor = System.Drawing.Color.White
            Me.gbParametrosBusqueda.Controls.Add(Me.rbTodos)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbCompras)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbCajaChica)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbFondoRotativo)
            Me.gbParametrosBusqueda.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParametrosBusqueda.Location = New System.Drawing.Point(435, 2)
            Me.gbParametrosBusqueda.Name = "gbParametrosBusqueda"
            Me.gbParametrosBusqueda.Size = New System.Drawing.Size(259, 61)
            Me.gbParametrosBusqueda.TabIndex = 103
            Me.gbParametrosBusqueda.TabStop = False
            Me.gbParametrosBusqueda.Text = "PARAMETROS DE BUSQUEDA"
            '
            'rbTodos
            '
            Me.rbTodos.AutoSize = True
            Me.rbTodos.Checked = True
            Me.rbTodos.Location = New System.Drawing.Point(195, 26)
            Me.rbTodos.Name = "rbTodos"
            Me.rbTodos.Size = New System.Drawing.Size(62, 17)
            Me.rbTodos.TabIndex = 3
            Me.rbTodos.TabStop = True
            Me.rbTodos.Text = "TODOS"
            Me.rbTodos.UseVisualStyleBackColor = True
            '
            'rbCompras
            '
            Me.rbCompras.AutoSize = True
            Me.rbCompras.Location = New System.Drawing.Point(122, 26)
            Me.rbCompras.Name = "rbCompras"
            Me.rbCompras.Size = New System.Drawing.Size(78, 17)
            Me.rbCompras.TabIndex = 2
            Me.rbCompras.Text = "COMPRAS"
            Me.rbCompras.UseVisualStyleBackColor = True
            '
            'rbCajaChica
            '
            Me.rbCajaChica.AutoSize = True
            Me.rbCajaChica.Location = New System.Drawing.Point(67, 26)
            Me.rbCajaChica.Name = "rbCajaChica"
            Me.rbCajaChica.Size = New System.Drawing.Size(52, 17)
            Me.rbCajaChica.TabIndex = 1
            Me.rbCajaChica.Text = "CAJA"
            Me.rbCajaChica.UseVisualStyleBackColor = True
            '
            'rbFondoRotativo
            '
            Me.rbFondoRotativo.AutoSize = True
            Me.rbFondoRotativo.Location = New System.Drawing.Point(6, 26)
            Me.rbFondoRotativo.Name = "rbFondoRotativo"
            Me.rbFondoRotativo.Size = New System.Drawing.Size(62, 17)
            Me.rbFondoRotativo.TabIndex = 0
            Me.rbFondoRotativo.Text = "FONDO"
            Me.rbFondoRotativo.UseVisualStyleBackColor = True
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Controls.Add(Me.Label9)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(699, 2)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(271, 61)
            Me.gbRangoFechas.TabIndex = 104
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(142, 24)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(106, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(24, 24)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(96, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(6, 27)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(19, 13)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "de"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(129, 27)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "a"
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Controls.Add(Me.txtIva5Compras)
            Me.gbTotal.Controls.Add(Me.Label12)
            Me.gbTotal.Controls.Add(Me.Label6)
            Me.gbTotal.Controls.Add(Me.txtSubTotalCompras)
            Me.gbTotal.Controls.Add(Me.Label5)
            Me.gbTotal.Controls.Add(Me.txtIvaCompras)
            Me.gbTotal.Controls.Add(Me.Label4)
            Me.gbTotal.Controls.Add(Me.txtTotalCompras)
            Me.gbTotal.Controls.Add(Me.Label3)
            Me.gbTotal.Controls.Add(Me.txtTotalRetencion)
            Me.gbTotal.Controls.Add(Me.Label2)
            Me.gbTotal.Controls.Add(Me.txtTotalAPagar)
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(0, 601)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1161, 44)
            Me.gbTotal.TabIndex = 106
            Me.gbTotal.TabStop = False
            '
            'txtIva5Compras
            '
            Me.txtIva5Compras.BackColor = System.Drawing.Color.White
            Me.txtIva5Compras.Enabled = False
            Me.txtIva5Compras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIva5Compras.Location = New System.Drawing.Point(368, 15)
            Me.txtIva5Compras.Name = "txtIva5Compras"
            Me.txtIva5Compras.Size = New System.Drawing.Size(79, 21)
            Me.txtIva5Compras.TabIndex = 17
            Me.txtIva5Compras.Text = "0.00"
            Me.txtIva5Compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(319, 20)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(36, 13)
            Me.Label12.TabIndex = 16
            Me.Label12.Text = "IVA 5:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(28, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(66, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "SUBTOTAL:"
            '
            'txtSubTotalCompras
            '
            Me.txtSubTotalCompras.BackColor = System.Drawing.Color.White
            Me.txtSubTotalCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalCompras.Enabled = False
            Me.txtSubTotalCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalCompras.Location = New System.Drawing.Point(95, 15)
            Me.txtSubTotalCompras.Name = "txtSubTotalCompras"
            Me.txtSubTotalCompras.ReadOnly = True
            Me.txtSubTotalCompras.Size = New System.Drawing.Size(71, 21)
            Me.txtSubTotalCompras.TabIndex = 14
            Me.txtSubTotalCompras.Text = "0.00"
            Me.txtSubTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(176, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(27, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "IVA:"
            '
            'txtIvaCompras
            '
            Me.txtIvaCompras.BackColor = System.Drawing.Color.White
            Me.txtIvaCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaCompras.Enabled = False
            Me.txtIvaCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaCompras.Location = New System.Drawing.Point(213, 15)
            Me.txtIvaCompras.Name = "txtIvaCompras"
            Me.txtIvaCompras.ReadOnly = True
            Me.txtIvaCompras.Size = New System.Drawing.Size(75, 21)
            Me.txtIvaCompras.TabIndex = 12
            Me.txtIvaCompras.Text = "0.00"
            Me.txtIvaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(482, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(101, 13)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "TOTAL COMPRAS:"
            '
            'txtTotalCompras
            '
            Me.txtTotalCompras.BackColor = System.Drawing.Color.White
            Me.txtTotalCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalCompras.Enabled = False
            Me.txtTotalCompras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCompras.Location = New System.Drawing.Point(583, 15)
            Me.txtTotalCompras.Name = "txtTotalCompras"
            Me.txtTotalCompras.ReadOnly = True
            Me.txtTotalCompras.Size = New System.Drawing.Size(72, 21)
            Me.txtTotalCompras.TabIndex = 10
            Me.txtTotalCompras.Text = "0.00"
            Me.txtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(679, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(108, 13)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "TOTAL RETENCIÓN:"
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(788, 15)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.ReadOnly = True
            Me.txtTotalRetencion.Size = New System.Drawing.Size(90, 21)
            Me.txtTotalRetencion.TabIndex = 8
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(935, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "TOTAL A PAGAR:"
            '
            'txtTotalAPagar
            '
            Me.txtTotalAPagar.BackColor = System.Drawing.Color.White
            Me.txtTotalAPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalAPagar.Enabled = False
            Me.txtTotalAPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAPagar.Location = New System.Drawing.Point(1032, 15)
            Me.txtTotalAPagar.Name = "txtTotalAPagar"
            Me.txtTotalAPagar.ReadOnly = True
            Me.txtTotalAPagar.Size = New System.Drawing.Size(90, 21)
            Me.txtTotalAPagar.TabIndex = 6
            Me.txtTotalAPagar.Text = "0.00"
            Me.txtTotalAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnReporte, Me.btnExportar, Me.ToolStripMenuItem1, Me.GENERARCOMPROBANTEToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1167, 32)
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
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(2, 33)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1165, 575)
            Me.TabControl1.TabIndex = 82
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.gbNombreComercialProveedor)
            Me.TabPage1.Controls.Add(Me.gbParametrosBusqueda)
            Me.TabPage1.Controls.Add(Me.dgvComprobantesCompra)
            Me.TabPage1.Controls.Add(Me.gbRangoFechas)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1157, 549)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "CONSULTAS"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.GroupBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1157, 549)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "RUTAS DOCUMENTOS"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnLiquidacionPath)
            Me.GroupBox1.Controls.Add(Me.btnRetencionPath)
            Me.GroupBox1.Controls.Add(Me.txtLiquidacionPath)
            Me.GroupBox1.Controls.Add(Me.txtRetencionPath)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 15)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1207, 111)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "SELECCIONE RUTAS"
            '
            'btnLiquidacionPath
            '
            Me.btnLiquidacionPath.FlatAppearance.BorderSize = 0
            Me.btnLiquidacionPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLiquidacionPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnLiquidacionPath.Location = New System.Drawing.Point(906, 48)
            Me.btnLiquidacionPath.Name = "btnLiquidacionPath"
            Me.btnLiquidacionPath.Size = New System.Drawing.Size(27, 27)
            Me.btnLiquidacionPath.TabIndex = 5
            Me.btnLiquidacionPath.UseVisualStyleBackColor = True
            '
            'btnRetencionPath
            '
            Me.btnRetencionPath.FlatAppearance.BorderSize = 0
            Me.btnRetencionPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRetencionPath.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnRetencionPath.Location = New System.Drawing.Point(906, 20)
            Me.btnRetencionPath.Name = "btnRetencionPath"
            Me.btnRetencionPath.Size = New System.Drawing.Size(27, 27)
            Me.btnRetencionPath.TabIndex = 4
            Me.btnRetencionPath.UseVisualStyleBackColor = True
            '
            'txtLiquidacionPath
            '
            Me.txtLiquidacionPath.Enabled = False
            Me.txtLiquidacionPath.Location = New System.Drawing.Point(231, 50)
            Me.txtLiquidacionPath.Name = "txtLiquidacionPath"
            Me.txtLiquidacionPath.Size = New System.Drawing.Size(656, 21)
            Me.txtLiquidacionPath.TabIndex = 3
            '
            'txtRetencionPath
            '
            Me.txtRetencionPath.Enabled = False
            Me.txtRetencionPath.Location = New System.Drawing.Point(231, 22)
            Me.txtRetencionPath.Name = "txtRetencionPath"
            Me.txtRetencionPath.Size = New System.Drawing.Size(656, 21)
            Me.txtRetencionPath.TabIndex = 2
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(11, 25)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(185, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "RUTA DE RETENCION DE COMPRA :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(11, 54)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(192, 13)
            Me.Label11.TabIndex = 1
            Me.Label11.Text = "RUTA DE LIQUIDACION DE COMPRA :"
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.PdfViewer1)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(1157, 549)
            Me.TabPage3.TabIndex = 2
            Me.TabPage3.Text = "Reporte"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'PdfViewer1
            '
            Me.PdfViewer1.Location = New System.Drawing.Point(6, 0)
            Me.PdfViewer1.Name = "PdfViewer1"
            Me.PdfViewer1.Size = New System.Drawing.Size(1149, 540)
            Me.PdfViewer1.TabIndex = 0
            '
            'FormBuscarComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1167, 645)
            Me.Controls.Add(Me.TabControl1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbTotal)
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
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbParametrosBusqueda.ResumeLayout(False)
            Me.gbParametrosBusqueda.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbTotal.ResumeLayout(False)
            Me.gbTotal.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabPage3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbParametrosBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents rbCompras As System.Windows.Forms.RadioButton
        Friend WithEvents rbCajaChica As System.Windows.Forms.RadioButton
        Friend WithEvents rbFondoRotativo As System.Windows.Forms.RadioButton
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents chkProveedorGeneral As System.Windows.Forms.CheckBox
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTotalAPagar As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtSubTotalCompras As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtIvaCompras As System.Windows.Forms.TextBox
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents XMLRETENCIÓNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents XMLNOTACRÉDITOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
        Friend WithEvents GENERARCOMPROBANTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PDFLIQUIDACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnLiquidacionPath As System.Windows.Forms.Button
        Friend WithEvents btnRetencionPath As System.Windows.Forms.Button
        Friend WithEvents txtLiquidacionPath As System.Windows.Forms.TextBox
        Friend WithEvents txtRetencionPath As System.Windows.Forms.TextBox
        Friend WithEvents PDFRETENCIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtIva5Compras As TextBox
        Friend WithEvents Label12 As Label
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents PdfViewer1 As PdfiumViewer.PdfViewer
    End Class
End Namespace