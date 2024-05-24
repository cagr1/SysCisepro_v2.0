Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Public Class ClassParametroDocumentos
    ''' <summary>
    ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
    ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
    ''' CON EL MISMO TIPO DE DATO
    ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
    Public IdParametroDocumentos As Integer
    Public NombreParametrosDocumentos As String
    Public TipoParametroDocumentos As String
    Public EstadoParametroDocumentos As Integer

    Public Function SeleccionarParametrosDocumentos(ByVal tipoCon As TipoConexion) As DataTable
        Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarParametrosDocumentos", False)
    End Function

    Public Function BuscarMayorIdParametroDocumentos(ByVal tipoCon As TipoConexion) As Integer
        Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdParametroDocumentos", False)
        Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
    End Function

    Public Function BuscarTipoParametroDocumentosXId(ByVal tipoCon As TipoConexion, ByVal IdParametro As String) As String
        Dim pars = New List(Of Object())
        pars.Add(New Object() {"ID_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar, IdParametro})
        Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarTipoParametroDocumentosXId", True, pars)
        Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
    End Function

    Public Function NuevoParametrosDocumentos() As SqlCommand
        Dim comando = New SqlCommand
        With comando
            .CommandType = CommandType.StoredProcedure
            .CommandText = "NuevoParametroDocumentos"
            .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = IdParametroDocumentos
            .Parameters.AddWithValue("@NOMBRE_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar).Value = NombreParametrosDocumentos
            .Parameters.AddWithValue("@TIPO_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar).Value = TipoParametroDocumentos
            .Parameters.AddWithValue("@ESTADO_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = EstadoParametroDocumentos
        End With
        Return comando
    End Function

    Public Function ModificarParametrosDocumentos() As SqlCommand
        Dim comando = New SqlCommand
        With comando
            .CommandType = CommandType.StoredProcedure
            .CommandText = "modificarParametroDocumentos"
            .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = IdParametroDocumentos
            .Parameters.AddWithValue("@NOMBRE_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar).Value = NombreParametrosDocumentos
            .Parameters.AddWithValue("@TIPO_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar).Value = TipoParametroDocumentos
            .Parameters.AddWithValue("@ESTADO_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = EstadoParametroDocumentos
        End With
        Return comando
    End Function

End Class