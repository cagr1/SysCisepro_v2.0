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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParametrosAutorizacionesCajaChica))
            Me.txtCiudadResponsable = New System.Windows.Forms.TextBox()
            Me.txtNombreResponsable = New System.Windows.Forms.TextBox()
            Me.txtIdResponsable = New System.Windows.Forms.TextBox()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.rbInactivo = New System.Windows.Forms.RadioButton()
            Me.rbActivo = New System.Windows.Forms.RadioButton()
            Me.dgvParametroAutorizaciones = New System.Windows.Forms.DataGridView()
            Me.rbApellidos = New System.Windows.Forms.RadioButton()
            Me.rbCedula = New System.Windows.Forms.RadioButton()
            Me.dgvPersonal = New System.Windows.Forms.DataGridView()
            Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.cbmParroquias = New System.Windows.Forms.ComboBox()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.txtNombres = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.cbmCiudad = New System.Windows.Forms.ComboBox()
            Me.cbmProvincias = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcAutorizaciones = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.crvAutorizaciones = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            CType(Me.dgvParametroAutorizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.tcAutorizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcAutorizaciones.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtCiudadResponsable
            '
            Me.txtCiudadResponsable.BackColor = System.Drawing.Color.White
            Me.txtCiudadResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCiudadResponsable.Enabled = False
            Me.txtCiudadResponsable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCiudadResponsable.Location = New System.Drawing.Point(493, 9)
            Me.txtCiudadResponsable.Name = "txtCiudadResponsable"
            Me.txtCiudadResponsable.Size = New System.Drawing.Size(138, 21)
            Me.txtCiudadResponsable.TabIndex = 18
            '
            'txtNombreResponsable
            '
            Me.txtNombreResponsable.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreResponsable.Enabled = False
            Me.txtNombreResponsable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreResponsable.Location = New System.Drawing.Point(166, 9)
            Me.txtNombreResponsable.Name = "txtNombreResponsable"
            Me.txtNombreResponsable.Size = New System.Drawing.Size(264, 21)
            Me.txtNombreResponsable.TabIndex = 16
            '
            'txtIdResponsable
            '
            Me.txtIdResponsable.BackColor = System.Drawing.Color.White
            Me.txtIdResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdResponsable.Enabled = False
            Me.txtIdResponsable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdResponsable.Location = New System.Drawing.Point(35, 8)
            Me.txtIdResponsable.Name = "txtIdResponsable"
            Me.txtIdResponsable.Size = New System.Drawing.Size(58, 21)
            Me.txtIdResponsable.TabIndex = 15
            '
            'btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnActualizar.FlatAppearance.BorderSize = 0
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.ForeColor = System.Drawing.Color.Black
            Me.btnActualizar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnActualizar.Location = New System.Drawing.Point(746, 6)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(36, 26)
            Me.btnActualizar.TabIndex = 13
            Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ToolTip1.SetToolTip(Me.btnActualizar, "Actualizar")
            Me.btnActualizar.UseVisualStyleBackColor = False
            '
            'rbInactivo
            '
            Me.rbInactivo.AutoSize = True
            Me.rbInactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbInactivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbInactivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbInactivo.Location = New System.Drawing.Point(653, 21)
            Me.rbInactivo.Name = "rbInactivo"
            Me.rbInactivo.Size = New System.Drawing.Size(64, 17)
            Me.rbInactivo.TabIndex = 10
            Me.rbInactivo.Text = "Inactivo"
            Me.rbInactivo.UseVisualStyleBackColor = False
            '
            'rbActivo
            '
            Me.rbActivo.AutoSize = True
            Me.rbActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbActivo.Checked = True
            Me.rbActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbActivo.Location = New System.Drawing.Point(654, 1)
            Me.rbActivo.Name = "rbActivo"
            Me.rbActivo.Size = New System.Drawing.Size(56, 17)
            Me.rbActivo.TabIndex = 9
            Me.rbActivo.TabStop = True
            Me.rbActivo.Text = "Activo"
            Me.rbActivo.UseVisualStyleBackColor = False
            '
            'dgvParametroAutorizaciones
            '
            Me.dgvParametroAutorizaciones.AllowUserToAddRows = False
            Me.dgvParametroAutorizaciones.AllowUserToDeleteRows = False
            Me.dgvParametroAutorizaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvParametroAutorizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvParametroAutorizaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvParametroAutorizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvParametroAutorizaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvParametroAutorizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvParametroAutorizaciones.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvParametroAutorizaciones.Location = New System.Drawing.Point(11, 46)
            Me.dgvParametroAutorizaciones.MultiSelect = False
            Me.dgvParametroAutorizaciones.Name = "dgvParametroAutorizaciones"
            Me.dgvParametroAutorizaciones.ReadOnly = True
            Me.dgvParametroAutorizaciones.RowHeadersVisible = False
            Me.dgvParametroAutorizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvParametroAutorizaciones.Size = New System.Drawing.Size(802, 149)
            Me.dgvParametroAutorizaciones.TabIndex = 8
            '
            'rbApellidos
            '
            Me.rbApellidos.AutoSize = True
            Me.rbApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbApellidos.Checked = True
            Me.rbApellidos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbApellidos.Location = New System.Drawing.Point(78, 5)
            Me.rbApellidos.Name = "rbApellidos"
            Me.rbApellidos.Size = New System.Drawing.Size(73, 17)
            Me.rbApellidos.TabIndex = 7
            Me.rbApellidos.TabStop = True
            Me.rbApellidos.Text = "Apellidos"
            Me.rbApellidos.UseVisualStyleBackColor = False
            '
            'rbCedula
            '
            Me.rbCedula.AutoSize = True
            Me.rbCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbCedula.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCedula.Location = New System.Drawing.Point(9, 6)
            Me.rbCedula.Name = "rbCedula"
            Me.rbCedula.Size = New System.Drawing.Size(61, 17)
            Me.rbCedula.TabIndex = 6
            Me.rbCedula.Text = "Cedula"
            Me.rbCedula.UseVisualStyleBackColor = False
            '
            'dgvPersonal
            '
            Me.dgvPersonal.AllowUserToAddRows = False
            Me.dgvPersonal.AllowUserToDeleteRows = False
            Me.dgvPersonal.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPersonal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPersonal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvPersonal.Location = New System.Drawing.Point(3, 31)
            Me.dgvPersonal.MultiSelect = False
            Me.dgvPersonal.Name = "dgvPersonal"
            Me.dgvPersonal.ReadOnly = True
            Me.dgvPersonal.RowHeadersVisible = False
            Me.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersonal.Size = New System.Drawing.Size(812, 109)
            Me.dgvPersonal.TabIndex = 5
            '
            'txtParametroBusqueda
            '
            Me.txtParametroBusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametroBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametroBusqueda.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametroBusqueda.Location = New System.Drawing.Point(169, 4)
            Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
            Me.txtParametroBusqueda.Size = New System.Drawing.Size(274, 21)
            Me.txtParametroBusqueda.TabIndex = 4
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.ForeColor = System.Drawing.Color.Black
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button1.Location = New System.Drawing.Point(766, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(27, 26)
            Me.Button1.TabIndex = 19
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'cbmParroquias
            '
            Me.cbmParroquias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquias.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquias.FormattingEnabled = True
            Me.cbmParroquias.Location = New System.Drawing.Point(621, 34)
            Me.cbmParroquias.Name = "cbmParroquias"
            Me.cbmParroquias.Size = New System.Drawing.Size(164, 21)
            Me.cbmParroquias.TabIndex = 14
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdPersonal.Location = New System.Drawing.Point(76, 8)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(63, 21)
            Me.txtIdPersonal.TabIndex = 11
            '
            'txtNombres
            '
            Me.txtNombres.BackColor = System.Drawing.Color.White
            Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombres.Enabled = False
            Me.txtNombres.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombres.Location = New System.Drawing.Point(318, 8)
            Me.txtNombres.Name = "txtNombres"
            Me.txtNombres.Size = New System.Drawing.Size(233, 21)
            Me.txtNombres.TabIndex = 7
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(621, 10)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(110, 21)
            Me.txtCedula.TabIndex = 5
            '
            'cbmCiudad
            '
            Me.cbmCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCiudad.FormattingEnabled = True
            Me.cbmCiudad.Location = New System.Drawing.Point(320, 35)
            Me.cbmCiudad.Name = "cbmCiudad"
            Me.cbmCiudad.Size = New System.Drawing.Size(164, 21)
            Me.cbmCiudad.TabIndex = 3
            '
            'cbmProvincias
            '
            Me.cbmProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincias.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincias.FormattingEnabled = True
            Me.cbmProvincias.Location = New System.Drawing.Point(78, 34)
            Me.cbmProvincias.Name = "cbmProvincias"
            Me.cbmProvincias.Size = New System.Drawing.Size(164, 21)
            Me.cbmProvincias.TabIndex = 2
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(839, 32)
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
            'tcAutorizaciones
            '
            Me.tcAutorizaciones.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.tcAutorizaciones.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.tcAutorizaciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcAutorizaciones.Location = New System.Drawing.Point(0, 32)
            Me.tcAutorizaciones.Name = "tcAutorizaciones"
            Me.tcAutorizaciones.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.tcAutorizaciones.SelectedIndex = 0
            Me.tcAutorizaciones.Size = New System.Drawing.Size(839, 524)
            Me.tcAutorizaciones.TabIndex = 201
            Me.tcAutorizaciones.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(837, 497)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Autorizaciones"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "826B1590800349FD4B87C7E7D5F967E2"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(9, 272)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtCiudadResponsable)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvParametroAutorizaciones)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnActualizar)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNombreResponsable)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbInactivo)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbActivo)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIdResponsable)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(822, 224)
            Me.KryptonGroupBox3.TabIndex = 203
            Me.KryptonGroupBox3.Values.Heading = "Parametros"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(438, 8)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel8.TabIndex = 14
            Me.KryptonLabel8.Values.Text = "Ciudad"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(99, 8)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel10.TabIndex = 12
            Me.KryptonLabel10.Values.Text = "Nombres"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(7, 9)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel12.TabIndex = 0
            Me.KryptonLabel12.Values.Text = "ID"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(9, 179)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmParroquias)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.Button1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtCedula)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdPersonal)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNombres)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmProvincias)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmCiudad)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(822, 88)
            Me.KryptonGroupBox2.TabIndex = 202
            Me.KryptonGroupBox2.Values.Heading = "Datos"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(552, 36)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel6.TabIndex = 20
            Me.KryptonLabel6.Values.Text = "Parroquia"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(567, 8)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel5.TabIndex = 14
            Me.KryptonLabel5.Values.Text = "Cedula"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(253, 34)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel4.TabIndex = 13
            Me.KryptonLabel4.Values.Text = "Ciudad"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(253, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel3.TabIndex = 12
            Me.KryptonLabel3.Values.Text = "Nombres"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(12, 34)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Provincia"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(12, 8)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Codigo"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(7, 7)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbApellidos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCedula)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtParametroBusqueda)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(822, 168)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = "Autorizador"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.crvAutorizaciones)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(837, 497)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "698A50F886CF46AC4285321E1F301B59"
            '
            'crvAutorizaciones
            '
            Me.crvAutorizaciones.ActiveViewIndex = -1
            Me.crvAutorizaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvAutorizaciones.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvAutorizaciones.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvAutorizaciones.Location = New System.Drawing.Point(0, 0)
            Me.crvAutorizaciones.Name = "crvAutorizaciones"
            Me.crvAutorizaciones.ShowLogo = False
            Me.crvAutorizaciones.Size = New System.Drawing.Size(837, 497)
            Me.crvAutorizaciones.TabIndex = 1
            Me.crvAutorizaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormParametrosAutorizacionesCajaChica
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(839, 556)
            Me.Controls.Add(Me.tcAutorizaciones)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormParametrosAutorizacionesCajaChica"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE PARÁMETROS DE AUTORIZACIONES DE CAJA CHICA"
            CType(Me.dgvParametroAutorizaciones, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.tcAutorizaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcAutorizaciones.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtCiudadResponsable As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreResponsable As System.Windows.Forms.TextBox
        Friend WithEvents txtIdResponsable As System.Windows.Forms.TextBox
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents dgvParametroAutorizaciones As System.Windows.Forms.DataGridView
        Friend WithEvents rbApellidos As System.Windows.Forms.RadioButton
        Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
        Friend WithEvents dgvPersonal As System.Windows.Forms.DataGridView
        Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents txtNombres As System.Windows.Forms.TextBox
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents cbmCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents cbmProvincias As System.Windows.Forms.ComboBox
        Friend WithEvents cbmParroquias As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents tcAutorizaciones As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents crvAutorizaciones As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace