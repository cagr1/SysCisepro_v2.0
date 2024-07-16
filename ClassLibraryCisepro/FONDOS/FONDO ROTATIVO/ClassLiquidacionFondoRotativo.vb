Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassLiquidacionFondoRotativo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdLiquidacion As Integer
        Public FechaLiquidacion As Date
        Public TotalLiquidacion As Decimal
        Public FondoLiquidacion As Decimal
        Public GastosLiquidacion As Decimal
        Public SaldoLiquidacion As Decimal
        Public ReposicionLiquidacion As Decimal
        Public EstadoLiquidacion As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdCentroCosto As Integer
        Public NroAsiento As Int64

        Public Function SeleccionarLiquidacionFondoRotativoXid(ByVal tipoCon As TipoConexion, ByVal idf As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_FR", SqlDbType.Int, idf})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM LIQUIDACION_FONDO_ROTATIVO WHERE id_liquidacion_fr = @ID_LIQUIDACION_FR;", False, pars)
        End Function

        Public Function SeleccionarLiquidacionFondoRotativo(ByVal tipoCon As TipoConexion, ByVal fin As String, ByVal fout As String) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM LIQUIDACION_FONDO_ROTATIVO WHERE ESTADO_LIQUIDACION_FR >=1 and fecha_liquidacion_fr between '" & fin & "' and '" & fout & "'", False)
        End Function

        Public Function SeleccionarLiquidacionFondoRotativoFormRevision(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarLiquidacionFondoRotativoFormRevision", True)
        End Function

        Public Function BuscarMayorIdLiquidacionFondoRotativo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdLiquidacionFondoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroLiquidacionForndoRotativoCommand(ByVal tipoCon As TipoConexion) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroLiquidacionFondoRotativo"
                .Parameters.AddWithValue("@ID_LIQUIDACION_FR", SqlDbType.Int).Value = IdLiquidacion
                .Parameters.AddWithValue("@FECHA_LIQUIDACION_FR", SqlDbType.DateTime).Value = FechaLiquidacion
                .Parameters.AddWithValue("@TOTAL_LIQUIDACION_FR", SqlDbType.Decimal).Value = TotalLiquidacion
                .Parameters.AddWithValue("@FONDO_LIQUIDACION_FR", SqlDbType.Decimal).Value = FondoLiquidacion
                .Parameters.AddWithValue("@GASTOS_LIQUIDACION_FR", SqlDbType.Decimal).Value = GastosLiquidacion
                .Parameters.AddWithValue("@SALDO_LIQUIDACION_FR", SqlDbType.Decimal).Value = SaldoLiquidacion
                .Parameters.AddWithValue("@REPOSICION_LIQUIDACION_FR", SqlDbType.Decimal).Value = ReposicionLiquidacion
                .Parameters.AddWithValue("@ESTADO_LIQUIDACION_FR", SqlDbType.Int).Value = EstadoLiquidacion
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@NRO_ASIENTO", SqlDbType.BigInt).Value = NroAsiento
            End With
            Return comando
        End Function

        Public Function ModificarEstadoLiquidacionFondoRotativoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarEstadoLiquidacionFondoRotativo"
                .Parameters.AddWithValue("@ID_LIQUIDACION_FR", SqlDbType.BigInt).Value = IdLiquidacion
                .Parameters.AddWithValue("@ESTADO_LIQUIDACION_FR", SqlDbType.Int).Value = EstadoLiquidacion
                .Parameters.AddWithValue("@NRO_ASIENTO", SqlDbType.BigInt).Value = NroAsiento
            End With
            Return comando
        End Function

        Public Function SeleccionarLiquidacionesFondoRotativoTodasRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarLiquidacionesFondoRotativoTodasRangoFecha", True, pars)
        End Function

        Public Function ReporteFondoRotativoPorIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idl As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION", SqlDbType.Int, idl})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select str(s.id_solicitud_fr) NRO, c.nombre_gastos_fr CONCEPTO, s.detalle_solicitud_fr DETALLE, p.apellidos + ' ' + p.nombres RECEPTOR, s.tipo_documento TIPDOC, s.id_documento NDOC, s.valor_solicitud_fr VALOR, s.NOMBRE_RAZON_SOCIAL_CLIENTE_GENERAL CLIENTE from solicitud_fondo_rotativo s  join gastos_fondo_rotativo c on c.id_gastos_fr=s.id_gastos_fr join personal p on s.id_personal = p.id_personal where s.id_liquidacion_fr = @ID_LIQUIDACION;", False, pars)
        End Function
    End Class
End Namespace
