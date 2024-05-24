Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormFondoRotativo
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFondoRotativo))
            Me.dgvFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.lblIdFondoRotativo = New System.Windows.Forms.Label()
            Me.lblDetalleFondoRotativo = New System.Windows.Forms.Label()
            Me.lblMontoFondoRotativo = New System.Windows.Forms.Label()
            Me.lblCtaContableFondo = New System.Windows.Forms.Label()
            Me.lblTipoCuenta = New System.Windows.Forms.Label()
            Me.lblNivelCuenta = New System.Windows.Forms.Label()
            Me.txtIdFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtDetalleFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtMontoFondoRotativo = New System.Windows.Forms.TextBox()
            Me.txtCtaContableFondo = New System.Windows.Forms.TextBox()
            Me.pCentroCostoSolicitudFR = New System.Windows.Forms.Panel()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.lblCanton = New System.Windows.Forms.Label()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbNivelCuenta = New System.Windows.Forms.ComboBox()
            Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.txtCustodioFondo = New System.Windows.Forms.TextBox()
            Me.lblCustodioFondo = New System.Windows.Forms.Label()
            Me.btnBuscarCustodio = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporteFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pCentroCostoSolicitudFR.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvFondoRotativo
            '
            Me.dgvFondoRotativo.AllowUserToAddRows = False
            Me.dgvFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFondoRotativo.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvFondoRotativo.Location = New System.Drawing.Point(4, 205)
            Me.dgvFondoRotativo.MultiSelect = False
            Me.dgvFondoRotativo.Name = "dgvFondoRotativo"
            Me.dgvFondoRotativo.ReadOnly = True
            Me.dgvFondoRotativo.RowHeadersVisible = False
            Me.dgvFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFondoRotativo.Size = New System.Drawing.Size(789, 181)
            Me.dgvFondoRotativo.TabIndex = 0
            '
            'lblIdFondoRotativo
            '
            Me.lblIdFondoRotativo.AutoSize = True
            Me.lblIdFondoRotativo.Location = New System.Drawing.Point(6, 24)
            Me.lblIdFondoRotativo.Name = "lblIdFondoRotativo"
            Me.lblIdFondoRotativo.Size = New System.Drawing.Size(62, 13)
            Me.lblIdFondoRotativo.TabIndex = 1
            Me.lblIdFondoRotativo.Text = "ID FONDO:"
            '
            'lblDetalleFondoRotativo
            '
            Me.lblDetalleFondoRotativo.AutoSize = True
            Me.lblDetalleFondoRotativo.Location = New System.Drawing.Point(6, 51)
            Me.lblDetalleFondoRotativo.Name = "lblDetalleFondoRotativo"
            Me.lblDetalleFondoRotativo.Size = New System.Drawing.Size(58, 13)
            Me.lblDetalleFondoRotativo.TabIndex = 2
            Me.lblDetalleFondoRotativo.Text = "DETALLE:"
            '
            'lblMontoFondoRotativo
            '
            Me.lblMontoFondoRotativo.AutoSize = True
            Me.lblMontoFondoRotativo.Location = New System.Drawing.Point(6, 78)
            Me.lblMontoFondoRotativo.Name = "lblMontoFondoRotativo"
            Me.lblMontoFondoRotativo.Size = New System.Drawing.Size(50, 13)
            Me.lblMontoFondoRotativo.TabIndex = 3
            Me.lblMontoFondoRotativo.Text = "MONTO:"
            '
            'lblCtaContableFondo
            '
            Me.lblCtaContableFondo.AutoSize = True
            Me.lblCtaContableFondo.Location = New System.Drawing.Point(529, 23)
            Me.lblCtaContableFondo.Name = "lblCtaContableFondo"
            Me.lblCtaContableFondo.Size = New System.Drawing.Size(94, 13)
            Me.lblCtaContableFondo.TabIndex = 4
            Me.lblCtaContableFondo.Text = "CTA. CONTABLE:"
            '
            'lblTipoCuenta
            '
            Me.lblTipoCuenta.AutoSize = True
            Me.lblTipoCuenta.Location = New System.Drawing.Point(529, 50)
            Me.lblTipoCuenta.Name = "lblTipoCuenta"
            Me.lblTipoCuenta.Size = New System.Drawing.Size(62, 13)
            Me.lblTipoCuenta.TabIndex = 5
            Me.lblTipoCuenta.Text = "TIPO CTA.:"
            '
            'lblNivelCuenta
            '
            Me.lblNivelCuenta.AutoSize = True
            Me.lblNivelCuenta.Location = New System.Drawing.Point(529, 77)
            Me.lblNivelCuenta.Name = "lblNivelCuenta"
            Me.lblNivelCuenta.Size = New System.Drawing.Size(68, 13)
            Me.lblNivelCuenta.TabIndex = 6
            Me.lblNivelCuenta.Text = "NIVEL CTA.:"
            '
            'txtIdFondoRotativo
            '
            Me.txtIdFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtIdFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdFondoRotativo.Enabled = False
            Me.txtIdFondoRotativo.Location = New System.Drawing.Point(76, 21)
            Me.txtIdFondoRotativo.Name = "txtIdFondoRotativo"
            Me.txtIdFondoRotativo.Size = New System.Drawing.Size(45, 20)
            Me.txtIdFondoRotativo.TabIndex = 10
            '
            'txtDetalleFondoRotativo
            '
            Me.txtDetalleFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtDetalleFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleFondoRotativo.Enabled = False
            Me.txtDetalleFondoRotativo.Location = New System.Drawing.Point(76, 48)
            Me.txtDetalleFondoRotativo.Name = "txtDetalleFondoRotativo"
            Me.txtDetalleFondoRotativo.Size = New System.Drawing.Size(399, 20)
            Me.txtDetalleFondoRotativo.TabIndex = 11
            '
            'txtMontoFondoRotativo
            '
            Me.txtMontoFondoRotativo.BackColor = System.Drawing.Color.White
            Me.txtMontoFondoRotativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMontoFondoRotativo.Enabled = False
            Me.txtMontoFondoRotativo.Location = New System.Drawing.Point(76, 75)
            Me.txtMontoFondoRotativo.Name = "txtMontoFondoRotativo"
            Me.txtMontoFondoRotativo.Size = New System.Drawing.Size(69, 20)
            Me.txtMontoFondoRotativo.TabIndex = 12
            '
            'txtCtaContableFondo
            '
            Me.txtCtaContableFondo.BackColor = System.Drawing.Color.White
            Me.txtCtaContableFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCtaContableFondo.Enabled = False
            Me.txtCtaContableFondo.Location = New System.Drawing.Point(630, 20)
            Me.txtCtaContableFondo.Name = "txtCtaContableFondo"
            Me.txtCtaContableFondo.Size = New System.Drawing.Size(138, 20)
            Me.txtCtaContableFondo.TabIndex = 13
            '
            'pCentroCostoSolicitudFR
            '
            Me.pCentroCostoSolicitudFR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbCentroCosto)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbParroquia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbCanton)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbProvincia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblParroquia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblProvincia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblCanton)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblCentroCosto)
            Me.pCentroCostoSolicitudFR.Location = New System.Drawing.Point(4, 134)
            Me.pCentroCostoSolicitudFR.Name = "pCentroCostoSolicitudFR"
            Me.pCentroCostoSolicitudFR.Size = New System.Drawing.Size(789, 68)
            Me.pCentroCostoSolicitudFR.TabIndex = 14
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(524, 35)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(257, 21)
            Me.cmbCentroCosto.TabIndex = 8
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.Enabled = False
            Me.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(77, 35)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(273, 21)
            Me.cmbParroquia.TabIndex = 7
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.Enabled = False
            Me.cmbCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(524, 8)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(215, 21)
            Me.cmbCanton.TabIndex = 6
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.Enabled = False
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(77, 8)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(273, 21)
            Me.cmbProvincia.TabIndex = 5
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Location = New System.Drawing.Point(1, 38)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(74, 13)
            Me.lblParroquia.TabIndex = 5
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Location = New System.Drawing.Point(3, 11)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(68, 13)
            Me.lblProvincia.TabIndex = 1
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'lblCanton
            '
            Me.lblCanton.AutoSize = True
            Me.lblCanton.Location = New System.Drawing.Point(432, 11)
            Me.lblCanton.Name = "lblCanton"
            Me.lblCanton.Size = New System.Drawing.Size(55, 13)
            Me.lblCanton.TabIndex = 3
            Me.lblCanton.Text = "CANTON:"
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Location = New System.Drawing.Point(432, 38)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(95, 13)
            Me.lblCentroCosto.TabIndex = 2
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.cmbNivelCuenta)
            Me.GroupBox1.Controls.Add(Me.cmbTipoCuenta)
            Me.GroupBox1.Controls.Add(Me.txtCustodioFondo)
            Me.GroupBox1.Controls.Add(Me.lblCustodioFondo)
            Me.GroupBox1.Controls.Add(Me.btnBuscarCustodio)
            Me.GroupBox1.Controls.Add(Me.lblIdFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblDetalleFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtCtaContableFondo)
            Me.GroupBox1.Controls.Add(Me.lblMontoFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.txtMontoFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblCtaContableFondo)
            Me.GroupBox1.Controls.Add(Me.txtDetalleFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblNivelCuenta)
            Me.GroupBox1.Controls.Add(Me.txtIdFondoRotativo)
            Me.GroupBox1.Controls.Add(Me.lblTipoCuenta)
            Me.GroupBox1.Location = New System.Drawing.Point(4, 26)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(789, 105)
            Me.GroupBox1.TabIndex = 15
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "FONDO"
            '
            'cmbNivelCuenta
            '
            Me.cmbNivelCuenta.BackColor = System.Drawing.Color.White
            Me.cmbNivelCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNivelCuenta.Enabled = False
            Me.cmbNivelCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbNivelCuenta.FormattingEnabled = True
            Me.cmbNivelCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cmbNivelCuenta.Location = New System.Drawing.Point(630, 74)
            Me.cmbNivelCuenta.Name = "cmbNivelCuenta"
            Me.cmbNivelCuenta.Size = New System.Drawing.Size(138, 21)
            Me.cmbNivelCuenta.TabIndex = 18
            '
            'cmbTipoCuenta
            '
            Me.cmbTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoCuenta.Enabled = False
            Me.cmbTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoCuenta.FormattingEnabled = True
            Me.cmbTipoCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
            Me.cmbTipoCuenta.Location = New System.Drawing.Point(630, 47)
            Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
            Me.cmbTipoCuenta.Size = New System.Drawing.Size(138, 21)
            Me.cmbTipoCuenta.TabIndex = 17
            '
            'txtCustodioFondo
            '
            Me.txtCustodioFondo.BackColor = System.Drawing.Color.White
            Me.txtCustodioFondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCustodioFondo.Enabled = False
            Me.txtCustodioFondo.Location = New System.Drawing.Point(214, 21)
            Me.txtCustodioFondo.Name = "txtCustodioFondo"
            Me.txtCustodioFondo.Size = New System.Drawing.Size(225, 20)
            Me.txtCustodioFondo.TabIndex = 16
            '
            'lblCustodioFondo
            '
            Me.lblCustodioFondo.AutoSize = True
            Me.lblCustodioFondo.Location = New System.Drawing.Point(142, 24)
            Me.lblCustodioFondo.Name = "lblCustodioFondo"
            Me.lblCustodioFondo.Size = New System.Drawing.Size(66, 13)
            Me.lblCustodioFondo.TabIndex = 15
            Me.lblCustodioFondo.Text = "CUSTODIO:"
            '
            'btnBuscarCustodio
            '
            Me.btnBuscarCustodio.Enabled = False
            Me.btnBuscarCustodio.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscarCustodio.Location = New System.Drawing.Point(445, 19)
            Me.btnBuscarCustodio.Name = "btnBuscarCustodio"
            Me.btnBuscarCustodio.Size = New System.Drawing.Size(30, 23)
            Me.btnBuscarCustodio.TabIndex = 14
            Me.btnBuscarCustodio.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoFondoRotativo, Me.btnModificarFondoRotativo, Me.btnGuardarFondoRotativo, Me.btnCancelarFondoRotativo, Me.btnReporteFondoRotativo})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(798, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoFondoRotativo
            '
            Me.btnNuevoFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevoFondoRotativo.Name = "btnNuevoFondoRotativo"
            Me.btnNuevoFondoRotativo.Size = New System.Drawing.Size(74, 20)
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
            Me.btnReporteFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporteFondoRotativo.Name = "btnReporteFondoRotativo"
            Me.btnReporteFondoRotativo.Size = New System.Drawing.Size(82, 20)
            Me.btnReporteFondoRotativo.Text = "REPORTE"
            '
            'FormFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(798, 391)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.pCentroCostoSolicitudFR)
            Me.Controls.Add(Me.dgvFondoRotativo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DEFINICION FONDO ROTATIVO"
            CType(Me.dgvFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pCentroCostoSolicitudFR.ResumeLayout(False)
            Me.pCentroCostoSolicitudFR.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblDetalleFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblMontoFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblCtaContableFondo As System.Windows.Forms.Label
        Friend WithEvents lblTipoCuenta As System.Windows.Forms.Label
        Friend WithEvents lblNivelCuenta As System.Windows.Forms.Label
        Friend WithEvents txtIdFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtMontoFondoRotativo As System.Windows.Forms.TextBox
        Friend WithEvents txtCtaContableFondo As System.Windows.Forms.TextBox
        Friend WithEvents pCentroCostoSolicitudFR As System.Windows.Forms.Panel
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents lblCanton As System.Windows.Forms.Label
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cmbNivelCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents txtCustodioFondo As System.Windows.Forms.TextBox
        Friend WithEvents lblCustodioFondo As System.Windows.Forms.Label
        Friend WithEvents btnBuscarCustodio As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporteFondoRotativo As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace