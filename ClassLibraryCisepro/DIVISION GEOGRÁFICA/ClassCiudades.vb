Imports System.Windows.Forms
Imports System.Data 
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace DIVISION_GEOGRÁFICA
    Public Class ClassCiudades
         
        Public Function BuscarIdCiudadPorNombreCiudad(ByVal tipoCon As TipoConexion, ByVal nombreCiudad As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CIUDADES", SqlDbType.NVarChar, nombreCiudad})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCiudadPorNombreCiudad", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreCiudadXIdCiudad(ByVal tipoCon As TipoConexion, ByVal idDeCiudad As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CIUDAD", SqlDbType.Int, idDeCiudad})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreCiudadXIdCiudad", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreCiudadXIdProvincia(ByVal tipoCon As TipoConexion, ByVal idProvincias As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVINCIAS", SqlDbType.Int, idProvincias})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreCiudadesXIdProvincia", True, pars) 
        End Function
         
        Private Function BuscarNombreCiudades(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombreCiudades", True) 
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombreCiudades(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("NOMBRE_CIUDADES")))
            Next
            Return coleccion
        End Function
 
    End Class
End Namespace

