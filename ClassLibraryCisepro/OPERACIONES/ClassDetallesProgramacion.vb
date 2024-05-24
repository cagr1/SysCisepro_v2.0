Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace OPERACIONES
    Public Class ClassDetallesProgramacion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Idprogrmacion As Integer
        Public Idpersonal As Integer
        Public Idsitiopuesto As Integer
        Public Idhorario As Integer
        Public Estado As Integer
        Public Fechadesde As Date
        Public Fechahasta As Date
        Public Detalle As String
        Public Tipo As Integer

        Public Function RegistrarNuevoDetalleProgramacionMesOperacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DETALLE_PROGRAMACION  " & _
                    "values (@id_programacion,@idpersonal,@idpuesto,@idhorario, @estado, @desde, @hasta, @detalle, @tipo);"
                .Parameters.AddWithValue("@id_programacion", SqlDbType.Int).Value = Idprogrmacion
                .Parameters.AddWithValue("@idpersonal", SqlDbType.Int).Value = Idpersonal
                .Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = Idsitiopuesto
                .Parameters.AddWithValue("@idhorario", SqlDbType.Int).Value = Idhorario
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@desde", SqlDbType.Timestamp).Value = Fechadesde
                .Parameters.AddWithValue("@hasta", SqlDbType.Timestamp).Value = Fechahasta
                .Parameters.AddWithValue("@detalle", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo
            End With
            Return comando
        End Function

        Public Function SeleccionarGruposDetallesProgramacionById(ByVal tipoCon As TipoConexion, ByVal id As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})

            Dim sql = "select sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) + ')'  SITIO, sit.rive " & _
                   "from DETALLE_PROGRAMACION dep join PROGRAMACION_OPERATIVOS pro on pro.id_programacion=dep.id_programacion " & _
                   "join personal per on dep.id_personal = per.id_personal " & _
                   "join sitios_trabajo sit on dep.id_puesto=sit.id_sitio_trabajo " & _
                   "join cliente_general cli on sit.id_cliente_general=cli.id_cliente_general " & _
                   "join horarios_operacion hor on dep.id_horario=hor.id_horario where dep.id_programacion = @id " & _
                   "group by sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) + ')', sit.rive order by sit.rive"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarGruposDetallesProgramacionById2(ByVal tipoCon As TipoConexion, ByVal id As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})

            Dim sql = "select sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) + ')'  SITIO, sit.rive " & _
                   "from DETALLE_PROGRAMACION dep join PROGRAMACION_OPERATIVOS pro on pro.id_programacion=dep.id_programacion " & _
                   "join personal per on dep.id_personal = per.id_personal " & _
                   "join sitios_trabajo sit on dep.id_puesto=sit.id_sitio_trabajo " & _
                   "join cliente_general cli on sit.id_cliente_general=cli.id_cliente_general " & _
                   "join horarios_operacion hor on dep.id_horario=hor.id_horario where dep.id_programacion = @id and sit.estado > 0 " & _
                   "group by sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) + ')', sit.rive order by sit.rive"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarDetalleProgramacionByIdFecha2(ByVal tipoCon As TipoConexion, ByVal id As String, ByVal fechad As DateTime, ByVal fechah As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})
            pars.Add(New Object() {"desde", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"hasta", SqlDbType.DateTime, fechah})

            Dim sql = "select per.id_personal IDP, per.apellidos + ' ' + per.nombres PERSONAL, sit.id_sitio_trabajo IDS, " & _
                    "sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) +')' SITIO, " & _
                    "hor.id_horario IDH, hor.detalle HOR, hor.dias DIAS,  hor.lunes LUNES, hor.martes MARTES, " & _
                    "hor.miercoles MIERCOLES, hor.jueves JUEVES, hor.viernes VIERNES, hor.sabado SABADO, hor.domingo DOMINGO, dep.DETALLE, @desde INICIA, @hasta TERMINA, dep.tipo TIPO, per.estado_personal " & _
                    "from DETALLE_PROGRAMACION dep join PROGRAMACION_OPERATIVOS pro on pro.id_programacion=dep.id_programacion " & _
                    "join personal per on dep.id_personal = per.id_personal " & _
                    "join sitios_trabajo sit on dep.id_puesto=sit.id_sitio_trabajo " & _
                    "join cliente_general cli on sit.id_cliente_general=cli.id_cliente_general " & _
                    "join horarios_operacion hor on dep.id_horario=hor.id_horario where dep.id_programacion = @id and per.id_personal > 0 and sit.estado > 0 order by dep.fecha_desde,dep.fecha_hasta, per.apellidos, per.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarDetalleProgramacionById(ByVal tipoCon As TipoConexion, ByVal id As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})

            Dim sql = "select per.id_personal IDP, per.apellidos + ' ' + per.nombres PERSONAL, sit.id_sitio_trabajo IDS, " & _
                    "sit.river + '     -  ' + RTRIM(LTRIM(sit.nombre_sitio_trabajo)) + ' ('+RTRIM(LTRIM(cli.nompre_razon_social_cliente_general)) +')' SITIO, " & _
                    "hor.id_horario IDH, hor.detalle HOR, hor.dias DIAS,  hor.lunes LUNES, hor.martes MARTES, " & _
                    "hor.miercoles MIERCOLES, hor.jueves JUEVES, hor.viernes VIERNES, hor.sabado SABADO, hor.domingo DOMINGO, dep.DETALLE, dep.fecha_desde INICIA, dep.fecha_hasta TERMINA, dep.tipo TIPO, per.estado_personal " & _
                    "from DETALLE_PROGRAMACION dep join PROGRAMACION_OPERATIVOS pro on pro.id_programacion=dep.id_programacion " & _
                    "join personal per on dep.id_personal = per.id_personal " & _
                    "join sitios_trabajo sit on dep.id_puesto=sit.id_sitio_trabajo " & _
                    "join cliente_general cli on sit.id_cliente_general=cli.id_cliente_general " & _
                    "join horarios_operacion hor on dep.id_horario=hor.id_horario where dep.id_programacion = @id order by dep.fecha_desde,dep.fecha_hasta, per.apellidos, per.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function


        Public Function SeleccionarDetalleAsistenciaByIdProgramacion(ByVal tipoCon As TipoConexion, ByVal rep As Boolean, ByVal id As String, ByVal dia As String, ByVal ndia As String, ByVal fechad As DateTime, ByVal fechah As DateTime, ByVal jdia As String, ByVal todos As Integer) As DataTable
            Dim tb = If(rep, "asignacion_personal", "detalle_programacion")
            Dim oc = If(rep, ", dp.tipo, dp.entrada, dp.c50, dp.c51, dp.c40, dp.c41, dp.salida, dp.cantrep, dp.observacion, dp.report, dp.id_user, dp.horario", ", case when dp.tipo = 1 or dp.tipo= 3 then 'PERMISO MÉDICO' when dp.tipo= 2 THEN 'CALAMIDAD DOMÉSTICA' when dp.tipo= 4 THEN 'VACACIONES' else 'PENDIENTE' end tipo, '-' entrada,'-', '-', '-', '-', '-' salida, 0 cantrep, '' observacion, '' report, 0 id_user, '' horario")
            Dim ag = If(rep, "and dp.fecha between @fechad and @fechah", "and @fechad between dp.fecha_desde and dp.fecha_hasta")

            Dim td = If(todos = 0, String.Empty, " and ho." & jdia & " = " & If(todos = 2, 0, 1))

            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, id})
            pars.Add(New Object() {"dia", SqlDbType.Int, dia})
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            If rep Then
                pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
            End If

            Dim sql = "select dbo.NumeroRiver(si.river) nriver, si.river, dp.id_programacion, pe.id_personal, pe.apellidos + ' ' + pe.nombres vigilante, " & _
                    "dp.id_puesto, si.nombre_sitio_trabajo, si.direccion_sitio_trabajo, ho.id_horario, ho." & ndia & oc & _
                    " from " & tb & " dp join programacion_operativos po on dp.id_programacion=po.id_programacion " & _
                    "join horarios_operacion ho on dp.id_horario=ho.id_horario join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo " & _
                    "join personal pe on dp.id_personal = pe.id_personal " & _
                    "where dp.id_programacion = @idp and " & If(rep, "", "pe.estado_personal = 1 and") & " si.estado > 0 and po.estado=1 " & td & " and ho.dias like '%' + @dia + '%' " & ag & _
                    " order by " & (If(todos, "ho." & jdia & " desc,", String.Empty)) & " dbo.NumeroRiver(si.river), si.river;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarDetalleAsistenciaLibresByIdProgramacion(ByVal tipoCon As TipoConexion, ByVal id As String, ByVal dia As String, ByVal fechad As DateTime, ByVal fechah As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, id})
            pars.Add(New Object() {"dia", SqlDbType.Int, dia})
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            Dim sql = "select si.river, pe.id_personal, pe.apellidos + ' ' + pe.nombres vigilante, si.nombre_sitio_trabajo, si.direccion_sitio_trabajo, ho.dias " & _
                "from detalle_programacion dp join programacion_operativos po on dp.id_programacion=po.id_programacion  " & _
                "join horarios_operacion ho on dp.id_horario=ho.id_horario join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join personal pe on dp.id_personal = pe.id_personal  " & _
                "where dp.id_programacion = @idp and pe.estado_personal = 1 and si.estado > 0 and po.estado=1  and ho.dias not like '%' + @dia + '%' and @fechad between dp.fecha_desde and dp.fecha_hasta order by dbo.NumeroRiver(si.river), si.river;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarDetallePermisosHoyForProgramacion(ByVal tipoCon As TipoConexion, ByVal fechad As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})

            Dim sql = "select * from registro_permisos_personal where @fechad between desde and hasta and estado = 1;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarReporteAperturaCierreBm(ByVal tipoCon As TipoConexion, ByVal idp As Integer, ByVal fechad As DateTime, ByVal fechah As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
            pars.Add(New Object() {"idp", SqlDbType.DateTime, idp})
            Dim sql = "select si.nombre_sitio_trabajo AGENCIA, max(ap.c50) APERTURA, max(ap.c40) CIERRE, '' OBSERVACION from asignacion_personal ap join sitios_trabajo si on ap.id_puesto=si.id_sitio_trabajo join cliente_general cg on si.id_cliente_general = cg.id_cliente_general where cg.id_cliente_general = 35 and ap.id_programacion=@idp and ap.fecha between @fechad and @fechah group by si.nombre_sitio_trabajo order by si.nombre_sitio_trabajo;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function


        Public Function DeleteDetallesProgramacionOperacionByIdCommand(ByVal idp As String) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "delete from detalle_programacion where id_programacion=@id_programacion;"
                .Parameters.AddWithValue("@id_programacion", SqlDbType.Int).Value = idp
            End With
            Return comando
        End Function

    End Class
End Namespace