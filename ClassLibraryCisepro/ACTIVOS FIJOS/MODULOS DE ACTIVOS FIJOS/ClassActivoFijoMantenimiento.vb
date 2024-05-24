Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS

    Public Class ClassActivoFijoMantenimiento

        Public Function BuscarMantenimientoPorIdMantenimientoProcesados(ByVal tipoCon As TipoConexion, ByVal idp As Long) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_MANTENIMIENTO", SqlDbType.BigInt, idp})
            Dim mant =  ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarMantenimientoPorIdMantenimientoProcesador", True, pars) 
            Dim dman =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_MANTENIMIENTOS WHERE ESTADO=1", False) 
            Dim sucu =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False) 
            Dim area =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False) 
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False) 
            Dim ds = New DataSet()
            dman.Fill(ds, "DETALLE_MANTENIMIENTOS")
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            sucu.Fill(ds, "SUCURSAL_GENERAL")
            area.Fill(ds, "AREA_GENERAL")
            gere.Fill(ds, "GERENCIAS_GENERAL")
            Return ds
        End Function

        Public Function BuscarMantenimientosDelDia(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant =  ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "buscarMantenimientosDelDia", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "DETALLE_MANTENIMIENTOS")
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            Return ds
        End Function

        Public Function BuscarMantenimientosDeSemana(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "buscarMantenimientosDeSemana", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "DETALLE_MANTENIMIENTOS")
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            Return ds
        End Function

        Public Function BuscarFichasMantenimiento(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "buscarFichasMantenimiento", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            Return ds
        End Function

        Public Function BuscarFichasMantenimientoNoCumplio(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "buscarFichasMantenimientoNoCumplio", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            Return ds
        End Function

        Public Function BuscarFichasMantenimientoCumplio(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "buscarFichasMantenimientoCumplio", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "ACTIVO_FIJO_MANTENIMIENTOS")
            Return ds
        End Function


        Public Function SeleccionarSolictudesMantenimientosPendiente(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSolictudesMantenimientosPendiente", True) 
        End Function

        Public Function SeleccionarSolictudesMantenimientosRealizadas(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSolictudesMantenimientosRealizadas", True) 
        End Function

        Public Function SeleccionarDetallesMantenimientoXidMantenimiento(ByVal tipoCon As TipoConexion, ByVal idMantenimiento As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_MANTENIMIENTO", SqlDbType.BigInt, idMantenimiento})
            Return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarDetallesMantenimientoXidMantenimiento", True, pars) 
        End Function

        Public Function SeleccionarAsientosMantenimientos(ByVal tipoCon As TipoConexion) As DataTable
            Return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarAsientosMantenimientos", True) 
        End Function

    End Class
End Namespace

