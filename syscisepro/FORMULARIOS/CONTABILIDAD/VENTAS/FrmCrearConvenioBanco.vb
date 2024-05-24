Imports ClassLibraryCisepro.VALIDACIONES

Namespace FORMULARIOS.CONTABILIDAD.VENTAS

    Public Class FrmCrearConvenioBanco 
        
        Public IdConvenio As Integer
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _validacionesNumeros As New ClassNumerico

        Public Sub Cero()
            cbxBanco.SelectedIndex = 0
            cbxTipoCuenta.SelectedIndex = 0
            cbxTipoDoc.SelectedIndex = 0
            txtNumCtaTarj.Clear()
            txtTitular.Clear()
            txtCedRucTitular.Clear()
            txtValor.Clear()
        End Sub

        Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub

        Private Sub txtNumCtaTarj_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNumCtaTarj.KeyPress, txtCedRucTitular.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
    End Class
End Namespace