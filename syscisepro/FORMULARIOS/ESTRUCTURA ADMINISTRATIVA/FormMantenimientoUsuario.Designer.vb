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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoUsuario))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdUsuario = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbmEmpresa = New System.Windows.Forms.ComboBox()
            Me.cbmSucursal = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbmArea = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDatos = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtLogin = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbmTipoUsuario = New System.Windows.Forms.ComboBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.btnPersonal = New System.Windows.Forms.Button()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbmIdRol = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(5, 38)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(21, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "ID:"
            '
            'txtIdUsuario
            '
            Me.txtIdUsuario.BackColor = System.Drawing.Color.White
            Me.txtIdUsuario.Enabled = False
            Me.txtIdUsuario.Location = New System.Drawing.Point(50, 35)
            Me.txtIdUsuario.Name = "txtIdUsuario"
            Me.txtIdUsuario.Size = New System.Drawing.Size(135, 22)
            Me.txtIdUsuario.TabIndex = 1
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(247, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(58, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "EMPRESA:"
            '
            'cbmEmpresa
            '
            Me.cbmEmpresa.BackColor = System.Drawing.Color.White
            Me.cbmEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEmpresa.Enabled = False
            Me.cbmEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmEmpresa.FormattingEnabled = True
            Me.cbmEmpresa.Location = New System.Drawing.Point(318, 32)
            Me.cbmEmpresa.Name = "cbmEmpresa"
            Me.cbmEmpresa.Size = New System.Drawing.Size(178, 21)
            Me.cbmEmpresa.TabIndex = 3
            '
            'cbmSucursal
            '
            Me.cbmSucursal.BackColor = System.Drawing.Color.White
            Me.cbmSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSucursal.Enabled = False
            Me.cbmSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmSucursal.FormattingEnabled = True
            Me.cbmSucursal.Location = New System.Drawing.Point(585, 32)
            Me.cbmSucursal.Name = "cbmSucursal"
            Me.cbmSucursal.Size = New System.Drawing.Size(151, 21)
            Me.cbmSucursal.TabIndex = 5
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(517, 36)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "SUCURSAL:"
            '
            'cbmArea
            '
            Me.cbmArea.BackColor = System.Drawing.Color.White
            Me.cbmArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmArea.Enabled = False
            Me.cbmArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmArea.FormattingEnabled = True
            Me.cbmArea.Location = New System.Drawing.Point(50, 61)
            Me.cbmArea.Name = "cbmArea"
            Me.cbmArea.Size = New System.Drawing.Size(189, 21)
            Me.cbmArea.TabIndex = 7
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(5, 64)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "AREA:"
            '
            'txtDatos
            '
            Me.txtDatos.BackColor = System.Drawing.Color.White
            Me.txtDatos.Enabled = False
            Me.txtDatos.Location = New System.Drawing.Point(318, 59)
            Me.txtDatos.Multiline = True
            Me.txtDatos.Name = "txtDatos"
            Me.txtDatos.Size = New System.Drawing.Size(393, 23)
            Me.txtDatos.TabIndex = 9
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(265, 62)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "DATOS:"
            '
            'txtLogin
            '
            Me.txtLogin.BackColor = System.Drawing.Color.White
            Me.txtLogin.Enabled = False
            Me.txtLogin.Location = New System.Drawing.Point(318, 91)
            Me.txtLogin.Name = "txtLogin"
            Me.txtLogin.Size = New System.Drawing.Size(135, 22)
            Me.txtLogin.TabIndex = 11
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(266, 91)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(43, 13)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "LOGIN:"
            '
            'cbmTipoUsuario
            '
            Me.cbmTipoUsuario.BackColor = System.Drawing.Color.White
            Me.cbmTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoUsuario.Enabled = False
            Me.cbmTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoUsuario.FormattingEnabled = True
            Me.cbmTipoUsuario.Items.AddRange(New Object() {"ADMINISTRADOR", "GERENTE", "RR.HH", "TESORERIA", "CONTABILIDAD", "AUDITOR", "SUPERVISOR"})
            Me.cbmTipoUsuario.Location = New System.Drawing.Point(50, 91)
            Me.cbmTipoUsuario.Name = "cbmTipoUsuario"
            Me.cbmTipoUsuario.Size = New System.Drawing.Size(189, 21)
            Me.cbmTipoUsuario.TabIndex = 13
            '
            'txtPassword
            '
            Me.txtPassword.BackColor = System.Drawing.Color.White
            Me.txtPassword.Enabled = False
            Me.txtPassword.Location = New System.Drawing.Point(559, 91)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(125, 22)
            Me.txtPassword.TabIndex = 17
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(472, 91)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(81, 13)
            Me.Label8.TabIndex = 16
            Me.Label8.Text = "CONTRASEÑA:"
            '
            'dgvUsuarios
            '
            Me.dgvUsuarios.AllowUserToAddRows = False
            Me.dgvUsuarios.AllowUserToDeleteRows = False
            Me.dgvUsuarios.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
            Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvUsuarios.Location = New System.Drawing.Point(0, 146)
            Me.dgvUsuarios.MultiSelect = False
            Me.dgvUsuarios.Name = "dgvUsuarios"
            Me.dgvUsuarios.RowHeadersVisible = False
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsuarios.Size = New System.Drawing.Size(743, 292)
            Me.dgvUsuarios.TabIndex = 18
            '
            'msKardex
            '
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmNuevo, Me.tsmGuardar, Me.ToolStripMenuItem2, Me.tsmCancelar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.msKardex.Size = New System.Drawing.Size(743, 24)
            Me.msKardex.TabIndex = 181
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 20)
            Me.ToolStripMenuItem1.Text = "LISTAR USUARIOS"
            '
            'tsmNuevo
            '
            Me.tsmNuevo.Image = CType(resources.GetObject("tsmNuevo.Image"), System.Drawing.Image)
            Me.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmNuevo.Name = "tsmNuevo"
            Me.tsmNuevo.Size = New System.Drawing.Size(74, 20)
            Me.tsmNuevo.Text = "NUEVO"
            '
            'tsmGuardar
            '
            Me.tsmGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmGuardar.Name = "tsmGuardar"
            Me.tsmGuardar.Size = New System.Drawing.Size(89, 20)
            Me.tsmGuardar.Text = "GUARDAR"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Enabled = False
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(72, 20)
            Me.ToolStripMenuItem2.Text = "EDITAR"
            '
            'tsmCancelar
            '
            Me.tsmCancelar.Enabled = False
            Me.tsmCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.tsmCancelar.Name = "tsmCancelar"
            Me.tsmCancelar.Size = New System.Drawing.Size(95, 20)
            Me.tsmCancelar.Text = "CANCELAR"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(5, 91)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(34, 13)
            Me.Label7.TabIndex = 182
            Me.Label7.Text = "TIPO:"
            '
            'btnPersonal
            '
            Me.btnPersonal.BackColor = System.Drawing.Color.White
            Me.btnPersonal.Enabled = False
            Me.btnPersonal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonal.Image = CType(resources.GetObject("btnPersonal.Image"), System.Drawing.Image)
            Me.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPersonal.Location = New System.Drawing.Point(710, 57)
            Me.btnPersonal.Name = "btnPersonal"
            Me.btnPersonal.Size = New System.Drawing.Size(26, 26)
            Me.btnPersonal.TabIndex = 194
            Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonal.UseVisualStyleBackColor = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(5, 120)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(34, 13)
            Me.Label9.TabIndex = 195
            Me.Label9.Text = " ROL:"
            '
            'cbmIdRol
            '
            Me.cbmIdRol.BackColor = System.Drawing.Color.White
            Me.cbmIdRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmIdRol.Enabled = False
            Me.cbmIdRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmIdRol.FormattingEnabled = True
            Me.cbmIdRol.Location = New System.Drawing.Point(64, 118)
            Me.cbmIdRol.Name = "cbmIdRol"
            Me.cbmIdRol.Size = New System.Drawing.Size(175, 21)
            Me.cbmIdRol.TabIndex = 196
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(265, 121)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(78, 13)
            Me.Label10.TabIndex = 197
            Me.Label10.Text = "ID PERSONAL:"
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Location = New System.Drawing.Point(353, 119)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(100, 22)
            Me.txtIdPersonal.TabIndex = 198
            '
            'FormMantenimientoUsuario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(743, 438)
            Me.Controls.Add(Me.txtIdPersonal)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.cbmIdRol)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.btnPersonal)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cbmEmpresa)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtIdUsuario)
            Me.Controls.Add(Me.dgvUsuarios)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.cbmTipoUsuario)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtLogin)
            Me.Controls.Add(Me.cbmSucursal)
            Me.Controls.Add(Me.txtDatos)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.cbmArea)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormMantenimientoUsuario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTO DE USUARIOS DEL SISTEMA"
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdUsuario As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbmEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents cbmSucursal As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbmArea As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDatos As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtLogin As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbmTipoUsuario As System.Windows.Forms.ComboBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnPersonal As System.Windows.Forms.Button
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbmIdRol As System.Windows.Forms.ComboBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
    End Class
End Namespace