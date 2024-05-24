Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteEvaluacionProveedores
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


        Dim objetoEvaluacionMateriales As New ClassEvaluacionProveedorMateriales
        Dim objetoEvaluacionServicios As New ClassEvaluacionProveedoreServicios
        Dim crEvalaucionMateriales As New CrystalReportEvaluacionProveedorMateriales
        Dim crEvaluacionServicios As New CrystalReportEvaluacionProveedorServicios

        Public Sub conectarReporte()
            If lblTipoProveedor.Text = "MATERIALES" Then
                crEvalaucionMateriales.SetDataSource(objetoEvaluacionMateriales.BuscarEvaluacionProveedorXIdEvaluacion(_tipoCon, CType(lblIdEvaluacionProveedor.Text, Integer)))
                crEvalaucionMateriales.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvEvaluacionProveedor.ReportSource = crEvalaucionMateriales
            ElseIf lblTipoProveedor.Text = "SERVICIOS" Then
                crEvaluacionServicios.SetDataSource(objetoEvaluacionServicios.BuscarEvaluacionProveedorXIdEvaluacion(_tipoCon, CType(lblIdEvaluacionProveedor.Text, Integer)))
                crEvalaucionMateriales.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvEvaluacionProveedor.ReportSource = crEvaluacionServicios
            End If

            crvEvaluacionProveedor.Zoom(75)
            crvEvaluacionProveedor.Refresh()
        End Sub

        Private Sub FormReporteEvaluacionProveedores_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
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