Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES

    Public Class FormReporteLibroDiario
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
        Dim objetoLibroDiario As New ClassLibroDiario
        Dim crLibroDiario As New crLibroDiario
        Public Sub conectarReporte()
            Try
                crLibroDiario.SetDataSource(objetoLibroDiario.SeleccionarLibroDiarioXIdLibroDiario(_tipoCon, CType(lblIdLibroDiario.Text, Int64)))
                crvReporteLibroDiario.ReportSource = crLibroDiario
                crvReporteLibroDiario.Zoom(75)
                crvReporteLibroDiario.Refresh()
            Catch ex As Exception
            End Try
        End Sub
        Private Sub crvReporteLibroDiario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvReporteLibroDiario.Load
            conectarReporte()
        End Sub

        Private Sub FormReporteLibroDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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