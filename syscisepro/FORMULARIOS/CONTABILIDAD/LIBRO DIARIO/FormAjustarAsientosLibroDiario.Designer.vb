Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAjustarAsientosLibroDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustarAsientosLibroDiario))
            Me.rbFechaAsiento = New System.Windows.Forms.RadioButton()
            Me.rbNumeroAsiento = New System.Windows.Forms.RadioButton()
            Me.dtpAsientoHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpAsientoDesde = New System.Windows.Forms.DateTimePicker()
            Me.txtNumeroAsientoBuscar = New System.Windows.Forms.TextBox()
            Me.txtDetalleAsiento = New System.Windows.Forms.TextBox()
            Me.txtValorDebeAsiento = New System.Windows.Forms.TextBox()
            Me.txtValorHaberAsiento = New System.Windows.Forms.TextBox()
            Me.txtNumeroRegistro = New System.Windows.Forms.TextBox()
            Me.txtDebeHaber = New System.Windows.Forms.TextBox()
            Me.txtConciliarAsiento = New System.Windows.Forms.TextBox()
            Me.txtEstadoAsiento = New System.Windows.Forms.TextBox()
            Me.txtIdLibroDiario = New System.Windows.Forms.TextBox()
            Me.lblIdLibroDiario = New System.Windows.Forms.Label()
            Me.lblEstadoAsiento = New System.Windows.Forms.Label()
            Me.lblConciliarAsiento = New System.Windows.Forms.Label()
            Me.lblDebeHaber = New System.Windows.Forms.Label()
            Me.lblNumeroRegistro = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtIdAsiento = New System.Windows.Forms.TextBox()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.dtpFechaAsiento = New System.Windows.Forms.DateTimePicker()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.dgvNumeroRegistroAsiento = New System.Windows.Forms.DataGridView()
            Me.dgvAsientoBuscado = New System.Windows.Forms.DataGridView()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.ID_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FECHA_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CODIGO_CUENTA_SIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NOMBRE_CUENTA_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONCEPTO_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DETALLE_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_DEBE_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VALOR_HABER_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NUMERO_REGISTRO_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DEBE_HABER_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CONSILIAR_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ESTADO_ASIENTO_DIARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_LIBRO_DIARIO_ASIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.rbTransaccionInterna = New System.Windows.Forms.RadioButton()
            Me.rbCheque = New System.Windows.Forms.RadioButton()
            Me.rbTransaccionExterna = New System.Windows.Forms.RadioButton()
            Me.rbEfectivo = New System.Windows.Forms.RadioButton()
            Me.rbTarjetaCredido = New System.Windows.Forms.RadioButton()
            Me.lblIdClienteProveedorPersonal = New System.Windows.Forms.Label()
            Me.lblRucClienteProveedorPersonal = New System.Windows.Forms.Label()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtNombreClienteProveedorPersonal = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.btnDelete = New Krypton.Toolkit.KryptonButton()
            Me.btnAdd = New Krypton.Toolkit.KryptonButton()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.txtHaber = New System.Windows.Forms.TextBox()
            Me.txtDebe = New System.Windows.Forms.TextBox()
            Me.kryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.kryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.txtFondoReservaxPagar = New System.Windows.Forms.TextBox()
            Me.txtAportePatronal = New System.Windows.Forms.TextBox()
            Me.dgvAsientoRoles = New Krypton.Toolkit.KryptonDataGridView()
            Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cbxTipo = New Krypton.Toolkit.KryptonComboBox()
            Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.dtpfecha = New Krypton.Toolkit.KryptonDateTimePicker()
            Me.btnGenerar = New Krypton.Toolkit.KryptonButton()
            Me.KryptonDockableNavigator1 = New ComponentFactory.Krypton.Docking.KryptonDockableNavigator()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox4 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.lblCodigoCuentaContable = New System.Windows.Forms.Label()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage4 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgvNumeroRegistroAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbFormaPago.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.kryptonGroupBox1.Panel.SuspendLayout()
            Me.kryptonGroupBox1.SuspendLayout()
            CType(Me.dgvAsientoRoles, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonDockableNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonDockableNavigator1.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage4.SuspendLayout()
            Me.SuspendLayout()
            '
            'rbFechaAsiento
            '
            Me.rbFechaAsiento.AutoSize = True
            Me.rbFechaAsiento.BackColor = System.Drawing.Color.Transparent
            Me.rbFechaAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFechaAsiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbFechaAsiento.Location = New System.Drawing.Point(85, 6)
            Me.rbFechaAsiento.Name = "rbFechaAsiento"
            Me.rbFechaAsiento.Size = New System.Drawing.Size(55, 17)
            Me.rbFechaAsiento.TabIndex = 2
            Me.rbFechaAsiento.Text = "Fecha"
            Me.rbFechaAsiento.UseVisualStyleBackColor = False
            '
            'rbNumeroAsiento
            '
            Me.rbNumeroAsiento.AutoSize = True
            Me.rbNumeroAsiento.BackColor = System.Drawing.Color.Transparent
            Me.rbNumeroAsiento.Checked = True
            Me.rbNumeroAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNumeroAsiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNumeroAsiento.Location = New System.Drawing.Point(3, 6)
            Me.rbNumeroAsiento.Name = "rbNumeroAsiento"
            Me.rbNumeroAsiento.Size = New System.Drawing.Size(79, 17)
            Me.rbNumeroAsiento.TabIndex = 1
            Me.rbNumeroAsiento.TabStop = True
            Me.rbNumeroAsiento.Text = "Nº Asiento"
            Me.rbNumeroAsiento.UseVisualStyleBackColor = False
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpAsientoHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(570, 2)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(208, 21)
            Me.dtpAsientoHasta.TabIndex = 7
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpAsientoDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(341, 2)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(171, 21)
            Me.dtpAsientoDesde.TabIndex = 6
            '
            'txtNumeroAsientoBuscar
            '
            Me.txtNumeroAsientoBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroAsientoBuscar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroAsientoBuscar.Location = New System.Drawing.Point(203, 3)
            Me.txtNumeroAsientoBuscar.Name = "txtNumeroAsientoBuscar"
            Me.txtNumeroAsientoBuscar.Size = New System.Drawing.Size(80, 21)
            Me.txtNumeroAsientoBuscar.TabIndex = 4
            '
            'txtDetalleAsiento
            '
            Me.txtDetalleAsiento.BackColor = System.Drawing.Color.White
            Me.txtDetalleAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleAsiento.Location = New System.Drawing.Point(59, 101)
            Me.txtDetalleAsiento.Name = "txtDetalleAsiento"
            Me.txtDetalleAsiento.Size = New System.Drawing.Size(434, 21)
            Me.txtDetalleAsiento.TabIndex = 7
            Me.txtDetalleAsiento.Text = "..."
            '
            'txtValorDebeAsiento
            '
            Me.txtValorDebeAsiento.BackColor = System.Drawing.Color.White
            Me.txtValorDebeAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDebeAsiento.Location = New System.Drawing.Point(551, 101)
            Me.txtValorDebeAsiento.Name = "txtValorDebeAsiento"
            Me.txtValorDebeAsiento.Size = New System.Drawing.Size(88, 21)
            Me.txtValorDebeAsiento.TabIndex = 12
            Me.txtValorDebeAsiento.Text = "0.00"
            Me.txtValorDebeAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorHaberAsiento
            '
            Me.txtValorHaberAsiento.BackColor = System.Drawing.Color.White
            Me.txtValorHaberAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorHaberAsiento.Location = New System.Drawing.Point(690, 101)
            Me.txtValorHaberAsiento.Name = "txtValorHaberAsiento"
            Me.txtValorHaberAsiento.Size = New System.Drawing.Size(88, 21)
            Me.txtValorHaberAsiento.TabIndex = 13
            Me.txtValorHaberAsiento.Text = "0.00"
            Me.txtValorHaberAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNumeroRegistro
            '
            Me.txtNumeroRegistro.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroRegistro.Location = New System.Drawing.Point(97, 32)
            Me.txtNumeroRegistro.Name = "txtNumeroRegistro"
            Me.txtNumeroRegistro.Size = New System.Drawing.Size(64, 20)
            Me.txtNumeroRegistro.TabIndex = 14
            Me.txtNumeroRegistro.Text = "0"
            '
            'txtDebeHaber
            '
            Me.txtDebeHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDebeHaber.Location = New System.Drawing.Point(163, 32)
            Me.txtDebeHaber.Name = "txtDebeHaber"
            Me.txtDebeHaber.Size = New System.Drawing.Size(42, 20)
            Me.txtDebeHaber.TabIndex = 15
            Me.txtDebeHaber.Text = "0"
            '
            'txtConciliarAsiento
            '
            Me.txtConciliarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConciliarAsiento.Location = New System.Drawing.Point(207, 32)
            Me.txtConciliarAsiento.Name = "txtConciliarAsiento"
            Me.txtConciliarAsiento.Size = New System.Drawing.Size(42, 20)
            Me.txtConciliarAsiento.TabIndex = 16
            Me.txtConciliarAsiento.Text = "1"
            '
            'txtEstadoAsiento
            '
            Me.txtEstadoAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEstadoAsiento.Location = New System.Drawing.Point(251, 32)
            Me.txtEstadoAsiento.Name = "txtEstadoAsiento"
            Me.txtEstadoAsiento.Size = New System.Drawing.Size(42, 20)
            Me.txtEstadoAsiento.TabIndex = 17
            Me.txtEstadoAsiento.Text = "1"
            '
            'txtIdLibroDiario
            '
            Me.txtIdLibroDiario.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLibroDiario.Location = New System.Drawing.Point(295, 32)
            Me.txtIdLibroDiario.Name = "txtIdLibroDiario"
            Me.txtIdLibroDiario.Size = New System.Drawing.Size(42, 20)
            Me.txtIdLibroDiario.TabIndex = 18
            Me.txtIdLibroDiario.Text = "0"
            '
            'lblIdLibroDiario
            '
            Me.lblIdLibroDiario.AutoSize = True
            Me.lblIdLibroDiario.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdLibroDiario.Location = New System.Drawing.Point(293, 18)
            Me.lblIdLibroDiario.Name = "lblIdLibroDiario"
            Me.lblIdLibroDiario.Size = New System.Drawing.Size(45, 10)
            Me.lblIdLibroDiario.TabIndex = 37
            Me.lblIdLibroDiario.Text = "ID LIBRO"
            '
            'lblEstadoAsiento
            '
            Me.lblEstadoAsiento.AutoSize = True
            Me.lblEstadoAsiento.Location = New System.Drawing.Point(251, 16)
            Me.lblEstadoAsiento.Name = "lblEstadoAsiento"
            Me.lblEstadoAsiento.Size = New System.Drawing.Size(25, 13)
            Me.lblEstadoAsiento.TabIndex = 36
            Me.lblEstadoAsiento.Text = "EST"
            '
            'lblConciliarAsiento
            '
            Me.lblConciliarAsiento.AutoSize = True
            Me.lblConciliarAsiento.Location = New System.Drawing.Point(207, 16)
            Me.lblConciliarAsiento.Name = "lblConciliarAsiento"
            Me.lblConciliarAsiento.Size = New System.Drawing.Size(31, 13)
            Me.lblConciliarAsiento.TabIndex = 35
            Me.lblConciliarAsiento.Text = "CONS"
            '
            'lblDebeHaber
            '
            Me.lblDebeHaber.AutoSize = True
            Me.lblDebeHaber.Location = New System.Drawing.Point(163, 15)
            Me.lblDebeHaber.Name = "lblDebeHaber"
            Me.lblDebeHaber.Size = New System.Drawing.Size(25, 13)
            Me.lblDebeHaber.TabIndex = 34
            Me.lblDebeHaber.Text = "D/H"
            '
            'lblNumeroRegistro
            '
            Me.lblNumeroRegistro.AutoSize = True
            Me.lblNumeroRegistro.Location = New System.Drawing.Point(97, 15)
            Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
            Me.lblNumeroRegistro.Size = New System.Drawing.Size(61, 13)
            Me.lblNumeroRegistro.TabIndex = 33
            Me.lblNumeroRegistro.Text = "# ASIENTO"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.txtIdAsiento)
            Me.GroupBox3.Controls.Add(Me.txtNumeroRegistro)
            Me.GroupBox3.Controls.Add(Me.lblNumeroRegistro)
            Me.GroupBox3.Controls.Add(Me.txtDebeHaber)
            Me.GroupBox3.Controls.Add(Me.lblDebeHaber)
            Me.GroupBox3.Controls.Add(Me.txtConciliarAsiento)
            Me.GroupBox3.Controls.Add(Me.lblIdLibroDiario)
            Me.GroupBox3.Controls.Add(Me.lblConciliarAsiento)
            Me.GroupBox3.Controls.Add(Me.txtEstadoAsiento)
            Me.GroupBox3.Controls.Add(Me.lblEstadoAsiento)
            Me.GroupBox3.Controls.Add(Me.txtIdLibroDiario)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(34, 112)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(341, 59)
            Me.GroupBox3.TabIndex = 119
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DATOS"
            '
            'txtIdAsiento
            '
            Me.txtIdAsiento.Location = New System.Drawing.Point(10, 32)
            Me.txtIdAsiento.Name = "txtIdAsiento"
            Me.txtIdAsiento.Size = New System.Drawing.Size(64, 20)
            Me.txtIdAsiento.TabIndex = 38
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.btnEliminar.Enabled = False
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(909, 264)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(23, 27)
            Me.btnEliminar.TabIndex = 19
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'btnAgregar
            '
            Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.btnAgregar.Enabled = False
            Me.btnAgregar.FlatAppearance.BorderSize = 0
            Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregar.Location = New System.Drawing.Point(873, 264)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(28, 27)
            Me.btnAgregar.TabIndex = 18
            Me.btnAgregar.UseVisualStyleBackColor = False
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.DropDownHeight = 200
            Me.cmbCuentasContables.DropDownWidth = 500
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.IntegralHeight = False
            Me.cmbCuentasContables.Location = New System.Drawing.Point(290, 28)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(222, 21)
            Me.cmbCuentasContables.TabIndex = 36
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 300
            Me.cmbConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Items.AddRange(New Object() {"COMPROBANTE ASIENTO DE DIARIO", "COMPROBANTE DIARIO DE AJUSTE", "COMPROBANTE DIARIO DE CRUCE DE CTAS", "COMPROBANTE DIARIO DE COMPRA", "COMPROBANTE DIARIO DE GASTO", "COMPROBANTE DIARIO DE NOTA DE CRÉDITO", "COMPROBANTE DIARIO DE VENTA", "COMPROBANTE DE EGRESO", "COMPROBANTE DE INGRESO", "COMPROBANTE DE INGRESO CUENTAS POR PAGAR", "COMPROBANTE DE INGRESO CUENTAS POR COBRAR", "NOTA DE CRÉDITO", "NOTA DE DEBITO", "CAJA CHICA", "FONDO ROTATIVO"})
            Me.cmbConcepto.Location = New System.Drawing.Point(290, 1)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(222, 21)
            Me.cmbConcepto.TabIndex = 33
            '
            'dtpFechaAsiento
            '
            Me.dtpFechaAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAsiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAsiento.Location = New System.Drawing.Point(93, 2)
            Me.dtpFechaAsiento.Name = "dtpFechaAsiento"
            Me.dtpFechaAsiento.Size = New System.Drawing.Size(102, 21)
            Me.dtpFechaAsiento.TabIndex = 32
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.DropDownWidth = 120
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(93, 28)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(102, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'dgvNumeroRegistroAsiento
            '
            Me.dgvNumeroRegistroAsiento.AllowUserToAddRows = False
            Me.dgvNumeroRegistroAsiento.AllowUserToDeleteRows = False
            Me.dgvNumeroRegistroAsiento.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNumeroRegistroAsiento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNumeroRegistroAsiento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvNumeroRegistroAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvNumeroRegistroAsiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvNumeroRegistroAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvNumeroRegistroAsiento.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvNumeroRegistroAsiento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvNumeroRegistroAsiento.Location = New System.Drawing.Point(0, 0)
            Me.dgvNumeroRegistroAsiento.MultiSelect = False
            Me.dgvNumeroRegistroAsiento.Name = "dgvNumeroRegistroAsiento"
            Me.dgvNumeroRegistroAsiento.ReadOnly = True
            Me.dgvNumeroRegistroAsiento.RowHeadersVisible = False
            Me.dgvNumeroRegistroAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNumeroRegistroAsiento.Size = New System.Drawing.Size(150, 462)
            Me.dgvNumeroRegistroAsiento.TabIndex = 124
            '
            'dgvAsientoBuscado
            '
            Me.dgvAsientoBuscado.AllowUserToAddRows = False
            Me.dgvAsientoBuscado.AllowUserToDeleteRows = False
            Me.dgvAsientoBuscado.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoBuscado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvAsientoBuscado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvAsientoBuscado.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientoBuscado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientoBuscado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientoBuscado.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvAsientoBuscado.Location = New System.Drawing.Point(3, 9)
            Me.dgvAsientoBuscado.MultiSelect = False
            Me.dgvAsientoBuscado.Name = "dgvAsientoBuscado"
            Me.dgvAsientoBuscado.ReadOnly = True
            Me.dgvAsientoBuscado.RowHeadersVisible = False
            Me.dgvAsientoBuscado.RowHeadersWidth = 20
            Me.dgvAsientoBuscado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoBuscado.Size = New System.Drawing.Size(786, 222)
            Me.dgvAsientoBuscado.TabIndex = 1
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientosDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvAsientosDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ASIENTO, Me.FECHA_ASIENTO, Me.CODIGO_CUENTA_SIENTO, Me.NOMBRE_CUENTA_ASIENTO, Me.CONCEPTO_ASIENTO, Me.DETALLE_ASIENTO, Me.VALOR_DEBE_ASIENTO, Me.VALOR_HABER_ASIENTO, Me.NUMERO_REGISTRO_ASIENTO, Me.DEBE_HABER_ASIENTO, Me.CONSILIAR_ASIENTO, Me.ESTADO_ASIENTO_DIARIO, Me.ID_LIBRO_DIARIO_ASIENTO})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(-2, 9)
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(791, 222)
            Me.dgvAsientosDiario.TabIndex = 125
            '
            'ID_ASIENTO
            '
            Me.ID_ASIENTO.HeaderText = "ORD"
            Me.ID_ASIENTO.Name = "ID_ASIENTO"
            Me.ID_ASIENTO.ReadOnly = True
            Me.ID_ASIENTO.Width = 60
            '
            'FECHA_ASIENTO
            '
            Me.FECHA_ASIENTO.HeaderText = "FECHA"
            Me.FECHA_ASIENTO.Name = "FECHA_ASIENTO"
            Me.FECHA_ASIENTO.ReadOnly = True
            '
            'CODIGO_CUENTA_SIENTO
            '
            Me.CODIGO_CUENTA_SIENTO.HeaderText = "CODIGO CTA"
            Me.CODIGO_CUENTA_SIENTO.Name = "CODIGO_CUENTA_SIENTO"
            Me.CODIGO_CUENTA_SIENTO.ReadOnly = True
            Me.CODIGO_CUENTA_SIENTO.Width = 120
            '
            'NOMBRE_CUENTA_ASIENTO
            '
            Me.NOMBRE_CUENTA_ASIENTO.HeaderText = "NOMB. CTA"
            Me.NOMBRE_CUENTA_ASIENTO.Name = "NOMBRE_CUENTA_ASIENTO"
            Me.NOMBRE_CUENTA_ASIENTO.ReadOnly = True
            Me.NOMBRE_CUENTA_ASIENTO.Width = 250
            '
            'CONCEPTO_ASIENTO
            '
            Me.CONCEPTO_ASIENTO.HeaderText = "CONCEPTO"
            Me.CONCEPTO_ASIENTO.Name = "CONCEPTO_ASIENTO"
            Me.CONCEPTO_ASIENTO.ReadOnly = True
            Me.CONCEPTO_ASIENTO.Width = 250
            '
            'DETALLE_ASIENTO
            '
            Me.DETALLE_ASIENTO.HeaderText = "DETALLE"
            Me.DETALLE_ASIENTO.Name = "DETALLE_ASIENTO"
            Me.DETALLE_ASIENTO.ReadOnly = True
            Me.DETALLE_ASIENTO.Width = 500
            '
            'VALOR_DEBE_ASIENTO
            '
            Me.VALOR_DEBE_ASIENTO.HeaderText = "DEBE"
            Me.VALOR_DEBE_ASIENTO.Name = "VALOR_DEBE_ASIENTO"
            Me.VALOR_DEBE_ASIENTO.ReadOnly = True
            Me.VALOR_DEBE_ASIENTO.Width = 70
            '
            'VALOR_HABER_ASIENTO
            '
            Me.VALOR_HABER_ASIENTO.HeaderText = "HABER"
            Me.VALOR_HABER_ASIENTO.Name = "VALOR_HABER_ASIENTO"
            Me.VALOR_HABER_ASIENTO.ReadOnly = True
            Me.VALOR_HABER_ASIENTO.Width = 70
            '
            'NUMERO_REGISTRO_ASIENTO
            '
            Me.NUMERO_REGISTRO_ASIENTO.HeaderText = "Nº ASIENTO"
            Me.NUMERO_REGISTRO_ASIENTO.Name = "NUMERO_REGISTRO_ASIENTO"
            Me.NUMERO_REGISTRO_ASIENTO.ReadOnly = True
            Me.NUMERO_REGISTRO_ASIENTO.Width = 80
            '
            'DEBE_HABER_ASIENTO
            '
            Me.DEBE_HABER_ASIENTO.HeaderText = "D_H"
            Me.DEBE_HABER_ASIENTO.Name = "DEBE_HABER_ASIENTO"
            Me.DEBE_HABER_ASIENTO.ReadOnly = True
            Me.DEBE_HABER_ASIENTO.Width = 70
            '
            'CONSILIAR_ASIENTO
            '
            Me.CONSILIAR_ASIENTO.HeaderText = "CONS"
            Me.CONSILIAR_ASIENTO.Name = "CONSILIAR_ASIENTO"
            Me.CONSILIAR_ASIENTO.ReadOnly = True
            Me.CONSILIAR_ASIENTO.Width = 70
            '
            'ESTADO_ASIENTO_DIARIO
            '
            Me.ESTADO_ASIENTO_DIARIO.HeaderText = "EST"
            Me.ESTADO_ASIENTO_DIARIO.Name = "ESTADO_ASIENTO_DIARIO"
            Me.ESTADO_ASIENTO_DIARIO.ReadOnly = True
            Me.ESTADO_ASIENTO_DIARIO.Width = 70
            '
            'ID_LIBRO_DIARIO_ASIENTO
            '
            Me.ID_LIBRO_DIARIO_ASIENTO.HeaderText = "ID LIBRO"
            Me.ID_LIBRO_DIARIO_ASIENTO.Name = "ID_LIBRO_DIARIO_ASIENTO"
            Me.ID_LIBRO_DIARIO_ASIENTO.ReadOnly = True
            Me.ID_LIBRO_DIARIO_ASIENTO.Width = 90
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(640, 28)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(138, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(640, 2)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(138, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.gbFormaPago.Controls.Add(Me.rbTransaccionInterna)
            Me.gbFormaPago.Controls.Add(Me.rbCheque)
            Me.gbFormaPago.Controls.Add(Me.rbTransaccionExterna)
            Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
            Me.gbFormaPago.Controls.Add(Me.rbTarjetaCredido)
            Me.gbFormaPago.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.gbFormaPago.Location = New System.Drawing.Point(8, 56)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(301, 40)
            Me.gbFormaPago.TabIndex = 128
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "Pago"
            '
            'rbTransaccionInterna
            '
            Me.rbTransaccionInterna.AutoSize = True
            Me.rbTransaccionInterna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTransaccionInterna.Location = New System.Drawing.Point(226, 15)
            Me.rbTransaccionInterna.Name = "rbTransaccionInterna"
            Me.rbTransaccionInterna.Size = New System.Drawing.Size(70, 17)
            Me.rbTransaccionInterna.TabIndex = 68
            Me.rbTransaccionInterna.TabStop = True
            Me.rbTransaccionInterna.Text = "T Interna"
            Me.rbTransaccionInterna.UseVisualStyleBackColor = True
            '
            'rbCheque
            '
            Me.rbCheque.AutoSize = True
            Me.rbCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCheque.Location = New System.Drawing.Point(3, 15)
            Me.rbCheque.Name = "rbCheque"
            Me.rbCheque.Size = New System.Drawing.Size(44, 17)
            Me.rbCheque.TabIndex = 64
            Me.rbCheque.TabStop = True
            Me.rbCheque.Text = "Che"
            Me.rbCheque.UseVisualStyleBackColor = True
            '
            'rbTransaccionExterna
            '
            Me.rbTransaccionExterna.AutoSize = True
            Me.rbTransaccionExterna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTransaccionExterna.Location = New System.Drawing.Point(152, 15)
            Me.rbTransaccionExterna.Name = "rbTransaccionExterna"
            Me.rbTransaccionExterna.Size = New System.Drawing.Size(74, 17)
            Me.rbTransaccionExterna.TabIndex = 67
            Me.rbTransaccionExterna.TabStop = True
            Me.rbTransaccionExterna.Text = "T. Externa"
            Me.rbTransaccionExterna.UseVisualStyleBackColor = True
            '
            'rbEfectivo
            '
            Me.rbEfectivo.AutoSize = True
            Me.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEfectivo.Location = New System.Drawing.Point(51, 15)
            Me.rbEfectivo.Name = "rbEfectivo"
            Me.rbEfectivo.Size = New System.Drawing.Size(47, 17)
            Me.rbEfectivo.TabIndex = 65
            Me.rbEfectivo.TabStop = True
            Me.rbEfectivo.Text = "Efec"
            Me.rbEfectivo.UseVisualStyleBackColor = True
            '
            'rbTarjetaCredido
            '
            Me.rbTarjetaCredido.AutoSize = True
            Me.rbTarjetaCredido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbTarjetaCredido.Location = New System.Drawing.Point(104, 15)
            Me.rbTarjetaCredido.Name = "rbTarjetaCredido"
            Me.rbTarjetaCredido.Size = New System.Drawing.Size(44, 17)
            Me.rbTarjetaCredido.TabIndex = 66
            Me.rbTarjetaCredido.TabStop = True
            Me.rbTarjetaCredido.Text = "Tarj"
            Me.rbTarjetaCredido.UseVisualStyleBackColor = True
            '
            'lblIdClienteProveedorPersonal
            '
            Me.lblIdClienteProveedorPersonal.AutoSize = True
            Me.lblIdClienteProveedorPersonal.BackColor = System.Drawing.Color.Transparent
            Me.lblIdClienteProveedorPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteProveedorPersonal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteProveedorPersonal.Location = New System.Drawing.Point(435, 56)
            Me.lblIdClienteProveedorPersonal.Name = "lblIdClienteProveedorPersonal"
            Me.lblIdClienteProveedorPersonal.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteProveedorPersonal.TabIndex = 28
            Me.lblIdClienteProveedorPersonal.Text = "0"
            '
            'lblRucClienteProveedorPersonal
            '
            Me.lblRucClienteProveedorPersonal.AutoSize = True
            Me.lblRucClienteProveedorPersonal.BackColor = System.Drawing.Color.Transparent
            Me.lblRucClienteProveedorPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucClienteProveedorPersonal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblRucClienteProveedorPersonal.Location = New System.Drawing.Point(610, 55)
            Me.lblRucClienteProveedorPersonal.Name = "lblRucClienteProveedorPersonal"
            Me.lblRucClienteProveedorPersonal.Size = New System.Drawing.Size(13, 13)
            Me.lblRucClienteProveedorPersonal.TabIndex = 27
            Me.lblRucClienteProveedorPersonal.Text = "0"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarPersonal.FlatAppearance.BorderSize = 0
            Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(751, 64)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(27, 27)
            Me.btnBuscarPersonal.TabIndex = 26
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtNombreClienteProveedorPersonal
            '
            Me.txtNombreClienteProveedorPersonal.BackColor = System.Drawing.Color.White
            Me.txtNombreClienteProveedorPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreClienteProveedorPersonal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreClienteProveedorPersonal.Location = New System.Drawing.Point(434, 71)
            Me.txtNombreClienteProveedorPersonal.Name = "txtNombreClienteProveedorPersonal"
            Me.txtNombreClienteProveedorPersonal.Size = New System.Drawing.Size(310, 21)
            Me.txtNombreClienteProveedorPersonal.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevoAsiento, Me.btnGuardar, Me.btnModificarAsiento, Me.btnCancelar, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(966, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(85, 28)
            Me.btnBuscarAsiento.Text = "BUSCAR"
            '
            'btnNuevoAsiento
            '
            Me.btnNuevoAsiento.Enabled = False
            Me.btnNuevoAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoAsiento.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoAsiento.Name = "btnNuevoAsiento"
            Me.btnNuevoAsiento.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoAsiento.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificarAsiento
            '
            Me.btnModificarAsiento.Enabled = False
            Me.btnModificarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarAsiento.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificarAsiento.Name = "btnModificarAsiento"
            Me.btnModificarAsiento.Size = New System.Drawing.Size(113, 28)
            Me.btnModificarAsiento.Text = "ACTUALIZAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(99, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'kryptonGroupBox1
            '
            Me.kryptonGroupBox1.CaptionOverlap = 0R
            Me.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.kryptonGroupBox1.Location = New System.Drawing.Point(2, 5)
            Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
            '
            'kryptonGroupBox1.Panel
            '
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.btnDelete)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.btnAdd)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.txtHaber)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.txtDebe)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonLabel6)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonLabel5)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonLabel4)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.txtFondoReservaxPagar)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.txtAportePatronal)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.dgvAsientoRoles)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.cbxTipo)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonLabel3)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.dtpfecha)
            Me.kryptonGroupBox1.Panel.Controls.Add(Me.btnGenerar)
            Me.kryptonGroupBox1.Size = New System.Drawing.Size(970, 587)
            Me.kryptonGroupBox1.TabIndex = 2
            Me.kryptonGroupBox1.Values.Heading = "Datos Asiento"
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(908, 7)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(30, 30)
            Me.btnDelete.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnDelete.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnDelete.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnDelete.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.[True]
            Me.btnDelete.TabIndex = 14
            Me.btnDelete.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnDelete.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnDelete.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnDelete.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnDelete.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnDelete.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_000000_FILL0_wght400_GRAD0_opsz24
            Me.btnDelete.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_000000_FILL0_wght400_GRAD0_opsz24
            Me.btnDelete.Values.Text = ""
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(867, 7)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(30, 30)
            Me.btnAdd.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnAdd.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.[False]
            Me.btnAdd.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnAdd.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.[True]
            Me.btnAdd.TabIndex = 13
            Me.btnAdd.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.btnAdd.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.btnAdd.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.btnAdd.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAdd.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAdd.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAdd.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAdd.Values.Text = ""
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(530, 498)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel8.TabIndex = 5
            Me.KryptonLabel8.Values.Text = "TOTAL"
            '
            'txtHaber
            '
            Me.txtHaber.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHaber.Location = New System.Drawing.Point(704, 497)
            Me.txtHaber.Name = "txtHaber"
            Me.txtHaber.ShortcutsEnabled = False
            Me.txtHaber.Size = New System.Drawing.Size(100, 23)
            Me.txtHaber.TabIndex = 4
            Me.txtHaber.Text = "0.00"
            Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDebe
            '
            Me.txtDebe.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDebe.Location = New System.Drawing.Point(589, 498)
            Me.txtDebe.Name = "txtDebe"
            Me.txtDebe.Size = New System.Drawing.Size(100, 23)
            Me.txtDebe.TabIndex = 3
            Me.txtDebe.Text = "0.00"
            Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'kryptonLabel6
            '
            Me.kryptonLabel6.Location = New System.Drawing.Point(391, 10)
            Me.kryptonLabel6.Name = "kryptonLabel6"
            Me.kryptonLabel6.Size = New System.Drawing.Size(67, 20)
            Me.kryptonLabel6.TabIndex = 12
            Me.kryptonLabel6.Values.Text = "FR x Pagar"
            '
            'kryptonLabel5
            '
            Me.kryptonLabel5.Location = New System.Drawing.Point(567, 9)
            Me.kryptonLabel5.Name = "kryptonLabel5"
            Me.kryptonLabel5.Size = New System.Drawing.Size(70, 20)
            Me.kryptonLabel5.TabIndex = 11
            Me.kryptonLabel5.Values.Text = "A. Patronal"
            '
            'kryptonLabel4
            '
            Me.kryptonLabel4.Location = New System.Drawing.Point(7, 8)
            Me.kryptonLabel4.Name = "kryptonLabel4"
            Me.kryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.kryptonLabel4.TabIndex = 10
            Me.kryptonLabel4.Values.Text = "Fecha"
            '
            'txtFondoReservaxPagar
            '
            Me.txtFondoReservaxPagar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoReservaxPagar.Location = New System.Drawing.Point(468, 9)
            Me.txtFondoReservaxPagar.Name = "txtFondoReservaxPagar"
            Me.txtFondoReservaxPagar.Size = New System.Drawing.Size(76, 21)
            Me.txtFondoReservaxPagar.TabIndex = 8
            '
            'txtAportePatronal
            '
            Me.txtAportePatronal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAportePatronal.Location = New System.Drawing.Point(646, 9)
            Me.txtAportePatronal.Name = "txtAportePatronal"
            Me.txtAportePatronal.Size = New System.Drawing.Size(78, 21)
            Me.txtAportePatronal.TabIndex = 7
            Me.txtAportePatronal.Text = "12.15"
            '
            'dgvAsientoRoles
            '
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientoRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientoRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.codigo, Me.cuenta, Me.concepto, Me.detalle, Me.debe, Me.haber})
            Me.dgvAsientoRoles.Location = New System.Drawing.Point(2, 48)
            Me.dgvAsientoRoles.Name = "dgvAsientoRoles"
            Me.dgvAsientoRoles.RowHeadersVisible = False
            Me.dgvAsientoRoles.Size = New System.Drawing.Size(960, 446)
            Me.dgvAsientoRoles.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvAsientoRoles.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
            Me.dgvAsientoRoles.TabIndex = 6
            '
            'id
            '
            Me.id.HeaderText = "Id"
            Me.id.Name = "id"
            Me.id.Width = 50
            '
            'fecha
            '
            Me.fecha.HeaderText = "Fecha"
            Me.fecha.Name = "fecha"
            Me.fecha.Width = 70
            '
            'codigo
            '
            Me.codigo.HeaderText = "Codigo"
            Me.codigo.Name = "codigo"
            Me.codigo.Width = 80
            '
            'cuenta
            '
            Me.cuenta.HeaderText = "Cuenta"
            Me.cuenta.Name = "cuenta"
            Me.cuenta.Width = 190
            '
            'concepto
            '
            Me.concepto.HeaderText = "Concepto"
            Me.concepto.Name = "concepto"
            Me.concepto.Width = 200
            '
            'detalle
            '
            Me.detalle.HeaderText = "Detalle"
            Me.detalle.Name = "detalle"
            Me.detalle.Width = 300
            '
            'debe
            '
            DataGridViewCellStyle9.Format = "N2"
            DataGridViewCellStyle9.NullValue = Nothing
            Me.debe.DefaultCellStyle = DataGridViewCellStyle9
            Me.debe.HeaderText = "Debe"
            Me.debe.Name = "debe"
            '
            'haber
            '
            DataGridViewCellStyle10.Format = "N2"
            DataGridViewCellStyle10.NullValue = Nothing
            Me.haber.DefaultCellStyle = DataGridViewCellStyle10
            Me.haber.HeaderText = "Haber"
            Me.haber.Name = "haber"
            '
            'cbxTipo
            '
            Me.cbxTipo.DropDownWidth = 121
            Me.cbxTipo.IntegralHeight = False
            Me.cbxTipo.Items.AddRange(New Object() {"- Elija Uno - ", "Administrativo", "Operativo"})
            Me.cbxTipo.Location = New System.Drawing.Point(246, 8)
            Me.cbxTipo.Name = "cbxTipo"
            Me.cbxTipo.Size = New System.Drawing.Size(125, 21)
            Me.cbxTipo.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
            Me.cbxTipo.TabIndex = 5
            '
            'kryptonLabel3
            '
            Me.kryptonLabel3.Location = New System.Drawing.Point(202, 8)
            Me.kryptonLabel3.Name = "kryptonLabel3"
            Me.kryptonLabel3.Size = New System.Drawing.Size(34, 20)
            Me.kryptonLabel3.TabIndex = 4
            Me.kryptonLabel3.Values.Text = "Tipo"
            '
            'dtpfecha
            '
            Me.dtpfecha.CalendarTodayDate = New Date(2024, 9, 26, 0, 0, 0, 0)
            Me.dtpfecha.CustomFormat = "MMMM  - yyyy"
            Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpfecha.Location = New System.Drawing.Point(55, 9)
            Me.dtpfecha.Name = "dtpfecha"
            Me.dtpfecha.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
            Me.dtpfecha.Size = New System.Drawing.Size(125, 21)
            Me.dtpfecha.TabIndex = 1
            '
            'btnGenerar
            '
            Me.btnGenerar.Location = New System.Drawing.Point(753, 5)
            Me.btnGenerar.Name = "btnGenerar"
            Me.btnGenerar.Size = New System.Drawing.Size(90, 25)
            Me.btnGenerar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.btnGenerar.StateNormal.Border.Rounding = 5.0!
            Me.btnGenerar.TabIndex = 0
            Me.btnGenerar.Values.Text = "Generar"
            '
            'KryptonDockableNavigator1
            '
            Me.KryptonDockableNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonDockableNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonDockableNavigator1.Name = "KryptonDockableNavigator1"
            Me.KryptonDockableNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup
            Me.KryptonDockableNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage3, Me.KryptonPage4})
            Me.KryptonDockableNavigator1.SelectedIndex = 0
            Me.KryptonDockableNavigator1.Size = New System.Drawing.Size(968, 587)
            Me.KryptonDockableNavigator1.TabIndex = 187
            Me.KryptonDockableNavigator1.Text = "KryptonDockableNavigator1"
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.btnEliminar)
            Me.KryptonPage3.Controls.Add(Me.MenuStrip1)
            Me.KryptonPage3.Controls.Add(Me.txtTotalHaber)
            Me.KryptonPage3.Controls.Add(Me.btnAgregar)
            Me.KryptonPage3.Controls.Add(Me.txtTotalDebe)
            Me.KryptonPage3.Controls.Add(Me.lblTotal)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox5)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox4)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox3)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(966, 558)
            Me.KryptonPage3.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.KryptonPage3.Text = "Asientos"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "EE3C6E7505E746DF0297AD06BDEBCD19"
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Enabled = False
            Me.txtTotalHaber.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(822, 532)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(100, 23)
            Me.txtTotalHaber.TabIndex = 136
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Enabled = False
            Me.txtTotalDebe.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(716, 532)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(100, 23)
            Me.txtTotalDebe.TabIndex = 137
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.lblTotal.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblTotal.Location = New System.Drawing.Point(653, 535)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(40, 15)
            Me.lblTotal.TabIndex = 135
            Me.lblTotal.Text = "Total"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(162, 260)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dgvAsientosDiario)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.dgvAsientoBuscado)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(796, 258)
            Me.KryptonGroupBox5.TabIndex = 134
            Me.KryptonGroupBox5.Values.Heading = "Transaccion de Diario"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(162, 99)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtValorHaberAsiento)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtValorDebeAsiento)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtDetalleAsiento)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.btnBuscarPersonal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblCodigoCuentaContable)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblIdClienteProveedorPersonal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.lblRucClienteProveedorPersonal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbCuentaBancos)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtNombreClienteProveedorPersonal)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbBancos)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbCuentasContables)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbConcepto)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaAsiento)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.gbFormaPago)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbCentroCosto)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(797, 157)
            Me.KryptonGroupBox4.TabIndex = 133
            Me.KryptonGroupBox4.Values.Heading = "Datos Asiento"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(643, 102)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel18.TabIndex = 132
            Me.KryptonLabel18.Values.Text = "Haber"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(507, 102)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel17.TabIndex = 131
            Me.KryptonLabel17.Values.Text = "Debe"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(7, 102)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel16.TabIndex = 130
            Me.KryptonLabel16.Values.Text = "Detalle"
            '
            'lblCodigoCuentaContable
            '
            Me.lblCodigoCuentaContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaContable.Location = New System.Drawing.Point(539, 31)
            Me.lblCodigoCuentaContable.Name = "lblCodigoCuentaContable"
            Me.lblCodigoCuentaContable.Size = New System.Drawing.Size(29, 21)
            Me.lblCodigoCuentaContable.TabIndex = 37
            Me.lblCodigoCuentaContable.Text = "0"
            Me.lblCodigoCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblCodigoCuentaContable.Visible = False
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(319, 71)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(109, 20)
            Me.KryptonLabel15.TabIndex = 129
            Me.KryptonLabel15.Values.Text = "Proveedor/Cliente"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(579, 28)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel14.TabIndex = 38
            Me.KryptonLabel14.Values.Text = "Cuenta"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(579, 3)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel13.TabIndex = 37
            Me.KryptonLabel13.Values.Text = "Banco"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(211, 29)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(81, 20)
            Me.KryptonLabel12.TabIndex = 35
            Me.KryptonLabel12.Values.Text = "Cta Contable"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(211, 2)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel11.TabIndex = 34
            Me.KryptonLabel11.Values.Text = "Concepto"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(9, 29)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel10.TabIndex = 33
            Me.KryptonLabel10.Values.Text = "Centro Costo"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(7, 3)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel9.TabIndex = 0
            Me.KryptonLabel9.Values.Text = "Fecha"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(2, 36)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvNumeroRegistroAsiento)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(154, 486)
            Me.KryptonGroupBox3.TabIndex = 132
            Me.KryptonGroupBox3.Values.Heading = "Asientos"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(162, 36)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpAsientoHasta)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpAsientoDesde)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNumeroAsientoBuscar)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbFechaAsiento)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbNumeroAsiento)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(797, 59)
            Me.KryptonGroupBox2.TabIndex = 131
            Me.KryptonGroupBox2.Values.Heading = "Busqueda"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(523, 3)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel7.TabIndex = 7
            Me.KryptonLabel7.Values.Text = "Hasta"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(290, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel2.TabIndex = 5
            Me.KryptonLabel2.Values.Text = "Desde"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(146, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel1.TabIndex = 3
            Me.KryptonLabel1.Values.Text = "Asiento"
            '
            'KryptonPage4
            '
            Me.KryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage4.Controls.Add(Me.kryptonGroupBox1)
            Me.KryptonPage4.Flags = 65534
            Me.KryptonPage4.LastVisibleSet = True
            Me.KryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage4.Name = "KryptonPage4"
            Me.KryptonPage4.Size = New System.Drawing.Size(966, 558)
            Me.KryptonPage4.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage4.Text = "Asientos Roles"
            Me.KryptonPage4.ToolTipTitle = "page tooltip"
            Me.KryptonPage4.UniqueName = "a9858e40b3764290cab36cb635175c42"
            '
            'FormAjustarAsientosLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(968, 587)
            Me.Controls.Add(Me.KryptonDockableNavigator1)
            Me.Controls.Add(Me.GroupBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAjustarAsientosLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AJUSTAR ASIENTOS LIBRO DIARIO"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.dgvNumeroRegistroAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbFormaPago.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.kryptonGroupBox1.Panel.ResumeLayout(False)
            Me.kryptonGroupBox1.Panel.PerformLayout()
            CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.kryptonGroupBox1.ResumeLayout(False)
            CType(Me.dgvAsientoRoles, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonDockableNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonDockableNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.KryptonPage3.PerformLayout()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroAsientoBuscar As System.Windows.Forms.TextBox
        Friend WithEvents rbFechaAsiento As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumeroAsiento As System.Windows.Forms.RadioButton
        Friend WithEvents txtDetalleAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtValorDebeAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtValorHaberAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroRegistro As System.Windows.Forms.TextBox
        Friend WithEvents txtDebeHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtConciliarAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtEstadoAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtIdLibroDiario As System.Windows.Forms.TextBox
        Friend WithEvents lblIdLibroDiario As System.Windows.Forms.Label
        Friend WithEvents lblEstadoAsiento As System.Windows.Forms.Label
        Friend WithEvents lblConciliarAsiento As System.Windows.Forms.Label
        Friend WithEvents lblDebeHaber As System.Windows.Forms.Label
        Friend WithEvents lblNumeroRegistro As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents dgvNumeroRegistroAsiento As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaAsiento As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtIdAsiento As System.Windows.Forms.TextBox
        Friend WithEvents dgvAsientoBuscado As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccionExterna As System.Windows.Forms.RadioButton
        Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbTarjetaCredido As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccionInterna As System.Windows.Forms.RadioButton
        Friend WithEvents lblRucClienteProveedorPersonal As System.Windows.Forms.Label
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtNombreClienteProveedorPersonal As System.Windows.Forms.TextBox
        Friend WithEvents lblIdClienteProveedorPersonal As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ID_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FECHA_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CODIGO_CUENTA_SIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE_CUENTA_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONCEPTO_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DETALLE_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_DEBE_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents VALOR_HABER_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NUMERO_REGISTRO_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DEBE_HABER_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CONSILIAR_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ESTADO_ASIENTO_DIARIO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_LIBRO_DIARIO_ASIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Private WithEvents kryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Private WithEvents kryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Private WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Private WithEvents txtFondoReservaxPagar As TextBox
        Private WithEvents txtAportePatronal As TextBox
        Private WithEvents cbxTipo As Krypton.Toolkit.KryptonComboBox
        Private WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Private WithEvents dtpfecha As Krypton.Toolkit.KryptonDateTimePicker
        Private WithEvents dgvAsientoRoles As Krypton.Toolkit.KryptonDataGridView
        Private WithEvents btnGenerar As Krypton.Toolkit.KryptonButton
        Friend WithEvents txtHaber As TextBox
        Friend WithEvents txtDebe As TextBox
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonDockableNavigator1 As ComponentFactory.Krypton.Docking.KryptonDockableNavigator
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage4 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents id As DataGridViewTextBoxColumn
        Friend WithEvents fecha As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents cuenta As DataGridViewTextBoxColumn
        Friend WithEvents concepto As DataGridViewTextBoxColumn
        Friend WithEvents detalle As DataGridViewTextBoxColumn
        Friend WithEvents debe As DataGridViewTextBoxColumn
        Friend WithEvents haber As DataGridViewTextBoxColumn
        Friend WithEvents btnDelete As Krypton.Toolkit.KryptonButton
        Friend WithEvents btnAdd As Krypton.Toolkit.KryptonButton
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox4 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblCodigoCuentaContable As Label
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents txtTotalHaber As TextBox
        Friend WithEvents txtTotalDebe As TextBox
        Friend WithEvents lblTotal As Label
    End Class
End Namespace