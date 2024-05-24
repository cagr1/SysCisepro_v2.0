Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmFacturadoPorClienteAnual
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbClienteGeneral = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialClienteGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.ComboBox2 = New System.Windows.Forms.ComboBox()
            Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbTotal = New System.Windows.Forms.GroupBox()
            Me.gbClienteGeneral.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRangoFechas.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbClienteGeneral
            '
            Me.gbClienteGeneral.Controls.Add(Me.txtNombreComercialClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
            Me.gbClienteGeneral.Controls.Add(Me.Label11)
            Me.gbClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbClienteGeneral.Location = New System.Drawing.Point(1, 23)
            Me.gbClienteGeneral.Name = "gbClienteGeneral"
            Me.gbClienteGeneral.Size = New System.Drawing.Size(599, 60)
            Me.gbClienteGeneral.TabIndex = 100
            Me.gbClienteGeneral.TabStop = False
            Me.gbClienteGeneral.Text = "CLIENTE"
            '
            'txtNombreComercialClienteGeneral
            '
            Me.txtNombreComercialClienteGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialClienteGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialClienteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialClienteGeneral.ForeColor = System.Drawing.SystemColors.ControlText
            Me.txtNombreComercialClienteGeneral.Location = New System.Drawing.Point(139, 24)
            Me.txtNombreComercialClienteGeneral.Name = "txtNombreComercialClienteGeneral"
            Me.txtNombreComercialClienteGeneral.Size = New System.Drawing.Size(456, 20)
            Me.txtNombreComercialClienteGeneral.TabIndex = 2
            '
            'lblIdClienteGeneral
            '
            Me.lblIdClienteGeneral.AutoSize = True
            Me.lblIdClienteGeneral.Location = New System.Drawing.Point(74, -1)
            Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
            Me.lblIdClienteGeneral.Size = New System.Drawing.Size(25, 13)
            Me.lblIdClienteGeneral.TabIndex = 76
            Me.lblIdClienteGeneral.Text = "..."
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(6, 25)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(133, 13)
            Me.Label11.TabIndex = 77
            Me.Label11.Text = "BUSCAR CLIENTE, C.I.:"
            '
            'dgvAsientosDiario
            '
            Me.dgvAsientosDiario.AllowUserToAddRows = False
            Me.dgvAsientosDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvAsientosDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvAsientosDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientosDiario.GridColor = System.Drawing.SystemColors.ControlLightLight
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(1, 88)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(1171, 543)
            Me.dgvAsientosDiario.TabIndex = 0
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.Controls.Add(Me.Label14)
            Me.gbRangoFechas.Controls.Add(Me.ComboBox2)
            Me.gbRangoFechas.Controls.Add(Me.dtpHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpDesde)
            Me.gbRangoFechas.Controls.Add(Me.Label10)
            Me.gbRangoFechas.Controls.Add(Me.Label7)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(602, 24)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(570, 60)
            Me.gbRangoFechas.TabIndex = 114
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(6, 24)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(85, 13)
            Me.Label14.TabIndex = 15
            Me.Label14.Text = "AÑO CONTRATO:"
            '
            'ComboBox2
            '
            Me.ComboBox2.BackColor = System.Drawing.Color.White
            Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ComboBox2.FormattingEnabled = True
            Me.ComboBox2.Items.AddRange(New Object() {"ALARMA", "GUARDIANIA", "ALARMA Y GUARDIANIA"})
            Me.ComboBox2.Location = New System.Drawing.Point(94, 21)
            Me.ComboBox2.Name = "ComboBox2"
            Me.ComboBox2.Size = New System.Drawing.Size(58, 21)
            Me.ComboBox2.TabIndex = 14
            '
            'dtpHasta
            '
            Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpHasta.Location = New System.Drawing.Point(467, 21)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(98, 20)
            Me.dtpHasta.TabIndex = 1
            '
            'dtpDesde
            '
            Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpDesde.Location = New System.Drawing.Point(347, 21)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(97, 20)
            Me.dtpDesde.TabIndex = 0
            Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 1, 0, 0)
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(198, 24)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(151, 13)
            Me.Label10.TabIndex = 4
            Me.Label10.Text = "DATOS COMPRENDIDOS ENTRE"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(448, 24)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(13, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Y"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1173, 24)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(119, 20)
            Me.btnBuscar.Text = "BUSCAR TODOS"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(91, 20)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'gbTotal
            '
            Me.gbTotal.BackColor = System.Drawing.Color.White
            Me.gbTotal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotal.Location = New System.Drawing.Point(1, 628)
            Me.gbTotal.Name = "gbTotal"
            Me.gbTotal.Size = New System.Drawing.Size(1172, 44)
            Me.gbTotal.TabIndex = 101
            Me.gbTotal.TabStop = False
            '
            'FrmFacturadoPorClienteAnual
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1173, 672)
            Me.Controls.Add(Me.gbClienteGeneral)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvAsientosDiario)
            Me.Controls.Add(Me.gbTotal)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FrmFacturadoPorClienteAnual"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TOTAL FACTURADO POR CLIENTE"
            Me.gbClienteGeneral.ResumeLayout(False)
            Me.gbClienteGeneral.PerformLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents gbClienteGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialClienteGeneral As System.Windows.Forms.TextBox
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents gbTotal As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    End Class
End Namespace