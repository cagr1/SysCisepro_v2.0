Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteOrdenCompra
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

        Dim objetoOrdenCompra As New ClassOrdenCompra
        Dim crOrdenCompra As New CrystalReportOrdenCompra

        Public Sub conectarReporte()
            Try
                crOrdenCompra.SetDataSource(objetoOrdenCompra.SeleccionarRegistrosOrdenCompraReporte(_tipoCon, CInt(lblIdOrdenCompra.Text)))
                crOrdenCompra.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvOrdenCompra.ReportSource = crOrdenCompra
                crvOrdenCompra.Zoom(75)
                crvOrdenCompra.Refresh()
            Catch
                crvOrdenCompra.ReportSource = Nothing
            End Try 
        End Sub

        Private Sub FormReporteOrdenCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
            conectarReporte()
        End Sub
    End Class
End Namespace