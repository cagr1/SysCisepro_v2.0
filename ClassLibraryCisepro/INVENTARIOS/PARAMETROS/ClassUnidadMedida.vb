Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.PARAMETROS
    Public Class ClassUnidadMedida
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdUnidadMedida As Integer
        Public DetalleUnidadMedida As String
        Public CodigoUnidadMedida As String
        Public EstadoUnidadMedida As Integer

        Public Function SeleccionarRegistrosUnidadMedida(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarRegistrosUnidadMedida", True) 
        End Function
         
        Public Function BuscarUnidadMedidaRepetida(ByVal tipoCon As TipoConexion, ByVal detalleUnidadMedida As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE_UNIDAD_MEDIDA", SqlDbType.NVarChar, detalleUnidadMedida})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarUnidadMedidaRepetida", True, pars) 
            Return data.Rows.Count <> 0 AndAlso CInt(data.Rows(0)("CANTIDAD")) > 0
        End Function

        Public Function BuscarMayorIdUnidadMedida(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarMayorIdUnidadMedida", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroUnidadMedida() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroUnidadMedida"
                .Parameters.AddWithValue("@ID_UNIDAD_MEDIDA", SqlDbType.Int).Value = IdUnidadMedida
                .Parameters.AddWithValue("@DETALLE_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = DetalleUnidadMedida
                .Parameters.AddWithValue("@CODIGO_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = CodigoUnidadMedida
                .Parameters.AddWithValue("@ESTADO_UNIDAD_MEDIDA", SqlDbType.Int).Value = EstadoUnidadMedida
            End With
            Return comando
        End Function
        Public Function NuevoRegistroUnidadMedida(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroUnidadMedida"
                .Parameters.AddWithValue("@ID_UNIDAD_MEDIDA", SqlDbType.Int).Value = idUnidadMedida
                .Parameters.AddWithValue("@DETALLE_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = detalleUnidadMedida
                .Parameters.AddWithValue("@CODIGO_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = codigoUnidadMedida
                .Parameters.AddWithValue("@ESTADO_UNIDAD_MEDIDA", SqlDbType.Int).Value = estadoUnidadMedida
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ModificarRegistroUnidadMedida() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroUnidadMedida"
                .Parameters.AddWithValue("@ID_UNIDAD_MEDIDA", SqlDbType.Int).Value = IdUnidadMedida
                .Parameters.AddWithValue("@DETALLE_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = DetalleUnidadMedida
                .Parameters.AddWithValue("@CODIGO_UNIDAD_MEDIDA", SqlDbType.NVarChar).Value = CodigoUnidadMedida
                .Parameters.AddWithValue("@ESTADO_UNIDAD_MEDIDA", SqlDbType.Int).Value = EstadoUnidadMedida
            End With
            Return comando
        End Function
       
    End Class
End Namespace

