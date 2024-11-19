Imports ClassLibraryCisepro.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES

Namespace FORMULARIOS.CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormDocumentosNoDeducibles
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

        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objNoDeducible As New ClassDocumentoNoDeducible
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _validacionesNumerico As New ClassNumerico

        Public ValorMaximo As Double
        Private _existeNumero As Boolean

        Private Function ValidacionParametros() As Boolean
            Return lblCodigoCuentaConcepto.Text <> "..." And txtNumeroDocumentoNoDeducible.Text <> "" And txtDescripcionDocumentoNoDeducible.Text <> "" And txtValorDocumentoNoDeducible.Text <> ""
        End Function

        Private Sub txtValorDocumentoNoDeducible_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorDocumentoNoDeducible.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar, txtValorDocumentoNoDeducible.Text)
        End Sub

        Private Sub btnNuevoSolicitudFR_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnListo.Click
            If ValidacionParametros() = True Then 'VALIDACION
                If CDbl(txtValorDocumentoNoDeducible.Text) > ValorMaximo Then
                    MsgBox("No se permite procesar un valor mayor monto disponible para caja ($" & ValorMaximo.ToString("N") & ")!", MsgBoxStyle.Information, "Mensaje de información")
                    Return
                End If

                If _existeNumero Then
                    MsgBox("El N° del comprobante ya ha sido registrado!", MsgBoxStyle.Information, "Mensaje de información")
                    Return
                End If
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                txtNumeroDocumentoNoDeducible.Focus()
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub txtValorDocumentoNoDeducible_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtValorDocumentoNoDeducible.KeyUp
            If txtValorDocumentoNoDeducible.Text.Trim().Length = 0 Then Return
            Try
                txtValorDocumentoNoDeducible.ForeColor = If(CDbl(txtValorDocumentoNoDeducible.Text) > ValorMaximo, Color.Red, Color.Black)
            Catch ex As Exception
                txtValorDocumentoNoDeducible.ForeColor = Color.Red
            End Try
        End Sub

        Private Sub txtNumeroDocumentoNoDeducible_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNumeroDocumentoNoDeducible.KeyPress
            e.Handled = Not _validacionesNumerico.EsNumero(e.KeyChar)
        End Sub

        Private Sub FormDocumentosNoDeducibles_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select

            AutocompletarPlanCuentas()
        End Sub

        Private Sub AutocompletarPlanCuentas()
            Try
                TextBox1.AutoCompleteCustomSource = _objetoPlanCuentas.Autocompletar(_tipoCon)
                TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                TextBox1.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
            If e.KeyValue <> 13 Then Return
            Try
                lblCodigoCuentaConcepto.Text = TextBox1.Text.Split("-")(0).Trim()
            Catch
                lblCodigoCuentaConcepto.Text = "..."
            End Try
        End Sub

        Private Sub txtNumeroDocumentoNoDeducible_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroDocumentoNoDeducible.KeyUp
            If txtNumeroDocumentoNoDeducible.Text.Trim.Length = 0 Then
                txtNumeroDocumentoNoDeducible.ForeColor = Color.Black
                Return
            End If
            Try
                _existeNumero = _objNoDeducible.ExisteNumDocumentoNoDeducible(_tipoCon, txtNumeroDocumentoNoDeducible.Text.Trim)
                If _existeNumero Then
                    txtNumeroDocumentoNoDeducible.ForeColor = Color.Red
                Else
                    txtNumeroDocumentoNoDeducible.ForeColor = Color.Black
                End If
            Catch
                txtNumeroDocumentoNoDeducible.ForeColor = Color.Red
            End Try
        End Sub
    End Class
End Namespace