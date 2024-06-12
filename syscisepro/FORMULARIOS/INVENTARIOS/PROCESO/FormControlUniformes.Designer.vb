Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormControlUniformes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormControlUniformes))
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
            Me.btnProcesar = New System.Windows.Forms.Button()
            Me.pbFoto = New System.Windows.Forms.PictureBox()
            Me.dgvControl = New System.Windows.Forms.DataGridView()
            Me.dgvTotales = New System.Windows.Forms.DataGridView()
            Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.KARDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.dgvCustodios = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.btnExportarComprobantes = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.chkCustodio = New System.Windows.Forms.RadioButton()
            Me.chkItem = New System.Windows.Forms.RadioButton()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnProcesar
            '
            Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProcesar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
            Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnProcesar.Location = New System.Drawing.Point(709, 241)
            Me.btnProcesar.Name = "btnProcesar"
            Me.btnProcesar.Size = New System.Drawing.Size(75, 21)
            Me.btnProcesar.TabIndex = 225
            Me.btnProcesar.Text = "Contar"
            Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnProcesar.UseVisualStyleBackColor = True
            '
            'pbFoto
            '
            Me.pbFoto.BackColor = System.Drawing.Color.Transparent
            Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pbFoto.Image = CType(resources.GetObject("pbFoto.Image"), System.Drawing.Image)
            Me.pbFoto.Location = New System.Drawing.Point(907, 67)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(155, 167)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 224
            Me.pbFoto.TabStop = False
            '
            'dgvControl
            '
            Me.dgvControl.AllowUserToAddRows = False
            Me.dgvControl.AllowUserToDeleteRows = False
            Me.dgvControl.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvControl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvControl.BackgroundColor = System.Drawing.Color.White
            Me.dgvControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvControl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvControl.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvControl.GridColor = System.Drawing.Color.White
            Me.dgvControl.Location = New System.Drawing.Point(0, 240)
            Me.dgvControl.MultiSelect = False
            Me.dgvControl.Name = "dgvControl"
            Me.dgvControl.ReadOnly = True
            Me.dgvControl.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvControl.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvControl.Size = New System.Drawing.Size(707, 370)
            Me.dgvControl.TabIndex = 49
            '
            'dgvTotales
            '
            Me.dgvTotales.AllowUserToAddRows = False
            Me.dgvTotales.AllowUserToDeleteRows = False
            Me.dgvTotales.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvTotales.BackgroundColor = System.Drawing.Color.White
            Me.dgvTotales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.CANTIDAD, Me.KARDEX})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotales.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvTotales.GridColor = System.Drawing.Color.White
            Me.dgvTotales.Location = New System.Drawing.Point(709, 240)
            Me.dgvTotales.MultiSelect = False
            Me.dgvTotales.Name = "dgvTotales"
            Me.dgvTotales.ReadOnly = True
            Me.dgvTotales.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvTotales.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTotales.Size = New System.Drawing.Size(364, 370)
            Me.dgvTotales.TabIndex = 50
            '
            'ITEM
            '
            Me.ITEM.HeaderText = "ITEM"
            Me.ITEM.Name = "ITEM"
            Me.ITEM.ReadOnly = True
            Me.ITEM.Width = 230
            '
            'CANTIDAD
            '
            Me.CANTIDAD.HeaderText = "CANTIDAD"
            Me.CANTIDAD.Name = "CANTIDAD"
            Me.CANTIDAD.ReadOnly = True
            Me.CANTIDAD.Width = 60
            '
            'KARDEX
            '
            Me.KARDEX.HeaderText = "KARDEX"
            Me.KARDEX.Name = "KARDEX"
            Me.KARDEX.ReadOnly = True
            Me.KARDEX.Width = 50
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.Black
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(143, 38)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(492, 21)
            Me.txtParametrobusqueda.TabIndex = 11
            '
            'dgvCustodios
            '
            Me.dgvCustodios.AllowUserToAddRows = False
            Me.dgvCustodios.AllowUserToDeleteRows = False
            Me.dgvCustodios.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCustodios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvCustodios.BackgroundColor = System.Drawing.Color.White
            Me.dgvCustodios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvCustodios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCustodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCustodios.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvCustodios.GridColor = System.Drawing.Color.White
            Me.dgvCustodios.Location = New System.Drawing.Point(0, 62)
            Me.dgvCustodios.MultiSelect = False
            Me.dgvCustodios.Name = "dgvCustodios"
            Me.dgvCustodios.ReadOnly = True
            Me.dgvCustodios.RowHeadersVisible = False
            Me.dgvCustodios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCustodios.Size = New System.Drawing.Size(872, 177)
            Me.dgvCustodios.TabIndex = 8
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportarComprobantes, Me.ToolStripMenuItem1})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1074, 32)
            Me.msKardex.TabIndex = 226
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(78, 28)
            Me.btnExportarComprobantes.Text = "DATOS"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(92, 28)
            Me.ToolStripMenuItem1.Text = "DETALLE"
            '
            'chkCustodio
            '
            Me.chkCustodio.AutoSize = True
            Me.chkCustodio.Checked = True
            Me.chkCustodio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkCustodio.Location = New System.Drawing.Point(7, 38)
            Me.chkCustodio.Name = "chkCustodio"
            Me.chkCustodio.Size = New System.Drawing.Size(69, 17)
            Me.chkCustodio.TabIndex = 227
            Me.chkCustodio.TabStop = True
            Me.chkCustodio.Text = "Custodio"
            Me.chkCustodio.UseVisualStyleBackColor = True
            '
            'chkItem
            '
            Me.chkItem.AutoSize = True
            Me.chkItem.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkItem.Location = New System.Drawing.Point(90, 37)
            Me.chkItem.Name = "chkItem"
            Me.chkItem.Size = New System.Drawing.Size(48, 17)
            Me.chkItem.TabIndex = 228
            Me.chkItem.Text = "Item"
            Me.chkItem.UseVisualStyleBackColor = True
            '
            'dtpHasta
            '
            Me.dtpHasta.CustomFormat = "dd MMMM yyyy"
            Me.dtpHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHasta.Location = New System.Drawing.Point(919, 35)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(153, 21)
            Me.dtpHasta.TabIndex = 231
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(873, 38)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(46, 13)
            Me.Label19.TabIndex = 232
            Me.Label19.Text = "HASTA:"
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "dd MMMM yyyy"
            Me.dtpDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDesde.Location = New System.Drawing.Point(694, 35)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(154, 21)
            Me.dtpDesde.TabIndex = 229
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(653, 38)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(43, 13)
            Me.Label17.TabIndex = 230
            Me.Label17.Text = "DESDE:"
            '
            'FormControlUniformes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1074, 611)
            Me.Controls.Add(Me.dtpHasta)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.dtpDesde)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.chkItem)
            Me.Controls.Add(Me.chkCustodio)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.btnProcesar)
            Me.Controls.Add(Me.pbFoto)
            Me.Controls.Add(Me.dgvTotales)
            Me.Controls.Add(Me.dgvCustodios)
            Me.Controls.Add(Me.dgvControl)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormControlUniformes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipY
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "CONTROL DE BODEGA POR PERSONAL / ITEM"
            CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvCustodios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents dgvCustodios As System.Windows.Forms.DataGridView
        Friend WithEvents dgvControl As System.Windows.Forms.DataGridView
        Friend WithEvents dgvTotales As System.Windows.Forms.DataGridView
        Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents KARDEX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
        Friend WithEvents btnProcesar As System.Windows.Forms.Button
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chkCustodio As System.Windows.Forms.RadioButton
        Friend WithEvents chkItem As System.Windows.Forms.RadioButton
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace