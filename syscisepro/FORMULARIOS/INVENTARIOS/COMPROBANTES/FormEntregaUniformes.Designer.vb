Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEntregaUniformes
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEntregaUniformes))
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.tbComprobanteIngresoBodega = New System.Windows.Forms.TabControl()
            Me.tpRegistro = New System.Windows.Forms.TabPage()
            Me.dtpRolPago = New System.Windows.Forms.DateTimePicker()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
            Me.txtObservacionEntrega = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtAprobado = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtRevisado = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.lblCargoRealizado = New System.Windows.Forms.Label()
            Me.txtRealizado = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.gbBusquedaArticulo = New System.Windows.Forms.GroupBox()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.btnSerie = New System.Windows.Forms.Button()
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.lblTotalUniformes = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.nudTotal = New System.Windows.Forms.NumericUpDown()
            Me.dgvSecuencial = New System.Windows.Forms.DataGridView()
            Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OBSERVACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NUMERO_KARDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE_KARDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_UNITARIO_ANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_TOTAL_ANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_UNITARIO_SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_SECUENCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblValorGasto = New System.Windows.Forms.Label()
            Me.tsmEliminar = New System.Windows.Forms.Button()
            Me.nudValor = New System.Windows.Forms.NumericUpDown()
            Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.tsmAgregar = New System.Windows.Forms.Button()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cmbObservacionCalidad = New System.Windows.Forms.ComboBox()
            Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.lblObservacionCalidad = New System.Windows.Forms.Label()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.lblIdDetalleKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex = New System.Windows.Forms.Label()
            Me.lblIdArticulo = New System.Windows.Forms.Label()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtRegistrado = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkEditar = New System.Windows.Forms.CheckBox()
            Me.txtVersion = New System.Windows.Forms.TextBox()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.gbEncabezado = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pbImagen = New System.Windows.Forms.PictureBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tpConsultar = New System.Windows.Forms.TabPage()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.rbtDet = New System.Windows.Forms.RadioButton()
            Me.rbtNum = New System.Windows.Forms.RadioButton()
            Me.txtDetail = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.txtNroComprobante = New System.Windows.Forms.TextBox()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.dgvComprobantesIngreso = New System.Windows.Forms.DataGridView()
            Me.gbDetalleComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarDetalleComprobante = New System.Windows.Forms.Button()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.bntCargar = New System.Windows.Forms.Button()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtIdEntrega = New System.Windows.Forms.TextBox()
            Me.crvComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.miniToolStrip = New System.Windows.Forms.MenuStrip()
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            Me.tpRegistro.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.gbBusquedaArticulo.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbEncabezado.SuspendLayout()
            CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultar.SuspendLayout()
            Me.gbNumeroFactura.SuspendLayout()
            Me.gbComprobante.SuspendLayout()
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDetalleComprobante.SuspendLayout()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tbComprobanteIngresoBodega
            '
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpRegistro)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpConsultar)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpReporte)
            Me.tbComprobanteIngresoBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbComprobanteIngresoBodega.Location = New System.Drawing.Point(2, 2)
            Me.tbComprobanteIngresoBodega.Name = "tbComprobanteIngresoBodega"
            Me.tbComprobanteIngresoBodega.SelectedIndex = 0
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(1267, 611)
            Me.tbComprobanteIngresoBodega.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tbComprobanteIngresoBodega.TabIndex = 168
            '
            'tpRegistro
            '
            Me.tpRegistro.BackColor = System.Drawing.Color.White
            Me.tpRegistro.Controls.Add(Me.dtpRolPago)
            Me.tpRegistro.Controls.Add(Me.Label24)
            Me.tpRegistro.Controls.Add(Me.MenuStrip1)
            Me.tpRegistro.Controls.Add(Me.Label13)
            Me.tpRegistro.Controls.Add(Me.dtpIngreso)
            Me.tpRegistro.Controls.Add(Me.txtObservacionEntrega)
            Me.tpRegistro.Controls.Add(Me.Label7)
            Me.tpRegistro.Controls.Add(Me.GroupBox4)
            Me.tpRegistro.Controls.Add(Me.txtCliente)
            Me.tpRegistro.Controls.Add(Me.Label8)
            Me.tpRegistro.Controls.Add(Me.GroupBox6)
            Me.tpRegistro.Controls.Add(Me.txtCedula)
            Me.tpRegistro.Controls.Add(Me.GroupBox7)
            Me.tpRegistro.Controls.Add(Me.Label5)
            Me.tpRegistro.Controls.Add(Me.gbBusquedaArticulo)
            Me.tpRegistro.Controls.Add(Me.txtRecibe)
            Me.tpRegistro.Controls.Add(Me.Label6)
            Me.tpRegistro.Controls.Add(Me.GroupBox5)
            Me.tpRegistro.Controls.Add(Me.GroupBox1)
            Me.tpRegistro.Controls.Add(Me.gbEncabezado)
            Me.tpRegistro.Controls.Add(Me.pbImagen)
            Me.tpRegistro.Controls.Add(Me.Label10)
            Me.tpRegistro.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tpRegistro.Name = "tpRegistro"
            Me.tpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegistro.Size = New System.Drawing.Size(1259, 585)
            Me.tpRegistro.TabIndex = 0
            Me.tpRegistro.Text = "REGISTRO"
            '
            'dtpRolPago
            '
            Me.dtpRolPago.CustomFormat = "MMMM yyyy"
            Me.dtpRolPago.Enabled = False
            Me.dtpRolPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpRolPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpRolPago.Location = New System.Drawing.Point(1131, 151)
            Me.dtpRolPago.Name = "dtpRolPago"
            Me.dtpRolPago.ShowUpDown = True
            Me.dtpRolPago.Size = New System.Drawing.Size(122, 21)
            Me.dtpRolPago.TabIndex = 214
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Enabled = False
            Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(1010, 155)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(123, 13)
            Me.Label24.TabIndex = 213
            Me.Label24.Text = "PROCESAR EN ROL DE:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1253, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'tsmNuevo
            '
            Me.tsmNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmNuevo.Name = "tsmNuevo"
            Me.tsmNuevo.Size = New System.Drawing.Size(82, 28)
            Me.tsmNuevo.Text = "NUEVO"
            '
            'tsmGuardar
            '
            Me.tsmGuardar.Enabled = False
            Me.tsmGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmGuardar.Name = "tsmGuardar"
            Me.tsmGuardar.Size = New System.Drawing.Size(95, 28)
            Me.tsmGuardar.Text = "GUARDAR"
            '
            'tsmCancelar
            '
            Me.tsmCancelar.Enabled = False
            Me.tsmCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmCancelar.Name = "tsmCancelar"
            Me.tsmCancelar.Size = New System.Drawing.Size(97, 28)
            Me.tsmCancelar.Text = "CANCELAR"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.Black
            Me.Label13.Location = New System.Drawing.Point(11, 157)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(84, 13)
            Me.Label13.TabIndex = 186
            Me.Label13.Text = "OBSERVACIÓN:"
            '
            'dtpIngreso
            '
            Me.dtpIngreso.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpIngreso.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpIngreso.Enabled = False
            Me.dtpIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpIngreso.Location = New System.Drawing.Point(1069, 123)
            Me.dtpIngreso.Name = "dtpIngreso"
            Me.dtpIngreso.Size = New System.Drawing.Size(186, 21)
            Me.dtpIngreso.TabIndex = 10
            '
            'txtObservacionEntrega
            '
            Me.txtObservacionEntrega.BackColor = System.Drawing.Color.White
            Me.txtObservacionEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionEntrega.Enabled = False
            Me.txtObservacionEntrega.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionEntrega.ForeColor = System.Drawing.Color.Black
            Me.txtObservacionEntrega.Location = New System.Drawing.Point(100, 151)
            Me.txtObservacionEntrega.Name = "txtObservacionEntrega"
            Me.txtObservacionEntrega.Size = New System.Drawing.Size(892, 22)
            Me.txtObservacionEntrega.TabIndex = 185
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(1010, 126)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(57, 13)
            Me.Label7.TabIndex = 9
            Me.Label7.Text = "INGRESO:"
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.txtAprobado)
            Me.GroupBox4.Controls.Add(Me.Label20)
            Me.GroupBox4.Location = New System.Drawing.Point(795, 621)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(394, 60)
            Me.GroupBox4.TabIndex = 182
            Me.GroupBox4.TabStop = False
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(175, 34)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(112, 15)
            Me.Label19.TabIndex = 5
            Me.Label19.Text = "Gerente General"
            '
            'txtAprobado
            '
            Me.txtAprobado.Enabled = False
            Me.txtAprobado.Location = New System.Drawing.Point(129, 11)
            Me.txtAprobado.Name = "txtAprobado"
            Me.txtAprobado.Size = New System.Drawing.Size(203, 21)
            Me.txtAprobado.TabIndex = 4
            Me.txtAprobado.Text = "Myr(R) Ignacio Navarrete L"
            Me.txtAprobado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(27, 16)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(98, 15)
            Me.Label20.TabIndex = 0
            Me.Label20.Text = "Aprobado por:"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(557, 123)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(435, 22)
            Me.txtCliente.TabIndex = 8
            Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(507, 126)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(50, 13)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = "PUESTO:"
            '
            'GroupBox6
            '
            Me.GroupBox6.BackColor = System.Drawing.Color.White
            Me.GroupBox6.Controls.Add(Me.Label16)
            Me.GroupBox6.Controls.Add(Me.txtRevisado)
            Me.GroupBox6.Controls.Add(Me.Label11)
            Me.GroupBox6.Location = New System.Drawing.Point(371, 621)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(420, 60)
            Me.GroupBox6.TabIndex = 181
            Me.GroupBox6.TabStop = False
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(175, 34)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(126, 15)
            Me.Label16.TabIndex = 5
            Me.Label16.Text = "Representante SIG"
            '
            'txtRevisado
            '
            Me.txtRevisado.Enabled = False
            Me.txtRevisado.Location = New System.Drawing.Point(132, 11)
            Me.txtRevisado.Name = "txtRevisado"
            Me.txtRevisado.Size = New System.Drawing.Size(203, 21)
            Me.txtRevisado.TabIndex = 4
            Me.txtRevisado.Text = "Ing. Karen Navarrete M"
            Me.txtRevisado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(30, 16)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(98, 15)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Revisado por:"
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(392, 123)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(94, 22)
            Me.txtCedula.TabIndex = 6
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'GroupBox7
            '
            Me.GroupBox7.BackColor = System.Drawing.Color.White
            Me.GroupBox7.Controls.Add(Me.lblCargoRealizado)
            Me.GroupBox7.Controls.Add(Me.txtRealizado)
            Me.GroupBox7.Controls.Add(Me.Label18)
            Me.GroupBox7.Location = New System.Drawing.Point(6, 621)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(359, 60)
            Me.GroupBox7.TabIndex = 180
            Me.GroupBox7.TabStop = False
            '
            'lblCargoRealizado
            '
            Me.lblCargoRealizado.AutoSize = True
            Me.lblCargoRealizado.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCargoRealizado.Location = New System.Drawing.Point(141, 34)
            Me.lblCargoRealizado.Name = "lblCargoRealizado"
            Me.lblCargoRealizado.Size = New System.Drawing.Size(84, 15)
            Me.lblCargoRealizado.TabIndex = 5
            Me.lblCargoRealizado.Text = "Jefe de SSO"
            '
            'txtRealizado
            '
            Me.txtRealizado.Enabled = False
            Me.txtRealizado.Location = New System.Drawing.Point(110, 11)
            Me.txtRealizado.Name = "txtRealizado"
            Me.txtRealizado.Size = New System.Drawing.Size(201, 21)
            Me.txtRealizado.TabIndex = 4
            Me.txtRealizado.Text = "Ing. José Navarrete M."
            Me.txtRealizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(8, 16)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(105, 15)
            Me.Label18.TabIndex = 0
            Me.Label18.Text = "Realizado por:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(342, 126)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(51, 13)
            Me.Label5.TabIndex = 5
            Me.Label5.Text = "CÉDULA:"
            '
            'gbBusquedaArticulo
            '
            Me.gbBusquedaArticulo.BackColor = System.Drawing.Color.White
            Me.gbBusquedaArticulo.Controls.Add(Me.pbFoto)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label27)
            Me.gbBusquedaArticulo.Controls.Add(Me.btnSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label26)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblTotalUniformes)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label25)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label9)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudTotal)
            Me.gbBusquedaArticulo.Controls.Add(Me.dgvSecuencial)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblValorGasto)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmEliminar)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudValor)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtCodigoArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label12)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmAgregar)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label15)
            Me.gbBusquedaArticulo.Controls.Add(Me.cmbObservacionCalidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudCantidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label17)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtObservacion)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblObservacionCalidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdDetalleKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdArticulo)
            Me.gbBusquedaArticulo.Enabled = False
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(3, 179)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(1253, 403)
            Me.gbBusquedaArticulo.TabIndex = 178
            Me.gbBusquedaArticulo.TabStop = False
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Location = New System.Drawing.Point(1050, 17)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(100, 40)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 215
            Me.pbFoto.TabStop = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.ForeColor = System.Drawing.Color.Black
            Me.Label27.Location = New System.Drawing.Point(1051, 1)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(40, 15)
            Me.Label27.TabIndex = 214
            Me.Label27.Text = "FOTO:"
            '
            'btnSerie
            '
            Me.btnSerie.BackColor = System.Drawing.Color.White
            Me.btnSerie.Enabled = False
            Me.btnSerie.FlatAppearance.BorderSize = 0
            Me.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSerie.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnSerie.Location = New System.Drawing.Point(378, 30)
            Me.btnSerie.Name = "btnSerie"
            Me.btnSerie.Size = New System.Drawing.Size(26, 26)
            Me.btnSerie.TabIndex = 213
            Me.btnSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSerie.UseVisualStyleBackColor = False
            Me.btnSerie.Visible = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(270, 31)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(104, 21)
            Me.txtSerie.TabIndex = 211
            Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtSerie.Visible = False
            '
            'Label26
            '
            Me.Label26.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.ForeColor = System.Drawing.Color.Black
            Me.Label26.Location = New System.Drawing.Point(271, 14)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(53, 14)
            Me.Label26.TabIndex = 212
            Me.Label26.Text = "SERIE:"
            Me.Label26.Visible = False
            '
            'lblTotalUniformes
            '
            Me.lblTotalUniformes.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblTotalUniformes.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalUniformes.Location = New System.Drawing.Point(1172, 387)
            Me.lblTotalUniformes.Name = "lblTotalUniformes"
            Me.lblTotalUniformes.Size = New System.Drawing.Size(80, 16)
            Me.lblTotalUniformes.TabIndex = 210
            Me.lblTotalUniformes.Text = "$ 0.00"
            Me.lblTotalUniformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label25
            '
            Me.Label25.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label25.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(-3, 387)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(1181, 16)
            Me.Label25.TabIndex = 209
            Me.Label25.Text = "0 PRENDA(S) - TOTAL UNIFORMES: "
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(706, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 194
            Me.Label9.Text = "TOTAL:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'nudTotal
            '
            Me.nudTotal.BackColor = System.Drawing.Color.White
            Me.nudTotal.DecimalPlaces = 2
            Me.nudTotal.Enabled = False
            Me.nudTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudTotal.ForeColor = System.Drawing.Color.Black
            Me.nudTotal.Location = New System.Drawing.Point(705, 32)
            Me.nudTotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudTotal.Name = "nudTotal"
            Me.nudTotal.Size = New System.Drawing.Size(85, 21)
            Me.nudTotal.TabIndex = 193
            Me.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.White
            Me.dgvSecuencial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSecuencial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSecuencial.ColumnHeadersHeight = 26
            Me.dgvSecuencial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.VALOR, Me.TOTAL, Me.OBSERVACION, Me.DETALLES, Me.NUMERO_KARDEX, Me.DETALLE_KARDEX, Me.VALOR_UNITARIO_ANTERIOR, Me.VALOR_TOTAL_ANTERIOR, Me.SALDO, Me.CANTIDAD_SALDO, Me.VALOR_UNITARIO_SALDO, Me.ID_SECUENCIAL})
            Me.dgvSecuencial.GridColor = System.Drawing.Color.Black
            Me.dgvSecuencial.Location = New System.Drawing.Point(3, 59)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(1244, 325)
            Me.dgvSecuencial.TabIndex = 192
            '
            'CODIGO
            '
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CODIGO.DefaultCellStyle = DataGridViewCellStyle3
            Me.CODIGO.HeaderText = "CÓD."
            Me.CODIGO.Name = "CODIGO"
            Me.CODIGO.ReadOnly = True
            Me.CODIGO.Width = 60
            '
            'NOMBRE
            '
            Me.NOMBRE.HeaderText = "NOMBRE"
            Me.NOMBRE.Name = "NOMBRE"
            Me.NOMBRE.ReadOnly = True
            Me.NOMBRE.Width = 370
            '
            'CANTIDAD
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle4
            Me.CANTIDAD.HeaderText = "CANT."
            Me.CANTIDAD.Name = "CANTIDAD"
            Me.CANTIDAD.ReadOnly = True
            Me.CANTIDAD.Width = 60
            '
            'VALOR
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VALOR.DefaultCellStyle = DataGridViewCellStyle5
            Me.VALOR.HeaderText = "VALOR"
            Me.VALOR.Name = "VALOR"
            Me.VALOR.ReadOnly = True
            Me.VALOR.Width = 60
            '
            'TOTAL
            '
            Me.TOTAL.HeaderText = "TOTAL"
            Me.TOTAL.Name = "TOTAL"
            Me.TOTAL.ReadOnly = True
            Me.TOTAL.Width = 60
            '
            'OBSERVACION
            '
            Me.OBSERVACION.HeaderText = "OBSERVACIÓN"
            Me.OBSERVACION.Name = "OBSERVACION"
            Me.OBSERVACION.ReadOnly = True
            Me.OBSERVACION.Width = 200
            '
            'DETALLES
            '
            Me.DETALLES.HeaderText = "DETALLES"
            Me.DETALLES.Name = "DETALLES"
            Me.DETALLES.ReadOnly = True
            Me.DETALLES.Width = 270
            '
            'NUMERO_KARDEX
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.NUMERO_KARDEX.DefaultCellStyle = DataGridViewCellStyle6
            Me.NUMERO_KARDEX.HeaderText = "N° KAR."
            Me.NUMERO_KARDEX.Name = "NUMERO_KARDEX"
            Me.NUMERO_KARDEX.ReadOnly = True
            Me.NUMERO_KARDEX.Width = 60
            '
            'DETALLE_KARDEX
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DETALLE_KARDEX.DefaultCellStyle = DataGridViewCellStyle7
            Me.DETALLE_KARDEX.HeaderText = "DETALLE"
            Me.DETALLE_KARDEX.Name = "DETALLE_KARDEX"
            Me.DETALLE_KARDEX.ReadOnly = True
            Me.DETALLE_KARDEX.Width = 80
            '
            'VALOR_UNITARIO_ANTERIOR
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VALOR_UNITARIO_ANTERIOR.DefaultCellStyle = DataGridViewCellStyle8
            Me.VALOR_UNITARIO_ANTERIOR.HeaderText = "V.U. ANTERIOR"
            Me.VALOR_UNITARIO_ANTERIOR.Name = "VALOR_UNITARIO_ANTERIOR"
            Me.VALOR_UNITARIO_ANTERIOR.ReadOnly = True
            Me.VALOR_UNITARIO_ANTERIOR.Visible = False
            '
            'VALOR_TOTAL_ANTERIOR
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.VALOR_TOTAL_ANTERIOR.DefaultCellStyle = DataGridViewCellStyle9
            Me.VALOR_TOTAL_ANTERIOR.HeaderText = "V.T. ANTERIOR"
            Me.VALOR_TOTAL_ANTERIOR.Name = "VALOR_TOTAL_ANTERIOR"
            Me.VALOR_TOTAL_ANTERIOR.ReadOnly = True
            Me.VALOR_TOTAL_ANTERIOR.Visible = False
            Me.VALOR_TOTAL_ANTERIOR.Width = 80
            '
            'SALDO
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
            Me.SALDO.DefaultCellStyle = DataGridViewCellStyle10
            Me.SALDO.HeaderText = "SALDO"
            Me.SALDO.Name = "SALDO"
            Me.SALDO.ReadOnly = True
            Me.SALDO.Visible = False
            Me.SALDO.Width = 60
            '
            'CANTIDAD_SALDO
            '
            Me.CANTIDAD_SALDO.HeaderText = "CANT. SALDO"
            Me.CANTIDAD_SALDO.Name = "CANTIDAD_SALDO"
            Me.CANTIDAD_SALDO.ReadOnly = True
            Me.CANTIDAD_SALDO.Visible = False
            Me.CANTIDAD_SALDO.Width = 80
            '
            'VALOR_UNITARIO_SALDO
            '
            Me.VALOR_UNITARIO_SALDO.HeaderText = "V.U. SALDO"
            Me.VALOR_UNITARIO_SALDO.Name = "VALOR_UNITARIO_SALDO"
            Me.VALOR_UNITARIO_SALDO.ReadOnly = True
            Me.VALOR_UNITARIO_SALDO.Visible = False
            '
            'ID_SECUENCIAL
            '
            Me.ID_SECUENCIAL.HeaderText = "ID_SECUENCIAL"
            Me.ID_SECUENCIAL.Name = "ID_SECUENCIAL"
            Me.ID_SECUENCIAL.ReadOnly = True
            Me.ID_SECUENCIAL.Visible = False
            '
            'lblValorGasto
            '
            Me.lblValorGasto.AutoSize = True
            Me.lblValorGasto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorGasto.ForeColor = System.Drawing.Color.Black
            Me.lblValorGasto.Location = New System.Drawing.Point(400, 15)
            Me.lblValorGasto.Name = "lblValorGasto"
            Me.lblValorGasto.Size = New System.Drawing.Size(45, 13)
            Me.lblValorGasto.TabIndex = 177
            Me.lblValorGasto.Text = "VALOR:"
            '
            'tsmEliminar
            '
            Me.tsmEliminar.BackColor = System.Drawing.Color.White
            Me.tsmEliminar.Enabled = False
            Me.tsmEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmEliminar.Location = New System.Drawing.Point(1203, 23)
            Me.tsmEliminar.Name = "tsmEliminar"
            Me.tsmEliminar.Size = New System.Drawing.Size(28, 28)
            Me.tsmEliminar.TabIndex = 176
            Me.tsmEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmEliminar.UseVisualStyleBackColor = False
            '
            'nudValor
            '
            Me.nudValor.BackColor = System.Drawing.Color.White
            Me.nudValor.DecimalPlaces = 2
            Me.nudValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValor.ForeColor = System.Drawing.Color.Black
            Me.nudValor.Location = New System.Drawing.Point(409, 31)
            Me.nudValor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.nudValor.Name = "nudValor"
            Me.nudValor.Size = New System.Drawing.Size(71, 21)
            Me.nudValor.TabIndex = 191
            Me.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoArticulo
            '
            Me.txtCodigoArticulo.BackColor = System.Drawing.Color.White
            Me.txtCodigoArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoArticulo.Enabled = False
            Me.txtCodigoArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(289, 31)
            Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
            Me.txtCodigoArticulo.Size = New System.Drawing.Size(73, 21)
            Me.txtCodigoArticulo.TabIndex = 175
            Me.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(276, 17)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(51, 13)
            Me.Label12.TabIndex = 176
            Me.Label12.Text = "CÓDIGO:"
            '
            'tsmAgregar
            '
            Me.tsmAgregar.BackColor = System.Drawing.Color.White
            Me.tsmAgregar.Enabled = False
            Me.tsmAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmAgregar.Location = New System.Drawing.Point(1169, 23)
            Me.tsmAgregar.Name = "tsmAgregar"
            Me.tsmAgregar.Size = New System.Drawing.Size(28, 28)
            Me.tsmAgregar.TabIndex = 175
            Me.tsmAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmAgregar.UseVisualStyleBackColor = False
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.Black
            Me.Label15.Location = New System.Drawing.Point(793, 6)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(82, 13)
            Me.Label15.TabIndex = 173
            Me.Label15.Text = "OBSERVACIÓN"
            '
            'cmbObservacionCalidad
            '
            Me.cmbObservacionCalidad.BackColor = System.Drawing.Color.White
            Me.cmbObservacionCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbObservacionCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbObservacionCalidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbObservacionCalidad.ForeColor = System.Drawing.Color.Black
            Me.cmbObservacionCalidad.FormattingEnabled = True
            Me.cmbObservacionCalidad.Items.AddRange(New Object() {"-- SELECCIONE UN ESTADO --", "NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO (DAR BAJA)"})
            Me.cmbObservacionCalidad.Location = New System.Drawing.Point(539, 32)
            Me.cmbObservacionCalidad.Name = "cmbObservacionCalidad"
            Me.cmbObservacionCalidad.Size = New System.Drawing.Size(161, 21)
            Me.cmbObservacionCalidad.TabIndex = 172
            '
            'nudCantidad
            '
            Me.nudCantidad.BackColor = System.Drawing.Color.White
            Me.nudCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidad.ForeColor = System.Drawing.Color.Black
            Me.nudCantidad.Location = New System.Drawing.Point(480, 31)
            Me.nudCantidad.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.nudCantidad.Name = "nudCantidad"
            Me.nudCantidad.Size = New System.Drawing.Size(53, 21)
            Me.nudCantidad.TabIndex = 155
            Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Me.Label17.Location = New System.Drawing.Point(477, 16)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(39, 13)
            Me.Label17.TabIndex = 161
            Me.Label17.Text = "CANT:"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.ForeColor = System.Drawing.Color.Black
            Me.txtObservacion.Location = New System.Drawing.Point(796, 23)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(248, 34)
            Me.txtObservacion.TabIndex = 156
            '
            'lblObservacionCalidad
            '
            Me.lblObservacionCalidad.AutoSize = True
            Me.lblObservacionCalidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacionCalidad.ForeColor = System.Drawing.Color.Black
            Me.lblObservacionCalidad.Location = New System.Drawing.Point(536, 14)
            Me.lblObservacionCalidad.Name = "lblObservacionCalidad"
            Me.lblObservacionCalidad.Size = New System.Drawing.Size(145, 13)
            Me.lblObservacionCalidad.TabIndex = 160
            Me.lblObservacionCalidad.Text = "OBSERVACIÓN DE CALIDAD"
            '
            'txtArticulo
            '
            Me.txtArticulo.BackColor = System.Drawing.Color.White
            Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtArticulo.Location = New System.Drawing.Point(6, 31)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(257, 21)
            Me.txtArticulo.TabIndex = 153
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.ForeColor = System.Drawing.Color.Black
            Me.lblArticulo.Location = New System.Drawing.Point(6, 16)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(62, 13)
            Me.lblArticulo.TabIndex = 158
            Me.lblArticulo.Text = "ARTÍCULO:"
            '
            'lblIdDetalleKardex
            '
            Me.lblIdDetalleKardex.AutoSize = True
            Me.lblIdDetalleKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardex.ForeColor = System.Drawing.Color.Red
            Me.lblIdDetalleKardex.Location = New System.Drawing.Point(232, 35)
            Me.lblIdDetalleKardex.Name = "lblIdDetalleKardex"
            Me.lblIdDetalleKardex.Size = New System.Drawing.Size(31, 13)
            Me.lblIdDetalleKardex.TabIndex = 166
            Me.lblIdDetalleKardex.Text = "0000"
            Me.lblIdDetalleKardex.Visible = False
            '
            'lblIdKardex
            '
            Me.lblIdKardex.AutoSize = True
            Me.lblIdKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdKardex.ForeColor = System.Drawing.Color.Red
            Me.lblIdKardex.Location = New System.Drawing.Point(184, 34)
            Me.lblIdKardex.Name = "lblIdKardex"
            Me.lblIdKardex.Size = New System.Drawing.Size(31, 13)
            Me.lblIdKardex.TabIndex = 163
            Me.lblIdKardex.Text = "0000"
            Me.lblIdKardex.Visible = False
            '
            'lblIdArticulo
            '
            Me.lblIdArticulo.AutoSize = True
            Me.lblIdArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdArticulo.ForeColor = System.Drawing.Color.Red
            Me.lblIdArticulo.Location = New System.Drawing.Point(97, 35)
            Me.lblIdArticulo.Name = "lblIdArticulo"
            Me.lblIdArticulo.Size = New System.Drawing.Size(31, 13)
            Me.lblIdArticulo.TabIndex = 162
            Me.lblIdArticulo.Text = "0000"
            Me.lblIdArticulo.Visible = False
            '
            'txtRecibe
            '
            Me.txtRecibe.BackColor = System.Drawing.Color.White
            Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecibe.Enabled = False
            Me.txtRecibe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibe.Location = New System.Drawing.Point(54, 123)
            Me.txtRecibe.Name = "txtRecibe"
            Me.txtRecibe.Size = New System.Drawing.Size(276, 22)
            Me.txtRecibe.TabIndex = 4
            Me.txtRecibe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(8, 127)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "RECIBE:"
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.White
            Me.GroupBox5.Controls.Add(Me.Label21)
            Me.GroupBox5.Controls.Add(Me.txtRegistrado)
            Me.GroupBox5.Controls.Add(Me.Label22)
            Me.GroupBox5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(278, 30)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(208, 87)
            Me.GroupBox5.TabIndex = 170
            Me.GroupBox5.TabStop = False
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(31, 58)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(110, 13)
            Me.Label21.TabIndex = 5
            Me.Label21.Text = "Gerente de Compras"
            '
            'txtRegistrado
            '
            Me.txtRegistrado.BackColor = System.Drawing.Color.White
            Me.txtRegistrado.Enabled = False
            Me.txtRegistrado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRegistrado.Location = New System.Drawing.Point(10, 35)
            Me.txtRegistrado.Name = "txtRegistrado"
            Me.txtRegistrado.Size = New System.Drawing.Size(188, 21)
            Me.txtRegistrado.TabIndex = 4
            Me.txtRegistrado.Text = "VIVAS ANASTACIO NATALIA JESSENIA"
            Me.txtRegistrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(8, 4)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(83, 13)
            Me.Label22.TabIndex = 0
            Me.Label22.Text = "Registrado por:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.chkEditar)
            Me.GroupBox1.Controls.Add(Me.txtVersion)
            Me.GroupBox1.Controls.Add(Me.txtCodigo)
            Me.GroupBox1.Controls.Add(Me.dtpFechaEmision)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(492, 30)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(336, 87)
            Me.GroupBox1.TabIndex = 169
            Me.GroupBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(8, 64)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(81, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Fecha Entrega:"
            '
            'chkEditar
            '
            Me.chkEditar.AutoSize = True
            Me.chkEditar.Location = New System.Drawing.Point(239, 38)
            Me.chkEditar.Name = "chkEditar"
            Me.chkEditar.Size = New System.Drawing.Size(63, 17)
            Me.chkEditar.TabIndex = 6
            Me.chkEditar.Text = "EDITAR"
            Me.chkEditar.UseVisualStyleBackColor = True
            '
            'txtVersion
            '
            Me.txtVersion.BackColor = System.Drawing.Color.White
            Me.txtVersion.Enabled = False
            Me.txtVersion.Location = New System.Drawing.Point(121, 36)
            Me.txtVersion.Name = "txtVersion"
            Me.txtVersion.Size = New System.Drawing.Size(112, 21)
            Me.txtVersion.TabIndex = 5
            Me.txtVersion.Text = "003"
            Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigo
            '
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Location = New System.Drawing.Point(121, 14)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(112, 21)
            Me.txtCodigo.TabIndex = 4
            Me.txtCodigo.Text = "RE-3.8.1-2"
            Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dtpFechaEmision
            '
            Me.dtpFechaEmision.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpFechaEmision.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaEmision.Location = New System.Drawing.Point(121, 59)
            Me.dtpFechaEmision.Name = "dtpFechaEmision"
            Me.dtpFechaEmision.Size = New System.Drawing.Size(209, 21)
            Me.dtpFechaEmision.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(8, 40)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(48, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Versión:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(8, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(47, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Código: "
            '
            'gbEncabezado
            '
            Me.gbEncabezado.BackColor = System.Drawing.Color.White
            Me.gbEncabezado.Controls.Add(Me.Label1)
            Me.gbEncabezado.Location = New System.Drawing.Point(90, 30)
            Me.gbEncabezado.Name = "gbEncabezado"
            Me.gbEncabezado.Size = New System.Drawing.Size(182, 87)
            Me.gbEncabezado.TabIndex = 168
            Me.gbEncabezado.TabStop = False
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(6, 11)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(170, 65)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "ENTREGA UNIFORMES / DESCUENTO BODEGA"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pbImagen
            '
            Me.pbImagen.BackColor = System.Drawing.Color.White
            Me.pbImagen.Image = CType(resources.GetObject("pbImagen.Image"), System.Drawing.Image)
            Me.pbImagen.Location = New System.Drawing.Point(3, 36)
            Me.pbImagen.Name = "pbImagen"
            Me.pbImagen.Size = New System.Drawing.Size(84, 79)
            Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbImagen.TabIndex = 167
            Me.pbImagen.TabStop = False
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.White
            Me.Label10.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(834, 36)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(418, 81)
            Me.Label10.TabIndex = 179
            Me.Label10.Text = resources.GetString("Label10.Text")
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tpConsultar
            '
            Me.tpConsultar.BackColor = System.Drawing.Color.White
            Me.tpConsultar.Controls.Add(Me.gbNumeroFactura)
            Me.tpConsultar.Controls.Add(Me.gbComprobante)
            Me.tpConsultar.Controls.Add(Me.gbDetalleComprobante)
            Me.tpConsultar.Controls.Add(Me.gbRangoFechas)
            Me.tpConsultar.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultar.Name = "tpConsultar"
            Me.tpConsultar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultar.Size = New System.Drawing.Size(1259, 585)
            Me.tpConsultar.TabIndex = 1
            Me.tpConsultar.Text = "CONSULTAR"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.White
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(1152, 4)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(27, 27)
            Me.btnExportarComprobantes.TabIndex = 154
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.chkTodos)
            Me.gbNumeroFactura.Controls.Add(Me.rbtDet)
            Me.gbNumeroFactura.Controls.Add(Me.rbtNum)
            Me.gbNumeroFactura.Controls.Add(Me.txtDetail)
            Me.gbNumeroFactura.Controls.Add(Me.Button1)
            Me.gbNumeroFactura.Controls.Add(Me.txtNroComprobante)
            Me.gbNumeroFactura.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroFactura.Location = New System.Drawing.Point(467, 6)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(789, 47)
            Me.gbNumeroFactura.TabIndex = 154
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "OPCIONES DE BUSQUEDA"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Checked = True
            Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkTodos.Location = New System.Drawing.Point(196, 0)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(57, 17)
            Me.chkTodos.TabIndex = 8
            Me.chkTodos.Text = "Todos"
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'rbtDet
            '
            Me.rbtDet.AutoSize = True
            Me.rbtDet.Enabled = False
            Me.rbtDet.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtDet.Location = New System.Drawing.Point(212, 19)
            Me.rbtDet.Name = "rbtDet"
            Me.rbtDet.Size = New System.Drawing.Size(63, 17)
            Me.rbtDet.TabIndex = 7
            Me.rbtDet.TabStop = True
            Me.rbtDet.Text = "Detalle:"
            Me.rbtDet.UseVisualStyleBackColor = True
            '
            'rbtNum
            '
            Me.rbtNum.AutoSize = True
            Me.rbtNum.Enabled = False
            Me.rbtNum.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtNum.Location = New System.Drawing.Point(6, 19)
            Me.rbtNum.Name = "rbtNum"
            Me.rbtNum.Size = New System.Drawing.Size(72, 17)
            Me.rbtNum.TabIndex = 6
            Me.rbtNum.TabStop = True
            Me.rbtNum.Text = "N° Comp:"
            Me.rbtNum.UseVisualStyleBackColor = True
            '
            'txtDetail
            '
            Me.txtDetail.BackColor = System.Drawing.Color.White
            Me.txtDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetail.Enabled = False
            Me.txtDetail.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetail.Location = New System.Drawing.Point(278, 18)
            Me.txtDetail.Name = "txtDetail"
            Me.txtDetail.Size = New System.Drawing.Size(401, 21)
            Me.txtDetail.TabIndex = 5
            Me.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.White
            Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.Button1.Location = New System.Drawing.Point(688, 13)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(28, 28)
            Me.Button1.TabIndex = 0
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'txtNroComprobante
            '
            Me.txtNroComprobante.BackColor = System.Drawing.Color.White
            Me.txtNroComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroComprobante.Enabled = False
            Me.txtNroComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobante.Location = New System.Drawing.Point(82, 18)
            Me.txtNroComprobante.Name = "txtNroComprobante"
            Me.txtNroComprobante.Size = New System.Drawing.Size(105, 21)
            Me.txtNroComprobante.TabIndex = 0
            Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Controls.Add(Me.btnExportarComprobantes)
            Me.gbComprobante.Controls.Add(Me.dgvComprobantesIngreso)
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(3, 59)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1253, 217)
            Me.gbComprobante.TabIndex = 151
            Me.gbComprobante.TabStop = False
            Me.gbComprobante.Text = "COMPROBANTE"
            '
            'dgvComprobantesIngreso
            '
            Me.dgvComprobantesIngreso.AllowUserToAddRows = False
            Me.dgvComprobantesIngreso.AllowUserToDeleteRows = False
            Me.dgvComprobantesIngreso.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesIngreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvComprobantesIngreso.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvComprobantesIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvComprobantesIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesIngreso.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobantesIngreso.GridColor = System.Drawing.Color.Black
            Me.dgvComprobantesIngreso.Location = New System.Drawing.Point(3, 32)
            Me.dgvComprobantesIngreso.MultiSelect = False
            Me.dgvComprobantesIngreso.Name = "dgvComprobantesIngreso"
            Me.dgvComprobantesIngreso.ReadOnly = True
            Me.dgvComprobantesIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesIngreso.RowHeadersVisible = False
            Me.dgvComprobantesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesIngreso.Size = New System.Drawing.Size(1247, 180)
            Me.dgvComprobantesIngreso.TabIndex = 145
            '
            'gbDetalleComprobante
            '
            Me.gbDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.gbDetalleComprobante.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.gbDetalleComprobante.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbDetalleComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleComprobante.Location = New System.Drawing.Point(6, 282)
            Me.gbDetalleComprobante.Name = "gbDetalleComprobante"
            Me.gbDetalleComprobante.Size = New System.Drawing.Size(1250, 300)
            Me.gbDetalleComprobante.TabIndex = 150
            Me.gbDetalleComprobante.TabStop = False
            Me.gbDetalleComprobante.Text = "DETALLE"
            '
            'btnExportarDetalleComprobante
            '
            Me.btnExportarDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.btnExportarDetalleComprobante.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarDetalleComprobante.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(1149, 5)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(27, 27)
            Me.btnExportarDetalleComprobante.TabIndex = 155
            Me.btnExportarDetalleComprobante.UseVisualStyleBackColor = False
            '
            'dgvDetalleComprobate
            '
            Me.dgvDetalleComprobate.AllowUserToAddRows = False
            Me.dgvDetalleComprobate.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobate.AllowUserToResizeRows = False
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvDetalleComprobate.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvDetalleComprobate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvDetalleComprobate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobate.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvDetalleComprobate.GridColor = System.Drawing.Color.Black
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(2, 32)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(1246, 265)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label14)
            Me.gbRangoFechas.Controls.Add(Me.Label23)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(3, 5)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(458, 48)
            Me.gbRangoFechas.TabIndex = 146
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(12, 23)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(23, 13)
            Me.Label14.TabIndex = 7
            Me.Label14.Text = "De:"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(233, 23)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(13, 13)
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(251, 20)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaHasta.TabIndex = 5
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(46, 20)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaDesde.TabIndex = 4
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.TabControl1)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1259, 585)
            Me.tpReporte.TabIndex = 2
            Me.tpReporte.Text = "REPORTE"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(2, 2)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(1257, 583)
            Me.TabControl1.TabIndex = 154
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.bntCargar)
            Me.TabPage1.Controls.Add(Me.Label30)
            Me.TabPage1.Controls.Add(Me.txtIdEntrega)
            Me.TabPage1.Controls.Add(Me.crvComprobante)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1249, 557)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Comprobante"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'bntCargar
            '
            Me.bntCargar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntCargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.bntCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntCargar.Location = New System.Drawing.Point(1160, 6)
            Me.bntCargar.Name = "bntCargar"
            Me.bntCargar.Size = New System.Drawing.Size(83, 23)
            Me.bntCargar.TabIndex = 9
            Me.bntCargar.Text = "CARGAR"
            Me.bntCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntCargar.UseVisualStyleBackColor = True
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(979, 11)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(80, 13)
            Me.Label30.TabIndex = 5
            Me.Label30.Text = "COMPROBANTE:"
            '
            'txtIdEntrega
            '
            Me.txtIdEntrega.Location = New System.Drawing.Point(1065, 8)
            Me.txtIdEntrega.Name = "txtIdEntrega"
            Me.txtIdEntrega.Size = New System.Drawing.Size(95, 21)
            Me.txtIdEntrega.TabIndex = 6
            Me.txtIdEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'crvComprobante
            '
            Me.crvComprobante.ActiveViewIndex = -1
            Me.crvComprobante.AutoSize = True
            Me.crvComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobante.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobante.ForeColor = System.Drawing.SystemColors.ControlText
            Me.crvComprobante.Location = New System.Drawing.Point(3, 6)
            Me.crvComprobante.Name = "crvComprobante"
            Me.crvComprobante.Size = New System.Drawing.Size(1240, 548)
            Me.crvComprobante.TabIndex = 152
            Me.crvComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1249, 557)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Imagen Adjunta"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(1243, 551)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 1
            Me.PictureBox1.TabStop = False
            '
            'miniToolStrip
            '
            Me.miniToolStrip.AutoSize = False
            Me.miniToolStrip.BackColor = System.Drawing.SystemColors.Window
            Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
            Me.miniToolStrip.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.miniToolStrip.Location = New System.Drawing.Point(7, 22)
            Me.miniToolStrip.Name = "miniToolStrip"
            Me.miniToolStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.miniToolStrip.Size = New System.Drawing.Size(320, 24)
            Me.miniToolStrip.TabIndex = 148
            '
            'FormEntregaUniformes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1270, 616)
            Me.Controls.Add(Me.tbComprobanteIngresoBodega)
            Me.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormEntregaUniformes"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ENTREGA DE UNIFORMES"
            Me.tbComprobanteIngresoBodega.ResumeLayout(False)
            Me.tpRegistro.ResumeLayout(False)
            Me.tpRegistro.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.gbBusquedaArticulo.ResumeLayout(False)
            Me.gbBusquedaArticulo.PerformLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbEncabezado.ResumeLayout(False)
            CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultar.ResumeLayout(False)
            Me.gbNumeroFactura.ResumeLayout(False)
            Me.gbNumeroFactura.PerformLayout()
            Me.gbComprobante.ResumeLayout(False)
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDetalleComprobante.ResumeLayout(False)
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tbComprobanteIngresoBodega As System.Windows.Forms.TabControl
        Friend WithEvents tpRegistro As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtAprobado As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtRevisado As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
        Friend WithEvents lblCargoRealizado As System.Windows.Forms.Label
        Friend WithEvents txtRealizado As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents gbBusquedaArticulo As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdDetalleKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdArticulo As System.Windows.Forms.Label
        Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents lblObservacionCalidad As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents lblValorGasto As System.Windows.Forms.Label
        Friend WithEvents dtpIngreso As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtRegistrado As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents chkEditar As System.Windows.Forms.CheckBox
        Friend WithEvents txtVersion As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents gbEncabezado As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoArticulo As System.Windows.Forms.TextBox
        Friend WithEvents tpConsultar As System.Windows.Forms.TabPage
        Friend WithEvents gbComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobantesIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents gbDetalleComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents txtIdEntrega As System.Windows.Forms.TextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtObservacionEntrega As System.Windows.Forms.TextBox
        Friend WithEvents miniToolStrip As System.Windows.Forms.MenuStrip
        Friend WithEvents cmbObservacionCalidad As System.Windows.Forms.ComboBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents bntCargar As System.Windows.Forms.Button
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents rbtDet As System.Windows.Forms.RadioButton
        Friend WithEvents rbtNum As System.Windows.Forms.RadioButton
        Friend WithEvents txtDetail As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents btnExportarDetalleComprobante As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmEliminar As System.Windows.Forms.Button
        Friend WithEvents tsmAgregar As System.Windows.Forms.Button
        Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
        Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents OBSERVACION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLES As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NUMERO_KARDEX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE_KARDEX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_UNITARIO_ANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_TOTAL_ANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_UNITARIO_SALDO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_SECUENCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents nudTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblTotalUniformes As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents dtpRolPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents btnSerie As System.Windows.Forms.Button
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace