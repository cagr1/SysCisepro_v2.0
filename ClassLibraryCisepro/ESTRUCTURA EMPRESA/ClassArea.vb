Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ESTRUCTURA_EMPRESA
    Public Class ClassArea
        
        Public Function SeleccionarTodosLosRegistrosArea(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosArea", True) 
        End Function

        Public Function BuscarIdAreaGeneralPorNombreAreaGeneral(ByVal tipoCon As TipoConexion, ByVal nombreArea As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_AREA", SqlDbType.NVarChar, nombreArea})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdAreaGeneralPorNombreAreaGeneral", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreAreaGeneralPorIdAreaGeneral(ByVal tipoCon As TipoConexion, ByVal idArea As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_AREA_GENERAL", SqlDbType.Int, idArea})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreAreaGeneralPorIdAreaGeneral", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
         
    End Class
End Namespace
