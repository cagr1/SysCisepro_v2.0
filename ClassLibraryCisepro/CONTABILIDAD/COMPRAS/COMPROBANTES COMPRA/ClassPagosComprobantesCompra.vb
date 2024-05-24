Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA

    Public Class ClassPagosComprobantesCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdPagosComprobantes As Int64
        Public FechaPagosComprobantes As DateTime
        Public NumeroPagosComprobantes As Integer
        Public MontoPagosComprobantes As Decimal
        Public SaldoPagosComprobantes As Decimal
        Public EstadoPagosComprobantes As Integer
        Public IdComprobante As Int64
        Public IdComprobanteEgreso As Int64
        Public IdProveedorGeneral As Integer

        Public Function SeleccionarPagosComrpobantesCompraXIdComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPagosComrpobantesCompraXIdComprobante", True, pars)
        End Function

        Public Function BuscarMayorIdPagosComprobantesCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdPagosComprobantesCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroPagosComprobantesCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorNumeroPagosComprobantesCompra", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorSaldoPagosComprobantesCompraXIdComprobante", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroPagosComprobantesCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroPagosComprobantesCompra"
                .Parameters.AddWithValue("@ID_PAGOS_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdPagosComprobantes
                .Parameters.AddWithValue("@FECHA_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = FechaPagosComprobantes
                .Parameters.AddWithValue("@NUMERO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = NumeroPagosComprobantes
                .Parameters.AddWithValue("@MONTO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = MontoPagosComprobantes
                .Parameters.AddWithValue("@SALDO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SaldoPagosComprobantes
                .Parameters.AddWithValue("@ESTADO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoPagosComprobantes
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
            End With
            Return comando
        End Function
        Public Function NuevoRegistroPagosComprobantesCompra(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroPagosComprobantesCompra"
                .Parameters.AddWithValue("@ID_PAGOS_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdPagosComprobantes
                .Parameters.AddWithValue("@FECHA_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = FechaPagosComprobantes
                .Parameters.AddWithValue("@NUMERO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = NumeroPagosComprobantes
                .Parameters.AddWithValue("@MONTO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = MontoPagosComprobantes
                .Parameters.AddWithValue("@SALDO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SaldoPagosComprobantes
                .Parameters.AddWithValue("@ESTADO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoPagosComprobantes
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function RestarPagoRetencionFacturaCompraByIdComprobanteCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_COMPROBANTES_COMPRA set MONTO_PAGOS_COMPROBANTE_COMPRA=0, SALDO_PAGOS_COMPROBANTE_COMPRA=@SALDO_PAGOS_COMPROBANTE_COMPRA where ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA;"
                .Parameters.AddWithValue("@SALDO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SaldoPagosComprobantes
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return comando
        End Function

        Public Function AnularPagoRetencionFacturaCompraByIdComprobanteCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_COMPROBANTES_COMPRA set ESTADO_PAGOS_COMPROBANTE_COMPRA=0 where  ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
            End With
            Return comando
        End Function

        Public Function AnularPagosComprobantesCompraByIdComprobanteEgreso() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update PAGOS_COMPROBANTES_COMPRA set ESTADO_PAGOS_COMPROBANTE_COMPRA=0 where  ID_COMPROBANTE_EGRESO_BANCOS=@ID_COMPROBANTE_EGRESO_BANCOS;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
            End With
            Return comando
        End Function

        Public Function NuevoRegistroPagosComprobantesCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroPagosComprobantesCompra"
                .Parameters.AddWithValue("@ID_PAGOS_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdPagosComprobantes
                .Parameters.AddWithValue("@FECHA_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = FechaPagosComprobantes
                .Parameters.AddWithValue("@NUMERO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = NumeroPagosComprobantes
                .Parameters.AddWithValue("@MONTO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = MontoPagosComprobantes
                .Parameters.AddWithValue("@SALDO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SaldoPagosComprobantes
                .Parameters.AddWithValue("@ESTADO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoPagosComprobantes
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
            End With
            Return comando
        End Function
        'Public Function NuevoRegistroPagosComprobantesCompraCommand(ByVal tipoCon As TipoConexion) As Boolean
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "nuevoRegistroPagosComprobantesCompra"
        '        .Parameters.AddWithValue("@ID_PAGOS_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdPagosComprobantes
        '        .Parameters.AddWithValue("@FECHA_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = FechaPagosComprobantes
        '        .Parameters.AddWithValue("@NUMERO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = NumeroPagosComprobantes
        '        .Parameters.AddWithValue("@MONTO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = MontoPagosComprobantes
        '        .Parameters.AddWithValue("@SALDO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = SaldoPagosComprobantes
        '        .Parameters.AddWithValue("@ESTADO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Int).Value = EstadoPagosComprobantes
        '        .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
        '        .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
        '        .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
        '    End With
        '    Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        'End Function

    End Class
End Namespace

