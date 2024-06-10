Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmGenerarDebitoBancarioClientes
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarDebitoBancarioClientes))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.miniToolStrip = New System.Windows.Forms.MenuStrip()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcBodega = New System.Windows.Forms.TabControl()
            Me.tpMantenimiento = New System.Windows.Forms.TabPage()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.lblCant = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgvHoy = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.dtpFiltroDesde = New System.Windows.Forms.DateTimePicker()
            Me.dgvDebitos = New System.Windows.Forms.DataGridView()
            Me.Column12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TipDoc = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.CiRuc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Ordenante = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Contrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FormaPago = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.Banco = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.TipoCuenta = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.NumCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Motivo = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.IdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FecProceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IdFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblComprobante = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbxTipoNegociacion = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtReferencia = New System.Windows.Forms.TextBox()
            Me.txtNumCuenta = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.dtpFechaVence = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaProceso = New System.Windows.Forms.DateTimePicker()
            Me.txtTipoServicio = New System.Windows.Forms.TextBox()
            Me.txtBeneficiario = New System.Windows.Forms.TextBox()
            Me.tpReporteBodega = New System.Windows.Forms.TabPage()
            Me.gbDetalleComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarDetalleComprobante = New System.Windows.Forms.Button()
            Me.dgvDetalleComprobate = New System.Windows.Forms.DataGridView()
            Me.gbComprobante = New System.Windows.Forms.GroupBox()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.dgvComprobantesIngreso = New System.Windows.Forms.DataGridView()
            Me.gbNumeroFactura = New System.Windows.Forms.GroupBox()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.rbtDet = New System.Windows.Forms.RadioButton()
            Me.rbtNum = New System.Windows.Forms.RadioButton()
            Me.txtDetail = New System.Windows.Forms.TextBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtNroComprobante = New System.Windows.Forms.TextBox()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGenerarExcel = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.tcBodega.SuspendLayout()
            Me.tpMantenimiento.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvHoy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.tpReporteBodega.SuspendLayout()
            Me.gbDetalleComprobante.SuspendLayout()
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbComprobante.SuspendLayout()
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNumeroFactura.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.msKardex.SuspendLayout()
            Me.SuspendLayout()
            '
            'miniToolStrip
            '
            Me.miniToolStrip.AutoSize = False
            Me.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
            Me.miniToolStrip.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.miniToolStrip.Location = New System.Drawing.Point(630, 2)
            Me.miniToolStrip.Name = "miniToolStrip"
            Me.miniToolStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.miniToolStrip.Size = New System.Drawing.Size(985, 24)
            Me.miniToolStrip.TabIndex = 179
            '
            'MenuStrip1
            '
            Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
            Me.MenuStrip1.TabIndex = 179
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(117, 18)
            Me.ToolStripMenuItem3.Text = "LISTAR BODEGAS"
            '
            'ToolStripMenuItem4
            '
            Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
            Me.ToolStripMenuItem4.Size = New System.Drawing.Size(70, 20)
            Me.ToolStripMenuItem4.Text = "NUEVO"
            '
            'ToolStripMenuItem5
            '
            Me.ToolStripMenuItem5.Enabled = False
            Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
            Me.ToolStripMenuItem5.Size = New System.Drawing.Size(84, 20)
            Me.ToolStripMenuItem5.Text = "GUARDAR"
            '
            'ToolStripMenuItem6
            '
            Me.ToolStripMenuItem6.Enabled = False
            Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
            Me.ToolStripMenuItem6.Size = New System.Drawing.Size(89, 18)
            Me.ToolStripMenuItem6.Text = "ACTUALIZAR"
            '
            'ToolStripMenuItem7
            '
            Me.ToolStripMenuItem7.Enabled = False
            Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
            Me.ToolStripMenuItem7.Size = New System.Drawing.Size(75, 18)
            Me.ToolStripMenuItem7.Text = "CANCELAR"
            '
            'ToolStripMenuItem8
            '
            Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White
            Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
            Me.ToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
            Me.ToolStripMenuItem8.Size = New System.Drawing.Size(140, 20)
            Me.ToolStripMenuItem8.Text = "GENERAR REPORTE"
            '
            'tcBodega
            '
            Me.tcBodega.Controls.Add(Me.tpMantenimiento)
            Me.tcBodega.Controls.Add(Me.tpReporteBodega)
            Me.tcBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcBodega.Location = New System.Drawing.Point(1, 37)
            Me.tcBodega.Name = "tcBodega"
            Me.tcBodega.SelectedIndex = 0
            Me.tcBodega.Size = New System.Drawing.Size(1193, 618)
            Me.tcBodega.TabIndex = 182
            '
            'tpMantenimiento
            '
            Me.tpMantenimiento.Controls.Add(Me.lblTotal)
            Me.tpMantenimiento.Controls.Add(Me.lblCant)
            Me.tpMantenimiento.Controls.Add(Me.Label12)
            Me.tpMantenimiento.Controls.Add(Me.Label11)
            Me.tpMantenimiento.Controls.Add(Me.txtObservacion)
            Me.tpMantenimiento.Controls.Add(Me.Label10)
            Me.tpMantenimiento.Controls.Add(Me.btnAdd)
            Me.tpMantenimiento.Controls.Add(Me.btnRemove)
            Me.tpMantenimiento.Controls.Add(Me.Label9)
            Me.tpMantenimiento.Controls.Add(Me.GroupBox2)
            Me.tpMantenimiento.Controls.Add(Me.dgvDebitos)
            Me.tpMantenimiento.Controls.Add(Me.GroupBox1)
            Me.tpMantenimiento.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpMantenimiento.Location = New System.Drawing.Point(4, 22)
            Me.tpMantenimiento.Name = "tpMantenimiento"
            Me.tpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
            Me.tpMantenimiento.Size = New System.Drawing.Size(1185, 592)
            Me.tpMantenimiento.TabIndex = 0
            Me.tpMantenimiento.Text = "ORDEN COBROS / PAGOS"
            Me.tpMantenimiento.UseVisualStyleBackColor = True
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(1095, 567)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(0, 13)
            Me.lblTotal.TabIndex = 195
            '
            'lblCant
            '
            Me.lblCant.AutoSize = True
            Me.lblCant.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCant.Location = New System.Drawing.Point(917, 566)
            Me.lblCant.Name = "lblCant"
            Me.lblCant.Size = New System.Drawing.Size(0, 13)
            Me.lblCant.TabIndex = 194
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(1045, 567)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(45, 13)
            Me.Label12.TabIndex = 193
            Me.Label12.Text = "TOTAL:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(816, 566)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(94, 13)
            Me.Label11.TabIndex = 192
            Me.Label11.Text = "CANT. CLIENTES:"
            '
            'txtObservacion
            '
            Me.txtObservacion.BackColor = System.Drawing.Color.White
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.Enabled = False
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(290, 563)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(507, 21)
            Me.txtObservacion.TabIndex = 191
            Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(201, 567)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(85, 13)
            Me.Label10.TabIndex = 190
            Me.Label10.Text = "OBSERVACIÓN:"
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.White
            Me.btnAdd.Enabled = False
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAdd.ForeColor = System.Drawing.Color.Black
            Me.btnAdd.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAdd.Location = New System.Drawing.Point(1093, 181)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(41, 30)
            Me.btnAdd.TabIndex = 189
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.White
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRemove.ForeColor = System.Drawing.Color.Black
            Me.btnRemove.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnRemove.Location = New System.Drawing.Point(1135, 182)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(41, 30)
            Me.btnRemove.TabIndex = 188
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'Label9
            '
            Me.Label9.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 180)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(1080, 23)
            Me.Label9.TabIndex = 187
            Me.Label9.Text = "DETALLE DE LA ORDEN"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgvHoy)
            Me.GroupBox2.Controls.Add(Me.dtpFiltroDesde)
            Me.GroupBox2.Location = New System.Drawing.Point(744, 6)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(433, 173)
            Me.GroupBox2.TabIndex = 186
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "VER TRANSACCIONES RECIENTES DESDE:"
            '
            'dgvHoy
            '
            Me.dgvHoy.AllowUserToAddRows = False
            Me.dgvHoy.AllowUserToDeleteRows = False
            Me.dgvHoy.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvHoy.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvHoy.BackgroundColor = System.Drawing.Color.White
            Me.dgvHoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvHoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvHoy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvHoy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column11, Me.DataGridViewTextBoxColumn4})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHoy.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvHoy.EnableHeadersVisualStyles = False
            Me.dgvHoy.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvHoy.Location = New System.Drawing.Point(6, 28)
            Me.dgvHoy.MultiSelect = False
            Me.dgvHoy.Name = "dgvHoy"
            Me.dgvHoy.ReadOnly = True
            Me.dgvHoy.RowHeadersVisible = False
            Me.dgvHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHoy.Size = New System.Drawing.Size(421, 138)
            Me.dgvHoy.TabIndex = 186
            '
            'DataGridViewTextBoxColumn1
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
            Me.DataGridViewTextBoxColumn1.HeaderText = "N° Comp."
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Width = 90
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            Me.DataGridViewTextBoxColumn2.Width = 150
            '
            'Column11
            '
            Me.Column11.HeaderText = "Cant"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Width = 60
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            '
            'dtpFiltroDesde
            '
            Me.dtpFiltroDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFiltroDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFiltroDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFiltroDesde.Location = New System.Drawing.Point(247, 0)
            Me.dtpFiltroDesde.Name = "dtpFiltroDesde"
            Me.dtpFiltroDesde.Size = New System.Drawing.Size(180, 22)
            Me.dtpFiltroDesde.TabIndex = 183
            '
            'dgvDebitos
            '
            Me.dgvDebitos.AllowUserToAddRows = False
            Me.dgvDebitos.AllowUserToDeleteRows = False
            Me.dgvDebitos.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDebitos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDebitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvDebitos.BackgroundColor = System.Drawing.Color.White
            Me.dgvDebitos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDebitos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvDebitos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDebitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.IdCliente, Me.Cliente, Me.TipDoc, Me.CiRuc, Me.Ordenante, Me.Contrato, Me.FormaPago, Me.Banco, Me.TipoCuenta, Me.NumCuenta, Me.Valor, Me.Motivo, Me.IdDetalle, Me.FecProceso, Me.IdFactura, Me.NumFactura})
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDebitos.DefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDebitos.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvDebitos.Location = New System.Drawing.Point(6, 215)
            Me.dgvDebitos.MultiSelect = False
            Me.dgvDebitos.Name = "dgvDebitos"
            Me.dgvDebitos.ReadOnly = True
            Me.dgvDebitos.RowHeadersVisible = False
            Me.dgvDebitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDebitos.Size = New System.Drawing.Size(1173, 342)
            Me.dgvDebitos.TabIndex = 185
            '
            'Column12
            '
            Me.Column12.Frozen = True
            Me.Column12.HeaderText = "Debito"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.Visible = False
            Me.Column12.Width = 60
            '
            'IdCliente
            '
            Me.IdCliente.Frozen = True
            Me.IdCliente.HeaderText = "ID"
            Me.IdCliente.Name = "IdCliente"
            Me.IdCliente.ReadOnly = True
            Me.IdCliente.Width = 50
            '
            'Cliente
            '
            Me.Cliente.Frozen = True
            Me.Cliente.HeaderText = "Cliente"
            Me.Cliente.Name = "Cliente"
            Me.Cliente.ReadOnly = True
            Me.Cliente.Width = 200
            '
            'TipDoc
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.TipDoc.DefaultCellStyle = DataGridViewCellStyle7
            Me.TipDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.TipDoc.HeaderText = "Tipo Doc."
            Me.TipDoc.Items.AddRange(New Object() {"C CÉDULA", "R RUC", "P PASAPORTE", "X NINGUNO"})
            Me.TipDoc.Name = "TipDoc"
            Me.TipDoc.ReadOnly = True
            Me.TipDoc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TipDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.TipDoc.Width = 90
            '
            'CiRuc
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.CiRuc.DefaultCellStyle = DataGridViewCellStyle8
            Me.CiRuc.HeaderText = "CI / RUC"
            Me.CiRuc.Name = "CiRuc"
            Me.CiRuc.ReadOnly = True
            Me.CiRuc.Width = 90
            '
            'Ordenante
            '
            Me.Ordenante.HeaderText = "Ordenante"
            Me.Ordenante.Name = "Ordenante"
            Me.Ordenante.ReadOnly = True
            Me.Ordenante.Width = 230
            '
            'Contrato
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Contrato.DefaultCellStyle = DataGridViewCellStyle9
            Me.Contrato.HeaderText = "Contrato"
            Me.Contrato.Name = "Contrato"
            Me.Contrato.ReadOnly = True
            '
            'FormaPago
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.FormaPago.DefaultCellStyle = DataGridViewCellStyle10
            Me.FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.FormaPago.HeaderText = "Forma Pg/Cb"
            Me.FormaPago.Items.AddRange(New Object() {"CU CUENTA PROPIA", "TJ TARJETA DE CRÉDITO", "CO COBRO O PAGOS INTERBANCARIOS"})
            Me.FormaPago.Name = "FormaPago"
            Me.FormaPago.ReadOnly = True
            Me.FormaPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.FormaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'Banco
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Banco.DefaultCellStyle = DataGridViewCellStyle11
            Me.Banco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Banco.HeaderText = "Banco"
            Me.Banco.Items.AddRange(New Object() {"002 BANECUADOR", "003 T/C MASTER PACIFICARD", "004 T/C AMERICAN EXPRESS BCO GUAYAQUIL", "005 T/C VISA - Guayaquil", "006 T/C DINERS CLUB", "007 T/C VISA - PICHINCHA", "008 T/C MASTER-Pichincha", "009 T/C VISA - BOLIVARIANO", "010 BANCO PICHINCHA", "012 T/C VISA CORPORATIVA-BANCO BOLIVARIA", "013 T/C MASTER-Produbanco", "014 T/C VISA - Machala", "015 T/C VISA COMERCIAL DE MANABI", "016 T/C VISA - Banco Internacional", "017 BANCO DE GUAYAQUIL", "018 T/C VISA - Austro", "021 T/C MASTER-Austro", "022 T/C VISA - Amazonas", "024 BANCO CITYBANK", "025 BANCO DE MACHALA", "027 T/C MASTER-Mut. Pichincha", "029 BANCO LOJA", "030 BANCO DEL PACIFICO", "031 BANCO DELBANK", "032 BANCO INTERNACIONAL", "033 COOP. JUV. ECUA PROGRESISTA LTDA.", "034 BANCO AMAZONAS", "035 BANCO DEL AUSTRO", "036 BANCO DE LA PRODUCCION", "037 BANCO BOLIVARIANO", "038 T/C Master-BANCO Internacional", "039 BANCO COMERCIAL DE MANABI", "041 T/C UniBanco CuotaFacil", "042 BANCO GENERAL RUMINAHUI", "043 BANCO DEL LITORAL", "044 CORFINSA S.A.", "045 BANCO SUDAMERICANO", "046 COOP.AHO.CREDITO ALIANZA DEL VALLE LTDA", "047 COOP.CONST.COMERCIO Y PRODUCCION LTDA", "048 FINANCIERA FINANCOOPERATIVA", "050 BANCO COFIEC", "051 BANCO CENTRO MUNDO", "053 PACIFICO BANANEROS", "059 BANCO SOLIDARIO", "060 BANCO ECUATORIANO DE LA VIVIENDA", "061 MUTUALISTA PICHINCHA", "062 MUTUALISTA BENALCAZAR", "063 FINANCIERA DINERS CLUB ECUADOR", "064 COOP. PREVISIION AHORRO Y DESARROLLO", "065 COOP.AHO.CREDITO ANDALUCIA", "066 COOP.AHO.CREDITO DE LA PEQUENA EMP. PASTAZA", "067 COOP.AHO.CREDITO PROGRESO", "068 COOP.AHO.CREDITO 29 DE OCTUBRE", "069 COOP.AHO.CREDITO COTOCALLAO", "071 COOP.AHO.CREDITO DESARROLLO PUEBLOS", "072 COOP.AHO.CREDITO 23 DE JULIO", "073 COOP.AHO.CREDITO NACIONAL", "074 COOP.AHO.CREDITO UNIDAD FAMILIAR", "075 COOP.AHO.CREDITO LA DOLOROSA LTDA", "076 MASTER DEL ECUADOR", "077 MUTUALISTA AZUAY", "078 COOP.AHO.CREDITO OSCUS", "079 MUTUALISTA AMBATO", "080 COOP.AHO.CREDITO EL SAGRARIO", "081 COOP.AHO.CREDITO SAN FRANCISCO", "082 COOP.AHO.CREDITO GUARANDA LTDA", "083 MUTUALISTA IMBABURA", "084 COOP.AHO.CREDITO ATUNTAQUI LTDA", "085 CAPECO LTDA", "086 COOP.AHO.CREDITO COMERCIO PORTOVIEJO", "087 COOP.AHO.CREDITO RIOBAMBA", "088 COOP.AHO.CREDITO PABLO M. VEGA", "089 COOP.AHO.CREDITO TULCAN", "090 MASTER PRIMA BANCO GUAYAQUIL", "091 COOP.AHO.CREDITO SANTA ROSA", "092 MASTERCARD BANCO BOLIVARIANO", "094 COOP.AHO.CREDITO JARDIN AZUAYO", "095 BANCO PROCREDIT", "096 COOP.AHO.CREDITO ONCE DE JUNIO", "097 CACPE BIBLIAN LTDA", "099 BCE-DINERO ELECTRONICO", "111 COOP. DE AHORRO Y CREDITO LA BENEFICA LTDA", "115 COOPERATIVA DE AHORRO Y CRÉDITO 14 DE MAYO", "116 COOPERATIVA DE AHORRO Y CRÉDITO BANCO CENTRAL DEL ECUADOR", "117 COOP. DE A. Y C. LUCHA CAMPESINA LTDA.", "296 COOP DE AHORRO Y CREDITIO DAQUILEMA", "982 COOP AHO Y CREDITO CACPECO LTDA", "01A BANCO CAPITAL", "01B COOP.AHO.CREDITO CHONE", "01C COOP.AHO.CREDITO SAN PEDRO DE TABOADA", "01D COOP.AHO.CREDITO SANTA ANA", "01E COOP.AHO.CREDITO 15 DE ABRIL", "01G COOP.AHO.CREDITO CAMARA COMERCIO DE AMBATO", "01H COOP.AHO.CREDITO CACPE DE LA PEQUENA LOJA", "01I COOP.AHO.CREDITO SAN JUAN DE SALINAS LTDA", "01J COOP.AHO.CREDITO PUELLARO LTDA.", "01K COOP.AHO.CREDITO NUEVA JERUSALEN", "01L COOP.AHO.CREDITO MALCHINGUI LTDA.", "01M COOP.AHO.CREDITO AMAZONAS LTDA.", "01N COOP.AHO.CREDITO AGRARIA MUSHUK KAWSAY LTDA", "01O COOP.AHO.CREDITO DE LA PEQUEÑA EMPRESA GUALAQUIZA", "01P COOP.AHO.CREDITO MI TIERRA", "01Q COOP.AHO.CREDITO MI TIERRA", "01R COOP.AHO.CREDITO PEDRO MONCAYO LTDA.", "01T COOP.AHO.CREDITO POLICIA NACIONAL LTDA.", "01U COOP.AHO.CREDITO NUEVA HUANCAVILCA LTDA.", "01V COOP.AHO.CREDITO ALFONSO JARAMILLO C.C.C", "01W COOP.AHO.CREDITO LA MERCED LTDA.", "01X COOP.AHO.CREDITO PROVIDA", "01Z COOP.AHO.CREDITO DE AHORRO Y CRÉDITO SAN JOSE S.J.", "02A COOP.AHO.CREDITO COOPERATIVA AC AUSTRO LTDA", "02B COOP.AHO.CREDITO SEÑOR DE GIRON", "02C COOP.AHO.CREDITO FAMILIA AUSTRAL", "02D COOP.AHO.CREDITO ERCO LTDA.", "02E COOP.AHO.CREDITO MUSHUC RUNA LTDA.", "02F COOP.AHO.CREDITO EDUC. DEL TUNGURAHUA LTDA.", "02G COOP.AHO.CREDITO AMBATO LTDA.", "02H COOP.AHO.CREDITO TUNGURAHUA LTDA.", "02I COOP.AHO.CREDITO LLANGANATES", "02J COOP.AHO.CREDITO ARTESANOS LTDA.", "02K COOP.AHO.CREDITO SANTA ANITA LTDA.", "02L COOP.AHO.CREDITO MUJERES UNIDAS TANTANAKUSHKA WARMIKUNAPAK CACMU LTDA.", "02M COOP.AHO.CREDITO SAN ANTONIO LTDA.", "02N COOP.AHO.CREDITO HUAYCO PUNGO LTDA.", "02O COOP.AHO.CREDITO ANDINA LTDA.", "02P COOP.AHO.CREDITO 15 DE AGOSTO PILACOTO", "02Q COOP.AHO.CREDITO CRISTO REY", "02R COOP.AHO.CREDITO SEMILLA DEL PROGRESO LTDA.", "02S COOP.AHO.CREDITO ACCIÓN RURAL", "02T COOP.AHO.CREDITO ACCION Y DESARROLLO LTDA", "02U COOP.AHO.CREDITO EDUCADORES DE CHIMBORAZO", "02V COOP.AHO.CREDITO MINGA LTDA.", "02W COOP.AHO.CREDITO 4 DE OCTUBRE LTDA.", "02X COOP.AHO.CREDITO CAMARA COMERCIO INDIGENA DE GUAMOTE LTDA", "02Y COOP.AHO.CREDITO SAN GABRIEL LTDA.", "02Z COOP. MEGO", "03A COOP. PADRE JULIAN LORENTE LTDA.", "03B COOP.AHO.CREDITO SAN JOSE S.J.", "03C COOP.AHO.CREDITO BAÑOS LTDA.", "03D COOP.AHO.CREDITO JUAN PIO DE MORA LTDA.", "03E COOP.AHO.CREDITO CREDIAMIGO LTDA. LOJA", "03F COOP.AHO.CREDITO 11 DE JUNIO", "03G COOP.AHO.CREDITO FUTURO Y PROGRESO DE GALAPAGOS LTDA.", "03H COOP.AHO.CREDITO CREA LTDA", "03I COOP.AHO.CREDITO 23 DE JULIO", "04A COOP.AHO.CREDITO FORTUNA", "04B COOP.AHO.CREDITO CACPE CELICA", "04C BIESS", "04D COOP.AHO.CREDITO MARCABELI LTDA", "04E COOP.AHO.CREDITO FORTUNA", "04F COOP.AHO.CREDITO DE LOS SERV.PUBL.DEL MIN.EDUCACION", "04G COOP.AHO.CREDITO SANTA ROSA DE PATUTAN LTDA.", "04H BANCO-D-MIRO S.A.", "04I  BANCO FINCA", "04J COOP.AHO.CREDITO CHIBULEO LTDA.", "04k COOP.AHO.CREDITO SAN SEBASTIAN", "04L COOP.AHO.CREDITO GONZANAMA", "04M COOP.AHO.CREDITO SERVIDORES MUNICIPALES DE CUENCA", "04N CORPORACION FINANCIERA", "04O COOP.AHO.CREDITO MANANTIAL DE ORO LTDA", "04P COOP.AHO.CREDITO TENA LTDA", "04Q COOP.AHO.CREDITO ALIANZA MINAS LTDA", "04R COOP.AHO.CREDITO DESARROLLO INTEGRAL LTDA", "04S COOP.AHO.CREDITO EDUCADORES DE PASTAZA LTDA", "04V COOP.AHO.CREDITO COCA LTDA", "04W COOP.AHO.CREDITO 23 DE MAYO LTDA"})
            Me.Banco.Name = "Banco"
            Me.Banco.ReadOnly = True
            Me.Banco.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Banco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'TipoCuenta
            '
            Me.TipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.TipoCuenta.HeaderText = "Tipo Cta"
            Me.TipoCuenta.Items.AddRange(New Object() {"10  AHORRO", "00  CORRIENTE", "00  TARJETA DE CREDITO"})
            Me.TipoCuenta.Name = "TipoCuenta"
            Me.TipoCuenta.ReadOnly = True
            Me.TipoCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.TipoCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'NumCuenta
            '
            Me.NumCuenta.HeaderText = "N° Cta"
            Me.NumCuenta.Name = "NumCuenta"
            Me.NumCuenta.ReadOnly = True
            '
            'Valor
            '
            Me.Valor.HeaderText = "Valor"
            Me.Valor.Name = "Valor"
            Me.Valor.ReadOnly = True
            Me.Valor.Width = 90
            '
            'Motivo
            '
            Me.Motivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Motivo.HeaderText = "Motivo"
            Me.Motivo.Items.AddRange(New Object() {"RPA ROLES DE PAGO", "VIA PAGOS POR CONCEPTO DE VIATICOS", "TRA PAGO POR CONCEPTO DE TRANSPORTE", "COM PAGO POR CONCEPTO DE COMISIONES", "PG PAGOS DEL GOBIERNO NACIONAL"})
            Me.Motivo.Name = "Motivo"
            Me.Motivo.ReadOnly = True
            Me.Motivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Motivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.Motivo.Width = 150
            '
            'IdDetalle
            '
            Me.IdDetalle.HeaderText = "IdDetalle"
            Me.IdDetalle.Name = "IdDetalle"
            Me.IdDetalle.ReadOnly = True
            Me.IdDetalle.Visible = False
            Me.IdDetalle.Width = 50
            '
            'FecProceso
            '
            Me.FecProceso.HeaderText = "Fec. Procesado"
            Me.FecProceso.Name = "FecProceso"
            Me.FecProceso.ReadOnly = True
            Me.FecProceso.Visible = False
            Me.FecProceso.Width = 110
            '
            'IdFactura
            '
            Me.IdFactura.HeaderText = "Id Factura"
            Me.IdFactura.Name = "IdFactura"
            Me.IdFactura.ReadOnly = True
            Me.IdFactura.Visible = False
            Me.IdFactura.Width = 80
            '
            'NumFactura
            '
            Me.NumFactura.HeaderText = "N° Factura"
            Me.NumFactura.Name = "NumFactura"
            Me.NumFactura.ReadOnly = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblComprobante)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.cbxTipoNegociacion)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtReferencia)
            Me.GroupBox1.Controls.Add(Me.txtNumCuenta)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.cbxTipoCuenta)
            Me.GroupBox1.Controls.Add(Me.lblCiudad)
            Me.GroupBox1.Controls.Add(Me.dtpFechaVence)
            Me.GroupBox1.Controls.Add(Me.dtpFechaProceso)
            Me.GroupBox1.Controls.Add(Me.txtTipoServicio)
            Me.GroupBox1.Controls.Add(Me.txtBeneficiario)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(731, 173)
            Me.GroupBox1.TabIndex = 184
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "ÓRDENES COBROS / PAGOS"
            '
            'lblComprobante
            '
            Me.lblComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblComprobante.ForeColor = System.Drawing.Color.Black
            Me.lblComprobante.Location = New System.Drawing.Point(7, 44)
            Me.lblComprobante.Name = "lblComprobante"
            Me.lblComprobante.Size = New System.Drawing.Size(101, 18)
            Me.lblComprobante.TabIndex = 153
            Me.lblComprobante.Text = "S/N"
            Me.lblComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(4, 26)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(104, 17)
            Me.Label8.TabIndex = 152
            Me.Label8.Text = "COMPROBANTE"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'cbxTipoNegociacion
            '
            Me.cbxTipoNegociacion.BackColor = System.Drawing.Color.White
            Me.cbxTipoNegociacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoNegociacion.Enabled = False
            Me.cbxTipoNegociacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbxTipoNegociacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipoNegociacion.ForeColor = System.Drawing.Color.Black
            Me.cbxTipoNegociacion.FormattingEnabled = True
            Me.cbxTipoNegociacion.Items.AddRange(New Object() {"S - SERVICIOS", "B - BIENES"})
            Me.cbxTipoNegociacion.Location = New System.Drawing.Point(394, 145)
            Me.cbxTipoNegociacion.Name = "cbxTipoNegociacion"
            Me.cbxTipoNegociacion.Size = New System.Drawing.Size(330, 21)
            Me.cbxTipoNegociacion.TabIndex = 65
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(391, 129)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(111, 13)
            Me.Label7.TabIndex = 64
            Me.Label7.Text = "TIPO NEGOCIACIÓN:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(21, 130)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 13)
            Me.Label6.TabIndex = 62
            Me.Label6.Text = "REFERENCIA:"
            '
            'txtReferencia
            '
            Me.txtReferencia.BackColor = System.Drawing.Color.White
            Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia.Enabled = False
            Me.txtReferencia.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtReferencia.Location = New System.Drawing.Point(24, 146)
            Me.txtReferencia.Name = "txtReferencia"
            Me.txtReferencia.Size = New System.Drawing.Size(344, 21)
            Me.txtReferencia.TabIndex = 61
            Me.txtReferencia.Text = "SERVICIO DE COBROS"
            Me.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtNumCuenta
            '
            Me.txtNumCuenta.BackColor = System.Drawing.Color.White
            Me.txtNumCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumCuenta.Enabled = False
            Me.txtNumCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumCuenta.Location = New System.Drawing.Point(467, 96)
            Me.txtNumCuenta.Name = "txtNumCuenta"
            Me.txtNumCuenta.Size = New System.Drawing.Size(257, 21)
            Me.txtNumCuenta.TabIndex = 60
            Me.txtNumCuenta.Text = "1010588398"
            Me.txtNumCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(391, 99)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(67, 13)
            Me.Label5.TabIndex = 59
            Me.Label5.Text = "N° CUENTA:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(21, 100)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(80, 13)
            Me.Label4.TabIndex = 58
            Me.Label4.Text = "TIPO CUENTA:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(391, 26)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(102, 13)
            Me.Label3.TabIndex = 57
            Me.Label3.Text = "TIPO DE SERVICIO:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(391, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(69, 13)
            Me.Label2.TabIndex = 56
            Me.Label2.Text = "FEC. VENCE:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(21, 73)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(85, 13)
            Me.Label1.TabIndex = 55
            Me.Label1.Text = "FEC. PROCESO:"
            '
            'cbxTipoCuenta
            '
            Me.cbxTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoCuenta.Enabled = False
            Me.cbxTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbxTipoCuenta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipoCuenta.ForeColor = System.Drawing.Color.Black
            Me.cbxTipoCuenta.FormattingEnabled = True
            Me.cbxTipoCuenta.Items.AddRange(New Object() {"03 - CORRIENTE", "04 - AHORRO"})
            Me.cbxTipoCuenta.Location = New System.Drawing.Point(111, 97)
            Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
            Me.cbxTipoCuenta.Size = New System.Drawing.Size(257, 21)
            Me.cbxTipoCuenta.TabIndex = 53
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudad.Location = New System.Drawing.Point(108, 27)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(81, 13)
            Me.lblCiudad.TabIndex = 54
            Me.lblCiudad.Text = "BENEFICIARIO:"
            '
            'dtpFechaVence
            '
            Me.dtpFechaVence.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaVence.Enabled = False
            Me.dtpFechaVence.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaVence.Location = New System.Drawing.Point(467, 68)
            Me.dtpFechaVence.Name = "dtpFechaVence"
            Me.dtpFechaVence.Size = New System.Drawing.Size(257, 21)
            Me.dtpFechaVence.TabIndex = 37
            '
            'dtpFechaProceso
            '
            Me.dtpFechaProceso.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaProceso.Enabled = False
            Me.dtpFechaProceso.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaProceso.Location = New System.Drawing.Point(111, 69)
            Me.dtpFechaProceso.Name = "dtpFechaProceso"
            Me.dtpFechaProceso.Size = New System.Drawing.Size(257, 21)
            Me.dtpFechaProceso.TabIndex = 35
            '
            'txtTipoServicio
            '
            Me.txtTipoServicio.BackColor = System.Drawing.Color.White
            Me.txtTipoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoServicio.Enabled = False
            Me.txtTipoServicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoServicio.Location = New System.Drawing.Point(394, 42)
            Me.txtTipoServicio.Name = "txtTipoServicio"
            Me.txtTipoServicio.Size = New System.Drawing.Size(330, 21)
            Me.txtTipoServicio.TabIndex = 33
            Me.txtTipoServicio.Text = "CI (SERVICIO CONTRATADO)"
            Me.txtTipoServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtBeneficiario
            '
            Me.txtBeneficiario.BackColor = System.Drawing.Color.White
            Me.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBeneficiario.Enabled = False
            Me.txtBeneficiario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBeneficiario.Location = New System.Drawing.Point(111, 43)
            Me.txtBeneficiario.Name = "txtBeneficiario"
            Me.txtBeneficiario.Size = New System.Drawing.Size(257, 21)
            Me.txtBeneficiario.TabIndex = 31
            Me.txtBeneficiario.Text = "CISEPRO CÍA. LTDA."
            Me.txtBeneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'tpReporteBodega
            '
            Me.tpReporteBodega.Controls.Add(Me.gbDetalleComprobante)
            Me.tpReporteBodega.Controls.Add(Me.gbComprobante)
            Me.tpReporteBodega.Controls.Add(Me.gbNumeroFactura)
            Me.tpReporteBodega.Controls.Add(Me.gbRangoFechas)
            Me.tpReporteBodega.Location = New System.Drawing.Point(4, 22)
            Me.tpReporteBodega.Name = "tpReporteBodega"
            Me.tpReporteBodega.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporteBodega.Size = New System.Drawing.Size(1185, 592)
            Me.tpReporteBodega.TabIndex = 1
            Me.tpReporteBodega.Text = "ORDENES GENERADAS"
            Me.tpReporteBodega.UseVisualStyleBackColor = True
            '
            'gbDetalleComprobante
            '
            Me.gbDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.gbDetalleComprobante.Controls.Add(Me.btnExportarDetalleComprobante)
            Me.gbDetalleComprobante.Controls.Add(Me.dgvDetalleComprobate)
            Me.gbDetalleComprobante.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDetalleComprobante.Location = New System.Drawing.Point(5, 303)
            Me.gbDetalleComprobante.Name = "gbDetalleComprobante"
            Me.gbDetalleComprobante.Size = New System.Drawing.Size(1174, 277)
            Me.gbDetalleComprobante.TabIndex = 153
            Me.gbDetalleComprobante.TabStop = False
            Me.gbDetalleComprobante.Text = "DETALLE"
            '
            'btnExportarDetalleComprobante
            '
            Me.btnExportarDetalleComprobante.BackColor = System.Drawing.Color.White
            Me.btnExportarDetalleComprobante.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarDetalleComprobante.Image = CType(resources.GetObject("btnExportarDetalleComprobante.Image"), System.Drawing.Image)
            Me.btnExportarDetalleComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportarDetalleComprobante.Location = New System.Drawing.Point(1044, 9)
            Me.btnExportarDetalleComprobante.Name = "btnExportarDetalleComprobante"
            Me.btnExportarDetalleComprobante.Size = New System.Drawing.Size(129, 26)
            Me.btnExportarDetalleComprobante.TabIndex = 153
            Me.btnExportarDetalleComprobante.Text = "EXPORTAR"
            Me.btnExportarDetalleComprobante.UseVisualStyleBackColor = False
            '
            'dgvDetalleComprobate
            '
            Me.dgvDetalleComprobate.AllowUserToAddRows = False
            Me.dgvDetalleComprobate.AllowUserToDeleteRows = False
            Me.dgvDetalleComprobate.AllowUserToResizeRows = False
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleComprobate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvDetalleComprobate.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleComprobate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvDetalleComprobate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvDetalleComprobate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetalleComprobate.DefaultCellStyle = DataGridViewCellStyle15
            Me.dgvDetalleComprobate.GridColor = System.Drawing.Color.Black
            Me.dgvDetalleComprobate.Location = New System.Drawing.Point(5, 35)
            Me.dgvDetalleComprobate.MultiSelect = False
            Me.dgvDetalleComprobate.Name = "dgvDetalleComprobate"
            Me.dgvDetalleComprobate.ReadOnly = True
            Me.dgvDetalleComprobate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvDetalleComprobate.RowHeadersVisible = False
            Me.dgvDetalleComprobate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleComprobate.Size = New System.Drawing.Size(1166, 236)
            Me.dgvDetalleComprobate.TabIndex = 146
            '
            'gbComprobante
            '
            Me.gbComprobante.BackColor = System.Drawing.Color.White
            Me.gbComprobante.Controls.Add(Me.btnExportarComprobantes)
            Me.gbComprobante.Controls.Add(Me.dgvComprobantesIngreso)
            Me.gbComprobante.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComprobante.Location = New System.Drawing.Point(7, 60)
            Me.gbComprobante.Name = "gbComprobante"
            Me.gbComprobante.Size = New System.Drawing.Size(1172, 237)
            Me.gbComprobante.TabIndex = 152
            Me.gbComprobante.TabStop = False
            Me.gbComprobante.Text = "COMPROBANTE"
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.White
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = CType(resources.GetObject("btnExportarComprobantes.Image"), System.Drawing.Image)
            Me.btnExportarComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(1041, 8)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(130, 26)
            Me.btnExportarComprobantes.TabIndex = 57
            Me.btnExportarComprobantes.Text = "EXPORTAR"
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
            '
            'dgvComprobantesIngreso
            '
            Me.dgvComprobantesIngreso.AllowUserToAddRows = False
            Me.dgvComprobantesIngreso.AllowUserToDeleteRows = False
            Me.dgvComprobantesIngreso.AllowUserToResizeRows = False
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobantesIngreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobantesIngreso.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobantesIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
            Me.dgvComprobantesIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobantesIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvComprobantesIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobantesIngreso.DefaultCellStyle = DataGridViewCellStyle18
            Me.dgvComprobantesIngreso.GridColor = System.Drawing.Color.Black
            Me.dgvComprobantesIngreso.Location = New System.Drawing.Point(3, 35)
            Me.dgvComprobantesIngreso.MultiSelect = False
            Me.dgvComprobantesIngreso.Name = "dgvComprobantesIngreso"
            Me.dgvComprobantesIngreso.ReadOnly = True
            Me.dgvComprobantesIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            Me.dgvComprobantesIngreso.RowHeadersVisible = False
            Me.dgvComprobantesIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobantesIngreso.Size = New System.Drawing.Size(1167, 196)
            Me.dgvComprobantesIngreso.TabIndex = 145
            '
            'gbNumeroFactura
            '
            Me.gbNumeroFactura.BackColor = System.Drawing.Color.White
            Me.gbNumeroFactura.Controls.Add(Me.chkTodos)
            Me.gbNumeroFactura.Controls.Add(Me.rbtDet)
            Me.gbNumeroFactura.Controls.Add(Me.rbtNum)
            Me.gbNumeroFactura.Controls.Add(Me.txtDetail)
            Me.gbNumeroFactura.Controls.Add(Me.btnBuscar)
            Me.gbNumeroFactura.Controls.Add(Me.txtNroComprobante)
            Me.gbNumeroFactura.Location = New System.Drawing.Point(471, 7)
            Me.gbNumeroFactura.Name = "gbNumeroFactura"
            Me.gbNumeroFactura.Size = New System.Drawing.Size(708, 47)
            Me.gbNumeroFactura.TabIndex = 149
            Me.gbNumeroFactura.TabStop = False
            Me.gbNumeroFactura.Text = "OPCIONES DE BUSQUEDA"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Checked = True
            Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkTodos.Location = New System.Drawing.Point(161, 0)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(56, 17)
            Me.chkTodos.TabIndex = 8
            Me.chkTodos.Text = "Todos"
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'rbtDet
            '
            Me.rbtDet.AutoSize = True
            Me.rbtDet.Enabled = False
            Me.rbtDet.Location = New System.Drawing.Point(212, 19)
            Me.rbtDet.Name = "rbtDet"
            Me.rbtDet.Size = New System.Drawing.Size(63, 17)
            Me.rbtDet.TabIndex = 7
            Me.rbtDet.TabStop = True
            Me.rbtDet.Text = "Detalle:"
            Me.rbtDet.UseVisualStyleBackColor = True
            '
            'rbtNum
            '
            Me.rbtNum.AutoSize = True
            Me.rbtNum.Enabled = False
            Me.rbtNum.Location = New System.Drawing.Point(6, 19)
            Me.rbtNum.Name = "rbtNum"
            Me.rbtNum.Size = New System.Drawing.Size(72, 17)
            Me.rbtNum.TabIndex = 6
            Me.rbtNum.TabStop = True
            Me.rbtNum.Text = "N° Comp:"
            Me.rbtNum.UseVisualStyleBackColor = True
            '
            'txtDetail
            '
            Me.txtDetail.BackColor = System.Drawing.Color.White
            Me.txtDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetail.Enabled = False
            Me.txtDetail.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetail.Location = New System.Drawing.Point(291, 18)
            Me.txtDetail.Name = "txtDetail"
            Me.txtDetail.Size = New System.Drawing.Size(320, 20)
            Me.txtDetail.TabIndex = 5
            Me.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.White
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscar.Location = New System.Drawing.Point(616, 14)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(89, 26)
            Me.btnBuscar.TabIndex = 0
            Me.btnBuscar.Text = "BUSCAR"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'txtNroComprobante
            '
            Me.txtNroComprobante.BackColor = System.Drawing.Color.White
            Me.txtNroComprobante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroComprobante.Enabled = False
            Me.txtNroComprobante.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNroComprobante.Location = New System.Drawing.Point(85, 18)
            Me.txtNroComprobante.Name = "txtNroComprobante"
            Me.txtNroComprobante.Size = New System.Drawing.Size(105, 20)
            Me.txtNroComprobante.TabIndex = 0
            Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.Label13)
            Me.gbRangoFechas.Controls.Add(Me.Label14)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Location = New System.Drawing.Point(7, 6)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(458, 48)
            Me.gbRangoFechas.TabIndex = 147
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(7, 22)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(23, 13)
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "De:"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(228, 22)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(13, 13)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(246, 19)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(173, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(41, 19)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(173, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNuevo, Me.tsmGuardar, Me.tsmEditar, Me.tsmCancelar, Me.btnGenerarExcel})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(0, 0)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1194, 32)
            Me.msKardex.TabIndex = 184
            Me.msKardex.Text = "msIngresoBodega"
            '
            'tsmNuevo
            '
            Me.tsmNuevo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmNuevo.Name = "tsmNuevo"
            Me.tsmNuevo.Size = New System.Drawing.Size(78, 28)
            Me.tsmNuevo.Text = "NUEVO"
            '
            'tsmGuardar
            '
            Me.tsmGuardar.Enabled = False
            Me.tsmGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmGuardar.Name = "tsmGuardar"
            Me.tsmGuardar.Size = New System.Drawing.Size(92, 28)
            Me.tsmGuardar.Text = "GUARDAR"
            '
            'tsmEditar
            '
            Me.tsmEditar.Enabled = False
            Me.tsmEditar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmEditar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmEditar.Name = "tsmEditar"
            Me.tsmEditar.Size = New System.Drawing.Size(85, 28)
            Me.tsmEditar.Text = "EDITAR"
            '
            'tsmCancelar
            '
            Me.tsmCancelar.Enabled = False
            Me.tsmCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsmCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.tsmCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmCancelar.Name = "tsmCancelar"
            Me.tsmCancelar.Size = New System.Drawing.Size(99, 28)
            Me.tsmCancelar.Text = "CANCELAR"
            '
            'btnGenerarExcel
            '
            Me.btnGenerarExcel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerarExcel.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGenerarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGenerarExcel.Name = "btnGenerarExcel"
            Me.btnGenerarExcel.Size = New System.Drawing.Size(92, 28)
            Me.btnGenerarExcel.Text = "GENERAR"
            '
            'FrmGenerarDebitoBancarioClientes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1194, 653)
            Me.Controls.Add(Me.msKardex)
            Me.Controls.Add(Me.tcBodega)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmGenerarDebitoBancarioClientes"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "GENERAR DÉBITO BANCARIO A CLIENTES"
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.tcBodega.ResumeLayout(False)
            Me.tpMantenimiento.ResumeLayout(False)
            Me.tpMantenimiento.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvHoy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.tpReporteBodega.ResumeLayout(False)
            Me.gbDetalleComprobante.ResumeLayout(False)
            CType(Me.dgvDetalleComprobate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbComprobante.ResumeLayout(False)
            CType(Me.dgvComprobantesIngreso, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNumeroFactura.ResumeLayout(False)
            Me.gbNumeroFactura.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents miniToolStrip As System.Windows.Forms.MenuStrip
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents tcBodega As System.Windows.Forms.TabControl
        Friend WithEvents tpMantenimiento As System.Windows.Forms.TabPage
        Friend WithEvents tpReporteBodega As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbxTipoNegociacion As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
        Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbxTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents dtpFechaVence As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaProceso As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtTipoServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
        Friend WithEvents lblComprobante As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dgvDebitos As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents dgvHoy As System.Windows.Forms.DataGridView
        Friend WithEvents btnRemove As System.Windows.Forms.Button
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents dtpFiltroDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblCant As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbNumeroFactura As System.Windows.Forms.GroupBox
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents rbtDet As System.Windows.Forms.RadioButton
        Friend WithEvents rbtNum As System.Windows.Forms.RadioButton
        Friend WithEvents txtDetail As System.Windows.Forms.TextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
        Friend WithEvents gbComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents dgvComprobantesIngreso As System.Windows.Forms.DataGridView
        Friend WithEvents gbDetalleComprobante As System.Windows.Forms.GroupBox
        Friend WithEvents btnExportarDetalleComprobante As System.Windows.Forms.Button
        Friend WithEvents dgvDetalleComprobate As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tsmCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGenerarExcel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents IdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents TipDoc As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents CiRuc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Ordenante As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Contrato As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FormaPago As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents Banco As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents TipoCuenta As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents NumCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Motivo As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents IdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FecProceso As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents IdFactura As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NumFactura As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tsmEditar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace