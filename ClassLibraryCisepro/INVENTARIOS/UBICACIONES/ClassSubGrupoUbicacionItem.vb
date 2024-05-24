Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UBICACIONES
    Public Class ClassSubGrupoUbicacionItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSubGrupoUbicacion As Int64
        Public NombreSubGrupoUbicacion As String
        Public FechaSubGrupoUbicacion As DateTime
        Public EstadoSubGrupoUbicacion As Integer
        Public IdGrupoSubGrupoUbicacion As Int64

        Public Function NuevaSubGrupoUbicacion() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSubGrupoUbicacion"
                .Parameters.AddWithValue("@ID_SUB_GRUPO_UBICACION", SqlDbType.BigInt).Value = IdSubGrupoUbicacion
                .Parameters.AddWithValue("@NOMBRE_SUB_GRUPO_UBICACION", SqlDbType.NVarChar).Value = NombreSubGrupoUbicacion
                .Parameters.AddWithValue("@FECHA_SUB_GRUPO_UBICACION", SqlDbType.DateTime).Value = FechaSubGrupoUbicacion
                .Parameters.AddWithValue("@ESTADO_SUB_GRUPO_UBICACION", SqlDbType.Int).Value = EstadoSubGrupoUbicacion
                .Parameters.AddWithValue("@ID_GRUPO_UBICACION", SqlDbType.BigInt).Value = IdGrupoSubGrupoUbicacion
            End With
            Return comando
        End Function

        Public Function BuscarMayorIdSubGrupoUbicacionItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSubGrupoUbicacionItem", True)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_SUB_GRUPO_UBICACION")))
        End Function
         
        Public Function SeleccionarSubGrupoUbicacionXidGrupoUbicacion(ByVal tipoCon As TipoConexion, ByVal idGrupoUbicacion As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GRUPO_UBICACION", SqlDbType.VarChar, idGrupoUbicacion})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarSubGrupoUbicacionXidGrupoUbicacion", True, pars)
        End Function

    End Class
End Namespace

