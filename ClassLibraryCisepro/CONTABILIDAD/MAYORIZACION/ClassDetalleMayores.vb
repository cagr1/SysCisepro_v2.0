Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.MAYORIZACION
    Public Class ClassDetalleMayores
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public Fecha As DateTime
        Public Descripcion As String
        Public Referencia As Int64
        Public Debe As Decimal
        Public Haber As Decimal
        Public Estado As Integer
        Public IdMayor As Integer
        Public IdAsiento As Int64
        Public IdCorte As Int64

        Public Function BuscarMayorIdDetalleMayorGeneral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleMayorGeneral", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleMayorCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDetalleMayor"
                .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = Descripcion
                .Parameters.AddWithValue("@REFERENCIA", SqlDbType.BigInt).Value = Referencia
                .Parameters.AddWithValue("@DEBE", SqlDbType.Decimal).Value = Debe
                .Parameters.AddWithValue("@HABER", SqlDbType.Decimal).Value = Haber
                .Parameters.AddWithValue("@ID_MAYOR", SqlDbType.BigInt).Value = IdMayor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@ID_CORTE", SqlDbType.BigInt).Value = IdCorte
            End With
            Return comando
        End Function
        'Public Function NuevoRegistroDetalleMayor(ByVal tipoCon As TipoConexion) As Boolean
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "NuevoRegistroDetalleMayor"
        '        .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = Id
        '        .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
        '        .Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = Descripcion
        '        .Parameters.AddWithValue("@REFERENCIA", SqlDbType.BigInt).Value = Referencia
        '        .Parameters.AddWithValue("@DEBE", SqlDbType.Decimal).Value = Debe
        '        .Parameters.AddWithValue("@HABER", SqlDbType.Decimal).Value = Haber
        '        .Parameters.AddWithValue("@ID_MAYOR", SqlDbType.BigInt).Value = idMayor
        '        .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
        '        .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = idAsiento
        '        .Parameters.AddWithValue("@ID_CORTE", SqlDbType.BigInt).Value = idCorte
        '    End With
        '    Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        'End Function
      
    End Class
End Namespace
