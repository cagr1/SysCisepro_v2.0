<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGrupo
    'Inherits System.Windows.Forms.Form
    Inherits Krypton.Toolkit.KryptonForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvGrupos = New Krypton.Toolkit.KryptonDataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.btnEdit = New Krypton.Toolkit.KryptonButton()
        Me.btnAdd = New Krypton.Toolkit.KryptonButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AllowUserToAddRows = False
        Me.dgvGrupos.AllowUserToDeleteRows = False
        Me.dgvGrupos.AllowUserToResizeRows = False
        Me.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrupos.Location = New System.Drawing.Point(12, 90)
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.RowHeadersVisible = False
        Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupos.Size = New System.Drawing.Size(501, 308)
        Me.dgvGrupos.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(309, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 34)
        Me.btnCancelar.TabIndex = 199
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(424, 404)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 34)
        Me.btnAceptar.TabIndex = 200
        Me.btnAceptar.Text = "GUARDAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 7)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 201
        Me.KryptonLabel1.Values.Text = "Nombre"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionOverlap = 0R
        Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnEdit)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnAdd)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(501, 72)
        Me.KryptonGroupBox1.TabIndex = 202
        Me.KryptonGroupBox1.Values.Heading = "Informacion"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(434, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(30, 30)
        Me.btnEdit.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.[False]
        Me.btnEdit.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.[False]
        Me.btnEdit.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.[True]
        Me.btnEdit.TabIndex = 204
        Me.btnEdit.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnEdit.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnEdit.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnEdit.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
        Me.btnEdit.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24__2_
        Me.btnEdit.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnEdit.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.edit_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnEdit.Values.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(395, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 30)
        Me.btnAdd.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.[False]
        Me.btnAdd.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.[False]
        Me.btnAdd.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAdd.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.[True]
        Me.btnAdd.TabIndex = 203
        Me.btnAdd.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAdd.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAdd.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAdd.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
        Me.btnAdd.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
        Me.btnAdd.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnAdd.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
        Me.btnAdd.Values.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(65, 7)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(319, 21)
        Me.txtNombre.TabIndex = 202
        '
        'FormGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 450)
        Me.Controls.Add(Me.KryptonGroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvGrupos)
        Me.Name = "FormGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.StateActive.Border.Rounding = 5.0!
        Me.Text = "Grupos"
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvGrupos As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAdd As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEdit As Krypton.Toolkit.KryptonButton
End Class
