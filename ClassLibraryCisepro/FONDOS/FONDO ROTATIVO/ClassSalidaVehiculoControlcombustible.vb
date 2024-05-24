Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql


Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassSalidaVehiculoControlCombustible
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSalidaVehiculo As Integer
        Public FechaSalidaVehiculo As Date
        Public HoraSalidaVehiculo As String
        Public KmSalidaVehiculo As Integer
        Public EstadoSalidaVehiculo As Integer 

        Public Function BuscarMayorIdSalidaVehiculos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSalidaVehiculos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarFechaSalidaVehiculoXIdSalidaVehiculo(ByVal tipoCon As TipoConexion, ByVal idLlegadaV As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SALIDA_V", SqlDbType.BigInt, idLlegadaV})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFechaSalidaVehiculoXIdSalidaVehiculo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarKmSalidaVehiculoXIdSalidaVehiculo(ByVal tipoCon As TipoConexion, ByVal idGastosSolicitud As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SALIDA_V", SqlDbType.Int, idGastosSolicitud})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarKMSalidaVehiculoXIdSalidaVehiculo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroSalidaVehiculosCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroSalidaVehiculos"
                .Parameters.AddWithValue("@ID_SALIDA_V", SqlDbType.Int).Value = IdSalidaVehiculo
                .Parameters.AddWithValue("@FECHA_SALIDA_V", SqlDbType.DateTime).Value = FechaSalidaVehiculo
                .Parameters.AddWithValue("@HORA_SALIDA_V", SqlDbType.NVarChar).Value = HoraSalidaVehiculo
                .Parameters.AddWithValue("@KM_SALIDA_V", SqlDbType.BigInt).Value = KmSalidaVehiculo
                .Parameters.AddWithValue("@ESTADO_SALIDA_V", SqlDbType.Int).Value = EstadoSalidaVehiculo
            End With

            Return comando
        End Function

    End Class
End Namespace