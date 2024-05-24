Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.ITEMS
    Public Class ClassSubGrupoItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSubGrupo As Int64
        Public CodigoSubGrupo As String
        Public NombreSubGrupo As String
        Public FechaSubGrupo As DateTime
        Public EstadoSubGrupo As Integer
        Public IdGrupoSubGrupo As Int64 

        Public Function NuevaSubGrupoItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSubGrupoItem"
                .Parameters.AddWithValue("@ID_SUB_GRUPO_ITEM", SqlDbType.BigInt).Value = IdSubGrupo
                .Parameters.AddWithValue("@CODIGO_SUB_GRUPO_ITEM", SqlDbType.NVarChar).Value = CodigoSubGrupo
                .Parameters.AddWithValue("@NOMBRE_SUB_GRUPO_ITEM", SqlDbType.NVarChar).Value = NombreSubGrupo
                .Parameters.AddWithValue("@FECHA_SUB_GRUPO_ITEM", SqlDbType.DateTime).Value = FechaSubGrupo
                .Parameters.AddWithValue("@ESTADO_SUB_GRUPO_ITEM", SqlDbType.Int).Value = EstadoSubGrupo
                .Parameters.AddWithValue("@ID_GRUPO_ITEM", SqlDbType.BigInt).Value = IdGrupoSubGrupo
            End With
            Return comando
        End Function
        Public Function NuevaSubGrupoItem(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSubGrupoItem"
                .Parameters.AddWithValue("@ID_SUB_GRUPO_ITEM", SqlDbType.BigInt).Value = IdSubGrupo
                .Parameters.AddWithValue("@CODIGO_SUB_GRUPO_ITEM", SqlDbType.NVarChar).Value = CodigoSubGrupo
                .Parameters.AddWithValue("@NOMBRE_SUB_GRUPO_ITEM", SqlDbType.NVarChar).Value = NombreSubGrupo
                .Parameters.AddWithValue("@FECHA_SUB_GRUPO_ITEM", SqlDbType.DateTime).Value = FechaSubGrupo
                .Parameters.AddWithValue("@ESTADO_SUB_GRUPO_ITEM", SqlDbType.Int).Value = EstadoSubGrupo
                .Parameters.AddWithValue("@ID_GRUPO_ITEM", SqlDbType.BigInt).Value = IdGrupoSubGrupo
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdSubGrupoItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSubGrupoItem", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorCodigoSubGrupoItemXidGrupo(ByVal tipoCon As TipoConexion, ByVal idGrupoItem As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_ITEM", SqlDbType.VarChar, idGrupoItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorCodigoSubGrupoItemXidGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarSubGrupoItemsActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSubGrupoItemsActivas", True) 
        End Function

        Public Function SeleccionarSubGrupoItemsActivasXIdGrupo(ByVal tipoCon As TipoConexion, ByVal idKardex As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO", SqlDbType.NVarChar, idKardex})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSubGrupoItemsActivasXIdGrupo", True, pars) 
        End Function

        Public Function BuscarCodigoSubGrupoItemXidSubGrupoItem(ByVal tipoCon As TipoConexion, ByVal idSubGrupoItem As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SUB_GRUPO_ITEM", SqlDbType.BigInt, idSubGrupoItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoSubGrupoItemXidSubGrupoItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
         
        Public Function BuscarSubGrupoItemXIdGrupoItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_ITEM", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarSubGrupoItemXIdGrupoItem", True, pars) 
        End Function

        Public Function BuscarSubGrupoItemXIdGrupoItemTodas(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_ITEM", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from (select 0 ID, '-- TODAS --' nombre union select id_sub_grupo_item ID, nombre_sub_grupo_item NOMBRE from sub_grupo_item where id_grupo_item = @ID_GRUPO_ITEM)as tab order by tab.id", False, pars)
        End Function

    End Class
End Namespace

