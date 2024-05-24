Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassSolicitudCajaChica
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSolitud As Int64
        Public Numero As Int64
        Public Fecha As DateTime
        Public Valor As Decimal
        Public Detalle As String
        Public CodDebe As String
        Public CodHaber As String
        Public Estado As Integer
        Public IdCajaChica As Integer
        Public IdResponsable As Integer
        Public IdCentroCosto As Integer
        Public IdGasto As Integer
        Public IdProvincia As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public NombresRecibe As String
        Public CedulaRecibe As String
        Public NombresEntrega As String
        Public CedulaEntrega As String
        Public IdParametroDocumento As Integer
        Public NroParametroDocumento As String
        Public IdPersonal As Integer
        Public IdLiquidacion As Integer 
        Public IdComprobanteCompra As Int64
         
        Public Function BuscarMayorIdSolicitudCajaChica(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSolicitudCajaChica", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNumeroSolicitudCajaChica(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNumeroSolicitudCajaChica", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarSolicitudesCajaChicaXIdCajaChica(ByVal tipoCon As TipoConexion, ByVal idCajaChica As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.Int, idCajaChica})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSolicitudesCajaChicaXIdCajaChica", True, pars) 
        End Function

        Public Function EliminarSolicitudesCajaChicaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "eliminarSolicitudesCajaChica"
                .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolitud
                .Parameters.AddWithValue("@ESTADO_SOLICITUD_CCH", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_LIQUIDACION", SqlDbType.Int).Value = IdLiquidacion
            End With
            Return comando
        End Function

        Public Function EliminarUnaSolicitudesCajaChicaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update solicitud_caja_chica set estado_solicitud_cch=0 where id_solictud_cch=@ID_SOLICITUD_CCH;"
                .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolitud 
            End With
            Return comando
        End Function


        Public Function AprobarSolicitudesCajaChicaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "aprobarSolicitudesCajaChica"
                .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolitud
                .Parameters.AddWithValue("@ESTADO_SOLICITUD_CCH", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function SeleccionarSolicitudesXIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLiquidacion As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_CCH", SqlDbType.Int, idLiquidacion})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarSolicitudesXIdLiquidacion", True, pars) 
        End Function

        Public Function SeleccionarSolicitudesCajaChicaXIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLiquidacion As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION", SqlDbType.Int, idLiquidacion})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarSolicitudesCajaChicaXIdLiquidacion", True, pars) 
        End Function

        Public Function NuevaSolicitudCajaChicaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSolicitudCajaChica"
                .Parameters.AddWithValue("@ID_SOLICTUD_CCH", SqlDbType.BigInt).Value = IdSolitud
                .Parameters.AddWithValue("@NUMERO_SOLICITUD_CCH", SqlDbType.BigInt).Value = Numero
                .Parameters.AddWithValue("@FECHA_SOLICITUD_CCH", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@VALOR_SOLICITUD_CCH", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@DETALLE_SOLICITUD_CCH", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@COD_DEBE_CCH", SqlDbType.NVarChar).Value = CodDebe
                .Parameters.AddWithValue("@COD_HABER_CCH", SqlDbType.NVarChar).Value = CodHaber
                .Parameters.AddWithValue("@ESTADO_SOLICITUD_CCH", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_CAJA_CHICA", SqlDbType.Int).Value = IdCajaChica
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = IdResponsable
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_GASTO_CAJA_CH", SqlDbType.Int).Value = IdGasto
                .Parameters.AddWithValue("@ID_PROVINCIA", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@NOMBRES_RECIBE", SqlDbType.NVarChar).Value = NombresRecibe
                .Parameters.AddWithValue("@CEDULA_RECIBE", SqlDbType.NVarChar).Value = CedulaRecibe
                .Parameters.AddWithValue("@NOMBRES_ENTREGA", SqlDbType.NVarChar).Value = NombresEntrega
                .Parameters.AddWithValue("@CEDULA_ENTREGA", SqlDbType.NVarChar).Value = CedulaEntrega
                .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = IdParametroDocumento
                .Parameters.AddWithValue("@NRO_PARAMETRO_DOCUMENTOS", SqlDbType.NVarChar).Value = NroParametroDocumento
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@ID_LIQUIDACION", SqlDbType.Int).Value = IdLiquidacion
                .Parameters.AddWithValue("@ID_COMPROBANTE", SqlDbType.BigInt).Value = IdComprobanteCompra
            End With
            Return comando
        End Function

    End Class
End Namespace

