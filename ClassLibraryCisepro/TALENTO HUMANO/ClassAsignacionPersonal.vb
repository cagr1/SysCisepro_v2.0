Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES

Namespace TALENTO_HUMANO
    Public Class ClassAsignacionPersonal
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdAsignacion As Int64
        Public IdPersonal As Int64
        Public IdRegistro As Int64
        Public IdPuesto As Int64
        Public IdHorario As Int64
        Public Estado As Int64
        Public Fecharegistro As Date
        Public IdpPogramacion As Int64
        Public Fecha As Date
        Public C50 As String
        Public C51 As String
        Public C40 As String
        Public C41 As String 
        Public Entrada As String
        Public Salida As String
        Public Tipo As String
        Public Cant As Integer 
        Public Observa As String
        Public Report As String 
        Public Iduser As Int32
        Public Horario As String

        Public Function BuscarMayorIdAsignacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdAsignacionPersonal", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarProgramacionByIdProgFecha(ByVal tipoCon As TipoConexion, ByVal idp As Integer, ByVal fechad As DateTime, ByVal fechah As DateTime) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id_programacion", SqlDbType.Int, idp})
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) cant from asignacion_personal where id_programacion=@id_programacion and fecha between @fechad and @fechah;", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)("cant")) > 0
        End Function

        Public Function RegistararNuevoAsignacionPersonalComman() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                '.CommandText = "DECLARE @con CHAR(1) = 'N';" & vbCrLf & "insert into asignacion_personal (id_asignacion, id_personal, id_puesto, id_horario, estado, fecha_registro, id_programacion, fecha, c50, c51, c40, c41, entrada, salida, tipo, cantrep, observacion, report, id_user, horario, fld_contar_multas)" & vbCrLf &
                ' "values (@id_asignacion, @id_personal, @id_puesto, @id_horario, @estado, @fecha_registro, @idp, @fecha, @c50, @c51, @c40, @c41,  @entrada, @salida,  @tipo, @cantrep, @observacion, @report, @id_user, @horario, (DATALENGTH(CAST(@report AS VARCHAR(MAX))) - DATALENGTH(REPLACE(CAST(@report AS VARCHAR(MAX)), @con, ''))));"


                '.CommandText = "INSERT INTO asignacion_personal (id_asignacion, id_personal, id_puesto, id_horario, estado, fecha_registro, id_programacion, fecha, c50, c51, c40, c41, entrada, salida, tipo, cantrep, observacion, report, id_user, horario, fld_contar_multas)" & vbCrLf &
                '               "VALUES (@id_asignacion, @id_personal, @id_puesto, @id_horario, @estado, @fecha_registro, @idp, @fecha, @c50, @c51, @c40, @c41,  @entrada, @salida,  @tipo, @cantrep, @observacion, @report, @id_user, @horario, @cantrep );" & vbCrLf
                .CommandText = "sp_registrarnuevoAsignacionPersonal"

                .Parameters.AddWithValue("@id_asignacion", SqlDbType.Int).Value = IdAsignacion
                .Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@id_puesto", SqlDbType.Int).Value = IdPuesto
                .Parameters.AddWithValue("@id_horario", SqlDbType.Int).Value = IdHorario
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@fecha_registro", SqlDbType.Date).Value = Fecharegistro
                .Parameters.AddWithValue("@id_programacion", SqlDbType.Int).Value = IdpPogramacion
                .Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = Fecha
                .Parameters.AddWithValue("@c50", SqlDbType.VarChar).Value = C50
                .Parameters.AddWithValue("@c51", SqlDbType.Date).Value = C51
                .Parameters.AddWithValue("@c40", SqlDbType.VarChar).Value = C40
                .Parameters.AddWithValue("@c41", SqlDbType.VarChar).Value = C41
                .Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = Tipo
                .Parameters.AddWithValue("@entrada", SqlDbType.VarChar).Value = Entrada
                .Parameters.AddWithValue("@salida", SqlDbType.VarChar).Value = Salida
                .Parameters.AddWithValue("@cantrep", SqlDbType.Int).Value = Cant
                .Parameters.AddWithValue("@observacion", SqlDbType.Text).Value = Observa
                .Parameters.AddWithValue("@report", SqlDbType.Text).Value = Report
                .Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = Iduser
                .Parameters.AddWithValue("@horario", SqlDbType.VarChar).Value = Horario

            End With
            Return comando
        End Function

        'Count N letters in the field report 2023
        Private Function CountOccurrencesOfN(ByVal report As String) As Integer
            Dim count As Integer = 0
            If Not String.IsNullOrEmpty(report) Then
                For Each c As Char In report
                    If c = "N"c Then
                        count += 1
                    End If
                Next
            End If
            Return count
        End Function


        Public Function DeleteRegistroNuevoAsignacionPersonalComman(ByVal idp As Integer, ByVal fecd As Date, ByVal fech As Date) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_deleteRegistroNuevaAsignacionPersonal"
                '.CommandText = "delete from asignacion_personal where id_programacion = @idp and fecha between @fecd and @fech;"
                .Parameters.AddWithValue("@idp", SqlDbType.Int).Value = idp
                .Parameters.AddWithValue("@fecd", SqlDbType.Date).Value = fecd
                .Parameters.AddWithValue("@fech", SqlDbType.Date).Value = fech

            End With
            Return comando
        End Function



        Public Function SeleccionarRegistroMultasDatosExceptoRadio(ByVal tipoCon As TipoConexion, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})

            Dim sql = "select p.apellidos + ' ' + p.nombres nombres, t.river, 1 rep, r.valor, s.tipo_sancion, s.detalle,d.observacion from registro_sanciones_personal r join sanciones_personal s on r.id_sancion=s.id_sancion join personal p on r.id_personal = p.id_personal join sitios_trabajo t on r.id_sitio=t.id_sitio_trabajo left join descuentos_rol d on r.id_descuento=d.id_registro where r.estado = 1 and s.tipo_sancion = 'MULTA' AND s.id_sancion <>28 and r.fecha between @DESDE and @HASTA order by p.apellidos, p.nombres"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarRegistroAsistenciaDatos(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select tab.id_personal, tab.cedula, tab.nomina, count(tab.fecha) dias, ingresa, sale, " & _
                    "(SELECT count(*) FROM DatesInRange('d', case when  (convert(varchar, ingresa, 23)+' 00:00:00') > @DESDE then (convert(varchar, ingresa, 23)+' 00:00:00') else @DESDE end, case when sale < (convert(varchar, ingresa, 23)+' 00:00:00') then @HASTA else case when sale < @HASTA then sale else @HASTA end end) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pr on ap.id_personal = pr.id_personal where pr.id_personal = tab.id_personal and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) libres, tab.estado_personal  " & _
                    "from (select pe.id_personal, pe.cedula, pe.apellidos + ' ' + pe.nombres nomina, ap.fecha, pe.fecha_entrada ingresa, pe.fecha_salida sale, (case when (pe.fecha_entrada > pe.fecha_salida) then 1 else case when (pe.fecha_salida < @HASTA) then 0 else 1 end end) estado_personal from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where ap.tipo <> 'PENDIENTE' and (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) and (ap.fecha between @DESDE and @HASTA) group by pe.id_personal, pe.cedula, pe.apellidos, pe.nombres, ap.fecha, pe.fecha_entrada, pe.fecha_salida, pe.estado_personal ) as tab group by tab.id_personal, tab.cedula, tab.nomina, tab.ingresa, tab.sale, tab.sale,tab.estado_personal order by tab.nomina"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarRegistroAsistenciaDetallesByGuardia(ByVal tipoCon As TipoConexion, ByVal libres As Boolean, ByVal idp As Int32, ByVal desde As DateTime, ByVal hasta As DateTime, ByVal ingreso As DateTime, ByVal sale As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"idp", SqlDbType.VarChar, idp})
            If libres Then
                pars.Add(New Object() {"fechap", SqlDbType.DateTime, ingreso})
                pars.Add(New Object() {"fechas", SqlDbType.DateTime, sale})
            End If

            Dim sql = "(select * from (select ap.id_puesto, ap.fecha, (select si.nombre_sitio_trabajo from sitios_trabajo si where si.id_sitio_trabajo = ap.id_puesto) puesto, ap.tipo,(select cast(cast(sum(valor)/2 as integer) as varchar) + ' - MULTA - NO CONTESTAR RADIO ' from descuentos_rol where id_personal = @idp and tipo = 10 and fecha between @fechap and @fechas) observacion, st.NOMBRE_SITIO_TRABAJO, cl.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO st on ap.ID_PUESTO = st.ID_SITIO_TRABAJO join CLIENTE_GENERAL cl on st.ID_CLIENTE_GENERAL = cl.ID_CLIENTE_GENERAL where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA) as data group by id_puesto, fecha, puesto, tipo, observacion,NOMBRE_SITIO_TRABAJO, NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL) " & _
                   If(libres, "union select * from (SELECT 0 id_puesto, IndividualDate fecha, 'SIN DATOS DEL PUESTO' puesto, 'LIBRE' tipo, 'SIN NOVEDADES' observacion,'' NOMBRE_SITIO_TRABAJO, '' NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL FROM DatesInRange('d', @fechap, @fechas) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) as data order by fecha", String.Empty)

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarReporteParaUtilidadesByFechas(ByVal tipoCon As TipoConexion, ByVal fechad As DateTime, ByVal fechah As DateTime, ByVal cliente As Integer, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, fechah})
            pars.Add(New Object() {"CLIENTE", SqlDbType.Int, cliente})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select tab.fecha FECHA, tab.cedula CEDULA,tab.nombres NOMBRES, tab.FECHA_ENTRADA, TAB.FECHA_SALIDA, (SELECT si.nombre_sitio_trabajo FROM sitios_trabajo si WHERE si.id_sitio_trabajo = tab.id_puesto) PUESTO, (select ap.tipo from ASIGNACION_PERSONAL ap where ap.id_asignacion=tab.id_asignacion) TIPO, TAB.REPORTE, TAB.OBSERVACION from (SELECT max(ap.id_asignacion) id_asignacion, ap.id_puesto, pe.id_personal, ap.fecha FECHA, pe.cedula CEDULA, pe.apellidos + ' ' +pe.nombres NOMBRES, convert(varchar, pe.fecha_entrada,  103) FECHA_ENTRADA, convert(varchar, pe.fecha_salida, 103) FECHA_SALIDA, max(ap.cantrep) REPORTE, max(ap.observacion) OBSERVACION FROM asignacion_personal ap JOIN personal pe ON ap.id_personal = pe.id_personal  join SITIOS_TRABAJO s on ap.id_puesto = s.ID_SITIO_TRABAJO where " & (If(cliente = 0, String.Empty, "s.id_cliente_general= @CLIENTE and")) & " ap.tipo <> 'PENDIENTE' AND ap.fecha BETWEEN @DESDE and @HASTA group by ap.id_puesto, pe.id_personal, ap.fecha, pe.cedula, pe.apellidos, pe.nombres, pe.fecha_entrada, pe.fecha_salida) as tab WHERE tab.nombres like ('%'+@FILTRO+'%') order by tab.fecha, tab.nombres;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarReportePara10Mo3ByAnio(ByVal tipoCon As TipoConexion, ByVal desde As DateTime,
                                                          ByVal hasta As DateTime) As DataTable
            'Dim desde = "'" & (anio - 1) & "-" & (mesDesde - 1) & "-" & 26 & " 00:00:00'"
            'Dim hasta = "'" & anio & "-" & mesHasta & "-" & diaHasta & " 23:59:59'"
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@desde", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@hasta", SqlDbType.DateTime, hasta})

            Dim sql = "select p.cedula, p.nombres, p.apellidos , substring(p.SEXO, 1,1) genero, co.CODIGO_OCUPACIONAL ocupacion, (sum(d.xiii)+sum(d.xiii_pension)) ganado, sum(d.diast) dias, 'P' pago, '' pjornada, '' hjornada , CASE WHEN p.discapacidad = 'SI' then 'X' else '' end discapacidad, '' rtenido, 'X' decimo from DETALLES_ROL d join PERSONAL p on d.ID_PERSONAL = p.id_personal join rol_pago r on d.id_rol = r.id_rol join CODIGO_CARGO_OCUPACIONAL co on p.ID_CARGO_OCUPACIONAL = co.ID_CARGO_OCUPACIONAL where (r.estado = 2 or r.estado =1) and d.id_personal > 0 and r.quincena = 1 and d.grupo <> '' and (r.desde >= @desde and r.hasta <= @hasta) group by p.id_personal,p.cedula, p.apellidos, p.nombres, p.SEXO, p.discapacidad, co.CODIGO_OCUPACIONAL order by p.apellidos, p.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarReportePara10Mo4ByAnio(ByVal tipoCon As TipoConexion, ByVal desde As DateTime,
                                                          ByVal hasta As DateTime) As DataTable
            'Dim desde = "'" & (anio - 1) & "-" & (mesDesde - 1) & "-" & 26 & " 00:00:00'"
            'Dim hasta = "'" & anio & "-" & mesHasta & "-" & diaHasta & " 23:59:59'"
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@desde", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@hasta", SqlDbType.DateTime, hasta})
            Dim sql = "select p.cedula, p.nombres, p.apellidos , substring(p.SEXO, 1,1) genero, co.CODIGO_OCUPACIONAL ocupacion, (sum(d.xiv)+sum(d.xiv_pension)) ganado, (sum(d.diast)+sum(d.diasdm)) dias, 'P' pago, '' pjornada, '' hjornada , CASE WHEN p.discapacidad = 'SI' then 'X' else '' end discapacidad, '' rtenido, 'X' decimo from DETALLES_ROL d join PERSONAL p on d.ID_PERSONAL = p.id_personal join rol_pago r on d.id_rol = r.id_rol join CODIGO_CARGO_OCUPACIONAL co on p.ID_CARGO_OCUPACIONAL = co.ID_CARGO_OCUPACIONAL where d.id_personal > 0 and (r.estado = 2 or r.estado = 1) and r.quincena = 1 and d.grupo <> '' and (r.desde >= @desde  and r.hasta <= @hasta) group by p.id_personal,p.cedula, p.apellidos, p.nombres, p.SEXO, p.discapacidad, co.CODIGO_OCUPACIONAL order by p.apellidos, p.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function


        Public Function SeleccionarReporteParaUtilidadesByAnio(ByVal tipoCon As TipoConexion, ByVal desde As DateTime, ByVal hasta As DateTime,
                                                               ByVal desdexiii As DateTime, ByVal hastaxiii As DateTime, ByVal desdexiv As DateTime,
                                                               ByVal hastaxiv As DateTime) As DataTable

            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@desde", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@hasta", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"@desdexiii", SqlDbType.DateTime, desdexiii})
            pars.Add(New Object() {"@hastaxiii", SqlDbType.DateTime, hastaxiii})
            pars.Add(New Object() {"@desdexiv", SqlDbType.DateTime, desdexiv})
            pars.Add(New Object() {"@hastaxiv", SqlDbType.DateTime, hastaxiv})


            Dim sql = "select p.cedula, p.nombres, p.apellidos, substring(p.SEXO, 1,1) genero, co.CODIGO_OCUPACIONAL ocupacion, 0 cargas, sum(d.diast) dias, 'P' pago, '' pjornada, '' hjornada, CASE WHEN p.discapacidad = 'SI' then 'X' else '' end discapacidad, '' ruc, (select sum(dx.xiii) + sum(dx.xiii_pension) from DETALLES_ROL dx join PERSONAL px on dx.ID_PERSONAL = px.id_personal join rol_pago rx on dx.id_rol = rx.id_rol join CODIGO_CARGO_OCUPACIONAL cox on px.ID_CARGO_OCUPACIONAL = cox.ID_CARGO_OCUPACIONAL where dx.id_personal = p.id_personal and rx.estado = 2 and rx.quincena = 1 and dx.grupo <> '' and (rx.desde >=  @desdexiii  and rx.hasta <= @hastaxiii ) group by px.id_personal) xiii, (select (sum(dx.xiv) + sum(dx.xiv_pension)) xiv from DETALLES_ROL dx join PERSONAL px on dx.ID_PERSONAL = px.id_personal join rol_pago rx on dx.id_rol = rx.id_rol join CODIGO_CARGO_OCUPACIONAL cox on px.ID_CARGO_OCUPACIONAL = cox.ID_CARGO_OCUPACIONAL where dx.id_personal = p.id_personal and rx.estado = 2 and rx.quincena = 1 and dx.grupo <> '' and (rx.desde >= @desdexiv  and rx.hasta <= @hastaxiv ) group by px.id_personal) xiv, 0 utilidad, sum(d.neto_rol) ganado, (sum(d.fon_res) + sum(d.fon_res_ant) + sum(d.val_acum_fon_res)) fonres from DETALLES_ROL d join PERSONAL p on d.ID_PERSONAL = p.id_personal join rol_pago r on d.id_rol = r.id_rol join CODIGO_CARGO_OCUPACIONAL co on p.ID_CARGO_OCUPACIONAL = co.ID_CARGO_OCUPACIONAL where (r.estado = 2 or r.estado = 1) and d.id_personal > 0 and r.quincena = 1 and d.grupo <> '' and (r.desde >= @desde  and r.hasta <= @hasta ) group by p.id_personal,p.cedula, p.apellidos, p.nombres, p.SEXO, p.discapacidad, co.CODIGO_OCUPACIONAL order by p.apellidos, p.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function


        Public Function SeleccionarReporteParaUtilidadesByMesesTodoAsistencia(ByVal tipoCon As TipoConexion, ByVal anio As Integer, ByVal mesIni As Integer, ByVal mesFin As Integer, ByVal idCliente As Integer, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            Dim desde As DateTime
            Dim hasta As DateTime

            Dim fechaDesdex As DateTime = "1-" & mesIni.ToString & "-" & anio.ToString & " 00:00:00"
            Dim fechaHastax As DateTime = "31-" & mesFin.ToString & "-" & anio.ToString & " 23:59:59"

            pars.Add(New Object() {"@ID_CLIENTE", SqlDbType.Int, idCliente})
            pars.Add(New Object() {"@DESDE", SqlDbType.DateTime, fechaDesdex})
            pars.Add(New Object() {"@HASTA", SqlDbType.DateTime, fechaHastax})
            pars.Add(New Object() {"@FILTRO", SqlDbType.VarChar, filtro})


            Dim sql = "select pe.id_personal, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, cl.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, convert(varchar, pe.fecha_entrada, 103) fecha_entrada, convert(varchar, pe.fecha_salida, 103) fecha_salida, "
            Dim fechaDesde As DateTime
            Dim fechaHasta As DateTime
            For i = mesIni To mesFin
                desde = New Date(anio, i, 1)
                hasta = New Date(anio, i, 1).AddMonths(1).AddDays(-1)

                fechaDesde = desde.Day.ToString & "-" & desde.Month.ToString & "-" & desde.Year.ToString & " 00:00:00"
                fechaHasta = hasta.Day.ToString & "-" & hasta.Month.ToString & "-" & hasta.Year.ToString & " 23:59:59"

                pars.Add(New Object() {"@DESDE" & i, SqlDbType.DateTime, fechaDesde})
                pars.Add(New Object() {"@HASTA" & i, SqlDbType.DateTime, fechaHasta})

                sql += "(select count(*) as " & ClassConversion.Mes(i).ToLower & " from (SELECT apx.fecha FROM asignacion_personal apx	JOIN personal pex ON apx.id_personal = pex.id_personal join SITIOS_TRABAJO xsi on apx.id_puesto=xsi.ID_SITIO_TRABAJO where pex.id_personal = pe.id_personal and xsi.ID_CLIENTE_GENERAL=cl.id_cliente_general and apx.tipo <> 'PENDIENTE' AND (apx.fecha BETWEEN @DESDE" & i & " and @HASTA" & i & ") group by apx.fecha) as tab) " & ClassConversion.Mes(i).ToUpper()

                If i <> mesFin Then sql += ","
            Next

            sql += ", '' TOTAL from ASIGNACION_PERSONAL ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO si on ap.id_puesto = si.id_sitio_trabajo join CLIENTE_GENERAL cl on si.ID_CLIENTE_GENERAL=cl.ID_CLIENTE_GENERAL where (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) and ap.tipo <> 'PENDIENTE' AND ap.fecha BETWEEN @DESDE and @HASTA group by pe.id_personal, pe.apellidos, pe.nombres, pe.cedula, cl.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, pe.fecha_entrada, pe.fecha_salida, cl.id_cliente_general order by  pe.apellidos, pe.nombres;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarReporteParaUtilidadesByMesesAsistencia(ByVal tipoCon As TipoConexion, ByVal anio As Integer, ByVal mesIni As Integer, ByVal mesFin As Integer, ByVal idCliente As Integer, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            Dim desde As DateTime
            Dim hasta As DateTime

            Dim fechaDesdex As DateTime = "1-" & mesIni.ToString & "-" & anio.ToString & " 00:00:00"
            Dim fechaHastax As DateTime = "31-" & mesFin.ToString & "-" & anio.ToString & " 23:59:59"

            pars.Add(New Object() {"@ID_CLIENTE", SqlDbType.Int, idCliente})
            pars.Add(New Object() {"@DESDE", SqlDbType.DateTime, fechaDesdex})
            pars.Add(New Object() {"@HASTA", SqlDbType.DateTime, fechaHastax})
            pars.Add(New Object() {"@FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select pe.id_personal, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, cl.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, convert(varchar, pe.fecha_entrada, 103) fecha_entrada, convert(varchar, pe.fecha_salida, 103) fecha_salida, "
            Dim fechaDesde As DateTime
            Dim fechaHasta As DateTime
            For i = mesIni To mesFin
                desde = New Date(anio, i, 1)
                hasta = New Date(anio, i, 1).AddMonths(1).AddDays(-1)

                fechaDesde = desde.Day.ToString & "-" & desde.Month.ToString & "-" & desde.Year.ToString & " 00:00:00"
                fechaHasta = hasta.Day.ToString & "-" & hasta.Month.ToString & "-" & hasta.Year.ToString & " 23:59:59"

                pars.Add(New Object() {"@DESDE" & i, SqlDbType.DateTime, fechaDesde})
                pars.Add(New Object() {"@HASTA" & i, SqlDbType.DateTime, fechaHasta})

                sql += "(select count(*) as " & ClassConversion.Mes(i).ToLower & " from (SELECT apx.fecha FROM asignacion_personal apx	JOIN personal pex ON apx.id_personal = pex.id_personal join SITIOS_TRABAJO sx on apx.id_puesto = sx.ID_SITIO_TRABAJO where pex.id_personal = pe.id_personal and sx.id_cliente_general= @ID_CLIENTE and apx.tipo <> 'PENDIENTE' AND (apx.fecha BETWEEN @DESDE" & i & " and @HASTA" & i & ") group by apx.fecha) as tab) " & ClassConversion.Mes(i).ToUpper()
                If i <> mesFin Then sql += ","
            Next

            sql += ", '' TOTAL from ASIGNACION_PERSONAL ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO si on ap.id_puesto = si.id_sitio_trabajo join CLIENTE_GENERAL cl on si.ID_CLIENTE_GENERAL=cl.ID_CLIENTE_GENERAL where (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) and si.id_cliente_general = @ID_CLIENTE and ap.tipo <> 'PENDIENTE' AND ap.fecha BETWEEN @DESDE and @HASTA group by pe.id_personal, pe.apellidos, pe.nombres, pe.cedula, cl.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, pe.fecha_entrada, pe.fecha_salida order by  pe.apellidos, pe.nombres;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarReporteParaUtilidadesByMesesAsistenciaPuesto(ByVal tipoCon As TipoConexion, ByVal anio As Integer, ByVal mesIni As Integer, ByVal mesFin As Integer, ByVal idCliente As Integer, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            Dim desde As DateTime
            Dim hasta As DateTime

            Dim fechaDesdex As DateTime = "1-" & mesIni.ToString & "-" & anio.ToString & " 00:00:00"
            Dim fechaHastax As DateTime = "31-" & mesFin.ToString & "-" & anio.ToString & " 23:59:59"

            pars.Add(New Object() {"@ID_CLIENTE", SqlDbType.Int, idCliente})
            pars.Add(New Object() {"@DESDE", SqlDbType.DateTime, fechaDesdex})
            pars.Add(New Object() {"@HASTA", SqlDbType.DateTime, fechaHastax})
            pars.Add(New Object() {"@FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select pe.id_personal, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, si.NOMBRE_SITIO_TRABAJO, convert(varchar, pe.fecha_entrada, 103) fecha_entrada, convert(varchar, pe.fecha_salida, 103) fecha_salida, "
            Dim fechaDesde As DateTime
            Dim fechaHasta As DateTime
            For i = mesIni To mesFin
                desde = New Date(anio, i, 1)
                hasta = New Date(anio, i, 1).AddMonths(1).AddDays(-1)

                fechaDesde = desde.Day.ToString & "-" & desde.Month.ToString & "-" & desde.Year.ToString & " 00:00:00"
                fechaHasta = hasta.Day.ToString & "-" & hasta.Month.ToString & "-" & hasta.Year.ToString & " 23:59:59"

                pars.Add(New Object() {"@DESDE" & i, SqlDbType.DateTime, fechaDesde})
                pars.Add(New Object() {"@HASTA" & i, SqlDbType.DateTime, fechaHasta})

                sql += "(select count(*) as " & ClassConversion.Mes(i).ToLower & " from (SELECT apx.fecha FROM asignacion_personal apx JOIN personal pex ON apx.id_personal = pex.id_personal join SITIOS_TRABAJO sx on apx.id_puesto = sx.ID_SITIO_TRABAJO where pex.id_personal = pe.id_personal and sx.ID_SITIO_TRABAJO= si.id_sitio_trabajo and apx.tipo <> 'PENDIENTE' AND (apx.fecha BETWEEN @DESDE" & i & " and @HASTA" & i & ") group by apx.fecha) as tab) " & ClassConversion.Mes(i).ToUpper()
                If i <> mesFin Then sql += ","
            Next

            sql += ", '' TOTAL from ASIGNACION_PERSONAL ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO si on ap.id_puesto = si.id_sitio_trabajo join CLIENTE_GENERAL cl on si.ID_CLIENTE_GENERAL=cl.ID_CLIENTE_GENERAL where (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) and si.id_cliente_general = @ID_CLIENTE and ap.tipo <> 'PENDIENTE' AND ap.fecha BETWEEN @DESDE and @HASTA group by pe.id_personal, pe.apellidos, pe.nombres, pe.cedula, si.NOMBRE_SITIO_TRABAJO, si.ID_SITIO_TRABAJO, pe.fecha_entrada, pe.fecha_salida order by  pe.apellidos, pe.nombres;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function BuscarMultasParaSancionxId(ByVal tipoCon As TipoConexion, ByVal idperson As Integer, ByVal fechad As DateTime, ByVal fechah As DateTime) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idperson", SqlDbType.Int, idperson})
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
            Dim sql = " SELECT TOP 1 ap.fld_contar_multas FROM ASIGNACION_PERSONAL ap WHERE ap.fecha BETWEEN @fechad AND @fechah AND ap.id_personal = @idperson and ap.fld_contar_multas > 0 ORDER BY ap.id_asignacion DESC;"
            Dim data As DataTable = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, Sql, False, pars)
            If data.Rows.Count > 0 AndAlso Not IsDBNull(data.Rows(0)(0)) Then
                Return CInt(data.Rows(0)(0))
            Else
                Return 0
            End If
        End Function
    End Class
End Namespace