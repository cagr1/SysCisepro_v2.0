Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteTransferenciasActivosFijos
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

        Public IdTransferencia As String

        ReadOnly _crTransferencia As New crReporteTransferencias
        ReadOnly _objetoActivoFijoTransferencias As New ClassActivoFijoTransferencias

        Private Sub ConectarReporte()
            _crTransferencia.SetDataSource(_objetoActivoFijoTransferencias.BuscarTransferenciaPorIdTransferencia(_tipoCon, Convert.ToInt64(lblIdTransferencia.Text)))
            _crTransferencia.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvTransferenciaActivosFijos.ReportSource = _crTransferencia
            crvTransferenciaActivosFijos.Zoom(75)
            _crTransferencia.Refresh()
        End Sub
        Private Sub FormReporteTransferenciasActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            lblIdTransferencia.Text = IdTransferencia
            conectarReporte()
        End Sub

    End Class
End Namespace