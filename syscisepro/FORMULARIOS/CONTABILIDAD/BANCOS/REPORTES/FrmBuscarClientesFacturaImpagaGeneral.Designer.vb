Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmBuscarClientesFacturaImpagaGeneral
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
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarClientesFacturaImpagaGeneral))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtParametrobusqueda = New System.Windows.Forms.TextBox()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dgvDebitos = New System.Windows.Forms.DataGridView()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Button1 = New System.Windows.Forms.Button()
            CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(519, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 14)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "BUSCAR:"
            '
            'txtParametrobusqueda
            '
            Me.txtParametrobusqueda.BackColor = System.Drawing.Color.White
            Me.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtParametrobusqueda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.txtParametrobusqueda.Location = New System.Drawing.Point(573, 2)
            Me.txtParametrobusqueda.Name = "txtParametrobusqueda"
            Me.txtParametrobusqueda.Size = New System.Drawing.Size(361, 23)
            Me.txtParametrobusqueda.TabIndex = 10
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaDesde.Location = New System.Drawing.Point(55, 2)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(170, 22)
            Me.dtpFechaDesde.TabIndex = 36
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(5, 5)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 14)
            Me.Label2.TabIndex = 37
            Me.Label2.Text = "DESDE:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(243, 5)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 14)
            Me.Label3.TabIndex = 39
            Me.Label3.Text = "HASTA:"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.CustomFormat = "dddd, dd-MMM-yyyy"
            Me.dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaHasta.Location = New System.Drawing.Point(285, 2)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(170, 22)
            Me.dtpFechaHasta.TabIndex = 38
            '
            'dgvDebitos
            '
            Me.dgvDebitos.AllowUserToAddRows = False
            Me.dgvDebitos.AllowUserToDeleteRows = False
            Me.dgvDebitos.AllowUserToOrderColumns = True
            Me.dgvDebitos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDebitos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDebitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgvDebitos.BackgroundColor = System.Drawing.Color.White
            Me.dgvDebitos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDebitos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvDebitos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDebitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column13, Me.Column14, Me.Column9, Me.Column15, Me.Column16})
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDebitos.DefaultCellStyle = DataGridViewCellStyle8
            Me.dgvDebitos.GridColor = System.Drawing.Color.LightSteelBlue
            Me.dgvDebitos.Location = New System.Drawing.Point(0, 25)
            Me.dgvDebitos.Name = "dgvDebitos"
            Me.dgvDebitos.ReadOnly = True
            Me.dgvDebitos.RowHeadersVisible = False
            Me.dgvDebitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDebitos.Size = New System.Drawing.Size(1027, 311)
            Me.dgvDebitos.TabIndex = 186
            '
            'Column11
            '
            Me.Column11.Frozen = True
            Me.Column11.HeaderText = "ID"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.Width = 60
            '
            'Column12
            '
            Me.Column12.Frozen = True
            Me.Column12.HeaderText = "Cliente"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.Width = 200
            '
            'Column3
            '
            Me.Column3.HeaderText = "Ordenante"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 230
            '
            'Column1
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
            Me.Column1.HeaderText = "Tipo Doc."
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column1.Width = 90
            '
            'Column2
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
            Me.Column2.HeaderText = "CI / RUC"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 90
            '
            'Column4
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
            Me.Column4.HeaderText = "Contrato"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            '
            'Column5
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
            Me.Column5.HeaderText = "Forma Pg/Cb"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            '
            'Column6
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
            Me.Column6.HeaderText = "Banco"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            '
            'Column7
            '
            Me.Column7.HeaderText = "Tipo Cta"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            '
            'Column8
            '
            Me.Column8.HeaderText = "N° Cta"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            '
            'Column10
            '
            Me.Column10.HeaderText = "Motivo"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.Column10.Width = 150
            '
            'Column13
            '
            Me.Column13.HeaderText = "ID Fact"
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            Me.Column13.Visible = False
            Me.Column13.Width = 70
            '
            'Column14
            '
            Me.Column14.HeaderText = "Num Fac"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Visible = False
            Me.Column14.Width = 80
            '
            'Column9
            '
            Me.Column9.HeaderText = "TOTAL FACTURA"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            '
            'Column15
            '
            Me.Column15.HeaderText = "SALDO FACTURA"
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            '
            'Column16
            '
            Me.Column16.HeaderText = "VALOR CONVENIO"
            Me.Column16.Name = "Column16"
            Me.Column16.ReadOnly = True
            '
            'Button1
            '
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.Image = Global.syscisepro.My.Resources.Resources.application_go
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.Location = New System.Drawing.Point(940, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(84, 26)
            Me.Button1.TabIndex = 187
            Me.Button1.Text = "ENVIAR"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            '
            'FrmBuscarClientesFacturaImpagaGeneral
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1027, 336)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.dgvDebitos)
            Me.Controls.Add(Me.dtpFechaHasta)
            Me.Controls.Add(Me.dtpFechaDesde)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtParametrobusqueda)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmBuscarClientesFacturaImpagaGeneral"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CLIENTE (Seleccione uno o varios)"
            CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtParametrobusqueda As System.Windows.Forms.TextBox
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dgvDebitos As System.Windows.Forms.DataGridView
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace