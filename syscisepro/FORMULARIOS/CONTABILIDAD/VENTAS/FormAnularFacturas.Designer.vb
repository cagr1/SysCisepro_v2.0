Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAnularFacturas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnularFacturas))
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.dgvPagosFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbBuscarFactura = New System.Windows.Forms.GroupBox()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvNotaCreditoVenta = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbClienteGeneral.SuspendLayout()
            Me.gbFacturaVenta.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBuscarFactura.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvNotaCreditoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.gbClienteGeneral.Location = New System.Drawing.Point(242, 27)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(599, 48)
            Me.gbClienteGeneral.TabIndex = 102
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
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(11, 18)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(582, 20)
            Me.txtNombreComercialCliente.TabIndex = 0
            '
            'gbFacturaVenta
            '
            Me.gbFacturaVenta.BackColor = System.Drawing.Color.White
            Me.gbFacturaVenta.Controls.Add(Me.dgvFacturaVenta)
            Me.gbFacturaVenta.Controls.Add(Me.dgvPagosFacturaVenta)
            Me.gbFacturaVenta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFacturaVenta.Location = New System.Drawing.Point(1, 75)
            Me.gbFacturaVenta.Name = "gbFacturaVenta"
            Me.gbFacturaVenta.Size = New System.Drawing.Size(840, 528)
            Me.gbFacturaVenta.TabIndex = 99
            Me.gbFacturaVenta.TabStop = False
            Me.gbFacturaVenta.Text = "FACTURAS DE VENTAS"
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(3, 18)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvFacturaVenta.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(834, 507)
            Me.dgvFacturaVenta.TabIndex = 86
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
            Me.dgvPagosFacturaVenta.Location = New System.Drawing.Point(251, 90)
            Me.dgvPagosFacturaVenta.Name = "dgvPagosFacturaVenta"
            Me.dgvPagosFacturaVenta.ReadOnly = True
            Me.dgvPagosFacturaVenta.Size = New System.Drawing.Size(441, 154)
            Me.dgvPagosFacturaVenta.TabIndex = 110
            '
            'gbBuscarFactura
            '
            Me.gbBuscarFactura.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbBuscarFactura.Location = New System.Drawing.Point(4, 27)
            Me.gbBuscarFactura.Name = "gbBuscarFactura"
            Me.gbBuscarFactura.Size = New System.Drawing.Size(236, 48)
            Me.gbBuscarFactura.TabIndex = 95
            Me.gbBuscarFactura.TabStop = False
            Me.gbBuscarFactura.Text = "BUSCAR FACTURA"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(122, 19)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(84, 23)
            Me.btnBuscarAsiento.TabIndex = 26
            Me.btnBuscarAsiento.Text = "BUSCAR #"
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(11, 19)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 0
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(9, 452)
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(691, 102)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 106
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(9, 373)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(691, 73)
            Me.dgvComprobanteRetencion.TabIndex = 107
            '
            'dgvNotaCreditoVenta
            '
            Me.dgvNotaCreditoVenta.AllowUserToAddRows = False
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvNotaCreditoVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvNotaCreditoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNotaCreditoVenta.DefaultCellStyle = DataGridViewCellStyle9
            Me.dgvNotaCreditoVenta.Location = New System.Drawing.Point(9, 560)
            Me.dgvNotaCreditoVenta.Name = "dgvNotaCreditoVenta"
            Me.dgvNotaCreditoVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvNotaCreditoVenta.Size = New System.Drawing.Size(691, 65)
            Me.dgvNotaCreditoVenta.TabIndex = 108
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(140, 20)
            Me.btnNuevo.Text = "CARGAR FACTURAS"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(77, 20)
            Me.btnGuardar.Text = "ANULAR"
            '
            'FormAnularFacturas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(841, 603)
            Me.Controls.Add(Me.gbBuscarFactura)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbFacturaVenta)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.Controls.Add(Me.dgvNotaCreditoVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAnularFacturas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ANULAR FACTURAS"
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.gbFacturaVenta.ResumeLayout(False)
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvPagosFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBuscarFactura.ResumeLayout(False)
            Me.gbBuscarFactura.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvNotaCreditoVenta, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents gbBuscarFactura As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents chk As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents dgvPagosFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvNotaCreditoVenta As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace