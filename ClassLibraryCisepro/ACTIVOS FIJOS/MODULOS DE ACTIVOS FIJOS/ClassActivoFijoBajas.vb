Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
    Public Class ClassActivoFijoBajas
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public FechaBaja As DateTime
        Public IdCustodio As Integer
        Public IdActivo As Integer
        Public Autorizo As String
        Public Motivo As String
        Public Destinatario As String
        Public InformeTecnico As String
        Public NroMemorandum As Int64
        Public Estado As Integer
        Public TipoActivo As String
        Public EstadoActivo As String
         
        Public Function SeleccionarTodosLosRegistrosActivosFijosBajas(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosActivosFijosBajas", True) 
        End Function

        Public Function BuscarMayorIdBajas(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdBajas", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoActivoFijoBajas() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoActivoFijoBajas"
                .Parameters.AddWithValue("@ID_BAJA", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = FechaBaja
                .Parameters.AddWithValue("@ID_CUSTODIO", SqlDbType.Int).Value = IdCustodio
                .Parameters.AddWithValue("@ID_ACTIVO", SqlDbType.Int).Value = IdActivo
                .Parameters.AddWithValue("@AUTORIZO", SqlDbType.NVarChar).Value = Autorizo
                .Parameters.AddWithValue("@MOTIVO", SqlDbType.NVarChar).Value = Motivo
                .Parameters.AddWithValue("@DESTINATARIO", SqlDbType.NVarChar).Value = Destinatario
                .Parameters.AddWithValue("@INFORME_TECNICO", SqlDbType.NVarChar).Value = InformeTecnico
                .Parameters.AddWithValue("@NRO_MEMORANDUM", SqlDbType.BigInt).Value = NroMemorandum
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@TIPO_ACTIVO", SqlDbType.NVarChar).Value = TipoActivo
                .Parameters.AddWithValue("@ESTADO_ACTIVO", SqlDbType.NVarChar).Value = EstadoActivo

            End With
            Return comando
        End Function

        Public Function BuscarBajaPorIdBaja(ByVal tipoCon As TipoConexion, ByVal idbaja As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_BAJA", SqlDbType.Int, idbaja})

            Dim baja =   ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarBajaPorIdBaja", True, pars) 

            Dim acti =   ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=0", False) 

            Dim ds = New DataSet()
            baja.Fill(ds, "ACTIVO_FIJO_BAJAS")
            acti.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function
        
    End Class
End Namespace