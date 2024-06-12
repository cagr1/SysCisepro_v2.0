Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormParametrosAutorizacionesCajaChica
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametrosAutorizacionesCajaChica))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.tcAutorizaciones = New System.Windows.Forms.TabControl()
            Me.tpAutorizaciones = New System.Windows.Forms.TabPage()
            Me.gbParametrosAutorizaciones = New System.Windows.Forms.GroupBox()
            Me.txtCiudadResponsable = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtNombreResponsable = New System.Windows.Forms.TextBox()
            Me.txtIdResponsable = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.rbInactivo = New System.Windows.Forms.RadioButton()
            Me.rbActivo = New System.Windows.Forms.RadioButton()
            Me.dgvParametroAutorizaciones = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbApellidos = New System.Windows.Forms.RadioButton()
            Me.rbCedula = New System.Windows.Forms.RadioButton()
            Me.dgvPersonal = New System.Windows.Forms.DataGridView()
            Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
            Me.gbDatos = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.cbmParroquias = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNombres = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbmCiudad = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbmProvincias = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.crvAutorizaciones = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcAutorizaciones.SuspendLayout()
            Me.tpAutorizaciones.SuspendLayout()
            Me.gbParametrosAutorizaciones.SuspendLayout()
            CType(Me.dgvParametroAutorizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDatos.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAutorizaciones
            '
            Me.tcAutorizaciones.Controls.Add(Me.tpAutorizaciones)
            Me.tcAutorizaciones.Controls.Add(Me.tpReporte)
            Me.tcAutorizaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAutorizaciones.Location = New System.Drawing.Point(0, 34)
            Me.tcAutorizaciones.Name = "tcAutorizaciones"
            Me.tcAutorizaciones.SelectedIndex = 0
            Me.tcAutorizaciones.Size = New System.Drawing.Size(1010, 651)
            Me.tcAutorizaciones.TabIndex = 0
            '
            'tpAutorizaciones
            '
            Me.tpAutorizaciones.BackColor = System.Drawing.Color.White
            Me.tpAutorizaciones.Controls.Add(Me.gbParametrosAutorizaciones)
            Me.tpAutorizaciones.Controls.Add(Me.GroupBox1)
            Me.tpAutorizaciones.Controls.Add(Me.gbDatos)
            Me.tpAutorizaciones.Location = New System.Drawing.Point(4, 22)
            Me.tpAutorizaciones.Name = "tpAutorizaciones"
            Me.tpAutorizaciones.Padding = New System.Windows.Forms.Padding(3)
            Me.tpAutorizaciones.Size = New System.Drawing.Size(1002, 625)
            Me.tpAutorizaciones.TabIndex = 0
            Me.tpAutorizaciones.Text = "AUTORIZACIONES"
            '
            'gbParametrosAutorizaciones
            '
            Me.gbParametrosAutorizaciones.BackColor = System.Drawing.Color.White
            Me.gbParametrosAutorizaciones.Controls.Add(Me.txtCiudadResponsable)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.Label8)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.txtNombreResponsable)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.txtIdResponsable)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.Label7)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.Label5)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.btnActualizar)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.rbInactivo)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.rbActivo)
            Me.gbParametrosAutorizaciones.Controls.Add(Me.dgvParametroAutorizaciones)
            Me.gbParametrosAutorizaciones.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParametrosAutorizaciones.Location = New System.Drawing.Point(6, 246)
            Me.gbParametrosAutorizaciones.Name = "gbParametrosAutorizaciones"
            Me.gbParametrosAutorizaciones.Size = New System.Drawing.Size(990, 379)
            Me.gbParametrosAutorizaciones.TabIndex = 9
            Me.gbParametrosAutorizaciones.TabStop = False
            Me.gbParametrosAutorizaciones.Text = "PARÁMETROS AUTORIZACIONES"
            '
            'txtCiudadResponsable
            '
            Me.txtCiudadResponsable.BackColor = System.Drawing.Color.White
            Me.txtCiudadResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCiudadResponsable.Enabled = False
            Me.txtCiudadResponsable.Location = New System.Drawing.Point(577, 17)
            Me.txtCiudadResponsable.Name = "txtCiudadResponsable"
            Me.txtCiudadResponsable.Size = New System.Drawing.Size(222, 21)
            Me.txtCiudadResponsable.TabIndex = 18
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(525, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(46, 13)
            Me.Label8.TabIndex = 17
            Me.Label8.Text = "CIUDAD:"
            '
            'txtNombreResponsable
            '
            Me.txtNombreResponsable.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreResponsable.Enabled = False
            Me.txtNombreResponsable.Location = New System.Drawing.Point(185, 17)
            Me.txtNombreResponsable.Name = "txtNombreResponsable"
            Me.txtNombreResponsable.Size = New System.Drawing.Size(297, 21)
            Me.txtNombreResponsable.TabIndex = 16
            '
            'txtIdResponsable
            '
            Me.txtIdResponsable.BackColor = System.Drawing.Color.White
            Me.txtIdResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdResponsable.Enabled = False
            Me.txtIdResponsable.Location = New System.Drawing.Point(32, 17)
            Me.txtIdResponsable.Name = "txtIdResponsable"
            Me.txtIdResponsable.Size = New System.Drawing.Size(70, 21)
            Me.txtIdResponsable.TabIndex = 15
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(124, 20)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(55, 13)
            Me.Label7.TabIndex = 14
            Me.Label7.Text = "NOMBRES:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "ID:"
            '
            'btnActualizar
            '
            Me.btnActualizar.FlatAppearance.BorderSize = 0
            Me.btnActualizar.ForeColor = System.Drawing.Color.Black
            Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
            Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnActualizar.Location = New System.Drawing.Point(901, 13)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(83, 26)
            Me.btnActualizar.TabIndex = 13
            Me.btnActualizar.Text = "ACTUALIZAR"
            Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnActualizar.UseVisualStyleBackColor = True
            '
            'rbInactivo
            '
            Me.rbInactivo.AutoSize = True
            Me.rbInactivo.Location = New System.Drawing.Point(818, 25)
            Me.rbInactivo.Name = "rbInactivo"
            Me.rbInactivo.Size = New System.Drawing.Size(68, 17)
            Me.rbInactivo.TabIndex = 10
            Me.rbInactivo.Text = "INACTIVO"
            Me.rbInactivo.UseVisualStyleBackColor = True
            '
            'rbActivo
            '
            Me.rbActivo.AutoSize = True
            Me.rbActivo.Checked = True
            Me.rbActivo.Location = New System.Drawing.Point(818, 8)
            Me.rbActivo.Name = "rbActivo"
            Me.rbActivo.Size = New System.Drawing.Size(58, 17)
            Me.rbActivo.TabIndex = 9
            Me.rbActivo.TabStop = True
            Me.rbActivo.Text = "ACTIVO"
            Me.rbActivo.UseVisualStyleBackColor = True
            '
            'dgvParametroAutorizaciones
            '
            Me.dgvParametroAutorizaciones.AllowUserToAddRows = False
            Me.dgvParametroAutorizaciones.AllowUserToDeleteRows = False
            Me.dgvParametroAutorizaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvParametroAutorizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvParametroAutorizaciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvParametroAutorizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvParametroAutorizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvParametroAutorizaciones.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvParametroAutorizaciones.Location = New System.Drawing.Point(9, 45)
            Me.dgvParametroAutorizaciones.MultiSelect = False
            Me.dgvParametroAutorizaciones.Name = "dgvParametroAutorizaciones"
            Me.dgvParametroAutorizaciones.ReadOnly = True
            Me.dgvParametroAutorizaciones.RowHeadersVisible = False
            Me.dgvParametroAutorizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvParametroAutorizaciones.Size = New System.Drawing.Size(975, 328)
            Me.dgvParametroAutorizaciones.TabIndex = 8
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.rbApellidos)
            Me.GroupBox1.Controls.Add(Me.rbCedula)
            Me.GroupBox1.Controls.Add(Me.dgvPersonal)
            Me.GroupBox1.Controls.Add(Me.txtParametroBusqueda)
            Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(990, 160)
            Me.GroupBox1.TabIndex = 8
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSCAR AUTORIZADOR"
            '
            'rbApellidos
            '
            Me.rbApellidos.AutoSize = True
            Me.rbApellidos.Checked = True
            Me.rbApellidos.Location = New System.Drawing.Point(78, 19)
            Me.rbApellidos.Name = "rbApellidos"
            Me.rbApellidos.Size = New System.Drawing.Size(74, 17)
            Me.rbApellidos.TabIndex = 7
            Me.rbApellidos.TabStop = True
            Me.rbApellidos.Text = "APELLIDOS"
            Me.rbApellidos.UseVisualStyleBackColor = True
            '
            'rbCedula
            '
            Me.rbCedula.AutoSize = True
            Me.rbCedula.Location = New System.Drawing.Point(9, 20)
            Me.rbCedula.Name = "rbCedula"
            Me.rbCedula.Size = New System.Drawing.Size(61, 17)
            Me.rbCedula.TabIndex = 6
            Me.rbCedula.Text = "CÉDULA"
            Me.rbCedula.UseVisualStyleBackColor = True
            '
            'dgvPersonal
            '
            Me.dgvPersonal.AllowUserToAddRows = False
            Me.dgvPersonal.AllowUserToDeleteRows = False
            Me.dgvPersonal.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPersonal.BackgroundColor = System.Drawing.Color.White
            Me.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPersonal.Location = New System.Drawing.Point(9, 39)
            Me.dgvPersonal.MultiSelect = False
            Me.dgvPersonal.Name = "dgvPersonal"
            Me.dgvPersonal.ReadOnly = True
            Me.dgvPersonal.RowHeadersVisible = False
            Me.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersonal.Size = New System.Drawing.Size(975, 112)
            Me.dgvPersonal.TabIndex = 5
            '
            'txtParametroBusqueda
            '
            Me.txtParametroBusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametroBusqueda.Location = New System.Drawing.Point(169, 15)
            Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
            Me.txtParametroBusqueda.Size = New System.Drawing.Size(815, 21)
            Me.txtParametroBusqueda.TabIndex = 4
            '
            'gbDatos
            '
            Me.gbDatos.Controls.Add(Me.Button1)
            Me.gbDatos.Controls.Add(Me.cbmParroquias)
            Me.gbDatos.Controls.Add(Me.Label9)
            Me.gbDatos.Controls.Add(Me.txtIdPersonal)
            Me.gbDatos.Controls.Add(Me.Label6)
            Me.gbDatos.Controls.Add(Me.txtNombres)
            Me.gbDatos.Controls.Add(Me.Label4)
            Me.gbDatos.Controls.Add(Me.txtCedula)
            Me.gbDatos.Controls.Add(Me.Label3)
            Me.gbDatos.Controls.Add(Me.cbmCiudad)
            Me.gbDatos.Controls.Add(Me.Label1)
            Me.gbDatos.Controls.Add(Me.cbmProvincias)
            Me.gbDatos.Controls.Add(Me.Label2)
            Me.gbDatos.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatos.Location = New System.Drawing.Point(6, 162)
            Me.gbDatos.Name = "gbDatos"
            Me.gbDatos.Size = New System.Drawing.Size(990, 78)
            Me.gbDatos.TabIndex = 7
            Me.gbDatos.TabStop = False
            Me.gbDatos.Text = "DATOS GENERALES:"
            '
            'Button1
            '
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.ForeColor = System.Drawing.Color.Black
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(901, 16)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(83, 26)
            Me.Button1.TabIndex = 19
            Me.Button1.Text = "GUARDAR"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            '
            'cbmParroquias
            '
            Me.cbmParroquias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquias.FormattingEnabled = True
            Me.cbmParroquias.Location = New System.Drawing.Point(780, 51)
            Me.cbmParroquias.Name = "cbmParroquias"
            Me.cbmParroquias.Size = New System.Drawing.Size(204, 21)
            Me.cbmParroquias.TabIndex = 14
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(714, 54)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(60, 13)
            Me.Label9.TabIndex = 13
            Me.Label9.Text = "PARROQUIA"
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Location = New System.Drawing.Point(68, 20)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(63, 21)
            Me.txtIdPersonal.TabIndex = 11
            Me.txtIdPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(5, 17)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(57, 26)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "CODIGO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PERSONAL:"
            '
            'txtNombres
            '
            Me.txtNombres.BackColor = System.Drawing.Color.White
            Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombres.Enabled = False
            Me.txtNombres.Location = New System.Drawing.Point(321, 18)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(308, 21)
            Me.txtNombres.TabIndex = 7
            Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(264, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "NOMBRES:"
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCedula.Enabled = False
            Me.txtCedula.Location = New System.Drawing.Point(743, 20)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(110, 21)
            Me.txtCedula.TabIndex = 5
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(691, 25)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(46, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "CEDULA:"
            '
            'cbmCiudad
            '
            Me.cbmCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCiudad.FormattingEnabled = True
            Me.cbmCiudad.Location = New System.Drawing.Point(412, 51)
            Me.cbmCiudad.Name = "cbmCiudad"
            Me.cbmCiudad.Size = New System.Drawing.Size(217, 21)
            Me.cbmCiudad.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 54)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "PROVINCIA:"
            '
            'cbmProvincias
            '
            Me.cbmProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincias.FormattingEnabled = True
            Me.cbmProvincias.Location = New System.Drawing.Point(78, 51)
            Me.cbmProvincias.Name = "cbmProvincias"
            Me.cbmProvincias.Size = New System.Drawing.Size(219, 21)
            Me.cbmProvincias.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(360, 54)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "CIUDAD:"
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.crvAutorizaciones)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1002, 639)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'crvAutorizaciones
            '
            Me.crvAutorizaciones.ActiveViewIndex = -1
            Me.crvAutorizaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvAutorizaciones.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvAutorizaciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvAutorizaciones.Location = New System.Drawing.Point(3, 3)
            Me.crvAutorizaciones.Name = "crvAutorizaciones"
            Me.crvAutorizaciones.Size = New System.Drawing.Size(996, 633)
            Me.crvAutorizaciones.TabIndex = 0
            Me.crvAutorizaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1009, 32)
            Me.MenuStrip1.TabIndex = 200
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'FormParametrosAutorizacionesCajaChica
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1009, 688)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAutorizaciones)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormParametrosAutorizacionesCajaChica"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE PARÁMETROS DE AUTORIZACIONES DE CAJA CHICA"
            Me.tcAutorizaciones.ResumeLayout(False)
            Me.tpAutorizaciones.ResumeLayout(False)
            Me.gbParametrosAutorizaciones.ResumeLayout(False)
            Me.gbParametrosAutorizaciones.PerformLayout()
            CType(Me.dgvParametroAutorizaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDatos.ResumeLayout(False)
            Me.gbDatos.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAutorizaciones As System.Windows.Forms.TabControl
        Friend WithEvents tpAutorizaciones As System.Windows.Forms.TabPage
        Friend WithEvents gbParametrosAutorizaciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtCiudadResponsable As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtNombreResponsable As System.Windows.Forms.TextBox
        Friend WithEvents txtIdResponsable As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents dgvParametroAutorizaciones As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbApellidos As System.Windows.Forms.RadioButton
        Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
        Friend WithEvents dgvPersonal As System.Windows.Forms.DataGridView
        Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNombres As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbmCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbmProvincias As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvAutorizaciones As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents cbmParroquias As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.Button
    End Class
End Namespace