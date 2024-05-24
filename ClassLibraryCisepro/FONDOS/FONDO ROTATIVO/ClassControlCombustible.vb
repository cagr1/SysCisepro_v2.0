Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassControlCombustible
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdControl As Integer
        Public FechaControl As Date
        Public ValorControl As Decimal
        Public DestinoControl As String
        Public TotalKmControl As Integer
        Public EstadoControl As Integer
        Public MotivoControl As String
        Public IdSolicitudFr As Int64
        Public IdSolicitudCch As Int64
        Public IdActivo As Integer
        Public IdGastosFondoRotativo As Integer
        Public IdGastosCajaChica As Integer
        Public IdResponsableFondoRotativo As Integer
        Public IdResponsableCajaChica As Integer
        Public IdPersonal As Integer
        Public IdRubro As Integer
        Public IdSalida As Int64
        Public IdLlegada As Int64

        Public Function SeleccionarRegistrosControlCombustiblePorFecha(ByVal tipoCon As TipoConexion, ByVal fechaBusquedaInicial As DateTime, ByVal fechaBusquedaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaBusquedaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaBusquedaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarRegistrosControlCombustiblePorFecha", True, pars)
        End Function

        'Public Function SeleccionarRegistrosControlCombustible(ByVal tipoCon As TipoConexion) As DataTable
        '    Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosControlCombustible", True) 
        'End Function

        Public Function SeleccionarRegistrosControlCombustibleReporte(ByVal tipoCon As TipoConexion, ByVal idControlC As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONTROL_C", SqlDbType.BigInt, idControlC})
            Dim comb = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarControlCombustiblePorIdControl", True, pars)
            Dim soli = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SOLICITUD_FONDO_ROTATIVO", False)
            Dim gast = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GASTOS_FONDO_ROTATIVO WHERE ESTADO_GASTOS_FR = 1", False)
            Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RESPONSABLE_AUTORIZACION_FONDO_ROTATIVO WHERE ESTADO_RESPONSABLE_AUTO_FR = 1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL = 1", False)
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS = 1", False)
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES = 1", False)
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS WHERE ESTADO_PARROQUIAS = 1", False)
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CENTRO_COSTO WHERE ESTADO_CENTRO_COSTO = 1", False)
            Dim rubr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RUBROS WHERE ESTADO_RUBRO = 1", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1 AND TIPO_ACTIVO='VEHÍCULOS'", False)
            Dim vehi = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.VEHICULOS WHERE ESTADO=1", False)
            Dim sali = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SALIDA_VEHICULO WHERE ESTADO_SALIDA_V = 1", False)
            Dim lleg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.LLEGADA_VEHICULO WHERE ESTADO_LLEGADA_V = 1", False)

            Dim ds = New DataSet()
            comb.Fill(ds, "CONTROL_COMBUSTIBLES")
            soli.Fill(ds, "SOLICITUD_FONDO_ROTATIVO")
            gast.Fill(ds, "GASTOS_FONDO_ROTATIVO")
            resp.Fill(ds, "RESPONSABLE_AUTORIZACION_FONDO_ROTATIVO")
            pers.Fill(ds, "PERSONAL")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            cent.Fill(ds, "CENTRO_COSTO")
            rubr.Fill(ds, "RUBROS")
            acti.Fill(ds, "ACTIVO_FIJO_GENERAL")
            vehi.Fill(ds, "VEHICULOS")
            sali.Fill(ds, "SALIDA_VEHICULO")
            lleg.Fill(ds, "LLEGADA_VEHICULO")
            Return ds
        End Function

        Public Function SeleccionarRegistrosControlCombustibleReporteCajaChica(ByVal tipoCon As TipoConexion, ByVal idControlC As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONTROL_C", SqlDbType.BigInt, idControlC})
            Dim comb = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarControlCombustiblePorIdControl", True, pars)
            Dim gast = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GASTOS_CAJA_CHICA WHERE ESTADO=1", False)
            Dim rubr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RUBROS WHERE ESTADO_RUBRO = 1", False)
            Dim sali = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SALIDA_VEHICULO WHERE ESTADO_SALIDA_V = 1", False)
            Dim lleg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.LLEGADA_VEHICULO WHERE ESTADO_LLEGADA_V = 1", False)
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CENTRO_COSTO WHERE ESTADO_CENTRO_COSTO = 1", False)
            Dim vehi = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.VEHICULOS WHERE ESTADO=1", False)
            Dim soli = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SOLICITUD_CAJA_CHICA WHERE ESTADO_SOLICITUD_CCH>0", False)
            Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.CAJA_CHICA", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1 AND TIPO_ACTIVO='VEHÍCULOS'", False)
            Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RESPONSABLE_AUTORIZACION_FONDO_CAJA WHERE ESTADO_RESPONSABLE_AUTO_CCH=1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL = 1", False)
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS = 1", False)
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES = 1", False)
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS WHERE ESTADO_PARROQUIAS = 1", False)

            Dim ds = New DataSet()
            comb.Fill(ds, "CONTROL_COMBUSTIBLES")
            soli.Fill(ds, "SOLICITUD_CAJA_CHICA")
            gast.Fill(ds, "GASTOS_CAJA_CHICA")
            resp.Fill(ds, "RESPONSABLE_AUTORIZACION_FONDO_CAJA")
            pers.Fill(ds, "PERSONAL")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            cent.Fill(ds, "CENTRO_COSTO")
            rubr.Fill(ds, "RUBROS")
            acti.Fill(ds, "ACTIVO_FIJO_GENERAL")
            vehi.Fill(ds, "VEHICULOS")
            sali.Fill(ds, "SALIDA_VEHICULO")
            lleg.Fill(ds, "LLEGADA_VEHICULO")
            caja.Fill(ds, "CAJA_CHICA")
            Return ds
        End Function

        Public Function BuscarMayorIdControlCombustible(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdControlCombustibles", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        'Public Function NuevoRegistroControlCombustibles() As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "NuevoRegistroControlCombustibles"
        '        .Parameters.AddWithValue("@ID_CONTROL_C", SqlDbType.Int).Value = IdControl
        '        .Parameters.AddWithValue("@FECHA_CONTROL_C", SqlDbType.DateTime).Value = FechaControl
        '        .Parameters.AddWithValue("@VALOR_CONTROL_C", SqlDbType.Decimal).Value = ValorControl
        '        .Parameters.AddWithValue("@DESTINO_CONTROL_C", SqlDbType.NVarChar).Value = DestinoControl
        '        .Parameters.AddWithValue("@TOTAL_KM_CONTROL_C", SqlDbType.Int).Value = TotalKmControl
        '        .Parameters.AddWithValue("@ESTADO_CONTROL_C", SqlDbType.Int).Value = EstadoControl
        '        .Parameters.AddWithValue("@MOTIVO_CONTROL_C", SqlDbType.NVarChar).Value = MotivoControl
        '        .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitudFr
        '        .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolicitudCch
        '        .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivo
        '        .Parameters.AddWithValue("@ID_GASTOS_FR", SqlDbType.Int).Value = IdGastosFondoRotativo
        '        .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_FR", SqlDbType.Int).Value = IdResponsableFondoRotativo
        '        .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
        '        .Parameters.AddWithValue("@ID_RUBRO", SqlDbType.Int).Value = IdRubro
        '        .Parameters.AddWithValue("@ID_SALIDA_V", SqlDbType.BigInt).Value = IdSalida
        '        .Parameters.AddWithValue("@ID_LLEGADA_V", SqlDbType.BigInt).Value = IdLlegada
        '        .Parameters.AddWithValue("@ID_GASTOS_CCH", SqlDbType.Int).Value = IdGastosFondoRotativo
        '        .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = IdResponsableFondoRotativo
        '    End With
        '    Return comando
        'End Function

        'Public Function SeleccionarVehiculosControlCombustible(ByVal tipoCon As TipoConexion) As DataSet
        '    Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarVehiculosControlCombustible", True) 
        '    Dim ds = New DataSet()
        '    caja.Fill(ds, "VEHICULOS")
        '    caja.Fill(ds, "ACTIVO_FIJO_GENERAL")
        '    Return ds
        'End Function

        Public Function NuevoRegistroControlCombustiblesCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroControlCombustibles"
                .Parameters.AddWithValue("@ID_CONTROL_C", SqlDbType.Int).Value = IdControl
                .Parameters.AddWithValue("@FECHA_CONTROL_C", SqlDbType.DateTime).Value = FechaControl
                .Parameters.AddWithValue("@VALOR_CONTROL_C", SqlDbType.Decimal).Value = ValorControl
                .Parameters.AddWithValue("@DESTINO_CONTROL_C", SqlDbType.NVarChar).Value = DestinoControl
                .Parameters.AddWithValue("@TOTAL_KM_CONTROL_C", SqlDbType.Int).Value = TotalKmControl
                .Parameters.AddWithValue("@ESTADO_CONTROL_C", SqlDbType.Int).Value = EstadoControl
                .Parameters.AddWithValue("@MOTIVO_CONTROL_C", SqlDbType.NVarChar).Value = MotivoControl
                .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitudFr
                .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolicitudCch
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivo
                .Parameters.AddWithValue("@ID_GASTOS_FR", SqlDbType.Int).Value = IdGastosFondoRotativo
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_FR", SqlDbType.Int).Value = IdResponsableFondoRotativo
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_RUBRO", SqlDbType.Int).Value = IdRubro
                .Parameters.AddWithValue("@ID_SALIDA_V", SqlDbType.BigInt).Value = IdSalida
                .Parameters.AddWithValue("@ID_LLEGADA_V", SqlDbType.BigInt).Value = IdLlegada
                .Parameters.AddWithValue("@ID_GASTOS_CCH", SqlDbType.Int).Value = IdGastosFondoRotativo
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = IdResponsableFondoRotativo
            End With
            Return comando
        End Function

    End Class
End Namespace