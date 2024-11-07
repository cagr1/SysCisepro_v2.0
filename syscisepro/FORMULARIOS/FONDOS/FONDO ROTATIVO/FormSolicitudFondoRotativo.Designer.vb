Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormSolicitudFondoRotativo
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudFondoRotativo))
            Me.txtNroSolicitudFR = New System.Windows.Forms.TextBox()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.txtActividadDetalleFR = New System.Windows.Forms.TextBox()
            Me.txtCodHaber = New System.Windows.Forms.TextBox()
            Me.txtCodDebe = New System.Windows.Forms.TextBox()
            Me.txtApellidoResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.cmbCargoResponsableAutoFR = New System.Windows.Forms.ComboBox()
            Me.txtNombreResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtCIResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.txtValorSolicitudFR = New System.Windows.Forms.TextBox()
            Me.txtDetalleSolicitudFR = New System.Windows.Forms.TextBox()
            Me.gbReferencia = New System.Windows.Forms.GroupBox()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.dgvDetallesRetencion = New System.Windows.Forms.DataGridView()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtFechaSolicitudFR = New System.Windows.Forms.DateTimePicker()
            Me.txtNombreComercialCliente = New System.Windows.Forms.TextBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtReceptorDineroSolicitud = New System.Windows.Forms.TextBox()
            Me.txtCIReceptorDinero = New System.Windows.Forms.TextBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.btnDocumento = New System.Windows.Forms.Button()
            Me.cmbNombreParametroDocumentos = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.chkCombustible = New System.Windows.Forms.CheckBox()
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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpHoraSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaSalidaVehiculo = New System.Windows.Forms.DateTimePicker()
            Me.txtKmSalidaVehiculo = New System.Windows.Forms.TextBox()
            Me.lblKilometrajeSalidaVehiculo = New System.Windows.Forms.Label()
            Me.cbmCombustible = New System.Windows.Forms.ComboBox()
            Me.txtMotivoControlC = New System.Windows.Forms.TextBox()
            Me.txtDestinoControlC = New System.Windows.Forms.TextBox()
            Me.txtValorControl = New System.Windows.Forms.TextBox()
            Me.lblMontoFondoRotativo = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblMontoAsignado = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
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
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.gbCombustible = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.gbReferencia.SuspendLayout()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.gbLlegadaVehiculo.SuspendLayout()
            Me.gpSalidaVehiculo.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.gbCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbCombustible.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbCombustible.Panel.SuspendLayout()
            Me.gbCombustible.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNroSolicitudFR
            '
            Me.txtNroSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtNroSolicitudFR.Enabled = False
            Me.txtNroSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroSolicitudFR.Location = New System.Drawing.Point(87, 6)
            Me.txtNroSolicitudFR.Name = "txtNroSolicitudFR"
            Me.txtNroSolicitudFR.Size = New System.Drawing.Size(70, 22)
            Me.txtNroSolicitudFR.TabIndex = 1
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(594, 34)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(191, 21)
            Me.cmbCentroCosto.TabIndex = 5
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.Enabled = False
            Me.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbParroquia.ForeColor = System.Drawing.Color.Black
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(595, 69)
            Me.cmbParroquia.Name = "cmbParroquia"
            Me.cmbParroquia.Size = New System.Drawing.Size(190, 21)
            Me.cmbParroquia.TabIndex = 8
            '
            'cmbCanton
            '
            Me.cmbCanton.BackColor = System.Drawing.Color.White
            Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCanton.Enabled = False
            Me.cmbCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCanton.ForeColor = System.Drawing.Color.Black
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(280, 68)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(210, 21)
            Me.cmbCanton.TabIndex = 7
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.Enabled = False
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.ForeColor = System.Drawing.Color.Black
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(73, 68)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(108, 21)
            Me.cmbProvincia.TabIndex = 6
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.Enabled = False
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.ForeColor = System.Drawing.Color.Black
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(280, 35)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(210, 21)
            Me.cmbConcepto.TabIndex = 4
            '
            'txtActividadDetalleFR
            '
            Me.txtActividadDetalleFR.BackColor = System.Drawing.Color.White
            Me.txtActividadDetalleFR.Enabled = False
            Me.txtActividadDetalleFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividadDetalleFR.ForeColor = System.Drawing.Color.Black
            Me.txtActividadDetalleFR.Location = New System.Drawing.Point(73, 38)
            Me.txtActividadDetalleFR.Name = "txtActividadDetalleFR"
            Me.txtActividadDetalleFR.Size = New System.Drawing.Size(84, 21)
            Me.txtActividadDetalleFR.TabIndex = 3
            Me.txtActividadDetalleFR.Text = "101010102"
            Me.txtActividadDetalleFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodHaber
            '
            Me.txtCodHaber.BackColor = System.Drawing.Color.White
            Me.txtCodHaber.Enabled = False
            Me.txtCodHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodHaber.Location = New System.Drawing.Point(620, 147)
            Me.txtCodHaber.Name = "txtCodHaber"
            Me.txtCodHaber.Size = New System.Drawing.Size(84, 21)
            Me.txtCodHaber.TabIndex = 14
            Me.txtCodHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodDebe
            '
            Me.txtCodDebe.BackColor = System.Drawing.Color.White
            Me.txtCodDebe.Enabled = False
            Me.txtCodDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodDebe.Location = New System.Drawing.Point(511, 147)
            Me.txtCodDebe.Name = "txtCodDebe"
            Me.txtCodDebe.Size = New System.Drawing.Size(84, 21)
            Me.txtCodDebe.TabIndex = 13
            Me.txtCodDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtApellidoResponsableAutoFR
            '
            Me.txtApellidoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtApellidoResponsableAutoFR.Enabled = False
            Me.txtApellidoResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidoResponsableAutoFR.Location = New System.Drawing.Point(308, 147)
            Me.txtApellidoResponsableAutoFR.Name = "txtApellidoResponsableAutoFR"
            Me.txtApellidoResponsableAutoFR.Size = New System.Drawing.Size(169, 21)
            Me.txtApellidoResponsableAutoFR.TabIndex = 12
            Me.txtApellidoResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbCargoResponsableAutoFR
            '
            Me.cmbCargoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.cmbCargoResponsableAutoFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCargoResponsableAutoFR.Enabled = False
            Me.cmbCargoResponsableAutoFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCargoResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCargoResponsableAutoFR.FormattingEnabled = True
            Me.cmbCargoResponsableAutoFR.Location = New System.Drawing.Point(73, 118)
            Me.cmbCargoResponsableAutoFR.Name = "cmbCargoResponsableAutoFR"
            Me.cmbCargoResponsableAutoFR.Size = New System.Drawing.Size(152, 21)
            Me.cmbCargoResponsableAutoFR.TabIndex = 9
            '
            'txtNombreResponsableAutoFR
            '
            Me.txtNombreResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsableAutoFR.Enabled = False
            Me.txtNombreResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreResponsableAutoFR.Location = New System.Drawing.Point(73, 148)
            Me.txtNombreResponsableAutoFR.Name = "txtNombreResponsableAutoFR"
            Me.txtNombreResponsableAutoFR.Size = New System.Drawing.Size(152, 21)
            Me.txtNombreResponsableAutoFR.TabIndex = 11
            Me.txtNombreResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCIResponsableAutoFR
            '
            Me.txtCIResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtCIResponsableAutoFR.Enabled = False
            Me.txtCIResponsableAutoFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCIResponsableAutoFR.Location = New System.Drawing.Point(309, 118)
            Me.txtCIResponsableAutoFR.Name = "txtCIResponsableAutoFR"
            Me.txtCIResponsableAutoFR.Size = New System.Drawing.Size(113, 21)
            Me.txtCIResponsableAutoFR.TabIndex = 10
            Me.txtCIResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtValorSolicitudFR
            '
            Me.txtValorSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtValorSolicitudFR.Enabled = False
            Me.txtValorSolicitudFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorSolicitudFR.Location = New System.Drawing.Point(360, 230)
            Me.txtValorSolicitudFR.Name = "txtValorSolicitudFR"
            Me.txtValorSolicitudFR.Size = New System.Drawing.Size(87, 21)
            Me.txtValorSolicitudFR.TabIndex = 21
            Me.txtValorSolicitudFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDetalleSolicitudFR
            '
            Me.txtDetalleSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtDetalleSolicitudFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleSolicitudFR.Enabled = False
            Me.txtDetalleSolicitudFR.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleSolicitudFR.Location = New System.Drawing.Point(360, 263)
            Me.txtDetalleSolicitudFR.Multiline = True
            Me.txtDetalleSolicitudFR.Name = "txtDetalleSolicitudFR"
            Me.txtDetalleSolicitudFR.Size = New System.Drawing.Size(454, 21)
            Me.txtDetalleSolicitudFR.TabIndex = 22
            '
            'gbReferencia
            '
            Me.gbReferencia.BackColor = System.Drawing.Color.White
            Me.gbReferencia.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.gbReferencia.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbReferencia.Controls.Add(Me.dgvDetallesRetencion)
            Me.gbReferencia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReferencia.Location = New System.Drawing.Point(736, 47)
            Me.gbReferencia.Name = "gbReferencia"
            Me.gbReferencia.Size = New System.Drawing.Size(52, 50)
            Me.gbReferencia.TabIndex = 19
            Me.gbReferencia.TabStop = False
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(323, 46)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(123, 22)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 20
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(471, 48)
            Me.dtpComprobanteRetencion.Name = "dtpComprobanteRetencion"
            Me.dtpComprobanteRetencion.Size = New System.Drawing.Size(123, 22)
            Me.dtpComprobanteRetencion.TabIndex = 19
            '
            'dgvDetallesRetencion
            '
            Me.dgvDetallesRetencion.AllowUserToAddRows = False
            Me.dgvDetallesRetencion.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetallesRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetallesRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetallesRetencion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetallesRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetallesRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetallesRetencion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioFiscal, Me.CodigoRetencion, Me.BaseImponible, Me.Impuesto, Me.PorcentajeRetencion, Me.ValorRetenido, Me.Column1, Me.Column2})
            Me.dgvDetallesRetencion.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvDetallesRetencion.Location = New System.Drawing.Point(47, 16)
            Me.dgvDetallesRetencion.MultiSelect = False
            Me.dgvDetallesRetencion.Name = "dgvDetallesRetencion"
            Me.dgvDetallesRetencion.ReadOnly = True
            Me.dgvDetallesRetencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.dgvDetallesRetencion.RowHeadersVisible = False
            Me.dgvDetallesRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetallesRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetallesRetencion.Size = New System.Drawing.Size(704, 85)
            Me.dgvDetallesRetencion.TabIndex = 54
            Me.dgvDetallesRetencion.Visible = False
            '
            'EjercicioFiscal
            '
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EjercicioFiscal.DefaultCellStyle = DataGridViewCellStyle3
            Me.EjercicioFiscal.HeaderText = "EJ. FISCAL"
            Me.EjercicioFiscal.Name = "EjercicioFiscal"
            Me.EjercicioFiscal.ReadOnly = True
            Me.EjercicioFiscal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.EjercicioFiscal.Width = 110
            '
            'CodigoRetencion
            '
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodigoRetencion.DefaultCellStyle = DataGridViewCellStyle4
            Me.CodigoRetencion.HeaderText = "CODIGO"
            Me.CodigoRetencion.Name = "CodigoRetencion"
            Me.CodigoRetencion.ReadOnly = True
            Me.CodigoRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CodigoRetencion.Width = 110
            '
            'BaseImponible
            '
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BaseImponible.DefaultCellStyle = DataGridViewCellStyle5
            Me.BaseImponible.HeaderText = "BASE IMPONIBLE"
            Me.BaseImponible.Name = "BaseImponible"
            Me.BaseImponible.ReadOnly = True
            Me.BaseImponible.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BaseImponible.Width = 145
            '
            'Impuesto
            '
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Impuesto.DefaultCellStyle = DataGridViewCellStyle6
            Me.Impuesto.HeaderText = "IMPUESTO"
            Me.Impuesto.Name = "Impuesto"
            Me.Impuesto.ReadOnly = True
            Me.Impuesto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.Impuesto.Width = 105
            '
            'PorcentajeRetencion
            '
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PorcentajeRetencion.DefaultCellStyle = DataGridViewCellStyle7
            Me.PorcentajeRetencion.HeaderText = "%"
            Me.PorcentajeRetencion.Name = "PorcentajeRetencion"
            Me.PorcentajeRetencion.ReadOnly = True
            Me.PorcentajeRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.PorcentajeRetencion.Width = 110
            '
            'ValorRetenido
            '
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ValorRetenido.DefaultCellStyle = DataGridViewCellStyle8
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
            'txtFechaSolicitudFR
            '
            Me.txtFechaSolicitudFR.Enabled = False
            Me.txtFechaSolicitudFR.Location = New System.Drawing.Point(215, 6)
            Me.txtFechaSolicitudFR.Name = "txtFechaSolicitudFR"
            Me.txtFechaSolicitudFR.Size = New System.Drawing.Size(262, 22)
            Me.txtFechaSolicitudFR.TabIndex = 2
            '
            'txtNombreComercialCliente
            '
            Me.txtNombreComercialCliente.Enabled = False
            Me.txtNombreComercialCliente.Location = New System.Drawing.Point(620, 195)
            Me.txtNombreComercialCliente.Name = "txtNombreComercialCliente"
            Me.txtNombreComercialCliente.Size = New System.Drawing.Size(194, 22)
            Me.txtNombreComercialCliente.TabIndex = 19
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarPersonal.Enabled = False
            Me.btnBuscarPersonal.FlatAppearance.BorderSize = 0
            Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(197, 191)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(28, 28)
            Me.btnBuscarPersonal.TabIndex = 16
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtReceptorDineroSolicitud
            '
            Me.txtReceptorDineroSolicitud.BackColor = System.Drawing.Color.White
            Me.txtReceptorDineroSolicitud.Enabled = False
            Me.txtReceptorDineroSolicitud.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReceptorDineroSolicitud.Location = New System.Drawing.Point(309, 197)
            Me.txtReceptorDineroSolicitud.Name = "txtReceptorDineroSolicitud"
            Me.txtReceptorDineroSolicitud.Size = New System.Drawing.Size(224, 21)
            Me.txtReceptorDineroSolicitud.TabIndex = 17
            Me.txtReceptorDineroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCIReceptorDinero
            '
            Me.txtCIReceptorDinero.BackColor = System.Drawing.Color.White
            Me.txtCIReceptorDinero.Enabled = False
            Me.txtCIReceptorDinero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCIReceptorDinero.Location = New System.Drawing.Point(73, 197)
            Me.txtCIReceptorDinero.Name = "txtCIReceptorDinero"
            Me.txtCIReceptorDinero.Size = New System.Drawing.Size(113, 22)
            Me.txtCIReceptorDinero.TabIndex = 15
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminarItem, Me.CODIGO, Me.CUENTA, Me.VALOR, Me.IVA})
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(314, 221)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(514, 28)
            Me.dgvAsientosDiario.TabIndex = 55
            Me.dgvAsientosDiario.Visible = False
            '
            'eliminarItem
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkRed
            DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
            Me.eliminarItem.DefaultCellStyle = DataGridViewCellStyle11
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
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.CUENTA.DefaultCellStyle = DataGridViewCellStyle12
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
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Location = New System.Drawing.Point(91, 263)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(152, 22)
            Me.txtNroDocumento.TabIndex = 19
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
            Me.btnDocumento.Location = New System.Drawing.Point(257, 255)
            Me.btnDocumento.Name = "btnDocumento"
            Me.btnDocumento.Size = New System.Drawing.Size(29, 29)
            Me.btnDocumento.TabIndex = 20
            Me.btnDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDocumento.UseVisualStyleBackColor = False
            '
            'cmbNombreParametroDocumentos
            '
            Me.cmbNombreParametroDocumentos.BackColor = System.Drawing.Color.White
            Me.cmbNombreParametroDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNombreParametroDocumentos.Enabled = False
            Me.cmbNombreParametroDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbNombreParametroDocumentos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNombreParametroDocumentos.FormattingEnabled = True
            Me.cmbNombreParametroDocumentos.Location = New System.Drawing.Point(91, 231)
            Me.cmbNombreParametroDocumentos.Name = "cmbNombreParametroDocumentos"
            Me.cmbNombreParametroDocumentos.Size = New System.Drawing.Size(152, 21)
            Me.cmbNombreParametroDocumentos.TabIndex = 18
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoSolicitudFR, Me.btnGuardarSolicitudFR, Me.btnCancelarSolicitudFR})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(828, 32)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoSolicitudFR
            '
            Me.btnNuevoSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoSolicitudFR.Name = "btnNuevoSolicitudFR"
            Me.btnNuevoSolicitudFR.Size = New System.Drawing.Size(81, 28)
            Me.btnNuevoSolicitudFR.Text = "NUEVO"
            '
            'btnGuardarSolicitudFR
            '
            Me.btnGuardarSolicitudFR.Enabled = False
            Me.btnGuardarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSolicitudFR.Name = "btnGuardarSolicitudFR"
            Me.btnGuardarSolicitudFR.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarSolicitudFR.Text = "GUARDAR"
            '
            'btnCancelarSolicitudFR
            '
            Me.btnCancelarSolicitudFR.Enabled = False
            Me.btnCancelarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarSolicitudFR.Name = "btnCancelarSolicitudFR"
            Me.btnCancelarSolicitudFR.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelarSolicitudFR.Text = "CANCELAR"
            '
            'chkCombustible
            '
            Me.chkCombustible.AutoSize = True
            Me.chkCombustible.BackColor = System.Drawing.Color.White
            Me.chkCombustible.Enabled = False
            Me.chkCombustible.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCombustible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkCombustible.Location = New System.Drawing.Point(4, 337)
            Me.chkCombustible.Name = "chkCombustible"
            Me.chkCombustible.Size = New System.Drawing.Size(143, 17)
            Me.chkCombustible.TabIndex = 23
            Me.chkCombustible.Text = "Control de Combustible"
            Me.chkCombustible.UseVisualStyleBackColor = False
            '
            'txtFechaControl
            '
            Me.txtFechaControl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtFechaControl.Location = New System.Drawing.Point(73, 6)
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
            Me.gbLlegadaVehiculo.Location = New System.Drawing.Point(453, 66)
            Me.gbLlegadaVehiculo.Name = "gbLlegadaVehiculo"
            Me.gbLlegadaVehiculo.Size = New System.Drawing.Size(165, 95)
            Me.gbLlegadaVehiculo.TabIndex = 32
            Me.gbLlegadaVehiculo.TabStop = False
            Me.gbLlegadaVehiculo.Text = "Llegada"
            '
            'dtpHoraLlegadaVehiculo
            '
            Me.dtpHoraLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHoraLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraLlegadaVehiculo.Location = New System.Drawing.Point(49, 42)
            Me.dtpHoraLlegadaVehiculo.Name = "dtpHoraLlegadaVehiculo"
            Me.dtpHoraLlegadaVehiculo.ShowUpDown = True
            Me.dtpHoraLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpHoraLlegadaVehiculo.TabIndex = 36
            '
            'dtpFechaLlegadaVehiculo
            '
            Me.dtpFechaLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaLlegadaVehiculo.Location = New System.Drawing.Point(49, 19)
            Me.dtpFechaLlegadaVehiculo.Name = "dtpFechaLlegadaVehiculo"
            Me.dtpFechaLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpFechaLlegadaVehiculo.TabIndex = 35
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(49, 65)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.txtKmLlegadaVehiculo.TabIndex = 37
            Me.txtKmLlegadaVehiculo.Text = "0"
            '
            'LblKilometrajeLlegadaVehiculo
            '
            Me.LblKilometrajeLlegadaVehiculo.AutoSize = True
            Me.LblKilometrajeLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblKilometrajeLlegadaVehiculo.Location = New System.Drawing.Point(8, 68)
            Me.LblKilometrajeLlegadaVehiculo.Name = "LblKilometrajeLlegadaVehiculo"
            Me.LblKilometrajeLlegadaVehiculo.Size = New System.Drawing.Size(24, 13)
            Me.LblKilometrajeLlegadaVehiculo.TabIndex = 2
            Me.LblKilometrajeLlegadaVehiculo.Text = "Km"
            '
            'lblHoraLlegadaVehiculo
            '
            Me.lblHoraLlegadaVehiculo.AutoSize = True
            Me.lblHoraLlegadaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraLlegadaVehiculo.Location = New System.Drawing.Point(8, 45)
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
            Me.txtIdActivoFijo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdActivoFijo.Location = New System.Drawing.Point(73, 76)
            Me.txtIdActivoFijo.Name = "txtIdActivoFijo"
            Me.txtIdActivoFijo.Size = New System.Drawing.Size(99, 21)
            Me.txtIdActivoFijo.TabIndex = 30
            Me.txtIdActivoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnBuscarVehiculo
            '
            Me.btnBuscarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscarVehiculo.Location = New System.Drawing.Point(188, 74)
            Me.btnBuscarVehiculo.Name = "btnBuscarVehiculo"
            Me.btnBuscarVehiculo.Size = New System.Drawing.Size(26, 24)
            Me.btnBuscarVehiculo.TabIndex = 32
            Me.btnBuscarVehiculo.Text = "..."
            Me.btnBuscarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscarVehiculo.UseVisualStyleBackColor = True
            '
            'txtPlacaVehiculo
            '
            Me.txtPlacaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtPlacaVehiculo.Enabled = False
            Me.txtPlacaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPlacaVehiculo.Location = New System.Drawing.Point(281, 107)
            Me.txtPlacaVehiculo.Name = "txtPlacaVehiculo"
            Me.txtPlacaVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtPlacaVehiculo.TabIndex = 34
            Me.txtPlacaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtModeloVehiculo
            '
            Me.txtModeloVehiculo.BackColor = System.Drawing.Color.White
            Me.txtModeloVehiculo.Enabled = False
            Me.txtModeloVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtModeloVehiculo.Location = New System.Drawing.Point(280, 76)
            Me.txtModeloVehiculo.Name = "txtModeloVehiculo"
            Me.txtModeloVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtModeloVehiculo.TabIndex = 33
            Me.txtModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtMarcaVehiculo
            '
            Me.txtMarcaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtMarcaVehiculo.Enabled = False
            Me.txtMarcaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMarcaVehiculo.Location = New System.Drawing.Point(73, 107)
            Me.txtMarcaVehiculo.Name = "txtMarcaVehiculo"
            Me.txtMarcaVehiculo.Size = New System.Drawing.Size(141, 21)
            Me.txtMarcaVehiculo.TabIndex = 31
            Me.txtMarcaVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtTotalKmControlC
            '
            Me.txtTotalKmControlC.BackColor = System.Drawing.Color.White
            Me.txtTotalKmControlC.Enabled = False
            Me.txtTotalKmControlC.Location = New System.Drawing.Point(747, 9)
            Me.txtTotalKmControlC.Name = "txtTotalKmControlC"
            Me.txtTotalKmControlC.Size = New System.Drawing.Size(47, 22)
            Me.txtTotalKmControlC.TabIndex = 29
            Me.txtTotalKmControlC.Text = "0"
            Me.txtTotalKmControlC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'gpSalidaVehiculo
            '
            Me.gpSalidaVehiculo.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.gpSalidaVehiculo.Controls.Add(Me.Label2)
            Me.gpSalidaVehiculo.Controls.Add(Me.Label1)
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpHoraSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.dtpFechaSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.txtKmSalidaVehiculo)
            Me.gpSalidaVehiculo.Controls.Add(Me.lblKilometrajeSalidaVehiculo)
            Me.gpSalidaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpSalidaVehiculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gpSalidaVehiculo.Location = New System.Drawing.Point(641, 65)
            Me.gpSalidaVehiculo.Name = "gpSalidaVehiculo"
            Me.gpSalidaVehiculo.Size = New System.Drawing.Size(165, 95)
            Me.gpSalidaVehiculo.TabIndex = 31
            Me.gpSalidaVehiculo.TabStop = False
            Me.gpSalidaVehiculo.Text = "Salida"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 46)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 38
            Me.Label2.Text = "Hora"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 38
            Me.Label1.Text = "Fecha"
            '
            'dtpHoraSalidaVehiculo
            '
            Me.dtpHoraSalidaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHoraSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpHoraSalidaVehiculo.Location = New System.Drawing.Point(46, 42)
            Me.dtpHoraSalidaVehiculo.Name = "dtpHoraSalidaVehiculo"
            Me.dtpHoraSalidaVehiculo.ShowUpDown = True
            Me.dtpHoraSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpHoraSalidaVehiculo.TabIndex = 39
            '
            'dtpFechaSalidaVehiculo
            '
            Me.dtpFechaSalidaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaSalidaVehiculo.Location = New System.Drawing.Point(46, 19)
            Me.dtpFechaSalidaVehiculo.Name = "dtpFechaSalidaVehiculo"
            Me.dtpFechaSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.dtpFechaSalidaVehiculo.TabIndex = 38
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(46, 65)
            Me.txtKmSalidaVehiculo.Name = "txtKmSalidaVehiculo"
            Me.txtKmSalidaVehiculo.Size = New System.Drawing.Size(110, 21)
            Me.txtKmSalidaVehiculo.TabIndex = 40
            Me.txtKmSalidaVehiculo.Text = "0"
            '
            'lblKilometrajeSalidaVehiculo
            '
            Me.lblKilometrajeSalidaVehiculo.AutoSize = True
            Me.lblKilometrajeSalidaVehiculo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblKilometrajeSalidaVehiculo.Location = New System.Drawing.Point(6, 68)
            Me.lblKilometrajeSalidaVehiculo.Name = "lblKilometrajeSalidaVehiculo"
            Me.lblKilometrajeSalidaVehiculo.Size = New System.Drawing.Size(24, 13)
            Me.lblKilometrajeSalidaVehiculo.TabIndex = 2
            Me.lblKilometrajeSalidaVehiculo.Text = "Km"
            '
            'cbmCombustible
            '
            Me.cbmCombustible.BackColor = System.Drawing.Color.White
            Me.cbmCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCombustible.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCombustible.FormattingEnabled = True
            Me.cbmCombustible.Location = New System.Drawing.Point(358, 7)
            Me.cbmCombustible.Name = "cbmCombustible"
            Me.cbmCombustible.Size = New System.Drawing.Size(175, 21)
            Me.cbmCombustible.TabIndex = 25
            '
            'txtMotivoControlC
            '
            Me.txtMotivoControlC.BackColor = System.Drawing.Color.White
            Me.txtMotivoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMotivoControlC.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotivoControlC.Location = New System.Drawing.Point(513, 38)
            Me.txtMotivoControlC.Name = "txtMotivoControlC"
            Me.txtMotivoControlC.Size = New System.Drawing.Size(283, 21)
            Me.txtMotivoControlC.TabIndex = 28
            '
            'txtDestinoControlC
            '
            Me.txtDestinoControlC.BackColor = System.Drawing.Color.White
            Me.txtDestinoControlC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDestinoControlC.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDestinoControlC.Location = New System.Drawing.Point(73, 35)
            Me.txtDestinoControlC.Name = "txtDestinoControlC"
            Me.txtDestinoControlC.Size = New System.Drawing.Size(274, 21)
            Me.txtDestinoControlC.TabIndex = 27
            '
            'txtValorControl
            '
            Me.txtValorControl.BackColor = System.Drawing.Color.White
            Me.txtValorControl.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorControl.ForeColor = System.Drawing.Color.Black
            Me.txtValorControl.Location = New System.Drawing.Point(595, 7)
            Me.txtValorControl.Name = "txtValorControl"
            Me.txtValorControl.Size = New System.Drawing.Size(83, 21)
            Me.txtValorControl.TabIndex = 26
            Me.txtValorControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblMontoFondoRotativo
            '
            Me.lblMontoFondoRotativo.AutoSize = True
            Me.lblMontoFondoRotativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoFondoRotativo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMontoFondoRotativo.Location = New System.Drawing.Point(746, 7)
            Me.lblMontoFondoRotativo.Name = "lblMontoFondoRotativo"
            Me.lblMontoFondoRotativo.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoFondoRotativo.TabIndex = 188
            Me.lblMontoFondoRotativo.Text = "00.00"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(628, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(126, 19)
            Me.Label3.TabIndex = 191
            Me.Label3.Text = "VALOR DISPONIBLE:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMontoAsignado
            '
            Me.lblMontoAsignado.AutoSize = True
            Me.lblMontoAsignado.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.lblMontoAsignado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblMontoAsignado.Location = New System.Drawing.Point(512, 6)
            Me.lblMontoAsignado.Name = "lblMontoAsignado"
            Me.lblMontoAsignado.Size = New System.Drawing.Size(34, 13)
            Me.lblMontoAsignado.TabIndex = 190
            Me.lblMontoAsignado.Text = "00.00"
            '
            'Label30
            '
            Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label30.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(393, 2)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(126, 19)
            Me.Label30.TabIndex = 189
            Me.Label30.Text = "MONTO ASIGNADO:"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel25)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel24)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel23)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalleSolicitudFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbNombreParametroDocumentos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorSolicitudFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreComercialCliente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodDebe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtReceptorDineroSolicitud)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCIReceptorDinero)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodHaber)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtApellidoResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCargoResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCIResponsableAutoFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaSolicitudFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroSolicitudFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtActividadDetalleFR)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbProvincia)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(828, 302)
            Me.KryptonGroupBox1.TabIndex = 192
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel25
            '
            Me.KryptonLabel25.Location = New System.Drawing.Point(308, 263)
            Me.KryptonLabel25.Name = "KryptonLabel25"
            Me.KryptonLabel25.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel25.TabIndex = 207
            Me.KryptonLabel25.Values.Text = "Detalle"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(308, 230)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel24.TabIndex = 206
            Me.KryptonLabel24.Values.Text = "Valor"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(10, 263)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel23.TabIndex = 205
            Me.KryptonLabel23.Values.Text = "Nro "
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(10, 231)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel22.TabIndex = 204
            Me.KryptonLabel22.Values.Text = "Documento"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(546, 197)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel21.TabIndex = 203
            Me.KryptonLabel21.Values.Text = "Cliente"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(240, 197)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel20.TabIndex = 202
            Me.KryptonLabel20.Values.Text = "Nombre"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(10, 199)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel19.TabIndex = 201
            Me.KryptonLabel19.Values.Text = "Cedula"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(10, 174)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel18.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel18.TabIndex = 200
            Me.KryptonLabel18.Values.Text = "Receptor"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(620, 119)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel17.TabIndex = 199
            Me.KryptonLabel17.Values.Text = "Haber"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(508, 119)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel16.TabIndex = 198
            Me.KryptonLabel16.Values.Text = "Debe"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(507, 93)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(94, 20)
            Me.KryptonLabel15.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel15.TabIndex = 197
            Me.KryptonLabel15.Values.Text = "Contabilizacion"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(242, 148)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel14.TabIndex = 196
            Me.KryptonLabel14.Values.Text = "Apellido"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(242, 122)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel13.TabIndex = 195
            Me.KryptonLabel13.Values.Text = "Cedula"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(10, 148)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel12.TabIndex = 194
            Me.KryptonLabel12.Values.Text = "Nombre"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(10, 122)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel11.TabIndex = 193
            Me.KryptonLabel11.Values.Text = "Cargo"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(10, 93)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel10.TabIndex = 192
            Me.KryptonLabel10.Values.Text = "Autorizacion"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(507, 36)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel9.TabIndex = 191
            Me.KryptonLabel9.Values.Text = "Centro Costo"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(507, 65)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel8.TabIndex = 190
            Me.KryptonLabel8.Values.Text = "Parroquia"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(200, 69)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel7.TabIndex = 189
            Me.KryptonLabel7.Values.Text = "Canton"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(200, 38)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel6.TabIndex = 188
            Me.KryptonLabel6.Values.Text = "Concepto"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(10, 65)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel5.TabIndex = 187
            Me.KryptonLabel5.Values.Text = "Provincia"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(10, 39)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel4.TabIndex = 186
            Me.KryptonLabel4.Values.Text = "Actividad"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(163, 6)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 2
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(10, 6)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Nro "
            '
            'gbCombustible
            '
            Me.gbCombustible.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.gbCombustible.Location = New System.Drawing.Point(0, 354)
            Me.gbCombustible.Name = "gbCombustible"
            '
            'gbCombustible.Panel
            '
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel32)
            Me.gbCombustible.Panel.Controls.Add(Me.gbLlegadaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel31)
            Me.gbCombustible.Panel.Controls.Add(Me.gpSalidaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtTotalKmControlC)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel33)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel34)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel37)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel36)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel30)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel29)
            Me.gbCombustible.Panel.Controls.Add(Me.cbmCombustible)
            Me.gbCombustible.Panel.Controls.Add(Me.txtMotivoControlC)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel28)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel27)
            Me.gbCombustible.Panel.Controls.Add(Me.KryptonLabel26)
            Me.gbCombustible.Panel.Controls.Add(Me.txtValorControl)
            Me.gbCombustible.Panel.Controls.Add(Me.btnBuscarVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtPlacaVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtIdActivoFijo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtModeloVehiculo)
            Me.gbCombustible.Panel.Controls.Add(Me.txtFechaControl)
            Me.gbCombustible.Panel.Controls.Add(Me.txtDestinoControlC)
            Me.gbCombustible.Panel.Controls.Add(Me.txtMarcaVehiculo)
            Me.gbCombustible.Panel.Enabled = False
            Me.gbCombustible.Size = New System.Drawing.Size(828, 173)
            Me.gbCombustible.TabIndex = 193
            Me.gbCombustible.Values.Heading = ""
            '
            'KryptonLabel32
            '
            Me.KryptonLabel32.Location = New System.Drawing.Point(682, 11)
            Me.KryptonLabel32.Name = "KryptonLabel32"
            Me.KryptonLabel32.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel32.TabIndex = 216
            Me.KryptonLabel32.Values.Text = "Total Km"
            '
            'KryptonLabel31
            '
            Me.KryptonLabel31.Location = New System.Drawing.Point(428, 36)
            Me.KryptonLabel31.Name = "KryptonLabel31"
            Me.KryptonLabel31.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel31.TabIndex = 215
            Me.KryptonLabel31.Values.Text = "Motivo"
            '
            'KryptonLabel33
            '
            Me.KryptonLabel33.Location = New System.Drawing.Point(546, 11)
            Me.KryptonLabel33.Name = "KryptonLabel33"
            Me.KryptonLabel33.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel33.TabIndex = 214
            Me.KryptonLabel33.Values.Text = "Valor"
            '
            'KryptonLabel34
            '
            Me.KryptonLabel34.Location = New System.Drawing.Point(240, 8)
            Me.KryptonLabel34.Name = "KryptonLabel34"
            Me.KryptonLabel34.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel34.TabIndex = 213
            Me.KryptonLabel34.Values.Text = "Combustible"
            '
            'KryptonLabel37
            '
            Me.KryptonLabel37.Location = New System.Drawing.Point(229, 107)
            Me.KryptonLabel37.Name = "KryptonLabel37"
            Me.KryptonLabel37.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel37.TabIndex = 212
            Me.KryptonLabel37.Values.Text = "Placa"
            '
            'KryptonLabel36
            '
            Me.KryptonLabel36.Location = New System.Drawing.Point(230, 78)
            Me.KryptonLabel36.Name = "KryptonLabel36"
            Me.KryptonLabel36.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel36.TabIndex = 211
            Me.KryptonLabel36.Values.Text = "Marca"
            '
            'KryptonLabel30
            '
            Me.KryptonLabel30.Location = New System.Drawing.Point(10, 104)
            Me.KryptonLabel30.Name = "KryptonLabel30"
            Me.KryptonLabel30.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel30.TabIndex = 210
            Me.KryptonLabel30.Values.Text = "Marca"
            '
            'KryptonLabel29
            '
            Me.KryptonLabel29.Location = New System.Drawing.Point(10, 78)
            Me.KryptonLabel29.Name = "KryptonLabel29"
            Me.KryptonLabel29.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel29.TabIndex = 209
            Me.KryptonLabel29.Values.Text = "Activo"
            '
            'KryptonLabel28
            '
            Me.KryptonLabel28.Location = New System.Drawing.Point(10, 36)
            Me.KryptonLabel28.Name = "KryptonLabel28"
            Me.KryptonLabel28.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel28.TabIndex = 208
            Me.KryptonLabel28.Values.Text = "Destino"
            '
            'KryptonLabel27
            '
            Me.KryptonLabel27.Location = New System.Drawing.Point(10, 6)
            Me.KryptonLabel27.Name = "KryptonLabel27"
            Me.KryptonLabel27.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel27.TabIndex = 208
            Me.KryptonLabel27.Values.Text = "Fecha"
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(10, 57)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(58, 20)
            Me.KryptonLabel26.StateCommon.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel26.TabIndex = 208
            Me.KryptonLabel26.Values.Text = "Vehiculo"
            '
            'FormSolicitudFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(828, 527)
            Me.Controls.Add(Me.gbCombustible)
            Me.Controls.Add(Me.chkCombustible)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.lblMontoFondoRotativo)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblMontoAsignado)
            Me.Controls.Add(Me.Label30)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbReferencia)
            Me.Controls.Add(Me.dgvAsientosDiario)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormSolicitudFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "SOLICITUD DE FONDO ROTATIVO"
            Me.gbReferencia.ResumeLayout(False)
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.gbLlegadaVehiculo.ResumeLayout(False)
            Me.gbLlegadaVehiculo.PerformLayout()
            Me.gpSalidaVehiculo.ResumeLayout(False)
            Me.gpSalidaVehiculo.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.gbCombustible.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCombustible.Panel.ResumeLayout(False)
            Me.gbCombustible.Panel.PerformLayout()
            CType(Me.gbCombustible, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbCombustible.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNroSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents txtActividadDetalleFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCodHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtCodDebe As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCIResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCargoResponsableAutoFR As System.Windows.Forms.ComboBox
        Friend WithEvents txtApellidoResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents gbReferencia As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtReceptorDineroSolicitud As System.Windows.Forms.TextBox
        Friend WithEvents txtCIReceptorDinero As System.Windows.Forms.TextBox
        Friend WithEvents cmbNombreParametroDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents txtValorSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtFechaSolicitudFR As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnDocumento As System.Windows.Forms.Button
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaControl As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbLlegadaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmLlegadaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents LblKilometrajeLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblHoraLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblFechaLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents txtIdActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscarVehiculo As System.Windows.Forms.Button
        Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtModeloVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtMarcaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalKmControlC As System.Windows.Forms.TextBox
        Friend WithEvents gpSalidaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmSalidaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblKilometrajeSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents chkCombustible As System.Windows.Forms.CheckBox
        Friend WithEvents cbmCombustible As System.Windows.Forms.ComboBox
        Friend WithEvents txtMotivoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtDestinoControlC As System.Windows.Forms.TextBox
        Friend WithEvents txtValorControl As System.Windows.Forms.TextBox
        Friend WithEvents lblMontoFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblMontoAsignado As System.Windows.Forms.Label
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents dgvDetallesRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents eliminarItem As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents EjercicioFiscal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CodigoRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents BaseImponible As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PorcentajeRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ValorRetenido As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtNombreComercialCliente As TextBox
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbCombustible As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
    End Class
End Namespace