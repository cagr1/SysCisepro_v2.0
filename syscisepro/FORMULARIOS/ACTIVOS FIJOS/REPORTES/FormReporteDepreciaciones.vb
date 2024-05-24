Imports ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteDepreciaciones
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
        Public Id As String
        ReadOnly _crDepreciaciones As New crDepreciaciones 

        ReadOnly _objDepreciacion As New ClassDepreciaciones

        Private Sub ConectarReporte()
            _crDepreciaciones.SetDataSource(_objDepreciacion.BuscarDepreciacionPorIdActivo(_tipoCon, CType(lblIdDepreciacion.Text, Integer)))
            _crDepreciaciones.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDepreciaciones.ReportSource = _crDepreciaciones
            crvDepreciaciones.Zoom(75)
            crvDepreciaciones.Refresh()
        End Sub
        Private Sub crvDepreciaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvDepreciaciones.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            lblIdDepreciacion.Text = Id
            ConectarReporte()
        End Sub

        Private Sub FormReporteDepreciaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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