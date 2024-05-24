Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    Public Class FrmSeleccionarDebito

        Public Boton As Int32

        Public Sub New(ByVal cliente As String, ByVal factura As Decimal, ByVal saldo As Decimal, ByVal convenio As Decimal)
            InitializeComponent()

            Boton = 0
            Label2.Text = cliente

            Button1.Text = "FACTURA: " & factura
            Button1.Tag = factura

            Button2.Text = "SALDO: " & saldo
            Button2.Tag = saldo

            Button3.Text = "CONVENIO: " & convenio
            Button3.Tag = convenio
        End Sub
         
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            Boton = 1
            DialogResult = DialogResult.OK
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            Boton = 2
            DialogResult = DialogResult.OK
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
            Boton = 3
            DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace