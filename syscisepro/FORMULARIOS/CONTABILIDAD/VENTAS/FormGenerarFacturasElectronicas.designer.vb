Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormGenerarFacturasElectronicas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenerarFacturasElectronicas))
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.lblEstadoXML = New System.Windows.Forms.Label()
            Me.dgvCliente = New System.Windows.Forms.DataGridView()
            Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
            Me.dgvDetalleFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.gbTipoEmision = New System.Windows.Forms.GroupBox()
            Me.rbTipoEmisionIndisponibilidadSistema = New System.Windows.Forms.RadioButton()
            Me.rbTipoEmisionNormal = New System.Windows.Forms.RadioButton()
            Me.gbTipoAnbiente = New System.Windows.Forms.GroupBox()
            Me.rbProduccion = New System.Windows.Forms.RadioButton()
            Me.rbPruebas = New System.Windows.Forms.RadioButton()
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.chkNumeroFactura = New System.Windows.Forms.CheckBox()
            Me.txtNumeroFacturaBuscar = New System.Windows.Forms.TextBox()
            Me.txtAsunto = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.gbEnvioCorreo = New System.Windows.Forms.GroupBox()
            Me.txtMensaje = New System.Windows.Forms.TextBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.lblIdFacturaVenta = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.chkClienteGeneral = New System.Windows.Forms.CheckBox()
            Me.txtClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.tamaño = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCargarXML = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSinFirmar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarFirmado = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnEnviar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipoEmision.SuspendLayout()
            Me.gbTipoAnbiente.SuspendLayout()
            Me.gbNumeroFactura.SuspendLayout()
            Me.gbEnvioCorreo.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbClienteGeneral.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            Me.dgvFacturaVenta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.White
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(2, 88)
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            Me.dgvFacturaVenta.ReadOnly = True
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(967, 529)
            Me.dgvFacturaVenta.TabIndex = 52
            '
            'lblEstadoXML
            '
            Me.lblEstadoXML.AutoSize = True
            Me.lblEstadoXML.Location = New System.Drawing.Point(161, 0)
            Me.lblEstadoXML.Name = "lblEstadoXML"
            Me.lblEstadoXML.Size = New System.Drawing.Size(25, 13)
            Me.lblEstadoXML.TabIndex = 91
            Me.lblEstadoXML.Text = "..."
            '
            'dgvCliente
            '
            Me.dgvCliente.AllowUserToAddRows = False
            Me.dgvCliente.AllowUserToDeleteRows = False
            Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvCliente.Location = New System.Drawing.Point(248, 39)
            Me.dgvCliente.Name = "dgvCliente"
            Me.dgvCliente.ReadOnly = True
            Me.dgvCliente.Size = New System.Drawing.Size(240, 46)
            Me.dgvCliente.TabIndex = 54
            '
            'dgvEmpresa
            '
            Me.dgvEmpresa.AllowUserToAddRows = False
            Me.dgvEmpresa.AllowUserToDeleteRows = False
            Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEmpresa.Location = New System.Drawing.Point(2, 41)
            Me.dgvEmpresa.Name = "dgvEmpresa"
            Me.dgvEmpresa.ReadOnly = True
            Me.dgvEmpresa.Size = New System.Drawing.Size(240, 46)
            Me.dgvEmpresa.TabIndex = 55
            '
            'dgvDetalleFacturaVenta
            '
            Me.dgvDetalleFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleFacturaVenta.Location = New System.Drawing.Point(495, 46)
            Me.dgvDetalleFacturaVenta.Name = "dgvDetalleFacturaVenta"
            Me.dgvDetalleFacturaVenta.Size = New System.Drawing.Size(240, 46)
            Me.dgvDetalleFacturaVenta.TabIndex = 56
            '
            'gbTipoEmision
            '
            Me.gbTipoEmision.BackColor = System.Drawing.Color.White
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionIndisponibilidadSistema)
            Me.gbTipoEmision.Controls.Add(Me.rbTipoEmisionNormal)
            Me.gbTipoEmision.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoEmision.Location = New System.Drawing.Point(96, 27)
            Me.gbTipoEmision.Name = "gbTipoEmision"
            Me.gbTipoEmision.Size = New System.Drawing.Size(121, 61)
            Me.gbTipoEmision.TabIndex = 88
            Me.gbTipoEmision.TabStop = False
            Me.gbTipoEmision.Text = "TIPO EMISION:"
            '
            'rbTipoEmisionIndisponibilidadSistema
            '
            Me.rbTipoEmisionIndisponibilidadSistema.AutoSize = True
            Me.rbTipoEmisionIndisponibilidadSistema.Location = New System.Drawing.Point(6, 31)
            Me.rbTipoEmisionIndisponibilidadSistema.Name = "rbTipoEmisionIndisponibilidadSistema"
            Me.rbTipoEmisionIndisponibilidadSistema.Size = New System.Drawing.Size(109, 17)
            Me.rbTipoEmisionIndisponibilidadSistema.TabIndex = 22
            Me.rbTipoEmisionIndisponibilidadSistema.Text = "INDISP SISTEMA"
            Me.rbTipoEmisionIndisponibilidadSistema.UseVisualStyleBackColor = True
            '
            'rbTipoEmisionNormal
            '
            Me.rbTipoEmisionNormal.AutoSize = True
            Me.rbTipoEmisionNormal.Checked = True
            Me.rbTipoEmisionNormal.Location = New System.Drawing.Point(6, 14)
            Me.rbTipoEmisionNormal.Name = "rbTipoEmisionNormal"
            Me.rbTipoEmisionNormal.Size = New System.Drawing.Size(61, 17)
            Me.rbTipoEmisionNormal.TabIndex = 21
            Me.rbTipoEmisionNormal.TabStop = True
            Me.rbTipoEmisionNormal.Text = "NORMAL"
            Me.rbTipoEmisionNormal.UseVisualStyleBackColor = True
            '
            'gbTipoAnbiente
            '
            Me.gbTipoAnbiente.BackColor = System.Drawing.Color.White
            Me.gbTipoAnbiente.Controls.Add(Me.rbProduccion)
            Me.gbTipoAnbiente.Controls.Add(Me.rbPruebas)
            Me.gbTipoAnbiente.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoAnbiente.Location = New System.Drawing.Point(2, 27)
            Me.gbTipoAnbiente.Name = "gbTipoAnbiente"
            Me.gbTipoAnbiente.Size = New System.Drawing.Size(94, 61)
            Me.gbTipoAnbiente.TabIndex = 89
            Me.gbTipoAnbiente.TabStop = False
            Me.gbTipoAnbiente.Text = "AMBIENTE:"
            '
            'rbProduccion
            '
            Me.rbProduccion.AutoSize = True
            Me.rbProduccion.Checked = True
            Me.rbProduccion.Location = New System.Drawing.Point(6, 31)
            Me.rbProduccion.Name = "rbProduccion"
            Me.rbProduccion.Size = New System.Drawing.Size(85, 17)
            Me.rbProduccion.TabIndex = 1
            Me.rbProduccion.TabStop = True
            Me.rbProduccion.Text = "PRODUCCIÓN"
            Me.rbProduccion.UseVisualStyleBackColor = True
            '
            'rbPruebas
            '
            Me.rbPruebas.AutoSize = True
            Me.rbPruebas.Location = New System.Drawing.Point(6, 14)
            Me.rbPruebas.Name = "rbPruebas"
            Me.rbPruebas.Size = New System.Drawing.Size(67, 17)
            Me.rbPruebas.TabIndex = 0
            Me.rbPruebas.Text = "PRUEBAS"
            Me.rbPruebas.UseVisualStyleBackColor = True
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.chkNumeroFactura)
            Me.gbNumeroFactura.Controls.Add(Me.txtNumeroFacturaBuscar)
            Me.gbNumeroFactura.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroFactura.Location = New System.Drawing.Point(848, 27)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(122, 61)
            Me.gbNumeroFactura.TabIndex = 90
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "NUMERO FACTURA:"
            '
            'chkNumeroFactura
            '
            Me.chkNumeroFactura.AutoSize = True
            Me.chkNumeroFactura.Location = New System.Drawing.Point(99, 0)
            Me.chkNumeroFactura.Name = "chkNumeroFactura"
            Me.chkNumeroFactura.Size = New System.Drawing.Size(15, 14)
            Me.chkNumeroFactura.TabIndex = 34
            Me.chkNumeroFactura.UseVisualStyleBackColor = True
            '
            'txtNumeroFacturaBuscar
            '
            Me.txtNumeroFacturaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroFacturaBuscar.Location = New System.Drawing.Point(6, 24)
            Me.txtNumeroFacturaBuscar.Name = "txtNumeroFacturaBuscar"
            Me.txtNumeroFacturaBuscar.Size = New System.Drawing.Size(105, 20)
            Me.txtNumeroFacturaBuscar.TabIndex = 1
            Me.txtNumeroFacturaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAsunto
            '
            Me.txtAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtAsunto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAsunto.Location = New System.Drawing.Point(9, 33)
            Me.txtAsunto.Name = "txtAsunto"
            Me.txtAsunto.Size = New System.Drawing.Size(340, 23)
            Me.txtAsunto.TabIndex = 10
            Me.txtAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Asunto :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 59)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(61, 13)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "Mensaje :"
            '
            'gbEnvioCorreo
            '
            Me.gbEnvioCorreo.BackColor = System.Drawing.Color.White
            Me.gbEnvioCorreo.Controls.Add(Me.lblEstadoXML)
            Me.gbEnvioCorreo.Controls.Add(Me.Label6)
            Me.gbEnvioCorreo.Controls.Add(Me.txtMensaje)
            Me.gbEnvioCorreo.Controls.Add(Me.Label5)
            Me.gbEnvioCorreo.Controls.Add(Me.txtAsunto)
            Me.gbEnvioCorreo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEnvioCorreo.Location = New System.Drawing.Point(970, 26)
            Me.gbEnvioCorreo.Name = "gbEnvioCorreo"
            Me.gbEnvioCorreo.Size = New System.Drawing.Size(355, 274)
            Me.gbEnvioCorreo.TabIndex = 91
            Me.gbEnvioCorreo.TabStop = False
            Me.gbEnvioCorreo.Text = "Correo"
            '
            'txtMensaje
            '
            Me.txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtMensaje.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMensaje.Location = New System.Drawing.Point(9, 75)
            Me.txtMensaje.Multiline = True
            Me.txtMensaje.Name = "txtMensaje"
            Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtMensaje.Size = New System.Drawing.Size(340, 193)
            Me.txtMensaje.TabIndex = 12
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.lblIdFacturaVenta)
            Me.gbRangoFechas.Controls.Add(Me.Label2)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(624, 27)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(224, 61)
            Me.gbRangoFechas.TabIndex = 92
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'lblIdFacturaVenta
            '
            Me.lblIdFacturaVenta.AutoSize = True
            Me.lblIdFacturaVenta.Location = New System.Drawing.Point(191, 1)
            Me.lblIdFacturaVenta.Name = "lblIdFacturaVenta"
            Me.lblIdFacturaVenta.Size = New System.Drawing.Size(25, 13)
            Me.lblIdFacturaVenta.TabIndex = 4
            Me.lblIdFacturaVenta.Text = "..."
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(104, 28)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(118, 24)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(6, 24)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(98, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.BackColor = System.Drawing.Color.White
            Me.gbClienteGeneral.Controls.Add(Me.chkClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.txtClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(217, 27)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(407, 61)
            Me.gbClienteGeneral.TabIndex = 93
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTES"
            '
            'chkClienteGeneral
            '
            Me.chkClienteGeneral.AutoSize = True
            Me.chkClienteGeneral.Location = New System.Drawing.Point(341, 1)
            Me.chkClienteGeneral.Name = "chkClienteGeneral"
            Me.chkClienteGeneral.Size = New System.Drawing.Size(56, 17)
            Me.chkClienteGeneral.TabIndex = 32
            Me.chkClienteGeneral.Text = "TODOS"
            Me.chkClienteGeneral.UseVisualStyleBackColor = True
            '
            'txtClienteGeneral
            '
            Me.txtClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteGeneral.Location = New System.Drawing.Point(6, 23)
            Me.txtClienteGeneral.Name = "txtClienteGeneral"
            Me.txtClienteGeneral.Size = New System.Drawing.Size(395, 20)
            Me.txtClienteGeneral.TabIndex = 31
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(66, 1)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteGeneral.TabIndex = 30
            Me.lblIdClienteGeneral.Text = "0"
            '
            'ListView1
            '
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombre, Me.tamaño, Me.fecha})
            Me.ListView1.Location = New System.Drawing.Point(970, 300)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(355, 317)
            Me.ListView1.TabIndex = 94
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'nombre
            '
            Me.nombre.Text = "Nombre"
            Me.nombre.Width = 206
            '
            'tamaño
            '
            Me.tamaño.Text = "Tamaño"
            '
            'fecha
            '
            Me.fecha.Text = "Fecha"
            Me.fecha.Width = 85
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnCargarXML, Me.btnGuardarSinFirmar, Me.btnGuardarFirmado, Me.btnEnviar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1325, 24)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(79, 20)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnCargarXML
            '
            Me.btnCargarXML.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarXML.Image = Global.syscisepro.My.Resources.Resources.generate_tables_icon
            Me.btnCargarXML.Name = "btnCargarXML"
            Me.btnCargarXML.Size = New System.Drawing.Size(134, 20)
            Me.btnCargarXML.Text = "CARGAR FACTURAS"
            '
            'btnGuardarSinFirmar
            '
            Me.btnGuardarSinFirmar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSinFirmar.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnGuardarSinFirmar.Name = "btnGuardarSinFirmar"
            Me.btnGuardarSinFirmar.Size = New System.Drawing.Size(108, 20)
            Me.btnGuardarSinFirmar.Text = "GENERAR XML"
            '
            'btnGuardarFirmado
            '
            Me.btnGuardarFirmado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarFirmado.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnGuardarFirmado.Name = "btnGuardarFirmado"
            Me.btnGuardarFirmado.Size = New System.Drawing.Size(99, 20)
            Me.btnGuardarFirmado.Text = "FIRMAR XML"
            '
            'btnEnviar
            '
            Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnviar.Image = Global.syscisepro.My.Resources.Resources.select_column_icon
            Me.btnEnviar.Name = "btnEnviar"
            Me.btnEnviar.Size = New System.Drawing.Size(97, 20)
            Me.btnEnviar.Text = "ENVIAR XML"
            '
            'FormGenerarFacturasElectronicas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1325, 618)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.ListView1)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbEnvioCorreo)
            Me.Controls.Add(Me.gbNumeroFactura)
            Me.Controls.Add(Me.gbTipoEmision)
            Me.Controls.Add(Me.gbTipoAnbiente)
            Me.Controls.Add(Me.dgvEmpresa)
            Me.Controls.Add(Me.dgvCliente)
            Me.Controls.Add(Me.dgvFacturaVenta)
            Me.Controls.Add(Me.dgvDetalleFacturaVenta)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormGenerarFacturasElectronicas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GENERAR FACTURA ELECTRÓNICA"
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipoEmision.ResumeLayout(False)
            Me.gbTipoEmision.PerformLayout()
            Me.gbTipoAnbiente.ResumeLayout(False)
            Me.gbTipoAnbiente.PerformLayout()
            Me.gbNumeroFactura.ResumeLayout(False)
            Me.gbNumeroFactura.PerformLayout()
            Me.gbEnvioCorreo.ResumeLayout(False)
            Me.gbEnvioCorreo.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
        Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents gbTipoEmision As System.Windows.Forms.GroupBox
        Friend WithEvents rbTipoEmisionIndisponibilidadSistema As System.Windows.Forms.RadioButton
        Friend WithEvents rbTipoEmisionNormal As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoAnbiente As System.Windows.Forms.GroupBox
        Friend WithEvents rbProduccion As System.Windows.Forms.RadioButton
        Friend WithEvents rbPruebas As System.Windows.Forms.RadioButton
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents lblEstadoXML As System.Windows.Forms.Label
        Friend WithEvents txtNumeroFacturaBuscar As System.Windows.Forms.TextBox
        Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents gbEnvioCorreo As System.Windows.Forms.GroupBox
        Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdFacturaVenta As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents chkClienteGeneral As System.Windows.Forms.CheckBox
        Friend WithEvents txtClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents chkNumeroFactura As System.Windows.Forms.CheckBox
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
        Friend WithEvents tamaño As System.Windows.Forms.ColumnHeader
        Friend WithEvents fecha As System.Windows.Forms.ColumnHeader
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCargarXML As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSinFirmar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarFirmado As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnEnviar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace