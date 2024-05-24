Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.ITEMS
    Public Class ClassGrupoItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdGrupo As Int64
        Public CodigoGrupo As String
        Public NombreGrupo As String
        Public FechaGrupo As DateTime
        Public EstadoGrupo As Integer
        Public IdCategoria As Int64

        Public Function NuevaGrupoItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaGrupoItem"
                .Parameters.AddWithValue("@ID_GRUPO_ITEM", SqlDbType.BigInt).Value = IdGrupo
                .Parameters.AddWithValue("@CODIGO_GRUPO_ITEM", SqlDbType.NVarChar).Value = CodigoGrupo
                .Parameters.AddWithValue("@NOMBRE_GRUPO_ITEM", SqlDbType.NVarChar).Value = NombreGrupo
                .Parameters.AddWithValue("@FECHA_GRUPO_ITEM", SqlDbType.DateTime).Value = FechaGrupo
                .Parameters.AddWithValue("@ESTADO_GRUPO_ITEM", SqlDbType.Int).Value = EstadoGrupo
                .Parameters.AddWithValue("@ID_CATEGORIA_ITEM", SqlDbType.BigInt).Value = IdCategoria
            End With
            Return comando
        End Function
        Public Function NuevaGrupoItem(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaGrupoItem"
                .Parameters.AddWithValue("@ID_GRUPO_ITEM", SqlDbType.BigInt).Value = IdGrupo
                .Parameters.AddWithValue("@CODIGO_GRUPO_ITEM", SqlDbType.NVarChar).Value = CodigoGrupo
                .Parameters.AddWithValue("@NOMBRE_GRUPO_ITEM", SqlDbType.NVarChar).Value = NombreGrupo
                .Parameters.AddWithValue("@FECHA_GRUPO_ITEM", SqlDbType.DateTime).Value = FechaGrupo
                .Parameters.AddWithValue("@ESTADO_GRUPO_ITEM", SqlDbType.Int).Value = EstadoGrupo
                .Parameters.AddWithValue("@ID_CATEGORIA_ITEM", SqlDbType.BigInt).Value = IdCategoria
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdGrupoItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdGrupoItem", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorCodigoGrupoItemXidCategoria(ByVal tipoCon As TipoConexion, ByVal idCategoriaItem As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_ITEM", SqlDbType.NVarChar, idCategoriaItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorCodigoGrupoItemXidCategoria", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarGrupoItemsActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarGrupoItemsActivas", True)
        End Function

        Public Function SeleccionarGrupoItemsActivasXIdCategoria(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATE", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarGrupoItemsActivasXIdCategoria", True, pars)
        End Function

        Public Function BuscarIdGrupoItemXnombreGrupoItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_GRUPO_ITEM", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdGrupoItemXnombreGrupoItem", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdCategoriaItemXidGrupoItem(ByVal tipoCon As TipoConexion, ByVal idCategoria As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_ITEM", SqlDbType.Int, idCategoria})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCategoriaItemXidGrupoItem", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoGrupoItemXidGrupoItem(ByVal tipoCon As TipoConexion, ByVal idGrupoItem As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_ITEM", SqlDbType.Int, idGrupoItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoGrupoItemXidGrupoItem", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarGrupoItemXIdCategoriaItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_ITEM", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarGrupoItemXCategoriaItem", True, pars)
        End Function

        Public Function BuscarGrupoItemXIdCategoriaItemTodas(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_ITEM", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from (select 0 ID, '-- TODAS --' nombre union select id_grupo_item ID, nombre_grupo_item NOMBRE from grupo_item where id_categoria_item = @ID_CATEGORIA_ITEM)as tab order by tab.id", False, pars)
        End Function
    End Class
End Namespace
