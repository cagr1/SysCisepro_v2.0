Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBalanceFinal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBalanceFinal))
            Me.tcAuxiliares = New System.Windows.Forms.TabControl()
            Me.tpActualizar = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.dgvMayores = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.LbCount1 = New System.Windows.Forms.Label()
            Me.txtUtilidad = New System.Windows.Forms.TextBox()
            Me.lblUtilidadPerdida = New System.Windows.Forms.Label()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCapital = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.tpArbol = New System.Windows.Forms.TabPage()
            Me.tvBalanceComprobacion = New System.Windows.Forms.TreeView()
            Me.ContextMenuStripClicDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOcultar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmMostrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnArbol = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcAuxiliares.SuspendLayout()
            Me.tpActualizar.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.tpArbol.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAuxiliares
            '
            Me.tcAuxiliares.Controls.Add(Me.tpActualizar)
            Me.tcAuxiliares.Controls.Add(Me.tpArbol)
            Me.tcAuxiliares.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAuxiliares.Location = New System.Drawing.Point(-5, 36)
            Me.tcAuxiliares.Name = "tcAuxiliares"
            Me.tcAuxiliares.SelectedIndex = 0
            Me.tcAuxiliares.Size = New System.Drawing.Size(927, 633)
            Me.tcAuxiliares.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tcAuxiliares.TabIndex = 2
            '
            'tpActualizar
            '
            Me.tpActualizar.BackColor = System.Drawing.Color.White
            Me.tpActualizar.Controls.Add(Me.GroupBox1)
            Me.tpActualizar.Controls.Add(Me.dtpFinal)
            Me.tpActualizar.Controls.Add(Me.dtpInicio)
            Me.tpActualizar.Controls.Add(Me.lblDesde)
            Me.tpActualizar.Controls.Add(Me.lblHasta)
            Me.tpActualizar.Controls.Add(Me.dgvMayores)
            Me.tpActualizar.Controls.Add(Me.GroupBox2)
            Me.tpActualizar.Location = New System.Drawing.Point(4, 22)
            Me.tpActualizar.Name = "tpActualizar"
            Me.tpActualizar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpActualizar.Size = New System.Drawing.Size(919, 607)
            Me.tpActualizar.TabIndex = 0
            Me.tpActualizar.Text = "MAYORES"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkTodos)
            Me.GroupBox1.Controls.Add(Me.cbNivel)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(335, -4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(377, 43)
            Me.GroupBox1.TabIndex = 258
            Me.GroupBox1.TabStop = False
            '
            'chkTodos
            '
            Me.chkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkTodos.Location = New System.Drawing.Point(278, 13)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(94, 22)
            Me.chkTodos.TabIndex = 235
            Me.chkTodos.Text = "Quitar $0.0"
            Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'cbNivel
            '
            Me.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbNivel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5"})
            Me.cbNivel.Location = New System.Drawing.Point(119, 13)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 234
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(10, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(96, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Niveles a mostrar"
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(210, 8)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(110, 21)
            Me.dtpFinal.TabIndex = 255
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(47, 8)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(103, 21)
            Me.dtpInicio.TabIndex = 254
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesde.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblDesde.Location = New System.Drawing.Point(6, 14)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(41, 13)
            Me.lblDesde.TabIndex = 256
            Me.lblDesde.Text = "Desde:"
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblHasta.Location = New System.Drawing.Point(167, 12)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(40, 13)
            Me.lblHasta.TabIndex = 257
            Me.lblHasta.Text = "Hasta:"
            '
            'dgvMayores
            '
            Me.dgvMayores.AllowUserToAddRows = False
            Me.dgvMayores.AllowUserToDeleteRows = False
            Me.dgvMayores.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayores.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodo})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMayores.Location = New System.Drawing.Point(0, 45)
            Me.dgvMayores.Name = "dgvMayores"
            Me.dgvMayores.RowHeadersVisible = False
            Me.dgvMayores.RowHeadersWidth = 26
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayores.Size = New System.Drawing.Size(916, 513)
            Me.dgvMayores.TabIndex = 225
            '
            'nodo
            '
            Me.nodo.HeaderText = "+"
            Me.nodo.Name = "nodo"
            Me.nodo.Width = 25
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.LbCount1)
            Me.GroupBox2.Controls.Add(Me.txtUtilidad)
            Me.GroupBox2.Controls.Add(Me.lblUtilidadPerdida)
            Me.GroupBox2.Controls.Add(Me.txtDeudor)
            Me.GroupBox2.Controls.Add(Me.txtAcreedor)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtCapital)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(0, 558)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(916, 46)
            Me.GroupBox2.TabIndex = 253
            Me.GroupBox2.TabStop = False
            '
            'LbCount1
            '
            Me.LbCount1.AutoSize = True
            Me.LbCount1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LbCount1.Location = New System.Drawing.Point(3, 9)
            Me.LbCount1.Name = "LbCount1"
            Me.LbCount1.Size = New System.Drawing.Size(0, 13)
            Me.LbCount1.TabIndex = 282
            '
            'txtUtilidad
            '
            Me.txtUtilidad.BackColor = System.Drawing.Color.White
            Me.txtUtilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUtilidad.Location = New System.Drawing.Point(793, 16)
            Me.txtUtilidad.Name = "txtUtilidad"
            Me.txtUtilidad.ReadOnly = True
            Me.txtUtilidad.Size = New System.Drawing.Size(113, 21)
            Me.txtUtilidad.TabIndex = 250
            Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblUtilidadPerdida
            '
            Me.lblUtilidadPerdida.AutoSize = True
            Me.lblUtilidadPerdida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUtilidadPerdida.Location = New System.Drawing.Point(732, 21)
            Me.lblUtilidadPerdida.Name = "lblUtilidadPerdida"
            Me.lblUtilidadPerdida.Size = New System.Drawing.Size(54, 13)
            Me.lblUtilidadPerdida.TabIndex = 251
            Me.lblUtilidadPerdida.Text = "UTILIDAD"
            '
            'txtDeudor
            '
            Me.txtDeudor.BackColor = System.Drawing.Color.White
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudor.Location = New System.Drawing.Point(139, 16)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(113, 21)
            Me.txtDeudor.TabIndex = 241
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedor
            '
            Me.txtAcreedor.BackColor = System.Drawing.Color.White
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedor.Location = New System.Drawing.Point(328, 16)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(113, 21)
            Me.txtAcreedor.TabIndex = 242
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(487, 20)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(105, 13)
            Me.Label10.TabIndex = 249
            Me.Label10.Text = "PATRIMONIO NETO"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(87, 21)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(46, 13)
            Me.Label8.TabIndex = 243
            Me.Label8.Text = "ACTIVO"
            '
            'txtCapital
            '
            Me.txtCapital.BackColor = System.Drawing.Color.White
            Me.txtCapital.Enabled = False
            Me.txtCapital.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCapital.Location = New System.Drawing.Point(596, 15)
            Me.txtCapital.Name = "txtCapital"
            Me.txtCapital.Size = New System.Drawing.Size(113, 21)
            Me.txtCapital.TabIndex = 248
            Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(278, 21)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 244
            Me.Label9.Text = "PASIVO"
            '
            'tpArbol
            '
            Me.tpArbol.BackColor = System.Drawing.Color.White
            Me.tpArbol.Controls.Add(Me.tvBalanceComprobacion)
            Me.tpArbol.Location = New System.Drawing.Point(4, 22)
            Me.tpArbol.Name = "tpArbol"
            Me.tpArbol.Padding = New System.Windows.Forms.Padding(3)
            Me.tpArbol.Size = New System.Drawing.Size(919, 607)
            Me.tpArbol.TabIndex = 1
            Me.tpArbol.Text = "ARBOL"
            '
            'tvBalanceComprobacion
            '
            Me.tvBalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvBalanceComprobacion.Location = New System.Drawing.Point(3, 3)
            Me.tvBalanceComprobacion.Name = "tvBalanceComprobacion"
            Me.tvBalanceComprobacion.Size = New System.Drawing.Size(913, 601)
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
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar, Me.btnArbol})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(922, 32)
            Me.MenuStrip1.TabIndex = 290
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
            'FormBalanceFinal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(922, 663)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAuxiliares)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBalanceFinal"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BALANCE FINAL"
            Me.tcAuxiliares.ResumeLayout(False)
            Me.tpActualizar.ResumeLayout(False)
            Me.tpActualizar.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.tpArbol.ResumeLayout(False)
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAuxiliares As System.Windows.Forms.TabControl
        Friend WithEvents tpActualizar As System.Windows.Forms.TabPage
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayores As System.Windows.Forms.DataGridView
        Friend WithEvents tpArbol As System.Windows.Forms.TabPage
        Friend WithEvents tvBalanceComprobacion As System.Windows.Forms.TreeView
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtCapital As System.Windows.Forms.TextBox
        Friend WithEvents lblUtilidadPerdida As System.Windows.Forms.Label
        Friend WithEvents txtUtilidad As System.Windows.Forms.TextBox
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents LbCount1 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnArbol As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents lblHasta As System.Windows.Forms.Label
    End Class
End Namespace