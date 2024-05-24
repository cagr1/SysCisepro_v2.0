Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassLiquidacionCajaChica
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Fecha As DateTime
        Public Total As Decimal
        Public Fondo As Decimal
        Public Gastos As Decimal
        Public Saldo As Decimal
        Public Reposicion As Decimal
        Public Estado As Integer
        Public IdProvincias As Integer
        Public IdCiudad As Integer
        Public IdParroquias As Integer
        Public IdCaja As Integer
        Public IdCentro As Integer 
        Public NroAsiento As Int64
          
        Public Function BuscarMayorIdLiquidacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdLiquidacion", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaLiquidacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaLiquidacion"
                .Parameters.AddWithValue("@ID_LIQUIDACION_CCH", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@FECHA_LIQUIDACION_CCH", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@TOTAL_LIQUIDACION_CCH", SqlDbType.Decimal).Value = Total
                .Parameters.AddWithValue("@FONDO_LIQUIDACION_CCH", SqlDbType.Decimal).Value = Fondo
                .Parameters.AddWithValue("@GASTOS_LIQUIDACION_CCH", SqlDbType.Decimal).Value = Gastos
                .Parameters.AddWithValue("@SALDO_LIQUIDACION_CCH", SqlDbType.Decimal).Value = Saldo
                .Parameters.AddWithValue("@REPOSICION_LIQUIDACION_CCH", SqlDbType.Decimal).Value = Reposicion
                .Parameters.AddWithValue("@ESTADO_LIQUIDACION_CCH", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincias
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquias
                .Parameters.AddWithValue("@ID_CAJA_CCH", SqlDbType.Int).Value = IdCaja
                .Parameters.AddWithValue("@ID_CENTRO_COSTO_CCH", SqlDbType.Int).Value = IdCentro
                .Parameters.AddWithValue("@NRO_ASIENTO", SqlDbType.BigInt).Value = NroAsiento
            End With
            Return comando
        End Function

        Public Function BuscarSolicitudesFondoCajaChicaPorIdLiquidacion(ByVal tipoCon As TipoConexion, ByVal idl As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIQUIDACION_CCH", SqlDbType.Int, idl})
            Dim liqi = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarLiquidacionFondoCajaChicaPorIdLiquidacion", True, pars) 
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM PROVINCIAS WHERE ESTADO_PROVINCIAS=1", False) 
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM CIUDADES WHERE ESTADO_CIUDADES=1", False) 
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM PARROQUIAS WHERE ESTADO_PARROQUIAS=1", False) 
            Dim soli = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SOLICITUD_CAJA_CHICA WHERE ESTADO_SOLICITUD_CCH>1", False) 
          
            Dim gast = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SELECT * FROM GASTOS_CAJA_CHICA WHERE ESTADO=1 AND ID_GASTOS_CAJA_CH IN (SELECT ID_GASTO_CAJA_CH FROM SOLICITUD_CAJA_CHICA WHERE ESTADO_SOLICITUD_CCH>1 and ID_LIQUIDACION=@ID_LIQUIDACION_CCH)", False, pars)
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM CENTRO_COSTO WHERE ESTADO_CENTRO_COSTO=1", False) 
            'Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM RESPONSABLE_AUTORIZACION_FONDO_CAJA WHERE ESTADO_RESPONSABLE_AUTO_CCH=1", False)
            Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM RESPONSABLE_AUTORIZACION_FONDO_CAJA", False)
            Dim parm = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM PRAMETROS_DOCUMENTOS WHERE ESTADO_PARAMETRO_DOCUMENTOS=1", False) 
            Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM CAJA_CHICA WHERE ESTADO_CAJA_CHICA=1", False) 
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM PERSONAL", False) 

            Dim ds = New DataSet()
            liqi.Fill(ds, "LIQUIDACION_CAJA_CHICA")
            soli.Fill(ds, "SOLICITUD_CAJA_CHICA")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            gast.Fill(ds, "GASTOS_CAJA_CHICA")
            cent.Fill(ds, "CENTRO_COSTO")
            resp.Fill(ds, "RESPONSABLE_AUTORIZACION_FONDO_CAJA")
            parm.Fill(ds, "PRAMETROS_DOCUMENTOS")
            caja.Fill(ds, "CAJA_CHICA")
            pers.Fill(ds, "PERSONAL")
            Return ds
        End Function

        Public Function SeleccionarLiquidacionesCajaChica(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM  dbo.LIQUIDACION_CAJA_CHICA WHERE ESTADO_LIQUIDACION_CCH=1", False) 
        End Function

        Public Function SeleccionarLiquidacionesCajaChicaTodasRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarLiquidacionesCajaChicaTodasRangoFecha", True, pars)
        End Function
         
        Public Function BuscarDetalleCajaChicaXIdCajaChica(ByVal tipoCon As TipoConexion, ByVal idCajaChica As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.Int, idCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarDetalleCajaChicaXIdCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function AprobarLiquidacionCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "aprobarLiquidación"
                .Parameters.AddWithValue("@ID_LIQUIDACION_CCH", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@ESTADO_LIQUIDACION_CCH", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@NRO_ASIENTO", SqlDbType.BigInt).Value = NroAsiento
            End With
            Return comando
        End Function
         
    End Class
End Namespace



