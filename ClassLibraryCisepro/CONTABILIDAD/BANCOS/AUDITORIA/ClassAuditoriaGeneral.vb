Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS.AUDITORIA
    Public Class ClassAuditoriaGeneral
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdAuditoria As Int64
        Public IdUsuarioAuditoria As Integer
        Public FormularioAuditoria As String
        Public AccionAuditoria As String
        Public FechaAuditoria As DateTime
        Public EstadoAuditoria As Integer

        Public Function FechaExactaAuditoria(ByVal tipoCon As TipoConexion) As DateTime
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select getDATE() FECHA", False)
            Return If(data.Rows.Count = 0, CDate("1990-01-01 00:00:00"), CDate(data.Rows(0)("FECHA")))
        End Function

        Public Function BuscarMayorIdAuditoriaGeneral(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdAuditoriaGeneral", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaAuditoria() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaAuditoria"
                .Parameters.AddWithValue("@ID_AUDITORIA_GENERAL", SqlDbType.BigInt).Value = IdAuditoria
                .Parameters.AddWithValue("@ID_USUARIO", SqlDbType.Int).Value = IdUsuarioAuditoria
                .Parameters.AddWithValue("@FORMULARIO", SqlDbType.NVarChar).Value = FormularioAuditoria
                .Parameters.AddWithValue("@ACCION", SqlDbType.NVarChar).Value = AccionAuditoria
                .Parameters.AddWithValue("@FECHA_AUDITORIA_GENERAL", SqlDbType.DateTime).Value = FechaAuditoria
                .Parameters.AddWithValue("@ESTADO_AUDITORIA_GENERAL", SqlDbType.Int).Value = EstadoAuditoria
            End With
            Return comando
        End Function
        Public Function NuevaAuditoria(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaAuditoria"
                .Parameters.AddWithValue("@ID_AUDITORIA_GENERAL", SqlDbType.BigInt).Value = IdAuditoria
                .Parameters.AddWithValue("@ID_USUARIO", SqlDbType.Int).Value = IdUsuarioAuditoria
                .Parameters.AddWithValue("@FORMULARIO", SqlDbType.NVarChar).Value = FormularioAuditoria
                .Parameters.AddWithValue("@ACCION", SqlDbType.NVarChar).Value = AccionAuditoria
                .Parameters.AddWithValue("@FECHA_AUDITORIA_GENERAL", SqlDbType.DateTime).Value = FechaAuditoria
                .Parameters.AddWithValue("@ESTADO_AUDITORIA_GENERAL", SqlDbType.Int).Value = EstadoAuditoria
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarTodosAuditoria(ByVal tipoCon As TipoConexion) As DataSet
            Dim obje = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.AUDITORIA_GENERAL WHERE ESTADO_AUDITORIA_GENERAL=1", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM USUARIO_GENERAL WHERE ESTADO=1", False)

            Dim ds = New DataSet()
            obje.Fill(ds, "AUDITORIA_GENERAL")
            acti.Fill(ds, "USUARIO_GENERAL")
            Return ds
        End Function

        Public Function RegistrarNuevoAuditoriaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaAuditoria"
                .Parameters.AddWithValue("@ID_AUDITORIA_GENERAL", SqlDbType.BigInt).Value = IdAuditoria
                .Parameters.AddWithValue("@ID_USUARIO", SqlDbType.Int).Value = IdUsuarioAuditoria
                .Parameters.AddWithValue("@FORMULARIO", SqlDbType.NVarChar).Value = FormularioAuditoria
                .Parameters.AddWithValue("@ACCION", SqlDbType.NVarChar).Value = AccionAuditoria
                .Parameters.AddWithValue("@FECHA_AUDITORIA_GENERAL", SqlDbType.DateTime).Value = FechaAuditoria
                .Parameters.AddWithValue("@ESTADO_AUDITORIA_GENERAL", SqlDbType.Int).Value = EstadoAuditoria
            End With
            Return comando
        End Function

    End Class
End Namespace

