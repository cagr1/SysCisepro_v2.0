Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace TALENTO_HUMANO
    Public Class ClassDescuentosPersonal
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdRegistro As Int64
        Public IdPersonal As Int64
        Public Fecha As Date
        Public Procesado As Int64
        Public Mes As Int64
        Public Anio As Int64
        Public IdRol As Int64
        Public Observacion As String
        Public Tipo As Int64
        Public Valor As Double
        Public Tipot As String
        Public Idprog As Int64

        Public Function BuscarMayorIdRegistroDescuento(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_registro=CASE WHEN MAX(id_registro) IS NULL THEN 0 ELSE MAX(id_registro) End FROM DESCUENTOS_ROL;", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_registro")))
        End Function

        Public Function NuevoRegistroDescuentoCommands() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DESCUENTOS_ROL (id_registro, id_personal, fecha, estado, procesado, mes_rol, anio_rol, id_rol, tipo, observacion, valor, tipox, id_prog) " & _
                    "values (@id_registro, @id_personal, @fecha, @estado, @procesado, @mes_rol, @anio_rol, @id_rol, @tipo, @observacion, @valor, @tipox, @idprog);"
                .Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro
                .Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = Fecha
                .Parameters.AddWithValue("@estado", SqlDbType.Int).Value = 1
                .Parameters.AddWithValue("@procesado", SqlDbType.Int).Value = Procesado
                .Parameters.AddWithValue("@mes_rol", SqlDbType.Int).Value = Mes
                .Parameters.AddWithValue("@anio_rol", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = IdRol
                .Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo
                .Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = Observacion
                .Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@tipox", SqlDbType.VarChar).Value = Tipot
                .Parameters.AddWithValue("@idprog", SqlDbType.Int).Value = Idprog
            End With
            Return comando
        End Function

        Public Function AnularRegistroDescuentoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update DESCUENTOS_ROL set estado=0 where id_registro=@id_registro;"
                .Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro
            End With
            Return comando
        End Function

        Public Function AnularRegistroDescuentoComprobanteEgreso(ByVal idp As Integer, ByVal fecd As DateTime, ByVal fech As DateTime)
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_deleteRegistroDescuentoComprobanteEgreso"
                .Parameters.AddWithValue("@idp", SqlDbType.Int).Value = idp
                .Parameters.AddWithValue("@fecd", SqlDbType.Int).Value = fecd
                .Parameters.AddWithValue("@fech", SqlDbType.Int).Value = fech
            End With
            Return comando
        End Function



        Public Function AnularRegistroDescuentoFrCommand(ByVal idSolFon As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update DESCUENTOS_ROL set estado=0 where observacion like 'ANTICIPOS (EMERGENTE) A%CON MOTIVO%ID FR: " & idSolFon & "';"
            End With
            Return comando
        End Function

        'Public Function DeleteRegistroDescuentoxAsignacionCommand(ByVal idp As Integer, ByVal fecd As Date, ByVal fech As Date) As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando
        '        .CommandType = CommandType.Text
        '        .CommandText = "update set  REGISTRO_SANCIONES_PERSONAL where set estado=0 where "
        '    End With
        '    Return comando

        'End Function

        Public Function DeleteRegistroDescuentoXAsignacionPersonalCommand(ByVal idp As Integer, ByVal fecd As Date, ByVal fech As Date) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                '.CommandText = "DELETE DR FROM DESCUENTOS_ROL DR JOIN REGISTRO_SANCIONES_PERSONAL RSP ON DR.id_registro = RSP.id_descuento WHERE DR.fecha BETWEEN @fecd AND @fech AND RSP.id_sancion IN (1,2,3,13,14,28) AND RSP.id_prog = @idp"
                .CommandText = "sp_deleteRegsitroDescuentoXAsignacionPersonal"
                .Parameters.AddWithValue("@idp", SqlDbType.Int).Value = idp
                .Parameters.AddWithValue("@fecd", SqlDbType.Date).Value = fecd
                .Parameters.AddWithValue("@fech", SqlDbType.Date).Value = fech
            End With
            Return comando
        End Function


        Public Function SeleccionarRegistroMultasAgrupados(tipoCon As TipoConexion, filtro As String, desde As DateTime, hasta As DateTime) As DataTable
            Dim pars As New List(Of Object()) From {
        New Object() {"FILTRO", SqlDbType.VarChar, filtro},
        New Object() {"DESDE", SqlDbType.DateTime, desde},
        New Object() {"HASTA", SqlDbType.DateTime, hasta}
             }
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarRegistroDescuentoAgrupados", True, pars)
        End Function


    End Class
End Namespace

