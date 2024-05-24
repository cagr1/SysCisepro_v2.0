Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteLiquidacionFondoRotativo
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

        Public IdFondo As Integer
        Public Fecha As DateTime
        Public Fondo As Decimal
        Public Saldo As Decimal
        Public Reposicion As Decimal
        Public Total As Decimal
         
        ReadOnly _crLiquidacionFondoRotativo As New crLiquidacionFondoRotativo
        ReadOnly _objetoLiquidacionFondoRotativo As New ClassLiquidacionFondoRotativo
         
        Private Sub FormReporteLiquidacionFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            lblIdLiquidacionFondoRotativo.Text = IdFondo
            Reporte()
        End Sub

        Private Sub Reporte()
            Try                
                _crLiquidacionFondoRotativo.SetDataSource(_objetoLiquidacionFondoRotativo.ReporteFondoRotativoPorIdLiquidacion(_tipoCon, IdFondo))
                _crLiquidacionFondoRotativo.SetParameterValue("idliquidacion", IdFondo)
                _crLiquidacionFondoRotativo.SetParameterValue("fecha", Fecha.ToLongDateString())
                _crLiquidacionFondoRotativo.SetParameterValue("fondo", Fondo.ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("saldo", Saldo.ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("reposicion", Reposicion.ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("total", Total.ToString("N"))
                _crLiquidacionFondoRotativo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvReporteLiquidacion.ReportSource = _crLiquidacionFondoRotativo
                crvReporteLiquidacion.Zoom(2)    
            Catch
                crvReporteLiquidacion.ReportSource = Nothing
            End Try
        End Sub

    End Class
End Namespace