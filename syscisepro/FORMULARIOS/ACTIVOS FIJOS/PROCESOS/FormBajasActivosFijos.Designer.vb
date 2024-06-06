Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBajasActivosFijos
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBajasActivosFijos))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblTipoActivo = New System.Windows.Forms.Label()
            Me.txtAutorizo = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtIdBaja = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtDestinatario = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtNroMemorandum = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtInformeTecnico = New System.Windows.Forms.TextBox()
            Me.cbmEstadoActivo = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblNombreCustodio = New System.Windows.Forms.Label()
            Me.lblIdCustodio = New System.Windows.Forms.Label()
            Me.lblNombreActivoFijo = New System.Windows.Forms.Label()
            Me.lblCodigoActivo = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.cbmMotivo = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblCodigo = New System.Windows.Forms.Label()
            Me.rbNombreCustodio = New System.Windows.Forms.RadioButton()
            Me.txtBusquedaActivoFijo = New System.Windows.Forms.TextBox()
            Me.rbCodigoActivo = New System.Windows.Forms.RadioButton()
            Me.dgvActivosFijos = New System.Windows.Forms.DataGridView()
            Me.ttSeleccion = New System.Windows.Forms.ToolTip(Me.components)
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoBaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnBaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblTipoActivo)
            Me.GroupBox1.Controls.Add(Me.txtAutorizo)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.txtIdBaja)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtDestinatario)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtNroMemorandum)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtInformeTecnico)
            Me.GroupBox1.Controls.Add(Me.cbmEstadoActivo)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.lblNombreCustodio)
            Me.GroupBox1.Controls.Add(Me.lblIdCustodio)
            Me.GroupBox1.Controls.Add(Me.lblNombreActivoFijo)
            Me.GroupBox1.Controls.Add(Me.lblCodigoActivo)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtFecha)
            Me.GroupBox1.Controls.Add(Me.cbmMotivo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.lblCodigo)
            Me.GroupBox1.Controls.Add(Me.rbNombreCustodio)
            Me.GroupBox1.Controls.Add(Me.txtBusquedaActivoFijo)
            Me.GroupBox1.Controls.Add(Me.rbCodigoActivo)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 38)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(920, 220)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "BUSQUEDA ACTIVO"
            '
            'lblTipoActivo
            '
            Me.lblTipoActivo.AutoSize = True
            Me.lblTipoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblTipoActivo.Location = New System.Drawing.Point(662, 200)
            Me.lblTipoActivo.Name = "lblTipoActivo"
            Me.lblTipoActivo.Size = New System.Drawing.Size(0, 13)
            Me.lblTipoActivo.TabIndex = 71
            '
            'txtAutorizo
            '
            Me.txtAutorizo.Enabled = False
            Me.txtAutorizo.Location = New System.Drawing.Point(115, 140)
            Me.txtAutorizo.Name = "txtAutorizo"
            Me.txtAutorizo.Size = New System.Drawing.Size(588, 21)
            Me.txtAutorizo.TabIndex = 70
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
            'txtIdBaja
            '
            Me.txtIdBaja.Enabled = False
            Me.txtIdBaja.Location = New System.Drawing.Point(823, 39)
            Me.txtIdBaja.Name = "txtIdBaja"
            Me.txtIdBaja.Size = New System.Drawing.Size(88, 21)
            Me.txtIdBaja.TabIndex = 68
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
            'txtDestinatario
            '
            Me.txtDestinatario.Enabled = False
            Me.txtDestinatario.Location = New System.Drawing.Point(115, 117)
            Me.txtDestinatario.Name = "txtDestinatario"
            Me.txtDestinatario.Size = New System.Drawing.Size(588, 21)
            Me.txtDestinatario.TabIndex = 65
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
            'txtNroMemorandum
            '
            Me.txtNroMemorandum.Enabled = False
            Me.txtNroMemorandum.Location = New System.Drawing.Point(821, 120)
            Me.txtNroMemorandum.Name = "txtNroMemorandum"
            Me.txtNroMemorandum.Size = New System.Drawing.Size(92, 21)
            Me.txtNroMemorandum.TabIndex = 63
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
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(6, 200)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(49, 13)
            Me.Label8.TabIndex = 61
            Me.Label8.Text = "ACTIVO:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(6, 181)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(64, 13)
            Me.Label7.TabIndex = 60
            Me.Label7.Text = "CUSTODIO:"
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
            'txtInformeTecnico
            '
            Me.txtInformeTecnico.Enabled = False
            Me.txtInformeTecnico.Location = New System.Drawing.Point(115, 61)
            Me.txtInformeTecnico.Multiline = True
            Me.txtInformeTecnico.Name = "txtInformeTecnico"
            Me.txtInformeTecnico.Size = New System.Drawing.Size(798, 53)
            Me.txtInformeTecnico.TabIndex = 57
            '
            'cbmEstadoActivo
            '
            Me.cbmEstadoActivo.Enabled = False
            Me.cbmEstadoActivo.FormattingEnabled = True
            Me.cbmEstadoActivo.Items.AddRange(New Object() {"OBSOLETO", "INSERVIBLE", "NINGUNO"})
            Me.cbmEstadoActivo.Location = New System.Drawing.Point(497, 11)
            Me.cbmEstadoActivo.Name = "cbmEstadoActivo"
            Me.cbmEstadoActivo.Size = New System.Drawing.Size(143, 21)
            Me.cbmEstadoActivo.TabIndex = 56
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
            'lblNombreCustodio
            '
            Me.lblNombreCustodio.AutoSize = True
            Me.lblNombreCustodio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblNombreCustodio.Location = New System.Drawing.Point(126, 181)
            Me.lblNombreCustodio.Name = "lblNombreCustodio"
            Me.lblNombreCustodio.Size = New System.Drawing.Size(0, 13)
            Me.lblNombreCustodio.TabIndex = 54
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
            'lblNombreActivoFijo
            '
            Me.lblNombreActivoFijo.AutoSize = True
            Me.lblNombreActivoFijo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblNombreActivoFijo.Location = New System.Drawing.Point(232, 199)
            Me.lblNombreActivoFijo.Name = "lblNombreActivoFijo"
            Me.lblNombreActivoFijo.Size = New System.Drawing.Size(0, 13)
            Me.lblNombreActivoFijo.TabIndex = 52
            '
            'lblCodigoActivo
            '
            Me.lblCodigoActivo.AutoSize = True
            Me.lblCodigoActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.lblCodigoActivo.Location = New System.Drawing.Point(126, 199)
            Me.lblCodigoActivo.Name = "lblCodigoActivo"
            Me.lblCodigoActivo.Size = New System.Drawing.Size(0, 13)
            Me.lblCodigoActivo.TabIndex = 51
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
            'txtFecha
            '
            Me.txtFecha.Enabled = False
            Me.txtFecha.Location = New System.Drawing.Point(776, 13)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.Size = New System.Drawing.Size(135, 21)
            Me.txtFecha.TabIndex = 48
            '
            'cbmMotivo
            '
            Me.cbmMotivo.Enabled = False
            Me.cbmMotivo.FormattingEnabled = True
            Me.cbmMotivo.Items.AddRange(New Object() {"DONACIÓN", "DESTRUCCIÓN", "VENTA", "PERDIDA"})
            Me.cbmMotivo.Location = New System.Drawing.Point(497, 36)
            Me.cbmMotivo.Name = "cbmMotivo"
            Me.cbmMotivo.Size = New System.Drawing.Size(143, 21)
            Me.cbmMotivo.TabIndex = 47
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
            'rbNombreCustodio
            '
            Me.rbNombreCustodio.AutoSize = True
            Me.rbNombreCustodio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNombreCustodio.Location = New System.Drawing.Point(79, 19)
            Me.rbNombreCustodio.Name = "rbNombreCustodio"
            Me.rbNombreCustodio.Size = New System.Drawing.Size(75, 17)
            Me.rbNombreCustodio.TabIndex = 40
            Me.rbNombreCustodio.TabStop = True
            Me.rbNombreCustodio.Text = "CUSTODIO:"
            Me.rbNombreCustodio.UseVisualStyleBackColor = True
            '
            'txtBusquedaActivoFijo
            '
            Me.txtBusquedaActivoFijo.Enabled = False
            Me.txtBusquedaActivoFijo.Location = New System.Drawing.Point(9, 37)
            Me.txtBusquedaActivoFijo.Name = "txtBusquedaActivoFijo"
            Me.txtBusquedaActivoFijo.Size = New System.Drawing.Size(367, 21)
            Me.txtBusquedaActivoFijo.TabIndex = 39
            '
            'rbCodigoActivo
            '
            Me.rbCodigoActivo.AutoSize = True
            Me.rbCodigoActivo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbCodigoActivo.Location = New System.Drawing.Point(11, 19)
            Me.rbCodigoActivo.Name = "rbCodigoActivo"
            Me.rbCodigoActivo.Size = New System.Drawing.Size(65, 17)
            Me.rbCodigoActivo.TabIndex = 41
            Me.rbCodigoActivo.TabStop = True
            Me.rbCodigoActivo.Text = "CODIGO:"
            Me.rbCodigoActivo.UseVisualStyleBackColor = True
            '
            'dgvActivosFijos
            '
            Me.dgvActivosFijos.AllowUserToAddRows = False
            Me.dgvActivosFijos.AllowUserToDeleteRows = False
            Me.dgvActivosFijos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvActivosFijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijos.BackgroundColor = System.Drawing.Color.White
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
            Me.dgvActivosFijos.Location = New System.Drawing.Point(3, 261)
            Me.dgvActivosFijos.MultiSelect = False
            Me.dgvActivosFijos.Name = "dgvActivosFijos"
            Me.dgvActivosFijos.RowHeadersVisible = False
            Me.dgvActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijos.Size = New System.Drawing.Size(920, 222)
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
            Me.MenuStrip1.Size = New System.Drawing.Size(925, 32)
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
            'FormBajasActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(925, 486)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvActivosFijos)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormBajasActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BAJAS DE ACTIVOS FIJOS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
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
    End Class
End Namespace