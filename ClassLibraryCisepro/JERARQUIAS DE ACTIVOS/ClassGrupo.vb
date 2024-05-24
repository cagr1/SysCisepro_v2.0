Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace JERARQUIAS_DE_ACTIVOS
    Public Class ClassGrupo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdGrupo As Integer
        Public CodigoGrupo As Integer
        Public NombreGrupo As String
        Public IdCategoriaGrupo As Integer
        Public EstadoGrupo As Integer

        Public Function CargarDatosGrupo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosRegistrosGrupoGeneral", True) 
        End Function

        Public Function BuscarNombresGrupoPorId(ByVal tipoCon As TipoConexion, ByVal nombre As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CTG", SqlDbType.Int, nombre})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM GRUPO_GENERAL WHERE ID_CATEGORIA_GRUPO=@CTG AND ESTADO_GRUPO=1", False, pars)
        End Function

        Public Function BuscarNombresGrupoPorIdCategoria(ByVal tipoCon As TipoConexion, ByVal nombre As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_GRUPO", SqlDbType.NVarChar, nombre})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombresGrupoPorIdCategoria", True, pars) 
        End Function

        Public Function BuscarCodigoGrupoPorNombreGrupo(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_GRUPO", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCODIGOGrupoPorNombreGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorCodigoGrupoPorIdCategoria(ByVal tipoCon As TipoConexion, ByVal codigoGrupo As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_GRUPO", SqlDbType.Int, codigoGrupo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorCodigoGrupoPorIdCategoria", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdGrupoPorNombreGrupo(ByVal tipoCon As TipoConexion, ByVal nombreGrupo As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_GRUPO", SqlDbType.VarChar, nombreGrupo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdGrupoPorNombreGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorGrupo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdGrupo", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroGrupo() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaGrupo"
                .Parameters.AddWithValue("@ID_GRUPO", SqlDbType.Int).Value = IdGrupo
                .Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CodigoGrupo
                .Parameters.AddWithValue("@NOMBRE_GRUPO", SqlDbType.NVarChar).Value = NombreGrupo
                .Parameters.AddWithValue("@ID_CATEGORIA_GRUPO", SqlDbType.Int).Value = IdCategoriaGrupo
                .Parameters.AddWithValue("@ESTADO_GRUPO", SqlDbType.Int).Value = EstadoGrupo
            End With
            Return comando
        End Function
        
    End Class
End Namespace
