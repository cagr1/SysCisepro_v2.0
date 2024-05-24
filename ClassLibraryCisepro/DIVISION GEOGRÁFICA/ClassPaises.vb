Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace DIVISION_GEOGRÁFICA
    Public Class ClassPaises
          
        Public Function SeleccionarTodosLosRegistrosPaises(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosPaises", True) 
        End Function

        Public Function BuscarIdPaisXNombrePais(ByVal tipoCon As TipoConexion, ByVal parametro As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_PAISES", SqlDbType.NVarChar, parametro})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdPaisXNombrePais", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

