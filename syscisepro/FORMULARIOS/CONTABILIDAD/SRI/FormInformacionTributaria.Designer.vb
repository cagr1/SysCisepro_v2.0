Namespace FORMULARIOS.CONTABILIDAD.SRI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormInformacionTributaria
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInformacionTributaria))
            Me.chkEmpresa = New System.Windows.Forms.CheckBox()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.txtLlevaContabilidadEmpresa = New System.Windows.Forms.TextBox()
            Me.txtContribuyenteEspecialEmpresa = New System.Windows.Forms.TextBox()
            Me.txtDireccionMatrizEmpresa = New System.Windows.Forms.TextBox()
            Me.txtRucEmpresa = New System.Windows.Forms.TextBox()
            Me.txtRazonSocialEmpresa = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialEmpresa = New System.Windows.Forms.TextBox()
            Me.lblIdInformacionTributaria = New System.Windows.Forms.Label()
            Me.chkSecuenciales = New System.Windows.Forms.CheckBox()
            Me.txtSecuencialComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtSecuencialNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSecuencialFactura = New System.Windows.Forms.TextBox()
            Me.chkImpuestos = New System.Windows.Forms.CheckBox()
            Me.txtPorcentajeICE = New System.Windows.Forms.TextBox()
            Me.txtPorcentajeIVA = New System.Windows.Forms.TextBox()
            Me.chkNroAutorizaciones = New System.Windows.Forms.CheckBox()
            Me.txtNroAutorizacionComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtNroAutorizaciónNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtNroAutorizacionFactura = New System.Windows.Forms.TextBox()
            Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
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
            Me.SuspendLayout()
            '
            'chkEmpresa
            '
            Me.chkEmpresa.AutoSize = True
            Me.chkEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkEmpresa.Location = New System.Drawing.Point(497, 46)
            Me.chkEmpresa.Name = "chkEmpresa"
            Me.chkEmpresa.Size = New System.Drawing.Size(61, 17)
            Me.chkEmpresa.TabIndex = 7
            Me.chkEmpresa.Text = "Activar"
            Me.chkEmpresa.UseVisualStyleBackColor = False
            '
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(177, 7)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(10, 13)
            Me.lblIdEmpresa.TabIndex = 6
            Me.lblIdEmpresa.Text = "."
            Me.lblIdEmpresa.Visible = False
            '
            'txtLlevaContabilidadEmpresa
            '
            Me.txtLlevaContabilidadEmpresa.BackColor = System.Drawing.Color.White
            Me.txtLlevaContabilidadEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLlevaContabilidadEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLlevaContabilidadEmpresa.Location = New System.Drawing.Point(413, 83)
            Me.txtLlevaContabilidadEmpresa.Name = "txtLlevaContabilidadEmpresa"
            Me.txtLlevaContabilidadEmpresa.Size = New System.Drawing.Size(98, 21)
            Me.txtLlevaContabilidadEmpresa.TabIndex = 5
            '
            'txtContribuyenteEspecialEmpresa
            '
            Me.txtContribuyenteEspecialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtContribuyenteEspecialEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContribuyenteEspecialEmpresa.Location = New System.Drawing.Point(134, 82)
            Me.txtContribuyenteEspecialEmpresa.Name = "txtContribuyenteEspecialEmpresa"
            Me.txtContribuyenteEspecialEmpresa.Size = New System.Drawing.Size(115, 21)
            Me.txtContribuyenteEspecialEmpresa.TabIndex = 4
            Me.txtContribuyenteEspecialEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDireccionMatrizEmpresa
            '
            Me.txtDireccionMatrizEmpresa.BackColor = System.Drawing.Color.White
            Me.txtDireccionMatrizEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionMatrizEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionMatrizEmpresa.Location = New System.Drawing.Point(134, 56)
            Me.txtDireccionMatrizEmpresa.Name = "txtDireccionMatrizEmpresa"
            Me.txtDireccionMatrizEmpresa.Size = New System.Drawing.Size(424, 21)
            Me.txtDireccionMatrizEmpresa.TabIndex = 3
            '
            'txtRucEmpresa
            '
            Me.txtRucEmpresa.BackColor = System.Drawing.Color.White
            Me.txtRucEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucEmpresa.Location = New System.Drawing.Point(62, 4)
            Me.txtRucEmpresa.Name = "txtRucEmpresa"
            Me.txtRucEmpresa.Size = New System.Drawing.Size(100, 21)
            Me.txtRucEmpresa.TabIndex = 2
            '
            'txtRazonSocialEmpresa
            '
            Me.txtRazonSocialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtRazonSocialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonSocialEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocialEmpresa.Location = New System.Drawing.Point(283, 3)
            Me.txtRazonSocialEmpresa.Name = "txtRazonSocialEmpresa"
            Me.txtRazonSocialEmpresa.Size = New System.Drawing.Size(275, 21)
            Me.txtRazonSocialEmpresa.TabIndex = 1
            '
            'txtNombreComercialEmpresa
            '
            Me.txtNombreComercialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialEmpresa.Location = New System.Drawing.Point(134, 29)
            Me.txtNombreComercialEmpresa.Name = "txtNombreComercialEmpresa"
            Me.txtNombreComercialEmpresa.Size = New System.Drawing.Size(424, 21)
            Me.txtNombreComercialEmpresa.TabIndex = 0
            '
            'lblIdInformacionTributaria
            '
            Me.lblIdInformacionTributaria.AutoSize = True
            Me.lblIdInformacionTributaria.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdInformacionTributaria.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdInformacionTributaria.Location = New System.Drawing.Point(152, 190)
            Me.lblIdInformacionTributaria.Name = "lblIdInformacionTributaria"
            Me.lblIdInformacionTributaria.Size = New System.Drawing.Size(10, 13)
            Me.lblIdInformacionTributaria.TabIndex = 7
            Me.lblIdInformacionTributaria.Text = "."
            '
            'chkSecuenciales
            '
            Me.chkSecuenciales.AutoSize = True
            Me.chkSecuenciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkSecuenciales.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSecuenciales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkSecuenciales.Location = New System.Drawing.Point(212, 187)
            Me.chkSecuenciales.Name = "chkSecuenciales"
            Me.chkSecuenciales.Size = New System.Drawing.Size(61, 17)
            Me.chkSecuenciales.TabIndex = 8
            Me.chkSecuenciales.Text = "Activar"
            Me.chkSecuenciales.UseVisualStyleBackColor = False
            '
            'txtSecuencialComprobanteRetencion
            '
            Me.txtSecuencialComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtSecuencialComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecuencialComprobanteRetencion.Location = New System.Drawing.Point(144, 55)
            Me.txtSecuencialComprobanteRetencion.Name = "txtSecuencialComprobanteRetencion"
            Me.txtSecuencialComprobanteRetencion.Size = New System.Drawing.Size(115, 21)
            Me.txtSecuencialComprobanteRetencion.TabIndex = 2
            Me.txtSecuencialComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSecuencialNotaCredito
            '
            Me.txtSecuencialNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSecuencialNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecuencialNotaCredito.Location = New System.Drawing.Point(144, 29)
            Me.txtSecuencialNotaCredito.Name = "txtSecuencialNotaCredito"
            Me.txtSecuencialNotaCredito.Size = New System.Drawing.Size(115, 21)
            Me.txtSecuencialNotaCredito.TabIndex = 1
            Me.txtSecuencialNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSecuencialFactura
            '
            Me.txtSecuencialFactura.BackColor = System.Drawing.Color.White
            Me.txtSecuencialFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecuencialFactura.Location = New System.Drawing.Point(144, 5)
            Me.txtSecuencialFactura.Name = "txtSecuencialFactura"
            Me.txtSecuencialFactura.Size = New System.Drawing.Size(115, 21)
            Me.txtSecuencialFactura.TabIndex = 0
            Me.txtSecuencialFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkImpuestos
            '
            Me.chkImpuestos.AutoSize = True
            Me.chkImpuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkImpuestos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkImpuestos.Location = New System.Drawing.Point(496, 302)
            Me.chkImpuestos.Name = "chkImpuestos"
            Me.chkImpuestos.Size = New System.Drawing.Size(61, 17)
            Me.chkImpuestos.TabIndex = 8
            Me.chkImpuestos.Text = "Activar"
            Me.chkImpuestos.UseVisualStyleBackColor = False
            '
            'txtPorcentajeICE
            '
            Me.txtPorcentajeICE.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeICE.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPorcentajeICE.Location = New System.Drawing.Point(397, 1)
            Me.txtPorcentajeICE.Name = "txtPorcentajeICE"
            Me.txtPorcentajeICE.Size = New System.Drawing.Size(78, 21)
            Me.txtPorcentajeICE.TabIndex = 1
            Me.txtPorcentajeICE.Text = "% ICE"
            Me.txtPorcentajeICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtPorcentajeIVA
            '
            Me.txtPorcentajeIVA.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPorcentajeIVA.Location = New System.Drawing.Point(144, 2)
            Me.txtPorcentajeIVA.Name = "txtPorcentajeIVA"
            Me.txtPorcentajeIVA.Size = New System.Drawing.Size(78, 21)
            Me.txtPorcentajeIVA.TabIndex = 0
            Me.txtPorcentajeIVA.Text = "% IVA"
            Me.txtPorcentajeIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkNroAutorizaciones
            '
            Me.chkNroAutorizaciones.AutoSize = True
            Me.chkNroAutorizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkNroAutorizaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkNroAutorizaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkNroAutorizaciones.Location = New System.Drawing.Point(495, 187)
            Me.chkNroAutorizaciones.Name = "chkNroAutorizaciones"
            Me.chkNroAutorizaciones.Size = New System.Drawing.Size(61, 17)
            Me.chkNroAutorizaciones.TabIndex = 8
            Me.chkNroAutorizaciones.Text = "Activar"
            Me.chkNroAutorizaciones.UseVisualStyleBackColor = False
            '
            'txtNroAutorizacionComprobanteRetencion
            '
            Me.txtNroAutorizacionComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizacionComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizacionComprobanteRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroAutorizacionComprobanteRetencion.Location = New System.Drawing.Point(102, 54)
            Me.txtNroAutorizacionComprobanteRetencion.Name = "txtNroAutorizacionComprobanteRetencion"
            Me.txtNroAutorizacionComprobanteRetencion.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizacionComprobanteRetencion.TabIndex = 2
            Me.txtNroAutorizacionComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroAutorizaciónNotaCredito
            '
            Me.txtNroAutorizaciónNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizaciónNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizaciónNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroAutorizaciónNotaCredito.Location = New System.Drawing.Point(102, 29)
            Me.txtNroAutorizaciónNotaCredito.Name = "txtNroAutorizaciónNotaCredito"
            Me.txtNroAutorizaciónNotaCredito.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizaciónNotaCredito.TabIndex = 1
            Me.txtNroAutorizaciónNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroAutorizacionFactura
            '
            Me.txtNroAutorizacionFactura.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizacionFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizacionFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroAutorizacionFactura.Location = New System.Drawing.Point(102, 4)
            Me.txtNroAutorizacionFactura.Name = "txtNroAutorizacionFactura"
            Me.txtNroAutorizacionFactura.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizacionFactura.TabIndex = 0
            Me.txtNroAutorizacionFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvEmpresa
            '
            Me.dgvEmpresa.AllowUserToAddRows = False
            Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEmpresa.Location = New System.Drawing.Point(459, 147)
            Me.dgvEmpresa.Name = "dgvEmpresa"
            Me.dgvEmpresa.Size = New System.Drawing.Size(40, 33)
            Me.dgvEmpresa.TabIndex = 46
            '
            'MenuStrip1
            '
            Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(572, 32)
            Me.MenuStrip1.TabIndex = 188
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
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_note_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(103, 28)
            Me.btnModificar.Text = "MODIFICAR"
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
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 39)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazonSocialEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtLlevaContabilidadEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionMatrizEmpresa)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtContribuyenteEspecialEmpresa)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(570, 141)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Empresa"
            Me.KryptonGroupBox1.Values.Image = Global.syscisepro.My.Resources.Resources.business_20dp__1_
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "RUC"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(198, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel2.TabIndex = 3
            Me.KryptonLabel2.Values.Text = "Razon Social"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(113, 20)
            Me.KryptonLabel3.TabIndex = 4
            Me.KryptonLabel3.Values.Text = "Nombre Comercial"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(3, 56)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(99, 20)
            Me.KryptonLabel4.TabIndex = 5
            Me.KryptonLabel4.Values.Text = "Direccion Matriz"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 82)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel5.TabIndex = 6
            Me.KryptonLabel5.Values.Text = "No Resolucion"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(283, 82)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(113, 20)
            Me.KryptonLabel6.TabIndex = 7
            Me.KryptonLabel6.Values.Text = "Oblig Contabilidad"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(2, 183)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSecuencialFactura)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSecuencialComprobanteRetencion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtSecuencialNotaCredito)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(274, 106)
            Me.KryptonGroupBox2.TabIndex = 190
            Me.KryptonGroupBox2.Values.Heading = "Secuencia Comprobantes"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(111, 20)
            Me.KryptonLabel7.TabIndex = 8
            Me.KryptonLabel7.Values.Text = "Secuencial Factura"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(124, 20)
            Me.KryptonLabel8.TabIndex = 9
            Me.KryptonLabel8.Values.Text = "Secuencial N Credito"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(3, 55)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(137, 20)
            Me.KryptonLabel9.TabIndex = 10
            Me.KryptonLabel9.Values.Text = "Secuencial C Retencion"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(276, 183)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNroAutorizacionFactura)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNroAutorizacionComprobanteRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNroAutorizaciónNotaCredito)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(296, 106)
            Me.KryptonGroupBox3.TabIndex = 191
            Me.KryptonGroupBox3.Values.Heading = "No Autorizacion Comprobantes"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(77, 20)
            Me.KryptonLabel12.TabIndex = 8
            Me.KryptonLabel12.Values.Text = "No Auto SRI"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(77, 20)
            Me.KryptonLabel10.TabIndex = 9
            Me.KryptonLabel10.Values.Text = "No Auto SRI"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(3, 55)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(77, 20)
            Me.KryptonLabel11.TabIndex = 10
            Me.KryptonLabel11.Values.Text = "No Auto SRI"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(2, 292)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtPorcentajeIVA)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtPorcentajeICE)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(570, 64)
            Me.KryptonGroupBox4.TabIndex = 192
            Me.KryptonGroupBox4.Values.Heading = "Impuestos"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel13.TabIndex = 10
            Me.KryptonLabel13.Values.Text = "Porcentaje IVA"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(283, 2)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel14.TabIndex = 11
            Me.KryptonLabel14.Values.Text = "Porcentaje ICE"
            '
            'FormInformacionTributaria
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(572, 355)
            Me.Controls.Add(Me.chkImpuestos)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.chkNroAutorizaciones)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.chkSecuenciales)
            Me.Controls.Add(Me.lblIdInformacionTributaria)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.chkEmpresa)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvEmpresa)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormInformacionTributaria"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "INFORMACIÓN TRIBUTARIA"
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtLlevaContabilidadEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtContribuyenteEspecialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionMatrizEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtRucEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonSocialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtSecuencialComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtSecuencialNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSecuencialFactura As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeICE As System.Windows.Forms.TextBox
        Friend WithEvents txtNroAutorizacionComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtNroAutorizaciónNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtNroAutorizacionFactura As System.Windows.Forms.TextBox
        Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblIdInformacionTributaria As System.Windows.Forms.Label
        Friend WithEvents chkEmpresa As System.Windows.Forms.CheckBox
        Friend WithEvents chkSecuenciales As System.Windows.Forms.CheckBox
        Friend WithEvents chkImpuestos As System.Windows.Forms.CheckBox
        Friend WithEvents chkNroAutorizaciones As System.Windows.Forms.CheckBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace