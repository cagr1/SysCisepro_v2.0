Namespace FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormCuentasPorPagar
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCuentasPorPagar))
            Me.dgvCuentasPorPagar = New System.Windows.Forms.DataGridView()
            Me.txtTotalCuentasPorPagar = New System.Windows.Forms.TextBox()
            Me.txtTotalAbonado = New System.Windows.Forms.TextBox()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.rbPorCliente = New System.Windows.Forms.RadioButton()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.rbGeneral = New System.Windows.Forms.RadioButton()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.ChkTodos = New System.Windows.Forms.CheckBox()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.lblRucProveedorGeneral = New System.Windows.Forms.Label()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIdComprobanteEgresoBanco = New System.Windows.Forms.Label()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.btnBuscarAcumulado = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.dtpHastaAcu = New System.Windows.Forms.DateTimePicker()
            Me.rbClienteAcu = New System.Windows.Forms.RadioButton()
            Me.dtpDesdeAcu = New System.Windows.Forms.DateTimePicker()
            Me.rbGeneralAcu = New System.Windows.Forms.RadioButton()
            Me.dgvProveedorAcumulado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvProveedorAcumulado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvCuentasPorPagar
            '
            Me.dgvCuentasPorPagar.AllowUserToAddRows = False
            Me.dgvCuentasPorPagar.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentasPorPagar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCuentasPorPagar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvCuentasPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvCuentasPorPagar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentasPorPagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCuentasPorPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCuentasPorPagar.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCuentasPorPagar.Location = New System.Drawing.Point(6, 82)
            Me.dgvCuentasPorPagar.MultiSelect = False
            Me.dgvCuentasPorPagar.Name = "dgvCuentasPorPagar"
            Me.dgvCuentasPorPagar.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCuentasPorPagar.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvCuentasPorPagar.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentasPorPagar.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvCuentasPorPagar.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvCuentasPorPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCuentasPorPagar.Size = New System.Drawing.Size(896, 267)
            Me.dgvCuentasPorPagar.TabIndex = 48
            '
            'txtTotalCuentasPorPagar
            '
            Me.txtTotalCuentasPorPagar.BackColor = System.Drawing.Color.White
            Me.txtTotalCuentasPorPagar.Enabled = False
            Me.txtTotalCuentasPorPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalCuentasPorPagar.Location = New System.Drawing.Point(753, 8)
            Me.txtTotalCuentasPorPagar.Name = "txtTotalCuentasPorPagar"
            Me.txtTotalCuentasPorPagar.ReadOnly = True
            Me.txtTotalCuentasPorPagar.Size = New System.Drawing.Size(77, 21)
            Me.txtTotalCuentasPorPagar.TabIndex = 0
            Me.txtTotalCuentasPorPagar.Text = "0.00"
            Me.txtTotalCuentasPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalAbonado
            '
            Me.txtTotalAbonado.BackColor = System.Drawing.Color.White
            Me.txtTotalAbonado.Enabled = False
            Me.txtTotalAbonado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalAbonado.Location = New System.Drawing.Point(561, 36)
            Me.txtTotalAbonado.Name = "txtTotalAbonado"
            Me.txtTotalAbonado.ReadOnly = True
            Me.txtTotalAbonado.Size = New System.Drawing.Size(75, 21)
            Me.txtTotalAbonado.TabIndex = 10
            Me.txtTotalAbonado.Text = "0.00"
            Me.txtTotalAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.BackColor = System.Drawing.Color.White
            Me.txtTotalSubtotal.Enabled = False
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(70, 8)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.ReadOnly = True
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(79, 21)
            Me.txtTotalSubtotal.TabIndex = 8
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.BackColor = System.Drawing.Color.White
            Me.txtTotalIVA.Enabled = False
            Me.txtTotalIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(70, 36)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.ReadOnly = True
            Me.txtTotalIVA.Size = New System.Drawing.Size(79, 21)
            Me.txtTotalIVA.TabIndex = 6
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Enabled = False
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(317, 8)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.ReadOnly = True
            Me.txtTotalFacturas.Size = New System.Drawing.Size(91, 21)
            Me.txtTotalFacturas.TabIndex = 4
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(317, 36)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.ReadOnly = True
            Me.txtTotalRetencion.Size = New System.Drawing.Size(91, 21)
            Me.txtTotalRetencion.TabIndex = 2
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Enabled = False
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(561, 8)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.ReadOnly = True
            Me.txtTotalACobrar.Size = New System.Drawing.Size(75, 21)
            Me.txtTotalACobrar.TabIndex = 0
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(910, 32)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(87, 28)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEASIENTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(115, 28)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE PDF"
            '
            'rbPorCliente
            '
            Me.rbPorCliente.AutoSize = True
            Me.rbPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPorCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPorCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPorCliente.Location = New System.Drawing.Point(89, 24)
            Me.rbPorCliente.Name = "rbPorCliente"
            Me.rbPorCliente.Size = New System.Drawing.Size(75, 17)
            Me.rbPorCliente.TabIndex = 3
            Me.rbPorCliente.Text = "Proveedor"
            Me.rbPorCliente.UseVisualStyleBackColor = False
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(267, 24)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(306, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'rbGeneral
            '
            Me.rbGeneral.AutoSize = True
            Me.rbGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneral.Checked = True
            Me.rbGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneral.Location = New System.Drawing.Point(5, 23)
            Me.rbGeneral.Name = "rbGeneral"
            Me.rbGeneral.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneral.TabIndex = 2
            Me.rbGeneral.TabStop = True
            Me.rbGeneral.Text = "General"
            Me.rbGeneral.UseVisualStyleBackColor = False
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(340, 7)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'ChkTodos
            '
            Me.ChkTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ChkTodos.CheckAlign = System.Drawing.ContentAlignment.TopLeft
            Me.ChkTodos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ChkTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.ChkTodos.Location = New System.Drawing.Point(179, 24)
            Me.ChkTodos.Name = "ChkTodos"
            Me.ChkTodos.Size = New System.Drawing.Size(90, 17)
            Me.ChkTodos.TabIndex = 4
            Me.ChkTodos.Text = "Mostrar todas"
            Me.ChkTodos.UseVisualStyleBackColor = False
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(642, 23)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(86, 21)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(267, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel1.TabIndex = 5
            Me.KryptonLabel1.Values.Text = "Proveedor"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(394, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel2.TabIndex = 77
            Me.KryptonLabel2.Values.Text = "RUC"
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(779, 23)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 21)
            Me.dtpHasta.TabIndex = 1
            '
            'lblRucProveedorGeneral
            '
            Me.lblRucProveedorGeneral.AutoSize = True
            Me.lblRucProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblRucProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucProveedorGeneral.Location = New System.Drawing.Point(438, 7)
            Me.lblRucProveedorGeneral.Name = "lblRucProveedorGeneral"
            Me.lblRucProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblRucProveedorGeneral.TabIndex = 79
            Me.lblRucProveedorGeneral.Text = "..."
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(591, 21)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 80
            Me.KryptonLabel3.Values.Text = "Desde"
            '
            'lblIdComprobanteEgresoBanco
            '
            Me.lblIdComprobanteEgresoBanco.AutoSize = True
            Me.lblIdComprobanteEgresoBanco.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteEgresoBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteEgresoBanco.Location = New System.Drawing.Point(736, 0)
            Me.lblIdComprobanteEgresoBanco.Name = "lblIdComprobanteEgresoBanco"
            Me.lblIdComprobanteEgresoBanco.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteEgresoBanco.TabIndex = 3
            Me.lblIdComprobanteEgresoBanco.Text = "..."
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(732, 23)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel4.TabIndex = 81
            Me.KryptonLabel4.Values.Text = "Hasta"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(4, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteEgresoBanco)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblRucProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.ChkTodos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPorCliente)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(899, 77)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(7, 354)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalCuentasPorPagar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalAbonado)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalSubtotal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalIVA)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalACobrar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(895, 90)
            Me.KryptonGroupBox2.TabIndex = 199
            Me.KryptonGroupBox2.Values.Heading = "Valores"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(673, 7)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(71, 20)
            Me.KryptonLabel11.TabIndex = 16
            Me.KryptonLabel11.Values.Text = "Total Saldo"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(449, 36)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(91, 20)
            Me.KryptonLabel8.TabIndex = 15
            Me.KryptonLabel8.Values.Text = "Total Abonado"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(449, 8)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel7.TabIndex = 14
            Me.KryptonLabel7.Values.Text = "Total a Pagar"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(213, 34)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel6.TabIndex = 7
            Me.KryptonLabel6.Values.Text = "Total Retencion"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(213, 8)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(84, 20)
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "Total Compra"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(8, 34)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel9.TabIndex = 5
            Me.KryptonLabel9.Values.Text = "IVA"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(8, 8)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel10.TabIndex = 0
            Me.KryptonLabel10.Values.Text = "Subtotal"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(910, 508)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 200
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.dgvCuentasPorPagar)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(908, 479)
            Me.KryptonPage1.Text = "Busqueda"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "16A243614DD84F11FAB299014B080135"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.dgvProveedorAcumulado)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(908, 479)
            Me.KryptonPage2.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Acumulado"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "A188187A0F1140C0E28DD9959FD4F774"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(11, 7)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnBuscarAcumulado)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtCliente)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpHastaAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbClienteAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpDesdeAcu)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbGeneralAcu)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(886, 55)
            Me.KryptonGroupBox3.TabIndex = 199
            Me.KryptonGroupBox3.Values.Heading = "Datos"
            '
            'btnBuscarAcumulado
            '
            Me.btnBuscarAcumulado.AutoSize = True
            Me.btnBuscarAcumulado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarAcumulado.Location = New System.Drawing.Point(473, -1)
            Me.btnBuscarAcumulado.Name = "btnBuscarAcumulado"
            Me.btnBuscarAcumulado.Size = New System.Drawing.Size(32, 32)
            Me.btnBuscarAcumulado.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarAcumulado.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarAcumulado.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnBuscarAcumulado.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.btnBuscarAcumulado.TabIndex = 250
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnBuscarAcumulado.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAcumulado.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAcumulado.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarAcumulado.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarAcumulado.Values.Text = ""
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(659, 5)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel12.TabIndex = 4
            Me.KryptonLabel12.Values.Text = "Hasta"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(519, 5)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel13.TabIndex = 3
            Me.KryptonLabel13.Values.Text = "Desde"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtCliente.Location = New System.Drawing.Point(152, 4)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(304, 20)
            Me.txtCliente.TabIndex = 2
            '
            'dtpHastaAcu
            '
            Me.dtpHastaAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHastaAcu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHastaAcu.Location = New System.Drawing.Point(705, 3)
            Me.dtpHastaAcu.Name = "dtpHastaAcu"
            Me.dtpHastaAcu.Size = New System.Drawing.Size(88, 21)
            Me.dtpHastaAcu.TabIndex = 1
            '
            'rbClienteAcu
            '
            Me.rbClienteAcu.AutoSize = True
            Me.rbClienteAcu.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbClienteAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbClienteAcu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbClienteAcu.Location = New System.Drawing.Point(75, 7)
            Me.rbClienteAcu.Name = "rbClienteAcu"
            Me.rbClienteAcu.Size = New System.Drawing.Size(60, 17)
            Me.rbClienteAcu.TabIndex = 1
            Me.rbClienteAcu.TabStop = True
            Me.rbClienteAcu.Text = "Cliente"
            Me.rbClienteAcu.UseVisualStyleBackColor = False
            '
            'dtpDesdeAcu
            '
            Me.dtpDesdeAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesdeAcu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesdeAcu.Location = New System.Drawing.Point(567, 4)
            Me.dtpDesdeAcu.Name = "dtpDesdeAcu"
            Me.dtpDesdeAcu.Size = New System.Drawing.Size(85, 21)
            Me.dtpDesdeAcu.TabIndex = 0
            Me.dtpDesdeAcu.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'rbGeneralAcu
            '
            Me.rbGeneralAcu.AutoSize = True
            Me.rbGeneralAcu.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbGeneralAcu.Checked = True
            Me.rbGeneralAcu.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbGeneralAcu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbGeneralAcu.Location = New System.Drawing.Point(9, 7)
            Me.rbGeneralAcu.Name = "rbGeneralAcu"
            Me.rbGeneralAcu.Size = New System.Drawing.Size(64, 17)
            Me.rbGeneralAcu.TabIndex = 0
            Me.rbGeneralAcu.TabStop = True
            Me.rbGeneralAcu.Text = "General"
            Me.rbGeneralAcu.UseVisualStyleBackColor = False
            '
            'dgvProveedorAcumulado
            '
            Me.dgvProveedorAcumulado.ColumnHeadersHeight = 35
            Me.dgvProveedorAcumulado.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed
            Me.dgvProveedorAcumulado.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList
            Me.dgvProveedorAcumulado.Location = New System.Drawing.Point(12, 66)
            Me.dgvProveedorAcumulado.Name = "dgvProveedorAcumulado"
            Me.dgvProveedorAcumulado.RowHeadersVisible = False
            Me.dgvProveedorAcumulado.RowHeadersWidth = 40
            Me.dgvProveedorAcumulado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedorAcumulado.Size = New System.Drawing.Size(885, 402)
            Me.dgvProveedorAcumulado.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvProveedorAcumulado.TabIndex = 200
            '
            'FormCuentasPorPagar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(910, 540)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormCuentasPorPagar"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CUENTAS POR PAGAR"
            CType(Me.dgvCuentasPorPagar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
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
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.dgvProveedorAcumulado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvCuentasPorPagar As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalCuentasPorPagar As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalAbonado As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalFacturas As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalACobrar As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents rbPorCliente As RadioButton
        Friend WithEvents txtNombreComercialProveedorGeneral As TextBox
        Friend WithEvents rbGeneral As RadioButton
        Friend WithEvents lblIdProveedorGeneral As Label
        Friend WithEvents ChkTodos As CheckBox
        Friend WithEvents dtpDesde As DateTimePicker
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpHasta As DateTimePicker
        Friend WithEvents lblRucProveedorGeneral As Label
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIdComprobanteEgresoBanco As Label
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnBuscarAcumulado As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtCliente As TextBox
        Friend WithEvents dtpHastaAcu As DateTimePicker
        Friend WithEvents rbClienteAcu As RadioButton
        Friend WithEvents dtpDesdeAcu As DateTimePicker
        Friend WithEvents rbGeneralAcu As RadioButton
        Friend WithEvents dgvProveedorAcumulado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    End Class
End Namespace