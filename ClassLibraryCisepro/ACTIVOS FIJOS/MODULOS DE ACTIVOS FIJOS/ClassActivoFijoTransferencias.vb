Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
    Public Class ClassActivoFijoTransferencias
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public Fecha As DateTime
        Public IdPersonalAnterior As Integer
        Public IdPersonalNuevo As Integer
        Public NombreAutoriza As String
        Public RazonTransferencia As String
        Public UbicacionAnterior As String
        Public CustodioAnterior As String
        Public UbicacionNueva As String
        Public CustodioNuevo As String
        Public Estado As Integer 

        Public Function BuscarMayorIdActivoFijoTransferencia(ByVal tipoCon As TipoConexion) As Integer
            Dim data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdActivoFijoTransferencia", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoActivoFijoTransferencias() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoActivoFijoTransferencias"
                .Parameters.AddWithValue("@ID_TRANSFERENCIA", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ID_PERSONAL_ANTERIOR", SqlDbType.Int).Value = IdPersonalAnterior
                .Parameters.AddWithValue("@ID_PERSONAL_NUEVO", SqlDbType.Int).Value = IdPersonalNuevo
                .Parameters.AddWithValue("@NOMBRE_AUTORIZA", SqlDbType.NVarChar).Value = NombreAutoriza
                .Parameters.AddWithValue("@RAZON", SqlDbType.NVarChar).Value = RazonTransferencia
                .Parameters.AddWithValue("@UBICACION_ANTERIOR", SqlDbType.NVarChar).Value = UbicacionAnterior
                .Parameters.AddWithValue("@CUSTODIO_ANTERIOR", SqlDbType.NVarChar).Value = CustodioAnterior
                .Parameters.AddWithValue("@UBICACION_NUEVA", SqlDbType.NVarChar).Value = UbicacionNueva
                .Parameters.AddWithValue("@CUSTODIO_NUEVO", SqlDbType.NVarChar).Value = CustodioNuevo
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
        
        Public Function BuscarTransferenciaPorIdTransferencia(ByVal tipoCon As TipoConexion, ByVal idTransferencia As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_MANTENIMIENTO", SqlDbType.BigInt, idTransferencia})

            Dim tran =  ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarTransferenciaPorIdTransferencia", True, pars) 

            Dim dman =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_TRANSFERENCIAS WHERE ESTADO=1", False) 

            Dim sucu =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False) 

            Dim area =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False) 

            Dim gere =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False) 

            Dim ds = New DataSet()
            dman.Fill(ds, "DETALLE_TRANSFERENCIAS")
            tran.Fill(ds, "ACTIVO_FIJO_TRANSFERENCIAS")
            sucu.Fill(ds, "SUCURSAL_GENERAL")
            area.Fill(ds, "AREA_GENERAL")
            gere.Fill(ds, "GERENCIAS_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarTodosLosRegistrosTransferencias(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosTransferencias", True) 
        End Function

        Public Function SeleccionarTodosLosRegistrosTransferenciasPorFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosTransferenciasPorFecha", True, pars) 
        End Function

        Public Function SeleccionarTodosLosRegistrosTransferenciasPorCustodioAnterior(ByVal tipoCon As TipoConexion, ByVal cua As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CUSTODIO", SqlDbType.VarChar, cua})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosTransferenciasPorCustodioAnterior", True, pars) 
        End Function

        Public Function SeleccionarTodosLosRegistrosTransferenciasPorCustodioNuevo(ByVal tipoCon As TipoConexion, ByVal cua As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CUSTODIO", SqlDbType.VarChar, cua})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosTransferenciasPorCustodioNuevo", True, pars) 
        End Function

    End Class
End Namespace

