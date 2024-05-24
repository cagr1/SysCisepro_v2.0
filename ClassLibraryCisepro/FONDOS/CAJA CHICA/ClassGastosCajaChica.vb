Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassGastosCajaChica
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdGastos As Integer
        Public NombreGastos As String
        Public CtaContable As String
        Public IdPlan As Integer
        Public Estado As Integer 
         
        Public Function SeleccionarTodosRegistrosGastosCajaChica(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosRegistrosGastosCajaChica", True) 
        End Function

        Public Function BuscarMayorIdGastosCajaChica(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdGastosCajaChica", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevaGastosCajaChica() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaGastosCajaChica"
                .Parameters.AddWithValue("@ID_GASTOS_CAJA_CH", SqlDbType.Int).Value = IdGastos
                .Parameters.AddWithValue("@NOMBRE_GASTO_CAJA_CH", SqlDbType.NVarChar).Value = NombreGastos
                .Parameters.AddWithValue("@CTA_CONTABLE_CAJA_CH", SqlDbType.NVarChar).Value = CtaContable
                .Parameters.AddWithValue("@ID_PLAN", SqlDbType.Int).Value = IdPlan
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
       
        Public Function SeleccionarCajasChicaConceptos(ByVal tipoCon As TipoConexion) As DataSet
            Dim caja = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.GASTOS_CAJA_CHICA  WHERE  ESTADO=1", False) 
            Dim plan = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM  dbo.PLAN_CUENTAS_GENERAL WHERE  ESTADO=1", False) 

            Dim ds = New DataSet()
            caja.Fill(ds, "GASTOS_CAJA_CHICA")
            plan.Fill(ds, "PLAN_CUENTAS_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarConceptosCajaChicaMachala2(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT *, cta_contable_gasto_caja_ch + ' - ' + nombre_gasto_caja_ch CUENTA  FROM  GASTOS_CAJA_CHICA  where estado = 1 order by NOMBRE_GASTO_CAJA_CH;", False)
        End Function

    End Class
End Namespace
