Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteEgresoBancos
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
        Public Tipo As Integer

        Dim objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        Dim objetoChequeEmitido As New ClassChequesEmitidosCxp

        Dim crComprobanteEgreso As New crComprobanteEgresoBancos
        Dim crComprobanteEgresoHorizontal As New crComprobanteEgresoBancosHorizontal

        Dim crChequeEmitido As New crChequesEmitidos
        Dim objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso

        Dim numeroRegistro As Int64 = 0
        Public Sub conectarReporteComprobanteEgreso()
            Try
                numeroRegistro = objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgreso.Text)

                If Tipo = 0 Then
                    crComprobanteEgreso.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                Else
                    crComprobanteEgresoHorizontal.SetDataSource(objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), numeroRegistro))
                End If

                crComprobanteEgreso.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvComprovanteEgresoBancos.ReportSource = crComprobanteEgreso
                crvComprovanteEgresoBancos.Zoom(75)
                crvComprovanteEgresoBancos.Refresh()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Public Sub conectarReporteChequeEmitido()
            Try
                crChequeEmitido.SetDataSource(objetoChequeEmitido.SeleccionarChequeEmitidoXIdComprobanteEgreso(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64)))
                crvChequeEmitido.ReportSource = crChequeEmitido
                crvChequeEmitido.Zoom(75)
                crvChequeEmitido.Refresh()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        Private Sub crvComprovanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles crvComprovanteEgresoBancos.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select

            conectarReporteComprobanteEgreso()
            conectarReporteChequeEmitido()
        End Sub

        Private Sub txtIdComprobanteEgreso_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIdComprobanteEgreso.KeyDown
            If e.KeyCode = Keys.Enter Then
                If txtIdComprobanteEgreso.Text <> "" Then
                    lblIdComprobanteEgreso.Text = txtIdComprobanteEgreso.Text
                    txtIdComprobanteEgreso.Enabled = False
                    conectarReporteComprobanteEgreso()
                    conectarReporteChequeEmitido()
                    txtIdComprobanteEgreso.Enabled = True
                End If
            End If
        End Sub

        Private Sub txtIdComprobamteEgreso2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdComprobamteEgreso2.KeyDown
            If e.KeyCode = Keys.Enter Then
                If txtIdComprobamteEgreso2.Text <> "" Then
                    lblIdComprobanteEgreso.Text = txtIdComprobamteEgreso2.Text
                    txtIdComprobamteEgreso2.Enabled = False
                    conectarReporteComprobanteEgreso()
                    conectarReporteChequeEmitido()
                    txtIdComprobamteEgreso2.Enabled = True
                End If
            End If
        End Sub

        Private Sub FormReporteComprobanteEgresoBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Private Sub crvChequeEmitido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvChequeEmitido.Load

        End Sub
    End Class
End Namespace