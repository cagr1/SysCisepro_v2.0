Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassCalificacionProveedores
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCalificacionProveedor As Integer
        Public FechaCalificacionProveedor As DateTime
        Public RucCalificacionProveedor As String
        Public EspecificacionesCalificacionProveedor As Integer
        Public PresentacionProductoCalificacionProveedor As Integer
        Public FormaPagoCalificacionProveedor As Integer
        Public TiempoEntregaCalificacionProveedor As Integer
        Public CertificacionesCalificacionProveedor As Integer
        Public TotalCalificacionProveedor As Integer
        Public AprobadoCalificacionProveedor As String
        Public ObservacionesCalificacionProveedor As String
        Public EstadoCalificacionProveedor As Integer
        Public IdProveedor As Integer
        Public IdPersonal As Integer

        Public Function BuscarMayorIdCalificacionProveedor(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCalificacionProveedor", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroCalificaionProveedor(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroClificaionProveedor"
                .Parameters.AddWithValue("@ID_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = IdCalificacionProveedor
                .Parameters.AddWithValue("@FECHA_CALIFICACION_PROVEEDOR", SqlDbType.DateTime).Value = FechaCalificacionProveedor
                .Parameters.AddWithValue("@RUC_ACTUALIZADO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = RucCalificacionProveedor
                .Parameters.AddWithValue("@ESPECIFICACION_PRODUCTO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = EspecificacionesCalificacionProveedor
                .Parameters.AddWithValue("@PRESENTACION_PRODUCTO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = PresentacionProductoCalificacionProveedor
                .Parameters.AddWithValue("@FORMA_PAGO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = FormaPagoCalificacionProveedor
                .Parameters.AddWithValue("@TIEMPO_ENTREGA_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = TiempoEntregaCalificacionProveedor
                .Parameters.AddWithValue("@CERTIFICACIONES_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = CertificacionesCalificacionProveedor
                .Parameters.AddWithValue("@TOTAL_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = TotalCalificacionProveedor
                .Parameters.AddWithValue("@APROBADO_CALIFICACION_PROVEEDOR", SqlDbType.NVarChar).Value = AprobadoCalificacionProveedor
                .Parameters.AddWithValue("@OBSERVACIONES_CALIFICACION_PROVEEDOR", SqlDbType.NVarChar).Value = ObservacionesCalificacionProveedor
                .Parameters.AddWithValue("@ESTADO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = EstadoCalificacionProveedor
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        'Public Function NuevoRegistroCalificaionProveedor() As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "nuevoRegistroClificaionProveedor"
        '        .Parameters.AddWithValue("@ID_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = idCalificacionProveedor
        '        .Parameters.AddWithValue("@FECHA_CALIFICACION_PROVEEDOR", SqlDbType.DateTime).Value = fechaCalificacionProveedor
        '        .Parameters.AddWithValue("@RUC_ACTUALIZADO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = rucCalificacionProveedor
        '        .Parameters.AddWithValue("@ESPECIFICACION_PRODUCTO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = especificacionesCalificacionProveedor
        '        .Parameters.AddWithValue("@PRESENTACION_PRODUCTO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = presentacionProductoCalificacionProveedor
        '        .Parameters.AddWithValue("@FORMA_PAGO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = formaPagoCalificacionProveedor
        '        .Parameters.AddWithValue("@TIEMPO_ENTREGA_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = tiempoEntregaCalificacionProveedor
        '        .Parameters.AddWithValue("@CERTIFICACIONES_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = certificacionesCalificacionProveedor
        '        .Parameters.AddWithValue("@TOTAL_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = totalCalificacionProveedor
        '        .Parameters.AddWithValue("@APROBADO_CALIFICACION_PROVEEDOR", SqlDbType.NVarChar).Value = aprobadoCalificacionProveedor
        '        .Parameters.AddWithValue("@OBSERVACIONES_CALIFICACION_PROVEEDOR", SqlDbType.NVarChar).Value = observacionesCalificacionProveedor
        '        .Parameters.AddWithValue("@ESTADO_CALIFICACION_PROVEEDOR", SqlDbType.Int).Value = estadoCalificacionProveedor
        '        .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = idProveedor
        '        .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = idPersonal
        '    End With
        '    Return comando
        'End Function

    End Class
End Namespace

