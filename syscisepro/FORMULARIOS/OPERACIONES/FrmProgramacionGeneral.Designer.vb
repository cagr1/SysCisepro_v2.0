Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProgramacionGeneral
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramacionGeneral))
            Me.btnNoSitiosProgramacion = New System.Windows.Forms.Button()
            Me.btnNoProgramacion = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.txtPo = New System.Windows.Forms.TextBox()
            Me.txtP8 = New System.Windows.Forms.TextBox()
            Me.txtP12 = New System.Windows.Forms.TextBox()
            Me.txtP24 = New System.Windows.Forms.TextBox()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtIdSitio = New System.Windows.Forms.TextBox()
            Me.txtSitio = New System.Windows.Forms.TextBox()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.cbmSitio = New System.Windows.Forms.ComboBox()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.txtNumHorario = New System.Windows.Forms.TextBox()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.cbmMotivo = New System.Windows.Forms.ComboBox()
            Me.dtpHastaP = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesdeP = New System.Windows.Forms.DateTimePicker()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.btnPersonal = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnMesAnterior = New System.Windows.Forms.ToolStripMenuItem()
            Me.crvSitios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIdHorario = New System.Windows.Forms.Label()
            Me.dtpADomingo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDDomingo = New System.Windows.Forms.DateTimePicker()
            Me.chkDomingo = New System.Windows.Forms.CheckBox()
            Me.dtpASabado = New System.Windows.Forms.DateTimePicker()
            Me.dtpDSabado = New System.Windows.Forms.DateTimePicker()
            Me.chkSabado = New System.Windows.Forms.CheckBox()
            Me.dtpAViernes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDViernes = New System.Windows.Forms.DateTimePicker()
            Me.chkViernes = New System.Windows.Forms.CheckBox()
            Me.dtpAJueves = New System.Windows.Forms.DateTimePicker()
            Me.dtpDJueves = New System.Windows.Forms.DateTimePicker()
            Me.chkJueves = New System.Windows.Forms.CheckBox()
            Me.dtpAMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.dtpDMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.chkMiercoles = New System.Windows.Forms.CheckBox()
            Me.dtpAMartes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDMartes = New System.Windows.Forms.DateTimePicker()
            Me.chkMartes = New System.Windows.Forms.CheckBox()
            Me.dtpALunes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDLunes = New System.Windows.Forms.DateTimePicker()
            Me.chkLunes = New System.Windows.Forms.CheckBox()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
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
            Me.SuspendLayout()
            '
            'btnNoSitiosProgramacion
            '
            Me.btnNoSitiosProgramacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnNoSitiosProgramacion.Enabled = False
            Me.btnNoSitiosProgramacion.FlatAppearance.BorderSize = 0
            Me.btnNoSitiosProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNoSitiosProgramacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.btnNoSitiosProgramacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.btnNoSitiosProgramacion.Image = Global.syscisepro.My.Resources.Resources.map_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnNoSitiosProgramacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNoSitiosProgramacion.Location = New System.Drawing.Point(736, 3)
            Me.btnNoSitiosProgramacion.Name = "btnNoSitiosProgramacion"
            Me.btnNoSitiosProgramacion.Size = New System.Drawing.Size(91, 26)
            Me.btnNoSitiosProgramacion.TabIndex = 206
            Me.btnNoSitiosProgramacion.Text = "SITIOS "
            Me.btnNoSitiosProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNoSitiosProgramacion.UseVisualStyleBackColor = False
            '
            'btnNoProgramacion
            '
            Me.btnNoProgramacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.btnNoProgramacion.Enabled = False
            Me.btnNoProgramacion.FlatAppearance.BorderSize = 0
            Me.btnNoProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNoProgramacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.btnNoProgramacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.btnNoProgramacion.Image = Global.syscisepro.My.Resources.Resources.group_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnNoProgramacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNoProgramacion.Location = New System.Drawing.Point(634, 3)
            Me.btnNoProgramacion.Name = "btnNoProgramacion"
            Me.btnNoProgramacion.Size = New System.Drawing.Size(96, 26)
            Me.btnNoProgramacion.TabIndex = 200
            Me.btnNoProgramacion.Text = "PERSONAL"
            Me.btnNoProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNoProgramacion.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.Transparent
            Me.btnAdd.Enabled = False
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAdd.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAdd.Location = New System.Drawing.Point(717, 56)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(26, 26)
            Me.btnAdd.TabIndex = 200
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'txtPo
            '
            Me.txtPo.BackColor = System.Drawing.Color.White
            Me.txtPo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPo.Enabled = False
            Me.txtPo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPo.Location = New System.Drawing.Point(782, 58)
            Me.txtPo.Name = "txtPo"
            Me.txtPo.Size = New System.Drawing.Size(39, 21)
            Me.txtPo.TabIndex = 214
            Me.txtPo.Text = "0"
            Me.txtPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP8
            '
            Me.txtP8.BackColor = System.Drawing.Color.White
            Me.txtP8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP8.Enabled = False
            Me.txtP8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtP8.Location = New System.Drawing.Point(675, 57)
            Me.txtP8.Name = "txtP8"
            Me.txtP8.Size = New System.Drawing.Size(39, 21)
            Me.txtP8.TabIndex = 212
            Me.txtP8.Text = "0"
            Me.txtP8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP12
            '
            Me.txtP12.BackColor = System.Drawing.Color.White
            Me.txtP12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP12.Enabled = False
            Me.txtP12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtP12.Location = New System.Drawing.Point(783, 30)
            Me.txtP12.Name = "txtP12"
            Me.txtP12.Size = New System.Drawing.Size(39, 21)
            Me.txtP12.TabIndex = 210
            Me.txtP12.Text = "0"
            Me.txtP12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP24
            '
            Me.txtP24.BackColor = System.Drawing.Color.White
            Me.txtP24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP24.Enabled = False
            Me.txtP24.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtP24.Location = New System.Drawing.Point(676, 30)
            Me.txtP24.Name = "txtP24"
            Me.txtP24.Size = New System.Drawing.Size(39, 21)
            Me.txtP24.TabIndex = 208
            Me.txtP24.Text = "0"
            Me.txtP24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(79, 57)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(475, 21)
            Me.txtCliente.TabIndex = 201
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.Transparent
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntPuesto.Location = New System.Drawing.Point(579, 25)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(28, 28)
            Me.bntPuesto.TabIndex = 193
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'txtIdSitio
            '
            Me.txtIdSitio.BackColor = System.Drawing.Color.White
            Me.txtIdSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdSitio.Enabled = False
            Me.txtIdSitio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdSitio.Location = New System.Drawing.Point(78, 31)
            Me.txtIdSitio.Name = "txtIdSitio"
            Me.txtIdSitio.Size = New System.Drawing.Size(56, 21)
            Me.txtIdSitio.TabIndex = 28
            Me.txtIdSitio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtSitio
            '
            Me.txtSitio.BackColor = System.Drawing.Color.White
            Me.txtSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSitio.Enabled = False
            Me.txtSitio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSitio.Location = New System.Drawing.Point(231, 31)
            Me.txtSitio.Name = "txtSitio"
            Me.txtSitio.Size = New System.Drawing.Size(324, 21)
            Me.txtSitio.TabIndex = 0
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnRemove.Location = New System.Drawing.Point(752, 56)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(26, 26)
            Me.btnRemove.TabIndex = 199
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'ListView1
            '
            Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
            Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(0, 0)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(834, 296)
            Me.ListView1.TabIndex = 196
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "IDP"
            Me.ColumnHeader2.Width = 0
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "PERSONAL / VIGILANTES DE SEGURIDAD"
            Me.ColumnHeader3.Width = 250
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "IDS"
            Me.ColumnHeader6.Width = 0
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "SITIO"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.DisplayIndex = 6
            Me.ColumnHeader10.Text = "IDH"
            Me.ColumnHeader10.Width = 0
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.DisplayIndex = 7
            Me.ColumnHeader11.Text = "HOR"
            Me.ColumnHeader11.Width = 40
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.DisplayIndex = 8
            Me.ColumnHeader12.Text = "DÍAS"
            Me.ColumnHeader12.Width = 100
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.DisplayIndex = 9
            Me.ColumnHeader13.Text = "LUNES"
            Me.ColumnHeader13.Width = 80
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.DisplayIndex = 10
            Me.ColumnHeader14.Text = "MARTES"
            Me.ColumnHeader14.Width = 80
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.DisplayIndex = 11
            Me.ColumnHeader15.Text = "MIÉRCOLES"
            Me.ColumnHeader15.Width = 80
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.DisplayIndex = 12
            Me.ColumnHeader16.Text = "JUEVES"
            Me.ColumnHeader16.Width = 80
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.DisplayIndex = 13
            Me.ColumnHeader17.Text = "VIERNES"
            Me.ColumnHeader17.Width = 80
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.DisplayIndex = 14
            Me.ColumnHeader18.Text = "SÁBADO"
            Me.ColumnHeader18.Width = 80
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.DisplayIndex = 15
            Me.ColumnHeader19.Text = "DOMINGO"
            Me.ColumnHeader19.Width = 80
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.DisplayIndex = 16
            Me.ColumnHeader1.Text = "DETALLE"
            Me.ColumnHeader1.Width = 300
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.DisplayIndex = 4
            Me.ColumnHeader4.Text = "INICIA"
            Me.ColumnHeader4.Width = 80
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.DisplayIndex = 5
            Me.ColumnHeader5.Text = "TERMINA"
            Me.ColumnHeader5.Width = 80
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "TIPO"
            Me.ColumnHeader7.Width = 30
            '
            'cbmSitio
            '
            Me.cbmSitio.BackColor = System.Drawing.Color.White
            Me.cbmSitio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSitio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmSitio.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmSitio.FormattingEnabled = True
            Me.cbmSitio.Location = New System.Drawing.Point(397, 383)
            Me.cbmSitio.Name = "cbmSitio"
            Me.cbmSitio.Size = New System.Drawing.Size(400, 21)
            Me.cbmSitio.TabIndex = 205
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker2.Enabled = False
            Me.DateTimePicker2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker2.Location = New System.Drawing.Point(623, 5)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(197, 21)
            Me.DateTimePicker2.TabIndex = 202
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker1.Location = New System.Drawing.Point(358, 5)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(197, 21)
            Me.DateTimePicker1.TabIndex = 200
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox3.Enabled = False
            Me.TextBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.Location = New System.Drawing.Point(37, 5)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(50, 21)
            Me.TextBox3.TabIndex = 28
            Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMMM yyyy"
            Me.dtpMes.Enabled = False
            Me.dtpMes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(144, 5)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(112, 21)
            Me.dtpMes.TabIndex = 198
            '
            'txtNumHorario
            '
            Me.txtNumHorario.BackColor = System.Drawing.Color.White
            Me.txtNumHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumHorario.Enabled = False
            Me.txtNumHorario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumHorario.Location = New System.Drawing.Point(78, 84)
            Me.txtNumHorario.Name = "txtNumHorario"
            Me.txtNumHorario.Size = New System.Drawing.Size(56, 21)
            Me.txtNumHorario.TabIndex = 197
            Me.txtNumHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.bntHorarios.Enabled = False
            Me.bntHorarios.FlatAppearance.BorderSize = 0
            Me.bntHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntHorarios.Location = New System.Drawing.Point(23, 112)
            Me.bntHorarios.Name = "bntHorarios"
            Me.bntHorarios.Size = New System.Drawing.Size(28, 28)
            Me.bntHorarios.TabIndex = 194
            Me.bntHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntHorarios.UseVisualStyleBackColor = False
            '
            'cbmMotivo
            '
            Me.cbmMotivo.BackColor = System.Drawing.Color.White
            Me.cbmMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMotivo.Enabled = False
            Me.cbmMotivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMotivo.FormattingEnabled = True
            Me.cbmMotivo.Items.AddRange(New Object() {"ASISTENCIA NORMAL SEGÚN PROGRAMACIÓN", "PERMISO POR MATERNIDA - PATERNIDAD", "PERMISO  POR CALAMIDAD DOMÉSTICA", "PERMISO  POR DESCANSO MÉDICO", "PERMISO  POR VACACIONES", "OTROS PERMISOS"})
            Me.cbmMotivo.Location = New System.Drawing.Point(603, 32)
            Me.cbmMotivo.Name = "cbmMotivo"
            Me.cbmMotivo.Size = New System.Drawing.Size(206, 21)
            Me.cbmMotivo.TabIndex = 209
            '
            'dtpHastaP
            '
            Me.dtpHastaP.CustomFormat = "MMMM yyyy"
            Me.dtpHastaP.Enabled = False
            Me.dtpHastaP.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHastaP.Location = New System.Drawing.Point(334, 34)
            Me.dtpHastaP.Name = "dtpHastaP"
            Me.dtpHastaP.Size = New System.Drawing.Size(197, 21)
            Me.dtpHastaP.TabIndex = 206
            '
            'dtpDesdeP
            '
            Me.dtpDesdeP.CustomFormat = "DDDD, dd/MMMM/yyyy"
            Me.dtpDesdeP.Enabled = False
            Me.dtpDesdeP.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesdeP.Location = New System.Drawing.Point(50, 34)
            Me.dtpDesdeP.Name = "dtpDesdeP"
            Me.dtpDesdeP.Size = New System.Drawing.Size(197, 21)
            Me.dtpDesdeP.TabIndex = 204
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.Location = New System.Drawing.Point(101, 61)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(591, 21)
            Me.txtDetalle.TabIndex = 199
            '
            'txtArea
            '
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Location = New System.Drawing.Point(484, 7)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(91, 20)
            Me.txtArea.TabIndex = 197
            Me.txtArea.Visible = False
            '
            'txtCargo
            '
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Location = New System.Drawing.Point(388, 7)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(187, 20)
            Me.txtCargo.TabIndex = 195
            Me.txtCargo.Visible = False
            '
            'btnPersonal
            '
            Me.btnPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnPersonal.Enabled = False
            Me.btnPersonal.FlatAppearance.BorderSize = 0
            Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPersonal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnPersonal.Location = New System.Drawing.Point(713, 2)
            Me.btnPersonal.Name = "btnPersonal"
            Me.btnPersonal.Size = New System.Drawing.Size(28, 28)
            Me.btnPersonal.TabIndex = 193
            Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonal.UseVisualStyleBackColor = False
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(50, 7)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(57, 21)
            Me.txtIdPersonal.TabIndex = 28
            Me.txtIdPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtPersonal
            '
            Me.txtPersonal.BackColor = System.Drawing.Color.White
            Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPersonal.Enabled = False
            Me.txtPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPersonal.Location = New System.Drawing.Point(186, 7)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(506, 21)
            Me.txtPersonal.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnCancelar, Me.btnMesAnterior})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(847, 32)
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
            'btnEditar
            '
            Me.btnEditar.Enabled = False
            Me.btnEditar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnEditar.Name = "btnEditar"
            Me.btnEditar.Size = New System.Drawing.Size(85, 28)
            Me.btnEditar.Text = "EDITAR"
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
            'btnMesAnterior
            '
            Me.btnMesAnterior.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.btnMesAnterior.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnMesAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnMesAnterior.Name = "btnMesAnterior"
            Me.btnMesAnterior.Size = New System.Drawing.Size(95, 28)
            Me.btnMesAnterior.Text = "MES ANT."
            '
            'crvSitios
            '
            Me.crvSitios.ActiveViewIndex = -1
            Me.crvSitios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSitios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSitios.Location = New System.Drawing.Point(0, 0)
            Me.crvSitios.Name = "crvSitios"
            Me.crvSitios.ShowCloseButton = False
            Me.crvSitios.ShowLogo = False
            Me.crvSitios.Size = New System.Drawing.Size(847, 669)
            Me.crvSitios.TabIndex = 0
            Me.crvSitios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
            Me.KryptonNavigator1.Size = New System.Drawing.Size(849, 696)
            Me.KryptonNavigator1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 3
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage1.Controls.Add(Me.cbmSitio)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.btnNoSitiosProgramacion)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.btnNoProgramacion)
            Me.KryptonPage1.Controls.Add(Me.MenuStrip1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(847, 669)
            Me.KryptonPage1.Text = "Mantenimiento"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "938C35765780470D149DE8DE6DC40A27"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.btnReporte)
            Me.KryptonPage2.Controls.Add(Me.DateTimePicker3)
            Me.KryptonPage2.Controls.Add(Me.crvSitios)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(847, 669)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "4577C4D69A4D41D116ACC5EEEF2D286F"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdHorario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntHorarios)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpADomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpASabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpALunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumHorario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtP8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtP12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtP24)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.DateTimePicker2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.DateTimePicker1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.TextBox3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpMes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdSitio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSitio)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(838, 181)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = "Datos de Programacion y Puesto de trabajo"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 5)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 201
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(99, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(33, 20)
            Me.KryptonLabel2.TabIndex = 202
            Me.KryptonLabel2.Values.Text = "Mes"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(311, 5)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 203
            Me.KryptonLabel3.Values.Text = "Desde"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(569, 5)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel4.TabIndex = 204
            Me.KryptonLabel4.Values.Text = "Hasta"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 31)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel5.TabIndex = 205
            Me.KryptonLabel5.Values.Text = "Id Sitio"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(157, 31)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel6.TabIndex = 206
            Me.KryptonLabel6.Values.Text = "Ubicacion"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(3, 57)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel7.TabIndex = 207
            Me.KryptonLabel7.Values.Text = "Cliente"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(630, 31)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel8.TabIndex = 208
            Me.KryptonLabel8.Values.Text = "P 24h"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(738, 31)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel9.TabIndex = 209
            Me.KryptonLabel9.Values.Text = "P 12h"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(629, 57)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel10.TabIndex = 210
            Me.KryptonLabel10.Values.Text = "P 8h"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(742, 57)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel11.TabIndex = 211
            Me.KryptonLabel11.Values.Text = "P 0h"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(80, 127)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel12.TabIndex = 217
            Me.KryptonLabel12.Values.Text = "Hasta"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(80, 108)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel13.TabIndex = 216
            Me.KryptonLabel13.Values.Text = "Desde"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(3, 83)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel14.TabIndex = 215
            Me.KryptonLabel14.Values.Text = "No Horario"
            '
            'lblIdHorario
            '
            Me.lblIdHorario.AutoSize = True
            Me.lblIdHorario.Location = New System.Drawing.Point(830, 134)
            Me.lblIdHorario.Name = "lblIdHorario"
            Me.lblIdHorario.Size = New System.Drawing.Size(0, 13)
            Me.lblIdHorario.TabIndex = 253
            Me.lblIdHorario.Visible = False
            '
            'dtpADomingo
            '
            Me.dtpADomingo.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpADomingo.CustomFormat = "HH:mm"
            Me.dtpADomingo.Enabled = False
            Me.dtpADomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpADomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpADomingo.Location = New System.Drawing.Point(746, 127)
            Me.dtpADomingo.Name = "dtpADomingo"
            Me.dtpADomingo.ShowUpDown = True
            Me.dtpADomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpADomingo.TabIndex = 252
            '
            'dtpDDomingo
            '
            Me.dtpDDomingo.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDDomingo.CustomFormat = "HH:mm"
            Me.dtpDDomingo.Enabled = False
            Me.dtpDDomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDDomingo.Location = New System.Drawing.Point(746, 105)
            Me.dtpDDomingo.Name = "dtpDDomingo"
            Me.dtpDDomingo.ShowUpDown = True
            Me.dtpDDomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpDDomingo.TabIndex = 251
            '
            'chkDomingo
            '
            Me.chkDomingo.AutoSize = True
            Me.chkDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkDomingo.Enabled = False
            Me.chkDomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkDomingo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkDomingo.Location = New System.Drawing.Point(747, 84)
            Me.chkDomingo.Name = "chkDomingo"
            Me.chkDomingo.Size = New System.Drawing.Size(70, 17)
            Me.chkDomingo.TabIndex = 248
            Me.chkDomingo.Text = "Domingo"
            Me.chkDomingo.UseVisualStyleBackColor = False
            '
            'dtpASabado
            '
            Me.dtpASabado.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpASabado.CustomFormat = "HH:mm"
            Me.dtpASabado.Enabled = False
            Me.dtpASabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpASabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpASabado.Location = New System.Drawing.Point(648, 127)
            Me.dtpASabado.Name = "dtpASabado"
            Me.dtpASabado.ShowUpDown = True
            Me.dtpASabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpASabado.TabIndex = 247
            '
            'dtpDSabado
            '
            Me.dtpDSabado.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDSabado.CustomFormat = "HH:mm"
            Me.dtpDSabado.Enabled = False
            Me.dtpDSabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDSabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDSabado.Location = New System.Drawing.Point(648, 105)
            Me.dtpDSabado.Name = "dtpDSabado"
            Me.dtpDSabado.ShowUpDown = True
            Me.dtpDSabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpDSabado.TabIndex = 246
            '
            'chkSabado
            '
            Me.chkSabado.AutoSize = True
            Me.chkSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkSabado.Enabled = False
            Me.chkSabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSabado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkSabado.Location = New System.Drawing.Point(649, 84)
            Me.chkSabado.Name = "chkSabado"
            Me.chkSabado.Size = New System.Drawing.Size(63, 17)
            Me.chkSabado.TabIndex = 243
            Me.chkSabado.Text = "Sabado"
            Me.chkSabado.UseVisualStyleBackColor = False
            '
            'dtpAViernes
            '
            Me.dtpAViernes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAViernes.CustomFormat = "HH:mm"
            Me.dtpAViernes.Enabled = False
            Me.dtpAViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAViernes.Location = New System.Drawing.Point(549, 127)
            Me.dtpAViernes.Name = "dtpAViernes"
            Me.dtpAViernes.ShowUpDown = True
            Me.dtpAViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAViernes.TabIndex = 242
            '
            'dtpDViernes
            '
            Me.dtpDViernes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDViernes.CustomFormat = "HH:mm"
            Me.dtpDViernes.Enabled = False
            Me.dtpDViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDViernes.Location = New System.Drawing.Point(549, 105)
            Me.dtpDViernes.Name = "dtpDViernes"
            Me.dtpDViernes.ShowUpDown = True
            Me.dtpDViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDViernes.TabIndex = 241
            '
            'chkViernes
            '
            Me.chkViernes.AutoSize = True
            Me.chkViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkViernes.Enabled = False
            Me.chkViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkViernes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkViernes.Location = New System.Drawing.Point(550, 84)
            Me.chkViernes.Name = "chkViernes"
            Me.chkViernes.Size = New System.Drawing.Size(64, 17)
            Me.chkViernes.TabIndex = 238
            Me.chkViernes.Text = "Viernes"
            Me.chkViernes.UseVisualStyleBackColor = False
            '
            'dtpAJueves
            '
            Me.dtpAJueves.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAJueves.CustomFormat = "HH:mm"
            Me.dtpAJueves.Enabled = False
            Me.dtpAJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAJueves.Location = New System.Drawing.Point(452, 127)
            Me.dtpAJueves.Name = "dtpAJueves"
            Me.dtpAJueves.ShowUpDown = True
            Me.dtpAJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpAJueves.TabIndex = 237
            '
            'dtpDJueves
            '
            Me.dtpDJueves.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDJueves.CustomFormat = "HH:mm"
            Me.dtpDJueves.Enabled = False
            Me.dtpDJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDJueves.Location = New System.Drawing.Point(452, 105)
            Me.dtpDJueves.Name = "dtpDJueves"
            Me.dtpDJueves.ShowUpDown = True
            Me.dtpDJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpDJueves.TabIndex = 236
            '
            'chkJueves
            '
            Me.chkJueves.AutoSize = True
            Me.chkJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkJueves.Enabled = False
            Me.chkJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkJueves.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkJueves.Location = New System.Drawing.Point(453, 84)
            Me.chkJueves.Name = "chkJueves"
            Me.chkJueves.Size = New System.Drawing.Size(61, 17)
            Me.chkJueves.TabIndex = 233
            Me.chkJueves.Text = "Jueves"
            Me.chkJueves.UseVisualStyleBackColor = False
            '
            'dtpAMiercoles
            '
            Me.dtpAMiercoles.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMiercoles.CustomFormat = "HH:mm"
            Me.dtpAMiercoles.Enabled = False
            Me.dtpAMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMiercoles.Location = New System.Drawing.Point(349, 128)
            Me.dtpAMiercoles.Name = "dtpAMiercoles"
            Me.dtpAMiercoles.ShowUpDown = True
            Me.dtpAMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMiercoles.TabIndex = 232
            '
            'dtpDMiercoles
            '
            Me.dtpDMiercoles.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDMiercoles.CustomFormat = "HH:mm"
            Me.dtpDMiercoles.Enabled = False
            Me.dtpDMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDMiercoles.Location = New System.Drawing.Point(349, 106)
            Me.dtpDMiercoles.Name = "dtpDMiercoles"
            Me.dtpDMiercoles.ShowUpDown = True
            Me.dtpDMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpDMiercoles.TabIndex = 231
            '
            'chkMiercoles
            '
            Me.chkMiercoles.AutoSize = True
            Me.chkMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkMiercoles.Enabled = False
            Me.chkMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkMiercoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkMiercoles.Location = New System.Drawing.Point(350, 85)
            Me.chkMiercoles.Name = "chkMiercoles"
            Me.chkMiercoles.Size = New System.Drawing.Size(76, 17)
            Me.chkMiercoles.TabIndex = 228
            Me.chkMiercoles.Text = "Miercoles"
            Me.chkMiercoles.UseVisualStyleBackColor = False
            '
            'dtpAMartes
            '
            Me.dtpAMartes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMartes.CustomFormat = "HH:mm"
            Me.dtpAMartes.Enabled = False
            Me.dtpAMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMartes.Location = New System.Drawing.Point(259, 128)
            Me.dtpAMartes.Name = "dtpAMartes"
            Me.dtpAMartes.ShowUpDown = True
            Me.dtpAMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMartes.TabIndex = 227
            '
            'dtpDMartes
            '
            Me.dtpDMartes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDMartes.CustomFormat = "HH:mm"
            Me.dtpDMartes.Enabled = False
            Me.dtpDMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDMartes.Location = New System.Drawing.Point(259, 106)
            Me.dtpDMartes.Name = "dtpDMartes"
            Me.dtpDMartes.ShowUpDown = True
            Me.dtpDMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDMartes.TabIndex = 226
            '
            'chkMartes
            '
            Me.chkMartes.AutoSize = True
            Me.chkMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkMartes.Enabled = False
            Me.chkMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkMartes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkMartes.Location = New System.Drawing.Point(260, 86)
            Me.chkMartes.Name = "chkMartes"
            Me.chkMartes.Size = New System.Drawing.Size(62, 17)
            Me.chkMartes.TabIndex = 223
            Me.chkMartes.Text = "Martes"
            Me.chkMartes.UseVisualStyleBackColor = False
            '
            'dtpALunes
            '
            Me.dtpALunes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpALunes.CustomFormat = "HH:mm"
            Me.dtpALunes.Enabled = False
            Me.dtpALunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpALunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpALunes.Location = New System.Drawing.Point(170, 127)
            Me.dtpALunes.Name = "dtpALunes"
            Me.dtpALunes.ShowUpDown = True
            Me.dtpALunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpALunes.TabIndex = 222
            '
            'dtpDLunes
            '
            Me.dtpDLunes.CalendarFont = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDLunes.CustomFormat = "HH:mm"
            Me.dtpDLunes.Enabled = False
            Me.dtpDLunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDLunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDLunes.Location = New System.Drawing.Point(170, 105)
            Me.dtpDLunes.Name = "dtpDLunes"
            Me.dtpDLunes.ShowUpDown = True
            Me.dtpDLunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDLunes.TabIndex = 221
            '
            'chkLunes
            '
            Me.chkLunes.AutoSize = True
            Me.chkLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkLunes.Enabled = False
            Me.chkLunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkLunes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkLunes.Location = New System.Drawing.Point(170, 85)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(56, 17)
            Me.chkLunes.TabIndex = 218
            Me.chkLunes.Text = "Lunes"
            Me.chkLunes.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 222)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnAdd)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnRemove)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmMotivo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDetalle)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpHastaP)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpDesdeP)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCargo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtArea)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(838, 113)
            Me.KryptonGroupBox2.TabIndex = 207
            Me.KryptonGroupBox2.Values.Heading = "Datos de Personal"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(2, 7)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel15.TabIndex = 254
            Me.KryptonLabel15.Values.Text = "Id"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(120, 7)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel16.TabIndex = 255
            Me.KryptonLabel16.Values.Text = "Nombres"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(269, 33)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel17.TabIndex = 257
            Me.KryptonLabel17.Values.Text = "Termina"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(5, 33)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel18.TabIndex = 256
            Me.KryptonLabel18.Values.Text = "Inicia"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(551, 35)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel19.TabIndex = 258
            Me.KryptonLabel19.Values.Text = "Tipo"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(5, 59)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel20.TabIndex = 259
            Me.KryptonLabel20.Values.Text = "Observacion"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(3, 340)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.ListView1)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(838, 320)
            Me.KryptonGroupBox3.TabIndex = 208
            Me.KryptonGroupBox3.Values.Heading = "Personal Asignado a Puesto de Trabajo segun programacion"
            '
            'btnReporte
            '
            Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.btnReporte.FlatAppearance.BorderSize = 0
            Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.ForeColor = System.Drawing.Color.Black
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.Location = New System.Drawing.Point(789, 1)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(26, 26)
            Me.btnReporte.TabIndex = 202
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.UseVisualStyleBackColor = False
            '
            'DateTimePicker3
            '
            Me.DateTimePicker3.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DateTimePicker3.Location = New System.Drawing.Point(658, 4)
            Me.DateTimePicker3.Name = "DateTimePicker3"
            Me.DateTimePicker3.ShowUpDown = True
            Me.DateTimePicker3.Size = New System.Drawing.Size(121, 21)
            Me.DateTimePicker3.TabIndex = 203
            '
            'FrmProgramacionGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(849, 696)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmProgramacionGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "PROGRAMACIÓN GENERAL"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
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
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnPersonal As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents crvSitios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents bntPuesto As System.Windows.Forms.Button
        Friend WithEvents txtIdSitio As System.Windows.Forms.TextBox
        Friend WithEvents txtSitio As System.Windows.Forms.TextBox
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents bntHorarios As System.Windows.Forms.Button
        Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents btnEditar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbmSitio As System.Windows.Forms.ComboBox
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtNumHorario As System.Windows.Forms.TextBox
        Friend WithEvents dtpHastaP As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesdeP As System.Windows.Forms.DateTimePicker
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnNoProgramacion As System.Windows.Forms.Button
        Friend WithEvents btnNoSitiosProgramacion As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents cbmMotivo As System.Windows.Forms.ComboBox
        Friend WithEvents btnMesAnterior As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtPo As System.Windows.Forms.TextBox
        Friend WithEvents txtP8 As System.Windows.Forms.TextBox
        Friend WithEvents txtP12 As System.Windows.Forms.TextBox
        Friend WithEvents txtP24 As System.Windows.Forms.TextBox
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIdHorario As Label
        Friend WithEvents dtpADomingo As DateTimePicker
        Friend WithEvents dtpDDomingo As DateTimePicker
        Friend WithEvents chkDomingo As CheckBox
        Friend WithEvents dtpASabado As DateTimePicker
        Friend WithEvents dtpDSabado As DateTimePicker
        Friend WithEvents chkSabado As CheckBox
        Friend WithEvents dtpAViernes As DateTimePicker
        Friend WithEvents dtpDViernes As DateTimePicker
        Friend WithEvents chkViernes As CheckBox
        Friend WithEvents dtpAJueves As DateTimePicker
        Friend WithEvents dtpDJueves As DateTimePicker
        Friend WithEvents chkJueves As CheckBox
        Friend WithEvents dtpAMiercoles As DateTimePicker
        Friend WithEvents dtpDMiercoles As DateTimePicker
        Friend WithEvents chkMiercoles As CheckBox
        Friend WithEvents dtpAMartes As DateTimePicker
        Friend WithEvents dtpDMartes As DateTimePicker
        Friend WithEvents chkMartes As CheckBox
        Friend WithEvents dtpALunes As DateTimePicker
        Friend WithEvents dtpDLunes As DateTimePicker
        Friend WithEvents chkLunes As CheckBox
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnReporte As Button
        Friend WithEvents DateTimePicker3 As DateTimePicker
    End Class
End Namespace