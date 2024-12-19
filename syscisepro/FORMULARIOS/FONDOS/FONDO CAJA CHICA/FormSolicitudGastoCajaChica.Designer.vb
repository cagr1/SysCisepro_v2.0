Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormSolicitudGastoCajaChica
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudGastoCajaChica))
            Me.btnControlCombustible = New System.Windows.Forms.Button()
            Me.txtTexto = New System.Windows.Forms.TextBox()
            Me.btnDocumento = New System.Windows.Forms.Button()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.cbmParametrosDocumentos = New System.Windows.Forms.ComboBox()
            Me.lblIdCombustible = New System.Windows.Forms.Label()
            Me.txtFechaControl = New System.Windows.Forms.DateTimePicker()
            Me.gbLlegadaVehiculo = New System.Windows.Forms.GroupBox()
            Me.dtpHoraLlegadaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaLlegadaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.txtKmLlegadaVehiculo = New System.Windows.Forms.TextBox()
            Me.LblKilometrajeLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.lblHoraLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.lblFechaLlegadaVehiculo = New System.Windows.Forms.Label()
            Me.txtIdActivoFijo = New System.Windows.Forms.TextBox()
            Me.btnBuscarVehiculo = New System.Windows.Forms.Button()
            Me.txtPlacaVehiculo = New System.Windows.Forms.TextBox()
            Me.txtModeloVehiculo = New System.Windows.Forms.TextBox()
            Me.txtMarcaVehiculo = New System.Windows.Forms.TextBox()
            Me.txtTotalKmControlC = New System.Windows.Forms.TextBox()
            Me.gpSalidaVehiculo = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpHoraSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.txtKmSalidaVehiculo = New System.Windows.Forms.TextBox()
            Me.chkCombustible = New System.Windows.Forms.CheckBox()
            Me.cbmCombustible = New System.Windows.Forms.ComboBox()
            Me.txtMotivoControlC = New System.Windows.Forms.TextBox()
            Me.txtDestinoControlC = New System.Windows.Forms.TextBox()
            Me.txtValorControl = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.btnBuscarPersonalRecibe = New System.Windows.Forms.Button()
            Me.txtNombresRecibe = New System.Windows.Forms.TextBox()
            Me.txtNombresEntrega = New System.Windows.Forms.TextBox()
            Me.txtCedulaRecibe = New System.Windows.Forms.TextBox()
            Me.txtCedulaEntrega = New System.Windows.Forms.TextBox()
            Me.txtDetalleGasto = New System.Windows.Forms.TextBox()
            Me.txtValorGasto = New System.Windows.Forms.TextBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtCodigoHaber = New System.Windows.Forms.TextBox()
            Me.txtCodigoDebe = New System.Windows.Forms.TextBox()
            Me.crvReporteCombustible = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.txtFecha = New System.Windows.Forms.DateTimePicker()
            Me.cbmAutoriza = New System.Windows.Forms.ComboBox()
            Me.txtNumeroSolicitud = New System.Windows.Forms.TextBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.cbmConcepto = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.cbmCajasChicas = New System.Windows.Forms.ComboBox()
            Me.dgvDetallesRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.KryptonDockableNavigator1 = New ComponentFactory.Krypton.Docking.KryptonDockableNavigator()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.gbCombustible = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.txtNumControl = New System.Windows.Forms.TextBox()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.gbLlegadaVehiculo.SuspendLayout()
            Me.gpSalidaVehiculo.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonDockableNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonDockableNavigator1.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.gbCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbCombustible.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCombustible.Panel.SuspendLayout()
            Me.gbCombustible.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
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
            'btnDocumento
            '
            Me.btnDocumento.BackColor = System.Drawing.Color.Transparent
            Me.btnDocumento.Enabled = False
            Me.btnDocumento.FlatAppearance.BorderSize = 0
            Me.btnDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDocumento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDocumento.Image = Global.syscisepro.My.Resources.Resources.upload_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDocumento.Location = New System.Drawing.Point(819, 227)
            Me.btnDocumento.Name = "btnDocumento"
            Me.btnDocumento.Size = New System.Drawing.Size(29, 29)
            Me.btnDocumento.TabIndex = 22
            Me.btnDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDocumento.UseVisualStyleBackColor = False
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Location = New System.Drawing.Point(444, 234)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(151, 22)
            Me.txtNroDocumento.TabIndex = 20
            '
            'cbmParametrosDocumentos
            '
            Me.cbmParametrosDocumentos.BackColor = System.Drawing.Color.White
            Me.cbmParametrosDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParametrosDocumentos.Enabled = False
            Me.cbmParametrosDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParametrosDocumentos.FormattingEnabled = True
            Me.cbmParametrosDocumentos.Location = New System.Drawing.Point(688, 236)
            Me.cbmParametrosDocumentos.Name = "cbmParametrosDocumentos"
            Me.cbmParametrosDocumentos.Size = New System.Drawing.Size(112, 21)
            Me.cbmParametrosDocumentos.TabIndex = 21
            '
            'lblIdCombustible
            '
            Me.lblIdCombustible.AutoSize = True
            Me.lblIdCombustible.BackColor = System.Drawing.Color.White
            Me.lblIdCombustible.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCombustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdCombustible.Location = New System.Drawing.Point(192, 275)
            Me.lblIdCombustible.Name = "lblIdCombustible"
            Me.lblIdCombustible.Size = New System.Drawing.Size(0, 15)
            Me.lblIdCombustible.TabIndex = 36
            '
            'txtFechaControl
            '
            Me.txtFechaControl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtFechaControl.Location = New System.Drawing.Point(76, 10)
            Me.txtFechaControl.Name = "txtFechaControl"
            Me.txtFechaControl.Size = New System.Drawing.Size(99, 22)
            Me.txtFechaControl.TabIndex = 24
            '
            'gbLlegadaVehiculo
            '
            Me.gbLlegadaVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.gbLlegadaVehiculo.Controls.Add(Me.dtpHoraLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.dtpFechaLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.txtKmLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.LblKilometrajeLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.lblHoraLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Controls.Add(Me.lblFechaLlegadaVehiculo)
            Me.gbLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbLlegadaVehiculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbLlegadaVehiculo.Location = New System.Drawing.Point(452, 68)
            Me.gbLlegadaVehiculo.Name = "gbLlegadaVehiculo"
            Me.gbLlegadaVehiculo.Size = New System.Drawing.Size(191, 100)
            Me.gbLlegadaVehiculo.TabIndex = 32
            Me.gbLlegadaVehiculo.TabStop = False
            Me.gbLlegadaVehiculo.Text = "Llegada"
            '
            'dtpHoraLlegadaVehiculo
            '
            Me.dtpHoraLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraLlegadaVehiculo.Location = New System.Drawing.Point(49, 46)
            Me.dtpHoraLlegadaVehiculo.Name = "dtpHoraLlegadaVehiculo"
            Me.dtpHoraLlegadaVehiculo.ShowUpDown = True
            Me.dtpHoraLlegadaVehiculo.Size = New System.Drawing.Size(95, 21)
            Me.dtpHoraLlegadaVehiculo.TabIndex = 36
            '
            'dtpFechaLlegadaVehiculo
            '
            Me.dtpFechaLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaLlegadaVehiculo.Location = New System.Drawing.Point(49, 19)
            Me.dtpFechaLlegadaVehiculo.Name = "dtpFechaLlegadaVehiculo"
            Me.dtpFechaLlegadaVehiculo.Size = New System.Drawing.Size(95, 21)
            Me.dtpFechaLlegadaVehiculo.TabIndex = 35
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(49, 73)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(95, 21)
            Me.txtKmLlegadaVehiculo.TabIndex = 37
            Me.txtKmLlegadaVehiculo.Text = "0"
            '
            'LblKilometrajeLlegadaVehiculo
            '
            Me.LblKilometrajeLlegadaVehiculo.AutoSize = True
            Me.LblKilometrajeLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblKilometrajeLlegadaVehiculo.Location = New System.Drawing.Point(8, 76)
            Me.LblKilometrajeLlegadaVehiculo.Name = "LblKilometrajeLlegadaVehiculo"
            Me.LblKilometrajeLlegadaVehiculo.Size = New System.Drawing.Size(24, 13)
            Me.LblKilometrajeLlegadaVehiculo.TabIndex = 2
            Me.LblKilometrajeLlegadaVehiculo.Text = "Km"
            '
            'lblHoraLlegadaVehiculo
            '
            Me.lblHoraLlegadaVehiculo.AutoSize = True
            Me.lblHoraLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraLlegadaVehiculo.Location = New System.Drawing.Point(8, 48)
            Me.lblHoraLlegadaVehiculo.Name = "lblHoraLlegadaVehiculo"
            Me.lblHoraLlegadaVehiculo.Size = New System.Drawing.Size(31, 13)
            Me.lblHoraLlegadaVehiculo.TabIndex = 1
            Me.lblHoraLlegadaVehiculo.Text = "Hora"
            '
            'lblFechaLlegadaVehiculo
            '
            Me.lblFechaLlegadaVehiculo.AutoSize = True
            Me.lblFechaLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaLlegadaVehiculo.Location = New System.Drawing.Point(8, 22)
            Me.lblFechaLlegadaVehiculo.Name = "lblFechaLlegadaVehiculo"
            Me.lblFechaLlegadaVehiculo.Size = New System.Drawing.Size(37, 13)
            Me.lblFechaLlegadaVehiculo.TabIndex = 0
            Me.lblFechaLlegadaVehiculo.Text = "Fecha"
            '
            'txtIdActivoFijo
            '
            Me.txtIdActivoFijo.BackColor = System.Drawing.Color.White
            Me.txtIdActivoFijo.Enabled = False
            Me.txtIdActivoFijo.Location = New System.Drawing.Point(77, 94)
            Me.txtIdActivoFijo.Name = "txtIdActivoFijo"
            Me.txtIdActivoFijo.Size = New System.Drawing.Size(98, 22)
            Me.txtIdActivoFijo.TabIndex = 30
            Me.txtIdActivoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnBuscarVehiculo
            '
            Me.btnBuscarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscarVehiculo.Location = New System.Drawing.Point(192, 93)
            Me.btnBuscarVehiculo.Name = "btnBuscarVehiculo"
            Me.btnBuscarVehiculo.Size = New System.Drawing.Size(26, 24)
            Me.btnBuscarVehiculo.TabIndex = 31
            Me.btnBuscarVehiculo.Text = "..."
            Me.btnBuscarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscarVehiculo.UseVisualStyleBackColor = True
            '
            'txtPlacaVehiculo
            '
            Me.txtPlacaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtPlacaVehiculo.Enabled = False
            Me.txtPlacaVehiculo.Location = New System.Drawing.Point(304, 126)
            Me.txtPlacaVehiculo.Name = "txtPlacaVehiculo"
            Me.txtPlacaVehiculo.Size = New System.Drawing.Size(141, 22)
            Me.txtPlacaVehiculo.TabIndex = 34
            Me.txtPlacaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtModeloVehiculo
            '
            Me.txtModeloVehiculo.BackColor = System.Drawing.Color.White
            Me.txtModeloVehiculo.Enabled = False
            Me.txtModeloVehiculo.Location = New System.Drawing.Point(304, 96)
            Me.txtModeloVehiculo.Name = "txtModeloVehiculo"
            Me.txtModeloVehiculo.Size = New System.Drawing.Size(141, 22)
            Me.txtModeloVehiculo.TabIndex = 33
            Me.txtModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtMarcaVehiculo
            '
            Me.txtMarcaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtMarcaVehiculo.Enabled = False
            Me.txtMarcaVehiculo.Location = New System.Drawing.Point(77, 126)
            Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
            Me.txtMarcaVehiculo.Size = New System.Drawing.Size(141, 22)
            Me.txtMarcaVehiculo.TabIndex = 32
            Me.txtMarcaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtTotalKmControlC
            '
            Me.txtTotalKmControlC.BackColor = System.Drawing.Color.White
            Me.txtTotalKmControlC.Enabled = False
            Me.txtTotalKmControlC.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalKmControlC.Location = New System.Drawing.Point(745, 9)
            Me.txtTotalKmControlC.Name = "txtTotalKmControlC"
            Me.txtTotalKmControlC.Size = New System.Drawing.Size(47, 21)
            Me.txtTotalKmControlC.TabIndex = 29
            Me.txtTotalKmControlC.Text = "0"
            Me.txtTotalKmControlC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'gpSalidaVehiculo
            '
            Me.gpSalidaVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.gpSalidaVehiculo.Controls.Add(Me.Label5)
            Me.gpSalidaVehiculo.Controls.Add(Me.Label4)
            Me.gpSalidaVehiculo.Controls.Add(Me.Label2)
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpHoraSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpFechaSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.txtKmSalidaVehiculo)
            Me.gpSalidaVehiculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gpSalidaVehiculo.Location = New System.Drawing.Point(671, 68)
            Me.gpSalidaVehiculo.Name = "gpSalidaVehiculo"
            Me.gpSalidaVehiculo.Size = New System.Drawing.Size(178, 100)
            Me.gpSalidaVehiculo.TabIndex = 31
            Me.gpSalidaVehiculo.TabStop = False
            Me.gpSalidaVehiculo.Text = "Salida"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(6, 75)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(24, 13)
            Me.Label5.TabIndex = 38
            Me.Label5.Text = "Km"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(6, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 38
            Me.Label4.Text = "Hora"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(37, 13)
            Me.Label2.TabIndex = 38
            Me.Label2.Text = "Fecha"
            '
            'dtpHoraSalidaVehiculo
            '
            Me.dtpHoraSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraSalidaVehiculo.Location = New System.Drawing.Point(46, 45)
            Me.dtpHoraSalidaVehiculo.Name = "dtpHoraSalidaVehiculo"
            Me.dtpHoraSalidaVehiculo.ShowUpDown = True
            Me.dtpHoraSalidaVehiculo.Size = New System.Drawing.Size(95, 22)
            Me.dtpHoraSalidaVehiculo.TabIndex = 39
            '
            'dtpFechaSalidaVehiculo
            '
            Me.dtpFechaSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaSalidaVehiculo.Location = New System.Drawing.Point(46, 16)
            Me.dtpFechaSalidaVehiculo.Name = "dtpFechaSalidaVehiculo"
            Me.dtpFechaSalidaVehiculo.Size = New System.Drawing.Size(95, 22)
            Me.dtpFechaSalidaVehiculo.TabIndex = 38
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(46, 71)
            Me.txtKmSalidaVehiculo.Name = "txtKmSalidaVehiculo"
            Me.txtKmSalidaVehiculo.Size = New System.Drawing.Size(95, 22)
            Me.txtKmSalidaVehiculo.TabIndex = 40
            Me.txtKmSalidaVehiculo.Text = "0"
            '
            'chkCombustible
            '
            Me.chkCombustible.AutoSize = True
            Me.chkCombustible.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkCombustible.Enabled = False
            Me.chkCombustible.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCombustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkCombustible.Location = New System.Drawing.Point(10, 277)
            Me.chkCombustible.Name = "chkCombustible"
            Me.chkCombustible.Size = New System.Drawing.Size(143, 17)
            Me.chkCombustible.TabIndex = 23
            Me.chkCombustible.Text = "Control de Combustible"
            Me.chkCombustible.UseVisualStyleBackColor = False
            '
            'cbmCombustible
            '
            Me.cbmCombustible.BackColor = System.Drawing.Color.White
            Me.cbmCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCombustible.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCombustible.FormattingEnabled = True
            Me.cbmCombustible.Location = New System.Drawing.Point(304, 9)
            Me.cbmCombustible.Name = "cbmCombustible"
            Me.cbmCombustible.Size = New System.Drawing.Size(132, 21)
            Me.cbmCombustible.TabIndex = 25
            '
            'txtMotivoControlC
            '
            Me.txtMotivoControlC.BackColor = System.Drawing.Color.White
            Me.txtMotivoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMotivoControlC.Location = New System.Drawing.Point(452, 38)
            Me.txtMotivoControlC.Name = "txtMotivoControlC"
            Me.txtMotivoControlC.Size = New System.Drawing.Size(295, 22)
            Me.txtMotivoControlC.TabIndex = 28
            '
            'txtDestinoControlC
            '
            Me.txtDestinoControlC.BackColor = System.Drawing.Color.White
            Me.txtDestinoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDestinoControlC.Location = New System.Drawing.Point(77, 38)
            Me.txtDestinoControlC.Name = "txtDestinoControlC"
            Me.txtDestinoControlC.Size = New System.Drawing.Size(283, 22)
            Me.txtDestinoControlC.TabIndex = 27
            '
            'txtValorControl
            '
            Me.txtValorControl.BackColor = System.Drawing.Color.White
            Me.txtValorControl.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorControl.ForeColor = System.Drawing.Color.Black
            Me.txtValorControl.Location = New System.Drawing.Point(501, 11)
            Me.txtValorControl.Name = "txtValorControl"
            Me.txtValorControl.Size = New System.Drawing.Size(83, 21)
            Me.txtValorControl.TabIndex = 26
            Me.txtValorControl.Text = "0.00"
            Me.txtValorControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialCliente.Enabled = False
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(444, 178)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(337, 22)
            Me.txtNombreComercialCliente.TabIndex = 22
            '
            'btnBuscarPersonalRecibe
            '
            Me.btnBuscarPersonalRecibe.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnBuscarPersonalRecibe.Enabled = False
            Me.btnBuscarPersonalRecibe.Location = New System.Drawing.Point(549, 120)
            Me.btnBuscarPersonalRecibe.Name = "btnBuscarPersonalRecibe"
            Me.btnBuscarPersonalRecibe.Size = New System.Drawing.Size(30, 24)
            Me.btnBuscarPersonalRecibe.TabIndex = 13
            Me.btnBuscarPersonalRecibe.Text = "..."
            Me.btnBuscarPersonalRecibe.UseVisualStyleBackColor = True
            '
            'txtNombresRecibe
            '
            Me.txtNombresRecibe.BackColor = System.Drawing.Color.White
            Me.txtNombresRecibe.Enabled = False
            Me.txtNombresRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtNombresRecibe.Location = New System.Drawing.Point(444, 150)
            Me.txtNombresRecibe.Name = "txtNombresRecibe"
            Me.txtNombresRecibe.Size = New System.Drawing.Size(238, 22)
            Me.txtNombresRecibe.TabIndex = 15
            '
            'txtNombresEntrega
            '
            Me.txtNombresEntrega.BackColor = System.Drawing.Color.White
            Me.txtNombresEntrega.Enabled = False
            Me.txtNombresEntrega.ForeColor = System.Drawing.Color.Black
            Me.txtNombresEntrega.Location = New System.Drawing.Point(75, 152)
            Me.txtNombresEntrega.Name = "txtNombresEntrega"
            Me.txtNombresEntrega.Size = New System.Drawing.Size(284, 22)
            Me.txtNombresEntrega.TabIndex = 12
            '
            'txtCedulaRecibe
            '
            Me.txtCedulaRecibe.BackColor = System.Drawing.Color.White
            Me.txtCedulaRecibe.Enabled = False
            Me.txtCedulaRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtCedulaRecibe.Location = New System.Drawing.Point(444, 122)
            Me.txtCedulaRecibe.Name = "txtCedulaRecibe"
            Me.txtCedulaRecibe.Size = New System.Drawing.Size(83, 22)
            Me.txtCedulaRecibe.TabIndex = 14
            '
            'txtCedulaEntrega
            '
            Me.txtCedulaEntrega.BackColor = System.Drawing.Color.White
            Me.txtCedulaEntrega.Enabled = False
            Me.txtCedulaEntrega.ForeColor = System.Drawing.Color.Black
            Me.txtCedulaEntrega.Location = New System.Drawing.Point(76, 124)
            Me.txtCedulaEntrega.Name = "txtCedulaEntrega"
            Me.txtCedulaEntrega.Size = New System.Drawing.Size(102, 22)
            Me.txtCedulaEntrega.TabIndex = 11
            '
            'txtDetalleGasto
            '
            Me.txtDetalleGasto.BackColor = System.Drawing.Color.White
            Me.txtDetalleGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleGasto.Enabled = False
            Me.txtDetalleGasto.Location = New System.Drawing.Point(76, 234)
            Me.txtDetalleGasto.Multiline = True
            Me.txtDetalleGasto.Name = "txtDetalleGasto"
            Me.txtDetalleGasto.Size = New System.Drawing.Size(283, 22)
            Me.txtDetalleGasto.TabIndex = 19
            '
            'txtValorGasto
            '
            Me.txtValorGasto.BackColor = System.Drawing.Color.White
            Me.txtValorGasto.Enabled = False
            Me.txtValorGasto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorGasto.Location = New System.Drawing.Point(75, 205)
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
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.CODIGO, Me.CUENTA, Me.VALOR, Me.IVA})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(31, 281)
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
            'txtCodigoHaber
            '
            Me.txtCodigoHaber.BackColor = System.Drawing.Color.White
            Me.txtCodigoHaber.Enabled = False
            Me.txtCodigoHaber.ForeColor = System.Drawing.Color.White
            Me.txtCodigoHaber.Location = New System.Drawing.Point(787, 149)
            Me.txtCodigoHaber.Name = "txtCodigoHaber"
            Me.txtCodigoHaber.Size = New System.Drawing.Size(93, 22)
            Me.txtCodigoHaber.TabIndex = 17
            Me.txtCodigoHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoDebe
            '
            Me.txtCodigoDebe.BackColor = System.Drawing.Color.White
            Me.txtCodigoDebe.Enabled = False
            Me.txtCodigoDebe.ForeColor = System.Drawing.Color.White
            Me.txtCodigoDebe.Location = New System.Drawing.Point(688, 149)
            Me.txtCodigoDebe.Name = "txtCodigoDebe"
            Me.txtCodigoDebe.Size = New System.Drawing.Size(93, 22)
            Me.txtCodigoDebe.TabIndex = 16
            Me.txtCodigoDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'crvReporteCombustible
            '
            Me.crvReporteCombustible.ActiveViewIndex = -1
            Me.crvReporteCombustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvReporteCombustible.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvReporteCombustible.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvReporteCombustible.Location = New System.Drawing.Point(0, 0)
            Me.crvReporteCombustible.Name = "crvReporteCombustible"
            Me.crvReporteCombustible.ShowLogo = False
            Me.crvReporteCombustible.Size = New System.Drawing.Size(893, 468)
            Me.crvReporteCombustible.TabIndex = 0
            Me.crvReporteCombustible.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtFecha.Location = New System.Drawing.Point(365, 3)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(93, 22)
            Me.txtFecha.TabIndex = 3
            '
            'cbmAutoriza
            '
            Me.cbmAutoriza.BackColor = System.Drawing.Color.White
            Me.cbmAutoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmAutoriza.Enabled = False
            Me.cbmAutoriza.FormattingEnabled = True
            Me.cbmAutoriza.Location = New System.Drawing.Point(600, 4)
            Me.cbmAutoriza.Name = "cbmAutoriza"
            Me.cbmAutoriza.Size = New System.Drawing.Size(213, 21)
            Me.cbmAutoriza.TabIndex = 4
            '
            'txtNumeroSolicitud
            '
            Me.txtNumeroSolicitud.BackColor = System.Drawing.Color.White
            Me.txtNumeroSolicitud.Enabled = False
            Me.txtNumeroSolicitud.Location = New System.Drawing.Point(39, 5)
            Me.txtNumeroSolicitud.Name = "txtNumeroSolicitud"
            Me.txtNumeroSolicitud.Size = New System.Drawing.Size(60, 22)
            Me.txtNumeroSolicitud.TabIndex = 1
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(76, 73)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(103, 21)
            Me.cbmProvincia.TabIndex = 8
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.Enabled = False
            Me.txtActividad.Location = New System.Drawing.Point(76, 40)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(103, 22)
            Me.txtActividad.TabIndex = 5
            Me.txtActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cbmConcepto
            '
            Me.cbmConcepto.BackColor = System.Drawing.Color.White
            Me.cbmConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmConcepto.Enabled = False
            Me.cbmConcepto.FormattingEnabled = True
            Me.cbmConcepto.Location = New System.Drawing.Point(254, 38)
            Me.cbmConcepto.Name = "cbmConcepto"
            Me.cbmConcepto.Size = New System.Drawing.Size(200, 21)
            Me.cbmConcepto.TabIndex = 6
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Enabled = False
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(600, 38)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(213, 21)
            Me.cbmCentroCosto.TabIndex = 7
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(600, 73)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(213, 21)
            Me.cbmParroquia.TabIndex = 10
            '
            'cbmCanton
            '
            Me.cbmCanton.BackColor = System.Drawing.Color.White
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Enabled = False
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(254, 72)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(200, 21)
            Me.cbmCanton.TabIndex = 9
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Enabled = False
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(410, 3)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(43, 22)
            Me.dtpComprobanteRetencion.TabIndex = 45
            Me.dtpComprobanteRetencion.Visible = False
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(374, 3)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(31, 22)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 44
            Me.dtpFechaEmisionComprobanteCompra.Visible = False
            '
            'cbmCajasChicas
            '
            Me.cbmCajasChicas.BackColor = System.Drawing.Color.White
            Me.cbmCajasChicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCajasChicas.Enabled = False
            Me.cbmCajasChicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCajasChicas.FormattingEnabled = True
            Me.cbmCajasChicas.Location = New System.Drawing.Point(152, 5)
            Me.cbmCajasChicas.Name = "cbmCajasChicas"
            Me.cbmCajasChicas.Size = New System.Drawing.Size(150, 21)
            Me.cbmCajasChicas.TabIndex = 2
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
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetallesRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvDetallesRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetallesRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetallesRetencion.Location = New System.Drawing.Point(38, 144)
            Me.dgvDetallesRetencion.MultiSelect = False
            Me.dgvDetallesRetencion.Name = "dgvDetallesRetencion"
            Me.dgvDetallesRetencion.ReadOnly = True
            Me.dgvDetallesRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetallesRetencion.RowHeadersVisible = False
            Me.dgvDetallesRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetallesRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetallesRetencion.Size = New System.Drawing.Size(185, 85)
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
            'Label30
            '
            Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label30.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(347, 13)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(118, 19)
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
            Me.MenuStrip1.Size = New System.Drawing.Size(895, 32)
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
            Me.lblMontoCajaChica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMontoCajaChica.Location = New System.Drawing.Point(646, 16)
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
            Me.lblMontoAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMontoAsignado.Location = New System.Drawing.Point(469, 16)
            Me.lblMontoAsignado.Name = "lblMontoAsignado"
            Me.lblMontoAsignado.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoAsignado.TabIndex = 27
            Me.lblMontoAsignado.Text = "00.00"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(526, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(114, 19)
            Me.Label3.TabIndex = 187
            Me.Label3.Text = "VALOR DISPONIBLE:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(698, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(101, 19)
            Me.Label6.TabIndex = 188
            Me.Label6.Text = "VALOR X TRANS:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMontoPorTransaccion
            '
            Me.lblMontoPorTransaccion.AutoSize = True
            Me.lblMontoPorTransaccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoPorTransaccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoPorTransaccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMontoPorTransaccion.Location = New System.Drawing.Point(805, 16)
            Me.lblMontoPorTransaccion.Name = "lblMontoPorTransaccion"
            Me.lblMontoPorTransaccion.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoPorTransaccion.TabIndex = 189
            Me.lblMontoPorTransaccion.Text = "00.00"
            '
            'KryptonDockableNavigator1
            '
            Me.KryptonDockableNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonDockableNavigator1.Name = "KryptonDockableNavigator1"
            Me.KryptonDockableNavigator1.Size = New System.Drawing.Size(250, 150)
            Me.KryptonDockableNavigator1.TabIndex = 0
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(895, 495)
            Me.KryptonNavigator1.TabIndex = 190
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.lblIdCombustible)
            Me.KryptonPage1.Controls.Add(Me.gbCombustible)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.chkCombustible)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(893, 468)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Registro Solicitudes"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "CBC9E2EE499240D362B0F89E4AB658E2"
            '
            'gbCombustible
            '
            Me.gbCombustible.Enabled = False
            Me.gbCombustible.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.gbCombustible.Location = New System.Drawing.Point(0, 292)
            Me.gbCombustible.Name = "gbCombustible"
            '
            'gbCombustible.Panel
            '
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel37)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel36)
            Me.gbCombustible.Panel.Controls.Add(Me.btnBuscarVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtPlacaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtIdActivoFijo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtModeloVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel35)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel34)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel33)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel32)
            Me.gbCombustible.Panel.Controls.Add(Me.gbLlegadaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtMarcaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.gpSalidaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel31)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel30)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel29)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel28)
            Me.gbCombustible.Panel.Controls.Add(Me.txtTotalKmControlC)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel27)
            Me.gbCombustible.Panel.Controls.Add(Me.txtFechaControl)
            Me.gbCombustible.Panel.Controls.Add(Me.txtDestinoControlC)
            Me.gbCombustible.Panel.Controls.Add(Me.cbmCombustible)
            Me.gbCombustible.Panel.Controls.Add(Me.txtValorControl)
            Me.gbCombustible.Panel.Controls.Add(Me.txtMotivoControlC)
            Me.gbCombustible.Size = New System.Drawing.Size(889, 177)
            Me.gbCombustible.TabIndex = 4
            Me.gbCombustible.Values.Heading = ""
            '
            'KryptonLabel37
            '
            Me.KryptonLabel37.Location = New System.Drawing.Point(254, 127)
            Me.KryptonLabel37.Name = "KryptonLabel37"
            Me.KryptonLabel37.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel37.TabIndex = 77
            Me.KryptonLabel37.Values.Text = "Placa"
            '
            'KryptonLabel36
            '
            Me.KryptonLabel36.Location = New System.Drawing.Point(255, 98)
            Me.KryptonLabel36.Name = "KryptonLabel36"
            Me.KryptonLabel36.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel36.TabIndex = 76
            Me.KryptonLabel36.Values.Text = "Marca"
            '
            'KryptonLabel35
            '
            Me.KryptonLabel35.Location = New System.Drawing.Point(10, 126)
            Me.KryptonLabel35.Name = "KryptonLabel35"
            Me.KryptonLabel35.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel35.TabIndex = 75
            Me.KryptonLabel35.Values.Text = "Marca"
            '
            'KryptonLabel34
            '
            Me.KryptonLabel34.Location = New System.Drawing.Point(10, 94)
            Me.KryptonLabel34.Name = "KryptonLabel34"
            Me.KryptonLabel34.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel34.TabIndex = 74
            Me.KryptonLabel34.Values.Text = "Activo"
            '
            'KryptonLabel33
            '
            Me.KryptonLabel33.Location = New System.Drawing.Point(9, 68)
            Me.KryptonLabel33.Name = "KryptonLabel33"
            Me.KryptonLabel33.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel33.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel33.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel33.TabIndex = 68
            Me.KryptonLabel33.Values.Text = "Vehiculo"
            '
            'KryptonLabel32
            '
            Me.KryptonLabel32.Location = New System.Drawing.Point(680, 10)
            Me.KryptonLabel32.Name = "KryptonLabel32"
            Me.KryptonLabel32.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel32.TabIndex = 73
            Me.KryptonLabel32.Values.Text = "Total Km"
            '
            'KryptonLabel31
            '
            Me.KryptonLabel31.Location = New System.Drawing.Point(375, 38)
            Me.KryptonLabel31.Name = "KryptonLabel31"
            Me.KryptonLabel31.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel31.TabIndex = 72
            Me.KryptonLabel31.Values.Text = "Motivo"
            '
            'KryptonLabel30
            '
            Me.KryptonLabel30.Location = New System.Drawing.Point(452, 12)
            Me.KryptonLabel30.Name = "KryptonLabel30"
            Me.KryptonLabel30.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel30.TabIndex = 71
            Me.KryptonLabel30.Values.Text = "Valor"
            '
            'KryptonLabel29
            '
            Me.KryptonLabel29.Location = New System.Drawing.Point(192, 10)
            Me.KryptonLabel29.Name = "KryptonLabel29"
            Me.KryptonLabel29.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel29.TabIndex = 70
            Me.KryptonLabel29.Values.Text = "Combustible"
            '
            'KryptonLabel28
            '
            Me.KryptonLabel28.Location = New System.Drawing.Point(10, 38)
            Me.KryptonLabel28.Name = "KryptonLabel28"
            Me.KryptonLabel28.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel28.TabIndex = 69
            Me.KryptonLabel28.Values.Text = "Destino"
            '
            'KryptonLabel27
            '
            Me.KryptonLabel27.Location = New System.Drawing.Point(10, 12)
            Me.KryptonLabel27.Name = "KryptonLabel27"
            Me.KryptonLabel27.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel27.TabIndex = 68
            Me.KryptonLabel27.Values.Text = "Fecha"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 2)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel26)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel25)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParametrosDocumentos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel24)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel23)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalleGasto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorGasto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoHaber)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoDebe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarPersonalRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombresRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedulaRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombresEntrega)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedulaEntrega)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmAutoriza)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpComprobanteRetencion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumeroSolicitud)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCajasChicas)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(889, 273)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(625, 236)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel26.TabIndex = 67
            Me.KryptonLabel26.Values.Text = "Codigo"
            '
            'KryptonLabel25
            '
            Me.KryptonLabel25.Location = New System.Drawing.Point(376, 234)
            Me.KryptonLabel25.Name = "KryptonLabel25"
            Me.KryptonLabel25.Size = New System.Drawing.Size(27, 20)
            Me.KryptonLabel25.TabIndex = 66
            Me.KryptonLabel25.Values.Text = "No"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(376, 208)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel24.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel24.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel24.TabIndex = 65
            Me.KryptonLabel24.Values.Text = "Documento"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(8, 234)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel23.TabIndex = 64
            Me.KryptonLabel23.Values.Text = "Detalle"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(9, 208)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel22.TabIndex = 63
            Me.KryptonLabel22.Values.Text = "Valor"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(8, 180)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel21.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel21.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel21.TabIndex = 62
            Me.KryptonLabel21.Values.Text = "Gasto"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(787, 121)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel20.TabIndex = 61
            Me.KryptonLabel20.Values.Text = "Haber"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(688, 121)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel19.TabIndex = 60
            Me.KryptonLabel19.Values.Text = "Debe"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(688, 100)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel18.Size = New System.Drawing.Size(94, 20)
            Me.KryptonLabel18.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel18.TabIndex = 59
            Me.KryptonLabel18.Values.Text = "Contabilizacion"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(376, 180)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel17.TabIndex = 58
            Me.KryptonLabel17.Values.Text = "Cliente"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(374, 154)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel16.TabIndex = 57
            Me.KryptonLabel16.Values.Text = "Nombres"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(374, 122)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel15.TabIndex = 56
            Me.KryptonLabel15.Values.Text = "Cedula"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(374, 99)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel14.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel14.TabIndex = 55
            Me.KryptonLabel14.Values.Text = "Recibe"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(6, 154)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel13.TabIndex = 54
            Me.KryptonLabel13.Values.Text = "Nombres"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(9, 124)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel12.TabIndex = 53
            Me.KryptonLabel12.Values.Text = "Cedula"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(9, 99)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
            Me.KryptonLabel11.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel11.TabIndex = 52
            Me.KryptonLabel11.Values.Text = "Entrega"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(485, 73)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel10.TabIndex = 51
            Me.KryptonLabel10.Values.Text = "Parroquia"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(191, 72)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel9.TabIndex = 50
            Me.KryptonLabel9.Values.Text = "Canton"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(8, 73)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel8.TabIndex = 49
            Me.KryptonLabel8.Values.Text = "Provincia"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(484, 40)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(99, 20)
            Me.KryptonLabel7.TabIndex = 48
            Me.KryptonLabel7.Values.Text = "Centro de Costo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(191, 40)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel6.TabIndex = 47
            Me.KryptonLabel6.Values.Text = "Concepto"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(8, 40)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel5.TabIndex = 46
            Me.KryptonLabel5.Values.Text = "Actividad"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(485, 3)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel4.TabIndex = 4
            Me.KryptonLabel4.Values.Text = "Autoriza"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(317, 3)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel3.TabIndex = 3
            Me.KryptonLabel3.Values.Text = "Fecha"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(109, 5)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel2.TabIndex = 2
            Me.KryptonLabel2.Values.Text = "Caja"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(6, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(27, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "No"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.txtNumControl)
            Me.KryptonPage2.Controls.Add(Me.btnReporte)
            Me.KryptonPage2.Controls.Add(Me.crvReporteCombustible)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(893, 468)
            Me.KryptonPage2.Text = "Reporte Combustible"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "1F88DC0C62DD43329DADA882EC8C8324"
            '
            'txtNumControl
            '
            Me.txtNumControl.BackColor = System.Drawing.Color.White
            Me.txtNumControl.Location = New System.Drawing.Point(688, 4)
            Me.txtNumControl.Name = "txtNumControl"
            Me.txtNumControl.Size = New System.Drawing.Size(79, 22)
            Me.txtNumControl.TabIndex = 8
            Me.txtNumControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnReporte
            '
            Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReporte.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Location = New System.Drawing.Point(773, 3)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(75, 23)
            Me.btnReporte.TabIndex = 7
            Me.btnReporte.Text = "REPORTE"
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'FormSolicitudGastoCajaChica
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(895, 527)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.lblMontoPorTransaccion)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.lblMontoCajaChica)
            Me.Controls.Add(Me.dgvAsientosDiario)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblMontoAsignado)
            Me.Controls.Add(Me.Label30)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtTexto)
            Me.Controls.Add(Me.btnControlCombustible)
            Me.Controls.Add(Me.dgvDetallesRetencion)
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
            Me.gbLlegadaVehiculo.ResumeLayout(False)
            Me.gbLlegadaVehiculo.PerformLayout()
            Me.gpSalidaVehiculo.ResumeLayout(False)
            Me.gpSalidaVehiculo.PerformLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonDockableNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonDockableNavigator1.ResumeLayout(False)
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.gbCombustible.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCombustible.Panel.ResumeLayout(False)
            Me.gbCombustible.Panel.PerformLayout()
            CType(Me.gbCombustible, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCombustible.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.KryptonPage2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnControlCombustible As System.Windows.Forms.Button
        Friend WithEvents txtTexto As System.Windows.Forms.TextBox
        Friend WithEvents cbmCajasChicas As System.Windows.Forms.ComboBox
        Friend WithEvents btnBuscarPersonalRecibe As System.Windows.Forms.Button
        Friend WithEvents txtNombresRecibe As System.Windows.Forms.TextBox
        Friend WithEvents txtNombresEntrega As System.Windows.Forms.TextBox
        Friend WithEvents txtCedulaRecibe As System.Windows.Forms.TextBox
        Friend WithEvents txtCedulaEntrega As System.Windows.Forms.TextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtDetalleGasto As System.Windows.Forms.TextBox
        Friend WithEvents txtValorGasto As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoDebe As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroSolicitud As System.Windows.Forms.TextBox
        Friend WithEvents cbmParametrosDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents cbmConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cbmAutoriza As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCombustible As System.Windows.Forms.ComboBox
        Friend WithEvents txtTotalKmControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtMotivoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtDestinoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtValorControl As System.Windows.Forms.TextBox
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
        Friend WithEvents txtIdActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtModeloVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtMarcaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscarVehiculo As System.Windows.Forms.Button
        Friend WithEvents crvReporteCombustible As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents chkCombustible As System.Windows.Forms.CheckBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblMontoCajaChica As System.Windows.Forms.Label
        Friend WithEvents lblMontoAsignado As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtFechaControl As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnDocumento As System.Windows.Forms.Button
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
        Friend KryptonDockableNavigator1 As ComponentFactory.Krypton.Docking.KryptonDockableNavigator
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbCombustible As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents txtNumControl As TextBox
        Friend WithEvents btnReporte As Button
    End Class
End Namespace