Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.PLAN_DE_CUENTAS
    Public Class ClassPlanDeCuentas
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdPlan As Integer
        Public Codigo As String
        Public Detalle As String
        Public Nivel As Integer
        Public PadreCuentas As String
        Public Movimiento As String
        Public Presupuesto As String
        Public Tipo As String
        Public IdEmpresa As String
        Public Estado As Integer
        Public EstadoContable As Integer

        Public Function SeleccionarPlanCuentas(ByVal tipoCon As TipoConexion, ByVal todo As Boolean, ByVal tipo As Integer, ByVal fil As String) As DataTable
            Dim sql = If(todo, "SELECT id_plan, codigo, detalle, nivel, padre_cuenta, movimiento, tipo_cuenta, dbo.TipoCuenta(TIPO_CUENTA) tipo FROM PLAN_CUENTAS_GENERAL WHERE ESTADO = 1 AND (CODIGO LIKE '%" & fil & "%' OR DETALLE LIKE '%" & fil & "%') order by CODIGO;", "SELECT id_plan, codigo, detalle, nivel, padre_cuenta, movimiento, tipo_cuenta, dbo.TipoCuenta(TIPO_CUENTA) tipo FROM PLAN_CUENTAS_GENERAL WHERE TIPO_CUENTA = " & tipo & " AND ESTADO = 1 AND (CODIGO LIKE '%" & fil & "%' OR DETALLE LIKE '%" & fil & "%') order by CODIGO;")
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, False)
        End Function

        Public Function BuscarDetallesCuentaPorCodigo(ByVal tipoCon As TipoConexion, ByVal codigo As String) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM PLAN_CUENTAS_GENERAL WHERE CODIGO ='" & codigo & "'", False)
        End Function

        Public Function SeleccionarTodosLosRegistrosPlanDeCuentas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosPlanDeCuentas", True) 
        End Function

        Public Function SeleccionarTodosLosRegistrosPlanDeCuentasOrdenados(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosPlanDeCuentasOrdenados", True) 
        End Function

        Public Function SeleccionarCuentasYDetallePlanDeCuentas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCuentasYDetallePlanDeCuentas", True) 
        End Function

        Public Function SeleccionarCuentasActivoFijo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT CODIGO, CODIGO + ' - ' + DETALLE CUENTA FROM PLAN_CUENTAS_GENERAL wHERE CODIGO LIKE +'1020%' ORDER BY CODIGO ASC", False)
        End Function

        Public Function SeleccionarCuentasGastosFijo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT CODIGO, CODIGO + ' - ' + DETALLE CUENTA FROM PLAN_CUENTAS_GENERAL wHERE CODIGO LIKE +'52%'  ORDER BY CODIGO ASC", False)
        End Function

        Public Function SeleccionarCuentasDepreciacionesFijo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT CODIGO, CODIGO + ' - ' + DETALLE CUENTA FROM PLAN_CUENTAS_GENERAL wHERE CODIGO LIKE +'520219%'   ORDER BY CODIGO ASC", False)
        End Function

        Public Function SeleccionarCuentas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarCuentas", True) 
        End Function

        Public Function BuscarMayorIdPlan(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdPlan", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

      
        Public Function NuevaRegistroPlanDeCuentas(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaRegistroPlanDeCuentas"
                .Parameters.AddWithValue("@ID_PLAN", SqlDbType.Int).Value = idPlan
                .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = Codigo.Trim
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = Detalle.Trim
                .Parameters.AddWithValue("@NIVEL", SqlDbType.Int).Value = nivel
                .Parameters.AddWithValue("@PADRE_CUENTA", SqlDbType.NVarChar).Value = padreCuentas
                .Parameters.AddWithValue("@MOVIMIENTO", SqlDbType.NVarChar).Value = movimiento
                .Parameters.AddWithValue("@PRESUPUESTO", SqlDbType.NVarChar).Value = presupuesto
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.Int).Value = tipo
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = idEmpresa
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estado
                .Parameters.AddWithValue("@ESTADO_CONTABLE", SqlDbType.Int).Value = estadoContable
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ModificarRegistroPlanDeCuentas(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroPlanDeCuentas"
                .Parameters.AddWithValue("@ID_PLAN", SqlDbType.Int).Value = idPlan
                .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = Codigo.Trim
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = Detalle.Trim
                .Parameters.AddWithValue("@NIVEL", SqlDbType.Int).Value = nivel
                .Parameters.AddWithValue("@PADRE_CUENTA", SqlDbType.NVarChar).Value = padreCuentas
                .Parameters.AddWithValue("@MOVIMIENTO", SqlDbType.NVarChar).Value = movimiento
                .Parameters.AddWithValue("@PRESUPUESTO", SqlDbType.NVarChar).Value = presupuesto
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.Int).Value = tipo
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = idEmpresa
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estado
                .Parameters.AddWithValue("@ESTADO_CONTABLE", SqlDbType.Int).Value = estadoContable
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarCuentasOtrosGastos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCuentasOtrosGastos", True) 
        End Function
         
        Public Function BuscarCodigoPlanCuentasPorDetalle(ByVal tipoCon As TipoConexion, ByVal detalle As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.VarChar, detalle})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoPlanCuentasPorDetalle", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("CODIGO")))
        End Function

        Public Function BuscarNivelPlanCuentasPorCodigo(ByVal tipoCon As TipoConexion, ByVal codigo As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO", SqlDbType.VarChar, codigo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNivelPlanCuentasPorCodigo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdPlanCuentasPorDetalle(ByVal tipoCon As TipoConexion, ByVal detalle As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, detalle})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdPlanCuentasPorDetalle", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarDetallePlanCuentasXcodigo(ByVal tipoCon As TipoConexion, ByVal codigoPlan As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO", SqlDbType.VarChar, codigoPlan})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarDetallePlanCuentasXcodigo", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("DETALLE")))
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = SeleccionarCuentasYDetallePlanDeCuentas(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("RESULTADO")))
            Next
            Return coleccion
        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiario2(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarSaldosMayoresXFechaDiario2", True, pars)
        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiario(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSaldosMayoresXFechaDiario", True, pars) 
        End Function

        Public Function SeleccionarPlanCuentasVacioCuentasActivas(ByVal tipoCon As TipoConexion) As DataTable
            Dim pars = New List(Of Object())
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT PC.CODIGO, PC.DETALLE AS 'CUENTA', DEBE='0.0', HABER='0.0', SALDO='0.0', PC.NIVEL AS 'NIVEL', PC.PADRE_CUENTA AS 'PADRE', PC.MOVIMIENTO, PC.TIPO_CUENTA AS 'TIPO' FROM PLAN_CUENTAS_GENERAL PC WHERE PC.ESTADO = 1 ORDER BY PC.CODIGO;", False)
        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiarioMensual2(ByVal tipoCon As TipoConexion, ByVal anio As Integer) As DataTable 
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ANIO", SqlDbType.Int, anio})
            'Cambio 2023 
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarSaldosMayoresXFechaDiarioMensual2", True, pars)
            'Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT PC.CODIGO, PC.DETALLE AS 'CUENTA',AD.VALOR_DEBE_ASIENTO - AD.VALOR_HABER_ASIENTO AS INICIAL,'0.0' AS DEBE,'0.0' AS HABER,'0.0' AS SALDO, PC.NIVEL AS 'NIVEL', PC.PADRE_CUENTA AS 'PADRE' FROM PLAN_CUENTAS_GENERAL PC LEFT JOIN ASIENTOS_LIBRO_DIARIO AD ON AD.CODIGO_CUENTA_ASIENTO = PC.CODIGO AND AD.ESTADO_ASIENTO = 2 AND AD.CONCEPTO_ASIENTO = 'ESTADO SITUACION INICIAL ' + CONVERT(VARCHAR, @ANIO) WHERE(PC.ESTADO = 1) ORDER BY PC.CODIGO;", False, pars)
        End Function
          
        Public Function SeleccionarSaldosMayoresXFechaDiarioBalanceFinal2(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarSaldosMayoresXFechaDiarioBalanceFinal2", True, pars)

        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiarioBalanceFinal(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSaldosMayoresXFechaDiarioBalanceFinal", True, pars) 
        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual2(ByVal tipoCon As TipoConexion, ByVal anio As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ANIO", SqlDbType.Int, anio})
            'Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT PC.CODIGO, PC.DETALLE AS 'CUENTA',ABS(AD.VALOR_DEBE_ASIENTO - AD.VALOR_HABER_ASIENTO) AS INICIAL,'0.0' AS DEBE, '0.0' AS HABER,'0.0' AS SALDO,PC.NIVEL AS 'NIVEL',PC.PADRE_CUENTA AS 'PADRE'FROM PLAN_CUENTAS_GENERAL PC LEFT JOIN ASIENTOS_LIBRO_DIARIO AD ON AD.CODIGO_CUENTA_ASIENTO = PC.CODIGO AND AD.ESTADO_ASIENTO = 2 AND AD.CONCEPTO_ASIENTO = 'ESTADO SITUACION INICIAL ' + CONVERT(VARCHAR, @ANIO) WHERE PC.TIPO_CUENTA < 4 AND PC.ESTADO = 1 ORDER BY PC.CODIGO;", False, pars)
            'Cambio 2023 
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarSaldosMayoresXFechaDiarioMensual2", True, pars)
        End Function

        Public Function SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSaldosMayoresXFechaDiarioBalanceFinalMensual", True)
        End Function

        Public Function SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiario(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiario", True, pars)
        End Function

        Public Function SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiarioMensual(ByVal tipoCon As TipoConexion) As DataTable
            Dim pars = New List(Of Object())
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT PC.CODIGO, PC.DETALLE AS 'CUENTA', DEBE='0.0', HABER='0.0', SALDO='0.0', PC.NIVEL AS 'NIVEL', PC.PADRE_CUENTA AS 'PADRE', PC.MOVIMIENTO, PC.TIPO_CUENTA AS 'TIPO' FROM PLAN_CUENTAS_GENERAL PC WHERE PC.ESTADO = 1 ORDER BY PC.CODIGO;", False)
        End Function

        Public Function SeleccionarTodosLosRegistrosPlanDeCuentasxCodigo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"PARAMETRO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosPlanDeCuentasxCodigo", True, pars) 
        End Function


        Public Function SeleccionarTodosLosRegistrosPlanDeCuentasxDetalle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"PARAMETRO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosPlanDeCuentasxDetalle", True, pars) 
        End Function

        Public Function SeleccionarCuentasXRangoFechasXRangoCuentas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal parametroCuenta As String, ByVal esPadre As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            pars.Add(New Object() {"CUENTA", SqlDbType.VarChar, parametroCuenta})

            If esPadre Then
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ld.CODIGO_CUENTA_ASIENTO  AS 'CODIGO', ld.NOMBRE_CUENTA_ASIENTO AS 'CUENTA',	SUM(ld.VALOR_DEBE_ASIENTO)  AS 'DEBE', SUM(ld.VALOR_HABER_ASIENTO) AS 'HABER', pc.NIVEL AS 'NIVEL', pc.PADRE_CUENTA AS 'PADRE' FROM ASIENTOS_LIBRO_DIARIO ld JOIN PLAN_CUENTAS_GENERAL pc on ld.CODIGO_CUENTA_ASIENTO =pc.CODIGO WHERE ld.ESTADO_ASIENTO>0 and ld.FECHA_ASIENTO BETWEEN @FECHA_INICIAL AND @FECHA_FINAL AND pc.CODIGO like (@CUENTA+'%') GROUP BY ld.CODIGO_CUENTA_ASIENTO, ld.NOMBRE_CUENTA_ASIENTO, pc.NIVEL, pc.PADRE_CUENTA ORDER BY ld.CODIGO_CUENTA_ASIENTO;", False, pars)
            Else
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ld.CODIGO_CUENTA_ASIENTO  AS 'CODIGO', ld.NOMBRE_CUENTA_ASIENTO AS 'CUENTA',	SUM(ld.VALOR_DEBE_ASIENTO)  AS 'DEBE', SUM(ld.VALOR_HABER_ASIENTO) AS 'HABER', pc.NIVEL AS 'NIVEL', pc.PADRE_CUENTA AS 'PADRE' FROM ASIENTOS_LIBRO_DIARIO ld JOIN PLAN_CUENTAS_GENERAL pc on ld.CODIGO_CUENTA_ASIENTO =pc.CODIGO WHERE ld.ESTADO_ASIENTO>0 and ld.FECHA_ASIENTO BETWEEN @FECHA_INICIAL AND @FECHA_FINAL AND pc.CODIGO = @CUENTA GROUP BY ld.CODIGO_CUENTA_ASIENTO, ld.NOMBRE_CUENTA_ASIENTO, pc.NIVEL, pc.PADRE_CUENTA ORDER BY ld.CODIGO_CUENTA_ASIENTO;", False, pars)
            End If
        End Function

        Public Function SeleccionarCuentasXRangoFechasXRangoCuentasAsientos(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime, ByVal parametroCuenta As String, ByVal esPadre As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaBusquedaFinal})
            pars.Add(New Object() {"CUENTA", SqlDbType.VarChar, parametroCuenta})

            If esPadre Then
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ld.FECHA_ASIENTO			AS 'FECHA', ld.CODIGO_CUENTA_ASIENTO	AS 'CODIGO', ld.NOMBRE_CUENTA_ASIENTO	AS 'CUENTA', ld.VALOR_DEBE_ASIENTO AS 'DEBE', ld.VALOR_HABER_ASIENTO AS 'HABER', pc.NIVEL AS 'NIVEL', ld.NUMERO_REGISTRO_ASIENTO	AS 'ASIENTO', CHEQUE =	(SELECT	CASE WHEN	MAX(ce.NUMERO_CHEQUE) IS NULL	THEN '0'  ELSE	MAX(ce.NUMERO_CHEQUE) END	 FROM	COMPROBANTE_EGRESO_BANCOS ce join NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_EGRESO nr on ce.ID_COMPROBANTE_EGRESO_BANCOS = nr.ID_COMPROBANTE_EGRESO_BANCOS WHERE	nr.NUMERO_REGISTRO = ld.NUMERO_REGISTRO_ASIENTO	AND ce.ID_COMPROBANTE_EGRESO_BANCOS = nr.ID_COMPROBANTE_EGRESO_BANCOS), ld.DETALLE_TRANSACCION_ASIENTO	AS 'DETALLE', 0 AS 'SALDO' FROM ASIENTOS_LIBRO_DIARIO ld join PLAN_CUENTAS_GENERAL pc on ld.CODIGO_CUENTA_ASIENTO = pc.CODIGO WHERE pc.CODIGO like @CUENTA+'%' AND ld.ESTADO_ASIENTO >	0 AND ld.FECHA_ASIENTO BETWEEN @FECHA_INICIAL AND @FECHA_FINAL ORDER BY FECHA;", False, pars)
            Else
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ld.FECHA_ASIENTO			AS 'FECHA', ld.CODIGO_CUENTA_ASIENTO	AS 'CODIGO', ld.NOMBRE_CUENTA_ASIENTO	AS 'CUENTA', ld.VALOR_DEBE_ASIENTO AS 'DEBE', ld.VALOR_HABER_ASIENTO AS 'HABER', pc.NIVEL AS 'NIVEL', ld.NUMERO_REGISTRO_ASIENTO	AS 'ASIENTO', CHEQUE =	(SELECT	CASE WHEN	MAX(ce.NUMERO_CHEQUE) IS NULL	THEN '0'  ELSE	MAX(ce.NUMERO_CHEQUE) END	 FROM	COMPROBANTE_EGRESO_BANCOS ce join NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_EGRESO nr on ce.ID_COMPROBANTE_EGRESO_BANCOS = nr.ID_COMPROBANTE_EGRESO_BANCOS WHERE	nr.NUMERO_REGISTRO = ld.NUMERO_REGISTRO_ASIENTO	AND ce.ID_COMPROBANTE_EGRESO_BANCOS = nr.ID_COMPROBANTE_EGRESO_BANCOS), ld.DETALLE_TRANSACCION_ASIENTO	AS 'DETALLE', 0 AS 'SALDO' FROM ASIENTOS_LIBRO_DIARIO ld join PLAN_CUENTAS_GENERAL pc on ld.CODIGO_CUENTA_ASIENTO = pc.CODIGO WHERE pc.CODIGO =	@CUENTA AND ld.ESTADO_ASIENTO >	0 AND ld.FECHA_ASIENTO BETWEEN @FECHA_INICIAL AND @FECHA_FINAL ORDER BY FECHA;", False, pars)
            End If
        End Function

        Public Function SeleccionarBalnceFinalComparativoDinamico(ByVal tipoCon As TipoConexion, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime, ByVal RangoBusqueda As String, ByVal OrdenColumns As String, ByVal chkAnterior As Boolean, ByVal chkPrevio As Boolean, cambio As Boolean, variacion As Boolean) As DataTable
            Dim pars = New List(Of Object())

            Dim chkAnteriorInt As Integer = If(chkAnterior, 1, 0)
            Dim chkPrevioInt As Integer = If(chkPrevio, 1, 0)
            Dim cambioInt As Integer = If(cambio, 1, 0)
            Dim variacionInt As Integer = If(variacion, 1, 0)

            pars.Add(New Object() {"@FechaInicio", SqlDbType.DateTime, FechaInicial})
            pars.Add(New Object() {"@FechaFin", SqlDbType.DateTime, FechaFinal})
            pars.Add(New Object() {"@RangoBusqueda", SqlDbType.VarChar, RangoBusqueda})
            pars.Add(New Object() {"@OrdenColumns", SqlDbType.VarChar, OrdenColumns})
            pars.Add(New Object() {"@chkAnterior", SqlDbType.Bit, chkAnteriorInt})
            pars.Add(New Object() {"@chkPrevio", SqlDbType.Bit, chkPrevioInt})
            pars.Add(New Object() {"@chkCambio", SqlDbType.Bit, cambioInt})
            pars.Add(New Object() {"@chkVariacion", SqlDbType.Bit, variacionInt})


            Dim tabla = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarBalanceFinalComparativo", True, pars)

            Return tabla
        End Function


    End Class
End Namespace

