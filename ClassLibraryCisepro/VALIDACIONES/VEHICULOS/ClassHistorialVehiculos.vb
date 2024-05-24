Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace VALIDACIONES.VEHICULOS
    Public Class ClassHistorialVehiculos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivoFijo As Integer
        Public NroHistorial As Integer
        Public Fecha As DateTime
        Public Soat As DateTime
        Public Aseguradora As String
        Public Seguro As String
        Public Broker As String
        Public NroPoliza As String
        Public CostoPrima As Decimal
        Public DispositivoSeguridad As String
        Public FechaInicioContrato As DateTime
        Public FechaFinalContrato As DateTime
        Public FechaRenovacionContrato As DateTime
        Public FechaInicioDispositivo As DateTime
        Public FechaFinalDispositivo As DateTime
        Public FechaRenovacionDispositivo As DateTime

        Public Function BuscarNroHistorialPorIActivo(ByVal tipoCon As TipoConexion, ByVal idActivoFijo As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.Int, idActivoFijo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNroHistorialPorIActivo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoHistorialVehiculos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoHistorialVehiculos"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@NRO_HISTORIAL", SqlDbType.NVarChar).Value = NroHistorial
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@SOAT ", SqlDbType.DateTime).Value = Soat
                .Parameters.AddWithValue("@ASEGURADORA", SqlDbType.NVarChar).Value = Aseguradora
                .Parameters.AddWithValue("@SEGURO", SqlDbType.NVarChar).Value = Seguro
                .Parameters.AddWithValue("@BROKER ", SqlDbType.NVarChar).Value = Broker
                .Parameters.AddWithValue("@NRO_POLIZA", SqlDbType.NVarChar).Value = NroPoliza
                .Parameters.AddWithValue("@COSTO_PRIMA", SqlDbType.Decimal).Value = CostoPrima
                .Parameters.AddWithValue("@DISPOSITIVO_SEGURIDAD", SqlDbType.NVarChar).Value = DispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", SqlDbType.DateTime).Value = FechaInicioContrato
                .Parameters.AddWithValue("@FECHA_FINAL_CONTRATO", SqlDbType.DateTime).Value = FechaFinalContrato
                .Parameters.AddWithValue("@FECHA_RENOVACION_CONTRATO", SqlDbType.DateTime).Value = FechaRenovacionContrato
                .Parameters.AddWithValue("@FECHA_INICIO_DIS_SEG", SqlDbType.DateTime).Value = FechaInicioDispositivo
                .Parameters.AddWithValue("@FECHA_FINAL_DIS_SEG", SqlDbType.DateTime).Value = FechaFinalDispositivo
                .Parameters.AddWithValue("@FECHA_RENOVACION_DIS_SEG", SqlDbType.DateTime).Value = FechaRenovacionDispositivo
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = 1
            End With
            Return comando
        End Function
         
        Public Function SeleccionarTodosHistorialVehiculos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosHistorialVehiculos", False) 
        End Function

        Public Function BuscarHistorialPorIdActivoFijo(ByVal tipoCon As TipoConexion, ByVal idActivoFijo As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.VarChar, idActivoFijo})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarHistorialPorIdActivoFijo", True, pars) 
        End Function

    End Class
End Namespace

