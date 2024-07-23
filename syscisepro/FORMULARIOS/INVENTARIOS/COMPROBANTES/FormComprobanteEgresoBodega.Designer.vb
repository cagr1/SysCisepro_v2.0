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
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteEgresoBodega))
            Me.tbComprobanteIngresoBodega = New System.Windows.Forms.TabControl()
            Me.tpRegistro = New System.Windows.Forms.TabPage()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtCedulaRecibe = New System.Windows.Forms.TextBox()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.lblRecibe = New System.Windows.Forms.Label()
            Me.gbBusquedaArticulo = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
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
            Me.lbldetalle = New System.Windows.Forms.Label()
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
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvDetalleComprobanteIngreso = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
            Me.btnEliminaringreso = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnAgregarIngreso = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.lblObservacionesTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblTotalTitulo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
            Me.txtArticuloIngreso = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleKardexIngreso = New System.Windows.Forms.Label()
            Me.lblIdKardexIngreso = New System.Windows.Forms.Label()
            Me.lblIdArticuloIngreso = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.lbldetalleIngreso = New System.Windows.Forms.Label()
            Me.txtCodigoIngreso = New System.Windows.Forms.TextBox()
            Me.KryptonGroupBox6 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox5 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.btnBuscarModi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.dgvComprobantesEgreso = New System.Windows.Forms.DataGridView()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.btnUniformes = New System.Windows.Forms.Button()
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
            Me.tmsEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmReingreso = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblIdKardex2 = New System.Windows.Forms.Label()
            Me.lblDetaComp = New System.Windows.Forms.Label()
            Me.lblDetKardex = New System.Windows.Forms.Label()
            Me.lblComp = New System.Windows.Forms.Label()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.lblCantidadSaldo = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            Me.tpRegistro.SuspendLayout()
            Me.gbBusquedaArticulo.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultar.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.dgvDetalleComprobanteIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudTotalIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValorIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidadIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            Me.gbComprobante.SuspendLayout()
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
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
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(1268, 620)
            Me.tbComprobanteIngresoBodega.TabIndex = 1
            '
            'tpRegistro
            '
            Me.tpRegistro.BackColor = System.Drawing.Color.White
            Me.tpRegistro.Controls.Add(Me.Label18)
            Me.tpRegistro.Controls.Add(Me.txtCedulaRecibe)
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
            Me.tpRegistro.Size = New System.Drawing.Size(1260, 594)
            Me.tpRegistro.TabIndex = 0
            Me.tpRegistro.Text = "REGISTRO"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(439, 154)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(47, 13)
            Me.Label18.TabIndex = 150
            Me.Label18.Text = "CEDULA"
            '
            'txtCedulaRecibe
            '
            Me.txtCedulaRecibe.BackColor = System.Drawing.Color.White
            Me.txtCedulaRecibe.Enabled = False
            Me.txtCedulaRecibe.Location = New System.Drawing.Point(438, 171)
            Me.txtCedulaRecibe.Name = "txtCedulaRecibe"
            Me.txtCedulaRecibe.Size = New System.Drawing.Size(100, 21)
            Me.txtCedulaRecibe.TabIndex = 149
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
            Me.txtRazon.TabIndex = 118
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
            Me.bntPuesto.TabIndex = 116
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
            Me.txtUbicacion.Location = New System.Drawing.Point(585, 164)
            Me.txtUbicacion.Multiline = True
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(379, 43)
            Me.txtUbicacion.TabIndex = 117
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
            Me.txtRecibe.TabIndex = 115
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
            Me.cbmProvincia.TabIndex = 103
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
            Me.gbBusquedaArticulo.Controls.Add(Me.Label11)
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
            Me.gbBusquedaArticulo.Controls.Add(Me.lbldetalle)
            Me.gbBusquedaArticulo.Enabled = False
            Me.gbBusquedaArticulo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(2, 202)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(1254, 389)
            Me.gbBusquedaArticulo.TabIndex = 148
            Me.gbBusquedaArticulo.TabStop = False
            Me.gbBusquedaArticulo.Text = "DETALLE DEL COMPROBANTE DE EGRESO"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
            Me.Label11.Location = New System.Drawing.Point(607, 361)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(0, 15)
            Me.Label11.TabIndex = 219
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
            Me.btnSerie.TabIndex = 120
            Me.btnSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSerie.UseVisualStyleBackColor = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(293, 48)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(101, 21)
            Me.txtSerie.TabIndex = 121
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
            Me.nudTotal.TabIndex = 125
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
            Me.nudValor.TabIndex = 123
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
            Me.tsmEliminar.TabIndex = 128
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
            Me.txtObservacion.Location = New System.Drawing.Point(823, 35)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(224, 39)
            Me.txtObservacion.TabIndex = 126
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
            Me.cmbObservacionCalidad.TabIndex = 124
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.White
            Me.dgvSecuencial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
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
            Me.nudCantidad.TabIndex = 122
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
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(180, 48)
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
            Me.txtArticulo.Location = New System.Drawing.Point(6, 48)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(281, 21)
            Me.txtArticulo.TabIndex = 119
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
            'lbldetalle
            '
            Me.lbldetalle.AutoSize = True
            Me.lbldetalle.ForeColor = System.Drawing.SystemColors.Highlight
            Me.lbldetalle.Location = New System.Drawing.Point(27, 53)
            Me.lbldetalle.Name = "lbldetalle"
            Me.lbldetalle.Size = New System.Drawing.Size(13, 13)
            Me.lbldetalle.TabIndex = 218
            Me.lbldetalle.Text = "0"
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
            Me.txtNumero.TabIndex = 100
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
            Me.txtProveedores.TabIndex = 114
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
            Me.cmbBodega.ItemHeight = 13
            Me.cmbBodega.Location = New System.Drawing.Point(130, 27)
            Me.cmbBodega.Name = "cmbBodega"
            Me.cmbBodega.Size = New System.Drawing.Size(270, 21)
            Me.cmbBodega.TabIndex = 102
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
            Me.cbmCanton.TabIndex = 104
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
            Me.cbmParroquia.TabIndex = 105
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
            Me.cmbConceptos.TabIndex = 113
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
            Me.cbmCentroCosto.TabIndex = 107
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
            Me.cbmEgreso.TabIndex = 108
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
            Me.dtpFecha.TabIndex = 111
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(6, 74)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(294, 21)
            Me.txtNombre.TabIndex = 106
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
            Me.txtNroDocumento.TabIndex = 110
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
            Me.cmbDocumento.TabIndex = 109
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
            Me.Label10.Location = New System.Drawing.Point(586, 148)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(174, 13)
            Me.Label10.TabIndex = 66
            Me.Label10.Text = "UBICACIÓN / CLIENTE / PUESTO:"
            '
            'tpConsultar
            '
            Me.tpConsultar.BackColor = System.Drawing.Color.White
            Me.tpConsultar.Controls.Add(Me.KryptonGroupBox1)
            Me.tpConsultar.Controls.Add(Me.KryptonGroupBox6)
            Me.tpConsultar.Controls.Add(Me.KryptonGroupBox5)
            Me.tpConsultar.Controls.Add(Me.gbComprobante)
            Me.tpConsultar.Controls.Add(Me.gbRangoFechas)
            Me.tpConsultar.Controls.Add(Me.GroupBox1)
            Me.tpConsultar.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultar.Name = "tpConsultar"
            Me.tpConsultar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultar.Size = New System.Drawing.Size(1260, 594)
            Me.tpConsultar.TabIndex = 1
            Me.tpConsultar.Text = "CONSULTAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 281)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvDetalleComprobanteIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnEliminaringreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnAgregarIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblObservacionesTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblTotalTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCalidadTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblValorTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCantidadTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarReingreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblSerieTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCodigoTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblArticuloTitulo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSerieIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.nudTotalIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.nudValorIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtObservacionesIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbxCalidadIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label24)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.nudCantidadIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtArticuloIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdDetalleKardexIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdKardexIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdArticuloIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lbldetalleIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoIngreso)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(1244, 310)
            Me.KryptonGroupBox1.TabIndex = 154
            Me.KryptonGroupBox1.Values.Heading = "Detalles"
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
            Me.dgvDetalleComprobanteIngreso.Location = New System.Drawing.Point(9, 59)
            Me.dgvDetalleComprobanteIngreso.Name = "dgvDetalleComprobanteIngreso"
            Me.dgvDetalleComprobanteIngreso.RowHeadersVisible = False
            Me.dgvDetalleComprobanteIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteIngreso.Size = New System.Drawing.Size(1233, 212)
            Me.dgvDetalleComprobanteIngreso.TabIndex = 258
            Me.dgvDetalleComprobanteIngreso.Visible = False
            '
            'btnEliminaringreso
            '
            Me.btnEliminaringreso.Location = New System.Drawing.Point(1137, 25)
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
            Me.btnAgregarIngreso.Location = New System.Drawing.Point(1097, 25)
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
            Me.lblObservacionesTitulo.Location = New System.Drawing.Point(838, 1)
            Me.lblObservacionesTitulo.Name = "lblObservacionesTitulo"
            Me.lblObservacionesTitulo.Size = New System.Drawing.Size(92, 18)
            Me.lblObservacionesTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservacionesTitulo.TabIndex = 255
            Me.lblObservacionesTitulo.Values.Text = "Observaciones"
            Me.lblObservacionesTitulo.Visible = False
            '
            'lblTotalTitulo
            '
            Me.lblTotalTitulo.Location = New System.Drawing.Point(744, 9)
            Me.lblTotalTitulo.Name = "lblTotalTitulo"
            Me.lblTotalTitulo.Size = New System.Drawing.Size(39, 18)
            Me.lblTotalTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalTitulo.TabIndex = 254
            Me.lblTotalTitulo.Values.Text = "Total"
            Me.lblTotalTitulo.Visible = False
            '
            'txtCalidadTitulo
            '
            Me.txtCalidadTitulo.Location = New System.Drawing.Point(595, 9)
            Me.txtCalidadTitulo.Name = "txtCalidadTitulo"
            Me.txtCalidadTitulo.Size = New System.Drawing.Size(52, 18)
            Me.txtCalidadTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCalidadTitulo.TabIndex = 253
            Me.txtCalidadTitulo.Values.Text = "Calidad"
            Me.txtCalidadTitulo.Visible = False
            '
            'lblValorTitulo
            '
            Me.lblValorTitulo.Location = New System.Drawing.Point(507, 9)
            Me.lblValorTitulo.Name = "lblValorTitulo"
            Me.lblValorTitulo.Size = New System.Drawing.Size(39, 18)
            Me.lblValorTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValorTitulo.TabIndex = 252
            Me.lblValorTitulo.Values.Text = "Valor"
            Me.lblValorTitulo.Visible = False
            '
            'lblCantidadTitulo
            '
            Me.lblCantidadTitulo.Location = New System.Drawing.Point(440, 9)
            Me.lblCantidadTitulo.Name = "lblCantidadTitulo"
            Me.lblCantidadTitulo.Size = New System.Drawing.Size(36, 18)
            Me.lblCantidadTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCantidadTitulo.TabIndex = 251
            Me.lblCantidadTitulo.Values.Text = "Cant"
            Me.lblCantidadTitulo.Visible = False
            '
            'btnBuscarReingreso
            '
            Me.btnBuscarReingreso.AutoSize = True
            Me.btnBuscarReingreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarReingreso.Location = New System.Drawing.Point(402, 25)
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
            Me.lblSerieTitulo.Location = New System.Drawing.Point(295, 9)
            Me.lblSerieTitulo.Name = "lblSerieTitulo"
            Me.lblSerieTitulo.Size = New System.Drawing.Size(38, 18)
            Me.lblSerieTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSerieTitulo.TabIndex = 245
            Me.lblSerieTitulo.Values.Text = "Serie"
            Me.lblSerieTitulo.Visible = False
            '
            'lblCodigoTitulo
            '
            Me.lblCodigoTitulo.Location = New System.Drawing.Point(192, 9)
            Me.lblCodigoTitulo.Name = "lblCodigoTitulo"
            Me.lblCodigoTitulo.Size = New System.Drawing.Size(50, 18)
            Me.lblCodigoTitulo.StateNormal.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoTitulo.TabIndex = 244
            Me.lblCodigoTitulo.Values.Text = "Codigo"
            Me.lblCodigoTitulo.Visible = False
            '
            'lblArticuloTitulo
            '
            Me.lblArticuloTitulo.Location = New System.Drawing.Point(18, 9)
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
            Me.txtSerieIngreso.Location = New System.Drawing.Point(295, 30)
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
            Me.nudTotalIngreso.Location = New System.Drawing.Point(748, 31)
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
            Me.nudValorIngreso.Location = New System.Drawing.Point(503, 31)
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
            Me.txtObservacionesIngreso.Location = New System.Drawing.Point(837, 25)
            Me.txtObservacionesIngreso.MaxLength = 255
            Me.txtObservacionesIngreso.Multiline = True
            Me.txtObservacionesIngreso.Name = "txtObservacionesIngreso"
            Me.txtObservacionesIngreso.Size = New System.Drawing.Size(254, 32)
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
            Me.cbxCalidadIngreso.Location = New System.Drawing.Point(594, 31)
            Me.cbxCalidadIngreso.Name = "cbxCalidadIngreso"
            Me.cbxCalidadIngreso.Size = New System.Drawing.Size(148, 21)
            Me.cbxCalidadIngreso.TabIndex = 229
            Me.cbxCalidadIngreso.Visible = False
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.Black
            Me.Label24.Location = New System.Drawing.Point(500, 1)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(0, 13)
            Me.Label24.TabIndex = 236
            '
            'nudCantidadIngreso
            '
            Me.nudCantidadIngreso.BackColor = System.Drawing.Color.White
            Me.nudCantidadIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidadIngreso.ForeColor = System.Drawing.Color.Black
            Me.nudCantidadIngreso.Location = New System.Drawing.Point(439, 31)
            Me.nudCantidadIngreso.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.nudCantidadIngreso.Name = "nudCantidadIngreso"
            Me.nudCantidadIngreso.Size = New System.Drawing.Size(61, 21)
            Me.nudCantidadIngreso.TabIndex = 227
            Me.nudCantidadIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.nudCantidadIngreso.Value = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudCantidadIngreso.Visible = False
            '
            'txtArticuloIngreso
            '
            Me.txtArticuloIngreso.BackColor = System.Drawing.Color.White
            Me.txtArticuloIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArticuloIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArticuloIngreso.ForeColor = System.Drawing.Color.Black
            Me.txtArticuloIngreso.Location = New System.Drawing.Point(21, 30)
            Me.txtArticuloIngreso.Name = "txtArticuloIngreso"
            Me.txtArticuloIngreso.Size = New System.Drawing.Size(268, 21)
            Me.txtArticuloIngreso.TabIndex = 224
            Me.txtArticuloIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtArticuloIngreso.Visible = False
            '
            'lblIdDetalleKardexIngreso
            '
            Me.lblIdDetalleKardexIngreso.AutoSize = True
            Me.lblIdDetalleKardexIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardexIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardexIngreso.Location = New System.Drawing.Point(202, 34)
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
            Me.lblIdKardexIngreso.Location = New System.Drawing.Point(250, 34)
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
            Me.lblIdArticuloIngreso.Location = New System.Drawing.Point(147, 34)
            Me.lblIdArticuloIngreso.Name = "lblIdArticuloIngreso"
            Me.lblIdArticuloIngreso.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticuloIngreso.TabIndex = 223
            Me.lblIdArticuloIngreso.Text = "0"
            Me.lblIdArticuloIngreso.Visible = False
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
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(6, 20)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(1234, 225)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'lbldetalleIngreso
            '
            Me.lbldetalleIngreso.AutoSize = True
            Me.lbldetalleIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbldetalleIngreso.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lbldetalleIngreso.Location = New System.Drawing.Point(29, 33)
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
            Me.txtCodigoIngreso.Location = New System.Drawing.Point(191, 30)
            Me.txtCodigoIngreso.Name = "txtCodigoIngreso"
            Me.txtCodigoIngreso.Size = New System.Drawing.Size(95, 21)
            Me.txtCodigoIngreso.TabIndex = 218
            Me.txtCodigoIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtCodigoIngreso.Visible = False
            '
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(6, -4)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(452, 62)
            Me.KryptonGroupBox6.TabIndex = 153
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
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(478, -3)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnBuscarModi)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(365, 61)
            Me.KryptonGroupBox5.TabIndex = 152
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            '
            'btnBuscarModi
            '
            Me.btnBuscarModi.AutoSize = True
            Me.btnBuscarModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarModi.Location = New System.Drawing.Point(311, 3)
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
            Me.txtFiltro.Location = New System.Drawing.Point(17, 6)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(264, 21)
            Me.txtFiltro.TabIndex = 13
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Controls.Add(Me.btnExportarComprobantes)
            Me.gbComprobante.Controls.Add(Me.dgvComprobantesEgreso)
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(8, 64)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1254, 213)
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
            Me.dgvComprobantesEgreso.Location = New System.Drawing.Point(4, 19)
            Me.dgvComprobantesEgreso.MultiSelect = False
            Me.dgvComprobantesEgreso.Name = "dgvComprobantesEgreso"
            Me.dgvComprobantesEgreso.ReadOnly = True
            Me.dgvComprobantesEgreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesEgreso.RowHeadersVisible = False
            Me.dgvComprobantesEgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesEgreso.Size = New System.Drawing.Size(1246, 187)
            Me.dgvComprobantesEgreso.TabIndex = 145
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label13)
            Me.gbRangoFechas.Controls.Add(Me.Label14)
            Me.gbRangoFechas.Location = New System.Drawing.Point(849, 10)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(294, 48)
            Me.gbRangoFechas.TabIndex = 146
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            Me.gbRangoFechas.Visible = False
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
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.TabControl1)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1260, 594)
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
            Me.TabPage1.Controls.Add(Me.btnUniformes)
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
            'btnUniformes
            '
            Me.btnUniformes.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnUniformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnUniformes.Location = New System.Drawing.Point(1117, 4)
            Me.btnUniformes.Name = "btnUniformes"
            Me.btnUniformes.Size = New System.Drawing.Size(126, 30)
            Me.btnUniformes.TabIndex = 153
            Me.btnUniformes.Text = "UNIFORMES"
            Me.btnUniformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnUniformes.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(988, 4)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(126, 30)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "COMPROBANTE"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(743, 14)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(92, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "COMPROBANTE:"
            '
            'txtIdComprobante
            '
            Me.txtIdComprobante.Location = New System.Drawing.Point(851, 10)
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
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar, Me.tsmActualizar, Me.tmsEliminar, Me.tsmReingreso})
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
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgvDetalleComprobate)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 283)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1250, 256)
            Me.GroupBox1.TabIndex = 155
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Detalles"
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
            Me.OBSERVACION_INGRESO.Items.AddRange(New Object() {"NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO (DAR BAJA)"})
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
            'FormComprobanteEgresoBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1270, 666)
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
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.dgvDetalleComprobanteIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudTotalIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValorIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidadIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.gbComprobante.ResumeLayout(False)
            CType(Me.dgvComprobantesEgreso, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.GroupBox1.ResumeLayout(False)
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
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
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
        Friend WithEvents Button1 As System.Windows.Forms.Button
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
        Friend WithEvents lbldetalle As Label
        Friend WithEvents tmsEliminar As ToolStripMenuItem
        Friend WithEvents Label11 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents txtCedulaRecibe As TextBox
        Friend WithEvents btnUniformes As Button
        Friend WithEvents txtFiltro As TextBox
        Friend WithEvents btnBuscarModi As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents KryptonGroupBox5 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox6 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dtpFechaHasta As DateTimePicker
        Friend WithEvents dtpFechaDesde As DateTimePicker
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents tsmReingreso As ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
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
        Friend WithEvents GroupBox1 As GroupBox
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
    End Class
End Namespace