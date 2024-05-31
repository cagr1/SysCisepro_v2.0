Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormHistorialSegurosVehiculos
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHistorialSegurosVehiculos))
            Me.dgvHistorial = New System.Windows.Forms.DataGridView()
            Me.cbmVehiculos = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblIdActivo = New System.Windows.Forms.Label()
            Me.btnFiltrar = New System.Windows.Forms.Button()
            CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvHistorial
            '
            Me.dgvHistorial.AllowUserToAddRows = False
            Me.dgvHistorial.AllowUserToDeleteRows = False
            Me.dgvHistorial.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvHistorial.BackgroundColor = System.Drawing.Color.White
            Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvHistorial.Location = New System.Drawing.Point(2, 44)
            Me.dgvHistorial.MultiSelect = False
            Me.dgvHistorial.Name = "dgvHistorial"
            Me.dgvHistorial.ReadOnly = True
            Me.dgvHistorial.RowHeadersVisible = False
            Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHistorial.Size = New System.Drawing.Size(988, 368)
            Me.dgvHistorial.TabIndex = 0
            '
            'cbmVehiculos
            '
            Me.cbmVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmVehiculos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmVehiculos.FormattingEnabled = True
            Me.cbmVehiculos.Location = New System.Drawing.Point(81, 12)
            Me.cbmVehiculos.Name = "cbmVehiculos"
            Me.cbmVehiculos.Size = New System.Drawing.Size(361, 21)
            Me.cbmVehiculos.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(7, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "VEHICULOS"
            '
            'lblIdActivo
            '
            Me.lblIdActivo.AutoSize = True
            Me.lblIdActivo.Location = New System.Drawing.Point(415, 18)
            Me.lblIdActivo.Name = "lblIdActivo"
            Me.lblIdActivo.Size = New System.Drawing.Size(25, 13)
            Me.lblIdActivo.TabIndex = 3
            Me.lblIdActivo.Text = "000"
            Me.lblIdActivo.Visible = False
            '
            'btnFiltrar
            '
            Me.btnFiltrar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
            Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnFiltrar.Location = New System.Drawing.Point(448, 3)
            Me.btnFiltrar.Name = "btnFiltrar"
            Me.btnFiltrar.Size = New System.Drawing.Size(60, 39)
            Me.btnFiltrar.TabIndex = 4
            Me.btnFiltrar.Text = "FILTRAR"
            Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFiltrar.UseVisualStyleBackColor = True
            '
            'FormHistorialSegurosVehiculos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(992, 415)
            Me.Controls.Add(Me.btnFiltrar)
            Me.Controls.Add(Me.lblIdActivo)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cbmVehiculos)
            Me.Controls.Add(Me.dgvHistorial)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormHistorialSegurosVehiculos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HISTORIAL DE SEGUROS DE VEHÍCULOS"
            CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvHistorial As System.Windows.Forms.DataGridView
        Friend WithEvents cbmVehiculos As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblIdActivo As System.Windows.Forms.Label
        Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    End Class
End Namespace