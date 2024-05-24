Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormConsultaTransferencias
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaTransferencias))
            Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
            Me.rbFecha = New System.Windows.Forms.RadioButton()
            Me.rbTodas = New System.Windows.Forms.RadioButton()
            Me.dgvConsulta = New System.Windows.Forms.DataGridView()
            Me.txtParametroBusqueda = New System.Windows.Forms.TextBox()
            Me.rbCustodioAnterior = New System.Windows.Forms.RadioButton()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
            Me.rbCustodioNuevo = New System.Windows.Forms.RadioButton()
            CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpFechaInicial
            '
            Me.dtpFechaInicial.CustomFormat = ""
            Me.dtpFechaInicial.Location = New System.Drawing.Point(81, 26)
            Me.dtpFechaInicial.Name = "dtpFechaInicial"
            Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
            Me.dtpFechaInicial.TabIndex = 0
            Me.dtpFechaInicial.Value = New Date(2012, 6, 18, 0, 0, 0, 0)
            '
            'rbFecha
            '
            Me.rbFecha.AutoSize = True
            Me.rbFecha.Location = New System.Drawing.Point(12, 26)
            Me.rbFecha.Name = "rbFecha"
            Me.rbFecha.Size = New System.Drawing.Size(63, 17)
            Me.rbFecha.TabIndex = 1
            Me.rbFecha.TabStop = True
            Me.rbFecha.Text = "FECHA:"
            Me.rbFecha.UseVisualStyleBackColor = True
            '
            'rbTodas
            '
            Me.rbTodas.AutoSize = True
            Me.rbTodas.Location = New System.Drawing.Point(494, 36)
            Me.rbTodas.Name = "rbTodas"
            Me.rbTodas.Size = New System.Drawing.Size(62, 17)
            Me.rbTodas.TabIndex = 2
            Me.rbTodas.TabStop = True
            Me.rbTodas.Text = "TODAS"
            Me.rbTodas.UseVisualStyleBackColor = True
            '
            'dgvConsulta
            '
            Me.dgvConsulta.AllowUserToAddRows = False
            Me.dgvConsulta.AllowUserToDeleteRows = False
            Me.dgvConsulta.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvConsulta.BackgroundColor = System.Drawing.Color.White
            Me.dgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvConsulta.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvConsulta.Location = New System.Drawing.Point(1, 60)
            Me.dgvConsulta.MultiSelect = False
            Me.dgvConsulta.Name = "dgvConsulta"
            Me.dgvConsulta.ReadOnly = True
            Me.dgvConsulta.RowHeadersVisible = False
            Me.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvConsulta.Size = New System.Drawing.Size(1012, 500)
            Me.dgvConsulta.TabIndex = 3
            '
            'txtParametroBusqueda
            '
            Me.txtParametroBusqueda.Location = New System.Drawing.Point(640, 22)
            Me.txtParametroBusqueda.Name = "txtParametroBusqueda"
            Me.txtParametroBusqueda.Size = New System.Drawing.Size(267, 20)
            Me.txtParametroBusqueda.TabIndex = 4
            '
            'rbCustodioAnterior
            '
            Me.rbCustodioAnterior.AutoSize = True
            Me.rbCustodioAnterior.Location = New System.Drawing.Point(494, 6)
            Me.rbCustodioAnterior.Name = "rbCustodioAnterior"
            Me.rbCustodioAnterior.Size = New System.Drawing.Size(140, 17)
            Me.rbCustodioAnterior.TabIndex = 5
            Me.rbCustodioAnterior.TabStop = True
            Me.rbCustodioAnterior.Text = "CUSTODIO ANTERIOR"
            Me.rbCustodioAnterior.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(927, 12)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(75, 39)
            Me.btnBuscar.TabIndex = 6
            Me.btnBuscar.Text = "BUSCAR"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.CustomFormat = ""
            Me.dtpFechaFinal.Location = New System.Drawing.Point(287, 26)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
            Me.dtpFechaFinal.TabIndex = 7
            Me.dtpFechaFinal.Value = New Date(2012, 6, 18, 0, 0, 0, 0)
            '
            'rbCustodioNuevo
            '
            Me.rbCustodioNuevo.AutoSize = True
            Me.rbCustodioNuevo.Location = New System.Drawing.Point(494, 21)
            Me.rbCustodioNuevo.Name = "rbCustodioNuevo"
            Me.rbCustodioNuevo.Size = New System.Drawing.Size(122, 17)
            Me.rbCustodioNuevo.TabIndex = 8
            Me.rbCustodioNuevo.TabStop = True
            Me.rbCustodioNuevo.Text = "CUSTODIO NUEVO"
            Me.rbCustodioNuevo.UseVisualStyleBackColor = True
            '
            'FormConsultaTransferencias
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1014, 563)
            Me.Controls.Add(Me.rbCustodioNuevo)
            Me.Controls.Add(Me.dtpFechaFinal)
            Me.Controls.Add(Me.btnBuscar)
            Me.Controls.Add(Me.rbCustodioAnterior)
            Me.Controls.Add(Me.txtParametroBusqueda)
            Me.Controls.Add(Me.dgvConsulta)
            Me.Controls.Add(Me.rbTodas)
            Me.Controls.Add(Me.rbFecha)
            Me.Controls.Add(Me.dtpFechaInicial)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormConsultaTransferencias"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTA DE TRANSFERENCIAS DE ACTIVOS FIJOS"
            CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
        Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
        Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
        Friend WithEvents txtParametroBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents rbCustodioAnterior As System.Windows.Forms.RadioButton
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents rbCustodioNuevo As System.Windows.Forms.RadioButton
    End Class
End Namespace