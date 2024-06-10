Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.MAYORIZACION
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.CONTABILIDAD.MAYORIZACION
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormSaldosMayores

        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Get
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        Return 2
                    Case TipoConexion.Seportpac
                        Return 1
                    Case Else
                        Return 0
                End Select
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 2
                        _tipoCon = TipoConexion.Asenava
                    Case 1
                        _tipoCon = TipoConexion.Seportpac
                    Case Else
                        _tipoCon = TipoConexion.Cisepro
                End Select
            End Set
        End Property
        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer
        Private _hoy As DateTime

        '==============================================================================================================================================================================
        Dim objPlan As New ClassPlanDeCuentas
        Dim objPlanPorProcesar As New ClassPlanDeCuentas
        Dim objMayor As New ClassMayorGeneral
        Dim objDetalle As New ClassDetalleMayores
        Dim objAsiento As New ClassAsientosLibroDiario
        Dim objAuditoria As New ClassAuditoriaGeneral

        '==== VALIDACIONES ===============================================================================================================================================================
        Dim validacionesNumeros As New ClassNumerico
        Dim validacionesAlfabetica As New ClassAlfabetico
        Dim validacionesAlfanumerica As New ClassAlfanumerico
        Dim validacionesDecimales As New ClassDecimal

        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""

        Public Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "SALDOS"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpInicio.Value.ToLongDateString() & "  AL " & dtpFinal.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub cargarEstadoSituacionInicial2()
            dgvCuentas.DataSource = Nothing

            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59"

            Dim objPlanCuentas As New ClassPlanDeCuentas
            dgvCuentas.DataSource = objPlanCuentas.SeleccionarPlanCuentasVacioCuentasActivas(_tipoCon)

            dgvCuentas.Columns(0).Width = 25
            dgvCuentas.Columns("CODIGO").Width = 80
            dgvCuentas.Columns("CUENTA").Width = 375
            dgvCuentas.Columns("DEBE").Width = 75
            dgvCuentas.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCuentas.Columns("HABER").Width = 75
            dgvCuentas.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCuentas.Columns("SALDO").Width = 75
            dgvCuentas.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvCuentas.Columns("NIVEL").Width = 40
            dgvCuentas.Columns("PADRE").Width = 80
            dgvCuentas.Columns("MOVIMIENTO").Width = 90
            dgvCuentas.Columns("TIPO").Width = 80

            Dim auxData As DataTable = objPlanCuentas.SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiario(_tipoCon, fechaDesde, fechaHasta)

            ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            For Each row As DataGridViewRow In dgvCuentas.Rows

                Select Case row.Cells.Item("NIVEL").Value.ToString
                    Case "7" : row.DefaultCellStyle.BackColor = Color.AliceBlue
                    Case "6" : row.DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "5" : row.DefaultCellStyle.BackColor = Color.White
                    Case "4" : row.DefaultCellStyle.BackColor = Color.SkyBlue
                    Case "3" : row.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "2" : row.DefaultCellStyle.BackColor = Color.PowderBlue
                    Case "1" : row.DefaultCellStyle.BackColor = Color.LightCyan
                End Select

                For Each drow As DataRow In auxData.Rows
                    If row.Cells("CODIGO").Value = drow("CODIGO") Then
                        row.Cells("DEBE").Value = drow("DEBE")
                        row.Cells("HABER").Value = drow("HABER")
                        row.Cells("SALDO").Value = drow("SALDO")
                    End If
                Next
            Next

            ' SE COPIA LA DATA ambas estructuras tiene debe, haber y saldo por nivel (auxiliar)
            auxData = CType(dgvCuentas.DataSource, DataTable)

            ' SE CALCULA LOS SALDOS TODOS LOS NIVELES (ACUMULADO NIVELES)
            For i = 7 To 1 Step -1
                For Each row As DataGridViewRow In dgvCuentas.Rows
                    For Each drow As DataRow In auxData.Rows
                        If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
                            row.Cells("DEBE").Value = Math.Round((CType(row.Cells("DEBE").Value, Double) + CType(drow("DEBE"), Double)), 2)
                            row.Cells("HABER").Value = Math.Round((CType(row.Cells("HABER").Value, Double) + CType(drow("HABER"), Double)), 2)
                            row.Cells("SALDO").Value = Math.Round((CType(row.Cells("SALDO").Value, Double) + CType(drow("SALDO"), Double)), 2)
                        End If

                        'verificar nodos
                        If row.Cells("CODIGO").Value = drow("PADRE") Then
                            row.Cells("nodo").Value = "-"
                        End If
                    Next
                Next
                auxData = CType(dgvCuentas.DataSource, DataTable)
            Next

            dgvCuentas.AutoResizeRows()

            '=== PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER ============================
            If dgvCuentas.Rows.Count > 0 Then
                Dim activo As Decimal = 0.0
                Dim pasivo As Decimal = 0.0
                Dim capital As Decimal = 0.0

                Dim deudorIngresos As Decimal = 0.0
                Dim acreedorIngresos As Decimal = 0.0
                Dim deudorEgresos As Decimal = 0.0
                Dim acreedorEgresos As Decimal = 0.0

                For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
                    If dgvCuentas.Rows(index).Cells("TIPO").Value < 4 Then
                        If dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("ACTIVO") Then
                            activo = activo + dgvCuentas.Rows(index).Cells("SALDO").Value
                        ElseIf dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("PASIVO") Then
                            pasivo = pasivo + dgvCuentas.Rows(index).Cells("SALDO").Value
                        ElseIf dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("PATRIMONIO NETO") Then
                            capital = capital + dgvCuentas.Rows(index).Cells("SALDO").Value
                        End If
                    ElseIf dgvCuentas.Rows(index).Cells("TIPO").Value = 4 Then
                        If dgvCuentas.Rows(index).Cells("NIVEL").Value = 1 Then
                            deudorIngresos = deudorIngresos + dgvCuentas.Rows(index).Cells("DEBE").Value
                            acreedorIngresos = acreedorIngresos + dgvCuentas.Rows(index).Cells("HABER").Value
                        End If
                    ElseIf dgvCuentas.Rows(index).Cells("TIPO").Value = 5 Then
                        If dgvCuentas.Rows(index).Cells("NIVEL").Value = 1 Then
                            deudorEgresos = deudorEgresos + dgvCuentas.Rows(index).Cells("DEBE").Value
                            acreedorEgresos = acreedorEgresos + dgvCuentas.Rows(index).Cells("HABER").Value
                        End If
                    End If
                Next
                txtDeudor.Text = activo
                txtAcreedor.Text = pasivo
                txtCapital.Text = capital
                txtUtilidad.Text = Math.Abs(activo + pasivo + capital)

                ' Asignar el valor de la utilidad a la cuenta contable
                Dim utilidad = activo + pasivo + capital
                If (utilidad > 0) Then
                    lblUtilidadPerdida.Text = "UTILIDAD"
                    lblUtilidadPerdida.ForeColor = Color.Navy
                    For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
                        If dgvCuentas.Rows(index).Cells("CUENTA").Value = "GANACIA NETA DEL PERIODO" Then
                            dgvCuentas.Rows(index).Cells("HABER").Value = dgvCuentas.Rows(index).Cells("HABER").Value + Convert.ToDouble(txtUtilidad.Text)
                            dgvCuentas.Rows(index).Cells("SALDO").Value = Math.Round(dgvCuentas.Rows(index).Cells("DEBE").Value - dgvCuentas.Rows(index).Cells("HABER").Value, 2)
                        End If
                    Next
                ElseIf (utilidad < 0) Then
                    lblUtilidadPerdida.Text = "PERDIDA"
                    lblUtilidadPerdida.ForeColor = Color.Red
                    For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
                        If dgvCuentas.Rows(index).Cells("CUENTA").Value = "(-) PÉRDIDA NETA DEL PERIODO" Then
                            dgvCuentas.Rows(index).Cells("DEBE").Value = dgvCuentas.Rows(index).Cells("DEBE").Value + Convert.ToDouble(txtUtilidad.Text)
                            dgvCuentas.Rows(index).Cells("SALDO").Value = Math.Round(dgvCuentas.Rows(index).Cells("DEBE").Value - dgvCuentas.Rows(index).Cells("HABER").Value, 2)
                        End If
                    Next
                Else
                    lblUtilidadPerdida.Text = "UTILIDAD"
                    lblUtilidadPerdida.ForeColor = Color.Navy
                End If

                txtDeudorIngresos.Text = deudorIngresos
                txtAcreedorIngresos.Text = acreedorIngresos
                txtDeudorEgresos.Text = deudorEgresos
                txtAcreedorEgresos.Text = acreedorEgresos

                txtIngresos.Text = Math.Round(Math.Abs(txtDeudorIngresos.Text - txtAcreedorIngresos.Text), 2)
                txtEgresos.Text = Math.Round(Math.Abs(txtDeudorEgresos.Text - txtAcreedorEgresos.Text), 2)
                txtTotal.Text = Math.Round(Math.Abs(txtIngresos.Text - txtEgresos.Text), 2)

                MsgBox("COMPROBACIÓN DE MAYORES EXITOSA!" & vbNewLine & "Por favor, verifique toda la información antes de generar el asiento!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                btnAsientoInicial.Enabled = True
            Else
                MsgBox("HUBO UN PROBLEMA AL REALIZAR LA COMPROBACIÓN!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                btnAsientoInicial.Enabled = False
            End If

        End Sub

        'Public Sub cargarEstadoSituacionInicial()
        '    Try
        '        ' Cargar las cuentas por procesar
        '        dgvCuentasPorProcesar.DataSource = objPlanPorProcesar.SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiario(_tipoCon, fechaDesde, fechaHasta)
        '        dgvCuentasPorProcesar.AutoResizeColumns()
        '        dgvCuentasPorProcesar.AutoResizeRows()

        '        ' Cargar las cuentas a mostrar (procesadas)
        '        dgvCuentas.DataSource = objPlan.SeleccionarSaldosMayoresEstadoInicialXFechaAsientoDiario(_tipoCon, fechaDesde, fechaHasta)
        '        dgvCuentas.AutoResizeColumns()
        '        dgvCuentas.AutoResizeRows()

        '        ' Redimensionar columnas
        '        dgvCuentas.Columns("nodo").Width = 25 : dgvCuentas.Columns("CODIGO").Width = 150 : dgvCuentas.Columns("CUENTA").Width = 375
        '        dgvCuentas.Columns("DEBE").Width = 75 : dgvCuentas.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        '        dgvCuentas.Columns("HABER").Width = 75 : dgvCuentas.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        '        dgvCuentas.Columns("SALDO").Width = 75 : dgvCuentas.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        '        ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
        '        For Each row As DataGridViewRow In dgvCuentas.Rows
        '            Select Case row.Cells.Item("NIVEL").Value.ToString
        '                Case "7" : row.DefaultCellStyle.BackColor = Color.AliceBlue
        '                Case "6" : row.DefaultCellStyle.BackColor = Color.GhostWhite
        '                Case "5" : row.DefaultCellStyle.BackColor = Color.White
        '                Case "4" : row.DefaultCellStyle.BackColor = Color.SkyBlue
        '                Case "3" : row.DefaultCellStyle.BackColor = Color.LightBlue
        '                Case "2" : row.DefaultCellStyle.BackColor = Color.PowderBlue
        '                Case "1" : row.DefaultCellStyle.BackColor = Color.LightCyan
        '            End Select
        '        Next

        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "7" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 6
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 6", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") ' txtNivel6.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "6" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 5
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 5", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") 'txtNivel5.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "5" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 4
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 4", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") 'txtNivel4.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "4" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 3
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 3", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") ' txtNivel3.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "3" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 2
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 2", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") 'txtNivel2.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "2" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Procesar Cuentas de nivel 1
        '        'MsgBox("PROCESANDO CUENTAS NIVEL 1", MsgBoxStyle.Information, "MENSAJE DE INFORMACION") ' txtNivel1.BackColor = Color.Azure
        '        ' Sumar los valores
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            For posicion = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(posicion).Cells("PADRE").Value And dgvCuentas.Rows(posicion).Cells("NIVEL").Value = "1" Then
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value + dgvCuentas.Rows(posicion).Cells("DEBE").Value
        '                    dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value + dgvCuentas.Rows(posicion).Cells("HABER").Value
        '                End If
        '            Next
        '        Next
        '        ' Actualizar los valores a mostrar
        '        For indice = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '            dgvCuentas.Rows(indice).Cells("CODIGO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentas.Rows(indice).Cells("CUENTA").Value = dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentas.Rows(indice).Cells("DEBE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value
        '            dgvCuentas.Rows(indice).Cells("HABER").Value = dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("SALDO").Value = dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value - dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value
        '            dgvCuentas.Rows(indice).Cells("NIVEL").Value = dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentas.Rows(indice).Cells("PADRE").Value = dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value
        '        Next
        '        ' Actualizar los valores a procesados
        '        For indice = 0 To dgvCuentasPorProcesar.Rows.Count - 1 Step 1
        '            dgvCuentasPorProcesar.Rows(indice).Cells("CODIGO").Value = dgvCuentas.Rows(indice).Cells("CODIGO").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("CUENTA").Value = dgvCuentas.Rows(indice).Cells("CUENTA").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("DEBE").Value = dgvCuentas.Rows(indice).Cells("DEBE").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("HABER").Value = dgvCuentas.Rows(indice).Cells("HABER").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("SALDO").Value = dgvCuentas.Rows(indice).Cells("SALDO").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("NIVEL").Value = dgvCuentas.Rows(indice).Cells("NIVEL").Value
        '            dgvCuentasPorProcesar.Rows(indice).Cells("PADRE").Value = dgvCuentas.Rows(indice).Cells("PADRE").Value
        '        Next

        '        ' Determinar si las cuentas son nodos (tienen sub cuentas)
        '        For indiceNodos = 0 To dgvCuentas.Rows.Count - 1
        '            For indicePadre = 0 To dgvCuentas.Rows.Count - 1
        '                If dgvCuentas.Rows(indiceNodos).Cells("CODIGO").Value = dgvCuentas.Rows(indicePadre).Cells("PADRE").Value Then
        '                    dgvCuentas.Rows(indiceNodos).Cells("nodo").Value = "-"
        '                End If
        '            Next
        '        Next

        '        '=== PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER =====================================================================================================================================
        '        Dim activo As Decimal = 0.0
        '        Dim pasivo As Decimal = 0.0
        '        Dim capital As Decimal = 0.0
        '        Dim deudorIngresos As Decimal = 0.0
        '        Dim acreedorIngresos As Decimal = 0.0
        '        Dim deudorEgresos As Decimal = 0.0
        '        Dim acreedorEgresos As Decimal = 0.0

        '        If dgvCuentas.Rows.Count > 0 Then
        '            For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                If dgvCuentas.Rows(index).Cells("TIPO").Value < 4 Then
        '                    If dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("ACTIVO") Then
        '                        activo = activo + dgvCuentas.Rows(index).Cells("SALDO").Value
        '                    ElseIf dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("PASIVO") Then
        '                        pasivo = pasivo + dgvCuentas.Rows(index).Cells("SALDO").Value
        '                    ElseIf dgvCuentas.Rows(index).Cells("CUENTA").Value.ToString().Trim().Equals("PATRIMONIO NETO") Then
        '                        capital = capital + dgvCuentas.Rows(index).Cells("SALDO").Value
        '                    End If
        '                ElseIf dgvCuentas.Rows(index).Cells("TIPO").Value = 4 Then
        '                    If dgvCuentas.Rows(index).Cells("NIVEL").Value = 1 Then
        '                        deudorIngresos = deudorIngresos + dgvCuentas.Rows(index).Cells("DEBE").Value
        '                        acreedorIngresos = acreedorIngresos + dgvCuentas.Rows(index).Cells("HABER").Value
        '                    End If
        '                ElseIf dgvCuentas.Rows(index).Cells("TIPO").Value = 5 Then
        '                    If dgvCuentas.Rows(index).Cells("NIVEL").Value = 1 Then
        '                        deudorEgresos = deudorEgresos + dgvCuentas.Rows(index).Cells("DEBE").Value
        '                        acreedorEgresos = acreedorEgresos + dgvCuentas.Rows(index).Cells("HABER").Value
        '                    End If
        '                End If
        '            Next
        '            txtDeudor.Text = activo
        '            txtAcreedor.Text = pasivo
        '            txtCapital.Text = capital
        '            txtUtilidad.Text = Math.Abs(activo + pasivo + capital)

        '            ' Asignar el valor de la utilidad a la cuenta contable
        '            Dim utilidad = activo + pasivo + capital

        '            If (utilidad > 0) Then
        '                lblUtilidadPerdida.Text = "UTILIDAD"
        '                lblUtilidadPerdida.ForeColor = Color.Navy
        '                For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                    If dgvCuentas.Rows(index).Cells("CUENTA").Value = "GANACIA NETA DEL PERIODO" Then
        '                        dgvCuentas.Rows(index).Cells("HABER").Value = dgvCuentas.Rows(index).Cells("HABER").Value + txtUtilidad.Text
        '                        dgvCuentas.Rows(index).Cells("SALDO").Value = dgvCuentas.Rows(index).Cells("DEBE").Value - dgvCuentas.Rows(index).Cells("HABER").Value
        '                    End If
        '                Next
        '            ElseIf (utilidad < 0) Then
        '                lblUtilidadPerdida.Text = "PERDIDA"
        '                lblUtilidadPerdida.ForeColor = Color.Red
        '                For index = 0 To dgvCuentas.Rows.Count - 1 Step 1
        '                    If dgvCuentas.Rows(index).Cells("CUENTA").Value = "(-) PÉRDIDA NETA DEL PERIODO" Then
        '                        dgvCuentas.Rows(index).Cells("DEBE").Value = dgvCuentas.Rows(index).Cells("DEBE").Value + txtUtilidad.Text
        '                        dgvCuentas.Rows(index).Cells("SALDO").Value = dgvCuentas.Rows(index).Cells("DEBE").Value - dgvCuentas.Rows(index).Cells("HABER").Value
        '                    End If
        '                Next
        '            Else
        '                lblUtilidadPerdida.Text = "UTILIDAD"
        '                lblUtilidadPerdida.ForeColor = Color.Navy
        '            End If

        '            txtDeudorIngresos.Text = deudorIngresos
        '            txtAcreedorIngresos.Text = acreedorIngresos
        '            txtDeudorEgresos.Text = deudorEgresos
        '            txtAcreedorEgresos.Text = acreedorEgresos

        '            txtIngresos.Text = Math.Round(Math.Abs(txtDeudorIngresos.Text - txtAcreedorIngresos.Text), 2)
        '            txtEgresos.Text = Math.Round(Math.Abs(txtDeudorEgresos.Text - txtAcreedorEgresos.Text), 2)
        '            txtTotal.Text = Math.Round(Math.Abs(txtIngresos.Text - txtEgresos.Text), 2)

        '            MsgBox("COMPROBACIÓN DE MAYORES EXITOSA!" & vbNewLine & "Por favor, verifique toda la información antes de generar el asiento!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
        '            btnAsientoInicial.Enabled = True
        '        Else
        '            MsgBox("HUBO UN PROBLEMA AL REALIZAR LA COMPROBACIÓN!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
        '            btnAsientoInicial.Enabled = False
        '        End If
        '    Catch ex As Exception
        '        MsgBox("HUBO UN PROBLEMA AL REALIZAR LA COMPROBACIÓN!", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
        '        btnAsientoInicial.Enabled = False
        '    End Try
        'End Sub

        Public Sub cargarCuentas()
            Try
                Dim indice As Integer = 0
                dgvCuentas.DataSource = objPlan.SeleccionarCuentas(_tipoCon)
                dgvCuentas.AutoResizeColumns()
                dgvCuentas.AutoResizeRows()
                For indice = 0 To dgvCuentas.Rows.Count - 1 Step 1
                    Select Case dgvCuentas.Rows(indice).Cells("NIVEL").Value
                        Case 1
                            dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.LightCyan
                        Case 2
                            dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.PowderBlue
                        Case 3
                            dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.LightBlue
                            'Case 4
                            '    dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.SkyBlue
                            'Case 5
                            '    dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.White
                            'Case 6
                            '    dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.GhostWhite
                            'Case 7
                            '    dgvCuentas.Rows(indice).DefaultCellStyle.BackColor = Color.AliceBlue
                    End Select
                Next
                Dim columnaDebe As DataGridViewColumn = New DataGridViewTextBoxColumn()
                Dim columnaHaber As DataGridViewColumn = New DataGridViewTextBoxColumn()
                columnaDebe.HeaderText = "DEBE"
                columnaHaber.HeaderText = "HABER"
                dgvCuentas.Columns.Add(columnaDebe)
                dgvCuentas.Columns.Add(columnaHaber)
                For indice = 0 To dgvCuentas.Columns.Count - 3
                    dgvCuentas.Columns(indice).ReadOnly = True
                    dgvCuentas.Columns(indice).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            Catch ex As Exception
                dgvCuentas.DataSource = Nothing
            End Try
        End Sub

        Private Sub FormSaldosMayores_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCuentas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCuentas.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _hoy = ValidationForms.FechaActual(_tipoCon)

            dtpAnio.Value = New Date(_hoy.Year, _hoy.Month, 1)
            dtpAnio_ValueChanged(Nothing, Nothing)
        End Sub

        Private Sub dgvCuentas_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCuentas.EditingControlShowing
            Dim ItemType As TextBox = TryCast(e.Control, TextBox)
            If ItemType IsNot Nothing Then
                AddHandler ItemType.KeyPress, AddressOf ItemType_KeyPress
            End If
        End Sub

        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvCuentas.KeyPress
            Select Case dgvCuentas.CurrentCell.ColumnIndex
                Case 5
                    If validacionesDecimales.EsDecimal(Convert.ToChar(e.KeyChar)) = True Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                Case 6
                    If validacionesDecimales.EsDecimal(Convert.ToChar(e.KeyChar)) = True Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
            End Select
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.000"
            fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"
            cargarEstadoSituacionInicial2()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvCuentas, "ESTADO DE SITUACION INICIAL")
        End Sub

        Private Sub btnAsientoInicial_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAsientoInicial.Click
            Try
                If dgvCuentas.RowCount = 0 Then
                    MessageBox.Show("DEBE SELECCIONAR EL AÑO Y CARGAR LAS CUENTAS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim concepto = "ESTADO SITUACION INICIAL " & dtpAnio.Value.Year
                Dim n = objAsiento.BuscarNumeroRegistroAsientoXConceptoAsientoLibroDiario(_tipoCon, concepto)
                If n > 0 Then
                    MessageBox.Show("YA EXISTE UN ESTADO DE SITUACION INICIAL PARA EL AÑO " & dtpAnio.Value.Year & vbNewLine & "REVISE EL ASIENTO NUMERO " & n, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim numeroRegistro = objAsiento.BuscarMayorNuneroRegistroAsientoInicialLibroDiario(_tipoCon) + 1
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA CREAR EL ESTADO DE SITUACIÓN INICIAL " & dtpAnio.Value.Year & " CON N° DE ASIENTO: " & numeroRegistro & "?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _sqlCommands.Clear()

                Dim idasiento = objAsiento.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

                For indice = 0 To dgvCuentas.Rows.Count - 1
                    With objAsiento
                        .IdAsiento = idasiento
                        .FechaAsiento = dtpAnio.Value.Year.ToString + "-01-01 12:00:00"
                        .CodigoCuentaAsiento = dgvCuentas.Rows(indice).Cells("CODIGO").Value
                        .NombreCuentaAsiento = dgvCuentas.Rows(indice).Cells("CUENTA").Value
                        .ConceptoAsiento = "ESTADO SITUACION INICIAL " & dtpAnio.Value.Year
                        .DetalleTransaccionAsiento = "INGRESO DE SALDOS"
                        .ProvinciaAsiento = "EL ORO"
                        .CiudadAsiento = "MACHALA"
                        .ParroquiaAsiento = "MACHALA"
                        .CentroCostoAsiento = "CONTABILIDAD"
                        .NumeroRegistroAsiento = numeroRegistro
                        .ConciliarAsiento = 1
                        If dgvCuentas.Rows(indice).Cells("TIPO").Value < 4 Then
                            If dgvCuentas.Rows(indice).Cells("MOVIMIENTO").Value = "SI" Then
                                If dgvCuentas.Rows(indice).Cells("SALDO").Value > 0 Then
                                    .ValorDebeAsiento = dgvCuentas.Rows(indice).Cells("SALDO").Value
                                    .ValorHaberAsiento = 0.0
                                ElseIf dgvCuentas.Rows(indice).Cells("SALDO").Value < 0 Then
                                    .ValorDebeAsiento = 0.0
                                    .ValorHaberAsiento = CDec(dgvCuentas.Rows(indice).Cells("SALDO").Value) * -1
                                Else
                                    .ValorDebeAsiento = 0.0
                                    .ValorHaberAsiento = 0.0
                                End If
                            Else
                                .ValorDebeAsiento = 0.0
                                .ValorHaberAsiento = 0.0
                            End If 
                        Else
                            .ValorDebeAsiento = 0.0
                            .ValorHaberAsiento = 0.0
                        End If


                        If .ValorDebeAsiento >= .ValorHaberAsiento Then
                            .DebeHaberAsiento = 1
                        Else
                            .DebeHaberAsiento = 2
                        End If
                        .EstadoAsiento = 2
                        .IdLibroDiario = 1
                        '.NuevoRegistroAsientoLibroDiario(_tipoCon)
                    End With
                    _sqlCommands.Add(objAsiento.NuevoRegistroAsientoLibroDiarioCommand)

                    idasiento += 1
                Next

                objAuditoria.AccionAuditoria = "SE REALIZADO NUEVO ESTADO DE SITUACION INICIAL CON REGISTRO DE DIARIO #" + CType(objAsiento.NumeroRegistroAsiento, String)
                objAuditoria.FormularioAuditoria = Me.Text.ToString.Trim
                With objAuditoria
                    .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                    .IdUsuarioAuditoria = IdUsuario
                    .EstadoAuditoria = 1
                    .FechaAuditoria = _hoy
                    '.NuevaAuditoria(_tipoCon)
                End With
                _sqlCommands.Add(objAuditoria.NuevaAuditoria)

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)

                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA GUARDAR!" & vbNewLine & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dgvCuentas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
            Try
                If dgvCuentas.Columns(e.ColumnIndex).Name = "nodo" AndAlso Me.dgvCuentas.Rows(e.RowIndex).IsNewRow = False Then
                    ' si el nodo esta desplegado
                    If dgvCuentas.CurrentRow.Cells("nodo").Value = "-" Then
                        For indiceNodo = 0 To dgvCuentas.Rows.Count - 1
                            ' si el valor del nodo cliqueado forma parte de la cadena de las demas celdas (hijos, nietos, visnietos, etc.)
                            If Mid(dgvCuentas.Rows(indiceNodo).Cells("PADRE").Value, 1, dgvCuentas.CurrentRow.Cells("CODIGO").Value.ToString.Length) = dgvCuentas.CurrentRow.Cells("CODIGO").Value Then
                                ' ocultamos la fila
                                dgvCuentas.Rows(indiceNodo).Visible = False
                                ' si la fila es sub nodo 
                                If dgvCuentas.Rows(indiceNodo).Cells("nodo").Value = "-" Then
                                    ' cambia el estado del nodo a contraido
                                    dgvCuentas.Rows(indiceNodo).Cells("nodo").Value = "+"
                                End If
                            End If
                        Next
                        ' cambia el estado del nodo a contraido
                        dgvCuentas.CurrentRow.Cells("nodo").Value = "+"

                    ElseIf dgvCuentas.CurrentRow.Cells("nodo").Value = "+" Then ' si el nodo esta contraido
                        For indiceNodo = 0 To dgvCuentas.Rows.Count - 1
                            ' si la fila es parte del nodo liqueado
                            If dgvCuentas.Rows(indiceNodo).Cells("PADRE").Value = dgvCuentas.CurrentRow.Cells("CODIGO").Value Then
                                ' mostramos la fila
                                dgvCuentas.Rows(indiceNodo).Visible = True
                            End If
                        Next
                        ' cambia el estado del nodo a desplegado
                        dgvCuentas.CurrentRow.Cells("nodo").Value = "-"
                    Else ' no es nodo
                        dgvCuentas.CurrentRow.Cells("nodo").Value = ""
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Private Sub dtpAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpAnio.ValueChanged
            dtpInicio.Value = New DateTime(dtpAnio.Value.Year - 1, 1, 1)
            dtpFinal.Value = New DateTime(dtpAnio.Value.Year - 1, 12, 31)
        End Sub
    End Class
End Namespace