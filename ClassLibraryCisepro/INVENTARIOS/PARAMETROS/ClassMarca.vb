Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.PARAMETROS
    Public Class ClassMarca
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdMarca As Integer
        Public DetalleMarca As String
        Public EstadoMarca As String

        Public Function SeleccionarTodosLosRegistrosMarca(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosMarca", True) 
        End Function

        Public Function BuscarMarcaRepetida(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarMarcaRepetida", True, pars) 
            Return data.Rows.Count <> 0 AndAlso CInt(data.Rows(0)("CANTIDAD")) > 0
        End Function

        Public Function NuevaMarca() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaMarca"
                .Parameters.AddWithValue("@ID_MARCA", SqlDbType.Int).Value = IdMarca
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = DetalleMarca
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = EstadoMarca
            End With
            Return comando
        End Function
        Public Function NuevaMarca(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaMarca"
                .Parameters.AddWithValue("@ID_MARCA", SqlDbType.Int).Value = idMarca
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = detalleMarca
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estadoMarca
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdMarca(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdMarca", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

