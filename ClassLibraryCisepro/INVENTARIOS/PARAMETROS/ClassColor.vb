Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.PARAMETROS
    Public Class ClassColor
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Detalle As String
        Public Estado As String

        Public Function SeleccionarTodosLosRegistrosColor(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosColor", True) 
        End Function

        Public Function BuscarColorRepetida(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarColorRepetida", True, pars) 
            Return data.Rows.Count <> 0 AndAlso CInt(data.Rows(0)("CANTIDAD"))
        End Function

        Public Function NuevaColor() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaColor"
                .Parameters.AddWithValue("@ID_COLOR", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
        Public Function NuevaColor(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaColor"
                .Parameters.AddWithValue("@ID_COLOR", SqlDbType.Int).Value = id
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = detalle
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estado
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdColor(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdColor", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

