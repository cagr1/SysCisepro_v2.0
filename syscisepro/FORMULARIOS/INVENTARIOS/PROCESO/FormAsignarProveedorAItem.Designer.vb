Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAsignarProveedorAItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsignarProveedorAItem))
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvProveedor = New System.Windows.Forms.DataGridView()
            Me.ColumnIdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColummRuc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnIdItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnCódigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ColumnItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvProveedoresAgregados = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvItems = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox6 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvProveedores = New System.Windows.Forms.DataGridView()
            Me.tcDetalleProveedorItem.SuspendLayout()
            Me.tpMantenimientos.SuspendLayout()
            Me.msKardex.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbBusquedaItem.SuspendLayout()
            Me.tpListadoProveedores.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.dgvProveedoresAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.tcDetalleProveedorItem.Location = New System.Drawing.Point(127, 120)
            Me.tcDetalleProveedorItem.Name = "tcDetalleProveedorItem"
            Me.tcDetalleProveedorItem.SelectedIndex = 0
            Me.tcDetalleProveedorItem.Size = New System.Drawing.Size(588, 408)
            Me.tcDetalleProveedorItem.TabIndex = 0
            '
            'tpMantenimientos
            '
            Me.tpMantenimientos.Controls.Add(Me.Label5)
            Me.tpMantenimientos.Controls.Add(Me.Label1)
            Me.tpMantenimientos.Controls.Add(Me.GroupBox1)
            Me.tpMantenimientos.Controls.Add(Me.gbBusquedaItem)
            Me.tpMantenimientos.Location = New System.Drawing.Point(4, 22)
            Me.tpMantenimientos.Name = "tpMantenimientos"
            Me.tpMantenimientos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpMantenimientos.Size = New System.Drawing.Size(580, 382)
            Me.tpMantenimientos.TabIndex = 0
            Me.tpMantenimientos.Text = "MANTENIMIENTOS"
            Me.tpMantenimientos.UseVisualStyleBackColor = True
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarProveedor, Me.btnGuardar, Me.btnEliminarProveedor, Me.btnReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1035, 32)
            Me.msKardex.TabIndex = 182
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnAgregarProveedor
            '
            Me.btnAgregarProveedor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarProveedor.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
            Me.btnAgregarProveedor.Size = New System.Drawing.Size(92, 28)
            Me.btnAgregarProveedor.Text = "AGREGAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnEliminarProveedor
            '
            Me.btnEliminarProveedor.Enabled = False
            Me.btnEliminarProveedor.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarProveedor.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminarProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnEliminarProveedor.Name = "btnEliminarProveedor"
            Me.btnEliminarProveedor.Size = New System.Drawing.Size(99, 28)
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
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 288)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(254, 13)
            Me.Label5.TabIndex = 83
            Me.Label5.Text = "LISTADO DE PROVEDORES AGREGADOS AL ITEM"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(9, 99)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(278, 13)
            Me.Label1.TabIndex = 82
            Me.Label1.Text = "LISTADO DE PROVEEDORES EN COLA PARA AGREGAR"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.lblNombreProveedor)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(514, 38)
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
            Me.Label3.Size = New System.Drawing.Size(31, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "RUC:"
            '
            'txtRuc
            '
            Me.txtRuc.BackColor = System.Drawing.Color.White
            Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRuc.Enabled = False
            Me.txtRuc.ForeColor = System.Drawing.Color.Black
            Me.txtRuc.Location = New System.Drawing.Point(380, 4)
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.Size = New System.Drawing.Size(107, 22)
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
            Me.txtBuscarNombreProveedor.Location = New System.Drawing.Point(65, 3)
            Me.txtBuscarNombreProveedor.Name = "txtBuscarNombreProveedor"
            Me.txtBuscarNombreProveedor.Size = New System.Drawing.Size(261, 22)
            Me.txtBuscarNombreProveedor.TabIndex = 2
            '
            'gbBusquedaItem
            '
            Me.gbBusquedaItem.BackColor = System.Drawing.Color.White
            Me.gbBusquedaItem.Controls.Add(Me.Label2)
            Me.gbBusquedaItem.Controls.Add(Me.lblNombreItem)
            Me.gbBusquedaItem.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusquedaItem.Location = New System.Drawing.Point(6, 38)
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
            Me.Label2.Size = New System.Drawing.Size(51, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "CÓDIGO:"
            '
            'txtCódigoItem
            '
            Me.txtCódigoItem.BackColor = System.Drawing.Color.White
            Me.txtCódigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCódigoItem.Enabled = False
            Me.txtCódigoItem.ForeColor = System.Drawing.Color.Black
            Me.txtCódigoItem.Location = New System.Drawing.Point(383, 4)
            Me.txtCódigoItem.Name = "txtCódigoItem"
            Me.txtCódigoItem.Size = New System.Drawing.Size(107, 22)
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
            Me.txtBuscarDetalleItems.Location = New System.Drawing.Point(63, 4)
            Me.txtBuscarDetalleItems.Name = "txtBuscarDetalleItems"
            Me.txtBuscarDetalleItems.Size = New System.Drawing.Size(261, 22)
            Me.txtBuscarDetalleItems.TabIndex = 2
            '
            'tpListadoProveedores
            '
            Me.tpListadoProveedores.Controls.Add(Me.Label7)
            Me.tpListadoProveedores.Controls.Add(Me.Label6)
            Me.tpListadoProveedores.Location = New System.Drawing.Point(4, 22)
            Me.tpListadoProveedores.Name = "tpListadoProveedores"
            Me.tpListadoProveedores.Padding = New System.Windows.Forms.Padding(3)
            Me.tpListadoProveedores.Size = New System.Drawing.Size(1020, 501)
            Me.tpListadoProveedores.TabIndex = 1
            Me.tpListadoProveedores.Text = "LISTADO"
            Me.tpListadoProveedores.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1035, 32)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 269)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(141, 13)
            Me.Label7.TabIndex = 85
            Me.Label7.Text = "LISTADO DE PROVEEDORES"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(6, 37)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(129, 13)
            Me.Label6.TabIndex = 84
            Me.Label6.Text = "LISTADO DE PRODUCTOS"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(1037, 530)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 1
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox4)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.msKardex)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(1035, 503)
            Me.KryptonPage1.Text = "Mantenimiento"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "E821B399CE79482CA48449BC3984929B"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox6)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox5)
            Me.KryptonPage2.Controls.Add(Me.MenuStrip1)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(1035, 503)
            Me.KryptonPage2.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Listado"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "3BAFB33636E64986719658DC5BF59747"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(7, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCódigoItem)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtBuscarDetalleItems)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(506, 61)
            Me.KryptonGroupBox1.TabIndex = 183
            Me.KryptonGroupBox1.Values.Heading = "Busqueda Item"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Nombre"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(327, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel2.TabIndex = 3
            Me.KryptonLabel2.Values.Text = "Codigo"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(519, 37)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtRuc)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtBuscarNombreProveedor)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(505, 61)
            Me.KryptonGroupBox2.TabIndex = 184
            Me.KryptonGroupBox2.Values.Heading = "Busqueda Proveedor"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(340, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel3.TabIndex = 3
            Me.KryptonLabel3.Values.Text = "RUC"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(6, 4)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel4.TabIndex = 0
            Me.KryptonLabel4.Values.Text = "Nombre"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(7, 105)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvProveedor)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(1017, 150)
            Me.KryptonGroupBox3.TabIndex = 185
            Me.KryptonGroupBox3.Values.Heading = "Listado Proveedores en cola para agregar"
            '
            'dgvProveedor
            '
            Me.dgvProveedor.AllowUserToAddRows = False
            Me.dgvProveedor.AllowUserToDeleteRows = False
            Me.dgvProveedor.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvProveedor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvProveedor.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedor.Location = New System.Drawing.Point(0, 0)
            Me.dgvProveedor.MultiSelect = False
            Me.dgvProveedor.Name = "dgvProveedor"
            Me.dgvProveedor.ReadOnly = True
            Me.dgvProveedor.RowHeadersVisible = False
            Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedor.Size = New System.Drawing.Size(1013, 126)
            Me.dgvProveedor.TabIndex = 78
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
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(7, 261)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvProveedoresAgregados)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(1017, 229)
            Me.KryptonGroupBox4.TabIndex = 186
            Me.KryptonGroupBox4.Values.Heading = "Listado Proveedores agredagos al item"
            '
            'dgvProveedoresAgregados
            '
            Me.dgvProveedoresAgregados.AllowUserToAddRows = False
            Me.dgvProveedoresAgregados.AllowUserToDeleteRows = False
            Me.dgvProveedoresAgregados.AllowUserToResizeRows = False
            Me.dgvProveedoresAgregados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvProveedoresAgregados.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvProveedoresAgregados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvProveedoresAgregados.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedoresAgregados.Location = New System.Drawing.Point(0, 0)
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
            Me.dgvProveedoresAgregados.Size = New System.Drawing.Size(1013, 205)
            Me.dgvProveedoresAgregados.TabIndex = 82
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(9, 37)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dgvItems)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(1015, 189)
            Me.KryptonGroupBox5.TabIndex = 184
            Me.KryptonGroupBox5.Values.Heading = "Listado de Productos"
            '
            'dgvItems
            '
            Me.dgvItems.AllowUserToAddRows = False
            Me.dgvItems.AllowUserToDeleteRows = False
            Me.dgvItems.AllowUserToResizeColumns = False
            Me.dgvItems.AllowUserToResizeRows = False
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvItems.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvItems.Location = New System.Drawing.Point(0, 0)
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
            Me.dgvItems.Size = New System.Drawing.Size(1011, 165)
            Me.dgvItems.TabIndex = 83
            '
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.CaptionOverlap = 0R
            Me.KryptonGroupBox6.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(9, 230)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dgvProveedores)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(1015, 262)
            Me.KryptonGroupBox6.TabIndex = 185
            Me.KryptonGroupBox6.Values.Heading = "Listado de Proveedores"
            '
            'dgvProveedores
            '
            Me.dgvProveedores.AllowUserToAddRows = False
            Me.dgvProveedores.AllowUserToDeleteRows = False
            Me.dgvProveedores.AllowUserToResizeColumns = False
            Me.dgvProveedores.AllowUserToResizeRows = False
            Me.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvProveedores.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvProveedores.Location = New System.Drawing.Point(0, 0)
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
            Me.dgvProveedores.Size = New System.Drawing.Size(1011, 238)
            Me.dgvProveedores.TabIndex = 84
            '
            'FormAsignarProveedorAItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1037, 530)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.tcDetalleProveedorItem)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAsignarProveedorAItem"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ASIGNAR PROVEEDORES A ITEMS DE PRODUCTOS"
            Me.tcDetalleProveedorItem.ResumeLayout(False)
            Me.tpMantenimientos.ResumeLayout(False)
            Me.tpMantenimientos.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbBusquedaItem.ResumeLayout(False)
            Me.gbBusquedaItem.PerformLayout()
            Me.tpListadoProveedores.ResumeLayout(False)
            Me.tpListadoProveedores.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.KryptonPage2.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.dgvProveedoresAgregados, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.ResumeLayout(False)
            CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents tcDetalleProveedorItem As System.Windows.Forms.TabControl
        Friend WithEvents tpMantenimientos As System.Windows.Forms.TabPage
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
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
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAgregarProveedor As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnEliminarProveedor As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvProveedoresAgregados As DataGridView
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvProveedor As DataGridView
        Friend WithEvents ColumnIdProveedor As DataGridViewTextBoxColumn
        Friend WithEvents ColummRuc As DataGridViewTextBoxColumn
        Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
        Friend WithEvents ColumnIdItem As DataGridViewTextBoxColumn
        Friend WithEvents ColumnCódigo As DataGridViewTextBoxColumn
        Friend WithEvents ColumnItem As DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox6 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvProveedores As DataGridView
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvItems As DataGridView
    End Class
End Namespace