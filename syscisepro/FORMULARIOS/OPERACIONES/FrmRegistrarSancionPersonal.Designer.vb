Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmRegistrarSancionPersonal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarSancionPersonal))
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnNormalF = New System.Windows.Forms.Button()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.dgvNormal = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgvSanciones = New System.Windows.Forms.DataGridView()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.txtMultador = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.NumericUpDown()
            Me.txtCant = New System.Windows.Forms.NumericUpDown()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.bntSanciones = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.txtValor = New System.Windows.Forms.TextBox()
            Me.txtIdSancion = New System.Windows.Forms.TextBox()
            Me.txtSancion = New System.Windows.Forms.TextBox()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.txtIdPuesto = New System.Windows.Forms.TextBox()
            Me.txtUbicacionPuesto = New System.Windows.Forms.TextBox()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.btnPersonalEntra = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgvNormal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtArea
            '
            Me.txtArea.BackColor = System.Drawing.Color.White
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArea.Location = New System.Drawing.Point(251, 30)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(205, 21)
            Me.txtArea.TabIndex = 197
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 279)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Button1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnNormalF)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.TabControl1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListView1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(569, 303)
            Me.KryptonGroupBox1.TabIndex = 300
            Me.KryptonGroupBox1.Values.Heading = "Registro de Multas"
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(468, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(92, 29)
            Me.Button1.TabIndex = 307
            Me.Button1.Text = "Agrupado"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'btnNormalF
            '
            Me.btnNormalF.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.btnNormalF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.btnNormalF.FlatAppearance.BorderSize = 0
            Me.btnNormalF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNormalF.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNormalF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.btnNormalF.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnNormalF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNormalF.Location = New System.Drawing.Point(383, 3)
            Me.btnNormalF.Name = "btnNormalF"
            Me.btnNormalF.Size = New System.Drawing.Size(75, 29)
            Me.btnNormalF.TabIndex = 306
            Me.btnNormalF.Text = "Normal"
            Me.btnNormalF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNormalF.UseVisualStyleBackColor = False
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(3, 38)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(564, 243)
            Me.TabControl1.TabIndex = 305
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.dgvNormal)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(556, 217)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Normal"
            '
            'dgvNormal
            '
            Me.dgvNormal.AllowUserToAddRows = False
            Me.dgvNormal.AllowUserToDeleteRows = False
            Me.dgvNormal.AllowUserToResizeColumns = False
            Me.dgvNormal.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
            Me.dgvNormal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNormal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNormal.Location = New System.Drawing.Point(3, 3)
            Me.dgvNormal.Name = "dgvNormal"
            Me.dgvNormal.RowHeadersVisible = False
            Me.dgvNormal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNormal.Size = New System.Drawing.Size(550, 211)
            Me.dgvNormal.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(243, Byte), Integer))
            Me.dgvNormal.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
            Me.dgvNormal.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White
            Me.dgvNormal.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.dgvNormal.TabIndex = 205
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.dgvSanciones)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(556, 217)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Agrupado"
            '
            'dgvSanciones
            '
            Me.dgvSanciones.AllowUserToAddRows = False
            Me.dgvSanciones.AllowUserToDeleteRows = False
            Me.dgvSanciones.AllowUserToOrderColumns = True
            Me.dgvSanciones.AllowUserToResizeRows = False
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSanciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSanciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(243, Byte), Integer))
            Me.dgvSanciones.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvSanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSanciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvSanciones.Location = New System.Drawing.Point(3, 3)
            Me.dgvSanciones.Name = "dgvSanciones"
            Me.dgvSanciones.RowHeadersVisible = False
            Me.dgvSanciones.ShowEditingIcon = False
            Me.dgvSanciones.Size = New System.Drawing.Size(550, 211)
            Me.dgvSanciones.TabIndex = 0
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(269, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(18, 20)
            Me.KryptonLabel3.TabIndex = 302
            Me.KryptonLabel3.Values.Text = "A"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(155, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel2.TabIndex = 301
            Me.KryptonLabel2.Values.Text = "De"
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(8, 4)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(143, 21)
            Me.txtFiltro.TabIndex = 291
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(185, 4)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(77, 22)
            Me.dtpFechaDesde.TabIndex = 299
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(295, 5)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(78, 22)
            Me.dtpFechaHasta.TabIndex = 2
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader13, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader10, Me.ColumnHeader14})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(174, 121)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(87, 67)
            Me.ListView1.TabIndex = 204
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            Me.ListView1.Visible = False
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 35
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "SANCION"
            Me.ColumnHeader4.Width = 0
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "IDS"
            Me.ColumnHeader13.Width = 0
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "FECHA"
            Me.ColumnHeader5.Width = 90
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "IDE"
            Me.ColumnHeader6.Width = 0
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "PERSONAL"
            Me.ColumnHeader2.Width = 200
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "CARGO"
            Me.ColumnHeader3.Width = 150
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "AREA"
            Me.ColumnHeader7.Width = 0
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "IDS"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "SITIO"
            Me.ColumnHeader9.Width = 240
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "VALOR"
            Me.ColumnHeader11.Width = 80
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "OBSERVACION"
            Me.ColumnHeader12.Width = 300
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "IDES"
            Me.ColumnHeader10.Width = 40
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "REGISTRADO"
            '
            'txtMultador
            '
            Me.txtMultador.BackColor = System.Drawing.Color.White
            Me.txtMultador.Enabled = False
            Me.txtMultador.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMultador.Location = New System.Drawing.Point(74, 169)
            Me.txtMultador.Name = "txtMultador"
            Me.txtMultador.Size = New System.Drawing.Size(259, 21)
            Me.txtMultador.TabIndex = 210
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.DecimalPlaces = 2
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(182, 143)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(52, 21)
            Me.txtTotal.TabIndex = 208
            '
            'txtCant
            '
            Me.txtCant.BackColor = System.Drawing.Color.White
            Me.txtCant.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCant.Location = New System.Drawing.Point(74, 142)
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(37, 21)
            Me.txtCant.TabIndex = 112
            '
            'dtpFecha
            '
            Me.dtpFecha.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.CustomFormat = "MMMM yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(182, 116)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(80, 21)
            Me.dtpFecha.TabIndex = 110
            '
            'bntSanciones
            '
            Me.bntSanciones.BackColor = System.Drawing.Color.Transparent
            Me.bntSanciones.Enabled = False
            Me.bntSanciones.FlatAppearance.BorderSize = 0
            Me.bntSanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntSanciones.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntSanciones.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntSanciones.Location = New System.Drawing.Point(462, 108)
            Me.bntSanciones.Name = "bntSanciones"
            Me.bntSanciones.Size = New System.Drawing.Size(26, 26)
            Me.bntSanciones.TabIndex = 111
            Me.bntSanciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntSanciones.UseVisualStyleBackColor = False
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(89, 193)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(242, 21)
            Me.txtObservacion.TabIndex = 113
            '
            'txtValor
            '
            Me.txtValor.BackColor = System.Drawing.Color.White
            Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValor.Enabled = False
            Me.txtValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValor.Location = New System.Drawing.Point(327, 141)
            Me.txtValor.Name = "txtValor"
            Me.txtValor.Size = New System.Drawing.Size(33, 21)
            Me.txtValor.TabIndex = 199
            '
            'txtIdSancion
            '
            Me.txtIdSancion.BackColor = System.Drawing.Color.White
            Me.txtIdSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdSancion.Enabled = False
            Me.txtIdSancion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdSancion.Location = New System.Drawing.Point(74, 116)
            Me.txtIdSancion.Name = "txtIdSancion"
            Me.txtIdSancion.Size = New System.Drawing.Size(55, 21)
            Me.txtIdSancion.TabIndex = 28
            '
            'txtSancion
            '
            Me.txtSancion.BackColor = System.Drawing.Color.White
            Me.txtSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSancion.Enabled = False
            Me.txtSancion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSancion.Location = New System.Drawing.Point(327, 114)
            Me.txtSancion.Name = "txtSancion"
            Me.txtSancion.Size = New System.Drawing.Size(129, 21)
            Me.txtSancion.TabIndex = 0
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(74, 88)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(381, 21)
            Me.txtCliente.TabIndex = 201
            '
            'txtIdPuesto
            '
            Me.txtIdPuesto.BackColor = System.Drawing.Color.White
            Me.txtIdPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPuesto.Enabled = False
            Me.txtIdPuesto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPuesto.Location = New System.Drawing.Point(74, 62)
            Me.txtIdPuesto.Name = "txtIdPuesto"
            Me.txtIdPuesto.Size = New System.Drawing.Size(37, 21)
            Me.txtIdPuesto.TabIndex = 28
            '
            'txtUbicacionPuesto
            '
            Me.txtUbicacionPuesto.BackColor = System.Drawing.Color.White
            Me.txtUbicacionPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacionPuesto.Enabled = False
            Me.txtUbicacionPuesto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacionPuesto.Location = New System.Drawing.Point(197, 62)
            Me.txtUbicacionPuesto.Name = "txtUbicacionPuesto"
            Me.txtUbicacionPuesto.Size = New System.Drawing.Size(259, 21)
            Me.txtUbicacionPuesto.TabIndex = 0
            '
            'txtCargo
            '
            Me.txtCargo.BackColor = System.Drawing.Color.White
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCargo.Location = New System.Drawing.Point(74, 30)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(126, 21)
            Me.txtCargo.TabIndex = 195
            '
            'btnPersonalEntra
            '
            Me.btnPersonalEntra.BackColor = System.Drawing.Color.Transparent
            Me.btnPersonalEntra.Enabled = False
            Me.btnPersonalEntra.FlatAppearance.BorderSize = 0
            Me.btnPersonalEntra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPersonalEntra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonalEntra.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnPersonalEntra.Location = New System.Drawing.Point(462, 0)
            Me.btnPersonalEntra.Name = "btnPersonalEntra"
            Me.btnPersonalEntra.Size = New System.Drawing.Size(26, 26)
            Me.btnPersonalEntra.TabIndex = 105
            Me.btnPersonalEntra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonalEntra.UseVisualStyleBackColor = False
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(74, 4)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(37, 21)
            Me.txtIdPersonal.TabIndex = 28
            '
            'txtPersonal
            '
            Me.txtPersonal.BackColor = System.Drawing.Color.White
            Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPersonal.Enabled = False
            Me.txtPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPersonal.Location = New System.Drawing.Point(197, 4)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(259, 21)
            Me.txtPersonal.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnAnular, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(569, 32)
            Me.MenuStrip1.TabIndex = 182
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
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
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
            'btnAnular
            '
            Me.btnAnular.Enabled = False
            Me.btnAnular.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(85, 28)
            Me.btnAnular.Text = "ANULAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(151, 586)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(339, 16)
            Me.Label1.TabIndex = 205
            Me.Label1.Text = "O REGISTRO(S) - TOTAL EN MULTAS: "
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(496, 585)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(66, 16)
            Me.Label2.TabIndex = 206
            Me.Label2.Text = "$ 0.00"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0.85R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 33)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtMultador)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtObservacion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.bntSanciones)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCant)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValor)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCliente)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFecha)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtArea)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtUbicacionPuesto)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdPuesto)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSancion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCargo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdSancion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnPersonalEntra)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(569, 243)
            Me.KryptonGroupBox2.TabIndex = 301
            Me.KryptonGroupBox2.Values.Heading = "Datos"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(5, 192)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel17.TabIndex = 212
            Me.KryptonLabel17.Values.Text = "Observacion"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(269, 143)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel16.TabIndex = 211
            Me.KryptonLabel16.Values.Text = "Valor"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(5, 166)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel15.TabIndex = 209
            Me.KryptonLabel15.Values.Text = "Registro"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(129, 142)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel14.TabIndex = 206
            Me.KryptonLabel14.Values.Text = "Total"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(5, 140)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(36, 20)
            Me.KryptonLabel13.TabIndex = 205
            Me.KryptonLabel13.Values.Text = "Cant"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(269, 114)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel12.TabIndex = 204
            Me.KryptonLabel12.Values.Text = "Sancion"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(132, 116)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel11.TabIndex = 203
            Me.KryptonLabel11.Values.Text = "Fecha"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(5, 114)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel10.TabIndex = 202
            Me.KryptonLabel10.Values.Text = "Id Sancion"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(5, 88)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel9.TabIndex = 200
            Me.KryptonLabel9.Values.Text = "Cliente"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(118, 62)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel8.TabIndex = 199
            Me.KryptonLabel8.Values.Text = "Ubicacion"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(5, 62)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel7.TabIndex = 198
            Me.KryptonLabel7.Values.Text = "Id Sitio"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(209, 29)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(36, 20)
            Me.KryptonLabel6.TabIndex = 196
            Me.KryptonLabel6.Values.Text = "Area"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(5, 30)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel5.TabIndex = 106
            Me.KryptonLabel5.Values.Text = "Cargo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(119, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel4.TabIndex = 29
            Me.KryptonLabel4.Values.Text = "Nombres"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'FrmRegistrarSancionPersonal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(569, 610)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmRegistrarSancionPersonal"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "SANCIONES AL PERSONAL"
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.dgvNormal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtIdPuesto As System.Windows.Forms.TextBox
        Friend WithEvents txtUbicacionPuesto As System.Windows.Forms.TextBox
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents btnPersonalEntra As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents txtValor As System.Windows.Forms.TextBox
        Friend WithEvents txtIdSancion As System.Windows.Forms.TextBox
        Friend WithEvents txtSancion As System.Windows.Forms.TextBox
        Friend WithEvents bntSanciones As System.Windows.Forms.Button
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtCant As System.Windows.Forms.NumericUpDown
        Friend WithEvents dgvSanciones As System.Windows.Forms.DataGridView
        Friend WithEvents txtMultador As TextBox
        Friend WithEvents ColumnHeader14 As ColumnHeader
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvNormal As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents btnNormalF As Button
        Friend WithEvents Button1 As Button
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace