Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace JERARQUIAS_DE_ACTIVOS
    Public Class ClassSecuencial
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSecuencial As Integer
        Public CodigoSecuencial As Integer
        Public NombreSecuencial As String
        Public EstadoDepreciableSecuencial As String
        Public IdSubGrupoSecuencial As Integer
        Public EstadoSecuencial As Integer

        Public Function BuscarMayorCodigoSecuencialPorIdSubGrupo(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SUB_GRUPO_SECUENCIAL", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorCodigoSecuencialPorIdSubGrupo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoSecuencialPorNombre(ByVal tipoCon As TipoConexion, ByVal nombreSecuencial As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SECUENCIAL", SqlDbType.NVarChar, nombreSecuencial})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoSecuencialPorNombre", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function CargarDatosSecuencial(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodosLosRegistrosSecuencial", True)
        End Function

        Public Function BuscarMayorSecuencial(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorSecuencial", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaSecuencial() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSecuencial"
                .Parameters.AddWithValue("@ID_SECUENCIAL", SqlDbType.Int).Value = IdSecuencial
                .Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CodigoSecuencial
                .Parameters.AddWithValue("@NOMBRE_SECUENCIAL", SqlDbType.NVarChar).Value = NombreSecuencial
                .Parameters.AddWithValue("@ESTADO_DEPRECIABLE", SqlDbType.NVarChar).Value = EstadoDepreciableSecuencial
                .Parameters.AddWithValue("@ID_SUB_GRUPO_SECUENCIAL", SqlDbType.Int).Value = IdSubGrupoSecuencial
                .Parameters.AddWithValue("@ESTADO_SECUENCIAL", SqlDbType.Int).Value = EstadoSecuencial
            End With
            Return comando
        End Function

        Public Function BuscarNombreSecuencialPorIdSub(ByVal tipoCon As TipoConexion, ByVal idgrupoSubGrupo As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDSEG", SqlDbType.Int, idgrupoSubGrupo})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM SECUENCIAL WHERE ID_SUB_GRUPO_SECUENCIAL=@IDSEG AND ESTADO_SECUENCIAL=1", False, pars)
        End Function
         
    End Class
End Namespace

