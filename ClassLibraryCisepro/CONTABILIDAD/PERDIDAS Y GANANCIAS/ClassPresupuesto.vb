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
        Public fecha As DateTime = DateTime.Now
        Public Estado As Boolean = True


        Public Function Guadar() As SqlCommand
            Dim comando = New SqlCommand()
            comando.CommandText = "sp_GuardarPresupuesto"
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Codigo", Codigo)
            comando.Parameters.AddWithValue("@Cuenta", Cuenta)
            comando.Parameters.AddWithValue("@Mes", Mes)
            comando.Parameters.AddWithValue("@Year", Year)
            comando.Parameters.AddWithValue("@Presupuesto", Presupuesto)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@Estado", Estado)
            Return comando

        End Function





    End Class
End Namespace
