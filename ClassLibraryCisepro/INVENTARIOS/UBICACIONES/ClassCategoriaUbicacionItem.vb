Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UBICACIONES
    Public Class ClassCategoriaUbicacionItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCategoriaUbicacion As Int64
        Public NombreCategoriaUbicacion As String
        Public FechaCategoriaUbicacion As DateTime
        Public EstadoCategoriaUbicacion As Integer
        Public FilasTotal As Integer
        Public FilasVacias As Integer
        Public FilasUsadas As Integer
        Public IdBodega As Integer

        Public Function NuevaCategoriaUbicacionItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaCategoriaUbicacionItem"
                .Parameters.AddWithValue("@ID_CATEGORIA_UBICACION", SqlDbType.BigInt).Value = IdCategoriaUbicacion
                .Parameters.AddWithValue("@NOMBRE_CATEGORIA_UBICACION", SqlDbType.NVarChar).Value = NombreCategoriaUbicacion
                .Parameters.AddWithValue("@FECHA_CATEGORIA_UBICACION", SqlDbType.DateTime).Value = FechaCategoriaUbicacion
                .Parameters.AddWithValue("@ESTADO_CATEGORIA_UBICACION", SqlDbType.Int).Value = EstadoCategoriaUbicacion
                .Parameters.AddWithValue("@FILAS_TOTAL_CATEGORIA_UBICACION", SqlDbType.Int).Value = FilasTotal
                .Parameters.AddWithValue("@FILAS_VACIAS_CATEGORIA_UBICACION", SqlDbType.Int).Value = FilasVacias
                .Parameters.AddWithValue("@FILAS_USADAS__CATEGORIA_UBICACION", SqlDbType.Int).Value = FilasUsadas
                .Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodega
            End With
            Return comando
        End Function
         
        Public Function BuscarMayorIdCategoriaUbicacionItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCategoriaUbicacionItem", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarCategoriasUbicacionItemsActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCategoriasUbicacionItemsActivasDireccion", True) 
        End Function

        Public Function BuscaridCategoriaUbicacionXNombreXidBodega(ByVal tipoCon As TipoConexion, ByVal nombre As String, ByVal idBodega As Int64) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BODEGA", SqlDbType.BigInt, idBodega})
            pars.Add(New Object() {"NOMBRE_CATEGORIA_UBICACION", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscaridCategoriaUbicacionXNombreXidBodega", True, pars) 
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_CATEGORIA_UBICACION")))
        End Function

        Public Function ContarMayorIdBodegaxIdBodega(ByVal tipoCon As TipoConexion, ByVal idBodega As Boolean) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BODEGA", SqlDbType.BigInt, idBodega})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "contarMayorIdBodegaxIdBodega", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

