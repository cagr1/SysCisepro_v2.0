Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormDepreciaciones
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDepreciaciones))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtFechaActual = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.dgvActivoFijo = New System.Windows.Forms.DataGridView()
            Me.txtCodigoActivo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCargar = New System.Windows.Forms.Button()
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
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMantenimientoDepreciaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDepreciaciones.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dtpHasta)
            Me.GroupBox1.Controls.Add(Me.dtpDesde)
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.dgvActivoFijo)
            Me.GroupBox1.Controls.Add(Me.txtCodigoActivo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.btnCargar)
            Me.GroupBox1.Location = New System.Drawing.Point(5, 27)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(998, 274)
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA DE ACTIVO FIJO A DEPRECIAR"
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
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscar.Location = New System.Drawing.Point(471, 14)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(66, 29)
            Me.btnBuscar.TabIndex = 11
            Me.btnBuscar.Text = "BUSCAR"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'dgvActivoFijo
            '
            Me.dgvActivoFijo.AllowUserToAddRows = False
            Me.dgvActivoFijo.AllowUserToDeleteRows = False
            Me.dgvActivoFijo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivoFijo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivoFijo.BackgroundColor = System.Drawing.Color.White
            Me.dgvActivoFijo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivoFijo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActivoFijo.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvActivoFijo.Location = New System.Drawing.Point(6, 63)
            Me.dgvActivoFijo.MultiSelect = False
            Me.dgvActivoFijo.Name = "dgvActivoFijo"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivoFijo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvActivoFijo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivoFijo.Size = New System.Drawing.Size(985, 205)
            Me.dgvActivoFijo.TabIndex = 10
            '
            'txtCodigoActivo
            '
            Me.txtCodigoActivo.Location = New System.Drawing.Point(280, 18)
            Me.txtCodigoActivo.Name = "txtCodigoActivo"
            Me.txtCodigoActivo.Size = New System.Drawing.Size(175, 20)
            Me.txtCodigoActivo.TabIndex = 9
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(8, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(267, 13)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "INGRESE CÓDIGO, TIPO O CUSTODIO DE ACTIVO :"
            '
            'btnCargar
            '
            Me.btnCargar.Font = New System.Drawing.Font("Calibri", 8.25!)
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.oki
            Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCargar.Location = New System.Drawing.Point(545, 14)
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(69, 29)
            Me.btnCargar.TabIndex = 12
            Me.btnCargar.Text = "CARGAR"
            Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCargar.UseVisualStyleBackColor = True
            '
            'dgvMantenimientoDepreciaciones
            '
            Me.dgvMantenimientoDepreciaciones.AllowUserToAddRows = False
            Me.dgvMantenimientoDepreciaciones.AllowUserToDeleteRows = False
            Me.dgvMantenimientoDepreciaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMantenimientoDepreciaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMantenimientoDepreciaciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvMantenimientoDepreciaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMantenimientoDepreciaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvMantenimientoDepreciaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMantenimientoDepreciaciones.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvMantenimientoDepreciaciones.Location = New System.Drawing.Point(11, 104)
            Me.dgvMantenimientoDepreciaciones.MultiSelect = False
            Me.dgvMantenimientoDepreciaciones.Name = "dgvMantenimientoDepreciaciones"
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMantenimientoDepreciaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvMantenimientoDepreciaciones.RowHeadersVisible = False
            Me.dgvMantenimientoDepreciaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMantenimientoDepreciaciones.Size = New System.Drawing.Size(984, 172)
            Me.dgvMantenimientoDepreciaciones.TabIndex = 9
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(104, 13)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "ID DEPRECIACION:"
            '
            'txtIdDepreciacion
            '
            Me.txtIdDepreciacion.Enabled = False
            Me.txtIdDepreciacion.Location = New System.Drawing.Point(122, 16)
            Me.txtIdDepreciacion.Name = "txtIdDepreciacion"
            Me.txtIdDepreciacion.Size = New System.Drawing.Size(97, 20)
            Me.txtIdDepreciacion.TabIndex = 15
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 54)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(45, 13)
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "FECHA:"
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Location = New System.Drawing.Point(119, 47)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(156, 20)
            Me.txtFecha.TabIndex = 17
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(12, 81)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(102, 13)
            Me.Label4.TabIndex = 18
            Me.Label4.Text = "N° DEPRECIACION"
            '
            'txtNroDepreciacion
            '
            Me.txtNroDepreciacion.Enabled = False
            Me.txtNroDepreciacion.Location = New System.Drawing.Point(119, 78)
            Me.txtNroDepreciacion.Name = "txtNroDepreciacion"
            Me.txtNroDepreciacion.Size = New System.Drawing.Size(97, 20)
            Me.txtNroDepreciacion.TabIndex = 19
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(445, 25)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(129, 13)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "VALOR DEPRECIACION:"
            '
            'txtValorDepreciacion
            '
            Me.txtValorDepreciacion.Enabled = False
            Me.txtValorDepreciacion.Location = New System.Drawing.Point(580, 19)
            Me.txtValorDepreciacion.Name = "txtValorDepreciacion"
            Me.txtValorDepreciacion.Size = New System.Drawing.Size(114, 20)
            Me.txtValorDepreciacion.TabIndex = 21
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(445, 54)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(103, 13)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "VALOR RESIDUAL:"
            '
            'txtValorResidual
            '
            Me.txtValorResidual.Enabled = False
            Me.txtValorResidual.Location = New System.Drawing.Point(582, 51)
            Me.txtValorResidual.Name = "txtValorResidual"
            Me.txtValorResidual.Size = New System.Drawing.Size(114, 20)
            Me.txtValorResidual.TabIndex = 23
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(445, 81)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(122, 13)
            Me.Label8.TabIndex = 26
            Me.Label8.Text = "TOPE DEPRECIACIÓN:"
            '
            'txtTope
            '
            Me.txtTope.Enabled = False
            Me.txtTope.Location = New System.Drawing.Point(638, 78)
            Me.txtTope.Name = "txtTope"
            Me.txtTope.Size = New System.Drawing.Size(56, 20)
            Me.txtTope.TabIndex = 27
            '
            'gbDepreciaciones
            '
            Me.gbDepreciaciones.Controls.Add(Me.txtTope)
            Me.gbDepreciaciones.Controls.Add(Me.Label8)
            Me.gbDepreciaciones.Controls.Add(Me.txtValorResidual)
            Me.gbDepreciaciones.Controls.Add(Me.Label6)
            Me.gbDepreciaciones.Controls.Add(Me.txtValorDepreciacion)
            Me.gbDepreciaciones.Controls.Add(Me.Label5)
            Me.gbDepreciaciones.Controls.Add(Me.txtNroDepreciacion)
            Me.gbDepreciaciones.Controls.Add(Me.Label4)
            Me.gbDepreciaciones.Controls.Add(Me.txtFecha)
            Me.gbDepreciaciones.Controls.Add(Me.Label3)
            Me.gbDepreciaciones.Controls.Add(Me.txtIdDepreciacion)
            Me.gbDepreciaciones.Controls.Add(Me.Label1)
            Me.gbDepreciaciones.Controls.Add(Me.dgvMantenimientoDepreciaciones)
            Me.gbDepreciaciones.Controls.Add(Me.lblTope)
            Me.gbDepreciaciones.Controls.Add(Me.lblValorResidual)
            Me.gbDepreciaciones.Controls.Add(Me.lblDepreciacion)
            Me.gbDepreciaciones.Controls.Add(Me.lblNro)
            Me.gbDepreciaciones.Controls.Add(Me.lblFecha)
            Me.gbDepreciaciones.Controls.Add(Me.lblIdDepreciacion)
            Me.gbDepreciaciones.Location = New System.Drawing.Point(5, 307)
            Me.gbDepreciaciones.Name = "gbDepreciaciones"
            Me.gbDepreciaciones.Size = New System.Drawing.Size(998, 285)
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
            Me.lblValorResidual.Size = New System.Drawing.Size(34, 13)
            Me.lblValorResidual.TabIndex = 32
            Me.lblValorResidual.Text = "00,00"
            '
            'lblDepreciacion
            '
            Me.lblDepreciacion.AutoSize = True
            Me.lblDepreciacion.ForeColor = System.Drawing.Color.Maroon
            Me.lblDepreciacion.Location = New System.Drawing.Point(745, 19)
            Me.lblDepreciacion.Name = "lblDepreciacion"
            Me.lblDepreciacion.Size = New System.Drawing.Size(34, 13)
            Me.lblDepreciacion.TabIndex = 31
            Me.lblDepreciacion.Text = "00,00"
            '
            'lblNro
            '
            Me.lblNro.AutoSize = True
            Me.lblNro.ForeColor = System.Drawing.Color.Maroon
            Me.lblNro.Location = New System.Drawing.Point(347, 81)
            Me.lblNro.Name = "lblNro"
            Me.lblNro.Size = New System.Drawing.Size(13, 13)
            Me.lblNro.TabIndex = 30
            Me.lblNro.Text = "1"
            '
            'lblFecha
            '
            Me.lblFecha.AutoSize = True
            Me.lblFecha.ForeColor = System.Drawing.Color.Maroon
            Me.lblFecha.Location = New System.Drawing.Point(284, 51)
            Me.lblFecha.Name = "lblFecha"
            Me.lblFecha.Size = New System.Drawing.Size(65, 13)
            Me.lblFecha.TabIndex = 29
            Me.lblFecha.Text = "10/10/2012"
            '
            'lblIdDepreciacion
            '
            Me.lblIdDepreciacion.AutoSize = True
            Me.lblIdDepreciacion.ForeColor = System.Drawing.Color.Maroon
            Me.lblIdDepreciacion.Location = New System.Drawing.Point(347, 22)
            Me.lblIdDepreciacion.Name = "lblIdDepreciacion"
            Me.lblIdDepreciacion.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDepreciacion.TabIndex = 28
            Me.lblIdDepreciacion.Text = "1"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDepreciar, Me.btnGuardar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1007, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnDepreciar
            '
            Me.btnDepreciar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDepreciar.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnDepreciar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnDepreciar.Name = "btnDepreciar"
            Me.btnDepreciar.Size = New System.Drawing.Size(98, 20)
            Me.btnDepreciar.Text = "DEPRECIAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnReporte
            '
            Me.btnReporte.Enabled = False
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'dtpDesde
            '
            Me.dtpDesde.Location = New System.Drawing.Point(638, 19)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(176, 20)
            Me.dtpDesde.TabIndex = 19
            '
            'dtpHasta
            '
            Me.dtpHasta.Location = New System.Drawing.Point(826, 19)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(164, 20)
            Me.dtpHasta.TabIndex = 20
            '
            'FormDepreciaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1007, 595)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.txtFechaActual)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbDepreciaciones)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormDepreciaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DEPRECIACIONES"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMantenimientoDepreciaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDepreciaciones.ResumeLayout(False)
            Me.gbDepreciaciones.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents dgvActivoFijo As System.Windows.Forms.DataGridView
        Friend WithEvents txtCodigoActivo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
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
    End Class
End Namespace