Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
    Public Class ClassVehiculo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivo As Integer
        Public Marca As String
        Public Modelo As String
        Public Serie As String
        Public Chasis As String
        Public EstadoActivo As String
        Public Placas As String
        Public Motor As String
        Public Cilindraje As String
        Public Capacidad As String
        Public Tipo As String
        Public Color As String
        Public Anio As Integer
        Public Aseguradora As String
        Public Seguro As String
        Public Broker As String
        Public NumeroPoliza As String
        Public CostoPrima As Decimal
        Public DispositivoSeguridad As String
        Public FechaInicioContrato As DateTime
        Public FechaFinalContrato As DateTime
        Public FechaRenovacionContrato As DateTime
        Public FechaInicioDispositivoSeguridad As DateTime
        Public FechaFinalDispositivoSeguridad As DateTime
        Public FechaRenovacionDispositivoSeguridad As DateTime
        Public Estado As Integer
        Public Soat As DateTime

        Public Function NuevoVehiculos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoVehiculos"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivo
                .Parameters.AddWithValue("@MARCA", SqlDbType.NVarChar).Value = Marca
                .Parameters.AddWithValue("@MODELO", SqlDbType.NVarChar).Value = Modelo
                .Parameters.AddWithValue("@SERIE", SqlDbType.NVarChar).Value = Serie
                .Parameters.AddWithValue("@CHASIS", SqlDbType.NVarChar).Value = Chasis
                .Parameters.AddWithValue("@ESTADO_ACTIVO", SqlDbType.NVarChar).Value = EstadoActivo
                .Parameters.AddWithValue("@PLACAS", SqlDbType.NVarChar).Value = Placas
                .Parameters.AddWithValue("@MOTOR", SqlDbType.NVarChar).Value = Motor
                .Parameters.AddWithValue("@CILINDRAJE", SqlDbType.NVarChar).Value = Cilindraje
                .Parameters.AddWithValue("@CAPACIDAD", SqlDbType.NVarChar).Value = Capacidad
                .Parameters.AddWithValue("@TIPO", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@COLOR", SqlDbType.NVarChar).Value = Color
                .Parameters.AddWithValue("@ANO_FABRICACION", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@ASEGURADORA", SqlDbType.NVarChar).Value = Aseguradora
                .Parameters.AddWithValue("@SEGURO", SqlDbType.NVarChar).Value = Seguro
                .Parameters.AddWithValue("@BROKER", SqlDbType.NVarChar).Value = Broker
                .Parameters.AddWithValue("@NRO_POLIZA", SqlDbType.NVarChar).Value = NumeroPoliza
                .Parameters.AddWithValue("@COSTO_PRIMA", SqlDbType.Decimal).Value = CostoPrima
                .Parameters.AddWithValue("@DISPOSITIVO_SEGURIDAD", SqlDbType.NVarChar).Value = DispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", SqlDbType.DateTime).Value = FechaInicioContrato
                .Parameters.AddWithValue("@FECHA_FINAL_CONTRATO", SqlDbType.DateTime).Value = FechaFinalContrato
                .Parameters.AddWithValue("@FECHA_RENOVACION_CONTRATO", SqlDbType.DateTime).Value = FechaRenovacionContrato
                .Parameters.AddWithValue("@FECHA_INICIO_DIS_SEG", SqlDbType.DateTime).Value = FechaInicioDispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_FINAL_DIS_SEG", SqlDbType.DateTime).Value = FechaFinalDispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_RENOVACION_DIS_SEG", SqlDbType.DateTime).Value = FechaRenovacionDispositivoSeguridad
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@SOAT", SqlDbType.DateTime).Value = Soat
            End With
            Return comando
        End Function
        
        Public Function SeleccionarTodosLosRegistrosVehiculosFiltro(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim mant = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarTodosLosRegistrosVehiculosFiltro", True, pars) 

            Dim ds = New DataSet()
            mant.Fill(ds, "VEHICULOS")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarTodosLosRegistrosVehiculos(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarTodosLosRegistrosVehiculos", True) 

            Dim ds = New DataSet()
            mant.Fill(ds, "VEHICULOS")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarSoatProximosSemana(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarSoatProximosSemana", True) 
            Dim acfi = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False) 

            Dim ds = New DataSet()
            mant.Fill(ds, "VEHICULOS")
            acfi.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarSegurosProximosSemana(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarSegurosProximosSemana", True) 

            Dim ds = New DataSet()
            mant.Fill(ds, "VEHICULOS")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarDispositivosSeguridadProximosSemana(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarDispositivosSeguridadProximosSemana", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "VEHICULOS")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function BuscarPorCodigoVehiculo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorCodigoVehiculo", True, pars) 
        End Function

        Public Function BuscarPorPlacaVehiculo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"PLACAS", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorPlacaVehiculo", True, pars) 
        End Function

        Public Function ActualizarSegurosVehiculo() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarSegurosVehiculo"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivo
                .Parameters.AddWithValue("@ASEGURADORA", SqlDbType.NVarChar).Value = Aseguradora
                .Parameters.AddWithValue("@SEGURO", SqlDbType.NVarChar).Value = Seguro
                .Parameters.AddWithValue("@BROKER", SqlDbType.NVarChar).Value = Broker
                .Parameters.AddWithValue("@NRO_POLIZA", SqlDbType.NVarChar).Value = NumeroPoliza
                .Parameters.AddWithValue("@COSTO_PRIMA", SqlDbType.Decimal).Value = CostoPrima
                .Parameters.AddWithValue("@DISPOSITIVO_SEGURIDAD", SqlDbType.NVarChar).Value = DispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", SqlDbType.DateTime).Value = FechaInicioContrato
                .Parameters.AddWithValue("@FECHA_FINAL_CONTRATO", SqlDbType.DateTime).Value = FechaFinalContrato
                .Parameters.AddWithValue("@FECHA_RENOVACION_CONTRATO", SqlDbType.DateTime).Value = FechaRenovacionContrato
                .Parameters.AddWithValue("@FECHA_INICIO_DIS_SEG", SqlDbType.DateTime).Value = FechaInicioDispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_FINAL_DIS_SEG", SqlDbType.DateTime).Value = FechaFinalDispositivoSeguridad
                .Parameters.AddWithValue("@FECHA_RENOVACION_DIS_SEG", SqlDbType.DateTime).Value = FechaRenovacionDispositivoSeguridad
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@SOAT", SqlDbType.DateTime).Value = Soat
            End With
            Return comando
        End Function

        Public Function SeleccionarIngresosVehiculos(ByVal tipoCon As TipoConexion) As DataSet
            Dim obje = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.VEHICULOS  WHERE  ESTADO=1", False) 
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False) 
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EMPRESA_GENERAL WHERE  ESTADO_EMPRESA=1", False) 
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False) 
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False) 
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False) 
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False) 
            Dim carg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", False) 

            Dim ds = New DataSet()
            obje.Fill(ds, "TERRENOS")
            acti.Fill(ds, "ACTIVO_FIJO_GENERAL")
            empr.Fill(ds, "EMPRESA_GENERAL")
            pers.Fill(ds, "PERSONAL")
            sucu.Fill(ds, "SUCURSAL_GENERAL")
            gere.Fill(ds, "GERENCIAS_GENERAL")
            area.Fill(ds, "AREA_GENERAL")
            carg.Fill(ds, "CARGO_OCUPACIONAL")
            Return ds
        End Function
      
    End Class
End Namespace

