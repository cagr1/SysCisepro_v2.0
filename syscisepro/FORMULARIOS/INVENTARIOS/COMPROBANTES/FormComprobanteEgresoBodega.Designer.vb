Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormComprobanteEgresoBodega
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteEgresoBodega))
            Me.tbComprobanteIngresoBodega = New System.Windows.Forms.TabControl()
            Me.tpRegistro = New System.Windows.Forms.TabPage()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.lblRecibe = New System.Windows.Forms.Label()
            Me.gbBusquedaArticulo = New System.Windows.Forms.GroupBox()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.btnSerie = New System.Windows.Forms.Button()
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.nudTotal = New System.Windows.Forms.NumericUpDown()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.nudValor = New System.Windows.Forms.NumericUpDown()
            Me.tsmEliminar = New System.Windows.Forms.Button()
            Me.tsmAgregar = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cmbObservacionCalidad = New System.Windows.Forms.ComboBox()
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
            Me.lblOpcion = New System.Windows.Forms.Label()
            Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.lblObservacionCalidad = New System.Windows.Forms.Label()
            Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblArticulo = New System.Windows.Forms.Label()
            Me.lblIdDetalleKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex = New System.Windows.Forms.Label()
            Me.lblIdArticulo = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.lblBodega = New System.Windows.Forms.Label()
            Me.txtProveedores = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblRazon = New System.Windows.Forms.Label()
            Me.cmbBodega = New System.Windows.Forms.ComboBox()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cmbConceptos = New System.Windows.Forms.ComboBox()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.cbmEgreso = New System.Windows.Forms.ComboBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.cmbDocumento = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblProveedor = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tpConsultar = New System.Windows.Forms.TabPage()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.dgvComprobantesEgreso = New System.Windows.Forms.DataGridView()
            Me.gbDetalleComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarDetalleComprobante = New System.Windows.Forms.Button()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.txtDetail = New System.Windows.Forms.TextBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtNroComprobante = New System.Windows.Forms.TextBox()
            Me.rbtNum = New System.Windows.Forms.RadioButton()
            Me.rbtDet = New System.Windows.Forms.RadioButton()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtIdComprobante = New System.Windows.Forms.TextBox()
            Me.crvComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmActualizar = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblIdKardex2 = New System.Windows.Forms.Label()
            Me.lblDetaComp = New System.Windows.Forms.Label()
            Me.lblDetKardex = New System.Windows.Forms.Label()
            Me.lblComp = New System.Windows.Forms.Label()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.lblCantidadSaldo = New System.Windows.Forms.Label()
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            Me.tpRegistro.SuspendLayout()
            Me.gbBusquedaArticulo.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultar.SuspendLayout()
            Me.gbComprobante.SuspendLayout()
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDetalleComprobante.SuspendLayout()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNumeroFactura.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tbComprobanteIngresoBodega
            '
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpRegistro)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpConsultar)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpReporte)
            Me.tbComprobanteIngresoBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbComprobanteIngresoBodega.Location = New System.Drawing.Point(2, 34)
            Me.tbComprobanteIngresoBodega.Name = "tbComprobanteIngresoBodega"
            Me.tbComprobanteIngresoBodega.SelectedIndex = 0
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(1268, 582)
            Me.tbComprobanteIngresoBodega.TabIndex = 1
            '
            'tpRegistro
            '
            Me.tpRegistro.BackColor = System.Drawing.Color.White
            Me.tpRegistro.Controls.Add(Me.txtRazon)
            Me.tpRegistro.Controls.Add(Me.bntPuesto)
            Me.tpRegistro.Controls.Add(Me.txtUbicacion)
            Me.tpRegistro.Controls.Add(Me.txtRecibe)
            Me.tpRegistro.Controls.Add(Me.cbmProvincia)
            Me.tpRegistro.Controls.Add(Me.lblRecibe)
            Me.tpRegistro.Controls.Add(Me.gbBusquedaArticulo)
            Me.tpRegistro.Controls.Add(Me.Label2)
            Me.tpRegistro.Controls.Add(Me.txtNumero)
            Me.tpRegistro.Controls.Add(Me.lblBodega)
            Me.tpRegistro.Controls.Add(Me.txtProveedores)
            Me.tpRegistro.Controls.Add(Me.Label8)
            Me.tpRegistro.Controls.Add(Me.lblRazon)
            Me.tpRegistro.Controls.Add(Me.cmbBodega)
            Me.tpRegistro.Controls.Add(Me.lblProvincia)
            Me.tpRegistro.Controls.Add(Me.txtCódigo)
            Me.tpRegistro.Controls.Add(Me.cbmCanton)
            Me.tpRegistro.Controls.Add(Me.lblCiudad)
            Me.tpRegistro.Controls.Add(Me.cbmParroquia)
            Me.tpRegistro.Controls.Add(Me.cmbConceptos)
            Me.tpRegistro.Controls.Add(Me.lblConcepto)
            Me.tpRegistro.Controls.Add(Me.cbmCentroCosto)
            Me.tpRegistro.Controls.Add(Me.lblParroquia)
            Me.tpRegistro.Controls.Add(Me.cbmEgreso)
            Me.tpRegistro.Controls.Add(Me.lblCentroCosto)
            Me.tpRegistro.Controls.Add(Me.Label1)
            Me.tpRegistro.Controls.Add(Me.lblActividad)
            Me.tpRegistro.Controls.Add(Me.dtpFecha)
            Me.tpRegistro.Controls.Add(Me.txtNombre)
            Me.tpRegistro.Controls.Add(Me.txtCedula)
            Me.tpRegistro.Controls.Add(Me.Label6)
            Me.tpRegistro.Controls.Add(Me.Label4)
            Me.tpRegistro.Controls.Add(Me.txtNroDocumento)
            Me.tpRegistro.Controls.Add(Me.cmbDocumento)
            Me.tpRegistro.Controls.Add(Me.Label5)
            Me.tpRegistro.Controls.Add(Me.lblProveedor)
            Me.tpRegistro.Controls.Add(Me.Label10)
            Me.tpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tpRegistro.Name = "tpRegistro"
            Me.tpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegistro.Size = New System.Drawing.Size(1260, 556)
            Me.tpRegistro.TabIndex = 0
            Me.tpRegistro.Text = "REGISTRO"
            '
            'txtRazon
            '
            Me.txtRazon.BackColor = System.Drawing.Color.White
            Me.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazon.Enabled = False
            Me.txtRazon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazon.ForeColor = System.Drawing.Color.Black
            Me.txtRazon.Location = New System.Drawing.Point(1019, 132)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.Size = New System.Drawing.Size(230, 75)
            Me.txtRazon.TabIndex = 11
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.White
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.bntPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntPuesto.Location = New System.Drawing.Point(970, 171)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(28, 28)
            Me.bntPuesto.TabIndex = 195
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'txtUbicacion
            '
            Me.txtUbicacion.BackColor = System.Drawing.Color.White
            Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacion.Enabled = False
            Me.txtUbicacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacion.ForeColor = System.Drawing.Color.Black
            Me.txtUbicacion.Location = New System.Drawing.Point(439, 164)
            Me.txtUbicacion.Multiline = True
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(525, 43)
            Me.txtUbicacion.TabIndex = 67
            '
            'txtRecibe
            '
            Me.txtRecibe.BackColor = System.Drawing.Color.White
            Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecibe.Enabled = False
            Me.txtRecibe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtRecibe.Location = New System.Drawing.Point(6, 171)
            Me.txtRecibe.Name = "txtRecibe"
            Me.txtRecibe.Size = New System.Drawing.Size(390, 21)
            Me.txtRecibe.TabIndex = 15
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.ForeColor = System.Drawing.Color.Black
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(439, 27)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(258, 21)
            Me.cbmProvincia.TabIndex = 152
            '
            'lblRecibe
            '
            Me.lblRecibe.AutoSize = True
            Me.lblRecibe.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRecibe.Location = New System.Drawing.Point(9, 154)
            Me.lblRecibe.Name = "lblRecibe"
            Me.lblRecibe.Size = New System.Drawing.Size(46, 13)
            Me.lblRecibe.TabIndex = 64
            Me.lblRecibe.Text = "RECIBE:"
            '
            'gbBusquedaArticulo
            '
            Me.gbBusquedaArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.gbBusquedaArticulo.Controls.Add(Me.pbFoto)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label27)
            Me.gbBusquedaArticulo.Controls.Add(Me.btnSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label16)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label15)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudTotal)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label7)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudValor)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmEliminar)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmAgregar)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtObservacion)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label9)
            Me.gbBusquedaArticulo.Controls.Add(Me.cmbObservacionCalidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.dgvSecuencial)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblOpcion)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudCantidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label17)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblObservacionCalidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtCodigoArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label12)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdDetalleKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdArticulo)
            Me.gbBusquedaArticulo.Enabled = False
            Me.gbBusquedaArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(2, 202)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(1254, 357)
            Me.gbBusquedaArticulo.TabIndex = 148
            Me.gbBusquedaArticulo.TabStop = False
            Me.gbBusquedaArticulo.Text = "DETALLE DEL COMPROBANTE DE EGRESO"
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Location = New System.Drawing.Point(1050, 34)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(100, 40)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 217
            Me.pbFoto.TabStop = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.ForeColor = System.Drawing.Color.Black
            Me.Label27.Location = New System.Drawing.Point(1051, 18)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(40, 15)
            Me.Label27.TabIndex = 216
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
            Me.btnSerie.Location = New System.Drawing.Point(397, 46)
            Me.btnSerie.Name = "btnSerie"
            Me.btnSerie.Size = New System.Drawing.Size(26, 26)
            Me.btnSerie.TabIndex = 196
            Me.btnSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSerie.UseVisualStyleBackColor = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(293, 47)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(101, 21)
            Me.txtSerie.TabIndex = 163
            Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Me.Label16.Location = New System.Drawing.Point(293, 32)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(39, 13)
            Me.Label16.TabIndex = 164
            Me.Label16.Text = "SERIE:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.Black
            Me.Label15.Location = New System.Drawing.Point(733, 33)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(45, 13)
            Me.Label15.TabIndex = 162
            Me.Label15.Text = "TOTAL:"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'nudTotal
            '
            Me.nudTotal.BackColor = System.Drawing.Color.White
            Me.nudTotal.DecimalPlaces = 2
            Me.nudTotal.Enabled = False
            Me.nudTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudTotal.ForeColor = System.Drawing.Color.Black
            Me.nudTotal.Location = New System.Drawing.Point(732, 48)
            Me.nudTotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudTotal.Name = "nudTotal"
            Me.nudTotal.Size = New System.Drawing.Size(85, 21)
            Me.nudTotal.TabIndex = 161
            Me.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Location = New System.Drawing.Point(492, 33)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(48, 13)
            Me.Label7.TabIndex = 160
            Me.Label7.Text = "VALOR.:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'nudValor
            '
            Me.nudValor.BackColor = System.Drawing.Color.White
            Me.nudValor.DecimalPlaces = 2
            Me.nudValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValor.ForeColor = System.Drawing.Color.Black
            Me.nudValor.Location = New System.Drawing.Point(492, 48)
            Me.nudValor.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudValor.Name = "nudValor"
            Me.nudValor.Size = New System.Drawing.Size(85, 21)
            Me.nudValor.TabIndex = 159
            Me.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'tsmEliminar
            '
            Me.tsmEliminar.BackColor = System.Drawing.Color.White
            Me.tsmEliminar.Enabled = False
            Me.tsmEliminar.FlatAppearance.BorderSize = 0
            Me.tsmEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.tsmEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmEliminar.Location = New System.Drawing.Point(1207, 35)
            Me.tsmEliminar.Name = "tsmEliminar"
            Me.tsmEliminar.Size = New System.Drawing.Size(28, 28)
            Me.tsmEliminar.TabIndex = 158
            Me.tsmEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmEliminar.UseVisualStyleBackColor = False
            '
            'tsmAgregar
            '
            Me.tsmAgregar.BackColor = System.Drawing.Color.White
            Me.tsmAgregar.Enabled = False
            Me.tsmAgregar.FlatAppearance.BorderSize = 0
            Me.tsmAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.tsmAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmAgregar.Location = New System.Drawing.Point(1173, 35)
            Me.tsmAgregar.Name = "tsmAgregar"
            Me.tsmAgregar.Size = New System.Drawing.Size(28, 28)
            Me.tsmAgregar.TabIndex = 157
            Me.tsmAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmAgregar.UseVisualStyleBackColor = False
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.ForeColor = System.Drawing.Color.Black
            Me.txtObservacion.Location = New System.Drawing.Point(823, 35)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(224, 39)
            Me.txtObservacion.TabIndex = 156
            Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(823, 19)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(85, 13)
            Me.Label9.TabIndex = 155
            Me.Label9.Text = "OBSERVACIÓN:"
            '
            'cmbObservacionCalidad
            '
            Me.cmbObservacionCalidad.BackColor = System.Drawing.Color.White
            Me.cmbObservacionCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbObservacionCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbObservacionCalidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbObservacionCalidad.ForeColor = System.Drawing.Color.Black
            Me.cmbObservacionCalidad.FormattingEnabled = True
            Me.cmbObservacionCalidad.Items.AddRange(New Object() {"-- ESTADO --", "NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO (DAR BAJA)"})
            Me.cmbObservacionCalidad.Location = New System.Drawing.Point(583, 48)
            Me.cmbObservacionCalidad.Name = "cmbObservacionCalidad"
            Me.cmbObservacionCalidad.Size = New System.Drawing.Size(148, 21)
            Me.cmbObservacionCalidad.TabIndex = 153
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
            Me.dgvSecuencial.Location = New System.Drawing.Point(5, 76)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(1244, 273)
            Me.dgvSecuencial.TabIndex = 152
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
            'lblOpcion
            '
            Me.lblOpcion.AutoSize = True
            Me.lblOpcion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOpcion.ForeColor = System.Drawing.Color.Black
            Me.lblOpcion.Location = New System.Drawing.Point(489, 18)
            Me.lblOpcion.Name = "lblOpcion"
            Me.lblOpcion.Size = New System.Drawing.Size(0, 13)
            Me.lblOpcion.TabIndex = 150
            '
            'nudCantidad
            '
            Me.nudCantidad.BackColor = System.Drawing.Color.White
            Me.nudCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidad.ForeColor = System.Drawing.Color.Black
            Me.nudCantidad.Location = New System.Drawing.Point(428, 48)
            Me.nudCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudCantidad.Name = "nudCantidad"
            Me.nudCantidad.Size = New System.Drawing.Size(61, 21)
            Me.nudCantidad.TabIndex = 2
            Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Me.Label17.Location = New System.Drawing.Point(433, 32)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(41, 13)
            Me.Label17.TabIndex = 28
            Me.Label17.Text = "CANT.:"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblObservacionCalidad
            '
            Me.lblObservacionCalidad.AutoSize = True
            Me.lblObservacionCalidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacionCalidad.ForeColor = System.Drawing.Color.Black
            Me.lblObservacionCalidad.Location = New System.Drawing.Point(580, 33)
            Me.lblObservacionCalidad.Name = "lblObservacionCalidad"
            Me.lblObservacionCalidad.Size = New System.Drawing.Size(104, 13)
            Me.lblObservacionCalidad.TabIndex = 26
            Me.lblObservacionCalidad.Text = "ESTADO / CALIDAD"
            '
            'txtCodigoArticulo
            '
            Me.txtCodigoArticulo.BackColor = System.Drawing.Color.White
            Me.txtCodigoArticulo.Enabled = False
            Me.txtCodigoArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(180, 47)
            Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
            Me.txtCodigoArticulo.Size = New System.Drawing.Size(107, 21)
            Me.txtCodigoArticulo.TabIndex = 3
            Me.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodigoArticulo.Visible = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(177, 31)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(51, 13)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "CÓDIGO:"
            Me.Label12.Visible = False
            '
            'txtArticulo
            '
            Me.txtArticulo.BackColor = System.Drawing.Color.White
            Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtArticulo.Location = New System.Drawing.Point(6, 47)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(281, 21)
            Me.txtArticulo.TabIndex = 0
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblArticulo
            '
            Me.lblArticulo.AutoSize = True
            Me.lblArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticulo.ForeColor = System.Drawing.Color.Black
            Me.lblArticulo.Location = New System.Drawing.Point(9, 31)
            Me.lblArticulo.Name = "lblArticulo"
            Me.lblArticulo.Size = New System.Drawing.Size(107, 13)
            Me.lblArticulo.TabIndex = 7
            Me.lblArticulo.Text = "BUSCAR ARTÍCULO:"
            '
            'lblIdDetalleKardex
            '
            Me.lblIdDetalleKardex.AutoSize = True
            Me.lblIdDetalleKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardex.Location = New System.Drawing.Point(191, 51)
            Me.lblIdDetalleKardex.Name = "lblIdDetalleKardex"
            Me.lblIdDetalleKardex.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleKardex.TabIndex = 149
            Me.lblIdDetalleKardex.Text = "0"
            Me.lblIdDetalleKardex.Visible = False
            '
            'lblIdKardex
            '
            Me.lblIdKardex.AutoSize = True
            Me.lblIdKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdKardex.Location = New System.Drawing.Point(239, 51)
            Me.lblIdKardex.Name = "lblIdKardex"
            Me.lblIdKardex.Size = New System.Drawing.Size(13, 13)
            Me.lblIdKardex.TabIndex = 141
            Me.lblIdKardex.Text = "0"
            Me.lblIdKardex.Visible = False
            '
            'lblIdArticulo
            '
            Me.lblIdArticulo.AutoSize = True
            Me.lblIdArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdArticulo.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdArticulo.Location = New System.Drawing.Point(136, 51)
            Me.lblIdArticulo.Name = "lblIdArticulo"
            Me.lblIdArticulo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticulo.TabIndex = 36
            Me.lblIdArticulo.Text = "0"
            Me.lblIdArticulo.Visible = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(5, 7)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(90, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "COMPROBANTE:"
            '
            'txtNumero
            '
            Me.txtNumero.BackColor = System.Drawing.Color.White
            Me.txtNumero.Enabled = False
            Me.txtNumero.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumero.Location = New System.Drawing.Point(6, 28)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(103, 21)
            Me.txtNumero.TabIndex = 6
            Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblBodega
            '
            Me.lblBodega.AutoSize = True
            Me.lblBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBodega.Location = New System.Drawing.Point(127, 10)
            Me.lblBodega.Name = "lblBodega"
            Me.lblBodega.Size = New System.Drawing.Size(53, 13)
            Me.lblBodega.TabIndex = 9
            Me.lblBodega.Text = "BODEGA:"
            '
            'txtProveedores
            '
            Me.txtProveedores.BackColor = System.Drawing.Color.White
            Me.txtProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtProveedores.Enabled = False
            Me.txtProveedores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedores.ForeColor = System.Drawing.Color.Black
            Me.txtProveedores.Location = New System.Drawing.Point(439, 123)
            Me.txtProveedores.Name = "txtProveedores"
            Me.txtProveedores.Size = New System.Drawing.Size(548, 21)
            Me.txtProveedores.TabIndex = 14
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(344, 108)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(51, 13)
            Me.Label8.TabIndex = 63
            Me.Label8.Text = "CÓDIGO:"
            '
            'lblRazon
            '
            Me.lblRazon.AutoSize = True
            Me.lblRazon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazon.Location = New System.Drawing.Point(1016, 117)
            Me.lblRazon.Name = "lblRazon"
            Me.lblRazon.Size = New System.Drawing.Size(101, 13)
            Me.lblRazon.TabIndex = 42
            Me.lblRazon.Text = "RAZÓN / MOTIVO:"
            '
            'cmbBodega
            '
            Me.cmbBodega.BackColor = System.Drawing.Color.White
            Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBodega.Enabled = False
            Me.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBodega.FormattingEnabled = True
            Me.cmbBodega.Location = New System.Drawing.Point(130, 27)
            Me.cmbBodega.Name = "cmbBodega"
            Me.cmbBodega.Size = New System.Drawing.Size(270, 21)
            Me.cmbBodega.TabIndex = 8
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProvincia.Location = New System.Drawing.Point(436, 10)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(67, 13)
            Me.lblProvincia.TabIndex = 51
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.ForeColor = System.Drawing.Color.Black
            Me.txtCódigo.Location = New System.Drawing.Point(348, 123)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(53, 21)
            Me.txtCódigo.TabIndex = 13
            Me.txtCódigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cbmCanton
            '
            Me.cbmCanton.BackColor = System.Drawing.Color.White
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Enabled = False
            Me.cbmCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCanton.ForeColor = System.Drawing.Color.Black
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(734, 28)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(253, 21)
            Me.cbmCanton.TabIndex = 1
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudad.Location = New System.Drawing.Point(731, 13)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(48, 13)
            Me.lblCiudad.TabIndex = 52
            Me.lblCiudad.Text = "CIUDAD:"
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.ForeColor = System.Drawing.Color.Black
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(1019, 27)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(230, 21)
            Me.cbmParroquia.TabIndex = 2
            '
            'cmbConceptos
            '
            Me.cmbConceptos.BackColor = System.Drawing.Color.White
            Me.cmbConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConceptos.Enabled = False
            Me.cmbConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConceptos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConceptos.ForeColor = System.Drawing.Color.Black
            Me.cmbConceptos.FormattingEnabled = True
            Me.cmbConceptos.Location = New System.Drawing.Point(6, 124)
            Me.cmbConceptos.Name = "cmbConceptos"
            Me.cmbConceptos.Size = New System.Drawing.Size(340, 21)
            Me.cmbConceptos.TabIndex = 12
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(9, 106)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(66, 13)
            Me.lblConcepto.TabIndex = 50
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Enabled = False
            Me.cbmCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.ForeColor = System.Drawing.Color.Black
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(441, 74)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(256, 21)
            Me.cbmCentroCosto.TabIndex = 3
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParroquia.Location = New System.Drawing.Point(1016, 13)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(70, 13)
            Me.lblParroquia.TabIndex = 53
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'cbmEgreso
            '
            Me.cbmEgreso.BackColor = System.Drawing.Color.White
            Me.cbmEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmEgreso.Enabled = False
            Me.cbmEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmEgreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEgreso.ForeColor = System.Drawing.Color.Black
            Me.cbmEgreso.FormattingEnabled = True
            Me.cbmEgreso.Items.AddRange(New Object() {"EGRESO"})
            Me.cbmEgreso.Location = New System.Drawing.Point(734, 74)
            Me.cbmEgreso.Name = "cbmEgreso"
            Me.cbmEgreso.Size = New System.Drawing.Size(100, 21)
            Me.cbmEgreso.TabIndex = 4
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(438, 56)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(109, 13)
            Me.lblCentroCosto.TabIndex = 57
            Me.lblCentroCosto.Text = "CENTRO DE COSTO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(1093, 57)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "FECHA:"
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(731, 56)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(65, 13)
            Me.lblActividad.TabIndex = 47
            Me.lblActividad.Text = "ACTIVIDAD:"
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFecha.Location = New System.Drawing.Point(1090, 73)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(159, 21)
            Me.dtpFecha.TabIndex = 7
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(6, 74)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(294, 21)
            Me.txtNombre.TabIndex = 9
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(301, 74)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(99, 21)
            Me.txtCedula.TabIndex = 10
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 56)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(64, 13)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "CUSTODIO:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(1016, 55)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(33, 13)
            Me.Label4.TabIndex = 16
            Me.Label4.Text = "NRO:"
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDocumento.Location = New System.Drawing.Point(1019, 73)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(68, 21)
            Me.txtNroDocumento.TabIndex = 15
            Me.txtNroDocumento.Text = "S/N"
            Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbDocumento
            '
            Me.cmbDocumento.BackColor = System.Drawing.Color.White
            Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbDocumento.Enabled = False
            Me.cmbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbDocumento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbDocumento.FormattingEnabled = True
            Me.cmbDocumento.Location = New System.Drawing.Point(840, 73)
            Me.cmbDocumento.Name = "cmbDocumento"
            Me.cmbDocumento.Size = New System.Drawing.Size(147, 21)
            Me.cmbDocumento.TabIndex = 5
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(837, 56)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(78, 13)
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "DOCUMENTO:"
            '
            'lblProveedor
            '
            Me.lblProveedor.AutoSize = True
            Me.lblProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProveedor.Location = New System.Drawing.Point(440, 110)
            Me.lblProveedor.Name = "lblProveedor"
            Me.lblProveedor.Size = New System.Drawing.Size(133, 13)
            Me.lblProveedor.TabIndex = 51
            Me.lblProveedor.Text = "PROVEEDOR / ENTREGA:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(439, 151)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(174, 13)
            Me.Label10.TabIndex = 66
            Me.Label10.Text = "UBICACIÓN / CLIENTE / PUESTO:"
            '
            'tpConsultar
            '
            Me.tpConsultar.BackColor = System.Drawing.Color.White
            Me.tpConsultar.Controls.Add(Me.gbComprobante)
            Me.tpConsultar.Controls.Add(Me.gbDetalleComprobante)
            Me.tpConsultar.Controls.Add(Me.gbNumeroFactura)
            Me.tpConsultar.Controls.Add(Me.gbRangoFechas)
            Me.tpConsultar.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultar.Name = "tpConsultar"
            Me.tpConsultar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultar.Size = New System.Drawing.Size(1260, 556)
            Me.tpConsultar.TabIndex = 1
            Me.tpConsultar.Text = "CONSULTAR"
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Controls.Add(Me.btnExportarComprobantes)
            Me.gbComprobante.Controls.Add(Me.dgvComprobantesEgreso)
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(3, 52)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1254, 224)
            Me.gbComprobante.TabIndex = 151
            Me.gbComprobante.TabStop = False
            Me.gbComprobante.Text = "COMPROBANTE"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.White
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(1202, 7)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(26, 26)
            Me.btnExportarComprobantes.TabIndex = 146
            Me.btnExportarComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
            '
            'dgvComprobantesEgreso
            '
            Me.dgvComprobantesEgreso.AllowUserToAddRows = False
            Me.dgvComprobantesEgreso.AllowUserToDeleteRows = False
            Me.dgvComprobantesEgreso.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesEgreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvComprobantesEgreso.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesEgreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvComprobantesEgreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesEgreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvComprobantesEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesEgreso.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobantesEgreso.GridColor = System.Drawing.Color.Black
            Me.dgvComprobantesEgreso.Location = New System.Drawing.Point(4, 33)
            Me.dgvComprobantesEgreso.MultiSelect = False
            Me.dgvComprobantesEgreso.Name = "dgvComprobantesEgreso"
            Me.dgvComprobantesEgreso.ReadOnly = True
            Me.dgvComprobantesEgreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesEgreso.RowHeadersVisible = False
            Me.dgvComprobantesEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesEgreso.Size = New System.Drawing.Size(1246, 187)
            Me.dgvComprobantesEgreso.TabIndex = 145
            '
            'gbDetalleComprobante
            '
            Me.gbDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.gbDetalleComprobante.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.gbDetalleComprobante.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbDetalleComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleComprobante.Location = New System.Drawing.Point(3, 282)
            Me.gbDetalleComprobante.Name = "gbDetalleComprobante"
            Me.gbDetalleComprobante.Size = New System.Drawing.Size(1254, 277)
            Me.gbDetalleComprobante.TabIndex = 150
            Me.gbDetalleComprobante.TabStop = False
            Me.gbDetalleComprobante.Text = "DETALLE"
            '
            'btnExportarDetalleComprobante
            '
            Me.btnExportarDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.btnExportarDetalleComprobante.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(1202, 6)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(26, 26)
            Me.btnExportarDetalleComprobante.TabIndex = 154
            Me.btnExportarDetalleComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvDetalleComprobate.GridColor = System.Drawing.Color.Black
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(4, 33)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(1246, 238)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.txtDetail)
            Me.gbNumeroFactura.Controls.Add(Me.chkTodos)
            Me.gbNumeroFactura.Controls.Add(Me.btnBuscar)
            Me.gbNumeroFactura.Controls.Add(Me.txtNroComprobante)
            Me.gbNumeroFactura.Controls.Add(Me.rbtNum)
            Me.gbNumeroFactura.Controls.Add(Me.rbtDet)
            Me.gbNumeroFactura.Location = New System.Drawing.Point(434, 5)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(823, 48)
            Me.gbNumeroFactura.TabIndex = 148
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "OPCIONES DE BUSQUEDA"
            '
            'txtDetail
            '
            Me.txtDetail.BackColor = System.Drawing.Color.White
            Me.txtDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetail.Enabled = False
            Me.txtDetail.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetail.Location = New System.Drawing.Point(292, 18)
            Me.txtDetail.Name = "txtDetail"
            Me.txtDetail.Size = New System.Drawing.Size(431, 20)
            Me.txtDetail.TabIndex = 11
            Me.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Checked = True
            Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkTodos.Location = New System.Drawing.Point(164, -2)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(56, 17)
            Me.chkTodos.TabIndex = 9
            Me.chkTodos.Text = "Todos"
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.White
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.Location = New System.Drawing.Point(730, 11)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(30, 30)
            Me.btnBuscar.TabIndex = 0
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'txtNroComprobante
            '
            Me.txtNroComprobante.BackColor = System.Drawing.Color.White
            Me.txtNroComprobante.Enabled = False
            Me.txtNroComprobante.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobante.Location = New System.Drawing.Point(85, 17)
            Me.txtNroComprobante.Name = "txtNroComprobante"
            Me.txtNroComprobante.Size = New System.Drawing.Size(108, 20)
            Me.txtNroComprobante.TabIndex = 0
            Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'rbtNum
            '
            Me.rbtNum.AutoSize = True
            Me.rbtNum.Enabled = False
            Me.rbtNum.Location = New System.Drawing.Point(7, 18)
            Me.rbtNum.Name = "rbtNum"
            Me.rbtNum.Size = New System.Drawing.Size(72, 17)
            Me.rbtNum.TabIndex = 10
            Me.rbtNum.TabStop = True
            Me.rbtNum.Text = "N° Comp:"
            Me.rbtNum.UseVisualStyleBackColor = True
            '
            'rbtDet
            '
            Me.rbtDet.AutoSize = True
            Me.rbtDet.Enabled = False
            Me.rbtDet.Location = New System.Drawing.Point(216, 18)
            Me.rbtDet.Name = "rbtDet"
            Me.rbtDet.Size = New System.Drawing.Size(63, 17)
            Me.rbtDet.TabIndex = 12
            Me.rbtDet.TabStop = True
            Me.rbtDet.Text = "Detalle:"
            Me.rbtDet.UseVisualStyleBackColor = True
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label13)
            Me.gbRangoFechas.Controls.Add(Me.Label14)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Location = New System.Drawing.Point(3, 5)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(429, 48)
            Me.gbRangoFechas.TabIndex = 146
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(8, 20)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(23, 13)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "De:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(218, 20)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(16, 13)
            Me.Label14.TabIndex = 4
            Me.Label14.Text = "a:"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(237, 17)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(180, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(33, 17)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(168, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.TabControl1)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1260, 556)
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
            Me.TabControl1.Size = New System.Drawing.Size(1258, 557)
            Me.TabControl1.TabIndex = 153
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.Button1)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.txtIdComprobante)
            Me.TabPage1.Controls.Add(Me.crvComprobante)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1250, 531)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Comprobante"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(1152, 8)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(90, 23)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "CARGAR"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(945, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "COMPROBANTE:"
            '
            'txtIdComprobante
            '
            Me.txtIdComprobante.Location = New System.Drawing.Point(1042, 8)
            Me.txtIdComprobante.Name = "txtIdComprobante"
            Me.txtIdComprobante.Size = New System.Drawing.Size(110, 21)
            Me.txtIdComprobante.TabIndex = 6
            Me.txtIdComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'crvComprobante
            '
            Me.crvComprobante.ActiveViewIndex = -1
            Me.crvComprobante.AutoSize = True
            Me.crvComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobante.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobante.ForeColor = System.Drawing.SystemColors.ControlText
            Me.crvComprobante.Location = New System.Drawing.Point(6, 6)
            Me.crvComprobante.Name = "crvComprobante"
            Me.crvComprobante.Size = New System.Drawing.Size(1238, 520)
            Me.crvComprobante.TabIndex = 152
            Me.crvComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1250, 531)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Imagen Adjunta"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(1244, 525)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar, Me.tsmActualizar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1270, 32)
            Me.MenuStrip1.TabIndex = 187
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
            'tsmActualizar
            '
            Me.tsmActualizar.Enabled = False
            Me.tsmActualizar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmActualizar.Name = "tsmActualizar"
            Me.tsmActualizar.Size = New System.Drawing.Size(112, 28)
            Me.tsmActualizar.Text = "ACTUALIZAR"
            '
            'lblIdKardex2
            '
            Me.lblIdKardex2.AutoSize = True
            Me.lblIdKardex2.Location = New System.Drawing.Point(592, 37)
            Me.lblIdKardex2.Name = "lblIdKardex2"
            Me.lblIdKardex2.Size = New System.Drawing.Size(0, 13)
            Me.lblIdKardex2.TabIndex = 188
            Me.lblIdKardex2.Visible = False
            '
            'lblDetaComp
            '
            Me.lblDetaComp.AutoSize = True
            Me.lblDetaComp.Location = New System.Drawing.Point(437, 35)
            Me.lblDetaComp.Name = "lblDetaComp"
            Me.lblDetaComp.Size = New System.Drawing.Size(0, 13)
            Me.lblDetaComp.TabIndex = 189
            Me.lblDetaComp.Visible = False
            '
            'lblDetKardex
            '
            Me.lblDetKardex.AutoSize = True
            Me.lblDetKardex.Location = New System.Drawing.Point(675, 37)
            Me.lblDetKardex.Name = "lblDetKardex"
            Me.lblDetKardex.Size = New System.Drawing.Size(0, 13)
            Me.lblDetKardex.TabIndex = 190
            Me.lblDetKardex.Visible = False
            '
            'lblComp
            '
            Me.lblComp.AutoSize = True
            Me.lblComp.Location = New System.Drawing.Point(500, 36)
            Me.lblComp.Name = "lblComp"
            Me.lblComp.Size = New System.Drawing.Size(0, 13)
            Me.lblComp.TabIndex = 191
            Me.lblComp.Visible = False
            '
            'lblIdSecuencial
            '
            Me.lblIdSecuencial.AutoSize = True
            Me.lblIdSecuencial.Location = New System.Drawing.Point(372, 36)
            Me.lblIdSecuencial.Name = "lblIdSecuencial"
            Me.lblIdSecuencial.Size = New System.Drawing.Size(0, 13)
            Me.lblIdSecuencial.TabIndex = 192
            Me.lblIdSecuencial.Visible = False
            '
            'lblCantidadSaldo
            '
            Me.lblCantidadSaldo.AutoSize = True
            Me.lblCantidadSaldo.Location = New System.Drawing.Point(304, 35)
            Me.lblCantidadSaldo.Name = "lblCantidadSaldo"
            Me.lblCantidadSaldo.Size = New System.Drawing.Size(0, 13)
            Me.lblCantidadSaldo.TabIndex = 193
            Me.lblCantidadSaldo.Visible = False
            '
            'FormComprobanteEgresoBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1270, 616)
            Me.Controls.Add(Me.lblCantidadSaldo)
            Me.Controls.Add(Me.lblIdSecuencial)
            Me.Controls.Add(Me.lblComp)
            Me.Controls.Add(Me.lblDetKardex)
            Me.Controls.Add(Me.lblDetaComp)
            Me.Controls.Add(Me.lblIdKardex2)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tbComprobanteIngresoBodega)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormComprobanteEgresoBodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRO DE COMPROBANTE DE EGRESO A BODEGA"
            Me.tbComprobanteIngresoBodega.ResumeLayout(False)
            Me.tpRegistro.ResumeLayout(False)
            Me.tpRegistro.PerformLayout()
            Me.gbBusquedaArticulo.ResumeLayout(False)
            Me.gbBusquedaArticulo.PerformLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultar.ResumeLayout(False)
            Me.gbComprobante.ResumeLayout(False)
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDetalleComprobante.ResumeLayout(False)
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNumeroFactura.ResumeLayout(False)
            Me.gbNumeroFactura.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tbComprobanteIngresoBodega As System.Windows.Forms.TabControl
        Friend WithEvents tpRegistro As System.Windows.Forms.TabPage
        Friend WithEvents gbBusquedaArticulo As System.Windows.Forms.GroupBox
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
        Friend WithEvents lblOpcion As System.Windows.Forms.Label
        Friend WithEvents lblIdDetalleKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdArticulo As System.Windows.Forms.Label
        Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblObservacionCalidad As System.Windows.Forms.Label
        Friend WithEvents txtCodigoArticulo As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents lblArticulo As System.Windows.Forms.Label
        Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
        Friend WithEvents lblRecibe As System.Windows.Forms.Label
        Friend WithEvents lblProveedor As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtProveedores As System.Windows.Forms.TextBox
        Friend WithEvents txtCódigo As System.Windows.Forms.TextBox
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents cmbConceptos As System.Windows.Forms.ComboBox
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents cbmEgreso As System.Windows.Forms.ComboBox
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents lblRazon As System.Windows.Forms.Label
        Friend WithEvents txtRazon As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cmbBodega As System.Windows.Forms.ComboBox
        Friend WithEvents lblBodega As System.Windows.Forms.Label
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents tpConsultar As System.Windows.Forms.TabPage
        Friend WithEvents gbComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents dgvComprobantesEgreso As System.Windows.Forms.DataGridView
        Friend WithEvents gbDetalleComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents txtIdComprobante As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cmbObservacionCalidad As System.Windows.Forms.ComboBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents btnExportarDetalleComprobante As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents rbtNum As System.Windows.Forms.RadioButton
        Friend WithEvents rbtDet As System.Windows.Forms.RadioButton
        Friend WithEvents txtDetail As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmEliminar As System.Windows.Forms.Button
        Friend WithEvents tsmAgregar As System.Windows.Forms.Button
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
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
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents nudTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents bntPuesto As System.Windows.Forms.Button
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents btnSerie As System.Windows.Forms.Button
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents tsmActualizar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblIdKardex2 As System.Windows.Forms.Label
        Friend WithEvents lblDetaComp As System.Windows.Forms.Label
        Friend WithEvents lblDetKardex As System.Windows.Forms.Label
        Friend WithEvents lblComp As System.Windows.Forms.Label
        Friend WithEvents lblIdSecuencial As System.Windows.Forms.Label
        Friend WithEvents lblCantidadSaldo As System.Windows.Forms.Label
    End Class
End Namespace