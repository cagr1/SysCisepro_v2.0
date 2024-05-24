Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassRegistroSancionPersonal
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdRegistro As Int64
        Public IdPersonal As Int64
        Public IdSancion As Int64
        Public Fecha As Date
        Public Valor As Decimal
        Public Estado As Int64
        Public Observacion As String
        Public Idsitio As Int64 
        Public IdProg As Int64
        Public IdDescuento As Int64
        Public Multador As String

        Public Function BuscarMayorIdRegistroSancion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_registro=CASE WHEN MAX(id_registro) IS NULL THEN 0 ELSE MAX(id_registro) End FROM REGISTRO_SANCIONES_PERSONAL;", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_registro")))
        End Function

        Public Function SeleccionarRegistroSancionesGrupos(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select n.tipo_sancion + ' ' + n.detalle sancion from REGISTRO_SANCIONES_PERSONAL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional join area_general a on e.id_area = a.id_area_general join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo join sanciones_personal n on r.id_sancion = n.id_sancion where r.estado = 1 and r.fecha between @DESDE and @HASTA and (n.tipo_sancion like ('%'+@FILTRO+'%') or n.detalle like ('%'+@FILTRO+'%') or e.cedula like ('%'+@FILTRO+'%') or e.apellidos like ('%'+@FILTRO+'%') or e.nombres like ('%'+@FILTRO+'%')) group by (n.tipo_sancion + ' ' + n.detalle) order by (n.tipo_sancion + ' ' + n.detalle);"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarRegistroSancionesDatos(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})

            Dim sql = "select r.id_registro, n.tipo_sancion + ' ' + n.detalle sancion, n.id_sancion, r.fecha, r.id_personal, e.apellidos+' '+e.nombres personal, c.descripcion, a.nombre_area, r.id_sitio, s.nombre_sitio_trabajo, r.valor, r.observacion from REGISTRO_SANCIONES_PERSONAL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional join area_general a on e.id_area = a.id_area_general LEFT join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo join sanciones_personal n on r.id_sancion = n.id_sancion where r.estado = 1 and r.fecha between @DESDE and @HASTA and (n.tipo_sancion like ('%'+@FILTRO+'%') or n.detalle like ('%'+@FILTRO+'%') or e.cedula like ('%'+@FILTRO+'%') or e.apellidos like ('%'+@FILTRO+'%') or e.nombres like ('%'+@FILTRO+'%'));"
            'Dim sql = "select r.id_registro, n.tipo_sancion + ' ' + n.detalle sancion, n.id_sancion, r.fecha, r.id_personal, e.apellidos+' '+e.nombres personal, c.descripcion, a.nombre_area, r.id_sitio, s.nombre_sitio_trabajo, r.valor, r.observacion, r.id_descuento from REGISTRO_SANCIONES_PERSONAL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional join area_general a on e.id_area = a.id_area_general LEFT join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo join sanciones_personal n on r.id_sancion = n.id_sancion where r.estado = 1 and r.fecha between @DESDE and @HASTA and (n.tipo_sancion like ('%'+@FILTRO+'%') or n.detalle like ('%'+@FILTRO+'%') or e.cedula like ('%'+@FILTRO+'%') or e.apellidos like ('%'+@FILTRO+'%') or e.nombres like ('%'+@FILTRO+'%'));"
            'Dim sql = "SELECT r.id_registro, n.tipo_sancion + ' ' + n.detalle AS sancion, n.id_sancion, r.fecha, r.id_personal, e.apellidos + ' ' + e.nombres AS personal, c.descripcion, a.nombre_area, r.id_sitio, s.nombre_sitio_trabajo, CASE WHEN ap.fld_contar_multas > 1 AND n.id_sancion = 28 AND ap.estado = 1  THEN r.valor * n.valor_descuento ELSE r.valor END AS valor, r.observacion, r.observacion, r.id_descuento FROM REGISTRO_SANCIONES_PERSONAL r JOIN personal e ON r.id_personal = e.id_personal JOIN cargo_ocupacional c ON e.id_cargo_ocupacional = c.id_cargo_ocupacional JOIN area_general a ON e.id_area = a.id_area_general LEFT JOIN sitios_trabajo s ON r.id_sitio = s.id_sitio_trabajo JOIN sanciones_personal n ON r.id_sancion = n.id_sancion  LEFT JOIN asignacion_personal ap ON ap.id_personal = r.id_personal WHERE(r.estado = 1) AND r.fecha BETWEEN @DESDE AND @HASTA  AND (n.tipo_sancion LIKE ('%'+@FILTRO+'%') OR n.detalle LIKE ('%'+@FILTRO+'%') OR e.cedula LIKE ('%'+@FILTRO+'%') OR e.apellidos LIKE ('%'+@FILTRO+'%') OR e.nombres LIKE ('%'+@FILTRO+'%'));"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function


        Public Function SeleccionarRegistroSancionesDatos2(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarRegistroSancionesDatos", True, pars)
        End Function

        Public Function NuevoRegistroSancionDescuentoCommands() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into REGISTRO_SANCIONES_PERSONAL (id_registro, id_personal, id_sancion, fecha, valor, estado, observacion, id_sitio, id_prog, id_descuento, multador) values (@id_registro, @id_personal, @id_sancion, @fecha, @valor, @estado, @observacion, @idsitio, @id_prog, @idesc, @multador);"
                .Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = idRegistro
                .Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = idPersonal
                .Parameters.AddWithValue("@id_sancion", SqlDbType.Int).Value = idSancion
                .Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = fecha
                .Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = valor
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = estado
                .Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = observacion
                .Parameters.AddWithValue("@idsitio", SqlDbType.Int).Value = idsitio
                .Parameters.AddWithValue("@id_prog", SqlDbType.Int).Value = IdProg
                .Parameters.AddWithValue("@idesc", SqlDbType.Int).Value = IdDescuento
                .Parameters.AddWithValue("@multador", SqlDbType.VarChar).Value = Multador
            End With
            Return comando
        End Function

        Public Function AnularRegistroSancionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update REGISTRO_SANCIONES_PERSONAL set estado=@estado where id_registro=@id_registro;"
                .Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = idRegistro
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = estado
            End With
            Return comando
        End Function

        
        'Public Function DeleteRegistroNuevoSancionPersonalCommand(ByVal idp As Integer, ByVal fecd As Date, ByVal fech As Date) As SqlCommand
        Public Function DeleteRegistroNuevoSancionPersonalCommand(ByVal idp As Integer, ByVal fecd As DateTime, ByVal fech As DateTime) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "delete from REGISTRO_SANCIONES_PERSONAL where fecha between @fecd and @fech and id_sancion IN (1,2,3,13,14,28)  and id_prog = @idp"

                .Parameters.AddWithValue("@idp", SqlDbType.Int).Value = idp
                .Parameters.AddWithValue("@fecd", SqlDbType.DateTime).Value = fecd
                .Parameters.AddWithValue("@fech", SqlDbType.DateTime).Value = fech
            End With
            Return comando
        End Function

        Public Function ActualizarValorSancion(ByVal tipoCon As TipoConexion, ByVal idpersonal As Integer, ByVal fecd As DateTime, ByVal fech As DateTime, ByVal idpro As Integer) As Decimal


            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idpersonal", SqlDbType.Int, idpersonal})
            pars.Add(New Object() {"fecd", SqlDbType.DateTime, fecd})
            pars.Add(New Object() {"fech", SqlDbType.DateTime, fech})
            pars.Add(New Object() {"idpro", SqlDbType.Int, idpro})
            Dim sql = "Select  ap.fld_contar_multas From ASIGNACION_PERSONAL ap WHERE ap.fecha between @fecd AND @fech AND ap.fld_contar_multas > 0 and ap.id_personal = @idpersonal and ap.id_programacion = @idpro and ap.estado = 1 order by ap.id_asignacion DESC "
            Dim data As DataTable = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            If data.Rows.Count > 0 AndAlso Not IsDBNull(data.Rows(0)(0)) Then
                Return CDec(data.Rows(0)(0))
            Else
                Return 0
            End If

        End Function


        Public Function ValorSancion(ByVal tipoCon As TipoConexion) As Decimal


            Dim pars = New List(Of Object())
            Dim sql = "Select sp.valor_descuento From SANCIONES_PERSONAL sp where sp.id_sancion = 28 and sp.estado = 1"
            Dim data As DataTable = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            If data.Rows.Count > 0 AndAlso Not IsDBNull(data.Rows(0)(0)) Then
                Return CDec(data.Rows(0)(0))
            Else
                Return 0
            End If

        End Function

        
        Public Function BuscarValorInastenciaParaSancionxId(ByVal tipoCon As TipoConexion, ByVal idperson As Integer, ByVal fechad As DateTime, ByVal fechah As DateTime) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idperson", SqlDbType.Int, idperson})
            pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
            pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
            'Dim sql = "Select top 1 ap.fld_contar_multas  FROM  ASIGNACION_PERSONAL ap  WHERE  ap.fecha between @fechad AND  @fechah AND  ap.fld_contar_multas > 0 and ap.id_personal = @idperson"
            Dim sql = " SELECT TOP 1 valor FROM REGISTRO_SANCIONES_PERSONAL where fecha between @fechad and @fechah and id_sancion = 3  and id_personal = @idperson"
            Dim data As DataTable = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            If data.Rows.Count > 0 AndAlso Not IsDBNull(data.Rows(0)(0)) Then
                Return CInt(data.Rows(0)(0))
            Else
                Return 0
            End If
        End Function

        'Public Function SeleccionarProgramacionByIdProgFecha(ByVal tipoCon As TipoConexion, ByVal idp As Integer, ByVal fechad As DateTime, ByVal fechah As DateTime) As Boolean
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"id_programacion", SqlDbType.Int, idp})
        '    pars.Add(New Object() {"fechad", SqlDbType.DateTime, fechad})
        '    pars.Add(New Object() {"fechah", SqlDbType.DateTime, fechah})
        '    Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select count(*) cant from asignacion_personal where id_programacion=@id_programacion and fecha between @fechad and @fechah;", False, pars)
        '    Return data.Rows.Count > 0 And CInt(data.Rows(0)("cant")) > 0
        'End Function

    End Class
End Namespace
