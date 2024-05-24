Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.RETENCIONES_EMITIDAS
    Public Class ClassPorcentajes

        Public Function BuscarCantidadPorcentajesRenta(ByVal tipoCon As TipoConexion, ByVal idConcep As Integer, ByVal idTipContrib As Integer, ByVal esCompra As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONCEPTO_PAGO", SqlDbType.Int, idConcep})
            pars.Add(New Object() {"ID_CONTRIBUYENTE_RETENIDO", SqlDbType.Int, idTipContrib})
            Dim sql = ""
            If esCompra Then
                sql = "SELECT PR.CANTIDAD_PORCENTAJE_RETENCION, PR.CUENTA_COMPRA, PC.DETALLE FROM PORCENTAJE_RETENCION PR JOIN PLAN_CUENTAS_GENERAL PC ON PR.CUENTA_COMPRA=PC.CODIGO WHERE PR.ID_IMPUESTO_RETENIDO=1 AND PR.ID_CONCEPTO_PAGO=@ID_CONCEPTO_PAGO AND PR.ID_CONTRIBUYENTE_RETENIDO=@ID_CONTRIBUYENTE_RETENIDO;"
            Else
                sql = "SELECT PR.CANTIDAD_PORCENTAJE_RETENCION, PR.CUENTA_VENTA, PC.DETALLE FROM PORCENTAJE_RETENCION PR JOIN PLAN_CUENTAS_GENERAL PC ON PR.CUENTA_VENTA=PC.CODIGO WHERE PR.ID_IMPUESTO_RETENIDO=1 AND PR.ID_CONCEPTO_PAGO=@ID_CONCEPTO_PAGO AND PR.ID_CONTRIBUYENTE_RETENIDO=@ID_CONTRIBUYENTE_RETENIDO;"
            End If
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function BuscarCantidadPorcentajesIva(ByVal tipoCon As TipoConexion, ByVal idTipCon As Integer, ByVal tipoBs As Integer, ByVal esCompra As Boolean) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"TIPO_B_S", SqlDbType.Int, tipoBs})
            pars.Add(New Object() {"ID_CONTRIBUYENTE_RETENIDO", SqlDbType.Int, idTipCon})
            Dim sql = ""
            If esCompra Then
                sql = "SELECT PR.CANTIDAD_PORCENTAJE_RETENCION, PR.CUENTA_COMPRA, PC.DETALLE FROM PORCENTAJE_RETENCION PR JOIN PLAN_CUENTAS_GENERAL PC ON PR.CUENTA_COMPRA=PC.CODIGO WHERE PR.ID_IMPUESTO_RETENIDO=2 AND PR.TIPO_B_S=@TIPO_B_S AND PR.ID_CONTRIBUYENTE_RETENIDO=@ID_CONTRIBUYENTE_RETENIDO;"
            Else
                sql = "SELECT PR.CANTIDAD_PORCENTAJE_RETENCION, PR.CUENTA_VENTA, PC.DETALLE FROM PORCENTAJE_RETENCION PR JOIN PLAN_CUENTAS_GENERAL PC ON PR.CUENTA_VENTA=PC.CODIGO WHERE PR.ID_IMPUESTO_RETENIDO=2 AND PR.TIPO_B_S=@TIPO_B_S AND PR.ID_CONTRIBUYENTE_RETENIDO=@ID_CONTRIBUYENTE_RETENIDO;"
            End If
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
        End Function

        Public Function CuentaRetencionRentaCodPorcTipo(ByVal tipoCon As TipoConexion, ByVal codp As Integer, ByVal porc As Decimal, ByVal tipo As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CODP", SqlDbType.Int, codp})
            pars.Add(New Object() {"PORC", SqlDbType.Decimal, porc})
            ' 0 compra -  1 venta
            Dim sql = If(tipo = 0,
                         "select p.cuenta_compra from PORCENTAJE_RETENCION p join CONCEPTO_PAGO c on p.ID_CONCEPTO_PAGO=c.ID_CONCEPTO_PAGO where p.ID_IMPUESTO_RETENIDO = 1 and c.CODIGO_CONCEPTO_PAGO = @CODP and CANTIDAD_PORCENTAJE_RETENCION = @PORC group by p.cuenta_compra;",
                         "select p.cuenta_venta from PORCENTAJE_RETENCION p join CONCEPTO_PAGO c on p.ID_CONCEPTO_PAGO=c.ID_CONCEPTO_PAGO where p.ID_IMPUESTO_RETENIDO = 1 and c.CODIGO_CONCEPTO_PAGO = @CODP and CANTIDAD_PORCENTAJE_RETENCION = @PORC group by p.cuenta_venta;")
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
        Public Function CuentaRetencionIvaPorContTipo(ByVal tipoCon As TipoConexion, ByVal porc As Decimal, ByVal cont As Integer, ByVal tipo As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONT", SqlDbType.Int, cont})
            pars.Add(New Object() {"PORC", SqlDbType.Decimal, porc})
            ' 0 compra -  1 venta
            Dim sql = If(tipo = 0,
                         "select p.cuenta_compra from PORCENTAJE_RETENCION p where p.ID_IMPUESTO_RETENIDO = 2 and p.ID_CONTRIBUYENTE_RETENIDO = @CONT and p.CANTIDAD_PORCENTAJE_RETENCION = @PORC group by p.cuenta_compra;",
                         "select p.cuenta_venta from PORCENTAJE_RETENCION p where p.ID_IMPUESTO_RETENIDO = 2 and p.ID_CONTRIBUYENTE_RETENIDO = @CONT and p.CANTIDAD_PORCENTAJE_RETENCION = @PORC group by p.cuenta_venta;")
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function CuentaRetencionIvaPorc(ByVal tipoCon As TipoConexion, ByVal porc As Decimal) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"PORC", SqlDbType.Decimal, porc})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.cuenta_compra from PORCENTAJE_RETENCION p where p.ID_IMPUESTO_RETENIDO = 2 and p.CANTIDAD_PORCENTAJE_RETENCION = @PORC group by p.cuenta_compra;", False, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function
    End Class
End Namespace

