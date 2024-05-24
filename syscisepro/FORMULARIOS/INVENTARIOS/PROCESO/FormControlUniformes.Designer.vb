Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormControlUniformes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormControlUniformes))
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.btnProcesar.Size = New System.Drawing.Size(75, 22)
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
            Me.pbFoto.Location = New System.Drawing.Point(878, 56)
            Me.pbFoto.Name = "pbFoto"
            Me.pbFoto.Size = New System.Drawing.Size(194, 183)
            Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbFoto.TabIndex = 224
            Me.pbFoto.TabStop = False
            '
            'dgvControl
            '
            Me.dgvControl.AllowUserToAddRows = False
            Me.dgvControl.AllowUserToDeleteRows = False
            Me.dgvControl.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvControl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvControl.BackgroundColor = System.Drawing.Color.White
            Me.dgvControl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvControl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvControl.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvControl.GridColor = System.Drawing.Color.White
            Me.dgvControl.Location = New System.Drawing.Point(0, 240)
            Me.dgvControl.MultiSelect = False
            Me.dgvControl.Name = "dgvControl"
            Me.dgvControl.ReadOnly = True
            Me.dgvControl.RowHeadersVisible = False
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvControl.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvControl.Size = New System.Drawing.Size(707, 370)
            Me.dgvControl.TabIndex = 49
            '
            'dgvTotales
            '
            Me.dgvTotales.AllowUserToAddRows = False
            Me.dgvTotales.AllowUserToDeleteRows = False
            Me.dgvTotales.AllowUserToResizeRows = False
            DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvTotales.BackgroundColor = System.Drawing.Color.White
            Me.dgvTotales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.CANTIDAD, Me.KARDEX})
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotales.DefaultCellStyle = DataGridViewCellStyle17
            Me.dgvTotales.GridColor = System.Drawing.Color.White
            Me.dgvTotales.Location = New System.Drawing.Point(709, 240)
            Me.dgvTotales.MultiSelect = False
            Me.dgvTotales.Name = "dgvTotales"
            Me.dgvTotales.ReadOnly = True
            Me.dgvTotales.RowHeadersVisible = False
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvTotales.RowsDefaultCellStyle = DataGridViewCellStyle18
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
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.Black
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(143, 27)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(492, 23)
            Me.txtParametrobusqueda.TabIndex = 11
            '
            'dgvCustodios
            '
            Me.dgvCustodios.AllowUserToAddRows = False
            Me.dgvCustodios.AllowUserToDeleteRows = False
            Me.dgvCustodios.AllowUserToResizeRows = False
            DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCustodios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
            Me.dgvCustodios.BackgroundColor = System.Drawing.Color.White
            Me.dgvCustodios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvCustodios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCustodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCustodios.DefaultCellStyle = DataGridViewCellStyle20
            Me.dgvCustodios.GridColor = System.Drawing.Color.White
            Me.dgvCustodios.Location = New System.Drawing.Point(0, 56)
            Me.dgvCustodios.MultiSelect = False
            Me.dgvCustodios.Name = "dgvCustodios"
            Me.dgvCustodios.ReadOnly = True
            Me.dgvCustodios.RowHeadersVisible = False
            Me.dgvCustodios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCustodios.Size = New System.Drawing.Size(872, 183)
            Me.dgvCustodios.TabIndex = 8
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportarComprobantes, Me.ToolStripMenuItem1})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.msKardex.Size = New System.Drawing.Size(1074, 24)
            Me.msKardex.TabIndex = 226
            Me.msKardex.Text = "msIngresoBodega"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportarComprobantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(133, 20)
            Me.btnExportarComprobantes.Text = "EXPORTAR DATOS"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(147, 20)
            Me.ToolStripMenuItem1.Text = "EXPORTAR DETALLE"
            '
            'chkCustodio
            '
            Me.chkCustodio.AutoSize = True
            Me.chkCustodio.Checked = True
            Me.chkCustodio.Location = New System.Drawing.Point(7, 30)
            Me.chkCustodio.Name = "chkCustodio"
            Me.chkCustodio.Size = New System.Drawing.Size(72, 17)
            Me.chkCustodio.TabIndex = 227
            Me.chkCustodio.TabStop = True
            Me.chkCustodio.Text = "Custodio"
            Me.chkCustodio.UseVisualStyleBackColor = True
            '
            'chkItem
            '
            Me.chkItem.AutoSize = True
            Me.chkItem.Location = New System.Drawing.Point(90, 30)
            Me.chkItem.Name = "chkItem"
            Me.chkItem.Size = New System.Drawing.Size(47, 17)
            Me.chkItem.TabIndex = 228
            Me.chkItem.Text = "Item"
            Me.chkItem.UseVisualStyleBackColor = True
            '
            'dtpHasta
            '
            Me.dtpHasta.CustomFormat = "dd MMMM yyyy"
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHasta.Location = New System.Drawing.Point(919, 30)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(153, 22)
            Me.dtpHasta.TabIndex = 231
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(878, 33)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 232
            Me.Label19.Text = "HASTA:"
            '
            'dtpDesde
            '
            Me.dtpDesde.CustomFormat = "dd MMMM yyyy"
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDesde.Location = New System.Drawing.Point(694, 30)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(154, 22)
            Me.dtpDesde.TabIndex = 229
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(653, 33)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(44, 13)
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
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormControlUniformes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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