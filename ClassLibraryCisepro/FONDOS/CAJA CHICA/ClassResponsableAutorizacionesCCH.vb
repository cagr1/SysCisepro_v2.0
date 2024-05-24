Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassResponsableAutorizacionesCch
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdResponsable As Integer
        Public IdPersonal As Integer
        Public Nombres As String
        Public Cedula As String
        Public IdProvincia As Integer
        Public IdCiudad As Integer
        Public IdParroquia As Integer
        Public Estado As Integer 

        Public Function SeleccionarResponsablesAutorizacionCajaChica(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarResponsablesAutorizacionCajaChica", True) 
        End Function

        Public Function BuscarMayorIdResponsableAutorizacionCajaChica(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdResponsableAutorizacionCajaChica", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroResponsableAutorizacionFondoCaja() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroResponsableAutorizacionFondoCaja"
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = IdResponsable
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal
                .Parameters.AddWithValue("@NOMBRES_AUTO_CCH", SqlDbType.NVarChar).Value = Nombres
                .Parameters.AddWithValue("@CEDULA_AUTO_CCH", SqlDbType.NVarChar).Value = Cedula
                .Parameters.AddWithValue("@ID_PROVINCIA", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquia
                .Parameters.AddWithValue("@ESTADO_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
        
        Public Function ActivarResponsableAutorizacionFondoCaja(ByVal idResponsable As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "activarResponsableAutorizacionFondoCaja"
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = idResponsable
            End With
            Return comando
        End Function

        Public Function DesactivarResponsableAutorizacionFondoCaja(ByVal idResponsable As Integer) As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "desactivarResponsableAutorizacionFondoCaja"
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_CCH", SqlDbType.Int).Value = idResponsable
            End With
            Return comando
        End Function
        
        Public Function SeleccionarResponsablesAutorizaciones(ByVal tipoCon As TipoConexion) As DataSet
            Dim resp = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.RESPONSABLE_AUTORIZACION_FONDO_CAJA WHERE  ESTADO_RESPONSABLE_AUTO_CCH=1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE  ESTADO_PERSONAL=1", False) 
            Dim carg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE ESTADO=1", False) 
            Dim prov = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PROVINCIAS WHERE ESTADO_PROVINCIAS=1", False) 
            Dim ciud = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CIUDADES  WHERE ESTADO_CIUDADES=1", False) 
            Dim parr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.PARROQUIAS WHERE ESTADO_PARROQUIAS=1", False) 

            Dim ds = New DataSet()
            resp.Fill(ds, "RESPONSABLE_AUTORIZACION_FONDO_CAJA")
            pers.Fill(ds, "PERSONAL")
            carg.Fill(ds, "CARGO_OCUPACIONAL")
            prov.Fill(ds, "PROVINCIAS")
            ciud.Fill(ds, "CIUDADES")
            parr.Fill(ds, "PARROQUIAS")
            Return ds
        End Function

        Public Function SeleccionarAutorizacionxProvinciasCiudadesParroquias(ByVal tipoCon As TipoConexion, ByVal idProvincias As Integer, ByVal idCiudad As Integer, ByVal idParroquias As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_PROVINCIA", SqlDbType.Int, idProvincias})
            pars.Add(New Object() {"ID_CIUDAD", SqlDbType.Int, idCiudad})
            pars.Add(New Object() {"ID_PARROQUIAS", SqlDbType.Int, idParroquias})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarAutorizacionxProvinciasCiudadesParroquias", True, pars) 
        End Function

    End Class
End Namespace

