Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.CONCEPTOS
    Public Class ClassConceptosInventarios
         
        Public Function SeleccionarConceptosxIdActividad(ByVal tipoCon As TipoConexion, ByVal idActividad As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ACTIVIDAD", SqlDbType.Int, idActividad})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarConceptosxIdActividad", True, pars) 
        End Function
         
        Public Function BuscarCodigoxIdConcepto(ByVal tipoCon As TipoConexion, ByVal idConcepto As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONCEPTO", SqlDbType.Int, idConcepto})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoxIdConcepto", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("CODIGO")))
        End Function

    End Class
End Namespace
