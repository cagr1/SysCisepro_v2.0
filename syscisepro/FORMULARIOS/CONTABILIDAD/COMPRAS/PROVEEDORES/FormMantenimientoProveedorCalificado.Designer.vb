Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormMantenimientoProveedorCalificado
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoProveedorCalificado))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbProveedorCalificado = New System.Windows.Forms.GroupBox()
            Me.lblIdPaises = New System.Windows.Forms.Label()
            Me.lblIdProvincia = New System.Windows.Forms.Label()
            Me.lblIdCiudad = New System.Windows.Forms.Label()
            Me.txtObservaciones = New System.Windows.Forms.TextBox()
            Me.lblObservaciones = New System.Windows.Forms.Label()
            Me.txtCertificaciones = New System.Windows.Forms.TextBox()
            Me.lblCertificaciones = New System.Windows.Forms.Label()
            Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
            Me.lblFormaPago = New System.Windows.Forms.Label()
            Me.txtServiciosPrestados = New System.Windows.Forms.TextBox()
            Me.lblServiciosPrestados = New System.Windows.Forms.Label()
            Me.txtPaginaWeb = New System.Windows.Forms.TextBox()
            Me.lblPaginaWeb = New System.Windows.Forms.Label()
            Me.cmbCiudad = New System.Windows.Forms.ComboBox()
            Me.lblCiudad = New System.Windows.Forms.Label()
            Me.cmbProvincia = New System.Windows.Forms.ComboBox()
            Me.lblProvincia = New System.Windows.Forms.Label()
            Me.cmbPais = New System.Windows.Forms.ComboBox()
            Me.lblpais = New System.Windows.Forms.Label()
            Me.cmbImportador = New System.Windows.Forms.ComboBox()
            Me.lblImportador = New System.Windows.Forms.Label()
            Me.txtActividad = New System.Windows.Forms.TextBox()
            Me.lblActividad = New System.Windows.Forms.Label()
            Me.txtNumeroCarpeta = New System.Windows.Forms.TextBox()
            Me.lblNumeroCarpeta = New System.Windows.Forms.Label()
            Me.dtpFechaCese = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaCese = New System.Windows.Forms.Label()
            Me.dtpFechaActualizacion = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaActualizacion = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaInicio = New System.Windows.Forms.Label()
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.btnBuscarProveedorCalificado = New System.Windows.Forms.Button()
            Me.lblIdProveedor = New System.Windows.Forms.Label()
            Me.txtIdProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblRucCiProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblRazonSocialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtRazonSocial = New System.Windows.Forms.TextBox()
            Me.lblNombreComercialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.panelAgregarEliminar = New System.Windows.Forms.Panel()
            Me.lblEtiquetaContactosProveedor = New System.Windows.Forms.Label()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgvContactosProveedorCalificado = New System.Windows.Forms.DataGridView()
            Me.idContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombresContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.apellidosContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cargoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.telefonoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.celularContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.emailContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.estadoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.idProveedorGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbProveedorCalificado.SuspendLayout()
            Me.gbProveedor.SuspendLayout()
            Me.panelAgregarEliminar.SuspendLayout()
            CType(Me.dgvContactosProveedorCalificado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbProveedorCalificado
            '
            Me.gbProveedorCalificado.BackColor = System.Drawing.Color.White
            Me.gbProveedorCalificado.Controls.Add(Me.lblIdPaises)
            Me.gbProveedorCalificado.Controls.Add(Me.lblIdProvincia)
            Me.gbProveedorCalificado.Controls.Add(Me.lblIdCiudad)
            Me.gbProveedorCalificado.Controls.Add(Me.txtObservaciones)
            Me.gbProveedorCalificado.Controls.Add(Me.lblObservaciones)
            Me.gbProveedorCalificado.Controls.Add(Me.txtCertificaciones)
            Me.gbProveedorCalificado.Controls.Add(Me.lblCertificaciones)
            Me.gbProveedorCalificado.Controls.Add(Me.cmbFormaPago)
            Me.gbProveedorCalificado.Controls.Add(Me.lblFormaPago)
            Me.gbProveedorCalificado.Controls.Add(Me.txtServiciosPrestados)
            Me.gbProveedorCalificado.Controls.Add(Me.lblServiciosPrestados)
            Me.gbProveedorCalificado.Controls.Add(Me.txtPaginaWeb)
            Me.gbProveedorCalificado.Controls.Add(Me.lblPaginaWeb)
            Me.gbProveedorCalificado.Controls.Add(Me.cmbCiudad)
            Me.gbProveedorCalificado.Controls.Add(Me.lblCiudad)
            Me.gbProveedorCalificado.Controls.Add(Me.cmbProvincia)
            Me.gbProveedorCalificado.Controls.Add(Me.lblProvincia)
            Me.gbProveedorCalificado.Controls.Add(Me.cmbPais)
            Me.gbProveedorCalificado.Controls.Add(Me.lblpais)
            Me.gbProveedorCalificado.Controls.Add(Me.cmbImportador)
            Me.gbProveedorCalificado.Controls.Add(Me.lblImportador)
            Me.gbProveedorCalificado.Controls.Add(Me.txtActividad)
            Me.gbProveedorCalificado.Controls.Add(Me.lblActividad)
            Me.gbProveedorCalificado.Controls.Add(Me.txtNumeroCarpeta)
            Me.gbProveedorCalificado.Controls.Add(Me.lblNumeroCarpeta)
            Me.gbProveedorCalificado.Controls.Add(Me.dtpFechaCese)
            Me.gbProveedorCalificado.Controls.Add(Me.lblFechaCese)
            Me.gbProveedorCalificado.Controls.Add(Me.dtpFechaActualizacion)
            Me.gbProveedorCalificado.Controls.Add(Me.lblFechaActualizacion)
            Me.gbProveedorCalificado.Controls.Add(Me.dtpFechaInicio)
            Me.gbProveedorCalificado.Controls.Add(Me.lblFechaInicio)
            Me.gbProveedorCalificado.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedorCalificado.Location = New System.Drawing.Point(3, 125)
            Me.gbProveedorCalificado.Name = "gbProveedorCalificado"
            Me.gbProveedorCalificado.Size = New System.Drawing.Size(699, 182)
            Me.gbProveedorCalificado.TabIndex = 0
            Me.gbProveedorCalificado.TabStop = False
            Me.gbProveedorCalificado.Text = "DATOS PROVEEDOR CALIFICADO"
            '
            'lblIdPaises
            '
            Me.lblIdPaises.AutoSize = True
            Me.lblIdPaises.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdPaises.Location = New System.Drawing.Point(210, 73)
            Me.lblIdPaises.Name = "lblIdPaises"
            Me.lblIdPaises.Size = New System.Drawing.Size(21, 15)
            Me.lblIdPaises.TabIndex = 47
            Me.lblIdPaises.Text = "00"
            '
            'lblIdProvincia
            '
            Me.lblIdProvincia.AutoSize = True
            Me.lblIdProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProvincia.Location = New System.Drawing.Point(454, 73)
            Me.lblIdProvincia.Name = "lblIdProvincia"
            Me.lblIdProvincia.Size = New System.Drawing.Size(21, 15)
            Me.lblIdProvincia.TabIndex = 46
            Me.lblIdProvincia.Text = "00"
            '
            'lblIdCiudad
            '
            Me.lblIdCiudad.AutoSize = True
            Me.lblIdCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdCiudad.Location = New System.Drawing.Point(675, 73)
            Me.lblIdCiudad.Name = "lblIdCiudad"
            Me.lblIdCiudad.Size = New System.Drawing.Size(21, 15)
            Me.lblIdCiudad.TabIndex = 45
            Me.lblIdCiudad.Text = "00"
            '
            'txtObservaciones
            '
            Me.txtObservaciones.BackColor = System.Drawing.Color.White
            Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(115, 153)
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(573, 20)
            Me.txtObservaciones.TabIndex = 44
            '
            'lblObservaciones
            '
            Me.lblObservaciones.AutoSize = True
            Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblObservaciones.Location = New System.Drawing.Point(4, 154)
            Me.lblObservaciones.Name = "lblObservaciones"
            Me.lblObservaciones.Size = New System.Drawing.Size(111, 15)
            Me.lblObservaciones.TabIndex = 43
            Me.lblObservaciones.Text = "OBSERVACIONES:"
            '
            'txtCertificaciones
            '
            Me.txtCertificaciones.BackColor = System.Drawing.Color.White
            Me.txtCertificaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCertificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCertificaciones.Location = New System.Drawing.Point(472, 126)
            Me.txtCertificaciones.Name = "txtCertificaciones"
            Me.txtCertificaciones.Size = New System.Drawing.Size(222, 20)
            Me.txtCertificaciones.TabIndex = 42
            '
            'lblCertificaciones
            '
            Me.lblCertificaciones.AutoSize = True
            Me.lblCertificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCertificaciones.Location = New System.Drawing.Point(317, 127)
            Me.lblCertificaciones.Name = "lblCertificaciones"
            Me.lblCertificaciones.Size = New System.Drawing.Size(115, 15)
            Me.lblCertificaciones.TabIndex = 41
            Me.lblCertificaciones.Text = "CERTIFICACIONES:"
            '
            'cmbFormaPago
            '
            Me.cmbFormaPago.BackColor = System.Drawing.Color.White
            Me.cmbFormaPago.FormattingEnabled = True
            Me.cmbFormaPago.Items.AddRange(New Object() {"CREDITO CHEQUE: 15 DÍAS", "CREDITO CHEQUE: 30 DÍAS O MÁS", "CREDITO TRANSFERENCIA: 15 DÍAS", "CREDITO TRANSFERENCIA: 30 DÍAS O MÁS", "CONTADO CHEQUE", "CONTADO EFECTIVO", "CONTADO TRANSFERENCIA"})
            Me.cmbFormaPago.Location = New System.Drawing.Point(115, 126)
            Me.cmbFormaPago.Name = "cmbFormaPago"
            Me.cmbFormaPago.Size = New System.Drawing.Size(193, 21)
            Me.cmbFormaPago.TabIndex = 40
            '
            'lblFormaPago
            '
            Me.lblFormaPago.AutoSize = True
            Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFormaPago.Location = New System.Drawing.Point(4, 126)
            Me.lblFormaPago.Name = "lblFormaPago"
            Me.lblFormaPago.Size = New System.Drawing.Size(89, 15)
            Me.lblFormaPago.TabIndex = 39
            Me.lblFormaPago.Text = "FORMA PAGO:"
            '
            'txtServiciosPrestados
            '
            Me.txtServiciosPrestados.BackColor = System.Drawing.Color.White
            Me.txtServiciosPrestados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtServiciosPrestados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtServiciosPrestados.Location = New System.Drawing.Point(472, 100)
            Me.txtServiciosPrestados.Name = "txtServiciosPrestados"
            Me.txtServiciosPrestados.Size = New System.Drawing.Size(222, 20)
            Me.txtServiciosPrestados.TabIndex = 38
            '
            'lblServiciosPrestados
            '
            Me.lblServiciosPrestados.AutoSize = True
            Me.lblServiciosPrestados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblServiciosPrestados.Location = New System.Drawing.Point(317, 101)
            Me.lblServiciosPrestados.Name = "lblServiciosPrestados"
            Me.lblServiciosPrestados.Size = New System.Drawing.Size(149, 15)
            Me.lblServiciosPrestados.TabIndex = 37
            Me.lblServiciosPrestados.Text = "SERVICIOS PRESTADOS:"
            '
            'txtPaginaWeb
            '
            Me.txtPaginaWeb.BackColor = System.Drawing.Color.White
            Me.txtPaginaWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPaginaWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaginaWeb.Location = New System.Drawing.Point(109, 100)
            Me.txtPaginaWeb.Name = "txtPaginaWeb"
            Me.txtPaginaWeb.Size = New System.Drawing.Size(199, 20)
            Me.txtPaginaWeb.TabIndex = 36
            '
            'lblPaginaWeb
            '
            Me.lblPaginaWeb.AutoSize = True
            Me.lblPaginaWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPaginaWeb.Location = New System.Drawing.Point(4, 101)
            Me.lblPaginaWeb.Name = "lblPaginaWeb"
            Me.lblPaginaWeb.Size = New System.Drawing.Size(83, 15)
            Me.lblPaginaWeb.TabIndex = 35
            Me.lblPaginaWeb.Text = "PÁGINA WEB:"
            '
            'cmbCiudad
            '
            Me.cmbCiudad.BackColor = System.Drawing.Color.White
            Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCiudad.FormattingEnabled = True
            Me.cmbCiudad.Location = New System.Drawing.Point(537, 70)
            Me.cmbCiudad.Name = "cmbCiudad"
            Me.cmbCiudad.Size = New System.Drawing.Size(126, 23)
            Me.cmbCiudad.TabIndex = 34
            '
            'lblCiudad
            '
            Me.lblCiudad.AutoSize = True
            Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCiudad.Location = New System.Drawing.Point(479, 73)
            Me.lblCiudad.Name = "lblCiudad"
            Me.lblCiudad.Size = New System.Drawing.Size(55, 15)
            Me.lblCiudad.TabIndex = 33
            Me.lblCiudad.Text = "CIUDAD:"
            '
            'cmbProvincia
            '
            Me.cmbProvincia.BackColor = System.Drawing.Color.White
            Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbProvincia.FormattingEnabled = True
            Me.cmbProvincia.Location = New System.Drawing.Point(319, 70)
            Me.cmbProvincia.Name = "cmbProvincia"
            Me.cmbProvincia.Size = New System.Drawing.Size(129, 23)
            Me.cmbProvincia.TabIndex = 32
            '
            'lblProvincia
            '
            Me.lblProvincia.AutoSize = True
            Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProvincia.Location = New System.Drawing.Point(237, 73)
            Me.lblProvincia.Name = "lblProvincia"
            Me.lblProvincia.Size = New System.Drawing.Size(73, 15)
            Me.lblProvincia.TabIndex = 31
            Me.lblProvincia.Text = "PROVINCIA:"
            '
            'cmbPais
            '
            Me.cmbPais.BackColor = System.Drawing.Color.White
            Me.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPais.FormattingEnabled = True
            Me.cmbPais.Location = New System.Drawing.Point(109, 70)
            Me.cmbPais.Name = "cmbPais"
            Me.cmbPais.Size = New System.Drawing.Size(99, 23)
            Me.cmbPais.TabIndex = 30
            '
            'lblpais
            '
            Me.lblpais.AutoSize = True
            Me.lblpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblpais.Location = New System.Drawing.Point(4, 73)
            Me.lblpais.Name = "lblpais"
            Me.lblpais.Size = New System.Drawing.Size(36, 15)
            Me.lblpais.TabIndex = 29
            Me.lblpais.Text = "PAÍS:"
            '
            'cmbImportador
            '
            Me.cmbImportador.BackColor = System.Drawing.Color.White
            Me.cmbImportador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbImportador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbImportador.FormattingEnabled = True
            Me.cmbImportador.Items.AddRange(New Object() {"SI", "NO"})
            Me.cmbImportador.Location = New System.Drawing.Point(637, 43)
            Me.cmbImportador.Name = "cmbImportador"
            Me.cmbImportador.Size = New System.Drawing.Size(57, 21)
            Me.cmbImportador.TabIndex = 28
            '
            'lblImportador
            '
            Me.lblImportador.AutoSize = True
            Me.lblImportador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblImportador.Location = New System.Drawing.Point(540, 45)
            Me.lblImportador.Name = "lblImportador"
            Me.lblImportador.Size = New System.Drawing.Size(91, 15)
            Me.lblImportador.TabIndex = 27
            Me.lblImportador.Text = "IMPORTADOR:"
            '
            'txtActividad
            '
            Me.txtActividad.BackColor = System.Drawing.Color.White
            Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtActividad.Location = New System.Drawing.Point(319, 44)
            Me.txtActividad.Name = "txtActividad"
            Me.txtActividad.Size = New System.Drawing.Size(215, 20)
            Me.txtActividad.TabIndex = 26
            '
            'lblActividad
            '
            Me.lblActividad.AutoSize = True
            Me.lblActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblActividad.Location = New System.Drawing.Point(238, 45)
            Me.lblActividad.Name = "lblActividad"
            Me.lblActividad.Size = New System.Drawing.Size(70, 15)
            Me.lblActividad.TabIndex = 25
            Me.lblActividad.Text = "ACTIVIDAD:"
            '
            'txtNumeroCarpeta
            '
            Me.txtNumeroCarpeta.BackColor = System.Drawing.Color.White
            Me.txtNumeroCarpeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCarpeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumeroCarpeta.Location = New System.Drawing.Point(109, 44)
            Me.txtNumeroCarpeta.Name = "txtNumeroCarpeta"
            Me.txtNumeroCarpeta.Size = New System.Drawing.Size(99, 20)
            Me.txtNumeroCarpeta.TabIndex = 24
            '
            'lblNumeroCarpeta
            '
            Me.lblNumeroCarpeta.AutoSize = True
            Me.lblNumeroCarpeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumeroCarpeta.Location = New System.Drawing.Point(4, 45)
            Me.lblNumeroCarpeta.Name = "lblNumeroCarpeta"
            Me.lblNumeroCarpeta.Size = New System.Drawing.Size(94, 15)
            Me.lblNumeroCarpeta.TabIndex = 6
            Me.lblNumeroCarpeta.Text = "NRO CARPETA:"
            '
            'dtpFechaCese
            '
            Me.dtpFechaCese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaCese.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaCese.Location = New System.Drawing.Point(598, 16)
            Me.dtpFechaCese.Name = "dtpFechaCese"
            Me.dtpFechaCese.Size = New System.Drawing.Size(96, 21)
            Me.dtpFechaCese.TabIndex = 5
            '
            'lblFechaCese
            '
            Me.lblFechaCese.AutoSize = True
            Me.lblFechaCese.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaCese.Location = New System.Drawing.Point(508, 21)
            Me.lblFechaCese.Name = "lblFechaCese"
            Me.lblFechaCese.Size = New System.Drawing.Size(84, 15)
            Me.lblFechaCese.TabIndex = 4
            Me.lblFechaCese.Text = "FECHA CESE:"
            '
            'dtpFechaActualizacion
            '
            Me.dtpFechaActualizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaActualizacion.Location = New System.Drawing.Point(387, 17)
            Me.dtpFechaActualizacion.Name = "dtpFechaActualizacion"
            Me.dtpFechaActualizacion.Size = New System.Drawing.Size(99, 21)
            Me.dtpFechaActualizacion.TabIndex = 3
            '
            'lblFechaActualizacion
            '
            Me.lblFechaActualizacion.AutoSize = True
            Me.lblFechaActualizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaActualizacion.Location = New System.Drawing.Point(238, 22)
            Me.lblFechaActualizacion.Name = "lblFechaActualizacion"
            Me.lblFechaActualizacion.Size = New System.Drawing.Size(143, 15)
            Me.lblFechaActualizacion.TabIndex = 2
            Me.lblFechaActualizacion.Text = "FECHA ACUTALIZACIÓN:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaInicio.Location = New System.Drawing.Point(109, 17)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 21)
            Me.dtpFechaInicio.TabIndex = 1
            '
            'lblFechaInicio
            '
            Me.lblFechaInicio.AutoSize = True
            Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaInicio.Location = New System.Drawing.Point(4, 22)
            Me.lblFechaInicio.Name = "lblFechaInicio"
            Me.lblFechaInicio.Size = New System.Drawing.Size(84, 15)
            Me.lblFechaInicio.TabIndex = 0
            Me.lblFechaInicio.Text = "FECHA INICIO"
            '
            'gbProveedor
            '
            Me.gbProveedor.BackColor = System.Drawing.Color.White
            Me.gbProveedor.Controls.Add(Me.btnBuscarProveedorCalificado)
            Me.gbProveedor.Controls.Add(Me.lblIdProveedor)
            Me.gbProveedor.Controls.Add(Me.txtIdProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRazonSocialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRazonSocial)
            Me.gbProveedor.Controls.Add(Me.lblNombreComercialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbProveedor.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedor.Location = New System.Drawing.Point(3, 26)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(699, 99)
            Me.gbProveedor.TabIndex = 25
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Text = "DATOS DEL PROVEEDOR"
            '
            'btnBuscarProveedorCalificado
            '
            Me.btnBuscarProveedorCalificado.Image = CType(resources.GetObject("btnBuscarProveedorCalificado.Image"), System.Drawing.Image)
            Me.btnBuscarProveedorCalificado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBuscarProveedorCalificado.Location = New System.Drawing.Point(619, 14)
            Me.btnBuscarProveedorCalificado.Name = "btnBuscarProveedorCalificado"
            Me.btnBuscarProveedorCalificado.Size = New System.Drawing.Size(75, 23)
            Me.btnBuscarProveedorCalificado.TabIndex = 24
            Me.btnBuscarProveedorCalificado.Text = "Buscar"
            Me.btnBuscarProveedorCalificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarProveedorCalificado.UseVisualStyleBackColor = True
            '
            'lblIdProveedor
            '
            Me.lblIdProveedor.AutoSize = True
            Me.lblIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedor.Location = New System.Drawing.Point(4, 20)
            Me.lblIdProveedor.Name = "lblIdProveedor"
            Me.lblIdProveedor.Size = New System.Drawing.Size(92, 13)
            Me.lblIdProveedor.TabIndex = 0
            Me.lblIdProveedor.Text = "ID PROVEEDOR:"
            '
            'txtIdProveedorGeneral
            '
            Me.txtIdProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtIdProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdProveedorGeneral.Enabled = False
            Me.txtIdProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdProveedorGeneral.Location = New System.Drawing.Point(132, 17)
            Me.txtIdProveedorGeneral.Name = "txtIdProveedorGeneral"
            Me.txtIdProveedorGeneral.Size = New System.Drawing.Size(99, 20)
            Me.txtIdProveedorGeneral.TabIndex = 1
            '
            'lblRucCiProveedorGeneral
            '
            Me.lblRucCiProveedorGeneral.AutoSize = True
            Me.lblRucCiProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucCiProveedorGeneral.Location = New System.Drawing.Point(237, 20)
            Me.lblRucCiProveedorGeneral.Name = "lblRucCiProveedorGeneral"
            Me.lblRucCiProveedorGeneral.Size = New System.Drawing.Size(54, 13)
            Me.lblRucCiProveedorGeneral.TabIndex = 4
            Me.lblRucCiProveedorGeneral.Text = "RUC / CI:"
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtRucCiProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucCiProveedorGeneral.Enabled = False
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(297, 17)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(100, 20)
            Me.txtRucCiProveedorGeneral.TabIndex = 5
            '
            'lblRazonSocialProveedorGeneral
            '
            Me.lblRazonSocialProveedorGeneral.AutoSize = True
            Me.lblRazonSocialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazonSocialProveedorGeneral.Location = New System.Drawing.Point(4, 46)
            Me.lblRazonSocialProveedorGeneral.Name = "lblRazonSocialProveedorGeneral"
            Me.lblRazonSocialProveedorGeneral.Size = New System.Drawing.Size(89, 13)
            Me.lblRazonSocialProveedorGeneral.TabIndex = 6
            Me.lblRazonSocialProveedorGeneral.Text = "RAZON SOCIAL:"
            '
            'txtRazonSocial
            '
            Me.txtRazonSocial.BackColor = System.Drawing.Color.White
            Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonSocial.Enabled = False
            Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocial.Location = New System.Drawing.Point(132, 43)
            Me.txtRazonSocial.Name = "txtRazonSocial"
            Me.txtRazonSocial.Size = New System.Drawing.Size(562, 20)
            Me.txtRazonSocial.TabIndex = 7
            '
            'lblNombreComercialProveedorGeneral
            '
            Me.lblNombreComercialProveedorGeneral.AutoSize = True
            Me.lblNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialProveedorGeneral.Location = New System.Drawing.Point(4, 72)
            Me.lblNombreComercialProveedorGeneral.Name = "lblNombreComercialProveedorGeneral"
            Me.lblNombreComercialProveedorGeneral.Size = New System.Drawing.Size(122, 13)
            Me.lblNombreComercialProveedorGeneral.TabIndex = 8
            Me.lblNombreComercialProveedorGeneral.Text = "NOMBRE COMERCIAL:"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Enabled = False
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(132, 69)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(562, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 9
            '
            'panelAgregarEliminar
            '
            Me.panelAgregarEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelAgregarEliminar.Controls.Add(Me.lblEtiquetaContactosProveedor)
            Me.panelAgregarEliminar.Controls.Add(Me.btnEliminar)
            Me.panelAgregarEliminar.Controls.Add(Me.btnAgregar)
            Me.panelAgregarEliminar.Location = New System.Drawing.Point(3, 309)
            Me.panelAgregarEliminar.Name = "panelAgregarEliminar"
            Me.panelAgregarEliminar.Size = New System.Drawing.Size(699, 26)
            Me.panelAgregarEliminar.TabIndex = 29
            '
            'lblEtiquetaContactosProveedor
            '
            Me.lblEtiquetaContactosProveedor.AutoSize = True
            Me.lblEtiquetaContactosProveedor.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaContactosProveedor.Location = New System.Drawing.Point(253, 6)
            Me.lblEtiquetaContactosProveedor.Name = "lblEtiquetaContactosProveedor"
            Me.lblEtiquetaContactosProveedor.Size = New System.Drawing.Size(161, 13)
            Me.lblEtiquetaContactosProveedor.TabIndex = 2
            Me.lblEtiquetaContactosProveedor.Text = "CONTÁCTOS DEL PROVEEDOR"
            '
            'btnEliminar
            '
            Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
            Me.btnEliminar.Location = New System.Drawing.Point(665, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(32, 25)
            Me.btnEliminar.TabIndex = 1
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
            Me.btnAgregar.Location = New System.Drawing.Point(634, 0)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(32, 25)
            Me.btnAgregar.TabIndex = 0
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'dgvContactosProveedorCalificado
            '
            Me.dgvContactosProveedorCalificado.AllowUserToAddRows = False
            Me.dgvContactosProveedorCalificado.AllowUserToDeleteRows = False
            Me.dgvContactosProveedorCalificado.AllowUserToResizeRows = False
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvContactosProveedorCalificado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvContactosProveedorCalificado.BackgroundColor = System.Drawing.Color.White
            Me.dgvContactosProveedorCalificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvContactosProveedorCalificado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idContactoProveedorCalificado, Me.nombresContactoProveedorCalificado, Me.apellidosContactoProveedorCalificado, Me.cargoContactoProveedorCalificado, Me.telefonoContactoProveedorCalificado, Me.celularContactoProveedorCalificado, Me.emailContactoProveedorCalificado, Me.estadoContactoProveedorCalificado, Me.idProveedorGeneral})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvContactosProveedorCalificado.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvContactosProveedorCalificado.Location = New System.Drawing.Point(3, 338)
            Me.dgvContactosProveedorCalificado.Name = "dgvContactosProveedorCalificado"
            Me.dgvContactosProveedorCalificado.ReadOnly = True
            Me.dgvContactosProveedorCalificado.RowHeadersVisible = False
            Me.dgvContactosProveedorCalificado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvContactosProveedorCalificado.Size = New System.Drawing.Size(699, 181)
            Me.dgvContactosProveedorCalificado.TabIndex = 30
            '
            'idContactoProveedorCalificado
            '
            Me.idContactoProveedorCalificado.HeaderText = "ID"
            Me.idContactoProveedorCalificado.Name = "idContactoProveedorCalificado"
            Me.idContactoProveedorCalificado.ReadOnly = True
            '
            'nombresContactoProveedorCalificado
            '
            Me.nombresContactoProveedorCalificado.HeaderText = "NOMBRES"
            Me.nombresContactoProveedorCalificado.Name = "nombresContactoProveedorCalificado"
            Me.nombresContactoProveedorCalificado.ReadOnly = True
            '
            'apellidosContactoProveedorCalificado
            '
            Me.apellidosContactoProveedorCalificado.HeaderText = "APELLIDOS"
            Me.apellidosContactoProveedorCalificado.Name = "apellidosContactoProveedorCalificado"
            Me.apellidosContactoProveedorCalificado.ReadOnly = True
            '
            'cargoContactoProveedorCalificado
            '
            Me.cargoContactoProveedorCalificado.HeaderText = "CARGO"
            Me.cargoContactoProveedorCalificado.Name = "cargoContactoProveedorCalificado"
            Me.cargoContactoProveedorCalificado.ReadOnly = True
            '
            'telefonoContactoProveedorCalificado
            '
            Me.telefonoContactoProveedorCalificado.HeaderText = "TELEFONO"
            Me.telefonoContactoProveedorCalificado.Name = "telefonoContactoProveedorCalificado"
            Me.telefonoContactoProveedorCalificado.ReadOnly = True
            '
            'celularContactoProveedorCalificado
            '
            Me.celularContactoProveedorCalificado.HeaderText = "CELULAR"
            Me.celularContactoProveedorCalificado.Name = "celularContactoProveedorCalificado"
            Me.celularContactoProveedorCalificado.ReadOnly = True
            '
            'emailContactoProveedorCalificado
            '
            Me.emailContactoProveedorCalificado.HeaderText = "E-MAIL"
            Me.emailContactoProveedorCalificado.Name = "emailContactoProveedorCalificado"
            Me.emailContactoProveedorCalificado.ReadOnly = True
            '
            'estadoContactoProveedorCalificado
            '
            Me.estadoContactoProveedorCalificado.HeaderText = "EST"
            Me.estadoContactoProveedorCalificado.Name = "estadoContactoProveedorCalificado"
            Me.estadoContactoProveedorCalificado.ReadOnly = True
            '
            'idProveedorGeneral
            '
            Me.idProveedorGeneral.HeaderText = "ID PG"
            Me.idProveedorGeneral.Name = "idProveedorGeneral"
            Me.idProveedorGeneral.ReadOnly = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoProveedorCalificado, Me.btnGuardarProveedorCalificado, Me.btnCancelarProveedorCalificado})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(704, 24)
            Me.MenuStrip1.TabIndex = 189
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoProveedorCalificado
            '
            Me.btnNuevoProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevoProveedorCalificado.Name = "btnNuevoProveedorCalificado"
            Me.btnNuevoProveedorCalificado.Size = New System.Drawing.Size(74, 20)
            Me.btnNuevoProveedorCalificado.Text = "NUEVO"
            '
            'btnGuardarProveedorCalificado
            '
            Me.btnGuardarProveedorCalificado.Enabled = False
            Me.btnGuardarProveedorCalificado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardarProveedorCalificado.Name = "btnGuardarProveedorCalificado"
            Me.btnGuardarProveedorCalificado.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardarProveedorCalificado.Text = "GUARDAR"
            '
            'btnCancelarProveedorCalificado
            '
            Me.btnCancelarProveedorCalificado.Enabled = False
            Me.btnCancelarProveedorCalificado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarProveedorCalificado.Name = "btnCancelarProveedorCalificado"
            Me.btnCancelarProveedorCalificado.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelarProveedorCalificado.Text = "CANCELAR"
            '
            'FormMantenimientoProveedorCalificado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(704, 520)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvContactosProveedorCalificado)
            Me.Controls.Add(Me.panelAgregarEliminar)
            Me.Controls.Add(Me.gbProveedor)
            Me.Controls.Add(Me.gbProveedorCalificado)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormMantenimientoProveedorCalificado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MANTENIMIENTO PROVEEDOR CALIFICADO"
            Me.gbProveedorCalificado.ResumeLayout(False)
            Me.gbProveedorCalificado.PerformLayout()
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            Me.panelAgregarEliminar.ResumeLayout(False)
            Me.panelAgregarEliminar.PerformLayout()
            CType(Me.dgvContactosProveedorCalificado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbProveedorCalificado As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaCese As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaCese As System.Windows.Forms.Label
        Friend WithEvents dtpFechaActualizacion As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaActualizacion As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
        Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents lblProvincia As System.Windows.Forms.Label
        Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
        Friend WithEvents lblpais As System.Windows.Forms.Label
        Friend WithEvents cmbImportador As System.Windows.Forms.ComboBox
        Friend WithEvents lblImportador As System.Windows.Forms.Label
        Friend WithEvents txtActividad As System.Windows.Forms.TextBox
        Friend WithEvents lblActividad As System.Windows.Forms.Label
        Friend WithEvents txtNumeroCarpeta As System.Windows.Forms.TextBox
        Friend WithEvents lblNumeroCarpeta As System.Windows.Forms.Label
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
        Friend WithEvents txtIdProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblRucCiProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblRazonSocialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreComercialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblObservaciones As System.Windows.Forms.Label
        Friend WithEvents txtCertificaciones As System.Windows.Forms.TextBox
        Friend WithEvents lblCertificaciones As System.Windows.Forms.Label
        Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
        Friend WithEvents lblFormaPago As System.Windows.Forms.Label
        Friend WithEvents txtServiciosPrestados As System.Windows.Forms.TextBox
        Friend WithEvents lblServiciosPrestados As System.Windows.Forms.Label
        Friend WithEvents txtPaginaWeb As System.Windows.Forms.TextBox
        Friend WithEvents lblPaginaWeb As System.Windows.Forms.Label
        Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents lblCiudad As System.Windows.Forms.Label
        Friend WithEvents btnBuscarProveedorCalificado As System.Windows.Forms.Button
        Friend WithEvents panelAgregarEliminar As System.Windows.Forms.Panel
        Friend WithEvents lblEtiquetaContactosProveedor As System.Windows.Forms.Label
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgvContactosProveedorCalificado As System.Windows.Forms.DataGridView
        Friend WithEvents idContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nombresContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents apellidosContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cargoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents telefonoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents celularContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents emailContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents estadoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents idProveedorGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
        Friend WithEvents lblIdProvincia As System.Windows.Forms.Label
        Friend WithEvents lblIdPaises As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace