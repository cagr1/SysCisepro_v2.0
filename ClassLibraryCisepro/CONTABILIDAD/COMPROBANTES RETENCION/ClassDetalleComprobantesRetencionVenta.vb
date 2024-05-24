Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPROBANTES_RETENCION
    Public Class ClassDetalleComprobantesRetencionVenta
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
        Public IdFactura As Int64

        Public Function SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion", True, pars)
        End Function

        Public Function SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdFacturaVenta", True, pars)
        End Function

        Public Function BuscarMayorIdDetalleComprobanteRetencionVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleComprobanteRetencionVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDetalleComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EjFiscalDetalleComprobanteRetencion
                .Parameters.AddWithValue("@CODIGO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = CodigoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = BaseImponibleDetalleComprobanteRetencion
                .Parameters.AddWithValue("@IMPUESTO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = ImpuestoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = PorcentajeComprobanteRetencion
                .Parameters.AddWithValue("@VALOR_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = ValorDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.Int).Value = IdFactura
            End With
            Return comando
        End Function

        Public Function ModificarRegistroDetalleComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroDetalleComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EjFiscalDetalleComprobanteRetencion
                .Parameters.AddWithValue("@CODIGO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = CodigoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = BaseImponibleDetalleComprobanteRetencion
                .Parameters.AddWithValue("@IMPUESTO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.NVarChar).Value = ImpuestoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = PorcentajeComprobanteRetencion
                .Parameters.AddWithValue("@VALOR_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Decimal).Value = ValorDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.Int).Value = IdFactura
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteRetencionVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoDetalleComprobanteRetencionVenta"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.BigInt).Value = IdDetalleComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_DETALLE_COMPROBANTE_RETENCION_VENTA", SqlDbType.Int).Value = EstadoDetalleComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function AnularDetalleComprobanteRetencionVentaByIdFactura() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE	dbo.DETALLE_COMPROBANTE_RETENCION_VENTA	SET ESTADO_DETALLE_COMPROBANTE_RETENCION_VENTA	= 0 WHERE	ID_FACTURA_VENTA		=	@ID_FACTURA_VENTA"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
            End With
            Return comando
        End Function
         
    End Class
End Namespace

