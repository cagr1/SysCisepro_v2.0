Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.COMPROBANTES
    Public Class ClassComprobanteIngresoBodego
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As String
        Public Fecha As DateTime
        Public NroParametroDocumento As String
        Public IdBodega As Int64
        Public IdActividad As Integer
        Public IdConcepto As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdCentroCosto As Integer
        Public IdParametroDocumento As Integer
        Public Estado As Integer 
        Public Razon As String
        Public IdPersonal As Integer
        Public IdEmpresa As Integer
        Public Cliente As String
        Public SitioTrabajo As String

        Public IdOrdenCompra As Int64

        Public Function BuscarClienteByIdComprobanteEgresoBodega(ByVal tipoCon As TipoConexion, ByVal idComprobante As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select cliente from comprobante_ingreso_bodega where id_comprobante=@ID_COMPROBANTE", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorIdComprobanteIngresoBodega(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteIngresoBodega", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroComprobanteIngresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteIngresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NRO_PARAMETRO", SqlDbType.NVarChar).Value = NroParametroDocumento
                .Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodega
                .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
                .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = IdConcepto
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTO", SqlDbType.Int).Value = IdParametroDocumento
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@RAZON", SqlDbType.NVarChar).Value = Razon
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@CLIENTE", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@SITIO", SqlDbType.NVarChar).Value = SitioTrabajo
            End With
            Return comando
        End Function

        Public Function ModificarRegistroComprobanteIngresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarComprobanteIngresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NRO_PARAMETRO", SqlDbType.NVarChar).Value = NroParametroDocumento
                .Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodega
                .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
                .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = IdConcepto
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTO", SqlDbType.Int).Value = IdParametroDocumento
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@RAZON", SqlDbType.NVarChar).Value = Razon
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@CLIENTE", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@SITIO", SqlDbType.NVarChar).Value = SitioTrabajo
            End With
            Return comando
        End Function


        Public Function AnularRegistroComprobanteIngresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_anularComprobanteIngresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id

            End With
            Return comando
        End Function

        Public Function SeleccionarComprobanteIngresoxIdCompronanteIngreso(ByVal tipoCon As TipoConexion, ByVal idComprobante As String) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            Dim comp = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarComprobanteIngresoxIdCompronanteIngreso", True, pars)
            Dim detc = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_INGRESO_BODEGA", False)
            Dim acin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVIDAD_INVENTARIOS", False)
            Dim coin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CONCEPTOS_INVENTARIOS", False)
            Dim deci = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_CONCEPTO_INVENTARIOS", False)
            Dim bode = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.BODEGA", False)
            Dim kard = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.KARDEX", False)
            Dim secu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM", False)
            Dim deta = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_KARDEX", False)
            Dim unid = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.UNIDAD_MEDIDA", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL", False)
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS", False)
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES", False)
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS", False)
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CENTRO_COSTO", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.EMPRESA_GENERAL", False)
            Dim pard = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PRAMETROS_DOCUMENTOS", False)

            Dim ds = New DataSet()
            comp.Fill(ds, "COMPROBANTE_INGRESO_BODEGA")
            detc.Fill(ds, "DETALLE_COMPROBANTE_INGRESO_BODEGA")
            acin.Fill(ds, "ACTIVIDAD_INVENTARIOS")
            coin.Fill(ds, "CONCEPTOS_INVENTARIOS")
            deci.Fill(ds, "DETALLE_CONCEPTO_INVENTARIOS")
            bode.Fill(ds, "BODEGA")
            kard.Fill(ds, "KARDEX")
            secu.Fill(ds, "SECUENCIAL_ITEM")
            deta.Fill(ds, "DETALLE_KARDEX")
            unid.Fill(ds, "UNIDAD_MEDIDA")
            pers.Fill(ds, "PERSONAL")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            cent.Fill(ds, "CENTRO_COSTO")
            empr.Fill(ds, "EMPRESA_GENERAL")
            pard.Fill(ds, "PRAMETROS_DOCUMENTOS")
            Return ds
        End Function

        Public Function SeleccionarComprobanteEgresoxIdComprobanteIngresoMin(ByVal tipoCon As TipoConexion, ByVal idComprobante As String) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            Dim comp = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarComprobanteIngresoBodegaxNroComprobante", True, pars)
            Dim detc = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "seleccionarDetallesComprobantesIngreso2", True, pars)
            Dim ds = New DataSet()
            comp.Fill(ds, "ComprobanteIngreso")
            detc.Fill(ds, "DetalleComprobanteIngreso")

            Return ds
        End Function



        Public Function SeleccionarComprobanteIngresoBodegaxNroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteIngresoBodegaxNroComprobante", True, pars) 
        End Function

        Public Function SeleccionarComprobanteIngresoBodegaxDealle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteIngresoBodegaxDetalle", True, pars) 
        End Function

        Public Function SeleccionarComprobanteIngresoBodegaxRengoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            pars.Add(New Object() {"@FILTRO", SqlDbType.VarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarComprobanteIngresoxRangoFechas", True, pars)

        End Function

        Public Function SeleccionarDetallesComprobantesIngreso(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesComprobantesIngreso2", True, pars) 
        End Function

        'Public Function SeleccionarComprobantesBodegaxRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
        '    pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobantesBodegaxRangoFechas", True, pars) 
        'End Function

        'Public Function SeleccionarComprobantesBodegaxNroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobantesBodegaxNroComprobante", True, pars) 
        'End Function

        'Public Function SeleccionarComprobantesBodegaxDealle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"DETALLE", SqlDbType.VarChar, parametroBusqueda})
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobantesBodegaxDealle", True, pars) 
        'End Function

        'Public Function SeleccionarDetallesComprobantesBodegaXIdComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal tipo As Int32) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"TIPO", SqlDbType.Int, tipo})
        '    pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesComprobantesBodegaXIdComprobante", True, pars) 
        'End Function

        'Public Function AnularRegistroDetalleComprobantePorId(ByVal idc As String) As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.Text
        '        .CommandText = "delete from COMPROBANTE_INGRESO_BODEGA where ID_COMPROBANTE = @idc"
        '        .Parameters.AddWithValue("@idc", SqlDbType.VarChar).Value = idc
        '    End With
        '    Return comando
        'End Function

        Public Function NuevoDetalleOrdenComprobanteIngresoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DETALLE_ORDEN_COMPROBANTE_COMPRA VALUES (@ID_ORDEN_COMPRA, @ID_COMPROBANTE_COMPRA, @ID_COMPROBANTE_INGRESO) "
                .Parameters.AddWithValue("@ID_ORDEN_COMPRA", SqlDbType.BigInt).Value = IdOrdenCompra
                .Parameters.AddWithValue("@ID_COMPROBANTE_COMPRA", SqlDbType.BigInt).Value = 0
                .Parameters.AddWithValue("@ID_COMPROBANTE_INGRESO", SqlDbType.BigInt).Value = Id
            End With
            Return comando
        End Function

        Public Function SeleccionarSerieByIdDetalleComprobanteIngresoBodega(ByVal tipoCon As TipoConexion, ByVal idComprobante As String, ByVal iddetcomp As String, ByVal idkar As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            pars.Add(New Object() {"ID_DET_COMP", SqlDbType.VarChar, iddetcomp})
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.VarChar, idkar})

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select OBSERVACION AS SERIE FROM detalle_comprobante_ingreso_bodega where id_comprobante=@ID_COMPROBANTE AND ID_DETALLE_COMPROBANTE = @ID_DET_COMP AND ID_KARDEX = @ID_KARDEX AND ESTADO_DETALLE = 1 ", False, pars)


        End Function

    End Class
End Namespace

