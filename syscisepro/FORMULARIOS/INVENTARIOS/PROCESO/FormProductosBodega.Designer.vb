Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormProductosBodega
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductosBodega))
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.cbmCategoría = New System.Windows.Forms.ComboBox()
            Me.lblCategoría = New System.Windows.Forms.Label()
            Me.cbmGrupo = New System.Windows.Forms.ComboBox()
            Me.lblGrupo = New System.Windows.Forms.Label()
            Me.cbmSubGrupo = New System.Windows.Forms.ComboBox()
            Me.lblSubGrupo = New System.Windows.Forms.Label()
            Me.lblSecuencial = New System.Windows.Forms.Label()
            Me.txtSecuencial = New System.Windows.Forms.TextBox()
            Me.lblIdSecuencial = New System.Windows.Forms.Label()
            Me.cbmMaterial = New System.Windows.Forms.ComboBox()
            Me.lblMaterial = New System.Windows.Forms.Label()
            Me.cbmModelo = New System.Windows.Forms.ComboBox()
            Me.lblModelo = New System.Windows.Forms.Label()
            Me.cbmMarca = New System.Windows.Forms.ComboBox()
            Me.lblMarca = New System.Windows.Forms.Label()
            Me.cbmColor = New System.Windows.Forms.ComboBox()
            Me.lblColor = New System.Windows.Forms.Label()
            Me.cbmUnidadDeMedida = New System.Windows.Forms.ComboBox()
            Me.lblUnidad = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtDescripción = New System.Windows.Forms.TextBox()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcProducto = New System.Windows.Forms.TabControl()
            Me.tpIngreso = New System.Windows.Forms.TabPage()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblValor = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.chbxDescuento = New System.Windows.Forms.CheckBox()
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.cbmSubGrupo2 = New System.Windows.Forms.ComboBox()
            Me.cbmGrupo2 = New System.Windows.Forms.ComboBox()
            Me.cbmCategoria2 = New System.Windows.Forms.ComboBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.txtPvp = New System.Windows.Forms.TextBox()
            Me.lblCrearSubGrupo = New System.Windows.Forms.Button()
            Me.lblCrearGrupo = New System.Windows.Forms.Button()
            Me.lblCrearCategoria = New System.Windows.Forms.Button()
            Me.lblCrearUnidadMedida = New System.Windows.Forms.Button()
            Me.lblCrearColor = New System.Windows.Forms.Button()
            Me.lblCrearMaterial = New System.Windows.Forms.Button()
            Me.lblCrearModelo = New System.Windows.Forms.Button()
            Me.lblCrearMarca = New System.Windows.Forms.Button()
            Me.txtCosto = New System.Windows.Forms.TextBox()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmAjustar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportarGrupos = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvSecuencial = New System.Windows.Forms.DataGridView()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox2 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.crvInventarios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcProducto.SuspendLayout()
            Me.tpIngreso.SuspendLayout()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'cbmCategoría
            '
            Me.cbmCategoría.BackColor = System.Drawing.Color.White
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.DropDownWidth = 177
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoría.ForeColor = System.Drawing.Color.Black
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(376, 28)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(151, 21)
            Me.cbmCategoría.TabIndex = 68
            '
            'lblCategoría
            '
            Me.lblCategoría.AutoSize = True
            Me.lblCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCategoría.Location = New System.Drawing.Point(330, 76)
            Me.lblCategoría.Name = "lblCategoría"
            Me.lblCategoría.Size = New System.Drawing.Size(66, 13)
            Me.lblCategoría.TabIndex = 67
            Me.lblCategoría.Text = "CATEGORÍA"
            '
            'cbmGrupo
            '
            Me.cbmGrupo.BackColor = System.Drawing.Color.White
            Me.cbmGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo.DropDownWidth = 177
            Me.cbmGrupo.Enabled = False
            Me.cbmGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.ForeColor = System.Drawing.Color.Black
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(376, 54)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(151, 21)
            Me.cbmGrupo.TabIndex = 76
            '
            'lblGrupo
            '
            Me.lblGrupo.AutoSize = True
            Me.lblGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblGrupo.Location = New System.Drawing.Point(330, 107)
            Me.lblGrupo.Name = "lblGrupo"
            Me.lblGrupo.Size = New System.Drawing.Size(44, 13)
            Me.lblGrupo.TabIndex = 75
            Me.lblGrupo.Text = "GRUPO"
            '
            'cbmSubGrupo
            '
            Me.cbmSubGrupo.BackColor = System.Drawing.Color.White
            Me.cbmSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSubGrupo.DropDownWidth = 177
            Me.cbmSubGrupo.Enabled = False
            Me.cbmSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmSubGrupo.ForeColor = System.Drawing.Color.Black
            Me.cbmSubGrupo.FormattingEnabled = True
            Me.cbmSubGrupo.Location = New System.Drawing.Point(376, 80)
            Me.cbmSubGrupo.Name = "cbmSubGrupo"
            Me.cbmSubGrupo.Size = New System.Drawing.Size(151, 21)
            Me.cbmSubGrupo.TabIndex = 78
            '
            'lblSubGrupo
            '
            Me.lblSubGrupo.AutoSize = True
            Me.lblSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubGrupo.Location = New System.Drawing.Point(330, 139)
            Me.lblSubGrupo.Name = "lblSubGrupo"
            Me.lblSubGrupo.Size = New System.Drawing.Size(68, 13)
            Me.lblSubGrupo.TabIndex = 77
            Me.lblSubGrupo.Text = "SUB GRUPO"
            '
            'lblSecuencial
            '
            Me.lblSecuencial.AutoSize = True
            Me.lblSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSecuencial.Location = New System.Drawing.Point(662, 38)
            Me.lblSecuencial.Name = "lblSecuencial"
            Me.lblSecuencial.Size = New System.Drawing.Size(56, 13)
            Me.lblSecuencial.TabIndex = 82
            Me.lblSecuencial.Text = "NOMBRE:"
            '
            'txtSecuencial
            '
            Me.txtSecuencial.BackColor = System.Drawing.Color.White
            Me.txtSecuencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencial.Enabled = False
            Me.txtSecuencial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSecuencial.ForeColor = System.Drawing.Color.Black
            Me.txtSecuencial.Location = New System.Drawing.Point(668, 4)
            Me.txtSecuencial.Multiline = True
            Me.txtSecuencial.Name = "txtSecuencial"
            Me.txtSecuencial.Size = New System.Drawing.Size(207, 20)
            Me.txtSecuencial.TabIndex = 83
            '
            'lblIdSecuencial
            '
            Me.lblIdSecuencial.AutoSize = True
            Me.lblIdSecuencial.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdSecuencial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.lblIdSecuencial.Location = New System.Drawing.Point(597, 52)
            Me.lblIdSecuencial.Name = "lblIdSecuencial"
            Me.lblIdSecuencial.Size = New System.Drawing.Size(35, 15)
            Me.lblIdSecuencial.TabIndex = 101
            Me.lblIdSecuencial.Text = "0000"
            Me.lblIdSecuencial.Visible = False
            '
            'cbmMaterial
            '
            Me.cbmMaterial.BackColor = System.Drawing.Color.White
            Me.cbmMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMaterial.Enabled = False
            Me.cbmMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMaterial.ForeColor = System.Drawing.Color.Black
            Me.cbmMaterial.FormattingEnabled = True
            Me.cbmMaterial.Location = New System.Drawing.Point(62, 54)
            Me.cbmMaterial.Name = "cbmMaterial"
            Me.cbmMaterial.Size = New System.Drawing.Size(151, 21)
            Me.cbmMaterial.TabIndex = 112
            '
            'lblMaterial
            '
            Me.lblMaterial.AutoSize = True
            Me.lblMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaterial.Location = New System.Drawing.Point(14, 107)
            Me.lblMaterial.Name = "lblMaterial"
            Me.lblMaterial.Size = New System.Drawing.Size(59, 13)
            Me.lblMaterial.TabIndex = 111
            Me.lblMaterial.Text = "MATERIAL"
            '
            'cbmModelo
            '
            Me.cbmModelo.BackColor = System.Drawing.Color.White
            Me.cbmModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmModelo.Enabled = False
            Me.cbmModelo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmModelo.ForeColor = System.Drawing.Color.Black
            Me.cbmModelo.FormattingEnabled = True
            Me.cbmModelo.Location = New System.Drawing.Point(62, 28)
            Me.cbmModelo.Name = "cbmModelo"
            Me.cbmModelo.Size = New System.Drawing.Size(151, 21)
            Me.cbmModelo.TabIndex = 110
            '
            'lblModelo
            '
            Me.lblModelo.AutoSize = True
            Me.lblModelo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblModelo.Location = New System.Drawing.Point(14, 76)
            Me.lblModelo.Name = "lblModelo"
            Me.lblModelo.Size = New System.Drawing.Size(52, 13)
            Me.lblModelo.TabIndex = 109
            Me.lblModelo.Text = "MODELO"
            '
            'cbmMarca
            '
            Me.cbmMarca.BackColor = System.Drawing.Color.White
            Me.cbmMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMarca.Enabled = False
            Me.cbmMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMarca.ForeColor = System.Drawing.Color.Black
            Me.cbmMarca.FormattingEnabled = True
            Me.cbmMarca.Location = New System.Drawing.Point(62, 3)
            Me.cbmMarca.Name = "cbmMarca"
            Me.cbmMarca.Size = New System.Drawing.Size(151, 21)
            Me.cbmMarca.TabIndex = 108
            '
            'lblMarca
            '
            Me.lblMarca.AutoSize = True
            Me.lblMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMarca.Location = New System.Drawing.Point(14, 43)
            Me.lblMarca.Name = "lblMarca"
            Me.lblMarca.Size = New System.Drawing.Size(45, 13)
            Me.lblMarca.TabIndex = 107
            Me.lblMarca.Text = "MARCA"
            '
            'cbmColor
            '
            Me.cbmColor.BackColor = System.Drawing.Color.White
            Me.cbmColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmColor.Enabled = False
            Me.cbmColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmColor.ForeColor = System.Drawing.Color.Black
            Me.cbmColor.FormattingEnabled = True
            Me.cbmColor.Location = New System.Drawing.Point(62, 80)
            Me.cbmColor.Name = "cbmColor"
            Me.cbmColor.Size = New System.Drawing.Size(151, 21)
            Me.cbmColor.TabIndex = 117
            '
            'lblColor
            '
            Me.lblColor.AutoSize = True
            Me.lblColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblColor.Location = New System.Drawing.Point(15, 139)
            Me.lblColor.Name = "lblColor"
            Me.lblColor.Size = New System.Drawing.Size(43, 13)
            Me.lblColor.TabIndex = 116
            Me.lblColor.Text = "COLOR"
            '
            'cbmUnidadDeMedida
            '
            Me.cbmUnidadDeMedida.BackColor = System.Drawing.Color.White
            Me.cbmUnidadDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmUnidadDeMedida.DropDownWidth = 177
            Me.cbmUnidadDeMedida.Enabled = False
            Me.cbmUnidadDeMedida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmUnidadDeMedida.ForeColor = System.Drawing.Color.Black
            Me.cbmUnidadDeMedida.FormattingEnabled = True
            Me.cbmUnidadDeMedida.Location = New System.Drawing.Point(376, 3)
            Me.cbmUnidadDeMedida.Name = "cbmUnidadDeMedida"
            Me.cbmUnidadDeMedida.Size = New System.Drawing.Size(151, 21)
            Me.cbmUnidadDeMedida.TabIndex = 120
            '
            'lblUnidad
            '
            Me.lblUnidad.AutoSize = True
            Me.lblUnidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUnidad.Location = New System.Drawing.Point(330, 43)
            Me.lblUnidad.Name = "lblUnidad"
            Me.lblUnidad.Size = New System.Drawing.Size(89, 13)
            Me.lblUnidad.TabIndex = 119
            Me.lblUnidad.Text = "UNIDAD MEDIDA"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(662, 64)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(80, 13)
            Me.Label14.TabIndex = 122
            Me.Label14.Text = "DESCRIPCIÓN:"
            '
            'txtDescripción
            '
            Me.txtDescripción.BackColor = System.Drawing.Color.White
            Me.txtDescripción.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescripción.Enabled = False
            Me.txtDescripción.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescripción.ForeColor = System.Drawing.Color.Black
            Me.txtDescripción.Location = New System.Drawing.Point(668, 27)
            Me.txtDescripción.Multiline = True
            Me.txtDescripción.Name = "txtDescripción"
            Me.txtDescripción.Size = New System.Drawing.Size(208, 38)
            Me.txtDescripción.TabIndex = 123
            '
            'ttPublico
            '
            Me.ttPublico.AutoPopDelay = 5000
            Me.ttPublico.BackColor = System.Drawing.Color.LightSteelBlue
            Me.ttPublico.InitialDelay = 100
            Me.ttPublico.IsBalloon = True
            Me.ttPublico.ReshowDelay = 100
            Me.ttPublico.ShowAlways = True
            Me.ttPublico.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            '
            'tcProducto
            '
            Me.tcProducto.Controls.Add(Me.tpIngreso)
            Me.tcProducto.Controls.Add(Me.tpReporte)
            Me.tcProducto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcProducto.Location = New System.Drawing.Point(302, 419)
            Me.tcProducto.Name = "tcProducto"
            Me.tcProducto.SelectedIndex = 0
            Me.tcProducto.Size = New System.Drawing.Size(351, 110)
            Me.tcProducto.TabIndex = 135
            '
            'tpIngreso
            '
            Me.tpIngreso.Controls.Add(Me.Label7)
            Me.tpIngreso.Controls.Add(Me.Label1)
            Me.tpIngreso.Controls.Add(Me.lblValor)
            Me.tpIngreso.Controls.Add(Me.Label14)
            Me.tpIngreso.Controls.Add(Me.lblColor)
            Me.tpIngreso.Controls.Add(Me.lblMaterial)
            Me.tpIngreso.Controls.Add(Me.lblSecuencial)
            Me.tpIngreso.Controls.Add(Me.lblSubGrupo)
            Me.tpIngreso.Controls.Add(Me.lblGrupo)
            Me.tpIngreso.Controls.Add(Me.lblCategoría)
            Me.tpIngreso.Controls.Add(Me.lblMarca)
            Me.tpIngreso.Controls.Add(Me.lblModelo)
            Me.tpIngreso.Controls.Add(Me.lblUnidad)
            Me.tpIngreso.Controls.Add(Me.Label3)
            Me.tpIngreso.Location = New System.Drawing.Point(4, 22)
            Me.tpIngreso.Name = "tpIngreso"
            Me.tpIngreso.Padding = New System.Windows.Forms.Padding(3)
            Me.tpIngreso.Size = New System.Drawing.Size(343, 84)
            Me.tpIngreso.TabIndex = 0
            Me.tpIngreso.Text = "ITEMS BODEGA"
            Me.tpIngreso.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(662, 115)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 13)
            Me.Label7.TabIndex = 201
            Me.Label7.Text = "SERIE:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(845, 141)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(34, 13)
            Me.Label1.TabIndex = 191
            Me.Label1.Text = "P.V.P:"
            '
            'lblValor
            '
            Me.lblValor.AutoSize = True
            Me.lblValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValor.Location = New System.Drawing.Point(662, 141)
            Me.lblValor.Name = "lblValor"
            Me.lblValor.Size = New System.Drawing.Size(47, 13)
            Me.lblValor.TabIndex = 165
            Me.lblValor.Text = "COSTO:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(663, 141)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(51, 13)
            Me.Label3.TabIndex = 179
            Me.Label3.Text = "CÓDIGO:"
            Me.Label3.Visible = False
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(343, 84)
            Me.tpReporte.TabIndex = 2
            Me.tpReporte.Text = "REPORTE"
            '
            'chbxDescuento
            '
            Me.chbxDescuento.AutoSize = True
            Me.chbxDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.chbxDescuento.Enabled = False
            Me.chbxDescuento.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chbxDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.chbxDescuento.Location = New System.Drawing.Point(379, 105)
            Me.chbxDescuento.Name = "chbxDescuento"
            Me.chbxDescuento.Size = New System.Drawing.Size(116, 18)
            Me.chbxDescuento.TabIndex = 205
            Me.chbxDescuento.Text = "Lleva descuento?"
            Me.chbxDescuento.UseVisualStyleBackColor = False
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSerie.Enabled = False
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(669, 68)
            Me.txtSerie.Multiline = True
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(207, 20)
            Me.txtSerie.TabIndex = 202
            '
            'cbmSubGrupo2
            '
            Me.cbmSubGrupo2.BackColor = System.Drawing.Color.White
            Me.cbmSubGrupo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSubGrupo2.DropDownWidth = 177
            Me.cbmSubGrupo2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmSubGrupo2.ForeColor = System.Drawing.Color.Black
            Me.cbmSubGrupo2.FormattingEnabled = True
            Me.cbmSubGrupo2.Location = New System.Drawing.Point(486, 3)
            Me.cbmSubGrupo2.Name = "cbmSubGrupo2"
            Me.cbmSubGrupo2.Size = New System.Drawing.Size(120, 21)
            Me.cbmSubGrupo2.TabIndex = 200
            '
            'cbmGrupo2
            '
            Me.cbmGrupo2.BackColor = System.Drawing.Color.White
            Me.cbmGrupo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo2.DropDownWidth = 177
            Me.cbmGrupo2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo2.ForeColor = System.Drawing.Color.Black
            Me.cbmGrupo2.FormattingEnabled = True
            Me.cbmGrupo2.Location = New System.Drawing.Point(276, 1)
            Me.cbmGrupo2.Name = "cbmGrupo2"
            Me.cbmGrupo2.Size = New System.Drawing.Size(120, 21)
            Me.cbmGrupo2.TabIndex = 198
            '
            'cbmCategoria2
            '
            Me.cbmCategoria2.BackColor = System.Drawing.Color.White
            Me.cbmCategoria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoria2.DropDownWidth = 177
            Me.cbmCategoria2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoria2.ForeColor = System.Drawing.Color.Black
            Me.cbmCategoria2.FormattingEnabled = True
            Me.cbmCategoria2.Location = New System.Drawing.Point(93, 2)
            Me.cbmCategoria2.Name = "cbmCategoria2"
            Me.cbmCategoria2.Size = New System.Drawing.Size(120, 21)
            Me.cbmCategoria2.TabIndex = 196
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.ForeColor = System.Drawing.Color.Black
            Me.TextBox1.Location = New System.Drawing.Point(672, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(203, 21)
            Me.TextBox1.TabIndex = 194
            '
            'txtPvp
            '
            Me.txtPvp.BackColor = System.Drawing.Color.White
            Me.txtPvp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPvp.Enabled = False
            Me.txtPvp.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPvp.Location = New System.Drawing.Point(811, 93)
            Me.txtPvp.Name = "txtPvp"
            Me.txtPvp.Size = New System.Drawing.Size(64, 21)
            Me.txtPvp.TabIndex = 192
            '
            'lblCrearSubGrupo
            '
            Me.lblCrearSubGrupo.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearSubGrupo.Enabled = False
            Me.lblCrearSubGrupo.FlatAppearance.BorderSize = 0
            Me.lblCrearSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearSubGrupo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearSubGrupo.Image = CType(resources.GetObject("lblCrearSubGrupo.Image"), System.Drawing.Image)
            Me.lblCrearSubGrupo.Location = New System.Drawing.Point(543, 82)
            Me.lblCrearSubGrupo.Name = "lblCrearSubGrupo"
            Me.lblCrearSubGrupo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearSubGrupo.TabIndex = 189
            Me.lblCrearSubGrupo.UseVisualStyleBackColor = False
            '
            'lblCrearGrupo
            '
            Me.lblCrearGrupo.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearGrupo.Enabled = False
            Me.lblCrearGrupo.FlatAppearance.BorderSize = 0
            Me.lblCrearGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearGrupo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearGrupo.Image = CType(resources.GetObject("lblCrearGrupo.Image"), System.Drawing.Image)
            Me.lblCrearGrupo.Location = New System.Drawing.Point(542, 57)
            Me.lblCrearGrupo.Name = "lblCrearGrupo"
            Me.lblCrearGrupo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearGrupo.TabIndex = 188
            Me.lblCrearGrupo.UseVisualStyleBackColor = False
            '
            'lblCrearCategoria
            '
            Me.lblCrearCategoria.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearCategoria.Enabled = False
            Me.lblCrearCategoria.FlatAppearance.BorderSize = 0
            Me.lblCrearCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearCategoria.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearCategoria.ForeColor = System.Drawing.Color.Black
            Me.lblCrearCategoria.Image = CType(resources.GetObject("lblCrearCategoria.Image"), System.Drawing.Image)
            Me.lblCrearCategoria.Location = New System.Drawing.Point(542, 29)
            Me.lblCrearCategoria.Name = "lblCrearCategoria"
            Me.lblCrearCategoria.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearCategoria.TabIndex = 187
            Me.lblCrearCategoria.UseVisualStyleBackColor = False
            '
            'lblCrearUnidadMedida
            '
            Me.lblCrearUnidadMedida.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearUnidadMedida.Enabled = False
            Me.lblCrearUnidadMedida.FlatAppearance.BorderSize = 0
            Me.lblCrearUnidadMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearUnidadMedida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearUnidadMedida.ForeColor = System.Drawing.Color.Black
            Me.lblCrearUnidadMedida.Image = CType(resources.GetObject("lblCrearUnidadMedida.Image"), System.Drawing.Image)
            Me.lblCrearUnidadMedida.Location = New System.Drawing.Point(542, 1)
            Me.lblCrearUnidadMedida.Name = "lblCrearUnidadMedida"
            Me.lblCrearUnidadMedida.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearUnidadMedida.TabIndex = 186
            Me.lblCrearUnidadMedida.UseVisualStyleBackColor = False
            '
            'lblCrearColor
            '
            Me.lblCrearColor.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearColor.Enabled = False
            Me.lblCrearColor.FlatAppearance.BorderSize = 0
            Me.lblCrearColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearColor.ForeColor = System.Drawing.Color.Black
            Me.lblCrearColor.Image = CType(resources.GetObject("lblCrearColor.Image"), System.Drawing.Image)
            Me.lblCrearColor.Location = New System.Drawing.Point(225, 81)
            Me.lblCrearColor.Name = "lblCrearColor"
            Me.lblCrearColor.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearColor.TabIndex = 185
            Me.lblCrearColor.UseVisualStyleBackColor = False
            '
            'lblCrearMaterial
            '
            Me.lblCrearMaterial.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearMaterial.Enabled = False
            Me.lblCrearMaterial.FlatAppearance.BorderSize = 0
            Me.lblCrearMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearMaterial.ForeColor = System.Drawing.Color.Black
            Me.lblCrearMaterial.Image = CType(resources.GetObject("lblCrearMaterial.Image"), System.Drawing.Image)
            Me.lblCrearMaterial.Location = New System.Drawing.Point(225, 55)
            Me.lblCrearMaterial.Name = "lblCrearMaterial"
            Me.lblCrearMaterial.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearMaterial.TabIndex = 184
            Me.lblCrearMaterial.UseVisualStyleBackColor = False
            '
            'lblCrearModelo
            '
            Me.lblCrearModelo.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearModelo.Enabled = False
            Me.lblCrearModelo.FlatAppearance.BorderSize = 0
            Me.lblCrearModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearModelo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearModelo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearModelo.Image = CType(resources.GetObject("lblCrearModelo.Image"), System.Drawing.Image)
            Me.lblCrearModelo.Location = New System.Drawing.Point(225, 29)
            Me.lblCrearModelo.Name = "lblCrearModelo"
            Me.lblCrearModelo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearModelo.TabIndex = 183
            Me.lblCrearModelo.UseVisualStyleBackColor = False
            '
            'lblCrearMarca
            '
            Me.lblCrearMarca.BackColor = System.Drawing.Color.Transparent
            Me.lblCrearMarca.Enabled = False
            Me.lblCrearMarca.FlatAppearance.BorderSize = 0
            Me.lblCrearMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearMarca.ForeColor = System.Drawing.Color.Black
            Me.lblCrearMarca.Image = CType(resources.GetObject("lblCrearMarca.Image"), System.Drawing.Image)
            Me.lblCrearMarca.Location = New System.Drawing.Point(225, 2)
            Me.lblCrearMarca.Name = "lblCrearMarca"
            Me.lblCrearMarca.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearMarca.TabIndex = 182
            Me.lblCrearMarca.UseVisualStyleBackColor = False
            '
            'txtCosto
            '
            Me.txtCosto.BackColor = System.Drawing.Color.White
            Me.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCosto.Enabled = False
            Me.txtCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCosto.Location = New System.Drawing.Point(669, 93)
            Me.txtCosto.Name = "txtCosto"
            Me.txtCosto.Size = New System.Drawing.Size(61, 21)
            Me.txtCosto.TabIndex = 181
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmNuevo, Me.tsmGuardar, Me.tsmModificar, Me.tsmAjustar, Me.tsmCancelar, Me.ToolStripMenuItem2, Me.btnExportarGrupos})
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(912, 32)
            Me.msKardex.TabIndex = 178
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'tsmNuevo
            '
            Me.tsmNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmNuevo.Name = "tsmNuevo"
            Me.tsmNuevo.Size = New System.Drawing.Size(82, 28)
            Me.tsmNuevo.Text = "NUEVO"
            '
            'tsmGuardar
            '
            Me.tsmGuardar.Enabled = False
            Me.tsmGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmGuardar.Name = "tsmGuardar"
            Me.tsmGuardar.Size = New System.Drawing.Size(97, 28)
            Me.tsmGuardar.Text = "GUARDAR"
            '
            'tsmModificar
            '
            Me.tsmModificar.Enabled = False
            Me.tsmModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmModificar.Name = "tsmModificar"
            Me.tsmModificar.Size = New System.Drawing.Size(106, 28)
            Me.tsmModificar.Text = "MODIFICAR"
            '
            'tsmAjustar
            '
            Me.tsmAjustar.Enabled = False
            Me.tsmAjustar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmAjustar.Image = Global.syscisepro.My.Resources.Resources.inventory_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmAjustar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmAjustar.Name = "tsmAjustar"
            Me.tsmAjustar.Size = New System.Drawing.Size(128, 28)
            Me.tsmAjustar.Text = "AJUSTAR STOCK"
            '
            'tsmCancelar
            '
            Me.tsmCancelar.Enabled = False
            Me.tsmCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmCancelar.Name = "tsmCancelar"
            Me.tsmCancelar.Size = New System.Drawing.Size(103, 28)
            Me.tsmCancelar.Text = "CANCELAR"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(90, 28)
            Me.ToolStripMenuItem2.Text = "REPORTE"
            '
            'btnExportarGrupos
            '
            Me.btnExportarGrupos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarGrupos.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarGrupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportarGrupos.Name = "btnExportarGrupos"
            Me.btnExportarGrupos.Size = New System.Drawing.Size(99, 28)
            Me.btnExportarGrupos.Text = "EXPORTAR"
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvSecuencial.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvSecuencial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSecuencial.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgvSecuencial.GridColor = System.Drawing.SystemColors.Control
            Me.dgvSecuencial.Location = New System.Drawing.Point(7, 249)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(898, 409)
            Me.dgvSecuencial.TabIndex = 128
            '
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.Location = New System.Drawing.Point(733, 93)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(22, 21)
            Me.txtCódigo.TabIndex = 190
            Me.txtCódigo.Visible = False
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(914, 696)
            Me.KryptonNavigator1.TabIndex = 136
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox2)
            Me.KryptonPage1.Controls.Add(Me.KryptonLabel14)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.dgvSecuencial)
            Me.KryptonPage1.Controls.Add(Me.msKardex)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(912, 669)
            Me.KryptonPage1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.KryptonPage1.Text = "Items"
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "66B8AABBA49D48E2F3BBCD5F5246482C"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(7, 188)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel18)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.TextBox1)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmSubGrupo2)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmGrupo2)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.cbmCategoria2)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(898, 52)
            Me.KryptonGroupBox2.TabIndex = 207
            Me.KryptonGroupBox2.Values.Heading = "Busqueda"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(622, 3)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel18.TabIndex = 207
            Me.KryptonLabel18.Values.Text = "Buscar"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(411, 3)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel17.TabIndex = 206
            Me.KryptonLabel17.Values.Text = "Sub Grupo"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(225, 3)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel16.TabIndex = 206
            Me.KryptonLabel16.Values.Text = "Grupo"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel15.TabIndex = 206
            Me.KryptonLabel15.Values.Text = "Categoria"
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(12, 193)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(6, 2)
            Me.KryptonLabel14.TabIndex = 206
            Me.KryptonLabel14.Values.Text = ""
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(7, 36)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.chbxDescuento)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSerie)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPvp)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmMarca)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdSecuencial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmColor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCódigo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearSubGrupo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDescripción)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmMaterial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearGrupo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmModelo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearCategoria)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearMarca)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearUnidadMedida)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtSecuencial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearModelo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearMaterial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCrearColor)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmUnidadDeMedida)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmSubGrupo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmGrupo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCategoría)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(898, 150)
            Me.KryptonGroupBox1.TabIndex = 179
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(766, 93)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(32, 20)
            Me.KryptonLabel13.TabIndex = 203
            Me.KryptonLabel13.Values.Text = "PVP"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(592, 94)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel9.TabIndex = 193
            Me.KryptonLabel9.Values.Text = "Costo"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(592, 68)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(37, 20)
            Me.KryptonLabel10.TabIndex = 192
            Me.KryptonLabel10.Values.Text = "Serie"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(587, 29)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(74, 20)
            Me.KryptonLabel11.TabIndex = 191
            Me.KryptonLabel11.Values.Text = "Descripcion"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(587, 3)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel12.TabIndex = 190
            Me.KryptonLabel12.Values.Text = "Nombre"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(274, 81)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel5.TabIndex = 189
            Me.KryptonLabel5.Values.Text = "Sub Grupo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(274, 55)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel6.TabIndex = 188
            Me.KryptonLabel6.Values.Text = "Grupo"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(274, 29)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel7.TabIndex = 187
            Me.KryptonLabel7.Values.Text = "Categoria"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(274, 3)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(95, 20)
            Me.KryptonLabel8.TabIndex = 186
            Me.KryptonLabel8.Values.Text = "Unidad Medida"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(3, 81)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel4.TabIndex = 3
            Me.KryptonLabel4.Values.Text = "Color"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 55)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(55, 20)
            Me.KryptonLabel3.TabIndex = 2
            Me.KryptonLabel3.Values.Text = "Material"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel2.TabIndex = 1
            Me.KryptonLabel2.Values.Text = "Modelo"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(44, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Marca"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.crvInventarios)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(912, 669)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "91281EBD2BF64503379EA749CF7AF49F"
            '
            'crvInventarios
            '
            Me.crvInventarios.ActiveViewIndex = -1
            Me.crvInventarios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvInventarios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvInventarios.Location = New System.Drawing.Point(0, 0)
            Me.crvInventarios.Name = "crvInventarios"
            Me.crvInventarios.ShowLogo = False
            Me.crvInventarios.Size = New System.Drawing.Size(912, 669)
            Me.crvInventarios.TabIndex = 1
            Me.crvInventarios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormProductosBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(914, 696)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Controls.Add(Me.tcProducto)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormProductosBodega"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE PRODUCTOS DE BODEGA"
            Me.tcProducto.ResumeLayout(False)
            Me.tpIngreso.ResumeLayout(False)
            Me.tpIngreso.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            Me.KryptonPage1.PerformLayout()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            Me.KryptonGroupBox2.Panel.PerformLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cbmCategoría As System.Windows.Forms.ComboBox
        Friend WithEvents lblCategoría As System.Windows.Forms.Label
        Friend WithEvents cbmGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents lblGrupo As System.Windows.Forms.Label
        Friend WithEvents cbmSubGrupo As System.Windows.Forms.ComboBox
        Friend WithEvents lblSubGrupo As System.Windows.Forms.Label
        Friend WithEvents lblSecuencial As System.Windows.Forms.Label
        Friend WithEvents txtSecuencial As System.Windows.Forms.TextBox
        Friend WithEvents lblIdSecuencial As System.Windows.Forms.Label
        Friend WithEvents cbmMaterial As System.Windows.Forms.ComboBox
        Friend WithEvents lblMaterial As System.Windows.Forms.Label
        Friend WithEvents cbmModelo As System.Windows.Forms.ComboBox
        Friend WithEvents lblModelo As System.Windows.Forms.Label
        Friend WithEvents cbmMarca As System.Windows.Forms.ComboBox
        Friend WithEvents lblMarca As System.Windows.Forms.Label
        Friend WithEvents cbmColor As System.Windows.Forms.ComboBox
        Friend WithEvents lblColor As System.Windows.Forms.Label
        Friend WithEvents cbmUnidadDeMedida As System.Windows.Forms.ComboBox
        Friend WithEvents lblUnidad As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtDescripción As System.Windows.Forms.TextBox
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents tcProducto As System.Windows.Forms.TabControl
        Friend WithEvents tpIngreso As System.Windows.Forms.TabPage
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents dgvSecuencial As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtCosto As System.Windows.Forms.TextBox
        Friend WithEvents lblCrearMarca As System.Windows.Forms.Button
        Friend WithEvents lblCrearColor As System.Windows.Forms.Button
        Friend WithEvents lblCrearMaterial As System.Windows.Forms.Button
        Friend WithEvents lblCrearModelo As System.Windows.Forms.Button
        Friend WithEvents lblCrearSubGrupo As System.Windows.Forms.Button
        Friend WithEvents lblCrearGrupo As System.Windows.Forms.Button
        Friend WithEvents lblCrearCategoria As System.Windows.Forms.Button
        Friend WithEvents lblCrearUnidadMedida As System.Windows.Forms.Button
        Friend WithEvents txtCódigo As System.Windows.Forms.TextBox
        Friend WithEvents txtPvp As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents lblValor As System.Windows.Forms.Label
        Friend WithEvents cbmSubGrupo2 As System.Windows.Forms.ComboBox
        Friend WithEvents cbmGrupo2 As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCategoria2 As System.Windows.Forms.ComboBox
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnExportarGrupos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmAjustar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents chbxDescuento As CheckBox
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents crvInventarios As CrystalDecisions.Windows.Forms.CrystalReportViewer
    End Class
End Namespace