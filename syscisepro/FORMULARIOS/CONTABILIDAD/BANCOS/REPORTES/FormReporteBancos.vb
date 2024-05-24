
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteBancos
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
        Dim crBancos As New crBancos
        Dim objetoBancos As New ClassBancos
        Private Sub crvBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvBancos.Load
            Try
                crBancos.SetDataSource(objetoBancos.SeleccionarOrdenadosRegistrosBancos(_tipoCon))
                crBancos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvBancos.ReportSource = crBancos
                crvBancos.Zoom(75)
                Me.crvBancos.Refresh()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub FormReporteBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    Icon = My.Resources.logo_c
            End Select
        End Sub
    End Class
End Namespace