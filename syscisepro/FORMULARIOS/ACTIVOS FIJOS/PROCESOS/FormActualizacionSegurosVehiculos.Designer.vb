Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormActualizacionSegurosVehiculos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizacionSegurosVehiculos))
            Me.dgvActualizacionVehiculos = New System.Windows.Forms.DataGridView()
            Me.gbBusqueda = New System.Windows.Forms.GroupBox()
            Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
            Me.rbPlacas = New System.Windows.Forms.RadioButton()
            Me.rbCodigoActivo = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombreActivo = New System.Windows.Forms.TextBox()
            Me.txtPlacas = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtIdActivo = New System.Windows.Forms.TextBox()
            Me.txtAseguradora = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtSeguro = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtBroker = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNroPoliza = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtCostoPrima = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtDispositivoSeguridad = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.dtpFechaInicioContrato = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaFinalContrato = New System.Windows.Forms.DateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaRenovacionContrato = New System.Windows.Forms.DateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.dtpFechaRenovacionDispositivo = New System.Windows.Forms.DateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechaFinalDispositivo = New System.Windows.Forms.DateTimePicker()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpFechaInicioDispositivo = New System.Windows.Forms.DateTimePicker()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.dtpSoat = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnActualizar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarUnidadMedida = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvActualizacionVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvActualizacionVehiculos
            '
            Me.dgvActualizacionVehiculos.AllowUserToAddRows = False
            Me.dgvActualizacionVehiculos.AllowUserToDeleteRows = False
            Me.dgvActualizacionVehiculos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActualizacionVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActualizacionVehiculos.BackgroundColor = System.Drawing.Color.White
            Me.dgvActualizacionVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvActualizacionVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActualizacionVehiculos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActualizacionVehiculos.Location = New System.Drawing.Point(2, 312)
            Me.dgvActualizacionVehiculos.MultiSelect = False
            Me.dgvActualizacionVehiculos.Name = "dgvActualizacionVehiculos"
            Me.dgvActualizacionVehiculos.RowHeadersVisible = False
            Me.dgvActualizacionVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActualizacionVehiculos.Size = New System.Drawing.Size(881, 296)
            Me.dgvActualizacionVehiculos.TabIndex = 0
            '
            'gbBusqueda
            '
            Me.gbBusqueda.BackColor = System.Drawing.Color.White
            Me.gbBusqueda.Controls.Add(Me.txtParametroBusqueda)
            Me.gbBusqueda.Controls.Add(Me.rbPlacas)
            Me.gbBusqueda.Controls.Add(Me.rbCodigoActivo)
            Me.gbBusqueda.Location = New System.Drawing.Point(3, 246)
            Me.gbBusqueda.Name = "gbBusqueda"
            Me.gbBusqueda.Size = New System.Drawing.Size(643, 60)
            Me.gbBusqueda.TabIndex = 1
            Me.gbBusqueda.TabStop = False
            Me.gbBusqueda.Text = "BUSQUEDA"
            '
            'txtParametroBusqueda
            '
            Me.txtParametroBusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametroBusqueda.ForeColor = System.Drawing.Color.Black
            Me.txtParametroBusqueda.Location = New System.Drawing.Point(259, 16)
            Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
            Me.txtParametroBusqueda.Size = New System.Drawing.Size(345, 29)
            Me.txtParametroBusqueda.TabIndex = 2
            '
            'rbPlacas
            '
            Me.rbPlacas.AutoSize = True
            Me.rbPlacas.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbPlacas.Location = New System.Drawing.Point(173, 26)
            Me.rbPlacas.Name = "rbPlacas"
            Me.rbPlacas.Size = New System.Drawing.Size(61, 17)
            Me.rbPlacas.TabIndex = 1
            Me.rbPlacas.TabStop = True
            Me.rbPlacas.Text = "PLACAS"
            Me.rbPlacas.UseVisualStyleBackColor = True
            '
            'rbCodigoActivo
            '
            Me.rbCodigoActivo.AutoSize = True
            Me.rbCodigoActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCodigoActivo.Location = New System.Drawing.Point(19, 26)
            Me.rbCodigoActivo.Name = "rbCodigoActivo"
            Me.rbCodigoActivo.Size = New System.Drawing.Size(99, 17)
            Me.rbCodigoActivo.TabIndex = 0
            Me.rbCodigoActivo.TabStop = True
            Me.rbCodigoActivo.Text = "CODIGO ACTIVO"
            Me.rbCodigoActivo.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 33)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "NOMBRE ACTIVO:"
            '
            'txtNombreActivo
            '
            Me.txtNombreActivo.Enabled = False
            Me.txtNombreActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreActivo.Location = New System.Drawing.Point(166, 31)
            Me.txtNombreActivo.Name = "txtNombreActivo"
            Me.txtNombreActivo.Size = New System.Drawing.Size(511, 21)
            Me.txtNombreActivo.TabIndex = 3
            '
            'txtPlacas
            '
            Me.txtPlacas.Enabled = False
            Me.txtPlacas.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPlacas.Location = New System.Drawing.Point(772, 30)
            Me.txtPlacas.Name = "txtPlacas"
            Me.txtPlacas.Size = New System.Drawing.Size(111, 21)
            Me.txtPlacas.TabIndex = 5
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(722, 34)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "PLACAS:"
            '
            'txtIdActivo
            '
            Me.txtIdActivo.Enabled = False
            Me.txtIdActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdActivo.Location = New System.Drawing.Point(91, 31)
            Me.txtIdActivo.Name = "txtIdActivo"
            Me.txtIdActivo.Size = New System.Drawing.Size(66, 21)
            Me.txtIdActivo.TabIndex = 6
            '
            'txtAseguradora
            '
            Me.txtAseguradora.Enabled = False
            Me.txtAseguradora.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAseguradora.Location = New System.Drawing.Point(87, 13)
            Me.txtAseguradora.Name = "txtAseguradora"
            Me.txtAseguradora.Size = New System.Drawing.Size(345, 21)
            Me.txtAseguradora.TabIndex = 8
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(5, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "ASEGURADORA:"
            '
            'txtSeguro
            '
            Me.txtSeguro.Enabled = False
            Me.txtSeguro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSeguro.Location = New System.Drawing.Point(532, 13)
            Me.txtSeguro.Name = "txtSeguro"
            Me.txtSeguro.Size = New System.Drawing.Size(345, 21)
            Me.txtSeguro.TabIndex = 10
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(435, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "SEGURO:"
            '
            'txtBroker
            '
            Me.txtBroker.Enabled = False
            Me.txtBroker.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBroker.Location = New System.Drawing.Point(87, 35)
            Me.txtBroker.Name = "txtBroker"
            Me.txtBroker.Size = New System.Drawing.Size(345, 21)
            Me.txtBroker.TabIndex = 12
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(5, 35)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(46, 13)
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "BROKER:"
            '
            'txtNroPoliza
            '
            Me.txtNroPoliza.Enabled = False
            Me.txtNroPoliza.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroPoliza.Location = New System.Drawing.Point(87, 57)
            Me.txtNroPoliza.Name = "txtNroPoliza"
            Me.txtNroPoliza.Size = New System.Drawing.Size(95, 21)
            Me.txtNroPoliza.TabIndex = 14
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(5, 57)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(56, 13)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "N° POLIZA:"
            '
            'txtCostoPrima
            '
            Me.txtCostoPrima.Enabled = False
            Me.txtCostoPrima.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCostoPrima.Location = New System.Drawing.Point(87, 79)
            Me.txtCostoPrima.Name = "txtCostoPrima"
            Me.txtCostoPrima.Size = New System.Drawing.Size(95, 21)
            Me.txtCostoPrima.TabIndex = 16
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(5, 79)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(74, 13)
            Me.Label7.TabIndex = 15
            Me.Label7.Text = "COSTO PRIMA:"
            '
            'txtDispositivoSeguridad
            '
            Me.txtDispositivoSeguridad.Enabled = False
            Me.txtDispositivoSeguridad.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDispositivoSeguridad.Location = New System.Drawing.Point(91, 18)
            Me.txtDispositivoSeguridad.Name = "txtDispositivoSeguridad"
            Me.txtDispositivoSeguridad.Size = New System.Drawing.Size(492, 21)
            Me.txtDispositivoSeguridad.TabIndex = 18
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(17, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(66, 26)
            Me.Label8.TabIndex = 17
            Me.Label8.Text = "DISPOSITIVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SEGURIDAD: "
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(434, 30)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(70, 26)
            Me.Label9.TabIndex = 19
            Me.Label9.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CONTRATO:"
            '
            'dtpFechaInicioContrato
            '
            Me.dtpFechaInicioContrato.Enabled = False
            Me.dtpFechaInicioContrato.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicioContrato.Location = New System.Drawing.Point(532, 35)
            Me.dtpFechaInicioContrato.Name = "dtpFechaInicioContrato"
            Me.dtpFechaInicioContrato.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaInicioContrato.TabIndex = 20
            '
            'dtpFechaFinalContrato
            '
            Me.dtpFechaFinalContrato.Enabled = False
            Me.dtpFechaFinalContrato.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinalContrato.Location = New System.Drawing.Point(532, 57)
            Me.dtpFechaFinalContrato.Name = "dtpFechaFinalContrato"
            Me.dtpFechaFinalContrato.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaFinalContrato.TabIndex = 22
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(434, 57)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(70, 26)
            Me.Label10.TabIndex = 21
            Me.Label10.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FINAL:"
            '
            'dtpFechaRenovacionContrato
            '
            Me.dtpFechaRenovacionContrato.Enabled = False
            Me.dtpFechaRenovacionContrato.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaRenovacionContrato.Location = New System.Drawing.Point(532, 79)
            Me.dtpFechaRenovacionContrato.Name = "dtpFechaRenovacionContrato"
            Me.dtpFechaRenovacionContrato.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaRenovacionContrato.TabIndex = 24
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.Black
            Me.Label11.Location = New System.Drawing.Point(434, 83)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(71, 26)
            Me.Label11.TabIndex = 23
            Me.Label11.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RENOVACIÓN:"
            '
            'dtpFechaRenovacionDispositivo
            '
            Me.dtpFechaRenovacionDispositivo.Enabled = False
            Me.dtpFechaRenovacionDispositivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaRenovacionDispositivo.Location = New System.Drawing.Point(675, 36)
            Me.dtpFechaRenovacionDispositivo.Name = "dtpFechaRenovacionDispositivo"
            Me.dtpFechaRenovacionDispositivo.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaRenovacionDispositivo.TabIndex = 30
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(601, 32)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(71, 26)
            Me.Label12.TabIndex = 29
            Me.Label12.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RENOVACIÓN:"
            '
            'dtpFechaFinalDispositivo
            '
            Me.dtpFechaFinalDispositivo.Enabled = False
            Me.dtpFechaFinalDispositivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinalDispositivo.Location = New System.Drawing.Point(383, 43)
            Me.dtpFechaFinalDispositivo.Name = "dtpFechaFinalDispositivo"
            Me.dtpFechaFinalDispositivo.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaFinalDispositivo.TabIndex = 28
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.Black
            Me.Label13.Location = New System.Drawing.Point(311, 42)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(70, 26)
            Me.Label13.TabIndex = 27
            Me.Label13.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FINAL:"
            '
            'dtpFechaInicioDispositivo
            '
            Me.dtpFechaInicioDispositivo.Enabled = False
            Me.dtpFechaInicioDispositivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicioDispositivo.Location = New System.Drawing.Point(92, 43)
            Me.dtpFechaInicioDispositivo.Name = "dtpFechaInicioDispositivo"
            Me.dtpFechaInicioDispositivo.Size = New System.Drawing.Size(200, 21)
            Me.dtpFechaInicioDispositivo.TabIndex = 26
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.Black
            Me.Label14.Location = New System.Drawing.Point(17, 40)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(70, 26)
            Me.Label14.TabIndex = 25
            Me.Label14.Text = "FECHA INICIO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CONTRATO:"
            '
            'dtpSoat
            '
            Me.dtpSoat.Enabled = False
            Me.dtpSoat.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpSoat.Location = New System.Drawing.Point(15, 25)
            Me.dtpSoat.Name = "dtpSoat"
            Me.dtpSoat.Size = New System.Drawing.Size(200, 21)
            Me.dtpSoat.TabIndex = 32
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtCostoPrima)
            Me.GroupBox1.Controls.Add(Me.txtSeguro)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.txtNroPoliza)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.dtpFechaInicioContrato)
            Me.GroupBox1.Controls.Add(Me.txtBroker)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtAseguradora)
            Me.GroupBox1.Controls.Add(Me.dtpFechaRenovacionContrato)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.dtpFechaFinalContrato)
            Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 55)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(881, 110)
            Me.GroupBox1.TabIndex = 33
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "SEGURO"
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtDispositivoSeguridad)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.dtpFechaRenovacionDispositivo)
            Me.GroupBox2.Controls.Add(Me.dtpFechaInicioDispositivo)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.dtpFechaFinalDispositivo)
            Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(2, 171)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(881, 70)
            Me.GroupBox2.TabIndex = 34
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DISPOSITIVO SEGURIDAD"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.dtpSoat)
            Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(652, 247)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(231, 59)
            Me.GroupBox3.TabIndex = 35
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "SOAT"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnModificar, Me.btnActualizar, Me.btnCancelarUnidadMedida})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(98, 20)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnActualizar
            '
            Me.btnActualizar.Enabled = False
            Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
            Me.btnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(84, 20)
            Me.btnActualizar.Text = "GUARDAR"
            '
            'btnCancelarUnidadMedida
            '
            Me.btnCancelarUnidadMedida.Enabled = False
            Me.btnCancelarUnidadMedida.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarUnidadMedida.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarUnidadMedida.Name = "btnCancelarUnidadMedida"
            Me.btnCancelarUnidadMedida.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarUnidadMedida.Text = "CANCELAR"
            '
            'FormActualizacionSegurosVehiculos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(884, 611)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtIdActivo)
            Me.Controls.Add(Me.txtPlacas)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtNombreActivo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.gbBusqueda)
            Me.Controls.Add(Me.dgvActualizacionVehiculos)
            Me.ForeColor = System.Drawing.Color.Black
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormActualizacionSegurosVehiculos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ACTUALIZACION DE SEGUROS Y DISPOSITIVOS DE SEGURIDAD EN VEHÍCULOS"
            CType(Me.dgvActualizacionVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBusqueda.ResumeLayout(False)
            Me.gbBusqueda.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvActualizacionVehiculos As System.Windows.Forms.DataGridView
        Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbPlacas As System.Windows.Forms.RadioButton
        Friend WithEvents rbCodigoActivo As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombreActivo As System.Windows.Forms.TextBox
        Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtIdActivo As System.Windows.Forms.TextBox
        Friend WithEvents txtAseguradora As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtSeguro As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtBroker As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNroPoliza As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtCostoPrima As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDispositivoSeguridad As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInicioContrato As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaFinalContrato As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaRenovacionContrato As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaRenovacionDispositivo As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFinalDispositivo As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInicioDispositivo As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents dtpSoat As System.Windows.Forms.DateTimePicker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarUnidadMedida As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace