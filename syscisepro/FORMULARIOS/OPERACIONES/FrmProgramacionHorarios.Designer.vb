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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramacionHorarios))
            Me.tcSitios = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dgvHorarios = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtTotalHoras = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtHoras100 = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtHoras50 = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtRecargoNocturno = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtHorasRegular = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
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
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.CmbTipo = New System.Windows.Forms.ComboBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.cbmCategoria = New System.Windows.Forms.ComboBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtIdHorario = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtDefinicion = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.crvSitios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcSitios.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.tcSitios.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcSitios.Location = New System.Drawing.Point(1, 2)
            Me.tcSitios.Name = "tcSitios"
            Me.tcSitios.SelectedIndex = 0
            Me.tcSitios.Size = New System.Drawing.Size(1017, 694)
            Me.tcSitios.TabIndex = 1
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.Label21)
            Me.TabPage1.Controls.Add(Me.txtFiltro)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.dgvHorarios)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.MenuStrip1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1009, 668)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "MANTENIMIENTO"
            '
            'Label21
            '
            Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label21.Location = New System.Drawing.Point(1, 217)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(1007, 16)
            Me.Label21.TabIndex = 194
            Me.Label21.Text = "HORARIOS REGISTRADOS"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFiltro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(62, 236)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(944, 21)
            Me.txtFiltro.TabIndex = 191
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label7.Location = New System.Drawing.Point(8, 239)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(46, 13)
            Me.Label7.TabIndex = 190
            Me.Label7.Text = "FILTRO:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'dgvHorarios
            '
            Me.dgvHorarios.AllowUserToAddRows = False
            Me.dgvHorarios.AllowUserToDeleteRows = False
            Me.dgvHorarios.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvHorarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvHorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvHorarios.BackgroundColor = System.Drawing.Color.White
            Me.dgvHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHorarios.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvHorarios.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvHorarios.Location = New System.Drawing.Point(4, 263)
            Me.dgvHorarios.MultiSelect = False
            Me.dgvHorarios.Name = "dgvHorarios"
            Me.dgvHorarios.ReadOnly = True
            Me.dgvHorarios.RowHeadersVisible = False
            Me.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHorarios.Size = New System.Drawing.Size(1001, 401)
            Me.dgvHorarios.TabIndex = 188
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.txtTotalHoras)
            Me.GroupBox2.Controls.Add(Me.Label25)
            Me.GroupBox2.Controls.Add(Me.txtObservacion)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.txtHoras100)
            Me.GroupBox2.Controls.Add(Me.Label19)
            Me.GroupBox2.Controls.Add(Me.txtHoras50)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.txtRecargoNocturno)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.txtHorasRegular)
            Me.GroupBox2.Controls.Add(Me.Label16)
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
            Me.GroupBox2.Controls.Add(Me.btnCalcular)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(3, 71)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1003, 145)
            Me.GroupBox2.TabIndex = 187
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DETALLE"
            '
            'txtTotalHoras
            '
            Me.txtTotalHoras.BackColor = System.Drawing.Color.White
            Me.txtTotalHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalHoras.Enabled = False
            Me.txtTotalHoras.Location = New System.Drawing.Point(81, 115)
            Me.txtTotalHoras.Name = "txtTotalHoras"
            Me.txtTotalHoras.Size = New System.Drawing.Size(50, 21)
            Me.txtTotalHoras.TabIndex = 195
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(8, 109)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(79, 26)
            Me.Label25.TabIndex = 194
            Me.Label25.Text = "HORAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRABAJADAS:"
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Location = New System.Drawing.Point(630, 102)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(347, 37)
            Me.txtObservacion.TabIndex = 52
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(628, 91)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(85, 13)
            Me.Label20.TabIndex = 51
            Me.Label20.Text = "OBSERVACIÓN:"
            '
            'txtHoras100
            '
            Me.txtHoras100.BackColor = System.Drawing.Color.White
            Me.txtHoras100.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras100.Enabled = False
            Me.txtHoras100.Location = New System.Drawing.Point(540, 113)
            Me.txtHoras100.Name = "txtHoras100"
            Me.txtHoras100.Size = New System.Drawing.Size(50, 21)
            Me.txtHoras100.TabIndex = 50
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(488, 116)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(50, 13)
            Me.Label19.TabIndex = 49
            Me.Label19.Text = "H. 100%:"
            '
            'txtHoras50
            '
            Me.txtHoras50.BackColor = System.Drawing.Color.White
            Me.txtHoras50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras50.Enabled = False
            Me.txtHoras50.Location = New System.Drawing.Point(422, 113)
            Me.txtHoras50.Name = "txtHoras50"
            Me.txtHoras50.Size = New System.Drawing.Size(50, 21)
            Me.txtHoras50.TabIndex = 48
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(377, 116)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(44, 13)
            Me.Label18.TabIndex = 47
            Me.Label18.Text = "H. 50%:"
            '
            'txtRecargoNocturno
            '
            Me.txtRecargoNocturno.BackColor = System.Drawing.Color.White
            Me.txtRecargoNocturno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecargoNocturno.Enabled = False
            Me.txtRecargoNocturno.Location = New System.Drawing.Point(308, 113)
            Me.txtRecargoNocturno.Name = "txtRecargoNocturno"
            Me.txtRecargoNocturno.Size = New System.Drawing.Size(50, 21)
            Me.txtRecargoNocturno.TabIndex = 46
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(273, 116)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(31, 13)
            Me.Label17.TabIndex = 45
            Me.Label17.Text = "R. N:"
            '
            'txtHorasRegular
            '
            Me.txtHorasRegular.BackColor = System.Drawing.Color.White
            Me.txtHorasRegular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHorasRegular.Enabled = False
            Me.txtHorasRegular.Location = New System.Drawing.Point(200, 113)
            Me.txtHorasRegular.Name = "txtHorasRegular"
            Me.txtHorasRegular.Size = New System.Drawing.Size(50, 21)
            Me.txtHorasRegular.TabIndex = 44
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(165, 116)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(31, 13)
            Me.Label16.TabIndex = 43
            Me.Label16.Text = "H. R:"
            '
            'dtpADomingo
            '
            Me.dtpADomingo.CustomFormat = "HH:mm"
            Me.dtpADomingo.Enabled = False
            Me.dtpADomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpADomingo.Location = New System.Drawing.Point(936, 66)
            Me.dtpADomingo.Name = "dtpADomingo"
            Me.dtpADomingo.ShowUpDown = True
            Me.dtpADomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpADomingo.TabIndex = 42
            '
            'dtpDeDomingo
            '
            Me.dtpDeDomingo.CustomFormat = "HH:mm"
            Me.dtpDeDomingo.Enabled = False
            Me.dtpDeDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeDomingo.Location = New System.Drawing.Point(936, 40)
            Me.dtpDeDomingo.Name = "dtpDeDomingo"
            Me.dtpDeDomingo.ShowUpDown = True
            Me.dtpDeDomingo.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeDomingo.TabIndex = 41
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(918, 69)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(17, 13)
            Me.Label14.TabIndex = 40
            Me.Label14.Text = "A:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(912, 43)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(23, 13)
            Me.Label15.TabIndex = 39
            Me.Label15.Text = "DE:"
            '
            'chkDomingo
            '
            Me.chkDomingo.AutoSize = True
            Me.chkDomingo.Enabled = False
            Me.chkDomingo.Location = New System.Drawing.Point(915, 17)
            Me.chkDomingo.Name = "chkDomingo"
            Me.chkDomingo.Size = New System.Drawing.Size(78, 17)
            Me.chkDomingo.TabIndex = 38
            Me.chkDomingo.Text = "DOMINGO"
            Me.chkDomingo.UseVisualStyleBackColor = True
            '
            'dtpASabado
            '
            Me.dtpASabado.CustomFormat = "HH:mm"
            Me.dtpASabado.Enabled = False
            Me.dtpASabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpASabado.Location = New System.Drawing.Point(794, 66)
            Me.dtpASabado.Name = "dtpASabado"
            Me.dtpASabado.ShowUpDown = True
            Me.dtpASabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpASabado.TabIndex = 37
            '
            'dtpDeSabado
            '
            Me.dtpDeSabado.CustomFormat = "HH:mm"
            Me.dtpDeSabado.Enabled = False
            Me.dtpDeSabado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeSabado.Location = New System.Drawing.Point(794, 40)
            Me.dtpDeSabado.Name = "dtpDeSabado"
            Me.dtpDeSabado.ShowUpDown = True
            Me.dtpDeSabado.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeSabado.TabIndex = 36
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(776, 69)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(17, 13)
            Me.Label12.TabIndex = 35
            Me.Label12.Text = "A:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(770, 43)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(23, 13)
            Me.Label13.TabIndex = 34
            Me.Label13.Text = "DE:"
            '
            'chkSabado
            '
            Me.chkSabado.AutoSize = True
            Me.chkSabado.Enabled = False
            Me.chkSabado.Location = New System.Drawing.Point(773, 17)
            Me.chkSabado.Name = "chkSabado"
            Me.chkSabado.Size = New System.Drawing.Size(69, 17)
            Me.chkSabado.TabIndex = 33
            Me.chkSabado.Text = "SÁBADO"
            Me.chkSabado.UseVisualStyleBackColor = True
            '
            'dtpAViernes
            '
            Me.dtpAViernes.CustomFormat = "HH:mm"
            Me.dtpAViernes.Enabled = False
            Me.dtpAViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAViernes.Location = New System.Drawing.Point(651, 66)
            Me.dtpAViernes.Name = "dtpAViernes"
            Me.dtpAViernes.ShowUpDown = True
            Me.dtpAViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAViernes.TabIndex = 32
            '
            'dtpDeViernes
            '
            Me.dtpDeViernes.CustomFormat = "HH:mm"
            Me.dtpDeViernes.Enabled = False
            Me.dtpDeViernes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeViernes.Location = New System.Drawing.Point(651, 40)
            Me.dtpDeViernes.Name = "dtpDeViernes"
            Me.dtpDeViernes.ShowUpDown = True
            Me.dtpDeViernes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeViernes.TabIndex = 31
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(633, 69)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(17, 13)
            Me.Label10.TabIndex = 30
            Me.Label10.Text = "A:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(627, 43)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(23, 13)
            Me.Label11.TabIndex = 29
            Me.Label11.Text = "DE:"
            '
            'chkViernes
            '
            Me.chkViernes.AutoSize = True
            Me.chkViernes.Enabled = False
            Me.chkViernes.Location = New System.Drawing.Point(630, 17)
            Me.chkViernes.Name = "chkViernes"
            Me.chkViernes.Size = New System.Drawing.Size(70, 17)
            Me.chkViernes.TabIndex = 28
            Me.chkViernes.Text = "VIERNES"
            Me.chkViernes.UseVisualStyleBackColor = True
            '
            'dtpAJueves
            '
            Me.dtpAJueves.CustomFormat = "HH:mm"
            Me.dtpAJueves.Enabled = False
            Me.dtpAJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAJueves.Location = New System.Drawing.Point(486, 66)
            Me.dtpAJueves.Name = "dtpAJueves"
            Me.dtpAJueves.ShowUpDown = True
            Me.dtpAJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpAJueves.TabIndex = 27
            '
            'dtpDeJueves
            '
            Me.dtpDeJueves.CustomFormat = "HH:mm"
            Me.dtpDeJueves.Enabled = False
            Me.dtpDeJueves.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeJueves.Location = New System.Drawing.Point(486, 40)
            Me.dtpDeJueves.Name = "dtpDeJueves"
            Me.dtpDeJueves.ShowUpDown = True
            Me.dtpDeJueves.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeJueves.TabIndex = 26
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(468, 69)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(17, 13)
            Me.Label8.TabIndex = 25
            Me.Label8.Text = "A:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(462, 43)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(23, 13)
            Me.Label9.TabIndex = 24
            Me.Label9.Text = "DE:"
            '
            'chkJueves
            '
            Me.chkJueves.AutoSize = True
            Me.chkJueves.Enabled = False
            Me.chkJueves.Location = New System.Drawing.Point(465, 17)
            Me.chkJueves.Name = "chkJueves"
            Me.chkJueves.Size = New System.Drawing.Size(65, 17)
            Me.chkJueves.TabIndex = 23
            Me.chkJueves.Text = "JUEVES"
            Me.chkJueves.UseVisualStyleBackColor = True
            '
            'dtpAMiercoles
            '
            Me.dtpAMiercoles.CustomFormat = "HH:mm"
            Me.dtpAMiercoles.Enabled = False
            Me.dtpAMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMiercoles.Location = New System.Drawing.Point(330, 66)
            Me.dtpAMiercoles.Name = "dtpAMiercoles"
            Me.dtpAMiercoles.ShowUpDown = True
            Me.dtpAMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMiercoles.TabIndex = 22
            '
            'dtpDeMiercoles
            '
            Me.dtpDeMiercoles.CustomFormat = "HH:mm"
            Me.dtpDeMiercoles.Enabled = False
            Me.dtpDeMiercoles.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMiercoles.Location = New System.Drawing.Point(330, 40)
            Me.dtpDeMiercoles.Name = "dtpDeMiercoles"
            Me.dtpDeMiercoles.ShowUpDown = True
            Me.dtpDeMiercoles.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeMiercoles.TabIndex = 21
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(307, 69)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(17, 13)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "A:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(301, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(23, 13)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "DE:"
            '
            'chkMiercoles
            '
            Me.chkMiercoles.AutoSize = True
            Me.chkMiercoles.Enabled = False
            Me.chkMiercoles.Location = New System.Drawing.Point(309, 17)
            Me.chkMiercoles.Name = "chkMiercoles"
            Me.chkMiercoles.Size = New System.Drawing.Size(86, 17)
            Me.chkMiercoles.TabIndex = 18
            Me.chkMiercoles.Text = "MIÉRCOLES"
            Me.chkMiercoles.UseVisualStyleBackColor = True
            '
            'dtpAMartes
            '
            Me.dtpAMartes.CustomFormat = "HH:mm"
            Me.dtpAMartes.Enabled = False
            Me.dtpAMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpAMartes.Location = New System.Drawing.Point(177, 66)
            Me.dtpAMartes.Name = "dtpAMartes"
            Me.dtpAMartes.ShowUpDown = True
            Me.dtpAMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpAMartes.TabIndex = 17
            '
            'dtpDeMartes
            '
            Me.dtpDeMartes.CustomFormat = "HH:mm"
            Me.dtpDeMartes.Enabled = False
            Me.dtpDeMartes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeMartes.Location = New System.Drawing.Point(177, 40)
            Me.dtpDeMartes.Name = "dtpDeMartes"
            Me.dtpDeMartes.ShowUpDown = True
            Me.dtpDeMartes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeMartes.TabIndex = 16
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(159, 69)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(17, 13)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "A:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(153, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(23, 13)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "DE:"
            '
            'chkMartes
            '
            Me.chkMartes.AutoSize = True
            Me.chkMartes.Enabled = False
            Me.chkMartes.Location = New System.Drawing.Point(156, 17)
            Me.chkMartes.Name = "chkMartes"
            Me.chkMartes.Size = New System.Drawing.Size(70, 17)
            Me.chkMartes.TabIndex = 13
            Me.chkMartes.Text = "MARTES"
            Me.chkMartes.UseVisualStyleBackColor = True
            '
            'dtpALunes
            '
            Me.dtpALunes.CustomFormat = "HH:mm"
            Me.dtpALunes.Enabled = False
            Me.dtpALunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpALunes.Location = New System.Drawing.Point(37, 66)
            Me.dtpALunes.Name = "dtpALunes"
            Me.dtpALunes.ShowUpDown = True
            Me.dtpALunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpALunes.TabIndex = 12
            '
            'dtpDeLunes
            '
            Me.dtpDeLunes.CustomFormat = "HH:mm"
            Me.dtpDeLunes.Enabled = False
            Me.dtpDeLunes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDeLunes.Location = New System.Drawing.Point(37, 40)
            Me.dtpDeLunes.Name = "dtpDeLunes"
            Me.dtpDeLunes.ShowUpDown = True
            Me.dtpDeLunes.Size = New System.Drawing.Size(61, 21)
            Me.dtpDeLunes.TabIndex = 11
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(19, 69)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(17, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "A:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(13, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(23, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "DE:"
            '
            'chkLunes
            '
            Me.chkLunes.AutoSize = True
            Me.chkLunes.Enabled = False
            Me.chkLunes.Location = New System.Drawing.Point(16, 17)
            Me.chkLunes.Name = "chkLunes"
            Me.chkLunes.Size = New System.Drawing.Size(60, 17)
            Me.chkLunes.TabIndex = 0
            Me.chkLunes.Text = "LUNES"
            Me.chkLunes.UseVisualStyleBackColor = True
            '
            'btnCalcular
            '
            Me.btnCalcular.BackColor = System.Drawing.Color.White
            Me.btnCalcular.Enabled = False
            Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.btnCalcular.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnCalcular.Location = New System.Drawing.Point(977, 100)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(20, 40)
            Me.btnCalcular.TabIndex = 193
            Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCalcular.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.CmbTipo)
            Me.GroupBox1.Controls.Add(Me.Label24)
            Me.GroupBox1.Controls.Add(Me.cbmCategoria)
            Me.GroupBox1.Controls.Add(Me.Label23)
            Me.GroupBox1.Controls.Add(Me.txtIdHorario)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.txtDefinicion)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 30)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1003, 41)
            Me.GroupBox1.TabIndex = 183
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "HORARIO"
            '
            'CmbTipo
            '
            Me.CmbTipo.BackColor = System.Drawing.Color.White
            Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbTipo.Enabled = False
            Me.CmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CmbTipo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbTipo.FormattingEnabled = True
            Me.CmbTipo.Items.AddRange(New Object() {"ADMINISTRATIVO", "OPERATIVO"})
            Me.CmbTipo.Location = New System.Drawing.Point(630, 14)
            Me.CmbTipo.Name = "CmbTipo"
            Me.CmbTipo.Size = New System.Drawing.Size(116, 21)
            Me.CmbTipo.TabIndex = 94
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(587, 18)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(37, 13)
            Me.Label24.TabIndex = 93
            Me.Label24.Text = "TIPO:"
            '
            'cbmCategoria
            '
            Me.cbmCategoria.BackColor = System.Drawing.Color.White
            Me.cbmCategoria.Enabled = False
            Me.cbmCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCategoria.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoria.FormattingEnabled = True
            Me.cbmCategoria.Location = New System.Drawing.Point(861, 14)
            Me.cbmCategoria.Name = "cbmCategoria"
            Me.cbmCategoria.Size = New System.Drawing.Size(136, 21)
            Me.cbmCategoria.TabIndex = 92
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(796, 18)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(67, 13)
            Me.Label23.TabIndex = 29
            Me.Label23.Text = "CATEGORÍA:"
            '
            'txtIdHorario
            '
            Me.txtIdHorario.BackColor = System.Drawing.Color.White
            Me.txtIdHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdHorario.Enabled = False
            Me.txtIdHorario.Location = New System.Drawing.Point(49, 15)
            Me.txtIdHorario.Name = "txtIdHorario"
            Me.txtIdHorario.Size = New System.Drawing.Size(79, 20)
            Me.txtIdHorario.TabIndex = 28
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
            'txtDefinicion
            '
            Me.txtDefinicion.BackColor = System.Drawing.Color.White
            Me.txtDefinicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDefinicion.Enabled = False
            Me.txtDefinicion.Location = New System.Drawing.Point(232, 15)
            Me.txtDefinicion.Name = "txtDefinicion"
            Me.txtDefinicion.Size = New System.Drawing.Size(307, 20)
            Me.txtDefinicion.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(153, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(73, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "DEFINICIÓN:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnAnular, Me.btnCancelar, Me.ToolStripMenuItem2})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1003, 24)
            Me.MenuStrip1.TabIndex = 182
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
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevo.Text = "NUEVO"
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
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(105, 20)
            Me.btnModificar.Text = "ACTUALIZAR"
            '
            'btnAnular
            '
            Me.btnAnular.Enabled = False
            Me.btnAnular.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(77, 20)
            Me.btnAnular.Text = "ANULAR"
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
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(91, 20)
            Me.ToolStripMenuItem2.Text = "EXPORTAR"
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.Button2)
            Me.tpReporte.Controls.Add(Me.crvSitios)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1009, 668)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.White
            Me.Button2.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Me.Button2.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button2.Location = New System.Drawing.Point(855, 6)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(151, 25)
            Me.Button2.TabIndex = 191
            Me.Button2.Text = "CARGAR REPORTE HORARIOS"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button2.UseVisualStyleBackColor = False
            '
            'crvSitios
            '
            Me.crvSitios.ActiveViewIndex = -1
            Me.crvSitios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvSitios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSitios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSitios.Location = New System.Drawing.Point(3, 3)
            Me.crvSitios.Name = "crvSitios"
            Me.crvSitios.Size = New System.Drawing.Size(1003, 662)
            Me.crvSitios.TabIndex = 0
            Me.crvSitios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FrmProgramacionHorarios
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1018, 696)
            Me.Controls.Add(Me.tcSitios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmProgramacionHorarios"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "PROGRAMACIÓN / HORARIO"
            Me.tcSitios.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcSitios As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dgvHorarios As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtDefinicion As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents crvSitios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents txtIdHorario As System.Windows.Forms.TextBox
        Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpALunes As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDeLunes As System.Windows.Forms.DateTimePicker
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
        Friend WithEvents txtHoras100 As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtHoras50 As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtRecargoNocturno As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtHorasRegular As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents cbmCategoria As System.Windows.Forms.ComboBox
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
    End Class
End Namespace