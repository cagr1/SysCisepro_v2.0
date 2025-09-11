Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.CUENTAS_POR_PAGAR
    Public Class ClassCuentasPorPagar
         
        Public Function BuscarCuentasPorPagarGeneralXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarGeneralXRangoFecha", True, pars) 
        End Function

        Public Function BuscarCuentasPorPagarGeneralXRangoFechaDetalle(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal idProveedor As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR", SqlDbType.Int, idProveedor})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarCuentasPorPagarGeneralXRangoFechaDetalle", True, pars)
        End Function

        Public Function BuscarCuentasPorPagarGeneralXRangoFechaMin(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarGeneralXRangoFecha", True, pars) 
        End Function

        Public Function BuscarCuentasPorPagarGeneralXRangoFechaNoCero(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarGeneralXRangoFecha", True, pars) 

            For Each row As DataRow In table.Rows
                If row.Item("saldo") < 0.01 Then row.Delete()
            Next row

            Return table
        End Function

        Public Function BuscarCuentasPorPagarGeneralXRangoFechaNoCeroMin(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarGeneralXRangoFecha", True, pars) 

            For Each row As DataRow In table.Rows
                If row.Item("saldo") < 0.01 Then row.Delete()
            Next row

            Return table
        End Function

        Public Function BuscarCuentasPorPagarXIdProveedorRangoFecha(ByVal tipoCon As TipoConexion, ByVal idCliente As Integer, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, idCliente})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarXIdProveedorRangoFecha", True, pars) 
        End Function

        Public Function BuscarCuentasPorPagarXIdProveedorRangoFechaMin(ByVal tipoCon As TipoConexion, ByVal idCliente As Integer, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, idCliente})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarXIdProveedorRangoFecha", True, pars) 
        End Function

        Public Function BuscarCuentasPorPagarXIdProveedorRangoFechaNoCero(ByVal tipoCon As TipoConexion, ByVal idCliente As Integer, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, idCliente})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarXIdProveedorRangoFecha", True, pars) 

            For Each row As DataRow In table.Rows
                If row.Item("saldo") < 0.01 Then row.Delete()
            Next row

            Return table
        End Function

        Public Function BuscarCuentasPorPagarXIdProveedorRangoFechaNoCeroMin(ByVal tipoCon As TipoConexion, ByVal idCliente As Integer, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, idCliente})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "CuentasPorPagarXIdProveedorRangoFecha", True, pars)

            For Each row As DataRow In table.Rows
                If row.Item("saldo") < 0.01 Then row.Delete()
            Next row

            Return table
        End Function


        Public Function BuscarCuentasPorPagarGeneralDetalladoPorClienteAcumulado(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal IdProveedor As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR", SqlDbType.Int, IdProveedor})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarCuentasPorPagarGeneralAcumulado", True, pars)
            Return table
        End Function

        Public Function BuscarCuentasPorPagarDetallado(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime, ByVal IdProveedor As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            pars.Add(New Object() {"ID_PROVEEDOR", SqlDbType.Int, IdProveedor})
            Dim table = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarCuentasPorPagarGeneralDetallado", True, pars)
            Return table
        End Function

    End Class
End Namespace

