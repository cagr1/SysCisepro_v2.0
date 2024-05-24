Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProgramacionGeneral
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramacionGeneral))
            Me.tcSitios = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnNoSitiosProgramacion = New System.Windows.Forms.Button()
            Me.btnNoProgramacion = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtPo = New System.Windows.Forms.TextBox()
            Me.txtP8 = New System.Windows.Forms.TextBox()
            Me.txtP12 = New System.Windows.Forms.TextBox()
            Me.txtP24 = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtIdSitio = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtSitio = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
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
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.dtpMes = New System.Windows.Forms.DateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtNumHorario = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblIdHorario = New System.Windows.Forms.Label()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.dtpADomingo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDDomingo = New System.Windows.Forms.DateTimePicker()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.chkDomingo = New System.Windows.Forms.CheckBox()
            Me.dtpASabado = New System.Windows.Forms.DateTimePicker()
            Me.dtpDSabado = New System.Windows.Forms.DateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.chkSabado = New System.Windows.Forms.CheckBox()
            Me.dtpAViernes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDViernes = New System.Windows.Forms.DateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.chkViernes = New System.Windows.Forms.CheckBox()
            Me.dtpAJueves = New System.Windows.Forms.DateTimePicker()
            Me.dtpDJueves = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.chkJueves = New System.Windows.Forms.CheckBox()
            Me.dtpAMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.dtpDMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.chkMiercoles = New System.Windows.Forms.CheckBox()
            Me.dtpAMartes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDMartes = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkMartes = New System.Windows.Forms.CheckBox()
            Me.dtpALunes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDLunes = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkLunes = New System.Windows.Forms.CheckBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbmMotivo = New System.Windows.Forms.ComboBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.dtpHastaP = New System.Windows.Forms.DateTimePicker()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.dtpDesdeP = New System.Windows.Forms.DateTimePicker()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.btnPersonal = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnMesAnterior = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.crvSitios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcSitios.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcSitios
            '
            Me.tcSitios.Controls.Add(Me.TabPage1)
            Me.tcSitios.Controls.Add(Me.tpReporte)
            Me.tcSitios.Location = New System.Drawing.Point(2, 2)
            Me.tcSitios.Name = "tcSitios"
            Me.tcSitios.SelectedIndex = 0
            Me.tcSitios.Size = New System.Drawing.Size(1010, 692)
            Me.tcSitios.TabIndex = 2
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.btnNoSitiosProgramacion)
            Me.TabPage1.Controls.Add(Me.btnNoProgramacion)
            Me.TabPage1.Controls.Add(Me.btnAdd)
            Me.TabPage1.Controls.Add(Me.GroupBox3)
            Me.TabPage1.Controls.Add(Me.btnRemove)
            Me.TabPage1.Controls.Add(Me.ListView1)
            Me.TabPage1.Controls.Add(Me.cbmSitio)
            Me.TabPage1.Controls.Add(Me.GroupBox4)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.MenuStrip1)
            Me.TabPage1.Controls.Add(Me.Label24)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1002, 666)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "MANTENIMIENTO"
            '
            'btnNoSitiosProgramacion
            '
            Me.btnNoSitiosProgramacion.BackColor = System.Drawing.Color.White
            Me.btnNoSitiosProgramacion.Enabled = False
            Me.btnNoSitiosProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNoSitiosProgramacion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNoSitiosProgramacion.Image = Global.syscisepro.My.Resources.Resources.world_warning_icon
            Me.btnNoSitiosProgramacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNoSitiosProgramacion.Location = New System.Drawing.Point(800, 3)
            Me.btnNoSitiosProgramacion.Name = "btnNoSitiosProgramacion"
            Me.btnNoSitiosProgramacion.Size = New System.Drawing.Size(199, 23)
            Me.btnNoSitiosProgramacion.TabIndex = 206
            Me.btnNoSitiosProgramacion.Text = "SITIOS NO PROGRAMACIÓN"
            Me.btnNoSitiosProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNoSitiosProgramacion.UseVisualStyleBackColor = False
            '
            'btnNoProgramacion
            '
            Me.btnNoProgramacion.BackColor = System.Drawing.Color.White
            Me.btnNoProgramacion.Enabled = False
            Me.btnNoProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNoProgramacion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNoProgramacion.Image = Global.syscisepro.My.Resources.Resources.personnel_light_icon
            Me.btnNoProgramacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNoProgramacion.Location = New System.Drawing.Point(599, 3)
            Me.btnNoProgramacion.Name = "btnNoProgramacion"
            Me.btnNoProgramacion.Size = New System.Drawing.Size(199, 23)
            Me.btnNoProgramacion.TabIndex = 200
            Me.btnNoProgramacion.Text = "PERSONAL NO PROGRAMACIÓN"
            Me.btnNoProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNoProgramacion.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.White
            Me.btnAdd.Enabled = False
            Me.btnAdd.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAdd.Image = Global.syscisepro.My.Resources.Resources.add
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAdd.Location = New System.Drawing.Point(847, 311)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(80, 26)
            Me.btnAdd.TabIndex = 200
            Me.btnAdd.Text = "AGREGAR"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.txtPo)
            Me.GroupBox3.Controls.Add(Me.txtP8)
            Me.GroupBox3.Controls.Add(Me.txtP12)
            Me.GroupBox3.Controls.Add(Me.txtP24)
            Me.GroupBox3.Controls.Add(Me.Label33)
            Me.GroupBox3.Controls.Add(Me.Label34)
            Me.GroupBox3.Controls.Add(Me.Label35)
            Me.GroupBox3.Controls.Add(Me.Label36)
            Me.GroupBox3.Controls.Add(Me.txtCliente)
            Me.GroupBox3.Controls.Add(Me.Label28)
            Me.GroupBox3.Controls.Add(Me.bntPuesto)
            Me.GroupBox3.Controls.Add(Me.txtIdSitio)
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.txtSitio)
            Me.GroupBox3.Controls.Add(Me.Label23)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(3, 72)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(995, 70)
            Me.GroupBox3.TabIndex = 194
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DATOS DEL PUESTO DE TRABAJO"
            '
            'txtPo
            '
            Me.txtPo.BackColor = System.Drawing.Color.White
            Me.txtPo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPo.Enabled = False
            Me.txtPo.Location = New System.Drawing.Point(950, 43)
            Me.txtPo.Name = "txtPo"
            Me.txtPo.Size = New System.Drawing.Size(39, 20)
            Me.txtPo.TabIndex = 214
            Me.txtPo.Text = "0"
            Me.txtPo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP8
            '
            Me.txtP8.BackColor = System.Drawing.Color.White
            Me.txtP8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP8.Enabled = False
            Me.txtP8.Location = New System.Drawing.Point(859, 43)
            Me.txtP8.Name = "txtP8"
            Me.txtP8.Size = New System.Drawing.Size(39, 20)
            Me.txtP8.TabIndex = 212
            Me.txtP8.Text = "0"
            Me.txtP8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP12
            '
            Me.txtP12.BackColor = System.Drawing.Color.White
            Me.txtP12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP12.Enabled = False
            Me.txtP12.Location = New System.Drawing.Point(769, 43)
            Me.txtP12.Name = "txtP12"
            Me.txtP12.Size = New System.Drawing.Size(39, 20)
            Me.txtP12.TabIndex = 210
            Me.txtP12.Text = "0"
            Me.txtP12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtP24
            '
            Me.txtP24.BackColor = System.Drawing.Color.White
            Me.txtP24.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtP24.Enabled = False
            Me.txtP24.Location = New System.Drawing.Point(674, 43)
            Me.txtP24.Name = "txtP24"
            Me.txtP24.Size = New System.Drawing.Size(39, 20)
            Me.txtP24.TabIndex = 208
            Me.txtP24.Text = "0"
            Me.txtP24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label33.Location = New System.Drawing.Point(918, 46)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(34, 13)
            Me.Label33.TabIndex = 213
            Me.Label33.Text = "P. OH:"
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label34.Location = New System.Drawing.Point(828, 46)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(33, 13)
            Me.Label34.TabIndex = 211
            Me.Label34.Text = "P. 8H:"
            '
            'Label35
            '
            Me.Label35.AutoSize = True
            Me.Label35.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label35.Location = New System.Drawing.Point(733, 46)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(39, 13)
            Me.Label35.TabIndex = 209
            Me.Label35.Text = "P. 12H:"
            '
            'Label36
            '
            Me.Label36.AutoSize = True
            Me.Label36.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label36.Location = New System.Drawing.Point(637, 46)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(39, 13)
            Me.Label36.TabIndex = 207
            Me.Label36.Text = "P. 24H:"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Location = New System.Drawing.Point(79, 42)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(552, 20)
            Me.txtCliente.TabIndex = 201
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(18, 45)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(55, 13)
            Me.Label28.TabIndex = 200
            Me.Label28.Text = "CLIENTE:"
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.White
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = CType(resources.GetObject("bntPuesto.Image"), System.Drawing.Image)
            Me.bntPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntPuesto.Location = New System.Drawing.Point(963, 11)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(26, 26)
            Me.bntPuesto.TabIndex = 193
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'txtIdSitio
            '
            Me.txtIdSitio.BackColor = System.Drawing.Color.White
            Me.txtIdSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdSitio.Enabled = False
            Me.txtIdSitio.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdSitio.Location = New System.Drawing.Point(44, 16)
            Me.txtIdSitio.Name = "txtIdSitio"
            Me.txtIdSitio.Size = New System.Drawing.Size(56, 20)
            Me.txtIdSitio.TabIndex = 28
            Me.txtIdSitio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(18, 21)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(25, 13)
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "ID:"
            '
            'txtSitio
            '
            Me.txtSitio.BackColor = System.Drawing.Color.White
            Me.txtSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSitio.Enabled = False
            Me.txtSitio.Location = New System.Drawing.Point(247, 16)
            Me.txtSitio.Name = "txtSitio"
            Me.txtSitio.Size = New System.Drawing.Size(714, 20)
            Me.txtSitio.TabIndex = 0
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(178, 19)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(67, 13)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "UBICACIÓN:"
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.White
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove.Image = Global.syscisepro.My.Resources.Resources.remove
            Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRemove.Location = New System.Drawing.Point(926, 311)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(73, 26)
            Me.btnRemove.TabIndex = 199
            Me.btnRemove.Text = "QUITAR"
            Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.Location = New System.Drawing.Point(0, 339)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(998, 324)
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
            Me.cbmSitio.Location = New System.Drawing.Point(558, 336)
            Me.cbmSitio.Name = "cbmSitio"
            Me.cbmSitio.Size = New System.Drawing.Size(400, 21)
            Me.cbmSitio.TabIndex = 205
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox4.Controls.Add(Me.TextBox3)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.dtpMes)
            Me.GroupBox4.Controls.Add(Me.Label17)
            Me.GroupBox4.Controls.Add(Me.Label16)
            Me.GroupBox4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(3, 26)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(996, 47)
            Me.GroupBox4.TabIndex = 201
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "DATOS DE LA PROGRAMACIÓN"
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker2.Enabled = False
            Me.DateTimePicker2.Location = New System.Drawing.Point(735, 13)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(255, 20)
            Me.DateTimePicker2.TabIndex = 202
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(694, 16)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 203
            Me.Label19.Text = "HASTA:"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker1.Location = New System.Drawing.Point(382, 14)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(255, 20)
            Me.DateTimePicker1.TabIndex = 200
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox3.Enabled = False
            Me.TextBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.Location = New System.Drawing.Point(30, 15)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(50, 20)
            Me.TextBox3.TabIndex = 28
            Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(7, 18)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(25, 13)
            Me.Label18.TabIndex = 8
            Me.Label18.Text = "ID:"
            '
            'dtpMes
            '
            Me.dtpMes.CustomFormat = "MMMM yyyy"
            Me.dtpMes.Enabled = False
            Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpMes.Location = New System.Drawing.Point(165, 15)
            Me.dtpMes.Name = "dtpMes"
            Me.dtpMes.ShowUpDown = True
            Me.dtpMes.Size = New System.Drawing.Size(121, 20)
            Me.dtpMes.TabIndex = 198
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(341, 17)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(43, 13)
            Me.Label17.TabIndex = 201
            Me.Label17.Text = "DESDE:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(136, 19)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(31, 13)
            Me.Label16.TabIndex = 199
            Me.Label16.Text = "MES:"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.txtNumHorario)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.lblIdHorario)
            Me.GroupBox2.Controls.Add(Me.bntHorarios)
            Me.GroupBox2.Controls.Add(Me.dtpADomingo)
            Me.GroupBox2.Controls.Add(Me.dtpDDomingo)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.chkDomingo)
            Me.GroupBox2.Controls.Add(Me.dtpASabado)
            Me.GroupBox2.Controls.Add(Me.dtpDSabado)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.chkSabado)
            Me.GroupBox2.Controls.Add(Me.dtpAViernes)
            Me.GroupBox2.Controls.Add(Me.dtpDViernes)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.chkViernes)
            Me.GroupBox2.Controls.Add(Me.dtpAJueves)
            Me.GroupBox2.Controls.Add(Me.dtpDJueves)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.chkJueves)
            Me.GroupBox2.Controls.Add(Me.dtpAMiercoles)
            Me.GroupBox2.Controls.Add(Me.dtpDMiercoles)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.chkMiercoles)
            Me.GroupBox2.Controls.Add(Me.dtpAMartes)
            Me.GroupBox2.Controls.Add(Me.dtpDMartes)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.chkMartes)
            Me.GroupBox2.Controls.Add(Me.dtpALunes)
            Me.GroupBox2.Controls.Add(Me.dtpDLunes)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.chkLunes)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(4, 140)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(995, 85)
            Me.GroupBox2.TabIndex = 187
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DATOS DEL HORARIO DE TRABAJO ASIGNADO"
            '
            'txtNumHorario
            '
            Me.txtNumHorario.BackColor = System.Drawing.Color.White
            Me.txtNumHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumHorario.Enabled = False
            Me.txtNumHorario.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumHorario.Location = New System.Drawing.Point(20, 42)
            Me.txtNumHorario.Name = "txtNumHorario"
            Me.txtNumHorario.Size = New System.Drawing.Size(56, 20)
            Me.txtNumHorario.TabIndex = 197
            Me.txtNumHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(11, 30)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 13)
            Me.Label7.TabIndex = 196
            Me.Label7.Text = "N° HORARIO:"
            '
            'lblIdHorario
            '
            Me.lblIdHorario.AutoSize = True
            Me.lblIdHorario.Location = New System.Drawing.Point(884, 41)
            Me.lblIdHorario.Name = "lblIdHorario"
            Me.lblIdHorario.Size = New System.Drawing.Size(0, 13)
            Me.lblIdHorario.TabIndex = 195
            Me.lblIdHorario.Visible = False
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.White
            Me.bntHorarios.Enabled = False
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = CType(resources.GetObject("bntHorarios.Image"), System.Drawing.Image)
            Me.bntHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntHorarios.Location = New System.Drawing.Point(962, 11)
            Me.bntHorarios.Name = "bntHorarios"
            Me.bntHorarios.Size = New System.Drawing.Size(26, 26)
            Me.bntHorarios.TabIndex = 194
            Me.bntHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntHorarios.UseVisualStyleBackColor = False
            '
            'dtpADomingo
            '
            Me.dtpADomingo.CustomFormat = "HH:mm"
            Me.dtpADomingo.Enabled = False
            Me.dtpADomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpADomingo.Location = New System.Drawing.Point(871, 56)
            Me.dtpADomingo.Name = "dtpADomingo"
            Me.dtpADomingo.ShowUpDown = True
            Me.dtpADomingo.Size = New System.Drawing.Size(61, 20)
            Me.dtpADomingo.TabIndex = 42
            '
            'dtpDDomingo
            '
            Me.dtpDDomingo.CustomFormat = "HH:mm"
            Me.dtpDDomingo.Enabled = False
            Me.dtpDDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDDomingo.Location = New System.Drawing.Point(871, 34)
            Me.dtpDDomingo.Name = "dtpDDomingo"
            Me.dtpDDomingo.ShowUpDown = True
            Me.dtpDDomingo.Size = New System.Drawing.Size(61, 20)
            Me.dtpDDomingo.TabIndex = 41
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(853, 59)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(19, 13)
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "A:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(847, 37)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(25, 13)
            Me.Label15.TabIndex = 39
            Me.Label15.Text = "DE:"
            '
            'chkDomingo
            '
            Me.chkDomingo.AutoSize = True
            Me.chkDomingo.Enabled = False
            Me.chkDomingo.Location = New System.Drawing.Point(850, 19)
            Me.chkDomingo.Name = "chkDomingo"
            Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
            Me.chkDomingo.TabIndex = 38
            Me.chkDomingo.Text = "DOMINGO"
            Me.chkDomingo.UseVisualStyleBackColor = True
            '
            'dtpASabado
            '
            Me.dtpASabado.CustomFormat = "HH:mm"
            Me.dtpASabado.Enabled = False
            Me.dtpASabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpASabado.Location = New System.Drawing.Point(761, 56)
            Me.dtpASabado.Name = "dtpASabado"
            Me.dtpASabado.ShowUpDown = True
            Me.dtpASabado.Size = New System.Drawing.Size(61, 20)
            Me.dtpASabado.TabIndex = 37
            '
            'dtpDSabado
            '
            Me.dtpDSabado.CustomFormat = "HH:mm"
            Me.dtpDSabado.Enabled = False
            Me.dtpDSabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDSabado.Location = New System.Drawing.Point(761, 34)
            Me.dtpDSabado.Name = "dtpDSabado"
            Me.dtpDSabado.ShowUpDown = True
            Me.dtpDSabado.Size = New System.Drawing.Size(61, 20)
            Me.dtpDSabado.TabIndex = 36
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(743, 59)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(19, 13)
            Me.Label12.TabIndex = 35
            Me.Label12.Text = "A:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(737, 37)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(25, 13)
            Me.Label13.TabIndex = 34
            Me.Label13.Text = "DE:"
            '
            'chkSabado
            '
            Me.chkSabado.AutoSize = True
            Me.chkSabado.Enabled = False
            Me.chkSabado.Location = New System.Drawing.Point(740, 19)
            Me.chkSabado.Name = "chkSabado"
            Me.chkSabado.Size = New System.Drawing.Size(62, 17)
            Me.chkSabado.TabIndex = 33
            Me.chkSabado.Text = "SÁBADO"
            Me.chkSabado.UseVisualStyleBackColor = True
            '
            'dtpAViernes
            '
            Me.dtpAViernes.CustomFormat = "HH:mm"
            Me.dtpAViernes.Enabled = False
            Me.dtpAViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAViernes.Location = New System.Drawing.Point(642, 56)
            Me.dtpAViernes.Name = "dtpAViernes"
            Me.dtpAViernes.ShowUpDown = True
            Me.dtpAViernes.Size = New System.Drawing.Size(61, 20)
            Me.dtpAViernes.TabIndex = 32
            '
            'dtpDViernes
            '
            Me.dtpDViernes.CustomFormat = "HH:mm"
            Me.dtpDViernes.Enabled = False
            Me.dtpDViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDViernes.Location = New System.Drawing.Point(642, 34)
            Me.dtpDViernes.Name = "dtpDViernes"
            Me.dtpDViernes.ShowUpDown = True
            Me.dtpDViernes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDViernes.TabIndex = 31
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(624, 59)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(19, 13)
            Me.Label10.TabIndex = 30
            Me.Label10.Text = "A:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(618, 37)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(25, 13)
            Me.Label11.TabIndex = 29
            Me.Label11.Text = "DE:"
            '
            'chkViernes
            '
            Me.chkViernes.AutoSize = True
            Me.chkViernes.Enabled = False
            Me.chkViernes.Location = New System.Drawing.Point(621, 19)
            Me.chkViernes.Name = "chkViernes"
            Me.chkViernes.Size = New System.Drawing.Size(68, 17)
            Me.chkViernes.TabIndex = 28
            Me.chkViernes.Text = "VIERNES"
            Me.chkViernes.UseVisualStyleBackColor = True
            '
            'dtpAJueves
            '
            Me.dtpAJueves.CustomFormat = "HH:mm"
            Me.dtpAJueves.Enabled = False
            Me.dtpAJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAJueves.Location = New System.Drawing.Point(522, 56)
            Me.dtpAJueves.Name = "dtpAJueves"
            Me.dtpAJueves.ShowUpDown = True
            Me.dtpAJueves.Size = New System.Drawing.Size(61, 20)
            Me.dtpAJueves.TabIndex = 27
            '
            'dtpDJueves
            '
            Me.dtpDJueves.CustomFormat = "HH:mm"
            Me.dtpDJueves.Enabled = False
            Me.dtpDJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDJueves.Location = New System.Drawing.Point(522, 34)
            Me.dtpDJueves.Name = "dtpDJueves"
            Me.dtpDJueves.ShowUpDown = True
            Me.dtpDJueves.Size = New System.Drawing.Size(61, 20)
            Me.dtpDJueves.TabIndex = 26
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(504, 59)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(19, 13)
            Me.Label8.TabIndex = 25
            Me.Label8.Text = "A:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(498, 37)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(25, 13)
            Me.Label9.TabIndex = 24
            Me.Label9.Text = "DE:"
            '
            'chkJueves
            '
            Me.chkJueves.AutoSize = True
            Me.chkJueves.Enabled = False
            Me.chkJueves.Location = New System.Drawing.Point(501, 19)
            Me.chkJueves.Name = "chkJueves"
            Me.chkJueves.Size = New System.Drawing.Size(62, 17)
            Me.chkJueves.TabIndex = 23
            Me.chkJueves.Text = "JUEVES"
            Me.chkJueves.UseVisualStyleBackColor = True
            '
            'dtpAMiercoles
            '
            Me.dtpAMiercoles.CustomFormat = "HH:mm"
            Me.dtpAMiercoles.Enabled = False
            Me.dtpAMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMiercoles.Location = New System.Drawing.Point(400, 57)
            Me.dtpAMiercoles.Name = "dtpAMiercoles"
            Me.dtpAMiercoles.ShowUpDown = True
            Me.dtpAMiercoles.Size = New System.Drawing.Size(61, 20)
            Me.dtpAMiercoles.TabIndex = 22
            '
            'dtpDMiercoles
            '
            Me.dtpDMiercoles.CustomFormat = "HH:mm"
            Me.dtpDMiercoles.Enabled = False
            Me.dtpDMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDMiercoles.Location = New System.Drawing.Point(400, 35)
            Me.dtpDMiercoles.Name = "dtpDMiercoles"
            Me.dtpDMiercoles.ShowUpDown = True
            Me.dtpDMiercoles.Size = New System.Drawing.Size(61, 20)
            Me.dtpDMiercoles.TabIndex = 21
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(379, 60)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(19, 13)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "A:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(373, 38)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(25, 13)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "DE:"
            '
            'chkMiercoles
            '
            Me.chkMiercoles.AutoSize = True
            Me.chkMiercoles.Enabled = False
            Me.chkMiercoles.Location = New System.Drawing.Point(379, 20)
            Me.chkMiercoles.Name = "chkMiercoles"
            Me.chkMiercoles.Size = New System.Drawing.Size(80, 17)
            Me.chkMiercoles.TabIndex = 18
            Me.chkMiercoles.Text = "MIÉRCOLES"
            Me.chkMiercoles.UseVisualStyleBackColor = True
            '
            'dtpAMartes
            '
            Me.dtpAMartes.CustomFormat = "HH:mm"
            Me.dtpAMartes.Enabled = False
            Me.dtpAMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMartes.Location = New System.Drawing.Point(274, 57)
            Me.dtpAMartes.Name = "dtpAMartes"
            Me.dtpAMartes.ShowUpDown = True
            Me.dtpAMartes.Size = New System.Drawing.Size(61, 20)
            Me.dtpAMartes.TabIndex = 17
            '
            'dtpDMartes
            '
            Me.dtpDMartes.CustomFormat = "HH:mm"
            Me.dtpDMartes.Enabled = False
            Me.dtpDMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDMartes.Location = New System.Drawing.Point(274, 35)
            Me.dtpDMartes.Name = "dtpDMartes"
            Me.dtpDMartes.ShowUpDown = True
            Me.dtpDMartes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDMartes.TabIndex = 16
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(251, 60)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(19, 13)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "A:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(245, 38)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(25, 13)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "DE:"
            '
            'chkMartes
            '
            Me.chkMartes.AutoSize = True
            Me.chkMartes.Enabled = False
            Me.chkMartes.Location = New System.Drawing.Point(253, 20)
            Me.chkMartes.Name = "chkMartes"
            Me.chkMartes.Size = New System.Drawing.Size(62, 17)
            Me.chkMartes.TabIndex = 13
            Me.chkMartes.Text = "MARTES"
            Me.chkMartes.UseVisualStyleBackColor = True
            '
            'dtpALunes
            '
            Me.dtpALunes.CustomFormat = "HH:mm"
            Me.dtpALunes.Enabled = False
            Me.dtpALunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpALunes.Location = New System.Drawing.Point(142, 56)
            Me.dtpALunes.Name = "dtpALunes"
            Me.dtpALunes.ShowUpDown = True
            Me.dtpALunes.Size = New System.Drawing.Size(61, 20)
            Me.dtpALunes.TabIndex = 12
            '
            'dtpDLunes
            '
            Me.dtpDLunes.CustomFormat = "HH:mm"
            Me.dtpDLunes.Enabled = False
            Me.dtpDLunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDLunes.Location = New System.Drawing.Point(142, 34)
            Me.dtpDLunes.Name = "dtpDLunes"
            Me.dtpDLunes.ShowUpDown = True
            Me.dtpDLunes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDLunes.TabIndex = 11
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(124, 59)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(19, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "A:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(118, 37)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(25, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "DE:"
            '
            'chkLunes
            '
            Me.chkLunes.AutoSize = True
            Me.chkLunes.Enabled = False
            Me.chkLunes.Location = New System.Drawing.Point(121, 19)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(56, 17)
            Me.chkLunes.TabIndex = 0
            Me.chkLunes.Text = "LUNES"
            Me.chkLunes.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.cbmMotivo)
            Me.GroupBox1.Controls.Add(Me.Label32)
            Me.GroupBox1.Controls.Add(Me.dtpHastaP)
            Me.GroupBox1.Controls.Add(Me.Label20)
            Me.GroupBox1.Controls.Add(Me.dtpDesdeP)
            Me.GroupBox1.Controls.Add(Me.Label31)
            Me.GroupBox1.Controls.Add(Me.txtDetalle)
            Me.GroupBox1.Controls.Add(Me.Label29)
            Me.GroupBox1.Controls.Add(Me.txtArea)
            Me.GroupBox1.Controls.Add(Me.Label27)
            Me.GroupBox1.Controls.Add(Me.txtCargo)
            Me.GroupBox1.Controls.Add(Me.Label25)
            Me.GroupBox1.Controls.Add(Me.btnPersonal)
            Me.GroupBox1.Controls.Add(Me.txtIdPersonal)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.txtPersonal)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 223)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(996, 87)
            Me.GroupBox1.TabIndex = 183
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DEL PERSONAL"
            '
            'cbmMotivo
            '
            Me.cbmMotivo.BackColor = System.Drawing.Color.White
            Me.cbmMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMotivo.Enabled = False
            Me.cbmMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmMotivo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMotivo.FormattingEnabled = True
            Me.cbmMotivo.Items.AddRange(New Object() {"ASISTENCIA NORMAL SEGÚN PROGRAMACIÓN", "PERMISO POR MATERNIDA - PATERNIDAD", "PERMISO  POR CALAMIDAD DOMÉSTICA", "PERMISO  POR DESCANSO MÉDICO", "PERMISO  POR VACACIONES", "OTROS PERMISOS"})
            Me.cbmMotivo.Location = New System.Drawing.Point(729, 37)
            Me.cbmMotivo.Name = "cbmMotivo"
            Me.cbmMotivo.Size = New System.Drawing.Size(261, 21)
            Me.cbmMotivo.TabIndex = 209
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(686, 44)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(37, 13)
            Me.Label32.TabIndex = 208
            Me.Label32.Text = "TIPO:"
            '
            'dtpHastaP
            '
            Me.dtpHastaP.CustomFormat = "MMMM yyyy"
            Me.dtpHastaP.Enabled = False
            Me.dtpHastaP.Location = New System.Drawing.Point(394, 38)
            Me.dtpHastaP.Name = "dtpHastaP"
            Me.dtpHastaP.Size = New System.Drawing.Size(255, 20)
            Me.dtpHastaP.TabIndex = 206
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(341, 41)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 13)
            Me.Label20.TabIndex = 207
            Me.Label20.Text = "TERMINA:"
            '
            'dtpDesdeP
            '
            Me.dtpDesdeP.CustomFormat = "DDDD, dd/MMMM/yyyy"
            Me.dtpDesdeP.Enabled = False
            Me.dtpDesdeP.Location = New System.Drawing.Point(55, 38)
            Me.dtpDesdeP.Name = "dtpDesdeP"
            Me.dtpDesdeP.Size = New System.Drawing.Size(255, 20)
            Me.dtpDesdeP.TabIndex = 204
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(8, 41)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(49, 13)
            Me.Label31.TabIndex = 205
            Me.Label31.Text = "INICIA:"
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Location = New System.Drawing.Point(89, 62)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(905, 20)
            Me.txtDetalle.TabIndex = 199
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(7, 65)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(79, 13)
            Me.Label29.TabIndex = 198
            Me.Label29.Text = "OBSERVACIÓN:"
            '
            'txtArea
            '
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Location = New System.Drawing.Point(113, 38)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(192, 20)
            Me.txtArea.TabIndex = 197
            Me.txtArea.Visible = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(265, 41)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 196
            Me.Label27.Text = "ÁREA:"
            Me.Label27.Visible = False
            '
            'txtCargo
            '
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Location = New System.Drawing.Point(69, 38)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(187, 20)
            Me.txtCargo.TabIndex = 195
            Me.txtCargo.Visible = False
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(23, 41)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(43, 13)
            Me.Label25.TabIndex = 194
            Me.Label25.Text = "CARGO:"
            Me.Label25.Visible = False
            '
            'btnPersonal
            '
            Me.btnPersonal.BackColor = System.Drawing.Color.White
            Me.btnPersonal.Enabled = False
            Me.btnPersonal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonal.Image = CType(resources.GetObject("btnPersonal.Image"), System.Drawing.Image)
            Me.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPersonal.Location = New System.Drawing.Point(964, 9)
            Me.btnPersonal.Name = "btnPersonal"
            Me.btnPersonal.Size = New System.Drawing.Size(26, 26)
            Me.btnPersonal.TabIndex = 193
            Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonal.UseVisualStyleBackColor = False
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(44, 12)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(57, 20)
            Me.txtIdPersonal.TabIndex = 28
            Me.txtIdPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(8, 16)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(25, 13)
            Me.Label22.TabIndex = 8
            Me.Label22.Text = "ID:"
            '
            'txtPersonal
            '
            Me.txtPersonal.BackColor = System.Drawing.Color.White
            Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPersonal.Enabled = False
            Me.txtPersonal.Location = New System.Drawing.Point(182, 14)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(780, 20)
            Me.txtPersonal.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(130, 17)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(55, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "NOMBRES:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnEditar, Me.btnCancelar, Me.btnMesAnterior})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
            Me.MenuStrip1.TabIndex = 182
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 20)
            Me.ToolStripMenuItem1.Text = "VER PROGRAMACIÓN"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnEditar
            '
            Me.btnEditar.Enabled = False
            Me.btnEditar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEditar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnEditar.Name = "btnEditar"
            Me.btnEditar.Size = New System.Drawing.Size(77, 20)
            Me.btnEditar.Text = "EDITAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnMesAnterior
            '
            Me.btnMesAnterior.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMesAnterior.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnMesAnterior.Name = "btnMesAnterior"
            Me.btnMesAnterior.Size = New System.Drawing.Size(91, 20)
            Me.btnMesAnterior.Text = "MES ANT."
            '
            'Label24
            '
            Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label24.Location = New System.Drawing.Point(0, 312)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(936, 24)
            Me.Label24.TabIndex = 195
            Me.Label24.Text = "PERSONAL ASIGNADO A PUESTOS DE TRABAJO SEGÚN PROGRAMACIÓN"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.btnReporte)
            Me.tpReporte.Controls.Add(Me.DateTimePicker3)
            Me.tpReporte.Controls.Add(Me.Label30)
            Me.tpReporte.Controls.Add(Me.crvSitios)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1002, 666)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'btnReporte
            '
            Me.btnReporte.BackColor = System.Drawing.Color.White
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.ForeColor = System.Drawing.Color.Black
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(825, 5)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(171, 25)
            Me.btnReporte.TabIndex = 191
            Me.btnReporte.Text = "CARGAR REPORTE PROGRAMACIÓN"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.UseVisualStyleBackColor = False
            '
            'DateTimePicker3
            '
            Me.DateTimePicker3.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DateTimePicker3.Location = New System.Drawing.Point(698, 7)
            Me.DateTimePicker3.Name = "DateTimePicker3"
            Me.DateTimePicker3.ShowUpDown = True
            Me.DateTimePicker3.Size = New System.Drawing.Size(121, 20)
            Me.DateTimePicker3.TabIndex = 200
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(662, 11)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(33, 13)
            Me.Label30.TabIndex = 201
            Me.Label30.Text = "MES:"
            '
            'crvSitios
            '
            Me.crvSitios.ActiveViewIndex = -1
            Me.crvSitios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvSitios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSitios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSitios.Location = New System.Drawing.Point(3, 3)
            Me.crvSitios.Name = "crvSitios"
            Me.crvSitios.Size = New System.Drawing.Size(996, 660)
            Me.crvSitios.TabIndex = 0
            Me.crvSitios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FrmProgramacionGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 696)
            Me.Controls.Add(Me.tcSitios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmProgramacionGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "PROGRAMACIÓN GENERA"
            Me.tcSitios.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.tpReporte.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcSitios As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpADomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDDomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
        Friend WithEvents dtpASabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDSabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpALunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDLunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnPersonal As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents crvSitios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents bntPuesto As System.Windows.Forms.Button
        Friend WithEvents txtIdSitio As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtSitio As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents lblIdHorario As System.Windows.Forms.Label
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
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbmSitio As System.Windows.Forms.ComboBox
        Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtNumHorario As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpHastaP As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents dtpDesdeP As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnNoProgramacion As System.Windows.Forms.Button
        Friend WithEvents btnNoSitiosProgramacion As System.Windows.Forms.Button
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents cbmMotivo As System.Windows.Forms.ComboBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents btnMesAnterior As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtPo As System.Windows.Forms.TextBox
        Friend WithEvents txtP8 As System.Windows.Forms.TextBox
        Friend WithEvents txtP12 As System.Windows.Forms.TextBox
        Friend WithEvents txtP24 As System.Windows.Forms.TextBox
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents Label36 As System.Windows.Forms.Label
    End Class
End Namespace