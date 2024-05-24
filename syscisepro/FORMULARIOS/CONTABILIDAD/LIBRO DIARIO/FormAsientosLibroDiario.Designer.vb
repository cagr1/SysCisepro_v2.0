Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAsientosLibroDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAsientosLibroDiario))
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dtpAsientoDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbRnagoFechas = New System.Windows.Forms.GroupBox()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.dtpAsientoHasta = New System.Windows.Forms.DateTimePicker()
            Me.gbTotalDebeTotalHaber = New System.Windows.Forms.GroupBox()
            Me.txtTotalHaber = New System.Windows.Forms.Label()
            Me.txtTotalDebe = New System.Windows.Forms.Label()
            Me.PictureBoxErrorSumaAsiento = New System.Windows.Forms.PictureBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.rbCuenta = New System.Windows.Forms.RadioButton()
            Me.gbTipoBusqueda = New System.Windows.Forms.GroupBox()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbNumero = New System.Windows.Forms.RadioButton()
            Me.gbComandos = New System.Windows.Forms.GroupBox()
            Me.txtCuentaNueva = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNumeroAsientoBuscar = New System.Windows.Forms.TextBox()
            Me.gbNumeroAsiento = New System.Windows.Forms.GroupBox()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscarAsiento = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAnular = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.REPORTEASIENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TODOSLOSASIENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.gbRnagoFechas.SuspendLayout()
            Me.gbTotalDebeTotalHaber.SuspendLayout()
            CType(Me.PictureBoxErrorSumaAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipoBusqueda.SuspendLayout()
            Me.gbComandos.SuspendLayout()
            Me.gbNumeroAsiento.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dtpAsientoDesde
            '
            Me.dtpAsientoDesde.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpAsientoDesde.Location = New System.Drawing.Point(6, 19)
            Me.dtpAsientoDesde.Name = "dtpAsientoDesde"
            Me.dtpAsientoDesde.Size = New System.Drawing.Size(90, 20)
            Me.dtpAsientoDesde.TabIndex = 6
            '
            'gbRnagoFechas
            '
            Me.gbRnagoFechas.BackColor = System.Drawing.Color.White
            Me.gbRnagoFechas.Controls.Add(Me.dtpAsientoDesde)
            Me.gbRnagoFechas.Controls.Add(Me.lblHasta)
            Me.gbRnagoFechas.Controls.Add(Me.dtpAsientoHasta)
            Me.gbRnagoFechas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRnagoFechas.Location = New System.Drawing.Point(328, 26)
            Me.gbRnagoFechas.Name = "gbRnagoFechas"
            Me.gbRnagoFechas.Size = New System.Drawing.Size(205, 50)
            Me.gbRnagoFechas.TabIndex = 133
            Me.gbRnagoFechas.TabStop = False
            Me.gbRnagoFechas.Text = "RANGO FECHAS"
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.Location = New System.Drawing.Point(95, 23)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(13, 13)
            Me.lblHasta.TabIndex = 8
            Me.lblHasta.Text = "a"
            '
            'dtpAsientoHasta
            '
            Me.dtpAsientoHasta.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpAsientoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpAsientoHasta.Location = New System.Drawing.Point(109, 19)
            Me.dtpAsientoHasta.Name = "dtpAsientoHasta"
            Me.dtpAsientoHasta.Size = New System.Drawing.Size(90, 20)
            Me.dtpAsientoHasta.TabIndex = 7
            '
            'gbTotalDebeTotalHaber
            '
            Me.gbTotalDebeTotalHaber.BackColor = System.Drawing.Color.White
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalHaber)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.txtTotalDebe)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.PictureBoxErrorSumaAsiento)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.lblTotal)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.Label3)
            Me.gbTotalDebeTotalHaber.Controls.Add(Me.Label1)
            Me.gbTotalDebeTotalHaber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotalDebeTotalHaber.Location = New System.Drawing.Point(1, 607)
            Me.gbTotalDebeTotalHaber.Name = "gbTotalDebeTotalHaber"
            Me.gbTotalDebeTotalHaber.Size = New System.Drawing.Size(1224, 40)
            Me.gbTotalDebeTotalHaber.TabIndex = 134
            Me.gbTotalDebeTotalHaber.TabStop = False
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.AutoSize = True
            Me.txtTotalHaber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(1096, 13)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(36, 20)
            Me.txtTotalHaber.TabIndex = 41
            Me.txtTotalHaber.Text = "0.00"
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.AutoSize = True
            Me.txtTotalDebe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(886, 13)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(36, 20)
            Me.txtTotalDebe.TabIndex = 40
            Me.txtTotalDebe.Text = "0.00"
            '
            'PictureBoxErrorSumaAsiento
            '
            Me.PictureBoxErrorSumaAsiento.Image = CType(resources.GetObject("PictureBoxErrorSumaAsiento.Image"), System.Drawing.Image)
            Me.PictureBoxErrorSumaAsiento.Location = New System.Drawing.Point(810, 16)
            Me.PictureBoxErrorSumaAsiento.Name = "PictureBoxErrorSumaAsiento"
            Me.PictureBoxErrorSumaAsiento.Size = New System.Drawing.Size(16, 16)
            Me.PictureBoxErrorSumaAsiento.TabIndex = 37
            Me.PictureBoxErrorSumaAsiento.TabStop = False
            Me.PictureBoxErrorSumaAsiento.Visible = False
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(747, 13)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(57, 20)
            Me.lblTotal.TabIndex = 34
            Me.lblTotal.Text = "TOTAL :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(1038, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(59, 20)
            Me.Label3.TabIndex = 39
            Me.Label3.Text = "HABER:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(838, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(48, 20)
            Me.Label1.TabIndex = 38
            Me.Label1.Text = "DEBE:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.dgvAsientosDiario)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 77)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1225, 531)
            Me.GroupBox1.TabIndex = 136
            Me.GroupBox1.TabStop = False
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvAsientosDiario.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientosDiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientosDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientosDiario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(3, 19)
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Info
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.GrayText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.RowHeadersWidth = 25
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosDiario.RowsDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(1219, 509)
            Me.dgvAsientosDiario.TabIndex = 126
            '
            'rbCuenta
            '
            Me.rbCuenta.AutoSize = True
            Me.rbCuenta.Location = New System.Drawing.Point(82, 17)
            Me.rbCuenta.Name = "rbCuenta"
            Me.rbCuenta.Size = New System.Drawing.Size(66, 17)
            Me.rbCuenta.TabIndex = 3
            Me.rbCuenta.TabStop = True
            Me.rbCuenta.Text = "CUENTA"
            Me.rbCuenta.UseVisualStyleBackColor = True
            '
            'gbTipoBusqueda
            '
            Me.gbTipoBusqueda.BackColor = System.Drawing.Color.White
            Me.gbTipoBusqueda.Controls.Add(Me.rbCuenta)
            Me.gbTipoBusqueda.Controls.Add(Me.rbFecha)
            Me.gbTipoBusqueda.Controls.Add(Me.rbNumero)
            Me.gbTipoBusqueda.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipoBusqueda.Location = New System.Drawing.Point(0, 26)
            Me.gbTipoBusqueda.Name = "gbTipoBusqueda"
            Me.gbTipoBusqueda.Size = New System.Drawing.Size(223, 50)
            Me.gbTipoBusqueda.TabIndex = 135
            Me.gbTipoBusqueda.TabStop = False
            Me.gbTipoBusqueda.Text = "TIPO BUSQUEDA"
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.Checked = True
            Me.rbFecha.Location = New System.Drawing.Point(158, 17)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(59, 17)
            Me.rbFecha.TabIndex = 2
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "FECHA"
            Me.rbFecha.UseVisualStyleBackColor = True
            '
            'rbNumero
            '
            Me.rbNumero.AutoSize = True
            Me.rbNumero.Location = New System.Drawing.Point(5, 17)
            Me.rbNumero.Name = "rbNumero"
            Me.rbNumero.Size = New System.Drawing.Size(69, 17)
            Me.rbNumero.TabIndex = 1
            Me.rbNumero.TabStop = True
            Me.rbNumero.Text = "ASIENTO"
            Me.rbNumero.UseVisualStyleBackColor = True
            '
            'gbComandos
            '
            Me.gbComandos.BackColor = System.Drawing.Color.White
            Me.gbComandos.Controls.Add(Me.txtCuentaNueva)
            Me.gbComandos.Controls.Add(Me.Label2)
            Me.gbComandos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComandos.Location = New System.Drawing.Point(532, 26)
            Me.gbComandos.Name = "gbComandos"
            Me.gbComandos.Size = New System.Drawing.Size(693, 50)
            Me.gbComandos.TabIndex = 131
            Me.gbComandos.TabStop = False
            Me.gbComandos.Text = "CUENTAS"
            '
            'txtCuentaNueva
            '
            Me.txtCuentaNueva.BackColor = System.Drawing.Color.White
            Me.txtCuentaNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaNueva.Enabled = False
            Me.txtCuentaNueva.Location = New System.Drawing.Point(56, 19)
            Me.txtCuentaNueva.Name = "txtCuentaNueva"
            Me.txtCuentaNueva.Size = New System.Drawing.Size(627, 22)
            Me.txtCuentaNueva.TabIndex = 58
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(49, 13)
            Me.Label2.TabIndex = 59
            Me.Label2.Text = "CUENTA:"
            '
            'txtNumeroAsientoBuscar
            '
            Me.txtNumeroAsientoBuscar.BackColor = System.Drawing.Color.White
            Me.txtNumeroAsientoBuscar.Enabled = False
            Me.txtNumeroAsientoBuscar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroAsientoBuscar.Location = New System.Drawing.Point(6, 20)
            Me.txtNumeroAsientoBuscar.Name = "txtNumeroAsientoBuscar"
            Me.txtNumeroAsientoBuscar.Size = New System.Drawing.Size(93, 20)
            Me.txtNumeroAsientoBuscar.TabIndex = 4
            Me.txtNumeroAsientoBuscar.Text = "0"
            Me.txtNumeroAsientoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'gbNumeroAsiento
            '
            Me.gbNumeroAsiento.BackColor = System.Drawing.Color.White
            Me.gbNumeroAsiento.Controls.Add(Me.txtNumeroAsientoBuscar)
            Me.gbNumeroAsiento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroAsiento.Location = New System.Drawing.Point(223, 26)
            Me.gbNumeroAsiento.Name = "gbNumeroAsiento"
            Me.gbNumeroAsiento.Size = New System.Drawing.Size(105, 50)
            Me.gbNumeroAsiento.TabIndex = 132
            Me.gbNumeroAsiento.TabStop = False
            Me.gbNumeroAsiento.Text = "N° ASIENTO"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarAsiento, Me.btnGuardar, Me.btnAnular, Me.ToolStripMenuItem1, Me.btnReporte, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1227, 24)
            Me.MenuStrip1.TabIndex = 186
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(136, 20)
            Me.btnBuscarAsiento.Text = "CARGAR ASIENTOS"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(144, 20)
            Me.btnGuardar.Text = "GUARDAR ASIENTOS"
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.syscisepro.My.Resources.Resources.EliminarRegistro
            Me.btnAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(136, 20)
            Me.btnAnular.Text = "ANULAR ASIENTOS"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(95, 20)
            Me.ToolStripMenuItem1.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTEASIENTOToolStripMenuItem, Me.TODOSLOSASIENTOSToolStripMenuItem})
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(82, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'REPORTEASIENTOToolStripMenuItem
            '
            Me.REPORTEASIENTOToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.report
            Me.REPORTEASIENTOToolStripMenuItem.Name = "REPORTEASIENTOToolStripMenuItem"
            Me.REPORTEASIENTOToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
            Me.REPORTEASIENTOToolStripMenuItem.Text = "REPORTE ASIENTO"
            '
            'TODOSLOSASIENTOSToolStripMenuItem
            '
            Me.TODOSLOSASIENTOSToolStripMenuItem.Image = Global.syscisepro.My.Resources.Resources.report
            Me.TODOSLOSASIENTOSToolStripMenuItem.Name = "TODOSLOSASIENTOSToolStripMenuItem"
            Me.TODOSLOSASIENTOSToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
            Me.TODOSLOSASIENTOSToolStripMenuItem.Text = "TODOS LOS ASIENTOS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(90, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(1059, 5)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(156, 17)
            Me.CheckBox1.TabIndex = 187
            Me.CheckBox1.Text = "OCULTAR CUENTAS $ 0.00"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'FormAsientosLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1227, 650)
            Me.Controls.Add(Me.CheckBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbRnagoFechas)
            Me.Controls.Add(Me.gbTotalDebeTotalHaber)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbTipoBusqueda)
            Me.Controls.Add(Me.gbComandos)
            Me.Controls.Add(Me.gbNumeroAsiento)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FormAsientosLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ASIENTOS LIBRO DIARIO GENERAL"
            Me.gbRnagoFechas.ResumeLayout(False)
            Me.gbRnagoFechas.PerformLayout()
            Me.gbTotalDebeTotalHaber.ResumeLayout(False)
            Me.gbTotalDebeTotalHaber.PerformLayout()
            CType(Me.PictureBoxErrorSumaAsiento, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipoBusqueda.ResumeLayout(False)
            Me.gbTipoBusqueda.PerformLayout()
            Me.gbComandos.ResumeLayout(False)
            Me.gbComandos.PerformLayout()
            Me.gbNumeroAsiento.ResumeLayout(False)
            Me.gbNumeroAsiento.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpAsientoDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbRnagoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents dtpAsientoHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbTotalDebeTotalHaber As System.Windows.Forms.GroupBox
        Friend WithEvents PictureBoxErrorSumaAsiento As System.Windows.Forms.PictureBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents rbCuenta As System.Windows.Forms.RadioButton
        Friend WithEvents gbTipoBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbNumero As System.Windows.Forms.RadioButton
        Friend WithEvents gbComandos As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCuentaNueva As System.Windows.Forms.TextBox
        Friend WithEvents txtNumeroAsientoBuscar As System.Windows.Forms.TextBox
        Friend WithEvents gbNumeroAsiento As System.Windows.Forms.GroupBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAnular As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTotalHaber As System.Windows.Forms.Label
        Friend WithEvents txtTotalDebe As System.Windows.Forms.Label
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents REPORTEASIENTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TODOSLOSASIENTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace