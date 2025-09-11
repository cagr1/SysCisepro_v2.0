<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportEstadoPyG
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
        Me.chkAnterior = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.cbxShowColumns = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.chkPorcAnterior = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkCambioAnterior = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkPorcPrevio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkCambioPrevio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkPrevio = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaDesdeMes = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpFechaHastaMes = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAcpetar = New System.Windows.Forms.Button()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox2.Panel.SuspendLayout()
        Me.KryptonGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAnterior
        '
        Me.chkAnterior.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkAnterior.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkAnterior.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkAnterior.Location = New System.Drawing.Point(14, 69)
        Me.chkAnterior.Name = "chkAnterior"
        Me.chkAnterior.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkAnterior.Size = New System.Drawing.Size(113, 18)
        Me.chkAnterior.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnterior.TabIndex = 251
        Me.chkAnterior.Values.Text = "Periodo Anterior"
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionOverlap = 0R
        Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 84)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbxShowColumns)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkPorcAnterior)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkCambioAnterior)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkAnterior)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkPorcPrevio)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkCambioPrevio)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.chkPrevio)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(317, 171)
        Me.KryptonGroupBox1.TabIndex = 252
        Me.KryptonGroupBox1.Values.Heading = "Columnas"
        '
        'cbxShowColumns
        '
        Me.cbxShowColumns.AlwaysActive = False
        Me.cbxShowColumns.DropDownWidth = 150
        Me.cbxShowColumns.Items.AddRange(New Object() {"Mensual", "Trimestral ", "Semestral", "Anual "})
        Me.cbxShowColumns.Location = New System.Drawing.Point(137, 20)
        Me.cbxShowColumns.Name = "cbxShowColumns"
        Me.cbxShowColumns.Size = New System.Drawing.Size(111, 21)
        Me.cbxShowColumns.TabIndex = 256
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 20)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(133, 20)
        Me.KryptonLabel1.TabIndex = 254
        Me.KryptonLabel1.Values.Text = "Mostrar Columnas por"
        '
        'chkPorcAnterior
        '
        Me.chkPorcAnterior.Enabled = False
        Me.chkPorcAnterior.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcAnterior.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcAnterior.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcAnterior.Location = New System.Drawing.Point(40, 116)
        Me.chkPorcAnterior.Name = "chkPorcAnterior"
        Me.chkPorcAnterior.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkPorcAnterior.Size = New System.Drawing.Size(78, 18)
        Me.chkPorcAnterior.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorcAnterior.TabIndex = 253
        Me.chkPorcAnterior.Values.Text = "% Cambio"
        '
        'chkCambioAnterior
        '
        Me.chkCambioAnterior.Enabled = False
        Me.chkCambioAnterior.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioAnterior.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioAnterior.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioAnterior.Location = New System.Drawing.Point(40, 92)
        Me.chkCambioAnterior.Name = "chkCambioAnterior"
        Me.chkCambioAnterior.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkCambioAnterior.Size = New System.Drawing.Size(76, 18)
        Me.chkCambioAnterior.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioAnterior.TabIndex = 252
        Me.chkCambioAnterior.Values.Text = "$ Cambio"
        '
        'chkPorcPrevio
        '
        Me.chkPorcPrevio.Enabled = False
        Me.chkPorcPrevio.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcPrevio.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcPrevio.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPorcPrevio.Location = New System.Drawing.Point(216, 116)
        Me.chkPorcPrevio.Name = "chkPorcPrevio"
        Me.chkPorcPrevio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkPorcPrevio.Size = New System.Drawing.Size(78, 18)
        Me.chkPorcPrevio.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorcPrevio.TabIndex = 253
        Me.chkPorcPrevio.Values.Text = "% Cambio"
        '
        'chkCambioPrevio
        '
        Me.chkCambioPrevio.Enabled = False
        Me.chkCambioPrevio.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioPrevio.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioPrevio.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkCambioPrevio.Location = New System.Drawing.Point(216, 92)
        Me.chkCambioPrevio.Name = "chkCambioPrevio"
        Me.chkCambioPrevio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkCambioPrevio.Size = New System.Drawing.Size(76, 18)
        Me.chkCambioPrevio.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCambioPrevio.TabIndex = 252
        Me.chkCambioPrevio.Values.Text = "$ Cambio"
        '
        'chkPrevio
        '
        Me.chkPrevio.Images.CheckedNormal = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPrevio.Images.CheckedPressed = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPrevio.Images.CheckedTracking = Global.syscisepro.My.Resources.Resources.check_24dp_FILL0_wght400_GRAD0_opsz24
        Me.chkPrevio.Location = New System.Drawing.Point(188, 69)
        Me.chkPrevio.Name = "chkPrevio"
        Me.chkPrevio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.chkPrevio.Size = New System.Drawing.Size(104, 18)
        Me.chkPrevio.StateCommon.ShortText.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrevio.TabIndex = 251
        Me.chkPrevio.Values.Text = "Periodo Previo"
        '
        'KryptonGroupBox2
        '
        Me.KryptonGroupBox2.CaptionOverlap = 0R
        Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
        Me.KryptonGroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
        '
        'KryptonGroupBox2.Panel
        '
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel11)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.KryptonLabel10)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaDesdeMes)
        Me.KryptonGroupBox2.Panel.Controls.Add(Me.dtpFechaHastaMes)
        Me.KryptonGroupBox2.Size = New System.Drawing.Size(317, 76)
        Me.KryptonGroupBox2.TabIndex = 253
        Me.KryptonGroupBox2.Values.Heading = "Rango de Reporte"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(159, 17)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel11.TabIndex = 235
        Me.KryptonLabel11.Values.Text = "Hasta"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(14, 17)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel10.TabIndex = 234
        Me.KryptonLabel10.Values.Text = "Desde"
        '
        'dtpFechaDesdeMes
        '
        Me.dtpFechaDesdeMes.AlwaysActive = False
        Me.dtpFechaDesdeMes.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
        Me.dtpFechaDesdeMes.CustomFormat = "MMMM - yyyy"
        Me.dtpFechaDesdeMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesdeMes.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpFechaDesdeMes.Location = New System.Drawing.Point(65, 17)
        Me.dtpFechaDesdeMes.Name = "dtpFechaDesdeMes"
        Me.dtpFechaDesdeMes.Size = New System.Drawing.Size(85, 21)
        Me.dtpFechaDesdeMes.TabIndex = 232
        '
        'dtpFechaHastaMes
        '
        Me.dtpFechaHastaMes.AlwaysActive = False
        Me.dtpFechaHastaMes.CalendarTodayDate = New Date(2025, 2, 4, 0, 0, 0, 0)
        Me.dtpFechaHastaMes.CustomFormat = "MMMM - yyyy"
        Me.dtpFechaHastaMes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHastaMes.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpFechaHastaMes.Location = New System.Drawing.Point(206, 17)
        Me.dtpFechaHastaMes.Name = "dtpFechaHastaMes"
        Me.dtpFechaHastaMes.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaHastaMes.TabIndex = 233
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(53, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 254
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAcpetar
        '
        Me.btnAcpetar.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAcpetar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAcpetar.FlatAppearance.BorderSize = 0
        Me.btnAcpetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcpetar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcpetar.ForeColor = System.Drawing.Color.White
        Me.btnAcpetar.Location = New System.Drawing.Point(163, 270)
        Me.btnAcpetar.Name = "btnAcpetar"
        Me.btnAcpetar.Size = New System.Drawing.Size(89, 34)
        Me.btnAcpetar.TabIndex = 255
        Me.btnAcpetar.Text = "ACEPTAR"
        Me.btnAcpetar.UseVisualStyleBackColor = False
        '
        'FormReportEstadoPyG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 320)
        Me.Controls.Add(Me.btnAcpetar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KryptonGroupBox2)
        Me.Controls.Add(Me.KryptonGroupBox1)
        Me.Name = "FormReportEstadoPyG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.StateActive.Border.Rounding = 5.0!
        Me.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.cbxShowColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.Panel.ResumeLayout(False)
        Me.KryptonGroupBox2.Panel.PerformLayout()
        CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkAnterior As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents chkPorcAnterior As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkCambioAnterior As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkPorcPrevio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkCambioPrevio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkPrevio As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxShowColumns As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel11 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaDesdeMes As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpFechaHastaMes As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAcpetar As Button
End Class
