Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.RETENCIONES_EMITIDAS
    Public Class ClassConceptosPago

        Public Function SeleccionarRegistrosConceptosOrdenado(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from concepto_pago where estado_concepto_pago=1 order by codigo_concepto_pago;", False)
        End Function
          
        'Public Function BuscarCodigoConceptoXIdConcepto(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"ID_CONCEPTO_PAGO", SqlDbType.NVarChar, parametroBusqueda})
        '    Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoConceptoXIdConcepto", True, pars)
        '    Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        'End Function

        Public Function BuscarCodigoConceptoXIdConcepto(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONCEPTO_PAGO", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoConceptoXIdConcepto", True, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdConceptoXCodigoConcepto(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"COD", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select ID_CONCEPTO_PAGO from CONCEPTO_PAGO where CODIGO_CONCEPTO_PAGO = @COD and ESTADO_CONCEPTO_PAGO = 1", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

    End Class
End Namespace
