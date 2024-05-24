Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.ITEMS
    Public Class ClassCategoriaItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCategoria As Int64
        Public NombreCategoria As String
        Public FechaCategoria As DateTime
        Public EstadoCategoria As Integer 

        Public Function NuevaCategoriaItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaCategoriaItem"
                .Parameters.AddWithValue("@ID_CATEGORIA_ITEM", SqlDbType.BigInt).Value = IdCategoria
                .Parameters.AddWithValue("@NOMBRE_CATEGORIA_ITEM", SqlDbType.NVarChar).Value = NombreCategoria
                .Parameters.AddWithValue("@FECHA_CATEGORIA_ITEM", SqlDbType.DateTime).Value = FechaCategoria
                .Parameters.AddWithValue("@ESTADO_CATEGORIA_ITEM", SqlDbType.Int).Value = EstadoCategoria
            End With
            Return comando
        End Function
        Public Function NuevaCategoriaItem(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaCategoriaItem"
                .Parameters.AddWithValue("@ID_CATEGORIA_ITEM", SqlDbType.BigInt).Value = idCategoria
                .Parameters.AddWithValue("@NOMBRE_CATEGORIA_ITEM", SqlDbType.NVarChar).Value = nombreCategoria
                .Parameters.AddWithValue("@FECHA_CATEGORIA_ITEM", SqlDbType.DateTime).Value = fechaCategoria
                .Parameters.AddWithValue("@ESTADO_CATEGORIA_ITEM", SqlDbType.Int).Value = estadoCategoria
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdCategoriaItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCategoriaItem", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarCategoriasItemsActivasTodas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from (select 0 ID, '-- TODAS --' nombre union select id_categoria_item ID, nombre_categoria_item NOMBRE from categoria_item) as tab order by tab.id", False)
        End Function

        Public Function SeleccionarCategoriasItemsActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCategoriasItemsActivas", True) 
        End Function

        Public Function BuscarIdCategoriaItemXnombreCategoriaItem(ByVal tipoCon As TipoConexion, ByVal nombreCategoriaItem As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CATEGORIA_ITEM", SqlDbType.NVarChar, nombreCategoriaItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCategoriaItemXnombreCategoriaItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

