Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.REQUISICIONES
    Public Class ClassDetalleRequisicionProductoServicio
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalleRequisicioPs As Int64
        Public IdSecuencialItem As Int64
        Public UmedidaDetalleRequisicioPs As String
        Public CantidadDetalleRequisicioPs As Integer
        Public EspecificacionesDetalleRequisicioPs As String
        Public ObservaionesDetalleRequisicioPs As String
        Public EstadoDetalleRequisicioPs As Integer
        Public IdRequisicioPs As Int64

        Public Function SeleccionarDetalleRequisicionProductoServicioXIdRequisicion(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_REQUISICION_PS", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT d.ID_DETALLE_REQUISICION_PS, s.NOMBRE_SECUENCIAL_ITEM, d.UMEDIDA_DETALLE_REQUISICION_PS, d.CANTIDAD_DETALLE_REQUISICION_PS, d.ESPECIFICACION_DETALLE_REQUISICION_PS, d.OBSERVACIONES_DETALLE_REQUISICION_PS, d.ESTADO_DETALLE_REQUISICION_PS, d.ID_REQUISICION_PS, s.ID_SECUENCIAL_ITEM FROM	DETALLE_REQUISICION_PRODUCTO_SERVICIO d	join SECUENCIAL_ITEM s on d.ID_SECUENCIAL_ITEM = s.ID_SECUENCIAL_ITEM	WHERE	d.ID_REQUISICION_PS = @ID_REQUISICION_PS;", False, pars)
        End Function

        Public Function BuscarMayorIdDetalleRequisicionProductoServicio(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleRequisicionProductoServicio", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleRequisicionProductoServicio() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroDetalleRequisicionProductoServicio"
                .Parameters.AddWithValue("@ID_DETALLE_REQUISICION_PS", SqlDbType.BigInt).Value = IdDetalleRequisicioPs
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.Int).Value = IdSecuencialItem
                .Parameters.AddWithValue("@UMEDIDA_DETALLE_REQUISICION_PS", SqlDbType.NVarChar).Value = UmedidaDetalleRequisicioPs
                .Parameters.AddWithValue("@CANTIDAD_DETALLE_REQUISICION_PS", SqlDbType.Int).Value = CantidadDetalleRequisicioPs
                .Parameters.AddWithValue("@ESPECIFICACION_DETALLE_REQUISICION_PS", SqlDbType.NVarChar).Value = EspecificacionesDetalleRequisicioPs
                .Parameters.AddWithValue("@OBSERVACIONES_DETALLE_REQUISICION_PS", SqlDbType.NVarChar).Value = ObservaionesDetalleRequisicioPs
                .Parameters.AddWithValue("@ESTADO_DETALLE_REQUISICION_PS", SqlDbType.Int).Value = EstadoDetalleRequisicioPs
                .Parameters.AddWithValue("@ID_REQUISICION_PS", SqlDbType.BigInt).Value = IdRequisicioPs
            End With
            Return comando
        End Function
       
        Public Function ModificarDetalleRequisicionProductoServicio() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarDetalleRequisicionProductoServicio"
                .Parameters.AddWithValue("@ID_DETALLE_REQUISICION_PS", SqlDbType.BigInt).Value = IdDetalleRequisicioPs
                .Parameters.AddWithValue("@CANTIDAD_DETALLE_REQUISICION_PS", SqlDbType.Int).Value = CantidadDetalleRequisicioPs
                .Parameters.AddWithValue("@ESTADO_DETALLE_REQUISICION_PS", SqlDbType.Int).Value = EstadoDetalleRequisicioPs
            End With
            Return comando
        End Function
       
    End Class
End Namespace

