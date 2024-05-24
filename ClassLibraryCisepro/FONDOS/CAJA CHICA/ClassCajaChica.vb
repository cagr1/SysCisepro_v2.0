Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassCajaChica
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Detalle As String
        Public Monto As Decimal
        Public Valor As Decimal
        Public CuentaContable As String
        Public TipoCuenta As Integer
        Public Nivel As Integer
        Public Estado As Integer
        Public IdCentroCosto As Integer
        Public IdProvincia As Integer
        Public IdCiudad As Integer
        Public IdParroquia As Integer
        Public IdPersonal As Integer 
         
        Public Function SeleccionarCajasChicas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from CAJA_CHICA where ESTADO_CAJA_CHICA= 1 order by detalle_caja_chica;", False) 
        End Function

        Public Function BuscarMayorIdCajaChica(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCajaChica", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaCajaChica() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaCajaChica"
                .Parameters.AddWithValue("@ID_CAJA_CHICA", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@DETALLE_CAJA_CHICA", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@MONTO_CAJA_CHICA", SqlDbType.Decimal).Value = Monto
                .Parameters.AddWithValue("@VALOR_GASTO", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@CTA_CONTABLE", SqlDbType.NVarChar).Value = CuentaContable
                .Parameters.AddWithValue("@TIPO_CTA", SqlDbType.Int).Value = TipoCuenta
                .Parameters.AddWithValue("@NIVEL_CTA", SqlDbType.Int).Value = Nivel
                .Parameters.AddWithValue("@ESTADO_CAJA_CHICA", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquia
                .Parameters.AddWithValue("@ID_PERSONAL ", SqlDbType.Int).Value = IdPersonal
            End With
            Return comando
        End Function
         
        Public Function ModificarCajaChica() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update CAJA_CHICA set DETALLE_CAJA_CHICA=@DETALLE_CAJA_CHICA, MONTO_CAJA_CHICA=@MONTO_CAJA_CHICA, VALOR_GASTO=@VALOR_GASTO, ID_CENTRO_COSTO=@ID_CENTRO_COSTO, " & _
                        "ID_PROVINCIAS=@ID_PROVINCIAS, ID_CIUDAD=@ID_CIUDAD, ID_PARROQUIAS=@ID_PARROQUIAS, ID_PERSONAL=@ID_PERSONAL where ID_CAJA_CHICA=@ID_CAJA_CHICA"
                .Parameters.AddWithValue("@ID_CAJA_CHICA", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@DETALLE_CAJA_CHICA", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@MONTO_CAJA_CHICA", SqlDbType.Decimal).Value = Monto
                .Parameters.AddWithValue("@VALOR_GASTO", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroCosto
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquia
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
            End With
            Return comando
        End Function
        
        Public Function SeleccionarCajasChicaParametros(ByVal tipoCon As TipoConexion) As DataSet
            Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CAJA_CHICA WHERE  ESTADO_CAJA_CHICA=1", False) 
            Dim cent = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CENTRO_COSTO WHERE ESTADO_CENTRO_COSTO=1", False) 
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS=1", False) 
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.CIUDADES WHERE ESTADO_CIUDADES=1", False) 
            Dim parq = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PARROQUIAS WHERE  ESTADO_PARROQUIAS=1", False) 
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False) 

            Dim ds = New DataSet()
            caja.Fill(ds, "CAJA_CHICA")
            cent.Fill(ds, "CENTRO_COSTO")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parq.Fill(ds, "PARROQUIAS")
            pers.Fill(ds, "PERSONAL")
            Return ds
        End Function

        Public Function BuscarIdCustodioCajaChicaXDetalleCajaChica(ByVal tipoCon As TipoConexion, ByVal detalleCajaChica As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"DETALLE_CAJA_CHICA", SqlDbType.NVarChar, detalleCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdCustodioCajaChicaXDetalleCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMontoAsignadoCajaChicaXidCajaChica(ByVal tipoCon As TipoConexion, ByVal detalleCajaChica As String) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.NVarChar, detalleCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarMontoAsignadoCajaChicaXidCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function BuscarValorAsignadoCajaChicaXidCajaChica(ByVal tipoCon As TipoConexion, ByVal idCajaChica As String) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.Int, idCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarValorAsignadoCajaChicaXidCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function BuscarCuentaContableXIdCajaChica(ByVal tipoCon As TipoConexion, ByVal idCajaChica As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.Int, idCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarCuentaContableXIdCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

    End Class
End Namespace

