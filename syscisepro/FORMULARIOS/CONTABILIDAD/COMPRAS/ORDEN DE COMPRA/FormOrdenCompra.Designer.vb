Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormOrdenCompra
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrdenCompra))
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtTelefono1ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtLlevaContabilidadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtNombreCiudad = New System.Windows.Forms.TextBox()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.lblValorContribuyenteEspecial = New System.Windows.Forms.Label()
            Me.lblValorLlevacontabilidad = New System.Windows.Forms.Label()
            Me.txtFechaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIdOrdenCompra = New System.Windows.Forms.TextBox()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorUnitarioProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorTotalProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.txtObservacionesOrdenCompra = New System.Windows.Forms.TextBox()
            Me.cmbTipoPagoOrdenCompra = New System.Windows.Forms.ComboBox()
            Me.cmbFormaPagoOrdenCompra = New System.Windows.Forms.ComboBox()
            Me.txtSon = New System.Windows.Forms.TextBox()
            Me.txtTotalOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuentoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0OrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12OrdenCompra = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvRequisicionProductoServicioNew = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvDetalleRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel26 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel24 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIva = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.dgvRequisicionProductoServicioNew, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(222, 7)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 42
            Me.lblIdProveedorGeneral.Text = "..."
            Me.lblIdProveedorGeneral.Visible = False
            '
            'txtTelefono1ProveedorGeneral
            '
            Me.txtTelefono1ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono1ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1ProveedorGeneral.Location = New System.Drawing.Point(355, 58)
            Me.txtTelefono1ProveedorGeneral.Name = "txtTelefono1ProveedorGeneral"
            Me.txtTelefono1ProveedorGeneral.Size = New System.Drawing.Size(85, 21)
            Me.txtTelefono1ProveedorGeneral.TabIndex = 31
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(355, 31)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(85, 21)
            Me.txtRucCiProveedorGeneral.TabIndex = 25
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(72, 58)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(220, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 29
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(72, 31)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(220, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 0
            '
            'txtContribuyenteEspecialProveedorGeneral
            '
            Me.txtContribuyenteEspecialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(562, 30)
            Me.txtContribuyenteEspecialProveedorGeneral.Name = "txtContribuyenteEspecialProveedorGeneral"
            Me.txtContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(32, 21)
            Me.txtContribuyenteEspecialProveedorGeneral.TabIndex = 40
            '
            'txtLlevaContabilidadProveedorGeneral
            '
            Me.txtLlevaContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtLlevaContabilidadProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLlevaContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLlevaContabilidadProveedorGeneral.Location = New System.Drawing.Point(701, 30)
            Me.txtLlevaContabilidadProveedorGeneral.Name = "txtLlevaContabilidadProveedorGeneral"
            Me.txtLlevaContabilidadProveedorGeneral.Size = New System.Drawing.Size(32, 21)
            Me.txtLlevaContabilidadProveedorGeneral.TabIndex = 39
            '
            'txtNombreCiudad
            '
            Me.txtNombreCiudad.BackColor = System.Drawing.Color.White
            Me.txtNombreCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCiudad.Location = New System.Drawing.Point(507, 58)
            Me.txtNombreCiudad.Name = "txtNombreCiudad"
            Me.txtNombreCiudad.Size = New System.Drawing.Size(88, 21)
            Me.txtNombreCiudad.TabIndex = 35
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(643, 58)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(90, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 33
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(621, 9)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(28, 13)
            Me.Label3.TabIndex = 43
            Me.Label3.Text = "###"
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCiudad.Location = New System.Drawing.Point(200, 7)
            Me.lblIdCiudad.Name = "lblIdCiudad"
            Me.lblIdCiudad.Size = New System.Drawing.Size(16, 13)
            Me.lblIdCiudad.TabIndex = 41
            Me.lblIdCiudad.Text = "..."
            Me.lblIdCiudad.Visible = False
            '
            'lblValorContribuyenteEspecial
            '
            Me.lblValorContribuyenteEspecial.AutoSize = True
            Me.lblValorContribuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorContribuyenteEspecial.Location = New System.Drawing.Point(180, 7)
            Me.lblValorContribuyenteEspecial.Name = "lblValorContribuyenteEspecial"
            Me.lblValorContribuyenteEspecial.Size = New System.Drawing.Size(16, 13)
            Me.lblValorContribuyenteEspecial.TabIndex = 40
            Me.lblValorContribuyenteEspecial.Text = "..."
            Me.lblValorContribuyenteEspecial.Visible = False
            '
            'lblValorLlevacontabilidad
            '
            Me.lblValorLlevacontabilidad.AutoSize = True
            Me.lblValorLlevacontabilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorLlevacontabilidad.Location = New System.Drawing.Point(157, 7)
            Me.lblValorLlevacontabilidad.Name = "lblValorLlevacontabilidad"
            Me.lblValorLlevacontabilidad.Size = New System.Drawing.Size(16, 13)
            Me.lblValorLlevacontabilidad.TabIndex = 39
            Me.lblValorLlevacontabilidad.Text = "..."
            Me.lblValorLlevacontabilidad.Visible = False
            '
            'txtFechaOrdenCompra
            '
            Me.txtFechaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtFechaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaOrdenCompra.Location = New System.Drawing.Point(306, 4)
            Me.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra"
            Me.txtFechaOrdenCompra.Size = New System.Drawing.Size(159, 21)
            Me.txtFechaOrdenCompra.TabIndex = 37
            '
            'txtIdOrdenCompra
            '
            Me.txtIdOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIdOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdOrdenCompra.Location = New System.Drawing.Point(72, 4)
            Me.txtIdOrdenCompra.Name = "txtIdOrdenCompra"
            Me.txtIdOrdenCompra.Size = New System.Drawing.Size(68, 21)
            Me.txtIdOrdenCompra.TabIndex = 35
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkReq.Enabled = False
            Me.chkReq.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkReq.Location = New System.Drawing.Point(488, 7)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(106, 17)
            Me.chkReq.TabIndex = 44
            Me.chkReq.Text = "Con requisición:"
            Me.chkReq.UseVisualStyleBackColor = False
            '
            'dgvDetalleOrdenCompra
            '
            Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToOrderColumns = True
            Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleOrdenCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleOrdenCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idItem, Me.nombreProductoServicio, Me.unidadMedida, Me.cantidadProductoServicio, Me.valorUnitarioProductoServicio, Me.valorTotalProductoServicio, Me.IVA})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleOrdenCompra.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(4, 14)
            Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
            Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
            Me.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(741, 191)
            Me.dgvDetalleOrdenCompra.TabIndex = 4
            '
            'idItem
            '
            Me.idItem.HeaderText = "ID"
            Me.idItem.Name = "idItem"
            Me.idItem.ReadOnly = True
            Me.idItem.Width = 50
            '
            'nombreProductoServicio
            '
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.nombreProductoServicio.DefaultCellStyle = DataGridViewCellStyle2
            Me.nombreProductoServicio.HeaderText = "PRODUCTO/SERVICIO"
            Me.nombreProductoServicio.Name = "nombreProductoServicio"
            Me.nombreProductoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nombreProductoServicio.Width = 375
            '
            'unidadMedida
            '
            Me.unidadMedida.HeaderText = "UND"
            Me.unidadMedida.Name = "unidadMedida"
            Me.unidadMedida.ReadOnly = True
            Me.unidadMedida.Width = 48
            '
            'cantidadProductoServicio
            '
            Me.cantidadProductoServicio.HeaderText = "CANT."
            Me.cantidadProductoServicio.Name = "cantidadProductoServicio"
            Me.cantidadProductoServicio.Width = 50
            '
            'valorUnitarioProductoServicio
            '
            Me.valorUnitarioProductoServicio.HeaderText = "V. UNITARIO"
            Me.valorUnitarioProductoServicio.Name = "valorUnitarioProductoServicio"
            Me.valorUnitarioProductoServicio.Width = 105
            '
            'valorTotalProductoServicio
            '
            Me.valorTotalProductoServicio.HeaderText = "V. TOTAL"
            Me.valorTotalProductoServicio.Name = "valorTotalProductoServicio"
            Me.valorTotalProductoServicio.ReadOnly = True
            Me.valorTotalProductoServicio.Width = 105
            '
            'IVA
            '
            Me.IVA.HeaderText = "IVA"
            Me.IVA.Name = "IVA"
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(719, 159)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(28, 28)
            Me.btnEliminar.TabIndex = 19
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'txtObservacionesOrdenCompra
            '
            Me.txtObservacionesOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesOrdenCompra.Location = New System.Drawing.Point(97, 57)
            Me.txtObservacionesOrdenCompra.Name = "txtObservacionesOrdenCompra"
            Me.txtObservacionesOrdenCompra.Size = New System.Drawing.Size(412, 21)
            Me.txtObservacionesOrdenCompra.TabIndex = 5
            '
            'cmbTipoPagoOrdenCompra
            '
            Me.cmbTipoPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.cmbTipoPagoOrdenCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoPagoOrdenCompra.FormattingEnabled = True
            Me.cmbTipoPagoOrdenCompra.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "NOTA DE CRÉDITO"})
            Me.cmbTipoPagoOrdenCompra.Location = New System.Drawing.Point(333, 29)
            Me.cmbTipoPagoOrdenCompra.Name = "cmbTipoPagoOrdenCompra"
            Me.cmbTipoPagoOrdenCompra.Size = New System.Drawing.Size(176, 21)
            Me.cmbTipoPagoOrdenCompra.TabIndex = 2
            '
            'cmbFormaPagoOrdenCompra
            '
            Me.cmbFormaPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.cmbFormaPagoOrdenCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFormaPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFormaPagoOrdenCompra.FormattingEnabled = True
            Me.cmbFormaPagoOrdenCompra.Items.AddRange(New Object() {"CRÉDITO", "CONTADO"})
            Me.cmbFormaPagoOrdenCompra.Location = New System.Drawing.Point(97, 30)
            Me.cmbFormaPagoOrdenCompra.Name = "cmbFormaPagoOrdenCompra"
            Me.cmbFormaPagoOrdenCompra.Size = New System.Drawing.Size(151, 21)
            Me.cmbFormaPagoOrdenCompra.TabIndex = 1
            Me.cmbFormaPagoOrdenCompra.Tag = ""
            '
            'txtSon
            '
            Me.txtSon.BackColor = System.Drawing.Color.White
            Me.txtSon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSon.Location = New System.Drawing.Point(10, 3)
            Me.txtSon.Name = "txtSon"
            Me.txtSon.Size = New System.Drawing.Size(499, 21)
            Me.txtSon.TabIndex = 1
            '
            'txtTotalOrdenCompra
            '
            Me.txtTotalOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalOrdenCompra.Location = New System.Drawing.Point(630, 101)
            Me.txtTotalOrdenCompra.Name = "txtTotalOrdenCompra"
            Me.txtTotalOrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtTotalOrdenCompra.TabIndex = 9
            Me.txtTotalOrdenCompra.Text = "0.00"
            Me.txtTotalOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaOrdenCompra
            '
            Me.txtIvaOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIvaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaOrdenCompra.Location = New System.Drawing.Point(630, 77)
            Me.txtIvaOrdenCompra.Name = "txtIvaOrdenCompra"
            Me.txtIvaOrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtIvaOrdenCompra.TabIndex = 8
            Me.txtIvaOrdenCompra.Text = "0.00"
            Me.txtIvaOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescuentoOrdenCompra
            '
            Me.txtDescuentoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescuentoOrdenCompra.Enabled = False
            Me.txtDescuentoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoOrdenCompra.Location = New System.Drawing.Point(630, 50)
            Me.txtDescuentoOrdenCompra.Name = "txtDescuentoOrdenCompra"
            Me.txtDescuentoOrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtDescuentoOrdenCompra.TabIndex = 7
            Me.txtDescuentoOrdenCompra.Text = "0.00"
            Me.txtDescuentoOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0OrdenCompra
            '
            Me.txtSubtotal0OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal0OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0OrdenCompra.Location = New System.Drawing.Point(630, 25)
            Me.txtSubtotal0OrdenCompra.Name = "txtSubtotal0OrdenCompra"
            Me.txtSubtotal0OrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtSubtotal0OrdenCompra.TabIndex = 6
            Me.txtSubtotal0OrdenCompra.Text = "0.00"
            Me.txtSubtotal0OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12OrdenCompra
            '
            Me.txtSubtotal12OrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSubtotal12OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12OrdenCompra.Location = New System.Drawing.Point(630, -1)
            Me.txtSubtotal12OrdenCompra.Name = "txtSubtotal12OrdenCompra"
            Me.txtSubtotal12OrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtSubtotal12OrdenCompra.TabIndex = 5
            Me.txtSubtotal12OrdenCompra.Text = "0.00"
            Me.txtSubtotal12OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1074, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
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
            'dgvRequisicionProductoServicioNew
            '
            Me.dgvRequisicionProductoServicioNew.AllowUserToAddRows = False
            Me.dgvRequisicionProductoServicioNew.AllowUserToDeleteRows = False
            Me.dgvRequisicionProductoServicioNew.AllowUserToOrderColumns = True
            Me.dgvRequisicionProductoServicioNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRequisicionProductoServicioNew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
            Me.dgvRequisicionProductoServicioNew.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvRequisicionProductoServicioNew.Location = New System.Drawing.Point(0, 0)
            Me.dgvRequisicionProductoServicioNew.Name = "dgvRequisicionProductoServicioNew"
            Me.dgvRequisicionProductoServicioNew.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicioNew.Size = New System.Drawing.Size(310, 169)
            Me.dgvRequisicionProductoServicioNew.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvRequisicionProductoServicioNew.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
            Me.dgvRequisicionProductoServicioNew.TabIndex = 36
            '
            'Column6
            '
            Me.Column6.HeaderText = ""
            Me.Column6.Name = "Column6"
            Me.Column6.Width = 50
            '
            'Column7
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column7.DefaultCellStyle = DataGridViewCellStyle4
            Me.Column7.HeaderText = "ID"
            Me.Column7.Name = "Column7"
            Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            Me.Column7.Width = 50
            '
            'Column8
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.NullValue = Nothing
            Me.Column8.DefaultCellStyle = DataGridViewCellStyle5
            Me.Column8.HeaderText = "Fecha"
            Me.Column8.Name = "Column8"
            '
            'Column9
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column9.DefaultCellStyle = DataGridViewCellStyle6
            Me.Column9.HeaderText = "Requiere"
            Me.Column9.Name = "Column9"
            Me.Column9.Width = 150
            '
            'Column10
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column10.DefaultCellStyle = DataGridViewCellStyle7
            Me.Column10.HeaderText = "Prioridad"
            Me.Column10.Name = "Column10"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(924, 39)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(28, 13)
            Me.Label1.TabIndex = 35
            Me.Label1.Text = "###"
            '
            'dgvRequisicionProductoServicio
            '
            Me.dgvRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToOrderColumns = True
            Me.dgvRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.White
            Me.dgvRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRequisicionProductoServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
            Me.dgvRequisicionProductoServicio.Location = New System.Drawing.Point(18, 63)
            Me.dgvRequisicionProductoServicio.Name = "dgvRequisicionProductoServicio"
            Me.dgvRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequisicionProductoServicio.Size = New System.Drawing.Size(107, 69)
            Me.dgvRequisicionProductoServicio.TabIndex = 1
            '
            'Column1
            '
            Me.Column1.HeaderText = ""
            Me.Column1.Name = "Column1"
            Me.Column1.Width = 35
            '
            'Column2
            '
            Me.Column2.HeaderText = "ID"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column2.Width = 50
            '
            'Column3
            '
            Me.Column3.HeaderText = "FECHA"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
            '
            'Column4
            '
            Me.Column4.HeaderText = "REQUIRIENTE"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column4.Width = 150
            '
            'Column5
            '
            Me.Column5.HeaderText = "PRIORIDAD"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column5.Width = 150
            '
            'dgvDetalleRequisicionProductoServicio
            '
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvDetalleRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleRequisicionProductoServicio.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvDetalleRequisicionProductoServicio.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleRequisicionProductoServicio.Location = New System.Drawing.Point(0, 0)
            Me.dgvDetalleRequisicionProductoServicio.Name = "dgvDetalleRequisicionProductoServicio"
            Me.dgvDetalleRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvDetalleRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionProductoServicio.Size = New System.Drawing.Size(308, 281)
            Me.dgvDetalleRequisicionProductoServicio.TabIndex = 3
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 33)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtContribuyenteEspecialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtLlevaContabilidadProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTelefono1ProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkReq)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblValorContribuyenteEspecial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblValorLlevacontabilidad)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(752, 116)
            Me.KryptonGroupBox1.TabIndex = 190
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(65, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "No Orden"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(250, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 36
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(5, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel3.TabIndex = 45
            Me.KryptonLabel3.Values.Text = "Sr(es)"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(298, 32)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel4.TabIndex = 46
            Me.KryptonLabel4.Values.Text = "RUC /CI"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(4, 55)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel5.TabIndex = 47
            Me.KryptonLabel5.Values.Text = "Direccion"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(298, 55)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(30, 20)
            Me.KryptonLabel6.TabIndex = 48
            Me.KryptonLabel6.Values.Text = "Telf"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(446, 32)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel7.TabIndex = 49
            Me.KryptonLabel7.Values.Text = "Contr Espec"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(600, 30)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel8.TabIndex = 50
            Me.KryptonLabel8.Values.Text = "Lleva Cont"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(446, 55)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel9.TabIndex = 51
            Me.KryptonLabel9.Values.Text = "Ciudad"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(600, 56)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel10.TabIndex = 52
            Me.KryptonLabel10.Values.Text = "Email"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(2, 154)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvDetalleOrdenCompra)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(752, 235)
            Me.KryptonGroupBox2.TabIndex = 191
            Me.KryptonGroupBox2.Values.Heading = "Detalle de Orden"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 395)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel26)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIvaOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel24)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDescuentoOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIva)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal0OrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal12OrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtObservacionesOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.cmbTipoPagoOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.cmbFormaPagoOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSon)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(754, 149)
            Me.KryptonGroupBox3.TabIndex = 192
            Me.KryptonGroupBox3.Values.Heading = "Valores"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(10, 30)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel11.TabIndex = 2
            Me.KryptonLabel11.Values.Text = "Forma Pago"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(261, 30)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(66, 20)
            Me.KryptonLabel12.TabIndex = 3
            Me.KryptonLabel12.Values.Text = "Tipo Pago"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(10, 56)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel13.TabIndex = 4
            Me.KryptonLabel13.Values.Text = "Observaciones"
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(541, 102)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel26.TabIndex = 160
            Me.KryptonLabel26.Values.Text = "Total"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(541, 26)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel24.TabIndex = 159
            Me.KryptonLabel24.Values.Text = "Subtotal 0%"
            '
            'lblIva
            '
            Me.lblIva.Location = New System.Drawing.Point(541, 77)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(29, 20)
            Me.lblIva.TabIndex = 158
            Me.lblIva.Values.Text = "IVA"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(541, 51)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel21.TabIndex = 157
            Me.KryptonLabel21.Values.Text = "Descuento"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(541, 0)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(83, 20)
            Me.KryptonLabel14.TabIndex = 156
            Me.KryptonLabel14.Values.Text = "Subtotal 12%"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(760, 33)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvRequisicionProductoServicioNew)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvRequisicionProductoServicio)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(314, 193)
            Me.KryptonGroupBox4.TabIndex = 193
            Me.KryptonGroupBox4.Values.Heading = "Requisiciones de Compra"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(762, 239)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dgvDetalleRequisicionProductoServicio)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(312, 305)
            Me.KryptonGroupBox5.TabIndex = 194
            Me.KryptonGroupBox5.Values.Heading = "Detalles de Requisicion"
            '
            'FormOrdenCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1074, 544)
            Me.Controls.Add(Me.KryptonGroupBox5)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormOrdenCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ORDEN DE COMPRA"
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.dgvRequisicionProductoServicioNew, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono1ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCiudad As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIdOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
        Friend WithEvents txtContribuyenteEspecialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtLlevaContabilidadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblValorContribuyenteEspecial As System.Windows.Forms.Label
        Friend WithEvents lblValorLlevacontabilidad As System.Windows.Forms.Label
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents cmbTipoPagoOrdenCompra As System.Windows.Forms.ComboBox
        Friend WithEvents cmbFormaPagoOrdenCompra As System.Windows.Forms.ComboBox
        Friend WithEvents txtSon As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacionesOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents idItem As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nombreProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents unidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cantidadProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents valorUnitarioProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents valorTotalProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents chkReq As System.Windows.Forms.CheckBox
        Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewCheckBoxColumn
        Friend WithEvents Column2 As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents dgvRequisicionProductoServicioNew As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents Column6 As DataGridViewCheckBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents Column9 As DataGridViewTextBoxColumn
        Friend WithEvents Column10 As DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
    End Class
End Namespace