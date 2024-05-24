Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassEvaluacionProveedorMateriales
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdEvaluacionProveedorMateriales As Integer
        Public FechaEvaluacionProveedorMateriales As DateTime
        Public CapacidadProvisionEvaluacionProveedorMateriales As Integer
        Public PuntosEntregaEvaluacionProveedorMateriales As Integer
        Public TiemposEntregaEvaluacionProveedorMateriales As Integer
        Public PrecioEvaluacionProveedorMateriales As Integer
        Public CondicionesPagoEvaluacionProveedorMateriales As Integer
        Public GarantiasEvaluacionProveedorMateriales As Integer
        Public SoporteTecnicoEvaluacionProveedorMateriales As Integer
        Public ServiciosAsociadosEvaluacionProveedorMateriales As Integer
        Public CalidadMaterialEvaluacionProveedorMateriales As Integer
        Public TotalEvaluacionProveedorMateriales As Integer
        Public EstadoEvaluacionProveedorMateriales As Integer
        Public IdProveedorGeneral As Integer
        Public IdPersonal As Integer

        Public Function BuscarMayorIdEvaluacionProveedorMateriales(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdEvaluacionProveedorMateriales", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarEvaluacionProveedorXIdProveedorYRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroIdProveedor As String, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.BigInt, parametroIdProveedor})
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarEvaluacionProveedorXIdProveedorYRangoFechas", True, pars)
        End Function

        Public Function BuscarEvaluacionProveedorMaterialesXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarEvaluacionProveedorMaterialesXRangoFechas", True, pars)
        End Function

        Public Function BuscarEvaluacionProveedorTodoXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarEvaluacionProveedorTodoXRangoFechas", True, pars)
        End Function

        Public Function BuscarEvaluacionProveedorXIdEvaluacion(ByVal tipoCon As TipoConexion, ByVal idEvaluacionBusqueda As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.BigInt, idEvaluacionBusqueda})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarEvaluacionProveedorMaterialesXIdEvaluacion", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVEEDOR_GENERAL WHERE ESTADO_PROVEEDOR_GENERAL=1", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "EVALUACION_PROVEEDOR_MATERIALES")
            empr.Fill(ds, "PROVEEDOR_GENERAL")
            sucu.Fill(ds, "PERSONAL")
            Return ds
        End Function
         
        Public Function NuevoRegistroEvaluacionProveedorMateriales(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroEvaluacionProveedorMateriales"
                .Parameters.AddWithValue("@ID_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = IdEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@FECHA_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.DateTime).Value = FechaEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@CAPACIDAD_PROVISION_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = CapacidadProvisionEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@PUNTOS_ENTREGA_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = PuntosEntregaEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@TIEMPOS_ENTREGA_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = TiemposEntregaEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@PRECIO_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = PrecioEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@CONDICIONES_PAGO_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = CondicionesPagoEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@GARANTIAS_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = GarantiasEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@SOPORTE_TECNICO_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = SoporteTecnicoEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@SERVICIOS_ASOCIADOS_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = ServiciosAsociadosEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@CALIDAD_MATERIAL_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = CalidadMaterialEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@TOTAL_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = TotalEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@ESTADO_EVALUACION_PROVEEDOR_MATERIALES", SqlDbType.Int).Value = EstadoEvaluacionProveedorMateriales
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

