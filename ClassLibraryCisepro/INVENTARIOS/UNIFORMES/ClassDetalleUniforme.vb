Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UNIFORMES
    Public Class ClassDetalleUniforme
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalle As Int64
        Public IdKardex As Int64
        Public IdDetalleKardex As Int64
        Public ObservacionEstado As String
        Public ObservacionDetalle As String
        Public Cantidad As Integer
        Public Estado As Integer
        Public FechaRenovacion As DateTime
        Public IdUniformes As Int64

        Public Function BuscarMayorIdDetalleUniformes(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleUNIFORMES", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetalleUniformesCommand() As SqlCommand
            Dim comando As New SqlCommand()
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[NuevoRegistroDetalleUNIFORMES2]"
                .Parameters.AddWithValue("@ID_DETALLE_UNIFORMES", SqlDbType.BigInt).Value = idDetalle
                .Parameters.AddWithValue("@ID_KARDEX_DETALLE_UNIFORMES", SqlDbType.BigInt).Value = idKardex
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX_DETALLE_UNIFORMES", SqlDbType.BigInt).Value = idDetalleKardex
                .Parameters.AddWithValue("@OBSERVACION_DETALLE_UNIFORMES", SqlDbType.NVarChar).Value = observacionEstado
                .Parameters.AddWithValue("@CANTIDAD_DETALLE_UNIFORMES", SqlDbType.Int).Value = cantidad
                .Parameters.AddWithValue("@ESTADO_DETALLE_UNIFORMES", SqlDbType.Int).Value = estado
                .Parameters.AddWithValue("@FECHA_RENOVACION_DETALLE_UNIFORMES", SqlDbType.DateTime).Value = fechaRenovacion
                .Parameters.AddWithValue("@ID_UNIFORMES", SqlDbType.BigInt).Value = idUniformes
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = observacionDetalle
            End With
            Return comando
        End Function

    End Class
End Namespace
