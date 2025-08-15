Imports System.Windows.Forms
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassPersonal

        Public Function SeleccionarTodosRegistrosPersonal(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosRegistrosPersonal", True)
        End Function
         
        Public Function SeleccionarTodosLosRegistrosSupervisores(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosSupervisores", True)
        End Function
        Public Function SeleccionarCajasChicasCustodios(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCajasChicasCustodios", True) 
        End Function

        Public Function BuscarDatosPersonal(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRES", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorNombreElPersonal", True, pars) 
        End Function

        Public Function BuscarPorApellidosElPersonal(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal todos As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"APELLIDOS", SqlDbType.VarChar, parametroBusqueda})
            Dim sql = If(todos, "SELECT * FROM dbo.PERSONAL WHERE APELLIDOS LIKE @APELLIDOS+'%';", "buscarPorApellidosElPersonal")
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, Not todos, pars) 
        End Function
        Public Function BuscarPorCedulaNombreApellidoElPersonalUni(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DATO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorCedulaNombreApellidoElPersonalMin", True, pars)
        End Function
        Public Function BuscarPorCedulaElPersonal(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CEDULA", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPorCedulaElPersonal", True, pars) 
        End Function
 
        Public Function BuscarPersonalCustodioBodegaPorIdBodega(ByVal tipoCon As TipoConexion, ByVal idBodega As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"BODEGA", SqlDbType.Int, idBodega})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.id_personal, p.cedula, (p.apellidos + ' ' + p.nombres) nombres from personal p join bodega b on p.id_personal = b.id_personal_bodega  where b.id_bodega = @BODEGA and p.estado_personal = 1", False, pars)
        End Function

        Public Function BuscarPersonalXIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonsal As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonsal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM PERSONAL p  join cargo_ocupacional c on p.id_cargo_ocupacional = c.id_cargo_ocupacional join area_general a on p.id_area = a.id_area_general WHERE p.ID_PERSONAL=@ID_PERSONAL;", False, pars)
        End Function

        Public Function BuscarCedulaPersonalXIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonsal As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonsal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT CEDULA FROM dbo.PERSONAL WHERE   @ID_PERSONAL=ID_PERSONAL;", False, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("CEDULA")))
        End Function

        Public Function BuscarNombresPersonalXIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonsal As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonsal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT NOMBRES FROM dbo.PERSONAL WHERE @ID_PERSONAL=ID_PERSONAL;", False, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("NOMBRES")))
        End Function
        Public Function BuscarApellidosPersonalXIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonsal As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonsal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT APELLIDOS FROM dbo.PERSONAL WHERE @ID_PERSONAL=ID_PERSONAL;", False, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarApellidosNombresPersonalXIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonsal As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonsal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT (APELLIDOS + ' ' + NOMBRES) NOMBRES FROM dbo.PERSONAL WHERE @ID_PERSONAL=ID_PERSONAL;", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("NOMBRES")))
        End Function

        Public Function BuscarPersonalPorIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonal As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonal})
            Dim obje = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarPersonalPorIdPersonal", True, pars) 
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE ESTADO = 1", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EMPRESA_GENERAL WHERE  ESTADO_EMPRESA=1", False) 

            Dim ds = New DataSet()
            obje.Fill(ds, "PERSONAL")
            acti.Fill(ds, "CARGO_OCUPACIONAL")
            empr.Fill(ds, "AREA_GENERAL")
            Return ds
        End Function
         
        Public Function BuscarPersonalConId(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT APELLIDOS + ' ' + NOMBRES + ' - ' + ltrim(rtrim( str(ID_PERSONAL))) DATOS, ID_PERSONAL ID FROM PERSONAL WHERE ESTADO_PERSONAL = 1 ORDER BY DATOS", False)
        End Function

        Public Function BuscarPersonal(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarPersonal", True) 
        End Function

        Public Function AutocompletarConId(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarPersonalConId(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("DATOS")))
            Next
            Return coleccion
        End Function
         
        Public Function BuscarIdPersonalXIdUsuario(ByVal tipoCon As TipoConexion, ByVal iduser As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDUSER", SqlDbType.VarChar, iduser})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ID_PERSONAL FROM USUARIO_GENERAL WHERE ID_USUARIO=@IDUSER;", False, pars)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_PERSONAL")))
        End Function

        Private Function SeleccionarApellidosNombresYIdPersonal(ByVal tipoCon As TipoConexion, ByVal todos As Boolean) As DataTable
            Dim sql = If(todos, "SELECT	APELLIDOS + ' ' + NOMBRES + ' - ' + CAST(ID_PERSONAL AS NVARCHAR(10)) AS DATOS, " & _
                            "ID_PERSONAL AS CODIGO FROM dbo.PERSONAL ORDER BY ID_PERSONAL", "SeleccionarApellidosNombresYIdPersonal")

            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, False) 
        End Function

        'Public Function SeleccionarIdPersonal(ByVal tipoCon As TipoConexion, ByVal para As String) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"para", SqlDbType.VarChar, para})
        '    Dim Sql = "SELECT ID_PERSONAL AS CODIGO FROM dbo.PERSONAL WHERE APELLIDOS + ' ' + NOMBRES LIKE '%' + REPLACE(@para, ' ', '%') + '%' OR NOMBRES + ' ' + APELLIDOS LIKE '%' + REPLACE(@para, ' ', '%') + '%' "
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, Sql, False, pars)
        'End Function

        'Public Function BuscarIdPersonalXIdUsuario(ByVal tipoCon As TipoConexion, ByVal iduser As String) As Integer
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"IDUSER", SqlDbType.VarChar, iduser})
        '    Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ID_PERSONAL FROM USUARIO_GENERAL WHERE ID_USUARIO=@IDUSER;", False, pars)
        '    Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_PERSONAL")))
        'End Function

        Public Function SeleccionarIdPersonal(ByVal tipoCon As TipoConexion, ByVal para As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"para", SqlDbType.VarChar, para})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT TOP 1 ID_PERSONAL FROM dbo.PERSONAL WHERE APELLIDOS + ' ' + NOMBRES LIKE '%' + REPLACE(@para, ' ', '%') + '%' OR NOMBRES + ' ' + APELLIDOS LIKE '%' + REPLACE(@para, ' ', '%') + '%' ", False, pars)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_PERSONAL")))
        End Function

        Public Function AutocompletarApellidos(ByVal tipoCon As TipoConexion, ByVal todos As Boolean) As AutoCompleteStringCollection
            Dim dt As DataTable = SeleccionarApellidosNombresYIdPersonal(tipoCon, todos)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("DATOS")))
            Next
            Return coleccion
        End Function

        Public Function BuscarFiltradoPorNombrePersonalGeneral(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal todos As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Dim sql As String
            If todos Then
                sql = "SELECT	ID_PERSONAL, '1' as 'un', '2' as 'dos' ,CEDULA ,NOMBRES ,APELLIDOS ,'3' as 'tres',PROVINCIA,DIRECCION       FROM	dbo.PERSONAL WHERE(CEDULA LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or NOMBRES LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or APELLIDOS LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%'));"
            Else
                sql = "buscarFiltradoPorNombrePersonalGeneral"
            End If
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, Not todos, pars) 
        End Function

        Public Function BuscarFiltradoPorNombrePersonalGeneralOperaciones(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal todos As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"filtro", SqlDbType.NVarChar, parametroBusqueda})
            pars.Add(New Object() {"todos", SqlDbType.Bit, todos})
            'Dim sql = "select p.id_personal,1 un,2 dos, p.cedula, p.nombres, p.apellidos, 3 tres,c.descripcion cargo, " & _
            '            "a.nombre_area area, p.movil, p.telefono from personal p join area_general a on p.id_area = a.id_area_general join cargo_ocupacional c on " & _
            '                "p.id_cargo_ocupacional = c.id_cargo_ocupacional where " & (If(todos, String.Empty, "estado_personal = 1 and a.id_gerencias_general=2 and ")) & " (p.cedula like ('%'+ @filtro +'%') or p.apellidos like ('%'+ @filtro +'%') or p.nombres like ('%'+ @filtro +'%') or c.descripcion like ('%'+ @filtro +'%') or a.nombre_area like ('%'+ @filtro +'%')) order by p.apellidos, p.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarFiltradoPorNombrePerosnalGenrealOperaciones", True, pars)
        End Function

        Public Function BuscarFiltradoPorNombrePersonalGeneralAdministrativo(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal todos As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"filtro", SqlDbType.VarChar, parametroBusqueda})
            Dim sql = "select p.id_personal,1 un,2 dos, p.cedula, p.nombres, p.apellidos, 3 tres,c.descripcion cargo, " & _
                        "a.nombre_area area, p.movil, p.telefono from personal p join area_general a on p.id_area = a.id_area_general join cargo_ocupacional c on " & _
                            "p.id_cargo_ocupacional = c.id_cargo_ocupacional where a.id_gerencias_general = 1 " & (If(todos, String.Empty, "and estado_personal = 1")) & " and (p.cedula like ('%'+ @filtro +'%') or p.apellidos like ('%'+ @filtro +'%') or p.nombres like ('%'+ @filtro +'%') or c.descripcion like ('%'+ @filtro +'%') or a.nombre_area like ('%'+ @filtro +'%')) order by p.apellidos, p.nombres;"
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars) 
        End Function

        Public Function BuscarPersonalUtilidades(ByVal tipoCon As TipoConexion, ByVal desde As DateTime, ByVal hasta As DateTime, ByVal tipo As Integer, ByVal anio As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@desde", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@hasta", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"@tipo", SqlDbType.Int, tipo})
            pars.Add(New Object() {"@anio", SqlDbType.DateTime, anio})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarPersonalParaPagoUtilidad", True, pars)

        End Function
    End Class
End Namespace
