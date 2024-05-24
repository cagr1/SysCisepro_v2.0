Imports ClassLibraryCisepro.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
Imports ClassLibraryCisepro.ENUMS 
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormEstadoPerdidasYGanancias

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
        
        ReadOnly _objEstado As New ClassPerdidasYGanancia

        Private Sub CargaIngresosMensual(ByVal all As Boolean)
            Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            dgvIngresos.DataSource = _objEstado.SeleccionarEstadoPerdidasGananciasVentasXRangoFechasMensual(_tipoCon)

            dgvIngresos.Columns(0).Width = 25 : dgvIngresos.Columns("CODIGO").Width = 80 : dgvIngresos.Columns("CUENTA").Width = 495
            dgvIngresos.Columns("DEBE").Width = 75 : dgvIngresos.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvIngresos.Columns("HABER").Width = 75 : dgvIngresos.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvIngresos.Columns("SALDO").Width = 75 : dgvIngresos.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvIngresos.Columns("NIVEL").Width = 40 : dgvIngresos.Columns("PADRE").Width = 80

            Dim auxData As DataTable = _objEstado.SeleccionarEstadoPerdidasGananciasVentasXRangoFechas(_tipoCon, fechaDesde, fechaHasta, all)

            ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            For Each row As DataGridViewRow In dgvIngresos.Rows

                Select Case row.Cells.Item("NIVEL").Value.ToString
                    Case "7"
                        row.DefaultCellStyle.BackColor = Color.AliceBlue
                    Case "6"
                        row.DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "5"
                        row.DefaultCellStyle.BackColor = Color.White
                    Case "4"
                        row.DefaultCellStyle.BackColor = Color.SkyBlue
                    Case "3"
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "2"
                        row.DefaultCellStyle.BackColor = Color.PowderBlue
                    Case "1"
                        row.DefaultCellStyle.BackColor = Color.LightCyan
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
            auxData = CType(dgvIngresos.DataSource, DataTable)

            ' SE CALCULA LOS SALDOS TODOS LOS NIVELES (ACUMULADO NIVELES)
            For i = 7 To 1 Step -1
                For Each row As DataGridViewRow In dgvIngresos.Rows
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
                auxData = CType(dgvIngresos.DataSource, DataTable)
            Next

        End Sub

        Private Sub CargarEgresosMensual(ByVal all As Boolean)
            Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            dgvEgresos.DataSource = _objEstado.SeleccionarEstadoPerdidasGananciasComprasXRangoFechasMensual(_tipoCon)

            dgvEgresos.Columns(0).Width = 25 : dgvEgresos.Columns("CODIGO").Width = 80 : dgvEgresos.Columns("CUENTA").Width = 495
            dgvEgresos.Columns("DEBE").Width = 75 : dgvEgresos.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvEgresos.Columns("HABER").Width = 75 : dgvEgresos.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvEgresos.Columns("SALDO").Width = 75 : dgvEgresos.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dgvEgresos.Columns("NIVEL").Width = 40 : dgvEgresos.Columns("PADRE").Width = 80

            Dim auxData As DataTable = _objEstado.SeleccionarEstadoPerdidasGananciasComprasXRangoFechas(_tipoCon, fechaDesde, fechaHasta, all)

            ' SE COPIA LA DATA, SE PINTA Y CALCULA SALDO (CUENTA POR CUENTA)
            For Each row As DataGridViewRow In dgvEgresos.Rows

                Select Case row.Cells.Item("NIVEL").Value.ToString
                    Case "7"
                        row.DefaultCellStyle.BackColor = Color.AliceBlue
                    Case "6"
                        row.DefaultCellStyle.BackColor = Color.GhostWhite
                    Case "5"
                        row.DefaultCellStyle.BackColor = Color.White
                    Case "4"
                        row.DefaultCellStyle.BackColor = Color.SkyBlue
                    Case "3"
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "2"
                        row.DefaultCellStyle.BackColor = Color.PowderBlue
                    Case "1"
                        row.DefaultCellStyle.BackColor = Color.LightCyan
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
            auxData = CType(dgvEgresos.DataSource, DataTable)

            ' SE CALCULA LOS SALDOS TODOS LOS NIVELES (ACUMULADO NIVELES)
            For i = 7 To 1 Step -1
                For Each row As DataGridViewRow In dgvEgresos.Rows
                    For Each drow As DataRow In auxData.Rows
                        If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
                            row.Cells("DEBE").Value = Math.Round((CType(row.Cells("DEBE").Value, Double) + CType(drow("DEBE"), Double)), 2)
                            row.Cells("HABER").Value = Math.Round((CType(row.Cells("HABER").Value, Double) + CType(drow("HABER"), Double)), 2)
                            row.Cells("SALDO").Value = Math.Round((CType(row.Cells("SALDO").Value, Double) + CType(drow("SALDO"), Double)), 2)
                        End If

                        'verificar nodos
                        If row.Cells("CODIGO").Value = drow("PADRE") Then
                            row.Cells("nodoEgreso").Value = "-"
                        End If
                    Next
                Next
                auxData = CType(dgvEgresos.DataSource, DataTable)
            Next
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "BALANCE_PYG"

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
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
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
                Dim c = 0
                For o = 0 To dgvAsientosDiario.Rows.Count - 1
                    If Not dgvAsientosDiario.Rows(o).Visible Then Continue For
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For
                        worksheet.Cells(c + 1 + headin, indc) = dgvAsientosDiario.Rows(o).Cells(j).Value
                        worksheet.Cells(c + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(c + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                    c += 1
                Next
                worksheet.Range("A" & (c + headin) & ":" & ic & indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


                Dim deu As String = If(titulo.ToUpper().Contains("INGRESOS"), txtDeudorIngresos.Text, txtDeudorEgresos.Text)
                Dim ace As String = If(titulo.ToUpper().Contains("INGRESOS"), txtAcreedorIngresos.Text, txtAcreedorEgresos.Text)
                Dim tot As String = If(titulo.ToUpper().Contains("INGRESOS"), txtIngresos.Text, txtEgresos.Text)

                ' TOTALES, ETC
                Dim foot = headin + c + 3
                worksheet.Cells(foot, 7).Value = "TOTAL DEUDOR"
                worksheet.Cells(foot, 7).Font.Bold = True
                worksheet.Cells(foot, 8).Value = deu

                worksheet.Cells(foot + 1, 7).Value = "TOTAL ACREEDOR"
                worksheet.Cells(foot + 1, 7).Font.Bold = True
                worksheet.Cells(foot + 1, 8).Value = ace

                worksheet.Cells(foot + 2, 7).Value = "TOTAL PYG"
                worksheet.Cells(foot + 2, 7).Font.Bold = True
                worksheet.Cells(foot + 2, 8).Value = tot

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ExportarDatosExcelDobleGrid(ByVal dgvIngresos As DataGridView, ByVal dgvEgresos As DataGridView, ByVal titulo As String)
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "BALANCE_PYG"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvIngresos)
                worksheet.Range("A1:" & ic & (dgvIngresos.RowCount + dgvEgresos.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvIngresos.Columns.Count - 1
                    If Not dgvIngresos.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvIngresos.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                Dim c = headin + 1
                For o = 0 To dgvIngresos.Rows.Count - 1
                    If Not dgvIngresos.Rows(o).Visible Then Continue For
                    indc = 1
                    For j = 0 To dgvIngresos.Columns.Count - 1
                        If Not dgvIngresos.Columns(j).Visible Then Continue For
                        worksheet.Cells(c, indc) = dgvIngresos.Rows(o).Cells(j).Value
                        worksheet.Cells(c, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(c, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                    c += 1
                Next
                worksheet.Range("A" & (c - 1) & ":" & ic & indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


                'Aca se ingresa las columnas
                indc = 1 
                c += 1
                For i = 0 To dgvEgresos.Columns.Count - 1
                    If Not dgvEgresos.Columns(i).Visible Then Continue For
                    worksheet.Cells(c, indc) = dgvEgresos.Columns(i).HeaderText
                    worksheet.Cells(c, indc).Font.Bold = True
                    worksheet.Cells(c, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(c, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(c, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(c, indc).Font.Color = Color.White
                    indc += 1
                Next
                
                'Aca se ingresa el detalle recorrera la tabla celda por celda
                c += 1
                For o = 0 To dgvEgresos.Rows.Count - 1
                    If Not dgvEgresos.Rows(o).Visible Then Continue For
                    indc = 1
                    For j = 0 To dgvEgresos.Columns.Count - 1
                        If Not dgvEgresos.Columns(j).Visible Then Continue For
                        worksheet.Cells(c, indc) = dgvEgresos.Rows(o).Cells(j).Value
                        worksheet.Cells(c, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(c, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                    c += 1
                Next
                worksheet.Range("A" & (c - 1) & ":" & ic & indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous


                Dim dei = txtDeudorIngresos.Text
                Dim aci = txtAcreedorIngresos.Text
                Dim toi = txtIngresos.Text

                Dim deg = txtDeudorEgresos.Text
                Dim acg = txtAcreedorEgresos.Text
                Dim tog = txtEgresos.Text

                ' TOTALES, ETC
                Dim foot = c + 2
                worksheet.Cells(foot, 7).Value = "TOTAL INGRESOS DEUDOR"
                worksheet.Cells(foot, 7).Font.Bold = True
                worksheet.Cells(foot, 8).Value = dei

                worksheet.Cells(foot + 1, 7).Value = "TOTAL INGRESOS ACREEDOR"
                worksheet.Cells(foot + 1, 7).Font.Bold = True
                worksheet.Cells(foot + 1, 8).Value = aci

                worksheet.Cells(foot + 2, 7).Value = "TOTAL INGRESOS"
                worksheet.Cells(foot + 2, 7).Font.Bold = True
                worksheet.Cells(foot + 2, 8).Value = toi

                worksheet.Cells(foot + 4, 7).Value = "TOTAL EGRESOS DEUDOR"
                worksheet.Cells(foot + 4, 7).Font.Bold = True
                worksheet.Cells(foot + 4, 8).Value = deg

                worksheet.Cells(foot + 5, 7).Value = "TOTAL EGRESOS ACREEDOR"
                worksheet.Cells(foot + 5, 7).Font.Bold = True
                worksheet.Cells(foot + 5, 8).Value = acg

                worksheet.Cells(foot + 6, 7).Value = "TOTAL EGRESOS"
                worksheet.Cells(foot + 6, 7).Font.Bold = True
                worksheet.Cells(foot + 6, 8).Value = tog

                worksheet.Cells(foot + 8, 7).Value = "TOTAL REPORTE"
                worksheet.Cells(foot + 8, 7).Font.Bold = True
                worksheet.Cells(foot + 8, 8).Value = txtTotal.Text

                worksheet.Range("A1:" & ic & (dgvIngresos.RowCount + dgvEgresos.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try 
        End Sub

        Private Sub FormEstadoPerdidasYGanancias_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label22.ForeColor = Color.White
                    Label22.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label22.ForeColor = Color.White
                    Label22.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label22.ForeColor = Color.White
                    Label22.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            Me.dgvIngresos.ContextMenuStrip = Me.ContextMenuStripClicDerecho
            Me.dgvEgresos.ContextMenuStrip = Me.ContextMenuStripClicDerechoEgresos
            cbNivel.SelectedIndex = 0
        End Sub

        Private Sub btnBuscarMensual_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarMensual.Click
            dgvEgresos.DataSource = Nothing
            dgvIngresos.DataSource = Nothing

            cargaIngresosMensual(True)
            '=== PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER =====================================================================================================================================
            Dim deudor As Decimal = 0.0
            Dim acreedor As Decimal = 0.0
            If dgvIngresos.Rows.Count > 0 Then
                For index = 0 To dgvIngresos.Rows.Count - 1 Step 1
                    If dgvIngresos.Rows(index).Cells("NIVEL").Value = 1 Then
                        deudor = deudor + dgvIngresos.Rows(index).Cells("DEBE").Value
                        acreedor = acreedor + dgvIngresos.Rows(index).Cells("HABER").Value
                    End If
                Next
                txtDeudorIngresos.Text = deudor
                txtAcreedorIngresos.Text = acreedor
            End If

            cargarEgresosMensual(True)
            '=== PARA SUMAR LOS TOTALES Y COMPROBAR LAS SUMAS DEL DEBE Y EL HABER =====================================================================================================================================
            deudor = 0.0
            acreedor = 0.0
            If dgvEgresos.Rows.Count > 0 Then
                For index = 0 To dgvEgresos.Rows.Count - 1 Step 1
                    If dgvEgresos.Rows(index).Cells("NIVEL").Value = 1 Then
                        deudor = deudor + dgvEgresos.Rows(index).Cells("DEBE").Value
                        acreedor = acreedor + dgvEgresos.Rows(index).Cells("HABER").Value
                    End If
                Next
                txtDeudorEgresos.Text = deudor
                txtAcreedorEgresos.Text = acreedor
            End If

            '=== PARA SABER LAS GANANCIAS =============================================================================================================================================================================
            Dim txdi As Double = If(txtDeudorIngresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtDeudorIngresos.Text.Trim()))
            Dim txai As Double = If(txtAcreedorIngresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtAcreedorIngresos.Text.Trim()))
            txtIngresos.Text = Math.Round(Math.Abs(txdi - txai), 2)

            Dim txde As Double = If(txtDeudorEgresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtDeudorEgresos.Text.Trim()))
            Dim txae As Double = If(txtAcreedorEgresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtAcreedorEgresos.Text.Trim()))
            txtEgresos.Text = Math.Round(Math.Abs(txde - txae), 2)

            Dim ti As Double = If(txtIngresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtIngresos.Text.Trim()))
            Dim te As Double = If(txtEgresos.Text.Trim().Length = 0, 0, Convert.ToDouble(txtEgresos.Text.Trim()))
            txtTotal.Text = Math.Round(Math.Abs(ti - te), 2)

            'CantidadReistros()
            chkTodos.Checked = False
        End Sub

        'Private Sub CantidadReistros()
        '    Dim v1 = 0
        '    Dim o1 = 0
        '    For Each row As DataGridViewRow In dgvIngresos.Rows
        '        If row.Visible Then
        '            v1 += 1
        '        Else
        '            o1 += 1
        '        End If
        '    Next

        '    Dim v2 = 0
        '    Dim o2 = 0
        '    For Each row As DataGridViewRow In dgvEgresos.Rows
        '        If row.Visible Then
        '            v2 += 1
        '        Else
        '            o2 += 1
        '        End If
        '    Next

        '    'LbCount1.Text = v1 & " REGISTRO(S)"
        '    'LbCount2.Text = v2 & " REGISTRO(S)"
        'End Sub

        Private Sub btnExportarIngresos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            ExportarDatosExcel(dgvIngresos, "INGRESOS")
        End Sub

        Private Sub btnExportarEgresos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            ExportarDatosExcel(dgvEgresos, "EGRESOS")
        End Sub

        Private Sub tsmOcultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmOcultar.Click
            Dim indice As Integer = 0
            If dgvIngresos.Rows.Count > 0 Then
                For indice = 0 To dgvIngresos.Rows.Count - 1 Step 1
                    If dgvIngresos.Rows(indice).Cells("PADRE").Value > dgvIngresos.CurrentRow.Cells.Item(5).Value Then
                        dgvIngresos.Rows(indice).Visible = False
                    End If
                Next
            Else
            End If
        End Sub

        Private Sub tsmMostrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmMostrar.Click
            Dim indice As Integer = 0
            If dgvIngresos.Rows.Count > 0 Then
                For indice = 0 To dgvIngresos.Rows.Count - 1 Step 1
                    If dgvIngresos.Rows(indice).Cells("PADRE").Value <> dgvIngresos.CurrentRow.Cells.Item(5).Value Then
                        dgvIngresos.Rows(indice).Visible = True
                    End If
                Next
            Else
            End If
        End Sub

        Private Sub tsmOcultarEgresos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmOcultarEgresos.Click
            Dim indice As Integer = 0
            If dgvEgresos.Rows.Count > 0 Then
                For indice = 0 To dgvEgresos.Rows.Count - 1 Step 1
                    If dgvEgresos.Rows(indice).Cells("PADRE").Value > dgvEgresos.CurrentRow.Cells.Item(5).Value Then
                        dgvEgresos.Rows(indice).Visible = False
                    End If
                Next
            Else
            End If
        End Sub

        Private Sub tsmMostrarEgresos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles tsmMostrarEgresos.Click
            Dim indice As Integer = 0
            If dgvEgresos.Rows.Count > 0 Then
                For indice = 0 To dgvEgresos.Rows.Count - 1 Step 1
                    If dgvEgresos.Rows(indice).Cells("PADRE").Value <> dgvEgresos.CurrentRow.Cells.Item(5).Value Then
                        dgvEgresos.Rows(indice).Visible = True
                    End If
                Next
            Else
            End If
        End Sub

        Private Sub FiltrarNiveles(ByVal nivel As Integer)
            cbNivel.SelectedIndex = nivel

            ' Ingresos
            dgvIngresos.CurrentCell = Nothing
            For indiceIngresos = 0 To dgvIngresos.Rows.Count - 1
                If nivel <> 0 And dgvIngresos.Rows(indiceIngresos).Cells("NIVEL").Value > nivel Then
                    dgvIngresos.Rows(indiceIngresos).Visible = False
                Else
                    dgvIngresos.Rows(indiceIngresos).Visible = True
                End If
            Next

            ' Egresos
            dgvEgresos.CurrentCell = Nothing
            For indiceEgresos = 0 To dgvEgresos.Rows.Count - 1
                If nivel <> 0 And dgvEgresos.Rows(indiceEgresos).Cells("NIVEL").Value > nivel Then
                    dgvEgresos.Rows(indiceEgresos).Visible = False
                Else
                    dgvEgresos.Rows(indiceEgresos).Visible = True
                End If
            Next

            chkTodos.Checked = False

            'CantidadReistros()
        End Sub

        Private Sub dgvIngresos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngresos.CellClick
            Try
                If dgvIngresos.Columns(e.ColumnIndex).Name = "nodo" AndAlso Me.dgvIngresos.Rows(e.RowIndex).IsNewRow = False Then
                    ' si el nodo esta desplegado
                    If dgvIngresos.CurrentRow.Cells("nodo").Value = "-" Then
                        For indiceNodo = 0 To dgvIngresos.Rows.Count - 1
                            ' si el valor del nodo cliqueado forma parte de la cadena de las demas celdas (hijos, nietos, visnietos, etc.)
                            If Mid(dgvIngresos.Rows(indiceNodo).Cells("PADRE").Value, 1, dgvIngresos.CurrentRow.Cells("CODIGO").Value.ToString.Length) = dgvIngresos.CurrentRow.Cells("CODIGO").Value Then
                                ' ocultamos la fila
                                dgvIngresos.Rows(indiceNodo).Visible = False
                                ' si la fila es sub nodo 
                                If dgvIngresos.Rows(indiceNodo).Cells("nodo").Value = "-" Then
                                    ' cambia el estado del nodo a contraido
                                    dgvIngresos.Rows(indiceNodo).Cells("nodo").Value = "+"
                                End If
                            End If
                        Next
                        ' cambia el estado del nodo a contraido
                        dgvIngresos.CurrentRow.Cells("nodo").Value = "+"

                    ElseIf dgvIngresos.CurrentRow.Cells("nodo").Value = "+" Then ' si el nodo esta contraido
                        For indiceNodo = 0 To dgvIngresos.Rows.Count - 1
                            ' si la fila es parte del nodo liqueado
                            If dgvIngresos.Rows(indiceNodo).Cells("PADRE").Value = dgvIngresos.CurrentRow.Cells("CODIGO").Value Then
                                ' mostramos la fila
                                dgvIngresos.Rows(indiceNodo).Visible = True
                            End If
                        Next
                        ' cambia el estado del nodo a desplegado
                        dgvIngresos.CurrentRow.Cells("nodo").Value = "-"
                    Else ' no es nodo
                        dgvIngresos.CurrentRow.Cells("nodo").Value = ""
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Private Sub dgvEgresos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvEgresos.CellClick
            Try
                If dgvEgresos.Columns(e.ColumnIndex).Name = "nodoEgreso" AndAlso Me.dgvEgresos.Rows(e.RowIndex).IsNewRow = False Then
                    ' si el nodo esta desplegado
                    If dgvEgresos.CurrentRow.Cells("nodoEgreso").Value = "-" Then
                        For indiceNodo = 0 To dgvEgresos.Rows.Count - 1
                            ' si el valor del nodo cliqueado forma parte de la cadena de las demas celdas (hijos, nietos, visnietos, etc.)
                            If Mid(dgvEgresos.Rows(indiceNodo).Cells("PADRE").Value, 1, dgvEgresos.CurrentRow.Cells("CODIGO").Value.ToString.Length) = dgvEgresos.CurrentRow.Cells("CODIGO").Value Then
                                ' ocultamos la fila
                                dgvEgresos.Rows(indiceNodo).Visible = False
                                ' si la fila es sub nodo 
                                If dgvEgresos.Rows(indiceNodo).Cells("nodoEgreso").Value = "-" Then
                                    ' cambia el estado del nodo a contraido
                                    dgvEgresos.Rows(indiceNodo).Cells("nodoEgreso").Value = "+"
                                End If
                            End If
                        Next
                        ' cambia el estado del nodo a contraido
                        dgvEgresos.CurrentRow.Cells("nodoEgreso").Value = "+"

                    ElseIf dgvEgresos.CurrentRow.Cells("nodoEgreso").Value = "+" Then ' si el nodo esta contraido
                        For indiceNodo = 0 To dgvEgresos.Rows.Count - 1
                            ' si la fila es parte del nodo liqueado
                            If dgvEgresos.Rows(indiceNodo).Cells("PADRE").Value = dgvEgresos.CurrentRow.Cells("CODIGO").Value Then
                                ' mostramos la fila
                                dgvEgresos.Rows(indiceNodo).Visible = True
                            End If
                        Next
                        ' cambia el estado del nodo a desplegado
                        dgvEgresos.CurrentRow.Cells("nodoEgreso").Value = "-"
                    Else ' no es nodo
                        dgvEgresos.CurrentRow.Cells("nodoEgreso").Value = ""
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            ExportarDatosExcelDobleGrid(dgvIngresos, dgvEgresos, "ESTADO DE PERDIDAS Y GANANCIAS")
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click

            Dim fpg As New FrmReportePerdidasYGanancias("REPORTE_PERDIDAS_GANANCIAS")

            Dim nivel1 As New List(Of Object)
            Dim nivel2 As New List(Of Object)
            Dim nivel3 As New List(Of Object)

            ' ingresos capturos elementos para ingresos n1, n2 y n3
            For Each row As DataGridViewRow In dgvIngresos.Rows
                Dim element As Object = {row.Cells("CODIGO").Value, row.Cells("CODIGO").Value & " - " & row.Cells("CUENTA").Value, row.Cells("SALDO").Value, row.Cells("PADRE").Value}

                If row.Cells("NIVEL").Value = 1 Then
                    nivel1.Add(element)
                End If
                If row.Cells("NIVEL").Value = 2 Then
                    nivel2.Add(element)
                End If
                If row.Cells("NIVEL").Value = 3 Then
                    nivel3.Add(element)
                End If
            Next

            ' lleno data source reporte
            Dim tn1 As Double = 0.0
            Dim tn2 As Double = 0.0
            Dim tn3 As Double = 0.0

            For i1 = 0 To nivel1.Count - 1 Step 1
                fpg.Datos.Rows.Add(nivel1(i1)(1), "", 1)
                tn1 += nivel1(i1)(2)
                For i2 = 0 To nivel2.Count - 1 Step 1
                    fpg.Datos.Rows.Add("        " & nivel2(i2)(1), "", 1)
                    tn2 += nivel2(i2)(2)
                    For i3 = 0 To nivel3.Count - 1 Step 1
                        If nivel3(i3)(3) = nivel2(i2)(0) Then
                            fpg.Datos.Rows.Add("            " & nivel3(i3)(1), nivel3(i3)(2), 0)
                            tn3 += nivel3(i3)(2)
                        End If
                    Next
                    fpg.Datos.Rows.Add("        TOTAL  " & nivel2(i2)(1), tn2, 2)
                Next
                fpg.Datos.Rows.Add("TOTAL  " & nivel1(i1)(1), tn1, 2)
            Next

            ' egresos capturos elementos para ingresos n1, n2 y n3
            nivel1.Clear()
            nivel2.Clear()
            nivel3.Clear()
            For Each row As DataGridViewRow In dgvEgresos.Rows
                Dim element As Object = {row.Cells("CODIGO").Value, row.Cells("CODIGO").Value & " - " & row.Cells("CUENTA").Value, row.Cells("SALDO").Value, row.Cells("PADRE").Value}
                If row.Cells("NIVEL").Value = 1 Then
                    nivel1.Add(element)
                End If

                If row.Cells("NIVEL").Value = 2 Then
                    nivel2.Add(element)
                End If

                If row.Cells("NIVEL").Value = 3 Then
                    nivel3.Add(element)
                End If
            Next

            ' fila de espacio
            fpg.Datos.Rows.Add("", "")

            tn1 = 0
            tn2 = 0
            tn3 = 0
            For i1 = 0 To nivel1.Count - 1 Step 1
                fpg.Datos.Rows.Add(nivel1(i1)(1), "", 1)
                tn1 += nivel1(i1)(2)
                For i2 = 0 To nivel2.Count - 1 Step 1
                    fpg.Datos.Rows.Add("        " & nivel2(i2)(1), "", 1)
                    tn2 += nivel2(i2)(2)
                    For i3 = 0 To nivel3.Count - 1 Step 1
                        If nivel3(i3)(3) = nivel2(i2)(0) Then
                            fpg.Datos.Rows.Add("            " & nivel3(i3)(1), nivel3(i3)(2), 0)
                            tn3 += nivel3(i3)(2)
                        End If
                    Next
                    fpg.Datos.Rows.Add("        TOTAL  " & nivel2(i2)(1), tn2, 2)
                Next
                fpg.Datos.Rows.Add("TOTAL  " & nivel1(i1)(1), tn1, 2)
            Next

            ' final
            fpg.Datos.Rows.Add("", "")
            fpg.Datos.Rows.Add("TOTAL  INGRESOS  -  EGRESOS", txtTotal.Text, 1)

            fpg.FInicio = dtpFechaDesde.Value.ToShortDateString & " 00:00:00"
            fpg.FFin = dtpFechaHasta.Value.ToShortDateString & " 23:59:59"
            fpg.Footer = "FECHA DE IMPRESIÓN: " & _objEstado.SeleccionarFechaActual(True)
            fpg.ShowDialog()

        End Sub

        Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTodos.CheckedChanged
            dgvIngresos.CurrentCell = Nothing
            dgvEgresos.CurrentCell = Nothing

            If chkTodos.Checked Then
                For Each row As DataGridViewRow In dgvIngresos.Rows
                    If row.Cells("SALDO").Value = 0 And row.Visible Then
                        row.Visible = False
                    End If
                Next
                For Each row As DataGridViewRow In dgvEgresos.Rows
                    If row.Cells("SALDO").Value = 0 And row.Visible Then
                        row.Visible = False
                    End If
                Next
            Else

                ' mostrar segun nivel
                For Each row As DataGridViewRow In dgvIngresos.Rows
                    If cbNivel.SelectedIndex = 0 Then
                        row.Visible = True
                    Else
                        If Not row.Visible And row.Cells("NIVEL").Value <= cbNivel.SelectedIndex Then
                            row.Visible = True
                        End If
                    End If
                Next
                For Each row As DataGridViewRow In dgvEgresos.Rows
                    If cbNivel.SelectedIndex = 0 Then
                        row.Visible = True
                    Else
                        If Not row.Visible And row.Cells("NIVEL").Value <= cbNivel.SelectedIndex Then
                            row.Visible = True
                        End If
                    End If
                Next
            End If

            'CantidadReistros()
        End Sub

        Private Sub cbNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbNivel.SelectedIndexChanged
            FiltrarNiveles(cbNivel.SelectedIndex)
        End Sub

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        End Sub
    End Class
End Namespace