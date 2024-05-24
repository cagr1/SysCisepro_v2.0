Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.BODEGA
    Public Class ClassBodega
         
        Public Function SeleccionarBodegasActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarBodegasActivas", True) 
        End Function

        Public Function BuscarIdBodegaXnombreBodega(ByVal tipoCon As TipoConexion, ByVal nombreBodega As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_BODEGA", SqlDbType.NVarChar, nombreBodega})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdBodegaXnombreBodega", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreCustodioBodegaXidBodega(ByVal tipoCon As TipoConexion, ByVal idActivoF As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BODEGA", SqlDbType.Int, idActivoF})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreCustodioBodegaXidBodega", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
         
    End Class
End Namespace

