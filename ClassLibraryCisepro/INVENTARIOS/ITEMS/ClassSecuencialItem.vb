Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.ITEMS
    Public Class ClassSecuencialItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public Codigo As String
        Public Nombre As String
        Public Fecha As Date
        Public IdMarca As Integer
        Public IdModelo As Integer
        Public IdMaterial As Integer
        Public IdColor As Integer
        Public IdUnidadMedida As Integer
        Public Descripcion As String
        Public Serie As String
        Public Estado As Integer
        Public IdSubGrupo As Int64
        Public IdLote As Int64
        Public Costo As Decimal
        Public Pvp As Decimal

        Public Function ContarMayorIdSubGrupoxIdSubGrupoItem(ByVal tipoCon As TipoConexion, ByVal idSubGrupoItem As Integer) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SUB_GRUPO_ITEM", SqlDbType.Int, idSubGrupoItem})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "contarMayorIdSubGrupoxIdSubGrupoItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaSecuencialItemCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSecuencialItem"
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CODIGO_SECUENCIAL_ITEM", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@NOMBRE_SECUENCIAL_ITEM", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@FECHA_SECUENCIAL_ITEM", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ID_MARCA", SqlDbType.Int).Value = IdMarca
                .Parameters.AddWithValue("@ID_MODELO", SqlDbType.Int).Value = IdModelo
                .Parameters.AddWithValue("@ID_MATERIAL", SqlDbType.Int).Value = IdMaterial
                .Parameters.AddWithValue("@ID_COLOR", SqlDbType.Int).Value = IdColor
                .Parameters.AddWithValue("@ID_UNIDAD_MEDIDA", SqlDbType.Int).Value = IdUnidadMedida
                .Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = Descripcion
                .Parameters.AddWithValue("@SERIE", SqlDbType.NVarChar).Value = Serie
                .Parameters.AddWithValue("@ESTADO_SECUENCIAL_ITEM", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_SUB_GRUPO_ITEM", SqlDbType.Int).Value = IdSubGrupo
                .Parameters.AddWithValue("@ID_LOTE", SqlDbType.BigInt).Value = IdLote
                .Parameters.AddWithValue("@COSTO", SqlDbType.Decimal).Value = Costo
                .Parameters.AddWithValue("@PVP", SqlDbType.Decimal).Value = Pvp
            End With
            Return comando
        End Function

        Public Function BuscarMayorIdSecuencialItem(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSecuencialItem", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarSecuencialItemsActivas(ByVal tipoCon As TipoConexion, ByVal cate As String, ByVal grup As String, ByVal subg As String, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})

            Dim c = If(cate = 0, String.Empty, " ca.ID_categoria_ITEM=" & cate & " and ")
            Dim g = If(grup = 0, String.Empty, " gu.ID_GRUPO_ITEM=" & grup & " and ")
            Dim s = If(subg = 0, String.Empty, " su.ID_SUB_GRUPO_ITEM=" & subg & " and ")

            Dim sql = "select si.ID_SECUENCIAL_ITEM AS 'ID', si.CODIGO_SECUENCIAL_ITEM AS 'CÓDIGO', si.NOMBRE_SECUENCIAL_ITEM AS 'PRODUCTO', si.DESCRIPCION AS 'DESCRIPCIÓN', SI.SERIE,  coalesce(si.COSTO,0)    AS 'COSTO', coalesce(si.PVP,0)   AS 'PVP', (select KX.CANTIDAD from kardex kx WHERE KX.ID_SECUENCIAL_ITEM = si.ID_SECUENCIAL_ITEM) STOCK, " & _
"si.FECHA_SECUENCIAL_ITEM AS 'FECHA CREACIÓN', mg.DETALLE AS 'MARCA', mo.DETALLE AS 'MODELO', ma.DETALLE AS 'MATERIAL', co.DETALLE AS 'COLOR', un.DETALLE_UNIDAD_MEDIDA AS 'UNIDAD MEDIDA', " & _
"un.CODIGO_UNIDAD_MEDIDA AS 'MEDIDA', su.NOMBRE_SUB_GRUPO_ITEM AS 'SUB GRUPO' , gu.NOMBRE_GRUPO_ITEM AS 'GRUPO' , ca.NOMBRE_categoria_ITEM AS 'CATEGORIA', su.ID_SUB_GRUPO_ITEM AS 'ID SUB GRUPO', gu.ID_GRUPO_ITEM AS 'ID GRUPO', ca.ID_categoria_ITEM AS 'ID CATEGORIA' " & _
"from secuencial_item si join marca_general mg on si.id_marca = mg.id_marca join modelo_general mo on si.id_modelo = mo.id_modelo join material_general ma on si.id_material = ma.id_material " & _
"join color_general co on si.id_color = co.id_color join unidad_medida un on si.id_unidad_medida = un.id_unidad_medida join sub_grupo_item su on si.id_sub_grupo_item = su.id_sub_grupo_item " & _
"join grupo_item gu on su.id_grupo_item = gu.id_grupo_item join categoria_item ca on gu.id_categoria_item = ca.id_categoria_item where si.estado_secuencial_item = 1 and mg.estado = 1  " & _
"and mo.estado= 1 and ma.estado = 1 and co.estado = 1 and un.ESTADO_UNIDAD_MEDIDA = 1 and  " & c & g & s & _
"(si.NOMBRE_SECUENCIAL_ITEM like ('%'+@FILTRO+'%') or si.DESCRIPCION like ('%' + @FILTRO + '%') or si.SERIE like ('%' + @FILTRO + '%')) ORDER BY si.ID_SUB_GRUPO_ITEM ASC , si.NOMBRE_SECUENCIAL_ITEM "

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function SeleccionarSecuencialItemsXNombre(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM SECUENCIAL_ITEM S JOIN UNIDAD_MEDIDA U ON S.ID_UNIDAD_MEDIDA=U.ID_UNIDAD_MEDIDA WHERE S.NOMBRE_SECUENCIAL_ITEM = @FILTRO;", False, pars)
        End Function

        Public Function SeleccionarSecuencialItemsActivas(ByVal tipoCon As TipoConexion, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FILTRO", SqlDbType.NVarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSecuencialItemsActivasFiltro", True, pars)
        End Function

        Public Function BuscarPvpSecuencialItemXIdSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Double
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ids", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select pvp from secuencial_item where id_secuencial_item = @ids;", False, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDbl(data.Rows(0)(0))))
        End Function

        Public Function BuscarCostoSecuencialItemXIdSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Double
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ids", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select costo from secuencial_item where id_secuencial_item = @ids;", False, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDbl(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdSecuencialItemXNombreSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SECUENCIAL_ITEM", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdSecuencialItemXNombreSecuencialItem", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCostoSecuencialItemXNombreSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Double
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SECUENCIAL_ITEM", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCostoSecuencialItemXNombreSecuencialItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDbl(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreSecuencialItem(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombreSecuencialItem", True) 
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombreSecuencialItem(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("NOMBRE_SECUENCIAL_ITEM")))
            Next
            Return coleccion
        End Function

        Public Function BuscarCodigoSecuencialItemxNombreSecuencial(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SECUENCIAL_ITEM", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoSecuencialItemxNombreSecuencial", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreSecuencialItemXIdSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SECUENCIAL_ITEM", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreSecuencialItemXIdSecuencialItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarSecuencialItemXIdSecuencialItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Int32) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SECUENCIAL_ITEM", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarSecuencialItemXIdSecuencialItem", True, pars) 
        End Function

        Public Function ModificarPreciosCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarPrecios"
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@COSTO", SqlDbType.Decimal).Value = Costo
                .Parameters.AddWithValue("@PVP", SqlDbType.Decimal).Value = Pvp
            End With
            Return comando
        End Function
         
    End Class
End Namespace

