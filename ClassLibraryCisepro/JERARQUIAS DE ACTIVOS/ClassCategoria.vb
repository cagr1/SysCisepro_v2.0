Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace JERARQUIAS_DE_ACTIVOS
    Public Class ClassCategoria
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCategoria As Integer
        Public CodigoCategoria As Integer
        Public NombreCategoria As String
        Public EstadoCategoria As Integer

        Public Function CargarDatosCategoria(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosCategoria", True)
        End Function

        Public Function BuscarMayorCategoria(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCategoria", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorCodigoCategoria(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorCodigoCategoria", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoCategoriaPorNombreCategoria(ByVal tipoCon As TipoConexion, ByVal nombreCategoria As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CATEGORIA", SqlDbType.VarChar, nombreCategoria})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCODIGOCategoriaPorNombreCategoria", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroCategoria() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaCategoria"
                .Parameters.AddWithValue("@ID_CATEGORIA", SqlDbType.Int).Value = IdCategoria
                .Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CodigoCategoria
                .Parameters.AddWithValue("@NOMBRE_CATEGORIA", SqlDbType.NVarChar).Value = NombreCategoria
                .Parameters.AddWithValue("@ESTADO_CATEGORIA", SqlDbType.Int).Value = EstadoCategoria
            End With
            Return comando
        End Function

    End Class
End Namespace

