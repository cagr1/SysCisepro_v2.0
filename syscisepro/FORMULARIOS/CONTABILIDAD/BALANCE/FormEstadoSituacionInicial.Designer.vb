Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEstadoSituacionInicial
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstadoSituacionInicial))
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtCapital = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.dgvMayores = New System.Windows.Forms.DataGridView()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.tvBalanceComprobacion = New System.Windows.Forms.TreeView()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnArbol = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.LbCount1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtUtilidad = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chkTodos
            '
            Me.chkTodos.BackColor = System.Drawing.Color.Transparent
            Me.chkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.chkTodos.Location = New System.Drawing.Point(537, 6)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(106, 18)
            Me.chkTodos.TabIndex = 234
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = False
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5"})
            Me.cbNivel.Location = New System.Drawing.Point(437, 6)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(77, 21)
            Me.cbNivel.TabIndex = 233
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(754, 541)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(54, 13)
            Me.Label11.TabIndex = 251
            Me.Label11.Text = "UTILIDAD"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(520, 541)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(105, 13)
            Me.Label10.TabIndex = 249
            Me.Label10.Text = "PATRIMONIO NETO"
            '
            'txtCapital
            '
            Me.txtCapital.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCapital.Location = New System.Drawing.Point(642, 535)
            Me.txtCapital.Name = "txtCapital"
            Me.txtCapital.Size = New System.Drawing.Size(106, 21)
            Me.txtCapital.TabIndex = 248
            Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(347, 541)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 244
            Me.Label9.Text = "PASIVO"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(188, 541)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(46, 13)
            Me.Label8.TabIndex = 243
            Me.Label8.Text = "ACTIVO"
            '
            'txtAcreedor
            '
            Me.txtAcreedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(406, 538)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(106, 21)
            Me.txtAcreedor.TabIndex = 242
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudor
            '
            Me.txtDeudor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(235, 538)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(106, 21)
            Me.txtDeudor.TabIndex = 241
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvMayores
            '
            Me.dgvMayores.AllowUserToAddRows = False
            Me.dgvMayores.AllowUserToDeleteRows = False
            Me.dgvMayores.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMayores.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMayores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMayores.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMayores.Location = New System.Drawing.Point(3, 47)
            Me.dgvMayores.MultiSelect = False
            Me.dgvMayores.Name = "dgvMayores"
            Me.dgvMayores.ReadOnly = True
            Me.dgvMayores.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayores.Size = New System.Drawing.Size(964, 471)
            Me.dgvMayores.TabIndex = 225
            '
            'dtpFinal
            '
            Me.dtpFinal.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(240, 7)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(121, 21)
            Me.dtpFinal.TabIndex = 210
            '
            'dtpInicio
            '
            Me.dtpInicio.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(63, 5)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(114, 21)
            Me.dtpInicio.TabIndex = 209
            '
            'tvBalanceComprobacion
            '
            Me.tvBalanceComprobacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tvBalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvBalanceComprobacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tvBalanceComprobacion.Location = New System.Drawing.Point(0, 0)
            Me.tvBalanceComprobacion.Name = "tvBalanceComprobacion"
            Me.tvBalanceComprobacion.Size = New System.Drawing.Size(969, 568)
            Me.tvBalanceComprobacion.TabIndex = 0
            '
            'ContextMenuStripClicDerecho
            '
            Me.ContextMenuStripClicDerecho.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ContextMenuStripClicDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOcultar, Me.tsmMostrar})
            Me.ContextMenuStripClicDerecho.Name = "ContextMenuStripClicDerecho"
            Me.ContextMenuStripClicDerecho.Size = New System.Drawing.Size(129, 48)
            '
            'tsmOcultar
            '
            Me.tsmOcultar.Name = "tsmOcultar"
            Me.tsmOcultar.Size = New System.Drawing.Size(128, 22)
            Me.tsmOcultar.Text = "OCULTAR"
            '
            'tsmMostrar
            '
            Me.tsmMostrar.Name = "tsmMostrar"
            Me.tsmMostrar.Size = New System.Drawing.Size(128, 22)
            Me.tsmMostrar.Text = "MOSTRAR"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar, Me.btnArbol, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(970, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(89, 28)
            Me.btnCargar.Text = "CARGAR"
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
            'btnArbol
            '
            Me.btnArbol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnArbol.Image = Global.syscisepro.My.Resources.Resources.account_tree_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnArbol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnArbol.Name = "btnArbol"
            Me.btnArbol.Size = New System.Drawing.Size(80, 28)
            Me.btnArbol.Text = "ÁRBOL"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(97, 28)
            Me.btnReporte.Text = "GUARDAR"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Location = New System.Drawing.Point(-1, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(971, 595)
            Me.KryptonNavigator1.TabIndex = 190
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.LbCount1)
            Me.KryptonPage1.Controls.Add(Me.txtUtilidad)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.Label11)
            Me.KryptonPage1.Controls.Add(Me.dgvMayores)
            Me.KryptonPage1.Controls.Add(Me.Label8)
            Me.KryptonPage1.Controls.Add(Me.txtCapital)
            Me.KryptonPage1.Controls.Add(Me.Label10)
            Me.KryptonPage1.Controls.Add(Me.txtDeudor)
            Me.KryptonPage1.Controls.Add(Me.txtAcreedor)
            Me.KryptonPage1.Controls.Add(Me.Label9)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(969, 568)
            Me.KryptonPage1.Text = "Mayores"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "C49FDDEC18C64C0F54A894FBDA637496"
            '
            'LbCount1
            '
            Me.LbCount1.Location = New System.Drawing.Point(17, 534)
            Me.LbCount1.Name = "LbCount1"
            Me.LbCount1.Size = New System.Drawing.Size(6, 2)
            Me.LbCount1.TabIndex = 253
            Me.LbCount1.Values.Text = ""
            '
            'txtUtilidad
            '
            Me.txtUtilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUtilidad.Location = New System.Drawing.Point(829, 535)
            Me.txtUtilidad.Name = "txtUtilidad"
            Me.txtUtilidad.Size = New System.Drawing.Size(106, 21)
            Me.txtUtilidad.TabIndex = 252
            Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 6)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbNivel)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpInicio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFinal)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(720, 36)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(381, 5)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 211
            Me.KryptonLabel3.Values.Text = "Niveles"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(193, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 210
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(12, 5)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.tvBalanceComprobacion)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(969, 568)
            Me.KryptonPage2.Text = "Arbol"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "6ABB3521295944E21284B582EF59D8C9"
            '
            'FormEstadoSituacionInicial
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(970, 625)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormEstadoSituacionInicial"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTADO DE SITUACION INICIAL"
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtCapital As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayores As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents tvBalanceComprobacion As System.Windows.Forms.TreeView
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnArbol As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtUtilidad As TextBox
        Friend WithEvents LbCount1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace