Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
    Public Class ClassSoftware
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdActivoFijo As Integer
        Public Detalle As String
        Public Version As String
        Public Provedor As String
        Public Tipo As String
        Public Estado As Integer

        Public Function NuevaSoftware() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaSoftware"
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@DETALLE", SqlDbType.NVarChar).Value = Detalle
                .Parameters.AddWithValue("@VERSION", SqlDbType.NVarChar).Value = Version
                .Parameters.AddWithValue("@PROVEDOR", SqlDbType.NVarChar).Value = Provedor
                .Parameters.AddWithValue("@TIPO", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function SeleccionarTodosLosRegistrosSoftware(ByVal tipoCon As TipoConexion) As DataSet
            Dim mant = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SeleccionarTodosLosRegistrosSoftware", True)

            Dim ds = New DataSet()
            mant.Fill(ds, "SOFTWARE")
            mant.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarIngresosSoftware(ByVal tipoCon As TipoConexion) As DataSet
            Dim obje = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SOFTWARE  WHERE  ESTADO=1", False)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.EMPRESA_GENERAL WHERE  ESTADO_EMPRESA=1", False)
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PERSONAL WHERE ESTADO_PERSONAL=1", False)
            Dim sucu = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.SUCURSAL_GENERAL WHERE ESTADO_SUCURSAL=1", False)
            Dim gere = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.GERENCIAS_GENERAL WHERE ESTADO_GERENCIAS=1", False)
            Dim area = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.AREA_GENERAL WHERE ESTADO_AREA=1", False)
            Dim carg = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", False)

            Dim ds = New DataSet()
            obje.Fill(ds, "SOFTWARE")
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

