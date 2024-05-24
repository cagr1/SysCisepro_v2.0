Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.COMPROBANTES
    Public Class ClassDetalleComprobanteEgreso
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalle As Int64
        Public IdKardex As Int64
        Public IdDetalleKardex As Int64
        Public ObservacionCalidad As String
        Public ObservacionDetalle As String
        Public IdComprobante As String
        Public Estado As Integer 

        Public Function BuscarMayorIdDetalleComprobanteEgresoBodega(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleComprobanteEgresoBodega", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleComprobanteEgresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDetalleComprobanteEgresoBodega2"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex
                .Parameters.AddWithValue("@OBSERVACION_DETALLE", SqlDbType.NVarChar).Value = ObservacionCalidad
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_DETALLE", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = ObservacionDetalle
            End With
            Return comando
        End Function

        Public Function ModificarDetalleComprobanteEgresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarDetalleComprobanteEgresoBodega"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex
                .Parameters.AddWithValue("@OBSERVACION_DETALLE", SqlDbType.NVarChar).Value = ObservacionCalidad
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_DETALLE", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = ObservacionDetalle
            End With
            Return comando
        End Function
    End Class
End Namespace

