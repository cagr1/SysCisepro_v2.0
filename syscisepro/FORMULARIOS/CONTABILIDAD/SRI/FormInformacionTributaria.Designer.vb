Namespace FORMULARIOS.CONTABILIDAD.SRI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormInformacionTributaria
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInformacionTributaria))
            Me.gbEmpresa = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.chkEmpresa = New System.Windows.Forms.CheckBox()
            Me.lblIdEmpresa = New System.Windows.Forms.Label()
            Me.txtLlevaContabilidadEmpresa = New System.Windows.Forms.TextBox()
            Me.txtContribuyenteEspecialEmpresa = New System.Windows.Forms.TextBox()
            Me.txtDireccionMatrizEmpresa = New System.Windows.Forms.TextBox()
            Me.txtRucEmpresa = New System.Windows.Forms.TextBox()
            Me.txtRazonSocialEmpresa = New System.Windows.Forms.TextBox()
            Me.txtNombreComercialEmpresa = New System.Windows.Forms.TextBox()
            Me.gbSecuenciaComprobantes = New System.Windows.Forms.GroupBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblIdInformacionTributaria = New System.Windows.Forms.Label()
            Me.chkSecuenciales = New System.Windows.Forms.CheckBox()
            Me.txtSecuencialComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtSecuencialNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtSecuencialFactura = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.chkImpuestos = New System.Windows.Forms.CheckBox()
            Me.txtPorcentajeICE = New System.Windows.Forms.TextBox()
            Me.txtPorcentajeIVA = New System.Windows.Forms.TextBox()
            Me.gbNumeroAutorizaciones = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.chkNroAutorizaciones = New System.Windows.Forms.CheckBox()
            Me.txtNroAutorizacionComprobanteRetencion = New System.Windows.Forms.TextBox()
            Me.txtNroAutorizaciónNotaCredito = New System.Windows.Forms.TextBox()
            Me.txtNroAutorizacionFactura = New System.Windows.Forms.TextBox()
            Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbEmpresa.SuspendLayout()
            Me.gbSecuenciaComprobantes.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbNumeroAutorizaciones.SuspendLayout()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbEmpresa
            '
            Me.gbEmpresa.BackColor = System.Drawing.Color.White
            Me.gbEmpresa.Controls.Add(Me.Label6)
            Me.gbEmpresa.Controls.Add(Me.Label5)
            Me.gbEmpresa.Controls.Add(Me.Label4)
            Me.gbEmpresa.Controls.Add(Me.Label3)
            Me.gbEmpresa.Controls.Add(Me.Label2)
            Me.gbEmpresa.Controls.Add(Me.Label1)
            Me.gbEmpresa.Controls.Add(Me.chkEmpresa)
            Me.gbEmpresa.Controls.Add(Me.lblIdEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtLlevaContabilidadEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtContribuyenteEspecialEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtDireccionMatrizEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtRucEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtRazonSocialEmpresa)
            Me.gbEmpresa.Controls.Add(Me.txtNombreComercialEmpresa)
            Me.gbEmpresa.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbEmpresa.Location = New System.Drawing.Point(2, 24)
            Me.gbEmpresa.Name = "gbEmpresa"
            Me.gbEmpresa.Size = New System.Drawing.Size(626, 173)
            Me.gbEmpresa.TabIndex = 0
            Me.gbEmpresa.TabStop = False
            Me.gbEmpresa.Text = "EMPRESA"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(327, 143)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(186, 13)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "OBLIGADO LLEVAR CONTABILIDAD:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(7, 143)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(190, 13)
            Me.Label5.TabIndex = 12
            Me.Label5.Text = "NRO RESOLUCIÓN CONT. ESPECIAL:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 112)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 13)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "DIRECCIÓN MATRIZ:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 81)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(120, 13)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "NOMBRE COMERCIAL:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(7, 50)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 13)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "RAZÓN SOCIAL:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "R.U.C.:"
            '
            'chkEmpresa
            '
            Me.chkEmpresa.AutoSize = True
            Me.chkEmpresa.Location = New System.Drawing.Point(550, -1)
            Me.chkEmpresa.Name = "chkEmpresa"
            Me.chkEmpresa.Size = New System.Drawing.Size(71, 17)
            Me.chkEmpresa.TabIndex = 7
            Me.chkEmpresa.Text = "ACTIVAR"
            Me.chkEmpresa.UseVisualStyleBackColor = True
            '
            'lblIdEmpresa
            '
            Me.lblIdEmpresa.AutoSize = True
            Me.lblIdEmpresa.Location = New System.Drawing.Point(61, 0)
            Me.lblIdEmpresa.Name = "lblIdEmpresa"
            Me.lblIdEmpresa.Size = New System.Drawing.Size(10, 13)
            Me.lblIdEmpresa.TabIndex = 6
            Me.lblIdEmpresa.Text = "."
            '
            'txtLlevaContabilidadEmpresa
            '
            Me.txtLlevaContabilidadEmpresa.BackColor = System.Drawing.Color.White
            Me.txtLlevaContabilidadEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtLlevaContabilidadEmpresa.Location = New System.Drawing.Point(520, 140)
            Me.txtLlevaContabilidadEmpresa.Name = "txtLlevaContabilidadEmpresa"
            Me.txtLlevaContabilidadEmpresa.Size = New System.Drawing.Size(98, 21)
            Me.txtLlevaContabilidadEmpresa.TabIndex = 5
            '
            'txtContribuyenteEspecialEmpresa
            '
            Me.txtContribuyenteEspecialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtContribuyenteEspecialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtContribuyenteEspecialEmpresa.Location = New System.Drawing.Point(200, 140)
            Me.txtContribuyenteEspecialEmpresa.Name = "txtContribuyenteEspecialEmpresa"
            Me.txtContribuyenteEspecialEmpresa.Size = New System.Drawing.Size(115, 21)
            Me.txtContribuyenteEspecialEmpresa.TabIndex = 4
            Me.txtContribuyenteEspecialEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDireccionMatrizEmpresa
            '
            Me.txtDireccionMatrizEmpresa.BackColor = System.Drawing.Color.White
            Me.txtDireccionMatrizEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDireccionMatrizEmpresa.Location = New System.Drawing.Point(116, 109)
            Me.txtDireccionMatrizEmpresa.Name = "txtDireccionMatrizEmpresa"
            Me.txtDireccionMatrizEmpresa.Size = New System.Drawing.Size(502, 21)
            Me.txtDireccionMatrizEmpresa.TabIndex = 3
            '
            'txtRucEmpresa
            '
            Me.txtRucEmpresa.BackColor = System.Drawing.Color.White
            Me.txtRucEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRucEmpresa.Location = New System.Drawing.Point(116, 16)
            Me.txtRucEmpresa.Name = "txtRucEmpresa"
            Me.txtRucEmpresa.Size = New System.Drawing.Size(100, 21)
            Me.txtRucEmpresa.TabIndex = 2
            '
            'txtRazonSocialEmpresa
            '
            Me.txtRazonSocialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtRazonSocialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRazonSocialEmpresa.Location = New System.Drawing.Point(116, 47)
            Me.txtRazonSocialEmpresa.Name = "txtRazonSocialEmpresa"
            Me.txtRazonSocialEmpresa.Size = New System.Drawing.Size(502, 21)
            Me.txtRazonSocialEmpresa.TabIndex = 1
            '
            'txtNombreComercialEmpresa
            '
            Me.txtNombreComercialEmpresa.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialEmpresa.Location = New System.Drawing.Point(116, 78)
            Me.txtNombreComercialEmpresa.Name = "txtNombreComercialEmpresa"
            Me.txtNombreComercialEmpresa.Size = New System.Drawing.Size(502, 21)
            Me.txtNombreComercialEmpresa.TabIndex = 0
            '
            'gbSecuenciaComprobantes
            '
            Me.gbSecuenciaComprobantes.BackColor = System.Drawing.Color.White
            Me.gbSecuenciaComprobantes.Controls.Add(Me.Label9)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.Label8)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.Label7)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.lblIdInformacionTributaria)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.chkSecuenciales)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.txtSecuencialComprobanteRetencion)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.txtSecuencialNotaCredito)
            Me.gbSecuenciaComprobantes.Controls.Add(Me.txtSecuencialFactura)
            Me.gbSecuenciaComprobantes.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbSecuenciaComprobantes.Location = New System.Drawing.Point(2, 197)
            Me.gbSecuenciaComprobantes.Name = "gbSecuenciaComprobantes"
            Me.gbSecuenciaComprobantes.Size = New System.Drawing.Size(321, 97)
            Me.gbSecuenciaComprobantes.TabIndex = 1
            Me.gbSecuenciaComprobantes.TabStop = False
            Me.gbSecuenciaComprobantes.Text = "SECUENCIA COMPROBANTES"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(7, 73)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(173, 13)
            Me.Label9.TabIndex = 16
            Me.Label9.Text = "SECUENCIAL COMP. RETENCIÓN:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(7, 47)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(155, 13)
            Me.Label8.TabIndex = 15
            Me.Label8.Text = "SECUENCIAL NOTA CRÉDITO:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(7, 21)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(124, 13)
            Me.Label7.TabIndex = 14
            Me.Label7.Text = "SECUENCIAL FACTURA:"
            '
            'lblIdInformacionTributaria
            '
            Me.lblIdInformacionTributaria.AutoSize = True
            Me.lblIdInformacionTributaria.Location = New System.Drawing.Point(146, 0)
            Me.lblIdInformacionTributaria.Name = "lblIdInformacionTributaria"
            Me.lblIdInformacionTributaria.Size = New System.Drawing.Size(10, 13)
            Me.lblIdInformacionTributaria.TabIndex = 7
            Me.lblIdInformacionTributaria.Text = "."
            '
            'chkSecuenciales
            '
            Me.chkSecuenciales.AutoSize = True
            Me.chkSecuenciales.Location = New System.Drawing.Point(244, -1)
            Me.chkSecuenciales.Name = "chkSecuenciales"
            Me.chkSecuenciales.Size = New System.Drawing.Size(71, 17)
            Me.chkSecuenciales.TabIndex = 8
            Me.chkSecuenciales.Text = "ACTIVAR"
            Me.chkSecuenciales.UseVisualStyleBackColor = True
            '
            'txtSecuencialComprobanteRetencion
            '
            Me.txtSecuencialComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtSecuencialComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialComprobanteRetencion.Location = New System.Drawing.Point(182, 70)
            Me.txtSecuencialComprobanteRetencion.Name = "txtSecuencialComprobanteRetencion"
            Me.txtSecuencialComprobanteRetencion.Size = New System.Drawing.Size(133, 21)
            Me.txtSecuencialComprobanteRetencion.TabIndex = 2
            Me.txtSecuencialComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSecuencialNotaCredito
            '
            Me.txtSecuencialNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtSecuencialNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialNotaCredito.Location = New System.Drawing.Point(182, 44)
            Me.txtSecuencialNotaCredito.Name = "txtSecuencialNotaCredito"
            Me.txtSecuencialNotaCredito.Size = New System.Drawing.Size(133, 21)
            Me.txtSecuencialNotaCredito.TabIndex = 1
            Me.txtSecuencialNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtSecuencialFactura
            '
            Me.txtSecuencialFactura.BackColor = System.Drawing.Color.White
            Me.txtSecuencialFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSecuencialFactura.Location = New System.Drawing.Point(182, 18)
            Me.txtSecuencialFactura.Name = "txtSecuencialFactura"
            Me.txtSecuencialFactura.Size = New System.Drawing.Size(133, 21)
            Me.txtSecuencialFactura.TabIndex = 0
            Me.txtSecuencialFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.White
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.chkImpuestos)
            Me.GroupBox1.Controls.Add(Me.txtPorcentajeICE)
            Me.GroupBox1.Controls.Add(Me.txtPorcentajeIVA)
            Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(2, 294)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(626, 46)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "IMPUESTOS"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(327, 19)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(97, 13)
            Me.Label14.TabIndex = 11
            Me.Label14.Text = "PORCENTAJE ICE:"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(7, 19)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(97, 13)
            Me.Label13.TabIndex = 10
            Me.Label13.Text = "PORCENTAJE IVA:"
            '
            'chkImpuestos
            '
            Me.chkImpuestos.AutoSize = True
            Me.chkImpuestos.Location = New System.Drawing.Point(550, -1)
            Me.chkImpuestos.Name = "chkImpuestos"
            Me.chkImpuestos.Size = New System.Drawing.Size(68, 17)
            Me.chkImpuestos.TabIndex = 8
            Me.chkImpuestos.Text = "ACTIVAR"
            Me.chkImpuestos.UseVisualStyleBackColor = True
            '
            'txtPorcentajeICE
            '
            Me.txtPorcentajeICE.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeICE.Location = New System.Drawing.Point(460, 16)
            Me.txtPorcentajeICE.Name = "txtPorcentajeICE"
            Me.txtPorcentajeICE.Size = New System.Drawing.Size(78, 20)
            Me.txtPorcentajeICE.TabIndex = 1
            Me.txtPorcentajeICE.Text = "% ICE"
            Me.txtPorcentajeICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtPorcentajeIVA
            '
            Me.txtPorcentajeIVA.BackColor = System.Drawing.Color.White
            Me.txtPorcentajeIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPorcentajeIVA.Location = New System.Drawing.Point(116, 16)
            Me.txtPorcentajeIVA.Name = "txtPorcentajeIVA"
            Me.txtPorcentajeIVA.Size = New System.Drawing.Size(78, 20)
            Me.txtPorcentajeIVA.TabIndex = 0
            Me.txtPorcentajeIVA.Text = "% IVA"
            Me.txtPorcentajeIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'gbNumeroAutorizaciones
            '
            Me.gbNumeroAutorizaciones.BackColor = System.Drawing.Color.White
            Me.gbNumeroAutorizaciones.Controls.Add(Me.Label12)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.Label11)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.Label10)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.chkNroAutorizaciones)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.txtNroAutorizacionComprobanteRetencion)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.txtNroAutorizaciónNotaCredito)
            Me.gbNumeroAutorizaciones.Controls.Add(Me.txtNroAutorizacionFactura)
            Me.gbNumeroAutorizaciones.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNumeroAutorizaciones.Location = New System.Drawing.Point(323, 197)
            Me.gbNumeroAutorizaciones.Name = "gbNumeroAutorizaciones"
            Me.gbNumeroAutorizaciones.Size = New System.Drawing.Size(305, 97)
            Me.gbNumeroAutorizaciones.TabIndex = 3
            Me.gbNumeroAutorizaciones.TabStop = False
            Me.gbNumeroAutorizaciones.Text = "NRO AUTORIZACIÓN DE COMPROBANTES"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(6, 73)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(125, 13)
            Me.Label12.TabIndex = 19
            Me.Label12.Text = "AUTORIZACIÓN SRI Nº:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(6, 47)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(125, 13)
            Me.Label11.TabIndex = 18
            Me.Label11.Text = "AUTORIZACIÓN SRI Nº:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 21)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(125, 13)
            Me.Label10.TabIndex = 17
            Me.Label10.Text = "AUTORIZACIÓN SRI Nº:"
            '
            'chkNroAutorizaciones
            '
            Me.chkNroAutorizaciones.AutoSize = True
            Me.chkNroAutorizaciones.Location = New System.Drawing.Point(225, -1)
            Me.chkNroAutorizaciones.Name = "chkNroAutorizaciones"
            Me.chkNroAutorizaciones.Size = New System.Drawing.Size(71, 17)
            Me.chkNroAutorizaciones.TabIndex = 8
            Me.chkNroAutorizaciones.Text = "ACTIVAR"
            Me.chkNroAutorizaciones.UseVisualStyleBackColor = True
            '
            'txtNroAutorizacionComprobanteRetencion
            '
            Me.txtNroAutorizacionComprobanteRetencion.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizacionComprobanteRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizacionComprobanteRetencion.Location = New System.Drawing.Point(139, 70)
            Me.txtNroAutorizacionComprobanteRetencion.Name = "txtNroAutorizacionComprobanteRetencion"
            Me.txtNroAutorizacionComprobanteRetencion.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizacionComprobanteRetencion.TabIndex = 2
            Me.txtNroAutorizacionComprobanteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroAutorizaciónNotaCredito
            '
            Me.txtNroAutorizaciónNotaCredito.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizaciónNotaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizaciónNotaCredito.Location = New System.Drawing.Point(139, 44)
            Me.txtNroAutorizaciónNotaCredito.Name = "txtNroAutorizaciónNotaCredito"
            Me.txtNroAutorizaciónNotaCredito.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizaciónNotaCredito.TabIndex = 1
            Me.txtNroAutorizaciónNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtNroAutorizacionFactura
            '
            Me.txtNroAutorizacionFactura.BackColor = System.Drawing.Color.White
            Me.txtNroAutorizacionFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNroAutorizacionFactura.Location = New System.Drawing.Point(139, 18)
            Me.txtNroAutorizacionFactura.Name = "txtNroAutorizacionFactura"
            Me.txtNroAutorizacionFactura.Size = New System.Drawing.Size(158, 21)
            Me.txtNroAutorizacionFactura.TabIndex = 0
            Me.txtNroAutorizacionFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'dgvEmpresa
            '
            Me.dgvEmpresa.AllowUserToAddRows = False
            Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEmpresa.Location = New System.Drawing.Point(2, 2)
            Me.dgvEmpresa.Name = "dgvEmpresa"
            Me.dgvEmpresa.Size = New System.Drawing.Size(321, 59)
            Me.dgvEmpresa.TabIndex = 46
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnModificar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
            Me.MenuStrip1.TabIndex = 188
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.NuevoRegistro
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(74, 20)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.GuardarRegistro
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(95, 20)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormInformacionTributaria
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(629, 342)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.gbNumeroAutorizaciones)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gbSecuenciaComprobantes)
            Me.Controls.Add(Me.gbEmpresa)
            Me.Controls.Add(Me.dgvEmpresa)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormInformacionTributaria"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "INFORMACIÓN TRIBUTARIA"
            Me.gbEmpresa.ResumeLayout(False)
            Me.gbEmpresa.PerformLayout()
            Me.gbSecuenciaComprobantes.ResumeLayout(False)
            Me.gbSecuenciaComprobantes.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbNumeroAutorizaciones.ResumeLayout(False)
            Me.gbNumeroAutorizaciones.PerformLayout()
            CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
        Friend WithEvents txtLlevaContabilidadEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtContribuyenteEspecialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccionMatrizEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtRucEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtRazonSocialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreComercialEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents gbSecuenciaComprobantes As System.Windows.Forms.GroupBox
        Friend WithEvents txtSecuencialComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtSecuencialNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtSecuencialFactura As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtPorcentajeIVA As System.Windows.Forms.TextBox
        Friend WithEvents txtPorcentajeICE As System.Windows.Forms.TextBox
        Friend WithEvents gbNumeroAutorizaciones As System.Windows.Forms.GroupBox
        Friend WithEvents txtNroAutorizacionComprobanteRetencion As System.Windows.Forms.TextBox
        Friend WithEvents txtNroAutorizaciónNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtNroAutorizacionFactura As System.Windows.Forms.TextBox
        Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
        Friend WithEvents lblIdEmpresa As System.Windows.Forms.Label
        Friend WithEvents lblIdInformacionTributaria As System.Windows.Forms.Label
        Friend WithEvents chkEmpresa As System.Windows.Forms.CheckBox
        Friend WithEvents chkSecuenciales As System.Windows.Forms.CheckBox
        Friend WithEvents chkImpuestos As System.Windows.Forms.CheckBox
        Friend WithEvents chkNroAutorizaciones As System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace