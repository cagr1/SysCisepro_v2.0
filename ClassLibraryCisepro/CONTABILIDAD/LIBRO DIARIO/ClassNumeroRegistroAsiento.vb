Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.LIBRO_DIARIO
    Public Class ClassNumeroRegistroAsiento
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public NumeroRegistro As Int64
        Public NumeroAnterior As Int64

        Public Function BuscarMayorNumeroRegistro(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroRegistro", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroAnterior(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroAnterior", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoNumeroRegistroAsientoLibroDiarioCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoNumeroRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@NUMERO_REGISTRO", SqlDbType.BigInt).Value = NumeroRegistro
                .Parameters.AddWithValue("@NUMERO_ANTERIOR", SqlDbType.BigInt).Value = NumeroAnterior
            End With
            Return comando
        End Function
        Public Function NuevoNumeroRegistroAsientoLibroDiario(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoNumeroRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@NUMERO_REGISTRO", SqlDbType.BigInt).Value = NumeroRegistro
                .Parameters.AddWithValue("@NUMERO_ANTERIOR", SqlDbType.BigInt).Value = NumeroAnterior
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

