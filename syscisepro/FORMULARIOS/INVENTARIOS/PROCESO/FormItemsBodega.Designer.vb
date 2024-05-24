Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormItemsBodega
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItemsBodega))
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbSubGrupo = New System.Windows.Forms.GroupBox()
            Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoSubGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSubGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarSubGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportarSubGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtCodigoGrupo = New System.Windows.Forms.TextBox()
            Me.txtCodigoSubGrupo = New System.Windows.Forms.TextBox()
            Me.lblCódigoSubGrupo = New System.Windows.Forms.Label()
            Me.cbmGrupo = New System.Windows.Forms.ComboBox()
            Me.dgvSubGrupoItem = New System.Windows.Forms.DataGridView()
            Me.lblGrupo = New System.Windows.Forms.Label()
            Me.txtIdSubGrupo = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNombreSubGrupo = New System.Windows.Forms.TextBox()
            Me.lblNombreSubGrupo = New System.Windows.Forms.Label()
            Me.gbGrupo = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportarGrupos = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtCodigoCategoría = New System.Windows.Forms.TextBox()
            Me.txtCódigoGrupo = New System.Windows.Forms.TextBox()
            Me.lblCódigoGrupo = New System.Windows.Forms.Label()
            Me.cbmCategoría = New System.Windows.Forms.ComboBox()
            Me.lblCategoría = New System.Windows.Forms.Label()
            Me.txtIdGrupo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
            Me.lblNombreGrupo = New System.Windows.Forms.Label()
            Me.dgvGrupoItem = New System.Windows.Forms.DataGridView()
            Me.gbCategoria = New System.Windows.Forms.GroupBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtIdCategoría = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombreCategoría = New System.Windows.Forms.TextBox()
            Me.lblNombreCategoría = New System.Windows.Forms.Label()
            Me.dgvCategoriaItem = New System.Windows.Forms.DataGridView()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.gbSubGrupo.SuspendLayout()
            Me.MenuStrip2.SuspendLayout()
            CType(Me.dgvSubGrupoItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbGrupo.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvGrupoItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCategoria.SuspendLayout()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbSubGrupo
            '
            Me.gbSubGrupo.Controls.Add(Me.MenuStrip2)
            Me.gbSubGrupo.Controls.Add(Me.txtCodigoGrupo)
            Me.gbSubGrupo.Controls.Add(Me.txtCodigoSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.lblCódigoSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.cbmGrupo)
            Me.gbSubGrupo.Controls.Add(Me.dgvSubGrupoItem)
            Me.gbSubGrupo.Controls.Add(Me.lblGrupo)
            Me.gbSubGrupo.Controls.Add(Me.txtIdSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.Label5)
            Me.gbSubGrupo.Controls.Add(Me.txtNombreSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.lblNombreSubGrupo)
            Me.gbSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.gbSubGrupo.Location = New System.Drawing.Point(403, 311)
            Me.gbSubGrupo.Name = "gbSubGrupo"
            Me.gbSubGrupo.Size = New System.Drawing.Size(564, 336)
            Me.gbSubGrupo.TabIndex = 1
            Me.gbSubGrupo.TabStop = False
            Me.gbSubGrupo.Text = "SUB GRUPO"
            '
            'MenuStrip2
            '
            Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoSubGrupo, Me.btnGuardarSubGrupo, Me.btnCancelarSubGrupo, Me.btnExportarSubGrupo})
            Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip2.Location = New System.Drawing.Point(3, 18)
            Me.MenuStrip2.Name = "MenuStrip2"
            Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip2.Size = New System.Drawing.Size(558, 24)
            Me.MenuStrip2.TabIndex = 182
            Me.MenuStrip2.Text = "msIngresoBodega"
            '
            'btnNuevoSubGrupo
            '
            Me.btnNuevoSubGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSubGrupo.Image = CType(resources.GetObject("btnNuevoSubGrupo.Image"), System.Drawing.Image)
            Me.btnNuevoSubGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoSubGrupo.Name = "btnNuevoSubGrupo"
            Me.btnNuevoSubGrupo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevoSubGrupo.Text = "NUEVO"
            '
            'btnGuardarSubGrupo
            '
            Me.btnGuardarSubGrupo.Enabled = False
            Me.btnGuardarSubGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSubGrupo.Image = CType(resources.GetObject("btnGuardarSubGrupo.Image"), System.Drawing.Image)
            Me.btnGuardarSubGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSubGrupo.Name = "btnGuardarSubGrupo"
            Me.btnGuardarSubGrupo.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardarSubGrupo.Text = "GUARDAR"
            '
            'btnCancelarSubGrupo
            '
            Me.btnCancelarSubGrupo.Enabled = False
            Me.btnCancelarSubGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSubGrupo.Image = CType(resources.GetObject("btnCancelarSubGrupo.Image"), System.Drawing.Image)
            Me.btnCancelarSubGrupo.Name = "btnCancelarSubGrupo"
            Me.btnCancelarSubGrupo.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarSubGrupo.Text = "CANCELAR"
            '
            'btnExportarSubGrupo
            '
            Me.btnExportarSubGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarSubGrupo.Image = CType(resources.GetObject("btnExportarSubGrupo.Image"), System.Drawing.Image)
            Me.btnExportarSubGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarSubGrupo.Name = "btnExportarSubGrupo"
            Me.btnExportarSubGrupo.Size = New System.Drawing.Size(91, 20)
            Me.btnExportarSubGrupo.Text = "EXPORTAR"
            '
            'txtCodigoGrupo
            '
            Me.txtCodigoGrupo.BackColor = System.Drawing.Color.White
            Me.txtCodigoGrupo.Enabled = False
            Me.txtCodigoGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoGrupo.Location = New System.Drawing.Point(96, 65)
            Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
            Me.txtCodigoGrupo.Size = New System.Drawing.Size(41, 22)
            Me.txtCodigoGrupo.TabIndex = 84
            Me.txtCodigoGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoSubGrupo
            '
            Me.txtCodigoSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtCodigoSubGrupo.Enabled = False
            Me.txtCodigoSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoSubGrupo.Location = New System.Drawing.Point(137, 65)
            Me.txtCodigoSubGrupo.Name = "txtCodigoSubGrupo"
            Me.txtCodigoSubGrupo.Size = New System.Drawing.Size(41, 22)
            Me.txtCodigoSubGrupo.TabIndex = 82
            Me.txtCodigoSubGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCódigoSubGrupo
            '
            Me.lblCódigoSubGrupo.AutoSize = True
            Me.lblCódigoSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCódigoSubGrupo.Location = New System.Drawing.Point(96, 48)
            Me.lblCódigoSubGrupo.Name = "lblCódigoSubGrupo"
            Me.lblCódigoSubGrupo.Size = New System.Drawing.Size(54, 13)
            Me.lblCódigoSubGrupo.TabIndex = 81
            Me.lblCódigoSubGrupo.Text = "CÓDIGO:"
            '
            'cbmGrupo
            '
            Me.cbmGrupo.BackColor = System.Drawing.Color.White
            Me.cbmGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo.Enabled = False
            Me.cbmGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(275, 65)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(278, 21)
            Me.cbmGrupo.TabIndex = 74
            '
            'dgvSubGrupoItem
            '
            Me.dgvSubGrupoItem.AllowUserToAddRows = False
            Me.dgvSubGrupoItem.AllowUserToDeleteRows = False
            Me.dgvSubGrupoItem.AllowUserToResizeRows = False
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSubGrupoItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvSubGrupoItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvSubGrupoItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSubGrupoItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvSubGrupoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSubGrupoItem.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvSubGrupoItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvSubGrupoItem.Location = New System.Drawing.Point(6, 121)
            Me.dgvSubGrupoItem.MultiSelect = False
            Me.dgvSubGrupoItem.Name = "dgvSubGrupoItem"
            Me.dgvSubGrupoItem.ReadOnly = True
            Me.dgvSubGrupoItem.RowHeadersVisible = False
            Me.dgvSubGrupoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSubGrupoItem.Size = New System.Drawing.Size(549, 209)
            Me.dgvSubGrupoItem.TabIndex = 57
            '
            'lblGrupo
            '
            Me.lblGrupo.AutoSize = True
            Me.lblGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGrupo.Location = New System.Drawing.Point(224, 68)
            Me.lblGrupo.Name = "lblGrupo"
            Me.lblGrupo.Size = New System.Drawing.Size(45, 13)
            Me.lblGrupo.TabIndex = 72
            Me.lblGrupo.Text = "GRUPO"
            '
            'txtIdSubGrupo
            '
            Me.txtIdSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtIdSubGrupo.Enabled = False
            Me.txtIdSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdSubGrupo.Location = New System.Drawing.Point(21, 65)
            Me.txtIdSubGrupo.Name = "txtIdSubGrupo"
            Me.txtIdSubGrupo.Size = New System.Drawing.Size(69, 22)
            Me.txtIdSubGrupo.TabIndex = 80
            Me.txtIdSubGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(18, 49)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(21, 13)
            Me.Label5.TabIndex = 79
            Me.Label5.Text = "ID:"
            '
            'txtNombreSubGrupo
            '
            Me.txtNombreSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreSubGrupo.Enabled = False
            Me.txtNombreSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSubGrupo.Location = New System.Drawing.Point(77, 93)
            Me.txtNombreSubGrupo.Name = "txtNombreSubGrupo"
            Me.txtNombreSubGrupo.Size = New System.Drawing.Size(476, 22)
            Me.txtNombreSubGrupo.TabIndex = 78
            '
            'lblNombreSubGrupo
            '
            Me.lblNombreSubGrupo.AutoSize = True
            Me.lblNombreSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreSubGrupo.Location = New System.Drawing.Point(21, 98)
            Me.lblNombreSubGrupo.Name = "lblNombreSubGrupo"
            Me.lblNombreSubGrupo.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreSubGrupo.TabIndex = 77
            Me.lblNombreSubGrupo.Text = "NOMBRE:"
            '
            'gbGrupo
            '
            Me.gbGrupo.Controls.Add(Me.MenuStrip1)
            Me.gbGrupo.Controls.Add(Me.txtCodigoCategoría)
            Me.gbGrupo.Controls.Add(Me.txtCódigoGrupo)
            Me.gbGrupo.Controls.Add(Me.lblCódigoGrupo)
            Me.gbGrupo.Controls.Add(Me.cbmCategoría)
            Me.gbGrupo.Controls.Add(Me.lblCategoría)
            Me.gbGrupo.Controls.Add(Me.txtIdGrupo)
            Me.gbGrupo.Controls.Add(Me.Label2)
            Me.gbGrupo.Controls.Add(Me.txtNombreGrupo)
            Me.gbGrupo.Controls.Add(Me.lblNombreGrupo)
            Me.gbGrupo.Controls.Add(Me.dgvGrupoItem)
            Me.gbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.gbGrupo.Location = New System.Drawing.Point(403, 1)
            Me.gbGrupo.Name = "gbGrupo"
            Me.gbGrupo.Size = New System.Drawing.Size(564, 309)
            Me.gbGrupo.TabIndex = 1
            Me.gbGrupo.TabStop = False
            Me.gbGrupo.Text = "GRUPO"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoGrupo, Me.btnGuardarGrupo, Me.btnCancelarGrupo, Me.btnExportarGrupos})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 18)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(558, 24)
            Me.MenuStrip1.TabIndex = 181
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoGrupo
            '
            Me.btnNuevoGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoGrupo.Image = CType(resources.GetObject("btnNuevoGrupo.Image"), System.Drawing.Image)
            Me.btnNuevoGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
            Me.btnNuevoGrupo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevoGrupo.Text = "NUEVO"
            '
            'btnGuardarGrupo
            '
            Me.btnGuardarGrupo.Enabled = False
            Me.btnGuardarGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarGrupo.Image = CType(resources.GetObject("btnGuardarGrupo.Image"), System.Drawing.Image)
            Me.btnGuardarGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarGrupo.Name = "btnGuardarGrupo"
            Me.btnGuardarGrupo.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardarGrupo.Text = "GUARDAR"
            '
            'btnCancelarGrupo
            '
            Me.btnCancelarGrupo.Enabled = False
            Me.btnCancelarGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarGrupo.Image = CType(resources.GetObject("btnCancelarGrupo.Image"), System.Drawing.Image)
            Me.btnCancelarGrupo.Name = "btnCancelarGrupo"
            Me.btnCancelarGrupo.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarGrupo.Text = "CANCELAR"
            '
            'btnExportarGrupos
            '
            Me.btnExportarGrupos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarGrupos.Image = CType(resources.GetObject("btnExportarGrupos.Image"), System.Drawing.Image)
            Me.btnExportarGrupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarGrupos.Name = "btnExportarGrupos"
            Me.btnExportarGrupos.Size = New System.Drawing.Size(91, 20)
            Me.btnExportarGrupos.Text = "EXPORTAR"
            '
            'txtCodigoCategoría
            '
            Me.txtCodigoCategoría.BackColor = System.Drawing.Color.White
            Me.txtCodigoCategoría.Enabled = False
            Me.txtCodigoCategoría.Location = New System.Drawing.Point(81, 59)
            Me.txtCodigoCategoría.Name = "txtCodigoCategoría"
            Me.txtCodigoCategoría.Size = New System.Drawing.Size(41, 22)
            Me.txtCodigoCategoría.TabIndex = 82
            Me.txtCodigoCategoría.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCódigoGrupo
            '
            Me.txtCódigoGrupo.BackColor = System.Drawing.Color.White
            Me.txtCódigoGrupo.Enabled = False
            Me.txtCódigoGrupo.Location = New System.Drawing.Point(125, 59)
            Me.txtCódigoGrupo.Name = "txtCódigoGrupo"
            Me.txtCódigoGrupo.Size = New System.Drawing.Size(41, 22)
            Me.txtCódigoGrupo.TabIndex = 81
            Me.txtCódigoGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCódigoGrupo
            '
            Me.lblCódigoGrupo.AutoSize = True
            Me.lblCódigoGrupo.Location = New System.Drawing.Point(78, 45)
            Me.lblCódigoGrupo.Name = "lblCódigoGrupo"
            Me.lblCódigoGrupo.Size = New System.Drawing.Size(54, 13)
            Me.lblCódigoGrupo.TabIndex = 79
            Me.lblCódigoGrupo.Text = "CÓDIGO:"
            '
            'cbmCategoría
            '
            Me.cbmCategoría.BackColor = System.Drawing.Color.White
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(287, 59)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(266, 21)
            Me.cbmCategoría.TabIndex = 66
            '
            'lblCategoría
            '
            Me.lblCategoría.AutoSize = True
            Me.lblCategoría.Location = New System.Drawing.Point(216, 62)
            Me.lblCategoría.Name = "lblCategoría"
            Me.lblCategoría.Size = New System.Drawing.Size(66, 13)
            Me.lblCategoría.TabIndex = 65
            Me.lblCategoría.Text = "CATEGORÍA"
            '
            'txtIdGrupo
            '
            Me.txtIdGrupo.BackColor = System.Drawing.Color.White
            Me.txtIdGrupo.Enabled = False
            Me.txtIdGrupo.Location = New System.Drawing.Point(11, 59)
            Me.txtIdGrupo.Name = "txtIdGrupo"
            Me.txtIdGrupo.Size = New System.Drawing.Size(67, 22)
            Me.txtIdGrupo.TabIndex = 71
            Me.txtIdGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(14, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(21, 13)
            Me.Label2.TabIndex = 70
            Me.Label2.Text = "ID:"
            '
            'txtNombreGrupo
            '
            Me.txtNombreGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreGrupo.Enabled = False
            Me.txtNombreGrupo.Location = New System.Drawing.Point(68, 85)
            Me.txtNombreGrupo.Name = "txtNombreGrupo"
            Me.txtNombreGrupo.Size = New System.Drawing.Size(485, 22)
            Me.txtNombreGrupo.TabIndex = 69
            '
            'lblNombreGrupo
            '
            Me.lblNombreGrupo.AutoSize = True
            Me.lblNombreGrupo.Location = New System.Drawing.Point(7, 88)
            Me.lblNombreGrupo.Name = "lblNombreGrupo"
            Me.lblNombreGrupo.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreGrupo.TabIndex = 68
            Me.lblNombreGrupo.Text = "NOMBRE:"
            '
            'dgvGrupoItem
            '
            Me.dgvGrupoItem.AllowUserToAddRows = False
            Me.dgvGrupoItem.AllowUserToDeleteRows = False
            Me.dgvGrupoItem.AllowUserToResizeRows = False
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrupoItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvGrupoItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvGrupoItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrupoItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvGrupoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrupoItem.DefaultCellStyle = DataGridViewCellStyle15
            Me.dgvGrupoItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvGrupoItem.Location = New System.Drawing.Point(6, 111)
            Me.dgvGrupoItem.MultiSelect = False
            Me.dgvGrupoItem.Name = "dgvGrupoItem"
            Me.dgvGrupoItem.ReadOnly = True
            Me.dgvGrupoItem.RowHeadersVisible = False
            Me.dgvGrupoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrupoItem.Size = New System.Drawing.Size(549, 186)
            Me.dgvGrupoItem.TabIndex = 56
            '
            'gbCategoria
            '
            Me.gbCategoria.Controls.Add(Me.msKardex)
            Me.gbCategoria.Controls.Add(Me.txtIdCategoría)
            Me.gbCategoria.Controls.Add(Me.Label1)
            Me.gbCategoria.Controls.Add(Me.txtNombreCategoría)
            Me.gbCategoria.Controls.Add(Me.lblNombreCategoría)
            Me.gbCategoria.Controls.Add(Me.dgvCategoriaItem)
            Me.gbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.gbCategoria.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCategoria.Location = New System.Drawing.Point(1, 2)
            Me.gbCategoria.Name = "gbCategoria"
            Me.gbCategoria.Size = New System.Drawing.Size(400, 645)
            Me.gbCategoria.TabIndex = 0
            Me.gbCategoria.TabStop = False
            Me.gbCategoria.Text = "CATEGORÍA"
            '
            'msKardex
            '
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoCategoría, Me.btnGuardarCategoría, Me.btnCancelarCategoría, Me.btnExportar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(3, 16)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.msKardex.Size = New System.Drawing.Size(394, 24)
            Me.msKardex.TabIndex = 180
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevoCategoría
            '
            Me.btnNuevoCategoría.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoCategoría.Image = CType(resources.GetObject("btnNuevoCategoría.Image"), System.Drawing.Image)
            Me.btnNuevoCategoría.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoCategoría.Name = "btnNuevoCategoría"
            Me.btnNuevoCategoría.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevoCategoría.Text = "NUEVO"
            '
            'btnGuardarCategoría
            '
            Me.btnGuardarCategoría.Enabled = False
            Me.btnGuardarCategoría.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarCategoría.Image = CType(resources.GetObject("btnGuardarCategoría.Image"), System.Drawing.Image)
            Me.btnGuardarCategoría.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarCategoría.Name = "btnGuardarCategoría"
            Me.btnGuardarCategoría.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardarCategoría.Text = "GUARDAR"
            '
            'btnCancelarCategoría
            '
            Me.btnCancelarCategoría.Enabled = False
            Me.btnCancelarCategoría.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarCategoría.Image = CType(resources.GetObject("btnCancelarCategoría.Image"), System.Drawing.Image)
            Me.btnCancelarCategoría.Name = "btnCancelarCategoría"
            Me.btnCancelarCategoría.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarCategoría.Text = "CANCELAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'txtIdCategoría
            '
            Me.txtIdCategoría.BackColor = System.Drawing.Color.White
            Me.txtIdCategoría.Enabled = False
            Me.txtIdCategoría.Location = New System.Drawing.Point(54, 49)
            Me.txtIdCategoría.Name = "txtIdCategoría"
            Me.txtIdCategoría.Size = New System.Drawing.Size(70, 20)
            Me.txtIdCategoría.TabIndex = 64
            Me.txtIdCategoría.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 52)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(49, 13)
            Me.Label1.TabIndex = 63
            Me.Label1.Text = "CÓDIGO:"
            '
            'txtNombreCategoría
            '
            Me.txtNombreCategoría.BackColor = System.Drawing.Color.White
            Me.txtNombreCategoría.Enabled = False
            Me.txtNombreCategoría.Location = New System.Drawing.Point(198, 49)
            Me.txtNombreCategoría.Name = "txtNombreCategoría"
            Me.txtNombreCategoría.Size = New System.Drawing.Size(196, 20)
            Me.txtNombreCategoría.TabIndex = 62
            '
            'lblNombreCategoría
            '
            Me.lblNombreCategoría.AutoSize = True
            Me.lblNombreCategoría.Location = New System.Drawing.Point(152, 52)
            Me.lblNombreCategoría.Name = "lblNombreCategoría"
            Me.lblNombreCategoría.Size = New System.Drawing.Size(49, 13)
            Me.lblNombreCategoría.TabIndex = 61
            Me.lblNombreCategoría.Text = "NOMBRE:"
            '
            'dgvCategoriaItem
            '
            Me.dgvCategoriaItem.AllowUserToAddRows = False
            Me.dgvCategoriaItem.AllowUserToDeleteRows = False
            Me.dgvCategoriaItem.AllowUserToResizeRows = False
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCategoriaItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvCategoriaItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvCategoriaItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoriaItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvCategoriaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoriaItem.DefaultCellStyle = DataGridViewCellStyle18
            Me.dgvCategoriaItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvCategoriaItem.Location = New System.Drawing.Point(6, 75)
            Me.dgvCategoriaItem.MultiSelect = False
            Me.dgvCategoriaItem.Name = "dgvCategoriaItem"
            Me.dgvCategoriaItem.ReadOnly = True
            Me.dgvCategoriaItem.RowHeadersVisible = False
            Me.dgvCategoriaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCategoriaItem.Size = New System.Drawing.Size(388, 565)
            Me.dgvCategoriaItem.TabIndex = 55
            '
            'ttPublico
            '
            Me.ttPublico.AutoPopDelay = 5000
            Me.ttPublico.BackColor = System.Drawing.Color.LightSteelBlue
            Me.ttPublico.InitialDelay = 100
            Me.ttPublico.IsBalloon = True
            Me.ttPublico.ReshowDelay = 100
            Me.ttPublico.ShowAlways = True
            Me.ttPublico.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            '
            'FormItemsBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(968, 648)
            Me.Controls.Add(Me.gbSubGrupo)
            Me.Controls.Add(Me.gbGrupo)
            Me.Controls.Add(Me.gbCategoria)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormItemsBodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTO DE ITEMS DE BODEGA"
            Me.gbSubGrupo.ResumeLayout(False)
            Me.gbSubGrupo.PerformLayout()
            Me.MenuStrip2.ResumeLayout(False)
            Me.MenuStrip2.PerformLayout()
            CType(Me.dgvSubGrupoItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbGrupo.ResumeLayout(False)
            Me.gbGrupo.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvGrupoItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCategoria.ResumeLayout(False)
            Me.gbCategoria.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbSubGrupo As System.Windows.Forms.GroupBox
        Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
        Friend WithEvents gbCategoria As System.Windows.Forms.GroupBox
        Friend WithEvents dgvSubGrupoItem As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCategoriaItem As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdCategoría As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCategoría As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCategoría As System.Windows.Forms.Label
        Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreGrupo As System.Windows.Forms.Label
        Friend WithEvents cbmGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents lblGrupo As System.Windows.Forms.Label
        Friend WithEvents txtIdSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNombreSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreSubGrupo As System.Windows.Forms.Label
        Friend WithEvents cbmCategoría As System.Windows.Forms.ComboBox
        Friend WithEvents lblCategoría As System.Windows.Forms.Label
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents lblCódigoGrupo As System.Windows.Forms.Label
        Friend WithEvents txtCodigoSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblCódigoSubGrupo As System.Windows.Forms.Label
        Friend WithEvents dgvGrupoItem As System.Windows.Forms.DataGridView
        Friend WithEvents txtCódigoGrupo As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoCategoría As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoGrupo As System.Windows.Forms.TextBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportarGrupos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoSubGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSubGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarSubGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportarSubGrupo As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace