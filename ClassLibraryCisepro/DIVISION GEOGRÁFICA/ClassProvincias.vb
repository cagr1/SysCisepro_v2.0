Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace DIVISION_GEOGRÁFICA
    Public Class ClassProvincias
 
        Public Function SeleccionarTodosLosRegistrosProvincias(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosProvincias", True) 
        End Function

        Public Function BuscarIdProvinciaPorNombreProvincia(ByVal tipoCon As TipoConexion, ByVal nombreProvincia As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_PROVINCIAS", SqlDbType.NVarChar, nombreProvincia})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdProvinciaPorNombreProvincia", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreProvinciaXIdProvincia(ByVal tipoCon As TipoConexion, ByVal idDeProvincia As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVINCIAS", SqlDbType.Int, idDeProvincia})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreProvinciaXIdProvincia", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdProvinciaXNombreProvincia(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_PROVINCIAS", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdProvinciaPorNombreProvincia", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreProvinciasXIdPaises(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PAISES", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreProvinciasXIdPaises", True, pars) 
        End Function
 
    End Class
End Namespace

