Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultarProximosSegurosVencidos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultarProximosSegurosVencidos))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.tcSeguros = New System.Windows.Forms.TabControl()
            Me.tpSeguros = New System.Windows.Forms.TabPage()
            Me.btnConsultar = New System.Windows.Forms.Button()
            Me.pbSeguros = New System.Windows.Forms.PictureBox()
            Me.txtFechaActual = New System.Windows.Forms.TextBox()
            Me.dgvSeguros = New System.Windows.Forms.DataGridView()
            Me.tpDispositivos = New System.Windows.Forms.TabPage()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.pbDispositivos = New System.Windows.Forms.PictureBox()
            Me.txtFechaActualDispositivo = New System.Windows.Forms.TextBox()
            Me.dgvDispositivos = New System.Windows.Forms.DataGridView()
            Me.tcSeguros.SuspendLayout()
            Me.tpSeguros.SuspendLayout()
            CType(Me.pbSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tpDispositivos.SuspendLayout()
            CType(Me.pbDispositivos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDispositivos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tcSeguros
            '
            Me.tcSeguros.Controls.Add(Me.tpSeguros)
            Me.tcSeguros.Controls.Add(Me.tpDispositivos)
            Me.tcSeguros.Location = New System.Drawing.Point(0, 0)
            Me.tcSeguros.Name = "tcSeguros"
            Me.tcSeguros.SelectedIndex = 0
            Me.tcSeguros.Size = New System.Drawing.Size(979, 480)
            Me.tcSeguros.TabIndex = 8
            '
            'tpSeguros
            '
            Me.tpSeguros.Controls.Add(Me.btnConsultar)
            Me.tpSeguros.Controls.Add(Me.pbSeguros)
            Me.tpSeguros.Controls.Add(Me.txtFechaActual)
            Me.tpSeguros.Controls.Add(Me.dgvSeguros)
            Me.tpSeguros.Location = New System.Drawing.Point(4, 22)
            Me.tpSeguros.Name = "tpSeguros"
            Me.tpSeguros.Padding = New System.Windows.Forms.Padding(3)
            Me.tpSeguros.Size = New System.Drawing.Size(971, 454)
            Me.tpSeguros.TabIndex = 0
            Me.tpSeguros.Text = "SEGUROS"
            Me.tpSeguros.UseVisualStyleBackColor = True
            '
            'btnConsultar
            '
            Me.btnConsultar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
            Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnConsultar.Location = New System.Drawing.Point(144, 21)
            Me.btnConsultar.Name = "btnConsultar"
            Me.btnConsultar.Size = New System.Drawing.Size(86, 32)
            Me.btnConsultar.TabIndex = 11
            Me.btnConsultar.Text = "CONSULTAR"
            Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnConsultar.UseVisualStyleBackColor = True
            '
            'pbSeguros
            '
            Me.pbSeguros.Image = CType(resources.GetObject("pbSeguros.Image"), System.Drawing.Image)
            Me.pbSeguros.Location = New System.Drawing.Point(869, 6)
            Me.pbSeguros.Name = "pbSeguros"
            Me.pbSeguros.Size = New System.Drawing.Size(100, 47)
            Me.pbSeguros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbSeguros.TabIndex = 10
            Me.pbSeguros.TabStop = False
            '
            'txtFechaActual
            '
            Me.txtFechaActual.Enabled = False
            Me.txtFechaActual.Location = New System.Drawing.Point(23, 27)
            Me.txtFechaActual.Name = "txtFechaActual"
            Me.txtFechaActual.Size = New System.Drawing.Size(115, 20)
            Me.txtFechaActual.TabIndex = 9
            Me.txtFechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvSeguros
            '
            Me.dgvSeguros.AllowUserToAddRows = False
            Me.dgvSeguros.AllowUserToDeleteRows = False
            Me.dgvSeguros.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSeguros.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSeguros.BackgroundColor = System.Drawing.Color.White
            Me.dgvSeguros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSeguros.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSeguros.Location = New System.Drawing.Point(2, 59)
            Me.dgvSeguros.MultiSelect = False
            Me.dgvSeguros.Name = "dgvSeguros"
            Me.dgvSeguros.ReadOnly = True
            Me.dgvSeguros.RowHeadersVisible = False
            Me.dgvSeguros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSeguros.Size = New System.Drawing.Size(965, 392)
            Me.dgvSeguros.TabIndex = 8
            '
            'tpDispositivos
            '
            Me.tpDispositivos.Controls.Add(Me.Button1)
            Me.tpDispositivos.Controls.Add(Me.pbDispositivos)
            Me.tpDispositivos.Controls.Add(Me.txtFechaActualDispositivo)
            Me.tpDispositivos.Controls.Add(Me.dgvDispositivos)
            Me.tpDispositivos.Location = New System.Drawing.Point(4, 22)
            Me.tpDispositivos.Name = "tpDispositivos"
            Me.tpDispositivos.Padding = New System.Windows.Forms.Padding(3)
            Me.tpDispositivos.Size = New System.Drawing.Size(971, 454)
            Me.tpDispositivos.TabIndex = 1
            Me.tpDispositivos.Text = "DISPOSITIVOS SEGURIDAD"
            Me.tpDispositivos.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(142, 6)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(86, 35)
            Me.Button1.TabIndex = 15
            Me.Button1.Text = "CONSULTAR"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            '
            'pbDispositivos
            '
            Me.pbDispositivos.Image = CType(resources.GetObject("pbDispositivos.Image"), System.Drawing.Image)
            Me.pbDispositivos.Location = New System.Drawing.Point(902, 6)
            Me.pbDispositivos.Name = "pbDispositivos"
            Me.pbDispositivos.Size = New System.Drawing.Size(63, 50)
            Me.pbDispositivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pbDispositivos.TabIndex = 14
            Me.pbDispositivos.TabStop = False
            '
            'txtFechaActualDispositivo
            '
            Me.txtFechaActualDispositivo.Enabled = False
            Me.txtFechaActualDispositivo.Location = New System.Drawing.Point(21, 16)
            Me.txtFechaActualDispositivo.Name = "txtFechaActualDispositivo"
            Me.txtFechaActualDispositivo.Size = New System.Drawing.Size(115, 20)
            Me.txtFechaActualDispositivo.TabIndex = 13
            Me.txtFechaActualDispositivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'dgvDispositivos
            '
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDispositivos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvDispositivos.BackgroundColor = System.Drawing.Color.White
            Me.dgvDispositivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDispositivos.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvDispositivos.GridColor = System.Drawing.SystemColors.AppWorkspace
            Me.dgvDispositivos.Location = New System.Drawing.Point(3, 62)
            Me.dgvDispositivos.MultiSelect = False
            Me.dgvDispositivos.Name = "dgvDispositivos"
            Me.dgvDispositivos.ReadOnly = True
            Me.dgvDispositivos.RowHeadersVisible = False
            Me.dgvDispositivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDispositivos.Size = New System.Drawing.Size(966, 389)
            Me.dgvDispositivos.TabIndex = 12
            '
            'FormConsultarProximosSegurosVencidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(978, 481)
            Me.Controls.Add(Me.tcSeguros)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultarProximosSegurosVencidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTAR SEGUROS Y DISPOSITIVOS DE SEGURIDAD VENCIDOS"
            Me.tcSeguros.ResumeLayout(False)
            Me.tpSeguros.ResumeLayout(False)
            Me.tpSeguros.PerformLayout()
            CType(Me.pbSeguros, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvSeguros, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tpDispositivos.ResumeLayout(False)
            Me.tpDispositivos.PerformLayout()
            CType(Me.pbDispositivos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDispositivos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents tcSeguros As System.Windows.Forms.TabControl
        Friend WithEvents tpSeguros As System.Windows.Forms.TabPage
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
        Friend WithEvents pbSeguros As System.Windows.Forms.PictureBox
        Friend WithEvents txtFechaActual As System.Windows.Forms.TextBox
        Friend WithEvents dgvSeguros As System.Windows.Forms.DataGridView
        Friend WithEvents tpDispositivos As System.Windows.Forms.TabPage
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents pbDispositivos As System.Windows.Forms.PictureBox
        Friend WithEvents txtFechaActualDispositivo As System.Windows.Forms.TextBox
        Friend WithEvents dgvDispositivos As System.Windows.Forms.DataGridView
    End Class
End Namespace