Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormRegistroComprobanteCompra
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnGuardarEnFondoRotativo = New System.Windows.Forms.Button()
            Me.lblTipoDocumento = New System.Windows.Forms.Label()
            Me.cmbNombreParametroDocumentos = New System.Windows.Forms.ComboBox()
            Me.chkActivoFijo = New System.Windows.Forms.CheckBox()
            Me.cmbBienServicio = New System.Windows.Forms.ComboBox()
            Me.btnEliminarImpuesto = New System.Windows.Forms.Button()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.cmbContribuyente = New System.Windows.Forms.ComboBox()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.btnAgregarImpuesto = New System.Windows.Forms.Button()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtObligadoLlevarContabilidadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtNumAutoContEspFacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtCiudadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtTelefonoProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtRucProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtObservacionesComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbxPorcentaje = New System.Windows.Forms.ComboBox()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.SpaceSeparatorVertical2 = New ReaLTaiizor.Controls.SpaceSeparatorVertical()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.SpaceSeparatorVertical1 = New ReaLTaiizor.Controls.SpaceSeparatorVertical()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.gbConceptoCompra = New System.Windows.Forms.GroupBox()
            Me.cmbConceptoCompra = New System.Windows.Forms.ComboBox()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel23 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel26 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel25 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel24 = New Krypton.Toolkit.KryptonLabel()
            Me.txtSubtotal5FacturaCompra = New System.Windows.Forms.TextBox()
            Me.lblIva = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New Krypton.Toolkit.KryptonLabel()
            Me.txtIva5ComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.txtDescuentoFacturaCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotalIva = New Krypton.Toolkit.KryptonLabel()
            Me.txtSubtotal0FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PORCENTAJE = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.btnOrdenCompra = New System.Windows.Forms.Button()
            Me.KryptonLabel20 = New Krypton.Toolkit.KryptonLabel()
            Me.lblOrdenCompra = New System.Windows.Forms.Label()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.txtRazModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.bntBuscarMod = New System.Windows.Forms.Button()
            Me.dtpFechaAutoSRIComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.txtNumAutoSRIComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.chkActivarRetencion = New System.Windows.Forms.CheckBox()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.txtGuiaRemisionComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtDocModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtNumeroComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.gbRUCProveedor = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel32 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel31 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel30 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel29 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel28 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel27 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.gbConceptoCompra.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(417, 10)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 28
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.FlatAppearance.BorderSize = 0
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.Location = New System.Drawing.Point(545, -8)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(35, 35)
            Me.btnGuardar.TabIndex = 10
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.FlatAppearance.BorderSize = 0
            Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.Location = New System.Drawing.Point(627, -7)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(35, 35)
            Me.btnCancelar.TabIndex = 12
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'btnReporte
            '
            Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnReporte.Enabled = False
            Me.btnReporte.FlatAppearance.BorderSize = 0
            Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReporte.Location = New System.Drawing.Point(668, -6)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(35, 35)
            Me.btnReporte.TabIndex = 13
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReporte.UseVisualStyleBackColor = False
            '
            'btnNuevo
            '
            Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnNuevo.FlatAppearance.BorderSize = 0
            Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.Location = New System.Drawing.Point(586, -7)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(35, 35)
            Me.btnNuevo.TabIndex = 9
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevo.UseVisualStyleBackColor = False
            '
            'btnGuardarEnFondoRotativo
            '
            Me.btnGuardarEnFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnGuardarEnFondoRotativo.Enabled = False
            Me.btnGuardarEnFondoRotativo.FlatAppearance.BorderSize = 0
            Me.btnGuardarEnFondoRotativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardarEnFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnGuardarEnFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnGuardarEnFondoRotativo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarEnFondoRotativo.Location = New System.Drawing.Point(504, -7)
            Me.btnGuardarEnFondoRotativo.Name = "btnGuardarEnFondoRotativo"
            Me.btnGuardarEnFondoRotativo.Size = New System.Drawing.Size(35, 35)
            Me.btnGuardarEnFondoRotativo.TabIndex = 11
            Me.btnGuardarEnFondoRotativo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarEnFondoRotativo.UseVisualStyleBackColor = False
            Me.btnGuardarEnFondoRotativo.Visible = False
            '
            'lblTipoDocumento
            '
            Me.lblTipoDocumento.AutoSize = True
            Me.lblTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTipoDocumento.Location = New System.Drawing.Point(130, 44)
            Me.lblTipoDocumento.Name = "lblTipoDocumento"
            Me.lblTipoDocumento.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoDocumento.TabIndex = 25
            Me.lblTipoDocumento.Text = "..."
            '
            'cmbNombreParametroDocumentos
            '
            Me.cmbNombreParametroDocumentos.BackColor = System.Drawing.Color.White
            Me.cmbNombreParametroDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNombreParametroDocumentos.DropDownWidth = 350
            Me.cmbNombreParametroDocumentos.FormattingEnabled = True
            Me.cmbNombreParametroDocumentos.Location = New System.Drawing.Point(4, 5)
            Me.cmbNombreParametroDocumentos.Name = "cmbNombreParametroDocumentos"
            Me.cmbNombreParametroDocumentos.Size = New System.Drawing.Size(215, 21)
            Me.cmbNombreParametroDocumentos.TabIndex = 7
            '
            'chkActivoFijo
            '
            Me.chkActivoFijo.AutoSize = True
            Me.chkActivoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkActivoFijo.Enabled = False
            Me.chkActivoFijo.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.chkActivoFijo.FlatAppearance.BorderSize = 4
            Me.chkActivoFijo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
            Me.chkActivoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.chkActivoFijo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkActivoFijo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkActivoFijo.Location = New System.Drawing.Point(293, 7)
            Me.chkActivoFijo.Name = "chkActivoFijo"
            Me.chkActivoFijo.Size = New System.Drawing.Size(78, 17)
            Me.chkActivoFijo.TabIndex = 32
            Me.chkActivoFijo.Text = "Activo Fijo"
            Me.chkActivoFijo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkActivoFijo.UseVisualStyleBackColor = False
            '
            'cmbBienServicio
            '
            Me.cmbBienServicio.BackColor = System.Drawing.Color.White
            Me.cmbBienServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBienServicio.DropDownWidth = 100
            Me.cmbBienServicio.FormattingEnabled = True
            Me.cmbBienServicio.Items.AddRange(New Object() {"BIEN", "SERV."})
            Me.cmbBienServicio.Location = New System.Drawing.Point(639, 32)
            Me.cmbBienServicio.Name = "cmbBienServicio"
            Me.cmbBienServicio.Size = New System.Drawing.Size(70, 21)
            Me.cmbBienServicio.TabIndex = 53
            '
            'btnEliminarImpuesto
            '
            Me.btnEliminarImpuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnEliminarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnEliminarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminarImpuesto.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminarImpuesto.Location = New System.Drawing.Point(681, 1)
            Me.btnEliminarImpuesto.Name = "btnEliminarImpuesto"
            Me.btnEliminarImpuesto.Size = New System.Drawing.Size(27, 27)
            Me.btnEliminarImpuesto.TabIndex = 48
            Me.btnEliminarImpuesto.UseVisualStyleBackColor = False
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 600
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(281, 29)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(111, 21)
            Me.cmbConcepto.TabIndex = 45
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(66, 29)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(89, 21)
            Me.cmbImpuesto.TabIndex = 44
            '
            'cmbContribuyente
            '
            Me.cmbContribuyente.BackColor = System.Drawing.Color.White
            Me.cmbContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyente.DropDownWidth = 300
            Me.cmbContribuyente.FormattingEnabled = True
            Me.cmbContribuyente.Location = New System.Drawing.Point(508, 32)
            Me.cmbContribuyente.Name = "cmbContribuyente"
            Me.cmbContribuyente.Size = New System.Drawing.Size(123, 21)
            Me.cmbContribuyente.TabIndex = 46
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Enabled = False
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(281, 3)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(111, 22)
            Me.dtpComprobanteRetencion.TabIndex = 42
            Me.dtpComprobanteRetencion.Value = New Date(2019, 11, 22, 0, 0, 0, 0)
            '
            'btnAgregarImpuesto
            '
            Me.btnAgregarImpuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnAgregarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnAgregarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarImpuesto.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarImpuesto.Location = New System.Drawing.Point(647, 1)
            Me.btnAgregarImpuesto.Name = "btnAgregarImpuesto"
            Me.btnAgregarImpuesto.Size = New System.Drawing.Size(27, 27)
            Me.btnAgregarImpuesto.TabIndex = 47
            Me.btnAgregarImpuesto.UseVisualStyleBackColor = False
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(508, 4)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(123, 22)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(66, 1)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(117, 22)
            Me.txtNumeroComprobanteRetencion.TabIndex = 41
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleComprobanteRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetalleComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(-1, 58)
            Me.dgvDetalleComprobanteRetencion.MultiSelect = False
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleComprobanteRetencion.RowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(710, 93)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 49
            '
            'EjercicioFiscal
            '
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EjercicioFiscal.DefaultCellStyle = DataGridViewCellStyle3
            Me.EjercicioFiscal.HeaderText = "AÑO"
            Me.EjercicioFiscal.Name = "EjercicioFiscal"
            Me.EjercicioFiscal.ReadOnly = True
            Me.EjercicioFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.EjercicioFiscal.Width = 60
            '
            'CodigoRetencion
            '
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodigoRetencion.DefaultCellStyle = DataGridViewCellStyle4
            Me.CodigoRetencion.HeaderText = "CODIGO"
            Me.CodigoRetencion.Name = "CodigoRetencion"
            Me.CodigoRetencion.ReadOnly = True
            Me.CodigoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CodigoRetencion.Width = 60
            '
            'BaseImponible
            '
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BaseImponible.DefaultCellStyle = DataGridViewCellStyle5
            Me.BaseImponible.HeaderText = "BASE IMPONIBLE"
            Me.BaseImponible.Name = "BaseImponible"
            Me.BaseImponible.ReadOnly = True
            Me.BaseImponible.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BaseImponible.Width = 70
            '
            'Impuesto
            '
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle6
            Me.Impuesto.HeaderText = "IMPUESTO"
            Me.Impuesto.Name = "Impuesto"
            Me.Impuesto.ReadOnly = True
            Me.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Impuesto.Width = 60
            '
            'PorcentajeRetencion
            '
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PorcentajeRetencion.DefaultCellStyle = DataGridViewCellStyle7
            Me.PorcentajeRetencion.HeaderText = "%"
            Me.PorcentajeRetencion.Name = "PorcentajeRetencion"
            Me.PorcentajeRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.PorcentajeRetencion.Width = 60
            '
            'ValorRetenido
            '
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ValorRetenido.DefaultCellStyle = DataGridViewCellStyle8
            Me.ValorRetenido.HeaderText = "VALOR"
            Me.ValorRetenido.Name = "ValorRetenido"
            Me.ValorRetenido.ReadOnly = True
            Me.ValorRetenido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ValorRetenido.Width = 70
            '
            'Column1
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle9
            Me.Column1.HeaderText = "CODIGO"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column2.DefaultCellStyle = DataGridViewCellStyle10
            Me.Column2.HeaderText = "CUENTA"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 350
            '
            'txtContribuyenteEspecialProveedorGeneral
            '
            Me.txtContribuyenteEspecialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(278, 83)
            Me.txtContribuyenteEspecialProveedorGeneral.Name = "txtContribuyenteEspecialProveedorGeneral"
            Me.txtContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(54, 21)
            Me.txtContribuyenteEspecialProveedorGeneral.TabIndex = 21
            '
            'txtObligadoLlevarContabilidadProveedorGeneral
            '
            Me.txtObligadoLlevarContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Location = New System.Drawing.Point(80, 83)
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Name = "txtObligadoLlevarContabilidadProveedorGeneral"
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Size = New System.Drawing.Size(65, 21)
            Me.txtObligadoLlevarContabilidadProveedorGeneral.TabIndex = 20
            '
            'txtNumAutoContEspFacturaCompra
            '
            Me.txtNumAutoContEspFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoContEspFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoContEspFacturaCompra.Location = New System.Drawing.Point(557, 52)
            Me.txtNumAutoContEspFacturaCompra.Name = "txtNumAutoContEspFacturaCompra"
            Me.txtNumAutoContEspFacturaCompra.Size = New System.Drawing.Size(68, 21)
            Me.txtNumAutoContEspFacturaCompra.TabIndex = 22
            Me.txtNumAutoContEspFacturaCompra.Text = "0"
            '
            'txtCiudadProveedorGeneral
            '
            Me.txtCiudadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtCiudadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCiudadProveedorGeneral.Location = New System.Drawing.Point(80, 56)
            Me.txtCiudadProveedorGeneral.Name = "txtCiudadProveedorGeneral"
            Me.txtCiudadProveedorGeneral.Size = New System.Drawing.Size(111, 21)
            Me.txtCiudadProveedorGeneral.TabIndex = 17
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(444, 28)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(221, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 19
            '
            'txtTelefonoProveedorGeneral
            '
            Me.txtTelefonoProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefonoProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefonoProveedorGeneral.Location = New System.Drawing.Point(278, 55)
            Me.txtTelefonoProveedorGeneral.Name = "txtTelefonoProveedorGeneral"
            Me.txtTelefonoProveedorGeneral.Size = New System.Drawing.Size(103, 21)
            Me.txtTelefonoProveedorGeneral.TabIndex = 18
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(80, 28)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(301, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 16
            '
            'txtRucProveedorGeneral
            '
            Me.txtRucProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucProveedorGeneral.Enabled = False
            Me.txtRucProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucProveedorGeneral.Location = New System.Drawing.Point(80, 4)
            Me.txtRucProveedorGeneral.Name = "txtRucProveedorGeneral"
            Me.txtRucProveedorGeneral.Size = New System.Drawing.Size(111, 20)
            Me.txtRucProveedorGeneral.TabIndex = 14
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdProveedorGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(638, 7)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(278, 2)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(302, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 15
            '
            'txtObservacionesComprobantesCompra
            '
            Me.txtObservacionesComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobantesCompra.Location = New System.Drawing.Point(145, 399)
            Me.txtObservacionesComprobantesCompra.Name = "txtObservacionesComprobantesCompra"
            Me.txtObservacionesComprobantesCompra.Size = New System.Drawing.Size(409, 22)
            Me.txtObservacionesComprobantesCompra.TabIndex = 40
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Enabled = False
            Me.rbTipoEmisionIndisponibilidadSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(581, 4)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(118, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 6
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "Indisp del Sistema"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = False
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbTipoEmisionNormal.Checked = True
            Me.rbTipoEmisionNormal.Enabled = False
            Me.rbTipoEmisionNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(517, 4)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(62, 17)
            Me.rbTipoEmisionNormal.TabIndex = 5
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "Normal"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = False
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbProduccion.Checked = True
            Me.rbProduccion.Enabled = False
            Me.rbProduccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbProduccion.Location = New System.Drawing.Point(327, 4)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(83, 17)
            Me.rbProduccion.TabIndex = 4
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "Produccion"
            Me.rbProduccion.UseVisualStyleBackColor = False
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPruebas.Enabled = False
            Me.rbPruebas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPruebas.Location = New System.Drawing.Point(258, 4)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(66, 17)
            Me.rbPruebas.TabIndex = 3
            Me.rbPruebas.Text = "Pruebas"
            Me.rbPruebas.UseVisualStyleBackColor = False
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision002.Checked = True
            Me.rbPtoEmision002.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision002.Location = New System.Drawing.Point(124, 4)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 2
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = False
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbPtoEmision001.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbPtoEmision001.Location = New System.Drawing.Point(81, 4)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 1
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = False
            '
            'ofdSeleccionarArchivo
            '
            Me.ofdSeleccionarArchivo.FileName = "ofdSeleccionarArchivo"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.cbxPorcentaje)
            Me.GroupBox2.Enabled = False
            Me.GroupBox2.Location = New System.Drawing.Point(646, 352)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(71, 35)
            Me.GroupBox2.TabIndex = 92
            Me.GroupBox2.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(6, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(102, 13)
            Me.Label3.TabIndex = 28
            Me.Label3.Text = "PORCENTAJE I.V.A:"
            '
            'cbxPorcentaje
            '
            Me.cbxPorcentaje.BackColor = System.Drawing.Color.White
            Me.cbxPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxPorcentaje.DropDownWidth = 300
            Me.cbxPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxPorcentaje.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxPorcentaje.FormattingEnabled = True
            Me.cbxPorcentaje.Items.AddRange(New Object() {"0 %", "5 %", "12 %", "15 %"})
            Me.cbxPorcentaje.Location = New System.Drawing.Point(109, 14)
            Me.cbxPorcentaje.Name = "cbxPorcentaje"
            Me.cbxPorcentaje.Size = New System.Drawing.Size(75, 21)
            Me.cbxPorcentaje.TabIndex = 33
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(-1, 2)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbTipoEmisionNormal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.SpaceSeparatorVertical2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbProduccion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.SpaceSeparatorVertical1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPruebas)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPtoEmision002)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbPtoEmision001)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(730, 36)
            Me.KryptonGroupBox1.TabIndex = 94
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(456, 4)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel3.TabIndex = 6
            Me.KryptonLabel3.Values.Text = "Emision"
            '
            'SpaceSeparatorVertical2
            '
            Me.SpaceSeparatorVertical2.Customization = "Kioq/yoqKv8jIyP/Kioq/w=="
            Me.SpaceSeparatorVertical2.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.SpaceSeparatorVertical2.Image = Nothing
            Me.SpaceSeparatorVertical2.Location = New System.Drawing.Point(439, 5)
            Me.SpaceSeparatorVertical2.Name = "SpaceSeparatorVertical2"
            Me.SpaceSeparatorVertical2.NoRounding = False
            Me.SpaceSeparatorVertical2.Size = New System.Drawing.Size(4, 15)
            Me.SpaceSeparatorVertical2.TabIndex = 5
            Me.SpaceSeparatorVertical2.Text = "SpaceSeparatorVertical2"
            Me.SpaceSeparatorVertical2.Transparent = False
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(190, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel2.TabIndex = 4
            Me.KryptonLabel2.Values.Text = "Ambiente"
            '
            'SpaceSeparatorVertical1
            '
            Me.SpaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w=="
            Me.SpaceSeparatorVertical1.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.SpaceSeparatorVertical1.Image = Nothing
            Me.SpaceSeparatorVertical1.Location = New System.Drawing.Point(176, 6)
            Me.SpaceSeparatorVertical1.Name = "SpaceSeparatorVertical1"
            Me.SpaceSeparatorVertical1.NoRounding = False
            Me.SpaceSeparatorVertical1.Size = New System.Drawing.Size(4, 15)
            Me.SpaceSeparatorVertical1.TabIndex = 3
            Me.SpaceSeparatorVertical1.Text = "SpaceSeparatorVertical1"
            Me.SpaceSeparatorVertical1.Transparent = False
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Pto Emision"
            '
            'gbConceptoCompra
            '
            Me.gbConceptoCompra.BackColor = System.Drawing.Color.White
            Me.gbConceptoCompra.Controls.Add(Me.cmbConceptoCompra)
            Me.gbConceptoCompra.Enabled = False
            Me.gbConceptoCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConceptoCompra.Location = New System.Drawing.Point(647, 52)
            Me.gbConceptoCompra.Name = "gbConceptoCompra"
            Me.gbConceptoCompra.Size = New System.Drawing.Size(66, 37)
            Me.gbConceptoCompra.TabIndex = 84
            Me.gbConceptoCompra.TabStop = False
            Me.gbConceptoCompra.Text = "CONCEPTO:"
            '
            'cmbConceptoCompra
            '
            Me.cmbConceptoCompra.DropDownHeight = 150
            Me.cmbConceptoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConceptoCompra.DropDownWidth = 500
            Me.cmbConceptoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConceptoCompra.FormattingEnabled = True
            Me.cmbConceptoCompra.IntegralHeight = False
            Me.cmbConceptoCompra.Location = New System.Drawing.Point(10, 23)
            Me.cmbConceptoCompra.Name = "cmbConceptoCompra"
            Me.cmbConceptoCompra.Size = New System.Drawing.Size(217, 21)
            Me.cmbConceptoCompra.TabIndex = 8
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(-1, 39)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblIdComprobanteCompra)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cmbNombreParametroDocumentos)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.chkActivoFijo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnReporte)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnCancelar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnGuardar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnGuardarEnFondoRotativo)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.btnNuevo)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(730, 57)
            Me.KryptonGroupBox2.TabIndex = 95
            Me.KryptonGroupBox2.Values.Heading = "Tipo Comprobante"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(371, 4)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel4.TabIndex = 33
            Me.KryptonLabel4.Values.Text = "Id CC"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(0, 98)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel23)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtObservacionesComprobantesCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel26)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel25)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel24)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal5FacturaCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIva)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIva5ComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDescuentoFacturaCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblSubtotalIva)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal0FacturaCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubTotalComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvAsientosDiario)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtSubtotal12FacturaCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblOrdenCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.chkReq)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtRazModComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.btnBuscar)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.bntBuscarMod)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dtpFechaAutoSRIComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNumAutoSRIComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.chkActivarRetencion)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtGuiaRemisionComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDocModComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNumeroComprobanteCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNumAutoContEspFacturaCompra)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtContribuyenteEspecialProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtObligadoLlevarContabilidadProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.lblIdProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtRucProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.gbRUCProveedor)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtCiudadProveedorGeneral)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.txtTelefonoProveedorGeneral)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(729, 450)
            Me.KryptonGroupBox3.TabIndex = 96
            Me.KryptonGroupBox3.Values.Heading = "Datos"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(6, 399)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel23.TabIndex = 156
            Me.KryptonLabel23.Values.Text = "Observaciones"
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(557, 401)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel26.TabIndex = 155
            Me.KryptonLabel26.Values.Text = "Total"
            '
            'KryptonLabel25
            '
            Me.KryptonLabel25.Location = New System.Drawing.Point(557, 374)
            Me.KryptonLabel25.Name = "KryptonLabel25"
            Me.KryptonLabel25.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel25.TabIndex = 154
            Me.KryptonLabel25.Values.Text = "IVA 5%"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(557, 269)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel24.TabIndex = 153
            Me.KryptonLabel24.Values.Text = "Subtotal 5%"
            '
            'txtSubtotal5FacturaCompra
            '
            Me.txtSubtotal5FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal5FacturaCompra.Enabled = False
            Me.txtSubtotal5FacturaCompra.Location = New System.Drawing.Point(643, 266)
            Me.txtSubtotal5FacturaCompra.Name = "txtSubtotal5FacturaCompra"
            Me.txtSubtotal5FacturaCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtSubtotal5FacturaCompra.TabIndex = 147
            Me.txtSubtotal5FacturaCompra.Text = "0.00"
            Me.txtSubtotal5FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIva
            '
            Me.lblIva.Location = New System.Drawing.Point(557, 347)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(29, 20)
            Me.lblIva.TabIndex = 152
            Me.lblIva.Values.Text = "IVA"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(557, 322)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel22.TabIndex = 151
            Me.KryptonLabel22.Values.Text = "Subtotal"
            '
            'txtIva5ComprobanteCompra
            '
            Me.txtIva5ComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIva5ComprobanteCompra.Enabled = False
            Me.txtIva5ComprobanteCompra.Location = New System.Drawing.Point(643, 371)
            Me.txtIva5ComprobanteCompra.Name = "txtIva5ComprobanteCompra"
            Me.txtIva5ComprobanteCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtIva5ComprobanteCompra.TabIndex = 146
            Me.txtIva5ComprobanteCompra.Text = "0.00"
            Me.txtIva5ComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(557, 295)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel21.TabIndex = 150
            Me.KryptonLabel21.Values.Text = "Descuento"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(557, 239)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel5.TabIndex = 149
            Me.KryptonLabel5.Values.Text = "Subtotal 0%"
            '
            'txtDescuentoFacturaCompra
            '
            Me.txtDescuentoFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoFacturaCompra.Enabled = False
            Me.txtDescuentoFacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoFacturaCompra.Location = New System.Drawing.Point(643, 292)
            Me.txtDescuentoFacturaCompra.Name = "txtDescuentoFacturaCompra"
            Me.txtDescuentoFacturaCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtDescuentoFacturaCompra.TabIndex = 142
            Me.txtDescuentoFacturaCompra.Text = "0.00"
            Me.txtDescuentoFacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.Location = New System.Drawing.Point(557, 210)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(79, 20)
            Me.lblSubtotalIva.TabIndex = 148
            Me.lblSubtotalIva.Values.Text = "Subtotal IVA"
            '
            'txtSubtotal0FacturaCompra
            '
            Me.txtSubtotal0FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0FacturaCompra.Enabled = False
            Me.txtSubtotal0FacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0FacturaCompra.Location = New System.Drawing.Point(643, 237)
            Me.txtSubtotal0FacturaCompra.Name = "txtSubtotal0FacturaCompra"
            Me.txtSubtotal0FacturaCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtSubtotal0FacturaCompra.TabIndex = 141
            Me.txtSubtotal0FacturaCompra.Text = "0.00"
            Me.txtSubtotal0FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalComprobanteCompra
            '
            Me.txtSubTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubTotalComprobanteCompra.Enabled = False
            Me.txtSubTotalComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalComprobanteCompra.Location = New System.Drawing.Point(643, 319)
            Me.txtSubTotalComprobanteCompra.Name = "txtSubTotalComprobanteCompra"
            Me.txtSubTotalComprobanteCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtSubTotalComprobanteCompra.TabIndex = 143
            Me.txtSubTotalComprobanteCompra.Text = "0.00"
            Me.txtSubTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.CODIGO, Me.CUENTA, Me.VALOR, Me.IVA, Me.PORCENTAJE})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(6, 210)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(545, 183)
            Me.dgvAsientosDiario.TabIndex = 139
            '
            'eliminarItem
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkRed
            DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
            Me.eliminarItem.DefaultCellStyle = DataGridViewCellStyle14
            Me.eliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.eliminarItem.HeaderText = "Supr"
            Me.eliminarItem.Name = "eliminarItem"
            Me.eliminarItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.eliminarItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.eliminarItem.Text = "(X)"
            Me.eliminarItem.ToolTipText = "Eliminar Fila"
            Me.eliminarItem.UseColumnTextForButtonValue = True
            Me.eliminarItem.Width = 40
            '
            'CODIGO
            '
            Me.CODIGO.HeaderText = "Codigo"
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.Width = 95
            '
            'CUENTA
            '
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CUENTA.DefaultCellStyle = DataGridViewCellStyle15
            Me.CUENTA.HeaderText = "Cuenta"
            Me.CUENTA.Name = "CUENTA"
            Me.CUENTA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CUENTA.Width = 225
            '
            'VALOR
            '
            Me.VALOR.HeaderText = "Valor"
            Me.VALOR.Name = "VALOR"
            Me.VALOR.Width = 80
            '
            'IVA
            '
            Me.IVA.HeaderText = "IVA"
            Me.IVA.Name = "IVA"
            Me.IVA.Width = 35
            '
            'PORCENTAJE
            '
            Me.PORCENTAJE.HeaderText = "%"
            Me.PORCENTAJE.Items.AddRange(New Object() {"0", "5", "12", "15"})
            Me.PORCENTAJE.Name = "PORCENTAJE"
            Me.PORCENTAJE.Width = 70
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(643, 399)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(73, 22)
            Me.txtTotalComprobanteCompra.TabIndex = 145
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12FacturaCompra
            '
            Me.txtSubtotal12FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12FacturaCompra.Enabled = False
            Me.txtSubtotal12FacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12FacturaCompra.Location = New System.Drawing.Point(643, 210)
            Me.txtSubtotal12FacturaCompra.Name = "txtSubtotal12FacturaCompra"
            Me.txtSubtotal12FacturaCompra.Size = New System.Drawing.Size(74, 22)
            Me.txtSubtotal12FacturaCompra.TabIndex = 140
            Me.txtSubtotal12FacturaCompra.Text = "0.00"
            Me.txtSubtotal12FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(643, 345)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(73, 22)
            Me.txtIvaComprobanteCompra.TabIndex = 144
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnOrdenCompra
            '
            Me.btnOrdenCompra.Enabled = False
            Me.btnOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOrdenCompra.Location = New System.Drawing.Point(617, 169)
            Me.btnOrdenCompra.Name = "btnOrdenCompra"
            Me.btnOrdenCompra.Size = New System.Drawing.Size(26, 22)
            Me.btnOrdenCompra.TabIndex = 138
            Me.btnOrdenCompra.Tag = "1"
            Me.btnOrdenCompra.Text = "..."
            Me.btnOrdenCompra.UseVisualStyleBackColor = True
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(526, 145)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel20.TabIndex = 137
            Me.KryptonLabel20.Values.Text = "Fecha Emision"
            '
            'lblOrdenCompra
            '
            Me.lblOrdenCompra.AutoSize = True
            Me.lblOrdenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblOrdenCompra.Location = New System.Drawing.Point(575, 176)
            Me.lblOrdenCompra.Name = "lblOrdenCompra"
            Me.lblOrdenCompra.Size = New System.Drawing.Size(28, 13)
            Me.lblOrdenCompra.TabIndex = 128
            Me.lblOrdenCompra.Text = "###"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(542, 121)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(72, 20)
            Me.KryptonLabel19.TabIndex = 136
            Me.KryptonLabel19.Values.Text = "Fecha Auto"
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkReq.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkReq.Location = New System.Drawing.Point(453, 175)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(87, 17)
            Me.chkReq.TabIndex = 129
            Me.chkReq.Text = "Órden C. N°:"
            Me.chkReq.UseVisualStyleBackColor = False
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(230, 145)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel18.TabIndex = 135
            Me.KryptonLabel18.Values.Text = "Aut SRI"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(230, 120)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel17.TabIndex = 134
            Me.KryptonLabel17.Values.Text = "No Fact"
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(617, 146)
            Me.dtpFechaEmisionComprobanteCompra.MinDate = New Date(2014, 9, 1, 0, 0, 0, 0)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(98, 21)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 126
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(2, 169)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(86, 20)
            Me.KryptonLabel16.TabIndex = 133
            Me.KryptonLabel16.Values.Text = "Aut SRI Modif"
            '
            'txtRazModComprobanteCompra
            '
            Me.txtRazModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtRazModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazModComprobanteCompra.Location = New System.Drawing.Point(93, 171)
            Me.txtRazModComprobanteCompra.Name = "txtRazModComprobanteCompra"
            Me.txtRazModComprobanteCompra.Size = New System.Drawing.Size(132, 21)
            Me.txtRazModComprobanteCompra.TabIndex = 121
            Me.txtRazModComprobanteCompra.Text = "0"
            Me.txtRazModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 7.0!)
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.attach_file_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnBuscar.Location = New System.Drawing.Point(508, 117)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(27, 27)
            Me.btnBuscar.TabIndex = 123
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'bntBuscarMod
            '
            Me.bntBuscarMod.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.bntBuscarMod.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
            Me.bntBuscarMod.FlatAppearance.BorderSize = 0
            Me.bntBuscarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntBuscarMod.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntBuscarMod.ForeColor = System.Drawing.Color.Black
            Me.bntBuscarMod.Image = Global.syscisepro.My.Resources.Resources.attach_file_24dp_FILL0_wght400_GRAD0_opsz24
            Me.bntBuscarMod.Location = New System.Drawing.Point(200, 140)
            Me.bntBuscarMod.Name = "bntBuscarMod"
            Me.bntBuscarMod.Size = New System.Drawing.Size(27, 27)
            Me.bntBuscarMod.TabIndex = 130
            Me.bntBuscarMod.UseVisualStyleBackColor = False
            '
            'dtpFechaAutoSRIComprobanteCompra
            '
            Me.dtpFechaAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAutoSRIComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAutoSRIComprobanteCompra.Location = New System.Drawing.Point(617, 119)
            Me.dtpFechaAutoSRIComprobanteCompra.Name = "dtpFechaAutoSRIComprobanteCompra"
            Me.dtpFechaAutoSRIComprobanteCompra.Size = New System.Drawing.Size(98, 21)
            Me.dtpFechaAutoSRIComprobanteCompra.TabIndex = 125
            '
            'txtNumAutoSRIComprobanteCompra
            '
            Me.txtNumAutoSRIComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoSRIComprobanteCompra.Location = New System.Drawing.Point(289, 146)
            Me.txtNumAutoSRIComprobanteCompra.Name = "txtNumAutoSRIComprobanteCompra"
            Me.txtNumAutoSRIComprobanteCompra.Size = New System.Drawing.Size(212, 21)
            Me.txtNumAutoSRIComprobanteCompra.TabIndex = 124
            Me.txtNumAutoSRIComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(2, 145)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel15.TabIndex = 132
            Me.KryptonLabel15.Values.Text = "Doc Modif"
            '
            'chkActivarRetencion
            '
            Me.chkActivarRetencion.AutoSize = True
            Me.chkActivarRetencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkActivarRetencion.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.chkActivarRetencion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
            Me.chkActivarRetencion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.chkActivarRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkActivarRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkActivarRetencion.Location = New System.Drawing.Point(235, 175)
            Me.chkActivarRetencion.Name = "chkActivarRetencion"
            Me.chkActivarRetencion.Size = New System.Drawing.Size(199, 17)
            Me.chkActivarRetencion.TabIndex = 127
            Me.chkActivarRetencion.Text = "Activar Comprobante de Retencion"
            Me.chkActivarRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkActivarRetencion.UseVisualStyleBackColor = False
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(2, 116)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(89, 20)
            Me.KryptonLabel14.TabIndex = 131
            Me.KryptonLabel14.Values.Text = "Guia Remision"
            '
            'txtGuiaRemisionComprobanteCompra
            '
            Me.txtGuiaRemisionComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtGuiaRemisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuiaRemisionComprobanteCompra.Location = New System.Drawing.Point(93, 117)
            Me.txtGuiaRemisionComprobanteCompra.Name = "txtGuiaRemisionComprobanteCompra"
            Me.txtGuiaRemisionComprobanteCompra.Size = New System.Drawing.Size(132, 21)
            Me.txtGuiaRemisionComprobanteCompra.TabIndex = 119
            Me.txtGuiaRemisionComprobanteCompra.Text = "000"
            Me.txtGuiaRemisionComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDocModComprobanteCompra
            '
            Me.txtDocModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtDocModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocModComprobanteCompra.Location = New System.Drawing.Point(93, 144)
            Me.txtDocModComprobanteCompra.Name = "txtDocModComprobanteCompra"
            Me.txtDocModComprobanteCompra.Size = New System.Drawing.Size(102, 21)
            Me.txtDocModComprobanteCompra.TabIndex = 120
            Me.txtDocModComprobanteCompra.Text = "000"
            Me.txtDocModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroComprobanteCompra
            '
            Me.txtNumeroComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteCompra.Location = New System.Drawing.Point(289, 117)
            Me.txtNumeroComprobanteCompra.Name = "txtNumeroComprobanteCompra"
            Me.txtNumeroComprobanteCompra.Size = New System.Drawing.Size(213, 21)
            Me.txtNumeroComprobanteCompra.TabIndex = 122
            Me.txtNumeroComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(2, 24)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel13.TabIndex = 83
            Me.KryptonLabel13.Values.Text = "Direccion"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(396, 55)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(126, 20)
            Me.KryptonLabel12.TabIndex = 82
            Me.KryptonLabel12.Values.Text = "Num Auto Contrib Es"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(155, 84)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(100, 20)
            Me.KryptonLabel11.TabIndex = 81
            Me.KryptonLabel11.Values.Text = "Contrib. Especial"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(2, 84)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel10.TabIndex = 80
            Me.KryptonLabel10.Values.Text = "Oblig Cont"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(396, 29)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel9.TabIndex = 79
            Me.KryptonLabel9.Values.Text = "Email"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(197, 55)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel8.TabIndex = 78
            Me.KryptonLabel8.Values.Text = "Telefono"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(1, 53)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel7.TabIndex = 77
            Me.KryptonLabel7.Values.Text = "Ciudad"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(201, 1)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel6.TabIndex = 15
            Me.KryptonLabel6.Values.Text = "Proveedor"
            '
            'gbRUCProveedor
            '
            Me.gbRUCProveedor.Location = New System.Drawing.Point(3, 1)
            Me.gbRUCProveedor.Name = "gbRUCProveedor"
            Me.gbRUCProveedor.Size = New System.Drawing.Size(57, 20)
            Me.gbRUCProveedor.TabIndex = 1
            Me.gbRUCProveedor.Values.Text = "CI / RUC "
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(0, 551)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnEliminarImpuesto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbBienServicio)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnAgregarImpuesto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel32)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel31)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbContribuyente)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel30)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel29)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel28)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel27)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpComprobanteRetencion)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbImpuesto)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(729, 178)
            Me.KryptonGroupBox4.TabIndex = 97
            Me.KryptonGroupBox4.Values.Heading = "Retencion"
            '
            'KryptonLabel32
            '
            Me.KryptonLabel32.Location = New System.Drawing.Point(411, 32)
            Me.KryptonLabel32.Name = "KryptonLabel32"
            Me.KryptonLabel32.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel32.TabIndex = 139
            Me.KryptonLabel32.Values.Text = "Contribuyente"
            '
            'KryptonLabel31
            '
            Me.KryptonLabel31.Location = New System.Drawing.Point(411, 5)
            Me.KryptonLabel31.Name = "KryptonLabel31"
            Me.KryptonLabel31.Size = New System.Drawing.Size(96, 20)
            Me.KryptonLabel31.TabIndex = 138
            Me.KryptonLabel31.Values.Text = "Total Retencion"
            '
            'KryptonLabel30
            '
            Me.KryptonLabel30.Location = New System.Drawing.Point(197, 32)
            Me.KryptonLabel30.Name = "KryptonLabel30"
            Me.KryptonLabel30.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel30.TabIndex = 137
            Me.KryptonLabel30.Values.Text = "Concepto"
            '
            'KryptonLabel29
            '
            Me.KryptonLabel29.Location = New System.Drawing.Point(222, 1)
            Me.KryptonLabel29.Name = "KryptonLabel29"
            Me.KryptonLabel29.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel29.TabIndex = 136
            Me.KryptonLabel29.Values.Text = "Fecha"
            '
            'KryptonLabel28
            '
            Me.KryptonLabel28.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel28.Name = "KryptonLabel28"
            Me.KryptonLabel28.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel28.TabIndex = 135
            Me.KryptonLabel28.Values.Text = "Impuesto"
            '
            'KryptonLabel27
            '
            Me.KryptonLabel27.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel27.Name = "KryptonLabel27"
            Me.KryptonLabel27.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel27.TabIndex = 134
            Me.KryptonLabel27.Values.Text = "Nro"
            '
            'FormRegistroComprobanteCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(730, 729)
            Me.Controls.Add(Me.KryptonGroupBox4)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.lblTipoDocumento)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.gbConceptoCompra)
            Me.Controls.Add(Me.GroupBox2)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "FormRegistroComprobanteCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRAR COMPROBANTE DE COMPRA"
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.gbConceptoCompra.ResumeLayout(False)
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
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
        Friend WithEvents cmbNombreParametroDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnEliminarImpuesto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImpuesto As System.Windows.Forms.Button
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtCiudadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefonoProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRucProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtContribuyenteEspecialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtObligadoLlevarContabilidadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtNumAutoContEspFacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents txtObservacionesComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents btnGuardarEnFondoRotativo As System.Windows.Forms.Button
        Friend WithEvents cmbContribuyente As System.Windows.Forms.ComboBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cbxPorcentaje As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cmbBienServicio As System.Windows.Forms.ComboBox
        Friend WithEvents chkActivoFijo As System.Windows.Forms.CheckBox
        Friend WithEvents EjercicioFiscal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CodigoRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BaseImponible As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PorcentajeRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ValorRetenido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents SpaceSeparatorVertical2 As ReaLTaiizor.Controls.SpaceSeparatorVertical
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents SpaceSeparatorVertical1 As ReaLTaiizor.Controls.SpaceSeparatorVertical
        Friend WithEvents gbConceptoCompra As GroupBox
        Friend WithEvents cmbConceptoCompra As ComboBox
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbRUCProveedor As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents btnOrdenCompra As Button
        Friend WithEvents KryptonLabel20 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblOrdenCompra As Label
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents chkReq As CheckBox
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpFechaEmisionComprobanteCompra As DateTimePicker
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtRazModComprobanteCompra As TextBox
        Friend WithEvents btnBuscar As Button
        Friend WithEvents bntBuscarMod As Button
        Friend WithEvents dtpFechaAutoSRIComprobanteCompra As DateTimePicker
        Friend WithEvents txtNumAutoSRIComprobanteCompra As TextBox
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents chkActivarRetencion As CheckBox
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtGuiaRemisionComprobanteCompra As TextBox
        Friend WithEvents txtDocModComprobanteCompra As TextBox
        Friend WithEvents txtNumeroComprobanteCompra As TextBox
        Friend WithEvents KryptonLabel26 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtSubtotal5FacturaCompra As TextBox
        Friend WithEvents lblIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtIva5ComprobanteCompra As TextBox
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtDescuentoFacturaCompra As TextBox
        Friend WithEvents lblSubtotalIva As Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtSubtotal0FacturaCompra As TextBox
        Friend WithEvents txtSubTotalComprobanteCompra As TextBox
        Friend WithEvents dgvAsientosDiario As DataGridView
        Friend WithEvents txtTotalComprobanteCompra As TextBox
        Friend WithEvents txtSubtotal12FacturaCompra As TextBox
        Friend WithEvents txtIvaComprobanteCompra As TextBox
        Friend WithEvents KryptonLabel23 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel32 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel31 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel30 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel29 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel28 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents eliminarItem As DataGridViewButtonColumn
        Friend WithEvents CODIGO As DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As DataGridViewTextBoxColumn
        Friend WithEvents VALOR As DataGridViewTextBoxColumn
        Friend WithEvents IVA As DataGridViewTextBoxColumn
        Friend WithEvents PORCENTAJE As DataGridViewComboBoxColumn
    End Class
End Namespace