Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace OPERACIONES
    Public Class ClassProgramacionOperaciones
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Idprogramcion As Integer
        Public Mes As String
        Public Anio As String
        Public Fechadesde As Date
        Public Fechahasta As Date
        Public Estado As Integer

        Public Function BuscarMayorIdProgramacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_programacion=CASE WHEN MAX(id_programacion) IS NULL THEN 0 ELSE MAX(id_programacion) End FROM PROGRAMACION_OPERATIVOS;", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_programacion")))
        End Function

        Public Function BuscarMesAnioUltimaProgramacion(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT top 1 * from programacion_operativos where estado > 0 order by anio_programacion desc, mes_programacion desc;", False)

        End Function

        Public Function FechaActual(ByVal tipoCon As TipoConexion) As DateTime
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT getDate();", False)
            Return If(data.Rows.Count = 0, DateTime.MinValue, CDate(data.Rows(0)(0)))
        End Function

        Public Function GetUltimaFechaProgramacion(ByVal tipoCon As TipoConexion) As DateTime
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select top 1 fecha_hasta from programacion_operativos where estado = 1 order by anio_programacion desc, mes_programacion desc;", False)
            Return If(data.Rows.Count = 0, DateTime.MinValue, CDate(data.Rows(0)(0)))
        End Function

        Public Function GetUltimaFechaProgramacionByMesAnio(ByVal tipoCon As TipoConexion, ByVal mes As Int16, ByVal ani As Int16) As DateTime
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"mes", SqlDbType.Int, mes})
            pars.Add(New Object() {"anio", SqlDbType.Int, ani})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select top 1 fecha_hasta from programacion_operativos where estado = 1  and mes_programacion = @mes and anio_programacion = @anio order by anio_programacion desc, mes_programacion desc;", False, pars)
            Return If(data.Rows.Count = 0, DateTime.MinValue, CDate(data.Rows(0)(0)))
        End Function

        Public Function SeleccionarProgramacionByFecha(ByVal tipoCon As TipoConexion, ByVal fecha As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"fecha", SqlDbType.DateTime, fecha})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from programacion_operativos where @fecha between fecha_desde and fecha_hasta and estado = 1 ;", False, pars)
        End Function

        Public Function SeleccionarProgramacionById(ByVal tipoCon As TipoConexion, ByVal id As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from programacion_operativos where id_programacion = @id;", False, pars)
        End Function

        Public Function BuscarProgramacion(ByVal tipoCon As TipoConexion, ByVal anio As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"anio", SqlDbType.Int, anio})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select id_programacion, 'PROGRAMACIÓN GENERAL DEL MES DE ' + dbo.MesEnLetrasPorNumero(mes_programacion) mes, anio_programacion, convert(NVARCHAR, fecha_desde, 105) desde, convert(NVARCHAR, fecha_hasta, 105) hasta, mes_programacion " & "from programacion_operativos where estado=1 and anio_programacion>= @anio;", False, pars)
        End Function

        Public Function RegistrarNuevoProgramacionMesOperacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into PROGRAMACION_OPERATIVOS values (@id_programacion,@mes,@anio,@desde,@hasta,@estado);"
                .Parameters.AddWithValue("@id_programacion", SqlDbType.Int).Value = Idprogramcion
                .Parameters.AddWithValue("@mes", SqlDbType.Int).Value = Mes
                .Parameters.AddWithValue("@anio", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@desde", SqlDbType.Timestamp).Value = Fechadesde
                .Parameters.AddWithValue("@hasta", SqlDbType.Timestamp).Value = Fechahasta
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function ExisteProgramacionMesAnio(ByVal tipoCon As TipoConexion, ByVal mes As Integer, ByVal anio As Integer) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"mes", SqlDbType.Int, mes})
            pars.Add(New Object() {"anio", SqlDbType.Int, anio})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) from PROGRAMACION_OPERATIVOS where estado<>0 and mes_programacion = @mes and anio_programacion = @anio;", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)(0)) > 0
        End Function

        Public Function CargarPersonalNoProgramacion(ByVal tipoCon As TipoConexion, ByVal idp As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, idp})

            If tipoCon = TipoConexion.Cisepro Then
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tab.id_personal, tab.apellidos + ' ' + tab.nombres nomina, (select top 1 si.nombre_sitio_trabajo + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo where dp.id_personal = tab.id_personal order by dp.id_programacion desc, dp.fecha_desde desc) ultima_asignacion, case when tab.ubicacion = 409 then 'ASPIRANTES PARA GUARDIAS' ELSE null END aspirante from (select pe.id_personal, pe.apellidos, pe.nombres, pe.ubicacion from personal pe where pe.estado_personal = 1 and pe.id_cargo_ocupacional = 22) as tab where tab.id_personal not in (select dp.id_personal from detalle_programacion dp where dp.id_programacion = @idp) order by tab.apellidos, tab.nombres;", False, pars)
            ElseIf tipoCon = TipoConexion.Seportpac Then
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tab.id_personal, tab.apellidos + ' ' + tab.nombres nomina, (select top 1 si.nombre_sitio_trabajo + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo where dp.id_personal = tab.id_personal order by dp.id_programacion desc, dp.fecha_desde desc) ultima_asignacion, case when tab.ubicacion = 33 then 'ASPIRANTES PARA GUARDIAS' ELSE null END aspirante from (select pe.id_personal, pe.apellidos, pe.nombres, pe.ubicacion from personal pe where pe.estado_personal = 1 and pe.id_cargo_ocupacional = 22) as tab where tab.id_personal not in (select dp.id_personal from detalle_programacion dp where dp.id_programacion = @idp) order by tab.apellidos, tab.nombres;", False, pars)
            Else
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tab.id_personal, tab.apellidos + ' ' + tab.nombres nomina, (select top 1 si.nombre_sitio_trabajo + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo where dp.id_personal = tab.id_personal order by dp.id_programacion desc, dp.fecha_desde desc) ultima_asignacion, case when tab.ubicacion = 3 then 'ASPIRANTES PARA GUARDIAS' ELSE null END aspirante from (select pe.id_personal, pe.apellidos, pe.nombres, pe.ubicacion from personal pe where pe.estado_personal = 1 and pe.id_cargo_ocupacional = 22) as tab where tab.id_personal not in (select dp.id_personal from detalle_programacion dp where dp.id_programacion = @idp) order by tab.apellidos, tab.nombres;", False, pars)
            End If
        End Function

        Public Function CargarSitiosNoProgramacion(ByVal tipoCon As TipoConexion, ByVal idp As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, idp})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select si.RIVER, cl.nompre_razon_social_cliente_genEral, si.NOMBRE_SITIO_TRABAJO, si.DIRECCION_SITIO_TRABAJO from sitios_trabajo si join cliente_general cl on si.id_cliente_general = cl.id_cliente_general where si.ESTADO > 0 and si.id_sitio_trabajo not in (select dp.id_puesto from DETALLE_PROGRAMACION dp where dp.ID_PROGRAMACION = @idp) order by si.river;", False, pars)
        End Function

        Public Function llenarGuardiasHorario(ByVal tipoCon As TipoConexion, ByVal desde As DateTime, ByVal hasta As DateTime, ByVal cedula As String, ByVal idHorario As Integer, ByVal sitio As String, ByVal river As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@desde", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@hasta", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"@cedula", SqlDbType.VarChar, cedula})
            pars.Add(New Object() {"@idh", SqlDbType.Int, idHorario})
            pars.Add(New Object() {"@sitio", SqlDbType.VarChar, sitio})
            pars.Add(New Object() {"@river", SqlDbType.VarChar, river})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_llenarHorarioGuardias", True, pars)

        End Function
    End Class
End Namespace

