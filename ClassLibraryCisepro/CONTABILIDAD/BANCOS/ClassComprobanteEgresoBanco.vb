Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassComprobanteEgresoBanco
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public NumeroComprobante As Int64
        Public FechaComprobante As DateTime
        Public NumeroFactura As String
        Public RucCiReceptor As String
        Public NombreReceptor As String
        Public Actividad As String
        Public Concepto As String
        Public TipoPago As String
        Public Razon As String
        Public Valor As Decimal
        Public NumeroCheque As String
        Public Estado As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdCentroCosto As Integer
        Public IdBancos As Integer
        Public IdCuentaBanco As Integer

        Public Function SeleccionarOrdenadosComprobanteEgresoBancos(ByVal tipoCon As TipoConexion, ByVal dato As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTER", SqlDbType.VarChar, dato})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarOrdenadosComprobanteEgresoBancos", True, pars)
        End Function

        Public Function SeleccionarComprobanteEgresoBancosXNumeroCheque(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_CHEQUE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteEgresoBancosXNumeroCheque", True, pars)
        End Function

        Public Function SeleccionarComprobanteEgresoBancosPorFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteEgresoBancosPorFecha", True, pars)
        End Function

        Public Function BuscarComprobantesEgresoBancoXIdComprobanteEgreso(ByVal tipoCon As TipoConexion, ByVal idCompEgreso As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.Int, idCompEgreso})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarComprobantesEgresoBancoXIdComprobante", True, pars)
        End Function

        Public Function BuscarComprobantesEgresoXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal dato As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            pars.Add(New Object() {"FILTER", SqlDbType.VarChar, dato})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesEgresoXRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesEgresoEmitidosXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal dato As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            pars.Add(New Object() {"FILTER", SqlDbType.VarChar, dato})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesEgresoEmitidosXRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesEgresoAprobadosXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal dato As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            pars.Add(New Object() {"FILTER", SqlDbType.VarChar, dato})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesEgresoAprobadosXRangoFecha", True, pars)
        End Function

        Public Function BuscarComprobantesEgresoXIdBancoIdCuentaRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroIdBanco As Integer, ByVal parametroIdCuenta As Integer, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal dato As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BANCO", SqlDbType.Int, parametroIdBanco})
            pars.Add(New Object() {"ID_CUENTA_BANCOS", SqlDbType.Int, parametroIdCuenta})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            pars.Add(New Object() {"FILTER", SqlDbType.VarChar, dato})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarComprobantesEgresoXIdBancoIdCuentaRangoFecha", True, pars)
        End Function

        Public Function BuscarMayorIdComprobanteEgresoBancos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteEgresoBancos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroComprobanteEgresoBancos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroComprobanteEgresoBancos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarReporteComprobantesEgresoBancoXIdComprobanteNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idCeBanco As Integer, ByVal numeroRegistro As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt, idCeBanco})

            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarComprobantesEgresoBancoXIdComprobante", True, pars)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.BANCOS WHERE ESTADO_BANCO>=0", False)
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CUENTAS_BANCOS WHERE ESTADO_CUENTA_BANCOS>=0", False)
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_EGRESO WHERE ID_COMPROBANTE_EGRESO_BANCOS=" + idCeBanco.ToString, False)
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE NUMERO_REGISTRO_ASIENTO=" + numeroRegistro.ToString, False)

            Dim ds = New DataSet()
            acts.Fill(ds, "COMPROBANTE_EGRESO_BANCOS")
            empr.Fill(ds, "BANCOS")
            sucu.Fill(ds, "CUENTAS_BANCOS")
            area.Fill(ds, "NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_EGRESO")
            gere.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function

        Public Function BuscarReporteComprobantesEgresoBancoMachalaXIdComprobanteNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idCeBanco As Integer, ByVal numeroRegistro As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt, idCeBanco})

            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarComprobantesEgresoBancoXIdComprobante", True, pars)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CHEQUES_EMITIDOS WHERE ID_COMPROBANTE_EGRESO_BANCOS=" + idCeBanco.ToString, False)
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CUENTAS_BANCOS WHERE ESTADO_CUENTA_BANCOS=1", False)
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE NUMERO_REGISTRO_ASIENTO=" + numeroRegistro.ToString, False)

            Dim ds = New DataSet()
            acts.Fill(ds, "COMPROBANTE_EGRESO_BANCOS")
            empr.Fill(ds, "CHEQUES_EMITIDOS")
            sucu.Fill(ds, "CUENTAS_BANCOS")
            area.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function

        Public Function NuevoRegistroComprobanteEgresoBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteEgresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_EGRESOBANCOS", SqlDbType.BigInt).Value = NumeroComprobante
                .Parameters.AddWithValue("@FECHA_COMPROBANTE_EGRESO_BANCOS", SqlDbType.DateTime).Value = FechaComprobante
                .Parameters.AddWithValue("@NUMERO_FACTURA_RECEPTOR", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@RUC_CI_RECEPTOR", SqlDbType.NVarChar).Value = RucCiReceptor
                .Parameters.AddWithValue("@NOMBRE_RECEPTOR", SqlDbType.NVarChar).Value = NombreReceptor
                .Parameters.AddWithValue("@ACTIVIDAD", SqlDbType.NVarChar).Value = Actividad
                .Parameters.AddWithValue("@CONCEPTO", SqlDbType.NVarChar).Value = Concepto
                .Parameters.AddWithValue("@TIPO_PAGO_COMPROBANTE_EGRESO_BANCOS", SqlDbType.NVarChar).Value = TipoPago
                .Parameters.AddWithValue("@RAZON_COMPROBANTE_EGRESO_BANCOS", SqlDbType.NVarChar).Value = Razon
                .Parameters.AddWithValue("@VALOR_COMPROBANTE_EGRESO_BANCOS", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@NUMERO_CHEQUE", SqlDbType.NVarChar).Value = NumeroCheque
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_EGRESO_BANCO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBanco
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function NuevoRegistroComprobanteEgresoBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteEgresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_EGRESOBANCOS", SqlDbType.BigInt).Value = NumeroComprobante
                .Parameters.AddWithValue("@FECHA_COMPROBANTE_EGRESO_BANCOS", SqlDbType.DateTime).Value = FechaComprobante
                .Parameters.AddWithValue("@NUMERO_FACTURA_RECEPTOR", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@RUC_CI_RECEPTOR", SqlDbType.NVarChar).Value = RucCiReceptor
                .Parameters.AddWithValue("@NOMBRE_RECEPTOR", SqlDbType.NVarChar).Value = NombreReceptor
                .Parameters.AddWithValue("@ACTIVIDAD", SqlDbType.NVarChar).Value = Actividad
                .Parameters.AddWithValue("@CONCEPTO", SqlDbType.NVarChar).Value = Concepto
                .Parameters.AddWithValue("@TIPO_PAGO_COMPROBANTE_EGRESO_BANCOS", SqlDbType.NVarChar).Value = TipoPago
                .Parameters.AddWithValue("@RAZON_COMPROBANTE_EGRESO_BANCOS", SqlDbType.NVarChar).Value = Razon
                .Parameters.AddWithValue("@VALOR_COMPROBANTE_EGRESO_BANCOS", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@NUMERO_CHEQUE", SqlDbType.NVarChar).Value = NumeroCheque
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_EGRESO_BANCO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@ID_CUENTA_BANCOS", SqlDbType.Int).Value = IdCuentaBanco
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteEgresoBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteEgresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_EGRESO_BANCOS", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function ActualizarConceptoComprobanteEgresoBancos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarConceptoComprobanteEgresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CONCEPTO", SqlDbType.NVarChar).Value = Concepto
            End With
            Return comando
        End Function

        Public Function ActualizarConceptoComprobanteEgresoBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarConceptoComprobanteEgresoBancos"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CONCEPTO", SqlDbType.NVarChar).Value = Concepto
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

