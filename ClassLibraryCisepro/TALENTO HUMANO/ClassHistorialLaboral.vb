Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassHistorialLaboral
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdHistorias As Int64
        Public FechaHistoria As Date
        Public DetalleHistoria As String
        Public EstadoHistoria As Integer
        Public IdPersonalHistoria As Int64
        Public IdSitioPuestoHistoria As String
        Public IdAuxiliares As Int64

        Public Function NuevaHistorialLaboralCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaHistoriaLaboral"
                .Parameters.AddWithValue("@ID_HISTORIA_LABORAL", SqlDbType.BigInt).Value = IdHistorias
                .Parameters.AddWithValue("@FECHA_HISTORIA_LABORAL", SqlDbType.DateTime).Value = FechaHistoria
                .Parameters.AddWithValue("@DETALLE_HISTORIA_LABORAL", SqlDbType.NVarChar).Value = DetalleHistoria
                .Parameters.AddWithValue("@ESTADO_HISTORIA_LABORAL", SqlDbType.Int).Value = EstadoHistoria
                .Parameters.AddWithValue("@ID_PERSONAL_HISTORIA_LABORAL", SqlDbType.Int).Value = IdPersonalHistoria
                .Parameters.AddWithValue("@ID_SITIO_PUESTO", SqlDbType.NVarChar).Value = IdSitioPuestoHistoria
                .Parameters.AddWithValue("@ID_AUX", SqlDbType.BigInt).Value = IdAuxiliares
            End With
            Return comando
        End Function

        Public Function BuscarMayorIdHistoriaLaboral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdHistoriaLaboral", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function RegistrarNuevoHistorialLaboralCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaHistoriaLaboral"
                .Parameters.AddWithValue("@ID_HISTORIA_LABORAL", SqlDbType.BigInt).Value = IdHistorias
                .Parameters.AddWithValue("@FECHA_HISTORIA_LABORAL", SqlDbType.DateTime).Value = FechaHistoria
                .Parameters.AddWithValue("@DETALLE_HISTORIA_LABORAL", SqlDbType.NVarChar).Value = DetalleHistoria
                .Parameters.AddWithValue("@ESTADO_HISTORIA_LABORAL", SqlDbType.Int).Value = EstadoHistoria
                .Parameters.AddWithValue("@ID_PERSONAL_HISTORIA_LABORAL", SqlDbType.BigInt).Value = IdPersonalHistoria
                .Parameters.AddWithValue("@ID_SITIO_PUESTO", SqlDbType.NVarChar).Value = IdSitioPuestoHistoria
                .Parameters.AddWithValue("@ID_AUX", SqlDbType.BigInt).Value = IdAuxiliares
            End With
            Return comando
        End Function

        Public Function AnularHistorialLaboralCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "update HISTORIA_LABORAL set estado = 0 where ID_AUX=@ID_AUX"
                .Parameters.AddWithValue("@ID_AUX", SqlDbType.BigInt).Value = IdAuxiliares
            End With
            Return comando
        End Function

        Public Function AnularHistorialLaboralFrCommand(ByVal idSolFon As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update HISTORIA_LABORAL set ESTADO_HISTORIA_LABORAL=0 where DETALLE_HISTORIA_LABORAL like 'ANTICIPOS (EMERGENTE) A%CON MOTIVO%ID FR: " & idSolFon & "';"
            End With
            Return comando
        End Function
    End Class
End Namespace

