Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
 
Namespace CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    Public Class ClassDetalleOrdenCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalleOrdenCompra As Int64
        Public IdSecuencialItem As Int64
        Public UmedidaDetalleOrdenCompra As String
        Public CantidadDetalleOrdenCompra As Integer
        Public ValorUDetalleOrdenCompra As String
        Public ValorTDetalleOrdenCompra As String
        Public EstadoDetalleOrdenCompra As Integer
        Public IdOrdenCompra As Int64
 
        Public Function SeleccionarDetalleOrdenCompraXIdOrden(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ORDEN_COMPRA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT d.ID_DETALLE_ORDEN_COMPRA, s.NOMBRE_SECUENCIAL_ITEM, d.UMEDIDA_DETALLE_ORDEN_COMPRA, d.CANTIDAD_DETALLE_ORDEN_COMPRA, d.VALORU_DETALLE_ORDEN_COMPRA, d.VALORT_DETALLE_ORDEN_COMPRA, d.ESTADO_DETALLE_ORDEN_COMPRA, d.ID_ORDEN_COMPRA, s.ID_SECUENCIAL_ITEM, k.ID_KARDEX, s.costo, s.serie, s.codigo_secuencial_item FROM DETALLE_ORDEN_COMPRA d	join SECUENCIAL_ITEM s on d.ID_SECUENCIAL_ITEM = s.ID_SECUENCIAL_ITEM	join kardex k on d.ID_SECUENCIAL_ITEM=k.ID_SECUENCIAL_ITEM WHERE	d.ID_ORDEN_COMPRA = @ID_ORDEN_COMPRA;", False, pars)
        End Function

        Public Function BuscarMayorIdDetalleROrdenCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleOrdenCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleOrdenCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroDetalleOrdenCompra"
                .Parameters.AddWithValue("@ID_DETALLE_ORDEN_COMPRA", SqlDbType.BigInt).Value = IdDetalleOrdenCompra
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = IdSecuencialItem
                .Parameters.AddWithValue("@UMEDIDA_DETALLE_ORDEN_COMPRA", SqlDbType.NVarChar).Value = UmedidaDetalleOrdenCompra
                .Parameters.AddWithValue("@CANTIDAD_DETALLE_ORDEN_COMPRA", SqlDbType.Int).Value = CantidadDetalleOrdenCompra
                .Parameters.AddWithValue("@VALORU_DETALLE_ORDEN_COMPRA", SqlDbType.Decimal).Value = ValorUDetalleOrdenCompra
                .Parameters.AddWithValue("@VALORT_DETALLE_ORDEN_COMPRA", SqlDbType.Decimal).Value = ValorTDetalleOrdenCompra
                .Parameters.AddWithValue("@ESTADO_DETALLE_ORDEN_COMPRA", SqlDbType.Int).Value = EstadoDetalleOrdenCompra
                .Parameters.AddWithValue("@ID_ORDEN_COMPRA", SqlDbType.BigInt).Value = IdOrdenCompra
            End With
            Return comando
        End Function

    End Class
End Namespace
