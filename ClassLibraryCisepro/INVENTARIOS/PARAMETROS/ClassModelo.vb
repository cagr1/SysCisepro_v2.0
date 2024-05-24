Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.PARAMETROS
    Public Class ClassModelo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Detalle As String
        Public EstadoMaterial As Integer
 
        Public Function SeleccionarTodosLosRegistrosModelo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosModelo", True) 
        End Function

        Public Function BuscarModeloRepetida(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarModeloRepetida", True, pars) 
            Return data.Rows.Count <> 0 AndAlso CInt(data.Rows(0)("CANTIDAD")) > 0
        End Function

        Public Function BuscarMayorIdModelo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdModelo", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function
         
        Public Function NuevaModelo(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaModelo"
                .Parameters.AddWithValue("@ID_MODELO", SqlDbType.Int).Value = id
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = detalle
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estadoMaterial
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function
         
    End Class
End Namespace

