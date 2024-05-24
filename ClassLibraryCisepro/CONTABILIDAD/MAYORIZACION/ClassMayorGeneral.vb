Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.MAYORIZACION
    Public Class ClassMayorGeneral
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public Codigo As String
        Public Fecha As DateTime
        Public Observacion As String
        Public TotalDebe As Decimal
        Public TotalHaber As Decimal
        Public TotalDeudor As Decimal
        Public TotalAcreedor As Decimal
        Public DeudorAcreedor As Integer
        Public Estado As Integer 
        Public IdEmpresa As Integer
        Public CodigoPadre As String

        Public Function BuscarMayorIdMayorGeneral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdMayorGeneral", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroMayorCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroMayor"
                .Parameters.AddWithValue("@ID_MAYOR", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
                .Parameters.AddWithValue("@TOTAL_DEBE", SqlDbType.Decimal).Value = TotalDebe
                .Parameters.AddWithValue("@TOTAL_HABER", SqlDbType.Decimal).Value = TotalHaber
                .Parameters.AddWithValue("@TOTAL_DEUDOR", SqlDbType.Decimal).Value = TotalDeudor
                .Parameters.AddWithValue("@TOTAL_ACREEDOR", SqlDbType.Decimal).Value = TotalAcreedor
                .Parameters.AddWithValue("@DEUDOR_ACREEDOR", SqlDbType.Int).Value = DeudorAcreedor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@CODIGO_PADRE", SqlDbType.NVarChar).Value = CodigoPadre
            End With
            Return comando
        End Function

        'Public Function NuevoRegistroMayor(ByVal tipoCon As TipoConexion) As Boolean
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "NuevoRegistroMayor"
        '        .Parameters.AddWithValue("@ID_MAYOR", SqlDbType.BigInt).Value = id
        '        .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = codigo
        '        .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = fecha
        '        .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = observacion
        '        .Parameters.AddWithValue("@TOTAL_DEBE", SqlDbType.Decimal).Value = totalDebe
        '        .Parameters.AddWithValue("@TOTAL_HABER", SqlDbType.Decimal).Value = totalHaber
        '        .Parameters.AddWithValue("@TOTAL_DEUDOR", SqlDbType.Decimal).Value = totalDeudor
        '        .Parameters.AddWithValue("@TOTAL_ACREEDOR", SqlDbType.Decimal).Value = totalAcreedor
        '        .Parameters.AddWithValue("@DEUDOR_ACREEDOR", SqlDbType.Int).Value = deudorAcreedor
        '        .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estado
        '        .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = idEmpresa
        '        .Parameters.AddWithValue("@CODIGO_PADRE", SqlDbType.NVarChar).Value = codigoPadre
        '    End With
        '    Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        'End Function
          
    End Class
End Namespace

