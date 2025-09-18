Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormBajasActivosFijos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBajasActivosFijos))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblIdCustodio = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.lblTipoActivo = New System.Windows.Forms.Label()
            Me.txtAutorizo = New System.Windows.Forms.TextBox()
            Me.txtIdBaja = New System.Windows.Forms.TextBox()
            Me.txtDestinatario = New System.Windows.Forms.TextBox()
            Me.txtNroMemorandum = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtInformeTecnico = New System.Windows.Forms.TextBox()
            Me.cbmEstadoActivo = New System.Windows.Forms.ComboBox()
            Me.lblNombreCustodio = New System.Windows.Forms.Label()
            Me.lblNombreActivoFijo = New System.Windows.Forms.Label()
            Me.lblCodigoActivo = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.cbmMotivo = New System.Windows.Forms.ComboBox()
            Me.rbNombreCustodio = New System.Windows.Forms.RadioButton()
            Me.txtBusquedaActivoFijo = New System.Windows.Forms.TextBox()
            Me.rbCodigoActivo = New System.Windows.Forms.RadioButton()
            Me.dgvActivosFijos = New System.Windows.Forms.DataGridView()
            Me.ttSeleccion = New System.Windows.Forms.ToolTip(Me.components)
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoBaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnBaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.lblIdCustodio)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.lblCodigo)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(437, 140)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(125, 76)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA ACTIVO"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(8, 143)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(64, 13)
            Me.Label12.TabIndex = 69
            Me.Label12.Text = "AUTORIZO:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(708, 45)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(52, 13)
            Me.Label11.TabIndex = 67
            Me.Label11.Text = "N° BAJA:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(8, 111)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(83, 26)
            Me.Label10.TabIndex = 64
            Me.Label10.Text = "DESTINATARIO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACTIVO:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(707, 123)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(105, 13)
            Me.Label9.TabIndex = 62
            Me.Label9.Text = "N° MEMORANDUM:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 162)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 13)
            Me.Label6.TabIndex = 59
            Me.Label6.Text = "DATOS:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 64)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(107, 13)
            Me.Label5.TabIndex = 58
            Me.Label5.Text = "INFORME TÉCNICO:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(395, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(94, 13)
            Me.Label4.TabIndex = 55
            Me.Label4.Text = "ESTADO ACTIVO:"
            '
            'lblIdCustodio
            '
            Me.lblIdCustodio.AutoSize = True
            Me.lblIdCustodio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblIdCustodio.Location = New System.Drawing.Point(71, 181)
            Me.lblIdCustodio.Name = "lblIdCustodio"
            Me.lblIdCustodio.Size = New System.Drawing.Size(0, 13)
            Me.lblIdCustodio.TabIndex = 53
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(708, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(44, 13)
            Me.Label3.TabIndex = 50
            Me.Label3.Text = "FECHA:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(395, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(53, 13)
            Me.Label2.TabIndex = 46
            Me.Label2.Text = "MOTIVO:"
            '
            'lblCodigo
            '
            Me.lblCodigo.AutoSize = True
            Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCodigo.Location = New System.Drawing.Point(71, 199)
            Me.lblCodigo.Name = "lblCodigo"
            Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
            Me.lblCodigo.TabIndex = 43
            '
            'lblTipoActivo
            '
            Me.lblTipoActivo.AutoSize = True
            Me.lblTipoActivo.BackColor = System.Drawing.Color.Transparent
            Me.lblTipoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTipoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTipoActivo.Location = New System.Drawing.Point(502, 184)
            Me.lblTipoActivo.Name = "lblTipoActivo"
            Me.lblTipoActivo.Size = New System.Drawing.Size(0, 13)
            Me.lblTipoActivo.TabIndex = 71
            Me.lblTipoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtAutorizo
            '
            Me.txtAutorizo.Enabled = False
            Me.txtAutorizo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAutorizo.Location = New System.Drawing.Point(92, 136)
            Me.txtAutorizo.Name = "txtAutorizo"
            Me.txtAutorizo.Size = New System.Drawing.Size(395, 21)
            Me.txtAutorizo.TabIndex = 70
            '
            'txtIdBaja
            '
            Me.txtIdBaja.Enabled = False
            Me.txtIdBaja.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdBaja.Location = New System.Drawing.Point(554, 36)
            Me.txtIdBaja.Name = "txtIdBaja"
            Me.txtIdBaja.Size = New System.Drawing.Size(125, 21)
            Me.txtIdBaja.TabIndex = 68
            '
            'txtDestinatario
            '
            Me.txtDestinatario.Enabled = False
            Me.txtDestinatario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDestinatario.Location = New System.Drawing.Point(92, 110)
            Me.txtDestinatario.Name = "txtDestinatario"
            Me.txtDestinatario.Size = New System.Drawing.Size(395, 21)
            Me.txtDestinatario.TabIndex = 65
            '
            'txtNroMemorandum
            '
            Me.txtNroMemorandum.Enabled = False
            Me.txtNroMemorandum.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroMemorandum.Location = New System.Drawing.Point(587, 111)
            Me.txtNroMemorandum.Name = "txtNroMemorandum"
            Me.txtNroMemorandum.Size = New System.Drawing.Size(92, 21)
            Me.txtNroMemorandum.TabIndex = 63
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(11, 184)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(38, 13)
            Me.Label8.TabIndex = 61
            Me.Label8.Text = "Activo"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(8, 163)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(51, 13)
            Me.Label7.TabIndex = 60
            Me.Label7.Text = "Custodio"
            '
            'txtInformeTecnico
            '
            Me.txtInformeTecnico.Enabled = False
            Me.txtInformeTecnico.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtInformeTecnico.Location = New System.Drawing.Point(92, 61)
            Me.txtInformeTecnico.Multiline = True
            Me.txtInformeTecnico.Name = "txtInformeTecnico"
            Me.txtInformeTecnico.Size = New System.Drawing.Size(587, 42)
            Me.txtInformeTecnico.TabIndex = 57
            '
            'cbmEstadoActivo
            '
            Me.cbmEstadoActivo.Enabled = False
            Me.cbmEstadoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmEstadoActivo.FormattingEnabled = True
            Me.cbmEstadoActivo.Items.AddRange(New Object() {"OBSOLETO", "INSERVIBLE", "NINGUNO"})
            Me.cbmEstadoActivo.Location = New System.Drawing.Point(373, 8)
            Me.cbmEstadoActivo.Name = "cbmEstadoActivo"
            Me.cbmEstadoActivo.Size = New System.Drawing.Size(114, 21)
            Me.cbmEstadoActivo.TabIndex = 56
            '
            'lblNombreCustodio
            '
            Me.lblNombreCustodio.AutoSize = True
            Me.lblNombreCustodio.BackColor = System.Drawing.Color.Transparent
            Me.lblNombreCustodio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreCustodio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.lblNombreCustodio.Location = New System.Drawing.Point(98, 161)
            Me.lblNombreCustodio.Name = "lblNombreCustodio"
            Me.lblNombreCustodio.Size = New System.Drawing.Size(0, 13)
            Me.lblNombreCustodio.TabIndex = 54
            Me.lblNombreCustodio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblNombreActivoFijo
            '
            Me.lblNombreActivoFijo.AutoSize = True
            Me.lblNombreActivoFijo.BackColor = System.Drawing.Color.Transparent
            Me.lblNombreActivoFijo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreActivoFijo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblNombreActivoFijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblNombreActivoFijo.Location = New System.Drawing.Point(204, 184)
            Me.lblNombreActivoFijo.Name = "lblNombreActivoFijo"
            Me.lblNombreActivoFijo.Size = New System.Drawing.Size(0, 13)
            Me.lblNombreActivoFijo.TabIndex = 52
            Me.lblNombreActivoFijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCodigoActivo
            '
            Me.lblCodigoActivo.AutoSize = True
            Me.lblCodigoActivo.BackColor = System.Drawing.Color.Transparent
            Me.lblCodigoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCodigoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCodigoActivo.Location = New System.Drawing.Point(97, 182)
            Me.lblCodigoActivo.Name = "lblCodigoActivo"
            Me.lblCodigoActivo.Size = New System.Drawing.Size(0, 13)
            Me.lblCodigoActivo.TabIndex = 51
            Me.lblCodigoActivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFecha.Location = New System.Drawing.Point(554, 8)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(125, 21)
            Me.txtFecha.TabIndex = 48
            '
            'cbmMotivo
            '
            Me.cbmMotivo.Enabled = False
            Me.cbmMotivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmMotivo.FormattingEnabled = True
            Me.cbmMotivo.Items.AddRange(New Object() {"DONACIÓN", "DESTRUCCIÓN", "VENTA", "PERDIDA"})
            Me.cbmMotivo.Location = New System.Drawing.Point(373, 36)
            Me.cbmMotivo.Name = "cbmMotivo"
            Me.cbmMotivo.Size = New System.Drawing.Size(114, 21)
            Me.cbmMotivo.TabIndex = 47
            '
            'rbNombreCustodio
            '
            Me.rbNombreCustodio.AutoSize = True
            Me.rbNombreCustodio.BackColor = System.Drawing.Color.Transparent
            Me.rbNombreCustodio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNombreCustodio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbNombreCustodio.Location = New System.Drawing.Point(95, 12)
            Me.rbNombreCustodio.Name = "rbNombreCustodio"
            Me.rbNombreCustodio.Size = New System.Drawing.Size(69, 17)
            Me.rbNombreCustodio.TabIndex = 40
            Me.rbNombreCustodio.TabStop = True
            Me.rbNombreCustodio.Text = "Custodio"
            Me.rbNombreCustodio.UseVisualStyleBackColor = False
            '
            'txtBusquedaActivoFijo
            '
            Me.txtBusquedaActivoFijo.Enabled = False
            Me.txtBusquedaActivoFijo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBusquedaActivoFijo.Location = New System.Drawing.Point(24, 35)
            Me.txtBusquedaActivoFijo.Name = "txtBusquedaActivoFijo"
            Me.txtBusquedaActivoFijo.Size = New System.Drawing.Size(286, 21)
            Me.txtBusquedaActivoFijo.TabIndex = 39
            '
            'rbCodigoActivo
            '
            Me.rbCodigoActivo.AutoSize = True
            Me.rbCodigoActivo.BackColor = System.Drawing.Color.Transparent
            Me.rbCodigoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCodigoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbCodigoActivo.Location = New System.Drawing.Point(24, 12)
            Me.rbCodigoActivo.Name = "rbCodigoActivo"
            Me.rbCodigoActivo.Size = New System.Drawing.Size(59, 17)
            Me.rbCodigoActivo.TabIndex = 41
            Me.rbCodigoActivo.TabStop = True
            Me.rbCodigoActivo.Text = "Codigo"
            Me.rbCodigoActivo.UseVisualStyleBackColor = False
            '
            'dgvActivosFijos
            '
            Me.dgvActivosFijos.AllowUserToAddRows = False
            Me.dgvActivosFijos.AllowUserToDeleteRows = False
            Me.dgvActivosFijos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivosFijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvActivosFijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActivosFijos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivosFijos.Location = New System.Drawing.Point(3, 283)
            Me.dgvActivosFijos.MultiSelect = False
            Me.dgvActivosFijos.Name = "dgvActivosFijos"
            Me.dgvActivosFijos.RowHeadersVisible = False
            Me.dgvActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijos.Size = New System.Drawing.Size(694, 200)
            Me.dgvActivosFijos.TabIndex = 50
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoBaja, Me.btnBaja, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(703, 32)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoBaja
            '
            Me.btnNuevoBaja.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevoBaja.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoBaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoBaja.Name = "btnNuevoBaja"
            Me.btnNuevoBaja.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevoBaja.Text = "NUEVO"
            '
            'btnBaja
            '
            Me.btnBaja.AutoSize = False
            Me.btnBaja.Enabled = False
            Me.btnBaja.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBaja.Image = Global.syscisepro.My.Resources.Resources.playlist_remove_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnBaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBaja.Name = "btnBaja"
            Me.btnBaja.Size = New System.Drawing.Size(71, 28)
            Me.btnBaja.Text = "BAJA"
            '
            'btnReporte
            '
            Me.btnReporte.AutoSize = False
            Me.btnReporte.Enabled = False
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(84, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(5, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblTipoActivo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtAutorizo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNroMemorandum)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblNombreActivoFijo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDestinatario)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.Label7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdBaja)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbCodigoActivo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbNombreCustodio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtBusquedaActivoFijo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblNombreCustodio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmEstadoActivo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFecha)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblCodigoActivo)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtInformeTecnico)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmMotivo)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(692, 239)
            Me.KryptonGroupBox1.TabIndex = 189
            Me.KryptonGroupBox1.Values.Heading = "Busqueda"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(495, 109)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(88, 20)
            Me.KryptonLabel8.TabIndex = 73
            Me.KryptonLabel8.Values.Text = "Memorandum"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(7, 136)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(57, 20)
            Me.KryptonLabel7.TabIndex = 72
            Me.KryptonLabel7.Values.Text = "Autorizo"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(7, 107)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(76, 20)
            Me.KryptonLabel6.TabIndex = 71
            Me.KryptonLabel6.Values.Text = "Destinatario"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(495, 34)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel5.TabIndex = 70
            Me.KryptonLabel5.Values.Text = "No Baja"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(320, 34)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel4.TabIndex = 69
            Me.KryptonLabel4.Values.Text = "Motivo"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(7, 61)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(53, 20)
            Me.KryptonLabel3.TabIndex = 57
            Me.KryptonLabel3.Values.Text = "Informe"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(495, 9)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 43
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(320, 8)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel1.TabIndex = 42
            Me.KryptonLabel1.Values.Text = "Estado"
            '
            'FormBajasActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(703, 486)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvActivosFijos)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormBajasActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.Text = "BAJAS DE ACTIVOS FIJOS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbNombreCustodio As System.Windows.Forms.RadioButton
        Friend WithEvents txtBusquedaActivoFijo As System.Windows.Forms.TextBox
        Friend WithEvents rbCodigoActivo As System.Windows.Forms.RadioButton
        Friend WithEvents lblCodigo As System.Windows.Forms.Label
        Friend WithEvents cbmMotivo As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents dgvActivosFijos As System.Windows.Forms.DataGridView
        Friend WithEvents lblNombreActivoFijo As System.Windows.Forms.Label
        Friend WithEvents lblCodigoActivo As System.Windows.Forms.Label
        Friend WithEvents lblNombreCustodio As System.Windows.Forms.Label
        Friend WithEvents lblIdCustodio As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtInformeTecnico As System.Windows.Forms.TextBox
        Friend WithEvents cbmEstadoActivo As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNroMemorandum As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtDestinatario As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtIdBaja As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtAutorizo As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents lblTipoActivo As System.Windows.Forms.Label
        Friend WithEvents ttSeleccion As System.Windows.Forms.ToolTip
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoBaja As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnBaja As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace