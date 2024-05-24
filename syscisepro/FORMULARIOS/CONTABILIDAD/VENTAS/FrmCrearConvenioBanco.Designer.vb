Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmCrearConvenioBanco
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearConvenioBanco))
            Me.txtValor = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtCedRucTitular = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cbxTipoDoc = New System.Windows.Forms.ComboBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtTitular = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.cbxBanco = New System.Windows.Forms.ComboBox()
            Me.txtNumCtaTarj = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtValor
            '
            Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValor.Location = New System.Drawing.Point(369, 72)
            Me.txtValor.Name = "txtValor"
            Me.txtValor.Size = New System.Drawing.Size(82, 20)
            Me.txtValor.TabIndex = 7
            Me.txtValor.Text = "0"
            Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(294, 75)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(43, 13)
            Me.Label20.TabIndex = 85
            Me.Label20.Text = "VALOR:"
            '
            'txtCedRucTitular
            '
            Me.txtCedRucTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCedRucTitular.Location = New System.Drawing.Point(369, 22)
            Me.txtCedRucTitular.Name = "txtCedRucTitular"
            Me.txtCedRucTitular.Size = New System.Drawing.Size(98, 20)
            Me.txtCedRucTitular.TabIndex = 4
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(292, 25)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(61, 13)
            Me.Label19.TabIndex = 83
            Me.Label19.Text = "CI / RUC:"
            '
            'cbxTipoDoc
            '
            Me.cbxTipoDoc.BackColor = System.Drawing.Color.White
            Me.cbxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbxTipoDoc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipoDoc.ForeColor = System.Drawing.Color.Black
            Me.cbxTipoDoc.FormattingEnabled = True
            Me.cbxTipoDoc.Items.AddRange(New Object() {"C CÉDULA", "R RUC", "P PASAPORTE", "X NINGUNO"})
            Me.cbxTipoDoc.Location = New System.Drawing.Point(68, 71)
            Me.cbxTipoDoc.Name = "cbxTipoDoc"
            Me.cbxTipoDoc.Size = New System.Drawing.Size(194, 21)
            Me.cbxTipoDoc.TabIndex = 3
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(11, 75)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(61, 13)
            Me.Label18.TabIndex = 81
            Me.Label18.Text = "TIPO DOC:"
            '
            'txtTitular
            '
            Me.txtTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTitular.Location = New System.Drawing.Point(369, 47)
            Me.txtTitular.Name = "txtTitular"
            Me.txtTitular.Size = New System.Drawing.Size(305, 20)
            Me.txtTitular.TabIndex = 6
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(292, 50)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(79, 13)
            Me.Label17.TabIndex = 79
            Me.Label17.Text = "TITULAR CTA:"
            '
            'cbxBanco
            '
            Me.cbxBanco.BackColor = System.Drawing.Color.White
            Me.cbxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbxBanco.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxBanco.ForeColor = System.Drawing.Color.Black
            Me.cbxBanco.FormattingEnabled = True
            Me.cbxBanco.Items.AddRange(New Object() {"002 BANECUADOR", "003 T/C MASTER PACIFICARD", "004 T/C AMERICAN EXPRESS BCO GUAYAQUIL", "005 T/C VISA - Guayaquil", "006 T/C DINERS CLUB", "007 T/C VISA - PICHINCHA", "008 T/C MASTER-Pichincha", "009 T/C VISA - BOLIVARIANO", "010 BANCO PICHINCHA", "012 T/C VISA CORPORATIVA-BANCO BOLIVARIA", "013 T/C MASTER-Produbanco", "014 T/C VISA - Machala", "015 T/C VISA COMERCIAL DE MANABI", "016 T/C VISA - Banco Internacional", "017 BANCO DE GUAYAQUIL", "018 T/C VISA - Austro", "021 T/C MASTER-Austro", "022 T/C VISA - Amazonas", "024 BANCO CITYBANK", "025 BANCO DE MACHALA", "027 T/C MASTER-Mut. Pichincha", "029 BANCO LOJA", "030 BANCO DEL PACIFICO", "031 BANCO DELBANK", "032 BANCO INTERNACIONAL", "033 COOP. JUV. ECUA PROGRESISTA LTDA.", "034 BANCO AMAZONAS", "035 BANCO DEL AUSTRO", "036 BANCO DE LA PRODUCCION", "037 BANCO BOLIVARIANO", "038 T/C Master-BANCO Internacional", "039 BANCO COMERCIAL DE MANABI", "041 T/C UniBanco CuotaFacil", "042 BANCO GENERAL RUMINAHUI", "043 BANCO DEL LITORAL", "044 CORFINSA S.A.", "045 BANCO SUDAMERICANO", "046 COOP.AHO.CREDITO ALIANZA DEL VALLE LTDA", "047 COOP.CONST.COMERCIO Y PRODUCCION LTDA", "048 FINANCIERA FINANCOOPERATIVA", "050 BANCO COFIEC", "051 BANCO CENTRO MUNDO", "053 PACIFICO BANANEROS", "059 BANCO SOLIDARIO", "060 BANCO ECUATORIANO DE LA VIVIENDA", "061 MUTUALISTA PICHINCHA", "062 MUTUALISTA BENALCAZAR", "063 FINANCIERA DINERS CLUB ECUADOR", "064 COOP. PREVISIION AHORRO Y DESARROLLO", "065 COOP.AHO.CREDITO ANDALUCIA", "066 COOP.AHO.CREDITO DE LA PEQUENA EMP. PASTAZA", "067 COOP.AHO.CREDITO PROGRESO", "068 COOP.AHO.CREDITO 29 DE OCTUBRE", "069 COOP.AHO.CREDITO COTOCALLAO", "071 COOP.AHO.CREDITO DESARROLLO PUEBLOS", "072 COOP.AHO.CREDITO 23 DE JULIO", "073 COOP.AHO.CREDITO NACIONAL", "074 COOP.AHO.CREDITO UNIDAD FAMILIAR", "075 COOP.AHO.CREDITO LA DOLOROSA LTDA", "076 MASTER DEL ECUADOR", "077 MUTUALISTA AZUAY", "078 COOP.AHO.CREDITO OSCUS", "079 MUTUALISTA AMBATO", "080 COOP.AHO.CREDITO EL SAGRARIO", "081 COOP.AHO.CREDITO SAN FRANCISCO", "082 COOP.AHO.CREDITO GUARANDA LTDA", "083 MUTUALISTA IMBABURA", "084 COOP.AHO.CREDITO ATUNTAQUI LTDA", "085 CAPECO LTDA", "086 COOP.AHO.CREDITO COMERCIO PORTOVIEJO", "087 COOP.AHO.CREDITO RIOBAMBA", "088 COOP.AHO.CREDITO PABLO M. VEGA", "089 COOP.AHO.CREDITO TULCAN", "090 MASTER PRIMA BANCO GUAYAQUIL", "091 COOP.AHO.CREDITO SANTA ROSA", "092 MASTERCARD BANCO BOLIVARIANO", "094 COOP.AHO.CREDITO JARDIN AZUAYO", "095 BANCO PROCREDIT", "096 COOP.AHO.CREDITO ONCE DE JUNIO", "097 CACPE BIBLIAN LTDA", "099 BCE-DINERO ELECTRONICO", "111 COOP. DE AHORRO Y CREDITO LA BENEFICA LTDA", "115 COOPERATIVA DE AHORRO Y CRÉDITO 14 DE MAYO", "116 COOPERATIVA DE AHORRO Y CRÉDITO BANCO CENTRAL DEL ECUADOR", "117 COOP. DE A. Y C. LUCHA CAMPESINA LTDA.", "296 COOP DE AHORRO Y CREDITIO DAQUILEMA", "982 COOP AHO Y CREDITO CACPECO LTDA", "01A BANCO CAPITAL", "01B COOP.AHO.CREDITO CHONE", "01C COOP.AHO.CREDITO SAN PEDRO DE TABOADA", "01D COOP.AHO.CREDITO SANTA ANA", "01E COOP.AHO.CREDITO 15 DE ABRIL", "01G COOP.AHO.CREDITO CAMARA COMERCIO DE AMBATO", "01H COOP.AHO.CREDITO CACPE DE LA PEQUENA LOJA", "01I COOP.AHO.CREDITO SAN JUAN DE SALINAS LTDA", "01J COOP.AHO.CREDITO PUELLARO LTDA.", "01K COOP.AHO.CREDITO NUEVA JERUSALEN", "01L COOP.AHO.CREDITO MALCHINGUI LTDA.", "01M COOP.AHO.CREDITO AMAZONAS LTDA.", "01N COOP.AHO.CREDITO AGRARIA MUSHUK KAWSAY LTDA", "01O COOP.AHO.CREDITO DE LA PEQUEÑA EMPRESA GUALAQUIZA", "01P COOP.AHO.CREDITO MI TIERRA", "01Q COOP.AHO.CREDITO MI TIERRA", "01R COOP.AHO.CREDITO PEDRO MONCAYO LTDA.", "01T COOP.AHO.CREDITO POLICIA NACIONAL LTDA.", "01U COOP.AHO.CREDITO NUEVA HUANCAVILCA LTDA.", "01V COOP.AHO.CREDITO ALFONSO JARAMILLO C.C.C", "01W COOP.AHO.CREDITO LA MERCED LTDA.", "01X COOP.AHO.CREDITO PROVIDA", "01Z COOP.AHO.CREDITO DE AHORRO Y CRÉDITO SAN JOSE S.J.", "02A COOP.AHO.CREDITO COOPERATIVA AC AUSTRO LTDA", "02B COOP.AHO.CREDITO SEÑOR DE GIRON", "02C COOP.AHO.CREDITO FAMILIA AUSTRAL", "02D COOP.AHO.CREDITO ERCO LTDA.", "02E COOP.AHO.CREDITO MUSHUC RUNA LTDA.", "02F COOP.AHO.CREDITO EDUC. DEL TUNGURAHUA LTDA.", "02G COOP.AHO.CREDITO AMBATO LTDA.", "02H COOP.AHO.CREDITO TUNGURAHUA LTDA.", "02I COOP.AHO.CREDITO LLANGANATES", "02J COOP.AHO.CREDITO ARTESANOS LTDA.", "02K COOP.AHO.CREDITO SANTA ANITA LTDA.", "02L COOP.AHO.CREDITO MUJERES UNIDAS TANTANAKUSHKA WARMIKUNAPAK CACMU LTDA.", "02M COOP.AHO.CREDITO SAN ANTONIO LTDA.", "02N COOP.AHO.CREDITO HUAYCO PUNGO LTDA.", "02O COOP.AHO.CREDITO ANDINA LTDA.", "02P COOP.AHO.CREDITO 15 DE AGOSTO PILACOTO", "02Q COOP.AHO.CREDITO CRISTO REY", "02R COOP.AHO.CREDITO SEMILLA DEL PROGRESO LTDA.", "02S COOP.AHO.CREDITO ACCIÓN RURAL", "02T COOP.AHO.CREDITO ACCION Y DESARROLLO LTDA", "02U COOP.AHO.CREDITO EDUCADORES DE CHIMBORAZO", "02V COOP.AHO.CREDITO MINGA LTDA.", "02W COOP.AHO.CREDITO 4 DE OCTUBRE LTDA.", "02X COOP.AHO.CREDITO CAMARA COMERCIO INDIGENA DE GUAMOTE LTDA", "02Y COOP.AHO.CREDITO SAN GABRIEL LTDA.", "02Z COOP. MEGO", "03A COOP. PADRE JULIAN LORENTE LTDA.", "03B COOP.AHO.CREDITO SAN JOSE S.J.", "03C COOP.AHO.CREDITO BAÑOS LTDA.", "03D COOP.AHO.CREDITO JUAN PIO DE MORA LTDA.", "03E COOP.AHO.CREDITO CREDIAMIGO LTDA. LOJA", "03F COOP.AHO.CREDITO 11 DE JUNIO", "03G COOP.AHO.CREDITO FUTURO Y PROGRESO DE GALAPAGOS LTDA.", "03H COOP.AHO.CREDITO CREA LTDA", "03I COOP.AHO.CREDITO 23 DE JULIO", "04A COOP.AHO.CREDITO FORTUNA", "04B COOP.AHO.CREDITO CACPE CELICA", "04C BIESS", "04D COOP.AHO.CREDITO MARCABELI LTDA", "04E COOP.AHO.CREDITO FORTUNA", "04F COOP.AHO.CREDITO DE LOS SERV.PUBL.DEL MIN.EDUCACION", "04G COOP.AHO.CREDITO SANTA ROSA DE PATUTAN LTDA.", "04H BANCO-D-MIRO S.A.", "04I BANCO FINCA", "04J COOP.AHO.CREDITO CHIBULEO LTDA.", "04k COOP.AHO.CREDITO SAN SEBASTIAN", "04L COOP.AHO.CREDITO GONZANAMA", "04M COOP.AHO.CREDITO SERVIDORES MUNICIPALES DE CUENCA", "04N CORPORACION FINANCIERA", "04O COOP.AHO.CREDITO MANANTIAL DE ORO LTDA", "04P COOP.AHO.CREDITO TENA LTDA", "04Q COOP.AHO.CREDITO ALIANZA MINAS LTDA", "04R COOP.AHO.CREDITO DESARROLLO INTEGRAL LTDA", "04S COOP.AHO.CREDITO EDUCADORES DE PASTAZA LTDA", "04V COOP.AHO.CREDITO COCA LTDA", "04W COOP.AHO.CREDITO 23 DE MAYO LTDA"})
            Me.cbxBanco.Location = New System.Drawing.Point(68, 23)
            Me.cbxBanco.Name = "cbxBanco"
            Me.cbxBanco.Size = New System.Drawing.Size(194, 21)
            Me.cbxBanco.TabIndex = 1
            '
            'txtNumCtaTarj
            '
            Me.txtNumCtaTarj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumCtaTarj.Location = New System.Drawing.Point(564, 22)
            Me.txtNumCtaTarj.Name = "txtNumCtaTarj"
            Me.txtNumCtaTarj.Size = New System.Drawing.Size(110, 20)
            Me.txtNumCtaTarj.TabIndex = 5
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(11, 27)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(43, 13)
            Me.Label14.TabIndex = 74
            Me.Label14.Text = "BANCO:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(482, 25)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(85, 13)
            Me.Label16.TabIndex = 77
            Me.Label16.Text = "N° CTA / TAR:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(11, 51)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(61, 13)
            Me.Label15.TabIndex = 75
            Me.Label15.Text = "TIPO CTA:"
            '
            'cbxTipoCuenta
            '
            Me.cbxTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.cbxTipoCuenta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbxTipoCuenta.ForeColor = System.Drawing.Color.Black
            Me.cbxTipoCuenta.FormattingEnabled = True
            Me.cbxTipoCuenta.Items.AddRange(New Object() {"10  AHORRO", "00  CORRIENTE", "00  TARJETA DE CREDITO"})
            Me.cbxTipoCuenta.Location = New System.Drawing.Point(68, 47)
            Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
            Me.cbxTipoCuenta.Size = New System.Drawing.Size(194, 21)
            Me.cbxTipoCuenta.TabIndex = 2
            '
            'Button2
            '
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(613, 159)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 10
            Me.Button2.Text = "ACEPTAR"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button1
            '
            Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button1.Location = New System.Drawing.Point(532, 159)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 9
            Me.Button1.Text = "CANCELAR"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.White
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Controls.Add(Me.TextBox1)
            Me.GroupBox3.Controls.Add(Me.cbxTipoCuenta)
            Me.GroupBox3.Controls.Add(Me.Label15)
            Me.GroupBox3.Controls.Add(Me.txtValor)
            Me.GroupBox3.Controls.Add(Me.Label20)
            Me.GroupBox3.Controls.Add(Me.Label14)
            Me.GroupBox3.Controls.Add(Me.txtCedRucTitular)
            Me.GroupBox3.Controls.Add(Me.txtNumCtaTarj)
            Me.GroupBox3.Controls.Add(Me.cbxBanco)
            Me.GroupBox3.Controls.Add(Me.cbxTipoDoc)
            Me.GroupBox3.Controls.Add(Me.Label18)
            Me.GroupBox3.Controls.Add(Me.txtTitular)
            Me.GroupBox3.Controls.Add(Me.Label16)
            Me.GroupBox3.Controls.Add(Me.Label19)
            Me.GroupBox3.Controls.Add(Me.Label17)
            Me.GroupBox3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(686, 151)
            Me.GroupBox3.TabIndex = 202
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "DEFINIR DATOS DEL CONVENIO DE DÉBITO BANCARIO"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(466, 76)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(211, 13)
            Me.Label2.TabIndex = 89
            Me.Label2.Text = "El valor debe ser mayor que $ 0.00"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 101)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(79, 13)
            Me.Label1.TabIndex = 87
            Me.Label1.Text = "OBSERVACIÓN:"
            '
            'TextBox1
            '
            Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TextBox1.Location = New System.Drawing.Point(99, 98)
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(574, 45)
            Me.TextBox1.TabIndex = 8
            '
            'FrmCrearConvenioBanco
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(693, 187)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FrmCrearConvenioBanco"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AGREAR DETALLE CONVENIO DÉBITO BANCO"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtValor As System.Windows.Forms.TextBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtCedRucTitular As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cbxTipoDoc As System.Windows.Forms.ComboBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtTitular As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents cbxBanco As System.Windows.Forms.ComboBox
        Friend WithEvents txtNumCtaTarj As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cbxTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace