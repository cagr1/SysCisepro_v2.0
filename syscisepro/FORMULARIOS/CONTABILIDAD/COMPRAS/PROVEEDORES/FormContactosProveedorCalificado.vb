Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class FormContactosProveedorCalificado
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
         
        ReadOnly _objetocontactoProveedorCalificado As New ClassContactosProveedorCalificado

        Private Sub limpiarParametros()
            txtIdContactoProveedorCalificado.Text = ""
            txtNombresContactoProveedorCalificado.Text = ""
            txtApellidosContactoProveedorCalificado.Text = ""
            txtCargoContactoProveedorCalificado.Text = ""
            txtTelefonoContactoProveedorCalificado.Text = ""
            txtCelularContactoProveedorCalificado.Text = ""
            txtEmailContactoProveedorCalificado.Text = ""
        End Sub

        Private Sub deshabilitadoListo()
            txtIdContactoProveedorCalificado.Enabled = False
            txtNombresContactoProveedorCalificado.Enabled = False
            txtApellidosContactoProveedorCalificado.Enabled = False
            txtCargoContactoProveedorCalificado.Enabled = False
            txtTelefonoContactoProveedorCalificado.Enabled = False
            txtCelularContactoProveedorCalificado.Enabled = False
            txtEmailContactoProveedorCalificado.Enabled = False
        End Sub
        Private Sub FormContactosProveedorCalificado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            Try
                limpiarParametros()
                txtIdContactoProveedorCalificado.Enabled = False

                txtIdContactoProveedorCalificado.Text = _objetocontactoProveedorCalificado.BuscarMayorIdContactoProveedorCalificado(_tipoCon) + 1
            Catch ex As Exception
                MsgBox("NO SE PUEDE CARGAR." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
            End Try

        End Sub

        Private Sub btnListo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnListo.Click
            If txtIdContactoProveedorCalificado.Text <> "" And txtNombresContactoProveedorCalificado.Text <> "" And txtApellidosContactoProveedorCalificado.Text <> "" And txtCargoContactoProveedorCalificado.Text <> "" And txtTelefonoContactoProveedorCalificado.Text <> "" Then
                btnCancelar.Enabled = False
                btnListo.Enabled = False 
                deshabilitadoListo()
                DialogResult = DialogResult.OK
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
                txtNombresContactoProveedorCalificado.Focus()
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            limpiarParametros()
        End Sub
    End Class
End Namespace