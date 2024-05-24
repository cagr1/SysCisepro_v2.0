Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
    Public Class ClassRotacionActivos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdRotacion As Integer
        Public IdActivoFijo As Integer
        Public Fecha As DateTime
        Public IdCustodioAnterior As Integer
        Public NombreCustodioAnterior As String
        Public IdCustodioNuevo As Integer
        Public NombreCustodioNuevo As String
        Public Observacion As String
        Public Estado As Integer 

        Public Function SeleccionarRotacionesVehiculos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRotacionesVehiculos", True) 
        End Function

        Public Function SeleccionarRotacionesVehiculosDiarias(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRotacionesVehiculosDiarias", True) 
        End Function

        Public Function NuevaRotacionVehiculos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevaRotacionVehiculos"
                .Parameters.AddWithValue("@ID_ROTACION", SqlDbType.Int).Value = IdRotacion
                .Parameters.AddWithValue("@ID_ACTIVO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ID_CUSTODIO_ANTERIOR", SqlDbType.Int).Value = IdCustodioAnterior
                .Parameters.AddWithValue("@ID_CUSTODIO_NUEVO", SqlDbType.Int).Value = IdCustodioNuevo
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO_ANTERIOR", SqlDbType.NVarChar).Value = NombreCustodioAnterior
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO_NUEVO", SqlDbType.NVarChar).Value = NombreCustodioNuevo
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
        
        Public Function BuscarMayorIdRotacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdRotacion", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarTodosLosRegistrosRotacionesPorFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosRotacionesPorFecha", True, pars) 
        End Function

    End Class
End Namespace

