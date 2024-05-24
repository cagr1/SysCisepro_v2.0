Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBalanceComprobacion
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBalanceComprobacion))
            Me.tcAuxiliares = New System.Windows.Forms.TabControl()
            Me.tpActualizar = New System.Windows.Forms.TabPage()
            Me.LbCount1 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.cbNivel = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtAcreedor = New System.Windows.Forms.TextBox()
            Me.txtDeudor = New System.Windows.Forms.TextBox()
            Me.dgvMayores = New System.Windows.Forms.DataGridView()
            Me.nodo = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.tpArbol = New System.Windows.Forms.TabPage()
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
            Me.tcAuxiliares.SuspendLayout()
            Me.tpActualizar.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpArbol.SuspendLayout()
            Me.ContextMenuStripClicDerecho.SuspendLayout()
            CType(Me.DsBalanceComprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DsBalanceComprobacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAuxiliares
            '
            Me.tcAuxiliares.Controls.Add(Me.tpActualizar)
            Me.tcAuxiliares.Controls.Add(Me.tpArbol)
            Me.tcAuxiliares.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAuxiliares.Location = New System.Drawing.Point(0, 24)
            Me.tcAuxiliares.Name = "tcAuxiliares"
            Me.tcAuxiliares.SelectedIndex = 0
            Me.tcAuxiliares.Size = New System.Drawing.Size(1008, 706)
            Me.tcAuxiliares.TabIndex = 1
            '
            'tpActualizar
            '
            Me.tpActualizar.BackColor = System.Drawing.Color.White
            Me.tpActualizar.Controls.Add(Me.LbCount1)
            Me.tpActualizar.Controls.Add(Me.GroupBox1)
            Me.tpActualizar.Controls.Add(Me.Label9)
            Me.tpActualizar.Controls.Add(Me.Label8)
            Me.tpActualizar.Controls.Add(Me.txtAcreedor)
            Me.tpActualizar.Controls.Add(Me.txtDeudor)
            Me.tpActualizar.Controls.Add(Me.dgvMayores)
            Me.tpActualizar.Controls.Add(Me.dtpFinal)
            Me.tpActualizar.Controls.Add(Me.dtpInicio)
            Me.tpActualizar.Controls.Add(Me.lblDesde)
            Me.tpActualizar.Controls.Add(Me.lblHasta)
            Me.tpActualizar.Location = New System.Drawing.Point(4, 22)
            Me.tpActualizar.Name = "tpActualizar"
            Me.tpActualizar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpActualizar.Size = New System.Drawing.Size(1000, 680)
            Me.tpActualizar.TabIndex = 0
            Me.tpActualizar.Text = "MAYORES"
            '
            'LbCount1
            '
            Me.LbCount1.AutoSize = True
            Me.LbCount1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LbCount1.Location = New System.Drawing.Point(5, 663)
            Me.LbCount1.Name = "LbCount1"
            Me.LbCount1.Size = New System.Drawing.Size(0, 13)
            Me.LbCount1.TabIndex = 283
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.chkTodos)
            Me.GroupBox1.Controls.Add(Me.cbNivel)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(620, -6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(377, 43)
            Me.GroupBox1.TabIndex = 248
            Me.GroupBox1.TabStop = False
            '
            'chkTodos
            '
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
            Me.cbNivel.FormattingEnabled = True
            Me.cbNivel.Items.AddRange(New Object() {" -- TODOS --", "1", "2", "3", "4", "5"})
            Me.cbNivel.Location = New System.Drawing.Point(119, 13)
            Me.cbNivel.Name = "cbNivel"
            Me.cbNivel.Size = New System.Drawing.Size(121, 21)
            Me.cbNivel.TabIndex = 234
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(10, 16)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(109, 13)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Niveles a mostrar"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label9.Location = New System.Drawing.Point(833, 657)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(55, 13)
            Me.Label9.TabIndex = 244
            Me.Label9.Text = "ACREEDOR"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label8.Location = New System.Drawing.Point(617, 657)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(43, 13)
            Me.Label8.TabIndex = 243
            Me.Label8.Text = "DEUDOR"
            '
            'txtAcreedor
            '
            Me.txtAcreedor.BackColor = System.Drawing.Color.White
            Me.txtAcreedor.Enabled = False
            Me.txtAcreedor.Location = New System.Drawing.Point(894, 654)
            Me.txtAcreedor.Name = "txtAcreedor"
            Me.txtAcreedor.Size = New System.Drawing.Size(98, 20)
            Me.txtAcreedor.TabIndex = 242
            Me.txtAcreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudor
            '
            Me.txtDeudor.BackColor = System.Drawing.Color.White
            Me.txtDeudor.Enabled = False
            Me.txtDeudor.Location = New System.Drawing.Point(666, 654)
            Me.txtDeudor.Name = "txtDeudor"
            Me.txtDeudor.Size = New System.Drawing.Size(98, 20)
            Me.txtDeudor.TabIndex = 241
            Me.txtDeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayores.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayores.Location = New System.Drawing.Point(0, 38)
            Me.dgvMayores.MultiSelect = False
            Me.dgvMayores.Name = "dgvMayores"
            Me.dgvMayores.ReadOnly = True
            Me.dgvMayores.RowHeadersVisible = False
            Me.dgvMayores.RowHeadersWidth = 26
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayores.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMayores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayores.Size = New System.Drawing.Size(1000, 610)
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
            Me.dtpFinal.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.dtpFinal.Location = New System.Drawing.Point(367, 6)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(247, 20)
            Me.dtpFinal.TabIndex = 210
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.dtpInicio.Location = New System.Drawing.Point(45, 6)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(247, 20)
            Me.dtpInicio.TabIndex = 209
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblDesde.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblDesde.Location = New System.Drawing.Point(3, 8)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(43, 13)
            Me.lblDesde.TabIndex = 211
            Me.lblDesde.Text = "Desde:"
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblHasta.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblHasta.Location = New System.Drawing.Point(325, 10)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(43, 13)
            Me.lblHasta.TabIndex = 212
            Me.lblHasta.Text = "Hasta:"
            '
            'tpArbol
            '
            Me.tpArbol.Controls.Add(Me.tvBalanceComprobacion)
            Me.tpArbol.Location = New System.Drawing.Point(4, 22)
            Me.tpArbol.Name = "tpArbol"
            Me.tpArbol.Padding = New System.Windows.Forms.Padding(3)
            Me.tpArbol.Size = New System.Drawing.Size(1000, 680)
            Me.tpArbol.TabIndex = 1
            Me.tpArbol.Text = "ARBOL"
            Me.tpArbol.UseVisualStyleBackColor = True
            '
            'tvBalanceComprobacion
            '
            Me.tvBalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvBalanceComprobacion.Location = New System.Drawing.Point(3, 3)
            Me.tvBalanceComprobacion.Name = "tvBalanceComprobacion"
            Me.tvBalanceComprobacion.Size = New System.Drawing.Size(994, 674)
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
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar, Me.btnArbol})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
            Me.MenuStrip1.TabIndex = 289
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(81, 20)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnExportar
            '
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(90, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'btnArbol
            '
            Me.btnArbol.Image = Global.syscisepro.My.Resources.Resources.chart_organisation_add
            Me.btnArbol.Name = "btnArbol"
            Me.btnArbol.Size = New System.Drawing.Size(72, 20)
            Me.btnArbol.Text = "ÁRBOL"
            '
            'FormBalanceComprobacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1008, 730)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAuxiliares)
            Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormBalanceComprobacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BALANCE DE COMPROBACIÓN"
            Me.tcAuxiliares.ResumeLayout(False)
            Me.tpActualizar.ResumeLayout(False)
            Me.tpActualizar.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvMayores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpArbol.ResumeLayout(False)
            Me.ContextMenuStripClicDerecho.ResumeLayout(False)
            CType(Me.DsBalanceComprobacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DsBalanceComprobacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAuxiliares As System.Windows.Forms.TabControl
        Friend WithEvents tpActualizar As System.Windows.Forms.TabPage
        Friend WithEvents txtAcreedor As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudor As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayores As System.Windows.Forms.DataGridView
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ContextMenuStripClicDerecho As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmOcultar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmMostrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tpArbol As System.Windows.Forms.TabPage
        Friend WithEvents tvBalanceComprobacion As System.Windows.Forms.TreeView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents DsBalanceComprobacion As syscisepro.dsBalanceComprobacion
        Friend WithEvents DsBalanceComprobacionBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents nodo As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents LbCount1 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnArbol As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace