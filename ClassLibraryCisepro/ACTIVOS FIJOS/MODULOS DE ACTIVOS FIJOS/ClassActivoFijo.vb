Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
    Public Class ClassActivoFijo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivoFijo As Integer
        Public IdPersonal As Integer
        Public IdEmpresa As Integer
        Public IdSucursal As Integer
        Public IdGerencias As Integer
        Public IdAreas As Integer
        Public Carpeta As String
        Public Contrato As String
        Public Codigo As String
        Public NombreActivo As String
        Public NombreProvedor As String
        Public NombreCustodio As String
        Public Responsable As String
        Public Fecha As DateTime
        Public CodigoArancel As String
        Public NumeroOrdenCompra As String
        Public NumeroFactura As String
        Public ValorFactura As Decimal
        Public ValorAdicional As Decimal
        Public ValorResidual As Decimal
        Public FechaAdquisicion As DateTime
        Public AnosVidaUtil As Integer
        Public CuentaActivo As String
        Public CuentaGastos As String
        Public CuentaDepreciacion As String
        Public Estado As Integer
        Public EstadoActivo As String
        Public TipoActivo As String
        Public Mantenimiento As String
        Public FechaMantenimiento As DateTime
        Public IdSitio As Integer
        Public IdProveedorGeneral As Integer 

        Public Function NuevaActivoFijo() As SqlCommand
            Dim comando = New SqlCommand
            With comando 
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaActivoFijo"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal
                .Parameters.AddWithValue("@ID_GERENCIAS", SqlDbType.Int).Value = IdGerencias
                .Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdAreas
                .Parameters.AddWithValue("@CARPETA", SqlDbType.NVarChar).Value = Carpeta
                .Parameters.AddWithValue("@CONTRATO", SqlDbType.NVarChar).Value = Contrato
                .Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@NOMBRE_ACTIVO", SqlDbType.NVarChar).Value = NombreActivo
                .Parameters.AddWithValue("@NOMBRE_PROVEDOR", SqlDbType.NVarChar).Value = NombreProvedor
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO", SqlDbType.NVarChar).Value = NombreCustodio
                .Parameters.AddWithValue("@RESPONSABLE", SqlDbType.NVarChar).Value = Responsable
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@CODIGO_ARANCEL", SqlDbType.NVarChar).Value = CodigoArancel
                .Parameters.AddWithValue("@NUM_ORDEN_COMPRA", SqlDbType.NVarChar).Value = NumeroOrdenCompra
                .Parameters.AddWithValue("@NUM_FACTURA", SqlDbType.NVarChar).Value = NumeroFactura
                .Parameters.AddWithValue("@VALOR_FACTURA", SqlDbType.Decimal).Value = ValorFactura
                .Parameters.AddWithValue("@VALOR_ADICIONAL", SqlDbType.Decimal).Value = ValorAdicional
                .Parameters.AddWithValue("@VALOR_RESIDUAL", SqlDbType.Decimal).Value = ValorResidual
                .Parameters.AddWithValue("@FECHA_ADQUISICION", SqlDbType.DateTime).Value = FechaAdquisicion
                .Parameters.AddWithValue("@AÑOS_VIDA_UTIL", SqlDbType.Int).Value = AnosVidaUtil
                .Parameters.AddWithValue("@CTA_ACTIVO", SqlDbType.NVarChar).Value = CuentaActivo
                .Parameters.AddWithValue("@CTA_GASTOS", SqlDbType.NVarChar).Value = CuentaGastos
                .Parameters.AddWithValue("@CTA_DEPRECIACION", SqlDbType.NVarChar).Value = CuentaDepreciacion
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ESTADO_ACTIVO", SqlDbType.Int).Value = EstadoActivo
                .Parameters.AddWithValue("@TIPO_ACTIVO", SqlDbType.NVarChar).Value = TipoActivo
                .Parameters.AddWithValue("@MANTENIMIENTO", SqlDbType.NVarChar).Value = Mantenimiento
                .Parameters.AddWithValue("@FECHA_MANTENIMIENTO", SqlDbType.DateTime).Value = FechaMantenimiento
                .Parameters.AddWithValue("@ID_SITIO", SqlDbType.Int).Value = IdSitio
                .Parameters.AddWithValue("@ID_PROOVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
            End With
            Return comando
        End Function 
        
        Public Function BuscarMayorIdActivoFijo(ByVal tipoCon As TipoConexion) As Integer
            Dim data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdActivoFijo", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdActivoFijoCodigo(ByVal tipoCon As TipoConexion, ByVal cod As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO", SqlDbType.NVarChar, cod})
            Dim data =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdActivoFijoCodigo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreActivoFijoXIdActivoFijo(ByVal tipoCon As TipoConexion, ByVal idActivoF As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.Int, idActivoF})
            Dim data =   ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreActivoFijoXIdActivoFijo", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarTodosRegistrosActivosFijos(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosRegistrosActivosFijos", True) 
        End Function

        Public Function SeleccionarTodosRegistrosActivosFijosPorIdPersona(ByVal tipoCon As TipoConexion, ByVal idp As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.BigInt, idp})

            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarTodosRegistrosActivosFijosPorIdPersona", True, pars)

            Dim empr =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.EMPRESA_GENERAL WHERE ESTADO_EMPRESA=1", False) 

            Dim sucu =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False) 

            Dim area =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False) 

            Dim gere =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False) 

            Dim pers =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False) 

            Dim sits =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SITIOS_TRABAJO", False) 

            Dim ds = New DataSet()
            acts.Fill(ds, "ACTIVO_FIJO_GENERAL")
            empr.Fill(ds, "EMPRESA_GENERAL")
            sucu.Fill(ds, "SUCURSAL_GENERAL")
            area.Fill(ds, "AREA_GENERAL")
            gere.Fill(ds, "GERENCIAS_GENERAL")
            pers.Fill(ds, "PERSONAL")
            sits.Fill(ds, "SITIOS_TRABAJO")
            Return ds
        End Function

        Public Function BuscarPorCodigoActivoFijo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODIGO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorCodigoActivoFijo", True, pars) 
        End Function

        Public Function BuscarPorCustodioActivoFijo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_CUSTODIO", SqlDbType.VarChar, parametroBusqueda})
            Return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorCustodioActivoFijo", True, pars) 
        End Function

        Public Function ActualizarCustodiosDeActivosFijosPorTransferencias() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarCustodiosDeActivosFijosPorTransferencias"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO", SqlDbType.NVarChar).Value = NombreCustodio
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal
                .Parameters.AddWithValue("@ID_GERENCIAS", SqlDbType.Int).Value = IdGerencias
                .Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdAreas
                .Parameters.AddWithValue("@ESTADO_ACTIVO", SqlDbType.NVarChar).Value = EstadoActivo
            End With
            Return comando
        End Function
        
        Public Function BajaArmas(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaArmas"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaRadios(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaRadios"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaVehiculos(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaVehiculos"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaTerrenos(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaTerrenos"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposComputo(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposComputo"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaLibrosYColecciones(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaLibrosYColecciones"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposOficina(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposOficina"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaMueblesOficina(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaMueblesOficina"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposCocina(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposCocina"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposAmbientacion(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposAmbientacion"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposComunicacion(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposComunicacion"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaEquiposSeguridadIndustrial(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaEquiposSeguridadIndustrial"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaCamarasSeguridad(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaCamarasSeguridad"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaGeneradores(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaGeneradores"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajaChalecos(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajaChalecos"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function BajasSoftware(ByVal ida As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "bajasSoftware"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
            End With
            Return comando
        End Function 

        Public Function ActualizarActivoFijoPoRotacionCustodio(ByVal ida As Integer, ByVal fc As DateTime, ByVal idp As Integer, ByVal nc As String) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarActivoFijoPoRotacionCustodio"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = ida
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = fc
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = idp
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO", SqlDbType.NVarChar).Value = nc
            End With
            Return comando
        End Function
         
        Public Function ActualizarFechaMantenimientoDeActivosFijosGeneral(ByVal idActivoFijoMantenimiento As Integer, ByVal fechaNuevoMantenimiento As DateTime) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarFechaMantenimientoDeActivosFijosGeneral"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = idActivoFijoMantenimiento
                .Parameters.AddWithValue("@FECHA_MANTENIMIENTO", SqlDbType.DateTime).Value = fechaNuevoMantenimiento
            End With
            Return comando
        End Function

        Public Function SeleccionarMantenimientosProximosSemana(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarMantenimientosProximosSemana", True) 
        End Function

        Public Function SeleccionarMantenimientosProximosTodos(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarMantenimientosProximosTodos", True) 
        End Function

        Public Function BuscarIdActivoActivoFijoPorNombreActivo(ByVal tipoCon As TipoConexion, ByVal nombre As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_ACTIVO", SqlDbType.NVarChar, nombre})
            Dim data =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdActivoActivoFijoPorNombreActivo", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarActivoFijoXnombrexEquipoAmbientación(ByVal tipoCon As TipoConexion, ByVal nombre As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_ACTIVO", SqlDbType.NVarChar, nombre})
            Return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarActivoFijoXnombrexEquipoAmbientación", True, pars) 
        End Function

        Public Function SeleccionarArmas(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarArmas", True) 
        End Function

        Public Function SeleccionarActivoFijoFiltro(ByVal tipoCon As TipoConexion, ByVal tipo As String, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"TIPO", SqlDbType.NVarChar, tipo})
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select af.ID_ACTIVO_FIJO AS ID, pe.APELLIDOS+' ' + pe.NOMBRES  AS 'CUSTODIO', em.NOMBRE_COMERCIAL_EMPRESA AS 'EMPRESA', su.NOMBRE_SUCURSAL AS 'SUCURSAL', ge.NOMBRE_GERENCIAS AS 'GERENCIAS', ar.NOMBRE_AREA	 AS 'AREA', af.CODIGO, af.NOMBRE_ACTIVO as 'NOMBRE ACTIVO', af.VALOR_FACTURA AS 'COSTO' from  ACTIVO_FIJO_GENERAL af join personal pe on af.ID_PERSONAL=pe.ID_PERSONAL join empresa_general em on af.ID_EMPRESA=em.ID_EMPRESA join sucursal_general su on af.ID_SUCURSAL=su.ID_SUCURSAL join gerencias_general ge on af.ID_GERENCIAS=ge.ID_GERENCIAS_GENERAL join area_general ar on af.ID_AREA=ar.ID_AREA_GENERAL WHERE AF.TIPO_ACTIVO=@TIPO AND (AF.CODIGO LIKE '%' + @FILTRO +  '%' OR af.NOMBRE_ACTIVO LIKE '%' + @FILTRO +  '%')", False, pars)
        End Function

        Public Function SelecionarCodigoActivoFijo(ByVal tipoCon As TipoConexion, ByVal id As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID", SqlDbType.NVarChar, id})
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select af.codigo as SERIE  from ACTIVO_FIJO_GENERAL where af.ID_ACTIVO_FIJO = @id AND AF.ESTADO = 1 ", True)


            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarRadios(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRadios", True) 
        End Function

        Public Function SeleccionarVehículos(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarVehículos", True) 
        End Function

        Public Function SeleccionarTerrenos(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTerrenos", True) 
        End Function

        Public Function SeleccionarEquiposdeComputo(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposdeComputo", True) 
        End Function

        Public Function SeleccionarLibrosYColecciones(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarLibrosYColecciones", True) 
        End Function

        Public Function SeleccionarEquiposDeOficina(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposDeOficina", True) 
        End Function

        Public Function SeleccionarMueblesDeOficina(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarMueblesDeOficina", True) 
        End Function

        Public Function SeleccionarEquiposDeCocina(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposDeCocina", True)
        End Function

        Public Function SeleccionarEquiposDeAmbientación(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposDeAmbientación", True) 
        End Function

        Public Function SeleccionarEquiposDeComunicacionYTelefonia(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposDeComunicacionYTelefonia", True) 
        End Function

        Public Function SeleccionarEquiposDeSeguridadIndustrial(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEquiposDeSeguridadIndustrial", True) 
        End Function

        Public Function SeleccionarCamarasSeguridad(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCamarasSeguridad", True) 
        End Function

        Public Function SeleccionarGeneradores(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarGeneradores", True) 
        End Function

        Public Function SeleccionarChalecos(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarChalecos", True) 
        End Function

        Public Function SeleccionarSoftware(ByVal tipoCon As TipoConexion) As DataTable
            Return   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSoftware", True) 
        End Function

        Public Function SeleccionaTotalActivosFijosValores(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionaTotalActivosFijosValores", True) 
        End Function

        Public Function BuscarActivoFijoPorSerie(ByVal tipoCon As TipoConexion, ByVal serie As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"SERIE", SqlDbType.NVarChar, serie})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdActivoActivoFijoPorNombreActivo", True, pars)
        End Function

        Public Function SeleccionarActivoFijoPorSerieNombreActivo(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@filtro", SqlDbType.NVarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleecionarActivoFijoxSeriexNombre", True, pars)
        End Function
    End Class
End Namespace


