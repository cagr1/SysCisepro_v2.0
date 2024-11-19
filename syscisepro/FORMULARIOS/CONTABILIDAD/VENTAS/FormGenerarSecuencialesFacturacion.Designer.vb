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
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtObservacionesFacturaSecuenciales = New System.Windows.Forms.TextBox()
            Me.txtFinalFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.txtInicialFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.lblActual = New System.Windows.Forms.Label()
            Me.dtpFechaFacturaSecuenciales = New System.Windows.Forms.DateTimePicker()
            Me.txtCantidadFacturaSecuencial = New System.Windows.Forms.TextBox()
            Me.lblIdFacturaSecuencial = New System.Windows.Forms.Label()
            Me.dgvFacturaSecuenciales = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.gbDatos.SuspendLayout()
            CType(Me.dgvFacturaSecuenciales, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbDatos
            '
            Me.gbDatos.BackColor = System.Drawing.Color.White
            Me.gbDatos.Controls.Add(Me.Label6)
            Me.gbDatos.Controls.Add(Me.Label5)
            Me.gbDatos.Controls.Add(Me.Label4)
            Me.gbDatos.Controls.Add(Me.Label3)
            Me.gbDatos.Controls.Add(Me.Label2)
            Me.gbDatos.Controls.Add(Me.Label1)
            Me.gbDatos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatos.Location = New System.Drawing.Point(175, 217)
            Me.gbDatos.Name = "gbDatos"
            Me.gbDatos.Size = New System.Drawing.Size(96, 28)
            Me.gbDatos.TabIndex = 33
            Me.gbDatos.TabStop = False
            Me.gbDatos.Text = "SECUENCIALES"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(10, 100)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(98, 13)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "OBSERVACIONES:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(421, 61)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(66, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "SEC. FINAL:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(199, 61)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "SEC. INICIAL:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(11, 61)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "CANTIDAD:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(421, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(117, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "ULTIMO SECUENCIAL:"
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
            'txtObservacionesFacturaSecuenciales
            '
            Me.txtObservacionesFacturaSecuenciales.BackColor = System.Drawing.Color.White
            Me.txtObservacionesFacturaSecuenciales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesFacturaSecuenciales.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesFacturaSecuenciales.Location = New System.Drawing.Point(96, 55)
            Me.txtObservacionesFacturaSecuenciales.Name = "txtObservacionesFacturaSecuenciales"
            Me.txtObservacionesFacturaSecuenciales.Size = New System.Drawing.Size(381, 21)
            Me.txtObservacionesFacturaSecuenciales.TabIndex = 11
            Me.txtObservacionesFacturaSecuenciales.Text = "..."
            '
            'txtFinalFacturaSecuencial
            '
            Me.txtFinalFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtFinalFacturaSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFinalFacturaSecuencial.Location = New System.Drawing.Point(405, 28)
            Me.txtFinalFacturaSecuencial.Name = "txtFinalFacturaSecuencial"
            Me.txtFinalFacturaSecuencial.ReadOnly = True
            Me.txtFinalFacturaSecuencial.Size = New System.Drawing.Size(64, 21)
            Me.txtFinalFacturaSecuencial.TabIndex = 9
            Me.txtFinalFacturaSecuencial.Text = "0"
            Me.txtFinalFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtInicialFacturaSecuencial
            '
            Me.txtInicialFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtInicialFacturaSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtInicialFacturaSecuencial.Location = New System.Drawing.Point(245, 29)
            Me.txtInicialFacturaSecuencial.Name = "txtInicialFacturaSecuencial"
            Me.txtInicialFacturaSecuencial.ReadOnly = True
            Me.txtInicialFacturaSecuencial.Size = New System.Drawing.Size(64, 21)
            Me.txtInicialFacturaSecuencial.TabIndex = 7
            Me.txtInicialFacturaSecuencial.Text = "0"
            Me.txtInicialFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblActual
            '
            Me.lblActual.AutoSize = True
            Me.lblActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblActual.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblActual.Location = New System.Drawing.Point(425, 7)
            Me.lblActual.Name = "lblActual"
            Me.lblActual.Size = New System.Drawing.Size(42, 14)
            Me.lblActual.TabIndex = 5
            Me.lblActual.Text = "00000"
            '
            'dtpFechaFacturaSecuenciales
            '
            Me.dtpFechaFacturaSecuenciales.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFacturaSecuenciales.Location = New System.Drawing.Point(96, 4)
            Me.dtpFechaFacturaSecuenciales.Name = "dtpFechaFacturaSecuenciales"
            Me.dtpFechaFacturaSecuenciales.Size = New System.Drawing.Size(169, 21)
            Me.dtpFechaFacturaSecuenciales.TabIndex = 3
            '
            'txtCantidadFacturaSecuencial
            '
            Me.txtCantidadFacturaSecuencial.BackColor = System.Drawing.Color.White
            Me.txtCantidadFacturaSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidadFacturaSecuencial.Location = New System.Drawing.Point(96, 30)
            Me.txtCantidadFacturaSecuencial.Name = "txtCantidadFacturaSecuencial"
            Me.txtCantidadFacturaSecuencial.Size = New System.Drawing.Size(64, 21)
            Me.txtCantidadFacturaSecuencial.TabIndex = 1
            Me.txtCantidadFacturaSecuencial.Text = "0"
            Me.txtCantidadFacturaSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIdFacturaSecuencial
            '
            Me.lblIdFacturaSecuencial.AutoSize = True
            Me.lblIdFacturaSecuencial.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdFacturaSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdFacturaSecuencial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdFacturaSecuencial.Location = New System.Drawing.Point(302, 40)
            Me.lblIdFacturaSecuencial.Name = "lblIdFacturaSecuencial"
            Me.lblIdFacturaSecuencial.Size = New System.Drawing.Size(16, 13)
            Me.lblIdFacturaSecuencial.TabIndex = 0
            Me.lblIdFacturaSecuencial.Text = "..."
            '
            'dgvFacturaSecuenciales
            '
            Me.dgvFacturaSecuenciales.AllowUserToAddRows = False
            Me.dgvFacturaSecuenciales.AllowUserToDeleteRows = False
            Me.dgvFacturaSecuenciales.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaSecuenciales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaSecuenciales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFacturaSecuenciales.BorderStyle = System.Windows.Forms.BorderStyle.None
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
            Me.dgvFacturaSecuenciales.Location = New System.Drawing.Point(4, 161)
            Me.dgvFacturaSecuenciales.Name = "dgvFacturaSecuenciales"
            Me.dgvFacturaSecuenciales.ReadOnly = True
            Me.dgvFacturaSecuenciales.RowHeadersVisible = False
            Me.dgvFacturaSecuenciales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvFacturaSecuenciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaSecuenciales.Size = New System.Drawing.Size(495, 156)
            Me.dgvFacturaSecuenciales.TabIndex = 35
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(501, 32)
            Me.msKardex.TabIndex = 181
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(99, 28)
            Me.btnReporte.Text = "EXPORTAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(4, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFinalFacturaSecuencial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblActual)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtObservacionesFacturaSecuenciales)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtInicialFacturaSecuencial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaFacturaSecuenciales)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCantidadFacturaSecuencial)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(495, 120)
            Me.KryptonGroupBox1.TabIndex = 182
            Me.KryptonGroupBox1.Values.Heading = "Secuenciales"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(289, 5)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(108, 20)
            Me.KryptonLabel6.TabIndex = 14
            Me.KryptonLabel6.Values.Text = "Ultimo Secuencial"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(336, 28)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel5.TabIndex = 13
            Me.KryptonLabel5.Values.Text = "Sec Final"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(169, 30)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel4.TabIndex = 12
            Me.KryptonLabel4.Values.Text = "Sec Inicial"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(5, 56)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Observaciones"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(5, 30)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Cantidad"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Fecha"
            '
            'FormGenerarSecuencialesFacturacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(501, 322)
            Me.Controls.Add(Me.lblIdFacturaSecuencial)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.dgvFacturaSecuenciales)
            Me.Controls.Add(Me.gbDatos)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormGenerarSecuencialesFacturacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "GENERAR SECUENCIALES FACTURACION"
            Me.gbDatos.ResumeLayout(False)
            Me.gbDatos.PerformLayout()
            CType(Me.dgvFacturaSecuenciales, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
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
        Friend WithEvents dgvFacturaSecuenciales As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace