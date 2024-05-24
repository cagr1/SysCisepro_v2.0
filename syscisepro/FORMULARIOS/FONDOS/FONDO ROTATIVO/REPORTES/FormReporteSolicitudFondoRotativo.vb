Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteSolicitudFondoRotativo
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

        ReadOnly _crObjetoSolicitudFondoRotativo As New crSolicitudFondoRotaivo
        ReadOnly _objetoSolicitudFondoRotativo As New ClassSolicitudFondoRotativo

        Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnVolver.Click
            Try
                _crObjetoSolicitudFondoRotativo.SetDataSource(_objetoSolicitudFondoRotativo.SeleccionarTodosRegistrosSolicitudFondoRotativoParaReporte(_tipoCon))
                _crObjetoSolicitudFondoRotativo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvSolicitudFondoRotativo.ReportSource = _crObjetoSolicitudFondoRotativo
                crvSolicitudFondoRotativo.Zoom(2)
            Catch
                crvSolicitudFondoRotativo.ReportSource = Nothing
            End Try
            
        End Sub

        Private Sub FormReporteSolicitudFondoRotativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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