Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormGenerarSecuencialesFacturacion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenerarSecuencialesFacturacion))
            Me.gbDatos = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtObservacionesFacturaSecuenciales = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtFinalFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtInicialFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblActual = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaFacturaSecuenciales = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCantidadFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.lblIdFacturaSecuencial = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dgvFacturaSecuenciales = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbDatos.SuspendLayout()
            CType(Me.dgvFacturaSecuenciales, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbDatos
            '
            Me.gbDatos.BackColor = System.Drawing.Color.White
            Me.gbDatos.Controls.Add(Me.Label6)
            Me.gbDatos.Controls.Add(Me.txtObservacionesFacturaSecuenciales)
            Me.gbDatos.Controls.Add(Me.Label5)
            Me.gbDatos.Controls.Add(Me.txtFinalFacturaSecuencial)
            Me.gbDatos.Controls.Add(Me.Label4)
            Me.gbDatos.Controls.Add(Me.txtInicialFacturaSecuencial)
            Me.gbDatos.Controls.Add(Me.Label3)
            Me.gbDatos.Controls.Add(Me.lblActual)
            Me.gbDatos.Controls.Add(Me.Label2)
            Me.gbDatos.Controls.Add(Me.dtpFechaFacturaSecuenciales)
            Me.gbDatos.Controls.Add(Me.Label1)
            Me.gbDatos.Controls.Add(Me.txtCantidadFacturaSecuencial)
            Me.gbDatos.Controls.Add(Me.lblIdFacturaSecuencial)
            Me.gbDatos.Location = New System.Drawing.Point(1, 26)
            Me.gbDatos.Name = "gbDatos"
            Me.gbDatos.Size = New System.Drawing.Size(610, 147)
            Me.gbDatos.TabIndex = 33
            Me.gbDatos.TabStop = False
            Me.gbDatos.Text = "SECUENCIALES"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(10, 100)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(96, 13)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "OBSERVACIONES:"
            '
            'txtObservacionesFacturaSecuenciales
            '
            Me.txtObservacionesFacturaSecuenciales.BackColor = System.Drawing.Color.White
            Me.txtObservacionesFacturaSecuenciales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesFacturaSecuenciales.Location = New System.Drawing.Point(108, 97)
            Me.txtObservacionesFacturaSecuenciales.Name = "txtObservacionesFacturaSecuenciales"
            Me.txtObservacionesFacturaSecuenciales.Size = New System.Drawing.Size(492, 22)
            Me.txtObservacionesFacturaSecuenciales.TabIndex = 11
            Me.txtObservacionesFacturaSecuenciales.Text = "..."
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(421, 61)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "SEC. FINAL:"
            '
            'txtFinalFacturaSecuencial
            '
            Me.txtFinalFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtFinalFacturaSecuencial.Location = New System.Drawing.Point(500, 58)
            Me.txtFinalFacturaSecuencial.Name = "txtFinalFacturaSecuencial"
            Me.txtFinalFacturaSecuencial.ReadOnly = True
            Me.txtFinalFacturaSecuencial.Size = New System.Drawing.Size(100, 22)
            Me.txtFinalFacturaSecuencial.TabIndex = 9
            Me.txtFinalFacturaSecuencial.Text = "0"
            Me.txtFinalFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(199, 61)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(71, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "SEC. INICIAL:"
            '
            'txtInicialFacturaSecuencial
            '
            Me.txtInicialFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtInicialFacturaSecuencial.Location = New System.Drawing.Point(290, 58)
            Me.txtInicialFacturaSecuencial.Name = "txtInicialFacturaSecuencial"
            Me.txtInicialFacturaSecuencial.ReadOnly = True
            Me.txtInicialFacturaSecuencial.Size = New System.Drawing.Size(100, 22)
            Me.txtInicialFacturaSecuencial.TabIndex = 7
            Me.txtInicialFacturaSecuencial.Text = "0"
            Me.txtInicialFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(11, 61)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "CANTIDAD:"
            '
            'lblActual
            '
            Me.lblActual.AutoSize = True
            Me.lblActual.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActual.Location = New System.Drawing.Point(552, 20)
            Me.lblActual.Name = "lblActual"
            Me.lblActual.Size = New System.Drawing.Size(48, 18)
            Me.lblActual.TabIndex = 5
            Me.lblActual.Text = "00000"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(421, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(116, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "ULTIMO SECUENCIAL:"
            '
            'dtpFechaFacturaSecuenciales
            '
            Me.dtpFechaFacturaSecuenciales.Location = New System.Drawing.Point(108, 20)
            Me.dtpFechaFacturaSecuenciales.Name = "dtpFechaFacturaSecuenciales"
            Me.dtpFechaFacturaSecuenciales.Size = New System.Drawing.Size(282, 22)
            Me.dtpFechaFacturaSecuenciales.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "FECHA:"
            '
            'txtCantidadFacturaSecuencial
            '
            Me.txtCantidadFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtCantidadFacturaSecuencial.Location = New System.Drawing.Point(108, 58)
            Me.txtCantidadFacturaSecuencial.Name = "txtCantidadFacturaSecuencial"
            Me.txtCantidadFacturaSecuencial.Size = New System.Drawing.Size(64, 22)
            Me.txtCantidadFacturaSecuencial.TabIndex = 1
            Me.txtCantidadFacturaSecuencial.Text = "0"
            Me.txtCantidadFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdFacturaSecuencial
            '
            Me.lblIdFacturaSecuencial.AutoSize = True
            Me.lblIdFacturaSecuencial.Location = New System.Drawing.Point(575, 0)
            Me.lblIdFacturaSecuencial.Name = "lblIdFacturaSecuencial"
            Me.lblIdFacturaSecuencial.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaSecuencial.TabIndex = 0
            Me.lblIdFacturaSecuencial.Text = "..."
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(0, 173)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(612, 20)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "SECUENCIALES"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'dgvFacturaSecuenciales
            '
            Me.dgvFacturaSecuenciales.AllowUserToAddRows = False
            Me.dgvFacturaSecuenciales.AllowUserToDeleteRows = False
            Me.dgvFacturaSecuenciales.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaSecuenciales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaSecuenciales.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaSecuenciales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaSecuenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaSecuenciales.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaSecuenciales.Location = New System.Drawing.Point(1, 196)
            Me.dgvFacturaSecuenciales.Name = "dgvFacturaSecuenciales"
            Me.dgvFacturaSecuenciales.ReadOnly = True
            Me.dgvFacturaSecuenciales.RowHeadersVisible = False
            Me.dgvFacturaSecuenciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaSecuenciales.Size = New System.Drawing.Size(610, 290)
            Me.dgvFacturaSecuenciales.TabIndex = 35
            '
            'msKardex
            '
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.msKardex.Size = New System.Drawing.Size(612, 24)
            Me.msKardex.TabIndex = 181
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(91, 20)
            Me.btnReporte.Text = "EXPORTAR"
            '
            'FormGenerarSecuencialesFacturacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(612, 487)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvFacturaSecuenciales)
            Me.Controls.Add(Me.gbDatos)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormGenerarSecuencialesFacturacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GENERAR SECUENCIALES FACTURACION"
            Me.gbDatos.ResumeLayout(False)
            Me.gbDatos.PerformLayout()
            CType(Me.dgvFacturaSecuenciales, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtObservacionesFacturaSecuenciales As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtFinalFacturaSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtInicialFacturaSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblActual As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFacturaSecuenciales As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCantidadFacturaSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents lblIdFacturaSecuencial As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dgvFacturaSecuenciales As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace