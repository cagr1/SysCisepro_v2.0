Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
    Public Class ClassNotaCredito
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdNotaCredito As Int64
        Public IdClienteGeneral As Int64
        Public NumeroNotaCredito As String
        Public NumAutoSriNotaCredito As String
        Public FechaAutoSriNotaCredito As DateTime
        Public FechaEmisionNotaCredito As DateTime
        Public NumDocModificacionNotaCredito As String
        Public RazonModificacionNotaCredito As String
        Public Subtotal12NotaCredito As Decimal
        Public Subtotal0NotaCredito As Decimal
        Public SubtotalNotaCredito As Decimal
        Public PorcentajeIvaNotaCredito As Integer
        Public IvaNotaCredito As Decimal
        Public TotalNotaCredito As Decimal
        Public EstadoNotaCredito As Integer
        Public IdFactura As Int64

        Public Function SeleccionarNotaCreditoXIdCliente(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarNotaCreditoXIdCliente", True, pars)
        End Function

        Public Function SeleccionarNotaCreditoXIdFactura(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_FACTURA_VENTA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarNotaCreditoXIdFactura", True, pars)
        End Function

        Public Function SeleccionarNotaCreditoVentaXNumeroNotaCredito(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_NOTA_CREDITO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarNotaCreditoVentaXNumeroNotaCredito", True, pars)
        End Function

        Public Function SeleccionarNotaCreditoVentaXParametros(ByVal tipoCon As TipoConexion, ByVal parametroIdCliente As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal parametroEstado As Integer) As DataTable
            Dim pars = New List(Of Object())
            Dim sql As String

            If parametroIdCliente > 0 And parametroEstado < 3 Then
                sql = "SeleccionarNotaCreditoVentaXParametros"
                pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.BigInt, parametroIdCliente})
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
                pars.Add(New Object() {"ESTADO_NOTA_CREDITO", SqlDbType.Int, parametroEstado})
            ElseIf parametroIdCliente > 0 And parametroEstado = 3 Then
                sql = "SeleccionarNotaCreditoVentaXIdClienteYRangoFechas"
                pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.BigInt, parametroIdCliente})
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            ElseIf parametroIdCliente = 0 And parametroEstado < 3 Then
                sql = "SeleccionarNotaCreditoVentaXEstadoYRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
                pars.Add(New Object() {"ESTADO_NOTA_CREDITO", SqlDbType.Int, parametroEstado})
            ElseIf parametroIdCliente = 0 And parametroEstado = 3 Then
                sql = "SeleccionarNotaCreditoVentaXRangoFechas"
                pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
                pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Else
                sql = String.Empty
            End If

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, True, pars)
        End Function

        Public Function BuscarNotaCreditoVentaXConsorcioRangoFecha(ByVal tipoCon As TipoConexion, ByVal parametroConsorcio As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONSORCIO_CLIENTE_GENERAL", SqlDbType.VarChar, parametroConsorcio})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNotaCreditoVentaXConsorcioRangoFecha", True, pars)
        End Function

        Public Function BuscarMayorIdNotaCreditoVenta(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdNotaCreditoVenta", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroNotaCreditoVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroNotaCreditoVenta"
                .Parameters.AddWithValue("@ID_NOTA_CREDITO", SqlDbType.BigInt).Value = IdNotaCredito
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdClienteGeneral
                .Parameters.AddWithValue("@NUMERO_NOTA_CREDITO", SqlDbType.NVarChar).Value = NumeroNotaCredito
                .Parameters.AddWithValue("@NUM_AUTO_SRI_NOTA_CREDITO", SqlDbType.NVarChar).Value = NumAutoSriNotaCredito
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_NOTA_CREDITO", SqlDbType.DateTime).Value = FechaAutoSriNotaCredito
                .Parameters.AddWithValue("@FECHA_EMISION_NOTA_CREDITO", SqlDbType.DateTime).Value = FechaEmisionNotaCredito
                .Parameters.AddWithValue("@NUM_DOC_MODIFICACION_NOTA_CREDITO", SqlDbType.NVarChar).Value = NumDocModificacionNotaCredito
                .Parameters.AddWithValue("@RAZON_MODIFICACION_NOTA_CREDITO", SqlDbType.NVarChar).Value = RazonModificacionNotaCredito
                .Parameters.AddWithValue("@SUBTOTAL_12_NOTA_CREDITO", SqlDbType.Decimal).Value = Subtotal12NotaCredito
                .Parameters.AddWithValue("@SUBTOTAL_0_NOTA_CREDITO", SqlDbType.Decimal).Value = Subtotal0NotaCredito
                .Parameters.AddWithValue("@SUBTOTAL_NOTA_CREDITO", SqlDbType.Decimal).Value = SubtotalNotaCredito
                .Parameters.AddWithValue("@PORCENTAJE_IVA_NOTA_CREDITO", SqlDbType.Int).Value = PorcentajeIvaNotaCredito
                .Parameters.AddWithValue("@IVA_NOTA_CREDITO", SqlDbType.Decimal).Value = IvaNotaCredito
                .Parameters.AddWithValue("@TOTAL_NOTA_CREDITO", SqlDbType.Decimal).Value = TotalNotaCredito
                .Parameters.AddWithValue("@ESTADO_NOTA_CREDITO", SqlDbType.Int).Value = EstadoNotaCredito
                .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = IdFactura
            End With
            Return comando
        End Function
        'Public Function NuevoRegistroNotaCreditoVenta(ByVal tipoCon As TipoConexion) As Boolean
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "nuevoRegistroNotaCreditoVenta"
        '        .Parameters.AddWithValue("@ID_NOTA_CREDITO", SqlDbType.BigInt).Value = idNotaCredito
        '        .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = idClienteGeneral
        '        .Parameters.AddWithValue("@NUMERO_NOTA_CREDITO", SqlDbType.NVarChar).Value = numeroNotaCredito
        '        .Parameters.AddWithValue("@NUM_AUTO_SRI_NOTA_CREDITO", SqlDbType.NVarChar).Value = numAutoSRINotaCredito
        '        .Parameters.AddWithValue("@FECHA_AUTO_SRI_NOTA_CREDITO", SqlDbType.DateTime).Value = fechaAutoSRINotaCredito
        '        .Parameters.AddWithValue("@FECHA_EMISION_NOTA_CREDITO", SqlDbType.DateTime).Value = fechaEmisionNotaCredito
        '        .Parameters.AddWithValue("@NUM_DOC_MODIFICACION_NOTA_CREDITO", SqlDbType.NVarChar).Value = numDocModificacionNotaCredito
        '        .Parameters.AddWithValue("@RAZON_MODIFICACION_NOTA_CREDITO", SqlDbType.NVarChar).Value = razonModificacionNotaCredito
        '        .Parameters.AddWithValue("@SUBTOTAL_12_NOTA_CREDITO", SqlDbType.Decimal).Value = subtotal12NotaCredito
        '        .Parameters.AddWithValue("@SUBTOTAL_0_NOTA_CREDITO", SqlDbType.Decimal).Value = subtotal0NotaCredito
        '        .Parameters.AddWithValue("@SUBTOTAL_NOTA_CREDITO", SqlDbType.Decimal).Value = subtotalNotaCredito
        '        .Parameters.AddWithValue("@PORCENTAJE_IVA_NOTA_CREDITO", SqlDbType.Int).Value = porcentajeIvaNotaCredito
        '        .Parameters.AddWithValue("@IVA_NOTA_CREDITO", SqlDbType.Decimal).Value = ivaNotaCredito
        '        .Parameters.AddWithValue("@TOTAL_NOTA_CREDITO", SqlDbType.Decimal).Value = totalNotaCredito
        '        .Parameters.AddWithValue("@ESTADO_NOTA_CREDITO", SqlDbType.Int).Value = estadoNotaCredito
        '        .Parameters.AddWithValue("@ID_FACTURA_VENTA", SqlDbType.BigInt).Value = idFactura
        '    End With
        '    Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        'End Function

        Public Function ActualizarEstadoNotaCreditoVenta() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoNotaCreditoVenta"
                .Parameters.AddWithValue("@ID_NOTA_CREDITO", SqlDbType.BigInt).Value = IdNotaCredito
                .Parameters.AddWithValue("@ESTADO_NOTA_CREDITO", SqlDbType.Int).Value = EstadoNotaCredito
            End With
            Return comando
        End Function
        'Public Function ActualizarEstadoNotaCreditoVenta(ByVal tipoCon As TipoConexion) As Boolean
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "actualizarEstadoNotaCreditoVenta"
        '        .Parameters.AddWithValue("@ID_NOTA_CREDITO", SqlDbType.BigInt).Value = idNotaCredito
        '        .Parameters.AddWithValue("@ESTADO_NOTA_CREDITO", SqlDbType.Int).Value = estadoNotaCredito
        '    End With
        '    Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        'End Function

    End Class
End Namespace

