Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.PARAMETROS
    Public Class ClassMaterial
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdMaterial As Integer
        Public DetalleMaterial As String
        Public EstadoMaterial As String

        Public Function SeleccionarTodosLosRegistrosMaterial(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosMaterial", True) 
        End Function

        Public Function NuevaMaterial() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaMaterial"
                .Parameters.AddWithValue("@ID_MATERIAL", SqlDbType.Int).Value = IdMaterial
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = DetalleMaterial
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = EstadoMaterial
            End With
            Return comando
        End Function
        Public Function NuevaMaterial(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaMaterial"
                .Parameters.AddWithValue("@ID_MATERIAL", SqlDbType.Int).Value = idMaterial
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = detalleMaterial
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estadoMaterial
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarMayorIdMaterial(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdMaterial", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMaterialRepetida(ByVal tipoCon As TipoConexion, ByVal detalleMaterial As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, detalleMaterial})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarMaterialRepetida", True, pars) 
            Return data.Rows.Count <> 0 AndAlso CInt(data.Rows(0)("CANTIDAD")) > 0
        End Function

    End Class
End Namespace

