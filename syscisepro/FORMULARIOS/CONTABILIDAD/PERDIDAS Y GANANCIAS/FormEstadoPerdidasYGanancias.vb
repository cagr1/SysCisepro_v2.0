Imports ClassLibraryCisepro.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
Imports ClassLibraryCisepro.ENUMS 
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports Krypton.Toolkit
Imports ClosedXML.Excel
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit


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

        Private SelectedRange As Integer
        Private FechaDesde As Date
        Private FechaHasta As Date
        Private ShowColumns As Integer
        Private Anterior As Boolean
        Private CambioAnterior As Boolean
        Private PorcentajeAnterior As Boolean
        Private Previo As Boolean
        Private CambioPrevio As Boolean
        Private PorcentajePrevio As Boolean

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
                    Krypton.Toolkit.KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                ' Crear un nuevo libro de trabajo y una hoja
                Dim workbook = New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("BALANCE_PYG")

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Style.Font.FontSize = 10

                ' Título
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon).ToString() & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Style.Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                worksheet.Range("A1:" & ic & "1").Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                worksheet.Range("A1:" & ic & "1").Style.Font.FontColor = XLColor.White
                worksheet.Range("A1:" & ic & "1").Style.Font.FontSize = 12

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Style.Font.FontSize = 12

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Style.Font.FontSize = 12

                ' Encabezados de columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.Bold = True
                    worksheet.Cell(headin, indc).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                    worksheet.Cell(headin, indc).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    worksheet.Cell(headin, indc).Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))
                    worksheet.Cell(headin, indc).Style.Font.FontColor = XLColor.White
                    indc += 1
                Next

                ' Detalle de la tabla

                Dim columnasContable As String() = {"DEBE", "HABER", "SALDO"}
                Dim c = 0
                For o = 0 To dgvAsientosDiario.Rows.Count - 1
                    If Not dgvAsientosDiario.Rows(o).Visible Then Continue For
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        Dim cellValue = dgvAsientosDiario.Rows(o).Cells(j).Value
                        Dim cell = worksheet.Cell(c + 1 + headin, indc)
                        Dim columnName As String = dgvAsientosDiario.Columns(j).HeaderText

                        ' Aplicar formato según el tipo de columna
                        If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                            If columnasContable.Contains(columnName) Then
                                ' Formato contable para DEBE, HABER y SALDO
                                cell.Value = CDbl(cellValue)
                                cell.Style.NumberFormat.Format = "#,##0.00"
                            Else
                                ' Formato numérico estándar para otras columnas numéricas
                                cell.Value = CDbl(cellValue)
                            End If
                        Else
                            ' Formato de texto para valores no numéricos
                            cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                        End If

                        ' Aplicar bordes a la celda
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        ' Aplicar borde inferior solo en la última fila
                        If o = dgvAsientosDiario.Rows.Count - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If




                        indc += 1
                    Next
                    c += 1
                Next

                ' Bordes inferiores
                worksheet.Range("A" & (c + headin) & ":" & ic & indc).Style.Border.BottomBorder = XLBorderStyleValues.Thin

                ' Totales
                Dim deu As String = If(titulo.ToUpper().Contains("INGRESOS"), txtDeudorIngresos.Text, txtDeudorEgresos.Text)
                Dim ace As String = If(titulo.ToUpper().Contains("INGRESOS"), txtAcreedorIngresos.Text, txtAcreedorEgresos.Text)
                Dim tot As String = If(titulo.ToUpper().Contains("INGRESOS"), txtIngresos.Text, txtEgresos.Text)

                Dim foot = headin + c + 3
                worksheet.Cell(foot, 7).Value = "TOTAL DEUDOR"
                worksheet.Cell(foot, 7).Style.Font.Bold = True
                worksheet.Cell(foot, 8).Value = Convert.ToDecimal(deu)

                worksheet.Cell(foot + 1, 7).Value = "TOTAL ACREEDOR"
                worksheet.Cell(foot + 1, 7).Style.Font.Bold = True
                worksheet.Cell(foot + 1, 8).Value = Convert.ToDecimal(ace)

                worksheet.Cell(foot + 2, 7).Value = "TOTAL PYG"
                worksheet.Cell(foot + 2, 7).Style.Font.Bold = True
                worksheet.Cell(foot + 2, 8).Value = Convert.ToDecimal(tot)

                ' Ajustar columnas
                Dim range As IXLRange = worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50))
                worksheet.Columns("A:" & ic).AdjustToContents()

                ' Guardar el archivo
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
                saveFileDialog.FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    workbook.SaveAs(saveFileDialog.FileName)
                    Process.Start(saveFileDialog.FileName)
                End If

                Krypton.Toolkit.KryptonMessageBox.Show("Datos exportados correctamente!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch ex As Exception
                Krypton.Toolkit.KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try


        End Sub

        Private Sub ExportarDatosExcelDobleGrid(ByVal dgvIngresos As DataGridView, ByVal dgvEgresos As DataGridView, ByVal titulo As String)
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)



                Dim saveFileDialog As New SaveFileDialog With {
                        .Filter = "Excel Files|*.xlsx",
                        .Title = "Guardar Reporte",
                        .FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                    }

                If saveFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

                Using workbook As New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("BALANCE_PYG")
                    Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvIngresos)
                    Dim row As Integer = 1

                    ' Encabezado
                    worksheet.Range("A1:" & ic & "1").Merge().Value = ValidationForms.NombreCompany(_tipoCon).ToString() & " - " & titulo
                    worksheet.Range("A1:" & ic & "1").Style.Font.SetBold(True).Font.SetFontSize(12).Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))).Font.SetFontColor(XLColor.White)
                    worksheet.Range("A1:" & ic & "1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                    row += 1

                    ' Período
                    worksheet.Cell(row, 1).Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & " AL " & dtpFechaHasta.Value.ToLongDateString()
                    row += 1

                    ' Fecha de Reporte
                    worksheet.Cell(row, 1).Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                    row += 2

                    ' Exportar DataGridView Ingresos
                    row = ExportarDataGridView(worksheet, dgvIngresos, row, "TOTAL INGRESOS", txtDeudorIngresos.Text, txtAcreedorIngresos.Text, txtIngresos.Text)


                    ' Exportar DataGridView Egresos
                    row = ExportarDataGridView(worksheet, dgvEgresos, row, "TOTAL EGRESOS", txtDeudorEgresos.Text, txtAcreedorEgresos.Text, txtEgresos.Text)

                    ' Guardar el archivo en una ubicación temporal y abrirlo
                    Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), saveFileDialog.FileName)

                    ' Guardar Archivo
                    workbook.SaveAs(saveFileDialog.FileName)

                    ' Abrir Archivo
                    Process.Start(saveFileDialog.FileName)
                End Using

                Krypton.Toolkit.KryptonMessageBox.Show("Datos exportados correctamente!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch ex As Exception

                Krypton.Toolkit.KryptonMessageBox.Show("Hubo un problema al exportar datos! " & ex.Message.ToString(), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try 
        End Sub

        Private Function ExportarDataGridView(ByVal worksheet As IXLWorksheet, ByVal dgv As DataGridView, ByVal startRow As Integer, ByVal totalLabel As String, ByVal totalDebe As String, ByVal totalHaber As String, ByVal total As String) As Integer
            Dim colIndex As Integer = 1
            Dim columnasContables As String() = {"DEBE", "HABER", "SALDO"}
            ' Encabezado
            For Each column As DataGridViewColumn In dgv.Columns
                If column.Visible Then
                    worksheet.Cell(startRow, colIndex).Value = column.HeaderText
                    worksheet.Cell(startRow, colIndex).Style.Font.SetBold(True).Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(_tipoCon))).Font.SetFontColor(XLColor.White).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    colIndex += 1
                End If
            Next
            startRow += 1

            ' Datos
            For Each row As DataGridViewRow In dgv.Rows
                If row.Visible Then
                    colIndex = 1
                    For Each cell As DataGridViewCell In row.Cells
                        If dgv.Columns(cell.ColumnIndex).Visible Then
                            Dim valor As Object = cell.Value
                            Dim cellExcel = worksheet.Cell(startRow, colIndex)
                            Dim colName = dgv.Columns(cell.ColumnIndex).HeaderText

                            If columnasContables.Contains(colName) AndAlso IsNumeric(valor) Then
                                cellExcel.Value = Convert.ToDouble(valor)
                                cellExcel.Style.NumberFormat.Format = "#,##0.00"
                            ElseIf IsNumeric(valor) Then
                                cellExcel.Value = Convert.ToDouble(valor)
                            Else
                                cellExcel.Value = If(valor IsNot Nothing, valor.ToString(), "")
                            End If




                            colIndex += 1
                        End If
                    Next
                    startRow += 1
                End If
            Next

            ' Totales
            worksheet.Cell(startRow, 1).Value = totalLabel
            worksheet.Cell(startRow, 1).Style.Font.SetBold(True)
            worksheet.Cell(startRow, dgv.Columns("DEBE").Index + 1).Value = Convert.ToDecimal(totalDebe)
            worksheet.Cell(startRow, dgv.Columns("DEBE").Index + 1).Style.NumberFormat.Format = "#,##0.00"

            worksheet.Cell(startRow, dgv.Columns("HABER").Index + 1).Value = Convert.ToDecimal(totalHaber)
            worksheet.Cell(startRow, dgv.Columns("HABER").Index + 1).Style.NumberFormat.Format = "#,##0.00"

            worksheet.Cell(startRow, dgv.Columns("SALDO").Index + 1).Value = Convert.ToDecimal(total)
            worksheet.Cell(startRow, dgv.Columns("SALDO").Index + 1).Style.NumberFormat.Format = "#,##0.00"

            startRow += 1

            ' Ajustar columnas
            worksheet.Columns().AdjustToContents()

            Return startRow
        End Function



        Private Sub FormEstadoPerdidasYGanancias_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a

                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c

                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvEgresos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvIngresos.Font = New Font("Roboto", 8, FontStyle.Regular)
            Me.dgvIngresos.ContextMenuStrip = Me.ContextMenuStripClicDerecho
            Me.dgvEgresos.ContextMenuStrip = Me.ContextMenuStripClicDerechoEgresos
            cbNivel.SelectedIndex = 0

            'make dtpFechaDesdeCom a year ago

            Me.MaximumSize = MdiParent.ClientSize
            btnCargar.Padding = New Padding(5)


            dtpFechaDesdeMes.Value = New Date(Now.Year, Now.Month, 1)


            Dim ctxMenu As ComponentFactory.Krypton.Toolkit.KryptonContextMenu = btnExcel.KryptonContextMenu

            If ctxMenu IsNot Nothing Then
                AsignarEventosMenu(ctxMenu.Items)
            End If

        End Sub

        Private Sub btnBuscarMensual_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            dgvEgresos.DataSource = Nothing
            dgvIngresos.DataSource = Nothing

            CargaIngresosMensual(True)
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

            CargarEgresosMensual(True)
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

        Private Sub btnExportarIngresos_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            ExportarDatosExcel(dgvIngresos, "INGRESOS")
        End Sub

        Private Sub btnExportarEgresos_Click(ByVal sender As System.Object, ByVal e As EventArgs)
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
                'MsgBox(ex.Message.ToString)
                Krypton.Toolkit.KryptonMessageBox.Show("ERROR: " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
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
                'MsgBox(ex.Message.ToString)
                Krypton.Toolkit.KryptonMessageBox.Show("ERROR: " & ex.Message, "ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            If dgvIngresos.Rows.Count = 0 Then
                Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If dgvIngresos.Rows.Count = 0 Then
                Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If


            ExportarDatosExcelDobleGrid(dgvIngresos, dgvEgresos, "ESTADO DE PERDIDAS Y GANANCIAS")
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs)

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

        Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

        End Sub

        Private Sub dtpFechaDesdeMes_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesdeMes.ValueChanged


            UpdateCbxDates()

        End Sub



        Private Sub chbxMensual_CheckedChanged(sender As Object, e As EventArgs)


        End Sub

        Private Sub chkbxAnual_CheckedChanged(sender As Object, e As EventArgs)


        End Sub

        Private Sub CargaIngresosMensualComparativo(ByVal mes1 As Integer, ByVal anio1 As Integer, ByVal mes2 As Integer, ByVal anio2 As Integer)

            dgvComparacion.DataSource = Nothing

        End Sub

        Private Sub KryptonRibbon1_SelectedTabChanged(sender As Object, e As EventArgs)

        End Sub


        Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
            dgvEgresos.DataSource = Nothing
            dgvIngresos.DataSource = Nothing

            CargaIngresosMensual(True)
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

            CargarEgresosMensual(True)
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

        Private Sub btnReporteNew_Click(sender As Object, e As EventArgs) Handles btnReporteNew.Click
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

        Private Sub kmcExcelMenu_Item_Click(sender As Object, e As EventArgs)
            Dim item As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem = TryCast(sender, ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem)



            Select Case item.Text
                Case "General"
                    If dgvIngresos.Rows.Count = 0 Then
                        Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If

                    If dgvIngresos.Rows.Count = 0 Then
                        Krypton.Toolkit.KryptonMessageBox.Show("Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                    End If

                    ExportarDatosExcelDobleGrid(dgvIngresos, dgvEgresos, "ESTADO_PyG")
                Case "Ingresos"

                    ExportarDatosExcel(dgvIngresos, "PyG_INGRESOS")

                Case "Egresos"

                    ExportarDatosExcel(dgvEgresos, "PyG_EGRESOS")

            End Select

        End Sub

        Private Sub AsignarEventosMenu(ByVal items As IEnumerable)
            For Each obj In items
                ' Intentamos convertir el objeto a KryptonContextMenuItem
                Dim menuItem As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem = TryCast(obj, ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem)
                If menuItem IsNot Nothing Then
                    ' Asignamos el evento Click
                    AddHandler menuItem.Click, AddressOf kmcExcelMenu_Item_Click
                Else
                    ' En algunos casos, el objeto puede ser una colección (por ejemplo, KryptonContextMenuItems)
                    Dim subItems As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems = TryCast(obj, ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems)
                    If subItems IsNot Nothing Then
                        ' Recorremos recursivamente los items de la colección
                        AsignarEventosMenu(subItems.Items)
                    End If
                End If
            Next
        End Sub

        Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        End Sub

        Private Sub btnCuztomize_Click(sender As Object, e As EventArgs) Handles btnCuztomize.Click
            Dim frm As New FormReportEstadoPyG()

            frm.SelectedRange = cbxDates.SelectedIndex
            frm.FechaDesde = dtpFechaDesdeMes.Value
            frm.FechaHasta = dtpFechaHastaMes.Value
            frm.ShowColumns = cbxShowColumns.SelectedIndex
            frm.Anterior = Anterior
            frm.CambioAnterior = CambioAnterior
            frm.PorcentajeAnterior = PorcentajeAnterior
            frm.Previo = Previo
            frm.CambioPrevio = CambioPrevio
            frm.PorcentajePrevio = PorcentajePrevio

            If frm.ShowDialog() = DialogResult.OK Then
                SelectedRange = frm.SelectedRange
                FechaDesde = frm.FechaDesde
                FechaHasta = frm.FechaHasta
                ShowColumns = frm.ShowColumns
                Anterior = frm.Anterior
                CambioAnterior = frm.CambioAnterior
                PorcentajeAnterior = frm.PorcentajeAnterior
                Previo = frm.Previo
                CambioPrevio = frm.CambioPrevio
                PorcentajePrevio = frm.PorcentajePrevio

                cbxDates.SelectedIndex = SelectedRange
                dtpFechaDesdeMes.Value = FechaDesde
                dtpFechaHastaMes.Value = FechaHasta
                cbxShowColumns.SelectedIndex = ShowColumns

            End If



        End Sub

        Private Sub cbxDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDates.SelectedIndexChanged
            Dim selectedRange As String = cbxDates.SelectedItem.ToString()

            Select Case selectedRange.Trim()
                Case "Mensual"
                    ' Desde el primer día del mes actual
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1)
                    dtpFechaHastaMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, Date.DaysInMonth(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month))

                Case "Trimestral"
                    ' Desde el primer día del mes, restando 2 meses (para cubrir 3 meses en total)
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-2)

                Case "Semestral"
                    ' Desde el primer día del mes, restando 5 meses (para cubrir 6 meses en total)
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year, dtpFechaHastaMes.Value.Month, 1).AddMonths(-5)

                Case "Anual"
                    ' Desde el primer día del mes, restando 1 año
                    dtpFechaDesdeMes.Value = New Date(dtpFechaHastaMes.Value.Year - 1, dtpFechaHastaMes.Value.Month, dtpFechaHastaMes.Value.Day)


                Case "Custom"
                    ' No hacer cambios en las fechas, el usuario las define manualmente
            End Select

            ' Actualizar cbxShowColumns
            UpdateCbxShowColumns()

            callReport()

        End Sub

        Private Sub UpdateCbxShowColumns()
            Dim fechaDesde As Date = dtpFechaDesdeMes.Value
            Dim fechaHasta As Date = dtpFechaHastaMes.Value
            Dim rangeInMonths As Integer = (fechaHasta.Year - fechaDesde.Year) * 12 + (fechaHasta.Month - fechaDesde.Month)



            ' Siempre permitir "Mensual"
            cbxShowColumns.SelectedItem = 0

            ' Permitir "Trimestral" si el rango es de al menos 3 meses
            If rangeInMonths >= 3 Then
                cbxShowColumns.SelectedItem = 1
            End If

            ' Permitir "Semestral" si el rango es de al menos 6 meses
            If rangeInMonths >= 6 Then
                cbxShowColumns.SelectedItem = 2
            End If

            ' Permitir "Anual" si el rango es de al menos 12 meses
            If rangeInMonths >= 12 Then
                cbxShowColumns.SelectedItem = 3
            End If

            ' Seleccionar la primera opción por defecto
            If cbxShowColumns.Items.Count > 0 Then
                cbxShowColumns.SelectedIndex = 0
            End If
        End Sub

        Private Sub callReport()

            Dim rangoBusqueda As String = cbxDates.SelectedItem.ToString()
            Dim ordenColumnas As String = cbxShowColumns.SelectedItem.ToString()
            Dim fechaInicio As DateTime = dtpFechaDesdeMes.Value
            Dim fechaFin As DateTime = dtpFechaHastaMes.Value




        End Sub

        Private Sub UpdateCbxDates()
            Dim fechaDesde As Date = dtpFechaDesdeMes.Value
            Dim fechaHasta As Date = dtpFechaHastaMes.Value

            RemoveHandler cbxDates.SelectedIndexChanged, AddressOf cbxDates_SelectedIndexChanged

            'Verificar si el rango de fechas coincide con un periodo estandar
            If IsMonthlyRange(fechaDesde, fechaHasta) Then
                cbxDates.SelectedIndex = 0
            ElseIf IsQuarterlyRange(fechaDesde, fechaHasta) Then
                cbxDates.SelectedIndex = 1
            ElseIf IsSemestralRange(fechaDesde, fechaHasta) Then
                cbxDates.SelectedIndex = 3
            ElseIf IsAnnualRange(fechaDesde, fechaHasta) Then
                cbxDates.SelectedIndex = 4
            Else
                cbxDates.SelectedIndex = 5
            End If

            AddHandler cbxDates.SelectedIndexChanged, AddressOf cbxDates_SelectedIndexChanged

        End Sub

        Private Function IsMonthlyRange(ByVal fechadesde As Date, ByVal fechashasta As Date) As Boolean
            Return fechadesde.Day = 1 AndAlso fechashasta = fechadesde.AddMonths(1).AddDays(-1)
        End Function

        Private Function IsQuarterlyRange(fechaDesde As Date, fechaHasta As Date) As Boolean
            Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddMonths(3).AddDays(-1)
        End Function

        Private Function IsSemestralRange(fechaDesde As Date, fechaHasta As Date) As Boolean
            Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddMonths(6).AddDays(-1)
        End Function

        Private Function IsAnnualRange(fechaDesde As Date, fechaHasta As Date) As Boolean
            Return fechaDesde.Day = 1 AndAlso fechaHasta = fechaDesde.AddYears(1).AddDays(-1)
        End Function





    End Class
End Namespace