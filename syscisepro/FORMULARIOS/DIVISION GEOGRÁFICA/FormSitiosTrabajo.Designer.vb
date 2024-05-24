Namespace FORMULARIOS.DIVISION_GEOGRÁFICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormSitiosTrabajo
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSitiosTrabajo))
            Me.tcSitios = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.chkExtra = New System.Windows.Forms.CheckBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtAdicional = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtHorasNoct = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtHorasFeria = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtHoras100 = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtHoras50 = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtHorasNormal = New System.Windows.Forms.TextBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.cbxFiltro = New System.Windows.Forms.ComboBox()
            Me.txtFiltro = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cbmGrupo = New System.Windows.Forms.ComboBox()
            Me.cbxHorasPuesto = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtRiver = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtLongitud = New System.Windows.Forms.TextBox()
            Me.txtLatitud = New System.Windows.Forms.TextBox()
            Me.txtNombreSitio = New System.Windows.Forms.TextBox()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.txtReferencia = New System.Windows.Forms.TextBox()
            Me.lblReferencia = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.lblDireccion = New System.Windows.Forms.Label()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.lblParroquia = New System.Windows.Forms.Label()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.cbxSupervisor = New System.Windows.Forms.ComboBox()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.lblTipo = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.cbxTipoIdentificacion = New System.Windows.Forms.ComboBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtCiRuc = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtClienteComercial = New System.Windows.Forms.TextBox()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargarSitios = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevoSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnActualizarSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnularSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportarSitio = New System.Windows.Forms.ToolStripMenuItem()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgvCategoriaItem = New System.Windows.Forms.DataGridView()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.ListView3 = New System.Windows.Forms.ListView()
            Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cbmProvincia2 = New System.Windows.Forms.TextBox()
            Me.cbmGrupo2 = New System.Windows.Forms.ComboBox()
            Me.txtRiver2 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtLongitud2 = New System.Windows.Forms.TextBox()
            Me.txtLatitud2 = New System.Windows.Forms.TextBox()
            Me.txtNombreSitio2 = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtReferencia2 = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtDireccion2 = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.crvSitios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.tcSitios.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip2.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.tpReporte.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcSitios
            '
            Me.tcSitios.Controls.Add(Me.TabPage1)
            Me.tcSitios.Controls.Add(Me.TabPage2)
            Me.tcSitios.Controls.Add(Me.tpReporte)
            Me.tcSitios.Location = New System.Drawing.Point(2, 2)
            Me.tcSitios.Name = "tcSitios"
            Me.tcSitios.SelectedIndex = 0
            Me.tcSitios.Size = New System.Drawing.Size(921, 692)
            Me.tcSitios.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.White
            Me.TabPage1.Controls.Add(Me.GroupBox5)
            Me.TabPage1.Controls.Add(Me.Label24)
            Me.TabPage1.Controls.Add(Me.cbxFiltro)
            Me.TabPage1.Controls.Add(Me.txtFiltro)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.MenuStrip1)
            Me.TabPage1.Controls.Add(Me.ListView1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(913, 666)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "MANTENIMIENTO"
            '
            'GroupBox5
            '
            Me.GroupBox5.BackColor = System.Drawing.Color.White
            Me.GroupBox5.Controls.Add(Me.chkExtra)
            Me.GroupBox5.Controls.Add(Me.Label19)
            Me.GroupBox5.Controls.Add(Me.txtAdicional)
            Me.GroupBox5.Controls.Add(Me.Label20)
            Me.GroupBox5.Controls.Add(Me.txtHorasNoct)
            Me.GroupBox5.Controls.Add(Me.Label14)
            Me.GroupBox5.Controls.Add(Me.txtHorasFeria)
            Me.GroupBox5.Controls.Add(Me.Label15)
            Me.GroupBox5.Controls.Add(Me.txtHoras100)
            Me.GroupBox5.Controls.Add(Me.Label13)
            Me.GroupBox5.Controls.Add(Me.txtHoras50)
            Me.GroupBox5.Controls.Add(Me.Label11)
            Me.GroupBox5.Controls.Add(Me.txtHorasNormal)
            Me.GroupBox5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox5.Location = New System.Drawing.Point(1, 209)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(907, 73)
            Me.GroupBox5.TabIndex = 200
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "DATOS CONTABLES (DESGLOSE DE HORAS Y SOBRETIEMPO SEGÚN PARÁMETROS EN ROL DE PAGOS" & _
                ")"
            '
            'chkExtra
            '
            Me.chkExtra.Enabled = False
            Me.chkExtra.Location = New System.Drawing.Point(716, 17)
            Me.chkExtra.Name = "chkExtra"
            Me.chkExtra.Size = New System.Drawing.Size(88, 48)
            Me.chkExtra.TabIndex = 212
            Me.chkExtra.Text = "XIII - F. RES. con extra?"
            Me.chkExtra.UseVisualStyleBackColor = True
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.Location = New System.Drawing.Point(523, 48)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(105, 13)
            Me.Label19.TabIndex = 211
            Me.Label19.Text = "VALOR ADICIONAL ($):"
            '
            'txtAdicional
            '
            Me.txtAdicional.BackColor = System.Drawing.Color.White
            Me.txtAdicional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtAdicional.Enabled = False
            Me.txtAdicional.Location = New System.Drawing.Point(628, 45)
            Me.txtAdicional.Name = "txtAdicional"
            Me.txtAdicional.Size = New System.Drawing.Size(62, 20)
            Me.txtAdicional.TabIndex = 210
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.Location = New System.Drawing.Point(523, 22)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(96, 13)
            Me.Label20.TabIndex = 209
            Me.Label20.Text = "RECARGO NOCT ($). "
            '
            'txtHorasNoct
            '
            Me.txtHorasNoct.BackColor = System.Drawing.Color.White
            Me.txtHorasNoct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHorasNoct.Enabled = False
            Me.txtHorasNoct.Location = New System.Drawing.Point(628, 19)
            Me.txtHorasNoct.Name = "txtHorasNoct"
            Me.txtHorasNoct.Size = New System.Drawing.Size(62, 20)
            Me.txtHorasNoct.TabIndex = 208
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(209, 48)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(220, 13)
            Me.Label14.TabIndex = 207
            Me.Label14.Text = "N°. HORAS EXT. 100% RECARGO (SAB-DOM-FER):"
            '
            'txtHorasFeria
            '
            Me.txtHorasFeria.BackColor = System.Drawing.Color.White
            Me.txtHorasFeria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHorasFeria.Enabled = False
            Me.txtHorasFeria.Location = New System.Drawing.Point(435, 45)
            Me.txtHorasFeria.Name = "txtHorasFeria"
            Me.txtHorasFeria.Size = New System.Drawing.Size(62, 20)
            Me.txtHorasFeria.TabIndex = 206
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(209, 22)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(186, 13)
            Me.Label15.TabIndex = 205
            Me.Label15.Text = "N°. HORAS EXT. 100% SUPLEMENTARIAS:"
            '
            'txtHoras100
            '
            Me.txtHoras100.BackColor = System.Drawing.Color.White
            Me.txtHoras100.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras100.Enabled = False
            Me.txtHoras100.Location = New System.Drawing.Point(434, 19)
            Me.txtHoras100.Name = "txtHoras100"
            Me.txtHoras100.Size = New System.Drawing.Size(62, 20)
            Me.txtHoras100.TabIndex = 204
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(13, 48)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(96, 13)
            Me.Label13.TabIndex = 203
            Me.Label13.Text = "N°. HORAS EXT. 50%"
            '
            'txtHoras50
            '
            Me.txtHoras50.BackColor = System.Drawing.Color.White
            Me.txtHoras50.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHoras50.Enabled = False
            Me.txtHoras50.Location = New System.Drawing.Point(128, 45)
            Me.txtHoras50.Name = "txtHoras50"
            Me.txtHoras50.Size = New System.Drawing.Size(62, 20)
            Me.txtHoras50.TabIndex = 202
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(13, 22)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(109, 13)
            Me.Label11.TabIndex = 201
            Me.Label11.Text = "N°. HORAS NORMALES:"
            '
            'txtHorasNormal
            '
            Me.txtHorasNormal.BackColor = System.Drawing.Color.White
            Me.txtHorasNormal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtHorasNormal.Enabled = False
            Me.txtHorasNormal.Location = New System.Drawing.Point(128, 19)
            Me.txtHorasNormal.Name = "txtHorasNormal"
            Me.txtHorasNormal.Size = New System.Drawing.Size(62, 20)
            Me.txtHorasNormal.TabIndex = 200
            '
            'Label24
            '
            Me.Label24.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label24.Location = New System.Drawing.Point(1, 285)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(911, 18)
            Me.Label24.TabIndex = 199
            Me.Label24.Text = "STIO / PUESTOS REGISTRADOS"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'cbxFiltro
            '
            Me.cbxFiltro.BackColor = System.Drawing.Color.White
            Me.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxFiltro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxFiltro.FormattingEnabled = True
            Me.cbxFiltro.Items.AddRange(New Object() {"-- TODOS --", "ACTIVOS", "INACTIVOS"})
            Me.cbxFiltro.Location = New System.Drawing.Point(785, 308)
            Me.cbxFiltro.Name = "cbxFiltro"
            Me.cbxFiltro.Size = New System.Drawing.Size(126, 21)
            Me.cbxFiltro.TabIndex = 198
            '
            'txtFiltro
            '
            Me.txtFiltro.BackColor = System.Drawing.Color.White
            Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFiltro.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFiltro.Location = New System.Drawing.Point(50, 308)
            Me.txtFiltro.Name = "txtFiltro"
            Me.txtFiltro.Size = New System.Drawing.Size(733, 21)
            Me.txtFiltro.TabIndex = 191
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label7.Location = New System.Drawing.Point(5, 312)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(48, 13)
            Me.Label7.TabIndex = 190
            Me.Label7.Text = "FILTRO:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.White
            Me.GroupBox2.Controls.Add(Me.cbmGrupo)
            Me.GroupBox2.Controls.Add(Me.cbxHorasPuesto)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtRiver)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.txtLongitud)
            Me.GroupBox2.Controls.Add(Me.txtLatitud)
            Me.GroupBox2.Controls.Add(Me.txtNombreSitio)
            Me.GroupBox2.Controls.Add(Me.lblNombre)
            Me.GroupBox2.Controls.Add(Me.txtReferencia)
            Me.GroupBox2.Controls.Add(Me.lblReferencia)
            Me.GroupBox2.Controls.Add(Me.txtDireccion)
            Me.GroupBox2.Controls.Add(Me.lblDireccion)
            Me.GroupBox2.Controls.Add(Me.cbmProvincia)
            Me.GroupBox2.Controls.Add(Me.cbmParroquia)
            Me.GroupBox2.Controls.Add(Me.cbmCanton)
            Me.GroupBox2.Controls.Add(Me.lblProvincia)
            Me.GroupBox2.Controls.Add(Me.lblParroquia)
            Me.GroupBox2.Controls.Add(Me.lblCiudad)
            Me.GroupBox2.Controls.Add(Me.Label28)
            Me.GroupBox2.Controls.Add(Me.cbxSupervisor)
            Me.GroupBox2.Controls.Add(Me.Label27)
            Me.GroupBox2.Controls.Add(Me.lblTipo)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(4, 90)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(907, 119)
            Me.GroupBox2.TabIndex = 187
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "LUGAR (SITIO TRABAJO)"
            '
            'cbmGrupo
            '
            Me.cbmGrupo.BackColor = System.Drawing.Color.White
            Me.cbmGrupo.Enabled = False
            Me.cbmGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmGrupo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo.FormattingEnabled = True
            Me.cbmGrupo.Location = New System.Drawing.Point(725, 40)
            Me.cbmGrupo.Name = "cbmGrupo"
            Me.cbmGrupo.Size = New System.Drawing.Size(178, 21)
            Me.cbmGrupo.TabIndex = 201
            '
            'cbxHorasPuesto
            '
            Me.cbxHorasPuesto.BackColor = System.Drawing.Color.White
            Me.cbxHorasPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxHorasPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxHorasPuesto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxHorasPuesto.FormattingEnabled = True
            Me.cbxHorasPuesto.Location = New System.Drawing.Point(821, 92)
            Me.cbxHorasPuesto.Name = "cbxHorasPuesto"
            Me.cbxHorasPuesto.Size = New System.Drawing.Size(81, 21)
            Me.cbxHorasPuesto.TabIndex = 200
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(770, 95)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 199
            Me.Label9.Text = "PUESTO:"
            '
            'txtRiver
            '
            Me.txtRiver.BackColor = System.Drawing.Color.White
            Me.txtRiver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRiver.Enabled = False
            Me.txtRiver.Location = New System.Drawing.Point(404, 41)
            Me.txtRiver.Name = "txtRiver"
            Me.txtRiver.Size = New System.Drawing.Size(41, 20)
            Me.txtRiver.TabIndex = 198
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(386, 44)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(21, 13)
            Me.Label10.TabIndex = 197
            Me.Label10.Text = "R#:"
            '
            'txtLongitud
            '
            Me.txtLongitud.BackColor = System.Drawing.Color.White
            Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLongitud.Enabled = False
            Me.txtLongitud.Location = New System.Drawing.Point(563, 41)
            Me.txtLongitud.Name = "txtLongitud"
            Me.txtLongitud.Size = New System.Drawing.Size(72, 20)
            Me.txtLongitud.TabIndex = 192
            '
            'txtLatitud
            '
            Me.txtLatitud.BackColor = System.Drawing.Color.White
            Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLatitud.Enabled = False
            Me.txtLatitud.Location = New System.Drawing.Point(490, 41)
            Me.txtLatitud.Name = "txtLatitud"
            Me.txtLatitud.Size = New System.Drawing.Size(72, 20)
            Me.txtLatitud.TabIndex = 191
            '
            'txtNombreSitio
            '
            Me.txtNombreSitio.BackColor = System.Drawing.Color.White
            Me.txtNombreSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreSitio.Enabled = False
            Me.txtNombreSitio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSitio.Location = New System.Drawing.Point(68, 40)
            Me.txtNombreSitio.Name = "txtNombreSitio"
            Me.txtNombreSitio.Size = New System.Drawing.Size(298, 21)
            Me.txtNombreSitio.TabIndex = 29
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombre.Location = New System.Drawing.Point(5, 43)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(50, 13)
            Me.lblNombre.TabIndex = 32
            Me.lblNombre.Text = "NOMBRE:"
            '
            'txtReferencia
            '
            Me.txtReferencia.BackColor = System.Drawing.Color.White
            Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia.Enabled = False
            Me.txtReferencia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReferencia.Location = New System.Drawing.Point(68, 92)
            Me.txtReferencia.Name = "txtReferencia"
            Me.txtReferencia.Size = New System.Drawing.Size(696, 21)
            Me.txtReferencia.TabIndex = 31
            '
            'lblReferencia
            '
            Me.lblReferencia.AutoSize = True
            Me.lblReferencia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReferencia.Location = New System.Drawing.Point(4, 95)
            Me.lblReferencia.Name = "lblReferencia"
            Me.lblReferencia.Size = New System.Drawing.Size(64, 13)
            Me.lblReferencia.TabIndex = 34
            Me.lblReferencia.Text = "REFERENCIA:"
            '
            'txtDireccion
            '
            Me.txtDireccion.BackColor = System.Drawing.Color.White
            Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccion.Enabled = False
            Me.txtDireccion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(68, 65)
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(836, 21)
            Me.txtDireccion.TabIndex = 30
            '
            'lblDireccion
            '
            Me.lblDireccion.AutoSize = True
            Me.lblDireccion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDireccion.Location = New System.Drawing.Point(5, 68)
            Me.lblDireccion.Name = "lblDireccion"
            Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
            Me.lblDireccion.TabIndex = 33
            Me.lblDireccion.Text = "DIRECCION:"
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(69, 13)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(193, 21)
            Me.cbmProvincia.TabIndex = 23
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(725, 13)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(178, 21)
            Me.cbmParroquia.TabIndex = 25
            '
            'cbmCanton
            '
            Me.cbmCanton.BackColor = System.Drawing.Color.White
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Enabled = False
            Me.cbmCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCanton.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(369, 13)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(207, 21)
            Me.cbmCanton.TabIndex = 24
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProvincia.Location = New System.Drawing.Point(4, 16)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(60, 13)
            Me.lblProvincia.TabIndex = 26
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'lblParroquia
            '
            Me.lblParroquia.AutoSize = True
            Me.lblParroquia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblParroquia.Location = New System.Drawing.Point(661, 16)
            Me.lblParroquia.Name = "lblParroquia"
            Me.lblParroquia.Size = New System.Drawing.Size(63, 13)
            Me.lblParroquia.TabIndex = 27
            Me.lblParroquia.Text = "PARROQUIA:"
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudad.Location = New System.Drawing.Point(318, 16)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(48, 13)
            Me.lblCiudad.TabIndex = 28
            Me.lblCiudad.Text = "CANTÓN:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(141, 0)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(25, 13)
            Me.Label28.TabIndex = 6
            Me.Label28.Text = "..."
            '
            'cbxSupervisor
            '
            Me.cbxSupervisor.BackColor = System.Drawing.Color.White
            Me.cbxSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxSupervisor.Enabled = False
            Me.cbxSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxSupervisor.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxSupervisor.FormattingEnabled = True
            Me.cbxSupervisor.Location = New System.Drawing.Point(625, 65)
            Me.cbxSupervisor.Name = "cbxSupervisor"
            Me.cbxSupervisor.Size = New System.Drawing.Size(277, 21)
            Me.cbxSupervisor.TabIndex = 186
            Me.cbxSupervisor.Visible = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label27.Location = New System.Drawing.Point(43, 95)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(73, 13)
            Me.Label27.TabIndex = 185
            Me.Label27.Text = "SUPERVISOR:"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Label27.Visible = False
            '
            'lblTipo
            '
            Me.lblTipo.AutoSize = True
            Me.lblTipo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipo.Location = New System.Drawing.Point(676, 44)
            Me.lblTipo.Name = "lblTipo"
            Me.lblTipo.Size = New System.Drawing.Size(43, 13)
            Me.lblTipo.TabIndex = 188
            Me.lblTipo.Text = "GRUPO:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(459, 44)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(34, 13)
            Me.Label8.TabIndex = 189
            Me.Label8.Text = "LT/LG:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.btnBuscarPersonal)
            Me.GroupBox1.Controls.Add(Me.cbxTipoIdentificacion)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.Label23)
            Me.GroupBox1.Controls.Add(Me.Label25)
            Me.GroupBox1.Controls.Add(Me.txtCiRuc)
            Me.GroupBox1.Controls.Add(Me.Label26)
            Me.GroupBox1.Controls.Add(Me.txtClienteComercial)
            Me.GroupBox1.Controls.Add(Me.txtCliente)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(907, 64)
            Me.GroupBox1.TabIndex = 183
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "CLIENTE"
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Enabled = False
            Me.btnBuscarPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarPersonal.Image = CType(resources.GetObject("btnBuscarPersonal.Image"), System.Drawing.Image)
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(875, 11)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(29, 23)
            Me.btnBuscarPersonal.TabIndex = 27
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'cbxTipoIdentificacion
            '
            Me.cbxTipoIdentificacion.BackColor = System.Drawing.Color.White
            Me.cbxTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoIdentificacion.DropDownWidth = 200
            Me.cbxTipoIdentificacion.Enabled = False
            Me.cbxTipoIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbxTipoIdentificacion.FormattingEnabled = True
            Me.cbxTipoIdentificacion.Items.AddRange(New Object() {"RUC", "CEDULA", "PASAPORTE", "VENTA A CONSUMIDOR FINAL", "IDENTIFICACION DEL EXTERIOR"})
            Me.cbxTipoIdentificacion.Location = New System.Drawing.Point(140, 12)
            Me.cbxTipoIdentificacion.Name = "cbxTipoIdentificacion"
            Me.cbxTipoIdentificacion.Size = New System.Drawing.Size(176, 21)
            Me.cbxTipoIdentificacion.TabIndex = 9
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(7, 16)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(127, 13)
            Me.Label22.TabIndex = 8
            Me.Label22.Text = "TIPO IDENTIFICACIÓN:"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(57, 0)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(25, 13)
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "..."
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(7, 41)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(55, 13)
            Me.Label25.TabIndex = 4
            Me.Label25.Text = "CLIENTE:"
            '
            'txtCiRuc
            '
            Me.txtCiRuc.BackColor = System.Drawing.Color.White
            Me.txtCiRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCiRuc.Enabled = False
            Me.txtCiRuc.Location = New System.Drawing.Point(746, 13)
            Me.txtCiRuc.Name = "txtCiRuc"
            Me.txtCiRuc.Size = New System.Drawing.Size(123, 20)
            Me.txtCiRuc.TabIndex = 0
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(661, 17)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(79, 13)
            Me.Label26.TabIndex = 3
            Me.Label26.Text = "RUC / C. I.:"
            '
            'txtClienteComercial
            '
            Me.txtClienteComercial.BackColor = System.Drawing.Color.White
            Me.txtClienteComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtClienteComercial.Enabled = False
            Me.txtClienteComercial.Location = New System.Drawing.Point(474, 38)
            Me.txtClienteComercial.Name = "txtClienteComercial"
            Me.txtClienteComercial.Size = New System.Drawing.Size(430, 20)
            Me.txtClienteComercial.TabIndex = 2
            '
            'txtCliente
            '
            Me.txtCliente.BackColor = System.Drawing.Color.White
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Enabled = False
            Me.txtCliente.Location = New System.Drawing.Point(68, 38)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Size = New System.Drawing.Size(400, 20)
            Me.txtCliente.TabIndex = 1
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargarSitios, Me.btnNuevoSitio, Me.btnGuardarSitio, Me.btnActualizarSitio, Me.btnAnularSitio, Me.btnCancelarSitio, Me.btnExportarSitio})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(907, 24)
            Me.MenuStrip1.TabIndex = 182
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargarSitios
            '
            Me.btnCargarSitios.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargarSitios.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnCargarSitios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargarSitios.Name = "btnCargarSitios"
            Me.btnCargarSitios.Size = New System.Drawing.Size(119, 20)
            Me.btnCargarSitios.Text = "LISTAR TODOS"
            '
            'btnNuevoSitio
            '
            Me.btnNuevoSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoSitio.Image = CType(resources.GetObject("btnNuevoSitio.Image"), System.Drawing.Image)
            Me.btnNuevoSitio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoSitio.Name = "btnNuevoSitio"
            Me.btnNuevoSitio.Size = New System.Drawing.Size(70, 20)
            Me.btnNuevoSitio.Text = "NUEVO"
            '
            'btnGuardarSitio
            '
            Me.btnGuardarSitio.Enabled = False
            Me.btnGuardarSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarSitio.Image = CType(resources.GetObject("btnGuardarSitio.Image"), System.Drawing.Image)
            Me.btnGuardarSitio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarSitio.Name = "btnGuardarSitio"
            Me.btnGuardarSitio.Size = New System.Drawing.Size(84, 20)
            Me.btnGuardarSitio.Text = "GUARDAR"
            '
            'btnActualizarSitio
            '
            Me.btnActualizarSitio.Enabled = False
            Me.btnActualizarSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizarSitio.Image = CType(resources.GetObject("btnActualizarSitio.Image"), System.Drawing.Image)
            Me.btnActualizarSitio.Name = "btnActualizarSitio"
            Me.btnActualizarSitio.Size = New System.Drawing.Size(105, 20)
            Me.btnActualizarSitio.Text = "ACTUALIZAR"
            '
            'btnAnularSitio
            '
            Me.btnAnularSitio.Enabled = False
            Me.btnAnularSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnularSitio.Image = CType(resources.GetObject("btnAnularSitio.Image"), System.Drawing.Image)
            Me.btnAnularSitio.Name = "btnAnularSitio"
            Me.btnAnularSitio.Size = New System.Drawing.Size(77, 20)
            Me.btnAnularSitio.Text = "ANULAR"
            '
            'btnCancelarSitio
            '
            Me.btnCancelarSitio.Enabled = False
            Me.btnCancelarSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarSitio.Image = CType(resources.GetObject("btnCancelarSitio.Image"), System.Drawing.Image)
            Me.btnCancelarSitio.Name = "btnCancelarSitio"
            Me.btnCancelarSitio.Size = New System.Drawing.Size(91, 20)
            Me.btnCancelarSitio.Text = "CANCELAR"
            '
            'btnExportarSitio
            '
            Me.btnExportarSitio.Enabled = False
            Me.btnExportarSitio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarSitio.Image = CType(resources.GetObject("btnExportarSitio.Image"), System.Drawing.Image)
            Me.btnExportarSitio.Name = "btnExportarSitio"
            Me.btnExportarSitio.Size = New System.Drawing.Size(91, 20)
            Me.btnExportarSitio.Text = "EXPORTAR"
            '
            'ListView1
            '
            Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader23, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader39, Me.ColumnHeader40})
            Me.ListView1.FullRowSelect = True
            Me.ListView1.Location = New System.Drawing.Point(3, 332)
            Me.ListView1.MultiSelect = False
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(907, 331)
            Me.ListView1.TabIndex = 196
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 0
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "SITIO"
            Me.ColumnHeader4.Width = 200
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "# RIVER"
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "IDP"
            Me.ColumnHeader5.Width = 0
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "PROVINCIA"
            Me.ColumnHeader6.Width = 0
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "IDC"
            Me.ColumnHeader2.Width = 0
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "CIUDAD"
            Me.ColumnHeader3.Width = 120
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "IDP"
            Me.ColumnHeader7.Width = 0
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "PARROQUIA"
            Me.ColumnHeader8.Width = 0
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "DIRECCION"
            Me.ColumnHeader9.Width = 250
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "REFERENCIA"
            Me.ColumnHeader10.Width = 250
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "TIPO"
            Me.ColumnHeader11.Width = 0
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "IDS"
            Me.ColumnHeader12.Width = 0
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "SUPERVISOR"
            Me.ColumnHeader13.Width = 0
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "ESTADO"
            Me.ColumnHeader14.Width = 0
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "IDC"
            Me.ColumnHeader15.Width = 0
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "TIPO"
            Me.ColumnHeader16.Width = 0
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "CI - RUC"
            Me.ColumnHeader17.Width = 0
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "RAZÓN SOCIAL"
            Me.ColumnHeader18.Width = 0
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "NOMBRE COMERCIAL"
            Me.ColumnHeader19.Width = 0
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "LATITUD"
            Me.ColumnHeader20.Width = 80
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "LONGITUD"
            Me.ColumnHeader21.Width = 80
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "GRUPO"
            Me.ColumnHeader22.Width = 150
            '
            'ColumnHeader39
            '
            Me.ColumnHeader39.Text = "RIVE"
            Me.ColumnHeader39.Width = 0
            '
            'ColumnHeader40
            '
            Me.ColumnHeader40.Text = "PUESTO"
            Me.ColumnHeader40.Width = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.dgvCategoriaItem)
            Me.TabPage2.Controls.Add(Me.Label33)
            Me.TabPage2.Controls.Add(Me.Label32)
            Me.TabPage2.Controls.Add(Me.ListView3)
            Me.TabPage2.Controls.Add(Me.MenuStrip2)
            Me.TabPage2.Controls.Add(Me.GroupBox4)
            Me.TabPage2.Controls.Add(Me.GroupBox3)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(913, 666)
            Me.TabPage2.TabIndex = 2
            Me.TabPage2.Text = "DETALLES DEL PUESTO"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'dgvCategoriaItem
            '
            Me.dgvCategoriaItem.AllowUserToAddRows = False
            Me.dgvCategoriaItem.AllowUserToDeleteRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCategoriaItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvCategoriaItem.BackgroundColor = System.Drawing.Color.White
            Me.dgvCategoriaItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCategoriaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvCategoriaItem.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvCategoriaItem.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvCategoriaItem.Location = New System.Drawing.Point(4, 434)
            Me.dgvCategoriaItem.MultiSelect = False
            Me.dgvCategoriaItem.Name = "dgvCategoriaItem"
            Me.dgvCategoriaItem.ReadOnly = True
            Me.dgvCategoriaItem.RowHeadersVisible = False
            Me.dgvCategoriaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCategoriaItem.Size = New System.Drawing.Size(906, 229)
            Me.dgvCategoriaItem.TabIndex = 211
            '
            'Label33
            '
            Me.Label33.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label33.Location = New System.Drawing.Point(1, 413)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(911, 18)
            Me.Label33.TabIndex = 210
            Me.Label33.Text = "EQUIPO DE SEGURIDAD ASIGNADO"
            Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label32
            '
            Me.Label32.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Label32.Location = New System.Drawing.Point(1, 127)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(911, 18)
            Me.Label32.TabIndex = 209
            Me.Label32.Text = "STIO / PUESTOS REGISTRADOS"
            Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ListView3
            '
            Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38})
            Me.ListView3.FullRowSelect = True
            Me.ListView3.Location = New System.Drawing.Point(3, 193)
            Me.ListView3.MultiSelect = False
            Me.ListView3.Name = "ListView3"
            Me.ListView3.Size = New System.Drawing.Size(907, 217)
            Me.ListView3.TabIndex = 208
            Me.ListView3.UseCompatibleStateImageBehavior = False
            Me.ListView3.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader24
            '
            Me.ColumnHeader24.Text = "DIA"
            Me.ColumnHeader24.Width = 0
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "FECHA"
            Me.ColumnHeader25.Width = 0
            '
            'ColumnHeader26
            '
            Me.ColumnHeader26.Text = "IDP"
            Me.ColumnHeader26.Width = 0
            '
            'ColumnHeader27
            '
            Me.ColumnHeader27.Text = "CÉDULA"
            Me.ColumnHeader27.Width = 80
            '
            'ColumnHeader28
            '
            Me.ColumnHeader28.Text = "APELLIDOS Y NOMBRES"
            Me.ColumnHeader28.Width = 250
            '
            'ColumnHeader29
            '
            Me.ColumnHeader29.Text = "REGISTRO"
            Me.ColumnHeader29.Width = 80
            '
            'ColumnHeader30
            '
            Me.ColumnHeader30.Text = "HORARIO"
            Me.ColumnHeader30.Width = 120
            '
            'ColumnHeader31
            '
            Me.ColumnHeader31.Text = "HORA ING."
            Me.ColumnHeader31.Width = 80
            '
            'ColumnHeader32
            '
            Me.ColumnHeader32.Text = "050"
            Me.ColumnHeader32.Width = 50
            '
            'ColumnHeader33
            '
            Me.ColumnHeader33.Text = "051"
            Me.ColumnHeader33.Width = 50
            '
            'ColumnHeader34
            '
            Me.ColumnHeader34.Text = "040"
            Me.ColumnHeader34.Width = 50
            '
            'ColumnHeader35
            '
            Me.ColumnHeader35.Text = "041"
            Me.ColumnHeader35.Width = 50
            '
            'ColumnHeader36
            '
            Me.ColumnHeader36.Text = "HORA SAL."
            Me.ColumnHeader36.Width = 80
            '
            'ColumnHeader37
            '
            Me.ColumnHeader37.Text = "MULTA"
            Me.ColumnHeader37.Width = 80
            '
            'ColumnHeader38
            '
            Me.ColumnHeader38.Text = "OBSERVACIONES"
            Me.ColumnHeader38.Width = 300
            '
            'MenuStrip2
            '
            Me.MenuStrip2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem7})
            Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip2.Name = "MenuStrip2"
            Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip2.Size = New System.Drawing.Size(907, 24)
            Me.MenuStrip2.TabIndex = 204
            Me.MenuStrip2.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR DETALLES DEL PUESTO"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Enabled = False
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(84, 20)
            Me.ToolStripMenuItem2.Text = "GUARDAR"
            Me.ToolStripMenuItem2.Visible = False
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Enabled = False
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(105, 20)
            Me.ToolStripMenuItem3.Text = "ACTUALIZAR"
            Me.ToolStripMenuItem3.Visible = False
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Enabled = False
            Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(91, 20)
            Me.ToolStripMenuItem4.Text = "CANCELAR"
            Me.ToolStripMenuItem4.Visible = False
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(91, 20)
            Me.ToolStripMenuItem7.Text = "EXPORTAR"
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.White
            Me.GroupBox4.Controls.Add(Me.DateTimePicker6)
            Me.GroupBox4.Controls.Add(Me.DateTimePicker7)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.Label17)
            Me.GroupBox4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(3, 144)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(907, 47)
            Me.GroupBox4.TabIndex = 203
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "REPORTE DE ASISTENCIA, DEL PUESTO:"
            '
            'DateTimePicker6
            '
            Me.DateTimePicker6.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker6.Location = New System.Drawing.Point(339, 19)
            Me.DateTimePicker6.Name = "DateTimePicker6"
            Me.DateTimePicker6.Size = New System.Drawing.Size(255, 20)
            Me.DateTimePicker6.TabIndex = 202
            '
            'DateTimePicker7
            '
            Me.DateTimePicker7.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker7.Location = New System.Drawing.Point(39, 19)
            Me.DateTimePicker7.Name = "DateTimePicker7"
            Me.DateTimePicker7.Size = New System.Drawing.Size(255, 20)
            Me.DateTimePicker7.TabIndex = 200
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(10, 22)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(31, 13)
            Me.Label18.TabIndex = 201
            Me.Label18.Text = "DEL:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(318, 22)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(25, 13)
            Me.Label17.TabIndex = 203
            Me.Label17.Text = "AL:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.cbmProvincia2)
            Me.GroupBox3.Controls.Add(Me.cbmGrupo2)
            Me.GroupBox3.Controls.Add(Me.txtRiver2)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.txtLongitud2)
            Me.GroupBox3.Controls.Add(Me.txtLatitud2)
            Me.GroupBox3.Controls.Add(Me.txtNombreSitio2)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.txtReferencia2)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.txtDireccion2)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label12)
            Me.GroupBox3.Controls.Add(Me.Label16)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(3, 29)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(907, 95)
            Me.GroupBox3.TabIndex = 188
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "LUGAR (SITIO TRABAJO)"
            '
            'cbmProvincia2
            '
            Me.cbmProvincia2.BackColor = System.Drawing.Color.White
            Me.cbmProvincia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.cbmProvincia2.Enabled = False
            Me.cbmProvincia2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia2.Location = New System.Drawing.Point(68, 15)
            Me.cbmProvincia2.Name = "cbmProvincia2"
            Me.cbmProvincia2.Size = New System.Drawing.Size(376, 21)
            Me.cbmProvincia2.TabIndex = 200
            '
            'cbmGrupo2
            '
            Me.cbmGrupo2.AutoCompleteCustomSource.AddRange(New String() {"FIJO", "TEMPORAL"})
            Me.cbmGrupo2.BackColor = System.Drawing.Color.White
            Me.cbmGrupo2.DropDownWidth = 300
            Me.cbmGrupo2.Enabled = False
            Me.cbmGrupo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmGrupo2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmGrupo2.FormattingEnabled = True
            Me.cbmGrupo2.Location = New System.Drawing.Point(770, 15)
            Me.cbmGrupo2.Name = "cbmGrupo2"
            Me.cbmGrupo2.Size = New System.Drawing.Size(131, 21)
            Me.cbmGrupo2.TabIndex = 187
            '
            'txtRiver2
            '
            Me.txtRiver2.BackColor = System.Drawing.Color.White
            Me.txtRiver2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRiver2.Enabled = False
            Me.txtRiver2.Location = New System.Drawing.Point(475, 15)
            Me.txtRiver2.Name = "txtRiver2"
            Me.txtRiver2.Size = New System.Drawing.Size(55, 20)
            Me.txtRiver2.TabIndex = 198
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(457, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(21, 13)
            Me.Label2.TabIndex = 197
            Me.Label2.Text = "R#:"
            '
            'txtLongitud2
            '
            Me.txtLongitud2.BackColor = System.Drawing.Color.White
            Me.txtLongitud2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLongitud2.Enabled = False
            Me.txtLongitud2.Location = New System.Drawing.Point(644, 15)
            Me.txtLongitud2.Name = "txtLongitud2"
            Me.txtLongitud2.Size = New System.Drawing.Size(72, 20)
            Me.txtLongitud2.TabIndex = 192
            '
            'txtLatitud2
            '
            Me.txtLatitud2.BackColor = System.Drawing.Color.White
            Me.txtLatitud2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLatitud2.Enabled = False
            Me.txtLatitud2.Location = New System.Drawing.Point(572, 15)
            Me.txtLatitud2.Name = "txtLatitud2"
            Me.txtLatitud2.Size = New System.Drawing.Size(72, 20)
            Me.txtLatitud2.TabIndex = 191
            '
            'txtNombreSitio2
            '
            Me.txtNombreSitio2.BackColor = System.Drawing.Color.White
            Me.txtNombreSitio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreSitio2.Enabled = False
            Me.txtNombreSitio2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSitio2.Location = New System.Drawing.Point(68, 42)
            Me.txtNombreSitio2.Name = "txtNombreSitio2"
            Me.txtNombreSitio2.Size = New System.Drawing.Size(462, 21)
            Me.txtNombreSitio2.TabIndex = 29
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(5, 45)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 13)
            Me.Label3.TabIndex = 32
            Me.Label3.Text = "NOMBRE:"
            '
            'txtReferencia2
            '
            Me.txtReferencia2.BackColor = System.Drawing.Color.White
            Me.txtReferencia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia2.Enabled = False
            Me.txtReferencia2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReferencia2.Location = New System.Drawing.Point(608, 41)
            Me.txtReferencia2.Multiline = True
            Me.txtReferencia2.Name = "txtReferencia2"
            Me.txtReferencia2.Size = New System.Drawing.Size(293, 49)
            Me.txtReferencia2.TabIndex = 31
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(540, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(64, 13)
            Me.Label4.TabIndex = 34
            Me.Label4.Text = "REFERENCIA:"
            '
            'txtDireccion2
            '
            Me.txtDireccion2.BackColor = System.Drawing.Color.White
            Me.txtDireccion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccion2.Enabled = False
            Me.txtDireccion2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion2.Location = New System.Drawing.Point(66, 69)
            Me.txtDireccion2.Name = "txtDireccion2"
            Me.txtDireccion2.Size = New System.Drawing.Size(464, 21)
            Me.txtDireccion2.TabIndex = 30
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(4, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(46, 13)
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "CIUDAD:"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(141, 0)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(25, 13)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "..."
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(726, 18)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(43, 13)
            Me.Label16.TabIndex = 188
            Me.Label16.Text = "GRUPO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(540, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(34, 13)
            Me.Label1.TabIndex = 203
            Me.Label1.Text = "LT/LG:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 72)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 13)
            Me.Label5.TabIndex = 33
            Me.Label5.Text = "DIRECCION:"
            '
            'tpReporte
            '
            Me.tpReporte.BackColor = System.Drawing.Color.White
            Me.tpReporte.Controls.Add(Me.Button2)
            Me.tpReporte.Controls.Add(Me.crvSitios)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(913, 666)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE"
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.White
            Me.Button2.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Me.Button2.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button2.Location = New System.Drawing.Point(727, 5)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(181, 25)
            Me.Button2.TabIndex = 191
            Me.Button2.Text = "CARGAR REPORTE SITIOS TRABAJO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button2.UseVisualStyleBackColor = False
            '
            'crvSitios
            '
            Me.crvSitios.ActiveViewIndex = -1
            Me.crvSitios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvSitios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvSitios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvSitios.Location = New System.Drawing.Point(3, 3)
            Me.crvSitios.Name = "crvSitios"
            Me.crvSitios.Size = New System.Drawing.Size(907, 660)
            Me.crvSitios.TabIndex = 0
            Me.crvSitios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormSitiosTrabajo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(924, 696)
            Me.Controls.Add(Me.tcSitios)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormSitiosTrabajo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SITIOS DE TRABAJO"
            Me.tcSitios.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.TabPage2.PerformLayout()
            CType(Me.dgvCategoriaItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip2.ResumeLayout(False)
            Me.MenuStrip2.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.tpReporte.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcSitios As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents crvSitios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnActualizarSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnularSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbxTipoIdentificacion As System.Windows.Forms.ComboBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtCiRuc As System.Windows.Forms.TextBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtClienteComercial As System.Windows.Forms.TextBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents lblTipo As System.Windows.Forms.Label
        Friend WithEvents cbxSupervisor As System.Windows.Forms.ComboBox
        Friend WithEvents txtNombreSitio As System.Windows.Forms.TextBox
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
        Friend WithEvents lblReferencia As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents lblDireccion As System.Windows.Forms.Label
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents lblParroquia As System.Windows.Forms.Label
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents btnCargarSitios As System.Windows.Forms.ToolStripMenuItem
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
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
        Friend WithEvents txtLatitud As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents btnExportarSitio As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtRiver As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
        Friend WithEvents cbxFiltro As System.Windows.Forms.ComboBox
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents cbmGrupo2 As System.Windows.Forms.ComboBox
        Friend WithEvents txtRiver2 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtLongitud2 As System.Windows.Forms.TextBox
        Friend WithEvents txtLatitud2 As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreSitio2 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtReferencia2 As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion2 As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cbmProvincia2 As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents DateTimePicker7 As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ListView3 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label32 As System.Windows.Forms.Label
        Friend WithEvents Label33 As System.Windows.Forms.Label
        Friend WithEvents dgvCategoriaItem As System.Windows.Forms.DataGridView
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents cbxHorasPuesto As System.Windows.Forms.ComboBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents txtHorasNormal As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtHoras50 As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtHorasFeria As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtHoras100 As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtAdicional As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtHorasNoct As System.Windows.Forms.TextBox
        Friend WithEvents chkExtra As System.Windows.Forms.CheckBox
        Friend WithEvents cbmGrupo As System.Windows.Forms.ComboBox
    End Class
End Namespace