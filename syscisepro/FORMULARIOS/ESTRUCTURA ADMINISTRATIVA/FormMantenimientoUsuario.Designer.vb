Namespace FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMantenimientoUsuario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoUsuario))
            Me.txtIdUsuario = New System.Windows.Forms.TextBox()
            Me.cbmEmpresa = New System.Windows.Forms.ComboBox()
            Me.cbmSucursal = New System.Windows.Forms.ComboBox()
            Me.cbmArea = New System.Windows.Forms.ComboBox()
            Me.txtDatos = New System.Windows.Forms.TextBox()
            Me.txtLogin = New System.Windows.Forms.TextBox()
            Me.cbmTipoUsuario = New System.Windows.Forms.ComboBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnPersonal = New System.Windows.Forms.Button()
            Me.cbmIdRol = New System.Windows.Forms.ComboBox()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
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
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtIdUsuario
            '
            Me.txtIdUsuario.BackColor = System.Drawing.Color.White
            Me.txtIdUsuario.Enabled = False
            Me.txtIdUsuario.Location = New System.Drawing.Point(50, 12)
            Me.txtIdUsuario.Name = "txtIdUsuario"
            Me.txtIdUsuario.Size = New System.Drawing.Size(70, 22)
            Me.txtIdUsuario.TabIndex = 1
            '
            'cbmEmpresa
            '
            Me.cbmEmpresa.BackColor = System.Drawing.Color.White
            Me.cbmEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEmpresa.Enabled = False
            Me.cbmEmpresa.FormattingEnabled = True
            Me.cbmEmpresa.Location = New System.Drawing.Point(278, 40)
            Me.cbmEmpresa.Name = "cbmEmpresa"
            Me.cbmEmpresa.Size = New System.Drawing.Size(135, 21)
            Me.cbmEmpresa.TabIndex = 3
            '
            'cbmSucursal
            '
            Me.cbmSucursal.BackColor = System.Drawing.Color.White
            Me.cbmSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSucursal.Enabled = False
            Me.cbmSucursal.FormattingEnabled = True
            Me.cbmSucursal.Location = New System.Drawing.Point(501, 40)
            Me.cbmSucursal.Name = "cbmSucursal"
            Me.cbmSucursal.Size = New System.Drawing.Size(151, 21)
            Me.cbmSucursal.TabIndex = 5
            '
            'cbmArea
            '
            Me.cbmArea.BackColor = System.Drawing.Color.White
            Me.cbmArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmArea.Enabled = False
            Me.cbmArea.FormattingEnabled = True
            Me.cbmArea.Location = New System.Drawing.Point(50, 40)
            Me.cbmArea.Name = "cbmArea"
            Me.cbmArea.Size = New System.Drawing.Size(130, 21)
            Me.cbmArea.TabIndex = 7
            '
            'txtDatos
            '
            Me.txtDatos.BackColor = System.Drawing.Color.White
            Me.txtDatos.Enabled = False
            Me.txtDatos.Location = New System.Drawing.Point(278, 12)
            Me.txtDatos.Multiline = True
            Me.txtDatos.Name = "txtDatos"
            Me.txtDatos.Size = New System.Drawing.Size(315, 23)
            Me.txtDatos.TabIndex = 9
            '
            'txtLogin
            '
            Me.txtLogin.BackColor = System.Drawing.Color.White
            Me.txtLogin.Enabled = False
            Me.txtLogin.Location = New System.Drawing.Point(278, 70)
            Me.txtLogin.Name = "txtLogin"
            Me.txtLogin.Size = New System.Drawing.Size(135, 22)
            Me.txtLogin.TabIndex = 11
            '
            'cbmTipoUsuario
            '
            Me.cbmTipoUsuario.BackColor = System.Drawing.Color.White
            Me.cbmTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoUsuario.Enabled = False
            Me.cbmTipoUsuario.FormattingEnabled = True
            Me.cbmTipoUsuario.Items.AddRange(New Object() {"ADMINISTRADOR", "GERENTE", "RR.HH", "TESORERIA", "CONTABILIDAD", "AUDITOR", "SUPERVISOR"})
            Me.cbmTipoUsuario.Location = New System.Drawing.Point(50, 67)
            Me.cbmTipoUsuario.Name = "cbmTipoUsuario"
            Me.cbmTipoUsuario.Size = New System.Drawing.Size(130, 21)
            Me.cbmTipoUsuario.TabIndex = 13
            '
            'txtPassword
            '
            Me.txtPassword.BackColor = System.Drawing.Color.White
            Me.txtPassword.Enabled = False
            Me.txtPassword.Location = New System.Drawing.Point(527, 70)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(125, 22)
            Me.txtPassword.TabIndex = 17
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'dgvUsuarios
            '
            Me.dgvUsuarios.AllowUserToAddRows = False
            Me.dgvUsuarios.AllowUserToDeleteRows = False
            Me.dgvUsuarios.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvUsuarios.Location = New System.Drawing.Point(4, 191)
            Me.dgvUsuarios.MultiSelect = False
            Me.dgvUsuarios.Name = "dgvUsuarios"
            Me.dgvUsuarios.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsuarios.Size = New System.Drawing.Size(681, 189)
            Me.dgvUsuarios.TabIndex = 18
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmNuevo, Me.tsmGuardar, Me.ToolStripMenuItem2, Me.tsmCancelar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(688, 32)
            Me.msKardex.TabIndex = 181
            Me.msKardex.Text = "msIngresoBodega"
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
            'tsmNuevo
            '
            Me.tsmNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmNuevo.Name = "tsmNuevo"
            Me.tsmNuevo.Size = New System.Drawing.Size(82, 28)
            Me.tsmNuevo.Text = "NUEVO"
            '
            'tsmGuardar
            '
            Me.tsmGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmGuardar.Name = "tsmGuardar"
            Me.tsmGuardar.Size = New System.Drawing.Size(97, 28)
            Me.tsmGuardar.Text = "GUARDAR"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Enabled = False
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(80, 28)
            Me.ToolStripMenuItem2.Text = "EDITAR"
            '
            'tsmCancelar
            '
            Me.tsmCancelar.Enabled = False
            Me.tsmCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmCancelar.Name = "tsmCancelar"
            Me.tsmCancelar.Size = New System.Drawing.Size(103, 28)
            Me.tsmCancelar.Text = "CANCELAR"
            '
            'btnPersonal
            '
            Me.btnPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnPersonal.Enabled = False
            Me.btnPersonal.FlatAppearance.BorderSize = 0
            Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPersonal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnPersonal.Location = New System.Drawing.Point(611, 8)
            Me.btnPersonal.Name = "btnPersonal"
            Me.btnPersonal.Size = New System.Drawing.Size(27, 27)
            Me.btnPersonal.TabIndex = 194
            Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonal.UseVisualStyleBackColor = False
            '
            'cbmIdRol
            '
            Me.cbmIdRol.BackColor = System.Drawing.Color.White
            Me.cbmIdRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmIdRol.Enabled = False
            Me.cbmIdRol.FormattingEnabled = True
            Me.cbmIdRol.Location = New System.Drawing.Point(50, 94)
            Me.cbmIdRol.Name = "cbmIdRol"
            Me.cbmIdRol.Size = New System.Drawing.Size(130, 21)
            Me.cbmIdRol.TabIndex = 196
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Location = New System.Drawing.Point(278, 98)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(70, 22)
            Me.txtIdPersonal.TabIndex = 198
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(4, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPassword)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmSucursal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmIdRol)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdUsuario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmArea)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmTipoUsuario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtLogin)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDatos)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(681, 150)
            Me.KryptonGroupBox1.TabIndex = 199
            Me.KryptonGroupBox1.Values.Heading = "Datos Usuario"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(429, 40)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel10.TabIndex = 202
            Me.KryptonLabel10.Values.Text = "Sucursal"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(429, 70)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel9.TabIndex = 201
            Me.KryptonLabel9.Values.Text = "Contraseña"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(200, 100)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(71, 20)
            Me.KryptonLabel8.TabIndex = 200
            Me.KryptonLabel8.Values.Text = "Id Personal"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(200, 70)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel7.TabIndex = 199
            Me.KryptonLabel7.Values.Text = "Login"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(200, 12)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel6.TabIndex = 198
            Me.KryptonLabel6.Values.Text = "Datos"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(200, 41)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel5.TabIndex = 197
            Me.KryptonLabel5.Values.Text = "Empresa"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(8, 90)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(28, 20)
            Me.KryptonLabel4.TabIndex = 3
            Me.KryptonLabel4.Values.Text = "Rol"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(6, 64)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Tipo"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(6, 38)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(36, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Area"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(6, 12)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "ID"
            '
            'FormMantenimientoUsuario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(688, 384)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvUsuarios)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormMantenimientoUsuario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE USUARIOS DEL SISTEMA"
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtIdUsuario As System.Windows.Forms.TextBox
        Friend WithEvents cbmEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents cbmSucursal As System.Windows.Forms.ComboBox
        Friend WithEvents cbmArea As System.Windows.Forms.ComboBox
        Friend WithEvents txtDatos As System.Windows.Forms.TextBox
        Friend WithEvents txtLogin As System.Windows.Forms.TextBox
        Friend WithEvents cbmTipoUsuario As System.Windows.Forms.ComboBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnPersonal As System.Windows.Forms.Button
        Friend WithEvents cbmIdRol As System.Windows.Forms.ComboBox
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace