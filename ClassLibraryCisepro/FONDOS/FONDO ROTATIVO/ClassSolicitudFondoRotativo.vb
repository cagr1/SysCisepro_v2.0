Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassSolicitudFondoRotativo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSolicitud As Int64
        Public NumeroSolicitud As Integer
        Public FechaSolicitud As Date
        Public ValorSolicitud As Decimal
        Public DetalleSolicitud As String
        Public NroDocumentoSolicitud As String
        Public CodDebeSolicitud As String
        Public CodHaberSolicitud As String
        Public EstadoSolicitud As Integer
        Public IdFondo As String
        Public IdResponsable As Integer
        Public IdCentro As Integer
        Public IdGasto As Integer
        Public IdPersonal As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdParametroDocumentos As Integer
        Public IdLiquidacion As Integer
        Public TipoDocumento As String
        Public IdDocumento As String
        Public NumeroDocumento As String

        Public Function SeleccionarRegistrosLiquidacionSolicitudfondoRotativo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosLiquidacionSolicitudfondoRotativo", True)
        End Function

        Public Function SeleccionarSolicitudFondoRotativoDeducibleXIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLiquidacionS As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_FR", SqlDbType.Int, idLiquidacionS})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSolicitudFondoRotativoXIdLiquidacion", True, pars)
        End Function

        Public Function SeleccionarSolicitudFondoRotativoNoDeducibleXIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLiquidacionS As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_FR", SqlDbType.Int, idLiquidacionS})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSolicitudFondoRotativoNoDeducibleXIdLiquidacion", True, pars)
        End Function

        Public Function SeleccionarTodosRegistrosSolicitudFondoRotativoParaReporte(ByVal tipoCon As TipoConexion) As DataSet
            Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SOLICITUD_FONDO_ROTATIVO WHERE ESTADO_SOLICITUD_FR=1", False)
            Dim gast = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.GASTOS_FONDO_ROTATIVO WHERE ESTADO_GASTOS_FR=1", False)
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS = 1", False)
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES WHERE ESTADO_CIUDADES=1", False)
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS WHERE ESTADO_PARROQUIAS=1", False)
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CENTRO_COSTO WHERE ESTADO_CENTRO_COSTO=1", False)
            Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RESPONSABLE_AUTORIZACION_FONDO_ROTATIVO WHERE ESTADO_RESPONSABLE_AUTO_FR=1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PERSONAL", False)

            Dim ds = New DataSet()
            caja.Fill(ds, "SOLICITUD_FONDO_ROTATIVO")
            gast.Fill(ds, "GASTOS_FONDO_ROTATIVO")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            cent.Fill(ds, "CENTRO_COSTO")
            resp.Fill(ds, "RESPONSABLE_AUTORIZACION_FONDO_ROTATIVO")
            pers.Fill(ds, "PERSONAL")
            Return ds
        End Function

        Public Function BuscarMayorIdSolicitudFondoRotativo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSolicitudFondoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNroSolicitudFondoRotativo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNroSolicitudFondoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroSolicitudForndoRotativoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroSolicitudFondoRotativo"
                .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitud
                .Parameters.AddWithValue("@NUMERO_SOLICITUD_FR", SqlDbType.BigInt).Value = NumeroSolicitud
                .Parameters.AddWithValue("@FECHA_SOLICITUD_FR", SqlDbType.DateTime).Value = FechaSolicitud
                .Parameters.AddWithValue("@VALOR_SOLICITUD_FR", SqlDbType.Decimal).Value = ValorSolicitud
                .Parameters.AddWithValue("@DETALLE_SOLICITUD_FR", SqlDbType.NVarChar).Value = DetalleSolicitud
                .Parameters.AddWithValue("@COD_DEBE", SqlDbType.NVarChar).Value = CodDebeSolicitud
                .Parameters.AddWithValue("@COD_HABER", SqlDbType.NVarChar).Value = CodHaberSolicitud
                .Parameters.AddWithValue("@ESTADO_SOLICITUD_FR", SqlDbType.Int).Value = EstadoSolicitud
                .Parameters.AddWithValue("@ID_FONDO_ROTATIVO", SqlDbType.Int).Value = IdFondo
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_FR", SqlDbType.Int).Value = IdResponsable
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentro
                .Parameters.AddWithValue("@ID_GASTOS_FR", SqlDbType.Int).Value = IdGasto
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = IdParametroDocumentos
                .Parameters.AddWithValue("@ID_LIQUIDACION_FR", SqlDbType.Int).Value = IdLiquidacion
                .Parameters.AddWithValue("@TIPO_DOCUMENTO", SqlDbType.NVarChar).Value = TipoDocumento
                .Parameters.AddWithValue("@ID_DOCUMENTO", SqlDbType.NVarChar).Value = IdDocumento
                .Parameters.AddWithValue("@NUMERO_DOCUMENTO", SqlDbType.NVarChar).Value = NumeroDocumento
            End With
            Return comando
        End Function

        Public Function ModificarLiquidacionSolicitudFondoRotativoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroLiquidacionSolicitudFondoRotativo"
                .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitud
                .Parameters.AddWithValue("@ESTADO_SOLICITUD_FR", SqlDbType.Int).Value = EstadoSolicitud
                .Parameters.AddWithValue("@ID_LIQUIDACION_FR", SqlDbType.Int).Value = IdLiquidacion
            End With
            Return comando
        End Function

        Public Function SeleccionarSolicitudesFrXIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLiquidacion As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_FR", SqlDbType.Int, idLiquidacion})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarSolicitudesFRXIdLiquidacion", True, pars)
        End Function


        Public Function EliminarUnaSolicitudesFondoRotativoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update SOLICITUD_FONDO_ROTATIVO set ESTADO_SOLICITUD_FR=0 where ID_SOLICITUD_FR=@ID_SOLICITUD_FR;"
                .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitud
            End With
            Return comando
        End Function
    End Class
End Namespace