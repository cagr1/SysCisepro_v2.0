Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Public Class ClassRubrosFondoRotativo
    ''' <summary>
    ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
    ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
    ''' CON EL MISMO TIPO DE DATO
    ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
    Public IdRubro As Integer
    Public NombreRubro As String
    Public ValorRubro As Decimal
    Public EstadoRubro As Integer

    Public Function SeleccionarRegistrosRubros(ByVal tipoCon As TipoConexion) As DataTable
        Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "ConsultaRubros", False)
    End Function

    Public Function BuscarMayorIdRubros(ByVal tipoCon As TipoConexion) As Integer
        Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdRubros", False)
        Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
    End Function

    Public Function BuscarNombreRubrosXIdRubro(ByVal tipoCon As TipoConexion, ByVal nombre As String) As String
        Dim pars = New List(Of Object())
        pars.Add(New Object() {"ID_RUBRO", SqlDbType.NVarChar, nombre})
        Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreRubrosXIdRubro", True, pars)
        Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
    End Function

    Public Function NuevoRegistroRubros() As SqlCommand
        Dim comando = New SqlCommand
        With comando
            .CommandType = CommandType.StoredProcedure
            .CommandText = "NuevoRegistroRubros"
            .Parameters.AddWithValue("@ID_RUBRO", SqlDbType.Int).Value = IdRubro
            .Parameters.AddWithValue("@NOMBRE_RUBRO", SqlDbType.NVarChar).Value = NombreRubro
            .Parameters.AddWithValue("@VALOR_RUBRO", SqlDbType.Decimal).Value = ValorRubro
            .Parameters.AddWithValue("@ESTADO_RUBRO", SqlDbType.Int).Value = EstadoRubro
        End With
        Return comando
    End Function

    Public Function ModificarRegistrosRubros() As SqlCommand
        Dim comando = New SqlCommand
        With comando
            .CommandType = CommandType.StoredProcedure
            .CommandText = "ModificarRegistroRubros"
            .Parameters.AddWithValue("@ID_RUBRO", SqlDbType.Int).Value = IdRubro
            .Parameters.AddWithValue("@NOMBRE_RUBRO", SqlDbType.NVarChar).Value = NombreRubro
            .Parameters.AddWithValue("@VALOR_RUBRO", SqlDbType.Decimal).Value = ValorRubro
            .Parameters.AddWithValue("@ESTADO_RUBRO", SqlDbType.Int).Value = EstadoRubro
        End With
        Return comando
    End Function

End Class