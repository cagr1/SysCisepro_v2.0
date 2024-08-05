Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormComprobanteIngresoBodega
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteIngresoBodega))
            Me.tbComprobanteIngresoBodega = New System.Windows.Forms.TabControl()
            Me.tpRegistro = New System.Windows.Forms.TabPage()
            Me.btnOrdenCompra = New System.Windows.Forms.Button()
            Me.lblOrdenCompra = New System.Windows.Forms.Label()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtProveedores = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.cmbConceptos = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtNroComprobante = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cmbBodega = New System.Windows.Forms.ComboBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cbmIngreso = New System.Windows.Forms.ComboBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.cmbDocumento = New System.Windows.Forms.ComboBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.gbBusquedaArticulo = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.btnSerie = New System.Windows.Forms.Button()
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.nudValor = New System.Windows.Forms.NumericUpDown()
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
            Me.tsmEliminar = New System.Windows.Forms.Button()
            Me.tsmAgregar = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cmbObservacionCalidad = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.lblIdDetalleKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex = New System.Windows.Forms.Label()
            Me.lblIdArticulo = New System.Windows.Forms.Label()
            Me.lblOpcion = New System.Windows.Forms.Label()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblRazon = New System.Windows.Forms.Label()
            Me.tpConsultar = New System.Windows.Forms.TabPage()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.dgvComprobantesIngreso = New System.Windows.Forms.DataGridView()
            Me.gbDetalleComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarDetalleComprobante = New System.Windows.Forms.Button()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.rbtDet = New System.Windows.Forms.RadioButton()
            Me.rbtNum = New System.Windows.Forms.RadioButton()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtNroComprobanteBusqueda = New System.Windows.Forms.TextBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.bntCargar = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtIdComprobante = New System.Windows.Forms.TextBox()
            Me.crvComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.TmsActualizar = New System.Windows.Forms.ToolStripMenuItem()
            Me.TmsEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblCantidadSaldo = New System.Windows.Forms.Label()
            Me.lblComp = New System.Windows.Forms.Label()
            Me.lblDetaComp = New System.Windows.Forms.Label()
            Me.lblDetaKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex2 = New System.Windows.Forms.Label()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.lblCantidadInicial = New System.Windows.Forms.Label()
            Me.KryptonGroupBox5 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.btnBuscarModi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            Me.tpRegistro.SuspendLayout()
            Me.gbBusquedaArticulo.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultar.SuspendLayout()
            Me.gbComprobante.SuspendLayout()
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            Me.SuspendLayout()
            '
            'tbComprobanteIngresoBodega
            '
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpRegistro)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpConsultar)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpReporte)
            Me.tbComprobanteIngresoBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbComprobanteIngresoBodega.Location = New System.Drawing.Point(1, 33)
            Me.tbComprobanteIngresoBodega.Name = "tbComprobanteIngresoBodega"
            Me.tbComprobanteIngresoBodega.SelectedIndex = 0
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(1084, 582)
            Me.tbComprobanteIngresoBodega.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tbComprobanteIngresoBodega.TabIndex = 0
            '
            'tpRegistro
            '
            Me.tpRegistro.BackColor = System.Drawing.Color.White
            Me.tpRegistro.Controls.Add(Me.btnOrdenCompra)
            Me.tpRegistro.Controls.Add(Me.lblOrdenCompra)
            Me.tpRegistro.Controls.Add(Me.chkReq)
            Me.tpRegistro.Controls.Add(Me.bntPuesto)
            Me.tpRegistro.Controls.Add(Me.txtRazon)
            Me.tpRegistro.Controls.Add(Me.txtUbicacion)
            Me.tpRegistro.Controls.Add(Me.txtRecibe)
            Me.tpRegistro.Controls.Add(Me.Label6)
            Me.tpRegistro.Controls.Add(Me.txtProveedores)
            Me.tpRegistro.Controls.Add(Me.Label2)
            Me.tpRegistro.Controls.Add(Me.txtCodigo)
            Me.tpRegistro.Controls.Add(Me.cmbConceptos)
            Me.tpRegistro.Controls.Add(Me.Label4)
            Me.tpRegistro.Controls.Add(Me.cbmProvincia)
            Me.tpRegistro.Controls.Add(Me.Label13)
            Me.tpRegistro.Controls.Add(Me.txtNroComprobante)
            Me.tpRegistro.Controls.Add(Me.Label15)
            Me.tpRegistro.Controls.Add(Me.cmbBodega)
            Me.tpRegistro.Controls.Add(Me.Label16)
            Me.tpRegistro.Controls.Add(Me.cbmCanton)
            Me.tpRegistro.Controls.Add(Me.Label18)
            Me.tpRegistro.Controls.Add(Me.cbmParroquia)
            Me.tpRegistro.Controls.Add(Me.cbmCentroCosto)
            Me.tpRegistro.Controls.Add(Me.Label19)
            Me.tpRegistro.Controls.Add(Me.cbmIngreso)
            Me.tpRegistro.Controls.Add(Me.Label20)
            Me.tpRegistro.Controls.Add(Me.Label21)
            Me.tpRegistro.Controls.Add(Me.Label22)
            Me.tpRegistro.Controls.Add(Me.dtpFecha)
            Me.tpRegistro.Controls.Add(Me.txtNombre)
            Me.tpRegistro.Controls.Add(Me.txtCedula)
            Me.tpRegistro.Controls.Add(Me.Label23)
            Me.tpRegistro.Controls.Add(Me.Label24)
            Me.tpRegistro.Controls.Add(Me.txtNroDocumento)
            Me.tpRegistro.Controls.Add(Me.cmbDocumento)
            Me.tpRegistro.Controls.Add(Me.Label25)
            Me.tpRegistro.Controls.Add(Me.gbBusquedaArticulo)
            Me.tpRegistro.Controls.Add(Me.Label5)
            Me.tpRegistro.Controls.Add(Me.Label1)
            Me.tpRegistro.Controls.Add(Me.lblRazon)
            Me.tpRegistro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tpRegistro.Name = "tpRegistro"
            Me.tpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegistro.Size = New System.Drawing.Size(1076, 556)
            Me.tpRegistro.TabIndex = 0
            Me.tpRegistro.Text = "REGISTRO"
            '
            'btnOrdenCompra
            '
            Me.btnOrdenCompra.Enabled = False
            Me.btnOrdenCompra.Location = New System.Drawing.Point(1017, 198)
            Me.btnOrdenCompra.Name = "btnOrdenCompra"
            Me.btnOrdenCompra.Size = New System.Drawing.Size(26, 26)
            Me.btnOrdenCompra.TabIndex = 117
            Me.btnOrdenCompra.Tag = "1"
            Me.btnOrdenCompra.Text = "..."
            Me.btnOrdenCompra.UseVisualStyleBackColor = True
            '
            'lblOrdenCompra
            '
            Me.lblOrdenCompra.AutoSize = True
            Me.lblOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOrdenCompra.Location = New System.Drawing.Point(986, 206)
            Me.lblOrdenCompra.Name = "lblOrdenCompra"
            Me.lblOrdenCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblOrdenCompra.TabIndex = 195
            Me.lblOrdenCompra.Text = "###"
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.Enabled = False
            Me.chkReq.Location = New System.Drawing.Point(877, 202)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(108, 21)
            Me.chkReq.TabIndex = 116
            Me.chkReq.Text = "ÓRDEN C. N°:"
            Me.chkReq.UseVisualStyleBackColor = True
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.White
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.bntPuesto.Location = New System.Drawing.Point(757, 183)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(26, 26)
            Me.bntPuesto.TabIndex = 114
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'txtRazon
            '
            Me.txtRazon.BackColor = System.Drawing.Color.White
            Me.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazon.Enabled = False
            Me.txtRazon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazon.ForeColor = System.Drawing.Color.Black
            Me.txtRazon.Location = New System.Drawing.Point(787, 125)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.Size = New System.Drawing.Size(256, 71)
            Me.txtRazon.TabIndex = 112
            '
            'txtUbicacion
            '
            Me.txtUbicacion.BackColor = System.Drawing.Color.White
            Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacion.Enabled = False
            Me.txtUbicacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacion.ForeColor = System.Drawing.Color.Black
            Me.txtUbicacion.Location = New System.Drawing.Point(415, 173)
            Me.txtUbicacion.Multiline = True
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(338, 47)
            Me.txtUbicacion.TabIndex = 115
            '
            'txtRecibe
            '
            Me.txtRecibe.BackColor = System.Drawing.Color.White
            Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecibe.Enabled = False
            Me.txtRecibe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtRecibe.Location = New System.Drawing.Point(11, 177)
            Me.txtRecibe.Name = "txtRecibe"
            Me.txtRecibe.Size = New System.Drawing.Size(390, 21)
            Me.txtRecibe.TabIndex = 113
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(14, 160)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(59, 13)
            Me.Label6.TabIndex = 183
            Me.Label6.Text = "ENTREGA:"
            '
            'txtProveedores
            '
            Me.txtProveedores.BackColor = System.Drawing.Color.White
            Me.txtProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtProveedores.Enabled = False
            Me.txtProveedores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedores.ForeColor = System.Drawing.Color.Black
            Me.txtProveedores.Location = New System.Drawing.Point(413, 122)
            Me.txtProveedores.Name = "txtProveedores"
            Me.txtProveedores.Size = New System.Drawing.Size(340, 21)
            Me.txtProveedores.TabIndex = 111
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(347, 106)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(51, 13)
            Me.Label2.TabIndex = 181
            Me.Label2.Text = "CÓDIGO:"
            '
            'txtCodigo
            '
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigo.Location = New System.Drawing.Point(351, 121)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(53, 21)
            Me.txtCodigo.TabIndex = 177
            Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            Me.cmbConceptos.Location = New System.Drawing.Point(9, 122)
            Me.cmbConceptos.Name = "cmbConceptos"
            Me.cmbConceptos.Size = New System.Drawing.Size(340, 21)
            Me.cmbConceptos.TabIndex = 110
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(12, 104)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(68, 13)
            Me.Label4.TabIndex = 179
            Me.Label4.Text = "CONCEPTO:"
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
            Me.cbmProvincia.Location = New System.Drawing.Point(413, 27)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(175, 21)
            Me.cbmProvincia.TabIndex = 102
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(8, 7)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(92, 13)
            Me.Label13.TabIndex = 160
            Me.Label13.Text = "COMPROBANTE:"
            '
            'txtNroComprobante
            '
            Me.txtNroComprobante.BackColor = System.Drawing.Color.White
            Me.txtNroComprobante.Enabled = False
            Me.txtNroComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobante.Location = New System.Drawing.Point(9, 28)
            Me.txtNroComprobante.Name = "txtNroComprobante"
            Me.txtNroComprobante.Size = New System.Drawing.Size(103, 21)
            Me.txtNroComprobante.TabIndex = 100
            Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(130, 10)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(53, 13)
            Me.Label15.TabIndex = 164
            Me.Label15.Text = "BODEGA:"
            '
            'cmbBodega
            '
            Me.cmbBodega.BackColor = System.Drawing.Color.White
            Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBodega.Enabled = False
            Me.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBodega.FormattingEnabled = True
            Me.cmbBodega.Location = New System.Drawing.Point(133, 27)
            Me.cmbBodega.Name = "cmbBodega"
            Me.cmbBodega.Size = New System.Drawing.Size(270, 21)
            Me.cmbBodega.TabIndex = 101
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(410, 10)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(67, 13)
            Me.Label16.TabIndex = 171
            Me.Label16.Text = "PROVINCIA:"
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
            Me.cbmCanton.Location = New System.Drawing.Point(602, 28)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(253, 21)
            Me.cbmCanton.TabIndex = 103
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(599, 13)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(48, 13)
            Me.Label18.TabIndex = 172
            Me.Label18.Text = "CIUDAD:"
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.ForeColor = System.Drawing.Color.Black
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(864, 27)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(230, 21)
            Me.cbmParroquia.TabIndex = 104
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
            Me.cbmCentroCosto.Location = New System.Drawing.Point(415, 74)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(173, 21)
            Me.cbmCentroCosto.TabIndex = 106
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(876, 13)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(70, 13)
            Me.Label19.TabIndex = 173
            Me.Label19.Text = "PARROQUIA:"
            '
            'cbmIngreso
            '
            Me.cbmIngreso.BackColor = System.Drawing.Color.White
            Me.cbmIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmIngreso.Enabled = False
            Me.cbmIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmIngreso.ForeColor = System.Drawing.Color.Black
            Me.cbmIngreso.FormattingEnabled = True
            Me.cbmIngreso.Items.AddRange(New Object() {"INGRESO"})
            Me.cbmIngreso.Location = New System.Drawing.Point(602, 74)
            Me.cbmIngreso.Name = "cbmIngreso"
            Me.cbmIngreso.Size = New System.Drawing.Size(100, 21)
            Me.cbmIngreso.TabIndex = 107
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(412, 56)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(109, 13)
            Me.Label20.TabIndex = 174
            Me.Label20.Text = "CENTRO DE COSTO:"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(870, 59)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(44, 13)
            Me.Label21.TabIndex = 158
            Me.Label21.Text = "FECHA:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(599, 56)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(65, 13)
            Me.Label22.TabIndex = 170
            Me.Label22.Text = "ACTIVIDAD:"
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFecha.Location = New System.Drawing.Point(920, 56)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(174, 22)
            Me.dtpFecha.TabIndex = 109
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(9, 74)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(294, 21)
            Me.txtNombre.TabIndex = 105
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(304, 74)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(99, 21)
            Me.txtCedula.TabIndex = 165
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(6, 56)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(64, 13)
            Me.Label23.TabIndex = 169
            Me.Label23.Text = "CUSTODIO:"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(870, 85)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(33, 13)
            Me.Label24.TabIndex = 168
            Me.Label24.Text = "NRO:"
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDocumento.Location = New System.Drawing.Point(920, 80)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.ReadOnly = True
            Me.txtNroDocumento.Size = New System.Drawing.Size(174, 22)
            Me.txtNroDocumento.TabIndex = 167
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
            Me.cmbDocumento.Location = New System.Drawing.Point(708, 73)
            Me.cmbDocumento.Name = "cmbDocumento"
            Me.cmbDocumento.Size = New System.Drawing.Size(147, 21)
            Me.cmbDocumento.TabIndex = 108
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(730, 56)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(78, 13)
            Me.Label25.TabIndex = 166
            Me.Label25.Text = "DOCUMENTO:"
            '
            'gbBusquedaArticulo
            '
            Me.gbBusquedaArticulo.BackColor = System.Drawing.Color.White
            Me.gbBusquedaArticulo.Controls.Add(Me.Label14)
            Me.gbBusquedaArticulo.Controls.Add(Me.pbFoto)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label17)
            Me.gbBusquedaArticulo.Controls.Add(Me.btnSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtSerie)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label12)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label9)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudValor)
            Me.gbBusquedaArticulo.Controls.Add(Me.dgvSecuencial)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmEliminar)
            Me.gbBusquedaArticulo.Controls.Add(Me.tsmAgregar)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtObservacion)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label8)
            Me.gbBusquedaArticulo.Controls.Add(Me.cmbObservacionCalidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label10)
            Me.gbBusquedaArticulo.Controls.Add(Me.nudCantidad)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label26)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label27)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtCodigoArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.txtArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label28)
            Me.gbBusquedaArticulo.Controls.Add(Me.Label29)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdDetalleKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdKardex)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblIdArticulo)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblOpcion)
            Me.gbBusquedaArticulo.Controls.Add(Me.lblDetalle)
            Me.gbBusquedaArticulo.Enabled = False
            Me.gbBusquedaArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(11, 230)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(1090, 359)
            Me.gbBusquedaArticulo.TabIndex = 148
            Me.gbBusquedaArticulo.TabStop = False
            Me.gbBusquedaArticulo.Text = "DETALLE DEL COMPROBANTE DE INGRESO"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label14.Location = New System.Drawing.Point(596, 333)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(0, 15)
            Me.Label14.TabIndex = 203
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Location = New System.Drawing.Point(874, 28)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(100, 40)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 201
            Me.pbFoto.TabStop = False
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Me.Label17.Location = New System.Drawing.Point(875, 12)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(40, 15)
            Me.Label17.TabIndex = 200
            Me.Label17.Text = "FOTO:"
            '
            'btnSerie
            '
            Me.btnSerie.BackColor = System.Drawing.Color.White
            Me.btnSerie.Enabled = False
            Me.btnSerie.FlatAppearance.BorderSize = 0
            Me.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSerie.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnSerie.Location = New System.Drawing.Point(377, 37)
            Me.btnSerie.Name = "btnSerie"
            Me.btnSerie.Size = New System.Drawing.Size(28, 28)
            Me.btnSerie.TabIndex = 119
            Me.btnSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSerie.UseVisualStyleBackColor = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(270, 43)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(101, 21)
            Me.txtSerie.TabIndex = 120
            Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(270, 28)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(39, 13)
            Me.Label12.TabIndex = 198
            Me.Label12.Text = "SERIE:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(630, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(48, 13)
            Me.Label9.TabIndex = 177
            Me.Label9.Text = "VALOR.:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'nudValor
            '
            Me.nudValor.BackColor = System.Drawing.Color.White
            Me.nudValor.DecimalPlaces = 2
            Me.nudValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValor.ForeColor = System.Drawing.Color.Black
            Me.nudValor.Location = New System.Drawing.Point(630, 44)
            Me.nudValor.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudValor.Name = "nudValor"
            Me.nudValor.Size = New System.Drawing.Size(73, 21)
            Me.nudValor.TabIndex = 123
            Me.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            Me.dgvSecuencial.Location = New System.Drawing.Point(3, 70)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(1056, 256)
            Me.dgvSecuencial.TabIndex = 175
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
            'tsmEliminar
            '
            Me.tsmEliminar.BackColor = System.Drawing.Color.White
            Me.tsmEliminar.Enabled = False
            Me.tsmEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmEliminar.Location = New System.Drawing.Point(1015, 32)
            Me.tsmEliminar.Name = "tsmEliminar"
            Me.tsmEliminar.Size = New System.Drawing.Size(28, 28)
            Me.tsmEliminar.TabIndex = 126
            Me.tsmEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmEliminar.UseVisualStyleBackColor = False
            '
            'tsmAgregar
            '
            Me.tsmAgregar.BackColor = System.Drawing.Color.White
            Me.tsmAgregar.Enabled = False
            Me.tsmAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmAgregar.Location = New System.Drawing.Point(981, 32)
            Me.tsmAgregar.Name = "tsmAgregar"
            Me.tsmAgregar.Size = New System.Drawing.Size(28, 28)
            Me.tsmAgregar.TabIndex = 125
            Me.tsmAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmAgregar.UseVisualStyleBackColor = False
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.ForeColor = System.Drawing.Color.Black
            Me.txtObservacion.Location = New System.Drawing.Point(720, 29)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(150, 38)
            Me.txtObservacion.TabIndex = 124
            Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(721, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(85, 13)
            Me.Label8.TabIndex = 171
            Me.Label8.Text = "OBSERVACIÓN:"
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
            Me.cmbObservacionCalidad.Location = New System.Drawing.Point(410, 43)
            Me.cmbObservacionCalidad.Name = "cmbObservacionCalidad"
            Me.cmbObservacionCalidad.Size = New System.Drawing.Size(142, 21)
            Me.cmbObservacionCalidad.TabIndex = 121
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(241, 12)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(0, 13)
            Me.Label10.TabIndex = 169
            Me.Label10.Visible = False
            '
            'nudCantidad
            '
            Me.nudCantidad.BackColor = System.Drawing.Color.White
            Me.nudCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidad.ForeColor = System.Drawing.Color.Black
            Me.nudCantidad.Location = New System.Drawing.Point(564, 44)
            Me.nudCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudCantidad.Name = "nudCantidad"
            Me.nudCantidad.Size = New System.Drawing.Size(61, 21)
            Me.nudCantidad.TabIndex = 122
            Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.ForeColor = System.Drawing.Color.Black
            Me.Label26.Location = New System.Drawing.Point(569, 28)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(41, 13)
            Me.Label26.TabIndex = 165
            Me.Label26.Text = "CANT.:"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label27.ForeColor = System.Drawing.Color.Black
            Me.Label27.Location = New System.Drawing.Point(411, 28)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(104, 13)
            Me.Label27.TabIndex = 164
            Me.Label27.Text = "ESTADO / CALIDAD"
            '
            'txtCodigoArticulo
            '
            Me.txtCodigoArticulo.BackColor = System.Drawing.Color.White
            Me.txtCodigoArticulo.Enabled = False
            Me.txtCodigoArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(135, 42)
            Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
            Me.txtCodigoArticulo.Size = New System.Drawing.Size(129, 21)
            Me.txtCodigoArticulo.TabIndex = 161
            Me.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodigoArticulo.Visible = False
            '
            'txtArticulo
            '
            Me.txtArticulo.BackColor = System.Drawing.Color.White
            Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtArticulo.Location = New System.Drawing.Point(6, 42)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(260, 21)
            Me.txtArticulo.TabIndex = 118
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.ForeColor = System.Drawing.Color.Black
            Me.Label28.Location = New System.Drawing.Point(191, 27)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(51, 13)
            Me.Label28.TabIndex = 163
            Me.Label28.Text = "CÓDIGO:"
            Me.Label28.Visible = False
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.ForeColor = System.Drawing.Color.Black
            Me.Label29.Location = New System.Drawing.Point(9, 27)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(107, 13)
            Me.Label29.TabIndex = 162
            Me.Label29.Text = "BUSCAR ARTÍCULO:"
            '
            'lblIdDetalleKardex
            '
            Me.lblIdDetalleKardex.AutoSize = True
            Me.lblIdDetalleKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardex.Location = New System.Drawing.Point(191, 47)
            Me.lblIdDetalleKardex.Name = "lblIdDetalleKardex"
            Me.lblIdDetalleKardex.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleKardex.TabIndex = 168
            Me.lblIdDetalleKardex.Text = "0"
            Me.lblIdDetalleKardex.Visible = False
            '
            'lblIdKardex
            '
            Me.lblIdKardex.AutoSize = True
            Me.lblIdKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdKardex.Location = New System.Drawing.Point(236, 47)
            Me.lblIdKardex.Name = "lblIdKardex"
            Me.lblIdKardex.Size = New System.Drawing.Size(13, 13)
            Me.lblIdKardex.TabIndex = 167
            Me.lblIdKardex.Text = "0"
            Me.lblIdKardex.Visible = False
            '
            'lblIdArticulo
            '
            Me.lblIdArticulo.AutoSize = True
            Me.lblIdArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdArticulo.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdArticulo.Location = New System.Drawing.Point(136, 47)
            Me.lblIdArticulo.Name = "lblIdArticulo"
            Me.lblIdArticulo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticulo.TabIndex = 166
            Me.lblIdArticulo.Text = "0"
            Me.lblIdArticulo.Visible = False
            '
            'lblOpcion
            '
            Me.lblOpcion.AutoSize = True
            Me.lblOpcion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOpcion.ForeColor = System.Drawing.Color.Black
            Me.lblOpcion.Location = New System.Drawing.Point(283, 17)
            Me.lblOpcion.Name = "lblOpcion"
            Me.lblOpcion.Size = New System.Drawing.Size(0, 13)
            Me.lblOpcion.TabIndex = 150
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.ForeColor = System.Drawing.SystemColors.Highlight
            Me.lblDetalle.Location = New System.Drawing.Point(43, 51)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(13, 13)
            Me.lblDetalle.TabIndex = 202
            Me.lblDetalle.Text = "0"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(414, 159)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(174, 13)
            Me.Label5.TabIndex = 184
            Me.Label5.Text = "UBICACIÓN / CLIENTE / PUESTO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(412, 109)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(125, 13)
            Me.Label1.TabIndex = 180
            Me.Label1.Text = "PROVEEDOR ENTREGA:"
            '
            'lblRazon
            '
            Me.lblRazon.AutoSize = True
            Me.lblRazon.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazon.Location = New System.Drawing.Point(764, 109)
            Me.lblRazon.Name = "lblRazon"
            Me.lblRazon.Size = New System.Drawing.Size(99, 13)
            Me.lblRazon.TabIndex = 187
            Me.lblRazon.Text = "RAZÓN / MOTIVO:"
            '
            'tpConsultar
            '
            Me.tpConsultar.BackColor = System.Drawing.Color.White
            Me.tpConsultar.Controls.Add(Me.KryptonGroupBox5)
            Me.tpConsultar.Controls.Add(Me.gbComprobante)
            Me.tpConsultar.Controls.Add(Me.gbDetalleComprobante)
            Me.tpConsultar.Controls.Add(Me.gbRangoFechas)
            Me.tpConsultar.Controls.Add(Me.gbNumeroFactura)
            Me.tpConsultar.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultar.Name = "tpConsultar"
            Me.tpConsultar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultar.Size = New System.Drawing.Size(1076, 556)
            Me.tpConsultar.TabIndex = 1
            Me.tpConsultar.Text = "CONSULTAR"
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Controls.Add(Me.btnExportarComprobantes)
            Me.gbComprobante.Controls.Add(Me.dgvComprobantesIngreso)
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(3, 59)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1050, 266)
            Me.gbComprobante.TabIndex = 151
            Me.gbComprobante.TabStop = False
            Me.gbComprobante.Text = "COMPROBANTE"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.White
            Me.btnExportarComprobantes.FlatAppearance.BorderSize = 0
            Me.btnExportarComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(991, 1)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(28, 28)
            Me.btnExportarComprobantes.TabIndex = 57
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
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
            Me.dgvComprobantesIngreso.Location = New System.Drawing.Point(6, 30)
            Me.dgvComprobantesIngreso.MultiSelect = False
            Me.dgvComprobantesIngreso.Name = "dgvComprobantesIngreso"
            Me.dgvComprobantesIngreso.ReadOnly = True
            Me.dgvComprobantesIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesIngreso.RowHeadersVisible = False
            Me.dgvComprobantesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesIngreso.Size = New System.Drawing.Size(1038, 227)
            Me.dgvComprobantesIngreso.TabIndex = 145
            '
            'gbDetalleComprobante
            '
            Me.gbDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.gbDetalleComprobante.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.gbDetalleComprobante.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbDetalleComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleComprobante.Location = New System.Drawing.Point(7, 329)
            Me.gbDetalleComprobante.Name = "gbDetalleComprobante"
            Me.gbDetalleComprobante.Size = New System.Drawing.Size(1046, 223)
            Me.gbDetalleComprobante.TabIndex = 150
            Me.gbDetalleComprobante.TabStop = False
            Me.gbDetalleComprobante.Text = "DETALLE"
            '
            'btnExportarDetalleComprobante
            '
            Me.btnExportarDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.btnExportarDetalleComprobante.FlatAppearance.BorderSize = 0
            Me.btnExportarDetalleComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportarDetalleComprobante.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarDetalleComprobante.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(987, -5)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(28, 28)
            Me.btnExportarDetalleComprobante.TabIndex = 153
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
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(2, 23)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(1038, 189)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.chkTodos)
            Me.gbNumeroFactura.Controls.Add(Me.rbtDet)
            Me.gbNumeroFactura.Controls.Add(Me.rbtNum)
            Me.gbNumeroFactura.Controls.Add(Me.btnBuscar)
            Me.gbNumeroFactura.Controls.Add(Me.txtNroComprobanteBusqueda)
            Me.gbNumeroFactura.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroFactura.Location = New System.Drawing.Point(791, 10)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(231, 47)
            Me.gbNumeroFactura.TabIndex = 148
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "OPCIONES DE BUSQUEDA"
            Me.gbNumeroFactura.Visible = False
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Checked = True
            Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkTodos.Location = New System.Drawing.Point(170, 0)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(56, 17)
            Me.chkTodos.TabIndex = 8
            Me.chkTodos.Text = "Todos"
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'rbtDet
            '
            Me.rbtDet.AutoSize = True
            Me.rbtDet.Enabled = False
            Me.rbtDet.Location = New System.Drawing.Point(143, 19)
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
            Me.rbtNum.Location = New System.Drawing.Point(15, 19)
            Me.rbtNum.Name = "rbtNum"
            Me.rbtNum.Size = New System.Drawing.Size(72, 17)
            Me.rbtNum.TabIndex = 6
            Me.rbtNum.TabStop = True
            Me.rbtNum.Text = "N° Comp:"
            Me.rbtNum.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.White
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscar.Location = New System.Drawing.Point(241, 18)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(28, 28)
            Me.btnBuscar.TabIndex = 0
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'txtNroComprobanteBusqueda
            '
            Me.txtNroComprobanteBusqueda.BackColor = System.Drawing.Color.White
            Me.txtNroComprobanteBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroComprobanteBusqueda.Enabled = False
            Me.txtNroComprobanteBusqueda.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobanteBusqueda.Location = New System.Drawing.Point(90, 18)
            Me.txtNroComprobanteBusqueda.Name = "txtNroComprobanteBusqueda"
            Me.txtNroComprobanteBusqueda.Size = New System.Drawing.Size(42, 21)
            Me.txtNroComprobanteBusqueda.TabIndex = 0
            Me.txtNroComprobanteBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label11)
            Me.gbRangoFechas.Controls.Add(Me.Label7)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(3, 5)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(436, 48)
            Me.gbRangoFechas.TabIndex = 146
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 22)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(23, 13)
            Me.Label11.TabIndex = 3
            Me.Label11.Text = "De:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(228, 22)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(16, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "a:"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(246, 19)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(34, 19)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.TabControl1)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1076, 556)
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
            Me.TabControl1.Size = New System.Drawing.Size(1256, 555)
            Me.TabControl1.TabIndex = 154
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.bntCargar)
            Me.TabPage1.Controls.Add(Me.Label3)
            Me.TabPage1.Controls.Add(Me.txtIdComprobante)
            Me.TabPage1.Controls.Add(Me.crvComprobante)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(1248, 529)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Comprobante"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'bntCargar
            '
            Me.bntCargar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntCargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.bntCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntCargar.Location = New System.Drawing.Point(952, 8)
            Me.bntCargar.Name = "bntCargar"
            Me.bntCargar.Size = New System.Drawing.Size(83, 23)
            Me.bntCargar.TabIndex = 7
            Me.bntCargar.Text = "CARGAR"
            Me.bntCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntCargar.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(747, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 15)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "COMPROBANTE:"
            '
            'txtIdComprobante
            '
            Me.txtIdComprobante.Location = New System.Drawing.Point(844, 8)
            Me.txtIdComprobante.Name = "txtIdComprobante"
            Me.txtIdComprobante.Size = New System.Drawing.Size(108, 21)
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
            Me.crvComprobante.Location = New System.Drawing.Point(5, 6)
            Me.crvComprobante.Name = "crvComprobante"
            Me.crvComprobante.Size = New System.Drawing.Size(1040, 517)
            Me.crvComprobante.TabIndex = 152
            Me.crvComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(1248, 529)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Imagen Adjunta"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(1242, 523)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 1
            Me.PictureBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar, Me.TmsActualizar, Me.TmsEliminar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1097, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "ELIMINAR"
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
            'TmsActualizar
            '
            Me.TmsActualizar.Enabled = False
            Me.TmsActualizar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.TmsActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TmsActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.TmsActualizar.Name = "TmsActualizar"
            Me.TmsActualizar.Size = New System.Drawing.Size(112, 28)
            Me.TmsActualizar.Text = "ACTUALIZAR"
            '
            'TmsEliminar
            '
            Me.TmsEliminar.Enabled = False
            Me.TmsEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.TmsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.TmsEliminar.Name = "TmsEliminar"
            Me.TmsEliminar.Size = New System.Drawing.Size(89, 28)
            Me.TmsEliminar.Text = "ANULAR"
            '
            'lblCantidadSaldo
            '
            Me.lblCantidadSaldo.AutoSize = True
            Me.lblCantidadSaldo.Location = New System.Drawing.Point(406, 51)
            Me.lblCantidadSaldo.Name = "lblCantidadSaldo"
            Me.lblCantidadSaldo.Size = New System.Drawing.Size(0, 13)
            Me.lblCantidadSaldo.TabIndex = 190
            Me.lblCantidadSaldo.Visible = False
            '
            'lblComp
            '
            Me.lblComp.AutoSize = True
            Me.lblComp.Location = New System.Drawing.Point(486, 50)
            Me.lblComp.Name = "lblComp"
            Me.lblComp.Size = New System.Drawing.Size(0, 13)
            Me.lblComp.TabIndex = 191
            Me.lblComp.Visible = False
            '
            'lblDetaComp
            '
            Me.lblDetaComp.AutoSize = True
            Me.lblDetaComp.Location = New System.Drawing.Point(552, 50)
            Me.lblDetaComp.Name = "lblDetaComp"
            Me.lblDetaComp.Size = New System.Drawing.Size(0, 13)
            Me.lblDetaComp.TabIndex = 192
            Me.lblDetaComp.Visible = False
            '
            'lblDetaKardex
            '
            Me.lblDetaKardex.AutoSize = True
            Me.lblDetaKardex.Location = New System.Drawing.Point(620, 50)
            Me.lblDetaKardex.Name = "lblDetaKardex"
            Me.lblDetaKardex.Size = New System.Drawing.Size(0, 13)
            Me.lblDetaKardex.TabIndex = 193
            Me.lblDetaKardex.Visible = False
            '
            'lblIdKardex2
            '
            Me.lblIdKardex2.AutoSize = True
            Me.lblIdKardex2.Location = New System.Drawing.Point(683, 50)
            Me.lblIdKardex2.Name = "lblIdKardex2"
            Me.lblIdKardex2.Size = New System.Drawing.Size(0, 13)
            Me.lblIdKardex2.TabIndex = 194
            Me.lblIdKardex2.Visible = False
            '
            'lblIdSecuencial
            '
            Me.lblIdSecuencial.AutoSize = True
            Me.lblIdSecuencial.Location = New System.Drawing.Point(744, 50)
            Me.lblIdSecuencial.Name = "lblIdSecuencial"
            Me.lblIdSecuencial.Size = New System.Drawing.Size(0, 13)
            Me.lblIdSecuencial.TabIndex = 195
            Me.lblIdSecuencial.Visible = False
            '
            'lblCantidadInicial
            '
            Me.lblCantidadInicial.AutoSize = True
            Me.lblCantidadInicial.Location = New System.Drawing.Point(377, 50)
            Me.lblCantidadInicial.Name = "lblCantidadInicial"
            Me.lblCantidadInicial.Size = New System.Drawing.Size(0, 13)
            Me.lblCantidadInicial.TabIndex = 196
            Me.lblCantidadInicial.Visible = False
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(471, -2)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnBuscarModi)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(307, 59)
            Me.KryptonGroupBox5.TabIndex = 153
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            '
            'btnBuscarModi
            '
            Me.btnBuscarModi.AutoSize = True
            Me.btnBuscarModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarModi.Location = New System.Drawing.Point(247, 2)
            Me.btnBuscarModi.Name = "btnBuscarModi"
            Me.btnBuscarModi.Size = New System.Drawing.Size(32, 32)
            Me.btnBuscarModi.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarModi.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarModi.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnBuscarModi.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.btnBuscarModi.TabIndex = 249
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnBuscarModi.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarModi.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarModi.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarModi.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarModi.Values.Text = ""
            '
            'txtFiltro
            '
            Me.txtFiltro.Location = New System.Drawing.Point(30, 9)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(100, 21)
            Me.txtFiltro.TabIndex = 250
            '
            'FormComprobanteIngresoBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1097, 613)
            Me.Controls.Add(Me.lblCantidadInicial)
            Me.Controls.Add(Me.lblIdSecuencial)
            Me.Controls.Add(Me.lblIdKardex2)
            Me.Controls.Add(Me.lblDetaKardex)
            Me.Controls.Add(Me.lblDetaComp)
            Me.Controls.Add(Me.lblComp)
            Me.Controls.Add(Me.lblCantidadSaldo)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tbComprobanteIngresoBodega)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormComprobanteIngresoBodega"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REGISTRO DE COMPROBANTE DE INGRESO A BODEGA"
            Me.tbComprobanteIngresoBodega.ResumeLayout(False)
            Me.tpRegistro.ResumeLayout(False)
            Me.tpRegistro.PerformLayout()
            Me.gbBusquedaArticulo.ResumeLayout(False)
            Me.gbBusquedaArticulo.PerformLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultar.ResumeLayout(False)
            Me.gbComprobante.ResumeLayout(False)
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tbComprobanteIngresoBodega As System.Windows.Forms.TabControl
        Friend WithEvents tpRegistro As System.Windows.Forms.TabPage
        Friend WithEvents tpConsultar As System.Windows.Forms.TabPage
        Friend WithEvents gbBusquedaArticulo As System.Windows.Forms.GroupBox
        Friend WithEvents lblOpcion As System.Windows.Forms.Label
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents bntCargar As System.Windows.Forms.Button
        Friend WithEvents txtIdComprobante As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents txtNroComprobanteBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents gbComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents gbDetalleComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents btnExportarDetalleComprobante As System.Windows.Forms.Button
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents rbtDet As System.Windows.Forms.RadioButton
        Friend WithEvents rbtNum As System.Windows.Forms.RadioButton
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cmbBodega As System.Windows.Forms.ComboBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cbmIngreso As System.Windows.Forms.ComboBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
        Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtProveedores As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents cmbConceptos As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblRazon As System.Windows.Forms.Label
        Friend WithEvents txtRazon As System.Windows.Forms.TextBox
        Friend WithEvents tsmEliminar As System.Windows.Forms.Button
        Friend WithEvents tsmAgregar As System.Windows.Forms.Button
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cmbObservacionCalidad As System.Windows.Forms.ComboBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtCodigoArticulo As System.Windows.Forms.TextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents lblIdDetalleKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdArticulo As System.Windows.Forms.Label
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents nudValor As System.Windows.Forms.NumericUpDown
        Friend WithEvents bntPuesto As System.Windows.Forms.Button
        Friend WithEvents btnSerie As System.Windows.Forms.Button
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents btnOrdenCompra As System.Windows.Forms.Button
        Friend WithEvents lblOrdenCompra As System.Windows.Forms.Label
        Friend WithEvents chkReq As System.Windows.Forms.CheckBox
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
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents TmsActualizar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblCantidadSaldo As System.Windows.Forms.Label
        Friend WithEvents lblComp As System.Windows.Forms.Label
        Friend WithEvents lblDetaComp As System.Windows.Forms.Label
        Friend WithEvents lblDetaKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex2 As System.Windows.Forms.Label
        Friend WithEvents lblIdSecuencial As System.Windows.Forms.Label
        Friend WithEvents lblCantidadInicial As System.Windows.Forms.Label
        Friend WithEvents lblDetalle As Label
        Friend WithEvents TmsEliminar As ToolStripMenuItem
        Friend WithEvents Label14 As Label
        Friend WithEvents KryptonGroupBox5 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnBuscarModi As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents txtFiltro As TextBox
    End Class
End Namespace