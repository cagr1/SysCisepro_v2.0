Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmReporteAsistencia
        'Inherits System.Windows.Forms.Form
        'Inherits MaterialSkin.Controls.MaterialForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        Inherits Krypton.Toolkit.KryptonForm
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteAsistencia))
            Me.tcSitios = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
            Me.btnAgregar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCambiar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnQuitar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAddRad = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.NOVEDADESACBMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTESDERADIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.EXPORTARDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.GUARDARCAMBIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgvDia = New System.Windows.Forms.DataGridView()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.RIVER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HORARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.dgvNoche = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.RIVER2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.HORARIO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.ListView3 = New System.Windows.Forms.ListView()
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Button10 = New System.Windows.Forms.Button()
            Me.Button7 = New System.Windows.Forms.Button()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcSitios.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.MenuStrip3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.MenuStrip2.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgvDia, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage3.SuspendLayout()
            CType(Me.dgvNoche, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage5.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcSitios
            '
            Me.tcSitios.Controls.Add(Me.TabPage1)
            Me.tcSitios.Controls.Add(Me.TabPage4)
            Me.tcSitios.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcSitios.Location = New System.Drawing.Point(2, 2)
            Me.tcSitios.Name = "tcSitios"
            Me.tcSitios.SelectedIndex = 0
            Me.tcSitios.Size = New System.Drawing.Size(1271, 671)
            Me.tcSitios.TabIndex = 2
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.Panel3)
            Me.TabPage1.Controls.Add(Me.Panel1)
            Me.TabPage1.Controls.Add(Me.TabControl1)
            Me.TabPage1.Controls.Add(Me.GroupBox4)
            Me.TabPage1.Controls.Add(Me.Label24)
            Me.TabPage1.Controls.Add(Me.Panel2)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1263, 645)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "MANTENIMIENTO"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.MenuStrip3)
            Me.Panel3.Location = New System.Drawing.Point(562, 88)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(700, 42)
            Me.Panel3.TabIndex = 217
            '
            'MenuStrip3
            '
            Me.MenuStrip3.AutoSize = False
            Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
            Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.btnCambiar, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.btnQuitar, Me.btnAddRad, Me.ToolStripMenuItem6})
            Me.MenuStrip3.Location = New System.Drawing.Point(0, 2)
            Me.MenuStrip3.Name = "MenuStrip3"
            Me.MenuStrip3.Size = New System.Drawing.Size(700, 38)
            Me.MenuStrip3.TabIndex = 1
            Me.MenuStrip3.Text = "MenuStrip3"
            '
            'btnAgregar
            '
            Me.btnAgregar.AutoToolTip = True
            Me.btnAgregar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.ForeColor = System.Drawing.Color.Black
            Me.btnAgregar.Image = Global.syscisepro.My.Resources.Resources.person_add_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(36, 34)
            Me.btnAgregar.ToolTipText = "Agregar"
            '
            'btnCambiar
            '
            Me.btnCambiar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCambiar.ForeColor = System.Drawing.Color.Black
            Me.btnCambiar.Image = Global.syscisepro.My.Resources.Resources.person_edit_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCambiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCambiar.Name = "btnCambiar"
            Me.btnCambiar.Size = New System.Drawing.Size(36, 34)
            Me.btnCambiar.ToolTipText = "cambiar nombre"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Black
            Me.ToolStripMenuItem3.Image = Global.syscisepro.My.Resources.Resources.location_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(36, 34)
            Me.ToolStripMenuItem3.ToolTipText = "river"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.calendar_month_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(36, 34)
            Me.ToolStripMenuItem1.ToolTipText = "turno"
            '
            'btnQuitar
            '
            Me.btnQuitar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnQuitar.ForeColor = System.Drawing.Color.Black
            Me.btnQuitar.Image = Global.syscisepro.My.Resources.Resources.person_cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnQuitar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnQuitar.Name = "btnQuitar"
            Me.btnQuitar.Size = New System.Drawing.Size(36, 34)
            Me.btnQuitar.ToolTipText = "quitar"
            '
            'btnAddRad
            '
            Me.btnAddRad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddRad.ForeColor = System.Drawing.Color.Black
            Me.btnAddRad.Image = Global.syscisepro.My.Resources.Resources.record_voice_over_24dp
            Me.btnAddRad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAddRad.Name = "btnAddRad"
            Me.btnAddRad.Size = New System.Drawing.Size(36, 34)
            Me.btnAddRad.ToolTipText = "rep +"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.Black
            Me.ToolStripMenuItem6.Image = Global.syscisepro.My.Resources.Resources.voice_over_off_24dp
            Me.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(36, 34)
            Me.ToolStripMenuItem6.ToolTipText = "rep -"
            '
            'Panel1
            '
            Me.Panel1.AutoSize = True
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Panel1.Controls.Add(Me.MenuStrip1)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.DateTimePicker4)
            Me.Panel1.Controls.Add(Me.MenuStrip2)
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1262, 39)
            Me.Panel1.TabIndex = 215
            '
            'MenuStrip1
            '
            Me.MenuStrip1.AutoSize = False
            Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTESToolStripMenuItem, Me.GUARDARCAMBIOSToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(1018, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(244, 36)
            Me.MenuStrip1.TabIndex = 1
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'REPORTESToolStripMenuItem
            '
            Me.REPORTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NOVEDADESACBMToolStripMenuItem, Me.REPORTESDERADIOToolStripMenuItem, Me.ToolStripSeparator1, Me.EXPORTARDATOSToolStripMenuItem})
            Me.REPORTESToolStripMenuItem.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.REPORTESToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
            Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(101, 32)
            Me.REPORTESToolStripMenuItem.Text = "REPORTES"
            '
            'NOVEDADESACBMToolStripMenuItem
            '
            Me.NOVEDADESACBMToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.NOVEDADESACBMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.NOVEDADESACBMToolStripMenuItem.Name = "NOVEDADESACBMToolStripMenuItem"
            Me.NOVEDADESACBMToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
            Me.NOVEDADESACBMToolStripMenuItem.Text = "NOVEDADES A / C B.M."
            '
            'REPORTESDERADIOToolStripMenuItem
            '
            Me.REPORTESDERADIOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.REPORTESDERADIOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTESDERADIOToolStripMenuItem.Name = "REPORTESDERADIOToolStripMenuItem"
            Me.REPORTESDERADIOToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
            Me.REPORTESDERADIOToolStripMenuItem.Text = "SANCIONES / MULTAS"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
            '
            'EXPORTARDATOSToolStripMenuItem
            '
            Me.EXPORTARDATOSToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.EXPORTARDATOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.EXPORTARDATOSToolStripMenuItem.Name = "EXPORTARDATOSToolStripMenuItem"
            Me.EXPORTARDATOSToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
            Me.EXPORTARDATOSToolStripMenuItem.Text = "EXPORTAR DATOS"
            '
            'GUARDARCAMBIOSToolStripMenuItem
            '
            Me.GUARDARCAMBIOSToolStripMenuItem.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GUARDARCAMBIOSToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.GUARDARCAMBIOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.GUARDARCAMBIOSToolStripMenuItem.Name = "GUARDARCAMBIOSToolStripMenuItem"
            Me.GUARDARCAMBIOSToolStripMenuItem.Size = New System.Drawing.Size(100, 32)
            Me.GUARDARCAMBIOSToolStripMenuItem.Text = "GUARDAR "
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(544, 10)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(60, 15)
            Me.Label8.TabIndex = 206
            Me.Label8.Text = "USUARIO"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Transparent
            Me.Label7.Location = New System.Drawing.Point(471, 10)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(71, 15)
            Me.Label7.TabIndex = 205
            Me.Label7.Text = "TURNO DE:"
            '
            'DateTimePicker4
            '
            Me.DateTimePicker4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker4.Location = New System.Drawing.Point(104, 7)
            Me.DateTimePicker4.Name = "DateTimePicker4"
            Me.DateTimePicker4.Size = New System.Drawing.Size(248, 21)
            Me.DateTimePicker4.TabIndex = 204
            '
            'MenuStrip2
            '
            Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
            Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
            Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip2.Name = "MenuStrip2"
            Me.MenuStrip2.Size = New System.Drawing.Size(96, 32)
            Me.MenuStrip2.TabIndex = 1
            Me.MenuStrip2.Text = "MenuStrip2"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(88, 28)
            Me.ToolStripMenuItem2.Text = "BUSCAR"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Controls.Add(Me.TabPage5)
            Me.TabControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(3, 130)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1259, 510)
            Me.TabControl1.TabIndex = 209
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.dgvDia)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1251, 484)
            Me.TabPage2.TabIndex = 0
            Me.TabPage2.Text = "DÍA"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'dgvDia
            '
            Me.dgvDia.AllowUserToAddRows = False
            Me.dgvDia.AllowUserToDeleteRows = False
            Me.dgvDia.AllowUserToOrderColumns = True
            Me.dgvDia.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvDia.BackgroundColor = System.Drawing.Color.White
            Me.dgvDia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.RIVER, Me.Column1, Me.Column2, Me.Column3, Me.Column31, Me.Column4, Me.Column9, Me.Column6, Me.HORARIO, Me.Column7, Me.Column8, Me.Column10, Me.Column13, Me.Column11, Me.Column14})
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDia.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvDia.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvDia.Location = New System.Drawing.Point(2, 3)
            Me.dgvDia.MultiSelect = False
            Me.dgvDia.Name = "dgvDia"
            Me.dgvDia.RowHeadersVisible = False
            Me.dgvDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDia.Size = New System.Drawing.Size(1246, 478)
            Me.dgvDia.TabIndex = 202
            '
            'Column15
            '
            Me.Column15.Frozen = True
            Me.Column15.HeaderText = "N° RIV"
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            Me.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column15.Visible = False
            '
            'RIVER
            '
            Me.RIVER.Frozen = True
            Me.RIVER.HeaderText = "RIV"
            Me.RIVER.Name = "RIVER"
            Me.RIVER.ReadOnly = True
            Me.RIVER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.RIVER.Width = 40
            '
            'Column1
            '
            Me.Column1.Frozen = True
            Me.Column1.HeaderText = "IDPR"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column1.Visible = False
            '
            'Column2
            '
            Me.Column2.Frozen = True
            Me.Column2.HeaderText = "IDPE"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column2.Visible = False
            Me.Column2.Width = 50
            '
            'Column3
            '
            Me.Column3.Frozen = True
            Me.Column3.HeaderText = "APELLIDOS Y NOMBRES"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column3.Width = 250
            '
            'Column31
            '
            Me.Column31.Frozen = True
            Me.Column31.HeaderText = "IDS"
            Me.Column31.Name = "Column31"
            Me.Column31.ReadOnly = True
            Me.Column31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column31.Visible = False
            Me.Column31.Width = 50
            '
            'Column4
            '
            Me.Column4.Frozen = True
            Me.Column4.HeaderText = "SITIO DE TRABAJO"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column4.Width = 180
            '
            'Column9
            '
            Me.Column9.HeaderText = "DIRECCIÓN DEL SITIO DE TRABAJO"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column9.Width = 290
            '
            'Column6
            '
            Me.Column6.HeaderText = "IDH"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column6.Visible = False
            '
            'HORARIO
            '
            Me.HORARIO.HeaderText = "HORARIO"
            Me.HORARIO.Name = "HORARIO"
            Me.HORARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.HORARIO.Width = 90
            '
            'Column7
            '
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
            Me.Column7.DropDownWidth = 170
            Me.Column7.HeaderText = "REPORTE"
            Me.Column7.Items.AddRange(New Object() {"PENDIENTE", "ATRASO", "ASISTENCIA", "DOBLADA", "CALAMIDAD DOMÉSTICA", "PERMISO MÉDICO", "VACACIONES", "INASISTENCIA"})
            Me.Column7.Name = "Column7"
            Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Column7.Width = 150
            '
            'Column8
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column8.DefaultCellStyle = DataGridViewCellStyle3
            Me.Column8.HeaderText = "H. ENTRADA"
            Me.Column8.Name = "Column8"
            Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column8.Width = 80
            '
            'Column10
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column10.DefaultCellStyle = DataGridViewCellStyle4
            Me.Column10.HeaderText = "H. 050"
            Me.Column10.Name = "Column10"
            Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column10.Width = 50
            '
            'Column13
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column13.DefaultCellStyle = DataGridViewCellStyle5
            Me.Column13.HeaderText = "H. 051"
            Me.Column13.Name = "Column13"
            Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column13.Visible = False
            Me.Column13.Width = 40
            '
            'Column11
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column11.DefaultCellStyle = DataGridViewCellStyle6
            Me.Column11.HeaderText = "H. 040"
            Me.Column11.Name = "Column11"
            Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column11.Width = 50
            '
            'Column14
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column14.DefaultCellStyle = DataGridViewCellStyle7
            Me.Column14.DividerWidth = 3
            Me.Column14.HeaderText = "H. 041"
            Me.Column14.Name = "Column14"
            Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column14.Visible = False
            Me.Column14.Width = 40
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.dgvNoche)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(1251, 484)
            Me.TabPage3.TabIndex = 1
            Me.TabPage3.Text = "NOCHE"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'dgvNoche
            '
            Me.dgvNoche.AllowUserToAddRows = False
            Me.dgvNoche.AllowUserToDeleteRows = False
            Me.dgvNoche.AllowUserToOrderColumns = True
            Me.dgvNoche.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNoche.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvNoche.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvNoche.BackgroundColor = System.Drawing.Color.White
            Me.dgvNoche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNoche.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.RIVER2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.HORARIO2, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvNoche.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvNoche.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvNoche.Location = New System.Drawing.Point(2, 3)
            Me.dgvNoche.MultiSelect = False
            Me.dgvNoche.Name = "dgvNoche"
            Me.dgvNoche.RowHeadersVisible = False
            Me.dgvNoche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNoche.Size = New System.Drawing.Size(1246, 478)
            Me.dgvNoche.TabIndex = 203
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.Frozen = True
            Me.DataGridViewTextBoxColumn1.HeaderText = "N° RIV"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn1.Visible = False
            '
            'RIVER2
            '
            Me.RIVER2.Frozen = True
            Me.RIVER2.HeaderText = "RIV"
            Me.RIVER2.Name = "RIVER2"
            Me.RIVER2.ReadOnly = True
            Me.RIVER2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.RIVER2.Width = 40
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.Frozen = True
            Me.DataGridViewTextBoxColumn3.HeaderText = "IDPR"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn3.Visible = False
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.Frozen = True
            Me.DataGridViewTextBoxColumn4.HeaderText = "IDPE"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn4.Visible = False
            Me.DataGridViewTextBoxColumn4.Width = 50
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.Frozen = True
            Me.DataGridViewTextBoxColumn5.HeaderText = "APELLIDOS Y NOMBRES"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn5.Width = 250
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.Frozen = True
            Me.DataGridViewTextBoxColumn6.HeaderText = "IDS"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn6.Visible = False
            Me.DataGridViewTextBoxColumn6.Width = 50
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.Frozen = True
            Me.DataGridViewTextBoxColumn7.HeaderText = "SITIO DE TRABAJO"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn7.Width = 180
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.HeaderText = "DIRECCIÓN DEL SITIO DE TRABAJO"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn8.Width = 290
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.HeaderText = "IDH"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn9.Visible = False
            '
            'HORARIO2
            '
            Me.HORARIO2.HeaderText = "HORARIO"
            Me.HORARIO2.Name = "HORARIO2"
            Me.HORARIO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.HORARIO2.Width = 90
            '
            'DataGridViewComboBoxColumn1
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
            Me.DataGridViewComboBoxColumn1.DropDownWidth = 170
            Me.DataGridViewComboBoxColumn1.HeaderText = "REPORTE"
            Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"PENDIENTE", "ATRASO", "ASISTENCIA", "DOBLADA", "CALAMIDAD DOMÉSTICA", "PERMISO MÉDICO", "VACACIONES", "INASISTENCIA"})
            Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
            Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridViewComboBoxColumn1.Width = 150
            '
            'DataGridViewTextBoxColumn11
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle11
            Me.DataGridViewTextBoxColumn11.HeaderText = "H. ENTRADA"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn11.Width = 80
            '
            'DataGridViewTextBoxColumn12
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle12
            Me.DataGridViewTextBoxColumn12.HeaderText = "050"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn12.Visible = False
            Me.DataGridViewTextBoxColumn12.Width = 40
            '
            'DataGridViewTextBoxColumn13
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle13
            Me.DataGridViewTextBoxColumn13.HeaderText = "051"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn13.Width = 40
            '
            'DataGridViewTextBoxColumn14
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle14
            Me.DataGridViewTextBoxColumn14.HeaderText = "040"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn14.Visible = False
            Me.DataGridViewTextBoxColumn14.Width = 40
            '
            'DataGridViewTextBoxColumn15
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle15
            Me.DataGridViewTextBoxColumn15.DividerWidth = 3
            Me.DataGridViewTextBoxColumn15.HeaderText = "041"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn15.Visible = False
            Me.DataGridViewTextBoxColumn15.Width = 40
            '
            'TabPage5
            '
            Me.TabPage5.Controls.Add(Me.DataGridView1)
            Me.TabPage5.Location = New System.Drawing.Point(4, 22)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage5.Size = New System.Drawing.Size(1251, 484)
            Me.TabPage5.TabIndex = 2
            Me.TabPage5.Text = "DÍA LIBRE"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AllowUserToOrderColumns = True
            Me.DataGridView1.AllowUserToResizeRows = False
            DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.Column12, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn23, Me.Column5})
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle20
            Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DataGridView1.Location = New System.Drawing.Point(2, 3)
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView1.Size = New System.Drawing.Size(1246, 478)
            Me.DataGridView1.TabIndex = 204
            '
            'DataGridViewTextBoxColumn10
            '
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle18
            Me.DataGridViewTextBoxColumn10.Frozen = True
            Me.DataGridViewTextBoxColumn10.HeaderText = "RIV"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn10.Width = 40
            '
            'Column12
            '
            Me.Column12.Frozen = True
            Me.Column12.HeaderText = "IDP"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.Visible = False
            '
            'DataGridViewTextBoxColumn18
            '
            Me.DataGridViewTextBoxColumn18.Frozen = True
            Me.DataGridViewTextBoxColumn18.HeaderText = "APELLIDOS Y NOMBRES"
            Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
            Me.DataGridViewTextBoxColumn18.ReadOnly = True
            Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn18.Width = 250
            '
            'DataGridViewTextBoxColumn20
            '
            Me.DataGridViewTextBoxColumn20.Frozen = True
            Me.DataGridViewTextBoxColumn20.HeaderText = "SITIO DE TRABAJO"
            Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
            Me.DataGridViewTextBoxColumn20.ReadOnly = True
            Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn20.Width = 180
            '
            'DataGridViewTextBoxColumn21
            '
            Me.DataGridViewTextBoxColumn21.HeaderText = "DIRECCIÓN DEL SITIO DE TRABAJO"
            Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
            Me.DataGridViewTextBoxColumn21.ReadOnly = True
            Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn21.Width = 290
            '
            'DataGridViewTextBoxColumn23
            '
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle19
            Me.DataGridViewTextBoxColumn23.HeaderText = "DIAS LABORABLE"
            Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
            Me.DataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DataGridViewTextBoxColumn23.Width = 110
            '
            'Column5
            '
            Me.Column5.HeaderText = "DOBLA / TURNO / REEMPLAZO"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 350
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker5)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox4.Controls.Add(Me.TextBox3)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.dtpMes)
            Me.GroupBox4.Controls.Add(Me.Label17)
            Me.GroupBox4.Controls.Add(Me.Label16)
            Me.GroupBox4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(3, 41)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(1257, 46)
            Me.GroupBox4.TabIndex = 201
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "REPORTE DE ASISTENCIA DEL"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(376, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(184, 13)
            Me.Label1.TabIndex = 205
            Me.Label1.Text = "DETALLES DE LA PROGRAMACIÓN:"
            '
            'DateTimePicker5
            '
            Me.DateTimePicker5.Enabled = False
            Me.DateTimePicker5.Location = New System.Drawing.Point(15, 14)
            Me.DateTimePicker5.Name = "DateTimePicker5"
            Me.DateTimePicker5.Size = New System.Drawing.Size(248, 21)
            Me.DateTimePicker5.TabIndex = 204
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker2.Enabled = False
            Me.DateTimePicker2.Location = New System.Drawing.Point(996, 17)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(255, 21)
            Me.DateTimePicker2.TabIndex = 202
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(979, 20)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(17, 13)
            Me.Label19.TabIndex = 203
            Me.Label19.Text = "A:"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker1.Location = New System.Drawing.Point(696, 17)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(255, 21)
            Me.DateTimePicker1.TabIndex = 200
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox3.Enabled = False
            Me.TextBox3.Location = New System.Drawing.Point(396, 17)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(50, 21)
            Me.TextBox3.TabIndex = 28
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(370, 23)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(20, 13)
            Me.Label18.TabIndex = 8
            Me.Label18.Text = "ID:"
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMMM yyyy"
            Me.dtpMes.Enabled = False
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(508, 19)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(121, 21)
            Me.dtpMes.TabIndex = 198
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(667, 20)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(29, 13)
            Me.Label17.TabIndex = 201
            Me.Label17.Text = "DEL:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(474, 23)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(33, 13)
            Me.Label16.TabIndex = 199
            Me.Label16.Text = "MES:"
            '
            'Label24
            '
            Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label24.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(0, 89)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(559, 39)
            Me.Label24.TabIndex = 195
            Me.Label24.Text = "PERSONAL ASIGNADO A PUESTOS DE TRABAJO SEGÚN PROGRAMACIÓN"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel2
            '
            Me.Panel2.Location = New System.Drawing.Point(1021, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(242, 26)
            Me.Panel2.TabIndex = 216
            '
            'TabPage4
            '
            Me.TabPage4.Controls.Add(Me.TextBox1)
            Me.TabPage4.Controls.Add(Me.ListView3)
            Me.TabPage4.Controls.Add(Me.ListView1)
            Me.TabPage4.Controls.Add(Me.Label4)
            Me.TabPage4.Controls.Add(Me.Label2)
            Me.TabPage4.Controls.Add(Me.GroupBox1)
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Size = New System.Drawing.Size(1263, 645)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "REPORTES"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Location = New System.Drawing.Point(58, 60)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(167, 21)
            Me.TextBox1.TabIndex = 29
            '
            'ListView3
            '
            Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader5, Me.ColumnHeader6})
            Me.ListView3.FullRowSelect = True
            Me.ListView3.HideSelection = False
            Me.ListView3.Location = New System.Drawing.Point(557, 82)
            Me.ListView3.MultiSelect = False
            Me.ListView3.Name = "ListView3"
            Me.ListView3.Size = New System.Drawing.Size(705, 563)
            Me.ListView3.TabIndex = 207
            Me.ListView3.UseCompatibleStateImageBehavior = False
            Me.ListView3.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "IDS"
            Me.ColumnHeader11.Width = 0
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "FECHA"
            Me.ColumnHeader14.Width = 90
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "PUESTO"
            Me.ColumnHeader15.Width = 250
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "DETALLE"
            Me.ColumnHeader16.Width = 130
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "OBSERVACIONES"
            Me.ColumnHeader18.Width = 400
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "SITIO"
            Me.ColumnHeader5.Width = 200
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "CLIENTE"
            Me.ColumnHeader6.Width = 200
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(1, 82)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(550, 563)
            Me.ListView1.TabIndex = 205
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "IDP"
            Me.ColumnHeader25.Width = 50
            '
            'ColumnHeader27
            '
            Me.ColumnHeader27.Text = "CÉDULA"
            Me.ColumnHeader27.Width = 80
            '
            'ColumnHeader28
            '
            Me.ColumnHeader28.Text = "NÓMINA"
            Me.ColumnHeader28.Width = 310
            '
            'ColumnHeader29
            '
            Me.ColumnHeader29.Text = "DÍAS"
            Me.ColumnHeader29.Width = 50
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "INGRESA"
            Me.ColumnHeader1.Width = 0
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "SALE"
            Me.ColumnHeader2.Width = 0
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "LIBRES"
            Me.ColumnHeader3.Width = 50
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "EST"
            Me.ColumnHeader4.Width = 0
            '
            'Label4
            '
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label4.Location = New System.Drawing.Point(557, 58)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(705, 24)
            Me.Label4.TabIndex = 204
            Me.Label4.Text = "DETALLE DEL VIGILANTE SELECCIONADO"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Location = New System.Drawing.Point(3, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(572, 24)
            Me.Label2.TabIndex = 203
            Me.Label2.Text = "BUSCAR:                                                            ASISTENCIA POR" &
    " PUESTO, VIGILANTE  Y DÍAS TRABAJADOS"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Button10)
            Me.GroupBox1.Controls.Add(Me.Button7)
            Me.GroupBox1.Controls.Add(Me.Button6)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker6)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker7)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1257, 52)
            Me.GroupBox1.TabIndex = 202
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "REPORTE DE ASISTENCIA, POR PUESTO Y DÍAS TRABAJADOS:"
            '
            'Button10
            '
            Me.Button10.BackColor = System.Drawing.Color.White
            Me.Button10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button10.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button10.Location = New System.Drawing.Point(1130, 12)
            Me.Button10.Name = "Button10"
            Me.Button10.Size = New System.Drawing.Size(92, 35)
            Me.Button10.TabIndex = 211
            Me.Button10.Text = "DETALLES"
            Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button10.UseVisualStyleBackColor = False
            '
            'Button7
            '
            Me.Button7.BackColor = System.Drawing.Color.White
            Me.Button7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button7.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button7.Location = New System.Drawing.Point(1022, 13)
            Me.Button7.Name = "Button7"
            Me.Button7.Size = New System.Drawing.Size(92, 35)
            Me.Button7.TabIndex = 209
            Me.Button7.Text = "PUESTOS"
            Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button7.UseVisualStyleBackColor = False
            '
            'Button6
            '
            Me.Button6.BackColor = System.Drawing.Color.White
            Me.Button6.FlatAppearance.BorderSize = 0
            Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button6.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button6.Location = New System.Drawing.Point(605, 13)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(28, 28)
            Me.Button6.TabIndex = 208
            Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.Button6.UseVisualStyleBackColor = False
            '
            'DateTimePicker6
            '
            Me.DateTimePicker6.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker6.Location = New System.Drawing.Point(339, 19)
            Me.DateTimePicker6.Name = "DateTimePicker6"
            Me.DateTimePicker6.Size = New System.Drawing.Size(255, 21)
            Me.DateTimePicker6.TabIndex = 202
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(313, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(23, 13)
            Me.Label3.TabIndex = 203
            Me.Label3.Text = "AL:"
            '
            'DateTimePicker7
            '
            Me.DateTimePicker7.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker7.Location = New System.Drawing.Point(39, 19)
            Me.DateTimePicker7.Name = "DateTimePicker7"
            Me.DateTimePicker7.Size = New System.Drawing.Size(255, 21)
            Me.DateTimePicker7.TabIndex = 200
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(10, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(29, 13)
            Me.Label5.TabIndex = 201
            Me.Label5.Text = "DEL:"
            '
            'ToolTip1
            '
            Me.ToolTip1.AutoPopDelay = 5000
            Me.ToolTip1.InitialDelay = 1000
            Me.ToolTip1.ReshowDelay = 300
            Me.ToolTip1.ShowAlways = True
            '
            'FrmReporteAsistencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1274, 673)
            Me.Controls.Add(Me.tcSitios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmReporteAsistencia"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.Text = "REPORTE ASISTENCIA"
            Me.tcSitios.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.MenuStrip3.ResumeLayout(False)
            Me.MenuStrip3.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.MenuStrip2.ResumeLayout(False)
            Me.MenuStrip2.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgvDia, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage3.ResumeLayout(False)
            CType(Me.dgvNoche, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage5.ResumeLayout(False)
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage4.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcSitios As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents dgvDia As System.Windows.Forms.DataGridView
        Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents dgvNoche As System.Windows.Forms.DataGridView
        Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker7 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Button6 As System.Windows.Forms.Button
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents Button7 As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ListView3 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Button10 As System.Windows.Forms.Button
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents NOVEDADESACBMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTESDERADIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents EXPORTARDATOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GUARDARCAMBIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCambiar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnQuitar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAddRad As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents RIVER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column31 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HORARIO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents RIVER2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents HORARIO2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace