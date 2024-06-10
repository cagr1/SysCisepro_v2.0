Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAgregarDiarioNoDeduciblesFondoCajaChica
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarDiarioNoDeduciblesFondoCajaChica))
            Me.gbRegistro = New System.Windows.Forms.GroupBox()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.txtCajaChica = New System.Windows.Forms.TextBox()
            Me.btnCargar = New System.Windows.Forms.Button()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblDetalleAsiento = New System.Windows.Forms.Label()
            Me.lblConceptoAsiento = New System.Windows.Forms.Label()
            Me.lblNombreCuentaAsiento = New System.Windows.Forms.Label()
            Me.lblNumeroCuentaAsiento = New System.Windows.Forms.Label()
            Me.txtCodCuentaAsiento = New System.Windows.Forms.TextBox()
            Me.txtNombreCuentaAsiento = New System.Windows.Forms.TextBox()
            Me.txtDetalleAsiento = New System.Windows.Forms.TextBox()
            Me.gbRegistro.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRegistro
            '
            Me.gbRegistro.BackColor = System.Drawing.Color.White
            Me.gbRegistro.Controls.Add(Me.txtConcepto)
            Me.gbRegistro.Controls.Add(Me.txtCajaChica)
            Me.gbRegistro.Controls.Add(Me.btnCargar)
            Me.gbRegistro.Controls.Add(Me.cbmCentroCosto)
            Me.gbRegistro.Controls.Add(Me.lblCentroCosto)
            Me.gbRegistro.Controls.Add(Me.lblDetalleAsiento)
            Me.gbRegistro.Controls.Add(Me.lblConceptoAsiento)
            Me.gbRegistro.Controls.Add(Me.lblNombreCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.lblNumeroCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtCodCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtNombreCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtDetalleAsiento)
            Me.gbRegistro.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRegistro.Location = New System.Drawing.Point(-1, 0)
            Me.gbRegistro.Name = "gbRegistro"
            Me.gbRegistro.Size = New System.Drawing.Size(647, 141)
            Me.gbRegistro.TabIndex = 20
            Me.gbRegistro.TabStop = False
            Me.gbRegistro.Text = "BUSCAR CUENTA"
            '
            'txtConcepto
            '
            Me.txtConcepto.BackColor = System.Drawing.Color.White
            Me.txtConcepto.Enabled = False
            Me.txtConcepto.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.ForeColor = System.Drawing.Color.Black
            Me.txtConcepto.Location = New System.Drawing.Point(68, 81)
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(570, 22)
            Me.txtConcepto.TabIndex = 36
            Me.txtConcepto.Text = "OTROS GASTOS NO DEDUCIBLES"
            '
            'txtCajaChica
            '
            Me.txtCajaChica.BackColor = System.Drawing.Color.White
            Me.txtCajaChica.Enabled = False
            Me.txtCajaChica.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCajaChica.ForeColor = System.Drawing.Color.Black
            Me.txtCajaChica.Location = New System.Drawing.Point(348, 23)
            Me.txtCajaChica.Name = "txtCajaChica"
            Me.txtCajaChica.Size = New System.Drawing.Size(219, 22)
            Me.txtCajaChica.TabIndex = 35
            '
            'btnCargar
            '
            Me.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCargar.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnCargar.FlatAppearance.BorderSize = 0
            Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCargar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCargar.Location = New System.Drawing.Point(573, 13)
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(50, 36)
            Me.btnCargar.TabIndex = 33
            Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCargar.UseVisualStyleBackColor = True
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(68, 23)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(274, 22)
            Me.cbmCentroCosto.TabIndex = 31
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(9, 23)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(50, 26)
            Me.lblCentroCosto.TabIndex = 32
            Me.lblCentroCosto.Text = "CENTRO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COSTO"
            '
            'lblDetalleAsiento
            '
            Me.lblDetalleAsiento.AutoSize = True
            Me.lblDetalleAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleAsiento.Location = New System.Drawing.Point(9, 110)
            Me.lblDetalleAsiento.Name = "lblDetalleAsiento"
            Me.lblDetalleAsiento.Size = New System.Drawing.Size(52, 13)
            Me.lblDetalleAsiento.TabIndex = 26
            Me.lblDetalleAsiento.Text = "DETALLE"
            '
            'lblConceptoAsiento
            '
            Me.lblConceptoAsiento.AutoSize = True
            Me.lblConceptoAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConceptoAsiento.Location = New System.Drawing.Point(9, 81)
            Me.lblConceptoAsiento.Name = "lblConceptoAsiento"
            Me.lblConceptoAsiento.Size = New System.Drawing.Size(65, 13)
            Me.lblConceptoAsiento.TabIndex = 24
            Me.lblConceptoAsiento.Text = "CONCEPTO"
            '
            'lblNombreCuentaAsiento
            '
            Me.lblNombreCuentaAsiento.AutoSize = True
            Me.lblNombreCuentaAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreCuentaAsiento.Location = New System.Drawing.Point(177, 49)
            Me.lblNombreCuentaAsiento.Name = "lblNombreCuentaAsiento"
            Me.lblNombreCuentaAsiento.Size = New System.Drawing.Size(53, 26)
            Me.lblNombreCuentaAsiento.TabIndex = 23
            Me.lblNombreCuentaAsiento.Text = "NOMBRE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUENTA:"
            '
            'lblNumeroCuentaAsiento
            '
            Me.lblNumeroCuentaAsiento.AutoSize = True
            Me.lblNumeroCuentaAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroCuentaAsiento.Location = New System.Drawing.Point(9, 55)
            Me.lblNumeroCuentaAsiento.Name = "lblNumeroCuentaAsiento"
            Me.lblNumeroCuentaAsiento.Size = New System.Drawing.Size(59, 13)
            Me.lblNumeroCuentaAsiento.TabIndex = 22
            Me.lblNumeroCuentaAsiento.Text = "# CUENTA"
            '
            'txtCodCuentaAsiento
            '
            Me.txtCodCuentaAsiento.BackColor = System.Drawing.Color.White
            Me.txtCodCuentaAsiento.Enabled = False
            Me.txtCodCuentaAsiento.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodCuentaAsiento.ForeColor = System.Drawing.Color.Black
            Me.txtCodCuentaAsiento.Location = New System.Drawing.Point(68, 52)
            Me.txtCodCuentaAsiento.Name = "txtCodCuentaAsiento"
            Me.txtCodCuentaAsiento.Size = New System.Drawing.Size(103, 22)
            Me.txtCodCuentaAsiento.TabIndex = 4
            Me.txtCodCuentaAsiento.Text = "520228"
            '
            'txtNombreCuentaAsiento
            '
            Me.txtNombreCuentaAsiento.BackColor = System.Drawing.Color.White
            Me.txtNombreCuentaAsiento.Enabled = False
            Me.txtNombreCuentaAsiento.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCuentaAsiento.ForeColor = System.Drawing.Color.Black
            Me.txtNombreCuentaAsiento.Location = New System.Drawing.Point(230, 52)
            Me.txtNombreCuentaAsiento.Name = "txtNombreCuentaAsiento"
            Me.txtNombreCuentaAsiento.Size = New System.Drawing.Size(410, 22)
            Me.txtNombreCuentaAsiento.TabIndex = 5
            Me.txtNombreCuentaAsiento.Text = "SIN CUENTA"
            '
            'txtDetalleAsiento
            '
            Me.txtDetalleAsiento.BackColor = System.Drawing.Color.White
            Me.txtDetalleAsiento.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleAsiento.ForeColor = System.Drawing.Color.Black
            Me.txtDetalleAsiento.Location = New System.Drawing.Point(68, 110)
            Me.txtDetalleAsiento.Name = "txtDetalleAsiento"
            Me.txtDetalleAsiento.Size = New System.Drawing.Size(572, 22)
            Me.txtDetalleAsiento.TabIndex = 7
            Me.txtDetalleAsiento.Text = "DETALLE UNIFICADO"
            '
            'FormAgregarDiarioNoDeduciblesFondoCajaChica
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(644, 140)
            Me.Controls.Add(Me.gbRegistro)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAgregarDiarioNoDeduciblesFondoCajaChica"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AGREGAR NO DEDUCIBLES A LIBRO DIARIO"
            Me.gbRegistro.ResumeLayout(False)
            Me.gbRegistro.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
        Friend WithEvents lblDetalleAsiento As System.Windows.Forms.Label
        Friend WithEvents lblConceptoAsiento As System.Windows.Forms.Label
        Friend WithEvents lblNombreCuentaAsiento As System.Windows.Forms.Label
        Friend WithEvents lblNumeroCuentaAsiento As System.Windows.Forms.Label
        Friend WithEvents txtCodCuentaAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCuentaAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleAsiento As System.Windows.Forms.TextBox
        Friend WithEvents btnCargar As System.Windows.Forms.Button
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents txtCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    End Class
End Namespace