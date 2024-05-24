Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassFacturaSecuenciales
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSecuenciales As Int64
        Public FechaSecuenciales As DateTime
        Public CantidadSecuenciales As Integer
        Public InicialSecuenciales As Integer
        Public FinalSecuenciales As Integer
        Public ActualSecuenciales As Integer
        Public ObservacionesSecuenciales As String
        Public EstadoSecuenciales As Integer

        Public Function SeleccionarRegistrosFacturaSecuenciales(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosFacturaSecuenciales", True)
        End Function

        Public Function BuscarMayorIdFacturaSecuencial(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdFacturaSecuencial", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroFacturaSecuenciales() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroFacturaSecuenciales"
                .Parameters.AddWithValue("@ID_FACTURA_SECUENCIAL", SqlDbType.BigInt).Value = IdSecuenciales
                .Parameters.AddWithValue("@FECHA_EMISION_FACTURA_SECUENCIALES", SqlDbType.Int).Value = FechaSecuenciales
                .Parameters.AddWithValue("@CANTIDAD_FACTURA_SECUENCIALES", SqlDbType.NVarChar).Value = CantidadSecuenciales
                .Parameters.AddWithValue("@NUMERO_INICIAL_FACTURA_SECUENCIALES", SqlDbType.DateTime).Value = InicialSecuenciales
                .Parameters.AddWithValue("@NUMERO_FINAL_FACTURA_SECUENCIALES", SqlDbType.NVarChar).Value = FinalSecuenciales
                .Parameters.AddWithValue("@ACTUAL_FACTURA_SECUENCIALES", SqlDbType.BigInt).Value = ActualSecuenciales
                .Parameters.AddWithValue("@OBSERVACIONES_FACTURA_SECUENCIALES", SqlDbType.NVarChar).Value = ObservacionesSecuenciales
                .Parameters.AddWithValue("@ESTADO_FACTURA_SECUENCIALES", SqlDbType.Decimal).Value = EstadoSecuenciales
            End With
            Return comando
        End Function
        
    End Class
End Namespace
