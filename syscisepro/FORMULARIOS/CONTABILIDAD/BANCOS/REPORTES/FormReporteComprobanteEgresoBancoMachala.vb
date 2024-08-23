Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteEgresoBancoMachala
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

        ReadOnly _objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco

        ReadOnly _crComprobanteEgreso As New crComprobanteEgresoBancoMachala2

        ReadOnly _objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso

        Dim _numeroRegistro As Int64 = 0

        Private Sub ConectarReporteComprobanteEgreso()
            Try
                _numeroRegistro = _objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgreso.Text)

                _crComprobanteEgreso.SetDataSource(_objetoComprobanteEgresoBancos.BuscarReporteComprobantesEgresoBancoMachalaXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteEgreso.Text, Int64), _numeroRegistro))
                crvComprobanteEgresoBancoMachala.ReportSource = _crComprobanteEgreso
                crvComprobanteEgresoBancoMachala.Zoom(75)
                crvComprobanteEgresoBancoMachala.Refresh()
            Catch ex As Exception
            End Try
        End Sub
        Private Sub FormReporteComprobanteEgresoBancoMachala_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
            conectarReporteComprobanteEgreso()
        End Sub

        Private Sub txtIdComprobanteEgreso_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtIdComprobanteEgreso.KeyDown
            If e.KeyCode = Keys.Enter Then
                If txtIdComprobanteEgreso.Text <> "" Then
                    lblIdComprobanteEgreso.Text = txtIdComprobanteEgreso.Text
                    txtIdComprobanteEgreso.Enabled = False
                    ConectarReporteComprobanteEgreso()
                    txtIdComprobanteEgreso.Enabled = True
                End If
            End If
        End Sub

        Private Sub txtIdComprobanteEgreso_TextChanged(sender As Object, e As EventArgs) Handles txtIdComprobanteEgreso.TextChanged

        End Sub
    End Class
End Namespace