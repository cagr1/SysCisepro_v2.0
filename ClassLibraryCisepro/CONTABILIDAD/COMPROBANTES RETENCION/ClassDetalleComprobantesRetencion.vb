Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPROBANTES_RETENCION
    Public Class ClassDetalleComprobantesRetencion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalleComprobanteRetencion As Int64
        Public EjFiscalDetalleComprobanteRetencion As Integer
        Public CodigoDetalleComprobanteRetencion As String
        Public BaseImponibleDetalleComprobanteRetencion As Decimal
        Public ImpuestoDetalleComprobanteRetencion As String
        Public PorcentajeComprobanteRetencion As Decimal
        Public ValorDetalleComprobanteRetencion As Decimal
        Public EstadoDetalleComprobanteRetencion As Integer
        Public IdComprobanteRetencion As Int64
        Public IdComprobanteCompra As Int64

        Public Function SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.VarChar, parametroBusqueda})
            'Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosDetalleComprobanteRetencionCompraXIdComprobanteRetencion", True, pars)
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	DR.*, DP.CODIGO, DP.CUENTA FROM	DETALLE_COMPROBANTE_RETENCION_COMPRA DR LEFT JOIN DETALLE_RETENCION_PLAN_CUENTAS DP ON DR.ID_DETALLE_COMPROBANTE_RETENCION_COMPRA=DP.ID_DETALLE_COMPROBANTE_RETENCION_COMPRA WHERE	DR.ID_COMPROBANTE_RETENCION_COMPRA = @ID_COMPROBANTE_RETENCION_COMPRA AND DR.ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA > 0;", False, pars)
        End Function

        Public Function SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	DR.*, DP.CODIGO, DP.CUENTA FROM	DETALLE_COMPROBANTE_RETENCION_COMPRA DR LEFT JOIN DETALLE_RETENCION_PLAN_CUENTAS DP ON DR.ID_DETALLE_COMPROBANTE_RETENCION_COMPRA=DP.ID_DETALLE_COMPROBANTE_RETENCION_COMPRA WHERE	DR.ID_COMPROBANTE_COMPRA = @ID_COMPROBANTE_COMPRA AND DR.ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA > 0;", False, pars)
        End Function

        Public Function BuscarMayorIdDetalleComprobanteRetencionCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleComprobanteRetencionCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function AnularDetalleComprobanteRetencionVentaByIdCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE	dbo.DETALLE_COMPROBANTE_RETENCION_COMPRA SET ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA = 0 WHERE ID_COMPROBANTE_COMPRA =	@ID_COMPROBANTE_COMPRA"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

        Public Function ModificarRegistroDetalleComprobanteRetencionCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroDetalleComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EjFiscalDetalleComprobanteRetencion
                .Parameters.AddWithValue("@CODIGO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = CodigoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = BaseImponibleDetalleComprobanteRetencion
                .Parameters.AddWithValue("@IMPUESTO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = ImpuestoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = PorcentajeComprobanteRetencion
                .Parameters.AddWithValue("@VALOR_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = ValorDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.Int).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoDetalleComprobanteRetencionCompraByIdComprobanteCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update DETALLE_COMPROBANTE_RETENCION_COMPRA set ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA=@ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA where ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoDetalleComprobanteRetencionCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoDetalleComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function NuevoRegistroDetalleComprobanteRetencionCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroDetalleComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EjFiscalDetalleComprobanteRetencion
                .Parameters.AddWithValue("@CODIGO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = CodigoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = BaseImponibleDetalleComprobanteRetencion
                .Parameters.AddWithValue("@IMPUESTO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = ImpuestoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = PorcentajeComprobanteRetencion
                .Parameters.AddWithValue("@VALOR_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = ValorDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.Int).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

    End Class
End Namespace

