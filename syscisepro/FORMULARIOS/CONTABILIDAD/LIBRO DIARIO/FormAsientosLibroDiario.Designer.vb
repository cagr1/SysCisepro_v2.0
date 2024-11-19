Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAsientosLibroDiario
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsientosLibroDiario))
            Me.dtpAsientoDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpAsientoHasta = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbCuenta = New System.Windows.Forms.RadioButton()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbNumero = New System.Windows.Forms.RadioButton()
            Me.txtCuentaNueva = New System.Windows.Forms.TextBox()
            Me.txtNumeroAsientoBuscar = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TODOSLOSASIENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.txtTotalHaber = New System.Windows.Forms.Label()
            Me.txtTotalDebe = New System.Windows.Forms.Label()
            Me.PictureBoxErrorSumaAsiento = New System.Windows.Forms.PictureBox()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBoxErrorSumaAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(408, 4)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(90, 21)
            Me.dtpAsientoDesde.TabIndex = 6
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(551, 4)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(90, 21)
            Me.dtpAsientoHasta.TabIndex = 7
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(705, 326)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(147, 78)
            Me.GroupBox1.TabIndex = 136
            Me.GroupBox1.TabStop = False
            '
            'rbCuenta
            '
            Me.rbCuenta.AutoSize = True
            Me.rbCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCuenta.Location = New System.Drawing.Point(77, 5)
            Me.rbCuenta.Name = "rbCuenta"
            Me.rbCuenta.Size = New System.Drawing.Size(60, 17)
            Me.rbCuenta.TabIndex = 3
            Me.rbCuenta.TabStop = True
            Me.rbCuenta.Text = "Cuenta"
            Me.rbCuenta.UseVisualStyleBackColor = False
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbFecha.Checked = True
            Me.rbFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFecha.Location = New System.Drawing.Point(143, 5)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(55, 17)
            Me.rbFecha.TabIndex = 2
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "Fecha"
            Me.rbFecha.UseVisualStyleBackColor = False
            '
            'rbNumero
            '
            Me.rbNumero.AutoSize = True
            Me.rbNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbNumero.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNumero.Location = New System.Drawing.Point(8, 5)
            Me.rbNumero.Name = "rbNumero"
            Me.rbNumero.Size = New System.Drawing.Size(63, 17)
            Me.rbNumero.TabIndex = 1
            Me.rbNumero.TabStop = True
            Me.rbNumero.Text = "Asiento"
            Me.rbNumero.UseVisualStyleBackColor = False
            '
            'txtCuentaNueva
            '
            Me.txtCuentaNueva.BackColor = System.Drawing.Color.White
            Me.txtCuentaNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaNueva.Enabled = False
            Me.txtCuentaNueva.Location = New System.Drawing.Point(696, 3)
            Me.txtCuentaNueva.Name = "txtCuentaNueva"
            Me.txtCuentaNueva.Size = New System.Drawing.Size(309, 22)
            Me.txtCuentaNueva.TabIndex = 58
            '
            'txtNumeroAsientoBuscar
            '
            Me.txtNumeroAsientoBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroAsientoBuscar.Enabled = False
            Me.txtNumeroAsientoBuscar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroAsientoBuscar.Location = New System.Drawing.Point(262, 4)
            Me.txtNumeroAsientoBuscar.Name = "txtNumeroAsientoBuscar"
            Me.txtNumeroAsientoBuscar.Size = New System.Drawing.Size(68, 21)
            Me.txtNumeroAsientoBuscar.TabIndex = 4
            Me.txtNumeroAsientoBuscar.Text = "0"
            Me.txtNumeroAsientoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnGuardar, Me.btnAnular, Me.ToolStripMenuItem1, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1120, 32)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(87, 28)
            Me.btnBuscarAsiento.Text = "BUSCAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
            Me.btnGuardar.Text = "GUARDAR "
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(92, 28)
            Me.btnAnular.Text = "ANULAR "
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 28)
            Me.ToolStripMenuItem1.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTEASIENTOToolStripMenuItem, Me.TODOSLOSASIENTOSToolStripMenuItem})
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(90, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEASIENTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE ASIENTO"
            '
            'TODOSLOSASIENTOSToolStripMenuItem
            '
            Me.TODOSLOSASIENTOSToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.TODOSLOSASIENTOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.TODOSLOSASIENTOSToolStripMenuItem.Name = "TODOSLOSASIENTOSToolStripMenuItem"
            Me.TODOSLOSASIENTOSToolStripMenuItem.Size = New System.Drawing.Size(198, 30)
            Me.TODOSLOSASIENTOSToolStripMenuItem.Text = "TODOS LOS ASIENTOS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(98, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.CheckBox1.Location = New System.Drawing.Point(843, 5)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(156, 17)
            Me.CheckBox1.TabIndex = 187
            Me.CheckBox1.Text = "OCULTAR CUENTAS $ 0.00"
            Me.CheckBox1.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCuentaNueva)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAsientoHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAsientoDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroAsientoBuscar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNumero)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbFecha)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(1016, 62)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(647, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel4.TabIndex = 8
            Me.KryptonLabel4.Values.Text = "Cuenta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(504, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel3.TabIndex = 7
            Me.KryptonLabel3.Values.Text = "Hasta"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(357, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel2.TabIndex = 6
            Me.KryptonLabel2.Values.Text = "Desde"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(206, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel1.TabIndex = 5
            Me.KryptonLabel1.Values.Text = "Asiento"
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientosDiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientosDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(3, 105)
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GrayText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.RowHeadersWidth = 25
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(1117, 446)
            Me.dgvAsientosDiario.TabIndex = 189
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.AutoSize = True
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalHaber.Location = New System.Drawing.Point(958, 560)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(36, 18)
            Me.txtTotalHaber.TabIndex = 192
            Me.txtTotalHaber.Text = "0.00"
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.AutoSize = True
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.txtTotalDebe.Location = New System.Drawing.Point(781, 560)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(36, 18)
            Me.txtTotalDebe.TabIndex = 191
            Me.txtTotalDebe.Text = "0.00"
            '
            'PictureBoxErrorSumaAsiento
            '
            Me.PictureBoxErrorSumaAsiento.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.PictureBoxErrorSumaAsiento.Location = New System.Drawing.Point(692, 554)
            Me.PictureBoxErrorSumaAsiento.Name = "PictureBoxErrorSumaAsiento"
            Me.PictureBoxErrorSumaAsiento.Size = New System.Drawing.Size(26, 26)
            Me.PictureBoxErrorSumaAsiento.TabIndex = 190
            Me.PictureBoxErrorSumaAsiento.TabStop = False
            Me.PictureBoxErrorSumaAsiento.Visible = False
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(597, 557)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(49, 23)
            Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel5.TabIndex = 193
            Me.KryptonLabel5.Values.Text = "Total"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(724, 557)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(51, 23)
            Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel6.TabIndex = 194
            Me.KryptonLabel6.Values.Text = "Debe"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(895, 557)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(57, 23)
            Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KryptonLabel7.TabIndex = 195
            Me.KryptonLabel7.Values.Text = "Haber"
            '
            'FormAsientosLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1120, 584)
            Me.Controls.Add(Me.KryptonLabel7)
            Me.Controls.Add(Me.KryptonLabel6)
            Me.Controls.Add(Me.KryptonLabel5)
            Me.Controls.Add(Me.txtTotalHaber)
            Me.Controls.Add(Me.txtTotalDebe)
            Me.Controls.Add(Me.PictureBoxErrorSumaAsiento)
            Me.Controls.Add(Me.dgvAsientosDiario)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.CheckBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAsientosLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ASIENTOS LIBRO DIARIO GENERAL"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBoxErrorSumaAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbCuenta As System.Windows.Forms.RadioButton
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumero As System.Windows.Forms.RadioButton
        Friend WithEvents txtCuentaNueva As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroAsientoBuscar As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TODOSLOSASIENTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvAsientosDiario As DataGridView
        Friend WithEvents txtTotalHaber As Label
        Friend WithEvents txtTotalDebe As Label
        Friend WithEvents PictureBoxErrorSumaAsiento As PictureBox
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace