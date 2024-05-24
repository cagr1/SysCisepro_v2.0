Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
     
    Public Class ClassPlanillaCobrosPagos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdPlanilla As Integer
        Public NumComprobante As String
        Public Beneficiario As String
        Public TipoServicio As String
        Public FechaProceso As DateTime
        Public FechaVence As DateTime
        Public TipoCuenta As String
        Public NumCuenta As String
        Public Referencia As String
        Public TipoNegociacion As String
        Public CantCuentas As Integer
        Public TotCuentas As Decimal
        Public Estado As Integer
        Public Observacion As String

        Public Function BuscarMayorIdPlanilla(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdPlanillaCobrosPagos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))

        End Function

        Public Function CargarPlanillaCobrosPagosRecientesPorFecha(ByVal tipoCon As TipoConexion, ByVal fecha As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"f", SqlDbType.Date, fecha})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select ID_PLANILLA, FECHA_PROCESO, CANT_CUENTAS, TOTAL_CUENTAS FROM PLANILLA_COBROS_PAGOS WHERE FECHA_PROCESO>=@f order by FECHA_PROCESO", False, pars)
        End Function

        Public Function CargarPlanillaCobrosPagosPorId(ByVal tipoCon As TipoConexion, ByVal id As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.NVarChar, id})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * FROM PLANILLA_COBROS_PAGOS WHERE ID_PLANILLA=@id", False, pars)
        End Function

        Public Function CargarDetallesPlanillaCobrosPagosPorId(ByVal tipoCon As TipoConexion, ByVal id As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.NVarChar, id})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * FROM DETALLE_PLANILLA_COBROS_PAGOS WHERE ID_PLANILLA=@id", False, pars)
        End Function

        Public Function NuevoRegistroPlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO PLANILLA_COBROS_PAGOS VALUES (@ID_PLANILLA, @NUM_COMPROBANTE, @BENEFICIARIO, @TIPO_SERVICIO, @FECHA_PROCESO, @FECHA_VENCE, @TIPO_CUENTA, @NUM_CUENTA, @REFERENCIA, @TIPO_NEGOCIACION, @CANT_CUENTAS, @TOTAL_CUENTAS, @ESTADO, @OBSERVACION)"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@NUM_COMPROBANTE", SqlDbType.NVarChar).Value = NumComprobante
                .Parameters.AddWithValue("@BENEFICIARIO", SqlDbType.NVarChar).Value = Beneficiario
                .Parameters.AddWithValue("@TIPO_SERVICIO", SqlDbType.NVarChar).Value = TipoServicio
                .Parameters.AddWithValue("@FECHA_PROCESO", SqlDbType.Date).Value = FechaProceso
                .Parameters.AddWithValue("@FECHA_VENCE", SqlDbType.Date).Value = FechaVence
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCuenta
                .Parameters.AddWithValue("@NUM_CUENTA", SqlDbType.NVarChar).Value = NumCuenta
                .Parameters.AddWithValue("@REFERENCIA", SqlDbType.NVarChar).Value = Referencia
                .Parameters.AddWithValue("@TIPO_NEGOCIACION", SqlDbType.NVarChar).Value = TipoNegociacion
                .Parameters.AddWithValue("@CANT_CUENTAS", SqlDbType.Int).Value = CantCuentas
                .Parameters.AddWithValue("@TOTAL_CUENTAS", SqlDbType.Decimal).Value = TotCuentas
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            End With
            Return comando
        End Function

        Public Function NuevoRegistroPlanillaCobrosPagos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO PLANILLA_COBROS_PAGOS VALUES (@ID_PLANILLA, @NUM_COMPROBANTE, @BENEFICIARIO, @TIPO_SERVICIO, @FECHA_PROCESO, @FECHA_VENCE, @TIPO_CUENTA, @NUM_CUENTA, @REFERENCIA, @TIPO_NEGOCIACION, @CANT_CUENTAS, @TOTAL_CUENTAS, @ESTADO, @OBSERVACION)"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@NUM_COMPROBANTE", SqlDbType.NVarChar).Value = NumComprobante
                .Parameters.AddWithValue("@BENEFICIARIO", SqlDbType.NVarChar).Value = Beneficiario
                .Parameters.AddWithValue("@TIPO_SERVICIO", SqlDbType.NVarChar).Value = TipoServicio
                .Parameters.AddWithValue("@FECHA_PROCESO", SqlDbType.Date).Value = FechaProceso
                .Parameters.AddWithValue("@FECHA_VENCE", SqlDbType.Date).Value = FechaVence
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCuenta
                .Parameters.AddWithValue("@NUM_CUENTA", SqlDbType.NVarChar).Value = NumCuenta
                .Parameters.AddWithValue("@REFERENCIA", SqlDbType.NVarChar).Value = Referencia
                .Parameters.AddWithValue("@TIPO_NEGOCIACION", SqlDbType.NVarChar).Value = TipoNegociacion
                .Parameters.AddWithValue("@CANT_CUENTAS", SqlDbType.Int).Value = CantCuentas
                .Parameters.AddWithValue("@TOTAL_CUENTAS", SqlDbType.Decimal).Value = TotCuentas
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ModificarObservacionRegistroPlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE PLANILLA_COBROS_PAGOS SET OBSERVACION=@OBSERVACION WHERE ID_PLANILLA=@ID_PLANILLA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            End With
            Return comando
        End Function

        Public Function ModificarObservacionRegistroPlanillaCobrosPagos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE PLANILLA_COBROS_PAGOS SET OBSERVACION=@OBSERVACION WHERE ID_PLANILLA=@ID_PLANILLA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarPlanillaCobrosPagosxRengoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPlanillaCobrosPagosxRengoFechas", True, pars)
        End Function

        Public Function SeleccionarPlanillaCobrosPagosxNroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PLANILLA", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPlanillaCobrosPagosxNroComprobante", True, pars)
        End Function

        Public Function SeleccionarPlanillaCobrosPagosxDetalle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarPlanillaCobrosPagosxDetalle", True, pars)
        End Function




        Public Function EditarRegistroPlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE PLANILLA_COBROS_PAGOS SET CANT_CUENTAS=@CANT_CUENTAS, TOTAL_CUENTAS=@TOTAL_CUENTAS, OBSERVACION=@OBSERVACION WHERE ID_PLANILLA=@ID_PLANILLA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@CANT_CUENTAS", SqlDbType.Int).Value = CantCuentas
                .Parameters.AddWithValue("@TOTAL_CUENTAS", SqlDbType.Decimal).Value = TotCuentas
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion
            End With
            Return comando
        End Function
    End Class
End Namespace