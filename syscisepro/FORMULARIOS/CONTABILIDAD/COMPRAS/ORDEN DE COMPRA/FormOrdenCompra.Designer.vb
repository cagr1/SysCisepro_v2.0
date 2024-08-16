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
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrdenCompra))
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblRucCiProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtTelefono1ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblTelefono1ProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblDireccionProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblNombreComercialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtLlevaContabilidadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblContabilidadProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.txtNombreCiudad = New System.Windows.Forms.TextBox()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblEmailProveedorGeneral = New System.Windows.Forms.Label()
            Me.gbOrdenCompraCabecera = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.lblValorContribuyenteEspecial = New System.Windows.Forms.Label()
            Me.lblValorLlevacontabilidad = New System.Windows.Forms.Label()
            Me.txtFechaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblFechaOrdenCompra = New System.Windows.Forms.Label()
            Me.txtIdOrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblIdOrdenCompra = New System.Windows.Forms.Label()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorUnitarioProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.valorTotalProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.gbObservaciones = New System.Windows.Forms.GroupBox()
            Me.txtObservacionesOrdenCompra = New System.Windows.Forms.TextBox()
            Me.gbTipoPago = New System.Windows.Forms.GroupBox()
            Me.cmbTipoPagoOrdenCompra = New System.Windows.Forms.ComboBox()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.cmbFormaPagoOrdenCompra = New System.Windows.Forms.ComboBox()
            Me.txtSon = New System.Windows.Forms.TextBox()
            Me.gbOrdenCompraValores = New System.Windows.Forms.GroupBox()
            Me.txtTotalOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtDescuentoOrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0OrdenCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12OrdenCompra = New System.Windows.Forms.TextBox()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.lblIvaOrdenCompra = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal12OrdenCompra = New System.Windows.Forms.Label()
            Me.gbDatos = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgvDetalleRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dgvRequisicionProductoServicioNew = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbProveedor.SuspendLayout()
            Me.gbOrdenCompraCabecera.SuspendLayout()
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelDetalle.SuspendLayout()
            Me.gbObservaciones.SuspendLayout()
            Me.gbTipoPago.SuspendLayout()
            Me.gbFormaPago.SuspendLayout()
            Me.gbOrdenCompraValores.SuspendLayout()
            Me.gbDatos.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRequisicionProductoServicioNew, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbProveedor
            '
            Me.gbProveedor.BackColor = System.Drawing.Color.White
            Me.gbProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtTelefono1ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblTelefono1ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblDireccionProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblNombreComercialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedor.Location = New System.Drawing.Point(2, 79)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(458, 70)
            Me.gbProveedor.TabIndex = 0
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Text = "PROVEEDOR"
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(425, 0)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 42
            Me.lblIdProveedorGeneral.Text = "..."
            Me.lblIdProveedorGeneral.Visible = False
            '
            'lblRucCiProveedorGeneral
            '
            Me.lblRucCiProveedorGeneral.AutoSize = True
            Me.lblRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucCiProveedorGeneral.Location = New System.Drawing.Point(288, 20)
            Me.lblRucCiProveedorGeneral.Name = "lblRucCiProveedorGeneral"
            Me.lblRucCiProveedorGeneral.Size = New System.Drawing.Size(52, 13)
            Me.lblRucCiProveedorGeneral.TabIndex = 24
            Me.lblRucCiProveedorGeneral.Text = "RUC / CI:"
            '
            'txtTelefono1ProveedorGeneral
            '
            Me.txtTelefono1ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono1ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1ProveedorGeneral.Location = New System.Drawing.Point(349, 43)
            Me.txtTelefono1ProveedorGeneral.Name = "txtTelefono1ProveedorGeneral"
            Me.txtTelefono1ProveedorGeneral.Size = New System.Drawing.Size(97, 21)
            Me.txtTelefono1ProveedorGeneral.TabIndex = 31
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(349, 17)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(97, 21)
            Me.txtRucCiProveedorGeneral.TabIndex = 25
            '
            'lblTelefono1ProveedorGeneral
            '
            Me.lblTelefono1ProveedorGeneral.AutoSize = True
            Me.lblTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono1ProveedorGeneral.Location = New System.Drawing.Point(289, 46)
            Me.lblTelefono1ProveedorGeneral.Name = "lblTelefono1ProveedorGeneral"
            Me.lblTelefono1ProveedorGeneral.Size = New System.Drawing.Size(65, 13)
            Me.lblTelefono1ProveedorGeneral.TabIndex = 30
            Me.lblTelefono1ProveedorGeneral.Text = "TELEFONO:"
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(52, 43)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(234, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 29
            '
            'lblDireccionProveedorGeneral
            '
            Me.lblDireccionProveedorGeneral.AutoSize = True
            Me.lblDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccionProveedorGeneral.Location = New System.Drawing.Point(3, 46)
            Me.lblDireccionProveedorGeneral.Name = "lblDireccionProveedorGeneral"
            Me.lblDireccionProveedorGeneral.Size = New System.Drawing.Size(43, 13)
            Me.lblDireccionProveedorGeneral.TabIndex = 28
            Me.lblDireccionProveedorGeneral.Text = "DIREC.:"
            '
            'lblNombreComercialProveedorGeneral
            '
            Me.lblNombreComercialProveedorGeneral.AutoSize = True
            Me.lblNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialProveedorGeneral.Location = New System.Drawing.Point(3, 20)
            Me.lblNombreComercialProveedorGeneral.Name = "lblNombreComercialProveedorGeneral"
            Me.lblNombreComercialProveedorGeneral.Size = New System.Drawing.Size(45, 13)
            Me.lblNombreComercialProveedorGeneral.TabIndex = 26
            Me.lblNombreComercialProveedorGeneral.Text = "SR(ES):"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(52, 17)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(234, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 0
            '
            'txtContribuyenteEspecialProveedorGeneral
            '
            Me.txtContribuyenteEspecialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(117, 17)
            Me.txtContribuyenteEspecialProveedorGeneral.Name = "txtContribuyenteEspecialProveedorGeneral"
            Me.txtContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(32, 21)
            Me.txtContribuyenteEspecialProveedorGeneral.TabIndex = 40
            '
            'txtLlevaContabilidadProveedorGeneral
            '
            Me.txtLlevaContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtLlevaContabilidadProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLlevaContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLlevaContabilidadProveedorGeneral.Location = New System.Drawing.Point(256, 17)
            Me.txtLlevaContabilidadProveedorGeneral.Name = "txtLlevaContabilidadProveedorGeneral"
            Me.txtLlevaContabilidadProveedorGeneral.Size = New System.Drawing.Size(32, 21)
            Me.txtLlevaContabilidadProveedorGeneral.TabIndex = 39
            '
            'lblContribuyenteEspecialProveedorGeneral
            '
            Me.lblContribuyenteEspecialProveedorGeneral.AutoSize = True
            Me.lblContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(2, 20)
            Me.lblContribuyenteEspecialProveedorGeneral.Name = "lblContribuyenteEspecialProveedorGeneral"
            Me.lblContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(112, 13)
            Me.lblContribuyenteEspecialProveedorGeneral.TabIndex = 38
            Me.lblContribuyenteEspecialProveedorGeneral.Text = "CONTRIB. ESPECIAL:"
            '
            'lblContabilidadProveedorGeneral
            '
            Me.lblContabilidadProveedorGeneral.AutoSize = True
            Me.lblContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContabilidadProveedorGeneral.Location = New System.Drawing.Point(165, 20)
            Me.lblContabilidadProveedorGeneral.Name = "lblContabilidadProveedorGeneral"
            Me.lblContabilidadProveedorGeneral.Size = New System.Drawing.Size(89, 13)
            Me.lblContabilidadProveedorGeneral.TabIndex = 36
            Me.lblContabilidadProveedorGeneral.Text = "LLEVA CONTAB:"
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudad.Location = New System.Drawing.Point(2, 46)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(49, 13)
            Me.lblCiudad.TabIndex = 34
            Me.lblCiudad.Text = "CIUDAD:"
            '
            'txtNombreCiudad
            '
            Me.txtNombreCiudad.BackColor = System.Drawing.Color.White
            Me.txtNombreCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCiudad.Location = New System.Drawing.Point(51, 42)
            Me.txtNombreCiudad.Name = "txtNombreCiudad"
            Me.txtNombreCiudad.Size = New System.Drawing.Size(98, 21)
            Me.txtNombreCiudad.TabIndex = 35
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(198, 43)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(90, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 33
            '
            'lblEmailProveedorGeneral
            '
            Me.lblEmailProveedorGeneral.AutoSize = True
            Me.lblEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmailProveedorGeneral.Location = New System.Drawing.Point(152, 46)
            Me.lblEmailProveedorGeneral.Name = "lblEmailProveedorGeneral"
            Me.lblEmailProveedorGeneral.Size = New System.Drawing.Size(45, 13)
            Me.lblEmailProveedorGeneral.TabIndex = 32
            Me.lblEmailProveedorGeneral.Text = "E-MAIL:"
            '
            'gbOrdenCompraCabecera
            '
            Me.gbOrdenCompraCabecera.BackColor = System.Drawing.Color.White
            Me.gbOrdenCompraCabecera.Controls.Add(Me.Label3)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.lblIdCiudad)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.lblValorContribuyenteEspecial)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.lblValorLlevacontabilidad)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.txtFechaOrdenCompra)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.lblFechaOrdenCompra)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.txtIdOrdenCompra)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.lblIdOrdenCompra)
            Me.gbOrdenCompraCabecera.Controls.Add(Me.chkReq)
            Me.gbOrdenCompraCabecera.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbOrdenCompraCabecera.Location = New System.Drawing.Point(2, 34)
            Me.gbOrdenCompraCabecera.Name = "gbOrdenCompraCabecera"
            Me.gbOrdenCompraCabecera.Size = New System.Drawing.Size(752, 42)
            Me.gbOrdenCompraCabecera.TabIndex = 1
            Me.gbOrdenCompraCabecera.TabStop = False
            Me.gbOrdenCompraCabecera.Text = "ORDEN DE COMPRA"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(617, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(28, 13)
            Me.Label3.TabIndex = 43
            Me.Label3.Text = "###"
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCiudad.Location = New System.Drawing.Point(178, 16)
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
            Me.lblValorContribuyenteEspecial.Location = New System.Drawing.Point(158, 16)
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
            Me.lblValorLlevacontabilidad.Location = New System.Drawing.Point(135, 16)
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
            Me.txtFechaOrdenCompra.Location = New System.Drawing.Point(273, 12)
            Me.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra"
            Me.txtFechaOrdenCompra.Size = New System.Drawing.Size(187, 21)
            Me.txtFechaOrdenCompra.TabIndex = 37
            '
            'lblFechaOrdenCompra
            '
            Me.lblFechaOrdenCompra.AutoSize = True
            Me.lblFechaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaOrdenCompra.Location = New System.Drawing.Point(224, 15)
            Me.lblFechaOrdenCompra.Name = "lblFechaOrdenCompra"
            Me.lblFechaOrdenCompra.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaOrdenCompra.TabIndex = 36
            Me.lblFechaOrdenCompra.Text = "FECHA:"
            '
            'txtIdOrdenCompra
            '
            Me.txtIdOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtIdOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdOrdenCompra.Location = New System.Drawing.Point(53, 13)
            Me.txtIdOrdenCompra.Name = "txtIdOrdenCompra"
            Me.txtIdOrdenCompra.Size = New System.Drawing.Size(68, 21)
            Me.txtIdOrdenCompra.TabIndex = 35
            '
            'lblIdOrdenCompra
            '
            Me.lblIdOrdenCompra.AutoSize = True
            Me.lblIdOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdOrdenCompra.Location = New System.Drawing.Point(3, 16)
            Me.lblIdOrdenCompra.Name = "lblIdOrdenCompra"
            Me.lblIdOrdenCompra.Size = New System.Drawing.Size(43, 13)
            Me.lblIdOrdenCompra.TabIndex = 34
            Me.lblIdOrdenCompra.Text = "N°: OC-"
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.Enabled = False
            Me.chkReq.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReq.Location = New System.Drawing.Point(496, 15)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(106, 17)
            Me.chkReq.TabIndex = 44
            Me.chkReq.Text = "Con requisición:"
            Me.chkReq.UseVisualStyleBackColor = True
            '
            'dgvDetalleOrdenCompra
            '
            Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
            Me.dgvDetalleOrdenCompra.AllowUserToOrderColumns = True
            Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleOrdenCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(2, 187)
            Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
            Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
            Me.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(752, 339)
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
            'panelDetalle
            '
            Me.panelDetalle.BackColor = System.Drawing.Color.White
            Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelDetalle.Controls.Add(Me.btnEliminar)
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(2, 153)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(752, 33)
            Me.panelDetalle.TabIndex = 36
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.White
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(717, 2)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(28, 28)
            Me.btnEliminar.TabIndex = 19
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(267, 7)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(156, 13)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "DETALLE ORDEN DE COMPRA"
            '
            'gbObservaciones
            '
            Me.gbObservaciones.BackColor = System.Drawing.Color.White
            Me.gbObservaciones.Controls.Add(Me.txtObservacionesOrdenCompra)
            Me.gbObservaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbObservaciones.Location = New System.Drawing.Point(2, 615)
            Me.gbObservaciones.Name = "gbObservaciones"
            Me.gbObservaciones.Size = New System.Drawing.Size(521, 47)
            Me.gbObservaciones.TabIndex = 37
            Me.gbObservaciones.TabStop = False
            Me.gbObservaciones.Text = "OBSERVACIONES:"
            '
            'txtObservacionesOrdenCompra
            '
            Me.txtObservacionesOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesOrdenCompra.Location = New System.Drawing.Point(10, 19)
            Me.txtObservacionesOrdenCompra.Name = "txtObservacionesOrdenCompra"
            Me.txtObservacionesOrdenCompra.Size = New System.Drawing.Size(499, 21)
            Me.txtObservacionesOrdenCompra.TabIndex = 5
            '
            'gbTipoPago
            '
            Me.gbTipoPago.BackColor = System.Drawing.Color.White
            Me.gbTipoPago.Controls.Add(Me.cmbTipoPagoOrdenCompra)
            Me.gbTipoPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoPago.Location = New System.Drawing.Point(263, 572)
            Me.gbTipoPago.Name = "gbTipoPago"
            Me.gbTipoPago.Size = New System.Drawing.Size(260, 44)
            Me.gbTipoPago.TabIndex = 3
            Me.gbTipoPago.TabStop = False
            Me.gbTipoPago.Text = "TIPO PAGO:"
            '
            'cmbTipoPagoOrdenCompra
            '
            Me.cmbTipoPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.cmbTipoPagoOrdenCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoPagoOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoPagoOrdenCompra.FormattingEnabled = True
            Me.cmbTipoPagoOrdenCompra.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "NOTA DE CRÉDITO"})
            Me.cmbTipoPagoOrdenCompra.Location = New System.Drawing.Point(10, 15)
            Me.cmbTipoPagoOrdenCompra.Name = "cmbTipoPagoOrdenCompra"
            Me.cmbTipoPagoOrdenCompra.Size = New System.Drawing.Size(238, 21)
            Me.cmbTipoPagoOrdenCompra.TabIndex = 2
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.White
            Me.gbFormaPago.Controls.Add(Me.cmbFormaPagoOrdenCompra)
            Me.gbFormaPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.Location = New System.Drawing.Point(2, 571)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(261, 44)
            Me.gbFormaPago.TabIndex = 2
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "FORMA PAGO:"
            '
            'cmbFormaPagoOrdenCompra
            '
            Me.cmbFormaPagoOrdenCompra.BackColor = System.Drawing.Color.White
            Me.cmbFormaPagoOrdenCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFormaPagoOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbFormaPagoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFormaPagoOrdenCompra.FormattingEnabled = True
            Me.cmbFormaPagoOrdenCompra.Items.AddRange(New Object() {"CRÉDITO", "CONTADO"})
            Me.cmbFormaPagoOrdenCompra.Location = New System.Drawing.Point(10, 15)
            Me.cmbFormaPagoOrdenCompra.Name = "cmbFormaPagoOrdenCompra"
            Me.cmbFormaPagoOrdenCompra.Size = New System.Drawing.Size(242, 21)
            Me.cmbFormaPagoOrdenCompra.TabIndex = 1
            Me.cmbFormaPagoOrdenCompra.Tag = ""
            '
            'txtSon
            '
            Me.txtSon.BackColor = System.Drawing.Color.White
            Me.txtSon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSon.Location = New System.Drawing.Point(10, 17)
            Me.txtSon.Name = "txtSon"
            Me.txtSon.Size = New System.Drawing.Size(499, 21)
            Me.txtSon.TabIndex = 1
            '
            'gbOrdenCompraValores
            '
            Me.gbOrdenCompraValores.BackColor = System.Drawing.Color.White
            Me.gbOrdenCompraValores.Controls.Add(Me.txtTotalOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.txtIvaOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.txtDescuentoOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.txtSubtotal0OrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.txtSubtotal12OrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.lblIvaOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbOrdenCompraValores.Controls.Add(Me.lblSubtotal12OrdenCompra)
            Me.gbOrdenCompraValores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbOrdenCompraValores.Location = New System.Drawing.Point(523, 526)
            Me.gbOrdenCompraValores.Name = "gbOrdenCompraValores"
            Me.gbOrdenCompraValores.Size = New System.Drawing.Size(231, 136)
            Me.gbOrdenCompraValores.TabIndex = 38
            Me.gbOrdenCompraValores.TabStop = False
            '
            'txtTotalOrdenCompra
            '
            Me.txtTotalOrdenCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalOrdenCompra.Location = New System.Drawing.Point(118, 102)
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
            Me.txtIvaOrdenCompra.Location = New System.Drawing.Point(118, 79)
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
            Me.txtDescuentoOrdenCompra.Location = New System.Drawing.Point(118, 56)
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
            Me.txtSubtotal0OrdenCompra.Location = New System.Drawing.Point(118, 33)
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
            Me.txtSubtotal12OrdenCompra.Location = New System.Drawing.Point(118, 10)
            Me.txtSubtotal12OrdenCompra.Name = "txtSubtotal12OrdenCompra"
            Me.txtSubtotal12OrdenCompra.Size = New System.Drawing.Size(93, 21)
            Me.txtSubtotal12OrdenCompra.TabIndex = 5
            Me.txtSubtotal12OrdenCompra.Text = "0.00"
            Me.txtSubtotal12OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(30, 105)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalOrdenCompra.TabIndex = 4
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'lblIvaOrdenCompra
            '
            Me.lblIvaOrdenCompra.AutoSize = True
            Me.lblIvaOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIvaOrdenCompra.Location = New System.Drawing.Point(30, 82)
            Me.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra"
            Me.lblIvaOrdenCompra.Size = New System.Drawing.Size(58, 13)
            Me.lblIvaOrdenCompra.TabIndex = 3
            Me.lblIvaOrdenCompra.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(30, 59)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(73, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 2
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(30, 36)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(75, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 1
            Me.lblSubtotal0OrdenCompra.Text = "SUBTOTAL 0:"
            '
            'lblSubtotal12OrdenCompra
            '
            Me.lblSubtotal12OrdenCompra.AutoSize = True
            Me.lblSubtotal12OrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal12OrdenCompra.Location = New System.Drawing.Point(30, 13)
            Me.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra"
            Me.lblSubtotal12OrdenCompra.Size = New System.Drawing.Size(81, 13)
            Me.lblSubtotal12OrdenCompra.TabIndex = 0
            Me.lblSubtotal12OrdenCompra.Text = "SUBTOTAL 12:"
            '
            'gbDatos
            '
            Me.gbDatos.BackColor = System.Drawing.Color.White
            Me.gbDatos.Controls.Add(Me.lblContribuyenteEspecialProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.txtContribuyenteEspecialProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.lblContabilidadProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.lblEmailProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.lblCiudad)
            Me.gbDatos.Controls.Add(Me.txtLlevaContabilidadProveedorGeneral)
            Me.gbDatos.Controls.Add(Me.txtNombreCiudad)
            Me.gbDatos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatos.Location = New System.Drawing.Point(460, 79)
            Me.gbDatos.Name = "gbDatos"
            Me.gbDatos.Size = New System.Drawing.Size(294, 70)
            Me.gbDatos.TabIndex = 44
            Me.gbDatos.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtSon)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 526)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(521, 45)
            Me.GroupBox1.TabIndex = 45
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "SON:"
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
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvRequisicionProductoServicioNew)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.dgvRequisicionProductoServicio)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(760, 33)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(314, 228)
            Me.GroupBox2.TabIndex = 188
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "REQUISICIONES DE COMPRA"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(169, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(25, 13)
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
            Me.dgvRequisicionProductoServicio.Location = New System.Drawing.Point(147, 14)
            Me.dgvRequisicionProductoServicio.Name = "dgvRequisicionProductoServicio"
            Me.dgvRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequisicionProductoServicio.Size = New System.Drawing.Size(143, 208)
            Me.dgvRequisicionProductoServicio.TabIndex = 1
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.dgvDetalleRequisicionProductoServicio)
            Me.GroupBox3.Location = New System.Drawing.Point(760, 267)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(314, 396)
            Me.GroupBox3.TabIndex = 189
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DETALLES DE REQUISICIÓN"
            '
            'dgvDetalleRequisicionProductoServicio
            '
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvDetalleRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleRequisicionProductoServicio.Location = New System.Drawing.Point(6, 13)
            Me.dgvDetalleRequisicionProductoServicio.Name = "dgvDetalleRequisicionProductoServicio"
            Me.dgvDetalleRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvDetalleRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionProductoServicio.Size = New System.Drawing.Size(302, 377)
            Me.dgvDetalleRequisicionProductoServicio.TabIndex = 3
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
            'dgvRequisicionProductoServicioNew
            '
            Me.dgvRequisicionProductoServicioNew.AllowUserToAddRows = False
            Me.dgvRequisicionProductoServicioNew.AllowUserToDeleteRows = False
            Me.dgvRequisicionProductoServicioNew.AllowUserToOrderColumns = True
            Me.dgvRequisicionProductoServicioNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRequisicionProductoServicioNew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
            Me.dgvRequisicionProductoServicioNew.Location = New System.Drawing.Point(6, 13)
            Me.dgvRequisicionProductoServicioNew.Name = "dgvRequisicionProductoServicioNew"
            Me.dgvRequisicionProductoServicioNew.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicioNew.Size = New System.Drawing.Size(296, 209)
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
            'FormOrdenCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1074, 664)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDatos)
            Me.Controls.Add(Me.gbFormaPago)
            Me.Controls.Add(Me.gbTipoPago)
            Me.Controls.Add(Me.dgvDetalleOrdenCompra)
            Me.Controls.Add(Me.gbOrdenCompraValores)
            Me.Controls.Add(Me.gbObservaciones)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.gbOrdenCompraCabecera)
            Me.Controls.Add(Me.gbProveedor)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormOrdenCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ORDEN DE COMPRA"
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            Me.gbOrdenCompraCabecera.ResumeLayout(False)
            Me.gbOrdenCompraCabecera.PerformLayout()
            CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            Me.gbObservaciones.ResumeLayout(False)
            Me.gbObservaciones.PerformLayout()
            Me.gbTipoPago.ResumeLayout(False)
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbOrdenCompraValores.ResumeLayout(False)
            Me.gbOrdenCompraValores.PerformLayout()
            Me.gbDatos.ResumeLayout(False)
            Me.gbDatos.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRequisicionProductoServicioNew, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblEmailProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblRucCiProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtTelefono1ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono1ProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccionProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblNombreComercialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents txtNombreCiudad As System.Windows.Forms.TextBox
        Friend WithEvents gbOrdenCompraCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtIdOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIdOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
        Friend WithEvents txtContribuyenteEspecialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtLlevaContabilidadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblContribuyenteEspecialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblContabilidadProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblValorContribuyenteEspecial As System.Windows.Forms.Label
        Friend WithEvents lblValorLlevacontabilidad As System.Windows.Forms.Label
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents gbObservaciones As System.Windows.Forms.GroupBox
        Friend WithEvents gbTipoPago As System.Windows.Forms.GroupBox
        Friend WithEvents cmbTipoPagoOrdenCompra As System.Windows.Forms.ComboBox
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents cmbFormaPagoOrdenCompra As System.Windows.Forms.ComboBox
        Friend WithEvents txtSon As System.Windows.Forms.TextBox
        Friend WithEvents gbOrdenCompraValores As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtIvaOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal0OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtSubtotal12OrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblIvaOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal12OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents txtObservacionesOrdenCompra As System.Windows.Forms.TextBox
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    End Class
End Namespace