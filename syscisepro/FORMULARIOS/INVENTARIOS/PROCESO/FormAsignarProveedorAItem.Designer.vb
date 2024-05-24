Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAsignarProveedorAItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsignarProveedorAItem))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcDetalleProveedorItem = New System.Windows.Forms.TabControl()
            Me.tpMantenimientos = New System.Windows.Forms.TabPage()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnAgregarProveedor = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnEliminarProveedor = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvProveedoresAgregados = New System.Windows.Forms.DataGridView()
            Me.dgvProveedor = New System.Windows.Forms.DataGridView()
            Me.ColumnIdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColummRuc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnIdItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnCódigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtRuc = New System.Windows.Forms.TextBox()
            Me.lblNombreProveedor = New System.Windows.Forms.Label()
            Me.txtBuscarNombreProveedor = New System.Windows.Forms.TextBox()
            Me.gbBusquedaItem = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCódigoItem = New System.Windows.Forms.TextBox()
            Me.lblNombreItem = New System.Windows.Forms.Label()
            Me.txtBuscarDetalleItems = New System.Windows.Forms.TextBox()
            Me.tpListadoProveedores = New System.Windows.Forms.TabPage()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.dgvItems = New System.Windows.Forms.DataGridView()
            Me.tcDetalleProveedorItem.SuspendLayout()
            Me.tpMantenimientos.SuspendLayout()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvProveedoresAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbBusquedaItem.SuspendLayout()
            Me.tpListadoProveedores.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            'tcDetalleProveedorItem
            '
            Me.tcDetalleProveedorItem.Controls.Add(Me.tpMantenimientos)
            Me.tcDetalleProveedorItem.Controls.Add(Me.tpListadoProveedores)
            Me.tcDetalleProveedorItem.Location = New System.Drawing.Point(2, 1)
            Me.tcDetalleProveedorItem.Name = "tcDetalleProveedorItem"
            Me.tcDetalleProveedorItem.SelectedIndex = 0
            Me.tcDetalleProveedorItem.Size = New System.Drawing.Size(1034, 527)
            Me.tcDetalleProveedorItem.TabIndex = 0
            '
            'tpMantenimientos
            '
            Me.tpMantenimientos.Controls.Add(Me.msKardex)
            Me.tpMantenimientos.Controls.Add(Me.Label5)
            Me.tpMantenimientos.Controls.Add(Me.Label1)
            Me.tpMantenimientos.Controls.Add(Me.dgvProveedoresAgregados)
            Me.tpMantenimientos.Controls.Add(Me.dgvProveedor)
            Me.tpMantenimientos.Controls.Add(Me.GroupBox1)
            Me.tpMantenimientos.Controls.Add(Me.gbBusquedaItem)
            Me.tpMantenimientos.Location = New System.Drawing.Point(4, 22)
            Me.tpMantenimientos.Name = "tpMantenimientos"
            Me.tpMantenimientos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpMantenimientos.Size = New System.Drawing.Size(1026, 501)
            Me.tpMantenimientos.TabIndex = 0
            Me.tpMantenimientos.Text = "MANTENIMIENTOS"
            Me.tpMantenimientos.UseVisualStyleBackColor = True
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarProveedor, Me.btnGuardar, Me.btnEliminarProveedor, Me.btnReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(3, 3)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.msKardex.Size = New System.Drawing.Size(1020, 24)
            Me.msKardex.TabIndex = 182
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnAgregarProveedor
            '
            Me.btnAgregarProveedor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarProveedor.Image = CType(resources.GetObject("btnAgregarProveedor.Image"), System.Drawing.Image)
            Me.btnAgregarProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
            Me.btnAgregarProveedor.Size = New System.Drawing.Size(84, 20)
            Me.btnAgregarProveedor.Text = "AGREGAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnEliminarProveedor
            '
            Me.btnEliminarProveedor.Enabled = False
            Me.btnEliminarProveedor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarProveedor.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
            Me.btnEliminarProveedor.Size = New System.Drawing.Size(91, 20)
            Me.btnEliminarProveedor.Text = "ELIMINAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 20)
            Me.btnReporte.Text = "REPORTE"
            Me.btnReporte.Visible = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 291)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(253, 13)
            Me.Label5.TabIndex = 83
            Me.Label5.Text = "LISTADO DE PROVEDORES AGREGADOS AL ITEM"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(9, 103)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(277, 13)
            Me.Label1.TabIndex = 82
            Me.Label1.Text = "LISTADO DE PROVEEDORES EN COLA PARA AGREGAR"
            '
            'dgvProveedoresAgregados
            '
            Me.dgvProveedoresAgregados.AllowUserToAddRows = False
            Me.dgvProveedoresAgregados.AllowUserToDeleteRows = False
            Me.dgvProveedoresAgregados.AllowUserToResizeRows = False
            Me.dgvProveedoresAgregados.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedoresAgregados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvProveedoresAgregados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedoresAgregados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedoresAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedoresAgregados.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvProveedoresAgregados.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedoresAgregados.Location = New System.Drawing.Point(6, 305)
            Me.dgvProveedoresAgregados.MultiSelect = False
            Me.dgvProveedoresAgregados.Name = "dgvProveedoresAgregados"
            Me.dgvProveedoresAgregados.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedoresAgregados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvProveedoresAgregados.RowHeadersVisible = False
            Me.dgvProveedoresAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedoresAgregados.Size = New System.Drawing.Size(1012, 190)
            Me.dgvProveedoresAgregados.TabIndex = 81
            '
            'dgvProveedor
            '
            Me.dgvProveedor.AllowUserToAddRows = False
            Me.dgvProveedor.AllowUserToDeleteRows = False
            Me.dgvProveedor.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvProveedor.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnIdProveedor, Me.ColummRuc, Me.ColumnNombre, Me.ColumnIdItem, Me.ColumnCódigo, Me.ColumnItem})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedor.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvProveedor.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedor.Location = New System.Drawing.Point(6, 116)
            Me.dgvProveedor.MultiSelect = False
            Me.dgvProveedor.Name = "dgvProveedor"
            Me.dgvProveedor.ReadOnly = True
            Me.dgvProveedor.RowHeadersVisible = False
            Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedor.Size = New System.Drawing.Size(1013, 161)
            Me.dgvProveedor.TabIndex = 77
            '
            'ColumnIdProveedor
            '
            Me.ColumnIdProveedor.HeaderText = "ID"
            Me.ColumnIdProveedor.Name = "ColumnIdProveedor"
            Me.ColumnIdProveedor.ReadOnly = True
            '
            'ColummRuc
            '
            Me.ColummRuc.HeaderText = "RUC"
            Me.ColummRuc.Name = "ColummRuc"
            Me.ColummRuc.ReadOnly = True
            '
            'ColumnNombre
            '
            Me.ColumnNombre.HeaderText = "PROVEEDOR"
            Me.ColumnNombre.Name = "ColumnNombre"
            Me.ColumnNombre.ReadOnly = True
            Me.ColumnNombre.Width = 300
            '
            'ColumnIdItem
            '
            Me.ColumnIdItem.HeaderText = "ID"
            Me.ColumnIdItem.Name = "ColumnIdItem"
            Me.ColumnIdItem.ReadOnly = True
            '
            'ColumnCódigo
            '
            Me.ColumnCódigo.HeaderText = "CÓDIGO"
            Me.ColumnCódigo.Name = "ColumnCódigo"
            Me.ColumnCódigo.ReadOnly = True
            '
            'ColumnItem
            '
            Me.ColumnItem.HeaderText = "ITEM"
            Me.ColumnItem.Name = "ColumnItem"
            Me.ColumnItem.ReadOnly = True
            Me.ColumnItem.Width = 300
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtRuc)
            Me.GroupBox1.Controls.Add(Me.lblNombreProveedor)
            Me.GroupBox1.Controls.Add(Me.txtBuscarNombreProveedor)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(514, 34)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(504, 59)
            Me.GroupBox1.TabIndex = 76
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA PROVEDOR"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(364, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(32, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "RUC:"
            '
            'txtRuc
            '
            Me.txtRuc.BackColor = System.Drawing.Color.White
            Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRuc.Enabled = False
            Me.txtRuc.ForeColor = System.Drawing.Color.Black
            Me.txtRuc.Location = New System.Drawing.Point(364, 27)
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.Size = New System.Drawing.Size(134, 22)
            Me.txtRuc.TabIndex = 4
            Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNombreProveedor
            '
            Me.lblNombreProveedor.AutoSize = True
            Me.lblNombreProveedor.Location = New System.Drawing.Point(6, 13)
            Me.lblNombreProveedor.Name = "lblNombreProveedor"
            Me.lblNombreProveedor.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreProveedor.TabIndex = 3
            Me.lblNombreProveedor.Text = "NOMBRE:"
            '
            'txtBuscarNombreProveedor
            '
            Me.txtBuscarNombreProveedor.BackColor = System.Drawing.Color.White
            Me.txtBuscarNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarNombreProveedor.ForeColor = System.Drawing.Color.Black
            Me.txtBuscarNombreProveedor.Location = New System.Drawing.Point(9, 27)
            Me.txtBuscarNombreProveedor.Name = "txtBuscarNombreProveedor"
            Me.txtBuscarNombreProveedor.Size = New System.Drawing.Size(351, 22)
            Me.txtBuscarNombreProveedor.TabIndex = 2
            '
            'gbBusquedaItem
            '
            Me.gbBusquedaItem.BackColor = System.Drawing.Color.White
            Me.gbBusquedaItem.Controls.Add(Me.Label2)
            Me.gbBusquedaItem.Controls.Add(Me.txtCódigoItem)
            Me.gbBusquedaItem.Controls.Add(Me.lblNombreItem)
            Me.gbBusquedaItem.Controls.Add(Me.txtBuscarDetalleItems)
            Me.gbBusquedaItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusquedaItem.Location = New System.Drawing.Point(6, 34)
            Me.gbBusquedaItem.Name = "gbBusquedaItem"
            Me.gbBusquedaItem.Size = New System.Drawing.Size(504, 59)
            Me.gbBusquedaItem.TabIndex = 75
            Me.gbBusquedaItem.TabStop = False
            Me.gbBusquedaItem.Text = "BUSQUEDA ITEM"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(360, 12)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "CÓDIGO:"
            '
            'txtCódigoItem
            '
            Me.txtCódigoItem.BackColor = System.Drawing.Color.White
            Me.txtCódigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCódigoItem.Enabled = False
            Me.txtCódigoItem.ForeColor = System.Drawing.Color.Black
            Me.txtCódigoItem.Location = New System.Drawing.Point(363, 27)
            Me.txtCódigoItem.Name = "txtCódigoItem"
            Me.txtCódigoItem.Size = New System.Drawing.Size(134, 22)
            Me.txtCódigoItem.TabIndex = 4
            Me.txtCódigoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblNombreItem
            '
            Me.lblNombreItem.AutoSize = True
            Me.lblNombreItem.Location = New System.Drawing.Point(6, 13)
            Me.lblNombreItem.Name = "lblNombreItem"
            Me.lblNombreItem.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreItem.TabIndex = 3
            Me.lblNombreItem.Text = "NOMBRE:"
            '
            'txtBuscarDetalleItems
            '
            Me.txtBuscarDetalleItems.BackColor = System.Drawing.Color.White
            Me.txtBuscarDetalleItems.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarDetalleItems.ForeColor = System.Drawing.Color.Black
            Me.txtBuscarDetalleItems.Location = New System.Drawing.Point(6, 27)
            Me.txtBuscarDetalleItems.Name = "txtBuscarDetalleItems"
            Me.txtBuscarDetalleItems.Size = New System.Drawing.Size(354, 22)
            Me.txtBuscarDetalleItems.TabIndex = 2
            '
            'tpListadoProveedores
            '
            Me.tpListadoProveedores.Controls.Add(Me.MenuStrip1)
            Me.tpListadoProveedores.Controls.Add(Me.Label7)
            Me.tpListadoProveedores.Controls.Add(Me.Label6)
            Me.tpListadoProveedores.Controls.Add(Me.dgvProveedores)
            Me.tpListadoProveedores.Controls.Add(Me.dgvItems)
            Me.tpListadoProveedores.Location = New System.Drawing.Point(4, 22)
            Me.tpListadoProveedores.Name = "tpListadoProveedores"
            Me.tpListadoProveedores.Padding = New System.Windows.Forms.Padding(3)
            Me.tpListadoProveedores.Size = New System.Drawing.Size(1026, 501)
            Me.tpListadoProveedores.TabIndex = 1
            Me.tpListadoProveedores.Text = "LISTADO"
            Me.tpListadoProveedores.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 20)
            Me.ToolStripMenuItem1.Text = "LISTAR TODOS"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 269)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(194, 15)
            Me.Label7.TabIndex = 85
            Me.Label7.Text = "LISTADO DE PROVEEDORES"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(6, 34)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(176, 15)
            Me.Label6.TabIndex = 84
            Me.Label6.Text = "LISTADO DE PRODUCTOS"
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DodgerBlue
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvProveedores.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedores.Location = New System.Drawing.Point(6, 284)
            Me.dgvProveedores.MultiSelect = False
            Me.dgvProveedores.Name = "dgvProveedores"
            Me.dgvProveedores.ReadOnly = True
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvProveedores.RowHeadersVisible = False
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvProveedores.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedores.Size = New System.Drawing.Size(1012, 212)
            Me.dgvProveedores.TabIndex = 83
            '
            'dgvItems
            '
            Me.dgvItems.AllowUserToAddRows = False
            Me.dgvItems.AllowUserToDeleteRows = False
            Me.dgvItems.AllowUserToResizeColumns = False
            Me.dgvItems.AllowUserToResizeRows = False
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvItems.BackgroundColor = System.Drawing.Color.White
            Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DodgerBlue
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvItems.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvItems.Location = New System.Drawing.Point(6, 50)
            Me.dgvItems.MultiSelect = False
            Me.dgvItems.Name = "dgvItems"
            Me.dgvItems.ReadOnly = True
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvItems.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvItems.Size = New System.Drawing.Size(1012, 216)
            Me.dgvItems.TabIndex = 82
            '
            'FormAsignarProveedorAItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1037, 530)
            Me.Controls.Add(Me.tcDetalleProveedorItem)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAsignarProveedorAItem"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ASIGNAR PROVEEDORES A ITEMS DE PRODUCTOS"
            Me.tcDetalleProveedorItem.ResumeLayout(False)
            Me.tpMantenimientos.ResumeLayout(False)
            Me.tpMantenimientos.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.dgvProveedoresAgregados, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbBusquedaItem.ResumeLayout(False)
            Me.gbBusquedaItem.PerformLayout()
            Me.tpListadoProveedores.ResumeLayout(False)
            Me.tpListadoProveedores.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents tcDetalleProveedorItem As System.Windows.Forms.TabControl
        Friend WithEvents tpMantenimientos As System.Windows.Forms.TabPage
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvProveedoresAgregados As System.Windows.Forms.DataGridView
        Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreProveedor As System.Windows.Forms.Label
        Friend WithEvents txtBuscarNombreProveedor As System.Windows.Forms.TextBox
        Friend WithEvents gbBusquedaItem As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCódigoItem As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreItem As System.Windows.Forms.Label
        Friend WithEvents txtBuscarDetalleItems As System.Windows.Forms.TextBox
        Friend WithEvents tpListadoProveedores As System.Windows.Forms.TabPage
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
        Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAgregarProveedor As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnEliminarProveedor As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ColumnIdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColummRuc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColumnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColumnIdItem As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColumnCódigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ColumnItem As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace