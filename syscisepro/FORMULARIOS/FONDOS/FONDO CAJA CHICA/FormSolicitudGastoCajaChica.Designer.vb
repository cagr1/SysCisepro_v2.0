Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormSolicitudGastoCajaChica
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudGastoCajaChica))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.btnControlCombustible = New System.Windows.Forms.Button()
            Me.txtTexto = New System.Windows.Forms.TextBox()
            Me.tcSolicitudCajaChica = New System.Windows.Forms.TabControl()
            Me.tpSolicitud = New System.Windows.Forms.TabPage()
            Me.txtFecha = New System.Windows.Forms.DateTimePicker()
            Me.gbRetenciones = New System.Windows.Forms.GroupBox()
            Me.btnDocumento = New System.Windows.Forms.Button()
            Me.lblNroDocumento = New System.Windows.Forms.Label()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.cbmParametrosDocumentos = New System.Windows.Forms.ComboBox()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblCaja = New System.Windows.Forms.Label()
            Me.cbmAutoriza = New System.Windows.Forms.ComboBox()
            Me.lblAutoriza = New System.Windows.Forms.Label()
            Me.cbmCajasChicas = New System.Windows.Forms.ComboBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblIdCombustible = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.txtFechaControl = New System.Windows.Forms.DateTimePicker()
            Me.gbLlegadaVehiculo = New System.Windows.Forms.GroupBox()
            Me.dtpHoraLlegadaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaLlegadaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.txtKmLlegadaVehiculo = New System.Windows.Forms.TextBox()
            Me.LblKilometrajeLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.lblHoraLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.lblFechaLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.gbVehiculo = New System.Windows.Forms.GroupBox()
            Me.txtIdActivoFijo = New System.Windows.Forms.TextBox()
            Me.btnBuscarVehiculo = New System.Windows.Forms.Button()
            Me.lblIdActivo = New System.Windows.Forms.Label()
            Me.txtPlacaVehiculo = New System.Windows.Forms.TextBox()
            Me.txtModeloVehiculo = New System.Windows.Forms.TextBox()
            Me.txtMarcaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblPlacaVehiculo = New System.Windows.Forms.Label()
            Me.lblModeloVehiculo = New System.Windows.Forms.Label()
            Me.lblMarcaVehiculo = New System.Windows.Forms.Label()
            Me.txtTotalKmControlC = New System.Windows.Forms.TextBox()
            Me.lblTotaKmControlC = New System.Windows.Forms.Label()
            Me.gpSalidaVehiculo = New System.Windows.Forms.GroupBox()
            Me.dtpHoraSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.txtKmSalidaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblKilometrajeSalidaVehiculo = New System.Windows.Forms.Label()
            Me.lblHoraSalidaVehiculo = New System.Windows.Forms.Label()
            Me.lblFechaSalidaVehiculo = New System.Windows.Forms.Label()
            Me.chkCombustible = New System.Windows.Forms.CheckBox()
            Me.cbmCombustible = New System.Windows.Forms.ComboBox()
            Me.lblFechaControlC = New System.Windows.Forms.Label()
            Me.txtMotivoControlC = New System.Windows.Forms.TextBox()
            Me.lblClaseGasolinaControlC = New System.Windows.Forms.Label()
            Me.txtDestinoControlC = New System.Windows.Forms.TextBox()
            Me.lblMotivoControlC = New System.Windows.Forms.Label()
            Me.txtValorControl = New System.Windows.Forms.TextBox()
            Me.lblDestinoControlC = New System.Windows.Forms.Label()
            Me.lblValorControlC = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnBuscarPersonalRecibe = New System.Windows.Forms.Button()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtNombresRecibe = New System.Windows.Forms.TextBox()
            Me.txtNombresEntrega = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtCedulaRecibe = New System.Windows.Forms.TextBox()
            Me.txtCedulaEntrega = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.txtDetalleGasto = New System.Windows.Forms.TextBox()
            Me.lblValorGasto = New System.Windows.Forms.Label()
            Me.txtValorGasto = New System.Windows.Forms.TextBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtCodigoHaber = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtCodigoDebe = New System.Windows.Forms.TextBox()
            Me.txtNumeroSolicitud = New System.Windows.Forms.TextBox()
            Me.gbDatos = New System.Windows.Forms.GroupBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.cbmConcepto = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.dgvDetallesRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tpReporteCombustible = New System.Windows.Forms.TabPage()
            Me.txtNumControl = New System.Windows.Forms.TextBox()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.crvReporteCombustible = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblMontoCajaChica = New System.Windows.Forms.Label()
            Me.lblMontoAsignado = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblMontoPorTransaccion = New System.Windows.Forms.Label()
            Me.tcSolicitudCajaChica.SuspendLayout()
            Me.tpSolicitud.SuspendLayout()
            Me.gbRetenciones.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbLlegadaVehiculo.SuspendLayout()
            Me.gbVehiculo.SuspendLayout()
            Me.gpSalidaVehiculo.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.gbDatos.SuspendLayout()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpReporteCombustible.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnControlCombustible
            '
            Me.btnControlCombustible.Location = New System.Drawing.Point(925, 699)
            Me.btnControlCombustible.Name = "btnControlCombustible"
            Me.btnControlCombustible.Size = New System.Drawing.Size(75, 23)
            Me.btnControlCombustible.TabIndex = 0
            Me.btnControlCombustible.Text = "..."
            Me.btnControlCombustible.UseVisualStyleBackColor = True
            '
            'txtTexto
            '
            Me.txtTexto.Location = New System.Drawing.Point(782, 702)
            Me.txtTexto.Name = "txtTexto"
            Me.txtTexto.Size = New System.Drawing.Size(100, 22)
            Me.txtTexto.TabIndex = 1
            '
            'tcSolicitudCajaChica
            '
            Me.tcSolicitudCajaChica.Controls.Add(Me.tpSolicitud)
            Me.tcSolicitudCajaChica.Controls.Add(Me.tpReporteCombustible)
            Me.tcSolicitudCajaChica.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcSolicitudCajaChica.Location = New System.Drawing.Point(2, 33)
            Me.tcSolicitudCajaChica.Name = "tcSolicitudCajaChica"
            Me.tcSolicitudCajaChica.SelectedIndex = 0
            Me.tcSolicitudCajaChica.Size = New System.Drawing.Size(1007, 518)
            Me.tcSolicitudCajaChica.TabIndex = 2
            '
            'tpSolicitud
            '
            Me.tpSolicitud.Controls.Add(Me.txtFecha)
            Me.tpSolicitud.Controls.Add(Me.gbRetenciones)
            Me.tpSolicitud.Controls.Add(Me.lblCaja)
            Me.tpSolicitud.Controls.Add(Me.cbmAutoriza)
            Me.tpSolicitud.Controls.Add(Me.lblAutoriza)
            Me.tpSolicitud.Controls.Add(Me.Label15)
            Me.tpSolicitud.Controls.Add(Me.GroupBox1)
            Me.tpSolicitud.Controls.Add(Me.GroupBox4)
            Me.tpSolicitud.Controls.Add(Me.GroupBox3)
            Me.tpSolicitud.Controls.Add(Me.GroupBox2)
            Me.tpSolicitud.Controls.Add(Me.txtNumeroSolicitud)
            Me.tpSolicitud.Controls.Add(Me.gbDatos)
            Me.tpSolicitud.Controls.Add(Me.Label1)
            Me.tpSolicitud.Controls.Add(Me.dtpComprobanteRetencion)
            Me.tpSolicitud.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.tpSolicitud.Controls.Add(Me.cbmCajasChicas)
            Me.tpSolicitud.Controls.Add(Me.dgvDetallesRetencion)
            Me.tpSolicitud.Location = New System.Drawing.Point(4, 22)
            Me.tpSolicitud.Name = "tpSolicitud"
            Me.tpSolicitud.Padding = New System.Windows.Forms.Padding(3)
            Me.tpSolicitud.Size = New System.Drawing.Size(999, 492)
            Me.tpSolicitud.TabIndex = 0
            Me.tpSolicitud.Text = "REGISTRO SOLICITUDES"
            Me.tpSolicitud.UseVisualStyleBackColor = True
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Location = New System.Drawing.Point(451, 12)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(247, 21)
            Me.txtFecha.TabIndex = 3
            '
            'gbRetenciones
            '
            Me.gbRetenciones.BackColor = System.Drawing.Color.White
            Me.gbRetenciones.Controls.Add(Me.btnDocumento)
            Me.gbRetenciones.Controls.Add(Me.lblNroDocumento)
            Me.gbRetenciones.Controls.Add(Me.txtNroDocumento)
            Me.gbRetenciones.Controls.Add(Me.cbmParametrosDocumentos)
            Me.gbRetenciones.Controls.Add(Me.lblCodigo)
            Me.gbRetenciones.Location = New System.Drawing.Point(709, 225)
            Me.gbRetenciones.Name = "gbRetenciones"
            Me.gbRetenciones.Size = New System.Drawing.Size(290, 87)
            Me.gbRetenciones.TabIndex = 52
            Me.gbRetenciones.TabStop = False
            Me.gbRetenciones.Text = "DOCUMENTOS"
            '
            'btnDocumento
            '
            Me.btnDocumento.BackColor = System.Drawing.Color.White
            Me.btnDocumento.Enabled = False
            Me.btnDocumento.FlatAppearance.BorderSize = 0
            Me.btnDocumento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDocumento.Image = Global.syscisepro.My.Resources.Resources.upload_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDocumento.Location = New System.Drawing.Point(214, 24)
            Me.btnDocumento.Name = "btnDocumento"
            Me.btnDocumento.Size = New System.Drawing.Size(64, 44)
            Me.btnDocumento.TabIndex = 22
            Me.btnDocumento.Text = "CARGAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.btnDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDocumento.UseVisualStyleBackColor = False
            '
            'lblNroDocumento
            '
            Me.lblNroDocumento.AutoSize = True
            Me.lblNroDocumento.Location = New System.Drawing.Point(17, 29)
            Me.lblNroDocumento.Name = "lblNroDocumento"
            Me.lblNroDocumento.Size = New System.Drawing.Size(22, 13)
            Me.lblNroDocumento.TabIndex = 21
            Me.lblNroDocumento.Text = "N°:"
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Location = New System.Drawing.Point(56, 24)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(151, 21)
            Me.txtNroDocumento.TabIndex = 20
            '
            'cbmParametrosDocumentos
            '
            Me.cbmParametrosDocumentos.BackColor = System.Drawing.Color.White
            Me.cbmParametrosDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParametrosDocumentos.Enabled = False
            Me.cbmParametrosDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParametrosDocumentos.FormattingEnabled = True
            Me.cbmParametrosDocumentos.Location = New System.Drawing.Point(95, 52)
            Me.cbmParametrosDocumentos.Name = "cbmParametrosDocumentos"
            Me.cbmParametrosDocumentos.Size = New System.Drawing.Size(112, 21)
            Me.cbmParametrosDocumentos.TabIndex = 21
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.Location = New System.Drawing.Point(17, 55)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(66, 13)
            Me.lblCodigo.TabIndex = 19
            Me.lblCodigo.Text = "CÓD. DOCU:"
            '
            'lblCaja
            '
            Me.lblCaja.AutoSize = True
            Me.lblCaja.Location = New System.Drawing.Point(121, 15)
            Me.lblCaja.Name = "lblCaja"
            Me.lblCaja.Size = New System.Drawing.Size(34, 13)
            Me.lblCaja.TabIndex = 46
            Me.lblCaja.Text = "CAJA"
            '
            'cbmAutoriza
            '
            Me.cbmAutoriza.BackColor = System.Drawing.Color.White
            Me.cbmAutoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmAutoriza.Enabled = False
            Me.cbmAutoriza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmAutoriza.FormattingEnabled = True
            Me.cbmAutoriza.Location = New System.Drawing.Point(779, 13)
            Me.cbmAutoriza.Name = "cbmAutoriza"
            Me.cbmAutoriza.Size = New System.Drawing.Size(213, 21)
            Me.cbmAutoriza.TabIndex = 4
            '
            'lblAutoriza
            '
            Me.lblAutoriza.AutoSize = True
            Me.lblAutoriza.Location = New System.Drawing.Point(715, 16)
            Me.lblAutoriza.Name = "lblAutoriza"
            Me.lblAutoriza.Size = New System.Drawing.Size(63, 13)
            Me.lblAutoriza.TabIndex = 10
            Me.lblAutoriza.Text = "AUTORIZA:"
            '
            'cbmCajasChicas
            '
            Me.cbmCajasChicas.BackColor = System.Drawing.Color.White
            Me.cbmCajasChicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCajasChicas.Enabled = False
            Me.cbmCajasChicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCajasChicas.FormattingEnabled = True
            Me.cbmCajasChicas.Location = New System.Drawing.Point(156, 12)
            Me.cbmCajasChicas.Name = "cbmCajasChicas"
            Me.cbmCajasChicas.Size = New System.Drawing.Size(216, 21)
            Me.cbmCajasChicas.TabIndex = 2
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(408, 16)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(44, 13)
            Me.Label15.TabIndex = 43
            Me.Label15.Text = "FECHA:"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblIdCombustible)
            Me.GroupBox1.Controls.Add(Me.PictureBox1)
            Me.GroupBox1.Controls.Add(Me.txtFechaControl)
            Me.GroupBox1.Controls.Add(Me.gbLlegadaVehiculo)
            Me.GroupBox1.Controls.Add(Me.gbVehiculo)
            Me.GroupBox1.Controls.Add(Me.txtTotalKmControlC)
            Me.GroupBox1.Controls.Add(Me.lblTotaKmControlC)
            Me.GroupBox1.Controls.Add(Me.gpSalidaVehiculo)
            Me.GroupBox1.Controls.Add(Me.chkCombustible)
            Me.GroupBox1.Controls.Add(Me.cbmCombustible)
            Me.GroupBox1.Controls.Add(Me.lblFechaControlC)
            Me.GroupBox1.Controls.Add(Me.txtMotivoControlC)
            Me.GroupBox1.Controls.Add(Me.lblClaseGasolinaControlC)
            Me.GroupBox1.Controls.Add(Me.txtDestinoControlC)
            Me.GroupBox1.Controls.Add(Me.lblMotivoControlC)
            Me.GroupBox1.Controls.Add(Me.txtValorControl)
            Me.GroupBox1.Controls.Add(Me.lblDestinoControlC)
            Me.GroupBox1.Controls.Add(Me.lblValorControlC)
            Me.GroupBox1.Enabled = False
            Me.GroupBox1.Location = New System.Drawing.Point(3, 318)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(997, 178)
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            '
            'lblIdCombustible
            '
            Me.lblIdCombustible.AutoSize = True
            Me.lblIdCombustible.BackColor = System.Drawing.Color.White
            Me.lblIdCombustible.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCombustible.Location = New System.Drawing.Point(186, 0)
            Me.lblIdCombustible.Name = "lblIdCombustible"
            Me.lblIdCombustible.Size = New System.Drawing.Size(0, 17)
            Me.lblIdCombustible.TabIndex = 36
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.Location = New System.Drawing.Point(772, 15)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(219, 154)
            Me.PictureBox1.TabIndex = 35
            Me.PictureBox1.TabStop = False
            '
            'txtFechaControl
            '
            Me.txtFechaControl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtFechaControl.Location = New System.Drawing.Point(63, 23)
            Me.txtFechaControl.Name = "txtFechaControl"
            Me.txtFechaControl.Size = New System.Drawing.Size(99, 21)
            Me.txtFechaControl.TabIndex = 24
            '
            'gbLlegadaVehiculo
            '
            Me.gbLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.gbLlegadaVehiculo.Controls.Add(Me.dtpHoraLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.dtpFechaLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.txtKmLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.LblKilometrajeLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.lblHoraLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.lblFechaLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Location = New System.Drawing.Point(423, 77)
            Me.gbLlegadaVehiculo.Name = "gbLlegadaVehiculo"
            Me.gbLlegadaVehiculo.Size = New System.Drawing.Size(165, 95)
            Me.gbLlegadaVehiculo.TabIndex = 32
            Me.gbLlegadaVehiculo.TabStop = False
            Me.gbLlegadaVehiculo.Text = "LLEGADA"
            '
            'dtpHoraLlegadaVehiculo
            '
            Me.dtpHoraLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraLlegadaVehiculo.Location = New System.Drawing.Point(49, 42)
            Me.dtpHoraLlegadaVehiculo.Name = "dtpHoraLlegadaVehiculo"
            Me.dtpHoraLlegadaVehiculo.ShowUpDown = True
            Me.dtpHoraLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpHoraLlegadaVehiculo.TabIndex = 36
            '
            'dtpFechaLlegadaVehiculo
            '
            Me.dtpFechaLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaLlegadaVehiculo.Location = New System.Drawing.Point(49, 19)
            Me.dtpFechaLlegadaVehiculo.Name = "dtpFechaLlegadaVehiculo"
            Me.dtpFechaLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpFechaLlegadaVehiculo.TabIndex = 35
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(49, 65)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.txtKmLlegadaVehiculo.TabIndex = 37
            Me.txtKmLlegadaVehiculo.Text = "0"
            '
            'LblKilometrajeLlegadaVehiculo
            '
            Me.LblKilometrajeLlegadaVehiculo.AutoSize = True
            Me.LblKilometrajeLlegadaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblKilometrajeLlegadaVehiculo.Location = New System.Drawing.Point(8, 68)
            Me.LblKilometrajeLlegadaVehiculo.Name = "LblKilometrajeLlegadaVehiculo"
            Me.LblKilometrajeLlegadaVehiculo.Size = New System.Drawing.Size(32, 13)
            Me.LblKilometrajeLlegadaVehiculo.TabIndex = 2
            Me.LblKilometrajeLlegadaVehiculo.Text = "KM'S:"
            '
            'lblHoraLlegadaVehiculo
            '
            Me.lblHoraLlegadaVehiculo.AutoSize = True
            Me.lblHoraLlegadaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraLlegadaVehiculo.Location = New System.Drawing.Point(8, 45)
            Me.lblHoraLlegadaVehiculo.Name = "lblHoraLlegadaVehiculo"
            Me.lblHoraLlegadaVehiculo.Size = New System.Drawing.Size(36, 13)
            Me.lblHoraLlegadaVehiculo.TabIndex = 1
            Me.lblHoraLlegadaVehiculo.Text = "HORA:"
            '
            'lblFechaLlegadaVehiculo
            '
            Me.lblFechaLlegadaVehiculo.AutoSize = True
            Me.lblFechaLlegadaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaLlegadaVehiculo.Location = New System.Drawing.Point(8, 22)
            Me.lblFechaLlegadaVehiculo.Name = "lblFechaLlegadaVehiculo"
            Me.lblFechaLlegadaVehiculo.Size = New System.Drawing.Size(39, 13)
            Me.lblFechaLlegadaVehiculo.TabIndex = 0
            Me.lblFechaLlegadaVehiculo.Text = "FECHA:"
            '
            'gbVehiculo
            '
            Me.gbVehiculo.BackColor = System.Drawing.Color.White
            Me.gbVehiculo.Controls.Add(Me.txtIdActivoFijo)
            Me.gbVehiculo.Controls.Add(Me.btnBuscarVehiculo)
            Me.gbVehiculo.Controls.Add(Me.lblIdActivo)
            Me.gbVehiculo.Controls.Add(Me.txtPlacaVehiculo)
            Me.gbVehiculo.Controls.Add(Me.txtModeloVehiculo)
            Me.gbVehiculo.Controls.Add(Me.txtMarcaVehiculo)
            Me.gbVehiculo.Controls.Add(Me.lblPlacaVehiculo)
            Me.gbVehiculo.Controls.Add(Me.lblModeloVehiculo)
            Me.gbVehiculo.Controls.Add(Me.lblMarcaVehiculo)
            Me.gbVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!)
            Me.gbVehiculo.Location = New System.Drawing.Point(6, 77)
            Me.gbVehiculo.Name = "gbVehiculo"
            Me.gbVehiculo.Size = New System.Drawing.Size(411, 95)
            Me.gbVehiculo.TabIndex = 33
            Me.gbVehiculo.TabStop = False
            Me.gbVehiculo.Text = "VEHICULO"
            '
            'txtIdActivoFijo
            '
            Me.txtIdActivoFijo.BackColor = System.Drawing.Color.White
            Me.txtIdActivoFijo.Enabled = False
            Me.txtIdActivoFijo.Location = New System.Drawing.Point(57, 24)
            Me.txtIdActivoFijo.Name = "txtIdActivoFijo"
            Me.txtIdActivoFijo.Size = New System.Drawing.Size(115, 21)
            Me.txtIdActivoFijo.TabIndex = 30
            Me.txtIdActivoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnBuscarVehiculo
            '
            Me.btnBuscarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscarVehiculo.Location = New System.Drawing.Point(172, 23)
            Me.btnBuscarVehiculo.Name = "btnBuscarVehiculo"
            Me.btnBuscarVehiculo.Size = New System.Drawing.Size(26, 24)
            Me.btnBuscarVehiculo.TabIndex = 31
            Me.btnBuscarVehiculo.Text = "..."
            Me.btnBuscarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscarVehiculo.UseVisualStyleBackColor = True
            '
            'lblIdActivo
            '
            Me.lblIdActivo.AutoSize = True
            Me.lblIdActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdActivo.Location = New System.Drawing.Point(10, 25)
            Me.lblIdActivo.Name = "lblIdActivo"
            Me.lblIdActivo.Size = New System.Drawing.Size(43, 13)
            Me.lblIdActivo.TabIndex = 6
            Me.lblIdActivo.Text = "ACTIVO:"
            '
            'txtPlacaVehiculo
            '
            Me.txtPlacaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtPlacaVehiculo.Enabled = False
            Me.txtPlacaVehiculo.Location = New System.Drawing.Point(261, 53)
            Me.txtPlacaVehiculo.Name = "txtPlacaVehiculo"
            Me.txtPlacaVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtPlacaVehiculo.TabIndex = 34
            Me.txtPlacaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtModeloVehiculo
            '
            Me.txtModeloVehiculo.BackColor = System.Drawing.Color.White
            Me.txtModeloVehiculo.Enabled = False
            Me.txtModeloVehiculo.Location = New System.Drawing.Point(261, 24)
            Me.txtModeloVehiculo.Name = "txtModeloVehiculo"
            Me.txtModeloVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtModeloVehiculo.TabIndex = 33
            Me.txtModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtMarcaVehiculo
            '
            Me.txtMarcaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtMarcaVehiculo.Enabled = False
            Me.txtMarcaVehiculo.Location = New System.Drawing.Point(57, 53)
            Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
            Me.txtMarcaVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtMarcaVehiculo.TabIndex = 32
            Me.txtMarcaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblPlacaVehiculo
            '
            Me.lblPlacaVehiculo.AutoSize = True
            Me.lblPlacaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlacaVehiculo.Location = New System.Drawing.Point(218, 56)
            Me.lblPlacaVehiculo.Name = "lblPlacaVehiculo"
            Me.lblPlacaVehiculo.Size = New System.Drawing.Size(39, 13)
            Me.lblPlacaVehiculo.TabIndex = 2
            Me.lblPlacaVehiculo.Text = "PLACA:"
            '
            'lblModeloVehiculo
            '
            Me.lblModeloVehiculo.AutoSize = True
            Me.lblModeloVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblModeloVehiculo.Location = New System.Drawing.Point(214, 27)
            Me.lblModeloVehiculo.Name = "lblModeloVehiculo"
            Me.lblModeloVehiculo.Size = New System.Drawing.Size(50, 13)
            Me.lblModeloVehiculo.TabIndex = 1
            Me.lblModeloVehiculo.Text = "MODELO:"
            '
            'lblMarcaVehiculo
            '
            Me.lblMarcaVehiculo.AutoSize = True
            Me.lblMarcaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMarcaVehiculo.Location = New System.Drawing.Point(10, 56)
            Me.lblMarcaVehiculo.Name = "lblMarcaVehiculo"
            Me.lblMarcaVehiculo.Size = New System.Drawing.Size(43, 13)
            Me.lblMarcaVehiculo.TabIndex = 0
            Me.lblMarcaVehiculo.Text = "MARCA:"
            '
            'txtTotalKmControlC
            '
            Me.txtTotalKmControlC.BackColor = System.Drawing.Color.White
            Me.txtTotalKmControlC.Enabled = False
            Me.txtTotalKmControlC.Location = New System.Drawing.Point(712, 51)
            Me.txtTotalKmControlC.Name = "txtTotalKmControlC"
            Me.txtTotalKmControlC.Size = New System.Drawing.Size(47, 21)
            Me.txtTotalKmControlC.TabIndex = 29
            Me.txtTotalKmControlC.Text = "0"
            Me.txtTotalKmControlC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblTotaKmControlC
            '
            Me.lblTotaKmControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotaKmControlC.Location = New System.Drawing.Point(715, 18)
            Me.lblTotaKmControlC.Name = "lblTotaKmControlC"
            Me.lblTotaKmControlC.Size = New System.Drawing.Size(40, 32)
            Me.lblTotaKmControlC.TabIndex = 20
            Me.lblTotaKmControlC.Text = "TOTAL KM's:"
            Me.lblTotaKmControlC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gpSalidaVehiculo
            '
            Me.gpSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpHoraSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpFechaSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.txtKmSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.lblKilometrajeSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.lblHoraSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.lblFechaSalidaVehiculo)
            Me.gpSalidaVehiculo.Location = New System.Drawing.Point(594, 77)
            Me.gpSalidaVehiculo.Name = "gpSalidaVehiculo"
            Me.gpSalidaVehiculo.Size = New System.Drawing.Size(165, 95)
            Me.gpSalidaVehiculo.TabIndex = 31
            Me.gpSalidaVehiculo.TabStop = False
            Me.gpSalidaVehiculo.Text = "SALIDA"
            '
            'dtpHoraSalidaVehiculo
            '
            Me.dtpHoraSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraSalidaVehiculo.Location = New System.Drawing.Point(46, 42)
            Me.dtpHoraSalidaVehiculo.Name = "dtpHoraSalidaVehiculo"
            Me.dtpHoraSalidaVehiculo.ShowUpDown = True
            Me.dtpHoraSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpHoraSalidaVehiculo.TabIndex = 39
            '
            'dtpFechaSalidaVehiculo
            '
            Me.dtpFechaSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaSalidaVehiculo.Location = New System.Drawing.Point(46, 19)
            Me.dtpFechaSalidaVehiculo.Name = "dtpFechaSalidaVehiculo"
            Me.dtpFechaSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpFechaSalidaVehiculo.TabIndex = 38
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(46, 65)
            Me.txtKmSalidaVehiculo.Name = "txtKmSalidaVehiculo"
            Me.txtKmSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.txtKmSalidaVehiculo.TabIndex = 40
            Me.txtKmSalidaVehiculo.Text = "0"
            '
            'lblKilometrajeSalidaVehiculo
            '
            Me.lblKilometrajeSalidaVehiculo.AutoSize = True
            Me.lblKilometrajeSalidaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblKilometrajeSalidaVehiculo.Location = New System.Drawing.Point(6, 68)
            Me.lblKilometrajeSalidaVehiculo.Name = "lblKilometrajeSalidaVehiculo"
            Me.lblKilometrajeSalidaVehiculo.Size = New System.Drawing.Size(32, 13)
            Me.lblKilometrajeSalidaVehiculo.TabIndex = 2
            Me.lblKilometrajeSalidaVehiculo.Text = "KM'S:"
            '
            'lblHoraSalidaVehiculo
            '
            Me.lblHoraSalidaVehiculo.AutoSize = True
            Me.lblHoraSalidaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraSalidaVehiculo.Location = New System.Drawing.Point(6, 45)
            Me.lblHoraSalidaVehiculo.Name = "lblHoraSalidaVehiculo"
            Me.lblHoraSalidaVehiculo.Size = New System.Drawing.Size(36, 13)
            Me.lblHoraSalidaVehiculo.TabIndex = 1
            Me.lblHoraSalidaVehiculo.Text = "HORA:"
            '
            'lblFechaSalidaVehiculo
            '
            Me.lblFechaSalidaVehiculo.AutoSize = True
            Me.lblFechaSalidaVehiculo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaSalidaVehiculo.Location = New System.Drawing.Point(6, 22)
            Me.lblFechaSalidaVehiculo.Name = "lblFechaSalidaVehiculo"
            Me.lblFechaSalidaVehiculo.Size = New System.Drawing.Size(39, 13)
            Me.lblFechaSalidaVehiculo.TabIndex = 0
            Me.lblFechaSalidaVehiculo.Text = "FECHA:"
            '
            'chkCombustible
            '
            Me.chkCombustible.AutoSize = True
            Me.chkCombustible.BackColor = System.Drawing.Color.White
            Me.chkCombustible.Enabled = False
            Me.chkCombustible.Location = New System.Drawing.Point(8, 0)
            Me.chkCombustible.Name = "chkCombustible"
            Me.chkCombustible.Size = New System.Drawing.Size(171, 17)
            Me.chkCombustible.TabIndex = 23
            Me.chkCombustible.Text = "CONTROL DE COMBUSTIBLE"
            Me.chkCombustible.UseVisualStyleBackColor = False
            '
            'cbmCombustible
            '
            Me.cbmCombustible.BackColor = System.Drawing.Color.White
            Me.cbmCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCombustible.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCombustible.FormattingEnabled = True
            Me.cbmCombustible.Location = New System.Drawing.Point(342, 24)
            Me.cbmCombustible.Name = "cbmCombustible"
            Me.cbmCombustible.Size = New System.Drawing.Size(175, 21)
            Me.cbmCombustible.TabIndex = 25
            '
            'lblFechaControlC
            '
            Me.lblFechaControlC.AutoSize = True
            Me.lblFechaControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaControlC.Location = New System.Drawing.Point(15, 27)
            Me.lblFechaControlC.Name = "lblFechaControlC"
            Me.lblFechaControlC.Size = New System.Drawing.Size(39, 13)
            Me.lblFechaControlC.TabIndex = 4
            Me.lblFechaControlC.Text = "FECHA:"
            '
            'txtMotivoControlC
            '
            Me.txtMotivoControlC.BackColor = System.Drawing.Color.White
            Me.txtMotivoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMotivoControlC.Location = New System.Drawing.Point(414, 51)
            Me.txtMotivoControlC.Name = "txtMotivoControlC"
            Me.txtMotivoControlC.Size = New System.Drawing.Size(283, 21)
            Me.txtMotivoControlC.TabIndex = 28
            '
            'lblClaseGasolinaControlC
            '
            Me.lblClaseGasolinaControlC.AutoSize = True
            Me.lblClaseGasolinaControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblClaseGasolinaControlC.Location = New System.Drawing.Point(262, 28)
            Me.lblClaseGasolinaControlC.Name = "lblClaseGasolinaControlC"
            Me.lblClaseGasolinaControlC.Size = New System.Drawing.Size(74, 13)
            Me.lblClaseGasolinaControlC.TabIndex = 14
            Me.lblClaseGasolinaControlC.Text = "COMBUSTIBLE:"
            '
            'txtDestinoControlC
            '
            Me.txtDestinoControlC.BackColor = System.Drawing.Color.White
            Me.txtDestinoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDestinoControlC.Location = New System.Drawing.Point(63, 51)
            Me.txtDestinoControlC.Name = "txtDestinoControlC"
            Me.txtDestinoControlC.Size = New System.Drawing.Size(289, 21)
            Me.txtDestinoControlC.TabIndex = 27
            '
            'lblMotivoControlC
            '
            Me.lblMotivoControlC.AutoSize = True
            Me.lblMotivoControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMotivoControlC.Location = New System.Drawing.Point(370, 55)
            Me.lblMotivoControlC.Name = "lblMotivoControlC"
            Me.lblMotivoControlC.Size = New System.Drawing.Size(47, 13)
            Me.lblMotivoControlC.TabIndex = 17
            Me.lblMotivoControlC.Text = "MOTIVO:"
            '
            'txtValorControl
            '
            Me.txtValorControl.BackColor = System.Drawing.Color.White
            Me.txtValorControl.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorControl.ForeColor = System.Drawing.Color.Black
            Me.txtValorControl.Location = New System.Drawing.Point(614, 25)
            Me.txtValorControl.Name = "txtValorControl"
            Me.txtValorControl.Size = New System.Drawing.Size(83, 21)
            Me.txtValorControl.TabIndex = 26
            Me.txtValorControl.Text = "0.00"
            Me.txtValorControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblDestinoControlC
            '
            Me.lblDestinoControlC.AutoSize = True
            Me.lblDestinoControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDestinoControlC.Location = New System.Drawing.Point(14, 55)
            Me.lblDestinoControlC.Name = "lblDestinoControlC"
            Me.lblDestinoControlC.Size = New System.Drawing.Size(49, 13)
            Me.lblDestinoControlC.TabIndex = 16
            Me.lblDestinoControlC.Text = "DESTINO:"
            '
            'lblValorControlC
            '
            Me.lblValorControlC.AutoSize = True
            Me.lblValorControlC.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorControlC.Location = New System.Drawing.Point(569, 28)
            Me.lblValorControlC.Name = "lblValorControlC"
            Me.lblValorControlC.Size = New System.Drawing.Size(39, 13)
            Me.lblValorControlC.TabIndex = 15
            Me.lblValorControlC.Text = "VALOR:"
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.txtNombreComercialCliente)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.btnBuscarPersonalRecibe)
            Me.GroupBox4.Controls.Add(Me.Label21)
            Me.GroupBox4.Controls.Add(Me.txtNombresRecibe)
            Me.GroupBox4.Controls.Add(Me.txtNombresEntrega)
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.txtCedulaRecibe)
            Me.GroupBox4.Controls.Add(Me.txtCedulaEntrega)
            Me.GroupBox4.Controls.Add(Me.Label16)
            Me.GroupBox4.Controls.Add(Me.Label20)
            Me.GroupBox4.Location = New System.Drawing.Point(1, 119)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(779, 100)
            Me.GroupBox4.TabIndex = 45
            Me.GroupBox4.TabStop = False
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Enabled = False
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(464, 74)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(305, 21)
            Me.txtNombreComercialCliente.TabIndex = 22
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(403, 79)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(50, 13)
            Me.Label5.TabIndex = 21
            Me.Label5.Text = "CLIENTE"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(397, 2)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(122, 13)
            Me.Label4.TabIndex = 20
            Me.Label4.Text = "RESPONSABLE RECIBE"
            '
            'btnBuscarPersonalRecibe
            '
            Me.btnBuscarPersonalRecibe.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnBuscarPersonalRecibe.Enabled = False
            Me.btnBuscarPersonalRecibe.Location = New System.Drawing.Point(547, 20)
            Me.btnBuscarPersonalRecibe.Name = "btnBuscarPersonalRecibe"
            Me.btnBuscarPersonalRecibe.Size = New System.Drawing.Size(30, 24)
            Me.btnBuscarPersonalRecibe.TabIndex = 13
            Me.btnBuscarPersonalRecibe.Text = "..."
            Me.btnBuscarPersonalRecibe.UseVisualStyleBackColor = True
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(399, 52)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(63, 13)
            Me.Label21.TabIndex = 9
            Me.Label21.Text = "NOMBRES:"
            '
            'txtNombresRecibe
            '
            Me.txtNombresRecibe.BackColor = System.Drawing.Color.White
            Me.txtNombresRecibe.Enabled = False
            Me.txtNombresRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtNombresRecibe.Location = New System.Drawing.Point(464, 49)
            Me.txtNombresRecibe.Name = "txtNombresRecibe"
            Me.txtNombresRecibe.Size = New System.Drawing.Size(305, 21)
            Me.txtNombresRecibe.TabIndex = 15
            '
            'txtNombresEntrega
            '
            Me.txtNombresEntrega.BackColor = System.Drawing.Color.White
            Me.txtNombresEntrega.Enabled = False
            Me.txtNombresEntrega.ForeColor = System.Drawing.Color.Black
            Me.txtNombresEntrega.Location = New System.Drawing.Point(68, 49)
            Me.txtNombresEntrega.Name = "txtNombresEntrega"
            Me.txtNombresEntrega.Size = New System.Drawing.Size(284, 21)
            Me.txtNombresEntrega.TabIndex = 12
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(399, 24)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(50, 13)
            Me.Label19.TabIndex = 5
            Me.Label19.Text = "CÉDULA:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(6, 24)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(50, 13)
            Me.Label18.TabIndex = 4
            Me.Label18.Text = "CÉDULA:"
            '
            'txtCedulaRecibe
            '
            Me.txtCedulaRecibe.BackColor = System.Drawing.Color.White
            Me.txtCedulaRecibe.Enabled = False
            Me.txtCedulaRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtCedulaRecibe.Location = New System.Drawing.Point(464, 21)
            Me.txtCedulaRecibe.Name = "txtCedulaRecibe"
            Me.txtCedulaRecibe.Size = New System.Drawing.Size(83, 21)
            Me.txtCedulaRecibe.TabIndex = 14
            '
            'txtCedulaEntrega
            '
            Me.txtCedulaEntrega.BackColor = System.Drawing.Color.White
            Me.txtCedulaEntrega.Enabled = False
            Me.txtCedulaEntrega.ForeColor = System.Drawing.Color.Black
            Me.txtCedulaEntrega.Location = New System.Drawing.Point(68, 21)
            Me.txtCedulaEntrega.Name = "txtCedulaEntrega"
            Me.txtCedulaEntrega.Size = New System.Drawing.Size(102, 21)
            Me.txtCedulaEntrega.TabIndex = 11
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Me.Label16.Location = New System.Drawing.Point(2, 2)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(135, 13)
            Me.Label16.TabIndex = 0
            Me.Label16.Text = "RESPONSABLE ENTREGA"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(5, 52)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(63, 13)
            Me.Label20.TabIndex = 7
            Me.Label20.Text = "NOMBRES:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.lblDetalle)
            Me.GroupBox3.Controls.Add(Me.txtDetalleGasto)
            Me.GroupBox3.Controls.Add(Me.lblValorGasto)
            Me.GroupBox3.Controls.Add(Me.txtValorGasto)
            Me.GroupBox3.Controls.Add(Me.dgvAsientosDiario)
            Me.GroupBox3.Location = New System.Drawing.Point(3, 225)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(707, 87)
            Me.GroupBox3.TabIndex = 42
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "GASTO:"
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.Location = New System.Drawing.Point(11, 51)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(55, 13)
            Me.lblDetalle.TabIndex = 17
            Me.lblDetalle.Text = "DETALLE:"
            '
            'txtDetalleGasto
            '
            Me.txtDetalleGasto.BackColor = System.Drawing.Color.White
            Me.txtDetalleGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleGasto.Enabled = False
            Me.txtDetalleGasto.Location = New System.Drawing.Point(68, 44)
            Me.txtDetalleGasto.Multiline = True
            Me.txtDetalleGasto.Name = "txtDetalleGasto"
            Me.txtDetalleGasto.Size = New System.Drawing.Size(633, 33)
            Me.txtDetalleGasto.TabIndex = 19
            '
            'lblValorGasto
            '
            Me.lblValorGasto.AutoSize = True
            Me.lblValorGasto.Location = New System.Drawing.Point(11, 21)
            Me.lblValorGasto.Name = "lblValorGasto"
            Me.lblValorGasto.Size = New System.Drawing.Size(45, 13)
            Me.lblValorGasto.TabIndex = 15
            Me.lblValorGasto.Text = "VALOR:"
            '
            'txtValorGasto
            '
            Me.txtValorGasto.BackColor = System.Drawing.Color.White
            Me.txtValorGasto.Enabled = False
            Me.txtValorGasto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorGasto.Location = New System.Drawing.Point(68, 18)
            Me.txtValorGasto.Name = "txtValorGasto"
            Me.txtValorGasto.Size = New System.Drawing.Size(101, 23)
            Me.txtValorGasto.TabIndex = 18
            Me.txtValorGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.CODIGO, Me.CUENTA, Me.VALOR, Me.IVA})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(183, 14)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(514, 28)
            Me.dgvAsientosDiario.TabIndex = 54
            Me.dgvAsientosDiario.Visible = False
            '
            'eliminarItem
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
            Me.eliminarItem.DefaultCellStyle = DataGridViewCellStyle3
            Me.eliminarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.eliminarItem.HeaderText = "SUPR"
            Me.eliminarItem.Name = "eliminarItem"
            Me.eliminarItem.ReadOnly = True
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
            Me.CODIGO.ReadOnly = True
            Me.CODIGO.Width = 95
            '
            'CUENTA
            '
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CUENTA.DefaultCellStyle = DataGridViewCellStyle4
            Me.CUENTA.HeaderText = "CUENTA"
            Me.CUENTA.Name = "CUENTA"
            Me.CUENTA.ReadOnly = True
            Me.CUENTA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.CUENTA.Width = 225
            '
            'VALOR
            '
            Me.VALOR.HeaderText = "VALOR"
            Me.VALOR.Name = "VALOR"
            Me.VALOR.ReadOnly = True
            Me.VALOR.Width = 80
            '
            'IVA
            '
            Me.IVA.HeaderText = "IVA"
            Me.IVA.Name = "IVA"
            Me.IVA.ReadOnly = True
            Me.IVA.Width = 35
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.txtCodigoHaber)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.txtCodigoDebe)
            Me.GroupBox2.Location = New System.Drawing.Point(779, 119)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(219, 100)
            Me.GroupBox2.TabIndex = 41
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "CONTABILIZACIÓN"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(146, 28)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(42, 13)
            Me.Label14.TabIndex = 21
            Me.Label14.Text = "HABER"
            '
            'txtCodigoHaber
            '
            Me.txtCodigoHaber.BackColor = System.Drawing.Color.White
            Me.txtCodigoHaber.Enabled = False
            Me.txtCodigoHaber.ForeColor = System.Drawing.Color.White
            Me.txtCodigoHaber.Location = New System.Drawing.Point(120, 49)
            Me.txtCodigoHaber.Name = "txtCodigoHaber"
            Me.txtCodigoHaber.Size = New System.Drawing.Size(93, 21)
            Me.txtCodigoHaber.TabIndex = 17
            Me.txtCodigoHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(35, 28)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(33, 13)
            Me.Label13.TabIndex = 19
            Me.Label13.Text = "DEBE"
            '
            'txtCodigoDebe
            '
            Me.txtCodigoDebe.BackColor = System.Drawing.Color.White
            Me.txtCodigoDebe.Enabled = False
            Me.txtCodigoDebe.ForeColor = System.Drawing.Color.White
            Me.txtCodigoDebe.Location = New System.Drawing.Point(7, 49)
            Me.txtCodigoDebe.Name = "txtCodigoDebe"
            Me.txtCodigoDebe.Size = New System.Drawing.Size(93, 21)
            Me.txtCodigoDebe.TabIndex = 16
            Me.txtCodigoDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNumeroSolicitud
            '
            Me.txtNumeroSolicitud.BackColor = System.Drawing.Color.White
            Me.txtNumeroSolicitud.Enabled = False
            Me.txtNumeroSolicitud.Location = New System.Drawing.Point(31, 11)
            Me.txtNumeroSolicitud.Name = "txtNumeroSolicitud"
            Me.txtNumeroSolicitud.Size = New System.Drawing.Size(66, 21)
            Me.txtNumeroSolicitud.TabIndex = 1
            '
            'gbDatos
            '
            Me.gbDatos.BackColor = System.Drawing.Color.White
            Me.gbDatos.Controls.Add(Me.cbmProvincia)
            Me.gbDatos.Controls.Add(Me.txtActividad)
            Me.gbDatos.Controls.Add(Me.cbmConcepto)
            Me.gbDatos.Controls.Add(Me.cbmCentroCosto)
            Me.gbDatos.Controls.Add(Me.cbmParroquia)
            Me.gbDatos.Controls.Add(Me.cbmCanton)
            Me.gbDatos.Controls.Add(Me.lblConcepto)
            Me.gbDatos.Controls.Add(Me.lblParroquia)
            Me.gbDatos.Controls.Add(Me.lblCiudad)
            Me.gbDatos.Controls.Add(Me.lblCentroCosto)
            Me.gbDatos.Controls.Add(Me.lblProvincia)
            Me.gbDatos.Controls.Add(Me.Label2)
            Me.gbDatos.Location = New System.Drawing.Point(1, 42)
            Me.gbDatos.Name = "gbDatos"
            Me.gbDatos.Size = New System.Drawing.Size(997, 76)
            Me.gbDatos.TabIndex = 35
            Me.gbDatos.TabStop = False
            Me.gbDatos.Text = "ENCABEZADO"
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(71, 46)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(200, 21)
            Me.cbmProvincia.TabIndex = 8
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.Enabled = False
            Me.txtActividad.Location = New System.Drawing.Point(71, 18)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(79, 21)
            Me.txtActividad.TabIndex = 5
            Me.txtActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cbmConcepto
            '
            Me.cbmConcepto.BackColor = System.Drawing.Color.White
            Me.cbmConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmConcepto.Enabled = False
            Me.cbmConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmConcepto.FormattingEnabled = True
            Me.cbmConcepto.Location = New System.Drawing.Point(270, 18)
            Me.cbmConcepto.Name = "cbmConcepto"
            Me.cbmConcepto.Size = New System.Drawing.Size(361, 21)
            Me.cbmConcepto.TabIndex = 6
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Enabled = False
            Me.cbmCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(785, 15)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(207, 21)
            Me.cbmCentroCosto.TabIndex = 7
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(791, 45)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(200, 21)
            Me.cbmParroquia.TabIndex = 10
            '
            'cbmCanton
            '
            Me.cbmCanton.BackColor = System.Drawing.Color.White
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Enabled = False
            Me.cbmCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(431, 45)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(200, 21)
            Me.cbmCanton.TabIndex = 9
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Location = New System.Drawing.Point(200, 21)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(68, 13)
            Me.lblConcepto.TabIndex = 5
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Location = New System.Drawing.Point(718, 48)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(70, 13)
            Me.lblParroquia.TabIndex = 4
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Location = New System.Drawing.Point(376, 50)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(55, 13)
            Me.lblCiudad.TabIndex = 3
            Me.lblCiudad.Text = "CANTÓN:"
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Location = New System.Drawing.Point(693, 19)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(93, 13)
            Me.lblCentroCosto.TabIndex = 2
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Location = New System.Drawing.Point(5, 50)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(67, 13)
            Me.lblProvincia.TabIndex = 1
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(7, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "ACTIVIDAD:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(22, 13)
            Me.Label1.TabIndex = 33
            Me.Label1.Text = "N°:"
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Enabled = False
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(518, 12)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(88, 21)
            Me.dtpComprobanteRetencion.TabIndex = 45
            Me.dtpComprobanteRetencion.Visible = False
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(454, 12)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(82, 21)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 44
            Me.dtpFechaEmisionComprobanteCompra.Visible = False
            '
            'dgvDetallesRetencion
            '
            Me.dgvDetallesRetencion.AllowUserToAddRows = False
            Me.dgvDetallesRetencion.AllowUserToDeleteRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetallesRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDetallesRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetallesRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetallesRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetallesRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvDetallesRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetallesRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetallesRetencion.Location = New System.Drawing.Point(37, 8)
            Me.dgvDetallesRetencion.MultiSelect = False
            Me.dgvDetallesRetencion.Name = "dgvDetallesRetencion"
            Me.dgvDetallesRetencion.ReadOnly = True
            Me.dgvDetallesRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetallesRetencion.RowHeadersVisible = False
            Me.dgvDetallesRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetallesRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetallesRetencion.Size = New System.Drawing.Size(704, 85)
            Me.dgvDetallesRetencion.TabIndex = 53
            Me.dgvDetallesRetencion.Visible = False
            '
            'EjercicioFiscal
            '
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EjercicioFiscal.DefaultCellStyle = DataGridViewCellStyle8
            Me.EjercicioFiscal.HeaderText = "EJ. FISCAL"
            Me.EjercicioFiscal.Name = "EjercicioFiscal"
            Me.EjercicioFiscal.ReadOnly = True
            Me.EjercicioFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.EjercicioFiscal.Width = 110
            '
            'CodigoRetencion
            '
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodigoRetencion.DefaultCellStyle = DataGridViewCellStyle9
            Me.CodigoRetencion.HeaderText = "CODIGO"
            Me.CodigoRetencion.Name = "CodigoRetencion"
            Me.CodigoRetencion.ReadOnly = True
            Me.CodigoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CodigoRetencion.Width = 110
            '
            'BaseImponible
            '
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BaseImponible.DefaultCellStyle = DataGridViewCellStyle10
            Me.BaseImponible.HeaderText = "BASE IMPONIBLE"
            Me.BaseImponible.Name = "BaseImponible"
            Me.BaseImponible.ReadOnly = True
            Me.BaseImponible.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BaseImponible.Width = 145
            '
            'Impuesto
            '
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle11
            Me.Impuesto.HeaderText = "IMPUESTO"
            Me.Impuesto.Name = "Impuesto"
            Me.Impuesto.ReadOnly = True
            Me.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Impuesto.Width = 105
            '
            'PorcentajeRetencion
            '
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PorcentajeRetencion.DefaultCellStyle = DataGridViewCellStyle12
            Me.PorcentajeRetencion.HeaderText = "%"
            Me.PorcentajeRetencion.Name = "PorcentajeRetencion"
            Me.PorcentajeRetencion.ReadOnly = True
            Me.PorcentajeRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.PorcentajeRetencion.Width = 110
            '
            'ValorRetenido
            '
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ValorRetenido.DefaultCellStyle = DataGridViewCellStyle13
            Me.ValorRetenido.HeaderText = "VALOR"
            Me.ValorRetenido.Name = "ValorRetenido"
            Me.ValorRetenido.ReadOnly = True
            Me.ValorRetenido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.ValorRetenido.Width = 120
            '
            'Column1
            '
            Me.Column1.HeaderText = "CODIGO"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'Column2
            '
            Me.Column2.HeaderText = "CUENTA"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            '
            'tpReporteCombustible
            '
            Me.tpReporteCombustible.Controls.Add(Me.txtNumControl)
            Me.tpReporteCombustible.Controls.Add(Me.btnReporte)
            Me.tpReporteCombustible.Controls.Add(Me.crvReporteCombustible)
            Me.tpReporteCombustible.Location = New System.Drawing.Point(4, 22)
            Me.tpReporteCombustible.Name = "tpReporteCombustible"
            Me.tpReporteCombustible.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporteCombustible.Size = New System.Drawing.Size(999, 492)
            Me.tpReporteCombustible.TabIndex = 2
            Me.tpReporteCombustible.Text = "REPORTE DE COMBUSTIBLE"
            Me.tpReporteCombustible.UseVisualStyleBackColor = True
            '
            'txtNumControl
            '
            Me.txtNumControl.BackColor = System.Drawing.Color.White
            Me.txtNumControl.Location = New System.Drawing.Point(829, 7)
            Me.txtNumControl.Name = "txtNumControl"
            Me.txtNumControl.Size = New System.Drawing.Size(79, 21)
            Me.txtNumControl.TabIndex = 6
            Me.txtNumControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnReporte
            '
            Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReporte.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Location = New System.Drawing.Point(914, 6)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(75, 23)
            Me.btnReporte.TabIndex = 1
            Me.btnReporte.Text = "REPORTE"
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'crvReporteCombustible
            '
            Me.crvReporteCombustible.ActiveViewIndex = -1
            Me.crvReporteCombustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvReporteCombustible.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvReporteCombustible.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvReporteCombustible.Location = New System.Drawing.Point(3, 3)
            Me.crvReporteCombustible.Name = "crvReporteCombustible"
            Me.crvReporteCombustible.Size = New System.Drawing.Size(993, 486)
            Me.crvReporteCombustible.TabIndex = 0
            Me.crvReporteCombustible.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'Label30
            '
            Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label30.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(379, 2)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(126, 19)
            Me.Label30.TabIndex = 26
            Me.Label30.Text = "MONTO ASIGNADO:"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1009, 32)
            Me.MenuStrip1.TabIndex = 186
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
            'lblMontoCajaChica
            '
            Me.lblMontoCajaChica.AutoSize = True
            Me.lblMontoCajaChica.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoCajaChica.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoCajaChica.Location = New System.Drawing.Point(732, 5)
            Me.lblMontoCajaChica.Name = "lblMontoCajaChica"
            Me.lblMontoCajaChica.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoCajaChica.TabIndex = 21
            Me.lblMontoCajaChica.Text = "00.00"
            '
            'lblMontoAsignado
            '
            Me.lblMontoAsignado.AutoSize = True
            Me.lblMontoAsignado.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoAsignado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAsignado.Location = New System.Drawing.Point(498, 4)
            Me.lblMontoAsignado.Name = "lblMontoAsignado"
            Me.lblMontoAsignado.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoAsignado.TabIndex = 27
            Me.lblMontoAsignado.Text = "00.00"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(614, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(126, 19)
            Me.Label3.TabIndex = 187
            Me.Label3.Text = "VALOR DISPONIBLE:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(828, 3)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(126, 19)
            Me.Label6.TabIndex = 188
            Me.Label6.Text = "VALOR X TRANS:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMontoPorTransaccion
            '
            Me.lblMontoPorTransaccion.AutoSize = True
            Me.lblMontoPorTransaccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoPorTransaccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoPorTransaccion.Location = New System.Drawing.Point(940, 6)
            Me.lblMontoPorTransaccion.Name = "lblMontoPorTransaccion"
            Me.lblMontoPorTransaccion.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoPorTransaccion.TabIndex = 189
            Me.lblMontoPorTransaccion.Text = "00.00"
            '
            'FormSolicitudGastoCajaChica
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1009, 556)
            Me.Controls.Add(Me.lblMontoPorTransaccion)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.lblMontoCajaChica)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblMontoAsignado)
            Me.Controls.Add(Me.Label30)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcSolicitudCajaChica)
            Me.Controls.Add(Me.txtTexto)
            Me.Controls.Add(Me.btnControlCombustible)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormSolicitudGastoCajaChica"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "SOLICITUD DE GASTO CAJA CHICA"
            Me.tcSolicitudCajaChica.ResumeLayout(False)
            Me.tpSolicitud.ResumeLayout(False)
            Me.tpSolicitud.PerformLayout()
            Me.gbRetenciones.ResumeLayout(False)
            Me.gbRetenciones.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbLlegadaVehiculo.ResumeLayout(False)
            Me.gbLlegadaVehiculo.PerformLayout()
            Me.gbVehiculo.ResumeLayout(False)
            Me.gbVehiculo.PerformLayout()
            Me.gpSalidaVehiculo.ResumeLayout(False)
            Me.gpSalidaVehiculo.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.gbDatos.ResumeLayout(False)
            Me.gbDatos.PerformLayout()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpReporteCombustible.ResumeLayout(False)
            Me.tpReporteCombustible.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnControlCombustible As System.Windows.Forms.Button
        Friend WithEvents txtTexto As System.Windows.Forms.TextBox
        Friend WithEvents tcSolicitudCajaChica As System.Windows.Forms.TabControl
        Friend WithEvents tpSolicitud As System.Windows.Forms.TabPage
        Friend WithEvents lblCaja As System.Windows.Forms.Label
        Friend WithEvents cbmCajasChicas As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarPersonalRecibe As System.Windows.Forms.Button
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtNombresRecibe As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtNombresEntrega As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtCedulaRecibe As System.Windows.Forms.TextBox
        Friend WithEvents txtCedulaEntrega As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents lblDetalle As System.Windows.Forms.Label
        Friend WithEvents txtDetalleGasto As System.Windows.Forms.TextBox
        Friend WithEvents lblValorGasto As System.Windows.Forms.Label
        Friend WithEvents txtValorGasto As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoHaber As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoDebe As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroSolicitud As System.Windows.Forms.TextBox
        Friend WithEvents cbmParametrosDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents cbmConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cbmAutoriza As System.Windows.Forms.ComboBox
        Friend WithEvents lblAutoriza As System.Windows.Forms.Label
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbmCombustible As System.Windows.Forms.ComboBox
        Friend WithEvents lblFechaControlC As System.Windows.Forms.Label
        Friend WithEvents txtTotalKmControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtMotivoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtDestinoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtValorControl As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivoControlC As System.Windows.Forms.Label
        Friend WithEvents lblTotaKmControlC As System.Windows.Forms.Label
        Friend WithEvents lblDestinoControlC As System.Windows.Forms.Label
        Friend WithEvents lblValorControlC As System.Windows.Forms.Label
        Friend WithEvents lblClaseGasolinaControlC As System.Windows.Forms.Label
        Friend WithEvents gbLlegadaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmLlegadaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents LblKilometrajeLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblHoraLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblFechaLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents gpSalidaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmSalidaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblKilometrajeSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblHoraSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblFechaSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents gbVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents lblIdActivo As System.Windows.Forms.Label
        Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtModeloVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtMarcaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblPlacaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblModeloVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblMarcaVehiculo As System.Windows.Forms.Label
        Friend WithEvents btnBuscarVehiculo As System.Windows.Forms.Button
        Friend WithEvents tpReporteCombustible As System.Windows.Forms.TabPage
        Friend WithEvents crvReporteCombustible As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents gbRetenciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkCombustible As System.Windows.Forms.CheckBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblMontoCajaChica As System.Windows.Forms.Label
        Friend WithEvents lblMontoAsignado As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtFechaControl As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnDocumento As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblMontoPorTransaccion As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvDetallesRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents eliminarItem As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtNumControl As System.Windows.Forms.TextBox
        Friend WithEvents lblIdCombustible As System.Windows.Forms.Label
        Friend WithEvents EjercicioFiscal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CodigoRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BaseImponible As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PorcentajeRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ValorRetenido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtNombreComercialCliente As TextBox
        Friend WithEvents Label5 As Label
    End Class
End Namespace