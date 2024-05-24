Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassPagosFacturaVenta
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdPagoFactura As Int64
        Public FechaPagoFactura As DateTime
        Public NumeroPagoFactura As Int64
        Public FormaPagoFactura As String
        Public MontoPagoFactura As Decimal
        Public SaldoPagoFactura As Decimal
        Public EstadoPagoFactura As Integer        
        Public IdFactura As Int64
        Public IdCliente As Int64
        Public IdComprobanteIngreso As Int64

        Public Function SeleccionarPagosFacturaVentaXIdFactura(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPagosFacturaVentaXIdFactura", True, pars)
        End Function

        Public Function SeleccionarPagosFacturaVentaXIdComprobanteIngreso(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPagosFacturaVentaXIdComprobanteIngreso", True, pars)
        End Function

        Public Function BuscarMayorIdPagoFacturaVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdPagoFacturaVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroPagoFcturaVentaXIdFactura(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorNumeroPagoFcturaVentaXIdFactura", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarPagosActivoXIdComprobante(ByVal tipoCon As TipoConexion, ByVal idCompComp As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, idCompComp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from pagos_FACTURA_VENTA where ID_FACTURA_VENTA = @ID_FACTURA_VENTA and estado_pago_FACTURA_VENTA=1 order by id_pago_FACTURA_VENTA desc;", False, pars)
        End Function

        Public Function BuscarMayorSaldoPagosFacturaventaXIdFactura(ByVal tipoCon As TipoConexion, ByVal cod As String) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.NVarChar, cod})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorSaldoPagosFacturaVentaXIdComprobante", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function
         
        Public Function NuevoRegistroPagosFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroPagosFacturaVenta"
                .Parameters.AddWithValue("@ID_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = IdPagoFactura
                .Parameters.AddWithValue("@FECHA_PAGO_FACTURA_VENTA", SqlDbType.DateTime).Value = FechaPagoFactura
                .Parameters.AddWithValue("@NUMERO_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = NumeroPagoFactura
                .Parameters.AddWithValue("@FORMA_PAGO_FACTURA_VENTA", SqlDbType.NVarChar).Value = FormaPagoFactura
                .Parameters.AddWithValue("@MONTO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = MontoPagoFactura
                .Parameters.AddWithValue("@SALDO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = SaldoPagoFactura
                .Parameters.AddWithValue("@ESTADO_PAGO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoPagoFactura
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
            End With
            Return comando
        End Function
        Public Function NuevoRegistroPagosFacturaVenta(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroPagosFacturaVenta"
                .Parameters.AddWithValue("@ID_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = IdPagoFactura
                .Parameters.AddWithValue("@FECHA_PAGO_FACTURA_VENTA", SqlDbType.DateTime).Value = FechaPagoFactura
                .Parameters.AddWithValue("@NUMERO_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = NumeroPagoFactura
                .Parameters.AddWithValue("@FORMA_PAGO_FACTURA_VENTA", SqlDbType.NVarChar).Value = FormaPagoFactura
                .Parameters.AddWithValue("@MONTO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = MontoPagoFactura
                .Parameters.AddWithValue("@SALDO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = SaldoPagoFactura
                .Parameters.AddWithValue("@ESTADO_PAGO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoPagoFactura
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function AnularPagosFacturaVentaByIdComprobanteIngresos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_FACTURA_VENTA set ESTADO_PAGO_FACTURA_VENTA=0 where ID_COMPROBANTE_INGRESO_BANCOS=@ID_COMPROBANTE_INGRESO_BANCOS;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
            End With
            Return comando
        End Function

        Public Function AnularPagoRetencionFacturaVentaByIdFacturaVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_FACTURA_VENTA set ESTADO_PAGO_FACTURA_VENTA=0 where  ID_FACTURA_VENTA=@ID_FACTURA_VENTA AND (FORMA_PAGO_FACTURA_VENTA = 'RETENCIÓN' OR FORMA_PAGO_FACTURA_VENTA = 'RETENCION');"
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
            End With
            Return comando
        End Function
         
        Public Function ActualizarRegistroPagosFacturaVenta(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ActualizarRegistroPagosFacturaVenta"
                .Parameters.AddWithValue("@ID_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = IdPagoFactura
                .Parameters.AddWithValue("@FECHA_PAGO_FACTURA_VENTA", SqlDbType.DateTime).Value = FechaPagoFactura
                .Parameters.AddWithValue("@NUMERO_PAGO_FACTURA_VENTA", SqlDbType.BigInt).Value = NumeroPagoFactura
                .Parameters.AddWithValue("@FORMA_PAGO_FACTURA_VENTA", SqlDbType.NVarChar).Value = FormaPagoFactura
                .Parameters.AddWithValue("@MONTO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = MontoPagoFactura
                .Parameters.AddWithValue("@SALDO_PAGO_FACTURA_VENTA", SqlDbType.Decimal).Value = SaldoPagoFactura
                .Parameters.AddWithValue("@ESTADO_PAGO_FACTURA_VENTA", SqlDbType.Int).Value = EstadoPagoFactura
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function
         
    End Class
End Namespace

