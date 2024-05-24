Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassCuentasBancos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCuentaBancos As Integer
        Public NumeroCuentaBancos As String
        Public MontoCuentaBancos As Decimal
        Public TipoCuentaBancos As String
        Public EstadoCuentaBancos As Integer
        Public IdBancos As Integer
        Public CodigoPlan As String

        Public Function SeleccionarRegistrosCuentasBancos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosCuentasBancos", True)
        End Function

        Public Function BuscarMayorIdCuentasBancos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCuentasBancos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNumeroCuentaXIdBanco(ByVal tipoCon As TipoConexion, ByVal idBancoCuenta As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BANCO", SqlDbType.VarChar, idBancoCuenta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CUENTAS_BANCOS WHERE ID_BANCO=@ID_BANCO", False, pars)
        End Function

        Public Function BuscarIdCuentaXNumeroCuenta(ByVal tipoCon As TipoConexion, ByVal nroCuenta As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_CUENTA_BANCOS", SqlDbType.NVarChar, nroCuenta})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCuentaXNumeroCuenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdCuentaXCodigoPlan(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO_PLAN_CUENTAS", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCuentaXCodigoPlan", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdBancoXIdCuenta(ByVal tipoCon As TipoConexion, ByVal idCuentaB As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CUENTA_BANCOS", SqlDbType.Int, idCuentaB})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdBancoXIdCuenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoPlanXIdCuenta(ByVal tipoCon As TipoConexion, ByVal idCuentaB As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CUENTA_BANCOS", SqlDbType.Int, idCuentaB})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoPlanXIdCuenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarComprobantesEgresoIngresoBancosXBancoCtaFecha(ByVal tipoCon As TipoConexion, ByVal idBancoRecibido As Integer, ByVal idCtaBancoRecibido As Integer, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal fechaBusquedaSaldo As DateTime, ByVal fechaBusquedaFinalSaldo As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BANCO", SqlDbType.Int, idBancoRecibido})
            pars.Add(New Object() {"ID_CUENTA_BANCOS", SqlDbType.Int, idCtaBancoRecibido})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            pars.Add(New Object() {"FECHA_INICIAL_SALDO", SqlDbType.DateTime, fechaBusquedaSaldo})
            pars.Add(New Object() {"FECHA_FINAL_SALDO", SqlDbType.DateTime, fechaBusquedaFinalSaldo})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarComprobantesEgresoIngresoBancosXBancoCtaFecha", True, pars)
        End Function

        Public Function NuevoRegistroCuentasBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroCuentasBancos"
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBancos
                .Parameters.AddWithValue("@NUMERO_CUENTA_BANCOS", SqlDbType.NVarChar).Value = NumeroCuentaBancos
                .Parameters.AddWithValue("@MONTO_CUENTA_BANCOS", SqlDbType.Decimal).Value = MontoCuentaBancos
                .Parameters.AddWithValue("@TIPO_CUENTA_BANCOS", SqlDbType.NVarChar).Value = TipoCuentaBancos
                .Parameters.AddWithValue("@ESTADO_CUENTA_BANCOS", SqlDbType.Int).Value = EstadoCuentaBancos
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@CODIGO_PLAN_CUENTAS", SqlDbType.NVarChar).Value = CodigoPlan
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarRestarMontoCuentasBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarRestarMontoCuentasBancos"
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBancos
                .Parameters.AddWithValue("@NUMERO_CUENTA_BANCOS", SqlDbType.NVarChar).Value = NumeroCuentaBancos
                .Parameters.AddWithValue("@MONTO_CUENTA_BANCOS", SqlDbType.Decimal).Value = MontoCuentaBancos
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarSumarMontoCuentasBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSumarMontoCuentasBancos"
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBancos
                .Parameters.AddWithValue("@NUMERO_CUENTA_BANCOS", SqlDbType.NVarChar).Value = NumeroCuentaBancos
                .Parameters.AddWithValue("@MONTO_CUENTA_BANCOS", SqlDbType.Decimal).Value = MontoCuentaBancos
            End With
            Return comando
        End Function

    End Class
End Namespace

