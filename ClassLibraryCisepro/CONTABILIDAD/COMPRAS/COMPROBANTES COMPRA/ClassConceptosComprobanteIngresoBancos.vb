Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
    Public Class ClassConceptosComprobanteIngresoBancos

        Public Function SeleccionarRegistrosConceptosComprobanteIngresoBancos(ByVal tipoCon As TipoConexion) As DataTable
            Dim pars = New List(Of Object())
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosConceptosComprobanteIngresoBancos", True, pars) 

        End Function

        Public Function BuscarCuentaConceptosComprobanteIngresoBancosPorNombre(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CONCEPTO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarCuentaConceptosComprobanteIngresoBancosPorNombre", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
         
    End Class
End Namespace

