Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassProveedores
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdProveedorGeneral As Integer
        Public FechaProveedorGeneral As DateTime
        Public RucProveedorGeneral As String
        Public RazonSocialProveedorGeneral As String
        Public NombreComercialProveedorGeneral As String
        Public TipoProveedorGeneral As String
        Public ContabilidadProveedorGeneral As String
        Public ContribuyenteEspecialProveedorGeneral As String
        Public DireccionProveedorGeneral As String
        Public IdCiudadProveedorGeneral As Integer
        Public Telefono1ProveedorGeneral As String
        Public Telefono2ProveedorGeneral As String
        Public EmailProveedorGeneral As String
        Public EstadoProveedorGeneral As Integer
        Public DocumentoContriEspeProveedorGeneral As Integer

        Public TipoIdeProveedorGeneral As String
        Public TipoPersonaProveedorGeneral As String

        Public Function SeleccionarRegistrosProveedorGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosProveedorGeneral", True) 
        End Function

        Public Function SeleccionarRegistrosProveedorGeneralCalificado(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosProveedorGeneralCalificado", True) 
        End Function

        Public Function BuscarProveedorGeneralXId(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"IDP", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.*, d.TIPO_IDENTIFICACION, d.TIPO_PROVEEDOR_GENERAL from proveedor_general p join DETALLE_PROVEEDOR d on p.ID_PROVEEDOR_GENERAL = d.ID_PROVEEDOR_GENERAL where p.id_proveedor_general = @IDP", False, pars)
        End Function

        Public Function BuscarProveedorGeneralXNombre(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RAZON_SOCIAL_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarProveedorGeneralXNombre", True, pars) 
        End Function

        Public Function BuscarProveedorGeneralXRuc(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RUC_CI_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarProveedorGeneralXRuc", True, pars) 
        End Function


        Public Function BuscarProveedorGeneralCalificadoXNombre(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_COMERCIAL_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarProveedorGeneralCalificadoXNombre", True, pars) 
        End Function

        Public Function BuscarProveedorGeneralCalificadoXRuc(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RUC_CI_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarProveedorGeneralCalificadoXRuc", True, pars) 
        End Function

        Public Function AutocompletarConId(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombresProveedorGeneralConId(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("RAZON_SOCIAL_PROVEEDOR_GENERAL")))
            Next
            Return coleccion
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombresProveedorGeneral(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("RAZON_SOCIAL_PROVEEDOR_GENERAL")))
            Next
            Return coleccion
        End Function

        Public Function AutocompletarProveedorClientePersonal(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombresProveedorClientePersonalGeneral(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("Nombres")))
            Next
            Return coleccion
        End Function

        Public Function BuscarMayorIdProveedorGeneral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdProveedorGeneral", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroProveedorGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroProveedorGeneral"
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = idProveedorGeneral
                .Parameters.AddWithValue("@FECHA_PROVEEDOR_GENERAL", SqlDbType.DateTime).Value = fechaProveedorGeneral
                .Parameters.AddWithValue("@RUC_CI_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = rucProveedorGeneral
                .Parameters.AddWithValue("@RAZON_SOCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = razonSocialProveedorGeneral
                .Parameters.AddWithValue("@NOMBRE_COMERCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = nombreComercialProveedorGeneral
                .Parameters.AddWithValue("@TIPO_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = tipoProveedorGeneral
                .Parameters.AddWithValue("@CONTABILIDAD_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = contabilidadProveedorGeneral
                .Parameters.AddWithValue("@CONTRIBUYENTE_ESPECIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = contribuyenteEspecialProveedorGeneral
                .Parameters.AddWithValue("@DIRECCION_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = direccionProveedorGeneral
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = idCiudadProveedorGeneral
                .Parameters.AddWithValue("@TELEFONO_1_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = telefono1ProveedorGeneral
                .Parameters.AddWithValue("@TELEFONO_2_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = telefono2ProveedorGeneral
                .Parameters.AddWithValue("@EMAIL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = EmailProveedorGeneral
                .Parameters.AddWithValue("@ESTADO_PROVEEDOR_GENERAL", SqlDbType.Int).Value = EstadoProveedorGeneral
                .Parameters.AddWithValue("@DOCUMENTO_CONTRI_ESPE_PROVEEDOR_GENERAL", SqlDbType.Int).Value = DocumentoContriEspeProveedorGeneral
            End With
            Return comando
        End Function


        Public Function BorrarRegistroDetalleProveedorGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "delete from DETALLE_PROVEEDOR where ID_PROVEEDOR_GENERAL=@ID_PROVEEDOR_GENERAL;"
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
            End With
            Return comando
        End Function

        Public Function NuevoRegistroDetalleProveedorGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DETALLE_PROVEEDOR (ID_PROVEEDOR_GENERAL, TIPO_IDENTIFICACION, TIPO_PROVEEDOR_GENERAL) " & _
                    "values (@ID_PROVEEDOR_GENERAL, @TIPO_IDENTIFICACION, @TIPO_PROVEEDOR_GENERAL);"
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
                .Parameters.AddWithValue("@TIPO_IDENTIFICACION", SqlDbType.NVarChar).Value = TipoIdeProveedorGeneral
                .Parameters.AddWithValue("@TIPO_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = TipoPersonaProveedorGeneral
            End With
            Return comando
        End Function

        Public Function ModificarRegistroProveedorGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroProveedorGeneral"
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = idProveedorGeneral
                .Parameters.AddWithValue("@FECHA_PROVEEDOR_GENERAL", SqlDbType.DateTime).Value = fechaProveedorGeneral
                .Parameters.AddWithValue("@RUC_CI_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = rucProveedorGeneral
                .Parameters.AddWithValue("@RAZON_SOCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = razonSocialProveedorGeneral
                .Parameters.AddWithValue("@NOMBRE_COMERCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = nombreComercialProveedorGeneral
                .Parameters.AddWithValue("@TIPO_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = tipoProveedorGeneral
                .Parameters.AddWithValue("@CONTABILIDAD_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = contabilidadProveedorGeneral
                .Parameters.AddWithValue("@CONTRIBUYENTE_ESPECIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = contribuyenteEspecialProveedorGeneral
                .Parameters.AddWithValue("@DIRECCION_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = direccionProveedorGeneral
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = idCiudadProveedorGeneral
                .Parameters.AddWithValue("@TELEFONO_1_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = telefono1ProveedorGeneral
                .Parameters.AddWithValue("@TELEFONO_2_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = telefono2ProveedorGeneral
                .Parameters.AddWithValue("@EMAIL_PROVEEDOR_GENERAL", SqlDbType.NVarChar).Value = EmailProveedorGeneral
                .Parameters.AddWithValue("@ESTADO_PROVEEDOR_GENERAL", SqlDbType.Int).Value = EstadoProveedorGeneral
                .Parameters.AddWithValue("@DOCUMENTO_CONTRI_ESPE_PROVEEDOR_GENERAL", SqlDbType.Int).Value = DocumentoContriEspeProveedorGeneral
            End With
            Return comando
        End Function
 
        Public Function BuscarRazonSocialProveedorxRuc(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RUC_CI_PROVEEDOR_GENERAL", SqlDbType.Int, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarRazonSocialProveedorxRuc", True, pars) 
            Return If(data.Rows.Count = 0, "0", CStr(data.Rows(0)("RAZON_SOCIAL_PROVEEDOR_GENERAL")))
        End Function
 
        Public Function BuscarIdProveedorXNombreComercialProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_COMERCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdProveedorXNombreComercialProveedor", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdProveedorXRazonSocialProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RAZON_SOCIAL_PROVEEDOR_GENERAL", SqlDbType.NVarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdProveedorXRazonSocial", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarTipoProveedorXIdProveedor(ByVal tipoCon As TipoConexion, ByVal id As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"idp", SqlDbType.Int, id})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tipo_identificacion from detalle_proveedor where id_proveedor_general = @idp;", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreComercialProveedorXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreComercialProveedorXIdProveedor", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("NOMBRE_COMERCIAL_PROVEEDOR_GENERAL")))
        End Function

        Public Function BuscarSiContribuyenteEspecialXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select contribuyente_especial_proveedor_general from proveedor_general where ID_PROVEEDOR_GENERAL = @ID_PROVEEDOR_GENERAL;", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)(0)))
        End Function

        Public Function BuscarRucProveedorXIdProveedor(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarRucProveedorXIdProveedor", True, pars) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("RUC_CI_PROVEEDOR_GENERAL")))
        End Function

        Private Function BuscarNombresProveedorGeneralConId(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT RAZON_SOCIAL_PROVEEDOR_GENERAL + ' - ' + ltrim(rtrim(str(ID_PROVEEDOR_GENERAL))) RAZON_SOCIAL_PROVEEDOR_GENERAL FROM PROVEEDOR_GENERAL WHERE ESTADO_PROVEEDOR_GENERAL = 1", False)
        End Function

        Private Function BuscarNombresProveedorGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombresProveedorGeneral", True)
        End Function

        Private Function BuscarNombresProveedorClientePersonalGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarProveedorClientePersonalGeneral", True)
        End Function

        Public Function BuscarFiltradoPorRazonSocialProveedorGeneral(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"RAZON_SOCIAL_PROVEEDOR_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFiltradoPorRazonSocialProveedorGeneral", True, pars) 
        End Function
         
    End Class
End Namespace