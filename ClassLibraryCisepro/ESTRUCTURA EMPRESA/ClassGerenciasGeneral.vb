Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ESTRUCTURA_EMPRESA
    Public Class ClassGerenciasGeneral
     
        Public Function SeleccionarTodosLosRegistrosGerenciasGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodosLosRegistrosGerenciasGeneral", True) 
        End Function
         
        Public Function BuscarIdGerenciasPorNombreGerencias(ByVal tipoCon As TipoConexion, ByVal nombreGerencias As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_GERENCIAS", SqlDbType.NVarChar, nombreGerencias})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdGerenciasPorNombreGerencias", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function
         
    End Class
End Namespace
