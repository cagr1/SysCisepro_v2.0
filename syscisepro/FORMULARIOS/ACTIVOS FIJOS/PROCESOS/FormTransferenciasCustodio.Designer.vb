Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormTransferenciasActivosFijos
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
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransferenciasActivosFijos))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtIdTransferencia = New System.Windows.Forms.TextBox()
            Me.gbParámetros = New System.Windows.Forms.GroupBox()
            Me.dgvBusquedaPersonal = New System.Windows.Forms.DataGridView()
            Me.rbNombre = New System.Windows.Forms.RadioButton()
            Me.rbCédula = New System.Windows.Forms.RadioButton()
            Me.txtBusqueda = New System.Windows.Forms.TextBox()
            Me.rbApellido = New System.Windows.Forms.RadioButton()
            Me.txtIdCustodioNuevo = New System.Windows.Forms.TextBox()
            Me.txtNombreCustodioNuevo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbEstadoActual = New System.Windows.Forms.ComboBox()
            Me.dgvActivoFijo = New System.Windows.Forms.DataGridView()
            Me.btnEliminarActivoFijoTransferencia = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblSucursal = New System.Windows.Forms.Label()
            Me.lblEmpresa = New System.Windows.Forms.Label()
            Me.cbArea = New System.Windows.Forms.ComboBox()
            Me.cbgerencias = New System.Windows.Forms.ComboBox()
            Me.cbSucursal = New System.Windows.Forms.ComboBox()
            Me.cbEmpresa = New System.Windows.Forms.ComboBox()
            Me.rbNombreCustodio = New System.Windows.Forms.RadioButton()
            Me.btnAgregarActivoFijo = New System.Windows.Forms.Button()
            Me.txtBusquedaActivoFijo = New System.Windows.Forms.TextBox()
            Me.rbCodigoActivo = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgvTransferencias = New System.Windows.Forms.DataGridView()
            Me.ID_TRANSFERENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CODIGO_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NOMBRE_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ESTADO_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_SUCURSAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_GERENCIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_AREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_PERSONAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_ACTIVO_FIJO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.txtFechaTransferencia = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombreCustodioAnterior = New System.Windows.Forms.TextBox()
            Me.txtUbicacionNueva = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtUbicacionAnterior = New System.Windows.Forms.TextBox()
            Me.txtIdCustodioAnterior = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtRazon = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbAutoriza = New System.Windows.Forms.ComboBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ButtonNuevoRegistro = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarTransferencia = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarParametroDocumentos = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbParámetros.SuspendLayout()
            CType(Me.dgvBusquedaPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(808, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(19, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "N°"
            '
            'txtIdTransferencia
            '
            Me.txtIdTransferencia.Enabled = False
            Me.txtIdTransferencia.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.txtIdTransferencia.Location = New System.Drawing.Point(845, 41)
            Me.txtIdTransferencia.Name = "txtIdTransferencia"
            Me.txtIdTransferencia.Size = New System.Drawing.Size(100, 23)
            Me.txtIdTransferencia.TabIndex = 1
            '
            'gbParámetros
            '
            Me.gbParámetros.BackColor = System.Drawing.Color.White
            Me.gbParámetros.Controls.Add(Me.dgvBusquedaPersonal)
            Me.gbParámetros.Controls.Add(Me.rbNombre)
            Me.gbParámetros.Controls.Add(Me.rbCédula)
            Me.gbParámetros.Controls.Add(Me.txtBusqueda)
            Me.gbParámetros.Controls.Add(Me.rbApellido)
            Me.gbParámetros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParámetros.Location = New System.Drawing.Point(3, 148)
            Me.gbParámetros.Name = "gbParámetros"
            Me.gbParámetros.Size = New System.Drawing.Size(1005, 133)
            Me.gbParámetros.TabIndex = 41
            Me.gbParámetros.TabStop = False
            Me.gbParámetros.Text = "BUSQUEDA CUSTODIO"
            '
            'dgvBusquedaPersonal
            '
            Me.dgvBusquedaPersonal.AllowUserToAddRows = False
            Me.dgvBusquedaPersonal.AllowUserToDeleteRows = False
            Me.dgvBusquedaPersonal.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvBusquedaPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvBusquedaPersonal.BackgroundColor = System.Drawing.Color.White
            Me.dgvBusquedaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvBusquedaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvBusquedaPersonal.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvBusquedaPersonal.Location = New System.Drawing.Point(7, 38)
            Me.dgvBusquedaPersonal.MultiSelect = False
            Me.dgvBusquedaPersonal.Name = "dgvBusquedaPersonal"
            Me.dgvBusquedaPersonal.RowHeadersVisible = False
            Me.dgvBusquedaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvBusquedaPersonal.Size = New System.Drawing.Size(992, 90)
            Me.dgvBusquedaPersonal.TabIndex = 40
            '
            'rbNombre
            '
            Me.rbNombre.AutoSize = True
            Me.rbNombre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNombre.Location = New System.Drawing.Point(103, 15)
            Me.rbNombre.Name = "rbNombre"
            Me.rbNombre.Size = New System.Drawing.Size(70, 17)
            Me.rbNombre.TabIndex = 37
            Me.rbNombre.TabStop = True
            Me.rbNombre.Text = "NOMBRES"
            Me.rbNombre.UseVisualStyleBackColor = True
            '
            'rbCédula
            '
            Me.rbCédula.AutoSize = True
            Me.rbCédula.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCédula.Location = New System.Drawing.Point(192, 15)
            Me.rbCédula.Name = "rbCédula"
            Me.rbCédula.Size = New System.Drawing.Size(61, 17)
            Me.rbCédula.TabIndex = 39
            Me.rbCédula.TabStop = True
            Me.rbCédula.Text = "CÉDULA"
            Me.rbCédula.UseVisualStyleBackColor = True
            '
            'txtBusqueda
            '
            Me.txtBusqueda.Location = New System.Drawing.Point(283, 13)
            Me.txtBusqueda.Name = "txtBusqueda"
            Me.txtBusqueda.Size = New System.Drawing.Size(203, 21)
            Me.txtBusqueda.TabIndex = 35
            '
            'rbApellido
            '
            Me.rbApellido.AutoSize = True
            Me.rbApellido.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbApellido.Location = New System.Drawing.Point(6, 15)
            Me.rbApellido.Name = "rbApellido"
            Me.rbApellido.Size = New System.Drawing.Size(74, 17)
            Me.rbApellido.TabIndex = 38
            Me.rbApellido.TabStop = True
            Me.rbApellido.Text = "APELLIDOS"
            Me.rbApellido.UseVisualStyleBackColor = True
            '
            'txtIdCustodioNuevo
            '
            Me.txtIdCustodioNuevo.Enabled = False
            Me.txtIdCustodioNuevo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCustodioNuevo.Location = New System.Drawing.Point(138, 96)
            Me.txtIdCustodioNuevo.Name = "txtIdCustodioNuevo"
            Me.txtIdCustodioNuevo.Size = New System.Drawing.Size(85, 23)
            Me.txtIdCustodioNuevo.TabIndex = 42
            '
            'txtNombreCustodioNuevo
            '
            Me.txtNombreCustodioNuevo.Enabled = False
            Me.txtNombreCustodioNuevo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCustodioNuevo.Location = New System.Drawing.Point(229, 96)
            Me.txtNombreCustodioNuevo.Name = "txtNombreCustodioNuevo"
            Me.txtNombreCustodioNuevo.Size = New System.Drawing.Size(337, 23)
            Me.txtNombreCustodioNuevo.TabIndex = 43
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(7, 97)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(108, 15)
            Me.Label2.TabIndex = 44
            Me.Label2.Text = "NUEVO CUSTODIO:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.cbEstadoActual)
            Me.GroupBox1.Controls.Add(Me.dgvActivoFijo)
            Me.GroupBox1.Controls.Add(Me.btnEliminarActivoFijoTransferencia)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.lblSucursal)
            Me.GroupBox1.Controls.Add(Me.lblEmpresa)
            Me.GroupBox1.Controls.Add(Me.cbArea)
            Me.GroupBox1.Controls.Add(Me.cbgerencias)
            Me.GroupBox1.Controls.Add(Me.cbSucursal)
            Me.GroupBox1.Controls.Add(Me.cbEmpresa)
            Me.GroupBox1.Controls.Add(Me.rbNombreCustodio)
            Me.GroupBox1.Controls.Add(Me.btnAgregarActivoFijo)
            Me.GroupBox1.Controls.Add(Me.txtBusquedaActivoFijo)
            Me.GroupBox1.Controls.Add(Me.rbCodigoActivo)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 288)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1005, 189)
            Me.GroupBox1.TabIndex = 42
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA ACTIVO FIJO"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.Label11.Location = New System.Drawing.Point(693, 21)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(91, 15)
            Me.Label11.TabIndex = 90
            Me.Label11.Text = "ESTADO ACTUAL"
            '
            'cbEstadoActual
            '
            Me.cbEstadoActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbEstadoActual.Enabled = False
            Me.cbEstadoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbEstadoActual.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbEstadoActual.FormattingEnabled = True
            Me.cbEstadoActual.Items.AddRange(New Object() {"BUENO", "REGULAR", "MALO"})
            Me.cbEstadoActual.Location = New System.Drawing.Point(696, 38)
            Me.cbEstadoActual.Name = "cbEstadoActual"
            Me.cbEstadoActual.Size = New System.Drawing.Size(125, 23)
            Me.cbEstadoActual.TabIndex = 89
            '
            'dgvActivoFijo
            '
            Me.dgvActivoFijo.AllowUserToAddRows = False
            Me.dgvActivoFijo.AllowUserToDeleteRows = False
            Me.dgvActivoFijo.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivoFijo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvActivoFijo.BackgroundColor = System.Drawing.Color.White
            Me.dgvActivoFijo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvActivoFijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActivoFijo.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvActivoFijo.Location = New System.Drawing.Point(7, 66)
            Me.dgvActivoFijo.MultiSelect = False
            Me.dgvActivoFijo.Name = "dgvActivoFijo"
            Me.dgvActivoFijo.RowHeadersVisible = False
            Me.dgvActivoFijo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivoFijo.Size = New System.Drawing.Size(992, 117)
            Me.dgvActivoFijo.TabIndex = 88
            '
            'btnEliminarActivoFijoTransferencia
            '
            Me.btnEliminarActivoFijoTransferencia.BackColor = System.Drawing.Color.White
            Me.btnEliminarActivoFijoTransferencia.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEliminarActivoFijoTransferencia.Enabled = False
            Me.btnEliminarActivoFijoTransferencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btnEliminarActivoFijoTransferencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
            Me.btnEliminarActivoFijoTransferencia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btnEliminarActivoFijoTransferencia.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarActivoFijoTransferencia.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminarActivoFijoTransferencia.Location = New System.Drawing.Point(890, 24)
            Me.btnEliminarActivoFijoTransferencia.Name = "btnEliminarActivoFijoTransferencia"
            Me.btnEliminarActivoFijoTransferencia.Size = New System.Drawing.Size(41, 30)
            Me.btnEliminarActivoFijoTransferencia.TabIndex = 87
            Me.btnEliminarActivoFijoTransferencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEliminarActivoFijoTransferencia.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.Label5.Location = New System.Drawing.Point(431, 41)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(37, 15)
            Me.Label5.TabIndex = 86
            Me.Label5.Text = "AREA:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.Label4.Location = New System.Drawing.Point(431, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(63, 15)
            Me.Label4.TabIndex = 85
            Me.Label4.Text = "GERENCIA:"
            '
            'lblSucursal
            '
            Me.lblSucursal.AutoSize = True
            Me.lblSucursal.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.lblSucursal.Location = New System.Drawing.Point(217, 43)
            Me.lblSucursal.Name = "lblSucursal"
            Me.lblSucursal.Size = New System.Drawing.Size(64, 15)
            Me.lblSucursal.TabIndex = 84
            Me.lblSucursal.Text = "SUCURSAL:"
            '
            'lblEmpresa
            '
            Me.lblEmpresa.AutoSize = True
            Me.lblEmpresa.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.lblEmpresa.Location = New System.Drawing.Point(217, 16)
            Me.lblEmpresa.Name = "lblEmpresa"
            Me.lblEmpresa.Size = New System.Drawing.Size(60, 15)
            Me.lblEmpresa.TabIndex = 83
            Me.lblEmpresa.Text = "EMPRESA:"
            '
            'cbArea
            '
            Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbArea.Enabled = False
            Me.cbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbArea.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbArea.FormattingEnabled = True
            Me.cbArea.Location = New System.Drawing.Point(500, 40)
            Me.cbArea.Name = "cbArea"
            Me.cbArea.Size = New System.Drawing.Size(178, 23)
            Me.cbArea.TabIndex = 82
            '
            'cbgerencias
            '
            Me.cbgerencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbgerencias.Enabled = False
            Me.cbgerencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbgerencias.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbgerencias.FormattingEnabled = True
            Me.cbgerencias.Location = New System.Drawing.Point(500, 13)
            Me.cbgerencias.Name = "cbgerencias"
            Me.cbgerencias.Size = New System.Drawing.Size(178, 23)
            Me.cbgerencias.TabIndex = 81
            '
            'cbSucursal
            '
            Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSucursal.Enabled = False
            Me.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbSucursal.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbSucursal.FormattingEnabled = True
            Me.cbSucursal.Location = New System.Drawing.Point(283, 39)
            Me.cbSucursal.Name = "cbSucursal"
            Me.cbSucursal.Size = New System.Drawing.Size(142, 23)
            Me.cbSucursal.TabIndex = 80
            '
            'cbEmpresa
            '
            Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbEmpresa.Enabled = False
            Me.cbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbEmpresa.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbEmpresa.FormattingEnabled = True
            Me.cbEmpresa.Location = New System.Drawing.Point(283, 13)
            Me.cbEmpresa.Name = "cbEmpresa"
            Me.cbEmpresa.Size = New System.Drawing.Size(142, 23)
            Me.cbEmpresa.TabIndex = 79
            '
            'rbNombreCustodio
            '
            Me.rbNombreCustodio.AutoSize = True
            Me.rbNombreCustodio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNombreCustodio.Location = New System.Drawing.Point(77, 19)
            Me.rbNombreCustodio.Name = "rbNombreCustodio"
            Me.rbNombreCustodio.Size = New System.Drawing.Size(75, 17)
            Me.rbNombreCustodio.TabIndex = 37
            Me.rbNombreCustodio.TabStop = True
            Me.rbNombreCustodio.Text = "CUSTODIO:"
            Me.rbNombreCustodio.UseVisualStyleBackColor = True
            '
            'btnAgregarActivoFijo
            '
            Me.btnAgregarActivoFijo.BackColor = System.Drawing.Color.White
            Me.btnAgregarActivoFijo.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAgregarActivoFijo.Enabled = False
            Me.btnAgregarActivoFijo.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btnAgregarActivoFijo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
            Me.btnAgregarActivoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btnAgregarActivoFijo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarActivoFijo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregarActivoFijo.Location = New System.Drawing.Point(843, 24)
            Me.btnAgregarActivoFijo.Name = "btnAgregarActivoFijo"
            Me.btnAgregarActivoFijo.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregarActivoFijo.TabIndex = 34
            Me.btnAgregarActivoFijo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAgregarActivoFijo.UseVisualStyleBackColor = False
            '
            'txtBusquedaActivoFijo
            '
            Me.txtBusquedaActivoFijo.Location = New System.Drawing.Point(6, 38)
            Me.txtBusquedaActivoFijo.Name = "txtBusquedaActivoFijo"
            Me.txtBusquedaActivoFijo.Size = New System.Drawing.Size(203, 21)
            Me.txtBusquedaActivoFijo.TabIndex = 35
            '
            'rbCodigoActivo
            '
            Me.rbCodigoActivo.AutoSize = True
            Me.rbCodigoActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCodigoActivo.Location = New System.Drawing.Point(6, 19)
            Me.rbCodigoActivo.Name = "rbCodigoActivo"
            Me.rbCodigoActivo.Size = New System.Drawing.Size(65, 17)
            Me.rbCodigoActivo.TabIndex = 38
            Me.rbCodigoActivo.TabStop = True
            Me.rbCodigoActivo.Text = "CODIGO:"
            Me.rbCodigoActivo.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.dgvTransferencias)
            Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(3, 477)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1005, 204)
            Me.GroupBox2.TabIndex = 48
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "ACTIVOS FIJOS AGREGADOS PARA TRANSFERENCIA DE CUSTODIO"
            '
            'dgvTransferencias
            '
            Me.dgvTransferencias.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTransferencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvTransferencias.BackgroundColor = System.Drawing.Color.White
            Me.dgvTransferencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTransferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_TRANSFERENCIA, Me.CODIGO_ACTIVO, Me.NOMBRE_ACTIVO, Me.ESTADO_ACTIVO, Me.ID_EMPRESA, Me.ID_SUCURSAL, Me.ID_GERENCIAS, Me.ID_AREA, Me.ID_PERSONAL, Me.ID_ACTIVO_FIJO})
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTransferencias.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvTransferencias.Location = New System.Drawing.Point(7, 19)
            Me.dgvTransferencias.MultiSelect = False
            Me.dgvTransferencias.Name = "dgvTransferencias"
            Me.dgvTransferencias.RowHeadersVisible = False
            Me.dgvTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTransferencias.Size = New System.Drawing.Size(992, 179)
            Me.dgvTransferencias.TabIndex = 46
            '
            'ID_TRANSFERENCIA
            '
            Me.ID_TRANSFERENCIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ID_TRANSFERENCIA.DefaultCellStyle = DataGridViewCellStyle6
            Me.ID_TRANSFERENCIA.HeaderText = "ID TRANSFERENCIA"
            Me.ID_TRANSFERENCIA.Name = "ID_TRANSFERENCIA"
            Me.ID_TRANSFERENCIA.Width = 140
            '
            'CODIGO_ACTIVO
            '
            Me.CODIGO_ACTIVO.HeaderText = "CODIGO"
            Me.CODIGO_ACTIVO.Name = "CODIGO_ACTIVO"
            Me.CODIGO_ACTIVO.Width = 120
            '
            'NOMBRE_ACTIVO
            '
            Me.NOMBRE_ACTIVO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.NOMBRE_ACTIVO.HeaderText = "NOMBRE ACTIVO"
            Me.NOMBRE_ACTIVO.Name = "NOMBRE_ACTIVO"
            Me.NOMBRE_ACTIVO.Width = 600
            '
            'ESTADO_ACTIVO
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.ESTADO_ACTIVO.DefaultCellStyle = DataGridViewCellStyle7
            Me.ESTADO_ACTIVO.HeaderText = "ESTADO_ACTIVO"
            Me.ESTADO_ACTIVO.Name = "ESTADO_ACTIVO"
            Me.ESTADO_ACTIVO.Width = 90
            '
            'ID_EMPRESA
            '
            Me.ID_EMPRESA.HeaderText = "ID_EMPRESA"
            Me.ID_EMPRESA.Name = "ID_EMPRESA"
            '
            'ID_SUCURSAL
            '
            Me.ID_SUCURSAL.HeaderText = "ID_SUCURSAL"
            Me.ID_SUCURSAL.Name = "ID_SUCURSAL"
            '
            'ID_GERENCIAS
            '
            Me.ID_GERENCIAS.HeaderText = "ID_GERENCIAS"
            Me.ID_GERENCIAS.Name = "ID_GERENCIAS"
            '
            'ID_AREA
            '
            Me.ID_AREA.HeaderText = "ID_AREA"
            Me.ID_AREA.Name = "ID_AREA"
            '
            'ID_PERSONAL
            '
            Me.ID_PERSONAL.HeaderText = "ID_PERSONAL"
            Me.ID_PERSONAL.Name = "ID_PERSONAL"
            '
            'ID_ACTIVO_FIJO
            '
            Me.ID_ACTIVO_FIJO.HeaderText = "ID_ACTIVO_FIJO"
            Me.ID_ACTIVO_FIJO.Name = "ID_ACTIVO_FIJO"
            '
            'txtFechaTransferencia
            '
            Me.txtFechaTransferencia.Enabled = False
            Me.txtFechaTransferencia.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaTransferencia.Location = New System.Drawing.Point(648, 41)
            Me.txtFechaTransferencia.Name = "txtFechaTransferencia"
            Me.txtFechaTransferencia.Size = New System.Drawing.Size(130, 23)
            Me.txtFechaTransferencia.TabIndex = 49
            Me.txtFechaTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(7, 73)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(128, 15)
            Me.Label3.TabIndex = 50
            Me.Label3.Text = "ANTERIOR UBICACIÓN:"
            '
            'txtNombreCustodioAnterior
            '
            Me.txtNombreCustodioAnterior.Enabled = False
            Me.txtNombreCustodioAnterior.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCustodioAnterior.Location = New System.Drawing.Point(229, 41)
            Me.txtNombreCustodioAnterior.Name = "txtNombreCustodioAnterior"
            Me.txtNombreCustodioAnterior.Size = New System.Drawing.Size(337, 23)
            Me.txtNombreCustodioAnterior.TabIndex = 51
            '
            'txtUbicacionNueva
            '
            Me.txtUbicacionNueva.Enabled = False
            Me.txtUbicacionNueva.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacionNueva.Location = New System.Drawing.Point(138, 125)
            Me.txtUbicacionNueva.Name = "txtUbicacionNueva"
            Me.txtUbicacionNueva.Size = New System.Drawing.Size(428, 23)
            Me.txtUbicacionNueva.TabIndex = 53
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(6, 123)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(109, 15)
            Me.Label6.TabIndex = 52
            Me.Label6.Text = "NUEVA UBICACIÓN:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(7, 47)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(124, 15)
            Me.Label7.TabIndex = 56
            Me.Label7.Text = "ANTERIOR CUSTODIO:"
            '
            'txtUbicacionAnterior
            '
            Me.txtUbicacionAnterior.Enabled = False
            Me.txtUbicacionAnterior.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacionAnterior.Location = New System.Drawing.Point(138, 69)
            Me.txtUbicacionAnterior.Name = "txtUbicacionAnterior"
            Me.txtUbicacionAnterior.Size = New System.Drawing.Size(428, 23)
            Me.txtUbicacionAnterior.TabIndex = 55
            '
            'txtIdCustodioAnterior
            '
            Me.txtIdCustodioAnterior.Enabled = False
            Me.txtIdCustodioAnterior.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCustodioAnterior.Location = New System.Drawing.Point(138, 42)
            Me.txtIdCustodioAnterior.Name = "txtIdCustodioAnterior"
            Me.txtIdCustodioAnterior.Size = New System.Drawing.Size(85, 23)
            Me.txtIdCustodioAnterior.TabIndex = 54
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(587, 45)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(44, 13)
            Me.Label8.TabIndex = 57
            Me.Label8.Text = "FECHA:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(587, 65)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(115, 15)
            Me.Label9.TabIndex = 58
            Me.Label9.Text = "NOMBRE AUTORIZA:"
            '
            'txtRazon
            '
            Me.txtRazon.Enabled = False
            Me.txtRazon.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazon.Location = New System.Drawing.Point(588, 125)
            Me.txtRazon.Name = "txtRazon"
            Me.txtRazon.Size = New System.Drawing.Size(418, 23)
            Me.txtRazon.TabIndex = 61
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(587, 107)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(47, 15)
            Me.Label10.TabIndex = 60
            Me.Label10.Text = "RAZÓN:"
            '
            'cbAutoriza
            '
            Me.cbAutoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAutoriza.Enabled = False
            Me.cbAutoriza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbAutoriza.FormattingEnabled = True
            Me.cbAutoriza.Items.AddRange(New Object() {"MAYOR IGNACIO NAVARRETE GERENTE GENERAL", "ING. JOSE NAVARRETE GERENTE DE OPERACIONES", "ING. JORGE ARMIJOS GERENTE ADMINISTRATIVO"})
            Me.cbAutoriza.Location = New System.Drawing.Point(590, 83)
            Me.cbAutoriza.Name = "cbAutoriza"
            Me.cbAutoriza.Size = New System.Drawing.Size(418, 21)
            Me.cbAutoriza.TabIndex = 62
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonNuevoRegistro, Me.btnGuardarTransferencia, Me.btnCancelarParametroDocumentos})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(1012, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ButtonNuevoRegistro
            '
            Me.ButtonNuevoRegistro.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonNuevoRegistro.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.ButtonNuevoRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ButtonNuevoRegistro.Name = "ButtonNuevoRegistro"
            Me.ButtonNuevoRegistro.Size = New System.Drawing.Size(78, 28)
            Me.ButtonNuevoRegistro.Text = "NUEVO"
            '
            'btnGuardarTransferencia
            '
            Me.btnGuardarTransferencia.Enabled = False
            Me.btnGuardarTransferencia.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarTransferencia.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarTransferencia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarTransferencia.Name = "btnGuardarTransferencia"
            Me.btnGuardarTransferencia.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardarTransferencia.Text = "GUARDAR"
            '
            'btnCancelarParametroDocumentos
            '
            Me.btnCancelarParametroDocumentos.AutoSize = False
            Me.btnCancelarParametroDocumentos.Enabled = False
            Me.btnCancelarParametroDocumentos.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarParametroDocumentos.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarParametroDocumentos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarParametroDocumentos.Name = "btnCancelarParametroDocumentos"
            Me.btnCancelarParametroDocumentos.Size = New System.Drawing.Size(91, 28)
            Me.btnCancelarParametroDocumentos.Text = "CANCELAR"
            '
            'FormTransferenciasActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1012, 688)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.cbAutoriza)
            Me.Controls.Add(Me.txtRazon)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtUbicacionAnterior)
            Me.Controls.Add(Me.txtIdCustodioAnterior)
            Me.Controls.Add(Me.txtUbicacionNueva)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtNombreCustodioAnterior)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtFechaTransferencia)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtNombreCustodioNuevo)
            Me.Controls.Add(Me.txtIdCustodioNuevo)
            Me.Controls.Add(Me.gbParámetros)
            Me.Controls.Add(Me.txtIdTransferencia)
            Me.Controls.Add(Me.Label1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormTransferenciasActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "TRANSFERENCIA DE ACTIVOS FIJOS"
            Me.gbParámetros.ResumeLayout(False)
            Me.gbParámetros.PerformLayout()
            CType(Me.dgvBusquedaPersonal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtIdTransferencia As System.Windows.Forms.TextBox
        Friend WithEvents gbParámetros As System.Windows.Forms.GroupBox
        Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
        Friend WithEvents rbCédula As System.Windows.Forms.RadioButton
        Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbApellido As System.Windows.Forms.RadioButton
        Friend WithEvents txtIdCustodioNuevo As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreCustodioNuevo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbNombreCustodio As System.Windows.Forms.RadioButton
        Friend WithEvents btnAgregarActivoFijo As System.Windows.Forms.Button
        Friend WithEvents txtBusquedaActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents rbCodigoActivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvTransferencias As System.Windows.Forms.DataGridView
        Friend WithEvents cbArea As System.Windows.Forms.ComboBox
        Friend WithEvents cbgerencias As System.Windows.Forms.ComboBox
        Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
        Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblSucursal As System.Windows.Forms.Label
        Friend WithEvents lblEmpresa As System.Windows.Forms.Label
        Friend WithEvents btnEliminarActivoFijoTransferencia As System.Windows.Forms.Button
        Friend WithEvents dgvBusquedaPersonal As System.Windows.Forms.DataGridView
        Friend WithEvents dgvActivoFijo As System.Windows.Forms.DataGridView
        Friend WithEvents txtFechaTransferencia As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCustodioAnterior As System.Windows.Forms.TextBox
        Friend WithEvents txtUbicacionNueva As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtUbicacionAnterior As System.Windows.Forms.TextBox
        Friend WithEvents txtIdCustodioAnterior As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtRazon As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbEstadoActual As System.Windows.Forms.ComboBox
        Friend WithEvents ID_TRANSFERENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CODIGO_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ESTADO_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_SUCURSAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_GERENCIAS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_AREA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_PERSONAL As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_ACTIVO_FIJO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cbAutoriza As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ButtonNuevoRegistro As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarTransferencia As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarParametroDocumentos As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace