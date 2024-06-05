Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMantenimientoMarcasMaterialesColores
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
            Dim ID_CATEGORIALabel As System.Windows.Forms.Label
            Dim NOMBRE_CATEGORIALabel As System.Windows.Forms.Label
            Dim ID_SUB_GRUPOLabel As System.Windows.Forms.Label
            Dim NOMBRE_SUB_GRUPOLabel As System.Windows.Forms.Label
            Dim ID_GRUPOLabel As System.Windows.Forms.Label
            Dim NOMBRE_GRUPOLabel As System.Windows.Forms.Label
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoMarcasMaterialesColores))
            Me.dgvMarcas = New System.Windows.Forms.DataGridView()
            Me.dgvMateriales = New System.Windows.Forms.DataGridView()
            Me.dgvColores = New System.Windows.Forms.DataGridView()
            Me.gbMarcas = New System.Windows.Forms.GroupBox()
            Me.btnGuardarMarca = New System.Windows.Forms.Button()
            Me.btnNuevoMarca = New System.Windows.Forms.Button()
            Me.txtIdMarca = New System.Windows.Forms.TextBox()
            Me.txtDetalleMarca = New System.Windows.Forms.TextBox()
            Me.btnVolver = New System.Windows.Forms.Button()
            Me.gbMateriales = New System.Windows.Forms.GroupBox()
            Me.btnGuardarMaterial = New System.Windows.Forms.Button()
            Me.txtIdMaterial = New System.Windows.Forms.TextBox()
            Me.btnNuevoMaterial = New System.Windows.Forms.Button()
            Me.txtDetalleMaterial = New System.Windows.Forms.TextBox()
            Me.gbColores = New System.Windows.Forms.GroupBox()
            Me.btnGuardarColor = New System.Windows.Forms.Button()
            Me.btnNuevoColor = New System.Windows.Forms.Button()
            Me.txtIdColor = New System.Windows.Forms.TextBox()
            Me.txtDetalleColor = New System.Windows.Forms.TextBox()
            ID_CATEGORIALabel = New System.Windows.Forms.Label()
            NOMBRE_CATEGORIALabel = New System.Windows.Forms.Label()
            ID_SUB_GRUPOLabel = New System.Windows.Forms.Label()
            NOMBRE_SUB_GRUPOLabel = New System.Windows.Forms.Label()
            ID_GRUPOLabel = New System.Windows.Forms.Label()
            NOMBRE_GRUPOLabel = New System.Windows.Forms.Label()
            CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvColores, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbMarcas.SuspendLayout()
            Me.gbMateriales.SuspendLayout()
            Me.gbColores.SuspendLayout()
            Me.SuspendLayout()
            '
            'ID_CATEGORIALabel
            '
            ID_CATEGORIALabel.AutoSize = True
            ID_CATEGORIALabel.Location = New System.Drawing.Point(6, 37)
            ID_CATEGORIALabel.Name = "ID_CATEGORIALabel"
            ID_CATEGORIALabel.Size = New System.Drawing.Size(20, 13)
            ID_CATEGORIALabel.TabIndex = 17
            ID_CATEGORIALabel.Text = "ID:"
            '
            'NOMBRE_CATEGORIALabel
            '
            NOMBRE_CATEGORIALabel.AutoSize = True
            NOMBRE_CATEGORIALabel.Location = New System.Drawing.Point(6, 73)
            NOMBRE_CATEGORIALabel.Name = "NOMBRE_CATEGORIALabel"
            NOMBRE_CATEGORIALabel.Size = New System.Drawing.Size(55, 13)
            NOMBRE_CATEGORIALabel.TabIndex = 21
            NOMBRE_CATEGORIALabel.Text = "DETALLE:"
            '
            'ID_SUB_GRUPOLabel
            '
            ID_SUB_GRUPOLabel.AutoSize = True
            ID_SUB_GRUPOLabel.Location = New System.Drawing.Point(23, 35)
            ID_SUB_GRUPOLabel.Name = "ID_SUB_GRUPOLabel"
            ID_SUB_GRUPOLabel.Size = New System.Drawing.Size(20, 13)
            ID_SUB_GRUPOLabel.TabIndex = 0
            ID_SUB_GRUPOLabel.Text = "ID:"
            '
            'NOMBRE_SUB_GRUPOLabel
            '
            NOMBRE_SUB_GRUPOLabel.AutoSize = True
            NOMBRE_SUB_GRUPOLabel.Location = New System.Drawing.Point(23, 70)
            NOMBRE_SUB_GRUPOLabel.Name = "NOMBRE_SUB_GRUPOLabel"
            NOMBRE_SUB_GRUPOLabel.Size = New System.Drawing.Size(55, 13)
            NOMBRE_SUB_GRUPOLabel.TabIndex = 4
            NOMBRE_SUB_GRUPOLabel.Text = "DETALLE:"
            '
            'ID_GRUPOLabel
            '
            ID_GRUPOLabel.AutoSize = True
            ID_GRUPOLabel.Location = New System.Drawing.Point(9, 41)
            ID_GRUPOLabel.Name = "ID_GRUPOLabel"
            ID_GRUPOLabel.Size = New System.Drawing.Size(20, 13)
            ID_GRUPOLabel.TabIndex = 13
            ID_GRUPOLabel.Text = "ID:"
            '
            'NOMBRE_GRUPOLabel
            '
            NOMBRE_GRUPOLabel.AutoSize = True
            NOMBRE_GRUPOLabel.Location = New System.Drawing.Point(9, 80)
            NOMBRE_GRUPOLabel.Name = "NOMBRE_GRUPOLabel"
            NOMBRE_GRUPOLabel.Size = New System.Drawing.Size(55, 13)
            NOMBRE_GRUPOLabel.TabIndex = 17
            NOMBRE_GRUPOLabel.Text = "DETALLE:"
            '
            'dgvMarcas
            '
            Me.dgvMarcas.AllowUserToAddRows = False
            Me.dgvMarcas.AllowUserToDeleteRows = False
            Me.dgvMarcas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMarcas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMarcas.BackgroundColor = System.Drawing.Color.White
            Me.dgvMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMarcas.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvMarcas.Location = New System.Drawing.Point(403, 2)
            Me.dgvMarcas.MultiSelect = False
            Me.dgvMarcas.Name = "dgvMarcas"
            Me.dgvMarcas.ReadOnly = True
            Me.dgvMarcas.RowHeadersVisible = False
            Me.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMarcas.Size = New System.Drawing.Size(359, 108)
            Me.dgvMarcas.TabIndex = 19
            '
            'dgvMateriales
            '
            Me.dgvMateriales.AllowUserToAddRows = False
            Me.dgvMateriales.AllowUserToDeleteRows = False
            Me.dgvMateriales.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvMateriales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvMateriales.BackgroundColor = System.Drawing.Color.White
            Me.dgvMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMateriales.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvMateriales.Location = New System.Drawing.Point(403, 235)
            Me.dgvMateriales.MultiSelect = False
            Me.dgvMateriales.Name = "dgvMateriales"
            Me.dgvMateriales.ReadOnly = True
            Me.dgvMateriales.RowHeadersVisible = False
            Me.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvMateriales.Size = New System.Drawing.Size(359, 126)
            Me.dgvMateriales.TabIndex = 18
            '
            'dgvColores
            '
            Me.dgvColores.AllowUserToAddRows = False
            Me.dgvColores.AllowUserToDeleteRows = False
            Me.dgvColores.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvColores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvColores.BackgroundColor = System.Drawing.Color.White
            Me.dgvColores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvColores.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvColores.Location = New System.Drawing.Point(403, 116)
            Me.dgvColores.MultiSelect = False
            Me.dgvColores.Name = "dgvColores"
            Me.dgvColores.ReadOnly = True
            Me.dgvColores.RowHeadersVisible = False
            Me.dgvColores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvColores.Size = New System.Drawing.Size(359, 113)
            Me.dgvColores.TabIndex = 17
            '
            'gbMarcas
            '
            Me.gbMarcas.Controls.Add(Me.btnGuardarMarca)
            Me.gbMarcas.Controls.Add(Me.btnNuevoMarca)
            Me.gbMarcas.Controls.Add(ID_CATEGORIALabel)
            Me.gbMarcas.Controls.Add(Me.txtIdMarca)
            Me.gbMarcas.Controls.Add(Me.txtDetalleMarca)
            Me.gbMarcas.Controls.Add(NOMBRE_CATEGORIALabel)
            Me.gbMarcas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbMarcas.Location = New System.Drawing.Point(2, 2)
            Me.gbMarcas.Name = "gbMarcas"
            Me.gbMarcas.Size = New System.Drawing.Size(395, 108)
            Me.gbMarcas.TabIndex = 14
            Me.gbMarcas.TabStop = False
            Me.gbMarcas.Text = "MARCAS"
            '
            'btnGuardarMarca
            '
            Me.btnGuardarMarca.BackColor = System.Drawing.Color.White
            Me.btnGuardarMarca.Enabled = False
            Me.btnGuardarMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarMarca.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnGuardarMarca.Location = New System.Drawing.Point(275, 22)
            Me.btnGuardarMarca.Name = "btnGuardarMarca"
            Me.btnGuardarMarca.Size = New System.Drawing.Size(47, 38)
            Me.btnGuardarMarca.TabIndex = 75
            Me.btnGuardarMarca.UseVisualStyleBackColor = False
            '
            'btnNuevoMarca
            '
            Me.btnNuevoMarca.BackColor = System.Drawing.Color.White
            Me.btnNuevoMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnNuevoMarca.FlatAppearance.BorderSize = 0
            Me.btnNuevoMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoMarca.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnNuevoMarca.Location = New System.Drawing.Point(220, 22)
            Me.btnNuevoMarca.Name = "btnNuevoMarca"
            Me.btnNuevoMarca.Size = New System.Drawing.Size(45, 38)
            Me.btnNuevoMarca.TabIndex = 74
            Me.btnNuevoMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoMarca.UseVisualStyleBackColor = False
            '
            'txtIdMarca
            '
            Me.txtIdMarca.BackColor = System.Drawing.Color.White
            Me.txtIdMarca.Enabled = False
            Me.txtIdMarca.Location = New System.Drawing.Point(70, 37)
            Me.txtIdMarca.Name = "txtIdMarca"
            Me.txtIdMarca.Size = New System.Drawing.Size(63, 21)
            Me.txtIdMarca.TabIndex = 3
            '
            'txtDetalleMarca
            '
            Me.txtDetalleMarca.Enabled = False
            Me.txtDetalleMarca.Location = New System.Drawing.Point(70, 66)
            Me.txtDetalleMarca.Name = "txtDetalleMarca"
            Me.txtDetalleMarca.Size = New System.Drawing.Size(306, 21)
            Me.txtDetalleMarca.TabIndex = 7
            '
            'btnVolver
            '
            Me.btnVolver.BackColor = System.Drawing.Color.White
            Me.btnVolver.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVolver.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__1_
            Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVolver.Location = New System.Drawing.Point(225, 330)
            Me.btnVolver.Name = "btnVolver"
            Me.btnVolver.Size = New System.Drawing.Size(114, 32)
            Me.btnVolver.TabIndex = 76
            Me.btnVolver.Text = "Aceptar"
            Me.btnVolver.UseVisualStyleBackColor = False
            '
            'gbMateriales
            '
            Me.gbMateriales.Controls.Add(Me.btnGuardarMaterial)
            Me.gbMateriales.Controls.Add(ID_SUB_GRUPOLabel)
            Me.gbMateriales.Controls.Add(Me.txtIdMaterial)
            Me.gbMateriales.Controls.Add(Me.btnNuevoMaterial)
            Me.gbMateriales.Controls.Add(NOMBRE_SUB_GRUPOLabel)
            Me.gbMateriales.Controls.Add(Me.txtDetalleMaterial)
            Me.gbMateriales.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbMateriales.Location = New System.Drawing.Point(1, 235)
            Me.gbMateriales.Name = "gbMateriales"
            Me.gbMateriales.Size = New System.Drawing.Size(396, 93)
            Me.gbMateriales.TabIndex = 16
            Me.gbMateriales.TabStop = False
            Me.gbMateriales.Text = "MATERIALES"
            '
            'btnGuardarMaterial
            '
            Me.btnGuardarMaterial.BackColor = System.Drawing.Color.White
            Me.btnGuardarMaterial.Enabled = False
            Me.btnGuardarMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarMaterial.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnGuardarMaterial.Location = New System.Drawing.Point(276, 19)
            Me.btnGuardarMaterial.Name = "btnGuardarMaterial"
            Me.btnGuardarMaterial.Size = New System.Drawing.Size(47, 38)
            Me.btnGuardarMaterial.TabIndex = 76
            Me.btnGuardarMaterial.TabStop = False
            Me.btnGuardarMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarMaterial.UseVisualStyleBackColor = False
            '
            'txtIdMaterial
            '
            Me.txtIdMaterial.BackColor = System.Drawing.Color.White
            Me.txtIdMaterial.Enabled = False
            Me.txtIdMaterial.Location = New System.Drawing.Point(87, 28)
            Me.txtIdMaterial.Name = "txtIdMaterial"
            Me.txtIdMaterial.Size = New System.Drawing.Size(60, 21)
            Me.txtIdMaterial.TabIndex = 0
            Me.txtIdMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnNuevoMaterial
            '
            Me.btnNuevoMaterial.BackColor = System.Drawing.Color.White
            Me.btnNuevoMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoMaterial.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnNuevoMaterial.Location = New System.Drawing.Point(221, 19)
            Me.btnNuevoMaterial.Name = "btnNuevoMaterial"
            Me.btnNuevoMaterial.Size = New System.Drawing.Size(45, 38)
            Me.btnNuevoMaterial.TabIndex = 75
            Me.btnNuevoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoMaterial.UseVisualStyleBackColor = False
            '
            'txtDetalleMaterial
            '
            Me.txtDetalleMaterial.Enabled = False
            Me.txtDetalleMaterial.Location = New System.Drawing.Point(87, 63)
            Me.txtDetalleMaterial.Name = "txtDetalleMaterial"
            Me.txtDetalleMaterial.Size = New System.Drawing.Size(280, 21)
            Me.txtDetalleMaterial.TabIndex = 2
            '
            'gbColores
            '
            Me.gbColores.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
            Me.gbColores.Controls.Add(Me.btnGuardarColor)
            Me.gbColores.Controls.Add(Me.btnNuevoColor)
            Me.gbColores.Controls.Add(ID_GRUPOLabel)
            Me.gbColores.Controls.Add(Me.txtIdColor)
            Me.gbColores.Controls.Add(NOMBRE_GRUPOLabel)
            Me.gbColores.Controls.Add(Me.txtDetalleColor)
            Me.gbColores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbColores.Location = New System.Drawing.Point(2, 116)
            Me.gbColores.Name = "gbColores"
            Me.gbColores.Size = New System.Drawing.Size(395, 113)
            Me.gbColores.TabIndex = 15
            Me.gbColores.TabStop = False
            Me.gbColores.Text = "COLORES"
            '
            'btnGuardarColor
            '
            Me.btnGuardarColor.BackColor = System.Drawing.Color.White
            Me.btnGuardarColor.Enabled = False
            Me.btnGuardarColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarColor.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnGuardarColor.Location = New System.Drawing.Point(275, 31)
            Me.btnGuardarColor.Name = "btnGuardarColor"
            Me.btnGuardarColor.Size = New System.Drawing.Size(47, 36)
            Me.btnGuardarColor.TabIndex = 73
            Me.btnGuardarColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarColor.UseVisualStyleBackColor = False
            '
            'btnNuevoColor
            '
            Me.btnNuevoColor.BackColor = System.Drawing.Color.White
            Me.btnNuevoColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoColor.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnNuevoColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevoColor.Location = New System.Drawing.Point(223, 31)
            Me.btnNuevoColor.Name = "btnNuevoColor"
            Me.btnNuevoColor.Size = New System.Drawing.Size(42, 36)
            Me.btnNuevoColor.TabIndex = 71
            Me.btnNuevoColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoColor.UseVisualStyleBackColor = False
            '
            'txtIdColor
            '
            Me.txtIdColor.BackColor = System.Drawing.Color.White
            Me.txtIdColor.Enabled = False
            Me.txtIdColor.Location = New System.Drawing.Point(73, 34)
            Me.txtIdColor.Name = "txtIdColor"
            Me.txtIdColor.Size = New System.Drawing.Size(60, 21)
            Me.txtIdColor.TabIndex = 4
            Me.txtIdColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtDetalleColor
            '
            Me.txtDetalleColor.Enabled = False
            Me.txtDetalleColor.Location = New System.Drawing.Point(73, 73)
            Me.txtDetalleColor.Name = "txtDetalleColor"
            Me.txtDetalleColor.Size = New System.Drawing.Size(306, 21)
            Me.txtDetalleColor.TabIndex = 9
            '
            'FormMantenimientoMarcasMaterialesColores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(762, 365)
            Me.Controls.Add(Me.btnVolver)
            Me.Controls.Add(Me.dgvMarcas)
            Me.Controls.Add(Me.dgvMateriales)
            Me.Controls.Add(Me.dgvColores)
            Me.Controls.Add(Me.gbMarcas)
            Me.Controls.Add(Me.gbMateriales)
            Me.Controls.Add(Me.gbColores)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormMantenimientoMarcasMaterialesColores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTO DE TABLAS DE PARÁMETROS DE ACTIVOS FIJOS"
            CType(Me.dgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMateriales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvColores, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbMarcas.ResumeLayout(False)
            Me.gbMarcas.PerformLayout()
            Me.gbMateriales.ResumeLayout(False)
            Me.gbMateriales.PerformLayout()
            Me.gbColores.ResumeLayout(False)
            Me.gbColores.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvMarcas As System.Windows.Forms.DataGridView
        Friend WithEvents dgvMateriales As System.Windows.Forms.DataGridView
        Friend WithEvents dgvColores As System.Windows.Forms.DataGridView
        Friend WithEvents gbMarcas As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardarMarca As System.Windows.Forms.Button
        Friend WithEvents btnNuevoMarca As System.Windows.Forms.Button
        Friend WithEvents txtIdMarca As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleMarca As System.Windows.Forms.TextBox
        Friend WithEvents gbMateriales As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardarMaterial As System.Windows.Forms.Button
        Friend WithEvents txtIdMaterial As System.Windows.Forms.TextBox
        Friend WithEvents btnNuevoMaterial As System.Windows.Forms.Button
        Friend WithEvents txtDetalleMaterial As System.Windows.Forms.TextBox
        Friend WithEvents gbColores As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardarColor As System.Windows.Forms.Button
        Friend WithEvents btnNuevoColor As System.Windows.Forms.Button
        Friend WithEvents txtIdColor As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalleColor As System.Windows.Forms.TextBox
        Friend WithEvents btnVolver As System.Windows.Forms.Button
    End Class
End Namespace