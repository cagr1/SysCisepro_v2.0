Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteMantenimientosActivosFijos
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
        Public LblId As String
        ReadOnly _crMantenimiento As New crMantenimientosProcesados
        ReadOnly _objetoActivoFijoMantenimiento As New ClassActivoFijoMantenimiento

        Private Sub ConectarReporte()
            _crMantenimiento.SetDataSource(_objetoActivoFijoMantenimiento.BuscarMantenimientoPorIdMantenimientoProcesados(_tipoCon, Convert.ToInt64(lblIdMantenimiento.Text)))
            _crMantenimiento.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvMantenimientoActivosFijos.ReportSource = _crMantenimiento
            crvMantenimientoActivosFijos.Zoom(75)
            crvMantenimientoActivosFijos.Refresh()
        End Sub
        Private Sub crvMantenimientoActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvMantenimientoActivosFijos.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            lblIdMantenimiento.Text = LblId
            conectarReporte()
        End Sub

        Private Sub FormReporteMantenimientosActivosFijos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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