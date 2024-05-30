Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarLiquidacionFondoRotativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarLiquidacionFondoRotativo))
            Me.dgvLiquidacionFondoRotativo = New System.Windows.Forms.DataGridView()
            Me.lblIdLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblFechaLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblTotalLiquidacionFondoRotativo = New System.Windows.Forms.Label()
            Me.lblFondoLiquidacion = New System.Windows.Forms.Label()
            Me.lblGastosLiquidacion = New System.Windows.Forms.Label()
            Me.lblSaldoLiquidacion = New System.Windows.Forms.Label()
            Me.lblReposicionLiquidacion = New System.Windows.Forms.Label()
            Me.txtIdLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFechaLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtTotalLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtFondoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtGastosLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtSaldoLiquidacion = New System.Windows.Forms.TextBox()
            Me.txtReposicionLiquidacion = New System.Windows.Forms.TextBox()
            Me.gbLiquidacion = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbLiquidacion.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvLiquidacionFondoRotativo
            '
            Me.dgvLiquidacionFondoRotativo.AllowUserToAddRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToDeleteRows = False
            Me.dgvLiquidacionFondoRotativo.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLiquidacionFondoRotativo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLiquidacionFondoRotativo.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvLiquidacionFondoRotativo.Location = New System.Drawing.Point(1, 73)
            Me.dgvLiquidacionFondoRotativo.MultiSelect = False
            Me.dgvLiquidacionFondoRotativo.Name = "dgvLiquidacionFondoRotativo"
            Me.dgvLiquidacionFondoRotativo.RowHeadersVisible = False
            Me.dgvLiquidacionFondoRotativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLiquidacionFondoRotativo.Size = New System.Drawing.Size(1015, 490)
            Me.dgvLiquidacionFondoRotativo.TabIndex = 0
            '
            'lblIdLiquidacionFondoRotativo
            '
            Me.lblIdLiquidacionFondoRotativo.AutoSize = True
            Me.lblIdLiquidacionFondoRotativo.Location = New System.Drawing.Point(9, 23)
            Me.lblIdLiquidacionFondoRotativo.Name = "lblIdLiquidacionFondoRotativo"
            Me.lblIdLiquidacionFondoRotativo.Size = New System.Drawing.Size(23, 13)
            Me.lblIdLiquidacionFondoRotativo.TabIndex = 1
            Me.lblIdLiquidacionFondoRotativo.Text = "ID :"
            '
            'lblFechaLiquidacionFondoRotativo
            '
            Me.lblFechaLiquidacionFondoRotativo.AutoSize = True
            Me.lblFechaLiquidacionFondoRotativo.Location = New System.Drawing.Point(94, 23)
            Me.lblFechaLiquidacionFondoRotativo.Name = "lblFechaLiquidacionFondoRotativo"
            Me.lblFechaLiquidacionFondoRotativo.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaLiquidacionFondoRotativo.TabIndex = 2
            Me.lblFechaLiquidacionFondoRotativo.Text = "FECHA:"
            '
            'lblTotalLiquidacionFondoRotativo
            '
            Me.lblTotalLiquidacionFondoRotativo.AutoSize = True
            Me.lblTotalLiquidacionFondoRotativo.Location = New System.Drawing.Point(819, 23)
            Me.lblTotalLiquidacionFondoRotativo.Name = "lblTotalLiquidacionFondoRotativo"
            Me.lblTotalLiquidacionFondoRotativo.Size = New System.Drawing.Size(45, 13)
            Me.lblTotalLiquidacionFondoRotativo.TabIndex = 3
            Me.lblTotalLiquidacionFondoRotativo.Text = "TOTAL:"
            '
            'lblFondoLiquidacion
            '
            Me.lblFondoLiquidacion.AutoSize = True
            Me.lblFondoLiquidacion.Location = New System.Drawing.Point(312, 24)
            Me.lblFondoLiquidacion.Name = "lblFondoLiquidacion"
            Me.lblFondoLiquidacion.Size = New System.Drawing.Size(47, 13)
            Me.lblFondoLiquidacion.TabIndex = 4
            Me.lblFondoLiquidacion.Text = "FONDO:"
            '
            'lblGastosLiquidacion
            '
            Me.lblGastosLiquidacion.AutoSize = True
            Me.lblGastosLiquidacion.Location = New System.Drawing.Point(537, 24)
            Me.lblGastosLiquidacion.Name = "lblGastosLiquidacion"
            Me.lblGastosLiquidacion.Size = New System.Drawing.Size(54, 13)
            Me.lblGastosLiquidacion.TabIndex = 5
            Me.lblGastosLiquidacion.Text = "GASTOS:"
            '
            'lblSaldoLiquidacion
            '
            Me.lblSaldoLiquidacion.AutoSize = True
            Me.lblSaldoLiquidacion.Location = New System.Drawing.Point(423, 24)
            Me.lblSaldoLiquidacion.Name = "lblSaldoLiquidacion"
            Me.lblSaldoLiquidacion.Size = New System.Drawing.Size(45, 13)
            Me.lblSaldoLiquidacion.TabIndex = 6
            Me.lblSaldoLiquidacion.Text = "SALDO:"
            '
            'lblReposicionLiquidacion
            '
            Me.lblReposicionLiquidacion.AutoSize = True
            Me.lblReposicionLiquidacion.Location = New System.Drawing.Point(677, 23)
            Me.lblReposicionLiquidacion.Name = "lblReposicionLiquidacion"
            Me.lblReposicionLiquidacion.Size = New System.Drawing.Size(74, 13)
            Me.lblReposicionLiquidacion.TabIndex = 7
            Me.lblReposicionLiquidacion.Text = "REPOSICION:"
            '
            'txtIdLiquidacion
            '
            Me.txtIdLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtIdLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdLiquidacion.Enabled = False
            Me.txtIdLiquidacion.Location = New System.Drawing.Point(33, 20)
            Me.txtIdLiquidacion.Name = "txtIdLiquidacion"
            Me.txtIdLiquidacion.Size = New System.Drawing.Size(51, 21)
            Me.txtIdLiquidacion.TabIndex = 8
            '
            'txtFechaLiquidacion
            '
            Me.txtFechaLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtFechaLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaLiquidacion.Enabled = False
            Me.txtFechaLiquidacion.Location = New System.Drawing.Point(140, 21)
            Me.txtFechaLiquidacion.Name = "txtFechaLiquidacion"
            Me.txtFechaLiquidacion.Size = New System.Drawing.Size(150, 21)
            Me.txtFechaLiquidacion.TabIndex = 9
            '
            'txtTotalLiquidacion
            '
            Me.txtTotalLiquidacion.BackColor = System.Drawing.Color.White
            Me.txtTotalLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalLiquidacion.Enabled = False
            Me.txtTotalLiquidacion.Location = New System.Drawing.Point(867, 20)
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
            Me.txtFondoLiquidacion.Location = New System.Drawing.Point(361, 20)
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
            Me.txtGastosLiquidacion.Location = New System.Drawing.Point(592, 20)
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
            Me.txtSaldoLiquidacion.Location = New System.Drawing.Point(468, 20)
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
            Me.txtReposicionLiquidacion.Location = New System.Drawing.Point(751, 20)
            Me.txtReposicionLiquidacion.Name = "txtReposicionLiquidacion"
            Me.txtReposicionLiquidacion.Size = New System.Drawing.Size(48, 21)
            Me.txtReposicionLiquidacion.TabIndex = 14
            Me.txtReposicionLiquidacion.Text = "0.00"
            Me.txtReposicionLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbLiquidacion
            '
            Me.gbLiquidacion.BackColor = System.Drawing.Color.White
            Me.gbLiquidacion.Controls.Add(Me.Button1)
            Me.gbLiquidacion.Controls.Add(Me.lblIdLiquidacionFondoRotativo)
            Me.gbLiquidacion.Controls.Add(Me.lblFechaLiquidacionFondoRotativo)
            Me.gbLiquidacion.Controls.Add(Me.lblTotalLiquidacionFondoRotativo)
            Me.gbLiquidacion.Controls.Add(Me.txtReposicionLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtSaldoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtGastosLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblSaldoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtFondoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblReposicionLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtTotalLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtIdLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.txtFechaLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblFondoLiquidacion)
            Me.gbLiquidacion.Controls.Add(Me.lblGastosLiquidacion)
            Me.gbLiquidacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbLiquidacion.ForeColor = System.Drawing.Color.Black
            Me.gbLiquidacion.Location = New System.Drawing.Point(-1, 25)
            Me.gbLiquidacion.Name = "gbLiquidacion"
            Me.gbLiquidacion.Size = New System.Drawing.Size(1017, 48)
            Me.gbLiquidacion.TabIndex = 16
            Me.gbLiquidacion.TabStop = False
            Me.gbLiquidacion.Text = "LIQUIDACION"
            '
            'Button1
            '
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.report
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Button1.Location = New System.Drawing.Point(943, 7)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(73, 40)
            Me.Button1.TabIndex = 15
            Me.Button1.Text = "REPORTE"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.Button1.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1018, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR LIQUIDACIONES"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(191, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(43, 13)
            Me.Label1.TabIndex = 190
            Me.Label1.Text = "DESDE:"
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
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(460, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 192
            Me.Label2.Text = "HASTA:"
            '
            'FormBuscarLiquidacionFondoRotativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1018, 565)
            Me.Controls.Add(Me.DateTimePicker2)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbLiquidacion)
            Me.Controls.Add(Me.dgvLiquidacionFondoRotativo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarLiquidacionFondoRotativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BUSCAR LIQUIDACION FONDO ROTATIVO"
            CType(Me.dgvLiquidacionFondoRotativo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbLiquidacion.ResumeLayout(False)
            Me.gbLiquidacion.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvLiquidacionFondoRotativo As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblFechaLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblTotalLiquidacionFondoRotativo As System.Windows.Forms.Label
        Friend WithEvents lblFondoLiquidacion As System.Windows.Forms.Label
        Friend WithEvents lblGastosLiquidacion As System.Windows.Forms.Label
        Friend WithEvents lblSaldoLiquidacion As System.Windows.Forms.Label
        Friend WithEvents lblReposicionLiquidacion As System.Windows.Forms.Label
        Friend WithEvents txtIdLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFondoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtGastosLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtSaldoLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents txtReposicionLiquidacion As System.Windows.Forms.TextBox
        Friend WithEvents gbLiquidacion As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace