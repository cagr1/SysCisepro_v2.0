Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace JERARQUIAS_DE_ACTIVOS
    Public Class ClassSubGrupo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSubGrupo As Integer
        Public CodigosubGrupo As Integer
        Public NombreSubGrupo As String
        Public IdGrupoSubGrupo As Integer
        Public EstadoSubGrupo As Integer

        Public Function CargarDatosSubGrupo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosRegistrosSubGrupoGeneral", True) 
        End Function

        Public Function BuscarMayorSubGrupo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSubGrupoGeneral", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoGrupoPorNombreGrupo(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SUB_GRUPO", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCODIGOSubGrupoPorNombreSubGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdSubGrupoPorNombreSubGrupo(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SUB_GRUPO", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdSubGrupoPorNombreSubGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorCodigoSubGrupoPorIdGrupo(ByVal tipoCon As TipoConexion, ByVal idGrupo As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_SUB_GRUPO", SqlDbType.Int, idGrupo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorCodigoSubGrupoPorIdGrupo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombresSubGrupoPorIdGrupo(ByVal tipoCon As TipoConexion, ByVal idgrupoSubGrupo As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ISG", SqlDbType.Int, idgrupoSubGrupo})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM SUB_GRUPO_GENERAL WHERE ID_GRUPO_SUB_GRUPO=@ISG AND ESTADO_SUB_GRUPO=1", False, pars)
        End Function

        Public Function NuevoRegistroSubGrupo() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSubGrupo"
                .Parameters.AddWithValue("@ID_SUB_GRUPO", SqlDbType.Int).Value = IdSubGrupo
                .Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CodigosubGrupo
                .Parameters.AddWithValue("@NOMBRE_SUB_GRUPO", SqlDbType.NVarChar).Value = NombreSubGrupo
                .Parameters.AddWithValue("@ID_GRUPO_SUB_GRUPO", SqlDbType.Int).Value = IdGrupoSubGrupo
                .Parameters.AddWithValue("@ESTADO_SUB_GRUPO", SqlDbType.Int).Value = EstadoSubGrupo
            End With
            Return comando
        End Function
        
    End Class
End Namespace

