Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAuxiliarComprobantesCompraRetencionAsiento
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliarComprobantesCompraRetencionAsiento))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTipoComprobanteCompra = New System.Windows.Forms.Label()
            Me.lblEstadoComprobanteCompra = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblIdComprobanteCompra = New System.Windows.Forms.Label()
            Me.dgvComprobantesCompra = New System.Windows.Forms.DataGridView()
            Me.gbRetencion = New System.Windows.Forms.GroupBox()
            Me.lblNumeroComprobanteRetencion = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dgvDetalleComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.lblEstadoDetalleComprabanteRetencionCompra = New System.Windows.Forms.Label()
            Me.lblIdComprobanteRetencion = New System.Windows.Forms.Label()
            Me.lblIdDetalleComprobanteRetencionCompra = New System.Windows.Forms.Label()
            Me.dgvComprobanteRetencion = New System.Windows.Forms.DataGridView()
            Me.gbAsientoDiario = New System.Windows.Forms.GroupBox()
            Me.lblNumeroRegistro = New System.Windows.Forms.Label()
            Me.dgvAsientoDiario = New System.Windows.Forms.DataGridView()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRetencion.SuspendLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbAsientoDiario.SuspendLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.lblTipoComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.lblEstadoComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.lblIdComprobanteCompra)
            Me.GroupBox1.Controls.Add(Me.dgvComprobantesCompra)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 66)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(961, 285)
            Me.GroupBox1.TabIndex = 97
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "COMPROBANTES DE COMPRA"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(287, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 96
            Me.Label1.Text = "/"
            '
            'lblTipoComprobanteCompra
            '
            Me.lblTipoComprobanteCompra.AutoSize = True
            Me.lblTipoComprobanteCompra.Location = New System.Drawing.Point(306, 0)
            Me.lblTipoComprobanteCompra.Name = "lblTipoComprobanteCompra"
            Me.lblTipoComprobanteCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblTipoComprobanteCompra.TabIndex = 95
            Me.lblTipoComprobanteCompra.Text = "..."
            Me.lblTipoComprobanteCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblEstadoComprobanteCompra
            '
            Me.lblEstadoComprobanteCompra.AutoSize = True
            Me.lblEstadoComprobanteCompra.Location = New System.Drawing.Point(206, 0)
            Me.lblEstadoComprobanteCompra.Name = "lblEstadoComprobanteCompra"
            Me.lblEstadoComprobanteCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblEstadoComprobanteCompra.TabIndex = 94
            Me.lblEstadoComprobanteCompra.Text = "..."
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(187, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(13, 13)
            Me.Label6.TabIndex = 93
            Me.Label6.Text = "/"
            '
            'lblIdComprobanteCompra
            '
            Me.lblIdComprobanteCompra.AutoSize = True
            Me.lblIdComprobanteCompra.Location = New System.Drawing.Point(153, 0)
            Me.lblIdComprobanteCompra.Name = "lblIdComprobanteCompra"
            Me.lblIdComprobanteCompra.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteCompra.TabIndex = 29
            Me.lblIdComprobanteCompra.Text = "..."
            '
            'dgvComprobantesCompra
            '
            Me.dgvComprobantesCompra.AllowUserToAddRows = False
            Me.dgvComprobantesCompra.AllowUserToDeleteRows = False
            Me.dgvComprobantesCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvComprobantesCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvComprobantesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesCompra.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvComprobantesCompra.Location = New System.Drawing.Point(5, 15)
            Me.dgvComprobantesCompra.MultiSelect = False
            Me.dgvComprobantesCompra.Name = "dgvComprobantesCompra"
            Me.dgvComprobantesCompra.RowHeadersVisible = False
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobantesCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvComprobantesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesCompra.Size = New System.Drawing.Size(950, 265)
            Me.dgvComprobantesCompra.TabIndex = 86
            '
            'gbRetencion
            '
            Me.gbRetencion.BackColor = System.Drawing.Color.White
            Me.gbRetencion.Controls.Add(Me.lblNumeroComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.Label4)
            Me.gbRetencion.Controls.Add(Me.dgvDetalleComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblEstadoDetalleComprabanteRetencionCompra)
            Me.gbRetencion.Controls.Add(Me.lblIdComprobanteRetencion)
            Me.gbRetencion.Controls.Add(Me.lblIdDetalleComprobanteRetencionCompra)
            Me.gbRetencion.Controls.Add(Me.dgvComprobanteRetencion)
            Me.gbRetencion.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRetencion.Location = New System.Drawing.Point(2, 351)
            Me.gbRetencion.Name = "gbRetencion"
            Me.gbRetencion.Size = New System.Drawing.Size(961, 138)
            Me.gbRetencion.TabIndex = 98
            Me.gbRetencion.TabStop = False
            Me.gbRetencion.Text = "RETENCIÓN"
            '
            'lblNumeroComprobanteRetencion
            '
            Me.lblNumeroComprobanteRetencion.AutoSize = True
            Me.lblNumeroComprobanteRetencion.Location = New System.Drawing.Point(135, 0)
            Me.lblNumeroComprobanteRetencion.Name = "lblNumeroComprobanteRetencion"
            Me.lblNumeroComprobanteRetencion.Size = New System.Drawing.Size(25, 13)
            Me.lblNumeroComprobanteRetencion.TabIndex = 98
            Me.lblNumeroComprobanteRetencion.Text = "..."
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(116, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(13, 13)
            Me.Label4.TabIndex = 97
            Me.Label4.Text = "/"
            '
            'dgvDetalleComprobanteRetencion
            '
            Me.dgvDetalleComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobanteRetencion.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobanteRetencion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvDetalleComprobanteRetencion.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobanteRetencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetalleComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetalleComprobanteRetencion.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDetalleComprobanteRetencion.Location = New System.Drawing.Point(5, 17)
            Me.dgvDetalleComprobanteRetencion.MultiSelect = False
            Me.dgvDetalleComprobanteRetencion.Name = "dgvDetalleComprobanteRetencion"
            Me.dgvDetalleComprobanteRetencion.RowHeadersVisible = False
            Me.dgvDetalleComprobanteRetencion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleComprobanteRetencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobanteRetencion.Size = New System.Drawing.Size(950, 116)
            Me.dgvDetalleComprobanteRetencion.TabIndex = 53
            '
            'lblEstadoDetalleComprabanteRetencionCompra
            '
            Me.lblEstadoDetalleComprabanteRetencionCompra.AutoSize = True
            Me.lblEstadoDetalleComprabanteRetencionCompra.Location = New System.Drawing.Point(602, 72)
            Me.lblEstadoDetalleComprabanteRetencionCompra.Name = "lblEstadoDetalleComprabanteRetencionCompra"
            Me.lblEstadoDetalleComprabanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblEstadoDetalleComprabanteRetencionCompra.TabIndex = 109
            Me.lblEstadoDetalleComprabanteRetencionCompra.Text = "0"
            '
            'lblIdComprobanteRetencion
            '
            Me.lblIdComprobanteRetencion.AutoSize = True
            Me.lblIdComprobanteRetencion.Location = New System.Drawing.Point(80, 0)
            Me.lblIdComprobanteRetencion.Name = "lblIdComprobanteRetencion"
            Me.lblIdComprobanteRetencion.Size = New System.Drawing.Size(25, 13)
            Me.lblIdComprobanteRetencion.TabIndex = 69
            Me.lblIdComprobanteRetencion.Text = "..."
            '
            'lblIdDetalleComprobanteRetencionCompra
            '
            Me.lblIdDetalleComprobanteRetencionCompra.AutoSize = True
            Me.lblIdDetalleComprobanteRetencionCompra.Location = New System.Drawing.Point(569, 72)
            Me.lblIdDetalleComprobanteRetencionCompra.Name = "lblIdDetalleComprobanteRetencionCompra"
            Me.lblIdDetalleComprobanteRetencionCompra.Size = New System.Drawing.Size(13, 13)
            Me.lblIdDetalleComprobanteRetencionCompra.TabIndex = 107
            Me.lblIdDetalleComprobanteRetencionCompra.Text = "0"
            '
            'dgvComprobanteRetencion
            '
            Me.dgvComprobanteRetencion.AllowUserToAddRows = False
            Me.dgvComprobanteRetencion.BackgroundColor = System.Drawing.SystemColors.ControlLight
            Me.dgvComprobanteRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvComprobanteRetencion.Location = New System.Drawing.Point(5, 17)
            Me.dgvComprobanteRetencion.Name = "dgvComprobanteRetencion"
            Me.dgvComprobanteRetencion.Size = New System.Drawing.Size(698, 75)
            Me.dgvComprobanteRetencion.TabIndex = 108
            '
            'gbAsientoDiario
            '
            Me.gbAsientoDiario.BackColor = System.Drawing.Color.White
            Me.gbAsientoDiario.Controls.Add(Me.lblNumeroRegistro)
            Me.gbAsientoDiario.Controls.Add(Me.dgvAsientoDiario)
            Me.gbAsientoDiario.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbAsientoDiario.Location = New System.Drawing.Point(2, 489)
            Me.gbAsientoDiario.Name = "gbAsientoDiario"
            Me.gbAsientoDiario.Size = New System.Drawing.Size(961, 191)
            Me.gbAsientoDiario.TabIndex = 99
            Me.gbAsientoDiario.TabStop = False
            Me.gbAsientoDiario.Text = "ASIENTO DE DIARIO:"
            '
            'lblNumeroRegistro
            '
            Me.lblNumeroRegistro.AutoSize = True
            Me.lblNumeroRegistro.Location = New System.Drawing.Point(135, 0)
            Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
            Me.lblNumeroRegistro.Size = New System.Drawing.Size(13, 13)
            Me.lblNumeroRegistro.TabIndex = 1
            Me.lblNumeroRegistro.Text = "0"
            '
            'dgvAsientoDiario
            '
            Me.dgvAsientoDiario.AllowUserToAddRows = False
            Me.dgvAsientoDiario.AllowUserToDeleteRows = False
            Me.dgvAsientoDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientoDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientoDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientoDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientoDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientoDiario.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientoDiario.Location = New System.Drawing.Point(8, 19)
            Me.dgvAsientoDiario.MultiSelect = False
            Me.dgvAsientoDiario.Name = "dgvAsientoDiario"
            Me.dgvAsientoDiario.ReadOnly = True
            Me.dgvAsientoDiario.RowHeadersVisible = False
            Me.dgvAsientoDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientoDiario.Size = New System.Drawing.Size(947, 167)
            Me.dgvAsientoDiario.TabIndex = 0
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label2)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(2, 23)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(961, 40)
            Me.gbRangoFechas.TabIndex = 105
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(117, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(136, 14)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(103, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(9, 14)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(103, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(967, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(81, 20)
            Me.btnBuscar.Text = "CARGAR"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 20)
            Me.ToolStripMenuItem1.Text = "EXPORTAR COMPRAS"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 20)
            Me.ToolStripMenuItem2.Text = "EXPORTAR RETENCIÓN"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(139, 20)
            Me.ToolStripMenuItem3.Text = "EXPORTAR ASIENTO"
            '
            'FormAuxiliarComprobantesCompraRetencionAsiento
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(967, 682)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbAsientoDiario)
            Me.Controls.Add(Me.gbRetencion)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAuxiliarComprobantesCompraRetencionAsiento"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AUXILIAR COMPROBANTES COMPRA"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvComprobantesCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRetencion.ResumeLayout(False)
            Me.gbRetencion.PerformLayout()
            CType(Me.dgvDetalleComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteRetencion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbAsientoDiario.ResumeLayout(False)
            Me.gbAsientoDiario.PerformLayout()
            CType(Me.dgvAsientoDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblEstadoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIdComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobantesCompra As System.Windows.Forms.DataGridView
        Friend WithEvents gbRetencion As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents gbAsientoDiario As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumeroRegistro As System.Windows.Forms.Label
        Friend WithEvents dgvAsientoDiario As System.Windows.Forms.DataGridView
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblTipoComprobanteCompra As System.Windows.Forms.Label
        Friend WithEvents lblEstadoDetalleComprabanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents lblIdDetalleComprobanteRetencionCompra As System.Windows.Forms.Label
        Friend WithEvents dgvComprobanteRetencion As System.Windows.Forms.DataGridView
        Friend WithEvents lblNumeroComprobanteRetencion As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace