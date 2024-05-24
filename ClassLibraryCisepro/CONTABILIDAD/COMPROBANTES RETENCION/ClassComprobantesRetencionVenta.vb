Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPROBANTES_RETENCION
    Public Class ClassComprobantesRetencionCompraVenta
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobanteRetencion As Int64
        Public IdCliente As Integer
        Public NumeroComprobanteRetencion As String
        Public NumAutoSriComprobanteRetencion As String
        Public FechaEmisionComprobanteRetencion As DateTime
        Public TipoCompVentaComprobanteRetencion As String
        Public NumCompVentaComprobanteRetencion As String
        Public TotalComprobanteRetencion As Decimal
        Public EstadoComprobanteRetencion As Integer
        Public IdFacturaVenta As Int64

        Public Function SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesRetencionVentaXIdFacturaVenta", True, pars)
        End Function

        Public Function BuscarMayorIdComprobanteRetencionVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteRetencionVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarTotalComprobanteRetencionVentaXIdFactura(ByVal tipoCon As TipoConexion, ByVal cod As Integer) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.BigInt, cod})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarTotalComprobanteRetencionVentaXIdFactura", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdCliente
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumeroComprobanteRetencion
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_RETENCION_VENTA", SqlDbType.DateTime).Value = FechaEmisionComprobanteRetencion
                .Parameters.AddWithValue("@TIPO_COMP_VENTA_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = TipoCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@NUM_COMP_VENTA_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = TotalComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoComprobanteRetencion
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFacturaVenta
            End With
            Return comando
        End Function

        Public Function ModificarRegistroComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdCliente
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumeroComprobanteRetencion
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_RETENCION_VENTA", SqlDbType.DateTime).Value = FechaEmisionComprobanteRetencion
                .Parameters.AddWithValue("@TIPO_COMP_VENTA_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = TipoCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@NUM_COMP_VENTA_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = NumCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = TotalComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoComprobanteRetencion
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFacturaVenta
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdFacturaVenta
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function AnularComprobanteRetencionVentaByIdFactura() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update COMPROBANTE_RETENCION_VENTA set ESTADO_COMPROBANTE_RETENCION_VENTA = 0 where ID_FACTURA_VENTA=@ID_FACTURA_VENTA;"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFacturaVenta
            End With
            Return comando
        End Function
       
    End Class
End Namespace

