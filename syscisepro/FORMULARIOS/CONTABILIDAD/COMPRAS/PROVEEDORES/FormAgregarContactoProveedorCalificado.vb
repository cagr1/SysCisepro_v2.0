
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class FormAgregarContactoProveedorCalificado
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

        Public idUsuario As Integer

        Dim objAuditoria As New ClassAuditoriaGeneral

        Dim objetoContactoProveedor As New ClassContactosProveedorCalificado

        Public Sub deshabilitadoInicio()
            btnBuscarProveedorCalificado.Enabled = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            btnNuevoProveedorCalificado.Enabled = True
            btnCancelarProveedorCalificado.Enabled = False
            btnGuardarProveedorCalificado.Enabled = False 
        End Sub

        Public Sub habilitadoNuevo()
            btnBuscarProveedorCalificado.Enabled = True
            btnAgregar.Enabled = True
            btnEliminar.Enabled = True
            btnNuevoProveedorCalificado.Enabled = False
            btnCancelarProveedorCalificado.Enabled = True
            btnGuardarProveedorCalificado.Enabled = True 
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

        Public Sub guardarRegistroContactoProveedorCalificado()
            Dim indice As Integer
            For indice = 0 To dgvContactosProveedorCalificado.RowCount - 1
                With objetoContactoProveedor
                    .IdContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(0).Value
                    .NombresContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(1).Value
                    .ApellidosContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(2).Value
                    .CargoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(3).Value
                    .TelefonoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(4).Value
                    .CelularContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(5).Value
                    .EmailContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(6).Value
                    .EstadoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(7).Value
                    .IdProveedorGeneral = dgvContactosProveedorCalificado.Rows(indice).Cells(8).Value
                    .NuevoRegistroContactoProveedorCalificado(_tipoCon)
                End With
                objAuditoria.AccionAuditoria = "CREO REGISTRO CONTÁCTO DE PROVEEDOR CALIFICADO. ID: " + dgvContactosProveedorCalificado.Rows(indice).Cells(0).Value + "NOMBRE: " + dgvContactosProveedorCalificado.Rows(indice).Cells(1).Value + " " + dgvContactosProveedorCalificado.Rows(indice).Cells(2).Value + " CORRESPONDIENTE AL PROVEEDOR GENERAL: RUC: " + txtRucCiProveedorGeneral.Text + " RAZÓN SOCIAL: " + txtRazonSocial.Text
                objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                Auditoria()
            Next
        End Sub

        Private Sub FormAgregarContactoProveedorCalificado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvContactosProveedorCalificado.Font = New Font("Roboto", 8, FontStyle.Regular)
            deshabilitadoInicio()
        End Sub

        Private Sub btnNuevoProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoProveedorCalificado.Click
            habilitadoNuevo()
        End Sub

        Private Sub btnCancelarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarProveedorCalificado.Click
            deshabilitadoInicio()
        End Sub

        Private Sub btnGuardarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarProveedorCalificado.Click
            If dgvContactosProveedorCalificado.RowCount <> 0 Then
                guardarRegistroContactoProveedorCalificado()
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN AGREGADO CONTÁCTOS AL PROVEEDOR CALIFICADO.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub btnBuscarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarProveedorCalificado.Click
            Dim formBuscarProveedor As New FormBuscarProveedorCalificado
            formBuscarProveedor.TipoCox = TipoCox
            DialogResult = formBuscarProveedor.ShowDialog
            Try
                If DialogResult = vbOK Then
                    txtIdProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(0).Value.ToString
                    txtRucCiProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(2).Value.ToString
                    txtRazonSocial.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(3).Value.ToString
                    txtNombreComercialProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(4).Value.ToString
                End If
            Catch ex As Exception
                MsgBox("BOTÓN BUSCAR PROVEEDOR:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If txtIdProveedorGeneral.Text <> "" Then
                Dim formAgregarContacto As New FormContactosProveedorCalificado
                formAgregarContacto.TipoCox = TipoCox
                DialogResult = formAgregarContacto.ShowDialog
                Try
                    If DialogResult = vbOK Then
                        dgvContactosProveedorCalificado.Rows.Add(formAgregarContacto.txtIdContactoProveedorCalificado.Text, formAgregarContacto.txtNombresContactoProveedorCalificado.Text, formAgregarContacto.txtApellidosContactoProveedorCalificado.Text, formAgregarContacto.txtCargoContactoProveedorCalificado.Text, formAgregarContacto.txtTelefonoContactoProveedorCalificado.Text, formAgregarContacto.txtCelularContactoProveedorCalificado.Text, formAgregarContacto.txtEmailContactoProveedorCalificado.Text, "1", txtIdProveedorGeneral.Text)
                    End If
                Catch ex As Exception
                    MsgBox("BOTÓN BUSCAR PROVEEDOR:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                End Try
            Else
                MsgBox("NO PUEDE AGREGAR CONTÁCTOS." & vbNewLine & "POR FAVOR PRIMERO SELECCIONE UN PROVEEDOR.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If dgvContactosProveedorCalificado.RowCount = 0 Then
                MsgBox("NO HAY CELDAS EN LA GRILLA", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                dgvContactosProveedorCalificado.Rows.RemoveAt(dgvContactosProveedorCalificado.CurrentRow.Index)
            End If
        End Sub
    End Class
End Namespace