Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAnularNotaCredito
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularNotaCredito))
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblLlevaContabilidadClienteGeneral = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblRucClienteGenral = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.gbFacturaVenta = New System.Windows.Forms.GroupBox()
            Me.lblTipoPagoFacturaCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdNotaCredito = New System.Windows.Forms.Label()
            Me.dgvNotaCredito = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbBuscarNotaCredito = New System.Windows.Forms.GroupBox()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbClienteGeneral.SuspendLayout()
            Me.gbFacturaVenta.SuspendLayout()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBuscarNotaCredito.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.Label5)
            Me.gbClienteGeneral.Controls.Add(Me.Label4)
            Me.gbClienteGeneral.Controls.Add(Me.lblLlevaContabilidadClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.Label2)
            Me.gbClienteGeneral.Controls.Add(Me.lblRucClienteGenral)
            Me.gbClienteGeneral.Controls.Add(Me.Label1)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialCliente)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(248, 26)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(649, 41)
            Me.gbClienteGeneral.TabIndex = 107
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(244, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(121, 13)
            Me.Label5.TabIndex = 100
            Me.Label5.Text = "LLEVA CONTABILIDAD:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(110, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "RUC:"
            '
            'lblLlevaContabilidadClienteGeneral
            '
            Me.lblLlevaContabilidadClienteGeneral.AutoSize = True
            Me.lblLlevaContabilidadClienteGeneral.Location = New System.Drawing.Point(365, 0)
            Me.lblLlevaContabilidadClienteGeneral.Name = "lblLlevaContabilidadClienteGeneral"
            Me.lblLlevaContabilidadClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblLlevaContabilidadClienteGeneral.TabIndex = 98
            Me.lblLlevaContabilidadClienteGeneral.Text = "..."
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(229, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 97
            Me.Label2.Text = "/"
            '
            'lblRucClienteGenral
            '
            Me.lblRucClienteGenral.AutoSize = True
            Me.lblRucClienteGenral.Location = New System.Drawing.Point(141, 0)
            Me.lblRucClienteGenral.Name = "lblRucClienteGenral"
            Me.lblRucClienteGenral.Size = New System.Drawing.Size(25, 13)
            Me.lblRucClienteGenral.TabIndex = 96
            Me.lblRucClienteGenral.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(95, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 95
            Me.Label1.Text = "/"
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(60, 0)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblIdClienteGeneral.TabIndex = 1
            Me.lblIdClienteGeneral.Text = "..."
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(18, 16)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(619, 20)
            Me.txtNombreComercialCliente.TabIndex = 0
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbFacturaVenta.Controls.Add(Me.lblTipoPagoFacturaCompra)
            Me.gbFacturaVenta.Controls.Add(Me.Label6)
            Me.gbFacturaVenta.Controls.Add(Me.lblIdNotaCredito)
            Me.gbFacturaVenta.Controls.Add(Me.dgvNotaCredito)
            Me.gbFacturaVenta.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.gbFacturaVenta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturaVenta.Location = New System.Drawing.Point(1, 68)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            Me.gbFacturaVenta.Size = New System.Drawing.Size(896, 685)
            Me.gbFacturaVenta.TabIndex = 104
            Me.gbFacturaVenta.TabStop = False
            Me.gbFacturaVenta.Text = "NOTA DE CRÉDITO"
            '
            'lblTipoPagoFacturaCompra
            '
            Me.lblTipoPagoFacturaCompra.AutoSize = True
            Me.lblTipoPagoFacturaCompra.Location = New System.Drawing.Point(181, 0)
            Me.lblTipoPagoFacturaCompra.Name = "lblTipoPagoFacturaCompra"
            Me.lblTipoPagoFacturaCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblTipoPagoFacturaCompra.TabIndex = 94
            Me.lblTipoPagoFacturaCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(162, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(13, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdNotaCredito
            '
            Me.lblIdNotaCredito.AutoSize = True
            Me.lblIdNotaCredito.Location = New System.Drawing.Point(128, 0)
            Me.lblIdNotaCredito.Name = "lblIdNotaCredito"
            Me.lblIdNotaCredito.Size = New System.Drawing.Size(25, 13)
            Me.lblIdNotaCredito.TabIndex = 29
            Me.lblIdNotaCredito.Text = "..."
            '
            'dgvNotaCredito
            '
            Me.dgvNotaCredito.AllowUserToAddRows = False
            Me.dgvNotaCredito.AllowUserToDeleteRows = False
            Me.dgvNotaCredito.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNotaCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNotaCredito.BackgroundColor = System.Drawing.Color.White
            Me.dgvNotaCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvNotaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNotaCredito.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNotaCredito.Location = New System.Drawing.Point(3, 16)
            Me.dgvNotaCredito.Name = "dgvNotaCredito"
            Me.dgvNotaCredito.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvNotaCredito.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvNotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNotaCredito.Size = New System.Drawing.Size(890, 666)
            Me.dgvNotaCredito.TabIndex = 86
            '
            'chk
            '
            Me.chk.HeaderText = "CHK"
            Me.chk.Name = "chk"
            Me.chk.Width = 30
            '
            'dgvPagosFacturaVenta
            '
            Me.dgvPagosFacturaVenta.AllowUserToAddRows = False
            Me.dgvPagosFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvPagosFacturaVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvPagosFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(129, 126)
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            Me.dgvPagosFacturaVenta.ReadOnly = True
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(524, 154)
            Me.dgvPagosFacturaVenta.TabIndex = 109
            '
            'gbBuscarNotaCredito
            '
            Me.gbBuscarNotaCredito.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarNotaCredito.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbBuscarNotaCredito.Location = New System.Drawing.Point(1, 26)
            Me.gbBuscarNotaCredito.Name = "gbBuscarNotaCredito"
            Me.gbBuscarNotaCredito.Size = New System.Drawing.Size(241, 41)
            Me.gbBuscarNotaCredito.TabIndex = 95
            Me.gbBuscarNotaCredito.TabStop = False
            Me.gbBuscarNotaCredito.Text = "BUSCAR NOTA CRÉDITO"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(124, 13)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(84, 23)
            Me.btnBuscarAsiento.TabIndex = 26
            Me.btnBuscarAsiento.Text = "BUSCAR #"
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(13, 15)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnGuardar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(897, 24)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR FACTURAS"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(77, 20)
            Me.btnGuardar.Text = "ANULAR"
            '
            'FormAnularNotaCredito
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(897, 754)
            Me.Controls.Add(Me.gbBuscarNotaCredito)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAnularNotaCredito"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ANULAR NOTA CRÉDITO"
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.gbFacturaVenta.ResumeLayout(False)
            Me.gbFacturaVenta.PerformLayout()
            CType(Me.dgvNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBuscarNotaCredito.ResumeLayout(False)
            Me.gbBuscarNotaCredito.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblLlevaContabilidadClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblRucClienteGenral As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialCliente As System.Windows.Forms.TextBox
        Friend WithEvents gbFacturaVenta As System.Windows.Forms.GroupBox
        Friend WithEvents gbBuscarNotaCredito As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents lblTipoPagoFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdNotaCredito As System.Windows.Forms.Label
        Friend WithEvents dgvNotaCredito As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace