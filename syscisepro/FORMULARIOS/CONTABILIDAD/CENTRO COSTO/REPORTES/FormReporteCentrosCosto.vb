Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.CENTRO_COSTO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteCentrosCosto
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
        ReadOnly _crCentrosCosto As New crCentrosCosto
        ReadOnly _objetoCentrosCosto As New ClassCentroCosto
        Private Sub FormReporteCentrosCosto_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
                _crCentrosCosto.SetDataSource(_objetoCentrosCosto.SeleccionarOrdenadosCentroCosto(_tipoCon))
                _crCentrosCosto.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvReporteCentrosCosto.ReportSource = _crCentrosCosto
                crvReporteCentrosCosto.Zoom(75)
                Me.crvReporteCentrosCosto.Refresh()
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace