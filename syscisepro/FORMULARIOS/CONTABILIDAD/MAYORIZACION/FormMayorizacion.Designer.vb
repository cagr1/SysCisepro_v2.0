Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMayorizacion
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
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMayorizacion))
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.dgvMayoresPadres = New System.Windows.Forms.DataGridView()
            Me.txtCuentaPadre = New System.Windows.Forms.TextBox()
            Me.dgvMayoresHijos = New System.Windows.Forms.DataGridView()
            Me.txtSaldo = New System.Windows.Forms.TextBox()
            Me.txtAcreedorRegistros = New System.Windows.Forms.TextBox()
            Me.txtDeudorRegistros = New System.Windows.Forms.TextBox()
            Me.txtSaldoAsiento = New System.Windows.Forms.TextBox()
            Me.txtAcreedorAsiento = New System.Windows.Forms.TextBox()
            Me.txtDeudorAsiento = New System.Windows.Forms.TextBox()
            Me.dgvAsiento = New System.Windows.Forms.DataGridView()
            Me.dgvRegistros = New System.Windows.Forms.DataGridView()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnMayores = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMayoresHijos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(222, 4)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(107, 21)
            Me.dtpFinal.TabIndex = 214
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicio.Location = New System.Drawing.Point(55, 4)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(107, 21)
            Me.dtpInicio.TabIndex = 213
            '
            'dgvMayoresPadres
            '
            Me.dgvMayoresPadres.AllowUserToAddRows = False
            Me.dgvMayoresPadres.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresPadres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayoresPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayoresPadres.Location = New System.Drawing.Point(863, 3)
            Me.dgvMayoresPadres.Name = "dgvMayoresPadres"
            Me.dgvMayoresPadres.ReadOnly = True
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresPadres.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayoresPadres.Size = New System.Drawing.Size(28, 19)
            Me.dgvMayoresPadres.TabIndex = 226
            Me.dgvMayoresPadres.Visible = False
            '
            'txtCuentaPadre
            '
            Me.txtCuentaPadre.BackColor = System.Drawing.Color.White
            Me.txtCuentaPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaPadre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaPadre.Location = New System.Drawing.Point(401, 4)
            Me.txtCuentaPadre.Name = "txtCuentaPadre"
            Me.txtCuentaPadre.Size = New System.Drawing.Size(342, 21)
            Me.txtCuentaPadre.TabIndex = 217
            '
            'dgvMayoresHijos
            '
            Me.dgvMayoresHijos.AllowUserToAddRows = False
            Me.dgvMayoresHijos.AllowUserToDeleteRows = False
            Me.dgvMayoresHijos.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresHijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMayoresHijos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvMayoresHijos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMayoresHijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayoresHijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayoresHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMayoresHijos.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMayoresHijos.Location = New System.Drawing.Point(7, 30)
            Me.dgvMayoresHijos.MultiSelect = False
            Me.dgvMayoresHijos.Name = "dgvMayoresHijos"
            Me.dgvMayoresHijos.ReadOnly = True
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMayoresHijos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvMayoresHijos.RowHeadersVisible = False
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvMayoresHijos.RowsDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvMayoresHijos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvMayoresHijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayoresHijos.Size = New System.Drawing.Size(471, 48)
            Me.dgvMayoresHijos.TabIndex = 228
            '
            'txtSaldo
            '
            Me.txtSaldo.BackColor = System.Drawing.Color.White
            Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSaldo.Enabled = False
            Me.txtSaldo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldo.Location = New System.Drawing.Point(762, 351)
            Me.txtSaldo.Name = "txtSaldo"
            Me.txtSaldo.Size = New System.Drawing.Size(131, 21)
            Me.txtSaldo.TabIndex = 287
            Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorRegistros
            '
            Me.txtAcreedorRegistros.BackColor = System.Drawing.Color.White
            Me.txtAcreedorRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAcreedorRegistros.Enabled = False
            Me.txtAcreedorRegistros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorRegistros.Location = New System.Drawing.Point(571, 352)
            Me.txtAcreedorRegistros.Name = "txtAcreedorRegistros"
            Me.txtAcreedorRegistros.Size = New System.Drawing.Size(122, 21)
            Me.txtAcreedorRegistros.TabIndex = 278
            Me.txtAcreedorRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorRegistros
            '
            Me.txtDeudorRegistros.BackColor = System.Drawing.Color.White
            Me.txtDeudorRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDeudorRegistros.Enabled = False
            Me.txtDeudorRegistros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorRegistros.Location = New System.Drawing.Point(365, 351)
            Me.txtDeudorRegistros.Name = "txtDeudorRegistros"
            Me.txtDeudorRegistros.Size = New System.Drawing.Size(122, 21)
            Me.txtDeudorRegistros.TabIndex = 277
            Me.txtDeudorRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSaldoAsiento
            '
            Me.txtSaldoAsiento.BackColor = System.Drawing.Color.White
            Me.txtSaldoAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSaldoAsiento.Enabled = False
            Me.txtSaldoAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoAsiento.Location = New System.Drawing.Point(767, 579)
            Me.txtSaldoAsiento.Name = "txtSaldoAsiento"
            Me.txtSaldoAsiento.Size = New System.Drawing.Size(131, 21)
            Me.txtSaldoAsiento.TabIndex = 289
            Me.txtSaldoAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAcreedorAsiento
            '
            Me.txtAcreedorAsiento.BackColor = System.Drawing.Color.White
            Me.txtAcreedorAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAcreedorAsiento.Enabled = False
            Me.txtAcreedorAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorAsiento.Location = New System.Drawing.Point(568, 579)
            Me.txtAcreedorAsiento.Name = "txtAcreedorAsiento"
            Me.txtAcreedorAsiento.Size = New System.Drawing.Size(122, 21)
            Me.txtAcreedorAsiento.TabIndex = 282
            Me.txtAcreedorAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeudorAsiento
            '
            Me.txtDeudorAsiento.BackColor = System.Drawing.Color.White
            Me.txtDeudorAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDeudorAsiento.Enabled = False
            Me.txtDeudorAsiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorAsiento.Location = New System.Drawing.Point(365, 579)
            Me.txtDeudorAsiento.Name = "txtDeudorAsiento"
            Me.txtDeudorAsiento.Size = New System.Drawing.Size(122, 21)
            Me.txtDeudorAsiento.TabIndex = 281
            Me.txtDeudorAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvAsiento
            '
            Me.dgvAsiento.AllowUserToAddRows = False
            Me.dgvAsiento.AllowUserToDeleteRows = False
            Me.dgvAsiento.AllowUserToResizeRows = False
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsiento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvAsiento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsiento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsiento.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvAsiento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsiento.Location = New System.Drawing.Point(0, 0)
            Me.dgvAsiento.MultiSelect = False
            Me.dgvAsiento.Name = "dgvAsiento"
            Me.dgvAsiento.ReadOnly = True
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsiento.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvAsiento.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvAsiento.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsiento.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsiento.Size = New System.Drawing.Size(904, 170)
            Me.dgvAsiento.TabIndex = 230
            '
            'dgvRegistros
            '
            Me.dgvRegistros.AllowUserToAddRows = False
            Me.dgvRegistros.AllowUserToDeleteRows = False
            Me.dgvRegistros.AllowUserToResizeRows = False
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvRegistros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvRegistros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRegistros.DefaultCellStyle = DataGridViewCellStyle15
            Me.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvRegistros.Location = New System.Drawing.Point(0, 0)
            Me.dgvRegistros.MultiSelect = False
            Me.dgvRegistros.Name = "dgvRegistros"
            Me.dgvRegistros.ReadOnly = True
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Roboto", 8.25!)
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRegistros.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvRegistros.RowHeadersVisible = False
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvRegistros.RowsDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvRegistros.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRegistros.Size = New System.Drawing.Size(904, 170)
            Me.dgvRegistros.TabIndex = 229
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.CheckBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.CheckBox1.Location = New System.Drawing.Point(758, 4)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(97, 17)
            Me.CheckBox1.TabIndex = 227
            Me.CheckBox1.Text = "Cuenta padre?"
            Me.CheckBox1.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnMayores, Me.btnExportar, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(914, 32)
            Me.MenuStrip1.TabIndex = 288
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(87, 28)
            Me.btnCargar.Text = "BUSCAR"
            '
            'btnMayores
            '
            Me.btnMayores.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnMayores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnMayores.Name = "btnMayores"
            Me.btnMayores.Size = New System.Drawing.Size(88, 28)
            Me.btnMayores.Text = "DETALLE"
            '
            'btnExportar
            '
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(89, 28)
            Me.btnExportar.Text = "ASIENTO"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.REPORTEASIENTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(93, 28)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE "
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.CheckBox1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvMayoresPadres)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCuentaPadre)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpFinal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dgvMayoresHijos)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.dtpInicio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(908, 109)
            Me.KryptonGroupBox1.TabIndex = 291
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Desde"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(169, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel2.TabIndex = 215
            Me.KryptonLabel2.Values.Text = "Hasta"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(346, 5)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel3.TabIndex = 216
            Me.KryptonLabel3.Values.Text = "Cuenta"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(0, 151)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvRegistros)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(908, 194)
            Me.KryptonGroupBox2.TabIndex = 292
            Me.KryptonGroupBox2.Values.Heading = "Detalle Mayor"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel4.Location = New System.Drawing.Point(307, 352)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(54, 20)
            Me.KryptonLabel4.TabIndex = 293
            Me.KryptonLabel4.Values.Text = "Deudor"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel5.Location = New System.Drawing.Point(503, 351)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel5.TabIndex = 294
            Me.KryptonLabel5.Values.Text = "Acreedor"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel6.Location = New System.Drawing.Point(715, 352)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel6.TabIndex = 295
            Me.KryptonLabel6.Values.Text = "Saldo"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(2, 379)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.dgvAsiento)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(908, 194)
            Me.KryptonGroupBox3.TabIndex = 296
            Me.KryptonGroupBox3.Values.Heading = "Asiento"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel7.Location = New System.Drawing.Point(715, 579)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(43, 20)
            Me.KryptonLabel7.TabIndex = 299
            Me.KryptonLabel7.Values.Text = "Saldo"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel8.Location = New System.Drawing.Point(503, 578)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(64, 20)
            Me.KryptonLabel8.TabIndex = 298
            Me.KryptonLabel8.Values.Text = "Acreedor"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
            Me.KryptonLabel9.Location = New System.Drawing.Point(307, 579)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(54, 20)
            Me.KryptonLabel9.TabIndex = 297
            Me.KryptonLabel9.Values.Text = "Deudor"
            '
            'FormMayorizacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(914, 600)
            Me.Controls.Add(Me.txtSaldoAsiento)
            Me.Controls.Add(Me.KryptonLabel7)
            Me.Controls.Add(Me.KryptonLabel8)
            Me.Controls.Add(Me.txtAcreedorAsiento)
            Me.Controls.Add(Me.KryptonLabel9)
            Me.Controls.Add(Me.KryptonGroupBox3)
            Me.Controls.Add(Me.txtDeudorAsiento)
            Me.Controls.Add(Me.txtSaldo)
            Me.Controls.Add(Me.KryptonLabel6)
            Me.Controls.Add(Me.KryptonLabel5)
            Me.Controls.Add(Me.KryptonLabel4)
            Me.Controls.Add(Me.txtAcreedorRegistros)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.txtDeudorRegistros)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMayorizacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MAYORIZACION"
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMayoresHijos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvMayoresPadres As System.Windows.Forms.DataGridView
        Friend WithEvents txtCuentaPadre As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayoresHijos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvRegistros As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsiento As System.Windows.Forms.DataGridView
        Friend WithEvents txtAcreedorRegistros As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorRegistros As System.Windows.Forms.TextBox
        Friend WithEvents txtAcreedorAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorAsiento As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoAsiento As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnMayores As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace