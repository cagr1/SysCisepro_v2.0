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
            Me.txtIdProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtFechaProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRazonSocial = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.cmbTipoProveedorGeneral = New System.Windows.Forms.ComboBox()
            Me.cmbContabilidadProveedorGeneral = New System.Windows.Forms.ComboBox()
            Me.cmbContribuyenteEspecial = New System.Windows.Forms.ComboBox()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtTelefono1ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtTelefono2ProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.cbxTipo = New System.Windows.Forms.ComboBox()
            Me.cbxCiruc = New System.Windows.Forms.ComboBox()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.txtNombreCiudad = New System.Windows.Forms.TextBox()
            Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
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
            Me.dgvProveedoresGeneral = New System.Windows.Forms.DataGridView()
            Me.msKardex.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.dgvProveedoresGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtIdProveedorGeneral
            '
            Me.txtIdProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtIdProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdProveedorGeneral.Location = New System.Drawing.Point(51, 3)
            Me.txtIdProveedorGeneral.Name = "txtIdProveedorGeneral"
            Me.txtIdProveedorGeneral.Size = New System.Drawing.Size(77, 21)
            Me.txtIdProveedorGeneral.TabIndex = 1
            '
            'txtFechaProveedorGeneral
            '
            Me.txtFechaProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtFechaProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaProveedorGeneral.Location = New System.Drawing.Point(198, 3)
            Me.txtFechaProveedorGeneral.Name = "txtFechaProveedorGeneral"
            Me.txtFechaProveedorGeneral.Size = New System.Drawing.Size(109, 21)
            Me.txtFechaProveedorGeneral.TabIndex = 3
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(489, 1)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(94, 21)
            Me.txtRucCiProveedorGeneral.TabIndex = 5
            '
            'txtRazonSocial
            '
            Me.txtRazonSocial.BackColor = System.Drawing.Color.White
            Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonSocial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocial.Location = New System.Drawing.Point(122, 29)
            Me.txtRazonSocial.Name = "txtRazonSocial"
            Me.txtRazonSocial.Size = New System.Drawing.Size(308, 21)
            Me.txtRazonSocial.TabIndex = 7
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(122, 56)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(308, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 9
            '
            'cmbTipoProveedorGeneral
            '
            Me.cmbTipoProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.cmbTipoProveedorGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoProveedorGeneral.FormattingEnabled = True
            Me.cmbTipoProveedorGeneral.Items.AddRange(New Object() {"PRODUCTOS", "SERVICIOS"})
            Me.cmbTipoProveedorGeneral.Location = New System.Drawing.Point(122, 83)
            Me.cmbTipoProveedorGeneral.Name = "cmbTipoProveedorGeneral"
            Me.cmbTipoProveedorGeneral.Size = New System.Drawing.Size(103, 21)
            Me.cmbTipoProveedorGeneral.TabIndex = 11
            '
            'cmbContabilidadProveedorGeneral
            '
            Me.cmbContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.cmbContabilidadProveedorGeneral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContabilidadProveedorGeneral.FormattingEnabled = True
            Me.cmbContabilidadProveedorGeneral.Items.AddRange(New Object() {"SI", "NO"})
            Me.cmbContabilidadProveedorGeneral.Location = New System.Drawing.Point(317, 81)
            Me.cmbContabilidadProveedorGeneral.Name = "cmbContabilidadProveedorGeneral"
            Me.cmbContabilidadProveedorGeneral.Size = New System.Drawing.Size(43, 21)
            Me.cmbContabilidadProveedorGeneral.TabIndex = 13
            '
            'cmbContribuyenteEspecial
            '
            Me.cmbContribuyenteEspecial.BackColor = System.Drawing.Color.White
            Me.cmbContribuyenteEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbContribuyenteEspecial.FormattingEnabled = True
            Me.cmbContribuyenteEspecial.Items.AddRange(New Object() {"SI", "NO"})
            Me.cmbContribuyenteEspecial.Location = New System.Drawing.Point(489, 83)
            Me.cmbContribuyenteEspecial.Name = "cmbContribuyenteEspecial"
            Me.cmbContribuyenteEspecial.Size = New System.Drawing.Size(100, 21)
            Me.cmbContribuyenteEspecial.TabIndex = 15
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(122, 108)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(304, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 17
            '
            'txtTelefono1ProveedorGeneral
            '
            Me.txtTelefono1ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono1ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1ProveedorGeneral.Location = New System.Drawing.Point(489, 28)
            Me.txtTelefono1ProveedorGeneral.Name = "txtTelefono1ProveedorGeneral"
            Me.txtTelefono1ProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtTelefono1ProveedorGeneral.TabIndex = 19
            '
            'txtTelefono2ProveedorGeneral
            '
            Me.txtTelefono2ProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono2ProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono2ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono2ProveedorGeneral.Location = New System.Drawing.Point(489, 57)
            Me.txtTelefono2ProveedorGeneral.Name = "txtTelefono2ProveedorGeneral"
            Me.txtTelefono2ProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtTelefono2ProveedorGeneral.TabIndex = 21
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(419, 140)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(170, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 23
            '
            'cbxTipo
            '
            Me.cbxTipo.BackColor = System.Drawing.Color.White
            Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipo.FormattingEnabled = True
            Me.cbxTipo.Items.AddRange(New Object() {"PERSONA NATURAL", "SOCIEDAD"})
            Me.cbxTipo.Location = New System.Drawing.Point(489, 107)
            Me.cbxTipo.Name = "cbxTipo"
            Me.cbxTipo.Size = New System.Drawing.Size(100, 21)
            Me.cbxTipo.TabIndex = 29
            '
            'cbxCiruc
            '
            Me.cbxCiruc.BackColor = System.Drawing.Color.White
            Me.cbxCiruc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxCiruc.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxCiruc.FormattingEnabled = True
            Me.cbxCiruc.Items.AddRange(New Object() {"CI", "RUC", "PASAPORTE"})
            Me.cbxCiruc.Location = New System.Drawing.Point(374, 3)
            Me.cbxCiruc.Name = "cbxCiruc"
            Me.cbxCiruc.Size = New System.Drawing.Size(103, 21)
            Me.cbxCiruc.TabIndex = 27
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdCiudad.Location = New System.Drawing.Point(333, 143)
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
            Me.txtNombreCiudad.Location = New System.Drawing.Point(122, 135)
            Me.txtNombreCiudad.Name = "txtNombreCiudad"
            Me.txtNombreCiudad.Size = New System.Drawing.Size(194, 21)
            Me.txtNombreCiudad.TabIndex = 25
            '
            'txtBuscarProveedor
            '
            Me.txtBuscarProveedor.BackColor = System.Drawing.Color.White
            Me.txtBuscarProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarProveedor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarProveedor.Location = New System.Drawing.Point(65, 85)
            Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
            Me.txtBuscarProveedor.Size = New System.Drawing.Size(528, 22)
            Me.txtBuscarProveedor.TabIndex = 0
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoProveedorGeneral, Me.btnGuardarProveedorGeneral, Me.btnModificarProveedorGeneral, Me.btnCancelarProveedorGeneral, Me.btnExportar})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(609, 32)
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
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(8, 42)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(608, 36)
            Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.KryptonLabel1.TabIndex = 187
            Me.KryptonLabel1.Values.Text = "Por favor no ingrese caracteres especiales (Ññ ´ & $%) en los datos del Proveedor" &
    " para evitar problemas con los" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comprobantes Electronicos"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(10, 85)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel2.TabIndex = 188
            Me.KryptonLabel2.Values.Text = "Buscar"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 113)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbxTipo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbxCiruc)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTelefono2ProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbContribuyenteEspecial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazonSocial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTelefono1ProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbTipoProveedorGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbContabilidadProveedorGeneral)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(601, 133)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(373, 141)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel15.TabIndex = 201
            Me.KryptonLabel15.Values.Text = "Email"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(9, 133)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel14.TabIndex = 200
            Me.KryptonLabel14.Values.Text = "Ciudad"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(443, 108)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel13.TabIndex = 199
            Me.KryptonLabel13.Values.Text = "Tipo"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(9, 107)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel12.TabIndex = 198
            Me.KryptonLabel12.Values.Text = "Direccion"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(373, 82)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(110, 20)
            Me.KryptonLabel11.TabIndex = 197
            Me.KryptonLabel11.Values.Text = "Contribuyente Esp"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(238, 81)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel10.TabIndex = 196
            Me.KryptonLabel10.Values.Text = "Llev Conta"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(9, 81)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(94, 20)
            Me.KryptonLabel9.TabIndex = 195
            Me.KryptonLabel9.Values.Text = "Tipo Proveedor"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(443, 57)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel8.TabIndex = 194
            Me.KryptonLabel8.Values.Text = "Telf 2"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(443, 30)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel7.TabIndex = 193
            Me.KryptonLabel7.Values.Text = "Telf 1"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(9, 55)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(113, 20)
            Me.KryptonLabel6.TabIndex = 192
            Me.KryptonLabel6.Values.Text = "Nombre Comercial"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(9, 29)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel5.TabIndex = 191
            Me.KryptonLabel5.Values.Text = "Razon Social"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(142, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 190
            Me.KryptonLabel4.Values.Text = "Fecha"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(9, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel3.TabIndex = 189
            Me.KryptonLabel3.Values.Text = "Id"
            '
            'dgvProveedoresGeneral
            '
            Me.dgvProveedoresGeneral.AllowUserToAddRows = False
            Me.dgvProveedoresGeneral.AllowUserToDeleteRows = False
            Me.dgvProveedoresGeneral.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvProveedoresGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvProveedoresGeneral.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
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
            Me.dgvProveedoresGeneral.Location = New System.Drawing.Point(10, 252)
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
            Me.dgvProveedoresGeneral.Size = New System.Drawing.Size(596, 292)
            Me.dgvProveedoresGeneral.TabIndex = 190
            '
            'FormMantenimientoProveedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(609, 545)
            Me.Controls.Add(Me.dgvProveedoresGeneral)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.txtBuscarProveedor)
            Me.Controls.Add(Me.KryptonLabel2)
            Me.Controls.Add(Me.KryptonLabel1)
            Me.Controls.Add(Me.msKardex)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMantenimientoProveedores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMINETO DE PROVEEDORES"
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.dgvProveedoresGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtIdProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents cmbTipoProveedorGeneral As System.Windows.Forms.ComboBox
        Friend WithEvents cmbContabilidadProveedorGeneral As System.Windows.Forms.ComboBox
        Friend WithEvents cmbContribuyenteEspecial As System.Windows.Forms.ComboBox
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono1ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono2ProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCiudad As System.Windows.Forms.TextBox
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents txtBuscarProveedor As System.Windows.Forms.TextBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbxCiruc As System.Windows.Forms.ComboBox
        Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dgvProveedoresGeneral As DataGridView
    End Class
End Namespace