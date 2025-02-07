Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBalanceComprobacion
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBalanceComprobacion))
            Me.dgvMayores = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.tvBalanceComprobacion = New System.Windows.Forms.TreeView()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.DsBalanceComprobacion = New syscisepro.dsBalanceComprobacion()
            Me.DsBalanceComprobacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnArbol = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.LbCount1 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            CType(Me.DsBalanceComprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DsBalanceComprobacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvMayores
            '
            Me.dgvMayores.AllowUserToAddRows = False
            Me.dgvMayores.AllowUserToDeleteRows = False
            Me.dgvMayores.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvMayores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMayores.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayores.Location = New System.Drawing.Point(12, 33)
            Me.dgvMayores.MultiSelect = False
            Me.dgvMayores.Name = "dgvMayores"
            Me.dgvMayores.ReadOnly = True
            Me.dgvMayores.RowHeadersVisible = False
            Me.dgvMayores.RowHeadersWidth = 26
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvMayores.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMayores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayores.Size = New System.Drawing.Size(808, 490)
            Me.dgvMayores.TabIndex = 225
            '
            'nodo
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.nodo.DefaultCellStyle = DataGridViewCellStyle3
            Me.nodo.HeaderText = "+"
            Me.nodo.Name = "nodo"
            Me.nodo.ReadOnly = True
            Me.nodo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.nodo.Width = 50
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(291, 7)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(109, 21)
            Me.dtpFinal.TabIndex = 210
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(89, 6)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(109, 21)
            Me.dtpInicio.TabIndex = 209
            '
            'tvBalanceComprobacion
            '
            Me.tvBalanceComprobacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tvBalanceComprobacion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tvBalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvBalanceComprobacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tvBalanceComprobacion.Location = New System.Drawing.Point(0, 0)
            Me.tvBalanceComprobacion.Name = "tvBalanceComprobacion"
            Me.tvBalanceComprobacion.Size = New System.Drawing.Size(831, 536)
            Me.tvBalanceComprobacion.TabIndex = 0
            '
            'ContextMenuStripClicDerecho
            '
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
            'DsBalanceComprobacion
            '
            Me.DsBalanceComprobacion.DataSetName = "dsBalanceComprobacion"
            Me.DsBalanceComprobacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'DsBalanceComprobacionBindingSource
            '
            Me.DsBalanceComprobacionBindingSource.DataSource = Me.DsBalanceComprobacion
            Me.DsBalanceComprobacionBindingSource.Position = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar, Me.btnArbol})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(833, 32)
            Me.MenuStrip1.TabIndex = 289
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(89, 28)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnExportar
            '
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(98, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnArbol
            '
            Me.btnArbol.Image = Global.syscisepro.My.Resources.Resources.account_tree_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnArbol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnArbol.Name = "btnArbol"
            Me.btnArbol.Size = New System.Drawing.Size(80, 28)
            Me.btnArbol.Text = "ÁRBOL"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(833, 565)
            Me.KryptonNavigator1.TabIndex = 290
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.chkTodos)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel3)
            Me.KryptonPage1.Controls.Add(Me.cbNivel)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel2)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel1)
            Me.KryptonPage1.Controls.Add(Me.dtpInicio)
            Me.KryptonPage1.Controls.Add(Me.dtpFinal)
            Me.KryptonPage1.Controls.Add(Me.dgvMayores)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(831, 536)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Mayores"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "EDB288AEF00F4D54D3AB7EA2044E8C99"
            '
            'chkTodos
            '
            Me.chkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkTodos.Location = New System.Drawing.Point(682, 5)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(94, 22)
            Me.chkTodos.TabIndex = 235
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = False
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(472, 6)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel3.TabIndex = 226
            Me.KryptonLabel3.Values.Text = "Niveles"
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5"})
            Me.cbNivel.Location = New System.Drawing.Point(540, 5)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 234
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(234, 7)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 210
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(11, 7)
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
            Me.KryptonPage2.Size = New System.Drawing.Size(831, 536)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Arbol"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "ACC3698D1399493773BA188A41E46459"
            '
            'LbCount1
            '
            Me.LbCount1.AutoSize = True
            Me.LbCount1.BackColor = System.Drawing.Color.Transparent
            Me.LbCount1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LbCount1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.LbCount1.Location = New System.Drawing.Point(57, 605)
            Me.LbCount1.Name = "LbCount1"
            Me.LbCount1.Size = New System.Drawing.Size(0, 13)
            Me.LbCount1.TabIndex = 283
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(580, 608)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(62, 13)
            Me.Label9.TabIndex = 294
            Me.Label9.Text = "ACREEDOR"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(365, 608)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(49, 13)
            Me.Label8.TabIndex = 293
            Me.Label8.Text = "DEUDOR"
            '
            'txtAcreedor
            '
            Me.txtAcreedor.BackColor = System.Drawing.Color.White
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(645, 605)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(98, 21)
            Me.txtAcreedor.TabIndex = 292
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudor
            '
            Me.txtDeudor.BackColor = System.Drawing.Color.White
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(417, 605)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(98, 21)
            Me.txtDeudor.TabIndex = 291
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'FormBalanceComprobacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(833, 637)
            Me.Controls.Add(Me.LbCount1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.txtAcreedor)
            Me.Controls.Add(Me.txtDeudor)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBalanceComprobacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BALANCE DE COMPROBACIÓN"
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            CType(Me.DsBalanceComprobacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DsBalanceComprobacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvMayores As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tvBalanceComprobacion As System.Windows.Forms.TreeView
        Friend WithEvents DsBalanceComprobacion As syscisepro.dsBalanceComprobacion
        Friend WithEvents DsBalanceComprobacionBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnArbol As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents chkTodos As CheckBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents cbNivel As ComboBox
        Friend WithEvents LbCount1 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents txtAcreedor As TextBox
        Friend WithEvents txtDeudor As TextBox
    End Class
End Namespace