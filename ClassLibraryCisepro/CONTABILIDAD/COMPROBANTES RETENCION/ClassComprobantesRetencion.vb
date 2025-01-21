Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPROBANTES_RETENCION

    Public Class ClassComprobantesRetencion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobanteRetencion As Int64
        Public NumeroComprobanteRetencion As String
        Public NumAutoSriComprobanteRetencion As String
        Public FechaAutoSriComprobanteRetencion As DateTime
        Public FechaEmisionComprobanteRetencion As DateTime
        Public IdProveedor As Integer
        Public TipoCompVentaComprobanteRetencion As String
        Public NumCompVentaComprobanteRetencion As String
        Public TotalComprobanteRetencion As Decimal
        Public EstadoComprobanteRetencion As Integer
        Public IdComprobanteCompra As Int64

        Public Function SeleccionarComrpobantesRetencionXIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComrpobantesRetencionXIdComprobanteCompra", True, pars) 
        End Function

        Public Function ExisteNumeroComprobanteRetencion(ByVal tipoCon As TipoConexion, ByVal parametroNumeroComprobante As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"n", SqlDbType.NVarChar, parametroNumeroComprobante})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) cant from comprobante_retencion_compra where numero_comprobante_retencion_compra = @n ", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)("cant")) > 0
        End Function

        Public Function ExisteNumeroComprobanteLiquidacionCompra(ByVal tipoCon As TipoConexion, ByVal parametroNumeroComprobante As String, ByVal idp As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"n", SqlDbType.NVarChar, parametroNumeroComprobante})
            pars.Add(New Object() {"idp", SqlDbType.Int, idp})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) cant from comprobantes_compra where numero_comprobante_compra = @n AND id_proveedor_general = @idp and tipo_comprobante_compra = 'LIQUIDACION DE COMPRA DE BIENES O PRESTACION DE SERVICIOS';", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)("cant")) > 0
        End Function

        Public Function BuscarMayorIdComprobanteRetencionCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteRetencionCompra", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroComprobanteRetencionCompra(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroComprobanteRetencionCompra", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroComprobanteRetencionCompra3(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_BuscarMayorNumeroComprobanteRetencionCompra3", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroComprobanteRetencionCompra4(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_BuscarMayorNumeroComprobanteRetencionCompra4", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function
        Public Function AnularComprobanteRetencionVentaByIdCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update COMPROBANTE_RETENCION_COMPRA set ESTADO_COMPROBANTE_RETENCION_COMPRA = 0 where ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

        Public Function NuevoRegistroComprobanteRetencionCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumeroComprobanteRetencion
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaEmisionComprobanteRetencion
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@TIPO_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = TipoCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@NUM_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = TotalComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

        Public Function ModificarRegistroComprobanteRetencionCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumeroComprobanteRetencion
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaEmisionComprobanteRetencion
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@TIPO_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = TipoCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@NUM_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = TotalComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteRetencionCompraByIdComprobanteCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update COMPROBANTE_RETENCION_COMPRA set ESTADO_COMPROBANTE_RETENCION_COMPRA =@ESTADO_COMPROBANTE_RETENCION_COMPRA where ID_COMPROBANTE_COMPRA=@ID_COMPROBANTE_COMPRA;"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoComprobanteRetencionCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoComprobanteRetencion
            End With
            Return comando
        End Function
        
        Public Function NuevoRegistroComprobanteRetencionCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroComprobanteRetencionCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_RETENCION_COMPRA", SqlDbType.BigInt).Value = IdComprobanteRetencion
                .Parameters.AddWithValue("@NUMERO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumeroComprobanteRetencion
                .Parameters.AddWithValue("@NUM_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaAutoSriComprobanteRetencion
                .Parameters.AddWithValue("@FECHA_EMISION_COMPROBANTE_RETENCION_COMPRA", SqlDbType.DateTime).Value = FechaEmisionComprobanteRetencion
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@TIPO_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = TipoCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@NUM_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA", SqlDbType.NVarChar).Value = NumCompVentaComprobanteRetencion
                .Parameters.AddWithValue("@TOTAL_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Decimal).Value = TotalComprobanteRetencion
                .Parameters.AddWithValue("@ESTADO_COMPROBANTE_RETENCION_COMPRA", SqlDbType.Int).Value = EstadoComprobanteRetencion
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

    End Class
End Namespace

