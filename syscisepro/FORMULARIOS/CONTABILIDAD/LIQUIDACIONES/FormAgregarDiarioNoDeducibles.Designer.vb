Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAgregarDiarioNoDeducibles
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarDiarioNoDeducibles))
            Me.gbRegistro = New System.Windows.Forms.GroupBox()
            Me.txtConceptoAsiento = New System.Windows.Forms.TextBox()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblValorHaberAsiento = New System.Windows.Forms.Label()
            Me.lblValorDebeAsiento = New System.Windows.Forms.Label()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblDetalleAsiento = New System.Windows.Forms.Label()
            Me.lblConceptoAsiento = New System.Windows.Forms.Label()
            Me.lblNombreCuentaAsiento = New System.Windows.Forms.Label()
            Me.lblNumeroCuentaAsiento = New System.Windows.Forms.Label()
            Me.txtCodCuentaAsiento = New System.Windows.Forms.TextBox()
            Me.txtNombreCuentaAsiento = New System.Windows.Forms.TextBox()
            Me.txtDetalleAsiento = New System.Windows.Forms.TextBox()
            Me.txtValorHaberAsiento = New System.Windows.Forms.TextBox()
            Me.txtValorDebeAsiento = New System.Windows.Forms.TextBox()
            Me.gbComandos = New System.Windows.Forms.GroupBox()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnEnviar = New System.Windows.Forms.Button()
            Me.gbRegistro.SuspendLayout()
            Me.gbComandos.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbRegistro
            '
            Me.gbRegistro.BackColor = System.Drawing.SystemColors.Window
            Me.gbRegistro.Controls.Add(Me.txtConceptoAsiento)
            Me.gbRegistro.Controls.Add(Me.cmbCentroCosto)
            Me.gbRegistro.Controls.Add(Me.lblValorHaberAsiento)
            Me.gbRegistro.Controls.Add(Me.lblValorDebeAsiento)
            Me.gbRegistro.Controls.Add(Me.lblCentroCosto)
            Me.gbRegistro.Controls.Add(Me.lblDetalleAsiento)
            Me.gbRegistro.Controls.Add(Me.lblConceptoAsiento)
            Me.gbRegistro.Controls.Add(Me.lblNombreCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.lblNumeroCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtCodCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtNombreCuentaAsiento)
            Me.gbRegistro.Controls.Add(Me.txtDetalleAsiento)
            Me.gbRegistro.Controls.Add(Me.txtValorHaberAsiento)
            Me.gbRegistro.Controls.Add(Me.txtValorDebeAsiento)
            Me.gbRegistro.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRegistro.Location = New System.Drawing.Point(1, 62)
            Me.gbRegistro.Name = "gbRegistro"
            Me.gbRegistro.Size = New System.Drawing.Size(594, 183)
            Me.gbRegistro.TabIndex = 20
            Me.gbRegistro.TabStop = False
            Me.gbRegistro.Text = "REGISTRO"
            '
            'txtConceptoAsiento
            '
            Me.txtConceptoAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConceptoAsiento.Location = New System.Drawing.Point(297, 46)
            Me.txtConceptoAsiento.Name = "txtConceptoAsiento"
            Me.txtConceptoAsiento.Size = New System.Drawing.Size(289, 22)
            Me.txtConceptoAsiento.TabIndex = 35
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(9, 152)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(399, 22)
            Me.cmbCentroCosto.TabIndex = 34
            '
            'lblValorHaberAsiento
            '
            Me.lblValorHaberAsiento.AutoSize = True
            Me.lblValorHaberAsiento.Location = New System.Drawing.Point(503, 135)
            Me.lblValorHaberAsiento.Name = "lblValorHaberAsiento"
            Me.lblValorHaberAsiento.Size = New System.Drawing.Size(42, 14)
            Me.lblValorHaberAsiento.TabIndex = 32
            Me.lblValorHaberAsiento.Text = "HABER"
            '
            'lblValorDebeAsiento
            '
            Me.lblValorDebeAsiento.AutoSize = True
            Me.lblValorDebeAsiento.Location = New System.Drawing.Point(414, 135)
            Me.lblValorDebeAsiento.Name = "lblValorDebeAsiento"
            Me.lblValorDebeAsiento.Size = New System.Drawing.Size(35, 14)
            Me.lblValorDebeAsiento.TabIndex = 31
            Me.lblValorDebeAsiento.Text = "DEBE"
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Location = New System.Drawing.Point(6, 135)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(91, 14)
            Me.lblCentroCosto.TabIndex = 30
            Me.lblCentroCosto.Text = "CENTRO COSTO"
            '
            'lblDetalleAsiento
            '
            Me.lblDetalleAsiento.AutoSize = True
            Me.lblDetalleAsiento.Location = New System.Drawing.Point(6, 82)
            Me.lblDetalleAsiento.Name = "lblDetalleAsiento"
            Me.lblDetalleAsiento.Size = New System.Drawing.Size(56, 14)
            Me.lblDetalleAsiento.TabIndex = 26
            Me.lblDetalleAsiento.Text = "DETALLE"
            '
            'lblConceptoAsiento
            '
            Me.lblConceptoAsiento.AutoSize = True
            Me.lblConceptoAsiento.Location = New System.Drawing.Point(294, 27)
            Me.lblConceptoAsiento.Name = "lblConceptoAsiento"
            Me.lblConceptoAsiento.Size = New System.Drawing.Size(63, 14)
            Me.lblConceptoAsiento.TabIndex = 24
            Me.lblConceptoAsiento.Text = "CONCEPTO"
            '
            'lblNombreCuentaAsiento
            '
            Me.lblNombreCuentaAsiento.AutoSize = True
            Me.lblNombreCuentaAsiento.Location = New System.Drawing.Point(115, 27)
            Me.lblNombreCuentaAsiento.Name = "lblNombreCuentaAsiento"
            Me.lblNombreCuentaAsiento.Size = New System.Drawing.Size(98, 14)
            Me.lblNombreCuentaAsiento.TabIndex = 23
            Me.lblNombreCuentaAsiento.Text = "NOMBRE CUENTA"
            '
            'lblNumeroCuentaAsiento
            '
            Me.lblNumeroCuentaAsiento.AutoSize = True
            Me.lblNumeroCuentaAsiento.Location = New System.Drawing.Point(6, 27)
            Me.lblNumeroCuentaAsiento.Name = "lblNumeroCuentaAsiento"
            Me.lblNumeroCuentaAsiento.Size = New System.Drawing.Size(63, 14)
            Me.lblNumeroCuentaAsiento.TabIndex = 22
            Me.lblNumeroCuentaAsiento.Text = "# CUENTA"
            '
            'txtCodCuentaAsiento
            '
            Me.txtCodCuentaAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodCuentaAsiento.Location = New System.Drawing.Point(5, 46)
            Me.txtCodCuentaAsiento.Name = "txtCodCuentaAsiento"
            Me.txtCodCuentaAsiento.Size = New System.Drawing.Size(103, 22)
            Me.txtCodCuentaAsiento.TabIndex = 4
            Me.txtCodCuentaAsiento.Text = "# CUENTA"
            '
            'txtNombreCuentaAsiento
            '
            Me.txtNombreCuentaAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCuentaAsiento.Location = New System.Drawing.Point(114, 46)
            Me.txtNombreCuentaAsiento.Name = "txtNombreCuentaAsiento"
            Me.txtNombreCuentaAsiento.Size = New System.Drawing.Size(174, 22)
            Me.txtNombreCuentaAsiento.TabIndex = 5
            Me.txtNombreCuentaAsiento.Text = "NOM CUENTA"
            '
            'txtDetalleAsiento
            '
            Me.txtDetalleAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleAsiento.Location = New System.Drawing.Point(6, 99)
            Me.txtDetalleAsiento.Name = "txtDetalleAsiento"
            Me.txtDetalleAsiento.Size = New System.Drawing.Size(581, 22)
            Me.txtDetalleAsiento.TabIndex = 7
            Me.txtDetalleAsiento.Text = "DETALLE"
            '
            'txtValorHaberAsiento
            '
            Me.txtValorHaberAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorHaberAsiento.Location = New System.Drawing.Point(503, 152)
            Me.txtValorHaberAsiento.Name = "txtValorHaberAsiento"
            Me.txtValorHaberAsiento.Size = New System.Drawing.Size(83, 22)
            Me.txtValorHaberAsiento.TabIndex = 13
            Me.txtValorHaberAsiento.Text = "0.00"
            '
            'txtValorDebeAsiento
            '
            Me.txtValorDebeAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDebeAsiento.Location = New System.Drawing.Point(414, 152)
            Me.txtValorDebeAsiento.Name = "txtValorDebeAsiento"
            Me.txtValorDebeAsiento.Size = New System.Drawing.Size(83, 22)
            Me.txtValorDebeAsiento.TabIndex = 12
            Me.txtValorDebeAsiento.Text = "0.00"
            '
            'gbComandos
            '
            Me.gbComandos.BackColor = System.Drawing.Color.White
            Me.gbComandos.Controls.Add(Me.btnCancelar)
            Me.gbComandos.Controls.Add(Me.btnEnviar)
            Me.gbComandos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComandos.Location = New System.Drawing.Point(1, 2)
            Me.gbComandos.Name = "gbComandos"
            Me.gbComandos.Size = New System.Drawing.Size(594, 60)
            Me.gbComandos.TabIndex = 21
            Me.gbComandos.TabStop = False
            Me.gbComandos.Text = "COMANDO"
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.Color.White
            Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
            Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCancelar.Location = New System.Drawing.Point(531, 12)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(58, 43)
            Me.btnCancelar.TabIndex = 20
            Me.btnCancelar.Text = "CANCELAR SALIR"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'btnEnviar
            '
            Me.btnEnviar.BackColor = System.Drawing.Color.White
            Me.btnEnviar.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnEnviar.Enabled = False
            Me.btnEnviar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
            Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEnviar.Location = New System.Drawing.Point(474, 12)
            Me.btnEnviar.Name = "btnEnviar"
            Me.btnEnviar.Size = New System.Drawing.Size(58, 43)
            Me.btnEnviar.TabIndex = 19
            Me.btnEnviar.Text = "REVISION CORRECTA"
            Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEnviar.UseVisualStyleBackColor = False
            '
            'FormAgregarDiarioNoDeducibles
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(596, 245)
            Me.Controls.Add(Me.gbComandos)
            Me.Controls.Add(Me.gbRegistro)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAgregarDiarioNoDeducibles"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AGREGAR NO DEDUCIBLES A LIBRO DIARIO"
            Me.gbRegistro.ResumeLayout(False)
            Me.gbRegistro.PerformLayout()
            Me.gbComandos.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
        Friend WithEvents lblValorHaberAsiento As System.Windows.Forms.Label
        Friend WithEvents lblValorDebeAsiento As System.Windows.Forms.Label
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents lblDetalleAsiento As System.Windows.Forms.Label
        Friend WithEvents lblConceptoAsiento As System.Windows.Forms.Label
        Friend WithEvents lblNombreCuentaAsiento As System.Windows.Forms.Label
        Friend WithEvents lblNumeroCuentaAsiento As System.Windows.Forms.Label
        Friend WithEvents txtCodCuentaAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCuentaAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtValorHaberAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtValorDebeAsiento As System.Windows.Forms.TextBox
        Friend WithEvents gbComandos As System.Windows.Forms.GroupBox
        Friend WithEvents btnEnviar As System.Windows.Forms.Button
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents txtConceptoAsiento As System.Windows.Forms.TextBox
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
    End Class
End Namespace