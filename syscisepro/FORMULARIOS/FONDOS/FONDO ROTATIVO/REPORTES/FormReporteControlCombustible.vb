Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteControlCombustible
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
        ReadOnly _objetoControlcombustible As New ClassControlCombustible
        ReadOnly _crControlcombustible As New crControlCombustible

        Private Sub ConectarReporte()
            _crControlcombustible.SetDataSource(_objetoControlcombustible.SeleccionarRegistrosControlCombustibleReporte(_tipoCon, CInt(lblIdControlCombustible.Text))) ', CType(lblIdActivoFijo.Text, Integer)))
            _crControlcombustible.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvControlCombustible.ReportSource = _crControlcombustible
            crvControlCombustible.Zoom(75)
            'crvControlCombustible.Refresh()
        End Sub
        Private Sub crvControlCombustible_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvControlCombustible.Load
            conectarReporte()
        End Sub

        Private Sub FormReporteControlCombustible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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