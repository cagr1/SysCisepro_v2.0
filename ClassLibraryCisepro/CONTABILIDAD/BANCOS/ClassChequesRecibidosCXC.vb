Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassChequesRecibidosCxc
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCheque As Int64
        Public FechaEmision As DateTime
        Public Titular As String
        Public Banco As String
        Public CtaCteCheque As String
        Public NumeroCheque As Integer
        Public Valor As Decimal
        Public Estado As Integer
        Public IdComprobanteIngreso As Int64
        Public IdClienteGeneral As Integer

        Public Function BuscarMayorIdChequeRecibidoCxc(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdChequeRecibidoCXC", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroChequeRecibidoCxc() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroChequeRecibidoCXC"
                .Parameters.AddWithValue("@ID_CHEQUE_RECIBIDO", SqlDbType.BigInt).Value = IdCheque
                .Parameters.AddWithValue("@FECHA_EMISION_CHEQUE_RECIBIDO", SqlDbType.DateTime).Value = FechaEmision
                .Parameters.AddWithValue("@TITULAR_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = Titular
                .Parameters.AddWithValue("@BANCO_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@CTA_CTE_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = CtaCteCheque
                .Parameters.AddWithValue("@NUMERO_CHEQUE_RECIBIDO", SqlDbType.Int).Value = NumeroCheque
                .Parameters.AddWithValue("@VALOR_CHEQUE_RECIBIDO", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ESTADO_CHEQUE_RECIBIDO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdClienteGeneral
            End With
            Return comando
        End Function
        Public Function NuevoRegistroChequeRecibidoCxc(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroChequeRecibidoCXC"
                .Parameters.AddWithValue("@ID_CHEQUE_RECIBIDO", SqlDbType.BigInt).Value = IdCheque
                .Parameters.AddWithValue("@FECHA_EMISION_CHEQUE_RECIBIDO", SqlDbType.DateTime).Value = FechaEmision
                .Parameters.AddWithValue("@TITULAR_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = Titular
                .Parameters.AddWithValue("@BANCO_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@CTA_CTE_CHEQUE_RECIBIDO", SqlDbType.NVarChar).Value = CtaCteCheque
                .Parameters.AddWithValue("@NUMERO_CHEQUE_RECIBIDO", SqlDbType.Int).Value = NumeroCheque
                .Parameters.AddWithValue("@VALOR_CHEQUE_RECIBIDO", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ESTADO_CHEQUE_RECIBIDO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteIngreso
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdClienteGeneral
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

