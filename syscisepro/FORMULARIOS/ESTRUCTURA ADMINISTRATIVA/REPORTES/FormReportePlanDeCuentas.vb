Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReportePlanDeCuentas
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

        ReadOnly _crObjetoPlanDeCuentas As New crPlanDeCuentas
        ReadOnly _objetoPlanDeCuentas As New ClassPlanDeCuentas

        Private Sub crvPlanDeCuentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvPlanDeCuentas.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
            Try
                _crObjetoPlanDeCuentas.SetDataSource(_objetoPlanDeCuentas.SeleccionarTodosLosRegistrosPlanDeCuentasOrdenados(_tipoCon))
                _crObjetoPlanDeCuentas.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvPlanDeCuentas.ReportSource = _crObjetoPlanDeCuentas
                crvPlanDeCuentas.Refresh()
                crvPlanDeCuentas.Zoom(75)
            Catch
                crvPlanDeCuentas.ReportSource = Nothing
            End Try
        End Sub

        Private Sub FormReportePlanDeCuentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
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