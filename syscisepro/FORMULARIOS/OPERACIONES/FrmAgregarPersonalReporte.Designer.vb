Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmAgregarPersonalReporte
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarPersonalReporte))
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.lblRiver = New System.Windows.Forms.Label()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtIdPuesto = New System.Windows.Forms.TextBox()
            Me.txtUbicacionPuesto = New System.Windows.Forms.TextBox()
            Me.lblDiaNoche = New System.Windows.Forms.Label()
            Me.lblDias = New System.Windows.Forms.Label()
            Me.lblIdHorario = New System.Windows.Forms.Label()
            Me.bntHorarios = New System.Windows.Forms.Button()
            Me.dtpADomingo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeDomingo = New System.Windows.Forms.DateTimePicker()
            Me.chkDomingo = New System.Windows.Forms.CheckBox()
            Me.dtpASabado = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeSabado = New System.Windows.Forms.DateTimePicker()
            Me.chkSabado = New System.Windows.Forms.CheckBox()
            Me.dtpAViernes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeViernes = New System.Windows.Forms.DateTimePicker()
            Me.chkViernes = New System.Windows.Forms.CheckBox()
            Me.dtpAJueves = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeJueves = New System.Windows.Forms.DateTimePicker()
            Me.chkJueves = New System.Windows.Forms.CheckBox()
            Me.dtpAMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeMiercoles = New System.Windows.Forms.DateTimePicker()
            Me.chkMiercoles = New System.Windows.Forms.CheckBox()
            Me.dtpAMartes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeMartes = New System.Windows.Forms.DateTimePicker()
            Me.chkMartes = New System.Windows.Forms.CheckBox()
            Me.dtpALunes = New System.Windows.Forms.DateTimePicker()
            Me.dtpDeLunes = New System.Windows.Forms.DateTimePicker()
            Me.chkLunes = New System.Windows.Forms.CheckBox()
            Me.lblIdAsignacion = New System.Windows.Forms.Label()
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.btnPersonal = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.Location = New System.Drawing.Point(474, 99)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(0, 13)
            Me.lblDireccion.TabIndex = 203
            Me.lblDireccion.Visible = False
            '
            'lblRiver
            '
            Me.lblRiver.AutoSize = True
            Me.lblRiver.Location = New System.Drawing.Point(503, 95)
            Me.lblRiver.Name = "lblRiver"
            Me.lblRiver.Size = New System.Drawing.Size(0, 13)
            Me.lblRiver.TabIndex = 202
            Me.lblRiver.Visible = False
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(57, 95)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(390, 21)
            Me.txtCliente.TabIndex = 201
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.location_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.bntPuesto.Location = New System.Drawing.Point(597, 58)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(26, 26)
            Me.bntPuesto.TabIndex = 193
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'txtIdPuesto
            '
            Me.txtIdPuesto.BackColor = System.Drawing.Color.White
            Me.txtIdPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPuesto.Enabled = False
            Me.txtIdPuesto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPuesto.Location = New System.Drawing.Point(57, 62)
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
            Me.txtUbicacionPuesto.Location = New System.Drawing.Point(190, 63)
            Me.txtUbicacionPuesto.Name = "txtUbicacionPuesto"
            Me.txtUbicacionPuesto.Size = New System.Drawing.Size(390, 21)
            Me.txtUbicacionPuesto.TabIndex = 0
            '
            'lblDiaNoche
            '
            Me.lblDiaNoche.AutoSize = True
            Me.lblDiaNoche.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDiaNoche.Location = New System.Drawing.Point(451, 187)
            Me.lblDiaNoche.Name = "lblDiaNoche"
            Me.lblDiaNoche.Size = New System.Drawing.Size(0, 13)
            Me.lblDiaNoche.TabIndex = 197
            Me.lblDiaNoche.Visible = False
            '
            'lblDias
            '
            Me.lblDias.AutoSize = True
            Me.lblDias.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDias.Location = New System.Drawing.Point(355, 179)
            Me.lblDias.Name = "lblDias"
            Me.lblDias.Size = New System.Drawing.Size(0, 13)
            Me.lblDias.TabIndex = 196
            Me.lblDias.Visible = False
            '
            'lblIdHorario
            '
            Me.lblIdHorario.AutoSize = True
            Me.lblIdHorario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdHorario.Location = New System.Drawing.Point(503, 204)
            Me.lblIdHorario.Name = "lblIdHorario"
            Me.lblIdHorario.Size = New System.Drawing.Size(0, 13)
            Me.lblIdHorario.TabIndex = 195
            Me.lblIdHorario.Visible = False
            '
            'bntHorarios
            '
            Me.bntHorarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.bntHorarios.FlatAppearance.BorderSize = 0
            Me.bntHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntHorarios.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntHorarios.Image = Global.syscisepro.My.Resources.Resources.calendar_month_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntHorarios.Location = New System.Drawing.Point(640, 120)
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
            Me.dtpADomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpADomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpADomingo.Location = New System.Drawing.Point(605, 202)
            Me.dtpADomingo.Name = "dtpADomingo"
            Me.dtpADomingo.ShowUpDown = True
            Me.dtpADomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpADomingo.TabIndex = 42
            '
            'dtpDeDomingo
            '
            Me.dtpDeDomingo.CustomFormat = "HH:mm"
            Me.dtpDeDomingo.Enabled = False
            Me.dtpDeDomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeDomingo.Location = New System.Drawing.Point(605, 181)
            Me.dtpDeDomingo.Name = "dtpDeDomingo"
            Me.dtpDeDomingo.ShowUpDown = True
            Me.dtpDeDomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeDomingo.TabIndex = 41
            '
            'chkDomingo
            '
            Me.chkDomingo.AutoSize = True
            Me.chkDomingo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkDomingo.Enabled = False
            Me.chkDomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkDomingo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkDomingo.Location = New System.Drawing.Point(600, 158)
            Me.chkDomingo.Name = "chkDomingo"
            Me.chkDomingo.Size = New System.Drawing.Size(70, 17)
            Me.chkDomingo.TabIndex = 38
            Me.chkDomingo.Text = "Domingo"
            Me.chkDomingo.UseVisualStyleBackColor = False
            '
            'dtpASabado
            '
            Me.dtpASabado.CustomFormat = "HH:mm"
            Me.dtpASabado.Enabled = False
            Me.dtpASabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpASabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpASabado.Location = New System.Drawing.Point(517, 202)
            Me.dtpASabado.Name = "dtpASabado"
            Me.dtpASabado.ShowUpDown = True
            Me.dtpASabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpASabado.TabIndex = 37
            '
            'dtpDeSabado
            '
            Me.dtpDeSabado.CustomFormat = "HH:mm"
            Me.dtpDeSabado.Enabled = False
            Me.dtpDeSabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeSabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeSabado.Location = New System.Drawing.Point(517, 181)
            Me.dtpDeSabado.Name = "dtpDeSabado"
            Me.dtpDeSabado.ShowUpDown = True
            Me.dtpDeSabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeSabado.TabIndex = 36
            '
            'chkSabado
            '
            Me.chkSabado.AutoSize = True
            Me.chkSabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkSabado.Enabled = False
            Me.chkSabado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSabado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkSabado.Location = New System.Drawing.Point(516, 158)
            Me.chkSabado.Name = "chkSabado"
            Me.chkSabado.Size = New System.Drawing.Size(63, 17)
            Me.chkSabado.TabIndex = 33
            Me.chkSabado.Text = "Sabado"
            Me.chkSabado.UseVisualStyleBackColor = False
            '
            'dtpAViernes
            '
            Me.dtpAViernes.CustomFormat = "HH:mm"
            Me.dtpAViernes.Enabled = False
            Me.dtpAViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAViernes.Location = New System.Drawing.Point(429, 202)
            Me.dtpAViernes.Name = "dtpAViernes"
            Me.dtpAViernes.ShowUpDown = True
            Me.dtpAViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAViernes.TabIndex = 32
            '
            'dtpDeViernes
            '
            Me.dtpDeViernes.CustomFormat = "HH:mm"
            Me.dtpDeViernes.Enabled = False
            Me.dtpDeViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeViernes.Location = New System.Drawing.Point(429, 181)
            Me.dtpDeViernes.Name = "dtpDeViernes"
            Me.dtpDeViernes.ShowUpDown = True
            Me.dtpDeViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeViernes.TabIndex = 31
            '
            'chkViernes
            '
            Me.chkViernes.AutoSize = True
            Me.chkViernes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkViernes.Enabled = False
            Me.chkViernes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkViernes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkViernes.Location = New System.Drawing.Point(428, 158)
            Me.chkViernes.Name = "chkViernes"
            Me.chkViernes.Size = New System.Drawing.Size(64, 17)
            Me.chkViernes.TabIndex = 28
            Me.chkViernes.Text = "Viernes"
            Me.chkViernes.UseVisualStyleBackColor = False
            '
            'dtpAJueves
            '
            Me.dtpAJueves.CustomFormat = "HH:mm"
            Me.dtpAJueves.Enabled = False
            Me.dtpAJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAJueves.Location = New System.Drawing.Point(339, 202)
            Me.dtpAJueves.Name = "dtpAJueves"
            Me.dtpAJueves.ShowUpDown = True
            Me.dtpAJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpAJueves.TabIndex = 27
            '
            'dtpDeJueves
            '
            Me.dtpDeJueves.CustomFormat = "HH:mm"
            Me.dtpDeJueves.Enabled = False
            Me.dtpDeJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeJueves.Location = New System.Drawing.Point(339, 181)
            Me.dtpDeJueves.Name = "dtpDeJueves"
            Me.dtpDeJueves.ShowUpDown = True
            Me.dtpDeJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeJueves.TabIndex = 26
            '
            'chkJueves
            '
            Me.chkJueves.AutoSize = True
            Me.chkJueves.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkJueves.Enabled = False
            Me.chkJueves.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkJueves.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkJueves.Location = New System.Drawing.Point(338, 158)
            Me.chkJueves.Name = "chkJueves"
            Me.chkJueves.Size = New System.Drawing.Size(61, 17)
            Me.chkJueves.TabIndex = 23
            Me.chkJueves.Text = "Jueves"
            Me.chkJueves.UseVisualStyleBackColor = False
            '
            'dtpAMiercoles
            '
            Me.dtpAMiercoles.CustomFormat = "HH:mm"
            Me.dtpAMiercoles.Enabled = False
            Me.dtpAMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMiercoles.Location = New System.Drawing.Point(247, 202)
            Me.dtpAMiercoles.Name = "dtpAMiercoles"
            Me.dtpAMiercoles.ShowUpDown = True
            Me.dtpAMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMiercoles.TabIndex = 22
            '
            'dtpDeMiercoles
            '
            Me.dtpDeMiercoles.CustomFormat = "HH:mm"
            Me.dtpDeMiercoles.Enabled = False
            Me.dtpDeMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMiercoles.Location = New System.Drawing.Point(247, 181)
            Me.dtpDeMiercoles.Name = "dtpDeMiercoles"
            Me.dtpDeMiercoles.ShowUpDown = True
            Me.dtpDeMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeMiercoles.TabIndex = 21
            '
            'chkMiercoles
            '
            Me.chkMiercoles.AutoSize = True
            Me.chkMiercoles.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkMiercoles.Enabled = False
            Me.chkMiercoles.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkMiercoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkMiercoles.Location = New System.Drawing.Point(246, 158)
            Me.chkMiercoles.Name = "chkMiercoles"
            Me.chkMiercoles.Size = New System.Drawing.Size(76, 17)
            Me.chkMiercoles.TabIndex = 18
            Me.chkMiercoles.Text = "Miercoles"
            Me.chkMiercoles.UseVisualStyleBackColor = False
            '
            'dtpAMartes
            '
            Me.dtpAMartes.CustomFormat = "HH:mm"
            Me.dtpAMartes.Enabled = False
            Me.dtpAMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMartes.Location = New System.Drawing.Point(159, 202)
            Me.dtpAMartes.Name = "dtpAMartes"
            Me.dtpAMartes.ShowUpDown = True
            Me.dtpAMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMartes.TabIndex = 17
            '
            'dtpDeMartes
            '
            Me.dtpDeMartes.CustomFormat = "HH:mm"
            Me.dtpDeMartes.Enabled = False
            Me.dtpDeMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMartes.Location = New System.Drawing.Point(159, 181)
            Me.dtpDeMartes.Name = "dtpDeMartes"
            Me.dtpDeMartes.ShowUpDown = True
            Me.dtpDeMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeMartes.TabIndex = 16
            '
            'chkMartes
            '
            Me.chkMartes.AutoSize = True
            Me.chkMartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkMartes.Enabled = False
            Me.chkMartes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkMartes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkMartes.Location = New System.Drawing.Point(158, 158)
            Me.chkMartes.Name = "chkMartes"
            Me.chkMartes.Size = New System.Drawing.Size(62, 17)
            Me.chkMartes.TabIndex = 13
            Me.chkMartes.Text = "Martes"
            Me.chkMartes.UseVisualStyleBackColor = False
            '
            'dtpALunes
            '
            Me.dtpALunes.CustomFormat = "HH:mm"
            Me.dtpALunes.Enabled = False
            Me.dtpALunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpALunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpALunes.Location = New System.Drawing.Point(68, 202)
            Me.dtpALunes.Name = "dtpALunes"
            Me.dtpALunes.ShowUpDown = True
            Me.dtpALunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpALunes.TabIndex = 12
            '
            'dtpDeLunes
            '
            Me.dtpDeLunes.CustomFormat = "HH:mm"
            Me.dtpDeLunes.Enabled = False
            Me.dtpDeLunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDeLunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeLunes.Location = New System.Drawing.Point(68, 181)
            Me.dtpDeLunes.Name = "dtpDeLunes"
            Me.dtpDeLunes.ShowUpDown = True
            Me.dtpDeLunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeLunes.TabIndex = 11
            '
            'chkLunes
            '
            Me.chkLunes.AutoSize = True
            Me.chkLunes.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkLunes.Enabled = False
            Me.chkLunes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkLunes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkLunes.Location = New System.Drawing.Point(67, 158)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(56, 17)
            Me.chkLunes.TabIndex = 0
            Me.chkLunes.Text = "Lunes"
            Me.chkLunes.UseVisualStyleBackColor = False
            '
            'lblIdAsignacion
            '
            Me.lblIdAsignacion.AutoSize = True
            Me.lblIdAsignacion.Location = New System.Drawing.Point(117, 8)
            Me.lblIdAsignacion.Name = "lblIdAsignacion"
            Me.lblIdAsignacion.Size = New System.Drawing.Size(0, 13)
            Me.lblIdAsignacion.TabIndex = 196
            '
            'txtArea
            '
            Me.txtArea.BackColor = System.Drawing.Color.White
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArea.Location = New System.Drawing.Point(342, 31)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(238, 21)
            Me.txtArea.TabIndex = 197
            '
            'txtCargo
            '
            Me.txtCargo.BackColor = System.Drawing.Color.White
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCargo.Location = New System.Drawing.Point(57, 33)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(225, 21)
            Me.txtCargo.TabIndex = 195
            '
            'btnPersonal
            '
            Me.btnPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnPersonal.FlatAppearance.BorderSize = 0
            Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPersonal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonal.Image = Global.syscisepro.My.Resources.Resources.person_add_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnPersonal.Location = New System.Drawing.Point(597, 1)
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
            Me.txtIdPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(57, 4)
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
            Me.txtPersonal.Location = New System.Drawing.Point(190, 5)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(390, 21)
            Me.txtPersonal.TabIndex = 0
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(79, Byte), Integer))
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.FlatAppearance.BorderSize = 0
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.White
            Me.Button2.Location = New System.Drawing.Point(598, 272)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(89, 34)
            Me.Button2.TabIndex = 199
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(58, Byte), Integer))
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.White
            Me.Button1.Location = New System.Drawing.Point(490, 272)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(89, 34)
            Me.Button1.TabIndex = 198
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = False
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(1, 8)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblRiver)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblDireccion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdAsignacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblDiaNoche)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblDias)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdHorario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntHorarios)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpADomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtArea)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpASabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtUbicacionPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCargo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpALunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeMiercoles)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(686, 257)
            Me.KryptonGroupBox1.TabIndex = 200
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(7, 204)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel10.TabIndex = 204
            Me.KryptonLabel10.Values.Text = "Hasta"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(5, 180)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel9.TabIndex = 203
            Me.KryptonLabel9.Values.Text = "Desde"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(5, 127)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel8.TabIndex = 202
            Me.KryptonLabel8.Values.Text = "Horarios"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(4, 95)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel7.TabIndex = 200
            Me.KryptonLabel7.Values.Text = "Cliente"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(124, 62)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel6.TabIndex = 199
            Me.KryptonLabel6.Values.Text = "Ubicacion"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(4, 62)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel5.TabIndex = 198
            Me.KryptonLabel5.Values.Text = "Id Sitio"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(300, 30)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(36, 20)
            Me.KryptonLabel4.TabIndex = 196
            Me.KryptonLabel4.Values.Text = "Area"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(4, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel3.TabIndex = 194
            Me.KryptonLabel3.Values.Text = "Cargo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(123, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel2.TabIndex = 29
            Me.KryptonLabel2.Values.Text = "Nombres"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'FrmAgregarPersonalReporte
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(690, 309)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmAgregarPersonalReporte"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AGREGAR PERSONAL"
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents bntPuesto As System.Windows.Forms.Button
        Friend WithEvents txtIdPuesto As System.Windows.Forms.TextBox
        Friend WithEvents txtUbicacionPuesto As System.Windows.Forms.TextBox
        Friend WithEvents lblIdHorario As System.Windows.Forms.Label
        Friend WithEvents bntHorarios As System.Windows.Forms.Button
        Friend WithEvents dtpADomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeDomingo As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
        Friend WithEvents dtpASabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeSabado As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeViernes As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeJueves As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeMiercoles As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
        Friend WithEvents dtpAMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeMartes As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpALunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeLunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
        Friend WithEvents lblIdAsignacion As System.Windows.Forms.Label
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents btnPersonal As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents lblRiver As System.Windows.Forms.Label
        Friend WithEvents lblDias As System.Windows.Forms.Label
        Friend WithEvents lblDiaNoche As System.Windows.Forms.Label
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace