Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormCrearCategoriasItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCrearCategoriasItem))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.tcItems = New System.Windows.Forms.TabControl()
            Me.tpCategoriasItem = New System.Windows.Forms.TabPage()
            Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCancelarCategoría = New System.Windows.Forms.Button()
            Me.btnGuardarCategoría = New System.Windows.Forms.Button()
            Me.btnNuevaCategoría = New System.Windows.Forms.Button()
            Me.tpGrupo = New System.Windows.Forms.TabPage()
            Me.btnCancelarGrupo = New System.Windows.Forms.Button()
            Me.btnGuardarGrupo = New System.Windows.Forms.Button()
            Me.btnNuevoGrupo = New System.Windows.Forms.Button()
            Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
            Me.lblNombreGrupo = New System.Windows.Forms.Label()
            Me.cbmCategoría = New System.Windows.Forms.ComboBox()
            Me.lblCategoría = New System.Windows.Forms.Label()
            Me.lblIdCategoría = New System.Windows.Forms.Label()
            Me.tpSubGrupo = New System.Windows.Forms.TabPage()
            Me.btnCancelarSubGrupo = New System.Windows.Forms.Button()
            Me.btnGuardarSubGrupo = New System.Windows.Forms.Button()
            Me.btnNuevoSubGrupo = New System.Windows.Forms.Button()
            Me.txtNombreSubGrupo = New System.Windows.Forms.TextBox()
            Me.lblNombreSubGrupo = New System.Windows.Forms.Label()
            Me.cbmGrupo = New System.Windows.Forms.ComboBox()
            Me.lblGrupo = New System.Windows.Forms.Label()
            Me.lblIdGrupo = New System.Windows.Forms.Label()
            Me.dgvPrevio = New System.Windows.Forms.DataGridView()
            Me.tcItems.SuspendLayout()
            Me.tpCategoriasItem.SuspendLayout()
            Me.tpGrupo.SuspendLayout()
            Me.tpSubGrupo.SuspendLayout()
            CType(Me.dgvPrevio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tcItems
            '
            Me.tcItems.Controls.Add(Me.tpCategoriasItem)
            Me.tcItems.Controls.Add(Me.tpGrupo)
            Me.tcItems.Controls.Add(Me.tpSubGrupo)
            Me.tcItems.Location = New System.Drawing.Point(2, 2)
            Me.tcItems.Name = "tcItems"
            Me.tcItems.SelectedIndex = 0
            Me.tcItems.Size = New System.Drawing.Size(364, 152)
            Me.tcItems.TabIndex = 0
            '
            'tpCategoriasItem
            '
            Me.tpCategoriasItem.Controls.Add(Me.txtNombreCategoria)
            Me.tpCategoriasItem.Controls.Add(Me.Label2)
            Me.tpCategoriasItem.Controls.Add(Me.btnCancelarCategoría)
            Me.tpCategoriasItem.Controls.Add(Me.btnGuardarCategoría)
            Me.tpCategoriasItem.Controls.Add(Me.btnNuevaCategoría)
            Me.tpCategoriasItem.Location = New System.Drawing.Point(4, 22)
            Me.tpCategoriasItem.Name = "tpCategoriasItem"
            Me.tpCategoriasItem.Padding = New System.Windows.Forms.Padding(3)
            Me.tpCategoriasItem.Size = New System.Drawing.Size(356, 126)
            Me.tpCategoriasItem.TabIndex = 0
            Me.tpCategoriasItem.Text = "CATEGORÍA"
            Me.tpCategoriasItem.UseVisualStyleBackColor = True
            '
            'txtNombreCategoria
            '
            Me.txtNombreCategoria.Enabled = False
            Me.txtNombreCategoria.Location = New System.Drawing.Point(13, 58)
            Me.txtNombreCategoria.Multiline = True
            Me.txtNombreCategoria.Name = "txtNombreCategoria"
            Me.txtNombreCategoria.Size = New System.Drawing.Size(324, 62)
            Me.txtNombreCategoria.TabIndex = 149
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(56, 13)
            Me.Label2.TabIndex = 147
            Me.Label2.Text = "NOMBRE:"
            '
            'btnCancelarCategoría
            '
            Me.btnCancelarCategoría.BackColor = System.Drawing.Color.White
            Me.btnCancelarCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarCategoría.Enabled = False
            Me.btnCancelarCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarCategoría.Image = CType(resources.GetObject("btnCancelarCategoría.Image"), System.Drawing.Image)
            Me.btnCancelarCategoría.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancelarCategoría.Location = New System.Drawing.Point(188, 6)
            Me.btnCancelarCategoría.Name = "btnCancelarCategoría"
            Me.btnCancelarCategoría.Size = New System.Drawing.Size(85, 26)
            Me.btnCancelarCategoría.TabIndex = 145
            Me.btnCancelarCategoría.Text = "CANCELAR"
            Me.btnCancelarCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarCategoría.UseVisualStyleBackColor = False
            '
            'btnGuardarCategoría
            '
            Me.btnGuardarCategoría.BackColor = System.Drawing.Color.White
            Me.btnGuardarCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarCategoría.Enabled = False
            Me.btnGuardarCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarCategoría.Image = CType(resources.GetObject("btnGuardarCategoría.Image"), System.Drawing.Image)
            Me.btnGuardarCategoría.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGuardarCategoría.Location = New System.Drawing.Point(97, 6)
            Me.btnGuardarCategoría.Name = "btnGuardarCategoría"
            Me.btnGuardarCategoría.Size = New System.Drawing.Size(85, 26)
            Me.btnGuardarCategoría.TabIndex = 144
            Me.btnGuardarCategoría.Text = "GUARDAR"
            Me.btnGuardarCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarCategoría.UseVisualStyleBackColor = False
            '
            'btnNuevaCategoría
            '
            Me.btnNuevaCategoría.BackColor = System.Drawing.Color.White
            Me.btnNuevaCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevaCategoría.FlatAppearance.BorderSize = 0
            Me.btnNuevaCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevaCategoría.Image = CType(resources.GetObject("btnNuevaCategoría.Image"), System.Drawing.Image)
            Me.btnNuevaCategoría.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevaCategoría.Location = New System.Drawing.Point(6, 6)
            Me.btnNuevaCategoría.Name = "btnNuevaCategoría"
            Me.btnNuevaCategoría.Size = New System.Drawing.Size(85, 26)
            Me.btnNuevaCategoría.TabIndex = 143
            Me.btnNuevaCategoría.Text = "NUEVO"
            Me.btnNuevaCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevaCategoría.UseVisualStyleBackColor = False
            '
            'tpGrupo
            '
            Me.tpGrupo.Controls.Add(Me.btnCancelarGrupo)
            Me.tpGrupo.Controls.Add(Me.btnGuardarGrupo)
            Me.tpGrupo.Controls.Add(Me.btnNuevoGrupo)
            Me.tpGrupo.Controls.Add(Me.txtNombreGrupo)
            Me.tpGrupo.Controls.Add(Me.lblNombreGrupo)
            Me.tpGrupo.Controls.Add(Me.cbmCategoría)
            Me.tpGrupo.Controls.Add(Me.lblCategoría)
            Me.tpGrupo.Controls.Add(Me.lblIdCategoría)
            Me.tpGrupo.Location = New System.Drawing.Point(4, 22)
            Me.tpGrupo.Name = "tpGrupo"
            Me.tpGrupo.Padding = New System.Windows.Forms.Padding(3)
            Me.tpGrupo.Size = New System.Drawing.Size(356, 126)
            Me.tpGrupo.TabIndex = 1
            Me.tpGrupo.Text = "GRUPO"
            Me.tpGrupo.UseVisualStyleBackColor = True
            '
            'btnCancelarGrupo
            '
            Me.btnCancelarGrupo.BackColor = System.Drawing.Color.White
            Me.btnCancelarGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarGrupo.Enabled = False
            Me.btnCancelarGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarGrupo.Image = CType(resources.GetObject("btnCancelarGrupo.Image"), System.Drawing.Image)
            Me.btnCancelarGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancelarGrupo.Location = New System.Drawing.Point(188, 6)
            Me.btnCancelarGrupo.Name = "btnCancelarGrupo"
            Me.btnCancelarGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnCancelarGrupo.TabIndex = 157
            Me.btnCancelarGrupo.Text = "CANCELAR"
            Me.btnCancelarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarGrupo.UseVisualStyleBackColor = False
            '
            'btnGuardarGrupo
            '
            Me.btnGuardarGrupo.BackColor = System.Drawing.Color.White
            Me.btnGuardarGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarGrupo.Enabled = False
            Me.btnGuardarGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarGrupo.Image = CType(resources.GetObject("btnGuardarGrupo.Image"), System.Drawing.Image)
            Me.btnGuardarGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGuardarGrupo.Location = New System.Drawing.Point(97, 6)
            Me.btnGuardarGrupo.Name = "btnGuardarGrupo"
            Me.btnGuardarGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnGuardarGrupo.TabIndex = 156
            Me.btnGuardarGrupo.Text = "GUARDAR"
            Me.btnGuardarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarGrupo.UseVisualStyleBackColor = False
            '
            'btnNuevoGrupo
            '
            Me.btnNuevoGrupo.BackColor = System.Drawing.Color.White
            Me.btnNuevoGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevoGrupo.FlatAppearance.BorderSize = 0
            Me.btnNuevoGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevoGrupo.Image = CType(resources.GetObject("btnNuevoGrupo.Image"), System.Drawing.Image)
            Me.btnNuevoGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevoGrupo.Location = New System.Drawing.Point(6, 6)
            Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
            Me.btnNuevoGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnNuevoGrupo.TabIndex = 155
            Me.btnNuevoGrupo.Text = "NUEVO"
            Me.btnNuevoGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevoGrupo.UseVisualStyleBackColor = False
            '
            'txtNombreGrupo
            '
            Me.txtNombreGrupo.Enabled = False
            Me.txtNombreGrupo.Location = New System.Drawing.Point(13, 86)
            Me.txtNombreGrupo.Multiline = True
            Me.txtNombreGrupo.Name = "txtNombreGrupo"
            Me.txtNombreGrupo.Size = New System.Drawing.Size(324, 37)
            Me.txtNombreGrupo.TabIndex = 151
            '
            'lblNombreGrupo
            '
            Me.lblNombreGrupo.AutoSize = True
            Me.lblNombreGrupo.Location = New System.Drawing.Point(10, 70)
            Me.lblNombreGrupo.Name = "lblNombreGrupo"
            Me.lblNombreGrupo.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreGrupo.TabIndex = 150
            Me.lblNombreGrupo.Text = "NOMBRE:"
            '
            'cbmCategoría
            '
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(81, 38)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(256, 21)
            Me.cbmCategoría.TabIndex = 101
            '
            'lblCategoría
            '
            Me.lblCategoría.AutoSize = True
            Me.lblCategoría.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lblCategoría.Location = New System.Drawing.Point(9, 41)
            Me.lblCategoría.Name = "lblCategoría"
            Me.lblCategoría.Size = New System.Drawing.Size(66, 13)
            Me.lblCategoría.TabIndex = 100
            Me.lblCategoría.Text = "CATEGORÍA"
            '
            'lblIdCategoría
            '
            Me.lblIdCategoría.AutoSize = True
            Me.lblIdCategoría.ForeColor = System.Drawing.Color.Red
            Me.lblIdCategoría.Location = New System.Drawing.Point(289, 42)
            Me.lblIdCategoría.Name = "lblIdCategoría"
            Me.lblIdCategoría.Size = New System.Drawing.Size(31, 13)
            Me.lblIdCategoría.TabIndex = 102
            Me.lblIdCategoría.Text = "0000"
            Me.lblIdCategoría.Visible = False
            '
            'tpSubGrupo
            '
            Me.tpSubGrupo.Controls.Add(Me.btnCancelarSubGrupo)
            Me.tpSubGrupo.Controls.Add(Me.btnGuardarSubGrupo)
            Me.tpSubGrupo.Controls.Add(Me.btnNuevoSubGrupo)
            Me.tpSubGrupo.Controls.Add(Me.txtNombreSubGrupo)
            Me.tpSubGrupo.Controls.Add(Me.lblNombreSubGrupo)
            Me.tpSubGrupo.Controls.Add(Me.cbmGrupo)
            Me.tpSubGrupo.Controls.Add(Me.lblGrupo)
            Me.tpSubGrupo.Controls.Add(Me.lblIdGrupo)
            Me.tpSubGrupo.Location = New System.Drawing.Point(4, 22)
            Me.tpSubGrupo.Name = "tpSubGrupo"
            Me.tpSubGrupo.Padding = New System.Windows.Forms.Padding(3)
            Me.tpSubGrupo.Size = New System.Drawing.Size(356, 126)
            Me.tpSubGrupo.TabIndex = 2
            Me.tpSubGrupo.Text = "SUB GRUPO"
            Me.tpSubGrupo.UseVisualStyleBackColor = True
            '
            'btnCancelarSubGrupo
            '
            Me.btnCancelarSubGrupo.BackColor = System.Drawing.Color.White
            Me.btnCancelarSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarSubGrupo.Enabled = False
            Me.btnCancelarSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarSubGrupo.Image = CType(resources.GetObject("btnCancelarSubGrupo.Image"), System.Drawing.Image)
            Me.btnCancelarSubGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCancelarSubGrupo.Location = New System.Drawing.Point(188, 6)
            Me.btnCancelarSubGrupo.Name = "btnCancelarSubGrupo"
            Me.btnCancelarSubGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnCancelarSubGrupo.TabIndex = 165
            Me.btnCancelarSubGrupo.Text = "CANCELAR"
            Me.btnCancelarSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarSubGrupo.UseVisualStyleBackColor = False
            '
            'btnGuardarSubGrupo
            '
            Me.btnGuardarSubGrupo.BackColor = System.Drawing.Color.White
            Me.btnGuardarSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarSubGrupo.Enabled = False
            Me.btnGuardarSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarSubGrupo.Image = CType(resources.GetObject("btnGuardarSubGrupo.Image"), System.Drawing.Image)
            Me.btnGuardarSubGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGuardarSubGrupo.Location = New System.Drawing.Point(97, 6)
            Me.btnGuardarSubGrupo.Name = "btnGuardarSubGrupo"
            Me.btnGuardarSubGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnGuardarSubGrupo.TabIndex = 164
            Me.btnGuardarSubGrupo.Text = "GUARDAR"
            Me.btnGuardarSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarSubGrupo.UseVisualStyleBackColor = False
            '
            'btnNuevoSubGrupo
            '
            Me.btnNuevoSubGrupo.BackColor = System.Drawing.Color.White
            Me.btnNuevoSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevoSubGrupo.FlatAppearance.BorderSize = 0
            Me.btnNuevoSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevoSubGrupo.Image = CType(resources.GetObject("btnNuevoSubGrupo.Image"), System.Drawing.Image)
            Me.btnNuevoSubGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevoSubGrupo.Location = New System.Drawing.Point(6, 6)
            Me.btnNuevoSubGrupo.Name = "btnNuevoSubGrupo"
            Me.btnNuevoSubGrupo.Size = New System.Drawing.Size(85, 26)
            Me.btnNuevoSubGrupo.TabIndex = 163
            Me.btnNuevoSubGrupo.Text = "NUEVO"
            Me.btnNuevoSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevoSubGrupo.UseVisualStyleBackColor = False
            '
            'txtNombreSubGrupo
            '
            Me.txtNombreSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreSubGrupo.Enabled = False
            Me.txtNombreSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSubGrupo.Location = New System.Drawing.Point(15, 84)
            Me.txtNombreSubGrupo.Multiline = True
            Me.txtNombreSubGrupo.Name = "txtNombreSubGrupo"
            Me.txtNombreSubGrupo.Size = New System.Drawing.Size(324, 36)
            Me.txtNombreSubGrupo.TabIndex = 159
            '
            'lblNombreSubGrupo
            '
            Me.lblNombreSubGrupo.AutoSize = True
            Me.lblNombreSubGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreSubGrupo.Location = New System.Drawing.Point(12, 68)
            Me.lblNombreSubGrupo.Name = "lblNombreSubGrupo"
            Me.lblNombreSubGrupo.Size = New System.Drawing.Size(56, 13)
            Me.lblNombreSubGrupo.TabIndex = 158
            Me.lblNombreSubGrupo.Text = "NOMBRE:"
            '
            'cbmGrupo
            '
            Me.cbmGrupo.BackColor = System.Drawing.Color.White
            Me.cbmGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo.Enabled = False
            Me.cbmGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(65, 38)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(274, 21)
            Me.cbmGrupo.TabIndex = 156
            '
            'lblGrupo
            '
            Me.lblGrupo.AutoSize = True
            Me.lblGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGrupo.Location = New System.Drawing.Point(14, 41)
            Me.lblGrupo.Name = "lblGrupo"
            Me.lblGrupo.Size = New System.Drawing.Size(45, 13)
            Me.lblGrupo.TabIndex = 155
            Me.lblGrupo.Text = "GRUPO"
            '
            'lblIdGrupo
            '
            Me.lblIdGrupo.AutoSize = True
            Me.lblIdGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdGrupo.ForeColor = System.Drawing.Color.Red
            Me.lblIdGrupo.Location = New System.Drawing.Point(293, 41)
            Me.lblIdGrupo.Name = "lblIdGrupo"
            Me.lblIdGrupo.Size = New System.Drawing.Size(31, 13)
            Me.lblIdGrupo.TabIndex = 157
            Me.lblIdGrupo.Text = "0000"
            '
            'dgvPrevio
            '
            Me.dgvPrevio.AllowUserToAddRows = False
            Me.dgvPrevio.AllowUserToDeleteRows = False
            Me.dgvPrevio.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPrevio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPrevio.BackgroundColor = System.Drawing.Color.White
            Me.dgvPrevio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvPrevio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
            Me.dgvPrevio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPrevio.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPrevio.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvPrevio.Location = New System.Drawing.Point(2, 160)
            Me.dgvPrevio.MultiSelect = False
            Me.dgvPrevio.Name = "dgvPrevio"
            Me.dgvPrevio.ReadOnly = True
            Me.dgvPrevio.RowHeadersVisible = False
            Me.dgvPrevio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPrevio.Size = New System.Drawing.Size(364, 129)
            Me.dgvPrevio.TabIndex = 208
            '
            'FormCrearCategoriasItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(369, 293)
            Me.Controls.Add(Me.dgvPrevio)
            Me.Controls.Add(Me.tcItems)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormCrearCategoriasItem"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTOS DE CATEGORÍAS DE ITEMS"
            Me.tcItems.ResumeLayout(False)
            Me.tpCategoriasItem.ResumeLayout(False)
            Me.tpCategoriasItem.PerformLayout()
            Me.tpGrupo.ResumeLayout(False)
            Me.tpGrupo.PerformLayout()
            Me.tpSubGrupo.ResumeLayout(False)
            Me.tpSubGrupo.PerformLayout()
            CType(Me.dgvPrevio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcItems As System.Windows.Forms.TabControl
        Friend WithEvents tpGrupo As System.Windows.Forms.TabPage
        Friend WithEvents tpSubGrupo As System.Windows.Forms.TabPage
        Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreGrupo As System.Windows.Forms.Label
        Friend WithEvents lblIdCategoría As System.Windows.Forms.Label
        Friend WithEvents cbmCategoría As System.Windows.Forms.ComboBox
        Friend WithEvents lblCategoría As System.Windows.Forms.Label
        Friend WithEvents txtNombreSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreSubGrupo As System.Windows.Forms.Label
        Friend WithEvents lblIdGrupo As System.Windows.Forms.Label
        Friend WithEvents cbmGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents lblGrupo As System.Windows.Forms.Label
        Friend WithEvents tpCategoriasItem As System.Windows.Forms.TabPage
        Friend WithEvents txtNombreCategoria As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnCancelarCategoría As System.Windows.Forms.Button
        Friend WithEvents btnGuardarCategoría As System.Windows.Forms.Button
        Friend WithEvents btnNuevaCategoría As System.Windows.Forms.Button
        Friend WithEvents dgvPrevio As System.Windows.Forms.DataGridView
        Friend WithEvents btnCancelarGrupo As System.Windows.Forms.Button
        Friend WithEvents btnGuardarGrupo As System.Windows.Forms.Button
        Friend WithEvents btnNuevoGrupo As System.Windows.Forms.Button
        Friend WithEvents btnCancelarSubGrupo As System.Windows.Forms.Button
        Friend WithEvents btnGuardarSubGrupo As System.Windows.Forms.Button
        Friend WithEvents btnNuevoSubGrupo As System.Windows.Forms.Button
    End Class
End Namespace