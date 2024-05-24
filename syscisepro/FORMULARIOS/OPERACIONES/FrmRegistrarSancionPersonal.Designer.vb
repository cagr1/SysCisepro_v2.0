Namespace FORMULARIOS.OPERACIONES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmRegistrarSancionPersonal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarSancionPersonal))
            Me.txtArea = New System.Windows.Forms.TextBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.tcSitios = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.dgvSanciones = New System.Windows.Forms.DataGridView()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtMultador = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotal = New System.Windows.Forms.NumericUpDown()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtCant = New System.Windows.Forms.NumericUpDown()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.bntSanciones = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtValor = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtIdSancion = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtSancion = New System.Windows.Forms.TextBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.txtIdPuesto = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtUbicacionPuesto = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtCargo = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.btnPersonalEntra = New System.Windows.Forms.Button()
            Me.txtIdPersonal = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtPersonal = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.AGRUPADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.tcSitios.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtArea
            '
            Me.txtArea.BackColor = System.Drawing.Color.White
            Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArea.Enabled = False
            Me.txtArea.Location = New System.Drawing.Point(436, 41)
            Me.txtArea.Name = "txtArea"
            Me.txtArea.Size = New System.Drawing.Size(338, 20)
            Me.txtArea.TabIndex = 197
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(393, 44)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(37, 13)
            Me.Label27.TabIndex = 196
            Me.Label27.Text = "ÁREA:"
            '
            'tcSitios
            '
            Me.tcSitios.Controls.Add(Me.TabPage1)
            Me.tcSitios.Location = New System.Drawing.Point(2, 2)
            Me.tcSitios.Name = "tcSitios"
            Me.tcSitios.SelectedIndex = 0
            Me.tcSitios.Size = New System.Drawing.Size(791, 707)
            Me.tcSitios.TabIndex = 4
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.TabControl1)
            Me.TabPage1.Controls.Add(Me.Label2)
            Me.TabPage1.Controls.Add(Me.Label1)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.dtpFechaHasta)
            Me.TabPage1.Controls.Add(Me.dtpFechaDesde)
            Me.TabPage1.Controls.Add(Me.Label24)
            Me.TabPage1.Controls.Add(Me.GroupBox3)
            Me.TabPage1.Controls.Add(Me.txtFiltro)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.MenuStrip1)
            Me.TabPage1.Controls.Add(Me.Label11)
            Me.TabPage1.Controls.Add(Me.Label10)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(783, 681)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "MANTENIMIENTO"
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.TabPage3)
            Me.TabControl1.Location = New System.Drawing.Point(8, 311)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(765, 349)
            Me.TabControl1.TabIndex = 207
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.ListView1)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(757, 323)
            Me.TabPage2.TabIndex = 0
            Me.TabPage2.Text = "NORMAL"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader13, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader10, Me.ColumnHeader14})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.HideSelection = False
            Me.ListView1.Location = New System.Drawing.Point(0, 0)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(757, 320)
            Me.ListView1.TabIndex = 204
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 35
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "SANCION"
            Me.ColumnHeader4.Width = 0
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "IDS"
            Me.ColumnHeader13.Width = 0
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "FECHA"
            Me.ColumnHeader5.Width = 90
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "IDE"
            Me.ColumnHeader6.Width = 0
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "PERSONAL"
            Me.ColumnHeader2.Width = 200
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "CARGO"
            Me.ColumnHeader3.Width = 150
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "AREA"
            Me.ColumnHeader7.Width = 0
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "IDS"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "SITIO"
            Me.ColumnHeader9.Width = 240
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "VALOR"
            Me.ColumnHeader11.Width = 80
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "OBSERVACION"
            Me.ColumnHeader12.Width = 300
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "IDES"
            Me.ColumnHeader10.Width = 40
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "MULTADOR"
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.dgvSanciones)
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(757, 338)
            Me.TabPage3.TabIndex = 1
            Me.TabPage3.Text = "AGRUPADOS"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'dgvSanciones
            '
            Me.dgvSanciones.AllowUserToAddRows = False
            Me.dgvSanciones.AllowUserToDeleteRows = False
            Me.dgvSanciones.AllowUserToOrderColumns = True
            Me.dgvSanciones.AllowUserToResizeRows = False
            Me.dgvSanciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvSanciones.Location = New System.Drawing.Point(0, 0)
            Me.dgvSanciones.Name = "dgvSanciones"
            Me.dgvSanciones.RowHeadersVisible = False
            Me.dgvSanciones.ShowEditingIcon = False
            Me.dgvSanciones.Size = New System.Drawing.Size(754, 335)
            Me.dgvSanciones.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label2.Location = New System.Drawing.Point(701, 663)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 16)
            Me.Label2.TabIndex = 206
            Me.Label2.Text = "$ 0.00"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label1.Location = New System.Drawing.Point(1, 663)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(700, 16)
            Me.Label1.TabIndex = 205
            Me.Label1.Text = "O REGISTRO(S) - TOTAL EN MULTAS: "
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.txtMultador)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtTotal)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtCant)
            Me.GroupBox2.Controls.Add(Me.dtpFecha)
            Me.GroupBox2.Controls.Add(Me.Label31)
            Me.GroupBox2.Controls.Add(Me.bntSanciones)
            Me.GroupBox2.Controls.Add(Me.txtObservacion)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.txtValor)
            Me.GroupBox2.Controls.Add(Me.Label19)
            Me.GroupBox2.Controls.Add(Me.txtIdSancion)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.txtSancion)
            Me.GroupBox2.Controls.Add(Me.Label30)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(2, 165)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(778, 99)
            Me.GroupBox2.TabIndex = 203
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "DATOS DE LA SANCIÓN / MULTA"
            '
            'txtMultador
            '
            Me.txtMultador.Enabled = False
            Me.txtMultador.Location = New System.Drawing.Point(143, 71)
            Me.txtMultador.Name = "txtMultador"
            Me.txtMultador.Size = New System.Drawing.Size(574, 20)
            Me.txtMultador.TabIndex = 210
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(13, 74)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(103, 13)
            Me.Label4.TabIndex = 209
            Me.Label4.Text = "REGISTRADO POR :"
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.DecimalPlaces = 2
            Me.txtTotal.Enabled = False
            Me.txtTotal.Location = New System.Drawing.Point(172, 44)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(77, 20)
            Me.txtTotal.TabIndex = 208
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(129, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 207
            Me.Label3.Text = "TOTAL:"
            '
            'txtCant
            '
            Me.txtCant.BackColor = System.Drawing.Color.White
            Me.txtCant.Location = New System.Drawing.Point(53, 44)
            Me.txtCant.Name = "txtCant"
            Me.txtCant.Size = New System.Drawing.Size(55, 20)
            Me.txtCant.TabIndex = 206
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "MMMM yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Location = New System.Drawing.Point(144, 15)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(261, 20)
            Me.dtpFecha.TabIndex = 204
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(103, 18)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(43, 13)
            Me.Label31.TabIndex = 205
            Me.Label31.Text = "FECHA:"
            '
            'bntSanciones
            '
            Me.bntSanciones.BackColor = System.Drawing.Color.White
            Me.bntSanciones.Enabled = False
            Me.bntSanciones.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bntSanciones.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.bntSanciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.bntSanciones.Location = New System.Drawing.Point(749, 13)
            Me.bntSanciones.Name = "bntSanciones"
            Me.bntSanciones.Size = New System.Drawing.Size(26, 26)
            Me.bntSanciones.TabIndex = 202
            Me.bntSanciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.bntSanciones.UseVisualStyleBackColor = False
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Location = New System.Drawing.Point(351, 43)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(424, 20)
            Me.txtObservacion.TabIndex = 201
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(266, 46)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(79, 13)
            Me.Label18.TabIndex = 200
            Me.Label18.Text = "OBSERVACIÓN:"
            '
            'txtValor
            '
            Me.txtValor.BackColor = System.Drawing.Color.White
            Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValor.Enabled = False
            Me.txtValor.Location = New System.Drawing.Point(716, 16)
            Me.txtValor.Name = "txtValor"
            Me.txtValor.Size = New System.Drawing.Size(33, 20)
            Me.txtValor.TabIndex = 199
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(10, 48)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 198
            Me.Label19.Text = "CANT.:"
            '
            'txtIdSancion
            '
            Me.txtIdSancion.BackColor = System.Drawing.Color.White
            Me.txtIdSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdSancion.Enabled = False
            Me.txtIdSancion.Location = New System.Drawing.Point(39, 16)
            Me.txtIdSancion.Name = "txtIdSancion"
            Me.txtIdSancion.Size = New System.Drawing.Size(37, 20)
            Me.txtIdSancion.TabIndex = 28
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(13, 21)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(25, 13)
            Me.Label20.TabIndex = 8
            Me.Label20.Text = "ID:"
            '
            'txtSancion
            '
            Me.txtSancion.BackColor = System.Drawing.Color.White
            Me.txtSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSancion.Enabled = False
            Me.txtSancion.Location = New System.Drawing.Point(479, 16)
            Me.txtSancion.Name = "txtSancion"
            Me.txtSancion.Size = New System.Drawing.Size(238, 20)
            Me.txtSancion.TabIndex = 0
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(429, 20)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(55, 13)
            Me.Label30.TabIndex = 3
            Me.Label30.Text = "SANCIÓN:"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(675, 285)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(93, 22)
            Me.dtpFechaHasta.TabIndex = 200
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(552, 285)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(93, 22)
            Me.dtpFechaDesde.TabIndex = 199
            '
            'Label24
            '
            Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label24.Location = New System.Drawing.Point(1, 267)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(780, 16)
            Me.Label24.TabIndex = 195
            Me.Label24.Text = "REGISTRO DE MULTAS AL PERSONAL"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.txtCliente)
            Me.GroupBox3.Controls.Add(Me.Label28)
            Me.GroupBox3.Controls.Add(Me.txtIdPuesto)
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.txtUbicacionPuesto)
            Me.GroupBox3.Controls.Add(Me.Label23)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(4, 96)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(778, 69)
            Me.GroupBox3.TabIndex = 194
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DATOS DEL PUESTO DE TRABAJO"
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Location = New System.Drawing.Point(79, 43)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(694, 20)
            Me.txtCliente.TabIndex = 201
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(18, 46)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(55, 13)
            Me.Label28.TabIndex = 200
            Me.Label28.Text = "CLIENTE:"
            '
            'txtIdPuesto
            '
            Me.txtIdPuesto.BackColor = System.Drawing.Color.White
            Me.txtIdPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPuesto.Enabled = False
            Me.txtIdPuesto.Location = New System.Drawing.Point(44, 16)
            Me.txtIdPuesto.Name = "txtIdPuesto"
            Me.txtIdPuesto.Size = New System.Drawing.Size(37, 20)
            Me.txtIdPuesto.TabIndex = 28
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(18, 21)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(25, 13)
            Me.Label21.TabIndex = 8
            Me.Label21.Text = "ID:"
            '
            'txtUbicacionPuesto
            '
            Me.txtUbicacionPuesto.BackColor = System.Drawing.Color.White
            Me.txtUbicacionPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbicacionPuesto.Enabled = False
            Me.txtUbicacionPuesto.Location = New System.Drawing.Point(170, 17)
            Me.txtUbicacionPuesto.Name = "txtUbicacionPuesto"
            Me.txtUbicacionPuesto.Size = New System.Drawing.Size(602, 20)
            Me.txtUbicacionPuesto.TabIndex = 0
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(101, 20)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(67, 13)
            Me.Label23.TabIndex = 3
            Me.Label23.Text = "UBICACIÓN:"
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFiltro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(62, 286)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(456, 21)
            Me.txtFiltro.TabIndex = 191
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label7.Location = New System.Drawing.Point(8, 290)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(48, 13)
            Me.Label7.TabIndex = 190
            Me.Label7.Text = "FILTRO:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.txtArea)
            Me.GroupBox1.Controls.Add(Me.Label27)
            Me.GroupBox1.Controls.Add(Me.txtCargo)
            Me.GroupBox1.Controls.Add(Me.Label25)
            Me.GroupBox1.Controls.Add(Me.btnPersonalEntra)
            Me.GroupBox1.Controls.Add(Me.txtIdPersonal)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.txtPersonal)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 29)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(778, 67)
            Me.GroupBox1.TabIndex = 183
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "DATOS DE PERSONAL"
            '
            'txtCargo
            '
            Me.txtCargo.BackColor = System.Drawing.Color.White
            Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCargo.Enabled = False
            Me.txtCargo.Location = New System.Drawing.Point(59, 41)
            Me.txtCargo.Name = "txtCargo"
            Me.txtCargo.Size = New System.Drawing.Size(280, 20)
            Me.txtCargo.TabIndex = 195
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(13, 44)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(43, 13)
            Me.Label25.TabIndex = 194
            Me.Label25.Text = "CARGO:"
            '
            'btnPersonalEntra
            '
            Me.btnPersonalEntra.BackColor = System.Drawing.Color.White
            Me.btnPersonalEntra.Enabled = False
            Me.btnPersonalEntra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPersonalEntra.Image = CType(resources.GetObject("btnPersonalEntra.Image"), System.Drawing.Image)
            Me.btnPersonalEntra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnPersonalEntra.Location = New System.Drawing.Point(741, 12)
            Me.btnPersonalEntra.Name = "btnPersonalEntra"
            Me.btnPersonalEntra.Size = New System.Drawing.Size(26, 26)
            Me.btnPersonalEntra.TabIndex = 193
            Me.btnPersonalEntra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPersonalEntra.UseVisualStyleBackColor = False
            '
            'txtIdPersonal
            '
            Me.txtIdPersonal.BackColor = System.Drawing.Color.White
            Me.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdPersonal.Enabled = False
            Me.txtIdPersonal.Location = New System.Drawing.Point(59, 17)
            Me.txtIdPersonal.Name = "txtIdPersonal"
            Me.txtIdPersonal.Size = New System.Drawing.Size(37, 20)
            Me.txtIdPersonal.TabIndex = 28
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(18, 19)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(25, 13)
            Me.Label22.TabIndex = 8
            Me.Label22.Text = "ID:"
            '
            'txtPersonal
            '
            Me.txtPersonal.BackColor = System.Drawing.Color.White
            Me.txtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPersonal.Enabled = False
            Me.txtPersonal.Location = New System.Drawing.Point(206, 17)
            Me.txtPersonal.Name = "txtPersonal"
            Me.txtPersonal.Size = New System.Drawing.Size(529, 20)
            Me.txtPersonal.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(141, 18)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(55, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "NOMBRES:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnAnular, Me.btnCancelar, Me.ToolStripMenuItem2, Me.AGRUPADOSToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(777, 24)
            Me.MenuStrip1.TabIndex = 182
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 20)
            Me.ToolStripMenuItem1.Text = "LISTAR TODOS"
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
            'btnAnular
            '
            Me.btnAnular.Enabled = False
            Me.btnAnular.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(77, 20)
            Me.btnAnular.Text = "ANULAR"
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
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(91, 20)
            Me.ToolStripMenuItem2.Text = "EXPORTAR"
            '
            'AGRUPADOSToolStripMenuItem
            '
            Me.AGRUPADOSToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AGRUPADOSToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.AGRUPADOSToolStripMenuItem.Name = "AGRUPADOSToolStripMenuItem"
            Me.AGRUPADOSToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
            Me.AGRUPADOSToolStripMenuItem.Text = "AGRUPADOS"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(659, 288)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(17, 13)
            Me.Label11.TabIndex = 202
            Me.Label11.Text = "A:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(529, 288)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(25, 13)
            Me.Label10.TabIndex = 201
            Me.Label10.Text = "DE:"
            '
            'FrmRegistrarSancionPersonal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(791, 710)
            Me.Controls.Add(Me.tcSitios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmRegistrarSancionPersonal"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SANCIONES AL PERSONAL"
            Me.tcSitios.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCant, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtArea As System.Windows.Forms.TextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents tcSitios As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtIdPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtUbicacionPuesto As System.Windows.Forms.TextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtCargo As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents btnPersonalEntra As System.Windows.Forms.Button
        Friend WithEvents txtIdPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtValor As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtIdSancion As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtSancion As System.Windows.Forms.TextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents bntSanciones As System.Windows.Forms.Button
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtTotal As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtCant As System.Windows.Forms.NumericUpDown
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents dgvSanciones As System.Windows.Forms.DataGridView
        Friend WithEvents AGRUPADOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label4 As Label
        Friend WithEvents txtMultador As TextBox
        Friend WithEvents ColumnHeader14 As ColumnHeader
    End Class
End Namespace