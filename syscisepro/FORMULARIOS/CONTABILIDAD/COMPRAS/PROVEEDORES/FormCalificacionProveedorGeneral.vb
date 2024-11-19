
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES

    Public Class FormCalificacionProveedorGeneral
        Public idUsuario As Integer
        ReadOnly _tipoCon = [Enum].Parse(GetType(TipoConexion), 0) ' CISEPRO

        Dim objAuditoria As New ClassAuditoriaGeneral

        Dim objetoCalificacionGeneral As New ClassCalificacionProveedores

        Public Sub deshabilitadoInicio()
            btnNuevoCalificacionProveedor.Enabled = True
            btnModificarCalificacionProveedor.Enabled = False
            btnCancelarCalificacionProveedor.Enabled = False
            btnGuardarCalificacionProveedor.Enabled = False
            btnSalirCalificacionProveedor.Enabled = True
            btnBuscarProveedorGeneral.Enabled = False
            btnBuscarPersonal.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = False
            txtNombrePersonal.Enabled = False
            txtPregunta1CalificacionProveedor.Enabled = False : cmbPregunta1CalificacionProveedor.Enabled = False
            txtPregunta2CalificacionProveedor.Enabled = False : cmbPregunta2CalificacionProveedor.Enabled = False
            txtPregunta3CalificacionProveedor.Enabled = False : cmbPregunta3CalificacionProveedor.Enabled = False
            txtPregunta4CalificacionProveedor.Enabled = False : cmbPregunta4CalificacionProveedor.Enabled = False
            txtPregunta5CalificacionProveedor.Enabled = False : cmbPregunta5CalificacionProveedor.Enabled = False
            txtPregunta6CalificacionProveedor.Enabled = False : cmbPregunta6CalificacionProveedor.Enabled = False
            txtTotalCalificacionProveedor.Enabled = False : txtObservacionesCalificacionProveedores.Enabled = False
        End Sub
        Public Sub habilitadoNuevo()
            btnNuevoCalificacionProveedor.Enabled = False
            btnCancelarCalificacionProveedor.Enabled = True
            btnGuardarCalificacionProveedor.Enabled = True
            btnSalirCalificacionProveedor.Enabled = False
            btnBuscarProveedorGeneral.Enabled = True
            btnBuscarPersonal.Enabled = True
            cmbPregunta1CalificacionProveedor.Enabled = True
            cmbPregunta2CalificacionProveedor.Enabled = True
            cmbPregunta3CalificacionProveedor.Enabled = True
            cmbPregunta4CalificacionProveedor.Enabled = True
            cmbPregunta5CalificacionProveedor.Enabled = True
            cmbPregunta6CalificacionProveedor.Enabled = True
            txtObservacionesCalificacionProveedores.Enabled = True
        End Sub
        Public Sub limpiarparametros()
            lblIdCalificacion.Text = "000"
            lblIdProveedorGeneral.Text = "."
            txtNombreComercialProveedorGeneral.Text = ""
            lblIdPersonal.Text = "."
            txtNombrePersonal.Text = ""
            lblFechaCalificacion.Text = "00/00/0000"
            txtPregunta1CalificacionProveedor.Text = "0" : cmbPregunta1CalificacionProveedor.Text = "Seleccione una opción"
            txtPregunta2CalificacionProveedor.Text = "0" : cmbPregunta2CalificacionProveedor.Text = "Seleccione una opción"
            txtPregunta3CalificacionProveedor.Text = "0" : cmbPregunta3CalificacionProveedor.Text = "Seleccione una opción"
            txtPregunta4CalificacionProveedor.Text = "0" : cmbPregunta4CalificacionProveedor.Text = "Seleccione una opción"
            txtPregunta5CalificacionProveedor.Text = "0" : cmbPregunta5CalificacionProveedor.Text = "Seleccione una opción"
            txtPregunta6CalificacionProveedor.Text = "0" : cmbPregunta6CalificacionProveedor.Text = "Seleccione una opción"
            txtTotalCalificacionProveedor.Text = "0" : txtObservacionesCalificacionProveedores.Text = ""
        End Sub
        Public Function ValidacionParametros() As Boolean
            If lblIdCalificacion.Text <> "" And txtNombreComercialProveedorGeneral.Text <> "" And txtNombrePersonal.Text <> "" And lblFechaCalificacion.Text <> "" And txtPregunta1CalificacionProveedor.Text <> "" And txtPregunta2CalificacionProveedor.Text <> "" And txtPregunta3CalificacionProveedor.Text <> "" And txtPregunta4CalificacionProveedor.Text <> "" And txtPregunta5CalificacionProveedor.Text <> "" And txtPregunta6CalificacionProveedor.Text <> "" And txtTotalCalificacionProveedor.Text <> "" And lblAprobado.Text <> "" And txtObservacionesCalificacionProveedores.Text <> "" Then
                Return True
            Else
                Return False
            End If
        End Function
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
            With objetoCalificacionGeneral

                .IdCalificacionProveedor = .BuscarMayorIdCalificacionProveedor(_tipoCon) + 1
                .FechaCalificacionProveedor = lblFechaCalificacion.Text
                .RucCalificacionProveedor = txtPregunta1CalificacionProveedor.Text
                .EspecificacionesCalificacionProveedor = txtPregunta2CalificacionProveedor.Text
                .PresentacionProductoCalificacionProveedor = txtPregunta3CalificacionProveedor.Text
                .FormaPagoCalificacionProveedor = txtPregunta4CalificacionProveedor.Text
                .TiempoEntregaCalificacionProveedor = txtPregunta5CalificacionProveedor.Text
                .CertificacionesCalificacionProveedor = txtPregunta6CalificacionProveedor.Text
                .TotalCalificacionProveedor = txtTotalCalificacionProveedor.Text
                .AprobadoCalificacionProveedor = lblAprobado.Text
                .ObservacionesCalificacionProveedor = txtObservacionesCalificacionProveedores.Text
                .EstadoCalificacionProveedor = 1
                .IdProveedor = lblIdProveedorGeneral.Text
                .IdPersonal = lblIdPersonal.Text
                .NuevoRegistroCalificaionProveedor(_tipoCon)
            End With
            objAuditoria.AccionAuditoria = "CREO UNA NUEVA CALIFICACIÓN DE PROVEEDOR DE SERVICIOS. ID: " + lblIdCalificacion.Text + " PROVEEDOR EVALUADO: " + txtNombreComercialProveedorGeneral.Text + " RESPONSABLE EVALUACION: " + txtNombrePersonal.Text + " TOTAL EVALUACIÓN: " + txtTotalCalificacionProveedor.Text
            objAuditoria.FormularioAuditoria = Me.Text.ToUpper
            Auditoria()
        End Sub

        Private Sub FormCalificacionProveedorGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
            deshabilitadoInicio()
        End Sub

        Private Sub btnBuscarProveedorGeneral_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarProveedorGeneral.Click
            Dim FormBuscarProveedor As New FormBuscarProveedorGeneral
            DialogResult = FormBuscarProveedor.ShowDialog
            Try
                If DialogResult = vbOK Then
                    lblIdProveedorGeneral.Text = FormBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(0).Value.ToString
                    txtNombreComercialProveedorGeneral.Text = FormBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(4).Value.ToString
                End If
            Catch ex As Exception
                MsgBox("BOTÓN BUSCAR PROVEEDOR:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub

        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.IsOperaciones = True
            frm.IsAdmin = False
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

        Private Sub btnNuevoCalificacionProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoCalificacionProveedor.Click
            habilitadoNuevo()

            lblIdCalificacion.Text = objetoCalificacionGeneral.BuscarMayorIdCalificacionProveedor(True) + 1
            lblFechaCalificacion.Text = Date.Now
        End Sub
        Private Sub btnCancelarCalificacionProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarCalificacionProveedor.Click
            limpiarparametros()
            deshabilitadoInicio()
        End Sub

        Private Sub btnGuardarCalificacionProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarCalificacionProveedor.Click
            If ValidacionParametros() = True Then
                guargarRegistroEvaluacioServicios()
                deshabilitadoInicio()
            Else
                MsgBox("No se puede guardar" & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS PARA LA CALIFICACIÓN.", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub
        Private Sub btnSalirCalificacionProveedor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSalirCalificacionProveedor.Click
            Me.Close()
        End Sub

        Private Sub cmbPregunta1CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta1CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta1CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta1CalificacionProveedor.Text = 0
                ElseIf cmbPregunta1CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta1CalificacionProveedor.Text = 10
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbPregunta2CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta2CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta2CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta2CalificacionProveedor.Text = 0
                ElseIf cmbPregunta2CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta2CalificacionProveedor.Text = 15
                ElseIf cmbPregunta2CalificacionProveedor.SelectedIndex = 2 Then
                    txtPregunta2CalificacionProveedor.Text = 25
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbPregunta3CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta3CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta3CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta3CalificacionProveedor.Text = 0
                ElseIf cmbPregunta3CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta3CalificacionProveedor.Text = 20
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbPregunta4CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta4CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta4CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta4CalificacionProveedor.Text = 0
                ElseIf cmbPregunta4CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta4CalificacionProveedor.Text = 15
                ElseIf cmbPregunta4CalificacionProveedor.SelectedIndex = 2 Then
                    txtPregunta4CalificacionProveedor.Text = 20
                ElseIf cmbPregunta4CalificacionProveedor.SelectedIndex = 3 Then
                    txtPregunta4CalificacionProveedor.Text = 25
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbPregunta5CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta5CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta5CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta5CalificacionProveedor.Text = 0
                ElseIf cmbPregunta5CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta5CalificacionProveedor.Text = 5
                ElseIf cmbPregunta5CalificacionProveedor.SelectedIndex = 2 Then
                    txtPregunta5CalificacionProveedor.Text = 10
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbPregunta6CalificacionProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPregunta6CalificacionProveedor.SelectedIndexChanged
            Try
                If cmbPregunta6CalificacionProveedor.SelectedIndex = 0 Then
                    txtPregunta6CalificacionProveedor.Text = 0
                ElseIf cmbPregunta6CalificacionProveedor.SelectedIndex = 1 Then
                    txtPregunta6CalificacionProveedor.Text = 10
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub txtPregunta1CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta1CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtPregunta2CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta2CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtPregunta3CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta3CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtPregunta4CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta4CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtPregunta5CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta5CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtPregunta6CalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtPregunta6CalificacionProveedor.TextChanged
            Try
                txtTotalCalificacionProveedor.Text = CType(txtPregunta1CalificacionProveedor.Text, Integer) + CType(txtPregunta2CalificacionProveedor.Text, Integer) + CType(txtPregunta3CalificacionProveedor.Text, Integer) + CType(txtPregunta4CalificacionProveedor.Text, Integer) + CType(txtPregunta5CalificacionProveedor.Text, Integer) + CType(txtPregunta6CalificacionProveedor.Text, Integer)
            Catch ex As Exception
                Exit Try
            End Try
        End Sub

        Private Sub txtTotalCalificacionProveedor_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTotalCalificacionProveedor.TextChanged
            Try
                If CType(txtTotalCalificacionProveedor.Text, Integer) >= 75 Then
                    txtTotalCalificacionProveedor.BackColor = Color.GreenYellow
                    lblAprobado.Text = "SI"
                ElseIf CType(txtTotalCalificacionProveedor.Text, Integer) < 75 Then
                    txtTotalCalificacionProveedor.BackColor = Color.Red
                    lblAprobado.Text = "NO"
                End If
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace