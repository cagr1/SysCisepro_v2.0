Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormVehiculosOtros
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVehiculosOtros))
            Me.dtpSoat = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtChasisVehiculo = New System.Windows.Forms.TextBox()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.txtTipoVehiculo = New System.Windows.Forms.TextBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.txtCilindrajeVehiculo = New System.Windows.Forms.TextBox()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtMotorVehiculo = New System.Windows.Forms.TextBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtPlacaVehiculo = New System.Windows.Forms.TextBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtModeloVehiculo = New System.Windows.Forms.TextBox()
            Me.cbmColorVehiculo = New System.Windows.Forms.ComboBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtSerieVehiculo = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNombreVehiculo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtIdVehiculoOtros = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtResponsable = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNombreCustodio = New System.Windows.Forms.TextBox()
            Me.cbmMarca = New System.Windows.Forms.ComboBox()
            Me.txtUbicacion = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbmTipoCustodio = New System.Windows.Forms.ComboBox()
            Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
            Me.nudCapacidad = New System.Windows.Forms.NumericUpDown()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtpSoat
            '
            Me.dtpSoat.Enabled = False
            Me.dtpSoat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpSoat.Location = New System.Drawing.Point(393, 116)
            Me.dtpSoat.Name = "dtpSoat"
            Me.dtpSoat.Size = New System.Drawing.Size(200, 22)
            Me.dtpSoat.TabIndex = 212
            Me.dtpSoat.Value = New Date(2012, 4, 18, 0, 0, 0, 0)
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(346, 115)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(37, 13)
            Me.Label8.TabIndex = 213
            Me.Label8.Text = "SOAT:"
            '
            'txtChasisVehiculo
            '
            Me.txtChasisVehiculo.Enabled = False
            Me.txtChasisVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtChasisVehiculo.Location = New System.Drawing.Point(221, 87)
            Me.txtChasisVehiculo.Name = "txtChasisVehiculo"
            Me.txtChasisVehiculo.Size = New System.Drawing.Size(104, 22)
            Me.txtChasisVehiculo.TabIndex = 209
            '
            'Label33
            '
            Me.Label33.AutoSize = True
            Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label33.Location = New System.Drawing.Point(162, 87)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(47, 13)
            Me.Label33.TabIndex = 208
            Me.Label33.Text = "CHASIS:"
            '
            'txtTipoVehiculo
            '
            Me.txtTipoVehiculo.Enabled = False
            Me.txtTipoVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoVehiculo.Location = New System.Drawing.Point(522, 34)
            Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
            Me.txtTipoVehiculo.Size = New System.Drawing.Size(126, 22)
            Me.txtTipoVehiculo.TabIndex = 207
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label32.Location = New System.Drawing.Point(820, 126)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(69, 13)
            Me.Label32.TabIndex = 206
            Me.Label32.Text = "CAPACIDAD:"
            '
            'txtCilindrajeVehiculo
            '
            Me.txtCilindrajeVehiculo.Enabled = False
            Me.txtCilindrajeVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCilindrajeVehiculo.Location = New System.Drawing.Point(221, 113)
            Me.txtCilindrajeVehiculo.Name = "txtCilindrajeVehiculo"
            Me.txtCilindrajeVehiculo.Size = New System.Drawing.Size(104, 22)
            Me.txtCilindrajeVehiculo.TabIndex = 205
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.Location = New System.Drawing.Point(156, 116)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(69, 13)
            Me.Label31.TabIndex = 204
            Me.Label31.Text = "CILINDRAJE:"
            '
            'txtMotorVehiculo
            '
            Me.txtMotorVehiculo.Enabled = False
            Me.txtMotorVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotorVehiculo.Location = New System.Drawing.Point(63, 114)
            Me.txtMotorVehiculo.Name = "txtMotorVehiculo"
            Me.txtMotorVehiculo.Size = New System.Drawing.Size(83, 22)
            Me.txtMotorVehiculo.TabIndex = 203
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(1, 116)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(50, 13)
            Me.Label30.TabIndex = 202
            Me.Label30.Text = "MOTOR:"
            '
            'txtPlacaVehiculo
            '
            Me.txtPlacaVehiculo.Enabled = False
            Me.txtPlacaVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPlacaVehiculo.Location = New System.Drawing.Point(63, 87)
            Me.txtPlacaVehiculo.Name = "txtPlacaVehiculo"
            Me.txtPlacaVehiculo.Size = New System.Drawing.Size(83, 22)
            Me.txtPlacaVehiculo.TabIndex = 201
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.Location = New System.Drawing.Point(1, 87)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(48, 13)
            Me.Label29.TabIndex = 200
            Me.Label29.Text = "PLACAS:"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.Location = New System.Drawing.Point(599, 118)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(47, 13)
            Me.Label26.TabIndex = 199
            Me.Label26.Text = "COLOR:"
            '
            'txtModeloVehiculo
            '
            Me.txtModeloVehiculo.Enabled = False
            Me.txtModeloVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtModeloVehiculo.Location = New System.Drawing.Point(615, 87)
            Me.txtModeloVehiculo.Name = "txtModeloVehiculo"
            Me.txtModeloVehiculo.Size = New System.Drawing.Size(117, 22)
            Me.txtModeloVehiculo.TabIndex = 198
            '
            'cbmColorVehiculo
            '
            Me.cbmColorVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmColorVehiculo.Enabled = False
            Me.cbmColorVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmColorVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmColorVehiculo.FormattingEnabled = True
            Me.cbmColorVehiculo.Location = New System.Drawing.Point(646, 115)
            Me.cbmColorVehiculo.Name = "cbmColorVehiculo"
            Me.cbmColorVehiculo.Size = New System.Drawing.Size(112, 21)
            Me.cbmColorVehiculo.TabIndex = 197
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.Location = New System.Drawing.Point(346, 87)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(48, 13)
            Me.Label23.TabIndex = 192
            Me.Label23.Text = "MARCA:"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.Location = New System.Drawing.Point(543, 87)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(57, 13)
            Me.Label24.TabIndex = 194
            Me.Label24.Text = "MODELO:"
            '
            'txtSerieVehiculo
            '
            Me.txtSerieVehiculo.Enabled = False
            Me.txtSerieVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSerieVehiculo.Location = New System.Drawing.Point(807, 88)
            Me.txtSerieVehiculo.Name = "txtSerieVehiculo"
            Me.txtSerieVehiculo.Size = New System.Drawing.Size(117, 22)
            Me.txtSerieVehiculo.TabIndex = 196
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.Location = New System.Drawing.Point(767, 87)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(38, 13)
            Me.Label25.TabIndex = 195
            Me.Label25.Text = "SERIE:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(1, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(63, 26)
            Me.Label1.TabIndex = 214
            Me.Label1.Text = "NOMBRE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VEHÍCULO:"
            '
            'txtNombreVehiculo
            '
            Me.txtNombreVehiculo.Enabled = False
            Me.txtNombreVehiculo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreVehiculo.Location = New System.Drawing.Point(63, 61)
            Me.txtNombreVehiculo.Name = "txtNombreVehiculo"
            Me.txtNombreVehiculo.Size = New System.Drawing.Size(391, 22)
            Me.txtNombreVehiculo.TabIndex = 215
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(1, 27)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 26)
            Me.Label2.TabIndex = 216
            Me.Label2.Text = "ID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VEHÍCULO:"
            '
            'txtIdVehiculoOtros
            '
            Me.txtIdVehiculoOtros.Enabled = False
            Me.txtIdVehiculoOtros.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdVehiculoOtros.Location = New System.Drawing.Point(63, 36)
            Me.txtIdVehiculoOtros.Name = "txtIdVehiculoOtros"
            Me.txtIdVehiculoOtros.Size = New System.Drawing.Size(36, 22)
            Me.txtIdVehiculoOtros.TabIndex = 217
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(104, 34)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(82, 13)
            Me.Label3.TabIndex = 218
            Me.Label3.Text = "RESPONSABLE:"
            '
            'txtResponsable
            '
            Me.txtResponsable.Enabled = False
            Me.txtResponsable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtResponsable.Location = New System.Drawing.Point(180, 34)
            Me.txtResponsable.Name = "txtResponsable"
            Me.txtResponsable.Size = New System.Drawing.Size(274, 22)
            Me.txtResponsable.TabIndex = 219
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(460, 31)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(63, 26)
            Me.Label4.TabIndex = 220
            Me.Label4.Text = "TIPO DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VEHÍCULO:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(460, 61)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 26)
            Me.Label5.TabIndex = 221
            Me.Label5.Text = "NOMBRE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUSTODIO:"
            '
            'txtNombreCustodio
            '
            Me.txtNombreCustodio.Enabled = False
            Me.txtNombreCustodio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreCustodio.Location = New System.Drawing.Point(522, 61)
            Me.txtNombreCustodio.Name = "txtNombreCustodio"
            Me.txtNombreCustodio.Size = New System.Drawing.Size(402, 22)
            Me.txtNombreCustodio.TabIndex = 222
            '
            'cbmMarca
            '
            Me.cbmMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmMarca.Enabled = False
            Me.cbmMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmMarca.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMarca.FormattingEnabled = True
            Me.cbmMarca.Location = New System.Drawing.Point(395, 87)
            Me.cbmMarca.Name = "cbmMarca"
            Me.cbmMarca.Size = New System.Drawing.Size(112, 21)
            Me.cbmMarca.TabIndex = 223
            '
            'txtUbicacion
            '
            Me.txtUbicacion.Enabled = False
            Me.txtUbicacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbicacion.Location = New System.Drawing.Point(63, 140)
            Me.txtUbicacion.Name = "txtUbicacion"
            Me.txtUbicacion.Size = New System.Drawing.Size(530, 22)
            Me.txtUbicacion.TabIndex = 225
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(1, 138)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(68, 13)
            Me.Label6.TabIndex = 224
            Me.Label6.Text = "UBICACIÓN:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(599, 146)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(92, 13)
            Me.Label7.TabIndex = 226
            Me.Label7.Text = "TIPO CUSTODIO:"
            '
            'cbmTipoCustodio
            '
            Me.cbmTipoCustodio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoCustodio.Enabled = False
            Me.cbmTipoCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoCustodio.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoCustodio.FormattingEnabled = True
            Me.cbmTipoCustodio.Items.AddRange(New Object() {"DIRECTIVO", "SUPERVISOR", "MENSAJERO", "COBRADOR"})
            Me.cbmTipoCustodio.Location = New System.Drawing.Point(685, 140)
            Me.cbmTipoCustodio.Name = "cbmTipoCustodio"
            Me.cbmTipoCustodio.Size = New System.Drawing.Size(73, 21)
            Me.cbmTipoCustodio.TabIndex = 227
            '
            'dgvVehiculos
            '
            Me.dgvVehiculos.AllowUserToAddRows = False
            Me.dgvVehiculos.AllowUserToDeleteRows = False
            Me.dgvVehiculos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvVehiculos.BackgroundColor = System.Drawing.Color.White
            Me.dgvVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvVehiculos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvVehiculos.Location = New System.Drawing.Point(4, 165)
            Me.dgvVehiculos.Name = "dgvVehiculos"
            Me.dgvVehiculos.RowHeadersVisible = False
            Me.dgvVehiculos.Size = New System.Drawing.Size(920, 290)
            Me.dgvVehiculos.TabIndex = 228
            '
            'nudCapacidad
            '
            Me.nudCapacidad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudCapacidad.Location = New System.Drawing.Point(888, 120)
            Me.nudCapacidad.Name = "nudCapacidad"
            Me.nudCapacidad.Size = New System.Drawing.Size(35, 22)
            Me.nudCapacidad.TabIndex = 232
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(927, 24)
            Me.MenuStrip1.TabIndex = 233
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(119, 20)
            Me.btnBuscar.Text = "LISTAR TODOS"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormVehiculosOtros
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(927, 460)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.nudCapacidad)
            Me.Controls.Add(Me.dgvVehiculos)
            Me.Controls.Add(Me.cbmTipoCustodio)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtUbicacion)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cbmMarca)
            Me.Controls.Add(Me.txtNombreCustodio)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtResponsable)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtIdVehiculoOtros)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtNombreVehiculo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpSoat)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.txtChasisVehiculo)
            Me.Controls.Add(Me.Label33)
            Me.Controls.Add(Me.txtTipoVehiculo)
            Me.Controls.Add(Me.Label32)
            Me.Controls.Add(Me.txtCilindrajeVehiculo)
            Me.Controls.Add(Me.Label31)
            Me.Controls.Add(Me.txtMotorVehiculo)
            Me.Controls.Add(Me.Label30)
            Me.Controls.Add(Me.txtPlacaVehiculo)
            Me.Controls.Add(Me.Label29)
            Me.Controls.Add(Me.Label26)
            Me.Controls.Add(Me.txtModeloVehiculo)
            Me.Controls.Add(Me.cbmColorVehiculo)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.txtSerieVehiculo)
            Me.Controls.Add(Me.Label25)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.HelpButton = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormVehiculosOtros"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "INGRESO DE VEHICULOS DE DIRECTIVOS Y SUPERVICIONES"
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpSoat As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtChasisVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents txtTipoVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents txtCilindrajeVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents txtMotorVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtModeloVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents cbmColorVehiculo As System.Windows.Forms.ComboBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtSerieVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtNombreVehiculo As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtIdVehiculoOtros As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCustodio As System.Windows.Forms.TextBox
        Friend WithEvents cbmMarca As System.Windows.Forms.ComboBox
        Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbmTipoCustodio As System.Windows.Forms.ComboBox
        Friend WithEvents dgvVehiculos As System.Windows.Forms.DataGridView
        Friend WithEvents nudCapacidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace