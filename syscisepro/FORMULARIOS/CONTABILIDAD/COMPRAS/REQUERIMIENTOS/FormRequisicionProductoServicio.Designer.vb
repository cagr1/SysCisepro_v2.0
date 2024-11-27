Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRequisicionProductoServicio
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRequisicionProductoServicio))
            Me.txtIdRequisicionProductoServicio = New System.Windows.Forms.TextBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtEntregaNumeroDias = New System.Windows.Forms.TextBox()
            Me.rbEntregaNormal = New System.Windows.Forms.RadioButton()
            Me.rbEntregaUrgente = New System.Windows.Forms.RadioButton()
            Me.txtNombrePersonal = New System.Windows.Forms.TextBox()
            Me.txtFechaRequisicionProducto = New System.Windows.Forms.TextBox()
            Me.lblIdPersonal = New System.Windows.Forms.Label()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.KryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
            Me.KryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
            Me.dgvDetalleRequisicionPS = New System.Windows.Forms.DataGridView()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.especificacionProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.observacionesProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.panelDetalle.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox2.Panel.SuspendLayout()
            Me.KryptonGroupBox2.SuspendLayout()
            CType(Me.dgvDetalleRequisicionPS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtIdRequisicionProductoServicio
            '
            Me.txtIdRequisicionProductoServicio.BackColor = System.Drawing.Color.White
            Me.txtIdRequisicionProductoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRequisicionProductoServicio.Location = New System.Drawing.Point(51, 5)
            Me.txtIdRequisicionProductoServicio.Name = "txtIdRequisicionProductoServicio"
            Me.txtIdRequisicionProductoServicio.Size = New System.Drawing.Size(42, 22)
            Me.txtIdRequisicionProductoServicio.TabIndex = 13
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnBuscarPersonal.FlatAppearance.BorderSize = 0
            Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(722, 3)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(26, 26)
            Me.btnBuscarPersonal.TabIndex = 4
            Me.btnBuscarPersonal.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtEntregaNumeroDias
            '
            Me.txtEntregaNumeroDias.BackColor = System.Drawing.Color.White
            Me.txtEntregaNumeroDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEntregaNumeroDias.Location = New System.Drawing.Point(356, 30)
            Me.txtEntregaNumeroDias.Name = "txtEntregaNumeroDias"
            Me.txtEntregaNumeroDias.Size = New System.Drawing.Size(32, 22)
            Me.txtEntregaNumeroDias.TabIndex = 10
            '
            'rbEntregaNormal
            '
            Me.rbEntregaNormal.AutoSize = True
            Me.rbEntregaNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbEntregaNormal.Checked = True
            Me.rbEntregaNormal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEntregaNormal.Location = New System.Drawing.Point(160, 31)
            Me.rbEntregaNormal.Name = "rbEntregaNormal"
            Me.rbEntregaNormal.Size = New System.Drawing.Size(105, 17)
            Me.rbEntregaNormal.TabIndex = 8
            Me.rbEntregaNormal.TabStop = True
            Me.rbEntregaNormal.Text = "Entrega Normal"
            Me.rbEntregaNormal.UseVisualStyleBackColor = False
            '
            'rbEntregaUrgente
            '
            Me.rbEntregaUrgente.AutoSize = True
            Me.rbEntregaUrgente.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.rbEntregaUrgente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
            Me.rbEntregaUrgente.Location = New System.Drawing.Point(8, 30)
            Me.rbEntregaUrgente.Name = "rbEntregaUrgente"
            Me.rbEntregaUrgente.Size = New System.Drawing.Size(110, 17)
            Me.rbEntregaUrgente.TabIndex = 7
            Me.rbEntregaUrgente.Text = "Entrega Urgente"
            Me.rbEntregaUrgente.UseVisualStyleBackColor = False
            '
            'txtNombrePersonal
            '
            Me.txtNombrePersonal.BackColor = System.Drawing.Color.White
            Me.txtNombrePersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombrePersonal.Location = New System.Drawing.Point(356, 5)
            Me.txtNombrePersonal.Name = "txtNombrePersonal"
            Me.txtNombrePersonal.Size = New System.Drawing.Size(359, 22)
            Me.txtNombrePersonal.TabIndex = 3
            '
            'txtFechaRequisicionProducto
            '
            Me.txtFechaRequisicionProducto.BackColor = System.Drawing.Color.White
            Me.txtFechaRequisicionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaRequisicionProducto.Location = New System.Drawing.Point(160, 4)
            Me.txtFechaRequisicionProducto.Name = "txtFechaRequisicionProducto"
            Me.txtFechaRequisicionProducto.Size = New System.Drawing.Size(118, 22)
            Me.txtFechaRequisicionProducto.TabIndex = 1
            '
            'lblIdPersonal
            '
            Me.lblIdPersonal.AutoSize = True
            Me.lblIdPersonal.Location = New System.Drawing.Point(726, 11)
            Me.lblIdPersonal.Name = "lblIdPersonal"
            Me.lblIdPersonal.Size = New System.Drawing.Size(19, 13)
            Me.lblIdPersonal.TabIndex = 5
            Me.lblIdPersonal.Text = "00"
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(723, 136)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(27, 27)
            Me.btnEliminar.TabIndex = 3
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'panelDetalle
            '
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(2, 251)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(704, 26)
            Me.panelDetalle.TabIndex = 37
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(267, 5)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(192, 18)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "DETALLE ORDEN DE COMPRA"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(763, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(97, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(103, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionOverlap = 0R
            Me.KryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(2, 35)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtEntregaNumeroDias)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbEntregaNormal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.rbEntregaUrgente)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblIdPersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdRequisicionProductoServicio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombrePersonal)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtFechaRequisicionProducto)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(761, 86)
            Me.KryptonGroupBox1.TabIndex = 188
            Me.KryptonGroupBox1.Values.Heading = "Datos"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(291, 27)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(40, 20)
            Me.KryptonLabel4.TabIndex = 16
            Me.KryptonLabel4.Values.Text = "Plazo"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(291, 6)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel3.TabIndex = 15
            Me.KryptonLabel3.Values.Text = "Realizado"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(110, 4)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(42, 20)
            Me.KryptonLabel2.TabIndex = 14
            Me.KryptonLabel2.Values.Text = "Fecha"
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 6)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(27, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "No"
            '
            'KryptonGroupBox2
            '
            Me.KryptonGroupBox2.CaptionOverlap = 0R
            Me.KryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon
            Me.KryptonGroupBox2.Location = New System.Drawing.Point(2, 131)
            Me.KryptonGroupBox2.Name = "KryptonGroupBox2"
            '
            'KryptonGroupBox2.Panel
            '
            Me.KryptonGroupBox2.Panel.Controls.Add(Me.dgvDetalleRequisicionPS)
            Me.KryptonGroupBox2.Size = New System.Drawing.Size(758, 292)
            Me.KryptonGroupBox2.TabIndex = 189
            Me.KryptonGroupBox2.Values.Heading = "Detalle de Orden de Compra"
            '
            'dgvDetalleRequisicionPS
            '
            Me.dgvDetalleRequisicionPS.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionPS.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionPS.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionPS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleRequisicionPS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.dgvDetalleRequisicionPS.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDetalleRequisicionPS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleRequisicionPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idItem, Me.nombreProductoServicio, Me.unidadMedida, Me.cantidadProductoServicio, Me.especificacionProductoServicio, Me.observacionesProductoServicio})
            Me.dgvDetalleRequisicionPS.Location = New System.Drawing.Point(2, 13)
            Me.dgvDetalleRequisicionPS.Name = "dgvDetalleRequisicionPS"
            Me.dgvDetalleRequisicionPS.RowHeadersVisible = False
            Me.dgvDetalleRequisicionPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionPS.Size = New System.Drawing.Size(749, 257)
            Me.dgvDetalleRequisicionPS.TabIndex = 4
            '
            'idItem
            '
            Me.idItem.HeaderText = "ID"
            Me.idItem.Name = "idItem"
            Me.idItem.ReadOnly = True
            Me.idItem.Width = 35
            '
            'nombreProductoServicio
            '
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.nombreProductoServicio.DefaultCellStyle = DataGridViewCellStyle2
            Me.nombreProductoServicio.HeaderText = "PRODUCTO/SERVICIO"
            Me.nombreProductoServicio.Name = "nombreProductoServicio"
            Me.nombreProductoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nombreProductoServicio.Width = 220
            '
            'unidadMedida
            '
            Me.unidadMedida.HeaderText = "UM"
            Me.unidadMedida.Name = "unidadMedida"
            Me.unidadMedida.ReadOnly = True
            Me.unidadMedida.Width = 40
            '
            'cantidadProductoServicio
            '
            Me.cantidadProductoServicio.HeaderText = "CANT."
            Me.cantidadProductoServicio.Name = "cantidadProductoServicio"
            Me.cantidadProductoServicio.Width = 40
            '
            'especificacionProductoServicio
            '
            Me.especificacionProductoServicio.HeaderText = "ESPECIFICACION"
            Me.especificacionProductoServicio.Name = "especificacionProductoServicio"
            Me.especificacionProductoServicio.Width = 200
            '
            'observacionesProductoServicio
            '
            Me.observacionesProductoServicio.HeaderText = "OBSERVACIONES"
            Me.observacionesProductoServicio.Name = "observacionesProductoServicio"
            Me.observacionesProductoServicio.Width = 220
            '
            'FormRequisicionProductoServicio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(763, 435)
            Me.Controls.Add(Me.btnEliminar)
            Me.Controls.Add(Me.KryptonGroupBox2)
            Me.Controls.Add(Me.KryptonGroupBox1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.panelDetalle)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRequisicionProductoServicio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REQUISICIÓN DE PRODUCTO / SERVICIO"
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            CType(Me.KryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.Panel.ResumeLayout(False)
            CType(Me.KryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox2.ResumeLayout(False)
            CType(Me.dgvDetalleRequisicionPS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtEntregaNumeroDias As System.Windows.Forms.TextBox
        Friend WithEvents rbEntregaNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbEntregaUrgente As System.Windows.Forms.RadioButton
        Friend WithEvents lblIdPersonal As System.Windows.Forms.Label
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtNombrePersonal As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaRequisicionProducto As System.Windows.Forms.TextBox
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents txtIdRequisicionProductoServicio As System.Windows.Forms.TextBox
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel3 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel2 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents dgvDetalleRequisicionPS As DataGridView
        Friend WithEvents idItem As DataGridViewTextBoxColumn
        Friend WithEvents nombreProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents unidadMedida As DataGridViewTextBoxColumn
        Friend WithEvents cantidadProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents especificacionProductoServicio As DataGridViewTextBoxColumn
        Friend WithEvents observacionesProductoServicio As DataGridViewTextBoxColumn
    End Class
End Namespace