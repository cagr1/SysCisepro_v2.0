Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormBuscarLiquidacionFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarLiquidacionFondoRotativo))
            Me.dgvLiquidacionFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.txtIdLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFechaLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFondoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtGastosLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtSaldoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtReposicionLiquidacion = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvLiquidacionFondoRotativo
            '
            Me.dgvLiquidacionFondoRotativo.AllowUserToAddRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLiquidacionFondoRotativo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvLiquidacionFondoRotativo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvLiquidacionFondoRotativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvLiquidacionFondoRotativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLiquidacionFondoRotativo.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLiquidacionFondoRotativo.Location = New System.Drawing.Point(5, 103)
            Me.dgvLiquidacionFondoRotativo.MultiSelect = False
            Me.dgvLiquidacionFondoRotativo.Name = "dgvLiquidacionFondoRotativo"
            Me.dgvLiquidacionFondoRotativo.RowHeadersVisible = False
            Me.dgvLiquidacionFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionFondoRotativo.Size = New System.Drawing.Size(830, 397)
            Me.dgvLiquidacionFondoRotativo.TabIndex = 0
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtIdLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdLiquidacion.Enabled = False
            Me.txtIdLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(29, 9)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(51, 21)
            Me.txtIdLiquidacion.TabIndex = 8
            '
            'txtFechaLiquidacion
            '
            Me.txtFechaLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFechaLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaLiquidacion.Enabled = False
            Me.txtFechaLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaLiquidacion.Location = New System.Drawing.Point(132, 10)
            Me.txtFechaLiquidacion.Name = "txtFechaLiquidacion"
            Me.txtFechaLiquidacion.Size = New System.Drawing.Size(111, 21)
            Me.txtFechaLiquidacion.TabIndex = 9
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(710, 7)
            Me.txtTotalLiquidacion.Name = "txtTotalLiquidacion"
            Me.txtTotalLiquidacion.Size = New System.Drawing.Size(69, 21)
            Me.txtTotalLiquidacion.TabIndex = 10
            Me.txtTotalLiquidacion.Text = "0.00"
            Me.txtTotalLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtFondoLiquidacion
            '
            Me.txtFondoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFondoLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFondoLiquidacion.Enabled = False
            Me.txtFondoLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFondoLiquidacion.Location = New System.Drawing.Point(298, 10)
            Me.txtFondoLiquidacion.Name = "txtFondoLiquidacion"
            Me.txtFondoLiquidacion.Size = New System.Drawing.Size(43, 21)
            Me.txtFondoLiquidacion.TabIndex = 11
            Me.txtFondoLiquidacion.Text = "0.00"
            Me.txtFondoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtGastosLiquidacion
            '
            Me.txtGastosLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtGastosLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtGastosLiquidacion.Enabled = False
            Me.txtGastosLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGastosLiquidacion.Location = New System.Drawing.Point(484, 9)
            Me.txtGastosLiquidacion.Name = "txtGastosLiquidacion"
            Me.txtGastosLiquidacion.Size = New System.Drawing.Size(51, 21)
            Me.txtGastosLiquidacion.TabIndex = 12
            Me.txtGastosLiquidacion.Text = "0.00"
            Me.txtGastosLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSaldoLiquidacion
            '
            Me.txtSaldoLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtSaldoLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSaldoLiquidacion.Enabled = False
            Me.txtSaldoLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSaldoLiquidacion.Location = New System.Drawing.Point(389, 9)
            Me.txtSaldoLiquidacion.Name = "txtSaldoLiquidacion"
            Me.txtSaldoLiquidacion.Size = New System.Drawing.Size(46, 21)
            Me.txtSaldoLiquidacion.TabIndex = 13
            Me.txtSaldoLiquidacion.Text = "0.00"
            Me.txtSaldoLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtReposicionLiquidacion
            '
            Me.txtReposicionLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtReposicionLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReposicionLiquidacion.Enabled = False
            Me.txtReposicionLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReposicionLiquidacion.Location = New System.Drawing.Point(614, 8)
            Me.txtReposicionLiquidacion.Name = "txtReposicionLiquidacion"
            Me.txtReposicionLiquidacion.Size = New System.Drawing.Size(48, 21)
            Me.txtReposicionLiquidacion.TabIndex = 14
            Me.txtReposicionLiquidacion.Text = "0.00"
            Me.txtReposicionLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.Button1.Location = New System.Drawing.Point(785, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(32, 34)
            Me.Button1.TabIndex = 15
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.Button1.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(839, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(189, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(38, 13)
            Me.Label1.TabIndex = 190
            Me.Label1.Text = "Desde"
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker1.Location = New System.Drawing.Point(238, 2)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
            Me.DateTimePicker1.TabIndex = 191
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker2.Location = New System.Drawing.Point(507, 2)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(200, 21)
            Me.DateTimePicker2.TabIndex = 193
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(455, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(37, 13)
            Me.Label2.TabIndex = 192
            Me.Label2.Text = "Hasta"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Button1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtReposicionLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTotalLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtGastosLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSaldoLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaLiquidacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFondoLiquidacion)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(830, 60)
            Me.KryptonGroupBox1.TabIndex = 194
            Me.KryptonGroupBox1.Values.Heading = "Liquidacion"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 8)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(22, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "ID"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(83, 9)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 9
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(249, 9)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel3.TabIndex = 10
            Me.KryptonLabel3.Values.Text = "Fondo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(347, 10)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel4.TabIndex = 12
            Me.KryptonLabel4.Values.Text = "Saldo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(439, 8)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel5.TabIndex = 14
            Me.KryptonLabel5.Values.Text = "Gasto"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(541, 8)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(70, 20)
            Me.KryptonLabel6.TabIndex = 15
            Me.KryptonLabel6.Values.Text = "Reposicion"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(668, 9)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel7.TabIndex = 16
            Me.KryptonLabel7.Values.Text = "Total"
            '
            'FormBuscarLiquidacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(839, 504)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.DateTimePicker2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvLiquidacionFondoRotativo)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarLiquidacionFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "BUSCAR LIQUIDACION FONDO ROTATIVO"
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvLiquidacionFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFondoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtGastosLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtReposicionLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace