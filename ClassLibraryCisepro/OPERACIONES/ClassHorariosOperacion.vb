Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace OPERACIONES
    Public Class ClassHorariosOperacion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdHorario As Integer
        Public Detalle As String
        Public Dias As String
        Public Lunes As String
        Public Martes As String
        Public Miercoles As String
        Public Jueves As String
        Public Viernes As String
        Public Sabado As String
        Public Domingo As String
        Public HoraRegular As Double
        Public RecNocturno As Double
        Public Horas50 As Double
        Public Horas100 As Double
        Public Observacion As String
        Public Categoria As String
        Public Estado As Integer
        Public Tipo As Integer
        Public Totalhoras As Double
        Public Ludi As Integer
        Public Madi As Integer
        Public Midi As Integer
        Public Judi As Integer
        Public Vidi As Integer
        Public Sadi As Integer
        Public Dodi As Integer

        Public Function BuscarMayorIdHorarios(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_horario=CASE WHEN MAX(id_horario) IS NULL THEN 0 ELSE MAX(id_horario) End FROM HORARIOS_OPERACION", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_horario")))
        End Function

        Public Function ExisteHorarioOperacion(ByVal tipoCon As TipoConexion, ByVal id As String, ByVal dias As String, ByVal lunes As String, ByVal martes As String, ByVal miercoles As String, ByVal jueves As String, ByVal viernes As String, ByVal sabado As String, ByVal domingo As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"id", SqlDbType.Int, id})
            pars.Add(New Object() {"dias", SqlDbType.NVarChar, dias})
            pars.Add(New Object() {"lunes", SqlDbType.NVarChar, lunes})
            pars.Add(New Object() {"martes", SqlDbType.NVarChar, martes})
            pars.Add(New Object() {"miercoles", SqlDbType.NVarChar, miercoles})
            pars.Add(New Object() {"jueves", SqlDbType.NVarChar, jueves})
            pars.Add(New Object() {"viernes", SqlDbType.NVarChar, viernes})
            pars.Add(New Object() {"sabado", SqlDbType.NVarChar, sabado})
            pars.Add(New Object() {"domingo", SqlDbType.NVarChar, domingo})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) cantidad from HORARIOS_OPERACION where estado=1 and dias=@dias and lunes=@lunes and martes=@martes and miercoles=@miercoles and jueves=@jueves and viernes=@viernes and sabado=@sabado and domingo=@domingo and id_horario<>@id;", False, pars)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("cantidad")))
        End Function
         
        Public Function EditarEstadoHorarioOperacion(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update HORARIOS_OPERACION set estado=@estado where id_horario=@id_horario;"
                .Parameters.AddWithValue("@id_horario", SqlDbType.Int).Value = idHorario
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = estado
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarHorariosOperacion(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "select id_horario ID, DETALLE, DIAS, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, CAST(hora_regular as int) hora_regular, " & _
                    "CAST(recargo_nocturno as int) recargo_nocturno, CAST(hora_cincuenta as int) hora_cincuenta, CAST(hora_cien as int) hora_cien, total_horas TOT_HORAS, OBSERVACION, ESTADO, CATEGORIA, tipo TIPO from HORARIOS_OPERACION where DETALLE like ('%'+@FILTRO+'%') or " & _
                    "DIAS like ('%'+@FILTRO+'%') or LUNES like ('%'+@FILTRO+'%') or MARTES like ('%'+@FILTRO+'%') or " & _
                    "MIERCOLES like ('%'+@FILTRO+'%') or JUEVES like ('%'+@FILTRO+'%') or VIERNES like ('%'+@FILTRO+'%') or " & _
                    "SABADO like ('%'+@FILTRO+'%') or DOMINGO like ('%'+@FILTRO+'%')"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarHorariosOperacionDia(ByVal tipoCon As TipoConexion, ByVal dia As String, ByVal esDiurno As Boolean) As DataTable
            Dim sql = "select tab.ndia from (select " & dia.Trim & " ndia from horarios_operacion where dias like '%" & dia.Substring(0, 2).Trim & "%' AND " & dia.Substring(0, 2).Trim & "_DI = " & If(esDiurno, 1, 0) & ") as tab group by ndia order by ndia;"
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, False) 
        End Function

        Public Function SeleccionarHorariosMasUsadoDia(ByVal tipoCon As TipoConexion, ByVal hora As String, ByVal dia As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"hora", SqlDbType.VarChar, hora})
            Dim sql = "select top 1 op.* from (select ho.id_horario id, count(ho.id_horario) cant from asignacion_personal ap left join horarios_operacion ho on ap.id_horario=ho.id_horario where ho." & dia & " = @hora group by ho.id_horario) as tab right join horarios_operacion op on tab.id=op.id_horario order by tab.cant desc"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarCategoriasHorariosOperacion(ByVal tipoCon As TipoConexion) As DataTable
            Dim sql = "select categoria from HORARIOS_OPERACION where estado = 1 group by categoria order by categoria"
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, False) 
        End Function

        Public Function HoraEstaEnRangoHorarioDiurno(ByVal tipoCon As TipoConexion, ByVal hora As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"h", SqlDbType.NVarChar, hora})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select case when @h between '06:00:00' and '18:30:00' then 1 else 0 end as hora;", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)("hora")) = 1
        End Function

        Public Function HoraEstaEnRangoHorarioNocturno(ByVal tipoCon As TipoConexion, ByVal hora As String) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"h", SqlDbType.NVarChar, hora})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select case when @h between '06:00:00' and '18:30:00' then 0 else 1 end as hora;", False, pars)
            Return data.Rows.Count > 0 And CInt(data.Rows(0)("hora")) = 1
        End Function
         
        Public Function RegistrarNuevoHorarioOperacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into HORARIOS_OPERACION values (@id_horario,@detalle,@lunes,@martes,@miercoles,@jueves,@viernes,@sabado,@domingo,@hora_regular,@recargo_nocturno,@hora_cincuenta,@hora_cien,@observacion,@dias,@estado,@categoria,@tipo,@thoras, @ludi, @madi, @midi, @judi, @vidi, @sadi, @dodi);"
                .Parameters.AddWithValue("@id_horario", SqlDbType.Int).Value = IdHorario
                .Parameters.AddWithValue("@detalle", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@lunes", SqlDbType.NVarChar).Value = Lunes
                .Parameters.AddWithValue("@martes", SqlDbType.NVarChar).Value = Martes
                .Parameters.AddWithValue("@miercoles", SqlDbType.NVarChar).Value = Miercoles
                .Parameters.AddWithValue("@jueves", SqlDbType.NVarChar).Value = Jueves
                .Parameters.AddWithValue("@viernes", SqlDbType.NVarChar).Value = Viernes
                .Parameters.AddWithValue("@sabado", SqlDbType.NVarChar).Value = Sabado
                .Parameters.AddWithValue("@domingo", SqlDbType.NVarChar).Value = Domingo
                .Parameters.AddWithValue("@hora_regular", SqlDbType.Decimal).Value = HoraRegular
                .Parameters.AddWithValue("@recargo_nocturno", SqlDbType.Decimal).Value = RecNocturno
                .Parameters.AddWithValue("@hora_cincuenta", SqlDbType.Decimal).Value = Horas50
                .Parameters.AddWithValue("@hora_cien", SqlDbType.Decimal).Value = Horas100
                .Parameters.AddWithValue("@observacion", SqlDbType.NVarChar).Value = Observacion
                .Parameters.AddWithValue("@dias", SqlDbType.NVarChar).Value = Dias
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@categoria", SqlDbType.Int).Value = Categoria
                .Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo
                .Parameters.AddWithValue("@thoras", SqlDbType.Decimal).Value = Totalhoras
                .Parameters.AddWithValue("@ludi", SqlDbType.Int).Value = Ludi
                .Parameters.AddWithValue("@madi", SqlDbType.Int).Value = Madi
                .Parameters.AddWithValue("@midi", SqlDbType.Int).Value = Midi
                .Parameters.AddWithValue("@judi", SqlDbType.Int).Value = Judi
                .Parameters.AddWithValue("@vidi", SqlDbType.Int).Value = Vidi
                .Parameters.AddWithValue("@sadi", SqlDbType.Int).Value = Sadi
                .Parameters.AddWithValue("@dodi", SqlDbType.Int).Value = Dodi
            End With
            Return comando
        End Function

        Public Function ModificarHorarioOperacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update HORARIOS_OPERACION set detalle=@detalle, lunes=@lunes, martes=@martes, miercoles=@miercoles, jueves=@jueves, " & _
                    "viernes=@viernes, sabado=@sabado, domingo=@domingo, hora_regular=@hora_regular, recargo_nocturno=@recargo_nocturno, hora_cincuenta=@hora_cincuenta, " & _
                    "hora_cien=@hora_cien, observacion=@observacion, dias=@dias, categoria=@categoria, tipo=@tipo, total_horas=@thoras, lu_di=@ludi, ma_di=@madi, mi_di=@midi, ju_di=@judi, vi_di=@vidi, sa_di=@sadi, do_di=@dodi where id_horario=@id_horario;"
                .Parameters.AddWithValue("@id_horario", SqlDbType.Int).Value = IdHorario
                .Parameters.AddWithValue("@detalle", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@lunes", SqlDbType.NVarChar).Value = Lunes
                .Parameters.AddWithValue("@martes", SqlDbType.NVarChar).Value = Martes
                .Parameters.AddWithValue("@miercoles", SqlDbType.NVarChar).Value = Miercoles
                .Parameters.AddWithValue("@jueves", SqlDbType.NVarChar).Value = Jueves
                .Parameters.AddWithValue("@viernes", SqlDbType.NVarChar).Value = Viernes
                .Parameters.AddWithValue("@sabado", SqlDbType.NVarChar).Value = Sabado
                .Parameters.AddWithValue("@domingo", SqlDbType.NVarChar).Value = Domingo
                .Parameters.AddWithValue("@hora_regular", SqlDbType.Decimal).Value = HoraRegular
                .Parameters.AddWithValue("@recargo_nocturno", SqlDbType.Decimal).Value = RecNocturno
                .Parameters.AddWithValue("@hora_cincuenta", SqlDbType.Decimal).Value = Horas50
                .Parameters.AddWithValue("@hora_cien", SqlDbType.Decimal).Value = Horas100
                .Parameters.AddWithValue("@observacion", SqlDbType.NVarChar).Value = Observacion
                .Parameters.AddWithValue("@dias", SqlDbType.NVarChar).Value = Dias
                .Parameters.AddWithValue("@categoria", SqlDbType.Int).Value = Categoria
                .Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo
                .Parameters.AddWithValue("@thoras", SqlDbType.Decimal).Value = Totalhoras
                .Parameters.AddWithValue("@ludi", SqlDbType.Int).Value = Ludi
                .Parameters.AddWithValue("@madi", SqlDbType.Int).Value = Madi
                .Parameters.AddWithValue("@midi", SqlDbType.Int).Value = Midi
                .Parameters.AddWithValue("@judi", SqlDbType.Int).Value = Judi
                .Parameters.AddWithValue("@vidi", SqlDbType.Int).Value = Vidi
                .Parameters.AddWithValue("@sadi", SqlDbType.Int).Value = Sadi
                .Parameters.AddWithValue("@dodi", SqlDbType.Int).Value = Dodi
            End With
            Return comando
        End Function

        Public Function ModificarEstadoHorarioOperacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update HORARIOS_OPERACION set estado=@estado where id_horario=@id_horario;"
                .Parameters.AddWithValue("@id_horario", SqlDbType.Int).Value = IdHorario
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

    End Class
End Namespace