Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAuxiliares
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuxiliares))
            Me.tcAuxiliares = New System.Windows.Forms.TabControl()
            Me.tpActualizar = New System.Windows.Forms.TabPage()
            Me.dgvAsientosDiario = New System.Windows.Forms.DataGridView()
            Me.dgvMayoresPadres = New System.Windows.Forms.DataGridView()
            Me.lblHasta = New System.Windows.Forms.Label()
            Me.lblDesde = New System.Windows.Forms.Label()
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
            Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnCargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcAuxiliares.SuspendLayout()
            Me.tpActualizar.SuspendLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tcAuxiliares
            '
            Me.tcAuxiliares.Controls.Add(Me.tpActualizar)
            Me.tcAuxiliares.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tcAuxiliares.Location = New System.Drawing.Point(1, 37)
            Me.tcAuxiliares.Name = "tcAuxiliares"
            Me.tcAuxiliares.SelectedIndex = 0
            Me.tcAuxiliares.Size = New System.Drawing.Size(984, 682)
            Me.tcAuxiliares.TabIndex = 0
            '
            'tpActualizar
            '
            Me.tpActualizar.Controls.Add(Me.dgvAsientosDiario)
            Me.tpActualizar.Controls.Add(Me.dgvMayoresPadres)
            Me.tpActualizar.Controls.Add(Me.lblHasta)
            Me.tpActualizar.Controls.Add(Me.lblDesde)
            Me.tpActualizar.Controls.Add(Me.dtpFinal)
            Me.tpActualizar.Controls.Add(Me.dtpInicio)
            Me.tpActualizar.Location = New System.Drawing.Point(4, 22)
            Me.tpActualizar.Name = "tpActualizar"
            Me.tpActualizar.Padding = New System.Windows.Forms.Padding(3)
            Me.tpActualizar.Size = New System.Drawing.Size(976, 656)
            Me.tpActualizar.TabIndex = 0
            Me.tpActualizar.Text = "MAYORES"
            Me.tpActualizar.UseVisualStyleBackColor = True
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
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosDiario.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvAsientosDiario.Location = New System.Drawing.Point(6, 29)
            Me.dgvAsientosDiario.MultiSelect = False
            Me.dgvAsientosDiario.Name = "dgvAsientosDiario"
            Me.dgvAsientosDiario.ReadOnly = True
            Me.dgvAsientosDiario.RowHeadersVisible = False
            Me.dgvAsientosDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosDiario.Size = New System.Drawing.Size(964, 622)
            Me.dgvAsientosDiario.TabIndex = 225
            '
            'dgvMayoresPadres
            '
            Me.dgvMayoresPadres.AllowUserToAddRows = False
            Me.dgvMayoresPadres.AllowUserToDeleteRows = False
            Me.dgvMayoresPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMayoresPadres.Location = New System.Drawing.Point(6, 55)
            Me.dgvMayoresPadres.Name = "dgvMayoresPadres"
            Me.dgvMayoresPadres.ReadOnly = True
            Me.dgvMayoresPadres.Size = New System.Drawing.Size(964, 22)
            Me.dgvMayoresPadres.TabIndex = 218
            Me.dgvMayoresPadres.Visible = False
            '
            'lblHasta
            '
            Me.lblHasta.AutoSize = True
            Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.lblHasta.Location = New System.Drawing.Point(365, 6)
            Me.lblHasta.Name = "lblHasta"
            Me.lblHasta.Size = New System.Drawing.Size(38, 13)
            Me.lblHasta.TabIndex = 212
            Me.lblHasta.Text = "Hasta:"
            '
            'lblDesde
            '
            Me.lblDesde.AutoSize = True
            Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.lblDesde.Location = New System.Drawing.Point(3, 6)
            Me.lblDesde.Name = "lblDesde"
            Me.lblDesde.Size = New System.Drawing.Size(41, 13)
            Me.lblDesde.TabIndex = 211
            Me.lblDesde.Text = "Desde:"
            '
            'dtpFinal
            '
            Me.dtpFinal.Location = New System.Drawing.Point(409, 3)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(200, 21)
            Me.dtpFinal.TabIndex = 210
            '
            'dtpInicio
            '
            Me.dtpInicio.Location = New System.Drawing.Point(51, 3)
            Me.dtpInicio.Name = "dtpInicio"
            Me.dtpInicio.Size = New System.Drawing.Size(200, 21)
            Me.dtpInicio.TabIndex = 209
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnExportar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(984, 32)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnCargar
            '
            Me.btnCargar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCargar.Image = Global.syscisepro.My.Resources.Resources.refresh_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnCargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCargar.Name = "btnCargar"
            Me.btnCargar.Size = New System.Drawing.Size(89, 28)
            Me.btnCargar.Text = "CARGAR"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.icons8_excel_48
            Me.btnExportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(98, 28)
            Me.btnExportar.Text = "EXPORTAR"
            '
            'FormAuxiliares
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(984, 720)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.tcAuxiliares)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAuxiliares"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AUXILIARES"
            Me.tcAuxiliares.ResumeLayout(False)
            Me.tpActualizar.ResumeLayout(False)
            Me.tpActualizar.PerformLayout()
            CType(Me.dgvAsientosDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMayoresPadres, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents tcAuxiliares As System.Windows.Forms.TabControl
        Friend WithEvents tpActualizar As System.Windows.Forms.TabPage
        Friend WithEvents lblHasta As System.Windows.Forms.Label
        Friend WithEvents lblDesde As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvMayoresPadres As System.Windows.Forms.DataGridView
        Friend WithEvents dgvAsientosDiario As System.Windows.Forms.DataGridView
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnCargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace