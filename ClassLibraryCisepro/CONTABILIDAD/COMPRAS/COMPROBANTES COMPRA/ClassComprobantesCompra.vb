Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
    Public Class ClassComprobantesCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobante As Int64
        Public IdProveedorGeneral As Integer
        Public TipoComprobante As String
        Public NumeroComprobante As String
        Public NumAutoSriComprobante As String
        Public FechaAutoSriComprobante As DateTime
        Public FechaEmisionComprobante As DateTime
        Public GuiaRemisionComprobante As String
        Public DocModComprobante As String
        Public RazModComprobante As String
        Public ObservacionComprobante As String
        Public Subtotal12Comprobante As Decimal
        Public Subtotal5Comprobante As Decimal
        Public Subtotal0Comprobante As Decimal
        Public DescuentoComprobante As Decimal
        Public SubtotalComprobante As Decimal
        Public PorcentajeIvaComprobante As Integer
        Public IvaComprobante As Decimal
        Public Iva5Comprobante As Decimal
        Public TotalComprobante As Decimal
        Public EstadoComprobante As Integer

        Public IdOrdenCompra As Int64

        Public Function BuscarMayorNumeroLiquidacionCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT	SECUENCIAL_LIQUIDACION_COMPRA = MAX(NUMERO_COMPROBANTE_COMPRA) FROM	comprobantes_compra  where tipo_comprobante_compra = 'LIQUIDACION DE COMPRA DE BIENES O PRESTACION DE SERVICIOS';", False)
            If data.Rows.Count = 0 Then Return 0
            Dim num As Integer
            Try
                num = CInt(CStr(data.Rows(0)(0)).Substring(5))
            Catch
                num = 0
            End Try
            Return num
        End Function

        Public Function BuscarMayorNumeroLiquidacionCompraIt(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT	MAX(SECUENCIAL_LIQUIDACION_COMPRA_IT) SECUENCIAL_LIQUIDACION_COMPRA_IT FROM INFORMACION_TRIBUTARIA", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarComrpobantesCompraXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesCompraXIdProveedor", True, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraXIdProveedorFecha(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal desde As Date, ByVal hasta As Date) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, parametroBusqueda})
            pars.Add(New Object() {"DESDE", SqlDbType.Date, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.Date, hasta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	* FROM	dbo.COMPROBANTES_COMPRA WHERE	ID_PROVEEDOR_GENERAL =	@ID_PROVEEDOR_GENERAL	AND TIPO_COMPROBANTE_COMPRA		<>	'CUENTAS X PAGAR'		AND ESTADO_COMPROBANTE_COMPRA	<>	0 and (fecha_emision_comprobante_compra between @DESDE and @HASTA);", False, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraImpagosXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesCompraImpagosXIdProveedor", True, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraActiosXIdProveedorRangoFechaComprobante(ByVal tipoCon As TipoConexion, ByVal parametroIdProveedor As Integer, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, parametroIdProveedor})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * from COMPROBANTES_COMPRA	WHERE ID_PROVEEDOR_GENERAL = @ID_PROVEEDOR_GENERAL AND ESTADO_COMPROBANTE_COMPRA = 1 and fecha_emision_comprobante_compra  between @FECHA_INICIAL and @FECHA_FINAL;", False, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraXIdProveedorYRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroIdProveedor As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, parametroIdProveedor})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesCompraXIdProveedorYRangoFechas", True, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraXEstadoYRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal parametroEstado As Integer) As DataTable
            Dim pars = New List(Of Object())

            Dim sql As String
            If parametroEstado > 9 Then
                sql = "SeleccionarComrpobantesCompraXEstadoYRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
                pars.Add(New Object() {"ESTADO_COMPROBANTE_COMPRA", SqlDbType.BigInt, parametroEstado})
            Else
                sql = "SeleccionarComrpobantesCompraXEstadoComprasYRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            End If
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, True, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraXRangoFechasIdProveedor(ByVal tipoCon As TipoConexion, ByVal IdProv As Integer, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR", SqlDbType.Int, IdProv})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesCompraXRangoFechasIdProveedor", True, pars)
        End Function

        Public Function SeleccionarComrpobantesCompraXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesCompraXRangoFechas", True, pars)
        End Function

        Public Function BuscarMayorIdComprobanteCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdProveedorXIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdProveedorXIdComprobanteCompra", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNumeroComprobanteXIdProveedorNumeroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroIdProveedor As Int64, ByVal parametroNumeroComprobante As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.Int, parametroIdProveedor})
            pars.Add(New Object() {"NUMERO_COMPROBANTE_COMPRA", SqlDbType.NVarChar, parametroNumeroComprobante})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNumeroComprobanteXIdProveedorNumeroComprobante", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function ModificarRegistroComprobanteCompra() As SqlCommand
            Dim comando As New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroComprobanteCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@TIPO_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = TipoComprobante
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = NumeroComprobante
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = NumAutoSriComprobante
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_COMPROBANTE_COMPRA", SqlDbType.DateTime).Value = FechaAutoSriComprobante
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_COMPRA", SqlDbType.DateTime).Value = FechaEmisionComprobante
                .Parameters.AddWithValue("@GUIA_REMISION_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = GuiaRemisionComprobante
                .Parameters.AddWithValue("@DOC_MOD_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = DocModComprobante
                .Parameters.AddWithValue("@RAZ_MOD_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = RazModComprobante
                .Parameters.AddWithValue("@OBSERVACION_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = ObservacionComprobante
                .Parameters.AddWithValue("@SUBTOTAL_12_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal12Comprobante
                .Parameters.AddWithValue("@SUBTOTAL_0_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal0Comprobante
                .Parameters.AddWithValue("@DESCUENTO_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = DescuentoComprobante
                .Parameters.AddWithValue("@SUBTOTAL_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SubtotalComprobante
                .Parameters.AddWithValue("@IVA_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = IvaComprobante
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = TotalComprobante
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoComprobante
                .Parameters.AddWithValue("@SUBTOTAL_5_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal5Comprobante
                .Parameters.AddWithValue("@IVA5_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Iva5Comprobante
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteCompras() As SqlCommand
            Dim comando As New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoComprobante
            End With
            Return comando
        End Function
        Public Function ActualizarEstadoComprobanteCompra(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando As New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoComprobante
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarEstadoPagosComprobanteCompras() As SqlCommand
            Dim comando As New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_COMPROBANTES_COMPRA set ESTADO_PAGOS_COMPROBANTE_COMPRA = @ESTADO_COMPROBANTE_COMPRA where ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoComprobante
            End With
            Return comando
        End Function

        Public Function SeleccionarComprobantesCompraXIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal idCompComp As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, idCompComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobantesCompraXIdComprobanteCompra", True, pars)
        End Function

        Public Function SeleccionarAsientoXIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal idCompComp As String) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from ASIENTOS_LIBRO_DIARIO where ESTADO_ASIENTO = 1 and DETALLE_TRANSACCION_ASIENTO like 'ID CC:%" & idCompComp & "%';", False)
        End Function

        Public Function SeleccionarPagosActivoXIdComprobante(ByVal tipoCon As TipoConexion, ByVal idCompComp As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, idCompComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from pagos_COMPROBANTES_COMPRA where id_COMPROBANTE_COMPRA = @ID_COMPROBANTE_COMPRA and estado_pagos_COMPROBANTE_COMPRA=1 order by id_pagos_COMPROBANTE_COMPRA desc;", False, pars)
        End Function

        Public Function SeleccionarComprobanteCompraXNumeroyAutorizacion(ByVal tipoCon As TipoConexion, ByVal numCompComp As String, ByVal numAutComp As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUM", SqlDbType.VarChar, numCompComp})
            pars.Add(New Object() {"AUT", SqlDbType.VarChar, numAutComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM COMPROBANTES_COMPRA WHERE NUMERO_COMPROBANTE_COMPRA = @NUM AND NUM_AUTO_SRI_COMPROBANTE_COMPRA =@AUT AND ESTADO_COMPROBANTE_COMPRA > 0", False, pars)
        End Function

        Public Function SeleccionarTotalSaldoComprobanteCompraXId(ByVal tipoCon As TipoConexion, ByVal idCompComp As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDC", SqlDbType.Int, idCompComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT C.TOTAL_COMPROBANTE_COMPRA, ((C.TOTAL_COMPROBANTE_COMPRA)-(SELECT	CASE WHEN SUM(R.TOTAL_COMPROBANTE_RETENCION_COMPRA)	IS NULL THEN 0 ELSE SUM(R.TOTAL_COMPROBANTE_RETENCION_COMPRA)	END FROM COMPROBANTE_RETENCION_COMPRA R	WHERE	R.ID_COMPROBANTE_COMPRA	 =	C.ID_COMPROBANTE_COMPRA  AND R.ESTADO_COMPROBANTE_RETENCION_COMPRA<>0))	PAGAR	FROM	COMPROBANTES_COMPRA C	WHERE	C.ID_COMPROBANTE_COMPRA	= @IDC", False, pars)
        End Function

        Public Function SeleccionarComprobanteCompraXIdComprobante(ByVal tipoCon As TipoConexion, ByVal idCompComp As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, idCompComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT c.*, p.CONTRIBUYENTE_ESPECIAL_PROVEEDOR_GENERAL	FROM	COMPROBANTES_COMPRA c join PROVEEDOR_GENERAL p on c.ID_PROVEEDOR_GENERAL = p.ID_PROVEEDOR_GENERAL WHERE	ID_COMPROBANTE_COMPRA	=	@ID_COMPROBANTE_COMPRA AND ESTADO_COMPROBANTE_COMPRA	>	0", False, pars)
        End Function

        Public Function BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idCompCompra As Integer, ByVal numeroRegistro As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarComprobanteCompraXIdComprobanteCompra", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVEEDOR_GENERAL WHERE	ESTADO_PROVEEDOR_GENERAL	<>	0", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.COMPROBANTE_RETENCION_COMPRA WHERE	ESTADO_COMPROBANTE_RETENCION_COMPRA	<>	0 AND ID_COMPROBANTE_COMPRA	=" & idCompCompra.ToString, False)

            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_RETENCION_COMPRA WHERE	ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA	<>	0 AND ID_COMPROBANTE_COMPRA	=" & idCompCompra.ToString, False)

            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_COMPRA WHERE ID_COMPROBANTE_COMPRA=" & idCompCompra.ToString, False)

            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE NUMERO_REGISTRO_ASIENTO=" & numeroRegistro.ToString, False)

            Dim ds = New DataSet()
            acts.Fill(ds, "COMPROBANTES_COMPRA")
            empr.Fill(ds, "PROVEEDOR_GENERAL")
            sucu.Fill(ds, "COMPROBANTE_RETENCION_COMPRA")
            area.Fill(ds, "DETALLE_COMPROBANTE_RETENCION_COMPRA")
            gere.Fill(ds, "NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_COMPRA")
            pers.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function

        Public Function BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro2(ByVal tipoCon As TipoConexion, ByVal idCompCompra As Integer, ByVal numeroRegistro As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarComprobanteCompraXIdComprobanteCompra", True, pars)

            Dim emprPars = New List(Of Object())
            emprPars.Add(New Object() {"ESTADO_PROVEEDOR_GENERAL", SqlDbType.Int, 0})
            Dim empr = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVEEDOR_GENERAL WHERE ESTADO_PROVEEDOR_GENERAL <> @ESTADO_PROVEEDOR_GENERAL", False, emprPars)

            Dim sucuPars = New List(Of Object())
            sucuPars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            sucuPars.Add(New Object() {"ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int, 0})
            Dim sucu = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM dbo.COMPROBANTE_RETENCION_COMPRA WHERE ESTADO_COMPROBANTE_RETENCION_COMPRA <> @ESTADO_COMPROBANTE_RETENCION_COMPRA AND ID_COMPROBANTE_COMPRA = @ID_COMPROBANTE_COMPRA", False, sucuPars)

            Dim areaPars = New List(Of Object())
            areaPars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            areaPars.Add(New Object() {"ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int, 0})
            Dim area = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_RETENCION_COMPRA WHERE ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA <> @ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA AND ID_COMPROBANTE_COMPRA = @ID_COMPROBANTE_COMPRA", False, areaPars)

            Dim gerePars = New List(Of Object())
            gerePars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            Dim gere = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM dbo.NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_COMPRA WHERE ID_COMPROBANTE_COMPRA = @ID_COMPROBANTE_COMPRA", False, gerePars)

            Dim persPars = New List(Of Object())
            persPars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt, numeroRegistro})
            Dim pers = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE NUMERO_REGISTRO_ASIENTO = @NUMERO_REGISTRO_ASIENTO", False, persPars)

            Dim ds = New DataSet()
            acts.Fill(ds, "COMPROBANTES_COMPRA")
            empr.Fill(ds, "PROVEEDOR_GENERAL")
            sucu.Fill(ds, "COMPROBANTE_RETENCION_COMPRA")
            area.Fill(ds, "DETALLE_COMPROBANTE_RETENCION_COMPRA")
            gere.Fill(ds, "NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_COMPRA")
            pers.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function

        Public Function IvaComprobanteTabla(ByVal tipoCon As TipoConexion, ByVal idCompCompra As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.BigInt, idCompCompra})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT COMPROBANTES_COMPRA.SUBTOTAL_5_COMPROBANTE_COMPRA, COMPROBANTES_COMPRA.IVA5_COMPROBANTE_COMPRA  FROM	COMPROBANTES_COMPRA WHERE	ID_COMPROBANTE_COMPRA	=	@ID_COMPROBANTE_COMPRA", False, pars)
        End Function

        Public Function NuevoRegistroComprobanteCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroComprobanteCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@TIPO_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = TipoComprobante
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = NumeroComprobante
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = NumAutoSriComprobante
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_COMPROBANTE_COMPRA", SqlDbType.DateTime).Value = FechaAutoSriComprobante
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_COMPRA", SqlDbType.DateTime).Value = FechaEmisionComprobante
                .Parameters.AddWithValue("@GUIA_REMISION_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = GuiaRemisionComprobante
                .Parameters.AddWithValue("@DOC_MOD_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = DocModComprobante
                .Parameters.AddWithValue("@RAZ_MOD_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = RazModComprobante
                .Parameters.AddWithValue("@OBSERVACION_COMPROBANTE_COMPRA", SqlDbType.NVarChar).Value = ObservacionComprobante
                .Parameters.AddWithValue("@SUBTOTAL_12_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal12Comprobante
                .Parameters.AddWithValue("@SUBTOTAL_0_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal0Comprobante
                .Parameters.AddWithValue("@DESCUENTO_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = DescuentoComprobante
                .Parameters.AddWithValue("@SUBTOTAL_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SubtotalComprobante
                .Parameters.AddWithValue("@PORCENTAJE_IVA_COMPROBANTE_COMPRA", SqlDbType.Int).Value = PorcentajeIvaComprobante
                .Parameters.AddWithValue("@IVA_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = IvaComprobante
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = TotalComprobante
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoComprobante
                .Parameters.AddWithValue("@SUBTOTAL_5_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Subtotal5Comprobante
                .Parameters.AddWithValue("@IVA5_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = Iva5Comprobante
            End With
            Return comando
        End Function

        Public Function NuevoDetalleOrdenComprobanteCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DETALLE_ORDEN_COMPROBANTE_COMPRA VALUES (@ID_ORDEN_COMPRA, @ID_COMPROBANTE_COMPRA, @ID_COMPROBANTE_INGRESO) "
                .Parameters.AddWithValue("@ID_ORDEN_COMPRA", SqlDbType.BigInt).Value = IdOrdenCompra
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO", SqlDbType.BigInt).Value = 0
            End With
            Return comando
        End Function

        Public Function SeleccionarComrpobantesCompraXParametrosNew(ByVal tipoCon As TipoConexion, ByVal IdProveedor As String, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime, ByVal Estado As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, FechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, FechaFinal})

            Dim esta = If(Estado = 0, "cc.ESTADO_COMPROBANTE_COMPRA > 0", "cc.ESTADO_COMPROBANTE_COMPRA = " & Estado)
            Dim prove = If(IdProveedor = 0, String.Empty, "and CC.id_proveedor_general= " & IdProveedor)

            '"cc.SUBTOTAL_12_COMPROBANTE_COMPRA AS 'SUBTOTAL 12%', cc.SUBTOTAL_0_COMPROBANTE_COMPRA AS 'SUBTOTAL  0%', " & _
            Dim sql = "select cc.ID_COMPROBANTE_COMPRA AS ID, pg.RAZON_SOCIAL_PROVEEDOR_GENERAL AS PROVEEDOR, " &
                    "cc.TIPO_COMPROBANTE_COMPRA AS TIPO, cc.NUMERO_COMPROBANTE_COMPRA AS NUMERO, cc.FECHA_EMISION_COMPROBANTE_COMPRA AS 'FECHA EMISION', " &
                    "cc.SUBTOTAL_12_COMPROBANTE_COMPRA AS 'SUBTOTAL IVA', cc.SUBTOTAL_5_COMPROBANTE_COMPRA AS 'SUBTOTAL IVA 5%',cc.SUBTOTAL_0_COMPROBANTE_COMPRA AS 'SUBTOTAL  0%',  " &
                    "cc.DESCUENTO_COMPROBANTE_COMPRA AS DESCUENTO, cc.SUBTOTAL_COMPROBANTE_COMPRA AS SUBTOTAL, cc.IVA_COMPROBANTE_COMPRA AS IVA, " &
                    "cc.IVA5_COMPROBANTE_COMPRA AS 'IVA 5', cc.TOTAL_COMPROBANTE_COMPRA	AS 'TOTAL', tt.codigo_detalle_comprobante_retencion_compra AS 'CODIGO',  tt.impuesto_detalle_comprobante_retencion_compra AS 'TIPO', " &
                    "tt.base_imponible_detalle_comprobante_retencion_compra AS 'BASE IMPONIBLE', tt.porcentaje_detalle_comprobante_retencion_compra AS 'PORCENTAJE', " &
                    "tt.valor_detalle_comprobante_retencion_compra AS 'VALOR', " &
                    "case when cr.total_comprobante_retencion_compra is null then 0 else cr.total_comprobante_retencion_compra  end as 'RETENCION', " &
                    "case when cr.total_comprobante_retencion_compra is null then cc.TOTAL_COMPROBANTE_COMPRA else (cc.TOTAL_COMPROBANTE_COMPRA-cr.TOTAL_COMPROBANTE_RETENCION_COMPRA ) end as 'TOTAL A PAGAR', " &
                    "cc.ESTADO_COMPROBANTE_COMPRA AS EST, case when nc.NUMERO_REGISTRO is null then 0 else nc.NUMERO_REGISTRO end as 'ASIENTO', cc.PORCENTAJE_IVA_COMPROBANTE_COMPRA as 'PORCENTAJE' " &
                    "from comprobantes_compra cc " &
                    "join proveedor_general pg on cc.id_proveedor_general=pg.id_proveedor_general " &
                    "left join NUMERO_REGISTRO_ASIENTOS_COMPROBANTE_COMPRA nc on cc.ID_COMPROBANTE_COMPRA=nc.ID_COMPROBANTE_COMPRA " &
                    "left join comprobante_retencion_compra cr on cc.id_comprObante_compra=cr.id_comprobante_compra " &
                    "left join (select det.id_comprobante_compra, det.codigo_detalle_comprobante_retencion_compra,  det.impuesto_detalle_comprobante_retencion_compra, det.base_imponible_detalle_comprobante_retencion_compra, " &
                    "det.porcentaje_detalle_comprobante_retencion_compra, det.valor_detalle_comprobante_retencion_compra " &
                    "from detalle_comprobante_retencion_compra det where det.estado_detalle_comprobante_retencion_compra > 0) tt on cc.id_comprobante_compra = tt.ID_COMPROBANTE_COMPRA " &
                    "where " & esta & prove & "AND cc.FECHA_EMISION_COMPROBANTE_COMPRA BETWEEN @FECHA_INICIAL AND @FECHA_FINAL " &
                    "ORDER BY CC.FECHA_EMISION_COMPROBANTE_COMPRA"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function



        Public Function SeleccionarProveedoresParaComprasngresoBodegaGrupo(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, String.Concat("%", filtro, "%")})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.razon_social_proveedor_general PROVEEDOR " & _
                                                                     "from comprobantes_compra c join proveedor_general p on c.id_proveedor_general = p.id_proveedor_general " & _
                                                                     "where c.estado_comprobante_compra=1 AND c.tipo_comprobante_compra = 'FACTURA' and c.fecha_emision_comprobante_compra > '2020-01-01 00:00:00' and " & _
                                                                     "(p.ruc_ci_proveedor_general like @FILTRO or p.razon_social_proveedor_general like @FILTRO) " & _
                                                                     "group by p.razon_social_proveedor_general", False, pars)
        End Function

        Public Function SeleccionarProveedoresParaComprasngresoBodegaDatos(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, String.Concat("%", filtro, "%")})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select c.id_comprobante_compra ID, p.razon_social_proveedor_general PROVEEDOR, c.numero_comprobante_compra NUMERO, " & _
                                                                     "c.fecha_emision_comprobante_compra FECHA, c.subtotal_comprobante_compra SUBTOTAL, c.iva_comprobante_compra IVA, c.total_comprobante_compra TOTAL, " & _
                                                                     "c.observacion_comprobante_compra OBSERVACION from comprobantes_compra c join proveedor_general p on c.id_proveedor_general = p.id_proveedor_general " & _
                                                                     "where c.estado_comprobante_compra=1 AND c.tipo_comprobante_compra = 'FACTURA' and c.fecha_emision_comprobante_compra > '2020-01-01 00:00:00' and " & _
                                                                     "(p.ruc_ci_proveedor_general like @FILTRO or p.razon_social_proveedor_general like @FILTRO) order by c.fecha_emision_comprobante_compra desc", False, pars)
        End Function

    End Class
End Namespace

