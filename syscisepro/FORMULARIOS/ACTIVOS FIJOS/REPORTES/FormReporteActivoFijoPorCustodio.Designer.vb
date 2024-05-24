Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormReporteActivoFijoPorCustodio
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteActivoFijoPorCustodio))
            Me.lblIdCustodio = New System.Windows.Forms.Label()
            Me.txtCustodio = New System.Windows.Forms.TextBox()
            Me.lblDatos = New System.Windows.Forms.Label()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.scReporteActivoFijoCustodio = New System.Windows.Forms.SplitContainer()
            Me.cbSucursal = New System.Windows.Forms.ComboBox()
            Me.cbEmpresa = New System.Windows.Forms.ComboBox()
            Me.lblSucursal = New System.Windows.Forms.Label()
            Me.lblEmpresa = New System.Windows.Forms.Label()
            Me.crvActivoCustodio = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            CType(Me.scReporteActivoFijoCustodio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.scReporteActivoFijoCustodio.Panel1.SuspendLayout()
            Me.scReporteActivoFijoCustodio.Panel2.SuspendLayout()
            Me.scReporteActivoFijoCustodio.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdCustodio
            '
            Me.lblIdCustodio.AutoSize = True
            Me.lblIdCustodio.BackColor = System.Drawing.Color.Transparent
            Me.lblIdCustodio.Location = New System.Drawing.Point(255, 16)
            Me.lblIdCustodio.Name = "lblIdCustodio"
            Me.lblIdCustodio.Size = New System.Drawing.Size(55, 13)
            Me.lblIdCustodio.TabIndex = 1
            Me.lblIdCustodio.Text = "00000000"
            Me.lblIdCustodio.Visible = False
            '
            'txtCustodio
            '
            Me.txtCustodio.Enabled = False
            Me.txtCustodio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCustodio.Location = New System.Drawing.Point(52, 11)
            Me.txtCustodio.Name = "txtCustodio"
            Me.txtCustodio.Size = New System.Drawing.Size(250, 21)
            Me.txtCustodio.TabIndex = 2
            '
            'lblDatos
            '
            Me.lblDatos.AutoSize = True
            Me.lblDatos.BackColor = System.Drawing.Color.Transparent
            Me.lblDatos.Location = New System.Drawing.Point(3, 16)
            Me.lblDatos.Name = "lblDatos"
            Me.lblDatos.Size = New System.Drawing.Size(47, 13)
            Me.lblDatos.TabIndex = 3
            Me.lblDatos.Text = "DATOS:"
            '
            'btnBuscar
            '
            Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnBuscar.Location = New System.Drawing.Point(327, 4)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(69, 40)
            Me.btnBuscar.TabIndex = 4
            Me.btnBuscar.Text = "BUSCAR"
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = False
            '
            'btnActualizar
            '
            Me.btnActualizar.Image = Global.syscisepro.My.Resources.Resources.oki
            Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnActualizar.Location = New System.Drawing.Point(402, 4)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(69, 40)
            Me.btnActualizar.TabIndex = 5
            Me.btnActualizar.Text = "CARGAR"
            Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnActualizar.UseVisualStyleBackColor = True
            '
            'scReporteActivoFijoCustodio
            '
            Me.scReporteActivoFijoCustodio.Location = New System.Drawing.Point(2, 2)
            Me.scReporteActivoFijoCustodio.Name = "scReporteActivoFijoCustodio"
            Me.scReporteActivoFijoCustodio.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'scReporteActivoFijoCustodio.Panel1
            '
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.cbSucursal)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.cbEmpresa)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.lblSucursal)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.lblEmpresa)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.txtCustodio)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.btnActualizar)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.lblIdCustodio)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.btnBuscar)
            Me.scReporteActivoFijoCustodio.Panel1.Controls.Add(Me.lblDatos)
            '
            'scReporteActivoFijoCustodio.Panel2
            '
            Me.scReporteActivoFijoCustodio.Panel2.Controls.Add(Me.crvActivoCustodio)
            Me.scReporteActivoFijoCustodio.Size = New System.Drawing.Size(990, 595)
            Me.scReporteActivoFijoCustodio.SplitterDistance = 47
            Me.scReporteActivoFijoCustodio.TabIndex = 6
            '
            'cbSucursal
            '
            Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbSucursal.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbSucursal.FormattingEnabled = True
            Me.cbSucursal.Location = New System.Drawing.Point(844, 12)
            Me.cbSucursal.Name = "cbSucursal"
            Me.cbSucursal.Size = New System.Drawing.Size(142, 23)
            Me.cbSucursal.TabIndex = 78
            '
            'cbEmpresa
            '
            Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbEmpresa.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.cbEmpresa.FormattingEnabled = True
            Me.cbEmpresa.Location = New System.Drawing.Point(557, 11)
            Me.cbEmpresa.Name = "cbEmpresa"
            Me.cbEmpresa.Size = New System.Drawing.Size(185, 23)
            Me.cbEmpresa.TabIndex = 77
            '
            'lblSucursal
            '
            Me.lblSucursal.AutoSize = True
            Me.lblSucursal.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.lblSucursal.Location = New System.Drawing.Point(768, 15)
            Me.lblSucursal.Name = "lblSucursal"
            Me.lblSucursal.Size = New System.Drawing.Size(64, 15)
            Me.lblSucursal.TabIndex = 76
            Me.lblSucursal.Text = "SUCURSAL:"
            '
            'lblEmpresa
            '
            Me.lblEmpresa.AutoSize = True
            Me.lblEmpresa.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.lblEmpresa.Location = New System.Drawing.Point(491, 16)
            Me.lblEmpresa.Name = "lblEmpresa"
            Me.lblEmpresa.Size = New System.Drawing.Size(60, 15)
            Me.lblEmpresa.TabIndex = 75
            Me.lblEmpresa.Text = "EMPRESA:"
            '
            'crvActivoCustodio
            '
            Me.crvActivoCustodio.ActiveViewIndex = -1
            Me.crvActivoCustodio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvActivoCustodio.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvActivoCustodio.Location = New System.Drawing.Point(0, 3)
            Me.crvActivoCustodio.Name = "crvActivoCustodio"
            Me.crvActivoCustodio.Size = New System.Drawing.Size(990, 538)
            Me.crvActivoCustodio.TabIndex = 1
            Me.crvActivoCustodio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'FormReporteActivoFijoPorCustodio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(993, 598)
            Me.Controls.Add(Me.scReporteActivoFijoCustodio)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormReporteActivoFijoPorCustodio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTE DE ACTIVO FIJO POR CUSTODIO"
            Me.scReporteActivoFijoCustodio.Panel1.ResumeLayout(False)
            Me.scReporteActivoFijoCustodio.Panel1.PerformLayout()
            Me.scReporteActivoFijoCustodio.Panel2.ResumeLayout(False)
            CType(Me.scReporteActivoFijoCustodio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.scReporteActivoFijoCustodio.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblIdCustodio As System.Windows.Forms.Label
        Friend WithEvents txtCustodio As System.Windows.Forms.TextBox
        Friend WithEvents lblDatos As System.Windows.Forms.Label
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents scReporteActivoFijoCustodio As System.Windows.Forms.SplitContainer
        Friend WithEvents crvActivoCustodio As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
        Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
        Friend WithEvents lblSucursal As System.Windows.Forms.Label
        Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    End Class
End Namespace