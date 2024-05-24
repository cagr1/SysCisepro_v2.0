Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEvaluacionProveedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEvaluacionProveedores))
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblProveedorEvaluado = New System.Windows.Forms.Label()
            Me.txtNombrePersonal = New System.Windows.Forms.TextBox()
            Me.lblResponsableEvaluacion = New System.Windows.Forms.Label()
            Me.lblIdPersonal = New System.Windows.Forms.Label()
            Me.lblEtiquetaFechaEvluacioProveedorServicios = New System.Windows.Forms.Label()
            Me.gbFechaEvaluacionProveedores = New System.Windows.Forms.GroupBox()
            Me.dtpFechaEvaluacion = New System.Windows.Forms.DateTimePicker()
            Me.lblFechaEvaluacionProveedor = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblIdEvlauacion = New System.Windows.Forms.Label()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.lblTipoProveedor = New System.Windows.Forms.Label()
            Me.cmbTipoProveedor = New System.Windows.Forms.ComboBox()
            Me.tcEvaluacionesProveedores = New System.Windows.Forms.TabControl()
            Me.tpEvaluacionProveedorServicios = New System.Windows.Forms.TabPage()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.lblClalificacionEvaluacionServicios = New System.Windows.Forms.Label()
            Me.lblLetreroClasificacion = New System.Windows.Forms.Label()
            Me.txtTotalEvaluacionServicios = New System.Windows.Forms.TextBox()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.cmbPregunta10Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta10Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta10Servicios = New System.Windows.Forms.Label()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.cmbPregunta9Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta9Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta9Servicios = New System.Windows.Forms.Label()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.cmbPregunta8Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta8Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta8Servicios = New System.Windows.Forms.Label()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.cmbPregunta7Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta7Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta7Servicios = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.cmbPregunta6Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta6Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta6Servicios = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.cmbPregunta5Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta5Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta5Servicios = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cmbPregunta4Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta4Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta4Servicios = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.cmbPregunta3Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta3Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta3Servicios = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.cmbPregunta2Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta2Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta2Servicios = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.cmbPregunta1Servicios = New System.Windows.Forms.ComboBox()
            Me.txtPregunta1Servicios = New System.Windows.Forms.TextBox()
            Me.lblPregunta1Servicios = New System.Windows.Forms.Label()
            Me.tpEvaluacionProveedorMateriales = New System.Windows.Forms.TabPage()
            Me.Panel12 = New System.Windows.Forms.Panel()
            Me.lblCalificacionEvaluacionMateriales = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotalEvaluacionMateriales = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel14 = New System.Windows.Forms.Panel()
            Me.cmbPregunta9Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta9Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta9Materiales = New System.Windows.Forms.Label()
            Me.Panel15 = New System.Windows.Forms.Panel()
            Me.cmbPregunta8Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta8Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta8Materiales = New System.Windows.Forms.Label()
            Me.Panel16 = New System.Windows.Forms.Panel()
            Me.cmbPregunta7Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta7Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta7Materiales = New System.Windows.Forms.Label()
            Me.Panel17 = New System.Windows.Forms.Panel()
            Me.cmbPregunta6Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta6Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta6Materiales = New System.Windows.Forms.Label()
            Me.Panel18 = New System.Windows.Forms.Panel()
            Me.cmbPregunta5Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta5Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta5Materiales = New System.Windows.Forms.Label()
            Me.Panel19 = New System.Windows.Forms.Panel()
            Me.cmbPregunta4Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta4Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta4Materiales = New System.Windows.Forms.Label()
            Me.Panel20 = New System.Windows.Forms.Panel()
            Me.cmbPregunta3Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta3Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta3Materiales = New System.Windows.Forms.Label()
            Me.Panel21 = New System.Windows.Forms.Panel()
            Me.cmbPregunta2Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta2Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta2Materiales = New System.Windows.Forms.Label()
            Me.Panel22 = New System.Windows.Forms.Panel()
            Me.cmbPregunta1Materiales = New System.Windows.Forms.ComboBox()
            Me.txtPregunta1Materiales = New System.Windows.Forms.TextBox()
            Me.lblPregunta1Materiales = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbFechaEvaluacionProveedores.SuspendLayout()
            Me.tcEvaluacionesProveedores.SuspendLayout()
            Me.tpEvaluacionProveedorServicios.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.Panel10.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.tpEvaluacionProveedorMateriales.SuspendLayout()
            Me.Panel12.SuspendLayout()
            Me.Panel14.SuspendLayout()
            Me.Panel15.SuspendLayout()
            Me.Panel16.SuspendLayout()
            Me.Panel17.SuspendLayout()
            Me.Panel18.SuspendLayout()
            Me.Panel19.SuspendLayout()
            Me.Panel20.SuspendLayout()
            Me.Panel21.SuspendLayout()
            Me.Panel22.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(529, 27)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(10, 13)
            Me.lblIdProveedorGeneral.TabIndex = 0
            Me.lblIdProveedorGeneral.Text = "."
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(180, 22)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(411, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 5
            '
            'lblProveedorEvaluado
            '
            Me.lblProveedorEvaluado.AutoSize = True
            Me.lblProveedorEvaluado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProveedorEvaluado.Location = New System.Drawing.Point(4, 25)
            Me.lblProveedorEvaluado.Name = "lblProveedorEvaluado"
            Me.lblProveedorEvaluado.Size = New System.Drawing.Size(152, 15)
            Me.lblProveedorEvaluado.TabIndex = 4
            Me.lblProveedorEvaluado.Text = "PROVEEDOR EVALUADO:"
            '
            'txtNombrePersonal
            '
            Me.txtNombrePersonal.BackColor = System.Drawing.Color.White
            Me.txtNombrePersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombrePersonal.Location = New System.Drawing.Point(180, 46)
            Me.txtNombrePersonal.Name = "txtNombrePersonal"
            Me.txtNombrePersonal.Size = New System.Drawing.Size(381, 21)
            Me.txtNombrePersonal.TabIndex = 5
            '
            'lblResponsableEvaluacion
            '
            Me.lblResponsableEvaluacion.AutoSize = True
            Me.lblResponsableEvaluacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblResponsableEvaluacion.Location = New System.Drawing.Point(4, 49)
            Me.lblResponsableEvaluacion.Name = "lblResponsableEvaluacion"
            Me.lblResponsableEvaluacion.Size = New System.Drawing.Size(176, 15)
            Me.lblResponsableEvaluacion.TabIndex = 4
            Me.lblResponsableEvaluacion.Text = "RESPONSABLE EVALUACIÓN:"
            '
            'lblIdPersonal
            '
            Me.lblIdPersonal.AutoSize = True
            Me.lblIdPersonal.Location = New System.Drawing.Point(516, 51)
            Me.lblIdPersonal.Name = "lblIdPersonal"
            Me.lblIdPersonal.Size = New System.Drawing.Size(10, 13)
            Me.lblIdPersonal.TabIndex = 0
            Me.lblIdPersonal.Text = "."
            '
            'lblEtiquetaFechaEvluacioProveedorServicios
            '
            Me.lblEtiquetaFechaEvluacioProveedorServicios.AutoSize = True
            Me.lblEtiquetaFechaEvluacioProveedorServicios.Location = New System.Drawing.Point(135, 0)
            Me.lblEtiquetaFechaEvluacioProveedorServicios.Name = "lblEtiquetaFechaEvluacioProveedorServicios"
            Me.lblEtiquetaFechaEvluacioProveedorServicios.Size = New System.Drawing.Size(134, 13)
            Me.lblEtiquetaFechaEvluacioProveedorServicios.TabIndex = 1
            Me.lblEtiquetaFechaEvluacioProveedorServicios.Text = "FECHA DE EVALUACIÓN:"
            '
            'gbFechaEvaluacionProveedores
            '
            Me.gbFechaEvaluacionProveedores.BackColor = System.Drawing.Color.White
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.dtpFechaEvaluacion)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblFechaEvaluacionProveedor)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.Label2)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblIdEvlauacion)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.btnBuscarPersonal)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblEtiquetaFechaEvluacioProveedorServicios)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.txtNombrePersonal)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblResponsableEvaluacion)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblIdPersonal)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbFechaEvaluacionProveedores.Controls.Add(Me.lblProveedorEvaluado)
            Me.gbFechaEvaluacionProveedores.Location = New System.Drawing.Point(2, 54)
            Me.gbFechaEvaluacionProveedores.Name = "gbFechaEvaluacionProveedores"
            Me.gbFechaEvaluacionProveedores.Size = New System.Drawing.Size(617, 73)
            Me.gbFechaEvaluacionProveedores.TabIndex = 9
            Me.gbFechaEvaluacionProveedores.TabStop = False
            '
            'dtpFechaEvaluacion
            '
            Me.dtpFechaEvaluacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaEvaluacion.Location = New System.Drawing.Point(274, 0)
            Me.dtpFechaEvaluacion.Name = "dtpFechaEvaluacion"
            Me.dtpFechaEvaluacion.Size = New System.Drawing.Size(140, 20)
            Me.dtpFechaEvaluacion.TabIndex = 9
            '
            'lblFechaEvaluacionProveedor
            '
            Me.lblFechaEvaluacionProveedor.AutoSize = True
            Me.lblFechaEvaluacionProveedor.Location = New System.Drawing.Point(275, 0)
            Me.lblFechaEvaluacionProveedor.Name = "lblFechaEvaluacionProveedor"
            Me.lblFechaEvaluacionProveedor.Size = New System.Drawing.Size(65, 13)
            Me.lblFechaEvaluacionProveedor.TabIndex = 8
            Me.lblFechaEvaluacionProveedor.Text = "00/00/0000"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(93, 13)
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "EVALUACIÓN N°:"
            '
            'lblIdEvlauacion
            '
            Me.lblIdEvlauacion.AutoSize = True
            Me.lblIdEvlauacion.Location = New System.Drawing.Point(104, 0)
            Me.lblIdEvlauacion.Name = "lblIdEvlauacion"
            Me.lblIdEvlauacion.Size = New System.Drawing.Size(25, 13)
            Me.lblIdEvlauacion.TabIndex = 5
            Me.lblIdEvlauacion.Text = "000"
            Me.lblIdEvlauacion.Visible = False
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.Image = CType(resources.GetObject("btnBuscarPersonal.Image"), System.Drawing.Image)
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(561, 45)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(30, 23)
            Me.btnBuscarPersonal.TabIndex = 6
            Me.btnBuscarPersonal.UseVisualStyleBackColor = True
            '
            'lblTipoProveedor
            '
            Me.lblTipoProveedor.AutoSize = True
            Me.lblTipoProveedor.Location = New System.Drawing.Point(321, 32)
            Me.lblTipoProveedor.Name = "lblTipoProveedor"
            Me.lblTipoProveedor.Size = New System.Drawing.Size(106, 13)
            Me.lblTipoProveedor.TabIndex = 6
            Me.lblTipoProveedor.Text = "TIPO PROVEEDOR:"
            '
            'cmbTipoProveedor
            '
            Me.cmbTipoProveedor.BackColor = System.Drawing.Color.White
            Me.cmbTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbTipoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipoProveedor.FormattingEnabled = True
            Me.cmbTipoProveedor.Items.AddRange(New Object() {"SERVICIOS", "MATERIALES"})
            Me.cmbTipoProveedor.Location = New System.Drawing.Point(433, 28)
            Me.cmbTipoProveedor.Name = "cmbTipoProveedor"
            Me.cmbTipoProveedor.Size = New System.Drawing.Size(182, 23)
            Me.cmbTipoProveedor.TabIndex = 5
            '
            'tcEvaluacionesProveedores
            '
            Me.tcEvaluacionesProveedores.Controls.Add(Me.tpEvaluacionProveedorServicios)
            Me.tcEvaluacionesProveedores.Controls.Add(Me.tpEvaluacionProveedorMateriales)
            Me.tcEvaluacionesProveedores.Location = New System.Drawing.Point(-2, 128)
            Me.tcEvaluacionesProveedores.Name = "tcEvaluacionesProveedores"
            Me.tcEvaluacionesProveedores.SelectedIndex = 0
            Me.tcEvaluacionesProveedores.Size = New System.Drawing.Size(625, 539)
            Me.tcEvaluacionesProveedores.TabIndex = 29
            '
            'tpEvaluacionProveedorServicios
            '
            Me.tpEvaluacionProveedorServicios.BackColor = System.Drawing.Color.White
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel11)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel10)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel9)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel8)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel7)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel6)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel5)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel4)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel3)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel2)
            Me.tpEvaluacionProveedorServicios.Controls.Add(Me.Panel1)
            Me.tpEvaluacionProveedorServicios.Location = New System.Drawing.Point(4, 22)
            Me.tpEvaluacionProveedorServicios.Name = "tpEvaluacionProveedorServicios"
            Me.tpEvaluacionProveedorServicios.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEvaluacionProveedorServicios.Size = New System.Drawing.Size(617, 513)
            Me.tpEvaluacionProveedorServicios.TabIndex = 0
            Me.tpEvaluacionProveedorServicios.Text = "PROVEEDOR SERVICIOS"
            '
            'Panel11
            '
            Me.Panel11.BackColor = System.Drawing.Color.White
            Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel11.Controls.Add(Me.lblClalificacionEvaluacionServicios)
            Me.Panel11.Controls.Add(Me.lblLetreroClasificacion)
            Me.Panel11.Controls.Add(Me.txtTotalEvaluacionServicios)
            Me.Panel11.Controls.Add(Me.lblTotal)
            Me.Panel11.Location = New System.Drawing.Point(0, 460)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(617, 50)
            Me.Panel11.TabIndex = 29
            '
            'lblClalificacionEvaluacionServicios
            '
            Me.lblClalificacionEvaluacionServicios.AutoSize = True
            Me.lblClalificacionEvaluacionServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblClalificacionEvaluacionServicios.Location = New System.Drawing.Point(183, 9)
            Me.lblClalificacionEvaluacionServicios.Name = "lblClalificacionEvaluacionServicios"
            Me.lblClalificacionEvaluacionServicios.Size = New System.Drawing.Size(0, 24)
            Me.lblClalificacionEvaluacionServicios.TabIndex = 3
            '
            'lblLetreroClasificacion
            '
            Me.lblLetreroClasificacion.AutoSize = True
            Me.lblLetreroClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLetreroClasificacion.Location = New System.Drawing.Point(3, 3)
            Me.lblLetreroClasificacion.Name = "lblLetreroClasificacion"
            Me.lblLetreroClasificacion.Size = New System.Drawing.Size(128, 36)
            Me.lblLetreroClasificacion.TabIndex = 2
            Me.lblLetreroClasificacion.Text = "CLASIFICACION                     (%)    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor FIJO                  75-100" & _
                "%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor OCASIONAL      65-74%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor DESCARTADO   0-64%"
            '
            'txtTotalEvaluacionServicios
            '
            Me.txtTotalEvaluacionServicios.BackColor = System.Drawing.Color.White
            Me.txtTotalEvaluacionServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEvaluacionServicios.Location = New System.Drawing.Point(553, 3)
            Me.txtTotalEvaluacionServicios.Multiline = True
            Me.txtTotalEvaluacionServicios.Name = "txtTotalEvaluacionServicios"
            Me.txtTotalEvaluacionServicios.Size = New System.Drawing.Size(60, 39)
            Me.txtTotalEvaluacionServicios.TabIndex = 1
            Me.txtTotalEvaluacionServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Location = New System.Drawing.Point(487, 14)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(45, 13)
            Me.lblTotal.TabIndex = 0
            Me.lblTotal.Text = "TOTAL:"
            '
            'Panel10
            '
            Me.Panel10.BackColor = System.Drawing.Color.White
            Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel10.Controls.Add(Me.cmbPregunta10Servicios)
            Me.Panel10.Controls.Add(Me.txtPregunta10Servicios)
            Me.Panel10.Controls.Add(Me.lblPregunta10Servicios)
            Me.Panel10.Location = New System.Drawing.Point(0, 414)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(617, 47)
            Me.Panel10.TabIndex = 28
            '
            'cmbPregunta10Servicios
            '
            Me.cmbPregunta10Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta10Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta10Servicios.DropDownWidth = 500
            Me.cmbPregunta10Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta10Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta10Servicios.FormattingEnabled = True
            Me.cmbPregunta10Servicios.Items.AddRange(New Object() {"(   0% ) - NO FACILITA NINGÚN TIPO DE INFORMACIÓN", "(   5% ) - FACILITA INFORMACIÓN SOLO SI ES UNA EXIGENCIA, EN CASOS PUNTUALES", "( 10% ) - FACILITA DOCUMENTACIÓN COMO: PERMISOS LEGALES, CERTIFICADOS DE CALIDAD," & _
                            " ETC."})
            Me.cmbPregunta10Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta10Servicios.Name = "cmbPregunta10Servicios"
            Me.cmbPregunta10Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta10Servicios.TabIndex = 2
            '
            'txtPregunta10Servicios
            '
            Me.txtPregunta10Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta10Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta10Servicios.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta10Servicios.Multiline = True
            Me.txtPregunta10Servicios.Name = "txtPregunta10Servicios"
            Me.txtPregunta10Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta10Servicios.TabIndex = 1
            Me.txtPregunta10Servicios.Text = "0"
            Me.txtPregunta10Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta10Servicios
            '
            Me.lblPregunta10Servicios.AutoSize = True
            Me.lblPregunta10Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta10Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta10Servicios.Name = "lblPregunta10Servicios"
            Me.lblPregunta10Servicios.Size = New System.Drawing.Size(529, 13)
            Me.lblPregunta10Servicios.TabIndex = 0
            Me.lblPregunta10Servicios.Text = "DOCUMENTOS ACTUALIZADOS RESPALDO DEL SERVICIO (Permisos Legales, Certificados, In" & _
                "formes, etc.)"
            '
            'Panel9
            '
            Me.Panel9.BackColor = System.Drawing.Color.White
            Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel9.Controls.Add(Me.cmbPregunta9Servicios)
            Me.Panel9.Controls.Add(Me.txtPregunta9Servicios)
            Me.Panel9.Controls.Add(Me.lblPregunta9Servicios)
            Me.Panel9.Location = New System.Drawing.Point(0, 368)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(617, 47)
            Me.Panel9.TabIndex = 27
            '
            'cmbPregunta9Servicios
            '
            Me.cmbPregunta9Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta9Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta9Servicios.DropDownWidth = 500
            Me.cmbPregunta9Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta9Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta9Servicios.FormattingEnabled = True
            Me.cmbPregunta9Servicios.Items.AddRange(New Object() {"(   0% ) - NO EXIXTE SOPORTE TÉCNICO", "( 20% ) - SOLO EN LA CIUDAD"})
            Me.cmbPregunta9Servicios.Location = New System.Drawing.Point(19, 20)
            Me.cmbPregunta9Servicios.Name = "cmbPregunta9Servicios"
            Me.cmbPregunta9Servicios.Size = New System.Drawing.Size(390, 23)
            Me.cmbPregunta9Servicios.TabIndex = 2
            '
            'txtPregunta9Servicios
            '
            Me.txtPregunta9Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta9Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta9Servicios.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta9Servicios.Multiline = True
            Me.txtPregunta9Servicios.Name = "txtPregunta9Servicios"
            Me.txtPregunta9Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta9Servicios.TabIndex = 1
            Me.txtPregunta9Servicios.Text = "0"
            Me.txtPregunta9Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta9Servicios
            '
            Me.lblPregunta9Servicios.AutoSize = True
            Me.lblPregunta9Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta9Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta9Servicios.Name = "lblPregunta9Servicios"
            Me.lblPregunta9Servicios.Size = New System.Drawing.Size(112, 13)
            Me.lblPregunta9Servicios.TabIndex = 0
            Me.lblPregunta9Servicios.Text = "SOPORTE TÉCNICO:"
            '
            'Panel8
            '
            Me.Panel8.BackColor = System.Drawing.Color.White
            Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel8.Controls.Add(Me.cmbPregunta8Servicios)
            Me.Panel8.Controls.Add(Me.txtPregunta8Servicios)
            Me.Panel8.Controls.Add(Me.lblPregunta8Servicios)
            Me.Panel8.Location = New System.Drawing.Point(0, 322)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(617, 47)
            Me.Panel8.TabIndex = 26
            '
            'cmbPregunta8Servicios
            '
            Me.cmbPregunta8Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta8Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta8Servicios.DropDownWidth = 500
            Me.cmbPregunta8Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta8Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta8Servicios.FormattingEnabled = True
            Me.cmbPregunta8Servicios.Items.AddRange(New Object() {"( 0% ) - NO PRESENTA GARANTÍAS", "( 5% ) - SI PRESENTA GARANTÍAS O NO APLICA"})
            Me.cmbPregunta8Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta8Servicios.Name = "cmbPregunta8Servicios"
            Me.cmbPregunta8Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta8Servicios.TabIndex = 2
            '
            'txtPregunta8Servicios
            '
            Me.txtPregunta8Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta8Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta8Servicios.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta8Servicios.Multiline = True
            Me.txtPregunta8Servicios.Name = "txtPregunta8Servicios"
            Me.txtPregunta8Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta8Servicios.TabIndex = 1
            Me.txtPregunta8Servicios.Text = "0"
            Me.txtPregunta8Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta8Servicios
            '
            Me.lblPregunta8Servicios.AutoSize = True
            Me.lblPregunta8Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta8Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta8Servicios.Name = "lblPregunta8Servicios"
            Me.lblPregunta8Servicios.Size = New System.Drawing.Size(142, 13)
            Me.lblPregunta8Servicios.TabIndex = 0
            Me.lblPregunta8Servicios.Text = "GARANTÍAS Y PÓLIZAS:    "
            '
            'Panel7
            '
            Me.Panel7.BackColor = System.Drawing.Color.White
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.cmbPregunta7Servicios)
            Me.Panel7.Controls.Add(Me.txtPregunta7Servicios)
            Me.Panel7.Controls.Add(Me.lblPregunta7Servicios)
            Me.Panel7.Location = New System.Drawing.Point(0, 276)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(617, 47)
            Me.Panel7.TabIndex = 25
            '
            'cmbPregunta7Servicios
            '
            Me.cmbPregunta7Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta7Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta7Servicios.DropDownWidth = 500
            Me.cmbPregunta7Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta7Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta7Servicios.FormattingEnabled = True
            Me.cmbPregunta7Servicios.Items.AddRange(New Object() {"( 2% ) DE 15 A 30 DÍAS", "( 5% ) D3 30 DÍAS EN ADELANTE"})
            Me.cmbPregunta7Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta7Servicios.Name = "cmbPregunta7Servicios"
            Me.cmbPregunta7Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta7Servicios.TabIndex = 2
            '
            'txtPregunta7Servicios
            '
            Me.txtPregunta7Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta7Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta7Servicios.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta7Servicios.Multiline = True
            Me.txtPregunta7Servicios.Name = "txtPregunta7Servicios"
            Me.txtPregunta7Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta7Servicios.TabIndex = 1
            Me.txtPregunta7Servicios.Text = "0"
            Me.txtPregunta7Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta7Servicios
            '
            Me.lblPregunta7Servicios.AutoSize = True
            Me.lblPregunta7Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta7Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta7Servicios.Name = "lblPregunta7Servicios"
            Me.lblPregunta7Servicios.Size = New System.Drawing.Size(117, 13)
            Me.lblPregunta7Servicios.TabIndex = 0
            Me.lblPregunta7Servicios.Text = "CONDICIONES PAGO:"
            '
            'Panel6
            '
            Me.Panel6.BackColor = System.Drawing.Color.White
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.cmbPregunta6Servicios)
            Me.Panel6.Controls.Add(Me.txtPregunta6Servicios)
            Me.Panel6.Controls.Add(Me.lblPregunta6Servicios)
            Me.Panel6.Location = New System.Drawing.Point(0, 230)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(617, 47)
            Me.Panel6.TabIndex = 24
            '
            'cmbPregunta6Servicios
            '
            Me.cmbPregunta6Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta6Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta6Servicios.DropDownWidth = 500
            Me.cmbPregunta6Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta6Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta6Servicios.FormattingEnabled = True
            Me.cmbPregunta6Servicios.Items.AddRange(New Object() {"(   2% ) - PRECIO SUPERIOR AL MERCADO", "(   5% ) - PRECIO COMPETITIVO", "( 10% ) - PRECIO INFERIOR AL MERCADO"})
            Me.cmbPregunta6Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta6Servicios.Name = "cmbPregunta6Servicios"
            Me.cmbPregunta6Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta6Servicios.TabIndex = 2
            '
            'txtPregunta6Servicios
            '
            Me.txtPregunta6Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta6Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta6Servicios.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta6Servicios.Multiline = True
            Me.txtPregunta6Servicios.Name = "txtPregunta6Servicios"
            Me.txtPregunta6Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta6Servicios.TabIndex = 1
            Me.txtPregunta6Servicios.Text = "0"
            Me.txtPregunta6Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta6Servicios
            '
            Me.lblPregunta6Servicios.AutoSize = True
            Me.lblPregunta6Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta6Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta6Servicios.Name = "lblPregunta6Servicios"
            Me.lblPregunta6Servicios.Size = New System.Drawing.Size(50, 13)
            Me.lblPregunta6Servicios.TabIndex = 0
            Me.lblPregunta6Servicios.Text = "PRECIO:"
            '
            'Panel5
            '
            Me.Panel5.BackColor = System.Drawing.Color.White
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.cmbPregunta5Servicios)
            Me.Panel5.Controls.Add(Me.txtPregunta5Servicios)
            Me.Panel5.Controls.Add(Me.lblPregunta5Servicios)
            Me.Panel5.Location = New System.Drawing.Point(0, 184)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(617, 47)
            Me.Panel5.TabIndex = 23
            '
            'cmbPregunta5Servicios
            '
            Me.cmbPregunta5Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta5Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta5Servicios.DropDownWidth = 500
            Me.cmbPregunta5Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta5Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta5Servicios.FormattingEnabled = True
            Me.cmbPregunta5Servicios.Items.AddRange(New Object() {"(   5% ) - PERMANENTES RETRASOS", "( 10% ) - PRESENTA RETRASOS ESPORADICOS", "( 15% ) - NUNCA PRESENTA RETRASOS CON LAS ENTREGAS"})
            Me.cmbPregunta5Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta5Servicios.Name = "cmbPregunta5Servicios"
            Me.cmbPregunta5Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta5Servicios.TabIndex = 2
            '
            'txtPregunta5Servicios
            '
            Me.txtPregunta5Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta5Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta5Servicios.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta5Servicios.Multiline = True
            Me.txtPregunta5Servicios.Name = "txtPregunta5Servicios"
            Me.txtPregunta5Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta5Servicios.TabIndex = 1
            Me.txtPregunta5Servicios.Text = "0"
            Me.txtPregunta5Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta5Servicios
            '
            Me.lblPregunta5Servicios.AutoSize = True
            Me.lblPregunta5Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta5Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta5Servicios.Name = "lblPregunta5Servicios"
            Me.lblPregunta5Servicios.Size = New System.Drawing.Size(293, 13)
            Me.lblPregunta5Servicios.TabIndex = 0
            Me.lblPregunta5Servicios.Text = "CUMPLIMIENTO TIEMPOS DE ENTREGA DEL SERVICIO:"
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.White
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.cmbPregunta4Servicios)
            Me.Panel4.Controls.Add(Me.txtPregunta4Servicios)
            Me.Panel4.Controls.Add(Me.lblPregunta4Servicios)
            Me.Panel4.Location = New System.Drawing.Point(0, 138)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(617, 47)
            Me.Panel4.TabIndex = 22
            '
            'cmbPregunta4Servicios
            '
            Me.cmbPregunta4Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta4Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta4Servicios.DropDownWidth = 500
            Me.cmbPregunta4Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta4Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta4Servicios.FormattingEnabled = True
            Me.cmbPregunta4Servicios.Items.AddRange(New Object() {"( 2% ) - SIEMPRE TRANSCURRE UN TIEMPO PARA RECIBIR RESPUESTA", "( 4% ) - RESPUESTA CASI INMEDIATA", "( 5% ) - RESPUESTA INMEDIATA Y GENERALMENTE PERSONAL"})
            Me.cmbPregunta4Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta4Servicios.Name = "cmbPregunta4Servicios"
            Me.cmbPregunta4Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta4Servicios.TabIndex = 2
            '
            'txtPregunta4Servicios
            '
            Me.txtPregunta4Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta4Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta4Servicios.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta4Servicios.Multiline = True
            Me.txtPregunta4Servicios.Name = "txtPregunta4Servicios"
            Me.txtPregunta4Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta4Servicios.TabIndex = 1
            Me.txtPregunta4Servicios.Text = "0"
            Me.txtPregunta4Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta4Servicios
            '
            Me.lblPregunta4Servicios.AutoSize = True
            Me.lblPregunta4Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta4Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta4Servicios.Name = "lblPregunta4Servicios"
            Me.lblPregunta4Servicios.Size = New System.Drawing.Size(273, 13)
            Me.lblPregunta4Servicios.TabIndex = 0
            Me.lblPregunta4Servicios.Text = "TIEMPO RESPUESTA A SOLICITUD, INFORMACIÓN: "
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.White
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.cmbPregunta3Servicios)
            Me.Panel3.Controls.Add(Me.txtPregunta3Servicios)
            Me.Panel3.Controls.Add(Me.lblPregunta3Servicios)
            Me.Panel3.Location = New System.Drawing.Point(0, 92)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(617, 47)
            Me.Panel3.TabIndex = 21
            '
            'cmbPregunta3Servicios
            '
            Me.cmbPregunta3Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta3Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta3Servicios.DropDownWidth = 500
            Me.cmbPregunta3Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta3Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta3Servicios.FormattingEnabled = True
            Me.cmbPregunta3Servicios.Items.AddRange(New Object() {"(   5% ) - TRANSPORTE RENTADO", "( 10% ) - TRANSPORTE PROPIO", "( 10% ) - TRANSPORTE NO ES NECESARIO"})
            Me.cmbPregunta3Servicios.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta3Servicios.Name = "cmbPregunta3Servicios"
            Me.cmbPregunta3Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta3Servicios.TabIndex = 2
            '
            'txtPregunta3Servicios
            '
            Me.txtPregunta3Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta3Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta3Servicios.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta3Servicios.Multiline = True
            Me.txtPregunta3Servicios.Name = "txtPregunta3Servicios"
            Me.txtPregunta3Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta3Servicios.TabIndex = 1
            Me.txtPregunta3Servicios.Text = "0"
            Me.txtPregunta3Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta3Servicios
            '
            Me.lblPregunta3Servicios.AutoSize = True
            Me.lblPregunta3Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta3Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta3Servicios.Name = "lblPregunta3Servicios"
            Me.lblPregunta3Servicios.Size = New System.Drawing.Size(84, 13)
            Me.lblPregunta3Servicios.TabIndex = 0
            Me.lblPregunta3Servicios.Text = "TRANSPORTE:"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.White
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.cmbPregunta2Servicios)
            Me.Panel2.Controls.Add(Me.txtPregunta2Servicios)
            Me.Panel2.Controls.Add(Me.lblPregunta2Servicios)
            Me.Panel2.Location = New System.Drawing.Point(0, 46)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(617, 47)
            Me.Panel2.TabIndex = 20
            '
            'cmbPregunta2Servicios
            '
            Me.cmbPregunta2Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta2Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta2Servicios.DropDownWidth = 500
            Me.cmbPregunta2Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta2Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta2Servicios.FormattingEnabled = True
            Me.cmbPregunta2Servicios.Items.AddRange(New Object() {"(   5% ) - NO DISPONE DE PERSONAL ADICIONAL Y SI ES NECESARIO", "( 10% ) - NO DISPONE DE PERSONAL ADICIONAL Y NO ES NECESARIO", "( 10% ) - PRESENTACIÓN DE ROL DEL IESS"})
            Me.cmbPregunta2Servicios.Location = New System.Drawing.Point(16, 19)
            Me.cmbPregunta2Servicios.Name = "cmbPregunta2Servicios"
            Me.cmbPregunta2Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta2Servicios.TabIndex = 2
            '
            'txtPregunta2Servicios
            '
            Me.txtPregunta2Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta2Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta2Servicios.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta2Servicios.Multiline = True
            Me.txtPregunta2Servicios.Name = "txtPregunta2Servicios"
            Me.txtPregunta2Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta2Servicios.TabIndex = 1
            Me.txtPregunta2Servicios.Text = "0"
            Me.txtPregunta2Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta2Servicios
            '
            Me.lblPregunta2Servicios.AutoSize = True
            Me.lblPregunta2Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta2Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta2Servicios.Name = "lblPregunta2Servicios"
            Me.lblPregunta2Servicios.Size = New System.Drawing.Size(115, 13)
            Me.lblPregunta2Servicios.TabIndex = 0
            Me.lblPregunta2Servicios.Text = "PERSONAL PROPIO: "
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.cmbPregunta1Servicios)
            Me.Panel1.Controls.Add(Me.txtPregunta1Servicios)
            Me.Panel1.Controls.Add(Me.lblPregunta1Servicios)
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(617, 47)
            Me.Panel1.TabIndex = 19
            '
            'cmbPregunta1Servicios
            '
            Me.cmbPregunta1Servicios.BackColor = System.Drawing.Color.White
            Me.cmbPregunta1Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta1Servicios.DropDownWidth = 500
            Me.cmbPregunta1Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta1Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta1Servicios.FormattingEnabled = True
            Me.cmbPregunta1Servicios.Items.AddRange(New Object() {"(   5% ) - ALQUILADAS U OTRO", "( 10% ) - PROPIA"})
            Me.cmbPregunta1Servicios.Location = New System.Drawing.Point(16, 19)
            Me.cmbPregunta1Servicios.Name = "cmbPregunta1Servicios"
            Me.cmbPregunta1Servicios.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta1Servicios.TabIndex = 2
            '
            'txtPregunta1Servicios
            '
            Me.txtPregunta1Servicios.BackColor = System.Drawing.Color.White
            Me.txtPregunta1Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta1Servicios.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta1Servicios.Multiline = True
            Me.txtPregunta1Servicios.Name = "txtPregunta1Servicios"
            Me.txtPregunta1Servicios.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta1Servicios.TabIndex = 1
            Me.txtPregunta1Servicios.Text = "0"
            Me.txtPregunta1Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta1Servicios
            '
            Me.lblPregunta1Servicios.AutoSize = True
            Me.lblPregunta1Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta1Servicios.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta1Servicios.Name = "lblPregunta1Servicios"
            Me.lblPregunta1Servicios.Size = New System.Drawing.Size(95, 13)
            Me.lblPregunta1Servicios.TabIndex = 0
            Me.lblPregunta1Servicios.Text = "INSTALACIONES:"
            '
            'tpEvaluacionProveedorMateriales
            '
            Me.tpEvaluacionProveedorMateriales.BackColor = System.Drawing.Color.White
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel12)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel14)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel15)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel16)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel17)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel18)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel19)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel20)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel21)
            Me.tpEvaluacionProveedorMateriales.Controls.Add(Me.Panel22)
            Me.tpEvaluacionProveedorMateriales.Location = New System.Drawing.Point(4, 22)
            Me.tpEvaluacionProveedorMateriales.Name = "tpEvaluacionProveedorMateriales"
            Me.tpEvaluacionProveedorMateriales.Padding = New System.Windows.Forms.Padding(3)
            Me.tpEvaluacionProveedorMateriales.Size = New System.Drawing.Size(617, 513)
            Me.tpEvaluacionProveedorMateriales.TabIndex = 1
            Me.tpEvaluacionProveedorMateriales.Text = "PROVEEDOR MATERIALES"
            '
            'Panel12
            '
            Me.Panel12.BackColor = System.Drawing.Color.White
            Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel12.Controls.Add(Me.lblCalificacionEvaluacionMateriales)
            Me.Panel12.Controls.Add(Me.Label3)
            Me.Panel12.Controls.Add(Me.Label4)
            Me.Panel12.Controls.Add(Me.txtTotalEvaluacionMateriales)
            Me.Panel12.Controls.Add(Me.Label5)
            Me.Panel12.Location = New System.Drawing.Point(0, 414)
            Me.Panel12.Name = "Panel12"
            Me.Panel12.Size = New System.Drawing.Size(617, 96)
            Me.Panel12.TabIndex = 40
            '
            'lblCalificacionEvaluacionMateriales
            '
            Me.lblCalificacionEvaluacionMateriales.AutoSize = True
            Me.lblCalificacionEvaluacionMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCalificacionEvaluacionMateriales.Location = New System.Drawing.Point(204, 7)
            Me.lblCalificacionEvaluacionMateriales.Name = "lblCalificacionEvaluacionMateriales"
            Me.lblCalificacionEvaluacionMateriales.Size = New System.Drawing.Size(0, 24)
            Me.lblCalificacionEvaluacionMateriales.TabIndex = 4
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(183, 9)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(0, 24)
            Me.Label3.TabIndex = 3
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(3, 3)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(176, 52)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "CLASIFICACION                     (%)    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor FIJO                  75-100" & _
                "%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor OCASIONAL      65-74%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor DESCARTADO   0-64%"
            '
            'txtTotalEvaluacionMateriales
            '
            Me.txtTotalEvaluacionMateriales.BackColor = System.Drawing.Color.White
            Me.txtTotalEvaluacionMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalEvaluacionMateriales.Location = New System.Drawing.Point(553, 3)
            Me.txtTotalEvaluacionMateriales.Multiline = True
            Me.txtTotalEvaluacionMateriales.Name = "txtTotalEvaluacionMateriales"
            Me.txtTotalEvaluacionMateriales.Size = New System.Drawing.Size(60, 39)
            Me.txtTotalEvaluacionMateriales.TabIndex = 1
            Me.txtTotalEvaluacionMateriales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(487, 14)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(45, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "TOTAL:"
            '
            'Panel14
            '
            Me.Panel14.BackColor = System.Drawing.Color.White
            Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel14.Controls.Add(Me.cmbPregunta9Materiales)
            Me.Panel14.Controls.Add(Me.txtPregunta9Materiales)
            Me.Panel14.Controls.Add(Me.lblPregunta9Materiales)
            Me.Panel14.Location = New System.Drawing.Point(0, 368)
            Me.Panel14.Name = "Panel14"
            Me.Panel14.Size = New System.Drawing.Size(617, 47)
            Me.Panel14.TabIndex = 38
            '
            'cmbPregunta9Materiales
            '
            Me.cmbPregunta9Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta9Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta9Materiales.DropDownWidth = 550
            Me.cmbPregunta9Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta9Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta9Materiales.FormattingEnabled = True
            Me.cmbPregunta9Materiales.Items.AddRange(New Object() {"(   5% ) - SE HAN PRESENTADO RECHAZOS DE MATERIAL EN LA OBRA O EN LA RECEPCIÓN", "( 18% ) - SE HAN PRESENTADO RECHAZOS DE MATERIAL EN LA RECEPCIÓN", "( 24% ) - EN POCAS OCACIONES SE HA PRESENTADO RECHAZOS DE MATERIAL", "( 30% ) - NUNCA SE HAN PRESENTADO PROBLEMAS DE MATERIAL"})
            Me.cmbPregunta9Materiales.Location = New System.Drawing.Point(19, 20)
            Me.cmbPregunta9Materiales.Name = "cmbPregunta9Materiales"
            Me.cmbPregunta9Materiales.Size = New System.Drawing.Size(390, 23)
            Me.cmbPregunta9Materiales.TabIndex = 2
            '
            'txtPregunta9Materiales
            '
            Me.txtPregunta9Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta9Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta9Materiales.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta9Materiales.Multiline = True
            Me.txtPregunta9Materiales.Name = "txtPregunta9Materiales"
            Me.txtPregunta9Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta9Materiales.TabIndex = 1
            Me.txtPregunta9Materiales.Text = "0"
            Me.txtPregunta9Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta9Materiales
            '
            Me.lblPregunta9Materiales.AutoSize = True
            Me.lblPregunta9Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta9Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta9Materiales.Name = "lblPregunta9Materiales"
            Me.lblPregunta9Materiales.Size = New System.Drawing.Size(134, 13)
            Me.lblPregunta9Materiales.TabIndex = 0
            Me.lblPregunta9Materiales.Text = "CALIDAD DEL MATERIAL"
            '
            'Panel15
            '
            Me.Panel15.BackColor = System.Drawing.Color.White
            Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel15.Controls.Add(Me.cmbPregunta8Materiales)
            Me.Panel15.Controls.Add(Me.txtPregunta8Materiales)
            Me.Panel15.Controls.Add(Me.lblPregunta8Materiales)
            Me.Panel15.Location = New System.Drawing.Point(0, 322)
            Me.Panel15.Name = "Panel15"
            Me.Panel15.Size = New System.Drawing.Size(617, 47)
            Me.Panel15.TabIndex = 37
            '
            'cmbPregunta8Materiales
            '
            Me.cmbPregunta8Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta8Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta8Materiales.DropDownWidth = 550
            Me.cmbPregunta8Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta8Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta8Materiales.FormattingEnabled = True
            Me.cmbPregunta8Materiales.Items.AddRange(New Object() {"( 2% ) - NO BRINDA SERVICIOS ASOCIADOS", "( 5% ) - BRINDA SERVICIOS ASOCIADOS DE CUALQUIER TIPO"})
            Me.cmbPregunta8Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta8Materiales.Name = "cmbPregunta8Materiales"
            Me.cmbPregunta8Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta8Materiales.TabIndex = 2
            '
            'txtPregunta8Materiales
            '
            Me.txtPregunta8Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta8Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta8Materiales.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta8Materiales.Multiline = True
            Me.txtPregunta8Materiales.Name = "txtPregunta8Materiales"
            Me.txtPregunta8Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta8Materiales.TabIndex = 1
            Me.txtPregunta8Materiales.Text = "0"
            Me.txtPregunta8Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta8Materiales
            '
            Me.lblPregunta8Materiales.AutoSize = True
            Me.lblPregunta8Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta8Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta8Materiales.Name = "lblPregunta8Materiales"
            Me.lblPregunta8Materiales.Size = New System.Drawing.Size(247, 13)
            Me.lblPregunta8Materiales.TabIndex = 0
            Me.lblPregunta8Materiales.Text = "SERVICIOS ASOCIADOS (Instalación, Instrucción)"
            '
            'Panel16
            '
            Me.Panel16.BackColor = System.Drawing.Color.White
            Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel16.Controls.Add(Me.cmbPregunta7Materiales)
            Me.Panel16.Controls.Add(Me.txtPregunta7Materiales)
            Me.Panel16.Controls.Add(Me.lblPregunta7Materiales)
            Me.Panel16.Location = New System.Drawing.Point(0, 276)
            Me.Panel16.Name = "Panel16"
            Me.Panel16.Size = New System.Drawing.Size(617, 47)
            Me.Panel16.TabIndex = 36
            '
            'cmbPregunta7Materiales
            '
            Me.cmbPregunta7Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta7Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta7Materiales.DropDownWidth = 550
            Me.cmbPregunta7Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta7Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta7Materiales.FormattingEnabled = True
            Me.cmbPregunta7Materiales.Items.AddRange(New Object() {"( 0% ) - NO EXISTE SOPORTE TÉCNICO", "( 2% ) - SOLO EN LA CIUDAD", "( 5% ) - EN CIUDAD O EN OBRA, O NO ES REQUERIDO"})
            Me.cmbPregunta7Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta7Materiales.Name = "cmbPregunta7Materiales"
            Me.cmbPregunta7Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta7Materiales.TabIndex = 2
            '
            'txtPregunta7Materiales
            '
            Me.txtPregunta7Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta7Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta7Materiales.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta7Materiales.Multiline = True
            Me.txtPregunta7Materiales.Name = "txtPregunta7Materiales"
            Me.txtPregunta7Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta7Materiales.TabIndex = 1
            Me.txtPregunta7Materiales.Text = "0"
            Me.txtPregunta7Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta7Materiales
            '
            Me.lblPregunta7Materiales.AutoSize = True
            Me.lblPregunta7Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta7Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta7Materiales.Name = "lblPregunta7Materiales"
            Me.lblPregunta7Materiales.Size = New System.Drawing.Size(109, 13)
            Me.lblPregunta7Materiales.TabIndex = 0
            Me.lblPregunta7Materiales.Text = "SOPORTE TÉCNICO"
            '
            'Panel17
            '
            Me.Panel17.BackColor = System.Drawing.Color.White
            Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel17.Controls.Add(Me.cmbPregunta6Materiales)
            Me.Panel17.Controls.Add(Me.txtPregunta6Materiales)
            Me.Panel17.Controls.Add(Me.lblPregunta6Materiales)
            Me.Panel17.Location = New System.Drawing.Point(0, 230)
            Me.Panel17.Name = "Panel17"
            Me.Panel17.Size = New System.Drawing.Size(617, 47)
            Me.Panel17.TabIndex = 35
            '
            'cmbPregunta6Materiales
            '
            Me.cmbPregunta6Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta6Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta6Materiales.DropDownWidth = 550
            Me.cmbPregunta6Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta6Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta6Materiales.FormattingEnabled = True
            Me.cmbPregunta6Materiales.Items.AddRange(New Object() {"( 0% ) - NO PROPORCIONA GARANTÍAS", "( 5% ) - PROPORCIONA GARANTÍAS"})
            Me.cmbPregunta6Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta6Materiales.Name = "cmbPregunta6Materiales"
            Me.cmbPregunta6Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta6Materiales.TabIndex = 2
            '
            'txtPregunta6Materiales
            '
            Me.txtPregunta6Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta6Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta6Materiales.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta6Materiales.Multiline = True
            Me.txtPregunta6Materiales.Name = "txtPregunta6Materiales"
            Me.txtPregunta6Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta6Materiales.TabIndex = 1
            Me.txtPregunta6Materiales.Text = "0"
            Me.txtPregunta6Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta6Materiales
            '
            Me.lblPregunta6Materiales.AutoSize = True
            Me.lblPregunta6Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta6Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta6Materiales.Name = "lblPregunta6Materiales"
            Me.lblPregunta6Materiales.Size = New System.Drawing.Size(347, 13)
            Me.lblPregunta6Materiales.TabIndex = 0
            Me.lblPregunta6Materiales.Text = "GARANTÍAS DE CALIDAD DEL PRODUCTO (Reposición, Reparación)"
            '
            'Panel18
            '
            Me.Panel18.BackColor = System.Drawing.Color.White
            Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel18.Controls.Add(Me.cmbPregunta5Materiales)
            Me.Panel18.Controls.Add(Me.txtPregunta5Materiales)
            Me.Panel18.Controls.Add(Me.lblPregunta5Materiales)
            Me.Panel18.Location = New System.Drawing.Point(0, 184)
            Me.Panel18.Name = "Panel18"
            Me.Panel18.Size = New System.Drawing.Size(617, 47)
            Me.Panel18.TabIndex = 34
            '
            'cmbPregunta5Materiales
            '
            Me.cmbPregunta5Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta5Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta5Materiales.DropDownWidth = 550
            Me.cmbPregunta5Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta5Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta5Materiales.FormattingEnabled = True
            Me.cmbPregunta5Materiales.Items.AddRange(New Object() {"( 2% ) - DE 15 a 30 DÍAS", "( 5% ) - DE 30 DÍAS EN ADELANTE"})
            Me.cmbPregunta5Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta5Materiales.Name = "cmbPregunta5Materiales"
            Me.cmbPregunta5Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta5Materiales.TabIndex = 2
            '
            'txtPregunta5Materiales
            '
            Me.txtPregunta5Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta5Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta5Materiales.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta5Materiales.Multiline = True
            Me.txtPregunta5Materiales.Name = "txtPregunta5Materiales"
            Me.txtPregunta5Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta5Materiales.TabIndex = 1
            Me.txtPregunta5Materiales.Text = "0"
            Me.txtPregunta5Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta5Materiales
            '
            Me.lblPregunta5Materiales.AutoSize = True
            Me.lblPregunta5Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta5Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta5Materiales.Name = "lblPregunta5Materiales"
            Me.lblPregunta5Materiales.Size = New System.Drawing.Size(132, 13)
            Me.lblPregunta5Materiales.TabIndex = 0
            Me.lblPregunta5Materiales.Text = "CONDICIONES DE PAGO"
            '
            'Panel19
            '
            Me.Panel19.BackColor = System.Drawing.Color.White
            Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel19.Controls.Add(Me.cmbPregunta4Materiales)
            Me.Panel19.Controls.Add(Me.txtPregunta4Materiales)
            Me.Panel19.Controls.Add(Me.lblPregunta4Materiales)
            Me.Panel19.Location = New System.Drawing.Point(0, 138)
            Me.Panel19.Name = "Panel19"
            Me.Panel19.Size = New System.Drawing.Size(617, 47)
            Me.Panel19.TabIndex = 33
            '
            'cmbPregunta4Materiales
            '
            Me.cmbPregunta4Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta4Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta4Materiales.DropDownWidth = 550
            Me.cmbPregunta4Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta4Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta4Materiales.FormattingEnabled = True
            Me.cmbPregunta4Materiales.Items.AddRange(New Object() {"(   2% ) - PRECIO SUPERIOR AL DEL MERCADO", "(   5% ) - PRECIO COMPETITIVO", "( 10% ) - PRECIO INFERIOR AL DEL MERCADO"})
            Me.cmbPregunta4Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta4Materiales.Name = "cmbPregunta4Materiales"
            Me.cmbPregunta4Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta4Materiales.TabIndex = 2
            '
            'txtPregunta4Materiales
            '
            Me.txtPregunta4Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta4Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta4Materiales.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta4Materiales.Multiline = True
            Me.txtPregunta4Materiales.Name = "txtPregunta4Materiales"
            Me.txtPregunta4Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta4Materiales.TabIndex = 1
            Me.txtPregunta4Materiales.Text = "0"
            Me.txtPregunta4Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta4Materiales
            '
            Me.lblPregunta4Materiales.AutoSize = True
            Me.lblPregunta4Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta4Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta4Materiales.Name = "lblPregunta4Materiales"
            Me.lblPregunta4Materiales.Size = New System.Drawing.Size(47, 13)
            Me.lblPregunta4Materiales.TabIndex = 0
            Me.lblPregunta4Materiales.Text = "PRECIO"
            '
            'Panel20
            '
            Me.Panel20.BackColor = System.Drawing.Color.White
            Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel20.Controls.Add(Me.cmbPregunta3Materiales)
            Me.Panel20.Controls.Add(Me.txtPregunta3Materiales)
            Me.Panel20.Controls.Add(Me.lblPregunta3Materiales)
            Me.Panel20.Location = New System.Drawing.Point(0, 92)
            Me.Panel20.Name = "Panel20"
            Me.Panel20.Size = New System.Drawing.Size(617, 47)
            Me.Panel20.TabIndex = 32
            '
            'cmbPregunta3Materiales
            '
            Me.cmbPregunta3Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta3Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta3Materiales.DropDownWidth = 550
            Me.cmbPregunta3Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta3Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta3Materiales.FormattingEnabled = True
            Me.cmbPregunta3Materiales.Items.AddRange(New Object() {"(   3% ) - PERMANENTES RETRASOS", "(   7% ) - PRESENTA RETRASOS ESPORÁDICOS", "( 10% ) - NUNCA PRESENTA RETRASOS CON LAS ENTREGAS"})
            Me.cmbPregunta3Materiales.Location = New System.Drawing.Point(16, 20)
            Me.cmbPregunta3Materiales.Name = "cmbPregunta3Materiales"
            Me.cmbPregunta3Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta3Materiales.TabIndex = 2
            '
            'txtPregunta3Materiales
            '
            Me.txtPregunta3Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta3Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta3Materiales.Location = New System.Drawing.Point(553, 3)
            Me.txtPregunta3Materiales.Multiline = True
            Me.txtPregunta3Materiales.Name = "txtPregunta3Materiales"
            Me.txtPregunta3Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta3Materiales.TabIndex = 1
            Me.txtPregunta3Materiales.Text = "0"
            Me.txtPregunta3Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta3Materiales
            '
            Me.lblPregunta3Materiales.AutoSize = True
            Me.lblPregunta3Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta3Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta3Materiales.Name = "lblPregunta3Materiales"
            Me.lblPregunta3Materiales.Size = New System.Drawing.Size(294, 13)
            Me.lblPregunta3Materiales.TabIndex = 0
            Me.lblPregunta3Materiales.Text = "CUMPLIMIENTO TIEMPOS DE ENTREGA DEL MATERIAL"
            '
            'Panel21
            '
            Me.Panel21.BackColor = System.Drawing.Color.White
            Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel21.Controls.Add(Me.cmbPregunta2Materiales)
            Me.Panel21.Controls.Add(Me.txtPregunta2Materiales)
            Me.Panel21.Controls.Add(Me.lblPregunta2Materiales)
            Me.Panel21.Location = New System.Drawing.Point(0, 46)
            Me.Panel21.Name = "Panel21"
            Me.Panel21.Size = New System.Drawing.Size(617, 47)
            Me.Panel21.TabIndex = 31
            '
            'cmbPregunta2Materiales
            '
            Me.cmbPregunta2Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta2Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta2Materiales.DropDownWidth = 550
            Me.cmbPregunta2Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta2Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta2Materiales.FormattingEnabled = True
            Me.cmbPregunta2Materiales.Items.AddRange(New Object() {"(   5% ) - RETIRO EN ALMACÉN", "( 15% ) - ENTREGA SÓLO EN OFICINA CENTRAL O CIUDAD"})
            Me.cmbPregunta2Materiales.Location = New System.Drawing.Point(16, 19)
            Me.cmbPregunta2Materiales.Name = "cmbPregunta2Materiales"
            Me.cmbPregunta2Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta2Materiales.TabIndex = 2
            '
            'txtPregunta2Materiales
            '
            Me.txtPregunta2Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta2Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta2Materiales.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta2Materiales.Multiline = True
            Me.txtPregunta2Materiales.Name = "txtPregunta2Materiales"
            Me.txtPregunta2Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta2Materiales.TabIndex = 1
            Me.txtPregunta2Materiales.Text = "0"
            Me.txtPregunta2Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta2Materiales
            '
            Me.lblPregunta2Materiales.AutoSize = True
            Me.lblPregunta2Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta2Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta2Materiales.Name = "lblPregunta2Materiales"
            Me.lblPregunta2Materiales.Size = New System.Drawing.Size(201, 13)
            Me.lblPregunta2Materiales.TabIndex = 0
            Me.lblPregunta2Materiales.Text = "PUNTOS DE ENTREGA (COBERTURA)"
            '
            'Panel22
            '
            Me.Panel22.BackColor = System.Drawing.Color.White
            Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel22.Controls.Add(Me.cmbPregunta1Materiales)
            Me.Panel22.Controls.Add(Me.txtPregunta1Materiales)
            Me.Panel22.Controls.Add(Me.lblPregunta1Materiales)
            Me.Panel22.Location = New System.Drawing.Point(0, 0)
            Me.Panel22.Name = "Panel22"
            Me.Panel22.Size = New System.Drawing.Size(617, 47)
            Me.Panel22.TabIndex = 30
            '
            'cmbPregunta1Materiales
            '
            Me.cmbPregunta1Materiales.BackColor = System.Drawing.Color.White
            Me.cmbPregunta1Materiales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPregunta1Materiales.DropDownWidth = 550
            Me.cmbPregunta1Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cmbPregunta1Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbPregunta1Materiales.FormattingEnabled = True
            Me.cmbPregunta1Materiales.Items.AddRange(New Object() {"(   5% ) - ENTREGA PARCIALM, HASTA EL 59% DEL PEDIDO", "( 10% ) - ENTREGA PARCIAL HASTA EL 70% DEL PEDIDO", "( 13% ) - ENTREGA EXACTA DEL PEDIDO", "( 15% ) - EXCEDE CAPACIDAD DE PROVISIÓN"})
            Me.cmbPregunta1Materiales.Location = New System.Drawing.Point(16, 19)
            Me.cmbPregunta1Materiales.Name = "cmbPregunta1Materiales"
            Me.cmbPregunta1Materiales.Size = New System.Drawing.Size(393, 23)
            Me.cmbPregunta1Materiales.TabIndex = 2
            '
            'txtPregunta1Materiales
            '
            Me.txtPregunta1Materiales.BackColor = System.Drawing.Color.White
            Me.txtPregunta1Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPregunta1Materiales.Location = New System.Drawing.Point(552, 3)
            Me.txtPregunta1Materiales.Multiline = True
            Me.txtPregunta1Materiales.Name = "txtPregunta1Materiales"
            Me.txtPregunta1Materiales.Size = New System.Drawing.Size(60, 39)
            Me.txtPregunta1Materiales.TabIndex = 1
            Me.txtPregunta1Materiales.Text = "0"
            Me.txtPregunta1Materiales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'lblPregunta1Materiales
            '
            Me.lblPregunta1Materiales.AutoSize = True
            Me.lblPregunta1Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPregunta1Materiales.Location = New System.Drawing.Point(3, 3)
            Me.lblPregunta1Materiales.Name = "lblPregunta1Materiales"
            Me.lblPregunta1Materiales.Size = New System.Drawing.Size(148, 13)
            Me.lblPregunta1Materiales.TabIndex = 0
            Me.lblPregunta1Materiales.Text = "CAPACIDAD DE PROVISIÓN"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoProveedorGeneral, Me.btnGuardarProveedorGeneral, Me.btnCancelarProveedorGeneral})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(619, 24)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoProveedorGeneral
            '
            Me.btnNuevoProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevoProveedorGeneral.Name = "btnNuevoProveedorGeneral"
            Me.btnNuevoProveedorGeneral.Size = New System.Drawing.Size(74, 20)
            Me.btnNuevoProveedorGeneral.Text = "NUEVO"
            '
            'btnGuardarProveedorGeneral
            '
            Me.btnGuardarProveedorGeneral.Enabled = False
            Me.btnGuardarProveedorGeneral.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardarProveedorGeneral.Name = "btnGuardarProveedorGeneral"
            Me.btnGuardarProveedorGeneral.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardarProveedorGeneral.Text = "GUARDAR"
            '
            'btnCancelarProveedorGeneral
            '
            Me.btnCancelarProveedorGeneral.Enabled = False
            Me.btnCancelarProveedorGeneral.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelarProveedorGeneral.Name = "btnCancelarProveedorGeneral"
            Me.btnCancelarProveedorGeneral.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelarProveedorGeneral.Text = "CANCELAR"
            '
            'FormEvaluacionProveedores
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(619, 667)
            Me.Controls.Add(Me.lblTipoProveedor)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.cmbTipoProveedor)
            Me.Controls.Add(Me.tcEvaluacionesProveedores)
            Me.Controls.Add(Me.gbFechaEvaluacionProveedores)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormEvaluacionProveedores"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "EVALUACIÓN PROVEEDORES"
            Me.gbFechaEvaluacionProveedores.ResumeLayout(False)
            Me.gbFechaEvaluacionProveedores.PerformLayout()
            Me.tcEvaluacionesProveedores.ResumeLayout(False)
            Me.tpEvaluacionProveedorServicios.ResumeLayout(False)
            Me.Panel11.ResumeLayout(False)
            Me.Panel11.PerformLayout()
            Me.Panel10.ResumeLayout(False)
            Me.Panel10.PerformLayout()
            Me.Panel9.ResumeLayout(False)
            Me.Panel9.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.Panel8.PerformLayout()
            Me.Panel7.ResumeLayout(False)
            Me.Panel7.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.tpEvaluacionProveedorMateriales.ResumeLayout(False)
            Me.Panel12.ResumeLayout(False)
            Me.Panel12.PerformLayout()
            Me.Panel14.ResumeLayout(False)
            Me.Panel14.PerformLayout()
            Me.Panel15.ResumeLayout(False)
            Me.Panel15.PerformLayout()
            Me.Panel16.ResumeLayout(False)
            Me.Panel16.PerformLayout()
            Me.Panel17.ResumeLayout(False)
            Me.Panel17.PerformLayout()
            Me.Panel18.ResumeLayout(False)
            Me.Panel18.PerformLayout()
            Me.Panel19.ResumeLayout(False)
            Me.Panel19.PerformLayout()
            Me.Panel20.ResumeLayout(False)
            Me.Panel20.PerformLayout()
            Me.Panel21.ResumeLayout(False)
            Me.Panel21.PerformLayout()
            Me.Panel22.ResumeLayout(False)
            Me.Panel22.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblProveedorEvaluado As System.Windows.Forms.Label
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtNombrePersonal As System.Windows.Forms.TextBox
        Friend WithEvents lblResponsableEvaluacion As System.Windows.Forms.Label
        Friend WithEvents lblIdPersonal As System.Windows.Forms.Label
        Friend WithEvents lblEtiquetaFechaEvluacioProveedorServicios As System.Windows.Forms.Label
        Friend WithEvents gbFechaEvaluacionProveedores As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdEvlauacion As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblFechaEvaluacionProveedor As System.Windows.Forms.Label
        Friend WithEvents tcEvaluacionesProveedores As System.Windows.Forms.TabControl
        Friend WithEvents tpEvaluacionProveedorServicios As System.Windows.Forms.TabPage
        Friend WithEvents Panel11 As System.Windows.Forms.Panel
        Friend WithEvents lblClalificacionEvaluacionServicios As System.Windows.Forms.Label
        Friend WithEvents lblLetreroClasificacion As System.Windows.Forms.Label
        Friend WithEvents txtTotalEvaluacionServicios As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Panel10 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta10Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta10Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta10Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta9Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta9Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta9Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta8Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta8Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta8Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta7Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta7Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta7Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta6Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta6Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta6Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta5Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta5Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta5Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta4Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta4Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta4Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta3Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta3Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta3Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta2Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta2Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta2Servicios As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta1Servicios As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta1Servicios As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta1Servicios As System.Windows.Forms.Label
        Friend WithEvents tpEvaluacionProveedorMateriales As System.Windows.Forms.TabPage
        Friend WithEvents Panel12 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTotalEvaluacionMateriales As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Panel14 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta9Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta9Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta9Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel15 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta8Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta8Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta8Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel16 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta7Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta7Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta7Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel17 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta6Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta6Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta6Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel18 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta5Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta5Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta5Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel19 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta4Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta4Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta4Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel20 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta3Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta3Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta3Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel21 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta2Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta2Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta2Materiales As System.Windows.Forms.Label
        Friend WithEvents Panel22 As System.Windows.Forms.Panel
        Friend WithEvents cmbPregunta1Materiales As System.Windows.Forms.ComboBox
        Friend WithEvents txtPregunta1Materiales As System.Windows.Forms.TextBox
        Friend WithEvents lblPregunta1Materiales As System.Windows.Forms.Label
        Friend WithEvents lblTipoProveedor As System.Windows.Forms.Label
        Friend WithEvents cmbTipoProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents lblCalificacionEvaluacionMateriales As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEvaluacion As System.Windows.Forms.DateTimePicker
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace