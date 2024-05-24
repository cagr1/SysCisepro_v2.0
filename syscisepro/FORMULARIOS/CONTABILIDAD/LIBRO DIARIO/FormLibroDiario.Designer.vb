Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormLibroDiario
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibroDiario))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvLibroDiario = New System.Windows.Forms.DataGridView()
            Me.gbDesplazamientoRegistros = New System.Windows.Forms.GroupBox()
            Me.lblIndice = New System.Windows.Forms.Label()
            Me.btnUltimoRegistro = New System.Windows.Forms.Button()
            Me.btnSiguienteRegistro = New System.Windows.Forms.Button()
            Me.btnAnteriorRegistro = New System.Windows.Forms.Button()
            Me.btnPrimerRegistro = New System.Windows.Forms.Button()
            Me.dgvAsientosLibroDiario = New System.Windows.Forms.DataGridView()
            Me.btnCuadrarLibroDiario = New System.Windows.Forms.Button()
            Me.btnAjusteLibroDiario = New System.Windows.Forms.Button()
            Me.txtTotalDebe = New System.Windows.Forms.TextBox()
            Me.txtTotalHaber = New System.Windows.Forms.TextBox()
            Me.lbltotalDebe = New System.Windows.Forms.Label()
            Me.lblTotalHaber = New System.Windows.Forms.Label()
            Me.gbComandos = New System.Windows.Forms.GroupBox()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnReporteLibroDiario = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.gbTotales = New System.Windows.Forms.GroupBox()
            Me.gbBuscarAsiento = New System.Windows.Forms.GroupBox()
            Me.btnBusquedaAvanzada = New System.Windows.Forms.Button()
            Me.btnBuscarAsiento = New System.Windows.Forms.Button()
            Me.txtBuscarAsiento = New System.Windows.Forms.TextBox()
            CType(Me.dgvLibroDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbDesplazamientoRegistros.SuspendLayout()
            CType(Me.dgvAsientosLibroDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbComandos.SuspendLayout()
            Me.gbTotales.SuspendLayout()
            Me.gbBuscarAsiento.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvLibroDiario
            '
            Me.dgvLibroDiario.AllowUserToAddRows = False
            Me.dgvLibroDiario.AllowUserToDeleteRows = False
            Me.dgvLibroDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvLibroDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvLibroDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvLibroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLibroDiario.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvLibroDiario.Location = New System.Drawing.Point(2, 2)
            Me.dgvLibroDiario.Name = "dgvLibroDiario"
            Me.dgvLibroDiario.RowHeadersVisible = False
            Me.dgvLibroDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLibroDiario.Size = New System.Drawing.Size(465, 157)
            Me.dgvLibroDiario.TabIndex = 0
            '
            'gbDesplazamientoRegistros
            '
            Me.gbDesplazamientoRegistros.BackColor = System.Drawing.Color.White
            Me.gbDesplazamientoRegistros.Controls.Add(Me.lblIndice)
            Me.gbDesplazamientoRegistros.Controls.Add(Me.btnUltimoRegistro)
            Me.gbDesplazamientoRegistros.Controls.Add(Me.btnSiguienteRegistro)
            Me.gbDesplazamientoRegistros.Controls.Add(Me.btnAnteriorRegistro)
            Me.gbDesplazamientoRegistros.Controls.Add(Me.btnPrimerRegistro)
            Me.gbDesplazamientoRegistros.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDesplazamientoRegistros.Location = New System.Drawing.Point(468, 2)
            Me.gbDesplazamientoRegistros.Name = "gbDesplazamientoRegistros"
            Me.gbDesplazamientoRegistros.Size = New System.Drawing.Size(240, 71)
            Me.gbDesplazamientoRegistros.TabIndex = 16
            Me.gbDesplazamientoRegistros.TabStop = False
            Me.gbDesplazamientoRegistros.Text = "DESPLAZAMIENTO DE REGISTROS"
            '
            'lblIndice
            '
            Me.lblIndice.AutoSize = True
            Me.lblIndice.Location = New System.Drawing.Point(271, 0)
            Me.lblIndice.Name = "lblIndice"
            Me.lblIndice.Size = New System.Drawing.Size(13, 13)
            Me.lblIndice.TabIndex = 18
            Me.lblIndice.Text = "0"
            '
            'btnUltimoRegistro
            '
            Me.btnUltimoRegistro.BackColor = System.Drawing.Color.White
            Me.btnUltimoRegistro.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnUltimoRegistro.Image = CType(resources.GetObject("btnUltimoRegistro.Image"), System.Drawing.Image)
            Me.btnUltimoRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnUltimoRegistro.Location = New System.Drawing.Point(176, 19)
            Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
            Me.btnUltimoRegistro.Size = New System.Drawing.Size(58, 43)
            Me.btnUltimoRegistro.TabIndex = 3
            Me.btnUltimoRegistro.Text = "ULTIMO REGISTRO"
            Me.btnUltimoRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnUltimoRegistro.UseVisualStyleBackColor = False
            '
            'btnSiguienteRegistro
            '
            Me.btnSiguienteRegistro.BackColor = System.Drawing.Color.White
            Me.btnSiguienteRegistro.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSiguienteRegistro.Image = CType(resources.GetObject("btnSiguienteRegistro.Image"), System.Drawing.Image)
            Me.btnSiguienteRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSiguienteRegistro.Location = New System.Drawing.Point(119, 19)
            Me.btnSiguienteRegistro.Name = "btnSiguienteRegistro"
            Me.btnSiguienteRegistro.Size = New System.Drawing.Size(58, 43)
            Me.btnSiguienteRegistro.TabIndex = 2
            Me.btnSiguienteRegistro.Text = "SIGUIENTE REGISTRO"
            Me.btnSiguienteRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSiguienteRegistro.UseVisualStyleBackColor = False
            '
            'btnAnteriorRegistro
            '
            Me.btnAnteriorRegistro.BackColor = System.Drawing.Color.White
            Me.btnAnteriorRegistro.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnteriorRegistro.Image = CType(resources.GetObject("btnAnteriorRegistro.Image"), System.Drawing.Image)
            Me.btnAnteriorRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAnteriorRegistro.Location = New System.Drawing.Point(62, 19)
            Me.btnAnteriorRegistro.Name = "btnAnteriorRegistro"
            Me.btnAnteriorRegistro.Size = New System.Drawing.Size(58, 43)
            Me.btnAnteriorRegistro.TabIndex = 1
            Me.btnAnteriorRegistro.Text = "ANTERIOR REGISTRO"
            Me.btnAnteriorRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAnteriorRegistro.UseVisualStyleBackColor = False
            '
            'btnPrimerRegistro
            '
            Me.btnPrimerRegistro.BackColor = System.Drawing.Color.White
            Me.btnPrimerRegistro.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPrimerRegistro.Image = CType(resources.GetObject("btnPrimerRegistro.Image"), System.Drawing.Image)
            Me.btnPrimerRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnPrimerRegistro.Location = New System.Drawing.Point(5, 19)
            Me.btnPrimerRegistro.Name = "btnPrimerRegistro"
            Me.btnPrimerRegistro.Size = New System.Drawing.Size(58, 43)
            Me.btnPrimerRegistro.TabIndex = 0
            Me.btnPrimerRegistro.Text = "PRIMER REGISTRO"
            Me.btnPrimerRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPrimerRegistro.UseVisualStyleBackColor = False
            '
            'dgvAsientosLibroDiario
            '
            Me.dgvAsientosLibroDiario.AllowUserToAddRows = False
            Me.dgvAsientosLibroDiario.AllowUserToDeleteRows = False
            Me.dgvAsientosLibroDiario.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosLibroDiario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvAsientosLibroDiario.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosLibroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosLibroDiario.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvAsientosLibroDiario.Location = New System.Drawing.Point(2, 160)
            Me.dgvAsientosLibroDiario.Name = "dgvAsientosLibroDiario"
            Me.dgvAsientosLibroDiario.RowHeadersVisible = False
            Me.dgvAsientosLibroDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosLibroDiario.Size = New System.Drawing.Size(1059, 529)
            Me.dgvAsientosLibroDiario.TabIndex = 17
            '
            'btnCuadrarLibroDiario
            '
            Me.btnCuadrarLibroDiario.BackColor = System.Drawing.Color.White
            Me.btnCuadrarLibroDiario.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCuadrarLibroDiario.Image = CType(resources.GetObject("btnCuadrarLibroDiario.Image"), System.Drawing.Image)
            Me.btnCuadrarLibroDiario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnCuadrarLibroDiario.Location = New System.Drawing.Point(5, 19)
            Me.btnCuadrarLibroDiario.Name = "btnCuadrarLibroDiario"
            Me.btnCuadrarLibroDiario.Size = New System.Drawing.Size(58, 43)
            Me.btnCuadrarLibroDiario.TabIndex = 18
            Me.btnCuadrarLibroDiario.Text = "CUADRAR DIARIO"
            Me.btnCuadrarLibroDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCuadrarLibroDiario.UseVisualStyleBackColor = False
            '
            'btnAjusteLibroDiario
            '
            Me.btnAjusteLibroDiario.BackColor = System.Drawing.Color.White
            Me.btnAjusteLibroDiario.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAjusteLibroDiario.Image = CType(resources.GetObject("btnAjusteLibroDiario.Image"), System.Drawing.Image)
            Me.btnAjusteLibroDiario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAjusteLibroDiario.Location = New System.Drawing.Point(62, 19)
            Me.btnAjusteLibroDiario.Name = "btnAjusteLibroDiario"
            Me.btnAjusteLibroDiario.Size = New System.Drawing.Size(58, 43)
            Me.btnAjusteLibroDiario.TabIndex = 19
            Me.btnAjusteLibroDiario.Text = "AJUSTAR DIARIO"
            Me.btnAjusteLibroDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAjusteLibroDiario.UseVisualStyleBackColor = False
            '
            'txtTotalDebe
            '
            Me.txtTotalDebe.Enabled = False
            Me.txtTotalDebe.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalDebe.Location = New System.Drawing.Point(103, 19)
            Me.txtTotalDebe.Name = "txtTotalDebe"
            Me.txtTotalDebe.Size = New System.Drawing.Size(114, 23)
            Me.txtTotalDebe.TabIndex = 20
            Me.txtTotalDebe.Text = "0.00"
            Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalHaber
            '
            Me.txtTotalHaber.Enabled = False
            Me.txtTotalHaber.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalHaber.Location = New System.Drawing.Point(103, 52)
            Me.txtTotalHaber.Name = "txtTotalHaber"
            Me.txtTotalHaber.Size = New System.Drawing.Size(114, 23)
            Me.txtTotalHaber.TabIndex = 21
            Me.txtTotalHaber.Text = "0.00"
            Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lbltotalDebe
            '
            Me.lbltotalDebe.AutoSize = True
            Me.lbltotalDebe.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbltotalDebe.Location = New System.Drawing.Point(6, 22)
            Me.lbltotalDebe.Name = "lbltotalDebe"
            Me.lbltotalDebe.Size = New System.Drawing.Size(84, 15)
            Me.lbltotalDebe.TabIndex = 22
            Me.lbltotalDebe.Text = "TOTAL DEBE:"
            '
            'lblTotalHaber
            '
            Me.lblTotalHaber.AutoSize = True
            Me.lblTotalHaber.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalHaber.Location = New System.Drawing.Point(6, 55)
            Me.lblTotalHaber.Name = "lblTotalHaber"
            Me.lblTotalHaber.Size = New System.Drawing.Size(91, 15)
            Me.lblTotalHaber.TabIndex = 23
            Me.lblTotalHaber.Text = "TOTAL HABER:"
            '
            'gbComandos
            '
            Me.gbComandos.BackColor = System.Drawing.Color.White
            Me.gbComandos.Controls.Add(Me.btnExportar)
            Me.gbComandos.Controls.Add(Me.btnSalir)
            Me.gbComandos.Controls.Add(Me.Label2)
            Me.gbComandos.Controls.Add(Me.btnAjusteLibroDiario)
            Me.gbComandos.Controls.Add(Me.btnCuadrarLibroDiario)
            Me.gbComandos.Controls.Add(Me.btnReporteLibroDiario)
            Me.gbComandos.Controls.Add(Me.btnGuardar)
            Me.gbComandos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbComandos.Location = New System.Drawing.Point(709, 2)
            Me.gbComandos.Name = "gbComandos"
            Me.gbComandos.Size = New System.Drawing.Size(352, 71)
            Me.gbComandos.TabIndex = 20
            Me.gbComandos.TabStop = False
            Me.gbComandos.Text = "COMANDOS"
            '
            'btnExportar
            '
            Me.btnExportar.BackColor = System.Drawing.Color.White
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnExportar.Location = New System.Drawing.Point(176, 19)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(58, 43)
            Me.btnExportar.TabIndex = 21
            Me.btnExportar.Text = "EXPORTAR"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnExportar.UseVisualStyleBackColor = False
            '
            'btnSalir
            '
            Me.btnSalir.BackColor = System.Drawing.Color.White
            Me.btnSalir.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSalir.Location = New System.Drawing.Point(290, 19)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(58, 43)
            Me.btnSalir.TabIndex = 20
            Me.btnSalir.Text = "SALIR"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSalir.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(279, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(13, 13)
            Me.Label2.TabIndex = 18
            Me.Label2.Text = "0"
            '
            'btnReporteLibroDiario
            '
            Me.btnReporteLibroDiario.BackColor = System.Drawing.Color.White
            Me.btnReporteLibroDiario.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporteLibroDiario.Image = CType(resources.GetObject("btnReporteLibroDiario.Image"), System.Drawing.Image)
            Me.btnReporteLibroDiario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnReporteLibroDiario.Location = New System.Drawing.Point(233, 19)
            Me.btnReporteLibroDiario.Name = "btnReporteLibroDiario"
            Me.btnReporteLibroDiario.Size = New System.Drawing.Size(58, 43)
            Me.btnReporteLibroDiario.TabIndex = 19
            Me.btnReporteLibroDiario.Text = "REPORTE LIBRO"
            Me.btnReporteLibroDiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReporteLibroDiario.UseVisualStyleBackColor = False
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.White
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnGuardar.Location = New System.Drawing.Point(119, 19)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(58, 43)
            Me.btnGuardar.TabIndex = 18
            Me.btnGuardar.Text = "GUARDAR DIARIO"
            Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'gbTotales
            '
            Me.gbTotales.BackColor = System.Drawing.Color.White
            Me.gbTotales.Controls.Add(Me.lbltotalDebe)
            Me.gbTotales.Controls.Add(Me.lblTotalHaber)
            Me.gbTotales.Controls.Add(Me.txtTotalDebe)
            Me.gbTotales.Controls.Add(Me.txtTotalHaber)
            Me.gbTotales.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTotales.Location = New System.Drawing.Point(708, 73)
            Me.gbTotales.Name = "gbTotales"
            Me.gbTotales.Size = New System.Drawing.Size(353, 86)
            Me.gbTotales.TabIndex = 24
            Me.gbTotales.TabStop = False
            Me.gbTotales.Text = "TOTALES"
            '
            'gbBuscarAsiento
            '
            Me.gbBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.gbBuscarAsiento.Controls.Add(Me.btnBusquedaAvanzada)
            Me.gbBuscarAsiento.Controls.Add(Me.btnBuscarAsiento)
            Me.gbBuscarAsiento.Controls.Add(Me.txtBuscarAsiento)
            Me.gbBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBuscarAsiento.Location = New System.Drawing.Point(468, 73)
            Me.gbBuscarAsiento.Name = "gbBuscarAsiento"
            Me.gbBuscarAsiento.Size = New System.Drawing.Size(240, 86)
            Me.gbBuscarAsiento.TabIndex = 25
            Me.gbBuscarAsiento.TabStop = False
            Me.gbBuscarAsiento.Text = "BUSCAR ASIENTO"
            '
            'btnBusquedaAvanzada
            '
            Me.btnBusquedaAvanzada.BackColor = System.Drawing.Color.White
            Me.btnBusquedaAvanzada.Enabled = False
            Me.btnBusquedaAvanzada.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBusquedaAvanzada.Image = CType(resources.GetObject("btnBusquedaAvanzada.Image"), System.Drawing.Image)
            Me.btnBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBusquedaAvanzada.Location = New System.Drawing.Point(119, 48)
            Me.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada"
            Me.btnBusquedaAvanzada.Size = New System.Drawing.Size(115, 27)
            Me.btnBusquedaAvanzada.TabIndex = 26
            Me.btnBusquedaAvanzada.Text = "AVANZADA"
            Me.btnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBusquedaAvanzada.UseVisualStyleBackColor = False
            '
            'btnBuscarAsiento
            '
            Me.btnBuscarAsiento.BackColor = System.Drawing.Color.White
            Me.btnBuscarAsiento.Enabled = False
            Me.btnBuscarAsiento.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscarAsiento.Image = CType(resources.GetObject("btnBuscarAsiento.Image"), System.Drawing.Image)
            Me.btnBuscarAsiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarAsiento.Location = New System.Drawing.Point(5, 48)
            Me.btnBuscarAsiento.Name = "btnBuscarAsiento"
            Me.btnBuscarAsiento.Size = New System.Drawing.Size(115, 27)
            Me.btnBuscarAsiento.TabIndex = 25
            Me.btnBuscarAsiento.Text = "BUSCAR #"
            Me.btnBuscarAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarAsiento.UseVisualStyleBackColor = False
            '
            'txtBuscarAsiento
            '
            Me.txtBuscarAsiento.Location = New System.Drawing.Point(6, 19)
            Me.txtBuscarAsiento.Name = "txtBuscarAsiento"
            Me.txtBuscarAsiento.Size = New System.Drawing.Size(228, 20)
            Me.txtBuscarAsiento.TabIndex = 24
            Me.txtBuscarAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'FormLibroDiario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1062, 692)
            Me.Controls.Add(Me.gbBuscarAsiento)
            Me.Controls.Add(Me.gbTotales)
            Me.Controls.Add(Me.gbComandos)
            Me.Controls.Add(Me.dgvAsientosLibroDiario)
            Me.Controls.Add(Me.gbDesplazamientoRegistros)
            Me.Controls.Add(Me.dgvLibroDiario)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormLibroDiario"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "LIBRO DIARIO GENERAL"
            CType(Me.dgvLibroDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbDesplazamientoRegistros.ResumeLayout(False)
            Me.gbDesplazamientoRegistros.PerformLayout()
            CType(Me.dgvAsientosLibroDiario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbComandos.ResumeLayout(False)
            Me.gbComandos.PerformLayout()
            Me.gbTotales.ResumeLayout(False)
            Me.gbTotales.PerformLayout()
            Me.gbBuscarAsiento.ResumeLayout(False)
            Me.gbBuscarAsiento.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvLibroDiario As System.Windows.Forms.DataGridView
        Friend WithEvents gbDesplazamientoRegistros As System.Windows.Forms.GroupBox
        Friend WithEvents btnUltimoRegistro As System.Windows.Forms.Button
        Friend WithEvents btnSiguienteRegistro As System.Windows.Forms.Button
        Friend WithEvents btnAnteriorRegistro As System.Windows.Forms.Button
        Friend WithEvents btnPrimerRegistro As System.Windows.Forms.Button
        Friend WithEvents dgvAsientosLibroDiario As System.Windows.Forms.DataGridView
        Friend WithEvents lblIndice As System.Windows.Forms.Label
        Friend WithEvents btnCuadrarLibroDiario As System.Windows.Forms.Button
        Friend WithEvents btnAjusteLibroDiario As System.Windows.Forms.Button
        Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
        Friend WithEvents lbltotalDebe As System.Windows.Forms.Label
        Friend WithEvents lblTotalHaber As System.Windows.Forms.Label
        Friend WithEvents gbComandos As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnReporteLibroDiario As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents gbTotales As System.Windows.Forms.GroupBox
        Friend WithEvents gbBuscarAsiento As System.Windows.Forms.GroupBox
        Friend WithEvents txtBuscarAsiento As System.Windows.Forms.TextBox
        Friend WithEvents btnBusquedaAvanzada As System.Windows.Forms.Button
        Friend WithEvents btnBuscarAsiento As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnExportar As System.Windows.Forms.Button
    End Class
End Namespace