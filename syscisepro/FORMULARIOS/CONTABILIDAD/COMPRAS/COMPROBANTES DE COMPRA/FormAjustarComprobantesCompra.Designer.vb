Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAjustarComprobantesCompra
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustarComprobantesCompra))
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.txtObservacionesComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.gbDatosEspecialesComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTipoComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtRazModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtDocModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblGuiaRemisionFacturaCompra = New System.Windows.Forms.Label()
            Me.txtGuiaRemisionComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblPorcentajeIVA = New System.Windows.Forms.Label()
            Me.txtDescuentoFacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblFechaEmisionFacturaCompra = New System.Windows.Forms.Label()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.lblNumAutoSRIFacturaCompra = New System.Windows.Forms.Label()
            Me.txtNumAutoSRIComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblNumeroFacturaCompra = New System.Windows.Forms.Label()
            Me.dtpFechaAutoSRIComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.txtNumeroComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblFechaAutoSRIFacturaCompra = New System.Windows.Forms.Label()
            Me.lblSeparadorRUC = New System.Windows.Forms.Label()
            Me.lblSeparadorNumFact = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbNombreComercialProveedor.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDatosEspecialesComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gbNombreComercialProveedor.Controls.Add(Me.Label6)
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(2, 25)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(811, 54)
            Me.gbNombreComercialProveedor.TabIndex = 93
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(9, 23)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(561, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(85, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(664, 26)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(608, 26)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 29
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(645, 26)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvComprobantesCompra)
            Me.GroupBox1.Controls.Add(Me.txtObservacionesComprobantesCompra)
            Me.GroupBox1.Controls.Add(Me.gbDatosEspecialesComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.GroupBox1.Location = New System.Drawing.Point(2, 82)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(811, 526)
            Me.GroupBox1.TabIndex = 92
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "COMPROBANTES DE COMPRA"
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(9, 204)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(794, 314)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'txtObservacionesComprobantesCompra
            '
            Me.txtObservacionesComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobantesCompra.Enabled = False
            Me.txtObservacionesComprobantesCompra.Location = New System.Drawing.Point(9, 178)
            Me.txtObservacionesComprobantesCompra.Name = "txtObservacionesComprobantesCompra"
            Me.txtObservacionesComprobantesCompra.Size = New System.Drawing.Size(794, 20)
            Me.txtObservacionesComprobantesCompra.TabIndex = 98
            Me.txtObservacionesComprobantesCompra.Text = "..."
            '
            'gbDatosEspecialesComprobanteCompra
            '
            Me.gbDatosEspecialesComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label2)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtTipoComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label1)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtRazModComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label32)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtDocModComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.lblGuiaRemisionFacturaCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtGuiaRemisionComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label5)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label9)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label45)
            Me.gbDatosEspecialesComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosEspecialesComprobanteCompra.Location = New System.Drawing.Point(9, 14)
            Me.gbDatosEspecialesComprobanteCompra.Name = "gbDatosEspecialesComprobanteCompra"
            Me.gbDatosEspecialesComprobanteCompra.Size = New System.Drawing.Size(239, 158)
            Me.gbDatosEspecialesComprobanteCompra.TabIndex = 97
            Me.gbDatosEspecialesComprobanteCompra.TabStop = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 132)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(37, 13)
            Me.Label2.TabIndex = 67
            Me.Label2.Text = "TIPO:"
            '
            'txtTipoComprobanteCompra
            '
            Me.txtTipoComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTipoComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoComprobanteCompra.Enabled = False
            Me.txtTipoComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoComprobanteCompra.Location = New System.Drawing.Point(96, 129)
            Me.txtTipoComprobanteCompra.Name = "txtTipoComprobanteCompra"
            Me.txtTipoComprobanteCompra.Size = New System.Drawing.Size(134, 20)
            Me.txtTipoComprobanteCompra.TabIndex = 66
            Me.txtTipoComprobanteCompra.Text = "..."
            Me.txtTipoComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 94)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 13)
            Me.Label1.TabIndex = 65
            Me.Label1.Text = "AUT. SRI:"
            '
            'txtRazModComprobanteCompra
            '
            Me.txtRazModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtRazModComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazModComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazModComprobanteCompra.Location = New System.Drawing.Point(96, 89)
            Me.txtRazModComprobanteCompra.Name = "txtRazModComprobanteCompra"
            Me.txtRazModComprobanteCompra.Size = New System.Drawing.Size(134, 20)
            Me.txtRazModComprobanteCompra.TabIndex = 64
            Me.txtRazModComprobanteCompra.Text = "..."
            Me.txtRazModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(4, 54)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(79, 13)
            Me.Label32.TabIndex = 63
            Me.Label32.Text = "DOC. MODIF.:"
            '
            'txtDocModComprobanteCompra
            '
            Me.txtDocModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtDocModComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocModComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocModComprobanteCompra.Location = New System.Drawing.Point(96, 51)
            Me.txtDocModComprobanteCompra.Name = "txtDocModComprobanteCompra"
            Me.txtDocModComprobanteCompra.Size = New System.Drawing.Size(134, 20)
            Me.txtDocModComprobanteCompra.TabIndex = 62
            Me.txtDocModComprobanteCompra.Text = "000"
            Me.txtDocModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblGuiaRemisionFacturaCompra
            '
            Me.lblGuiaRemisionFacturaCompra.AutoSize = True
            Me.lblGuiaRemisionFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuiaRemisionFacturaCompra.Location = New System.Drawing.Point(4, 16)
            Me.lblGuiaRemisionFacturaCompra.Name = "lblGuiaRemisionFacturaCompra"
            Me.lblGuiaRemisionFacturaCompra.Size = New System.Drawing.Size(91, 13)
            Me.lblGuiaRemisionFacturaCompra.TabIndex = 57
            Me.lblGuiaRemisionFacturaCompra.Text = "GUIA REMISIÓN:"
            '
            'txtGuiaRemisionComprobanteCompra
            '
            Me.txtGuiaRemisionComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtGuiaRemisionComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtGuiaRemisionComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuiaRemisionComprobanteCompra.Location = New System.Drawing.Point(96, 13)
            Me.txtGuiaRemisionComprobanteCompra.Name = "txtGuiaRemisionComprobanteCompra"
            Me.txtGuiaRemisionComprobanteCompra.Size = New System.Drawing.Size(134, 20)
            Me.txtGuiaRemisionComprobanteCompra.TabIndex = 12
            Me.txtGuiaRemisionComprobanteCompra.Text = "000"
            Me.txtGuiaRemisionComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label5.Location = New System.Drawing.Point(4, 29)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(229, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "_____________________________________"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label9.Location = New System.Drawing.Point(4, 67)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(229, 13)
            Me.Label9.TabIndex = 59
            Me.Label9.Text = "_____________________________________"
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label45.Location = New System.Drawing.Point(4, 106)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(229, 13)
            Me.Label45.TabIndex = 61
            Me.Label45.Text = "_____________________________________"
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.Label3)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblPorcentajeIVA)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuentoFacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0FacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12FacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(487, 14)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(316, 158)
            Me.gbValoresComprobanteCompra.TabIndex = 96
            Me.gbValoresComprobanteCompra.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(66, 111)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(19, 13)
            Me.Label3.TabIndex = 23
            Me.Label3.Text = "%:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblPorcentajeIVA
            '
            Me.lblPorcentajeIVA.AutoSize = True
            Me.lblPorcentajeIVA.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPorcentajeIVA.Location = New System.Drawing.Point(47, 111)
            Me.lblPorcentajeIVA.Name = "lblPorcentajeIVA"
            Me.lblPorcentajeIVA.Size = New System.Drawing.Size(13, 13)
            Me.lblPorcentajeIVA.TabIndex = 22
            Me.lblPorcentajeIVA.Text = "0"
            Me.lblPorcentajeIVA.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtDescuentoFacturaCompra
            '
            Me.txtDescuentoFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoFacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoFacturaCompra.Location = New System.Drawing.Point(142, 59)
            Me.txtDescuentoFacturaCompra.Name = "txtDescuentoFacturaCompra"
            Me.txtDescuentoFacturaCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtDescuentoFacturaCompra.TabIndex = 18
            Me.txtDescuentoFacturaCompra.Text = "0.00"
            Me.txtDescuentoFacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0FacturaCompra
            '
            Me.txtSubtotal0FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0FacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0FacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0FacturaCompra.Location = New System.Drawing.Point(142, 36)
            Me.txtSubtotal0FacturaCompra.Name = "txtSubtotal0FacturaCompra"
            Me.txtSubtotal0FacturaCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtSubtotal0FacturaCompra.TabIndex = 17
            Me.txtSubtotal0FacturaCompra.Text = "0.00"
            Me.txtSubtotal0FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12FacturaCompra
            '
            Me.txtSubtotal12FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12FacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12FacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12FacturaCompra.Location = New System.Drawing.Point(142, 13)
            Me.txtSubtotal12FacturaCompra.Name = "txtSubtotal12FacturaCompra"
            Me.txtSubtotal12FacturaCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtSubtotal12FacturaCompra.TabIndex = 16
            Me.txtSubtotal12FacturaCompra.Text = "0.00"
            Me.txtSubtotal12FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalComprobanteCompra
            '
            Me.txtSubTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubTotalComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalComprobanteCompra.Location = New System.Drawing.Point(142, 82)
            Me.txtSubTotalComprobanteCompra.Name = "txtSubTotalComprobanteCompra"
            Me.txtSubTotalComprobanteCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtSubTotalComprobanteCompra.TabIndex = 19
            Me.txtSubTotalComprobanteCompra.Text = "0.00"
            Me.txtSubTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(16, 86)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(67, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(142, 129)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtTotalComprobanteCompra.TabIndex = 21
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(142, 106)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(107, 20)
            Me.txtIvaComprobanteCompra.TabIndex = 20
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(16, 134)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(16, 111)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblIvaOrdenCompra.TabIndex = 13
            Me.lblIvaOrdenCompra.Text = "IVA"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(17, 62)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(67, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(17, 39)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0:"
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(17, 16)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(85, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 10
            Me.lblSubtotal12OrdenCompra.Text = "SUB TOTAL 12:"
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumAutoSRIFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.txtNumAutoSRIComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.dtpFechaAutoSRIComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.txtNumeroComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaAutoSRIFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblSeparadorRUC)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblSeparadorNumFact)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label37)
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(248, 14)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(239, 158)
            Me.gbDatosComprobanteCompra.TabIndex = 95
            Me.gbDatosComprobanteCompra.TabStop = False
            '
            'lblFechaEmisionFacturaCompra
            '
            Me.lblFechaEmisionFacturaCompra.AutoSize = True
            Me.lblFechaEmisionFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaEmisionFacturaCompra.Location = New System.Drawing.Point(5, 132)
            Me.lblFechaEmisionFacturaCompra.Name = "lblFechaEmisionFacturaCompra"
            Me.lblFechaEmisionFacturaCompra.Size = New System.Drawing.Size(91, 13)
            Me.lblFechaEmisionFacturaCompra.TabIndex = 55
            Me.lblFechaEmisionFacturaCompra.Text = "FECHA EMISIÓN:"
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(98, 129)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(127, 20)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 11
            '
            'lblNumAutoSRIFacturaCompra
            '
            Me.lblNumAutoSRIFacturaCompra.AutoSize = True
            Me.lblNumAutoSRIFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAutoSRIFacturaCompra.Location = New System.Drawing.Point(5, 54)
            Me.lblNumAutoSRIFacturaCompra.Name = "lblNumAutoSRIFacturaCompra"
            Me.lblNumAutoSRIFacturaCompra.Size = New System.Drawing.Size(61, 13)
            Me.lblNumAutoSRIFacturaCompra.TabIndex = 28
            Me.lblNumAutoSRIFacturaCompra.Text = "AUT. SRI:"
            '
            'txtNumAutoSRIComprobanteCompra
            '
            Me.txtNumAutoSRIComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoSRIComprobanteCompra.Location = New System.Drawing.Point(76, 51)
            Me.txtNumAutoSRIComprobanteCompra.Name = "txtNumAutoSRIComprobanteCompra"
            Me.txtNumAutoSRIComprobanteCompra.Size = New System.Drawing.Size(149, 20)
            Me.txtNumAutoSRIComprobanteCompra.TabIndex = 14
            Me.txtNumAutoSRIComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNumeroFacturaCompra
            '
            Me.lblNumeroFacturaCompra.AutoSize = True
            Me.lblNumeroFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaCompra.Location = New System.Drawing.Point(5, 16)
            Me.lblNumeroFacturaCompra.Name = "lblNumeroFacturaCompra"
            Me.lblNumeroFacturaCompra.Size = New System.Drawing.Size(61, 13)
            Me.lblNumeroFacturaCompra.TabIndex = 26
            Me.lblNumeroFacturaCompra.Text = "Nº FACT.:"
            '
            'dtpFechaAutoSRIComprobanteCompra
            '
            Me.dtpFechaAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAutoSRIComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAutoSRIComprobanteCompra.Location = New System.Drawing.Point(98, 90)
            Me.dtpFechaAutoSRIComprobanteCompra.Name = "dtpFechaAutoSRIComprobanteCompra"
            Me.dtpFechaAutoSRIComprobanteCompra.Size = New System.Drawing.Size(127, 20)
            Me.dtpFechaAutoSRIComprobanteCompra.TabIndex = 15
            '
            'txtNumeroComprobanteCompra
            '
            Me.txtNumeroComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteCompra.Location = New System.Drawing.Point(76, 13)
            Me.txtNumeroComprobanteCompra.Name = "txtNumeroComprobanteCompra"
            Me.txtNumeroComprobanteCompra.Size = New System.Drawing.Size(149, 20)
            Me.txtNumeroComprobanteCompra.TabIndex = 13
            Me.txtNumeroComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaAutoSRIFacturaCompra
            '
            Me.lblFechaAutoSRIFacturaCompra.AutoSize = True
            Me.lblFechaAutoSRIFacturaCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaAutoSRIFacturaCompra.Location = New System.Drawing.Point(5, 94)
            Me.lblFechaAutoSRIFacturaCompra.Name = "lblFechaAutoSRIFacturaCompra"
            Me.lblFechaAutoSRIFacturaCompra.Size = New System.Drawing.Size(79, 13)
            Me.lblFechaAutoSRIFacturaCompra.TabIndex = 54
            Me.lblFechaAutoSRIFacturaCompra.Text = "FECHA AUTO.:"
            '
            'lblSeparadorRUC
            '
            Me.lblSeparadorRUC.AutoSize = True
            Me.lblSeparadorRUC.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.lblSeparadorRUC.Location = New System.Drawing.Point(6, 29)
            Me.lblSeparadorRUC.Name = "lblSeparadorRUC"
            Me.lblSeparadorRUC.Size = New System.Drawing.Size(223, 13)
            Me.lblSeparadorRUC.TabIndex = 30
            Me.lblSeparadorRUC.Text = "____________________________________"
            '
            'lblSeparadorNumFact
            '
            Me.lblSeparadorNumFact.AutoSize = True
            Me.lblSeparadorNumFact.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.lblSeparadorNumFact.Location = New System.Drawing.Point(6, 67)
            Me.lblSeparadorNumFact.Name = "lblSeparadorNumFact"
            Me.lblSeparadorNumFact.Size = New System.Drawing.Size(223, 13)
            Me.lblSeparadorNumFact.TabIndex = 31
            Me.lblSeparadorNumFact.Text = "____________________________________"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label37.Location = New System.Drawing.Point(6, 106)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(223, 13)
            Me.Label37.TabIndex = 56
            Me.Label37.Text = "____________________________________"
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(819, 309)
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(286, 86)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 107
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(819, 242)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(286, 61)
            Me.dgvComprobanteRetencion.TabIndex = 106
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(818, 24)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(98, 20)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormAjustarComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(818, 612)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAjustarComprobantesCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AJUSTAR COMPROBANTE DE COMPRA"
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDatosEspecialesComprobanteCompra.ResumeLayout(False)
            Me.gbDatosEspecialesComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents gbDatosEspecialesComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtRazModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtDocModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblGuiaRemisionFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents txtGuiaRemisionComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label45 As System.Windows.Forms.Label
        Friend WithEvents gbValoresComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescuentoFacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0FacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12FacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblSubTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblNumAutoSRIFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents txtNumAutoSRIComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblNumeroFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents dtpFechaAutoSRIComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaAutoSRIFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents lblSeparadorRUC As System.Windows.Forms.Label
        Friend WithEvents lblSeparadorNumFact As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtTipoComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacionesComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblPorcentajeIVA As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace