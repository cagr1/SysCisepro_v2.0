Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
    Public Class ClassNumeroRegistroAsientoComprobanteCompra
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobante As Int64
        Public IdLibro As Int64
        Public IdAsiento As Int64
        Public NumeroRegistro As Int64

        Public Function BuscarNumeroRegistroAsientoPorNoComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUM", SqlDbType.NVarChar, "'%ID CC%" & parametroBusqueda & "%'"})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from ASIENTOS_LIBRO_DIARIO where DETALLE_TRANSACCION_ASIENTO like @NUM;", False, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNumeroRegistroAsientoPorIdComprobanteCompra(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE_COMPRA", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNumeroRegistroAsientoPorIdComprobanteCompra", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroNumeroRegistroAsientoComprobanteCompraCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroNumeroRegistroAsientoComprobanteCompra"
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = IdLibro
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO", SqlDbType.BigInt).Value = NumeroRegistro
            End With
            Return comando
        End Function

    End Class
End Namespace

