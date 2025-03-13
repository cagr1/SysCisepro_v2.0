Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassFormasPago
        
        Public Function SeleccionarRegistrosFormasPago(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosFormasPago", True) 
        End Function

        Public Function BuscarCodigoFormasPagoXdetalle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE_FORMA_PAGO", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoFormasPagoXdetalle", True, pars)
            Return If(data.Rows.Count = 0, "0", If(IsDBNull(data.Rows(0)(0)), "0", data.Rows(0)(0).ToString()))
        End Function

        Public Function BuscarDetalleFormaPago(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"codigo", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarDetalleFormaPago", True, pars)
        End Function

    End Class
End Namespace
