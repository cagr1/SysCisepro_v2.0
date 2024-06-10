Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRegistroComprobanteCompra
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
            Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gpComandos = New System.Windows.Forms.GroupBox()
            Me.lblEtiquetaIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnGuardarEnFondoRotativo = New System.Windows.Forms.Button()
            Me.gbTipoComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.lblTipoDocumento = New System.Windows.Forms.Label()
            Me.cmbNombreParametroDocumentos = New System.Windows.Forms.ComboBox()
            Me.chkActivoFijo = New System.Windows.Forms.CheckBox()
            Me.gbRetencion = New System.Windows.Forms.GroupBox()
            Me.cmbBienServicio = New System.Windows.Forms.ComboBox()
            Me.btnEliminarImpuesto = New System.Windows.Forms.Button()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.cmbImpuesto = New System.Windows.Forms.ComboBox()
            Me.cmbContribuyente = New System.Windows.Forms.ComboBox()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.btnAgregarImpuesto = New System.Windows.Forms.Button()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.lblImpuesto = New System.Windows.Forms.Label()
            Me.lblTotalRetencion = New System.Windows.Forms.Label()
            Me.txtTotalComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblNroRetencion = New System.Windows.Forms.Label()
            Me.txtNumeroComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.lblFechaRetencion = New System.Windows.Forms.Label()
            Me.lblContribuyente = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gbDatosEspecialesComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.bntBuscarMod = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtRazModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtDocModComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblGuiaRemisionFacturaCompra = New System.Windows.Forms.Label()
            Me.txtGuiaRemisionComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.chkActivarRetencion = New System.Windows.Forms.CheckBox()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.lblFechaEmisionFacturaCompra = New System.Windows.Forms.Label()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.gbValoresComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.txtSubtotal5FacturaCompra = New System.Windows.Forms.TextBox()
            Me.lblSubtotal5ComprabanteCompra = New System.Windows.Forms.Label()
            Me.txtIva5ComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblIva5 = New System.Windows.Forms.Label()
            Me.txtDescuentoFacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal0FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubtotal12FacturaCompra = New System.Windows.Forms.TextBox()
            Me.txtSubTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtTotalComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.txtIvaComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblSubTotal = New System.Windows.Forms.Label()
            Me.lblTotalOrdenCompra = New System.Windows.Forms.Label()
            Me.lblIva = New System.Windows.Forms.Label()
            Me.lblDescuentoOrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotal0OrdenCompra = New System.Windows.Forms.Label()
            Me.lblSubtotalIva = New System.Windows.Forms.Label()
            Me.gbDatosComprobanteCompra = New System.Windows.Forms.GroupBox()
            Me.btnOrdenCompra = New System.Windows.Forms.Button()
            Me.lblOrdenCompra = New System.Windows.Forms.Label()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.lblNumAutoSRIFacturaCompra = New System.Windows.Forms.Label()
            Me.txtNumAutoSRIComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblNumeroFacturaCompra = New System.Windows.Forms.Label()
            Me.dtpFechaAutoSRIComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.txtNumeroComprobanteCompra = New System.Windows.Forms.TextBox()
            Me.lblFechaAutoSRIFacturaCompra = New System.Windows.Forms.Label()
            Me.lblSeparadorRUC = New System.Windows.Forms.Label()
            Me.lblSeparadorNumFact = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.gbDatosProveedor = New System.Windows.Forms.GroupBox()
            Me.txtContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtObligadoLlevarContabilidadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtNumAutoContEspFacturaCompra = New System.Windows.Forms.TextBox()
            Me.lblNumAutoContEspFacturaCompra = New System.Windows.Forms.Label()
            Me.lblContabilidadProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblContribuyenteEspecialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtCiudadProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblCiudadProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtEmailProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTelefonoProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblTelefono1ProveedorGeneral = New System.Windows.Forms.Label()
            Me.lblDireccionProveedorGeneral = New System.Windows.Forms.Label()
            Me.gbRUCProveedor = New System.Windows.Forms.GroupBox()
            Me.txtRucProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.gbObservaciones = New System.Windows.Forms.GroupBox()
            Me.txtObservacionesComprobantesCompra = New System.Windows.Forms.TextBox()
            Me.gbConceptoCompra = New System.Windows.Forms.GroupBox()
            Me.cmbConceptoCompra = New System.Windows.Forms.ComboBox()
            Me.gbTipoEmision = New System.Windows.Forms.GroupBox()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.gbTipoAnbiente = New System.Windows.Forms.GroupBox()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.gbPtoEmision = New System.Windows.Forms.GroupBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.rbPtoEmision002 = New System.Windows.Forms.RadioButton()
            Me.rbPtoEmision001 = New System.Windows.Forms.RadioButton()
            Me.ofdSeleccionarArchivo = New System.Windows.Forms.OpenFileDialog()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbxPorcentaje = New System.Windows.Forms.ComboBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PORCENTAJE = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.gpComandos.SuspendLayout()
            Me.gbTipoComprobanteCompra.SuspendLayout()
            Me.gbRetencion.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDatosEspecialesComprobanteCompra.SuspendLayout()
            Me.gbValoresComprobanteCompra.SuspendLayout()
            Me.gbDatosComprobanteCompra.SuspendLayout()
            Me.gbDatosProveedor.SuspendLayout()
            Me.gbRUCProveedor.SuspendLayout()
            Me.gbNombreComercialProveedor.SuspendLayout()
            Me.gbObservaciones.SuspendLayout()
            Me.gbConceptoCompra.SuspendLayout()
            Me.gbTipoEmision.SuspendLayout()
            Me.gbTipoAnbiente.SuspendLayout()
            Me.gbPtoEmision.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gpComandos
            '
            Me.gpComandos.BackColor = System.Drawing.Color.White
            Me.gpComandos.Controls.Add(Me.lblEtiquetaIdComprobanteCompra)
            Me.gpComandos.Controls.Add(Me.lblIdComprobanteCompra)
            Me.gpComandos.Controls.Add(Me.btnGuardar)
            Me.gpComandos.Controls.Add(Me.btnCancelar)
            Me.gpComandos.Controls.Add(Me.btnReporte)
            Me.gpComandos.Controls.Add(Me.btnNuevo)
            Me.gpComandos.Controls.Add(Me.btnGuardarEnFondoRotativo)
            Me.gpComandos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpComandos.Location = New System.Drawing.Point(465, 32)
            Me.gpComandos.Name = "gpComandos"
            Me.gpComandos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.gpComandos.Size = New System.Drawing.Size(325, 48)
            Me.gpComandos.TabIndex = 47
            Me.gpComandos.TabStop = False
            '
            'lblEtiquetaIdComprobanteCompra
            '
            Me.lblEtiquetaIdComprobanteCompra.AutoSize = True
            Me.lblEtiquetaIdComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaIdComprobanteCompra.Location = New System.Drawing.Point(6, 0)
            Me.lblEtiquetaIdComprobanteCompra.Name = "lblEtiquetaIdComprobanteCompra"
            Me.lblEtiquetaIdComprobanteCompra.Size = New System.Drawing.Size(34, 13)
            Me.lblEtiquetaIdComprobanteCompra.TabIndex = 29
            Me.lblEtiquetaIdComprobanteCompra.Text = "ID CC"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(48, -4)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(16, 13)
            Me.lblIdComprobanteCompra.TabIndex = 28
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.White
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.Location = New System.Drawing.Point(136, 10)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(35, 35)
            Me.btnGuardar.TabIndex = 10
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.Color.White
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.Location = New System.Drawing.Point(176, 10)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(35, 35)
            Me.btnCancelar.TabIndex = 12
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'btnReporte
            '
            Me.btnReporte.BackColor = System.Drawing.Color.White
            Me.btnReporte.Enabled = False
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReporte.Location = New System.Drawing.Point(217, 10)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(35, 35)
            Me.btnReporte.TabIndex = 13
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReporte.UseVisualStyleBackColor = False
            '
            'btnNuevo
            '
            Me.btnNuevo.BackColor = System.Drawing.Color.White
            Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.Location = New System.Drawing.Point(95, 10)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(35, 35)
            Me.btnNuevo.TabIndex = 9
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevo.UseVisualStyleBackColor = False
            '
            'btnGuardarEnFondoRotativo
            '
            Me.btnGuardarEnFondoRotativo.BackColor = System.Drawing.Color.White
            Me.btnGuardarEnFondoRotativo.Enabled = False
            Me.btnGuardarEnFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 6.5!)
            Me.btnGuardarEnFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.ok
            Me.btnGuardarEnFondoRotativo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarEnFondoRotativo.Location = New System.Drawing.Point(137, 10)
            Me.btnGuardarEnFondoRotativo.Name = "btnGuardarEnFondoRotativo"
            Me.btnGuardarEnFondoRotativo.Size = New System.Drawing.Size(35, 35)
            Me.btnGuardarEnFondoRotativo.TabIndex = 11
            Me.btnGuardarEnFondoRotativo.Text = "GUARDAR"
            Me.btnGuardarEnFondoRotativo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarEnFondoRotativo.UseVisualStyleBackColor = False
            '
            'gbTipoComprobanteCompra
            '
            Me.gbTipoComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbTipoComprobanteCompra.Controls.Add(Me.lblTipoDocumento)
            Me.gbTipoComprobanteCompra.Controls.Add(Me.cmbNombreParametroDocumentos)
            Me.gbTipoComprobanteCompra.Controls.Add(Me.chkActivoFijo)
            Me.gbTipoComprobanteCompra.Enabled = False
            Me.gbTipoComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoComprobanteCompra.Location = New System.Drawing.Point(1, 32)
            Me.gbTipoComprobanteCompra.Name = "gbTipoComprobanteCompra"
            Me.gbTipoComprobanteCompra.Size = New System.Drawing.Size(427, 48)
            Me.gbTipoComprobanteCompra.TabIndex = 46
            Me.gbTipoComprobanteCompra.TabStop = False
            Me.gbTipoComprobanteCompra.Text = "TIPO DE COMPROBANTE"
            '
            'lblTipoDocumento
            '
            Me.lblTipoDocumento.AutoSize = True
            Me.lblTipoDocumento.Location = New System.Drawing.Point(149, 0)
            Me.lblTipoDocumento.Name = "lblTipoDocumento"
            Me.lblTipoDocumento.Size = New System.Drawing.Size(16, 13)
            Me.lblTipoDocumento.TabIndex = 25
            Me.lblTipoDocumento.Text = "..."
            '
            'cmbNombreParametroDocumentos
            '
            Me.cmbNombreParametroDocumentos.BackColor = System.Drawing.Color.White
            Me.cmbNombreParametroDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNombreParametroDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbNombreParametroDocumentos.FormattingEnabled = True
            Me.cmbNombreParametroDocumentos.Location = New System.Drawing.Point(5, 20)
            Me.cmbNombreParametroDocumentos.Name = "cmbNombreParametroDocumentos"
            Me.cmbNombreParametroDocumentos.Size = New System.Drawing.Size(400, 21)
            Me.cmbNombreParametroDocumentos.TabIndex = 7
            '
            'chkActivoFijo
            '
            Me.chkActivoFijo.AutoSize = True
            Me.chkActivoFijo.Enabled = False
            Me.chkActivoFijo.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.chkActivoFijo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
            Me.chkActivoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.chkActivoFijo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkActivoFijo.Location = New System.Drawing.Point(331, 0)
            Me.chkActivoFijo.Name = "chkActivoFijo"
            Me.chkActivoFijo.Size = New System.Drawing.Size(88, 17)
            Me.chkActivoFijo.TabIndex = 32
            Me.chkActivoFijo.Text = "ACTIVO FIJO"
            Me.chkActivoFijo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkActivoFijo.UseVisualStyleBackColor = True
            '
            'gbRetencion
            '
            Me.gbRetencion.BackColor = System.Drawing.Color.White
            Me.gbRetencion.Controls.Add(Me.cmbBienServicio)
            Me.gbRetencion.Controls.Add(Me.btnEliminarImpuesto)
            Me.gbRetencion.Controls.Add(Me.cmbConcepto)
            Me.gbRetencion.Controls.Add(Me.cmbImpuesto)
            Me.gbRetencion.Controls.Add(Me.cmbContribuyente)
            Me.gbRetencion.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.btnAgregarImpuesto)
            Me.gbRetencion.Controls.Add(Me.lblConcepto)
            Me.gbRetencion.Controls.Add(Me.lblImpuesto)
            Me.gbRetencion.Controls.Add(Me.lblTotalRetencion)
            Me.gbRetencion.Controls.Add(Me.txtTotalComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblNroRetencion)
            Me.gbRetencion.Controls.Add(Me.txtNumeroComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblFechaRetencion)
            Me.gbRetencion.Controls.Add(Me.lblContribuyente)
            Me.gbRetencion.Enabled = False
            Me.gbRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetencion.Location = New System.Drawing.Point(1, 519)
            Me.gbRetencion.Name = "gbRetencion"
            Me.gbRetencion.Size = New System.Drawing.Size(790, 69)
            Me.gbRetencion.TabIndex = 72
            Me.gbRetencion.TabStop = False
            Me.gbRetencion.Text = "RETENCIÓN"
            '
            'cmbBienServicio
            '
            Me.cmbBienServicio.BackColor = System.Drawing.Color.White
            Me.cmbBienServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBienServicio.DropDownWidth = 100
            Me.cmbBienServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBienServicio.FormattingEnabled = True
            Me.cmbBienServicio.Items.AddRange(New Object() {"BIEN", "SERV."})
            Me.cmbBienServicio.Location = New System.Drawing.Point(681, 43)
            Me.cmbBienServicio.Name = "cmbBienServicio"
            Me.cmbBienServicio.Size = New System.Drawing.Size(102, 21)
            Me.cmbBienServicio.TabIndex = 53
            '
            'btnEliminarImpuesto
            '
            Me.btnEliminarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnEliminarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnEliminarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminarImpuesto.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminarImpuesto.Location = New System.Drawing.Point(747, 14)
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
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(242, 43)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(163, 21)
            Me.cmbConcepto.TabIndex = 45
            '
            'cmbImpuesto
            '
            Me.cmbImpuesto.BackColor = System.Drawing.Color.White
            Me.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbImpuesto.FormattingEnabled = True
            Me.cmbImpuesto.Location = New System.Drawing.Point(72, 43)
            Me.cmbImpuesto.Name = "cmbImpuesto"
            Me.cmbImpuesto.Size = New System.Drawing.Size(89, 21)
            Me.cmbImpuesto.TabIndex = 44
            '
            'cmbContribuyente
            '
            Me.cmbContribuyente.BackColor = System.Drawing.Color.White
            Me.cmbContribuyente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbContribuyente.DropDownWidth = 300
            Me.cmbContribuyente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbContribuyente.FormattingEnabled = True
            Me.cmbContribuyente.Location = New System.Drawing.Point(548, 43)
            Me.cmbContribuyente.Name = "cmbContribuyente"
            Me.cmbContribuyente.Size = New System.Drawing.Size(123, 21)
            Me.cmbContribuyente.TabIndex = 46
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Enabled = False
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(274, 16)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(129, 21)
            Me.dtpComprobanteRetencion.TabIndex = 42
            Me.dtpComprobanteRetencion.Value = New Date(2019, 11, 22, 0, 0, 0, 0)
            '
            'btnAgregarImpuesto
            '
            Me.btnAgregarImpuesto.BackColor = System.Drawing.Color.White
            Me.btnAgregarImpuesto.FlatAppearance.BorderSize = 0
            Me.btnAgregarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarImpuesto.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarImpuesto.Location = New System.Drawing.Point(713, 13)
            Me.btnAgregarImpuesto.Name = "btnAgregarImpuesto"
            Me.btnAgregarImpuesto.Size = New System.Drawing.Size(27, 27)
            Me.btnAgregarImpuesto.TabIndex = 47
            Me.btnAgregarImpuesto.UseVisualStyleBackColor = False
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Location = New System.Drawing.Point(178, 47)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(68, 13)
            Me.lblConcepto.TabIndex = 50
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'lblImpuesto
            '
            Me.lblImpuesto.AutoSize = True
            Me.lblImpuesto.Location = New System.Drawing.Point(7, 47)
            Me.lblImpuesto.Name = "lblImpuesto"
            Me.lblImpuesto.Size = New System.Drawing.Size(65, 13)
            Me.lblImpuesto.TabIndex = 48
            Me.lblImpuesto.Text = "IMPUESTO:"
            '
            'lblTotalRetencion
            '
            Me.lblTotalRetencion.AutoSize = True
            Me.lblTotalRetencion.Location = New System.Drawing.Point(426, 19)
            Me.lblTotalRetencion.Name = "lblTotalRetencion"
            Me.lblTotalRetencion.Size = New System.Drawing.Size(108, 13)
            Me.lblTotalRetencion.TabIndex = 44
            Me.lblTotalRetencion.Text = "TOTAL RETENCIÓN:"
            '
            'txtTotalComprobanteRetencion
            '
            Me.txtTotalComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteRetencion.Enabled = False
            Me.txtTotalComprobanteRetencion.Location = New System.Drawing.Point(548, 16)
            Me.txtTotalComprobanteRetencion.Name = "txtTotalComprobanteRetencion"
            Me.txtTotalComprobanteRetencion.Size = New System.Drawing.Size(123, 21)
            Me.txtTotalComprobanteRetencion.TabIndex = 43
            Me.txtTotalComprobanteRetencion.Text = "0.00"
            Me.txtTotalComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNroRetencion
            '
            Me.lblNroRetencion.AutoSize = True
            Me.lblNroRetencion.Location = New System.Drawing.Point(6, 19)
            Me.lblNroRetencion.Name = "lblNroRetencion"
            Me.lblNroRetencion.Size = New System.Drawing.Size(33, 13)
            Me.lblNroRetencion.TabIndex = 28
            Me.lblNroRetencion.Text = "NRO:"
            '
            'txtNumeroComprobanteRetencion
            '
            Me.txtNumeroComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteRetencion.Location = New System.Drawing.Point(43, 16)
            Me.txtNumeroComprobanteRetencion.Name = "txtNumeroComprobanteRetencion"
            Me.txtNumeroComprobanteRetencion.Size = New System.Drawing.Size(117, 21)
            Me.txtNumeroComprobanteRetencion.TabIndex = 41
            '
            'lblFechaRetencion
            '
            Me.lblFechaRetencion.AutoSize = True
            Me.lblFechaRetencion.Location = New System.Drawing.Point(181, 19)
            Me.lblFechaRetencion.Name = "lblFechaRetencion"
            Me.lblFechaRetencion.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaRetencion.TabIndex = 46
            Me.lblFechaRetencion.Text = "FECHA:"
            '
            'lblContribuyente
            '
            Me.lblContribuyente.AutoSize = True
            Me.lblContribuyente.Location = New System.Drawing.Point(430, 47)
            Me.lblContribuyente.Name = "lblContribuyente"
            Me.lblContribuyente.Size = New System.Drawing.Size(98, 13)
            Me.lblContribuyente.TabIndex = 52
            Me.lblContribuyente.Text = "CONTRIBUYENTE:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(1, 588)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
            Me.GroupBox1.Size = New System.Drawing.Size(789, 103)
            Me.GroupBox1.TabIndex = 70
            Me.GroupBox1.TabStop = False
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle46
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobanteRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle47.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle47
            Me.dgvDetalleComprobanteRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetalleComprobanteRetencion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleComprobanteRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(2, 17)
            Me.dgvDetalleComprobanteRetencion.MultiSelect = False
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(785, 83)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 49
            '
            'EjercicioFiscal
            '
            DataGridViewCellStyle48.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EjercicioFiscal.DefaultCellStyle = DataGridViewCellStyle48
            Me.EjercicioFiscal.HeaderText = "AÑO"
            Me.EjercicioFiscal.Name = "EjercicioFiscal"
            Me.EjercicioFiscal.ReadOnly = True
            Me.EjercicioFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.EjercicioFiscal.Width = 60
            '
            'CodigoRetencion
            '
            DataGridViewCellStyle49.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodigoRetencion.DefaultCellStyle = DataGridViewCellStyle49
            Me.CodigoRetencion.HeaderText = "CODIGO"
            Me.CodigoRetencion.Name = "CodigoRetencion"
            Me.CodigoRetencion.ReadOnly = True
            Me.CodigoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CodigoRetencion.Width = 60
            '
            'BaseImponible
            '
            DataGridViewCellStyle50.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BaseImponible.DefaultCellStyle = DataGridViewCellStyle50
            Me.BaseImponible.HeaderText = "BASE IMPONIBLE"
            Me.BaseImponible.Name = "BaseImponible"
            Me.BaseImponible.ReadOnly = True
            Me.BaseImponible.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BaseImponible.Width = 70
            '
            'Impuesto
            '
            DataGridViewCellStyle51.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle51
            Me.Impuesto.HeaderText = "IMPUESTO"
            Me.Impuesto.Name = "Impuesto"
            Me.Impuesto.ReadOnly = True
            Me.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Impuesto.Width = 60
            '
            'PorcentajeRetencion
            '
            DataGridViewCellStyle52.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PorcentajeRetencion.DefaultCellStyle = DataGridViewCellStyle52
            Me.PorcentajeRetencion.HeaderText = "%"
            Me.PorcentajeRetencion.Name = "PorcentajeRetencion"
            Me.PorcentajeRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.PorcentajeRetencion.Width = 60
            '
            'ValorRetenido
            '
            DataGridViewCellStyle53.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ValorRetenido.DefaultCellStyle = DataGridViewCellStyle53
            Me.ValorRetenido.HeaderText = "VALOR"
            Me.ValorRetenido.Name = "ValorRetenido"
            Me.ValorRetenido.ReadOnly = True
            Me.ValorRetenido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ValorRetenido.Width = 70
            '
            'Column1
            '
            DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle54
            Me.Column1.HeaderText = "CODIGO"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            Me.Column2.DefaultCellStyle = DataGridViewCellStyle55
            Me.Column2.HeaderText = "CUENTA"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 350
            '
            'gbDatosEspecialesComprobanteCompra
            '
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.bntBuscarMod)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label1)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtRazModComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label32)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtDocModComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.lblGuiaRemisionFacturaCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.txtGuiaRemisionComprobanteCompra)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label5)
            Me.gbDatosEspecialesComprobanteCompra.Controls.Add(Me.Label9)
            Me.gbDatosEspecialesComprobanteCompra.Enabled = False
            Me.gbDatosEspecialesComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosEspecialesComprobanteCompra.Location = New System.Drawing.Point(1, 200)
            Me.gbDatosEspecialesComprobanteCompra.Name = "gbDatosEspecialesComprobanteCompra"
            Me.gbDatosEspecialesComprobanteCompra.Size = New System.Drawing.Size(239, 102)
            Me.gbDatosEspecialesComprobanteCompra.TabIndex = 71
            Me.gbDatosEspecialesComprobanteCompra.TabStop = False
            '
            'bntBuscarMod
            '
            Me.bntBuscarMod.BackColor = System.Drawing.Color.White
            Me.bntBuscarMod.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
            Me.bntBuscarMod.FlatAppearance.BorderSize = 0
            Me.bntBuscarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntBuscarMod.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntBuscarMod.ForeColor = System.Drawing.Color.Black
            Me.bntBuscarMod.Image = Global.syscisepro.My.Resources.Resources.attach_file_24dp_FILL0_wght400_GRAD0_opsz24
            Me.bntBuscarMod.Location = New System.Drawing.Point(206, 40)
            Me.bntBuscarMod.Name = "bntBuscarMod"
            Me.bntBuscarMod.Size = New System.Drawing.Size(27, 27)
            Me.bntBuscarMod.TabIndex = 66
            Me.bntBuscarMod.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 74)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 13)
            Me.Label1.TabIndex = 65
            Me.Label1.Text = "AUT SRI MODIF:"
            '
            'txtRazModComprobanteCompra
            '
            Me.txtRazModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtRazModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazModComprobanteCompra.Location = New System.Drawing.Point(98, 71)
            Me.txtRazModComprobanteCompra.Name = "txtRazModComprobanteCompra"
            Me.txtRazModComprobanteCompra.Size = New System.Drawing.Size(132, 21)
            Me.txtRazModComprobanteCompra.TabIndex = 25
            Me.txtRazModComprobanteCompra.Text = "0"
            Me.txtRazModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(4, 45)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(74, 13)
            Me.Label32.TabIndex = 63
            Me.Label32.Text = "DOC. MODIF.:"
            '
            'txtDocModComprobanteCompra
            '
            Me.txtDocModComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtDocModComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDocModComprobanteCompra.Location = New System.Drawing.Point(98, 42)
            Me.txtDocModComprobanteCompra.Name = "txtDocModComprobanteCompra"
            Me.txtDocModComprobanteCompra.Size = New System.Drawing.Size(102, 21)
            Me.txtDocModComprobanteCompra.TabIndex = 24
            Me.txtDocModComprobanteCompra.Text = "000"
            Me.txtDocModComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblGuiaRemisionFacturaCompra
            '
            Me.lblGuiaRemisionFacturaCompra.AutoSize = True
            Me.lblGuiaRemisionFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuiaRemisionFacturaCompra.Location = New System.Drawing.Point(4, 14)
            Me.lblGuiaRemisionFacturaCompra.Name = "lblGuiaRemisionFacturaCompra"
            Me.lblGuiaRemisionFacturaCompra.Size = New System.Drawing.Size(90, 13)
            Me.lblGuiaRemisionFacturaCompra.TabIndex = 57
            Me.lblGuiaRemisionFacturaCompra.Text = "GUIA REMISIÓN:"
            '
            'txtGuiaRemisionComprobanteCompra
            '
            Me.txtGuiaRemisionComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtGuiaRemisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGuiaRemisionComprobanteCompra.Location = New System.Drawing.Point(98, 11)
            Me.txtGuiaRemisionComprobanteCompra.Name = "txtGuiaRemisionComprobanteCompra"
            Me.txtGuiaRemisionComprobanteCompra.Size = New System.Drawing.Size(132, 21)
            Me.txtGuiaRemisionComprobanteCompra.TabIndex = 23
            Me.txtGuiaRemisionComprobanteCompra.Text = "000"
            Me.txtGuiaRemisionComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label5.Location = New System.Drawing.Point(4, 26)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(192, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "_____________________________________"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label9.Location = New System.Drawing.Point(4, 55)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(192, 13)
            Me.Label9.TabIndex = 59
            Me.Label9.Text = "_____________________________________"
            '
            'chkActivarRetencion
            '
            Me.chkActivarRetencion.AutoSize = True
            Me.chkActivarRetencion.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.chkActivarRetencion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
            Me.chkActivarRetencion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.chkActivarRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkActivarRetencion.Location = New System.Drawing.Point(9, 76)
            Me.chkActivarRetencion.Name = "chkActivarRetencion"
            Me.chkActivarRetencion.Size = New System.Drawing.Size(235, 17)
            Me.chkActivarRetencion.TabIndex = 31
            Me.chkActivarRetencion.Text = "ACTIVAR COMPROBANTE DE RETENCIÓN"
            Me.chkActivarRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkActivarRetencion.UseVisualStyleBackColor = True
            '
            'Label45
            '
            Me.Label45.AutoSize = True
            Me.Label45.Font = New System.Drawing.Font("Segoe UI", 7.0!)
            Me.Label45.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label45.Location = New System.Drawing.Point(352, 56)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(129, 12)
            Me.Label45.TabIndex = 61
            Me.Label45.Text = "_______________________________"
            '
            'lblFechaEmisionFacturaCompra
            '
            Me.lblFechaEmisionFacturaCompra.AutoSize = True
            Me.lblFechaEmisionFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaEmisionFacturaCompra.Location = New System.Drawing.Point(348, 45)
            Me.lblFechaEmisionFacturaCompra.Name = "lblFechaEmisionFacturaCompra"
            Me.lblFechaEmisionFacturaCompra.Size = New System.Drawing.Size(92, 13)
            Me.lblFechaEmisionFacturaCompra.TabIndex = 55
            Me.lblFechaEmisionFacturaCompra.Text = "FECHA EMISIÓN:"
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(441, 40)
            Me.dtpFechaEmisionComprobanteCompra.MinDate = New Date(2014, 9, 1, 0, 0, 0, 0)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(98, 21)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 30
            '
            'gbValoresComprobanteCompra
            '
            Me.gbValoresComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal5FacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal5ComprabanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIva5ComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIva5)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtDescuentoFacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal0FacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubtotal12FacturaCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtSubTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtTotalComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.txtIvaComprobanteCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubTotal)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblTotalOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblIva)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblDescuentoOrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotal0OrdenCompra)
            Me.gbValoresComprobanteCompra.Controls.Add(Me.lblSubtotalIva)
            Me.gbValoresComprobanteCompra.Enabled = False
            Me.gbValoresComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbValoresComprobanteCompra.Location = New System.Drawing.Point(586, 307)
            Me.gbValoresComprobanteCompra.Name = "gbValoresComprobanteCompra"
            Me.gbValoresComprobanteCompra.Size = New System.Drawing.Size(204, 212)
            Me.gbValoresComprobanteCompra.TabIndex = 70
            Me.gbValoresComprobanteCompra.TabStop = False
            '
            'txtSubtotal5FacturaCompra
            '
            Me.txtSubtotal5FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal5FacturaCompra.Enabled = False
            Me.txtSubtotal5FacturaCompra.Location = New System.Drawing.Point(96, 56)
            Me.txtSubtotal5FacturaCompra.Name = "txtSubtotal5FacturaCompra"
            Me.txtSubtotal5FacturaCompra.Size = New System.Drawing.Size(106, 21)
            Me.txtSubtotal5FacturaCompra.TabIndex = 43
            Me.txtSubtotal5FacturaCompra.Text = "0.00"
            Me.txtSubtotal5FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubtotal5ComprabanteCompra
            '
            Me.lblSubtotal5ComprabanteCompra.AutoSize = True
            Me.lblSubtotal5ComprabanteCompra.Location = New System.Drawing.Point(7, 59)
            Me.lblSubtotal5ComprabanteCompra.Name = "lblSubtotal5ComprabanteCompra"
            Me.lblSubtotal5ComprabanteCompra.Size = New System.Drawing.Size(86, 13)
            Me.lblSubtotal5ComprabanteCompra.TabIndex = 42
            Me.lblSubtotal5ComprabanteCompra.Text = "SUB TOTAL 5%:"
            '
            'txtIva5ComprobanteCompra
            '
            Me.txtIva5ComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIva5ComprobanteCompra.Enabled = False
            Me.txtIva5ComprobanteCompra.Location = New System.Drawing.Point(96, 154)
            Me.txtIva5ComprobanteCompra.Name = "txtIva5ComprobanteCompra"
            Me.txtIva5ComprobanteCompra.Size = New System.Drawing.Size(104, 21)
            Me.txtIva5ComprobanteCompra.TabIndex = 41
            Me.txtIva5ComprobanteCompra.Text = "0.00"
            Me.txtIva5ComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblIva5
            '
            Me.lblIva5.AutoSize = True
            Me.lblIva5.Location = New System.Drawing.Point(4, 163)
            Me.lblIva5.Name = "lblIva5"
            Me.lblIva5.Size = New System.Drawing.Size(44, 13)
            Me.lblIva5.TabIndex = 40
            Me.lblIva5.Text = "IVA 5%:"
            '
            'txtDescuentoFacturaCompra
            '
            Me.txtDescuentoFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtDescuentoFacturaCompra.Enabled = False
            Me.txtDescuentoFacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoFacturaCompra.Location = New System.Drawing.Point(96, 82)
            Me.txtDescuentoFacturaCompra.Name = "txtDescuentoFacturaCompra"
            Me.txtDescuentoFacturaCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtDescuentoFacturaCompra.TabIndex = 36
            Me.txtDescuentoFacturaCompra.Text = "0.00"
            Me.txtDescuentoFacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal0FacturaCompra
            '
            Me.txtSubtotal0FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal0FacturaCompra.Enabled = False
            Me.txtSubtotal0FacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal0FacturaCompra.Location = New System.Drawing.Point(96, 33)
            Me.txtSubtotal0FacturaCompra.Name = "txtSubtotal0FacturaCompra"
            Me.txtSubtotal0FacturaCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtSubtotal0FacturaCompra.TabIndex = 35
            Me.txtSubtotal0FacturaCompra.Text = "0.00"
            Me.txtSubtotal0FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubtotal12FacturaCompra
            '
            Me.txtSubtotal12FacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtSubtotal12FacturaCompra.Enabled = False
            Me.txtSubtotal12FacturaCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubtotal12FacturaCompra.Location = New System.Drawing.Point(96, 10)
            Me.txtSubtotal12FacturaCompra.Name = "txtSubtotal12FacturaCompra"
            Me.txtSubtotal12FacturaCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtSubtotal12FacturaCompra.TabIndex = 34
            Me.txtSubtotal12FacturaCompra.Text = "0.00"
            Me.txtSubtotal12FacturaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSubTotalComprobanteCompra
            '
            Me.txtSubTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtSubTotalComprobanteCompra.Enabled = False
            Me.txtSubTotalComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSubTotalComprobanteCompra.Location = New System.Drawing.Point(96, 106)
            Me.txtSubTotalComprobanteCompra.Name = "txtSubTotalComprobanteCompra"
            Me.txtSubTotalComprobanteCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtSubTotalComprobanteCompra.TabIndex = 37
            Me.txtSubTotalComprobanteCompra.Text = "0.00"
            Me.txtSubTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalComprobanteCompra
            '
            Me.txtTotalComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtTotalComprobanteCompra.Enabled = False
            Me.txtTotalComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalComprobanteCompra.Location = New System.Drawing.Point(97, 180)
            Me.txtTotalComprobanteCompra.Name = "txtTotalComprobanteCompra"
            Me.txtTotalComprobanteCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtTotalComprobanteCompra.TabIndex = 39
            Me.txtTotalComprobanteCompra.Text = "0.00"
            Me.txtTotalComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtIvaComprobanteCompra
            '
            Me.txtIvaComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtIvaComprobanteCompra.Enabled = False
            Me.txtIvaComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIvaComprobanteCompra.Location = New System.Drawing.Point(97, 130)
            Me.txtIvaComprobanteCompra.Name = "txtIvaComprobanteCompra"
            Me.txtIvaComprobanteCompra.Size = New System.Drawing.Size(105, 22)
            Me.txtIvaComprobanteCompra.TabIndex = 38
            Me.txtIvaComprobanteCompra.Text = "0.00"
            Me.txtIvaComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblSubTotal
            '
            Me.lblSubTotal.AutoSize = True
            Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubTotal.Location = New System.Drawing.Point(5, 109)
            Me.lblSubTotal.Name = "lblSubTotal"
            Me.lblSubTotal.Size = New System.Drawing.Size(64, 13)
            Me.lblSubTotal.TabIndex = 20
            Me.lblSubTotal.Text = "SUB TOTAL:"
            '
            'lblTotalOrdenCompra
            '
            Me.lblTotalOrdenCompra.AutoSize = True
            Me.lblTotalOrdenCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalOrdenCompra.Location = New System.Drawing.Point(5, 184)
            Me.lblTotalOrdenCompra.Name = "lblTotalOrdenCompra"
            Me.lblTotalOrdenCompra.Size = New System.Drawing.Size(41, 13)
            Me.lblTotalOrdenCompra.TabIndex = 14
            Me.lblTotalOrdenCompra.Text = "TOTAL:"
            '
            'lblIva
            '
            Me.lblIva.AutoSize = True
            Me.lblIva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIva.Location = New System.Drawing.Point(5, 134)
            Me.lblIva.Name = "lblIva"
            Me.lblIva.Size = New System.Drawing.Size(56, 13)
            Me.lblIva.TabIndex = 13
            Me.lblIva.Text = "IVA (12%):"
            '
            'lblDescuentoOrdenCompra
            '
            Me.lblDescuentoOrdenCompra.AutoSize = True
            Me.lblDescuentoOrdenCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDescuentoOrdenCompra.Location = New System.Drawing.Point(6, 85)
            Me.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra"
            Me.lblDescuentoOrdenCompra.Size = New System.Drawing.Size(73, 13)
            Me.lblDescuentoOrdenCompra.TabIndex = 12
            Me.lblDescuentoOrdenCompra.Text = "DESCUENTO:"
            '
            'lblSubtotal0OrdenCompra
            '
            Me.lblSubtotal0OrdenCompra.AutoSize = True
            Me.lblSubtotal0OrdenCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotal0OrdenCompra.Location = New System.Drawing.Point(6, 35)
            Me.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra"
            Me.lblSubtotal0OrdenCompra.Size = New System.Drawing.Size(82, 13)
            Me.lblSubtotal0OrdenCompra.TabIndex = 11
            Me.lblSubtotal0OrdenCompra.Text = "SUB TOTAL 0%:"
            '
            'lblSubtotalIva
            '
            Me.lblSubtotalIva.AutoSize = True
            Me.lblSubtotalIva.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtotalIva.Location = New System.Drawing.Point(7, 12)
            Me.lblSubtotalIva.Name = "lblSubtotalIva"
            Me.lblSubtotalIva.Size = New System.Drawing.Size(88, 13)
            Me.lblSubtotalIva.TabIndex = 10
            Me.lblSubtotalIva.Text = "SUB TOTAL 12%:"
            '
            'gbDatosComprobanteCompra
            '
            Me.gbDatosComprobanteCompra.Controls.Add(Me.btnOrdenCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblOrdenCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.chkReq)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.btnBuscar)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaEmisionFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumAutoSRIFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.txtNumAutoSRIComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblNumeroFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.dtpFechaAutoSRIComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.chkActivarRetencion)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label45)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.txtNumeroComprobanteCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblFechaAutoSRIFacturaCompra)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblSeparadorRUC)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.lblSeparadorNumFact)
            Me.gbDatosComprobanteCompra.Controls.Add(Me.Label37)
            Me.gbDatosComprobanteCompra.Enabled = False
            Me.gbDatosComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosComprobanteCompra.Location = New System.Drawing.Point(240, 200)
            Me.gbDatosComprobanteCompra.Name = "gbDatosComprobanteCompra"
            Me.gbDatosComprobanteCompra.Size = New System.Drawing.Size(550, 102)
            Me.gbDatosComprobanteCompra.TabIndex = 69
            Me.gbDatosComprobanteCompra.TabStop = False
            '
            'btnOrdenCompra
            '
            Me.btnOrdenCompra.Enabled = False
            Me.btnOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOrdenCompra.Location = New System.Drawing.Point(434, 70)
            Me.btnOrdenCompra.Name = "btnOrdenCompra"
            Me.btnOrdenCompra.Size = New System.Drawing.Size(26, 22)
            Me.btnOrdenCompra.TabIndex = 118
            Me.btnOrdenCompra.Tag = "1"
            Me.btnOrdenCompra.Text = "..."
            Me.btnOrdenCompra.UseVisualStyleBackColor = True
            '
            'lblOrdenCompra
            '
            Me.lblOrdenCompra.AutoSize = True
            Me.lblOrdenCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOrdenCompra.Location = New System.Drawing.Point(400, 76)
            Me.lblOrdenCompra.Name = "lblOrdenCompra"
            Me.lblOrdenCompra.Size = New System.Drawing.Size(28, 13)
            Me.lblOrdenCompra.TabIndex = 62
            Me.lblOrdenCompra.Text = "###"
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkReq.Location = New System.Drawing.Point(304, 74)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(93, 17)
            Me.chkReq.TabIndex = 63
            Me.chkReq.Text = "ÓRDEN C. N°:"
            Me.chkReq.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.White
            Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 7.0!)
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.attach_file_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnBuscar.Location = New System.Drawing.Point(286, 11)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(27, 27)
            Me.btnBuscar.TabIndex = 27
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'lblNumAutoSRIFacturaCompra
            '
            Me.lblNumAutoSRIFacturaCompra.AutoSize = True
            Me.lblNumAutoSRIFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAutoSRIFacturaCompra.Location = New System.Drawing.Point(5, 45)
            Me.lblNumAutoSRIFacturaCompra.Name = "lblNumAutoSRIFacturaCompra"
            Me.lblNumAutoSRIFacturaCompra.Size = New System.Drawing.Size(53, 13)
            Me.lblNumAutoSRIFacturaCompra.TabIndex = 28
            Me.lblNumAutoSRIFacturaCompra.Text = "AUT. SRI:"
            '
            'txtNumAutoSRIComprobanteCompra
            '
            Me.txtNumAutoSRIComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoSRIComprobanteCompra.Location = New System.Drawing.Point(67, 41)
            Me.txtNumAutoSRIComprobanteCompra.Name = "txtNumAutoSRIComprobanteCompra"
            Me.txtNumAutoSRIComprobanteCompra.Size = New System.Drawing.Size(212, 21)
            Me.txtNumAutoSRIComprobanteCompra.TabIndex = 28
            Me.txtNumAutoSRIComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblNumeroFacturaCompra
            '
            Me.lblNumeroFacturaCompra.AutoSize = True
            Me.lblNumeroFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroFacturaCompra.Location = New System.Drawing.Point(5, 15)
            Me.lblNumeroFacturaCompra.Name = "lblNumeroFacturaCompra"
            Me.lblNumeroFacturaCompra.Size = New System.Drawing.Size(54, 13)
            Me.lblNumeroFacturaCompra.TabIndex = 26
            Me.lblNumeroFacturaCompra.Text = "Nº FACT.:"
            '
            'dtpFechaAutoSRIComprobanteCompra
            '
            Me.dtpFechaAutoSRIComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAutoSRIComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAutoSRIComprobanteCompra.Location = New System.Drawing.Point(441, 12)
            Me.dtpFechaAutoSRIComprobanteCompra.Name = "dtpFechaAutoSRIComprobanteCompra"
            Me.dtpFechaAutoSRIComprobanteCompra.Size = New System.Drawing.Size(98, 21)
            Me.dtpFechaAutoSRIComprobanteCompra.TabIndex = 29
            '
            'txtNumeroComprobanteCompra
            '
            Me.txtNumeroComprobanteCompra.BackColor = System.Drawing.Color.White
            Me.txtNumeroComprobanteCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroComprobanteCompra.Location = New System.Drawing.Point(67, 12)
            Me.txtNumeroComprobanteCompra.Name = "txtNumeroComprobanteCompra"
            Me.txtNumeroComprobanteCompra.Size = New System.Drawing.Size(213, 21)
            Me.txtNumeroComprobanteCompra.TabIndex = 26
            Me.txtNumeroComprobanteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblFechaAutoSRIFacturaCompra
            '
            Me.lblFechaAutoSRIFacturaCompra.AutoSize = True
            Me.lblFechaAutoSRIFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaAutoSRIFacturaCompra.Location = New System.Drawing.Point(348, 16)
            Me.lblFechaAutoSRIFacturaCompra.Name = "lblFechaAutoSRIFacturaCompra"
            Me.lblFechaAutoSRIFacturaCompra.Size = New System.Drawing.Size(78, 13)
            Me.lblFechaAutoSRIFacturaCompra.TabIndex = 54
            Me.lblFechaAutoSRIFacturaCompra.Text = "FECHA AUTO.:"
            '
            'lblSeparadorRUC
            '
            Me.lblSeparadorRUC.AutoSize = True
            Me.lblSeparadorRUC.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSeparadorRUC.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.lblSeparadorRUC.Location = New System.Drawing.Point(7, 27)
            Me.lblSeparadorRUC.Name = "lblSeparadorRUC"
            Me.lblSeparadorRUC.Size = New System.Drawing.Size(217, 13)
            Me.lblSeparadorRUC.TabIndex = 30
            Me.lblSeparadorRUC.Text = "__________________________________________"
            '
            'lblSeparadorNumFact
            '
            Me.lblSeparadorNumFact.AutoSize = True
            Me.lblSeparadorNumFact.Font = New System.Drawing.Font("Segoe UI", 7.0!)
            Me.lblSeparadorNumFact.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.lblSeparadorNumFact.Location = New System.Drawing.Point(7, 56)
            Me.lblSeparadorNumFact.Name = "lblSeparadorNumFact"
            Me.lblSeparadorNumFact.Size = New System.Drawing.Size(173, 12)
            Me.lblSeparadorNumFact.TabIndex = 31
            Me.lblSeparadorNumFact.Text = "__________________________________________"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Segoe UI", 7.0!)
            Me.Label37.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.Label37.Location = New System.Drawing.Point(348, 28)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(129, 12)
            Me.Label37.TabIndex = 56
            Me.Label37.Text = "_______________________________"
            '
            'gbDatosProveedor
            '
            Me.gbDatosProveedor.BackColor = System.Drawing.Color.White
            Me.gbDatosProveedor.Controls.Add(Me.txtContribuyenteEspecialProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.txtObligadoLlevarContabilidadProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.txtNumAutoContEspFacturaCompra)
            Me.gbDatosProveedor.Controls.Add(Me.lblNumAutoContEspFacturaCompra)
            Me.gbDatosProveedor.Controls.Add(Me.lblContabilidadProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.lblContribuyenteEspecialProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.txtCiudadProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.lblCiudadProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.txtEmailProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.Label2)
            Me.gbDatosProveedor.Controls.Add(Me.txtTelefonoProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.txtDireccionProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.lblTelefono1ProveedorGeneral)
            Me.gbDatosProveedor.Controls.Add(Me.lblDireccionProveedorGeneral)
            Me.gbDatosProveedor.Enabled = False
            Me.gbDatosProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDatosProveedor.Location = New System.Drawing.Point(1, 120)
            Me.gbDatosProveedor.Name = "gbDatosProveedor"
            Me.gbDatosProveedor.Size = New System.Drawing.Size(790, 87)
            Me.gbDatosProveedor.TabIndex = 82
            Me.gbDatosProveedor.TabStop = False
            '
            'txtContribuyenteEspecialProveedorGeneral
            '
            Me.txtContribuyenteEspecialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(330, 61)
            Me.txtContribuyenteEspecialProveedorGeneral.Name = "txtContribuyenteEspecialProveedorGeneral"
            Me.txtContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(54, 21)
            Me.txtContribuyenteEspecialProveedorGeneral.TabIndex = 21
            '
            'txtObligadoLlevarContabilidadProveedorGeneral
            '
            Me.txtObligadoLlevarContabilidadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Location = New System.Drawing.Point(131, 61)
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Name = "txtObligadoLlevarContabilidadProveedorGeneral"
            Me.txtObligadoLlevarContabilidadProveedorGeneral.Size = New System.Drawing.Size(65, 21)
            Me.txtObligadoLlevarContabilidadProveedorGeneral.TabIndex = 20
            '
            'txtNumAutoContEspFacturaCompra
            '
            Me.txtNumAutoContEspFacturaCompra.BackColor = System.Drawing.Color.White
            Me.txtNumAutoContEspFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumAutoContEspFacturaCompra.Location = New System.Drawing.Point(713, 58)
            Me.txtNumAutoContEspFacturaCompra.Name = "txtNumAutoContEspFacturaCompra"
            Me.txtNumAutoContEspFacturaCompra.Size = New System.Drawing.Size(68, 21)
            Me.txtNumAutoContEspFacturaCompra.TabIndex = 22
            Me.txtNumAutoContEspFacturaCompra.Text = "0"
            '
            'lblNumAutoContEspFacturaCompra
            '
            Me.lblNumAutoContEspFacturaCompra.AutoSize = True
            Me.lblNumAutoContEspFacturaCompra.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumAutoContEspFacturaCompra.Location = New System.Drawing.Point(399, 63)
            Me.lblNumAutoContEspFacturaCompra.Name = "lblNumAutoContEspFacturaCompra"
            Me.lblNumAutoContEspFacturaCompra.Size = New System.Drawing.Size(235, 13)
            Me.lblNumAutoContEspFacturaCompra.TabIndex = 91
            Me.lblNumAutoContEspFacturaCompra.Text = "NUM. AUTORIZACIÓN CONTRIBUYENTE ESP.:"
            '
            'lblContabilidadProveedorGeneral
            '
            Me.lblContabilidadProveedorGeneral.AutoSize = True
            Me.lblContabilidadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContabilidadProveedorGeneral.Location = New System.Drawing.Point(8, 64)
            Me.lblContabilidadProveedorGeneral.Name = "lblContabilidadProveedorGeneral"
            Me.lblContabilidadProveedorGeneral.Size = New System.Drawing.Size(110, 13)
            Me.lblContabilidadProveedorGeneral.TabIndex = 89
            Me.lblContabilidadProveedorGeneral.Text = "OBLIG. LLEV. CONT.:"
            '
            'lblContribuyenteEspecialProveedorGeneral
            '
            Me.lblContribuyenteEspecialProveedorGeneral.AutoSize = True
            Me.lblContribuyenteEspecialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblContribuyenteEspecialProveedorGeneral.Location = New System.Drawing.Point(210, 64)
            Me.lblContribuyenteEspecialProveedorGeneral.Name = "lblContribuyenteEspecialProveedorGeneral"
            Me.lblContribuyenteEspecialProveedorGeneral.Size = New System.Drawing.Size(112, 13)
            Me.lblContribuyenteEspecialProveedorGeneral.TabIndex = 90
            Me.lblContribuyenteEspecialProveedorGeneral.Text = "CONTRIB. ESPECIAL:"
            '
            'txtCiudadProveedorGeneral
            '
            Me.txtCiudadProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtCiudadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCiudadProveedorGeneral.Location = New System.Drawing.Point(85, 36)
            Me.txtCiudadProveedorGeneral.Name = "txtCiudadProveedorGeneral"
            Me.txtCiudadProveedorGeneral.Size = New System.Drawing.Size(111, 21)
            Me.txtCiudadProveedorGeneral.TabIndex = 17
            '
            'lblCiudadProveedorGeneral
            '
            Me.lblCiudadProveedorGeneral.AutoSize = True
            Me.lblCiudadProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudadProveedorGeneral.Location = New System.Drawing.Point(8, 38)
            Me.lblCiudadProveedorGeneral.Name = "lblCiudadProveedorGeneral"
            Me.lblCiudadProveedorGeneral.Size = New System.Drawing.Size(48, 13)
            Me.lblCiudadProveedorGeneral.TabIndex = 76
            Me.lblCiudadProveedorGeneral.Text = "CIUDAD:"
            '
            'txtEmailProveedorGeneral
            '
            Me.txtEmailProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailProveedorGeneral.Location = New System.Drawing.Point(448, 36)
            Me.txtEmailProveedorGeneral.Name = "txtEmailProveedorGeneral"
            Me.txtEmailProveedorGeneral.Size = New System.Drawing.Size(333, 21)
            Me.txtEmailProveedorGeneral.TabIndex = 19
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(397, 39)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(45, 13)
            Me.Label2.TabIndex = 75
            Me.Label2.Text = "E-MAIL:"
            '
            'txtTelefonoProveedorGeneral
            '
            Me.txtTelefonoProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefonoProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefonoProveedorGeneral.Location = New System.Drawing.Point(270, 36)
            Me.txtTelefonoProveedorGeneral.Name = "txtTelefonoProveedorGeneral"
            Me.txtTelefonoProveedorGeneral.Size = New System.Drawing.Size(114, 21)
            Me.txtTelefonoProveedorGeneral.TabIndex = 18
            '
            'txtDireccionProveedorGeneral
            '
            Me.txtDireccionProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionProveedorGeneral.Location = New System.Drawing.Point(85, 12)
            Me.txtDireccionProveedorGeneral.Name = "txtDireccionProveedorGeneral"
            Me.txtDireccionProveedorGeneral.Size = New System.Drawing.Size(696, 21)
            Me.txtDireccionProveedorGeneral.TabIndex = 16
            '
            'lblTelefono1ProveedorGeneral
            '
            Me.lblTelefono1ProveedorGeneral.AutoSize = True
            Me.lblTelefono1ProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTelefono1ProveedorGeneral.Location = New System.Drawing.Point(210, 39)
            Me.lblTelefono1ProveedorGeneral.Name = "lblTelefono1ProveedorGeneral"
            Me.lblTelefono1ProveedorGeneral.Size = New System.Drawing.Size(62, 13)
            Me.lblTelefono1ProveedorGeneral.TabIndex = 73
            Me.lblTelefono1ProveedorGeneral.Text = "TELEFONO"
            '
            'lblDireccionProveedorGeneral
            '
            Me.lblDireccionProveedorGeneral.AutoSize = True
            Me.lblDireccionProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccionProveedorGeneral.Location = New System.Drawing.Point(8, 15)
            Me.lblDireccionProveedorGeneral.Name = "lblDireccionProveedorGeneral"
            Me.lblDireccionProveedorGeneral.Size = New System.Drawing.Size(66, 13)
            Me.lblDireccionProveedorGeneral.TabIndex = 74
            Me.lblDireccionProveedorGeneral.Text = "DIRECCIÓN:"
            '
            'gbRUCProveedor
            '
            Me.gbRUCProveedor.BackColor = System.Drawing.Color.White
            Me.gbRUCProveedor.Controls.Add(Me.txtRucProveedorGeneral)
            Me.gbRUCProveedor.Enabled = False
            Me.gbRUCProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRUCProveedor.Location = New System.Drawing.Point(1, 80)
            Me.gbRUCProveedor.Name = "gbRUCProveedor"
            Me.gbRUCProveedor.Size = New System.Drawing.Size(239, 42)
            Me.gbRUCProveedor.TabIndex = 80
            Me.gbRUCProveedor.TabStop = False
            Me.gbRUCProveedor.Text = "CI / RUC / PASAPORTE"
            '
            'txtRucProveedorGeneral
            '
            Me.txtRucProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucProveedorGeneral.Enabled = False
            Me.txtRucProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucProveedorGeneral.Location = New System.Drawing.Point(11, 14)
            Me.txtRucProveedorGeneral.Name = "txtRucProveedorGeneral"
            Me.txtRucProveedorGeneral.Size = New System.Drawing.Size(219, 20)
            Me.txtRucProveedorGeneral.TabIndex = 14
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(81, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "..."
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Enabled = False
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(239, 80)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(551, 42)
            Me.gbNombreComercialProveedor.TabIndex = 81
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(6, 14)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(536, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 15
            '
            'gbObservaciones
            '
            Me.gbObservaciones.BackColor = System.Drawing.Color.White
            Me.gbObservaciones.Controls.Add(Me.txtObservacionesComprobantesCompra)
            Me.gbObservaciones.Enabled = False
            Me.gbObservaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbObservaciones.Location = New System.Drawing.Point(1, 478)
            Me.gbObservaciones.Name = "gbObservaciones"
            Me.gbObservaciones.Size = New System.Drawing.Size(585, 41)
            Me.gbObservaciones.TabIndex = 83
            Me.gbObservaciones.TabStop = False
            Me.gbObservaciones.Text = "OBSERVACIONES"
            '
            'txtObservacionesComprobantesCompra
            '
            Me.txtObservacionesComprobantesCompra.BackColor = System.Drawing.Color.White
            Me.txtObservacionesComprobantesCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesComprobantesCompra.Location = New System.Drawing.Point(7, 14)
            Me.txtObservacionesComprobantesCompra.Name = "txtObservacionesComprobantesCompra"
            Me.txtObservacionesComprobantesCompra.Size = New System.Drawing.Size(570, 21)
            Me.txtObservacionesComprobantesCompra.TabIndex = 40
            '
            'gbConceptoCompra
            '
            Me.gbConceptoCompra.BackColor = System.Drawing.Color.White
            Me.gbConceptoCompra.Controls.Add(Me.cmbConceptoCompra)
            Me.gbConceptoCompra.Enabled = False
            Me.gbConceptoCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConceptoCompra.Location = New System.Drawing.Point(332, 7)
            Me.gbConceptoCompra.Name = "gbConceptoCompra"
            Me.gbConceptoCompra.Size = New System.Drawing.Size(181, 56)
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
            'gbTipoEmision
            '
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionNormal)
            Me.gbTipoEmision.Controls.Add(Me.Label20)
            Me.gbTipoEmision.Controls.Add(Me.gbConceptoCompra)
            Me.gbTipoEmision.Enabled = False
            Me.gbTipoEmision.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoEmision.Location = New System.Drawing.Point(448, -3)
            Me.gbTipoEmision.Name = "gbTipoEmision"
            Me.gbTipoEmision.Size = New System.Drawing.Size(349, 34)
            Me.gbTipoEmision.TabIndex = 88
            Me.gbTipoEmision.TabStop = False
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.Enabled = False
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(160, 9)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(133, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 6
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "INDISP DEL SISTEMA"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = True
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.Checked = True
            Me.rbTipoEmisionNormal.Enabled = False
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(91, 9)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(61, 17)
            Me.rbTipoEmisionNormal.TabIndex = 5
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "NORMAL"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = True
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(14, 9)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(63, 15)
            Me.Label20.TabIndex = 20
            Me.Label20.Text = "EMISIÓN:"
            '
            'gbTipoAnbiente
            '
            Me.gbTipoAnbiente.Controls.Add(Me.rbProduccion)
            Me.gbTipoAnbiente.Controls.Add(Me.Label18)
            Me.gbTipoAnbiente.Controls.Add(Me.rbPruebas)
            Me.gbTipoAnbiente.Enabled = False
            Me.gbTipoAnbiente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoAnbiente.Location = New System.Drawing.Point(220, -3)
            Me.gbTipoAnbiente.Name = "gbTipoAnbiente"
            Me.gbTipoAnbiente.Size = New System.Drawing.Size(228, 34)
            Me.gbTipoAnbiente.TabIndex = 89
            Me.gbTipoAnbiente.TabStop = False
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.Checked = True
            Me.rbProduccion.Enabled = False
            Me.rbProduccion.Location = New System.Drawing.Point(139, 9)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(85, 17)
            Me.rbProduccion.TabIndex = 4
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "PRODUCCIÓN"
            Me.rbProduccion.UseVisualStyleBackColor = True
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(4, 9)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(70, 15)
            Me.Label18.TabIndex = 15
            Me.Label18.Text = "AMBIENTE:"
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.Enabled = False
            Me.rbPruebas.Location = New System.Drawing.Point(74, 9)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(67, 17)
            Me.rbPruebas.TabIndex = 3
            Me.rbPruebas.Text = "PRUEBAS"
            Me.rbPruebas.UseVisualStyleBackColor = True
            '
            'gbPtoEmision
            '
            Me.gbPtoEmision.Controls.Add(Me.Label19)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision002)
            Me.gbPtoEmision.Controls.Add(Me.rbPtoEmision001)
            Me.gbPtoEmision.Enabled = False
            Me.gbPtoEmision.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbPtoEmision.Location = New System.Drawing.Point(1, -3)
            Me.gbPtoEmision.Name = "gbPtoEmision"
            Me.gbPtoEmision.Size = New System.Drawing.Size(220, 34)
            Me.gbPtoEmision.TabIndex = 91
            Me.gbPtoEmision.TabStop = False
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(4, 9)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(91, 15)
            Me.Label19.TabIndex = 16
            Me.Label19.Text = "PTO EMISIÓN:"
            '
            'rbPtoEmision002
            '
            Me.rbPtoEmision002.AutoSize = True
            Me.rbPtoEmision002.Checked = True
            Me.rbPtoEmision002.Location = New System.Drawing.Point(141, 9)
            Me.rbPtoEmision002.Name = "rbPtoEmision002"
            Me.rbPtoEmision002.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision002.TabIndex = 2
            Me.rbPtoEmision002.TabStop = True
            Me.rbPtoEmision002.Text = "002"
            Me.rbPtoEmision002.UseVisualStyleBackColor = True
            '
            'rbPtoEmision001
            '
            Me.rbPtoEmision001.AutoSize = True
            Me.rbPtoEmision001.Location = New System.Drawing.Point(98, 9)
            Me.rbPtoEmision001.Name = "rbPtoEmision001"
            Me.rbPtoEmision001.Size = New System.Drawing.Size(43, 17)
            Me.rbPtoEmision001.TabIndex = 1
            Me.rbPtoEmision001.Text = "001"
            Me.rbPtoEmision001.UseVisualStyleBackColor = True
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
            Me.GroupBox2.Location = New System.Drawing.Point(603, 307)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(130, 28)
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
            Me.cbxPorcentaje.Items.AddRange(New Object() {"0 %", "12 %", "15 %"})
            Me.cbxPorcentaje.Location = New System.Drawing.Point(109, 14)
            Me.cbxPorcentaje.Name = "cbxPorcentaje"
            Me.cbxPorcentaje.Size = New System.Drawing.Size(75, 21)
            Me.cbxPorcentaje.TabIndex = 33
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.dgvAsientosDiario)
            Me.GroupBox3.Enabled = False
            Me.GroupBox3.Location = New System.Drawing.Point(1, 307)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
            Me.GroupBox3.Size = New System.Drawing.Size(585, 171)
            Me.GroupBox3.TabIndex = 93
            Me.GroupBox3.TabStop = False
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle56
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle57.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle57
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.CODIGO, Me.CUENTA, Me.VALOR, Me.IVA, Me.PORCENTAJE})
            DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle60.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle60
            Me.dgvAsientosDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(2, 17)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(581, 152)
            Me.dgvAsientosDiario.TabIndex = 32
            '
            'eliminarItem
            '
            DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle58.BackColor = System.Drawing.Color.DarkRed
            DataGridViewCellStyle58.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.White
            Me.eliminarItem.DefaultCellStyle = DataGridViewCellStyle58
            Me.eliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.eliminarItem.HeaderText = "SUPR"
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
            Me.CODIGO.HeaderText = "CODIGO"
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.Width = 95
            '
            'CUENTA
            '
            DataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CUENTA.DefaultCellStyle = DataGridViewCellStyle59
            Me.CUENTA.HeaderText = "CUENTA"
            Me.CUENTA.Name = "CUENTA"
            Me.CUENTA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CUENTA.Width = 225
            '
            'VALOR
            '
            Me.VALOR.HeaderText = "VALOR"
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
            Me.PORCENTAJE.HeaderText = "PORCENTAJE"
            Me.PORCENTAJE.Items.AddRange(New Object() {"0", "5", "12", "15"})
            Me.PORCENTAJE.Name = "PORCENTAJE"
            '
            'FormRegistroComprobanteCompra
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(792, 694)
            Me.Controls.Add(Me.gbRetencion)
            Me.Controls.Add(Me.gbObservaciones)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.Controls.Add(Me.gbPtoEmision)
            Me.Controls.Add(Me.gbRUCProveedor)
            Me.Controls.Add(Me.gpComandos)
            Me.Controls.Add(Me.gbTipoEmision)
            Me.Controls.Add(Me.gbTipoAnbiente)
            Me.Controls.Add(Me.gbDatosProveedor)
            Me.Controls.Add(Me.gbDatosEspecialesComprobanteCompra)
            Me.Controls.Add(Me.gbDatosComprobanteCompra)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbValoresComprobanteCompra)
            Me.Controls.Add(Me.gbTipoComprobanteCompra)
            Me.Controls.Add(Me.GroupBox2)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "FormRegistroComprobanteCompra"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRAR COMPROBANTE DE COMPRA"
            Me.gpComandos.ResumeLayout(False)
            Me.gpComandos.PerformLayout()
            Me.gbTipoComprobanteCompra.ResumeLayout(False)
            Me.gbTipoComprobanteCompra.PerformLayout()
            Me.gbRetencion.ResumeLayout(False)
            Me.gbRetencion.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDatosEspecialesComprobanteCompra.ResumeLayout(False)
            Me.gbDatosEspecialesComprobanteCompra.PerformLayout()
            Me.gbValoresComprobanteCompra.ResumeLayout(False)
            Me.gbValoresComprobanteCompra.PerformLayout()
            Me.gbDatosComprobanteCompra.ResumeLayout(False)
            Me.gbDatosComprobanteCompra.PerformLayout()
            Me.gbDatosProveedor.ResumeLayout(False)
            Me.gbDatosProveedor.PerformLayout()
            Me.gbRUCProveedor.ResumeLayout(False)
            Me.gbRUCProveedor.PerformLayout()
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            Me.gbObservaciones.ResumeLayout(False)
            Me.gbObservaciones.PerformLayout()
            Me.gbConceptoCompra.ResumeLayout(False)
            Me.gbTipoEmision.ResumeLayout(False)
            Me.gbTipoEmision.PerformLayout()
            Me.gbTipoAnbiente.ResumeLayout(False)
            Me.gbTipoAnbiente.PerformLayout()
            Me.gbPtoEmision.ResumeLayout(False)
            Me.gbPtoEmision.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gpComandos As System.Windows.Forms.GroupBox
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents gbTipoComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
        Friend WithEvents cmbNombreParametroDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents gbRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnEliminarImpuesto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarImpuesto As System.Windows.Forms.Button
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents lblFechaRetencion As System.Windows.Forms.Label
        Friend WithEvents lblTotalRetencion As System.Windows.Forms.Label
        Friend WithEvents txtTotalComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents lblNroRetencion As System.Windows.Forms.Label
        Friend WithEvents txtNumeroComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents gbDatosEspecialesComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaEmisionFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblGuiaRemisionFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents txtGuiaRemisionComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents chkActivarRetencion As System.Windows.Forms.CheckBox
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
        Friend WithEvents lblIva As System.Windows.Forms.Label
        Friend WithEvents lblDescuentoOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotal0OrdenCompra As System.Windows.Forms.Label
        Friend WithEvents lblSubtotalIva As System.Windows.Forms.Label
        Friend WithEvents gbDatosComprobanteCompra As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumAutoSRIFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents txtNumAutoSRIComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblNumeroFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents dtpFechaAutoSRIComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaAutoSRIFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents lblSeparadorRUC As System.Windows.Forms.Label
        Friend WithEvents lblSeparadorNumFact As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents gbDatosProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtCiudadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblCiudadProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtEmailProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtTelefonoProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblTelefono1ProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblDireccionProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents gbRUCProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtRucProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtDocModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents txtContribuyenteEspecialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtObligadoLlevarContabilidadProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtNumAutoContEspFacturaCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblNumAutoContEspFacturaCompra As System.Windows.Forms.Label
        Friend WithEvents lblContabilidadProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents lblContribuyenteEspecialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtRazModComprobanteCompra As System.Windows.Forms.TextBox
        Friend WithEvents lblEtiquetaIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents gbObservaciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacionesComprobantesCompra As System.Windows.Forms.TextBox
        Friend WithEvents btnGuardarEnFondoRotativo As System.Windows.Forms.Button
        Friend WithEvents gbConceptoCompra As System.Windows.Forms.GroupBox
        Friend WithEvents cmbConceptoCompra As System.Windows.Forms.ComboBox
        Friend WithEvents lblContribuyente As System.Windows.Forms.Label
        Friend WithEvents cmbContribuyente As System.Windows.Forms.ComboBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents lblImpuesto As System.Windows.Forms.Label
        Friend WithEvents cmbImpuesto As System.Windows.Forms.ComboBox
        Friend WithEvents gbTipoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents gbTipoAnbiente As System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents gbPtoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents rbPtoEmision002 As System.Windows.Forms.RadioButton
        Friend WithEvents rbPtoEmision001 As System.Windows.Forms.RadioButton
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents ofdSeleccionarArchivo As System.Windows.Forms.OpenFileDialog
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents cbxPorcentaje As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents bntBuscarMod As System.Windows.Forms.Button
        Friend WithEvents lblOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents chkReq As System.Windows.Forms.CheckBox
        Friend WithEvents btnOrdenCompra As System.Windows.Forms.Button
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
        Friend WithEvents txtIva5ComprobanteCompra As TextBox
        Friend WithEvents lblIva5 As Label
        Friend WithEvents txtSubtotal5FacturaCompra As TextBox
        Friend WithEvents lblSubtotal5ComprabanteCompra As Label
        Friend WithEvents eliminarItem As DataGridViewButtonColumn
        Friend WithEvents CODIGO As DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As DataGridViewTextBoxColumn
        Friend WithEvents VALOR As DataGridViewTextBoxColumn
        Friend WithEvents IVA As DataGridViewTextBoxColumn
        Friend WithEvents PORCENTAJE As DataGridViewComboBoxColumn
    End Class
End Namespace