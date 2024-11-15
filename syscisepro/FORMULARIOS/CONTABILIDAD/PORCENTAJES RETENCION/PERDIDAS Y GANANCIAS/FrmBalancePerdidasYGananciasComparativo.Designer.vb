Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBalancePerdidasYGananciasComparativo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBalancePerdidasYGananciasComparativo))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.dgvIngresos = New System.Windows.Forms.DataGridView()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgvEgresos = New System.Windows.Forms.DataGridView()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarMensual = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
            Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
            Me.GroupBox1.Controls.Add(Me.Label24)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 33)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1073, 45)
            Me.GroupBox1.TabIndex = 119
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "FILTRAR DATOS"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(125, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "MES CORTE:"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(202, 16)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.ShowUpDown = True
            Me.dtpFechaHasta.Size = New System.Drawing.Size(161, 21)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "MMMM - yyyy"
            Me.dtpFechaDesde.Enabled = False
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(518, 16)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.ShowUpDown = True
            Me.dtpFechaDesde.Size = New System.Drawing.Size(161, 20)
            Me.dtpFechaDesde.TabIndex = 0
            Me.dtpFechaDesde.Visible = False
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(455, 16)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(37, 13)
            Me.Label24.TabIndex = 230
            Me.Label24.Text = "desde"
            Me.Label24.Visible = False
            '
            'dgvIngresos
            '
            Me.dgvIngresos.AllowUserToAddRows = False
            Me.dgvIngresos.AllowUserToDeleteRows = False
            Me.dgvIngresos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvIngresos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvIngresos.BackgroundColor = System.Drawing.Color.White
            Me.dgvIngresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvIngresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvIngresos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvIngresos.Location = New System.Drawing.Point(1, 92)
            Me.dgvIngresos.Name = "dgvIngresos"
            Me.dgvIngresos.ReadOnly = True
            Me.dgvIngresos.RowHeadersVisible = False
            Me.dgvIngresos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            Me.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvIngresos.Size = New System.Drawing.Size(1073, 208)
            Me.dgvIngresos.TabIndex = 227
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.White
            Me.Label2.Location = New System.Drawing.Point(2, 79)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(1069, 12)
            Me.Label2.TabIndex = 228
            Me.Label2.Text = "INGRESOS"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(1, 300)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(1072, 12)
            Me.Label3.TabIndex = 230
            Me.Label3.Text = "EGRESOS"
            '
            'dgvEgresos
            '
            Me.dgvEgresos.AllowUserToAddRows = False
            Me.dgvEgresos.AllowUserToDeleteRows = False
            Me.dgvEgresos.AllowUserToResizeRows = False
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEgresos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvEgresos.BackgroundColor = System.Drawing.Color.White
            Me.dgvEgresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvEgresos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvEgresos.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvEgresos.Location = New System.Drawing.Point(1, 313)
            Me.dgvEgresos.Name = "dgvEgresos"
            Me.dgvEgresos.ReadOnly = True
            Me.dgvEgresos.RowHeadersVisible = False
            Me.dgvEgresos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            Me.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEgresos.Size = New System.Drawing.Size(1073, 198)
            Me.dgvEgresos.TabIndex = 229
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(1, 76)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(1073, 433)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.PictureBox1.TabIndex = 231
            Me.PictureBox1.TabStop = False
            Me.PictureBox1.Visible = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarMensual, Me.Button1, Me.Button2, Me.Button3})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1074, 32)
            Me.MenuStrip1.TabIndex = 291
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarMensual
            '
            Me.btnBuscarMensual.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarMensual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscarMensual.Name = "btnBuscarMensual"
            Me.btnBuscarMensual.Size = New System.Drawing.Size(89, 28)
            Me.btnBuscarMensual.Text = "CARGAR"
            '
            'Button1
            '
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(93, 28)
            Me.Button1.Text = "GENERAL"
            '
            'Button2
            '
            Me.Button2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(97, 28)
            Me.Button2.Text = "INGRESOS"
            '
            'Button3
            '
            Me.Button3.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(91, 28)
            Me.Button3.Text = "EGRESOS"
            '
            'FrmBalancePerdidasYGananciasComparativo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1074, 512)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dgvEgresos)
            Me.Controls.Add(Me.dgvIngresos)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmBalancePerdidasYGananciasComparativo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTADO DE PERDIDAS Y GANANCIAS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvIngresos As System.Windows.Forms.DataGridView
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgvEgresos As System.Windows.Forms.DataGridView
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarMensual As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Button3 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace