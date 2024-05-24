Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.COMPROBANTES
    Public Class ClassDetalleComprobanteIngreso
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalle As Int64
        Public IdKardex As Int64
        Public IdDetalleKardex As Int64
        Public ObservacionCalidadDetalle As String
        Public IdComprobante As String
        Public Estado As Integer 
        Public ObservacionDetalleSerial As String


        Public Function BuscarMayorIdDetalleComprobanteIngresoBodega(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleComprobanteIngresoBodega", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleComprobanteIngresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDetalleComprobanteIngresoBodega2"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex
                .Parameters.AddWithValue("@OBSERVACION_DETALLE", SqlDbType.NVarChar).Value = ObservacionCalidadDetalle
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_DETALLE", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = ObservacionDetalleSerial
            End With
            Return comando
        End Function 

        Public Function ModificarDetalleComprobanteIngresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarDetalleComprobanteIngresoBodega"
                .Parameters.AddWithValue("@ID_DETALLE_COMPROBANTE", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex
                .Parameters.AddWithValue("@OBSERVACION_DETALLE", SqlDbType.NVarChar).Value = ObservacionCalidadDetalle
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@ESTADO_DETALLE", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = ObservacionDetalleSerial
            End With
            Return comando
        End Function
    End Class
End Namespace

