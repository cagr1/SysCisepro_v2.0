Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAuxiliaresDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliaresDiario))
            Me.tcAuxiliaresDiario = New System.Windows.Forms.TabControl()
            Me.tpDiarios = New System.Windows.Forms.TabPage()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtHaberSumaAsientos = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtDebeSumaAsientos = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtHaber = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.txtDebe = New System.Windows.Forms.TextBox()
            Me.dgvJornalizacion = New System.Windows.Forms.DataGridView()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.dgvAsientos = New System.Windows.Forms.DataGridView()
            Me.dgvDiarios = New System.Windows.Forms.DataGridView()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCuadrar = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.tcAuxiliaresDiario.SuspendLayout()
            Me.tpDiarios.SuspendLayout()
            CType(Me.dgvJornalizacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAuxiliaresDiario
            '
            Me.tcAuxiliaresDiario.Controls.Add(Me.tpDiarios)
            Me.tcAuxiliaresDiario.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAuxiliaresDiario.Location = New System.Drawing.Point(3, 43)
            Me.tcAuxiliaresDiario.Name = "tcAuxiliaresDiario"
            Me.tcAuxiliaresDiario.SelectedIndex = 0
            Me.tcAuxiliaresDiario.Size = New System.Drawing.Size(871, 611)
            Me.tcAuxiliaresDiario.TabIndex = 0
            '
            'tpDiarios
            '
            Me.tpDiarios.Controls.Add(Me.Label7)
            Me.tpDiarios.Controls.Add(Me.txtHaberSumaAsientos)
            Me.tpDiarios.Controls.Add(Me.Label8)
            Me.tpDiarios.Controls.Add(Me.txtDebeSumaAsientos)
            Me.tpDiarios.Controls.Add(Me.Label6)
            Me.tpDiarios.Controls.Add(Me.txtHaber)
            Me.tpDiarios.Controls.Add(Me.Label4)
            Me.tpDiarios.Controls.Add(Me.Label5)
            Me.tpDiarios.Controls.Add(Me.txtCantidad)
            Me.tpDiarios.Controls.Add(Me.txtDebe)
            Me.tpDiarios.Controls.Add(Me.dgvJornalizacion)
            Me.tpDiarios.Controls.Add(Me.lblDetalle)
            Me.tpDiarios.Controls.Add(Me.dgvAsientos)
            Me.tpDiarios.Controls.Add(Me.dgvDiarios)
            Me.tpDiarios.Controls.Add(Me.Label3)
            Me.tpDiarios.Controls.Add(Me.Label2)
            Me.tpDiarios.Controls.Add(Me.Label1)
            Me.tpDiarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tpDiarios.Location = New System.Drawing.Point(4, 22)
            Me.tpDiarios.Name = "tpDiarios"
            Me.tpDiarios.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDiarios.Size = New System.Drawing.Size(863, 585)
            Me.tpDiarios.TabIndex = 0
            Me.tpDiarios.Text = "DIARIOS"
            Me.tpDiarios.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(702, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(45, 13)
            Me.Label7.TabIndex = 251
            Me.Label7.Text = "HABER:"
            '
            'txtHaberSumaAsientos
            '
            Me.txtHaberSumaAsientos.BackColor = System.Drawing.Color.White
            Me.txtHaberSumaAsientos.Enabled = False
            Me.txtHaberSumaAsientos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHaberSumaAsientos.Location = New System.Drawing.Point(748, 7)
            Me.txtHaberSumaAsientos.Name = "txtHaberSumaAsientos"
            Me.txtHaberSumaAsientos.Size = New System.Drawing.Size(107, 21)
            Me.txtHaberSumaAsientos.TabIndex = 250
            Me.txtHaberSumaAsientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(556, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(33, 13)
            Me.Label8.TabIndex = 249
            Me.Label8.Text = "DEBE"
            '
            'txtDebeSumaAsientos
            '
            Me.txtDebeSumaAsientos.BackColor = System.Drawing.Color.White
            Me.txtDebeSumaAsientos.Enabled = False
            Me.txtDebeSumaAsientos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDebeSumaAsientos.Location = New System.Drawing.Point(594, 7)
            Me.txtDebeSumaAsientos.Name = "txtDebeSumaAsientos"
            Me.txtDebeSumaAsientos.Size = New System.Drawing.Size(107, 21)
            Me.txtDebeSumaAsientos.TabIndex = 248
            Me.txtDebeSumaAsientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(702, 343)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(42, 13)
            Me.Label6.TabIndex = 247
            Me.Label6.Text = "HABER"
            '
            'txtHaber
            '
            Me.txtHaber.BackColor = System.Drawing.Color.White
            Me.txtHaber.Enabled = False
            Me.txtHaber.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHaber.Location = New System.Drawing.Point(746, 338)
            Me.txtHaber.Name = "txtHaber"
            Me.txtHaber.Size = New System.Drawing.Size(107, 21)
            Me.txtHaber.TabIndex = 246
            Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(346, 341)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(53, 13)
            Me.Label4.TabIndex = 245
            Me.Label4.Text = "ASIENTO"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(556, 342)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(33, 13)
            Me.Label5.TabIndex = 244
            Me.Label5.Text = "DEBE"
            '
            'txtCantidad
            '
            Me.txtCantidad.BackColor = System.Drawing.Color.White
            Me.txtCantidad.Enabled = False
            Me.txtCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidad.Location = New System.Drawing.Point(402, 338)
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(96, 21)
            Me.txtCantidad.TabIndex = 243
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtDebe
            '
            Me.txtDebe.BackColor = System.Drawing.Color.White
            Me.txtDebe.Enabled = False
            Me.txtDebe.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDebe.Location = New System.Drawing.Point(592, 338)
            Me.txtDebe.Name = "txtDebe"
            Me.txtDebe.Size = New System.Drawing.Size(107, 21)
            Me.txtDebe.TabIndex = 241
            Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvJornalizacion
            '
            Me.dgvJornalizacion.AllowUserToAddRows = False
            Me.dgvJornalizacion.AllowUserToDeleteRows = False
            Me.dgvJornalizacion.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvJornalizacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvJornalizacion.BackgroundColor = System.Drawing.Color.White
            Me.dgvJornalizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvJornalizacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvJornalizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvJornalizacion.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvJornalizacion.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.dgvJornalizacion.Location = New System.Drawing.Point(3, 366)
            Me.dgvJornalizacion.MultiSelect = False
            Me.dgvJornalizacion.Name = "dgvJornalizacion"
            Me.dgvJornalizacion.ReadOnly = True
            Me.dgvJornalizacion.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvJornalizacion.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvJornalizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvJornalizacion.Size = New System.Drawing.Size(856, 216)
            Me.dgvJornalizacion.TabIndex = 232
            '
            'lblDetalle
            '
            Me.lblDetalle.AutoSize = True
            Me.lblDetalle.ForeColor = System.Drawing.Color.Red
            Me.lblDetalle.Location = New System.Drawing.Point(8, 375)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(0, 16)
            Me.lblDetalle.TabIndex = 231
            '
            'dgvAsientos
            '
            Me.dgvAsientos.AllowUserToAddRows = False
            Me.dgvAsientos.AllowUserToDeleteRows = False
            Me.dgvAsientos.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvAsientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientos.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvAsientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvAsientos.Location = New System.Drawing.Point(187, 31)
            Me.dgvAsientos.MultiSelect = False
            Me.dgvAsientos.Name = "dgvAsientos"
            Me.dgvAsientos.ReadOnly = True
            Me.dgvAsientos.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsientos.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientos.Size = New System.Drawing.Size(672, 302)
            Me.dgvAsientos.TabIndex = 224
            '
            'dgvDiarios
            '
            Me.dgvDiarios.AllowUserToAddRows = False
            Me.dgvDiarios.AllowUserToDeleteRows = False
            Me.dgvDiarios.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDiarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvDiarios.BackgroundColor = System.Drawing.Color.White
            Me.dgvDiarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDiarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDiarios.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvDiarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.dgvDiarios.Location = New System.Drawing.Point(3, 31)
            Me.dgvDiarios.MultiSelect = False
            Me.dgvDiarios.Name = "dgvDiarios"
            Me.dgvDiarios.ReadOnly = True
            Me.dgvDiarios.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDiarios.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDiarios.Size = New System.Drawing.Size(178, 302)
            Me.dgvDiarios.TabIndex = 223
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 346)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(95, 13)
            Me.Label3.TabIndex = 229
            Me.Label3.Text = "JORNALIZACION:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(3, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 19)
            Me.Label2.TabIndex = 226
            Me.Label2.Text = "LIBRO:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(190, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(81, 19)
            Me.Label1.TabIndex = 225
            Me.Label1.Text = "ASIENTO:"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCuadrar, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(874, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCuadrar
            '
            Me.btnCuadrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadrar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCuadrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCuadrar.Name = "btnCuadrar"
            Me.btnCuadrar.Size = New System.Drawing.Size(89, 28)
            Me.btnCuadrar.Text = "CARGAR"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 28)
            Me.ToolStripMenuItem1.Text = "EXPORTAR LIBRO"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem2.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(153, 28)
            Me.ToolStripMenuItem2.Text = "EXPORTAR ASIENTOS"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem3.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 28)
            Me.ToolStripMenuItem3.Text = "EXPORTAR DETALLES"
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHasta.Location = New System.Drawing.Point(354, 42)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(40, 13)
            Me.lblHasta.TabIndex = 216
            Me.lblHasta.Text = "Hasta:"
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesde.Location = New System.Drawing.Point(79, 42)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(41, 13)
            Me.lblDesde.TabIndex = 215
            Me.lblDesde.Text = "Desde:"
            '
            'dtpFinal
            '
            Me.dtpFinal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFinal.Location = New System.Drawing.Point(398, 38)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(222, 21)
            Me.dtpFinal.TabIndex = 214
            '
            'dtpInicio
            '
            Me.dtpInicio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpInicio.Location = New System.Drawing.Point(125, 38)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(210, 21)
            Me.dtpInicio.TabIndex = 213
            '
            'FormAuxiliaresDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(874, 658)
            Me.Controls.Add(Me.lblHasta)
            Me.Controls.Add(Me.lblDesde)
            Me.Controls.Add(Me.dtpFinal)
            Me.Controls.Add(Me.dtpInicio)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAuxiliaresDiario)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAuxiliaresDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AUXILIARES DIARIO"
            Me.tcAuxiliaresDiario.ResumeLayout(False)
            Me.tpDiarios.ResumeLayout(False)
            Me.tpDiarios.PerformLayout()
            CType(Me.dgvJornalizacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAuxiliaresDiario As System.Windows.Forms.TabControl
        Friend WithEvents tpDiarios As System.Windows.Forms.TabPage
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvAsientos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDiarios As System.Windows.Forms.DataGridView
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblDetalle As System.Windows.Forms.Label
        Friend WithEvents dgvJornalizacion As System.Windows.Forms.DataGridView
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtHaber As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents txtDebe As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtHaberSumaAsientos As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtDebeSumaAsientos As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCuadrar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace