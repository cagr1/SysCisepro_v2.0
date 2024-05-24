Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
    Public Class ClassEquiposAmbientacion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivoFijo As Integer
        Public Marca As String
        Public Modelo As String
        Public EstadoActivo As String
        Public Color As String
        Public Serie As String
        Public Material As String
        Public Amperaje As Integer
        Public Voltaje As Integer
        Public Tipo As String
        Public Anio As Integer
        Public Estado As Integer

        Public Function NuevoEquiposAmbientacion() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaEquipoAmbientacion"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@MARCA", SqlDbType.NVarChar).Value = Marca
                .Parameters.AddWithValue("@MODELO", SqlDbType.NVarChar).Value = Modelo
                .Parameters.AddWithValue("@ESTADO_ACTIVO", SqlDbType.NVarChar).Value = EstadoActivo
                .Parameters.AddWithValue("@COLOR", SqlDbType.NVarChar).Value = Color
                .Parameters.AddWithValue("@SERIE", SqlDbType.NVarChar).Value = Serie
                .Parameters.AddWithValue("@MATERIAL", SqlDbType.NVarChar).Value = Material
                .Parameters.AddWithValue("@AMPERAJE", SqlDbType.Int).Value = Amperaje
                .Parameters.AddWithValue("@VOLTAJE", SqlDbType.Int).Value = Voltaje
                .Parameters.AddWithValue("@TIPO", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@ANO", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function SeleccionarTodosLosRegistrosEquiposAmbientacion(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarTodosLosRegistrosEquiposAmbientacion", True)

            Dim ds = New DataSet()
            mant.Fill(ds, "EQUIPOS_AMBIENTACION")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarIngresosEquiposDeAmbientacion(ByVal tipoCon As TipoConexion) As DataSet
            Dim obje = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EQUIPOS_AMBIENTACION  WHERE  ESTADO=1", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EMPRESA_GENERAL WHERE  ESTADO_EMPRESA=1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False)
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False)
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False)
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False)
            Dim carg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", False)

            Dim ds = New DataSet()
            obje.Fill(ds, "CHALECOS")
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

