Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormComprobanteEgresoBodega
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteEgresoBodega))
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.btnSerie = New System.Windows.Forms.Button()
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.nudTotal = New System.Windows.Forms.NumericUpDown()
            Me.nudValor = New System.Windows.Forms.NumericUpDown()
            Me.tsmEliminar = New System.Windows.Forms.Button()
            Me.tsmAgregar = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
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
            Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
            Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex = New System.Windows.Forms.Label()
            Me.lblIdArticulo = New System.Windows.Forms.Label()
            Me.lbldetalle = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.gbxIngreso = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvDetalleComprobanteIngreso = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.ID_KAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NOMBRE_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_SECUENCIAL_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TOTAL_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OBSERVACION_INGRESO = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.DETALLES_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_UNITARIO_ANTERIOR_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_TOTAL_ANTERIOR_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SALDO_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CODIGO_CONCEPTO_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO_INVENTARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD_INICIAL_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD_TOTAL_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnEliminaringreso = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnAgregarIngreso = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.lblObservacionesTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblTotalTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtArticuloIngreso = New System.Windows.Forms.TextBox()
            Me.txtCalidadTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblValorTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblCantidadTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.btnBuscarReingreso = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.lblSerieTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblCodigoTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblArticuloTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtSerieIngreso = New System.Windows.Forms.TextBox()
            Me.nudTotalIngreso = New System.Windows.Forms.NumericUpDown()
            Me.nudValorIngreso = New System.Windows.Forms.NumericUpDown()
            Me.txtObservacionesIngreso = New System.Windows.Forms.TextBox()
            Me.cbxCalidadIngreso = New System.Windows.Forms.ComboBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.nudCantidadIngreso = New System.Windows.Forms.NumericUpDown()
            Me.lblIdDetalleKardexIngreso = New System.Windows.Forms.Label()
            Me.lblIdKardexIngreso = New System.Windows.Forms.Label()
            Me.lblIdArticuloIngreso = New System.Windows.Forms.Label()
            Me.lbldetalleIngreso = New System.Windows.Forms.Label()
            Me.txtCodigoIngreso = New System.Windows.Forms.TextBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnUniformes = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.txtIdComprobante = New System.Windows.Forms.TextBox()
            Me.crvComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmActualizar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tmsEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmReingreso = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblIdKardex2 = New System.Windows.Forms.Label()
            Me.lblDetaComp = New System.Windows.Forms.Label()
            Me.lblDetKardex = New System.Windows.Forms.Label()
            Me.lblComp = New System.Windows.Forms.Label()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.lblCantidadSaldo = New System.Windows.Forms.Label()
            Me.tbComprobanteIngresoBodega = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.gbBusquedaArticulo = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtCedulaRecibe = New System.Windows.Forms.TextBox()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.txtProveedores = New System.Windows.Forms.TextBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.cmbBodega = New System.Windows.Forms.ComboBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cmbConceptos = New System.Windows.Forms.ComboBox()
            Me.cbmEgreso = New System.Windows.Forms.ComboBox()
            Me.cmbDocumento = New System.Windows.Forms.ComboBox()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.btnExportarDetalleComprobante = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnExportarComprobantes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.gbxDetalles = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvComprobantesEgreso = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox6 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox5 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.btnBuscarModi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbxIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbxIngreso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbxIngreso.Panel.SuspendLayout()
            Me.gbxIngreso.SuspendLayout()
            CType(Me.dgvDetalleComprobanteIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotalIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValorIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidadIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.tbComprobanteIngresoBodega, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.gbBusquedaArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbBusquedaArticulo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBusquedaArticulo.Panel.SuspendLayout()
            Me.gbBusquedaArticulo.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.gbxDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gbxDetalles.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbxDetalles.Panel.SuspendLayout()
            Me.gbxDetalles.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Location = New System.Drawing.Point(626, 30)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(44, 28)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 217
            Me.pbFoto.TabStop = False
            '
            'btnSerie
            '
            Me.btnSerie.BackColor = System.Drawing.Color.Transparent
            Me.btnSerie.Enabled = False
            Me.btnSerie.FlatAppearance.BorderSize = 0
            Me.btnSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSerie.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnSerie.Location = New System.Drawing.Point(437, 1)
            Me.btnSerie.Name = "btnSerie"
            Me.btnSerie.Size = New System.Drawing.Size(26, 26)
            Me.btnSerie.TabIndex = 120
            Me.btnSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSerie.UseVisualStyleBackColor = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(351, 5)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(80, 21)
            Me.txtSerie.TabIndex = 121
            Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudTotal
            '
            Me.nudTotal.BackColor = System.Drawing.Color.White
            Me.nudTotal.DecimalPlaces = 2
            Me.nudTotal.Enabled = False
            Me.nudTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudTotal.ForeColor = System.Drawing.Color.Black
            Me.nudTotal.Location = New System.Drawing.Point(860, 3)
            Me.nudTotal.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudTotal.Name = "nudTotal"
            Me.nudTotal.Size = New System.Drawing.Size(68, 21)
            Me.nudTotal.TabIndex = 125
            Me.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudValor
            '
            Me.nudValor.BackColor = System.Drawing.Color.White
            Me.nudValor.DecimalPlaces = 2
            Me.nudValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValor.ForeColor = System.Drawing.Color.Black
            Me.nudValor.Location = New System.Drawing.Point(708, 3)
            Me.nudValor.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudValor.Name = "nudValor"
            Me.nudValor.Size = New System.Drawing.Size(85, 21)
            Me.nudValor.TabIndex = 123
            Me.nudValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'tsmEliminar
            '
            Me.tsmEliminar.BackColor = System.Drawing.Color.Transparent
            Me.tsmEliminar.Enabled = False
            Me.tsmEliminar.FlatAppearance.BorderSize = 0
            Me.tsmEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.tsmEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmEliminar.Location = New System.Drawing.Point(771, 32)
            Me.tsmEliminar.Name = "tsmEliminar"
            Me.tsmEliminar.Size = New System.Drawing.Size(28, 28)
            Me.tsmEliminar.TabIndex = 128
            Me.tsmEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmEliminar.UseVisualStyleBackColor = False
            '
            'tsmAgregar
            '
            Me.tsmAgregar.BackColor = System.Drawing.Color.Transparent
            Me.tsmAgregar.Enabled = False
            Me.tsmAgregar.FlatAppearance.BorderSize = 0
            Me.tsmAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.tsmAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmAgregar.Location = New System.Drawing.Point(735, 32)
            Me.tsmAgregar.Name = "tsmAgregar"
            Me.tsmAgregar.Size = New System.Drawing.Size(28, 28)
            Me.tsmAgregar.TabIndex = 127
            Me.tsmAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.tsmAgregar.UseVisualStyleBackColor = False
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.ForeColor = System.Drawing.Color.Black
            Me.txtObservacion.Location = New System.Drawing.Point(370, 38)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(179, 21)
            Me.txtObservacion.TabIndex = 126
            Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            Me.cmbObservacionCalidad.Location = New System.Drawing.Point(139, 37)
            Me.cmbObservacionCalidad.Name = "cmbObservacionCalidad"
            Me.cmbObservacionCalidad.Size = New System.Drawing.Size(133, 21)
            Me.cmbObservacionCalidad.TabIndex = 124
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvSecuencial.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvSecuencial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSecuencial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSecuencial.ColumnHeadersHeight = 26
            Me.dgvSecuencial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.VALOR, Me.TOTAL, Me.OBSERVACION, Me.DETALLES, Me.NUMERO_KARDEX, Me.DETALLE_KARDEX, Me.VALOR_UNITARIO_ANTERIOR, Me.VALOR_TOTAL_ANTERIOR, Me.SALDO, Me.CANTIDAD_SALDO, Me.VALOR_UNITARIO_SALDO, Me.ID_SECUENCIAL})
            Me.dgvSecuencial.GridColor = System.Drawing.Color.Black
            Me.dgvSecuencial.Location = New System.Drawing.Point(4, 66)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(941, 269)
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
            'nudCantidad
            '
            Me.nudCantidad.BackColor = System.Drawing.Color.White
            Me.nudCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidad.ForeColor = System.Drawing.Color.Black
            Me.nudCantidad.Location = New System.Drawing.Point(561, 6)
            Me.nudCantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudCantidad.Name = "nudCantidad"
            Me.nudCantidad.Size = New System.Drawing.Size(61, 21)
            Me.nudCantidad.TabIndex = 122
            Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'txtCodigoArticulo
            '
            Me.txtCodigoArticulo.BackColor = System.Drawing.Color.White
            Me.txtCodigoArticulo.Enabled = False
            Me.txtCodigoArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(133, 4)
            Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
            Me.txtCodigoArticulo.Size = New System.Drawing.Size(107, 21)
            Me.txtCodigoArticulo.TabIndex = 3
            Me.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodigoArticulo.Visible = False
            '
            'txtArticulo
            '
            Me.txtArticulo.BackColor = System.Drawing.Color.White
            Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticulo.ForeColor = System.Drawing.Color.Black
            Me.txtArticulo.Location = New System.Drawing.Point(66, 5)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(206, 21)
            Me.txtArticulo.TabIndex = 119
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblIdDetalleKardex
            '
            Me.lblIdDetalleKardex.AutoSize = True
            Me.lblIdDetalleKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardex.Location = New System.Drawing.Point(130, 11)
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
            Me.lblIdKardex.Location = New System.Drawing.Point(354, 7)
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
            Me.lblIdArticulo.Location = New System.Drawing.Point(90, 11)
            Me.lblIdArticulo.Name = "lblIdArticulo"
            Me.lblIdArticulo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticulo.TabIndex = 36
            Me.lblIdArticulo.Text = "0"
            Me.lblIdArticulo.Visible = False
            '
            'lbldetalle
            '
            Me.lbldetalle.AutoSize = True
            Me.lbldetalle.ForeColor = System.Drawing.SystemColors.Highlight
            Me.lbldetalle.Location = New System.Drawing.Point(72, 10)
            Me.lbldetalle.Name = "lbldetalle"
            Me.lbldetalle.Size = New System.Drawing.Size(13, 13)
            Me.lbldetalle.TabIndex = 218
            Me.lbldetalle.Text = "0"
            '
            'dgvDetalleComprobate
            '
            Me.dgvDetalleComprobate.AllowUserToAddRows = False
            Me.dgvDetalleComprobate.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobate.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvDetalleComprobate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleComprobate.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleComprobate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvDetalleComprobate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDetalleComprobate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvDetalleComprobate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalleComprobate.GridColor = System.Drawing.Color.Black
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(0, 0)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(945, 273)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'gbxIngreso
            '
            Me.gbxIngreso.CaptionOverlap = 0.85R
            Me.gbxIngreso.Location = New System.Drawing.Point(2, 299)
            Me.gbxIngreso.Name = "gbxIngreso"
            '
            'gbxIngreso.Panel
            '
            Me.gbxIngreso.Panel.Controls.Add(Me.dgvDetalleComprobanteIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.btnEliminaringreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.btnAgregarIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblObservacionesTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblTotalTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.txtArticuloIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.txtCalidadTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblValorTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblCantidadTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.btnBuscarReingreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblSerieTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblCodigoTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblArticuloTitulo)
            Me.gbxIngreso.Panel.Controls.Add(Me.txtSerieIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.nudTotalIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.nudValorIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.txtObservacionesIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.cbxCalidadIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.Label24)
            Me.gbxIngreso.Panel.Controls.Add(Me.nudCantidadIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblIdDetalleKardexIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblIdKardexIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lblIdArticuloIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.lbldetalleIngreso)
            Me.gbxIngreso.Panel.Controls.Add(Me.txtCodigoIngreso)
            Me.gbxIngreso.Size = New System.Drawing.Size(947, 297)
            Me.gbxIngreso.TabIndex = 154
            Me.gbxIngreso.Values.Heading = "Detalles"
            '
            'dgvDetalleComprobanteIngreso
            '
            Me.dgvDetalleComprobanteIngreso.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteIngreso.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteIngreso.AllowUserToResizeRows = False
            Me.dgvDetalleComprobanteIngreso.ColumnHeadersHeight = 24
            Me.dgvDetalleComprobanteIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvDetalleComprobanteIngreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_KAR, Me.NOMBRE_INGRESO, Me.ID_SECUENCIAL_INGRESO, Me.CANTIDAD_INGRESO, Me.VALOR_INGRESO, Me.TOTAL_INGRESO, Me.OBSERVACION_INGRESO, Me.DETALLES_INGRESO, Me.VALOR_UNITARIO_ANTERIOR_INGRESO, Me.VALOR_TOTAL_ANTERIOR_INGRESO, Me.SALDO_INGRESO, Me.FECHA_INGRESO, Me.CODIGO_CONCEPTO_INGRESO, Me.CONCEPTO_INVENTARIO, Me.CANTIDAD_INICIAL_INGRESO, Me.CANTIDAD_TOTAL_INGRESO})
            Me.dgvDetalleComprobanteIngreso.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
            Me.dgvDetalleComprobanteIngreso.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
            Me.dgvDetalleComprobanteIngreso.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
            Me.dgvDetalleComprobanteIngreso.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
            Me.dgvDetalleComprobanteIngreso.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
            Me.dgvDetalleComprobanteIngreso.Location = New System.Drawing.Point(4, 63)
            Me.dgvDetalleComprobanteIngreso.Name = "dgvDetalleComprobanteIngreso"
            Me.dgvDetalleComprobanteIngreso.RowHeadersVisible = False
            Me.dgvDetalleComprobanteIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteIngreso.Size = New System.Drawing.Size(938, 223)
            Me.dgvDetalleComprobanteIngreso.TabIndex = 258
            Me.dgvDetalleComprobanteIngreso.Visible = False
            '
            'ID_KAR
            '
            Me.ID_KAR.HeaderText = "ID KARDEX"
            Me.ID_KAR.Name = "ID_KAR"
            Me.ID_KAR.ReadOnly = True
            '
            'NOMBRE_INGRESO
            '
            Me.NOMBRE_INGRESO.HeaderText = "NOMBRE"
            Me.NOMBRE_INGRESO.Name = "NOMBRE_INGRESO"
            Me.NOMBRE_INGRESO.ReadOnly = True
            Me.NOMBRE_INGRESO.Width = 350
            '
            'ID_SECUENCIAL_INGRESO
            '
            Me.ID_SECUENCIAL_INGRESO.HeaderText = "ID SECUENCIAL"
            Me.ID_SECUENCIAL_INGRESO.Name = "ID_SECUENCIAL_INGRESO"
            Me.ID_SECUENCIAL_INGRESO.ReadOnly = True
            '
            'CANTIDAD_INGRESO
            '
            Me.CANTIDAD_INGRESO.HeaderText = "CANT"
            Me.CANTIDAD_INGRESO.Name = "CANTIDAD_INGRESO"
            Me.CANTIDAD_INGRESO.Width = 70
            '
            'VALOR_INGRESO
            '
            Me.VALOR_INGRESO.HeaderText = "VALOR"
            Me.VALOR_INGRESO.Name = "VALOR_INGRESO"
            Me.VALOR_INGRESO.ReadOnly = True
            Me.VALOR_INGRESO.Width = 70
            '
            'TOTAL_INGRESO
            '
            Me.TOTAL_INGRESO.HeaderText = "TOTAL"
            Me.TOTAL_INGRESO.Name = "TOTAL_INGRESO"
            Me.TOTAL_INGRESO.ReadOnly = True
            Me.TOTAL_INGRESO.Width = 70
            '
            'OBSERVACION_INGRESO
            '
            Me.OBSERVACION_INGRESO.HeaderText = "OBSERVACION"
            Me.OBSERVACION_INGRESO.Items.AddRange(New Object() {"NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO(DAR BAJA)"})
            Me.OBSERVACION_INGRESO.Name = "OBSERVACION_INGRESO"
            Me.OBSERVACION_INGRESO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.OBSERVACION_INGRESO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.OBSERVACION_INGRESO.Width = 130
            '
            'DETALLES_INGRESO
            '
            Me.DETALLES_INGRESO.HeaderText = "DETALLES"
            Me.DETALLES_INGRESO.Name = "DETALLES_INGRESO"
            Me.DETALLES_INGRESO.Width = 220
            '
            'VALOR_UNITARIO_ANTERIOR_INGRESO
            '
            Me.VALOR_UNITARIO_ANTERIOR_INGRESO.HeaderText = "V.U. ANTERIOR"
            Me.VALOR_UNITARIO_ANTERIOR_INGRESO.Name = "VALOR_UNITARIO_ANTERIOR_INGRESO"
            Me.VALOR_UNITARIO_ANTERIOR_INGRESO.ReadOnly = True
            Me.VALOR_UNITARIO_ANTERIOR_INGRESO.Visible = False
            '
            'VALOR_TOTAL_ANTERIOR_INGRESO
            '
            Me.VALOR_TOTAL_ANTERIOR_INGRESO.HeaderText = "V.T. ANTERIOR"
            Me.VALOR_TOTAL_ANTERIOR_INGRESO.Name = "VALOR_TOTAL_ANTERIOR_INGRESO"
            Me.VALOR_TOTAL_ANTERIOR_INGRESO.ReadOnly = True
            Me.VALOR_TOTAL_ANTERIOR_INGRESO.Visible = False
            '
            'SALDO_INGRESO
            '
            Me.SALDO_INGRESO.HeaderText = "SALDO"
            Me.SALDO_INGRESO.Name = "SALDO_INGRESO"
            Me.SALDO_INGRESO.ReadOnly = True
            Me.SALDO_INGRESO.Visible = False
            '
            'FECHA_INGRESO
            '
            Me.FECHA_INGRESO.HeaderText = "FECHA"
            Me.FECHA_INGRESO.Name = "FECHA_INGRESO"
            Me.FECHA_INGRESO.ReadOnly = True
            '
            'CODIGO_CONCEPTO_INGRESO
            '
            Me.CODIGO_CONCEPTO_INGRESO.HeaderText = "CODIGO"
            Me.CODIGO_CONCEPTO_INGRESO.Name = "CODIGO_CONCEPTO_INGRESO"
            Me.CODIGO_CONCEPTO_INGRESO.ReadOnly = True
            '
            'CONCEPTO_INVENTARIO
            '
            Me.CONCEPTO_INVENTARIO.HeaderText = "CONCEPTO"
            Me.CONCEPTO_INVENTARIO.Name = "CONCEPTO_INVENTARIO"
            Me.CONCEPTO_INVENTARIO.ReadOnly = True
            '
            'CANTIDAD_INICIAL_INGRESO
            '
            Me.CANTIDAD_INICIAL_INGRESO.HeaderText = "C. INICIAL"
            Me.CANTIDAD_INICIAL_INGRESO.Name = "CANTIDAD_INICIAL_INGRESO"
            Me.CANTIDAD_INICIAL_INGRESO.ReadOnly = True
            '
            'CANTIDAD_TOTAL_INGRESO
            '
            Me.CANTIDAD_TOTAL_INGRESO.HeaderText = "C. TOTAL"
            Me.CANTIDAD_TOTAL_INGRESO.Name = "CANTIDAD_TOTAL_INGRESO"
            Me.CANTIDAD_TOTAL_INGRESO.ReadOnly = True
            '
            'btnEliminaringreso
            '
            Me.btnEliminaringreso.Location = New System.Drawing.Point(869, 32)
            Me.btnEliminaringreso.Name = "btnEliminaringreso"
            Me.btnEliminaringreso.Size = New System.Drawing.Size(34, 25)
            Me.btnEliminaringreso.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnEliminaringreso.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnEliminaringreso.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnEliminaringreso.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-2)
            Me.btnEliminaringreso.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnEliminaringreso.TabIndex = 257
            Me.btnEliminaringreso.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnEliminaringreso.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnEliminaringreso.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnEliminaringreso.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminaringreso.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminaringreso.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_000000_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminaringreso.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_000000_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminaringreso.Values.Text = ""
            Me.btnEliminaringreso.Visible = False
            '
            'btnAgregarIngreso
            '
            Me.btnAgregarIngreso.Location = New System.Drawing.Point(823, 32)
            Me.btnAgregarIngreso.Name = "btnAgregarIngreso"
            Me.btnAgregarIngreso.Size = New System.Drawing.Size(34, 25)
            Me.btnAgregarIngreso.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnAgregarIngreso.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnAgregarIngreso.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnAgregarIngreso.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-2)
            Me.btnAgregarIngreso.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnAgregarIngreso.TabIndex = 256
            Me.btnAgregarIngreso.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnAgregarIngreso.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnAgregarIngreso.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnAgregarIngreso.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarIngreso.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarIngreso.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAgregarIngreso.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAgregarIngreso.Values.Text = ""
            Me.btnAgregarIngreso.Visible = False
            '
            'lblObservacionesTitulo
            '
            Me.lblObservacionesTitulo.Location = New System.Drawing.Point(251, 39)
            Me.lblObservacionesTitulo.Name = "lblObservacionesTitulo"
            Me.lblObservacionesTitulo.Size = New System.Drawing.Size(92, 18)
            Me.lblObservacionesTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacionesTitulo.TabIndex = 255
            Me.lblObservacionesTitulo.Values.Text = "Observaciones"
            Me.lblObservacionesTitulo.Visible = False
            '
            'lblTotalTitulo
            '
            Me.lblTotalTitulo.Location = New System.Drawing.Point(749, 8)
            Me.lblTotalTitulo.Name = "lblTotalTitulo"
            Me.lblTotalTitulo.Size = New System.Drawing.Size(39, 18)
            Me.lblTotalTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalTitulo.TabIndex = 254
            Me.lblTotalTitulo.Values.Text = "Total"
            Me.lblTotalTitulo.Visible = False
            '
            'txtArticuloIngreso
            '
            Me.txtArticuloIngreso.BackColor = System.Drawing.Color.White
            Me.txtArticuloIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticuloIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticuloIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtArticuloIngreso.Location = New System.Drawing.Point(71, 8)
            Me.txtArticuloIngreso.Name = "txtArticuloIngreso"
            Me.txtArticuloIngreso.Size = New System.Drawing.Size(170, 21)
            Me.txtArticuloIngreso.TabIndex = 224
            Me.txtArticuloIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtArticuloIngreso.Visible = False
            '
            'txtCalidadTitulo
            '
            Me.txtCalidadTitulo.Location = New System.Drawing.Point(9, 38)
            Me.txtCalidadTitulo.Name = "txtCalidadTitulo"
            Me.txtCalidadTitulo.Size = New System.Drawing.Size(101, 18)
            Me.txtCalidadTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCalidadTitulo.TabIndex = 253
            Me.txtCalidadTitulo.Values.Text = "Estado / Calidad"
            Me.txtCalidadTitulo.Visible = False
            '
            'lblValorTitulo
            '
            Me.lblValorTitulo.Location = New System.Drawing.Point(586, 11)
            Me.lblValorTitulo.Name = "lblValorTitulo"
            Me.lblValorTitulo.Size = New System.Drawing.Size(39, 18)
            Me.lblValorTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorTitulo.TabIndex = 252
            Me.lblValorTitulo.Values.Text = "Valor"
            Me.lblValorTitulo.Visible = False
            '
            'lblCantidadTitulo
            '
            Me.lblCantidadTitulo.Location = New System.Drawing.Point(444, 9)
            Me.lblCantidadTitulo.Name = "lblCantidadTitulo"
            Me.lblCantidadTitulo.Size = New System.Drawing.Size(60, 18)
            Me.lblCantidadTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadTitulo.TabIndex = 251
            Me.lblCantidadTitulo.Values.Text = "Cantidad"
            Me.lblCantidadTitulo.Visible = False
            '
            'btnBuscarReingreso
            '
            Me.btnBuscarReingreso.AutoSize = True
            Me.btnBuscarReingreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarReingreso.Location = New System.Drawing.Point(406, 1)
            Me.btnBuscarReingreso.Name = "btnBuscarReingreso"
            Me.btnBuscarReingreso.Size = New System.Drawing.Size(32, 32)
            Me.btnBuscarReingreso.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarReingreso.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.btnBuscarReingreso.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.btnBuscarReingreso.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.btnBuscarReingreso.TabIndex = 250
            Me.btnBuscarReingreso.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnBuscarReingreso.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnBuscarReingreso.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnBuscarReingreso.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarReingreso.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarReingreso.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarReingreso.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.btnBuscarReingreso.Values.Text = ""
            Me.btnBuscarReingreso.Visible = False
            '
            'lblSerieTitulo
            '
            Me.lblSerieTitulo.Location = New System.Drawing.Point(251, 9)
            Me.lblSerieTitulo.Name = "lblSerieTitulo"
            Me.lblSerieTitulo.Size = New System.Drawing.Size(38, 18)
            Me.lblSerieTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSerieTitulo.TabIndex = 245
            Me.lblSerieTitulo.Values.Text = "Serie"
            Me.lblSerieTitulo.Visible = False
            '
            'lblCodigoTitulo
            '
            Me.lblCodigoTitulo.Location = New System.Drawing.Point(159, 9)
            Me.lblCodigoTitulo.Name = "lblCodigoTitulo"
            Me.lblCodigoTitulo.Size = New System.Drawing.Size(50, 18)
            Me.lblCodigoTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoTitulo.TabIndex = 244
            Me.lblCodigoTitulo.Values.Text = "Codigo"
            Me.lblCodigoTitulo.Visible = False
            '
            'lblArticuloTitulo
            '
            Me.lblArticuloTitulo.Location = New System.Drawing.Point(12, 9)
            Me.lblArticuloTitulo.Name = "lblArticuloTitulo"
            Me.lblArticuloTitulo.Size = New System.Drawing.Size(53, 18)
            Me.lblArticuloTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblArticuloTitulo.TabIndex = 243
            Me.lblArticuloTitulo.Values.Text = "Articulo"
            Me.lblArticuloTitulo.Visible = False
            '
            'txtSerieIngreso
            '
            Me.txtSerieIngreso.BackColor = System.Drawing.Color.White
            Me.txtSerieIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerieIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtSerieIngreso.Location = New System.Drawing.Point(295, 8)
            Me.txtSerieIngreso.Name = "txtSerieIngreso"
            Me.txtSerieIngreso.Size = New System.Drawing.Size(101, 21)
            Me.txtSerieIngreso.TabIndex = 226
            Me.txtSerieIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtSerieIngreso.Visible = False
            '
            'nudTotalIngreso
            '
            Me.nudTotalIngreso.BackColor = System.Drawing.Color.White
            Me.nudTotalIngreso.DecimalPlaces = 2
            Me.nudTotalIngreso.Enabled = False
            Me.nudTotalIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudTotalIngreso.ForeColor = System.Drawing.Color.Black
            Me.nudTotalIngreso.Location = New System.Drawing.Point(823, 6)
            Me.nudTotalIngreso.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudTotalIngreso.Name = "nudTotalIngreso"
            Me.nudTotalIngreso.Size = New System.Drawing.Size(80, 21)
            Me.nudTotalIngreso.TabIndex = 230
            Me.nudTotalIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudTotalIngreso.Visible = False
            '
            'nudValorIngreso
            '
            Me.nudValorIngreso.BackColor = System.Drawing.Color.White
            Me.nudValorIngreso.DecimalPlaces = 2
            Me.nudValorIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValorIngreso.ForeColor = System.Drawing.Color.Black
            Me.nudValorIngreso.Location = New System.Drawing.Point(641, 8)
            Me.nudValorIngreso.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudValorIngreso.Name = "nudValorIngreso"
            Me.nudValorIngreso.Size = New System.Drawing.Size(85, 21)
            Me.nudValorIngreso.TabIndex = 228
            Me.nudValorIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudValorIngreso.Visible = False
            '
            'txtObservacionesIngreso
            '
            Me.txtObservacionesIngreso.BackColor = System.Drawing.Color.White
            Me.txtObservacionesIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacionesIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacionesIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtObservacionesIngreso.Location = New System.Drawing.Point(392, 35)
            Me.txtObservacionesIngreso.MaxLength = 255
            Me.txtObservacionesIngreso.Multiline = True
            Me.txtObservacionesIngreso.Name = "txtObservacionesIngreso"
            Me.txtObservacionesIngreso.Size = New System.Drawing.Size(182, 21)
            Me.txtObservacionesIngreso.TabIndex = 231
            Me.txtObservacionesIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtObservacionesIngreso.Visible = False
            '
            'cbxCalidadIngreso
            '
            Me.cbxCalidadIngreso.BackColor = System.Drawing.Color.White
            Me.cbxCalidadIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxCalidadIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxCalidadIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxCalidadIngreso.ForeColor = System.Drawing.Color.Black
            Me.cbxCalidadIngreso.FormattingEnabled = True
            Me.cbxCalidadIngreso.Items.AddRange(New Object() {"-- ESTADO --", "NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO (DAR BAJA)"})
            Me.cbxCalidadIngreso.Location = New System.Drawing.Point(119, 36)
            Me.cbxCalidadIngreso.Name = "cbxCalidadIngreso"
            Me.cbxCalidadIngreso.Size = New System.Drawing.Size(122, 21)
            Me.cbxCalidadIngreso.TabIndex = 229
            Me.cbxCalidadIngreso.Visible = False
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.Black
            Me.Label24.Location = New System.Drawing.Point(425, 1)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(0, 13)
            Me.Label24.TabIndex = 236
            '
            'nudCantidadIngreso
            '
            Me.nudCantidadIngreso.BackColor = System.Drawing.Color.White
            Me.nudCantidadIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidadIngreso.ForeColor = System.Drawing.Color.Black
            Me.nudCantidadIngreso.Location = New System.Drawing.Point(513, 8)
            Me.nudCantidadIngreso.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudCantidadIngreso.Name = "nudCantidadIngreso"
            Me.nudCantidadIngreso.Size = New System.Drawing.Size(61, 21)
            Me.nudCantidadIngreso.TabIndex = 227
            Me.nudCantidadIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidadIngreso.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudCantidadIngreso.Visible = False
            '
            'lblIdDetalleKardexIngreso
            '
            Me.lblIdDetalleKardexIngreso.AutoSize = True
            Me.lblIdDetalleKardexIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardexIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardexIngreso.Location = New System.Drawing.Point(172, 14)
            Me.lblIdDetalleKardexIngreso.Name = "lblIdDetalleKardexIngreso"
            Me.lblIdDetalleKardexIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleKardexIngreso.TabIndex = 235
            Me.lblIdDetalleKardexIngreso.Text = "0"
            Me.lblIdDetalleKardexIngreso.Visible = False
            '
            'lblIdKardexIngreso
            '
            Me.lblIdKardexIngreso.AutoSize = True
            Me.lblIdKardexIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdKardexIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdKardexIngreso.Location = New System.Drawing.Point(145, 14)
            Me.lblIdKardexIngreso.Name = "lblIdKardexIngreso"
            Me.lblIdKardexIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lblIdKardexIngreso.TabIndex = 234
            Me.lblIdKardexIngreso.Text = "0"
            Me.lblIdKardexIngreso.Visible = False
            '
            'lblIdArticuloIngreso
            '
            Me.lblIdArticuloIngreso.AutoSize = True
            Me.lblIdArticuloIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdArticuloIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdArticuloIngreso.Location = New System.Drawing.Point(124, 14)
            Me.lblIdArticuloIngreso.Name = "lblIdArticuloIngreso"
            Me.lblIdArticuloIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticuloIngreso.TabIndex = 223
            Me.lblIdArticuloIngreso.Text = "0"
            Me.lblIdArticuloIngreso.Visible = False
            '
            'lbldetalleIngreso
            '
            Me.lbldetalleIngreso.AutoSize = True
            Me.lbldetalleIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbldetalleIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lbldetalleIngreso.Location = New System.Drawing.Point(83, 12)
            Me.lbldetalleIngreso.Name = "lbldetalleIngreso"
            Me.lbldetalleIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lbldetalleIngreso.TabIndex = 259
            Me.lbldetalleIngreso.Text = "0"
            Me.lbldetalleIngreso.Visible = False
            '
            'txtCodigoIngreso
            '
            Me.txtCodigoIngreso.BackColor = System.Drawing.Color.White
            Me.txtCodigoIngreso.Enabled = False
            Me.txtCodigoIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtCodigoIngreso.Location = New System.Drawing.Point(86, 8)
            Me.txtCodigoIngreso.Name = "txtCodigoIngreso"
            Me.txtCodigoIngreso.Size = New System.Drawing.Size(95, 21)
            Me.txtCodigoIngreso.TabIndex = 218
            Me.txtCodigoIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodigoIngreso.Visible = False
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(5, 6)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(946, 600)
            Me.TabControl1.TabIndex = 153
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.btnUniformes)
            Me.TabPage1.Controls.Add(Me.Button1)
            Me.TabPage1.Controls.Add(Me.txtIdComprobante)
            Me.TabPage1.Controls.Add(Me.crvComprobante)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(938, 574)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Comprobante"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'btnUniformes
            '
            Me.btnUniformes.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnUniformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUniformes.Location = New System.Drawing.Point(804, 2)
            Me.btnUniformes.Name = "btnUniformes"
            Me.btnUniformes.Size = New System.Drawing.Size(117, 30)
            Me.btnUniformes.TabIndex = 153
            Me.btnUniformes.Text = "UNIFORMES"
            Me.btnUniformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnUniformes.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.Transparent
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(652, 3)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(126, 30)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "COMPROBANTE"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            '
            'txtIdComprobante
            '
            Me.txtIdComprobante.Location = New System.Drawing.Point(514, 9)
            Me.txtIdComprobante.Name = "txtIdComprobante"
            Me.txtIdComprobante.Size = New System.Drawing.Size(110, 22)
            Me.txtIdComprobante.TabIndex = 6
            Me.txtIdComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'crvComprobante
            '
            Me.crvComprobante.ActiveViewIndex = -1
            Me.crvComprobante.AutoSize = True
            Me.crvComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvComprobante.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvComprobante.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvComprobante.ForeColor = System.Drawing.SystemColors.ControlText
            Me.crvComprobante.Location = New System.Drawing.Point(3, 3)
            Me.crvComprobante.Name = "crvComprobante"
            Me.crvComprobante.ShowLogo = False
            Me.crvComprobante.Size = New System.Drawing.Size(932, 568)
            Me.crvComprobante.TabIndex = 152
            Me.crvComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(938, 574)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Imagen Adjunta"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(932, 568)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar, Me.tsmActualizar, Me.tmsEliminar, Me.tsmReingreso})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(952, 32)
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
            'tmsEliminar
            '
            Me.tmsEliminar.Enabled = False
            Me.tmsEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tmsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tmsEliminar.Name = "tmsEliminar"
            Me.tmsEliminar.Size = New System.Drawing.Size(89, 28)
            Me.tmsEliminar.Text = "ANULAR"
            '
            'tsmReingreso
            '
            Me.tsmReingreso.Enabled = False
            Me.tsmReingreso.Image = Global.syscisepro.My.Resources.Resources.edit_square_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmReingreso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmReingreso.Name = "tsmReingreso"
            Me.tsmReingreso.Size = New System.Drawing.Size(104, 28)
            Me.tsmReingreso.Text = "REINGRESO"
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
            'tbComprobanteIngresoBodega
            '
            Me.tbComprobanteIngresoBodega.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.tbComprobanteIngresoBodega.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.tbComprobanteIngresoBodega.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbComprobanteIngresoBodega.Location = New System.Drawing.Point(0, 32)
            Me.tbComprobanteIngresoBodega.Name = "tbComprobanteIngresoBodega"
            Me.tbComprobanteIngresoBodega.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2, Me.KryptonPage3})
            Me.tbComprobanteIngresoBodega.SelectedIndex = 0
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(952, 628)
            Me.tbComprobanteIngresoBodega.TabIndex = 194
            Me.tbComprobanteIngresoBodega.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.gbBusquedaArticulo)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(950, 601)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Registro"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "A1A45DA1DBE94048219F810DE607EFFF"
            '
            'gbBusquedaArticulo
            '
            Me.gbBusquedaArticulo.CaptionOverlap = 0.85R
            Me.gbBusquedaArticulo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(2, 199)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            '
            'gbBusquedaArticulo.Panel
            '
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.Label11)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel29)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.pbFoto)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel28)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel27)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel26)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.tsmEliminar)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.dgvSecuencial)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel25)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.tsmAgregar)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel24)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel23)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel22)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtObservacion)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.nudTotal)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.btnSerie)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtCodigoArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lbldetalle)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtSerie)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.nudValor)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdDetalleKardex)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdKardex)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.cmbObservacionCalidad)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.nudCantidad)
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(952, 391)
            Me.gbBusquedaArticulo.TabIndex = 195
            Me.gbBusquedaArticulo.Values.Heading = "Detalles Comprobante"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Label11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(56, 342)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(0, 15)
            Me.Label11.TabIndex = 226
            '
            'KryptonLabel29
            '
            Me.KryptonLabel29.Location = New System.Drawing.Point(561, 39)
            Me.KryptonLabel29.Name = "KryptonLabel29"
            Me.KryptonLabel29.Size = New System.Drawing.Size(35, 20)
            Me.KryptonLabel29.TabIndex = 225
            Me.KryptonLabel29.Values.Text = "Foto"
            '
            'KryptonLabel28
            '
            Me.KryptonLabel28.Location = New System.Drawing.Point(281, 38)
            Me.KryptonLabel28.Name = "KryptonLabel28"
            Me.KryptonLabel28.Size = New System.Drawing.Size(78, 20)
            Me.KryptonLabel28.TabIndex = 224
            Me.KryptonLabel28.Values.Text = "Observacion"
            '
            'KryptonLabel27
            '
            Me.KryptonLabel27.Location = New System.Drawing.Point(7, 38)
            Me.KryptonLabel27.Name = "KryptonLabel27"
            Me.KryptonLabel27.Size = New System.Drawing.Size(99, 20)
            Me.KryptonLabel27.TabIndex = 223
            Me.KryptonLabel27.Values.Text = "Estado / Calidad"
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(806, 4)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel26.TabIndex = 222
            Me.KryptonLabel26.Values.Text = "Total"
            '
            'KryptonLabel25
            '
            Me.KryptonLabel25.Location = New System.Drawing.Point(648, 4)
            Me.KryptonLabel25.Name = "KryptonLabel25"
            Me.KryptonLabel25.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel25.TabIndex = 221
            Me.KryptonLabel25.Values.Text = "Valor"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(490, 5)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel24.TabIndex = 220
            Me.KryptonLabel24.Values.Text = "Cantidad"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(281, 5)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(37, 20)
            Me.KryptonLabel23.TabIndex = 219
            Me.KryptonLabel23.Values.Text = "Serie"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(3, 6)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel22.TabIndex = 121
            Me.KryptonLabel22.Values.Text = "Buscar"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0.85R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 2)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedulaRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtUbicacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazon)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtProveedores)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNumero)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBodega)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombre)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCódigo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedula)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbConceptos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmEgreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroDocumento)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(954, 195)
            Me.KryptonGroupBox1.TabIndex = 1
            Me.KryptonGroupBox1.Values.Heading = "Comprobante Egreso"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(487, 143)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel21.TabIndex = 150
            Me.KryptonLabel21.Values.Text = "Ubicacion"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(283, 141)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel20.TabIndex = 121
            Me.KryptonLabel20.Values.Text = "Cedula"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(6, 141)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel19.TabIndex = 120
            Me.KryptonLabel19.Values.Text = "Recibe"
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.Transparent
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.bntPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntPuesto.Location = New System.Drawing.Point(866, 129)
            Me.bntPuesto.Name = "bntPuesto"
            Me.bntPuesto.Size = New System.Drawing.Size(28, 28)
            Me.bntPuesto.TabIndex = 116
            Me.bntPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntPuesto.UseVisualStyleBackColor = False
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(721, 70)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel18.TabIndex = 119
            Me.KryptonLabel18.Values.Text = "Razon"
            '
            'txtCedulaRecibe
            '
            Me.txtCedulaRecibe.BackColor = System.Drawing.Color.White
            Me.txtCedulaRecibe.Enabled = False
            Me.txtCedulaRecibe.Location = New System.Drawing.Point(353, 141)
            Me.txtCedulaRecibe.Name = "txtCedulaRecibe"
            Me.txtCedulaRecibe.Size = New System.Drawing.Size(85, 22)
            Me.txtCedulaRecibe.TabIndex = 149
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(431, 105)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(120, 20)
            Me.KryptonLabel17.TabIndex = 117
            Me.KryptonLabel17.Values.Text = "Proveedor / Entrega"
            '
            'txtUbicacion
            '
            Me.txtUbicacion.BackColor = System.Drawing.Color.White
            Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacion.Enabled = False
            Me.txtUbicacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacion.ForeColor = System.Drawing.Color.Black
            Me.txtUbicacion.Location = New System.Drawing.Point(563, 129)
            Me.txtUbicacion.Multiline = True
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(287, 30)
            Me.txtUbicacion.TabIndex = 117
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(283, 104)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel16.TabIndex = 116
            Me.KryptonLabel16.Values.Text = "Codigo"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(3, 103)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel15.TabIndex = 115
            Me.KryptonLabel15.Values.Text = "Concepto"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(3, 71)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel14.TabIndex = 114
            Me.KryptonLabel14.Values.Text = "Documento"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(283, 70)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel13.TabIndex = 113
            Me.KryptonLabel13.Values.Text = "Fecha"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(520, 70)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel12.TabIndex = 112
            Me.KryptonLabel12.Values.Text = "Nro"
            '
            'txtRecibe
            '
            Me.txtRecibe.BackColor = System.Drawing.Color.White
            Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecibe.Enabled = False
            Me.txtRecibe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtRecibe.Location = New System.Drawing.Point(68, 140)
            Me.txtRecibe.Name = "txtRecibe"
            Me.txtRecibe.Size = New System.Drawing.Size(206, 21)
            Me.txtRecibe.TabIndex = 115
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(722, 36)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel11.TabIndex = 110
            Me.KryptonLabel11.Values.Text = "Actividad"
            '
            'txtRazon
            '
            Me.txtRazon.BackColor = System.Drawing.Color.White
            Me.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazon.Enabled = False
            Me.txtRazon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazon.ForeColor = System.Drawing.Color.Black
            Me.txtRazon.Location = New System.Drawing.Point(784, 71)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.Size = New System.Drawing.Size(146, 54)
            Me.txtRazon.TabIndex = 118
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(472, 37)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel10.TabIndex = 109
            Me.KryptonLabel10.Values.Text = "Centro Costo"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(283, 39)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel9.TabIndex = 108
            Me.KryptonLabel9.Values.Text = "Cedula"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(3, 38)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel8.TabIndex = 107
            Me.KryptonLabel8.Values.Text = "Custodio"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(721, 4)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 106
            Me.KryptonLabel7.Values.Text = "Parroquia"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(505, 6)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel6.TabIndex = 105
            Me.KryptonLabel6.Values.Text = "Ciudad"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(283, 6)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel5.TabIndex = 104
            Me.KryptonLabel5.Values.Text = "Provincia"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(119, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel2.TabIndex = 102
            Me.KryptonLabel2.Values.Text = "Bodega"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 101
            Me.KryptonLabel1.Values.Text = "Nro"
            '
            'txtProveedores
            '
            Me.txtProveedores.BackColor = System.Drawing.Color.White
            Me.txtProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtProveedores.Enabled = False
            Me.txtProveedores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedores.ForeColor = System.Drawing.Color.Black
            Me.txtProveedores.Location = New System.Drawing.Point(563, 104)
            Me.txtProveedores.Name = "txtProveedores"
            Me.txtProveedores.Size = New System.Drawing.Size(202, 21)
            Me.txtProveedores.TabIndex = 114
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
            Me.cbmParroquia.Location = New System.Drawing.Point(792, 6)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(138, 21)
            Me.cbmParroquia.TabIndex = 105
            '
            'txtNumero
            '
            Me.txtNumero.BackColor = System.Drawing.Color.White
            Me.txtNumero.Enabled = False
            Me.txtNumero.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumero.Location = New System.Drawing.Point(40, 3)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(73, 21)
            Me.txtNumero.TabIndex = 100
            Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbBodega
            '
            Me.cmbBodega.BackColor = System.Drawing.Color.White
            Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBodega.Enabled = False
            Me.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBodega.FormattingEnabled = True
            Me.cmbBodega.ItemHeight = 13
            Me.cmbBodega.Location = New System.Drawing.Point(171, 5)
            Me.cmbBodega.Name = "cmbBodega"
            Me.cmbBodega.Size = New System.Drawing.Size(103, 21)
            Me.cmbBodega.TabIndex = 102
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
            Me.cbmProvincia.Location = New System.Drawing.Point(356, 7)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(138, 21)
            Me.cbmProvincia.TabIndex = 103
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
            Me.cbmCanton.Location = New System.Drawing.Point(563, 5)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(138, 21)
            Me.cbmCanton.TabIndex = 104
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(356, 71)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(100, 21)
            Me.dtpFecha.TabIndex = 111
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(68, 38)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(206, 21)
            Me.txtNombre.TabIndex = 106
            '
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.ForeColor = System.Drawing.Color.Black
            Me.txtCódigo.Location = New System.Drawing.Point(356, 103)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(53, 21)
            Me.txtCódigo.TabIndex = 13
            Me.txtCódigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(356, 37)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(82, 21)
            Me.txtCedula.TabIndex = 10
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            Me.cbmCentroCosto.Location = New System.Drawing.Point(563, 37)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(138, 21)
            Me.cbmCentroCosto.TabIndex = 107
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
            Me.cmbConceptos.Location = New System.Drawing.Point(84, 102)
            Me.cmbConceptos.Name = "cmbConceptos"
            Me.cmbConceptos.Size = New System.Drawing.Size(190, 21)
            Me.cmbConceptos.TabIndex = 113
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
            Me.cbmEgreso.Location = New System.Drawing.Point(830, 39)
            Me.cbmEgreso.Name = "cbmEgreso"
            Me.cbmEgreso.Size = New System.Drawing.Size(100, 21)
            Me.cbmEgreso.TabIndex = 108
            '
            'cmbDocumento
            '
            Me.cmbDocumento.BackColor = System.Drawing.Color.White
            Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbDocumento.Enabled = False
            Me.cmbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbDocumento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbDocumento.FormattingEnabled = True
            Me.cmbDocumento.Location = New System.Drawing.Point(84, 71)
            Me.cmbDocumento.Name = "cmbDocumento"
            Me.cmbDocumento.Size = New System.Drawing.Size(106, 21)
            Me.cmbDocumento.TabIndex = 109
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDocumento.Location = New System.Drawing.Point(563, 71)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.Size = New System.Drawing.Size(68, 21)
            Me.txtNroDocumento.TabIndex = 110
            Me.txtNroDocumento.Text = "S/N"
            Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.KryptonPage2.Controls.Add(Me.btnExportarComprobantes)
            Me.KryptonPage2.Controls.Add(Me.gbxDetalles)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox6)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox5)
            Me.KryptonPage2.Controls.Add(Me.gbxIngreso)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(950, 601)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Consultar"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "15F0A501768844E4AE98667FC32CB704"
            '
            'btnExportarDetalleComprobante
            '
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(832, 287)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(89, 25)
            Me.btnExportarDetalleComprobante.TabIndex = 198
            Me.btnExportarDetalleComprobante.Values.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportarDetalleComprobante.Values.Text = "Exportar"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(827, 55)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(89, 25)
            Me.btnExportarComprobantes.TabIndex = 197
            Me.btnExportarComprobantes.Values.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportarComprobantes.Values.Text = "Exportar"
            '
            'gbxDetalles
            '
            Me.gbxDetalles.CaptionOverlap = 0.85R
            Me.gbxDetalles.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.gbxDetalles.Location = New System.Drawing.Point(2, 299)
            Me.gbxDetalles.Name = "gbxDetalles"
            '
            'gbxDetalles.Panel
            '
            Me.gbxDetalles.Panel.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbxDetalles.Size = New System.Drawing.Size(949, 297)
            Me.gbxDetalles.TabIndex = 196
            Me.gbxDetalles.Values.Heading = "Detalles Comprobante"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0.85R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(3, 66)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvComprobantesEgreso)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(949, 218)
            Me.KryptonGroupBox3.TabIndex = 195
            Me.KryptonGroupBox3.Values.Heading = "Comprobante"
            '
            'dgvComprobantesEgreso
            '
            Me.dgvComprobantesEgreso.AllowUserToAddRows = False
            Me.dgvComprobantesEgreso.AllowUserToDeleteRows = False
            Me.dgvComprobantesEgreso.AllowUserToResizeRows = False
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesEgreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobantesEgreso.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobantesEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesEgreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvComprobantesEgreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesEgreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobantesEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesEgreso.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobantesEgreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesEgreso.GridColor = System.Drawing.Color.Black
            Me.dgvComprobantesEgreso.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprobantesEgreso.MultiSelect = False
            Me.dgvComprobantesEgreso.Name = "dgvComprobantesEgreso"
            Me.dgvComprobantesEgreso.ReadOnly = True
            Me.dgvComprobantesEgreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesEgreso.RowHeadersVisible = False
            Me.dgvComprobantesEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesEgreso.Size = New System.Drawing.Size(945, 194)
            Me.dgvComprobantesEgreso.TabIndex = 145
            '
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.CaptionOverlap = 0R
            Me.KryptonGroupBox6.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(3, 2)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(452, 62)
            Me.KryptonGroupBox6.TabIndex = 157
            Me.KryptonGroupBox6.Values.Heading = "Fechas"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(251, 8)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(180, 21)
            Me.dtpFechaHasta.TabIndex = 11
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(36, 8)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(168, 21)
            Me.dtpFechaDesde.TabIndex = 10
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(219, 9)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(18, 20)
            Me.KryptonLabel3.TabIndex = 9
            Me.KryptonLabel3.Values.Text = "A"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(4, 9)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(26, 20)
            Me.KryptonLabel4.TabIndex = 8
            Me.KryptonLabel4.Values.Text = "De"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(459, 2)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnBuscarModi)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(266, 61)
            Me.KryptonGroupBox5.TabIndex = 156
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            '
            'btnBuscarModi
            '
            Me.btnBuscarModi.AutoSize = True
            Me.btnBuscarModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarModi.Location = New System.Drawing.Point(218, 3)
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
            Me.txtFiltro.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(16, 8)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(189, 21)
            Me.txtFiltro.TabIndex = 13
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.TabControl1)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(950, 601)
            Me.KryptonPage3.Text = "Reporte"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "CF1859721FEB44DA25A4318F18E1F105"
            '
            'FormComprobanteEgresoBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(952, 660)
            Me.Controls.Add(Me.tbComprobanteIngresoBodega)
            Me.Controls.Add(Me.lblCantidadSaldo)
            Me.Controls.Add(Me.lblIdSecuencial)
            Me.Controls.Add(Me.lblComp)
            Me.Controls.Add(Me.lblDetKardex)
            Me.Controls.Add(Me.lblDetaComp)
            Me.Controls.Add(Me.lblIdKardex2)
            Me.Controls.Add(Me.MenuStrip1)
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
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gbxIngreso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbxIngreso.Panel.ResumeLayout(False)
            Me.gbxIngreso.Panel.PerformLayout()
            CType(Me.gbxIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbxIngreso.ResumeLayout(False)
            CType(Me.dgvDetalleComprobanteIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTotalIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValorIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidadIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.tbComprobanteIngresoBodega, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tbComprobanteIngresoBodega.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.gbBusquedaArticulo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBusquedaArticulo.Panel.ResumeLayout(False)
            Me.gbBusquedaArticulo.Panel.PerformLayout()
            CType(Me.gbBusquedaArticulo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBusquedaArticulo.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.gbxDetalles.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbxDetalles.Panel.ResumeLayout(False)
            CType(Me.gbxDetalles, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbxDetalles.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.Panel.ResumeLayout(False)
            Me.KryptonGroupBox6.Panel.PerformLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.ResumeLayout(False)
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdDetalleKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdArticulo As System.Windows.Forms.Label
        Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtCodigoArticulo As System.Windows.Forms.TextBox
        Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents crvComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents txtIdComprobante As System.Windows.Forms.TextBox
        Friend WithEvents cmbObservacionCalidad As System.Windows.Forms.ComboBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmEliminar As System.Windows.Forms.Button
        Friend WithEvents tsmAgregar As System.Windows.Forms.Button
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
        Friend WithEvents nudTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents btnSerie As System.Windows.Forms.Button
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
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
        Friend WithEvents lbldetalle As Label
        Friend WithEvents tmsEliminar As ToolStripMenuItem
        Friend WithEvents btnUniformes As Button
        Friend WithEvents tsmReingreso As ToolStripMenuItem
        Friend WithEvents gbxIngreso As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents lblTotalTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtCalidadTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblValorTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblCantidadTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents btnBuscarReingreso As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents lblSerieTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblCodigoTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblArticuloTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtSerieIngreso As TextBox
        Friend WithEvents nudTotalIngreso As NumericUpDown
        Friend WithEvents nudValorIngreso As NumericUpDown
        Friend WithEvents txtObservacionesIngreso As TextBox
        Friend WithEvents cbxCalidadIngreso As ComboBox
        Friend WithEvents Label24 As Label
        Friend WithEvents nudCantidadIngreso As NumericUpDown
        Friend WithEvents txtCodigoIngreso As TextBox
        Friend WithEvents txtArticuloIngreso As TextBox
        Friend WithEvents lblIdDetalleKardexIngreso As Label
        Friend WithEvents lblIdKardexIngreso As Label
        Friend WithEvents lblIdArticuloIngreso As Label
        Friend WithEvents lblObservacionesTitulo As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents btnAgregarIngreso As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents btnEliminaringreso As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents dgvDetalleComprobanteIngreso As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Friend WithEvents lbldetalleIngreso As Label
        Friend WithEvents ID_KAR As DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents ID_SECUENCIAL_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents TOTAL_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents OBSERVACION_INGRESO As DataGridViewComboBoxColumn
        Friend WithEvents DETALLES_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_UNITARIO_ANTERIOR_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_TOTAL_ANTERIOR_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents SALDO_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents FECHA_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents CODIGO_CONCEPTO_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO_INVENTARIO As DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD_INICIAL_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD_TOTAL_INGRESO As DataGridViewTextBoxColumn
        Friend WithEvents tbComprobanteIngresoBodega As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents bntPuesto As Button
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtCedulaRecibe As TextBox
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtUbicacion As TextBox
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtRecibe As TextBox
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtRazon As TextBox
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents txtProveedores As TextBox
        Friend WithEvents cbmParroquia As ComboBox
        Friend WithEvents txtNumero As TextBox
        Friend WithEvents cmbBodega As ComboBox
        Friend WithEvents cbmProvincia As ComboBox
        Friend WithEvents cbmCanton As ComboBox
        Friend WithEvents dtpFecha As DateTimePicker
        Friend WithEvents txtNombre As TextBox
        Friend WithEvents txtCódigo As TextBox
        Friend WithEvents txtCedula As TextBox
        Friend WithEvents cbmCentroCosto As ComboBox
        Friend WithEvents cmbConceptos As ComboBox
        Friend WithEvents cbmEgreso As ComboBox
        Friend WithEvents cmbDocumento As ComboBox
        Friend WithEvents txtNroDocumento As TextBox
        Friend WithEvents gbBusquedaArticulo As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents Label11 As Label
        Friend WithEvents KryptonGroupBox6 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dtpFechaHasta As DateTimePicker
        Friend WithEvents dtpFechaDesde As DateTimePicker
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox5 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnBuscarModi As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents txtFiltro As TextBox
        Friend WithEvents dgvComprobantesEgreso As DataGridView
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents gbxDetalles As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents btnExportarDetalleComprobante As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents btnExportarComprobantes As ComponentFactory.Krypton.Toolkit.KryptonButton
    End Class
End Namespace