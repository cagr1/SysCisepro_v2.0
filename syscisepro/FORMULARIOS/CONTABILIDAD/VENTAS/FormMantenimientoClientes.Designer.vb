Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormMantenimientoClientes
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
            Me.components = New System.ComponentModel.Container()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoClientes))
            Me.cmbTipoIdentificacion = New System.Windows.Forms.ComboBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.txtRucCiClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtApellidoNombreComercial = New System.Windows.Forms.TextBox()
            Me.txtNombreRazonSocialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.rbNOLlevaContabilidad = New System.Windows.Forms.RadioButton()
            Me.rbSILlevaContabilidad = New System.Windows.Forms.RadioButton()
            Me.txtnroResContEspecial = New System.Windows.Forms.TextBox()
            Me.txtDireccionUbicacionClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtDireccionFacturacionClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtCiudad = New System.Windows.Forms.TextBox()
            Me.txtConsorcioGrupo = New System.Windows.Forms.TextBox()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.txtContactoClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtEmailClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtTelefono2ClienteGeneral = New System.Windows.Forms.TextBox()
            Me.txtTelefono1ClienteGeneral = New System.Windows.Forms.TextBox()
            Me.TextBoxVal = New System.Windows.Forms.TextBox()
            Me.ComboBox2 = New System.Windows.Forms.ComboBox()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.dtpFechaIngresoClienteGeneral = New System.Windows.Forms.DateTimePicker()
            Me.cmbTipoCliente = New System.Windows.Forms.ComboBox()
            Me.rbNoContribuyenteEspecial = New System.Windows.Forms.RadioButton()
            Me.rbSiContribuyenteEspecial = New System.Windows.Forms.RadioButton()
            Me.dgvClienteGeneral = New System.Windows.Forms.DataGridView()
            Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
            Me.gbConvenioBancario = New System.Windows.Forms.GroupBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.DataGridView3 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.TextBox12 = New System.Windows.Forms.TextBox()
            Me.TextBox13 = New System.Windows.Forms.TextBox()
            Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvSitios = New System.Windows.Forms.DataGridView()
            Me.cbmTipo = New System.Windows.Forms.ComboBox()
            Me.cbxSupervisor = New System.Windows.Forms.ComboBox()
            Me.txtNombreSitio = New System.Windows.Forms.TextBox()
            Me.txtReferencia = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.cbmCanton = New System.Windows.Forms.ComboBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.AGREGARSITIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
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
            Me.TextBox10 = New System.Windows.Forms.TextBox()
            Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.dgvFacturaVenta = New System.Windows.Forms.DataGridView()
            Me.TextBox7 = New System.Windows.Forms.TextBox()
            Me.ComboBox3 = New System.Windows.Forms.ComboBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.TextBox4 = New System.Windows.Forms.TextBox()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
            Me.TextBox9 = New System.Windows.Forms.TextBox()
            Me.DataGridView2 = New System.Windows.Forms.DataGridView()
            Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.KryptonNavigator1 = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.TabControl1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.chkConvenio = New Krypton.Toolkit.KryptonCheckBox()
            Me.KryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox5 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox4 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox3 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox7 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonGroupBox6 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel21 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel19 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel20 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage3 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox9 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel32 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel31 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel30 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel28 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel29 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel25 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel26 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel27 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox8 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel22 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel23 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel24 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage4 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox10 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel35 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel34 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel33 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage5 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonLabel51 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel50 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel49 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel48 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel47 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel46 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel45 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel44 = New Krypton.Toolkit.KryptonLabel()
            Me.TextBox8 = New System.Windows.Forms.TextBox()
            Me.txtTotalNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtTotalRetencion = New System.Windows.Forms.TextBox()
            Me.txtTotalACobrar = New System.Windows.Forms.TextBox()
            Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
            Me.txtTotalIVA = New System.Windows.Forms.TextBox()
            Me.txtTotalFacturas = New System.Windows.Forms.TextBox()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.lblNroRegistros = New System.Windows.Forms.Label()
            Me.KryptonGroupBox11 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel42 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel41 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel40 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel39 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel36 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel37 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel38 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonPage6 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonLabel43 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvClienteGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbConvenioBancario.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip5.SuspendLayout()
            CType(Me.dgvSitios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.MenuStrip4.SuspendLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip2.SuspendLayout()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip3.SuspendLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonNavigator1.SuspendLayout()
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabControl1.SuspendLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox5.Panel.SuspendLayout()
            Me.KryptonGroupBox5.SuspendLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox4.Panel.SuspendLayout()
            Me.KryptonGroupBox4.SuspendLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox3.Panel.SuspendLayout()
            Me.KryptonGroupBox3.SuspendLayout()
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
            CType(Me.KryptonGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox7.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox7.Panel.SuspendLayout()
            Me.KryptonGroupBox7.SuspendLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox6.Panel.SuspendLayout()
            Me.KryptonGroupBox6.SuspendLayout()
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage3.SuspendLayout()
            CType(Me.KryptonGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox9.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox9.Panel.SuspendLayout()
            Me.KryptonGroupBox9.SuspendLayout()
            CType(Me.KryptonGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox8.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox8.Panel.SuspendLayout()
            Me.KryptonGroupBox8.SuspendLayout()
            CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage4.SuspendLayout()
            CType(Me.KryptonGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox10.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox10.Panel.SuspendLayout()
            Me.KryptonGroupBox10.SuspendLayout()
            CType(Me.KryptonPage5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage5.SuspendLayout()
            CType(Me.KryptonGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox11.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox11.Panel.SuspendLayout()
            Me.KryptonGroupBox11.SuspendLayout()
            CType(Me.KryptonPage6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage6.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmbTipoIdentificacion
            '
            Me.cmbTipoIdentificacion.BackColor = System.Drawing.Color.White
            Me.cmbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoIdentificacion.DropDownWidth = 200
            Me.cmbTipoIdentificacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoIdentificacion.FormattingEnabled = True
            Me.cmbTipoIdentificacion.Items.AddRange(New Object() {"RUC", "CEDULA", "PASAPORTE", "VENTA A CONSUMIDOR FINAL", "IDENTIFICACION DEL EXTERIOR"})
            Me.cmbTipoIdentificacion.Location = New System.Drawing.Point(111, 3)
            Me.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion"
            Me.cmbTipoIdentificacion.Size = New System.Drawing.Size(140, 21)
            Me.cmbTipoIdentificacion.TabIndex = 7
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblIdClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdClienteGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(68, 36)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(16, 13)
            Me.lblIdClienteGeneral.TabIndex = 6
            Me.lblIdClienteGeneral.Text = "..."
            '
            'txtRucCiClienteGeneral
            '
            Me.txtRucCiClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiClienteGeneral.Location = New System.Drawing.Point(313, 4)
            Me.txtRucCiClienteGeneral.Name = "txtRucCiClienteGeneral"
            Me.txtRucCiClienteGeneral.Size = New System.Drawing.Size(121, 21)
            Me.txtRucCiClienteGeneral.TabIndex = 0
            '
            'txtApellidoNombreComercial
            '
            Me.txtApellidoNombreComercial.BackColor = System.Drawing.Color.White
            Me.txtApellidoNombreComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoNombreComercial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidoNombreComercial.Location = New System.Drawing.Point(167, 55)
            Me.txtApellidoNombreComercial.Name = "txtApellidoNombreComercial"
            Me.txtApellidoNombreComercial.Size = New System.Drawing.Size(267, 21)
            Me.txtApellidoNombreComercial.TabIndex = 2
            '
            'txtNombreRazonSocialClienteGeneral
            '
            Me.txtNombreRazonSocialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreRazonSocialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreRazonSocialClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreRazonSocialClienteGeneral.Location = New System.Drawing.Point(111, 30)
            Me.txtNombreRazonSocialClienteGeneral.Name = "txtNombreRazonSocialClienteGeneral"
            Me.txtNombreRazonSocialClienteGeneral.Size = New System.Drawing.Size(323, 21)
            Me.txtNombreRazonSocialClienteGeneral.TabIndex = 1
            '
            'rbNOLlevaContabilidad
            '
            Me.rbNOLlevaContabilidad.AutoSize = True
            Me.rbNOLlevaContabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbNOLlevaContabilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNOLlevaContabilidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNOLlevaContabilidad.Location = New System.Drawing.Point(44, 4)
            Me.rbNOLlevaContabilidad.Name = "rbNOLlevaContabilidad"
            Me.rbNOLlevaContabilidad.Size = New System.Drawing.Size(41, 17)
            Me.rbNOLlevaContabilidad.TabIndex = 9
            Me.rbNOLlevaContabilidad.TabStop = True
            Me.rbNOLlevaContabilidad.Text = "NO"
            Me.rbNOLlevaContabilidad.UseVisualStyleBackColor = False
            '
            'rbSILlevaContabilidad
            '
            Me.rbSILlevaContabilidad.AutoSize = True
            Me.rbSILlevaContabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbSILlevaContabilidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSILlevaContabilidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbSILlevaContabilidad.Location = New System.Drawing.Point(3, 4)
            Me.rbSILlevaContabilidad.Name = "rbSILlevaContabilidad"
            Me.rbSILlevaContabilidad.Size = New System.Drawing.Size(35, 17)
            Me.rbSILlevaContabilidad.TabIndex = 8
            Me.rbSILlevaContabilidad.TabStop = True
            Me.rbSILlevaContabilidad.Text = "SI"
            Me.rbSILlevaContabilidad.UseVisualStyleBackColor = False
            '
            'txtnroResContEspecial
            '
            Me.txtnroResContEspecial.BackColor = System.Drawing.Color.White
            Me.txtnroResContEspecial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtnroResContEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtnroResContEspecial.Location = New System.Drawing.Point(106, 2)
            Me.txtnroResContEspecial.Name = "txtnroResContEspecial"
            Me.txtnroResContEspecial.Size = New System.Drawing.Size(92, 21)
            Me.txtnroResContEspecial.TabIndex = 6
            Me.txtnroResContEspecial.Text = "0"
            Me.txtnroResContEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDireccionUbicacionClienteGeneral
            '
            Me.txtDireccionUbicacionClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionUbicacionClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionUbicacionClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionUbicacionClienteGeneral.Location = New System.Drawing.Point(93, 105)
            Me.txtDireccionUbicacionClienteGeneral.Name = "txtDireccionUbicacionClienteGeneral"
            Me.txtDireccionUbicacionClienteGeneral.Size = New System.Drawing.Size(341, 21)
            Me.txtDireccionUbicacionClienteGeneral.TabIndex = 3
            '
            'txtDireccionFacturacionClienteGeneral
            '
            Me.txtDireccionFacturacionClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtDireccionFacturacionClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionFacturacionClienteGeneral.Enabled = False
            Me.txtDireccionFacturacionClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionFacturacionClienteGeneral.Location = New System.Drawing.Point(93, 131)
            Me.txtDireccionFacturacionClienteGeneral.Name = "txtDireccionFacturacionClienteGeneral"
            Me.txtDireccionFacturacionClienteGeneral.Size = New System.Drawing.Size(341, 21)
            Me.txtDireccionFacturacionClienteGeneral.TabIndex = 4
            '
            'txtCiudad
            '
            Me.txtCiudad.BackColor = System.Drawing.Color.White
            Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCiudad.Location = New System.Drawing.Point(93, 79)
            Me.txtCiudad.Name = "txtCiudad"
            Me.txtCiudad.Size = New System.Drawing.Size(117, 21)
            Me.txtCiudad.TabIndex = 5
            '
            'txtConsorcioGrupo
            '
            Me.txtConsorcioGrupo.BackColor = System.Drawing.Color.White
            Me.txtConsorcioGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtConsorcioGrupo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConsorcioGrupo.Location = New System.Drawing.Point(321, 79)
            Me.txtConsorcioGrupo.Name = "txtConsorcioGrupo"
            Me.txtConsorcioGrupo.Size = New System.Drawing.Size(113, 21)
            Me.txtConsorcioGrupo.TabIndex = 10
            Me.txtConsorcioGrupo.Text = "SIN GRUPO"
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.Location = New System.Drawing.Point(108, 82)
            Me.lblIdCiudad.Name = "lblIdCiudad"
            Me.lblIdCiudad.Size = New System.Drawing.Size(16, 13)
            Me.lblIdCiudad.TabIndex = 9
            Me.lblIdCiudad.Text = "..."
            '
            'txtContactoClienteGeneral
            '
            Me.txtContactoClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtContactoClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtContactoClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtContactoClienteGeneral.Location = New System.Drawing.Point(111, 156)
            Me.txtContactoClienteGeneral.Name = "txtContactoClienteGeneral"
            Me.txtContactoClienteGeneral.Size = New System.Drawing.Size(323, 21)
            Me.txtContactoClienteGeneral.TabIndex = 3
            Me.txtContactoClienteGeneral.Text = "SIN CONTÁCTO"
            '
            'txtEmailClienteGeneral
            '
            Me.txtEmailClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtEmailClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmailClienteGeneral.Location = New System.Drawing.Point(93, 182)
            Me.txtEmailClienteGeneral.Name = "txtEmailClienteGeneral"
            Me.txtEmailClienteGeneral.Size = New System.Drawing.Size(341, 21)
            Me.txtEmailClienteGeneral.TabIndex = 2
            Me.txtEmailClienteGeneral.Text = "sin correo"
            '
            'txtTelefono2ClienteGeneral
            '
            Me.txtTelefono2ClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono2ClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono2ClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono2ClienteGeneral.Location = New System.Drawing.Point(95, 99)
            Me.txtTelefono2ClienteGeneral.Name = "txtTelefono2ClienteGeneral"
            Me.txtTelefono2ClienteGeneral.Size = New System.Drawing.Size(103, 21)
            Me.txtTelefono2ClienteGeneral.TabIndex = 1
            Me.txtTelefono2ClienteGeneral.Text = "0"
            Me.txtTelefono2ClienteGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTelefono1ClienteGeneral
            '
            Me.txtTelefono1ClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtTelefono1ClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTelefono1ClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono1ClienteGeneral.Location = New System.Drawing.Point(95, 73)
            Me.txtTelefono1ClienteGeneral.Name = "txtTelefono1ClienteGeneral"
            Me.txtTelefono1ClienteGeneral.Size = New System.Drawing.Size(103, 21)
            Me.txtTelefono1ClienteGeneral.TabIndex = 0
            Me.txtTelefono1ClienteGeneral.Text = "0"
            Me.txtTelefono1ClienteGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'TextBoxVal
            '
            Me.TextBoxVal.BackColor = System.Drawing.Color.White
            Me.TextBoxVal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBoxVal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBoxVal.Location = New System.Drawing.Point(267, 1)
            Me.TextBoxVal.Name = "TextBoxVal"
            Me.TextBoxVal.Size = New System.Drawing.Size(85, 21)
            Me.TextBoxVal.TabIndex = 12
            Me.TextBoxVal.Text = "0.00"
            Me.TextBoxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ComboBox2
            '
            Me.ComboBox2.BackColor = System.Drawing.Color.White
            Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox2.FormattingEnabled = True
            Me.ComboBox2.Items.AddRange(New Object() {"ALARMA", "GUARDIANIA", "ALARMA Y GUARDIANIA"})
            Me.ComboBox2.Location = New System.Drawing.Point(93, 3)
            Me.ComboBox2.Name = "ComboBox2"
            Me.ComboBox2.Size = New System.Drawing.Size(74, 21)
            Me.ComboBox2.TabIndex = 11
            '
            'txtObservaciones
            '
            Me.txtObservaciones.BackColor = System.Drawing.Color.White
            Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(454, 1)
            Me.txtObservaciones.Multiline = True
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(203, 45)
            Me.txtObservaciones.TabIndex = 0
            '
            'dtpFechaIngresoClienteGeneral
            '
            Me.dtpFechaIngresoClienteGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIngresoClienteGeneral.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaIngresoClienteGeneral.Location = New System.Drawing.Point(95, 19)
            Me.dtpFechaIngresoClienteGeneral.Name = "dtpFechaIngresoClienteGeneral"
            Me.dtpFechaIngresoClienteGeneral.Size = New System.Drawing.Size(103, 21)
            Me.dtpFechaIngresoClienteGeneral.TabIndex = 1
            '
            'cmbTipoCliente
            '
            Me.cmbTipoCliente.BackColor = System.Drawing.Color.White
            Me.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoCliente.DropDownWidth = 140
            Me.cmbTipoCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoCliente.FormattingEnabled = True
            Me.cmbTipoCliente.Items.AddRange(New Object() {"ALARMA", "GUARDIANIA", "ALARMA Y GUARDIANIA"})
            Me.cmbTipoCliente.Location = New System.Drawing.Point(95, 46)
            Me.cmbTipoCliente.Name = "cmbTipoCliente"
            Me.cmbTipoCliente.Size = New System.Drawing.Size(103, 21)
            Me.cmbTipoCliente.TabIndex = 2
            '
            'rbNoContribuyenteEspecial
            '
            Me.rbNoContribuyenteEspecial.AutoSize = True
            Me.rbNoContribuyenteEspecial.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbNoContribuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNoContribuyenteEspecial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNoContribuyenteEspecial.Location = New System.Drawing.Point(43, 3)
            Me.rbNoContribuyenteEspecial.Name = "rbNoContribuyenteEspecial"
            Me.rbNoContribuyenteEspecial.Size = New System.Drawing.Size(41, 17)
            Me.rbNoContribuyenteEspecial.TabIndex = 11
            Me.rbNoContribuyenteEspecial.TabStop = True
            Me.rbNoContribuyenteEspecial.Text = "NO"
            Me.rbNoContribuyenteEspecial.UseVisualStyleBackColor = False
            '
            'rbSiContribuyenteEspecial
            '
            Me.rbSiContribuyenteEspecial.AutoSize = True
            Me.rbSiContribuyenteEspecial.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.rbSiContribuyenteEspecial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbSiContribuyenteEspecial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbSiContribuyenteEspecial.Location = New System.Drawing.Point(3, 3)
            Me.rbSiContribuyenteEspecial.Name = "rbSiContribuyenteEspecial"
            Me.rbSiContribuyenteEspecial.Size = New System.Drawing.Size(35, 17)
            Me.rbSiContribuyenteEspecial.TabIndex = 10
            Me.rbSiContribuyenteEspecial.TabStop = True
            Me.rbSiContribuyenteEspecial.Text = "SI"
            Me.rbSiContribuyenteEspecial.UseVisualStyleBackColor = False
            '
            'dgvClienteGeneral
            '
            Me.dgvClienteGeneral.AllowUserToAddRows = False
            Me.dgvClienteGeneral.AllowUserToDeleteRows = False
            Me.dgvClienteGeneral.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvClienteGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvClienteGeneral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvClienteGeneral.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvClienteGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvClienteGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvClienteGeneral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvClienteGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvClienteGeneral.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvClienteGeneral.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvClienteGeneral.Location = New System.Drawing.Point(10, 373)
            Me.dgvClienteGeneral.MultiSelect = False
            Me.dgvClienteGeneral.Name = "dgvClienteGeneral"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvClienteGeneral.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvClienteGeneral.RowHeadersVisible = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.dgvClienteGeneral.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvClienteGeneral.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.dgvClienteGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvClienteGeneral.Size = New System.Drawing.Size(665, 292)
            Me.dgvClienteGeneral.TabIndex = 36
            '
            'txtBuscarCliente
            '
            Me.txtBuscarCliente.BackColor = System.Drawing.Color.White
            Me.txtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarCliente.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarCliente.Location = New System.Drawing.Point(62, 347)
            Me.txtBuscarCliente.Name = "txtBuscarCliente"
            Me.txtBuscarCliente.Size = New System.Drawing.Size(295, 21)
            Me.txtBuscarCliente.TabIndex = 0
            '
            'gbConvenioBancario
            '
            Me.gbConvenioBancario.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.gbConvenioBancario.Controls.Add(Me.DataGridView1)
            Me.gbConvenioBancario.Controls.Add(Me.btnAdd)
            Me.gbConvenioBancario.Controls.Add(Me.btnRemove)
            Me.gbConvenioBancario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbConvenioBancario.Location = New System.Drawing.Point(53, 390)
            Me.gbConvenioBancario.Name = "gbConvenioBancario"
            Me.gbConvenioBancario.Size = New System.Drawing.Size(604, 121)
            Me.gbConvenioBancario.TabIndex = 189
            Me.gbConvenioBancario.TabStop = False
            Me.gbConvenioBancario.Text = "CONVENIO DÉBITO BANCARIO"
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
            Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView1.Size = New System.Drawing.Size(598, 101)
            Me.DataGridView1.TabIndex = 37
            '
            'Column1
            '
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 40
            '
            'Column2
            '
            Me.Column2.HeaderText = "IDC"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Visible = False
            Me.Column2.Width = 40
            '
            'Column3
            '
            Me.Column3.HeaderText = "BANCO"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 120
            '
            'Column4
            '
            Me.Column4.HeaderText = "TIPO CTA."
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 90
            '
            'Column5
            '
            Me.Column5.HeaderText = "DOC"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            Me.Column5.Width = 90
            '
            'Column6
            '
            Me.Column6.HeaderText = "N° CTA."
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 80
            '
            'Column7
            '
            Me.Column7.HeaderText = "NUM_CI"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Visible = False
            '
            'Column8
            '
            Me.Column8.HeaderText = "TITULAR CTA."
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 180
            '
            'Column9
            '
            Me.Column9.HeaderText = "VALOR"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Width = 60
            '
            'Column10
            '
            Me.Column10.HeaderText = "DESCRIPCIÓN"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Width = 450
            '
            'btnAdd
            '
            Me.btnAdd.Enabled = False
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAdd.ForeColor = System.Drawing.Color.Black
            Me.btnAdd.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAdd.Location = New System.Drawing.Point(709, 0)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(26, 26)
            Me.btnAdd.TabIndex = 191
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'btnRemove
            '
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove.ForeColor = System.Drawing.Color.Black
            Me.btnRemove.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnRemove.Location = New System.Drawing.Point(738, 0)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(26, 26)
            Me.btnRemove.TabIndex = 190
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnAnular, Me.btnCancelar, Me.ToolStripMenuItem3})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(678, 32)
            Me.msKardex.TabIndex = 180
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(113, 28)
            Me.btnModificar.Text = "ACTUALIZAR"
            '
            'btnAnular
            '
            Me.btnAnular.Enabled = False
            Me.btnAnular.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(85, 28)
            Me.btnAnular.Text = "ANULAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem3.Text = "EXPORTAR"
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.Transparent
            Me.Button2.Enabled = False
            Me.Button2.FlatAppearance.BorderSize = 0
            Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button2.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Me.Button2.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.Button2.Location = New System.Drawing.Point(594, 133)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(27, 27)
            Me.Button2.TabIndex = 190
            Me.Button2.UseVisualStyleBackColor = False
            '
            'DataGridView3
            '
            Me.DataGridView3.AllowUserToDeleteRows = False
            Me.DataGridView3.AllowUserToResizeRows = False
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column11})
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle9
            Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataGridView3.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
            Me.DataGridView3.MultiSelect = False
            Me.DataGridView3.Name = "DataGridView3"
            Me.DataGridView3.RowHeadersVisible = False
            Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView3.Size = New System.Drawing.Size(628, 167)
            Me.DataGridView3.TabIndex = 37
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 40
            '
            'Column11
            '
            Me.Column11.HeaderText = "DIRECCION DE FACTURACION"
            Me.Column11.Name = "Column11"
            Me.Column11.Width = 720
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label47.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label47.Location = New System.Drawing.Point(519, 5)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(16, 13)
            Me.Label47.TabIndex = 183
            Me.Label47.Text = "..."
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label44.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label44.Location = New System.Drawing.Point(179, 42)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(16, 13)
            Me.Label44.TabIndex = 6
            Me.Label44.Text = "..."
            '
            'TextBox12
            '
            Me.TextBox12.BackColor = System.Drawing.Color.White
            Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox12.Enabled = False
            Me.TextBox12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox12.Location = New System.Drawing.Point(168, 30)
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.Size = New System.Drawing.Size(305, 21)
            Me.TextBox12.TabIndex = 2
            '
            'TextBox13
            '
            Me.TextBox13.BackColor = System.Drawing.Color.White
            Me.TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox13.Enabled = False
            Me.TextBox13.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox13.Location = New System.Drawing.Point(168, 1)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New System.Drawing.Size(305, 21)
            Me.TextBox13.TabIndex = 1
            '
            'MenuStrip5
            '
            Me.MenuStrip5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.ToolStripMenuItem14, Me.ToolStripMenuItem11, Me.ToolStripMenuItem16})
            Me.MenuStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip5.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip5.Name = "MenuStrip5"
            Me.MenuStrip5.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip5.Size = New System.Drawing.Size(678, 32)
            Me.MenuStrip5.TabIndex = 181
            Me.MenuStrip5.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem9
            '
            Me.ToolStripMenuItem9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem9.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
            Me.ToolStripMenuItem9.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem9.Text = "BUSCAR"
            '
            'ToolStripMenuItem14
            '
            Me.ToolStripMenuItem14.Enabled = False
            Me.ToolStripMenuItem14.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem14.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
            Me.ToolStripMenuItem14.Size = New System.Drawing.Size(113, 28)
            Me.ToolStripMenuItem14.Text = "ACTUALIZAR"
            '
            'ToolStripMenuItem11
            '
            Me.ToolStripMenuItem11.Enabled = False
            Me.ToolStripMenuItem11.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem11.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
            Me.ToolStripMenuItem11.Size = New System.Drawing.Size(92, 28)
            Me.ToolStripMenuItem11.Text = "GUARDAR"
            '
            'ToolStripMenuItem16
            '
            Me.ToolStripMenuItem16.Enabled = False
            Me.ToolStripMenuItem16.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem16.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.ToolStripMenuItem16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
            Me.ToolStripMenuItem16.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem16.Text = "CANCELAR"
            '
            'dgvSitios
            '
            Me.dgvSitios.AllowUserToAddRows = False
            Me.dgvSitios.AllowUserToDeleteRows = False
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSitios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvSitios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvSitios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvSitios.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvSitios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvSitios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSitios.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvSitios.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvSitios.Location = New System.Drawing.Point(8, 267)
            Me.dgvSitios.MultiSelect = False
            Me.dgvSitios.Name = "dgvSitios"
            Me.dgvSitios.RowHeadersVisible = False
            Me.dgvSitios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSitios.Size = New System.Drawing.Size(646, 387)
            Me.dgvSitios.TabIndex = 184
            '
            'cbmTipo
            '
            Me.cbmTipo.AutoCompleteCustomSource.AddRange(New String() {"FIJO", "TEMPORAL"})
            Me.cbmTipo.BackColor = System.Drawing.Color.White
            Me.cbmTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipo.Enabled = False
            Me.cbmTipo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipo.ForeColor = System.Drawing.Color.White
            Me.cbmTipo.FormattingEnabled = True
            Me.cbmTipo.Items.AddRange(New Object() {"FIJO", "TEMPORAL"})
            Me.cbmTipo.Location = New System.Drawing.Point(477, 28)
            Me.cbmTipo.Name = "cbmTipo"
            Me.cbmTipo.Size = New System.Drawing.Size(141, 21)
            Me.cbmTipo.TabIndex = 187
            '
            'cbxSupervisor
            '
            Me.cbxSupervisor.BackColor = System.Drawing.Color.White
            Me.cbxSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxSupervisor.Enabled = False
            Me.cbxSupervisor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxSupervisor.ForeColor = System.Drawing.Color.White
            Me.cbxSupervisor.FormattingEnabled = True
            Me.cbxSupervisor.Location = New System.Drawing.Point(411, 80)
            Me.cbxSupervisor.Name = "cbxSupervisor"
            Me.cbxSupervisor.Size = New System.Drawing.Size(207, 21)
            Me.cbxSupervisor.TabIndex = 186
            '
            'txtNombreSitio
            '
            Me.txtNombreSitio.BackColor = System.Drawing.Color.White
            Me.txtNombreSitio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreSitio.Enabled = False
            Me.txtNombreSitio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreSitio.ForeColor = System.Drawing.Color.White
            Me.txtNombreSitio.Location = New System.Drawing.Point(88, 28)
            Me.txtNombreSitio.Name = "txtNombreSitio"
            Me.txtNombreSitio.Size = New System.Drawing.Size(315, 21)
            Me.txtNombreSitio.TabIndex = 29
            '
            'txtReferencia
            '
            Me.txtReferencia.BackColor = System.Drawing.Color.White
            Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia.Enabled = False
            Me.txtReferencia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReferencia.ForeColor = System.Drawing.Color.White
            Me.txtReferencia.Location = New System.Drawing.Point(88, 80)
            Me.txtReferencia.Name = "txtReferencia"
            Me.txtReferencia.Size = New System.Drawing.Size(315, 21)
            Me.txtReferencia.TabIndex = 31
            '
            'txtDireccion
            '
            Me.txtDireccion.BackColor = System.Drawing.Color.White
            Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccion.Enabled = False
            Me.txtDireccion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.ForeColor = System.Drawing.Color.White
            Me.txtDireccion.Location = New System.Drawing.Point(88, 54)
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(315, 21)
            Me.txtDireccion.TabIndex = 30
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.ForeColor = System.Drawing.Color.White
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(88, 3)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(125, 21)
            Me.cbmProvincia.TabIndex = 23
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.ForeColor = System.Drawing.Color.White
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(477, 4)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(141, 21)
            Me.cbmParroquia.TabIndex = 25
            '
            'cbmCanton
            '
            Me.cbmCanton.BackColor = System.Drawing.Color.White
            Me.cbmCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCanton.Enabled = False
            Me.cbmCanton.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCanton.ForeColor = System.Drawing.Color.White
            Me.cbmCanton.FormattingEnabled = True
            Me.cbmCanton.Location = New System.Drawing.Point(278, 4)
            Me.cbmCanton.Name = "cbmCanton"
            Me.cbmCanton.Size = New System.Drawing.Size(125, 21)
            Me.cbmCanton.TabIndex = 24
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label28.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(100, 131)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(16, 13)
            Me.Label28.TabIndex = 6
            Me.Label28.Text = "..."
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem4, Me.AGREGARSITIOToolStripMenuItem})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(678, 32)
            Me.MenuStrip1.TabIndex = 181
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem2.Text = "BUSCAR"
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem4.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem4.Text = "EXPORTAR"
            '
            'AGREGARSITIOToolStripMenuItem
            '
            Me.AGREGARSITIOToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.AGREGARSITIOToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AGREGARSITIOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.AGREGARSITIOToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.AGREGARSITIOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.AGREGARSITIOToolStripMenuItem.Name = "AGREGARSITIOToolStripMenuItem"
            Me.AGREGARSITIOToolStripMenuItem.Size = New System.Drawing.Size(134, 28)
            Me.AGREGARSITIOToolStripMenuItem.Text = "AGREGAR SITIO"
            '
            'ComboBox1
            '
            Me.ComboBox1.BackColor = System.Drawing.Color.White
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 200
            Me.ComboBox1.Enabled = False
            Me.ComboBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"RUC", "CEDULA", "PASAPORTE", "VENTA A CONSUMIDOR FINAL", "IDENTIFICACION DEL EXTERIOR"})
            Me.ComboBox1.Location = New System.Drawing.Point(120, 4)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
            Me.ComboBox1.TabIndex = 9
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label23.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label23.Location = New System.Drawing.Point(132, 43)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(16, 13)
            Me.Label23.TabIndex = 6
            Me.Label23.Text = "..."
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.ForeColor = System.Drawing.Color.White
            Me.TextBox1.Location = New System.Drawing.Point(496, 5)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(123, 21)
            Me.TextBox1.TabIndex = 0
            '
            'TextBox2
            '
            Me.TextBox2.BackColor = System.Drawing.Color.White
            Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox2.Enabled = False
            Me.TextBox2.ForeColor = System.Drawing.Color.White
            Me.TextBox2.Location = New System.Drawing.Point(496, 28)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(122, 20)
            Me.TextBox2.TabIndex = 2
            Me.TextBox2.Visible = False
            '
            'TextBox3
            '
            Me.TextBox3.BackColor = System.Drawing.Color.White
            Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox3.Enabled = False
            Me.TextBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox3.ForeColor = System.Drawing.Color.White
            Me.TextBox3.Location = New System.Drawing.Point(120, 29)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(283, 21)
            Me.TextBox3.TabIndex = 1
            '
            'ListView3
            '
            Me.ListView3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38})
            Me.ListView3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListView3.FullRowSelect = True
            Me.ListView3.HideSelection = False
            Me.ListView3.Location = New System.Drawing.Point(7, 96)
            Me.ListView3.MultiSelect = False
            Me.ListView3.Name = "ListView3"
            Me.ListView3.Size = New System.Drawing.Size(663, 518)
            Me.ListView3.TabIndex = 209
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
            'TextBox10
            '
            Me.TextBox10.BackColor = System.Drawing.Color.White
            Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox10.Location = New System.Drawing.Point(414, 3)
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.Size = New System.Drawing.Size(263, 21)
            Me.TextBox10.TabIndex = 204
            '
            'DateTimePicker6
            '
            Me.DateTimePicker6.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker6.Location = New System.Drawing.Point(237, 2)
            Me.DateTimePicker6.Name = "DateTimePicker6"
            Me.DateTimePicker6.Size = New System.Drawing.Size(111, 21)
            Me.DateTimePicker6.TabIndex = 202
            '
            'DateTimePicker7
            '
            Me.DateTimePicker7.CustomFormat = "MMMM yyyy"
            Me.DateTimePicker7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker7.Location = New System.Drawing.Point(55, 2)
            Me.DateTimePicker7.Name = "DateTimePicker7"
            Me.DateTimePicker7.Size = New System.Drawing.Size(111, 21)
            Me.DateTimePicker7.TabIndex = 200
            '
            'MenuStrip4
            '
            Me.MenuStrip4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem12})
            Me.MenuStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip4.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip4.Name = "MenuStrip4"
            Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip4.Size = New System.Drawing.Size(678, 32)
            Me.MenuStrip4.TabIndex = 205
            Me.MenuStrip4.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem8
            '
            Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem8.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
            Me.ToolStripMenuItem8.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem8.Text = "BUSCAR"
            '
            'ToolStripMenuItem12
            '
            Me.ToolStripMenuItem12.Enabled = False
            Me.ToolStripMenuItem12.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem12.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
            Me.ToolStripMenuItem12.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem12.Text = "EXPORTAR"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(343, 53)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(142, 21)
            Me.dtpFechaHasta.TabIndex = 191
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(139, 52)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(128, 21)
            Me.dtpFechaDesde.TabIndex = 190
            '
            'dgvFacturaVenta
            '
            Me.dgvFacturaVenta.AllowUserToAddRows = False
            Me.dgvFacturaVenta.AllowUserToDeleteRows = False
            DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvFacturaVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvFacturaVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvFacturaVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvFacturaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvFacturaVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvFacturaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.DefaultCellStyle = DataGridViewCellStyle14
            Me.dgvFacturaVenta.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dgvFacturaVenta.Location = New System.Drawing.Point(12, 149)
            Me.dgvFacturaVenta.MultiSelect = False
            Me.dgvFacturaVenta.Name = "dgvFacturaVenta"
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFacturaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvFacturaVenta.RowHeadersVisible = False
            Me.dgvFacturaVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.dgvFacturaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFacturaVenta.Size = New System.Drawing.Size(658, 450)
            Me.dgvFacturaVenta.TabIndex = 189
            '
            'TextBox7
            '
            Me.TextBox7.BackColor = System.Drawing.Color.White
            Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox7.Enabled = False
            Me.TextBox7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox7.Location = New System.Drawing.Point(562, 4)
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.Size = New System.Drawing.Size(87, 21)
            Me.TextBox7.TabIndex = 188
            Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'ComboBox3
            '
            Me.ComboBox3.BackColor = System.Drawing.Color.White
            Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox3.DropDownWidth = 200
            Me.ComboBox3.Enabled = False
            Me.ComboBox3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox3.FormattingEnabled = True
            Me.ComboBox3.Items.AddRange(New Object() {"RUC", "CEDULA", "PASAPORTE", "VENTA A CONSUMIDOR FINAL", "IDENTIFICACION DEL EXTERIOR"})
            Me.ComboBox3.Location = New System.Drawing.Point(123, 4)
            Me.ComboBox3.Name = "ComboBox3"
            Me.ComboBox3.Size = New System.Drawing.Size(144, 21)
            Me.ComboBox3.TabIndex = 9
            '
            'TextBox5
            '
            Me.TextBox5.BackColor = System.Drawing.Color.White
            Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox5.Enabled = False
            Me.TextBox5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox5.Location = New System.Drawing.Point(562, 29)
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Size = New System.Drawing.Size(87, 21)
            Me.TextBox5.TabIndex = 185
            Me.TextBox5.Text = "0.00"
            Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(139, 42)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(16, 13)
            Me.Label17.TabIndex = 6
            Me.Label17.Text = "..."
            '
            'TextBox4
            '
            Me.TextBox4.BackColor = System.Drawing.Color.White
            Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox4.Enabled = False
            Me.TextBox4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox4.ForeColor = System.Drawing.Color.White
            Me.TextBox4.Location = New System.Drawing.Point(343, 5)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(123, 21)
            Me.TextBox4.TabIndex = 0
            '
            'TextBox6
            '
            Me.TextBox6.BackColor = System.Drawing.Color.White
            Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox6.Enabled = False
            Me.TextBox6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.ForeColor = System.Drawing.Color.White
            Me.TextBox6.Location = New System.Drawing.Point(72, 27)
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Size = New System.Drawing.Size(394, 21)
            Me.TextBox6.TabIndex = 1
            '
            'MenuStrip2
            '
            Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
            Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip2.Name = "MenuStrip2"
            Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip2.Size = New System.Drawing.Size(678, 32)
            Me.MenuStrip2.TabIndex = 182
            Me.MenuStrip2.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem5
            '
            Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem5.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            Me.ToolStripMenuItem5.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem5.Text = "BUSCAR"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem6.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem6.Text = "EXPORTAR"
            '
            'TextBox9
            '
            Me.TextBox9.BackColor = System.Drawing.Color.White
            Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox9.Location = New System.Drawing.Point(71, 36)
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Size = New System.Drawing.Size(368, 21)
            Me.TextBox9.TabIndex = 182
            '
            'DataGridView2
            '
            Me.DataGridView2.AllowUserToAddRows = False
            Me.DataGridView2.AllowUserToDeleteRows = False
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle18
            Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DataGridView2.Location = New System.Drawing.Point(9, 62)
            Me.DataGridView2.MultiSelect = False
            Me.DataGridView2.Name = "DataGridView2"
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Roboto", 8.0!)
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.DataGridView2.RowHeadersVisible = False
            Me.DataGridView2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.0!)
            Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView2.Size = New System.Drawing.Size(661, 592)
            Me.DataGridView2.TabIndex = 183
            '
            'MenuStrip3
            '
            Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem13})
            Me.MenuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip3.Name = "MenuStrip3"
            Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip3.Size = New System.Drawing.Size(678, 32)
            Me.MenuStrip3.TabIndex = 181
            Me.MenuStrip3.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem7.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem7.Text = "BUSCAR"
            '
            'ToolStripMenuItem13
            '
            Me.ToolStripMenuItem13.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem13.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
            Me.ToolStripMenuItem13.Size = New System.Drawing.Size(99, 28)
            Me.ToolStripMenuItem13.Text = "EXPORTAR"
            '
            'KryptonNavigator1
            '
            Me.KryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.KryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.KryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.KryptonNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.KryptonNavigator1.Name = "KryptonNavigator1"
            Me.KryptonNavigator1.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.TabControl1, Me.KryptonPage2, Me.KryptonPage3, Me.KryptonPage4, Me.KryptonPage5, Me.KryptonPage6})
            Me.KryptonNavigator1.SelectedIndex = 0
            Me.KryptonNavigator1.Size = New System.Drawing.Size(680, 696)
            Me.KryptonNavigator1.TabIndex = 40
            Me.KryptonNavigator1.Text = "KryptonNavigator1"
            '
            'TabControl1
            '
            Me.TabControl1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.TabControl1.Controls.Add(Me.lblIdClienteGeneral)
            Me.TabControl1.Controls.Add(Me.chkConvenio)
            Me.TabControl1.Controls.Add(Me.KryptonLabel18)
            Me.TabControl1.Controls.Add(Me.dgvClienteGeneral)
            Me.TabControl1.Controls.Add(Me.txtBuscarCliente)
            Me.TabControl1.Controls.Add(Me.KryptonGroupBox5)
            Me.TabControl1.Controls.Add(Me.KryptonGroupBox4)
            Me.TabControl1.Controls.Add(Me.KryptonGroupBox3)
            Me.TabControl1.Controls.Add(Me.KryptonGroupBox2)
            Me.TabControl1.Controls.Add(Me.KryptonGroupBox1)
            Me.TabControl1.Controls.Add(Me.msKardex)
            Me.TabControl1.Controls.Add(Me.gbConvenioBancario)
            Me.TabControl1.Flags = 65534
            Me.TabControl1.LastVisibleSet = True
            Me.TabControl1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.Size = New System.Drawing.Size(678, 669)
            Me.TabControl1.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.TabControl1.Text = "Datos"
            Me.TabControl1.ToolTipTitle = "Page ToolTip"
            Me.TabControl1.UniqueName = "5C1CB1EEDBA44CA08089F95A764C35C6"
            '
            'chkConvenio
            '
            Me.chkConvenio.Location = New System.Drawing.Point(403, 347)
            Me.chkConvenio.Name = "chkConvenio"
            Me.chkConvenio.Size = New System.Drawing.Size(97, 20)
            Me.chkConvenio.TabIndex = 190
            Me.chkConvenio.Values.Text = "Ver Convenio"
            '
            'KryptonLabel18
            '
            Me.KryptonLabel18.Location = New System.Drawing.Point(10, 347)
            Me.KryptonLabel18.Name = "KryptonLabel18"
            Me.KryptonLabel18.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel18.TabIndex = 186
            Me.KryptonLabel18.Values.Text = "Buscar"
            '
            'KryptonGroupBox5
            '
            Me.KryptonGroupBox5.CaptionOverlap = 0R
            Me.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox5.Location = New System.Drawing.Point(3, 267)
            Me.KryptonGroupBox5.Name = "KryptonGroupBox5"
            '
            'KryptonGroupBox5.Panel
            '
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel17)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel16)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.KryptonLabel15)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.txtObservaciones)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.TextBoxVal)
            Me.KryptonGroupBox5.Panel.Controls.Add(Me.ComboBox2)
            Me.KryptonGroupBox5.Size = New System.Drawing.Size(672, 74)
            Me.KryptonGroupBox5.TabIndex = 185
            Me.KryptonGroupBox5.Values.Heading = "Informacion Adicional sobre Contacto"
            '
            'KryptonLabel17
            '
            Me.KryptonLabel17.Location = New System.Drawing.Point(358, 3)
            Me.KryptonLabel17.Name = "KryptonLabel17"
            Me.KryptonLabel17.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel17.TabIndex = 23
            Me.KryptonLabel17.Values.Text = "Observaciones"
            '
            'KryptonLabel16
            '
            Me.KryptonLabel16.Location = New System.Drawing.Point(172, 2)
            Me.KryptonLabel16.Name = "KryptonLabel16"
            Me.KryptonLabel16.Size = New System.Drawing.Size(90, 20)
            Me.KryptonLabel16.TabIndex = 22
            Me.KryptonLabel16.Values.Text = "Valor Contrato"
            '
            'KryptonLabel15
            '
            Me.KryptonLabel15.Location = New System.Drawing.Point(5, 2)
            Me.KryptonLabel15.Name = "KryptonLabel15"
            Me.KryptonLabel15.Size = New System.Drawing.Size(84, 20)
            Me.KryptonLabel15.TabIndex = 21
            Me.KryptonLabel15.Values.Text = "Año Contrato"
            '
            'KryptonGroupBox4
            '
            Me.KryptonGroupBox4.CaptionOverlap = 0R
            Me.KryptonGroupBox4.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox4.Location = New System.Drawing.Point(462, 136)
            Me.KryptonGroupBox4.Name = "KryptonGroupBox4"
            '
            'KryptonGroupBox4.Panel
            '
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel14)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtTelefono2ClienteGeneral)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.dtpFechaIngresoClienteGeneral)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.txtTelefono1ClienteGeneral)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox4.Panel.Controls.Add(Me.cmbTipoCliente)
            Me.KryptonGroupBox4.Size = New System.Drawing.Size(213, 128)
            Me.KryptonGroupBox4.TabIndex = 184
            Me.KryptonGroupBox4.Values.Heading = ""
            '
            'KryptonLabel14
            '
            Me.KryptonLabel14.Location = New System.Drawing.Point(3, 99)
            Me.KryptonLabel14.Name = "KryptonLabel14"
            Me.KryptonLabel14.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel14.StateNormal.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel14.TabIndex = 20
            Me.KryptonLabel14.Values.Text = "Telf 2"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(3, 18)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(86, 20)
            Me.KryptonLabel9.StateNormal.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel9.TabIndex = 15
            Me.KryptonLabel9.Values.Text = "Fecha Ingreso"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(3, 47)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel10.StateNormal.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel10.TabIndex = 16
            Me.KryptonLabel10.Values.Text = "Tipo Cliente"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(3, 73)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel13.StateNormal.ShortText.Color1 = System.Drawing.Color.SeaGreen
            Me.KryptonLabel13.TabIndex = 19
            Me.KryptonLabel13.Values.Text = "Telf 1"
            '
            'KryptonGroupBox3
            '
            Me.KryptonGroupBox3.CaptionOverlap = 0R
            Me.KryptonGroupBox3.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox3.Location = New System.Drawing.Point(462, 84)
            Me.KryptonGroupBox3.Name = "KryptonGroupBox3"
            '
            'KryptonGroupBox3.Panel
            '
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbSILlevaContabilidad)
            Me.KryptonGroupBox3.Panel.Controls.Add(Me.rbNOLlevaContabilidad)
            Me.KryptonGroupBox3.Size = New System.Drawing.Size(213, 48)
            Me.KryptonGroupBox3.TabIndex = 183
            Me.KryptonGroupBox3.Values.Heading = "Obligado llevar Contabilidad"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(462, 33)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbSiContribuyenteEspecial)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.txtnroResContEspecial)
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.rbNoContribuyenteEspecial)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(213, 48)
            Me.KryptonGroupBox2.TabIndex = 182
            Me.KryptonGroupBox2.Values.Heading = "No Res Contribuyente Especial"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 33)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEmailClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtContactoClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionFacturacionClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDireccionUbicacionClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtConsorcioGrupo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmbTipoIdentificacion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtApellidoNombreComercial)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtRucCiClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreRazonSocialClienteGeneral)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdCiudad)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(456, 231)
            Me.KryptonGroupBox1.TabIndex = 181
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(4, 183)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel6.TabIndex = 20
            Me.KryptonLabel6.Values.Text = "Email"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(4, 157)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(109, 20)
            Me.KryptonLabel5.TabIndex = 19
            Me.KryptonLabel5.Values.Text = "Nombre Contacto"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(5, 131)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(87, 20)
            Me.KryptonLabel12.TabIndex = 18
            Me.KryptonLabel12.Values.Text = "Direccion Fact"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(4, 105)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel11.TabIndex = 17
            Me.KryptonLabel11.Values.Text = "Direccion "
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(213, 79)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(108, 20)
            Me.KryptonLabel8.TabIndex = 14
            Me.KryptonLabel8.Values.Text = "Consorcio/ Grupo"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(4, 79)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel7.TabIndex = 13
            Me.KryptonLabel7.Values.Text = "Ciudad"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(4, 56)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(163, 20)
            Me.KryptonLabel4.TabIndex = 10
            Me.KryptonLabel4.Values.Text = "Apellido/Nombre Comercial"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(4, 30)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(101, 20)
            Me.KryptonLabel3.TabIndex = 9
            Me.KryptonLabel3.Values.Text = "Nombre / Razon"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(257, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel2.TabIndex = 8
            Me.KryptonLabel2.Values.Text = "RUC/CI"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(4, 4)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Tipo Identifi"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.Label44)
            Me.KryptonPage2.Controls.Add(Me.Button2)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox7)
            Me.KryptonPage2.Controls.Add(Me.KryptonGroupBox6)
            Me.KryptonPage2.Controls.Add(Me.MenuStrip5)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(678, 669)
            Me.KryptonPage2.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage2.Text = "Direcciones"
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "A75575C8DECA485D868F52562450C0D8"
            '
            'KryptonGroupBox7
            '
            Me.KryptonGroupBox7.CaptionOverlap = 0R
            Me.KryptonGroupBox7.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox7.Location = New System.Drawing.Point(9, 139)
            Me.KryptonGroupBox7.Name = "KryptonGroupBox7"
            '
            'KryptonGroupBox7.Panel
            '
            Me.KryptonGroupBox7.Panel.Controls.Add(Me.DataGridView3)
            Me.KryptonGroupBox7.Size = New System.Drawing.Size(632, 191)
            Me.KryptonGroupBox7.TabIndex = 183
            Me.KryptonGroupBox7.Values.Heading = "Direcciones de Facturacion"
            '
            'KryptonGroupBox6
            '
            Me.KryptonGroupBox6.CaptionOverlap = 0R
            Me.KryptonGroupBox6.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox6.Location = New System.Drawing.Point(7, 37)
            Me.KryptonGroupBox6.Name = "KryptonGroupBox6"
            '
            'KryptonGroupBox6.Panel
            '
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.Label47)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel21)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel19)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.KryptonLabel20)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.TextBox13)
            Me.KryptonGroupBox6.Panel.Controls.Add(Me.TextBox12)
            Me.KryptonGroupBox6.Size = New System.Drawing.Size(634, 92)
            Me.KryptonGroupBox6.TabIndex = 182
            Me.KryptonGroupBox6.Values.Heading = "Cliente"
            '
            'KryptonLabel21
            '
            Me.KryptonLabel21.Location = New System.Drawing.Point(477, 1)
            Me.KryptonLabel21.Name = "KryptonLabel21"
            Me.KryptonLabel21.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel21.TabIndex = 13
            Me.KryptonLabel21.Values.Text = "RUC"
            '
            'KryptonLabel19
            '
            Me.KryptonLabel19.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel19.Name = "KryptonLabel19"
            Me.KryptonLabel19.Size = New System.Drawing.Size(163, 20)
            Me.KryptonLabel19.TabIndex = 12
            Me.KryptonLabel19.Values.Text = "Apellido/Nombre Comercial"
            '
            'KryptonLabel20
            '
            Me.KryptonLabel20.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel20.Name = "KryptonLabel20"
            Me.KryptonLabel20.Size = New System.Drawing.Size(136, 20)
            Me.KryptonLabel20.TabIndex = 11
            Me.KryptonLabel20.Values.Text = "Nombre / Razon Social"
            '
            'KryptonPage3
            '
            Me.KryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage3.Controls.Add(Me.dgvSitios)
            Me.KryptonPage3.Controls.Add(Me.Label28)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox9)
            Me.KryptonPage3.Controls.Add(Me.Label23)
            Me.KryptonPage3.Controls.Add(Me.KryptonGroupBox8)
            Me.KryptonPage3.Controls.Add(Me.MenuStrip1)
            Me.KryptonPage3.Flags = 65534
            Me.KryptonPage3.LastVisibleSet = True
            Me.KryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage3.Name = "KryptonPage3"
            Me.KryptonPage3.Size = New System.Drawing.Size(678, 669)
            Me.KryptonPage3.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage3.Text = "Sitios Vigilancia"
            Me.KryptonPage3.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage3.UniqueName = "A1F1BA4D313C407A91BB072AA818A651"
            '
            'KryptonGroupBox9
            '
            Me.KryptonGroupBox9.CaptionOverlap = 0R
            Me.KryptonGroupBox9.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox9.Location = New System.Drawing.Point(7, 125)
            Me.KryptonGroupBox9.Name = "KryptonGroupBox9"
            '
            'KryptonGroupBox9.Panel
            '
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel32)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.cbxSupervisor)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel31)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.cbmTipo)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel30)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel28)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.txtReferencia)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel29)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel25)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel26)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.KryptonLabel27)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.txtNombreSitio)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.txtDireccion)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.cbmCanton)
            Me.KryptonGroupBox9.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox9.Size = New System.Drawing.Size(650, 136)
            Me.KryptonGroupBox9.TabIndex = 184
            Me.KryptonGroupBox9.Values.Heading = "Sitio"
            '
            'KryptonLabel32
            '
            Me.KryptonLabel32.Location = New System.Drawing.Point(411, 54)
            Me.KryptonLabel32.Name = "KryptonLabel32"
            Me.KryptonLabel32.Size = New System.Drawing.Size(68, 20)
            Me.KryptonLabel32.TabIndex = 189
            Me.KryptonLabel32.Values.Text = "Supervisor"
            '
            'KryptonLabel31
            '
            Me.KryptonLabel31.Location = New System.Drawing.Point(3, 81)
            Me.KryptonLabel31.Name = "KryptonLabel31"
            Me.KryptonLabel31.Size = New System.Drawing.Size(67, 20)
            Me.KryptonLabel31.TabIndex = 188
            Me.KryptonLabel31.Values.Text = "Referencia"
            '
            'KryptonLabel30
            '
            Me.KryptonLabel30.Location = New System.Drawing.Point(410, 31)
            Me.KryptonLabel30.Name = "KryptonLabel30"
            Me.KryptonLabel30.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel30.TabIndex = 31
            Me.KryptonLabel30.Values.Text = "Tipo"
            '
            'KryptonLabel28
            '
            Me.KryptonLabel28.Location = New System.Drawing.Point(3, 55)
            Me.KryptonLabel28.Name = "KryptonLabel28"
            Me.KryptonLabel28.Size = New System.Drawing.Size(62, 20)
            Me.KryptonLabel28.TabIndex = 30
            Me.KryptonLabel28.Values.Text = "Direccion"
            '
            'KryptonLabel29
            '
            Me.KryptonLabel29.Location = New System.Drawing.Point(410, 5)
            Me.KryptonLabel29.Name = "KryptonLabel29"
            Me.KryptonLabel29.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel29.TabIndex = 26
            Me.KryptonLabel29.Values.Text = "Parroquia"
            '
            'KryptonLabel25
            '
            Me.KryptonLabel25.Location = New System.Drawing.Point(221, 4)
            Me.KryptonLabel25.Name = "KryptonLabel25"
            Me.KryptonLabel25.Size = New System.Drawing.Size(50, 20)
            Me.KryptonLabel25.TabIndex = 13
            Me.KryptonLabel25.Values.Text = "Canton"
            '
            'KryptonLabel26
            '
            Me.KryptonLabel26.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel26.Name = "KryptonLabel26"
            Me.KryptonLabel26.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel26.TabIndex = 12
            Me.KryptonLabel26.Values.Text = "Nombre"
            '
            'KryptonLabel27
            '
            Me.KryptonLabel27.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel27.Name = "KryptonLabel27"
            Me.KryptonLabel27.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel27.TabIndex = 11
            Me.KryptonLabel27.Values.Text = "Provincia"
            '
            'KryptonGroupBox8
            '
            Me.KryptonGroupBox8.CaptionOverlap = 0R
            Me.KryptonGroupBox8.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox8.Location = New System.Drawing.Point(7, 38)
            Me.KryptonGroupBox8.Name = "KryptonGroupBox8"
            '
            'KryptonGroupBox8.Panel
            '
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.ComboBox1)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.KryptonLabel22)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.KryptonLabel23)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.TextBox1)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.KryptonLabel24)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.TextBox3)
            Me.KryptonGroupBox8.Panel.Controls.Add(Me.TextBox2)
            Me.KryptonGroupBox8.Size = New System.Drawing.Size(650, 80)
            Me.KryptonGroupBox8.TabIndex = 183
            Me.KryptonGroupBox8.Values.Heading = "Cliente"
            '
            'KryptonLabel22
            '
            Me.KryptonLabel22.Location = New System.Drawing.Point(436, 5)
            Me.KryptonLabel22.Name = "KryptonLabel22"
            Me.KryptonLabel22.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel22.TabIndex = 13
            Me.KryptonLabel22.Values.Text = "RUC"
            '
            'KryptonLabel23
            '
            Me.KryptonLabel23.Location = New System.Drawing.Point(3, 29)
            Me.KryptonLabel23.Name = "KryptonLabel23"
            Me.KryptonLabel23.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel23.TabIndex = 12
            Me.KryptonLabel23.Values.Text = "Cliente"
            '
            'KryptonLabel24
            '
            Me.KryptonLabel24.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel24.Name = "KryptonLabel24"
            Me.KryptonLabel24.Size = New System.Drawing.Size(111, 20)
            Me.KryptonLabel24.TabIndex = 11
            Me.KryptonLabel24.Values.Text = "Tipo Identificacion"
            '
            'KryptonPage4
            '
            Me.KryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage4.Controls.Add(Me.ListView3)
            Me.KryptonPage4.Controls.Add(Me.KryptonGroupBox10)
            Me.KryptonPage4.Controls.Add(Me.MenuStrip4)
            Me.KryptonPage4.Flags = 65534
            Me.KryptonPage4.LastVisibleSet = True
            Me.KryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage4.Name = "KryptonPage4"
            Me.KryptonPage4.Size = New System.Drawing.Size(678, 669)
            Me.KryptonPage4.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage4.Text = "Detalle Puesto"
            Me.KryptonPage4.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage4.UniqueName = "E919C937CBC64ADE2189356EF5154589"
            '
            'KryptonGroupBox10
            '
            Me.KryptonGroupBox10.CaptionOverlap = 0R
            Me.KryptonGroupBox10.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox10.Location = New System.Drawing.Point(7, 35)
            Me.KryptonGroupBox10.Name = "KryptonGroupBox10"
            '
            'KryptonGroupBox10.Panel
            '
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.TextBox10)
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.KryptonLabel35)
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.KryptonLabel34)
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.DateTimePicker6)
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.KryptonLabel33)
            Me.KryptonGroupBox10.Panel.Controls.Add(Me.DateTimePicker7)
            Me.KryptonGroupBox10.Size = New System.Drawing.Size(697, 55)
            Me.KryptonGroupBox10.TabIndex = 206
            Me.KryptonGroupBox10.Values.Heading = "Reporte Asistencia"
            '
            'KryptonLabel35
            '
            Me.KryptonLabel35.Location = New System.Drawing.Point(362, 3)
            Me.KryptonLabel35.Name = "KryptonLabel35"
            Me.KryptonLabel35.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel35.TabIndex = 203
            Me.KryptonLabel35.Values.Text = "Buscar"
            '
            'KryptonLabel34
            '
            Me.KryptonLabel34.Location = New System.Drawing.Point(186, 2)
            Me.KryptonLabel34.Name = "KryptonLabel34"
            Me.KryptonLabel34.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel34.TabIndex = 201
            Me.KryptonLabel34.Values.Text = "Hasta"
            '
            'KryptonLabel33
            '
            Me.KryptonLabel33.Location = New System.Drawing.Point(2, 3)
            Me.KryptonLabel33.Name = "KryptonLabel33"
            Me.KryptonLabel33.Size = New System.Drawing.Size(45, 20)
            Me.KryptonLabel33.TabIndex = 0
            Me.KryptonLabel33.Values.Text = "Desde"
            '
            'KryptonPage5
            '
            Me.KryptonPage5.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel51)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel50)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel49)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel48)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel47)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel46)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel45)
            Me.KryptonPage5.Controls.Add(Me.KryptonLabel44)
            Me.KryptonPage5.Controls.Add(Me.TextBox8)
            Me.KryptonPage5.Controls.Add(Me.txtTotalNotaCredito)
            Me.KryptonPage5.Controls.Add(Me.txtTotalRetencion)
            Me.KryptonPage5.Controls.Add(Me.txtTotalACobrar)
            Me.KryptonPage5.Controls.Add(Me.txtTotalSubtotal)
            Me.KryptonPage5.Controls.Add(Me.txtTotalIVA)
            Me.KryptonPage5.Controls.Add(Me.txtTotalFacturas)
            Me.KryptonPage5.Controls.Add(Me.Label38)
            Me.KryptonPage5.Controls.Add(Me.lblNroRegistros)
            Me.KryptonPage5.Controls.Add(Me.Label17)
            Me.KryptonPage5.Controls.Add(Me.MenuStrip2)
            Me.KryptonPage5.Controls.Add(Me.KryptonGroupBox11)
            Me.KryptonPage5.Controls.Add(Me.dgvFacturaVenta)
            Me.KryptonPage5.Flags = 65534
            Me.KryptonPage5.LastVisibleSet = True
            Me.KryptonPage5.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage5.Name = "KryptonPage5"
            Me.KryptonPage5.Size = New System.Drawing.Size(678, 669)
            Me.KryptonPage5.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage5.Text = "Historial"
            Me.KryptonPage5.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage5.UniqueName = "4723714FF0274E48859C587BD3B9B735"
            '
            'KryptonLabel51
            '
            Me.KryptonLabel51.Location = New System.Drawing.Point(601, 606)
            Me.KryptonLabel51.Name = "KryptonLabel51"
            Me.KryptonLabel51.Size = New System.Drawing.Size(69, 20)
            Me.KryptonLabel51.TabIndex = 231
            Me.KryptonLabel51.Values.Text = "Disponible"
            '
            'KryptonLabel50
            '
            Me.KryptonLabel50.Location = New System.Drawing.Point(379, 635)
            Me.KryptonLabel50.Name = "KryptonLabel50"
            Me.KryptonLabel50.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel50.TabIndex = 230
            Me.KryptonLabel50.Values.Text = "T Cobrar"
            '
            'KryptonLabel49
            '
            Me.KryptonLabel49.Location = New System.Drawing.Point(435, 608)
            Me.KryptonLabel49.Name = "KryptonLabel49"
            Me.KryptonLabel49.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel49.TabIndex = 229
            Me.KryptonLabel49.Values.Text = "T Factura"
            '
            'KryptonLabel48
            '
            Me.KryptonLabel48.Location = New System.Drawing.Point(204, 635)
            Me.KryptonLabel48.Name = "KryptonLabel48"
            Me.KryptonLabel48.Size = New System.Drawing.Size(73, 20)
            Me.KryptonLabel48.TabIndex = 228
            Me.KryptonLabel48.Values.Text = "T N Credito"
            '
            'KryptonLabel47
            '
            Me.KryptonLabel47.Location = New System.Drawing.Point(291, 606)
            Me.KryptonLabel47.Name = "KryptonLabel47"
            Me.KryptonLabel47.Size = New System.Drawing.Size(29, 20)
            Me.KryptonLabel47.TabIndex = 227
            Me.KryptonLabel47.Values.Text = "IVA"
            '
            'KryptonLabel46
            '
            Me.KryptonLabel46.Location = New System.Drawing.Point(135, 608)
            Me.KryptonLabel46.Name = "KryptonLabel46"
            Me.KryptonLabel46.Size = New System.Drawing.Size(56, 20)
            Me.KryptonLabel46.TabIndex = 226
            Me.KryptonLabel46.Values.Text = "Subtotal"
            '
            'KryptonLabel45
            '
            Me.KryptonLabel45.Location = New System.Drawing.Point(13, 635)
            Me.KryptonLabel45.Name = "KryptonLabel45"
            Me.KryptonLabel45.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel45.TabIndex = 225
            Me.KryptonLabel45.Values.Text = "T Retencion"
            '
            'KryptonLabel44
            '
            Me.KryptonLabel44.Location = New System.Drawing.Point(10, 606)
            Me.KryptonLabel44.Name = "KryptonLabel44"
            Me.KryptonLabel44.Size = New System.Drawing.Size(75, 20)
            Me.KryptonLabel44.TabIndex = 224
            Me.KryptonLabel44.Values.Text = "No Registro"
            '
            'TextBox8
            '
            Me.TextBox8.BackColor = System.Drawing.Color.White
            Me.TextBox8.Enabled = False
            Me.TextBox8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox8.Location = New System.Drawing.Point(565, 632)
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Size = New System.Drawing.Size(97, 21)
            Me.TextBox8.TabIndex = 223
            Me.TextBox8.Text = "0.00"
            Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalNotaCredito
            '
            Me.txtTotalNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtTotalNotaCredito.Enabled = False
            Me.txtTotalNotaCredito.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalNotaCredito.Location = New System.Drawing.Point(280, 634)
            Me.txtTotalNotaCredito.Name = "txtTotalNotaCredito"
            Me.txtTotalNotaCredito.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalNotaCredito.TabIndex = 220
            Me.txtTotalNotaCredito.Text = "0.00"
            Me.txtTotalNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalRetencion
            '
            Me.txtTotalRetencion.BackColor = System.Drawing.Color.White
            Me.txtTotalRetencion.Enabled = False
            Me.txtTotalRetencion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalRetencion.Location = New System.Drawing.Point(94, 634)
            Me.txtTotalRetencion.Name = "txtTotalRetencion"
            Me.txtTotalRetencion.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalRetencion.TabIndex = 218
            Me.txtTotalRetencion.Text = "0.00"
            Me.txtTotalRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalACobrar
            '
            Me.txtTotalACobrar.BackColor = System.Drawing.Color.White
            Me.txtTotalACobrar.Enabled = False
            Me.txtTotalACobrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalACobrar.Location = New System.Drawing.Point(445, 632)
            Me.txtTotalACobrar.Name = "txtTotalACobrar"
            Me.txtTotalACobrar.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalACobrar.TabIndex = 216
            Me.txtTotalACobrar.Text = "0.00"
            Me.txtTotalACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalSubtotal
            '
            Me.txtTotalSubtotal.BackColor = System.Drawing.Color.White
            Me.txtTotalSubtotal.Enabled = False
            Me.txtTotalSubtotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalSubtotal.Location = New System.Drawing.Point(202, 605)
            Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
            Me.txtTotalSubtotal.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalSubtotal.TabIndex = 214
            Me.txtTotalSubtotal.Text = "0.00"
            Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalIVA
            '
            Me.txtTotalIVA.BackColor = System.Drawing.Color.White
            Me.txtTotalIVA.Enabled = False
            Me.txtTotalIVA.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalIVA.Location = New System.Drawing.Point(339, 606)
            Me.txtTotalIVA.Name = "txtTotalIVA"
            Me.txtTotalIVA.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalIVA.TabIndex = 212
            Me.txtTotalIVA.Text = "0.00"
            Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalFacturas
            '
            Me.txtTotalFacturas.BackColor = System.Drawing.Color.White
            Me.txtTotalFacturas.Enabled = False
            Me.txtTotalFacturas.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalFacturas.Location = New System.Drawing.Point(501, 605)
            Me.txtTotalFacturas.Name = "txtTotalFacturas"
            Me.txtTotalFacturas.Size = New System.Drawing.Size(78, 21)
            Me.txtTotalFacturas.TabIndex = 210
            Me.txtTotalFacturas.Text = "0.00"
            Me.txtTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Location = New System.Drawing.Point(712, 559)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(74, 26)
            Me.Label38.TabIndex = 222
            Me.Label38.Text = "DISPONIBLE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FACTURAR:"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNroRegistros
            '
            Me.lblNroRegistros.AutoSize = True
            Me.lblNroRegistros.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.lblNroRegistros.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroRegistros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNroRegistros.Location = New System.Drawing.Point(91, 609)
            Me.lblNroRegistros.Name = "lblNroRegistros"
            Me.lblNroRegistros.Size = New System.Drawing.Size(13, 13)
            Me.lblNroRegistros.TabIndex = 209
            Me.lblNroRegistros.Text = "0"
            '
            'KryptonGroupBox11
            '
            Me.KryptonGroupBox11.CaptionOverlap = 0R
            Me.KryptonGroupBox11.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox11.Location = New System.Drawing.Point(8, 36)
            Me.KryptonGroupBox11.Name = "KryptonGroupBox11"
            '
            'KryptonGroupBox11.Panel
            '
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel42)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel41)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.TextBox7)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.TextBox5)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel40)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel39)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel36)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel37)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.ComboBox3)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.KryptonLabel38)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.TextBox4)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.TextBox6)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.dtpFechaHasta)
            Me.KryptonGroupBox11.Panel.Controls.Add(Me.dtpFechaDesde)
            Me.KryptonGroupBox11.Size = New System.Drawing.Size(664, 109)
            Me.KryptonGroupBox11.TabIndex = 183
            Me.KryptonGroupBox11.Values.Heading = "Cliente"
            '
            'KryptonLabel42
            '
            Me.KryptonLabel42.Location = New System.Drawing.Point(293, 51)
            Me.KryptonLabel42.Name = "KryptonLabel42"
            Me.KryptonLabel42.Size = New System.Drawing.Size(41, 20)
            Me.KryptonLabel42.TabIndex = 193
            Me.KryptonLabel42.Values.Text = "Hasta"
            '
            'KryptonLabel41
            '
            Me.KryptonLabel41.Location = New System.Drawing.Point(5, 52)
            Me.KryptonLabel41.Name = "KryptonLabel41"
            Me.KryptonLabel41.Size = New System.Drawing.Size(122, 20)
            Me.KryptonLabel41.TabIndex = 192
            Me.KryptonLabel41.Values.Text = "Hsitorial Facturacion"
            '
            'KryptonLabel40
            '
            Me.KryptonLabel40.Location = New System.Drawing.Point(478, 28)
            Me.KryptonLabel40.Name = "KryptonLabel40"
            Me.KryptonLabel40.Size = New System.Drawing.Size(79, 20)
            Me.KryptonLabel40.TabIndex = 18
            Me.KryptonLabel40.Values.Text = "Val Contrato"
            '
            'KryptonLabel39
            '
            Me.KryptonLabel39.Location = New System.Drawing.Point(478, 5)
            Me.KryptonLabel39.Name = "KryptonLabel39"
            Me.KryptonLabel39.Size = New System.Drawing.Size(84, 20)
            Me.KryptonLabel39.TabIndex = 17
            Me.KryptonLabel39.Values.Text = "Año Contrato"
            '
            'KryptonLabel36
            '
            Me.KryptonLabel36.Location = New System.Drawing.Point(293, 3)
            Me.KryptonLabel36.Name = "KryptonLabel36"
            Me.KryptonLabel36.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel36.TabIndex = 16
            Me.KryptonLabel36.Values.Text = "RUC"
            '
            'KryptonLabel37
            '
            Me.KryptonLabel37.Location = New System.Drawing.Point(5, 30)
            Me.KryptonLabel37.Name = "KryptonLabel37"
            Me.KryptonLabel37.Size = New System.Drawing.Size(48, 20)
            Me.KryptonLabel37.TabIndex = 15
            Me.KryptonLabel37.Values.Text = "Cliente"
            '
            'KryptonLabel38
            '
            Me.KryptonLabel38.Location = New System.Drawing.Point(5, 4)
            Me.KryptonLabel38.Name = "KryptonLabel38"
            Me.KryptonLabel38.Size = New System.Drawing.Size(111, 20)
            Me.KryptonLabel38.TabIndex = 14
            Me.KryptonLabel38.Values.Text = "Tipo Identificacion"
            '
            'KryptonPage6
            '
            Me.KryptonPage6.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage6.Controls.Add(Me.DataGridView2)
            Me.KryptonPage6.Controls.Add(Me.TextBox9)
            Me.KryptonPage6.Controls.Add(Me.KryptonLabel43)
            Me.KryptonPage6.Controls.Add(Me.MenuStrip3)
            Me.KryptonPage6.Flags = 65534
            Me.KryptonPage6.LastVisibleSet = True
            Me.KryptonPage6.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage6.Name = "KryptonPage6"
            Me.KryptonPage6.Size = New System.Drawing.Size(678, 669)
            Me.KryptonPage6.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.KryptonPage6.Text = "Convenio"
            Me.KryptonPage6.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage6.UniqueName = "7AF916BA3E3E481CD585CA609D403106"
            '
            'KryptonLabel43
            '
            Me.KryptonLabel43.Location = New System.Drawing.Point(15, 36)
            Me.KryptonLabel43.Name = "KryptonLabel43"
            Me.KryptonLabel43.Size = New System.Drawing.Size(46, 20)
            Me.KryptonLabel43.TabIndex = 182
            Me.KryptonLabel43.Values.Text = "Buscar"
            '
            'FormMantenimientoClientes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(680, 696)
            Me.Controls.Add(Me.KryptonNavigator1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMantenimientoClientes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "MANTENIMIENTO DE CLIENTES"
            CType(Me.dgvClienteGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbConvenioBancario.ResumeLayout(False)
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip5.ResumeLayout(False)
            Me.MenuStrip5.PerformLayout()
            CType(Me.dgvSitios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.MenuStrip4.ResumeLayout(False)
            Me.MenuStrip4.PerformLayout()
            CType(Me.dgvFacturaVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip2.ResumeLayout(False)
            Me.MenuStrip2.PerformLayout()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip3.ResumeLayout(False)
            Me.MenuStrip3.PerformLayout()
            CType(Me.KryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonNavigator1.ResumeLayout(False)
            CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabControl1.ResumeLayout(False)
            Me.TabControl1.PerformLayout()
            CType(Me.KryptonGroupBox5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.Panel.ResumeLayout(False)
            Me.KryptonGroupBox5.Panel.PerformLayout()
            CType(Me.KryptonGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox5.ResumeLayout(False)
            CType(Me.KryptonGroupBox4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.Panel.ResumeLayout(False)
            Me.KryptonGroupBox4.Panel.PerformLayout()
            CType(Me.KryptonGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox4.ResumeLayout(False)
            CType(Me.KryptonGroupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.Panel.ResumeLayout(False)
            Me.KryptonGroupBox3.Panel.PerformLayout()
            CType(Me.KryptonGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox3.ResumeLayout(False)
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
            Me.KryptonPage2.PerformLayout()
            CType(Me.KryptonGroupBox7.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox7.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox7.ResumeLayout(False)
            CType(Me.KryptonGroupBox6.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.Panel.ResumeLayout(False)
            Me.KryptonGroupBox6.Panel.PerformLayout()
            CType(Me.KryptonGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox6.ResumeLayout(False)
            CType(Me.KryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage3.ResumeLayout(False)
            Me.KryptonPage3.PerformLayout()
            CType(Me.KryptonGroupBox9.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox9.Panel.ResumeLayout(False)
            Me.KryptonGroupBox9.Panel.PerformLayout()
            CType(Me.KryptonGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox9.ResumeLayout(False)
            CType(Me.KryptonGroupBox8.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox8.Panel.ResumeLayout(False)
            Me.KryptonGroupBox8.Panel.PerformLayout()
            CType(Me.KryptonGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox8.ResumeLayout(False)
            CType(Me.KryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage4.ResumeLayout(False)
            Me.KryptonPage4.PerformLayout()
            CType(Me.KryptonGroupBox10.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox10.Panel.ResumeLayout(False)
            Me.KryptonGroupBox10.Panel.PerformLayout()
            CType(Me.KryptonGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox10.ResumeLayout(False)
            CType(Me.KryptonPage5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage5.ResumeLayout(False)
            Me.KryptonPage5.PerformLayout()
            CType(Me.KryptonGroupBox11.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox11.Panel.ResumeLayout(False)
            Me.KryptonGroupBox11.Panel.PerformLayout()
            CType(Me.KryptonGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox11.ResumeLayout(False)
            CType(Me.KryptonPage6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage6.ResumeLayout(False)
            Me.KryptonPage6.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtnroResContEspecial As System.Windows.Forms.TextBox
        Friend WithEvents txtApellidoNombreComercial As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreRazonSocialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtRucCiClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionUbicacionClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionFacturacionClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
        Friend WithEvents txtContactoClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtEmailClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono2ClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono1ClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents rbNOLlevaContabilidad As System.Windows.Forms.RadioButton
        Friend WithEvents rbSILlevaContabilidad As System.Windows.Forms.RadioButton
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaIngresoClienteGeneral As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbTipoCliente As System.Windows.Forms.ComboBox
        Friend WithEvents dgvClienteGeneral As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents cmbTipoIdentificacion As System.Windows.Forms.ComboBox
        Friend WithEvents txtBuscarCliente As System.Windows.Forms.TextBox
        Friend WithEvents rbNoContribuyenteEspecial As System.Windows.Forms.RadioButton
        Friend WithEvents rbSiContribuyenteEspecial As System.Windows.Forms.RadioButton
        Friend WithEvents txtConsorcioGrupo As System.Windows.Forms.TextBox
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents dgvSitios As System.Windows.Forms.DataGridView
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCanton As System.Windows.Forms.ComboBox
        Friend WithEvents txtNombreSitio As System.Windows.Forms.TextBox
        Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents cbxSupervisor As System.Windows.Forms.ComboBox
        Friend WithEvents cbmTipo As System.Windows.Forms.ComboBox
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents gbConvenioBancario As System.Windows.Forms.GroupBox
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TextBoxVal As System.Windows.Forms.TextBox
        Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
        Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
        Friend WithEvents dgvFacturaVenta As System.Windows.Forms.DataGridView
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
        Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
        Friend WithEvents DateTimePicker7 As System.Windows.Forms.DateTimePicker
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
        Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip5 As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents AGREGARSITIOToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents KryptonNavigator1 As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents TabControl1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage3 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage4 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage5 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonPage6 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel14 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox3 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox4 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel6 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox5 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel17 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel16 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel15 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel18 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents chkConvenio As Krypton.Toolkit.KryptonCheckBox
        Friend WithEvents KryptonGroupBox6 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel21 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel19 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel20 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox7 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonGroupBox8 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel22 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel23 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel24 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox9 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel28 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel29 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel25 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel26 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel27 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel32 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel31 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel30 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox10 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel35 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel34 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel33 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox11 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel42 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel41 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel40 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel39 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel36 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel37 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel38 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel43 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents TextBox8 As TextBox
        Friend WithEvents txtTotalNotaCredito As TextBox
        Friend WithEvents txtTotalRetencion As TextBox
        Friend WithEvents txtTotalACobrar As TextBox
        Friend WithEvents txtTotalSubtotal As TextBox
        Friend WithEvents txtTotalIVA As TextBox
        Friend WithEvents txtTotalFacturas As TextBox
        Friend WithEvents Label38 As Label
        Friend WithEvents lblNroRegistros As Label
        Friend WithEvents KryptonLabel51 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel50 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel49 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel48 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel47 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel46 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel45 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel44 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace