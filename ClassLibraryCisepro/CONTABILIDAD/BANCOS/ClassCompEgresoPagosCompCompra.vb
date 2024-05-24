Imports System.Data
Imports System.Data.SqlClient

Namespace CONTABILIDAD.BANCOS
    Public Class ClassCompEgresoPagosCompCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public IdComprobanteCompra As Int64
        Public IdPagosComprobante As Int64
        Public MontoPagos As Decimal
        Public NumeroRegistro As Int64

        Public Function NuevoRegistroCompEgresoPagosCompCompra() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroCompEgresoPagosCompCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobanteCompra
                .Parameters.AddWithValue("@ID_PAGOS_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdPagosComprobante
                .Parameters.AddWithValue("@MONTO_PAGOS_COMPROBANTE_COMPRA", SqlDbType.Decimal).Value = MontoPagos
                .Parameters.AddWithValue("@NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt).Value = NumeroRegistro
            End With
            Return comando
        End Function

    End Class
End Namespace

