Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteComprobanteCompra
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
        Public _porcentaje As String
        Dim objetoComprobanteCompra As New ClassComprobantesCompra
        Dim objetoNumeroRegistroComprobanteCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        Dim crComprobanteCompra As New CrComprobanteCompra

        Dim numeroRegistro As Int64 = 0

        Public Sub conectarReporteComprobanteCompra()
            
            numeroRegistro = objetoNumeroRegistroComprobanteCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)

            Dim iva5 As DataTable = objetoComprobanteCompra.IvaComprobanteTabla(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))

            Dim subtotal5Value As String = "0"
            Dim iva5Value As String = "0"
            If iva5.Rows.Count > 0 Then

                subtotal5Value = If(iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA").ToString(), "0")
                iva5Value = If(iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA").ToString(), "0")
            End If

            crComprobanteCompra.SetDataSource(objetoComprobanteCompra.BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64), numeroRegistro))
            crComprobanteCompra.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crComprobanteCompra.SetParameterValue("porcentaje", _porcentaje)
            crComprobanteCompra.SetParameterValue("subtotal5", subtotal5Value)
            crComprobanteCompra.SetParameterValue("iva5", iva5Value)
            crvComprobanteCompra.ReportSource = crComprobanteCompra
            crvComprobanteCompra.Zoom(75)
            crvComprobanteCompra.Refresh() 
        End Sub
         
        Private Sub FormReporteComprobanteCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            conectarReporteComprobanteCompra()
        End Sub
    End Class
End Namespace