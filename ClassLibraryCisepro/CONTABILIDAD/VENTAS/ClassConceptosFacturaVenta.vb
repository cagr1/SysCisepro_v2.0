Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassConceptosFacturaVenta
        
        Public Function SeleccionarRegistrosConceptosFacturaVenta(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosConceptosFacturaVenta", True) 
        End Function

        Public Function SeleccionarConveniosDebitoByIdCliente(ByVal tipoCon As TipoConexion, ByVal idc As Integer) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "(SELECT 0, '-- SELECCIONE UNA CUENTA DEBITO --') UNION (select ID_CONVENIO, substring(BANCO_CONVENIO,5,len(BANCO_CONVENIO)) + ' (' +titular_cuenta + ' CTA ' + num_cuenta_tarj+ ' - $' + cast(valor as varchar) + ')' DETALLE from convenio_cliente_banco_debito where id_cliente_general= " & idc & "  AND ESTADO > 0)", False)
        End Function

        Public Function BuscarCuentaConceptosFacturaVentaPorNombre(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CONCEPTO_FACTURA_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarCuentaConceptosFacturaVentaPorNombre", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("CUENTA_CONCEPTO_FACTURA_VENTA")))
        End Function
         
    End Class
End Namespace

