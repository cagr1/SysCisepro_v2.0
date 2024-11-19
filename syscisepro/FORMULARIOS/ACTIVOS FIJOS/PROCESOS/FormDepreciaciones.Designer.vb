Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDepreciaciones
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDepreciaciones))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.dgvActivoFijo = New System.Windows.Forms.DataGridView()
            Me.txtCodigoActivo = New System.Windows.Forms.TextBox()
            Me.btnCargar = New System.Windows.Forms.Button()
            Me.txtFechaActual = New System.Windows.Forms.TextBox()
            Me.dgvMantenimientoDepreciaciones = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdDepreciacion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNroDepreciacion = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtValorDepreciacion = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtValorResidual = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtTope = New System.Windows.Forms.TextBox()
            Me.gbDepreciaciones = New System.Windows.Forms.GroupBox()
            Me.lblTope = New System.Windows.Forms.Label()
            Me.lblValorResidual = New System.Windows.Forms.Label()
            Me.lblDepreciacion = New System.Windows.Forms.Label()
            Me.lblNro = New System.Windows.Forms.Label()
            Me.lblFecha = New System.Windows.Forms.Label()
            Me.lblIdDepreciacion = New System.Windows.Forms.Label()
            Me.ttDepreciar = New System.Windows.Forms.ToolTip(Me.components)
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnDepreciar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMantenimientoDepreciaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDepreciaciones.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(607, 72)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(167, 194)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA DE ACTIVO FIJO A DEPRECIAR"
            '
            'dtpHasta
            '
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Location = New System.Drawing.Point(626, 12)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(191, 21)
            Me.dtpHasta.TabIndex = 20
            '
            'dtpDesde
            '
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Location = New System.Drawing.Point(376, 12)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(199, 21)
            Me.dtpDesde.TabIndex = 19
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscar.FlatAppearance.BorderSize = 0
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscar.Location = New System.Drawing.Point(251, 7)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(25, 25)
            Me.btnBuscar.TabIndex = 11
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'dgvActivoFijo
            '
            Me.dgvActivoFijo.AllowUserToAddRows = False
            Me.dgvActivoFijo.AllowUserToDeleteRows = False
            Me.dgvActivoFijo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivoFijo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivoFijo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvActivoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvActivoFijo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvActivoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActivoFijo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivoFijo.Location = New System.Drawing.Point(8, 38)
            Me.dgvActivoFijo.MultiSelect = False
            Me.dgvActivoFijo.Name = "dgvActivoFijo"
            Me.dgvActivoFijo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivoFijo.Size = New System.Drawing.Size(809, 203)
            Me.dgvActivoFijo.TabIndex = 10
            '
            'txtCodigoActivo
            '
            Me.txtCodigoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoActivo.Location = New System.Drawing.Point(14, 12)
            Me.txtCodigoActivo.Name = "txtCodigoActivo"
            Me.txtCodigoActivo.Size = New System.Drawing.Size(220, 21)
            Me.txtCodigoActivo.TabIndex = 9
            '
            'btnCargar
            '
            Me.btnCargar.BackColor = System.Drawing.Color.Transparent
            Me.btnCargar.FlatAppearance.BorderSize = 0
            Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCargar.Font = New System.Drawing.Font("Calibri", 8.25!)
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.Location = New System.Drawing.Point(288, 7)
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(25, 25)
            Me.btnCargar.TabIndex = 12
            Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCargar.UseVisualStyleBackColor = False
            '
            'txtFechaActual
            '
            Me.txtFechaActual.Enabled = False
            Me.txtFechaActual.Location = New System.Drawing.Point(784, 4)
            Me.txtFechaActual.Name = "txtFechaActual"
            Me.txtFechaActual.Size = New System.Drawing.Size(68, 20)
            Me.txtFechaActual.TabIndex = 18
            Me.txtFechaActual.Visible = False
            '
            'dgvMantenimientoDepreciaciones
            '
            Me.dgvMantenimientoDepreciaciones.AllowUserToAddRows = False
            Me.dgvMantenimientoDepreciaciones.AllowUserToDeleteRows = False
            Me.dgvMantenimientoDepreciaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMantenimientoDepreciaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMantenimientoDepreciaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMantenimientoDepreciaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMantenimientoDepreciaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvMantenimientoDepreciaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMantenimientoDepreciaciones.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMantenimientoDepreciaciones.Location = New System.Drawing.Point(9, 91)
            Me.dgvMantenimientoDepreciaciones.MultiSelect = False
            Me.dgvMantenimientoDepreciaciones.Name = "dgvMantenimientoDepreciaciones"
            Me.dgvMantenimientoDepreciaciones.RowHeadersVisible = False
            Me.dgvMantenimientoDepreciaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMantenimientoDepreciaciones.Size = New System.Drawing.Size(808, 172)
            Me.dgvMantenimientoDepreciaciones.TabIndex = 9
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(99, 13)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "ID DEPRECIACION:"
            '
            'txtIdDepreciacion
            '
            Me.txtIdDepreciacion.Enabled = False
            Me.txtIdDepreciacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdDepreciacion.Location = New System.Drawing.Point(116, 11)
            Me.txtIdDepreciacion.Name = "txtIdDepreciacion"
            Me.txtIdDepreciacion.Size = New System.Drawing.Size(97, 21)
            Me.txtIdDepreciacion.TabIndex = 15
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 54)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(44, 13)
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "FECHA:"
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFecha.Location = New System.Drawing.Point(116, 37)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(96, 21)
            Me.txtFecha.TabIndex = 17
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(12, 81)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(98, 13)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "N° DEPRECIACION"
            '
            'txtNroDepreciacion
            '
            Me.txtNroDepreciacion.Enabled = False
            Me.txtNroDepreciacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroDepreciacion.Location = New System.Drawing.Point(116, 63)
            Me.txtNroDepreciacion.Name = "txtNroDepreciacion"
            Me.txtNroDepreciacion.Size = New System.Drawing.Size(97, 21)
            Me.txtNroDepreciacion.TabIndex = 19
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(445, 25)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(124, 13)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "VALOR DEPRECIACION:"
            '
            'txtValorDepreciacion
            '
            Me.txtValorDepreciacion.Enabled = False
            Me.txtValorDepreciacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorDepreciacion.Location = New System.Drawing.Point(483, 11)
            Me.txtValorDepreciacion.Name = "txtValorDepreciacion"
            Me.txtValorDepreciacion.Size = New System.Drawing.Size(114, 21)
            Me.txtValorDepreciacion.TabIndex = 21
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(445, 54)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(98, 13)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "VALOR RESIDUAL:"
            '
            'txtValorResidual
            '
            Me.txtValorResidual.Enabled = False
            Me.txtValorResidual.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorResidual.Location = New System.Drawing.Point(483, 37)
            Me.txtValorResidual.Name = "txtValorResidual"
            Me.txtValorResidual.Size = New System.Drawing.Size(114, 21)
            Me.txtValorResidual.TabIndex = 23
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(445, 81)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(117, 13)
            Me.Label8.TabIndex = 26
            Me.Label8.Text = "TOPE DEPRECIACIÓN:"
            '
            'txtTope
            '
            Me.txtTope.Enabled = False
            Me.txtTope.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTope.Location = New System.Drawing.Point(483, 63)
            Me.txtTope.Name = "txtTope"
            Me.txtTope.Size = New System.Drawing.Size(56, 21)
            Me.txtTope.TabIndex = 27
            '
            'gbDepreciaciones
            '
            Me.gbDepreciaciones.Controls.Add(Me.Label8)
            Me.gbDepreciaciones.Controls.Add(Me.Label6)
            Me.gbDepreciaciones.Controls.Add(Me.Label5)
            Me.gbDepreciaciones.Controls.Add(Me.Label4)
            Me.gbDepreciaciones.Controls.Add(Me.Label3)
            Me.gbDepreciaciones.Controls.Add(Me.Label1)
            Me.gbDepreciaciones.Controls.Add(Me.lblTope)
            Me.gbDepreciaciones.Controls.Add(Me.lblValorResidual)
            Me.gbDepreciaciones.Controls.Add(Me.lblDepreciacion)
            Me.gbDepreciaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDepreciaciones.Location = New System.Drawing.Point(645, 437)
            Me.gbDepreciaciones.Name = "gbDepreciaciones"
            Me.gbDepreciaciones.Size = New System.Drawing.Size(146, 69)
            Me.gbDepreciaciones.TabIndex = 8
            Me.gbDepreciaciones.TabStop = False
            Me.gbDepreciaciones.Text = "MANTENIMIENTO DEPRECIACIONES"
            '
            'lblTope
            '
            Me.lblTope.AutoSize = True
            Me.lblTope.ForeColor = System.Drawing.Color.Maroon
            Me.lblTope.Location = New System.Drawing.Point(745, 81)
            Me.lblTope.Name = "lblTope"
            Me.lblTope.Size = New System.Drawing.Size(13, 13)
            Me.lblTope.TabIndex = 34
            Me.lblTope.Text = "1"
            '
            'lblValorResidual
            '
            Me.lblValorResidual.AutoSize = True
            Me.lblValorResidual.ForeColor = System.Drawing.Color.Maroon
            Me.lblValorResidual.Location = New System.Drawing.Point(745, 50)
            Me.lblValorResidual.Name = "lblValorResidual"
            Me.lblValorResidual.Size = New System.Drawing.Size(33, 13)
            Me.lblValorResidual.TabIndex = 32
            Me.lblValorResidual.Text = "00,00"
            '
            'lblDepreciacion
            '
            Me.lblDepreciacion.AutoSize = True
            Me.lblDepreciacion.ForeColor = System.Drawing.Color.Maroon
            Me.lblDepreciacion.Location = New System.Drawing.Point(745, 19)
            Me.lblDepreciacion.Name = "lblDepreciacion"
            Me.lblDepreciacion.Size = New System.Drawing.Size(33, 13)
            Me.lblDepreciacion.TabIndex = 31
            Me.lblDepreciacion.Text = "00,00"
            '
            'lblNro
            '
            Me.lblNro.AutoSize = True
            Me.lblNro.BackColor = System.Drawing.Color.Transparent
            Me.lblNro.ForeColor = System.Drawing.Color.Maroon
            Me.lblNro.Location = New System.Drawing.Point(284, 67)
            Me.lblNro.Name = "lblNro"
            Me.lblNro.Size = New System.Drawing.Size(13, 13)
            Me.lblNro.TabIndex = 30
            Me.lblNro.Text = "1"
            Me.lblNro.Visible = False
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.BackColor = System.Drawing.Color.Transparent
            Me.lblFecha.ForeColor = System.Drawing.Color.Maroon
            Me.lblFecha.Location = New System.Drawing.Point(230, 37)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(65, 13)
            Me.lblFecha.TabIndex = 29
            Me.lblFecha.Text = "10/10/2012"
            Me.lblFecha.Visible = False
            '
            'lblIdDepreciacion
            '
            Me.lblIdDepreciacion.AutoSize = True
            Me.lblIdDepreciacion.BackColor = System.Drawing.Color.Transparent
            Me.lblIdDepreciacion.ForeColor = System.Drawing.Color.Maroon
            Me.lblIdDepreciacion.Location = New System.Drawing.Point(284, 8)
            Me.lblIdDepreciacion.Name = "lblIdDepreciacion"
            Me.lblIdDepreciacion.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDepreciacion.TabIndex = 28
            Me.lblIdDepreciacion.Text = "1"
            Me.lblIdDepreciacion.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDepreciar, Me.btnGuardar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(848, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnDepreciar
            '
            Me.btnDepreciar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDepreciar.Image = Global.syscisepro.My.Resources.Resources.playlist_remove_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnDepreciar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnDepreciar.Name = "btnDepreciar"
            Me.btnDepreciar.Size = New System.Drawing.Size(106, 28)
            Me.btnDepreciar.Text = "DEPRECIAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnReporte
            '
            Me.btnReporte.AutoSize = False
            Me.btnReporte.Enabled = False
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(6, 38)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvActivoFijo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpHasta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpDesde)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCodigoActivo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscar)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnCargar)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(836, 268)
            Me.KryptonGroupBox1.TabIndex = 190
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(581, 12)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 21
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(328, 12)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(6, 311)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtTope)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvMantenimientoDepreciaciones)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorResidual)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtIdDepreciacion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtValorDepreciacion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtFecha)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtNroDepreciacion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblFecha)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblIdDepreciacion)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.lblNro)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(836, 290)
            Me.KryptonGroupBox2.TabIndex = 191
            Me.KryptonGroupBox2.Values.Heading = "Mantenimiento"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(367, 63)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(111, 20)
            Me.KryptonLabel8.TabIndex = 33
            Me.KryptonLabel8.Values.Text = "Tope depreciacion"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(367, 36)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel7.TabIndex = 32
            Me.KryptonLabel7.Values.Text = "Valor Residual"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(367, 11)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(113, 20)
            Me.KryptonLabel6.TabIndex = 31
            Me.KryptonLabel6.Values.Text = "Valor Depreciacion"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(9, 63)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(101, 20)
            Me.KryptonLabel5.TabIndex = 18
            Me.KryptonLabel5.Values.Text = "No Depreciacion"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(9, 37)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel4.TabIndex = 16
            Me.KryptonLabel4.Values.Text = "Fecha"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(9, 11)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel3.TabIndex = 1
            Me.KryptonLabel3.Values.Text = "ID"
            '
            'FormDepreciaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(848, 603)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtFechaActual)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDepreciaciones)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormDepreciaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "DEPRECIACIONES"
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMantenimientoDepreciaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDepreciaciones.ResumeLayout(False)
            Me.gbDepreciaciones.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents dgvActivoFijo As System.Windows.Forms.DataGridView
        Friend WithEvents txtCodigoActivo As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaActual As System.Windows.Forms.TextBox
        Friend WithEvents dgvMantenimientoDepreciaciones As System.Windows.Forms.DataGridView
        Friend WithEvents btnCargar As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdDepreciacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNroDepreciacion As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtValorDepreciacion As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtValorResidual As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtTope As System.Windows.Forms.TextBox
        Friend WithEvents gbDepreciaciones As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdDepreciacion As System.Windows.Forms.Label
        Friend WithEvents lblTope As System.Windows.Forms.Label
        Friend WithEvents lblValorResidual As System.Windows.Forms.Label
        Friend WithEvents lblDepreciacion As System.Windows.Forms.Label
        Friend WithEvents lblNro As System.Windows.Forms.Label
        Friend WithEvents lblFecha As System.Windows.Forms.Label
        Friend WithEvents ttDepreciar As System.Windows.Forms.ToolTip
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnDepreciar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace