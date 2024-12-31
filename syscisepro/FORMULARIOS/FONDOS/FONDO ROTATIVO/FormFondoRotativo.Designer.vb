Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFondoRotativo))
            Me.dgvFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.txtIdFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtDetalleFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtMontoFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtCtaContableFondo = New System.Windows.Forms.TextBox()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.cmbNivelCuenta = New System.Windows.Forms.ComboBox()
            Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.txtCustodioFondo = New System.Windows.Forms.TextBox()
            Me.btnBuscarCustodio = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
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
            CType(Me.dgvFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvFondoRotativo
            '
            Me.dgvFondoRotativo.AllowUserToAddRows = False
            Me.dgvFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFondoRotativo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFondoRotativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFondoRotativo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFondoRotativo.Location = New System.Drawing.Point(2, 207)
            Me.dgvFondoRotativo.MultiSelect = False
            Me.dgvFondoRotativo.Name = "dgvFondoRotativo"
            Me.dgvFondoRotativo.ReadOnly = True
            Me.dgvFondoRotativo.RowHeadersVisible = False
            Me.dgvFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFondoRotativo.Size = New System.Drawing.Size(670, 181)
            Me.dgvFondoRotativo.TabIndex = 0
            '
            'txtIdFondoRotativo
            '
            Me.txtIdFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtIdFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdFondoRotativo.Enabled = False
            Me.txtIdFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdFondoRotativo.Location = New System.Drawing.Point(72, 4)
            Me.txtIdFondoRotativo.Name = "txtIdFondoRotativo"
            Me.txtIdFondoRotativo.Size = New System.Drawing.Size(45, 21)
            Me.txtIdFondoRotativo.TabIndex = 10
            '
            'txtDetalleFondoRotativo
            '
            Me.txtDetalleFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtDetalleFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleFondoRotativo.Enabled = False
            Me.txtDetalleFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleFondoRotativo.Location = New System.Drawing.Point(72, 30)
            Me.txtDetalleFondoRotativo.Name = "txtDetalleFondoRotativo"
            Me.txtDetalleFondoRotativo.Size = New System.Drawing.Size(360, 21)
            Me.txtDetalleFondoRotativo.TabIndex = 11
            '
            'txtMontoFondoRotativo
            '
            Me.txtMontoFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtMontoFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoFondoRotativo.Enabled = False
            Me.txtMontoFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMontoFondoRotativo.Location = New System.Drawing.Point(72, 56)
            Me.txtMontoFondoRotativo.Name = "txtMontoFondoRotativo"
            Me.txtMontoFondoRotativo.Size = New System.Drawing.Size(69, 21)
            Me.txtMontoFondoRotativo.TabIndex = 12
            '
            'txtCtaContableFondo
            '
            Me.txtCtaContableFondo.BackColor = System.Drawing.Color.White
            Me.txtCtaContableFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableFondo.Enabled = False
            Me.txtCtaContableFondo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCtaContableFondo.Location = New System.Drawing.Point(581, 4)
            Me.txtCtaContableFondo.Name = "txtCtaContableFondo"
            Me.txtCtaContableFondo.Size = New System.Drawing.Size(68, 21)
            Me.txtCtaContableFondo.TabIndex = 13
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(346, 110)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(154, 21)
            Me.cmbCentroCosto.TabIndex = 8
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.Enabled = False
            Me.cmbParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(74, 109)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(154, 21)
            Me.cmbParroquia.TabIndex = 7
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.Enabled = False
            Me.cmbCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(346, 82)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(154, 21)
            Me.cmbCanton.TabIndex = 6
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.Enabled = False
            Me.cmbProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(72, 82)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(156, 21)
            Me.cmbProvincia.TabIndex = 5
            '
            'cmbNivelCuenta
            '
            Me.cmbNivelCuenta.BackColor = System.Drawing.Color.White
            Me.cmbNivelCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNivelCuenta.Enabled = False
            Me.cmbNivelCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNivelCuenta.FormattingEnabled = True
            Me.cmbNivelCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cmbNivelCuenta.Location = New System.Drawing.Point(581, 55)
            Me.cmbNivelCuenta.Name = "cmbNivelCuenta"
            Me.cmbNivelCuenta.Size = New System.Drawing.Size(68, 21)
            Me.cmbNivelCuenta.TabIndex = 18
            '
            'cmbTipoCuenta
            '
            Me.cmbTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoCuenta.Enabled = False
            Me.cmbTipoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoCuenta.FormattingEnabled = True
            Me.cmbTipoCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cmbTipoCuenta.Location = New System.Drawing.Point(581, 29)
            Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
            Me.cmbTipoCuenta.Size = New System.Drawing.Size(68, 21)
            Me.cmbTipoCuenta.TabIndex = 17
            '
            'txtCustodioFondo
            '
            Me.txtCustodioFondo.BackColor = System.Drawing.Color.White
            Me.txtCustodioFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCustodioFondo.Enabled = False
            Me.txtCustodioFondo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCustodioFondo.Location = New System.Drawing.Point(207, 4)
            Me.txtCustodioFondo.Name = "txtCustodioFondo"
            Me.txtCustodioFondo.Size = New System.Drawing.Size(225, 21)
            Me.txtCustodioFondo.TabIndex = 16
            '
            'btnBuscarCustodio
            '
            Me.btnBuscarCustodio.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarCustodio.Enabled = False
            Me.btnBuscarCustodio.FlatAppearance.BorderSize = 0
            Me.btnBuscarCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarCustodio.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarCustodio.Location = New System.Drawing.Point(446, 3)
            Me.btnBuscarCustodio.Name = "btnBuscarCustodio"
            Me.btnBuscarCustodio.Size = New System.Drawing.Size(29, 29)
            Me.btnBuscarCustodio.TabIndex = 14
            Me.btnBuscarCustodio.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoFondoRotativo, Me.btnModificarFondoRotativo, Me.btnGuardarFondoRotativo, Me.btnCancelarFondoRotativo, Me.btnReporteFondoRotativo})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(675, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoFondoRotativo
            '
            Me.btnNuevoFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoFondoRotativo.Name = "btnNuevoFondoRotativo"
            Me.btnNuevoFondoRotativo.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevoFondoRotativo.Text = "NUEVO"
            Me.btnNuevoFondoRotativo.Visible = False
            '
            'btnModificarFondoRotativo
            '
            Me.btnModificarFondoRotativo.Enabled = False
            Me.btnModificarFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificarFondoRotativo.Name = "btnModificarFondoRotativo"
            Me.btnModificarFondoRotativo.Size = New System.Drawing.Size(95, 20)
            Me.btnModificarFondoRotativo.Text = "MODIFICAR"
            Me.btnModificarFondoRotativo.Visible = False
            '
            'btnGuardarFondoRotativo
            '
            Me.btnGuardarFondoRotativo.Enabled = False
            Me.btnGuardarFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardarFondoRotativo.Name = "btnGuardarFondoRotativo"
            Me.btnGuardarFondoRotativo.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardarFondoRotativo.Text = "GUARDAR"
            Me.btnGuardarFondoRotativo.Visible = False
            '
            'btnCancelarFondoRotativo
            '
            Me.btnCancelarFondoRotativo.Enabled = False
            Me.btnCancelarFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarFondoRotativo.Name = "btnCancelarFondoRotativo"
            Me.btnCancelarFondoRotativo.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelarFondoRotativo.Text = "CANCELAR"
            Me.btnCancelarFondoRotativo.Visible = False
            '
            'btnReporteFondoRotativo
            '
            Me.btnReporteFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporteFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporteFondoRotativo.Name = "btnReporteFondoRotativo"
            Me.btnReporteFondoRotativo.Size = New System.Drawing.Size(90, 28)
            Me.btnReporteFondoRotativo.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbNivelCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbTipoCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCtaContableFondo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCustodioFondo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarCustodio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdFondoRotativo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtMontoFondoRotativo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalleFondoRotativo)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(670, 166)
            Me.KryptonGroupBox1.TabIndex = 190
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(251, 109)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel11.TabIndex = 25
            Me.KryptonLabel11.Values.Text = "Centro Costo"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(6, 108)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel10.TabIndex = 24
            Me.KryptonLabel10.Values.Text = "Parroquia"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(251, 82)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel9.TabIndex = 23
            Me.KryptonLabel9.Values.Text = "Canton"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(6, 82)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel8.TabIndex = 22
            Me.KryptonLabel8.Values.Text = "Provincia"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(494, 56)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel7.TabIndex = 21
            Me.KryptonLabel7.Values.Text = "Nivel"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(494, 30)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel6.TabIndex = 20
            Me.KryptonLabel6.Values.Text = "Tipo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(494, 4)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel5.TabIndex = 19
            Me.KryptonLabel5.Values.Text = "Cta Contable"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(4, 56)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel4.TabIndex = 18
            Me.KryptonLabel4.Values.Text = "Monto"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(4, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel3.TabIndex = 17
            Me.KryptonLabel3.Values.Text = "Detalle"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(142, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel2.TabIndex = 11
            Me.KryptonLabel2.Values.Text = "Custodio"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "ID"
            '
            'FormFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(675, 391)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvFondoRotativo)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DEFINICION FONDO ROTATIVO"
            CType(Me.dgvFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtCtaContableFondo As System.Windows.Forms.TextBox
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbNivelCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents txtCustodioFondo As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscarCustodio As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporteFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace