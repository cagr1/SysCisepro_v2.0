Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UNIFORMES
    Public Class ClassControlUniformes
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdControl As Int64
        Public IdPersonal As Integer
        Public IdComprobante As String
        Public Cantidad As Integer
        Public Fecha As DateTime
        Public IdActividad As Integer
        Public Estado As Integer
        Public IdDetalleKardex As Int64
        
        Public Function BuscarMayorIdControlUniformes(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdControlUniformes", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroControlUniformesCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroControlUniformes"
                .Parameters.AddWithValue("@ID_CONTROL", SqlDbType.BigInt).Value = IdControl
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@CANTIDAD_ARTICULOS", SqlDbType.Int).Value = Cantidad
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex
            End With
            Return comando
        End Function

        Public Function SeleccionarMovimientosKardexByIdPersonal(ByVal tipoCon As TipoConexion, ByVal idPersonal As Integer, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PERSONAL", SqlDbType.Int, idPersonal})
            pars.Add(New Object() {"DESDE", SqlDbType.Date, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.Date, hasta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT dbo.CONTROL_UNIFORMES.ID_CONTROL AS 'CONTROL', dbo.CONTROL_UNIFORMES.ID_COMPROBANTE AS 'NRO COMPROBANTE', dbo.ACTIVIDAD_INVENTARIOS.DETALLE_ACTIVIDAD AS 'ACTIVIDAD', dbo.CONTROL_UNIFORMES.CANTIDAD_ARTICULOS AS 'CANTIDAD', dbo.CONTROL_UNIFORMES.FECHA, dbo.PERSONAL.APELLIDOS + ' ' + dbo.PERSONAL.NOMBRES AS 'NOMBRES', dbo.DETALLE_KARDEX.ID_DETALLE AS 'ID DETALLE', dbo.SECUENCIAL_ITEM.NOMBRE_SECUENCIAL_ITEM as 'ITEM', dbo.KARDEX.ID_KARDEX as'KARDEX', case when dbo.ACTIVIDAD_INVENTARIOS.ID_ACTIVIDAD = 1 then (select razon from comprobante_ingreso_bodega where id_comprobante = dbo.CONTROL_UNIFORMES.ID_COMPROBANTE) else (select razon from comprobante_egreso_bodega where id_comprobante = dbo.CONTROL_UNIFORMES.ID_COMPROBANTE) end MOTIVO FROM dbo.CONTROL_UNIFORMES, dbo.PERSONAL, dbo.ACTIVIDAD_INVENTARIOS, dbo.DETALLE_KARDEX, dbo.KARDEX, dbo.SECUENCIAL_ITEM WHERE dbo.CONTROL_UNIFORMES.estado > 0 and dbo.CONTROL_UNIFORMES.ID_ACTIVIDAD=dbo.ACTIVIDAD_INVENTARIOS.ID_ACTIVIDAD AND dbo.CONTROL_UNIFORMES.ID_DETALLE_KARDEX=dbo.DETALLE_KARDEX.ID_DETALLE AND dbo.DETALLE_KARDEX.ID_KARDEX=dbo.KARDEX.ID_KARDEX AND dbo.KARDEX.ID_SECUENCIAL_ITEM=dbo.SECUENCIAL_ITEM.ID_SECUENCIAL_ITEM and dbo.CONTROL_UNIFORMES.id_personal = dbo.PERSONAL.id_personal and dbo.CONTROL_UNIFORMES.id_personal = @ID_PERSONAL and dbo.CONTROL_UNIFORMES.fecha between @DESDE and @HASTA order by dbo.CONTROL_UNIFORMES.FECHA;", False, pars)
        End Function

        Public Function SeleccionarMovimientosKardexByIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Integer, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.Int, idKardex})
            pars.Add(New Object() {"DESDE", SqlDbType.Date, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.Date, hasta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT dbo.CONTROL_UNIFORMES.ID_CONTROL AS 'CONTROL', dbo.CONTROL_UNIFORMES.ID_COMPROBANTE AS 'NRO COMPROBANTE', dbo.ACTIVIDAD_INVENTARIOS.DETALLE_ACTIVIDAD AS 'ACTIVIDAD', dbo.CONTROL_UNIFORMES.CANTIDAD_ARTICULOS AS 'CANTIDAD', dbo.CONTROL_UNIFORMES.FECHA, dbo.PERSONAL.APELLIDOS + ' ' + dbo.PERSONAL.NOMBRES AS 'NOMBRES', dbo.DETALLE_KARDEX.ID_DETALLE AS 'ID DETALLE', dbo.SECUENCIAL_ITEM.NOMBRE_SECUENCIAL_ITEM as 'ITEM', dbo.KARDEX.ID_KARDEX as'KARDEX', case when dbo.ACTIVIDAD_INVENTARIOS.ID_ACTIVIDAD = 1 then (select razon from comprobante_ingreso_bodega where id_comprobante = dbo.CONTROL_UNIFORMES.ID_COMPROBANTE) else (select razon from comprobante_egreso_bodega where id_comprobante = dbo.CONTROL_UNIFORMES.ID_COMPROBANTE) end MOTIVO FROM dbo.CONTROL_UNIFORMES, dbo.PERSONAL, dbo.ACTIVIDAD_INVENTARIOS, dbo.DETALLE_KARDEX, dbo.KARDEX, dbo.SECUENCIAL_ITEM WHERE dbo.CONTROL_UNIFORMES.estado > 0 and dbo.CONTROL_UNIFORMES.ID_ACTIVIDAD=dbo.ACTIVIDAD_INVENTARIOS.ID_ACTIVIDAD AND dbo.CONTROL_UNIFORMES.ID_DETALLE_KARDEX=dbo.DETALLE_KARDEX.ID_DETALLE AND dbo.DETALLE_KARDEX.ID_KARDEX=dbo.KARDEX.ID_KARDEX AND dbo.KARDEX.ID_SECUENCIAL_ITEM=dbo.SECUENCIAL_ITEM.ID_SECUENCIAL_ITEM and dbo.CONTROL_UNIFORMES.id_personal = dbo.PERSONAL.id_personal and dbo.KARDEX.ID_KARDEX = @ID_KARDEX and dbo.CONTROL_UNIFORMES.fecha between @DESDE and @HASTA order by dbo.CONTROL_UNIFORMES.FECHA;", False, pars)
        End Function


        Public Function BuscarItemsKardexReporte(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DATO", SqlDbType.VarChar, "%" & parametroBusqueda & "%"})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT K.ID_KARDEX, S.ID_SECUENCIAL_ITEM, S.NOMBRE_SECUENCIAL_ITEM, S.DESCRIPCION FROM KARDEX K JOIN SECUENCIAL_ITEM S ON K.ID_SECUENCIAL_ITEM = S.ID_SECUENCIAL_ITEM WHERE S.NOMBRE_SECUENCIAL_ITEM LIKE @dato;", False, pars)
        End Function

        Public Function SeleccionarComprobanteUniformesxRengoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteUniformesxRangoFechas", True, pars) 
        End Function

        Public Function SeleccionarComprobanteUniformesxNroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteUniformesxNroComprobante", True, pars) 
        End Function

        Public Function SeleccionarComprobanteUniformesxDealle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteUniformesxDealle", True, pars)
        End Function

        Public Function SeleccionarDetallesComprobanteuNniformesXId(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesComprobanteUniformesXId", True, pars) 
        End Function

        'Public Function SeleccionarIdPersonal(ByVal tipoCon As TipoConexion, ByVal para As String) As Integer
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"para", SqlDbType.VarChar, para})
        '    Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT TOP 1 ID_PERSONAL FROM dbo.PERSONAL WHERE APELLIDOS + ' ' + NOMBRES LIKE '%' + REPLACE(@para, ' ', '%') + '%' OR NOMBRES + ' ' + APELLIDOS LIKE '%' + REPLACE(@para, ' ', '%') + '%' ", False, pars)
        '    Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_PERSONAL")))
        'End Function

        'Public Function SeleccionarIdControlUniformes(ByVal tipoCon As TipoConexion, ByVal Idcomp As String, ByVal idper As Int32, ByVal idkar As Int64) As Integer
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"idcomp", SqlDbType.VarChar, Idcomp})
        '    pars.Add(New Object() {"idper", SqlDbType.Int, idper})
        '    pars.Add(New Object() {"iddetkar", SqlDbType.BigInt, idkar})
        '    Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarIdControlUniformes", False, pars)
        '    Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_CONTROL")))
        'End Function

        Public Function SeleccionarIdControlUniformes(ByVal tipoCon As TipoConexion, ByVal Idcomp As String, ByVal idkar As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idcomp", SqlDbType.VarChar, Idcomp})
            'pars.Add(New Object() {"idper", SqlDbType.Int, idper})
            pars.Add(New Object() {"iddetkar", SqlDbType.BigInt, idkar})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarIdControlUniformes", True, pars)


        End Function

        Public Function ModificarControlCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarControlUniformes"
                .Parameters.AddWithValue("@ID_CONTROL", SqlDbType.BigInt).Value = IdControl
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = IdComprobante
                .Parameters.AddWithValue("@CANTIDAD_ARTICULOS", SqlDbType.Int).Value = Cantidad
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_DETALLE_KARDEX", SqlDbType.BigInt).Value = IdDetalleKardex

                
            End With
            Return comando
        End Function

    End Class
End Namespace

