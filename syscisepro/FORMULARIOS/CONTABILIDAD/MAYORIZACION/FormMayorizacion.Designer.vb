Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMayorizacion
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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMayorizacion))
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.dgvMayoresPadres = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCuentaPadre = New System.Windows.Forms.TextBox()
            Me.dgvMayoresHijos = New System.Windows.Forms.DataGridView()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.txtSaldo = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtAcreedorRegistros = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtDeudorRegistros = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.txtSaldoAsiento = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtAcreedorAsiento = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtDeudorAsiento = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dgvAsiento = New System.Windows.Forms.DataGridView()
            Me.dgvRegistros = New System.Windows.Forms.DataGridView()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnMayores = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMayoresHijos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel7.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblHasta.Location = New System.Drawing.Point(5, 29)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(43, 13)
            Me.lblHasta.TabIndex = 216
            Me.lblHasta.Text = "Hasta:"
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.lblDesde.Location = New System.Drawing.Point(4, 6)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(43, 13)
            Me.lblDesde.TabIndex = 215
            Me.lblDesde.Text = "Desde:"
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.dtpFinal.Location = New System.Drawing.Point(46, 26)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(230, 20)
            Me.dtpFinal.TabIndex = 214
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.dtpInicio.Location = New System.Drawing.Point(46, 3)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(230, 20)
            Me.dtpInicio.TabIndex = 213
            '
            'dgvMayoresPadres
            '
            Me.dgvMayoresPadres.AllowUserToAddRows = False
            Me.dgvMayoresPadres.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresPadres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMayoresPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayoresPadres.Location = New System.Drawing.Point(-539, 9)
            Me.dgvMayoresPadres.Name = "dgvMayoresPadres"
            Me.dgvMayoresPadres.ReadOnly = True
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresPadres.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMayoresPadres.Size = New System.Drawing.Size(910, 19)
            Me.dgvMayoresPadres.TabIndex = 226
            Me.dgvMayoresPadres.Visible = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(17, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(49, 13)
            Me.Label1.TabIndex = 218
            Me.Label1.Text = "CUENTA:"
            '
            'txtCuentaPadre
            '
            Me.txtCuentaPadre.BackColor = System.Drawing.Color.White
            Me.txtCuentaPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaPadre.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaPadre.Location = New System.Drawing.Point(65, 6)
            Me.txtCuentaPadre.Name = "txtCuentaPadre"
            Me.txtCuentaPadre.Size = New System.Drawing.Size(590, 20)
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
            Me.dgvMayoresHijos.BackgroundColor = System.Drawing.Color.White
            Me.dgvMayoresHijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvMayoresHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMayoresHijos.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMayoresHijos.Location = New System.Drawing.Point(0, 80)
            Me.dgvMayoresHijos.MultiSelect = False
            Me.dgvMayoresHijos.Name = "dgvMayoresHijos"
            Me.dgvMayoresHijos.ReadOnly = True
            Me.dgvMayoresHijos.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvMayoresHijos.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMayoresHijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMayoresHijos.Size = New System.Drawing.Size(948, 48)
            Me.dgvMayoresHijos.TabIndex = 228
            '
            'Panel7
            '
            Me.Panel7.BackColor = System.Drawing.Color.White
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.Label13)
            Me.Panel7.Location = New System.Drawing.Point(0, 135)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(948, 27)
            Me.Panel7.TabIndex = 290
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(399, 3)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(153, 19)
            Me.Label13.TabIndex = 231
            Me.Label13.Text = "DETALLE DE MAYOR"
            '
            'Panel6
            '
            Me.Panel6.BackColor = System.Drawing.Color.White
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.txtSaldo)
            Me.Panel6.Controls.Add(Me.Label14)
            Me.Panel6.Controls.Add(Me.txtAcreedorRegistros)
            Me.Panel6.Controls.Add(Me.Label18)
            Me.Panel6.Controls.Add(Me.txtDeudorRegistros)
            Me.Panel6.Controls.Add(Me.Label19)
            Me.Panel6.Location = New System.Drawing.Point(0, 402)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(948, 32)
            Me.Panel6.TabIndex = 289
            '
            'txtSaldo
            '
            Me.txtSaldo.BackColor = System.Drawing.Color.White
            Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSaldo.Enabled = False
            Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldo.Location = New System.Drawing.Point(810, 4)
            Me.txtSaldo.Name = "txtSaldo"
            Me.txtSaldo.Size = New System.Drawing.Size(131, 20)
            Me.txtSaldo.TabIndex = 287
            Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label14.Location = New System.Drawing.Point(772, 8)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(37, 13)
            Me.Label14.TabIndex = 288
            Me.Label14.Text = "SALDO"
            '
            'txtAcreedorRegistros
            '
            Me.txtAcreedorRegistros.BackColor = System.Drawing.Color.White
            Me.txtAcreedorRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAcreedorRegistros.Enabled = False
            Me.txtAcreedorRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorRegistros.Location = New System.Drawing.Point(611, 4)
            Me.txtAcreedorRegistros.Name = "txtAcreedorRegistros"
            Me.txtAcreedorRegistros.Size = New System.Drawing.Size(122, 20)
            Me.txtAcreedorRegistros.TabIndex = 278
            Me.txtAcreedorRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label18.Location = New System.Drawing.Point(550, 8)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 13)
            Me.Label18.TabIndex = 280
            Me.Label18.Text = "ACREEDOR"
            '
            'txtDeudorRegistros
            '
            Me.txtDeudorRegistros.BackColor = System.Drawing.Color.White
            Me.txtDeudorRegistros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDeudorRegistros.Enabled = False
            Me.txtDeudorRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorRegistros.Location = New System.Drawing.Point(408, 4)
            Me.txtDeudorRegistros.Name = "txtDeudorRegistros"
            Me.txtDeudorRegistros.Size = New System.Drawing.Size(122, 20)
            Me.txtDeudorRegistros.TabIndex = 277
            Me.txtDeudorRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label19.Location = New System.Drawing.Point(359, 8)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 279
            Me.Label19.Text = "DEUDOR"
            '
            'Panel5
            '
            Me.Panel5.BackColor = System.Drawing.Color.White
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.Label10)
            Me.Panel5.Location = New System.Drawing.Point(0, 443)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(948, 27)
            Me.Panel5.TabIndex = 288
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(435, 3)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(72, 19)
            Me.Label10.TabIndex = 231
            Me.Label10.Text = "ASIENTO"
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.White
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.txtSaldoAsiento)
            Me.Panel4.Controls.Add(Me.Label15)
            Me.Panel4.Controls.Add(Me.txtAcreedorAsiento)
            Me.Panel4.Controls.Add(Me.Label11)
            Me.Panel4.Controls.Add(Me.txtDeudorAsiento)
            Me.Panel4.Controls.Add(Me.Label12)
            Me.Panel4.Location = New System.Drawing.Point(0, 638)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(948, 32)
            Me.Panel4.TabIndex = 287
            '
            'txtSaldoAsiento
            '
            Me.txtSaldoAsiento.BackColor = System.Drawing.Color.White
            Me.txtSaldoAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSaldoAsiento.Enabled = False
            Me.txtSaldoAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoAsiento.Location = New System.Drawing.Point(810, 4)
            Me.txtSaldoAsiento.Name = "txtSaldoAsiento"
            Me.txtSaldoAsiento.Size = New System.Drawing.Size(131, 20)
            Me.txtSaldoAsiento.TabIndex = 289
            Me.txtSaldoAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label15.Location = New System.Drawing.Point(767, 8)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(37, 13)
            Me.Label15.TabIndex = 290
            Me.Label15.Text = "SALDO"
            '
            'txtAcreedorAsiento
            '
            Me.txtAcreedorAsiento.BackColor = System.Drawing.Color.White
            Me.txtAcreedorAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAcreedorAsiento.Enabled = False
            Me.txtAcreedorAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAcreedorAsiento.Location = New System.Drawing.Point(611, 4)
            Me.txtAcreedorAsiento.Name = "txtAcreedorAsiento"
            Me.txtAcreedorAsiento.Size = New System.Drawing.Size(122, 20)
            Me.txtAcreedorAsiento.TabIndex = 282
            Me.txtAcreedorAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label11.Location = New System.Drawing.Point(550, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(55, 13)
            Me.Label11.TabIndex = 284
            Me.Label11.Text = "ACREEDOR"
            '
            'txtDeudorAsiento
            '
            Me.txtDeudorAsiento.BackColor = System.Drawing.Color.White
            Me.txtDeudorAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDeudorAsiento.Enabled = False
            Me.txtDeudorAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeudorAsiento.Location = New System.Drawing.Point(408, 4)
            Me.txtDeudorAsiento.Name = "txtDeudorAsiento"
            Me.txtDeudorAsiento.Size = New System.Drawing.Size(122, 20)
            Me.txtDeudorAsiento.TabIndex = 281
            Me.txtDeudorAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.Label12.Location = New System.Drawing.Point(359, 8)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(43, 13)
            Me.Label12.TabIndex = 283
            Me.Label12.Text = "DEUDOR"
            '
            'dgvAsiento
            '
            Me.dgvAsiento.AllowUserToAddRows = False
            Me.dgvAsiento.AllowUserToDeleteRows = False
            Me.dgvAsiento.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsiento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAsiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvAsiento.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsiento.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsiento.Location = New System.Drawing.Point(0, 469)
            Me.dgvAsiento.MultiSelect = False
            Me.dgvAsiento.Name = "dgvAsiento"
            Me.dgvAsiento.ReadOnly = True
            Me.dgvAsiento.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsiento.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsiento.Size = New System.Drawing.Size(948, 168)
            Me.dgvAsiento.TabIndex = 230
            '
            'dgvRegistros
            '
            Me.dgvRegistros.AllowUserToAddRows = False
            Me.dgvRegistros.AllowUserToDeleteRows = False
            Me.dgvRegistros.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvRegistros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvRegistros.BackgroundColor = System.Drawing.Color.White
            Me.dgvRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRegistros.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvRegistros.Location = New System.Drawing.Point(0, 161)
            Me.dgvRegistros.MultiSelect = False
            Me.dgvRegistros.Name = "dgvRegistros"
            Me.dgvRegistros.ReadOnly = True
            Me.dgvRegistros.RowHeadersVisible = False
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvRegistros.RowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRegistros.Size = New System.Drawing.Size(948, 242)
            Me.dgvRegistros.TabIndex = 229
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.dtpInicio)
            Me.Panel1.Controls.Add(Me.dtpFinal)
            Me.Panel1.Controls.Add(Me.lblDesde)
            Me.Panel1.Controls.Add(Me.lblHasta)
            Me.Panel1.Location = New System.Drawing.Point(0, 25)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(282, 52)
            Me.Panel1.TabIndex = 287
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.CheckBox1)
            Me.Panel2.Controls.Add(Me.txtCuentaPadre)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.dgvMayoresPadres)
            Me.Panel2.Location = New System.Drawing.Point(288, 25)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(660, 52)
            Me.Panel2.TabIndex = 287
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CheckBox1.Location = New System.Drawing.Point(516, 30)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
            Me.CheckBox1.TabIndex = 227
            Me.CheckBox1.Text = "ES CUENTA PADRE?"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnMayores, Me.btnExportar, Me.REPORTEASIENTOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
            Me.MenuStrip1.TabIndex = 288
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(81, 20)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnMayores
            '
            Me.btnMayores.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnMayores.Name = "btnMayores"
            Me.btnMayores.Size = New System.Drawing.Size(138, 20)
            Me.btnMayores.Text = "EXPORTAR DETALLE"
            '
            'btnExportar
            '
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(139, 20)
            Me.btnExportar.Text = "EXPORTAR ASIENTO"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.report
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE PDF"
            '
            'FormMayorizacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(944, 672)
            Me.Controls.Add(Me.Panel5)
            Me.Controls.Add(Me.Panel4)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.dgvAsiento)
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.dgvMayoresHijos)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.dgvRegistros)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMayorizacion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MAYORIZACION"
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMayoresHijos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            CType(Me.dgvAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvMayoresPadres As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCuentaPadre As System.Windows.Forms.TextBox
        Friend WithEvents dgvMayoresHijos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvRegistros As System.Windows.Forms.DataGridView
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents dgvAsiento As System.Windows.Forms.DataGridView
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtAcreedorRegistros As System.Windows.Forms.TextBox
        Friend WithEvents txtDeudorRegistros As System.Windows.Forms.TextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents txtAcreedorAsiento As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtDeudorAsiento As System.Windows.Forms.TextBox
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtSaldoAsiento As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnMayores As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace