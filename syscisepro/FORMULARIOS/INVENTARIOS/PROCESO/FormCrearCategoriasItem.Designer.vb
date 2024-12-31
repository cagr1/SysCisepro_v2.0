Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormCrearCategoriasItem
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCrearCategoriasItem))
            Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
            Me.btnCancelarCategoría = New System.Windows.Forms.Button()
            Me.btnGuardarCategoría = New System.Windows.Forms.Button()
            Me.btnNuevaCategoría = New System.Windows.Forms.Button()
            Me.btnCancelarGrupo = New System.Windows.Forms.Button()
            Me.btnGuardarGrupo = New System.Windows.Forms.Button()
            Me.btnNuevoGrupo = New System.Windows.Forms.Button()
            Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
            Me.cbmCategoría = New System.Windows.Forms.ComboBox()
            Me.lblIdCategoría = New System.Windows.Forms.Label()
            Me.btnCancelarSubGrupo = New System.Windows.Forms.Button()
            Me.btnGuardarSubGrupo = New System.Windows.Forms.Button()
            Me.btnNuevoSubGrupo = New System.Windows.Forms.Button()
            Me.dgvPrevio = New System.Windows.Forms.DataGridView()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.tcItems = New ReaLTaiizor.Controls.MetroTabControl()
            Me.MetroTabPage1 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.MetroTabPage2 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.MetroTabPage3 = New ReaLTaiizor.Child.Metro.MetroTabPage()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.lblIdGrupo = New System.Windows.Forms.Label()
            Me.txtNombreSubGrupo = New System.Windows.Forms.TextBox()
            Me.cbmGrupo = New System.Windows.Forms.ComboBox()
            CType(Me.dgvPrevio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcItems.SuspendLayout()
            Me.MetroTabPage1.SuspendLayout()
            Me.MetroTabPage2.SuspendLayout()
            Me.MetroTabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNombreCategoria
            '
            Me.txtNombreCategoria.Enabled = False
            Me.txtNombreCategoria.Location = New System.Drawing.Point(72, 46)
            Me.txtNombreCategoria.Multiline = True
            Me.txtNombreCategoria.Name = "txtNombreCategoria"
            Me.txtNombreCategoria.Size = New System.Drawing.Size(241, 37)
            Me.txtNombreCategoria.TabIndex = 149
            '
            'btnCancelarCategoría
            '
            Me.btnCancelarCategoría.BackColor = System.Drawing.Color.Transparent
            Me.btnCancelarCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarCategoría.Enabled = False
            Me.btnCancelarCategoría.FlatAppearance.BorderSize = 0
            Me.btnCancelarCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelarCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarCategoría.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarCategoría.Location = New System.Drawing.Point(98, 3)
            Me.btnCancelarCategoría.Name = "btnCancelarCategoría"
            Me.btnCancelarCategoría.Size = New System.Drawing.Size(28, 28)
            Me.btnCancelarCategoría.TabIndex = 145
            Me.btnCancelarCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarCategoría.UseVisualStyleBackColor = False
            '
            'btnGuardarCategoría
            '
            Me.btnGuardarCategoría.BackColor = System.Drawing.Color.Transparent
            Me.btnGuardarCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarCategoría.Enabled = False
            Me.btnGuardarCategoría.FlatAppearance.BorderSize = 0
            Me.btnGuardarCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardarCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarCategoría.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarCategoría.Location = New System.Drawing.Point(58, 3)
            Me.btnGuardarCategoría.Name = "btnGuardarCategoría"
            Me.btnGuardarCategoría.Size = New System.Drawing.Size(28, 28)
            Me.btnGuardarCategoría.TabIndex = 144
            Me.btnGuardarCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarCategoría.UseVisualStyleBackColor = False
            '
            'btnNuevaCategoría
            '
            Me.btnNuevaCategoría.BackColor = System.Drawing.Color.Transparent
            Me.btnNuevaCategoría.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevaCategoría.FlatAppearance.BorderSize = 0
            Me.btnNuevaCategoría.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevaCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNuevaCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevaCategoría.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevaCategoría.Location = New System.Drawing.Point(15, 3)
            Me.btnNuevaCategoría.Name = "btnNuevaCategoría"
            Me.btnNuevaCategoría.Size = New System.Drawing.Size(28, 28)
            Me.btnNuevaCategoría.TabIndex = 143
            Me.btnNuevaCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevaCategoría.UseVisualStyleBackColor = False
            '
            'btnCancelarGrupo
            '
            Me.btnCancelarGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnCancelarGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarGrupo.Enabled = False
            Me.btnCancelarGrupo.FlatAppearance.BorderSize = 0
            Me.btnCancelarGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelarGrupo.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarGrupo.Location = New System.Drawing.Point(104, 3)
            Me.btnCancelarGrupo.Name = "btnCancelarGrupo"
            Me.btnCancelarGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnCancelarGrupo.TabIndex = 157
            Me.btnCancelarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarGrupo.UseVisualStyleBackColor = False
            '
            'btnGuardarGrupo
            '
            Me.btnGuardarGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnGuardarGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarGrupo.Enabled = False
            Me.btnGuardarGrupo.FlatAppearance.BorderSize = 0
            Me.btnGuardarGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardarGrupo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarGrupo.Location = New System.Drawing.Point(61, 3)
            Me.btnGuardarGrupo.Name = "btnGuardarGrupo"
            Me.btnGuardarGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnGuardarGrupo.TabIndex = 156
            Me.btnGuardarGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarGrupo.UseVisualStyleBackColor = False
            '
            'btnNuevoGrupo
            '
            Me.btnNuevoGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnNuevoGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevoGrupo.FlatAppearance.BorderSize = 0
            Me.btnNuevoGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNuevoGrupo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoGrupo.Location = New System.Drawing.Point(15, 3)
            Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
            Me.btnNuevoGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnNuevoGrupo.TabIndex = 155
            Me.btnNuevoGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevoGrupo.UseVisualStyleBackColor = False
            '
            'txtNombreGrupo
            '
            Me.txtNombreGrupo.Enabled = False
            Me.txtNombreGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreGrupo.Location = New System.Drawing.Point(82, 71)
            Me.txtNombreGrupo.Multiline = True
            Me.txtNombreGrupo.Name = "txtNombreGrupo"
            Me.txtNombreGrupo.Size = New System.Drawing.Size(241, 37)
            Me.txtNombreGrupo.TabIndex = 151
            '
            'cbmCategoría
            '
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(82, 38)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(169, 21)
            Me.cbmCategoría.TabIndex = 101
            '
            'lblIdCategoría
            '
            Me.lblIdCategoría.AutoSize = True
            Me.lblIdCategoría.BackColor = System.Drawing.Color.White
            Me.lblIdCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCategoría.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdCategoría.Location = New System.Drawing.Point(193, 41)
            Me.lblIdCategoría.Name = "lblIdCategoría"
            Me.lblIdCategoría.Size = New System.Drawing.Size(31, 13)
            Me.lblIdCategoría.TabIndex = 102
            Me.lblIdCategoría.Text = "0000"
            Me.lblIdCategoría.Visible = False
            '
            'btnCancelarSubGrupo
            '
            Me.btnCancelarSubGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnCancelarSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnCancelarSubGrupo.Enabled = False
            Me.btnCancelarSubGrupo.FlatAppearance.BorderSize = 0
            Me.btnCancelarSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnCancelarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelarSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSubGrupo.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarSubGrupo.Location = New System.Drawing.Point(104, 3)
            Me.btnCancelarSubGrupo.Name = "btnCancelarSubGrupo"
            Me.btnCancelarSubGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnCancelarSubGrupo.TabIndex = 165
            Me.btnCancelarSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancelarSubGrupo.UseVisualStyleBackColor = False
            '
            'btnGuardarSubGrupo
            '
            Me.btnGuardarSubGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnGuardarSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnGuardarSubGrupo.Enabled = False
            Me.btnGuardarSubGrupo.FlatAppearance.BorderSize = 0
            Me.btnGuardarSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnGuardarSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardarSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSubGrupo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSubGrupo.Location = New System.Drawing.Point(63, 3)
            Me.btnGuardarSubGrupo.Name = "btnGuardarSubGrupo"
            Me.btnGuardarSubGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnGuardarSubGrupo.TabIndex = 164
            Me.btnGuardarSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGuardarSubGrupo.UseVisualStyleBackColor = False
            '
            'btnNuevoSubGrupo
            '
            Me.btnNuevoSubGrupo.BackColor = System.Drawing.Color.Transparent
            Me.btnNuevoSubGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.btnNuevoSubGrupo.FlatAppearance.BorderSize = 0
            Me.btnNuevoSubGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
            Me.btnNuevoSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNuevoSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSubGrupo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoSubGrupo.Location = New System.Drawing.Point(20, 3)
            Me.btnNuevoSubGrupo.Name = "btnNuevoSubGrupo"
            Me.btnNuevoSubGrupo.Size = New System.Drawing.Size(28, 28)
            Me.btnNuevoSubGrupo.TabIndex = 163
            Me.btnNuevoSubGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNuevoSubGrupo.UseVisualStyleBackColor = False
            '
            'dgvPrevio
            '
            Me.dgvPrevio.AllowUserToAddRows = False
            Me.dgvPrevio.AllowUserToDeleteRows = False
            Me.dgvPrevio.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPrevio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPrevio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvPrevio.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPrevio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
            Me.dgvPrevio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPrevio.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPrevio.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvPrevio.Location = New System.Drawing.Point(16, 183)
            Me.dgvPrevio.MultiSelect = False
            Me.dgvPrevio.Name = "dgvPrevio"
            Me.dgvPrevio.ReadOnly = True
            Me.dgvPrevio.RowHeadersVisible = False
            Me.dgvPrevio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPrevio.Size = New System.Drawing.Size(356, 129)
            Me.dgvPrevio.TabIndex = 208
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(10, 47)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel2.TabIndex = 167
            Me.KryptonLabel2.Values.Text = "Nombre"
            '
            'tcItems
            '
            Me.tcItems.AnimateEasingType = ReaLTaiizor.[Enum].Metro.EasingType.CubeOut
            Me.tcItems.AnimateTime = 200
            Me.tcItems.BackgroundColor = System.Drawing.Color.White
            Me.tcItems.Controls.Add(Me.MetroTabPage1)
            Me.tcItems.Controls.Add(Me.MetroTabPage2)
            Me.tcItems.Controls.Add(Me.MetroTabPage3)
            Me.tcItems.ControlsVisible = True
            Me.tcItems.IsDerivedStyle = True
            Me.tcItems.ItemSize = New System.Drawing.Size(100, 38)
            Me.tcItems.Location = New System.Drawing.Point(3, 12)
            Me.tcItems.MCursor = System.Windows.Forms.Cursors.Hand
            Me.tcItems.Name = "tcItems"
            Me.tcItems.SelectedIndex = 0
            Me.tcItems.SelectedTextColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.tcItems.Size = New System.Drawing.Size(373, 165)
            Me.tcItems.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.tcItems.Speed = 100
            Me.tcItems.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.tcItems.StyleManager = Nothing
            Me.tcItems.TabIndex = 210
            Me.tcItems.TabStyle = ReaLTaiizor.[Enum].Metro.TabStyle.Style2
            Me.tcItems.ThemeAuthor = "Taiizor"
            Me.tcItems.ThemeName = "MetroLight"
            Me.tcItems.UnselectedTextColor = System.Drawing.Color.Gray
            '
            'MetroTabPage1
            '
            Me.MetroTabPage1.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage1.Controls.Add(Me.txtNombreCategoria)
            Me.MetroTabPage1.Controls.Add(Me.btnNuevaCategoría)
            Me.MetroTabPage1.Controls.Add(Me.KryptonLabel2)
            Me.MetroTabPage1.Controls.Add(Me.btnGuardarCategoría)
            Me.MetroTabPage1.Controls.Add(Me.btnCancelarCategoría)
            Me.MetroTabPage1.Font = Nothing
            Me.MetroTabPage1.ImageIndex = 0
            Me.MetroTabPage1.ImageKey = Nothing
            Me.MetroTabPage1.IsDerivedStyle = True
            Me.MetroTabPage1.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage1.Name = "MetroTabPage1"
            Me.MetroTabPage1.Size = New System.Drawing.Size(365, 119)
            Me.MetroTabPage1.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage1.StyleManager = Nothing
            Me.MetroTabPage1.TabIndex = 0
            Me.MetroTabPage1.Text = "Categoria"
            Me.MetroTabPage1.ThemeAuthor = "Taiizor"
            Me.MetroTabPage1.ThemeName = "MetroLight"
            Me.MetroTabPage1.ToolTipText = Nothing
            '
            'MetroTabPage2
            '
            Me.MetroTabPage2.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage2.Controls.Add(Me.txtNombreGrupo)
            Me.MetroTabPage2.Controls.Add(Me.KryptonLabel4)
            Me.MetroTabPage2.Controls.Add(Me.KryptonLabel5)
            Me.MetroTabPage2.Controls.Add(Me.cbmCategoría)
            Me.MetroTabPage2.Controls.Add(Me.btnCancelarGrupo)
            Me.MetroTabPage2.Controls.Add(Me.btnNuevoGrupo)
            Me.MetroTabPage2.Controls.Add(Me.btnGuardarGrupo)
            Me.MetroTabPage2.Controls.Add(Me.lblIdCategoría)
            Me.MetroTabPage2.Font = Nothing
            Me.MetroTabPage2.ImageIndex = 0
            Me.MetroTabPage2.ImageKey = Nothing
            Me.MetroTabPage2.IsDerivedStyle = True
            Me.MetroTabPage2.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage2.Name = "MetroTabPage2"
            Me.MetroTabPage2.Size = New System.Drawing.Size(365, 119)
            Me.MetroTabPage2.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage2.StyleManager = Nothing
            Me.MetroTabPage2.TabIndex = 1
            Me.MetroTabPage2.Text = "Grupo"
            Me.MetroTabPage2.ThemeAuthor = "Taiizor"
            Me.MetroTabPage2.ThemeName = "MetroLight"
            Me.MetroTabPage2.ToolTipText = Nothing
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(15, 71)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel4.TabIndex = 172
            Me.KryptonLabel4.Values.Text = "Nombre"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(15, 39)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel5.TabIndex = 171
            Me.KryptonLabel5.Values.Text = "Grupo"
            '
            'MetroTabPage3
            '
            Me.MetroTabPage3.BaseColor = System.Drawing.Color.White
            Me.MetroTabPage3.Controls.Add(Me.KryptonLabel3)
            Me.MetroTabPage3.Controls.Add(Me.KryptonLabel1)
            Me.MetroTabPage3.Controls.Add(Me.txtNombreSubGrupo)
            Me.MetroTabPage3.Controls.Add(Me.cbmGrupo)
            Me.MetroTabPage3.Controls.Add(Me.btnNuevoSubGrupo)
            Me.MetroTabPage3.Controls.Add(Me.btnCancelarSubGrupo)
            Me.MetroTabPage3.Controls.Add(Me.btnGuardarSubGrupo)
            Me.MetroTabPage3.Controls.Add(Me.lblIdGrupo)
            Me.MetroTabPage3.Font = Nothing
            Me.MetroTabPage3.ImageIndex = 0
            Me.MetroTabPage3.ImageKey = Nothing
            Me.MetroTabPage3.IsDerivedStyle = True
            Me.MetroTabPage3.Location = New System.Drawing.Point(4, 42)
            Me.MetroTabPage3.Name = "MetroTabPage3"
            Me.MetroTabPage3.Size = New System.Drawing.Size(365, 119)
            Me.MetroTabPage3.Style = ReaLTaiizor.[Enum].Metro.Style.Light
            Me.MetroTabPage3.StyleManager = Nothing
            Me.MetroTabPage3.TabIndex = 2
            Me.MetroTabPage3.Text = "Sub Grupo"
            Me.MetroTabPage3.ThemeAuthor = "Taiizor"
            Me.MetroTabPage3.ThemeName = "MetroLight"
            Me.MetroTabPage3.ToolTipText = Nothing
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(13, 67)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel3.TabIndex = 170
            Me.KryptonLabel3.Values.Text = "Nombre"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(14, 41)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel1.TabIndex = 169
            Me.KryptonLabel1.Values.Text = "Grupo"
            '
            'lblIdGrupo
            '
            Me.lblIdGrupo.AutoSize = True
            Me.lblIdGrupo.BackColor = System.Drawing.Color.White
            Me.lblIdGrupo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdGrupo.Location = New System.Drawing.Point(178, 44)
            Me.lblIdGrupo.Name = "lblIdGrupo"
            Me.lblIdGrupo.Size = New System.Drawing.Size(31, 13)
            Me.lblIdGrupo.TabIndex = 168
            Me.lblIdGrupo.Text = "0000"
            Me.lblIdGrupo.Visible = False
            '
            'txtNombreSubGrupo
            '
            Me.txtNombreSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreSubGrupo.Enabled = False
            Me.txtNombreSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSubGrupo.Location = New System.Drawing.Point(78, 67)
            Me.txtNombreSubGrupo.Multiline = True
            Me.txtNombreSubGrupo.Name = "txtNombreSubGrupo"
            Me.txtNombreSubGrupo.Size = New System.Drawing.Size(241, 37)
            Me.txtNombreSubGrupo.TabIndex = 167
            '
            'cbmGrupo
            '
            Me.cbmGrupo.BackColor = System.Drawing.Color.White
            Me.cbmGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo.Enabled = False
            Me.cbmGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(78, 41)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(169, 21)
            Me.cbmGrupo.TabIndex = 166
            '
            'FormCrearCategoriasItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(384, 322)
            Me.Controls.Add(Me.tcItems)
            Me.Controls.Add(Me.dgvPrevio)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormCrearCategoriasItem"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.Text = "MANTENIMIENTOS DE CATEGORÍAS DE ITEMS"
            CType(Me.dgvPrevio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcItems.ResumeLayout(False)
            Me.MetroTabPage1.ResumeLayout(False)
            Me.MetroTabPage1.PerformLayout()
            Me.MetroTabPage2.ResumeLayout(False)
            Me.MetroTabPage2.PerformLayout()
            Me.MetroTabPage3.ResumeLayout(False)
            Me.MetroTabPage3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
        Friend WithEvents lblIdCategoría As System.Windows.Forms.Label
        Friend WithEvents cbmCategoría As System.Windows.Forms.ComboBox
        Friend WithEvents txtNombreCategoria As System.Windows.Forms.TextBox
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
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents tcItems As ReaLTaiizor.Controls.MetroTabControl
        Friend WithEvents MetroTabPage1 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents MetroTabPage2 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents MetroTabPage3 As ReaLTaiizor.Child.Metro.MetroTabPage
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents lblIdGrupo As Label
        Friend WithEvents txtNombreSubGrupo As TextBox
        Friend WithEvents cbmGrupo As ComboBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace