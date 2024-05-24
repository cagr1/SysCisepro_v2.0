Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassEvaluacionProveedoreServicios
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdEvaluacionProveedorServicios As Integer
        Public FechaEvaluacionProveedorServicios As DateTime
        Public InstalacionesEvaluacionProveedorServicios As Integer
        Public PersonalPropioEvaluacionProveedorServicios As Integer
        Public TransporteEvaluacionProveedorServicios As Integer
        Public TiempoRespuestaEvaluacionProveedorServicios As Integer
        Public CumplimientoTiemposEntregaEvaluacionProveedorServicios As Integer
        Public PrecioEvaluacionProveedorServicios As Integer
        Public CondicionesPagoEvaluacionProveedorServicios As Integer
        Public GarantiasEvaluacionProveedorServicios As Integer
        Public SoporteTecnicoEvaluacionProveedorServicios As Integer
        Public DocumentosActualizadosEvaluacionProveedorServicios As Integer
        Public TotalEvaluacionProveedorServicios As Integer
        Public EstadoEvaluacionProveedorServicios As Integer
        Public IdProveedorGeneral As Integer
        Public IdPersonal As Integer

        Public Function BuscarMayorIdEvaluacionProveedorServicios(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdEvaluacionProveedorServicios", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarEvaluacionProveedorServiciosXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarEvaluacionProveedorServiciosXRangoFechas", True, pars)
        End Function

        Public Function BuscarEvaluacionProveedorXIdEvaluacion(ByVal tipoCon As TipoConexion, ByVal idEvaluacionBusqueda As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.BigInt, idEvaluacionBusqueda})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarEvaluacionProveedorServiciosXIdEvaluacion", True, pars)

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVEEDOR_GENERAL WHERE ESTADO_PROVEEDOR_GENERAL=1", False)

            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False)

            Dim ds = New DataSet()
            acts.Fill(ds, "EVALUACION_PROVEEDOR_SERVICIOS")
            empr.Fill(ds, "PROVEEDOR_GENERAL")
            sucu.Fill(ds, "PERSONAL")
            Return ds
        End Function
         
        Public Function NuevoRegistroEvaluacionProveedorServicios(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroEvaluacionProveedorServicios"
                .Parameters.AddWithValue("@ID_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = IdEvaluacionProveedorServicios
                .Parameters.AddWithValue("@FECHA_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.DateTime).Value = FechaEvaluacionProveedorServicios
                .Parameters.AddWithValue("@INSTALACIONES_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = InstalacionesEvaluacionProveedorServicios
                .Parameters.AddWithValue("@PERSONAL_PROPIO_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = PersonalPropioEvaluacionProveedorServicios
                .Parameters.AddWithValue("@TRANSPORTE_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = TransporteEvaluacionProveedorServicios
                .Parameters.AddWithValue("@TIEMPO_RESPUESTA_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = TiempoRespuestaEvaluacionProveedorServicios
                .Parameters.AddWithValue("@CUMPLIMIENTO_TIEMPOS_ENTREGA_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = CumplimientoTiemposEntregaEvaluacionProveedorServicios
                .Parameters.AddWithValue("@PRECIO_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = PrecioEvaluacionProveedorServicios
                .Parameters.AddWithValue("@CONDICIONES_PAGO_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = CondicionesPagoEvaluacionProveedorServicios
                .Parameters.AddWithValue("@GARANTIAS_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = GarantiasEvaluacionProveedorServicios
                .Parameters.AddWithValue("@SOPORTE_TECNICO_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = SoporteTecnicoEvaluacionProveedorServicios
                .Parameters.AddWithValue("@DOCUMENTOS_ACTUALIZADOS_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = DocumentosActualizadosEvaluacionProveedorServicios
                .Parameters.AddWithValue("@TOTAL_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = TotalEvaluacionProveedorServicios
                .Parameters.AddWithValue("@ESTADO_EVALUACION_PROVEEDOR_SERVICIOS", SqlDbType.Int).Value = EstadoEvaluacionProveedorServicios
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

