Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteIngresoBancos
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
        Dim objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        Public Tipo As Integer
        Dim crComprobanteIngreso As New crComprobanteIngresoBancos
        Dim crComprobanteIngresoGrande As New crComprobanteIngresoBancosGrande

        Dim objetoNumeroRegistroAsientoCompIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso

        Dim numeroRegistro As Int64 = 0

        Public Sub conectarReporteComprobanteIngreso()
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
                numeroRegistro = objetoNumeroRegistroAsientoCompIngreso.BuscarNumeroRegistroAsientoPorIdComprobanteIngreso(_tipoCon, lblIdComprobanteIngreso.Text)

                If Tipo = 0 Then
                    crComprobanteIngreso.SetDataSource(objetoComprobanteIngresoBancos.BuscarReporteComprobantesIngresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CInt(lblIdComprobanteIngreso.Text), numeroRegistro))
                    crComprobanteIngreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    crvComprobanteIngresoBancos.ReportSource = crComprobanteIngreso
                Else
                    crComprobanteIngresoGrande.SetDataSource(objetoComprobanteIngresoBancos.BuscarReporteComprobantesIngresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CInt(lblIdComprobanteIngreso.Text), numeroRegistro))
                    crComprobanteIngresoGrande.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    crvComprobanteIngresoBancos.ReportSource = crComprobanteIngresoGrande
                End If
                  
                crvComprobanteIngresoBancos.Zoom(75)
                crvComprobanteIngresoBancos.Refresh()
            Catch ex As Exception
            End Try
        End Sub
        Private Sub FormReporteComprobanteIngresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            conectarReporteComprobanteIngreso()
        End Sub
    End Class
End Namespace