
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.REPORTES
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteCodigosActivos

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

        ReadOnly _crCodigo As New crCodigosActivosFijos
        ReadOnly _reporteCodigo As New ClassReporteCodigoActivos
        '==============================================================================================================================================================================
        Private Sub crvCodigos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvCodigos.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
            ConectarReporte()
        End Sub
        '==============================================================================================================================================================================
        Private Sub ConectarReporte()

            _crCodigo.SetDataSource(_reporteCodigo.CodigosActivos(_tipoCon))
            _crCodigo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvCodigos.ReportSource = _crCodigo
            crvCodigos.Zoom(75)
            crvCodigos.Refresh()
            'crvCodigos.RefreshReport()
        End Sub

        Private Sub FormReporteCodigosActivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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