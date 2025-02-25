Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassClienteGeneral
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCliente As Int64
        Public CodigoCliente As String
        Public TipoIdentificacionCliente As String
        Public RucCiCliente As String
        Public NombreRazonSocialCliente As String
        Public ApellidoNombreComercialCliente As String
        Public NroResContEspecialCliente As String
        Public ObligLlevarContCliente As String
        Public DireccionUbicacionCliente As String
        Public DireccionFacturacionCliente As String
        Public ConsorcioCliente As String
        Public IdCiudadCliente As Integer
        Public Telefono1Cliente As String
        Public Telefono2Cliente As String
        Public EmailCliente As String
        Public ContactoCliente As String
        Public FechaIngresoCliente As DateTime
        Public TipoCliente As String
        Public ObservacionesCliente As String
        Public EstadoCliente As Integer
        Public TipoEmpresa As String


        Public Function BuscarMayorIdClienteGeneral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarMayorIdClienteGeneral", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarClienteGeneralXNombreComercial(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarClienteGeneralXNombreComercial", True, pars)
        End Function

        Public Function BuscarClienteGeneralXRazonSocial(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarClienteGeneralXRazonSocial", True, pars)
        End Function

        Public Function BuscarIdClienteXNombreComercial(ByVal tipoCon As TipoConexion, ByVal cod As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL", SqlDbType.NVarChar, cod})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdClienteXNombreComercial", True, pars)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_CLIENTE_GENERAL")))
        End Function

        Public Function BuscarIdClienteXRazonSocial(ByVal tipoCon As TipoConexion, ByVal cod As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_RAZON_SOCIAL_CLIENTE_GENRAL", SqlDbType.NVarChar, cod})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarIdClienteXRazonSocial", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarRazonSocialClienteGeneralXRuc(ByVal tipoCon As TipoConexion, ByVal idActivoF As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RUC_CI_CLIENTE_GENERAL", SqlDbType.Int, idActivoF})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarRazonSocialClienteGeneralXRuc", True, pars)
            Return If(data.Rows.Count = 0, "0", CStr(data.Rows(0)("NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL")))
        End Function

        Public Function CargarClienteGeneralFacturasPorCobrar(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String, ByVal desde As String, ByVal hasta As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DESDE", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"HASTA", SqlDbType.DateTime, hasta})
            pars.Add(New Object() {"DETALLE", SqlDbType.NVarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "cargarClienteGeneralFacturasPorCobrar", True, pars)
        End Function

        Public Function CargarClienteGeneralSinFacturasPorRangoFecha(ByVal tipoCon As TipoConexion, ByVal desde As DateTime, ByVal hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@FECHA_INICIAL", SqlDbType.DateTime, desde})
            pars.Add(New Object() {"@FECHA_FINAL", SqlDbType.DateTime, hasta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_cargarClienteGeneralSinFacturasPorCobrarPorRangoFecha", True, pars)
        End Function

        Public Function BuscarFiltradoPorRazonSocialClienteVigilanciaFisica(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            ' and c.id_cliente_general in (select s.id_CLIENTE_GENERAL from sitios_trabajo s where s.id_sitio_trabajo in (select a.id_puesto from asignacion_personal a))
            'Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	C.*, (SELECT TOP 1 ID_CONTRATO FROM CONTRATO_CLIENTE WHERE ID_CLIENTE_GENERAL=C.ID_CLIENTE_GENERAL AND ESTADO =1 ORDER BY ANIO DESC) FROM CLIENTE_GENERAL C WHERE C.ESTADO_CLIENTE_GENERAL = 1 and c.id_cliente_general in (select s.id_CLIENTE_GENERAL from sitios_trabajo s where s.id_sitio_trabajo in (select a.id_puesto from asignacion_personal a)) and (C.RUC_CI_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%'));", False, pars)
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	C.*, (SELECT TOP 1 ID_CONTRATO FROM CONTRATO_CLIENTE WHERE ID_CLIENTE_GENERAL=C.ID_CLIENTE_GENERAL AND ESTADO =1 ORDER BY ANIO DESC) FROM CLIENTE_GENERAL C WHERE C.ESTADO_CLIENTE_GENERAL = 1 and (C.RUC_CI_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%'));", False, pars)
        End Function

        Public Function BuscarFiltradoPorConvenioClienteGeneral(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FIL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select cg.id_cliente_general ID, cb.id_convenio IDC, cg.ruc_ci_cliente_general CI_RUC_CLIENTE, cg.nompre_razon_social_cliente_general CLIENTE, cb.banco_convenio BANCO, cb.tipo_cuenta TIPO, cb.num_cuenta_tarj CUENTA_TARJETA, cb.num_ci_ruc CI_RUC_TITULAR, cb.titular_cuenta TITULAR_CUENTA, cb.valor VALOR from convenio_cliente_banco_debito cb join cliente_general cg on cb.id_cliente_general = cg.id_cliente_general where cb.estado = 1 AND (cg.nompre_razon_social_cliente_general  like ('%'+@FIL+'%') or cb.banco_convenio like ('%'+@FIL+'%') or cb.num_ci_ruc like ('%'+@FIL+'%') or cb.titular_cuenta like  ('%'+@FIL+'%'))", False, pars)
        End Function

        Public Function BuscarFiltradoPorRazonSocialClienteGeneral(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFiltradoPorRazonSocialClienteGeneral", True, pars)
        End Function

        Public Function BuscarRazonSocialClienteGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarRazonSocialClienteGeneral", True)
        End Function

        Public Function BuscarConsorcioClienteGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarConsorcioClienteGeneral", True)
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarRazonSocialClienteGeneral(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL")))
            Next
            Return coleccion
        End Function

        Public Function AutocompletarConsorcio(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarConsorcioClienteGeneral(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("CONSORCIO_CLIENTE_GENERAL")))
            Next
            Return coleccion
        End Function

        Public Function NuevoRegistroClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroClienteGeneral"
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@CODIGO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = CodigoCliente
                .Parameters.AddWithValue("@TIPO_IDENTIFICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoIdentificacionCliente
                .Parameters.AddWithValue("@RUC_CI_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = RucCiCliente
                .Parameters.AddWithValue("@NOMBRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NombreRazonSocialCliente
                .Parameters.AddWithValue("@APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ApellidoNombreComercialCliente
                .Parameters.AddWithValue("@NRO_RES_CONT_ESPECIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NroResContEspecialCliente
                .Parameters.AddWithValue("@OBLIG_LLEVAR_CONT_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObligLlevarContCliente
                .Parameters.AddWithValue("@DIRECCION_UBICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionUbicacionCliente
                .Parameters.AddWithValue("@DIRECCION_FACTURACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionFacturacionCliente
                .Parameters.AddWithValue("@CONSORCIO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ConsorcioCliente
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCliente
                .Parameters.AddWithValue("@TELEFONO_1_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono1Cliente
                .Parameters.AddWithValue("@TELEFONO_2_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono2Cliente
                .Parameters.AddWithValue("@EMAIL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = EmailCliente
                .Parameters.AddWithValue("@CONTACTO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ContactoCliente
                .Parameters.AddWithValue("@FECHA_INGRESO_CLIENTE_GENERAL", SqlDbType.DateTime).Value = FechaIngresoCliente
                .Parameters.AddWithValue("@TIPO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoCliente
                .Parameters.AddWithValue("@OBSERVACIONES_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObservacionesCliente
                .Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente
                .Parameters.AddWithValue("@TIPO_EMPRESA_CLIENTE", SqlDbType.NVarChar).Value = TipoEmpresa
            End With
            Return comando
        End Function

        Public Function ModificarRegistroClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroClienteGeneral"
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@CODIGO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = CodigoCliente
                .Parameters.AddWithValue("@TIPO_IDENTIFICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoIdentificacionCliente
                .Parameters.AddWithValue("@RUC_CI_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = RucCiCliente
                .Parameters.AddWithValue("@NOMBRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NombreRazonSocialCliente
                .Parameters.AddWithValue("@APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ApellidoNombreComercialCliente
                .Parameters.AddWithValue("@NRO_RES_CONT_ESPECIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NroResContEspecialCliente
                .Parameters.AddWithValue("@OBLIG_LLEVAR_CONT_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObligLlevarContCliente
                .Parameters.AddWithValue("@DIRECCION_UBICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionUbicacionCliente
                .Parameters.AddWithValue("@DIRECCION_FACTURACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionFacturacionCliente
                .Parameters.AddWithValue("@CONSORCIO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ConsorcioCliente
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCliente
                .Parameters.AddWithValue("@TELEFONO_1_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono1Cliente
                .Parameters.AddWithValue("@TELEFONO_2_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono2Cliente
                .Parameters.AddWithValue("@EMAIL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = EmailCliente
                .Parameters.AddWithValue("@CONTACTO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ContactoCliente
                .Parameters.AddWithValue("@FECHA_INGRESO_CLIENTE_GENERAL", SqlDbType.DateTime).Value = FechaIngresoCliente
                .Parameters.AddWithValue("@TIPO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoCliente
                .Parameters.AddWithValue("@OBSERVACIONES_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObservacionesCliente
                .Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente
                .Parameters.AddWithValue("@TIPO_EMPRESA_CLIENTE", SqlDbType.NVarChar).Value = TipoEmpresa
            End With
            Return comando
        End Function

        Public Function ActualizarEstadoClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarEstadoClienteGeneral"
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente
                .Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente
            End With
            Return comando
        End Function

    End Class
End Namespace

