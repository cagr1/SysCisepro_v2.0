Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.REQUISICIONES
    Public Class ClassRequisicionProductoServicio
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdRequisicionPs As Int64
        Public FechaRequisicionPs As DateTime
        Public IdPersonal As Integer
        Public PrioridadEntregaRequisicionPs As String
        Public TiempoEntregaRequisicionPs As String
        Public EstadoRequisicionPs As Integer


        Public Function SeleccionarRegistrosRequisicionProductoServicio(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosRequisicionProductoServicio", True)
        End Function

        Public Function SeleccionarRegistrosAprobadosRequisicionProductoServicio(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT R.ID_REQUISICION_PS ID, R.FECHA_REQUISICION_PS FECHA, P.NOMBRES + ' ' + P.APELLIDOS REQUIRIENTE, R.PRIORIDAD_ENTREGA_REQUISICION_PS PRIORIDAD FROM	REQUISICION_PRODUCTO_SERVICIO R JOIN PERSONAL P ON R.ID_PERSONAL = P.ID_PERSONAL WHERE R.ESTADO_REQUISICION_PS = 2;", False)
        End Function

        Public Function BuscarMayorIdRequisicionProductoServicio(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdRequisicionProductoServicio", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroRequisicionProductoServicio() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroRequisicionProductoServicio"
                .Parameters.AddWithValue("@ID_REQUISICION_PS", SqlDbType.Int).Value = IdRequisicionPs
                .Parameters.AddWithValue("@FECHA_REQUISICION_PS", SqlDbType.DateTime).Value = FechaRequisicionPs
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@PRIORIDAD_ENTREGA_REQUISICION_PS", SqlDbType.NVarChar).Value = PrioridadEntregaRequisicionPs
                .Parameters.AddWithValue("@TIEMPO_ENTREGA_REQUISICION_PS", SqlDbType.NVarChar).Value = TiempoEntregaRequisicionPs
                .Parameters.AddWithValue("@ESTADO_REQUISICION_PS", SqlDbType.Int).Value = EstadoRequisicionPs
            End With
            Return comando
        End Function
         
        Public Function ActualizarEstadoRequisicionProductoServicio() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoRequisicionProductoServicio"
                .Parameters.AddWithValue("@ID_REQUISICION_PS", SqlDbType.BigInt).Value = IdRequisicionPs
                .Parameters.AddWithValue("@ESTADO_REQUISICION_PS", SqlDbType.Int).Value = EstadoRequisicionPs
            End With
            Return comando
        End Function
        
    End Class
End Namespace

