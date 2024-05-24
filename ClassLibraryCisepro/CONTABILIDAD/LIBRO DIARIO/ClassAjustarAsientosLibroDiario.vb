Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.LIBRO_DIARIO
    Public Class ClassAjustarAsientosLibroDiario
         
        Public Function BuscarValorDebeCuentaXNumeroRegistroCuenta(ByVal tipoCon As TipoConexion, ByVal numeroRegistro As Int64, ByVal codCuenta As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.NVarChar, numeroRegistro})
            pars.Add(New Object() {"CODIGO_CUENTA_ASIENTO", SqlDbType.NVarChar, codCuenta})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarValorDebeCuentaXNumeroRegistroCuenta", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("VALOR_ASIENTO")))
        End Function

        Public Function BuscarValorHaberCuentaXNumeroRegistroCuenta(ByVal tipoCon As TipoConexion, ByVal numeroRegistro As Int64, ByVal codCuenta As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.NVarChar, numeroRegistro})
            pars.Add(New Object() {"CODIGO_CUENTA_ASIENTO", SqlDbType.NVarChar, codCuenta})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarValorHaberCuentaXNumeroRegistroCuenta", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("VALOR_ASIENTO")))
        End Function

        Public Function SeleccionarAsientosLibroDiario(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosAsientosLibroDiario", True) 
        End Function

        Public Function BuscarAsientosLibroDiarioXNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal nroRegistro As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.Int, nroRegistro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioXNumeroRegistro", True, pars) 
        End Function

        Public Function BuscarAsientosLibroDiarioResumidoXNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal nroRegistro As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.Int, nroRegistro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioResumidoXNumeroRegistro", True, pars) 
        End Function

        Public Function BuscarAsientosLibroDiarioXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioXRangoFecha", True, pars) 
        End Function

        Public Function BuscarAsientosLibroDiarioXCodigoCuenta(ByVal tipoCon As TipoConexion, ByVal codigoCuenta As String, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO_CUENTA_ASIENTO", SqlDbType.VarChar, codigoCuenta})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioXCodigoCuenta", True, pars)
        End Function

        Public Function BuscarReporteAsientoLibroDiarioXNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idp As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt, idp})

            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "BuscarAsientosLibroDiarioReporteXNumeroRegistro", True, pars)

            Dim ds = New DataSet()
            acts.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            acts.Fill(ds, "LIBRO_DIARIO_GENERAL")
            Return ds
        End Function
         
    End Class
End Namespace
