Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.KARDEX
    Public Class ClassKardex
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public IdsecuencialItem As Int64
        Public Fecha As DateTime
        Public Cantidad As Integer
        Public Estado As Integer


        Public Function SeleccionarKardexCreadosBuscarDetalle(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"PARAMETRO", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarKardexCreadosBuscarDetalle", True, pars) 
        End Function

        Public Function SeleccionarComprobantesIngresoEgresoBodegaPorId(ByVal tipoCon As TipoConexion, ByVal tipo As Integer, ByVal parametroBusqueda As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"TIPO", SqlDbType.Int, tipo})
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.Int, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarComprobantesIngresoEgresoBodegaPorId", True, pars)
        End Function

        Public Function BuscarKardexPorIdSecuencialItem(ByVal tipoCon As TipoConexion, ByVal idSecuencial As Int64) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SECUENCIAL_ITEM", SqlDbType.Int, idSecuencial})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarKardexPorIdSecuencialItem", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarUltimoMoviminetoKardexXIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Int64, ByVal idDetalleKardex As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.BigInt, idKardex})
            pars.Add(New Object() {"ID_DETALLE", SqlDbType.BigInt, idDetalleKardex})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarUltimoMoviminetoKardexXIdKardex", True, pars) 
        End Function

        'Public Function SeleccionarKardexPorIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Int64) As DataSet
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"ID_KARDEX", SqlDbType.BigInt, idKardex})
        '    Dim kard = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarKardexPorIdKardex", True, pars)
        '    Dim deta = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_KARDEX WHERE dbo.DETALLE_KARDEX.ID_KARDEX=" & idKardex, False)
        '    Dim acin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVIDAD_INVENTARIOS", False)
        '    Dim coin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CONCEPTOS_INVENTARIOS", False)
        '    Dim dein = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_CONCEPTO_INVENTARIOS", False)
        '    Dim seit = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM", False)
        '    Dim bode = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.BODEGA", False)
        '    Dim coeg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.COMPROBANTE_EGRESO_BODEGA", False)
        '    Dim deco = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_EGRESO_BODEGA", False)
        '    Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS", False)
        '    Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL", False)
        '    Dim sitr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SITIOS_TRABAJO", False)
        '    Dim unme = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.UNIDAD_MEDIDA", False)

        '    Dim ds = New DataSet()
        '    kard.Fill(ds, "KARDEX")
        '    deta.Fill(ds, "DETALLE_KARDEX")
        '    acin.Fill(ds, "ACTIVIDAD_INVENTARIOS")
        '    coin.Fill(ds, "CONCEPTOS_INVENTARIOS")
        '    dein.Fill(ds, "DETALLE_CONCEPTO_INVENTARIOS")
        '    seit.Fill(ds, "SECUENCIAL_ITEM")
        '    bode.Fill(ds, "BODEGA")
        '    coeg.Fill(ds, "COMPROBANTE_EGRESO_BODEGA")
        '    parr.Fill(ds, "PARROQUIA")
        '    pers.Fill(ds, "PERSONAL")
        '    sitr.Fill(ds, "SITIOS_TRABAJO")
        '    unme.Fill(ds, "UNIDAD_MEDIDA")
        '    Return ds
        'End Function

        Public Function SeleccionarKardexPorIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.BigInt, idKardex})
            Dim kard = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarKardexPorIdKardexBodega", True, pars)
            Dim deta = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_KARDEX", False)
            Dim acin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVIDAD_INVENTARIOS", False)
            Dim coin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CONCEPTOS_INVENTARIOS", False)
            Dim dein = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_CONCEPTO_INVENTARIOS", False)
            Dim seit = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM", False)
            Dim bode = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.BODEGA", False)
            Dim coeg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.COMPROBANTE_EGRESO_BODEGA", False)
            Dim deco = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_COMPROBANTE_EGRESO_BODEGA", False)
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL", False)
            Dim sitr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SITIOS_TRABAJO", False)
            Dim unme = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.UNIDAD_MEDIDA", False)

            Dim ds = New DataSet()
            kard.Fill(ds, "KARDEX")
            deta.Fill(ds, "DETALLE_KARDEX")
            acin.Fill(ds, "ACTIVIDAD_INVENTARIOS")
            coin.Fill(ds, "CONCEPTOS_INVENTARIOS")
            dein.Fill(ds, "DETALLE_CONCEPTO_INVENTARIOS")
            seit.Fill(ds, "SECUENCIAL_ITEM")
            bode.Fill(ds, "BODEGA")
            coeg.Fill(ds, "COMPROBANTE_EGRESO_BODEGA")
            parr.Fill(ds, "PARROQUIA")
            pers.Fill(ds, "PERSONAL")
            sitr.Fill(ds, "SITIOS_TRABAJO")
            unme.Fill(ds, "UNIDAD_MEDIDA")
            Return ds
        End Function

        'Public Function SeleccionarKardexPorIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Int64) As DataSet
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"ID_KARDEX", SqlDbType.BigInt, idKardex})
        '    Dim kard = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarKardexPorIdKardex", True, pars)
        '    Dim deta = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_KARDEX", False)
        '    Dim acin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVIDAD_INVENTARIOS", False)
        '    Dim coin = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CONCEPTOS_INVENTARIOS", False)
        '    Dim dein = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_CONCEPTO_INVENTARIOS", False)
        '    Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL", False)
        '    Dim sitr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SITIO_TRABAJO", False)
        '    Dim seit = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM", False)
        '    Dim unme = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.UNIDAD_MEDIDA", False)

        '    Dim ds = New DataSet()
        '    kard.Fill(ds, "KARDEX")
        '    deta.Fill(ds, "DETALLE_KARDEX")
        '    acin.Fill(ds, "ACTIVIDAD_INVENTARIOS")
        '    coin.Fill(ds, "CONCEPTOS_INVENTARIOS")
        '    dein.Fill(ds, "DETALLE_CONCEPTO_INVENTARIOS")
        '    pers.Fill(ds, "PERSONAL")
        '    sitr.Fill(ds, "SITIO_TRABAJO")
        '    seit.Fill(ds, "SECUENCIAL_ITEM")
        '    unme.Fill(ds, "UNIDAD_MEDIDA")
        '    Return ds
        'End Function



        Public Function BuscarMayorIdKardex(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdKardex", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroKardexCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroKardex"
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = IdsecuencialItem
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@CANTIDAD", SqlDbType.Int).Value = Cantidad
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado

            End With
            Return comando
        End Function

        Public Function ModificarCantidadKardexCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarCantidadKardex"
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = IdsecuencialItem
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@CANTIDAD", SqlDbType.Int).Value = Cantidad
            End With
            Return comando
        End Function

        Public Function ModificarCantidadKardexMinCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE KARDEX SET CANTIDAD=@CANTIDAD WHERE ID_KARDEX=@ID_KARDEX;"
                .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CANTIDAD", SqlDbType.Int).Value = Cantidad
            End With
            Return comando
        End Function

    End Class
End Namespace