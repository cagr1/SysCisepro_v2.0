Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormResponsableAutorizacionFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormResponsableAutorizacionFondoRotativo))
            Me.dgvResponsableAutoFR = New System.Windows.Forms.DataGridView()
            Me.txtIdResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtCIResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtNombreResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtApellidoResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.cmbCargo = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoResponsableAutoFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarResponsableAutoFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarResponsableAutoFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvResponsableAutoFR, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvResponsableAutoFR
            '
            Me.dgvResponsableAutoFR.AllowUserToAddRows = False
            Me.dgvResponsableAutoFR.AllowUserToDeleteRows = False
            Me.dgvResponsableAutoFR.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvResponsableAutoFR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvResponsableAutoFR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvResponsableAutoFR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvResponsableAutoFR.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvResponsableAutoFR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvResponsableAutoFR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvResponsableAutoFR.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvResponsableAutoFR.Location = New System.Drawing.Point(8, 83)
            Me.dgvResponsableAutoFR.MultiSelect = False
            Me.dgvResponsableAutoFR.Name = "dgvResponsableAutoFR"
            Me.dgvResponsableAutoFR.ReadOnly = True
            Me.dgvResponsableAutoFR.RowHeadersVisible = False
            Me.dgvResponsableAutoFR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvResponsableAutoFR.Size = New System.Drawing.Size(668, 202)
            Me.dgvResponsableAutoFR.TabIndex = 19
            '
            'txtIdResponsableAutoFR
            '
            Me.txtIdResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtIdResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdResponsableAutoFR.Location = New System.Drawing.Point(82, 4)
            Me.txtIdResponsableAutoFR.Name = "txtIdResponsableAutoFR"
            Me.txtIdResponsableAutoFR.Size = New System.Drawing.Size(55, 21)
            Me.txtIdResponsableAutoFR.TabIndex = 20
            '
            'txtCIResponsableAutoFR
            '
            Me.txtCIResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtCIResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCIResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCIResponsableAutoFR.Location = New System.Drawing.Point(178, 4)
            Me.txtCIResponsableAutoFR.Name = "txtCIResponsableAutoFR"
            Me.txtCIResponsableAutoFR.Size = New System.Drawing.Size(84, 21)
            Me.txtCIResponsableAutoFR.TabIndex = 21
            '
            'txtNombreResponsableAutoFR
            '
            Me.txtNombreResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreResponsableAutoFR.Location = New System.Drawing.Point(82, 30)
            Me.txtNombreResponsableAutoFR.Name = "txtNombreResponsableAutoFR"
            Me.txtNombreResponsableAutoFR.Size = New System.Drawing.Size(180, 21)
            Me.txtNombreResponsableAutoFR.TabIndex = 23
            '
            'txtApellidoResponsableAutoFR
            '
            Me.txtApellidoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtApellidoResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidoResponsableAutoFR.Location = New System.Drawing.Point(340, 30)
            Me.txtApellidoResponsableAutoFR.Name = "txtApellidoResponsableAutoFR"
            Me.txtApellidoResponsableAutoFR.Size = New System.Drawing.Size(180, 21)
            Me.txtApellidoResponsableAutoFR.TabIndex = 26
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(508, 56)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(171, 21)
            Me.cmbParroquia.TabIndex = 7
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(284, 55)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(151, 21)
            Me.cmbCanton.TabIndex = 6
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(82, 56)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(135, 21)
            Me.cmbProvincia.TabIndex = 5
            '
            'cmbCargo
            '
            Me.cmbCargo.BackColor = System.Drawing.Color.White
            Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCargo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCargo.FormattingEnabled = True
            Me.cmbCargo.Location = New System.Drawing.Point(340, 5)
            Me.cmbCargo.Name = "cmbCargo"
            Me.cmbCargo.Size = New System.Drawing.Size(180, 21)
            Me.cmbCargo.TabIndex = 28
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoResponsableAutoFondoRotativo, Me.btnGuardarResponsableAutoFR, Me.btnCancelarResponsableAutoFR})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(692, 32)
            Me.MenuStrip1.TabIndex = 185
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoResponsableAutoFondoRotativo
            '
            Me.btnNuevoResponsableAutoFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoResponsableAutoFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoResponsableAutoFondoRotativo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoResponsableAutoFondoRotativo.Name = "btnNuevoResponsableAutoFondoRotativo"
            Me.btnNuevoResponsableAutoFondoRotativo.Size = New System.Drawing.Size(81, 28)
            Me.btnNuevoResponsableAutoFondoRotativo.Text = "NUEVO"
            '
            'btnGuardarResponsableAutoFR
            '
            Me.btnGuardarResponsableAutoFR.Enabled = False
            Me.btnGuardarResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarResponsableAutoFR.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarResponsableAutoFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarResponsableAutoFR.Name = "btnGuardarResponsableAutoFR"
            Me.btnGuardarResponsableAutoFR.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarResponsableAutoFR.Text = "GUARDAR"
            '
            'btnCancelarResponsableAutoFR
            '
            Me.btnCancelarResponsableAutoFR.Enabled = False
            Me.btnCancelarResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarResponsableAutoFR.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarResponsableAutoFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarResponsableAutoFR.Name = "btnCancelarResponsableAutoFR"
            Me.btnCancelarResponsableAutoFR.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelarResponsableAutoFR.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 31)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCargo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtApellidoResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCIResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreResponsableAutoFR)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(687, 312)
            Me.KryptonGroupBox1.TabIndex = 186
            Me.KryptonGroupBox1.Values.Heading = "Responsable"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(11, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(65, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id Respon"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(151, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel2.TabIndex = 21
            Me.KryptonLabel2.Values.Text = "CI"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(11, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel3.TabIndex = 22
            Me.KryptonLabel3.Values.Text = "Nombre"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(278, 30)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel4.TabIndex = 24
            Me.KryptonLabel4.Values.Text = "Apellido"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(278, 4)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel5.TabIndex = 27
            Me.KryptonLabel5.Values.Text = "Cargo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(11, 56)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel6.TabIndex = 29
            Me.KryptonLabel6.Values.Text = "Provincia"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(227, 56)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel7.TabIndex = 30
            Me.KryptonLabel7.Values.Text = "Canton"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(444, 56)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel8.TabIndex = 31
            Me.KryptonLabel8.Values.Text = "Parroquia"
            '
            'FormResponsableAutorizacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(692, 345)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormResponsableAutorizacionFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "RESPONSABLES AUTORIZACION DE FONDO ROTATIVO"
            CType(Me.dgvResponsableAutoFR, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents dgvResponsableAutoFR As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCIResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtApellidoResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCargo As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoResponsableAutoFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarResponsableAutoFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarResponsableAutoFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace