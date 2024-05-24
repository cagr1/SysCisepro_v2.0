Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteGastosFondoRotativo
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
        ReadOnly _crConceptosFondoRotativo As New crConceptosFondoRotativo
        ReadOnly _objetoConceptoFondoRotativo As New ClassGastosFondoRotativo
        Private Sub crvReporteConceptosFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvReporteConceptosFondoRotativo.Load
            Try
                _crConceptosFondoRotativo.SetDataSource(_objetoConceptoFondoRotativo.SeleccionarOrdenadosGastosFondoRotativo(_tipoCon))
                _crConceptosFondoRotativo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvReporteConceptosFondoRotativo.ReportSource = _crConceptosFondoRotativo 
                crvReporteConceptosFondoRotativo.Zoom(75)
                'Me.crvReporteConceptosFondoRotativo.Refresh()
            Catch
                crvReporteConceptosFondoRotativo.ReportSource = Nothing
            End Try
        End Sub

        Private Sub FormReporteGastosFondoRotativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
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
End Namespace