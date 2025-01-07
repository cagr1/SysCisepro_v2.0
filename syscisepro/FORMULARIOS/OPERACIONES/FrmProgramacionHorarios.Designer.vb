Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmProgramacionHorarios
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramacionHorarios))
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.txtTotalHoras = New System.Windows.Forms.TextBox()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.txtHoras100 = New System.Windows.Forms.TextBox()
            Me.txtHoras50 = New System.Windows.Forms.TextBox()
            Me.txtRecargoNocturno = New System.Windows.Forms.TextBox()
            Me.txtHorasRegular = New System.Windows.Forms.TextBox()
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
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.CmbTipo = New System.Windows.Forms.ComboBox()
            Me.cbmCategoria = New System.Windows.Forms.ComboBox()
            Me.txtIdHorario = New System.Windows.Forms.TextBox()
            Me.txtDefinicion = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.crvSitios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvHorarios = New System.Windows.Forms.DataGridView()
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
            CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFiltro.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(99, 239)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(410, 21)
            Me.txtFiltro.TabIndex = 191
            '
            'txtTotalHoras
            '
            Me.txtTotalHoras.BackColor = System.Drawing.Color.White
            Me.txtTotalHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalHoras.Enabled = False
            Me.txtTotalHoras.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHoras.Location = New System.Drawing.Point(94, 116)
            Me.txtTotalHoras.Name = "txtTotalHoras"
            Me.txtTotalHoras.Size = New System.Drawing.Size(50, 21)
            Me.txtTotalHoras.TabIndex = 195
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(94, 148)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(410, 21)
            Me.txtObservacion.TabIndex = 52
            '
            'txtHoras100
            '
            Me.txtHoras100.BackColor = System.Drawing.Color.White
            Me.txtHoras100.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras100.Enabled = False
            Me.txtHoras100.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHoras100.Location = New System.Drawing.Point(571, 115)
            Me.txtHoras100.Name = "txtHoras100"
            Me.txtHoras100.Size = New System.Drawing.Size(50, 21)
            Me.txtHoras100.TabIndex = 50
            '
            'txtHoras50
            '
            Me.txtHoras50.BackColor = System.Drawing.Color.White
            Me.txtHoras50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras50.Enabled = False
            Me.txtHoras50.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHoras50.Location = New System.Drawing.Point(454, 116)
            Me.txtHoras50.Name = "txtHoras50"
            Me.txtHoras50.Size = New System.Drawing.Size(50, 21)
            Me.txtHoras50.TabIndex = 48
            '
            'txtRecargoNocturno
            '
            Me.txtRecargoNocturno.BackColor = System.Drawing.Color.White
            Me.txtRecargoNocturno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecargoNocturno.Enabled = False
            Me.txtRecargoNocturno.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecargoNocturno.Location = New System.Drawing.Point(340, 115)
            Me.txtRecargoNocturno.Name = "txtRecargoNocturno"
            Me.txtRecargoNocturno.Size = New System.Drawing.Size(50, 21)
            Me.txtRecargoNocturno.TabIndex = 46
            '
            'txtHorasRegular
            '
            Me.txtHorasRegular.BackColor = System.Drawing.Color.White
            Me.txtHorasRegular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHorasRegular.Enabled = False
            Me.txtHorasRegular.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHorasRegular.Location = New System.Drawing.Point(220, 115)
            Me.txtHorasRegular.Name = "txtHorasRegular"
            Me.txtHorasRegular.Size = New System.Drawing.Size(50, 21)
            Me.txtHorasRegular.TabIndex = 44
            '
            'dtpADomingo
            '
            Me.dtpADomingo.CustomFormat = "HH:mm"
            Me.dtpADomingo.Enabled = False
            Me.dtpADomingo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpADomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpADomingo.Location = New System.Drawing.Point(790, 86)
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
            Me.dtpDeDomingo.Location = New System.Drawing.Point(790, 60)
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
            Me.chkDomingo.Location = New System.Drawing.Point(790, 37)
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
            Me.dtpASabado.Location = New System.Drawing.Point(672, 86)
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
            Me.dtpDeSabado.Location = New System.Drawing.Point(672, 60)
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
            Me.chkSabado.Location = New System.Drawing.Point(672, 37)
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
            Me.dtpAViernes.Location = New System.Drawing.Point(560, 86)
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
            Me.dtpDeViernes.Location = New System.Drawing.Point(560, 60)
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
            Me.chkViernes.Location = New System.Drawing.Point(560, 37)
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
            Me.dtpAJueves.Location = New System.Drawing.Point(443, 86)
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
            Me.dtpDeJueves.Location = New System.Drawing.Point(443, 60)
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
            Me.chkJueves.Location = New System.Drawing.Point(443, 37)
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
            Me.dtpAMiercoles.Location = New System.Drawing.Point(329, 86)
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
            Me.dtpDeMiercoles.Location = New System.Drawing.Point(329, 60)
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
            Me.chkMiercoles.Location = New System.Drawing.Point(329, 37)
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
            Me.dtpAMartes.Location = New System.Drawing.Point(209, 86)
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
            Me.dtpDeMartes.Location = New System.Drawing.Point(209, 60)
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
            Me.chkMartes.Location = New System.Drawing.Point(209, 37)
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
            Me.dtpALunes.Location = New System.Drawing.Point(94, 86)
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
            Me.dtpDeLunes.Location = New System.Drawing.Point(94, 60)
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
            Me.chkLunes.Location = New System.Drawing.Point(94, 37)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(56, 17)
            Me.chkLunes.TabIndex = 0
            Me.chkLunes.Text = "Lunes"
            Me.chkLunes.UseVisualStyleBackColor = False
            '
            'btnCalcular
            '
            Me.btnCalcular.BackColor = System.Drawing.Color.Transparent
            Me.btnCalcular.Enabled = False
            Me.btnCalcular.FlatAppearance.BorderSize = 0
            Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.btnCalcular.Image = Global.syscisepro.My.Resources.Resources.edit_calendar_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCalcular.Location = New System.Drawing.Point(525, 139)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(28, 33)
            Me.btnCalcular.TabIndex = 193
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = False
            '
            'CmbTipo
            '
            Me.CmbTipo.BackColor = System.Drawing.Color.White
            Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbTipo.Enabled = False
            Me.CmbTipo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbTipo.FormattingEnabled = True
            Me.CmbTipo.Items.AddRange(New Object() {"ADMINISTRATIVO", "OPERATIVO"})
            Me.CmbTipo.Location = New System.Drawing.Point(306, 4)
            Me.CmbTipo.Name = "CmbTipo"
            Me.CmbTipo.Size = New System.Drawing.Size(116, 21)
            Me.CmbTipo.TabIndex = 94
            '
            'cbmCategoria
            '
            Me.cbmCategoria.BackColor = System.Drawing.Color.White
            Me.cbmCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoria.Enabled = False
            Me.cbmCategoria.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoria.FormattingEnabled = True
            Me.cbmCategoria.Location = New System.Drawing.Point(514, 4)
            Me.cbmCategoria.Name = "cbmCategoria"
            Me.cbmCategoria.Size = New System.Drawing.Size(136, 21)
            Me.cbmCategoria.TabIndex = 92
            '
            'txtIdHorario
            '
            Me.txtIdHorario.BackColor = System.Drawing.Color.White
            Me.txtIdHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdHorario.Enabled = False
            Me.txtIdHorario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdHorario.Location = New System.Drawing.Point(36, 3)
            Me.txtIdHorario.Name = "txtIdHorario"
            Me.txtIdHorario.Size = New System.Drawing.Size(56, 21)
            Me.txtIdHorario.TabIndex = 28
            '
            'txtDefinicion
            '
            Me.txtDefinicion.BackColor = System.Drawing.Color.White
            Me.txtDefinicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDefinicion.Enabled = False
            Me.txtDefinicion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDefinicion.Location = New System.Drawing.Point(186, 3)
            Me.txtDefinicion.Name = "txtDefinicion"
            Me.txtDefinicion.Size = New System.Drawing.Size(59, 21)
            Me.txtDefinicion.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnAnular, Me.btnCancelar, Me.ToolStripMenuItem2})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(896, 32)
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
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(113, 28)
            Me.btnModificar.Text = "ACTUALIZAR"
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
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem2.Text = "EXPORTAR"
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.White
            Me.Button2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Me.Button2.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button2.Location = New System.Drawing.Point(795, 1)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(80, 29)
            Me.Button2.TabIndex = 191
            Me.Button2.Text = "Reporte"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button2.UseVisualStyleBackColor = False
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
            Me.KryptonNavigator1.Size = New System.Drawing.Size(898, 696)
            Me.KryptonNavigator1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonNavigator1.TabIndex = 2
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.txtFiltro)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel15)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.MenuStrip1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(896, 669)
            Me.KryptonPage1.Text = "Mantinimiento"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "73E5AC233A3044C57C87837D2D02D0DE"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.Button2)
            Me.KryptonPage2.Controls.Add(Me.crvSitios)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(896, 669)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "3032ACAA469F49C002BA09C076795879"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtObservacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnCalcular)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtHoras100)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalHoras)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtHoras50)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRecargoNocturno)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCategoria)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.CmbTipo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtHorasRegular)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdHorario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDefinicion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpADomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeLunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpALunes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkDomingo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpASabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMartes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkSabado)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAMiercoles)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkViernes)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpAJueves)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDeJueves)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(888, 200)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 201
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(106, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(65, 20)
            Me.KryptonLabel2.TabIndex = 202
            Me.KryptonLabel2.Values.Text = "Definicion"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(257, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel3.TabIndex = 203
            Me.KryptonLabel3.Values.Text = "Tipo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(445, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel4.TabIndex = 204
            Me.KryptonLabel4.Values.Text = "Categoria"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(5, 90)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel10.TabIndex = 210
            Me.KryptonLabel10.Values.Text = "Hasta"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(6, 60)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel9.TabIndex = 209
            Me.KryptonLabel9.Values.Text = "Desde"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(5, 34)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel8.TabIndex = 208
            Me.KryptonLabel8.Values.Text = "Horarios"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(6, 116)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel5.TabIndex = 211
            Me.KryptonLabel5.Values.Text = "H trabajadas"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(163, 116)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(35, 20)
            Me.KryptonLabel6.TabIndex = 212
            Me.KryptonLabel6.Values.Text = "H. R."
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(284, 116)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(36, 20)
            Me.KryptonLabel7.TabIndex = 213
            Me.KryptonLabel7.Values.Text = "R. N."
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(393, 116)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel11.TabIndex = 214
            Me.KryptonLabel11.Values.Text = "H. 50%"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(510, 116)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel12.TabIndex = 215
            Me.KryptonLabel12.Values.Text = "H. 100%"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(164, 90)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel13.TabIndex = 216
            Me.KryptonLabel13.Values.Text = "Tipo"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(5, 149)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel14.TabIndex = 217
            Me.KryptonLabel14.Values.Text = "Observaciones"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(11, 239)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel15.TabIndex = 218
            Me.KryptonLabel15.Values.Text = "Buscar"
            '
            'crvSitios
            '
            Me.crvSitios.ActiveViewIndex = -1
            Me.crvSitios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvSitios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSitios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSitios.Location = New System.Drawing.Point(0, 0)
            Me.crvSitios.Name = "crvSitios"
            Me.crvSitios.ShowCloseButton = False
            Me.crvSitios.ShowLogo = False
            Me.crvSitios.Size = New System.Drawing.Size(896, 669)
            Me.crvSitios.TabIndex = 1
            Me.crvSitios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(3, 264)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvHorarios)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(888, 394)
            Me.KryptonGroupBox2.TabIndex = 219
            Me.KryptonGroupBox2.Values.Heading = "Horarios Registrados"
            '
            'dgvHorarios
            '
            Me.dgvHorarios.AllowUserToAddRows = False
            Me.dgvHorarios.AllowUserToDeleteRows = False
            Me.dgvHorarios.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvHorarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvHorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvHorarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHorarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHorarios.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvHorarios.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvHorarios.Location = New System.Drawing.Point(0, 0)
            Me.dgvHorarios.MultiSelect = False
            Me.dgvHorarios.Name = "dgvHorarios"
            Me.dgvHorarios.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHorarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvHorarios.RowHeadersVisible = False
            Me.dgvHorarios.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHorarios.Size = New System.Drawing.Size(884, 370)
            Me.dgvHorarios.TabIndex = 220
            '
            'FrmProgramacionHorarios
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(898, 696)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmProgramacionHorarios"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "PROGRAMACIÓN / HORARIO"
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
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents txtDefinicion As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents txtIdHorario As System.Windows.Forms.TextBox
        Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
        Friend WithEvents dtpALunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeLunes As System.Windows.Forms.DateTimePicker
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
        Friend WithEvents txtHoras100 As System.Windows.Forms.TextBox
        Friend WithEvents txtHoras50 As System.Windows.Forms.TextBox
        Friend WithEvents txtRecargoNocturno As System.Windows.Forms.TextBox
        Friend WithEvents txtHorasRegular As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbmCategoria As System.Windows.Forms.ComboBox
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
        Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents crvSitios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvHorarios As DataGridView
    End Class
End Namespace