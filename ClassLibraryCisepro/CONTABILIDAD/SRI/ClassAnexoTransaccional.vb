Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.SRI
    Public Class ClassAnexoTransaccional
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Periodo As DateTime
        Public ComprasFacturas As String
        Public ComprasNotasVenta As String
        Public ComprasNotasCredito As String
        Public ComprasLiquidaciones As String
        Public VentasNotasCredito As String
        Public VentasFacturas As String
        Public RetencionesCompras As String
        Public FechaCreacion As DateTime
        Public Estado As String

        Public Function NuevoRegistroAts(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroATS"
                .Parameters.AddWithValue("@PERIODO_ATS", SqlDbType.DateTime).Value = Periodo
                .Parameters.AddWithValue("@COMPRAS_FACTURAS_ATS", SqlDbType.NVarChar).Value = ComprasFacturas
                .Parameters.AddWithValue("@COMPRAS_NOTAS_VENTA_ATS", SqlDbType.NVarChar).Value = ComprasNotasVenta
                .Parameters.AddWithValue("@COMPRAS_NOTAS_CREDITO_ATS", SqlDbType.NVarChar).Value = ComprasNotasCredito
                .Parameters.AddWithValue("@COMPRAS_LIQUIDACIONES_ATS", SqlDbType.NVarChar).Value = ComprasLiquidaciones
                .Parameters.AddWithValue("@VENTAS_NOTAS_CREDITO_ATS", SqlDbType.NVarChar).Value = VentasNotasCredito
                .Parameters.AddWithValue("@VENTAS_FACTURAS_ATS", SqlDbType.NVarChar).Value = VentasFacturas
                .Parameters.AddWithValue("@RETENCIONES_COMPRAS_ATS", SqlDbType.NVarChar).Value = RetencionesCompras
                .Parameters.AddWithValue("@FECHA_CREACION_ATS", SqlDbType.DateTime).Value = FechaCreacion
                .Parameters.AddWithValue("@ESTADO_ATS", SqlDbType.Int).Value = Estado
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Private Function BuscarAtsxRangoFechaDeclaracion(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarATSXRangoFechaDeclaracion", True, pars)
        End Function

        Public Function ValidarCompraConDeclaracion(ByVal tipoCon As TipoConexion, ByVal fechaCompra As DateTime) As Boolean
            Dim fechaFinal As String
            Dim fechaInicial = "01-" & fechaCompra.Month.ToString & "-" & fechaCompra.Year.ToString & " 00:00:00.001"
            If fechaCompra.Month = 2 Then
                fechaFinal = "28-" & fechaCompra.Month.ToString & "-" & fechaCompra.Year.ToString & " 23:59:59.000"
            Else
                fechaFinal = "30-" & fechaCompra.Month.ToString & "-" & fechaCompra.Year.ToString & " 23:59:59.000"
            End If
            Return BuscarAtsxRangoFechaDeclaracion(tipoCon, fechaInicial, fechaFinal).Rows.Count > 0
        End Function

        Public Function SeleccionarRegistrosTotalComprasXRangoFechas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosTotalComprasXRangoFechas", True, pars)
        End Function

        Public Function SeleccionarRegistrosTotalVentasXRangoFechas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosTotalVentasXRangoFechas", True, pars)
        End Function

        Public Function SeleccionarRegistrosTotalNotasCreditoXRangoFechas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosTotalNotasCreditoXRangoFechas", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_Compras(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_Compras", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_VentasNotaCredito", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_VentasFacturas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_VentasFacturas", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_FacturasAnuladas(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_FacturasAnuladas", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_RetencionFuente(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_RetencionFuente", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_RetencionIVABienes(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_RetencionIVABienes", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_RetencionIVAServicios(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_RetencionIVAServicios", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_RetencionIVA100(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_RetencionIVA100", True, pars)
        End Function

        Public Function SeleccionarRegistrosAnexoTransaccional_ResumenRetencionesEfectuaron(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosAnexoTransaccional_ResumenRetencionesEfectuaron", True, pars)
        End Function

    End Class
End Namespace

