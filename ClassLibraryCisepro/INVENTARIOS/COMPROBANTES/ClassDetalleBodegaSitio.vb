Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.COMPROBANTES
    Public Class ClassDetalleBodegaSitio
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public IdSitio As Int64
        Public IdDetalle As Int64
        Public Fecha As DateTime
        Public Tipo As String
        Public Estado As Integer
        Public Serie As String

        Public Function BuscarMayorIdRegistroDetalleComprobante(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_detalle=CASE WHEN MAX(id_detalle) IS NULL THEN 0 ELSE MAX(id_detalle) End FROM detalle_items_puesto", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleComprobanteEgresoSitioCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into detalle_items_puesto values (@ID_SITIO, @ID_DETALLE_COMPROBANTE, @FECHA, @TIPO, @ESTADO, @ID, @SERIE)"
                .Parameters.AddWithValue("@ID_SITIO", SqlDbType.BigInt).Value = IdSitio
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@TIPO", SqlDbType.VarChar).Value = Tipo
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@SERIE", SqlDbType.VarChar).Value = Serie
            End With
            Return comando
        End Function

    End Class
End Namespace