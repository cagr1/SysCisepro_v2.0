Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassNumeroRegistroAsientoComprobanteEgreso
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobanteEgreso As Int64
        Public IdLibro As Int64
        Public IdAsiento As Int64
        Public NumeroRegistro As Int64

        Public Function BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNumeroRegistroAsientoPorIdComprobanteEgreso", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroNumeroRegistroAsientoComprobanteEgreso() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroNumeroRegistroAsientoComprobanteEgreso"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = IdLibro
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO", SqlDbType.BigInt).Value = NumeroRegistro
            End With
            Return comando
        End Function
        Public Function NuevoRegistroNumeroRegistroAsientoComprobanteEgreso(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroNumeroRegistroAsientoComprobanteEgreso"
                .Parameters.AddWithValue("@ID_COMPROBANTE_EGRESO_BANCOS", SqlDbType.BigInt).Value = IdComprobanteEgreso
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = IdLibro
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO", SqlDbType.BigInt).Value = NumeroRegistro
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

