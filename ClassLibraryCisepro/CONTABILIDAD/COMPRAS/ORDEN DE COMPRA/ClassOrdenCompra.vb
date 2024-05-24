Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    Public Class ClassOrdenCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdOrdenCompra As Int64
        Public FechaOrdenCompra As DateTime
        Public IdProveedor As Integer
        Public FormaPagoOrdenCompra As String
        Public TipoPagoOrdenCompra As String
        Public ObservacionesOrdenCompra As String
        Public SubTotal12OrdenCompra As Decimal
        Public SubTotal0OrdenCompra As Decimal
        Public DescuentoOrdenCompra As Decimal
        Public IvaOrdenCompra As Decimal
        Public TotalOrdenCompra As Decimal
        Public EstadoOrdenCompra As Integer
        Public IdRequisicion As String

        Public Function SeleccionarRegistrosOrdenCompraAprobacion(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosOrdenCompraAprobacion", True)
        End Function

        Public Function SeleccionarRegistrosOrdenCompraReporte(ByVal tipoCon As TipoConexion, ByVal idOrdenC As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ORDEN_COMPRA", SqlDbType.BigInt, idOrdenC})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarRegistrosOrdenCompraXIdOrdenCompraReporte", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_ORDEN_COMPRA WHERE ESTADO_DETALLE_ORDEN_COMPRA = 1", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM WHERE ESTADO_SECUENCIAL_ITEM = 1", False)

            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVEEDOR_GENERAL", False)

            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES = 1", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "ORDEN_COMPRA")
            empr.Fill(ds, "DETALLE_ORDEN_COMPRA")
            sucu.Fill(ds, "SECUENCIAL_ITEM")
            area.Fill(ds, "PROVEEDOR_GENERAL")
            gere.Fill(ds, "CIUDADES")
            Return ds
        End Function

        Public Function BuscarMayorIdOrdenCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdOrdenCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarDetalleRequisicionProductoServicioXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarDetalleRequisicionProductoServicioXIdProveedor", True, pars)
        End Function

        Public Function NuevoRegistroOrdenCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroOrdenCompra"
                .Parameters.AddWithValue("@ID_ORDEN_COMPRA", SqlDbType.Int).Value = IdOrdenCompra
                .Parameters.AddWithValue("@FECHA_ORDEN_COMPRA", SqlDbType.DateTime).Value = FechaOrdenCompra
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@FORMA_PAGO_ORDEN_COMPRA", SqlDbType.NVarChar).Value = FormaPagoOrdenCompra
                .Parameters.AddWithValue("@TIPO_PAGO_ORDEN_COMPRA", SqlDbType.NVarChar).Value = TipoPagoOrdenCompra
                .Parameters.AddWithValue("@OBSERVACIONES_ORDEN_COMPRA", SqlDbType.NVarChar).Value = ObservacionesOrdenCompra
                .Parameters.AddWithValue("@SUBTOTAL_12_ORDEN_COMPRA", SqlDbType.Decimal).Value = SubTotal12OrdenCompra
                .Parameters.AddWithValue("@SUBTOTAL_0_ORDEN_COMPRA", SqlDbType.Decimal).Value = SubTotal0OrdenCompra
                .Parameters.AddWithValue("@DESCUENTO_ORDEN_COMPRA", SqlDbType.Decimal).Value = DescuentoOrdenCompra
                .Parameters.AddWithValue("@IVA_ORDEN_COMPRA", SqlDbType.Decimal).Value = IvaOrdenCompra
                .Parameters.AddWithValue("@TOTAL_ORDEN_COMPRA", SqlDbType.Decimal).Value = TotalOrdenCompra
                .Parameters.AddWithValue("@ESTADO_ORDEN_COMPRA", SqlDbType.Int).Value = EstadoOrdenCompra
                .Parameters.AddWithValue("@ID_REQUISICION", SqlDbType.Int).Value = IdRequisicion
            End With
            Return comando
        End Function

    End Class
End Namespace
