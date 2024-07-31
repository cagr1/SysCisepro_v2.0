Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRotacionVehiculos
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRotacionVehiculos))
            Me.gbSupervisores = New System.Windows.Forms.GroupBox()
            Me.dgvPersonal = New System.Windows.Forms.DataGridView()
            Me.gbVehiculos = New System.Windows.Forms.GroupBox()
            Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtFechaRotacion = New System.Windows.Forms.TextBox()
            Me.gbRotaciones = New System.Windows.Forms.GroupBox()
            Me.dgvRotaciones = New System.Windows.Forms.DataGridView()
            Me.ID_ROTACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.NOMBRE_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CUSTODIO_NUEVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUSTODIO_NUEVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ID_CUSTODIO_ANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CUSTODIO_ANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OBSERVACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtIdRotacion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gbSupervisores.SuspendLayout()
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbVehiculos.SuspendLayout()
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRotaciones.SuspendLayout()
            CType(Me.dgvRotaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbSupervisores
            '
            Me.gbSupervisores.Controls.Add(Me.dgvPersonal)
            Me.gbSupervisores.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSupervisores.Location = New System.Drawing.Point(5, 4)
            Me.gbSupervisores.Name = "gbSupervisores"
            Me.gbSupervisores.Size = New System.Drawing.Size(786, 152)
            Me.gbSupervisores.TabIndex = 1
            Me.gbSupervisores.TabStop = False
            Me.gbSupervisores.Text = "SUPERVISORES"
            '
            'dgvPersonal
            '
            Me.dgvPersonal.AllowUserToAddRows = False
            Me.dgvPersonal.AllowUserToDeleteRows = False
            Me.dgvPersonal.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPersonal.BackgroundColor = System.Drawing.Color.White
            Me.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPersonal.Location = New System.Drawing.Point(6, 19)
            Me.dgvPersonal.MultiSelect = False
            Me.dgvPersonal.Name = "dgvPersonal"
            Me.dgvPersonal.RowHeadersVisible = False
            Me.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPersonal.Size = New System.Drawing.Size(771, 128)
            Me.dgvPersonal.TabIndex = 1
            '
            'gbVehiculos
            '
            Me.gbVehiculos.Controls.Add(Me.dgvVehiculos)
            Me.gbVehiculos.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbVehiculos.Location = New System.Drawing.Point(5, 155)
            Me.gbVehiculos.Name = "gbVehiculos"
            Me.gbVehiculos.Size = New System.Drawing.Size(786, 141)
            Me.gbVehiculos.TabIndex = 2
            Me.gbVehiculos.TabStop = False
            Me.gbVehiculos.Text = "VEHICULOS"
            '
            'dgvVehiculos
            '
            Me.dgvVehiculos.AllowUserToAddRows = False
            Me.dgvVehiculos.AllowUserToDeleteRows = False
            Me.dgvVehiculos.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvVehiculos.BackgroundColor = System.Drawing.Color.White
            Me.dgvVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvVehiculos.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvVehiculos.Location = New System.Drawing.Point(6, 19)
            Me.dgvVehiculos.MultiSelect = False
            Me.dgvVehiculos.Name = "dgvVehiculos"
            Me.dgvVehiculos.RowHeadersVisible = False
            Me.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvVehiculos.Size = New System.Drawing.Size(771, 116)
            Me.dgvVehiculos.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(511, 304)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(118, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "FECHA DE ROTACIÓN:"
            '
            'txtFechaRotacion
            '
            Me.txtFechaRotacion.Enabled = False
            Me.txtFechaRotacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaRotacion.Location = New System.Drawing.Point(650, 301)
            Me.txtFechaRotacion.Name = "txtFechaRotacion"
            Me.txtFechaRotacion.Size = New System.Drawing.Size(132, 21)
            Me.txtFechaRotacion.TabIndex = 4
            '
            'gbRotaciones
            '
            Me.gbRotaciones.Controls.Add(Me.dgvRotaciones)
            Me.gbRotaciones.Location = New System.Drawing.Point(5, 358)
            Me.gbRotaciones.Name = "gbRotaciones"
            Me.gbRotaciones.Size = New System.Drawing.Size(786, 229)
            Me.gbRotaciones.TabIndex = 3
            Me.gbRotaciones.TabStop = False
            Me.gbRotaciones.Text = "ROTACIONES"
            '
            'dgvRotaciones
            '
            Me.dgvRotaciones.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRotaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvRotaciones.BackgroundColor = System.Drawing.Color.White
            Me.dgvRotaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRotaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ROTACION, Me.ID_ACTIVO, Me.NOMBRE_ACTIVO, Me.FECHA, Me.ID_CUSTODIO_NUEVO, Me.CUSTODIO_NUEVO, Me.ID_CUSTODIO_ANTERIOR, Me.CUSTODIO_ANTERIOR, Me.OBSERVACION})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRotaciones.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgvRotaciones.Location = New System.Drawing.Point(6, 19)
            Me.dgvRotaciones.MultiSelect = False
            Me.dgvRotaciones.Name = "dgvRotaciones"
            Me.dgvRotaciones.RowHeadersVisible = False
            Me.dgvRotaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRotaciones.Size = New System.Drawing.Size(771, 204)
            Me.dgvRotaciones.TabIndex = 1
            '
            'ID_ROTACION
            '
            Me.ID_ROTACION.HeaderText = "ID_ROTACION"
            Me.ID_ROTACION.Name = "ID_ROTACION"
            '
            'ID_ACTIVO
            '
            Me.ID_ACTIVO.HeaderText = "ID_ACTIVO"
            Me.ID_ACTIVO.Name = "ID_ACTIVO"
            '
            'NOMBRE_ACTIVO
            '
            Me.NOMBRE_ACTIVO.HeaderText = "NOMBRE_ACTIVO"
            Me.NOMBRE_ACTIVO.Name = "NOMBRE_ACTIVO"
            Me.NOMBRE_ACTIVO.Width = 500
            '
            'FECHA
            '
            Me.FECHA.HeaderText = "FECHA"
            Me.FECHA.Name = "FECHA"
            '
            'ID_CUSTODIO_NUEVO
            '
            Me.ID_CUSTODIO_NUEVO.HeaderText = "ID_CUSTODIO_NUEVO"
            Me.ID_CUSTODIO_NUEVO.Name = "ID_CUSTODIO_NUEVO"
            Me.ID_CUSTODIO_NUEVO.Width = 150
            '
            'CUSTODIO_NUEVO
            '
            Me.CUSTODIO_NUEVO.HeaderText = "CUSTODIO_NUEVO"
            Me.CUSTODIO_NUEVO.Name = "CUSTODIO_NUEVO"
            Me.CUSTODIO_NUEVO.Width = 500
            '
            'ID_CUSTODIO_ANTERIOR
            '
            Me.ID_CUSTODIO_ANTERIOR.HeaderText = "ID_CUSTODIO_ANTERIOR"
            Me.ID_CUSTODIO_ANTERIOR.Name = "ID_CUSTODIO_ANTERIOR"
            Me.ID_CUSTODIO_ANTERIOR.Width = 150
            '
            'CUSTODIO_ANTERIOR
            '
            Me.CUSTODIO_ANTERIOR.HeaderText = "CUSTODIO_ANTERIOR"
            Me.CUSTODIO_ANTERIOR.Name = "CUSTODIO_ANTERIOR"
            Me.CUSTODIO_ANTERIOR.Width = 500
            '
            'OBSERVACION
            '
            Me.OBSERVACION.HeaderText = "OBSERVACION"
            Me.OBSERVACION.Name = "OBSERVACION"
            Me.OBSERVACION.Width = 200
            '
            'btnAgregar
            '
            Me.btnAgregar.Enabled = False
            Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Image = Global.syscisepro.My.Resources.Resources.add_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnAgregar.Location = New System.Drawing.Point(694, 329)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(41, 30)
            Me.btnAgregar.TabIndex = 5
            Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar")
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'txtObservacion
            '
            Me.txtObservacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(101, 338)
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.Size = New System.Drawing.Size(397, 21)
            Me.txtObservacion.TabIndex = 7
            Me.txtObservacion.Text = "NINGUNA"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(8, 338)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(85, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "OBSERVACIÓN:"
            '
            'txtIdRotacion
            '
            Me.txtIdRotacion.Enabled = False
            Me.txtIdRotacion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRotacion.Location = New System.Drawing.Point(94, 304)
            Me.txtIdRotacion.Name = "txtIdRotacion"
            Me.txtIdRotacion.Size = New System.Drawing.Size(86, 21)
            Me.txtIdRotacion.TabIndex = 9
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(8, 307)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(78, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "ID ROTACIÓN:"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.Location = New System.Drawing.Point(647, 329)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(41, 30)
            Me.btnNuevo.TabIndex = 10
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.Location = New System.Drawing.Point(741, 329)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(41, 30)
            Me.btnGuardar.TabIndex = 11
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
            Me.btnGuardar.UseVisualStyleBackColor = True
            '
            'FormRotacionVehiculos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(794, 589)
            Me.Controls.Add(Me.btnGuardar)
            Me.Controls.Add(Me.btnNuevo)
            Me.Controls.Add(Me.txtIdRotacion)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtObservacion)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.btnAgregar)
            Me.Controls.Add(Me.gbRotaciones)
            Me.Controls.Add(Me.txtFechaRotacion)
            Me.Controls.Add(Me.gbVehiculos)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.gbSupervisores)
            Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormRotacionVehiculos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ROTACION DE VEHÍCULOS"
            Me.gbSupervisores.ResumeLayout(False)
            CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbVehiculos.ResumeLayout(False)
            CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRotaciones.ResumeLayout(False)
            CType(Me.dgvRotaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbSupervisores As System.Windows.Forms.GroupBox
        Friend WithEvents dgvPersonal As System.Windows.Forms.DataGridView
        Friend WithEvents gbVehiculos As System.Windows.Forms.GroupBox
        Friend WithEvents dgvVehiculos As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtFechaRotacion As System.Windows.Forms.TextBox
        Friend WithEvents gbRotaciones As System.Windows.Forms.GroupBox
        Friend WithEvents dgvRotaciones As System.Windows.Forms.DataGridView
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents ID_ROTACION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents NOMBRE_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CUSTODIO_NUEVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUSTODIO_NUEVO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents ID_CUSTODIO_ANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents CUSTODIO_ANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents OBSERVACION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtIdRotacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As ToolTip
    End Class
End Namespace