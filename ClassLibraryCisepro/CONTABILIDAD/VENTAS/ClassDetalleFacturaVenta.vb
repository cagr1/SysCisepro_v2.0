Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassDetalleFacturaVenta
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalleFactura As Int64
        Public IdSecuencialItem As Int64
        Public CantidadDetalleFactura As Integer
        Public ValorUDetalleFactura As Decimal
        Public ValorDDetalleFactura As Decimal
        Public ValorTDetalleFactura As Decimal
        Public EstadoDetalleFactura As Integer
        Public IdFactura As Int64

        Public Function SeleccionarDetalleFacturaVentaXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarDetalleFacturaVentaXIdFacturaVenta", True, pars)
        End Function
        Public Function SeleccionarDetalleFacturaDescripcionXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarDetalleFacturaDescripcionXIdFacturaVenta", True, pars)
        End Function

        Public Function BuscarMayorIdDetalleFacturaVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleFacturaVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDetalleFacturaVenta"
                .Parameters.AddWithValue("@ID_DETALLE_FACTURA_VENTA", SqlDbType.BigInt).Value = IdDetalleFactura
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = IdSecuencialItem
                .Parameters.AddWithValue("@CANTIDAD_DETALLE_FACTURA_VENTA", SqlDbType.Int).Value = CantidadDetalleFactura
                .Parameters.AddWithValue("@VALORU_DETALLE_FACTURA_VENTA", SqlDbType.NVarChar).Value = ValorUDetalleFactura  ' valor unitario
                .Parameters.AddWithValue("@VALORD_DETALLE_FACTURA_VENTA", SqlDbType.NVarChar).Value = ValorDDetalleFactura  ' valor descuento
                .Parameters.AddWithValue("@VALORT_DETALLE_FACTURA_VENTA", SqlDbType.NVarChar).Value = ValorTDetalleFactura  ' valor total
                .Parameters.AddWithValue("@ESTADO_DETALLE_FACTURA_VENTA", SqlDbType.Int).Value = EstadoDetalleFactura
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
            End With
            Return comando
        End Function
       
    End Class
End Namespace

