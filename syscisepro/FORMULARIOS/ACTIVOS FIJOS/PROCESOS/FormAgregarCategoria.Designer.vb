Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAgregarCategoria
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
            Dim ID_GRUPOLabel As System.Windows.Forms.Label
            Dim CODIGOLabel As System.Windows.Forms.Label
            Dim NOMBRE_GRUPOLabel As System.Windows.Forms.Label
            Dim ID_CATEGORIA_GRUPOLabel As System.Windows.Forms.Label
            Dim ID_SUB_GRUPOLabel As System.Windows.Forms.Label
            Dim CODIGOLabel1 As System.Windows.Forms.Label
            Dim NOMBRE_SUB_GRUPOLabel As System.Windows.Forms.Label
            Dim ID_GRUPO_SUB_GRUPOLabel As System.Windows.Forms.Label
            Dim ID_CATEGORIALabel As System.Windows.Forms.Label
            Dim CODIGOLabel2 As System.Windows.Forms.Label
            Dim NOMBRE_CATEGORIALabel As System.Windows.Forms.Label
            Dim Label1 As System.Windows.Forms.Label
            Dim Label2 As System.Windows.Forms.Label
            Dim Label3 As System.Windows.Forms.Label
            Dim Label4 As System.Windows.Forms.Label
            Dim Label5 As System.Windows.Forms.Label
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
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarCategoria))
            Me.gbGrupo = New System.Windows.Forms.GroupBox()
            Me.btnGuardarGrupo = New System.Windows.Forms.Button()
            Me.btnNuevoGrupo = New System.Windows.Forms.Button()
            Me.cbmCategoriaGrupo = New System.Windows.Forms.ComboBox()
            Me.txtIdGrupo = New System.Windows.Forms.TextBox()
            Me.txtCodigoGrupo = New System.Windows.Forms.TextBox()
            Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
            Me.gbSubGrupo = New System.Windows.Forms.GroupBox()
            Me.btnGuardarSubGrupo = New System.Windows.Forms.Button()
            Me.cbmSubGrupo = New System.Windows.Forms.ComboBox()
            Me.txtIdSubGrupo = New System.Windows.Forms.TextBox()
            Me.txtCodigoSubGrupo = New System.Windows.Forms.TextBox()
            Me.btnNuevoSubGrupo = New System.Windows.Forms.Button()
            Me.txtNombreSubGrupo = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnGuardarCategoria = New System.Windows.Forms.Button()
            Me.btnNuevoCategoria = New System.Windows.Forms.Button()
            Me.txtIdCategoria = New System.Windows.Forms.TextBox()
            Me.txtCodigoCategoria = New System.Windows.Forms.TextBox()
            Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
            Me.btnVolver = New System.Windows.Forms.Button()
            Me.gbSecuencial = New System.Windows.Forms.GroupBox()
            Me.cbDepreciable = New System.Windows.Forms.ComboBox()
            Me.btnGuardarSecuencial = New System.Windows.Forms.Button()
            Me.cbSubGrupo = New System.Windows.Forms.ComboBox()
            Me.txtIdSecuencial = New System.Windows.Forms.TextBox()
            Me.txtCodigoSecuencial = New System.Windows.Forms.TextBox()
            Me.btnNuevoSecuecial = New System.Windows.Forms.Button()
            Me.txtNombreSecuencial = New System.Windows.Forms.TextBox()
            Me.dgvCategoria = New System.Windows.Forms.DataGridView()
            Me.dgvGrupos = New System.Windows.Forms.DataGridView()
            Me.dgvSubgrupos = New System.Windows.Forms.DataGridView()
            Me.dgvSecuencial = New System.Windows.Forms.DataGridView()
            ID_GRUPOLabel = New System.Windows.Forms.Label()
            CODIGOLabel = New System.Windows.Forms.Label()
            NOMBRE_GRUPOLabel = New System.Windows.Forms.Label()
            ID_CATEGORIA_GRUPOLabel = New System.Windows.Forms.Label()
            ID_SUB_GRUPOLabel = New System.Windows.Forms.Label()
            CODIGOLabel1 = New System.Windows.Forms.Label()
            NOMBRE_SUB_GRUPOLabel = New System.Windows.Forms.Label()
            ID_GRUPO_SUB_GRUPOLabel = New System.Windows.Forms.Label()
            ID_CATEGORIALabel = New System.Windows.Forms.Label()
            CODIGOLabel2 = New System.Windows.Forms.Label()
            NOMBRE_CATEGORIALabel = New System.Windows.Forms.Label()
            Label1 = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            Label3 = New System.Windows.Forms.Label()
            Label4 = New System.Windows.Forms.Label()
            Label5 = New System.Windows.Forms.Label()
            Me.gbGrupo.SuspendLayout()
            Me.gbSubGrupo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbSecuencial.SuspendLayout()
            CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSubgrupos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ID_GRUPOLabel
            '
            ID_GRUPOLabel.AutoSize = True
            ID_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ID_GRUPOLabel.Location = New System.Drawing.Point(19, 27)
            ID_GRUPOLabel.Name = "ID_GRUPOLabel"
            ID_GRUPOLabel.Size = New System.Drawing.Size(55, 13)
            ID_GRUPOLabel.TabIndex = 13
            ID_GRUPOLabel.Text = "ID GRUPO:"
            '
            'CODIGOLabel
            '
            CODIGOLabel.AutoSize = True
            CODIGOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CODIGOLabel.Location = New System.Drawing.Point(19, 53)
            CODIGOLabel.Name = "CODIGOLabel"
            CODIGOLabel.Size = New System.Drawing.Size(47, 13)
            CODIGOLabel.TabIndex = 15
            CODIGOLabel.Text = "CODIGO:"
            '
            'NOMBRE_GRUPOLabel
            '
            NOMBRE_GRUPOLabel.AutoSize = True
            NOMBRE_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NOMBRE_GRUPOLabel.Location = New System.Drawing.Point(19, 79)
            NOMBRE_GRUPOLabel.Name = "NOMBRE_GRUPOLabel"
            NOMBRE_GRUPOLabel.Size = New System.Drawing.Size(86, 13)
            NOMBRE_GRUPOLabel.TabIndex = 17
            NOMBRE_GRUPOLabel.Text = "NOMBRE GRUPO:"
            '
            'ID_CATEGORIA_GRUPOLabel
            '
            ID_CATEGORIA_GRUPOLabel.AutoSize = True
            ID_CATEGORIA_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ID_CATEGORIA_GRUPOLabel.Location = New System.Drawing.Point(19, 105)
            ID_CATEGORIA_GRUPOLabel.Name = "ID_CATEGORIA_GRUPOLabel"
            ID_CATEGORIA_GRUPOLabel.Size = New System.Drawing.Size(62, 13)
            ID_CATEGORIA_GRUPOLabel.TabIndex = 19
            ID_CATEGORIA_GRUPOLabel.Text = "CATEGORIA:"
            '
            'ID_SUB_GRUPOLabel
            '
            ID_SUB_GRUPOLabel.AutoSize = True
            ID_SUB_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ID_SUB_GRUPOLabel.Location = New System.Drawing.Point(16, 25)
            ID_SUB_GRUPOLabel.Name = "ID_SUB_GRUPOLabel"
            ID_SUB_GRUPOLabel.Size = New System.Drawing.Size(75, 13)
            ID_SUB_GRUPOLabel.TabIndex = 0
            ID_SUB_GRUPOLabel.Text = "ID SUB GRUPO:"
            '
            'CODIGOLabel1
            '
            CODIGOLabel1.AutoSize = True
            CODIGOLabel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CODIGOLabel1.Location = New System.Drawing.Point(16, 51)
            CODIGOLabel1.Name = "CODIGOLabel1"
            CODIGOLabel1.Size = New System.Drawing.Size(47, 13)
            CODIGOLabel1.TabIndex = 2
            CODIGOLabel1.Text = "CODIGO:"
            '
            'NOMBRE_SUB_GRUPOLabel
            '
            NOMBRE_SUB_GRUPOLabel.AutoSize = True
            NOMBRE_SUB_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NOMBRE_SUB_GRUPOLabel.Location = New System.Drawing.Point(16, 77)
            NOMBRE_SUB_GRUPOLabel.Name = "NOMBRE_SUB_GRUPOLabel"
            NOMBRE_SUB_GRUPOLabel.Size = New System.Drawing.Size(106, 13)
            NOMBRE_SUB_GRUPOLabel.TabIndex = 4
            NOMBRE_SUB_GRUPOLabel.Text = "NOMBRE SUB GRUPO:"
            '
            'ID_GRUPO_SUB_GRUPOLabel
            '
            ID_GRUPO_SUB_GRUPOLabel.AutoSize = True
            ID_GRUPO_SUB_GRUPOLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ID_GRUPO_SUB_GRUPOLabel.Location = New System.Drawing.Point(16, 103)
            ID_GRUPO_SUB_GRUPOLabel.Name = "ID_GRUPO_SUB_GRUPOLabel"
            ID_GRUPO_SUB_GRUPOLabel.Size = New System.Drawing.Size(43, 13)
            ID_GRUPO_SUB_GRUPOLabel.TabIndex = 6
            ID_GRUPO_SUB_GRUPOLabel.Text = "GRUPO:"
            '
            'ID_CATEGORIALabel
            '
            ID_CATEGORIALabel.AutoSize = True
            ID_CATEGORIALabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ID_CATEGORIALabel.Location = New System.Drawing.Point(11, 30)
            ID_CATEGORIALabel.Name = "ID_CATEGORIALabel"
            ID_CATEGORIALabel.Size = New System.Drawing.Size(20, 13)
            ID_CATEGORIALabel.TabIndex = 17
            ID_CATEGORIALabel.Text = "ID:"
            '
            'CODIGOLabel2
            '
            CODIGOLabel2.AutoSize = True
            CODIGOLabel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CODIGOLabel2.Location = New System.Drawing.Point(11, 51)
            CODIGOLabel2.Name = "CODIGOLabel2"
            CODIGOLabel2.Size = New System.Drawing.Size(47, 13)
            CODIGOLabel2.TabIndex = 19
            CODIGOLabel2.Text = "CODIGO:"
            '
            'NOMBRE_CATEGORIALabel
            '
            NOMBRE_CATEGORIALabel.AutoSize = True
            NOMBRE_CATEGORIALabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            NOMBRE_CATEGORIALabel.Location = New System.Drawing.Point(11, 75)
            NOMBRE_CATEGORIALabel.Name = "NOMBRE_CATEGORIALabel"
            NOMBRE_CATEGORIALabel.Size = New System.Drawing.Size(62, 26)
            NOMBRE_CATEGORIALabel.TabIndex = 21
            NOMBRE_CATEGORIALabel.Text = "NOMBRE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CATEGORIA:"
            '
            'Label1
            '
            Label1.AutoSize = True
            Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label1.Location = New System.Drawing.Point(16, 20)
            Label1.Name = "Label1"
            Label1.Size = New System.Drawing.Size(78, 13)
            Label1.TabIndex = 0
            Label1.Text = "ID SECUENCIAL:"
            '
            'Label2
            '
            Label2.AutoSize = True
            Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label2.Location = New System.Drawing.Point(16, 46)
            Label2.Name = "Label2"
            Label2.Size = New System.Drawing.Size(47, 13)
            Label2.TabIndex = 2
            Label2.Text = "CODIGO:"
            '
            'Label3
            '
            Label3.AutoSize = True
            Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label3.Location = New System.Drawing.Point(16, 72)
            Label3.Name = "Label3"
            Label3.Size = New System.Drawing.Size(109, 13)
            Label3.TabIndex = 4
            Label3.Text = "NOMBRE SECUENCIAL:"
            '
            'Label4
            '
            Label4.AutoSize = True
            Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label4.Location = New System.Drawing.Point(15, 123)
            Label4.Name = "Label4"
            Label4.Size = New System.Drawing.Size(63, 13)
            Label4.TabIndex = 6
            Label4.Text = "SUB GRUPO:"
            '
            'Label5
            '
            Label5.AutoSize = True
            Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Label5.Location = New System.Drawing.Point(15, 98)
            Label5.Name = "Label5"
            Label5.Size = New System.Drawing.Size(108, 13)
            Label5.TabIndex = 78
            Label5.Text = "ESTADO DEPRECIABLE:"
            '
            'gbGrupo
            '
            Me.gbGrupo.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
            Me.gbGrupo.Controls.Add(Me.btnGuardarGrupo)
            Me.gbGrupo.Controls.Add(Me.btnNuevoGrupo)
            Me.gbGrupo.Controls.Add(Me.cbmCategoriaGrupo)
            Me.gbGrupo.Controls.Add(ID_GRUPOLabel)
            Me.gbGrupo.Controls.Add(Me.txtIdGrupo)
            Me.gbGrupo.Controls.Add(CODIGOLabel)
            Me.gbGrupo.Controls.Add(Me.txtCodigoGrupo)
            Me.gbGrupo.Controls.Add(NOMBRE_GRUPOLabel)
            Me.gbGrupo.Controls.Add(Me.txtNombreGrupo)
            Me.gbGrupo.Controls.Add(ID_CATEGORIA_GRUPOLabel)
            Me.gbGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbGrupo.Location = New System.Drawing.Point(2, 132)
            Me.gbGrupo.Name = "gbGrupo"
            Me.gbGrupo.Size = New System.Drawing.Size(458, 141)
            Me.gbGrupo.TabIndex = 1
            Me.gbGrupo.TabStop = False
            Me.gbGrupo.Text = "GRUPOS"
            '
            'btnGuardarGrupo
            '
            Me.btnGuardarGrupo.BackColor = System.Drawing.Color.White
            Me.btnGuardarGrupo.Enabled = False
            Me.btnGuardarGrupo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarGrupo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarGrupo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarGrupo.Location = New System.Drawing.Point(350, 27)
            Me.btnGuardarGrupo.Name = "btnGuardarGrupo"
            Me.btnGuardarGrupo.Size = New System.Drawing.Size(41, 34)
            Me.btnGuardarGrupo.TabIndex = 73
            Me.btnGuardarGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarGrupo.UseVisualStyleBackColor = False
            '
            'btnNuevoGrupo
            '
            Me.btnNuevoGrupo.BackColor = System.Drawing.Color.White
            Me.btnNuevoGrupo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoGrupo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoGrupo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevoGrupo.Location = New System.Drawing.Point(304, 27)
            Me.btnNuevoGrupo.Name = "btnNuevoGrupo"
            Me.btnNuevoGrupo.Size = New System.Drawing.Size(41, 34)
            Me.btnNuevoGrupo.TabIndex = 71
            Me.btnNuevoGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoGrupo.UseVisualStyleBackColor = False
            '
            'cbmCategoriaGrupo
            '
            Me.cbmCategoriaGrupo.BackColor = System.Drawing.Color.White
            Me.cbmCategoriaGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoriaGrupo.Enabled = False
            Me.cbmCategoriaGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCategoriaGrupo.FormattingEnabled = True
            Me.cbmCategoriaGrupo.Location = New System.Drawing.Point(153, 101)
            Me.cbmCategoriaGrupo.Name = "cbmCategoriaGrupo"
            Me.cbmCategoriaGrupo.Size = New System.Drawing.Size(280, 21)
            Me.cbmCategoriaGrupo.TabIndex = 0
            '
            'txtIdGrupo
            '
            Me.txtIdGrupo.BackColor = System.Drawing.Color.White
            Me.txtIdGrupo.Enabled = False
            Me.txtIdGrupo.Location = New System.Drawing.Point(153, 24)
            Me.txtIdGrupo.Name = "txtIdGrupo"
            Me.txtIdGrupo.Size = New System.Drawing.Size(60, 21)
            Me.txtIdGrupo.TabIndex = 4
            Me.txtIdGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoGrupo
            '
            Me.txtCodigoGrupo.BackColor = System.Drawing.Color.White
            Me.txtCodigoGrupo.Enabled = False
            Me.txtCodigoGrupo.Location = New System.Drawing.Point(153, 50)
            Me.txtCodigoGrupo.Name = "txtCodigoGrupo"
            Me.txtCodigoGrupo.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoGrupo.TabIndex = 8
            '
            'txtNombreGrupo
            '
            Me.txtNombreGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreGrupo.Enabled = False
            Me.txtNombreGrupo.Location = New System.Drawing.Point(153, 76)
            Me.txtNombreGrupo.Name = "txtNombreGrupo"
            Me.txtNombreGrupo.Size = New System.Drawing.Size(280, 21)
            Me.txtNombreGrupo.TabIndex = 9
            '
            'gbSubGrupo
            '
            Me.gbSubGrupo.Controls.Add(Me.btnGuardarSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.cbmSubGrupo)
            Me.gbSubGrupo.Controls.Add(ID_SUB_GRUPOLabel)
            Me.gbSubGrupo.Controls.Add(Me.txtIdSubGrupo)
            Me.gbSubGrupo.Controls.Add(CODIGOLabel1)
            Me.gbSubGrupo.Controls.Add(Me.txtCodigoSubGrupo)
            Me.gbSubGrupo.Controls.Add(Me.btnNuevoSubGrupo)
            Me.gbSubGrupo.Controls.Add(NOMBRE_SUB_GRUPOLabel)
            Me.gbSubGrupo.Controls.Add(Me.txtNombreSubGrupo)
            Me.gbSubGrupo.Controls.Add(ID_GRUPO_SUB_GRUPOLabel)
            Me.gbSubGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSubGrupo.Location = New System.Drawing.Point(2, 279)
            Me.gbSubGrupo.Name = "gbSubGrupo"
            Me.gbSubGrupo.Size = New System.Drawing.Size(458, 135)
            Me.gbSubGrupo.TabIndex = 4
            Me.gbSubGrupo.TabStop = False
            Me.gbSubGrupo.Text = "SUB-GRUPOS"
            '
            'btnGuardarSubGrupo
            '
            Me.btnGuardarSubGrupo.BackColor = System.Drawing.Color.White
            Me.btnGuardarSubGrupo.Enabled = False
            Me.btnGuardarSubGrupo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarSubGrupo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarSubGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSubGrupo.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSubGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarSubGrupo.Location = New System.Drawing.Point(350, 26)
            Me.btnGuardarSubGrupo.Name = "btnGuardarSubGrupo"
            Me.btnGuardarSubGrupo.Size = New System.Drawing.Size(41, 34)
            Me.btnGuardarSubGrupo.TabIndex = 76
            Me.btnGuardarSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarSubGrupo.UseVisualStyleBackColor = False
            '
            'cbmSubGrupo
            '
            Me.cbmSubGrupo.BackColor = System.Drawing.Color.White
            Me.cbmSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSubGrupo.Enabled = False
            Me.cbmSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmSubGrupo.FormattingEnabled = True
            Me.cbmSubGrupo.Location = New System.Drawing.Point(153, 101)
            Me.cbmSubGrupo.Name = "cbmSubGrupo"
            Me.cbmSubGrupo.Size = New System.Drawing.Size(277, 21)
            Me.cbmSubGrupo.TabIndex = 3
            '
            'txtIdSubGrupo
            '
            Me.txtIdSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtIdSubGrupo.Enabled = False
            Me.txtIdSubGrupo.Location = New System.Drawing.Point(152, 22)
            Me.txtIdSubGrupo.Name = "txtIdSubGrupo"
            Me.txtIdSubGrupo.Size = New System.Drawing.Size(60, 21)
            Me.txtIdSubGrupo.TabIndex = 0
            Me.txtIdSubGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoSubGrupo
            '
            Me.txtCodigoSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtCodigoSubGrupo.Enabled = False
            Me.txtCodigoSubGrupo.Location = New System.Drawing.Point(152, 48)
            Me.txtCodigoSubGrupo.Name = "txtCodigoSubGrupo"
            Me.txtCodigoSubGrupo.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoSubGrupo.TabIndex = 1
            '
            'btnNuevoSubGrupo
            '
            Me.btnNuevoSubGrupo.BackColor = System.Drawing.Color.White
            Me.btnNuevoSubGrupo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoSubGrupo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoSubGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSubGrupo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoSubGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevoSubGrupo.Location = New System.Drawing.Point(304, 26)
            Me.btnNuevoSubGrupo.Name = "btnNuevoSubGrupo"
            Me.btnNuevoSubGrupo.Size = New System.Drawing.Size(41, 34)
            Me.btnNuevoSubGrupo.TabIndex = 75
            Me.btnNuevoSubGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoSubGrupo.UseVisualStyleBackColor = False
            '
            'txtNombreSubGrupo
            '
            Me.txtNombreSubGrupo.BackColor = System.Drawing.Color.White
            Me.txtNombreSubGrupo.Enabled = False
            Me.txtNombreSubGrupo.Location = New System.Drawing.Point(152, 74)
            Me.txtNombreSubGrupo.Name = "txtNombreSubGrupo"
            Me.txtNombreSubGrupo.Size = New System.Drawing.Size(280, 21)
            Me.txtNombreSubGrupo.TabIndex = 2
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnGuardarCategoria)
            Me.GroupBox1.Controls.Add(Me.btnNuevoCategoria)
            Me.GroupBox1.Controls.Add(ID_CATEGORIALabel)
            Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
            Me.GroupBox1.Controls.Add(CODIGOLabel2)
            Me.GroupBox1.Controls.Add(Me.txtCodigoCategoria)
            Me.GroupBox1.Controls.Add(Me.txtNombreCategoria)
            Me.GroupBox1.Controls.Add(NOMBRE_CATEGORIALabel)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(458, 124)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "CATEGORIAS"
            '
            'btnGuardarCategoria
            '
            Me.btnGuardarCategoria.BackColor = System.Drawing.Color.White
            Me.btnGuardarCategoria.Enabled = False
            Me.btnGuardarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarCategoria.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarCategoria.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarCategoria.Location = New System.Drawing.Point(350, 30)
            Me.btnGuardarCategoria.Name = "btnGuardarCategoria"
            Me.btnGuardarCategoria.Size = New System.Drawing.Size(41, 34)
            Me.btnGuardarCategoria.TabIndex = 75
            Me.btnGuardarCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarCategoria.UseVisualStyleBackColor = False
            '
            'btnNuevoCategoria
            '
            Me.btnNuevoCategoria.BackColor = System.Drawing.Color.White
            Me.btnNuevoCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnNuevoCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoCategoria.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoCategoria.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevoCategoria.Location = New System.Drawing.Point(304, 30)
            Me.btnNuevoCategoria.Name = "btnNuevoCategoria"
            Me.btnNuevoCategoria.Size = New System.Drawing.Size(41, 34)
            Me.btnNuevoCategoria.TabIndex = 74
            Me.btnNuevoCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoCategoria.UseVisualStyleBackColor = False
            '
            'txtIdCategoria
            '
            Me.txtIdCategoria.BackColor = System.Drawing.Color.White
            Me.txtIdCategoria.Enabled = False
            Me.txtIdCategoria.Location = New System.Drawing.Point(74, 27)
            Me.txtIdCategoria.Name = "txtIdCategoria"
            Me.txtIdCategoria.Size = New System.Drawing.Size(58, 21)
            Me.txtIdCategoria.TabIndex = 3
            '
            'txtCodigoCategoria
            '
            Me.txtCodigoCategoria.BackColor = System.Drawing.Color.White
            Me.txtCodigoCategoria.Enabled = False
            Me.txtCodigoCategoria.Location = New System.Drawing.Point(74, 52)
            Me.txtCodigoCategoria.Name = "txtCodigoCategoria"
            Me.txtCodigoCategoria.Size = New System.Drawing.Size(68, 21)
            Me.txtCodigoCategoria.TabIndex = 6
            '
            'txtNombreCategoria
            '
            Me.txtNombreCategoria.BackColor = System.Drawing.Color.White
            Me.txtNombreCategoria.Enabled = False
            Me.txtNombreCategoria.Location = New System.Drawing.Point(74, 78)
            Me.txtNombreCategoria.Name = "txtNombreCategoria"
            Me.txtNombreCategoria.Size = New System.Drawing.Size(372, 21)
            Me.txtNombreCategoria.TabIndex = 7
            '
            'btnVolver
            '
            Me.btnVolver.BackColor = System.Drawing.Color.White
            Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnVolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnVolver.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnVolver.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnVolver.Location = New System.Drawing.Point(169, 571)
            Me.btnVolver.Name = "btnVolver"
            Me.btnVolver.Size = New System.Drawing.Size(104, 35)
            Me.btnVolver.TabIndex = 12
            Me.btnVolver.Text = "     ACEPTAR"
            Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVolver.UseVisualStyleBackColor = False
            '
            'gbSecuencial
            '
            Me.gbSecuencial.Controls.Add(Me.cbDepreciable)
            Me.gbSecuencial.Controls.Add(Label5)
            Me.gbSecuencial.Controls.Add(Me.btnGuardarSecuencial)
            Me.gbSecuencial.Controls.Add(Me.cbSubGrupo)
            Me.gbSecuencial.Controls.Add(Label1)
            Me.gbSecuencial.Controls.Add(Me.txtIdSecuencial)
            Me.gbSecuencial.Controls.Add(Label2)
            Me.gbSecuencial.Controls.Add(Me.txtCodigoSecuencial)
            Me.gbSecuencial.Controls.Add(Me.btnNuevoSecuecial)
            Me.gbSecuencial.Controls.Add(Label3)
            Me.gbSecuencial.Controls.Add(Me.txtNombreSecuencial)
            Me.gbSecuencial.Controls.Add(Label4)
            Me.gbSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSecuencial.Location = New System.Drawing.Point(2, 420)
            Me.gbSecuencial.Name = "gbSecuencial"
            Me.gbSecuencial.Size = New System.Drawing.Size(459, 150)
            Me.gbSecuencial.TabIndex = 14
            Me.gbSecuencial.TabStop = False
            Me.gbSecuencial.Text = "SECUENCIAL"
            '
            'cbDepreciable
            '
            Me.cbDepreciable.BackColor = System.Drawing.Color.White
            Me.cbDepreciable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbDepreciable.Enabled = False
            Me.cbDepreciable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbDepreciable.FormattingEnabled = True
            Me.cbDepreciable.Items.AddRange(New Object() {"SI", "NO"})
            Me.cbDepreciable.Location = New System.Drawing.Point(151, 94)
            Me.cbDepreciable.Name = "cbDepreciable"
            Me.cbDepreciable.Size = New System.Drawing.Size(87, 21)
            Me.cbDepreciable.TabIndex = 79
            '
            'btnGuardarSecuencial
            '
            Me.btnGuardarSecuencial.BackColor = System.Drawing.Color.White
            Me.btnGuardarSecuencial.Enabled = False
            Me.btnGuardarSecuencial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarSecuencial.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnGuardarSecuencial.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSecuencial.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarSecuencial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardarSecuencial.Location = New System.Drawing.Point(350, 20)
            Me.btnGuardarSecuencial.Name = "btnGuardarSecuencial"
            Me.btnGuardarSecuencial.Size = New System.Drawing.Size(41, 34)
            Me.btnGuardarSecuencial.TabIndex = 76
            Me.btnGuardarSecuencial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardarSecuencial.UseVisualStyleBackColor = False
            '
            'cbSubGrupo
            '
            Me.cbSubGrupo.BackColor = System.Drawing.Color.White
            Me.cbSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSubGrupo.Enabled = False
            Me.cbSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbSubGrupo.FormattingEnabled = True
            Me.cbSubGrupo.Location = New System.Drawing.Point(152, 121)
            Me.cbSubGrupo.Name = "cbSubGrupo"
            Me.cbSubGrupo.Size = New System.Drawing.Size(277, 21)
            Me.cbSubGrupo.TabIndex = 3
            '
            'txtIdSecuencial
            '
            Me.txtIdSecuencial.BackColor = System.Drawing.Color.White
            Me.txtIdSecuencial.Enabled = False
            Me.txtIdSecuencial.Location = New System.Drawing.Point(152, 17)
            Me.txtIdSecuencial.Name = "txtIdSecuencial"
            Me.txtIdSecuencial.Size = New System.Drawing.Size(60, 21)
            Me.txtIdSecuencial.TabIndex = 0
            Me.txtIdSecuencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCodigoSecuencial
            '
            Me.txtCodigoSecuencial.BackColor = System.Drawing.Color.White
            Me.txtCodigoSecuencial.Enabled = False
            Me.txtCodigoSecuencial.Location = New System.Drawing.Point(152, 43)
            Me.txtCodigoSecuencial.Name = "txtCodigoSecuencial"
            Me.txtCodigoSecuencial.Size = New System.Drawing.Size(100, 21)
            Me.txtCodigoSecuencial.TabIndex = 1
            '
            'btnNuevoSecuecial
            '
            Me.btnNuevoSecuecial.BackColor = System.Drawing.Color.White
            Me.btnNuevoSecuecial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoSecuecial.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnNuevoSecuecial.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSecuecial.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoSecuecial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnNuevoSecuecial.Location = New System.Drawing.Point(304, 20)
            Me.btnNuevoSecuecial.Name = "btnNuevoSecuecial"
            Me.btnNuevoSecuecial.Size = New System.Drawing.Size(41, 34)
            Me.btnNuevoSecuecial.TabIndex = 75
            Me.btnNuevoSecuecial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnNuevoSecuecial.UseVisualStyleBackColor = False
            '
            'txtNombreSecuencial
            '
            Me.txtNombreSecuencial.BackColor = System.Drawing.Color.White
            Me.txtNombreSecuencial.Enabled = False
            Me.txtNombreSecuencial.Location = New System.Drawing.Point(152, 69)
            Me.txtNombreSecuencial.Name = "txtNombreSecuencial"
            Me.txtNombreSecuencial.Size = New System.Drawing.Size(280, 21)
            Me.txtNombreSecuencial.TabIndex = 2
            '
            'dgvCategoria
            '
            Me.dgvCategoria.AllowUserToAddRows = False
            Me.dgvCategoria.AllowUserToDeleteRows = False
            Me.dgvCategoria.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCategoria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCategoria.BackgroundColor = System.Drawing.Color.White
            Me.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCategoria.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvCategoria.Location = New System.Drawing.Point(466, 5)
            Me.dgvCategoria.MultiSelect = False
            Me.dgvCategoria.Name = "dgvCategoria"
            Me.dgvCategoria.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvCategoria.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvCategoria.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCategoria.Size = New System.Drawing.Size(492, 121)
            Me.dgvCategoria.TabIndex = 42
            '
            'dgvGrupos
            '
            Me.dgvGrupos.AllowUserToAddRows = False
            Me.dgvGrupos.AllowUserToDeleteRows = False
            Me.dgvGrupos.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvGrupos.BackgroundColor = System.Drawing.Color.White
            Me.dgvGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGrupos.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvGrupos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvGrupos.Location = New System.Drawing.Point(466, 132)
            Me.dgvGrupos.MultiSelect = False
            Me.dgvGrupos.Name = "dgvGrupos"
            Me.dgvGrupos.ReadOnly = True
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrupos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvGrupos.RowHeadersVisible = False
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvGrupos.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrupos.Size = New System.Drawing.Size(492, 141)
            Me.dgvGrupos.TabIndex = 43
            '
            'dgvSubgrupos
            '
            Me.dgvSubgrupos.AllowUserToAddRows = False
            Me.dgvSubgrupos.AllowUserToDeleteRows = False
            Me.dgvSubgrupos.AllowUserToResizeRows = False
            DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSubgrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
            Me.dgvSubgrupos.BackgroundColor = System.Drawing.Color.White
            Me.dgvSubgrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSubgrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvSubgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSubgrupos.DefaultCellStyle = DataGridViewCellStyle13
            Me.dgvSubgrupos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvSubgrupos.Location = New System.Drawing.Point(466, 279)
            Me.dgvSubgrupos.MultiSelect = False
            Me.dgvSubgrupos.Name = "dgvSubgrupos"
            Me.dgvSubgrupos.ReadOnly = True
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSubgrupos.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvSubgrupos.RowHeadersVisible = False
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSubgrupos.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvSubgrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSubgrupos.Size = New System.Drawing.Size(492, 135)
            Me.dgvSubgrupos.TabIndex = 44
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.White
            Me.dgvSecuencial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSecuencial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvSecuencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSecuencial.DefaultCellStyle = DataGridViewCellStyle18
            Me.dgvSecuencial.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvSecuencial.Location = New System.Drawing.Point(466, 420)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSecuencial.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.dgvSecuencial.RowHeadersVisible = False
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSecuencial.RowsDefaultCellStyle = DataGridViewCellStyle20
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(492, 186)
            Me.dgvSecuencial.TabIndex = 45
            '
            'FormAgregarCategoria
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(960, 608)
            Me.Controls.Add(Me.dgvSecuencial)
            Me.Controls.Add(Me.btnVolver)
            Me.Controls.Add(Me.dgvSubgrupos)
            Me.Controls.Add(Me.dgvGrupos)
            Me.Controls.Add(Me.dgvCategoria)
            Me.Controls.Add(Me.gbSecuencial)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbSubGrupo)
            Me.Controls.Add(Me.gbGrupo)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormAgregarCategoria"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AGREGAR CODIGOS DE ACTIVOS FIJOS"
            Me.gbGrupo.ResumeLayout(False)
            Me.gbGrupo.PerformLayout()
            Me.gbSubGrupo.ResumeLayout(False)
            Me.gbSubGrupo.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbSecuencial.ResumeLayout(False)
            Me.gbSecuencial.PerformLayout()
            CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSubgrupos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoGrupo As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreGrupo As System.Windows.Forms.TextBox
        Friend WithEvents gbSubGrupo As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreSubGrupo As System.Windows.Forms.TextBox
        Friend WithEvents cbmCategoriaGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents btnNuevoGrupo As System.Windows.Forms.Button
        Friend WithEvents btnGuardarGrupo As System.Windows.Forms.Button
        Friend WithEvents btnGuardarSubGrupo As System.Windows.Forms.Button
        Friend WithEvents btnNuevoSubGrupo As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardarCategoria As System.Windows.Forms.Button
        Friend WithEvents btnNuevoCategoria As System.Windows.Forms.Button
        Friend WithEvents btnVolver As System.Windows.Forms.Button
        Friend WithEvents cbmSubGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents gbSecuencial As System.Windows.Forms.GroupBox
        Friend WithEvents btnGuardarSecuencial As System.Windows.Forms.Button
        Friend WithEvents cbSubGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents txtIdSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents btnNuevoSecuecial As System.Windows.Forms.Button
        Friend WithEvents txtNombreSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents cbDepreciable As System.Windows.Forms.ComboBox
        Friend WithEvents txtIdCategoria As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoCategoria As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCategoria As System.Windows.Forms.TextBox
        Friend WithEvents dgvCategoria As System.Windows.Forms.DataGridView
        Friend WithEvents dgvGrupos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvSubgrupos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
    End Class
End Namespace