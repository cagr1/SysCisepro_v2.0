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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.txtSerie = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbmSubGrupo2 = New System.Windows.Forms.ComboBox()
            Me.cbmGrupo2 = New System.Windows.Forms.ComboBox()
            Me.cbmCategoria2 = New System.Windows.Forms.ComboBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtPvp = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
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
            Me.lblValor = New System.Windows.Forms.Label()
            Me.dgvSecuencial = New System.Windows.Forms.DataGridView()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.crvInventarios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcProducto.SuspendLayout()
            Me.tpIngreso.SuspendLayout()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvSecuencial, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpReporte.SuspendLayout()
            Me.SuspendLayout()
            '
            'cbmCategoría
            '
            Me.cbmCategoría.BackColor = System.Drawing.Color.White
            Me.cbmCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoría.DropDownWidth = 177
            Me.cbmCategoría.Enabled = False
            Me.cbmCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmCategoría.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoría.ForeColor = System.Drawing.Color.Black
            Me.cbmCategoría.FormattingEnabled = True
            Me.cbmCategoría.Location = New System.Drawing.Point(424, 72)
            Me.cbmCategoría.Name = "cbmCategoría"
            Me.cbmCategoría.Size = New System.Drawing.Size(176, 21)
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
            Me.cbmGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.ForeColor = System.Drawing.Color.Black
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(424, 104)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(176, 21)
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
            Me.cbmSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmSubGrupo.ForeColor = System.Drawing.Color.Black
            Me.cbmSubGrupo.FormattingEnabled = True
            Me.cbmSubGrupo.Location = New System.Drawing.Point(424, 136)
            Me.cbmSubGrupo.Name = "cbmSubGrupo"
            Me.cbmSubGrupo.Size = New System.Drawing.Size(176, 21)
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
            Me.txtSecuencial.Location = New System.Drawing.Point(742, 35)
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
            Me.lblIdSecuencial.Location = New System.Drawing.Point(912, 38)
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
            Me.cbmMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMaterial.ForeColor = System.Drawing.Color.Black
            Me.cbmMaterial.FormattingEnabled = True
            Me.cbmMaterial.Location = New System.Drawing.Point(82, 104)
            Me.cbmMaterial.Name = "cbmMaterial"
            Me.cbmMaterial.Size = New System.Drawing.Size(177, 21)
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
            Me.cbmModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmModelo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmModelo.ForeColor = System.Drawing.Color.Black
            Me.cbmModelo.FormattingEnabled = True
            Me.cbmModelo.Location = New System.Drawing.Point(82, 72)
            Me.cbmModelo.Name = "cbmModelo"
            Me.cbmModelo.Size = New System.Drawing.Size(177, 21)
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
            Me.cbmMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMarca.ForeColor = System.Drawing.Color.Black
            Me.cbmMarca.FormattingEnabled = True
            Me.cbmMarca.Location = New System.Drawing.Point(82, 40)
            Me.cbmMarca.Name = "cbmMarca"
            Me.cbmMarca.Size = New System.Drawing.Size(177, 21)
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
            Me.cbmColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmColor.ForeColor = System.Drawing.Color.Black
            Me.cbmColor.FormattingEnabled = True
            Me.cbmColor.Location = New System.Drawing.Point(82, 136)
            Me.cbmColor.Name = "cbmColor"
            Me.cbmColor.Size = New System.Drawing.Size(177, 21)
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
            Me.cbmUnidadDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmUnidadDeMedida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmUnidadDeMedida.ForeColor = System.Drawing.Color.Black
            Me.cbmUnidadDeMedida.FormattingEnabled = True
            Me.cbmUnidadDeMedida.Location = New System.Drawing.Point(423, 40)
            Me.cbmUnidadDeMedida.Name = "cbmUnidadDeMedida"
            Me.cbmUnidadDeMedida.Size = New System.Drawing.Size(177, 21)
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
            Me.txtDescripción.Location = New System.Drawing.Point(742, 58)
            Me.txtDescripción.Multiline = True
            Me.txtDescripción.Name = "txtDescripción"
            Me.txtDescripción.Size = New System.Drawing.Size(208, 51)
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
            Me.tcProducto.Location = New System.Drawing.Point(3, 6)
            Me.tcProducto.Name = "tcProducto"
            Me.tcProducto.SelectedIndex = 0
            Me.tcProducto.Size = New System.Drawing.Size(972, 689)
            Me.tcProducto.TabIndex = 135
            '
            'tpIngreso
            '
            Me.tpIngreso.Controls.Add(Me.txtSerie)
            Me.tpIngreso.Controls.Add(Me.Label7)
            Me.tpIngreso.Controls.Add(Me.cbmSubGrupo2)
            Me.tpIngreso.Controls.Add(Me.cbmGrupo2)
            Me.tpIngreso.Controls.Add(Me.cbmCategoria2)
            Me.tpIngreso.Controls.Add(Me.TextBox1)
            Me.tpIngreso.Controls.Add(Me.Label2)
            Me.tpIngreso.Controls.Add(Me.txtPvp)
            Me.tpIngreso.Controls.Add(Me.Label1)
            Me.tpIngreso.Controls.Add(Me.lblCrearSubGrupo)
            Me.tpIngreso.Controls.Add(Me.lblCrearGrupo)
            Me.tpIngreso.Controls.Add(Me.lblCrearCategoria)
            Me.tpIngreso.Controls.Add(Me.lblCrearUnidadMedida)
            Me.tpIngreso.Controls.Add(Me.lblCrearColor)
            Me.tpIngreso.Controls.Add(Me.lblCrearMaterial)
            Me.tpIngreso.Controls.Add(Me.lblCrearModelo)
            Me.tpIngreso.Controls.Add(Me.lblCrearMarca)
            Me.tpIngreso.Controls.Add(Me.txtCosto)
            Me.tpIngreso.Controls.Add(Me.msKardex)
            Me.tpIngreso.Controls.Add(Me.lblValor)
            Me.tpIngreso.Controls.Add(Me.dgvSecuencial)
            Me.tpIngreso.Controls.Add(Me.Label14)
            Me.tpIngreso.Controls.Add(Me.lblColor)
            Me.tpIngreso.Controls.Add(Me.txtDescripción)
            Me.tpIngreso.Controls.Add(Me.lblMaterial)
            Me.tpIngreso.Controls.Add(Me.lblSecuencial)
            Me.tpIngreso.Controls.Add(Me.lblSubGrupo)
            Me.tpIngreso.Controls.Add(Me.lblGrupo)
            Me.tpIngreso.Controls.Add(Me.lblCategoría)
            Me.tpIngreso.Controls.Add(Me.txtSecuencial)
            Me.tpIngreso.Controls.Add(Me.lblMarca)
            Me.tpIngreso.Controls.Add(Me.cbmMarca)
            Me.tpIngreso.Controls.Add(Me.lblModelo)
            Me.tpIngreso.Controls.Add(Me.cbmModelo)
            Me.tpIngreso.Controls.Add(Me.cbmMaterial)
            Me.tpIngreso.Controls.Add(Me.cbmUnidadDeMedida)
            Me.tpIngreso.Controls.Add(Me.cbmCategoría)
            Me.tpIngreso.Controls.Add(Me.cbmGrupo)
            Me.tpIngreso.Controls.Add(Me.cbmSubGrupo)
            Me.tpIngreso.Controls.Add(Me.cbmColor)
            Me.tpIngreso.Controls.Add(Me.lblIdSecuencial)
            Me.tpIngreso.Controls.Add(Me.lblUnidad)
            Me.tpIngreso.Controls.Add(Me.Label3)
            Me.tpIngreso.Controls.Add(Me.txtCódigo)
            Me.tpIngreso.Controls.Add(Me.Label5)
            Me.tpIngreso.Controls.Add(Me.Label6)
            Me.tpIngreso.Controls.Add(Me.Label4)
            Me.tpIngreso.Location = New System.Drawing.Point(4, 22)
            Me.tpIngreso.Name = "tpIngreso"
            Me.tpIngreso.Padding = New System.Windows.Forms.Padding(3)
            Me.tpIngreso.Size = New System.Drawing.Size(964, 663)
            Me.tpIngreso.TabIndex = 0
            Me.tpIngreso.Text = "ITEMS BODEGA"
            Me.tpIngreso.UseVisualStyleBackColor = True
            '
            'txtSerie
            '
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSerie.Enabled = False
            Me.txtSerie.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(742, 112)
            Me.txtSerie.Multiline = True
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(207, 20)
            Me.txtSerie.TabIndex = 202
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(666, 115)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 13)
            Me.Label7.TabIndex = 201
            Me.Label7.Text = "SERIE:"
            '
            'cbmSubGrupo2
            '
            Me.cbmSubGrupo2.BackColor = System.Drawing.Color.White
            Me.cbmSubGrupo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmSubGrupo2.DropDownWidth = 177
            Me.cbmSubGrupo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmSubGrupo2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmSubGrupo2.ForeColor = System.Drawing.Color.Black
            Me.cbmSubGrupo2.FormattingEnabled = True
            Me.cbmSubGrupo2.Location = New System.Drawing.Point(520, 182)
            Me.cbmSubGrupo2.Name = "cbmSubGrupo2"
            Me.cbmSubGrupo2.Size = New System.Drawing.Size(120, 21)
            Me.cbmSubGrupo2.TabIndex = 200
            '
            'cbmGrupo2
            '
            Me.cbmGrupo2.BackColor = System.Drawing.Color.White
            Me.cbmGrupo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmGrupo2.DropDownWidth = 177
            Me.cbmGrupo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmGrupo2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo2.ForeColor = System.Drawing.Color.Black
            Me.cbmGrupo2.FormattingEnabled = True
            Me.cbmGrupo2.Location = New System.Drawing.Point(311, 182)
            Me.cbmGrupo2.Name = "cbmGrupo2"
            Me.cbmGrupo2.Size = New System.Drawing.Size(120, 21)
            Me.cbmGrupo2.TabIndex = 198
            '
            'cbmCategoria2
            '
            Me.cbmCategoria2.BackColor = System.Drawing.Color.White
            Me.cbmCategoria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCategoria2.DropDownWidth = 177
            Me.cbmCategoria2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbmCategoria2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCategoria2.ForeColor = System.Drawing.Color.Black
            Me.cbmCategoria2.FormattingEnabled = True
            Me.cbmCategoria2.Location = New System.Drawing.Point(124, 182)
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
            Me.TextBox1.Location = New System.Drawing.Point(707, 182)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(249, 21)
            Me.TextBox1.TabIndex = 194
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(662, 185)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 193
            Me.Label2.Text = "FILTRO:"
            '
            'txtPvp
            '
            Me.txtPvp.BackColor = System.Drawing.Color.White
            Me.txtPvp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPvp.Enabled = False
            Me.txtPvp.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPvp.Location = New System.Drawing.Point(886, 136)
            Me.txtPvp.Name = "txtPvp"
            Me.txtPvp.Size = New System.Drawing.Size(64, 21)
            Me.txtPvp.TabIndex = 192
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
            'lblCrearSubGrupo
            '
            Me.lblCrearSubGrupo.BackColor = System.Drawing.Color.White
            Me.lblCrearSubGrupo.Enabled = False
            Me.lblCrearSubGrupo.FlatAppearance.BorderSize = 0
            Me.lblCrearSubGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearSubGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearSubGrupo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearSubGrupo.Image = CType(resources.GetObject("lblCrearSubGrupo.Image"), System.Drawing.Image)
            Me.lblCrearSubGrupo.Location = New System.Drawing.Point(610, 133)
            Me.lblCrearSubGrupo.Name = "lblCrearSubGrupo"
            Me.lblCrearSubGrupo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearSubGrupo.TabIndex = 189
            Me.lblCrearSubGrupo.UseVisualStyleBackColor = False
            '
            'lblCrearGrupo
            '
            Me.lblCrearGrupo.BackColor = System.Drawing.Color.White
            Me.lblCrearGrupo.Enabled = False
            Me.lblCrearGrupo.FlatAppearance.BorderSize = 0
            Me.lblCrearGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearGrupo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearGrupo.Image = CType(resources.GetObject("lblCrearGrupo.Image"), System.Drawing.Image)
            Me.lblCrearGrupo.Location = New System.Drawing.Point(610, 101)
            Me.lblCrearGrupo.Name = "lblCrearGrupo"
            Me.lblCrearGrupo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearGrupo.TabIndex = 188
            Me.lblCrearGrupo.UseVisualStyleBackColor = False
            '
            'lblCrearCategoria
            '
            Me.lblCrearCategoria.BackColor = System.Drawing.Color.White
            Me.lblCrearCategoria.Enabled = False
            Me.lblCrearCategoria.FlatAppearance.BorderSize = 0
            Me.lblCrearCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearCategoria.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearCategoria.ForeColor = System.Drawing.Color.Black
            Me.lblCrearCategoria.Image = CType(resources.GetObject("lblCrearCategoria.Image"), System.Drawing.Image)
            Me.lblCrearCategoria.Location = New System.Drawing.Point(610, 69)
            Me.lblCrearCategoria.Name = "lblCrearCategoria"
            Me.lblCrearCategoria.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearCategoria.TabIndex = 187
            Me.lblCrearCategoria.UseVisualStyleBackColor = False
            '
            'lblCrearUnidadMedida
            '
            Me.lblCrearUnidadMedida.BackColor = System.Drawing.Color.White
            Me.lblCrearUnidadMedida.Enabled = False
            Me.lblCrearUnidadMedida.FlatAppearance.BorderSize = 0
            Me.lblCrearUnidadMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearUnidadMedida.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearUnidadMedida.ForeColor = System.Drawing.Color.Black
            Me.lblCrearUnidadMedida.Image = CType(resources.GetObject("lblCrearUnidadMedida.Image"), System.Drawing.Image)
            Me.lblCrearUnidadMedida.Location = New System.Drawing.Point(609, 37)
            Me.lblCrearUnidadMedida.Name = "lblCrearUnidadMedida"
            Me.lblCrearUnidadMedida.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearUnidadMedida.TabIndex = 186
            Me.lblCrearUnidadMedida.UseVisualStyleBackColor = False
            '
            'lblCrearColor
            '
            Me.lblCrearColor.BackColor = System.Drawing.Color.White
            Me.lblCrearColor.Enabled = False
            Me.lblCrearColor.FlatAppearance.BorderSize = 0
            Me.lblCrearColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearColor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearColor.ForeColor = System.Drawing.Color.Black
            Me.lblCrearColor.Image = CType(resources.GetObject("lblCrearColor.Image"), System.Drawing.Image)
            Me.lblCrearColor.Location = New System.Drawing.Point(267, 134)
            Me.lblCrearColor.Name = "lblCrearColor"
            Me.lblCrearColor.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearColor.TabIndex = 185
            Me.lblCrearColor.UseVisualStyleBackColor = False
            '
            'lblCrearMaterial
            '
            Me.lblCrearMaterial.BackColor = System.Drawing.Color.White
            Me.lblCrearMaterial.Enabled = False
            Me.lblCrearMaterial.FlatAppearance.BorderSize = 0
            Me.lblCrearMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearMaterial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearMaterial.ForeColor = System.Drawing.Color.Black
            Me.lblCrearMaterial.Image = CType(resources.GetObject("lblCrearMaterial.Image"), System.Drawing.Image)
            Me.lblCrearMaterial.Location = New System.Drawing.Point(267, 102)
            Me.lblCrearMaterial.Name = "lblCrearMaterial"
            Me.lblCrearMaterial.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearMaterial.TabIndex = 184
            Me.lblCrearMaterial.UseVisualStyleBackColor = False
            '
            'lblCrearModelo
            '
            Me.lblCrearModelo.BackColor = System.Drawing.Color.White
            Me.lblCrearModelo.Enabled = False
            Me.lblCrearModelo.FlatAppearance.BorderSize = 0
            Me.lblCrearModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearModelo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearModelo.ForeColor = System.Drawing.Color.Black
            Me.lblCrearModelo.Image = CType(resources.GetObject("lblCrearModelo.Image"), System.Drawing.Image)
            Me.lblCrearModelo.Location = New System.Drawing.Point(267, 70)
            Me.lblCrearModelo.Name = "lblCrearModelo"
            Me.lblCrearModelo.Size = New System.Drawing.Size(26, 26)
            Me.lblCrearModelo.TabIndex = 183
            Me.lblCrearModelo.UseVisualStyleBackColor = False
            '
            'lblCrearMarca
            '
            Me.lblCrearMarca.BackColor = System.Drawing.Color.White
            Me.lblCrearMarca.Enabled = False
            Me.lblCrearMarca.FlatAppearance.BorderSize = 0
            Me.lblCrearMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.lblCrearMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lblCrearMarca.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCrearMarca.ForeColor = System.Drawing.Color.Black
            Me.lblCrearMarca.Image = CType(resources.GetObject("lblCrearMarca.Image"), System.Drawing.Image)
            Me.lblCrearMarca.Location = New System.Drawing.Point(267, 38)
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
            Me.txtCosto.Location = New System.Drawing.Point(742, 135)
            Me.txtCosto.Name = "txtCosto"
            Me.txtCosto.Size = New System.Drawing.Size(61, 21)
            Me.txtCosto.TabIndex = 181
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmNuevo, Me.tsmGuardar, Me.tsmModificar, Me.tsmAjustar, Me.tsmCancelar, Me.ToolStripMenuItem2, Me.btnExportarGrupos})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(3, 3)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(958, 32)
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
            'lblValor
            '
            Me.lblValor.AutoSize = True
            Me.lblValor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblValor.Location = New System.Drawing.Point(666, 141)
            Me.lblValor.Name = "lblValor"
            Me.lblValor.Size = New System.Drawing.Size(47, 13)
            Me.lblValor.TabIndex = 165
            Me.lblValor.Text = "COSTO:"
            '
            'dgvSecuencial
            '
            Me.dgvSecuencial.AllowUserToAddRows = False
            Me.dgvSecuencial.AllowUserToDeleteRows = False
            Me.dgvSecuencial.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSecuencial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSecuencial.BackgroundColor = System.Drawing.Color.White
            Me.dgvSecuencial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSecuencial.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSecuencial.GridColor = System.Drawing.SystemColors.Control
            Me.dgvSecuencial.Location = New System.Drawing.Point(6, 206)
            Me.dgvSecuencial.MultiSelect = False
            Me.dgvSecuencial.Name = "dgvSecuencial"
            Me.dgvSecuencial.ReadOnly = True
            Me.dgvSecuencial.RowHeadersVisible = False
            Me.dgvSecuencial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            Me.dgvSecuencial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSecuencial.Size = New System.Drawing.Size(952, 451)
            Me.dgvSecuencial.TabIndex = 128
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
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.Location = New System.Drawing.Point(742, 135)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(61, 21)
            Me.txtCódigo.TabIndex = 190
            Me.txtCódigo.Visible = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(268, 186)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 197
            Me.Label5.Text = "GRUPO"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(453, 186)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(68, 13)
            Me.Label6.TabIndex = 199
            Me.Label6.Text = "SUB GRUPO"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(11, 186)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(111, 13)
            Me.Label4.TabIndex = 195
            Me.Label4.Text = "BUSCAR CATEGORÍA"
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.crvInventarios)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(964, 663)
            Me.tpReporte.TabIndex = 2
            Me.tpReporte.Text = "REPORTE"
            '
            'crvInventarios
            '
            Me.crvInventarios.ActiveViewIndex = -1
            Me.crvInventarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvInventarios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvInventarios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvInventarios.Location = New System.Drawing.Point(3, 3)
            Me.crvInventarios.Name = "crvInventarios"
            Me.crvInventarios.Size = New System.Drawing.Size(958, 657)
            Me.crvInventarios.TabIndex = 0
            Me.crvInventarios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormProductosBodega
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(974, 696)
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
            Me.tpReporte.ResumeLayout(False)
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
        Friend WithEvents crvInventarios As CrystalDecisions.Windows.Forms.CrystalReportViewer
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
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblValor As System.Windows.Forms.Label
        Friend WithEvents cbmSubGrupo2 As System.Windows.Forms.ComboBox
        Friend WithEvents cbmGrupo2 As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCategoria2 As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtSerie As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnExportarGrupos As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmAjustar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace