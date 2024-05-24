Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteBajas
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
        ReadOnly _crBajaCisepro As New crBajas

        ReadOnly _objetoActivoFijoBaja As New ClassActivoFijoBajas

        Private Sub FormReporteBajas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select

            lblIdBaja.Text = Id
            ConectarReporte()
        End Sub

        Private Sub ConectarReporte()
            _crBajaCisepro.SetDataSource(_objetoActivoFijoBaja.BuscarBajaPorIdBaja(_tipoCon, CType(lblIdBaja.Text, Integer)))
            _crBajaCisepro.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvBajas.ReportSource = _crBajaCisepro
            crvBajas.Zoom(75)
            crvBajas.Refresh()
        End Sub
    End Class
End Namespace