Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.SRI
    Public Class ClassInformacionTributaria
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public SecuencialFactura As String
        Public SecuencialNotaCredito As String
        Public SecuencialComprobanteRetencion As String
        Public SecuencialLiquidacionCompra As String
        Public NroAutoFactura As String
        Public NroAutoNotaCredito As String
        Public NroAutoComprobanteRetencion As String
        Public PorcentajeIva As Integer
        Public PorcentajeIce As Integer

        Public Function SeleccionarRegistrosInformacionTributaria(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosInformacionTributaria", True)
        End Function

        Public Function SeleccionarNroResolucionAgenteRetencion(ByVal tipoCon As TipoConexion) As String
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT NRO_RESOLUCION_AGENTE_RETENCION from INFORMACION_TRIBUTARIA;", False)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function ActualizarSecuencialFacturaInformacionTributaria() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSecuencialFacturaInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_FACTURA_IT", SqlDbType.Int).Value = SecuencialFactura
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialFacturaInformacionTributaria3() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialFacturaInformacionTributaria3"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_FACTURA_IT", SqlDbType.Int).Value = SecuencialFactura
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialFacturaInformacionTributaria4() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialFacturaInformacionTributaria4"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_FACTURA_IT", SqlDbType.Int).Value = SecuencialFactura
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialNotaCreditoInformacionTributaria() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSecuencialNotaCreditoInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_NOTA_CREDITO_IT", SqlDbType.Int).Value = SecuencialNotaCredito
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialesInformacionTributaria(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSecuencialesInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_FACTURA_IT", SqlDbType.Int).Value = SecuencialFactura
                .Parameters.AddWithValue("@SECUENCIAL_NOTA_CREDITO_IT", SqlDbType.Int).Value = SecuencialNotaCredito
                .Parameters.AddWithValue("@SECUENCIAL_COMPROBANTE_RETENCION_IT", SqlDbType.Int).Value = SecuencialComprobanteRetencion
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarAutorizacionesInformacionTributaria(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarAutorizacionesInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@NRO_AUTORIZACION_FACTURA_IT", SqlDbType.Int).Value = NroAutoFactura
                .Parameters.AddWithValue("@NRO_AUTORIZACION_NOTA_CREDITO_IT", SqlDbType.Int).Value = NroAutoNotaCredito
                .Parameters.AddWithValue("@NRO_AUTORIZACION_COMP_RETENCION_IT", SqlDbType.Int).Value = NroAutoComprobanteRetencion
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarPorcentajesInformacionTributaria(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarPorcentajesInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@PORCENTAJE_IVA_IT", SqlDbType.Int).Value = PorcentajeIva
                .Parameters.AddWithValue("@PORCENTAJE_ICE_IT", SqlDbType.Int).Value = PorcentajeIce
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSecuencialComprobanteRetencionInformacionTributaria"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_COMPROBANTE_RETENCION_IT", SqlDbType.Int).Value = SecuencialComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand3() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialComprobanteRetencionInformacionTributaria3"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_COMPROBANTE_RETENCION_IT", SqlDbType.Int).Value = SecuencialComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand4() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialComprobanteRetencionInformacionTributaria4"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_COMPROBANTE_RETENCION_IT", SqlDbType.Int).Value = SecuencialComprobanteRetencion
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE INFORMACION_TRIBUTARIA set SECUENCIAL_LIQUIDACION_COMPRA_IT = @SECUENCIAL_LIQUIDACION_COMPRA_IT WHERE ID_INFORMACION=@ID_INFORMACION"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_LIQUIDACION_COMPRA_IT", SqlDbType.Int).Value = SecuencialLiquidacionCompra
            End With
            Return comando
        End Function

        Public Function ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand3() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialLiquidacionCompra3"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_LIQUIDACION_COMPRA_IT", SqlDbType.Int).Value = SecuencialLiquidacionCompra
            End With
            Return comando
        End Function
        Public Function ActualizarSecuencialLiquidacionCompraInformacionTributariaCommand4() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_actualizarSecuencialLiquidacionCompra4"
                .Parameters.AddWithValue("@ID_INFORMACION", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@SECUENCIAL_LIQUIDACION_COMPRA_IT", SqlDbType.Int).Value = SecuencialLiquidacionCompra
            End With
            Return comando
        End Function
    End Class
End Namespace

