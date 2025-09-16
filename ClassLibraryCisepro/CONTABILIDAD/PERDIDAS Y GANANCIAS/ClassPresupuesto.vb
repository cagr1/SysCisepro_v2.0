Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports System.Data.SqlClient


Namespace CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    Public Class ClassPresupuesto
        Public Codigo As String
        Public Cuenta As String
        Public Mes As Integer
        Public Year As Integer
        Public Presupuesto As Decimal
        Public fecha As DateTime
        Public Estado As Boolean = True


        Public Function Guardar() As SqlCommand
            Dim comando = New SqlCommand()
            comando.CommandText = "sp_nuevoPresupuesto"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Codigo", SqlDbType.NVarChar).Value = Codigo
            comando.Parameters.AddWithValue("@Cuenta", SqlDbType.NVarChar).Value = Cuenta
            comando.Parameters.AddWithValue("@Mes", SqlDbType.Int).Value = Mes
            comando.Parameters.AddWithValue("@Year", SqlDbType.Int).Value = Year
            comando.Parameters.AddWithValue("@Presupuesto", SqlDbType.Decimal).Value = Presupuesto
            comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha
            comando.Parameters.AddWithValue("@Estado", SqlDbType.Bit).Value = Estado
            Return comando

        End Function

        Public Function Update() As SqlCommand
            Dim comando = New SqlCommand()
            comando.CommandText = "sp_updatePresupuesto"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Codigo", SqlDbType.NVarChar).Value = Codigo
            comando.Parameters.AddWithValue("@Cuenta", SqlDbType.NVarChar).Value = Cuenta
            comando.Parameters.AddWithValue("@Mes", SqlDbType.Int).Value = Mes
            comando.Parameters.AddWithValue("@Year", SqlDbType.Int).Value = Year
            comando.Parameters.AddWithValue("@Presupuesto", SqlDbType.Decimal).Value = Presupuesto
            comando.Parameters.AddWithValue("@fecha", SqlDbType.DateTime).Value = fecha
            comando.Parameters.AddWithValue("@Estado", SqlDbType.Bit).Value = Estado
            Return comando
        End Function





    End Class
End Namespace
