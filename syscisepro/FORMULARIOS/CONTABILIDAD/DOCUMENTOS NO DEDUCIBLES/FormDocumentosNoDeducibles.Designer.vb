Namespace FORMULARIOS.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDocumentosNoDeducibles
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDocumentosNoDeducibles))
            Me.txtValorDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.dtpDocumentoNoDeducible = New System.Windows.Forms.DateTimePicker()
            Me.txtNumeroDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.txtDescripcionDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.lblCodigoCuentaConcepto = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnListo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtValorDocumentoNoDeducible
            '
            Me.txtValorDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtValorDocumentoNoDeducible.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDocumentoNoDeducible.Location = New System.Drawing.Point(435, 4)
            Me.txtValorDocumentoNoDeducible.Name = "txtValorDocumentoNoDeducible"
            Me.txtValorDocumentoNoDeducible.Size = New System.Drawing.Size(91, 22)
            Me.txtValorDocumentoNoDeducible.TabIndex = 4
            Me.txtValorDocumentoNoDeducible.Text = "0.00"
            Me.txtValorDocumentoNoDeducible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dtpDocumentoNoDeducible
            '
            Me.dtpDocumentoNoDeducible.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDocumentoNoDeducible.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDocumentoNoDeducible.Location = New System.Drawing.Point(255, 6)
            Me.dtpDocumentoNoDeducible.Name = "dtpDocumentoNoDeducible"
            Me.dtpDocumentoNoDeducible.Size = New System.Drawing.Size(112, 22)
            Me.dtpDocumentoNoDeducible.TabIndex = 2
            '
            'txtNumeroDocumentoNoDeducible
            '
            Me.txtNumeroDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtNumeroDocumentoNoDeducible.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroDocumentoNoDeducible.Location = New System.Drawing.Point(65, 3)
            Me.txtNumeroDocumentoNoDeducible.Name = "txtNumeroDocumentoNoDeducible"
            Me.txtNumeroDocumentoNoDeducible.Size = New System.Drawing.Size(116, 22)
            Me.txtNumeroDocumentoNoDeducible.TabIndex = 1
            '
            'txtDescripcionDocumentoNoDeducible
            '
            Me.txtDescripcionDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtDescripcionDocumentoNoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescripcionDocumentoNoDeducible.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescripcionDocumentoNoDeducible.Location = New System.Drawing.Point(65, 61)
            Me.txtDescripcionDocumentoNoDeducible.Multiline = True
            Me.txtDescripcionDocumentoNoDeducible.Name = "txtDescripcionDocumentoNoDeducible"
            Me.txtDescripcionDocumentoNoDeducible.Size = New System.Drawing.Size(461, 21)
            Me.txtDescripcionDocumentoNoDeducible.TabIndex = 3
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(65, 34)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(302, 22)
            Me.TextBox1.TabIndex = 2
            '
            'lblCodigoCuentaConcepto
            '
            Me.lblCodigoCuentaConcepto.AutoSize = True
            Me.lblCodigoCuentaConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblCodigoCuentaConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblCodigoCuentaConcepto.Location = New System.Drawing.Point(387, 37)
            Me.lblCodigoCuentaConcepto.Name = "lblCodigoCuentaConcepto"
            Me.lblCodigoCuentaConcepto.Size = New System.Drawing.Size(16, 13)
            Me.lblCodigoCuentaConcepto.TabIndex = 1
            Me.lblCodigoCuentaConcepto.Text = "..."
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListo, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.MenuStrip1.Size = New System.Drawing.Size(616, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnListo
            '
            Me.btnListo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnListo.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnListo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnListo.Name = "btnListo"
            Me.btnListo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnListo.Size = New System.Drawing.Size(92, 28)
            Me.btnListo.Text = "ACEPTAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnCancelar.Size = New System.Drawing.Size(103, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(1, 39)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDescripcionDocumentoNoDeducible)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCodigoCuentaConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.TextBox1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorDocumentoNoDeducible)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDocumentoNoDeducible)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroDocumentoNoDeducible)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(614, 137)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Documento"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 8)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Numero"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(207, 6)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 2
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(390, 8)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel3.TabIndex = 3
            Me.KryptonLabel3.Values.Text = "Valor"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(4, 34)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "Concepto"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(4, 62)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "Detalle"
            '
            'FormDocumentosNoDeducibles
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(616, 177)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormDocumentosNoDeducibles"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DOCUMENTO NO DEDUCIBLES"
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
        Friend WithEvents dtpDocumentoNoDeducible As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents txtValorDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents txtDescripcionDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnListo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblCodigoCuentaConcepto As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace