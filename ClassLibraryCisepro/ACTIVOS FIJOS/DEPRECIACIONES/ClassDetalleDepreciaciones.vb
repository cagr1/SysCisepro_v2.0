Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.DEPRECIACIONES
    Public Class ClassDetalleDepreciaciones
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalle As Integer
        Public Fecha As DateTime
        Public NumeroDepreciacion As Integer
        Public ValorDepreciacion As Decimal
        Public ValorResidualDepreciacion As Decimal
        Public Estado As Integer
        Public IdDetalleGeneral As Integer


        

        Public Function BuscarMayorIdDetalleDepreciacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleDepreciacion", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        'Public Function BuscarMayorIdDetalleDepreciacion(ByVal tipoCon As TipoConexion) As Integer
        '    Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_DEPRECIACION = MAX(ID_DEPRECIACION) FROM DETALLE_DEPRECIACION", False)
        '    Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_DEPRECIACION")))
        'End Function

        Public Function BuscarIdDetalleDepreciacionRepetido(ByVal tipoCon As TipoConexion, ByVal id As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"iddepre", SqlDbType.Int, id})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarIdDetalleDepreciacionRepetido", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevaDetalleDepreciacion() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaDetalleDepreciacion"
                .Parameters.AddWithValue("@ID_DEPRECIACION", SqlDbType.Int).Value = IdDetalle
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NUM_DEPRECIACION", SqlDbType.Decimal).Value = NumeroDepreciacion
                .Parameters.AddWithValue("@VALOR_DEPRECIACION", SqlDbType.Decimal).Value = ValorDepreciacion
                .Parameters.AddWithValue("@VALOR_RESIDUAL_DEPRECIACION", SqlDbType.Decimal).Value = ValorResidualDepreciacion
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_DEPRECIACION_GENERAL", SqlDbType.Int).Value = IdDetalleGeneral
            End With
            Return comando
        End Function

        Public Function SeleccionarDetallesDepreciacionPorIdDepreciacion(ByVal tipoCon As TipoConexion, ByVal ids As List(Of String)) As DataTable

            Dim lids As String = ids.Aggregate("(", Function(current, id) current & (id & ","))
            lids = If(lids.EndsWith(","), lids.Substring(0, lids.Length - 1) & ")", lids & ")")

            'Dim pars = New List(Of Object())
            'pars.Add(New Object() {"ID_DEPRECIACION", SqlDbType.VarChar, id})
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.DETALLE_DEPRECIACION WHERE ESTADO=1 and ID_DEPRECIACION_GENERAL IN " & lids & " ORDER BY ID_DEPRECIACION_GENERAL", False)
            'Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesDepreciacionPorIdDepreciacion", True, pars)
        End Function

    End Class
End Namespace

