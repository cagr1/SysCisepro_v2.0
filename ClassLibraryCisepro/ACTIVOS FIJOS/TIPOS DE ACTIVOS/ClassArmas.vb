Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
    Public Class ClassArmas
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivoFijo As Integer
        Public NumeroPermisoGobierno As String
        Public NumeroPermisoComando As String
        Public NumeroTenencia As String
        Public FechaAceptacionTenencia As DateTime
        Public FechaCaducidadTenencia As DateTime
        Public NumeroMatricula As String
        Public FechaAceptacionMatricula As DateTime
        Public FechaCaducidadMatricula As DateTime
        Public Serie As String
        Public Estado As Integer
        Public Origen As String

        Public Function NuevoArmas() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoArmas"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@NUM_PERMISO_GOBIERNO", SqlDbType.NVarChar).Value = NumeroPermisoGobierno
                .Parameters.AddWithValue("@NUM_PERMISO_COMANDO", SqlDbType.NVarChar).Value = NumeroPermisoComando
                .Parameters.AddWithValue("@NUM_TENENCIA_ARMAS", SqlDbType.NVarChar).Value = NumeroTenencia
                .Parameters.AddWithValue("@FEC_ACEPTACION_TENENCIA", SqlDbType.DateTime).Value = FechaAceptacionTenencia
                .Parameters.AddWithValue("@FEC_CADUCIDAD_TENENCIA", SqlDbType.DateTime).Value = FechaCaducidadTenencia
                .Parameters.AddWithValue("@NUM_MATRICULA_ARMA", SqlDbType.NVarChar).Value = NumeroMatricula
                .Parameters.AddWithValue("@FEC_ACEPTACION_MATRICULA", SqlDbType.DateTime).Value = FechaAceptacionMatricula
                .Parameters.AddWithValue("@FEC_CADUCIDAD_MATRICULA", SqlDbType.DateTime).Value = FechaCaducidadMatricula
                .Parameters.AddWithValue("@SERIE", SqlDbType.NVarChar).Value = Serie
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ORIGEN", SqlDbType.NVarChar).Value = Origen
            End With
            Return comando
        End Function
         
        Public Function SeleccionarTodosLosRegistrosArmas(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarTodosLosRegistrosArmas", True) 
            Dim ds = New DataSet()
            mant.Fill(ds, "ARMAS")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarIngresosArmas(ByVal tipoCon As TipoConexion) As DataSet
            Dim obje = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ARMAS WHERE  ESTADO=1", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False) 
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EMPRESA_GENERAL WHERE  ESTADO_EMPRESA=1", False) 
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False) 
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False) 
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False) 
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False) 
            Dim carg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", False) 

            Dim ds = New DataSet()
            obje.Fill(ds, "ARMAS")
            acti.Fill(ds, "ACTIVO_FIJO_GENERAL")
            empr.Fill(ds, "EMPRESA_GENERAL")
            pers.Fill(ds, "PERSONAL")
            sucu.Fill(ds, "SUCURSAL_GENERAL")
            gere.Fill(ds, "GERENCIAS_GENERAL")
            area.Fill(ds, "AREA_GENERAL")
            carg.Fill(ds, "CARGO_OCUPACIONAL")
            Return ds
        End Function

    End Class
End Namespace

