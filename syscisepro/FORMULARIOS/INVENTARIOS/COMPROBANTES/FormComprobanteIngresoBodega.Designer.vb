Namespace FORMULARIOS.INVENTARIOS.COMPROBANTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormComprobanteIngresoBodega
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormComprobanteIngresoBodega))
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.TmsEliminar = New System.Windows.Forms.ToolStripMenuItem()
            Me.TmsActualizar = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblCantidadSaldo = New System.Windows.Forms.Label()
            Me.lblComp = New System.Windows.Forms.Label()
            Me.lblDetaComp = New System.Windows.Forms.Label()
            Me.lblDetaKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex2 = New System.Windows.Forms.Label()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.lblCantidadInicial = New System.Windows.Forms.Label()
            Me.btnOrdenCompra = New System.Windows.Forms.Button()
            Me.lblOrdenCompra = New System.Windows.Forms.Label()
            Me.chkReq = New System.Windows.Forms.CheckBox()
            Me.bntPuesto = New System.Windows.Forms.Button()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.txtRecibe = New System.Windows.Forms.TextBox()
            Me.txtProveedores = New System.Windows.Forms.TextBox()
            Me.txtCodigo = New System.Windows.Forms.TextBox()
            Me.txtNroComprobante = New System.Windows.Forms.TextBox()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.txtNroDocumento = New System.Windows.Forms.TextBox()
            Me.cmbConceptos = New System.Windows.Forms.ComboBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.cmbBodega = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.cbmIngreso = New System.Windows.Forms.ComboBox()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.cmbDocumento = New System.Windows.Forms.ComboBox()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.btnSerie = New System.Windows.Forms.Button()
            Me.txtSerie = New System.Windows.Forms.TextBox()
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
            Me.cmbObservacionCalidad = New System.Windows.Forms.ComboBox()
            Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
            Me.txtCodigoArticulo = New System.Windows.Forms.TextBox()
            Me.txtArticulo = New System.Windows.Forms.TextBox()
            Me.lblIdDetalleKardex = New System.Windows.Forms.Label()
            Me.lblIdKardex = New System.Windows.Forms.Label()
            Me.lblIdArticulo = New System.Windows.Forms.Label()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.gbBusquedaArticulo = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.label14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
            Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.btnExportarComprobantes = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.gbxDetalles = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.dgvComprobantesIngreso = New System.Windows.Forms.DataGridView()
            Me.KryptonGroupBox5 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.btnBuscarModi = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.KryptonGroupBox6 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.bntCargar = New System.Windows.Forms.Button()
            Me.txtIdComprobante = New System.Windows.Forms.TextBox()
            Me.crvComprobante = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.tpConsultar = New System.Windows.Forms.TabPage()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.gbDetalleComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarDetalleComprobante = New System.Windows.Forms.Button()
            Me.tpRegistro = New System.Windows.Forms.TabPage()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblRazon = New System.Windows.Forms.Label()
            Me.tbComprobanteIngresoBodega = New System.Windows.Forms.TabControl()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
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
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpConsultar.SuspendLayout()
            Me.gbDetalleComprobante.SuspendLayout()
            Me.tpRegistro.SuspendLayout()
            Me.tbComprobanteIngresoBodega.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmCancelar, Me.TmsEliminar, Me.TmsActualizar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(952, 32)
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
            'TmsEliminar
            '
            Me.TmsEliminar.Enabled = False
            Me.TmsEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.TmsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.TmsEliminar.Name = "TmsEliminar"
            Me.TmsEliminar.Size = New System.Drawing.Size(89, 28)
            Me.TmsEliminar.Text = "ANULAR"
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
            Me.TmsActualizar.Visible = False
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
            'btnOrdenCompra
            '
            Me.btnOrdenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(243, Byte), Integer))
            Me.btnOrdenCompra.Enabled = False
            Me.btnOrdenCompra.FlatAppearance.BorderSize = 0
            Me.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnOrdenCompra.Location = New System.Drawing.Point(451, 128)
            Me.btnOrdenCompra.Name = "btnOrdenCompra"
            Me.btnOrdenCompra.Size = New System.Drawing.Size(26, 26)
            Me.btnOrdenCompra.TabIndex = 117
            Me.btnOrdenCompra.Tag = "1"
            Me.btnOrdenCompra.Text = "..."
            Me.btnOrdenCompra.UseVisualStyleBackColor = False
            '
            'lblOrdenCompra
            '
            Me.lblOrdenCompra.AutoSize = True
            Me.lblOrdenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblOrdenCompra.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblOrdenCompra.Location = New System.Drawing.Point(391, 136)
            Me.lblOrdenCompra.Name = "lblOrdenCompra"
            Me.lblOrdenCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblOrdenCompra.TabIndex = 195
            Me.lblOrdenCompra.Text = "###"
            '
            'chkReq
            '
            Me.chkReq.AutoSize = True
            Me.chkReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chkReq.Enabled = False
            Me.chkReq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chkReq.Location = New System.Drawing.Point(294, 134)
            Me.chkReq.Name = "chkReq"
            Me.chkReq.Size = New System.Drawing.Size(95, 17)
            Me.chkReq.TabIndex = 116
            Me.chkReq.Text = "ÓRDEN C. N°:"
            Me.chkReq.UseVisualStyleBackColor = False
            '
            'bntPuesto
            '
            Me.bntPuesto.BackColor = System.Drawing.Color.Transparent
            Me.bntPuesto.Enabled = False
            Me.bntPuesto.FlatAppearance.BorderSize = 0
            Me.bntPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.bntPuesto.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntPuesto.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.bntPuesto.Location = New System.Drawing.Point(860, 136)
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
            Me.txtRazon.Location = New System.Drawing.Point(782, 72)
            Me.txtRazon.Multiline = True
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.Size = New System.Drawing.Size(146, 54)
            Me.txtRazon.TabIndex = 112
            '
            'txtUbicacion
            '
            Me.txtUbicacion.BackColor = System.Drawing.Color.White
            Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacion.Enabled = False
            Me.txtUbicacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacion.ForeColor = System.Drawing.Color.Black
            Me.txtUbicacion.Location = New System.Drawing.Point(561, 136)
            Me.txtUbicacion.Multiline = True
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(287, 30)
            Me.txtUbicacion.TabIndex = 115
            '
            'txtRecibe
            '
            Me.txtRecibe.BackColor = System.Drawing.Color.White
            Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRecibe.Enabled = False
            Me.txtRecibe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRecibe.ForeColor = System.Drawing.Color.Black
            Me.txtRecibe.Location = New System.Drawing.Point(69, 133)
            Me.txtRecibe.Name = "txtRecibe"
            Me.txtRecibe.Size = New System.Drawing.Size(208, 21)
            Me.txtRecibe.TabIndex = 113
            '
            'txtProveedores
            '
            Me.txtProveedores.BackColor = System.Drawing.Color.White
            Me.txtProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtProveedores.Enabled = False
            Me.txtProveedores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedores.ForeColor = System.Drawing.Color.Black
            Me.txtProveedores.Location = New System.Drawing.Point(561, 106)
            Me.txtProveedores.Name = "txtProveedores"
            Me.txtProveedores.Size = New System.Drawing.Size(208, 21)
            Me.txtProveedores.TabIndex = 111
            '
            'txtCodigo
            '
            Me.txtCodigo.BackColor = System.Drawing.Color.White
            Me.txtCodigo.Enabled = False
            Me.txtCodigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigo.ForeColor = System.Drawing.Color.Black
            Me.txtCodigo.Location = New System.Drawing.Point(349, 105)
            Me.txtCodigo.Name = "txtCodigo"
            Me.txtCodigo.Size = New System.Drawing.Size(53, 21)
            Me.txtCodigo.TabIndex = 177
            Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNroComprobante
            '
            Me.txtNroComprobante.BackColor = System.Drawing.Color.White
            Me.txtNroComprobante.Enabled = False
            Me.txtNroComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobante.Location = New System.Drawing.Point(40, 4)
            Me.txtNroComprobante.Name = "txtNroComprobante"
            Me.txtNroComprobante.Size = New System.Drawing.Size(73, 21)
            Me.txtNroComprobante.TabIndex = 100
            Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(69, 36)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(208, 21)
            Me.txtNombre.TabIndex = 105
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(349, 37)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(99, 21)
            Me.txtCedula.TabIndex = 165
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNroDocumento
            '
            Me.txtNroDocumento.BackColor = System.Drawing.Color.White
            Me.txtNroDocumento.Enabled = False
            Me.txtNroDocumento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDocumento.Location = New System.Drawing.Point(561, 67)
            Me.txtNroDocumento.Name = "txtNroDocumento"
            Me.txtNroDocumento.ReadOnly = True
            Me.txtNroDocumento.Size = New System.Drawing.Size(68, 22)
            Me.txtNroDocumento.TabIndex = 167
            Me.txtNroDocumento.Text = "S/N"
            Me.txtNroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbConceptos
            '
            Me.cmbConceptos.BackColor = System.Drawing.Color.White
            Me.cmbConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConceptos.Enabled = False
            Me.cmbConceptos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConceptos.ForeColor = System.Drawing.Color.Black
            Me.cmbConceptos.FormattingEnabled = True
            Me.cmbConceptos.Location = New System.Drawing.Point(94, 103)
            Me.cmbConceptos.Name = "cmbConceptos"
            Me.cmbConceptos.Size = New System.Drawing.Size(183, 21)
            Me.cmbConceptos.TabIndex = 110
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
            Me.cbmProvincia.Location = New System.Drawing.Point(349, 6)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(138, 21)
            Me.cbmProvincia.TabIndex = 102
            '
            'cmbBodega
            '
            Me.cmbBodega.BackColor = System.Drawing.Color.White
            Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBodega.Enabled = False
            Me.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBodega.FormattingEnabled = True
            Me.cmbBodega.Location = New System.Drawing.Point(174, 5)
            Me.cmbBodega.Name = "cmbBodega"
            Me.cmbBodega.Size = New System.Drawing.Size(103, 21)
            Me.cmbBodega.TabIndex = 101
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
            Me.cbmCanton.Location = New System.Drawing.Point(560, 6)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(138, 21)
            Me.cbmCanton.TabIndex = 103
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.ForeColor = System.Drawing.Color.Black
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(790, 6)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(138, 21)
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
            Me.cbmCentroCosto.Location = New System.Drawing.Point(560, 38)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(138, 21)
            Me.cbmCentroCosto.TabIndex = 106
            '
            'cbmIngreso
            '
            Me.cbmIngreso.BackColor = System.Drawing.Color.White
            Me.cbmIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmIngreso.Enabled = False
            Me.cbmIngreso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmIngreso.ForeColor = System.Drawing.Color.Black
            Me.cbmIngreso.FormattingEnabled = True
            Me.cbmIngreso.Items.AddRange(New Object() {"INGRESO"})
            Me.cbmIngreso.Location = New System.Drawing.Point(828, 36)
            Me.cbmIngreso.Name = "cbmIngreso"
            Me.cbmIngreso.Size = New System.Drawing.Size(100, 21)
            Me.cbmIngreso.TabIndex = 107
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(349, 68)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(99, 22)
            Me.dtpFecha.TabIndex = 109
            '
            'cmbDocumento
            '
            Me.cmbDocumento.BackColor = System.Drawing.Color.White
            Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbDocumento.Enabled = False
            Me.cmbDocumento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbDocumento.FormattingEnabled = True
            Me.cmbDocumento.Location = New System.Drawing.Point(94, 68)
            Me.cmbDocumento.Name = "cmbDocumento"
            Me.cmbDocumento.Size = New System.Drawing.Size(106, 21)
            Me.cmbDocumento.TabIndex = 108
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Location = New System.Drawing.Point(631, 32)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(44, 28)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 201
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
            Me.btnSerie.Location = New System.Drawing.Point(447, 2)
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
            Me.txtSerie.Location = New System.Drawing.Point(347, 9)
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(80, 21)
            Me.txtSerie.TabIndex = 120
            Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'nudValor
            '
            Me.nudValor.BackColor = System.Drawing.Color.White
            Me.nudValor.DecimalPlaces = 2
            Me.nudValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudValor.ForeColor = System.Drawing.Color.Black
            Me.nudValor.Location = New System.Drawing.Point(707, 3)
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
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvSecuencial.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvSecuencial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSecuencial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSecuencial.ColumnHeadersHeight = 26
            Me.dgvSecuencial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.VALOR, Me.TOTAL, Me.OBSERVACION, Me.DETALLES, Me.NUMERO_KARDEX, Me.DETALLE_KARDEX, Me.VALOR_UNITARIO_ANTERIOR, Me.VALOR_TOTAL_ANTERIOR, Me.SALDO, Me.CANTIDAD_SALDO, Me.VALOR_UNITARIO_SALDO, Me.ID_SECUENCIAL})
            Me.dgvSecuencial.GridColor = System.Drawing.Color.Black
            Me.dgvSecuencial.Location = New System.Drawing.Point(7, 68)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(919, 243)
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
            Me.tsmEliminar.BackColor = System.Drawing.Color.Transparent
            Me.tsmEliminar.Enabled = False
            Me.tsmEliminar.FlatAppearance.BorderSize = 0
            Me.tsmEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.tsmEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmEliminar.Location = New System.Drawing.Point(753, 32)
            Me.tsmEliminar.Name = "tsmEliminar"
            Me.tsmEliminar.Size = New System.Drawing.Size(28, 28)
            Me.tsmEliminar.TabIndex = 126
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
            Me.tsmAgregar.Location = New System.Drawing.Point(719, 32)
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
            Me.txtObservacion.Location = New System.Drawing.Point(364, 36)
            Me.txtObservacion.MaxLength = 255
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(179, 21)
            Me.txtObservacion.TabIndex = 124
            Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cmbObservacionCalidad
            '
            Me.cmbObservacionCalidad.BackColor = System.Drawing.Color.White
            Me.cmbObservacionCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbObservacionCalidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbObservacionCalidad.ForeColor = System.Drawing.Color.Black
            Me.cmbObservacionCalidad.FormattingEnabled = True
            Me.cmbObservacionCalidad.Items.AddRange(New Object() {"-- SELECCIONE UN ESTADO --", "NUEVO", "BUEN ESTADO", "REGULAR ESTADO", "MAL ESTADO (DAR BAJA)"})
            Me.cmbObservacionCalidad.Location = New System.Drawing.Point(133, 39)
            Me.cmbObservacionCalidad.Name = "cmbObservacionCalidad"
            Me.cmbObservacionCalidad.Size = New System.Drawing.Size(142, 21)
            Me.cmbObservacionCalidad.TabIndex = 121
            '
            'nudCantidad
            '
            Me.nudCantidad.BackColor = System.Drawing.Color.White
            Me.nudCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCantidad.ForeColor = System.Drawing.Color.Black
            Me.nudCantidad.Location = New System.Drawing.Point(559, 4)
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
            Me.txtCodigoArticulo.Location = New System.Drawing.Point(104, 5)
            Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
            Me.txtCodigoArticulo.Size = New System.Drawing.Size(10, 21)
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
            Me.txtArticulo.Location = New System.Drawing.Point(67, 7)
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(208, 21)
            Me.txtArticulo.TabIndex = 118
            Me.txtArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblIdDetalleKardex
            '
            Me.lblIdDetalleKardex.AutoSize = True
            Me.lblIdDetalleKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdDetalleKardex.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblIdDetalleKardex.Location = New System.Drawing.Point(209, 13)
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
            Me.lblIdKardex.Location = New System.Drawing.Point(221, 13)
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
            Me.lblIdArticulo.Location = New System.Drawing.Point(154, 13)
            Me.lblIdArticulo.Name = "lblIdArticulo"
            Me.lblIdArticulo.Size = New System.Drawing.Size(13, 13)
            Me.lblIdArticulo.TabIndex = 166
            Me.lblIdArticulo.Text = "0"
            Me.lblIdArticulo.Visible = False
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.ForeColor = System.Drawing.SystemColors.Highlight
            Me.lblDetalle.Location = New System.Drawing.Point(114, 12)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(13, 13)
            Me.lblDetalle.TabIndex = 202
            Me.lblDetalle.Text = "0"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 32)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2, Me.KryptonPage3})
            Me.KryptonNavigator1.SelectedIndex = 1
            Me.KryptonNavigator1.Size = New System.Drawing.Size(952, 600)
            Me.KryptonNavigator1.TabIndex = 197
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
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
            Me.KryptonPage1.Size = New System.Drawing.Size(950, 573)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage1.Text = "Registro"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "7D57C30D2BC1426D7C9F2DF44707F4B4"
            '
            'gbBusquedaArticulo
            '
            Me.gbBusquedaArticulo.CaptionOverlap = 0.85R
            Me.gbBusquedaArticulo.Enabled = False
            Me.gbBusquedaArticulo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.gbBusquedaArticulo.Location = New System.Drawing.Point(5, 202)
            Me.gbBusquedaArticulo.Name = "gbBusquedaArticulo"
            '
            'gbBusquedaArticulo.Panel
            '
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.label14)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.pbFoto)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.Label11)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel29)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.dgvSecuencial)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.btnSerie)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel28)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.nudValor)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtSerie)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.tsmEliminar)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel27)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.tsmAgregar)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel26)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtObservacion)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel25)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel24)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel23)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.cmbObservacionCalidad)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.nudCantidad)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.KryptonLabel22)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.txtCodigoArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblDetalle)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdArticulo)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdKardex)
            Me.gbBusquedaArticulo.Panel.Controls.Add(Me.lblIdDetalleKardex)
            Me.gbBusquedaArticulo.Size = New System.Drawing.Size(941, 368)
            Me.gbBusquedaArticulo.TabIndex = 196
            Me.gbBusquedaArticulo.Values.Heading = "Detalles Comprobante"
            '
            'label14
            '
            Me.label14.Location = New System.Drawing.Point(54, 323)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(6, 2)
            Me.label14.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label14.TabIndex = 227
            Me.label14.Values.Text = ""
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
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.bntPuesto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtUbicacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblOrdenCompra)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkReq)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRecibe)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtProveedores)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRazon)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbConceptos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroDocumento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCedula)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombre)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroComprobante)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbBodega)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCanton)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmIngreso)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbDocumento)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(948, 195)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = "Comprobante"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(487, 134)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel21.TabIndex = 180
            Me.KryptonLabel21.Values.Text = "Ubicacion"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(6, 132)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel19.TabIndex = 178
            Me.KryptonLabel19.Values.Text = "Recibe"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(435, 106)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(120, 20)
            Me.KryptonLabel17.TabIndex = 172
            Me.KryptonLabel17.Values.Text = "Proveedor / Entrega"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(287, 105)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel16.TabIndex = 171
            Me.KryptonLabel16.Values.Text = "Codigo"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(7, 104)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel15.TabIndex = 170
            Me.KryptonLabel15.Values.Text = "Concepto"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(725, 69)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel18.TabIndex = 169
            Me.KryptonLabel18.Values.Text = "Razon"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(7, 70)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel14.TabIndex = 168
            Me.KryptonLabel14.Values.Text = "Documento"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(287, 69)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel13.TabIndex = 167
            Me.KryptonLabel13.Values.Text = "Fecha"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(524, 69)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel12.TabIndex = 166
            Me.KryptonLabel12.Values.Text = "Nro"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(721, 36)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(61, 20)
            Me.KryptonLabel11.TabIndex = 115
            Me.KryptonLabel11.Values.Text = "Actividad"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(476, 36)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel10.TabIndex = 114
            Me.KryptonLabel10.Values.Text = "Centro Costo"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(287, 38)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel9.TabIndex = 113
            Me.KryptonLabel9.Values.Text = "Cedula"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(7, 37)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel8.TabIndex = 112
            Me.KryptonLabel8.Values.Text = "Custodio"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(721, 4)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 111
            Me.KryptonLabel7.Values.Text = "Parroquia"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(505, 6)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel6.TabIndex = 110
            Me.KryptonLabel6.Values.Text = "Ciudad"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(283, 6)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel5.TabIndex = 109
            Me.KryptonLabel5.Values.Text = "Provincia"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(119, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel2.TabIndex = 108
            Me.KryptonLabel2.Values.Text = "Bodega"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(31, 20)
            Me.KryptonLabel1.TabIndex = 107
            Me.KryptonLabel1.Values.Text = "Nro"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.KryptonButton1)
            Me.KryptonPage2.Controls.Add(Me.btnExportarComprobantes)
            Me.KryptonPage2.Controls.Add(Me.gbxDetalles)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox5)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox6)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(950, 573)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Consultar"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "FC57A9849A1F4EA84FBAFBF6DBC6FB53"
            '
            'KryptonButton1
            '
            Me.KryptonButton1.Location = New System.Drawing.Point(851, 297)
            Me.KryptonButton1.Name = "KryptonButton1"
            Me.KryptonButton1.Size = New System.Drawing.Size(89, 25)
            Me.KryptonButton1.TabIndex = 200
            Me.KryptonButton1.Values.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.KryptonButton1.Values.Text = "Exportar"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(847, 68)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(89, 25)
            Me.btnExportarComprobantes.TabIndex = 199
            Me.btnExportarComprobantes.Values.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportarComprobantes.Values.Text = "Exportar"
            '
            'gbxDetalles
            '
            Me.gbxDetalles.CaptionOverlap = 0.85R
            Me.gbxDetalles.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.gbxDetalles.Location = New System.Drawing.Point(2, 307)
            Me.gbxDetalles.Name = "gbxDetalles"
            '
            'gbxDetalles.Panel
            '
            Me.gbxDetalles.Panel.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbxDetalles.Size = New System.Drawing.Size(946, 260)
            Me.gbxDetalles.TabIndex = 198
            Me.gbxDetalles.Values.Heading = "Detalles Comprobante"
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
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDetalleComprobate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(942, 236)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0.85R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(5, 77)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvComprobantesIngreso)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(942, 218)
            Me.KryptonGroupBox3.TabIndex = 197
            Me.KryptonGroupBox3.Values.Heading = "Comprobante"
            '
            'dgvComprobantesIngreso
            '
            Me.dgvComprobantesIngreso.AllowUserToAddRows = False
            Me.dgvComprobantesIngreso.AllowUserToDeleteRows = False
            Me.dgvComprobantesIngreso.AllowUserToResizeRows = False
            DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesIngreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobantesIngreso.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvComprobantesIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvComprobantesIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvComprobantesIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobantesIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesIngreso.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobantesIngreso.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvComprobantesIngreso.GridColor = System.Drawing.Color.Black
            Me.dgvComprobantesIngreso.Location = New System.Drawing.Point(0, 0)
            Me.dgvComprobantesIngreso.MultiSelect = False
            Me.dgvComprobantesIngreso.Name = "dgvComprobantesIngreso"
            Me.dgvComprobantesIngreso.ReadOnly = True
            Me.dgvComprobantesIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesIngreso.RowHeadersVisible = False
            Me.dgvComprobantesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesIngreso.Size = New System.Drawing.Size(938, 194)
            Me.dgvComprobantesIngreso.TabIndex = 146
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(469, 9)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtFiltro)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.btnBuscarModi)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(266, 62)
            Me.KryptonGroupBox5.TabIndex = 153
            Me.KryptonGroupBox5.Values.Heading = "Busqueda"
            '
            'txtFiltro
            '
            Me.txtFiltro.Location = New System.Drawing.Point(9, 9)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(195, 22)
            Me.txtFiltro.TabIndex = 250
            '
            'btnBuscarModi
            '
            Me.btnBuscarModi.AutoSize = True
            Me.btnBuscarModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnBuscarModi.Location = New System.Drawing.Point(210, 2)
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
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.CaptionOverlap = 0R
            Me.KryptonGroupBox6.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(9, 9)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(452, 62)
            Me.KryptonGroupBox6.TabIndex = 154
            Me.KryptonGroupBox6.Values.Heading = "Fechas"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(211, 9)
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
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(31, 9)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(238, 9)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(173, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.TabControl1)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(950, 573)
            Me.KryptonPage3.Text = "Reporte"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "147865F89994432DFBA9BF8766727FA3"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Location = New System.Drawing.Point(-1, 3)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(998, 556)
            Me.TabControl1.TabIndex = 154
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.bntCargar)
            Me.TabPage1.Controls.Add(Me.txtIdComprobante)
            Me.TabPage1.Controls.Add(Me.crvComprobante)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(990, 530)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Comprobante"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'bntCargar
            '
            Me.bntCargar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntCargar.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.bntCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntCargar.Location = New System.Drawing.Point(753, 1)
            Me.bntCargar.Name = "bntCargar"
            Me.bntCargar.Size = New System.Drawing.Size(101, 32)
            Me.bntCargar.TabIndex = 155
            Me.bntCargar.Text = "Reporte"
            Me.bntCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntCargar.UseVisualStyleBackColor = True
            '
            'txtIdComprobante
            '
            Me.txtIdComprobante.Location = New System.Drawing.Point(615, 7)
            Me.txtIdComprobante.Name = "txtIdComprobante"
            Me.txtIdComprobante.Size = New System.Drawing.Size(108, 22)
            Me.txtIdComprobante.TabIndex = 154
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
            Me.crvComprobante.ShowCloseButton = False
            Me.crvComprobante.ShowGroupTreeButton = False
            Me.crvComprobante.ShowLogo = False
            Me.crvComprobante.Size = New System.Drawing.Size(984, 524)
            Me.crvComprobante.TabIndex = 153
            Me.crvComprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.PictureBox1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(990, 530)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Imagen Adjunta"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(984, 524)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 1
            Me.PictureBox1.TabStop = False
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(829, 0)
            Me.tpReporte.TabIndex = 2
            Me.tpReporte.Text = "REPORTE"
            '
            'tpConsultar
            '
            Me.tpConsultar.BackColor = System.Drawing.Color.White
            Me.tpConsultar.Controls.Add(Me.gbComprobante)
            Me.tpConsultar.Controls.Add(Me.gbDetalleComprobante)
            Me.tpConsultar.Location = New System.Drawing.Point(4, 22)
            Me.tpConsultar.Name = "tpConsultar"
            Me.tpConsultar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpConsultar.Size = New System.Drawing.Size(829, 0)
            Me.tpConsultar.TabIndex = 1
            Me.tpConsultar.Text = "CONSULTAR"
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(-143, 69)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1178, 266)
            Me.gbComprobante.TabIndex = 151
            Me.gbComprobante.TabStop = False
            Me.gbComprobante.Text = "COMPROBANTE"
            '
            'gbDetalleComprobante
            '
            Me.gbDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.gbDetalleComprobante.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.gbDetalleComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleComprobante.Location = New System.Drawing.Point(138, 336)
            Me.gbDetalleComprobante.Name = "gbDetalleComprobante"
            Me.gbDetalleComprobante.Size = New System.Drawing.Size(897, 214)
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
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(938, 0)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(28, 28)
            Me.btnExportarDetalleComprobante.TabIndex = 153
            Me.btnExportarDetalleComprobante.UseVisualStyleBackColor = False
            '
            'tpRegistro
            '
            Me.tpRegistro.BackColor = System.Drawing.Color.White
            Me.tpRegistro.Controls.Add(Me.Label6)
            Me.tpRegistro.Controls.Add(Me.Label2)
            Me.tpRegistro.Controls.Add(Me.Label4)
            Me.tpRegistro.Controls.Add(Me.Label13)
            Me.tpRegistro.Controls.Add(Me.Label15)
            Me.tpRegistro.Controls.Add(Me.Label16)
            Me.tpRegistro.Controls.Add(Me.Label18)
            Me.tpRegistro.Controls.Add(Me.Label19)
            Me.tpRegistro.Controls.Add(Me.Label20)
            Me.tpRegistro.Controls.Add(Me.Label21)
            Me.tpRegistro.Controls.Add(Me.Label22)
            Me.tpRegistro.Controls.Add(Me.Label23)
            Me.tpRegistro.Controls.Add(Me.Label24)
            Me.tpRegistro.Controls.Add(Me.Label25)
            Me.tpRegistro.Controls.Add(Me.Label5)
            Me.tpRegistro.Controls.Add(Me.Label1)
            Me.tpRegistro.Controls.Add(Me.lblRazon)
            Me.tpRegistro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpRegistro.Location = New System.Drawing.Point(4, 22)
            Me.tpRegistro.Name = "tpRegistro"
            Me.tpRegistro.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRegistro.Size = New System.Drawing.Size(829, 0)
            Me.tpRegistro.TabIndex = 0
            Me.tpRegistro.Text = "REGISTRO"
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
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(285, 106)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(51, 13)
            Me.Label2.TabIndex = 181
            Me.Label2.Text = "CÓDIGO:"
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
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(327, 10)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(67, 13)
            Me.Label16.TabIndex = 171
            Me.Label16.Text = "PROVINCIA:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(516, 13)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(48, 13)
            Me.Label18.TabIndex = 172
            Me.Label18.Text = "CIUDAD:"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(793, 13)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(70, 13)
            Me.Label19.TabIndex = 173
            Me.Label19.Text = "PARROQUIA:"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(395, 56)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(109, 13)
            Me.Label20.TabIndex = 174
            Me.Label20.Text = "CENTRO DE COSTO:"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label21.Location = New System.Drawing.Point(811, 59)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(44, 13)
            Me.Label21.TabIndex = 158
            Me.Label21.Text = "FECHA:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.Location = New System.Drawing.Point(568, 56)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(65, 13)
            Me.Label22.TabIndex = 170
            Me.Label22.Text = "ACTIVIDAD:"
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
            Me.Label24.Location = New System.Drawing.Point(811, 85)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(33, 13)
            Me.Label24.TabIndex = 168
            Me.Label24.Text = "NRO:"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(699, 56)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(78, 13)
            Me.Label25.TabIndex = 166
            Me.Label25.Text = "DOCUMENTO:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(378, 159)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(174, 13)
            Me.Label5.TabIndex = 184
            Me.Label5.Text = "UBICACIÓN / CLIENTE / PUESTO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(350, 109)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(125, 13)
            Me.Label1.TabIndex = 180
            Me.Label1.Text = "PROVEEDOR ENTREGA:"
            '
            'lblRazon
            '
            Me.lblRazon.AutoSize = True
            Me.lblRazon.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazon.Location = New System.Drawing.Point(695, 109)
            Me.lblRazon.Name = "lblRazon"
            Me.lblRazon.Size = New System.Drawing.Size(99, 13)
            Me.lblRazon.TabIndex = 187
            Me.lblRazon.Text = "RAZÓN / MOTIVO:"
            '
            'tbComprobanteIngresoBodega
            '
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpRegistro)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpConsultar)
            Me.tbComprobanteIngresoBodega.Controls.Add(Me.tpReporte)
            Me.tbComprobanteIngresoBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbComprobanteIngresoBodega.Location = New System.Drawing.Point(212, 447)
            Me.tbComprobanteIngresoBodega.Name = "tbComprobanteIngresoBodega"
            Me.tbComprobanteIngresoBodega.SelectedIndex = 0
            Me.tbComprobanteIngresoBodega.Size = New System.Drawing.Size(837, 10)
            Me.tbComprobanteIngresoBodega.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tbComprobanteIngresoBodega.TabIndex = 0
            '
            'FormComprobanteIngresoBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(952, 632)
            Me.Controls.Add(Me.KryptonNavigator1)
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
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudValor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
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
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.Panel.ResumeLayout(False)
            Me.KryptonGroupBox6.Panel.PerformLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpConsultar.ResumeLayout(False)
            Me.gbDetalleComprobante.ResumeLayout(False)
            Me.tpRegistro.ResumeLayout(False)
            Me.tpRegistro.PerformLayout()
            Me.tbComprobanteIngresoBodega.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TmsActualizar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblCantidadSaldo As System.Windows.Forms.Label
        Friend WithEvents lblComp As System.Windows.Forms.Label
        Friend WithEvents lblDetaComp As System.Windows.Forms.Label
        Friend WithEvents lblDetaKardex As System.Windows.Forms.Label
        Friend WithEvents lblIdKardex2 As System.Windows.Forms.Label
        Friend WithEvents lblIdSecuencial As System.Windows.Forms.Label
        Friend WithEvents lblCantidadInicial As System.Windows.Forms.Label
        Friend WithEvents TmsEliminar As ToolStripMenuItem
        Friend WithEvents btnOrdenCompra As Button
        Friend WithEvents lblOrdenCompra As Label
        Friend WithEvents chkReq As CheckBox
        Friend WithEvents bntPuesto As Button
        Friend WithEvents txtRazon As TextBox
        Friend WithEvents txtUbicacion As TextBox
        Friend WithEvents txtRecibe As TextBox
        Friend WithEvents txtProveedores As TextBox
        Friend WithEvents txtCodigo As TextBox
        Friend WithEvents txtNroComprobante As TextBox
        Friend WithEvents txtNombre As TextBox
        Friend WithEvents txtCedula As TextBox
        Friend WithEvents txtNroDocumento As TextBox
        Friend WithEvents cmbConceptos As ComboBox
        Friend WithEvents cbmProvincia As ComboBox
        Friend WithEvents cmbBodega As ComboBox
        Friend WithEvents cbmCanton As ComboBox
        Friend WithEvents cbmParroquia As ComboBox
        Friend WithEvents cbmCentroCosto As ComboBox
        Friend WithEvents cbmIngreso As ComboBox
        Friend WithEvents dtpFecha As DateTimePicker
        Friend WithEvents cmbDocumento As ComboBox
        Friend WithEvents pbFoto As PictureBox
        Friend WithEvents btnSerie As Button
        Friend WithEvents txtSerie As TextBox
        Friend WithEvents nudValor As NumericUpDown
        Friend WithEvents dgvSecuencial As DataGridView
        Friend WithEvents tsmEliminar As Button
        Friend WithEvents tsmAgregar As Button
        Friend WithEvents txtObservacion As TextBox
        Friend WithEvents cmbObservacionCalidad As ComboBox
        Friend WithEvents nudCantidad As NumericUpDown
        Friend WithEvents txtCodigoArticulo As TextBox
        Friend WithEvents txtArticulo As TextBox
        Friend WithEvents lblIdDetalleKardex As Label
        Friend WithEvents lblIdKardex As Label
        Friend WithEvents lblIdArticulo As Label
        Friend WithEvents lblDetalle As Label
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents gbBusquedaArticulo As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents Label11 As Label
        Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents label14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox6 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents dtpFechaDesde As DateTimePicker
        Friend WithEvents dtpFechaHasta As DateTimePicker
        Friend WithEvents KryptonGroupBox5 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents txtFiltro As TextBox
        Friend WithEvents btnBuscarModi As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents gbxDetalles As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents crvComprobante As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents dgvDetalleComprobate As DataGridView
        Friend WithEvents tpReporte As TabPage
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents tpConsultar As TabPage
        Friend WithEvents gbComprobante As GroupBox
        Friend WithEvents gbDetalleComprobante As GroupBox
        Friend WithEvents btnExportarDetalleComprobante As Button
        Friend WithEvents tpRegistro As TabPage
        Friend WithEvents Label6 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label16 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents Label23 As Label
        Friend WithEvents Label24 As Label
        Friend WithEvents Label25 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents lblRazon As Label
        Friend WithEvents tbComprobanteIngresoBodega As TabControl
        Friend WithEvents dgvComprobantesIngreso As DataGridView
        Friend WithEvents bntCargar As Button
        Friend WithEvents txtIdComprobante As TextBox
        Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents btnExportarComprobantes As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents CODIGO As DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
        Friend WithEvents VALOR As DataGridViewTextBoxColumn
        Friend WithEvents TOTAL As DataGridViewTextBoxColumn
        Friend WithEvents OBSERVACION As DataGridViewTextBoxColumn
        Friend WithEvents DETALLES As DataGridViewTextBoxColumn
        Friend WithEvents NUMERO_KARDEX As DataGridViewTextBoxColumn
        Friend WithEvents DETALLE_KARDEX As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_UNITARIO_ANTERIOR As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_TOTAL_ANTERIOR As DataGridViewTextBoxColumn
        Friend WithEvents SALDO As DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD_SALDO As DataGridViewTextBoxColumn
        Friend WithEvents VALOR_UNITARIO_SALDO As DataGridViewTextBoxColumn
        Friend WithEvents ID_SECUENCIAL As DataGridViewTextBoxColumn
    End Class
End Namespace