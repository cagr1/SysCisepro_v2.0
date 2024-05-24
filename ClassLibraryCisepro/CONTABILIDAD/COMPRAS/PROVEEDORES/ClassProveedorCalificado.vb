Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassProveedorCalificado
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdProveedorCalificado As Integer
        Public FechaInicioProveedorCalificado As DateTime
        Public FechaCeseProveedorCalificado As DateTime
        Public FechaActualizacionProveedorCalificado As DateTime
        Public NumeroCarpetaProveedorCalificado As Integer
        Public ActividadProveedorCalificado As String
        Public ImportadorProveedorCalificado As String
        Public PaginaWebProveedorCalificado As String
        Public ServiciosPrestadosProveedorCalificado As String
        Public FormaPagoProveedorCalificado As String
        Public CertificacionesProveedorCalificado As String
        Public ObservacionesProveedorCalificado As String
        Public EstadoProveedorCalificado As Integer
        Public IdproveedorGeneral As Integer

        Public Function BuscarMayorIdProveedorCalificado(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdProveedorCalificado", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroProveedorCalificado(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroProveedorCalificado"
                .Parameters.AddWithValue("@ID_PROVEEDOR_CALIFICADO", SqlDbType.Int).Value = IdProveedorCalificado
                .Parameters.AddWithValue("@FECHA_INICIO_PROVEEDOR_CALIFICADO", SqlDbType.DateTime).Value = FechaInicioProveedorCalificado
                .Parameters.AddWithValue("@FECHA_CESE_PROVEEDOR_CALIFICADO", SqlDbType.DateTime).Value = FechaCeseProveedorCalificado
                .Parameters.AddWithValue("@FECHA_ACTUALIZACION_PROVEEDOR_CALIFICADO", SqlDbType.DateTime).Value = FechaActualizacionProveedorCalificado
                .Parameters.AddWithValue("@NUMERO_CARPETA_PROVEEDOR_CALIFICADO", SqlDbType.Int).Value = NumeroCarpetaProveedorCalificado
                .Parameters.AddWithValue("@ACTIVIDAD_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = ActividadProveedorCalificado
                .Parameters.AddWithValue("@ES_IMPORTADOR_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = ImportadorProveedorCalificado
                .Parameters.AddWithValue("@PAGINA_WEB_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = PaginaWebProveedorCalificado
                .Parameters.AddWithValue("@SERVICIOS_PRESTADOS_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = ServiciosPrestadosProveedorCalificado
                .Parameters.AddWithValue("@FORMA_PAGO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = FormaPagoProveedorCalificado
                .Parameters.AddWithValue("@CERTIFICACIONES_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = CertificacionesProveedorCalificado
                .Parameters.AddWithValue("@OBSERVACIONES_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = ObservacionesProveedorCalificado
                .Parameters.AddWithValue("@ESTADO_PROVEEDOR_CALIFICADO", SqlDbType.Int).Value = EstadoProveedorCalificado
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdproveedorGeneral
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

