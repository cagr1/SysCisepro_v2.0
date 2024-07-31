Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAuxiliaresLiquidaciones
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliaresLiquidaciones))
            Me.tcAuxiliaresLiquidaciones = New System.Windows.Forms.TabControl()
            Me.tpLiquidaciones = New System.Windows.Forms.TabPage()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtHaber = New System.Windows.Forms.TextBox()
            Me.txtDebe = New System.Windows.Forms.TextBox()
            Me.dgvAsiento = New System.Windows.Forms.DataGridView()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.rbFondo = New System.Windows.Forms.RadioButton()
            Me.rbCaja = New System.Windows.Forms.RadioButton()
            Me.lblidAsiento = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dgvLiquidaciones = New System.Windows.Forms.DataGridView()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCuadrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.tcAuxiliaresLiquidaciones.SuspendLayout()
            Me.tpLiquidaciones.SuspendLayout()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpReporte.SuspendLayout()
            CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAuxiliaresLiquidaciones
            '
            Me.tcAuxiliaresLiquidaciones.Controls.Add(Me.tpLiquidaciones)
            Me.tcAuxiliaresLiquidaciones.Controls.Add(Me.tpReporte)
            Me.tcAuxiliaresLiquidaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAuxiliaresLiquidaciones.Location = New System.Drawing.Point(2, 45)
            Me.tcAuxiliaresLiquidaciones.Name = "tcAuxiliaresLiquidaciones"
            Me.tcAuxiliaresLiquidaciones.SelectedIndex = 0
            Me.tcAuxiliaresLiquidaciones.Size = New System.Drawing.Size(825, 596)
            Me.tcAuxiliaresLiquidaciones.TabIndex = 1
            '
            'tpLiquidaciones
            '
            Me.tpLiquidaciones.Controls.Add(Me.Label6)
            Me.tpLiquidaciones.Controls.Add(Me.Label7)
            Me.tpLiquidaciones.Controls.Add(Me.txtHaber)
            Me.tpLiquidaciones.Controls.Add(Me.txtDebe)
            Me.tpLiquidaciones.Controls.Add(Me.dgvAsiento)
            Me.tpLiquidaciones.Controls.Add(Me.Label5)
            Me.tpLiquidaciones.Controls.Add(Me.lblDetalle)
            Me.tpLiquidaciones.Controls.Add(Me.rbFondo)
            Me.tpLiquidaciones.Controls.Add(Me.rbCaja)
            Me.tpLiquidaciones.Controls.Add(Me.lblidAsiento)
            Me.tpLiquidaciones.Controls.Add(Me.Label2)
            Me.tpLiquidaciones.Controls.Add(Me.dgvLiquidaciones)
            Me.tpLiquidaciones.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpLiquidaciones.Location = New System.Drawing.Point(4, 22)
            Me.tpLiquidaciones.Name = "tpLiquidaciones"
            Me.tpLiquidaciones.Padding = New System.Windows.Forms.Padding(3)
            Me.tpLiquidaciones.Size = New System.Drawing.Size(817, 570)
            Me.tpLiquidaciones.TabIndex = 0
            Me.tpLiquidaciones.Text = "FONDOS"
            Me.tpLiquidaciones.UseVisualStyleBackColor = True
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(585, 205)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 250
            Me.Label6.Text = "HABER"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(445, 205)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(31, 13)
            Me.Label7.TabIndex = 249
            Me.Label7.Text = "DEBE"
            '
            'txtHaber
            '
            Me.txtHaber.BackColor = System.Drawing.Color.White
            Me.txtHaber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHaber.Enabled = False
            Me.txtHaber.Location = New System.Drawing.Point(628, 200)
            Me.txtHaber.Name = "txtHaber"
            Me.txtHaber.Size = New System.Drawing.Size(94, 23)
            Me.txtHaber.TabIndex = 248
            Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtDebe
            '
            Me.txtDebe.BackColor = System.Drawing.Color.White
            Me.txtDebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDebe.Enabled = False
            Me.txtDebe.Location = New System.Drawing.Point(482, 200)
            Me.txtDebe.Name = "txtDebe"
            Me.txtDebe.Size = New System.Drawing.Size(94, 23)
            Me.txtDebe.TabIndex = 246
            Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvAsiento
            '
            Me.dgvAsiento.AllowUserToAddRows = False
            Me.dgvAsiento.AllowUserToDeleteRows = False
            Me.dgvAsiento.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsiento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAsiento.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsiento.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvAsiento.Location = New System.Drawing.Point(6, 224)
            Me.dgvAsiento.MultiSelect = False
            Me.dgvAsiento.Name = "dgvAsiento"
            Me.dgvAsiento.ReadOnly = True
            Me.dgvAsiento.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsiento.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsiento.Size = New System.Drawing.Size(805, 343)
            Me.dgvAsiento.TabIndex = 245
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 207)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 18)
            Me.Label5.TabIndex = 244
            Me.Label5.Text = "ASIENTO:"
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.ForeColor = System.Drawing.Color.Red
            Me.lblDetalle.Location = New System.Drawing.Point(3, 355)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(0, 15)
            Me.lblDetalle.TabIndex = 242
            '
            'rbFondo
            '
            Me.rbFondo.AutoSize = True
            Me.rbFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbFondo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFondo.Location = New System.Drawing.Point(226, 12)
            Me.rbFondo.Name = "rbFondo"
            Me.rbFondo.Size = New System.Drawing.Size(61, 17)
            Me.rbFondo.TabIndex = 234
            Me.rbFondo.Text = "FONDO"
            Me.rbFondo.UseVisualStyleBackColor = True
            '
            'rbCaja
            '
            Me.rbCaja.AutoSize = True
            Me.rbCaja.Checked = True
            Me.rbCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbCaja.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCaja.Location = New System.Drawing.Point(134, 11)
            Me.rbCaja.Name = "rbCaja"
            Me.rbCaja.Size = New System.Drawing.Size(51, 17)
            Me.rbCaja.TabIndex = 233
            Me.rbCaja.TabStop = True
            Me.rbCaja.Text = "CAJA"
            Me.rbCaja.UseVisualStyleBackColor = True
            '
            'lblidAsiento
            '
            Me.lblidAsiento.AutoSize = True
            Me.lblidAsiento.ForeColor = System.Drawing.Color.Red
            Me.lblidAsiento.Location = New System.Drawing.Point(289, -8)
            Me.lblidAsiento.Name = "lblidAsiento"
            Me.lblidAsiento.Size = New System.Drawing.Size(0, 15)
            Me.lblidAsiento.TabIndex = 230
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(74, 13)
            Me.Label2.TabIndex = 226
            Me.Label2.Text = "LIQUIDACION"
            '
            'dgvLiquidaciones
            '
            Me.dgvLiquidaciones.AllowUserToAddRows = False
            Me.dgvLiquidaciones.AllowUserToDeleteRows = False
            Me.dgvLiquidaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvLiquidaciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvLiquidaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLiquidaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidaciones.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvLiquidaciones.Location = New System.Drawing.Point(6, 33)
            Me.dgvLiquidaciones.MultiSelect = False
            Me.dgvLiquidaciones.Name = "dgvLiquidaciones"
            Me.dgvLiquidaciones.ReadOnly = True
            Me.dgvLiquidaciones.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvLiquidaciones.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidaciones.Size = New System.Drawing.Size(805, 162)
            Me.dgvLiquidaciones.TabIndex = 223
            '
            'tpReporte
            '
            Me.tpReporte.Controls.Add(Me.Label4)
            Me.tpReporte.Controls.Add(Me.Label1)
            Me.tpReporte.Controls.Add(Me.txtCantidad)
            Me.tpReporte.Controls.Add(Me.txtTotal)
            Me.tpReporte.Controls.Add(Me.dgvSolicitudes)
            Me.tpReporte.Controls.Add(Me.Label3)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(817, 570)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "SOLICITUDES"
            Me.tpReporte.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(411, 10)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(55, 13)
            Me.Label4.TabIndex = 260
            Me.Label4.Text = "CANTIDAD"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(623, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 13)
            Me.Label1.TabIndex = 259
            Me.Label1.Text = "TOTAL"
            '
            'txtCantidad
            '
            Me.txtCantidad.BackColor = System.Drawing.Color.White
            Me.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCantidad.Enabled = False
            Me.txtCantidad.Location = New System.Drawing.Point(472, 7)
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(94, 21)
            Me.txtCantidad.TabIndex = 258
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotal.Enabled = False
            Me.txtTotal.Location = New System.Drawing.Point(663, 6)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(94, 21)
            Me.txtTotal.TabIndex = 257
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvSolicitudes
            '
            Me.dgvSolicitudes.AllowUserToAddRows = False
            Me.dgvSolicitudes.AllowUserToDeleteRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSolicitudes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White
            Me.dgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudes.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvSolicitudes.Location = New System.Drawing.Point(6, 30)
            Me.dgvSolicitudes.MultiSelect = False
            Me.dgvSolicitudes.Name = "dgvSolicitudes"
            Me.dgvSolicitudes.ReadOnly = True
            Me.dgvSolicitudes.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudes.Size = New System.Drawing.Size(804, 534)
            Me.dgvSolicitudes.TabIndex = 256
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(6, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(104, 18)
            Me.Label3.TabIndex = 255
            Me.Label3.Text = "SOLICITUDES:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCuadrar, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(830, 32)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCuadrar
            '
            Me.btnCuadrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadrar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCuadrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCuadrar.Name = "btnCuadrar"
            Me.btnCuadrar.Size = New System.Drawing.Size(89, 28)
            Me.btnCuadrar.Text = "CARGAR"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 28)
            Me.ToolStripMenuItem1.Text = "EXPORTAR LIQUIDACIONES"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 28)
            Me.ToolStripMenuItem2.Text = "EXPORTAR ASIENTO"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(170, 28)
            Me.ToolStripMenuItem3.Text = "EXPORTAR SOLICITUDES"
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.Location = New System.Drawing.Point(434, 43)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(40, 13)
            Me.lblHasta.TabIndex = 220
            Me.lblHasta.Text = "Hasta:"
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesde.Location = New System.Drawing.Point(159, 43)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(41, 13)
            Me.lblDesde.TabIndex = 219
            Me.lblDesde.Text = "Desde:"
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Location = New System.Drawing.Point(478, 40)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(200, 21)
            Me.dtpFinal.TabIndex = 218
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Location = New System.Drawing.Point(205, 40)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(200, 21)
            Me.dtpInicio.TabIndex = 217
            '
            'FormAuxiliaresLiquidaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(830, 650)
            Me.Controls.Add(Me.lblHasta)
            Me.Controls.Add(Me.lblDesde)
            Me.Controls.Add(Me.dtpFinal)
            Me.Controls.Add(Me.dtpInicio)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAuxiliaresLiquidaciones)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAuxiliaresLiquidaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AUXILIARES LIQUIDACIONES"
            Me.tcAuxiliaresLiquidaciones.ResumeLayout(False)
            Me.tpLiquidaciones.ResumeLayout(False)
            Me.tpLiquidaciones.PerformLayout()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpReporte.ResumeLayout(False)
            Me.tpReporte.PerformLayout()
            CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAuxiliaresLiquidaciones As System.Windows.Forms.TabControl
        Friend WithEvents tpLiquidaciones As System.Windows.Forms.TabPage
        Friend WithEvents lblidAsiento As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dgvLiquidaciones As System.Windows.Forms.DataGridView
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents rbFondo As System.Windows.Forms.RadioButton
        Friend WithEvents rbCaja As System.Windows.Forms.RadioButton
        Friend WithEvents lblDetalle As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dgvAsiento As System.Windows.Forms.DataGridView
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtHaber As System.Windows.Forms.TextBox
        Friend WithEvents txtDebe As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCuadrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents dgvSolicitudes As System.Windows.Forms.DataGridView
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace