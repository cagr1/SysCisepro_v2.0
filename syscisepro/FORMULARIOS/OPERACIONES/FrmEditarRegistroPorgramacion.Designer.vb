Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmEditarRegistroPorgramacion
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
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtIdPuesto = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtUbicacionPuesto = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbmMotivo = New System.Windows.Forms.ComboBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtNumHorario = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpHastaP = New System.Windows.Forms.DateTimePicker()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.dtpDesdeP = New System.Windows.Forms.DateTimePicker()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.lblIdHorario = New System.Windows.Forms.Label()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.dtpADomingo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeDomingo = New System.Windows.Forms.DateTimePicker()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.chkDomingo = New System.Windows.Forms.CheckBox()
            Me.dtpASabado = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeSabado = New System.Windows.Forms.DateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.chkSabado = New System.Windows.Forms.CheckBox()
            Me.dtpAViernes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeViernes = New System.Windows.Forms.DateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.chkViernes = New System.Windows.Forms.CheckBox()
            Me.dtpAJueves = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeJueves = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.chkJueves = New System.Windows.Forms.CheckBox()
            Me.dtpAMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.chkMiercoles = New System.Windows.Forms.CheckBox()
            Me.dtpAMartes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeMartes = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkMartes = New System.Windows.Forms.CheckBox()
            Me.dtpALunes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeLunes = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkLunes = New System.Windows.Forms.CheckBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblIdAsignacion = New System.Windows.Forms.Label()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.txtIdPuesto)
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.txtUbicacionPuesto)
            Me.GroupBox3.Controls.Add(Me.Label23)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(1, 43)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(770, 45)
            Me.GroupBox3.TabIndex = 197
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DATOS DEL PUESTO DE TRABAJO"
            '
            'txtIdPuesto
            '
            Me.txtIdPuesto.BackColor = System.Drawing.Color.White
            Me.txtIdPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPuesto.Enabled = False
            Me.txtIdPuesto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPuesto.Location = New System.Drawing.Point(44, 16)
            Me.txtIdPuesto.Name = "txtIdPuesto"
            Me.txtIdPuesto.Size = New System.Drawing.Size(37, 20)
            Me.txtIdPuesto.TabIndex = 28
            Me.txtIdPuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            'txtUbicacionPuesto
            '
            Me.txtUbicacionPuesto.BackColor = System.Drawing.Color.White
            Me.txtUbicacionPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacionPuesto.Enabled = False
            Me.txtUbicacionPuesto.Location = New System.Drawing.Point(170, 17)
            Me.txtUbicacionPuesto.Name = "txtUbicacionPuesto"
            Me.txtUbicacionPuesto.Size = New System.Drawing.Size(593, 20)
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
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.cbmMotivo)
            Me.GroupBox2.Controls.Add(Me.Label32)
            Me.GroupBox2.Controls.Add(Me.txtNumHorario)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.dtpHastaP)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.dtpDesdeP)
            Me.GroupBox2.Controls.Add(Me.Label31)
            Me.GroupBox2.Controls.Add(Me.txtDetalle)
            Me.GroupBox2.Controls.Add(Me.Label29)
            Me.GroupBox2.Controls.Add(Me.lblIdHorario)
            Me.GroupBox2.Controls.Add(Me.bntHorarios)
            Me.GroupBox2.Controls.Add(Me.dtpADomingo)
            Me.GroupBox2.Controls.Add(Me.dtpDeDomingo)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.chkDomingo)
            Me.GroupBox2.Controls.Add(Me.dtpASabado)
            Me.GroupBox2.Controls.Add(Me.dtpDeSabado)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.chkSabado)
            Me.GroupBox2.Controls.Add(Me.dtpAViernes)
            Me.GroupBox2.Controls.Add(Me.dtpDeViernes)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.chkViernes)
            Me.GroupBox2.Controls.Add(Me.dtpAJueves)
            Me.GroupBox2.Controls.Add(Me.dtpDeJueves)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.chkJueves)
            Me.GroupBox2.Controls.Add(Me.dtpAMiercoles)
            Me.GroupBox2.Controls.Add(Me.dtpDeMiercoles)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.chkMiercoles)
            Me.GroupBox2.Controls.Add(Me.dtpAMartes)
            Me.GroupBox2.Controls.Add(Me.dtpDeMartes)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.chkMartes)
            Me.GroupBox2.Controls.Add(Me.dtpALunes)
            Me.GroupBox2.Controls.Add(Me.dtpDeLunes)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.chkLunes)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(1, 88)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(770, 150)
            Me.GroupBox2.TabIndex = 196
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DATOS DEL HORARIO DE TRABAJO ASIGNADO"
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
            Me.cbmMotivo.Location = New System.Drawing.Point(509, 122)
            Me.cbmMotivo.Name = "cbmMotivo"
            Me.cbmMotivo.Size = New System.Drawing.Size(255, 21)
            Me.cbmMotivo.TabIndex = 217
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(458, 125)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(37, 13)
            Me.Label32.TabIndex = 216
            Me.Label32.Text = "TIPO:"
            '
            'txtNumHorario
            '
            Me.txtNumHorario.BackColor = System.Drawing.Color.White
            Me.txtNumHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumHorario.Enabled = False
            Me.txtNumHorario.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumHorario.Location = New System.Drawing.Point(56, 93)
            Me.txtNumHorario.Name = "txtNumHorario"
            Me.txtNumHorario.Size = New System.Drawing.Size(65, 20)
            Me.txtNumHorario.TabIndex = 215
            Me.txtNumHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 96)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(49, 13)
            Me.Label7.TabIndex = 214
            Me.Label7.Text = "N° HOR:"
            '
            'dtpHastaP
            '
            Me.dtpHastaP.CustomFormat = "MMMM yyyy"
            Me.dtpHastaP.Location = New System.Drawing.Point(509, 97)
            Me.dtpHastaP.Name = "dtpHastaP"
            Me.dtpHastaP.Size = New System.Drawing.Size(255, 20)
            Me.dtpHastaP.TabIndex = 212
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(458, 100)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 13)
            Me.Label20.TabIndex = 213
            Me.Label20.Text = "TERMINA:"
            '
            'dtpDesdeP
            '
            Me.dtpDesdeP.CustomFormat = "MMMM yyyy"
            Me.dtpDesdeP.Location = New System.Drawing.Point(188, 97)
            Me.dtpDesdeP.Name = "dtpDesdeP"
            Me.dtpDesdeP.Size = New System.Drawing.Size(255, 20)
            Me.dtpDesdeP.TabIndex = 210
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(141, 100)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(49, 13)
            Me.Label31.TabIndex = 211
            Me.Label31.Text = "INICIA:"
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Location = New System.Drawing.Point(56, 123)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(387, 20)
            Me.txtDetalle.TabIndex = 209
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(3, 126)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(55, 13)
            Me.Label29.TabIndex = 208
            Me.Label29.Text = "DETALLE:"
            '
            'lblIdHorario
            '
            Me.lblIdHorario.AutoSize = True
            Me.lblIdHorario.Location = New System.Drawing.Point(549, 70)
            Me.lblIdHorario.Name = "lblIdHorario"
            Me.lblIdHorario.Size = New System.Drawing.Size(0, 13)
            Me.lblIdHorario.TabIndex = 195
            Me.lblIdHorario.Visible = False
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.White
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.bntHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntHorarios.Location = New System.Drawing.Point(737, 17)
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
            Me.dtpADomingo.Location = New System.Drawing.Point(690, 68)
            Me.dtpADomingo.Name = "dtpADomingo"
            Me.dtpADomingo.ShowUpDown = True
            Me.dtpADomingo.Size = New System.Drawing.Size(61, 20)
            Me.dtpADomingo.TabIndex = 42
            '
            'dtpDeDomingo
            '
            Me.dtpDeDomingo.CustomFormat = "HH:mm"
            Me.dtpDeDomingo.Enabled = False
            Me.dtpDeDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeDomingo.Location = New System.Drawing.Point(690, 47)
            Me.dtpDeDomingo.Name = "dtpDeDomingo"
            Me.dtpDeDomingo.ShowUpDown = True
            Me.dtpDeDomingo.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeDomingo.TabIndex = 41
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(672, 71)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(19, 13)
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "A:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(666, 50)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(25, 13)
            Me.Label15.TabIndex = 39
            Me.Label15.Text = "DE:"
            '
            'chkDomingo
            '
            Me.chkDomingo.AutoSize = True
            Me.chkDomingo.Enabled = False
            Me.chkDomingo.Location = New System.Drawing.Point(669, 24)
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
            Me.dtpASabado.Location = New System.Drawing.Point(583, 68)
            Me.dtpASabado.Name = "dtpASabado"
            Me.dtpASabado.ShowUpDown = True
            Me.dtpASabado.Size = New System.Drawing.Size(61, 20)
            Me.dtpASabado.TabIndex = 37
            '
            'dtpDeSabado
            '
            Me.dtpDeSabado.CustomFormat = "HH:mm"
            Me.dtpDeSabado.Enabled = False
            Me.dtpDeSabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeSabado.Location = New System.Drawing.Point(583, 47)
            Me.dtpDeSabado.Name = "dtpDeSabado"
            Me.dtpDeSabado.ShowUpDown = True
            Me.dtpDeSabado.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeSabado.TabIndex = 36
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(565, 71)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(19, 13)
            Me.Label12.TabIndex = 35
            Me.Label12.Text = "A:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(559, 50)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(25, 13)
            Me.Label13.TabIndex = 34
            Me.Label13.Text = "DE:"
            '
            'chkSabado
            '
            Me.chkSabado.AutoSize = True
            Me.chkSabado.Enabled = False
            Me.chkSabado.Location = New System.Drawing.Point(562, 24)
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
            Me.dtpAViernes.Location = New System.Drawing.Point(475, 68)
            Me.dtpAViernes.Name = "dtpAViernes"
            Me.dtpAViernes.ShowUpDown = True
            Me.dtpAViernes.Size = New System.Drawing.Size(61, 20)
            Me.dtpAViernes.TabIndex = 32
            '
            'dtpDeViernes
            '
            Me.dtpDeViernes.CustomFormat = "HH:mm"
            Me.dtpDeViernes.Enabled = False
            Me.dtpDeViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeViernes.Location = New System.Drawing.Point(475, 47)
            Me.dtpDeViernes.Name = "dtpDeViernes"
            Me.dtpDeViernes.ShowUpDown = True
            Me.dtpDeViernes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeViernes.TabIndex = 31
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(457, 71)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(19, 13)
            Me.Label10.TabIndex = 30
            Me.Label10.Text = "A:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(451, 50)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(25, 13)
            Me.Label11.TabIndex = 29
            Me.Label11.Text = "DE:"
            '
            'chkViernes
            '
            Me.chkViernes.AutoSize = True
            Me.chkViernes.Enabled = False
            Me.chkViernes.Location = New System.Drawing.Point(454, 24)
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
            Me.dtpAJueves.Location = New System.Drawing.Point(369, 68)
            Me.dtpAJueves.Name = "dtpAJueves"
            Me.dtpAJueves.ShowUpDown = True
            Me.dtpAJueves.Size = New System.Drawing.Size(61, 20)
            Me.dtpAJueves.TabIndex = 27
            '
            'dtpDeJueves
            '
            Me.dtpDeJueves.CustomFormat = "HH:mm"
            Me.dtpDeJueves.Enabled = False
            Me.dtpDeJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeJueves.Location = New System.Drawing.Point(369, 47)
            Me.dtpDeJueves.Name = "dtpDeJueves"
            Me.dtpDeJueves.ShowUpDown = True
            Me.dtpDeJueves.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeJueves.TabIndex = 26
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(351, 71)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(19, 13)
            Me.Label8.TabIndex = 25
            Me.Label8.Text = "A:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(345, 50)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(25, 13)
            Me.Label9.TabIndex = 24
            Me.Label9.Text = "DE:"
            '
            'chkJueves
            '
            Me.chkJueves.AutoSize = True
            Me.chkJueves.Enabled = False
            Me.chkJueves.Location = New System.Drawing.Point(348, 24)
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
            Me.dtpAMiercoles.Location = New System.Drawing.Point(258, 68)
            Me.dtpAMiercoles.Name = "dtpAMiercoles"
            Me.dtpAMiercoles.ShowUpDown = True
            Me.dtpAMiercoles.Size = New System.Drawing.Size(61, 20)
            Me.dtpAMiercoles.TabIndex = 22
            '
            'dtpDeMiercoles
            '
            Me.dtpDeMiercoles.CustomFormat = "HH:mm"
            Me.dtpDeMiercoles.Enabled = False
            Me.dtpDeMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMiercoles.Location = New System.Drawing.Point(258, 47)
            Me.dtpDeMiercoles.Name = "dtpDeMiercoles"
            Me.dtpDeMiercoles.ShowUpDown = True
            Me.dtpDeMiercoles.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeMiercoles.TabIndex = 21
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(235, 71)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(19, 13)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "A:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(229, 50)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(25, 13)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "DE:"
            '
            'chkMiercoles
            '
            Me.chkMiercoles.AutoSize = True
            Me.chkMiercoles.Enabled = False
            Me.chkMiercoles.Location = New System.Drawing.Point(237, 24)
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
            Me.dtpAMartes.Location = New System.Drawing.Point(147, 68)
            Me.dtpAMartes.Name = "dtpAMartes"
            Me.dtpAMartes.ShowUpDown = True
            Me.dtpAMartes.Size = New System.Drawing.Size(61, 20)
            Me.dtpAMartes.TabIndex = 17
            '
            'dtpDeMartes
            '
            Me.dtpDeMartes.CustomFormat = "HH:mm"
            Me.dtpDeMartes.Enabled = False
            Me.dtpDeMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMartes.Location = New System.Drawing.Point(147, 47)
            Me.dtpDeMartes.Name = "dtpDeMartes"
            Me.dtpDeMartes.ShowUpDown = True
            Me.dtpDeMartes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeMartes.TabIndex = 16
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(129, 71)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(19, 13)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "A:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(123, 50)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(25, 13)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "DE:"
            '
            'chkMartes
            '
            Me.chkMartes.AutoSize = True
            Me.chkMartes.Enabled = False
            Me.chkMartes.Location = New System.Drawing.Point(126, 24)
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
            Me.dtpALunes.Location = New System.Drawing.Point(37, 68)
            Me.dtpALunes.Name = "dtpALunes"
            Me.dtpALunes.ShowUpDown = True
            Me.dtpALunes.Size = New System.Drawing.Size(61, 20)
            Me.dtpALunes.TabIndex = 12
            '
            'dtpDeLunes
            '
            Me.dtpDeLunes.CustomFormat = "HH:mm"
            Me.dtpDeLunes.Enabled = False
            Me.dtpDeLunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeLunes.Location = New System.Drawing.Point(37, 47)
            Me.dtpDeLunes.Name = "dtpDeLunes"
            Me.dtpDeLunes.ShowUpDown = True
            Me.dtpDeLunes.Size = New System.Drawing.Size(61, 20)
            Me.dtpDeLunes.TabIndex = 11
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(19, 71)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(19, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "A:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 50)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(25, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "DE:"
            '
            'chkLunes
            '
            Me.chkLunes.AutoSize = True
            Me.chkLunes.Enabled = False
            Me.chkLunes.Location = New System.Drawing.Point(16, 24)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(56, 17)
            Me.chkLunes.TabIndex = 0
            Me.chkLunes.Text = "LUNES"
            Me.chkLunes.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblIdAsignacion)
            Me.GroupBox1.Controls.Add(Me.txtIdPersonal)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.txtPersonal)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(770, 42)
            Me.GroupBox1.TabIndex = 195
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DEL PERSONAL"
            '
            'lblIdAsignacion
            '
            Me.lblIdAsignacion.AutoSize = True
            Me.lblIdAsignacion.Location = New System.Drawing.Point(100, 17)
            Me.lblIdAsignacion.Name = "lblIdAsignacion"
            Me.lblIdAsignacion.Size = New System.Drawing.Size(0, 13)
            Me.lblIdAsignacion.TabIndex = 196
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(44, 14)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(37, 20)
            Me.txtIdPersonal.TabIndex = 28
            Me.txtIdPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(18, 19)
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
            Me.txtPersonal.Location = New System.Drawing.Point(219, 15)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(544, 20)
            Me.txtPersonal.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(167, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(55, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "NOMBRES:"
            '
            'Button2
            '
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(686, 241)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 199
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.Location = New System.Drawing.Point(605, 241)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 198
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'FrmEditarRegistroPorgramacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(773, 271)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmEditarRegistroPorgramacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MODOFICAR REGISTRO DE PROGRAMACIÓN"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtUbicacionPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdHorario As System.Windows.Forms.Label
        Friend WithEvents bntHorarios As System.Windows.Forms.Button
        Friend WithEvents dtpADomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeDomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
        Friend WithEvents dtpASabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeSabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpALunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeLunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdAsignacion As System.Windows.Forms.Label
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents dtpHastaP As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents dtpDesdeP As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents txtNumHorario As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbmMotivo As System.Windows.Forms.ComboBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
    End Class
End Namespace