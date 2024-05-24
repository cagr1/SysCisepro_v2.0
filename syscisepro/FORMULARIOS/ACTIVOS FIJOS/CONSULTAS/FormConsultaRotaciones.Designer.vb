Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaRotaciones
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaRotaciones))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pdRotaciones = New System.Drawing.Printing.PrintDocument()
            Me.ppdRotaciones = New System.Windows.Forms.PrintPreviewDialog()
            Me.rbEntre = New System.Windows.Forms.RadioButton()
            Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
            Me.btnReporteRotaciones = New System.Windows.Forms.Button()
            Me.btnConsultar = New System.Windows.Forms.Button()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.rbDia = New System.Windows.Forms.RadioButton()
            Me.btnPrevio = New System.Windows.Forms.Button()
            Me.btnImprimir = New System.Windows.Forms.Button()
            Me.dgvRotacionesVehiculos = New System.Windows.Forms.DataGridView()
            Me.crvRotaciones = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            CType(Me.dgvRotacionesVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pdRotaciones
            '
            '
            'ppdRotaciones
            '
            Me.ppdRotaciones.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.ppdRotaciones.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.ppdRotaciones.ClientSize = New System.Drawing.Size(400, 300)
            Me.ppdRotaciones.Enabled = True
            Me.ppdRotaciones.Icon = CType(resources.GetObject("ppdRotaciones.Icon"), System.Drawing.Icon)
            Me.ppdRotaciones.Name = "ppdRotaciones"
            Me.ppdRotaciones.Visible = False
            '
            'rbEntre
            '
            Me.rbEntre.AutoSize = True
            Me.rbEntre.Location = New System.Drawing.Point(155, 16)
            Me.rbEntre.Name = "rbEntre"
            Me.rbEntre.Size = New System.Drawing.Size(62, 17)
            Me.rbEntre.TabIndex = 17
            Me.rbEntre.TabStop = True
            Me.rbEntre.Text = "ENTRE"
            Me.rbEntre.UseVisualStyleBackColor = True
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.CustomFormat = ""
            Me.dtpFechaFinal.Location = New System.Drawing.Point(448, 13)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
            Me.dtpFechaFinal.TabIndex = 16
            Me.dtpFechaFinal.Value = New Date(2012, 6, 18, 0, 0, 0, 0)
            '
            'dtpFechaInicial
            '
            Me.dtpFechaInicial.CustomFormat = ""
            Me.dtpFechaInicial.Location = New System.Drawing.Point(242, 13)
            Me.dtpFechaInicial.Name = "dtpFechaInicial"
            Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
            Me.dtpFechaInicial.TabIndex = 15
            Me.dtpFechaInicial.Value = New Date(2012, 6, 18, 0, 0, 0, 0)
            '
            'btnReporteRotaciones
            '
            Me.btnReporteRotaciones.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteRotaciones.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporteRotaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReporteRotaciones.Location = New System.Drawing.Point(753, 3)
            Me.btnReporteRotaciones.Name = "btnReporteRotaciones"
            Me.btnReporteRotaciones.Size = New System.Drawing.Size(73, 42)
            Me.btnReporteRotaciones.TabIndex = 14
            Me.btnReporteRotaciones.Text = "REPORTE"
            Me.btnReporteRotaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReporteRotaciones.UseVisualStyleBackColor = True
            '
            'btnConsultar
            '
            Me.btnConsultar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
            Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnConsultar.Location = New System.Drawing.Point(674, 3)
            Me.btnConsultar.Name = "btnConsultar"
            Me.btnConsultar.Size = New System.Drawing.Size(73, 42)
            Me.btnConsultar.TabIndex = 13
            Me.btnConsultar.Text = "CONSULTAR"
            Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnConsultar.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Location = New System.Drawing.Point(85, 16)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(62, 17)
            Me.rbTodas.TabIndex = 12
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "TODAS"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'rbDia
            '
            Me.rbDia.AutoSize = True
            Me.rbDia.Location = New System.Drawing.Point(29, 16)
            Me.rbDia.Name = "rbDia"
            Me.rbDia.Size = New System.Drawing.Size(48, 17)
            Me.rbDia.TabIndex = 11
            Me.rbDia.TabStop = True
            Me.rbDia.Text = "HOY"
            Me.rbDia.UseVisualStyleBackColor = True
            '
            'btnPrevio
            '
            Me.btnPrevio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPrevio.Image = CType(resources.GetObject("btnPrevio.Image"), System.Drawing.Image)
            Me.btnPrevio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPrevio.Location = New System.Drawing.Point(832, 3)
            Me.btnPrevio.Name = "btnPrevio"
            Me.btnPrevio.Size = New System.Drawing.Size(73, 42)
            Me.btnPrevio.TabIndex = 10
            Me.btnPrevio.Text = "PREVIO"
            Me.btnPrevio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPrevio.UseVisualStyleBackColor = True
            '
            'btnImprimir
            '
            Me.btnImprimir.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
            Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnImprimir.Location = New System.Drawing.Point(911, 3)
            Me.btnImprimir.Name = "btnImprimir"
            Me.btnImprimir.Size = New System.Drawing.Size(73, 42)
            Me.btnImprimir.TabIndex = 9
            Me.btnImprimir.Text = "IMPRIMIR"
            Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnImprimir.UseVisualStyleBackColor = True
            '
            'dgvRotacionesVehiculos
            '
            Me.dgvRotacionesVehiculos.AllowUserToAddRows = False
            Me.dgvRotacionesVehiculos.AllowUserToDeleteRows = False
            Me.dgvRotacionesVehiculos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRotacionesVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRotacionesVehiculos.BackgroundColor = System.Drawing.Color.White
            Me.dgvRotacionesVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRotacionesVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRotacionesVehiculos.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvRotacionesVehiculos.Location = New System.Drawing.Point(2, 49)
            Me.dgvRotacionesVehiculos.MultiSelect = False
            Me.dgvRotacionesVehiculos.Name = "dgvRotacionesVehiculos"
            Me.dgvRotacionesVehiculos.ReadOnly = True
            Me.dgvRotacionesVehiculos.RowHeadersVisible = False
            Me.dgvRotacionesVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRotacionesVehiculos.Size = New System.Drawing.Size(982, 127)
            Me.dgvRotacionesVehiculos.TabIndex = 8
            '
            'crvRotaciones
            '
            Me.crvRotaciones.ActiveViewIndex = -1
            Me.crvRotaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvRotaciones.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvRotaciones.Location = New System.Drawing.Point(2, 179)
            Me.crvRotaciones.Name = "crvRotaciones"
            Me.crvRotaciones.Size = New System.Drawing.Size(982, 386)
            Me.crvRotaciones.TabIndex = 0
            Me.crvRotaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormConsultaRotaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(985, 567)
            Me.Controls.Add(Me.rbEntre)
            Me.Controls.Add(Me.crvRotaciones)
            Me.Controls.Add(Me.dtpFechaFinal)
            Me.Controls.Add(Me.dtpFechaInicial)
            Me.Controls.Add(Me.dgvRotacionesVehiculos)
            Me.Controls.Add(Me.btnReporteRotaciones)
            Me.Controls.Add(Me.btnImprimir)
            Me.Controls.Add(Me.btnConsultar)
            Me.Controls.Add(Me.btnPrevio)
            Me.Controls.Add(Me.rbTodas)
            Me.Controls.Add(Me.rbDia)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormConsultaRotaciones"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTA DE ROTACIONES DE VEHICULOS SEMANALES"
            CType(Me.dgvRotacionesVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pdRotaciones As System.Drawing.Printing.PrintDocument
        Friend WithEvents ppdRotaciones As System.Windows.Forms.PrintPreviewDialog
        Friend WithEvents btnReporteRotaciones As System.Windows.Forms.Button
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents rbDia As System.Windows.Forms.RadioButton
        Friend WithEvents btnPrevio As System.Windows.Forms.Button
        Friend WithEvents btnImprimir As System.Windows.Forms.Button
        Friend WithEvents dgvRotacionesVehiculos As System.Windows.Forms.DataGridView
        Friend WithEvents crvRotaciones As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents rbEntre As System.Windows.Forms.RadioButton
        Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    End Class
End Namespace