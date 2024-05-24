Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassComprobanteIngresoBanco
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public FechaComprobanteIngreso As DateTime
        Public NumeroFactura As String
        Public IdCliente As String
        Public ActividadComprobanteIngreso As String
        Public ConceptoComprobanteIngreso As String
        Public FormaPagoComprobanteIngreso As String
        Public ObservacionesComprobanteIngreso As String
        Public ValorComprobanteIngreso As Decimal
        Public NumeroDepositoComprobanteIngreso As String
        Public EstadoComprobanteIngreso As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdCentro As Integer
        Public IdBancos As Integer
        Public IdCuentaBancos As Integer

        Public Function SeleccionarComprobanteIngresoBancos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarComprobanteIngresoBancos", True)
        End Function

        Public Function BuscarMayorIdComprobanteIngresoBancos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteIngresoBancos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarComprobantesIngresoXIComprobanteIngreso(ByVal tipoCon As TipoConexion, ByVal parametroIdCompIngreso As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.VarChar, parametroIdCompIngreso})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesIngresoXIComprobanteIngreso", True, pars)
        End Function

        Public Function BuscarComprobantesIngresoXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesIngresoXRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesIngresoXIdBancoIdCuentaRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroIdBanco As Integer, ByVal parametroIdCuenta As Integer, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BANCO", SqlDbType.Int, parametroIdBanco})
            pars.Add(New Object() {"ID_CUENTA_BANCOS", SqlDbType.Int, parametroIdCuenta})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesIngresoXIdBancoIdCuentaRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesIngresoXIClienteRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroIdCliente As Integer, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroIdCliente})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesIngresoXIClienteRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesIngresoXConsorcioRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroConsorcio As String, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONSORCIO_CLIENTE_GENERAL", SqlDbType.Int, parametroConsorcio})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesIngresoXConsorcioRangoFecha", True, pars)
        End Function

        Public Function BuscarReporteComprobantesIngresoBancoXIdComprobanteNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idCiBanco As Integer, ByVal numeroRegistro As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt, idCiBanco})

            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "seleccionarComprobanteIngresoBancosXIdComprobante", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CLIENTE_GENERAL WHERE ESTADO_CLIENTE_GENERAL>0", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.BANCOS WHERE ESTADO_BANCO>=0", False)

            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CUENTAS_BANCOS WHERE ESTADO_CUENTA_BANCOS>=0", False)

            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_INGRESO WHERE ID_COMPROBANTE_INGRESO_BANCOS=" + idCiBanco.ToString, False)

            Dim asie = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE NUMERO_REGISTRO_ASIENTO=" + numeroRegistro.ToString + " order by DEBE_HABER", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "COMPROBANTE_INGRESO_BANCOS")
            empr.Fill(ds, "CLIENTE_GENERAL")
            sucu.Fill(ds, "BANCOS")
            area.Fill(ds, "CUENTAS_BANCOS")
            gere.Fill(ds, "NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_INGRESO")
            asie.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function

        Public Function NuevoRegistroComprobanteIngresoBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteIngresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE_INGRESO_BANCOS", SqlDbType.DateTime).Value = FechaComprobanteIngreso
                .Parameters.AddWithValue("@NUMERO_FACTURA_VENTA", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ACTIVIDAD_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ActividadComprobanteIngreso
                .Parameters.AddWithValue("@CONCEPTO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ConceptoComprobanteIngreso
                .Parameters.AddWithValue("@FORMA_PAGO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = FormaPagoComprobanteIngreso
                .Parameters.AddWithValue("@OBSERVACIONES_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ObservacionesComprobanteIngreso
                .Parameters.AddWithValue("@VALOR_COMPROBANTE_INGRESO_BANCOS", SqlDbType.Decimal).Value = ValorComprobanteIngreso
                .Parameters.AddWithValue("@NUMERO_DEPOSITO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = NumeroDepositoComprobanteIngreso
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_INGRESO_BANCO", SqlDbType.Int).Value = EstadoComprobanteIngreso
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentro
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBancos
            End With
            Return comando
        End Function
        Public Function NuevoRegistroComprobanteIngresoBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteIngresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE_INGRESO_BANCOS", SqlDbType.DateTime).Value = FechaComprobanteIngreso
                .Parameters.AddWithValue("@NUMERO_FACTURA_VENTA", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ACTIVIDAD_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ActividadComprobanteIngreso
                .Parameters.AddWithValue("@CONCEPTO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ConceptoComprobanteIngreso
                .Parameters.AddWithValue("@FORMA_PAGO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = FormaPagoComprobanteIngreso
                .Parameters.AddWithValue("@OBSERVACIONES_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = ObservacionesComprobanteIngreso
                .Parameters.AddWithValue("@VALOR_COMPROBANTE_INGRESO_BANCOS", SqlDbType.Decimal).Value = ValorComprobanteIngreso
                .Parameters.AddWithValue("@NUMERO_DEPOSITO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.NVarChar).Value = NumeroDepositoComprobanteIngreso
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_INGRESO_BANCO", SqlDbType.Int).Value = EstadoComprobanteIngreso
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentro
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBancos
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarEstadoComprobanteIngresoBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteIngresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_INGRESO_BANCOS", SqlDbType.Int).Value = EstadoComprobanteIngreso
            End With
            Return comando
        End Function

    End Class
End Namespace

