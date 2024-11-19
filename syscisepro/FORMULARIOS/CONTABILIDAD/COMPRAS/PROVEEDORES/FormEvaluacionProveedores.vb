
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormEvaluacionProveedores

        Public validarProveedor As Integer = 0
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Get
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        Return 2
                    Case TipoConexion.Seportpac
                        Return 1
                    Case Else
                        Return 0
                End Select
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 2
                        _tipoCon = TipoConexion.Asenava
                    Case 1
                        _tipoCon = TipoConexion.Seportpac
                    Case Else
                        _tipoCon = TipoConexion.Cisepro
                End Select
            End Set
        End Property 
        Public IdUsuario As Integer
        Dim objAuditoria As New ClassAuditoriaGeneral
        Dim objetoProveedorGeneral As New ClassProveedores
        Dim objetoEvaluacionServicios As New ClassEvaluacionProveedoreServicios
        Dim objetoEvaluacionMateriales As New ClassEvaluacionProveedorMateriales

        Public Sub deshabilitadoInicio()
            btnNuevoProveedorGeneral.Enabled = True
            btnCancelarProveedorGeneral.Enabled = False
            btnGuardarProveedorGeneral.Enabled = False 
            btnBuscarPersonal.Enabled = False
            cmbTipoProveedor.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = False
            txtNombrePersonal.Enabled = False
            txtPregunta1Servicios.Enabled = False : cmbPregunta1Servicios.Enabled = False
            txtPregunta2Servicios.Enabled = False : cmbPregunta2Servicios.Enabled = False
            txtPregunta3Servicios.Enabled = False : cmbPregunta3Servicios.Enabled = False
            txtPregunta4Servicios.Enabled = False : cmbPregunta4Servicios.Enabled = False
            txtPregunta5Servicios.Enabled = False : cmbPregunta5Servicios.Enabled = False
            txtPregunta6Servicios.Enabled = False : cmbPregunta6Servicios.Enabled = False
            txtPregunta7Servicios.Enabled = False : cmbPregunta7Servicios.Enabled = False
            txtPregunta8Servicios.Enabled = False : cmbPregunta8Servicios.Enabled = False
            txtPregunta9Servicios.Enabled = False : cmbPregunta9Servicios.Enabled = False
            txtPregunta10Servicios.Enabled = False : cmbPregunta10Servicios.Enabled = False
            txtTotalEvaluacionServicios.Enabled = False
            txtPregunta1Materiales.Enabled = False : cmbPregunta1Materiales.Enabled = False
            txtPregunta2Materiales.Enabled = False : cmbPregunta2Materiales.Enabled = False
            txtPregunta3Materiales.Enabled = False : cmbPregunta3Materiales.Enabled = False
            txtPregunta4Materiales.Enabled = False : cmbPregunta4Materiales.Enabled = False
            txtPregunta5Materiales.Enabled = False : cmbPregunta5Materiales.Enabled = False
            txtPregunta6Materiales.Enabled = False : cmbPregunta6Materiales.Enabled = False
            txtPregunta7Materiales.Enabled = False : cmbPregunta7Materiales.Enabled = False
            txtPregunta8Materiales.Enabled = False : cmbPregunta8Materiales.Enabled = False
            txtPregunta9Materiales.Enabled = False : cmbPregunta9Materiales.Enabled = False
            txtTotalEvaluacionMateriales.Enabled = False
        End Sub
        Public Sub deshabilitadoProveedorServicios()
            txtPregunta1Servicios.Enabled = False : cmbPregunta1Servicios.Enabled = False
            txtPregunta2Servicios.Enabled = False : cmbPregunta2Servicios.Enabled = False
            txtPregunta3Servicios.Enabled = False : cmbPregunta3Servicios.Enabled = False
            txtPregunta4Servicios.Enabled = False : cmbPregunta4Servicios.Enabled = False
            txtPregunta5Servicios.Enabled = False : cmbPregunta5Servicios.Enabled = False
            txtPregunta6Servicios.Enabled = False : cmbPregunta6Servicios.Enabled = False
            txtPregunta7Servicios.Enabled = False : cmbPregunta7Servicios.Enabled = False
            txtPregunta8Servicios.Enabled = False : cmbPregunta8Servicios.Enabled = False
            txtPregunta9Servicios.Enabled = False : cmbPregunta9Servicios.Enabled = False
            txtPregunta10Servicios.Enabled = False : cmbPregunta10Servicios.Enabled = False
            txtTotalEvaluacionServicios.Enabled = False
        End Sub
        Public Sub deshabilitadoproveedorMateriales()
            txtPregunta1Materiales.Enabled = False : cmbPregunta1Materiales.Enabled = False
            txtPregunta2Materiales.Enabled = False : cmbPregunta2Materiales.Enabled = False
            txtPregunta3Materiales.Enabled = False : cmbPregunta3Materiales.Enabled = False
            txtPregunta4Materiales.Enabled = False : cmbPregunta4Materiales.Enabled = False
            txtPregunta5Materiales.Enabled = False : cmbPregunta5Materiales.Enabled = False
            txtPregunta6Materiales.Enabled = False : cmbPregunta6Materiales.Enabled = False
            txtPregunta7Materiales.Enabled = False : cmbPregunta7Materiales.Enabled = False
            txtPregunta8Materiales.Enabled = False : cmbPregunta8Materiales.Enabled = False
            txtPregunta9Materiales.Enabled = False : cmbPregunta9Materiales.Enabled = False
            txtTotalEvaluacionMateriales.Enabled = False
        End Sub

        Public Sub habilitadoNuevo()
            btnNuevoProveedorGeneral.Enabled = False
            btnCancelarProveedorGeneral.Enabled = True
            btnGuardarProveedorGeneral.Enabled = True 
            btnBuscarPersonal.Enabled = True
            cmbTipoProveedor.Enabled = True
            txtNombreComercialProveedorGeneral.Enabled = True
        End Sub
        Public Sub habilitadoProveedorServicios()
            cmbPregunta1Servicios.Enabled = True
            cmbPregunta2Servicios.Enabled = True
            cmbPregunta3Servicios.Enabled = True
            cmbPregunta4Servicios.Enabled = True
            cmbPregunta5Servicios.Enabled = True
            cmbPregunta6Servicios.Enabled = True
            cmbPregunta7Servicios.Enabled = True
            cmbPregunta8Servicios.Enabled = True
            cmbPregunta9Servicios.Enabled = True
            cmbPregunta10Servicios.Enabled = True
        End Sub
        Public Sub habilitadoProveedorMateriales()
            cmbPregunta1Materiales.Enabled = True
            cmbPregunta2Materiales.Enabled = True
            cmbPregunta3Materiales.Enabled = True
            cmbPregunta4Materiales.Enabled = True
            cmbPregunta5Materiales.Enabled = True
            cmbPregunta6Materiales.Enabled = True
            cmbPregunta7Materiales.Enabled = True
            cmbPregunta8Materiales.Enabled = True
            cmbPregunta9Materiales.Enabled = True
        End Sub
        Public Sub limpiarparametros()
            lblIdEvlauacion.Text = "000"
            lblIdProveedorGeneral.Text = "."
            txtNombreComercialProveedorGeneral.Text = ""
            lblIdPersonal.Text = "."
            txtNombrePersonal.Text = ""
            lblFechaEvaluacionProveedor.Text = "00/00/0000"
            txtPregunta1Servicios.Text = "0" : cmbPregunta1Servicios.Text = "Seleccione una opción"
            txtPregunta2Servicios.Text = "0" : cmbPregunta2Servicios.Text = "Seleccione una opción"
            txtPregunta3Servicios.Text = "0" : cmbPregunta3Servicios.Text = "Seleccione una opción"
            txtPregunta4Servicios.Text = "0" : cmbPregunta4Servicios.Text = "Seleccione una opción"
            txtPregunta5Servicios.Text = "0" : cmbPregunta5Servicios.Text = "Seleccione una opción"
            txtPregunta6Servicios.Text = "0" : cmbPregunta6Servicios.Text = "Seleccione una opción"
            txtPregunta7Servicios.Text = "0" : cmbPregunta7Servicios.Text = "Seleccione una opción"
            txtPregunta8Servicios.Text = "0" : cmbPregunta8Servicios.Text = "Seleccione una opción"
            txtPregunta9Servicios.Text = "0" : cmbPregunta9Servicios.Text = "Seleccione una opción"
            txtPregunta10Servicios.Text = "0" : cmbPregunta10Servicios.Text = "Seleccione una opción"
            txtTotalEvaluacionServicios.Text = "0"
        End Sub
        Public Function ValidacionParametrosServicios() As Boolean
            If lblIdEvlauacion.Text <> "" And txtNombreComercialProveedorGeneral.Text <> "" And txtNombrePersonal.Text <> "" And lblFechaEvaluacionProveedor.Text <> "" And txtPregunta1Servicios.Text <> "" And cmbPregunta1Servicios.Text <> "" And txtPregunta2Servicios.Text <> "" And cmbPregunta2Servicios.Text <> "" And txtPregunta3Servicios.Text <> "" And cmbPregunta3Servicios.Text <> "" And txtPregunta4Servicios.Text <> "" And cmbPregunta4Servicios.Text <> "" And txtPregunta5Servicios.Text <> "" And cmbPregunta5Servicios.Text <> "" And txtPregunta6Servicios.Text <> "" And txtPregunta7Servicios.Text <> "" And txtPregunta8Servicios.Text <> "" And cmbPregunta8Servicios.Text <> "" And txtPregunta9Servicios.Text <> "" And txtPregunta10Servicios.Text <> "" And txtTotalEvaluacionServicios.Text <> "" Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function ValidacionParametrosMateriales() As Boolean
            If lblIdEvlauacion.Text <> "" And txtNombreComercialProveedorGeneral.Text <> "" And txtNombrePersonal.Text <> "" And lblIdEvlauacion.Text <> "" And lblFechaEvaluacionProveedor.Text <> "" And txtPregunta1Materiales.Text <> "" And txtPregunta2Materiales.Text <> "" And txtPregunta3Materiales.Text <> "" And txtPregunta4Materiales.Text <> "" And txtPregunta5Materiales.Text <> "" And txtPregunta6Materiales.Text <> "" And txtPregunta7Materiales.Text <> "" And txtPregunta8Materiales.Text <> "" And txtPregunta9Materiales.Text <> "" And txtTotalEvaluacionMateriales.Text <> "" Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Sub autocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Public Sub Auditoria()
            With objAuditoria

                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = idUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = Date.Now
                .NuevaAuditoria(_tipoCon)
            End With
        End Sub
        Public Sub guargarRegistroEvaluacioServicios()
            With objetoEvaluacionServicios
                .IdEvaluacionProveedorServicios = .BuscarMayorIdEvaluacionProveedorServicios(_tipoCon) + 1
                .FechaEvaluacionProveedorServicios = dtpFechaEvaluacion.Value
                .InstalacionesEvaluacionProveedorServicios = txtPregunta1Servicios.Text
                .PersonalPropioEvaluacionProveedorServicios = txtPregunta2Servicios.Text
                .TransporteEvaluacionProveedorServicios = txtPregunta3Servicios.Text
                .TiempoRespuestaEvaluacionProveedorServicios = txtPregunta4Servicios.Text
                .CumplimientoTiemposEntregaEvaluacionProveedorServicios = txtPregunta5Servicios.Text
                .PrecioEvaluacionProveedorServicios = txtPregunta6Servicios.Text
                .CondicionesPagoEvaluacionProveedorServicios = txtPregunta7Servicios.Text
                .GarantiasEvaluacionProveedorServicios = txtPregunta8Servicios.Text
                .SoporteTecnicoEvaluacionProveedorServicios = txtPregunta9Servicios.Text
                .DocumentosActualizadosEvaluacionProveedorServicios = txtPregunta10Servicios.Text
                .TotalEvaluacionProveedorServicios = txtTotalEvaluacionServicios.Text
                .EstadoEvaluacionProveedorServicios = 1
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .IdPersonal = lblIdPersonal.Text
                .NuevoRegistroEvaluacionProveedorServicios(_tipoCon)
            End With
            objAuditoria.AccionAuditoria = "CREO UNA NUEVA EVALUACIÓN DE PROVEEDOR DE SERVICIOS. ID: " + lblIdEvlauacion.Text + " PROVEEDOR EVALUADO: " + txtNombreComercialProveedorGeneral.Text + " RESPONSABLE EVALUACION: " + txtNombrePersonal.Text + " TOTAL EVALUACION: " + txtTotalEvaluacionServicios.Text
            objAuditoria.FormularioAuditoria = Me.Text.ToUpper
            Auditoria()
        End Sub
        Public Sub guargarRegistroEvaluacioMateriales()
            With objetoEvaluacionMateriales

                .IdEvaluacionProveedorMateriales = .BuscarMayorIdEvaluacionProveedorMateriales(_tipoCon) + 1
                .FechaEvaluacionProveedorMateriales = dtpFechaEvaluacion.Value
                .CapacidadProvisionEvaluacionProveedorMateriales = txtPregunta1Materiales.Text
                .PuntosEntregaEvaluacionProveedorMateriales = txtPregunta2Materiales.Text
                .TiemposEntregaEvaluacionProveedorMateriales = txtPregunta3Materiales.Text
                .PrecioEvaluacionProveedorMateriales = txtPregunta4Materiales.Text
                .CondicionesPagoEvaluacionProveedorMateriales = txtPregunta5Materiales.Text
                .GarantiasEvaluacionProveedorMateriales = txtPregunta6Materiales.Text
                .SoporteTecnicoEvaluacionProveedorMateriales = txtPregunta7Materiales.Text
                .ServiciosAsociadosEvaluacionProveedorMateriales = txtPregunta8Materiales.Text
                .CalidadMaterialEvaluacionProveedorMateriales = txtPregunta9Materiales.Text
                .TotalEvaluacionProveedorMateriales = txtTotalEvaluacionMateriales.Text
                .EstadoEvaluacionProveedorMateriales = 1
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .IdPersonal = lblIdPersonal.Text
                .NuevoRegistroEvaluacionProveedorMateriales(_tipoCon)
            End With
            objAuditoria.AccionAuditoria = "CREO UNA NUEVA EVALUACION DE PROVEEDOR DE MATERIALES. ID: " + lblIdEvlauacion.Text + " PROVEEDOR EVALUADO: " + lblIdProveedorGeneral.Text + " RESPONSABLE EVALUACION: " + lblIdPersonal.Text + " TTOTAL EVALUACION: " + txtTotalEvaluacionServicios.Text
            objAuditoria.FormularioAuditoria = Me.Text.ToUpper
            Auditoria()
        End Sub
        Private Sub FormEvaluacionProveedorServicios_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            deshabilitadoInicio() 
        End Sub

        Private Sub btnNuevoProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoProveedorGeneral.Click
            lblFechaEvaluacionProveedor.Text = Date.Now
            habilitadoNuevo()
            autocompletarNombreProveedor()
            If cmbTipoProveedor.Text = "SERVICIOS" Then

                lblIdEvlauacion.Text = objetoEvaluacionServicios.BuscarMayorIdEvaluacionProveedorServicios(_tipoCon) + 1
                habilitadoProveedorServicios()
            ElseIf cmbTipoProveedor.Text = "MATERIALES" Then

                lblIdEvlauacion.Text = objetoEvaluacionMateriales.BuscarMayorIdEvaluacionProveedorMateriales(_tipoCon) + 1
                habilitadoProveedorMateriales()
            End If
        End Sub
        Private Sub btnCancelarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarProveedorGeneral.Click
            limpiarparametros()
            deshabilitadoInicio()
        End Sub
        Private Sub btnGuardarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarProveedorGeneral.Click
            Select Case (validarProveedor)
                Case 1
                    If ValidacionParametrosServicios() = True Then
                        guargarRegistroEvaluacioServicios()
                        deshabilitadoInicio()
                    Else
                        MsgBox("No se puede guardar" & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS PARA LA EVALUACIÓN.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    End If
                Case 2
                    If ValidacionParametrosMateriales() = True Then
                        guargarRegistroEvaluacioMateriales()
                        deshabilitadoInicio()
                    Else
                        MsgBox("No se puede guardar" & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS PARA LA EVALUACIÓN.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    End If
            End Select

        End Sub
        
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.Todos = True 
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        lblIdPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value 
                        txtNombrePersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                lblIdPersonal.Text = ""
                txtNombrePersonal.Clear()
            End Try
        End Sub
        Private Sub cmbTipoProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoProveedor.SelectedIndexChanged
            Select Case (cmbTipoProveedor.Text)
                Case "SERVICIOS"
                    habilitadoProveedorServicios() : deshabilitadoproveedorMateriales()
                    tcEvaluacionesProveedores.SelectedTab = tpEvaluacionProveedorServicios

                    lblIdEvlauacion.Text = objetoEvaluacionServicios.BuscarMayorIdEvaluacionProveedorServicios(_tipoCon) + 1
                    validarProveedor = 1
                Case "MATERIALES"
                    habilitadoProveedorMateriales()
                    deshabilitadoProveedorServicios()
                    tcEvaluacionesProveedores.SelectedTab = tpEvaluacionProveedorMateriales

                    lblIdEvlauacion.Text = objetoEvaluacionMateriales.BuscarMayorIdEvaluacionProveedorMateriales(_tipoCon) + 1
                    validarProveedor = 2
            End Select
        End Sub

        '===================================================== EVALUACION PROVEEDOR DE MATERILIALES ===========================================================================
        Private Sub cmbPregunta1Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta1Materiales.SelectedIndexChanged
            Try
                If cmbPregunta1Materiales.SelectedIndex = 0 Then
                    txtPregunta1Materiales.Text = 5
                ElseIf cmbPregunta1Materiales.SelectedIndex = 1 Then
                    txtPregunta1Materiales.Text = 10
                ElseIf cmbPregunta1Materiales.SelectedIndex = 2 Then
                    txtPregunta1Materiales.Text = 13
                ElseIf cmbPregunta1Materiales.SelectedIndex = 3 Then
                    txtPregunta1Materiales.Text = 15
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta2Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta2Materiales.SelectedIndexChanged
            Try
                If cmbPregunta2Materiales.SelectedIndex = 0 Then
                    txtPregunta2Materiales.Text = 5
                ElseIf cmbPregunta2Materiales.SelectedIndex = 1 Then
                    txtPregunta2Materiales.Text = 15
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta3Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta3Materiales.SelectedIndexChanged
            Try
                If cmbPregunta3Materiales.SelectedIndex = 0 Then
                    txtPregunta3Materiales.Text = 3
                ElseIf cmbPregunta3Materiales.SelectedIndex = 1 Then
                    txtPregunta3Materiales.Text = 7
                ElseIf cmbPregunta3Materiales.SelectedIndex = 2 Then
                    txtPregunta3Materiales.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta4Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta4Materiales.SelectedIndexChanged
            Try
                If cmbPregunta4Materiales.SelectedIndex = 0 Then
                    txtPregunta4Materiales.Text = 2
                ElseIf cmbPregunta4Materiales.SelectedIndex = 1 Then
                    txtPregunta4Materiales.Text = 5
                ElseIf cmbPregunta4Materiales.SelectedIndex = 2 Then
                    txtPregunta4Materiales.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta5Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta5Materiales.SelectedIndexChanged
            Try
                If cmbPregunta5Materiales.SelectedIndex = 0 Then
                    txtPregunta5Materiales.Text = 2
                ElseIf cmbPregunta5Materiales.SelectedIndex = 1 Then
                    txtPregunta5Materiales.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta6Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta6Materiales.SelectedIndexChanged
            Try
                If cmbPregunta6Materiales.SelectedIndex = 0 Then
                    txtPregunta6Materiales.Text = 0
                ElseIf cmbPregunta6Materiales.SelectedIndex = 1 Then
                    txtPregunta6Materiales.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta7Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta7Materiales.SelectedIndexChanged
            Try
                If cmbPregunta7Materiales.SelectedIndex = 0 Then
                    txtPregunta7Materiales.Text = 0
                ElseIf cmbPregunta7Materiales.SelectedIndex = 1 Then
                    txtPregunta7Materiales.Text = 2
                ElseIf cmbPregunta7Materiales.SelectedIndex = 2 Then
                    txtPregunta7Materiales.Text = 5
                End If
            Catch ex As Exception
                MsgBox("COMBOBOX PREGUNTA 7 " + ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE")
            End Try
        End Sub
        Private Sub cmbPregunta8Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta8Materiales.SelectedIndexChanged
            Try
                If cmbPregunta8Materiales.SelectedIndex = 0 Then
                    txtPregunta8Materiales.Text = 2
                ElseIf cmbPregunta8Materiales.SelectedIndex = 1 Then
                    txtPregunta8Materiales.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta9Materiales_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta9Materiales.SelectedIndexChanged
            Try
                If cmbPregunta9Materiales.SelectedIndex = 0 Then
                    txtPregunta9Materiales.Text = 5
                ElseIf cmbPregunta9Materiales.SelectedIndex = 1 Then
                    txtPregunta9Materiales.Text = 18
                ElseIf cmbPregunta9Materiales.SelectedIndex = 2 Then
                    txtPregunta9Materiales.Text = 24
                ElseIf cmbPregunta9Materiales.SelectedIndex = 3 Then
                    txtPregunta9Materiales.Text = 30
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtPregunta1Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta1Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta2Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta2Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta3Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta3Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta4Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta4Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta5Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta5Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta6Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta6Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta7Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta7Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta8Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta8Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtPregunta9Materiales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta9Materiales.TextChanged
            Try
                txtTotalEvaluacionMateriales.Text = CType(txtPregunta1Materiales.Text, Integer) + CType(txtPregunta2Materiales.Text, Integer) + CType(txtPregunta3Materiales.Text, Integer) + CType(txtPregunta4Materiales.Text, Integer) + CType(txtPregunta5Materiales.Text, Integer) + CType(txtPregunta6Materiales.Text, Integer) + CType(txtPregunta7Materiales.Text, Integer) + CType(txtPregunta8Materiales.Text, Integer) + CType(txtPregunta9Materiales.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub txtTotalEvaluacionMateriales_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTotalEvaluacionMateriales.TextChanged
            Try
                If CType(txtTotalEvaluacionMateriales.Text, Integer) >= 75 Then
                    txtTotalEvaluacionMateriales.BackColor = Color.GreenYellow
                    lblCalificacionEvaluacionMateriales.Text = "PROVEEDOR FIJO"
                    lblCalificacionEvaluacionMateriales.ForeColor = Color.GreenYellow
                ElseIf CType(txtTotalEvaluacionMateriales.Text, Integer) < 75 And CType(txtTotalEvaluacionMateriales.Text, Integer) > 64 Then
                    txtTotalEvaluacionMateriales.BackColor = Color.Yellow
                    lblCalificacionEvaluacionMateriales.Text = "PROVEEDOR OCASIONAL"
                    lblCalificacionEvaluacionMateriales.ForeColor = Color.Yellow
                ElseIf CType(txtTotalEvaluacionMateriales.Text, Integer) < 65 Then
                    txtTotalEvaluacionMateriales.BackColor = Color.Red
                    lblCalificacionEvaluacionMateriales.Text = "PROVEEDOR DESCARTADO"
                    lblCalificacionEvaluacionMateriales.ForeColor = Color.Red
                End If
            Catch ex As Exception
            End Try
        End Sub
        '===================================================================== EVALUACION MATERIALES ========================================================================
        Private Sub cmbPregunta1Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta1Servicios.SelectedIndexChanged
            Try
                If cmbPregunta1Servicios.SelectedIndex = 0 Then
                    txtPregunta1Servicios.Text = 5
                ElseIf cmbPregunta1Servicios.SelectedIndex = 1 Then
                    txtPregunta1Servicios.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta2Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta2Servicios.SelectedIndexChanged
            Try
                If cmbPregunta2Servicios.SelectedIndex = 0 Then
                    txtPregunta2Servicios.Text = 5
                ElseIf cmbPregunta2Servicios.SelectedIndex = 1 Then
                    txtPregunta2Servicios.Text = 10
                ElseIf cmbPregunta2Servicios.SelectedIndex = 2 Then
                    txtPregunta2Servicios.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta3Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta3Servicios.SelectedIndexChanged
            Try
                If cmbPregunta3Servicios.SelectedIndex = 0 Then
                    txtPregunta3Servicios.Text = 5
                ElseIf cmbPregunta3Servicios.SelectedIndex = 1 Then
                    txtPregunta3Servicios.Text = 10
                ElseIf cmbPregunta3Servicios.SelectedIndex = 2 Then
                    txtPregunta3Servicios.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta4Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta4Servicios.SelectedIndexChanged
            Try
                If cmbPregunta4Servicios.SelectedIndex = 0 Then
                    txtPregunta4Servicios.Text = 2
                ElseIf cmbPregunta4Servicios.SelectedIndex = 1 Then
                    txtPregunta4Servicios.Text = 4
                ElseIf cmbPregunta4Servicios.SelectedIndex = 2 Then
                    txtPregunta4Servicios.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta5Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta5Servicios.SelectedIndexChanged
            Try
                If cmbPregunta5Servicios.SelectedIndex = 0 Then
                    txtPregunta5Servicios.Text = 5
                ElseIf cmbPregunta5Servicios.SelectedIndex = 1 Then
                    txtPregunta5Servicios.Text = 10
                ElseIf cmbPregunta5Servicios.SelectedIndex = 2 Then
                    txtPregunta5Servicios.Text = 15
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta6Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta6Servicios.SelectedIndexChanged
            Try
                If cmbPregunta6Servicios.SelectedIndex = 0 Then
                    txtPregunta6Servicios.Text = 2
                ElseIf cmbPregunta6Servicios.SelectedIndex = 1 Then
                    txtPregunta6Servicios.Text = 5
                ElseIf cmbPregunta6Servicios.SelectedIndex = 2 Then
                    txtPregunta6Servicios.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta7Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta7Servicios.SelectedIndexChanged
            Try
                If cmbPregunta7Servicios.SelectedIndex = 0 Then
                    txtPregunta7Servicios.Text = 2
                ElseIf cmbPregunta7Servicios.SelectedIndex = 1 Then
                    txtPregunta7Servicios.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta8Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta8Servicios.SelectedIndexChanged
            Try
                If cmbPregunta8Servicios.SelectedIndex = 0 Then
                    txtPregunta8Servicios.Text = 0
                ElseIf cmbPregunta8Servicios.SelectedIndex = 1 Then
                    txtPregunta8Servicios.Text = 5
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta9Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta9Servicios.SelectedIndexChanged
            Try
                If cmbPregunta9Servicios.SelectedIndex = 0 Then
                    txtPregunta9Servicios.Text = 0
                ElseIf cmbPregunta9Servicios.SelectedIndex = 1 Then
                    txtPregunta9Servicios.Text = 20
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cmbPregunta10Servicios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta10Servicios.SelectedIndexChanged
            Try
                If cmbPregunta10Servicios.SelectedIndex = 0 Then
                    txtPregunta10Servicios.Text = 0
                ElseIf cmbPregunta10Servicios.SelectedIndex = 1 Then
                    txtPregunta10Servicios.Text = 5
                ElseIf cmbPregunta10Servicios.SelectedIndex = 2 Then
                    txtPregunta10Servicios.Text = 10
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtPregunta1Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta1Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta2Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta2Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta3Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta3Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta4Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta4Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta5Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta5Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta6Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta6Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta7Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta7Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta8Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta8Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta9Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta9Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub
        Private Sub txtPregunta10Servicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta10Servicios.TextChanged
            Try
                txtTotalEvaluacionServicios.Text = CType(txtPregunta1Servicios.Text, Integer) + CType(txtPregunta2Servicios.Text, Integer) + CType(txtPregunta3Servicios.Text, Integer) + CType(txtPregunta4Servicios.Text, Integer) + CType(txtPregunta5Servicios.Text, Integer) + CType(txtPregunta6Servicios.Text, Integer) + CType(txtPregunta7Servicios.Text, Integer) + CType(txtPregunta8Servicios.Text, Integer) + CType(txtPregunta9Servicios.Text, Integer) + CType(txtPregunta10Servicios.Text, Integer)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub txtNombreComercialProveedorGeneral_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then

                lblIdProveedorGeneral.Text = objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text.Trim)
            End If
        End Sub

        Private Sub txtTotalEvaluacionServicios_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTotalEvaluacionServicios.TextChanged
            Try
                If CType(txtTotalEvaluacionServicios.Text, Integer) >= 75 Then
                    txtTotalEvaluacionServicios.BackColor = Color.GreenYellow
                    lblClalificacionEvaluacionServicios.Text = "PROVEEDOR FIJO"
                    lblClalificacionEvaluacionServicios.ForeColor = Color.GreenYellow
                ElseIf CType(txtTotalEvaluacionServicios.Text, Integer) < 75 And CType(txtTotalEvaluacionServicios.Text, Integer) > 64 Then
                    txtTotalEvaluacionServicios.BackColor = Color.Yellow
                    lblClalificacionEvaluacionServicios.Text = "PROVEEDOR OCASIONAL"
                    lblClalificacionEvaluacionServicios.ForeColor = Color.Yellow
                ElseIf CType(txtTotalEvaluacionServicios.Text, Integer) < 65 Then
                    txtTotalEvaluacionServicios.BackColor = Color.Red
                    lblClalificacionEvaluacionServicios.Text = "PROVEEDOR DESCARTADO"
                    lblClalificacionEvaluacionServicios.ForeColor = Color.Red
                End If
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace