Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAjustarComprobantesCompra
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustarComprobantesCompra))
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.txtObservacionesComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.txtTipoComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtRazModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtDocModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtGuiaRemisionComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuentoFacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.txtNumAutoSRIComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.dtpFechaAutoSRIComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.txtNumeroComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.lblPorcentajeIVA = New System.Windows.Forms.Label()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(9, 3)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(382, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(91, 48)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(481, 6)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(425, 6)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 29
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(462, 6)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(12, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobantesCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(7, 182)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.ReadOnly = True
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvComprobantesCompra.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(687, 159)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'txtObservacionesComprobantesCompra
            '
            Me.txtObservacionesComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobantesCompra.Enabled = False
            Me.txtObservacionesComprobantesCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesComprobantesCompra.Location = New System.Drawing.Point(10, 149)
            Me.txtObservacionesComprobantesCompra.Name = "txtObservacionesComprobantesCompra"
            Me.txtObservacionesComprobantesCompra.Size = New System.Drawing.Size(684, 21)
            Me.txtObservacionesComprobantesCompra.TabIndex = 98
            Me.txtObservacionesComprobantesCompra.Text = "..."
            '
            'txtTipoComprobanteCompra
            '
            Me.txtTipoComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTipoComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoComprobanteCompra.Enabled = False
            Me.txtTipoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoComprobanteCompra.Location = New System.Drawing.Point(100, 80)
            Me.txtTipoComprobanteCompra.Name = "txtTipoComprobanteCompra"
            Me.txtTipoComprobanteCompra.Size = New System.Drawing.Size(134, 21)
            Me.txtTipoComprobanteCompra.TabIndex = 66
            Me.txtTipoComprobanteCompra.Text = "..."
            Me.txtTipoComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtRazModComprobanteCompra
            '
            Me.txtRazModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtRazModComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazModComprobanteCompra.Location = New System.Drawing.Point(100, 54)
            Me.txtRazModComprobanteCompra.Name = "txtRazModComprobanteCompra"
            Me.txtRazModComprobanteCompra.Size = New System.Drawing.Size(134, 21)
            Me.txtRazModComprobanteCompra.TabIndex = 64
            Me.txtRazModComprobanteCompra.Text = "..."
            Me.txtRazModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDocModComprobanteCompra
            '
            Me.txtDocModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtDocModComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDocModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocModComprobanteCompra.Location = New System.Drawing.Point(100, 27)
            Me.txtDocModComprobanteCompra.Name = "txtDocModComprobanteCompra"
            Me.txtDocModComprobanteCompra.Size = New System.Drawing.Size(134, 21)
            Me.txtDocModComprobanteCompra.TabIndex = 62
            Me.txtDocModComprobanteCompra.Text = "000"
            Me.txtDocModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtGuiaRemisionComprobanteCompra
            '
            Me.txtGuiaRemisionComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtGuiaRemisionComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtGuiaRemisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuiaRemisionComprobanteCompra.Location = New System.Drawing.Point(100, 3)
            Me.txtGuiaRemisionComprobanteCompra.Name = "txtGuiaRemisionComprobanteCompra"
            Me.txtGuiaRemisionComprobanteCompra.Size = New System.Drawing.Size(134, 21)
            Me.txtGuiaRemisionComprobanteCompra.TabIndex = 12
            Me.txtGuiaRemisionComprobanteCompra.Text = "000"
            Me.txtGuiaRemisionComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuentoFacturaCompra
            '
            Me.txtDescuentoFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoFacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoFacturaCompra.Location = New System.Drawing.Point(587, 44)
            Me.txtDescuentoFacturaCompra.Name = "txtDescuentoFacturaCompra"
            Me.txtDescuentoFacturaCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtDescuentoFacturaCompra.TabIndex = 18
            Me.txtDescuentoFacturaCompra.Text = "0.00"
            Me.txtDescuentoFacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0FacturaCompra
            '
            Me.txtSubtotal0FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0FacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0FacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0FacturaCompra.Location = New System.Drawing.Point(587, 21)
            Me.txtSubtotal0FacturaCompra.Name = "txtSubtotal0FacturaCompra"
            Me.txtSubtotal0FacturaCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtSubtotal0FacturaCompra.TabIndex = 17
            Me.txtSubtotal0FacturaCompra.Text = "0.00"
            Me.txtSubtotal0FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12FacturaCompra
            '
            Me.txtSubtotal12FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12FacturaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12FacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12FacturaCompra.Location = New System.Drawing.Point(587, -2)
            Me.txtSubtotal12FacturaCompra.Name = "txtSubtotal12FacturaCompra"
            Me.txtSubtotal12FacturaCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtSubtotal12FacturaCompra.TabIndex = 16
            Me.txtSubtotal12FacturaCompra.Text = "0.00"
            Me.txtSubtotal12FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalComprobanteCompra
            '
            Me.txtSubTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubTotalComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubTotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalComprobanteCompra.Location = New System.Drawing.Point(587, 67)
            Me.txtSubTotalComprobanteCompra.Name = "txtSubTotalComprobanteCompra"
            Me.txtSubTotalComprobanteCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtSubTotalComprobanteCompra.TabIndex = 19
            Me.txtSubTotalComprobanteCompra.Text = "0.00"
            Me.txtSubTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(587, 114)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtTotalComprobanteCompra.TabIndex = 21
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(587, 91)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(107, 21)
            Me.txtIvaComprobanteCompra.TabIndex = 20
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(346, 80)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(127, 21)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 11
            '
            'txtNumAutoSRIComprobanteCompra
            '
            Me.txtNumAutoSRIComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoSRIComprobanteCompra.Location = New System.Drawing.Point(346, 28)
            Me.txtNumAutoSRIComprobanteCompra.Name = "txtNumAutoSRIComprobanteCompra"
            Me.txtNumAutoSRIComprobanteCompra.Size = New System.Drawing.Size(149, 21)
            Me.txtNumAutoSRIComprobanteCompra.TabIndex = 14
            Me.txtNumAutoSRIComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dtpFechaAutoSRIComprobanteCompra
            '
            Me.dtpFechaAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAutoSRIComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAutoSRIComprobanteCompra.Location = New System.Drawing.Point(346, 54)
            Me.dtpFechaAutoSRIComprobanteCompra.Name = "dtpFechaAutoSRIComprobanteCompra"
            Me.dtpFechaAutoSRIComprobanteCompra.Size = New System.Drawing.Size(127, 21)
            Me.dtpFechaAutoSRIComprobanteCompra.TabIndex = 15
            '
            'txtNumeroComprobanteCompra
            '
            Me.txtNumeroComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteCompra.Location = New System.Drawing.Point(346, 2)
            Me.txtNumeroComprobanteCompra.Name = "txtNumeroComprobanteCompra"
            Me.txtNumeroComprobanteCompra.Size = New System.Drawing.Size(149, 21)
            Me.txtNumeroComprobanteCompra.TabIndex = 13
            Me.txtNumeroComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(716, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(106, 28)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 41)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label6)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(715, 53)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Proveedor"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 100)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvComprobantesCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblPorcentajeIVA)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtObservacionesComprobantesCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDescuentoFacturaCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal0FacturaCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubtotal12FacturaCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSubTotalComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNumAutoSRIComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaAutoSRIComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTipoComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNumeroComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtRazModComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtGuiaRemisionComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtDocModComprobanteCompra)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(715, 387)
            Me.KryptonGroupBox2.TabIndex = 189
            Me.KryptonGroupBox2.Values.Heading = "Comprobante Compra"
            '
            'lblPorcentajeIVA
            '
            Me.lblPorcentajeIVA.AutoSize = True
            Me.lblPorcentajeIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblPorcentajeIVA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPorcentajeIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblPorcentajeIVA.Location = New System.Drawing.Point(544, 94)
            Me.lblPorcentajeIVA.Name = "lblPorcentajeIVA"
            Me.lblPorcentajeIVA.Size = New System.Drawing.Size(13, 13)
            Me.lblPorcentajeIVA.TabIndex = 22
            Me.lblPorcentajeIVA.Text = "0"
            Me.lblPorcentajeIVA.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(506, 114)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel14.TabIndex = 76
            Me.KryptonLabel14.Values.Text = "TOTAL"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(509, 92)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel13.TabIndex = 75
            Me.KryptonLabel13.Values.Text = "IVA "
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(506, 68)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel12.TabIndex = 74
            Me.KryptonLabel12.Values.Text = "SubTotal"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(506, 45)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel11.TabIndex = 73
            Me.KryptonLabel11.Values.Text = "Descuento"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(507, 22)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel10.TabIndex = 72
            Me.KryptonLabel10.Values.Text = "SubTotal 0"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(506, -1)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel9.TabIndex = 71
            Me.KryptonLabel9.Values.Text = "SubTotal 12"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(257, 80)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel8.TabIndex = 70
            Me.KryptonLabel8.Values.Text = "Fecha Emision"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(257, 54)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel7.TabIndex = 69
            Me.KryptonLabel7.Values.Text = "Fecha Auto"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(257, 28)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel6.TabIndex = 68
            Me.KryptonLabel6.Values.Text = "Aut. SRI"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(257, 4)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel5.TabIndex = 67
            Me.KryptonLabel5.Values.Text = "No Factura"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(5, 80)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel4.TabIndex = 65
            Me.KryptonLabel4.Values.Text = "Tipo"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(5, 54)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel3.TabIndex = 63
            Me.KryptonLabel3.Values.Text = "Aut. SRI"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(5, 28)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(71, 20)
            Me.KryptonLabel2.TabIndex = 13
            Me.KryptonLabel2.Values.Text = "Doc. Modif"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 2)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Guia Remision"
            '
            'FormAjustarComprobantesCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(716, 489)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.lblIdProveedorGeneral)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvComprobanteRetencion)
            Me.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAjustarComprobantesCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AJUSTAR COMPROBANTE DE COMPRA"
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents txtRazModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDocModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtGuiaRemisionComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoFacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0FacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12FacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumAutoSRIComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaAutoSRIComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtTipoComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacionesComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblPorcentajeIVA As Label
    End Class
End Namespace