Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace DIVISION_GEOGRÁFICA
    Public Class ClassParroquias
         
        Public Function BuscarIdParroquiaXNombreParroquia(ByVal tipoCon As TipoConexion, ByVal nombreParroquias As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_PARROQUIAS", SqlDbType.NVarChar, nombreParroquias})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarIdParroquiaXNombreParroquia", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreParroquiaXIdParroquia(ByVal tipoCon As TipoConexion, ByVal idParroquia As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PARROQUIAS", SqlDbType.Int, idParroquia})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreParroquiaXIdParroquia", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreParroquiaXIdCiudad(ByVal tipoCon As TipoConexion, ByVal idC As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CIUDAD", SqlDbType.Int, idC})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreParroquiaXIdCiudades", True, pars) 
        End Function
         
    End Class
End Namespace
