Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassSanciones
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSancion As Int64
        Public Tipo As String
        Public Detalle As String
        Public Valor As Decimal
        Public Estado As Int64
        Public Sancionpermiso As Int64

        Public Function BuscarMayorIdSancion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSancion", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarTiposSanciones(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select tipo_sancion TIPO from sanciones_personal where san_per = 0 group by tipo_sancion order by tipo_sancion;", False)
        End Function

        Public Function SeleccionarSancionesFiltro(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"filtro", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from sanciones_personal where san_per = 0 and estado = 1 and (tipo_sancion like ('%'+@filtro+'%') or detalle like ('%'+@filtro+'%')) order by tipo_sancion, detalle;", False, pars)
        End Function

        Public Function RegistrarNuevoSancionPersonalCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into sanciones_personal values (@id_sancion, @tipo_sancion, @detalle, @valor_descuento, @estado, @sanper);"
                .Parameters.AddWithValue("@id_sancion", SqlDbType.Int).Value = IdSancion
                .Parameters.AddWithValue("@tipo_sancion", SqlDbType.VarChar).Value = Tipo
                .Parameters.AddWithValue("@detalle", SqlDbType.VarChar).Value = Detalle
                .Parameters.AddWithValue("@valor_descuento", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@sanper", SqlDbType.Int).Value = Sancionpermiso
            End With
            Return comando
        End Function

        Public Function ModificarSancionPersonalCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update sanciones_personal set tipo_sancion=@tipo_sancion, detalle=@detalle, valor_descuento=@valor_descuento where id_sancion=@id_sancion;"
                .Parameters.AddWithValue("@id_sancion", SqlDbType.Int).Value = IdSancion
                .Parameters.AddWithValue("@tipo_sancion", SqlDbType.VarChar).Value = Tipo
                .Parameters.AddWithValue("@detalle", SqlDbType.VarChar).Value = Detalle
                .Parameters.AddWithValue("@valor_descuento", SqlDbType.Decimal).Value = Valor
            End With
            Return comando
        End Function

        Public Function AnularSancionPersonalCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update sanciones_personal set estado=@estado where id_sancion=@id_sancion;"
                .Parameters.AddWithValue("@id_sancion", SqlDbType.Int).Value = IdSancion
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

    End Class
End Namespace