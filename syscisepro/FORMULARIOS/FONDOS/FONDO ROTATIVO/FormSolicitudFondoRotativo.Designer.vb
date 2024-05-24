Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormSolicitudFondoRotativo
        Inherits System.Windows.Forms.Form

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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSolicitudFondoRotativo))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblNumeroSolicitudFR = New System.Windows.Forms.Label()
            Me.txtNroSolicitudFR = New System.Windows.Forms.TextBox()
            Me.lblFechaSolicitudFR = New System.Windows.Forms.Label()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblConceptoDetalleFR = New System.Windows.Forms.Label()
            Me.lblCanton = New System.Windows.Forms.Label()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.lblActividadDetalleFR = New System.Windows.Forms.Label()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cmbParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbCanton = New System.Windows.Forms.ComboBox()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.txtActividadDetalleFR = New System.Windows.Forms.TextBox()
            Me.txtCodHaber = New System.Windows.Forms.TextBox()
            Me.txtCodDebe = New System.Windows.Forms.TextBox()
            Me.lblCodHaber = New System.Windows.Forms.Label()
            Me.lblCodDebe = New System.Windows.Forms.Label()
            Me.gpAutorizacionFondoRotativo = New System.Windows.Forms.GroupBox()
            Me.txtApellidoResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.lblApellidoResponsableAutoFR = New System.Windows.Forms.Label()
            Me.cmbCargoResponsableAutoFR = New System.Windows.Forms.ComboBox()
            Me.lblCargoResponsableAutoFR = New System.Windows.Forms.Label()
            Me.txtNombreResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.lblNombreResponsbleAutoFR = New System.Windows.Forms.Label()
            Me.txtCIResponsableAutoFR = New System.Windows.Forms.TextBox()
            Me.lblCIResponsableAutoFR = New System.Windows.Forms.Label()
            Me.gpValorGastoSolicitudFR = New System.Windows.Forms.GroupBox()
            Me.txtValorSolicitudFR = New System.Windows.Forms.TextBox()
            Me.gbDetalleGasto = New System.Windows.Forms.GroupBox()
            Me.txtDetalleSolicitudFR = New System.Windows.Forms.TextBox()
            Me.gbReferencia = New System.Windows.Forms.GroupBox()
            Me.txtFechaSolicitudFR = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaEmisionComprobanteCompra = New System.Windows.Forms.DateTimePicker()
            Me.dtpComprobanteRetencion = New System.Windows.Forms.DateTimePicker()
            Me.dgvDetallesRetencion = New System.Windows.Forms.DataGridView()
            Me.gbReceptorDinero = New System.Windows.Forms.GroupBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtReceptorDineroSolicitud = New System.Windows.Forms.TextBox()
            Me.txtCIReceptorDinero = New System.Windows.Forms.TextBox()
            Me.lblNombreReceptorReciboFR = New System.Windows.Forms.Label()
            Me.lblCIReceptorReciboFR = New System.Windows.Forms.Label()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.eliminarItem = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.gbDocumento = New System.Windows.Forms.GroupBox()
            Me.lblNroDocumento = New System.Windows.Forms.Label()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.btnDocumento = New System.Windows.Forms.Button()
            Me.cmbNombreParametroDocumentos = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarSolicitudFR = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.chkCombustible = New System.Windows.Forms.CheckBox()
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
            Me.cbmCombustible = New System.Windows.Forms.ComboBox()
            Me.lblFechaControlC = New System.Windows.Forms.Label()
            Me.txtMotivoControlC = New System.Windows.Forms.TextBox()
            Me.lblClaseGasolinaControlC = New System.Windows.Forms.Label()
            Me.txtDestinoControlC = New System.Windows.Forms.TextBox()
            Me.lblMotivoControlC = New System.Windows.Forms.Label()
            Me.txtValorControl = New System.Windows.Forms.TextBox()
            Me.lblDestinoControlC = New System.Windows.Forms.Label()
            Me.lblValorControlC = New System.Windows.Forms.Label()
            Me.lblMontoFondoRotativo = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblMontoAsignado = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.EjercicioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CodigoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.BaseImponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PorcentajeRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ValorRetenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.gpAutorizacionFondoRotativo.SuspendLayout()
            Me.gpValorGastoSolicitudFR.SuspendLayout()
            Me.gbDetalleGasto.SuspendLayout()
            Me.gbReferencia.SuspendLayout()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbReceptorDinero.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbDocumento.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbLlegadaVehiculo.SuspendLayout()
            Me.gbVehiculo.SuspendLayout()
            Me.gpSalidaVehiculo.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblNumeroSolicitudFR
            '
            Me.lblNumeroSolicitudFR.AutoSize = True
            Me.lblNumeroSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroSolicitudFR.Location = New System.Drawing.Point(213, 17)
            Me.lblNumeroSolicitudFR.Name = "lblNumeroSolicitudFR"
            Me.lblNumeroSolicitudFR.Size = New System.Drawing.Size(60, 13)
            Me.lblNumeroSolicitudFR.TabIndex = 0
            Me.lblNumeroSolicitudFR.Text = "NRO: SRF-"
            '
            'txtNroSolicitudFR
            '
            Me.txtNroSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtNroSolicitudFR.Enabled = False
            Me.txtNroSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroSolicitudFR.Location = New System.Drawing.Point(271, 14)
            Me.txtNroSolicitudFR.Name = "txtNroSolicitudFR"
            Me.txtNroSolicitudFR.Size = New System.Drawing.Size(70, 22)
            Me.txtNroSolicitudFR.TabIndex = 1
            '
            'lblFechaSolicitudFR
            '
            Me.lblFechaSolicitudFR.AutoSize = True
            Me.lblFechaSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaSolicitudFR.Location = New System.Drawing.Point(447, 17)
            Me.lblFechaSolicitudFR.Name = "lblFechaSolicitudFR"
            Me.lblFechaSolicitudFR.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaSolicitudFR.TabIndex = 2
            Me.lblFechaSolicitudFR.Text = "FECHA:"
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParroquia.ForeColor = System.Drawing.Color.Black
            Me.lblParroquia.Location = New System.Drawing.Point(724, 48)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(71, 13)
            Me.lblParroquia.TabIndex = 5
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblConceptoDetalleFR
            '
            Me.lblConceptoDetalleFR.AutoSize = True
            Me.lblConceptoDetalleFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConceptoDetalleFR.ForeColor = System.Drawing.Color.Black
            Me.lblConceptoDetalleFR.Location = New System.Drawing.Point(207, 21)
            Me.lblConceptoDetalleFR.Name = "lblConceptoDetalleFR"
            Me.lblConceptoDetalleFR.Size = New System.Drawing.Size(67, 13)
            Me.lblConceptoDetalleFR.TabIndex = 4
            Me.lblConceptoDetalleFR.Text = "CONCEPTO:"
            '
            'lblCanton
            '
            Me.lblCanton.AutoSize = True
            Me.lblCanton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCanton.ForeColor = System.Drawing.Color.Black
            Me.lblCanton.Location = New System.Drawing.Point(362, 48)
            Me.lblCanton.Name = "lblCanton"
            Me.lblCanton.Size = New System.Drawing.Size(54, 13)
            Me.lblCanton.TabIndex = 3
            Me.lblCanton.Text = "CANTON:"
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.lblCentroCosto.Location = New System.Drawing.Point(649, 21)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(92, 13)
            Me.lblCentroCosto.TabIndex = 2
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProvincia.ForeColor = System.Drawing.Color.Black
            Me.lblProvincia.Location = New System.Drawing.Point(5, 48)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(67, 13)
            Me.lblProvincia.TabIndex = 1
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'lblActividadDetalleFR
            '
            Me.lblActividadDetalleFR.AutoSize = True
            Me.lblActividadDetalleFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividadDetalleFR.ForeColor = System.Drawing.Color.Black
            Me.lblActividadDetalleFR.Location = New System.Drawing.Point(9, 22)
            Me.lblActividadDetalleFR.Name = "lblActividadDetalleFR"
            Me.lblActividadDetalleFR.Size = New System.Drawing.Size(66, 13)
            Me.lblActividadDetalleFR.TabIndex = 0
            Me.lblActividadDetalleFR.Text = "ACTIVIDAD:"
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCentroCosto.Enabled = False
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(745, 18)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(248, 21)
            Me.cmbCentroCosto.TabIndex = 5
            '
            'cmbParroquia
            '
            Me.cmbParroquia.BackColor = System.Drawing.Color.White
            Me.cmbParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParroquia.Enabled = False
            Me.cmbParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbParroquia.ForeColor = System.Drawing.Color.Black
            Me.cmbParroquia.FormattingEnabled = True
            Me.cmbParroquia.Location = New System.Drawing.Point(803, 45)
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
            Me.cmbCanton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCanton.ForeColor = System.Drawing.Color.Black
            Me.cmbCanton.FormattingEnabled = True
            Me.cmbCanton.Location = New System.Drawing.Point(422, 45)
            Me.cmbCanton.Name = "cmbCanton"
            Me.cmbCanton.Size = New System.Drawing.Size(221, 21)
            Me.cmbCanton.TabIndex = 7
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.Enabled = False
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.ForeColor = System.Drawing.Color.Black
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(82, 45)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(258, 21)
            Me.cmbProvincia.TabIndex = 6
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.Enabled = False
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.ForeColor = System.Drawing.Color.Black
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Location = New System.Drawing.Point(276, 18)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(351, 21)
            Me.cmbConcepto.TabIndex = 4
            '
            'txtActividadDetalleFR
            '
            Me.txtActividadDetalleFR.BackColor = System.Drawing.Color.White
            Me.txtActividadDetalleFR.Enabled = False
            Me.txtActividadDetalleFR.ForeColor = System.Drawing.Color.Black
            Me.txtActividadDetalleFR.Location = New System.Drawing.Point(82, 19)
            Me.txtActividadDetalleFR.Name = "txtActividadDetalleFR"
            Me.txtActividadDetalleFR.Size = New System.Drawing.Size(84, 22)
            Me.txtActividadDetalleFR.TabIndex = 3
            Me.txtActividadDetalleFR.Text = "101010102"
            Me.txtActividadDetalleFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodHaber
            '
            Me.txtCodHaber.BackColor = System.Drawing.Color.White
            Me.txtCodHaber.Enabled = False
            Me.txtCodHaber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodHaber.Location = New System.Drawing.Point(197, 38)
            Me.txtCodHaber.Name = "txtCodHaber"
            Me.txtCodHaber.Size = New System.Drawing.Size(84, 23)
            Me.txtCodHaber.TabIndex = 14
            Me.txtCodHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodDebe
            '
            Me.txtCodDebe.BackColor = System.Drawing.Color.White
            Me.txtCodDebe.Enabled = False
            Me.txtCodDebe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodDebe.Location = New System.Drawing.Point(43, 38)
            Me.txtCodDebe.Name = "txtCodDebe"
            Me.txtCodDebe.Size = New System.Drawing.Size(84, 23)
            Me.txtCodDebe.TabIndex = 13
            Me.txtCodDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCodHaber
            '
            Me.lblCodHaber.AutoSize = True
            Me.lblCodHaber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodHaber.Location = New System.Drawing.Point(199, 23)
            Me.lblCodHaber.Name = "lblCodHaber"
            Me.lblCodHaber.Size = New System.Drawing.Size(77, 15)
            Me.lblCodHaber.TabIndex = 1
            Me.lblCodHaber.Text = "COD. HABER:"
            '
            'lblCodDebe
            '
            Me.lblCodDebe.AutoSize = True
            Me.lblCodDebe.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodDebe.Location = New System.Drawing.Point(47, 23)
            Me.lblCodDebe.Name = "lblCodDebe"
            Me.lblCodDebe.Size = New System.Drawing.Size(68, 15)
            Me.lblCodDebe.TabIndex = 0
            Me.lblCodDebe.Text = "COD. DEBE:"
            '
            'gpAutorizacionFondoRotativo
            '
            Me.gpAutorizacionFondoRotativo.BackColor = System.Drawing.Color.White
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.txtApellidoResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.lblApellidoResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.cmbCargoResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.lblCargoResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.txtNombreResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.lblNombreResponsbleAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.txtCIResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Controls.Add(Me.lblCIResponsableAutoFR)
            Me.gpAutorizacionFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gpAutorizacionFondoRotativo.Location = New System.Drawing.Point(2, 134)
            Me.gpAutorizacionFondoRotativo.Name = "gpAutorizacionFondoRotativo"
            Me.gpAutorizacionFondoRotativo.Size = New System.Drawing.Size(670, 75)
            Me.gpAutorizacionFondoRotativo.TabIndex = 14
            Me.gpAutorizacionFondoRotativo.TabStop = False
            Me.gpAutorizacionFondoRotativo.Text = "AUTORIZACIÓN"
            '
            'txtApellidoResponsableAutoFR
            '
            Me.txtApellidoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtApellidoResponsableAutoFR.Enabled = False
            Me.txtApellidoResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidoResponsableAutoFR.Location = New System.Drawing.Point(418, 47)
            Me.txtApellidoResponsableAutoFR.Name = "txtApellidoResponsableAutoFR"
            Me.txtApellidoResponsableAutoFR.Size = New System.Drawing.Size(247, 22)
            Me.txtApellidoResponsableAutoFR.TabIndex = 12
            Me.txtApellidoResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblApellidoResponsableAutoFR
            '
            Me.lblApellidoResponsableAutoFR.AutoSize = True
            Me.lblApellidoResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblApellidoResponsableAutoFR.Location = New System.Drawing.Point(342, 50)
            Me.lblApellidoResponsableAutoFR.Name = "lblApellidoResponsableAutoFR"
            Me.lblApellidoResponsableAutoFR.Size = New System.Drawing.Size(58, 13)
            Me.lblApellidoResponsableAutoFR.TabIndex = 6
            Me.lblApellidoResponsableAutoFR.Text = "APELLIDO:"
            '
            'cmbCargoResponsableAutoFR
            '
            Me.cmbCargoResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.cmbCargoResponsableAutoFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCargoResponsableAutoFR.Enabled = False
            Me.cmbCargoResponsableAutoFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCargoResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCargoResponsableAutoFR.FormattingEnabled = True
            Me.cmbCargoResponsableAutoFR.Location = New System.Drawing.Point(71, 20)
            Me.cmbCargoResponsableAutoFR.Name = "cmbCargoResponsableAutoFR"
            Me.cmbCargoResponsableAutoFR.Size = New System.Drawing.Size(244, 21)
            Me.cmbCargoResponsableAutoFR.TabIndex = 9
            '
            'lblCargoResponsableAutoFR
            '
            Me.lblCargoResponsableAutoFR.AutoSize = True
            Me.lblCargoResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCargoResponsableAutoFR.Location = New System.Drawing.Point(7, 23)
            Me.lblCargoResponsableAutoFR.Name = "lblCargoResponsableAutoFR"
            Me.lblCargoResponsableAutoFR.Size = New System.Drawing.Size(47, 13)
            Me.lblCargoResponsableAutoFR.TabIndex = 4
            Me.lblCargoResponsableAutoFR.Text = "CARGO:"
            '
            'txtNombreResponsableAutoFR
            '
            Me.txtNombreResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtNombreResponsableAutoFR.Enabled = False
            Me.txtNombreResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreResponsableAutoFR.Location = New System.Drawing.Point(71, 47)
            Me.txtNombreResponsableAutoFR.Name = "txtNombreResponsableAutoFR"
            Me.txtNombreResponsableAutoFR.Size = New System.Drawing.Size(244, 22)
            Me.txtNombreResponsableAutoFR.TabIndex = 11
            Me.txtNombreResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblNombreResponsbleAutoFR
            '
            Me.lblNombreResponsbleAutoFR.AutoSize = True
            Me.lblNombreResponsbleAutoFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreResponsbleAutoFR.Location = New System.Drawing.Point(7, 50)
            Me.lblNombreResponsbleAutoFR.Name = "lblNombreResponsbleAutoFR"
            Me.lblNombreResponsbleAutoFR.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreResponsbleAutoFR.TabIndex = 2
            Me.lblNombreResponsbleAutoFR.Text = "NOMBRE:"
            '
            'txtCIResponsableAutoFR
            '
            Me.txtCIResponsableAutoFR.BackColor = System.Drawing.Color.White
            Me.txtCIResponsableAutoFR.Enabled = False
            Me.txtCIResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCIResponsableAutoFR.Location = New System.Drawing.Point(418, 20)
            Me.txtCIResponsableAutoFR.Name = "txtCIResponsableAutoFR"
            Me.txtCIResponsableAutoFR.Size = New System.Drawing.Size(113, 22)
            Me.txtCIResponsableAutoFR.TabIndex = 10
            Me.txtCIResponsableAutoFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCIResponsableAutoFR
            '
            Me.lblCIResponsableAutoFR.AutoSize = True
            Me.lblCIResponsableAutoFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCIResponsableAutoFR.Location = New System.Drawing.Point(342, 23)
            Me.lblCIResponsableAutoFR.Name = "lblCIResponsableAutoFR"
            Me.lblCIResponsableAutoFR.Size = New System.Drawing.Size(54, 13)
            Me.lblCIResponsableAutoFR.TabIndex = 0
            Me.lblCIResponsableAutoFR.Text = "CEDULA :"
            '
            'gpValorGastoSolicitudFR
            '
            Me.gpValorGastoSolicitudFR.BackColor = System.Drawing.Color.White
            Me.gpValorGastoSolicitudFR.Controls.Add(Me.txtValorSolicitudFR)
            Me.gpValorGastoSolicitudFR.Location = New System.Drawing.Point(276, 265)
            Me.gpValorGastoSolicitudFR.Name = "gpValorGastoSolicitudFR"
            Me.gpValorGastoSolicitudFR.Size = New System.Drawing.Size(112, 65)
            Me.gpValorGastoSolicitudFR.TabIndex = 15
            Me.gpValorGastoSolicitudFR.TabStop = False
            Me.gpValorGastoSolicitudFR.Text = "VALOR"
            '
            'txtValorSolicitudFR
            '
            Me.txtValorSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtValorSolicitudFR.Enabled = False
            Me.txtValorSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorSolicitudFR.Location = New System.Drawing.Point(13, 24)
            Me.txtValorSolicitudFR.Name = "txtValorSolicitudFR"
            Me.txtValorSolicitudFR.Size = New System.Drawing.Size(87, 23)
            Me.txtValorSolicitudFR.TabIndex = 21
            Me.txtValorSolicitudFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbDetalleGasto
            '
            Me.gbDetalleGasto.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.gbDetalleGasto.BackColor = System.Drawing.Color.White
            Me.gbDetalleGasto.Controls.Add(Me.txtDetalleSolicitudFR)
            Me.gbDetalleGasto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleGasto.Location = New System.Drawing.Point(389, 265)
            Me.gbDetalleGasto.Name = "gbDetalleGasto"
            Me.gbDetalleGasto.Size = New System.Drawing.Size(611, 65)
            Me.gbDetalleGasto.TabIndex = 16
            Me.gbDetalleGasto.TabStop = False
            Me.gbDetalleGasto.Text = "DETALLE DEL GASTO"
            '
            'txtDetalleSolicitudFR
            '
            Me.txtDetalleSolicitudFR.BackColor = System.Drawing.Color.White
            Me.txtDetalleSolicitudFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleSolicitudFR.Enabled = False
            Me.txtDetalleSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleSolicitudFR.Location = New System.Drawing.Point(6, 16)
            Me.txtDetalleSolicitudFR.Multiline = True
            Me.txtDetalleSolicitudFR.Name = "txtDetalleSolicitudFR"
            Me.txtDetalleSolicitudFR.Size = New System.Drawing.Size(599, 43)
            Me.txtDetalleSolicitudFR.TabIndex = 22
            '
            'gbReferencia
            '
            Me.gbReferencia.BackColor = System.Drawing.Color.White
            Me.gbReferencia.Controls.Add(Me.txtFechaSolicitudFR)
            Me.gbReferencia.Controls.Add(Me.txtNroSolicitudFR)
            Me.gbReferencia.Controls.Add(Me.lblFechaSolicitudFR)
            Me.gbReferencia.Controls.Add(Me.lblNumeroSolicitudFR)
            Me.gbReferencia.Controls.Add(Me.dtpFechaEmisionComprobanteCompra)
            Me.gbReferencia.Controls.Add(Me.dtpComprobanteRetencion)
            Me.gbReferencia.Controls.Add(Me.dgvDetallesRetencion)
            Me.gbReferencia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReferencia.Location = New System.Drawing.Point(1, 20)
            Me.gbReferencia.Name = "gbReferencia"
            Me.gbReferencia.Size = New System.Drawing.Size(999, 42)
            Me.gbReferencia.TabIndex = 19
            Me.gbReferencia.TabStop = False
            '
            'txtFechaSolicitudFR
            '
            Me.txtFechaSolicitudFR.Enabled = False
            Me.txtFechaSolicitudFR.Location = New System.Drawing.Point(497, 14)
            Me.txtFechaSolicitudFR.Name = "txtFechaSolicitudFR"
            Me.txtFechaSolicitudFR.Size = New System.Drawing.Size(262, 22)
            Me.txtFechaSolicitudFR.TabIndex = 2
            '
            'dtpFechaEmisionComprobanteCompra
            '
            Me.dtpFechaEmisionComprobanteCompra.Enabled = False
            Me.dtpFechaEmisionComprobanteCompra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaEmisionComprobanteCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEmisionComprobanteCompra.Location = New System.Drawing.Point(498, 14)
            Me.dtpFechaEmisionComprobanteCompra.Name = "dtpFechaEmisionComprobanteCompra"
            Me.dtpFechaEmisionComprobanteCompra.Size = New System.Drawing.Size(123, 22)
            Me.dtpFechaEmisionComprobanteCompra.TabIndex = 20
            '
            'dtpComprobanteRetencion
            '
            Me.dtpComprobanteRetencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpComprobanteRetencion.Location = New System.Drawing.Point(498, 14)
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
            Me.dgvDetallesRetencion.Location = New System.Drawing.Point(147, 15)
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
            'gbReceptorDinero
            '
            Me.gbReceptorDinero.BackColor = System.Drawing.Color.White
            Me.gbReceptorDinero.Controls.Add(Me.btnBuscarPersonal)
            Me.gbReceptorDinero.Controls.Add(Me.txtReceptorDineroSolicitud)
            Me.gbReceptorDinero.Controls.Add(Me.txtCIReceptorDinero)
            Me.gbReceptorDinero.Controls.Add(Me.lblNombreReceptorReciboFR)
            Me.gbReceptorDinero.Controls.Add(Me.lblCIReceptorReciboFR)
            Me.gbReceptorDinero.Controls.Add(Me.dgvAsientosDiario)
            Me.gbReceptorDinero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbReceptorDinero.Location = New System.Drawing.Point(2, 211)
            Me.gbReceptorDinero.Name = "gbReceptorDinero"
            Me.gbReceptorDinero.Size = New System.Drawing.Size(998, 53)
            Me.gbReceptorDinero.TabIndex = 20
            Me.gbReceptorDinero.TabStop = False
            Me.gbReceptorDinero.Text = "RECEPTOR DEL DINERO"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Enabled = False
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.personnel_light_icon
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(294, 18)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(32, 23)
            Me.btnBuscarPersonal.TabIndex = 16
            Me.btnBuscarPersonal.Text = "..."
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtReceptorDineroSolicitud
            '
            Me.txtReceptorDineroSolicitud.BackColor = System.Drawing.Color.White
            Me.txtReceptorDineroSolicitud.Enabled = False
            Me.txtReceptorDineroSolicitud.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReceptorDineroSolicitud.Location = New System.Drawing.Point(513, 19)
            Me.txtReceptorDineroSolicitud.Name = "txtReceptorDineroSolicitud"
            Me.txtReceptorDineroSolicitud.Size = New System.Drawing.Size(423, 22)
            Me.txtReceptorDineroSolicitud.TabIndex = 17
            Me.txtReceptorDineroSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCIReceptorDinero
            '
            Me.txtCIReceptorDinero.BackColor = System.Drawing.Color.White
            Me.txtCIReceptorDinero.Enabled = False
            Me.txtCIReceptorDinero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCIReceptorDinero.Location = New System.Drawing.Point(181, 19)
            Me.txtCIReceptorDinero.Name = "txtCIReceptorDinero"
            Me.txtCIReceptorDinero.Size = New System.Drawing.Size(113, 22)
            Me.txtCIReceptorDinero.TabIndex = 15
            '
            'lblNombreReceptorReciboFR
            '
            Me.lblNombreReceptorReciboFR.AutoSize = True
            Me.lblNombreReceptorReciboFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreReceptorReciboFR.Location = New System.Drawing.Point(450, 22)
            Me.lblNombreReceptorReciboFR.Name = "lblNombreReceptorReciboFR"
            Me.lblNombreReceptorReciboFR.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreReceptorReciboFR.TabIndex = 7
            Me.lblNombreReceptorReciboFR.Text = "NOMBRE:"
            '
            'lblCIReceptorReciboFR
            '
            Me.lblCIReceptorReciboFR.AutoSize = True
            Me.lblCIReceptorReciboFR.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCIReceptorReciboFR.Location = New System.Drawing.Point(68, 22)
            Me.lblCIReceptorReciboFR.Name = "lblCIReceptorReciboFR"
            Me.lblCIReceptorReciboFR.Size = New System.Drawing.Size(111, 13)
            Me.lblCIReceptorReciboFR.TabIndex = 6
            Me.lblCIReceptorReciboFR.Text = "CEDULA IDENTIDAD:"
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
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(341, 13)
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
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtCodDebe)
            Me.GroupBox1.Controls.Add(Me.lblCodDebe)
            Me.GroupBox1.Controls.Add(Me.lblCodHaber)
            Me.GroupBox1.Controls.Add(Me.txtCodHaber)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(678, 136)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(322, 73)
            Me.GroupBox1.TabIndex = 39
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "CONTABILIZACIÓN"
            '
            'gbDocumento
            '
            Me.gbDocumento.BackColor = System.Drawing.Color.White
            Me.gbDocumento.Controls.Add(Me.lblNroDocumento)
            Me.gbDocumento.Controls.Add(Me.txtNroDocumento)
            Me.gbDocumento.Controls.Add(Me.btnDocumento)
            Me.gbDocumento.Controls.Add(Me.cmbNombreParametroDocumentos)
            Me.gbDocumento.Location = New System.Drawing.Point(2, 265)
            Me.gbDocumento.Name = "gbDocumento"
            Me.gbDocumento.Size = New System.Drawing.Size(273, 65)
            Me.gbDocumento.TabIndex = 40
            Me.gbDocumento.TabStop = False
            Me.gbDocumento.Text = "DOCUMENTO:"
            '
            'lblNroDocumento
            '
            Me.lblNroDocumento.AutoSize = True
            Me.lblNroDocumento.Location = New System.Drawing.Point(9, 42)
            Me.lblNroDocumento.Name = "lblNroDocumento"
            Me.lblNroDocumento.Size = New System.Drawing.Size(22, 13)
            Me.lblNroDocumento.TabIndex = 56
            Me.lblNroDocumento.Text = "N°:"
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Location = New System.Drawing.Point(37, 39)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(159, 22)
            Me.txtNroDocumento.TabIndex = 19
            '
            'btnDocumento
            '
            Me.btnDocumento.BackColor = System.Drawing.Color.White
            Me.btnDocumento.Enabled = False
            Me.btnDocumento.FlatAppearance.BorderSize = 0
            Me.btnDocumento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDocumento.Image = CType(resources.GetObject("btnDocumento.Image"), System.Drawing.Image)
            Me.btnDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDocumento.Location = New System.Drawing.Point(202, 10)
            Me.btnDocumento.Name = "btnDocumento"
            Me.btnDocumento.Size = New System.Drawing.Size(67, 50)
            Me.btnDocumento.TabIndex = 20
            Me.btnDocumento.Text = "CARGAR DOCUM."
            Me.btnDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDocumento.UseVisualStyleBackColor = False
            '
            'cmbNombreParametroDocumentos
            '
            Me.cmbNombreParametroDocumentos.BackColor = System.Drawing.Color.White
            Me.cmbNombreParametroDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNombreParametroDocumentos.Enabled = False
            Me.cmbNombreParametroDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbNombreParametroDocumentos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNombreParametroDocumentos.FormattingEnabled = True
            Me.cmbNombreParametroDocumentos.Location = New System.Drawing.Point(12, 14)
            Me.cmbNombreParametroDocumentos.Name = "cmbNombreParametroDocumentos"
            Me.cmbNombreParametroDocumentos.Size = New System.Drawing.Size(184, 23)
            Me.cmbNombreParametroDocumentos.TabIndex = 18
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoSolicitudFR, Me.btnGuardarSolicitudFR, Me.btnCancelarSolicitudFR})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1001, 24)
            Me.MenuStrip1.TabIndex = 183
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoSolicitudFR
            '
            Me.btnNuevoSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSolicitudFR.Image = CType(resources.GetObject("btnNuevoSolicitudFR.Image"), System.Drawing.Image)
            Me.btnNuevoSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoSolicitudFR.Name = "btnNuevoSolicitudFR"
            Me.btnNuevoSolicitudFR.Size = New System.Drawing.Size(73, 20)
            Me.btnNuevoSolicitudFR.Text = "NUEVO"
            '
            'btnGuardarSolicitudFR
            '
            Me.btnGuardarSolicitudFR.Enabled = False
            Me.btnGuardarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSolicitudFR.Image = CType(resources.GetObject("btnGuardarSolicitudFR.Image"), System.Drawing.Image)
            Me.btnGuardarSolicitudFR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSolicitudFR.Name = "btnGuardarSolicitudFR"
            Me.btnGuardarSolicitudFR.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardarSolicitudFR.Text = "GUARDAR"
            '
            'btnCancelarSolicitudFR
            '
            Me.btnCancelarSolicitudFR.Enabled = False
            Me.btnCancelarSolicitudFR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSolicitudFR.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarSolicitudFR.Name = "btnCancelarSolicitudFR"
            Me.btnCancelarSolicitudFR.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelarSolicitudFR.Text = "CANCELAR"
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.lblActividadDetalleFR)
            Me.GroupBox2.Controls.Add(Me.lblCentroCosto)
            Me.GroupBox2.Controls.Add(Me.lblCanton)
            Me.GroupBox2.Controls.Add(Me.lblProvincia)
            Me.GroupBox2.Controls.Add(Me.lblConceptoDetalleFR)
            Me.GroupBox2.Controls.Add(Me.cmbCentroCosto)
            Me.GroupBox2.Controls.Add(Me.lblParroquia)
            Me.GroupBox2.Controls.Add(Me.cmbParroquia)
            Me.GroupBox2.Controls.Add(Me.txtActividadDetalleFR)
            Me.GroupBox2.Controls.Add(Me.cmbCanton)
            Me.GroupBox2.Controls.Add(Me.cmbConcepto)
            Me.GroupBox2.Controls.Add(Me.cmbProvincia)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(1, 63)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(999, 71)
            Me.GroupBox2.TabIndex = 184
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "CENTRO COSTO DEL GASTO"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.chkCombustible)
            Me.GroupBox3.Controls.Add(Me.PictureBox1)
            Me.GroupBox3.Controls.Add(Me.txtFechaControl)
            Me.GroupBox3.Controls.Add(Me.gbLlegadaVehiculo)
            Me.GroupBox3.Controls.Add(Me.gbVehiculo)
            Me.GroupBox3.Controls.Add(Me.txtTotalKmControlC)
            Me.GroupBox3.Controls.Add(Me.lblTotaKmControlC)
            Me.GroupBox3.Controls.Add(Me.gpSalidaVehiculo)
            Me.GroupBox3.Controls.Add(Me.cbmCombustible)
            Me.GroupBox3.Controls.Add(Me.lblFechaControlC)
            Me.GroupBox3.Controls.Add(Me.txtMotivoControlC)
            Me.GroupBox3.Controls.Add(Me.lblClaseGasolinaControlC)
            Me.GroupBox3.Controls.Add(Me.txtDestinoControlC)
            Me.GroupBox3.Controls.Add(Me.lblMotivoControlC)
            Me.GroupBox3.Controls.Add(Me.txtValorControl)
            Me.GroupBox3.Controls.Add(Me.lblDestinoControlC)
            Me.GroupBox3.Controls.Add(Me.lblValorControlC)
            Me.GroupBox3.Enabled = False
            Me.GroupBox3.Location = New System.Drawing.Point(1, 332)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(997, 178)
            Me.GroupBox3.TabIndex = 185
            Me.GroupBox3.TabStop = False
            '
            'chkCombustible
            '
            Me.chkCombustible.AutoSize = True
            Me.chkCombustible.BackColor = System.Drawing.Color.White
            Me.chkCombustible.Enabled = False
            Me.chkCombustible.Location = New System.Drawing.Point(6, 0)
            Me.chkCombustible.Name = "chkCombustible"
            Me.chkCombustible.Size = New System.Drawing.Size(169, 17)
            Me.chkCombustible.TabIndex = 23
            Me.chkCombustible.Text = "CONTROL DE COMBUSTIBLE"
            Me.chkCombustible.UseVisualStyleBackColor = False
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
            Me.txtFechaControl.Size = New System.Drawing.Size(99, 22)
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
            Me.dtpHoraLlegadaVehiculo.Size = New System.Drawing.Size(110, 22)
            Me.dtpHoraLlegadaVehiculo.TabIndex = 36
            '
            'dtpFechaLlegadaVehiculo
            '
            Me.dtpFechaLlegadaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaLlegadaVehiculo.Location = New System.Drawing.Point(49, 19)
            Me.dtpFechaLlegadaVehiculo.Name = "dtpFechaLlegadaVehiculo"
            Me.dtpFechaLlegadaVehiculo.Size = New System.Drawing.Size(110, 22)
            Me.dtpFechaLlegadaVehiculo.TabIndex = 35
            '
            'txtKmLlegadaVehiculo
            '
            Me.txtKmLlegadaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmLlegadaVehiculo.Location = New System.Drawing.Point(49, 65)
            Me.txtKmLlegadaVehiculo.Name = "txtKmLlegadaVehiculo"
            Me.txtKmLlegadaVehiculo.Size = New System.Drawing.Size(110, 22)
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
            Me.btnBuscarVehiculo.TabIndex = 32
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
            Me.txtMarcaVehiculo.TabIndex = 31
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
            Me.txtTotalKmControlC.Size = New System.Drawing.Size(47, 22)
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
            Me.dtpHoraSalidaVehiculo.Size = New System.Drawing.Size(110, 22)
            Me.dtpHoraSalidaVehiculo.TabIndex = 39
            '
            'dtpFechaSalidaVehiculo
            '
            Me.dtpFechaSalidaVehiculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaSalidaVehiculo.Location = New System.Drawing.Point(46, 19)
            Me.dtpFechaSalidaVehiculo.Name = "dtpFechaSalidaVehiculo"
            Me.dtpFechaSalidaVehiculo.Size = New System.Drawing.Size(110, 22)
            Me.dtpFechaSalidaVehiculo.TabIndex = 38
            '
            'txtKmSalidaVehiculo
            '
            Me.txtKmSalidaVehiculo.BackColor = System.Drawing.Color.White
            Me.txtKmSalidaVehiculo.Location = New System.Drawing.Point(46, 65)
            Me.txtKmSalidaVehiculo.Name = "txtKmSalidaVehiculo"
            Me.txtKmSalidaVehiculo.Size = New System.Drawing.Size(110, 22)
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
            Me.txtMotivoControlC.Size = New System.Drawing.Size(283, 22)
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
            Me.txtDestinoControlC.Size = New System.Drawing.Size(289, 22)
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
            'lblMontoFondoRotativo
            '
            Me.lblMontoFondoRotativo.AutoSize = True
            Me.lblMontoFondoRotativo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoFondoRotativo.Location = New System.Drawing.Point(930, 5)
            Me.lblMontoFondoRotativo.Name = "lblMontoFondoRotativo"
            Me.lblMontoFondoRotativo.Size = New System.Drawing.Size(38, 15)
            Me.lblMontoFondoRotativo.TabIndex = 188
            Me.lblMontoFondoRotativo.Text = "00.00"
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(812, 3)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(126, 19)
            Me.Label3.TabIndex = 191
            Me.Label3.Text = "VALOR DISPONIBLE:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblMontoAsignado
            '
            Me.lblMontoAsignado.AutoSize = True
            Me.lblMontoAsignado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMontoAsignado.Location = New System.Drawing.Point(696, 4)
            Me.lblMontoAsignado.Name = "lblMontoAsignado"
            Me.lblMontoAsignado.Size = New System.Drawing.Size(38, 15)
            Me.lblMontoAsignado.TabIndex = 190
            Me.lblMontoAsignado.Text = "00.00"
            '
            'Label30
            '
            Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(577, 2)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(126, 19)
            Me.Label30.TabIndex = 189
            Me.Label30.Text = "MONTO ASIGNADO:"
            Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            'FormSolicitudFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1001, 510)
            Me.Controls.Add(Me.lblMontoFondoRotativo)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblMontoAsignado)
            Me.Controls.Add(Me.Label30)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbReferencia)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbReceptorDinero)
            Me.Controls.Add(Me.gbDetalleGasto)
            Me.Controls.Add(Me.gpValorGastoSolicitudFR)
            Me.Controls.Add(Me.gpAutorizacionFondoRotativo)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.gbDocumento)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormSolicitudFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SOLICITUD DE FONDO ROTATIVO"
            Me.gpAutorizacionFondoRotativo.ResumeLayout(False)
            Me.gpAutorizacionFondoRotativo.PerformLayout()
            Me.gpValorGastoSolicitudFR.ResumeLayout(False)
            Me.gpValorGastoSolicitudFR.PerformLayout()
            Me.gbDetalleGasto.ResumeLayout(False)
            Me.gbDetalleGasto.PerformLayout()
            Me.gbReferencia.ResumeLayout(False)
            Me.gbReferencia.PerformLayout()
            CType(Me.dgvDetallesRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbReceptorDinero.ResumeLayout(False)
            Me.gbReceptorDinero.PerformLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbDocumento.ResumeLayout(False)
            Me.gbDocumento.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbLlegadaVehiculo.ResumeLayout(False)
            Me.gbLlegadaVehiculo.PerformLayout()
            Me.gbVehiculo.ResumeLayout(False)
            Me.gbVehiculo.PerformLayout()
            Me.gpSalidaVehiculo.ResumeLayout(False)
            Me.gpSalidaVehiculo.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblNumeroSolicitudFR As System.Windows.Forms.Label
        Friend WithEvents txtNroSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaSolicitudFR As System.Windows.Forms.Label
        Friend WithEvents lblActividadDetalleFR As System.Windows.Forms.Label
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblConceptoDetalleFR As System.Windows.Forms.Label
        Friend WithEvents lblCanton As System.Windows.Forms.Label
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents lblCodHaber As System.Windows.Forms.Label
        Friend WithEvents lblCodDebe As System.Windows.Forms.Label
        Friend WithEvents txtActividadDetalleFR As System.Windows.Forms.TextBox
        Friend WithEvents txtCodHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtCodDebe As System.Windows.Forms.TextBox
        Friend WithEvents gpAutorizacionFondoRotativo As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreResponsbleAutoFR As System.Windows.Forms.Label
        Friend WithEvents txtCIResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents lblCIResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents gpValorGastoSolicitudFR As System.Windows.Forms.GroupBox
        Friend WithEvents gbDetalleGasto As System.Windows.Forms.GroupBox
        Friend WithEvents txtDetalleSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCargoResponsableAutoFR As System.Windows.Forms.ComboBox
        Friend WithEvents lblCargoResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents lblApellidoResponsableAutoFR As System.Windows.Forms.Label
        Friend WithEvents txtApellidoResponsableAutoFR As System.Windows.Forms.TextBox
        Friend WithEvents gbReferencia As System.Windows.Forms.GroupBox
        Friend WithEvents gbReceptorDinero As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtReceptorDineroSolicitud As System.Windows.Forms.TextBox
        Friend WithEvents txtCIReceptorDinero As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreReceptorReciboFR As System.Windows.Forms.Label
        Friend WithEvents lblCIReceptorReciboFR As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents gbDocumento As System.Windows.Forms.GroupBox
        Friend WithEvents cmbNombreParametroDocumentos As System.Windows.Forms.ComboBox
        Friend WithEvents txtValorSolicitudFR As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmisionComprobanteCompra As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarSolicitudFR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaSolicitudFR As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpComprobanteRetencion As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnDocumento As System.Windows.Forms.Button
        Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents txtFechaControl As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbLlegadaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaLlegadaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmLlegadaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents LblKilometrajeLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblHoraLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblFechaLlegadaVehiculo As System.Windows.Forms.Label
        Friend WithEvents gbVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscarVehiculo As System.Windows.Forms.Button
        Friend WithEvents lblIdActivo As System.Windows.Forms.Label
        Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtModeloVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents txtMarcaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblPlacaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblModeloVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblMarcaVehiculo As System.Windows.Forms.Label
        Friend WithEvents txtTotalKmControlC As System.Windows.Forms.TextBox
        Friend WithEvents lblTotaKmControlC As System.Windows.Forms.Label
        Friend WithEvents gpSalidaVehiculo As System.Windows.Forms.GroupBox
        Friend WithEvents dtpHoraSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaSalidaVehiculo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtKmSalidaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents lblKilometrajeSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblHoraSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents lblFechaSalidaVehiculo As System.Windows.Forms.Label
        Friend WithEvents chkCombustible As System.Windows.Forms.CheckBox
        Friend WithEvents cbmCombustible As System.Windows.Forms.ComboBox
        Friend WithEvents lblFechaControlC As System.Windows.Forms.Label
        Friend WithEvents txtMotivoControlC As System.Windows.Forms.TextBox
        Friend WithEvents lblClaseGasolinaControlC As System.Windows.Forms.Label
        Friend WithEvents txtDestinoControlC As System.Windows.Forms.TextBox
        Friend WithEvents lblMotivoControlC As System.Windows.Forms.Label
        Friend WithEvents txtValorControl As System.Windows.Forms.TextBox
        Friend WithEvents lblDestinoControlC As System.Windows.Forms.Label
        Friend WithEvents lblValorControlC As System.Windows.Forms.Label
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
    End Class
End Namespace