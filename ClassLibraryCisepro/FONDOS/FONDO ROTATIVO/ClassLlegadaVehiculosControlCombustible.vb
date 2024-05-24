Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassLlegadaVehiculosControlCombustible
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdLlegadaVehiculo As Integer
        Public FechaLlegadaVehiculo As Date
        Public HoraLlegadaVehiculo As String
        Public KmLlegadaVehiculo As Integer
        Public EstadoLlegadaVehiculo As Integer 

        Public Function BuscarMayorIdLlegadaVehiculos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdLlegadaVehiculos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarFechaLlegadaVehiculoXIdLlegadaVehiculo(ByVal tipoCon As TipoConexion, ByVal idLlegadaV As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LLEGADA_V", SqlDbType.BigInt, idLlegadaV})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFechaLlegadaVehiculoXIdLlegadaVehiculo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarKmLlegadaVehiculoXIdLlegadaVehiculo(ByVal tipoCon As TipoConexion, ByVal idLlegadaV As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LLEGADA_V", SqlDbType.NVarChar, idLlegadaV})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarKMLlegadaVehiculoXIdLlegadaVehiculo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroLlegadaVehiculosCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroLlegadaVehiculos"
                .Parameters.AddWithValue("@ID_LLEGADA_V", SqlDbType.Int).Value = IdLlegadaVehiculo
                .Parameters.AddWithValue("@FECHA_LLEGADA_V", SqlDbType.DateTime).Value = FechaLlegadaVehiculo
                .Parameters.AddWithValue("@HORA_LLEGADA_V", SqlDbType.NVarChar).Value = HoraLlegadaVehiculo
                .Parameters.AddWithValue("@KM_LLEGADA_V", SqlDbType.BigInt).Value = KmLlegadaVehiculo
                .Parameters.AddWithValue("@ESTADO_LLEGADA_V", SqlDbType.Int).Value = EstadoLlegadaVehiculo
            End With
            Return comando
        End Function

    End Class
End Namespace

