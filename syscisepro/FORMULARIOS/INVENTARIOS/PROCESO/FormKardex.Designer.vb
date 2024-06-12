Namespace FORMULARIOS.INVENTARIOS.PROCESO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormKardex
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKardex))
            Me.tcKardex = New System.Windows.Forms.TabControl()
            Me.tpCreacion = New System.Windows.Forms.TabPage()
            Me.btnllamar = New System.Windows.Forms.Button()
            Me.btnExportarComprobantes = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.txtBodega = New System.Windows.Forms.TextBox()
            Me.txtCentroCosto = New System.Windows.Forms.TextBox()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.lblRazon = New System.Windows.Forms.Label()
            Me.txtRazón = New System.Windows.Forms.TextBox()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.txtCódigo = New System.Windows.Forms.TextBox()
            Me.lblCentroCosto = New System.Windows.Forms.Label()
            Me.lblConcepto = New System.Windows.Forms.Label()
            Me.lblBodega = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtBuscarKardex = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dgvDetalleKardex = New System.Windows.Forms.DataGridView()
            Me.msKardex = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.dgvKardex = New System.Windows.Forms.DataGridView()
            Me.tpReporte = New System.Windows.Forms.TabPage()
            Me.crvKardex = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.ttPublico = New System.Windows.Forms.ToolTip(Me.components)
            Me.tcKardex.SuspendLayout()
            Me.tpCreacion.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvDetalleKardex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.msKardex.SuspendLayout()
            CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpReporte.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcKardex
            '
            Me.tcKardex.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.tcKardex.Controls.Add(Me.tpCreacion)
            Me.tcKardex.Controls.Add(Me.tpReporte)
            Me.tcKardex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcKardex.Location = New System.Drawing.Point(1, 0)
            Me.tcKardex.Name = "tcKardex"
            Me.tcKardex.SelectedIndex = 0
            Me.tcKardex.Size = New System.Drawing.Size(1271, 638)
            Me.tcKardex.TabIndex = 0
            '
            'tpCreacion
            '
            Me.tpCreacion.BackColor = System.Drawing.Color.White
            Me.tpCreacion.Controls.Add(Me.btnllamar)
            Me.tpCreacion.Controls.Add(Me.btnExportarComprobantes)
            Me.tpCreacion.Controls.Add(Me.GroupBox1)
            Me.tpCreacion.Controls.Add(Me.txtBuscarKardex)
            Me.tpCreacion.Controls.Add(Me.Label7)
            Me.tpCreacion.Controls.Add(Me.dgvDetalleKardex)
            Me.tpCreacion.Controls.Add(Me.msKardex)
            Me.tpCreacion.Controls.Add(Me.dgvKardex)
            Me.tpCreacion.Font = New System.Drawing.Font("Consolas", 8.25!)
            Me.tpCreacion.Location = New System.Drawing.Point(4, 22)
            Me.tpCreacion.Margin = New System.Windows.Forms.Padding(0)
            Me.tpCreacion.Name = "tpCreacion"
            Me.tpCreacion.Padding = New System.Windows.Forms.Padding(3)
            Me.tpCreacion.Size = New System.Drawing.Size(1263, 612)
            Me.tpCreacion.TabIndex = 0
            Me.tpCreacion.Text = "DETALLE DE ITEMS"
            '
            'btnllamar
            '
            Me.btnllamar.Location = New System.Drawing.Point(326, 8)
            Me.btnllamar.Name = "btnllamar"
            Me.btnllamar.Size = New System.Drawing.Size(75, 23)
            Me.btnllamar.TabIndex = 197
            Me.btnllamar.Text = "llamar"
            Me.btnllamar.UseVisualStyleBackColor = True
            '
            'btnExportarComprobantes
            '
            Me.btnExportarComprobantes.BackColor = System.Drawing.Color.White
            Me.btnExportarComprobantes.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportarComprobantes.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportarComprobantes.Location = New System.Drawing.Point(563, 37)
            Me.btnExportarComprobantes.Name = "btnExportarComprobantes"
            Me.btnExportarComprobantes.Size = New System.Drawing.Size(28, 28)
            Me.btnExportarComprobantes.TabIndex = 196
            Me.btnExportarComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportarComprobantes.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.TextBox1)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtConcepto)
            Me.GroupBox1.Controls.Add(Me.txtBodega)
            Me.GroupBox1.Controls.Add(Me.txtCentroCosto)
            Me.GroupBox1.Controls.Add(Me.txtActividad)
            Me.GroupBox1.Controls.Add(Me.lblRazon)
            Me.GroupBox1.Controls.Add(Me.txtRazón)
            Me.GroupBox1.Controls.Add(Me.txtCedula)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.txtCódigo)
            Me.GroupBox1.Controls.Add(Me.lblCentroCosto)
            Me.GroupBox1.Controls.Add(Me.lblConcepto)
            Me.GroupBox1.Controls.Add(Me.lblBodega)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.dtpFecha)
            Me.GroupBox1.Controls.Add(Me.lblActividad)
            Me.GroupBox1.Controls.Add(Me.txtNumero)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(654, 37)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(603, 266)
            Me.GroupBox1.TabIndex = 195
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos del comprobante"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(6, 161)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(134, 13)
            Me.Label4.TabIndex = 82
            Me.Label4.Text = "UBICACIÓN / DIRECCIÓN:"
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Enabled = False
            Me.TextBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox1.ForeColor = System.Drawing.Color.Black
            Me.TextBox1.Location = New System.Drawing.Point(5, 179)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(591, 40)
            Me.TextBox1.TabIndex = 81
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(511, 65)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(51, 13)
            Me.Label3.TabIndex = 80
            Me.Label3.Text = "CÓDIGO:"
            '
            'txtConcepto
            '
            Me.txtConcepto.BackColor = System.Drawing.Color.White
            Me.txtConcepto.Enabled = False
            Me.txtConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConcepto.Location = New System.Drawing.Point(316, 130)
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.Size = New System.Drawing.Size(281, 21)
            Me.txtConcepto.TabIndex = 79
            Me.txtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtBodega
            '
            Me.txtBodega.BackColor = System.Drawing.Color.White
            Me.txtBodega.Enabled = False
            Me.txtBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBodega.Location = New System.Drawing.Point(5, 81)
            Me.txtBodega.Name = "txtBodega"
            Me.txtBodega.Size = New System.Drawing.Size(300, 21)
            Me.txtBodega.TabIndex = 78
            Me.txtBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCentroCosto
            '
            Me.txtCentroCosto.BackColor = System.Drawing.Color.White
            Me.txtCentroCosto.Enabled = False
            Me.txtCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCentroCosto.Location = New System.Drawing.Point(316, 35)
            Me.txtCentroCosto.Name = "txtCentroCosto"
            Me.txtCentroCosto.Size = New System.Drawing.Size(281, 21)
            Me.txtCentroCosto.TabIndex = 77
            Me.txtCentroCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.Enabled = False
            Me.txtActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(190, 35)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(115, 21)
            Me.txtActividad.TabIndex = 76
            Me.txtActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblRazon
            '
            Me.lblRazon.AutoSize = True
            Me.lblRazon.BackColor = System.Drawing.Color.Transparent
            Me.lblRazon.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazon.Location = New System.Drawing.Point(3, 222)
            Me.lblRazon.Name = "lblRazon"
            Me.lblRazon.Size = New System.Drawing.Size(47, 13)
            Me.lblRazon.TabIndex = 75
            Me.lblRazon.Text = "RAZÓN:"
            '
            'txtRazón
            '
            Me.txtRazón.BackColor = System.Drawing.Color.White
            Me.txtRazón.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazón.Enabled = False
            Me.txtRazón.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazón.ForeColor = System.Drawing.Color.Black
            Me.txtRazón.Location = New System.Drawing.Point(6, 240)
            Me.txtRazón.Name = "txtRazón"
            Me.txtRazón.Size = New System.Drawing.Size(591, 21)
            Me.txtRazón.TabIndex = 74
            '
            'txtCedula
            '
            Me.txtCedula.BackColor = System.Drawing.Color.White
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(235, 130)
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(70, 21)
            Me.txtCedula.TabIndex = 73
            Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 112)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(64, 13)
            Me.Label6.TabIndex = 72
            Me.Label6.Text = "CUSTODIO:"
            '
            'txtNombre
            '
            Me.txtNombre.BackColor = System.Drawing.Color.White
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(6, 130)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(230, 21)
            Me.txtNombre.TabIndex = 71
            Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtCódigo
            '
            Me.txtCódigo.BackColor = System.Drawing.Color.White
            Me.txtCódigo.Enabled = False
            Me.txtCódigo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCódigo.ForeColor = System.Drawing.Color.Black
            Me.txtCódigo.Location = New System.Drawing.Point(514, 78)
            Me.txtCódigo.Name = "txtCódigo"
            Me.txtCódigo.Size = New System.Drawing.Size(83, 21)
            Me.txtCódigo.TabIndex = 69
            Me.txtCódigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'lblCentroCosto
            '
            Me.lblCentroCosto.AutoSize = True
            Me.lblCentroCosto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCentroCosto.Location = New System.Drawing.Point(313, 19)
            Me.lblCentroCosto.Name = "lblCentroCosto"
            Me.lblCentroCosto.Size = New System.Drawing.Size(109, 13)
            Me.lblCentroCosto.TabIndex = 68
            Me.lblCentroCosto.Text = "CENTRO DE COSTO:"
            '
            'lblConcepto
            '
            Me.lblConcepto.AutoSize = True
            Me.lblConcepto.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConcepto.Location = New System.Drawing.Point(315, 114)
            Me.lblConcepto.Name = "lblConcepto"
            Me.lblConcepto.Size = New System.Drawing.Size(68, 13)
            Me.lblConcepto.TabIndex = 55
            Me.lblConcepto.Text = "CONCEPTO:"
            '
            'lblBodega
            '
            Me.lblBodega.AutoSize = True
            Me.lblBodega.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBodega.Location = New System.Drawing.Point(3, 66)
            Me.lblBodega.Name = "lblBodega"
            Me.lblBodega.Size = New System.Drawing.Size(53, 13)
            Me.lblBodega.TabIndex = 53
            Me.lblBodega.Text = "BODEGA:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(313, 65)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 50
            Me.Label1.Text = "FECHA:"
            '
            'dtpFecha
            '
            Me.dtpFecha.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFecha.Location = New System.Drawing.Point(316, 78)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(178, 21)
            Me.dtpFecha.TabIndex = 51
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(187, 22)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(65, 13)
            Me.lblActividad.TabIndex = 49
            Me.lblActividad.Text = "ACTIVIDAD:"
            '
            'txtNumero
            '
            Me.txtNumero.BackColor = System.Drawing.Color.White
            Me.txtNumero.Enabled = False
            Me.txtNumero.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumero.Location = New System.Drawing.Point(6, 35)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(101, 21)
            Me.txtNumero.TabIndex = 8
            Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Location = New System.Drawing.Point(3, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "COMPROBANTE:"
            '
            'txtBuscarKardex
            '
            Me.txtBuscarKardex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtBuscarKardex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarKardex.Location = New System.Drawing.Point(91, 39)
            Me.txtBuscarKardex.Name = "txtBuscarKardex"
            Me.txtBuscarKardex.Size = New System.Drawing.Size(466, 22)
            Me.txtBuscarKardex.TabIndex = 194
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(7, 42)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(81, 13)
            Me.Label7.TabIndex = 193
            Me.Label7.Text = "BUSCAR ITEM:"
            '
            'dgvDetalleKardex
            '
            Me.dgvDetalleKardex.AllowDrop = True
            Me.dgvDetalleKardex.AllowUserToAddRows = False
            Me.dgvDetalleKardex.AllowUserToDeleteRows = False
            Me.dgvDetalleKardex.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleKardex.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleKardex.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleKardex.Location = New System.Drawing.Point(3, 304)
            Me.dgvDetalleKardex.MultiSelect = False
            Me.dgvDetalleKardex.Name = "dgvDetalleKardex"
            Me.dgvDetalleKardex.ReadOnly = True
            Me.dgvDetalleKardex.RowHeadersVisible = False
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetalleKardex.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleKardex.Size = New System.Drawing.Size(1254, 305)
            Me.dgvDetalleKardex.TabIndex = 178
            '
            'msKardex
            '
            Me.msKardex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.msKardex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsmReporte})
            Me.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.msKardex.Location = New System.Drawing.Point(3, 3)
            Me.msKardex.Name = "msKardex"
            Me.msKardex.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.msKardex.Size = New System.Drawing.Size(1257, 32)
            Me.msKardex.TabIndex = 177
            Me.msKardex.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'tsmReporte
            '
            Me.tsmReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.tsmReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.tsmReporte.Name = "tsmReporte"
            Me.tsmReporte.Size = New System.Drawing.Size(93, 28)
            Me.tsmReporte.Text = "REPORTE "
            '
            'dgvKardex
            '
            Me.dgvKardex.AllowDrop = True
            Me.dgvKardex.AllowUserToAddRows = False
            Me.dgvKardex.AllowUserToDeleteRows = False
            Me.dgvKardex.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvKardex.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvKardex.BackgroundColor = System.Drawing.Color.White
            Me.dgvKardex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 8.25!)
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvKardex.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvKardex.Location = New System.Drawing.Point(3, 67)
            Me.dgvKardex.MultiSelect = False
            Me.dgvKardex.Name = "dgvKardex"
            Me.dgvKardex.ReadOnly = True
            Me.dgvKardex.RowHeadersVisible = False
            Me.dgvKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvKardex.Size = New System.Drawing.Size(645, 229)
            Me.dgvKardex.TabIndex = 129
            '
            'tpReporte
            '
            Me.tpReporte.Controls.Add(Me.crvKardex)
            Me.tpReporte.Location = New System.Drawing.Point(4, 22)
            Me.tpReporte.Name = "tpReporte"
            Me.tpReporte.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReporte.Size = New System.Drawing.Size(1263, 612)
            Me.tpReporte.TabIndex = 1
            Me.tpReporte.Text = "REPORTE DE ITEM"
            Me.tpReporte.UseVisualStyleBackColor = True
            '
            'crvKardex
            '
            Me.crvKardex.ActiveViewIndex = -1
            Me.crvKardex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvKardex.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvKardex.Location = New System.Drawing.Point(1, 1)
            Me.crvKardex.Name = "crvKardex"
            Me.crvKardex.Size = New System.Drawing.Size(1259, 609)
            Me.crvKardex.TabIndex = 2
            Me.crvKardex.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'ttPublico
            '
            Me.ttPublico.AutoPopDelay = 5000
            Me.ttPublico.BackColor = System.Drawing.Color.LightSteelBlue
            Me.ttPublico.InitialDelay = 100
            Me.ttPublico.IsBalloon = True
            Me.ttPublico.ReshowDelay = 100
            Me.ttPublico.ShowAlways = True
            Me.ttPublico.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            '
            'FormKardex
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1274, 638)
            Me.Controls.Add(Me.tcKardex)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormKardex"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "KARDEX"
            Me.tcKardex.ResumeLayout(False)
            Me.tpCreacion.ResumeLayout(False)
            Me.tpCreacion.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgvDetalleKardex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.msKardex.ResumeLayout(False)
            Me.msKardex.PerformLayout()
            CType(Me.dgvKardex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpReporte.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcKardex As System.Windows.Forms.TabControl
        Friend WithEvents tpReporte As System.Windows.Forms.TabPage
        Friend WithEvents dgvKardex As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetalleKardex As System.Windows.Forms.DataGridView
        Friend WithEvents msKardex As System.Windows.Forms.MenuStrip
        Friend WithEvents tsmReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents crvKardex As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Public WithEvents ttPublico As System.Windows.Forms.ToolTip
        Friend WithEvents txtBuscarKardex As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents tpCreacion As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblConcepto As System.Windows.Forms.Label
        Friend WithEvents lblBodega As System.Windows.Forms.Label
        Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
        Friend WithEvents txtCódigo As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents lblRazon As System.Windows.Forms.Label
        Friend WithEvents txtRazón As System.Windows.Forms.TextBox
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents txtBodega As System.Windows.Forms.TextBox
        Friend WithEvents txtCentroCosto As System.Windows.Forms.TextBox
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnExportarComprobantes As System.Windows.Forms.Button
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnllamar As System.Windows.Forms.Button
    End Class
End Namespace