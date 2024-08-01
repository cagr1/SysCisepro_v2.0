Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace DIVISION_GEOGRÁFICA
    Public Class ClassSitiosTrabajo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public IdProvincia As Integer
        Public IdCiudad As Integer
        Public IdParroquia As Integer
        Public Direccion As String
        Public Referencia As String
        Public Nombre As String
        Public Tipo As String
        Public Cliente As Integer
        Public Supervisor As Integer
        Public Estado As Integer
        Public Latitud As String
        Public Longitud As String
        Public River As String
        Public Grupo As String
        Public Riv As Integer
        Public HorasPuesto As Integer
        Public CantHorasNor As Decimal
        Public CantHoras50 As Decimal
        Public CantHoras100 As Decimal
        Public CantHorasExt As Decimal
        Public CantRecNoct As Decimal
        Public CantAdicional As Decimal
        Public DecimosConExtra As Boolean
        
        'Public Function SeleccionarArmasByIdSitio(ByVal tipoCon As TipoConexion, ByVal idSitio As String, ByVal filtro As String, ByVal fechad As DateTime, ByVal fechah As DateTime) As DataTable
        'Public Function SeleccionarArmasByIdSitio(ByVal tipoCon As TipoConexion, ByVal idSitio As String, ByVal fechad As DateTime, ByVal fechah As DateTime) As DataTable
        Public Function SeleccionarArmasByIdSitio(ByVal tipoCon As TipoConexion, ByVal idSitio As String, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SITIO", SqlDbType.Int, idSitio})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            'pars.Add(New Object() {"FECHAD", SqlDbType.DateTime, fechad})
            'pars.Add(New Object() {"FECHAH", SqlDbType.DateTime, fechah})
            ' E SALE DEL PUESTO - INGRESA A BODEGA
            ' I ENRA AL PUESTO - SALE DE BODEGA

            Dim sql = "select * from ( " & _
"(select ci.id_comprobante, convert(varchar, di.fecha, 103) fecha,'E' tipo, si.nombre_secuencial_item, di.serie, ci.razon " & _
"from detalle_items_puesto di " & _
"join detalle_comprobante_ingreso_bodega db on di.id_detalle_comprobante=db.id_detalle_comprobante " & _
"join comprobante_ingreso_bodega ci on db.id_comprobante=ci.id_comprobante " & _
"join kardex kd on db.id_kardex = kd.id_kardex " & _
"join secuencial_item si on kd.id_secuencial_item=si.id_secuencial_item " & _
"join sitios_trabajo st on di.id_sitio = st.id_sitio_trabajo " & _
"where di.id_sitio = @ID_SITIO and di.tipo = 'INGRESO') " & _
"union " & _
"(select ci.id_comprobante, convert(varchar, di.fecha, 103) fecha,'I' tipo, si.nombre_secuencial_item, di.serie, ci.razon " & _
"from detalle_items_puesto di " & _
"join detalle_comprobante_egreso_bodega db on di.id_detalle_comprobante=db.id_detalle_comprobante " & _
"join comprobante_egreso_bodega ci on db.id_comprobante=ci.id_comprobante " & _
"join kardex kd on db.id_kardex = kd.id_kardex " & _
"join secuencial_item si on kd.id_secuencial_item=si.id_secuencial_item " & _
"join sitios_trabajo st on di.id_sitio = st.id_sitio_trabajo " & _
"where di.id_sitio = @ID_SITIO and di.tipo = 'EGRESO') " & _
") as tab where tab.serie like ('%' + @FILTRO +'%') order by tab.fecha"
            'Dim Sql = "SELECT * " & _
            '"FROM " & _
            '"( SELECT CU.ID_COMPROBANTE AS COMPROBANTE, CU.FECHA,CU.CANTIDAD_ARTICULOS AS CANTIDAD," & _
            '"CASE WHEN CU.ID_ACTIVIDAD = 1 THEN 'I' " & _
            '"WHEN CU.ID_ACTIVIDAD = 2 THEN 'E' " & _
            '"ELSE '' " & _
            '"END AS TIPO, " & _
            '"SI.NOMBRE_SECUENCIAL_ITEM, K.ID_KARDEX, DCIB.OBSERVACION, CIB.RAZON " & _
            '"FROM CONTROL_UNIFORMES CU join COMPROBANTE_INGRESO_BODEGA CIB on CU.ID_COMPROBANTE = CIB.ID_COMPROBANTE " & _
            '"JOIN DETALLE_KARDEX DK ON CU.ID_DETALLE_KARDEX = DK.ID_DETALLE JOIN KARDEX K ON K.ID_KARDEX = DK.ID_KARDEX " & _
            '"JOIN SECUENCIAL_ITEM SI ON K.ID_SECUENCIAL_ITEM = SI.ID_SECUENCIAL_ITEM JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB " & _
            '"ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE " & _
            '"WHERE CIB.ID_SITIO_TRABAJO = @ID_SITIO AND CU.FECHA BETWEEN @FECHAD AND @FECHAH " & _
            '"AND CIB.ESTADO = 1 AND DK.ESTADO = 1 " & _
            '"UNION " & _
            '"SELECT CU.ID_COMPROBANTE , CU.FECHA,CU.CANTIDAD_ARTICULOS, " & _
            '"CASE WHEN CU.ID_ACTIVIDAD = 1 THEN 'I' " & _
            '"WHEN CU.ID_ACTIVIDAD = 2 THEN 'E' " & _
            '"ELSE '' " & _
            '"END AS TIPO, " & _
            '"SI.NOMBRE_SECUENCIAL_ITEM, K.ID_KARDEX, DCEB.OBSERVACION, CEB.RAZON " & _
            '"FROM CONTROL_UNIFORMES CU join COMPROBANTE_EGRESO_BODEGA CEB on CU.ID_COMPROBANTE = CEB.ID_COMPROBANTE " & _
            '"JOIN DETALLE_KARDEX DK ON CU.ID_DETALLE_KARDEX = DK.ID_DETALLE JOIN KARDEX K ON K.ID_KARDEX = DK.ID_KARDEX " & _
            '"JOIN SECUENCIAL_ITEM SI ON K.ID_SECUENCIAL_ITEM = SI.ID_SECUENCIAL_ITEM JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB " & _
            '"ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE " & _
            '"WHERE CEB.ID_SITIO_TRABAJO = @ID_SITIO AND CU.FECHA BETWEEN @FECHAD AND @FECHAH " & _
            '"AND CEB.ESTADO = 1 AND DK.ESTADO = 1) " & _
            '"AS TAB " & _
            '"GROUP BY TAB.COMPROBANTE,TAB.FECHA,TAB.CANTIDAD, TAB.ID_KARDEX, TAB.OBSERVACION,TAB.RAZON, TAB.TIPO, TAB.NOMBRE_SECUENCIAL_ITEM " & _
            '"ORDER BY TAB.FECHA"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)




            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function BuscarMayorIdSitio(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSitio", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarSitioxIdxIdPersonal(ByVal tipoCon As TipoConexion, ByVal idper As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idper", SqlDbType.Int, idper})
            Dim sql = "SELECT top 1 id_sitio_trabajo from asignacion_personal ap join sitios_trabajo si on ap.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general = cl.id_cliente_general where(ap.id_personal = @idper) order by ap.id_programacion desc"
            Dim data As DataTable = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            If data.Rows.Count > 0 AndAlso Not IsDBNull(data.Rows(0)(0)) Then
                Return CInt(data.Rows(0)(0))
            Else
                Return 0
            End If
        End Function

        Public Function SeleccionarSitiosClientexIdPersonal1(ByVal tipoCon As TipoConexion, ByVal idper As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.Int, idper})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select nombre_sitio_trabajo + ' (' + nompre_razon_social_cliente_general+ ')' from personal pe join sitios_trabajo st on pe.ubicacion = st.id_sitio_trabajo join cliente_general cl on st.id_cliente_general = cl.id_cliente_general where pe.id_personal = @idp", False, pars)
        End Function

        Public Function SeleccionarSitiosClientexIdPersonal2(ByVal tipoCon As TipoConexion, ByVal idper As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.Int, idper})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select top 1 si.nombre_sitio_trabajo+ ' (' + cl.nompre_razon_social_cliente_general  + ')' + ' DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general where dp.id_personal = @IDP order by dp.id_programacion desc, dp.fecha_desde desc", False, pars)
        End Function

        Public Function SeleccionarSitiosClientexIdPersonal3(ByVal tipoCon As TipoConexion, ByVal idper As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.Int, idper})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select nombre_sitio_trabajo, cl.nompre_razon_social_cliente_general, st.ID_SITIO_TRABAJO from personal pe join sitios_trabajo st on pe.ubicacion = st.id_sitio_trabajo join cliente_general cl on st.id_cliente_general = cl.id_cliente_general where pe.id_personal = @idp", False, pars)
        End Function
        Public Function SeleccionarSitiosFullClientexIdPersonal2(ByVal tipoCon As TipoConexion, ByVal idper As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, idper})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select top 1 str(id_sitio_trabajo)+'|'+si.nombre_sitio_trabajo+'|'+nompre_razon_social_cliente_general from asignacion_personal dp join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general = cl.id_cliente_general  where dp.id_personal = @idp order by dp.id_programacion desc, dp.fecha desc", False, pars)
        End Function

        

        Public Function SeleccionarSitiosFullClientexIdPersonal(ByVal tipoCon As TipoConexion, ByVal idper As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, idper})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select st.*, cl.*, (select top 1 str(id_sitio_trabajo)+'|'+si.nombre_sitio_trabajo+'|'+nompre_razon_social_cliente_general from asignacion_personal dp join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general = cl.id_cliente_general where dp.id_personal = pe.id_personal order by dp.id_programacion desc, dp.fecha desc) puesto from personal pe join sitios_trabajo st on pe.ubicacion = st.id_sitio_trabajo join cliente_general cl on st.id_cliente_general = cl.id_cliente_general where id_personal = @idp", False, pars)
        End Function

        Public Function SeleccionarSitiosxIdCliente(ByVal tipoCon As TipoConexion, ByVal idCliente As String, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, idCliente})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSitiosxIdCliente", True, pars) 
        End Function

        Public Function SeleccionarSitiosTrabajo2(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal todo As Integer) As DataTable
            Dim t = If(todo = 0, String.Empty, If(todo = 1, "s.estado=1 and", "s.estado=0 and"))
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "SELECT S.ID_SITIO_TRABAJO, s.NOMBRE_SITIO_TRABAJO, S.RIVER, S.ID_PROVINCIA,  P.NOMBRE_PROVINCIAS, S.ID_CIUDAD, " & _
                    "C.NOMBRE_CIUDADES, S.ID_PARROQUIA, R.NOMBRE_PARROQUIAS, S.DIRECCION_SITIO_TRABAJO, S.REFERENCIA_SITIO_TRABAJO, s.TIPO_SITIO_TRABAJO, " & _
                    "S.ID_PERSONAL_SUPERVISOR, E.APELLIDOS + ' ' + E.NOMBRES SUPERVISOR, S.ESTADO, s.ID_CLIENTE_GENERAL, G.TIPO_IDENTIFICACION_CLIENTE_GENERAL, " & _
                    "G.RUC_CI_CLIENTE_GENERAL, G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL,  S.LATITUD,  S.LONGITUD,  S.GRUPO, S.RIVE, S.PUESTO_HORAS, S.CANT_HORAS, S.CANT_HORAS_50, S.CANT_HORAS_100, S.CANT_HORAS_EXT, S.CANT_REC_NOC, S.CANT_ADICI, S.DECIMO_EXTRA " & _
                    "FROM SITIOS_TRABAJO S JOIN PROVINCIAS P ON S.ID_PROVINCIA= P.ID_PROVINCIAS " & _
                    "JOIN CIUDADES C ON S.ID_CIUDAD=C.ID_CIUDAD JOIN PARROQUIAS R ON S.ID_PARROQUIA=R.ID_PARROQUIAS " & _
                    "JOIN PERSONAL E ON S.ID_PERSONAL_SUPERVISOR=E.ID_PERSONAL " & _
                    "left join cliente_general G on  s.ID_CLIENTE_GENERAL=g.ID_CLIENTE_GENERAL " & _
                    "where " & t & " (S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%') OR S.RIVER LIKE ('%' + @FILTRO + '%') OR G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%' + @FILTRO + '%') OR G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%' + @FILTRO + '%')) ORDER BY s.rive, s.river"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarSitiosTrabajo4(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal todo As Integer) As DataTable
            Dim t = If(todo = 0, String.Empty, If(todo = 1, "s.estado=1 and", "s.estado=0 and"))
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "SELECT S.ID_SITIO_TRABAJO, S.RIVER, s.NOMBRE_SITIO_TRABAJO, S.DIRECCION_SITIO_TRABAJO,  C.NOMBRE_CIUDADES, E.APELLIDOS + ' ' + E.NOMBRES SUPERVISOR, S.ID_PROVINCIA,  P.NOMBRE_PROVINCIAS, " & _
                    " S.ID_CIUDAD, S.ID_PARROQUIA, R.NOMBRE_PARROQUIAS, S.REFERENCIA_SITIO_TRABAJO, s.TIPO_SITIO_TRABAJO, " & _
                    "S.ID_PERSONAL_SUPERVISOR,  S.ESTADO, s.ID_CLIENTE_GENERAL, G.TIPO_IDENTIFICACION_CLIENTE_GENERAL, " & _
                    "G.RUC_CI_CLIENTE_GENERAL, G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL,  S.LATITUD,  S.LONGITUD,  S.GRUPO, " & _
                    "S.RIVE, S.PUESTO_HORAS, S.CANT_HORAS, S.CANT_HORAS_50, S.CANT_HORAS_100, S.CANT_HORAS_EXT, S.CANT_REC_NOC, S.CANT_ADICI, S.DECIMO_EXTRA FROM SITIOS_TRABAJO S JOIN PROVINCIAS P ON S.ID_PROVINCIA= P.ID_PROVINCIAS " & _
                    "JOIN CIUDADES C ON S.ID_CIUDAD=C.ID_CIUDAD JOIN PARROQUIAS R ON S.ID_PARROQUIA=R.ID_PARROQUIAS " & _
                    "JOIN PERSONAL E ON S.ID_PERSONAL_SUPERVISOR=E.ID_PERSONAL " & _
                    "left join cliente_general G on  s.ID_CLIENTE_GENERAL=g.ID_CLIENTE_GENERAL " & _
                    "where " & t & " (S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%') OR S.RIVER LIKE ('%' + @FILTRO + '%') OR G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%' + @FILTRO + '%') OR G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%' + @FILTRO + '%')) ORDER BY  S.NOMBRE_SITIO_TRABAJO"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function SeleccionarSitiosTrabajo2Grupos(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal todo As Integer) As DataTable
            Dim t = If(todo = 0, String.Empty, If(todo = 1, "s.estado=1 and", "s.estado=0 and"))
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "SELECT G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL FROM SITIOS_TRABAJO S " & _
                    "JOIN PROVINCIAS P ON S.ID_PROVINCIA= P.ID_PROVINCIAS JOIN CIUDADES C ON S.ID_CIUDAD=C.ID_CIUDAD " & _
                    "JOIN PARROQUIAS R ON S.ID_PARROQUIA=R.ID_PARROQUIAS JOIN PERSONAL E ON S.ID_PERSONAL_SUPERVISOR=E.ID_PERSONAL " & _
                    "left join cliente_general G on  s.ID_CLIENTE_GENERAL=g.ID_CLIENTE_GENERAL " & _
                    "where " & t & " (S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%') OR S.RIVER LIKE ('%' + @FILTRO + '%') OR G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%' + @FILTRO + '%') OR G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%' + @FILTRO + '%')) " & _
                    "GROUP BY G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL ORDER BY G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function
 
        Public Function BuscarNombreSitioxIdSitio(ByVal tipoCon As TipoConexion, ByVal idSitio As Integer, ByVal dos As Boolean) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SITIO_TRABAJO", SqlDbType.Int, idSitio})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, If(dos, "select s.nombre_sitio_trabajo + ' ('+c.nompre_razon_social_cliente_general+')' NOMBRE_SITIO_TRABAJO from SITIOS_TRABAJO s join cliente_general c on s.id_cliente_general=c.id_cliente_general where s.id_sitio_trabajo = @ID_SITIO_TRABAJO", "buscarNombreSitioxIdSitio"), Not dos, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarSitiosTrabajo(ByVal tipoCon As TipoConexion) As DataSet
            Dim siti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SITIOS_TRABAJO", False) 
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS=1", False) 
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES=1", False) 
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS WHERE ESTADO_PARROQUIAS=1", False) 

            Dim ds = New DataSet()
            siti.Fill(ds, "SITIOS_TRABAJO")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            Return ds
        End Function
         
        Public Function RegistrarNuevoSitioTrabajoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoSitio"
                .Parameters.AddWithValue("@ID_SITIO_TRABAJO", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@ID_PROVINCIA", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIA", SqlDbType.Int).Value = IdParroquia
                .Parameters.AddWithValue("@DIRECCION_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Direccion
                .Parameters.AddWithValue("@REFERENCIA_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Referencia
                .Parameters.AddWithValue("@NOMBRE_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@TIPO_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = Cliente
                .Parameters.AddWithValue("@ID_PERSONAL_SUPERVISOR", SqlDbType.Int).Value = Supervisor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@LATITUD", SqlDbType.NVarChar).Value = Latitud
                .Parameters.AddWithValue("@LONGITUD", SqlDbType.NVarChar).Value = Longitud
                .Parameters.AddWithValue("@RIVER", SqlDbType.NVarChar).Value = River
                .Parameters.AddWithValue("@GRUPO", SqlDbType.NVarChar).Value = Grupo
                .Parameters.AddWithValue("@RIVE", SqlDbType.Int).Value = Riv
                .Parameters.AddWithValue("@PUESTO_HORAS", SqlDbType.Int).Value = HorasPuesto
                .Parameters.AddWithValue("@CANT_HORAS", SqlDbType.Decimal).Value = CantHorasNor
                .Parameters.AddWithValue("@CANT_HORAS_50", SqlDbType.Decimal).Value = CantHoras50
                .Parameters.AddWithValue("@CANT_HORAS_100", SqlDbType.Decimal).Value = CantHoras100
                .Parameters.AddWithValue("@CANT_HORAS_EXT", SqlDbType.Decimal).Value = CantHorasExt
                .Parameters.AddWithValue("@CANT_REC_NOC", SqlDbType.Decimal).Value = CantRecNoct
                .Parameters.AddWithValue("@CANT_ADICI", SqlDbType.Decimal).Value = CantAdicional
                .Parameters.AddWithValue("@DECIMO_EXTRA", SqlDbType.Int).Value = If(DecimosConExtra, 1, 0)
            End With
            Return comando
        End Function

        Public Function ModificarSitioTrabajoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "EditarSitio"
                .Parameters.AddWithValue("@ID_SITIO_TRABAJO", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@ID_PROVINCIA", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIA", SqlDbType.Int).Value = IdParroquia
                .Parameters.AddWithValue("@DIRECCION_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Direccion
                .Parameters.AddWithValue("@REFERENCIA_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Referencia
                .Parameters.AddWithValue("@NOMBRE_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@TIPO_SITIO_TRABAJO", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = Cliente
                .Parameters.AddWithValue("@ID_PERSONAL_SUPERVISOR", SqlDbType.Int).Value = Supervisor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@LATITUD", SqlDbType.NVarChar).Value = Latitud
                .Parameters.AddWithValue("@LONGITUD", SqlDbType.NVarChar).Value = Longitud
                .Parameters.AddWithValue("@RIVER", SqlDbType.NVarChar).Value = River
                .Parameters.AddWithValue("@GRUPO", SqlDbType.NVarChar).Value = Grupo
                .Parameters.AddWithValue("@RIVE", SqlDbType.Int).Value = Riv
                .Parameters.AddWithValue("@PUESTO_HORAS", SqlDbType.Int).Value = HorasPuesto
                .Parameters.AddWithValue("@CANT_HORAS", SqlDbType.Decimal).Value = CantHorasNor
                .Parameters.AddWithValue("@CANT_HORAS_50", SqlDbType.Decimal).Value = CantHoras50
                .Parameters.AddWithValue("@CANT_HORAS_100", SqlDbType.Decimal).Value = CantHoras100
                .Parameters.AddWithValue("@CANT_HORAS_EXT", SqlDbType.Decimal).Value = CantHorasExt
                .Parameters.AddWithValue("@CANT_REC_NOC", SqlDbType.Decimal).Value = CantRecNoct
                .Parameters.AddWithValue("@CANT_ADICI", SqlDbType.Decimal).Value = CantAdicional
                .Parameters.AddWithValue("@DECIMO_EXTRA", SqlDbType.Int).Value = If(DecimosConExtra, 1, 0)
            End With
            Return comando
        End Function

        Public Function ModificarEstadoSitioTrabajoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update SITIOS_TRABAJO set estado = @estado where ID_SITIO_TRABAJO=@ID_SITIO_TRABAJO;"
                .Parameters.AddWithValue("@ID_SITIO_TRABAJO", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function GuardarGruposSitioTrabajoCommand(ByVal grupo As String) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into GRUPO_STITIO values (@GRUPO, @desc_diff);"
                .Parameters.AddWithValue("@GRUPO", SqlDbType.VarChar).Value = grupo
                .Parameters.AddWithValue("@desc_diff", SqlDbType.Int).Value = 1
            End With
            Return comando
        End Function

        Public Function SeleccionarGruposSitioTrabajo(ByVal tipoCon As TipoConexion, ByVal grupo As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"GR", SqlDbType.VarChar, River})
            Dim sql = "select rtrim(ltrim(grupo)) grupo from GRUPO_STITIO where grupo = @GR group by grupo;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarGruposSitioTrabajo(ByVal tipoCon As TipoConexion) As DataTable 
            Dim sql = "select rtrim(ltrim(grupo)) grupo from GRUPO_STITIO group by grupo;"
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, False)
        End Function

        Public Function ExisteNumeroRiverActivo(ByVal tipoCon As TipoConexion, ByVal idSitio As String, ByVal river As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"river", SqlDbType.VarChar, river})
            pars.Add(New Object() {"idSitio", SqlDbType.Int, idSitio})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from sitios_trabajo where estado = 1 and river=@river and id_sitio_trabajo <>@idSitio", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("NOMBRE_SITIO_TRABAJO")))
        End Function
         
        Public Function SeleccionarRegistroGrupoAsistenciaDetallesByPuestoDias(ByVal tipoCon As TipoConexion, ByVal idp As Integer, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.Int, idp})
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta}) 

            Dim sql = "select * from (select * from (select ap.fecha fecha, 'REGISTROS DEL DÍA: ' + convert(varchar, ap.fecha, 103) dia from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where ap.id_puesto=@IDP and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)as data union select * from (SELECT IndividualDate fecha, 'REGISTROS DEL DÍA: ' + convert(varchar, IndividualDate, 103) dia FROM DatesInRange('d', @DESDE, @HASTA) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where ap.id_puesto=@IDP AND ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) as data group by data.dia, data.fecha) as tab order by tab.fecha"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function
        Public Function SeleccionarRegistroDetalleAsistenciaDetallesByPuestoDias(ByVal tipoCon As TipoConexion, ByVal idp As Integer, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.Int, idp})
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta}) 

            Dim sql = "select * from (select 'REGISTROS DEL DÍA: ' + convert(varchar, ap.fecha, 103) dia, ap.fecha, ap.id_personal, pe.cedula, pe.apellidos + ' ' + pe.nombres nombres, ap.tipo, ap.horario, ap.entrada, ap.c50, ap.c51, ap.c40, ap.c41, ap.salida, case ap.cantrep when 0 then 'SIN NOVEDAD' else str(ap.cantrep) + ' - NO CONTESTADO' end multa, case len(rtrim(ltrim(ap.observacion))) when 0 then 'SIN NOVEDADES' else ap.observacion end observacion from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where ap.id_puesto=@IDP and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)as data union select * from (SELECT 'REGISTROS DEL DÍA: ' + convert(varchar, IndividualDate, 103) dia, IndividualDate fecha, 0 id_personal, 'SIN DATOS' cedula, '' nombres, 'LIBRE' tipo, '' horario, '' entrada, '' c50, '' c51, '' c40, '' c41, '' salida,'SIN NOVEDAD' multa, 'SIN NOVEDADES' observacion FROM DatesInRange('d', @DESDE, @HASTA) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where ap.id_puesto=@IDP AND ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) as data order by data.fecha"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function




        Public Function SeleccionarRegistroGrupoAsistenciaDetallesByPuestoDiasCliente(ByVal tipoCon As TipoConexion, ByVal idc As Integer, ByVal desde As DateTime, ByVal hasta As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDC", SqlDbType.Int, idc})
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "select * from(select ap.fecha fecha, 'REGISTROS DEL DÍA: ' + convert(varchar, ap.fecha, 103) dia from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO si on ap.id_puesto = si.id_sitio_trabajo join CLIENTE_GENERAL cl on si.ID_CLIENTE_GENERAL = cl.ID_CLIENTE_GENERAL where cl.ID_CLIENTE_GENERAL=@IDC and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE AND @HASTA and (pe.apellidos like ('%' + @FILTRO + '%') or pe.nombres like ('%' + @FILTRO + '%'))) as tab group by tab.dia, tab.fecha;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarRegistroDetalleAsistenciaDetallesByPuestoDiasCliente(ByVal tipoCon As TipoConexion, ByVal idc As Integer, ByVal desde As DateTime, ByVal hasta As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDC", SqlDbType.Int, idc})
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Dim sql = "select 'REGISTROS DEL DÍA: ' + convert(varchar, ap.fecha, 103) dia, ap.fecha, ap.id_personal, pe.cedula, pe.apellidos + ' ' + pe.nombres nombres, ap.tipo, ap.horario, ap.entrada, ap.c50, ap.c51, ap.c40, ap.c41, ap.salida, case ap.cantrep when 0 then 'SIN NOVEDAD' else str(ap.cantrep) + ' - NO CONTESTADO' end multa, case len(rtrim(ltrim(ap.observacion))) when 0 then 'SIN NOVEDADES' else ap.observacion end observacion from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal join SITIOS_TRABAJO si on ap.id_puesto = si.id_sitio_trabajo join CLIENTE_GENERAL cl on si.ID_CLIENTE_GENERAL = cl.ID_CLIENTE_GENERAL where cl.ID_CLIENTE_GENERAL=@IDC and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE AND @HASTA and (pe.apellidos like ('%' + @FILTRO + '%') or pe.nombres like ('%' + @FILTRO + '%')) order by ap.fecha;"

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function
    End Class
End Namespace


