Namespace FORMULARIOS.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDocumentosNoDeducibles
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDocumentosNoDeducibles))
            Me.gbDocumentoNoDeducible = New System.Windows.Forms.GroupBox()
            Me.txtValorDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpDocumentoNoDeducible = New System.Windows.Forms.DateTimePicker()
            Me.lblNumeroRecibo = New System.Windows.Forms.Label()
            Me.txtNumeroDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.lblFechaDocumentoDeducible = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtDescripcionDocumentoNoDeducible = New System.Windows.Forms.TextBox()
            Me.gbConceptoCompra = New System.Windows.Forms.GroupBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.lblCodigoCuentaConcepto = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnListo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbDocumentoNoDeducible.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbConceptoCompra.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbDocumentoNoDeducible
            '
            Me.gbDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.gbDocumentoNoDeducible.Controls.Add(Me.txtValorDocumentoNoDeducible)
            Me.gbDocumentoNoDeducible.Controls.Add(Me.Label2)
            Me.gbDocumentoNoDeducible.Controls.Add(Me.dtpDocumentoNoDeducible)
            Me.gbDocumentoNoDeducible.Controls.Add(Me.lblNumeroRecibo)
            Me.gbDocumentoNoDeducible.Controls.Add(Me.txtNumeroDocumentoNoDeducible)
            Me.gbDocumentoNoDeducible.Controls.Add(Me.lblFechaDocumentoDeducible)
            Me.gbDocumentoNoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDocumentoNoDeducible.Location = New System.Drawing.Point(1, 24)
            Me.gbDocumentoNoDeducible.Name = "gbDocumentoNoDeducible"
            Me.gbDocumentoNoDeducible.Size = New System.Drawing.Size(614, 43)
            Me.gbDocumentoNoDeducible.TabIndex = 49
            Me.gbDocumentoNoDeducible.TabStop = False
            Me.gbDocumentoNoDeducible.Text = "DOCUMENTO"
            '
            'txtValorDocumentoNoDeducible
            '
            Me.txtValorDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtValorDocumentoNoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDocumentoNoDeducible.Location = New System.Drawing.Point(502, 13)
            Me.txtValorDocumentoNoDeducible.Name = "txtValorDocumentoNoDeducible"
            Me.txtValorDocumentoNoDeducible.Size = New System.Drawing.Size(106, 23)
            Me.txtValorDocumentoNoDeducible.TabIndex = 4
            Me.txtValorDocumentoNoDeducible.Text = "0.00"
            Me.txtValorDocumentoNoDeducible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(456, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(47, 15)
            Me.Label2.TabIndex = 35
            Me.Label2.Text = "VALOR:"
            '
            'dtpDocumentoNoDeducible
            '
            Me.dtpDocumentoNoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDocumentoNoDeducible.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDocumentoNoDeducible.Location = New System.Drawing.Point(261, 14)
            Me.dtpDocumentoNoDeducible.Name = "dtpDocumentoNoDeducible"
            Me.dtpDocumentoNoDeducible.Size = New System.Drawing.Size(129, 23)
            Me.dtpDocumentoNoDeducible.TabIndex = 2
            '
            'lblNumeroRecibo
            '
            Me.lblNumeroRecibo.AutoSize = True
            Me.lblNumeroRecibo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroRecibo.Location = New System.Drawing.Point(7, 17)
            Me.lblNumeroRecibo.Name = "lblNumeroRecibo"
            Me.lblNumeroRecibo.Size = New System.Drawing.Size(35, 15)
            Me.lblNumeroRecibo.TabIndex = 9
            Me.lblNumeroRecibo.Text = "NRO:"
            '
            'txtNumeroDocumentoNoDeducible
            '
            Me.txtNumeroDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtNumeroDocumentoNoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroDocumentoNoDeducible.Location = New System.Drawing.Point(48, 14)
            Me.txtNumeroDocumentoNoDeducible.Name = "txtNumeroDocumentoNoDeducible"
            Me.txtNumeroDocumentoNoDeducible.Size = New System.Drawing.Size(129, 23)
            Me.txtNumeroDocumentoNoDeducible.TabIndex = 1
            '
            'lblFechaDocumentoDeducible
            '
            Me.lblFechaDocumentoDeducible.AutoSize = True
            Me.lblFechaDocumentoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaDocumentoDeducible.Location = New System.Drawing.Point(206, 17)
            Me.lblFechaDocumentoDeducible.Name = "lblFechaDocumentoDeducible"
            Me.lblFechaDocumentoDeducible.Size = New System.Drawing.Size(47, 15)
            Me.lblFechaDocumentoDeducible.TabIndex = 34
            Me.lblFechaDocumentoDeducible.Text = "FECHA:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtDescripcionDocumentoNoDeducible)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 111)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(614, 76)
            Me.GroupBox1.TabIndex = 50
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DETALLE"
            '
            'txtDescripcionDocumentoNoDeducible
            '
            Me.txtDescripcionDocumentoNoDeducible.BackColor = System.Drawing.Color.White
            Me.txtDescripcionDocumentoNoDeducible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescripcionDocumentoNoDeducible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescripcionDocumentoNoDeducible.Location = New System.Drawing.Point(6, 17)
            Me.txtDescripcionDocumentoNoDeducible.Multiline = True
            Me.txtDescripcionDocumentoNoDeducible.Name = "txtDescripcionDocumentoNoDeducible"
            Me.txtDescripcionDocumentoNoDeducible.Size = New System.Drawing.Size(602, 54)
            Me.txtDescripcionDocumentoNoDeducible.TabIndex = 3
            '
            'gbConceptoCompra
            '
            Me.gbConceptoCompra.BackColor = System.Drawing.Color.White
            Me.gbConceptoCompra.Controls.Add(Me.TextBox1)
            Me.gbConceptoCompra.Controls.Add(Me.lblCodigoCuentaConcepto)
            Me.gbConceptoCompra.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConceptoCompra.Location = New System.Drawing.Point(1, 66)
            Me.gbConceptoCompra.Name = "gbConceptoCompra"
            Me.gbConceptoCompra.Size = New System.Drawing.Size(614, 45)
            Me.gbConceptoCompra.TabIndex = 85
            Me.gbConceptoCompra.TabStop = False
            Me.gbConceptoCompra.Text = "CONCEPTO:"
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.Location = New System.Drawing.Point(6, 16)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(602, 23)
            Me.TextBox1.TabIndex = 2
            '
            'lblCodigoCuentaConcepto
            '
            Me.lblCodigoCuentaConcepto.AutoSize = True
            Me.lblCodigoCuentaConcepto.Location = New System.Drawing.Point(81, 1)
            Me.lblCodigoCuentaConcepto.Name = "lblCodigoCuentaConcepto"
            Me.lblCodigoCuentaConcepto.Size = New System.Drawing.Size(16, 15)
            Me.lblCodigoCuentaConcepto.TabIndex = 1
            Me.lblCodigoCuentaConcepto.Text = "..."
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnListo, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.MenuStrip1.Size = New System.Drawing.Size(616, 24)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnListo
            '
            Me.btnListo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnListo.Image = Global.syscisepro.My.Resources.Resources.ok
            Me.btnListo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnListo.Name = "btnListo"
            Me.btnListo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnListo.Size = New System.Drawing.Size(86, 20)
            Me.btnListo.Text = "ACEPTAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btnCancelar.Size = New System.Drawing.Size(95, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormDocumentosNoDeducibles
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(616, 187)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbConceptoCompra)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDocumentoNoDeducible)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormDocumentosNoDeducibles"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DOCUMENTO NO DEDUCIBLES"
            Me.gbDocumentoNoDeducible.ResumeLayout(False)
            Me.gbDocumentoNoDeducible.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbConceptoCompra.ResumeLayout(False)
            Me.gbConceptoCompra.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbDocumentoNoDeducible As System.Windows.Forms.GroupBox
        Friend WithEvents dtpDocumentoNoDeducible As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblNumeroRecibo As System.Windows.Forms.Label
        Friend WithEvents txtNumeroDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaDocumentoDeducible As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtValorDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents txtDescripcionDocumentoNoDeducible As System.Windows.Forms.TextBox
        Friend WithEvents gbConceptoCompra As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnListo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblCodigoCuentaConcepto As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    End Class
End Namespace