Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMantenimientoProveedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoProveedores))
            Me.lblIdProveedor = New System.Windows.Forms.Label()
            Me.txtIdProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtFechaProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblFechaProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRazonSocial = New System.Windows.Forms.TextBox()
            Me.lblRazonSocialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblNombreComercialProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblTipoProveedor = New System.Windows.Forms.Label()
            Me.cmbTipoProveedorGeneral = New System.Windows.Forms.ComboBox()
            Me.cmbContabilidadProveedorGeneral = New System.Windows.Forms.ComboBox()
            Me.lblContabilidadProveedorGeneral = New System.Windows.Forms.Label()
            Me.cmbContribuyenteEspecial = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblDireccionProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtTelefono1ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblTelefono1ProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtTelefono2ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblTelefono2ProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblEmailProveedorGeneral = New System.Windows.Forms.Label()
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.cbxTipo = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbxCiruc = New System.Windows.Forms.ComboBox()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.txtNombreCiudad = New System.Windows.Forms.TextBox()
            Me.lblNombreCiudad = New System.Windows.Forms.Label()
            Me.dgvProveedoresGeneral = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
            Me.pCentroCosto = New System.Windows.Forms.Panel()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbProveedor.SuspendLayout()
            CType(Me.dgvProveedoresGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.pCentroCosto.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdProveedor
            '
            Me.lblIdProveedor.AutoSize = True
            Me.lblIdProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedor.Location = New System.Drawing.Point(8, 21)
            Me.lblIdProveedor.Name = "lblIdProveedor"
            Me.lblIdProveedor.Size = New System.Drawing.Size(86, 13)
            Me.lblIdProveedor.TabIndex = 0
            Me.lblIdProveedor.Text = "ID PROVEEDOR:"
            '
            'txtIdProveedorGeneral
            '
            Me.txtIdProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtIdProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdProveedorGeneral.Location = New System.Drawing.Point(136, 18)
            Me.txtIdProveedorGeneral.Name = "txtIdProveedorGeneral"
            Me.txtIdProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtIdProveedorGeneral.TabIndex = 1
            '
            'txtFechaProveedorGeneral
            '
            Me.txtFechaProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtFechaProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaProveedorGeneral.Location = New System.Drawing.Point(304, 18)
            Me.txtFechaProveedorGeneral.Name = "txtFechaProveedorGeneral"
            Me.txtFechaProveedorGeneral.Size = New System.Drawing.Size(143, 21)
            Me.txtFechaProveedorGeneral.TabIndex = 3
            '
            'lblFechaProveedorGeneral
            '
            Me.lblFechaProveedorGeneral.AutoSize = True
            Me.lblFechaProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaProveedorGeneral.Location = New System.Drawing.Point(262, 21)
            Me.lblFechaProveedorGeneral.Name = "lblFechaProveedorGeneral"
            Me.lblFechaProveedorGeneral.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaProveedorGeneral.TabIndex = 2
            Me.lblFechaProveedorGeneral.Text = "FECHA:"
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(600, 18)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(124, 21)
            Me.txtRucCiProveedorGeneral.TabIndex = 5
            '
            'txtRazonSocial
            '
            Me.txtRazonSocial.BackColor = System.Drawing.Color.White
            Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonSocial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocial.Location = New System.Drawing.Point(136, 44)
            Me.txtRazonSocial.Name = "txtRazonSocial"
            Me.txtRazonSocial.Size = New System.Drawing.Size(588, 21)
            Me.txtRazonSocial.TabIndex = 7
            '
            'lblRazonSocialProveedorGeneral
            '
            Me.lblRazonSocialProveedorGeneral.AutoSize = True
            Me.lblRazonSocialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazonSocialProveedorGeneral.Location = New System.Drawing.Point(8, 47)
            Me.lblRazonSocialProveedorGeneral.Name = "lblRazonSocialProveedorGeneral"
            Me.lblRazonSocialProveedorGeneral.Size = New System.Drawing.Size(88, 13)
            Me.lblRazonSocialProveedorGeneral.TabIndex = 6
            Me.lblRazonSocialProveedorGeneral.Text = "RAZON SOCIAL:"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(136, 70)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(588, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 9
            '
            'lblNombreComercialProveedorGeneral
            '
            Me.lblNombreComercialProveedorGeneral.AutoSize = True
            Me.lblNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialProveedorGeneral.Location = New System.Drawing.Point(8, 73)
            Me.lblNombreComercialProveedorGeneral.Name = "lblNombreComercialProveedorGeneral"
            Me.lblNombreComercialProveedorGeneral.Size = New System.Drawing.Size(120, 13)
            Me.lblNombreComercialProveedorGeneral.TabIndex = 8
            Me.lblNombreComercialProveedorGeneral.Text = "NOMBRE COMERCIAL:"
            '
            'lblTipoProveedor
            '
            Me.lblTipoProveedor.AutoSize = True
            Me.lblTipoProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoProveedor.Location = New System.Drawing.Point(7, 99)
            Me.lblTipoProveedor.Name = "lblTipoProveedor"
            Me.lblTipoProveedor.Size = New System.Drawing.Size(101, 13)
            Me.lblTipoProveedor.TabIndex = 10
            Me.lblTipoProveedor.Text = "TIPO PROVEEDOR:"
            '
            'cmbTipoProveedorGeneral
            '
            Me.cmbTipoProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.cmbTipoProveedorGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoProveedorGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoProveedorGeneral.FormattingEnabled = True
            Me.cmbTipoProveedorGeneral.Items.AddRange(New Object() {"PRODUCTOS", "SERVICIOS"})
            Me.cmbTipoProveedorGeneral.Location = New System.Drawing.Point(135, 96)
            Me.cmbTipoProveedorGeneral.Name = "cmbTipoProveedorGeneral"
            Me.cmbTipoProveedorGeneral.Size = New System.Drawing.Size(121, 21)
            Me.cmbTipoProveedorGeneral.TabIndex = 11
            '
            'cmbContabilidadProveedorGeneral
            '
            Me.cmbContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.cmbContabilidadProveedorGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContabilidadProveedorGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContabilidadProveedorGeneral.FormattingEnabled = True
            Me.cmbContabilidadProveedorGeneral.Items.AddRange(New Object() {"SI", "NO"})
            Me.cmbContabilidadProveedorGeneral.Location = New System.Drawing.Point(393, 96)
            Me.cmbContabilidadProveedorGeneral.Name = "cmbContabilidadProveedorGeneral"
            Me.cmbContabilidadProveedorGeneral.Size = New System.Drawing.Size(70, 21)
            Me.cmbContabilidadProveedorGeneral.TabIndex = 13
            '
            'lblContabilidadProveedorGeneral
            '
            Me.lblContabilidadProveedorGeneral.AutoSize = True
            Me.lblContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContabilidadProveedorGeneral.Location = New System.Drawing.Point(262, 99)
            Me.lblContabilidadProveedorGeneral.Name = "lblContabilidadProveedorGeneral"
            Me.lblContabilidadProveedorGeneral.Size = New System.Drawing.Size(122, 13)
            Me.lblContabilidadProveedorGeneral.TabIndex = 12
            Me.lblContabilidadProveedorGeneral.Text = "LLEVA CONTABILIDAD:"
            '
            'cmbContribuyenteEspecial
            '
            Me.cmbContribuyenteEspecial.BackColor = System.Drawing.Color.White
            Me.cmbContribuyenteEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyenteEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbContribuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContribuyenteEspecial.FormattingEnabled = True
            Me.cmbContribuyenteEspecial.Items.AddRange(New Object() {"SI", "NO"})
            Me.cmbContribuyenteEspecial.Location = New System.Drawing.Point(624, 96)
            Me.cmbContribuyenteEspecial.Name = "cmbContribuyenteEspecial"
            Me.cmbContribuyenteEspecial.Size = New System.Drawing.Size(100, 21)
            Me.cmbContribuyenteEspecial.TabIndex = 15
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(469, 99)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(150, 13)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "CONTRIBUYENTE ESPECIAL:"
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(135, 123)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(589, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 17
            '
            'lblDireccionProveedorGeneral
            '
            Me.lblDireccionProveedorGeneral.AutoSize = True
            Me.lblDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccionProveedorGeneral.Location = New System.Drawing.Point(7, 126)
            Me.lblDireccionProveedorGeneral.Name = "lblDireccionProveedorGeneral"
            Me.lblDireccionProveedorGeneral.Size = New System.Drawing.Size(66, 13)
            Me.lblDireccionProveedorGeneral.TabIndex = 16
            Me.lblDireccionProveedorGeneral.Text = "DIRECCION:"
            '
            'txtTelefono1ProveedorGeneral
            '
            Me.txtTelefono1ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono1ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1ProveedorGeneral.Location = New System.Drawing.Point(436, 149)
            Me.txtTelefono1ProveedorGeneral.Name = "txtTelefono1ProveedorGeneral"
            Me.txtTelefono1ProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtTelefono1ProveedorGeneral.TabIndex = 19
            '
            'lblTelefono1ProveedorGeneral
            '
            Me.lblTelefono1ProveedorGeneral.AutoSize = True
            Me.lblTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono1ProveedorGeneral.Location = New System.Drawing.Point(354, 152)
            Me.lblTelefono1ProveedorGeneral.Name = "lblTelefono1ProveedorGeneral"
            Me.lblTelefono1ProveedorGeneral.Size = New System.Drawing.Size(74, 13)
            Me.lblTelefono1ProveedorGeneral.TabIndex = 18
            Me.lblTelefono1ProveedorGeneral.Text = "TELEFONO 1:"
            '
            'txtTelefono2ProveedorGeneral
            '
            Me.txtTelefono2ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono2ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono2ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono2ProveedorGeneral.Location = New System.Drawing.Point(624, 149)
            Me.txtTelefono2ProveedorGeneral.Name = "txtTelefono2ProveedorGeneral"
            Me.txtTelefono2ProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtTelefono2ProveedorGeneral.TabIndex = 21
            '
            'lblTelefono2ProveedorGeneral
            '
            Me.lblTelefono2ProveedorGeneral.AutoSize = True
            Me.lblTelefono2ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono2ProveedorGeneral.Location = New System.Drawing.Point(542, 152)
            Me.lblTelefono2ProveedorGeneral.Name = "lblTelefono2ProveedorGeneral"
            Me.lblTelefono2ProveedorGeneral.Size = New System.Drawing.Size(74, 13)
            Me.lblTelefono2ProveedorGeneral.TabIndex = 20
            Me.lblTelefono2ProveedorGeneral.Text = "TELEFONO 2:"
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(135, 175)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(401, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 23
            '
            'lblEmailProveedorGeneral
            '
            Me.lblEmailProveedorGeneral.AutoSize = True
            Me.lblEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEmailProveedorGeneral.Location = New System.Drawing.Point(8, 178)
            Me.lblEmailProveedorGeneral.Name = "lblEmailProveedorGeneral"
            Me.lblEmailProveedorGeneral.Size = New System.Drawing.Size(45, 13)
            Me.lblEmailProveedorGeneral.TabIndex = 22
            Me.lblEmailProveedorGeneral.Text = "E-MAIL:"
            '
            'gbProveedor
            '
            Me.gbProveedor.BackColor = System.Drawing.Color.White
            Me.gbProveedor.Controls.Add(Me.cbxTipo)
            Me.gbProveedor.Controls.Add(Me.Label2)
            Me.gbProveedor.Controls.Add(Me.cbxCiruc)
            Me.gbProveedor.Controls.Add(Me.lblIdCiudad)
            Me.gbProveedor.Controls.Add(Me.txtNombreCiudad)
            Me.gbProveedor.Controls.Add(Me.lblNombreCiudad)
            Me.gbProveedor.Controls.Add(Me.lblIdProveedor)
            Me.gbProveedor.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtIdProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblEmailProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtTelefono2ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtFechaProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblTelefono2ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtTelefono1ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblTelefono1ProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRazonSocialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRazonSocial)
            Me.gbProveedor.Controls.Add(Me.lblDireccionProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblNombreComercialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.cmbContribuyenteEspecial)
            Me.gbProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.Label1)
            Me.gbProveedor.Controls.Add(Me.lblTipoProveedor)
            Me.gbProveedor.Controls.Add(Me.cmbContabilidadProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.cmbTipoProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblContabilidadProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblFechaProveedorGeneral)
            Me.gbProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedor.Location = New System.Drawing.Point(2, 117)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(731, 205)
            Me.gbProveedor.TabIndex = 24
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Text = "DATOS DEL PROVEEDOR"
            '
            'cbxTipo
            '
            Me.cbxTipo.BackColor = System.Drawing.Color.White
            Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxTipo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipo.FormattingEnabled = True
            Me.cbxTipo.Items.AddRange(New Object() {"PERSONA NATURAL", "SOCIEDAD"})
            Me.cbxTipo.Location = New System.Drawing.Point(624, 175)
            Me.cbxTipo.Name = "cbxTipo"
            Me.cbxTipo.Size = New System.Drawing.Size(100, 21)
            Me.cbxTipo.TabIndex = 29
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(577, 178)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 13)
            Me.Label2.TabIndex = 28
            Me.Label2.Text = "TIPO:"
            '
            'cbxCiruc
            '
            Me.cbxCiruc.BackColor = System.Drawing.Color.White
            Me.cbxCiruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxCiruc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxCiruc.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxCiruc.FormattingEnabled = True
            Me.cbxCiruc.Items.AddRange(New Object() {"CI", "RUC", "PASAPORTE"})
            Me.cbxCiruc.Location = New System.Drawing.Point(491, 18)
            Me.cbxCiruc.Name = "cbxCiruc"
            Me.cbxCiruc.Size = New System.Drawing.Size(103, 21)
            Me.cbxCiruc.TabIndex = 27
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCiudad.Location = New System.Drawing.Point(335, 152)
            Me.lblIdCiudad.Name = "lblIdCiudad"
            Me.lblIdCiudad.Size = New System.Drawing.Size(13, 13)
            Me.lblIdCiudad.TabIndex = 26
            Me.lblIdCiudad.Text = ".."
            '
            'txtNombreCiudad
            '
            Me.txtNombreCiudad.BackColor = System.Drawing.Color.White
            Me.txtNombreCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCiudad.Location = New System.Drawing.Point(135, 149)
            Me.txtNombreCiudad.Name = "txtNombreCiudad"
            Me.txtNombreCiudad.Size = New System.Drawing.Size(194, 21)
            Me.txtNombreCiudad.TabIndex = 25
            '
            'lblNombreCiudad
            '
            Me.lblNombreCiudad.AutoSize = True
            Me.lblNombreCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreCiudad.Location = New System.Drawing.Point(8, 152)
            Me.lblNombreCiudad.Name = "lblNombreCiudad"
            Me.lblNombreCiudad.Size = New System.Drawing.Size(45, 13)
            Me.lblNombreCiudad.TabIndex = 24
            Me.lblNombreCiudad.Text = "CIUDAD"
            '
            'dgvProveedoresGeneral
            '
            Me.dgvProveedoresGeneral.AllowUserToAddRows = False
            Me.dgvProveedoresGeneral.AllowUserToDeleteRows = False
            Me.dgvProveedoresGeneral.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvProveedoresGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedoresGeneral.BackgroundColor = System.Drawing.Color.White
            Me.dgvProveedoresGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvProveedoresGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvProveedoresGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedoresGeneral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvProveedoresGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvProveedoresGeneral.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvProveedoresGeneral.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvProveedoresGeneral.Location = New System.Drawing.Point(3, 16)
            Me.dgvProveedoresGeneral.Name = "dgvProveedoresGeneral"
            Me.dgvProveedoresGeneral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvProveedoresGeneral.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvProveedoresGeneral.RowHeadersVisible = False
            Me.dgvProveedoresGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvProveedoresGeneral.Size = New System.Drawing.Size(725, 292)
            Me.dgvProveedoresGeneral.TabIndex = 27
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtBuscarProveedor)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 77)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(731, 39)
            Me.GroupBox1.TabIndex = 38
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSCAR PROVEEDOR"
            '
            'txtBuscarProveedor
            '
            Me.txtBuscarProveedor.BackColor = System.Drawing.Color.White
            Me.txtBuscarProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarProveedor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarProveedor.Location = New System.Drawing.Point(6, 13)
            Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
            Me.txtBuscarProveedor.Size = New System.Drawing.Size(717, 22)
            Me.txtBuscarProveedor.TabIndex = 0
            '
            'pCentroCosto
            '
            Me.pCentroCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.pCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pCentroCosto.Controls.Add(Me.lblCentroCosto)
            Me.pCentroCosto.Location = New System.Drawing.Point(2, 34)
            Me.pCentroCosto.Name = "pCentroCosto"
            Me.pCentroCosto.Size = New System.Drawing.Size(731, 41)
            Me.pCentroCosto.TabIndex = 39
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblCentroCosto.Enabled = False
            Me.lblCentroCosto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.lblCentroCosto.Location = New System.Drawing.Point(6, 9)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(709, 26)
            Me.lblCentroCosto.TabIndex = 28
            Me.lblCentroCosto.Text = "NOTA: Por favor no ingrese caracteres especiales (Ññ ´ & $%) en los datos del pro" &
    "veedor para evitar problemas con los " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "comprobantes electrónicos"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvProveedoresGeneral)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(2, 308)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(731, 311)
            Me.GroupBox2.TabIndex = 40
            Me.GroupBox2.TabStop = False
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoProveedorGeneral, Me.btnGuardarProveedorGeneral, Me.btnModificarProveedorGeneral, Me.btnCancelarProveedorGeneral, Me.btnExportar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(734, 32)
            Me.msKardex.TabIndex = 186
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnNuevoProveedorGeneral
            '
            Me.btnNuevoProveedorGeneral.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoProveedorGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoProveedorGeneral.Name = "btnNuevoProveedorGeneral"
            Me.btnNuevoProveedorGeneral.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoProveedorGeneral.Text = "NUEVO"
            '
            'btnGuardarProveedorGeneral
            '
            Me.btnGuardarProveedorGeneral.Enabled = False
            Me.btnGuardarProveedorGeneral.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarProveedorGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarProveedorGeneral.Name = "btnGuardarProveedorGeneral"
            Me.btnGuardarProveedorGeneral.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarProveedorGeneral.Text = "GUARDAR"
            '
            'btnModificarProveedorGeneral
            '
            Me.btnModificarProveedorGeneral.Enabled = False
            Me.btnModificarProveedorGeneral.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarProveedorGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarProveedorGeneral.Name = "btnModificarProveedorGeneral"
            Me.btnModificarProveedorGeneral.Size = New System.Drawing.Size(106, 28)
            Me.btnModificarProveedorGeneral.Text = "MODIFICAR"
            '
            'btnCancelarProveedorGeneral
            '
            Me.btnCancelarProveedorGeneral.Enabled = False
            Me.btnCancelarProveedorGeneral.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarProveedorGeneral.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarProveedorGeneral.Name = "btnCancelarProveedorGeneral"
            Me.btnCancelarProveedorGeneral.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelarProveedorGeneral.Text = "CANCELAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(92, 28)
            Me.btnExportar.Text = "REPORTE"
            '
            'FormMantenimientoProveedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(734, 622)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.pCentroCosto)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbProveedor)
            Me.Controls.Add(Me.GroupBox2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMantenimientoProveedores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMINETO DE PROVEEDORES"
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            CType(Me.dgvProveedoresGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pCentroCosto.ResumeLayout(False)
            Me.pCentroCosto.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
        Friend WithEvents txtIdProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
        Friend WithEvents lblRazonSocialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreComercialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblTipoProveedor As System.Windows.Forms.Label
        Friend WithEvents cmbTipoProveedorGeneral As System.Windows.Forms.ComboBox
        Friend WithEvents cmbContabilidadProveedorGeneral As System.Windows.Forms.ComboBox
        Friend WithEvents lblContabilidadProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents cmbContribuyenteEspecial As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccionProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtTelefono1ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono1ProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtTelefono2ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono2ProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblEmailProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents dgvProveedoresGeneral As System.Windows.Forms.DataGridView
        Friend WithEvents txtNombreCiudad As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreCiudad As System.Windows.Forms.Label
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtBuscarProveedor As System.Windows.Forms.TextBox
        Friend WithEvents pCentroCosto As System.Windows.Forms.Panel
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbxCiruc As System.Windows.Forms.ComboBox
        Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace