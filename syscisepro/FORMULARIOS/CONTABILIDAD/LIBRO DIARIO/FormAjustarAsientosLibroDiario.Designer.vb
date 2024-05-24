Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAjustarAsientosLibroDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAjustarAsientosLibroDiario))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbBuscarAsiento = New System.Windows.Forms.GroupBox()
            Me.rbFechaAsiento = New System.Windows.Forms.RadioButton()
            Me.rbNumeroAsiento = New System.Windows.Forms.RadioButton()
            Me.lblHasta = New System.Windows.Forms.Label()
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
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.gbDebeHaber = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbDetalle = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtIdAsiento = New System.Windows.Forms.TextBox()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.pCentroCosto = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblCodigoCuentaContable = New System.Windows.Forms.Label()
            Me.cmbCuentasContables = New System.Windows.Forms.ComboBox()
            Me.cmbConcepto = New System.Windows.Forms.ComboBox()
            Me.dtpFechaAsiento = New System.Windows.Forms.DateTimePicker()
            Me.cmbCentroCosto = New System.Windows.Forms.ComboBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.gbNumeroAsiento = New System.Windows.Forms.GroupBox()
            Me.gbRnagoFechas = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
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
            Me.gbBanco = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmbCuentaBancos = New System.Windows.Forms.ComboBox()
            Me.cmbBancos = New System.Windows.Forms.ComboBox()
            Me.gbFormaPago = New System.Windows.Forms.GroupBox()
            Me.rbTransaccionInterna = New System.Windows.Forms.RadioButton()
            Me.rbCheque = New System.Windows.Forms.RadioButton()
            Me.rbTransaccionExterna = New System.Windows.Forms.RadioButton()
            Me.rbEfectivo = New System.Windows.Forms.RadioButton()
            Me.rbTarjetaCredido = New System.Windows.Forms.RadioButton()
            Me.gbClienteProveedorPersonal = New System.Windows.Forms.GroupBox()
            Me.lblIdClienteProveedorPersonal = New System.Windows.Forms.Label()
            Me.lblRucClienteProveedorPersonal = New System.Windows.Forms.Label()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtNombreClienteProveedorPersonal = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.gbBuscarAsiento.SuspendLayout()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            Me.gbDebeHaber.SuspendLayout()
            Me.gbDetalle.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.panelDetalle.SuspendLayout()
            Me.pCentroCosto.SuspendLayout()
            Me.gbNumeroAsiento.SuspendLayout()
            Me.gbRnagoFechas.SuspendLayout()
            CType(Me.dgvNumeroRegistroAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBanco.SuspendLayout()
            Me.gbFormaPago.SuspendLayout()
            Me.gbClienteProveedorPersonal.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbBuscarAsiento
            '
            Me.gbBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.gbBuscarAsiento.Controls.Add(Me.rbFechaAsiento)
            Me.gbBuscarAsiento.Controls.Add(Me.rbNumeroAsiento)
            Me.gbBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBuscarAsiento.Location = New System.Drawing.Point(190, 26)
            Me.gbBuscarAsiento.Name = "gbBuscarAsiento"
            Me.gbBuscarAsiento.Size = New System.Drawing.Size(163, 50)
            Me.gbBuscarAsiento.TabIndex = 0
            Me.gbBuscarAsiento.TabStop = False
            Me.gbBuscarAsiento.Text = "BUSCAR ASIENTO"
            '
            'rbFechaAsiento
            '
            Me.rbFechaAsiento.AutoSize = True
            Me.rbFechaAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFechaAsiento.Location = New System.Drawing.Point(102, 23)
            Me.rbFechaAsiento.Name = "rbFechaAsiento"
            Me.rbFechaAsiento.Size = New System.Drawing.Size(55, 17)
            Me.rbFechaAsiento.TabIndex = 2
            Me.rbFechaAsiento.Text = "FECHA"
            Me.rbFechaAsiento.UseVisualStyleBackColor = True
            '
            'rbNumeroAsiento
            '
            Me.rbNumeroAsiento.AutoSize = True
            Me.rbNumeroAsiento.Checked = True
            Me.rbNumeroAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNumeroAsiento.Location = New System.Drawing.Point(11, 23)
            Me.rbNumeroAsiento.Name = "rbNumeroAsiento"
            Me.rbNumeroAsiento.Size = New System.Drawing.Size(85, 17)
            Me.rbNumeroAsiento.TabIndex = 1
            Me.rbNumeroAsiento.TabStop = True
            Me.rbNumeroAsiento.Text = "Nº ASIENTO"
            Me.rbNumeroAsiento.UseVisualStyleBackColor = True
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.Location = New System.Drawing.Point(334, 23)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(43, 13)
            Me.lblHasta.TabIndex = 8
            Me.lblHasta.Text = "HASTA:"
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpAsientoHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(383, 20)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(261, 20)
            Me.dtpAsientoHasta.TabIndex = 7
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.CalendarMonthBackground = System.Drawing.Color.White
            Me.dtpAsientoDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(69, 20)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(251, 20)
            Me.dtpAsientoDesde.TabIndex = 6
            '
            'txtNumeroAsientoBuscar
            '
            Me.txtNumeroAsientoBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroAsientoBuscar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroAsientoBuscar.Location = New System.Drawing.Point(6, 19)
            Me.txtNumeroAsientoBuscar.Name = "txtNumeroAsientoBuscar"
            Me.txtNumeroAsientoBuscar.Size = New System.Drawing.Size(93, 20)
            Me.txtNumeroAsientoBuscar.TabIndex = 4
            '
            'txtDetalleAsiento
            '
            Me.txtDetalleAsiento.BackColor = System.Drawing.Color.White
            Me.txtDetalleAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalleAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalleAsiento.Location = New System.Drawing.Point(5, 17)
            Me.txtDetalleAsiento.Name = "txtDetalleAsiento"
            Me.txtDetalleAsiento.Size = New System.Drawing.Size(623, 20)
            Me.txtDetalleAsiento.TabIndex = 7
            Me.txtDetalleAsiento.Text = "..."
            '
            'txtValorDebeAsiento
            '
            Me.txtValorDebeAsiento.BackColor = System.Drawing.Color.White
            Me.txtValorDebeAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDebeAsiento.Location = New System.Drawing.Point(6, 17)
            Me.txtValorDebeAsiento.Name = "txtValorDebeAsiento"
            Me.txtValorDebeAsiento.Size = New System.Drawing.Size(143, 20)
            Me.txtValorDebeAsiento.TabIndex = 12
            Me.txtValorDebeAsiento.Text = "0.00"
            Me.txtValorDebeAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtValorHaberAsiento
            '
            Me.txtValorHaberAsiento.BackColor = System.Drawing.Color.White
            Me.txtValorHaberAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorHaberAsiento.Location = New System.Drawing.Point(184, 17)
            Me.txtValorHaberAsiento.Name = "txtValorHaberAsiento"
            Me.txtValorHaberAsiento.Size = New System.Drawing.Size(138, 20)
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
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.White
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(190, 653)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(963, 37)
            Me.gbTotalDebeTotalHaber.TabIndex = 112
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.BackColor = System.Drawing.Color.White
            Me.txtTotalHaber.Enabled = False
            Me.txtTotalHaber.Location = New System.Drawing.Point(857, 11)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(100, 20)
            Me.txtTotalHaber.TabIndex = 35
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.BackColor = System.Drawing.Color.White
            Me.txtTotalDebe.Enabled = False
            Me.txtTotalDebe.Location = New System.Drawing.Point(751, 11)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(100, 20)
            Me.txtTotalDebe.TabIndex = 36
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Location = New System.Drawing.Point(695, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(49, 13)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'gbDebeHaber
            '
            Me.gbDebeHaber.BackColor = System.Drawing.Color.White
            Me.gbDebeHaber.Controls.Add(Me.Label1)
            Me.gbDebeHaber.Controls.Add(Me.txtValorDebeAsiento)
            Me.gbDebeHaber.Controls.Add(Me.txtValorHaberAsiento)
            Me.gbDebeHaber.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDebeHaber.Location = New System.Drawing.Point(823, 227)
            Me.gbDebeHaber.Name = "gbDebeHaber"
            Me.gbDebeHaber.Size = New System.Drawing.Size(328, 47)
            Me.gbDebeHaber.TabIndex = 115
            Me.gbDebeHaber.TabStop = False
            Me.gbDebeHaber.Text = "DEBE"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(187, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "HABER"
            '
            'gbDetalle
            '
            Me.gbDetalle.BackColor = System.Drawing.Color.White
            Me.gbDetalle.Controls.Add(Me.txtDetalleAsiento)
            Me.gbDetalle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalle.Location = New System.Drawing.Point(189, 227)
            Me.gbDetalle.Name = "gbDetalle"
            Me.gbDetalle.Size = New System.Drawing.Size(634, 47)
            Me.gbDetalle.TabIndex = 118
            Me.gbDetalle.TabStop = False
            Me.gbDetalle.Text = "DETALLE"
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
            Me.GroupBox3.Location = New System.Drawing.Point(635, 81)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(343, 59)
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
            'panelDetalle
            '
            Me.panelDetalle.BackColor = System.Drawing.Color.White
            Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelDetalle.Controls.Add(Me.btnEliminar)
            Me.panelDetalle.Controls.Add(Me.btnAgregar)
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(189, 274)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(962, 30)
            Me.panelDetalle.TabIndex = 120
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.White
            Me.btnEliminar.Enabled = False
            Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
            Me.btnEliminar.Location = New System.Drawing.Point(928, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(32, 28)
            Me.btnEliminar.TabIndex = 19
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'btnAgregar
            '
            Me.btnAgregar.BackColor = System.Drawing.Color.White
            Me.btnAgregar.Enabled = False
            Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
            Me.btnAgregar.Location = New System.Drawing.Point(897, 0)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(32, 28)
            Me.btnAgregar.TabIndex = 18
            Me.btnAgregar.UseVisualStyleBackColor = False
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(354, 4)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(176, 18)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "TRANSACCIÓN DE DIARIO"
            '
            'pCentroCosto
            '
            Me.pCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pCentroCosto.Controls.Add(Me.Label2)
            Me.pCentroCosto.Controls.Add(Me.lblCodigoCuentaContable)
            Me.pCentroCosto.Controls.Add(Me.cmbCuentasContables)
            Me.pCentroCosto.Controls.Add(Me.cmbConcepto)
            Me.pCentroCosto.Controls.Add(Me.dtpFechaAsiento)
            Me.pCentroCosto.Controls.Add(Me.cmbCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.lblCentroCosto)
            Me.pCentroCosto.Controls.Add(Me.lblActividad)
            Me.pCentroCosto.Controls.Add(Me.lblConcepto)
            Me.pCentroCosto.Location = New System.Drawing.Point(189, 76)
            Me.pCentroCosto.Name = "pCentroCosto"
            Me.pCentroCosto.Size = New System.Drawing.Size(962, 65)
            Me.pCentroCosto.TabIndex = 121
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(365, 37)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(91, 13)
            Me.Label2.TabIndex = 38
            Me.Label2.Text = "CTA. CONTABLE:"
            '
            'lblCodigoCuentaContable
            '
            Me.lblCodigoCuentaContable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoCuentaContable.Location = New System.Drawing.Point(849, 34)
            Me.lblCodigoCuentaContable.Name = "lblCodigoCuentaContable"
            Me.lblCodigoCuentaContable.Size = New System.Drawing.Size(107, 21)
            Me.lblCodigoCuentaContable.TabIndex = 37
            Me.lblCodigoCuentaContable.Text = "0"
            Me.lblCodigoCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblCodigoCuentaContable.Visible = False
            '
            'cmbCuentasContables
            '
            Me.cmbCuentasContables.BackColor = System.Drawing.Color.White
            Me.cmbCuentasContables.DropDownHeight = 200
            Me.cmbCuentasContables.DropDownWidth = 500
            Me.cmbCuentasContables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentasContables.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCuentasContables.FormattingEnabled = True
            Me.cmbCuentasContables.IntegralHeight = False
            Me.cmbCuentasContables.Location = New System.Drawing.Point(462, 34)
            Me.cmbCuentasContables.Name = "cmbCuentasContables"
            Me.cmbCuentasContables.Size = New System.Drawing.Size(381, 21)
            Me.cmbCuentasContables.TabIndex = 36
            '
            'cmbConcepto
            '
            Me.cmbConcepto.BackColor = System.Drawing.Color.White
            Me.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbConcepto.DropDownWidth = 300
            Me.cmbConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbConcepto.FormattingEnabled = True
            Me.cmbConcepto.Items.AddRange(New Object() {"COMPROBANTE ASIENTO DE DIARIO", "COMPROBANTE DIARIO DE AJUSTE", "COMPROBANTE DIARIO DE CRUCE DE CTAS", "COMPROBANTE DIARIO DE COMPRA", "COMPROBANTE DIARIO DE GASTO", "COMPROBANTE DIARIO DE NOTA DE CRÉDITO", "COMPROBANTE DIARIO DE VENTA", "COMPROBANTE DE EGRESO", "COMPROBANTE DE INGRESO", "COMPROBANTE DE INGRESO CUENTAS POR PAGAR", "COMPROBANTE DE INGRESO CUENTAS POR COBRAR", "NOTA DE CRÉDITO", "NOTA DE DEBITO", "CAJA CHICA", "FONDO ROTATIVO"})
            Me.cmbConcepto.Location = New System.Drawing.Point(462, 7)
            Me.cmbConcepto.Name = "cmbConcepto"
            Me.cmbConcepto.Size = New System.Drawing.Size(494, 21)
            Me.cmbConcepto.TabIndex = 33
            '
            'dtpFechaAsiento
            '
            Me.dtpFechaAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaAsiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaAsiento.Location = New System.Drawing.Point(97, 5)
            Me.dtpFechaAsiento.Name = "dtpFechaAsiento"
            Me.dtpFechaAsiento.Size = New System.Drawing.Size(133, 20)
            Me.dtpFechaAsiento.TabIndex = 32
            '
            'cmbCentroCosto
            '
            Me.cmbCentroCosto.BackColor = System.Drawing.Color.White
            Me.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCentroCosto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCentroCosto.FormattingEnabled = True
            Me.cmbCentroCosto.Location = New System.Drawing.Point(97, 34)
            Me.cmbCentroCosto.Name = "cmbCentroCosto"
            Me.cmbCentroCosto.Size = New System.Drawing.Size(256, 21)
            Me.cmbCentroCosto.TabIndex = 29
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(6, 37)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(85, 13)
            Me.lblCentroCosto.TabIndex = 28
            Me.lblCentroCosto.Text = "CENTRO COSTO:"
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(6, 10)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(43, 13)
            Me.lblActividad.TabIndex = 5
            Me.lblActividad.Text = "FECHA:"
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(365, 11)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(61, 13)
            Me.lblConcepto.TabIndex = 6
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'gbNumeroAsiento
            '
            Me.gbNumeroAsiento.BackColor = System.Drawing.Color.White
            Me.gbNumeroAsiento.Controls.Add(Me.txtNumeroAsientoBuscar)
            Me.gbNumeroAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroAsiento.Location = New System.Drawing.Point(353, 26)
            Me.gbNumeroAsiento.Name = "gbNumeroAsiento"
            Me.gbNumeroAsiento.Size = New System.Drawing.Size(108, 50)
            Me.gbNumeroAsiento.TabIndex = 122
            Me.gbNumeroAsiento.TabStop = False
            Me.gbNumeroAsiento.Text = "NÚMERO ASIENTO"
            '
            'gbRnagoFechas
            '
            Me.gbRnagoFechas.BackColor = System.Drawing.Color.White
            Me.gbRnagoFechas.Controls.Add(Me.Label3)
            Me.gbRnagoFechas.Controls.Add(Me.dtpAsientoDesde)
            Me.gbRnagoFechas.Controls.Add(Me.lblHasta)
            Me.gbRnagoFechas.Controls.Add(Me.dtpAsientoHasta)
            Me.gbRnagoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRnagoFechas.Location = New System.Drawing.Point(461, 26)
            Me.gbRnagoFechas.Name = "gbRnagoFechas"
            Me.gbRnagoFechas.Size = New System.Drawing.Size(690, 50)
            Me.gbRnagoFechas.TabIndex = 123
            Me.gbRnagoFechas.TabStop = False
            Me.gbRnagoFechas.Text = "RANGO FECHAS"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(20, 23)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 185
            Me.Label3.Text = "DESDE:"
            '
            'dgvNumeroRegistroAsiento
            '
            Me.dgvNumeroRegistroAsiento.AllowUserToAddRows = False
            Me.dgvNumeroRegistroAsiento.AllowUserToDeleteRows = False
            Me.dgvNumeroRegistroAsiento.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvNumeroRegistroAsiento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvNumeroRegistroAsiento.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvNumeroRegistroAsiento.Location = New System.Drawing.Point(0, 45)
            Me.dgvNumeroRegistroAsiento.MultiSelect = False
            Me.dgvNumeroRegistroAsiento.Name = "dgvNumeroRegistroAsiento"
            Me.dgvNumeroRegistroAsiento.ReadOnly = True
            Me.dgvNumeroRegistroAsiento.RowHeadersVisible = False
            Me.dgvNumeroRegistroAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvNumeroRegistroAsiento.Size = New System.Drawing.Size(184, 646)
            Me.dgvNumeroRegistroAsiento.TabIndex = 124
            '
            'dgvAsientoBuscado
            '
            Me.dgvAsientoBuscado.AllowUserToAddRows = False
            Me.dgvAsientoBuscado.AllowUserToDeleteRows = False
            Me.dgvAsientoBuscado.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoBuscado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvAsientoBuscado.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvAsientoBuscado.Location = New System.Drawing.Point(189, 305)
            Me.dgvAsientoBuscado.MultiSelect = False
            Me.dgvAsientoBuscado.Name = "dgvAsientoBuscado"
            Me.dgvAsientoBuscado.ReadOnly = True
            Me.dgvAsientoBuscado.RowHeadersVisible = False
            Me.dgvAsientoBuscado.RowHeadersWidth = 20
            Me.dgvAsientoBuscado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoBuscado.Size = New System.Drawing.Size(962, 354)
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
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(188, 304)
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(962, 354)
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
            'gbBanco
            '
            Me.gbBanco.BackColor = System.Drawing.Color.White
            Me.gbBanco.Controls.Add(Me.Label10)
            Me.gbBanco.Controls.Add(Me.cmbCuentaBancos)
            Me.gbBanco.Controls.Add(Me.cmbBancos)
            Me.gbBanco.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBanco.Location = New System.Drawing.Point(738, 143)
            Me.gbBanco.Name = "gbBanco"
            Me.gbBanco.Size = New System.Drawing.Size(413, 40)
            Me.gbBanco.TabIndex = 127
            Me.gbBanco.TabStop = False
            Me.gbBanco.Text = "  BANCO: "
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(292, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 34
            Me.Label10.Text = "CA/CC/TA:"
            '
            'cmbCuentaBancos
            '
            Me.cmbCuentaBancos.BackColor = System.Drawing.Color.White
            Me.cmbCuentaBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCuentaBancos.DropDownWidth = 130
            Me.cmbCuentaBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCuentaBancos.FormattingEnabled = True
            Me.cmbCuentaBancos.Location = New System.Drawing.Point(290, 13)
            Me.cmbCuentaBancos.Name = "cmbCuentaBancos"
            Me.cmbCuentaBancos.Size = New System.Drawing.Size(117, 21)
            Me.cmbCuentaBancos.TabIndex = 29
            '
            'cmbBancos
            '
            Me.cmbBancos.BackColor = System.Drawing.Color.White
            Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbBancos.DropDownWidth = 140
            Me.cmbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbBancos.FormattingEnabled = True
            Me.cmbBancos.Location = New System.Drawing.Point(6, 13)
            Me.cmbBancos.Name = "cmbBancos"
            Me.cmbBancos.Size = New System.Drawing.Size(278, 21)
            Me.cmbBancos.TabIndex = 25
            '
            'gbFormaPago
            '
            Me.gbFormaPago.BackColor = System.Drawing.Color.White
            Me.gbFormaPago.Controls.Add(Me.rbTransaccionInterna)
            Me.gbFormaPago.Controls.Add(Me.rbCheque)
            Me.gbFormaPago.Controls.Add(Me.rbTransaccionExterna)
            Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
            Me.gbFormaPago.Controls.Add(Me.rbTarjetaCredido)
            Me.gbFormaPago.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbFormaPago.Location = New System.Drawing.Point(189, 143)
            Me.gbFormaPago.Name = "gbFormaPago"
            Me.gbFormaPago.Size = New System.Drawing.Size(549, 40)
            Me.gbFormaPago.TabIndex = 128
            Me.gbFormaPago.TabStop = False
            Me.gbFormaPago.Text = "FORMA PAGO:"
            '
            'rbTransaccionInterna
            '
            Me.rbTransaccionInterna.AutoSize = True
            Me.rbTransaccionInterna.Location = New System.Drawing.Point(374, 15)
            Me.rbTransaccionInterna.Name = "rbTransaccionInterna"
            Me.rbTransaccionInterna.Size = New System.Drawing.Size(103, 17)
            Me.rbTransaccionInterna.TabIndex = 68
            Me.rbTransaccionInterna.TabStop = True
            Me.rbTransaccionInterna.Text = "Trans Interna"
            Me.rbTransaccionInterna.UseVisualStyleBackColor = True
            '
            'rbCheque
            '
            Me.rbCheque.AutoSize = True
            Me.rbCheque.Location = New System.Drawing.Point(22, 15)
            Me.rbCheque.Name = "rbCheque"
            Me.rbCheque.Size = New System.Drawing.Size(61, 17)
            Me.rbCheque.TabIndex = 64
            Me.rbCheque.TabStop = True
            Me.rbCheque.Text = "Cheque"
            Me.rbCheque.UseVisualStyleBackColor = True
            '
            'rbTransaccionExterna
            '
            Me.rbTransaccionExterna.AutoSize = True
            Me.rbTransaccionExterna.Location = New System.Drawing.Point(258, 15)
            Me.rbTransaccionExterna.Name = "rbTransaccionExterna"
            Me.rbTransaccionExterna.Size = New System.Drawing.Size(103, 17)
            Me.rbTransaccionExterna.TabIndex = 67
            Me.rbTransaccionExterna.TabStop = True
            Me.rbTransaccionExterna.Text = "Trans Externa"
            Me.rbTransaccionExterna.UseVisualStyleBackColor = True
            '
            'rbEfectivo
            '
            Me.rbEfectivo.AutoSize = True
            Me.rbEfectivo.Location = New System.Drawing.Point(94, 15)
            Me.rbEfectivo.Name = "rbEfectivo"
            Me.rbEfectivo.Size = New System.Drawing.Size(73, 17)
            Me.rbEfectivo.TabIndex = 65
            Me.rbEfectivo.TabStop = True
            Me.rbEfectivo.Text = "Efectivo"
            Me.rbEfectivo.UseVisualStyleBackColor = True
            '
            'rbTarjetaCredido
            '
            Me.rbTarjetaCredido.AutoSize = True
            Me.rbTarjetaCredido.Location = New System.Drawing.Point(178, 15)
            Me.rbTarjetaCredido.Name = "rbTarjetaCredido"
            Me.rbTarjetaCredido.Size = New System.Drawing.Size(67, 17)
            Me.rbTarjetaCredido.TabIndex = 66
            Me.rbTarjetaCredido.TabStop = True
            Me.rbTarjetaCredido.Text = "Tarjeta"
            Me.rbTarjetaCredido.UseVisualStyleBackColor = True
            '
            'gbClienteProveedorPersonal
            '
            Me.gbClienteProveedorPersonal.BackColor = System.Drawing.Color.White
            Me.gbClienteProveedorPersonal.Controls.Add(Me.lblIdClienteProveedorPersonal)
            Me.gbClienteProveedorPersonal.Controls.Add(Me.lblRucClienteProveedorPersonal)
            Me.gbClienteProveedorPersonal.Controls.Add(Me.btnBuscarPersonal)
            Me.gbClienteProveedorPersonal.Controls.Add(Me.txtNombreClienteProveedorPersonal)
            Me.gbClienteProveedorPersonal.Controls.Add(Me.Label5)
            Me.gbClienteProveedorPersonal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteProveedorPersonal.Location = New System.Drawing.Point(189, 182)
            Me.gbClienteProveedorPersonal.Name = "gbClienteProveedorPersonal"
            Me.gbClienteProveedorPersonal.Size = New System.Drawing.Size(962, 45)
            Me.gbClienteProveedorPersonal.TabIndex = 130
            Me.gbClienteProveedorPersonal.TabStop = False
            '
            'lblIdClienteProveedorPersonal
            '
            Me.lblIdClienteProveedorPersonal.AutoSize = True
            Me.lblIdClienteProveedorPersonal.Location = New System.Drawing.Point(842, 0)
            Me.lblIdClienteProveedorPersonal.Name = "lblIdClienteProveedorPersonal"
            Me.lblIdClienteProveedorPersonal.Size = New System.Drawing.Size(13, 13)
            Me.lblIdClienteProveedorPersonal.TabIndex = 28
            Me.lblIdClienteProveedorPersonal.Text = "0"
            '
            'lblRucClienteProveedorPersonal
            '
            Me.lblRucClienteProveedorPersonal.AutoSize = True
            Me.lblRucClienteProveedorPersonal.Location = New System.Drawing.Point(372, 0)
            Me.lblRucClienteProveedorPersonal.Name = "lblRucClienteProveedorPersonal"
            Me.lblRucClienteProveedorPersonal.Size = New System.Drawing.Size(13, 13)
            Me.lblRucClienteProveedorPersonal.TabIndex = 27
            Me.lblRucClienteProveedorPersonal.Text = "0"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = CType(resources.GetObject("btnBuscarPersonal.Image"), System.Drawing.Image)
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(927, 14)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(29, 23)
            Me.btnBuscarPersonal.TabIndex = 26
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtNombreClienteProveedorPersonal
            '
            Me.txtNombreClienteProveedorPersonal.BackColor = System.Drawing.Color.White
            Me.txtNombreClienteProveedorPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreClienteProveedorPersonal.Location = New System.Drawing.Point(201, 16)
            Me.txtNombreClienteProveedorPersonal.Name = "txtNombreClienteProveedorPersonal"
            Me.txtNombreClienteProveedorPersonal.Size = New System.Drawing.Size(716, 20)
            Me.txtNombreClienteProveedorPersonal.TabIndex = 0
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 19)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(193, 13)
            Me.Label5.TabIndex = 39
            Me.Label5.Text = "PROVEEDOR / CLIENTE / PERSONAL:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnNuevoAsiento, Me.btnGuardar, Me.btnModificarAsiento, Me.btnCancelar, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1153, 24)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscarAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(119, 20)
            Me.btnBuscarAsiento.Text = "LISTAR TODOS"
            '
            'btnNuevoAsiento
            '
            Me.btnNuevoAsiento.Enabled = False
            Me.btnNuevoAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoAsiento.Image = CType(resources.GetObject("btnNuevoAsiento.Image"), System.Drawing.Image)
            Me.btnNuevoAsiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoAsiento.Name = "btnNuevoAsiento"
            Me.btnNuevoAsiento.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevoAsiento.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificarAsiento
            '
            Me.btnModificarAsiento.Enabled = False
            Me.btnModificarAsiento.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificarAsiento.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificarAsiento.Name = "btnModificarAsiento"
            Me.btnModificarAsiento.Size = New System.Drawing.Size(105, 20)
            Me.btnModificarAsiento.Text = "ACTUALIZAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(5, 28)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(121, 13)
            Me.Label4.TabIndex = 186
            Me.Label4.Text = "TODOS LOS REGISTROS"
            '
            'FormAjustarAsientosLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1153, 691)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbClienteProveedorPersonal)
            Me.Controls.Add(Me.gbFormaPago)
            Me.Controls.Add(Me.gbNumeroAsiento)
            Me.Controls.Add(Me.gbBanco)
            Me.Controls.Add(Me.dgvAsientosDiario)
            Me.Controls.Add(Me.dgvNumeroRegistroAsiento)
            Me.Controls.Add(Me.gbRnagoFechas)
            Me.Controls.Add(Me.pCentroCosto)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.gbDetalle)
            Me.Controls.Add(Me.gbDebeHaber)
            Me.Controls.Add(Me.dgvAsientoBuscado)
            Me.Controls.Add(Me.gbBuscarAsiento)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAjustarAsientosLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AJUSTAR ASIENTOS LIBRO DIARIO"
            Me.gbBuscarAsiento.ResumeLayout(False)
            Me.gbBuscarAsiento.PerformLayout()
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            Me.gbDebeHaber.ResumeLayout(False)
            Me.gbDebeHaber.PerformLayout()
            Me.gbDetalle.ResumeLayout(False)
            Me.gbDetalle.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            Me.pCentroCosto.ResumeLayout(False)
            Me.pCentroCosto.PerformLayout()
            Me.gbNumeroAsiento.ResumeLayout(False)
            Me.gbNumeroAsiento.PerformLayout()
            Me.gbRnagoFechas.ResumeLayout(False)
            Me.gbRnagoFechas.PerformLayout()
            CType(Me.dgvNumeroRegistroAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBanco.ResumeLayout(False)
            Me.gbBanco.PerformLayout()
            Me.gbFormaPago.ResumeLayout(False)
            Me.gbFormaPago.PerformLayout()
            Me.gbClienteProveedorPersonal.ResumeLayout(False)
            Me.gbClienteProveedorPersonal.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbBuscarAsiento As System.Windows.Forms.GroupBox
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtNumeroAsientoBuscar As System.Windows.Forms.TextBox
        Friend WithEvents rbFechaAsiento As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumeroAsiento As System.Windows.Forms.RadioButton
        Friend WithEvents lblHasta As System.Windows.Forms.Label
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
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents gbDebeHaber As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents pCentroCosto As System.Windows.Forms.Panel
        Friend WithEvents cmbCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents gbNumeroAsiento As System.Windows.Forms.GroupBox
        Friend WithEvents gbRnagoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents dgvNumeroRegistroAsiento As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaAsiento As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtIdAsiento As System.Windows.Forms.TextBox
        Friend WithEvents dgvAsientoBuscado As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents cmbConcepto As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblCodigoCuentaContable As System.Windows.Forms.Label
        Friend WithEvents cmbCuentasContables As System.Windows.Forms.ComboBox
        Friend WithEvents gbBanco As System.Windows.Forms.GroupBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cmbCuentaBancos As System.Windows.Forms.ComboBox
        Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
        Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
        Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccionExterna As System.Windows.Forms.RadioButton
        Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbTarjetaCredido As System.Windows.Forms.RadioButton
        Friend WithEvents rbTransaccionInterna As System.Windows.Forms.RadioButton
        Friend WithEvents gbClienteProveedorPersonal As System.Windows.Forms.GroupBox
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
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
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
    End Class
End Namespace