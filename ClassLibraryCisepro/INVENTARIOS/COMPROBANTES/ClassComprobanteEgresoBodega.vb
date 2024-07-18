Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.COMPROBANTES
    Public Class ClassComprobanteEgresoBodega
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As String
        Public Fecha As DateTime
        Public Nro As String
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
        Public IdPersonal As String
        Public IdEmpresa As Integer
        Public Cliente As String
        Public SitioTrabajo As String

        Public Function BuscarClienteByIdComprobanteEgresoBodega(ByVal tipoCon As TipoConexion, ByVal idComprobante As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select cliente from comprobante_egreso_bodega where id_comprobante=@ID_COMPROBANTE", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorIdComprobanteEgresoBodega(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdComprobanteEgresoBodega", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroComprobanteEgresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroComprobanteEgresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NRO_PARAMETRO", SqlDbType.NVarChar).Value = Nro
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
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.NVarChar).Value = IdPersonal
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@CLIENTE", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@SITIO", SqlDbType.NVarChar).Value = SitioTrabajo
            End With
            Return comando
        End Function

        Public Function ModificarComprobanteEgresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarComprobanteEgresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id
                .Parameters.AddWithValue("@FECHA_COMPROBANTE", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NRO_PARAMETRO", SqlDbType.NVarChar).Value = Nro
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
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.NVarChar).Value = IdPersonal
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@CLIENTE", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@SITIO", SqlDbType.NVarChar).Value = SitioTrabajo
            End With
            Return comando
        End Function
         
        Public Function SeleccionarComprobanteEgresoxIdComprobanteEgreso(ByVal tipoCon As TipoConexion, ByVal idComprobante As String) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            Dim comp = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarComprobanteEgresoxIdComprobanteEgreso", True, pars)
            Dim detc = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_EGRESO_BODEGA", False)
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
            comp.Fill(ds, "COMPROBANTE_EGRESO_BODEGA")
            detc.Fill(ds, "DETALLE_COMPROBANTE_EGRESO_BODEGA")
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

        Public Function SeleccionarGruposComprobantesEgresoBodegaxNroComprobante(ByVal tipoCon As TipoConexion, ByVal num As String, ByVal todos As Boolean) As DataTable
            If todos Then
                Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select comprobante from(select 'N°: ' + dc.id_comprobante + ' -  FEC: ' +  convert(varchar, ce.fecha_comprobante, 103) + ' - DET: ' + ce.razon comprobante from detalle_comprobante_egreso_bodega dc join comprobante_egreso_bodega ce on dc.id_comprobante = ce.id_comprobante join kardex ka on dc.id_kardex = ka.id_kardex join secuencial_item si on ka.id_secuencial_item=si.id_secuencial_item join detalle_kardex dk on dc.id_detalle_kardex=dk.id_detalle where ce.fecha_comprobante > '2019-12-01 00:00:00') as tab group by tab.comprobante order by tab.comprobante;", False)
            Else
                Dim pars = New List(Of Object())
                pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, num})
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select comprobante from (select 'N°: ' + dc.id_comprobante + ' -  FEC: ' +  convert(varchar, ce.fecha_comprobante, 103) + ' - DET: ' + ce.razon comprobante from detalle_comprobante_egreso_bodega dc join comprobante_egreso_bodega ce on dc.id_comprobante = ce.id_comprobante join kardex ka on dc.id_kardex = ka.id_kardex join secuencial_item si on ka.id_secuencial_item=si.id_secuencial_item join detalle_kardex dk on dc.id_detalle_kardex=dk.id_detalle where ce.fecha_comprobante > '2019-12-01 00:00:00' and ce.id_comprobante = @ID_COMPROBANTE) as tab group by tab.comprobante order by tab.comprobante;", False, pars)
            End If
        End Function

        Public Function SeleccionarDatosComprobantesEgresoBodegaxNroComprobante(ByVal tipoCon As TipoConexion, ByVal num As String, ByVal todos As Boolean) As DataTable
            If todos Then
                Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select 'N°: ' + dc.id_comprobante + ' -  FEC: ' +  convert(varchar, ce.fecha_comprobante, 103) + ' - DET: ' + ce.razon comprobante,  dc.id_comprobante, si.id_secuencial_item, si.descripcion, dk.cantidad_egreso, dk.valor_unitario_egreso, dk.valor_total_egreso from detalle_comprobante_egreso_bodega dc join comprobante_egreso_bodega ce on dc.id_comprobante = ce.id_comprobante join kardex ka on dc.id_kardex = ka.id_kardex join secuencial_item si on ka.id_secuencial_item=si.id_secuencial_item join detalle_kardex dk on dc.id_detalle_kardex=dk.id_detalle where ce.fecha_comprobante > '2019-12-01 00:00:00' order by ce.fecha_comprobante;", False)
            Else
                Dim pars = New List(Of Object())
                pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, num})
                Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select 'N°: ' + dc.id_comprobante + ' -  FEC: ' +  convert(varchar, ce.fecha_comprobante, 103) + ' - DET: ' + ce.razon comprobante,  dc.id_comprobante, si.id_secuencial_item, si.descripcion, dk.cantidad_egreso, dk.valor_unitario_egreso, dk.valor_total_egreso from detalle_comprobante_egreso_bodega dc join comprobante_egreso_bodega ce on dc.id_comprobante = ce.id_comprobante join kardex ka on dc.id_kardex = ka.id_kardex join secuencial_item si on ka.id_secuencial_item=si.id_secuencial_item join detalle_kardex dk on dc.id_detalle_kardex=dk.id_detalle WHERE ce.fecha_comprobante > '2019-12-01 00:00:00' and ce.id_comprobante = @ID_COMPROBANTE  order by ce.fecha_comprobante;", False, pars)
            End If
        End Function

        Public Function SeleccionarComprobanteEgresoBodegaxNroComprobante(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteEgresoBodegaxNroComprobante", True, pars) 
        End Function

        Public Function SeleccionarComprobanteEgresoBodegaxDetalle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobanteEgresoBodegaxDetalle", True, pars) 
        End Function

        Public Function SeleccionarComprobanteEgresoBodegaxRengoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarComprobanteEgresoxRangoFechas", True, pars)
        End Function

        Public Function SeleccionarComprobanteEgresoBodegaxRengoFechasReingreso(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal filtro As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            pars.Add(New Object() {"FILTRO", SqlDbType.VarChar, filtro})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarComprobanteEgresoxRangoFechasReingreso", True, pars)
        End Function

        Public Function SeleccionarDetallesComprobantesEgreso(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesComprobantesEgreso2", True, pars) 
        End Function


        Public Function SeleccionarSerieByIdDetalleComprobanteEgresoBodega(ByVal tipoCon As TipoConexion, ByVal idComprobante As String, ByVal iddetcomp As String, ByVal idkar As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, idComprobante})
            pars.Add(New Object() {"ID_DET_COMP", SqlDbType.VarChar, iddetcomp})
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.VarChar, idkar})

            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select OBSERVACION AS SERIE FROM detalle_comprobante_egreso_bodega where id_comprobante=@ID_COMPROBANTE AND ID_DETALLE_COMPROBANTE = @ID_DET_COMP AND ID_KARDEX = @ID_KARDEX AND ESTADO_DETALLE = 1 ", False, pars)


        End Function

        Public Function AnularRegistroComprobanteEgresoBodegaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_anularComprobanteEgresoBodega"
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.NVarChar).Value = Id

            End With
            Return comando
        End Function




        'Public Function AnularRegistroDetalleComprobantePorId(ByVal idc As String) As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.Text
        '        .CommandText = "delete from COMPROBANTE_EGRESO_BODEGA where ID_COMPROBANTE = @idc"
        '        .Parameters.AddWithValue("@idc", SqlDbType.VarChar).Value = idc
        '    End With
        '    Return comando
        'End Function

    End Class
End Namespace
