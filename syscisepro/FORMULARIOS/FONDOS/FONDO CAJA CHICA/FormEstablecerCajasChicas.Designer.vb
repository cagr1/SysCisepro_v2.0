Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEstablecerCajasChicas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstablecerCajasChicas))
            Me.tcDatos = New System.Windows.Forms.TabControl()
            Me.tpDatos = New System.Windows.Forms.TabPage()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.lblNombres = New System.Windows.Forms.TextBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.btnBuscarCustodio = New System.Windows.Forms.Button()
            Me.txtIdCustodio = New System.Windows.Forms.TextBox()
            Me.cbmCiudad = New System.Windows.Forms.ComboBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.txtCuentaContable = New System.Windows.Forms.TextBox()
            Me.cbmNivelCuenta = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbmTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtValorGasto = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtIdCajaChica = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dgvCajas = New System.Windows.Forms.DataGridView()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.crvCajasChicasCustodios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevaCaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcDatos.SuspendLayout()
            Me.tpDatos.SuspendLayout()
            CType(Me.dgvCajas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpReporte.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcDatos
            '
            Me.tcDatos.Controls.Add(Me.tpDatos)
            Me.tcDatos.Controls.Add(Me.tpReporte)
            Me.tcDatos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcDatos.Location = New System.Drawing.Point(3, 30)
            Me.tcDatos.Name = "tcDatos"
            Me.tcDatos.SelectedIndex = 0
            Me.tcDatos.Size = New System.Drawing.Size(886, 484)
            Me.tcDatos.TabIndex = 0
            '
            'tpDatos
            '
            Me.tpDatos.BackColor = System.Drawing.Color.White
            Me.tpDatos.Controls.Add(Me.Label15)
            Me.tpDatos.Controls.Add(Me.lblNombres)
            Me.tpDatos.Controls.Add(Me.cbmParroquia)
            Me.tpDatos.Controls.Add(Me.Label14)
            Me.tpDatos.Controls.Add(Me.btnBuscarCustodio)
            Me.tpDatos.Controls.Add(Me.txtIdCustodio)
            Me.tpDatos.Controls.Add(Me.cbmCiudad)
            Me.tpDatos.Controls.Add(Me.Label11)
            Me.tpDatos.Controls.Add(Me.cbmProvincia)
            Me.tpDatos.Controls.Add(Me.txtCuentaContable)
            Me.tpDatos.Controls.Add(Me.cbmNivelCuenta)
            Me.tpDatos.Controls.Add(Me.Label9)
            Me.tpDatos.Controls.Add(Me.Label10)
            Me.tpDatos.Controls.Add(Me.cbmTipoCuenta)
            Me.tpDatos.Controls.Add(Me.cbmCentroCosto)
            Me.tpDatos.Controls.Add(Me.Label8)
            Me.tpDatos.Controls.Add(Me.txtValorGasto)
            Me.tpDatos.Controls.Add(Me.Label3)
            Me.tpDatos.Controls.Add(Me.txtMonto)
            Me.tpDatos.Controls.Add(Me.txtDetalle)
            Me.tpDatos.Controls.Add(Me.Label7)
            Me.tpDatos.Controls.Add(Me.txtIdCajaChica)
            Me.tpDatos.Controls.Add(Me.Label6)
            Me.tpDatos.Controls.Add(Me.Label1)
            Me.tpDatos.Controls.Add(Me.Label2)
            Me.tpDatos.Controls.Add(Me.Label5)
            Me.tpDatos.Controls.Add(Me.Label4)
            Me.tpDatos.Controls.Add(Me.dgvCajas)
            Me.tpDatos.Location = New System.Drawing.Point(4, 22)
            Me.tpDatos.Name = "tpDatos"
            Me.tpDatos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDatos.Size = New System.Drawing.Size(878, 458)
            Me.tpDatos.TabIndex = 0
            Me.tpDatos.Text = "DATOS"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(9, 35)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(57, 13)
            Me.Label15.TabIndex = 56
            Me.Label15.Text = "CUSTODIO:"
            '
            'lblNombres
            '
            Me.lblNombres.BackColor = System.Drawing.Color.White
            Me.lblNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.lblNombres.Enabled = False
            Me.lblNombres.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombres.Location = New System.Drawing.Point(74, 32)
            Me.lblNombres.Name = "lblNombres"
            Me.lblNombres.Size = New System.Drawing.Size(368, 21)
            Me.lblNombres.TabIndex = 55
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(552, 87)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(176, 21)
            Me.cbmParroquia.TabIndex = 54
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(461, 95)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(60, 13)
            Me.Label14.TabIndex = 53
            Me.Label14.Text = "PARROQUIA"
            '
            'btnBuscarCustodio
            '
            Me.btnBuscarCustodio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscarCustodio.Enabled = False
            Me.btnBuscarCustodio.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscarCustodio.Location = New System.Drawing.Point(413, 4)
            Me.btnBuscarCustodio.Name = "btnBuscarCustodio"
            Me.btnBuscarCustodio.Size = New System.Drawing.Size(29, 23)
            Me.btnBuscarCustodio.TabIndex = 44
            Me.btnBuscarCustodio.UseVisualStyleBackColor = True
            '
            'txtIdCustodio
            '
            Me.txtIdCustodio.BackColor = System.Drawing.Color.White
            Me.txtIdCustodio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCustodio.Enabled = False
            Me.txtIdCustodio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCustodio.Location = New System.Drawing.Point(339, 5)
            Me.txtIdCustodio.Name = "txtIdCustodio"
            Me.txtIdCustodio.Size = New System.Drawing.Size(68, 21)
            Me.txtIdCustodio.TabIndex = 50
            '
            'cbmCiudad
            '
            Me.cbmCiudad.BackColor = System.Drawing.Color.White
            Me.cbmCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCiudad.Enabled = False
            Me.cbmCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCiudad.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCiudad.FormattingEnabled = True
            Me.cbmCiudad.Location = New System.Drawing.Point(552, 59)
            Me.cbmCiudad.Name = "cbmCiudad"
            Me.cbmCiudad.Size = New System.Drawing.Size(176, 21)
            Me.cbmCiudad.TabIndex = 49
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(264, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(69, 13)
            Me.Label11.TabIndex = 42
            Me.Label11.Text = "ID CUSTODIO:"
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(552, 32)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(176, 21)
            Me.cbmProvincia.TabIndex = 48
            '
            'txtCuentaContable
            '
            Me.txtCuentaContable.BackColor = System.Drawing.Color.White
            Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaContable.Enabled = False
            Me.txtCuentaContable.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaContable.Location = New System.Drawing.Point(750, 92)
            Me.txtCuentaContable.Name = "txtCuentaContable"
            Me.txtCuentaContable.Size = New System.Drawing.Size(122, 23)
            Me.txtCuentaContable.TabIndex = 46
            Me.txtCuentaContable.Text = "101010101"
            Me.txtCuentaContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cbmNivelCuenta
            '
            Me.cbmNivelCuenta.BackColor = System.Drawing.Color.White
            Me.cbmNivelCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmNivelCuenta.Enabled = False
            Me.cbmNivelCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmNivelCuenta.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmNivelCuenta.FormattingEnabled = True
            Me.cbmNivelCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
            Me.cbmNivelCuenta.Location = New System.Drawing.Point(803, 41)
            Me.cbmNivelCuenta.Name = "cbmNivelCuenta"
            Me.cbmNivelCuenta.Size = New System.Drawing.Size(69, 21)
            Me.cbmNivelCuenta.TabIndex = 45
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(461, 40)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(60, 13)
            Me.Label9.TabIndex = 37
            Me.Label9.Text = "PROVINCIA:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(461, 67)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(46, 13)
            Me.Label10.TabIndex = 40
            Me.Label10.Text = "CIUDAD:"
            '
            'cbmTipoCuenta
            '
            Me.cbmTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cbmTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoCuenta.Enabled = False
            Me.cbmTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoCuenta.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoCuenta.FormattingEnabled = True
            Me.cbmTipoCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
            Me.cbmTipoCuenta.Location = New System.Drawing.Point(803, 10)
            Me.cbmTipoCuenta.Name = "cbmTipoCuenta"
            Me.cbmTipoCuenta.Size = New System.Drawing.Size(69, 21)
            Me.cbmTipoCuenta.TabIndex = 43
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Enabled = False
            Me.cbmCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(552, 4)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(176, 21)
            Me.cbmCentroCosto.TabIndex = 47
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(461, 4)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(45, 26)
            Me.Label8.TabIndex = 35
            Me.Label8.Text = "CENTRO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COSTO:"
            '
            'txtValorGasto
            '
            Me.txtValorGasto.BackColor = System.Drawing.Color.White
            Me.txtValorGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorGasto.Enabled = False
            Me.txtValorGasto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorGasto.Location = New System.Drawing.Point(365, 86)
            Me.txtValorGasto.Name = "txtValorGasto"
            Me.txtValorGasto.Size = New System.Drawing.Size(77, 21)
            Me.txtValorGasto.TabIndex = 38
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(746, 76)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(93, 13)
            Me.Label3.TabIndex = 28
            Me.Label3.Text = "CUENTA CONTABLE:"
            '
            'txtMonto
            '
            Me.txtMonto.BackColor = System.Drawing.Color.White
            Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMonto.Enabled = False
            Me.txtMonto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(74, 86)
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(77, 21)
            Me.txtMonto.TabIndex = 36
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.Location = New System.Drawing.Point(74, 60)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(368, 21)
            Me.txtDetalle.TabIndex = 33
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(747, 44)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(45, 26)
            Me.Label7.TabIndex = 34
            Me.Label7.Text = "NIVEL " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUENTA:"
            '
            'txtIdCajaChica
            '
            Me.txtIdCajaChica.BackColor = System.Drawing.Color.White
            Me.txtIdCajaChica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCajaChica.Enabled = False
            Me.txtIdCajaChica.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCajaChica.Location = New System.Drawing.Point(74, 5)
            Me.txtIdCajaChica.Name = "txtIdCajaChica"
            Me.txtIdCajaChica.Size = New System.Drawing.Size(55, 21)
            Me.txtIdCajaChica.TabIndex = 32
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(746, 10)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 26)
            Me.Label6.TabIndex = 31
            Me.Label6.Text = "TIPO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUENTA:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(9, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 26
            Me.Label1.Text = "ID CAJA:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(9, 63)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(47, 13)
            Me.Label2.TabIndex = 27
            Me.Label2.Text = "DETALLE:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(9, 87)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(45, 13)
            Me.Label5.TabIndex = 30
            Me.Label5.Text = "MONTO:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(298, 84)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 26)
            Me.Label4.TabIndex = 29
            Me.Label4.Text = "VALOR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "POR GASTO:"
            '
            'dgvCajas
            '
            Me.dgvCajas.AllowUserToAddRows = False
            Me.dgvCajas.AllowUserToDeleteRows = False
            Me.dgvCajas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCajas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCajas.BackgroundColor = System.Drawing.Color.White
            Me.dgvCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCajas.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCajas.Location = New System.Drawing.Point(3, 121)
            Me.dgvCajas.MultiSelect = False
            Me.dgvCajas.Name = "dgvCajas"
            Me.dgvCajas.ReadOnly = True
            Me.dgvCajas.RowHeadersVisible = False
            Me.dgvCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCajas.Size = New System.Drawing.Size(872, 335)
            Me.dgvCajas.TabIndex = 14
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.crvCajasChicasCustodios)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(878, 458)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'crvCajasChicasCustodios
            '
            Me.crvCajasChicasCustodios.ActiveViewIndex = -1
            Me.crvCajasChicasCustodios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvCajasChicasCustodios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvCajasChicasCustodios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvCajasChicasCustodios.Location = New System.Drawing.Point(3, 3)
            Me.crvCajasChicasCustodios.Name = "crvCajasChicasCustodios"
            Me.crvCajasChicasCustodios.Size = New System.Drawing.Size(872, 452)
            Me.crvCajasChicasCustodios.TabIndex = 0
            Me.crvCajasChicasCustodios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevaCaja, Me.btnGuardar, Me.btnModificar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
            Me.MenuStrip1.TabIndex = 198
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
            'btnNuevaCaja
            '
            Me.btnNuevaCaja.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevaCaja.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevaCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevaCaja.Name = "btnNuevaCaja"
            Me.btnNuevaCaja.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevaCaja.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(98, 20)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'FormEstablecerCajasChicas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(893, 517)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcDatos)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormEstablecerCajasChicas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ESTABLECER CAJAS CHICAS"
            Me.tcDatos.ResumeLayout(False)
            Me.tpDatos.ResumeLayout(False)
            Me.tpDatos.PerformLayout()
            CType(Me.dgvCajas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpReporte.ResumeLayout(False)
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcDatos As System.Windows.Forms.TabControl
        Friend WithEvents tpDatos As System.Windows.Forms.TabPage
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents btnBuscarCustodio As System.Windows.Forms.Button
        Friend WithEvents txtIdCustodio As System.Windows.Forms.TextBox
        Friend WithEvents cbmCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
        Friend WithEvents cbmNivelCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cbmTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtValorGasto As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtIdCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dgvCajas As System.Windows.Forms.DataGridView
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvCajasChicasCustodios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevaCaja As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblNombres As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace