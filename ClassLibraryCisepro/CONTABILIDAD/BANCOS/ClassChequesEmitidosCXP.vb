Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassChequesEmitidosCxp
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCheque As Int64
        Public FechaEmisionCheque As DateTime
        Public BancoCheque As String
        Public CtaCteCheque As String
        Public NumeroCheque As Integer
        Public BeneficiarioCheque As String
        Public ValorCheque As Decimal
        Public EstadoCheque As Integer
        Public FechaCobro As DateTime
        Public IdComprobante As Int64

        Public Function ExisteNumChequeEmitido(ByVal tipoCon As TipoConexion, ByVal num As Long, ByVal ban As String, ByVal cue As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUM", SqlDbType.BigInt, num})
            pars.Add(New Object() {"BAN", SqlDbType.VarChar, ban})
            pars.Add(New Object() {"CUE", SqlDbType.VarChar, cue})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from cheques_emitidos where numero_cheque_emitido = @NUM and banco_cheque_emitido = @BAN and cta_cte_cheque_emitido = @CUE and  estado_cheque_emitido=1;", False, pars)
            Return data.Rows.Count <> 0 AndAlso Not IsDBNull(data.Rows(0)(0))
        End Function

        Public Function SeleccionarChequeEmitidoXIdComprobanteEgreso(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.VarChar, parametroBusqueda})
            Dim obje = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarComprobantesEgresoBancoXIdComprobante", True, pars)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CHEQUES_EMITIDOS", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES=1", False)

            Dim ds = New DataSet()
            obje.Fill(ds, "COMPROBANTE_EGRESO_BANCOS")
            acti.Fill(ds, "CHEQUES_EMITIDOS")
            empr.Fill(ds, "CIUDADES")
            Return ds
        End Function

        Public Function BuscarMayorIdChequeEmitidoCxp(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdChequeEmitidoCXP", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarBancoXNumeroChequeEmitido(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_CHEQUE_EMITIDO", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarBancoXNumeroChequeEmitido", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarChequesEmitidosNoCobradosXRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaDesde})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaHasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarChequesEmitidosNoCobradosXRangoFecha", True, pars)
        End Function

        Public Function BuscarChequesEmitidosNoCobradosXRangoFechaMin(ByVal tipoCon As TipoConexion, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal ban As String, ByVal cuentaCheque As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaDesde})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaHasta})
            pars.Add(New Object() {"BANCO_CHEQUE_EMITIDO", SqlDbType.VarChar, ban})
            pars.Add(New Object() {"CUENTA_CHEQUE_EMITIDO", SqlDbType.VarChar, cuentaCheque})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarChequesEmitidosNoCobradosXRangoFechaMin", True, pars)
        End Function

        Public Function BuscarChequesEmitidosCobradosXRangoFechaCobro(ByVal tipoCon As TipoConexion, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaDesde})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaHasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarChequesEmitidosCobradosXRangoFechaCobro", True, pars)
        End Function

        Public Function BuscarChequesEmitidosCobradosXRangoFechaCobroMin(ByVal tipoCon As TipoConexion, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal ban As String, ByVal cuentaCheque As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaDesde})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaHasta})
            pars.Add(New Object() {"BANCO_CHEQUE_EMITIDO", SqlDbType.VarChar, ban})
            pars.Add(New Object() {"CUENTA_CHEQUE_EMITIDO", SqlDbType.VarChar, cuentaCheque})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarChequesEmitidosCobradosXRangoFechaCobroMin", True, pars)
        End Function

        Public Function BuscarChequesEmitidosCaducadosXRangoFechaCobro(ByVal tipoCon As TipoConexion, ByVal fechaDesde As DateTime, ByVal fechaHasta As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaDesde})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaHasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarChequesEmitidosCaducadosXRangoFechaCobro", True, pars)
        End Function

        Public Function NuevoRegistroChequeEmitidoCxp() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroChequeEmitidoCXP"
                .Parameters.AddWithValue("@ID_CHEQUE_EMITIDO", SqlDbType.BigInt).Value = IdCheque
                .Parameters.AddWithValue("@FECHA_EMISION_CHEQUE_EMITIDO", SqlDbType.DateTime).Value = FechaEmisionCheque
                .Parameters.AddWithValue("@BANCO_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = BancoCheque
                .Parameters.AddWithValue("@CTA_CTE_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = CtaCteCheque
                .Parameters.AddWithValue("@NUMERO_CHEQUE_EMITIDO", SqlDbType.Int).Value = NumeroCheque
                .Parameters.AddWithValue("@BENEFICIARIO_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = BeneficiarioCheque
                .Parameters.AddWithValue("@VALOR_CHEQUE_EMITIDO", SqlDbType.Decimal).Value = ValorCheque
                .Parameters.AddWithValue("@ESTADO_CHEQUE_EMITIDO", SqlDbType.Int).Value = EstadoCheque
                .Parameters.AddWithValue("@FECHA_COBRO_CHEQUE_EMITIDO", SqlDbType.Int).Value = FechaCobro
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return comando
        End Function
        Public Function NuevoRegistroChequeEmitidoCxp(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroChequeEmitidoCXP"
                .Parameters.AddWithValue("@ID_CHEQUE_EMITIDO", SqlDbType.BigInt).Value = IdCheque
                .Parameters.AddWithValue("@FECHA_EMISION_CHEQUE_EMITIDO", SqlDbType.DateTime).Value = FechaEmisionCheque
                .Parameters.AddWithValue("@BANCO_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = BancoCheque
                .Parameters.AddWithValue("@CTA_CTE_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = CtaCteCheque
                .Parameters.AddWithValue("@NUMERO_CHEQUE_EMITIDO", SqlDbType.Int).Value = NumeroCheque
                .Parameters.AddWithValue("@BENEFICIARIO_CHEQUE_EMITIDO", SqlDbType.NVarChar).Value = BeneficiarioCheque
                .Parameters.AddWithValue("@VALOR_CHEQUE_EMITIDO", SqlDbType.Decimal).Value = ValorCheque
                .Parameters.AddWithValue("@ESTADO_CHEQUE_EMITIDO", SqlDbType.Int).Value = EstadoCheque
                .Parameters.AddWithValue("@FECHA_COBRO_CHEQUE_EMITIDO", SqlDbType.Int).Value = FechaCobro
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarEstadoChequesEmitidos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoChequesEmitidos"
                .Parameters.AddWithValue("@ID_CHEQUE_EMTIDO", SqlDbType.BigInt).Value = IdCheque
                .Parameters.AddWithValue("@FECHA_COBRO_CHEQUE_EMITIDO", SqlDbType.DateTime).Value = FechaCobro
                .Parameters.AddWithValue("@ESTADO_CHEQUE_EMITIDO", SqlDbType.Int).Value = EstadoCheque
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarEstadoChequesEmitidosXIdComprobanteEgreso() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoChequesEmitidosXIdComprobanteEgreso"
                .Parameters.AddWithValue("@ESTADO_CHEQUE_EMITIDO", SqlDbType.Int).Value = EstadoCheque
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return comando
        End Function
        Public Function ActualizarEstadoChequesEmitidosXIdComprobanteEgreso(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoChequesEmitidosXIdComprobanteEgreso"
                .Parameters.AddWithValue("@ESTADO_CHEQUE_EMITIDO", SqlDbType.Int).Value = EstadoCheque
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

