Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ESTRUCTURA_EMPRESA
    Public Class ClassEmpresa
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdEmpresa As Integer
        Public RucEmpresa As String
        Public RazonSocialEmpresa As String
        Public NombreComercialEmpresa As String
        Public DireccionMatrizEmpresa As String
        Public NroResContEspecialEmpresa As String
        Public ObligadoLlevarContEmpresa As String
        Public EstadoEmpresa As Integer

        Public Function ObtenerRutasDocsEltectronicos(ByVal tipoCon As TipoConexion) As String
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from RUTA_DOC_ELECTRONICO;", False)
            Return If(data.Rows.Count = 0, String.Empty, data.Rows(0)(1) & "~" & data.Rows(1)(1) & "~" & data.Rows(2)(1))
        End Function

        Public Function SeleccionarTodosLosRegistrosEmpresa(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodosLosRegistrosEmpresa", True)
        End Function

        Public Function SeleccionarRegistroEmpresaGeneralInformacionTributaria(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarRegistroEmpresaGeneralInformacionTributaria", True)
        End Function

        Public Function BuscarIdEmpresaPorNombre(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_COMERCIAL_EMPRESA", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdEmpresaPorNombre", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreEmpresaPorId(ByVal tipoCon As TipoConexion, ByVal idEmpresa As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_EMPRESA", SqlDbType.Int, idEmpresa})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreEmpresaPorId", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function ModificarRegistroEmpresaGeneral(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroEmpresaGeneral"
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@RUC_EMPRESA", SqlDbType.NVarChar).Value = RucEmpresa
                .Parameters.AddWithValue("@RAZON_SOCIAL_EMPRESA", SqlDbType.NVarChar).Value = RazonSocialEmpresa
                .Parameters.AddWithValue("@NOMBRE_COMERCIAL_EMPRESA", SqlDbType.NVarChar).Value = NombreComercialEmpresa
                .Parameters.AddWithValue("@DIRECCION_MATRIZ_EMPRESA", SqlDbType.NVarChar).Value = DireccionMatrizEmpresa
                .Parameters.AddWithValue("@NRO_RES_CONT_ESPECIAL_EMPRESA", SqlDbType.NVarChar).Value = NroResContEspecialEmpresa
                .Parameters.AddWithValue("@OBLIGADO_LLEVAR_CONT_EMPRESA", SqlDbType.NVarChar).Value = ObligadoLlevarContEmpresa
                .Parameters.AddWithValue("@ESTADO_EMPRESA", SqlDbType.Int).Value = EstadoEmpresa
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace


