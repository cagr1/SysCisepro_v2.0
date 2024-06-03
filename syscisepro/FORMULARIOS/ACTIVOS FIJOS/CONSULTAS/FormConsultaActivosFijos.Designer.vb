Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FormConsultaActivosFijos
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultaActivosFijos))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvActivosFijos = New System.Windows.Forms.DataGridView()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCantidad = New System.Windows.Forms.TextBox()
            Me.txtTotal = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgvTotalActivosFijos = New System.Windows.Forms.DataGridView()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.cbmTipoActivo = New System.Windows.Forms.ToolStripComboBox()
            Me.btnReporteFondoRotativo = New System.Windows.Forms.ToolStripMenuItem()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtCustodio = New System.Windows.Forms.TextBox()
            Me.txtActivo = New System.Windows.Forms.TextBox()
            Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
            Me.txtBuscar = New System.Windows.Forms.TextBox()
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTotalActivosFijos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(13, 208)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 13)
            Me.Label1.TabIndex = 6
            Me.Label1.Text = "TIPO ACTIVO"
            '
            'dgvActivosFijos
            '
            Me.dgvActivosFijos.AllowUserToAddRows = False
            Me.dgvActivosFijos.AllowUserToDeleteRows = False
            Me.dgvActivosFijos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvActivosFijos.BackgroundColor = System.Drawing.Color.White
            Me.dgvActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvActivosFijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvActivosFijos.Location = New System.Drawing.Point(0, 245)
            Me.dgvActivosFijos.MultiSelect = False
            Me.dgvActivosFijos.Name = "dgvActivosFijos"
            Me.dgvActivosFijos.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActivosFijos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvActivosFijos.RowHeadersVisible = False
            Me.dgvActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActivosFijos.Size = New System.Drawing.Size(974, 433)
            Me.dgvActivosFijos.TabIndex = 7
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(359, 208)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 13)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "CANTIDAD"
            '
            'txtCantidad
            '
            Me.txtCantidad.BackColor = System.Drawing.Color.White
            Me.txtCantidad.Enabled = False
            Me.txtCantidad.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCantidad.Location = New System.Drawing.Point(425, 206)
            Me.txtCantidad.Name = "txtCantidad"
            Me.txtCantidad.Size = New System.Drawing.Size(56, 21)
            Me.txtCantidad.TabIndex = 9
            Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtTotal
            '
            Me.txtTotal.BackColor = System.Drawing.Color.White
            Me.txtTotal.Enabled = False
            Me.txtTotal.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotal.Location = New System.Drawing.Point(534, 206)
            Me.txtTotal.Name = "txtTotal"
            Me.txtTotal.Size = New System.Drawing.Size(100, 21)
            Me.txtTotal.TabIndex = 11
            Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(493, 210)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(42, 13)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "TOTAL"
            '
            'dgvTotalActivosFijos
            '
            Me.dgvTotalActivosFijos.AllowUserToAddRows = False
            Me.dgvTotalActivosFijos.AllowUserToDeleteRows = False
            Me.dgvTotalActivosFijos.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotalActivosFijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvTotalActivosFijos.BackgroundColor = System.Drawing.Color.White
            Me.dgvTotalActivosFijos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.dgvTotalActivosFijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotalActivosFijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvTotalActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotalActivosFijos.Location = New System.Drawing.Point(0, 102)
            Me.dgvTotalActivosFijos.MultiSelect = False
            Me.dgvTotalActivosFijos.Name = "dgvTotalActivosFijos"
            Me.dgvTotalActivosFijos.ReadOnly = True
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTotalActivosFijos.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgvTotalActivosFijos.RowHeadersVisible = False
            Me.dgvTotalActivosFijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTotalActivosFijos.Size = New System.Drawing.Size(974, 97)
            Me.dgvTotalActivosFijos.TabIndex = 12
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(16, 81)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(140, 13)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "TOTAL DE ACTIVOS FIJOS"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.cbmTipoActivo, Me.btnReporteFondoRotativo})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(974, 25)
            Me.MenuStrip1.TabIndex = 242
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(117, 20)
            Me.ToolStripMenuItem1.Text = "CARGAR TODAS"
            '
            'cbmTipoActivo
            '
            Me.cbmTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoActivo.Items.AddRange(New Object() {"ARMAS", "RADIOS", "VEHICULOS", "TERRENOS", "EQUIPOS DE COMPUTO", "LIBROS Y COLECCIONES", "EQUIPOS DE OFICINA", "MUEBLES DE OFICINA", "EQUIPOS DE COCINA", "EQUIPOS DE AMBIENTACION", "EQUIPOS DE COMUNICACION Y TELEFONIA", "EQUIPOS DE SEGURIDAD INDUSTRIAL", "CAMARAS DE SEGURIDAD", "GENERADORES", "CHALECOS", "SOFTWARE"})
            Me.cbmTipoActivo.Name = "cbmTipoActivo"
            Me.cbmTipoActivo.Size = New System.Drawing.Size(121, 21)
            '
            'btnReporteFondoRotativo
            '
            Me.btnReporteFondoRotativo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteFondoRotativo.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnReporteFondoRotativo.Name = "btnReporteFondoRotativo"
            Me.btnReporteFondoRotativo.Size = New System.Drawing.Size(83, 20)
            Me.btnReporteFondoRotativo.Text = "REPORTE"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(659, 210)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(61, 13)
            Me.Label5.TabIndex = 243
            Me.Label5.Text = "CUSTODIO"
            '
            'txtCustodio
            '
            Me.txtCustodio.BackColor = System.Drawing.Color.White
            Me.txtCustodio.Enabled = False
            Me.txtCustodio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCustodio.Location = New System.Drawing.Point(726, 206)
            Me.txtCustodio.Name = "txtCustodio"
            Me.txtCustodio.Size = New System.Drawing.Size(248, 21)
            Me.txtCustodio.TabIndex = 244
            Me.txtCustodio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtActivo
            '
            Me.txtActivo.BackColor = System.Drawing.Color.White
            Me.txtActivo.Enabled = False
            Me.txtActivo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActivo.Location = New System.Drawing.Point(105, 205)
            Me.txtActivo.Name = "txtActivo"
            Me.txtActivo.Size = New System.Drawing.Size(237, 21)
            Me.txtActivo.TabIndex = 245
            Me.txtActivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'KryptonButton1
            '
            Me.KryptonButton1.AutoSize = True
            Me.KryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.KryptonButton1.Location = New System.Drawing.Point(228, 32)
            Me.KryptonButton1.Name = "KryptonButton1"
            Me.KryptonButton1.Size = New System.Drawing.Size(32, 32)
            Me.KryptonButton1.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.KryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.KryptonButton1.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.[False]
            Me.KryptonButton1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            Me.KryptonButton1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
            Me.KryptonButton1.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
            Me.KryptonButton1.TabIndex = 247
            Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
            Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
            Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
            Me.KryptonButton1.Values.ImageStates.ImageDisabled = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.KryptonButton1.Values.ImageStates.ImageNormal = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.KryptonButton1.Values.ImageStates.ImagePressed = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.KryptonButton1.Values.ImageStates.ImageTracking = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz40
            Me.KryptonButton1.Values.Text = ""
            '
            'txtBuscar
            '
            Me.txtBuscar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscar.Location = New System.Drawing.Point(19, 36)
            Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 2, 2)
            Me.txtBuscar.Name = "txtBuscar"
            Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtBuscar.Size = New System.Drawing.Size(194, 23)
            Me.txtBuscar.TabIndex = 248
            '
            'FormConsultaActivosFijos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(974, 616)
            Me.Controls.Add(Me.txtBuscar)
            Me.Controls.Add(Me.KryptonButton1)
            Me.Controls.Add(Me.txtActivo)
            Me.Controls.Add(Me.txtCustodio)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dgvTotalActivosFijos)
            Me.Controls.Add(Me.txtTotal)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtCantidad)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dgvActivosFijos)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormConsultaActivosFijos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CONSULTA DE REGISTROS DE ACTIVOS FIJOS"
            CType(Me.dgvActivosFijos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTotalActivosFijos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvActivosFijos As System.Windows.Forms.DataGridView
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgvTotalActivosFijos As System.Windows.Forms.DataGridView
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnReporteFondoRotativo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtCustodio As System.Windows.Forms.TextBox
        Friend WithEvents cbmTipoActivo As System.Windows.Forms.ToolStripComboBox
        Friend WithEvents txtActivo As System.Windows.Forms.TextBox
        Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
        Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    End Class
End Namespace