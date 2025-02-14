Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    Public Class ClassPerdidasYGanancia

        Public Function SeleccionarEstadoPerdidasGananciasComprasXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal all As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Dim tabla = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarEstadoPerdidasGananciasComprasXRangoFechas", True, pars) 
            If Not all Then
                For Each row As DataRow In tabla.Rows
                    If row.Item("NIVEL") > 4 And row.Item("SALDO") = 0 Then
                        row.Delete()
                    End If
                Next row
            End If
            Return tabla
        End Function

        Public Function SeleccionarEstadoPerdidasGananciasVentasXRangoFechas(ByVal tipoCon As TipoConexion, ByVal parametroFechaInicial As DateTime, ByVal parametroFechaFinal As DateTime, ByVal all As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, parametroFechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, parametroFechaFinal})
            Dim tabla = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarEstadoPerdidasGananciasVentasXRangoFechas", True, pars) 
            If Not all Then
                For Each row As DataRow In tabla.Rows
                    If row.Item("NIVEL") > 4 And row.Item("SALDO") = 0 Then
                        row.Delete()
                    End If
                Next row
            End If
            Return tabla
        End Function

        Public Function SeleccionarEstadoPerdidasGananciasVentasXRangoFechasMensual(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEstadoPerdidasGananciasVentasXRangoFechasMensual", True) 
        End Function

        Public Function SeleccionarEstadoPerdidasGananciasComprasXRangoFechasMensual(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarEstadoPerdidasGananciasComprasXRangoFechasMensual", True) 
        End Function

        Public Function SeleccionarFechaActual(ByVal tipoCon As TipoConexion) As String
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select getdate() as now", False) 
            Return If(data.Rows.Count = 0, String.Empty, CStr(data.Rows(0)("now")).Substring(0, 19))
        End Function

        Public Function SeleccionarEstadoPerdidasGananciasComparativaPorMesesIngresos(ByVal tipoCon As TipoConexion, ByVal inicio As Date, ByVal fin As Date) As DataTable

            Dim year = inicio.Year

            Dim base = "select pc.codigo,pc.padre_cuenta padre, pc.nivel, pc.detalle "
            Dim fm As Date
            If (fin.Month - inicio.Month) >= 0 Then
                For i As Integer = inicio.Month To fin.Month Step 1
                    fm = Convert.ToDateTime(year & "-" & i & "-1").AddMonths(1).AddDays(-1)
                    base = base + ", coalesce((sum(CASE WHEN ld.FECHA_ASIENTO between '" & (year & "-" & i & "-1") & " 00:00:00' and '" & (year & "-" & fm.Month & "-" & fm.Day) & " 23:59:59' THEN ld.VALOR_DEBE_ASIENTO END) - sum(CASE WHEN ld.FECHA_ASIENTO between '" & (year & "-" & i & "-1") & " 00:00:00' and '" & (year & "-" & fm.Month & "-" & fm.Day) & " 23:59:59' THEN ld.VALOR_HABER_ASIENTO END)),0) " & Mes(i)
                Next
            End If
            base = base + ", 0.0 TOTAL from plan_cuentas_general pc left join asientos_libro_diario ld on pc.codigo = ld.codigo_cuenta_asiento where pc.estado = 1 and pc.codigo like '4%' and ld.ESTADO_ASIENTO>0 " & _
"and ld.FECHA_ASIENTO between '" & (year & "-" & inicio.Month & "-1") & " 00:00:00' and '" & (year & "-" & fin.Month & "-" & fin.Day) & " 23:59:59' " & _
"group by pc.codigo, pc.padre_cuenta, pc.nivel, pc.detalle  order by pc.codigo;"


            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, base, False) 
        End Function

        Public Function SeleccionarEstadoPerdidasGananciasComparativaPorMesesEgresos(ByVal tipoCon As TipoConexion, ByVal inicio As Date, ByVal fin As Date) As DataTable

            Dim year = inicio.Year

            Dim base = "select pc.codigo,pc.padre_cuenta padre, pc.nivel, pc.detalle "
            Dim fm As Date
            If (fin.Month - inicio.Month) >= 0 Then
                For i As Integer = inicio.Month To fin.Month Step 1
                    fm = Convert.ToDateTime(year & "-" & i & "-1").AddMonths(1).AddDays(-1)
                    base = base + ", coalesce((sum(CASE WHEN ld.FECHA_ASIENTO between '" & (year & "-" & i & "-1") & " 00:00:00' and '" & (year & "-" & fm.Month & "-" & fm.Day) & " 23:59:59' THEN ld.VALOR_DEBE_ASIENTO END) - sum(CASE WHEN ld.FECHA_ASIENTO between '" & (year & "-" & i & "-1") & " 00:00:00' and '" & (year & "-" & fm.Month & "-" & fm.Day) & " 23:59:59' THEN ld.VALOR_HABER_ASIENTO END)),0) " & Mes(i)
                Next
            End If
            base = base + ", 0.0 TOTAL from plan_cuentas_general pc left join asientos_libro_diario ld on pc.codigo = ld.codigo_cuenta_asiento where  pc.estado = 1 and pc.codigo like '5%' and ld.ESTADO_ASIENTO>0 " & _
"and ld.FECHA_ASIENTO between '" & (year & "-" & inicio.Month & "-1") & " 00:00:00' and '" & (year & "-" & fin.Month & "-" & fin.Day) & " 23:59:59' " & _
"group by pc.codigo, pc.padre_cuenta, pc.nivel, pc.detalle  order by pc.codigo;"

            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, base, False) 
        End Function

        Private Function Mes(ByVal m As Integer) As String
            Dim ms = ""
            Select Case m
                Case 1 : ms = "ENERO"
                Case 2 : ms = "FEBRERO"
                Case 3 : ms = "MARZO"
                Case 4 : ms = "ABRIL"
                Case 5 : ms = "MAYO"
                Case 6 : ms = "JUNIO"
                Case 7 : ms = "JULIO"
                Case 8 : ms = "AGOSTO"
                Case 9 : ms = "SEPTIEMBRE"
                Case 10 : ms = "OCTUBRE"
                Case 11 : ms = "NOVIEMBRE"
                Case 12 : ms = "DICIEMBRE"
            End Select
            Return ms
        End Function


        Public Function SeleccionarEstadoPerdidasGananciasComparativoDinamico(ByVal tipoCon As TipoConexion, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime, ByVal RangoBusqueda As String, ByVal OrdenColumns As String, ByVal chkAnterior As Boolean, ByVal chkPrevio As Boolean, cambio As Boolean, variacion As Boolean) As DataTable
            Dim pars = New List(Of Object())

            Dim chkAnteriorInt As Integer = If(chkAnterior, 1, 0)
            Dim chkPrevioInt As Integer = If(chkPrevio, 1, 0)
            Dim cambioInt As Integer = If(cambio, 1, 0)
            Dim variacionInt As Integer = If(variacion, 1, 0)

            pars.Add(New Object() {"@FechaInicio", SqlDbType.DateTime, FechaInicial})
            pars.Add(New Object() {"@FechaFin", SqlDbType.DateTime, FechaFinal})
            pars.Add(New Object() {"@RangoBusqueda", SqlDbType.VarChar, RangoBusqueda})
            pars.Add(New Object() {"@OrdenColumns", SqlDbType.VarChar, OrdenColumns})
            pars.Add(New Object() {"@chkAnterior", SqlDbType.Bit, chkAnteriorInt})
            pars.Add(New Object() {"@chkPrevio", SqlDbType.Bit, chkPrevioInt})
            pars.Add(New Object() {"@chkCambio", SqlDbType.Bit, cambioInt})
            pars.Add(New Object() {"@chkVariacion", SqlDbType.Bit, variacionInt})


            Dim tabla = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarEstadoPyGComparativo", True, pars)

            Return tabla
        End Function


    End Class
End Namespace