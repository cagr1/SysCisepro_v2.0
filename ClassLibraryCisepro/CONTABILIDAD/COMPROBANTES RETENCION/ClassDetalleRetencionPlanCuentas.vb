Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports System.Data.SqlClient

Namespace CONTABILIDAD.COMPROBANTES_RETENCION
    Public Class ClassDetalleRetencionPlanCuentas
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        ''' 
        Public IdDetalleRetencionPlanCuenta As Int64
        Public IdFacturaVenta As Int64
        Public IdComprobanteCompra As Int64
        Public IdDetalleComprobanteRetencionVenta As Int64
        Public IdDetalleComprobanteRetencionCompra As Int64
        Public Codigo As String
        Public Cuenta As String

        Public Function BuscarMayorIdRegistroDetalleRetencionPlanCuenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_DETALLE=CASE WHEN MAX(ID_DETALLE) IS NULL THEN 0 ELSE MAX(ID_DETALLE) End FROM DETALLE_RETENCION_PLAN_CUENTAS", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_DETALLE")))
        End Function

        Public Function NuevoRegistroDetalleRetencionPlanCuenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DETALLE_RETENCION_PLAN_CUENTAS values (@ID_DETALLE, @ID_FACTURA_VENTA, @ID_COMPROBANTE_COMPRA, @ID_DETALLE_COMPROBANTE_RETENCION_VENTA, @ID_DETALLE_COMPROBANTE_RETENCION_COMPRA, @CODIGO, @CUENTA)"
                .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = IdDetalleRetencionPlanCuenta
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.Int).Value = IdFacturaVenta
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.Int).Value = IdComprobanteCompra
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = IdDetalleComprobanteRetencionVenta
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = IdDetalleComprobanteRetencionCompra
                .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@CUENTA", SqlDbType.NVarChar).Value = Cuenta
            End With
            Return comando
        End Function
    End Class
End Namespace