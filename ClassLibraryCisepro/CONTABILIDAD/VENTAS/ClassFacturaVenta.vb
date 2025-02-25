Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassFacturaVenta
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdFactura As Int64
        Public IdEmpresa As Integer
        Public NumeroFactura As String
        Public FechaEmisionFactura As DateTime
        Public PlazoFactura As DateTime
        Public GuiaRemisionFactura As String
        Public IdCliente As Int64
        Public TipoPagoFactura As String
        Public ConceptoFactura As String
        Public ObservacionesFactura As String
        Public SubTotal12Factura As Decimal
        Public SubTotal0Factura As Decimal
        Public DescuentoFactura As Decimal
        Public SubTotalFactura As Decimal
        Public PorcentajeIvaFactura As Integer
        Public IvaFactura As Decimal
        Public TotalFactura As Decimal
        Public EstadoFactura As Decimal
        Public IdConvenio As Int64

        Public Function SeleccionarFacturaVentaXIdCliente(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturaVentaXIdCliente", True, pars)
        End Function
        Public Function SeleccionarFacturaVentaXIdClienteFecha(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroBusqueda})
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	ID_FACTURA_VENTA AS	ID, ID_EMPRESA_GENERAL					AS	ID_E, NUMERO_FACTURA_VENTA				AS	NUMERO, FECHA_EMISION_FACTURA_VENTA			AS	FECHA, GUIA_REMISION_FACTURA_VENTA			AS	GUIA_REMISION, ID_CLIENTE_GENERAL					AS	CLIENTE, TIPO_PAGO_FACTURA_VENTA				AS	TIPO_PAGO, OBSERVACIONES_FACTURA_VENTA			AS	OBSERVACIONES, SUBTOTAL_12_FACTURA_VENTA			AS	SUBTOTAL_12, SUBTOTAL_0_FACTURA_VENTA			AS	SUBTOTAL_0, DESCUENTO_FACTURA_VENTA				AS	DESCUENTO, SUBTOTAL_FACTURA_VENTA				AS	SUBTOTAL, IVA_FACTURA_VENTA					AS	IVA, TOTAL_FACTURA_VENTA					AS	TOTAL, ESTADO_FACTURA_VENTA				AS	EST FROM	dbo.FACTURA_VENTA WHERE	ID_CLIENTE_GENERAL		=	@ID_CLIENTE_GENERAL	and ESTADO_FACTURA_VENTA	>	0	and FECHA_EMISION_FACTURA_VENTA between @DESDE and @HASTA;", False, pars)
        End Function


        Public Function SeleccionarFacturaVentaImpagasXIdCliente(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturaVentaImpagasXIdCliente", True, pars)
        End Function

        Public Function SeleccionarFacturaVentaImpagasGeneralXIdCliente(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturaVentaImpagasGeneralXIdCliente", True, pars)
        End Function

        Public Function SeleccionarFacturaVentaXNumeroFactura(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturaVentaXNumeroFactura", True, pars)
        End Function

        Public Function SeleccionarFacturasVentaXParametros(ByVal tipoCon As TipoConexion, ByVal parametroIdCliente As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal parametroEstado As Integer) As DataTable
            Dim pars = New List(Of Object())
            Dim sql = String.Empty
            If parametroIdCliente > 0 And parametroEstado < 3 Then
                sql = "SeleccionarFacturasVentaXParametros"
                pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.BigInt, parametroIdCliente})
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
                pars.Add(New Object() {"ESTADO_FACTURA_VENTA", SqlDbType.BigInt, parametroEstado})
            ElseIf parametroIdCliente > 0 And parametroEstado = 3 Then
                sql = "SeleccionarFacturasVentaXIdClienteYRangoFechas"
                pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.BigInt, parametroIdCliente})
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            ElseIf parametroIdCliente = 0 And parametroEstado < 3 Then
                sql = "SeleccionarFacturasVentaXEstadoYRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
                pars.Add(New Object() {"ESTADO_FACTURA_VENTA", SqlDbType.BigInt, parametroEstado})
            ElseIf parametroIdCliente = 0 And parametroEstado = 3 Then
                sql = "SeleccionarFacturasVentaXRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            End If

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, True, pars)
        End Function

        Public Function BuscarFacturaVentaXIdClienteRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroIdCliente As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroIdCliente})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturasVentaXIdClienteYRangoFechas", True, pars)
        End Function

        Public Function BuscarFacturaVentaXIdClienteConceptoRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroIdCliente As String, ByVal parametroConcepto As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, parametroIdCliente})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            pars.Add(New Object() {"CONCEPTO_FACTURA_VENTA", SqlDbType.NVarChar, parametroConcepto})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarFacturaVentaXIdClienteConceptoRangoFecha", True, pars)
        End Function

        Public Function BuscarFacturaVentaXConsorcioRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroConsorcio As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONSORCIO_CLIENTE_GENERAL", SqlDbType.Int, parametroConsorcio})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarFacturaVentaXConsorcioRangoFecha", True, pars)
        End Function

        Public Function BuscarFacturaVentasXConceptoRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroConcepto As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONCEPTO_FACTURA_VENTA", SqlDbType.Int, parametroConcepto})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarFacturaVentaXConceptoRangoFecha", True, pars)
        End Function

        Public Function SeleccionarFacturasVentaRevisionXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal parametroFechaInicialAnte As DateTime, ByVal parametroFechaFinalAnte As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL_ANTE", SqlDbType.Int, parametroFechaInicialAnte})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            pars.Add(New Object() {"FECHA_FINAL_ANTE", SqlDbType.NVarChar, parametroFechaFinalAnte})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarFacturasVentaRevisionXRangoFechas", True, pars)
        End Function

        Public Function SeleccionarRegistrosFacturaVentaReporte(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.BigInt, parametroBusqueda})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarRegistrosFacturaVentaXIdFacturaVentaReporte", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_FACTURA_VENTA WHERE ESTADO_DETALLE_FACTURA_VENTA = 1", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM WHERE ESTADO_SECUENCIAL_ITEM = 1", False)

            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CLIENTE_GENERAL", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "FACTURA_VENTA")
            empr.Fill(ds, "DETALLE_FACTURA_VENTA")
            sucu.Fill(ds, "SECUENCIAL_ITEM")
            area.Fill(ds, "CLIENTE_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarRegistrosReporteVentas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal parametroEstado As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            pars.Add(New Object() {"ESTADO_FACTURA_VENTA", SqlDbType.BigInt, parametroEstado})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarFacturasVentaReporteXEstadoYRangoFechas", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CLIENTE_GENERAL", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "FACTURA_VENTA")
            empr.Fill(ds, "CLIENTE_GENERAL")
            Return ds
        End Function

        Public Function BuscarMayorIdFacturaVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdFacturaVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroFacturaVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroFacturaVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroFacturaVentaIt(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroFacturaVentaIT", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroFacturaVentaIt3(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_BuscarMayorNumeroFacturaVentaIT3", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroFacturaVentaIt4(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_BuscarMayorNumeroFacturaVentaIT4", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarTotalFacturaVentaXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarTotalFacturaVentaXRangoFechas", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdFacturaVentaXNumeroFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdFacturaVentaXNumeroFacturaVenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNumeroFacturaVentaXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNumeroFacturaVentaXIdFacturaVenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdClienteXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdClienteXIdFacturaVenta", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Private Function BuscarConceptoFacturaVenta(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarConceptoFacturaVenta", True)
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarConceptoFacturaVenta(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("CONCEPTO_FACTURA_VENTA")))
            Next
            Return coleccion
        End Function

        Public Function NuevoRegistroFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroFacturaVenta"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ID_EMPRESA_GENERAL", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@NUMERO_FACTURA_VENTA", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@FECHA_EMISION_FACTURA_VENTA", SqlDbType.DateTime).Value = FechaEmisionFactura
                .Parameters.AddWithValue("@GUIA_REMISION_FACTURA_VENTA", SqlDbType.NVarChar).Value = GuiaRemisionFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@TIPO_PAGO_FACTURA_VENTA", SqlDbType.NVarChar).Value = TipoPagoFactura
                .Parameters.AddWithValue("@CONCEPTO_FACTURA_VENTA", SqlDbType.NVarChar).Value = ConceptoFactura
                .Parameters.AddWithValue("@OBSERVACIONES_FACTURA_VENTA", SqlDbType.NVarChar).Value = ObservacionesFactura
                .Parameters.AddWithValue("@SUBTOTAL_12_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotal12Factura
                .Parameters.AddWithValue("@SUBTOTAL_0_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotal0Factura
                .Parameters.AddWithValue("@DESCUENTO_FACTURA_VENTA", SqlDbType.Decimal).Value = DescuentoFactura
                .Parameters.AddWithValue("@SUBTOTAL_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotalFactura
                .Parameters.AddWithValue("@PORCENTAJE_IVA_FACTURA_VENTA", SqlDbType.Decimal).Value = PorcentajeIvaFactura
                .Parameters.AddWithValue("@IVA_FACTURA_VENTA", SqlDbType.Decimal).Value = IvaFactura
                .Parameters.AddWithValue("@TOTAL_FACTURA_VENTA", SqlDbType.Decimal).Value = TotalFactura
                .Parameters.AddWithValue("@ESTADO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoFactura
                .Parameters.AddWithValue("@PLAZO_FACTURA_VENTA", SqlDbType.DateTime).Value = PlazoFactura
            End With
            Return comando
        End Function

        Public Function NuevoRegistroFacturaVentaConvenio() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into factura_debito_convenio values (@id_factura, @id_convenio);"
                .Parameters.AddWithValue("@id_factura", SqlDbType.Int).Value = IdFactura
                .Parameters.AddWithValue("@id_convenio", SqlDbType.Int).Value = IdConvenio
            End With
            Return comando
        End Function

        Public Function ModificarRegistroFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroFacturaVenta"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ID_EMPRESA_GENERAL", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@NUMERO_FACTURA_VENTA", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@FECHA_EMISION_FACTURA_VENTA", SqlDbType.DateTime).Value = FechaEmisionFactura
                .Parameters.AddWithValue("@GUIA_REMISION_FACTURA_VENTA", SqlDbType.NVarChar).Value = GuiaRemisionFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@TIPO_PAGO_FACTURA_VENTA", SqlDbType.NVarChar).Value = TipoPagoFactura
                .Parameters.AddWithValue("@CONCEPTO_FACTURA_VENTA", SqlDbType.NVarChar).Value = ConceptoFactura
                .Parameters.AddWithValue("@OBSERVACIONES_FACTURA_VENTA", SqlDbType.NVarChar).Value = ObservacionesFactura
                .Parameters.AddWithValue("@SUBTOTAL_12_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotal12Factura
                .Parameters.AddWithValue("@SUBTOTAL_0_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotal0Factura
                .Parameters.AddWithValue("@DESCUENTO_FACTURA_VENTA", SqlDbType.Decimal).Value = DescuentoFactura
                .Parameters.AddWithValue("@SUBTOTAL_FACTURA_VENTA", SqlDbType.Decimal).Value = SubTotalFactura
                .Parameters.AddWithValue("@PORCENTAJE_IVA_FACTURA_VENTA", SqlDbType.Decimal).Value = PorcentajeIvaFactura
                .Parameters.AddWithValue("@IVA_FACTURA_VENTA", SqlDbType.Decimal).Value = IvaFactura
                .Parameters.AddWithValue("@TOTAL_FACTURA_VENTA", SqlDbType.Decimal).Value = TotalFactura
                .Parameters.AddWithValue("@ESTADO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoFactura
                .Parameters.AddWithValue("@PLAZO_FACTURA_VENTA", SqlDbType.DateTime).Value = PlazoFactura
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoFacturaVenta"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ESTADO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoFactura
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoFacturaVenta(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoFacturaVenta"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ESTADO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoFactura
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarVentasXFechaAuxiliar(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarVentasXFechaAuxiliar", True, pars)
        End Function


        Public Function SeleccionarComrpobantesRetencionXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	*	FROM	dbo.COMPROBANTE_RETENCION_VENTA	WHERE	ID_FACTURA_VENTA  = @ID_FACTURA AND ESTADO_COMPROBANTE_RETENCION_VENTA <> 0", False, pars)
        End Function

        Public Function SeleccionarRegistrosDetalleComprobanteRetencionCompraXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta", True, pars)
        End Function

    End Class
End Namespace

