Imports ClassLibraryCisepro.ENUMS

Public Class KryptonInputBoxForm

    Private _tipoCon As TipoConexion
    Property TipoCox As Integer
        Private Get
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
    Private Sub KryptonInputBoxForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _tipoCon
            Case TipoConexion.Asenava
                Icon = My.Resources.logo_a

            Case TipoConexion.Seportpac
                Icon = My.Resources.logo_s

            Case Else
                Icon = My.Resources.logo_c

        End Select


    End Sub
End Class