Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAprovacionRequisicion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAprovacionRequisicion))
            Me.dgvRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.txtPrioridadEntregaRequisicion = New System.Windows.Forms.TextBox()
            Me.txtIdRequisicionProductoServicio = New System.Windows.Forms.TextBox()
            Me.txtTiempoEntregaRequisicion = New System.Windows.Forms.TextBox()
            Me.txtFechaRequisicionProducto = New System.Windows.Forms.TextBox()
            Me.txtNombrePersonal = New System.Windows.Forms.TextBox()
            Me.dgvDetalleRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprovar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnRechazar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvRequisicionProductoServicio
            '
            Me.dgvRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvRequisicionProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRequisicionProductoServicio.Location = New System.Drawing.Point(2, 37)
            Me.dgvRequisicionProductoServicio.Name = "dgvRequisicionProductoServicio"
            Me.dgvRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequisicionProductoServicio.Size = New System.Drawing.Size(535, 119)
            Me.dgvRequisicionProductoServicio.TabIndex = 0
            '
            'txtPrioridadEntregaRequisicion
            '
            Me.txtPrioridadEntregaRequisicion.BackColor = System.Drawing.Color.White
            Me.txtPrioridadEntregaRequisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrioridadEntregaRequisicion.Enabled = False
            Me.txtPrioridadEntregaRequisicion.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrioridadEntregaRequisicion.Location = New System.Drawing.Point(82, 59)
            Me.txtPrioridadEntregaRequisicion.Name = "txtPrioridadEntregaRequisicion"
            Me.txtPrioridadEntregaRequisicion.Size = New System.Drawing.Size(112, 22)
            Me.txtPrioridadEntregaRequisicion.TabIndex = 25
            '
            'txtIdRequisicionProductoServicio
            '
            Me.txtIdRequisicionProductoServicio.BackColor = System.Drawing.Color.White
            Me.txtIdRequisicionProductoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRequisicionProductoServicio.Enabled = False
            Me.txtIdRequisicionProductoServicio.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRequisicionProductoServicio.Location = New System.Drawing.Point(82, 3)
            Me.txtIdRequisicionProductoServicio.Name = "txtIdRequisicionProductoServicio"
            Me.txtIdRequisicionProductoServicio.Size = New System.Drawing.Size(58, 22)
            Me.txtIdRequisicionProductoServicio.TabIndex = 23
            '
            'txtTiempoEntregaRequisicion
            '
            Me.txtTiempoEntregaRequisicion.BackColor = System.Drawing.Color.White
            Me.txtTiempoEntregaRequisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTiempoEntregaRequisicion.Enabled = False
            Me.txtTiempoEntregaRequisicion.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTiempoEntregaRequisicion.Location = New System.Drawing.Point(261, 61)
            Me.txtTiempoEntregaRequisicion.Name = "txtTiempoEntregaRequisicion"
            Me.txtTiempoEntregaRequisicion.Size = New System.Drawing.Size(99, 22)
            Me.txtTiempoEntregaRequisicion.TabIndex = 20
            '
            'txtFechaRequisicionProducto
            '
            Me.txtFechaRequisicionProducto.BackColor = System.Drawing.Color.White
            Me.txtFechaRequisicionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaRequisicionProducto.Enabled = False
            Me.txtFechaRequisicionProducto.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaRequisicionProducto.Location = New System.Drawing.Point(261, 5)
            Me.txtFechaRequisicionProducto.Name = "txtFechaRequisicionProducto"
            Me.txtFechaRequisicionProducto.Size = New System.Drawing.Size(99, 22)
            Me.txtFechaRequisicionProducto.TabIndex = 15
            '
            'txtNombrePersonal
            '
            Me.txtNombrePersonal.BackColor = System.Drawing.Color.White
            Me.txtNombrePersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombrePersonal.Enabled = False
            Me.txtNombrePersonal.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombrePersonal.Location = New System.Drawing.Point(82, 31)
            Me.txtNombrePersonal.Name = "txtNombrePersonal"
            Me.txtNombrePersonal.Size = New System.Drawing.Size(278, 22)
            Me.txtNombrePersonal.TabIndex = 17
            '
            'dgvDetalleRequisicionProductoServicio
            '
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleRequisicionProductoServicio.Location = New System.Drawing.Point(2, 162)
            Me.dgvDetalleRequisicionProductoServicio.Name = "dgvDetalleRequisicionProductoServicio"
            Me.dgvDetalleRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvDetalleRequisicionProductoServicio.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Roboto", 8.25!)
            Me.dgvDetalleRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionProductoServicio.Size = New System.Drawing.Size(919, 328)
            Me.dgvDetalleRequisicionProductoServicio.TabIndex = 2
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRecargar, Me.btnAprovar, Me.btnRechazar, Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(923, 32)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnRecargar
            '
            Me.btnRecargar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(85, 28)
            Me.btnRecargar.Text = "BUSCAR"
            '
            'btnAprovar
            '
            Me.btnAprovar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprovar.Image = Global.syscisepro.My.Resources.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAprovar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAprovar.Name = "btnAprovar"
            Me.btnAprovar.Size = New System.Drawing.Size(92, 28)
            Me.btnAprovar.Text = "APROBAR"
            '
            'btnRechazar
            '
            Me.btnRechazar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRechazar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnRechazar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRechazar.Name = "btnRechazar"
            Me.btnRechazar.Size = New System.Drawing.Size(98, 28)
            Me.btnRechazar.Text = "RECHAZAR"
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(103, 28)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(543, 37)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtTiempoEntregaRequisicion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtPrioridadEntregaRequisicion)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdRequisicionProductoServicio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaRequisicionProducto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombrePersonal)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(378, 121)
            Me.KryptonGroupBox1.TabIndex = 185
            Me.KryptonGroupBox1.Values.Heading = "Datos "
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(200, 61)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(52, 20)
            Me.KryptonLabel5.TabIndex = 27
            Me.KryptonLabel5.Values.Text = "Entrega"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(3, 59)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel4.TabIndex = 26
            Me.KryptonLabel4.Values.Text = "Prioridad"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(3, 33)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel3.TabIndex = 25
            Me.KryptonLabel3.Values.Text = "Realizado"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(210, 3)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 24
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(80, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Req Numero"
            '
            'FormAprovacionRequisicion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(923, 496)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvDetalleRequisicionProductoServicio)
            Me.Controls.Add(Me.dgvRequisicionProductoServicio)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAprovacionRequisicion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "APROBACIÓN DE REQUISICIÓN DE PRODUCTO/SERVICIO"
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents txtIdRequisicionProductoServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtTiempoEntregaRequisicion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaRequisicionProducto As System.Windows.Forms.TextBox
        Friend WithEvents txtNombrePersonal As System.Windows.Forms.TextBox
        Friend WithEvents dgvDetalleRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents txtPrioridadEntregaRequisicion As System.Windows.Forms.TextBox
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAprovar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRechazar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRecargar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel5 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
    End Class
End Namespace