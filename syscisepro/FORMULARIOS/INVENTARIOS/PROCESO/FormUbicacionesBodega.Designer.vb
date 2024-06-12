Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormUbicacionesBodega
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUbicacionesBodega))
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.tcMantenimientoItemsBodega = New System.Windows.Forms.TabControl()
            Me.tpMantenimientosItems = New System.Windows.Forms.TabPage()
            Me.dgvCategoriaItem = New System.Windows.Forms.DataGridView()
            Me.cbmBodega = New System.Windows.Forms.ComboBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarCategoría = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblBodega = New System.Windows.Forms.Label()
            Me.txtIdCategoría = New System.Windows.Forms.TextBox()
            Me.nudFilas = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombreCategoría = New System.Windows.Forms.TextBox()
            Me.lblNombreCategoría = New System.Windows.Forms.Label()
            Me.tpFilas = New System.Windows.Forms.TabPage()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarGrupo = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgvCasilleros = New System.Windows.Forms.DataGridView()
            Me.dgvGrupoItem = New System.Windows.Forms.DataGridView()
            Me.cbmBodegaGrupo = New System.Windows.Forms.ComboBox()
            Me.lblNombreGrupo = New System.Windows.Forms.Label()
            Me.lblBodegaGrupo = New System.Windows.Forms.Label()
            Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
            Me.nudCasilleros = New System.Windows.Forms.NumericUpDown()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtIdGrupo = New System.Windows.Forms.TextBox()
            Me.lblCategoría = New System.Windows.Forms.Label()
            Me.cbmCategoría = New System.Windows.Forms.ComboBox()
            Me.tpEsquema = New System.Windows.Forms.TabPage()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.pbCategoríaUbicación = New System.Windows.Forms.PictureBox()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcMantenimientoItemsBodega.SuspendLayout()
            Me.tpMantenimientosItems.SuspendLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.nudFilas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpFilas.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvCasilleros, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvGrupoItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCasilleros, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpEsquema.SuspendLayout()
            CType(Me.pbCategoríaUbicación, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tcMantenimientoItemsBodega
            '
            Me.tcMantenimientoItemsBodega.Controls.Add(Me.tpMantenimientosItems)
            Me.tcMantenimientoItemsBodega.Controls.Add(Me.tpFilas)
            Me.tcMantenimientoItemsBodega.Controls.Add(Me.tpEsquema)
            Me.tcMantenimientoItemsBodega.Location = New System.Drawing.Point(3, 4)
            Me.tcMantenimientoItemsBodega.Name = "tcMantenimientoItemsBodega"
            Me.tcMantenimientoItemsBodega.SelectedIndex = 0
            Me.tcMantenimientoItemsBodega.Size = New System.Drawing.Size(813, 605)
            Me.tcMantenimientoItemsBodega.TabIndex = 0
            '
            'tpMantenimientosItems
            '
            Me.tpMantenimientosItems.Controls.Add(Me.dgvCategoriaItem)
            Me.tpMantenimientosItems.Controls.Add(Me.cbmBodega)
            Me.tpMantenimientosItems.Controls.Add(Me.msKardex)
            Me.tpMantenimientosItems.Controls.Add(Me.Label6)
            Me.tpMantenimientosItems.Controls.Add(Me.lblBodega)
            Me.tpMantenimientosItems.Controls.Add(Me.txtIdCategoría)
            Me.tpMantenimientosItems.Controls.Add(Me.nudFilas)
            Me.tpMantenimientosItems.Controls.Add(Me.Label1)
            Me.tpMantenimientosItems.Controls.Add(Me.txtNombreCategoría)
            Me.tpMantenimientosItems.Controls.Add(Me.lblNombreCategoría)
            Me.tpMantenimientosItems.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpMantenimientosItems.Location = New System.Drawing.Point(4, 22)
            Me.tpMantenimientosItems.Name = "tpMantenimientosItems"
            Me.tpMantenimientosItems.Padding = New System.Windows.Forms.Padding(3)
            Me.tpMantenimientosItems.Size = New System.Drawing.Size(805, 579)
            Me.tpMantenimientosItems.TabIndex = 0
            Me.tpMantenimientosItems.Text = "PERCHAS"
            Me.tpMantenimientosItems.UseVisualStyleBackColor = True
            '
            'dgvCategoriaItem
            '
            Me.dgvCategoriaItem.AllowUserToAddRows = False
            Me.dgvCategoriaItem.AllowUserToDeleteRows = False
            Me.dgvCategoriaItem.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCategoriaItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvCategoriaItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvCategoriaItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCategoriaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoriaItem.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvCategoriaItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvCategoriaItem.Location = New System.Drawing.Point(5, 66)
            Me.dgvCategoriaItem.MultiSelect = False
            Me.dgvCategoriaItem.Name = "dgvCategoriaItem"
            Me.dgvCategoriaItem.ReadOnly = True
            Me.dgvCategoriaItem.RowHeadersVisible = False
            Me.dgvCategoriaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCategoriaItem.Size = New System.Drawing.Size(794, 508)
            Me.dgvCategoriaItem.TabIndex = 55
            '
            'cbmBodega
            '
            Me.cbmBodega.BackColor = System.Drawing.Color.White
            Me.cbmBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmBodega.Enabled = False
            Me.cbmBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmBodega.ForeColor = System.Drawing.Color.Black
            Me.cbmBodega.FormattingEnabled = True
            Me.cbmBodega.Location = New System.Drawing.Point(215, 39)
            Me.cbmBodega.Name = "cbmBodega"
            Me.cbmBodega.Size = New System.Drawing.Size(272, 21)
            Me.cbmBodega.TabIndex = 80
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevoCategoría, Me.btnGuardarCategoría, Me.btnCancelarCategoría})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(3, 3)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(799, 32)
            Me.msKardex.TabIndex = 181
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'btnNuevoCategoría
            '
            Me.btnNuevoCategoría.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoCategoría.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoCategoría.Name = "btnNuevoCategoría"
            Me.btnNuevoCategoría.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevoCategoría.Text = "NUEVO"
            '
            'btnGuardarCategoría
            '
            Me.btnGuardarCategoría.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarCategoría.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarCategoría.Name = "btnGuardarCategoría"
            Me.btnGuardarCategoría.Size = New System.Drawing.Size(97, 28)
            Me.btnGuardarCategoría.Text = "GUARDAR"
            '
            'btnCancelarCategoría
            '
            Me.btnCancelarCategoría.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarCategoría.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarCategoría.Name = "btnCancelarCategoría"
            Me.btnCancelarCategoría.Size = New System.Drawing.Size(103, 28)
            Me.btnCancelarCategoría.Text = "CANCELAR"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(687, 41)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(54, 13)
            Me.Label6.TabIndex = 77
            Me.Label6.Text = "N° FILAS:"
            '
            'lblBodega
            '
            Me.lblBodega.AutoSize = True
            Me.lblBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBodega.Location = New System.Drawing.Point(157, 43)
            Me.lblBodega.Name = "lblBodega"
            Me.lblBodega.Size = New System.Drawing.Size(50, 13)
            Me.lblBodega.TabIndex = 79
            Me.lblBodega.Text = "BODEGA"
            '
            'txtIdCategoría
            '
            Me.txtIdCategoría.Enabled = False
            Me.txtIdCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCategoría.Location = New System.Drawing.Point(39, 39)
            Me.txtIdCategoría.Name = "txtIdCategoría"
            Me.txtIdCategoría.Size = New System.Drawing.Size(47, 21)
            Me.txtIdCategoría.TabIndex = 64
            Me.txtIdCategoría.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudFilas
            '
            Me.nudFilas.BackColor = System.Drawing.Color.White
            Me.nudFilas.Enabled = False
            Me.nudFilas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudFilas.ForeColor = System.Drawing.Color.Black
            Me.nudFilas.Location = New System.Drawing.Point(740, 38)
            Me.nudFilas.Name = "nudFilas"
            Me.nudFilas.Size = New System.Drawing.Size(50, 21)
            Me.nudFilas.TabIndex = 78
            Me.nudFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(13, 42)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 13)
            Me.Label1.TabIndex = 63
            Me.Label1.Text = "ID:"
            '
            'txtNombreCategoría
            '
            Me.txtNombreCategoría.BackColor = System.Drawing.Color.White
            Me.txtNombreCategoría.Enabled = False
            Me.txtNombreCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCategoría.ForeColor = System.Drawing.Color.Black
            Me.txtNombreCategoría.Location = New System.Drawing.Point(573, 38)
            Me.txtNombreCategoría.Name = "txtNombreCategoría"
            Me.txtNombreCategoría.Size = New System.Drawing.Size(66, 21)
            Me.txtNombreCategoría.TabIndex = 83
            Me.txtNombreCategoría.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblNombreCategoría
            '
            Me.lblNombreCategoría.AutoSize = True
            Me.lblNombreCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreCategoría.Location = New System.Drawing.Point(516, 42)
            Me.lblNombreCategoría.Name = "lblNombreCategoría"
            Me.lblNombreCategoría.Size = New System.Drawing.Size(48, 13)
            Me.lblNombreCategoría.TabIndex = 82
            Me.lblNombreCategoría.Text = "CÓDIGO"
            '
            'tpFilas
            '
            Me.tpFilas.Controls.Add(Me.Button1)
            Me.tpFilas.Controls.Add(Me.MenuStrip1)
            Me.tpFilas.Controls.Add(Me.Label3)
            Me.tpFilas.Controls.Add(Me.dgvCasilleros)
            Me.tpFilas.Controls.Add(Me.dgvGrupoItem)
            Me.tpFilas.Controls.Add(Me.cbmBodegaGrupo)
            Me.tpFilas.Controls.Add(Me.lblNombreGrupo)
            Me.tpFilas.Controls.Add(Me.lblBodegaGrupo)
            Me.tpFilas.Controls.Add(Me.txtNombreGrupo)
            Me.tpFilas.Controls.Add(Me.nudCasilleros)
            Me.tpFilas.Controls.Add(Me.Label2)
            Me.tpFilas.Controls.Add(Me.Label7)
            Me.tpFilas.Controls.Add(Me.txtIdGrupo)
            Me.tpFilas.Controls.Add(Me.lblCategoría)
            Me.tpFilas.Controls.Add(Me.cbmCategoría)
            Me.tpFilas.Location = New System.Drawing.Point(4, 22)
            Me.tpFilas.Name = "tpFilas"
            Me.tpFilas.Padding = New System.Windows.Forms.Padding(3)
            Me.tpFilas.Size = New System.Drawing.Size(805, 579)
            Me.tpFilas.TabIndex = 1
            Me.tpFilas.Text = "FILAS Y CASILLEROS"
            Me.tpFilas.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(729, 395)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(73, 25)
            Me.Button1.TabIndex = 183
            Me.Button1.Text = "NUEVO"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.btnNuevoGrupo, Me.btnGuardarGrupo, Me.btnCancelarGrupo})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(799, 24)
            Me.MenuStrip1.TabIndex = 181
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(119, 20)
            Me.ToolStripMenuItem2.Text = "LISTAR TODOS"
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
            Me.btnGuardarGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarGrupo.Image = CType(resources.GetObject("btnGuardarGrupo.Image"), System.Drawing.Image)
            Me.btnGuardarGrupo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarGrupo.Name = "btnGuardarGrupo"
            Me.btnGuardarGrupo.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardarGrupo.Text = "GUARDAR"
            '
            'btnCancelarGrupo
            '
            Me.btnCancelarGrupo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarGrupo.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarGrupo.Name = "btnCancelarGrupo"
            Me.btnCancelarGrupo.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarGrupo.Text = "CANCELAR"
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 395)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(801, 25)
            Me.Label3.TabIndex = 182
            Me.Label3.Text = "CASILLEROS CREADOS"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dgvCasilleros
            '
            Me.dgvCasilleros.AllowUserToAddRows = False
            Me.dgvCasilleros.AllowUserToDeleteRows = False
            Me.dgvCasilleros.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCasilleros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvCasilleros.BackgroundColor = System.Drawing.Color.White
            Me.dgvCasilleros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvCasilleros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCasilleros.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvCasilleros.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvCasilleros.Location = New System.Drawing.Point(5, 420)
            Me.dgvCasilleros.MultiSelect = False
            Me.dgvCasilleros.Name = "dgvCasilleros"
            Me.dgvCasilleros.ReadOnly = True
            Me.dgvCasilleros.RowHeadersVisible = False
            Me.dgvCasilleros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCasilleros.Size = New System.Drawing.Size(793, 153)
            Me.dgvCasilleros.TabIndex = 181
            '
            'dgvGrupoItem
            '
            Me.dgvGrupoItem.AllowUserToAddRows = False
            Me.dgvGrupoItem.AllowUserToDeleteRows = False
            Me.dgvGrupoItem.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrupoItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvGrupoItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvGrupoItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvGrupoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrupoItem.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvGrupoItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvGrupoItem.Location = New System.Drawing.Point(5, 65)
            Me.dgvGrupoItem.MultiSelect = False
            Me.dgvGrupoItem.Name = "dgvGrupoItem"
            Me.dgvGrupoItem.ReadOnly = True
            Me.dgvGrupoItem.RowHeadersVisible = False
            Me.dgvGrupoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrupoItem.Size = New System.Drawing.Size(795, 324)
            Me.dgvGrupoItem.TabIndex = 79
            '
            'cbmBodegaGrupo
            '
            Me.cbmBodegaGrupo.BackColor = System.Drawing.Color.White
            Me.cbmBodegaGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmBodegaGrupo.Enabled = False
            Me.cbmBodegaGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmBodegaGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmBodegaGrupo.ForeColor = System.Drawing.Color.Black
            Me.cbmBodegaGrupo.FormattingEnabled = True
            Me.cbmBodegaGrupo.Location = New System.Drawing.Point(154, 39)
            Me.cbmBodegaGrupo.Name = "cbmBodegaGrupo"
            Me.cbmBodegaGrupo.Size = New System.Drawing.Size(148, 21)
            Me.cbmBodegaGrupo.TabIndex = 88
            '
            'lblNombreGrupo
            '
            Me.lblNombreGrupo.AutoSize = True
            Me.lblNombreGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreGrupo.Location = New System.Drawing.Point(525, 42)
            Me.lblNombreGrupo.Name = "lblNombreGrupo"
            Me.lblNombreGrupo.Size = New System.Drawing.Size(29, 13)
            Me.lblNombreGrupo.TabIndex = 68
            Me.lblNombreGrupo.Text = "FILA:"
            '
            'lblBodegaGrupo
            '
            Me.lblBodegaGrupo.AutoSize = True
            Me.lblBodegaGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBodegaGrupo.Location = New System.Drawing.Point(103, 42)
            Me.lblBodegaGrupo.Name = "lblBodegaGrupo"
            Me.lblBodegaGrupo.Size = New System.Drawing.Size(45, 13)
            Me.lblBodegaGrupo.TabIndex = 87
            Me.lblBodegaGrupo.Text = "BODEGA"
            '
            'txtNombreGrupo
            '
            Me.txtNombreGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreGrupo.Enabled = False
            Me.txtNombreGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreGrupo.ForeColor = System.Drawing.Color.Black
            Me.txtNombreGrupo.Location = New System.Drawing.Point(560, 38)
            Me.txtNombreGrupo.Name = "txtNombreGrupo"
            Me.txtNombreGrupo.Size = New System.Drawing.Size(67, 21)
            Me.txtNombreGrupo.TabIndex = 69
            Me.txtNombreGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudCasilleros
            '
            Me.nudCasilleros.BackColor = System.Drawing.Color.White
            Me.nudCasilleros.Enabled = False
            Me.nudCasilleros.ForeColor = System.Drawing.Color.Black
            Me.nudCasilleros.Location = New System.Drawing.Point(722, 38)
            Me.nudCasilleros.Name = "nudCasilleros"
            Me.nudCasilleros.Size = New System.Drawing.Size(73, 22)
            Me.nudCasilleros.TabIndex = 81
            Me.nudCasilleros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(13, 41)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 13)
            Me.Label2.TabIndex = 70
            Me.Label2.Text = "ID:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(640, 41)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(76, 13)
            Me.Label7.TabIndex = 80
            Me.Label7.Text = "N° CASILLEROS:"
            '
            'txtIdGrupo
            '
            Me.txtIdGrupo.Enabled = False
            Me.txtIdGrupo.Location = New System.Drawing.Point(39, 37)
            Me.txtIdGrupo.Name = "txtIdGrupo"
            Me.txtIdGrupo.Size = New System.Drawing.Size(53, 22)
            Me.txtIdGrupo.TabIndex = 71
            Me.txtIdGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCategoría
            '
            Me.lblCategoría.AutoSize = True
            Me.lblCategoría.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCategoría.Location = New System.Drawing.Point(328, 42)
            Me.lblCategoría.Name = "lblCategoría"
            Me.lblCategoría.Size = New System.Drawing.Size(43, 13)
            Me.lblCategoría.TabIndex = 65
            Me.lblCategoría.Text = "PERCHA"
            '
            'cbmCategoría
            '
            Me.cbmCategoría.BackColor = System.Drawing.Color.White
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCategoría.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoría.ForeColor = System.Drawing.Color.Black
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(377, 38)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(122, 21)
            Me.cbmCategoría.TabIndex = 66
            '
            'tpEsquema
            '
            Me.tpEsquema.Controls.Add(Me.Label11)
            Me.tpEsquema.Controls.Add(Me.Label10)
            Me.tpEsquema.Controls.Add(Me.Label9)
            Me.tpEsquema.Controls.Add(Me.Label8)
            Me.tpEsquema.Controls.Add(Me.TextBox4)
            Me.tpEsquema.Controls.Add(Me.TextBox3)
            Me.tpEsquema.Controls.Add(Me.TextBox2)
            Me.tpEsquema.Controls.Add(Me.TextBox1)
            Me.tpEsquema.Controls.Add(Me.pbCategoríaUbicación)
            Me.tpEsquema.Location = New System.Drawing.Point(4, 22)
            Me.tpEsquema.Name = "tpEsquema"
            Me.tpEsquema.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEsquema.Size = New System.Drawing.Size(805, 579)
            Me.tpEsquema.TabIndex = 3
            Me.tpEsquema.Text = "ESQUEMA"
            Me.tpEsquema.UseVisualStyleBackColor = True
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(4, 500)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(161, 14)
            Me.Label11.TabIndex = 87
            Me.Label11.Text = "¿QUE ÉS UN  CASILLERO?"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(3, 347)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(126, 14)
            Me.Label10.TabIndex = 86
            Me.Label10.Text = "¿QUE ÉS UNA FILA?"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(5, 139)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(315, 14)
            Me.Label9.TabIndex = 85
            Me.Label9.Text = "EJEMPLO DE CODIFICACIÓN FINAL EN UNA PERCHA:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 3)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(119, 14)
            Me.Label8.TabIndex = 84
            Me.Label8.Text = "¿QUE ÉS PERCHA? "
            '
            'TextBox4
            '
            Me.TextBox4.BackColor = System.Drawing.Color.White
            Me.TextBox4.Enabled = False
            Me.TextBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox4.Location = New System.Drawing.Point(5, 156)
            Me.TextBox4.Multiline = True
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(476, 129)
            Me.TextBox4.TabIndex = 83
            Me.TextBox4.Text = "1A1, 1A2,1A3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1B1,1B2,1B3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1C1,1C2,1C3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1D1,1D2,1D3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1E1,1E2,1E3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Representa lo" &
    "s casilleros de la percha que se muestra en el gráfico de esquema principal"
            Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.Enabled = False
            Me.TextBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.Location = New System.Drawing.Point(3, 517)
            Me.TextBox3.Multiline = True
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(476, 42)
            Me.TextBox3.TabIndex = 82
            Me.TextBox3.Text = "Son las divisiones que sirven para ubicar cada categoria. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EJEMPLO: 1,2,3,4... D" &
    "onde el número simboliza el casillero."
            '
            'TextBox2
            '
            Me.TextBox2.BackColor = System.Drawing.Color.White
            Me.TextBox2.Enabled = False
            Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox2.Location = New System.Drawing.Point(3, 364)
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(476, 61)
            Me.TextBox2.TabIndex = 81
            Me.TextBox2.Text = "Son las divisiones que sirven para segmentar una percha en categorías, estos a su" &
    " vez contienen casilleros. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EJEMPLO: A,B,C,D..... Donde la letra del abecedario" &
    " representa o simboliza una fila."
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(3, 20)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(797, 74)
            Me.TextBox1.TabIndex = 80
            Me.TextBox1.Text = resources.GetString("TextBox1.Text")
            '
            'pbCategoríaUbicación
            '
            Me.pbCategoríaUbicación.Image = CType(resources.GetObject("pbCategoríaUbicación.Image"), System.Drawing.Image)
            Me.pbCategoríaUbicación.Location = New System.Drawing.Point(485, 100)
            Me.pbCategoríaUbicación.Name = "pbCategoríaUbicación"
            Me.pbCategoríaUbicación.Size = New System.Drawing.Size(315, 473)
            Me.pbCategoríaUbicación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbCategoríaUbicación.TabIndex = 79
            Me.pbCategoríaUbicación.TabStop = False
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
            'FormUbicacionesBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(817, 612)
            Me.Controls.Add(Me.tcMantenimientoItemsBodega)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormUbicacionesBodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE UBICACIONES DE ITEMS DE BODEGA"
            Me.tcMantenimientoItemsBodega.ResumeLayout(False)
            Me.tpMantenimientosItems.ResumeLayout(False)
            Me.tpMantenimientosItems.PerformLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.nudFilas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpFilas.ResumeLayout(False)
            Me.tpFilas.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvCasilleros, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvGrupoItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCasilleros, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpEsquema.ResumeLayout(False)
            Me.tpEsquema.PerformLayout()
            CType(Me.pbCategoríaUbicación, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcMantenimientoItemsBodega As System.Windows.Forms.TabControl
        Friend WithEvents tpMantenimientosItems As System.Windows.Forms.TabPage
        Friend WithEvents dgvCategoriaItem As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdCategoría As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents nudFilas As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCategoría As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCategoría As System.Windows.Forms.Label
        Friend WithEvents cbmBodega As System.Windows.Forms.ComboBox
        Friend WithEvents lblBodega As System.Windows.Forms.Label
        Friend WithEvents tpFilas As System.Windows.Forms.TabPage
        Friend WithEvents pbCategoríaUbicación As System.Windows.Forms.PictureBox
        Friend WithEvents cbmCategoría As System.Windows.Forms.ComboBox
        Friend WithEvents lblCategoría As System.Windows.Forms.Label
        Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreGrupo As System.Windows.Forms.Label
        Friend WithEvents tpEsquema As System.Windows.Forms.TabPage
        Friend WithEvents dgvGrupoItem As System.Windows.Forms.DataGridView
        Friend WithEvents nudCasilleros As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbmBodegaGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents lblBodegaGrupo As System.Windows.Forms.Label
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevoCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarCategoría As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgvCasilleros As System.Windows.Forms.DataGridView
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevoGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarGrupo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarGrupo As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace