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
            Me.lblIdResponsableAutoFR = New System.Windows.Forms.Label()
            Me.lblCIResponsableAutoFR = New System.Windows.Forms.Label()
            Me.lblNombreResponsableAutoFR = New System.Windows.Forms.Label()
            Me.lblCargoResponsableAutoFR = New System.Windows.Forms.Label()
            Me.dgvResponsableAutoFR = New System.Windows.Forms.DataGridView()
            Me.txtIdResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtCIResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtNombreResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtApellidoResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.lblApellidoResponsableAutoFR = New System.Windows.Forms.Label()
            Me.pCentroCostoSolicitudFR = New System.Windows.Forms.Panel()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.lblCanton = New System.Windows.Forms.Label()
            Me.cmbCargo = New System.Windows.Forms.ComboBox()
            Me.gbResponsable = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoResponsableAutoFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarResponsableAutoFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarResponsableAutoFR = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvResponsableAutoFR, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pCentroCostoSolicitudFR.SuspendLayout()
            Me.gbResponsable.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdResponsableAutoFR
            '
            Me.lblIdResponsableAutoFR.AutoSize = True
            Me.lblIdResponsableAutoFR.Location = New System.Drawing.Point(12, 22)
            Me.lblIdResponsableAutoFR.Name = "lblIdResponsableAutoFR"
            Me.lblIdResponsableAutoFR.Size = New System.Drawing.Size(50, 13)
            Me.lblIdResponsableAutoFR.TabIndex = 0
            Me.lblIdResponsableAutoFR.Text = "ID RESP:"
            '
            'lblCIResponsableAutoFR
            '
            Me.lblCIResponsableAutoFR.AutoSize = True
            Me.lblCIResponsableAutoFR.Location = New System.Drawing.Point(185, 22)
            Me.lblCIResponsableAutoFR.Name = "lblCIResponsableAutoFR"
            Me.lblCIResponsableAutoFR.Size = New System.Drawing.Size(29, 13)
            Me.lblCIResponsableAutoFR.TabIndex = 1
            Me.lblCIResponsableAutoFR.Text = "C. I.:"
            '
            'lblNombreResponsableAutoFR
            '
            Me.lblNombreResponsableAutoFR.AutoSize = True
            Me.lblNombreResponsableAutoFR.Location = New System.Drawing.Point(378, 18)
            Me.lblNombreResponsableAutoFR.Name = "lblNombreResponsableAutoFR"
            Me.lblNombreResponsableAutoFR.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreResponsableAutoFR.TabIndex = 2
            Me.lblNombreResponsableAutoFR.Text = "NOMBRE:"
            '
            'lblCargoResponsableAutoFR
            '
            Me.lblCargoResponsableAutoFR.AutoSize = True
            Me.lblCargoResponsableAutoFR.Location = New System.Drawing.Point(12, 52)
            Me.lblCargoResponsableAutoFR.Name = "lblCargoResponsableAutoFR"
            Me.lblCargoResponsableAutoFR.Size = New System.Drawing.Size(47, 13)
            Me.lblCargoResponsableAutoFR.TabIndex = 3
            Me.lblCargoResponsableAutoFR.Text = "CARGO:"
            '
            'dgvResponsableAutoFR
            '
            Me.dgvResponsableAutoFR.AllowUserToAddRows = False
            Me.dgvResponsableAutoFR.AllowUserToDeleteRows = False
            Me.dgvResponsableAutoFR.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvResponsableAutoFR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvResponsableAutoFR.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvResponsableAutoFR.Location = New System.Drawing.Point(1, 155)
            Me.dgvResponsableAutoFR.MultiSelect = False
            Me.dgvResponsableAutoFR.Name = "dgvResponsableAutoFR"
            Me.dgvResponsableAutoFR.ReadOnly = True
            Me.dgvResponsableAutoFR.RowHeadersVisible = False
            Me.dgvResponsableAutoFR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvResponsableAutoFR.Size = New System.Drawing.Size(706, 189)
            Me.dgvResponsableAutoFR.TabIndex = 19
            '
            'txtIdResponsableAutoFR
            '
            Me.txtIdResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtIdResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdResponsableAutoFR.Location = New System.Drawing.Point(69, 19)
            Me.txtIdResponsableAutoFR.Name = "txtIdResponsableAutoFR"
            Me.txtIdResponsableAutoFR.Size = New System.Drawing.Size(95, 21)
            Me.txtIdResponsableAutoFR.TabIndex = 20
            '
            'txtCIResponsableAutoFR
            '
            Me.txtCIResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtCIResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCIResponsableAutoFR.Location = New System.Drawing.Point(222, 19)
            Me.txtCIResponsableAutoFR.Name = "txtCIResponsableAutoFR"
            Me.txtCIResponsableAutoFR.Size = New System.Drawing.Size(132, 21)
            Me.txtCIResponsableAutoFR.TabIndex = 21
            '
            'txtNombreResponsableAutoFR
            '
            Me.txtNombreResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreResponsableAutoFR.Location = New System.Drawing.Point(441, 15)
            Me.txtNombreResponsableAutoFR.Name = "txtNombreResponsableAutoFR"
            Me.txtNombreResponsableAutoFR.Size = New System.Drawing.Size(252, 21)
            Me.txtNombreResponsableAutoFR.TabIndex = 23
            '
            'txtApellidoResponsableAutoFR
            '
            Me.txtApellidoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtApellidoResponsableAutoFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoResponsableAutoFR.Location = New System.Drawing.Point(441, 41)
            Me.txtApellidoResponsableAutoFR.Name = "txtApellidoResponsableAutoFR"
            Me.txtApellidoResponsableAutoFR.Size = New System.Drawing.Size(252, 21)
            Me.txtApellidoResponsableAutoFR.TabIndex = 26
            '
            'lblApellidoResponsableAutoFR
            '
            Me.lblApellidoResponsableAutoFR.AutoSize = True
            Me.lblApellidoResponsableAutoFR.Location = New System.Drawing.Point(380, 44)
            Me.lblApellidoResponsableAutoFR.Name = "lblApellidoResponsableAutoFR"
            Me.lblApellidoResponsableAutoFR.Size = New System.Drawing.Size(60, 13)
            Me.lblApellidoResponsableAutoFR.TabIndex = 25
            Me.lblApellidoResponsableAutoFR.Text = "APELLIDO:"
            '
            'pCentroCostoSolicitudFR
            '
            Me.pCentroCostoSolicitudFR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbParroquia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbCanton)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.cmbProvincia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblParroquia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblProvincia)
            Me.pCentroCostoSolicitudFR.Controls.Add(Me.lblCanton)
            Me.pCentroCostoSolicitudFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pCentroCostoSolicitudFR.Location = New System.Drawing.Point(2, 113)
            Me.pCentroCostoSolicitudFR.Name = "pCentroCostoSolicitudFR"
            Me.pCentroCostoSolicitudFR.Size = New System.Drawing.Size(705, 41)
            Me.pCentroCostoSolicitudFR.TabIndex = 27
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(515, 10)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(171, 21)
            Me.cmbParroquia.TabIndex = 7
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(281, 10)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(151, 21)
            Me.cmbCanton.TabIndex = 6
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(82, 10)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(135, 21)
            Me.cmbProvincia.TabIndex = 5
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Location = New System.Drawing.Point(444, 13)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(70, 13)
            Me.lblParroquia.TabIndex = 5
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Location = New System.Drawing.Point(8, 13)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(67, 13)
            Me.lblProvincia.TabIndex = 1
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'lblCanton
            '
            Me.lblCanton.AutoSize = True
            Me.lblCanton.Location = New System.Drawing.Point(224, 13)
            Me.lblCanton.Name = "lblCanton"
            Me.lblCanton.Size = New System.Drawing.Size(55, 13)
            Me.lblCanton.TabIndex = 3
            Me.lblCanton.Text = "CANTON:"
            '
            'cmbCargo
            '
            Me.cmbCargo.BackColor = System.Drawing.Color.White
            Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCargo.FormattingEnabled = True
            Me.cmbCargo.Location = New System.Drawing.Point(69, 48)
            Me.cmbCargo.Name = "cmbCargo"
            Me.cmbCargo.Size = New System.Drawing.Size(303, 21)
            Me.cmbCargo.TabIndex = 28
            '
            'gbResponsable
            '
            Me.gbResponsable.BackColor = System.Drawing.Color.White
            Me.gbResponsable.Controls.Add(Me.lblIdResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.lblCIResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.cmbCargo)
            Me.gbResponsable.Controls.Add(Me.lblNombreResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.lblCargoResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.txtApellidoResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.txtIdResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.lblApellidoResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.txtCIResponsableAutoFR)
            Me.gbResponsable.Controls.Add(Me.txtNombreResponsableAutoFR)
            Me.gbResponsable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbResponsable.Location = New System.Drawing.Point(4, 34)
            Me.gbResponsable.Name = "gbResponsable"
            Me.gbResponsable.Size = New System.Drawing.Size(703, 76)
            Me.gbResponsable.TabIndex = 30
            Me.gbResponsable.TabStop = False
            Me.gbResponsable.Text = "RESPONSABLE"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoResponsableAutoFondoRotativo, Me.btnGuardarResponsableAutoFR, Me.btnCancelarResponsableAutoFR})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(712, 32)
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
            'FormResponsableAutorizacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(712, 345)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbResponsable)
            Me.Controls.Add(Me.pCentroCostoSolicitudFR)
            Me.Controls.Add(Me.dgvResponsableAutoFR)
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
            Me.pCentroCostoSolicitudFR.ResumeLayout(False)
            Me.pCentroCostoSolicitudFR.PerformLayout()
            Me.gbResponsable.ResumeLayout(False)
            Me.gbResponsable.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIdResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents lblCIResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents lblNombreResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents lblCargoResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents dgvResponsableAutoFR As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCIResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtApellidoResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents lblApellidoResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents pCentroCostoSolicitudFR As System.Windows.Forms.Panel
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents lblCanton As System.Windows.Forms.Label
        Friend WithEvents cmbCargo As System.Windows.Forms.ComboBox
        Friend WithEvents gbResponsable As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoResponsableAutoFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarResponsableAutoFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarResponsableAutoFR As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace