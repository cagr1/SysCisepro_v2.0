<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendienteFacturacion
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
        Me.dgvPendiente = New Krypton.Toolkit.KryptonDataGridView()
        Me.btnExportar = New Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.dtpFecha = New Krypton.Toolkit.KryptonDateTimePicker()
        CType(Me.dgvPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPendiente
        '
        Me.dgvPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPendiente.Location = New System.Drawing.Point(12, 49)
        Me.dgvPendiente.Name = "dgvPendiente"
        Me.dgvPendiente.RowHeadersVisible = False
        Me.dgvPendiente.Size = New System.Drawing.Size(603, 389)
        Me.dgvPendiente.TabIndex = 0
        '
        'btnExportar
        '
        Me.btnExportar.AutoSize = True
        Me.btnExportar.Location = New System.Drawing.Point(118, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(90, 32)
        Me.btnExportar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnExportar.StateNormal.Border.Rounding = 5.0!
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Values.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
        Me.btnExportar.Values.Text = "Exportar"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.AutoSize = True
        Me.KryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate
        Me.KryptonButton1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(90, 32)
        Me.KryptonButton1.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.StateNormal.Border.Rounding = 5.0!
        Me.KryptonButton1.TabIndex = 2
        Me.KryptonButton1.Values.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
        Me.KryptonButton1.Values.Text = "Aceptar"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(229, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(195, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'FrmPendienteFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(628, 450)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.dgvPendiente)
        Me.Name = "FrmPendienteFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.StateActive.Border.Rounding = 5.0!
        Me.Text = "Pendiente Facturacion"
        CType(Me.dgvPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPendiente As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnExportar As Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents dtpFecha As Krypton.Toolkit.KryptonDateTimePicker
End Class
