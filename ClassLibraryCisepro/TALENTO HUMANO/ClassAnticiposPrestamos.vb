Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassAnticiposPrestamos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdAnticipoPrestamo As Int64
        Public FechaAnticipoPrestamo As Date
        Public TipoAnticipoPrestamo As String
        Public FormaAnticipoPrestamo As String
        Public Valor As Decimal
        Public IdPersonal As Int64
        Public Estado As Int64
        Public Detalle As String
        Public Diferido As Int64
        Public Interes As Int64
        Public ValorCuotas As Int64
        Public SaldoCuotas As Int64
        Public SaldoValor As Decimal
        Public IdAuxFondoCheque As Int64

        Public Function BuscarMayorIdAnticiposPrestamos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_antipres=CASE WHEN MAX(id_antipres) IS NULL THEN 0 ELSE MAX(id_antipres) End FROM ANTICIPOS_PRESTAMOS", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_antipres")))
        End Function

        Public Function GuardarAnticiposPrestamoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into ANTICIPOS_PRESTAMOS values (@id_antipres, @fecha, @tipo, @forma, @valor, @id_personal, @estado, @detalle, " & _
                    "@diferido, @interes, @val_cuota, @saldo_cuotas, @saldo_total, @idfr_ideg);"
                .Parameters.AddWithValue("@id_antipres", SqlDbType.Int).Value = IdAnticipoPrestamo
                .Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = FechaAnticipoPrestamo
                .Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = TipoAnticipoPrestamo
                .Parameters.AddWithValue("@forma", SqlDbType.VarChar).Value = FormaAnticipoPrestamo
                .Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@detalle", SqlDbType.VarChar).Value = Detalle
                .Parameters.AddWithValue("@diferido", SqlDbType.Int).Value = Diferido
                .Parameters.AddWithValue("@interes", SqlDbType.Int).Value = Interes
                .Parameters.AddWithValue("@val_cuota", SqlDbType.Decimal).Value = ValorCuotas
                .Parameters.AddWithValue("@saldo_cuotas", SqlDbType.Int).Value = SaldoCuotas
                .Parameters.AddWithValue("@saldo_total", SqlDbType.Decimal).Value = SaldoValor
                .Parameters.AddWithValue("@idfr_ideg", SqlDbType.Int).Value = IdAuxFondoCheque
            End With
            Return comando
        End Function

        Public Function AnularAnticiposPrestamoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update ANTICIPOS_PRESTAMOS set estado=0 where idfr_ideg=@idfr_ideg;"
                .Parameters.AddWithValue("@idfr_ideg", SqlDbType.Int).Value = IdAuxFondoCheque
            End With
            Return comando
        End Function
    End Class
End Namespace

