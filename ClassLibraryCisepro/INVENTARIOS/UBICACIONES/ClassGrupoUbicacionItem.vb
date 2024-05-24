Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UBICACIONES
    Public Class ClassGrupoUbicacionItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdGrupoUbicacion As Int64
        Public NombreGrupoUbicacion As String
        Public FechaGrupoUbicacion As DateTime
        Public EstadoGrupoUbicacion As Integer
        Public IdCategoriaUbicacion As Int64
        Public CasillerosTotal As Integer
        Public CasilleroVacios As Integer
        Public CasillerosUsados As Integer 
        Public IdBodegas As Int64

        Public Function NuevaGrupoUbicacionItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaGrupoUbicacionItem"
                .Parameters.AddWithValue("@ID_GRUPO_UBICACION", SqlDbType.BigInt).Value = IdGrupoUbicacion
                .Parameters.AddWithValue("@NOMBRE_GRUPO_UBICACION", SqlDbType.NVarChar).Value = NombreGrupoUbicacion
                .Parameters.AddWithValue("@FECHA_GRUPO_UBICACION", SqlDbType.DateTime).Value = FechaGrupoUbicacion
                .Parameters.AddWithValue("@ESTADO_GRUPO_UBICACION", SqlDbType.Int).Value = EstadoGrupoUbicacion
                .Parameters.AddWithValue("@ID_CATEGORIA_UBICACION", SqlDbType.BigInt).Value = IdCategoriaUbicacion
                .Parameters.AddWithValue("@CASILLEROS_TOTAL_CATEGORIA_UBICACION", SqlDbType.Int).Value = CasillerosTotal
                .Parameters.AddWithValue("@CASILLEROS_VACIAS_CATEGORIA_UBICACION", SqlDbType.Int).Value = CasilleroVacios
                .Parameters.AddWithValue("@CASILLEROS_USADAS_CATEGORIA_UBICACION", SqlDbType.Int).Value = CasillerosUsados
                .Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodegas
            End With
            Return comando
        End Function
       
        Public Function BuscarMayorIdGrupoUbicacionItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdGrupoUbicacionItem", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarGrupoUbicacionItemsActivas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarGrupoUbicacionItemsActivas", True) 
        End Function

        Public Function SeleccionarGrupoUbicacionItemsActivasXidBodegas(ByVal tipoCon As TipoConexion, ByVal IdBodega As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BODEGA", SqlDbType.VarChar, IdBodega})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarGrupoUbicacionItemsActivasXidBodegas", True, pars) 
        End Function


        Public Function ContarNombreXidGrupoXidBodega(ByVal tipoCon As TipoConexion, ByVal idCategoria As Int64, ByVal idBodega As Int64) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CATEGORIA_UBICACION", SqlDbType.Int, idCategoria})
            pars.Add(New Object() {"ID_BODEGA", SqlDbType.Int, idBodega})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "contarNombreXidGrupoXidBodega", True, pars) 
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("NOMBRE")))
        End Function

    End Class
End Namespace
