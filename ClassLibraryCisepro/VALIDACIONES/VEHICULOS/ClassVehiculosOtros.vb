Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace VALIDACIONES.VEHICULOS
    Public Class ClassVehiculosOtros
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public Nombre As String
        Public Responsable As String
        Public Tipo As String
        Public NombreCustodio As String
        Public Placas As String
        Public Chasis As String
        Public Marca As String
        Public Modelo As String
        Public Serie As String
        Public Motor As String
        Public Cilindraje As String
        Public Soat As DateTime
        Public Color As String
        Public Capacacidad As Integer
        Public Ubicacion As String
        Public TipoCustodio As String
        Public Estado As String

        Public Function BuscarMayorIdVehiculosOtros(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdVehiculosOtros", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarRegistrosVehiculosOtros(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosVehiculosOtros", True) 
        End Function

        Public Function NuevaVehiculosOtros() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaVehiculosOtros"
                .Parameters.AddWithValue("@ID_VEHICULOS", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@NOMBRE_VEHICULO", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@RESPONSABLE ", SqlDbType.NVarChar).Value = Responsable
                .Parameters.AddWithValue("@TIPO_VEHICULO ", SqlDbType.NVarChar).Value = Tipo
                .Parameters.AddWithValue("@NOMBRE_CUSTODIO ", SqlDbType.NVarChar).Value = NombreCustodio
                .Parameters.AddWithValue("@PLACAS ", SqlDbType.NVarChar).Value = Placas
                .Parameters.AddWithValue("@CHASIS ", SqlDbType.NVarChar).Value = Chasis
                .Parameters.AddWithValue("@MARCA ", SqlDbType.NVarChar).Value = Marca
                .Parameters.AddWithValue("@MODELO ", SqlDbType.NVarChar).Value = Modelo
                .Parameters.AddWithValue("@SERIE ", SqlDbType.NVarChar).Value = Serie
                .Parameters.AddWithValue("@MOTOR ", SqlDbType.NVarChar).Value = Motor
                .Parameters.AddWithValue("@CILINDRAJE ", SqlDbType.NVarChar).Value = Cilindraje
                .Parameters.AddWithValue("@SOAT ", SqlDbType.DateTime).Value = Soat
                .Parameters.AddWithValue("@COLOR ", SqlDbType.NVarChar).Value = Color
                .Parameters.AddWithValue("@CAPACIDAD ", SqlDbType.NVarChar).Value = Capacacidad
                .Parameters.AddWithValue("@UBICACION ", SqlDbType.NVarChar).Value = Ubicacion
                .Parameters.AddWithValue("@TIPO_CUSTODIO ", SqlDbType.NVarChar).Value = TipoCustodio
                .Parameters.AddWithValue("@ESTADO  ", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
         
    End Class
End Namespace

