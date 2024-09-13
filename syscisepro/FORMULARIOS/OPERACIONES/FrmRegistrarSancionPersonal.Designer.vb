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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarSancionPersonal))
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
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
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtMultador = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.NumericUpDown()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtCant = New System.Windows.Forms.NumericUpDown()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.bntSanciones = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtValor = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtIdSancion = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtSancion = New System.Windows.Forms.TextBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.txtIdPuesto = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtUbicacionPuesto = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.btnPersonalEntra = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgvNormal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtArea
            '
            Me.txtArea.BackColor = System.Drawing.Color.White
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Location = New System.Drawing.Point(313, 41)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(255, 21)
            Me.txtArea.TabIndex = 197
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(270, 44)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 196
            Me.Label27.Text = "ÁREA:"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 272)
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
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(588, 386)
            Me.KryptonGroupBox1.TabIndex = 300
            Me.KryptonGroupBox1.Values.Heading = "Registro de Multas"
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
            Me.btnNormalF.Location = New System.Drawing.Point(398, 3)
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
            Me.TabControl1.Location = New System.Drawing.Point(4, 36)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(582, 323)
            Me.TabControl1.TabIndex = 305
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.dgvNormal)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(574, 297)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Normal"
            '
            'dgvNormal
            '
            Me.dgvNormal.AllowUserToAddRows = False
            Me.dgvNormal.AllowUserToDeleteRows = False
            Me.dgvNormal.AllowUserToResizeColumns = False
            Me.dgvNormal.AllowUserToResizeRows = False
            Me.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNormal.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNormal.Location = New System.Drawing.Point(3, 3)
            Me.dgvNormal.Name = "dgvNormal"
            Me.dgvNormal.RowHeadersVisible = False
            Me.dgvNormal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNormal.Size = New System.Drawing.Size(568, 291)
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
            Me.TabPage2.Size = New System.Drawing.Size(574, 297)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Agrupado"
            '
            'dgvSanciones
            '
            Me.dgvSanciones.AllowUserToAddRows = False
            Me.dgvSanciones.AllowUserToDeleteRows = False
            Me.dgvSanciones.AllowUserToOrderColumns = True
            Me.dgvSanciones.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSanciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSanciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvSanciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSanciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvSanciones.Location = New System.Drawing.Point(3, 3)
            Me.dgvSanciones.Name = "dgvSanciones"
            Me.dgvSanciones.RowHeadersVisible = False
            Me.dgvSanciones.ShowEditingIcon = False
            Me.dgvSanciones.Size = New System.Drawing.Size(568, 291)
            Me.dgvSanciones.TabIndex = 0
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(267, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(18, 20)
            Me.KryptonLabel3.TabIndex = 302
            Me.KryptonLabel3.Values.Text = "A"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(158, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel2.TabIndex = 301
            Me.KryptonLabel2.Values.Text = "De"
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFiltro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.dtpFechaDesde.Location = New System.Drawing.Point(291, 5)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(90, 22)
            Me.dtpFechaDesde.TabIndex = 299
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(183, 4)
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
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.txtMultador)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtTotal)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtCant)
            Me.GroupBox2.Controls.Add(Me.dtpFecha)
            Me.GroupBox2.Controls.Add(Me.Label31)
            Me.GroupBox2.Controls.Add(Me.bntSanciones)
            Me.GroupBox2.Controls.Add(Me.txtObservacion)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.txtValor)
            Me.GroupBox2.Controls.Add(Me.Label19)
            Me.GroupBox2.Controls.Add(Me.txtIdSancion)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.txtSancion)
            Me.GroupBox2.Controls.Add(Me.Label30)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(2, 174)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(586, 99)
            Me.GroupBox2.TabIndex = 203
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DATOS DE LA SANCIÓN / MULTA"
            '
            'txtMultador
            '
            Me.txtMultador.Enabled = False
            Me.txtMultador.Location = New System.Drawing.Point(126, 71)
            Me.txtMultador.Name = "txtMultador"
            Me.txtMultador.Size = New System.Drawing.Size(373, 21)
            Me.txtMultador.TabIndex = 210
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(13, 74)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(105, 13)
            Me.Label4.TabIndex = 209
            Me.Label4.Text = "REGISTRADO POR :"
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.DecimalPlaces = 2
            Me.txtTotal.Enabled = False
            Me.txtTotal.Location = New System.Drawing.Point(151, 44)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(77, 21)
            Me.txtTotal.TabIndex = 208
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(106, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(45, 13)
            Me.Label3.TabIndex = 207
            Me.Label3.Text = "TOTAL:"
            '
            'txtCant
            '
            Me.txtCant.BackColor = System.Drawing.Color.White
            Me.txtCant.Location = New System.Drawing.Point(46, 44)
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(55, 21)
            Me.txtCant.TabIndex = 112
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "MMMM yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(136, 15)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(108, 21)
            Me.dtpFecha.TabIndex = 110
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(89, 18)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(44, 13)
            Me.Label31.TabIndex = 205
            Me.Label31.Text = "FECHA:"
            '
            'bntSanciones
            '
            Me.bntSanciones.BackColor = System.Drawing.Color.White
            Me.bntSanciones.Enabled = False
            Me.bntSanciones.FlatAppearance.BorderSize = 0
            Me.bntSanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntSanciones.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntSanciones.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntSanciones.Location = New System.Drawing.Point(550, 11)
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
            Me.txtObservacion.Location = New System.Drawing.Point(339, 43)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(240, 21)
            Me.txtObservacion.TabIndex = 113
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(254, 46)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(85, 13)
            Me.Label18.TabIndex = 200
            Me.Label18.Text = "OBSERVACIÓN:"
            '
            'txtValor
            '
            Me.txtValor.BackColor = System.Drawing.Color.White
            Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValor.Enabled = False
            Me.txtValor.Location = New System.Drawing.Point(508, 15)
            Me.txtValor.Name = "txtValor"
            Me.txtValor.Size = New System.Drawing.Size(33, 21)
            Me.txtValor.TabIndex = 199
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(3, 48)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(41, 13)
            Me.Label19.TabIndex = 198
            Me.Label19.Text = "CANT.:"
            '
            'txtIdSancion
            '
            Me.txtIdSancion.BackColor = System.Drawing.Color.White
            Me.txtIdSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdSancion.Enabled = False
            Me.txtIdSancion.Location = New System.Drawing.Point(26, 16)
            Me.txtIdSancion.Name = "txtIdSancion"
            Me.txtIdSancion.Size = New System.Drawing.Size(55, 21)
            Me.txtIdSancion.TabIndex = 28
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(4, 21)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(20, 13)
            Me.Label20.TabIndex = 8
            Me.Label20.Text = "ID:"
            '
            'txtSancion
            '
            Me.txtSancion.BackColor = System.Drawing.Color.White
            Me.txtSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSancion.Enabled = False
            Me.txtSancion.Location = New System.Drawing.Point(339, 13)
            Me.txtSancion.Name = "txtSancion"
            Me.txtSancion.Size = New System.Drawing.Size(151, 21)
            Me.txtSancion.TabIndex = 0
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(254, 20)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(58, 13)
            Me.Label30.TabIndex = 3
            Me.Label30.Text = "SANCIÓN:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.txtCliente)
            Me.GroupBox3.Controls.Add(Me.Label28)
            Me.GroupBox3.Controls.Add(Me.txtIdPuesto)
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.txtUbicacionPuesto)
            Me.GroupBox3.Controls.Add(Me.Label23)
            Me.GroupBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(2, 104)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(586, 69)
            Me.GroupBox3.TabIndex = 194
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DATOS DEL PUESTO DE TRABAJO"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Location = New System.Drawing.Point(79, 43)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(435, 21)
            Me.txtCliente.TabIndex = 201
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(18, 46)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(53, 13)
            Me.Label28.TabIndex = 200
            Me.Label28.Text = "CLIENTE:"
            '
            'txtIdPuesto
            '
            Me.txtIdPuesto.BackColor = System.Drawing.Color.White
            Me.txtIdPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPuesto.Enabled = False
            Me.txtIdPuesto.Location = New System.Drawing.Point(44, 16)
            Me.txtIdPuesto.Name = "txtIdPuesto"
            Me.txtIdPuesto.Size = New System.Drawing.Size(37, 21)
            Me.txtIdPuesto.TabIndex = 28
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(18, 21)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(20, 13)
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "ID:"
            '
            'txtUbicacionPuesto
            '
            Me.txtUbicacionPuesto.BackColor = System.Drawing.Color.White
            Me.txtUbicacionPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacionPuesto.Enabled = False
            Me.txtUbicacionPuesto.Location = New System.Drawing.Point(170, 17)
            Me.txtUbicacionPuesto.Name = "txtUbicacionPuesto"
            Me.txtUbicacionPuesto.Size = New System.Drawing.Size(344, 21)
            Me.txtUbicacionPuesto.TabIndex = 0
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(101, 20)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(67, 13)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "UBICACIÓN:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtArea)
            Me.GroupBox1.Controls.Add(Me.Label27)
            Me.GroupBox1.Controls.Add(Me.txtCargo)
            Me.GroupBox1.Controls.Add(Me.Label25)
            Me.GroupBox1.Controls.Add(Me.btnPersonalEntra)
            Me.GroupBox1.Controls.Add(Me.txtIdPersonal)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.txtPersonal)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 33)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(588, 67)
            Me.GroupBox1.TabIndex = 183
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DE PERSONAL"
            '
            'txtCargo
            '
            Me.txtCargo.BackColor = System.Drawing.Color.White
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Location = New System.Drawing.Point(59, 41)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(204, 21)
            Me.txtCargo.TabIndex = 195
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(13, 44)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(47, 13)
            Me.Label25.TabIndex = 194
            Me.Label25.Text = "CARGO:"
            '
            'btnPersonalEntra
            '
            Me.btnPersonalEntra.BackColor = System.Drawing.Color.White
            Me.btnPersonalEntra.Enabled = False
            Me.btnPersonalEntra.FlatAppearance.BorderSize = 0
            Me.btnPersonalEntra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPersonalEntra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonalEntra.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnPersonalEntra.Location = New System.Drawing.Point(549, 10)
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
            Me.txtIdPersonal.Location = New System.Drawing.Point(59, 17)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(37, 21)
            Me.txtIdPersonal.TabIndex = 28
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(18, 19)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(20, 13)
            Me.Label22.TabIndex = 8
            Me.Label22.Text = "ID:"
            '
            'txtPersonal
            '
            Me.txtPersonal.BackColor = System.Drawing.Color.White
            Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPersonal.Enabled = False
            Me.txtPersonal.Location = New System.Drawing.Point(173, 17)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(309, 21)
            Me.txtPersonal.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(108, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(63, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "NOMBRES:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnAnular, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(588, 32)
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
            Me.Label1.Location = New System.Drawing.Point(143, 662)
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
            Me.Label2.Location = New System.Drawing.Point(502, 663)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(66, 16)
            Me.Label2.TabIndex = 206
            Me.Label2.Text = "$ 0.00"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.Button1.Location = New System.Drawing.Point(481, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(92, 29)
            Me.Button1.TabIndex = 307
            Me.Button1.Text = "Agrupado"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'FrmRegistrarSancionPersonal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(588, 682)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
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
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtIdPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtUbicacionPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents btnPersonalEntra As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtValor As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtIdSancion As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtSancion As System.Windows.Forms.TextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
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
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtCant As System.Windows.Forms.NumericUpDown
        Friend WithEvents dgvSanciones As System.Windows.Forms.DataGridView
        Friend WithEvents Label4 As Label
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
    End Class
End Namespace